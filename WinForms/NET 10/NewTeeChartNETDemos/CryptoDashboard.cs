using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Steema.TeeChart;
using Steema.TeeChart.Styles;

namespace NewTeeChartNETDemos
{
    public partial class CryptoDashboard : Form
    {
        private class CryptoData
        {
            public string Code { get; set; }
            public string Name { get; set; }
            public double Price { get; set; }
            public double MarketCap { get; set; }
            public double Volume { get; set; }
            public double Change1h { get; set; }
            public double Change24h { get; set; }
            public double Change1w { get; set; }
            public List<CryptoPricePoint> HistoricalData { get; set; }
        }

        private class CryptoPricePoint
        {
            public DateTime Date { get; set; }
            public double Rate { get; set; }
            public double Volume { get; set; }
            public double Liquidity { get; set; }
            public double MarketCap { get; set; }
        }

        private List<CryptoData> cryptoList = new List<CryptoData>();
        private int selectedCryptoIndex = -1;

        public CryptoDashboard()
        {
            InitializeComponent();
        }

        private void CryptoDashboard_Load(object sender, EventArgs e)
        {
            Text = "TeeChart - Crypto Dashboard";
            Width = 1400;
            Height = 900;

            InitializeCryptoData();
            SetupDataGrid();
            ConfigureChart();
            SelectCrypto(0);
        }

        private void InitializeCryptoData()
        {
            // Initialize with sample crypto data
            cryptoList.Add(new CryptoData
            {
                Code = "BTC",
                Name = "Bitcoin",
                Price = 42350.00,
                MarketCap = 827000000000,
                Volume = 21000000000,
                Change1h = 0.45,
                Change24h = 2.35,
                Change1w = 5.67,
                HistoricalData = GenerateHistoricalData("BTC")
            });

            cryptoList.Add(new CryptoData
            {
                Code = "ETH",
                Name = "Ethereum",
                Price = 2245.50,
                MarketCap = 269000000000,
                Volume = 12500000000,
                Change1h = 0.32,
                Change24h = 1.85,
                Change1w = 4.12,
                HistoricalData = GenerateHistoricalData("ETH")
            });

            cryptoList.Add(new CryptoData
            {
                Code = "ADA",
                Name = "Cardano",
                Price = 0.98,
                MarketCap = 35000000000,
                Volume = 1200000000,
                Change1h = -0.15,
                Change24h = -1.25,
                Change1w = 2.45,
                HistoricalData = GenerateHistoricalData("ADA")
            });

            cryptoList.Add(new CryptoData
            {
                Code = "SOL",
                Name = "Solana",
                Price = 156.80,
                MarketCap = 63000000000,
                Volume = 3500000000,
                Change1h = 0.72,
                Change24h = 3.15,
                Change1w = 8.92,
                HistoricalData = GenerateHistoricalData("SOL")
            });

            cryptoList.Add(new CryptoData
            {
                Code = "XRP",
                Name = "Ripple",
                Price = 2.15,
                MarketCap = 115000000000,
                Volume = 5800000000,
                Change1h = 0.28,
                Change24h = 1.62,
                Change1w = 3.45,
                HistoricalData = GenerateHistoricalData("XRP")
            });
        }

        private List<CryptoPricePoint> GenerateHistoricalData(string code)
        {
            var data = new List<CryptoPricePoint>();
            Random rand = new Random(code.GetHashCode());
            double baseRate = code switch
            {
                "BTC" => 40000,
                "ETH" => 2000,
                "ADA" => 0.80,
                "SOL" => 140,
                "XRP" => 2.00,
                _ => 100
            };

            DateTime startDate = DateTime.UtcNow.AddDays(-30);
            for (int i = 0; i < 30 * 24; i++) // 30 days of hourly data
            {
                double variation = (rand.NextDouble() - 0.5) * baseRate * 0.02;
                double rate = baseRate + variation;
                double volume = rand.NextDouble() * baseRate * 1000000;
                double liquidity = rand.NextDouble() * baseRate * 500000;
                double cap = baseRate * rand.NextDouble() * 10000000000;

                data.Add(new CryptoPricePoint
                {
                    Date = startDate.AddHours(i),
                    Rate = rate,
                    Volume = volume,
                    Liquidity = liquidity,
                    MarketCap = cap
                });

                baseRate = rate;
            }

            return data;
        }

        private void SetupDataGrid()
        {
            dataGridViewCryptos.ColumnCount = 9;
            dataGridViewCryptos.Columns[0].Name = "Coin";
            dataGridViewCryptos.Columns[0].Width = 100;
            dataGridViewCryptos.Columns[1].Name = "Price";
            dataGridViewCryptos.Columns[1].Width = 120;
            dataGridViewCryptos.Columns[2].Name = "1h %";
            dataGridViewCryptos.Columns[2].Width = 80;
            dataGridViewCryptos.Columns[3].Name = "24h %";
            dataGridViewCryptos.Columns[3].Width = 80;
            dataGridViewCryptos.Columns[4].Name = "1w %";
            dataGridViewCryptos.Columns[4].Width = 80;
            dataGridViewCryptos.Columns[5].Name = "Market Cap";
            dataGridViewCryptos.Columns[5].Width = 140;
            dataGridViewCryptos.Columns[6].Name = "Volume";
            dataGridViewCryptos.Columns[6].Width = 140;
            dataGridViewCryptos.Columns[7].Name = "Price (USD)";
            dataGridViewCryptos.Columns[7].Width = 120;
            dataGridViewCryptos.Columns[8].Name = "Status";
            dataGridViewCryptos.Columns[8].Width = 60;

            dataGridViewCryptos.DefaultCellStyle.BackColor = Color.FromArgb(60, 60, 65);
            dataGridViewCryptos.DefaultCellStyle.ForeColor = Color.White;
            dataGridViewCryptos.DefaultCellStyle.SelectionBackColor = Color.FromArgb(100, 100, 110);
            dataGridViewCryptos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(37, 37, 38);
            dataGridViewCryptos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            foreach (var crypto in cryptoList)
            {
                int rowIndex = dataGridViewCryptos.Rows.Add();
                dataGridViewCryptos.Rows[rowIndex].Cells[0].Value = $"{crypto.Code} - {crypto.Name}";
                dataGridViewCryptos.Rows[rowIndex].Cells[1].Value = $"${crypto.Price:F2}";
                dataGridViewCryptos.Rows[rowIndex].Cells[2].Value = $"{(crypto.Change1h >= 0 ? "+" : "")}{crypto.Change1h:F2}%";
                dataGridViewCryptos.Rows[rowIndex].Cells[3].Value = $"{(crypto.Change24h >= 0 ? "+" : "")}{crypto.Change24h:F2}%";
                dataGridViewCryptos.Rows[rowIndex].Cells[4].Value = $"{(crypto.Change1w >= 0 ? "+" : "")}{crypto.Change1w:F2}%";
                dataGridViewCryptos.Rows[rowIndex].Cells[5].Value = $"${(crypto.MarketCap / 1e9):F2}B";
                dataGridViewCryptos.Rows[rowIndex].Cells[6].Value = $"${(crypto.Volume / 1e9):F2}B";
                dataGridViewCryptos.Rows[rowIndex].Cells[7].Value = $"${crypto.Price:F2}";
                dataGridViewCryptos.Rows[rowIndex].Cells[8].Value = crypto.Change24h >= 0 ? "↑" : "↓";

                // Color code based on 24h change
                Color cellColor = crypto.Change24h >= 0 ? Color.FromArgb(70, 100, 70) : Color.FromArgb(100, 70, 70);
                dataGridViewCryptos.Rows[rowIndex].DefaultCellStyle.BackColor = cellColor;
            }
        }

        private void ConfigureChart()
        {
            tChart1.Series.Clear();
            tChart1.Axes.Custom.Clear();

            tChart1.Header.Text = "Crypto Drill-Down Analysis";
            tChart1.Header.Font.Color = Color.White;
            tChart1.Header.Font.Size = 14;

            tChart1.Panel.Gradient.Visible = false;
            tChart1.Panel.Color = Color.FromArgb(24, 24, 24);

            tChart1.Aspect.View3D = false;

            // Configure X Axis
            Axis axisX = tChart1.Axes.Bottom;
            axisX.Title.Text = "Date/Time";
            axisX.Title.Font.Color = Color.White;
            axisX.Labels.Font.Color = Color.White;
            axisX.AxisPen.Color = Color.FromArgb(100, 100, 100);
            axisX.Grid.Color = Color.FromArgb(45, 45, 45);
            axisX.Labels.DateTimeFormat = "yyyy-MM-dd HH:mm";

            // Configure Left Axis - increase label size
            Axis axisLeft = tChart1.Axes.Left;
            axisLeft.Title.Font.Color = Color.White;
            axisLeft.Labels.Font.Color = Color.White;
            axisLeft.AxisPen.Color = Color.FromArgb(100, 100, 100);
            axisLeft.Grid.Color = Color.FromArgb(45, 45, 45);
            axisLeft.Labels.Font.Size = 11;
            axisLeft.IStartPos = 10;            

            tChart1.Legend.Visible = true;
            tChart1.Legend.Font.Color = Color.White;
            tChart1.Legend.Alignment = LegendAlignments.Right;            
        }

        private void SelectCrypto(int index)
        {
            if (index < 0 || index >= cryptoList.Count)
                return;

            selectedCryptoIndex = index;

            // Highlight selected row
            dataGridViewCryptos.ClearSelection();
            dataGridViewCryptos.Rows[index].Selected = true;
            dataGridViewCryptos.FirstDisplayedScrollingRowIndex = index;

            UpdateChart(cryptoList[index]);
        }

        private void UpdateChart(CryptoData crypto)
        {
            tChart1.Series.Clear();

            tChart1.Header.Text = $"{crypto.Name} ({crypto.Code}) - Drill-Down Analysis";

            // Create custom axes for different metrics
            Axis axisRate = new Axis(tChart1.Chart);
            axisRate.Title.Text = "Rate ($)";
            axisRate.Title.Font.Color = Color.White;
            axisRate.Labels.Font.Color = Color.White;
            axisRate.AxisPen.Color = Color.FromArgb(100, 200, 100);
            axisRate.AxisPen.Visible = true;
            axisRate.Grid.Color = Color.FromArgb(45, 45, 45);
            axisRate.Grid.Visible = true;
            axisRate.Labels.Visible = true;            
            axisRate.EndPosition = (100 * 1) / 4;

            Axis axisVolume = new Axis(tChart1.Chart);
            axisVolume.Title.Text = "Volume ($)";
            axisVolume.Title.Font.Color = Color.White;
            axisVolume.Labels.Font.Color = Color.White;
            axisVolume.AxisPen.Color = Color.FromArgb(100, 150, 255);
            axisVolume.AxisPen.Visible = true;
            axisVolume.Grid.Color = Color.FromArgb(45, 45, 45);
            axisVolume.Grid.Visible = true;
            axisVolume.Labels.Visible = true;
            axisVolume.StartPosition = 25;
            axisVolume.EndPosition = 50;

            Axis axisLiquidity = new Axis(tChart1.Chart);
            axisLiquidity.Title.Text = "Liquidity ($)";
            axisLiquidity.Title.Font.Color = Color.White;
            axisLiquidity.Labels.Font.Color = Color.White;
            axisLiquidity.AxisPen.Color = Color.FromArgb(255, 200, 100);
            axisLiquidity.AxisPen.Visible = true;
            axisLiquidity.Grid.Color = Color.FromArgb(45, 45, 45);
            axisLiquidity.Grid.Visible = true;
            axisLiquidity.Labels.Visible = true;
            axisLiquidity.StartPosition = 50;
            axisLiquidity.EndPosition = 75;

            Axis axisCap = new Axis(tChart1.Chart);
            axisCap.Title.Text = "Market Cap ($)";
            axisCap.Title.Font.Color = Color.White;
            axisCap.Labels.Font.Color = Color.White;
            axisCap.AxisPen.Color = Color.FromArgb(200, 100, 255);
            axisCap.AxisPen.Visible = true;
            axisCap.Grid.Color = Color.FromArgb(45, 45, 45);
            axisCap.Grid.Visible = true;
            axisCap.Labels.Visible = true;
            axisCap.StartPosition = 75;
            axisCap.EndPosition = 100;

            tChart1.Chart.Axes.Custom.Add(axisRate);
            tChart1.Chart.Axes.Custom.Add(axisVolume);
            tChart1.Chart.Axes.Custom.Add(axisLiquidity);
            tChart1.Chart.Axes.Custom.Add(axisCap);

            // Rate Series
            Line seriesRate = new Line(tChart1.Chart)
            {
                Title = $"{crypto.Name} Rate"
            };
            seriesRate.Color = Color.FromArgb(100, 200, 100);
            seriesRate.VertAxis = VerticalAxis.Custom;
            seriesRate.CustomVertAxis = axisRate;

            // Volume Area Series
            Area seriesVolume = new Area(tChart1.Chart)
            {
                Title = $"{crypto.Name} Volume"
            };
            seriesVolume.Color = Color.FromArgb(100, 150, 255);
            seriesVolume.VertAxis = VerticalAxis.Custom;
            seriesVolume.CustomVertAxis = axisVolume;

            // Liquidity Series
            Line seriesLiquidity = new Line(tChart1.Chart)
            {
                Title = $"{crypto.Name} Liquidity"
            };
            seriesLiquidity.Color = Color.FromArgb(255, 200, 100);
            seriesLiquidity.VertAxis = VerticalAxis.Custom;
            seriesLiquidity.CustomVertAxis = axisLiquidity;

            // Market Cap Series
            Line seriesCap = new Line(tChart1.Chart)
            {
                Title = $"{crypto.Name} Market Cap"
            };
            seriesCap.Color = Color.FromArgb(200, 100, 255);
            seriesCap.VertAxis = VerticalAxis.Custom;
            seriesCap.CustomVertAxis = axisCap;

            // Add data to series
            foreach (var point in crypto.HistoricalData)
            {
                seriesRate.Add(point.Date.ToOADate(), point.Rate);
                seriesVolume.Add(point.Date.ToOADate(), point.Volume);
                seriesLiquidity.Add(point.Date.ToOADate(), point.Liquidity);
                seriesCap.Add(point.Date.ToOADate(), point.MarketCap);
            }
        }

        private void DataGridViewCryptos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < cryptoList.Count)
            {
                SelectCrypto(e.RowIndex);
            }
        }

        private void DataGridViewCryptos_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < cryptoList.Count)
            {
                dataGridViewCryptos.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(120, 120, 130);
            }
        }

        private void DataGridViewCryptos_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < cryptoList.Count)
            {
                var crypto = cryptoList[e.RowIndex];
                Color cellColor = crypto.Change24h >= 0 ? Color.FromArgb(70, 100, 70) : Color.FromArgb(100, 70, 70);
                dataGridViewCryptos.Rows[e.RowIndex].DefaultCellStyle.BackColor = cellColor;
            }
        }
    }
}
