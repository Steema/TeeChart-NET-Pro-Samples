Imports System
Imports System.ComponentModel
imports System.Data
imports System.Drawing
imports System.Text
imports System.Windows.Forms



Public Class Tool_Fibonacci
    Inherits Samples.BaseForm

    Private fibonacciTool1 As Steema.TeeChart.Tools.FibonacciTool
    Private WithEvents numericUpDown2 As NumericUpDown
    Private label2 As Label
    Private label1 As Label
    Private WithEvents numericUpDown1 As NumericUpDown
    Private buttonPen1 As ButtonPen
    Private WithEvents comboBox1 As ComboBox
    Private label3 As Label
    Private WithEvents checkBox1 As CheckBox

    Private candle1 As Steema.TeeChart.Styles.Candle

    '/ <summary>
    '/ Required designer variable.
    '/ </summary>
    Private components As System.ComponentModel.IContainer = Nothing


    Public Sub New() ' me call is required by the Windows Form Designer.
        InitializeComponent()
        candle1.FillSampleValues(40)
        fibonacciTool1.StartX = candle1.DateValues(0)
        fibonacciTool1.StartY = candle1.CloseValues(0)
        fibonacciTool1.EndX = candle1.DateValues(10)
        fibonacciTool1.EndY = candle1.CloseValues(10)
        buttonPen1.Pen = fibonacciTool1.TrendPen
        comboBox1.SelectedIndex = 0
    End Sub

    Private Sub numericUpDown1_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles numericUpDown1.ValueChanged
        fibonacciTool1.StartX = candle1.DateValues(CType(numericUpDown1.Value, Integer))
        fibonacciTool1.StartY = candle1.CloseValues(CType(numericUpDown1.Value, Integer))
    End Sub

    Private Sub numericUpDown2_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles numericUpDown2.ValueChanged
        If Not numericUpDown2.Value = 10D Then
            fibonacciTool1.EndX = candle1.DateValues(CType(numericUpDown2.Value, Integer))
            fibonacciTool1.EndY = candle1.CloseValues(CType(numericUpDown2.Value, Integer))
        End If
    End Sub

    Private Sub comboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox1.SelectedIndexChanged
        fibonacciTool1.DrawStyle = CType(comboBox1.SelectedIndex, Steema.TeeChart.Tools.FibonacciStyle)
    End Sub

    Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox1.CheckedChanged
        fibonacciTool1.ShowLabels = checkBox1.Checked
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Tool_Fibonacci))
        Me.candle1 = New Steema.TeeChart.Styles.Candle
        Me.fibonacciTool1 = New Steema.TeeChart.Tools.FibonacciTool
        Me.numericUpDown1 = New System.Windows.Forms.NumericUpDown
        Me.label1 = New System.Windows.Forms.Label
        Me.label2 = New System.Windows.Forms.Label
        Me.numericUpDown2 = New System.Windows.Forms.NumericUpDown
        Me.buttonPen1 = New Steema.TeeChart.ButtonPen
        Me.label3 = New System.Windows.Forms.Label
        Me.comboBox1 = New System.Windows.Forms.ComboBox
        Me.checkBox1 = New System.Windows.Forms.CheckBox
        Me.panel1.SuspendLayout()
        Me.chartContainer.SuspendLayout()
        CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'textBox1
        '
        Me.textBox1.Text = resources.GetString("textBox1.Text")
        '
        'panel1
        '
        Me.panel1.Controls.Add(Me.checkBox1)
        Me.panel1.Controls.Add(Me.comboBox1)
        Me.panel1.Controls.Add(Me.label3)
        Me.panel1.Controls.Add(Me.buttonPen1)
        Me.panel1.Controls.Add(Me.numericUpDown2)
        Me.panel1.Controls.Add(Me.label2)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Controls.Add(Me.numericUpDown1)
        Me.panel1.Size = New System.Drawing.Size(440, 72)
        '
        'tChart1
        '
        '
        '
        '
        Me.tChart1.Aspect.ColorPaletteIndex = -1
        Me.tChart1.Aspect.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighSpeed
        Me.tChart1.Aspect.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
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
        Me.tChart1.Axes.Bottom.AxisPen.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        '
        '
        Me.tChart1.Axes.Bottom.Grid.Color = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tChart1.Axes.Bottom.Grid.Style = System.Drawing.Drawing2D.DashStyle.Dot
        '
        '
        '
        '
        '
        '
        Me.tChart1.Axes.Bottom.Labels.Font.Name = "Arial"
        '
        '
        '
        Me.tChart1.Axes.Bottom.MinorTicks.Visible = False
        '
        '
        '
        Me.tChart1.Axes.Bottom.Ticks.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tChart1.Axes.Bottom.Ticks.Length = 2
        '
        '
        '
        Me.tChart1.Axes.Bottom.TicksInner.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        '
        '
        '
        '
        '
        Me.tChart1.Axes.Bottom.Title.Font.Name = "Arial"
        '
        '
        '
        '
        '
        '
        Me.tChart1.Axes.Depth.AxisPen.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        '
        '
        Me.tChart1.Axes.Depth.Grid.Color = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tChart1.Axes.Depth.Grid.Style = System.Drawing.Drawing2D.DashStyle.Dot
        '
        '
        '
        '
        '
        '
        Me.tChart1.Axes.Depth.Labels.Font.Name = "Arial"
        '
        '
        '
        Me.tChart1.Axes.Depth.MinorTicks.Visible = False
        '
        '
        '
        Me.tChart1.Axes.Depth.Ticks.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tChart1.Axes.Depth.Ticks.Length = 2
        '
        '
        '
        Me.tChart1.Axes.Depth.TicksInner.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        '
        '
        '
        '
        '
        Me.tChart1.Axes.Depth.Title.Font.Name = "Arial"
        '
        '
        '
        '
        '
        '
        Me.tChart1.Axes.DepthTop.AxisPen.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        '
        '
        Me.tChart1.Axes.DepthTop.Grid.Color = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tChart1.Axes.DepthTop.Grid.Style = System.Drawing.Drawing2D.DashStyle.Dot
        '
        '
        '
        '
        '
        '
        Me.tChart1.Axes.DepthTop.Labels.Font.Name = "Arial"
        '
        '
        '
        Me.tChart1.Axes.DepthTop.MinorTicks.Visible = False
        '
        '
        '
        Me.tChart1.Axes.DepthTop.Ticks.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tChart1.Axes.DepthTop.Ticks.Length = 2
        '
        '
        '
        Me.tChart1.Axes.DepthTop.TicksInner.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        '
        '
        '
        '
        '
        Me.tChart1.Axes.DepthTop.Title.Font.Name = "Arial"
        '
        '
        '
        '
        '
        '
        Me.tChart1.Axes.Left.AxisPen.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        '
        '
        Me.tChart1.Axes.Left.Grid.Color = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tChart1.Axes.Left.Grid.Style = System.Drawing.Drawing2D.DashStyle.Dot
        '
        '
        '
        '
        '
        '
        Me.tChart1.Axes.Left.Labels.Font.Name = "Arial"
        '
        '
        '
        Me.tChart1.Axes.Left.MinorTicks.Visible = False
        '
        '
        '
        Me.tChart1.Axes.Left.Ticks.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tChart1.Axes.Left.Ticks.Length = 2
        '
        '
        '
        Me.tChart1.Axes.Left.TicksInner.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        '
        '
        '
        '
        '
        Me.tChart1.Axes.Left.Title.Font.Name = "Arial"
        '
        '
        '
        '
        '
        '
        Me.tChart1.Axes.Right.AxisPen.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        '
        '
        Me.tChart1.Axes.Right.Grid.Color = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tChart1.Axes.Right.Grid.Style = System.Drawing.Drawing2D.DashStyle.Dot
        '
        '
        '
        '
        '
        '
        Me.tChart1.Axes.Right.Labels.Font.Name = "Arial"
        '
        '
        '
        Me.tChart1.Axes.Right.MinorTicks.Visible = False
        '
        '
        '
        Me.tChart1.Axes.Right.Ticks.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tChart1.Axes.Right.Ticks.Length = 2
        '
        '
        '
        Me.tChart1.Axes.Right.TicksInner.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        '
        '
        '
        '
        '
        Me.tChart1.Axes.Right.Title.Font.Name = "Arial"
        '
        '
        '
        '
        '
        '
        Me.tChart1.Axes.Top.AxisPen.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        '
        '
        Me.tChart1.Axes.Top.Grid.Color = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tChart1.Axes.Top.Grid.Style = System.Drawing.Drawing2D.DashStyle.Dot
        '
        '
        '
        '
        '
        '
        Me.tChart1.Axes.Top.Labels.Font.Name = "Arial"
        '
        '
        '
        Me.tChart1.Axes.Top.MinorTicks.Visible = False
        '
        '
        '
        Me.tChart1.Axes.Top.Ticks.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tChart1.Axes.Top.Ticks.Length = 2
        '
        '
        '
        Me.tChart1.Axes.Top.TicksInner.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        '
        '
        '
        '
        '
        Me.tChart1.Axes.Top.Title.Font.Name = "Arial"
        Me.tChart1.Cursor = System.Windows.Forms.Cursors.Default
        '
        '
        '
        '
        '
        '
        '
        '
        '
        Me.tChart1.Header.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tChart1.Header.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tChart1.Header.Brush.Gradient.SigmaFocus = 0.0!
        Me.tChart1.Header.Brush.Gradient.SigmaScale = 0.0!
        Me.tChart1.Header.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tChart1.Header.Brush.Gradient.UseMiddle = True
        '
        '
        '
        '
        '
        '
        Me.tChart1.Header.Font.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tChart1.Header.Font.Name = "Arial"
        Me.tChart1.Header.Lines = New String() {"Financial data analysis"}
        '
        '
        '
        Me.tChart1.Header.Pen.Visible = False
        '
        '
        '
        '
        '
        '
        '
        '
        '
        Me.tChart1.Legend.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tChart1.Legend.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tChart1.Legend.Brush.Gradient.SigmaFocus = 0.0!
        Me.tChart1.Legend.Brush.Gradient.SigmaScale = 0.0!
        Me.tChart1.Legend.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tChart1.Legend.Brush.Gradient.UseMiddle = True
        '
        '
        '
        Me.tChart1.Legend.Font.Name = "Arial"
        '
        '
        '
        '
        '
        '
        Me.tChart1.Legend.Shadow.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        '
        '
        Me.tChart1.Legend.Shadow.Brush.Gradient.Transparency = 50
        '
        '
        '
        '
        '
        '
        Me.tChart1.Legend.Title.Pen.Visible = False
        Me.tChart1.Legend.Visible = False
        Me.tChart1.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        '
        '
        '
        Me.tChart1.Panel.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None
        '
        '
        '
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tChart1.Panel.Brush.Gradient.SigmaFocus = 0.0!
        Me.tChart1.Panel.Brush.Gradient.SigmaScale = 0.0!
        Me.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tChart1.Panel.Gradient.Visible = True
        '
        '
        '
        Me.tChart1.Panel.Pen.Visible = True
        '
        '
        '
        Me.tChart1.Panel.Shadow.Height = 5
        Me.tChart1.Panel.Shadow.Width = 5
        Me.tChart1.Series.Add(Me.candle1)
        Me.tChart1.Size = New System.Drawing.Size(440, 172)
        Me.tChart1.Tools.Add(Me.fibonacciTool1)
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
        Me.tChart1.Walls.Back.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tChart1.Walls.Back.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tChart1.Walls.Back.Brush.Gradient.SigmaFocus = 0.0!
        Me.tChart1.Walls.Back.Brush.Gradient.SigmaScale = 0.0!
        Me.tChart1.Walls.Back.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tChart1.Walls.Back.Brush.Gradient.UseMiddle = True
        Me.tChart1.Walls.Back.Brush.Gradient.Visible = False
        Me.tChart1.Walls.Back.Brush.Visible = False
        Me.tChart1.Walls.Back.Transparent = True
        '
        '
        '
        '
        '
        '
        '
        '
        '
        Me.tChart1.Walls.Bottom.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tChart1.Walls.Bottom.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tChart1.Walls.Bottom.Brush.Gradient.SigmaFocus = 0.0!
        Me.tChart1.Walls.Bottom.Brush.Gradient.SigmaScale = 0.0!
        Me.tChart1.Walls.Bottom.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tChart1.Walls.Bottom.Brush.Gradient.UseMiddle = True
        '
        '
        '
        '
        '
        '
        Me.tChart1.Walls.Left.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        '
        '
        '
        Me.tChart1.Walls.Left.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tChart1.Walls.Left.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tChart1.Walls.Left.Brush.Gradient.SigmaFocus = 0.0!
        Me.tChart1.Walls.Left.Brush.Gradient.SigmaScale = 0.0!
        Me.tChart1.Walls.Left.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tChart1.Walls.Left.Brush.Gradient.UseMiddle = True
        '
        '
        '
        '
        '
        '
        Me.tChart1.Walls.Right.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        '
        '
        '
        Me.tChart1.Walls.Right.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tChart1.Walls.Right.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tChart1.Walls.Right.Brush.Gradient.SigmaFocus = 0.0!
        Me.tChart1.Walls.Right.Brush.Gradient.SigmaScale = 0.0!
        Me.tChart1.Walls.Right.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tChart1.Walls.Right.Brush.Gradient.UseMiddle = True
        '
        'chartContainer
        '
        Me.chartContainer.Location = New System.Drawing.Point(0, 145)
        Me.chartContainer.Size = New System.Drawing.Size(440, 172)
        '
        'candle1
        '
        '
        '
        '
        Me.candle1.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.candle1.CloseValues = Me.candle1.YValues
        Me.candle1.ColorEach = False
        Me.candle1.DateValues = Me.candle1.XValues
        '
        '
        '
        Me.candle1.HighLowPen.Color = System.Drawing.Color.Black
        '
        '
        '
        Me.candle1.LinePen.Color = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        '
        '
        '
        '
        '
        '
        '
        '
        Me.candle1.Marks.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.candle1.Marks.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.candle1.Marks.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.candle1.Marks.Brush.Gradient.UseMiddle = True
        '
        '
        '
        Me.candle1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None
        Me.candle1.Marks.Callout.ArrowHeadSize = 8
        '
        '
        '
        Me.candle1.Marks.Callout.Brush.Color = System.Drawing.Color.Black
        Me.candle1.Marks.Callout.Distance = 0
        Me.candle1.Marks.Callout.Draw3D = False
        Me.candle1.Marks.Callout.Length = 10
        Me.candle1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        '
        '
        '
        Me.candle1.Pointer.Draw3D = False
        Me.candle1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.candle1.Pointer.Visible = True
        Me.candle1.Title = "candle1"
        '
        '
        '
        Me.candle1.XValues.DataMember = "Date"
        Me.candle1.XValues.DateTime = True
        Me.candle1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        '
        '
        '
        Me.candle1.YValues.DataMember = "Close"
        '
        'fibonacciTool1
        '
        Me.fibonacciTool1.EndX = 0
        Me.fibonacciTool1.EndY = 0
        Me.fibonacciTool1.Series = Me.candle1
        Me.fibonacciTool1.StartX = 0
        Me.fibonacciTool1.StartY = 0
        '
        'numericUpDown1
        '
        Me.numericUpDown1.Location = New System.Drawing.Point(101, 10)
        Me.numericUpDown1.Maximum = New Decimal(New Integer() {38, 0, 0, 0})
        Me.numericUpDown1.Name = "numericUpDown1"
        Me.numericUpDown1.Size = New System.Drawing.Size(47, 20)
        Me.numericUpDown1.TabIndex = 0
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(12, 12)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(83, 13)
        Me.label1.TabIndex = 1
        Me.label1.Text = "Start point index"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(12, 36)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(80, 13)
        Me.label2.TabIndex = 2
        Me.label2.Text = "End point index"
        '
        'numericUpDown2
        '
        Me.numericUpDown2.Location = New System.Drawing.Point(101, 34)
        Me.numericUpDown2.Maximum = New Decimal(New Integer() {39, 0, 0, 0})
        Me.numericUpDown2.Name = "numericUpDown2"
        Me.numericUpDown2.Size = New System.Drawing.Size(47, 20)
        Me.numericUpDown2.TabIndex = 3
        Me.numericUpDown2.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'buttonPen1
        '
        Me.buttonPen1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonPen1.Location = New System.Drawing.Point(228, 4)
        Me.buttonPen1.Name = "buttonPen1"
        Me.buttonPen1.Size = New System.Drawing.Size(75, 23)
        Me.buttonPen1.TabIndex = 4
    Me.buttonPen1.Text = "Trendline"
#If VS2005 Then
        Me.buttonPen1.UseVisualStyleBackColor = True
#End If
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(175, 36)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(47, 13)
        Me.label3.TabIndex = 5
        Me.label3.Text = "Arc style"
        '
        'comboBox1
    '
#If VS2005 Then
        Me.comboBox1.FormattingEnabled = True
#End If
        Me.comboBox1.Items.AddRange(New Object() {"Arc", "Fan lines"})
        Me.comboBox1.Location = New System.Drawing.Point(228, 33)
        Me.comboBox1.Name = "comboBox1"
        Me.comboBox1.Size = New System.Drawing.Size(75, 21)
        Me.comboBox1.TabIndex = 6
        '
        'checkBox1
    '
#If VS2005 Then
        Me.checkBox1.AutoSize = True
#End If
        Me.checkBox1.Checked = True
        Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox1.Location = New System.Drawing.Point(324, 32)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(79, 17)
        Me.checkBox1.TabIndex = 7
    Me.checkBox1.Text = "Level labels"
#If VS2005 Then
        Me.checkBox1.UseVisualStyleBackColor = True
#End If
        '
        'Tool_Fibonacci
        '
        Me.ClientSize = New System.Drawing.Size(440, 317)
        Me.Name = "Tool_Fibonacci"
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.chartContainer.ResumeLayout(False)
        CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
#End Region

End Class

