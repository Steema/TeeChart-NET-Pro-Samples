using Steema.TeeChart.Styles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Steema.TeeChart.Samples
{
  public class Series_Tornado : Steema.TeeChart.Samples.BaseForm
  {
    Steema.TeeChart.Styles.Tornado tornado;
    public Series_Tornado()
    {
      InitializeComponent();


    }

    private void Series_Tornado_Load(object sender, EventArgs e)
    {
      tChart1.Series.Clear();

      tornado = new Steema.TeeChart.Styles.Tornado();
      tChart1.Series.Add(tornado);

      tornado.BarStyle = Steema.TeeChart.Styles.BarStyles.RoundRectangle;
      //tornado.LeftColor = Color.Red;
      tornado.MarksOnBar = true;
      tornado.Marks.Font.Size = 12;
      tornado.Marks.Font.Bold = true;
      tornado.Marks.Font.Color = Color.White;

      tornado.SortBy = TornadoSortBy.None;

      tChart1[0].Add(1.2, 2.1, "Potatoes", Color.Empty);
      tChart1[0].Add(4.8, 3.7, "Cabbages", Color.Empty);
      tChart1[0].Add(3.1, 6.1, "Carrots", Color.Empty);
      tChart1[0].Add(5.1, 4.2, "Turnips", Color.Empty);

      tChart1.Legend.Visible = false;
      tChart1.Header.Text = "Greenhouse       Open air";
      tChart1.Axes.Bottom.Title.Text = "tonnes";

    }

    private ComboBox comboBox1;
    private Label label1;
    private ComboBox comboBox2;
    private Label label2;

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
      this.label1 = new System.Windows.Forms.Label();
      this.comboBox1 = new System.Windows.Forms.ComboBox();
      this.label2 = new System.Windows.Forms.Label();
      this.comboBox2 = new System.Windows.Forms.ComboBox();
      this.panel1.SuspendLayout();
      this.chartContainer.SuspendLayout();
      this.SuspendLayout();
      // 
      // textBox1
      // 
      this.textBox1.Text = "A Tornado chart, based on horizontal bars, is useful to show relativities as a sc" +
    "aled set between two categories..";
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.comboBox2);
      this.panel1.Controls.Add(this.label2);
      this.panel1.Controls.Add(this.comboBox1);
      this.panel1.Controls.Add(this.label1);
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
      this.tChart1.Axes.Bottom.Labels.Sign = false;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Depth.Labels.Sign = false;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.DepthTop.Labels.Sign = false;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Left.Labels.Sign = false;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Right.Labels.Sign = false;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Top.Labels.Sign = false;
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
      // 
      // 
      // 
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
      this.tChart1.Legend.ClipText = false;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Legend.Title.Font.Bold = true;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Panel.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.Raised;
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
      this.tChart1.Walls.Back.Brush.Visible = false;
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
      this.tChart1.Zoom.Brush.Visible = false;
      // 
      // label1
      // 
      this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(261, 12);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(44, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "sort b&y: ";
      // 
      // comboBox1
      // 
      this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.comboBox1.FormattingEnabled = true;
      this.comboBox1.Items.AddRange(new object[] {
            "Sum",
            "Left",
            "Right",
            "None"});
      this.comboBox1.Location = new System.Drawing.Point(311, 8);
      this.comboBox1.Name = "comboBox1";
      this.comboBox1.Size = new System.Drawing.Size(121, 21);
      this.comboBox1.TabIndex = 1;
      this.comboBox1.Text = "None";
      this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
      // 
      // label2
      // 
      this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(96, 12);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(50, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "&Order by:";
      // 
      // comboBox2
      // 
      this.comboBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.comboBox2.FormattingEnabled = true;
      this.comboBox2.Items.AddRange(new object[] {
            "None",
            "Ascending",
            "Descending"});
      this.comboBox2.Location = new System.Drawing.Point(152, 8);
      this.comboBox2.Name = "comboBox2";
      this.comboBox2.Size = new System.Drawing.Size(92, 21);
      this.comboBox2.TabIndex = 3;
      this.comboBox2.Text = "None";
      this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
      // 
      // Series_Tornado
      // 
      this.ClientSize = new System.Drawing.Size(440, 317);
      this.Name = "Series_Tornado";
      this.Load += new System.EventHandler(this.Series_Tornado_Load);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.chartContainer.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

private void resetSort()
{

      switch (comboBox1.SelectedIndex)
      {
        case 0: tornado.SortBy = Styles.TornadoSortBy.Sum; break;
        case 1: tornado.SortBy = Styles.TornadoSortBy.Left; break;
        case 2: tornado.SortBy = Styles.TornadoSortBy.Right; break;
        case 3: tornado.SortBy = Styles.TornadoSortBy.None; break;
      }

      switch (comboBox2.SelectedIndex)
      {
        case 0: tornado.SortOrder = ValueListOrder.None; break;
        case 1: tornado.SortOrder = ValueListOrder.Ascending; ; break;
        case 2: tornado.SortOrder = ValueListOrder.Descending; break;
      }

      tChart1.Refresh();

    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
      resetSort();
    }

    private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
    {
      resetSort();
    }
  }
}
