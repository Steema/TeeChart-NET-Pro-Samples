using System.Resources;

namespace WinAppMultiVis
{
  partial class FormMultiPanel
  {
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
      components = new System.ComponentModel.Container();
      Steema.TeeChart.Margins margins1 = new Steema.TeeChart.Margins();
      Steema.TeeChart.Drawing.Cursor cursor1 = new Steema.TeeChart.Drawing.Cursor();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMultiPanel));
      Steema.TeeChart.Margins margins2 = new Steema.TeeChart.Margins();
      Steema.TeeChart.Margins margins3 = new Steema.TeeChart.Margins();
      Steema.TeeChart.Margins margins4 = new Steema.TeeChart.Margins();
      Steema.TeeChart.Margins margins5 = new Steema.TeeChart.Margins();
      Steema.TeeChart.Margins margins6 = new Steema.TeeChart.Margins();
      Steema.TeeChart.Margins margins7 = new Steema.TeeChart.Margins();
      Steema.TeeChart.Margins margins8 = new Steema.TeeChart.Margins();
      Steema.TeeChart.Margins margins9 = new Steema.TeeChart.Margins();
      panel1 = new Panel();
      button1 = new Button();
      chartController1 = new Steema.TeeChart.ChartController();
      tChart6 = new Steema.TeeChart.TChart();
      axis3 = new Steema.TeeChart.Axis(components);
      axis4 = new Steema.TeeChart.Axis(components);
      highLow1 = new Steema.TeeChart.Styles.HighLow();
      line3 = new Steema.TeeChart.Styles.Line();
      stdDeviation2 = new Steema.TeeChart.Functions.StdDeviation();
      line4 = new Steema.TeeChart.Styles.Line();
      rootMeanSquare1 = new Steema.TeeChart.Functions.RootMeanSquare();
      colorBand1 = new Steema.TeeChart.Tools.ColorBand();
      colorBand2 = new Steema.TeeChart.Tools.ColorBand();
      annotation1 = new Steema.TeeChart.Tools.Annotation();
      annotation2 = new Steema.TeeChart.Tools.Annotation();
      tChart7 = new Steema.TeeChart.TChart();
      axis1 = new Steema.TeeChart.Axis(components);
      axis2 = new Steema.TeeChart.Axis(components);
      area1 = new Steema.TeeChart.Styles.Area();
      line1 = new Steema.TeeChart.Styles.Line();
      line2 = new Steema.TeeChart.Styles.Line();
      bar3D1 = new Steema.TeeChart.Styles.Bar3D();
      cursorTool1 = new Steema.TeeChart.Tools.CursorTool();
      tChart5 = new Steema.TeeChart.TChart();
      surface = new Steema.TeeChart.Styles.Surface();
      rotate1 = new Steema.TeeChart.Tools.Rotate();
      stdDeviation1 = new Steema.TeeChart.Functions.StdDeviation();
      tChart8 = new Steema.TeeChart.TChart();
      tChart1 = new Steema.TeeChart.TChart();
      circularGauge1 = new Steema.TeeChart.Styles.CircularGauge();
      panel2 = new Panel();
      panel8 = new Panel();
      panel7 = new Panel();
      panel3 = new Panel();
      panel6 = new Panel();
      panel5 = new Panel();
      panel4 = new Panel();
      tChart9 = new Steema.TeeChart.TChart();
      donut4 = new Steema.TeeChart.Styles.Donut();
      tChart4 = new Steema.TeeChart.TChart();
      donut3 = new Steema.TeeChart.Styles.Donut();
      tChart3 = new Steema.TeeChart.TChart();
      donut2 = new Steema.TeeChart.Styles.Donut();
      tChart2 = new Steema.TeeChart.TChart();
      donut1 = new Steema.TeeChart.Styles.Donut();
      timer1 = new System.Windows.Forms.Timer(components);
      panel1.SuspendLayout();
      panel2.SuspendLayout();
      panel8.SuspendLayout();
      panel7.SuspendLayout();
      panel3.SuspendLayout();
      panel6.SuspendLayout();
      panel5.SuspendLayout();
      panel4.SuspendLayout();
      this.SuspendLayout();
      // 
      // panel1
      // 
      panel1.Controls.Add(button1);
      panel1.Controls.Add(chartController1);
      panel1.Dock = DockStyle.Top;
      panel1.Location = new Point(0, 0);
      panel1.Name = "panel1";
      panel1.Size = new Size(1377, 36);
      panel1.TabIndex = 0;
      // 
      // button1
      // 
      button1.Anchor = (AnchorStyles)(AnchorStyles.Top) | (AnchorStyles.Right);
      button1.FlatStyle = FlatStyle.Flat;
      button1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      button1.Location = new Point(1245, 5);
      button1.Name = "button1";
      button1.Size = new Size(120, 27);
      button1.TabIndex = 1;
      button1.Text = "Engage on/off";
      button1.UseVisualStyleBackColor = true;
      button1.Click += (this.button1_Click);
      // 
      // chartController1
      // 
      chartController1.ButtonSize = Steema.TeeChart.ControllerButtonSize.x16;
      chartController1.Chart = tChart6;
      chartController1.Dock = DockStyle.Fill;
      chartController1.LabelValues = true;
      chartController1.Location = new Point(0, 0);
      chartController1.Name = "chartController1";
      chartController1.Size = new Size(1377, 36);
      chartController1.TabIndex = 0;
      chartController1.Text = "chartController1";
      // 
      // tChart6
      // 
      // 
      // 
      // 
      tChart6.Aspect.ColorPaletteIndex = -1;
      tChart6.Aspect.Elevation = 315;
      tChart6.Aspect.ElevationFloat = 315D;
      tChart6.Aspect.Orthogonal = false;
      tChart6.Aspect.Perspective = 0;
      tChart6.Aspect.Rotation = 360;
      tChart6.Aspect.RotationFloat = 360D;
      // 
      // 
      // 
      tChart6.Axes.Automatic = false;
      // 
      // 
      // 
      tChart6.Axes.Bottom.Automatic = false;
      tChart6.Axes.Bottom.AutomaticMaximum = false;
      tChart6.Axes.Bottom.AutomaticMinimum = false;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart6.Axes.Bottom.Labels.Brush.Color = Color.White;
      tChart6.Axes.Bottom.Labels.Brush.Solid = true;
      tChart6.Axes.Bottom.Labels.Brush.Visible = true;
      tChart6.Axes.Bottom.Labels.DateTimeFormat = "hh:mm:ss";
      // 
      // 
      // 
      tChart6.Axes.Bottom.Labels.Font.Bold = false;
      // 
      // 
      // 
      tChart6.Axes.Bottom.Labels.Font.Brush.Color = Color.FromArgb((int)(byte)255, (int)(byte)255, (int)(byte)255);
      tChart6.Axes.Bottom.Labels.Font.Brush.Solid = true;
      tChart6.Axes.Bottom.Labels.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart6.Axes.Bottom.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart6.Axes.Bottom.Labels.Font.Shadow.Brush.Solid = true;
      tChart6.Axes.Bottom.Labels.Font.Shadow.Brush.Visible = true;
      tChart6.Axes.Bottom.Labels.Font.Size = 8;
      tChart6.Axes.Bottom.Labels.Font.SizeFloat = 8F;
      tChart6.Axes.Bottom.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart6.Axes.Bottom.Labels.ImageBevel.Brush.Color = Color.LightGray;
      tChart6.Axes.Bottom.Labels.ImageBevel.Brush.Solid = true;
      tChart6.Axes.Bottom.Labels.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart6.Axes.Bottom.Labels.Shadow.Brush.Color = Color.DarkGray;
      tChart6.Axes.Bottom.Labels.Shadow.Brush.Solid = true;
      tChart6.Axes.Bottom.Labels.Shadow.Brush.Visible = true;
      tChart6.Axes.Bottom.Maximum = 0D;
      tChart6.Axes.Bottom.Minimum = 0D;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart6.Axes.Bottom.Title.Brush.Color = Color.Silver;
      tChart6.Axes.Bottom.Title.Brush.Solid = true;
      tChart6.Axes.Bottom.Title.Brush.Visible = true;
      // 
      // 
      // 
      tChart6.Axes.Bottom.Title.Font.Bold = false;
      // 
      // 
      // 
      tChart6.Axes.Bottom.Title.Font.Brush.Color = Color.FromArgb((int)(byte)0, (int)(byte)0, (int)(byte)0);
      tChart6.Axes.Bottom.Title.Font.Brush.Solid = true;
      tChart6.Axes.Bottom.Title.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart6.Axes.Bottom.Title.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart6.Axes.Bottom.Title.Font.Shadow.Brush.Solid = true;
      tChart6.Axes.Bottom.Title.Font.Shadow.Brush.Visible = true;
      tChart6.Axes.Bottom.Title.Font.Size = 8;
      tChart6.Axes.Bottom.Title.Font.SizeFloat = 8F;
      tChart6.Axes.Bottom.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart6.Axes.Bottom.Title.ImageBevel.Brush.Color = Color.LightGray;
      tChart6.Axes.Bottom.Title.ImageBevel.Brush.Solid = true;
      tChart6.Axes.Bottom.Title.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart6.Axes.Bottom.Title.Shadow.Brush.Color = Color.DarkGray;
      tChart6.Axes.Bottom.Title.Shadow.Brush.Solid = true;
      tChart6.Axes.Bottom.Title.Shadow.Brush.Visible = true;
      tChart6.Axes.Custom.Add(axis3);
      tChart6.Axes.Custom.Add(axis4);
      // 
      // 
      // 
      tChart6.Axes.Depth.Automatic = false;
      tChart6.Axes.Depth.AutomaticMaximum = false;
      tChart6.Axes.Depth.AutomaticMinimum = false;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart6.Axes.Depth.Labels.Brush.Color = Color.White;
      tChart6.Axes.Depth.Labels.Brush.Solid = true;
      tChart6.Axes.Depth.Labels.Brush.Visible = true;
      // 
      // 
      // 
      tChart6.Axes.Depth.Labels.Font.Bold = false;
      // 
      // 
      // 
      tChart6.Axes.Depth.Labels.Font.Brush.Color = Color.FromArgb((int)(byte)255, (int)(byte)255, (int)(byte)255);
      tChart6.Axes.Depth.Labels.Font.Brush.Solid = true;
      tChart6.Axes.Depth.Labels.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart6.Axes.Depth.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart6.Axes.Depth.Labels.Font.Shadow.Brush.Solid = true;
      tChart6.Axes.Depth.Labels.Font.Shadow.Brush.Visible = true;
      tChart6.Axes.Depth.Labels.Font.Size = 8;
      tChart6.Axes.Depth.Labels.Font.SizeFloat = 8F;
      tChart6.Axes.Depth.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart6.Axes.Depth.Labels.ImageBevel.Brush.Color = Color.LightGray;
      tChart6.Axes.Depth.Labels.ImageBevel.Brush.Solid = true;
      tChart6.Axes.Depth.Labels.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart6.Axes.Depth.Labels.Shadow.Brush.Color = Color.DarkGray;
      tChart6.Axes.Depth.Labels.Shadow.Brush.Solid = true;
      tChart6.Axes.Depth.Labels.Shadow.Brush.Visible = true;
      tChart6.Axes.Depth.Maximum = 0D;
      tChart6.Axes.Depth.Minimum = 0D;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart6.Axes.Depth.Title.Brush.Color = Color.Silver;
      tChart6.Axes.Depth.Title.Brush.Solid = true;
      tChart6.Axes.Depth.Title.Brush.Visible = true;
      // 
      // 
      // 
      tChart6.Axes.Depth.Title.Font.Bold = false;
      // 
      // 
      // 
      tChart6.Axes.Depth.Title.Font.Brush.Color = Color.FromArgb((int)(byte)0, (int)(byte)0, (int)(byte)0);
      tChart6.Axes.Depth.Title.Font.Brush.Solid = true;
      tChart6.Axes.Depth.Title.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart6.Axes.Depth.Title.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart6.Axes.Depth.Title.Font.Shadow.Brush.Solid = true;
      tChart6.Axes.Depth.Title.Font.Shadow.Brush.Visible = true;
      tChart6.Axes.Depth.Title.Font.Size = 8;
      tChart6.Axes.Depth.Title.Font.SizeFloat = 8F;
      tChart6.Axes.Depth.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart6.Axes.Depth.Title.ImageBevel.Brush.Color = Color.LightGray;
      tChart6.Axes.Depth.Title.ImageBevel.Brush.Solid = true;
      tChart6.Axes.Depth.Title.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart6.Axes.Depth.Title.Shadow.Brush.Color = Color.DarkGray;
      tChart6.Axes.Depth.Title.Shadow.Brush.Solid = true;
      tChart6.Axes.Depth.Title.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      tChart6.Axes.DepthTop.Automatic = false;
      tChart6.Axes.DepthTop.AutomaticMaximum = false;
      tChart6.Axes.DepthTop.AutomaticMinimum = false;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart6.Axes.DepthTop.Labels.Brush.Color = Color.White;
      tChart6.Axes.DepthTop.Labels.Brush.Solid = true;
      tChart6.Axes.DepthTop.Labels.Brush.Visible = true;
      // 
      // 
      // 
      tChart6.Axes.DepthTop.Labels.Font.Bold = false;
      // 
      // 
      // 
      tChart6.Axes.DepthTop.Labels.Font.Brush.Color = Color.FromArgb((int)(byte)255, (int)(byte)255, (int)(byte)255);
      tChart6.Axes.DepthTop.Labels.Font.Brush.Solid = true;
      tChart6.Axes.DepthTop.Labels.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart6.Axes.DepthTop.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart6.Axes.DepthTop.Labels.Font.Shadow.Brush.Solid = true;
      tChart6.Axes.DepthTop.Labels.Font.Shadow.Brush.Visible = true;
      tChart6.Axes.DepthTop.Labels.Font.Size = 8;
      tChart6.Axes.DepthTop.Labels.Font.SizeFloat = 8F;
      tChart6.Axes.DepthTop.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart6.Axes.DepthTop.Labels.ImageBevel.Brush.Color = Color.LightGray;
      tChart6.Axes.DepthTop.Labels.ImageBevel.Brush.Solid = true;
      tChart6.Axes.DepthTop.Labels.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart6.Axes.DepthTop.Labels.Shadow.Brush.Color = Color.DarkGray;
      tChart6.Axes.DepthTop.Labels.Shadow.Brush.Solid = true;
      tChart6.Axes.DepthTop.Labels.Shadow.Brush.Visible = true;
      tChart6.Axes.DepthTop.Maximum = 0D;
      tChart6.Axes.DepthTop.Minimum = 0D;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart6.Axes.DepthTop.Title.Brush.Color = Color.Silver;
      tChart6.Axes.DepthTop.Title.Brush.Solid = true;
      tChart6.Axes.DepthTop.Title.Brush.Visible = true;
      // 
      // 
      // 
      tChart6.Axes.DepthTop.Title.Font.Bold = false;
      // 
      // 
      // 
      tChart6.Axes.DepthTop.Title.Font.Brush.Color = Color.FromArgb((int)(byte)0, (int)(byte)0, (int)(byte)0);
      tChart6.Axes.DepthTop.Title.Font.Brush.Solid = true;
      tChart6.Axes.DepthTop.Title.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart6.Axes.DepthTop.Title.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart6.Axes.DepthTop.Title.Font.Shadow.Brush.Solid = true;
      tChart6.Axes.DepthTop.Title.Font.Shadow.Brush.Visible = true;
      tChart6.Axes.DepthTop.Title.Font.Size = 8;
      tChart6.Axes.DepthTop.Title.Font.SizeFloat = 8F;
      tChart6.Axes.DepthTop.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart6.Axes.DepthTop.Title.ImageBevel.Brush.Color = Color.LightGray;
      tChart6.Axes.DepthTop.Title.ImageBevel.Brush.Solid = true;
      tChart6.Axes.DepthTop.Title.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart6.Axes.DepthTop.Title.Shadow.Brush.Color = Color.DarkGray;
      tChart6.Axes.DepthTop.Title.Shadow.Brush.Solid = true;
      tChart6.Axes.DepthTop.Title.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      tChart6.Axes.Left.Automatic = false;
      tChart6.Axes.Left.AutomaticMaximum = false;
      tChart6.Axes.Left.AutomaticMinimum = false;
      tChart6.Axes.Left.EndPosition = 38D;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart6.Axes.Left.Labels.Brush.Color = Color.White;
      tChart6.Axes.Left.Labels.Brush.Solid = true;
      tChart6.Axes.Left.Labels.Brush.Visible = true;
      tChart6.Axes.Left.Labels.CustomSize = 44;
      // 
      // 
      // 
      tChart6.Axes.Left.Labels.Font.Bold = false;
      // 
      // 
      // 
      tChart6.Axes.Left.Labels.Font.Brush.Color = Color.FromArgb((int)(byte)255, (int)(byte)255, (int)(byte)255);
      tChart6.Axes.Left.Labels.Font.Brush.Solid = true;
      tChart6.Axes.Left.Labels.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart6.Axes.Left.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart6.Axes.Left.Labels.Font.Shadow.Brush.Solid = true;
      tChart6.Axes.Left.Labels.Font.Shadow.Brush.Visible = true;
      tChart6.Axes.Left.Labels.Font.Size = 8;
      tChart6.Axes.Left.Labels.Font.SizeFloat = 8F;
      tChart6.Axes.Left.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart6.Axes.Left.Labels.ImageBevel.Brush.Color = Color.LightGray;
      tChart6.Axes.Left.Labels.ImageBevel.Brush.Solid = true;
      tChart6.Axes.Left.Labels.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart6.Axes.Left.Labels.Shadow.Brush.Color = Color.DarkGray;
      tChart6.Axes.Left.Labels.Shadow.Brush.Solid = true;
      tChart6.Axes.Left.Labels.Shadow.Brush.Visible = true;
      tChart6.Axes.Left.Maximum = 1010D;
      tChart6.Axes.Left.Minimum = 780D;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart6.Axes.Left.Title.Brush.Color = Color.Silver;
      tChart6.Axes.Left.Title.Brush.Solid = true;
      tChart6.Axes.Left.Title.Brush.Visible = true;
      tChart6.Axes.Left.Title.Caption = "Range";
      // 
      // 
      // 
      tChart6.Axes.Left.Title.Font.Bold = false;
      // 
      // 
      // 
      tChart6.Axes.Left.Title.Font.Brush.Color = Color.FromArgb((int)(byte)224, (int)(byte)224, (int)(byte)224);
      tChart6.Axes.Left.Title.Font.Brush.Solid = true;
      tChart6.Axes.Left.Title.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart6.Axes.Left.Title.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart6.Axes.Left.Title.Font.Shadow.Brush.Solid = true;
      tChart6.Axes.Left.Title.Font.Shadow.Brush.Visible = true;
      tChart6.Axes.Left.Title.Font.Size = 8;
      tChart6.Axes.Left.Title.Font.SizeFloat = 8F;
      tChart6.Axes.Left.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart6.Axes.Left.Title.ImageBevel.Brush.Color = Color.LightGray;
      tChart6.Axes.Left.Title.ImageBevel.Brush.Solid = true;
      tChart6.Axes.Left.Title.ImageBevel.Brush.Visible = true;
      tChart6.Axes.Left.Title.Lines = new string[]
  {
    "Range"
  };
      // 
      // 
      // 
      // 
      // 
      // 
      tChart6.Axes.Left.Title.Shadow.Brush.Color = Color.DarkGray;
      tChart6.Axes.Left.Title.Shadow.Brush.Solid = true;
      tChart6.Axes.Left.Title.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      tChart6.Axes.Right.Automatic = false;
      tChart6.Axes.Right.AutomaticMaximum = false;
      tChart6.Axes.Right.AutomaticMinimum = false;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart6.Axes.Right.Labels.Brush.Color = Color.White;
      tChart6.Axes.Right.Labels.Brush.Solid = true;
      tChart6.Axes.Right.Labels.Brush.Visible = true;
      // 
      // 
      // 
      tChart6.Axes.Right.Labels.Font.Bold = false;
      // 
      // 
      // 
      tChart6.Axes.Right.Labels.Font.Brush.Color = Color.FromArgb((int)(byte)255, (int)(byte)255, (int)(byte)255);
      tChart6.Axes.Right.Labels.Font.Brush.Solid = true;
      tChart6.Axes.Right.Labels.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart6.Axes.Right.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart6.Axes.Right.Labels.Font.Shadow.Brush.Solid = true;
      tChart6.Axes.Right.Labels.Font.Shadow.Brush.Visible = true;
      tChart6.Axes.Right.Labels.Font.Size = 8;
      tChart6.Axes.Right.Labels.Font.SizeFloat = 8F;
      tChart6.Axes.Right.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart6.Axes.Right.Labels.ImageBevel.Brush.Color = Color.LightGray;
      tChart6.Axes.Right.Labels.ImageBevel.Brush.Solid = true;
      tChart6.Axes.Right.Labels.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart6.Axes.Right.Labels.Shadow.Brush.Color = Color.DarkGray;
      tChart6.Axes.Right.Labels.Shadow.Brush.Solid = true;
      tChart6.Axes.Right.Labels.Shadow.Brush.Visible = true;
      tChart6.Axes.Right.Maximum = 0D;
      tChart6.Axes.Right.Minimum = 0D;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart6.Axes.Right.Title.Brush.Color = Color.Silver;
      tChart6.Axes.Right.Title.Brush.Solid = true;
      tChart6.Axes.Right.Title.Brush.Visible = true;
      // 
      // 
      // 
      tChart6.Axes.Right.Title.Font.Bold = false;
      // 
      // 
      // 
      tChart6.Axes.Right.Title.Font.Brush.Color = Color.FromArgb((int)(byte)0, (int)(byte)0, (int)(byte)0);
      tChart6.Axes.Right.Title.Font.Brush.Solid = true;
      tChart6.Axes.Right.Title.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart6.Axes.Right.Title.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart6.Axes.Right.Title.Font.Shadow.Brush.Solid = true;
      tChart6.Axes.Right.Title.Font.Shadow.Brush.Visible = true;
      tChart6.Axes.Right.Title.Font.Size = 8;
      tChart6.Axes.Right.Title.Font.SizeFloat = 8F;
      tChart6.Axes.Right.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart6.Axes.Right.Title.ImageBevel.Brush.Color = Color.LightGray;
      tChart6.Axes.Right.Title.ImageBevel.Brush.Solid = true;
      tChart6.Axes.Right.Title.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart6.Axes.Right.Title.Shadow.Brush.Color = Color.DarkGray;
      tChart6.Axes.Right.Title.Shadow.Brush.Solid = true;
      tChart6.Axes.Right.Title.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      tChart6.Axes.Top.Automatic = false;
      tChart6.Axes.Top.AutomaticMaximum = false;
      tChart6.Axes.Top.AutomaticMinimum = false;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart6.Axes.Top.Labels.Brush.Color = Color.White;
      tChart6.Axes.Top.Labels.Brush.Solid = true;
      tChart6.Axes.Top.Labels.Brush.Visible = true;
      // 
      // 
      // 
      tChart6.Axes.Top.Labels.Font.Bold = false;
      // 
      // 
      // 
      tChart6.Axes.Top.Labels.Font.Brush.Color = Color.FromArgb((int)(byte)255, (int)(byte)255, (int)(byte)255);
      tChart6.Axes.Top.Labels.Font.Brush.Solid = true;
      tChart6.Axes.Top.Labels.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart6.Axes.Top.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart6.Axes.Top.Labels.Font.Shadow.Brush.Solid = true;
      tChart6.Axes.Top.Labels.Font.Shadow.Brush.Visible = true;
      tChart6.Axes.Top.Labels.Font.Size = 8;
      tChart6.Axes.Top.Labels.Font.SizeFloat = 8F;
      tChart6.Axes.Top.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart6.Axes.Top.Labels.ImageBevel.Brush.Color = Color.LightGray;
      tChart6.Axes.Top.Labels.ImageBevel.Brush.Solid = true;
      tChart6.Axes.Top.Labels.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart6.Axes.Top.Labels.Shadow.Brush.Color = Color.DarkGray;
      tChart6.Axes.Top.Labels.Shadow.Brush.Solid = true;
      tChart6.Axes.Top.Labels.Shadow.Brush.Visible = true;
      tChart6.Axes.Top.Maximum = 0D;
      tChart6.Axes.Top.Minimum = 0D;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart6.Axes.Top.Title.Brush.Color = Color.Silver;
      tChart6.Axes.Top.Title.Brush.Solid = true;
      tChart6.Axes.Top.Title.Brush.Visible = true;
      // 
      // 
      // 
      tChart6.Axes.Top.Title.Font.Bold = false;
      // 
      // 
      // 
      tChart6.Axes.Top.Title.Font.Brush.Color = Color.FromArgb((int)(byte)0, (int)(byte)0, (int)(byte)0);
      tChart6.Axes.Top.Title.Font.Brush.Solid = true;
      tChart6.Axes.Top.Title.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart6.Axes.Top.Title.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart6.Axes.Top.Title.Font.Shadow.Brush.Solid = true;
      tChart6.Axes.Top.Title.Font.Shadow.Brush.Visible = true;
      tChart6.Axes.Top.Title.Font.Size = 8;
      tChart6.Axes.Top.Title.Font.SizeFloat = 8F;
      tChart6.Axes.Top.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart6.Axes.Top.Title.ImageBevel.Brush.Color = Color.LightGray;
      tChart6.Axes.Top.Title.ImageBevel.Brush.Solid = true;
      tChart6.Axes.Top.Title.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart6.Axes.Top.Title.Shadow.Brush.Color = Color.DarkGray;
      tChart6.Axes.Top.Title.Shadow.Brush.Solid = true;
      tChart6.Axes.Top.Title.Shadow.Brush.Visible = true;
      tChart6.Dock = DockStyle.Fill;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart6.Footer.Brush.Color = Color.Silver;
      tChart6.Footer.Brush.Solid = true;
      tChart6.Footer.Brush.Visible = true;
      // 
      // 
      // 
      tChart6.Footer.Font.Bold = false;
      // 
      // 
      // 
      tChart6.Footer.Font.Brush.Color = Color.Red;
      tChart6.Footer.Font.Brush.Solid = true;
      tChart6.Footer.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart6.Footer.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart6.Footer.Font.Shadow.Brush.Solid = true;
      tChart6.Footer.Font.Shadow.Brush.Visible = true;
      tChart6.Footer.Font.Size = 8;
      tChart6.Footer.Font.SizeFloat = 8F;
      tChart6.Footer.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart6.Footer.ImageBevel.Brush.Color = Color.LightGray;
      tChart6.Footer.ImageBevel.Brush.Solid = true;
      tChart6.Footer.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart6.Footer.Shadow.Brush.Color = Color.DarkGray;
      tChart6.Footer.Shadow.Brush.Solid = true;
      tChart6.Footer.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart6.Header.Brush.Color = Color.FromArgb((int)(byte)192, (int)(byte)192, (int)(byte)192);
      // 
      // 
      // 
      tChart6.Header.Brush.Gradient.SigmaFocus = 0F;
      tChart6.Header.Brush.Gradient.SigmaScale = 0F;
      tChart6.Header.Brush.Solid = true;
      tChart6.Header.Brush.Visible = true;
      // 
      // 
      // 
      tChart6.Header.Font.Bold = false;
      // 
      // 
      // 
      tChart6.Header.Font.Brush.Color = Color.FromArgb((int)(byte)255, (int)(byte)255, (int)(byte)255);
      tChart6.Header.Font.Brush.Solid = true;
      tChart6.Header.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart6.Header.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart6.Header.Font.Shadow.Brush.Solid = true;
      tChart6.Header.Font.Shadow.Brush.Visible = true;
      tChart6.Header.Font.Size = 8;
      tChart6.Header.Font.SizeFloat = 8F;
      tChart6.Header.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart6.Header.ImageBevel.Brush.Color = Color.LightGray;
      tChart6.Header.ImageBevel.Brush.Solid = true;
      tChart6.Header.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart6.Header.Shadow.Brush.Color = Color.FromArgb((int)(byte)169, (int)(byte)169, (int)(byte)169);
      tChart6.Header.Shadow.Brush.Solid = true;
      tChart6.Header.Shadow.Brush.Visible = true;
      tChart6.Header.Shadow.Height = 0;
      tChart6.Header.Shadow.Width = 0;
      tChart6.Header.Visible = false;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart6.Legend.Brush.Color = Color.White;
      // 
      // 
      // 
      tChart6.Legend.Brush.Gradient.SigmaFocus = 0F;
      tChart6.Legend.Brush.Gradient.SigmaScale = 0F;
      tChart6.Legend.Brush.Gradient.Visible = true;
      tChart6.Legend.Brush.Solid = true;
      tChart6.Legend.Brush.Visible = true;
      tChart6.Legend.CheckBoxes = false;
      tChart6.Legend.ClipText = false;
      // 
      // 
      // 
      tChart6.Legend.Font.Bold = false;
      // 
      // 
      // 
      tChart6.Legend.Font.Brush.Color = Color.FromArgb((int)(byte)255, (int)(byte)255, (int)(byte)255);
      tChart6.Legend.Font.Brush.Solid = true;
      tChart6.Legend.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart6.Legend.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart6.Legend.Font.Shadow.Brush.Solid = true;
      tChart6.Legend.Font.Shadow.Brush.Visible = true;
      tChart6.Legend.Font.Size = 8;
      tChart6.Legend.Font.SizeFloat = 8F;
      tChart6.Legend.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart6.Legend.ImageBevel.Brush.Color = Color.LightGray;
      tChart6.Legend.ImageBevel.Brush.Solid = true;
      tChart6.Legend.ImageBevel.Brush.Visible = true;
      tChart6.Legend.LegendStyle = Steema.TeeChart.LegendStyles.Values;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart6.Legend.Shadow.Brush.Color = Color.FromArgb((int)(byte)0, (int)(byte)0, (int)(byte)0);
      tChart6.Legend.Shadow.Brush.Solid = true;
      tChart6.Legend.Shadow.Brush.Visible = true;
      tChart6.Legend.Shadow.Width = 0;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      tChart6.Legend.Symbol.Shadow.Brush.Color = Color.DarkGray;
      tChart6.Legend.Symbol.Shadow.Brush.Solid = true;
      tChart6.Legend.Symbol.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart6.Legend.Title.Brush.Color = Color.White;
      tChart6.Legend.Title.Brush.Solid = true;
      tChart6.Legend.Title.Brush.Visible = true;
      // 
      // 
      // 
      tChart6.Legend.Title.Font.Bold = true;
      // 
      // 
      // 
      tChart6.Legend.Title.Font.Brush.Color = Color.Black;
      tChart6.Legend.Title.Font.Brush.Solid = true;
      tChart6.Legend.Title.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart6.Legend.Title.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart6.Legend.Title.Font.Shadow.Brush.Solid = true;
      tChart6.Legend.Title.Font.Shadow.Brush.Visible = true;
      tChart6.Legend.Title.Font.Size = 8;
      tChart6.Legend.Title.Font.SizeFloat = 8F;
      tChart6.Legend.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Bold;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart6.Legend.Title.ImageBevel.Brush.Color = Color.LightGray;
      tChart6.Legend.Title.ImageBevel.Brush.Solid = true;
      tChart6.Legend.Title.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart6.Legend.Title.Shadow.Brush.Color = Color.DarkGray;
      tChart6.Legend.Title.Shadow.Brush.Solid = true;
      tChart6.Legend.Title.Shadow.Brush.Visible = true;
      tChart6.Legend.Visible = false;
      tChart6.Location = new Point(0, 0);
      tChart6.Name = "tChart6";
      // 
      // 
      // 
      // 
      // 
      // 
      tChart6.Panel.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.Raised;
      // 
      // 
      // 
      tChart6.Panel.Brush.Color = Color.FromArgb((int)(byte)240, (int)(byte)240, (int)(byte)240);
      // 
      // 
      // 
      tChart6.Panel.Brush.Gradient.EndColor = Color.FromArgb((int)(byte)70, (int)(byte)70, (int)(byte)70);
      tChart6.Panel.Brush.Gradient.MiddleColor = Color.FromArgb((int)(byte)0, (int)(byte)0, (int)(byte)0, (int)(byte)0);
      tChart6.Panel.Brush.Gradient.SigmaFocus = 0F;
      tChart6.Panel.Brush.Gradient.SigmaScale = 0F;
      tChart6.Panel.Brush.Gradient.StartColor = Color.FromArgb((int)(byte)70, (int)(byte)70, (int)(byte)70);
      tChart6.Panel.Brush.Gradient.UseMiddle = false;
      tChart6.Panel.Brush.Gradient.Visible = true;
      tChart6.Panel.Brush.Solid = true;
      tChart6.Panel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart6.Panel.ImageBevel.Brush.Color = Color.LightGray;
      tChart6.Panel.ImageBevel.Brush.Solid = true;
      tChart6.Panel.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart6.Panel.Shadow.Brush.Color = Color.DarkGray;
      tChart6.Panel.Shadow.Brush.Solid = true;
      tChart6.Panel.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      margins1.Bottom = 100;
      margins1.Left = 100;
      margins1.Right = 100;
      margins1.Top = 100;
      tChart6.Printer.Margins = margins1;
      tChart6.Series.Add(highLow1);
      tChart6.Series.Add(line3);
      tChart6.Series.Add(line4);
      tChart6.Size = new Size(477, 571);
      // 
      // 
      // 
      // 
      // 
      // 
      tChart6.SubFooter.Brush.Color = Color.Silver;
      tChart6.SubFooter.Brush.Solid = true;
      tChart6.SubFooter.Brush.Visible = true;
      // 
      // 
      // 
      tChart6.SubFooter.Font.Bold = false;
      // 
      // 
      // 
      tChart6.SubFooter.Font.Brush.Color = Color.Red;
      tChart6.SubFooter.Font.Brush.Solid = true;
      tChart6.SubFooter.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart6.SubFooter.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart6.SubFooter.Font.Shadow.Brush.Solid = true;
      tChart6.SubFooter.Font.Shadow.Brush.Visible = true;
      tChart6.SubFooter.Font.Size = 8;
      tChart6.SubFooter.Font.SizeFloat = 8F;
      tChart6.SubFooter.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart6.SubFooter.ImageBevel.Brush.Color = Color.LightGray;
      tChart6.SubFooter.ImageBevel.Brush.Solid = true;
      tChart6.SubFooter.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart6.SubFooter.Shadow.Brush.Color = Color.DarkGray;
      tChart6.SubFooter.Shadow.Brush.Solid = true;
      tChart6.SubFooter.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart6.SubHeader.Brush.Color = Color.FromArgb((int)(byte)192, (int)(byte)192, (int)(byte)192);
      tChart6.SubHeader.Brush.Solid = true;
      tChart6.SubHeader.Brush.Visible = true;
      // 
      // 
      // 
      tChart6.SubHeader.Font.Bold = false;
      // 
      // 
      // 
      tChart6.SubHeader.Font.Brush.Color = Color.FromArgb((int)(byte)128, (int)(byte)128, (int)(byte)128);
      tChart6.SubHeader.Font.Brush.Solid = true;
      tChart6.SubHeader.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart6.SubHeader.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart6.SubHeader.Font.Shadow.Brush.Solid = true;
      tChart6.SubHeader.Font.Shadow.Brush.Visible = true;
      tChart6.SubHeader.Font.Size = 12;
      tChart6.SubHeader.Font.SizeFloat = 12F;
      tChart6.SubHeader.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart6.SubHeader.ImageBevel.Brush.Color = Color.LightGray;
      tChart6.SubHeader.ImageBevel.Brush.Solid = true;
      tChart6.SubHeader.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart6.SubHeader.Shadow.Brush.Color = Color.FromArgb((int)(byte)169, (int)(byte)169, (int)(byte)169);
      tChart6.SubHeader.Shadow.Brush.Solid = true;
      tChart6.SubHeader.Shadow.Brush.Visible = true;
      tChart6.TabIndex = 0;
      tChart6.Tools.Add(colorBand1);
      tChart6.Tools.Add(colorBand2);
      tChart6.Tools.Add(annotation1);
      tChart6.Tools.Add(annotation2);
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      tChart6.Walls.Back.Brush.Color = Color.Silver;
      // 
      // 
      // 
      tChart6.Walls.Back.Brush.Gradient.EndColor = Color.FromArgb((int)(byte)120, (int)(byte)120, (int)(byte)120);
      tChart6.Walls.Back.Brush.Gradient.StartColor = Color.FromArgb((int)(byte)70, (int)(byte)70, (int)(byte)70);
      tChart6.Walls.Back.Brush.Solid = true;
      tChart6.Walls.Back.Brush.Visible = false;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart6.Walls.Back.ImageBevel.Brush.Color = Color.LightGray;
      tChart6.Walls.Back.ImageBevel.Brush.Solid = true;
      tChart6.Walls.Back.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart6.Walls.Back.Shadow.Brush.Color = Color.DarkGray;
      tChart6.Walls.Back.Shadow.Brush.Solid = true;
      tChart6.Walls.Back.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart6.Walls.Bottom.Brush.Color = Color.White;
      // 
      // 
      // 
      tChart6.Walls.Bottom.Brush.Gradient.SigmaFocus = 0F;
      tChart6.Walls.Bottom.Brush.Gradient.SigmaScale = 0F;
      tChart6.Walls.Bottom.Brush.Solid = true;
      tChart6.Walls.Bottom.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart6.Walls.Bottom.ImageBevel.Brush.Color = Color.LightGray;
      tChart6.Walls.Bottom.ImageBevel.Brush.Solid = true;
      tChart6.Walls.Bottom.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart6.Walls.Bottom.Shadow.Brush.Color = Color.DarkGray;
      tChart6.Walls.Bottom.Shadow.Brush.Solid = true;
      tChart6.Walls.Bottom.Shadow.Brush.Visible = true;
      tChart6.Walls.Bottom.Visible = false;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart6.Walls.Left.Brush.Color = Color.LightYellow;
      // 
      // 
      // 
      tChart6.Walls.Left.Brush.Gradient.SigmaFocus = 0F;
      tChart6.Walls.Left.Brush.Gradient.SigmaScale = 0F;
      tChart6.Walls.Left.Brush.Solid = true;
      tChart6.Walls.Left.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart6.Walls.Left.ImageBevel.Brush.Color = Color.LightGray;
      tChart6.Walls.Left.ImageBevel.Brush.Solid = true;
      tChart6.Walls.Left.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart6.Walls.Left.Shadow.Brush.Color = Color.DarkGray;
      tChart6.Walls.Left.Shadow.Brush.Solid = true;
      tChart6.Walls.Left.Shadow.Brush.Visible = true;
      tChart6.Walls.Left.Visible = false;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart6.Walls.Right.Brush.Color = Color.FromArgb((int)(byte)192, (int)(byte)192, (int)(byte)192);
      // 
      // 
      // 
      tChart6.Walls.Right.Brush.Gradient.SigmaFocus = 0F;
      tChart6.Walls.Right.Brush.Gradient.SigmaScale = 0F;
      tChart6.Walls.Right.Brush.Solid = true;
      tChart6.Walls.Right.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart6.Walls.Right.ImageBevel.Brush.Color = Color.LightGray;
      tChart6.Walls.Right.ImageBevel.Brush.Solid = true;
      tChart6.Walls.Right.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart6.Walls.Right.Shadow.Brush.Color = Color.DarkGray;
      tChart6.Walls.Right.Shadow.Brush.Solid = true;
      tChart6.Walls.Right.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart6.Zoom.Brush.Color = Color.FromArgb((int)(byte)127, (int)(byte)0, (int)(byte)0, (int)(byte)255);
      tChart6.Zoom.Brush.Solid = true;
      tChart6.Zoom.Brush.Visible = false;
      tChart6.BeforeDrawSeries += (this.tChart6_BeforeDrawSeries);
      // 
      // axis3
      // 
      axis3.Automatic = false;
      axis3.AutomaticMaximum = false;
      axis3.AutomaticMinimum = false;
      axis3.EndPosition = 68D;
      axis3.Horizontal = false;
      // 
      // 
      // 
      // 
      // 
      // 
      axis3.Labels.Brush.Color = Color.White;
      axis3.Labels.Brush.Solid = true;
      axis3.Labels.Brush.Visible = true;
      axis3.Labels.CustomSize = 44;
      // 
      // 
      // 
      axis3.Labels.Font.Bold = false;
      // 
      // 
      // 
      axis3.Labels.Font.Brush.Color = Color.FromArgb((int)(byte)168, (int)(byte)168, (int)(byte)0);
      axis3.Labels.Font.Brush.Solid = true;
      axis3.Labels.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      axis3.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
      axis3.Labels.Font.Shadow.Brush.Solid = true;
      axis3.Labels.Font.Shadow.Brush.Visible = true;
      axis3.Labels.Font.Size = 9;
      axis3.Labels.Font.SizeFloat = 9F;
      axis3.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      axis3.Labels.ImageBevel.Brush.Color = Color.LightGray;
      axis3.Labels.ImageBevel.Brush.Solid = true;
      axis3.Labels.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      axis3.Labels.Shadow.Brush.Color = Color.DarkGray;
      axis3.Labels.Shadow.Brush.Solid = true;
      axis3.Labels.Shadow.Brush.Visible = true;
      axis3.Maximum = 120D;
      axis3.Minimum = 0D;
      axis3.OtherSide = false;
      axis3.StartPosition = 42D;
      // 
      // 
      // 
      axis3.Title.Angle = 90;
      // 
      // 
      // 
      axis3.Title.Brush.Color = Color.Silver;
      axis3.Title.Brush.Solid = true;
      axis3.Title.Brush.Visible = true;
      axis3.Title.Caption = "Std deviation";
      // 
      // 
      // 
      axis3.Title.Font.Bold = false;
      // 
      // 
      // 
      axis3.Title.Font.Brush.Color = Color.FromArgb((int)(byte)224, (int)(byte)224, (int)(byte)224);
      axis3.Title.Font.Brush.Solid = true;
      axis3.Title.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      axis3.Title.Font.Shadow.Brush.Color = Color.DarkGray;
      axis3.Title.Font.Shadow.Brush.Solid = true;
      axis3.Title.Font.Shadow.Brush.Visible = true;
      axis3.Title.Font.Size = 8;
      axis3.Title.Font.SizeFloat = 8F;
      axis3.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      axis3.Title.ImageBevel.Brush.Color = Color.LightGray;
      axis3.Title.ImageBevel.Brush.Solid = true;
      axis3.Title.ImageBevel.Brush.Visible = true;
      axis3.Title.Lines = new string[]
  {
    "Std deviation"
  };
      // 
      // 
      // 
      // 
      // 
      // 
      axis3.Title.Shadow.Brush.Color = Color.DarkGray;
      axis3.Title.Shadow.Brush.Solid = true;
      axis3.Title.Shadow.Brush.Visible = true;
      // 
      // axis4
      // 
      axis4.Automatic = false;
      axis4.AutomaticMaximum = false;
      axis4.AutomaticMinimum = false;
      // 
      // 
      // 
      axis4.Grid.DrawEvery = 1;
      axis4.Horizontal = false;
      // 
      // 
      // 
      // 
      // 
      // 
      axis4.Labels.Brush.Color = Color.White;
      axis4.Labels.Brush.Solid = true;
      axis4.Labels.Brush.Visible = true;
      axis4.Labels.CustomSize = 44;
      // 
      // 
      // 
      axis4.Labels.Font.Bold = false;
      // 
      // 
      // 
      axis4.Labels.Font.Brush.Color = Color.FromArgb((int)(byte)192, (int)(byte)192, (int)(byte)192);
      axis4.Labels.Font.Brush.Solid = true;
      axis4.Labels.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      axis4.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
      axis4.Labels.Font.Shadow.Brush.Solid = true;
      axis4.Labels.Font.Shadow.Brush.Visible = true;
      axis4.Labels.Font.Size = 9;
      axis4.Labels.Font.SizeFloat = 9F;
      axis4.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      axis4.Labels.ImageBevel.Brush.Color = Color.LightGray;
      axis4.Labels.ImageBevel.Brush.Solid = true;
      axis4.Labels.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      axis4.Labels.Shadow.Brush.Color = Color.DarkGray;
      axis4.Labels.Shadow.Brush.Solid = true;
      axis4.Labels.Shadow.Brush.Visible = true;
      axis4.Maximum = 1050D;
      axis4.Minimum = 870D;
      axis4.OtherSide = false;
      axis4.StartPosition = 72D;
      // 
      // 
      // 
      axis4.Title.Angle = 90;
      // 
      // 
      // 
      axis4.Title.Brush.Color = Color.Silver;
      axis4.Title.Brush.Solid = true;
      axis4.Title.Brush.Visible = true;
      axis4.Title.Caption = "RMS.";
      // 
      // 
      // 
      axis4.Title.Font.Bold = false;
      // 
      // 
      // 
      axis4.Title.Font.Brush.Color = Color.FromArgb((int)(byte)224, (int)(byte)224, (int)(byte)224);
      axis4.Title.Font.Brush.Solid = true;
      axis4.Title.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      axis4.Title.Font.Shadow.Brush.Color = Color.DarkGray;
      axis4.Title.Font.Shadow.Brush.Solid = true;
      axis4.Title.Font.Shadow.Brush.Visible = true;
      axis4.Title.Font.Size = 8;
      axis4.Title.Font.SizeFloat = 8F;
      axis4.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      axis4.Title.ImageBevel.Brush.Color = Color.LightGray;
      axis4.Title.ImageBevel.Brush.Solid = true;
      axis4.Title.ImageBevel.Brush.Visible = true;
      axis4.Title.Lines = new string[]
  {
    "RMS."
  };
      // 
      // 
      // 
      // 
      // 
      // 
      axis4.Title.Shadow.Brush.Color = Color.DarkGray;
      axis4.Title.Shadow.Brush.Solid = true;
      axis4.Title.Shadow.Brush.Visible = true;
      // 
      // highLow1
      // 
      // 
      // 
      // 
      highLow1.Brush.Color = Color.Empty;
      highLow1.Brush.Solid = true;
      highLow1.Brush.Visible = true;
      highLow1.Color = Color.FromArgb((int)(byte)119, (int)(byte)153, (int)(byte)214);
      highLow1.Cursor = cursor1;
      // 
      // 
      // 
      highLow1.HighBrush.Color = Color.FromArgb((int)(byte)127, (int)(byte)192, (int)(byte)192, (int)(byte)255);
      // 
      // 
      // 
      highLow1.HighBrush.Gradient.Transparency = 50;
      highLow1.HighBrush.Gradient.UseMiddle = true;
      highLow1.HighBrush.Gradient.Visible = true;
      highLow1.HighBrush.Solid = false;
      highLow1.HighBrush.Visible = true;
      // 
      // 
      // 
      highLow1.HighPen.Color = Color.FromArgb((int)(byte)192, (int)(byte)192, (int)(byte)192);
      // 
      // 
      // 
      highLow1.HighValues.DataMember = "Y";
      highLow1.HighValues.Value = new double[]
  {
    446.02168674861167D,
    489.54056458991988D,
    435.172371536108D,
    462.403249955924D,
    472.00169627182277D,
    430.52556590667268D,
    511.95000885610949D,
    474.93265544759714D,
    541.83236586015335D,
    557.439763917327D,
    510.58896994711336D,
    492.96516249560079D,
    589.625629079354D,
    538.44681444505568D,
    635.04807107851309D,
    602.80418973546693D,
    554.7864222222878D,
    507.42133609364822D,
    547.08100065918711D,
    484.08754285615316D,
    514.67523026032177D,
    587.969787599505D,
    659.38582995877891D,
    654.24195064894968D,
    672.04320839235731D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
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
      // 
      // 
      // 
      highLow1.Legend.Brush.Color = Color.White;
      highLow1.Legend.Brush.Solid = true;
      highLow1.Legend.Brush.Visible = true;
      // 
      // 
      // 
      highLow1.Legend.Font.Bold = false;
      // 
      // 
      // 
      highLow1.Legend.Font.Brush.Color = Color.Black;
      highLow1.Legend.Font.Brush.Solid = true;
      highLow1.Legend.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      highLow1.Legend.Font.Shadow.Brush.Color = Color.DarkGray;
      highLow1.Legend.Font.Shadow.Brush.Solid = true;
      highLow1.Legend.Font.Shadow.Brush.Visible = true;
      highLow1.Legend.Font.Size = 8;
      highLow1.Legend.Font.SizeFloat = 8F;
      highLow1.Legend.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      highLow1.Legend.ImageBevel.Brush.Color = Color.LightGray;
      highLow1.Legend.ImageBevel.Brush.Solid = true;
      highLow1.Legend.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      highLow1.Legend.Shadow.Brush.Color = Color.DarkGray;
      highLow1.Legend.Shadow.Brush.Solid = true;
      highLow1.Legend.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      highLow1.LowBrush.Color = Color.FromArgb((int)(byte)127, (int)(byte)223, (int)(byte)223, (int)(byte)255);
      // 
      // 
      // 
      highLow1.LowBrush.Gradient.UseMiddle = true;
      highLow1.LowBrush.Gradient.Visible = true;
      highLow1.LowBrush.Solid = false;
      highLow1.LowBrush.Visible = true;
      // 
      // 
      // 
      highLow1.LowPen.Color = Color.FromArgb((int)(byte)128, (int)(byte)128, (int)(byte)255);
      // 
      // 
      // 
      highLow1.LowValues.DataMember = "Low";
      highLow1.LowValues.Value = new double[]
  {
    389.22506295574141D,
    334.13868645864488D,
    338.6856836446961D,
    340.06133113990614D,
    436.12041675305022D,
    348.68490712190288D,
    459.37484174937714D,
    394.41024157889677D,
    473.64137311169958D,
    438.25583981268863D,
    478.39373935870555D,
    425.17659786398383D,
    560.49792955652731D,
    384.68222719835239D,
    594.78342453706261D,
    460.4867399020527D,
    434.43665333764488D,
    316.865593435646D,
    546.657866354407D,
    340.18439694316362D,
    365.33722908484646D,
    479.03857998505191D,
    634.01843688172232D,
    543.68207712829235D,
    598.12989965925476D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
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
      // 
      // 
      // 
      highLow1.Marks.Brush.Color = Color.FromArgb((int)(byte)255, (int)(byte)255, (int)(byte)255);
      highLow1.Marks.Brush.Solid = true;
      highLow1.Marks.Brush.Visible = true;
      // 
      // 
      // 
      highLow1.Marks.Font.Bold = false;
      // 
      // 
      // 
      highLow1.Marks.Font.Brush.Color = Color.Black;
      highLow1.Marks.Font.Brush.Solid = true;
      highLow1.Marks.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      highLow1.Marks.Font.Shadow.Brush.Color = Color.DarkGray;
      highLow1.Marks.Font.Shadow.Brush.Solid = true;
      highLow1.Marks.Font.Shadow.Brush.Visible = true;
      highLow1.Marks.Font.Size = 8;
      highLow1.Marks.Font.SizeFloat = 8F;
      highLow1.Marks.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      highLow1.Marks.ImageBevel.Brush.Color = Color.LightGray;
      highLow1.Marks.ImageBevel.Brush.Solid = true;
      highLow1.Marks.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      highLow1.Marks.Shadow.Brush.Color = Color.Gray;
      highLow1.Marks.Shadow.Brush.Solid = true;
      highLow1.Marks.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      highLow1.Marks.Symbol.Brush.Color = Color.White;
      highLow1.Marks.Symbol.Brush.Solid = true;
      highLow1.Marks.Symbol.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      highLow1.Marks.Symbol.ImageBevel.Brush.Color = Color.LightGray;
      highLow1.Marks.Symbol.ImageBevel.Brush.Solid = true;
      highLow1.Marks.Symbol.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      highLow1.Marks.Symbol.Shadow.Brush.Color = Color.DarkGray;
      highLow1.Marks.Symbol.Shadow.Brush.Solid = true;
      highLow1.Marks.Symbol.Shadow.Brush.Visible = true;
      highLow1.Title = "high-Low1";
      // 
      // 
      // 
      highLow1.XValues.DataMember = "X";
      highLow1.XValues.DateTime = true;
      highLow1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
      highLow1.XValues.Value = new double[]
  {
    46132.712337731478D,
    46133.712337731478D,
    46134.712337731478D,
    46135.712337731478D,
    46136.712337731478D,
    46137.712337731478D,
    46138.712337731478D,
    46139.712337731478D,
    46140.712337731478D,
    46141.712337731478D,
    46142.712337731478D,
    46143.712337731478D,
    46144.712337731478D,
    46145.712337731478D,
    46146.712337731478D,
    46147.712337731478D,
    46148.712337731478D,
    46149.712337731478D,
    46150.712337731478D,
    46151.712337731478D,
    46152.712337731478D,
    46153.712337731478D,
    46154.712337731478D,
    46155.712337731478D,
    46156.712337731478D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
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
      // line3
      // 
      // 
      // 
      // 
      line3.AreaBrush.Color = Color.White;
      line3.AreaBrush.Solid = true;
      line3.AreaBrush.Visible = false;
      // 
      // 
      // 
      line3.Brush.Color = Color.FromArgb((int)(byte)255, (int)(byte)207, (int)(byte)104);
      line3.Brush.Solid = true;
      line3.Brush.Visible = true;
      line3.Color = Color.FromArgb((int)(byte)255, (int)(byte)207, (int)(byte)104);
      line3.Cursor = cursor1;
      line3.CustomVertAxis = axis3;
      line3.DataSource = highLow1;
      line3.Function = stdDeviation2;
      // 
      // 
      // 
      // 
      // 
      // 
      line3.Legend.Brush.Color = Color.White;
      line3.Legend.Brush.Solid = true;
      line3.Legend.Brush.Visible = true;
      // 
      // 
      // 
      line3.Legend.Font.Bold = false;
      // 
      // 
      // 
      line3.Legend.Font.Brush.Color = Color.Black;
      line3.Legend.Font.Brush.Solid = true;
      line3.Legend.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      line3.Legend.Font.Shadow.Brush.Color = Color.DarkGray;
      line3.Legend.Font.Shadow.Brush.Solid = true;
      line3.Legend.Font.Shadow.Brush.Visible = true;
      line3.Legend.Font.Size = 8;
      line3.Legend.Font.SizeFloat = 8F;
      line3.Legend.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      line3.Legend.ImageBevel.Brush.Color = Color.LightGray;
      line3.Legend.ImageBevel.Brush.Solid = true;
      line3.Legend.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      line3.Legend.Shadow.Brush.Color = Color.DarkGray;
      line3.Legend.Shadow.Brush.Solid = true;
      line3.Legend.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      line3.Marks.Brush.Color = Color.FromArgb((int)(byte)255, (int)(byte)255, (int)(byte)255);
      line3.Marks.Brush.Solid = true;
      line3.Marks.Brush.Visible = true;
      // 
      // 
      // 
      line3.Marks.Font.Bold = false;
      // 
      // 
      // 
      line3.Marks.Font.Brush.Color = Color.Black;
      line3.Marks.Font.Brush.Solid = true;
      line3.Marks.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      line3.Marks.Font.Shadow.Brush.Color = Color.DarkGray;
      line3.Marks.Font.Shadow.Brush.Solid = true;
      line3.Marks.Font.Shadow.Brush.Visible = true;
      line3.Marks.Font.Size = 8;
      line3.Marks.Font.SizeFloat = 8F;
      line3.Marks.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      line3.Marks.ImageBevel.Brush.Color = Color.LightGray;
      line3.Marks.ImageBevel.Brush.Solid = true;
      line3.Marks.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      line3.Marks.Shadow.Brush.Color = Color.Gray;
      line3.Marks.Shadow.Brush.Solid = true;
      line3.Marks.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      line3.Marks.Symbol.Brush.Color = Color.White;
      line3.Marks.Symbol.Brush.Solid = true;
      line3.Marks.Symbol.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      line3.Marks.Symbol.ImageBevel.Brush.Color = Color.LightGray;
      line3.Marks.Symbol.ImageBevel.Brush.Solid = true;
      line3.Marks.Symbol.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      line3.Marks.Symbol.Shadow.Brush.Color = Color.DarkGray;
      line3.Marks.Symbol.Shadow.Brush.Solid = true;
      line3.Marks.Symbol.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      line3.Pointer.Brush.Color = Color.FromArgb((int)(byte)255, (int)(byte)255, (int)(byte)255);
      line3.Pointer.Brush.Solid = true;
      line3.Pointer.Brush.Visible = true;
      line3.Title = "line1";
      line3.VertAxis = Steema.TeeChart.Styles.VerticalAxis.Custom;
      // 
      // 
      // 
      line3.XValues.DateTime = true;
      line3.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
      line3.XValues.Value = new double[]
  {
    46137.212337731478D,
    46147.212337731478D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
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
      line3.YValues.Value = new double[]
  {
    43.327475425725368D,
    50.091223839955333D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
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
      // stdDeviation2
      // 
      stdDeviation2.Period = 10D;
      // 
      // line4
      // 
      // 
      // 
      // 
      line4.AreaBrush.Color = Color.White;
      line4.AreaBrush.Solid = true;
      line4.AreaBrush.Visible = false;
      // 
      // 
      // 
      line4.Brush.Color = Color.FromArgb((int)(byte)255, (int)(byte)127, (int)(byte)71);
      line4.Brush.Solid = true;
      line4.Brush.Visible = true;
      line4.Color = Color.FromArgb((int)(byte)255, (int)(byte)127, (int)(byte)71);
      line4.Cursor = cursor1;
      line4.CustomVertAxis = axis4;
      line4.DataSource = highLow1;
      line4.Function = rootMeanSquare1;
      // 
      // 
      // 
      // 
      // 
      // 
      line4.Legend.Brush.Color = Color.White;
      line4.Legend.Brush.Solid = true;
      line4.Legend.Brush.Visible = true;
      // 
      // 
      // 
      line4.Legend.Font.Bold = false;
      // 
      // 
      // 
      line4.Legend.Font.Brush.Color = Color.Black;
      line4.Legend.Font.Brush.Solid = true;
      line4.Legend.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      line4.Legend.Font.Shadow.Brush.Color = Color.DarkGray;
      line4.Legend.Font.Shadow.Brush.Solid = true;
      line4.Legend.Font.Shadow.Brush.Visible = true;
      line4.Legend.Font.Size = 8;
      line4.Legend.Font.SizeFloat = 8F;
      line4.Legend.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      line4.Legend.ImageBevel.Brush.Color = Color.LightGray;
      line4.Legend.ImageBevel.Brush.Solid = true;
      line4.Legend.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      line4.Legend.Shadow.Brush.Color = Color.DarkGray;
      line4.Legend.Shadow.Brush.Solid = true;
      line4.Legend.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      line4.Marks.Brush.Color = Color.FromArgb((int)(byte)255, (int)(byte)255, (int)(byte)255);
      line4.Marks.Brush.Solid = true;
      line4.Marks.Brush.Visible = true;
      // 
      // 
      // 
      line4.Marks.Font.Bold = false;
      // 
      // 
      // 
      line4.Marks.Font.Brush.Color = Color.Black;
      line4.Marks.Font.Brush.Solid = true;
      line4.Marks.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      line4.Marks.Font.Shadow.Brush.Color = Color.DarkGray;
      line4.Marks.Font.Shadow.Brush.Solid = true;
      line4.Marks.Font.Shadow.Brush.Visible = true;
      line4.Marks.Font.Size = 8;
      line4.Marks.Font.SizeFloat = 8F;
      line4.Marks.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      line4.Marks.ImageBevel.Brush.Color = Color.LightGray;
      line4.Marks.ImageBevel.Brush.Solid = true;
      line4.Marks.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      line4.Marks.Shadow.Brush.Color = Color.Gray;
      line4.Marks.Shadow.Brush.Solid = true;
      line4.Marks.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      line4.Marks.Symbol.Brush.Color = Color.White;
      line4.Marks.Symbol.Brush.Solid = true;
      line4.Marks.Symbol.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      line4.Marks.Symbol.ImageBevel.Brush.Color = Color.LightGray;
      line4.Marks.Symbol.ImageBevel.Brush.Solid = true;
      line4.Marks.Symbol.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      line4.Marks.Symbol.Shadow.Brush.Color = Color.DarkGray;
      line4.Marks.Symbol.Shadow.Brush.Solid = true;
      line4.Marks.Symbol.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      line4.Pointer.Brush.Color = Color.FromArgb((int)(byte)255, (int)(byte)255, (int)(byte)255);
      line4.Pointer.Brush.Solid = true;
      line4.Pointer.Brush.Visible = true;
      line4.Title = "line2";
      line4.VertAxis = Steema.TeeChart.Styles.VerticalAxis.Custom;
      // 
      // 
      // 
      line4.XValues.DateTime = true;
      line4.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
      line4.XValues.Value = new double[]
  {
    46137.212337731478D,
    46147.212337731478D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
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
      line4.YValues.Value = new double[]
  {
    510.107850687598D,
    578.01007323963836D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
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
      // rootMeanSquare1
      // 
      rootMeanSquare1.Period = 10D;
      // 
      // colorBand1
      // 
      colorBand1.Axis = axis3;
      colorBand1.AxisIndex = -1;
      // 
      // 
      // 
      colorBand1.Brush.Color = Color.FromArgb((int)(byte)102, (int)(byte)190, (int)(byte)190, (int)(byte)0);
      colorBand1.Brush.Solid = true;
      colorBand1.Brush.Visible = true;
      colorBand1.End = 110D;
      // 
      // 
      // 
      colorBand1.Pen.Visible = false;
      colorBand1.ResizeEnd = false;
      colorBand1.ResizeStart = false;
      colorBand1.Start = 10D;
      // 
      // colorBand2
      // 
      colorBand2.Axis = axis4;
      colorBand2.AxisIndex = -1;
      // 
      // 
      // 
      colorBand2.Brush.Color = Color.FromArgb((int)(byte)97, (int)(byte)192, (int)(byte)192, (int)(byte)192);
      colorBand2.Brush.Solid = true;
      colorBand2.Brush.Visible = true;
      colorBand2.End = 940D;
      // 
      // 
      // 
      colorBand2.Pen.Visible = false;
      colorBand2.ResizeEnd = false;
      colorBand2.ResizeStart = false;
      colorBand2.Start = 1000D;
      // 
      // annotation1
      // 
      annotation1.AutoSize = true;
      // 
      // 
      // 
      annotation1.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
      annotation1.Callout.ArrowHeadDirection = Steema.TeeChart.Styles.ArrowHeadDirection.FromPoint;
      annotation1.Callout.ArrowHeadSize = 8;
      // 
      // 
      // 
      annotation1.Callout.Brush.Color = Color.Black;
      annotation1.Callout.Brush.Solid = true;
      annotation1.Callout.Brush.Visible = true;
      annotation1.Callout.Distance = 0;
      annotation1.Callout.Draw3D = false;
      annotation1.Callout.XPosition = 0;
      annotation1.Callout.YPosition = 0;
      annotation1.Callout.ZPosition = 0;
      annotation1.Cursor = cursor1;
      annotation1.Left = 6;
      annotation1.Position = Steema.TeeChart.Tools.AnnotationPositions.Custom;
      annotation1.PositionUnits = Steema.TeeChart.PositionUnits.Percent;
      // 
      // 
      // 
      annotation1.Shape.Bottom = 27;
      // 
      // 
      // 
      annotation1.Shape.Brush.Color = Color.White;
      annotation1.Shape.Brush.Solid = true;
      annotation1.Shape.Brush.Visible = true;
      annotation1.Shape.CustomPosition = true;
      // 
      // 
      // 
      annotation1.Shape.Font.Bold = false;
      // 
      // 
      // 
      annotation1.Shape.Font.Brush.Color = Color.FromArgb((int)(byte)190, (int)(byte)190, (int)(byte)0);
      annotation1.Shape.Font.Brush.Solid = true;
      annotation1.Shape.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      annotation1.Shape.Font.Shadow.Brush.Color = Color.DarkGray;
      annotation1.Shape.Font.Shadow.Brush.Solid = true;
      annotation1.Shape.Font.Shadow.Brush.Visible = true;
      annotation1.Shape.Font.Size = 8;
      annotation1.Shape.Font.SizeFloat = 8F;
      annotation1.Shape.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      annotation1.Shape.ImageBevel.Brush.Color = Color.LightGray;
      annotation1.Shape.ImageBevel.Brush.Solid = true;
      annotation1.Shape.ImageBevel.Brush.Visible = true;
      annotation1.Shape.Left = 6;
      annotation1.Shape.Lines = new string[]
  {
    "Safe Upper limit"
  };
      annotation1.Shape.Right = 79;
      // 
      // 
      // 
      // 
      // 
      // 
      annotation1.Shape.Shadow.Brush.Color = Color.DarkGray;
      annotation1.Shape.Shadow.Brush.Solid = true;
      annotation1.Shape.Shadow.Brush.Visible = true;
      annotation1.Shape.Top = 8;
      annotation1.Shape.Transparent = true;
      annotation1.Text = "Safe Upper limit";
      annotation1.Top = 8;
      // 
      // annotation2
      // 
      annotation2.AutoSize = true;
      // 
      // 
      // 
      annotation2.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
      annotation2.Callout.ArrowHeadDirection = Steema.TeeChart.Styles.ArrowHeadDirection.FromPoint;
      annotation2.Callout.ArrowHeadSize = 8;
      // 
      // 
      // 
      annotation2.Callout.Brush.Color = Color.Black;
      annotation2.Callout.Brush.Solid = true;
      annotation2.Callout.Brush.Visible = true;
      annotation2.Callout.Distance = 0;
      annotation2.Callout.Draw3D = false;
      annotation2.Callout.XPosition = 0;
      annotation2.Callout.YPosition = 0;
      annotation2.Callout.ZPosition = 0;
      annotation2.Cursor = cursor1;
      annotation2.Left = 6;
      annotation2.Position = Steema.TeeChart.Tools.AnnotationPositions.Custom;
      annotation2.PositionUnits = Steema.TeeChart.PositionUnits.Percent;
      // 
      // 
      // 
      annotation2.Shape.Bottom = 27;
      // 
      // 
      // 
      annotation2.Shape.Brush.Color = Color.White;
      annotation2.Shape.Brush.Solid = true;
      annotation2.Shape.Brush.Visible = true;
      annotation2.Shape.CustomPosition = true;
      // 
      // 
      // 
      annotation2.Shape.Font.Bold = false;
      // 
      // 
      // 
      annotation2.Shape.Font.Brush.Color = Color.FromArgb((int)(byte)190, (int)(byte)190, (int)(byte)0);
      annotation2.Shape.Font.Brush.Solid = true;
      annotation2.Shape.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      annotation2.Shape.Font.Shadow.Brush.Color = Color.DarkGray;
      annotation2.Shape.Font.Shadow.Brush.Solid = true;
      annotation2.Shape.Font.Shadow.Brush.Visible = true;
      annotation2.Shape.Font.Size = 8;
      annotation2.Shape.Font.SizeFloat = 8F;
      annotation2.Shape.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      annotation2.Shape.ImageBevel.Brush.Color = Color.LightGray;
      annotation2.Shape.ImageBevel.Brush.Solid = true;
      annotation2.Shape.ImageBevel.Brush.Visible = true;
      annotation2.Shape.Left = 6;
      annotation2.Shape.Lines = new string[]
  {
    "Safe Lower limit"
  };
      annotation2.Shape.Right = 79;
      // 
      // 
      // 
      // 
      // 
      // 
      annotation2.Shape.Shadow.Brush.Color = Color.DarkGray;
      annotation2.Shape.Shadow.Brush.Solid = true;
      annotation2.Shape.Shadow.Brush.Visible = true;
      annotation2.Shape.Top = 8;
      annotation2.Shape.Transparent = true;
      annotation2.Text = "Safe Lower limit";
      annotation2.Top = 8;
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
      tChart7.Axes.Bottom.Labels.Font.Brush.Color = Color.FromArgb((int)(byte)255, (int)(byte)255, (int)(byte)255);
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
      tChart7.Axes.Bottom.Title.Font.Brush.Color = Color.FromArgb((int)(byte)0, (int)(byte)0, (int)(byte)0);
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
      tChart7.Axes.Depth.Labels.Font.Brush.Color = Color.FromArgb((int)(byte)255, (int)(byte)255, (int)(byte)255);
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
      tChart7.Axes.Depth.Title.Font.Brush.Color = Color.FromArgb((int)(byte)0, (int)(byte)0, (int)(byte)0);
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
      tChart7.Axes.DepthTop.Labels.Font.Brush.Color = Color.FromArgb((int)(byte)255, (int)(byte)255, (int)(byte)255);
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
      tChart7.Axes.DepthTop.Title.Font.Brush.Color = Color.FromArgb((int)(byte)0, (int)(byte)0, (int)(byte)0);
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
      tChart7.Axes.Left.AxisPen.Color = Color.FromArgb((int)(byte)128, (int)(byte)128, (int)(byte)255);
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
      tChart7.Axes.Left.Labels.Font.Brush.Color = Color.FromArgb((int)(byte)255, (int)(byte)255, (int)(byte)255);
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
      tChart7.Axes.Left.Title.Font.Brush.Color = Color.FromArgb((int)(byte)255, (int)(byte)255, (int)(byte)255);
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
      tChart7.Axes.Right.AxisPen.Color = Color.FromArgb((int)(byte)255, (int)(byte)192, (int)(byte)128);
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
      tChart7.Axes.Right.Labels.Font.Brush.Color = Color.FromArgb((int)(byte)255, (int)(byte)255, (int)(byte)255);
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
      tChart7.Axes.Right.Title.Font.Brush.Color = Color.FromArgb((int)(byte)255, (int)(byte)255, (int)(byte)255);
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
      tChart7.Axes.Top.Labels.Font.Brush.Color = Color.FromArgb((int)(byte)255, (int)(byte)255, (int)(byte)255);
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
      tChart7.Axes.Top.Title.Font.Brush.Color = Color.FromArgb((int)(byte)0, (int)(byte)0, (int)(byte)0);
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
      tChart7.Footer.Alignment = Steema.TeeChart.Drawing.StringAlignment.Near;
      tChart7.Footer.Bottom = 349;
      // 
      // 
      // 
      tChart7.Footer.Brush.Color = Color.Silver;
      tChart7.Footer.Brush.Solid = true;
      tChart7.Footer.Brush.Visible = true;
      tChart7.Footer.CustomPosition = true;
      // 
      // 
      // 
      tChart7.Footer.Font.Bold = false;
      // 
      // 
      // 
      tChart7.Footer.Font.Brush.Color = Color.FromArgb((int)(byte)192, (int)(byte)192, (int)(byte)192);
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
      tChart7.Footer.Left = 640;
      tChart7.Footer.Lines = new string[]
  {
    "Cycles"
  };
      tChart7.Footer.Right = 694;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart7.Footer.Shadow.Brush.Color = Color.DarkGray;
      tChart7.Footer.Shadow.Brush.Solid = true;
      tChart7.Footer.Shadow.Brush.Visible = true;
      tChart7.Footer.Top = 334;
      tChart7.Footer.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart7.Header.Brush.Color = Color.FromArgb((int)(byte)192, (int)(byte)192, (int)(byte)192);
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
      tChart7.Header.Font.Brush.Color = Color.FromArgb((int)(byte)255, (int)(byte)255, (int)(byte)255);
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
      tChart7.Header.Shadow.Brush.Color = Color.FromArgb((int)(byte)169, (int)(byte)169, (int)(byte)169);
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
      tChart7.Legend.Font.Brush.Color = Color.FromArgb((int)(byte)255, (int)(byte)255, (int)(byte)255);
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
      tChart7.Legend.Shadow.Brush.Color = Color.FromArgb((int)(byte)0, (int)(byte)0, (int)(byte)0);
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
      tChart7.Location = new Point(0, 0);
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
      tChart7.Panel.Brush.Color = Color.FromArgb((int)(byte)240, (int)(byte)240, (int)(byte)240);
      // 
      // 
      // 
      tChart7.Panel.Brush.Gradient.EndColor = Color.FromArgb((int)(byte)70, (int)(byte)70, (int)(byte)70);
      tChart7.Panel.Brush.Gradient.MiddleColor = Color.FromArgb((int)(byte)0, (int)(byte)0, (int)(byte)0, (int)(byte)0);
      tChart7.Panel.Brush.Gradient.SigmaFocus = 0F;
      tChart7.Panel.Brush.Gradient.SigmaScale = 0F;
      tChart7.Panel.Brush.Gradient.StartColor = Color.FromArgb((int)(byte)70, (int)(byte)70, (int)(byte)70);
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
      tChart7.Panel.MarginLeft = 4D;
      tChart7.Panel.MarginRight = 10D;
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
      margins2.Bottom = 100;
      margins2.Left = 100;
      margins2.Right = 100;
      margins2.Top = 100;
      tChart7.Printer.Margins = margins2;
      tChart7.Series.Add(area1);
      tChart7.Series.Add(line1);
      tChart7.Series.Add(line2);
      tChart7.Series.Add(bar3D1);
      tChart7.Size = new Size(705, 365);
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
      tChart7.SubHeader.Brush.Color = Color.FromArgb((int)(byte)192, (int)(byte)192, (int)(byte)192);
      tChart7.SubHeader.Brush.Solid = true;
      tChart7.SubHeader.Brush.Visible = true;
      // 
      // 
      // 
      tChart7.SubHeader.Font.Bold = false;
      // 
      // 
      // 
      tChart7.SubHeader.Font.Brush.Color = Color.FromArgb((int)(byte)128, (int)(byte)128, (int)(byte)128);
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
      tChart7.SubHeader.Shadow.Brush.Color = Color.FromArgb((int)(byte)169, (int)(byte)169, (int)(byte)169);
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
      tChart7.Walls.Back.Brush.Gradient.EndColor = Color.FromArgb((int)(byte)120, (int)(byte)120, (int)(byte)120);
      tChart7.Walls.Back.Brush.Gradient.StartColor = Color.FromArgb((int)(byte)70, (int)(byte)70, (int)(byte)70);
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
      tChart7.Walls.Right.Brush.Color = Color.FromArgb((int)(byte)192, (int)(byte)192, (int)(byte)192);
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
      tChart7.Zoom.Brush.Color = Color.FromArgb((int)(byte)127, (int)(byte)0, (int)(byte)0, (int)(byte)255);
      tChart7.Zoom.Brush.Solid = true;
      tChart7.Zoom.Brush.Visible = false;
      tChart7.AfterDraw += (this.tChart7_AfterDraw);
      // 
      // axis1
      // 
      // 
      // 
      // 
      axis1.AxisPen.Color = Color.FromArgb((int)(byte)255, (int)(byte)128, (int)(byte)0);
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
      axis1.Labels.Font.Brush.Color = Color.FromArgb((int)(byte)192, (int)(byte)192, (int)(byte)192);
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
      axis1.RelativePosition = -11D;
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
      axis1.Title.Font.Brush.Color = Color.FromArgb((int)(byte)255, (int)(byte)255, (int)(byte)255);
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
      axis2.AxisPen.Color = Color.FromArgb((int)(byte)192, (int)(byte)192, (int)(byte)255);
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
      axis2.Labels.Font.Brush.Color = Color.FromArgb((int)(byte)192, (int)(byte)192, (int)(byte)192);
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
      axis2.Title.Font.Brush.Color = Color.FromArgb((int)(byte)255, (int)(byte)255, (int)(byte)255);
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
      area1.AreaBrush.Color = Color.FromArgb((int)(byte)119, (int)(byte)153, (int)(byte)214);
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
      area1.AreaLines.Color = Color.FromArgb((int)(byte)71, (int)(byte)92, (int)(byte)128);
      area1.AreaLines.Visible = false;
      // 
      // 
      // 
      area1.Brush.Color = Color.FromArgb((int)(byte)119, (int)(byte)153, (int)(byte)214);
      area1.Brush.Solid = true;
      area1.Brush.Visible = true;
      area1.Color = Color.FromArgb((int)(byte)119, (int)(byte)153, (int)(byte)214);
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
      area1.Marks.Brush.Color = Color.FromArgb((int)(byte)255, (int)(byte)255, (int)(byte)255);
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
      area1.Pointer.Brush.Color = Color.FromArgb((int)(byte)255, (int)(byte)255, (int)(byte)255);
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
    46132.712340196762D,
    46133.712340196762D,
    46134.712340196762D,
    46135.712340196762D,
    46136.712340196762D,
    46137.712340196762D,
    46138.712340196762D,
    46139.712340196762D,
    46140.712340196762D,
    46141.712340196762D,
    46142.712340196762D,
    46143.712340196762D,
    46144.712340196762D,
    46145.712340196762D,
    46146.712340196762D,
    46147.712340196762D,
    46148.712340196762D,
    46149.712340196762D,
    46150.712340196762D,
    46151.712340196762D,
    46152.712340196762D,
    46153.712340196762D,
    46154.712340196762D,
    46155.712340196762D,
    46156.712340196762D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
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
    130D,
    134D,
    61D,
    63D,
    136D,
    46D,
    106D,
    61D,
    55D,
    17D,
    97D,
    113D,
    2D,
    17D,
    132D,
    49D,
    60D,
    85D,
    13D,
    70D,
    45D,
    95D,
    175D,
    261D,
    318D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
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
      line1.Brush.Color = Color.FromArgb((int)(byte)255, (int)(byte)207, (int)(byte)104);
      line1.Brush.Solid = true;
      line1.Brush.Visible = true;
      line1.Color = Color.FromArgb((int)(byte)255, (int)(byte)207, (int)(byte)104);
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
      line1.Marks.Brush.Color = Color.FromArgb((int)(byte)255, (int)(byte)255, (int)(byte)255);
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
      line1.Pointer.Brush.Color = Color.FromArgb((int)(byte)255, (int)(byte)255, (int)(byte)255);
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
    46132.712340196762D,
    46133.712340196762D,
    46134.712340196762D,
    46135.712340196762D,
    46136.712340196762D,
    46137.712340196762D,
    46138.712340196762D,
    46139.712340196762D,
    46140.712340196762D,
    46141.712340196762D,
    46142.712340196762D,
    46143.712340196762D,
    46144.712340196762D,
    46145.712340196762D,
    46146.712340196762D,
    46147.712340196762D,
    46148.712340196762D,
    46149.712340196762D,
    46150.712340196762D,
    46151.712340196762D,
    46152.712340196762D,
    46153.712340196762D,
    46154.712340196762D,
    46155.712340196762D,
    46156.712340196762D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
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
    1032D,
    1100D,
    1074D,
    1149D,
    1139D,
    1174D,
    1075D,
    956D,
    1069D,
    1028D,
    975D,
    961D,
    1057D,
    942D,
    1018D,
    942D,
    1027D,
    1054D,
    1008D,
    1069D,
    1051D,
    1135D,
    1157D,
    1146D,
    1255D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
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
      line2.Brush.Color = Color.FromArgb((int)(byte)255, (int)(byte)127, (int)(byte)71);
      line2.Brush.Solid = true;
      line2.Brush.Visible = true;
      line2.Color = Color.FromArgb((int)(byte)255, (int)(byte)127, (int)(byte)71);
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
      line2.Marks.Brush.Color = Color.FromArgb((int)(byte)255, (int)(byte)255, (int)(byte)255);
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
      line2.Pointer.Brush.Color = Color.FromArgb((int)(byte)255, (int)(byte)255, (int)(byte)255);
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
    46132.712340196762D,
    46133.712340196762D,
    46134.712340196762D,
    46135.712340196762D,
    46136.712340196762D,
    46137.712340196762D,
    46138.712340196762D,
    46139.712340196762D,
    46140.712340196762D,
    46141.712340196762D,
    46142.712340196762D,
    46143.712340196762D,
    46144.712340196762D,
    46145.712340196762D,
    46146.712340196762D,
    46147.712340196762D,
    46148.712340196762D,
    46149.712340196762D,
    46150.712340196762D,
    46151.712340196762D,
    46152.712340196762D,
    46153.712340196762D,
    46154.712340196762D,
    46155.712340196762D,
    46156.712340196762D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
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
    868D,
    750D,
    855D,
    889D,
    888D,
    938D,
    865D,
    757D,
    730D,
    661D,
    755D,
    777D,
    707D,
    717D,
    654D,
    717D,
    734D,
    719D,
    840D,
    761D,
    700D,
    701D,
    814D,
    738D,
    730D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
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
      bar3D1.Brush.Color = Color.FromArgb((int)(byte)129, (int)(byte)202, (int)(byte)219);
      bar3D1.Brush.Solid = true;
      bar3D1.Brush.Visible = true;
      bar3D1.Color = Color.FromArgb((int)(byte)129, (int)(byte)202, (int)(byte)219);
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
      bar3D1.Marks.Brush.Color = Color.FromArgb((int)(byte)255, (int)(byte)255, (int)(byte)255);
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
    46132.712340196762D,
    46137.512340196765D,
    46142.312340196768D,
    46147.112340196771D,
    46151.912340196774D,
    46156.712340196776D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
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
    700.95594328407D,
    232.96401775580085D,
    325.50441603898275D,
    237.53816108570348D,
    533.67343917660116D,
    404.32547120113179D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
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
      cursorTool1.Pen.Color = Color.FromArgb((int)(byte)255, (int)(byte)255, (int)(byte)255);
      cursorTool1.Pen.Style = Steema.TeeChart.Drawing.DashStyle.Dash;
      cursorTool1.Series = line2;
      cursorTool1.SeriesIndex = -1;
      cursorTool1.Change += (this.cursorTool1_Change);
      // 
      // tChart5
      // 
      // 
      // 
      // 
      tChart5.Aspect.Chart3DPercent = 90;
      tChart5.Aspect.ColorPaletteIndex = 21;
      tChart5.Aspect.Elevation = 348;
      tChart5.Aspect.ElevationFloat = 348D;
      tChart5.Aspect.Orthogonal = false;
      tChart5.Aspect.Perspective = 96;
      tChart5.Aspect.Rotation = 327;
      tChart5.Aspect.RotationFloat = 327D;
      tChart5.Aspect.View3D = true;
      tChart5.Aspect.Zoom = 63;
      tChart5.Aspect.ZoomFloat = 63D;
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
      tChart5.Axes.Bottom.Labels.Brush.Color = Color.White;
      tChart5.Axes.Bottom.Labels.Brush.Solid = true;
      tChart5.Axes.Bottom.Labels.Brush.Visible = true;
      // 
      // 
      // 
      tChart5.Axes.Bottom.Labels.Font.Bold = false;
      // 
      // 
      // 
      tChart5.Axes.Bottom.Labels.Font.Brush.Color = Color.FromArgb((int)(byte)255, (int)(byte)255, (int)(byte)255);
      tChart5.Axes.Bottom.Labels.Font.Brush.Solid = true;
      tChart5.Axes.Bottom.Labels.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart5.Axes.Bottom.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart5.Axes.Bottom.Labels.Font.Shadow.Brush.Solid = true;
      tChart5.Axes.Bottom.Labels.Font.Shadow.Brush.Visible = true;
      tChart5.Axes.Bottom.Labels.Font.Size = 8;
      tChart5.Axes.Bottom.Labels.Font.SizeFloat = 8F;
      tChart5.Axes.Bottom.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart5.Axes.Bottom.Labels.ImageBevel.Brush.Color = Color.LightGray;
      tChart5.Axes.Bottom.Labels.ImageBevel.Brush.Solid = true;
      tChart5.Axes.Bottom.Labels.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart5.Axes.Bottom.Labels.Shadow.Brush.Color = Color.DarkGray;
      tChart5.Axes.Bottom.Labels.Shadow.Brush.Solid = true;
      tChart5.Axes.Bottom.Labels.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart5.Axes.Bottom.Title.Brush.Color = Color.Silver;
      tChart5.Axes.Bottom.Title.Brush.Solid = true;
      tChart5.Axes.Bottom.Title.Brush.Visible = true;
      tChart5.Axes.Bottom.Title.Caption = "m2 area";
      // 
      // 
      // 
      tChart5.Axes.Bottom.Title.Font.Bold = false;
      // 
      // 
      // 
      tChart5.Axes.Bottom.Title.Font.Brush.Color = Color.FromArgb((int)(byte)224, (int)(byte)224, (int)(byte)224);
      tChart5.Axes.Bottom.Title.Font.Brush.Solid = true;
      tChart5.Axes.Bottom.Title.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart5.Axes.Bottom.Title.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart5.Axes.Bottom.Title.Font.Shadow.Brush.Solid = true;
      tChart5.Axes.Bottom.Title.Font.Shadow.Brush.Visible = true;
      tChart5.Axes.Bottom.Title.Font.Size = 11;
      tChart5.Axes.Bottom.Title.Font.SizeFloat = 11F;
      tChart5.Axes.Bottom.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart5.Axes.Bottom.Title.ImageBevel.Brush.Color = Color.LightGray;
      tChart5.Axes.Bottom.Title.ImageBevel.Brush.Solid = true;
      tChart5.Axes.Bottom.Title.ImageBevel.Brush.Visible = true;
      tChart5.Axes.Bottom.Title.Lines = new string[]
  {
    "m2 area"
  };
      // 
      // 
      // 
      // 
      // 
      // 
      tChart5.Axes.Bottom.Title.Shadow.Brush.Color = Color.DarkGray;
      tChart5.Axes.Bottom.Title.Shadow.Brush.Solid = true;
      tChart5.Axes.Bottom.Title.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      tChart5.Axes.Depth.Increment = 0.2D;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart5.Axes.Depth.Labels.Brush.Color = Color.White;
      tChart5.Axes.Depth.Labels.Brush.Solid = true;
      tChart5.Axes.Depth.Labels.Brush.Visible = true;
      // 
      // 
      // 
      tChart5.Axes.Depth.Labels.Font.Bold = false;
      // 
      // 
      // 
      tChart5.Axes.Depth.Labels.Font.Brush.Color = Color.FromArgb((int)(byte)255, (int)(byte)255, (int)(byte)255);
      tChart5.Axes.Depth.Labels.Font.Brush.Solid = true;
      tChart5.Axes.Depth.Labels.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart5.Axes.Depth.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart5.Axes.Depth.Labels.Font.Shadow.Brush.Solid = true;
      tChart5.Axes.Depth.Labels.Font.Shadow.Brush.Visible = true;
      tChart5.Axes.Depth.Labels.Font.Size = 8;
      tChart5.Axes.Depth.Labels.Font.SizeFloat = 8F;
      tChart5.Axes.Depth.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart5.Axes.Depth.Labels.ImageBevel.Brush.Color = Color.LightGray;
      tChart5.Axes.Depth.Labels.ImageBevel.Brush.Solid = true;
      tChart5.Axes.Depth.Labels.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart5.Axes.Depth.Labels.Shadow.Brush.Color = Color.DarkGray;
      tChart5.Axes.Depth.Labels.Shadow.Brush.Solid = true;
      tChart5.Axes.Depth.Labels.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart5.Axes.Depth.Title.Brush.Color = Color.Silver;
      tChart5.Axes.Depth.Title.Brush.Solid = true;
      tChart5.Axes.Depth.Title.Brush.Visible = true;
      // 
      // 
      // 
      tChart5.Axes.Depth.Title.Font.Bold = false;
      // 
      // 
      // 
      tChart5.Axes.Depth.Title.Font.Brush.Color = Color.FromArgb((int)(byte)0, (int)(byte)0, (int)(byte)0);
      tChart5.Axes.Depth.Title.Font.Brush.Solid = true;
      tChart5.Axes.Depth.Title.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart5.Axes.Depth.Title.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart5.Axes.Depth.Title.Font.Shadow.Brush.Solid = true;
      tChart5.Axes.Depth.Title.Font.Shadow.Brush.Visible = true;
      tChart5.Axes.Depth.Title.Font.Size = 8;
      tChart5.Axes.Depth.Title.Font.SizeFloat = 8F;
      tChart5.Axes.Depth.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart5.Axes.Depth.Title.ImageBevel.Brush.Color = Color.LightGray;
      tChart5.Axes.Depth.Title.ImageBevel.Brush.Solid = true;
      tChart5.Axes.Depth.Title.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart5.Axes.Depth.Title.Shadow.Brush.Color = Color.DarkGray;
      tChart5.Axes.Depth.Title.Shadow.Brush.Solid = true;
      tChart5.Axes.Depth.Title.Shadow.Brush.Visible = true;
      tChart5.Axes.Depth.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      tChart5.Axes.DepthTop.Labels.Brush.Color = Color.White;
      tChart5.Axes.DepthTop.Labels.Brush.Solid = true;
      tChart5.Axes.DepthTop.Labels.Brush.Visible = true;
      // 
      // 
      // 
      tChart5.Axes.DepthTop.Labels.Font.Bold = false;
      // 
      // 
      // 
      tChart5.Axes.DepthTop.Labels.Font.Brush.Color = Color.FromArgb((int)(byte)255, (int)(byte)255, (int)(byte)255);
      tChart5.Axes.DepthTop.Labels.Font.Brush.Solid = true;
      tChart5.Axes.DepthTop.Labels.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart5.Axes.DepthTop.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart5.Axes.DepthTop.Labels.Font.Shadow.Brush.Solid = true;
      tChart5.Axes.DepthTop.Labels.Font.Shadow.Brush.Visible = true;
      tChart5.Axes.DepthTop.Labels.Font.Size = 8;
      tChart5.Axes.DepthTop.Labels.Font.SizeFloat = 8F;
      tChart5.Axes.DepthTop.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart5.Axes.DepthTop.Labels.ImageBevel.Brush.Color = Color.LightGray;
      tChart5.Axes.DepthTop.Labels.ImageBevel.Brush.Solid = true;
      tChart5.Axes.DepthTop.Labels.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart5.Axes.DepthTop.Labels.Shadow.Brush.Color = Color.DarkGray;
      tChart5.Axes.DepthTop.Labels.Shadow.Brush.Solid = true;
      tChart5.Axes.DepthTop.Labels.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart5.Axes.DepthTop.Title.Brush.Color = Color.Silver;
      tChart5.Axes.DepthTop.Title.Brush.Solid = true;
      tChart5.Axes.DepthTop.Title.Brush.Visible = true;
      // 
      // 
      // 
      tChart5.Axes.DepthTop.Title.Font.Bold = false;
      // 
      // 
      // 
      tChart5.Axes.DepthTop.Title.Font.Brush.Color = Color.FromArgb((int)(byte)0, (int)(byte)0, (int)(byte)0);
      tChart5.Axes.DepthTop.Title.Font.Brush.Solid = true;
      tChart5.Axes.DepthTop.Title.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart5.Axes.DepthTop.Title.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart5.Axes.DepthTop.Title.Font.Shadow.Brush.Solid = true;
      tChart5.Axes.DepthTop.Title.Font.Shadow.Brush.Visible = true;
      tChart5.Axes.DepthTop.Title.Font.Size = 8;
      tChart5.Axes.DepthTop.Title.Font.SizeFloat = 8F;
      tChart5.Axes.DepthTop.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart5.Axes.DepthTop.Title.ImageBevel.Brush.Color = Color.LightGray;
      tChart5.Axes.DepthTop.Title.ImageBevel.Brush.Solid = true;
      tChart5.Axes.DepthTop.Title.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart5.Axes.DepthTop.Title.Shadow.Brush.Color = Color.DarkGray;
      tChart5.Axes.DepthTop.Title.Shadow.Brush.Solid = true;
      tChart5.Axes.DepthTop.Title.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      tChart5.Axes.Left.Labels.Brush.Color = Color.White;
      tChart5.Axes.Left.Labels.Brush.Solid = true;
      tChart5.Axes.Left.Labels.Brush.Visible = true;
      // 
      // 
      // 
      tChart5.Axes.Left.Labels.Font.Bold = false;
      // 
      // 
      // 
      tChart5.Axes.Left.Labels.Font.Brush.Color = Color.FromArgb((int)(byte)255, (int)(byte)255, (int)(byte)255);
      tChart5.Axes.Left.Labels.Font.Brush.Solid = true;
      tChart5.Axes.Left.Labels.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart5.Axes.Left.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart5.Axes.Left.Labels.Font.Shadow.Brush.Solid = true;
      tChart5.Axes.Left.Labels.Font.Shadow.Brush.Visible = true;
      tChart5.Axes.Left.Labels.Font.Size = 8;
      tChart5.Axes.Left.Labels.Font.SizeFloat = 8F;
      tChart5.Axes.Left.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart5.Axes.Left.Labels.ImageBevel.Brush.Color = Color.LightGray;
      tChart5.Axes.Left.Labels.ImageBevel.Brush.Solid = true;
      tChart5.Axes.Left.Labels.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart5.Axes.Left.Labels.Shadow.Brush.Color = Color.DarkGray;
      tChart5.Axes.Left.Labels.Shadow.Brush.Solid = true;
      tChart5.Axes.Left.Labels.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart5.Axes.Left.Title.Brush.Color = Color.Silver;
      tChart5.Axes.Left.Title.Brush.Solid = true;
      tChart5.Axes.Left.Title.Brush.Visible = true;
      tChart5.Axes.Left.Title.Caption = "ºC range";
      // 
      // 
      // 
      tChart5.Axes.Left.Title.Font.Bold = false;
      // 
      // 
      // 
      tChart5.Axes.Left.Title.Font.Brush.Color = Color.FromArgb((int)(byte)224, (int)(byte)224, (int)(byte)224);
      tChart5.Axes.Left.Title.Font.Brush.Solid = true;
      tChart5.Axes.Left.Title.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart5.Axes.Left.Title.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart5.Axes.Left.Title.Font.Shadow.Brush.Solid = true;
      tChart5.Axes.Left.Title.Font.Shadow.Brush.Visible = true;
      tChart5.Axes.Left.Title.Font.Size = 11;
      tChart5.Axes.Left.Title.Font.SizeFloat = 11F;
      tChart5.Axes.Left.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart5.Axes.Left.Title.ImageBevel.Brush.Color = Color.LightGray;
      tChart5.Axes.Left.Title.ImageBevel.Brush.Solid = true;
      tChart5.Axes.Left.Title.ImageBevel.Brush.Visible = true;
      tChart5.Axes.Left.Title.Lines = new string[]
  {
    "ºC range"
  };
      // 
      // 
      // 
      // 
      // 
      // 
      tChart5.Axes.Left.Title.Shadow.Brush.Color = Color.DarkGray;
      tChart5.Axes.Left.Title.Shadow.Brush.Solid = true;
      tChart5.Axes.Left.Title.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      tChart5.Axes.Right.Labels.Brush.Color = Color.White;
      tChart5.Axes.Right.Labels.Brush.Solid = true;
      tChart5.Axes.Right.Labels.Brush.Visible = true;
      // 
      // 
      // 
      tChart5.Axes.Right.Labels.Font.Bold = false;
      // 
      // 
      // 
      tChart5.Axes.Right.Labels.Font.Brush.Color = Color.FromArgb((int)(byte)255, (int)(byte)255, (int)(byte)255);
      tChart5.Axes.Right.Labels.Font.Brush.Solid = true;
      tChart5.Axes.Right.Labels.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart5.Axes.Right.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart5.Axes.Right.Labels.Font.Shadow.Brush.Solid = true;
      tChart5.Axes.Right.Labels.Font.Shadow.Brush.Visible = true;
      tChart5.Axes.Right.Labels.Font.Size = 8;
      tChart5.Axes.Right.Labels.Font.SizeFloat = 8F;
      tChart5.Axes.Right.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart5.Axes.Right.Labels.ImageBevel.Brush.Color = Color.LightGray;
      tChart5.Axes.Right.Labels.ImageBevel.Brush.Solid = true;
      tChart5.Axes.Right.Labels.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart5.Axes.Right.Labels.Shadow.Brush.Color = Color.DarkGray;
      tChart5.Axes.Right.Labels.Shadow.Brush.Solid = true;
      tChart5.Axes.Right.Labels.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart5.Axes.Right.Title.Brush.Color = Color.Silver;
      tChart5.Axes.Right.Title.Brush.Solid = true;
      tChart5.Axes.Right.Title.Brush.Visible = true;
      // 
      // 
      // 
      tChart5.Axes.Right.Title.Font.Bold = false;
      // 
      // 
      // 
      tChart5.Axes.Right.Title.Font.Brush.Color = Color.FromArgb((int)(byte)0, (int)(byte)0, (int)(byte)0);
      tChart5.Axes.Right.Title.Font.Brush.Solid = true;
      tChart5.Axes.Right.Title.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart5.Axes.Right.Title.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart5.Axes.Right.Title.Font.Shadow.Brush.Solid = true;
      tChart5.Axes.Right.Title.Font.Shadow.Brush.Visible = true;
      tChart5.Axes.Right.Title.Font.Size = 8;
      tChart5.Axes.Right.Title.Font.SizeFloat = 8F;
      tChart5.Axes.Right.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart5.Axes.Right.Title.ImageBevel.Brush.Color = Color.LightGray;
      tChart5.Axes.Right.Title.ImageBevel.Brush.Solid = true;
      tChart5.Axes.Right.Title.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart5.Axes.Right.Title.Shadow.Brush.Color = Color.DarkGray;
      tChart5.Axes.Right.Title.Shadow.Brush.Solid = true;
      tChart5.Axes.Right.Title.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      tChart5.Axes.Top.Labels.Brush.Color = Color.White;
      tChart5.Axes.Top.Labels.Brush.Solid = true;
      tChart5.Axes.Top.Labels.Brush.Visible = true;
      // 
      // 
      // 
      tChart5.Axes.Top.Labels.Font.Bold = false;
      // 
      // 
      // 
      tChart5.Axes.Top.Labels.Font.Brush.Color = Color.FromArgb((int)(byte)255, (int)(byte)255, (int)(byte)255);
      tChart5.Axes.Top.Labels.Font.Brush.Solid = true;
      tChart5.Axes.Top.Labels.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart5.Axes.Top.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart5.Axes.Top.Labels.Font.Shadow.Brush.Solid = true;
      tChart5.Axes.Top.Labels.Font.Shadow.Brush.Visible = true;
      tChart5.Axes.Top.Labels.Font.Size = 8;
      tChart5.Axes.Top.Labels.Font.SizeFloat = 8F;
      tChart5.Axes.Top.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart5.Axes.Top.Labels.ImageBevel.Brush.Color = Color.LightGray;
      tChart5.Axes.Top.Labels.ImageBevel.Brush.Solid = true;
      tChart5.Axes.Top.Labels.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart5.Axes.Top.Labels.Shadow.Brush.Color = Color.DarkGray;
      tChart5.Axes.Top.Labels.Shadow.Brush.Solid = true;
      tChart5.Axes.Top.Labels.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart5.Axes.Top.Title.Brush.Color = Color.Silver;
      tChart5.Axes.Top.Title.Brush.Solid = true;
      tChart5.Axes.Top.Title.Brush.Visible = true;
      // 
      // 
      // 
      tChart5.Axes.Top.Title.Font.Bold = false;
      // 
      // 
      // 
      tChart5.Axes.Top.Title.Font.Brush.Color = Color.FromArgb((int)(byte)0, (int)(byte)0, (int)(byte)0);
      tChart5.Axes.Top.Title.Font.Brush.Solid = true;
      tChart5.Axes.Top.Title.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart5.Axes.Top.Title.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart5.Axes.Top.Title.Font.Shadow.Brush.Solid = true;
      tChart5.Axes.Top.Title.Font.Shadow.Brush.Visible = true;
      tChart5.Axes.Top.Title.Font.Size = 8;
      tChart5.Axes.Top.Title.Font.SizeFloat = 8F;
      tChart5.Axes.Top.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart5.Axes.Top.Title.ImageBevel.Brush.Color = Color.LightGray;
      tChart5.Axes.Top.Title.ImageBevel.Brush.Solid = true;
      tChart5.Axes.Top.Title.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart5.Axes.Top.Title.Shadow.Brush.Color = Color.DarkGray;
      tChart5.Axes.Top.Title.Shadow.Brush.Solid = true;
      tChart5.Axes.Top.Title.Shadow.Brush.Visible = true;
      tChart5.Dock = DockStyle.Fill;
      // 
      // 
      // 
      tChart5.Footer.Alignment = Steema.TeeChart.Drawing.StringAlignment.Near;
      // 
      // 
      // 
      tChart5.Footer.Brush.Color = Color.Silver;
      tChart5.Footer.Brush.Solid = true;
      tChart5.Footer.Brush.Visible = true;
      // 
      // 
      // 
      tChart5.Footer.Font.Bold = false;
      // 
      // 
      // 
      tChart5.Footer.Font.Brush.Color = Color.FromArgb((int)(byte)192, (int)(byte)192, (int)(byte)192);
      tChart5.Footer.Font.Brush.Solid = true;
      tChart5.Footer.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart5.Footer.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart5.Footer.Font.Shadow.Brush.Solid = true;
      tChart5.Footer.Font.Shadow.Brush.Visible = true;
      tChart5.Footer.Font.Size = 8;
      tChart5.Footer.Font.SizeFloat = 8F;
      tChart5.Footer.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart5.Footer.ImageBevel.Brush.Color = Color.LightGray;
      tChart5.Footer.ImageBevel.Brush.Solid = true;
      tChart5.Footer.ImageBevel.Brush.Visible = true;
      tChart5.Footer.Lines = new string[]
  {
    "Heat profile"
  };
      // 
      // 
      // 
      // 
      // 
      // 
      tChart5.Footer.Shadow.Brush.Color = Color.DarkGray;
      tChart5.Footer.Shadow.Brush.Solid = true;
      tChart5.Footer.Shadow.Brush.Visible = true;
      tChart5.Footer.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart5.Header.Brush.Color = Color.FromArgb((int)(byte)192, (int)(byte)192, (int)(byte)192);
      // 
      // 
      // 
      tChart5.Header.Brush.Gradient.SigmaFocus = 0F;
      tChart5.Header.Brush.Gradient.SigmaScale = 0F;
      tChart5.Header.Brush.Solid = true;
      tChart5.Header.Brush.Visible = true;
      // 
      // 
      // 
      tChart5.Header.Font.Bold = false;
      // 
      // 
      // 
      tChart5.Header.Font.Brush.Color = Color.FromArgb((int)(byte)255, (int)(byte)255, (int)(byte)255);
      tChart5.Header.Font.Brush.Solid = true;
      tChart5.Header.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart5.Header.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart5.Header.Font.Shadow.Brush.Solid = true;
      tChart5.Header.Font.Shadow.Brush.Visible = true;
      tChart5.Header.Font.Size = 8;
      tChart5.Header.Font.SizeFloat = 8F;
      tChart5.Header.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart5.Header.ImageBevel.Brush.Color = Color.LightGray;
      tChart5.Header.ImageBevel.Brush.Solid = true;
      tChart5.Header.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart5.Header.Shadow.Brush.Color = Color.FromArgb((int)(byte)169, (int)(byte)169, (int)(byte)169);
      tChart5.Header.Shadow.Brush.Solid = true;
      tChart5.Header.Shadow.Brush.Visible = true;
      tChart5.Header.Shadow.Height = 0;
      tChart5.Header.Shadow.Width = 0;
      tChart5.Header.Visible = false;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart5.Legend.Brush.Color = Color.White;
      // 
      // 
      // 
      tChart5.Legend.Brush.Gradient.SigmaFocus = 0F;
      tChart5.Legend.Brush.Gradient.SigmaScale = 0F;
      tChart5.Legend.Brush.Gradient.Visible = true;
      tChart5.Legend.Brush.Solid = true;
      tChart5.Legend.Brush.Visible = true;
      tChart5.Legend.CheckBoxes = false;
      tChart5.Legend.ClipText = false;
      // 
      // 
      // 
      tChart5.Legend.Font.Bold = false;
      // 
      // 
      // 
      tChart5.Legend.Font.Brush.Color = Color.FromArgb((int)(byte)255, (int)(byte)255, (int)(byte)255);
      tChart5.Legend.Font.Brush.Solid = true;
      tChart5.Legend.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart5.Legend.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart5.Legend.Font.Shadow.Brush.Solid = true;
      tChart5.Legend.Font.Shadow.Brush.Visible = true;
      tChart5.Legend.Font.Size = 8;
      tChart5.Legend.Font.SizeFloat = 8F;
      tChart5.Legend.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart5.Legend.ImageBevel.Brush.Color = Color.LightGray;
      tChart5.Legend.ImageBevel.Brush.Solid = true;
      tChart5.Legend.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart5.Legend.Shadow.Brush.Color = Color.FromArgb((int)(byte)0, (int)(byte)0, (int)(byte)0);
      tChart5.Legend.Shadow.Brush.Solid = true;
      tChart5.Legend.Shadow.Brush.Visible = true;
      tChart5.Legend.Shadow.Width = 0;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      tChart5.Legend.Symbol.Shadow.Brush.Color = Color.DarkGray;
      tChart5.Legend.Symbol.Shadow.Brush.Solid = true;
      tChart5.Legend.Symbol.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart5.Legend.Title.Brush.Color = Color.White;
      tChart5.Legend.Title.Brush.Solid = true;
      tChart5.Legend.Title.Brush.Visible = true;
      // 
      // 
      // 
      tChart5.Legend.Title.Font.Bold = true;
      // 
      // 
      // 
      tChart5.Legend.Title.Font.Brush.Color = Color.Black;
      tChart5.Legend.Title.Font.Brush.Solid = true;
      tChart5.Legend.Title.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart5.Legend.Title.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart5.Legend.Title.Font.Shadow.Brush.Solid = true;
      tChart5.Legend.Title.Font.Shadow.Brush.Visible = true;
      tChart5.Legend.Title.Font.Size = 8;
      tChart5.Legend.Title.Font.SizeFloat = 8F;
      tChart5.Legend.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Bold;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart5.Legend.Title.ImageBevel.Brush.Color = Color.LightGray;
      tChart5.Legend.Title.ImageBevel.Brush.Solid = true;
      tChart5.Legend.Title.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart5.Legend.Title.Shadow.Brush.Color = Color.DarkGray;
      tChart5.Legend.Title.Shadow.Brush.Solid = true;
      tChart5.Legend.Title.Shadow.Brush.Visible = true;
      tChart5.Legend.Visible = false;
      tChart5.Location = new Point(0, 0);
      tChart5.Name = "tChart5";
      // 
      // 
      // 
      // 
      // 
      // 
      tChart5.Panel.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.Raised;
      // 
      // 
      // 
      tChart5.Panel.Brush.Color = Color.FromArgb((int)(byte)240, (int)(byte)240, (int)(byte)240);
      // 
      // 
      // 
      tChart5.Panel.Brush.Gradient.EndColor = Color.FromArgb((int)(byte)70, (int)(byte)70, (int)(byte)70);
      tChart5.Panel.Brush.Gradient.MiddleColor = Color.FromArgb((int)(byte)0, (int)(byte)0, (int)(byte)0, (int)(byte)0);
      tChart5.Panel.Brush.Gradient.SigmaFocus = 0F;
      tChart5.Panel.Brush.Gradient.SigmaScale = 0F;
      tChart5.Panel.Brush.Gradient.StartColor = Color.FromArgb((int)(byte)70, (int)(byte)70, (int)(byte)70);
      tChart5.Panel.Brush.Gradient.UseMiddle = false;
      tChart5.Panel.Brush.Gradient.Visible = true;
      tChart5.Panel.Brush.Solid = true;
      tChart5.Panel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart5.Panel.ImageBevel.Brush.Color = Color.LightGray;
      tChart5.Panel.ImageBevel.Brush.Solid = true;
      tChart5.Panel.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart5.Panel.Shadow.Brush.Color = Color.DarkGray;
      tChart5.Panel.Shadow.Brush.Solid = true;
      tChart5.Panel.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      margins3.Bottom = 100;
      margins3.Left = 100;
      margins3.Right = 100;
      margins3.Top = 100;
      tChart5.Printer.Margins = margins3;
      tChart5.Series.Add(surface);
      tChart5.Size = new Size(477, 365);
      // 
      // 
      // 
      // 
      // 
      // 
      tChart5.SubFooter.Brush.Color = Color.Silver;
      tChart5.SubFooter.Brush.Solid = true;
      tChart5.SubFooter.Brush.Visible = true;
      // 
      // 
      // 
      tChart5.SubFooter.Font.Bold = false;
      // 
      // 
      // 
      tChart5.SubFooter.Font.Brush.Color = Color.Red;
      tChart5.SubFooter.Font.Brush.Solid = true;
      tChart5.SubFooter.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart5.SubFooter.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart5.SubFooter.Font.Shadow.Brush.Solid = true;
      tChart5.SubFooter.Font.Shadow.Brush.Visible = true;
      tChart5.SubFooter.Font.Size = 8;
      tChart5.SubFooter.Font.SizeFloat = 8F;
      tChart5.SubFooter.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart5.SubFooter.ImageBevel.Brush.Color = Color.LightGray;
      tChart5.SubFooter.ImageBevel.Brush.Solid = true;
      tChart5.SubFooter.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart5.SubFooter.Shadow.Brush.Color = Color.DarkGray;
      tChart5.SubFooter.Shadow.Brush.Solid = true;
      tChart5.SubFooter.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart5.SubHeader.Brush.Color = Color.FromArgb((int)(byte)192, (int)(byte)192, (int)(byte)192);
      tChart5.SubHeader.Brush.Solid = true;
      tChart5.SubHeader.Brush.Visible = true;
      // 
      // 
      // 
      tChart5.SubHeader.Font.Bold = false;
      // 
      // 
      // 
      tChart5.SubHeader.Font.Brush.Color = Color.FromArgb((int)(byte)128, (int)(byte)128, (int)(byte)128);
      tChart5.SubHeader.Font.Brush.Solid = true;
      tChart5.SubHeader.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart5.SubHeader.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart5.SubHeader.Font.Shadow.Brush.Solid = true;
      tChart5.SubHeader.Font.Shadow.Brush.Visible = true;
      tChart5.SubHeader.Font.Size = 12;
      tChart5.SubHeader.Font.SizeFloat = 12F;
      tChart5.SubHeader.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart5.SubHeader.ImageBevel.Brush.Color = Color.LightGray;
      tChart5.SubHeader.ImageBevel.Brush.Solid = true;
      tChart5.SubHeader.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart5.SubHeader.Shadow.Brush.Color = Color.FromArgb((int)(byte)169, (int)(byte)169, (int)(byte)169);
      tChart5.SubHeader.Shadow.Brush.Solid = true;
      tChart5.SubHeader.Shadow.Brush.Visible = true;
      tChart5.TabIndex = 0;
      tChart5.Tools.Add(rotate1);
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      tChart5.Walls.Back.Brush.Color = Color.Silver;
      // 
      // 
      // 
      tChart5.Walls.Back.Brush.Gradient.EndColor = Color.FromArgb((int)(byte)120, (int)(byte)120, (int)(byte)120);
      tChart5.Walls.Back.Brush.Gradient.StartColor = Color.FromArgb((int)(byte)70, (int)(byte)70, (int)(byte)70);
      tChart5.Walls.Back.Brush.Solid = true;
      tChart5.Walls.Back.Brush.Visible = false;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart5.Walls.Back.ImageBevel.Brush.Color = Color.LightGray;
      tChart5.Walls.Back.ImageBevel.Brush.Solid = true;
      tChart5.Walls.Back.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart5.Walls.Back.Shadow.Brush.Color = Color.DarkGray;
      tChart5.Walls.Back.Shadow.Brush.Solid = true;
      tChart5.Walls.Back.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart5.Walls.Bottom.Brush.Color = Color.White;
      // 
      // 
      // 
      tChart5.Walls.Bottom.Brush.Gradient.SigmaFocus = 0F;
      tChart5.Walls.Bottom.Brush.Gradient.SigmaScale = 0F;
      tChart5.Walls.Bottom.Brush.Solid = true;
      tChart5.Walls.Bottom.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart5.Walls.Bottom.ImageBevel.Brush.Color = Color.LightGray;
      tChart5.Walls.Bottom.ImageBevel.Brush.Solid = true;
      tChart5.Walls.Bottom.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart5.Walls.Bottom.Shadow.Brush.Color = Color.DarkGray;
      tChart5.Walls.Bottom.Shadow.Brush.Solid = true;
      tChart5.Walls.Bottom.Shadow.Brush.Visible = true;
      tChart5.Walls.Bottom.Visible = false;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart5.Walls.Left.Brush.Color = Color.LightYellow;
      // 
      // 
      // 
      tChart5.Walls.Left.Brush.Gradient.SigmaFocus = 0F;
      tChart5.Walls.Left.Brush.Gradient.SigmaScale = 0F;
      tChart5.Walls.Left.Brush.Solid = true;
      tChart5.Walls.Left.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart5.Walls.Left.ImageBevel.Brush.Color = Color.LightGray;
      tChart5.Walls.Left.ImageBevel.Brush.Solid = true;
      tChart5.Walls.Left.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart5.Walls.Left.Shadow.Brush.Color = Color.DarkGray;
      tChart5.Walls.Left.Shadow.Brush.Solid = true;
      tChart5.Walls.Left.Shadow.Brush.Visible = true;
      tChart5.Walls.Left.Visible = false;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart5.Walls.Right.Brush.Color = Color.FromArgb((int)(byte)192, (int)(byte)192, (int)(byte)192);
      // 
      // 
      // 
      tChart5.Walls.Right.Brush.Gradient.SigmaFocus = 0F;
      tChart5.Walls.Right.Brush.Gradient.SigmaScale = 0F;
      tChart5.Walls.Right.Brush.Solid = true;
      tChart5.Walls.Right.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart5.Walls.Right.ImageBevel.Brush.Color = Color.LightGray;
      tChart5.Walls.Right.ImageBevel.Brush.Solid = true;
      tChart5.Walls.Right.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart5.Walls.Right.Shadow.Brush.Color = Color.DarkGray;
      tChart5.Walls.Right.Shadow.Brush.Solid = true;
      tChart5.Walls.Right.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart5.Zoom.Brush.Color = Color.FromArgb((int)(byte)127, (int)(byte)0, (int)(byte)0, (int)(byte)255);
      tChart5.Zoom.Brush.Solid = true;
      tChart5.Zoom.Brush.Visible = false;
      // 
      // surface
      // 
      // 
      // 
      // 
      surface.Brush.Color = Color.FromArgb((int)(byte)178, (int)(byte)220, (int)(byte)92, (int)(byte)5);
      // 
      // 
      // 
      surface.Brush.Gradient.Transparency = 30;
      surface.Brush.Solid = true;
      surface.Brush.Visible = true;
      surface.Color = Color.FromArgb((int)(byte)178, (int)(byte)220, (int)(byte)92, (int)(byte)5);
      surface.Cursor = cursor1;
      // 
      // 
      // 
      // 
      // 
      // 
      surface.Legend.Brush.Color = Color.White;
      surface.Legend.Brush.Solid = true;
      surface.Legend.Brush.Visible = true;
      // 
      // 
      // 
      surface.Legend.Font.Bold = false;
      // 
      // 
      // 
      surface.Legend.Font.Brush.Color = Color.Black;
      surface.Legend.Font.Brush.Solid = true;
      surface.Legend.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      surface.Legend.Font.Shadow.Brush.Color = Color.DarkGray;
      surface.Legend.Font.Shadow.Brush.Solid = true;
      surface.Legend.Font.Shadow.Brush.Visible = true;
      surface.Legend.Font.Size = 8;
      surface.Legend.Font.SizeFloat = 8F;
      surface.Legend.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      surface.Legend.ImageBevel.Brush.Color = Color.LightGray;
      surface.Legend.ImageBevel.Brush.Solid = true;
      surface.Legend.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      surface.Legend.Shadow.Brush.Color = Color.DarkGray;
      surface.Legend.Shadow.Brush.Solid = true;
      surface.Legend.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      surface.Marks.Arrow.Transparency = 30;
      // 
      // 
      // 
      surface.Marks.Brush.Color = Color.FromArgb((int)(byte)178, (int)(byte)255, (int)(byte)255, (int)(byte)255);
      // 
      // 
      // 
      surface.Marks.Brush.Gradient.Transparency = 30;
      surface.Marks.Brush.Solid = true;
      surface.Marks.Brush.Visible = true;
      // 
      // 
      // 
      surface.Marks.Font.Bold = false;
      // 
      // 
      // 
      surface.Marks.Font.Brush.Color = Color.FromArgb((int)(byte)178, (int)(byte)0, (int)(byte)0, (int)(byte)0);
      // 
      // 
      // 
      surface.Marks.Font.Brush.Gradient.Transparency = 30;
      surface.Marks.Font.Brush.Solid = true;
      surface.Marks.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      surface.Marks.Font.Shadow.Brush.Color = Color.DarkGray;
      surface.Marks.Font.Shadow.Brush.Solid = true;
      surface.Marks.Font.Shadow.Brush.Visible = true;
      surface.Marks.Font.Size = 8;
      surface.Marks.Font.SizeFloat = 8F;
      surface.Marks.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      surface.Marks.ImageBevel.Brush.Color = Color.LightGray;
      surface.Marks.ImageBevel.Brush.Solid = true;
      surface.Marks.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      surface.Marks.Pen.Transparency = 30;
      // 
      // 
      // 
      // 
      // 
      // 
      surface.Marks.Shadow.Brush.Color = Color.FromArgb((int)(byte)178, (int)(byte)128, (int)(byte)128, (int)(byte)128);
      // 
      // 
      // 
      surface.Marks.Shadow.Brush.Gradient.Transparency = 30;
      surface.Marks.Shadow.Brush.Solid = true;
      surface.Marks.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      surface.Marks.Symbol.Brush.Color = Color.White;
      surface.Marks.Symbol.Brush.Solid = true;
      surface.Marks.Symbol.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      surface.Marks.Symbol.ImageBevel.Brush.Color = Color.LightGray;
      surface.Marks.Symbol.ImageBevel.Brush.Solid = true;
      surface.Marks.Symbol.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      surface.Marks.Symbol.Shadow.Brush.Color = Color.DarkGray;
      surface.Marks.Symbol.Shadow.Brush.Solid = true;
      surface.Marks.Symbol.Shadow.Brush.Visible = true;
      surface.PaletteMin = 0D;
      surface.PaletteStep = 0D;
      surface.PaletteStyle = Steema.TeeChart.Styles.PaletteStyles.Pale;
      // 
      // 
      // 
      surface.Pen.Color = Color.FromArgb((int)(byte)224, (int)(byte)224, (int)(byte)224);
      surface.Pen.Transparency = 30;
      // 
      // 
      // 
      surface.SideBrush.Color = Color.Black;
      surface.SideBrush.Solid = true;
      surface.SideBrush.Visible = false;
      surface.Title = "surface1";
      surface.Transparency = 30;
      surface.UseColorRange = false;
      surface.UsePalette = true;
      // 
      // 
      // 
      surface.WaterLines.Transparency = 30;
      // 
      // 
      // 
      surface.XValues.DataMember = "X";
      surface.XValues.Value = new double[]
  {
    1D,
    2D,
    3D,
    4D,
    5D,
    6D,
    7D,
    8D,
    9D,
    10D,
    1D,
    2D,
    3D,
    4D,
    5D,
    6D,
    7D,
    8D,
    9D,
    10D,
    1D,
    2D,
    3D,
    4D,
    5D,
    6D,
    7D,
    8D,
    9D,
    10D,
    1D,
    2D,
    3D,
    4D,
    5D,
    6D,
    7D,
    8D,
    9D,
    10D,
    1D,
    2D,
    3D,
    4D,
    5D,
    6D,
    7D,
    8D,
    9D,
    10D,
    1D,
    2D,
    3D,
    4D,
    5D,
    6D,
    7D,
    8D,
    9D,
    10D,
    1D,
    2D,
    3D,
    4D,
    5D,
    6D,
    7D,
    8D,
    9D,
    10D,
    1D,
    2D,
    3D,
    4D,
    5D,
    6D,
    7D,
    8D,
    9D,
    10D,
    1D,
    2D,
    3D,
    4D,
    5D,
    6D,
    7D,
    8D,
    9D,
    10D,
    1D,
    2D,
    3D,
    4D,
    5D,
    6D,
    7D,
    8D,
    9D,
    10D,
    0D
  };
      // 
      // 
      // 
      surface.YValues.DataMember = "Y";
      surface.YValues.Value = new double[]
  {
    0.17516015155986309D,
    -0.063952134043957276D,
    -0.20741354905728315D,
    -0.1233263301230747D,
    0.11100012145863469D,
    0.28012714675541983D,
    0.22856013867865443D,
    0.0037095666406748995D,
    -0.187697990378341D,
    -0.16968330717628488D,
    -0.24405883580942134D,
    -0.48317112141324181D,
    -0.62663253642656758D,
    -0.54254531749235912D,
    -0.30821886591064973D,
    -0.13909184061386481D,
    -0.19065884869063D,
    -0.41550942072860964D,
    -0.60691697774762554D,
    -0.5889022945455693D,
    -0.43525628674286609D,
    -0.67436857234668657D,
    -0.81782998736001244D,
    -0.733742768425804D,
    -0.49941631684409449D,
    -0.33028929154730957D,
    -0.38185629962407486D,
    -0.60670687166205439D,
    -0.7981144286810703D,
    -0.78009974547901417D,
    -0.13845294331193636D,
    -0.37756522891575689D,
    -0.52102664392908271D,
    -0.43693942499487431D,
    -0.20261297341316475D,
    -0.033485948116379838D,
    -0.085052956193145124D,
    -0.30990352823112466D,
    -0.50131108525014056D,
    -0.48329640204808444D,
    0.48660436333050816D,
    0.2474920777266878D,
    0.10403066271336192D,
    0.18811788164757037D,
    0.42244433322927988D,
    0.59157135852606491D,
    0.54000435044929951D,
    0.31515377841132D,
    0.12374622139230407D,
    0.14176090459436019D,
    1.0028029653155441D,
    0.76369067971172377D,
    0.6202292646983979D,
    0.70431648363260635D,
    0.93864293521431574D,
    1.1077699605111009D,
    1.0562029524343355D,
    0.83135238039635584D,
    0.63994482337734016D,
    0.65795950657939617D,
    1.0920595607384465D,
    0.85294727513462576D,
    0.70948586012129988D,
    0.79357307905550833D,
    1.0278995306372181D,
    1.1970265559340028D,
    1.1454595478572376D,
    0.920608975819258D,
    0.729201418800242D,
    0.74721610200229815D,
    0.84152508186401709D,
    0.60241279626019661D,
    0.45895138124687074D,
    0.54303860018107919D,
    0.77736505176278869D,
    0.94649207705957361D,
    0.89492506898280832D,
    0.67007449694482879D,
    0.47866693992581283D,
    0.49668162312786895D,
    0.65671254021778358D,
    0.41760025461396305D,
    0.27413883960063723D,
    0.35822605853484563D,
    0.59255251011655519D,
    0.7616795354133401D,
    0.71011252733657471D,
    0.48526195529859523D,
    0.29385439827957938D,
    0.3118690814816355D,
    0.88168664847595113D,
    0.64257436287213054D,
    0.49911294785880478D,
    0.58320016679301323D,
    0.81752661837472274D,
    0.98665364367150765D,
    0.93508663559474225D,
    0.71023606355676283D,
    0.51882850653774693D,
    0.536843189739803D,
    0D
  };
      // 
      // 
      // 
      surface.ZValues.DataMember = "Z";
      surface.ZValues.Value = new double[]
  {
    1D,
    1D,
    1D,
    1D,
    1D,
    1D,
    1D,
    1D,
    1D,
    1D,
    2D,
    2D,
    2D,
    2D,
    2D,
    2D,
    2D,
    2D,
    2D,
    2D,
    3D,
    3D,
    3D,
    3D,
    3D,
    3D,
    3D,
    3D,
    3D,
    3D,
    4D,
    4D,
    4D,
    4D,
    4D,
    4D,
    4D,
    4D,
    4D,
    4D,
    5D,
    5D,
    5D,
    5D,
    5D,
    5D,
    5D,
    5D,
    5D,
    5D,
    6D,
    6D,
    6D,
    6D,
    6D,
    6D,
    6D,
    6D,
    6D,
    6D,
    7D,
    7D,
    7D,
    7D,
    7D,
    7D,
    7D,
    7D,
    7D,
    7D,
    8D,
    8D,
    8D,
    8D,
    8D,
    8D,
    8D,
    8D,
    8D,
    8D,
    9D,
    9D,
    9D,
    9D,
    9D,
    9D,
    9D,
    9D,
    9D,
    9D,
    10D,
    10D,
    10D,
    10D,
    10D,
    10D,
    10D,
    10D,
    10D,
    10D,
    0D
  };
      // 
      // rotate1
      // 
      // 
      // 
      // 
      rotate1.Pen.Visible = false;
      // 
      // stdDeviation1
      // 
      stdDeviation1.Period = 4D;
      // 
      // tChart8
      // 
      // 
      // 
      // 
      tChart8.Aspect.ColorPaletteIndex = -1;
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
      tChart8.Axes.Bottom.Labels.Brush.Color = Color.White;
      tChart8.Axes.Bottom.Labels.Brush.Solid = true;
      tChart8.Axes.Bottom.Labels.Brush.Visible = true;
      // 
      // 
      // 
      tChart8.Axes.Bottom.Labels.Font.Bold = false;
      // 
      // 
      // 
      tChart8.Axes.Bottom.Labels.Font.Brush.Color = Color.FromArgb((int)(byte)255, (int)(byte)255, (int)(byte)255);
      tChart8.Axes.Bottom.Labels.Font.Brush.Solid = true;
      tChart8.Axes.Bottom.Labels.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart8.Axes.Bottom.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart8.Axes.Bottom.Labels.Font.Shadow.Brush.Solid = true;
      tChart8.Axes.Bottom.Labels.Font.Shadow.Brush.Visible = true;
      tChart8.Axes.Bottom.Labels.Font.Size = 8;
      tChart8.Axes.Bottom.Labels.Font.SizeFloat = 8F;
      tChart8.Axes.Bottom.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart8.Axes.Bottom.Labels.ImageBevel.Brush.Color = Color.LightGray;
      tChart8.Axes.Bottom.Labels.ImageBevel.Brush.Solid = true;
      tChart8.Axes.Bottom.Labels.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart8.Axes.Bottom.Labels.Shadow.Brush.Color = Color.DarkGray;
      tChart8.Axes.Bottom.Labels.Shadow.Brush.Solid = true;
      tChart8.Axes.Bottom.Labels.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart8.Axes.Bottom.Title.Brush.Color = Color.Silver;
      tChart8.Axes.Bottom.Title.Brush.Solid = true;
      tChart8.Axes.Bottom.Title.Brush.Visible = true;
      // 
      // 
      // 
      tChart8.Axes.Bottom.Title.Font.Bold = false;
      // 
      // 
      // 
      tChart8.Axes.Bottom.Title.Font.Brush.Color = Color.FromArgb((int)(byte)0, (int)(byte)0, (int)(byte)0);
      tChart8.Axes.Bottom.Title.Font.Brush.Solid = true;
      tChart8.Axes.Bottom.Title.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart8.Axes.Bottom.Title.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart8.Axes.Bottom.Title.Font.Shadow.Brush.Solid = true;
      tChart8.Axes.Bottom.Title.Font.Shadow.Brush.Visible = true;
      tChart8.Axes.Bottom.Title.Font.Size = 8;
      tChart8.Axes.Bottom.Title.Font.SizeFloat = 8F;
      tChart8.Axes.Bottom.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart8.Axes.Bottom.Title.ImageBevel.Brush.Color = Color.LightGray;
      tChart8.Axes.Bottom.Title.ImageBevel.Brush.Solid = true;
      tChart8.Axes.Bottom.Title.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart8.Axes.Bottom.Title.Shadow.Brush.Color = Color.DarkGray;
      tChart8.Axes.Bottom.Title.Shadow.Brush.Solid = true;
      tChart8.Axes.Bottom.Title.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      tChart8.Axes.Depth.Labels.Brush.Color = Color.White;
      tChart8.Axes.Depth.Labels.Brush.Solid = true;
      tChart8.Axes.Depth.Labels.Brush.Visible = true;
      // 
      // 
      // 
      tChart8.Axes.Depth.Labels.Font.Bold = false;
      // 
      // 
      // 
      tChart8.Axes.Depth.Labels.Font.Brush.Color = Color.FromArgb((int)(byte)255, (int)(byte)255, (int)(byte)255);
      tChart8.Axes.Depth.Labels.Font.Brush.Solid = true;
      tChart8.Axes.Depth.Labels.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart8.Axes.Depth.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart8.Axes.Depth.Labels.Font.Shadow.Brush.Solid = true;
      tChart8.Axes.Depth.Labels.Font.Shadow.Brush.Visible = true;
      tChart8.Axes.Depth.Labels.Font.Size = 8;
      tChart8.Axes.Depth.Labels.Font.SizeFloat = 8F;
      tChart8.Axes.Depth.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart8.Axes.Depth.Labels.ImageBevel.Brush.Color = Color.LightGray;
      tChart8.Axes.Depth.Labels.ImageBevel.Brush.Solid = true;
      tChart8.Axes.Depth.Labels.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart8.Axes.Depth.Labels.Shadow.Brush.Color = Color.DarkGray;
      tChart8.Axes.Depth.Labels.Shadow.Brush.Solid = true;
      tChart8.Axes.Depth.Labels.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart8.Axes.Depth.Title.Brush.Color = Color.Silver;
      tChart8.Axes.Depth.Title.Brush.Solid = true;
      tChart8.Axes.Depth.Title.Brush.Visible = true;
      // 
      // 
      // 
      tChart8.Axes.Depth.Title.Font.Bold = false;
      // 
      // 
      // 
      tChart8.Axes.Depth.Title.Font.Brush.Color = Color.FromArgb((int)(byte)0, (int)(byte)0, (int)(byte)0);
      tChart8.Axes.Depth.Title.Font.Brush.Solid = true;
      tChart8.Axes.Depth.Title.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart8.Axes.Depth.Title.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart8.Axes.Depth.Title.Font.Shadow.Brush.Solid = true;
      tChart8.Axes.Depth.Title.Font.Shadow.Brush.Visible = true;
      tChart8.Axes.Depth.Title.Font.Size = 8;
      tChart8.Axes.Depth.Title.Font.SizeFloat = 8F;
      tChart8.Axes.Depth.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart8.Axes.Depth.Title.ImageBevel.Brush.Color = Color.LightGray;
      tChart8.Axes.Depth.Title.ImageBevel.Brush.Solid = true;
      tChart8.Axes.Depth.Title.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart8.Axes.Depth.Title.Shadow.Brush.Color = Color.DarkGray;
      tChart8.Axes.Depth.Title.Shadow.Brush.Solid = true;
      tChart8.Axes.Depth.Title.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      tChart8.Axes.DepthTop.Labels.Brush.Color = Color.White;
      tChart8.Axes.DepthTop.Labels.Brush.Solid = true;
      tChart8.Axes.DepthTop.Labels.Brush.Visible = true;
      // 
      // 
      // 
      tChart8.Axes.DepthTop.Labels.Font.Bold = false;
      // 
      // 
      // 
      tChart8.Axes.DepthTop.Labels.Font.Brush.Color = Color.FromArgb((int)(byte)255, (int)(byte)255, (int)(byte)255);
      tChart8.Axes.DepthTop.Labels.Font.Brush.Solid = true;
      tChart8.Axes.DepthTop.Labels.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart8.Axes.DepthTop.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart8.Axes.DepthTop.Labels.Font.Shadow.Brush.Solid = true;
      tChart8.Axes.DepthTop.Labels.Font.Shadow.Brush.Visible = true;
      tChart8.Axes.DepthTop.Labels.Font.Size = 8;
      tChart8.Axes.DepthTop.Labels.Font.SizeFloat = 8F;
      tChart8.Axes.DepthTop.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart8.Axes.DepthTop.Labels.ImageBevel.Brush.Color = Color.LightGray;
      tChart8.Axes.DepthTop.Labels.ImageBevel.Brush.Solid = true;
      tChart8.Axes.DepthTop.Labels.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart8.Axes.DepthTop.Labels.Shadow.Brush.Color = Color.DarkGray;
      tChart8.Axes.DepthTop.Labels.Shadow.Brush.Solid = true;
      tChart8.Axes.DepthTop.Labels.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart8.Axes.DepthTop.Title.Brush.Color = Color.Silver;
      tChart8.Axes.DepthTop.Title.Brush.Solid = true;
      tChart8.Axes.DepthTop.Title.Brush.Visible = true;
      // 
      // 
      // 
      tChart8.Axes.DepthTop.Title.Font.Bold = false;
      // 
      // 
      // 
      tChart8.Axes.DepthTop.Title.Font.Brush.Color = Color.FromArgb((int)(byte)0, (int)(byte)0, (int)(byte)0);
      tChart8.Axes.DepthTop.Title.Font.Brush.Solid = true;
      tChart8.Axes.DepthTop.Title.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart8.Axes.DepthTop.Title.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart8.Axes.DepthTop.Title.Font.Shadow.Brush.Solid = true;
      tChart8.Axes.DepthTop.Title.Font.Shadow.Brush.Visible = true;
      tChart8.Axes.DepthTop.Title.Font.Size = 8;
      tChart8.Axes.DepthTop.Title.Font.SizeFloat = 8F;
      tChart8.Axes.DepthTop.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart8.Axes.DepthTop.Title.ImageBevel.Brush.Color = Color.LightGray;
      tChart8.Axes.DepthTop.Title.ImageBevel.Brush.Solid = true;
      tChart8.Axes.DepthTop.Title.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart8.Axes.DepthTop.Title.Shadow.Brush.Color = Color.DarkGray;
      tChart8.Axes.DepthTop.Title.Shadow.Brush.Solid = true;
      tChart8.Axes.DepthTop.Title.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      tChart8.Axes.Left.Labels.Brush.Color = Color.White;
      tChart8.Axes.Left.Labels.Brush.Solid = true;
      tChart8.Axes.Left.Labels.Brush.Visible = true;
      // 
      // 
      // 
      tChart8.Axes.Left.Labels.Font.Bold = false;
      // 
      // 
      // 
      tChart8.Axes.Left.Labels.Font.Brush.Color = Color.FromArgb((int)(byte)255, (int)(byte)255, (int)(byte)255);
      tChart8.Axes.Left.Labels.Font.Brush.Solid = true;
      tChart8.Axes.Left.Labels.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart8.Axes.Left.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart8.Axes.Left.Labels.Font.Shadow.Brush.Solid = true;
      tChart8.Axes.Left.Labels.Font.Shadow.Brush.Visible = true;
      tChart8.Axes.Left.Labels.Font.Size = 8;
      tChart8.Axes.Left.Labels.Font.SizeFloat = 8F;
      tChart8.Axes.Left.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart8.Axes.Left.Labels.ImageBevel.Brush.Color = Color.LightGray;
      tChart8.Axes.Left.Labels.ImageBevel.Brush.Solid = true;
      tChart8.Axes.Left.Labels.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart8.Axes.Left.Labels.Shadow.Brush.Color = Color.DarkGray;
      tChart8.Axes.Left.Labels.Shadow.Brush.Solid = true;
      tChart8.Axes.Left.Labels.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart8.Axes.Left.Title.Brush.Color = Color.Silver;
      tChart8.Axes.Left.Title.Brush.Solid = true;
      tChart8.Axes.Left.Title.Brush.Visible = true;
      // 
      // 
      // 
      tChart8.Axes.Left.Title.Font.Bold = false;
      // 
      // 
      // 
      tChart8.Axes.Left.Title.Font.Brush.Color = Color.FromArgb((int)(byte)0, (int)(byte)0, (int)(byte)0);
      tChart8.Axes.Left.Title.Font.Brush.Solid = true;
      tChart8.Axes.Left.Title.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart8.Axes.Left.Title.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart8.Axes.Left.Title.Font.Shadow.Brush.Solid = true;
      tChart8.Axes.Left.Title.Font.Shadow.Brush.Visible = true;
      tChart8.Axes.Left.Title.Font.Size = 8;
      tChart8.Axes.Left.Title.Font.SizeFloat = 8F;
      tChart8.Axes.Left.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart8.Axes.Left.Title.ImageBevel.Brush.Color = Color.LightGray;
      tChart8.Axes.Left.Title.ImageBevel.Brush.Solid = true;
      tChart8.Axes.Left.Title.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart8.Axes.Left.Title.Shadow.Brush.Color = Color.DarkGray;
      tChart8.Axes.Left.Title.Shadow.Brush.Solid = true;
      tChart8.Axes.Left.Title.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      tChart8.Axes.Right.Labels.Brush.Color = Color.White;
      tChart8.Axes.Right.Labels.Brush.Solid = true;
      tChart8.Axes.Right.Labels.Brush.Visible = true;
      // 
      // 
      // 
      tChart8.Axes.Right.Labels.Font.Bold = false;
      // 
      // 
      // 
      tChart8.Axes.Right.Labels.Font.Brush.Color = Color.FromArgb((int)(byte)255, (int)(byte)255, (int)(byte)255);
      tChart8.Axes.Right.Labels.Font.Brush.Solid = true;
      tChart8.Axes.Right.Labels.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart8.Axes.Right.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart8.Axes.Right.Labels.Font.Shadow.Brush.Solid = true;
      tChart8.Axes.Right.Labels.Font.Shadow.Brush.Visible = true;
      tChart8.Axes.Right.Labels.Font.Size = 8;
      tChart8.Axes.Right.Labels.Font.SizeFloat = 8F;
      tChart8.Axes.Right.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart8.Axes.Right.Labels.ImageBevel.Brush.Color = Color.LightGray;
      tChart8.Axes.Right.Labels.ImageBevel.Brush.Solid = true;
      tChart8.Axes.Right.Labels.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart8.Axes.Right.Labels.Shadow.Brush.Color = Color.DarkGray;
      tChart8.Axes.Right.Labels.Shadow.Brush.Solid = true;
      tChart8.Axes.Right.Labels.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart8.Axes.Right.Title.Brush.Color = Color.Silver;
      tChart8.Axes.Right.Title.Brush.Solid = true;
      tChart8.Axes.Right.Title.Brush.Visible = true;
      // 
      // 
      // 
      tChart8.Axes.Right.Title.Font.Bold = false;
      // 
      // 
      // 
      tChart8.Axes.Right.Title.Font.Brush.Color = Color.FromArgb((int)(byte)0, (int)(byte)0, (int)(byte)0);
      tChart8.Axes.Right.Title.Font.Brush.Solid = true;
      tChart8.Axes.Right.Title.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart8.Axes.Right.Title.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart8.Axes.Right.Title.Font.Shadow.Brush.Solid = true;
      tChart8.Axes.Right.Title.Font.Shadow.Brush.Visible = true;
      tChart8.Axes.Right.Title.Font.Size = 8;
      tChart8.Axes.Right.Title.Font.SizeFloat = 8F;
      tChart8.Axes.Right.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart8.Axes.Right.Title.ImageBevel.Brush.Color = Color.LightGray;
      tChart8.Axes.Right.Title.ImageBevel.Brush.Solid = true;
      tChart8.Axes.Right.Title.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart8.Axes.Right.Title.Shadow.Brush.Color = Color.DarkGray;
      tChart8.Axes.Right.Title.Shadow.Brush.Solid = true;
      tChart8.Axes.Right.Title.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      tChart8.Axes.Top.Labels.Brush.Color = Color.White;
      tChart8.Axes.Top.Labels.Brush.Solid = true;
      tChart8.Axes.Top.Labels.Brush.Visible = true;
      // 
      // 
      // 
      tChart8.Axes.Top.Labels.Font.Bold = false;
      // 
      // 
      // 
      tChart8.Axes.Top.Labels.Font.Brush.Color = Color.FromArgb((int)(byte)255, (int)(byte)255, (int)(byte)255);
      tChart8.Axes.Top.Labels.Font.Brush.Solid = true;
      tChart8.Axes.Top.Labels.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart8.Axes.Top.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart8.Axes.Top.Labels.Font.Shadow.Brush.Solid = true;
      tChart8.Axes.Top.Labels.Font.Shadow.Brush.Visible = true;
      tChart8.Axes.Top.Labels.Font.Size = 8;
      tChart8.Axes.Top.Labels.Font.SizeFloat = 8F;
      tChart8.Axes.Top.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart8.Axes.Top.Labels.ImageBevel.Brush.Color = Color.LightGray;
      tChart8.Axes.Top.Labels.ImageBevel.Brush.Solid = true;
      tChart8.Axes.Top.Labels.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart8.Axes.Top.Labels.Shadow.Brush.Color = Color.DarkGray;
      tChart8.Axes.Top.Labels.Shadow.Brush.Solid = true;
      tChart8.Axes.Top.Labels.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart8.Axes.Top.Title.Brush.Color = Color.Silver;
      tChart8.Axes.Top.Title.Brush.Solid = true;
      tChart8.Axes.Top.Title.Brush.Visible = true;
      // 
      // 
      // 
      tChart8.Axes.Top.Title.Font.Bold = false;
      // 
      // 
      // 
      tChart8.Axes.Top.Title.Font.Brush.Color = Color.FromArgb((int)(byte)0, (int)(byte)0, (int)(byte)0);
      tChart8.Axes.Top.Title.Font.Brush.Solid = true;
      tChart8.Axes.Top.Title.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart8.Axes.Top.Title.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart8.Axes.Top.Title.Font.Shadow.Brush.Solid = true;
      tChart8.Axes.Top.Title.Font.Shadow.Brush.Visible = true;
      tChart8.Axes.Top.Title.Font.Size = 8;
      tChart8.Axes.Top.Title.Font.SizeFloat = 8F;
      tChart8.Axes.Top.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart8.Axes.Top.Title.ImageBevel.Brush.Color = Color.LightGray;
      tChart8.Axes.Top.Title.ImageBevel.Brush.Solid = true;
      tChart8.Axes.Top.Title.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart8.Axes.Top.Title.Shadow.Brush.Color = Color.DarkGray;
      tChart8.Axes.Top.Title.Shadow.Brush.Solid = true;
      tChart8.Axes.Top.Title.Shadow.Brush.Visible = true;
      tChart8.Dock = DockStyle.Fill;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart8.Footer.Brush.Color = Color.Silver;
      tChart8.Footer.Brush.Solid = true;
      tChart8.Footer.Brush.Visible = true;
      // 
      // 
      // 
      tChart8.Footer.Font.Bold = false;
      // 
      // 
      // 
      tChart8.Footer.Font.Brush.Color = Color.Red;
      tChart8.Footer.Font.Brush.Solid = true;
      tChart8.Footer.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart8.Footer.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart8.Footer.Font.Shadow.Brush.Solid = true;
      tChart8.Footer.Font.Shadow.Brush.Visible = true;
      tChart8.Footer.Font.Size = 8;
      tChart8.Footer.Font.SizeFloat = 8F;
      tChart8.Footer.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart8.Footer.ImageBevel.Brush.Color = Color.LightGray;
      tChart8.Footer.ImageBevel.Brush.Solid = true;
      tChart8.Footer.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart8.Footer.Shadow.Brush.Color = Color.DarkGray;
      tChart8.Footer.Shadow.Brush.Solid = true;
      tChart8.Footer.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart8.Header.Brush.Color = Color.FromArgb((int)(byte)192, (int)(byte)192, (int)(byte)192);
      // 
      // 
      // 
      tChart8.Header.Brush.Gradient.SigmaFocus = 0F;
      tChart8.Header.Brush.Gradient.SigmaScale = 0F;
      tChart8.Header.Brush.Solid = true;
      tChart8.Header.Brush.Visible = true;
      // 
      // 
      // 
      tChart8.Header.Font.Bold = false;
      // 
      // 
      // 
      tChart8.Header.Font.Brush.Color = Color.FromArgb((int)(byte)255, (int)(byte)255, (int)(byte)255);
      tChart8.Header.Font.Brush.Solid = true;
      tChart8.Header.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart8.Header.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart8.Header.Font.Shadow.Brush.Solid = true;
      tChart8.Header.Font.Shadow.Brush.Visible = true;
      tChart8.Header.Font.Size = 8;
      tChart8.Header.Font.SizeFloat = 8F;
      tChart8.Header.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart8.Header.ImageBevel.Brush.Color = Color.LightGray;
      tChart8.Header.ImageBevel.Brush.Solid = true;
      tChart8.Header.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart8.Header.Shadow.Brush.Color = Color.FromArgb((int)(byte)169, (int)(byte)169, (int)(byte)169);
      tChart8.Header.Shadow.Brush.Solid = true;
      tChart8.Header.Shadow.Brush.Visible = true;
      tChart8.Header.Shadow.Height = 0;
      tChart8.Header.Shadow.Width = 0;
      tChart8.Header.Visible = false;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart8.Legend.Brush.Color = Color.White;
      // 
      // 
      // 
      tChart8.Legend.Brush.Gradient.SigmaFocus = 0F;
      tChart8.Legend.Brush.Gradient.SigmaScale = 0F;
      tChart8.Legend.Brush.Gradient.Visible = true;
      tChart8.Legend.Brush.Solid = true;
      tChart8.Legend.Brush.Visible = true;
      tChart8.Legend.CheckBoxes = false;
      tChart8.Legend.ClipText = false;
      // 
      // 
      // 
      tChart8.Legend.Font.Bold = false;
      // 
      // 
      // 
      tChart8.Legend.Font.Brush.Color = Color.FromArgb((int)(byte)255, (int)(byte)255, (int)(byte)255);
      tChart8.Legend.Font.Brush.Solid = true;
      tChart8.Legend.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart8.Legend.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart8.Legend.Font.Shadow.Brush.Solid = true;
      tChart8.Legend.Font.Shadow.Brush.Visible = true;
      tChart8.Legend.Font.Size = 8;
      tChart8.Legend.Font.SizeFloat = 8F;
      tChart8.Legend.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart8.Legend.ImageBevel.Brush.Color = Color.LightGray;
      tChart8.Legend.ImageBevel.Brush.Solid = true;
      tChart8.Legend.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart8.Legend.Shadow.Brush.Color = Color.FromArgb((int)(byte)0, (int)(byte)0, (int)(byte)0);
      tChart8.Legend.Shadow.Brush.Solid = true;
      tChart8.Legend.Shadow.Brush.Visible = true;
      tChart8.Legend.Shadow.Width = 0;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      tChart8.Legend.Symbol.Shadow.Brush.Color = Color.DarkGray;
      tChart8.Legend.Symbol.Shadow.Brush.Solid = true;
      tChart8.Legend.Symbol.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart8.Legend.Title.Brush.Color = Color.White;
      tChart8.Legend.Title.Brush.Solid = true;
      tChart8.Legend.Title.Brush.Visible = true;
      // 
      // 
      // 
      tChart8.Legend.Title.Font.Bold = true;
      // 
      // 
      // 
      tChart8.Legend.Title.Font.Brush.Color = Color.Black;
      tChart8.Legend.Title.Font.Brush.Solid = true;
      tChart8.Legend.Title.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart8.Legend.Title.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart8.Legend.Title.Font.Shadow.Brush.Solid = true;
      tChart8.Legend.Title.Font.Shadow.Brush.Visible = true;
      tChart8.Legend.Title.Font.Size = 8;
      tChart8.Legend.Title.Font.SizeFloat = 8F;
      tChart8.Legend.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Bold;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart8.Legend.Title.ImageBevel.Brush.Color = Color.LightGray;
      tChart8.Legend.Title.ImageBevel.Brush.Solid = true;
      tChart8.Legend.Title.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart8.Legend.Title.Shadow.Brush.Color = Color.DarkGray;
      tChart8.Legend.Title.Shadow.Brush.Solid = true;
      tChart8.Legend.Title.Shadow.Brush.Visible = true;
      tChart8.Legend.Visible = false;
      tChart8.Location = new Point(0, 0);
      tChart8.Name = "tChart8";
      // 
      // 
      // 
      // 
      // 
      // 
      tChart8.Panel.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.Raised;
      // 
      // 
      // 
      tChart8.Panel.Brush.Color = Color.FromArgb((int)(byte)240, (int)(byte)240, (int)(byte)240);
      // 
      // 
      // 
      tChart8.Panel.Brush.Gradient.EndColor = Color.FromArgb((int)(byte)70, (int)(byte)70, (int)(byte)70);
      tChart8.Panel.Brush.Gradient.MiddleColor = Color.FromArgb((int)(byte)0, (int)(byte)0, (int)(byte)0, (int)(byte)0);
      tChart8.Panel.Brush.Gradient.SigmaFocus = 0F;
      tChart8.Panel.Brush.Gradient.SigmaScale = 0F;
      tChart8.Panel.Brush.Gradient.StartColor = Color.FromArgb((int)(byte)70, (int)(byte)70, (int)(byte)70);
      tChart8.Panel.Brush.Gradient.UseMiddle = false;
      tChart8.Panel.Brush.Gradient.Visible = true;
      tChart8.Panel.Brush.Solid = true;
      tChart8.Panel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart8.Panel.ImageBevel.Brush.Color = Color.LightGray;
      tChart8.Panel.ImageBevel.Brush.Solid = true;
      tChart8.Panel.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart8.Panel.Shadow.Brush.Color = Color.DarkGray;
      tChart8.Panel.Shadow.Brush.Solid = true;
      tChart8.Panel.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      margins4.Bottom = 100;
      margins4.Left = 100;
      margins4.Right = 100;
      margins4.Top = 100;
      tChart8.Printer.Margins = margins4;
      tChart8.Size = new Size(705, 571);
      // 
      // 
      // 
      // 
      // 
      // 
      tChart8.SubFooter.Brush.Color = Color.Silver;
      tChart8.SubFooter.Brush.Solid = true;
      tChart8.SubFooter.Brush.Visible = true;
      // 
      // 
      // 
      tChart8.SubFooter.Font.Bold = false;
      // 
      // 
      // 
      tChart8.SubFooter.Font.Brush.Color = Color.Red;
      tChart8.SubFooter.Font.Brush.Solid = true;
      tChart8.SubFooter.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart8.SubFooter.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart8.SubFooter.Font.Shadow.Brush.Solid = true;
      tChart8.SubFooter.Font.Shadow.Brush.Visible = true;
      tChart8.SubFooter.Font.Size = 8;
      tChart8.SubFooter.Font.SizeFloat = 8F;
      tChart8.SubFooter.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart8.SubFooter.ImageBevel.Brush.Color = Color.LightGray;
      tChart8.SubFooter.ImageBevel.Brush.Solid = true;
      tChart8.SubFooter.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart8.SubFooter.Shadow.Brush.Color = Color.DarkGray;
      tChart8.SubFooter.Shadow.Brush.Solid = true;
      tChart8.SubFooter.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      tChart8.SubHeader.AdjustFrame = false;
      tChart8.SubHeader.Alignment = Steema.TeeChart.Drawing.StringAlignment.Far;
      tChart8.SubHeader.Bottom = 42;
      // 
      // 
      // 
      tChart8.SubHeader.Brush.Color = Color.FromArgb((int)(byte)192, (int)(byte)192, (int)(byte)192);
      tChart8.SubHeader.Brush.Solid = true;
      tChart8.SubHeader.Brush.Visible = true;
      tChart8.SubHeader.CustomPosition = true;
      // 
      // 
      // 
      tChart8.SubHeader.Font.Bold = false;
      // 
      // 
      // 
      tChart8.SubHeader.Font.Brush.Color = Color.FromArgb((int)(byte)192, (int)(byte)192, (int)(byte)192);
      tChart8.SubHeader.Font.Brush.Solid = true;
      tChart8.SubHeader.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart8.SubHeader.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart8.SubHeader.Font.Shadow.Brush.Solid = true;
      tChart8.SubHeader.Font.Shadow.Brush.Visible = true;
      tChart8.SubHeader.Font.Size = 8;
      tChart8.SubHeader.Font.SizeFloat = 8F;
      tChart8.SubHeader.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart8.SubHeader.ImageBevel.Brush.Color = Color.LightGray;
      tChart8.SubHeader.ImageBevel.Brush.Solid = true;
      tChart8.SubHeader.ImageBevel.Brush.Visible = true;
      tChart8.SubHeader.Left = 616;
      tChart8.SubHeader.Lines = new string[]
  {
    "Resonance"
  };
      tChart8.SubHeader.Right = 684;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart8.SubHeader.Shadow.Brush.Color = Color.FromArgb((int)(byte)169, (int)(byte)169, (int)(byte)169);
      tChart8.SubHeader.Shadow.Brush.Solid = true;
      tChart8.SubHeader.Shadow.Brush.Visible = true;
      tChart8.SubHeader.Top = 27;
      tChart8.SubHeader.Visible = true;
      tChart8.TabIndex = 0;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      tChart8.Walls.Back.Brush.Color = Color.Silver;
      // 
      // 
      // 
      tChart8.Walls.Back.Brush.Gradient.EndColor = Color.FromArgb((int)(byte)120, (int)(byte)120, (int)(byte)120);
      tChart8.Walls.Back.Brush.Gradient.StartColor = Color.FromArgb((int)(byte)70, (int)(byte)70, (int)(byte)70);
      tChart8.Walls.Back.Brush.Solid = true;
      tChart8.Walls.Back.Brush.Visible = false;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart8.Walls.Back.ImageBevel.Brush.Color = Color.LightGray;
      tChart8.Walls.Back.ImageBevel.Brush.Solid = true;
      tChart8.Walls.Back.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart8.Walls.Back.Shadow.Brush.Color = Color.DarkGray;
      tChart8.Walls.Back.Shadow.Brush.Solid = true;
      tChart8.Walls.Back.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart8.Walls.Bottom.Brush.Color = Color.White;
      // 
      // 
      // 
      tChart8.Walls.Bottom.Brush.Gradient.SigmaFocus = 0F;
      tChart8.Walls.Bottom.Brush.Gradient.SigmaScale = 0F;
      tChart8.Walls.Bottom.Brush.Solid = true;
      tChart8.Walls.Bottom.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart8.Walls.Bottom.ImageBevel.Brush.Color = Color.LightGray;
      tChart8.Walls.Bottom.ImageBevel.Brush.Solid = true;
      tChart8.Walls.Bottom.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart8.Walls.Bottom.Shadow.Brush.Color = Color.DarkGray;
      tChart8.Walls.Bottom.Shadow.Brush.Solid = true;
      tChart8.Walls.Bottom.Shadow.Brush.Visible = true;
      tChart8.Walls.Bottom.Visible = false;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart8.Walls.Left.Brush.Color = Color.LightYellow;
      // 
      // 
      // 
      tChart8.Walls.Left.Brush.Gradient.SigmaFocus = 0F;
      tChart8.Walls.Left.Brush.Gradient.SigmaScale = 0F;
      tChart8.Walls.Left.Brush.Solid = true;
      tChart8.Walls.Left.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart8.Walls.Left.ImageBevel.Brush.Color = Color.LightGray;
      tChart8.Walls.Left.ImageBevel.Brush.Solid = true;
      tChart8.Walls.Left.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart8.Walls.Left.Shadow.Brush.Color = Color.DarkGray;
      tChart8.Walls.Left.Shadow.Brush.Solid = true;
      tChart8.Walls.Left.Shadow.Brush.Visible = true;
      tChart8.Walls.Left.Visible = false;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart8.Walls.Right.Brush.Color = Color.FromArgb((int)(byte)192, (int)(byte)192, (int)(byte)192);
      // 
      // 
      // 
      tChart8.Walls.Right.Brush.Gradient.SigmaFocus = 0F;
      tChart8.Walls.Right.Brush.Gradient.SigmaScale = 0F;
      tChart8.Walls.Right.Brush.Solid = true;
      tChart8.Walls.Right.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart8.Walls.Right.ImageBevel.Brush.Color = Color.LightGray;
      tChart8.Walls.Right.ImageBevel.Brush.Solid = true;
      tChart8.Walls.Right.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart8.Walls.Right.Shadow.Brush.Color = Color.DarkGray;
      tChart8.Walls.Right.Shadow.Brush.Solid = true;
      tChart8.Walls.Right.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart8.Zoom.Brush.Color = Color.FromArgb((int)(byte)127, (int)(byte)0, (int)(byte)0, (int)(byte)255);
      tChart8.Zoom.Brush.Solid = true;
      tChart8.Zoom.Brush.Visible = false;
      // 
      // tChart1
      // 
      // 
      // 
      // 
      tChart1.Aspect.ColorPaletteIndex = -1;
      tChart1.Aspect.Elevation = 315;
      tChart1.Aspect.ElevationFloat = 315D;
      tChart1.Aspect.Orthogonal = false;
      tChart1.Aspect.Perspective = 0;
      tChart1.Aspect.Rotation = 360;
      tChart1.Aspect.RotationFloat = 360D;
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
      tChart1.Axes.Bottom.Labels.Brush.Color = Color.White;
      tChart1.Axes.Bottom.Labels.Brush.Solid = true;
      tChart1.Axes.Bottom.Labels.Brush.Visible = true;
      // 
      // 
      // 
      tChart1.Axes.Bottom.Labels.Font.Bold = false;
      // 
      // 
      // 
      tChart1.Axes.Bottom.Labels.Font.Brush.Color = Color.FromArgb((int)(byte)255, (int)(byte)255, (int)(byte)255);
      tChart1.Axes.Bottom.Labels.Font.Brush.Solid = true;
      tChart1.Axes.Bottom.Labels.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart1.Axes.Bottom.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart1.Axes.Bottom.Labels.Font.Shadow.Brush.Solid = true;
      tChart1.Axes.Bottom.Labels.Font.Shadow.Brush.Visible = true;
      tChart1.Axes.Bottom.Labels.Font.Size = 8;
      tChart1.Axes.Bottom.Labels.Font.SizeFloat = 8F;
      tChart1.Axes.Bottom.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart1.Axes.Bottom.Labels.ImageBevel.Brush.Color = Color.LightGray;
      tChart1.Axes.Bottom.Labels.ImageBevel.Brush.Solid = true;
      tChart1.Axes.Bottom.Labels.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart1.Axes.Bottom.Labels.Shadow.Brush.Color = Color.DarkGray;
      tChart1.Axes.Bottom.Labels.Shadow.Brush.Solid = true;
      tChart1.Axes.Bottom.Labels.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart1.Axes.Bottom.Title.Brush.Color = Color.Silver;
      tChart1.Axes.Bottom.Title.Brush.Solid = true;
      tChart1.Axes.Bottom.Title.Brush.Visible = true;
      // 
      // 
      // 
      tChart1.Axes.Bottom.Title.Font.Bold = false;
      // 
      // 
      // 
      tChart1.Axes.Bottom.Title.Font.Brush.Color = Color.FromArgb((int)(byte)0, (int)(byte)0, (int)(byte)0);
      tChart1.Axes.Bottom.Title.Font.Brush.Solid = true;
      tChart1.Axes.Bottom.Title.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart1.Axes.Bottom.Title.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart1.Axes.Bottom.Title.Font.Shadow.Brush.Solid = true;
      tChart1.Axes.Bottom.Title.Font.Shadow.Brush.Visible = true;
      tChart1.Axes.Bottom.Title.Font.Size = 8;
      tChart1.Axes.Bottom.Title.Font.SizeFloat = 8F;
      tChart1.Axes.Bottom.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart1.Axes.Bottom.Title.ImageBevel.Brush.Color = Color.LightGray;
      tChart1.Axes.Bottom.Title.ImageBevel.Brush.Solid = true;
      tChart1.Axes.Bottom.Title.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart1.Axes.Bottom.Title.Shadow.Brush.Color = Color.DarkGray;
      tChart1.Axes.Bottom.Title.Shadow.Brush.Solid = true;
      tChart1.Axes.Bottom.Title.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      tChart1.Axes.Depth.Labels.Brush.Color = Color.White;
      tChart1.Axes.Depth.Labels.Brush.Solid = true;
      tChart1.Axes.Depth.Labels.Brush.Visible = true;
      // 
      // 
      // 
      tChart1.Axes.Depth.Labels.Font.Bold = false;
      // 
      // 
      // 
      tChart1.Axes.Depth.Labels.Font.Brush.Color = Color.FromArgb((int)(byte)255, (int)(byte)255, (int)(byte)255);
      tChart1.Axes.Depth.Labels.Font.Brush.Solid = true;
      tChart1.Axes.Depth.Labels.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart1.Axes.Depth.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart1.Axes.Depth.Labels.Font.Shadow.Brush.Solid = true;
      tChart1.Axes.Depth.Labels.Font.Shadow.Brush.Visible = true;
      tChart1.Axes.Depth.Labels.Font.Size = 8;
      tChart1.Axes.Depth.Labels.Font.SizeFloat = 8F;
      tChart1.Axes.Depth.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart1.Axes.Depth.Labels.ImageBevel.Brush.Color = Color.LightGray;
      tChart1.Axes.Depth.Labels.ImageBevel.Brush.Solid = true;
      tChart1.Axes.Depth.Labels.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart1.Axes.Depth.Labels.Shadow.Brush.Color = Color.DarkGray;
      tChart1.Axes.Depth.Labels.Shadow.Brush.Solid = true;
      tChart1.Axes.Depth.Labels.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart1.Axes.Depth.Title.Brush.Color = Color.Silver;
      tChart1.Axes.Depth.Title.Brush.Solid = true;
      tChart1.Axes.Depth.Title.Brush.Visible = true;
      // 
      // 
      // 
      tChart1.Axes.Depth.Title.Font.Bold = false;
      // 
      // 
      // 
      tChart1.Axes.Depth.Title.Font.Brush.Color = Color.FromArgb((int)(byte)0, (int)(byte)0, (int)(byte)0);
      tChart1.Axes.Depth.Title.Font.Brush.Solid = true;
      tChart1.Axes.Depth.Title.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart1.Axes.Depth.Title.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart1.Axes.Depth.Title.Font.Shadow.Brush.Solid = true;
      tChart1.Axes.Depth.Title.Font.Shadow.Brush.Visible = true;
      tChart1.Axes.Depth.Title.Font.Size = 8;
      tChart1.Axes.Depth.Title.Font.SizeFloat = 8F;
      tChart1.Axes.Depth.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart1.Axes.Depth.Title.ImageBevel.Brush.Color = Color.LightGray;
      tChart1.Axes.Depth.Title.ImageBevel.Brush.Solid = true;
      tChart1.Axes.Depth.Title.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart1.Axes.Depth.Title.Shadow.Brush.Color = Color.DarkGray;
      tChart1.Axes.Depth.Title.Shadow.Brush.Solid = true;
      tChart1.Axes.Depth.Title.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      tChart1.Axes.DepthTop.Labels.Brush.Color = Color.White;
      tChart1.Axes.DepthTop.Labels.Brush.Solid = true;
      tChart1.Axes.DepthTop.Labels.Brush.Visible = true;
      // 
      // 
      // 
      tChart1.Axes.DepthTop.Labels.Font.Bold = false;
      // 
      // 
      // 
      tChart1.Axes.DepthTop.Labels.Font.Brush.Color = Color.FromArgb((int)(byte)255, (int)(byte)255, (int)(byte)255);
      tChart1.Axes.DepthTop.Labels.Font.Brush.Solid = true;
      tChart1.Axes.DepthTop.Labels.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart1.Axes.DepthTop.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart1.Axes.DepthTop.Labels.Font.Shadow.Brush.Solid = true;
      tChart1.Axes.DepthTop.Labels.Font.Shadow.Brush.Visible = true;
      tChart1.Axes.DepthTop.Labels.Font.Size = 8;
      tChart1.Axes.DepthTop.Labels.Font.SizeFloat = 8F;
      tChart1.Axes.DepthTop.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart1.Axes.DepthTop.Labels.ImageBevel.Brush.Color = Color.LightGray;
      tChart1.Axes.DepthTop.Labels.ImageBevel.Brush.Solid = true;
      tChart1.Axes.DepthTop.Labels.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart1.Axes.DepthTop.Labels.Shadow.Brush.Color = Color.DarkGray;
      tChart1.Axes.DepthTop.Labels.Shadow.Brush.Solid = true;
      tChart1.Axes.DepthTop.Labels.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart1.Axes.DepthTop.Title.Brush.Color = Color.Silver;
      tChart1.Axes.DepthTop.Title.Brush.Solid = true;
      tChart1.Axes.DepthTop.Title.Brush.Visible = true;
      // 
      // 
      // 
      tChart1.Axes.DepthTop.Title.Font.Bold = false;
      // 
      // 
      // 
      tChart1.Axes.DepthTop.Title.Font.Brush.Color = Color.FromArgb((int)(byte)0, (int)(byte)0, (int)(byte)0);
      tChart1.Axes.DepthTop.Title.Font.Brush.Solid = true;
      tChart1.Axes.DepthTop.Title.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart1.Axes.DepthTop.Title.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart1.Axes.DepthTop.Title.Font.Shadow.Brush.Solid = true;
      tChart1.Axes.DepthTop.Title.Font.Shadow.Brush.Visible = true;
      tChart1.Axes.DepthTop.Title.Font.Size = 8;
      tChart1.Axes.DepthTop.Title.Font.SizeFloat = 8F;
      tChart1.Axes.DepthTop.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart1.Axes.DepthTop.Title.ImageBevel.Brush.Color = Color.LightGray;
      tChart1.Axes.DepthTop.Title.ImageBevel.Brush.Solid = true;
      tChart1.Axes.DepthTop.Title.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart1.Axes.DepthTop.Title.Shadow.Brush.Color = Color.DarkGray;
      tChart1.Axes.DepthTop.Title.Shadow.Brush.Solid = true;
      tChart1.Axes.DepthTop.Title.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart1.Axes.Left.AxisPen.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart1.Axes.Left.Labels.Brush.Color = Color.White;
      tChart1.Axes.Left.Labels.Brush.Solid = true;
      tChart1.Axes.Left.Labels.Brush.Visible = true;
      // 
      // 
      // 
      tChart1.Axes.Left.Labels.Font.Bold = false;
      // 
      // 
      // 
      tChart1.Axes.Left.Labels.Font.Brush.Color = Color.White;
      tChart1.Axes.Left.Labels.Font.Brush.Solid = true;
      tChart1.Axes.Left.Labels.Font.Brush.Visible = true;
      tChart1.Axes.Left.Labels.Font.Name = "Yu Gothic";
      // 
      // 
      // 
      // 
      // 
      // 
      tChart1.Axes.Left.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart1.Axes.Left.Labels.Font.Shadow.Brush.Solid = true;
      tChart1.Axes.Left.Labels.Font.Shadow.Brush.Visible = true;
      tChart1.Axes.Left.Labels.Font.Size = 8;
      tChart1.Axes.Left.Labels.Font.SizeFloat = 8F;
      tChart1.Axes.Left.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart1.Axes.Left.Labels.ImageBevel.Brush.Color = Color.LightGray;
      tChart1.Axes.Left.Labels.ImageBevel.Brush.Solid = true;
      tChart1.Axes.Left.Labels.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart1.Axes.Left.Labels.Shadow.Brush.Color = Color.DarkGray;
      tChart1.Axes.Left.Labels.Shadow.Brush.Solid = true;
      tChart1.Axes.Left.Labels.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      tChart1.Axes.Left.MinorTicks.Color = Color.FromArgb((int)(byte)100, (int)(byte)100, (int)(byte)100);
      tChart1.Axes.Left.MinorTicks.Length = 1;
      tChart1.Axes.Left.MinorTicks.Visible = true;
      // 
      // 
      // 
      tChart1.Axes.Left.Ticks.Color = Color.FromArgb((int)(byte)100, (int)(byte)100, (int)(byte)100);
      tChart1.Axes.Left.Ticks.Length = 12;
      tChart1.Axes.Left.Ticks.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart1.Axes.Left.Title.Brush.Color = Color.Silver;
      tChart1.Axes.Left.Title.Brush.Solid = true;
      tChart1.Axes.Left.Title.Brush.Visible = true;
      // 
      // 
      // 
      tChart1.Axes.Left.Title.Font.Bold = false;
      // 
      // 
      // 
      tChart1.Axes.Left.Title.Font.Brush.Color = Color.Black;
      tChart1.Axes.Left.Title.Font.Brush.Solid = true;
      tChart1.Axes.Left.Title.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart1.Axes.Left.Title.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart1.Axes.Left.Title.Font.Shadow.Brush.Solid = true;
      tChart1.Axes.Left.Title.Font.Shadow.Brush.Visible = true;
      tChart1.Axes.Left.Title.Font.Size = 8;
      tChart1.Axes.Left.Title.Font.SizeFloat = 8F;
      tChart1.Axes.Left.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart1.Axes.Left.Title.ImageBevel.Brush.Color = Color.LightGray;
      tChart1.Axes.Left.Title.ImageBevel.Brush.Solid = true;
      tChart1.Axes.Left.Title.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart1.Axes.Left.Title.Shadow.Brush.Color = Color.DarkGray;
      tChart1.Axes.Left.Title.Shadow.Brush.Solid = true;
      tChart1.Axes.Left.Title.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      tChart1.Axes.Right.Labels.Brush.Color = Color.White;
      tChart1.Axes.Right.Labels.Brush.Solid = true;
      tChart1.Axes.Right.Labels.Brush.Visible = true;
      // 
      // 
      // 
      tChart1.Axes.Right.Labels.Font.Bold = false;
      // 
      // 
      // 
      tChart1.Axes.Right.Labels.Font.Brush.Color = Color.FromArgb((int)(byte)255, (int)(byte)255, (int)(byte)255);
      tChart1.Axes.Right.Labels.Font.Brush.Solid = true;
      tChart1.Axes.Right.Labels.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart1.Axes.Right.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart1.Axes.Right.Labels.Font.Shadow.Brush.Solid = true;
      tChart1.Axes.Right.Labels.Font.Shadow.Brush.Visible = true;
      tChart1.Axes.Right.Labels.Font.Size = 8;
      tChart1.Axes.Right.Labels.Font.SizeFloat = 8F;
      tChart1.Axes.Right.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart1.Axes.Right.Labels.ImageBevel.Brush.Color = Color.LightGray;
      tChart1.Axes.Right.Labels.ImageBevel.Brush.Solid = true;
      tChart1.Axes.Right.Labels.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart1.Axes.Right.Labels.Shadow.Brush.Color = Color.DarkGray;
      tChart1.Axes.Right.Labels.Shadow.Brush.Solid = true;
      tChart1.Axes.Right.Labels.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart1.Axes.Right.Title.Brush.Color = Color.Silver;
      tChart1.Axes.Right.Title.Brush.Solid = true;
      tChart1.Axes.Right.Title.Brush.Visible = true;
      // 
      // 
      // 
      tChart1.Axes.Right.Title.Font.Bold = false;
      // 
      // 
      // 
      tChart1.Axes.Right.Title.Font.Brush.Color = Color.FromArgb((int)(byte)0, (int)(byte)0, (int)(byte)0);
      tChart1.Axes.Right.Title.Font.Brush.Solid = true;
      tChart1.Axes.Right.Title.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart1.Axes.Right.Title.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart1.Axes.Right.Title.Font.Shadow.Brush.Solid = true;
      tChart1.Axes.Right.Title.Font.Shadow.Brush.Visible = true;
      tChart1.Axes.Right.Title.Font.Size = 8;
      tChart1.Axes.Right.Title.Font.SizeFloat = 8F;
      tChart1.Axes.Right.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart1.Axes.Right.Title.ImageBevel.Brush.Color = Color.LightGray;
      tChart1.Axes.Right.Title.ImageBevel.Brush.Solid = true;
      tChart1.Axes.Right.Title.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart1.Axes.Right.Title.Shadow.Brush.Color = Color.DarkGray;
      tChart1.Axes.Right.Title.Shadow.Brush.Solid = true;
      tChart1.Axes.Right.Title.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      tChart1.Axes.Top.Labels.Brush.Color = Color.White;
      tChart1.Axes.Top.Labels.Brush.Solid = true;
      tChart1.Axes.Top.Labels.Brush.Visible = true;
      // 
      // 
      // 
      tChart1.Axes.Top.Labels.Font.Bold = false;
      // 
      // 
      // 
      tChart1.Axes.Top.Labels.Font.Brush.Color = Color.FromArgb((int)(byte)255, (int)(byte)255, (int)(byte)255);
      tChart1.Axes.Top.Labels.Font.Brush.Solid = true;
      tChart1.Axes.Top.Labels.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart1.Axes.Top.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart1.Axes.Top.Labels.Font.Shadow.Brush.Solid = true;
      tChart1.Axes.Top.Labels.Font.Shadow.Brush.Visible = true;
      tChart1.Axes.Top.Labels.Font.Size = 8;
      tChart1.Axes.Top.Labels.Font.SizeFloat = 8F;
      tChart1.Axes.Top.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart1.Axes.Top.Labels.ImageBevel.Brush.Color = Color.LightGray;
      tChart1.Axes.Top.Labels.ImageBevel.Brush.Solid = true;
      tChart1.Axes.Top.Labels.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart1.Axes.Top.Labels.Shadow.Brush.Color = Color.DarkGray;
      tChart1.Axes.Top.Labels.Shadow.Brush.Solid = true;
      tChart1.Axes.Top.Labels.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart1.Axes.Top.Title.Brush.Color = Color.Silver;
      tChart1.Axes.Top.Title.Brush.Solid = true;
      tChart1.Axes.Top.Title.Brush.Visible = true;
      // 
      // 
      // 
      tChart1.Axes.Top.Title.Font.Bold = false;
      // 
      // 
      // 
      tChart1.Axes.Top.Title.Font.Brush.Color = Color.FromArgb((int)(byte)0, (int)(byte)0, (int)(byte)0);
      tChart1.Axes.Top.Title.Font.Brush.Solid = true;
      tChart1.Axes.Top.Title.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart1.Axes.Top.Title.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart1.Axes.Top.Title.Font.Shadow.Brush.Solid = true;
      tChart1.Axes.Top.Title.Font.Shadow.Brush.Visible = true;
      tChart1.Axes.Top.Title.Font.Size = 8;
      tChart1.Axes.Top.Title.Font.SizeFloat = 8F;
      tChart1.Axes.Top.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart1.Axes.Top.Title.ImageBevel.Brush.Color = Color.LightGray;
      tChart1.Axes.Top.Title.ImageBevel.Brush.Solid = true;
      tChart1.Axes.Top.Title.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart1.Axes.Top.Title.Shadow.Brush.Color = Color.DarkGray;
      tChart1.Axes.Top.Title.Shadow.Brush.Solid = true;
      tChart1.Axes.Top.Title.Shadow.Brush.Visible = true;
      tChart1.Dock = DockStyle.Bottom;
      // 
      // 
      // 
      tChart1.Footer.Bottom = 176;
      // 
      // 
      // 
      tChart1.Footer.Brush.Color = Color.Silver;
      tChart1.Footer.Brush.Solid = true;
      tChart1.Footer.Brush.Visible = true;
      tChart1.Footer.CustomPosition = true;
      // 
      // 
      // 
      tChart1.Footer.Font.Bold = false;
      // 
      // 
      // 
      tChart1.Footer.Font.Brush.Color = Color.FromArgb((int)(byte)192, (int)(byte)192, (int)(byte)192);
      tChart1.Footer.Font.Brush.Solid = true;
      tChart1.Footer.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart1.Footer.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart1.Footer.Font.Shadow.Brush.Solid = true;
      tChart1.Footer.Font.Shadow.Brush.Visible = true;
      tChart1.Footer.Font.Size = 8;
      tChart1.Footer.Font.SizeFloat = 8F;
      tChart1.Footer.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart1.Footer.ImageBevel.Brush.Color = Color.LightGray;
      tChart1.Footer.ImageBevel.Brush.Solid = true;
      tChart1.Footer.ImageBevel.Brush.Visible = true;
      tChart1.Footer.Left = 6;
      tChart1.Footer.Lines = new string[]
  {
    "Flue Gen"
  };
      tChart1.Footer.Right = 72;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart1.Footer.Shadow.Brush.Color = Color.DarkGray;
      tChart1.Footer.Shadow.Brush.Solid = true;
      tChart1.Footer.Shadow.Brush.Visible = true;
      tChart1.Footer.Top = 161;
      tChart1.Footer.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart1.Header.Brush.Color = Color.FromArgb((int)(byte)192, (int)(byte)192, (int)(byte)192);
      // 
      // 
      // 
      tChart1.Header.Brush.Gradient.SigmaFocus = 0F;
      tChart1.Header.Brush.Gradient.SigmaScale = 0F;
      tChart1.Header.Brush.Solid = true;
      tChart1.Header.Brush.Visible = true;
      // 
      // 
      // 
      tChart1.Header.Font.Bold = false;
      // 
      // 
      // 
      tChart1.Header.Font.Brush.Color = Color.FromArgb((int)(byte)255, (int)(byte)255, (int)(byte)255);
      tChart1.Header.Font.Brush.Solid = true;
      tChart1.Header.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart1.Header.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart1.Header.Font.Shadow.Brush.Solid = true;
      tChart1.Header.Font.Shadow.Brush.Visible = true;
      tChart1.Header.Font.Size = 8;
      tChart1.Header.Font.SizeFloat = 8F;
      tChart1.Header.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart1.Header.ImageBevel.Brush.Color = Color.LightGray;
      tChart1.Header.ImageBevel.Brush.Solid = true;
      tChart1.Header.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart1.Header.Shadow.Brush.Color = Color.FromArgb((int)(byte)169, (int)(byte)169, (int)(byte)169);
      tChart1.Header.Shadow.Brush.Solid = true;
      tChart1.Header.Shadow.Brush.Visible = true;
      tChart1.Header.Shadow.Height = 0;
      tChart1.Header.Shadow.Width = 0;
      tChart1.Header.Visible = false;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart1.Legend.Brush.Color = Color.White;
      // 
      // 
      // 
      tChart1.Legend.Brush.Gradient.SigmaFocus = 0F;
      tChart1.Legend.Brush.Gradient.SigmaScale = 0F;
      tChart1.Legend.Brush.Gradient.Visible = true;
      tChart1.Legend.Brush.Solid = true;
      tChart1.Legend.Brush.Visible = true;
      tChart1.Legend.CheckBoxes = false;
      tChart1.Legend.ClipText = false;
      // 
      // 
      // 
      tChart1.Legend.Font.Bold = false;
      // 
      // 
      // 
      tChart1.Legend.Font.Brush.Color = Color.FromArgb((int)(byte)255, (int)(byte)255, (int)(byte)255);
      tChart1.Legend.Font.Brush.Solid = true;
      tChart1.Legend.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart1.Legend.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart1.Legend.Font.Shadow.Brush.Solid = true;
      tChart1.Legend.Font.Shadow.Brush.Visible = true;
      tChart1.Legend.Font.Size = 8;
      tChart1.Legend.Font.SizeFloat = 8F;
      tChart1.Legend.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart1.Legend.ImageBevel.Brush.Color = Color.LightGray;
      tChart1.Legend.ImageBevel.Brush.Solid = true;
      tChart1.Legend.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart1.Legend.Shadow.Brush.Color = Color.FromArgb((int)(byte)0, (int)(byte)0, (int)(byte)0);
      tChart1.Legend.Shadow.Brush.Solid = true;
      tChart1.Legend.Shadow.Brush.Visible = true;
      tChart1.Legend.Shadow.Width = 0;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      tChart1.Legend.Symbol.Shadow.Brush.Color = Color.DarkGray;
      tChart1.Legend.Symbol.Shadow.Brush.Solid = true;
      tChart1.Legend.Symbol.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart1.Legend.Title.Brush.Color = Color.White;
      tChart1.Legend.Title.Brush.Solid = true;
      tChart1.Legend.Title.Brush.Visible = true;
      // 
      // 
      // 
      tChart1.Legend.Title.Font.Bold = true;
      // 
      // 
      // 
      tChart1.Legend.Title.Font.Brush.Color = Color.Black;
      tChart1.Legend.Title.Font.Brush.Solid = true;
      tChart1.Legend.Title.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart1.Legend.Title.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart1.Legend.Title.Font.Shadow.Brush.Solid = true;
      tChart1.Legend.Title.Font.Shadow.Brush.Visible = true;
      tChart1.Legend.Title.Font.Size = 8;
      tChart1.Legend.Title.Font.SizeFloat = 8F;
      tChart1.Legend.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Bold;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart1.Legend.Title.ImageBevel.Brush.Color = Color.LightGray;
      tChart1.Legend.Title.ImageBevel.Brush.Solid = true;
      tChart1.Legend.Title.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart1.Legend.Title.Shadow.Brush.Color = Color.DarkGray;
      tChart1.Legend.Title.Shadow.Brush.Solid = true;
      tChart1.Legend.Title.Shadow.Brush.Visible = true;
      tChart1.Location = new Point(0, 708);
      tChart1.Name = "tChart1";
      // 
      // 
      // 
      // 
      // 
      // 
      tChart1.Panel.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.Raised;
      // 
      // 
      // 
      tChart1.Panel.Brush.Color = Color.FromArgb((int)(byte)240, (int)(byte)240, (int)(byte)240);
      // 
      // 
      // 
      tChart1.Panel.Brush.Gradient.EndColor = Color.FromArgb((int)(byte)70, (int)(byte)70, (int)(byte)70);
      tChart1.Panel.Brush.Gradient.MiddleColor = Color.FromArgb((int)(byte)0, (int)(byte)0, (int)(byte)0, (int)(byte)0);
      tChart1.Panel.Brush.Gradient.SigmaFocus = 0F;
      tChart1.Panel.Brush.Gradient.SigmaScale = 0F;
      tChart1.Panel.Brush.Gradient.StartColor = Color.FromArgb((int)(byte)70, (int)(byte)70, (int)(byte)70);
      tChart1.Panel.Brush.Gradient.UseMiddle = false;
      tChart1.Panel.Brush.Gradient.Visible = true;
      tChart1.Panel.Brush.Solid = true;
      tChart1.Panel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart1.Panel.ImageBevel.Brush.Color = Color.LightGray;
      tChart1.Panel.ImageBevel.Brush.Solid = true;
      tChart1.Panel.ImageBevel.Brush.Visible = true;
      tChart1.Panel.MarginBottom = 20D;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart1.Panel.Shadow.Brush.Color = Color.DarkGray;
      tChart1.Panel.Shadow.Brush.Solid = true;
      tChart1.Panel.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      margins5.Bottom = 100;
      margins5.Left = 100;
      margins5.Right = 100;
      margins5.Top = 100;
      tChart1.Printer.Margins = margins5;
      tChart1.Series.Add(circularGauge1);
      tChart1.Size = new Size(195, 228);
      // 
      // 
      // 
      tChart1.SubFooter.Alignment = Steema.TeeChart.Drawing.StringAlignment.Near;
      tChart1.SubFooter.Bottom = 176;
      // 
      // 
      // 
      tChart1.SubFooter.Brush.Color = Color.Silver;
      tChart1.SubFooter.Brush.Solid = true;
      tChart1.SubFooter.Brush.Visible = true;
      tChart1.SubFooter.CustomPosition = true;
      // 
      // 
      // 
      tChart1.SubFooter.Font.Bold = false;
      // 
      // 
      // 
      tChart1.SubFooter.Font.Brush.Color = Color.Silver;
      tChart1.SubFooter.Font.Brush.Solid = true;
      tChart1.SubFooter.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart1.SubFooter.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart1.SubFooter.Font.Shadow.Brush.Solid = true;
      tChart1.SubFooter.Font.Shadow.Brush.Visible = true;
      tChart1.SubFooter.Font.Size = 8;
      tChart1.SubFooter.Font.SizeFloat = 8F;
      tChart1.SubFooter.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart1.SubFooter.ImageBevel.Brush.Color = Color.LightGray;
      tChart1.SubFooter.ImageBevel.Brush.Solid = true;
      tChart1.SubFooter.ImageBevel.Brush.Visible = true;
      tChart1.SubFooter.Left = 6;
      tChart1.SubFooter.Right = 21;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart1.SubFooter.Shadow.Brush.Color = Color.DarkGray;
      tChart1.SubFooter.Shadow.Brush.Solid = true;
      tChart1.SubFooter.Shadow.Brush.Visible = true;
      tChart1.SubFooter.Top = 161;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart1.SubHeader.Brush.Color = Color.FromArgb((int)(byte)192, (int)(byte)192, (int)(byte)192);
      tChart1.SubHeader.Brush.Solid = true;
      tChart1.SubHeader.Brush.Visible = true;
      // 
      // 
      // 
      tChart1.SubHeader.Font.Bold = false;
      // 
      // 
      // 
      tChart1.SubHeader.Font.Brush.Color = Color.FromArgb((int)(byte)128, (int)(byte)128, (int)(byte)128);
      tChart1.SubHeader.Font.Brush.Solid = true;
      tChart1.SubHeader.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart1.SubHeader.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart1.SubHeader.Font.Shadow.Brush.Solid = true;
      tChart1.SubHeader.Font.Shadow.Brush.Visible = true;
      tChart1.SubHeader.Font.Size = 12;
      tChart1.SubHeader.Font.SizeFloat = 12F;
      tChart1.SubHeader.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart1.SubHeader.ImageBevel.Brush.Color = Color.LightGray;
      tChart1.SubHeader.ImageBevel.Brush.Solid = true;
      tChart1.SubHeader.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart1.SubHeader.Shadow.Brush.Color = Color.FromArgb((int)(byte)169, (int)(byte)169, (int)(byte)169);
      tChart1.SubHeader.Shadow.Brush.Solid = true;
      tChart1.SubHeader.Shadow.Brush.Visible = true;
      tChart1.TabIndex = 0;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      tChart1.Walls.Back.Brush.Color = Color.Silver;
      // 
      // 
      // 
      tChart1.Walls.Back.Brush.Gradient.EndColor = Color.FromArgb((int)(byte)120, (int)(byte)120, (int)(byte)120);
      tChart1.Walls.Back.Brush.Gradient.StartColor = Color.FromArgb((int)(byte)70, (int)(byte)70, (int)(byte)70);
      tChart1.Walls.Back.Brush.Solid = true;
      tChart1.Walls.Back.Brush.Visible = false;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart1.Walls.Back.ImageBevel.Brush.Color = Color.LightGray;
      tChart1.Walls.Back.ImageBevel.Brush.Solid = true;
      tChart1.Walls.Back.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart1.Walls.Back.Shadow.Brush.Color = Color.DarkGray;
      tChart1.Walls.Back.Shadow.Brush.Solid = true;
      tChart1.Walls.Back.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart1.Walls.Bottom.Brush.Color = Color.White;
      // 
      // 
      // 
      tChart1.Walls.Bottom.Brush.Gradient.SigmaFocus = 0F;
      tChart1.Walls.Bottom.Brush.Gradient.SigmaScale = 0F;
      tChart1.Walls.Bottom.Brush.Solid = true;
      tChart1.Walls.Bottom.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart1.Walls.Bottom.ImageBevel.Brush.Color = Color.LightGray;
      tChart1.Walls.Bottom.ImageBevel.Brush.Solid = true;
      tChart1.Walls.Bottom.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart1.Walls.Bottom.Shadow.Brush.Color = Color.DarkGray;
      tChart1.Walls.Bottom.Shadow.Brush.Solid = true;
      tChart1.Walls.Bottom.Shadow.Brush.Visible = true;
      tChart1.Walls.Bottom.Visible = false;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart1.Walls.Left.Brush.Color = Color.LightYellow;
      // 
      // 
      // 
      tChart1.Walls.Left.Brush.Gradient.SigmaFocus = 0F;
      tChart1.Walls.Left.Brush.Gradient.SigmaScale = 0F;
      tChart1.Walls.Left.Brush.Solid = true;
      tChart1.Walls.Left.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart1.Walls.Left.ImageBevel.Brush.Color = Color.LightGray;
      tChart1.Walls.Left.ImageBevel.Brush.Solid = true;
      tChart1.Walls.Left.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart1.Walls.Left.Shadow.Brush.Color = Color.DarkGray;
      tChart1.Walls.Left.Shadow.Brush.Solid = true;
      tChart1.Walls.Left.Shadow.Brush.Visible = true;
      tChart1.Walls.Left.Visible = false;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart1.Walls.Right.Brush.Color = Color.FromArgb((int)(byte)192, (int)(byte)192, (int)(byte)192);
      // 
      // 
      // 
      tChart1.Walls.Right.Brush.Gradient.SigmaFocus = 0F;
      tChart1.Walls.Right.Brush.Gradient.SigmaScale = 0F;
      tChart1.Walls.Right.Brush.Solid = true;
      tChart1.Walls.Right.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart1.Walls.Right.ImageBevel.Brush.Color = Color.LightGray;
      tChart1.Walls.Right.ImageBevel.Brush.Solid = true;
      tChart1.Walls.Right.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart1.Walls.Right.Shadow.Brush.Color = Color.DarkGray;
      tChart1.Walls.Right.Shadow.Brush.Solid = true;
      tChart1.Walls.Right.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart1.Zoom.Brush.Color = Color.FromArgb((int)(byte)127, (int)(byte)0, (int)(byte)0, (int)(byte)255);
      tChart1.Zoom.Brush.Solid = true;
      tChart1.Zoom.Brush.Visible = false;
      tChart1.AfterDraw += (this.tChart1_AfterDraw);
      tChart1.BeforeDrawAxes += (this.tChart1_BeforeDrawAxes);
      // 
      // circularGauge1
      // 
      // 
      // 
      // 
      circularGauge1.Brush.Color = Color.Empty;
      circularGauge1.Brush.Solid = true;
      circularGauge1.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      circularGauge1.Center.Brush.Color = Color.FromArgb((int)(byte)130, (int)(byte)130, (int)(byte)130);
      circularGauge1.Center.Brush.Solid = true;
      circularGauge1.Center.Brush.Visible = true;
      circularGauge1.Center.HorizSize = 16;
      // 
      // 
      // 
      circularGauge1.Center.Pen.Color = Color.FromArgb((int)(byte)130, (int)(byte)130, (int)(byte)130);
      circularGauge1.Center.Pen.Width = 2;
      circularGauge1.Center.Position = 0;
      circularGauge1.Center.Spiralled = false;
      circularGauge1.Center.Style = (Steema.TeeChart.Styles.GaugePointerStyles)resources.GetObject("resource.Style");
      circularGauge1.Center.VertSize = 16;
      circularGauge1.Center.Visible = true;
      circularGauge1.Circled = true;
      circularGauge1.Color = Color.FromArgb((int)(byte)119, (int)(byte)153, (int)(byte)214);
      circularGauge1.ColorLineEndValues.Add(100D);
      circularGauge1.ColorLineEndValues.Add(70D);
      circularGauge1.ColorLineEndValues.Add(100D);
      circularGauge1.ColorLineEndValues.Add(70D);
      circularGauge1.ColorLineEndValues.Add(100D);
      circularGauge1.ColorLineEndValues.Add(70D);
      circularGauge1.ColorLineEndValues.Add(100D);
      circularGauge1.ColorLineEndValues.Add(70D);
      circularGauge1.ColorLineEndValues.Add(100D);
      circularGauge1.ColorLineEndValues.Add(70D);
      circularGauge1.ColorLineEndValues.Add(100D);
      circularGauge1.ColorLineEndValues.Add(70D);
      circularGauge1.ColorLineEndValues.Add(100D);
      circularGauge1.ColorLineEndValues.Add(70D);
      circularGauge1.ColorLineEndValues.Add(100D);
      circularGauge1.ColorLineEndValues.Add(70D);
      circularGauge1.ColorLineEndValues.Add(100D);
      circularGauge1.ColorLineEndValues.Add(70D);
      circularGauge1.ColorLineEndValues.Add(100D);
      circularGauge1.ColorLineEndValues.Add(70D);
      circularGauge1.ColorLineEndValues.Add(100D);
      circularGauge1.ColorLineEndValues.Add(70D);
      circularGauge1.ColorLineEndValues.Add(100D);
      circularGauge1.ColorLineEndValues.Add(70D);
      circularGauge1.ColorLineEndValues.Add(100D);
      circularGauge1.ColorLineEndValues.Add(70D);
      circularGauge1.ColorLineEndValues.Add(100D);
      circularGauge1.ColorLineEndValues.Add(70D);
      circularGauge1.ColorLineEndValues.Add(100D);
      circularGauge1.ColorLineEndValues.Add(70D);
      circularGauge1.ColorLineEndValues.Add(100D);
      circularGauge1.ColorLineEndValues.Add(70D);
      circularGauge1.ColorLineEndValues.Add(100D);
      circularGauge1.ColorLineEndValues.Add(70D);
      circularGauge1.ColorLineEndValues.Add(100D);
      circularGauge1.ColorLineEndValues.Add(70D);
      circularGauge1.ColorLineEndValues.Add(100D);
      circularGauge1.ColorLineEndValues.Add(70D);
      circularGauge1.ColorLineEndValues.Add(100D);
      circularGauge1.ColorLineEndValues.Add(70D);
      circularGauge1.ColorLineEndValues.Add(100D);
      circularGauge1.ColorLineEndValues.Add(70D);
      circularGauge1.ColorLineEndValues.Add(100D);
      circularGauge1.ColorLineEndValues.Add(70D);
      circularGauge1.ColorLineEndValues.Add(100D);
      circularGauge1.ColorLineEndValues.Add(70D);
      circularGauge1.ColorLineEndValues.Add(100D);
      circularGauge1.ColorLineEndValues.Add(70D);
      circularGauge1.ColorLineEndValues.Add(100D);
      circularGauge1.ColorLineEndValues.Add(70D);
      circularGauge1.ColorLineEndValues.Add(100D);
      circularGauge1.ColorLineEndValues.Add(70D);
      circularGauge1.ColorLineEndValues.Add(100D);
      circularGauge1.ColorLineEndValues.Add(70D);
      circularGauge1.ColorLineEndValues.Add(100D);
      circularGauge1.ColorLineEndValues.Add(70D);
      circularGauge1.ColorLineEndValues.Add(100D);
      circularGauge1.ColorLineEndValues.Add(70D);
      circularGauge1.ColorLineEndValues.Add(100D);
      circularGauge1.ColorLineEndValues.Add(70D);
      circularGauge1.ColorLineEndValues.Add(100D);
      circularGauge1.ColorLineEndValues.Add(70D);
      circularGauge1.ColorLineEndValues.Add(100D);
      circularGauge1.ColorLineEndValues.Add(70D);
      circularGauge1.ColorLineEndValues.Add(100D);
      circularGauge1.ColorLineEndValues.Add(70D);
      circularGauge1.ColorLineStartValues.Add(80D);
      circularGauge1.ColorLineStartValues.Add(0D);
      circularGauge1.ColorLineStartValues.Add(80D);
      circularGauge1.ColorLineStartValues.Add(0D);
      circularGauge1.ColorLineStartValues.Add(80D);
      circularGauge1.ColorLineStartValues.Add(0D);
      circularGauge1.ColorLineStartValues.Add(80D);
      circularGauge1.ColorLineStartValues.Add(0D);
      circularGauge1.ColorLineStartValues.Add(80D);
      circularGauge1.ColorLineStartValues.Add(0D);
      circularGauge1.ColorLineStartValues.Add(80D);
      circularGauge1.ColorLineStartValues.Add(0D);
      circularGauge1.ColorLineStartValues.Add(80D);
      circularGauge1.ColorLineStartValues.Add(0D);
      circularGauge1.ColorLineStartValues.Add(80D);
      circularGauge1.ColorLineStartValues.Add(0D);
      circularGauge1.ColorLineStartValues.Add(80D);
      circularGauge1.ColorLineStartValues.Add(0D);
      circularGauge1.ColorLineStartValues.Add(80D);
      circularGauge1.ColorLineStartValues.Add(0D);
      circularGauge1.ColorLineStartValues.Add(73D);
      circularGauge1.ColorLineStartValues.Add(0D);
      circularGauge1.ColorLineStartValues.Add(73D);
      circularGauge1.ColorLineStartValues.Add(0D);
      circularGauge1.ColorLineStartValues.Add(73D);
      circularGauge1.ColorLineStartValues.Add(0D);
      circularGauge1.ColorLineStartValues.Add(73D);
      circularGauge1.ColorLineStartValues.Add(0D);
      circularGauge1.ColorLineStartValues.Add(73D);
      circularGauge1.ColorLineStartValues.Add(0D);
      circularGauge1.ColorLineStartValues.Add(73D);
      circularGauge1.ColorLineStartValues.Add(0D);
      circularGauge1.ColorLineStartValues.Add(73D);
      circularGauge1.ColorLineStartValues.Add(0D);
      circularGauge1.ColorLineStartValues.Add(73D);
      circularGauge1.ColorLineStartValues.Add(0D);
      circularGauge1.ColorLineStartValues.Add(73D);
      circularGauge1.ColorLineStartValues.Add(0D);
      circularGauge1.ColorLineStartValues.Add(73D);
      circularGauge1.ColorLineStartValues.Add(0D);
      circularGauge1.ColorLineStartValues.Add(73D);
      circularGauge1.ColorLineStartValues.Add(0D);
      circularGauge1.ColorLineStartValues.Add(73D);
      circularGauge1.ColorLineStartValues.Add(0D);
      circularGauge1.ColorLineStartValues.Add(73D);
      circularGauge1.ColorLineStartValues.Add(0D);
      circularGauge1.ColorLineStartValues.Add(73D);
      circularGauge1.ColorLineStartValues.Add(0D);
      circularGauge1.ColorLineStartValues.Add(73D);
      circularGauge1.ColorLineStartValues.Add(0D);
      circularGauge1.ColorLineStartValues.Add(73D);
      circularGauge1.ColorLineStartValues.Add(0D);
      circularGauge1.ColorLineStartValues.Add(73D);
      circularGauge1.ColorLineStartValues.Add(0D);
      circularGauge1.ColorLineStartValues.Add(80D);
      circularGauge1.ColorLineStartValues.Add(0D);
      circularGauge1.ColorLineStartValues.Add(75D);
      circularGauge1.ColorLineStartValues.Add(0D);
      circularGauge1.ColorLineStartValues.Add(80D);
      circularGauge1.ColorLineStartValues.Add(0D);
      circularGauge1.ColorLineStartValues.Add(80D);
      circularGauge1.ColorLineStartValues.Add(0D);
      circularGauge1.ColorLineStartValues.Add(80D);
      circularGauge1.ColorLineStartValues.Add(0D);
      circularGauge1.ColorLineStartValues.Add(80D);
      circularGauge1.ColorLineStartValues.Add(0D);
      circularGauge1.Cursor = cursor1;
      // 
      // 
      // 
      circularGauge1.FaceBrush.Color = Color.FromArgb((int)(byte)15, (int)(byte)15, (int)(byte)15);
      // 
      // 
      // 
      // 
      // 
      // 
      circularGauge1.FaceBrush.Gradient.Style.CenterXOffset = 26;
      circularGauge1.FaceBrush.Gradient.Style.CenterYOffset = -26;
      circularGauge1.FaceBrush.Gradient.Style.Direction = Steema.TeeChart.Drawing.PathGradientMode.Radial;
      circularGauge1.FaceBrush.Gradient.Style.Visible = true;
      circularGauge1.FaceBrush.Gradient.Visible = true;
      circularGauge1.FaceBrush.Solid = true;
      circularGauge1.FaceBrush.Visible = true;
      // 
      // 
      // 
      circularGauge1.Frame.Circled = true;
      circularGauge1.Frame.FrameElementPercents = new double[]
  {
    39D,
    47D,
    13.06928673489992D
  };
      // 
      // 
      // 
      circularGauge1.Frame.InnerBand.Color = Color.FromArgb((int)(byte)128, (int)(byte)128, (int)(byte)128);
      circularGauge1.Frame.InnerBand.Solid = true;
      circularGauge1.Frame.InnerBand.Visible = true;
      // 
      // 
      // 
      circularGauge1.Frame.OuterBand.Color = Color.FromArgb((int)(byte)128, (int)(byte)128, (int)(byte)128);
      // 
      // 
      // 
      circularGauge1.Frame.OuterBand.Gradient.UseMiddle = true;
      circularGauge1.Frame.OuterBand.Gradient.Visible = true;
      circularGauge1.Frame.OuterBand.Solid = true;
      circularGauge1.Frame.OuterBand.Visible = true;
      circularGauge1.Frame.Visible = false;
      circularGauge1.Frame.Width = 9;
      circularGauge1.GaugeColorPalette = new Color[]
  {
    Color.FromArgb((int)(byte)40, (int)(byte)40, (int)(byte)40),
    Color.FromArgb((int)(byte)50, (int)(byte)50, (int)(byte)50),
    Color.FromArgb((int)(byte)100, (int)(byte)100, (int)(byte)100),
    Color.FromArgb((int)(byte)15, (int)(byte)15, (int)(byte)15),
    Color.FromArgb((int)(byte)100, (int)(byte)100, (int)(byte)100),
    Color.FromArgb((int)(byte)15, (int)(byte)15, (int)(byte)15),
    Color.FromArgb((int)(byte)100, (int)(byte)40, (int)(byte)40),
    Color.Empty,
    Color.FromArgb((int)(byte)100, (int)(byte)100, (int)(byte)100),
    Color.FromArgb((int)(byte)100, (int)(byte)100, (int)(byte)100),
    Color.Empty,
    Color.FromArgb((int)(byte)30, (int)(byte)200, (int)(byte)30),
    Color.FromArgb((int)(byte)200, (int)(byte)115, (int)(byte)60),
    Color.FromArgb((int)(byte)200, (int)(byte)115, (int)(byte)60),
    Color.FromArgb((int)(byte)200, (int)(byte)115, (int)(byte)60),
    Color.FromArgb((int)(byte)150, (int)(byte)50, (int)(byte)10),
    Color.FromArgb((int)(byte)130, (int)(byte)130, (int)(byte)130),
    Color.FromArgb((int)(byte)130, (int)(byte)130, (int)(byte)130),
    Color.Empty,
    Color.FromArgb((int)(byte)30, (int)(byte)30, (int)(byte)30),
    Color.FromArgb((int)(byte)100, (int)(byte)100, (int)(byte)100),
    Color.FromArgb((int)(byte)100, (int)(byte)100, (int)(byte)100),
    Color.FromArgb((int)(byte)100, (int)(byte)100, (int)(byte)100),
    Color.FromArgb((int)(byte)100, (int)(byte)100, (int)(byte)100),
    Color.FromArgb((int)(byte)128, (int)(byte)128, (int)(byte)128),
    Color.FromArgb((int)(byte)192, (int)(byte)192, (int)(byte)192),
    Color.FromArgb((int)(byte)224, (int)(byte)224, (int)(byte)224)
  };
      circularGauge1.HandDistances.Add(80);
      circularGauge1.HandDistances.Add(80);
      circularGauge1.HandDistances.Add(80);
      circularGauge1.HandDistances.Add(80);
      circularGauge1.HandDistances.Add(80);
      circularGauge1.HandDistances.Add(80);
      circularGauge1.HandDistances.Add(80);
      circularGauge1.HandDistances.Add(80);
      circularGauge1.HandDistances.Add(80);
      circularGauge1.HandDistances.Add(80);
      circularGauge1.HandDistances.Add(80);
      circularGauge1.HandDistances.Add(80);
      circularGauge1.HandDistances.Add(80);
      circularGauge1.HandDistances.Add(80);
      circularGauge1.HandDistances.Add(80);
      circularGauge1.HandDistances.Add(80);
      circularGauge1.HandDistances.Add(80);
      circularGauge1.HandDistances.Add(80);
      circularGauge1.HandDistances.Add(80);
      circularGauge1.HandDistances.Add(80);
      circularGauge1.HandDistances.Add(80);
      circularGauge1.HandDistances.Add(80);
      circularGauge1.HandDistances.Add(80);
      circularGauge1.HandDistances.Add(80);
      circularGauge1.HandDistances.Add(80);
      circularGauge1.HandDistances.Add(80);
      circularGauge1.HandDistances.Add(80);
      circularGauge1.HandDistances.Add(80);
      circularGauge1.HandDistances.Add(80);
      circularGauge1.HandDistances.Add(80);
      circularGauge1.HandDistances.Add(80);
      circularGauge1.HandDistances.Add(80);
      circularGauge1.HandDistances.Add(80);
      circularGauge1.HandOffsets.Add(30);
      circularGauge1.HandOffsets.Add(30);
      circularGauge1.HandOffsets.Add(30);
      circularGauge1.HandOffsets.Add(30);
      circularGauge1.HandOffsets.Add(30);
      circularGauge1.HandOffsets.Add(30);
      circularGauge1.HandOffsets.Add(30);
      circularGauge1.HandOffsets.Add(30);
      circularGauge1.HandOffsets.Add(30);
      circularGauge1.HandOffsets.Add(30);
      circularGauge1.HandOffsets.Add(30);
      circularGauge1.HandOffsets.Add(30);
      circularGauge1.HandOffsets.Add(30);
      circularGauge1.HandOffsets.Add(30);
      circularGauge1.HandOffsets.Add(30);
      circularGauge1.HandOffsets.Add(30);
      circularGauge1.HandOffsets.Add(30);
      circularGauge1.HandOffsets.Add(30);
      circularGauge1.HandOffsets.Add(30);
      circularGauge1.HandOffsets.Add(30);
      circularGauge1.HandOffsets.Add(30);
      circularGauge1.HandOffsets.Add(30);
      circularGauge1.HandOffsets.Add(30);
      circularGauge1.HandOffsets.Add(30);
      circularGauge1.HandOffsets.Add(30);
      circularGauge1.HandOffsets.Add(30);
      circularGauge1.HandOffsets.Add(30);
      circularGauge1.HandOffsets.Add(30);
      circularGauge1.HandOffsets.Add(30);
      circularGauge1.HandOffsets.Add(30);
      circularGauge1.HandOffsets.Add(30);
      circularGauge1.HandOffsets.Add(30);
      circularGauge1.HandOffsets.Add(30);
      circularGauge1.LabelsInside = false;
      // 
      // 
      // 
      // 
      // 
      // 
      circularGauge1.Legend.Brush.Color = Color.White;
      circularGauge1.Legend.Brush.Solid = true;
      circularGauge1.Legend.Brush.Visible = true;
      // 
      // 
      // 
      circularGauge1.Legend.Font.Bold = false;
      // 
      // 
      // 
      circularGauge1.Legend.Font.Brush.Color = Color.Black;
      circularGauge1.Legend.Font.Brush.Solid = true;
      circularGauge1.Legend.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      circularGauge1.Legend.Font.Shadow.Brush.Color = Color.DarkGray;
      circularGauge1.Legend.Font.Shadow.Brush.Solid = true;
      circularGauge1.Legend.Font.Shadow.Brush.Visible = true;
      circularGauge1.Legend.Font.Size = 8;
      circularGauge1.Legend.Font.SizeFloat = 8F;
      circularGauge1.Legend.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      circularGauge1.Legend.ImageBevel.Brush.Color = Color.LightGray;
      circularGauge1.Legend.ImageBevel.Brush.Solid = true;
      circularGauge1.Legend.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      circularGauge1.Legend.Shadow.Brush.Color = Color.DarkGray;
      circularGauge1.Legend.Shadow.Brush.Solid = true;
      circularGauge1.Legend.Shadow.Brush.Visible = true;
      circularGauge1.Legend.Visible = false;
      // 
      // 
      // 
      // 
      // 
      // 
      circularGauge1.Marks.Brush.Color = Color.FromArgb((int)(byte)255, (int)(byte)255, (int)(byte)255);
      circularGauge1.Marks.Brush.Solid = true;
      circularGauge1.Marks.Brush.Visible = true;
      // 
      // 
      // 
      circularGauge1.Marks.Font.Bold = false;
      // 
      // 
      // 
      circularGauge1.Marks.Font.Brush.Color = Color.Black;
      circularGauge1.Marks.Font.Brush.Solid = true;
      circularGauge1.Marks.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      circularGauge1.Marks.Font.Shadow.Brush.Color = Color.DarkGray;
      circularGauge1.Marks.Font.Shadow.Brush.Solid = true;
      circularGauge1.Marks.Font.Shadow.Brush.Visible = true;
      circularGauge1.Marks.Font.Size = 8;
      circularGauge1.Marks.Font.SizeFloat = 8F;
      circularGauge1.Marks.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      circularGauge1.Marks.ImageBevel.Brush.Color = Color.LightGray;
      circularGauge1.Marks.ImageBevel.Brush.Solid = true;
      circularGauge1.Marks.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      circularGauge1.Marks.Shadow.Brush.Color = Color.Gray;
      circularGauge1.Marks.Shadow.Brush.Solid = true;
      circularGauge1.Marks.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      circularGauge1.Marks.Symbol.Brush.Color = Color.White;
      circularGauge1.Marks.Symbol.Brush.Solid = true;
      circularGauge1.Marks.Symbol.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      circularGauge1.Marks.Symbol.ImageBevel.Brush.Color = Color.LightGray;
      circularGauge1.Marks.Symbol.ImageBevel.Brush.Solid = true;
      circularGauge1.Marks.Symbol.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      circularGauge1.Marks.Symbol.Shadow.Brush.Color = Color.DarkGray;
      circularGauge1.Marks.Symbol.Shadow.Brush.Solid = true;
      circularGauge1.Marks.Symbol.Shadow.Brush.Visible = true;
      circularGauge1.Maximum = 100D;
      circularGauge1.Minimum = 0D;
      // 
      // 
      // 
      // 
      // 
      // 
      circularGauge1.MinorTicks.Brush.Color = Color.Transparent;
      // 
      // 
      // 
      circularGauge1.MinorTicks.Brush.Gradient.Transparency = 100;
      circularGauge1.MinorTicks.Brush.Solid = true;
      circularGauge1.MinorTicks.Brush.Visible = true;
      circularGauge1.MinorTicks.HorizSize = 1;
      circularGauge1.MinorTicks.Position = 0;
      circularGauge1.MinorTicks.Spiralled = false;
      circularGauge1.MinorTicks.Style = (Steema.TeeChart.Styles.GaugePointerStyles)resources.GetObject("resource.Style1");
      circularGauge1.MinorTicks.VertSize = 1;
      circularGauge1.MinorTicks.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      circularGauge1.NumericGauge.Brush.Color = Color.Empty;
      circularGauge1.NumericGauge.Brush.Solid = true;
      circularGauge1.NumericGauge.Brush.Visible = true;
      circularGauge1.NumericGauge.Color = Color.Empty;
      circularGauge1.NumericGauge.ColorLineEndValues.Add(0D);
      circularGauge1.NumericGauge.ColorLineEndValues.Add(0D);
      circularGauge1.NumericGauge.ColorLineEndValues.Add(0D);
      circularGauge1.NumericGauge.ColorLineEndValues.Add(0D);
      circularGauge1.NumericGauge.ColorLineEndValues.Add(0D);
      circularGauge1.NumericGauge.ColorLineEndValues.Add(0D);
      circularGauge1.NumericGauge.ColorLineEndValues.Add(0D);
      circularGauge1.NumericGauge.ColorLineEndValues.Add(0D);
      circularGauge1.NumericGauge.ColorLineEndValues.Add(0D);
      circularGauge1.NumericGauge.ColorLineEndValues.Add(0D);
      circularGauge1.NumericGauge.ColorLineEndValues.Add(0D);
      circularGauge1.NumericGauge.ColorLineEndValues.Add(0D);
      circularGauge1.NumericGauge.ColorLineEndValues.Add(0D);
      circularGauge1.NumericGauge.ColorLineEndValues.Add(0D);
      circularGauge1.NumericGauge.ColorLineEndValues.Add(0D);
      circularGauge1.NumericGauge.ColorLineEndValues.Add(0D);
      circularGauge1.NumericGauge.ColorLineEndValues.Add(0D);
      circularGauge1.NumericGauge.ColorLineEndValues.Add(0D);
      circularGauge1.NumericGauge.ColorLineEndValues.Add(0D);
      circularGauge1.NumericGauge.ColorLineEndValues.Add(0D);
      circularGauge1.NumericGauge.ColorLineEndValues.Add(0D);
      circularGauge1.NumericGauge.ColorLineEndValues.Add(0D);
      circularGauge1.NumericGauge.ColorLineEndValues.Add(0D);
      circularGauge1.NumericGauge.ColorLineEndValues.Add(0D);
      circularGauge1.NumericGauge.ColorLineEndValues.Add(0D);
      circularGauge1.NumericGauge.ColorLineEndValues.Add(0D);
      circularGauge1.NumericGauge.ColorLineEndValues.Add(0D);
      circularGauge1.NumericGauge.ColorLineEndValues.Add(0D);
      circularGauge1.NumericGauge.ColorLineEndValues.Add(0D);
      circularGauge1.NumericGauge.ColorLineEndValues.Add(0D);
      circularGauge1.NumericGauge.ColorLineEndValues.Add(0D);
      circularGauge1.NumericGauge.ColorLineEndValues.Add(0D);
      circularGauge1.NumericGauge.ColorLineEndValues.Add(0D);
      circularGauge1.NumericGauge.ColorLineEndValues.Add(0D);
      circularGauge1.NumericGauge.ColorLineEndValues.Add(0D);
      circularGauge1.NumericGauge.ColorLineEndValues.Add(0D);
      circularGauge1.NumericGauge.ColorLineEndValues.Add(0D);
      circularGauge1.NumericGauge.ColorLineEndValues.Add(0D);
      circularGauge1.NumericGauge.ColorLineEndValues.Add(0D);
      circularGauge1.NumericGauge.ColorLineEndValues.Add(0D);
      circularGauge1.NumericGauge.ColorLineEndValues.Add(0D);
      circularGauge1.NumericGauge.ColorLineEndValues.Add(0D);
      circularGauge1.NumericGauge.ColorLineEndValues.Add(0D);
      circularGauge1.NumericGauge.ColorLineEndValues.Add(0D);
      circularGauge1.NumericGauge.ColorLineEndValues.Add(0D);
      circularGauge1.NumericGauge.ColorLineEndValues.Add(0D);
      circularGauge1.NumericGauge.ColorLineEndValues.Add(0D);
      circularGauge1.NumericGauge.ColorLineEndValues.Add(0D);
      circularGauge1.NumericGauge.ColorLineEndValues.Add(0D);
      circularGauge1.NumericGauge.ColorLineEndValues.Add(0D);
      circularGauge1.NumericGauge.ColorLineEndValues.Add(0D);
      circularGauge1.NumericGauge.ColorLineEndValues.Add(0D);
      circularGauge1.NumericGauge.ColorLineEndValues.Add(0D);
      circularGauge1.NumericGauge.ColorLineEndValues.Add(0D);
      circularGauge1.NumericGauge.ColorLineEndValues.Add(0D);
      circularGauge1.NumericGauge.ColorLineEndValues.Add(0D);
      circularGauge1.NumericGauge.ColorLineEndValues.Add(0D);
      circularGauge1.NumericGauge.ColorLineEndValues.Add(0D);
      circularGauge1.NumericGauge.ColorLineEndValues.Add(0D);
      circularGauge1.NumericGauge.ColorLineEndValues.Add(0D);
      circularGauge1.NumericGauge.ColorLineEndValues.Add(0D);
      circularGauge1.NumericGauge.ColorLineEndValues.Add(0D);
      circularGauge1.NumericGauge.ColorLineEndValues.Add(0D);
      circularGauge1.NumericGauge.ColorLineEndValues.Add(0D);
      circularGauge1.NumericGauge.ColorLineStartValues.Add(0D);
      circularGauge1.NumericGauge.ColorLineStartValues.Add(0D);
      circularGauge1.NumericGauge.ColorLineStartValues.Add(0D);
      circularGauge1.NumericGauge.ColorLineStartValues.Add(0D);
      circularGauge1.NumericGauge.ColorLineStartValues.Add(0D);
      circularGauge1.NumericGauge.ColorLineStartValues.Add(0D);
      circularGauge1.NumericGauge.ColorLineStartValues.Add(0D);
      circularGauge1.NumericGauge.ColorLineStartValues.Add(0D);
      circularGauge1.NumericGauge.ColorLineStartValues.Add(0D);
      circularGauge1.NumericGauge.ColorLineStartValues.Add(0D);
      circularGauge1.NumericGauge.ColorLineStartValues.Add(0D);
      circularGauge1.NumericGauge.ColorLineStartValues.Add(0D);
      circularGauge1.NumericGauge.ColorLineStartValues.Add(0D);
      circularGauge1.NumericGauge.ColorLineStartValues.Add(0D);
      circularGauge1.NumericGauge.ColorLineStartValues.Add(0D);
      circularGauge1.NumericGauge.ColorLineStartValues.Add(0D);
      circularGauge1.NumericGauge.ColorLineStartValues.Add(0D);
      circularGauge1.NumericGauge.ColorLineStartValues.Add(0D);
      circularGauge1.NumericGauge.ColorLineStartValues.Add(0D);
      circularGauge1.NumericGauge.ColorLineStartValues.Add(0D);
      circularGauge1.NumericGauge.ColorLineStartValues.Add(0D);
      circularGauge1.NumericGauge.ColorLineStartValues.Add(0D);
      circularGauge1.NumericGauge.ColorLineStartValues.Add(0D);
      circularGauge1.NumericGauge.ColorLineStartValues.Add(0D);
      circularGauge1.NumericGauge.ColorLineStartValues.Add(0D);
      circularGauge1.NumericGauge.ColorLineStartValues.Add(0D);
      circularGauge1.NumericGauge.ColorLineStartValues.Add(0D);
      circularGauge1.NumericGauge.ColorLineStartValues.Add(0D);
      circularGauge1.NumericGauge.ColorLineStartValues.Add(0D);
      circularGauge1.NumericGauge.ColorLineStartValues.Add(0D);
      circularGauge1.NumericGauge.ColorLineStartValues.Add(0D);
      circularGauge1.NumericGauge.ColorLineStartValues.Add(0D);
      circularGauge1.NumericGauge.ColorLineStartValues.Add(0D);
      circularGauge1.NumericGauge.ColorLineStartValues.Add(0D);
      circularGauge1.NumericGauge.ColorLineStartValues.Add(0D);
      circularGauge1.NumericGauge.ColorLineStartValues.Add(0D);
      circularGauge1.NumericGauge.ColorLineStartValues.Add(0D);
      circularGauge1.NumericGauge.ColorLineStartValues.Add(0D);
      circularGauge1.NumericGauge.ColorLineStartValues.Add(0D);
      circularGauge1.NumericGauge.ColorLineStartValues.Add(0D);
      circularGauge1.NumericGauge.ColorLineStartValues.Add(0D);
      circularGauge1.NumericGauge.ColorLineStartValues.Add(0D);
      circularGauge1.NumericGauge.ColorLineStartValues.Add(0D);
      circularGauge1.NumericGauge.ColorLineStartValues.Add(0D);
      circularGauge1.NumericGauge.ColorLineStartValues.Add(0D);
      circularGauge1.NumericGauge.ColorLineStartValues.Add(0D);
      circularGauge1.NumericGauge.ColorLineStartValues.Add(0D);
      circularGauge1.NumericGauge.ColorLineStartValues.Add(0D);
      circularGauge1.NumericGauge.ColorLineStartValues.Add(0D);
      circularGauge1.NumericGauge.ColorLineStartValues.Add(0D);
      circularGauge1.NumericGauge.ColorLineStartValues.Add(0D);
      circularGauge1.NumericGauge.ColorLineStartValues.Add(0D);
      circularGauge1.NumericGauge.ColorLineStartValues.Add(0D);
      circularGauge1.NumericGauge.ColorLineStartValues.Add(0D);
      circularGauge1.NumericGauge.ColorLineStartValues.Add(0D);
      circularGauge1.NumericGauge.ColorLineStartValues.Add(0D);
      circularGauge1.NumericGauge.ColorLineStartValues.Add(0D);
      circularGauge1.NumericGauge.ColorLineStartValues.Add(0D);
      circularGauge1.NumericGauge.ColorLineStartValues.Add(0D);
      circularGauge1.NumericGauge.ColorLineStartValues.Add(0D);
      circularGauge1.NumericGauge.ColorLineStartValues.Add(0D);
      circularGauge1.NumericGauge.ColorLineStartValues.Add(0D);
      circularGauge1.NumericGauge.ColorLineStartValues.Add(0D);
      circularGauge1.NumericGauge.ColorLineStartValues.Add(0D);
      circularGauge1.NumericGauge.CustomBounds = new Rectangle(78, 137, 38, 15);
      // 
      // 
      // 
      circularGauge1.NumericGauge.FaceBrush.Color = Color.FromArgb((int)(byte)170, (int)(byte)170, (int)(byte)130);
      // 
      // 
      // 
      // 
      // 
      // 
      circularGauge1.NumericGauge.FaceBrush.Gradient.Style.Direction = Steema.TeeChart.Drawing.PathGradientMode.Radial;
      circularGauge1.NumericGauge.FaceBrush.Gradient.Style.Visible = true;
      circularGauge1.NumericGauge.FaceBrush.Gradient.Visible = true;
      circularGauge1.NumericGauge.FaceBrush.Solid = true;
      circularGauge1.NumericGauge.FaceBrush.Visible = true;
      // 
      // 
      // 
      circularGauge1.NumericGauge.Frame.Circled = false;
      // 
      // 
      // 
      circularGauge1.NumericGauge.Frame.InnerBand.Color = Color.FromArgb((int)(byte)40, (int)(byte)40, (int)(byte)40);
      circularGauge1.NumericGauge.Frame.InnerBand.Solid = true;
      circularGauge1.NumericGauge.Frame.InnerBand.Visible = true;
      // 
      // 
      // 
      circularGauge1.NumericGauge.Frame.OuterBand.Color = Color.FromArgb((int)(byte)40, (int)(byte)40, (int)(byte)40);
      // 
      // 
      // 
      circularGauge1.NumericGauge.Frame.OuterBand.Gradient.UseMiddle = true;
      circularGauge1.NumericGauge.Frame.OuterBand.Gradient.Visible = true;
      circularGauge1.NumericGauge.Frame.OuterBand.Solid = true;
      circularGauge1.NumericGauge.Frame.OuterBand.Visible = true;
      circularGauge1.NumericGauge.GaugeColorPalette = new Color[]
  {
    Color.FromArgb((int)(byte)40, (int)(byte)40, (int)(byte)40),
    Color.FromArgb((int)(byte)50, (int)(byte)50, (int)(byte)50),
    Color.FromArgb((int)(byte)100, (int)(byte)100, (int)(byte)100),
    Color.FromArgb((int)(byte)170, (int)(byte)170, (int)(byte)130),
    Color.FromArgb((int)(byte)170, (int)(byte)170, (int)(byte)130),
    Color.FromArgb((int)(byte)170, (int)(byte)170, (int)(byte)130),
    Color.FromArgb((int)(byte)100, (int)(byte)40, (int)(byte)40),
    Color.Empty,
    Color.FromArgb((int)(byte)100, (int)(byte)100, (int)(byte)100),
    Color.FromArgb((int)(byte)100, (int)(byte)100, (int)(byte)100),
    Color.Empty,
    Color.FromArgb((int)(byte)30, (int)(byte)200, (int)(byte)30),
    Color.FromArgb((int)(byte)200, (int)(byte)115, (int)(byte)60),
    Color.FromArgb((int)(byte)200, (int)(byte)115, (int)(byte)60),
    Color.FromArgb((int)(byte)200, (int)(byte)115, (int)(byte)60),
    Color.FromArgb((int)(byte)150, (int)(byte)50, (int)(byte)10),
    Color.FromArgb((int)(byte)130, (int)(byte)130, (int)(byte)130),
    Color.FromArgb((int)(byte)130, (int)(byte)130, (int)(byte)130),
    Color.Empty,
    Color.FromArgb((int)(byte)30, (int)(byte)30, (int)(byte)30),
    Color.FromArgb((int)(byte)40, (int)(byte)40, (int)(byte)40),
    Color.FromArgb((int)(byte)100, (int)(byte)100, (int)(byte)100),
    Color.FromArgb((int)(byte)100, (int)(byte)100, (int)(byte)100),
    Color.FromArgb((int)(byte)100, (int)(byte)100, (int)(byte)100)
  };
      // 
      // 
      // 
      // 
      // 
      // 
      circularGauge1.NumericGauge.GreenLine.Brush.Color = Color.Black;
      // 
      // 
      // 
      circularGauge1.NumericGauge.GreenLine.Brush.Gradient.Sigma = true;
      circularGauge1.NumericGauge.GreenLine.Brush.Gradient.SigmaFocus = 0F;
      circularGauge1.NumericGauge.GreenLine.Brush.Gradient.UseMiddle = false;
      circularGauge1.NumericGauge.GreenLine.Brush.Solid = true;
      circularGauge1.NumericGauge.GreenLine.Brush.Visible = true;
      circularGauge1.NumericGauge.GreenLine.Position = 0;
      circularGauge1.NumericGauge.GreenLine.Spiralled = false;
      circularGauge1.NumericGauge.GreenLine.Style = (Steema.TeeChart.Styles.GaugePointerStyles)resources.GetObject("resource.Style2");
      circularGauge1.NumericGauge.GreenLine.VertSize = 5;
      circularGauge1.NumericGauge.GreenLine.Visible = true;
      circularGauge1.NumericGauge.GreenLineEndValue = 0D;
      circularGauge1.NumericGauge.GreenLineStartValue = 0D;
      // 
      // 
      // 
      // 
      // 
      // 
      circularGauge1.NumericGauge.Hand.Brush.Color = Color.FromArgb((int)(byte)255, (int)(byte)0, (int)(byte)0);
      circularGauge1.NumericGauge.Hand.Brush.Solid = true;
      circularGauge1.NumericGauge.Hand.Brush.Visible = true;
      circularGauge1.NumericGauge.Hand.Position = 0;
      circularGauge1.NumericGauge.Hand.Spiralled = false;
      circularGauge1.NumericGauge.Hand.Style = (Steema.TeeChart.Styles.GaugePointerStyles)resources.GetObject("resource.Style3");
      circularGauge1.NumericGauge.Hand.Visible = true;
      circularGauge1.NumericGauge.HorizAxis = Steema.TeeChart.Styles.HorizontalAxis.Custom;
      // 
      // 
      // 
      // 
      // 
      // 
      circularGauge1.NumericGauge.Legend.Brush.Color = Color.White;
      circularGauge1.NumericGauge.Legend.Brush.Solid = true;
      circularGauge1.NumericGauge.Legend.Brush.Visible = true;
      // 
      // 
      // 
      circularGauge1.NumericGauge.Legend.Font.Bold = false;
      // 
      // 
      // 
      circularGauge1.NumericGauge.Legend.Font.Brush.Color = Color.Black;
      circularGauge1.NumericGauge.Legend.Font.Brush.Solid = true;
      circularGauge1.NumericGauge.Legend.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      circularGauge1.NumericGauge.Legend.Font.Shadow.Brush.Color = Color.DarkGray;
      circularGauge1.NumericGauge.Legend.Font.Shadow.Brush.Solid = true;
      circularGauge1.NumericGauge.Legend.Font.Shadow.Brush.Visible = true;
      circularGauge1.NumericGauge.Legend.Font.Size = 8;
      circularGauge1.NumericGauge.Legend.Font.SizeFloat = 8F;
      circularGauge1.NumericGauge.Legend.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      circularGauge1.NumericGauge.Legend.ImageBevel.Brush.Color = Color.LightGray;
      circularGauge1.NumericGauge.Legend.ImageBevel.Brush.Solid = true;
      circularGauge1.NumericGauge.Legend.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      circularGauge1.NumericGauge.Legend.Shadow.Brush.Color = Color.DarkGray;
      circularGauge1.NumericGauge.Legend.Shadow.Brush.Solid = true;
      circularGauge1.NumericGauge.Legend.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      circularGauge1.NumericGauge.Marks.Brush.Color = Color.FromArgb((int)(byte)255, (int)(byte)255, (int)(byte)255);
      circularGauge1.NumericGauge.Marks.Brush.Solid = true;
      circularGauge1.NumericGauge.Marks.Brush.Visible = true;
      // 
      // 
      // 
      circularGauge1.NumericGauge.Marks.Font.Bold = false;
      // 
      // 
      // 
      circularGauge1.NumericGauge.Marks.Font.Brush.Color = Color.FromArgb((int)(byte)0, (int)(byte)0, (int)(byte)0);
      circularGauge1.NumericGauge.Marks.Font.Brush.Solid = true;
      circularGauge1.NumericGauge.Marks.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      circularGauge1.NumericGauge.Marks.Font.Shadow.Brush.Color = Color.DarkGray;
      circularGauge1.NumericGauge.Marks.Font.Shadow.Brush.Solid = true;
      circularGauge1.NumericGauge.Marks.Font.Shadow.Brush.Visible = true;
      circularGauge1.NumericGauge.Marks.Font.Size = 8;
      circularGauge1.NumericGauge.Marks.Font.SizeFloat = 8F;
      circularGauge1.NumericGauge.Marks.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      circularGauge1.NumericGauge.Marks.ImageBevel.Brush.Color = Color.LightGray;
      circularGauge1.NumericGauge.Marks.ImageBevel.Brush.Solid = true;
      circularGauge1.NumericGauge.Marks.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      circularGauge1.NumericGauge.Marks.Shadow.Brush.Color = Color.FromArgb((int)(byte)128, (int)(byte)128, (int)(byte)128);
      circularGauge1.NumericGauge.Marks.Shadow.Brush.Solid = true;
      circularGauge1.NumericGauge.Marks.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      circularGauge1.NumericGauge.Marks.Symbol.Brush.Color = Color.White;
      circularGauge1.NumericGauge.Marks.Symbol.Brush.Solid = true;
      circularGauge1.NumericGauge.Marks.Symbol.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      circularGauge1.NumericGauge.Marks.Symbol.ImageBevel.Brush.Color = Color.LightGray;
      circularGauge1.NumericGauge.Marks.Symbol.ImageBevel.Brush.Solid = true;
      circularGauge1.NumericGauge.Marks.Symbol.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      circularGauge1.NumericGauge.Marks.Symbol.Shadow.Brush.Color = Color.DarkGray;
      circularGauge1.NumericGauge.Marks.Symbol.Shadow.Brush.Solid = true;
      circularGauge1.NumericGauge.Marks.Symbol.Shadow.Brush.Visible = true;
      circularGauge1.NumericGauge.Maximum = global::System.Double.PositiveInfinity;
      circularGauge1.NumericGauge.Minimum = 0D;
      // 
      // 
      // 
      // 
      // 
      // 
      circularGauge1.NumericGauge.MinorTicks.Brush.Color = Color.Transparent;
      circularGauge1.NumericGauge.MinorTicks.Brush.Solid = true;
      circularGauge1.NumericGauge.MinorTicks.Brush.Visible = true;
      circularGauge1.NumericGauge.MinorTicks.HorizSize = 1;
      circularGauge1.NumericGauge.MinorTicks.Position = 0;
      circularGauge1.NumericGauge.MinorTicks.Spiralled = false;
      circularGauge1.NumericGauge.MinorTicks.Style = (Steema.TeeChart.Styles.GaugePointerStyles)resources.GetObject("resource.Style4");
      circularGauge1.NumericGauge.MinorTicks.VertSize = 1;
      circularGauge1.NumericGauge.MinorTicks.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      circularGauge1.NumericGauge.RedLine.Brush.Color = Color.Black;
      // 
      // 
      // 
      circularGauge1.NumericGauge.RedLine.Brush.Gradient.Sigma = true;
      circularGauge1.NumericGauge.RedLine.Brush.Gradient.SigmaFocus = 0F;
      circularGauge1.NumericGauge.RedLine.Brush.Solid = true;
      circularGauge1.NumericGauge.RedLine.Brush.Visible = true;
      circularGauge1.NumericGauge.RedLine.Position = 0;
      circularGauge1.NumericGauge.RedLine.Spiralled = false;
      circularGauge1.NumericGauge.RedLine.Style = (Steema.TeeChart.Styles.GaugePointerStyles)resources.GetObject("resource.Style5");
      circularGauge1.NumericGauge.RedLine.VertSize = 5;
      circularGauge1.NumericGauge.RedLine.Visible = true;
      circularGauge1.NumericGauge.RedLineEndValue = 0D;
      circularGauge1.NumericGauge.RedLineStartValue = 0D;
      // 
      // 
      // 
      circularGauge1.NumericGauge.TextMarker.Active = false;
      circularGauge1.NumericGauge.TextMarker.AutoSize = true;
      // 
      // 
      // 
      circularGauge1.NumericGauge.TextMarker.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
      circularGauge1.NumericGauge.TextMarker.Callout.ArrowHeadDirection = Steema.TeeChart.Styles.ArrowHeadDirection.FromPoint;
      circularGauge1.NumericGauge.TextMarker.Callout.ArrowHeadSize = 8;
      // 
      // 
      // 
      circularGauge1.NumericGauge.TextMarker.Callout.Brush.Color = Color.Black;
      circularGauge1.NumericGauge.TextMarker.Callout.Brush.Solid = true;
      circularGauge1.NumericGauge.TextMarker.Callout.Brush.Visible = true;
      circularGauge1.NumericGauge.TextMarker.Callout.Distance = 0;
      circularGauge1.NumericGauge.TextMarker.Callout.Draw3D = false;
      circularGauge1.NumericGauge.TextMarker.Callout.XPosition = 0;
      circularGauge1.NumericGauge.TextMarker.Callout.YPosition = 0;
      circularGauge1.NumericGauge.TextMarker.Callout.ZPosition = 0;
      circularGauge1.NumericGauge.TextMarker.Centered = false;
      circularGauge1.NumericGauge.TextMarker.Cursor = cursor1;
      // 
      // 
      // 
      // 
      // 
      // 
      circularGauge1.NumericGauge.TextMarker.Shape.Brush.Color = Color.FromArgb((int)(byte)40, (int)(byte)40, (int)(byte)40);
      circularGauge1.NumericGauge.TextMarker.Shape.Brush.Solid = true;
      circularGauge1.NumericGauge.TextMarker.Shape.Brush.Visible = true;
      // 
      // 
      // 
      circularGauge1.NumericGauge.TextMarker.Shape.Font.Bold = false;
      // 
      // 
      // 
      circularGauge1.NumericGauge.TextMarker.Shape.Font.Brush.Color = Color.FromArgb((int)(byte)170, (int)(byte)170, (int)(byte)130);
      circularGauge1.NumericGauge.TextMarker.Shape.Font.Brush.Solid = true;
      circularGauge1.NumericGauge.TextMarker.Shape.Font.Brush.Visible = true;
      circularGauge1.NumericGauge.TextMarker.Shape.Font.Name = "DS-Digital";
      // 
      // 
      // 
      // 
      // 
      // 
      circularGauge1.NumericGauge.TextMarker.Shape.Font.Shadow.Brush.Color = Color.DarkGray;
      circularGauge1.NumericGauge.TextMarker.Shape.Font.Shadow.Brush.Solid = true;
      circularGauge1.NumericGauge.TextMarker.Shape.Font.Shadow.Brush.Visible = true;
      circularGauge1.NumericGauge.TextMarker.Shape.Font.Size = 11;
      circularGauge1.NumericGauge.TextMarker.Shape.Font.SizeFloat = 11F;
      circularGauge1.NumericGauge.TextMarker.Shape.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      circularGauge1.NumericGauge.TextMarker.Shape.Font.UsePrivateFont = true;
      // 
      // 
      // 
      // 
      // 
      // 
      circularGauge1.NumericGauge.TextMarker.Shape.ImageBevel.Brush.Color = Color.LightGray;
      circularGauge1.NumericGauge.TextMarker.Shape.ImageBevel.Brush.Solid = true;
      circularGauge1.NumericGauge.TextMarker.Shape.ImageBevel.Brush.Visible = true;
      circularGauge1.NumericGauge.TextMarker.Shape.Lines = new string[]
  {
    "FREQ"
  };
      // 
      // 
      // 
      circularGauge1.NumericGauge.TextMarker.Shape.Pen.Visible = false;
      // 
      // 
      // 
      // 
      // 
      // 
      circularGauge1.NumericGauge.TextMarker.Shape.Shadow.Brush.Color = Color.FromArgb((int)(byte)169, (int)(byte)169, (int)(byte)169);
      circularGauge1.NumericGauge.TextMarker.Shape.Shadow.Brush.Solid = true;
      circularGauge1.NumericGauge.TextMarker.Shape.Shadow.Brush.Visible = true;
      circularGauge1.NumericGauge.TextMarker.Shape.Shadow.Visible = false;
      circularGauge1.NumericGauge.TextMarker.Text = "FREQ";
      circularGauge1.NumericGauge.TextMarker.TextAlign = Steema.TeeChart.Drawing.StringAlignment.Center;
      circularGauge1.NumericGauge.TextMarker.UsePalette = true;
      // 
      // 
      // 
      // 
      // 
      // 
      circularGauge1.NumericGauge.Ticks.Brush.Color = Color.FromArgb((int)(byte)255, (int)(byte)255, (int)(byte)255);
      circularGauge1.NumericGauge.Ticks.Brush.Solid = true;
      circularGauge1.NumericGauge.Ticks.Brush.Visible = true;
      circularGauge1.NumericGauge.Ticks.Position = 0;
      circularGauge1.NumericGauge.Ticks.Spiralled = false;
      circularGauge1.NumericGauge.Ticks.Style = (Steema.TeeChart.Styles.GaugePointerStyles)resources.GetObject("resource.Style6");
      circularGauge1.NumericGauge.Ticks.VertSize = 20;
      circularGauge1.NumericGauge.Ticks.Visible = true;
      // 
      // 
      // 
      circularGauge1.NumericGauge.UnitsMarker.Active = false;
      circularGauge1.NumericGauge.UnitsMarker.AutoSize = true;
      // 
      // 
      // 
      circularGauge1.NumericGauge.UnitsMarker.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
      circularGauge1.NumericGauge.UnitsMarker.Callout.ArrowHeadDirection = Steema.TeeChart.Styles.ArrowHeadDirection.FromPoint;
      circularGauge1.NumericGauge.UnitsMarker.Callout.ArrowHeadSize = 8;
      // 
      // 
      // 
      circularGauge1.NumericGauge.UnitsMarker.Callout.Brush.Color = Color.Black;
      circularGauge1.NumericGauge.UnitsMarker.Callout.Brush.Solid = true;
      circularGauge1.NumericGauge.UnitsMarker.Callout.Brush.Visible = true;
      circularGauge1.NumericGauge.UnitsMarker.Callout.Distance = 0;
      circularGauge1.NumericGauge.UnitsMarker.Callout.Draw3D = false;
      circularGauge1.NumericGauge.UnitsMarker.Callout.XPosition = 0;
      circularGauge1.NumericGauge.UnitsMarker.Callout.YPosition = 0;
      circularGauge1.NumericGauge.UnitsMarker.Callout.ZPosition = 0;
      circularGauge1.NumericGauge.UnitsMarker.Centered = false;
      circularGauge1.NumericGauge.UnitsMarker.Cursor = cursor1;
      circularGauge1.NumericGauge.UnitsMarker.Position = Steema.TeeChart.Tools.AnnotationPositions.LeftBottom;
      // 
      // 
      // 
      // 
      // 
      // 
      circularGauge1.NumericGauge.UnitsMarker.Shape.Brush.Color = Color.FromArgb((int)(byte)170, (int)(byte)170, (int)(byte)130);
      circularGauge1.NumericGauge.UnitsMarker.Shape.Brush.Solid = true;
      circularGauge1.NumericGauge.UnitsMarker.Shape.Brush.Visible = true;
      // 
      // 
      // 
      circularGauge1.NumericGauge.UnitsMarker.Shape.Font.Bold = false;
      // 
      // 
      // 
      circularGauge1.NumericGauge.UnitsMarker.Shape.Font.Brush.Color = Color.FromArgb((int)(byte)40, (int)(byte)40, (int)(byte)40);
      circularGauge1.NumericGauge.UnitsMarker.Shape.Font.Brush.Solid = true;
      circularGauge1.NumericGauge.UnitsMarker.Shape.Font.Brush.Visible = true;
      circularGauge1.NumericGauge.UnitsMarker.Shape.Font.Name = "DS-Digital";
      // 
      // 
      // 
      // 
      // 
      // 
      circularGauge1.NumericGauge.UnitsMarker.Shape.Font.Shadow.Brush.Color = Color.DarkGray;
      circularGauge1.NumericGauge.UnitsMarker.Shape.Font.Shadow.Brush.Solid = true;
      circularGauge1.NumericGauge.UnitsMarker.Shape.Font.Shadow.Brush.Visible = true;
      circularGauge1.NumericGauge.UnitsMarker.Shape.Font.Size = 18;
      circularGauge1.NumericGauge.UnitsMarker.Shape.Font.SizeFloat = 18F;
      circularGauge1.NumericGauge.UnitsMarker.Shape.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      circularGauge1.NumericGauge.UnitsMarker.Shape.Font.UsePrivateFont = true;
      // 
      // 
      // 
      // 
      // 
      // 
      circularGauge1.NumericGauge.UnitsMarker.Shape.ImageBevel.Brush.Color = Color.LightGray;
      circularGauge1.NumericGauge.UnitsMarker.Shape.ImageBevel.Brush.Solid = true;
      circularGauge1.NumericGauge.UnitsMarker.Shape.ImageBevel.Brush.Visible = true;
      circularGauge1.NumericGauge.UnitsMarker.Shape.Lines = new string[]
  {
    "MHz"
  };
      // 
      // 
      // 
      circularGauge1.NumericGauge.UnitsMarker.Shape.Pen.Visible = false;
      // 
      // 
      // 
      // 
      // 
      // 
      circularGauge1.NumericGauge.UnitsMarker.Shape.Shadow.Brush.Color = Color.FromArgb((int)(byte)169, (int)(byte)169, (int)(byte)169);
      circularGauge1.NumericGauge.UnitsMarker.Shape.Shadow.Brush.Solid = true;
      circularGauge1.NumericGauge.UnitsMarker.Shape.Shadow.Brush.Visible = true;
      circularGauge1.NumericGauge.UnitsMarker.Shape.Shadow.Visible = false;
      circularGauge1.NumericGauge.UnitsMarker.Text = "MHz";
      circularGauge1.NumericGauge.UnitsMarker.TextAlign = Steema.TeeChart.Drawing.StringAlignment.Center;
      circularGauge1.NumericGauge.UnitsMarker.UsePalette = true;
      circularGauge1.NumericGauge.Value = 24.5123920145037D;
      circularGauge1.NumericGauge.ValueFormat = "N";
      // 
      // 
      // 
      circularGauge1.NumericGauge.ValueMarker.Active = false;
      circularGauge1.NumericGauge.ValueMarker.AutoSize = false;
      // 
      // 
      // 
      circularGauge1.NumericGauge.ValueMarker.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
      circularGauge1.NumericGauge.ValueMarker.Callout.ArrowHeadDirection = Steema.TeeChart.Styles.ArrowHeadDirection.FromPoint;
      circularGauge1.NumericGauge.ValueMarker.Callout.ArrowHeadSize = 8;
      // 
      // 
      // 
      circularGauge1.NumericGauge.ValueMarker.Callout.Brush.Color = Color.Black;
      circularGauge1.NumericGauge.ValueMarker.Callout.Brush.Solid = true;
      circularGauge1.NumericGauge.ValueMarker.Callout.Brush.Visible = true;
      circularGauge1.NumericGauge.ValueMarker.Callout.Distance = 0;
      circularGauge1.NumericGauge.ValueMarker.Callout.Draw3D = false;
      circularGauge1.NumericGauge.ValueMarker.Callout.XPosition = 0;
      circularGauge1.NumericGauge.ValueMarker.Callout.YPosition = 0;
      circularGauge1.NumericGauge.ValueMarker.Callout.ZPosition = 0;
      circularGauge1.NumericGauge.ValueMarker.Centered = true;
      circularGauge1.NumericGauge.ValueMarker.Cursor = cursor1;
      circularGauge1.NumericGauge.ValueMarker.Height = 18;
      circularGauge1.NumericGauge.ValueMarker.Left = 82;
      circularGauge1.NumericGauge.ValueMarker.Position = Steema.TeeChart.Tools.AnnotationPositions.Custom;
      // 
      // 
      // 
      circularGauge1.NumericGauge.ValueMarker.Shape.Bottom = 152;
      // 
      // 
      // 
      circularGauge1.NumericGauge.ValueMarker.Shape.Brush.Color = Color.FromArgb((int)(byte)170, (int)(byte)170, (int)(byte)130);
      circularGauge1.NumericGauge.ValueMarker.Shape.Brush.Solid = true;
      circularGauge1.NumericGauge.ValueMarker.Shape.Brush.Visible = true;
      circularGauge1.NumericGauge.ValueMarker.Shape.CustomPosition = true;
      // 
      // 
      // 
      circularGauge1.NumericGauge.ValueMarker.Shape.Font.Bold = true;
      // 
      // 
      // 
      circularGauge1.NumericGauge.ValueMarker.Shape.Font.Brush.Color = Color.FromArgb((int)(byte)255, (int)(byte)255, (int)(byte)255);
      circularGauge1.NumericGauge.ValueMarker.Shape.Font.Brush.Solid = true;
      circularGauge1.NumericGauge.ValueMarker.Shape.Font.Brush.Visible = true;
      circularGauge1.NumericGauge.ValueMarker.Shape.Font.Name = "DS-Digital";
      // 
      // 
      // 
      // 
      // 
      // 
      circularGauge1.NumericGauge.ValueMarker.Shape.Font.Shadow.Brush.Color = Color.DarkGray;
      circularGauge1.NumericGauge.ValueMarker.Shape.Font.Shadow.Brush.Solid = true;
      circularGauge1.NumericGauge.ValueMarker.Shape.Font.Shadow.Brush.Visible = true;
      circularGauge1.NumericGauge.ValueMarker.Shape.Font.Size = 12;
      circularGauge1.NumericGauge.ValueMarker.Shape.Font.SizeFloat = 12F;
      circularGauge1.NumericGauge.ValueMarker.Shape.Font.Style = Steema.TeeChart.Drawing.FontStyle.Bold;
      circularGauge1.NumericGauge.ValueMarker.Shape.Font.UsePrivateFont = true;
      // 
      // 
      // 
      // 
      // 
      // 
      circularGauge1.NumericGauge.ValueMarker.Shape.ImageBevel.Brush.Color = Color.LightGray;
      circularGauge1.NumericGauge.ValueMarker.Shape.ImageBevel.Brush.Solid = true;
      circularGauge1.NumericGauge.ValueMarker.Shape.ImageBevel.Brush.Visible = true;
      circularGauge1.NumericGauge.ValueMarker.Shape.Left = 82;
      circularGauge1.NumericGauge.ValueMarker.Shape.Lines = new string[]
  {
    "24.51"
  };
      // 
      // 
      // 
      circularGauge1.NumericGauge.ValueMarker.Shape.Pen.Visible = false;
      circularGauge1.NumericGauge.ValueMarker.Shape.Right = 112;
      // 
      // 
      // 
      // 
      // 
      // 
      circularGauge1.NumericGauge.ValueMarker.Shape.Shadow.Brush.Color = Color.FromArgb((int)(byte)169, (int)(byte)169, (int)(byte)169);
      circularGauge1.NumericGauge.ValueMarker.Shape.Shadow.Brush.Solid = true;
      circularGauge1.NumericGauge.ValueMarker.Shape.Shadow.Brush.Visible = true;
      circularGauge1.NumericGauge.ValueMarker.Shape.Shadow.Visible = false;
      circularGauge1.NumericGauge.ValueMarker.Shape.Top = 134;
      circularGauge1.NumericGauge.ValueMarker.Text = "24.51";
      circularGauge1.NumericGauge.ValueMarker.TextAlign = Steema.TeeChart.Drawing.StringAlignment.Far;
      circularGauge1.NumericGauge.ValueMarker.Top = 134;
      circularGauge1.NumericGauge.ValueMarker.UsePalette = false;
      circularGauge1.NumericGauge.ValueMarker.Width = 30;
      circularGauge1.NumericGauge.VertAxis = Steema.TeeChart.Styles.VerticalAxis.Custom;
      // 
      // 
      // 
      circularGauge1.NumericGauge.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
      circularGauge1.NumericGauge.XValues.Value = new double[]
  {
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
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
      circularGauge1.NumericGauge.YValues.Value = new double[]
  {
    24.5123920145037D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
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
      // 
      // 
      // 
      circularGauge1.Ticks.Brush.Color = Color.Transparent;
      // 
      // 
      // 
      circularGauge1.Ticks.Brush.Gradient.Transparency = 100;
      circularGauge1.Ticks.Brush.Solid = true;
      circularGauge1.Ticks.Brush.Visible = true;
      circularGauge1.Ticks.Position = 0;
      circularGauge1.Ticks.Spiralled = false;
      circularGauge1.Ticks.Style = (Steema.TeeChart.Styles.GaugePointerStyles)resources.GetObject("resource.Style7");
      circularGauge1.Ticks.VertSize = 12;
      circularGauge1.Ticks.Visible = true;
      circularGauge1.Title = "circularGauge1";
      circularGauge1.TotalAngle = 300D;
      circularGauge1.UniqueCustomRadius = true;
      circularGauge1.Value = 73.001821030836311D;
      // 
      // 
      // 
      circularGauge1.XValues.DataMember = "Angle";
      circularGauge1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
      circularGauge1.XValues.Value = new double[]
  {
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
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
      circularGauge1.YValues.DataMember = "Y";
      circularGauge1.YValues.Value = new double[]
  {
    73.001821030836311D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
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
      // panel2
      // 
      panel2.Controls.Add(panel8);
      panel2.Controls.Add(panel7);
      panel2.Dock = DockStyle.Left;
      panel2.Location = new Point(0, 36);
      panel2.Name = "panel2";
      panel2.Size = new Size(705, 936);
      panel2.TabIndex = 1;
      // 
      // panel8
      // 
      panel8.Controls.Add(tChart8);
      panel8.Dock = DockStyle.Fill;
      panel8.Location = new Point(0, 365);
      panel8.Name = "panel8";
      panel8.Size = new Size(705, 571);
      panel8.TabIndex = 1;
      // 
      // panel7
      // 
      panel7.Controls.Add(tChart7);
      panel7.Dock = DockStyle.Top;
      panel7.Location = new Point(0, 0);
      panel7.Name = "panel7";
      panel7.Size = new Size(705, 365);
      panel7.TabIndex = 0;
      // 
      // panel3
      // 
      panel3.Controls.Add(panel6);
      panel3.Controls.Add(panel5);
      panel3.Controls.Add(panel4);
      panel3.Dock = DockStyle.Fill;
      panel3.Location = new Point(705, 36);
      panel3.Name = "panel3";
      panel3.Size = new Size(672, 936);
      panel3.TabIndex = 2;
      // 
      // panel6
      // 
      panel6.Controls.Add(tChart6);
      panel6.Dock = DockStyle.Fill;
      panel6.Location = new Point(0, 365);
      panel6.Name = "panel6";
      panel6.Size = new Size(477, 571);
      panel6.TabIndex = 2;
      // 
      // panel5
      // 
      panel5.Controls.Add(tChart5);
      panel5.Dock = DockStyle.Top;
      panel5.Location = new Point(0, 0);
      panel5.Name = "panel5";
      panel5.Size = new Size(477, 365);
      panel5.TabIndex = 1;
      // 
      // panel4
      // 
      panel4.Controls.Add(tChart9);
      panel4.Controls.Add(tChart4);
      panel4.Controls.Add(tChart3);
      panel4.Controls.Add(tChart2);
      panel4.Controls.Add(tChart1);
      panel4.Dock = DockStyle.Right;
      panel4.Location = new Point(477, 0);
      panel4.Name = "panel4";
      panel4.Size = new Size(195, 936);
      panel4.TabIndex = 0;
      // 
      // tChart9
      // 
      // 
      // 
      // 
      tChart9.Aspect.ColorPaletteIndex = -1;
      tChart9.Aspect.Elevation = 315;
      tChart9.Aspect.ElevationFloat = 315D;
      tChart9.Aspect.Orthogonal = false;
      tChart9.Aspect.Perspective = 0;
      tChart9.Aspect.Rotation = 360;
      tChart9.Aspect.RotationFloat = 360D;
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
      tChart9.Axes.Bottom.Labels.Brush.Color = Color.White;
      tChart9.Axes.Bottom.Labels.Brush.Solid = true;
      tChart9.Axes.Bottom.Labels.Brush.Visible = true;
      // 
      // 
      // 
      tChart9.Axes.Bottom.Labels.Font.Bold = false;
      // 
      // 
      // 
      tChart9.Axes.Bottom.Labels.Font.Brush.Color = Color.FromArgb((int)(byte)255, (int)(byte)255, (int)(byte)255);
      tChart9.Axes.Bottom.Labels.Font.Brush.Solid = true;
      tChart9.Axes.Bottom.Labels.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart9.Axes.Bottom.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart9.Axes.Bottom.Labels.Font.Shadow.Brush.Solid = true;
      tChart9.Axes.Bottom.Labels.Font.Shadow.Brush.Visible = true;
      tChart9.Axes.Bottom.Labels.Font.Size = 8;
      tChart9.Axes.Bottom.Labels.Font.SizeFloat = 8F;
      tChart9.Axes.Bottom.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart9.Axes.Bottom.Labels.ImageBevel.Brush.Color = Color.LightGray;
      tChart9.Axes.Bottom.Labels.ImageBevel.Brush.Solid = true;
      tChart9.Axes.Bottom.Labels.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart9.Axes.Bottom.Labels.Shadow.Brush.Color = Color.DarkGray;
      tChart9.Axes.Bottom.Labels.Shadow.Brush.Solid = true;
      tChart9.Axes.Bottom.Labels.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart9.Axes.Bottom.Title.Brush.Color = Color.Silver;
      tChart9.Axes.Bottom.Title.Brush.Solid = true;
      tChart9.Axes.Bottom.Title.Brush.Visible = true;
      // 
      // 
      // 
      tChart9.Axes.Bottom.Title.Font.Bold = false;
      // 
      // 
      // 
      tChart9.Axes.Bottom.Title.Font.Brush.Color = Color.FromArgb((int)(byte)0, (int)(byte)0, (int)(byte)0);
      tChart9.Axes.Bottom.Title.Font.Brush.Solid = true;
      tChart9.Axes.Bottom.Title.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart9.Axes.Bottom.Title.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart9.Axes.Bottom.Title.Font.Shadow.Brush.Solid = true;
      tChart9.Axes.Bottom.Title.Font.Shadow.Brush.Visible = true;
      tChart9.Axes.Bottom.Title.Font.Size = 8;
      tChart9.Axes.Bottom.Title.Font.SizeFloat = 8F;
      tChart9.Axes.Bottom.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart9.Axes.Bottom.Title.ImageBevel.Brush.Color = Color.LightGray;
      tChart9.Axes.Bottom.Title.ImageBevel.Brush.Solid = true;
      tChart9.Axes.Bottom.Title.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart9.Axes.Bottom.Title.Shadow.Brush.Color = Color.DarkGray;
      tChart9.Axes.Bottom.Title.Shadow.Brush.Solid = true;
      tChart9.Axes.Bottom.Title.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      tChart9.Axes.Depth.Labels.Brush.Color = Color.White;
      tChart9.Axes.Depth.Labels.Brush.Solid = true;
      tChart9.Axes.Depth.Labels.Brush.Visible = true;
      // 
      // 
      // 
      tChart9.Axes.Depth.Labels.Font.Bold = false;
      // 
      // 
      // 
      tChart9.Axes.Depth.Labels.Font.Brush.Color = Color.FromArgb((int)(byte)255, (int)(byte)255, (int)(byte)255);
      tChart9.Axes.Depth.Labels.Font.Brush.Solid = true;
      tChart9.Axes.Depth.Labels.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart9.Axes.Depth.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart9.Axes.Depth.Labels.Font.Shadow.Brush.Solid = true;
      tChart9.Axes.Depth.Labels.Font.Shadow.Brush.Visible = true;
      tChart9.Axes.Depth.Labels.Font.Size = 8;
      tChart9.Axes.Depth.Labels.Font.SizeFloat = 8F;
      tChart9.Axes.Depth.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart9.Axes.Depth.Labels.ImageBevel.Brush.Color = Color.LightGray;
      tChart9.Axes.Depth.Labels.ImageBevel.Brush.Solid = true;
      tChart9.Axes.Depth.Labels.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart9.Axes.Depth.Labels.Shadow.Brush.Color = Color.DarkGray;
      tChart9.Axes.Depth.Labels.Shadow.Brush.Solid = true;
      tChart9.Axes.Depth.Labels.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart9.Axes.Depth.Title.Brush.Color = Color.Silver;
      tChart9.Axes.Depth.Title.Brush.Solid = true;
      tChart9.Axes.Depth.Title.Brush.Visible = true;
      // 
      // 
      // 
      tChart9.Axes.Depth.Title.Font.Bold = false;
      // 
      // 
      // 
      tChart9.Axes.Depth.Title.Font.Brush.Color = Color.FromArgb((int)(byte)0, (int)(byte)0, (int)(byte)0);
      tChart9.Axes.Depth.Title.Font.Brush.Solid = true;
      tChart9.Axes.Depth.Title.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart9.Axes.Depth.Title.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart9.Axes.Depth.Title.Font.Shadow.Brush.Solid = true;
      tChart9.Axes.Depth.Title.Font.Shadow.Brush.Visible = true;
      tChart9.Axes.Depth.Title.Font.Size = 8;
      tChart9.Axes.Depth.Title.Font.SizeFloat = 8F;
      tChart9.Axes.Depth.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart9.Axes.Depth.Title.ImageBevel.Brush.Color = Color.LightGray;
      tChart9.Axes.Depth.Title.ImageBevel.Brush.Solid = true;
      tChart9.Axes.Depth.Title.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart9.Axes.Depth.Title.Shadow.Brush.Color = Color.DarkGray;
      tChart9.Axes.Depth.Title.Shadow.Brush.Solid = true;
      tChart9.Axes.Depth.Title.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      tChart9.Axes.DepthTop.Labels.Brush.Color = Color.White;
      tChart9.Axes.DepthTop.Labels.Brush.Solid = true;
      tChart9.Axes.DepthTop.Labels.Brush.Visible = true;
      // 
      // 
      // 
      tChart9.Axes.DepthTop.Labels.Font.Bold = false;
      // 
      // 
      // 
      tChart9.Axes.DepthTop.Labels.Font.Brush.Color = Color.FromArgb((int)(byte)255, (int)(byte)255, (int)(byte)255);
      tChart9.Axes.DepthTop.Labels.Font.Brush.Solid = true;
      tChart9.Axes.DepthTop.Labels.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart9.Axes.DepthTop.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart9.Axes.DepthTop.Labels.Font.Shadow.Brush.Solid = true;
      tChart9.Axes.DepthTop.Labels.Font.Shadow.Brush.Visible = true;
      tChart9.Axes.DepthTop.Labels.Font.Size = 8;
      tChart9.Axes.DepthTop.Labels.Font.SizeFloat = 8F;
      tChart9.Axes.DepthTop.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart9.Axes.DepthTop.Labels.ImageBevel.Brush.Color = Color.LightGray;
      tChart9.Axes.DepthTop.Labels.ImageBevel.Brush.Solid = true;
      tChart9.Axes.DepthTop.Labels.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart9.Axes.DepthTop.Labels.Shadow.Brush.Color = Color.DarkGray;
      tChart9.Axes.DepthTop.Labels.Shadow.Brush.Solid = true;
      tChart9.Axes.DepthTop.Labels.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart9.Axes.DepthTop.Title.Brush.Color = Color.Silver;
      tChart9.Axes.DepthTop.Title.Brush.Solid = true;
      tChart9.Axes.DepthTop.Title.Brush.Visible = true;
      // 
      // 
      // 
      tChart9.Axes.DepthTop.Title.Font.Bold = false;
      // 
      // 
      // 
      tChart9.Axes.DepthTop.Title.Font.Brush.Color = Color.FromArgb((int)(byte)0, (int)(byte)0, (int)(byte)0);
      tChart9.Axes.DepthTop.Title.Font.Brush.Solid = true;
      tChart9.Axes.DepthTop.Title.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart9.Axes.DepthTop.Title.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart9.Axes.DepthTop.Title.Font.Shadow.Brush.Solid = true;
      tChart9.Axes.DepthTop.Title.Font.Shadow.Brush.Visible = true;
      tChart9.Axes.DepthTop.Title.Font.Size = 8;
      tChart9.Axes.DepthTop.Title.Font.SizeFloat = 8F;
      tChart9.Axes.DepthTop.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart9.Axes.DepthTop.Title.ImageBevel.Brush.Color = Color.LightGray;
      tChart9.Axes.DepthTop.Title.ImageBevel.Brush.Solid = true;
      tChart9.Axes.DepthTop.Title.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart9.Axes.DepthTop.Title.Shadow.Brush.Color = Color.DarkGray;
      tChart9.Axes.DepthTop.Title.Shadow.Brush.Solid = true;
      tChart9.Axes.DepthTop.Title.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      tChart9.Axes.Left.Labels.Brush.Color = Color.White;
      tChart9.Axes.Left.Labels.Brush.Solid = true;
      tChart9.Axes.Left.Labels.Brush.Visible = true;
      // 
      // 
      // 
      tChart9.Axes.Left.Labels.Font.Bold = false;
      // 
      // 
      // 
      tChart9.Axes.Left.Labels.Font.Brush.Color = Color.FromArgb((int)(byte)255, (int)(byte)255, (int)(byte)255);
      tChart9.Axes.Left.Labels.Font.Brush.Solid = true;
      tChart9.Axes.Left.Labels.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart9.Axes.Left.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart9.Axes.Left.Labels.Font.Shadow.Brush.Solid = true;
      tChart9.Axes.Left.Labels.Font.Shadow.Brush.Visible = true;
      tChart9.Axes.Left.Labels.Font.Size = 8;
      tChart9.Axes.Left.Labels.Font.SizeFloat = 8F;
      tChart9.Axes.Left.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart9.Axes.Left.Labels.ImageBevel.Brush.Color = Color.LightGray;
      tChart9.Axes.Left.Labels.ImageBevel.Brush.Solid = true;
      tChart9.Axes.Left.Labels.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart9.Axes.Left.Labels.Shadow.Brush.Color = Color.DarkGray;
      tChart9.Axes.Left.Labels.Shadow.Brush.Solid = true;
      tChart9.Axes.Left.Labels.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart9.Axes.Left.Title.Brush.Color = Color.Silver;
      tChart9.Axes.Left.Title.Brush.Solid = true;
      tChart9.Axes.Left.Title.Brush.Visible = true;
      // 
      // 
      // 
      tChart9.Axes.Left.Title.Font.Bold = false;
      // 
      // 
      // 
      tChart9.Axes.Left.Title.Font.Brush.Color = Color.FromArgb((int)(byte)0, (int)(byte)0, (int)(byte)0);
      tChart9.Axes.Left.Title.Font.Brush.Solid = true;
      tChart9.Axes.Left.Title.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart9.Axes.Left.Title.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart9.Axes.Left.Title.Font.Shadow.Brush.Solid = true;
      tChart9.Axes.Left.Title.Font.Shadow.Brush.Visible = true;
      tChart9.Axes.Left.Title.Font.Size = 8;
      tChart9.Axes.Left.Title.Font.SizeFloat = 8F;
      tChart9.Axes.Left.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart9.Axes.Left.Title.ImageBevel.Brush.Color = Color.LightGray;
      tChart9.Axes.Left.Title.ImageBevel.Brush.Solid = true;
      tChart9.Axes.Left.Title.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart9.Axes.Left.Title.Shadow.Brush.Color = Color.DarkGray;
      tChart9.Axes.Left.Title.Shadow.Brush.Solid = true;
      tChart9.Axes.Left.Title.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      tChart9.Axes.Right.Labels.Brush.Color = Color.White;
      tChart9.Axes.Right.Labels.Brush.Solid = true;
      tChart9.Axes.Right.Labels.Brush.Visible = true;
      // 
      // 
      // 
      tChart9.Axes.Right.Labels.Font.Bold = false;
      // 
      // 
      // 
      tChart9.Axes.Right.Labels.Font.Brush.Color = Color.FromArgb((int)(byte)255, (int)(byte)255, (int)(byte)255);
      tChart9.Axes.Right.Labels.Font.Brush.Solid = true;
      tChart9.Axes.Right.Labels.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart9.Axes.Right.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart9.Axes.Right.Labels.Font.Shadow.Brush.Solid = true;
      tChart9.Axes.Right.Labels.Font.Shadow.Brush.Visible = true;
      tChart9.Axes.Right.Labels.Font.Size = 8;
      tChart9.Axes.Right.Labels.Font.SizeFloat = 8F;
      tChart9.Axes.Right.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart9.Axes.Right.Labels.ImageBevel.Brush.Color = Color.LightGray;
      tChart9.Axes.Right.Labels.ImageBevel.Brush.Solid = true;
      tChart9.Axes.Right.Labels.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart9.Axes.Right.Labels.Shadow.Brush.Color = Color.DarkGray;
      tChart9.Axes.Right.Labels.Shadow.Brush.Solid = true;
      tChart9.Axes.Right.Labels.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart9.Axes.Right.Title.Brush.Color = Color.Silver;
      tChart9.Axes.Right.Title.Brush.Solid = true;
      tChart9.Axes.Right.Title.Brush.Visible = true;
      // 
      // 
      // 
      tChart9.Axes.Right.Title.Font.Bold = false;
      // 
      // 
      // 
      tChart9.Axes.Right.Title.Font.Brush.Color = Color.FromArgb((int)(byte)0, (int)(byte)0, (int)(byte)0);
      tChart9.Axes.Right.Title.Font.Brush.Solid = true;
      tChart9.Axes.Right.Title.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart9.Axes.Right.Title.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart9.Axes.Right.Title.Font.Shadow.Brush.Solid = true;
      tChart9.Axes.Right.Title.Font.Shadow.Brush.Visible = true;
      tChart9.Axes.Right.Title.Font.Size = 8;
      tChart9.Axes.Right.Title.Font.SizeFloat = 8F;
      tChart9.Axes.Right.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart9.Axes.Right.Title.ImageBevel.Brush.Color = Color.LightGray;
      tChart9.Axes.Right.Title.ImageBevel.Brush.Solid = true;
      tChart9.Axes.Right.Title.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart9.Axes.Right.Title.Shadow.Brush.Color = Color.DarkGray;
      tChart9.Axes.Right.Title.Shadow.Brush.Solid = true;
      tChart9.Axes.Right.Title.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      tChart9.Axes.Top.Labels.Brush.Color = Color.White;
      tChart9.Axes.Top.Labels.Brush.Solid = true;
      tChart9.Axes.Top.Labels.Brush.Visible = true;
      // 
      // 
      // 
      tChart9.Axes.Top.Labels.Font.Bold = false;
      // 
      // 
      // 
      tChart9.Axes.Top.Labels.Font.Brush.Color = Color.FromArgb((int)(byte)255, (int)(byte)255, (int)(byte)255);
      tChart9.Axes.Top.Labels.Font.Brush.Solid = true;
      tChart9.Axes.Top.Labels.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart9.Axes.Top.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart9.Axes.Top.Labels.Font.Shadow.Brush.Solid = true;
      tChart9.Axes.Top.Labels.Font.Shadow.Brush.Visible = true;
      tChart9.Axes.Top.Labels.Font.Size = 8;
      tChart9.Axes.Top.Labels.Font.SizeFloat = 8F;
      tChart9.Axes.Top.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart9.Axes.Top.Labels.ImageBevel.Brush.Color = Color.LightGray;
      tChart9.Axes.Top.Labels.ImageBevel.Brush.Solid = true;
      tChart9.Axes.Top.Labels.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart9.Axes.Top.Labels.Shadow.Brush.Color = Color.DarkGray;
      tChart9.Axes.Top.Labels.Shadow.Brush.Solid = true;
      tChart9.Axes.Top.Labels.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart9.Axes.Top.Title.Brush.Color = Color.Silver;
      tChart9.Axes.Top.Title.Brush.Solid = true;
      tChart9.Axes.Top.Title.Brush.Visible = true;
      // 
      // 
      // 
      tChart9.Axes.Top.Title.Font.Bold = false;
      // 
      // 
      // 
      tChart9.Axes.Top.Title.Font.Brush.Color = Color.FromArgb((int)(byte)0, (int)(byte)0, (int)(byte)0);
      tChart9.Axes.Top.Title.Font.Brush.Solid = true;
      tChart9.Axes.Top.Title.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart9.Axes.Top.Title.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart9.Axes.Top.Title.Font.Shadow.Brush.Solid = true;
      tChart9.Axes.Top.Title.Font.Shadow.Brush.Visible = true;
      tChart9.Axes.Top.Title.Font.Size = 8;
      tChart9.Axes.Top.Title.Font.SizeFloat = 8F;
      tChart9.Axes.Top.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart9.Axes.Top.Title.ImageBevel.Brush.Color = Color.LightGray;
      tChart9.Axes.Top.Title.ImageBevel.Brush.Solid = true;
      tChart9.Axes.Top.Title.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart9.Axes.Top.Title.Shadow.Brush.Color = Color.DarkGray;
      tChart9.Axes.Top.Title.Shadow.Brush.Solid = true;
      tChart9.Axes.Top.Title.Shadow.Brush.Visible = true;
      tChart9.Dock = DockStyle.Fill;
      // 
      // 
      // 
      tChart9.Footer.Bottom = 186;
      // 
      // 
      // 
      tChart9.Footer.Brush.Color = Color.FromArgb((int)(byte)224, (int)(byte)224, (int)(byte)224);
      tChart9.Footer.Brush.Solid = true;
      tChart9.Footer.Brush.Visible = true;
      tChart9.Footer.CustomPosition = true;
      // 
      // 
      // 
      tChart9.Footer.Font.Bold = false;
      // 
      // 
      // 
      tChart9.Footer.Font.Brush.Color = Color.FromArgb((int)(byte)192, (int)(byte)192, (int)(byte)192);
      tChart9.Footer.Font.Brush.Solid = true;
      tChart9.Footer.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart9.Footer.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart9.Footer.Font.Shadow.Brush.Solid = true;
      tChart9.Footer.Font.Shadow.Brush.Visible = true;
      tChart9.Footer.Font.Size = 8;
      tChart9.Footer.Font.SizeFloat = 8F;
      tChart9.Footer.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart9.Footer.ImageBevel.Brush.Color = Color.LightGray;
      tChart9.Footer.ImageBevel.Brush.Solid = true;
      tChart9.Footer.ImageBevel.Brush.Visible = true;
      tChart9.Footer.Left = 6;
      tChart9.Footer.Lines = new string[]
  {
    "Oven 4"
  };
      tChart9.Footer.Right = 64;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart9.Footer.Shadow.Brush.Color = Color.DarkGray;
      tChart9.Footer.Shadow.Brush.Solid = true;
      tChart9.Footer.Shadow.Brush.Visible = true;
      tChart9.Footer.Top = 171;
      tChart9.Footer.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart9.Header.Brush.Color = Color.FromArgb((int)(byte)192, (int)(byte)192, (int)(byte)192);
      // 
      // 
      // 
      tChart9.Header.Brush.Gradient.SigmaFocus = 0F;
      tChart9.Header.Brush.Gradient.SigmaScale = 0F;
      tChart9.Header.Brush.Solid = true;
      tChart9.Header.Brush.Visible = true;
      // 
      // 
      // 
      tChart9.Header.Font.Bold = false;
      // 
      // 
      // 
      tChart9.Header.Font.Brush.Color = Color.FromArgb((int)(byte)255, (int)(byte)255, (int)(byte)255);
      tChart9.Header.Font.Brush.Solid = true;
      tChart9.Header.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart9.Header.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart9.Header.Font.Shadow.Brush.Solid = true;
      tChart9.Header.Font.Shadow.Brush.Visible = true;
      tChart9.Header.Font.Size = 8;
      tChart9.Header.Font.SizeFloat = 8F;
      tChart9.Header.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart9.Header.ImageBevel.Brush.Color = Color.LightGray;
      tChart9.Header.ImageBevel.Brush.Solid = true;
      tChart9.Header.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart9.Header.Shadow.Brush.Color = Color.FromArgb((int)(byte)169, (int)(byte)169, (int)(byte)169);
      tChart9.Header.Shadow.Brush.Solid = true;
      tChart9.Header.Shadow.Brush.Visible = true;
      tChart9.Header.Shadow.Height = 0;
      tChart9.Header.Shadow.Width = 0;
      tChart9.Header.Visible = false;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart9.Legend.Brush.Color = Color.White;
      // 
      // 
      // 
      tChart9.Legend.Brush.Gradient.SigmaFocus = 0F;
      tChart9.Legend.Brush.Gradient.SigmaScale = 0F;
      tChart9.Legend.Brush.Gradient.Visible = true;
      tChart9.Legend.Brush.Solid = true;
      tChart9.Legend.Brush.Visible = true;
      tChart9.Legend.CheckBoxes = false;
      tChart9.Legend.ClipText = false;
      // 
      // 
      // 
      tChart9.Legend.Font.Bold = false;
      // 
      // 
      // 
      tChart9.Legend.Font.Brush.Color = Color.FromArgb((int)(byte)255, (int)(byte)255, (int)(byte)255);
      tChart9.Legend.Font.Brush.Solid = true;
      tChart9.Legend.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart9.Legend.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart9.Legend.Font.Shadow.Brush.Solid = true;
      tChart9.Legend.Font.Shadow.Brush.Visible = true;
      tChart9.Legend.Font.Size = 8;
      tChart9.Legend.Font.SizeFloat = 8F;
      tChart9.Legend.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart9.Legend.ImageBevel.Brush.Color = Color.LightGray;
      tChart9.Legend.ImageBevel.Brush.Solid = true;
      tChart9.Legend.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart9.Legend.Shadow.Brush.Color = Color.FromArgb((int)(byte)0, (int)(byte)0, (int)(byte)0);
      tChart9.Legend.Shadow.Brush.Solid = true;
      tChart9.Legend.Shadow.Brush.Visible = true;
      tChart9.Legend.Shadow.Width = 0;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      tChart9.Legend.Symbol.Shadow.Brush.Color = Color.DarkGray;
      tChart9.Legend.Symbol.Shadow.Brush.Solid = true;
      tChart9.Legend.Symbol.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart9.Legend.Title.Brush.Color = Color.White;
      tChart9.Legend.Title.Brush.Solid = true;
      tChart9.Legend.Title.Brush.Visible = true;
      // 
      // 
      // 
      tChart9.Legend.Title.Font.Bold = true;
      // 
      // 
      // 
      tChart9.Legend.Title.Font.Brush.Color = Color.Black;
      tChart9.Legend.Title.Font.Brush.Solid = true;
      tChart9.Legend.Title.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart9.Legend.Title.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart9.Legend.Title.Font.Shadow.Brush.Solid = true;
      tChart9.Legend.Title.Font.Shadow.Brush.Visible = true;
      tChart9.Legend.Title.Font.Size = 8;
      tChart9.Legend.Title.Font.SizeFloat = 8F;
      tChart9.Legend.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Bold;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart9.Legend.Title.ImageBevel.Brush.Color = Color.LightGray;
      tChart9.Legend.Title.ImageBevel.Brush.Solid = true;
      tChart9.Legend.Title.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart9.Legend.Title.Shadow.Brush.Color = Color.DarkGray;
      tChart9.Legend.Title.Shadow.Brush.Solid = true;
      tChart9.Legend.Title.Shadow.Brush.Visible = true;
      tChart9.Legend.Visible = false;
      tChart9.Location = new Point(0, 547);
      tChart9.Name = "tChart9";
      // 
      // 
      // 
      // 
      // 
      // 
      tChart9.Panel.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.Raised;
      // 
      // 
      // 
      tChart9.Panel.Brush.Color = Color.FromArgb((int)(byte)240, (int)(byte)240, (int)(byte)240);
      // 
      // 
      // 
      tChart9.Panel.Brush.Gradient.EndColor = Color.FromArgb((int)(byte)70, (int)(byte)70, (int)(byte)70);
      tChart9.Panel.Brush.Gradient.MiddleColor = Color.FromArgb((int)(byte)0, (int)(byte)0, (int)(byte)0, (int)(byte)0);
      tChart9.Panel.Brush.Gradient.SigmaFocus = 0F;
      tChart9.Panel.Brush.Gradient.SigmaScale = 0F;
      tChart9.Panel.Brush.Gradient.StartColor = Color.FromArgb((int)(byte)70, (int)(byte)70, (int)(byte)70);
      tChart9.Panel.Brush.Gradient.UseMiddle = false;
      tChart9.Panel.Brush.Gradient.Visible = true;
      tChart9.Panel.Brush.Solid = true;
      tChart9.Panel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart9.Panel.ImageBevel.Brush.Color = Color.LightGray;
      tChart9.Panel.ImageBevel.Brush.Solid = true;
      tChart9.Panel.ImageBevel.Brush.Visible = true;
      tChart9.Panel.MarginBottom = 2D;
      tChart9.Panel.MarginLeft = 7D;
      tChart9.Panel.MarginRight = 7D;
      tChart9.Panel.MarginTop = 6D;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart9.Panel.Shadow.Brush.Color = Color.DarkGray;
      tChart9.Panel.Shadow.Brush.Solid = true;
      tChart9.Panel.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      margins6.Bottom = 100;
      margins6.Left = 100;
      margins6.Right = 100;
      margins6.Top = 100;
      tChart9.Printer.Margins = margins6;
      tChart9.Series.Add(donut4);
      tChart9.Size = new Size(195, 161);
      // 
      // 
      // 
      // 
      // 
      // 
      tChart9.SubFooter.Brush.Color = Color.Silver;
      tChart9.SubFooter.Brush.Solid = true;
      tChart9.SubFooter.Brush.Visible = true;
      // 
      // 
      // 
      tChart9.SubFooter.Font.Bold = false;
      // 
      // 
      // 
      tChart9.SubFooter.Font.Brush.Color = Color.Red;
      tChart9.SubFooter.Font.Brush.Solid = true;
      tChart9.SubFooter.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart9.SubFooter.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart9.SubFooter.Font.Shadow.Brush.Solid = true;
      tChart9.SubFooter.Font.Shadow.Brush.Visible = true;
      tChart9.SubFooter.Font.Size = 8;
      tChart9.SubFooter.Font.SizeFloat = 8F;
      tChart9.SubFooter.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart9.SubFooter.ImageBevel.Brush.Color = Color.LightGray;
      tChart9.SubFooter.ImageBevel.Brush.Solid = true;
      tChart9.SubFooter.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart9.SubFooter.Shadow.Brush.Color = Color.DarkGray;
      tChart9.SubFooter.Shadow.Brush.Solid = true;
      tChart9.SubFooter.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart9.SubHeader.Brush.Color = Color.FromArgb((int)(byte)192, (int)(byte)192, (int)(byte)192);
      tChart9.SubHeader.Brush.Solid = true;
      tChart9.SubHeader.Brush.Visible = true;
      // 
      // 
      // 
      tChart9.SubHeader.Font.Bold = false;
      // 
      // 
      // 
      tChart9.SubHeader.Font.Brush.Color = Color.FromArgb((int)(byte)128, (int)(byte)128, (int)(byte)128);
      tChart9.SubHeader.Font.Brush.Solid = true;
      tChart9.SubHeader.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart9.SubHeader.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart9.SubHeader.Font.Shadow.Brush.Solid = true;
      tChart9.SubHeader.Font.Shadow.Brush.Visible = true;
      tChart9.SubHeader.Font.Size = 12;
      tChart9.SubHeader.Font.SizeFloat = 12F;
      tChart9.SubHeader.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart9.SubHeader.ImageBevel.Brush.Color = Color.LightGray;
      tChart9.SubHeader.ImageBevel.Brush.Solid = true;
      tChart9.SubHeader.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart9.SubHeader.Shadow.Brush.Color = Color.FromArgb((int)(byte)169, (int)(byte)169, (int)(byte)169);
      tChart9.SubHeader.Shadow.Brush.Solid = true;
      tChart9.SubHeader.Shadow.Brush.Visible = true;
      tChart9.TabIndex = 4;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      tChart9.Walls.Back.Brush.Color = Color.Silver;
      // 
      // 
      // 
      tChart9.Walls.Back.Brush.Gradient.EndColor = Color.FromArgb((int)(byte)120, (int)(byte)120, (int)(byte)120);
      tChart9.Walls.Back.Brush.Gradient.StartColor = Color.FromArgb((int)(byte)70, (int)(byte)70, (int)(byte)70);
      tChart9.Walls.Back.Brush.Solid = true;
      tChart9.Walls.Back.Brush.Visible = false;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart9.Walls.Back.ImageBevel.Brush.Color = Color.LightGray;
      tChart9.Walls.Back.ImageBevel.Brush.Solid = true;
      tChart9.Walls.Back.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart9.Walls.Back.Shadow.Brush.Color = Color.DarkGray;
      tChart9.Walls.Back.Shadow.Brush.Solid = true;
      tChart9.Walls.Back.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart9.Walls.Bottom.Brush.Color = Color.White;
      // 
      // 
      // 
      tChart9.Walls.Bottom.Brush.Gradient.SigmaFocus = 0F;
      tChart9.Walls.Bottom.Brush.Gradient.SigmaScale = 0F;
      tChart9.Walls.Bottom.Brush.Solid = true;
      tChart9.Walls.Bottom.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart9.Walls.Bottom.ImageBevel.Brush.Color = Color.LightGray;
      tChart9.Walls.Bottom.ImageBevel.Brush.Solid = true;
      tChart9.Walls.Bottom.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart9.Walls.Bottom.Shadow.Brush.Color = Color.DarkGray;
      tChart9.Walls.Bottom.Shadow.Brush.Solid = true;
      tChart9.Walls.Bottom.Shadow.Brush.Visible = true;
      tChart9.Walls.Bottom.Visible = false;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart9.Walls.Left.Brush.Color = Color.LightYellow;
      // 
      // 
      // 
      tChart9.Walls.Left.Brush.Gradient.SigmaFocus = 0F;
      tChart9.Walls.Left.Brush.Gradient.SigmaScale = 0F;
      tChart9.Walls.Left.Brush.Solid = true;
      tChart9.Walls.Left.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart9.Walls.Left.ImageBevel.Brush.Color = Color.LightGray;
      tChart9.Walls.Left.ImageBevel.Brush.Solid = true;
      tChart9.Walls.Left.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart9.Walls.Left.Shadow.Brush.Color = Color.DarkGray;
      tChart9.Walls.Left.Shadow.Brush.Solid = true;
      tChart9.Walls.Left.Shadow.Brush.Visible = true;
      tChart9.Walls.Left.Visible = false;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart9.Walls.Right.Brush.Color = Color.FromArgb((int)(byte)192, (int)(byte)192, (int)(byte)192);
      // 
      // 
      // 
      tChart9.Walls.Right.Brush.Gradient.SigmaFocus = 0F;
      tChart9.Walls.Right.Brush.Gradient.SigmaScale = 0F;
      tChart9.Walls.Right.Brush.Solid = true;
      tChart9.Walls.Right.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart9.Walls.Right.ImageBevel.Brush.Color = Color.LightGray;
      tChart9.Walls.Right.ImageBevel.Brush.Solid = true;
      tChart9.Walls.Right.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart9.Walls.Right.Shadow.Brush.Color = Color.DarkGray;
      tChart9.Walls.Right.Shadow.Brush.Solid = true;
      tChart9.Walls.Right.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart9.Zoom.Brush.Color = Color.FromArgb((int)(byte)127, (int)(byte)0, (int)(byte)0, (int)(byte)255);
      tChart9.Zoom.Brush.Solid = true;
      tChart9.Zoom.Brush.Visible = false;
      tChart9.AfterDraw += (this.tChart9_AfterDraw);
      tChart9.BeforeDrawAxes += (this.tChart9_BeforeDrawAxes);
      // 
      // donut4
      // 
      // 
      // 
      // 
      donut4.Brush.Color = Color.FromArgb((int)(byte)255, (int)(byte)243, (int)(byte)144);
      donut4.Brush.Solid = true;
      donut4.Brush.Visible = true;
      donut4.Circled = true;
      donut4.Color = Color.FromArgb((int)(byte)119, (int)(byte)153, (int)(byte)214);
      donut4.Cursor = cursor1;
      // 
      // 
      // 
      donut4.Frame.Circled = true;
      donut4.Frame.FrameElementPercents = new double[]
  {
    25D,
    60D,
    15D
  };
      // 
      // 
      // 
      donut4.Frame.InnerBand.Color = Color.Gray;
      donut4.Frame.InnerBand.Solid = true;
      donut4.Frame.InnerBand.Visible = true;
      // 
      // 
      // 
      donut4.Frame.OuterBand.Color = Color.Gray;
      // 
      // 
      // 
      donut4.Frame.OuterBand.Gradient.Visible = true;
      donut4.Frame.OuterBand.Solid = true;
      donut4.Frame.OuterBand.Visible = true;
      donut4.LabelMember = "Labels";
      // 
      // 
      // 
      // 
      // 
      // 
      donut4.Legend.Brush.Color = Color.White;
      donut4.Legend.Brush.Solid = true;
      donut4.Legend.Brush.Visible = true;
      // 
      // 
      // 
      donut4.Legend.Font.Bold = false;
      // 
      // 
      // 
      donut4.Legend.Font.Brush.Color = Color.Black;
      donut4.Legend.Font.Brush.Solid = true;
      donut4.Legend.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      donut4.Legend.Font.Shadow.Brush.Color = Color.DarkGray;
      donut4.Legend.Font.Shadow.Brush.Solid = true;
      donut4.Legend.Font.Shadow.Brush.Visible = true;
      donut4.Legend.Font.Size = 8;
      donut4.Legend.Font.SizeFloat = 8F;
      donut4.Legend.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      donut4.Legend.ImageBevel.Brush.Color = Color.LightGray;
      donut4.Legend.ImageBevel.Brush.Solid = true;
      donut4.Legend.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      donut4.Legend.Shadow.Brush.Color = Color.DarkGray;
      donut4.Legend.Shadow.Brush.Solid = true;
      donut4.Legend.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      donut4.Marks.Arrow.Color = Color.Black;
      // 
      // 
      // 
      donut4.Marks.Brush.Color = Color.FromArgb((int)(byte)255, (int)(byte)255, (int)(byte)255);
      donut4.Marks.Brush.Solid = true;
      donut4.Marks.Brush.Visible = true;
      // 
      // 
      // 
      donut4.Marks.Font.Bold = false;
      // 
      // 
      // 
      donut4.Marks.Font.Brush.Color = Color.FromArgb((int)(byte)0, (int)(byte)0, (int)(byte)0);
      donut4.Marks.Font.Brush.Solid = true;
      donut4.Marks.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      donut4.Marks.Font.Shadow.Brush.Color = Color.DarkGray;
      donut4.Marks.Font.Shadow.Brush.Solid = true;
      donut4.Marks.Font.Shadow.Brush.Visible = true;
      donut4.Marks.Font.Size = 8;
      donut4.Marks.Font.SizeFloat = 8F;
      donut4.Marks.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      donut4.Marks.ImageBevel.Brush.Color = Color.LightGray;
      donut4.Marks.ImageBevel.Brush.Solid = true;
      donut4.Marks.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      donut4.Marks.Shadow.Brush.Color = Color.FromArgb((int)(byte)128, (int)(byte)128, (int)(byte)128);
      donut4.Marks.Shadow.Brush.Solid = true;
      donut4.Marks.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      donut4.Marks.Symbol.Brush.Color = Color.White;
      donut4.Marks.Symbol.Brush.Solid = true;
      donut4.Marks.Symbol.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      donut4.Marks.Symbol.ImageBevel.Brush.Color = Color.LightGray;
      donut4.Marks.Symbol.ImageBevel.Brush.Solid = true;
      donut4.Marks.Symbol.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      donut4.Marks.Symbol.Shadow.Brush.Color = Color.DarkGray;
      donut4.Marks.Symbol.Shadow.Brush.Solid = true;
      donut4.Marks.Symbol.Shadow.Brush.Visible = true;
      donut4.Marks.Visible = false;
      // 
      // 
      // 
      donut4.MarksPie.InsideSlice = false;
      donut4.MarksPie.LegSize = 0;
      donut4.MarksPie.Rotated = false;
      donut4.MarksPie.RotateStyle = Steema.TeeChart.Styles.Pie.MarksRotateStyle.Radial;
      donut4.MarksPie.VertCenter = false;
      donut4.MultiPie = Steema.TeeChart.Styles.MultiPies.Automatic;
      // 
      // 
      // 
      donut4.OtherSlice.Color = Color.Empty;
      donut4.OtherSlice.Style = Steema.TeeChart.Styles.PieOtherStyles.None;
      donut4.OtherSlice.Text = "";
      donut4.OtherSlice.Value = 0D;
      // 
      // 
      // 
      // 
      // 
      // 
      donut4.Shadow.Brush.Color = Color.DarkGray;
      donut4.Shadow.Brush.Solid = true;
      donut4.Shadow.Brush.Visible = true;
      donut4.Title = "donut1";
      donut4.UniqueCustomRadius = true;
      // 
      // 
      // 
      donut4.XValues.DataMember = "Angle";
      donut4.XValues.Value = new double[]
  {
    0D,
    1D,
    2D,
    3D,
    4D,
    5D,
    6D,
    7D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
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
      donut4.YValues.DataMember = "Pie";
      donut4.YValues.Value = new double[]
  {
    233D,
    584D,
    649D,
    669D,
    516D,
    406D,
    664D,
    33D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
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
      // tChart4
      // 
      // 
      // 
      // 
      tChart4.Aspect.ColorPaletteIndex = -1;
      tChart4.Aspect.Elevation = 315;
      tChart4.Aspect.ElevationFloat = 315D;
      tChart4.Aspect.Orthogonal = false;
      tChart4.Aspect.Perspective = 0;
      tChart4.Aspect.Rotation = 360;
      tChart4.Aspect.RotationFloat = 360D;
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
      tChart4.Axes.Bottom.Labels.Brush.Color = Color.White;
      tChart4.Axes.Bottom.Labels.Brush.Solid = true;
      tChart4.Axes.Bottom.Labels.Brush.Visible = true;
      // 
      // 
      // 
      tChart4.Axes.Bottom.Labels.Font.Bold = false;
      // 
      // 
      // 
      tChart4.Axes.Bottom.Labels.Font.Brush.Color = Color.FromArgb((int)(byte)255, (int)(byte)255, (int)(byte)255);
      tChart4.Axes.Bottom.Labels.Font.Brush.Solid = true;
      tChart4.Axes.Bottom.Labels.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart4.Axes.Bottom.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart4.Axes.Bottom.Labels.Font.Shadow.Brush.Solid = true;
      tChart4.Axes.Bottom.Labels.Font.Shadow.Brush.Visible = true;
      tChart4.Axes.Bottom.Labels.Font.Size = 8;
      tChart4.Axes.Bottom.Labels.Font.SizeFloat = 8F;
      tChart4.Axes.Bottom.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart4.Axes.Bottom.Labels.ImageBevel.Brush.Color = Color.LightGray;
      tChart4.Axes.Bottom.Labels.ImageBevel.Brush.Solid = true;
      tChart4.Axes.Bottom.Labels.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart4.Axes.Bottom.Labels.Shadow.Brush.Color = Color.DarkGray;
      tChart4.Axes.Bottom.Labels.Shadow.Brush.Solid = true;
      tChart4.Axes.Bottom.Labels.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart4.Axes.Bottom.Title.Brush.Color = Color.Silver;
      tChart4.Axes.Bottom.Title.Brush.Solid = true;
      tChart4.Axes.Bottom.Title.Brush.Visible = true;
      // 
      // 
      // 
      tChart4.Axes.Bottom.Title.Font.Bold = false;
      // 
      // 
      // 
      tChart4.Axes.Bottom.Title.Font.Brush.Color = Color.FromArgb((int)(byte)0, (int)(byte)0, (int)(byte)0);
      tChart4.Axes.Bottom.Title.Font.Brush.Solid = true;
      tChart4.Axes.Bottom.Title.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart4.Axes.Bottom.Title.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart4.Axes.Bottom.Title.Font.Shadow.Brush.Solid = true;
      tChart4.Axes.Bottom.Title.Font.Shadow.Brush.Visible = true;
      tChart4.Axes.Bottom.Title.Font.Size = 8;
      tChart4.Axes.Bottom.Title.Font.SizeFloat = 8F;
      tChart4.Axes.Bottom.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart4.Axes.Bottom.Title.ImageBevel.Brush.Color = Color.LightGray;
      tChart4.Axes.Bottom.Title.ImageBevel.Brush.Solid = true;
      tChart4.Axes.Bottom.Title.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart4.Axes.Bottom.Title.Shadow.Brush.Color = Color.DarkGray;
      tChart4.Axes.Bottom.Title.Shadow.Brush.Solid = true;
      tChart4.Axes.Bottom.Title.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      tChart4.Axes.Depth.Labels.Brush.Color = Color.White;
      tChart4.Axes.Depth.Labels.Brush.Solid = true;
      tChart4.Axes.Depth.Labels.Brush.Visible = true;
      // 
      // 
      // 
      tChart4.Axes.Depth.Labels.Font.Bold = false;
      // 
      // 
      // 
      tChart4.Axes.Depth.Labels.Font.Brush.Color = Color.FromArgb((int)(byte)255, (int)(byte)255, (int)(byte)255);
      tChart4.Axes.Depth.Labels.Font.Brush.Solid = true;
      tChart4.Axes.Depth.Labels.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart4.Axes.Depth.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart4.Axes.Depth.Labels.Font.Shadow.Brush.Solid = true;
      tChart4.Axes.Depth.Labels.Font.Shadow.Brush.Visible = true;
      tChart4.Axes.Depth.Labels.Font.Size = 8;
      tChart4.Axes.Depth.Labels.Font.SizeFloat = 8F;
      tChart4.Axes.Depth.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart4.Axes.Depth.Labels.ImageBevel.Brush.Color = Color.LightGray;
      tChart4.Axes.Depth.Labels.ImageBevel.Brush.Solid = true;
      tChart4.Axes.Depth.Labels.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart4.Axes.Depth.Labels.Shadow.Brush.Color = Color.DarkGray;
      tChart4.Axes.Depth.Labels.Shadow.Brush.Solid = true;
      tChart4.Axes.Depth.Labels.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart4.Axes.Depth.Title.Brush.Color = Color.Silver;
      tChart4.Axes.Depth.Title.Brush.Solid = true;
      tChart4.Axes.Depth.Title.Brush.Visible = true;
      // 
      // 
      // 
      tChart4.Axes.Depth.Title.Font.Bold = false;
      // 
      // 
      // 
      tChart4.Axes.Depth.Title.Font.Brush.Color = Color.FromArgb((int)(byte)0, (int)(byte)0, (int)(byte)0);
      tChart4.Axes.Depth.Title.Font.Brush.Solid = true;
      tChart4.Axes.Depth.Title.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart4.Axes.Depth.Title.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart4.Axes.Depth.Title.Font.Shadow.Brush.Solid = true;
      tChart4.Axes.Depth.Title.Font.Shadow.Brush.Visible = true;
      tChart4.Axes.Depth.Title.Font.Size = 8;
      tChart4.Axes.Depth.Title.Font.SizeFloat = 8F;
      tChart4.Axes.Depth.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart4.Axes.Depth.Title.ImageBevel.Brush.Color = Color.LightGray;
      tChart4.Axes.Depth.Title.ImageBevel.Brush.Solid = true;
      tChart4.Axes.Depth.Title.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart4.Axes.Depth.Title.Shadow.Brush.Color = Color.DarkGray;
      tChart4.Axes.Depth.Title.Shadow.Brush.Solid = true;
      tChart4.Axes.Depth.Title.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      tChart4.Axes.DepthTop.Labels.Brush.Color = Color.White;
      tChart4.Axes.DepthTop.Labels.Brush.Solid = true;
      tChart4.Axes.DepthTop.Labels.Brush.Visible = true;
      // 
      // 
      // 
      tChart4.Axes.DepthTop.Labels.Font.Bold = false;
      // 
      // 
      // 
      tChart4.Axes.DepthTop.Labels.Font.Brush.Color = Color.FromArgb((int)(byte)255, (int)(byte)255, (int)(byte)255);
      tChart4.Axes.DepthTop.Labels.Font.Brush.Solid = true;
      tChart4.Axes.DepthTop.Labels.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart4.Axes.DepthTop.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart4.Axes.DepthTop.Labels.Font.Shadow.Brush.Solid = true;
      tChart4.Axes.DepthTop.Labels.Font.Shadow.Brush.Visible = true;
      tChart4.Axes.DepthTop.Labels.Font.Size = 8;
      tChart4.Axes.DepthTop.Labels.Font.SizeFloat = 8F;
      tChart4.Axes.DepthTop.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart4.Axes.DepthTop.Labels.ImageBevel.Brush.Color = Color.LightGray;
      tChart4.Axes.DepthTop.Labels.ImageBevel.Brush.Solid = true;
      tChart4.Axes.DepthTop.Labels.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart4.Axes.DepthTop.Labels.Shadow.Brush.Color = Color.DarkGray;
      tChart4.Axes.DepthTop.Labels.Shadow.Brush.Solid = true;
      tChart4.Axes.DepthTop.Labels.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart4.Axes.DepthTop.Title.Brush.Color = Color.Silver;
      tChart4.Axes.DepthTop.Title.Brush.Solid = true;
      tChart4.Axes.DepthTop.Title.Brush.Visible = true;
      // 
      // 
      // 
      tChart4.Axes.DepthTop.Title.Font.Bold = false;
      // 
      // 
      // 
      tChart4.Axes.DepthTop.Title.Font.Brush.Color = Color.FromArgb((int)(byte)0, (int)(byte)0, (int)(byte)0);
      tChart4.Axes.DepthTop.Title.Font.Brush.Solid = true;
      tChart4.Axes.DepthTop.Title.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart4.Axes.DepthTop.Title.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart4.Axes.DepthTop.Title.Font.Shadow.Brush.Solid = true;
      tChart4.Axes.DepthTop.Title.Font.Shadow.Brush.Visible = true;
      tChart4.Axes.DepthTop.Title.Font.Size = 8;
      tChart4.Axes.DepthTop.Title.Font.SizeFloat = 8F;
      tChart4.Axes.DepthTop.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart4.Axes.DepthTop.Title.ImageBevel.Brush.Color = Color.LightGray;
      tChart4.Axes.DepthTop.Title.ImageBevel.Brush.Solid = true;
      tChart4.Axes.DepthTop.Title.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart4.Axes.DepthTop.Title.Shadow.Brush.Color = Color.DarkGray;
      tChart4.Axes.DepthTop.Title.Shadow.Brush.Solid = true;
      tChart4.Axes.DepthTop.Title.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      tChart4.Axes.Left.Labels.Brush.Color = Color.White;
      tChart4.Axes.Left.Labels.Brush.Solid = true;
      tChart4.Axes.Left.Labels.Brush.Visible = true;
      // 
      // 
      // 
      tChart4.Axes.Left.Labels.Font.Bold = false;
      // 
      // 
      // 
      tChart4.Axes.Left.Labels.Font.Brush.Color = Color.FromArgb((int)(byte)255, (int)(byte)255, (int)(byte)255);
      tChart4.Axes.Left.Labels.Font.Brush.Solid = true;
      tChart4.Axes.Left.Labels.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart4.Axes.Left.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart4.Axes.Left.Labels.Font.Shadow.Brush.Solid = true;
      tChart4.Axes.Left.Labels.Font.Shadow.Brush.Visible = true;
      tChart4.Axes.Left.Labels.Font.Size = 8;
      tChart4.Axes.Left.Labels.Font.SizeFloat = 8F;
      tChart4.Axes.Left.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart4.Axes.Left.Labels.ImageBevel.Brush.Color = Color.LightGray;
      tChart4.Axes.Left.Labels.ImageBevel.Brush.Solid = true;
      tChart4.Axes.Left.Labels.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart4.Axes.Left.Labels.Shadow.Brush.Color = Color.DarkGray;
      tChart4.Axes.Left.Labels.Shadow.Brush.Solid = true;
      tChart4.Axes.Left.Labels.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart4.Axes.Left.Title.Brush.Color = Color.Silver;
      tChart4.Axes.Left.Title.Brush.Solid = true;
      tChart4.Axes.Left.Title.Brush.Visible = true;
      // 
      // 
      // 
      tChart4.Axes.Left.Title.Font.Bold = false;
      // 
      // 
      // 
      tChart4.Axes.Left.Title.Font.Brush.Color = Color.FromArgb((int)(byte)0, (int)(byte)0, (int)(byte)0);
      tChart4.Axes.Left.Title.Font.Brush.Solid = true;
      tChart4.Axes.Left.Title.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart4.Axes.Left.Title.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart4.Axes.Left.Title.Font.Shadow.Brush.Solid = true;
      tChart4.Axes.Left.Title.Font.Shadow.Brush.Visible = true;
      tChart4.Axes.Left.Title.Font.Size = 8;
      tChart4.Axes.Left.Title.Font.SizeFloat = 8F;
      tChart4.Axes.Left.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart4.Axes.Left.Title.ImageBevel.Brush.Color = Color.LightGray;
      tChart4.Axes.Left.Title.ImageBevel.Brush.Solid = true;
      tChart4.Axes.Left.Title.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart4.Axes.Left.Title.Shadow.Brush.Color = Color.DarkGray;
      tChart4.Axes.Left.Title.Shadow.Brush.Solid = true;
      tChart4.Axes.Left.Title.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      tChart4.Axes.Right.Labels.Brush.Color = Color.White;
      tChart4.Axes.Right.Labels.Brush.Solid = true;
      tChart4.Axes.Right.Labels.Brush.Visible = true;
      // 
      // 
      // 
      tChart4.Axes.Right.Labels.Font.Bold = false;
      // 
      // 
      // 
      tChart4.Axes.Right.Labels.Font.Brush.Color = Color.FromArgb((int)(byte)255, (int)(byte)255, (int)(byte)255);
      tChart4.Axes.Right.Labels.Font.Brush.Solid = true;
      tChart4.Axes.Right.Labels.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart4.Axes.Right.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart4.Axes.Right.Labels.Font.Shadow.Brush.Solid = true;
      tChart4.Axes.Right.Labels.Font.Shadow.Brush.Visible = true;
      tChart4.Axes.Right.Labels.Font.Size = 8;
      tChart4.Axes.Right.Labels.Font.SizeFloat = 8F;
      tChart4.Axes.Right.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart4.Axes.Right.Labels.ImageBevel.Brush.Color = Color.LightGray;
      tChart4.Axes.Right.Labels.ImageBevel.Brush.Solid = true;
      tChart4.Axes.Right.Labels.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart4.Axes.Right.Labels.Shadow.Brush.Color = Color.DarkGray;
      tChart4.Axes.Right.Labels.Shadow.Brush.Solid = true;
      tChart4.Axes.Right.Labels.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart4.Axes.Right.Title.Brush.Color = Color.Silver;
      tChart4.Axes.Right.Title.Brush.Solid = true;
      tChart4.Axes.Right.Title.Brush.Visible = true;
      // 
      // 
      // 
      tChart4.Axes.Right.Title.Font.Bold = false;
      // 
      // 
      // 
      tChart4.Axes.Right.Title.Font.Brush.Color = Color.FromArgb((int)(byte)0, (int)(byte)0, (int)(byte)0);
      tChart4.Axes.Right.Title.Font.Brush.Solid = true;
      tChart4.Axes.Right.Title.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart4.Axes.Right.Title.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart4.Axes.Right.Title.Font.Shadow.Brush.Solid = true;
      tChart4.Axes.Right.Title.Font.Shadow.Brush.Visible = true;
      tChart4.Axes.Right.Title.Font.Size = 8;
      tChart4.Axes.Right.Title.Font.SizeFloat = 8F;
      tChart4.Axes.Right.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart4.Axes.Right.Title.ImageBevel.Brush.Color = Color.LightGray;
      tChart4.Axes.Right.Title.ImageBevel.Brush.Solid = true;
      tChart4.Axes.Right.Title.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart4.Axes.Right.Title.Shadow.Brush.Color = Color.DarkGray;
      tChart4.Axes.Right.Title.Shadow.Brush.Solid = true;
      tChart4.Axes.Right.Title.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      tChart4.Axes.Top.Labels.Brush.Color = Color.White;
      tChart4.Axes.Top.Labels.Brush.Solid = true;
      tChart4.Axes.Top.Labels.Brush.Visible = true;
      // 
      // 
      // 
      tChart4.Axes.Top.Labels.Font.Bold = false;
      // 
      // 
      // 
      tChart4.Axes.Top.Labels.Font.Brush.Color = Color.FromArgb((int)(byte)255, (int)(byte)255, (int)(byte)255);
      tChart4.Axes.Top.Labels.Font.Brush.Solid = true;
      tChart4.Axes.Top.Labels.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart4.Axes.Top.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart4.Axes.Top.Labels.Font.Shadow.Brush.Solid = true;
      tChart4.Axes.Top.Labels.Font.Shadow.Brush.Visible = true;
      tChart4.Axes.Top.Labels.Font.Size = 8;
      tChart4.Axes.Top.Labels.Font.SizeFloat = 8F;
      tChart4.Axes.Top.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart4.Axes.Top.Labels.ImageBevel.Brush.Color = Color.LightGray;
      tChart4.Axes.Top.Labels.ImageBevel.Brush.Solid = true;
      tChart4.Axes.Top.Labels.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart4.Axes.Top.Labels.Shadow.Brush.Color = Color.DarkGray;
      tChart4.Axes.Top.Labels.Shadow.Brush.Solid = true;
      tChart4.Axes.Top.Labels.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart4.Axes.Top.Title.Brush.Color = Color.Silver;
      tChart4.Axes.Top.Title.Brush.Solid = true;
      tChart4.Axes.Top.Title.Brush.Visible = true;
      // 
      // 
      // 
      tChart4.Axes.Top.Title.Font.Bold = false;
      // 
      // 
      // 
      tChart4.Axes.Top.Title.Font.Brush.Color = Color.FromArgb((int)(byte)0, (int)(byte)0, (int)(byte)0);
      tChart4.Axes.Top.Title.Font.Brush.Solid = true;
      tChart4.Axes.Top.Title.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart4.Axes.Top.Title.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart4.Axes.Top.Title.Font.Shadow.Brush.Solid = true;
      tChart4.Axes.Top.Title.Font.Shadow.Brush.Visible = true;
      tChart4.Axes.Top.Title.Font.Size = 8;
      tChart4.Axes.Top.Title.Font.SizeFloat = 8F;
      tChart4.Axes.Top.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart4.Axes.Top.Title.ImageBevel.Brush.Color = Color.LightGray;
      tChart4.Axes.Top.Title.ImageBevel.Brush.Solid = true;
      tChart4.Axes.Top.Title.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart4.Axes.Top.Title.Shadow.Brush.Color = Color.DarkGray;
      tChart4.Axes.Top.Title.Shadow.Brush.Solid = true;
      tChart4.Axes.Top.Title.Shadow.Brush.Visible = true;
      tChart4.Dock = DockStyle.Top;
      // 
      // 
      // 
      tChart4.Footer.Bottom = 176;
      // 
      // 
      // 
      tChart4.Footer.Brush.Color = Color.FromArgb((int)(byte)224, (int)(byte)224, (int)(byte)224);
      tChart4.Footer.Brush.Solid = true;
      tChart4.Footer.Brush.Visible = true;
      tChart4.Footer.CustomPosition = true;
      // 
      // 
      // 
      tChart4.Footer.Font.Bold = false;
      // 
      // 
      // 
      tChart4.Footer.Font.Brush.Color = Color.FromArgb((int)(byte)192, (int)(byte)192, (int)(byte)192);
      tChart4.Footer.Font.Brush.Solid = true;
      tChart4.Footer.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart4.Footer.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart4.Footer.Font.Shadow.Brush.Solid = true;
      tChart4.Footer.Font.Shadow.Brush.Visible = true;
      tChart4.Footer.Font.Size = 8;
      tChart4.Footer.Font.SizeFloat = 8F;
      tChart4.Footer.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart4.Footer.ImageBevel.Brush.Color = Color.LightGray;
      tChart4.Footer.ImageBevel.Brush.Solid = true;
      tChart4.Footer.ImageBevel.Brush.Visible = true;
      tChart4.Footer.Left = 6;
      tChart4.Footer.Lines = new string[]
  {
    "Oven 3"
  };
      tChart4.Footer.Right = 64;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart4.Footer.Shadow.Brush.Color = Color.DarkGray;
      tChart4.Footer.Shadow.Brush.Solid = true;
      tChart4.Footer.Shadow.Brush.Visible = true;
      tChart4.Footer.Top = 161;
      tChart4.Footer.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart4.Header.Brush.Color = Color.FromArgb((int)(byte)192, (int)(byte)192, (int)(byte)192);
      // 
      // 
      // 
      tChart4.Header.Brush.Gradient.SigmaFocus = 0F;
      tChart4.Header.Brush.Gradient.SigmaScale = 0F;
      tChart4.Header.Brush.Solid = true;
      tChart4.Header.Brush.Visible = true;
      // 
      // 
      // 
      tChart4.Header.Font.Bold = false;
      // 
      // 
      // 
      tChart4.Header.Font.Brush.Color = Color.FromArgb((int)(byte)255, (int)(byte)255, (int)(byte)255);
      tChart4.Header.Font.Brush.Solid = true;
      tChart4.Header.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart4.Header.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart4.Header.Font.Shadow.Brush.Solid = true;
      tChart4.Header.Font.Shadow.Brush.Visible = true;
      tChart4.Header.Font.Size = 8;
      tChart4.Header.Font.SizeFloat = 8F;
      tChart4.Header.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart4.Header.ImageBevel.Brush.Color = Color.LightGray;
      tChart4.Header.ImageBevel.Brush.Solid = true;
      tChart4.Header.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart4.Header.Shadow.Brush.Color = Color.FromArgb((int)(byte)169, (int)(byte)169, (int)(byte)169);
      tChart4.Header.Shadow.Brush.Solid = true;
      tChart4.Header.Shadow.Brush.Visible = true;
      tChart4.Header.Shadow.Height = 0;
      tChart4.Header.Shadow.Width = 0;
      tChart4.Header.Visible = false;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart4.Legend.Brush.Color = Color.White;
      // 
      // 
      // 
      tChart4.Legend.Brush.Gradient.SigmaFocus = 0F;
      tChart4.Legend.Brush.Gradient.SigmaScale = 0F;
      tChart4.Legend.Brush.Gradient.Visible = true;
      tChart4.Legend.Brush.Solid = true;
      tChart4.Legend.Brush.Visible = true;
      tChart4.Legend.CheckBoxes = false;
      tChart4.Legend.ClipText = false;
      // 
      // 
      // 
      tChart4.Legend.Font.Bold = false;
      // 
      // 
      // 
      tChart4.Legend.Font.Brush.Color = Color.FromArgb((int)(byte)255, (int)(byte)255, (int)(byte)255);
      tChart4.Legend.Font.Brush.Solid = true;
      tChart4.Legend.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart4.Legend.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart4.Legend.Font.Shadow.Brush.Solid = true;
      tChart4.Legend.Font.Shadow.Brush.Visible = true;
      tChart4.Legend.Font.Size = 8;
      tChart4.Legend.Font.SizeFloat = 8F;
      tChart4.Legend.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart4.Legend.ImageBevel.Brush.Color = Color.LightGray;
      tChart4.Legend.ImageBevel.Brush.Solid = true;
      tChart4.Legend.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart4.Legend.Shadow.Brush.Color = Color.FromArgb((int)(byte)0, (int)(byte)0, (int)(byte)0);
      tChart4.Legend.Shadow.Brush.Solid = true;
      tChart4.Legend.Shadow.Brush.Visible = true;
      tChart4.Legend.Shadow.Width = 0;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      tChart4.Legend.Symbol.Shadow.Brush.Color = Color.DarkGray;
      tChart4.Legend.Symbol.Shadow.Brush.Solid = true;
      tChart4.Legend.Symbol.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart4.Legend.Title.Brush.Color = Color.White;
      tChart4.Legend.Title.Brush.Solid = true;
      tChart4.Legend.Title.Brush.Visible = true;
      // 
      // 
      // 
      tChart4.Legend.Title.Font.Bold = true;
      // 
      // 
      // 
      tChart4.Legend.Title.Font.Brush.Color = Color.Black;
      tChart4.Legend.Title.Font.Brush.Solid = true;
      tChart4.Legend.Title.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart4.Legend.Title.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart4.Legend.Title.Font.Shadow.Brush.Solid = true;
      tChart4.Legend.Title.Font.Shadow.Brush.Visible = true;
      tChart4.Legend.Title.Font.Size = 8;
      tChart4.Legend.Title.Font.SizeFloat = 8F;
      tChart4.Legend.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Bold;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart4.Legend.Title.ImageBevel.Brush.Color = Color.LightGray;
      tChart4.Legend.Title.ImageBevel.Brush.Solid = true;
      tChart4.Legend.Title.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart4.Legend.Title.Shadow.Brush.Color = Color.DarkGray;
      tChart4.Legend.Title.Shadow.Brush.Solid = true;
      tChart4.Legend.Title.Shadow.Brush.Visible = true;
      tChart4.Legend.Visible = false;
      tChart4.Location = new Point(0, 365);
      tChart4.Name = "tChart4";
      // 
      // 
      // 
      // 
      // 
      // 
      tChart4.Panel.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.Raised;
      // 
      // 
      // 
      tChart4.Panel.Brush.Color = Color.FromArgb((int)(byte)240, (int)(byte)240, (int)(byte)240);
      // 
      // 
      // 
      tChart4.Panel.Brush.Gradient.EndColor = Color.FromArgb((int)(byte)70, (int)(byte)70, (int)(byte)70);
      tChart4.Panel.Brush.Gradient.MiddleColor = Color.FromArgb((int)(byte)0, (int)(byte)0, (int)(byte)0, (int)(byte)0);
      tChart4.Panel.Brush.Gradient.SigmaFocus = 0F;
      tChart4.Panel.Brush.Gradient.SigmaScale = 0F;
      tChart4.Panel.Brush.Gradient.StartColor = Color.FromArgb((int)(byte)70, (int)(byte)70, (int)(byte)70);
      tChart4.Panel.Brush.Gradient.UseMiddle = false;
      tChart4.Panel.Brush.Gradient.Visible = true;
      tChart4.Panel.Brush.Solid = true;
      tChart4.Panel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart4.Panel.ImageBevel.Brush.Color = Color.LightGray;
      tChart4.Panel.ImageBevel.Brush.Solid = true;
      tChart4.Panel.ImageBevel.Brush.Visible = true;
      tChart4.Panel.MarginBottom = 2D;
      tChart4.Panel.MarginLeft = 7D;
      tChart4.Panel.MarginRight = 7D;
      tChart4.Panel.MarginTop = 6D;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart4.Panel.Shadow.Brush.Color = Color.DarkGray;
      tChart4.Panel.Shadow.Brush.Solid = true;
      tChart4.Panel.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      margins7.Bottom = 100;
      margins7.Left = 100;
      margins7.Right = 100;
      margins7.Top = 100;
      tChart4.Printer.Margins = margins7;
      tChart4.Series.Add(donut3);
      tChart4.Size = new Size(195, 182);
      // 
      // 
      // 
      // 
      // 
      // 
      tChart4.SubFooter.Brush.Color = Color.Silver;
      tChart4.SubFooter.Brush.Solid = true;
      tChart4.SubFooter.Brush.Visible = true;
      // 
      // 
      // 
      tChart4.SubFooter.Font.Bold = false;
      // 
      // 
      // 
      tChart4.SubFooter.Font.Brush.Color = Color.Red;
      tChart4.SubFooter.Font.Brush.Solid = true;
      tChart4.SubFooter.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart4.SubFooter.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart4.SubFooter.Font.Shadow.Brush.Solid = true;
      tChart4.SubFooter.Font.Shadow.Brush.Visible = true;
      tChart4.SubFooter.Font.Size = 8;
      tChart4.SubFooter.Font.SizeFloat = 8F;
      tChart4.SubFooter.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart4.SubFooter.ImageBevel.Brush.Color = Color.LightGray;
      tChart4.SubFooter.ImageBevel.Brush.Solid = true;
      tChart4.SubFooter.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart4.SubFooter.Shadow.Brush.Color = Color.DarkGray;
      tChart4.SubFooter.Shadow.Brush.Solid = true;
      tChart4.SubFooter.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart4.SubHeader.Brush.Color = Color.FromArgb((int)(byte)192, (int)(byte)192, (int)(byte)192);
      tChart4.SubHeader.Brush.Solid = true;
      tChart4.SubHeader.Brush.Visible = true;
      // 
      // 
      // 
      tChart4.SubHeader.Font.Bold = false;
      // 
      // 
      // 
      tChart4.SubHeader.Font.Brush.Color = Color.FromArgb((int)(byte)128, (int)(byte)128, (int)(byte)128);
      tChart4.SubHeader.Font.Brush.Solid = true;
      tChart4.SubHeader.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart4.SubHeader.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart4.SubHeader.Font.Shadow.Brush.Solid = true;
      tChart4.SubHeader.Font.Shadow.Brush.Visible = true;
      tChart4.SubHeader.Font.Size = 12;
      tChart4.SubHeader.Font.SizeFloat = 12F;
      tChart4.SubHeader.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart4.SubHeader.ImageBevel.Brush.Color = Color.LightGray;
      tChart4.SubHeader.ImageBevel.Brush.Solid = true;
      tChart4.SubHeader.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart4.SubHeader.Shadow.Brush.Color = Color.FromArgb((int)(byte)169, (int)(byte)169, (int)(byte)169);
      tChart4.SubHeader.Shadow.Brush.Solid = true;
      tChart4.SubHeader.Shadow.Brush.Visible = true;
      tChart4.TabIndex = 3;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      tChart4.Walls.Back.Brush.Color = Color.Silver;
      // 
      // 
      // 
      tChart4.Walls.Back.Brush.Gradient.EndColor = Color.FromArgb((int)(byte)120, (int)(byte)120, (int)(byte)120);
      tChart4.Walls.Back.Brush.Gradient.StartColor = Color.FromArgb((int)(byte)70, (int)(byte)70, (int)(byte)70);
      tChart4.Walls.Back.Brush.Solid = true;
      tChart4.Walls.Back.Brush.Visible = false;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart4.Walls.Back.ImageBevel.Brush.Color = Color.LightGray;
      tChart4.Walls.Back.ImageBevel.Brush.Solid = true;
      tChart4.Walls.Back.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart4.Walls.Back.Shadow.Brush.Color = Color.DarkGray;
      tChart4.Walls.Back.Shadow.Brush.Solid = true;
      tChart4.Walls.Back.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart4.Walls.Bottom.Brush.Color = Color.White;
      // 
      // 
      // 
      tChart4.Walls.Bottom.Brush.Gradient.SigmaFocus = 0F;
      tChart4.Walls.Bottom.Brush.Gradient.SigmaScale = 0F;
      tChart4.Walls.Bottom.Brush.Solid = true;
      tChart4.Walls.Bottom.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart4.Walls.Bottom.ImageBevel.Brush.Color = Color.LightGray;
      tChart4.Walls.Bottom.ImageBevel.Brush.Solid = true;
      tChart4.Walls.Bottom.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart4.Walls.Bottom.Shadow.Brush.Color = Color.DarkGray;
      tChart4.Walls.Bottom.Shadow.Brush.Solid = true;
      tChart4.Walls.Bottom.Shadow.Brush.Visible = true;
      tChart4.Walls.Bottom.Visible = false;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart4.Walls.Left.Brush.Color = Color.LightYellow;
      // 
      // 
      // 
      tChart4.Walls.Left.Brush.Gradient.SigmaFocus = 0F;
      tChart4.Walls.Left.Brush.Gradient.SigmaScale = 0F;
      tChart4.Walls.Left.Brush.Solid = true;
      tChart4.Walls.Left.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart4.Walls.Left.ImageBevel.Brush.Color = Color.LightGray;
      tChart4.Walls.Left.ImageBevel.Brush.Solid = true;
      tChart4.Walls.Left.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart4.Walls.Left.Shadow.Brush.Color = Color.DarkGray;
      tChart4.Walls.Left.Shadow.Brush.Solid = true;
      tChart4.Walls.Left.Shadow.Brush.Visible = true;
      tChart4.Walls.Left.Visible = false;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart4.Walls.Right.Brush.Color = Color.FromArgb((int)(byte)192, (int)(byte)192, (int)(byte)192);
      // 
      // 
      // 
      tChart4.Walls.Right.Brush.Gradient.SigmaFocus = 0F;
      tChart4.Walls.Right.Brush.Gradient.SigmaScale = 0F;
      tChart4.Walls.Right.Brush.Solid = true;
      tChart4.Walls.Right.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart4.Walls.Right.ImageBevel.Brush.Color = Color.LightGray;
      tChart4.Walls.Right.ImageBevel.Brush.Solid = true;
      tChart4.Walls.Right.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart4.Walls.Right.Shadow.Brush.Color = Color.DarkGray;
      tChart4.Walls.Right.Shadow.Brush.Solid = true;
      tChart4.Walls.Right.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart4.Zoom.Brush.Color = Color.FromArgb((int)(byte)127, (int)(byte)0, (int)(byte)0, (int)(byte)255);
      tChart4.Zoom.Brush.Solid = true;
      tChart4.Zoom.Brush.Visible = false;
      tChart4.AfterDraw += (this.tChart4_AfterDraw);
      // 
      // donut3
      // 
      // 
      // 
      // 
      donut3.Brush.Color = Color.FromArgb((int)(byte)255, (int)(byte)243, (int)(byte)144);
      donut3.Brush.Solid = true;
      donut3.Brush.Visible = true;
      donut3.Circled = true;
      donut3.Color = Color.FromArgb((int)(byte)119, (int)(byte)153, (int)(byte)214);
      donut3.Cursor = cursor1;
      // 
      // 
      // 
      donut3.Frame.Circled = true;
      donut3.Frame.FrameElementPercents = new double[]
  {
    25D,
    60D,
    15D
  };
      // 
      // 
      // 
      donut3.Frame.InnerBand.Color = Color.Gray;
      donut3.Frame.InnerBand.Solid = true;
      donut3.Frame.InnerBand.Visible = true;
      // 
      // 
      // 
      donut3.Frame.OuterBand.Color = Color.Gray;
      // 
      // 
      // 
      donut3.Frame.OuterBand.Gradient.Visible = true;
      donut3.Frame.OuterBand.Solid = true;
      donut3.Frame.OuterBand.Visible = true;
      donut3.LabelMember = "Labels";
      // 
      // 
      // 
      // 
      // 
      // 
      donut3.Legend.Brush.Color = Color.White;
      donut3.Legend.Brush.Solid = true;
      donut3.Legend.Brush.Visible = true;
      // 
      // 
      // 
      donut3.Legend.Font.Bold = false;
      // 
      // 
      // 
      donut3.Legend.Font.Brush.Color = Color.Black;
      donut3.Legend.Font.Brush.Solid = true;
      donut3.Legend.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      donut3.Legend.Font.Shadow.Brush.Color = Color.DarkGray;
      donut3.Legend.Font.Shadow.Brush.Solid = true;
      donut3.Legend.Font.Shadow.Brush.Visible = true;
      donut3.Legend.Font.Size = 8;
      donut3.Legend.Font.SizeFloat = 8F;
      donut3.Legend.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      donut3.Legend.ImageBevel.Brush.Color = Color.LightGray;
      donut3.Legend.ImageBevel.Brush.Solid = true;
      donut3.Legend.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      donut3.Legend.Shadow.Brush.Color = Color.DarkGray;
      donut3.Legend.Shadow.Brush.Solid = true;
      donut3.Legend.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      donut3.Marks.Arrow.Color = Color.Black;
      // 
      // 
      // 
      donut3.Marks.Brush.Color = Color.FromArgb((int)(byte)255, (int)(byte)255, (int)(byte)255);
      donut3.Marks.Brush.Solid = true;
      donut3.Marks.Brush.Visible = true;
      // 
      // 
      // 
      donut3.Marks.Font.Bold = false;
      // 
      // 
      // 
      donut3.Marks.Font.Brush.Color = Color.FromArgb((int)(byte)0, (int)(byte)0, (int)(byte)0);
      donut3.Marks.Font.Brush.Solid = true;
      donut3.Marks.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      donut3.Marks.Font.Shadow.Brush.Color = Color.DarkGray;
      donut3.Marks.Font.Shadow.Brush.Solid = true;
      donut3.Marks.Font.Shadow.Brush.Visible = true;
      donut3.Marks.Font.Size = 8;
      donut3.Marks.Font.SizeFloat = 8F;
      donut3.Marks.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      donut3.Marks.ImageBevel.Brush.Color = Color.LightGray;
      donut3.Marks.ImageBevel.Brush.Solid = true;
      donut3.Marks.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      donut3.Marks.Shadow.Brush.Color = Color.FromArgb((int)(byte)128, (int)(byte)128, (int)(byte)128);
      donut3.Marks.Shadow.Brush.Solid = true;
      donut3.Marks.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      donut3.Marks.Symbol.Brush.Color = Color.White;
      donut3.Marks.Symbol.Brush.Solid = true;
      donut3.Marks.Symbol.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      donut3.Marks.Symbol.ImageBevel.Brush.Color = Color.LightGray;
      donut3.Marks.Symbol.ImageBevel.Brush.Solid = true;
      donut3.Marks.Symbol.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      donut3.Marks.Symbol.Shadow.Brush.Color = Color.DarkGray;
      donut3.Marks.Symbol.Shadow.Brush.Solid = true;
      donut3.Marks.Symbol.Shadow.Brush.Visible = true;
      donut3.Marks.Visible = false;
      // 
      // 
      // 
      donut3.MarksPie.InsideSlice = false;
      donut3.MarksPie.LegSize = 0;
      donut3.MarksPie.Rotated = false;
      donut3.MarksPie.RotateStyle = Steema.TeeChart.Styles.Pie.MarksRotateStyle.Radial;
      donut3.MarksPie.VertCenter = false;
      donut3.MultiPie = Steema.TeeChart.Styles.MultiPies.Automatic;
      // 
      // 
      // 
      donut3.OtherSlice.Color = Color.Empty;
      donut3.OtherSlice.Style = Steema.TeeChart.Styles.PieOtherStyles.None;
      donut3.OtherSlice.Text = "";
      donut3.OtherSlice.Value = 0D;
      // 
      // 
      // 
      // 
      // 
      // 
      donut3.Shadow.Brush.Color = Color.DarkGray;
      donut3.Shadow.Brush.Solid = true;
      donut3.Shadow.Brush.Visible = true;
      donut3.Title = "donut1";
      donut3.UniqueCustomRadius = true;
      // 
      // 
      // 
      donut3.XValues.DataMember = "Angle";
      donut3.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
      donut3.XValues.Value = new double[]
  {
    0D,
    1D,
    2D,
    3D,
    4D,
    5D,
    6D,
    7D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
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
      donut3.YValues.DataMember = "Pie";
      donut3.YValues.Value = new double[]
  {
    494D,
    130D,
    655D,
    667D,
    370D,
    925D,
    997D,
    592D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
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
      // tChart3
      // 
      // 
      // 
      // 
      tChart3.Aspect.ColorPaletteIndex = -1;
      tChart3.Aspect.Elevation = 315;
      tChart3.Aspect.ElevationFloat = 315D;
      tChart3.Aspect.Orthogonal = false;
      tChart3.Aspect.Perspective = 0;
      tChart3.Aspect.Rotation = 360;
      tChart3.Aspect.RotationFloat = 360D;
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
      tChart3.Axes.Bottom.Labels.Brush.Color = Color.White;
      tChart3.Axes.Bottom.Labels.Brush.Solid = true;
      tChart3.Axes.Bottom.Labels.Brush.Visible = true;
      // 
      // 
      // 
      tChart3.Axes.Bottom.Labels.Font.Bold = false;
      // 
      // 
      // 
      tChart3.Axes.Bottom.Labels.Font.Brush.Color = Color.FromArgb((int)(byte)255, (int)(byte)255, (int)(byte)255);
      tChart3.Axes.Bottom.Labels.Font.Brush.Solid = true;
      tChart3.Axes.Bottom.Labels.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart3.Axes.Bottom.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart3.Axes.Bottom.Labels.Font.Shadow.Brush.Solid = true;
      tChart3.Axes.Bottom.Labels.Font.Shadow.Brush.Visible = true;
      tChart3.Axes.Bottom.Labels.Font.Size = 8;
      tChart3.Axes.Bottom.Labels.Font.SizeFloat = 8F;
      tChart3.Axes.Bottom.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart3.Axes.Bottom.Labels.ImageBevel.Brush.Color = Color.LightGray;
      tChart3.Axes.Bottom.Labels.ImageBevel.Brush.Solid = true;
      tChart3.Axes.Bottom.Labels.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart3.Axes.Bottom.Labels.Shadow.Brush.Color = Color.DarkGray;
      tChart3.Axes.Bottom.Labels.Shadow.Brush.Solid = true;
      tChart3.Axes.Bottom.Labels.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart3.Axes.Bottom.Title.Brush.Color = Color.Silver;
      tChart3.Axes.Bottom.Title.Brush.Solid = true;
      tChart3.Axes.Bottom.Title.Brush.Visible = true;
      // 
      // 
      // 
      tChart3.Axes.Bottom.Title.Font.Bold = false;
      // 
      // 
      // 
      tChart3.Axes.Bottom.Title.Font.Brush.Color = Color.FromArgb((int)(byte)0, (int)(byte)0, (int)(byte)0);
      tChart3.Axes.Bottom.Title.Font.Brush.Solid = true;
      tChart3.Axes.Bottom.Title.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart3.Axes.Bottom.Title.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart3.Axes.Bottom.Title.Font.Shadow.Brush.Solid = true;
      tChart3.Axes.Bottom.Title.Font.Shadow.Brush.Visible = true;
      tChart3.Axes.Bottom.Title.Font.Size = 8;
      tChart3.Axes.Bottom.Title.Font.SizeFloat = 8F;
      tChart3.Axes.Bottom.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart3.Axes.Bottom.Title.ImageBevel.Brush.Color = Color.LightGray;
      tChart3.Axes.Bottom.Title.ImageBevel.Brush.Solid = true;
      tChart3.Axes.Bottom.Title.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart3.Axes.Bottom.Title.Shadow.Brush.Color = Color.DarkGray;
      tChart3.Axes.Bottom.Title.Shadow.Brush.Solid = true;
      tChart3.Axes.Bottom.Title.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      tChart3.Axes.Depth.Labels.Brush.Color = Color.White;
      tChart3.Axes.Depth.Labels.Brush.Solid = true;
      tChart3.Axes.Depth.Labels.Brush.Visible = true;
      // 
      // 
      // 
      tChart3.Axes.Depth.Labels.Font.Bold = false;
      // 
      // 
      // 
      tChart3.Axes.Depth.Labels.Font.Brush.Color = Color.FromArgb((int)(byte)255, (int)(byte)255, (int)(byte)255);
      tChart3.Axes.Depth.Labels.Font.Brush.Solid = true;
      tChart3.Axes.Depth.Labels.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart3.Axes.Depth.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart3.Axes.Depth.Labels.Font.Shadow.Brush.Solid = true;
      tChart3.Axes.Depth.Labels.Font.Shadow.Brush.Visible = true;
      tChart3.Axes.Depth.Labels.Font.Size = 8;
      tChart3.Axes.Depth.Labels.Font.SizeFloat = 8F;
      tChart3.Axes.Depth.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart3.Axes.Depth.Labels.ImageBevel.Brush.Color = Color.LightGray;
      tChart3.Axes.Depth.Labels.ImageBevel.Brush.Solid = true;
      tChart3.Axes.Depth.Labels.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart3.Axes.Depth.Labels.Shadow.Brush.Color = Color.DarkGray;
      tChart3.Axes.Depth.Labels.Shadow.Brush.Solid = true;
      tChart3.Axes.Depth.Labels.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart3.Axes.Depth.Title.Brush.Color = Color.Silver;
      tChart3.Axes.Depth.Title.Brush.Solid = true;
      tChart3.Axes.Depth.Title.Brush.Visible = true;
      // 
      // 
      // 
      tChart3.Axes.Depth.Title.Font.Bold = false;
      // 
      // 
      // 
      tChart3.Axes.Depth.Title.Font.Brush.Color = Color.FromArgb((int)(byte)0, (int)(byte)0, (int)(byte)0);
      tChart3.Axes.Depth.Title.Font.Brush.Solid = true;
      tChart3.Axes.Depth.Title.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart3.Axes.Depth.Title.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart3.Axes.Depth.Title.Font.Shadow.Brush.Solid = true;
      tChart3.Axes.Depth.Title.Font.Shadow.Brush.Visible = true;
      tChart3.Axes.Depth.Title.Font.Size = 8;
      tChart3.Axes.Depth.Title.Font.SizeFloat = 8F;
      tChart3.Axes.Depth.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart3.Axes.Depth.Title.ImageBevel.Brush.Color = Color.LightGray;
      tChart3.Axes.Depth.Title.ImageBevel.Brush.Solid = true;
      tChart3.Axes.Depth.Title.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart3.Axes.Depth.Title.Shadow.Brush.Color = Color.DarkGray;
      tChart3.Axes.Depth.Title.Shadow.Brush.Solid = true;
      tChart3.Axes.Depth.Title.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      tChart3.Axes.DepthTop.Labels.Brush.Color = Color.White;
      tChart3.Axes.DepthTop.Labels.Brush.Solid = true;
      tChart3.Axes.DepthTop.Labels.Brush.Visible = true;
      // 
      // 
      // 
      tChart3.Axes.DepthTop.Labels.Font.Bold = false;
      // 
      // 
      // 
      tChart3.Axes.DepthTop.Labels.Font.Brush.Color = Color.FromArgb((int)(byte)255, (int)(byte)255, (int)(byte)255);
      tChart3.Axes.DepthTop.Labels.Font.Brush.Solid = true;
      tChart3.Axes.DepthTop.Labels.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart3.Axes.DepthTop.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart3.Axes.DepthTop.Labels.Font.Shadow.Brush.Solid = true;
      tChart3.Axes.DepthTop.Labels.Font.Shadow.Brush.Visible = true;
      tChart3.Axes.DepthTop.Labels.Font.Size = 8;
      tChart3.Axes.DepthTop.Labels.Font.SizeFloat = 8F;
      tChart3.Axes.DepthTop.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart3.Axes.DepthTop.Labels.ImageBevel.Brush.Color = Color.LightGray;
      tChart3.Axes.DepthTop.Labels.ImageBevel.Brush.Solid = true;
      tChart3.Axes.DepthTop.Labels.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart3.Axes.DepthTop.Labels.Shadow.Brush.Color = Color.DarkGray;
      tChart3.Axes.DepthTop.Labels.Shadow.Brush.Solid = true;
      tChart3.Axes.DepthTop.Labels.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart3.Axes.DepthTop.Title.Brush.Color = Color.Silver;
      tChart3.Axes.DepthTop.Title.Brush.Solid = true;
      tChart3.Axes.DepthTop.Title.Brush.Visible = true;
      // 
      // 
      // 
      tChart3.Axes.DepthTop.Title.Font.Bold = false;
      // 
      // 
      // 
      tChart3.Axes.DepthTop.Title.Font.Brush.Color = Color.FromArgb((int)(byte)0, (int)(byte)0, (int)(byte)0);
      tChart3.Axes.DepthTop.Title.Font.Brush.Solid = true;
      tChart3.Axes.DepthTop.Title.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart3.Axes.DepthTop.Title.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart3.Axes.DepthTop.Title.Font.Shadow.Brush.Solid = true;
      tChart3.Axes.DepthTop.Title.Font.Shadow.Brush.Visible = true;
      tChart3.Axes.DepthTop.Title.Font.Size = 8;
      tChart3.Axes.DepthTop.Title.Font.SizeFloat = 8F;
      tChart3.Axes.DepthTop.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart3.Axes.DepthTop.Title.ImageBevel.Brush.Color = Color.LightGray;
      tChart3.Axes.DepthTop.Title.ImageBevel.Brush.Solid = true;
      tChart3.Axes.DepthTop.Title.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart3.Axes.DepthTop.Title.Shadow.Brush.Color = Color.DarkGray;
      tChart3.Axes.DepthTop.Title.Shadow.Brush.Solid = true;
      tChart3.Axes.DepthTop.Title.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      tChart3.Axes.Left.Labels.Brush.Color = Color.White;
      tChart3.Axes.Left.Labels.Brush.Solid = true;
      tChart3.Axes.Left.Labels.Brush.Visible = true;
      // 
      // 
      // 
      tChart3.Axes.Left.Labels.Font.Bold = false;
      // 
      // 
      // 
      tChart3.Axes.Left.Labels.Font.Brush.Color = Color.FromArgb((int)(byte)255, (int)(byte)255, (int)(byte)255);
      tChart3.Axes.Left.Labels.Font.Brush.Solid = true;
      tChart3.Axes.Left.Labels.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart3.Axes.Left.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart3.Axes.Left.Labels.Font.Shadow.Brush.Solid = true;
      tChart3.Axes.Left.Labels.Font.Shadow.Brush.Visible = true;
      tChart3.Axes.Left.Labels.Font.Size = 8;
      tChart3.Axes.Left.Labels.Font.SizeFloat = 8F;
      tChart3.Axes.Left.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart3.Axes.Left.Labels.ImageBevel.Brush.Color = Color.LightGray;
      tChart3.Axes.Left.Labels.ImageBevel.Brush.Solid = true;
      tChart3.Axes.Left.Labels.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart3.Axes.Left.Labels.Shadow.Brush.Color = Color.DarkGray;
      tChart3.Axes.Left.Labels.Shadow.Brush.Solid = true;
      tChart3.Axes.Left.Labels.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart3.Axes.Left.Title.Brush.Color = Color.Silver;
      tChart3.Axes.Left.Title.Brush.Solid = true;
      tChart3.Axes.Left.Title.Brush.Visible = true;
      // 
      // 
      // 
      tChart3.Axes.Left.Title.Font.Bold = false;
      // 
      // 
      // 
      tChart3.Axes.Left.Title.Font.Brush.Color = Color.FromArgb((int)(byte)0, (int)(byte)0, (int)(byte)0);
      tChart3.Axes.Left.Title.Font.Brush.Solid = true;
      tChart3.Axes.Left.Title.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart3.Axes.Left.Title.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart3.Axes.Left.Title.Font.Shadow.Brush.Solid = true;
      tChart3.Axes.Left.Title.Font.Shadow.Brush.Visible = true;
      tChart3.Axes.Left.Title.Font.Size = 8;
      tChart3.Axes.Left.Title.Font.SizeFloat = 8F;
      tChart3.Axes.Left.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart3.Axes.Left.Title.ImageBevel.Brush.Color = Color.LightGray;
      tChart3.Axes.Left.Title.ImageBevel.Brush.Solid = true;
      tChart3.Axes.Left.Title.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart3.Axes.Left.Title.Shadow.Brush.Color = Color.DarkGray;
      tChart3.Axes.Left.Title.Shadow.Brush.Solid = true;
      tChart3.Axes.Left.Title.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      tChart3.Axes.Right.Labels.Brush.Color = Color.White;
      tChart3.Axes.Right.Labels.Brush.Solid = true;
      tChart3.Axes.Right.Labels.Brush.Visible = true;
      // 
      // 
      // 
      tChart3.Axes.Right.Labels.Font.Bold = false;
      // 
      // 
      // 
      tChart3.Axes.Right.Labels.Font.Brush.Color = Color.FromArgb((int)(byte)255, (int)(byte)255, (int)(byte)255);
      tChart3.Axes.Right.Labels.Font.Brush.Solid = true;
      tChart3.Axes.Right.Labels.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart3.Axes.Right.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart3.Axes.Right.Labels.Font.Shadow.Brush.Solid = true;
      tChart3.Axes.Right.Labels.Font.Shadow.Brush.Visible = true;
      tChart3.Axes.Right.Labels.Font.Size = 8;
      tChart3.Axes.Right.Labels.Font.SizeFloat = 8F;
      tChart3.Axes.Right.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart3.Axes.Right.Labels.ImageBevel.Brush.Color = Color.LightGray;
      tChart3.Axes.Right.Labels.ImageBevel.Brush.Solid = true;
      tChart3.Axes.Right.Labels.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart3.Axes.Right.Labels.Shadow.Brush.Color = Color.DarkGray;
      tChart3.Axes.Right.Labels.Shadow.Brush.Solid = true;
      tChart3.Axes.Right.Labels.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart3.Axes.Right.Title.Brush.Color = Color.Silver;
      tChart3.Axes.Right.Title.Brush.Solid = true;
      tChart3.Axes.Right.Title.Brush.Visible = true;
      // 
      // 
      // 
      tChart3.Axes.Right.Title.Font.Bold = false;
      // 
      // 
      // 
      tChart3.Axes.Right.Title.Font.Brush.Color = Color.FromArgb((int)(byte)0, (int)(byte)0, (int)(byte)0);
      tChart3.Axes.Right.Title.Font.Brush.Solid = true;
      tChart3.Axes.Right.Title.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart3.Axes.Right.Title.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart3.Axes.Right.Title.Font.Shadow.Brush.Solid = true;
      tChart3.Axes.Right.Title.Font.Shadow.Brush.Visible = true;
      tChart3.Axes.Right.Title.Font.Size = 8;
      tChart3.Axes.Right.Title.Font.SizeFloat = 8F;
      tChart3.Axes.Right.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart3.Axes.Right.Title.ImageBevel.Brush.Color = Color.LightGray;
      tChart3.Axes.Right.Title.ImageBevel.Brush.Solid = true;
      tChart3.Axes.Right.Title.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart3.Axes.Right.Title.Shadow.Brush.Color = Color.DarkGray;
      tChart3.Axes.Right.Title.Shadow.Brush.Solid = true;
      tChart3.Axes.Right.Title.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      tChart3.Axes.Top.Labels.Brush.Color = Color.White;
      tChart3.Axes.Top.Labels.Brush.Solid = true;
      tChart3.Axes.Top.Labels.Brush.Visible = true;
      // 
      // 
      // 
      tChart3.Axes.Top.Labels.Font.Bold = false;
      // 
      // 
      // 
      tChart3.Axes.Top.Labels.Font.Brush.Color = Color.FromArgb((int)(byte)255, (int)(byte)255, (int)(byte)255);
      tChart3.Axes.Top.Labels.Font.Brush.Solid = true;
      tChart3.Axes.Top.Labels.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart3.Axes.Top.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart3.Axes.Top.Labels.Font.Shadow.Brush.Solid = true;
      tChart3.Axes.Top.Labels.Font.Shadow.Brush.Visible = true;
      tChart3.Axes.Top.Labels.Font.Size = 8;
      tChart3.Axes.Top.Labels.Font.SizeFloat = 8F;
      tChart3.Axes.Top.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart3.Axes.Top.Labels.ImageBevel.Brush.Color = Color.LightGray;
      tChart3.Axes.Top.Labels.ImageBevel.Brush.Solid = true;
      tChart3.Axes.Top.Labels.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart3.Axes.Top.Labels.Shadow.Brush.Color = Color.DarkGray;
      tChart3.Axes.Top.Labels.Shadow.Brush.Solid = true;
      tChart3.Axes.Top.Labels.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart3.Axes.Top.Title.Brush.Color = Color.Silver;
      tChart3.Axes.Top.Title.Brush.Solid = true;
      tChart3.Axes.Top.Title.Brush.Visible = true;
      // 
      // 
      // 
      tChart3.Axes.Top.Title.Font.Bold = false;
      // 
      // 
      // 
      tChart3.Axes.Top.Title.Font.Brush.Color = Color.FromArgb((int)(byte)0, (int)(byte)0, (int)(byte)0);
      tChart3.Axes.Top.Title.Font.Brush.Solid = true;
      tChart3.Axes.Top.Title.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart3.Axes.Top.Title.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart3.Axes.Top.Title.Font.Shadow.Brush.Solid = true;
      tChart3.Axes.Top.Title.Font.Shadow.Brush.Visible = true;
      tChart3.Axes.Top.Title.Font.Size = 8;
      tChart3.Axes.Top.Title.Font.SizeFloat = 8F;
      tChart3.Axes.Top.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart3.Axes.Top.Title.ImageBevel.Brush.Color = Color.LightGray;
      tChart3.Axes.Top.Title.ImageBevel.Brush.Solid = true;
      tChart3.Axes.Top.Title.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart3.Axes.Top.Title.Shadow.Brush.Color = Color.DarkGray;
      tChart3.Axes.Top.Title.Shadow.Brush.Solid = true;
      tChart3.Axes.Top.Title.Shadow.Brush.Visible = true;
      tChart3.Dock = DockStyle.Top;
      // 
      // 
      // 
      tChart3.Footer.Bottom = 176;
      // 
      // 
      // 
      tChart3.Footer.Brush.Color = Color.Silver;
      tChart3.Footer.Brush.Solid = true;
      tChart3.Footer.Brush.Visible = true;
      tChart3.Footer.CustomPosition = true;
      // 
      // 
      // 
      tChart3.Footer.Font.Bold = false;
      // 
      // 
      // 
      tChart3.Footer.Font.Brush.Color = Color.FromArgb((int)(byte)192, (int)(byte)192, (int)(byte)192);
      tChart3.Footer.Font.Brush.Solid = true;
      tChart3.Footer.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart3.Footer.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart3.Footer.Font.Shadow.Brush.Solid = true;
      tChart3.Footer.Font.Shadow.Brush.Visible = true;
      tChart3.Footer.Font.Size = 8;
      tChart3.Footer.Font.SizeFloat = 8F;
      tChart3.Footer.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart3.Footer.ImageBevel.Brush.Color = Color.LightGray;
      tChart3.Footer.ImageBevel.Brush.Solid = true;
      tChart3.Footer.ImageBevel.Brush.Visible = true;
      tChart3.Footer.Left = 6;
      tChart3.Footer.Lines = new string[]
  {
    "Oven 2"
  };
      tChart3.Footer.Right = 64;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart3.Footer.Shadow.Brush.Color = Color.DarkGray;
      tChart3.Footer.Shadow.Brush.Solid = true;
      tChart3.Footer.Shadow.Brush.Visible = true;
      tChart3.Footer.Top = 161;
      tChart3.Footer.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart3.Header.Brush.Color = Color.FromArgb((int)(byte)192, (int)(byte)192, (int)(byte)192);
      // 
      // 
      // 
      tChart3.Header.Brush.Gradient.SigmaFocus = 0F;
      tChart3.Header.Brush.Gradient.SigmaScale = 0F;
      tChart3.Header.Brush.Solid = true;
      tChart3.Header.Brush.Visible = true;
      // 
      // 
      // 
      tChart3.Header.Font.Bold = false;
      // 
      // 
      // 
      tChart3.Header.Font.Brush.Color = Color.Silver;
      tChart3.Header.Font.Brush.Solid = true;
      tChart3.Header.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart3.Header.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart3.Header.Font.Shadow.Brush.Solid = true;
      tChart3.Header.Font.Shadow.Brush.Visible = true;
      tChart3.Header.Font.Size = 8;
      tChart3.Header.Font.SizeFloat = 8F;
      tChart3.Header.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart3.Header.ImageBevel.Brush.Color = Color.LightGray;
      tChart3.Header.ImageBevel.Brush.Solid = true;
      tChart3.Header.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart3.Header.Shadow.Brush.Color = Color.FromArgb((int)(byte)169, (int)(byte)169, (int)(byte)169);
      tChart3.Header.Shadow.Brush.Solid = true;
      tChart3.Header.Shadow.Brush.Visible = true;
      tChart3.Header.Shadow.Height = 0;
      tChart3.Header.Shadow.Width = 0;
      tChart3.Header.Visible = false;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart3.Legend.Brush.Color = Color.White;
      // 
      // 
      // 
      tChart3.Legend.Brush.Gradient.SigmaFocus = 0F;
      tChart3.Legend.Brush.Gradient.SigmaScale = 0F;
      tChart3.Legend.Brush.Gradient.Visible = true;
      tChart3.Legend.Brush.Solid = true;
      tChart3.Legend.Brush.Visible = true;
      tChart3.Legend.CheckBoxes = false;
      tChart3.Legend.ClipText = false;
      // 
      // 
      // 
      tChart3.Legend.Font.Bold = false;
      // 
      // 
      // 
      tChart3.Legend.Font.Brush.Color = Color.FromArgb((int)(byte)255, (int)(byte)255, (int)(byte)255);
      tChart3.Legend.Font.Brush.Solid = true;
      tChart3.Legend.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart3.Legend.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart3.Legend.Font.Shadow.Brush.Solid = true;
      tChart3.Legend.Font.Shadow.Brush.Visible = true;
      tChart3.Legend.Font.Size = 8;
      tChart3.Legend.Font.SizeFloat = 8F;
      tChart3.Legend.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart3.Legend.ImageBevel.Brush.Color = Color.LightGray;
      tChart3.Legend.ImageBevel.Brush.Solid = true;
      tChart3.Legend.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart3.Legend.Shadow.Brush.Color = Color.FromArgb((int)(byte)0, (int)(byte)0, (int)(byte)0);
      tChart3.Legend.Shadow.Brush.Solid = true;
      tChart3.Legend.Shadow.Brush.Visible = true;
      tChart3.Legend.Shadow.Width = 0;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      tChart3.Legend.Symbol.Shadow.Brush.Color = Color.DarkGray;
      tChart3.Legend.Symbol.Shadow.Brush.Solid = true;
      tChart3.Legend.Symbol.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart3.Legend.Title.Brush.Color = Color.White;
      tChart3.Legend.Title.Brush.Solid = true;
      tChart3.Legend.Title.Brush.Visible = true;
      // 
      // 
      // 
      tChart3.Legend.Title.Font.Bold = true;
      // 
      // 
      // 
      tChart3.Legend.Title.Font.Brush.Color = Color.Black;
      tChart3.Legend.Title.Font.Brush.Solid = true;
      tChart3.Legend.Title.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart3.Legend.Title.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart3.Legend.Title.Font.Shadow.Brush.Solid = true;
      tChart3.Legend.Title.Font.Shadow.Brush.Visible = true;
      tChart3.Legend.Title.Font.Size = 8;
      tChart3.Legend.Title.Font.SizeFloat = 8F;
      tChart3.Legend.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Bold;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart3.Legend.Title.ImageBevel.Brush.Color = Color.LightGray;
      tChart3.Legend.Title.ImageBevel.Brush.Solid = true;
      tChart3.Legend.Title.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart3.Legend.Title.Shadow.Brush.Color = Color.DarkGray;
      tChart3.Legend.Title.Shadow.Brush.Solid = true;
      tChart3.Legend.Title.Shadow.Brush.Visible = true;
      tChart3.Legend.Visible = false;
      tChart3.Location = new Point(0, 183);
      tChart3.Name = "tChart3";
      // 
      // 
      // 
      // 
      // 
      // 
      tChart3.Panel.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.Raised;
      // 
      // 
      // 
      tChart3.Panel.Brush.Color = Color.FromArgb((int)(byte)240, (int)(byte)240, (int)(byte)240);
      // 
      // 
      // 
      tChart3.Panel.Brush.Gradient.EndColor = Color.FromArgb((int)(byte)70, (int)(byte)70, (int)(byte)70);
      tChart3.Panel.Brush.Gradient.MiddleColor = Color.FromArgb((int)(byte)0, (int)(byte)0, (int)(byte)0, (int)(byte)0);
      tChart3.Panel.Brush.Gradient.SigmaFocus = 0F;
      tChart3.Panel.Brush.Gradient.SigmaScale = 0F;
      tChart3.Panel.Brush.Gradient.StartColor = Color.FromArgb((int)(byte)70, (int)(byte)70, (int)(byte)70);
      tChart3.Panel.Brush.Gradient.UseMiddle = false;
      tChart3.Panel.Brush.Gradient.Visible = true;
      tChart3.Panel.Brush.Solid = true;
      tChart3.Panel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart3.Panel.ImageBevel.Brush.Color = Color.LightGray;
      tChart3.Panel.ImageBevel.Brush.Solid = true;
      tChart3.Panel.ImageBevel.Brush.Visible = true;
      tChart3.Panel.MarginBottom = 2D;
      tChart3.Panel.MarginLeft = 7D;
      tChart3.Panel.MarginRight = 7D;
      tChart3.Panel.MarginTop = 6D;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart3.Panel.Shadow.Brush.Color = Color.DarkGray;
      tChart3.Panel.Shadow.Brush.Solid = true;
      tChart3.Panel.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      margins8.Bottom = 100;
      margins8.Left = 100;
      margins8.Right = 100;
      margins8.Top = 100;
      tChart3.Printer.Margins = margins8;
      tChart3.Series.Add(donut2);
      tChart3.Size = new Size(195, 182);
      // 
      // 
      // 
      // 
      // 
      // 
      tChart3.SubFooter.Brush.Color = Color.Silver;
      tChart3.SubFooter.Brush.Solid = true;
      tChart3.SubFooter.Brush.Visible = true;
      // 
      // 
      // 
      tChart3.SubFooter.Font.Bold = false;
      // 
      // 
      // 
      tChart3.SubFooter.Font.Brush.Color = Color.Red;
      tChart3.SubFooter.Font.Brush.Solid = true;
      tChart3.SubFooter.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart3.SubFooter.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart3.SubFooter.Font.Shadow.Brush.Solid = true;
      tChart3.SubFooter.Font.Shadow.Brush.Visible = true;
      tChart3.SubFooter.Font.Size = 8;
      tChart3.SubFooter.Font.SizeFloat = 8F;
      tChart3.SubFooter.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart3.SubFooter.ImageBevel.Brush.Color = Color.LightGray;
      tChart3.SubFooter.ImageBevel.Brush.Solid = true;
      tChart3.SubFooter.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart3.SubFooter.Shadow.Brush.Color = Color.DarkGray;
      tChart3.SubFooter.Shadow.Brush.Solid = true;
      tChart3.SubFooter.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart3.SubHeader.Brush.Color = Color.FromArgb((int)(byte)192, (int)(byte)192, (int)(byte)192);
      tChart3.SubHeader.Brush.Solid = true;
      tChart3.SubHeader.Brush.Visible = true;
      // 
      // 
      // 
      tChart3.SubHeader.Font.Bold = false;
      // 
      // 
      // 
      tChart3.SubHeader.Font.Brush.Color = Color.FromArgb((int)(byte)128, (int)(byte)128, (int)(byte)128);
      tChart3.SubHeader.Font.Brush.Solid = true;
      tChart3.SubHeader.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart3.SubHeader.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart3.SubHeader.Font.Shadow.Brush.Solid = true;
      tChart3.SubHeader.Font.Shadow.Brush.Visible = true;
      tChart3.SubHeader.Font.Size = 12;
      tChart3.SubHeader.Font.SizeFloat = 12F;
      tChart3.SubHeader.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart3.SubHeader.ImageBevel.Brush.Color = Color.LightGray;
      tChart3.SubHeader.ImageBevel.Brush.Solid = true;
      tChart3.SubHeader.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart3.SubHeader.Shadow.Brush.Color = Color.FromArgb((int)(byte)169, (int)(byte)169, (int)(byte)169);
      tChart3.SubHeader.Shadow.Brush.Solid = true;
      tChart3.SubHeader.Shadow.Brush.Visible = true;
      tChart3.TabIndex = 2;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      tChart3.Walls.Back.Brush.Color = Color.Silver;
      // 
      // 
      // 
      tChart3.Walls.Back.Brush.Gradient.EndColor = Color.FromArgb((int)(byte)120, (int)(byte)120, (int)(byte)120);
      tChart3.Walls.Back.Brush.Gradient.StartColor = Color.FromArgb((int)(byte)70, (int)(byte)70, (int)(byte)70);
      tChart3.Walls.Back.Brush.Solid = true;
      tChart3.Walls.Back.Brush.Visible = false;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart3.Walls.Back.ImageBevel.Brush.Color = Color.LightGray;
      tChart3.Walls.Back.ImageBevel.Brush.Solid = true;
      tChart3.Walls.Back.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart3.Walls.Back.Shadow.Brush.Color = Color.DarkGray;
      tChart3.Walls.Back.Shadow.Brush.Solid = true;
      tChart3.Walls.Back.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart3.Walls.Bottom.Brush.Color = Color.White;
      // 
      // 
      // 
      tChart3.Walls.Bottom.Brush.Gradient.SigmaFocus = 0F;
      tChart3.Walls.Bottom.Brush.Gradient.SigmaScale = 0F;
      tChart3.Walls.Bottom.Brush.Solid = true;
      tChart3.Walls.Bottom.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart3.Walls.Bottom.ImageBevel.Brush.Color = Color.LightGray;
      tChart3.Walls.Bottom.ImageBevel.Brush.Solid = true;
      tChart3.Walls.Bottom.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart3.Walls.Bottom.Shadow.Brush.Color = Color.DarkGray;
      tChart3.Walls.Bottom.Shadow.Brush.Solid = true;
      tChart3.Walls.Bottom.Shadow.Brush.Visible = true;
      tChart3.Walls.Bottom.Visible = false;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart3.Walls.Left.Brush.Color = Color.LightYellow;
      // 
      // 
      // 
      tChart3.Walls.Left.Brush.Gradient.SigmaFocus = 0F;
      tChart3.Walls.Left.Brush.Gradient.SigmaScale = 0F;
      tChart3.Walls.Left.Brush.Solid = true;
      tChart3.Walls.Left.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart3.Walls.Left.ImageBevel.Brush.Color = Color.LightGray;
      tChart3.Walls.Left.ImageBevel.Brush.Solid = true;
      tChart3.Walls.Left.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart3.Walls.Left.Shadow.Brush.Color = Color.DarkGray;
      tChart3.Walls.Left.Shadow.Brush.Solid = true;
      tChart3.Walls.Left.Shadow.Brush.Visible = true;
      tChart3.Walls.Left.Visible = false;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart3.Walls.Right.Brush.Color = Color.FromArgb((int)(byte)192, (int)(byte)192, (int)(byte)192);
      // 
      // 
      // 
      tChart3.Walls.Right.Brush.Gradient.SigmaFocus = 0F;
      tChart3.Walls.Right.Brush.Gradient.SigmaScale = 0F;
      tChart3.Walls.Right.Brush.Solid = true;
      tChart3.Walls.Right.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart3.Walls.Right.ImageBevel.Brush.Color = Color.LightGray;
      tChart3.Walls.Right.ImageBevel.Brush.Solid = true;
      tChart3.Walls.Right.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart3.Walls.Right.Shadow.Brush.Color = Color.DarkGray;
      tChart3.Walls.Right.Shadow.Brush.Solid = true;
      tChart3.Walls.Right.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart3.Zoom.Brush.Color = Color.FromArgb((int)(byte)127, (int)(byte)0, (int)(byte)0, (int)(byte)255);
      tChart3.Zoom.Brush.Solid = true;
      tChart3.Zoom.Brush.Visible = false;
      tChart3.AfterDraw += (this.tChart3_AfterDraw);
      // 
      // donut2
      // 
      // 
      // 
      // 
      donut2.Brush.Color = Color.FromArgb((int)(byte)255, (int)(byte)243, (int)(byte)144);
      donut2.Brush.Solid = true;
      donut2.Brush.Visible = true;
      donut2.Circled = true;
      donut2.Color = Color.FromArgb((int)(byte)119, (int)(byte)153, (int)(byte)214);
      donut2.Cursor = cursor1;
      // 
      // 
      // 
      donut2.Frame.Circled = true;
      donut2.Frame.FrameElementPercents = new double[]
  {
    25D,
    60D,
    15D
  };
      // 
      // 
      // 
      donut2.Frame.InnerBand.Color = Color.Gray;
      donut2.Frame.InnerBand.Solid = true;
      donut2.Frame.InnerBand.Visible = true;
      // 
      // 
      // 
      donut2.Frame.OuterBand.Color = Color.Gray;
      // 
      // 
      // 
      donut2.Frame.OuterBand.Gradient.Visible = true;
      donut2.Frame.OuterBand.Solid = true;
      donut2.Frame.OuterBand.Visible = true;
      donut2.LabelMember = "Labels";
      // 
      // 
      // 
      // 
      // 
      // 
      donut2.Legend.Brush.Color = Color.White;
      donut2.Legend.Brush.Solid = true;
      donut2.Legend.Brush.Visible = true;
      // 
      // 
      // 
      donut2.Legend.Font.Bold = false;
      // 
      // 
      // 
      donut2.Legend.Font.Brush.Color = Color.Black;
      donut2.Legend.Font.Brush.Solid = true;
      donut2.Legend.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      donut2.Legend.Font.Shadow.Brush.Color = Color.DarkGray;
      donut2.Legend.Font.Shadow.Brush.Solid = true;
      donut2.Legend.Font.Shadow.Brush.Visible = true;
      donut2.Legend.Font.Size = 8;
      donut2.Legend.Font.SizeFloat = 8F;
      donut2.Legend.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      donut2.Legend.ImageBevel.Brush.Color = Color.LightGray;
      donut2.Legend.ImageBevel.Brush.Solid = true;
      donut2.Legend.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      donut2.Legend.Shadow.Brush.Color = Color.DarkGray;
      donut2.Legend.Shadow.Brush.Solid = true;
      donut2.Legend.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      donut2.Marks.Arrow.Color = Color.Black;
      // 
      // 
      // 
      donut2.Marks.Brush.Color = Color.FromArgb((int)(byte)255, (int)(byte)255, (int)(byte)255);
      donut2.Marks.Brush.Solid = true;
      donut2.Marks.Brush.Visible = true;
      // 
      // 
      // 
      donut2.Marks.Font.Bold = false;
      // 
      // 
      // 
      donut2.Marks.Font.Brush.Color = Color.FromArgb((int)(byte)0, (int)(byte)0, (int)(byte)0);
      donut2.Marks.Font.Brush.Solid = true;
      donut2.Marks.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      donut2.Marks.Font.Shadow.Brush.Color = Color.DarkGray;
      donut2.Marks.Font.Shadow.Brush.Solid = true;
      donut2.Marks.Font.Shadow.Brush.Visible = true;
      donut2.Marks.Font.Size = 8;
      donut2.Marks.Font.SizeFloat = 8F;
      donut2.Marks.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      donut2.Marks.ImageBevel.Brush.Color = Color.LightGray;
      donut2.Marks.ImageBevel.Brush.Solid = true;
      donut2.Marks.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      donut2.Marks.Shadow.Brush.Color = Color.FromArgb((int)(byte)128, (int)(byte)128, (int)(byte)128);
      donut2.Marks.Shadow.Brush.Solid = true;
      donut2.Marks.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      donut2.Marks.Symbol.Brush.Color = Color.White;
      donut2.Marks.Symbol.Brush.Solid = true;
      donut2.Marks.Symbol.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      donut2.Marks.Symbol.ImageBevel.Brush.Color = Color.LightGray;
      donut2.Marks.Symbol.ImageBevel.Brush.Solid = true;
      donut2.Marks.Symbol.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      donut2.Marks.Symbol.Shadow.Brush.Color = Color.DarkGray;
      donut2.Marks.Symbol.Shadow.Brush.Solid = true;
      donut2.Marks.Symbol.Shadow.Brush.Visible = true;
      donut2.Marks.Visible = false;
      // 
      // 
      // 
      donut2.MarksPie.InsideSlice = false;
      donut2.MarksPie.LegSize = 0;
      donut2.MarksPie.Rotated = false;
      donut2.MarksPie.RotateStyle = Steema.TeeChart.Styles.Pie.MarksRotateStyle.Radial;
      donut2.MarksPie.VertCenter = false;
      donut2.MultiPie = Steema.TeeChart.Styles.MultiPies.Automatic;
      // 
      // 
      // 
      donut2.OtherSlice.Color = Color.Empty;
      donut2.OtherSlice.Style = Steema.TeeChart.Styles.PieOtherStyles.None;
      donut2.OtherSlice.Text = "";
      donut2.OtherSlice.Value = 0D;
      // 
      // 
      // 
      // 
      // 
      // 
      donut2.Shadow.Brush.Color = Color.DarkGray;
      donut2.Shadow.Brush.Solid = true;
      donut2.Shadow.Brush.Visible = true;
      donut2.Title = "donut1";
      donut2.UniqueCustomRadius = true;
      // 
      // 
      // 
      donut2.XValues.DataMember = "Angle";
      donut2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
      donut2.XValues.Value = new double[]
  {
    0D,
    1D,
    2D,
    3D,
    4D,
    5D,
    6D,
    7D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
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
      donut2.YValues.DataMember = "Pie";
      donut2.YValues.Value = new double[]
  {
    298D,
    462D,
    614D,
    871D,
    259D,
    428D,
    409D,
    480D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
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
      // tChart2
      // 
      // 
      // 
      // 
      tChart2.Aspect.ColorPaletteIndex = -1;
      tChart2.Aspect.Elevation = 315;
      tChart2.Aspect.ElevationFloat = 315D;
      tChart2.Aspect.Orthogonal = false;
      tChart2.Aspect.Perspective = 0;
      tChart2.Aspect.Rotation = 360;
      tChart2.Aspect.RotationFloat = 360D;
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
      tChart2.Axes.Bottom.Labels.Brush.Color = Color.White;
      tChart2.Axes.Bottom.Labels.Brush.Solid = true;
      tChart2.Axes.Bottom.Labels.Brush.Visible = true;
      // 
      // 
      // 
      tChart2.Axes.Bottom.Labels.Font.Bold = false;
      // 
      // 
      // 
      tChart2.Axes.Bottom.Labels.Font.Brush.Color = Color.FromArgb((int)(byte)255, (int)(byte)255, (int)(byte)255);
      tChart2.Axes.Bottom.Labels.Font.Brush.Solid = true;
      tChart2.Axes.Bottom.Labels.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart2.Axes.Bottom.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart2.Axes.Bottom.Labels.Font.Shadow.Brush.Solid = true;
      tChart2.Axes.Bottom.Labels.Font.Shadow.Brush.Visible = true;
      tChart2.Axes.Bottom.Labels.Font.Size = 8;
      tChart2.Axes.Bottom.Labels.Font.SizeFloat = 8F;
      tChart2.Axes.Bottom.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart2.Axes.Bottom.Labels.ImageBevel.Brush.Color = Color.LightGray;
      tChart2.Axes.Bottom.Labels.ImageBevel.Brush.Solid = true;
      tChart2.Axes.Bottom.Labels.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart2.Axes.Bottom.Labels.Shadow.Brush.Color = Color.DarkGray;
      tChart2.Axes.Bottom.Labels.Shadow.Brush.Solid = true;
      tChart2.Axes.Bottom.Labels.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart2.Axes.Bottom.Title.Brush.Color = Color.Silver;
      tChart2.Axes.Bottom.Title.Brush.Solid = true;
      tChart2.Axes.Bottom.Title.Brush.Visible = true;
      // 
      // 
      // 
      tChart2.Axes.Bottom.Title.Font.Bold = false;
      // 
      // 
      // 
      tChart2.Axes.Bottom.Title.Font.Brush.Color = Color.FromArgb((int)(byte)0, (int)(byte)0, (int)(byte)0);
      tChart2.Axes.Bottom.Title.Font.Brush.Solid = true;
      tChart2.Axes.Bottom.Title.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart2.Axes.Bottom.Title.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart2.Axes.Bottom.Title.Font.Shadow.Brush.Solid = true;
      tChart2.Axes.Bottom.Title.Font.Shadow.Brush.Visible = true;
      tChart2.Axes.Bottom.Title.Font.Size = 8;
      tChart2.Axes.Bottom.Title.Font.SizeFloat = 8F;
      tChart2.Axes.Bottom.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart2.Axes.Bottom.Title.ImageBevel.Brush.Color = Color.LightGray;
      tChart2.Axes.Bottom.Title.ImageBevel.Brush.Solid = true;
      tChart2.Axes.Bottom.Title.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart2.Axes.Bottom.Title.Shadow.Brush.Color = Color.DarkGray;
      tChart2.Axes.Bottom.Title.Shadow.Brush.Solid = true;
      tChart2.Axes.Bottom.Title.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      tChart2.Axes.Depth.Labels.Brush.Color = Color.White;
      tChart2.Axes.Depth.Labels.Brush.Solid = true;
      tChart2.Axes.Depth.Labels.Brush.Visible = true;
      // 
      // 
      // 
      tChart2.Axes.Depth.Labels.Font.Bold = false;
      // 
      // 
      // 
      tChart2.Axes.Depth.Labels.Font.Brush.Color = Color.FromArgb((int)(byte)255, (int)(byte)255, (int)(byte)255);
      tChart2.Axes.Depth.Labels.Font.Brush.Solid = true;
      tChart2.Axes.Depth.Labels.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart2.Axes.Depth.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart2.Axes.Depth.Labels.Font.Shadow.Brush.Solid = true;
      tChart2.Axes.Depth.Labels.Font.Shadow.Brush.Visible = true;
      tChart2.Axes.Depth.Labels.Font.Size = 8;
      tChart2.Axes.Depth.Labels.Font.SizeFloat = 8F;
      tChart2.Axes.Depth.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart2.Axes.Depth.Labels.ImageBevel.Brush.Color = Color.LightGray;
      tChart2.Axes.Depth.Labels.ImageBevel.Brush.Solid = true;
      tChart2.Axes.Depth.Labels.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart2.Axes.Depth.Labels.Shadow.Brush.Color = Color.DarkGray;
      tChart2.Axes.Depth.Labels.Shadow.Brush.Solid = true;
      tChart2.Axes.Depth.Labels.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart2.Axes.Depth.Title.Brush.Color = Color.Silver;
      tChart2.Axes.Depth.Title.Brush.Solid = true;
      tChart2.Axes.Depth.Title.Brush.Visible = true;
      // 
      // 
      // 
      tChart2.Axes.Depth.Title.Font.Bold = false;
      // 
      // 
      // 
      tChart2.Axes.Depth.Title.Font.Brush.Color = Color.FromArgb((int)(byte)0, (int)(byte)0, (int)(byte)0);
      tChart2.Axes.Depth.Title.Font.Brush.Solid = true;
      tChart2.Axes.Depth.Title.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart2.Axes.Depth.Title.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart2.Axes.Depth.Title.Font.Shadow.Brush.Solid = true;
      tChart2.Axes.Depth.Title.Font.Shadow.Brush.Visible = true;
      tChart2.Axes.Depth.Title.Font.Size = 8;
      tChart2.Axes.Depth.Title.Font.SizeFloat = 8F;
      tChart2.Axes.Depth.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart2.Axes.Depth.Title.ImageBevel.Brush.Color = Color.LightGray;
      tChart2.Axes.Depth.Title.ImageBevel.Brush.Solid = true;
      tChart2.Axes.Depth.Title.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart2.Axes.Depth.Title.Shadow.Brush.Color = Color.DarkGray;
      tChart2.Axes.Depth.Title.Shadow.Brush.Solid = true;
      tChart2.Axes.Depth.Title.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      tChart2.Axes.DepthTop.Labels.Brush.Color = Color.White;
      tChart2.Axes.DepthTop.Labels.Brush.Solid = true;
      tChart2.Axes.DepthTop.Labels.Brush.Visible = true;
      // 
      // 
      // 
      tChart2.Axes.DepthTop.Labels.Font.Bold = false;
      // 
      // 
      // 
      tChart2.Axes.DepthTop.Labels.Font.Brush.Color = Color.FromArgb((int)(byte)255, (int)(byte)255, (int)(byte)255);
      tChart2.Axes.DepthTop.Labels.Font.Brush.Solid = true;
      tChart2.Axes.DepthTop.Labels.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart2.Axes.DepthTop.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart2.Axes.DepthTop.Labels.Font.Shadow.Brush.Solid = true;
      tChart2.Axes.DepthTop.Labels.Font.Shadow.Brush.Visible = true;
      tChart2.Axes.DepthTop.Labels.Font.Size = 8;
      tChart2.Axes.DepthTop.Labels.Font.SizeFloat = 8F;
      tChart2.Axes.DepthTop.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart2.Axes.DepthTop.Labels.ImageBevel.Brush.Color = Color.LightGray;
      tChart2.Axes.DepthTop.Labels.ImageBevel.Brush.Solid = true;
      tChart2.Axes.DepthTop.Labels.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart2.Axes.DepthTop.Labels.Shadow.Brush.Color = Color.DarkGray;
      tChart2.Axes.DepthTop.Labels.Shadow.Brush.Solid = true;
      tChart2.Axes.DepthTop.Labels.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart2.Axes.DepthTop.Title.Brush.Color = Color.Silver;
      tChart2.Axes.DepthTop.Title.Brush.Solid = true;
      tChart2.Axes.DepthTop.Title.Brush.Visible = true;
      // 
      // 
      // 
      tChart2.Axes.DepthTop.Title.Font.Bold = false;
      // 
      // 
      // 
      tChart2.Axes.DepthTop.Title.Font.Brush.Color = Color.FromArgb((int)(byte)0, (int)(byte)0, (int)(byte)0);
      tChart2.Axes.DepthTop.Title.Font.Brush.Solid = true;
      tChart2.Axes.DepthTop.Title.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart2.Axes.DepthTop.Title.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart2.Axes.DepthTop.Title.Font.Shadow.Brush.Solid = true;
      tChart2.Axes.DepthTop.Title.Font.Shadow.Brush.Visible = true;
      tChart2.Axes.DepthTop.Title.Font.Size = 8;
      tChart2.Axes.DepthTop.Title.Font.SizeFloat = 8F;
      tChart2.Axes.DepthTop.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart2.Axes.DepthTop.Title.ImageBevel.Brush.Color = Color.LightGray;
      tChart2.Axes.DepthTop.Title.ImageBevel.Brush.Solid = true;
      tChart2.Axes.DepthTop.Title.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart2.Axes.DepthTop.Title.Shadow.Brush.Color = Color.DarkGray;
      tChart2.Axes.DepthTop.Title.Shadow.Brush.Solid = true;
      tChart2.Axes.DepthTop.Title.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      tChart2.Axes.Left.Labels.Brush.Color = Color.White;
      tChart2.Axes.Left.Labels.Brush.Solid = true;
      tChart2.Axes.Left.Labels.Brush.Visible = true;
      // 
      // 
      // 
      tChart2.Axes.Left.Labels.Font.Bold = false;
      // 
      // 
      // 
      tChart2.Axes.Left.Labels.Font.Brush.Color = Color.FromArgb((int)(byte)255, (int)(byte)255, (int)(byte)255);
      tChart2.Axes.Left.Labels.Font.Brush.Solid = true;
      tChart2.Axes.Left.Labels.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart2.Axes.Left.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart2.Axes.Left.Labels.Font.Shadow.Brush.Solid = true;
      tChart2.Axes.Left.Labels.Font.Shadow.Brush.Visible = true;
      tChart2.Axes.Left.Labels.Font.Size = 8;
      tChart2.Axes.Left.Labels.Font.SizeFloat = 8F;
      tChart2.Axes.Left.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart2.Axes.Left.Labels.ImageBevel.Brush.Color = Color.LightGray;
      tChart2.Axes.Left.Labels.ImageBevel.Brush.Solid = true;
      tChart2.Axes.Left.Labels.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart2.Axes.Left.Labels.Shadow.Brush.Color = Color.DarkGray;
      tChart2.Axes.Left.Labels.Shadow.Brush.Solid = true;
      tChart2.Axes.Left.Labels.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart2.Axes.Left.Title.Brush.Color = Color.Silver;
      tChart2.Axes.Left.Title.Brush.Solid = true;
      tChart2.Axes.Left.Title.Brush.Visible = true;
      // 
      // 
      // 
      tChart2.Axes.Left.Title.Font.Bold = false;
      // 
      // 
      // 
      tChart2.Axes.Left.Title.Font.Brush.Color = Color.FromArgb((int)(byte)0, (int)(byte)0, (int)(byte)0);
      tChart2.Axes.Left.Title.Font.Brush.Solid = true;
      tChart2.Axes.Left.Title.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart2.Axes.Left.Title.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart2.Axes.Left.Title.Font.Shadow.Brush.Solid = true;
      tChart2.Axes.Left.Title.Font.Shadow.Brush.Visible = true;
      tChart2.Axes.Left.Title.Font.Size = 8;
      tChart2.Axes.Left.Title.Font.SizeFloat = 8F;
      tChart2.Axes.Left.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart2.Axes.Left.Title.ImageBevel.Brush.Color = Color.LightGray;
      tChart2.Axes.Left.Title.ImageBevel.Brush.Solid = true;
      tChart2.Axes.Left.Title.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart2.Axes.Left.Title.Shadow.Brush.Color = Color.DarkGray;
      tChart2.Axes.Left.Title.Shadow.Brush.Solid = true;
      tChart2.Axes.Left.Title.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      tChart2.Axes.Right.Labels.Brush.Color = Color.White;
      tChart2.Axes.Right.Labels.Brush.Solid = true;
      tChart2.Axes.Right.Labels.Brush.Visible = true;
      // 
      // 
      // 
      tChart2.Axes.Right.Labels.Font.Bold = false;
      // 
      // 
      // 
      tChart2.Axes.Right.Labels.Font.Brush.Color = Color.FromArgb((int)(byte)255, (int)(byte)255, (int)(byte)255);
      tChart2.Axes.Right.Labels.Font.Brush.Solid = true;
      tChart2.Axes.Right.Labels.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart2.Axes.Right.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart2.Axes.Right.Labels.Font.Shadow.Brush.Solid = true;
      tChart2.Axes.Right.Labels.Font.Shadow.Brush.Visible = true;
      tChart2.Axes.Right.Labels.Font.Size = 8;
      tChart2.Axes.Right.Labels.Font.SizeFloat = 8F;
      tChart2.Axes.Right.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart2.Axes.Right.Labels.ImageBevel.Brush.Color = Color.LightGray;
      tChart2.Axes.Right.Labels.ImageBevel.Brush.Solid = true;
      tChart2.Axes.Right.Labels.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart2.Axes.Right.Labels.Shadow.Brush.Color = Color.DarkGray;
      tChart2.Axes.Right.Labels.Shadow.Brush.Solid = true;
      tChart2.Axes.Right.Labels.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart2.Axes.Right.Title.Brush.Color = Color.Silver;
      tChart2.Axes.Right.Title.Brush.Solid = true;
      tChart2.Axes.Right.Title.Brush.Visible = true;
      // 
      // 
      // 
      tChart2.Axes.Right.Title.Font.Bold = false;
      // 
      // 
      // 
      tChart2.Axes.Right.Title.Font.Brush.Color = Color.FromArgb((int)(byte)0, (int)(byte)0, (int)(byte)0);
      tChart2.Axes.Right.Title.Font.Brush.Solid = true;
      tChart2.Axes.Right.Title.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart2.Axes.Right.Title.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart2.Axes.Right.Title.Font.Shadow.Brush.Solid = true;
      tChart2.Axes.Right.Title.Font.Shadow.Brush.Visible = true;
      tChart2.Axes.Right.Title.Font.Size = 8;
      tChart2.Axes.Right.Title.Font.SizeFloat = 8F;
      tChart2.Axes.Right.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart2.Axes.Right.Title.ImageBevel.Brush.Color = Color.LightGray;
      tChart2.Axes.Right.Title.ImageBevel.Brush.Solid = true;
      tChart2.Axes.Right.Title.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart2.Axes.Right.Title.Shadow.Brush.Color = Color.DarkGray;
      tChart2.Axes.Right.Title.Shadow.Brush.Solid = true;
      tChart2.Axes.Right.Title.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      tChart2.Axes.Top.Labels.Brush.Color = Color.White;
      tChart2.Axes.Top.Labels.Brush.Solid = true;
      tChart2.Axes.Top.Labels.Brush.Visible = true;
      // 
      // 
      // 
      tChart2.Axes.Top.Labels.Font.Bold = false;
      // 
      // 
      // 
      tChart2.Axes.Top.Labels.Font.Brush.Color = Color.FromArgb((int)(byte)255, (int)(byte)255, (int)(byte)255);
      tChart2.Axes.Top.Labels.Font.Brush.Solid = true;
      tChart2.Axes.Top.Labels.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart2.Axes.Top.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart2.Axes.Top.Labels.Font.Shadow.Brush.Solid = true;
      tChart2.Axes.Top.Labels.Font.Shadow.Brush.Visible = true;
      tChart2.Axes.Top.Labels.Font.Size = 8;
      tChart2.Axes.Top.Labels.Font.SizeFloat = 8F;
      tChart2.Axes.Top.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart2.Axes.Top.Labels.ImageBevel.Brush.Color = Color.LightGray;
      tChart2.Axes.Top.Labels.ImageBevel.Brush.Solid = true;
      tChart2.Axes.Top.Labels.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart2.Axes.Top.Labels.Shadow.Brush.Color = Color.DarkGray;
      tChart2.Axes.Top.Labels.Shadow.Brush.Solid = true;
      tChart2.Axes.Top.Labels.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart2.Axes.Top.Title.Brush.Color = Color.Silver;
      tChart2.Axes.Top.Title.Brush.Solid = true;
      tChart2.Axes.Top.Title.Brush.Visible = true;
      // 
      // 
      // 
      tChart2.Axes.Top.Title.Font.Bold = false;
      // 
      // 
      // 
      tChart2.Axes.Top.Title.Font.Brush.Color = Color.FromArgb((int)(byte)0, (int)(byte)0, (int)(byte)0);
      tChart2.Axes.Top.Title.Font.Brush.Solid = true;
      tChart2.Axes.Top.Title.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart2.Axes.Top.Title.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart2.Axes.Top.Title.Font.Shadow.Brush.Solid = true;
      tChart2.Axes.Top.Title.Font.Shadow.Brush.Visible = true;
      tChart2.Axes.Top.Title.Font.Size = 8;
      tChart2.Axes.Top.Title.Font.SizeFloat = 8F;
      tChart2.Axes.Top.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart2.Axes.Top.Title.ImageBevel.Brush.Color = Color.LightGray;
      tChart2.Axes.Top.Title.ImageBevel.Brush.Solid = true;
      tChart2.Axes.Top.Title.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart2.Axes.Top.Title.Shadow.Brush.Color = Color.DarkGray;
      tChart2.Axes.Top.Title.Shadow.Brush.Solid = true;
      tChart2.Axes.Top.Title.Shadow.Brush.Visible = true;
      tChart2.Dock = DockStyle.Top;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart2.Footer.Brush.Color = Color.Silver;
      tChart2.Footer.Brush.Solid = true;
      tChart2.Footer.Brush.Visible = true;
      // 
      // 
      // 
      tChart2.Footer.Font.Bold = false;
      // 
      // 
      // 
      tChart2.Footer.Font.Brush.Color = Color.Red;
      tChart2.Footer.Font.Brush.Solid = true;
      tChart2.Footer.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart2.Footer.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart2.Footer.Font.Shadow.Brush.Solid = true;
      tChart2.Footer.Font.Shadow.Brush.Visible = true;
      tChart2.Footer.Font.Size = 8;
      tChart2.Footer.Font.SizeFloat = 8F;
      tChart2.Footer.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart2.Footer.ImageBevel.Brush.Color = Color.LightGray;
      tChart2.Footer.ImageBevel.Brush.Solid = true;
      tChart2.Footer.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart2.Footer.Shadow.Brush.Color = Color.DarkGray;
      tChart2.Footer.Shadow.Brush.Solid = true;
      tChart2.Footer.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart2.Header.Brush.Color = Color.FromArgb((int)(byte)192, (int)(byte)192, (int)(byte)192);
      // 
      // 
      // 
      tChart2.Header.Brush.Gradient.SigmaFocus = 0F;
      tChart2.Header.Brush.Gradient.SigmaScale = 0F;
      tChart2.Header.Brush.Solid = true;
      tChart2.Header.Brush.Visible = true;
      // 
      // 
      // 
      tChart2.Header.Font.Bold = false;
      // 
      // 
      // 
      tChart2.Header.Font.Brush.Color = Color.FromArgb((int)(byte)255, (int)(byte)255, (int)(byte)255);
      tChart2.Header.Font.Brush.Solid = true;
      tChart2.Header.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart2.Header.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart2.Header.Font.Shadow.Brush.Solid = true;
      tChart2.Header.Font.Shadow.Brush.Visible = true;
      tChart2.Header.Font.Size = 8;
      tChart2.Header.Font.SizeFloat = 8F;
      tChart2.Header.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart2.Header.ImageBevel.Brush.Color = Color.LightGray;
      tChart2.Header.ImageBevel.Brush.Solid = true;
      tChart2.Header.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart2.Header.Shadow.Brush.Color = Color.FromArgb((int)(byte)169, (int)(byte)169, (int)(byte)169);
      tChart2.Header.Shadow.Brush.Solid = true;
      tChart2.Header.Shadow.Brush.Visible = true;
      tChart2.Header.Shadow.Height = 0;
      tChart2.Header.Shadow.Width = 0;
      tChart2.Header.Visible = false;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart2.Legend.Brush.Color = Color.White;
      // 
      // 
      // 
      tChart2.Legend.Brush.Gradient.SigmaFocus = 0F;
      tChart2.Legend.Brush.Gradient.SigmaScale = 0F;
      tChart2.Legend.Brush.Gradient.Visible = true;
      tChart2.Legend.Brush.Solid = true;
      tChart2.Legend.Brush.Visible = true;
      tChart2.Legend.CheckBoxes = false;
      tChart2.Legend.ClipText = false;
      // 
      // 
      // 
      tChart2.Legend.Font.Bold = false;
      // 
      // 
      // 
      tChart2.Legend.Font.Brush.Color = Color.FromArgb((int)(byte)255, (int)(byte)255, (int)(byte)255);
      tChart2.Legend.Font.Brush.Solid = true;
      tChart2.Legend.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart2.Legend.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart2.Legend.Font.Shadow.Brush.Solid = true;
      tChart2.Legend.Font.Shadow.Brush.Visible = true;
      tChart2.Legend.Font.Size = 8;
      tChart2.Legend.Font.SizeFloat = 8F;
      tChart2.Legend.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart2.Legend.ImageBevel.Brush.Color = Color.LightGray;
      tChart2.Legend.ImageBevel.Brush.Solid = true;
      tChart2.Legend.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart2.Legend.Shadow.Brush.Color = Color.FromArgb((int)(byte)0, (int)(byte)0, (int)(byte)0);
      tChart2.Legend.Shadow.Brush.Solid = true;
      tChart2.Legend.Shadow.Brush.Visible = true;
      tChart2.Legend.Shadow.Width = 0;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      tChart2.Legend.Symbol.Shadow.Brush.Color = Color.DarkGray;
      tChart2.Legend.Symbol.Shadow.Brush.Solid = true;
      tChart2.Legend.Symbol.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart2.Legend.Title.Brush.Color = Color.White;
      tChart2.Legend.Title.Brush.Solid = true;
      tChart2.Legend.Title.Brush.Visible = true;
      // 
      // 
      // 
      tChart2.Legend.Title.Font.Bold = true;
      // 
      // 
      // 
      tChart2.Legend.Title.Font.Brush.Color = Color.Black;
      tChart2.Legend.Title.Font.Brush.Solid = true;
      tChart2.Legend.Title.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart2.Legend.Title.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart2.Legend.Title.Font.Shadow.Brush.Solid = true;
      tChart2.Legend.Title.Font.Shadow.Brush.Visible = true;
      tChart2.Legend.Title.Font.Size = 8;
      tChart2.Legend.Title.Font.SizeFloat = 8F;
      tChart2.Legend.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Bold;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart2.Legend.Title.ImageBevel.Brush.Color = Color.LightGray;
      tChart2.Legend.Title.ImageBevel.Brush.Solid = true;
      tChart2.Legend.Title.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart2.Legend.Title.Shadow.Brush.Color = Color.DarkGray;
      tChart2.Legend.Title.Shadow.Brush.Solid = true;
      tChart2.Legend.Title.Shadow.Brush.Visible = true;
      tChart2.Legend.Visible = false;
      tChart2.Location = new Point(0, 0);
      tChart2.Name = "tChart2";
      // 
      // 
      // 
      // 
      // 
      // 
      tChart2.Panel.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.Raised;
      // 
      // 
      // 
      tChart2.Panel.Brush.Color = Color.FromArgb((int)(byte)240, (int)(byte)240, (int)(byte)240);
      // 
      // 
      // 
      tChart2.Panel.Brush.Gradient.EndColor = Color.FromArgb((int)(byte)70, (int)(byte)70, (int)(byte)70);
      tChart2.Panel.Brush.Gradient.MiddleColor = Color.FromArgb((int)(byte)0, (int)(byte)0, (int)(byte)0, (int)(byte)0);
      tChart2.Panel.Brush.Gradient.SigmaFocus = 0F;
      tChart2.Panel.Brush.Gradient.SigmaScale = 0F;
      tChart2.Panel.Brush.Gradient.StartColor = Color.FromArgb((int)(byte)70, (int)(byte)70, (int)(byte)70);
      tChart2.Panel.Brush.Gradient.UseMiddle = false;
      tChart2.Panel.Brush.Gradient.Visible = true;
      tChart2.Panel.Brush.Solid = true;
      tChart2.Panel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart2.Panel.ImageBevel.Brush.Color = Color.LightGray;
      tChart2.Panel.ImageBevel.Brush.Solid = true;
      tChart2.Panel.ImageBevel.Brush.Visible = true;
      tChart2.Panel.MarginBottom = 2D;
      tChart2.Panel.MarginLeft = 7D;
      tChart2.Panel.MarginRight = 7D;
      tChart2.Panel.MarginTop = 6D;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart2.Panel.Shadow.Brush.Color = Color.DarkGray;
      tChart2.Panel.Shadow.Brush.Solid = true;
      tChart2.Panel.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      margins9.Bottom = 100;
      margins9.Left = 100;
      margins9.Right = 100;
      margins9.Top = 100;
      tChart2.Printer.Margins = margins9;
      tChart2.Series.Add(donut1);
      tChart2.Size = new Size(195, 183);
      // 
      // 
      // 
      tChart2.SubFooter.AdjustFrame = false;
      tChart2.SubFooter.Bottom = 176;
      // 
      // 
      // 
      tChart2.SubFooter.Brush.Color = Color.FromArgb((int)(byte)255, (int)(byte)255, (int)(byte)192);
      tChart2.SubFooter.Brush.Solid = true;
      tChart2.SubFooter.Brush.Visible = true;
      tChart2.SubFooter.CustomPosition = true;
      // 
      // 
      // 
      tChart2.SubFooter.Font.Bold = false;
      // 
      // 
      // 
      tChart2.SubFooter.Font.Brush.Color = Color.FromArgb((int)(byte)192, (int)(byte)192, (int)(byte)192);
      tChart2.SubFooter.Font.Brush.Solid = true;
      tChart2.SubFooter.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart2.SubFooter.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart2.SubFooter.Font.Shadow.Brush.Solid = true;
      tChart2.SubFooter.Font.Shadow.Brush.Visible = true;
      tChart2.SubFooter.Font.Size = 8;
      tChart2.SubFooter.Font.SizeFloat = 8F;
      tChart2.SubFooter.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart2.SubFooter.ImageBevel.Brush.Color = Color.LightGray;
      tChart2.SubFooter.ImageBevel.Brush.Solid = true;
      tChart2.SubFooter.ImageBevel.Brush.Visible = true;
      tChart2.SubFooter.Left = 6;
      tChart2.SubFooter.Lines = new string[]
  {
    "Oven 1"
  };
      tChart2.SubFooter.Right = 181;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart2.SubFooter.Shadow.Brush.Color = Color.DarkGray;
      tChart2.SubFooter.Shadow.Brush.Solid = true;
      tChart2.SubFooter.Shadow.Brush.Visible = true;
      tChart2.SubFooter.Top = 161;
      tChart2.SubFooter.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart2.SubHeader.Brush.Color = Color.FromArgb((int)(byte)192, (int)(byte)192, (int)(byte)192);
      tChart2.SubHeader.Brush.Solid = true;
      tChart2.SubHeader.Brush.Visible = true;
      // 
      // 
      // 
      tChart2.SubHeader.Font.Bold = false;
      // 
      // 
      // 
      tChart2.SubHeader.Font.Brush.Color = Color.FromArgb((int)(byte)128, (int)(byte)128, (int)(byte)128);
      tChart2.SubHeader.Font.Brush.Solid = true;
      tChart2.SubHeader.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart2.SubHeader.Font.Shadow.Brush.Color = Color.DarkGray;
      tChart2.SubHeader.Font.Shadow.Brush.Solid = true;
      tChart2.SubHeader.Font.Shadow.Brush.Visible = true;
      tChart2.SubHeader.Font.Size = 12;
      tChart2.SubHeader.Font.SizeFloat = 12F;
      tChart2.SubHeader.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart2.SubHeader.ImageBevel.Brush.Color = Color.LightGray;
      tChart2.SubHeader.ImageBevel.Brush.Solid = true;
      tChart2.SubHeader.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart2.SubHeader.Shadow.Brush.Color = Color.FromArgb((int)(byte)169, (int)(byte)169, (int)(byte)169);
      tChart2.SubHeader.Shadow.Brush.Solid = true;
      tChart2.SubHeader.Shadow.Brush.Visible = true;
      tChart2.TabIndex = 1;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      tChart2.Walls.Back.Brush.Color = Color.Silver;
      // 
      // 
      // 
      tChart2.Walls.Back.Brush.Gradient.EndColor = Color.FromArgb((int)(byte)120, (int)(byte)120, (int)(byte)120);
      tChart2.Walls.Back.Brush.Gradient.StartColor = Color.FromArgb((int)(byte)70, (int)(byte)70, (int)(byte)70);
      tChart2.Walls.Back.Brush.Solid = true;
      tChart2.Walls.Back.Brush.Visible = false;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart2.Walls.Back.ImageBevel.Brush.Color = Color.LightGray;
      tChart2.Walls.Back.ImageBevel.Brush.Solid = true;
      tChart2.Walls.Back.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart2.Walls.Back.Shadow.Brush.Color = Color.DarkGray;
      tChart2.Walls.Back.Shadow.Brush.Solid = true;
      tChart2.Walls.Back.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart2.Walls.Bottom.Brush.Color = Color.White;
      // 
      // 
      // 
      tChart2.Walls.Bottom.Brush.Gradient.SigmaFocus = 0F;
      tChart2.Walls.Bottom.Brush.Gradient.SigmaScale = 0F;
      tChart2.Walls.Bottom.Brush.Solid = true;
      tChart2.Walls.Bottom.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart2.Walls.Bottom.ImageBevel.Brush.Color = Color.LightGray;
      tChart2.Walls.Bottom.ImageBevel.Brush.Solid = true;
      tChart2.Walls.Bottom.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart2.Walls.Bottom.Shadow.Brush.Color = Color.DarkGray;
      tChart2.Walls.Bottom.Shadow.Brush.Solid = true;
      tChart2.Walls.Bottom.Shadow.Brush.Visible = true;
      tChart2.Walls.Bottom.Visible = false;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart2.Walls.Left.Brush.Color = Color.LightYellow;
      // 
      // 
      // 
      tChart2.Walls.Left.Brush.Gradient.SigmaFocus = 0F;
      tChart2.Walls.Left.Brush.Gradient.SigmaScale = 0F;
      tChart2.Walls.Left.Brush.Solid = true;
      tChart2.Walls.Left.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart2.Walls.Left.ImageBevel.Brush.Color = Color.LightGray;
      tChart2.Walls.Left.ImageBevel.Brush.Solid = true;
      tChart2.Walls.Left.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart2.Walls.Left.Shadow.Brush.Color = Color.DarkGray;
      tChart2.Walls.Left.Shadow.Brush.Solid = true;
      tChart2.Walls.Left.Shadow.Brush.Visible = true;
      tChart2.Walls.Left.Visible = false;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart2.Walls.Right.Brush.Color = Color.FromArgb((int)(byte)192, (int)(byte)192, (int)(byte)192);
      // 
      // 
      // 
      tChart2.Walls.Right.Brush.Gradient.SigmaFocus = 0F;
      tChart2.Walls.Right.Brush.Gradient.SigmaScale = 0F;
      tChart2.Walls.Right.Brush.Solid = true;
      tChart2.Walls.Right.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart2.Walls.Right.ImageBevel.Brush.Color = Color.LightGray;
      tChart2.Walls.Right.ImageBevel.Brush.Solid = true;
      tChart2.Walls.Right.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart2.Walls.Right.Shadow.Brush.Color = Color.DarkGray;
      tChart2.Walls.Right.Shadow.Brush.Solid = true;
      tChart2.Walls.Right.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart2.Zoom.Brush.Color = Color.FromArgb((int)(byte)127, (int)(byte)0, (int)(byte)0, (int)(byte)255);
      tChart2.Zoom.Brush.Solid = true;
      tChart2.Zoom.Brush.Visible = false;
      tChart2.AfterDraw += (this.tChart2_AfterDraw);
      // 
      // donut1
      // 
      donut1.AngleSize = 237;
      // 
      // 
      // 
      donut1.Brush.Color = Color.FromArgb((int)(byte)255, (int)(byte)243, (int)(byte)144);
      donut1.Brush.Solid = true;
      donut1.Brush.Visible = true;
      donut1.Circled = true;
      donut1.Color = Color.FromArgb((int)(byte)119, (int)(byte)153, (int)(byte)214);
      donut1.Cursor = cursor1;
      donut1.DonutPercent = 70;
      // 
      // 
      // 
      donut1.Frame.Circled = true;
      donut1.Frame.FrameElementPercents = new double[]
  {
    25D,
    60D,
    15D
  };
      // 
      // 
      // 
      donut1.Frame.InnerBand.Color = Color.Gray;
      donut1.Frame.InnerBand.Solid = true;
      donut1.Frame.InnerBand.Visible = true;
      // 
      // 
      // 
      donut1.Frame.OuterBand.Color = Color.Gray;
      // 
      // 
      // 
      donut1.Frame.OuterBand.Gradient.Visible = true;
      donut1.Frame.OuterBand.Solid = true;
      donut1.Frame.OuterBand.Visible = true;
      donut1.LabelMember = "Labels";
      // 
      // 
      // 
      // 
      // 
      // 
      donut1.Legend.Brush.Color = Color.White;
      donut1.Legend.Brush.Solid = true;
      donut1.Legend.Brush.Visible = true;
      // 
      // 
      // 
      donut1.Legend.Font.Bold = false;
      // 
      // 
      // 
      donut1.Legend.Font.Brush.Color = Color.Black;
      donut1.Legend.Font.Brush.Solid = true;
      donut1.Legend.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      donut1.Legend.Font.Shadow.Brush.Color = Color.DarkGray;
      donut1.Legend.Font.Shadow.Brush.Solid = true;
      donut1.Legend.Font.Shadow.Brush.Visible = true;
      donut1.Legend.Font.Size = 8;
      donut1.Legend.Font.SizeFloat = 8F;
      donut1.Legend.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      donut1.Legend.ImageBevel.Brush.Color = Color.LightGray;
      donut1.Legend.ImageBevel.Brush.Solid = true;
      donut1.Legend.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      donut1.Legend.Shadow.Brush.Color = Color.DarkGray;
      donut1.Legend.Shadow.Brush.Solid = true;
      donut1.Legend.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      donut1.Marks.Arrow.Color = Color.Black;
      donut1.Marks.Arrow.Visible = false;
      // 
      // 
      // 
      donut1.Marks.Brush.Color = Color.FromArgb((int)(byte)255, (int)(byte)255, (int)(byte)255);
      donut1.Marks.Brush.Solid = true;
      donut1.Marks.Brush.Visible = true;
      // 
      // 
      // 
      donut1.Marks.Font.Bold = false;
      // 
      // 
      // 
      donut1.Marks.Font.Brush.Color = Color.FromArgb((int)(byte)0, (int)(byte)0, (int)(byte)0);
      donut1.Marks.Font.Brush.Solid = true;
      donut1.Marks.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      donut1.Marks.Font.Shadow.Brush.Color = Color.DarkGray;
      donut1.Marks.Font.Shadow.Brush.Solid = true;
      donut1.Marks.Font.Shadow.Brush.Visible = true;
      donut1.Marks.Font.Size = 8;
      donut1.Marks.Font.SizeFloat = 8F;
      donut1.Marks.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      donut1.Marks.ImageBevel.Brush.Color = Color.LightGray;
      donut1.Marks.ImageBevel.Brush.Solid = true;
      donut1.Marks.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      donut1.Marks.Shadow.Brush.Color = Color.FromArgb((int)(byte)128, (int)(byte)128, (int)(byte)128);
      donut1.Marks.Shadow.Brush.Solid = true;
      donut1.Marks.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      donut1.Marks.Symbol.Brush.Color = Color.White;
      donut1.Marks.Symbol.Brush.Solid = true;
      donut1.Marks.Symbol.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      donut1.Marks.Symbol.ImageBevel.Brush.Color = Color.LightGray;
      donut1.Marks.Symbol.ImageBevel.Brush.Solid = true;
      donut1.Marks.Symbol.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      donut1.Marks.Symbol.Shadow.Brush.Color = Color.DarkGray;
      donut1.Marks.Symbol.Shadow.Brush.Solid = true;
      donut1.Marks.Symbol.Shadow.Brush.Visible = true;
      donut1.Marks.TailStyle = Steema.TeeChart.Styles.MarksTail.None;
      donut1.Marks.Visible = false;
      // 
      // 
      // 
      donut1.MarksPie.InsideSlice = true;
      donut1.MarksPie.LegSize = 0;
      donut1.MarksPie.Rotated = false;
      donut1.MarksPie.RotateStyle = Steema.TeeChart.Styles.Pie.MarksRotateStyle.Radial;
      donut1.MarksPie.VertCenter = false;
      donut1.MultiPie = Steema.TeeChart.Styles.MultiPies.Automatic;
      // 
      // 
      // 
      donut1.OtherSlice.Color = Color.Empty;
      donut1.OtherSlice.Style = Steema.TeeChart.Styles.PieOtherStyles.None;
      donut1.OtherSlice.Text = "";
      donut1.OtherSlice.Value = 0D;
      // 
      // 
      // 
      donut1.Pen.Width = 3;
      donut1.RotationAngle = 332;
      // 
      // 
      // 
      // 
      // 
      // 
      donut1.Shadow.Brush.Color = Color.DarkGray;
      donut1.Shadow.Brush.Solid = true;
      donut1.Shadow.Brush.Visible = true;
      donut1.Title = "donut1";
      donut1.UniqueCustomRadius = true;
      // 
      // 
      // 
      donut1.XValues.DataMember = "Angle";
      donut1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
      donut1.XValues.Value = new double[]
  {
    0D,
    1D,
    2D,
    3D,
    4D,
    5D,
    6D,
    7D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
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
      donut1.YValues.DataMember = "Pie";
      donut1.YValues.Value = new double[]
  {
    275D,
    434D,
    612D,
    48D,
    658D,
    849D,
    685D,
    415D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
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
      // timer1
      // 
      timer1.Interval = 10;
      timer1.Tick += (this.timer1_Tick);
      // 
      // FormMultiPanel
      // 
      this.ClientSize = new Size(1377, 972);
      this.Controls.Add(panel3);
      this.Controls.Add(panel2);
      this.Controls.Add(panel1);
      this.Name = "FormMultiPanel";
      this.Text = "Realtime Multi Panel example";
      this.WindowState = FormWindowState.Maximized;
      panel1.ResumeLayout(false);
      panel1.PerformLayout();
      panel2.ResumeLayout(false);
      panel8.ResumeLayout(false);
      panel7.ResumeLayout(false);
      panel3.ResumeLayout(false);
      panel6.ResumeLayout(false);
      panel5.ResumeLayout(false);
      panel4.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Panel panel3;
    private System.Windows.Forms.Panel panel4;
    private Steema.TeeChart.TChart tChart1;
    private Steema.TeeChart.TChart tChart4;
    private Steema.TeeChart.TChart tChart3;
    private Steema.TeeChart.TChart tChart2;
    private Steema.TeeChart.ChartController chartController1;
    private Steema.TeeChart.Styles.CircularGauge circularGauge1;
    private Steema.TeeChart.Styles.Donut donut1;
    private Steema.TeeChart.Styles.Donut donut2;
    private Steema.TeeChart.Styles.Donut donut3;
    private Steema.TeeChart.Styles.Donut donut4;
    private System.Windows.Forms.Panel panel6;
    private Steema.TeeChart.TChart tChart6;
    private System.Windows.Forms.Panel panel5;
    private Steema.TeeChart.TChart tChart5;
    //private Steema.TeeChart.Drawing.GL.TeeOpenGL teeOpenGL1;
    private Steema.TeeChart.Styles.Surface surface;
    private System.Windows.Forms.Timer timer1;
    private System.Windows.Forms.Button button1;
    private Steema.TeeChart.Tools.Rotate rotate1;
    private System.Windows.Forms.Panel panel7;
    private System.Windows.Forms.Panel panel8;
    private Steema.TeeChart.TChart tChart8;
    private Steema.TeeChart.TChart tChart7;
    private Steema.TeeChart.Styles.Area area1;
    private Steema.TeeChart.Styles.Line line1;
    private Steema.TeeChart.Styles.Line line2;
    private Steema.TeeChart.Axis axis1;
    private Steema.TeeChart.Axis axis2;
    private Steema.TeeChart.Styles.Bar3D bar3D1;
    private Steema.TeeChart.Tools.CursorTool cursorTool1;
    private Steema.TeeChart.Styles.HighLow highLow1;
    private Steema.TeeChart.TChart tChart9;
    private Steema.TeeChart.Axis axis3;
    private Steema.TeeChart.Styles.Line line3;
    private Steema.TeeChart.Functions.StdDeviation stdDeviation1;
    private Steema.TeeChart.Axis axis4;
    private Steema.TeeChart.Styles.Line line4;
    private Steema.TeeChart.Functions.StdDeviation stdDeviation2;
    private Steema.TeeChart.Tools.ColorBand colorBand1;
    private Steema.TeeChart.Tools.ColorBand colorBand2;
    private Steema.TeeChart.Tools.Annotation annotation1;
    private Steema.TeeChart.Tools.Annotation annotation2;
    private Steema.TeeChart.Functions.RootMeanSquare rootMeanSquare1;
  }
}