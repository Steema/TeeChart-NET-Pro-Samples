using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Steema.TeeChart;
using Steema.TeeChart.Styles;

namespace NewTeeChartNETDemos
{
    public sealed class DowJonesTickerDemo : AttentionChartDemoBase
    {
        private const double InitialIndex = 44150.0;
        private const int HistoryLength = 80;

        private readonly List<StockQuote> stocks = new();
        private readonly List<double> indexHistory = new();
        private Line indexSeries = null!;
        private Area indexArea = null!;
        private Points indexLastPoint = null!;
        private Bar moversSeries = null!;
        private DataGridView tickerGrid = null!;
        private Label indexValueLabel = null!;
        private Label indexChangeLabel = null!;
        private Label breadthLabel = null!;
        private Label volatilityLabel = null!;
        private Label lastUpdateLabel = null!;
        private double simulatedIndex = InitialIndex;

        public DowJonesTickerDemo() : base("Dow Jones Live Ticker")
        {
            Text = "TeeChart - Dow Jones Live Ticker (simulated)";
            Width = 1450;
            Height = 900;

            InitializeStockUniverse();
            BuildDashboardLayout();
            ConfigureIndexChart();
            ConfigureMoversChart();
            ConfigureTickerGrid();
            RefreshDashboard(0);
            StartValueAnimation(RefreshDashboard);
        }

        private void InitializeStockUniverse()
        {
            AddStock("AAPL", "Apple", 191.25, 0.009, 18.4);
            AddStock("AMGN", "Amgen", 287.40, 0.012, 2.5);
            AddStock("AMZN", "Amazon", 178.20, 0.014, 15.1);
            AddStock("AXP", "American Express", 235.60, 0.010, 2.9);
            AddStock("BA", "Boeing", 176.80, 0.022, 5.8);
            AddStock("CAT", "Caterpillar", 358.30, 0.013, 3.1);
            AddStock("CRM", "Salesforce", 330.15, 0.016, 4.8);
            AddStock("CSCO", "Cisco", 61.25, 0.008, 12.2);
            AddStock("CVX", "Chevron", 153.45, 0.011, 6.9);
            AddStock("DIS", "Walt Disney", 112.70, 0.019, 7.1);
            AddStock("GS", "Goldman Sachs", 610.20, 0.014, 2.3);
            AddStock("HD", "Home Depot", 378.45, 0.010, 3.7);
            AddStock("HON", "Honeywell", 219.35, 0.010, 2.8);
            AddStock("IBM", "IBM", 252.80, 0.009, 4.5);
            AddStock("JNJ", "Johnson & Johnson", 162.25, 0.007, 7.4);
            AddStock("JPM", "JPMorgan Chase", 240.75, 0.012, 8.6);
            AddStock("KO", "Coca-Cola", 72.35, 0.006, 11.6);
            AddStock("MCD", "McDonald's", 302.10, 0.009, 2.4);
            AddStock("MRK", "Merck", 100.15, 0.011, 10.3);
            AddStock("MSFT", "Microsoft", 421.60, 0.010, 17.7);
            AddStock("NKE", "Nike", 72.80, 0.018, 8.2);
            AddStock("NVDA", "NVIDIA", 135.70, 0.025, 34.0);
            AddStock("PG", "Procter & Gamble", 168.40, 0.006, 6.8);
            AddStock("SHW", "Sherwin-Williams", 377.80, 0.013, 1.4);
            AddStock("TRV", "Travelers", 257.65, 0.010, 1.7);
            AddStock("UNH", "UnitedHealth", 520.30, 0.020, 3.3);
            AddStock("V", "Visa", 330.55, 0.009, 7.6);
            AddStock("VZ", "Verizon", 44.20, 0.007, 14.7);
            AddStock("WMT", "Walmart", 101.60, 0.008, 13.8);
            AddStock("MMM", "3M", 151.20, 0.013, 2.1);

            for (int i = 0; i < HistoryLength; i++)
            {
                double sample = InitialIndex
                    + 110 * Math.Sin(i * 0.12)
                    + 45 * Math.Sin(i * 0.43)
                    + (i - HistoryLength) * 0.45;
                indexHistory.Add(sample);
            }
        }

        private void AddStock(string symbol, string company, double price, double volatility, double volumeMillions)
        {
            // The universe mirrors the familiar Dow blue-chip ticker set; values are demo baselines.
            stocks.Add(new StockQuote(symbol, company, price, volatility, volumeMillions, stocks.Count * 0.71));
        }

        private void BuildDashboardLayout()
        {
            Controls.Remove(TeeChart);

            var dashboard = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.FromArgb(10, 22, 33),
                ColumnCount = 1,
                RowCount = 3,
                Padding = new Padding(8)
            };
            dashboard.RowStyles.Add(new RowStyle(SizeType.Absolute, 78));
            dashboard.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
            dashboard.RowStyles.Add(new RowStyle(SizeType.Absolute, 220));

            var metrics = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 4,
                RowCount = 1,
                BackColor = Color.FromArgb(10, 22, 33)
            };
            for (int i = 0; i < 4; i++)
                metrics.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25));

            metrics.Controls.Add(CreateMetricCard("DJIA · POINTS", out indexValueLabel, Color.FromArgb(74, 197, 255)), 0, 0);
            metrics.Controls.Add(CreateMetricCard("CHANGE", out indexChangeLabel, Color.FromArgb(75, 220, 155)), 1, 0);
            metrics.Controls.Add(CreateMetricCard("BREADTH · ↑ / ↓", out breadthLabel, Color.FromArgb(255, 196, 79)), 2, 0);
            metrics.Controls.Add(CreateMetricCard("MAX VOLATILITY", out volatilityLabel, Color.FromArgb(255, 105, 118)), 3, 0);

            var charts = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 2,
                RowCount = 1,
                BackColor = Color.FromArgb(10, 22, 33),
                Margin = new Padding(0, 6, 0, 6)
            };
            charts.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70));
            charts.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30));
            charts.Controls.Add(TeeChart, 0, 0);
            TeeChart.Dock = DockStyle.Fill;

            var moversChart = new TChart { Dock = DockStyle.Fill };
            charts.Controls.Add(moversChart, 1, 0);
            moversChart.Tag = "MoversChart";

            tickerGrid = new DataGridView();
            lastUpdateLabel = new Label
            {
                Dock = DockStyle.Bottom,
                Height = 18,
                TextAlign = ContentAlignment.MiddleRight,
                ForeColor = Color.FromArgb(140, 170, 185),
                BackColor = Color.FromArgb(10, 22, 33),
                Font = new Font("Segoe UI", 8)
            };

            dashboard.Controls.Add(metrics, 0, 0);
            dashboard.Controls.Add(charts, 0, 1);
            dashboard.Controls.Add(tickerGrid, 0, 2);
            Controls.Add(dashboard);
            Controls.Add(lastUpdateLabel);
            lastUpdateLabel.BringToFront();

            _moversChart = moversChart;
        }

        private TChart _moversChart = null!;

        private static System.Windows.Forms.Panel CreateMetricCard(string caption, out Label valueLabel, Color accent)
        {
            var card = new System.Windows.Forms.Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.FromArgb(18, 39, 54),
                Margin = new Padding(4, 0, 4, 0),
                Padding = new Padding(12, 7, 12, 4)
            };
            var captionLabel = new Label
            {
                Dock = DockStyle.Top,
                Height = 20,
                Text = caption,
                ForeColor = Color.FromArgb(150, 181, 194),
                Font = new Font("Segoe UI", 8, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter
            };
            valueLabel = new Label
            {
                Dock = DockStyle.Fill,
                Text = "--",
                ForeColor = accent,
                Font = new Font("Segoe UI", 17, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter
            };
            card.Controls.Add(valueLabel);
            card.Controls.Add(captionLabel);
            return card;
        }

        private void ConfigureIndexChart()
        {
            TeeChart.Panel.Color = Color.FromArgb(14, 28, 41);
            TeeChart.Header.Text = "DJIA synthetic intraday pulse · 80 ticks";
            TeeChart.Header.Font.Color = Color.White;
            TeeChart.Header.Font.Size = 12;
            TeeChart.Legend.Visible = false;
            TeeChart.Aspect.View3D = false;

            indexArea = new Area(TeeChart.Chart)
            {
                Title = "DJIA range",
                Color = Color.FromArgb(56, 145, 196)
            };
            indexArea.AreaBrush.Color = Color.FromArgb(56, 145, 196);
            indexArea.AreaBrush.Transparency = 91;
            indexArea.LinePen.Visible = false;
            indexArea.Pointer.Visible = false;

            indexSeries = new Line(TeeChart.Chart)
            {
                Title = "DJIA",
                Color = Color.FromArgb(74, 197, 255)
            };
            indexSeries.LinePen.Width = 2;
            indexSeries.Pointer.Visible = false;

            indexLastPoint = new Points(TeeChart.Chart)
            {
                Title = "Last",
                Color = Color.FromArgb(255, 255, 255)
            };
            indexLastPoint.Pointer.Style = PointerStyles.Circle;
            indexLastPoint.Pointer.HorizSize = 5;
            indexLastPoint.Pointer.VertSize = 5;
            indexLastPoint.Pointer.Brush.Color = Color.FromArgb(74, 197, 255);
            indexLastPoint.Pointer.Pen.Color = Color.White;
            indexLastPoint.Marks.Visible = false;

            for (int i = 0; i < indexHistory.Count; i++)
            {
                indexArea.Add(i, indexHistory[i]);
                indexSeries.Add(i, indexHistory[i]);
            }
            indexLastPoint.Add(HistoryLength - 1, indexHistory[indexHistory.Count - 1]);

            TeeChart.Axes.Bottom.SetMinMax(0, HistoryLength - 1);
            TeeChart.Axes.Bottom.Increment = 10;
            TeeChart.Axes.Bottom.Labels.Visible = false;
            TeeChart.Axes.Left.SetMinMax(42500, 45500);
            TeeChart.Axes.Left.Increment = 500;
            TeeChart.Axes.Left.Labels.ValueFormat = "#,##0";
            TeeChart.Axes.Left.Labels.Font.Color = Color.FromArgb(190, 215, 225);
            TeeChart.Axes.Left.Title.Text = "DJIA points";
            TeeChart.Axes.Left.Title.Font.Color = Color.FromArgb(150, 181, 194);
            TeeChart.Axes.Left.Grid.Transparency = 84;
            TeeChart.Axes.Bottom.Grid.Transparency = 88;
        }

        private void ConfigureMoversChart()
        {
            _moversChart.Panel.Color = Color.FromArgb(14, 28, 41);
            _moversChart.Header.Text = "Largest moves · %";
            _moversChart.Header.Font.Color = Color.White;
            _moversChart.Header.Font.Size = 11;
            _moversChart.Legend.Visible = false;
            _moversChart.Aspect.View3D = false;

            moversSeries = new Bar(_moversChart.Chart)
            {
                Title = "Movers",
                ColorEach = true
            };
            moversSeries.Marks.Visible = true;
            moversSeries.Marks.Style = MarksStyles.Value;
            moversSeries.Marks.Transparent = true;
            moversSeries.Marks.Font.Color = Color.FromArgb(220, 235, 240);
            moversSeries.Marks.Font.Size = 8;

            _moversChart.Axes.Bottom.SetMinMax(0, 7);
            _moversChart.Axes.Bottom.Labels.Font.Color = Color.FromArgb(190, 215, 225);
            _moversChart.Axes.Bottom.Grid.Visible = false;
            _moversChart.Axes.Left.SetMinMax(-3.5, 3.5);
            _moversChart.Axes.Left.Increment = 1;
            // Values are already expressed in percentage points (for example, +1.4).
            _moversChart.Axes.Left.Labels.ValueFormat = "+0.0;-0.0";
            _moversChart.Axes.Left.Labels.Font.Color = Color.FromArgb(190, 215, 225);
            _moversChart.Axes.Left.Grid.Transparency = 86;
        }

        private void ConfigureTickerGrid()
        {
            tickerGrid.Dock = DockStyle.Fill;
            tickerGrid.ReadOnly = true;
            tickerGrid.AllowUserToAddRows = false;
            tickerGrid.AllowUserToDeleteRows = false;
            tickerGrid.AllowUserToResizeRows = false;
            tickerGrid.RowHeadersVisible = false;
            tickerGrid.AutoGenerateColumns = false;
            tickerGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tickerGrid.MultiSelect = false;
            tickerGrid.BorderStyle = BorderStyle.None;
            tickerGrid.BackgroundColor = Color.FromArgb(14, 28, 41);
            tickerGrid.GridColor = Color.FromArgb(45, 72, 86);
            tickerGrid.EnableHeadersVisualStyles = false;
            tickerGrid.ColumnHeadersHeight = 25;
            tickerGrid.RowTemplate.Height = 23;
            tickerGrid.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.FromArgb(24, 48, 64),
                ForeColor = Color.FromArgb(190, 215, 225),
                Font = new Font("Segoe UI", 8, FontStyle.Bold)
            };
            tickerGrid.DefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.FromArgb(14, 28, 41),
                ForeColor = Color.White,
                SelectionBackColor = Color.FromArgb(40, 76, 91),
                SelectionForeColor = Color.White,
                Font = new Font("Segoe UI", 8),
                Padding = new Padding(3, 0, 3, 0)
            };

            AddGridColumn("Signal", " ", 46);
            AddGridColumn("Symbol", "Symbol", 72);
            AddGridColumn("Company", "Company", 190);
            AddGridColumn("Price", "Last", 95);
            AddGridColumn("Change", "Change", 90);
            AddGridColumn("Volume", "Volume M", 100);
            AddGridColumn("Status", "Readout", 120);

            foreach (StockQuote stock in stocks)
                tickerGrid.Rows.Add("", stock.Symbol, stock.Company, "", "", "", "");
        }

        private void AddGridColumn(string name, string header, int width)
        {
            tickerGrid.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = name,
                HeaderText = header,
                Width = width,
                SortMode = DataGridViewColumnSortMode.NotSortable
            });
        }

        private void RefreshDashboard(double phase)
        {
            UpdateStockPrices(phase);
            UpdateIndexSeries();
            UpdateMoversChart();
            UpdateTickerGrid();
            UpdateMetrics();
        }

        private void UpdateStockPrices(double phase)
        {
            double weightedMove = 0;
            foreach (StockQuote stock in stocks)
            {
                double primaryWave = Math.Sin(phase * 0.62 + stock.Phase);
                double fastWave = Math.Sin(phase * 1.75 + stock.Phase * 0.73);
                double newsPulse = Math.Max(0, Math.Sin(phase * 0.19 + stock.Phase * 1.7));
                double move = 0.0045 * primaryWave
                    + stock.Volatility * 0.95 * fastWave
                    + stock.Volatility * 0.55 * newsPulse * Math.Sign(Math.Sin(stock.Phase * 2.3));

                stock.Price = stock.PreviousClose * (1 + move);
                stock.ChangePercent = (stock.Price / stock.PreviousClose - 1) * 100;
                stock.VolumeMillions = stock.BaseVolumeMillions
                    * (0.72 + 0.28 * Math.Abs(fastWave) + (Math.Abs(stock.ChangePercent) > 1.0 ? 0.48 : 0));
                stock.History.Add(stock.Price);
                if (stock.History.Count > 24)
                    stock.History.RemoveAt(0);

                weightedMove += stock.ChangePercent * stock.Weight;
            }

            simulatedIndex = InitialIndex * (1 + weightedMove / 100);
            indexHistory.Add(simulatedIndex);
            if (indexHistory.Count > HistoryLength)
                indexHistory.RemoveAt(0);
        }

        private void UpdateIndexSeries()
        {
            indexArea.BeginUpdate();
            indexSeries.BeginUpdate();
            try
            {
                indexArea.Clear();
                indexSeries.Clear();
                for (int i = 0; i < indexHistory.Count; i++)
                {
                    indexArea.Add(i, indexHistory[i]);
                    indexSeries.Add(i, indexHistory[i]);
                }

                indexLastPoint.XValues[0] = indexHistory.Count - 1;
                indexLastPoint.YValues[0] = simulatedIndex;
            }
            finally
            {
                indexSeries.EndUpdate();
                indexArea.EndUpdate();
            }
        }

        private void UpdateMoversChart()
        {
            var movers = new List<StockQuote>(stocks);
            movers.Sort((left, right) => Math.Abs(right.ChangePercent).CompareTo(Math.Abs(left.ChangePercent)));

            moversSeries.BeginUpdate();
            try
            {
                moversSeries.Clear();
                int count = Math.Min(8, movers.Count);
                for (int i = 0; i < count; i++)
                {
                    StockQuote stock = movers[i];
                    Color color = stock.ChangePercent >= 0
                        ? Color.FromArgb(75, 220, 155)
                        : Color.FromArgb(255, 105, 118);
                    moversSeries.Add(stock.ChangePercent, stock.Symbol, color);
                }
            }
            finally
            {
                moversSeries.EndUpdate();
            }
        }

        private void UpdateTickerGrid()
        {
            if (tickerGrid.IsDisposed || tickerGrid.Rows.Count < stocks.Count)
                return;

            for (int i = 0; i < stocks.Count; i++)
            {
                StockQuote stock = stocks[i];
                DataGridViewRow row = tickerGrid.Rows[i];
                bool important = Math.Abs(stock.ChangePercent) >= 1.0;
                Color directionColor = stock.ChangePercent >= 0
                    ? Color.FromArgb(75, 220, 155)
                    : Color.FromArgb(255, 105, 118);

                row.Cells[0].Value = important ? "⚡" : (stock.ChangePercent >= 0 ? "▲" : "▼");
                row.Cells[3].Value = $"${stock.Price:N2}";
                row.Cells[4].Value = $"{(stock.ChangePercent >= 0 ? "+" : "")}{stock.ChangePercent:F2}%";
                row.Cells[5].Value = $"{stock.VolumeMillions:N1}";
                row.Cells[6].Value = important ? "Strong move" : "In range";

                row.DefaultCellStyle.BackColor = important
                    ? (stock.ChangePercent >= 0 ? Color.FromArgb(22, 67, 54) : Color.FromArgb(74, 35, 45))
                    : Color.FromArgb(14, 28, 41);
                row.Cells[0].Style.ForeColor = directionColor;
                row.Cells[4].Style.ForeColor = directionColor;
                row.Cells[6].Style.ForeColor = important ? directionColor : Color.FromArgb(155, 180, 190);
            }
        }

        private void UpdateMetrics()
        {
            double previousIndex = indexHistory.Count > 1 ? indexHistory[indexHistory.Count - 2] : InitialIndex;
            double indexChange = (simulatedIndex / previousIndex - 1) * 100;
            int advancers = 0;
            int decliners = 0;
            double maxVolatility = 0;

            foreach (StockQuote stock in stocks)
            {
                if (stock.ChangePercent >= 0)
                    advancers++;
                else
                    decliners++;
                maxVolatility = Math.Max(maxVolatility, Math.Abs(stock.ChangePercent));
            }

            indexValueLabel.Text = $"{simulatedIndex:N2}";
            indexChangeLabel.Text = $"{(indexChange >= 0 ? "+" : "")}{indexChange:F2}%";
            indexChangeLabel.ForeColor = indexChange >= 0
                ? Color.FromArgb(75, 220, 155)
                : Color.FromArgb(255, 105, 118);
            breadthLabel.Text = $"{advancers} ↑  /  {decliners} ↓";
            volatilityLabel.Text = $"{maxVolatility:F2}%";
            lastUpdateLabel.Text = $"● LIVE SIMULATION · update {DateTime.Now:HH:mm:ss} · no external data";
        }

        private sealed class StockQuote
        {
            public StockQuote(string symbol, string company, double price, double volatility, double volumeMillions, double phase)
            {
                Symbol = symbol;
                Company = company;
                Price = price;
                PreviousClose = price;
                Volatility = volatility;
                BaseVolumeMillions = volumeMillions;
                VolumeMillions = volumeMillions;
                Phase = phase;
                Weight = 1.0 / 30.0;
                History = new List<double> { price };
            }

            public string Symbol { get; }
            public string Company { get; }
            public double Price { get; set; }
            public double PreviousClose { get; }
            public double ChangePercent { get; set; }
            public double Volatility { get; }
            public double BaseVolumeMillions { get; }
            public double VolumeMillions { get; set; }
            public double Phase { get; }
            public double Weight { get; }
            public List<double> History { get; }
        }
    }
}
