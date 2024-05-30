using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Steema.TeeChart.Samples
{
    public class Series_Renko : Steema.TeeChart.Samples.BaseForm
    {
        public Series_Renko()
        {
            InitializeComponent();
            candle1.FillSampleValues(20);

            //add initial colors if wanted
            renko1.UpSwingColor = Color.Green;
            renko1.DownSwingColor = Color.Red;

            //// populate renko with closing values
            renko1.Clear();
            for (int i = 0; i < candle1.Count; i++)
                renko1.Add(candle1.CloseValues[i]);

            // box size set to 2
            renko1.BoxSize = 5;

            // link buttons to colors
            buttonColor1.Color = renko1.UpSwingColor;
            buttonColor2.Color = renko1.DownSwingColor;
        }


        private Steema.TeeChart.Styles.Candle candle1;
        private Steema.TeeChart.Styles.Renko renko1;
        private Label label1;
        private ButtonColor buttonColor2;
        private ButtonColor buttonColor1;
        private NumericUpDown numericUpDown1;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            ComponentResourceManager resources = new ComponentResourceManager(typeof(Series_Renko));
            Drawing.Cursor cursor1 = new Drawing.Cursor();
            candle1 = new Styles.Candle();
            renko1 = new Styles.Renko();
            buttonColor1 = new ButtonColor();
            buttonColor2 = new ButtonColor();
            label1 = new Label();
            numericUpDown1 = new NumericUpDown();
            panel1.SuspendLayout();
            chartContainer.SuspendLayout();
            ((ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // panel1
            // 
            panel1.Controls.Add(numericUpDown1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(buttonColor2);
            panel1.Controls.Add(buttonColor1);
            panel1.Size = new Size(440, 69);
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
            tChart1.Axes.Bottom.Grid.Style = Drawing.DashStyle.Dash;
            // 
            // 
            // 
            tChart1.Axes.Bottom.Labels.DateTimeFormat = "d.M.yyyy";
            tChart1.Axes.Bottom.RelativePosition = 50D;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Axes.Depth.Grid.Style = Drawing.DashStyle.Dash;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Axes.DepthTop.Grid.Style = Drawing.DashStyle.Dash;
            // 
            // 
            // 
            tChart1.Axes.Left.EndPosition = 50D;
            // 
            // 
            // 
            tChart1.Axes.Left.Grid.Style = Drawing.DashStyle.Dash;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Axes.Right.Grid.Centered = true;
            tChart1.Axes.Right.Grid.Style = Drawing.DashStyle.Dash;
            tChart1.Axes.Right.Increment = 1D;
            tChart1.Axes.Right.MaximumOffset = 20;
            tChart1.Axes.Right.MinimumOffset = 20;
            tChart1.Axes.Right.StartPosition = 50D;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Axes.Top.Grid.Centered = true;
            tChart1.Axes.Top.Grid.Style = Drawing.DashStyle.Dash;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Axes.Top.Labels.Font.Size = 7;
            tChart1.Axes.Top.Labels.Font.SizeFloat = 7F;
            tChart1.Axes.Top.Labels.Style = AxisLabelStyle.Value;
            tChart1.Axes.Top.Labels.Visible = false;
            tChart1.Axes.Top.MaximumOffset = 20;
            tChart1.Axes.Top.MinimumOffset = 20;
            tChart1.Axes.Top.RelativePosition = 100D;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Header.Font.Size = 14;
            tChart1.Header.Font.SizeFloat = 14F;
            tChart1.Header.Visible = false;
            // 
            // 
            // 
            tChart1.Legend.Alignment = LegendAlignments.Bottom;
            tChart1.Legend.CheckBoxes = false;
            tChart1.Series.Add(candle1);
            tChart1.Series.Add(renko1);
            tChart1.Size = new Size(440, 175);
            // 
            // chartContainer
            // 
            chartContainer.Location = new Point(0, 142);
            chartContainer.Size = new Size(440, 175);
            // 
            // candle1
            // 
            candle1.Color = Color.FromArgb(119, 153, 214);
            candle1.Cursor = cursor1;
            // 
            // 
            // 
            candle1.Pointer.Draw3D = false;
            candle1.Title = "Trading data";
            // 
            // 
            // 
            candle1.XValues.DataMember = "Date";
            candle1.XValues.DateTime = true;
            candle1.XValues.Order = Styles.ValueListOrder.Ascending;
            candle1.XValues.Value = new double[] { 45425.670504155096D, 45426.670504155096D, 45427.670504155096D, 45428.670504155096D, 45429.670504155096D, 45430.670504155096D, 45431.670504155096D, 45432.670504155096D, 45433.670504155096D, 45434.670504155096D, 45435.670504155096D, 45436.670504155096D, 45437.670504155096D, 45438.670504155096D, 45439.670504155096D, 45440.670504155096D, 45441.670504155096D, 45442.670504155096D, 45443.670504155096D, 45444.670504155096D, 45445.670504155096D, 45446.670504155096D, 45447.670504155096D, 45448.670504155096D, 45449.670504155096D, 45450.670504155096D, 45451.670504155096D, 45452.670504155096D, 45453.670504155096D, 45454.670504155096D, 45455.670504155096D, 45456.670504155096D, 45457.670504155096D, 45458.670504155096D, 45459.670504155096D, 45460.670504155096D, 45461.670504155096D, 45462.670504155096D, 45463.670504155096D, 45464.670504155096D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D };
            // 
            // 
            // 
            candle1.YValues.DataMember = "Close";
            candle1.YValues.Value = new double[] { 46.702045923425842D, 60.24862922134281D, 77.796137877645037D, 81.370989698158112D, 61.06089896199336D, 68.973248501295814D, 54.632739334661863D, 42.065338925023262D, 47.7810316299D, 48.462173224176354D, 45.168407693118041D, 55.6996136636937D, 43.28258356791109D, 46.296035276398072D, 33.277796602471632D, 23.471728577498212D, 11.726566280110994D, 26.004597904628412D, 25.245765157624035D, 35.265823645641014D, 38.3246839327387D, 39.337184390210169D, 52.55556934725287D, 43.097227420703149D, 31.861660854826525D, 26.698042249166427D, 41.7415805038724D, 47.134612795959512D, 34.316715140043158D, 29.911316934466043D, 31.053903444229576D, 14.406513544454477D, 26.321412193738581D, 27.550682851369814D, 19.998064386657468D, 15.79913407694508D, 15.708247273093207D, 18.037894403113938D, 35.694078275791412D, 23.541592364451667D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D };
            // 
            // renko1
            // 
            renko1.BrickStats = Styles.BrickStatOptions.all;
            renko1.Color = Color.FromArgb(0, 0, 0);
            renko1.Cursor = cursor1;
            renko1.HorizAxis = Styles.HorizontalAxis.Top;
            renko1.Title = "Renko (close values)";
            // 
            // 
            // 
            renko1.VData.Color = Color.FromArgb(255, 207, 104);
            // 
            // 
            // 
            renko1.VData.Legend.Visible = false;
            // 
            // 
            // 
            renko1.VData.Marks.Visible = false;
            renko1.VData.SeriesData = null;
            renko1.VData.Title = "bar1";
            renko1.VData.Visible = false;
            // 
            // 
            // 
            renko1.VData.XValues.Value = new double[] { 0D };
            // 
            // 
            // 
            renko1.VData.YValues.Value = new double[] { 0D };
            renko1.VertAxis = Styles.VerticalAxis.Right;
            // 
            // 
            // 
            renko1.XValues.DataMember = "X";
            renko1.XValues.DateTime = true;
            renko1.XValues.Order = Styles.ValueListOrder.Ascending;
            renko1.XValues.Value = new double[] { 45417.670504166665D, 45418.670504166665D, 45419.670504166665D, 45420.670504166665D, 45421.670504166665D, 45422.670504166665D, 45423.670504166665D, 45424.670504166665D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D };
            // 
            // 
            // 
            renko1.YValues.DataMember = "Y";
            renko1.YValues.Value = new double[] { -1.8577913932048D, 0.94063693238788249D, 3.2342269891686377D, 2.9935203918681044D, 4.2797024185806123D, 3.3544184463320583D, 2.1566977542315762D, 5.0116815850722478D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D };
            // 
            // buttonColor1
            // 
            buttonColor1.Color = Color.Empty;
            buttonColor1.Location = new Point(12, 6);
            buttonColor1.Name = "buttonColor1";
            buttonColor1.Size = new Size(105, 23);
            buttonColor1.TabIndex = 0;
            buttonColor1.Text = "Up swing";
            buttonColor1.Click += buttonColor1_Click;
            // 
            // buttonColor2
            // 
            buttonColor2.Color = Color.Empty;
            buttonColor2.Location = new Point(12, 35);
            buttonColor2.Name = "buttonColor2";
            buttonColor2.Size = new Size(105, 23);
            buttonColor2.TabIndex = 1;
            buttonColor2.Text = "Down swing";
            buttonColor2.Click += buttonColor2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(143, 11);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 2;
            label1.Text = "Box size";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(195, 9);
            numericUpDown1.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(64, 23);
            numericUpDown1.TabIndex = 3;
            numericUpDown1.Value = new decimal(new int[] { 5, 0, 0, 0 });
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // Series_Renko
            // 
            ClientSize = new Size(440, 317);
            Name = "Series_Renko";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            chartContainer.ResumeLayout(false);
            ((ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            renko1.BoxSize = (int)numericUpDown1.Value;
        }

        private void buttonColor1_Click(object sender, EventArgs e)
        {
            renko1.UpSwingColor = buttonColor1.Color;
        }

        private void buttonColor2_Click(object sender, EventArgs e)
        {
            renko1.DownSwingColor = buttonColor2.Color;
        }
    }
}

