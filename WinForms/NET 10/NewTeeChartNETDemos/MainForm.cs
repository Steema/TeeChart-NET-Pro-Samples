using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace NewTeeChartNETDemos
{
    public partial class MainForm : Form
    {
        private Dictionary<string, Type> demoMap = new Dictionary<string, Type>();
        private Form? currentDemo = null;
        private TabControl? demoTabs = null;

        private static readonly string[] DemoOrder =
        {
            "Dow Jones Live Ticker",
            "Aircraft Cockpit Command Panel",
            "World Flight Routes",
            "Crypto Dashboard",
            "Multi-channel Real-Time Monitoring",
            "Sweeping Heat Map",
            "Gauge Chart Dashboard",
            "Threshold Line Chart",
            "Cytometry Visualization",
            "Radar Chart",
            "Bubble Chart",
            "Treemap Chart",
            "Radial Bar Chart",
            "Circular Bar Chart",
            "Pie Chart"
        };

        private static readonly Dictionary<Type, DemoInfo> DemoInformation = new()
        {
            { typeof(SweepingHeatMap), new("Live thermal scanning over a sensor grid.", "ColorGrid + ColorLine", "Show a moving sweep and changing intensity.") },
            { typeof(MultiChannelRealTimeMonitoring), new("Real-time monitoring of several independent channels.", "Line", "Compare live signals as they change.") },
            { typeof(CryptoDashboard), new("Crypto market overview for price, volume, liquidity and cap.", "Line + Area", "Spot market changes quickly.") },
            { typeof(GaugeChartDashboard), new("Operational dashboard with a trend and a headline KPI.", "Line + CircularGauge", "Combine a live trend with a current reading.") },
            { typeof(CytometryVisualization), new("Flow-cytometry-style view of a cell population.", "Points", "Reveal clusters and outliers.") },
            { typeof(ThresholdLineChart), new("Live values monitored against good and bad limits.", "Line + ColorLine", "Highlight threshold crossings.") },
            { typeof(CircularBarChartDemo), new("Circular comparison of category magnitudes.", "Rose", "Show values around a radial layout.") },
            { typeof(RadialBarChartDemo), new("Radial comparison using circular bars.", "PolarBar", "Compare categories with a circular scale.") },
            { typeof(TreemapChartDemo), new("Hierarchical distribution of categories.", "TreeMap", "Show part-to-whole relationships by area.") },
            { typeof(PieChartDemo), new("Animated composition of category values.", "Pie", "Show percentage contribution.") },
            { typeof(RadarChartDemo), new("Multivariate profile comparison on fixed axes.", "Radar", "Compare several dimensions at once.") },
            { typeof(BubbleChartDemo), new("Animated view of magnitude and density.", "Bubble", "Encode a third value as bubble size.") },
            { typeof(WorldFlightRoutesDemo), new("Worldwide routes with moving aircraft.", "World + Line + Points", "Visualize origins, destinations and trajectories.") },
            { typeof(DowJonesTickerDemo), new("Simulated Dow Jones market ticker.", "Area + Line + Points + Bar", "Monitor index movement and market movers.") },
            { typeof(AircraftCockpitCommandPanelDemo), new("Aircraft cockpit command panel simulation.", "Area + Line + CircularGauge + Bar + Radar + Polar", "Combine flight instruments in one live cockpit.") }
        };

        public MainForm()
        {
            InitializeComponent();
            InitializeDemos();
        }

        private void InitializeDemos()
        {
            // Create mapping of demo names to their Form types
            demoMap = new Dictionary<string, Type>
            {
                { "Sweeping Heat Map", typeof(SweepingHeatMap) },
                { "Multi-channel Real-Time Monitoring", typeof(MultiChannelRealTimeMonitoring) },
                { "Crypto Dashboard", typeof(CryptoDashboard) },
                { "Gauge Chart Dashboard", typeof(GaugeChartDashboard) },
                { "Cytometry Visualization", typeof(CytometryVisualization) },
                { "Threshold Line Chart", typeof(ThresholdLineChart) },
                { "Circular Bar Chart", typeof(CircularBarChartDemo) },
                { "Radial Bar Chart", typeof(RadialBarChartDemo) },
                { "Treemap Chart", typeof(TreemapChartDemo) },
                { "Pie Chart", typeof(PieChartDemo) },
                { "Radar Chart", typeof(RadarChartDemo) },
                { "Bubble Chart", typeof(BubbleChartDemo) },
                { "World Flight Routes", typeof(WorldFlightRoutesDemo) },
                { "Dow Jones Live Ticker", typeof(DowJonesTickerDemo) },
                { "Aircraft Cockpit Command Panel", typeof(AircraftCockpitCommandPanelDemo) }
            };

            // Add demos in order of practical relevance: complete dashboards first,
            // followed by monitoring views and individual chart examples.
            foreach (string demoName in DemoOrder)
            {
                listBoxDemos.Items.Add(demoName);
            }

            // Select first demo by default
            if (listBoxDemos.Items.Count > 0)
            {
                listBoxDemos.SelectedIndex = 0;
            }
        }

        private void ListBoxDemos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxDemos.SelectedIndex == -1)
                return;

            object? selectedItem = listBoxDemos.SelectedItem;
            if (selectedItem != null)
            {
                string selectedDemoName = selectedItem.ToString() ?? string.Empty;
                LoadDemo(selectedDemoName);
            }
        }

        private void LoadDemo(string demoName)
        {
            if (string.IsNullOrEmpty(demoName))
                return;

            CloseCurrentDemo();

            // Get the demo type
            if (!demoMap.TryGetValue(demoName, out Type? demoType) || demoType == null)
                return;

            // Create instance of the demo form
            object? demoInstance = Activator.CreateInstance(demoType);
            if (demoInstance is not Form form)
                return;

            currentDemo = form;

            // Configure the form to work as an embedded control
            currentDemo.TopLevel = false;
            currentDemo.FormBorderStyle = FormBorderStyle.None;
            currentDemo.Dock = DockStyle.Fill;

            var visualizationTab = new TabPage("Visualization")
            {
                BackColor = Color.FromArgb(45, 45, 48),
                Padding = new Padding(0)
            };
            var visualizationSurface = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.FromArgb(45, 45, 48)
            };
            visualizationSurface.Controls.Add(currentDemo);
            Button infoButton = CreateInfoButton(visualizationSurface, demoType);
            visualizationSurface.Controls.Add(infoButton);
            visualizationTab.Controls.Add(visualizationSurface);

            var sourceTab = new TabPage("Source Code")
            {
                BackColor = Color.FromArgb(30, 30, 30),
                Padding = new Padding(8)
            };
            sourceTab.Controls.Add(CreateSourceCodeViewer(demoType));

            demoTabs = new TabControl
            {
                Dock = DockStyle.Fill,
                BackColor = Color.FromArgb(45, 45, 48),
                Padding = new Point(12, 4)
            };
            demoTabs.TabPages.Add(visualizationTab);
            demoTabs.TabPages.Add(sourceTab);

            panelDemo.Controls.Add(demoTabs);
            currentDemo.Show();
            infoButton.BringToFront();
        }

        private static Button CreateInfoButton(Panel visualizationSurface, Type demoType)
        {
            var infoButton = new InfoButton
            {
                Size = new Size(32, 28),
                Anchor = AnchorStyles.Top | AnchorStyles.Right,
                TabStop = false,
                AccessibleName = "Show example information"
            };
            infoButton.Click += (_, _) => ShowDemoInformation(demoType, visualizationSurface.FindForm());

            void PositionButton()
            {
                infoButton.Location = new Point(
                    Math.Max(4, visualizationSurface.ClientSize.Width - infoButton.Width - 8),
                    8);
            }

            visualizationSurface.Resize += (_, _) => PositionButton();
            PositionButton();
            return infoButton;
        }

        private static void ShowDemoInformation(Type demoType, IWin32Window? owner)
        {
            if (!DemoInformation.TryGetValue(demoType, out DemoInfo? info))
                info = new DemoInfo("Interactive TeeChart visualization.", "TeeChart series", "Explore the live chart.");

            using var infoForm = new Form
            {
                Text = "Chart Information",
                StartPosition = owner == null ? FormStartPosition.CenterScreen : FormStartPosition.CenterParent,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MaximizeBox = false,
                MinimizeBox = false,
                ShowInTaskbar = false,
                ClientSize = new Size(450, 245),
                BackColor = Color.FromArgb(24, 34, 42),
                ForeColor = Color.FromArgb(225, 238, 243)
            };

            var content = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 1,
                RowCount = 4,
                Padding = new Padding(22, 18, 22, 16),
                BackColor = Color.FromArgb(24, 34, 42)
            };
            content.RowStyles.Add(new RowStyle(SizeType.Absolute, 28));
            content.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
            content.RowStyles.Add(new RowStyle(SizeType.Absolute, 36));
            content.RowStyles.Add(new RowStyle(SizeType.Absolute, 8));

            var title = new Label
            {
                Dock = DockStyle.Fill,
                Text = "ABOUT THIS VISUALIZATION",
                ForeColor = Color.FromArgb(120, 215, 245),
                Font = new Font("Segoe UI", 11f, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleLeft
            };
            var description = new Label
            {
                Dock = DockStyle.Fill,
                AutoSize = false,
                Text = $"OBJECTIVE\r\n{info.Objective}\r\n\r\n{info.Description}\r\n\r\nSERIES\r\n{info.Series}",
                ForeColor = Color.FromArgb(220, 230, 235),
                Font = new Font("Segoe UI", 9.5f),
                TextAlign = ContentAlignment.MiddleLeft
            };
            var closeButton = new Button
            {
                Anchor = AnchorStyles.Right,
                AutoSize = true,
                Text = "Close",
                DialogResult = DialogResult.OK,
                BackColor = Color.FromArgb(42, 91, 108),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Padding = new Padding(12, 3, 12, 3)
            };
            closeButton.FlatAppearance.BorderColor = Color.FromArgb(90, 175, 205);
            infoForm.AcceptButton = closeButton;
            infoForm.CancelButton = closeButton;

            content.Controls.Add(title, 0, 0);
            content.Controls.Add(description, 0, 1);
            content.Controls.Add(closeButton, 0, 2);
            infoForm.Controls.Add(content);
            infoForm.ShowDialog(owner);
        }

        private sealed class InfoButton : Button
        {
            private bool isHovered;

            public InfoButton()
            {
                Cursor = Cursors.Hand;
                FlatStyle = FlatStyle.Flat;
                BackColor = Color.Transparent;
                TabStop = false;
                SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint |
                    ControlStyles.OptimizedDoubleBuffer, true);
                MouseEnter += (_, _) => { isHovered = true; Invalidate(); };
                MouseLeave += (_, _) => { isHovered = false; Invalidate(); };
            }

            protected override void OnPaint(PaintEventArgs e)
            {
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                Rectangle circle = new Rectangle(5, 3, Width - 10, Height - 6);
                Color fillColor = isHovered ? Color.FromArgb(76, 164, 190) : Color.FromArgb(40, 105, 128);
                using var fill = new SolidBrush(fillColor);
                using var outline = new Pen(Color.FromArgb(165, 235, 250), 1.2f);
                e.Graphics.FillEllipse(fill, circle);
                e.Graphics.DrawEllipse(outline, circle);

                using var font = new Font("Segoe UI", 12f, FontStyle.Bold);
                using var textBrush = new SolidBrush(Color.White);
                SizeF textSize = e.Graphics.MeasureString("i", font);
                e.Graphics.DrawString("i", font, textBrush,
                    (Width - textSize.Width) / 2f,
                    (Height - textSize.Height) / 2f - 1f);
            }
        }

        private sealed class DemoInfo
        {
            public DemoInfo(string description, string series, string objective)
            {
                Description = description;
                Series = series;
                Objective = objective;
            }

            public string Description { get; }
            public string Series { get; }
            public string Objective { get; }
        }

        private static RichTextBox CreateSourceCodeViewer(Type demoType)
        {
            string sourceFileName = demoType.Name + ".cs";
            string sourceCode = LoadSourceCode(sourceFileName)
                ?? $"// Source file not found: {sourceFileName}{Environment.NewLine}";

            return new RichTextBox
            {
                Dock = DockStyle.Fill,
                ReadOnly = true,
                DetectUrls = false,
                WordWrap = false,
                ScrollBars = RichTextBoxScrollBars.Both,
                BorderStyle = BorderStyle.None,
                BackColor = Color.FromArgb(30, 30, 30),
                ForeColor = Color.FromArgb(220, 225, 230),
                Font = new Font("Consolas", 9.5f),
                Text = sourceCode
            };
        }

        private static string? LoadSourceCode(string sourceFileName)
        {
            Assembly assembly = typeof(MainForm).Assembly;
            string resourceName = "SourceCode/" + sourceFileName;
            using (Stream? resource = assembly.GetManifestResourceStream(resourceName))
            {
                if (resource != null)
                {
                    using var reader = new StreamReader(resource);
                    return reader.ReadToEnd();
                }
            }

            DirectoryInfo? directory = new DirectoryInfo(AppContext.BaseDirectory);
            while (directory != null)
            {
                string candidate = Path.Combine(directory.FullName, sourceFileName);
                if (File.Exists(candidate))
                    return File.ReadAllText(candidate);

                directory = directory.Parent;
            }

            return null;
        }

        private void CloseCurrentDemo()
        {
            currentDemo?.Dispose();
            currentDemo = null;

            demoTabs?.Dispose();
            demoTabs = null;
            panelDemo.Controls.Clear();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseCurrentDemo();
        }
    }
}
