using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;


namespace Steema.TeeChart.Samples
{
    public class Legend_CheckBox : Samples.BaseForm
    {
        private Steema.TeeChart.Styles.Line lineSeries1;
        private Steema.TeeChart.Styles.Bar barSeries1;
        private Steema.TeeChart.Styles.Area areaSeries1;
        private Steema.TeeChart.Styles.Points pointSeries1;
        private ComboBox comboBox1;
        private Label label1;
        private IContainer components = null;

        public Legend_CheckBox()
        {
            // This call is required by the Windows Form Designer.
            InitializeComponent();

            foreach (Steema.TeeChart.Styles.Series s in tChart1.Series)
                s.FillSampleValues(6);
            ActiveStylesSetup();
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
            ComponentResourceManager resources = new ComponentResourceManager(typeof(Legend_CheckBox));
            Drawing.Cursor cursor2 = new Drawing.Cursor();
            lineSeries1 = new Styles.Line();
            barSeries1 = new Styles.Bar();
            areaSeries1 = new Styles.Area();
            pointSeries1 = new Styles.Points();
            label1 = new Label();
            comboBox1 = new ComboBox();
            panel1.SuspendLayout();
            chartContainer.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Size = new Size(466, 78);
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // panel1
            // 
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 78);
            panel1.Size = new Size(466, 40);
            // 
            // tChart1
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Axes.Bottom.Grid.Color = Color.Gray;
            // 
            // 
            // 
            tChart1.Axes.Bottom.Ticks.Length = 2;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Axes.Depth.Grid.Color = Color.Gray;
            // 
            // 
            // 
            tChart1.Axes.Depth.Ticks.Length = 2;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Axes.Left.Grid.Color = Color.FromArgb(254, 192, 192, 192);
            // 
            // 
            // 
            tChart1.Axes.Left.Ticks.Color = Color.FromArgb(254, 128, 128, 128);
            tChart1.Axes.Left.Ticks.Length = 2;
            tChart1.Axes.Left.Ticks.Style = Drawing.DashStyle.Dot;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Axes.Right.Grid.Color = Color.Gray;
            // 
            // 
            // 
            tChart1.Axes.Right.Ticks.Length = 2;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Axes.Top.Grid.Color = Color.Gray;
            // 
            // 
            // 
            tChart1.Axes.Top.Ticks.Length = 2;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Header.Font.Size = 14;
            tChart1.Header.Font.SizeFloat = 14F;
            tChart1.Header.Lines = new string[] { "tChart1" };
            // 
            // 
            // 
            tChart1.Legend.CheckBoxes = true;
            // 
            // 
            // 
            tChart1.Legend.Pen.Color = Color.FromArgb(254, 128, 128, 128);
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Legend.Shadow.Brush.Color = Color.FromArgb(181, 0, 0, 0);
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Panel.Brush.Color = Color.FromArgb(254, 255, 255, 255);
            // 
            // 
            // 
            tChart1.Panel.Brush.Gradient.EndColor = Color.Yellow;
            tChart1.Panel.Brush.Gradient.MiddleColor = Color.Empty;
            tChart1.Panel.Brush.Gradient.StartColor = Color.White;
            tChart1.Panel.Brush.Gradient.UseMiddle = false;
            // 
            // 
            // 
            tChart1.Panel.Shadow.Height = 0;
            tChart1.Panel.Shadow.Width = 0;
            tChart1.Series.Add(barSeries1);
            tChart1.Series.Add(areaSeries1);
            tChart1.Series.Add(pointSeries1);
            tChart1.Series.Add(lineSeries1);
            tChart1.Size = new Size(466, 168);
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Walls.Back.Pen.Color = Color.FromArgb(254, 128, 128, 128);
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
            // 
            // 
            // 
            // 
            // 
            tChart1.Walls.Right.Brush.Color = Color.Silver;
            // 
            // chartContainer
            // 
            chartContainer.Location = new Point(0, 118);
            chartContainer.Size = new Size(466, 168);
            // 
            // lineSeries1
            // 
            lineSeries1.Color = Color.FromArgb(255, 207, 104);
            lineSeries1.Cursor = cursor2;
            lineSeries1.Title = "lineSeries1";
            // 
            // 
            // 
            lineSeries1.XValues.DataMember = "X";
            lineSeries1.XValues.Order = Styles.ValueListOrder.Ascending;
            lineSeries1.XValues.Value = new double[] { 0D, 0.20833333333333334D, 0.41666666666666669D, 0.625D, 0.83333333333333337D, 1.0416666666666667D, 1.25D, 1.4583333333333333D, 1.6666666666666665D, 1.8749999999999998D, 2.083333333333333D, 2.2916666666666665D, 2.5D, 2.7083333333333335D, 2.916666666666667D, 3.1250000000000004D, 3.3333333333333339D, 3.5416666666666674D, 3.7500000000000009D, 3.9583333333333344D, 4.1666666666666679D, 4.3750000000000009D, 4.5833333333333339D, 4.791666666666667D, 5D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D };
            // 
            // 
            // 
            lineSeries1.YValues.DataMember = "Y";
            lineSeries1.YValues.Value = new double[] { 474D, 380D, 345D, 413D, 465D, 500D, 617D, 713D, 657D, 648D, 741D, 651D, 579D, 688D, 813D, 824D, 720D, 612D, 590D, 696D, 648D, 568D, 532D, 446D, 363D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D };
            // 
            // barSeries1
            // 
            barSeries1.BarRound = Styles.BarRounding.AtValue;
            barSeries1.Color = Color.FromArgb(255, 153, 153);
            barSeries1.Cursor = cursor2;
            barSeries1.Title = "barSeries1";
            // 
            // 
            // 
            barSeries1.XValues.DataMember = "X";
            barSeries1.XValues.Order = Styles.ValueListOrder.Ascending;
            barSeries1.XValues.Value = new double[] { 0D, 1D, 2D, 3D, 4D, 5D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D };
            // 
            // 
            // 
            barSeries1.YValues.DataMember = "Bar";
            barSeries1.YValues.Value = new double[] { 953D, 993D, 1047D, 1003D, 913D, 987D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D };
            // 
            // areaSeries1
            // 
            // 
            // 
            // 
            areaSeries1.AreaBrush.Color = Color.FromArgb(119, 153, 214);
            // 
            // 
            // 
            areaSeries1.AreaLines.Color = Color.FromArgb(71, 92, 128);
            areaSeries1.Color = Color.FromArgb(119, 153, 214);
            areaSeries1.Cursor = cursor2;
            areaSeries1.Title = "areaSeries1";
            // 
            // 
            // 
            areaSeries1.XValues.DataMember = "X";
            areaSeries1.XValues.Order = Styles.ValueListOrder.Ascending;
            areaSeries1.XValues.Value = new double[] { 0D, 0.20833333333333334D, 0.41666666666666669D, 0.625D, 0.83333333333333337D, 1.0416666666666667D, 1.25D, 1.4583333333333333D, 1.6666666666666665D, 1.8749999999999998D, 2.083333333333333D, 2.2916666666666665D, 2.5D, 2.7083333333333335D, 2.916666666666667D, 3.1250000000000004D, 3.3333333333333339D, 3.5416666666666674D, 3.7500000000000009D, 3.9583333333333344D, 4.1666666666666679D, 4.3750000000000009D, 4.5833333333333339D, 4.791666666666667D, 5D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D };
            // 
            // 
            // 
            areaSeries1.YValues.DataMember = "Y";
            areaSeries1.YValues.Value = new double[] { 429D, 446D, 492D, 413D, 335D, 260D, 249D, 281D, 221D, 162D, 164D, 84D, 64D, 9D, 38D, 77D, 44D, 161D, 120D, 161D, 284D, 163D, 259D, 139D, 73D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D };
            // 
            // pointSeries1
            // 
            pointSeries1.Color = Color.FromArgb(204, 255, 255);
            pointSeries1.Cursor = cursor2;
            // 
            // 
            // 
            // 
            // 
            // 
            pointSeries1.Pointer.Brush.Color = Color.FromArgb(204, 255, 255);
            // 
            // 
            // 
            pointSeries1.Pointer.Pen.Color = Color.FromArgb(122, 153, 153);
            pointSeries1.Title = "pointSeries1";
            // 
            // 
            // 
            pointSeries1.XValues.DataMember = "X";
            pointSeries1.XValues.Order = Styles.ValueListOrder.Ascending;
            pointSeries1.XValues.Value = new double[] { 0D, 0.20833333333333334D, 0.41666666666666669D, 0.625D, 0.83333333333333337D, 1.0416666666666667D, 1.25D, 1.4583333333333333D, 1.6666666666666665D, 1.8749999999999998D, 2.083333333333333D, 2.2916666666666665D, 2.5D, 2.7083333333333335D, 2.916666666666667D, 3.1250000000000004D, 3.3333333333333339D, 3.5416666666666674D, 3.7500000000000009D, 3.9583333333333344D, 4.1666666666666679D, 4.3750000000000009D, 4.5833333333333339D, 4.791666666666667D, 5D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D };
            // 
            // 
            // 
            pointSeries1.YValues.DataMember = "Y";
            pointSeries1.YValues.Value = new double[] { 467D, 597D, 667D, 566D, 448D, 472D, 398D, 498D, 398D, 404D, 334D, 238D, 272D, 181D, 127D, 206D, 299D, 254D, 305D, 302D, 186D, 222D, 161D, 33D, 79D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D };
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 13);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 0;
            label1.Text = "Active Style";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(85, 10);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 1;
            // 
            // Legend_CheckBox
            // 
            AutoScaleBaseSize = new Size(6, 16);
            ClientSize = new Size(466, 286);
            Name = "Legend_CheckBox";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            chartContainer.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private void ActiveStylesSetup()
        {
            comboBox1.DataSource = Enum.GetValues(typeof(LegendActiveStyles));
            comboBox1.SelectedValueChanged += ComboBox1_SelectedValueChanged;

        }
        private void ComboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            tChart1.Legend.ActiveStyle = (LegendActiveStyles)comboBox1.SelectedItem;
        }
        


    }
}

