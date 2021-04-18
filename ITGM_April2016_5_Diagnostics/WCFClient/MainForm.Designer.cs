namespace WCFClient
{
  partial class MainForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.getStateButton = new System.Windows.Forms.Button();
      this.stateTextBox = new System.Windows.Forms.TextBox();
      this.stoppedRadioButton = new System.Windows.Forms.RadioButton();
      this.setStateGroupBox = new System.Windows.Forms.GroupBox();
      this.setButton = new System.Windows.Forms.Button();
      this.runningRadioButton = new System.Windows.Forms.RadioButton();
      this.setStateGroupBox.SuspendLayout();
      this.SuspendLayout();
      // 
      // getStateButton
      // 
      this.getStateButton.Location = new System.Drawing.Point(13, 13);
      this.getStateButton.Name = "getStateButton";
      this.getStateButton.Size = new System.Drawing.Size(75, 23);
      this.getStateButton.TabIndex = 0;
      this.getStateButton.Text = "Get state";
      this.getStateButton.UseVisualStyleBackColor = true;
      this.getStateButton.Click += new System.EventHandler(this.getStateButton_Click);
      // 
      // stateTextBox
      // 
      this.stateTextBox.Location = new System.Drawing.Point(13, 148);
      this.stateTextBox.Multiline = true;
      this.stateTextBox.Name = "stateTextBox";
      this.stateTextBox.ReadOnly = true;
      this.stateTextBox.Size = new System.Drawing.Size(408, 206);
      this.stateTextBox.TabIndex = 1;
      // 
      // stoppedRadioButton
      // 
      this.stoppedRadioButton.AutoSize = true;
      this.stoppedRadioButton.Location = new System.Drawing.Point(6, 19);
      this.stoppedRadioButton.Name = "stoppedRadioButton";
      this.stoppedRadioButton.Size = new System.Drawing.Size(65, 17);
      this.stoppedRadioButton.TabIndex = 2;
      this.stoppedRadioButton.TabStop = true;
      this.stoppedRadioButton.Text = "Stopped";
      this.stoppedRadioButton.UseVisualStyleBackColor = true;
      // 
      // setStateGroupBox
      // 
      this.setStateGroupBox.Controls.Add(this.setButton);
      this.setStateGroupBox.Controls.Add(this.runningRadioButton);
      this.setStateGroupBox.Controls.Add(this.stoppedRadioButton);
      this.setStateGroupBox.Location = new System.Drawing.Point(13, 42);
      this.setStateGroupBox.Name = "setStateGroupBox";
      this.setStateGroupBox.Size = new System.Drawing.Size(200, 100);
      this.setStateGroupBox.TabIndex = 3;
      this.setStateGroupBox.TabStop = false;
      this.setStateGroupBox.Text = "Set state";
      // 
      // setButton
      // 
      this.setButton.Location = new System.Drawing.Point(119, 71);
      this.setButton.Name = "setButton";
      this.setButton.Size = new System.Drawing.Size(75, 23);
      this.setButton.TabIndex = 4;
      this.setButton.Text = "Set state";
      this.setButton.UseVisualStyleBackColor = true;
      this.setButton.Click += new System.EventHandler(this.setButton_Click);
      // 
      // runningRadioButton
      // 
      this.runningRadioButton.AutoSize = true;
      this.runningRadioButton.Location = new System.Drawing.Point(7, 43);
      this.runningRadioButton.Name = "runningRadioButton";
      this.runningRadioButton.Size = new System.Drawing.Size(65, 17);
      this.runningRadioButton.TabIndex = 3;
      this.runningRadioButton.TabStop = true;
      this.runningRadioButton.Text = "Running";
      this.runningRadioButton.UseVisualStyleBackColor = true;
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(433, 366);
      this.Controls.Add(this.stateTextBox);
      this.Controls.Add(this.getStateButton);
      this.Controls.Add(this.setStateGroupBox);
      this.Name = "MainForm";
      this.Text = "WCF Client";
      this.setStateGroupBox.ResumeLayout(false);
      this.setStateGroupBox.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button getStateButton;
    private System.Windows.Forms.TextBox stateTextBox;
    private System.Windows.Forms.RadioButton stoppedRadioButton;
    private System.Windows.Forms.GroupBox setStateGroupBox;
    private System.Windows.Forms.Button setButton;
    private System.Windows.Forms.RadioButton runningRadioButton;
  }
}

