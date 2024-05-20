using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Steema.TeeChart.Samples
{
    public class Canvas_AntiAlias : Steema.TeeChart.Samples.BaseForm
    {
        private Steema.TeeChart.Styles.Pie pie1;
        private CheckBox checkBox1;
        private IContainer components = null;

        public Canvas_AntiAlias()
        {
            // This call is required by the Windows Form Designer.
            InitializeComponent();
            pie1.FillSampleValues(8);

            Bitmap b = tChart1.Bitmap();
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
            ComponentResourceManager resources = new ComponentResourceManager(typeof(Canvas_AntiAlias));
            pie1 = new Styles.Pie();
            checkBox1 = new CheckBox();
            panel1.SuspendLayout();
            chartContainer.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Size = new Size(440, 90);
            textBox1.Text = "Global method to smooth curve and diagonal lines (Anti-Alias), and new Canvas property to zoom fonts (as percentage).";
            // 
            // panel1
            // 
            panel1.Controls.Add(checkBox1);
            panel1.Location = new Point(0, 90);
            panel1.Size = new Size(440, 48);
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
            tChart1.Header.Lines = new string[] { "Anti-Aliased Pie" };
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
            tChart1.Series.Add(pie1);
            tChart1.Size = new Size(440, 179);
            tChart1.AfterDraw += tChart1_AfterDraw;
            // 
            // chartContainer
            // 
            chartContainer.Location = new Point(0, 138);
            chartContainer.Size = new Size(440, 179);
            // 
            // pie1
            // 
            pie1.Color = Color.FromArgb(119, 153, 214);
            pie1.Cursor = cursor1;
            // 
            // 
            // 
            pie1.Frame.Circled = true;
            pie1.Frame.FrameElementPercents = new double[] { 25D, 60D, 15D };
            // 
            // 
            // 
            pie1.Frame.InnerBand.Color = Color.Gray;
            // 
            // 
            // 
            pie1.Frame.OuterBand.Color = Color.Gray;
            // 
            // 
            // 
            pie1.Frame.OuterBand.Gradient.Visible = true;
            pie1.LabelMember = "Labels";
            // 
            // 
            // 
            // 
            // 
            // 
            pie1.Marks.Arrow.Color = Color.Black;
            // 
            // 
            // 
            pie1.MarksPie.InsideSlice = false;
            pie1.MarksPie.LegSize = 0;
            pie1.MarksPie.Rotated = false;
            pie1.MarksPie.RotateStyle = Styles.Pie.MarksRotateStyle.Radial;
            pie1.MarksPie.VertCenter = false;
            pie1.MultiPie = Styles.MultiPies.Automatic;
            // 
            // 
            // 
            pie1.OtherSlice.Color = Color.Empty;
            pie1.OtherSlice.Style = Styles.PieOtherStyles.None;
            pie1.OtherSlice.Text = "";
            pie1.OtherSlice.Value = 0D;
            pie1.Title = "pie1";
            pie1.UniqueCustomRadius = true;
            // 
            // 
            // 
            pie1.XValues.DataMember = "Angle";
            pie1.XValues.Order = Styles.ValueListOrder.Ascending;
            pie1.XValues.Value = new double[] { 0D, 1D, 2D, 3D, 4D, 5D, 6D, 7D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D };
            // 
            // 
            // 
            pie1.YValues.DataMember = "Pie";
            pie1.YValues.Value = new double[] { 444D, 98D, 39D, 961D, 186D, 699D, 304D, 753D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D, 0D };
            // 
            // checkBox1
            // 
            checkBox1.Location = new Point(19, 10);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(125, 29);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Anti-Alias";
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            checkBox1.Click += checkBox1_Click;
            // 
            // Canvas_AntiAlias
            // 
            AutoScaleBaseSize = new Size(6, 16);
            ClientSize = new Size(440, 317);
            Name = "Canvas_AntiAlias";
            panel1.ResumeLayout(false);
            chartContainer.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private void checkBox1_Click(object sender, EventArgs e)
        {

        }

        private void tChart1_AfterDraw(object sender, Steema.TeeChart.Drawing.IGraphics3D g)
        {
            Drawing.Graphics3DGdiPlus gg = g as Drawing.Graphics3DGdiPlus;
            if (gg.SmoothingMode == System.Drawing.Drawing2D.SmoothingMode.Default)
            {
                gg.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            }
            else
            {
                gg.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.Default;

            }

        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            tChart1.Invalidate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Steema.TeeChart.Drawing.TextShape ts;
            ts = pie1.Marks;
            ts.Font.Size = 20;
        }


    }
}

