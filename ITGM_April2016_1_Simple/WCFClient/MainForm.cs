using System;
using System.ServiceModel;
using System.Text;
using System.Windows.Forms;
using WCFContract;

namespace WCFClient
{
  public partial class MainForm : Form
  {
    private readonly ChannelFactory<IService> cf;
    
    public MainForm()
    {
      InitializeComponent();
      cf = new ChannelFactory<IService>("ServiceEndpoint");
    }

    private void getStateButton_Click(object sender, EventArgs e)
    {
      IService proxy = cf.CreateChannel();

      ExecuteWithExceptionHandling(
        () =>
        {
          ServerState state = proxy.GetServerState();

          stateTextBox.Text = state.ToString();
          runningRadioButton.Checked = state.State == State.Running;
          stoppedRadioButton.Checked = state.State == State.Stopped;
        });
    }

    private void setButton_Click(object sender, EventArgs e)
    {
      ExecuteWithExceptionHandling(
        () =>
        {
          IService proxy = cf.CreateChannel();
          proxy.SetServerState(runningRadioButton.Checked ? State.Running : State.Stopped);
        },
        "Done");
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
  }
}
