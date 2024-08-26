using Microsoft.Maui;
using Steema.TeeChart.Drawing;
using Steema.TeeChart.Maui;
using Steema.TeeChart.Styles;
using Shape = Steema.TeeChart.Styles.Shape;

namespace TeeChartMockUpDemos
{
    public partial class AllCharts : ContentPage
    {
        public AllCharts()
        {
            InitializeComponent();
            
            var line = new Line(tChart1.Chart);
            var bar = new Bar(tChart2.Chart);
            var area = new Area(tChart3.Chart);
            var pie = new Pie(tChart4.Chart);
            pie.Circled = true;
            pie.Marks.Visible = false;
            tChart4.Chart.Header.Visible = false;

            var bubble = new Bubble(tChart5.Chart);
            var donut = new Donut(tChart6.Chart);
            donut.Circled = true;
            var candle = new Candle(tChart7.Chart);
            var volume = new Volume(tChart8.Chart);

            var horizline = new HorizLine(tChart9.Chart);
            var horizbar = new HorizBar(tChart10.Chart);
            var horizarea = new HorizArea(tChart11.Chart);
            var fastline = new FastLine(tChart12.Chart);

            var pyramid = new Pyramid(tChart13.Chart);
            var points = new Points(tChart14.Chart);
            var shape = new Shape(tChart15.Chart);
            var highlow = new HighLow(tChart16.Chart);

            var gantt = new Gantt(tChart17.Chart);
            var activitygauge = new Points(tChart18.Chart);
            var surface = new Surface(tChart19.Chart);
            var contour = new Contour(tChart20.Chart);

            var waterfall = new Waterfall(tChart21.Chart);
            var colorgrid = new ColorGrid(tChart22.Chart);
            var vector3d = new Vector3D(tChart23.Chart);
            var tower = new Tower(tChart24.Chart);

            var isosurface = new IsoSurface(tChart25.Chart);
            var polargrid = new PolarGrid(tChart26.Chart);
            var tagcloud = new TagCloud(tChart27.Chart);
            var windrose = new WindRose(tChart28.Chart);

            var histogram = new Histogram(tChart29.Chart);
            var volumepipe = new VolumePipe(tChart30.Chart);
            //var funnel = new Funnel(tChart31.Chart);
            //var errorbar = new ErrorBar(tChart32.Chart);

            line.FillSampleValues();
            bar.FillSampleValues();
            area.FillSampleValues();
            pie.FillSampleValues();

            bubble.FillSampleValues();
            donut.FillSampleValues();
            candle.FillSampleValues();
            volume.FillSampleValues();  

            horizline.FillSampleValues();   
            horizbar.FillSampleValues();   
            horizarea.FillSampleValues();
            fastline.FillSampleValues();

            pyramid.FillSampleValues(); 
            points.FillSampleValues();  
            shape.FillSampleValues();   
            highlow.FillSampleValues();

            gantt.FillSampleValues();
            activitygauge.FillSampleValues();
            surface.FillSampleValues();
            contour.FillSampleValues();

            waterfall.FillSampleValues();
            colorgrid.FillSampleValues();
            vector3d.FillSampleValues();
            tower.FillSampleValues();

            isosurface.FillSampleValues();
            polargrid.FillSampleValues();
            tagcloud.FillSampleValues();
            windrose.FillSampleValues();

            histogram.FillSampleValues();
            volumepipe.FillSampleValues();
            //funnel = new Funnel(tChart31.Chart);
            //errorbar = new ErrorBar(tChart32.Chart);

            view3D.CheckedChanged += View3D_CheckedChanged;
            tChart24.Chart.Zoom.Active = false;
            tChart24.Chart.Panning.Active = false;
            var _rotateTool = new Steema.TeeChart.Tools.Rotate();
            _rotateTool.Style = Steema.TeeChart.Tools.RotateStyles.Rotation;
            tChart24.Chart.Tools.Add(_rotateTool);

        }
        
        private void View3D_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            tChart1.Chart.Aspect.View3D = e.Value;
            tChart2.Chart.Aspect.View3D = e.Value;
            tChart3.Chart.Aspect.View3D = e.Value;
            tChart4.Chart.Aspect.View3D = e.Value;
            tChart5.Chart.Aspect.View3D = e.Value;
            tChart6.Chart.Aspect.View3D = e.Value;
            tChart7.Chart.Aspect.View3D = e.Value;
            tChart8.Chart.Aspect.View3D = e.Value;
            tChart9.Chart.Aspect.View3D = e.Value;
            tChart10.Chart.Aspect.View3D = e.Value;
            tChart11.Chart.Aspect.View3D = e.Value;
            tChart12.Chart.Aspect.View3D = e.Value;
            tChart13.Chart.Aspect.View3D = e.Value;
            tChart14.Chart.Aspect.View3D = e.Value;
            tChart15.Chart.Aspect.View3D = e.Value;
            tChart16.Chart.Aspect.View3D = e.Value;
            tChart24.Chart.Aspect.View3D = e.Value;

            InvalidateMeasure();
        }
        

    }
}
