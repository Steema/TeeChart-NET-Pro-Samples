
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing

Imports System.Windows.Forms



Public Class Tool_SeriesStat
    Inherits Samples.BaseForm

    Private checkBox1 As System.Windows.Forms.CheckBox
    Private checkBox2 As System.Windows.Forms.CheckBox
    Private checkBox3 As System.Windows.Forms.CheckBox
    Private checkBox4 As System.Windows.Forms.CheckBox
    Private checkBox5 As System.Windows.Forms.CheckBox
    Private checkBox6 As System.Windows.Forms.CheckBox
    Private button1 As System.Windows.Forms.Button
    Private line1 As Steema.TeeChart.Styles.Line
    Private line2 As Steema.TeeChart.Styles.Line
    Private average1 As Steema.TeeChart.Functions.Average
    Private seriesStats1 As Steema.TeeChart.Tools.SeriesStats
    Private line3 As Steema.TeeChart.Styles.Line
    Private trendFunction1 As Steema.TeeChart.Functions.TrendFunction
    Private line4 As Steema.TeeChart.Styles.Line
    Private low1 As Steema.TeeChart.Functions.Low
    Private line5 As Steema.TeeChart.Styles.Line
    Private high1 As Steema.TeeChart.Functions.High
    Private line6 As Steema.TeeChart.Styles.Line
    Private line7 As Steema.TeeChart.Styles.Line
    Private correlationFunction1 As Steema.TeeChart.Functions.CorrelationFunction
    Private medianFunction1 As Steema.TeeChart.Functions.MedianFunction
    '/ <summary>
    '/ Required designer variable.
    '/ </summary>
    Private components As System.ComponentModel.IContainer = Nothing


    Public Sub New() ' This call is required by the Windows Form Designer.
        InitializeComponent()
        line1.FillSampleValues(30)
    End Sub


    '/ <summary>
    '/ Clean up any resources being used.
    '/ </summary>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub 'Dispose

#Region "Windows Form Designer generated code"

    '/ <summary>
    '/ Required method for Designer support - do not modify
    '/ the contents of this method with the code editor.
    '/ </summary>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Tool_SeriesStat))
        Me.checkBox1 = New System.Windows.Forms.CheckBox
        Me.checkBox2 = New System.Windows.Forms.CheckBox
        Me.checkBox3 = New System.Windows.Forms.CheckBox
        Me.checkBox4 = New System.Windows.Forms.CheckBox
        Me.checkBox5 = New System.Windows.Forms.CheckBox
        Me.checkBox6 = New System.Windows.Forms.CheckBox
        Me.line1 = New Steema.TeeChart.Styles.Line
        Me.line2 = New Steema.TeeChart.Styles.Line
        Me.average1 = New Steema.TeeChart.Functions.Average
        Me.button1 = New System.Windows.Forms.Button
        Me.seriesStats1 = New Steema.TeeChart.Tools.SeriesStats
        Me.trendFunction1 = New Steema.TeeChart.Functions.TrendFunction
        Me.line3 = New Steema.TeeChart.Styles.Line
        Me.low1 = New Steema.TeeChart.Functions.Low
        Me.line4 = New Steema.TeeChart.Styles.Line
        Me.high1 = New Steema.TeeChart.Functions.High
        Me.line5 = New Steema.TeeChart.Styles.Line
        Me.line6 = New Steema.TeeChart.Styles.Line
        Me.medianFunction1 = New Steema.TeeChart.Functions.MedianFunction
        Me.correlationFunction1 = New Steema.TeeChart.Functions.CorrelationFunction
        Me.line7 = New Steema.TeeChart.Styles.Line
        Me.panel1.SuspendLayout()
        Me.chartContainer.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.button1)
        Me.panel1.Controls.Add(Me.checkBox6)
        Me.panel1.Controls.Add(Me.checkBox5)
        Me.panel1.Controls.Add(Me.checkBox4)
        Me.panel1.Controls.Add(Me.checkBox3)
        Me.panel1.Controls.Add(Me.checkBox2)
        Me.panel1.Controls.Add(Me.checkBox1)
        Me.panel1.Size = New System.Drawing.Size(440, 71)
        ' 
        ' tChart1
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Aspect.ColorPaletteIndex = 0
        Me.tChart1.Aspect.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
        Me.tChart1.Aspect.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias
        Me.tChart1.Aspect.View3D = False
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Bottom.Labels.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Bottom.Title.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Depth.Labels.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Depth.Title.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.DepthTop.Labels.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.DepthTop.Title.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Left.Labels.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Left.Title.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Right.Labels.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Right.Title.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Top.Labels.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Top.Title.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Footer.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Header.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Legend.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Legend.Title.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.tChart1.Panel.Brush.Gradient.ExtendedColorPalette = Nothing
        Me.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tChart1.Panel.Brush.Gradient.Sigma = True
        Me.tChart1.Panel.Brush.Gradient.SigmaFocus = 1.0!
        Me.tChart1.Panel.Brush.Gradient.SigmaScale = 0.8!
        Me.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tChart1.Panel.Brush.Gradient.UseMiddle = True
        Me.tChart1.Panel.Brush.Gradient.Visible = True
        Me.tChart1.Series.Add(Me.line1)
        Me.tChart1.Series.Add(Me.line2)
        Me.tChart1.Series.Add(Me.line3)
        Me.tChart1.Series.Add(Me.line4)
        Me.tChart1.Series.Add(Me.line5)
        Me.tChart1.Series.Add(Me.line6)
        Me.tChart1.Series.Add(Me.line7)
        Me.tChart1.Size = New System.Drawing.Size(440, 173)
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.SubFooter.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.SubHeader.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        Me.tChart1.Tools.Add(Me.seriesStats1)
        ' 
        ' chartContainer
        ' 
        Me.chartContainer.Location = New System.Drawing.Point(0, 144)
        Me.chartContainer.Size = New System.Drawing.Size(440, 173)
        ' 
        ' checkBox1
        ' 
#If VS2005 Then
        Me.checkBox1.AutoSize = True
#End If
        Me.checkBox1.Checked = True
        Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox1.Location = New System.Drawing.Point(12, 19)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(63, 17)
        Me.checkBox1.TabIndex = 0
        Me.checkBox1.Text = "Average"
#If VS2005 Then
        Me.checkBox1.UseVisualStyleBackColor = True
#End If
        AddHandler checkBox1.CheckedChanged, AddressOf Me.checkBox1_CheckedChanged
        ' 
        ' checkBox2
        ' 
#If VS2005 Then
        Me.checkBox2.AutoSize = True
#End If
        Me.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox2.Location = New System.Drawing.Point(12, 42)
        Me.checkBox2.Name = "checkBox2"
        Me.checkBox2.Size = New System.Drawing.Size(51, 17)
        Me.checkBox2.TabIndex = 1
        Me.checkBox2.Text = "Trend"
#If VS2005 Then
        Me.checkBox2.UseVisualStyleBackColor = True
#End If
        AddHandler checkBox2.CheckedChanged, AddressOf Me.checkBox2_CheckedChanged
        ' 
        ' checkBox3
        ' 
#If VS2005 Then
        Me.checkBox3.AutoSize = True
#End If
        Me.checkBox3.Checked = True
        Me.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox3.Location = New System.Drawing.Point(81, 19)
        Me.checkBox3.Name = "checkBox3"
        Me.checkBox3.Size = New System.Drawing.Size(43, 17)
        Me.checkBox3.TabIndex = 2
        Me.checkBox3.Text = "Low"
#If VS2005 Then
        Me.checkBox3.UseVisualStyleBackColor = True
#End If
        AddHandler checkBox3.CheckedChanged, AddressOf Me.checkBox3_CheckedChanged
        ' 
        ' checkBox4
        ' 
#If VS2005 Then
        Me.checkBox4.AutoSize = True
#End If
        Me.checkBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox4.Location = New System.Drawing.Point(81, 42)
        Me.checkBox4.Name = "checkBox4"
        Me.checkBox4.Size = New System.Drawing.Size(45, 17)
        Me.checkBox4.TabIndex = 3
        Me.checkBox4.Text = "High"
#If VS2005 Then
        Me.checkBox4.UseVisualStyleBackColor = True
#End If
        AddHandler checkBox4.CheckedChanged, AddressOf Me.checkBox4_CheckedChanged
        ' 
        ' checkBox5
        ' 
#If VS2005 Then
        Me.checkBox5.AutoSize = True
#End If
        Me.checkBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox5.Location = New System.Drawing.Point(130, 19)
        Me.checkBox5.Name = "checkBox5"
        Me.checkBox5.Size = New System.Drawing.Size(58, 17)
        Me.checkBox5.TabIndex = 4
        Me.checkBox5.Text = "Median"
#If VS2005 Then

        Me.checkBox5.UseVisualStyleBackColor = True
#End If
        AddHandler checkBox5.CheckedChanged, AddressOf Me.checkBox5_CheckedChanged
        ' 
        ' checkBox6
        '
#If VS2005 Then
        Me.checkBox6.AutoSize = True
#End If
        Me.checkBox6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox6.Location = New System.Drawing.Point(130, 42)
        Me.checkBox6.Name = "checkBox6"
        Me.checkBox6.Size = New System.Drawing.Size(73, 17)
        Me.checkBox6.TabIndex = 5
        Me.checkBox6.Text = "Correlation"
#If VS2005 Then
        Me.checkBox6.UseVisualStyleBackColor = True
#End If
        AddHandler checkBox6.CheckedChanged, AddressOf Me.checkBox6_CheckedChanged
        ' 
        ' line1
        ' 
        ' 
        ' 
        ' 
        Me.line1.Brush.Color = System.Drawing.Color.Red
        Me.line1.ColorEach = False
        ' 
        ' 
        ' 
        Me.line1.Gradient.ExtendedColorPalette = Nothing
        Me.line1.Gradient.StartColor = System.Drawing.Color.Red
        ' 
        ' 
        ' 
        Me.line1.LinePen.Color = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.line1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None
        Me.line1.Marks.Callout.ArrowHeadSize = 8
        ' 
        ' 
        ' 
        Me.line1.Marks.Callout.Brush.Color = System.Drawing.Color.Black
        Me.line1.Marks.Callout.Distance = 0
        Me.line1.Marks.Callout.Draw3D = False
        Me.line1.Marks.Callout.Length = 10
        Me.line1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        ' 
        ' 
        ' 
        Me.line1.Marks.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        ' 
        ' 
        ' 
        Me.line1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.line1.Title = "Source"
        ' 
        ' 
        ' 
        Me.line1.XValues.DataMember = "X"
        Me.line1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' 
        ' 
        Me.line1.YValues.DataMember = "Y"
        ' 
        ' line2
        ' 
        ' 
        ' 
        ' 
        Me.line2.Brush.Color = System.Drawing.Color.Green
        Me.line2.ColorEach = False
        Me.line2.DataSource = Me.line1
        Me.line2.Function = Me.average1
        ' 
        ' 
        ' 
        Me.line2.Gradient.ExtendedColorPalette = Nothing
        Me.line2.Gradient.StartColor = System.Drawing.Color.Green
        ' 
        ' 
        ' 
        Me.line2.LinePen.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer))
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.line2.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None
        Me.line2.Marks.Callout.ArrowHeadSize = 8
        ' 
        ' 
        ' 
        Me.line2.Marks.Callout.Brush.Color = System.Drawing.Color.Black
        Me.line2.Marks.Callout.Distance = 0
        Me.line2.Marks.Callout.Draw3D = False
        Me.line2.Marks.Callout.Length = 10
        Me.line2.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        ' 
        ' 
        ' 
        Me.line2.Marks.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        ' 
        ' 
        ' 
        Me.line2.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.line2.Title = "Average"
        ' 
        ' 
        ' 
        Me.line2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' button1
        ' 
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.Location = New System.Drawing.Point(267, 19)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(75, 23)
        Me.button1.TabIndex = 6
        Me.button1.Text = "Edit tool"
#If VS2005 Then
        Me.button1.UseVisualStyleBackColor = True
#End If
        AddHandler button1.Click, AddressOf Me.button1_Click
        ' 
        ' seriesStats1
        ' 
        Me.seriesStats1.Series = Me.line1
        ' 
        ' line3
        ' 
        ' 
        ' 
        ' 
        Me.line3.Brush.Color = System.Drawing.Color.Yellow
        Me.line3.ColorEach = False
        Me.line3.DataSource = Me.line1
        Me.line3.Function = Me.trendFunction1
        ' 
        ' 
        ' 
        Me.line3.Gradient.ExtendedColorPalette = Nothing
        Me.line3.Gradient.StartColor = System.Drawing.Color.Yellow
        ' 
        ' 
        ' 
        Me.line3.LinePen.Color = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(0, Byte), Integer))
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.line3.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None
        Me.line3.Marks.Callout.ArrowHeadSize = 8
        ' 
        ' 
        ' 
        Me.line3.Marks.Callout.Brush.Color = System.Drawing.Color.Black
        Me.line3.Marks.Callout.Distance = 0
        Me.line3.Marks.Callout.Draw3D = False
        Me.line3.Marks.Callout.Length = 10
        Me.line3.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        ' 
        ' 
        ' 
        Me.line3.Marks.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        ' 
        ' 
        ' 
        Me.line3.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.line3.Title = "Trend"
        Me.line3.Visible = False
        ' 
        ' 
        ' 
        Me.line3.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' line4
        ' 
        ' 
        ' 
        ' 
        Me.line4.Brush.Color = System.Drawing.Color.Blue
        Me.line4.ColorEach = False
        Me.line4.DataSource = Me.line1
        Me.line4.Function = Me.low1
        ' 
        ' 
        ' 
        Me.line4.Gradient.ExtendedColorPalette = Nothing
        Me.line4.Gradient.StartColor = System.Drawing.Color.Blue
        ' 
        ' 
        ' 
        Me.line4.LinePen.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer))
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.line4.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None
        Me.line4.Marks.Callout.ArrowHeadSize = 8
        ' 
        ' 
        ' 
        Me.line4.Marks.Callout.Brush.Color = System.Drawing.Color.Black
        Me.line4.Marks.Callout.Distance = 0
        Me.line4.Marks.Callout.Draw3D = False
        Me.line4.Marks.Callout.Length = 10
        Me.line4.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        ' 
        ' 
        ' 
        Me.line4.Marks.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        ' 
        ' 
        ' 
        Me.line4.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.line4.Title = "Low"
        ' 
        ' 
        ' 
        Me.line4.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' line5
        ' 
        ' 
        ' 
        ' 
        Me.line5.Brush.Color = System.Drawing.Color.White
        Me.line5.ColorEach = False
        Me.line5.DataSource = Me.line1
        Me.line5.Function = Me.high1
        ' 
        ' 
        ' 
        Me.line5.Gradient.ExtendedColorPalette = Nothing
        Me.line5.Gradient.StartColor = System.Drawing.Color.White
        ' 
        ' 
        ' 
        Me.line5.LinePen.Color = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.line5.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None
        Me.line5.Marks.Callout.ArrowHeadSize = 8
        ' 
        ' 
        ' 
        Me.line5.Marks.Callout.Brush.Color = System.Drawing.Color.Black
        Me.line5.Marks.Callout.Distance = 0
        Me.line5.Marks.Callout.Draw3D = False
        Me.line5.Marks.Callout.Length = 10
        Me.line5.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        ' 
        ' 
        ' 
        Me.line5.Marks.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        ' 
        ' 
        ' 
        Me.line5.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.line5.Title = "High"
        Me.line5.Visible = False
        ' 
        ' 
        ' 
        Me.line5.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' line6
        ' 
        ' 
        ' 
        ' 
        Me.line6.Brush.Color = System.Drawing.Color.Gray
        Me.line6.ColorEach = False
        Me.line6.DataSource = Me.line1
        Me.line6.Function = Me.medianFunction1
        ' 
        ' 
        ' 
        Me.line6.Gradient.ExtendedColorPalette = Nothing
        Me.line6.Gradient.StartColor = System.Drawing.Color.Gray
        ' 
        ' 
        ' 
        Me.line6.LinePen.Color = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer))
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.line6.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None
        Me.line6.Marks.Callout.ArrowHeadSize = 8
        ' 
        ' 
        ' 
        Me.line6.Marks.Callout.Brush.Color = System.Drawing.Color.Black
        Me.line6.Marks.Callout.Distance = 0
        Me.line6.Marks.Callout.Draw3D = False
        Me.line6.Marks.Callout.Length = 10
        Me.line6.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        ' 
        ' 
        ' 
        Me.line6.Marks.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        ' 
        ' 
        ' 
        Me.line6.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.line6.Title = "Median"
        Me.line6.Visible = False
        ' 
        ' 
        ' 
        Me.line6.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' line7
        ' 
        ' 
        ' 
        ' 
        Me.line7.Brush.Color = System.Drawing.Color.Fuchsia
        Me.line7.ColorEach = False
        Me.line7.DataSource = Me.line1
        Me.line7.Function = Me.correlationFunction1
        ' 
        ' 
        ' 
        Me.line7.Gradient.ExtendedColorPalette = Nothing
        Me.line7.Gradient.StartColor = System.Drawing.Color.Fuchsia
        ' 
        ' 
        ' 
        Me.line7.LinePen.Color = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer))
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.line7.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None
        Me.line7.Marks.Callout.ArrowHeadSize = 8
        ' 
        ' 
        ' 
        Me.line7.Marks.Callout.Brush.Color = System.Drawing.Color.Black
        Me.line7.Marks.Callout.Distance = 0
        Me.line7.Marks.Callout.Draw3D = False
        Me.line7.Marks.Callout.Length = 10
        Me.line7.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        ' 
        ' 
        ' 
        Me.line7.Marks.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        ' 
        ' 
        ' 
        Me.line7.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.line7.Title = "Correlation"
        Me.line7.Visible = False
        ' 
        ' 
        ' 
        Me.line7.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' Tool_SeriesStat
        ' 
        Me.ClientSize = New System.Drawing.Size(440, 317)
        Me.Name = "Tool_SeriesStat"
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.chartContainer.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

#End Region

    Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs)
        Editors.Tools.ToolsEditor.ShowEditor(seriesStats1)
        ' Update checkboxes
        checkBox1.Checked = line2.Active
        checkBox2.Checked = line3.Active
        checkBox3.Checked = line4.Active
        checkBox4.Checked = line5.Active
        checkBox5.Checked = line6.Active
        checkBox6.Checked = line7.Active
    End Sub

    Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
        line2.Active = checkBox1.Checked
    End Sub

    Private Sub checkBox3_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
        line4.Active = checkBox3.Checked
    End Sub

    Private Sub checkBox2_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
        line3.Active = checkBox2.Checked
    End Sub

    Private Sub checkBox4_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
        line5.Active = checkBox4.Checked
    End Sub

    Private Sub checkBox5_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
        line6.Active = checkBox5.Checked
    End Sub

    Private Sub checkBox6_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
        line7.Active = checkBox6.Checked
    End Sub

End Class

