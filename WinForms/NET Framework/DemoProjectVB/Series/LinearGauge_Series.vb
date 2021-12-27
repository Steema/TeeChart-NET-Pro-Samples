Imports System
#If VS2005 Then
imports System.Collections.Generic
#End If
imports System.ComponentModel
imports System.Data
imports System.Drawing
imports System.Text
imports System.Windows.Forms



Public Class LinearGauge_Series
    Inherits Samples.BaseForm
    Private WithEvents bEditSeries As Button
    Private WithEvents timer1 As Timer
    Private WithEvents cbAnimate As CheckBox
    Private linearGauge1 As Steema.TeeChart.Styles.LinearGauge
    Private linearGauge2 As Steema.TeeChart.Styles.LinearGauge

    '/ <summary>
    '/ Required designer variable.
    '/ </summary>
    Private components As System.ComponentModel.IContainer = Nothing


    Public Sub New() ' me call is required by the Windows Form Designer.
        InitializeComponent()
        InitializeChart()
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
    '/ the contents of me method with the code editor.
    '/ </summary>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LinearGauge_Series))
        Me.bEditSeries = New System.Windows.Forms.Button()
        Me.timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.cbAnimate = New System.Windows.Forms.CheckBox()
        Me.linearGauge1 = New Steema.TeeChart.Styles.LinearGauge()
        Me.linearGauge2 = New Steema.TeeChart.Styles.LinearGauge()
        Me.panel1.SuspendLayout()
        Me.chartContainer.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Text = "The Linear Gauge series provides a fast and fully configurable Linear Gauge."
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.cbAnimate)
        Me.panel1.Controls.Add(Me.bEditSeries)
        ' 
        ' tChart1
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Aspect.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
        Me.tChart1.Aspect.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Bottom.Increment = 10
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Bottom.Labels.Font.Bold = True
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Bottom.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.tChart1.Axes.Bottom.Labels.Font.Size = 12
        Me.tChart1.Axes.Bottom.Labels.Font.SizeFloat = 12.0F
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Bottom.MinorTicks.Color = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.tChart1.Axes.Bottom.MinorTicks.Length = 1
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Bottom.Ticks.Color = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.tChart1.Axes.Bottom.Ticks.Length = 20
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Bottom.Title.Caption = "Axis Title %"
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Bottom.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.tChart1.Axes.Bottom.Title.Lines = New String() { _
        "Axis Title %"}
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
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(216, Byte), Integer))
        ' 
        ' 
        ' 
        Me.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.tChart1.Panel.Brush.Gradient.ExtendedColorPalette = Nothing
        Me.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tChart1.Panel.Brush.Gradient.Sigma = True
        Me.tChart1.Panel.Brush.Gradient.SigmaFocus = 1.0F
        Me.tChart1.Panel.Brush.Gradient.SigmaScale = 0.8F
        Me.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tChart1.Panel.Brush.Gradient.UseMiddle = True
        Me.tChart1.Panel.Brush.Gradient.Visible = True
        Me.tChart1.Series.Add(Me.linearGauge1)
        Me.tChart1.Series.Add(Me.linearGauge2)
        Me.tChart1.Size = New System.Drawing.Size(440, 205)
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
        ' 
        ' bEditSeries
        ' 
        Me.bEditSeries.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bEditSeries.Location = New System.Drawing.Point(12, 10)
        Me.bEditSeries.Name = "bEditSeries"
        Me.bEditSeries.Size = New System.Drawing.Size(116, 23)
        Me.bEditSeries.TabIndex = 0
        Me.bEditSeries.Text = "Edit Top Series..."
#If VS2005 Then
        Me.bEditSeries.UseVisualStyleBackColor = True
#End If
        ' 
        ' timer1
        ' 
        Me.timer1.Enabled = True
        ' 
        ' cbAnimate
        ' 
        Me.cbAnimate.Checked = True
        Me.cbAnimate.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbAnimate.Location = New System.Drawing.Point(143, 14)
        Me.cbAnimate.Name = "cbAnimate"
        Me.cbAnimate.Size = New System.Drawing.Size(67, 17)
        Me.cbAnimate.TabIndex = 1
        Me.cbAnimate.Text = "Animate!"
#If VS2005 Then
        Me.cbAnimate.AutoSize = True
        Me.cbAnimate.UseVisualStyleBackColor = True
#End If
        ' 
        ' linearGauge1
        ' 
        Me.linearGauge1.ColorEach = False
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.linearGauge1.FaceBrush.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.linearGauge1.FaceBrush.Gradient.ExtendedColorPalette = Nothing
        Me.linearGauge1.FaceBrush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.linearGauge1.FaceBrush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        ' 
        ' 
        ' 
        Me.linearGauge1.FaceBrush.Gradient.Style.CenterXOffset = 80
        Me.linearGauge1.FaceBrush.Gradient.Style.CenterYOffset = -13
        Me.linearGauge1.FaceBrush.Gradient.Style.Direction = Steema.TeeChart.Drawing.PathGradientMode.Radial
        Me.linearGauge1.FaceBrush.Gradient.Style.Visible = True
        Me.linearGauge1.FaceBrush.Gradient.UseMiddle = True
        Me.linearGauge1.FaceBrush.Gradient.Visible = True
        ' 
        ' 
        ' 
        Me.linearGauge1.Frame.Circled = False
        Me.linearGauge1.GaugeColorPalette = New System.Drawing.Color() { _
             System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer)), _
             System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer)), _
             System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer)), _
             System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer)), _
             System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer)), _
             System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer)), _
             System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer)), _
             System.Drawing.Color.Empty, _
             System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer)), _
             System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer)), _
             System.Drawing.Color.Empty, _
             System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(30, Byte), Integer)), _
             System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(60, Byte), Integer)), _
             System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(60, Byte), Integer)), _
             System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(60, Byte), Integer)), _
             System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(10, Byte), Integer)), _
             System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer)), _
             System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer)), _
             System.Drawing.Color.Empty, _
             System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer)), _
             System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer)), _
             System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer)), _
             System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer)), _
             System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))}
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.linearGauge1.GreenLine.Brush.Color = System.Drawing.Color.Black
        ' 
        ' 
        ' 
        Me.linearGauge1.GreenLine.Brush.Gradient.Direction = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.linearGauge1.GreenLine.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.linearGauge1.GreenLine.Brush.Gradient.ExtendedColorPalette = Nothing
        Me.linearGauge1.GreenLine.Brush.Gradient.MiddleColor = System.Drawing.Color.Empty
        Me.linearGauge1.GreenLine.Brush.Gradient.Sigma = True
        Me.linearGauge1.GreenLine.Brush.Gradient.SigmaFocus = 0.0F
        Me.linearGauge1.GreenLine.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.linearGauge1.GreenLine.Brush.Gradient.Visible = True
        Me.linearGauge1.GreenLine.Style = CType(resources.GetObject("resource.Style"), Steema.TeeChart.Styles.GaugePointerStyles)
        Me.linearGauge1.GreenLine.VertSize = 5
        Me.linearGauge1.GreenLine.Visible = True
        Me.linearGauge1.GreenLineEndValue = 40
        Me.linearGauge1.GreenLineStartValue = 0
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.linearGauge1.Hand.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        ' 
        ' 
        ' 
        Me.linearGauge1.Hand.Pen.Color = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.linearGauge1.Hand.Pen.Visible = False
        Me.linearGauge1.Hand.Style = CType(resources.GetObject("resource.Style1"), Steema.TeeChart.Styles.GaugePointerStyles)
        Me.linearGauge1.Hand.Visible = True
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.linearGauge1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None
        Me.linearGauge1.Marks.Callout.ArrowHeadSize = 8
        ' 
        ' 
        ' 
        Me.linearGauge1.Marks.Callout.Brush.Color = System.Drawing.Color.Black
        Me.linearGauge1.Marks.Callout.Distance = 0
        Me.linearGauge1.Marks.Callout.Draw3D = False
        Me.linearGauge1.Marks.Callout.Length = 10
        Me.linearGauge1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        ' 
        ' 
        ' 
        Me.linearGauge1.Maximum = 100
        ' 
        ' 
    '
        Me.linearGauge1.MaxValueIndicator.VertSize = 5
        Me.linearGauge1.MaxValueIndicator.Visible = True
        Me.linearGauge1.Minimum = 0
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.linearGauge1.MinorTicks.Brush.Color = System.Drawing.Color.Transparent
        Me.linearGauge1.MinorTicks.Brush.Visible = False
        Me.linearGauge1.MinorTicks.HorizSize = 1
        ' 
        ' 
        ' 
        Me.linearGauge1.MinorTicks.Pen.Color = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.linearGauge1.MinorTicks.Style = CType(resources.GetObject("resource.Style3"), Steema.TeeChart.Styles.GaugePointerStyles)
        Me.linearGauge1.MinorTicks.VertSize = 1
        Me.linearGauge1.MinorTicks.Visible = True
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.linearGauge1.RedLine.Brush.Color = System.Drawing.Color.Black
        ' 
        ' 
        ' 
        Me.linearGauge1.RedLine.Brush.Gradient.Direction = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.linearGauge1.RedLine.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.linearGauge1.RedLine.Brush.Gradient.ExtendedColorPalette = Nothing
        Me.linearGauge1.RedLine.Brush.Gradient.MiddleColor = System.Drawing.Color.Empty
        Me.linearGauge1.RedLine.Brush.Gradient.Sigma = True
        Me.linearGauge1.RedLine.Brush.Gradient.SigmaFocus = 0.0F
        Me.linearGauge1.RedLine.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.linearGauge1.RedLine.Brush.Gradient.Visible = True
        Me.linearGauge1.RedLine.Style = CType(resources.GetObject("resource.Style4"), Steema.TeeChart.Styles.GaugePointerStyles)
        Me.linearGauge1.RedLine.VertSize = 5
        Me.linearGauge1.RedLine.Visible = True
        Me.linearGauge1.RedLineEndValue = 100
        Me.linearGauge1.RedLineStartValue = 80
        Me.linearGauge1.ShowInLegend = False
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.linearGauge1.Ticks.Brush.Color = System.Drawing.Color.Transparent
        Me.linearGauge1.Ticks.Brush.Visible = False
        ' 
        ' 
        ' 
        Me.linearGauge1.Ticks.Pen.Color = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.linearGauge1.Ticks.Style = CType(resources.GetObject("resource.Style5"), Steema.TeeChart.Styles.GaugePointerStyles)
        Me.linearGauge1.Ticks.VertSize = 20
        Me.linearGauge1.Ticks.Visible = True
        Me.linearGauge1.Title = "linearGauge1"
        Me.linearGauge1.UseValueColorPalette = False
        Me.linearGauge1.Value = 0
        Me.linearGauge1.ValueColorPalette = New System.Drawing.Color() { _
             System.Drawing.Color.Green, _
             System.Drawing.Color.Yellow, _
             System.Drawing.Color.Orange, _
             System.Drawing.Color.Red}
        ' 
        ' 
        ' 
        Me.linearGauge1.XValues.DataMember = "X"
        Me.linearGauge1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' 
        ' 
        Me.linearGauge1.YValues.DataMember = "Y"
        ' 
        ' linearGauge2
        ' 
        Me.linearGauge2.ColorEach = False
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.linearGauge2.FaceBrush.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.linearGauge2.FaceBrush.Gradient.ExtendedColorPalette = Nothing
        Me.linearGauge2.FaceBrush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.linearGauge2.FaceBrush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        ' 
        ' 
        ' 
        Me.linearGauge2.FaceBrush.Gradient.Style.CenterXOffset = 80
        Me.linearGauge2.FaceBrush.Gradient.Style.CenterYOffset = -13
        Me.linearGauge2.FaceBrush.Gradient.Style.Direction = Steema.TeeChart.Drawing.PathGradientMode.Radial
        Me.linearGauge2.FaceBrush.Gradient.Style.Visible = True
        Me.linearGauge2.FaceBrush.Gradient.UseMiddle = True
        Me.linearGauge2.FaceBrush.Gradient.Visible = True
        ' 
        ' 
        ' 
        Me.linearGauge2.Frame.Circled = False
        Me.linearGauge2.GaugeColorPalette = New System.Drawing.Color() { _
             System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer)), _
             System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer)), _
             System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer)), _
             System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer)), _
             System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer)), _
             System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer)), _
             System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer)), _
             System.Drawing.Color.Empty, _
             System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer)), _
             System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer)), _
             System.Drawing.Color.Empty, _
             System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(30, Byte), Integer)), _
             System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(60, Byte), Integer)), _
             System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(60, Byte), Integer)), _
             System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(60, Byte), Integer)), _
             System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(10, Byte), Integer)), _
             System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer)), _
             System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer)), _
             System.Drawing.Color.Empty, _
             System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer)), _
             System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer)), _
             System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer)), _
             System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer)), _
             System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))}
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.linearGauge2.GreenLine.Brush.Color = System.Drawing.Color.Black
        ' 
        ' 
        ' 
        Me.linearGauge2.GreenLine.Brush.Gradient.Direction = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.linearGauge2.GreenLine.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.linearGauge2.GreenLine.Brush.Gradient.ExtendedColorPalette = Nothing
        Me.linearGauge2.GreenLine.Brush.Gradient.MiddleColor = System.Drawing.Color.Empty
        Me.linearGauge2.GreenLine.Brush.Gradient.Sigma = True
        Me.linearGauge2.GreenLine.Brush.Gradient.SigmaFocus = 0.0F
        Me.linearGauge2.GreenLine.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.linearGauge2.GreenLine.Brush.Gradient.Visible = True
        Me.linearGauge2.GreenLine.Style = CType(resources.GetObject("resource.Style6"), Steema.TeeChart.Styles.GaugePointerStyles)
        Me.linearGauge2.GreenLine.VertSize = 5
        Me.linearGauge2.GreenLine.Visible = True
        Me.linearGauge2.GreenLineEndValue = 40
        Me.linearGauge2.GreenLineStartValue = 0
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.linearGauge2.Hand.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        ' 
        ' 
        ' 
        Me.linearGauge2.Hand.Pen.Color = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.linearGauge2.Hand.Pen.Visible = False
        Me.linearGauge2.Hand.Style = CType(resources.GetObject("resource.Style7"), Steema.TeeChart.Styles.GaugePointerStyles)
        Me.linearGauge2.Hand.Visible = True
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.linearGauge2.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None
        Me.linearGauge2.Marks.Callout.ArrowHeadSize = 8
        ' 
        ' 
        ' 
        Me.linearGauge2.Marks.Callout.Brush.Color = System.Drawing.Color.Black
        Me.linearGauge2.Marks.Callout.Distance = 0
        Me.linearGauge2.Marks.Callout.Draw3D = False
        Me.linearGauge2.Marks.Callout.Length = 10
        Me.linearGauge2.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        ' 
        ' 
        ' 
        Me.linearGauge2.Maximum = 100
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.linearGauge2.MaxValueIndicator.Brush.Color = System.Drawing.Color.Red
        Me.linearGauge2.MaxValueIndicator.VertSize = 5
        Me.linearGauge2.MaxValueIndicator.Visible = True
        Me.linearGauge2.Minimum = 0
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.linearGauge2.MinorTicks.Brush.Color = System.Drawing.Color.Transparent
        Me.linearGauge2.MinorTicks.Brush.Visible = False
        Me.linearGauge2.MinorTicks.HorizSize = 1
        ' 
        ' 
        ' 
        Me.linearGauge2.MinorTicks.Pen.Color = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.linearGauge2.MinorTicks.Style = CType(resources.GetObject("resource.Style9"), Steema.TeeChart.Styles.GaugePointerStyles)
        Me.linearGauge2.MinorTicks.VertSize = 1
        Me.linearGauge2.MinorTicks.Visible = True
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.linearGauge2.RedLine.Brush.Color = System.Drawing.Color.Black
        ' 
        ' 
        ' 
        Me.linearGauge2.RedLine.Brush.Gradient.Direction = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.linearGauge2.RedLine.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.linearGauge2.RedLine.Brush.Gradient.ExtendedColorPalette = Nothing
        Me.linearGauge2.RedLine.Brush.Gradient.MiddleColor = System.Drawing.Color.Empty
        Me.linearGauge2.RedLine.Brush.Gradient.Sigma = True
        Me.linearGauge2.RedLine.Brush.Gradient.SigmaFocus = 0.0F
        Me.linearGauge2.RedLine.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.linearGauge2.RedLine.Brush.Gradient.Visible = True
        Me.linearGauge2.RedLine.Style = CType(resources.GetObject("resource.Style10"), Steema.TeeChart.Styles.GaugePointerStyles)
        Me.linearGauge2.RedLine.VertSize = 5
        Me.linearGauge2.RedLine.Visible = True
        Me.linearGauge2.RedLineEndValue = 100
        Me.linearGauge2.RedLineStartValue = 80
        Me.linearGauge2.ShowInLegend = False
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.linearGauge2.Ticks.Brush.Color = System.Drawing.Color.Transparent
        Me.linearGauge2.Ticks.Brush.Visible = False
        ' 
        ' 
        ' 
        Me.linearGauge2.Ticks.Pen.Color = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.linearGauge2.Ticks.Style = CType(resources.GetObject("resource.Style11"), Steema.TeeChart.Styles.GaugePointerStyles)
        Me.linearGauge2.Ticks.VertSize = 20
        Me.linearGauge2.Ticks.Visible = True
        Me.linearGauge2.Title = "linearGauge2"
        Me.linearGauge2.UseValueColorPalette = False
        Me.linearGauge2.Value = 0
        Me.linearGauge2.ValueColorPalette = New System.Drawing.Color() { _
        System.Drawing.Color.Green, _
        System.Drawing.Color.Yellow, _
        System.Drawing.Color.Orange, _
        System.Drawing.Color.Red}
        ' 
        ' 
        ' 
        Me.linearGauge2.XValues.DataMember = "X"
        Me.linearGauge2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' 
        ' 
        Me.linearGauge2.YValues.DataMember = "Y"
        ' 
        ' LinearGauge_Series
        ' 
#If VS2005 Then
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
#End If
        Me.ClientSize = New System.Drawing.Size(440, 317)
        Me.Name = "LinearGauge_Series"
        Me.Text = "LinearGauge_Series"
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.chartContainer.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

#End Region


    Private Sub InitializeChart()
        linearGauge1.UseValueColorPalette = True
    End Sub

    Private Sub bEditSeries_Click(ByVal sender As Object, ByVal e As EventArgs) Handles bEditSeries.Click
        Dim editor As Steema.TeeChart.Editors.Series.LinearGaugeSeries = New Steema.TeeChart.Editors.Series.LinearGaugeSeries(linearGauge1)
        Steema.TeeChart.Editors.EditorUtils.ShowFormModal(editor)
    End Sub

    Private Sub cbAnimate_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbAnimate.CheckedChanged
        timer1.Enabled = cbAnimate.Checked
    End Sub

    Dim rnd As Random = New Random()
    Private Sub timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles timer1.Tick
        Dim value As Double = rnd.Next(0, 100)
        linearGauge1.Value = value
        While (value = linearGauge1.Value)
            value = rnd.Next(0, 100)
        End While
        linearGauge2.Value = value
    End Sub

    
End Class

