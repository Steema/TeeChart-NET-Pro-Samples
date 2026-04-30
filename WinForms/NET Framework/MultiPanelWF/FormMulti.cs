using PdfSharp.Charting;
using PdfSharp.Pdf.Content.Objects;
using Steema.TeeChart;
using Steema.TeeChart.Editors.Series;
using Steema.TeeChart.Styles;
using Steema.TeeChart.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection.Emit;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MultiPanelWF
{
  public partial class FormMulti : Form
  {
    public FormMulti()
    {
      InitializeComponent();
      Config();
    }

    Random rand;

    public void Config()
    {
      rand = new Random();
      ConfigGauge1();
      ConfigGauge2();
      ConfigGauge3();
      ConfigGauge4();
      ConfigGauge5();
      ConfigSurface();
      ConfigMultiSeries1();
      ConfigHarmonics();
    }

    private void ConfigGauge1()
    {
      //circularGauge1.HandDistance = 20;
      //circularGauge1.HandOffset = 80;
      circularGauge1.GreenLine.Pen.Visible = false;
      circularGauge1.GreenLine.Gradient.Visible = false;
      circularGauge1.GreenLine.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(104))))); ; // Color.LightGreen;
      circularGauge1.RedLine.Pen.Visible = false;
      circularGauge1.RedLine.Gradient.Visible = false;
      circularGauge1.RedLine.Brush.Color = Color.Red;
      circularGauge1.Frame.OuterBand.Visible = false;
      circularGauge1.Frame.MiddleBand.Visible = false;
      circularGauge1.Frame.InnerBand.Visible = false;
      circularGauge1.FaceBrush.Visible = false;

      circularGauge1.Value = rand.NextDouble() * 70;

      this.circularGauge1.Axis.GetAxisDrawLabel += Axis_GetAxisDrawLabel;

    }

    private void Axis_GetAxisDrawLabel(object sender, Steema.TeeChart.GetAxisDrawLabelEventArgs e)
    {
      if ((e.Text != "70") && (e.Text != "0") && (e.Text != "100"))
        e.Text = "";
    }

    private void ConfigGauge2()
    {
      donut1.Add(rand.NextDouble() * 1000);
      donut1.Add(1000 - donut1.YValues.Last);

      donut1.Pen.Fill.Color = donut1.Chart.Panel.Brush.Gradient.StartColor; //  Color.Black;
      donut1.Pen.Fill.Visible = true;
    }

    private void ConfigGauge3()
    {
      // donut2
      this.donut2.AngleSize = 237;
      this.donut2.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(144)))));
      this.donut2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(153)))), ((int)(((byte)(214)))));
      this.donut2.DonutPercent = 70;
      this.donut2.Frame.Circled = true;
      this.donut2.Frame.FrameElementPercents = new double[] {
        25D,
        60D,
        15D};
      this.donut2.Frame.OuterBand.Gradient.UseMiddle = false;
      this.donut2.LabelMember = "Labels";
      this.donut2.Marks.Visible = false;
      this.donut2.MarksPie.InsideSlice = true;
      this.donut2.MarksPie.LegSize = 0;
      this.donut2.MarksPie.Rotated = false;
      this.donut2.MarksPie.RotateStyle = Steema.TeeChart.Styles.Pie.MarksRotateStyle.Radial;
      this.donut2.MarksPie.VertCenter = false;
      this.donut2.MultiPie = Steema.TeeChart.Styles.MultiPies.Automatic;
      this.donut2.OriginalCursor = null;
      this.donut2.OtherSlice.Color = System.Drawing.Color.Empty;
      this.donut2.OtherSlice.Style = Steema.TeeChart.Styles.PieOtherStyles.None;
      this.donut2.OtherSlice.Text = "";
      this.donut2.OtherSlice.Value = 0D;
      this.donut2.Pen.Width = 3;
      this.donut2.RotationAngle = 332;
      this.donut2.Title = "donut2";
      this.donut2.UniqueCustomRadius = true;
      this.donut2.UseExtendedNumRange = false;
      this.donut2.XValues.DataMember = "Angle";
      this.donut2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;

      this.donut2.YValues.DataMember = "Pie";

      donut2.Add(rand.NextDouble() * 1000);
      donut2.Add(1000-donut2.YValues.Last);
      donut2.Pen.Fill.Color = donut1.Chart.Panel.Brush.Gradient.StartColor; //  Color.Black;
      donut2.Pen.Fill.Visible = true;
    }

    private void ConfigGauge4()
    {
      // donut3
      this.donut3.AngleSize = 237;
      this.donut3.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(144)))));
      this.donut3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(153)))), ((int)(((byte)(214)))));
      this.donut3.DonutPercent = 70;
      this.donut3.Frame.Circled = true;
      this.donut3.Frame.FrameElementPercents = new double[] {
    25D,
    60D,
    15D};
      this.donut3.Frame.OuterBand.Gradient.UseMiddle = false;
      this.donut3.LabelMember = "Labels";
      this.donut3.Marks.Visible = false;
      this.donut3.MarksPie.InsideSlice = true;
      this.donut3.MarksPie.LegSize = 0;
      this.donut3.MarksPie.Rotated = false;
      this.donut3.MarksPie.RotateStyle = Steema.TeeChart.Styles.Pie.MarksRotateStyle.Radial;
      this.donut3.MarksPie.VertCenter = false;
      this.donut3.MultiPie = Steema.TeeChart.Styles.MultiPies.Automatic;
      this.donut3.OriginalCursor = null;
      this.donut3.OtherSlice.Color = System.Drawing.Color.Empty;
      this.donut3.OtherSlice.Style = Steema.TeeChart.Styles.PieOtherStyles.None;
      this.donut3.OtherSlice.Text = "";
      this.donut3.OtherSlice.Value = 0D;
      this.donut3.Pen.Width = 3;
      this.donut3.RotationAngle = 332;
      this.donut3.Title = "donut3";
      this.donut3.UniqueCustomRadius = true;
      this.donut3.UseExtendedNumRange = false;
      this.donut3.XValues.DataMember = "Angle";
      this.donut3.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;

      this.donut3.YValues.DataMember = "Pie";

      donut3.Add(rand.NextDouble() *  1000);
      donut3.Add(1000 - donut3.YValues.Last);
      donut3.Pen.Fill.Color = donut1.Chart.Panel.Brush.Gradient.StartColor; //  Color.Black;
      donut3.Pen.Fill.Visible = true;
    }

    private void ConfigGauge5()
    {
      // donut4
      this.donut4.AngleSize = 237;
      this.donut4.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(144)))));
      this.donut4.Color = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(153)))), ((int)(((byte)(214)))));
      this.donut4.DonutPercent = 70;
      this.donut4.Frame.Circled = true;
      this.donut4.Frame.FrameElementPercents = new double[] {
    25D,
    60D,
    15D};
      this.donut4.Frame.OuterBand.Gradient.UseMiddle = false;
      this.donut4.LabelMember = "Labels";
      this.donut4.Marks.Visible = false;
      this.donut4.MarksPie.InsideSlice = true;
      this.donut4.MarksPie.LegSize = 0;
      this.donut4.MarksPie.Rotated = false;
      this.donut4.MarksPie.RotateStyle = Steema.TeeChart.Styles.Pie.MarksRotateStyle.Radial;
      this.donut4.MarksPie.VertCenter = false;
      this.donut4.MultiPie = Steema.TeeChart.Styles.MultiPies.Automatic;
      this.donut4.OriginalCursor = null;
      this.donut4.OtherSlice.Color = System.Drawing.Color.Empty;
      this.donut4.OtherSlice.Style = Steema.TeeChart.Styles.PieOtherStyles.None;
      this.donut4.OtherSlice.Text = "";
      this.donut4.OtherSlice.Value = 0D;
      this.donut4.Pen.Width = 3;
      this.donut4.RotationAngle = 332;
      this.donut4.Title = "donut4";
      this.donut4.UniqueCustomRadius = true;
      this.donut4.UseExtendedNumRange = false;
      this.donut4.XValues.DataMember = "Angle";
      this.donut4.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;

      this.donut4.YValues.DataMember = "Pie";

      donut4.Add(rand.NextDouble() * 1000);
      donut4.Add(1000 - donut4.YValues.Last);
      donut4.Pen.Fill.Color = donut1.Chart.Panel.Brush.Gradient.StartColor; //  Color.Black;
      donut4.Pen.Fill.Visible = true;
    }

    private void ConfigHighLow()
    {
      //tChart6.Axes.Left.SetMinMax(0, (line1.YValues.Maximum > line2.YValues.Maximum) ? line1.YValues.Maximum + 50 : line2.YValues.Maximum + 50);

      annotation1.PositionUnits = PositionUnits.Pixels;
      annotation2.PositionUnits = PositionUnits.Pixels;

      annotation1.Position = AnnotationPositions.Custom;
      annotation2.Position = AnnotationPositions.Custom;

      tChart6.Axes.Left.Maximum = 1000;

      highLow1.HighBrush.Visible = true;
      highLow1.HighBrush.Gradient.Visible = true;
      highLow1.HighBrush.Transparency = 50;
      highLow1.LowBrush.Visible = true;
      highLow1.LowBrush.Gradient.Visible = true;
      highLow1.LowBrush.Transparency = 50;

      for (int i = 0; i < line1.Count; i++) {
        highLow1.Add(line1.XValues[i], line1.YValues[i], line2.YValues[i]);
      }

      line3.CheckDataSource();
      line4.CheckDataSource();
    }

    private void addHighLow()
    {
      double newHigh = highLow1.HighValues.Last + Convert.ToDouble(100.0 - (rand.NextDouble() * 50));
      double newLow = highLow1.LowValues.Last + Convert.ToDouble(100.0 - (rand.NextDouble() * 50));

      if (newHigh > 999)
        newHigh = 1000 - (rand.NextDouble() * 200);

      if (newLow > 999)
        newLow = 1000 - (rand.NextDouble() * 200);

      highLow1.Add(highLow1.XValues.Last + (1/86400.0F / 2.0F), newHigh, newLow);

      if (highLow1.Count > 100)
      {
        highLow1.Delete(0);
        //tChart6.Axes.Bottom.Scroll((1.0 / 86400 / 100), false);
        tChart6.Axes.Bottom.SetMinMax(highLow1.XValues[0], highLow1.XValues.Last);
      }

      line3.CheckDataSource();
      line4.CheckDataSource();

    }

    private void ConfigMultiSeries1()
    {
      tChart7.AfterDraw += tChart7_AfterDraw;

      area1.FillSampleValues(100);
      line1.FillSampleValues(100);
      line2.FillSampleValues(100);
      //bar3D1.FillSampleValues(50);

      double startDT = DateTime.Now.ToOADate();

      for (int i = 0; i < area1.XValues.Count; i++)
      {
        area1.XValues[i] =startDT   + (1.0/86400 * i / 2);

        line1.XValues[i] = area1.XValues[i];
        line2.XValues[i] = area1.XValues[i];

        if (line1.YValues[i] > 999)
          line1.YValues[i] = 1000 - (rand.NextDouble() * 200);

        if (line2.YValues[i] > 999)
          line2.YValues[i] = 1000 - (rand.NextDouble() * 200);

        //line1.Add(area1.XValues[i], rand.Next(900));
        //line2.Add(area1.XValues[i], rand.Next(600));

        if (i % 2 == 0)
          bar3D1.Add(area1.XValues[i], 400 - rand.Next(400), 400 + rand.Next(400));
      }

      ConfigHighLow();

    }

    private void modGauges()
    {
      void modDonut(Donut donut)
      {
        double delta1 = rand.NextDouble() * 5;

        if (donut.YValues[1] > 910) donut.YValues[1] = donut.YValues[1] - delta1;
        else if (donut.YValues[1] < 90) donut.YValues[1] = donut.YValues[1] + delta1;
        else donut.YValues[1] = donut.YValues[1] + (1 - delta1);
        donut.YValues[0] = 1000 - donut.YValues[1];
        donut.Repaint();

      }

      modDonut(donut1);
      modDonut(donut2);
      modDonut(donut3);
      modDonut(donut4);

      if (circularGauge1.Value > 65) circularGauge1.Value = circularGauge1.Value - rand.NextDouble() * 2;
      else if (circularGauge1.Value < 10) circularGauge1.Value = circularGauge1.Value + rand.NextDouble() * 2;
      else circularGauge1.Value = circularGauge1.Value + (2 - rand.NextDouble() * 3);
    }

    int OneYesOneNo = 0;
    private void addToMultiSeries()
    {
      double delta1 = rand.NextDouble() * 350;
      double delta2 = rand.NextDouble() * 350;
      double delta3 = (rand.NextDouble() * 350) + 10;

      double newAreaVal = area1.YValues.Last + ((area1.YValues.Last > 449) ? -delta1 : delta1);
      double newLine1Val = line1.YValues.Last + ((line1.YValues.Last > 449) ? -delta1 : delta1);
      double newLine2Val = line2.YValues.Last + ((line2.YValues.Last > 449) ? -delta1 : delta1);

      if (newAreaVal < 100) newAreaVal = 100;
      if (newLine1Val < 100) newLine1Val = 100;
      if (newLine2Val < 100) newLine2Val = 100;

      double timeStamp = area1.XValues.Last + (1 / 86400.0F / 2.0F);

      area1.Add(timeStamp, newAreaVal);
      area1.XValues.Modified = true;

      line1.Add(timeStamp, newLine1Val);
      line2.Add(timeStamp, newLine2Val);

      if (area1.Count == 102)
        OneYesOneNo = 0; //init

      OneYesOneNo++;

      if (OneYesOneNo == 1)
      {
        bar3D1.Add(timeStamp, 400 - rand.Next(400), 400 + rand.Next(400));
        OneYesOneNo = -1;
      }

      if (area1.Count > 110)
      {
        area1.Delete(0);
        area1.XValues.Modified = true;
        line1.Delete(0);
        line1.XValues.Modified = true;
        line2.Delete(0);
        line2.XValues.Modified = true;

        if (bar3D1.Count > 55)
        {
          bar3D1.Delete(0);
          bar3D1.XValues.Modified = true;
        }

        tChart7.Axes.Bottom.SetMinMax(area1.XValues[0], area1.XValues.Last);
      }
    }

    private void ConfigHarmonics()
    {
      tChart8.Aspect.View3D = true;
      //teeOpenGL1.SetChart(tChart8.Chart);
      //teeOpenGL1.Active = true;

      tChart8.Axes.Left.SetMinMax(-1.2, 1.21);
      tChart8.Series.Add(new FastLine());
      tChart8.Series[0].Color = Color.FromArgb(255, 255, 128);
      ((FastLine)(tChart8.Series[0])).LinePen.UseStyling = false;
      Harmonic();
    }

    double[] x = new double[3000];
    int N1 = 3000;
    double p2 = Math.PI * 2;
    int m = 0;
    double freq = 3;
    double aFactor = 1.0;

    private void Harmonic()
    {
      double a;

      //m = 40;  //0 -> 500
      //square if ( (function_type.itemindex=0) )
      {
        for (int n = 0; n < N1; n++)
        {
          x[n] = 0;
          for (int k = 1; k <= m; k++)
          {
            a = aFactor / k;
            if ((((k - 1) % 2) == 0))
              x[n] = x[n] + (4.0 / Math.PI) * a * Math.Sin(p2 * freq * k * n / N1);
          }
        }
      }
      /* sawtooth else
      {
        for (n=0 to N1-1 do
        {
          x[n]=0;
          s=-1;
          for (k=1 to m do
          {
            s=-s;
            a=s/k;
            x[n]=x[n]+(2/pi)*a*sin(p2*3*k*n/N1);
          }
        }
      }*/
      tChart8[0].Clear();
      for (int n = 0; n < N1; n++)
        tChart8[0].Add(n, x[n]);
    }

    bool deltaM = true;

    int tickCount = 0;

    protected void DoTimerTick()
    {
      if (deltaM)
      {
        m = m + 10;
        if (m == 200)
          deltaM = false;
      }
      else
      {
        m = m - 10;
        if (m == 10)
          deltaM = true;
      }

      tickCount++;

      Harmonic();

      addHighLow();

      rotateSurface();

      addToMultiSeries();

      if (tickCount == 70)
      {
        modGauges();
        tickCount =0;
      }

      //PointsPerFrame = tChart[0].Count;

      //base.DoTimerTick();
    }

    private void ConfigSurface(){

      tChart5.Panel.Color = Color.FromArgb(70, 70, 70);
      //teeOpenGL1.SetChart(tChart5.Chart);
      //teeOpenGL1.Active = true;

      //surface.FillSampleValues(35);

      /*
			 *  Arrays of X and Z values with sample points...
			 * The values have floating point decimals and define
			 * an irregular grid
			*/
      double[] xval = new double[10] { 0.1, 0.2, 0.3, 0.5, 0.8, 1.1, 1.5, 2.0, 2.2, 3.0 };
      double[] zval = new double[10] { 0.5, 0.6, 0.7, 0.75, 0.8, 1.1, 1.5, 2.0, 2.2, 5.6 };
      surface.IrregularGrid = true; // <---------- VERY IMPORTANT !!!
      //surface.GetVertAxis.SetMinMax(-2.0, 2.0); // axis scale for Y values

      // Now add all "Y" points...
      // An irregular grid of 10 x 10 cells
      surface.NumXValues = 10;
      surface.NumZValues = 10;

      double y;

      for (int x = 0; x < 9; x++) // = 10 rows
        for (int z = 0; z < 09; z++) // = 10 columns
        {
          //y = (Math.Sin(z * Math.PI / 10.0) * Math.Cos(x * Math.PI / 5.0) + 1) * 700 ;  // example Y value
          y = 700 + Math.Sin(z * Math.PI / 10.0) * Math.Cos(x * Math.PI / 5.0);  // example Y value
          surface.Add(xval[x], y, zval[z]);
        }



      /*this.trackBar1.ValueChanged += TrackBar1_ValueChanged;
      this.trackBar2.ValueChanged += TrackBar2_ValueChanged;
      this.trackBar3.ValueChanged += TrackBar3_ValueChanged;
      this.trackBar4.ValueChanged += TrackBar4_ValueChanged;*/
    }

    int Delta = 1;
    int rotateBrake = 0;
    private void rotateSurface()
    {
      if (rotateBrake % 40 == 0)
      {
        rotateBrake = 0;

        if ((tChart5.Aspect.Rotation == 360)) Delta = -1;
        else if ((tChart5.Aspect.Rotation == 0)) Delta = 1;

        if ((tChart5.Aspect.Rotation <= 360) && (Delta == 1))
          tChart5.Aspect.Rotation++;
        else if ((tChart5.Aspect.Rotation >= 0) && (Delta == -1))
          tChart5.Aspect.Rotation--;
      }
      else
        rotateBrake++;
    }

    private void TrackBar4_ValueChanged(object sender, EventArgs e)
    {
      throw new NotImplementedException();
    }

    private void TrackBar3_ValueChanged(object sender, EventArgs e)
    {
      throw new NotImplementedException();
    }

    private void TrackBar2_ValueChanged(object sender, EventArgs e)
    {
      throw new NotImplementedException();
    }

    private void TrackBar1_ValueChanged(object sender, EventArgs e)
    {
      throw new NotImplementedException();
    }

    private void tChart1_AfterDraw(object sender, Steema.TeeChart.Drawing.Graphics3D g)
    {
      var x = tChart1.Graphics3D.ChartXCenter;
      var y = tChart1.Graphics3D.ChartYCenter + 23;

      if (x > -1)
      {
        g.Font.Color = Color.White;
        g.Font.Bold = true;
        g.TextOut((int)(x - (g.TextWidth(circularGauge1.Value.ToString("#.00")) / 2)), (int)y, circularGauge1.Value.ToString("#.00"));
        g.TextOut((int)(x - (g.TextWidth("ºC")/2)) , (int)y + 20, "ºC");
      }
    }

    private void tChart2_AfterDraw(object sender, Steema.TeeChart.Drawing.Graphics3D g)
    {
      var x = tChart2.Graphics3D.ChartXCenter;
      var y = tChart2.Graphics3D.ChartYCenter;

      if (x > -1)
      {
        g.Font.Color = Color.White;
        g.Font.Size = 16;
        g.TextOut((int)(x - (g.TextWidth(donut1.YValues[1].ToString("#.00")) / 2)), (int)(y - (g.TextHeight("H")/2)), donut1.YValues[1].ToString("#.00"));
        g.Font.Size = 10;
        g.TextOut((int)(x - (g.TextWidth("ºC") / 2)), (int)y + 40, "ºC");
      }
    }

    private void tChart3_AfterDraw(object sender, Steema.TeeChart.Drawing.Graphics3D g)
    {
      var x = tChart3.Graphics3D.ChartXCenter;
      var y = tChart3.Graphics3D.ChartYCenter;

      if (x > -1)
      {
        g.Font.Color = Color.White;
        g.Font.Size = 16;
        g.TextOut((int)(x - (g.TextWidth(donut2.YValues[1].ToString("#.00")) / 2)), (int)(y - (g.TextHeight("H") / 2)), donut2.YValues[1].ToString("#.00"));
        g.Font.Size = 10;
        g.TextOut((int)(x - (g.TextWidth("ºC") / 2)), (int)y + 40, "ºC");
      }
    }

    private void tChart4_AfterDraw(object sender, Steema.TeeChart.Drawing.Graphics3D g)
    {
      var x = tChart4.Graphics3D.ChartXCenter;
      var y = tChart4.Graphics3D.ChartYCenter;

      if (x > -1)
      {
        g.Font.Color = Color.White;
        g.Font.Size = 16;
        g.TextOut((int)(x - (g.TextWidth(donut3.YValues[1].ToString("#.00")) / 2)), (int)(y - (g.TextHeight("H") / 2)), donut3.YValues[1].ToString("#.00"));
        g.Font.Size = 10;
        g.TextOut((int)(x - (g.TextWidth("ºC") / 2)), (int)y + 40, "ºC");
      }
    }

    // surface ***************************************

    private double a, b, c, d;
    private bool Changing;
    private int Formula, oldFormula;
    private int DeltaA, DeltaB, DeltaC, DeltaD;


    string cursorText = "";
    int cursorX = -1;
    int cursorY = -1;
    private void cursorTool1_Change(object sender, Steema.TeeChart.Tools.CursorChangeEventArgs e)
    {
      cursorText = line2.YScreenToValue(e.y).ToString("#.00");
      cursorX = e.x;
      cursorY = e.y;


    }

    private void tChart7_AfterDraw(object sender, Steema.TeeChart.Drawing.Graphics3D g)
    {
      if (!timer1.Enabled)
      {
        if (cursorX != -1)
        {
          g.Font.Color = Color.White;
          g.Font.Size = 12;
          g.TextOut(cursorX + 3, (int)(cursorY - g.TextHeight("H") - 2), "Freq. Hz.: " + cursorText);
        }
      }
    }

    private void tChart9_AfterDraw(object sender, Steema.TeeChart.Drawing.Graphics3D g)
    {
      var x = tChart9.Graphics3D.ChartXCenter;
      var y = tChart9.Graphics3D.ChartYCenter;

      if (x > -1)
      {
        g.Font.Color = Color.White;
        g.Font.Size = 16;
        g.TextOut((int)(x - (g.TextWidth(donut4.YValues[1].ToString("#.00")) / 2)), (int)(y - (g.TextHeight("H") / 2)), donut4.YValues[1].ToString("#.00"));
        g.Font.Size = 10;
        g.TextOut((int)(x - (g.TextWidth("ºC") / 2)), (int)y + 40, "ºC");
      }
    }

    private void tChart6_BeforeDrawSeries(object sender, Steema.TeeChart.Drawing.Graphics3D g)
    {
      var pRight = tChart6.Axes.Bottom.CalcPosValue(tChart6.Axes.Bottom.Maximum);

      annotation1.Left = (int)(pRight - g.TextWidth(annotation1.Text));
      annotation2.Left = (int)(pRight - g.TextWidth(annotation2.Text));

      annotation1.Top = (int)(tChart6.Axes.Custom[0].CalcPosValue(colorBand1.End) - g.TextHeight("H"));
      annotation2.Top = tChart6.Axes.Custom[0].CalcPosValue(colorBand1.Start);
    }

    private void button2_Click(object sender, EventArgs e)
    {
      //rotateSurface();
    }

    private void tChart9_BeforeDrawAxes(object sender, Steema.TeeChart.Drawing.Graphics3D g)
    {
      tChart9.Footer.Top = tChart9.Chart.ChartBounds.Height - 30;
    }

    private void tChart1_BeforeDrawAxes(object sender, Steema.TeeChart.Drawing.Graphics3D g)
    {
      tChart1.Footer.Top = tChart1.Chart.ChartBounds.Height - 30;
    }

    private void InitSurface()
    {
      Changing = false;
      DeltaA = 2;
      DeltaB = 2;
      DeltaC = 6;
      DeltaD = 6;
      a = 3.0;
      b = 10.0;
      c = 5.0;
      d = 1.0;
      //trackBar3.Value = 100;
      Formula = 0;
      Fill();
    }

    private void Fill()
    {
      /* do a loop && fill a 21 x 21 surface... */
      if (!Changing)
        surface.Clear();
      for (int i = -10; i <= 10; i++)
        for (int j = -10; j <= 10; j++) surface.Add(i, Calc(i, j), j);
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      DoTimerTick();
      /*timer1.Enabled = false;
      Changing = true;
      ChangeScroll(trackBar1, ref DeltaA);
      ChangeScroll(trackBar2, ref DeltaB);
      ChangeScroll(trackBar3, ref DeltaC);
      ChangeScroll(trackBar4, ref DeltaD);
      Changing = false;
      Fill();
      timer1.Enabled = true;*/
    }

    private void button1_Click(object sender, EventArgs e)
    {
      timer1.Enabled = !timer1.Enabled;

      cursorTool1.Active = !timer1.Enabled;
      if (cursorTool1.Active)
      {
        cursorTool1.XValue = tChart7.Axes.Bottom.Minimum + (tChart7.Axes.Bottom.iRange / 2);
        cursorTool1.YValue = tChart7.Axes.Left.Minimum + (tChart7.Axes.Left.iRange / 2);
      }

      if (!timer1.Enabled)
        tChart6.Aspect.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
      else
        tChart6.Aspect.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
    }

    /* return a surface cell value... */
    private double Calc(double x, double y)
    {
      Random r = new Random();

      switch (Formula)
      {
        case 0:
          {
            x = x / 3.0;
            y = y / 3.0;
            return a * Math.Pow(d - x, 2) * Math.Exp(-(x * x) - Math.Pow(y + d, 2))
              - b * (x / c - (x * x * x) - (y * y * y * y * y)) * Math.Exp(-Math.Pow(x, 2) - Math.Pow(y, 2))
              - (d / a) * Math.Exp(-Math.Pow(x + d, 2) - Math.Pow(y, 2));
          }
        case 1:
          {
            x = (x / 15.0) * r.Next(100) / 100.0;
            y = (y / 15.0) * r.Next(100) / 100.0;
            return Math.Cos(x + Math.Pow(y, 2) + a * b * c * d);
          }
        case 2:
          {
            x = (x / 15.0) * Math.PI / 3.0;
            y = (y / 15.0) * Math.PI / 1;
            return Math.Cos(Math.Pow(a, 2) + x * Math.Sin(y) + Math.Sin(Math.Pow(b, 2) + x) * Math.Pow(Math.Cos(Math.Pow(c * d + y, 2)), 2)); ;
          }
        default: { return 0; }
      }
    }

    private void trackBarValueChanged()
    {
      a = trackBar1.Value / 100.0;
      b = trackBar2.Value / 100.0;
      c = trackBar3.Value / 100.0;
      d = trackBar4.Value / 100.0;
      Fill();
    }

    private void ChangeScroll(System.Windows.Forms.TrackBar trackBar, ref int aDelta)
    {
      if (((trackBar.Value + aDelta) < trackBar.Minimum) || ((trackBar.Value + aDelta) > trackBar.Maximum))
        aDelta = -aDelta;
      else
        trackBar.Value = trackBar.Value + aDelta;
    }

    // surface ***************************************

  }
}
