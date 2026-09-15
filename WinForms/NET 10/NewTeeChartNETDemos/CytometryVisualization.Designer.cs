namespace NewTeeChartNETDemos
{
    partial class CytometryVisualization
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
            this.tChart1 = new Steema.TeeChart.TChart();
            this.SuspendLayout();
            // 
            // tChart1
            // 
            this.tChart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tChart1.Location = new System.Drawing.Point(0, 0);
            this.tChart1.Name = "tChart1";
            this.tChart1.Size = new System.Drawing.Size(1200, 800);
            this.tChart1.TabIndex = 0;
            // 
            // CytometryVisualization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.tChart1);
            this.Name = "CytometryVisualization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cytometry Visualization";
            this.Load += new System.EventHandler(this.CytometryVisualization_Load);
            this.ResumeLayout(false);
        }

        private Steema.TeeChart.TChart tChart1;
    }
}
