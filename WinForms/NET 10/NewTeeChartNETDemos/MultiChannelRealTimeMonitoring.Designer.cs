namespace NewTeeChartNETDemos
{
    partial class MultiChannelRealTimeMonitoring
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MultiChannelRealTimeMonitoring));
            this.tChart1 = new Steema.TeeChart.TChart();
            this.panelControls = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblFPS = new System.Windows.Forms.Label();
            this.panelControls.SuspendLayout();
            this.SuspendLayout();

            // tChart1
            this.tChart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tChart1.Location = new System.Drawing.Point(0, 50);
            this.tChart1.Name = "tChart1";
            this.tChart1.Size = new System.Drawing.Size(1200, 750);
            this.tChart1.TabIndex = 0;

            // panelControls
            this.panelControls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panelControls.Controls.Add(this.btnReset);
            this.panelControls.Controls.Add(this.lblFPS);
            this.panelControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControls.Location = new System.Drawing.Point(0, 0);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(1200, 50);
            this.panelControls.TabIndex = 1;

            // btnReset
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(65)))));
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(10, 10);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 30);
            this.btnReset.TabIndex = 0;
            this.btnReset.Text = "Reset View";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);

            // lblFPS
            this.lblFPS.AutoSize = true;
            this.lblFPS.ForeColor = System.Drawing.Color.White;
            this.lblFPS.Location = new System.Drawing.Point(1000, 15);
            this.lblFPS.Name = "lblFPS";
            this.lblFPS.Size = new System.Drawing.Size(42, 15);
            this.lblFPS.TabIndex = 1;
            this.lblFPS.Text = "FPS: 0";

            // MultiChannelRealTimeMonitoring
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.tChart1);
            this.Controls.Add(this.panelControls);
            this.Name = "MultiChannelRealTimeMonitoring";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Multi-channel Real-Time Data Monitoring";
            this.Load += new System.EventHandler(this.MultiChannelRealTimeMonitoring_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MultiChannelRealTimeMonitoring_FormClosing);
            this.panelControls.ResumeLayout(false);
            this.panelControls.PerformLayout();
            this.ResumeLayout(false);
        }

        private Steema.TeeChart.TChart tChart1;
        private System.Windows.Forms.Panel panelControls;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblFPS;
    }
}
