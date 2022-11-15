using Steema.TeeChart;
using Steema.TeeChart.Styles;
using Steema.TeeChart.Tools;

namespace Drag_Drop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeChart();
        }

        private int _index = -1;
        private Selector? select;
        private readonly DateTime[] xvalues = new DateTime[11] { DateTime.Parse("2022/11/8"), DateTime.Parse("2022/11/9"), DateTime.Parse("2022/11/10"),
                                             DateTime.Parse("2022/11/11"), DateTime.Parse("2022/11/12"), DateTime.Parse("2022/11/13"),
                                             DateTime.Parse("2022/11/14"), DateTime.Parse("2022/11/15"), DateTime.Parse("2022/11/16"),
                                             DateTime.Parse("2022/11/17"), DateTime.Parse("2022/11/18")};
        private readonly double[] _yvalues1 = new double[11] { 5, 3, 10, 8, 3, 6, 5, 8, 10, 7, 8 };
        private readonly double[] _yvalues2 = new double[11] { 15, 11, 20, 18, 12, 16, 15, 18, 20, 17, 18 };
        private Line? line1, line2;
        private Series? _selectedSeries = null;


        private void InitializeChart()
        {
            tChart1.Header.Text = "Drag and drop series";
            tChart1.Axes.Left.SetMinMax(0, 20);

            line1 = new(tChart1.Chart);
            line2 = new(tChart1.Chart);

            line1.XValues.DateTime = true;
            line2.XValues.DateTime = true;

            AddValues();

            select = new(tChart1.Chart);
            select.Selected += Select_Selected;

            tChart1.Zoom.Direction = ZoomDirections.None;

            tChart1.MouseMove += TChart1_MouseMove;
            tChart1.MouseUp += TChart1_MouseUp;
        }

        private void TChart1_MouseUp(object? sender, MouseEventArgs e)
        {
            Clear();
            if (select != null)
            {
                select.Part = new ChartClickedPart { Part = ChartClickedPartStyle.ChartRect };
            }
        }

        private void TChart1_MouseMove(object? sender, MouseEventArgs e)
        {
            if (_selectedSeries != null)
            {
                if (_index == -1)
                {
                    _index = _selectedSeries.Clicked(e.X, e.Y);
                }

                if (_index > -1)
                {
                    double screen = _selectedSeries.YScreenToValue(e.Y);
                    double value = _selectedSeries.YValues[_index];

                    for (int i = 0; i < _selectedSeries.Count; i++)
                    {
                        _selectedSeries.YValues[i] = _selectedSeries.YValues[i] - value + screen;
                    }
                }
            }
            else
            {
                Clear();
            }
        }

        private void AddValues()
        {
            if (line1 != null && line2 != null)
            {
                line1.Add(xvalues, _yvalues1.Clone() as double[]);
                line2.Add(xvalues, _yvalues2.Clone() as double[]);
            }
        }

        private void Clear()
        {
            _selectedSeries = null;
            _index = -1;
        }

        private void Select_Selected(object sender, EventArgs e)
        {
            Clear();
            _selectedSeries = ((Selector)sender).Series;
        }

        private void cbSelector_CheckedChanged(object sender, EventArgs e)
        {
            if (select != null)
            {
                select.Active = cbSelector.Checked;
            }
        }

        private void cbBlackDots_CheckedChanged(object sender, EventArgs e)
        {
            if (select != null)
            {
                select.DrawHandles = cbBlackDots.Checked;
            }
        }

        private void cbZoom_CheckedChanged(object sender, EventArgs e)
        {
            tChart1.Zoom.Direction = cbZoom.Checked ? ZoomDirections.Both : ZoomDirections.None;
        }

        private void cbXval_CheckedChanged(object sender, EventArgs e)
        {
            if (line1 != null && line2 != null)
            {
                if (cbXval.Checked)
                {
                    for (int i = 2; i < 5; i++)
                    {
                        line1.SetNull(i, true);
                        line2.SetNull(i, true);
                    }

                }
                else
                {
                    for (int i = 2; i < 5; i++)
                    {
                        line1.SetNull(i, false);
                        line2.SetNull(i, false);
                    }
                }

                tChart1.Invalidate();
            }
        }

        private void bReset_Click(object sender, EventArgs e)
        {
            Clear();
            if (line1 != null && line2 != null)
            {
                line1.Clear();
                line2.Clear();
            }
            AddValues();
        }
    }
}