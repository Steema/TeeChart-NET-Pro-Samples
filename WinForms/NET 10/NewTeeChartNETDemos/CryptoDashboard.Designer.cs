namespace NewTeeChartNETDemos
{
    partial class CryptoDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CryptoDashboard));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridViewCryptos = new System.Windows.Forms.DataGridView();
            this.tChart1 = new Steema.TeeChart.TChart();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCryptos)).BeginInit();
            this.SuspendLayout();

            // splitContainer1
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.splitContainer1.Size = new System.Drawing.Size(1200, 800);
            this.splitContainer1.SplitterDistance = 400;
            this.splitContainer1.TabIndex = 0;

            // Panel1 - DataGrid
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.splitContainer1.Panel1.Controls.Add(this.dataGridViewCryptos);

            // Panel2 - Chart
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.splitContainer1.Panel2.Controls.Add(this.tChart1);

            // dataGridViewCryptos
            this.dataGridViewCryptos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.dataGridViewCryptos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewCryptos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCryptos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCryptos.ForeColor = System.Drawing.Color.White;
            this.dataGridViewCryptos.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewCryptos.Name = "dataGridViewCryptos";
            this.dataGridViewCryptos.RowHeadersVisible = false;
            this.dataGridViewCryptos.RowTemplate.Height = 25;
            this.dataGridViewCryptos.Size = new System.Drawing.Size(1200, 400);
            this.dataGridViewCryptos.TabIndex = 0;
            this.dataGridViewCryptos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewCryptos_CellClick);
            this.dataGridViewCryptos.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewCryptos_CellMouseEnter);
            this.dataGridViewCryptos.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewCryptos_CellMouseLeave);

            // tChart1
            this.tChart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tChart1.Location = new System.Drawing.Point(0, 0);
            this.tChart1.Name = "tChart1";
            this.tChart1.Size = new System.Drawing.Size(1200, 396);
            this.tChart1.TabIndex = 0;

            // CryptoDashboard
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.splitContainer1);
            this.Name = "CryptoDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crypto Dashboard";
            this.Load += new System.EventHandler(this.CryptoDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCryptos)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridViewCryptos;
        private Steema.TeeChart.TChart tChart1;
    }
}
