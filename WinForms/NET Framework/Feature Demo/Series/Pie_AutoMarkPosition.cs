using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Steema.TeeChart.Samples
{
	public class Pie_AutoMarkPosition : Steema.TeeChart.Samples.BaseForm
	{
		private Steema.TeeChart.Styles.Pie pie1;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.ComponentModel.IContainer components = null;

		public Pie_AutoMarkPosition()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

            pie1.Marks.ArrowLength = 20;
			pie1.FillSampleValues(16);
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.pie1 = new Steema.TeeChart.Styles.Pie();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Text = "Pie series can display Marks using an anti-overlap algorithm. \r\nThe algorithm mov" +
                "es marks outside the space of previous point marks. \r\n\r\npie1.Marks.AutoPosition = checkBox1.Checked;   // default is True";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.checkBox1);
			this.panel1.Name = "panel1";
			// 
			// tChart1
			// 
			// 
			// tChart1.Aspect
			// 
			this.tChart1.Aspect.Elevation = 315;
			this.tChart1.Aspect.Orthogonal = false;
			this.tChart1.Aspect.Perspective = 0;
			this.tChart1.Aspect.Rotation = 360;
			this.tChart1.Aspect.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
			this.tChart1.Aspect.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
			this.tChart1.Cursor = System.Windows.Forms.Cursors.Default;
			// 
			// tChart1.Header
			// 
			this.tChart1.Header.Lines = new string[0];
			// 
			// tChart1.Legend
			// 
			// 
			// tChart1.Legend.Brush
			// 
			this.tChart1.Legend.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(127)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			// 
			// tChart1.Legend.Gradient
			// 
			this.tChart1.Legend.Brush.Gradient.Transparency = 50;
			// 
			// tChart1.Legend.Gradient
			// 
			this.tChart1.Legend.Gradient.Transparency = 50;
			// 
			// tChart1.Legend.Shadow
			// 
			// 
			// tChart1.Legend.Shadow.Brush
			// 
			this.tChart1.Legend.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(127)), ((System.Byte)(0)), ((System.Byte)(0)), ((System.Byte)(0)));
			this.tChart1.Name = "tChart1";
			// 
			// tChart1.Panel
			// 
			// 
			// tChart1.Panel.Brush
			// 
			this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.tChart1.Series.Add(this.pie1);
			// 
			// pie1
			// 
			// 
			// pie1.Brush
			// 
			this.pie1.Brush.Color = System.Drawing.Color.Red;
			this.pie1.LabelMember = "Labels";
			// 
			// pie1.Marks
			// 
			// 
			// pie1.Marks.Symbol
			// 
			// 
			// pie1.Marks.Symbol.Shadow
			// 
			this.pie1.Marks.Symbol.Shadow.Height = 1;
			this.pie1.Marks.Symbol.Shadow.Visible = true;
			this.pie1.Marks.Symbol.Shadow.Width = 1;
			// 
			// pie1.Pen
			// 
			this.pie1.Pen.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(128)), ((System.Byte)(128)), ((System.Byte)(128)));
			// 
			// pie1.Shadow
			// 
			this.pie1.Shadow.Height = 20;
			this.pie1.Shadow.Width = 20;
			this.pie1.Title = "pie1";
			// 
			// pie1.XValues
			// 
			this.pie1.XValues.DataMember = "Angle";
			this.pie1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// pie1.YValues
			// 
			this.pie1.YValues.DataMember = "Pie";
			// 
			// checkBox1
			// 
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox1.Location = new System.Drawing.Point(8, 8);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(152, 24);
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "AutoMark Position";
			this.checkBox1.Click += new System.EventHandler(this.checkBox1_Click);
			// 
			// Pie_AutoMarkPosition
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(440, 317);
			this.Name = "Pie_AutoMarkPosition";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void checkBox1_Click(object sender, System.EventArgs e) {
			pie1.Marks.AutoPosition = checkBox1.Checked;
			tChart1.Invalidate();
		}
	}
}

