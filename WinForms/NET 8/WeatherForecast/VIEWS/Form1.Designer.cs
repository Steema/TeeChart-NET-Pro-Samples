
namespace MeteoApp
{
    partial class Form1
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
            Steema.TeeChart.Margins margins1 = new Steema.TeeChart.Margins();
            Steema.TeeChart.Margins margins2 = new Steema.TeeChart.Margins();
            headerPanel = new Panel();
            languageMenuStrip = new MenuStrip();
            languageToolStripMenuItem = new ToolStripMenuItem();
            englishToolStripMenuItem = new ToolStripMenuItem();
            catalanToolStripMenuItem = new ToolStripMenuItem();
            spanishToolStripMenuItem = new ToolStripMenuItem();
            searchPanel = new Panel();
            btnSearch = new Button();
            txtSearch = new TextBox();
            lblSearch = new Label();
            titleLabel = new Label();
            mainPanel = new Panel();
            cmbDays = new ComboBox();
            rightPanel = new Panel();
            richTextBox1 = new RichTextBox();
            btnVisitWebsite = new Button();
            txtBlockInformation = new RichTextBox();
            txtInformation = new Label();
            centerPanel = new Panel();
            suggestionsListBox = new ListBox();
            buttonsPanel = new Panel();
            btnHours = new Button();
            btnDays = new Button();
            locationPanel = new Panel();
            txtRegion = new Label();
            txtCity = new Label();
            weatherPanel = new Panel();
            txtTemperature = new Label();
            imgWeatherIcon = new PictureBox();
            leftPanel = new Panel();
            lstCities = new ListBox();
            txtRecentCities = new Label();
            chartsPanel = new Panel();
            scrollBarChart = new HScrollBar();
            tabControlCharts = new TabControl();
            tabTemperature = new TabPage();
            panelTempChart = new Panel();
            tChart1 = new Steema.TeeChart.TChart();
            tabTemperatureAndHumidity = new TabPage();
            panelTempHumidityChart = new Panel();
            tChart2 = new Steema.TeeChart.TChart();
            headerPanel.SuspendLayout();
            languageMenuStrip.SuspendLayout();
            searchPanel.SuspendLayout();
            mainPanel.SuspendLayout();
            rightPanel.SuspendLayout();
            centerPanel.SuspendLayout();
            buttonsPanel.SuspendLayout();
            locationPanel.SuspendLayout();
            weatherPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgWeatherIcon).BeginInit();
            leftPanel.SuspendLayout();
            chartsPanel.SuspendLayout();
            tabControlCharts.SuspendLayout();
            tabTemperature.SuspendLayout();
            panelTempChart.SuspendLayout();
            tabTemperatureAndHumidity.SuspendLayout();
            panelTempHumidityChart.SuspendLayout();
            SuspendLayout();
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.FromArgb(44, 62, 80);
            headerPanel.Controls.Add(languageMenuStrip);
            headerPanel.Controls.Add(searchPanel);
            headerPanel.Controls.Add(titleLabel);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(1517, 68);
            headerPanel.TabIndex = 0;
            // 
            // languageMenuStrip
            // 
            languageMenuStrip.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            languageMenuStrip.BackColor = Color.Transparent;
            languageMenuStrip.Dock = DockStyle.None;
            languageMenuStrip.Items.AddRange(new ToolStripItem[] { languageToolStripMenuItem });
            languageMenuStrip.Location = new Point(1453, 17);
            languageMenuStrip.Name = "languageMenuStrip";
            languageMenuStrip.Size = new Size(46, 25);
            languageMenuStrip.TabIndex = 2;
            languageMenuStrip.Text = "menuStrip1";
            // 
            // languageToolStripMenuItem
            // 
            languageToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { englishToolStripMenuItem, catalanToolStripMenuItem, spanishToolStripMenuItem });
            languageToolStripMenuItem.ForeColor = Color.White;
            languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            languageToolStripMenuItem.Size = new Size(38, 21);
            languageToolStripMenuItem.Text = "🌐";
            // 
            // englishToolStripMenuItem
            // 
            englishToolStripMenuItem.Checked = true;
            englishToolStripMenuItem.CheckState = CheckState.Checked;
            englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            englishToolStripMenuItem.Size = new Size(122, 22);
            englishToolStripMenuItem.Tag = "en";
            englishToolStripMenuItem.Text = "English";
            englishToolStripMenuItem.Click += englishToolStripMenuItem1_Click;
            // 
            // catalanToolStripMenuItem
            // 
            catalanToolStripMenuItem.Name = "catalanToolStripMenuItem";
            catalanToolStripMenuItem.Size = new Size(122, 22);
            catalanToolStripMenuItem.Tag = "ca";
            catalanToolStripMenuItem.Text = "Català";
            catalanToolStripMenuItem.Click += catalanToolStripMenuItem1_Click;
            // 
            // spanishToolStripMenuItem
            // 
            spanishToolStripMenuItem.Name = "spanishToolStripMenuItem";
            spanishToolStripMenuItem.Size = new Size(122, 22);
            spanishToolStripMenuItem.Tag = "es";
            spanishToolStripMenuItem.Text = "Español";
            spanishToolStripMenuItem.Click += spanishToolStripMenuItem1_Click;
            // 
            // searchPanel
            // 
            searchPanel.Anchor = AnchorStyles.Top;
            searchPanel.Controls.Add(btnSearch);
            searchPanel.Controls.Add(txtSearch);
            searchPanel.Controls.Add(lblSearch);
            searchPanel.Location = new Point(570, 14);
            searchPanel.Name = "searchPanel";
            searchPanel.Size = new Size(500, 41);
            searchPanel.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(458, 0);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(40, 41);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "🔍";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Microsoft Sans Serif", 14F);
            txtSearch.Location = new Point(173, 0);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(280, 29);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            txtSearch.KeyDown += txtSearch_KeyDown;
            txtSearch.Leave += txtSearch_LostFocus;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            lblSearch.ForeColor = Color.White;
            lblSearch.Location = new Point(0, 9);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(147, 20);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "The weather in... ";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold);
            titleLabel.ForeColor = Color.White;
            titleLabel.Location = new Point(20, 17);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(287, 31);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "☁️ Weather Forecast";
            // 
            // mainPanel
            // 
            mainPanel.Controls.Add(cmbDays);
            mainPanel.Controls.Add(rightPanel);
            mainPanel.Controls.Add(centerPanel);
            mainPanel.Controls.Add(leftPanel);
            mainPanel.Dock = DockStyle.Top;
            mainPanel.Location = new Point(0, 68);
            mainPanel.Name = "mainPanel";
            mainPanel.Padding = new Padding(20, 23, 20, 23);
            mainPanel.Size = new Size(1517, 317);
            mainPanel.TabIndex = 1;
            // 
            // cmbDays
            // 
            cmbDays.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            cmbDays.BackColor = Color.FromArgb(52, 152, 219);
            cmbDays.Font = new Font("Microsoft Sans Serif", 14F);
            cmbDays.ForeColor = Color.White;
            cmbDays.FormattingEnabled = true;
            cmbDays.Location = new Point(269, 264);
            cmbDays.Name = "cmbDays";
            cmbDays.Size = new Size(200, 32);
            cmbDays.TabIndex = 3;
            cmbDays.SelectionChangeCommitted += cmbDays_SelectionChanged;
            // 
            // rightPanel
            // 
            rightPanel.BackColor = Color.White;
            rightPanel.Controls.Add(richTextBox1);
            rightPanel.Controls.Add(btnVisitWebsite);
            rightPanel.Controls.Add(txtBlockInformation);
            rightPanel.Controls.Add(txtInformation);
            rightPanel.Dock = DockStyle.Right;
            rightPanel.Location = new Point(1005, 23);
            rightPanel.Name = "rightPanel";
            rightPanel.Size = new Size(492, 271);
            rightPanel.TabIndex = 2;
            // 
            // richTextBox1
            // 
            richTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            richTextBox1.BackColor = Color.White;
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Font = new Font("Microsoft Sans Serif", 14F);
            richTextBox1.ForeColor = Color.FromArgb(93, 109, 126);
            richTextBox1.Location = new Point(15, 136);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(462, 84);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "This demo mode uses a free 3 day forecast. Add a test account via weatherapi.com (button below) for 14 day free preview of a 10 day forecast.";
            // 
            // btnVisitWebsite
            // 
            btnVisitWebsite.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnVisitWebsite.BackColor = Color.FromArgb(52, 152, 219);
            btnVisitWebsite.ForeColor = Color.White;
            btnVisitWebsite.Location = new Point(50, 226);
            btnVisitWebsite.Name = "btnVisitWebsite";
            btnVisitWebsite.Size = new Size(392, 34);
            btnVisitWebsite.TabIndex = 2;
            btnVisitWebsite.Text = "🌐 Weather API Web";
            btnVisitWebsite.UseVisualStyleBackColor = false;
            btnVisitWebsite.Click += BtnVisitWebsite_Click;
            // 
            // txtBlockInformation
            // 
            txtBlockInformation.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtBlockInformation.BackColor = Color.White;
            txtBlockInformation.BorderStyle = BorderStyle.None;
            txtBlockInformation.Font = new Font("Microsoft Sans Serif", 14F);
            txtBlockInformation.ForeColor = Color.FromArgb(93, 109, 126);
            txtBlockInformation.Location = new Point(15, 46);
            txtBlockInformation.Name = "txtBlockInformation";
            txtBlockInformation.ReadOnly = true;
            txtBlockInformation.Size = new Size(462, 84);
            txtBlockInformation.TabIndex = 1;
            txtBlockInformation.Text = "Type the name of a city to get its weather forecast. You can change the language from the top menu. See recent cities in the side list.";
            // 
            // txtInformation
            // 
            txtInformation.AutoSize = true;
            txtInformation.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold);
            txtInformation.Location = new Point(15, 17);
            txtInformation.Name = "txtInformation";
            txtInformation.Size = new Size(165, 26);
            txtInformation.TabIndex = 0;
            txtInformation.Text = "ℹ️ Information";
            // 
            // centerPanel
            // 
            centerPanel.BackColor = Color.White;
            centerPanel.Controls.Add(suggestionsListBox);
            centerPanel.Controls.Add(buttonsPanel);
            centerPanel.Controls.Add(locationPanel);
            centerPanel.Controls.Add(weatherPanel);
            centerPanel.Dock = DockStyle.Fill;
            centerPanel.Location = new Point(250, 23);
            centerPanel.Name = "centerPanel";
            centerPanel.Size = new Size(1247, 271);
            centerPanel.TabIndex = 1;
            // 
            // suggestionsListBox
            // 
            suggestionsListBox.FormattingEnabled = true;
            suggestionsListBox.ItemHeight = 17;
            suggestionsListBox.Location = new Point(2, 12);
            suggestionsListBox.Name = "suggestionsListBox";
            suggestionsListBox.Size = new Size(1247, 259);
            suggestionsListBox.TabIndex = 3;
            suggestionsListBox.Visible = false;
            suggestionsListBox.MouseClick += suggestionsList_MouseClick;
            suggestionsListBox.SelectedIndexChanged += suggestionsListBox_SelectedIndexChanged;
            // 
            // buttonsPanel
            // 
            buttonsPanel.Controls.Add(btnHours);
            buttonsPanel.Controls.Add(btnDays);
            buttonsPanel.Location = new Point(240, 147);
            buttonsPanel.Name = "buttonsPanel";
            buttonsPanel.Size = new Size(315, 45);
            buttonsPanel.TabIndex = 2;
            // 
            // btnHours
            // 
            btnHours.BackColor = Color.FromArgb(52, 152, 219);
            btnHours.ForeColor = Color.White;
            btnHours.Location = new Point(165, 0);
            btnHours.Name = "btnHours";
            btnHours.Size = new Size(150, 45);
            btnHours.TabIndex = 1;
            btnHours.Text = "Forecast by hours";
            btnHours.UseVisualStyleBackColor = false;
            btnHours.Click += btnHours_Click;
            // 
            // btnDays
            // 
            btnDays.BackColor = Color.FromArgb(52, 152, 219);
            btnDays.ForeColor = Color.White;
            btnDays.Location = new Point(0, 0);
            btnDays.Name = "btnDays";
            btnDays.Size = new Size(150, 45);
            btnDays.TabIndex = 0;
            btnDays.Text = "Forecast by days";
            btnDays.UseVisualStyleBackColor = false;
            btnDays.Click += btnDays_Click;
            // 
            // locationPanel
            // 
            locationPanel.Controls.Add(txtRegion);
            locationPanel.Controls.Add(txtCity);
            locationPanel.Location = new Point(240, 34);
            locationPanel.Name = "locationPanel";
            locationPanel.Size = new Size(400, 102);
            locationPanel.TabIndex = 1;
            // 
            // txtRegion
            // 
            txtRegion.AutoSize = true;
            txtRegion.Font = new Font("Microsoft Sans Serif", 18F);
            txtRegion.ForeColor = Color.FromArgb(149, 165, 166);
            txtRegion.Location = new Point(0, 57);
            txtRegion.Name = "txtRegion";
            txtRegion.Size = new Size(201, 29);
            txtRegion.TabIndex = 1;
            txtRegion.Text = "Province, Country";
            // 
            // txtCity
            // 
            txtCity.AutoSize = true;
            txtCity.Font = new Font("Microsoft Sans Serif", 32F, FontStyle.Bold);
            txtCity.ForeColor = Color.FromArgb(44, 62, 80);
            txtCity.Location = new Point(12, 0);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(101, 51);
            txtCity.TabIndex = 0;
            txtCity.Text = "City";
            // 
            // weatherPanel
            // 
            weatherPanel.BackColor = Color.FromArgb(240, 249, 255);
            weatherPanel.Controls.Add(txtTemperature);
            weatherPanel.Controls.Add(imgWeatherIcon);
            weatherPanel.Location = new Point(30, 34);
            weatherPanel.Name = "weatherPanel";
            weatherPanel.Size = new Size(180, 204);
            weatherPanel.TabIndex = 0;
            // 
            // txtTemperature
            // 
            txtTemperature.Dock = DockStyle.Bottom;
            txtTemperature.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Bold);
            txtTemperature.ForeColor = Color.FromArgb(44, 62, 80);
            txtTemperature.Location = new Point(0, 142);
            txtTemperature.Name = "txtTemperature";
            txtTemperature.Size = new Size(180, 62);
            txtTemperature.TabIndex = 1;
            txtTemperature.Text = "--ºC";
            txtTemperature.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // imgWeatherIcon
            // 
            imgWeatherIcon.Dock = DockStyle.Top;
            imgWeatherIcon.Location = new Point(0, 0);
            imgWeatherIcon.Name = "imgWeatherIcon";
            imgWeatherIcon.Size = new Size(180, 136);
            imgWeatherIcon.SizeMode = PictureBoxSizeMode.CenterImage;
            imgWeatherIcon.TabIndex = 0;
            imgWeatherIcon.TabStop = false;
            // 
            // leftPanel
            // 
            leftPanel.BackColor = Color.White;
            leftPanel.Controls.Add(lstCities);
            leftPanel.Controls.Add(txtRecentCities);
            leftPanel.Dock = DockStyle.Left;
            leftPanel.Location = new Point(20, 23);
            leftPanel.Name = "leftPanel";
            leftPanel.Size = new Size(230, 271);
            leftPanel.TabIndex = 0;
            // 
            // lstCities
            // 
            lstCities.Dock = DockStyle.Fill;
            lstCities.FormattingEnabled = true;
            lstCities.ItemHeight = 17;
            lstCities.Items.AddRange(new object[] { "Girona", "Barcelona", "Birmingham", "Paris" });
            lstCities.Location = new Point(0, 60);
            lstCities.Name = "lstCities";
            lstCities.Size = new Size(230, 211);
            lstCities.TabIndex = 1;
            lstCities.SelectedIndexChanged += lstCities_SelectionChanged;
            // 
            // txtRecentCities
            // 
            txtRecentCities.AutoSize = true;
            txtRecentCities.Dock = DockStyle.Top;
            txtRecentCities.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold);
            txtRecentCities.Location = new Point(0, 0);
            txtRecentCities.Name = "txtRecentCities";
            txtRecentCities.Padding = new Padding(15, 17, 15, 17);
            txtRecentCities.Size = new Size(206, 60);
            txtRecentCities.TabIndex = 0;
            txtRecentCities.Text = "📍Recent cities";
            // 
            // chartsPanel
            // 
            chartsPanel.BackColor = Color.White;
            chartsPanel.Controls.Add(scrollBarChart);
            chartsPanel.Controls.Add(tabControlCharts);
            chartsPanel.Dock = DockStyle.Fill;
            chartsPanel.Location = new Point(0, 385);
            chartsPanel.Name = "chartsPanel";
            chartsPanel.Padding = new Padding(20, 23, 20, 23);
            chartsPanel.Size = new Size(1517, 565);
            chartsPanel.TabIndex = 2;
            // 
            // scrollBarChart
            // 
            scrollBarChart.Dock = DockStyle.Bottom;
            scrollBarChart.Location = new Point(20, 520);
            scrollBarChart.Maximum = 109;
            scrollBarChart.Name = "scrollBarChart";
            scrollBarChart.Size = new Size(1477, 22);
            scrollBarChart.TabIndex = 1;
            scrollBarChart.Scroll += scrollBarChart_Scroll;
            // 
            // tabControlCharts
            // 
            tabControlCharts.Controls.Add(tabTemperature);
            tabControlCharts.Controls.Add(tabTemperatureAndHumidity);
            tabControlCharts.Dock = DockStyle.Fill;
            tabControlCharts.Location = new Point(20, 23);
            tabControlCharts.Name = "tabControlCharts";
            tabControlCharts.SelectedIndex = 0;
            tabControlCharts.Size = new Size(1477, 519);
            tabControlCharts.TabIndex = 0;
            // 
            // tabTemperature
            // 
            tabTemperature.Controls.Add(panelTempChart);
            tabTemperature.Location = new Point(4, 26);
            tabTemperature.Name = "tabTemperature";
            tabTemperature.Padding = new Padding(3);
            tabTemperature.Size = new Size(1469, 489);
            tabTemperature.TabIndex = 0;
            tabTemperature.Text = "Temperature";
            tabTemperature.UseVisualStyleBackColor = true;
            // 
            // panelTempChart
            // 
            panelTempChart.Controls.Add(tChart1);
            panelTempChart.Dock = DockStyle.Fill;
            panelTempChart.Location = new Point(3, 3);
            panelTempChart.Name = "panelTempChart";
            panelTempChart.Size = new Size(1463, 483);
            panelTempChart.TabIndex = 0;
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
            tChart1.Axes.Bottom.Labels.Font.Brush.Color = Color.FromArgb(128, 128, 128);
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
            tChart1.Axes.Bottom.Labels.Font.Size = 9;
            tChart1.Axes.Bottom.Labels.Font.SizeFloat = 9F;
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
            tChart1.Axes.Bottom.Title.Distance = 0;
            // 
            // 
            // 
            tChart1.Axes.Bottom.Title.Font.Bold = false;
            // 
            // 
            // 
            tChart1.Axes.Bottom.Title.Font.Brush.Color = Color.FromArgb(64, 64, 64);
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
            tChart1.Axes.Bottom.Title.Font.Size = 11;
            tChart1.Axes.Bottom.Title.Font.SizeFloat = 11F;
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
            tChart1.Axes.Depth.Labels.Font.Brush.Color = Color.FromArgb(128, 128, 128);
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
            tChart1.Axes.Depth.Labels.Font.Size = 9;
            tChart1.Axes.Depth.Labels.Font.SizeFloat = 9F;
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
            tChart1.Axes.Depth.Title.Distance = 0;
            // 
            // 
            // 
            tChart1.Axes.Depth.Title.Font.Bold = false;
            // 
            // 
            // 
            tChart1.Axes.Depth.Title.Font.Brush.Color = Color.FromArgb(64, 64, 64);
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
            tChart1.Axes.Depth.Title.Font.Size = 11;
            tChart1.Axes.Depth.Title.Font.SizeFloat = 11F;
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
            tChart1.Axes.DepthTop.Labels.Font.Brush.Color = Color.FromArgb(128, 128, 128);
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
            tChart1.Axes.DepthTop.Labels.Font.Size = 9;
            tChart1.Axes.DepthTop.Labels.Font.SizeFloat = 9F;
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
            tChart1.Axes.DepthTop.Title.Distance = 0;
            // 
            // 
            // 
            tChart1.Axes.DepthTop.Title.Font.Bold = false;
            // 
            // 
            // 
            tChart1.Axes.DepthTop.Title.Font.Brush.Color = Color.FromArgb(64, 64, 64);
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
            tChart1.Axes.DepthTop.Title.Font.Size = 11;
            tChart1.Axes.DepthTop.Title.Font.SizeFloat = 11F;
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
            tChart1.Axes.Left.Labels.Font.Brush.Color = Color.FromArgb(128, 128, 128);
            tChart1.Axes.Left.Labels.Font.Brush.Solid = true;
            tChart1.Axes.Left.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Axes.Left.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
            tChart1.Axes.Left.Labels.Font.Shadow.Brush.Solid = true;
            tChart1.Axes.Left.Labels.Font.Shadow.Brush.Visible = true;
            tChart1.Axes.Left.Labels.Font.Size = 9;
            tChart1.Axes.Left.Labels.Font.SizeFloat = 9F;
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
            // 
            // 
            // 
            tChart1.Axes.Left.Title.Brush.Color = Color.Silver;
            tChart1.Axes.Left.Title.Brush.Solid = true;
            tChart1.Axes.Left.Title.Brush.Visible = true;
            tChart1.Axes.Left.Title.Distance = 0;
            // 
            // 
            // 
            tChart1.Axes.Left.Title.Font.Bold = false;
            // 
            // 
            // 
            tChart1.Axes.Left.Title.Font.Brush.Color = Color.FromArgb(64, 64, 64);
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
            tChart1.Axes.Left.Title.Font.Size = 11;
            tChart1.Axes.Left.Title.Font.SizeFloat = 11F;
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
            tChart1.Axes.Right.Labels.Font.Brush.Color = Color.FromArgb(128, 128, 128);
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
            tChart1.Axes.Right.Labels.Font.Size = 9;
            tChart1.Axes.Right.Labels.Font.SizeFloat = 9F;
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
            tChart1.Axes.Right.Title.Distance = 0;
            // 
            // 
            // 
            tChart1.Axes.Right.Title.Font.Bold = false;
            // 
            // 
            // 
            tChart1.Axes.Right.Title.Font.Brush.Color = Color.FromArgb(64, 64, 64);
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
            tChart1.Axes.Right.Title.Font.Size = 11;
            tChart1.Axes.Right.Title.Font.SizeFloat = 11F;
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
            tChart1.Axes.Top.Labels.Font.Brush.Color = Color.FromArgb(128, 128, 128);
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
            tChart1.Axes.Top.Labels.Font.Size = 9;
            tChart1.Axes.Top.Labels.Font.SizeFloat = 9F;
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
            tChart1.Axes.Top.Title.Distance = 0;
            // 
            // 
            // 
            tChart1.Axes.Top.Title.Font.Bold = false;
            // 
            // 
            // 
            tChart1.Axes.Top.Title.Font.Brush.Color = Color.FromArgb(64, 64, 64);
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
            tChart1.Axes.Top.Title.Font.Size = 11;
            tChart1.Axes.Top.Title.Font.SizeFloat = 11F;
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
            tChart1.Dock = DockStyle.Fill;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Footer.Brush.Color = Color.Silver;
            tChart1.Footer.Brush.Solid = true;
            tChart1.Footer.Brush.Visible = true;
            // 
            // 
            // 
            tChart1.Footer.Font.Bold = false;
            // 
            // 
            // 
            tChart1.Footer.Font.Brush.Color = Color.Red;
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
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Footer.Shadow.Brush.Color = Color.DarkGray;
            tChart1.Footer.Shadow.Brush.Solid = true;
            tChart1.Footer.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Header.Brush.Color = Color.FromArgb(192, 192, 192);
            tChart1.Header.Brush.Solid = true;
            tChart1.Header.Brush.Visible = true;
            // 
            // 
            // 
            tChart1.Header.Font.Bold = false;
            // 
            // 
            // 
            tChart1.Header.Font.Brush.Color = Color.FromArgb(128, 128, 128);
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
            tChart1.Header.Font.Size = 12;
            tChart1.Header.Font.SizeFloat = 12F;
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
            tChart1.Header.Shadow.Brush.Color = Color.FromArgb(169, 169, 169);
            tChart1.Header.Shadow.Brush.Solid = true;
            tChart1.Header.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Legend.Brush.Color = Color.White;
            tChart1.Legend.Brush.Solid = true;
            tChart1.Legend.Brush.Visible = true;
            tChart1.Legend.CheckBoxes = false;
            // 
            // 
            // 
            tChart1.Legend.Font.Bold = false;
            // 
            // 
            // 
            tChart1.Legend.Font.Brush.Color = Color.FromArgb(64, 64, 64);
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
            tChart1.Legend.Font.Size = 9;
            tChart1.Legend.Font.SizeFloat = 9F;
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
            tChart1.Legend.Shadow.Brush.Color = Color.FromArgb(0, 0, 0);
            tChart1.Legend.Shadow.Brush.Solid = true;
            tChart1.Legend.Shadow.Brush.Visible = true;
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
            tChart1.Location = new Point(0, 0);
            tChart1.Name = "tChart1";
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Panel.Brush.Color = Color.FromArgb(255, 255, 255);
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
            margins1.Bottom = 100;
            margins1.Left = 100;
            margins1.Right = 100;
            margins1.Top = 100;
            tChart1.Printer.Margins = margins1;
            tChart1.Size = new Size(1463, 483);
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.SubFooter.Brush.Color = Color.Silver;
            tChart1.SubFooter.Brush.Solid = true;
            tChart1.SubFooter.Brush.Visible = true;
            // 
            // 
            // 
            tChart1.SubFooter.Font.Bold = false;
            // 
            // 
            // 
            tChart1.SubFooter.Font.Brush.Color = Color.Red;
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
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.SubFooter.Shadow.Brush.Color = Color.DarkGray;
            tChart1.SubFooter.Shadow.Brush.Solid = true;
            tChart1.SubFooter.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.SubHeader.Brush.Color = Color.FromArgb(192, 192, 192);
            tChart1.SubHeader.Brush.Solid = true;
            tChart1.SubHeader.Brush.Visible = true;
            // 
            // 
            // 
            tChart1.SubHeader.Font.Bold = false;
            // 
            // 
            // 
            tChart1.SubHeader.Font.Brush.Color = Color.FromArgb(128, 128, 128);
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
            tChart1.SubHeader.Shadow.Brush.Color = Color.FromArgb(169, 169, 169);
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
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Walls.Left.Brush.Color = Color.LightYellow;
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
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Walls.Right.Brush.Color = Color.LightYellow;
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
            tChart1.Zoom.Brush.Color = Color.FromArgb(150, 173, 216, 230);
            tChart1.Zoom.Brush.Solid = true;
            tChart1.Zoom.Brush.Visible = true;
            tChart1.AfterDraw += tChart1_AfterDraw_1;
            tChart1.BeforeDrawSeries += tChart1_BeforeDrawSeries;
            // 
            // tabTemperatureAndHumidity
            // 
            tabTemperatureAndHumidity.Controls.Add(panelTempHumidityChart);
            tabTemperatureAndHumidity.Location = new Point(4, 26);
            tabTemperatureAndHumidity.Name = "tabTemperatureAndHumidity";
            tabTemperatureAndHumidity.Padding = new Padding(3);
            tabTemperatureAndHumidity.Size = new Size(1469, 489);
            tabTemperatureAndHumidity.TabIndex = 1;
            tabTemperatureAndHumidity.Text = "Temperature/Humidity";
            tabTemperatureAndHumidity.UseVisualStyleBackColor = true;
            // 
            // panelTempHumidityChart
            // 
            panelTempHumidityChart.Controls.Add(tChart2);
            panelTempHumidityChart.Dock = DockStyle.Fill;
            panelTempHumidityChart.Location = new Point(3, 3);
            panelTempHumidityChart.Name = "panelTempHumidityChart";
            panelTempHumidityChart.Padding = new Padding(15, 17, 15, 17);
            panelTempHumidityChart.Size = new Size(1463, 483);
            panelTempHumidityChart.TabIndex = 0;
            // 
            // tChart2
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
            tChart2.Axes.Bottom.Labels.Font.Brush.Color = Color.FromArgb(128, 128, 128);
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
            tChart2.Axes.Bottom.Labels.Font.Size = 9;
            tChart2.Axes.Bottom.Labels.Font.SizeFloat = 9F;
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
            tChart2.Axes.Bottom.Title.Distance = 0;
            // 
            // 
            // 
            tChart2.Axes.Bottom.Title.Font.Bold = false;
            // 
            // 
            // 
            tChart2.Axes.Bottom.Title.Font.Brush.Color = Color.FromArgb(64, 64, 64);
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
            tChart2.Axes.Bottom.Title.Font.Size = 11;
            tChart2.Axes.Bottom.Title.Font.SizeFloat = 11F;
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
            tChart2.Axes.Depth.Labels.Font.Brush.Color = Color.FromArgb(128, 128, 128);
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
            tChart2.Axes.Depth.Labels.Font.Size = 9;
            tChart2.Axes.Depth.Labels.Font.SizeFloat = 9F;
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
            tChart2.Axes.Depth.Title.Distance = 0;
            // 
            // 
            // 
            tChart2.Axes.Depth.Title.Font.Bold = false;
            // 
            // 
            // 
            tChart2.Axes.Depth.Title.Font.Brush.Color = Color.FromArgb(64, 64, 64);
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
            tChart2.Axes.Depth.Title.Font.Size = 11;
            tChart2.Axes.Depth.Title.Font.SizeFloat = 11F;
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
            tChart2.Axes.DepthTop.Labels.Font.Brush.Color = Color.FromArgb(128, 128, 128);
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
            tChart2.Axes.DepthTop.Labels.Font.Size = 9;
            tChart2.Axes.DepthTop.Labels.Font.SizeFloat = 9F;
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
            tChart2.Axes.DepthTop.Title.Distance = 0;
            // 
            // 
            // 
            tChart2.Axes.DepthTop.Title.Font.Bold = false;
            // 
            // 
            // 
            tChart2.Axes.DepthTop.Title.Font.Brush.Color = Color.FromArgb(64, 64, 64);
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
            tChart2.Axes.DepthTop.Title.Font.Size = 11;
            tChart2.Axes.DepthTop.Title.Font.SizeFloat = 11F;
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
            tChart2.Axes.Left.Labels.Font.Brush.Color = Color.FromArgb(128, 128, 128);
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
            tChart2.Axes.Left.Labels.Font.Size = 9;
            tChart2.Axes.Left.Labels.Font.SizeFloat = 9F;
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
            tChart2.Axes.Left.Title.Distance = 0;
            // 
            // 
            // 
            tChart2.Axes.Left.Title.Font.Bold = false;
            // 
            // 
            // 
            tChart2.Axes.Left.Title.Font.Brush.Color = Color.FromArgb(64, 64, 64);
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
            tChart2.Axes.Left.Title.Font.Size = 11;
            tChart2.Axes.Left.Title.Font.SizeFloat = 11F;
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
            tChart2.Axes.Right.Labels.Font.Brush.Color = Color.FromArgb(128, 128, 128);
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
            tChart2.Axes.Right.Labels.Font.Size = 9;
            tChart2.Axes.Right.Labels.Font.SizeFloat = 9F;
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
            tChart2.Axes.Right.Title.Distance = 0;
            // 
            // 
            // 
            tChart2.Axes.Right.Title.Font.Bold = false;
            // 
            // 
            // 
            tChart2.Axes.Right.Title.Font.Brush.Color = Color.FromArgb(64, 64, 64);
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
            tChart2.Axes.Right.Title.Font.Size = 11;
            tChart2.Axes.Right.Title.Font.SizeFloat = 11F;
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
            tChart2.Axes.Top.Labels.Font.Brush.Color = Color.FromArgb(128, 128, 128);
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
            tChart2.Axes.Top.Labels.Font.Size = 9;
            tChart2.Axes.Top.Labels.Font.SizeFloat = 9F;
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
            tChart2.Axes.Top.Title.Distance = 0;
            // 
            // 
            // 
            tChart2.Axes.Top.Title.Font.Bold = false;
            // 
            // 
            // 
            tChart2.Axes.Top.Title.Font.Brush.Color = Color.FromArgb(64, 64, 64);
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
            tChart2.Axes.Top.Title.Font.Size = 11;
            tChart2.Axes.Top.Title.Font.SizeFloat = 11F;
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
            tChart2.Dock = DockStyle.Fill;
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
            tChart2.Header.Brush.Color = Color.FromArgb(192, 192, 192);
            tChart2.Header.Brush.Solid = true;
            tChart2.Header.Brush.Visible = true;
            // 
            // 
            // 
            tChart2.Header.Font.Bold = false;
            // 
            // 
            // 
            tChart2.Header.Font.Brush.Color = Color.FromArgb(128, 128, 128);
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
            tChart2.Header.Font.Size = 12;
            tChart2.Header.Font.SizeFloat = 12F;
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
            tChart2.Header.Shadow.Brush.Color = Color.FromArgb(169, 169, 169);
            tChart2.Header.Shadow.Brush.Solid = true;
            tChart2.Header.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart2.Legend.Brush.Color = Color.White;
            tChart2.Legend.Brush.Solid = true;
            tChart2.Legend.Brush.Visible = true;
            tChart2.Legend.CheckBoxes = false;
            // 
            // 
            // 
            tChart2.Legend.Font.Bold = false;
            // 
            // 
            // 
            tChart2.Legend.Font.Brush.Color = Color.FromArgb(64, 64, 64);
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
            tChart2.Legend.Font.Size = 9;
            tChart2.Legend.Font.SizeFloat = 9F;
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
            tChart2.Legend.Shadow.Brush.Color = Color.FromArgb(0, 0, 0);
            tChart2.Legend.Shadow.Brush.Solid = true;
            tChart2.Legend.Shadow.Brush.Visible = true;
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
            tChart2.Location = new Point(15, 17);
            tChart2.Name = "tChart2";
            // 
            // 
            // 
            // 
            // 
            // 
            tChart2.Panel.Brush.Color = Color.FromArgb(255, 255, 255);
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
            margins2.Bottom = 100;
            margins2.Left = 100;
            margins2.Right = 100;
            margins2.Top = 100;
            tChart2.Printer.Margins = margins2;
            tChart2.Size = new Size(1433, 449);
            // 
            // 
            // 
            // 
            // 
            // 
            tChart2.SubFooter.Brush.Color = Color.Silver;
            tChart2.SubFooter.Brush.Solid = true;
            tChart2.SubFooter.Brush.Visible = true;
            // 
            // 
            // 
            tChart2.SubFooter.Font.Bold = false;
            // 
            // 
            // 
            tChart2.SubFooter.Font.Brush.Color = Color.Red;
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
            // 
            // 
            // 
            // 
            // 
            // 
            tChart2.SubFooter.Shadow.Brush.Color = Color.DarkGray;
            tChart2.SubFooter.Shadow.Brush.Solid = true;
            tChart2.SubFooter.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart2.SubHeader.Brush.Color = Color.FromArgb(192, 192, 192);
            tChart2.SubHeader.Brush.Solid = true;
            tChart2.SubHeader.Brush.Visible = true;
            // 
            // 
            // 
            tChart2.SubHeader.Font.Bold = false;
            // 
            // 
            // 
            tChart2.SubHeader.Font.Brush.Color = Color.FromArgb(128, 128, 128);
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
            tChart2.SubHeader.Shadow.Brush.Color = Color.FromArgb(169, 169, 169);
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
            // 
            // 
            // 
            // 
            // 
            // 
            tChart2.Walls.Left.Brush.Color = Color.LightYellow;
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
            // 
            // 
            // 
            // 
            // 
            // 
            tChart2.Walls.Right.Brush.Color = Color.LightYellow;
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
            tChart2.Zoom.Brush.Color = Color.FromArgb(150, 173, 216, 230);
            tChart2.Zoom.Brush.Solid = true;
            tChart2.Zoom.Brush.Visible = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(1517, 950);
            Controls.Add(chartsPanel);
            Controls.Add(mainPanel);
            Controls.Add(headerPanel);
            MainMenuStrip = languageMenuStrip;
            Name = "Form1";
            Text = "Weather Forecast";
            WindowState = FormWindowState.Maximized;
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            languageMenuStrip.ResumeLayout(false);
            languageMenuStrip.PerformLayout();
            searchPanel.ResumeLayout(false);
            searchPanel.PerformLayout();
            mainPanel.ResumeLayout(false);
            rightPanel.ResumeLayout(false);
            rightPanel.PerformLayout();
            centerPanel.ResumeLayout(false);
            buttonsPanel.ResumeLayout(false);
            locationPanel.ResumeLayout(false);
            locationPanel.PerformLayout();
            weatherPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)imgWeatherIcon).EndInit();
            leftPanel.ResumeLayout(false);
            leftPanel.PerformLayout();
            chartsPanel.ResumeLayout(false);
            tabControlCharts.ResumeLayout(false);
            tabTemperature.ResumeLayout(false);
            panelTempChart.ResumeLayout(false);
            tabTemperatureAndHumidity.ResumeLayout(false);
            panelTempHumidityChart.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Steema.TeeChart.TChart tChart1;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.MenuStrip languageMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catalanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spanishToolStripMenuItem;
        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.Button btnVisitWebsite;
        private System.Windows.Forms.Panel centerPanel;
        private System.Windows.Forms.ComboBox cmbDays;
        private System.Windows.Forms.Panel buttonsPanel;
        public  System.Windows.Forms.Button btnHours;
        public  System.Windows.Forms.Button btnDays;
        private System.Windows.Forms.Panel locationPanel;
        private System.Windows.Forms.Label txtRegion;
        private System.Windows.Forms.Label txtCity;
        private System.Windows.Forms.Panel weatherPanel;
        private System.Windows.Forms.Label txtTemperature;
        private System.Windows.Forms.PictureBox imgWeatherIcon;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.ListBox lstCities;
        private System.Windows.Forms.Panel chartsPanel;
        private System.Windows.Forms.TabControl tabControlCharts;
        private System.Windows.Forms.Panel panelTempChart;
        private System.Windows.Forms.Panel panelTempHumidityChart;
        private System.Windows.Forms.ListBox suggestionsListBox;
        private Steema.TeeChart.TChart tChart2;
        public HScrollBar scrollBarChart;
        public Label txtRecentCities;
        public Label txtInformation;
        public RichTextBox txtBlockInformation;
        public System.Windows.Forms.TabPage tabTemperatureAndHumidity;
        public System.Windows.Forms.TabPage tabTemperature;
        public RichTextBox richTextBox1;
    }
}
