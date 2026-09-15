namespace NewTeeChartNETDemos
{
    partial class GaugeChartDashboard
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
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.gaugesPanelContainer = new System.Windows.Forms.Panel();
            this.tChartXY = new Steema.TeeChart.TChart();
            this.panelControls = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.panelControls.SuspendLayout();
            this.SuspendLayout();

            // splitContainerMain
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 50);
            this.splitContainerMain.Name = "splitContainerMain";
            this.splitContainerMain.Orientation = System.Windows.Forms.Orientation.Vertical;

            // Panel1: Gauges (left side - narrow)
            this.splitContainerMain.Panel1.AutoScroll = true;
            this.splitContainerMain.Panel1.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
            this.splitContainerMain.Panel1.Controls.Add(this.gaugesPanelContainer);
            this.splitContainerMain.Panel1.Name = "Panel1";

            // Panel2: XY Chart (right side - wide)
            this.splitContainerMain.Panel2.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
            this.splitContainerMain.Panel2.Controls.Add(this.tChartXY);
            this.splitContainerMain.Panel2.Name = "Panel2";

            this.splitContainerMain.SplitterDistance = 50;
            this.splitContainerMain.Size = new System.Drawing.Size(1200, 750);
            this.splitContainerMain.TabIndex = 0;

            // gaugesPanelContainer
            this.gaugesPanelContainer.AutoSize = false;
            this.gaugesPanelContainer.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
            this.gaugesPanelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gaugesPanelContainer.Location = new System.Drawing.Point(0, 0);
            this.gaugesPanelContainer.Name = "gaugesPanelContainer";
            this.gaugesPanelContainer.Size = new System.Drawing.Size(150, 750);
            this.gaugesPanelContainer.TabIndex = 0;

            // tChartXY
            this.tChartXY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tChartXY.Location = new System.Drawing.Point(0, 0);
            this.tChartXY.Name = "tChartXY";
            this.tChartXY.Size = new System.Drawing.Size(960, 750);
            this.tChartXY.TabIndex = 1;

            // panelControls
            this.panelControls.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
            this.panelControls.Controls.Add(this.btnReset);
            this.panelControls.Controls.Add(this.lblStatus);
            this.panelControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControls.Location = new System.Drawing.Point(0, 0);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(1200, 50);
            this.panelControls.TabIndex = 1;

            // btnReset
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(60, 60, 65);
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(10, 10);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 30);
            this.btnReset.TabIndex = 0;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);

            // lblStatus
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(120, 15);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(82, 15);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Real-time data";

            // GaugeChartDashboard
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.splitContainerMain);
            this.Controls.Add(this.panelControls);
            this.Name = "GaugeChartDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gauge Chart Dashboard";
            this.Load += new System.EventHandler(this.GaugeChartDashboard_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GaugeChartDashboard_FormClosing);
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.panelControls.ResumeLayout(false);
            this.panelControls.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.Panel gaugesPanelContainer;
        private Steema.TeeChart.TChart tChartXY;
        private System.Windows.Forms.Panel panelControls;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblStatus;
    }
}
