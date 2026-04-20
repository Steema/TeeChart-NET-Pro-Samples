using System.Resources;

namespace WinAppMultiVis
{
  partial class FormMultiAxis
  {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      components = new System.ComponentModel.Container();
      Steema.TeeChart.Margins margins1 = new Steema.TeeChart.Margins();
      Steema.TeeChart.Drawing.Cursor cursor1 = new Steema.TeeChart.Drawing.Cursor();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMultiAxis));
      chartController1 = new Steema.TeeChart.ChartController();
      tChart7 = new Steema.TeeChart.TChart();
      axis1 = new Steema.TeeChart.Axis(components);
      axis2 = new Steema.TeeChart.Axis(components);
      area1 = new Steema.TeeChart.Styles.Area();
      line1 = new Steema.TeeChart.Styles.Line();
      line2 = new Steema.TeeChart.Styles.Line();
      bar3D1 = new Steema.TeeChart.Styles.Bar3D();
      cursorTool1 = new Steema.TeeChart.Tools.CursorTool();
      SuspendLayout();
      // 
      // chartController1
      // 
      chartController1.ButtonSize = Steema.TeeChart.ControllerButtonSize.x16;
      chartController1.Chart = tChart7;
      chartController1.LabelValues = true;
      chartController1.Location = new Point(0, 0);
      chartController1.Name = "chartController1";
      chartController1.Size = new Size(1427, 25);
      chartController1.TabIndex = 0;
      chartController1.Text = "chartController1";
      // 
      // tChart7
      // 
      // 
      // 
      // 
      tChart7.Aspect.ColorPaletteIndex = -1;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      tChart7.Axes.Bottom.Labels.Angle = 45;
      // 
      // 
      // 
      tChart7.Axes.Bottom.Labels.Brush.Color = Color.White;
      tChart7.Axes.Bottom.Labels.Brush.Solid = true;
      tChart7.Axes.Bottom.Labels.Brush.Visible = true;
      tChart7.Axes.Bottom.Labels.DateTimeFormat = "hh:mm:ss";
      // 
      // 
      // 
      tChart7.Axes.Bottom.Labels.Font.Bold = false;
      // 
      // 
      // 
      tChart7.Axes.Bottom.Labels.Font.Brush.Color = Color.FromArgb(255, 255, 255);
      tChart7.Axes.Bottom.Labels.Font.Brush.Solid = true;
      tChart7.Axes.Bottom.Labels.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart7.Axes.Bottom.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart7.Axes.Bottom.Labels.Font.Shadow.Brush.Solid = true;
      tChart7.Axes.Bottom.Labels.Font.Shadow.Brush.Visible = true;
      tChart7.Axes.Bottom.Labels.Font.Size = 6;
      tChart7.Axes.Bottom.Labels.Font.SizeFloat = 6F;
      tChart7.Axes.Bottom.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart7.Axes.Bottom.Labels.ImageBevel.Brush.Color = Color.LightGray;
      tChart7.Axes.Bottom.Labels.ImageBevel.Brush.Solid = true;
      tChart7.Axes.Bottom.Labels.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart7.Axes.Bottom.Labels.Shadow.Brush.Color = Color.DarkGray;
      tChart7.Axes.Bottom.Labels.Shadow.Brush.Solid = true;
      tChart7.Axes.Bottom.Labels.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart7.Axes.Bottom.Title.Brush.Color = Color.Silver;
      tChart7.Axes.Bottom.Title.Brush.Solid = true;
      tChart7.Axes.Bottom.Title.Brush.Visible = true;
      // 
      // 
      // 
      tChart7.Axes.Bottom.Title.Font.Bold = false;
      // 
      // 
      // 
      tChart7.Axes.Bottom.Title.Font.Brush.Color = Color.FromArgb(0, 0, 0);
      tChart7.Axes.Bottom.Title.Font.Brush.Solid = true;
      tChart7.Axes.Bottom.Title.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart7.Axes.Bottom.Title.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart7.Axes.Bottom.Title.Font.Shadow.Brush.Solid = true;
      tChart7.Axes.Bottom.Title.Font.Shadow.Brush.Visible = true;
      tChart7.Axes.Bottom.Title.Font.Size = 8;
      tChart7.Axes.Bottom.Title.Font.SizeFloat = 8F;
      tChart7.Axes.Bottom.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart7.Axes.Bottom.Title.ImageBevel.Brush.Color = Color.LightGray;
      tChart7.Axes.Bottom.Title.ImageBevel.Brush.Solid = true;
      tChart7.Axes.Bottom.Title.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart7.Axes.Bottom.Title.Shadow.Brush.Color = Color.DarkGray;
      tChart7.Axes.Bottom.Title.Shadow.Brush.Solid = true;
      tChart7.Axes.Bottom.Title.Shadow.Brush.Visible = true;
      tChart7.Axes.Custom.Add(axis1);
      tChart7.Axes.Custom.Add(axis2);
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      tChart7.Axes.Depth.Labels.Brush.Color = Color.White;
      tChart7.Axes.Depth.Labels.Brush.Solid = true;
      tChart7.Axes.Depth.Labels.Brush.Visible = true;
      // 
      // 
      // 
      tChart7.Axes.Depth.Labels.Font.Bold = false;
      // 
      // 
      // 
      tChart7.Axes.Depth.Labels.Font.Brush.Color = Color.FromArgb(255, 255, 255);
      tChart7.Axes.Depth.Labels.Font.Brush.Solid = true;
      tChart7.Axes.Depth.Labels.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart7.Axes.Depth.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart7.Axes.Depth.Labels.Font.Shadow.Brush.Solid = true;
      tChart7.Axes.Depth.Labels.Font.Shadow.Brush.Visible = true;
      tChart7.Axes.Depth.Labels.Font.Size = 8;
      tChart7.Axes.Depth.Labels.Font.SizeFloat = 8F;
      tChart7.Axes.Depth.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart7.Axes.Depth.Labels.ImageBevel.Brush.Color = Color.LightGray;
      tChart7.Axes.Depth.Labels.ImageBevel.Brush.Solid = true;
      tChart7.Axes.Depth.Labels.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart7.Axes.Depth.Labels.Shadow.Brush.Color = Color.DarkGray;
      tChart7.Axes.Depth.Labels.Shadow.Brush.Solid = true;
      tChart7.Axes.Depth.Labels.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart7.Axes.Depth.Title.Brush.Color = Color.Silver;
      tChart7.Axes.Depth.Title.Brush.Solid = true;
      tChart7.Axes.Depth.Title.Brush.Visible = true;
      // 
      // 
      // 
      tChart7.Axes.Depth.Title.Font.Bold = false;
      // 
      // 
      // 
      tChart7.Axes.Depth.Title.Font.Brush.Color = Color.FromArgb(0, 0, 0);
      tChart7.Axes.Depth.Title.Font.Brush.Solid = true;
      tChart7.Axes.Depth.Title.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart7.Axes.Depth.Title.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart7.Axes.Depth.Title.Font.Shadow.Brush.Solid = true;
      tChart7.Axes.Depth.Title.Font.Shadow.Brush.Visible = true;
      tChart7.Axes.Depth.Title.Font.Size = 8;
      tChart7.Axes.Depth.Title.Font.SizeFloat = 8F;
      tChart7.Axes.Depth.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart7.Axes.Depth.Title.ImageBevel.Brush.Color = Color.LightGray;
      tChart7.Axes.Depth.Title.ImageBevel.Brush.Solid = true;
      tChart7.Axes.Depth.Title.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart7.Axes.Depth.Title.Shadow.Brush.Color = Color.DarkGray;
      tChart7.Axes.Depth.Title.Shadow.Brush.Solid = true;
      tChart7.Axes.Depth.Title.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      tChart7.Axes.DepthTop.Labels.Brush.Color = Color.White;
      tChart7.Axes.DepthTop.Labels.Brush.Solid = true;
      tChart7.Axes.DepthTop.Labels.Brush.Visible = true;
      // 
      // 
      // 
      tChart7.Axes.DepthTop.Labels.Font.Bold = false;
      // 
      // 
      // 
      tChart7.Axes.DepthTop.Labels.Font.Brush.Color = Color.FromArgb(255, 255, 255);
      tChart7.Axes.DepthTop.Labels.Font.Brush.Solid = true;
      tChart7.Axes.DepthTop.Labels.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart7.Axes.DepthTop.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart7.Axes.DepthTop.Labels.Font.Shadow.Brush.Solid = true;
      tChart7.Axes.DepthTop.Labels.Font.Shadow.Brush.Visible = true;
      tChart7.Axes.DepthTop.Labels.Font.Size = 8;
      tChart7.Axes.DepthTop.Labels.Font.SizeFloat = 8F;
      tChart7.Axes.DepthTop.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart7.Axes.DepthTop.Labels.ImageBevel.Brush.Color = Color.LightGray;
      tChart7.Axes.DepthTop.Labels.ImageBevel.Brush.Solid = true;
      tChart7.Axes.DepthTop.Labels.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart7.Axes.DepthTop.Labels.Shadow.Brush.Color = Color.DarkGray;
      tChart7.Axes.DepthTop.Labels.Shadow.Brush.Solid = true;
      tChart7.Axes.DepthTop.Labels.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart7.Axes.DepthTop.Title.Brush.Color = Color.Silver;
      tChart7.Axes.DepthTop.Title.Brush.Solid = true;
      tChart7.Axes.DepthTop.Title.Brush.Visible = true;
      // 
      // 
      // 
      tChart7.Axes.DepthTop.Title.Font.Bold = false;
      // 
      // 
      // 
      tChart7.Axes.DepthTop.Title.Font.Brush.Color = Color.FromArgb(0, 0, 0);
      tChart7.Axes.DepthTop.Title.Font.Brush.Solid = true;
      tChart7.Axes.DepthTop.Title.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart7.Axes.DepthTop.Title.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart7.Axes.DepthTop.Title.Font.Shadow.Brush.Solid = true;
      tChart7.Axes.DepthTop.Title.Font.Shadow.Brush.Visible = true;
      tChart7.Axes.DepthTop.Title.Font.Size = 8;
      tChart7.Axes.DepthTop.Title.Font.SizeFloat = 8F;
      tChart7.Axes.DepthTop.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart7.Axes.DepthTop.Title.ImageBevel.Brush.Color = Color.LightGray;
      tChart7.Axes.DepthTop.Title.ImageBevel.Brush.Solid = true;
      tChart7.Axes.DepthTop.Title.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart7.Axes.DepthTop.Title.Shadow.Brush.Color = Color.DarkGray;
      tChart7.Axes.DepthTop.Title.Shadow.Brush.Solid = true;
      tChart7.Axes.DepthTop.Title.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart7.Axes.Left.AxisPen.Color = Color.FromArgb(128, 128, 255);
      tChart7.Axes.Left.AxisPen.Visible = true;
      tChart7.Axes.Left.EndPosition = 70D;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart7.Axes.Left.Labels.Brush.Color = Color.White;
      tChart7.Axes.Left.Labels.Brush.Solid = true;
      tChart7.Axes.Left.Labels.Brush.Visible = true;
      // 
      // 
      // 
      tChart7.Axes.Left.Labels.Font.Bold = false;
      // 
      // 
      // 
      tChart7.Axes.Left.Labels.Font.Brush.Color = Color.FromArgb(255, 255, 255);
      tChart7.Axes.Left.Labels.Font.Brush.Solid = true;
      tChart7.Axes.Left.Labels.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart7.Axes.Left.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart7.Axes.Left.Labels.Font.Shadow.Brush.Solid = true;
      tChart7.Axes.Left.Labels.Font.Shadow.Brush.Visible = true;
      tChart7.Axes.Left.Labels.Font.Size = 8;
      tChart7.Axes.Left.Labels.Font.SizeFloat = 8F;
      tChart7.Axes.Left.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart7.Axes.Left.Labels.ImageBevel.Brush.Color = Color.LightGray;
      tChart7.Axes.Left.Labels.ImageBevel.Brush.Solid = true;
      tChart7.Axes.Left.Labels.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart7.Axes.Left.Labels.Shadow.Brush.Color = Color.DarkGray;
      tChart7.Axes.Left.Labels.Shadow.Brush.Solid = true;
      tChart7.Axes.Left.Labels.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart7.Axes.Left.Title.Brush.Color = Color.Silver;
      tChart7.Axes.Left.Title.Brush.Solid = true;
      tChart7.Axes.Left.Title.Brush.Visible = true;
      tChart7.Axes.Left.Title.Caption = "Volume GBs";
      // 
      // 
      // 
      tChart7.Axes.Left.Title.Font.Bold = false;
      // 
      // 
      // 
      tChart7.Axes.Left.Title.Font.Brush.Color = Color.FromArgb(255, 255, 255);
      tChart7.Axes.Left.Title.Font.Brush.Solid = true;
      tChart7.Axes.Left.Title.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart7.Axes.Left.Title.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart7.Axes.Left.Title.Font.Shadow.Brush.Solid = true;
      tChart7.Axes.Left.Title.Font.Shadow.Brush.Visible = true;
      tChart7.Axes.Left.Title.Font.Size = 8;
      tChart7.Axes.Left.Title.Font.SizeFloat = 8F;
      tChart7.Axes.Left.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart7.Axes.Left.Title.ImageBevel.Brush.Color = Color.LightGray;
      tChart7.Axes.Left.Title.ImageBevel.Brush.Solid = true;
      tChart7.Axes.Left.Title.ImageBevel.Brush.Visible = true;
      tChart7.Axes.Left.Title.Lines = new string[]
  {
    "Volume GBs"
  };
      // 
      // 
      // 
      // 
      // 
      // 
      tChart7.Axes.Left.Title.Shadow.Brush.Color = Color.DarkGray;
      tChart7.Axes.Left.Title.Shadow.Brush.Solid = true;
      tChart7.Axes.Left.Title.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart7.Axes.Right.AxisPen.Color = Color.FromArgb(255, 192, 128);
      tChart7.Axes.Right.AxisPen.Visible = true;
      tChart7.Axes.Right.EndPosition = 70D;
      // 
      // 
      // 
      tChart7.Axes.Right.Grid.Visible = false;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart7.Axes.Right.Labels.Brush.Color = Color.White;
      tChart7.Axes.Right.Labels.Brush.Solid = true;
      tChart7.Axes.Right.Labels.Brush.Visible = true;
      // 
      // 
      // 
      tChart7.Axes.Right.Labels.Font.Bold = false;
      // 
      // 
      // 
      tChart7.Axes.Right.Labels.Font.Brush.Color = Color.FromArgb(255, 255, 255);
      tChart7.Axes.Right.Labels.Font.Brush.Solid = true;
      tChart7.Axes.Right.Labels.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart7.Axes.Right.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart7.Axes.Right.Labels.Font.Shadow.Brush.Solid = true;
      tChart7.Axes.Right.Labels.Font.Shadow.Brush.Visible = true;
      tChart7.Axes.Right.Labels.Font.Size = 8;
      tChart7.Axes.Right.Labels.Font.SizeFloat = 8F;
      tChart7.Axes.Right.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart7.Axes.Right.Labels.ImageBevel.Brush.Color = Color.LightGray;
      tChart7.Axes.Right.Labels.ImageBevel.Brush.Solid = true;
      tChart7.Axes.Right.Labels.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart7.Axes.Right.Labels.Shadow.Brush.Color = Color.DarkGray;
      tChart7.Axes.Right.Labels.Shadow.Brush.Solid = true;
      tChart7.Axes.Right.Labels.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart7.Axes.Right.Title.Brush.Color = Color.Silver;
      tChart7.Axes.Right.Title.Brush.Solid = true;
      tChart7.Axes.Right.Title.Brush.Visible = true;
      tChart7.Axes.Right.Title.Caption = "Throughput GB/s";
      // 
      // 
      // 
      tChart7.Axes.Right.Title.Font.Bold = false;
      // 
      // 
      // 
      tChart7.Axes.Right.Title.Font.Brush.Color = Color.FromArgb(255, 255, 255);
      tChart7.Axes.Right.Title.Font.Brush.Solid = true;
      tChart7.Axes.Right.Title.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart7.Axes.Right.Title.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart7.Axes.Right.Title.Font.Shadow.Brush.Solid = true;
      tChart7.Axes.Right.Title.Font.Shadow.Brush.Visible = true;
      tChart7.Axes.Right.Title.Font.Size = 8;
      tChart7.Axes.Right.Title.Font.SizeFloat = 8F;
      tChart7.Axes.Right.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart7.Axes.Right.Title.ImageBevel.Brush.Color = Color.LightGray;
      tChart7.Axes.Right.Title.ImageBevel.Brush.Solid = true;
      tChart7.Axes.Right.Title.ImageBevel.Brush.Visible = true;
      tChart7.Axes.Right.Title.Lines = new string[]
  {
    "Throughput GB/s"
  };
      // 
      // 
      // 
      // 
      // 
      // 
      tChart7.Axes.Right.Title.Shadow.Brush.Color = Color.DarkGray;
      tChart7.Axes.Right.Title.Shadow.Brush.Solid = true;
      tChart7.Axes.Right.Title.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      tChart7.Axes.Top.Labels.Brush.Color = Color.White;
      tChart7.Axes.Top.Labels.Brush.Solid = true;
      tChart7.Axes.Top.Labels.Brush.Visible = true;
      // 
      // 
      // 
      tChart7.Axes.Top.Labels.Font.Bold = false;
      // 
      // 
      // 
      tChart7.Axes.Top.Labels.Font.Brush.Color = Color.FromArgb(255, 255, 255);
      tChart7.Axes.Top.Labels.Font.Brush.Solid = true;
      tChart7.Axes.Top.Labels.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart7.Axes.Top.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart7.Axes.Top.Labels.Font.Shadow.Brush.Solid = true;
      tChart7.Axes.Top.Labels.Font.Shadow.Brush.Visible = true;
      tChart7.Axes.Top.Labels.Font.Size = 8;
      tChart7.Axes.Top.Labels.Font.SizeFloat = 8F;
      tChart7.Axes.Top.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart7.Axes.Top.Labels.ImageBevel.Brush.Color = Color.LightGray;
      tChart7.Axes.Top.Labels.ImageBevel.Brush.Solid = true;
      tChart7.Axes.Top.Labels.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart7.Axes.Top.Labels.Shadow.Brush.Color = Color.DarkGray;
      tChart7.Axes.Top.Labels.Shadow.Brush.Solid = true;
      tChart7.Axes.Top.Labels.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart7.Axes.Top.Title.Brush.Color = Color.Silver;
      tChart7.Axes.Top.Title.Brush.Solid = true;
      tChart7.Axes.Top.Title.Brush.Visible = true;
      // 
      // 
      // 
      tChart7.Axes.Top.Title.Font.Bold = false;
      // 
      // 
      // 
      tChart7.Axes.Top.Title.Font.Brush.Color = Color.FromArgb(0, 0, 0);
      tChart7.Axes.Top.Title.Font.Brush.Solid = true;
      tChart7.Axes.Top.Title.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart7.Axes.Top.Title.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart7.Axes.Top.Title.Font.Shadow.Brush.Solid = true;
      tChart7.Axes.Top.Title.Font.Shadow.Brush.Visible = true;
      tChart7.Axes.Top.Title.Font.Size = 8;
      tChart7.Axes.Top.Title.Font.SizeFloat = 8F;
      tChart7.Axes.Top.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart7.Axes.Top.Title.ImageBevel.Brush.Color = Color.LightGray;
      tChart7.Axes.Top.Title.ImageBevel.Brush.Solid = true;
      tChart7.Axes.Top.Title.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart7.Axes.Top.Title.Shadow.Brush.Color = Color.DarkGray;
      tChart7.Axes.Top.Title.Shadow.Brush.Solid = true;
      tChart7.Axes.Top.Title.Shadow.Brush.Visible = true;
      tChart7.Dock = DockStyle.Fill;
      // 
      // 
      // 
      tChart7.Footer.Alignment = Steema.TeeChart.Drawing.StringAlignment.Far;
      // 
      // 
      // 
      tChart7.Footer.Brush.Color = Color.Silver;
      tChart7.Footer.Brush.Solid = true;
      tChart7.Footer.Brush.Visible = true;
      // 
      // 
      // 
      tChart7.Footer.Font.Bold = false;
      // 
      // 
      // 
      tChart7.Footer.Font.Brush.Color = Color.FromArgb(192, 192, 192);
      tChart7.Footer.Font.Brush.Solid = true;
      tChart7.Footer.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart7.Footer.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart7.Footer.Font.Shadow.Brush.Solid = true;
      tChart7.Footer.Font.Shadow.Brush.Visible = true;
      tChart7.Footer.Font.Size = 8;
      tChart7.Footer.Font.SizeFloat = 8F;
      tChart7.Footer.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart7.Footer.ImageBevel.Brush.Color = Color.LightGray;
      tChart7.Footer.ImageBevel.Brush.Solid = true;
      tChart7.Footer.ImageBevel.Brush.Visible = true;
      tChart7.Footer.Lines = new string[]
  {
    "Cycles"
  };
      // 
      // 
      // 
      // 
      // 
      // 
      tChart7.Footer.Shadow.Brush.Color = Color.DarkGray;
      tChart7.Footer.Shadow.Brush.Solid = true;
      tChart7.Footer.Shadow.Brush.Visible = true;
      tChart7.Footer.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart7.Header.Brush.Color = Color.FromArgb(192, 192, 192);
      // 
      // 
      // 
      tChart7.Header.Brush.Gradient.SigmaFocus = 0F;
      tChart7.Header.Brush.Gradient.SigmaScale = 0F;
      tChart7.Header.Brush.Solid = true;
      tChart7.Header.Brush.Visible = true;
      // 
      // 
      // 
      tChart7.Header.Font.Bold = false;
      // 
      // 
      // 
      tChart7.Header.Font.Brush.Color = Color.FromArgb(255, 255, 255);
      tChart7.Header.Font.Brush.Solid = true;
      tChart7.Header.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart7.Header.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart7.Header.Font.Shadow.Brush.Solid = true;
      tChart7.Header.Font.Shadow.Brush.Visible = true;
      tChart7.Header.Font.Size = 8;
      tChart7.Header.Font.SizeFloat = 8F;
      tChart7.Header.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart7.Header.ImageBevel.Brush.Color = Color.LightGray;
      tChart7.Header.ImageBevel.Brush.Solid = true;
      tChart7.Header.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart7.Header.Shadow.Brush.Color = Color.FromArgb(169, 169, 169);
      tChart7.Header.Shadow.Brush.Solid = true;
      tChart7.Header.Shadow.Brush.Visible = true;
      tChart7.Header.Shadow.Height = 0;
      tChart7.Header.Shadow.Width = 0;
      tChart7.Header.Visible = false;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart7.Legend.Brush.Color = Color.White;
      // 
      // 
      // 
      tChart7.Legend.Brush.Gradient.SigmaFocus = 0F;
      tChart7.Legend.Brush.Gradient.SigmaScale = 0F;
      tChart7.Legend.Brush.Gradient.Visible = true;
      tChart7.Legend.Brush.Solid = true;
      tChart7.Legend.Brush.Visible = true;
      tChart7.Legend.CheckBoxes = false;
      tChart7.Legend.ClipText = false;
      // 
      // 
      // 
      tChart7.Legend.Font.Bold = false;
      // 
      // 
      // 
      tChart7.Legend.Font.Brush.Color = Color.FromArgb(255, 255, 255);
      tChart7.Legend.Font.Brush.Solid = true;
      tChart7.Legend.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart7.Legend.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart7.Legend.Font.Shadow.Brush.Solid = true;
      tChart7.Legend.Font.Shadow.Brush.Visible = true;
      tChart7.Legend.Font.Size = 8;
      tChart7.Legend.Font.SizeFloat = 8F;
      tChart7.Legend.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart7.Legend.ImageBevel.Brush.Color = Color.LightGray;
      tChart7.Legend.ImageBevel.Brush.Solid = true;
      tChart7.Legend.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart7.Legend.Shadow.Brush.Color = Color.FromArgb(0, 0, 0);
      tChart7.Legend.Shadow.Brush.Solid = true;
      tChart7.Legend.Shadow.Brush.Visible = true;
      tChart7.Legend.Shadow.Width = 0;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      tChart7.Legend.Symbol.Shadow.Brush.Color = Color.DarkGray;
      tChart7.Legend.Symbol.Shadow.Brush.Solid = true;
      tChart7.Legend.Symbol.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart7.Legend.Title.Brush.Color = Color.White;
      tChart7.Legend.Title.Brush.Solid = true;
      tChart7.Legend.Title.Brush.Visible = true;
      // 
      // 
      // 
      tChart7.Legend.Title.Font.Bold = true;
      // 
      // 
      // 
      tChart7.Legend.Title.Font.Brush.Color = Color.Black;
      tChart7.Legend.Title.Font.Brush.Solid = true;
      tChart7.Legend.Title.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart7.Legend.Title.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart7.Legend.Title.Font.Shadow.Brush.Solid = true;
      tChart7.Legend.Title.Font.Shadow.Brush.Visible = true;
      tChart7.Legend.Title.Font.Size = 8;
      tChart7.Legend.Title.Font.SizeFloat = 8F;
      tChart7.Legend.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Bold;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart7.Legend.Title.ImageBevel.Brush.Color = Color.LightGray;
      tChart7.Legend.Title.ImageBevel.Brush.Solid = true;
      tChart7.Legend.Title.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart7.Legend.Title.Shadow.Brush.Color = Color.DarkGray;
      tChart7.Legend.Title.Shadow.Brush.Solid = true;
      tChart7.Legend.Title.Shadow.Brush.Visible = true;
      tChart7.Legend.Visible = false;
      tChart7.Location = new Point(0, 25);
      tChart7.Name = "tChart7";
      // 
      // 
      // 
      // 
      // 
      // 
      tChart7.Panel.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.Raised;
      // 
      // 
      // 
      tChart7.Panel.Brush.Color = Color.FromArgb(240, 240, 240);
      // 
      // 
      // 
      tChart7.Panel.Brush.Gradient.EndColor = Color.FromArgb(70, 70, 70);
      tChart7.Panel.Brush.Gradient.MiddleColor = Color.FromArgb(0, 0, 0, 0);
      tChart7.Panel.Brush.Gradient.SigmaFocus = 0F;
      tChart7.Panel.Brush.Gradient.SigmaScale = 0F;
      tChart7.Panel.Brush.Gradient.StartColor = Color.FromArgb(70, 70, 70);
      tChart7.Panel.Brush.Gradient.UseMiddle = false;
      tChart7.Panel.Brush.Gradient.Visible = true;
      tChart7.Panel.Brush.Solid = true;
      tChart7.Panel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart7.Panel.ImageBevel.Brush.Color = Color.LightGray;
      tChart7.Panel.ImageBevel.Brush.Solid = true;
      tChart7.Panel.ImageBevel.Brush.Visible = true;
      tChart7.Panel.MarginBottom = 7D;
      tChart7.Panel.MarginLeft = 2D;
      tChart7.Panel.MarginRight = 6D;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart7.Panel.Shadow.Brush.Color = Color.DarkGray;
      tChart7.Panel.Shadow.Brush.Solid = true;
      tChart7.Panel.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      margins1.Bottom = 100;
      margins1.Left = 100;
      margins1.Right = 100;
      margins1.Top = 100;
      tChart7.Printer.Margins = margins1;
      tChart7.Series.Add(area1);
      tChart7.Series.Add(line1);
      tChart7.Series.Add(line2);
      tChart7.Series.Add(bar3D1);
      tChart7.Size = new Size(1427, 764);
      // 
      // 
      // 
      // 
      // 
      // 
      tChart7.SubFooter.Brush.Color = Color.Silver;
      tChart7.SubFooter.Brush.Solid = true;
      tChart7.SubFooter.Brush.Visible = true;
      // 
      // 
      // 
      tChart7.SubFooter.Font.Bold = false;
      // 
      // 
      // 
      tChart7.SubFooter.Font.Brush.Color = Color.Red;
      tChart7.SubFooter.Font.Brush.Solid = true;
      tChart7.SubFooter.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart7.SubFooter.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart7.SubFooter.Font.Shadow.Brush.Solid = true;
      tChart7.SubFooter.Font.Shadow.Brush.Visible = true;
      tChart7.SubFooter.Font.Size = 8;
      tChart7.SubFooter.Font.SizeFloat = 8F;
      tChart7.SubFooter.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart7.SubFooter.ImageBevel.Brush.Color = Color.LightGray;
      tChart7.SubFooter.ImageBevel.Brush.Solid = true;
      tChart7.SubFooter.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart7.SubFooter.Shadow.Brush.Color = Color.DarkGray;
      tChart7.SubFooter.Shadow.Brush.Solid = true;
      tChart7.SubFooter.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart7.SubHeader.Brush.Color = Color.FromArgb(192, 192, 192);
      tChart7.SubHeader.Brush.Solid = true;
      tChart7.SubHeader.Brush.Visible = true;
      // 
      // 
      // 
      tChart7.SubHeader.Font.Bold = false;
      // 
      // 
      // 
      tChart7.SubHeader.Font.Brush.Color = Color.FromArgb(128, 128, 128);
      tChart7.SubHeader.Font.Brush.Solid = true;
      tChart7.SubHeader.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart7.SubHeader.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart7.SubHeader.Font.Shadow.Brush.Solid = true;
      tChart7.SubHeader.Font.Shadow.Brush.Visible = true;
      tChart7.SubHeader.Font.Size = 12;
      tChart7.SubHeader.Font.SizeFloat = 12F;
      tChart7.SubHeader.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart7.SubHeader.ImageBevel.Brush.Color = Color.LightGray;
      tChart7.SubHeader.ImageBevel.Brush.Solid = true;
      tChart7.SubHeader.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart7.SubHeader.Shadow.Brush.Color = Color.FromArgb(169, 169, 169);
      tChart7.SubHeader.Shadow.Brush.Solid = true;
      tChart7.SubHeader.Shadow.Brush.Visible = true;
      tChart7.TabIndex = 0;
      tChart7.Tools.Add(cursorTool1);
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      tChart7.Walls.Back.Brush.Color = Color.Silver;
      // 
      // 
      // 
      tChart7.Walls.Back.Brush.Gradient.EndColor = Color.FromArgb(120, 120, 120);
      tChart7.Walls.Back.Brush.Gradient.StartColor = Color.FromArgb(70, 70, 70);
      tChart7.Walls.Back.Brush.Solid = true;
      tChart7.Walls.Back.Brush.Visible = false;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart7.Walls.Back.ImageBevel.Brush.Color = Color.LightGray;
      tChart7.Walls.Back.ImageBevel.Brush.Solid = true;
      tChart7.Walls.Back.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart7.Walls.Back.Shadow.Brush.Color = Color.DarkGray;
      tChart7.Walls.Back.Shadow.Brush.Solid = true;
      tChart7.Walls.Back.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart7.Walls.Bottom.Brush.Color = Color.White;
      // 
      // 
      // 
      tChart7.Walls.Bottom.Brush.Gradient.SigmaFocus = 0F;
      tChart7.Walls.Bottom.Brush.Gradient.SigmaScale = 0F;
      tChart7.Walls.Bottom.Brush.Solid = true;
      tChart7.Walls.Bottom.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart7.Walls.Bottom.ImageBevel.Brush.Color = Color.LightGray;
      tChart7.Walls.Bottom.ImageBevel.Brush.Solid = true;
      tChart7.Walls.Bottom.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart7.Walls.Bottom.Shadow.Brush.Color = Color.DarkGray;
      tChart7.Walls.Bottom.Shadow.Brush.Solid = true;
      tChart7.Walls.Bottom.Shadow.Brush.Visible = true;
      tChart7.Walls.Bottom.Visible = false;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart7.Walls.Left.Brush.Color = Color.LightYellow;
      // 
      // 
      // 
      tChart7.Walls.Left.Brush.Gradient.SigmaFocus = 0F;
      tChart7.Walls.Left.Brush.Gradient.SigmaScale = 0F;
      tChart7.Walls.Left.Brush.Solid = true;
      tChart7.Walls.Left.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart7.Walls.Left.ImageBevel.Brush.Color = Color.LightGray;
      tChart7.Walls.Left.ImageBevel.Brush.Solid = true;
      tChart7.Walls.Left.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart7.Walls.Left.Shadow.Brush.Color = Color.DarkGray;
      tChart7.Walls.Left.Shadow.Brush.Solid = true;
      tChart7.Walls.Left.Shadow.Brush.Visible = true;
      tChart7.Walls.Left.Visible = false;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart7.Walls.Right.Brush.Color = Color.FromArgb(192, 192, 192);
      // 
      // 
      // 
      tChart7.Walls.Right.Brush.Gradient.SigmaFocus = 0F;
      tChart7.Walls.Right.Brush.Gradient.SigmaScale = 0F;
      tChart7.Walls.Right.Brush.Solid = true;
      tChart7.Walls.Right.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart7.Walls.Right.ImageBevel.Brush.Color = Color.LightGray;
      tChart7.Walls.Right.ImageBevel.Brush.Solid = true;
      tChart7.Walls.Right.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart7.Walls.Right.Shadow.Brush.Color = Color.DarkGray;
      tChart7.Walls.Right.Shadow.Brush.Solid = true;
      tChart7.Walls.Right.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart7.Zoom.Brush.Color = Color.FromArgb(127, 0, 0, 255);
      tChart7.Zoom.Brush.Solid = true;
      tChart7.Zoom.Brush.Visible = false;
      tChart7.AfterDraw += tChart7_AfterDraw;
      // 
      // axis1
      // 
      // 
      // 
      // 
      axis1.AxisPen.Color = Color.FromArgb(255, 128, 0);
      axis1.AxisPen.Visible = true;
      axis1.EndPosition = 70D;
      // 
      // 
      // 
      axis1.Grid.Visible = false;
      axis1.Horizontal = false;
      // 
      // 
      // 
      // 
      // 
      // 
      axis1.Labels.Brush.Color = Color.White;
      axis1.Labels.Brush.Solid = true;
      axis1.Labels.Brush.Visible = true;
      // 
      // 
      // 
      axis1.Labels.Font.Bold = false;
      // 
      // 
      // 
      axis1.Labels.Font.Brush.Color = Color.FromArgb(192, 192, 192);
      axis1.Labels.Font.Brush.Solid = true;
      axis1.Labels.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      axis1.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
      axis1.Labels.Font.Shadow.Brush.Solid = true;
      axis1.Labels.Font.Shadow.Brush.Visible = true;
      axis1.Labels.Font.Size = 9;
      axis1.Labels.Font.SizeFloat = 9F;
      axis1.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      axis1.Labels.ImageBevel.Brush.Color = Color.LightGray;
      axis1.Labels.ImageBevel.Brush.Solid = true;
      axis1.Labels.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      axis1.Labels.Shadow.Brush.Color = Color.DarkGray;
      axis1.Labels.Shadow.Brush.Solid = true;
      axis1.Labels.Shadow.Brush.Visible = true;
      axis1.OtherSide = true;
      axis1.RelativePosition = -5D;
      // 
      // 
      // 
      axis1.Title.Angle = 270;
      // 
      // 
      // 
      axis1.Title.Brush.Color = Color.Silver;
      axis1.Title.Brush.Solid = true;
      axis1.Title.Brush.Visible = true;
      axis1.Title.Caption = "Freq. Hz.";
      // 
      // 
      // 
      axis1.Title.Font.Bold = false;
      // 
      // 
      // 
      axis1.Title.Font.Brush.Color = Color.FromArgb(255, 255, 255);
      axis1.Title.Font.Brush.Solid = true;
      axis1.Title.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      axis1.Title.Font.Shadow.Brush.Color = Color.DarkGray;
      axis1.Title.Font.Shadow.Brush.Solid = true;
      axis1.Title.Font.Shadow.Brush.Visible = true;
      axis1.Title.Font.Size = 8;
      axis1.Title.Font.SizeFloat = 8F;
      axis1.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      axis1.Title.ImageBevel.Brush.Color = Color.LightGray;
      axis1.Title.ImageBevel.Brush.Solid = true;
      axis1.Title.ImageBevel.Brush.Visible = true;
      axis1.Title.Lines = new string[]
  {
    "Freq. Hz."
  };
      // 
      // 
      // 
      // 
      // 
      // 
      axis1.Title.Shadow.Brush.Color = Color.DarkGray;
      axis1.Title.Shadow.Brush.Solid = true;
      axis1.Title.Shadow.Brush.Visible = true;
      axis1.ZPosition = 0D;
      // 
      // axis2
      // 
      // 
      // 
      // 
      axis2.AxisPen.Color = Color.FromArgb(192, 192, 255);
      axis2.AxisPen.Visible = true;
      axis2.Horizontal = false;
      // 
      // 
      // 
      // 
      // 
      // 
      axis2.Labels.Brush.Color = Color.White;
      axis2.Labels.Brush.Solid = true;
      axis2.Labels.Brush.Visible = true;
      // 
      // 
      // 
      axis2.Labels.Font.Bold = false;
      // 
      // 
      // 
      axis2.Labels.Font.Brush.Color = Color.FromArgb(192, 192, 192);
      axis2.Labels.Font.Brush.Solid = true;
      axis2.Labels.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      axis2.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
      axis2.Labels.Font.Shadow.Brush.Solid = true;
      axis2.Labels.Font.Shadow.Brush.Visible = true;
      axis2.Labels.Font.Size = 9;
      axis2.Labels.Font.SizeFloat = 9F;
      axis2.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      axis2.Labels.ImageBevel.Brush.Color = Color.LightGray;
      axis2.Labels.ImageBevel.Brush.Solid = true;
      axis2.Labels.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      axis2.Labels.Shadow.Brush.Color = Color.DarkGray;
      axis2.Labels.Shadow.Brush.Solid = true;
      axis2.Labels.Shadow.Brush.Visible = true;
      axis2.OtherSide = false;
      axis2.StartPosition = 72D;
      // 
      // 
      // 
      axis2.Title.Angle = 90;
      // 
      // 
      // 
      axis2.Title.Brush.Color = Color.Silver;
      axis2.Title.Brush.Solid = true;
      axis2.Title.Brush.Visible = true;
      axis2.Title.Caption = "Buffer range";
      // 
      // 
      // 
      axis2.Title.Font.Bold = false;
      // 
      // 
      // 
      axis2.Title.Font.Brush.Color = Color.FromArgb(255, 255, 255);
      axis2.Title.Font.Brush.Solid = true;
      axis2.Title.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      axis2.Title.Font.Shadow.Brush.Color = Color.DarkGray;
      axis2.Title.Font.Shadow.Brush.Solid = true;
      axis2.Title.Font.Shadow.Brush.Visible = true;
      axis2.Title.Font.Size = 8;
      axis2.Title.Font.SizeFloat = 8F;
      axis2.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      axis2.Title.ImageBevel.Brush.Color = Color.LightGray;
      axis2.Title.ImageBevel.Brush.Solid = true;
      axis2.Title.ImageBevel.Brush.Visible = true;
      axis2.Title.Lines = new string[]
  {
    "Buffer range"
  };
      // 
      // 
      // 
      // 
      // 
      // 
      axis2.Title.Shadow.Brush.Color = Color.DarkGray;
      axis2.Title.Shadow.Brush.Solid = true;
      axis2.Title.Shadow.Brush.Visible = true;
      // 
      // area1
      // 
      // 
      // 
      // 
      area1.AreaBrush.Color = Color.FromArgb(119, 153, 214);
      // 
      // 
      // 
      area1.Gradient.Transparency = 20;
      area1.Gradient.Visible = true;
      area1.AreaBrush.Solid = false;
      area1.AreaBrush.Visible = false;
      // 
      // 
      // 
      area1.AreaLines.Color = Color.FromArgb(71, 92, 128);
      area1.AreaLines.Visible = false;
      // 
      // 
      // 
      area1.Brush.Color = Color.FromArgb(119, 153, 214);
      area1.Brush.Solid = true;
      area1.Brush.Visible = true;
      area1.Color = Color.FromArgb(119, 153, 214);
      area1.Cursor = cursor1;
      // 
      // 
      // 
      // 
      // 
      // 
      area1.Legend.Brush.Color = Color.White;
      area1.Legend.Brush.Solid = true;
      area1.Legend.Brush.Visible = true;
      // 
      // 
      // 
      area1.Legend.Font.Bold = false;
      // 
      // 
      // 
      area1.Legend.Font.Brush.Color = Color.Black;
      area1.Legend.Font.Brush.Solid = true;
      area1.Legend.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      area1.Legend.Font.Shadow.Brush.Color = Color.DarkGray;
      area1.Legend.Font.Shadow.Brush.Solid = true;
      area1.Legend.Font.Shadow.Brush.Visible = true;
      area1.Legend.Font.Size = 8;
      area1.Legend.Font.SizeFloat = 8F;
      area1.Legend.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      area1.Legend.ImageBevel.Brush.Color = Color.LightGray;
      area1.Legend.ImageBevel.Brush.Solid = true;
      area1.Legend.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      area1.Legend.Shadow.Brush.Color = Color.DarkGray;
      area1.Legend.Shadow.Brush.Solid = true;
      area1.Legend.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      area1.Marks.Brush.Color = Color.FromArgb(255, 255, 255);
      area1.Marks.Brush.Solid = true;
      area1.Marks.Brush.Visible = true;
      // 
      // 
      // 
      area1.Marks.Font.Bold = false;
      // 
      // 
      // 
      area1.Marks.Font.Brush.Color = Color.Black;
      area1.Marks.Font.Brush.Solid = true;
      area1.Marks.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      area1.Marks.Font.Shadow.Brush.Color = Color.DarkGray;
      area1.Marks.Font.Shadow.Brush.Solid = true;
      area1.Marks.Font.Shadow.Brush.Visible = true;
      area1.Marks.Font.Size = 8;
      area1.Marks.Font.SizeFloat = 8F;
      area1.Marks.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      area1.Marks.ImageBevel.Brush.Color = Color.LightGray;
      area1.Marks.ImageBevel.Brush.Solid = true;
      area1.Marks.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      area1.Marks.Shadow.Brush.Color = Color.Gray;
      area1.Marks.Shadow.Brush.Solid = true;
      area1.Marks.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      area1.Marks.Symbol.Brush.Color = Color.White;
      area1.Marks.Symbol.Brush.Solid = true;
      area1.Marks.Symbol.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      area1.Marks.Symbol.ImageBevel.Brush.Color = Color.LightGray;
      area1.Marks.Symbol.ImageBevel.Brush.Solid = true;
      area1.Marks.Symbol.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      area1.Marks.Symbol.Shadow.Brush.Color = Color.DarkGray;
      area1.Marks.Symbol.Shadow.Brush.Solid = true;
      area1.Marks.Symbol.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      area1.Pointer.Brush.Color = Color.FromArgb(255, 255, 255);
      area1.Pointer.Brush.Solid = true;
      area1.Pointer.Brush.Visible = true;
      area1.Title = "area1";
      // 
      // 
      // 
      area1.XValues.DataMember = "X";
      area1.XValues.DateTime = true;
      area1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
      area1.XValues.Value = new double[]
  {
    46132.712322037034D,
    46133.712322037034D,
    46134.712322037034D,
    46135.712322037034D,
    46136.712322037034D,
    46137.712322037034D,
    46138.712322037034D,
    46139.712322037034D,
    46140.712322037034D,
    46141.712322037034D,
    46142.712322037034D,
    46143.712322037034D,
    46144.712322037034D,
    46145.712322037034D,
    46146.712322037034D,
    46147.712322037034D,
    46148.712322037034D,
    46149.712322037034D,
    46150.712322037034D,
    46151.712322037034D,
    46152.712322037034D,
    46153.712322037034D,
    46154.712322037034D,
    46155.712322037034D,
    46156.712322037034D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D
  };
      // 
      // 
      // 
      area1.YValues.DataMember = "Y";
      area1.YValues.Value = new double[]
  {
    550D,
    491D,
    401D,
    373D,
    257D,
    368D,
    296D,
    300D,
    267D,
    335D,
    347D,
    444D,
    461D,
    471D,
    449D,
    355D,
    480D,
    380D,
    465D,
    399D,
    431D,
    320D,
    362D,
    343D,
    269D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D
  };
      // 
      // line1
      // 
      // 
      // 
      // 
      line1.AreaBrush.Color = Color.White;
      line1.AreaBrush.Solid = true;
      line1.AreaBrush.Visible = false;
      // 
      // 
      // 
      line1.Brush.Color = Color.FromArgb(255, 207, 104);
      line1.Brush.Solid = true;
      line1.Brush.Visible = true;
      line1.Color = Color.FromArgb(255, 207, 104);
      line1.Cursor = cursor1;
      // 
      // 
      // 
      // 
      // 
      // 
      line1.Legend.Brush.Color = Color.White;
      line1.Legend.Brush.Solid = true;
      line1.Legend.Brush.Visible = true;
      // 
      // 
      // 
      line1.Legend.Font.Bold = false;
      // 
      // 
      // 
      line1.Legend.Font.Brush.Color = Color.Black;
      line1.Legend.Font.Brush.Solid = true;
      line1.Legend.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      line1.Legend.Font.Shadow.Brush.Color = Color.DarkGray;
      line1.Legend.Font.Shadow.Brush.Solid = true;
      line1.Legend.Font.Shadow.Brush.Visible = true;
      line1.Legend.Font.Size = 8;
      line1.Legend.Font.SizeFloat = 8F;
      line1.Legend.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      line1.Legend.ImageBevel.Brush.Color = Color.LightGray;
      line1.Legend.ImageBevel.Brush.Solid = true;
      line1.Legend.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      line1.Legend.Shadow.Brush.Color = Color.DarkGray;
      line1.Legend.Shadow.Brush.Solid = true;
      line1.Legend.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      line1.LinePen.Width = 2;
      // 
      // 
      // 
      // 
      // 
      // 
      line1.Marks.Brush.Color = Color.FromArgb(255, 255, 255);
      line1.Marks.Brush.Solid = true;
      line1.Marks.Brush.Visible = true;
      // 
      // 
      // 
      line1.Marks.Font.Bold = false;
      // 
      // 
      // 
      line1.Marks.Font.Brush.Color = Color.Black;
      line1.Marks.Font.Brush.Solid = true;
      line1.Marks.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      line1.Marks.Font.Shadow.Brush.Color = Color.DarkGray;
      line1.Marks.Font.Shadow.Brush.Solid = true;
      line1.Marks.Font.Shadow.Brush.Visible = true;
      line1.Marks.Font.Size = 8;
      line1.Marks.Font.SizeFloat = 8F;
      line1.Marks.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      line1.Marks.ImageBevel.Brush.Color = Color.LightGray;
      line1.Marks.ImageBevel.Brush.Solid = true;
      line1.Marks.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      line1.Marks.Shadow.Brush.Color = Color.Gray;
      line1.Marks.Shadow.Brush.Solid = true;
      line1.Marks.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      line1.Marks.Symbol.Brush.Color = Color.White;
      line1.Marks.Symbol.Brush.Solid = true;
      line1.Marks.Symbol.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      line1.Marks.Symbol.ImageBevel.Brush.Color = Color.LightGray;
      line1.Marks.Symbol.ImageBevel.Brush.Solid = true;
      line1.Marks.Symbol.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      line1.Marks.Symbol.Shadow.Brush.Color = Color.DarkGray;
      line1.Marks.Symbol.Shadow.Brush.Solid = true;
      line1.Marks.Symbol.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      line1.Pointer.Brush.Color = Color.FromArgb(255, 255, 255);
      line1.Pointer.Brush.Solid = true;
      line1.Pointer.Brush.Visible = true;
      line1.Title = "line1";
      line1.VertAxis = Steema.TeeChart.Styles.VerticalAxis.Right;
      // 
      // 
      // 
      line1.XValues.DataMember = "X";
      line1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
      line1.XValues.Value = new double[]
  {
    46132.712322037034D,
    46133.712322037034D,
    46134.712322037034D,
    46135.712322037034D,
    46136.712322037034D,
    46137.712322037034D,
    46138.712322037034D,
    46139.712322037034D,
    46140.712322037034D,
    46141.712322037034D,
    46142.712322037034D,
    46143.712322037034D,
    46144.712322037034D,
    46145.712322037034D,
    46146.712322037034D,
    46147.712322037034D,
    46148.712322037034D,
    46149.712322037034D,
    46150.712322037034D,
    46151.712322037034D,
    46152.712322037034D,
    46153.712322037034D,
    46154.712322037034D,
    46155.712322037034D,
    46156.712322037034D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D
  };
      // 
      // 
      // 
      line1.YValues.DataMember = "Y";
      line1.YValues.Value = new double[]
  {
    604D,
    606D,
    639D,
    752D,
    789D,
    829D,
    783D,
    732D,
    747D,
    742D,
    776D,
    792D,
    802D,
    771D,
    765D,
    860D,
    848D,
    967D,
    878D,
    939D,
    870D,
    950D,
    962D,
    931D,
    1033D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D
  };
      // 
      // line2
      // 
      // 
      // 
      // 
      line2.AreaBrush.Color = Color.White;
      line2.AreaBrush.Solid = true;
      line2.AreaBrush.Visible = false;
      // 
      // 
      // 
      line2.Brush.Color = Color.FromArgb(255, 127, 71);
      line2.Brush.Solid = true;
      line2.Brush.Visible = true;
      line2.Color = Color.FromArgb(255, 127, 71);
      line2.Cursor = cursor1;
      line2.CustomVertAxis = axis1;
      // 
      // 
      // 
      // 
      // 
      // 
      line2.Legend.Brush.Color = Color.White;
      line2.Legend.Brush.Solid = true;
      line2.Legend.Brush.Visible = true;
      // 
      // 
      // 
      line2.Legend.Font.Bold = false;
      // 
      // 
      // 
      line2.Legend.Font.Brush.Color = Color.Black;
      line2.Legend.Font.Brush.Solid = true;
      line2.Legend.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      line2.Legend.Font.Shadow.Brush.Color = Color.DarkGray;
      line2.Legend.Font.Shadow.Brush.Solid = true;
      line2.Legend.Font.Shadow.Brush.Visible = true;
      line2.Legend.Font.Size = 8;
      line2.Legend.Font.SizeFloat = 8F;
      line2.Legend.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      line2.Legend.ImageBevel.Brush.Color = Color.LightGray;
      line2.Legend.ImageBevel.Brush.Solid = true;
      line2.Legend.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      line2.Legend.Shadow.Brush.Color = Color.DarkGray;
      line2.Legend.Shadow.Brush.Solid = true;
      line2.Legend.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      line2.LinePen.Width = 2;
      // 
      // 
      // 
      // 
      // 
      // 
      line2.Marks.Brush.Color = Color.FromArgb(255, 255, 255);
      line2.Marks.Brush.Solid = true;
      line2.Marks.Brush.Visible = true;
      // 
      // 
      // 
      line2.Marks.Font.Bold = false;
      // 
      // 
      // 
      line2.Marks.Font.Brush.Color = Color.Black;
      line2.Marks.Font.Brush.Solid = true;
      line2.Marks.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      line2.Marks.Font.Shadow.Brush.Color = Color.DarkGray;
      line2.Marks.Font.Shadow.Brush.Solid = true;
      line2.Marks.Font.Shadow.Brush.Visible = true;
      line2.Marks.Font.Size = 8;
      line2.Marks.Font.SizeFloat = 8F;
      line2.Marks.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      line2.Marks.ImageBevel.Brush.Color = Color.LightGray;
      line2.Marks.ImageBevel.Brush.Solid = true;
      line2.Marks.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      line2.Marks.Shadow.Brush.Color = Color.Gray;
      line2.Marks.Shadow.Brush.Solid = true;
      line2.Marks.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      line2.Marks.Symbol.Brush.Color = Color.White;
      line2.Marks.Symbol.Brush.Solid = true;
      line2.Marks.Symbol.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      line2.Marks.Symbol.ImageBevel.Brush.Color = Color.LightGray;
      line2.Marks.Symbol.ImageBevel.Brush.Solid = true;
      line2.Marks.Symbol.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      line2.Marks.Symbol.Shadow.Brush.Color = Color.DarkGray;
      line2.Marks.Symbol.Shadow.Brush.Solid = true;
      line2.Marks.Symbol.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      line2.Pointer.Brush.Color = Color.FromArgb(255, 255, 255);
      line2.Pointer.Brush.Solid = true;
      line2.Pointer.Brush.Visible = true;
      line2.Title = "line2";
      line2.VertAxis = Steema.TeeChart.Styles.VerticalAxis.Custom;
      // 
      // 
      // 
      line2.XValues.DataMember = "X";
      line2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
      line2.XValues.Value = new double[]
  {
    46132.712322037034D,
    46133.712322037034D,
    46134.712322037034D,
    46135.712322037034D,
    46136.712322037034D,
    46137.712322037034D,
    46138.712322037034D,
    46139.712322037034D,
    46140.712322037034D,
    46141.712322037034D,
    46142.712322037034D,
    46143.712322037034D,
    46144.712322037034D,
    46145.712322037034D,
    46146.712322037034D,
    46147.712322037034D,
    46148.712322037034D,
    46149.712322037034D,
    46150.712322037034D,
    46151.712322037034D,
    46152.712322037034D,
    46153.712322037034D,
    46154.712322037034D,
    46155.712322037034D,
    46156.712322037034D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D
  };
      // 
      // 
      // 
      line2.YValues.DataMember = "Y";
      line2.YValues.Value = new double[]
  {
    275D,
    306D,
    186D,
    94D,
    202D,
    256D,
    207D,
    86D,
    140D,
    32D,
    28D,
    79D,
    195D,
    111D,
    211D,
    216D,
    249D,
    282D,
    296D,
    394D,
    516D,
    515D,
    504D,
    462D,
    467D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D
  };
      // 
      // bar3D1
      // 
      bar3D1.BarRound = Steema.TeeChart.Styles.BarRounding.AtValue;
      // 
      // 
      // 
      bar3D1.Brush.Color = Color.FromArgb(129, 202, 219);
      bar3D1.Brush.Solid = true;
      bar3D1.Brush.Visible = true;
      bar3D1.Color = Color.FromArgb(129, 202, 219);
      bar3D1.Cursor = cursor1;
      bar3D1.CustomVertAxis = axis2;
      // 
      // 
      // 
      // 
      // 
      // 
      bar3D1.Legend.Brush.Color = Color.White;
      bar3D1.Legend.Brush.Solid = true;
      bar3D1.Legend.Brush.Visible = true;
      // 
      // 
      // 
      bar3D1.Legend.Font.Bold = false;
      // 
      // 
      // 
      bar3D1.Legend.Font.Brush.Color = Color.Black;
      bar3D1.Legend.Font.Brush.Solid = true;
      bar3D1.Legend.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      bar3D1.Legend.Font.Shadow.Brush.Color = Color.DarkGray;
      bar3D1.Legend.Font.Shadow.Brush.Solid = true;
      bar3D1.Legend.Font.Shadow.Brush.Visible = true;
      bar3D1.Legend.Font.Size = 8;
      bar3D1.Legend.Font.SizeFloat = 8F;
      bar3D1.Legend.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      bar3D1.Legend.ImageBevel.Brush.Color = Color.LightGray;
      bar3D1.Legend.ImageBevel.Brush.Solid = true;
      bar3D1.Legend.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      bar3D1.Legend.Shadow.Brush.Color = Color.DarkGray;
      bar3D1.Legend.Shadow.Brush.Solid = true;
      bar3D1.Legend.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      bar3D1.Marks.Brush.Color = Color.FromArgb(255, 255, 255);
      bar3D1.Marks.Brush.Solid = true;
      bar3D1.Marks.Brush.Visible = true;
      // 
      // 
      // 
      bar3D1.Marks.Font.Bold = false;
      // 
      // 
      // 
      bar3D1.Marks.Font.Brush.Color = Color.Black;
      bar3D1.Marks.Font.Brush.Solid = true;
      bar3D1.Marks.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      bar3D1.Marks.Font.Shadow.Brush.Color = Color.DarkGray;
      bar3D1.Marks.Font.Shadow.Brush.Solid = true;
      bar3D1.Marks.Font.Shadow.Brush.Visible = true;
      bar3D1.Marks.Font.Size = 8;
      bar3D1.Marks.Font.SizeFloat = 8F;
      bar3D1.Marks.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      bar3D1.Marks.ImageBevel.Brush.Color = Color.LightGray;
      bar3D1.Marks.ImageBevel.Brush.Solid = true;
      bar3D1.Marks.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      bar3D1.Marks.Shadow.Brush.Color = Color.Gray;
      bar3D1.Marks.Shadow.Brush.Solid = true;
      bar3D1.Marks.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      bar3D1.Marks.Symbol.Brush.Color = Color.White;
      bar3D1.Marks.Symbol.Brush.Solid = true;
      bar3D1.Marks.Symbol.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      bar3D1.Marks.Symbol.ImageBevel.Brush.Color = Color.LightGray;
      bar3D1.Marks.Symbol.ImageBevel.Brush.Solid = true;
      bar3D1.Marks.Symbol.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      bar3D1.Marks.Symbol.Shadow.Brush.Color = Color.DarkGray;
      bar3D1.Marks.Symbol.Shadow.Brush.Solid = true;
      bar3D1.Marks.Symbol.Shadow.Brush.Visible = true;
      bar3D1.Marks.Visible = false;
      // 
      // 
      // 
      // 
      // 
      // 
      bar3D1.Shadow.Brush.Color = Color.DarkGray;
      bar3D1.Shadow.Brush.Solid = true;
      bar3D1.Shadow.Brush.Visible = true;
      bar3D1.Title = "bar3D1";
      bar3D1.VertAxis = Steema.TeeChart.Styles.VerticalAxis.Custom;
      // 
      // 
      // 
      bar3D1.XValues.DataMember = "X";
      bar3D1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
      bar3D1.XValues.Value = new double[]
  {
    46132.712322037034D,
    46137.512322037037D,
    46142.31232203704D,
    46147.112322037043D,
    46151.912322037046D,
    46156.712322037049D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D
  };
      // 
      // 
      // 
      bar3D1.YValues.DataMember = "Bar";
      bar3D1.YValues.Value = new double[]
  {
    423.85796592284828D,
    934.217835033414D,
    904.78973899725349D,
    537.69680438921637D,
    404.74424179398653D,
    601.24002493510022D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D
  };
      // 
      // cursorTool1
      // 
      cursorTool1.FastCursor = false;
      // 
      // 
      // 
      cursorTool1.Pen.Color = Color.FromArgb(255, 255, 255);
      cursorTool1.Pen.Style = Steema.TeeChart.Drawing.DashStyle.Dash;
      cursorTool1.Series = line2;
      cursorTool1.SeriesIndex = -1;
      cursorTool1.Change += CursorTool1_Change;
      // 
      // FormMultiAxis
      // 
      AutoScaleDimensions = new SizeF(7F, 17F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(1427, 789);
      Controls.Add(tChart7);
      Controls.Add(chartController1);
      Name = "FormMultiAxis";
      Text = "Multi-axis example";
      WindowState = FormWindowState.Maximized;
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Steema.TeeChart.ChartController chartController1;
    private Steema.TeeChart.TChart tChart7;
    private Steema.TeeChart.Styles.Area area1;
    private Steema.TeeChart.Styles.Line line1;
    private Steema.TeeChart.Styles.Line line2;
    private Steema.TeeChart.Styles.Bar3D bar3D1;
    private Steema.TeeChart.Axis axis1;
    private Steema.TeeChart.Axis axis2;
    private Steema.TeeChart.Tools.CursorTool cursorTool1;
  }
}
