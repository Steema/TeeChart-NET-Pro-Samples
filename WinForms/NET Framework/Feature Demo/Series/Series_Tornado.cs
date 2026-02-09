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
      Steema.TeeChart.Margins margins1 = new Steema.TeeChart.Margins();
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
      // 
      // 
      // 
      this.tChart1.Axes.Bottom.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
      // 
      // 
      // 
      this.tChart1.Axes.Bottom.Labels.Brush.Color = System.Drawing.Color.White;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Bottom.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Bottom.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
      this.tChart1.Axes.Bottom.Labels.Font.Size = 9;
      this.tChart1.Axes.Bottom.Labels.Font.SizeFloat = 9F;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Bottom.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Bottom.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
      this.tChart1.Axes.Bottom.Labels.Sign = false;
      // 
      // 
      // 
      this.tChart1.Axes.Bottom.Title.Angle = 0;
      // 
      // 
      // 
      this.tChart1.Axes.Bottom.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
      // 
      // 
      // 
      this.tChart1.Axes.Bottom.Title.Brush.Color = System.Drawing.Color.Silver;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Bottom.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Bottom.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
      this.tChart1.Axes.Bottom.Title.Font.Size = 11;
      this.tChart1.Axes.Bottom.Title.Font.SizeFloat = 11F;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Bottom.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Bottom.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Depth.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
      // 
      // 
      // 
      this.tChart1.Axes.Depth.Labels.Brush.Color = System.Drawing.Color.White;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Depth.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Depth.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
      this.tChart1.Axes.Depth.Labels.Font.Size = 9;
      this.tChart1.Axes.Depth.Labels.Font.SizeFloat = 9F;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Depth.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Depth.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
      this.tChart1.Axes.Depth.Labels.Sign = false;
      // 
      // 
      // 
      this.tChart1.Axes.Depth.Title.Angle = 0;
      // 
      // 
      // 
      this.tChart1.Axes.Depth.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
      // 
      // 
      // 
      this.tChart1.Axes.Depth.Title.Brush.Color = System.Drawing.Color.Silver;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Depth.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Depth.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
      this.tChart1.Axes.Depth.Title.Font.Size = 11;
      this.tChart1.Axes.Depth.Title.Font.SizeFloat = 11F;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Depth.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Depth.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.DepthTop.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
      // 
      // 
      // 
      this.tChart1.Axes.DepthTop.Labels.Brush.Color = System.Drawing.Color.White;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.DepthTop.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.DepthTop.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
      this.tChart1.Axes.DepthTop.Labels.Font.Size = 9;
      this.tChart1.Axes.DepthTop.Labels.Font.SizeFloat = 9F;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.DepthTop.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.DepthTop.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
      this.tChart1.Axes.DepthTop.Labels.Sign = false;
      // 
      // 
      // 
      this.tChart1.Axes.DepthTop.Title.Angle = 0;
      // 
      // 
      // 
      this.tChart1.Axes.DepthTop.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
      // 
      // 
      // 
      this.tChart1.Axes.DepthTop.Title.Brush.Color = System.Drawing.Color.Silver;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.DepthTop.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.DepthTop.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
      this.tChart1.Axes.DepthTop.Title.Font.Size = 11;
      this.tChart1.Axes.DepthTop.Title.Font.SizeFloat = 11F;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.DepthTop.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.DepthTop.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Left.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
      // 
      // 
      // 
      this.tChart1.Axes.Left.Labels.Brush.Color = System.Drawing.Color.White;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Left.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Left.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
      this.tChart1.Axes.Left.Labels.Font.Size = 9;
      this.tChart1.Axes.Left.Labels.Font.SizeFloat = 9F;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Left.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Left.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
      this.tChart1.Axes.Left.Labels.Sign = false;
      // 
      // 
      // 
      this.tChart1.Axes.Left.Title.Angle = 90;
      // 
      // 
      // 
      this.tChart1.Axes.Left.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
      // 
      // 
      // 
      this.tChart1.Axes.Left.Title.Brush.Color = System.Drawing.Color.Silver;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Left.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Left.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
      this.tChart1.Axes.Left.Title.Font.Size = 11;
      this.tChart1.Axes.Left.Title.Font.SizeFloat = 11F;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Left.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Left.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Right.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
      // 
      // 
      // 
      this.tChart1.Axes.Right.Labels.Brush.Color = System.Drawing.Color.White;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Right.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Right.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
      this.tChart1.Axes.Right.Labels.Font.Size = 9;
      this.tChart1.Axes.Right.Labels.Font.SizeFloat = 9F;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Right.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Right.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
      this.tChart1.Axes.Right.Labels.Sign = false;
      // 
      // 
      // 
      this.tChart1.Axes.Right.Title.Angle = 270;
      // 
      // 
      // 
      this.tChart1.Axes.Right.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
      // 
      // 
      // 
      this.tChart1.Axes.Right.Title.Brush.Color = System.Drawing.Color.Silver;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Right.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Right.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
      this.tChart1.Axes.Right.Title.Font.Size = 11;
      this.tChart1.Axes.Right.Title.Font.SizeFloat = 11F;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Right.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Right.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Top.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
      // 
      // 
      // 
      this.tChart1.Axes.Top.Labels.Brush.Color = System.Drawing.Color.White;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Top.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Top.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
      this.tChart1.Axes.Top.Labels.Font.Size = 9;
      this.tChart1.Axes.Top.Labels.Font.SizeFloat = 9F;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Top.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Top.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
      this.tChart1.Axes.Top.Labels.Sign = false;
      // 
      // 
      // 
      this.tChart1.Axes.Top.Title.Angle = 0;
      // 
      // 
      // 
      this.tChart1.Axes.Top.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
      // 
      // 
      // 
      this.tChart1.Axes.Top.Title.Brush.Color = System.Drawing.Color.Silver;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Top.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Top.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
      this.tChart1.Axes.Top.Title.Font.Size = 11;
      this.tChart1.Axes.Top.Title.Font.SizeFloat = 11F;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Top.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Top.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Footer.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
      // 
      // 
      // 
      this.tChart1.Footer.Brush.Color = System.Drawing.Color.Silver;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Footer.Font.Brush.Color = System.Drawing.Color.Red;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Footer.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
      this.tChart1.Footer.Font.Size = 8;
      this.tChart1.Footer.Font.SizeFloat = 8F;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Footer.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Footer.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Header.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
      // 
      // 
      // 
      this.tChart1.Header.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
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
      // 
      // 
      // 
      this.tChart1.Header.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Header.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
      this.tChart1.Header.Font.Size = 14;
      this.tChart1.Header.Font.SizeFloat = 14F;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Header.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Header.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Legend.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
      // 
      // 
      // 
      this.tChart1.Legend.Brush.Color = System.Drawing.Color.White;
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
      this.tChart1.Legend.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Legend.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
      this.tChart1.Legend.Font.Size = 9;
      this.tChart1.Legend.Font.SizeFloat = 9F;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Legend.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Legend.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Legend.Symbol.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Legend.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
      // 
      // 
      // 
      this.tChart1.Legend.Title.Brush.Color = System.Drawing.Color.White;
      // 
      // 
      // 
      this.tChart1.Legend.Title.Font.Bold = true;
      // 
      // 
      // 
      this.tChart1.Legend.Title.Font.Brush.Color = System.Drawing.Color.Black;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Legend.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
      this.tChart1.Legend.Title.Font.Size = 8;
      this.tChart1.Legend.Title.Font.SizeFloat = 8F;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Legend.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Legend.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
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
      this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Panel.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Panel.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
      // 
      // 
      // 
      margins1.Bottom = 100;
      margins1.Left = 100;
      margins1.Right = 100;
      margins1.Top = 100;
      this.tChart1.Printer.Margins = margins1;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.SubFooter.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
      // 
      // 
      // 
      this.tChart1.SubFooter.Brush.Color = System.Drawing.Color.Silver;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.SubFooter.Font.Brush.Color = System.Drawing.Color.Red;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.SubFooter.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
      this.tChart1.SubFooter.Font.Size = 8;
      this.tChart1.SubFooter.Font.SizeFloat = 8F;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.SubFooter.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.SubFooter.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.SubHeader.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
      // 
      // 
      // 
      this.tChart1.SubHeader.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.SubHeader.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.SubHeader.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
      this.tChart1.SubHeader.Font.Size = 12;
      this.tChart1.SubHeader.Font.SizeFloat = 12F;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.SubHeader.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.SubHeader.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Walls.Back.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
      // 
      // 
      // 
      this.tChart1.Walls.Back.Brush.Color = System.Drawing.Color.Silver;
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
      this.tChart1.Walls.Back.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Walls.Back.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Walls.Bottom.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
      // 
      // 
      // 
      this.tChart1.Walls.Bottom.Brush.Color = System.Drawing.Color.White;
      // 
      // 
      // 
      this.tChart1.Walls.Bottom.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.tChart1.Walls.Bottom.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      this.tChart1.Walls.Bottom.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(0)))));
      this.tChart1.Walls.Bottom.Brush.Gradient.UseMiddle = true;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Walls.Bottom.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Walls.Bottom.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
      this.tChart1.Walls.Bottom.Visible = false;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Walls.Left.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
      // 
      // 
      // 
      this.tChart1.Walls.Left.Brush.Color = System.Drawing.Color.LightYellow;
      // 
      // 
      // 
      this.tChart1.Walls.Left.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.tChart1.Walls.Left.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      this.tChart1.Walls.Left.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(0)))));
      this.tChart1.Walls.Left.Brush.Gradient.UseMiddle = true;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Walls.Left.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Walls.Left.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
      this.tChart1.Walls.Left.Visible = false;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Walls.Right.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
      // 
      // 
      // 
      this.tChart1.Walls.Right.Brush.Color = System.Drawing.Color.LightYellow;
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
      this.tChart1.Walls.Right.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Walls.Right.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
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
      this.label1.Location = new System.Drawing.Point(261, 11);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(44, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "sort b&y: ";
      // 
      // comboBox1
      // 
      this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
      this.label2.Location = new System.Drawing.Point(96, 11);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(50, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "&Order by:";
      // 
      // comboBox2
      // 
      this.comboBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
