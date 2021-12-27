
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms


Public Class ChartThemes
    Inherits Steema.TeeChart.Samples.BaseNoChart
    Private label1 As System.Windows.Forms.Label
    Private tChart1 As Steema.TeeChart.TChart
    Private bar1 As Steema.TeeChart.Styles.Bar
    Private components As System.ComponentModel.IContainer = Nothing
    Private lbThemes As System.Windows.Forms.ListBox
    Private button1 As System.Windows.Forms.Button
    Private button2 As System.Windows.Forms.Button
    Private gridBand1 As Steema.TeeChart.Tools.GridBand
    Private themeEditor As Steema.TeeChart.Editors.ThemeEditor
    
    Public Sub New() ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' TODO: Add any initialization after the InitializeComponent call
    End Sub

    '/// <summary>
    '/// Clean up any resources being used.
    '/// </summary>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)

        If (disposing) Then
            If Not components Is Nothing Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub
#Region "Designer generated code"

    '/// <summary>
    '/// Required method for Designer support - do not modify
    '/// the contents of this method with the code editor.
    '/// </summary>
    Private Sub InitializeComponent()

        Me.label1 = New System.Windows.Forms.Label
        Me.lbThemes = New System.Windows.Forms.ListBox
        Me.tChart1 = New Steema.TeeChart.TChart
        Me.bar1 = New Steema.TeeChart.Styles.Bar
        Me.gridBand1 = New Steema.TeeChart.Tools.GridBand
        Me.button1 = New System.Windows.Forms.Button
        Me.button2 = New System.Windows.Forms.Button
        Me.panel1.SuspendLayout()
        Me.panel2.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Text = "TeeChart Themes enable rapid change of many chart properties with a single mouse " + "click. " + vbCr + vbLf + vbCr + vbLf + "Several themes are provided through the Themes Editor and programatic" + "ally. " + vbCr + vbLf + "Creating new themes by code is really simple."
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.button2)
        Me.panel1.Controls.Add(Me.button1)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Name = "panel1"
        ' 
        ' panel2
        ' 
        Me.panel2.Anchor = CType(System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right, System.Windows.Forms.AnchorStyles)
        Me.panel2.Controls.Add(Me.tChart1)
        Me.panel2.Controls.Add(Me.lbThemes)
        Me.panel2.Dock = System.Windows.Forms.DockStyle.None
        Me.panel2.Name = "panel2"
        ' 
        ' label1
        ' 
        Me.label1.Location = New System.Drawing.Point(0, 24)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(100, 16)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Select Theme:"
        ' 
        ' lbThemes
        ' 
        Me.lbThemes.Location = New System.Drawing.Point(0, 0)
        Me.lbThemes.Name = "lbThemes"
        Me.lbThemes.Size = New System.Drawing.Size(88, 160)
        Me.lbThemes.TabIndex = 0
        AddHandler Me.lbThemes.SelectedIndexChanged, AddressOf Me.lbThemes_SelectedIndexChanged
        ' 
        ' tChart1
        ' 
        Me.tChart1.Anchor = CType(System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right, System.Windows.Forms.AnchorStyles)
        ' 
        ' tChart1.Aspect
        ' 
        Me.tChart1.Aspect.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality
        Me.tChart1.Aspect.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        ' 
        ' tChart1.Header
        ' 
        Me.tChart1.Header.Lines = New String() {"TeeChart"}
        ' 
        ' tChart1.Legend
        ' 
        ' 
        ' tChart1.Legend.Brush
        ' 
        ' 
        ' tChart1.Legend.Gradient
        ' 
        Me.tChart1.Legend.Brush.Gradient.Visible = True
        ' 
        ' tChart1.Legend.Gradient
        ' 
        Me.tChart1.Legend.Gradient.Visible = True
        Me.tChart1.Location = New System.Drawing.Point(88, 0)
        Me.tChart1.Name = "tChart1"
        Me.tChart1.Series.Add(Me.bar1)
        Me.tChart1.Size = New System.Drawing.Size(344, 160)
        Me.tChart1.TabIndex = 1
        Me.tChart1.Tools.Add(Me.gridBand1)
        ' 
        ' bar1
        ' 
        ' 
        ' bar1.Brush
        ' 
        Me.bar1.Brush.Color = System.Drawing.Color.Red
        Me.bar1.ColorEach = True
        ' 
        ' bar1.Marks
        ' 
        ' 
        ' bar1.Marks.Symbol
        ' 
        ' 
        ' bar1.Marks.Symbol.Shadow
        ' 
        Me.bar1.Marks.Symbol.Shadow.Height = 1
        Me.bar1.Marks.Symbol.Shadow.Visible = True
        Me.bar1.Marks.Symbol.Shadow.Width = 1
        Me.bar1.Title = "bar1"
        ' 
        ' bar1.XValues
        ' 
        Me.bar1.XValues.DataMember = "X"
        Me.bar1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' bar1.YValues
        ' 
        Me.bar1.YValues.DataMember = "Bar"
        ' 
        ' gridBand1
        ' 
        Me.gridBand1.Axis = Me.tChart1.Axes.Left
        ' 
        ' gridBand1.Band1
        ' 
        Me.gridBand1.Band1.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(224, System.Byte), CType(224, System.Byte), CType(224, System.Byte))
        ' 
        ' gridBand1.Band2
        ' 
        Me.gridBand1.Band2.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        ' 
        ' button1
        ' 
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.Location = New System.Drawing.Point(120, 11)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(96, 23)
        Me.button1.TabIndex = 1
        Me.button1.Text = "Theme Editor..."
        AddHandler Me.button1.Click, AddressOf Me.button1_Click
        ' 
        ' button2
        ' 
        Me.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button2.Location = New System.Drawing.Point(256, 11)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(112, 23)
        Me.button2.TabIndex = 2
        Me.button2.Text = "Apply by code"
        AddHandler Me.button2.Click, AddressOf Me.button2_Click
        ' 
        ' ChartThemes
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(426, 258)
        Me.Name = "ChartThemes"
        Me.Text = "Chart Themes"
        AddHandler Me.Load, AddressOf Me.ChartThemes_Load
        Me.panel1.ResumeLayout(False)
        Me.panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub 'New 
#End Region


    Private Sub ChartThemes_Load(ByVal sender As Object, ByVal e As System.EventArgs)
        bar1.FillSampleValues()
        bar1.ColorEach = True

        ' Add all available themes to ListBox1.
        themeEditor = New Steema.TeeChart.Editors.ThemeEditor(tChart1.Chart, Nothing)

        Dim objectCollection(lbThemes.Items.Count) As Object
        lbThemes.Items.CopyTo(objectCollection, 0)
        themeEditor.AddChartThemes(objectCollection)
        lbThemes.Items.Clear()
        lbThemes.Items.Add(Texts.Current)
        lbThemes.Items.AddRange(objectCollection)
        lbThemes.SelectedIndex = 0
    End Sub 'ChartThemes_Load


    Private Sub lbThemes_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        If lbThemes.SelectedIndex <> 0 Then
            CType(lbThemes.SelectedItem, Themes.Theme).Apply()
        End If
    End Sub 'lbThemes_SelectedIndexChanged


    Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs)

        themeEditor.ShowDialog()
        lbThemes.SelectedIndex = 0
    End Sub 'button1_Click


    Private Sub button2_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim xpTheme As New Steema.TeeChart.Themes.XPTheme(tChart1.Chart)
        xpTheme.Apply()
    End Sub 'button2_Click 
End Class 'ChartThemes