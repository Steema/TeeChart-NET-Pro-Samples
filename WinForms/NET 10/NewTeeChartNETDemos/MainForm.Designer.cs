namespace NewTeeChartNETDemos
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listBoxDemos = new System.Windows.Forms.ListBox();
            this.labelDemos = new System.Windows.Forms.Label();
            this.panelDemo = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();

            // splitContainer1
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Size = new System.Drawing.Size(1400, 800);
            this.splitContainer1.SplitterDistance = 250;
            this.splitContainer1.TabIndex = 0;

            // Panel1 (Left - Demo List)
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.splitContainer1.Panel1.Controls.Add(this.listBoxDemos);
            this.splitContainer1.Panel1.Controls.Add(this.labelDemos);
            this.splitContainer1.Panel1.ForeColor = System.Drawing.Color.White;

            // Panel2 (Right - Demo Display)
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.splitContainer1.Panel2.Controls.Add(this.panelDemo);

            // labelDemos
            this.labelDemos.AutoSize = true;
            this.labelDemos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.labelDemos.ForeColor = System.Drawing.Color.White;
            this.labelDemos.Location = new System.Drawing.Point(10, 10);
            this.labelDemos.Name = "labelDemos";
            this.labelDemos.Size = new System.Drawing.Size(125, 21);
            this.labelDemos.TabIndex = 1;
            this.labelDemos.Text = "Demostraciones";

            // listBoxDemos
            this.listBoxDemos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(65)))));
            this.listBoxDemos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxDemos.ForeColor = System.Drawing.Color.White;
            this.listBoxDemos.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.listBoxDemos.FormattingEnabled = true;
            this.listBoxDemos.ItemHeight = 19;
            this.listBoxDemos.Location = new System.Drawing.Point(10, 40);
            this.listBoxDemos.Name = "listBoxDemos";
            this.listBoxDemos.Size = new System.Drawing.Size(230, 745);
            this.listBoxDemos.TabIndex = 0;
            this.listBoxDemos.SelectedIndexChanged += new System.EventHandler(this.ListBoxDemos_SelectedIndexChanged);

            // panelDemo
            this.panelDemo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDemo.Location = new System.Drawing.Point(0, 0);
            this.panelDemo.Name = "panelDemo";
            this.panelDemo.Size = new System.Drawing.Size(1146, 800);
            this.panelDemo.TabIndex = 0;

            // MainForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1400, 800);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TeeChart Demos - Navigator";
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox listBoxDemos;
        private System.Windows.Forms.Label labelDemos;
        private System.Windows.Forms.Panel panelDemo;
    }
}
