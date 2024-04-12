using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;


namespace Steema.TeeChart.Samples
{
    public class SeriesType_Line : Samples.BaseForm
    {
        private Steema.TeeChart.Styles.Line lineSeries1;
        private Steema.TeeChart.Styles.Line lineSeries2;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private CheckBox checkBox5;
        private Button button1;
        private Steema.TeeChart.Tools.GridBand gridBand1;
        private IContainer components = null;

        public SeriesType_Line()
        {
            // This call is required by the Windows Form Designer.
            InitializeComponent();
            lineSeries1.FillSampleValues(20);
            lineSeries2.FillSampleValues(20);
            tChart1.Aspect.View3D = true;
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(SeriesType_Line));
            Drawing.Cursor cursor2 = new Drawing.Cursor();
            lineSeries1 = new Styles.Line();
            lineSeries2 = new Styles.Line();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox5 = new CheckBox();
            button1 = new Button();
            gridBand1 = new Tools.GridBand();
            panel1.SuspendLayout();
            chartContainer.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Size = new Size(466, 78);
            textBox1.Text = "Line series displays points drawing one line from each point to the next.\r\nOption" +
                "s include 2D and 3D, \"stairs\" mode, null points, pointers, border, filling patte" +
                "rn, height 3D, stacking, overlaping, clicking, dark 3D and marks.";
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(checkBox5);
            panel1.Controls.Add(checkBox4);
            panel1.Controls.Add(checkBox3);
            panel1.Controls.Add(checkBox2);
            panel1.Controls.Add(checkBox1);
            panel1.Location = new Point(0, 78);
            panel1.Size = new Size(466, 50);
            // 
            // tChart1
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Header.Font.Size = 14;
            tChart1.Header.Font.SizeFloat = 14F;
            tChart1.Header.Lines = new string[] { "Line Series example" };
            // 
            // 
            // 
            tChart1.Legend.CheckBoxes = false;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Panel.Brush.Color = Color.FromArgb(254, 255, 255, 255);
            tChart1.Series.Add(lineSeries1);
            tChart1.Series.Add(lineSeries2);
            tChart1.Size = new Size(466, 158);
            tChart1.Tools.Add(gridBand1);
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Walls.Bottom.Pen.Visible = false;
            tChart1.Walls.Bottom.Size = 5;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Walls.Left.Pen.Visible = false;
            tChart1.Walls.Left.Size = 5;
            // 
            // chartContainer
            // 
            chartContainer.Location = new Point(0, 128);
            chartContainer.Size = new Size(466, 158);
            // 
            // lineSeries1
            // 
            lineSeries1.Color = Color.FromArgb(119, 153, 214);
            lineSeries1.Cursor = cursor2;
            lineSeries1.Title = "line2";
            // 
            // 
            // 
            lineSeries1.XValues.DataMember = "X";
            lineSeries1.XValues.Order = Styles.ValueListOrder.Ascending;
            lineSeries1.XValues.Value = new double[] { 0D, 1D, 2D, 3D, 4D, 5D, 6D, 7D, 8D, 9D, 10D, 11D, 12D, 13D, 14D, 15D, 16D, 17D, 18D, 19D, 20D, 21D, 22D, 23D, 24D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D };
            // 
            // 
            // 
            lineSeries1.YValues.DataMember = "Y";
            lineSeries1.YValues.Value = new double[] { 549D, 609D, 496D, 501D, 536D, 422D, 315D, 268D, 344D, 460D, 444D, 430D, 424D, 430D, 307D, 283D, 284D, 336D, 406D, 301D, 416D, 297D, 358D, 307D, 352D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D };
            // 
            // lineSeries2
            // 
            lineSeries2.Color = Color.FromArgb(255, 207, 104);
            lineSeries2.Cursor = cursor2;
            lineSeries2.Title = "line2";
            // 
            // 
            // 
            lineSeries2.XValues.DataMember = "X";
            lineSeries2.XValues.Order = Styles.ValueListOrder.Ascending;
            lineSeries2.XValues.Value = new double[] { 0D, 1D, 2D, 3D, 4D, 5D, 6D, 7D, 8D, 9D, 10D, 11D, 12D, 13D, 14D, 15D, 16D, 17D, 18D, 19D, 20D, 21D, 22D, 23D, 24D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D };
            // 
            // 
            // 
            lineSeries2.YValues.DataMember = "Y";
            lineSeries2.YValues.Value = new double[] { 615D, 649D, 644D, 607D, 606D, 647D, 628D, 622D, 586D, 544D, 525D, 546D, 506D, 547D, 528D, 499D, 505D, 503D, 521D, 544D, 541D, 509D, 493D, 470D, 507D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D };
            // 
            // checkBox1
            // 
            checkBox1.FlatStyle = FlatStyle.Flat;
            checkBox1.Location = new Point(24, 11);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(72, 26);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "&Stairs";
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.FlatStyle = FlatStyle.Flat;
            checkBox2.Location = new Point(96, 11);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(80, 26);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "&Pointers";
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBox3
            // 
            checkBox3.FlatStyle = FlatStyle.Flat;
            checkBox3.Location = new Point(184, 11);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(64, 26);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "&Marks";
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // checkBox4
            // 
            checkBox4.FlatStyle = FlatStyle.Flat;
            checkBox4.Location = new Point(256, 11);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(80, 26);
            checkBox4.TabIndex = 3;
            checkBox4.Text = "S&tacked";
            checkBox4.CheckedChanged += checkBox4_CheckedChanged;
            // 
            // checkBox5
            // 
            checkBox5.Checked = true;
            checkBox5.CheckState = CheckState.Checked;
            checkBox5.FlatStyle = FlatStyle.Flat;
            checkBox5.Location = new Point(336, 11);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(48, 26);
            checkBox5.TabIndex = 4;
            checkBox5.Text = "&3D";
            checkBox5.CheckedChanged += checkBox5_CheckedChanged;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(440, 11);
            button1.Name = "button1";
            button1.Size = new Size(90, 28);
            button1.TabIndex = 5;
            button1.Text = "&Edit...";
            button1.Click += button1_Click;
            // 
            // gridBand1
            // 
            gridBand1.Axis = tChart1.Axes.Left;
            gridBand1.AxisIndex = -1;
            // 
            // 
            // 
            gridBand1.Band1.Color = Color.FromArgb(127, 192, 192, 192);
            // 
            // 
            // 
            gridBand1.Band2.Color = Color.FromArgb(127, 224, 224, 224);
            // 
            // SeriesType_Line
            // 
            AutoScaleBaseSize = new Size(6, 16);
            ClientSize = new Size(466, 286);
            Name = "SeriesType_Line";
            panel1.ResumeLayout(false);
            chartContainer.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            lineSeries1.Stairs = checkBox1.Checked;
            lineSeries2.Stairs = checkBox1.Checked;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            lineSeries1.Pointer.Visible = checkBox2.Checked;
            lineSeries2.Pointer.Visible = checkBox2.Checked;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            lineSeries1.Marks.Visible = checkBox3.Checked;
            lineSeries2.Marks.Visible = checkBox3.Checked;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked) lineSeries1.Stacked = Steema.TeeChart.Styles.CustomStack.Stack;
            else lineSeries1.Stacked = Steema.TeeChart.Styles.CustomStack.None;
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            tChart1.Aspect.View3D = checkBox5.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tChart1.ShowEditor();
        }
    }
}

