using System;
using System.Text;
using System.Windows.Forms;
using WCFContract;

namespace WCFClient
{
  public partial class MainForm : Form
  {
    public MainForm()
    {
      InitializeComponent();
    }

    private void getStateButton_Click(object sender, EventArgs e)
    {
      ExecuteWithExceptionHandling(() =>
      {
        long totalSent = 0;
        for (int size = 4096; size <= 512 * 1024; size *= 2)
        {
          for (int i = 0; i < 20; i++)
          {
            var proxy = new ServiceProxy(CredentialStorage.UserName);
            {
              byte[] largeBuffer = new byte[size];
              proxy.SendLargeBuffer(largeBuffer);
              ServerState state = proxy.GetServerState();

              totalSent += size;
              stateTextBox.Text = state.ToString();
              runningRadioButton.Checked = state.State == State.Running;
              stoppedRadioButton.Checked = state.State == State.Stopped;
            }
          }
        }
        stateTextBox.Text += Environment.NewLine + "Total bytes sent: " + totalSent;
      });
    }

    private void setButton_Click(object sender, EventArgs e)
    {
      ExecuteWithExceptionHandling(() =>
      {
        using (var proxy = new ServiceProxy(CredentialStorage.UserName))
        {
          proxy.SetServerState(
            runningRadioButton.Checked ? State.Running : State.Stopped);
        }
      });
    }


    private void ExecuteWithExceptionHandling(
      Action x,
      string onSuccess = null)
    {
      try
      {
        // Force empty text box
        stateTextBox.Text = string.Empty;
        Invalidate();

        x.Invoke();

        // Set final status
        if (onSuccess != null)
        {
          stateTextBox.Text = onSuccess;
        }
      }
      catch (Exception exception)
      {
        StringBuilder sb = new StringBuilder();
        while (exception.InnerException != null)
        {
          sb.AppendFormat("{0}:{1}", exception.GetType().Name, Environment.NewLine);
          exception = exception.InnerException;
        }
        sb.AppendLine("Message:");
        sb.AppendLine(exception.Message);
        stateTextBox.Text = sb.ToString();
      }
    }

    private void validUserCheckBox_CheckedChanged(object sender, EventArgs e)
    {
      if (validUserCheckBox.Checked)
      {
        CredentialStorage.UserName = "validUser";
      }
      else
      {
        CredentialStorage.UserName = "invalidUser";
      }
    }

  }
}
