
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing

Imports System.Windows.Forms



Public Class NumericGauge_Series
    Inherits Samples.BaseForm

    Private bEdit As Button
    Private timer1 As Timer
    Private cbAnimate As CheckBox
    Private numericGauge1 As Steema.TeeChart.Styles.NumericGauge
    Private numericGauge2 As Steema.TeeChart.Styles.NumericGauge

    '/ <summary>
    '/ Required designer variable.
    '/ </summary>
    Private components As System.ComponentModel.IContainer = Nothing


    Public Sub New() ' This call is required by the Windows Form Designer.
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
    '/ the contents of this method with the code editor.
    '/ </summary>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NumericGauge_Series))
        Me.bEdit = New System.Windows.Forms.Button
        Me.timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.cbAnimate = New System.Windows.Forms.CheckBox
        Me.numericGauge1 = New Steema.TeeChart.Styles.NumericGauge
        Me.numericGauge2 = New Steema.TeeChart.Styles.NumericGauge
        Me.panel1.SuspendLayout()
        Me.chartContainer.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Text = ("A new series type, Numeric Gauge, which displays a fast, fully " & vbCrLf & "customizable numeric and text gauge.")
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.cbAnimate)
        Me.panel1.Controls.Add(Me.bEdit)
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
        Me.tChart1.Axes.Bottom.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.tChart1.Axes.Bottom.Labels.Font.DrawingFont = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.tChart1.Axes.Bottom.Labels.Font.Size = 12
        Me.tChart1.Axes.Bottom.Labels.Font.SizeFloat = 12.0!
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
        Me.tChart1.Axes.Bottom.Title.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        Me.tChart1.Axes.Bottom.Title.Lines = New String() {"Axis Title %"}
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
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(216, Byte), Integer))
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
        Me.tChart1.Series.Add(Me.numericGauge1)
        Me.tChart1.Series.Add(Me.numericGauge2)
        Me.tChart1.Size = New System.Drawing.Size(440, 205)
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
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Walls.Back.Brush.Visible = True
        ' 
        ' bEdit
        ' 
        Me.bEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bEdit.Location = New System.Drawing.Point(12, 6)
        Me.bEdit.Name = "bEdit"
        Me.bEdit.Size = New System.Drawing.Size(115, 23)
        Me.bEdit.TabIndex = 1
        Me.bEdit.Text = "Edit Top Series..."
        AddHandler bEdit.Click, AddressOf Me.bEdit_Click
        ' 
        ' timer1
        ' 
        AddHandler timer1.Tick, AddressOf Me.timer1_Tick
        ' 
        ' cbAnimate
        ' 
        Me.cbAnimate.Checked = True
        Me.cbAnimate.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbAnimate.Location = New System.Drawing.Point(133, 6)
        Me.cbAnimate.Name = "cbAnimate"
        Me.cbAnimate.Size = New System.Drawing.Size(104, 24)
        Me.cbAnimate.TabIndex = 0
        Me.cbAnimate.Text = "Animate!"
        AddHandler cbAnimate.CheckedChanged, AddressOf Me.cbAnimate_CheckedChanged
        ' 
        ' numericGauge1
        ' 
        Me.numericGauge1.ColorEach = False
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.numericGauge1.FaceBrush.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.numericGauge1.FaceBrush.Gradient.ExtendedColorPalette = Nothing
        Me.numericGauge1.FaceBrush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.numericGauge1.FaceBrush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        ' 
        ' 
        ' 
        Me.numericGauge1.FaceBrush.Gradient.Style.CenterXOffset = 37
        Me.numericGauge1.FaceBrush.Gradient.Style.CenterYOffset = -12
        Me.numericGauge1.FaceBrush.Gradient.Style.Direction = Steema.TeeChart.Drawing.PathGradientMode.Radial
        Me.numericGauge1.FaceBrush.Gradient.Style.Visible = True
        Me.numericGauge1.FaceBrush.Gradient.UseMiddle = True
        Me.numericGauge1.FaceBrush.Gradient.Visible = True
        ' 
        ' 
        ' 
        Me.numericGauge1.Frame.Circled = False
        Me.numericGauge1.GaugeColorPalette = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(125, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(200, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(160, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer)), System.Drawing.Color.Empty, System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer)), System.Drawing.Color.Empty, System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(30, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(60, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(60, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(60, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(10, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer)), System.Drawing.Color.Empty, System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))}
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.numericGauge1.GreenLine.Brush.Color = System.Drawing.Color.Black
        ' 
        ' 
        ' 
        Me.numericGauge1.GreenLine.Brush.Gradient.Direction = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.numericGauge1.GreenLine.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.numericGauge1.GreenLine.Brush.Gradient.ExtendedColorPalette = Nothing
        Me.numericGauge1.GreenLine.Brush.Gradient.MiddleColor = System.Drawing.Color.Empty
        Me.numericGauge1.GreenLine.Brush.Gradient.Sigma = True
        Me.numericGauge1.GreenLine.Brush.Gradient.SigmaFocus = 0.0!
        Me.numericGauge1.GreenLine.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.numericGauge1.GreenLine.Brush.Gradient.Visible = True
        Me.numericGauge1.GreenLine.Style = CType(resources.GetObject("resource.Style"), Steema.TeeChart.Styles.GaugePointerStyles)
        Me.numericGauge1.GreenLine.VertSize = 5
        Me.numericGauge1.GreenLine.Visible = True
        Me.numericGauge1.GreenLineEndValue = 0
        Me.numericGauge1.GreenLineStartValue = 0
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.numericGauge1.Hand.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        ' 
        ' 
        ' 
        Me.numericGauge1.Hand.Pen.Color = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.numericGauge1.Hand.Style = CType(resources.GetObject("resource.Style1"), Steema.TeeChart.Styles.GaugePointerStyles)
        Me.numericGauge1.Hand.Visible = True
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.numericGauge1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None
        Me.numericGauge1.Marks.Callout.ArrowHeadSize = 8
        ' 
        ' 
        ' 
        Me.numericGauge1.Marks.Callout.Brush.Color = System.Drawing.Color.Black
        Me.numericGauge1.Marks.Callout.Distance = 0
        Me.numericGauge1.Marks.Callout.Draw3D = False
        Me.numericGauge1.Marks.Callout.Length = 10
        Me.numericGauge1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        ' 
        ' 
        ' 
        Me.numericGauge1.Marks.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        Me.numericGauge1.Maximum = Double.PositiveInfinity
        Me.numericGauge1.Minimum = 0
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.numericGauge1.MinorTicks.Brush.Color = System.Drawing.Color.Transparent
        Me.numericGauge1.MinorTicks.Brush.Visible = False
        Me.numericGauge1.MinorTicks.HorizSize = 1
        ' 
        ' 
        ' 
        Me.numericGauge1.MinorTicks.Pen.Color = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.numericGauge1.MinorTicks.Style = CType(resources.GetObject("resource.Style2"), Steema.TeeChart.Styles.GaugePointerStyles)
        Me.numericGauge1.MinorTicks.VertSize = 1
        Me.numericGauge1.MinorTicks.Visible = True
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.numericGauge1.RedLine.Brush.Color = System.Drawing.Color.Black
        ' 
        ' 
        ' 
        Me.numericGauge1.RedLine.Brush.Gradient.Direction = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.numericGauge1.RedLine.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.numericGauge1.RedLine.Brush.Gradient.ExtendedColorPalette = Nothing
        Me.numericGauge1.RedLine.Brush.Gradient.MiddleColor = System.Drawing.Color.Empty
        Me.numericGauge1.RedLine.Brush.Gradient.Sigma = True
        Me.numericGauge1.RedLine.Brush.Gradient.SigmaFocus = 0.0!
        Me.numericGauge1.RedLine.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.numericGauge1.RedLine.Brush.Gradient.Visible = True
        Me.numericGauge1.RedLine.Style = CType(resources.GetObject("resource.Style3"), Steema.TeeChart.Styles.GaugePointerStyles)
        Me.numericGauge1.RedLine.VertSize = 5
        Me.numericGauge1.RedLine.Visible = True
        Me.numericGauge1.RedLineEndValue = 0
        Me.numericGauge1.RedLineStartValue = 0
        Me.numericGauge1.ShowInLegend = False
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.numericGauge1.Ticks.Brush.Color = System.Drawing.Color.Transparent
        Me.numericGauge1.Ticks.Brush.Visible = False
        ' 
        ' 
        ' 
        Me.numericGauge1.Ticks.Pen.Color = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.numericGauge1.Ticks.Style = CType(resources.GetObject("resource.Style4"), Steema.TeeChart.Styles.GaugePointerStyles)
        Me.numericGauge1.Ticks.VertSize = 20
        Me.numericGauge1.Ticks.Visible = True
        Me.numericGauge1.Title = "numericGauge1"
        Me.numericGauge1.Value = 0
        ' 
        ' 
        ' 
        Me.numericGauge1.XValues.DataMember = "X"
        Me.numericGauge1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' 
        ' 
        Me.numericGauge1.YValues.DataMember = "Y"
        ' 
        ' numericGauge2
        ' 
        Me.numericGauge2.ColorEach = False
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.numericGauge2.FaceBrush.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.numericGauge2.FaceBrush.Gradient.ExtendedColorPalette = Nothing
        Me.numericGauge2.FaceBrush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.numericGauge2.FaceBrush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        ' 
        ' 
        ' 
        Me.numericGauge2.FaceBrush.Gradient.Style.CenterXOffset = 37
        Me.numericGauge2.FaceBrush.Gradient.Style.CenterYOffset = -12
        Me.numericGauge2.FaceBrush.Gradient.Style.Direction = Steema.TeeChart.Drawing.PathGradientMode.Radial
        Me.numericGauge2.FaceBrush.Gradient.Style.Visible = True
        Me.numericGauge2.FaceBrush.Gradient.UseMiddle = True
        Me.numericGauge2.FaceBrush.Gradient.Visible = True
        ' 
        ' 
        ' 
        Me.numericGauge2.Frame.Circled = False
        Me.numericGauge2.GaugeColorPalette = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(125, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(200, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(160, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer)), System.Drawing.Color.Empty, System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer)), System.Drawing.Color.Empty, System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(30, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(60, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(60, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(60, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(10, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer)), System.Drawing.Color.Empty, System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))}
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.numericGauge2.GreenLine.Brush.Color = System.Drawing.Color.Black
        ' 
        ' 
        ' 
        Me.numericGauge2.GreenLine.Brush.Gradient.Direction = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.numericGauge2.GreenLine.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.numericGauge2.GreenLine.Brush.Gradient.ExtendedColorPalette = Nothing
        Me.numericGauge2.GreenLine.Brush.Gradient.MiddleColor = System.Drawing.Color.Empty
        Me.numericGauge2.GreenLine.Brush.Gradient.Sigma = True
        Me.numericGauge2.GreenLine.Brush.Gradient.SigmaFocus = 0.0!
        Me.numericGauge2.GreenLine.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.numericGauge2.GreenLine.Brush.Gradient.Visible = True
        Me.numericGauge2.GreenLine.Style = CType(resources.GetObject("resource.Style5"), Steema.TeeChart.Styles.GaugePointerStyles)
        Me.numericGauge2.GreenLine.VertSize = 5
        Me.numericGauge2.GreenLine.Visible = True
        Me.numericGauge2.GreenLineEndValue = 0
        Me.numericGauge2.GreenLineStartValue = 0
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.numericGauge2.Hand.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        ' 
        ' 
        ' 
        Me.numericGauge2.Hand.Pen.Color = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.numericGauge2.Hand.Style = CType(resources.GetObject("resource.Style6"), Steema.TeeChart.Styles.GaugePointerStyles)
        Me.numericGauge2.Hand.Visible = True
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.numericGauge2.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None
        Me.numericGauge2.Marks.Callout.ArrowHeadSize = 8
        ' 
        ' 
        ' 
        Me.numericGauge2.Marks.Callout.Brush.Color = System.Drawing.Color.Black
        Me.numericGauge2.Marks.Callout.Distance = 0
        Me.numericGauge2.Marks.Callout.Draw3D = False
        Me.numericGauge2.Marks.Callout.Length = 10
        Me.numericGauge2.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        ' 
        ' 
        ' 
        Me.numericGauge2.Marks.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        Me.numericGauge2.Maximum = Double.PositiveInfinity
        Me.numericGauge2.Minimum = 0
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.numericGauge2.MinorTicks.Brush.Color = System.Drawing.Color.Transparent
        Me.numericGauge2.MinorTicks.Brush.Visible = False
        Me.numericGauge2.MinorTicks.HorizSize = 1
        ' 
        ' 
        ' 
        Me.numericGauge2.MinorTicks.Pen.Color = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.numericGauge2.MinorTicks.Style = CType(resources.GetObject("resource.Style7"), Steema.TeeChart.Styles.GaugePointerStyles)
        Me.numericGauge2.MinorTicks.VertSize = 1
        Me.numericGauge2.MinorTicks.Visible = True
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.numericGauge2.RedLine.Brush.Color = System.Drawing.Color.Black
        ' 
        ' 
        ' 
        Me.numericGauge2.RedLine.Brush.Gradient.Direction = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.numericGauge2.RedLine.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.numericGauge2.RedLine.Brush.Gradient.ExtendedColorPalette = Nothing
        Me.numericGauge2.RedLine.Brush.Gradient.MiddleColor = System.Drawing.Color.Empty
        Me.numericGauge2.RedLine.Brush.Gradient.Sigma = True
        Me.numericGauge2.RedLine.Brush.Gradient.SigmaFocus = 0.0!
        Me.numericGauge2.RedLine.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.numericGauge2.RedLine.Brush.Gradient.Visible = True
        Me.numericGauge2.RedLine.Style = CType(resources.GetObject("resource.Style8"), Steema.TeeChart.Styles.GaugePointerStyles)
        Me.numericGauge2.RedLine.VertSize = 5
        Me.numericGauge2.RedLine.Visible = True
        Me.numericGauge2.RedLineEndValue = 0
        Me.numericGauge2.RedLineStartValue = 0
        Me.numericGauge2.ShowInLegend = False
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.numericGauge2.Ticks.Brush.Color = System.Drawing.Color.Transparent
        Me.numericGauge2.Ticks.Brush.Visible = False
        ' 
        ' 
        ' 
        Me.numericGauge2.Ticks.Pen.Color = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.numericGauge2.Ticks.Style = CType(resources.GetObject("resource.Style9"), Steema.TeeChart.Styles.GaugePointerStyles)
        Me.numericGauge2.Ticks.VertSize = 20
        Me.numericGauge2.Ticks.Visible = True
        Me.numericGauge2.Title = "numericGauge2"
        Me.numericGauge2.Value = 0
        ' 
        ' 
        ' 
        Me.numericGauge2.XValues.DataMember = "X"
        Me.numericGauge2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' 
        ' 
        Me.numericGauge2.YValues.DataMember = "Y"
        ' 
        ' NumericGauge_Series
        ' 
#If VS2005 Then
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
#End If
        Me.ClientSize = New System.Drawing.Size(440, 317)
        Me.Name = "NumericGauge_Series"
        Me.Text = "NumericGauge_Series"
        Me.panel1.ResumeLayout(False)
        Me.chartContainer.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub InitializeChart()
        timer1.Enabled = True
        numericGauge1.GaugeColorPalette = Steema.TeeChart.Styles.NumericGauge.LCDPalette
        numericGauge1.DigitalFontType = Steema.TeeChart.Styles.DigitalFont.Dot
    End Sub

    Private rnd As Random = New Random()
    Private Sub timer1_Tick(ByVal sender As Object, ByVal e As EventArgs)

        Dim value As Double = rnd.NextDouble() * 1000
        numericGauge1.Value = value
        While (value = numericGauge1.Value)
            value = rnd.NextDouble() * 1000
        End While
        numericGauge2.Value = value
    End Sub

    Private Sub cbAnimate_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)

        timer1.Enabled = cbAnimate.Checked
    End Sub

    Private Sub bEdit_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim editor As Steema.TeeChart.Editors.Series.NumericGaugeSeries = New Steema.TeeChart.Editors.Series.NumericGaugeSeries(numericGauge1)
        Steema.TeeChart.Editors.EditorUtils.ShowFormModal(editor)
    End Sub

End Class

