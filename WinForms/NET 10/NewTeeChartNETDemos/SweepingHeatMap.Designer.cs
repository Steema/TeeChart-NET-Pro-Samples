namespace NewTeeChartNETDemos
{
    partial class SweepingHeatMap
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
            tChart1 = new Steema.TeeChart.TChart();
            SuspendLayout();
            // 
            // tChart1
            // 
            tChart1.Dock = DockStyle.Fill;
            // 
            // 
            // 
            tChart1.Legend.CheckBoxes = false;
            tChart1.Legend.ClipText = false;
            tChart1.Location = new Point(0, 0);
            tChart1.Name = "tChart1";
            tChart1.Size = new Size(1190, 665);
            tChart1.TabIndex = 0;
            tChart1.Text = "tChart1";
            tChart1.DoubleClick += tChart1_DoubleClick;
            // 
            // SweepingHeatMap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1190, 665);
            Controls.Add(tChart1);
            Name = "SweepingHeatMap";
            Text = "SweepingHeatMap";
            Load += SweepingHeatMap_Load;
            ResumeLayout(false);
        }

        #endregion

        private Steema.TeeChart.TChart tChart1;
    }
}
