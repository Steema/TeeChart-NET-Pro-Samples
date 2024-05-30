using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;


namespace Steema.TeeChart.Samples
{
    public class Canvas_180Rotation : Samples.BaseForm
    {
        private HScrollBar hScrollBar2;
        private Label label1;
        private Label label2;
        private Steema.TeeChart.Styles.Bar bar1;
        private IContainer components = null;

        public Canvas_180Rotation()
        {
            // This call is required by the Windows Form Designer.
            InitializeComponent();
            tChart1.Aspect.View3D = true;
            tChart1.Aspect.Orthogonal = false;


            bar1.FillSampleValues(4);
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
            Drawing.Cursor cursor1 = new Drawing.Cursor();
            ComponentResourceManager resources = new ComponentResourceManager(typeof(Canvas_180Rotation));
            hScrollBar2 = new HScrollBar();
            label1 = new Label();
            label2 = new Label();
            bar1 = new Styles.Bar();
            panel1.SuspendLayout();
            chartContainer.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Size = new Size(432, 89);
            textBox1.TabIndex = 0;
            textBox1.Text = "Chart can be fully rotated along the horizontal (x) axis.\r\nIn previous versions it allowed 180 degree rotation only.";
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(hScrollBar2);
            panel1.Location = new Point(0, 89);
            panel1.Size = new Size(432, 40);
            panel1.TabIndex = 1;
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
            tChart1.Header.Lines = new string[] { "tChart1" };
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
            // 
            // 
            // 
            tChart1.Panel.Brush.Gradient.EndColor = Color.FromArgb(254, 21, 60, 89);
            tChart1.Panel.Brush.Gradient.MiddleColor = Color.FromArgb(254, 255, 255, 255);
            tChart1.Panel.Brush.Gradient.Sigma = true;
            tChart1.Panel.Brush.Gradient.SigmaFocus = 1F;
            tChart1.Panel.Brush.Gradient.SigmaScale = 0.8F;
            tChart1.Panel.Brush.Gradient.StartColor = Color.FromArgb(254, 255, 255, 255);
            tChart1.Panel.Brush.Gradient.Visible = true;
            tChart1.Series.Add(bar1);
            tChart1.Size = new Size(432, 188);
            tChart1.TabIndex = 2;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Walls.Bottom.Size = 5;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Walls.Left.Brush.Color = Color.FromArgb(254, 232, 232, 255);
            tChart1.Walls.Left.Size = 10;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Walls.Right.Brush.Color = Color.FromArgb(254, 192, 192, 192);
            tChart1.Walls.Right.Size = 10;
            tChart1.Walls.Right.Visible = true;
            // 
            // chartContainer
            // 
            chartContainer.Location = new Point(0, 129);
            chartContainer.Size = new Size(432, 188);
            // 
            // hScrollBar2
            // 
            hScrollBar2.LargeChange = 1;
            hScrollBar2.Location = new Point(157, 12);
            hScrollBar2.Maximum = 360;
            hScrollBar2.Name = "hScrollBar2";
            hScrollBar2.Size = new Size(161, 18);
            hScrollBar2.TabIndex = 3;
            hScrollBar2.Scroll += hScrollBar2_Scroll;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 12);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 0;
            label1.Text = "&Rotation angle:";
            label1.TextAlign = ContentAlignment.TopRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(326, 12);
            label2.Name = "label2";
            label2.Size = new Size(25, 15);
            label2.TabIndex = 2;
            label2.Text = "360";
            label2.TextAlign = ContentAlignment.TopRight;
            // 
            // bar1
            // 
            bar1.BarRound = Styles.BarRounding.AtValue;
            // 
            // 
            // 
            // 
            // 
            // 
            bar1.Brush.Gradient.Visible = true;
            bar1.Color = Color.Red;
            bar1.Cursor = cursor1;
            // 
            // 
            // 
            bar1.Marks.ArrowLength = 20;
            bar1.Title = "bar1";
            // 
            // 
            // 
            bar1.XValues.DataMember = "X";
            bar1.XValues.Order = Styles.ValueListOrder.Ascending;
            bar1.XValues.Value = new double[] { 0D, 1D, 2D, 3D, 4D, 5D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D };
            // 
            // 
            // 
            bar1.YValues.DataMember = "Bar";
            bar1.YValues.Value = new double[] { 51D, 169D, 257D, 199D, 281D, 253D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D };
            // 
            // Canvas_180Rotation
            // 
            AutoScaleBaseSize = new Size(6, 16);
            ClientSize = new Size(432, 317);
            Name = "Canvas_180Rotation";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            chartContainer.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            tChart1.Aspect.Rotation = hScrollBar2.Value;
            label2.Text = tChart1.Aspect.Rotation.ToString();
        }
    }
}

