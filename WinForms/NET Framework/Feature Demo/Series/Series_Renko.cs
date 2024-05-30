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

            // populate renko with closing values
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Series_Renko));
            this.candle1 = new Steema.TeeChart.Styles.Candle();
            this.renko1 = new Steema.TeeChart.Styles.Renko();
            this.buttonColor1 = new Steema.TeeChart.ButtonColor();
            this.buttonColor2 = new Steema.TeeChart.ButtonColor();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            this.chartContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonColor2);
            this.panel1.Controls.Add(this.buttonColor1);
            this.panel1.Size = new System.Drawing.Size(440, 69);
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
            this.tChart1.Axes.Bottom.Grid.Style = System.Drawing.Drawing2D.DashStyle.Dash;
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.Labels.DateTimeFormat = "d.M.yyyy";
            this.tChart1.Axes.Bottom.RelativePosition = 50D;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Depth.Grid.Style = System.Drawing.Drawing2D.DashStyle.Dash;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.DepthTop.Grid.Style = System.Drawing.Drawing2D.DashStyle.Dash;
            // 
            // 
            // 
            this.tChart1.Axes.Left.EndPosition = 50D;
            // 
            // 
            // 
            this.tChart1.Axes.Left.Grid.Style = System.Drawing.Drawing2D.DashStyle.Dash;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Right.Grid.Centered = true;
            this.tChart1.Axes.Right.Grid.Style = System.Drawing.Drawing2D.DashStyle.Dash;
            this.tChart1.Axes.Right.Increment = 1D;
            this.tChart1.Axes.Right.MaximumOffset = 20;
            this.tChart1.Axes.Right.MinimumOffset = 20;
            this.tChart1.Axes.Right.StartPosition = 50D;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Top.Grid.Centered = true;
            this.tChart1.Axes.Top.Grid.Style = System.Drawing.Drawing2D.DashStyle.Dash;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Top.Labels.Font.Size = 7;
            this.tChart1.Axes.Top.Labels.Font.SizeFloat = 7F;
            this.tChart1.Axes.Top.Labels.Style = Steema.TeeChart.AxisLabelStyle.Value;
            this.tChart1.Axes.Top.Labels.Visible = false;
            this.tChart1.Axes.Top.MaximumOffset = 20;
            this.tChart1.Axes.Top.MinimumOffset = 20;
            this.tChart1.Axes.Top.RelativePosition = 100D;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Header.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tChart1.Header.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tChart1.Header.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(0)))));
            this.tChart1.Header.Brush.Gradient.UseMiddle = true;
            // 
            // 
            // 
            this.tChart1.Header.Font.Size = 14;
            this.tChart1.Header.Font.SizeFloat = 14F;
            this.tChart1.Header.Visible = false;
            // 
            // 
            // 
            this.tChart1.Legend.Alignment = Steema.TeeChart.LegendAlignments.Bottom;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Legend.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tChart1.Legend.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tChart1.Legend.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(0)))));
            this.tChart1.Legend.Brush.Gradient.UseMiddle = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Panel.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.Raised;
            this.tChart1.Series.Add(this.candle1);
            this.tChart1.Series.Add(this.renko1);
            this.tChart1.Series.Add(this.renko1.VData);
            this.tChart1.Size = new System.Drawing.Size(440, 175);
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
            // 
            // 
            this.tChart1.Walls.Back.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Walls.Bottom.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tChart1.Walls.Bottom.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tChart1.Walls.Bottom.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(0)))));
            this.tChart1.Walls.Bottom.Brush.Gradient.UseMiddle = true;
            this.tChart1.Walls.Bottom.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Walls.Left.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tChart1.Walls.Left.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tChart1.Walls.Left.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(0)))));
            this.tChart1.Walls.Left.Brush.Gradient.UseMiddle = true;
            this.tChart1.Walls.Left.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Walls.Right.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tChart1.Walls.Right.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tChart1.Walls.Right.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(0)))));
            this.tChart1.Walls.Right.Brush.Gradient.UseMiddle = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Zoom.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            // 
            // chartContainer
            // 
            this.chartContainer.Location = new System.Drawing.Point(0, 142);
            this.chartContainer.Size = new System.Drawing.Size(440, 175);
            // 
            // candle1
            // 
            // 
            // 
            // 
            this.candle1.Brush.Color = System.Drawing.Color.White;
            this.candle1.CloseValues = this.candle1.YValues;
            this.candle1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(153)))), ((int)(((byte)(214)))));
            this.candle1.ColorEach = false;
            this.candle1.DateValues = this.candle1.XValues;
            // 
            // 
            // 
            this.candle1.HighLowPen.Color = System.Drawing.Color.Black;
            // 
            // 
            // 
            this.candle1.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(92)))), ((int)(((byte)(128)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.candle1.Marks.TailParams.CustomPointPos = ((System.Drawing.PointF)(resources.GetObject("resource.CustomPointPos")));
            this.candle1.Marks.TailParams.Margin = 0F;
            this.candle1.Marks.TailParams.PointerHeight = 8D;
            this.candle1.Marks.TailParams.PointerWidth = 8D;
            this.candle1.OriginalCursor = null;
            // 
            // 
            // 
            this.candle1.Pointer.Draw3D = false;
            this.candle1.Pointer.SizeDouble = 0D;
            this.candle1.Pointer.SizeUnits = Steema.TeeChart.Styles.PointerSizeUnits.Pixels;
            this.candle1.Title = "Trading data";
            this.candle1.UseExtendedNumRange = false;
            // 
            // 
            // 
            this.candle1.XValues.DataMember = "Date";
            this.candle1.XValues.DateTime = true;
            this.candle1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // 
            // 
            this.candle1.YValues.DataMember = "Close";
            // 
            // renko1
            // 
            this.renko1.BrickStats = Steema.TeeChart.Styles.BrickStatOptions.all;
            // 
            // 
            // 
            this.renko1.Brush.Color = System.Drawing.Color.Black;
            this.renko1.CloseValues = this.renko1.YValues;
            this.renko1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.renko1.ColorEach = false;
            this.renko1.DateValues = this.renko1.XValues;
            this.renko1.HorizAxis = Steema.TeeChart.Styles.HorizontalAxis.Top;
            // 
            // 
            // 
            this.renko1.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(76)))), ((int)(((byte)(43)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.renko1.Marks.TailParams.CustomPointPos = ((System.Drawing.PointF)(resources.GetObject("resource.CustomPointPos1")));
            this.renko1.Marks.TailParams.Margin = 0F;
            this.renko1.Marks.TailParams.PointerHeight = 8D;
            this.renko1.Marks.TailParams.PointerWidth = 8D;
            this.renko1.OriginalCursor = null;
            // 
            // 
            // 
            this.renko1.Pointer.SizeDouble = 0D;
            this.renko1.Pointer.SizeUnits = Steema.TeeChart.Styles.PointerSizeUnits.Pixels;
            this.renko1.Title = "Renko (close values)";
            this.renko1.UseExtendedNumRange = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.renko1.VData.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(104)))));
            this.renko1.VData.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(104)))));
            this.renko1.VData.ColorEach = false;
            // 
            // 
            // 
            this.renko1.VData.Legend.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.renko1.VData.Marks.TailParams.CustomPointPos = ((System.Drawing.PointF)(resources.GetObject("resource.CustomPointPos2")));
            this.renko1.VData.Marks.TailParams.Margin = 0F;
            this.renko1.VData.Marks.TailParams.PointerHeight = 8D;
            this.renko1.VData.Marks.TailParams.PointerWidth = 8D;
            this.renko1.VData.Marks.Visible = false;
            this.renko1.VData.OriginalCursor = null;
            // 
            // 
            // 
            this.renko1.VData.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(124)))), ((int)(((byte)(62)))));
            this.renko1.VData.SeriesData = null;
            this.renko1.VData.Title = "bar1";
            this.renko1.VData.UseExtendedNumRange = false;
            this.renko1.VData.Visible = false;
            this.renko1.VertAxis = Steema.TeeChart.Styles.VerticalAxis.Right;
            // 
            // 
            // 
            this.renko1.XValues.DataMember = "Date";
            this.renko1.XValues.DateTime = true;
            // 
            // 
            // 
            this.renko1.YValues.DataMember = "Close";
            // 
            // buttonColor1
            // 
            this.buttonColor1.Color = System.Drawing.Color.Empty;
            this.buttonColor1.Location = new System.Drawing.Point(12, 6);
            this.buttonColor1.Name = "buttonColor1";
            this.buttonColor1.Size = new System.Drawing.Size(105, 23);
            this.buttonColor1.TabIndex = 0;
            this.buttonColor1.Text = "Up swing";
            this.buttonColor1.UseVisualStyleBackColor = true;
            this.buttonColor1.Click += new System.EventHandler(this.buttonColor1_Click);
            // 
            // buttonColor2
            // 
            this.buttonColor2.Color = System.Drawing.Color.Empty;
            this.buttonColor2.Location = new System.Drawing.Point(12, 35);
            this.buttonColor2.Name = "buttonColor2";
            this.buttonColor2.Size = new System.Drawing.Size(105, 23);
            this.buttonColor2.TabIndex = 1;
            this.buttonColor2.Text = "Down swing";
            this.buttonColor2.UseVisualStyleBackColor = true;
            this.buttonColor2.Click += new System.EventHandler(this.buttonColor2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Box size";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(195, 9);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(64, 20);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // Series_Renko
            // 
            this.ClientSize = new System.Drawing.Size(440, 317);
            this.Name = "Series_Renko";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.chartContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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

