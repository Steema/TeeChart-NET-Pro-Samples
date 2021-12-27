
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms



Public Class Function_ADX
    Inherits Steema.TeeChart.Samples.BaseForm
    Private label1 As System.Windows.Forms.Label
    Private WithEvents UDPeriod As System.Windows.Forms.NumericUpDown
    Private candle1 As Steema.TeeChart.Styles.Candle
    Private axis1 As Steema.TeeChart.Axis
    Private adxFunction1 As Steema.TeeChart.Functions.ADXFunction
    Private line1 As Steema.TeeChart.Styles.Line
    Private components As System.ComponentModel.IContainer = Nothing
    
    
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        UDPeriod.Value = Convert.ToDecimal(adxFunction1.Period)
        candle1.FillSampleValues(300)
    End Sub 'New
    
    
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

#Region "Designer generated code"

    '/ <summary>
    '/ Required method for Designer support - do not modify
    '/ the contents of this method with the code editor.
    '/ </summary>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.label1 = New System.Windows.Forms.Label
        Me.UDPeriod = New System.Windows.Forms.NumericUpDown
        Me.candle1 = New Steema.TeeChart.Styles.Candle
        Me.axis1 = New Steema.TeeChart.Axis(Me.tChart1.Chart)
        Me.adxFunction1 = New Steema.TeeChart.Functions.ADXFunction
        Me.line1 = New Steema.TeeChart.Styles.Line
        Me.panel1.SuspendLayout()
        CType(Me.UDPeriod, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Text = "A.D.X ( Average Directional Change ), is a commonly used" + vbCr + vbLf + "indicator function in F" + "inancial charting applications." + vbCr + vbLf + vbCr + vbLf + "The ADX Function uses a OHLC ( Candle ) serie" + "s as datasource," + vbCr + vbLf + "and plots 3 lines: DMI+ , ADX and DMI-"
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.UDPeriod)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Name = "panel1"
        ' 
        ' tChart1
        ' 
        ' 
        ' tChart1.Aspect
        ' 
        Me.tChart1.Aspect.ColorPaletteIndex = -1
        Me.tChart1.Aspect.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality
        Me.tChart1.Aspect.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        Me.tChart1.Aspect.ThemeIndex = 2
        Me.tChart1.Aspect.View3D = False
        ' 
        ' tChart1.Axes
        ' 
        ' 
        ' tChart1.Axes.Bottom
        ' 
        ' 
        ' tChart1.Axes.Bottom.AxisPen
        ' 
        Me.tChart1.Axes.Bottom.AxisPen.Width = 1
        ' 
        ' tChart1.Axes.Bottom.Grid
        ' 
        Me.tChart1.Axes.Bottom.Grid.Centered = True
        Me.tChart1.Axes.Bottom.Grid.Color = System.Drawing.Color.Black
        Me.tChart1.Axes.Bottom.Grid.Style = System.Drawing.Drawing2D.DashStyle.Solid
        ' 
        ' tChart1.Axes.Bottom.Labels
        ' 
        ' 
        ' tChart1.Axes.Bottom.Labels.Font
        ' 
        Me.tChart1.Axes.Bottom.Labels.Font.Bold = True
        Me.tChart1.Axes.Bottom.Labels.Font.Name = "Times New Roman"
        Me.tChart1.Axes.Bottom.Labels.Font.Size = 10
        ' 
        ' tChart1.Axes.Bottom.MinorGrid
        ' 
        Me.tChart1.Axes.Bottom.MinorGrid.Color = System.Drawing.Color.FromArgb(CType(229, System.Byte), CType(229, System.Byte), CType(229, System.Byte))
        ' 
        ' tChart1.Axes.Bottom.MinorTicks
        ' 
        Me.tChart1.Axes.Bottom.MinorTicks.Color = System.Drawing.Color.Black
        Me.tChart1.Axes.Bottom.MinorTicks.Visible = False
        ' 
        ' tChart1.Axes.Bottom.Ticks
        ' 
        Me.tChart1.Axes.Bottom.Ticks.Color = System.Drawing.Color.Black
        Me.tChart1.Axes.Bottom.Ticks.Length = 2
        ' 
        ' tChart1.Axes.Bottom.TicksInner
        ' 
        Me.tChart1.Axes.Bottom.TicksInner.Color = System.Drawing.Color.Black
        Me.tChart1.Axes.Bottom.TicksInner.Visible = False
        ' 
        ' tChart1.Axes.Bottom.Title
        ' 
        ' 
        ' tChart1.Axes.Bottom.Title.Font
        ' 
        Me.tChart1.Axes.Bottom.Title.Font.Name = "Times New Roman"
        Me.tChart1.Axes.Custom.Add(Me.axis1)
        ' 
        ' tChart1.Axes.Depth
        ' 
        ' 
        ' tChart1.Axes.Depth.AxisPen
        ' 
        Me.tChart1.Axes.Depth.AxisPen.Width = 1
        ' 
        ' tChart1.Axes.Depth.Grid
        ' 
        Me.tChart1.Axes.Depth.Grid.Color = System.Drawing.Color.Black
        Me.tChart1.Axes.Depth.Grid.Style = System.Drawing.Drawing2D.DashStyle.Solid
        ' 
        ' tChart1.Axes.Depth.Labels
        ' 
        ' 
        ' tChart1.Axes.Depth.Labels.Font
        ' 
        Me.tChart1.Axes.Depth.Labels.Font.Name = "Times New Roman"
        Me.tChart1.Axes.Depth.Labels.Font.Size = 10
        ' 
        ' tChart1.Axes.Depth.MinorTicks
        ' 
        Me.tChart1.Axes.Depth.MinorTicks.Color = System.Drawing.Color.Black
        Me.tChart1.Axes.Depth.MinorTicks.Visible = False
        ' 
        ' tChart1.Axes.Depth.Ticks
        ' 
        Me.tChart1.Axes.Depth.Ticks.Color = System.Drawing.Color.Black
        Me.tChart1.Axes.Depth.Ticks.Length = 2
        ' 
        ' tChart1.Axes.Depth.TicksInner
        ' 
        Me.tChart1.Axes.Depth.TicksInner.Color = System.Drawing.Color.Black
        Me.tChart1.Axes.Depth.TicksInner.Visible = False
        ' 
        ' tChart1.Axes.Depth.Title
        ' 
        ' 
        ' tChart1.Axes.Depth.Title.Font
        ' 
        Me.tChart1.Axes.Depth.Title.Font.Name = "Times New Roman"
        ' 
        ' tChart1.Axes.Left
        ' 
        ' 
        ' tChart1.Axes.Left.AxisPen
        ' 
        Me.tChart1.Axes.Left.AxisPen.Width = 1
        Me.tChart1.Axes.Left.EndPosition = 55
        ' 
        ' tChart1.Axes.Left.Grid
        ' 
        Me.tChart1.Axes.Left.Grid.Color = System.Drawing.Color.Black
        Me.tChart1.Axes.Left.Grid.Style = System.Drawing.Drawing2D.DashStyle.Solid
        ' 
        ' tChart1.Axes.Left.Labels
        ' 
        ' 
        ' tChart1.Axes.Left.Labels.Font
        ' 
        Me.tChart1.Axes.Left.Labels.Font.Bold = True
        Me.tChart1.Axes.Left.Labels.Font.Name = "Times New Roman"
        Me.tChart1.Axes.Left.Labels.Font.Size = 10
        ' 
        ' tChart1.Axes.Left.MinorTicks
        ' 
        Me.tChart1.Axes.Left.MinorTicks.Color = System.Drawing.Color.Black
        Me.tChart1.Axes.Left.MinorTicks.Visible = False
        ' 
        ' tChart1.Axes.Left.Ticks
        ' 
        Me.tChart1.Axes.Left.Ticks.Color = System.Drawing.Color.Black
        Me.tChart1.Axes.Left.Ticks.Length = 2
        ' 
        ' tChart1.Axes.Left.TicksInner
        ' 
        Me.tChart1.Axes.Left.TicksInner.Color = System.Drawing.Color.Black
        Me.tChart1.Axes.Left.TicksInner.Visible = False
        ' 
        ' tChart1.Axes.Left.Title
        ' 
        ' 
        ' tChart1.Axes.Left.Title.Font
        ' 
        Me.tChart1.Axes.Left.Title.Font.Name = "Times New Roman"
        ' 
        ' tChart1.Axes.Right
        ' 
        ' 
        ' tChart1.Axes.Right.AxisPen
        ' 
        Me.tChart1.Axes.Right.AxisPen.Width = 1
        ' 
        ' tChart1.Axes.Right.Grid
        ' 
        Me.tChart1.Axes.Right.Grid.Color = System.Drawing.Color.Black
        Me.tChart1.Axes.Right.Grid.Style = System.Drawing.Drawing2D.DashStyle.Solid
        ' 
        ' tChart1.Axes.Right.Labels
        ' 
        ' 
        ' tChart1.Axes.Right.Labels.Font
        ' 
        Me.tChart1.Axes.Right.Labels.Font.Name = "Times New Roman"
        Me.tChart1.Axes.Right.Labels.Font.Size = 10
        ' 
        ' tChart1.Axes.Right.MinorTicks
        ' 
        Me.tChart1.Axes.Right.MinorTicks.Color = System.Drawing.Color.Black
        Me.tChart1.Axes.Right.MinorTicks.Visible = False
        ' 
        ' tChart1.Axes.Right.Ticks
        ' 
        Me.tChart1.Axes.Right.Ticks.Color = System.Drawing.Color.Black
        Me.tChart1.Axes.Right.Ticks.Length = 2
        ' 
        ' tChart1.Axes.Right.TicksInner
        ' 
        Me.tChart1.Axes.Right.TicksInner.Color = System.Drawing.Color.Black
        Me.tChart1.Axes.Right.TicksInner.Visible = False
        ' 
        ' tChart1.Axes.Right.Title
        ' 
        ' 
        ' tChart1.Axes.Right.Title.Font
        ' 
        Me.tChart1.Axes.Right.Title.Font.Name = "Times New Roman"
        ' 
        ' tChart1.Axes.Top
        ' 
        ' 
        ' tChart1.Axes.Top.AxisPen
        ' 
        Me.tChart1.Axes.Top.AxisPen.Width = 1
        ' 
        ' tChart1.Axes.Top.Grid
        ' 
        Me.tChart1.Axes.Top.Grid.Color = System.Drawing.Color.Black
        Me.tChart1.Axes.Top.Grid.Style = System.Drawing.Drawing2D.DashStyle.Solid
        ' 
        ' tChart1.Axes.Top.Labels
        ' 
        ' 
        ' tChart1.Axes.Top.Labels.Font
        ' 
        Me.tChart1.Axes.Top.Labels.Font.Name = "Times New Roman"
        Me.tChart1.Axes.Top.Labels.Font.Size = 10
        ' 
        ' tChart1.Axes.Top.MinorTicks
        ' 
        Me.tChart1.Axes.Top.MinorTicks.Color = System.Drawing.Color.Black
        Me.tChart1.Axes.Top.MinorTicks.Visible = False
        ' 
        ' tChart1.Axes.Top.Ticks
        ' 
        Me.tChart1.Axes.Top.Ticks.Color = System.Drawing.Color.Black
        Me.tChart1.Axes.Top.Ticks.Length = 2
        ' 
        ' tChart1.Axes.Top.TicksInner
        ' 
        Me.tChart1.Axes.Top.TicksInner.Color = System.Drawing.Color.Black
        Me.tChart1.Axes.Top.TicksInner.Visible = False
        ' 
        ' tChart1.Axes.Top.Title
        ' 
        ' 
        ' tChart1.Axes.Top.Title.Font
        ' 
        Me.tChart1.Axes.Top.Title.Font.Name = "Times New Roman"
        Me.tChart1.Cursor = System.Windows.Forms.Cursors.Default
        ' 
        ' tChart1.Header
        ' 
        ' 
        ' tChart1.Header.Brush
        ' 
        Me.tChart1.Header.Brush.Color = System.Drawing.Color.White
        ' 
        ' tChart1.Header.Gradient
        ' 
        Me.tChart1.Header.Brush.Gradient.EndColor = System.Drawing.Color.Gray
        Me.tChart1.Header.Brush.Gradient.MiddleColor = System.Drawing.Color.Empty
        Me.tChart1.Header.Brush.Gradient.StartColor = System.Drawing.Color.White
        Me.tChart1.Header.Brush.Gradient.Visible = True
        ' 
        ' tChart1.Header.Font
        ' 
        ' 
        ' tChart1.Header.Font.Brush
        ' 
        Me.tChart1.Header.Font.Brush.Color = System.Drawing.Color.Black
        Me.tChart1.Header.Font.Name = "Times New Roman"
        Me.tChart1.Header.Font.Size = 12
        ' 
        ' tChart1.Header.Gradient
        ' 
        Me.tChart1.Header.Gradient.EndColor = System.Drawing.Color.Gray
        Me.tChart1.Header.Gradient.MiddleColor = System.Drawing.Color.Empty
        Me.tChart1.Header.Gradient.StartColor = System.Drawing.Color.White
        Me.tChart1.Header.Gradient.Visible = True
        Me.tChart1.Header.Lines = New String() {"TeeChart"}
        ' 
        ' tChart1.Header.Pen
        ' 
        Me.tChart1.Header.Pen.Width = 2
        ' 
        ' tChart1.Header.Shadow
        ' 
        ' 
        ' tChart1.Header.Shadow.Brush
        ' 
        Me.tChart1.Header.Shadow.Brush.Color = System.Drawing.Color.FromArgb(CType(76, System.Byte), CType(169, System.Byte), CType(169, System.Byte), CType(169, System.Byte))
        Me.tChart1.Header.Shadow.Height = 4
        Me.tChart1.Header.Shadow.Width = 4
        Me.tChart1.Header.Visible = False
        ' 
        ' tChart1.Legend
        ' 
        ' 
        ' tChart1.Legend.Brush
        ' 
        ' 
        ' tChart1.Legend.Gradient
        ' 
        Me.tChart1.Legend.Brush.Gradient.EndColor = System.Drawing.Color.Yellow
        Me.tChart1.Legend.Brush.Gradient.MiddleColor = System.Drawing.Color.Empty
        Me.tChart1.Legend.Brush.Gradient.StartColor = System.Drawing.Color.White
        ' 
        ' tChart1.Legend.DividingLines
        ' 
        Me.tChart1.Legend.DividingLines.Color = System.Drawing.Color.Silver
        ' 
        ' tChart1.Legend.Font
        ' 
        ' 
        ' tChart1.Legend.Font.Brush
        ' 
        Me.tChart1.Legend.Font.Brush.Color = System.Drawing.Color.FromArgb(CType(100, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        Me.tChart1.Legend.Font.Name = "Times New Roman"
        Me.tChart1.Legend.Font.Size = 10
        ' 
        ' tChart1.Legend.Gradient
        ' 
        Me.tChart1.Legend.Gradient.EndColor = System.Drawing.Color.Yellow
        Me.tChart1.Legend.Gradient.MiddleColor = System.Drawing.Color.Empty
        Me.tChart1.Legend.Gradient.StartColor = System.Drawing.Color.White
        ' 
        ' tChart1.Legend.Pen
        ' 
        Me.tChart1.Legend.Pen.Visible = False
        ' 
        ' tChart1.Legend.Shadow
        ' 
        ' 
        ' tChart1.Legend.Shadow.Brush
        ' 
        Me.tChart1.Legend.Shadow.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(169, System.Byte), CType(169, System.Byte), CType(169, System.Byte))
        Me.tChart1.Legend.Shadow.Height = 0
        Me.tChart1.Legend.Shadow.Width = 0
        ' 
        ' tChart1.Legend.Symbol
        ' 
        Me.tChart1.Legend.Symbol.DefaultPen = False
        ' 
        ' tChart1.Legend.Symbol.Pen
        ' 
        Me.tChart1.Legend.Symbol.Pen.Visible = False
        Me.tChart1.Legend.Symbol.Squared = True
        Me.tChart1.Legend.Transparent = True
        Me.tChart1.Legend.Visible = False
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Bevel
        ' 
        Me.tChart1.Panel.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None
        ' 
        ' tChart1.Panel.Brush
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.White
        ' 
        ' tChart1.Panel.Gradient
        ' 
        Me.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.Yellow
        Me.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.Empty
        Me.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.White
        ' 
        ' tChart1.Panel.Gradient
        ' 
        Me.tChart1.Panel.Gradient.EndColor = System.Drawing.Color.Yellow
        Me.tChart1.Panel.Gradient.MiddleColor = System.Drawing.Color.Empty
        Me.tChart1.Panel.Gradient.StartColor = System.Drawing.Color.White
        ' 
        ' tChart1.Panel.Pen
        ' 
        Me.tChart1.Panel.Pen.Visible = True
        ' 
        ' tChart1.Panel.Shadow
        ' 
        ' 
        ' tChart1.Panel.Shadow.Brush
        ' 
        Me.tChart1.Panel.Shadow.Brush.Color = System.Drawing.Color.Black
        Me.tChart1.Panel.Shadow.Height = 0
        Me.tChart1.Panel.Shadow.Visible = True
        Me.tChart1.Panel.Shadow.Width = 0
        Me.tChart1.Series.Add(Me.candle1)
        Me.tChart1.Series.Add(Me.line1)
        ' 
        ' tChart1.Walls
        ' 
        ' 
        ' tChart1.Walls.Back
        ' 
        Me.tChart1.Walls.Back.ApplyDark = False
        ' 
        ' tChart1.Walls.Back.Brush
        ' 
        Me.tChart1.Walls.Back.Brush.Color = System.Drawing.Color.White
        ' 
        ' tChart1.Walls.Back.Gradient
        ' 
        Me.tChart1.Walls.Back.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(223, System.Byte), CType(122, System.Byte), CType(41, System.Byte))
        Me.tChart1.Walls.Back.Brush.Gradient.MiddleColor = System.Drawing.Color.Empty
        Me.tChart1.Walls.Back.Brush.Gradient.StartColor = System.Drawing.Color.White
        ' 
        ' tChart1.Walls.Back.Gradient
        ' 
        Me.tChart1.Walls.Back.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(223, System.Byte), CType(122, System.Byte), CType(41, System.Byte))
        Me.tChart1.Walls.Back.Gradient.MiddleColor = System.Drawing.Color.Empty
        Me.tChart1.Walls.Back.Gradient.StartColor = System.Drawing.Color.White
        Me.tChart1.Walls.Back.Size = 8
        Me.tChart1.Walls.Back.Transparent = False
        ' 
        ' tChart1.Walls.Bottom
        ' 
        Me.tChart1.Walls.Bottom.ApplyDark = False
        ' 
        ' tChart1.Walls.Bottom.Brush
        ' 
        ' 
        ' tChart1.Walls.Bottom.Gradient
        ' 
        Me.tChart1.Walls.Bottom.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(252, System.Byte), CType(254, System.Byte), CType(253, System.Byte))
        Me.tChart1.Walls.Bottom.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(47, System.Byte), CType(133, System.Byte), CType(253, System.Byte))
        ' 
        ' tChart1.Walls.Bottom.Gradient
        ' 
        Me.tChart1.Walls.Bottom.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(252, System.Byte), CType(254, System.Byte), CType(253, System.Byte))
        Me.tChart1.Walls.Bottom.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(47, System.Byte), CType(133, System.Byte), CType(253, System.Byte))
        Me.tChart1.Walls.Bottom.Size = 8
        ' 
        ' tChart1.Walls.Left
        ' 
        Me.tChart1.Walls.Left.ApplyDark = False
        ' 
        ' tChart1.Walls.Left.Brush
        ' 
        Me.tChart1.Walls.Left.Brush.Color = System.Drawing.Color.White
        ' 
        ' tChart1.Walls.Left.Gradient
        ' 
        Me.tChart1.Walls.Left.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(36, System.Byte), CType(209, System.Byte), CType(252, System.Byte))
        Me.tChart1.Walls.Left.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(13, System.Byte), CType(188, System.Byte), CType(124, System.Byte))
        ' 
        ' tChart1.Walls.Left.Gradient
        ' 
        Me.tChart1.Walls.Left.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(36, System.Byte), CType(209, System.Byte), CType(252, System.Byte))
        Me.tChart1.Walls.Left.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(13, System.Byte), CType(188, System.Byte), CType(124, System.Byte))
        Me.tChart1.Walls.Left.Size = 8
        ' 
        ' tChart1.Walls.Right
        ' 
        Me.tChart1.Walls.Right.ApplyDark = False
        ' 
        ' tChart1.Walls.Right.Brush
        ' 
        Me.tChart1.Walls.Right.Brush.Color = System.Drawing.Color.White
        Me.tChart1.Walls.Right.Size = 8
        ' 
        ' label1
        ' 
        Me.label1.Location = New System.Drawing.Point(16, 12)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(48, 23)
        Me.label1.TabIndex = 0
        Me.label1.Text = "&Period:"
        ' 
        ' UDPeriod
        ' 
        Me.UDPeriod.Location = New System.Drawing.Point(63, 10)
        Me.UDPeriod.Name = "UDPeriod"
        Me.UDPeriod.Size = New System.Drawing.Size(79, 20)
        Me.UDPeriod.TabIndex = 1
        ' 
        ' candle1
        ' 
        ' 
        ' candle1.Brush
        ' 
        Me.candle1.Brush.Color = System.Drawing.Color.FromArgb(CType(255, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        Me.candle1.CloseValues = Me.candle1.YValues
        Me.candle1.DateValues = Me.candle1.XValues
        ' 
        ' candle1.Marks
        ' 
        ' 
        ' candle1.Marks.Arrow
        ' 
        Me.candle1.Marks.Arrow.Color = System.Drawing.Color.Black
        ' 
        ' candle1.Marks.Brush
        ' 
        ' 
        ' candle1.Marks.Gradient
        ' 
        Me.candle1.Marks.Brush.Gradient.StartColor = System.Drawing.Color.Silver
        ' 
        ' candle1.Marks.Font
        ' 
        Me.candle1.Marks.Font.Name = "Times New Roman"
        Me.candle1.Marks.Font.Size = 10
        ' 
        ' candle1.Marks.Gradient
        ' 
        Me.candle1.Marks.Gradient.StartColor = System.Drawing.Color.Silver
        ' 
        ' candle1.Marks.Symbol
        ' 
        ' 
        ' candle1.Marks.Symbol.Shadow
        ' 
        Me.candle1.Marks.Symbol.Shadow.Height = 1
        Me.candle1.Marks.Symbol.Shadow.Visible = True
        Me.candle1.Marks.Symbol.Shadow.Width = 1
        Me.candle1.Marks.Transparent = True
        ' 
        ' candle1.Pointer
        ' 
        ' 
        ' candle1.Pointer.Brush
        ' 
        Me.candle1.Pointer.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(0, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        Me.candle1.Pointer.Draw3D = False
        Me.candle1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.candle1.Title = "candle1"
        ' 
        ' candle1.XValues
        ' 
        Me.candle1.XValues.DataMember = "Date"
        Me.candle1.XValues.DateTime = True
        Me.candle1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' candle1.YValues
        ' 
        Me.candle1.YValues.DataMember = "Close"
        ' 
        ' axis1
        ' 
        ' 
        ' axis1.AxisPen
        ' 
        Me.axis1.AxisPen.Width = 1
        ' 
        ' axis1.Grid
        ' 
        Me.axis1.Grid.Color = System.Drawing.Color.Black
        Me.axis1.Grid.Style = System.Drawing.Drawing2D.DashStyle.Solid
        Me.axis1.Horizontal = False
        ' 
        ' axis1.Labels
        ' 
        ' 
        ' axis1.Labels.Font
        ' 
        Me.axis1.Labels.Font.Name = "Times New Roman"
        Me.axis1.Labels.Font.Size = 10
        ' 
        ' axis1.MinorTicks
        ' 
        Me.axis1.MinorTicks.Color = System.Drawing.Color.Black
        Me.axis1.MinorTicks.Visible = False
        Me.axis1.OtherSide = False
        Me.axis1.StartPosition = 61
        ' 
        ' axis1.Ticks
        ' 
        Me.axis1.Ticks.Color = System.Drawing.Color.Black
        Me.axis1.Ticks.Length = 2
        ' 
        ' axis1.TicksInner
        ' 
        Me.axis1.TicksInner.Color = System.Drawing.Color.Black
        Me.axis1.TicksInner.Visible = False
        ' 
        ' axis1.Title
        ' 
        ' 
        ' axis1.Title.Font
        ' 
        Me.axis1.Title.Font.Name = "Times New Roman"
        ' 
        ' adxFunction1
        ' 
        Me.adxFunction1.Period = 14
        ' 
        ' line1
        ' 
        ' 
        ' line1.Brush
        ' 
        Me.line1.Brush.Color = System.Drawing.Color.FromArgb(CType(0, System.Byte), CType(255, System.Byte), CType(0, System.Byte))
        Me.line1.CustomVertAxis = Me.axis1
        Me.line1.DataSource = Me.candle1
        Me.line1.Function = Me.adxFunction1
        ' 
        ' line1.Marks
        ' 
        ' 
        ' line1.Marks.Arrow
        ' 
        Me.line1.Marks.Arrow.Color = System.Drawing.Color.Black
        ' 
        ' line1.Marks.Brush
        ' 
        ' 
        ' line1.Marks.Gradient
        ' 
        Me.line1.Marks.Brush.Gradient.StartColor = System.Drawing.Color.Silver
        ' 
        ' line1.Marks.Font
        ' 
        Me.line1.Marks.Font.Name = "Times New Roman"
        Me.line1.Marks.Font.Size = 10
        ' 
        ' line1.Marks.Gradient
        ' 
        Me.line1.Marks.Gradient.StartColor = System.Drawing.Color.Silver
        ' 
        ' line1.Marks.Symbol
        ' 
        ' 
        ' line1.Marks.Symbol.Shadow
        ' 
        Me.line1.Marks.Symbol.Shadow.Height = 1
        Me.line1.Marks.Symbol.Shadow.Visible = True
        Me.line1.Marks.Symbol.Shadow.Width = 1
        Me.line1.Marks.Transparent = True
        ' 
        ' line1.Pointer
        ' 
        ' 
        ' line1.Pointer.Brush
        ' 
        Me.line1.Pointer.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(0, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        Me.line1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.line1.Title = "line1"
        Me.line1.VertAxis = Steema.TeeChart.Styles.VerticalAxis.Custom
        ' 
        ' line1.XValues
        ' 
        Me.line1.XValues.DateTime = True
        Me.line1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' line1.YValues
        ' 
        Me.line1.YValues.DataMember = "Close"
        ' 
        ' ADXFunction
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(440, 317)
        Me.Name = "ADXFunction"
        Me.panel1.ResumeLayout(False)
        CType(Me.UDPeriod, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub 'InitializeComponent 
#End Region


    Private Sub UDPeriod_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles UDPeriod.ValueChanged
        adxFunction1.Period = Convert.ToDouble(UDPeriod.Value)
    End Sub 'UDPeriod_ValueChanged
End Class 'Function_ADX
