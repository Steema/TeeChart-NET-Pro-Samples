namespace WinformRealtime
{
  partial class EntryForm
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
      groupBox1 = new GroupBox();
      button2 = new Button();
      button1 = new Button();
      groupBox1.SuspendLayout();
      SuspendLayout();
      // 
      // groupBox1
      // 
      groupBox1.Controls.Add(button2);
      groupBox1.Controls.Add(button1);
      groupBox1.Dock = DockStyle.Fill;
      groupBox1.Location = new Point(0, 0);
      groupBox1.Name = "groupBox1";
      groupBox1.Size = new Size(458, 298);
      groupBox1.TabIndex = 0;
      groupBox1.TabStop = false;
      groupBox1.Text = "Chart menu";
      // 
      // button2
      // 
      button2.Location = new Point(121, 134);
      button2.Name = "button2";
      button2.Size = new Size(216, 78);
      button2.TabIndex = 1;
      button2.Text = "Multi-Panel demo";
      button2.UseVisualStyleBackColor = true;
      button2.Click += button2_Click;
      // 
      // button1
      // 
      button1.Location = new Point(121, 50);
      button1.Name = "button1";
      button1.Size = new Size(216, 78);
      button1.TabIndex = 0;
      button1.Text = "Multi-Axis demo";
      button1.UseVisualStyleBackColor = true;
      button1.Click += button1_Click;
      // 
      // EntryForm
      // 
      AutoScaleDimensions = new SizeF(7F, 17F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(458, 298);
      Controls.Add(groupBox1);
      MaximizeBox = false;
      Name = "EntryForm";
      StartPosition = FormStartPosition.CenterScreen;
      Text = "TeeChart Complex Charts";
      groupBox1.ResumeLayout(false);
      ResumeLayout(false);
    }

    #endregion

    private GroupBox groupBox1;
    private Button button2;
    private Button button1;
  }
}