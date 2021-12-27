
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms


'/ <summary>
'/ Clock Series class.
'/ </summary>

Public Class SeriesType_Clock
    Inherits System.Windows.Forms.Form
    Friend Protected textBox1 As System.Windows.Forms.TextBox
    Protected panel1 As System.Windows.Forms.Panel
    Private panel2 As System.Windows.Forms.Panel
    Private tChart1 As Steema.TeeChart.TChart
    Private tChart2 As Steema.TeeChart.TChart
    Private tChart3 As Steema.TeeChart.TChart
    Private clockSeries1 As Steema.TeeChart.Styles.Clock
    Private clockSeries2 As Steema.TeeChart.Styles.Clock
    Private clockSeries3 As Steema.TeeChart.Styles.Clock
    Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
    Private label1 As System.Windows.Forms.Label
    Private WithEvents numericUpDown1 As System.Windows.Forms.NumericUpDown
    '/ <summary>
    '/ Required designer variable.
    '/ </summary>
    Private components As System.ComponentModel.Container = Nothing
    
    
    Public Sub New()
        '
        ' Required for Windows Form Designer support
        InitializeComponent()
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

#Region "Windows Form Designer generated code"

    '/ <summary>
    '/ Required method for Designer support - do not modify
    '/ the contents of this method with the code editor.
    '/ </summary>
    Private Sub InitializeComponent()
        Me.textBox1 = New System.Windows.Forms.TextBox
        Me.panel1 = New System.Windows.Forms.Panel
        Me.numericUpDown1 = New System.Windows.Forms.NumericUpDown
        Me.label1 = New System.Windows.Forms.Label
        Me.checkBox1 = New System.Windows.Forms.CheckBox
        Me.panel2 = New System.Windows.Forms.Panel
        Me.tChart3 = New Steema.TeeChart.TChart
        Me.clockSeries3 = New Steema.TeeChart.Styles.Clock
        Me.tChart2 = New Steema.TeeChart.TChart
        Me.clockSeries2 = New Steema.TeeChart.Styles.Clock
        Me.tChart1 = New Steema.TeeChart.TChart
        Me.clockSeries1 = New Steema.TeeChart.Styles.Clock
        Me.panel1.SuspendLayout()
        CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'textBox1
        '
        Me.textBox1.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.textBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.textBox1.Location = New System.Drawing.Point(0, 0)
        Me.textBox1.Multiline = True
        Me.textBox1.Name = "textBox1"
        Me.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.textBox1.Size = New System.Drawing.Size(426, 48)
        Me.textBox1.TabIndex = 2
        Me.textBox1.Text = "The Clock series displays live watches. Multiple configuration parameters are ava" & _
        "ilable, like colors, numbering style, backgrounds, gradient, font, etc."
        '
        'panel1
        '
        Me.panel1.Controls.Add(Me.numericUpDown1)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Controls.Add(Me.checkBox1)
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel1.Location = New System.Drawing.Point(0, 48)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(426, 34)
        Me.panel1.TabIndex = 3
        '
        'numericUpDown1
        '
        Me.numericUpDown1.Location = New System.Drawing.Point(224, 8)
        Me.numericUpDown1.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.numericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numericUpDown1.Name = "numericUpDown1"
        Me.numericUpDown1.Size = New System.Drawing.Size(60, 20)
        Me.numericUpDown1.TabIndex = 2
        Me.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numericUpDown1.Value = New Decimal(New Integer() {1000, 0, 0, 0})
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(133, 10)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(87, 16)
        Me.label1.TabIndex = 1
        Me.label1.Text = "&Refresh interval:"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'checkBox1
        '
        Me.checkBox1.Checked = True
        Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox1.Location = New System.Drawing.Point(13, 8)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(114, 21)
        Me.checkBox1.TabIndex = 0
        Me.checkBox1.Text = "&Roman numbers"
        '
        'panel2
        '
        Me.panel2.Controls.Add(Me.tChart3)
        Me.panel2.Controls.Add(Me.tChart2)
        Me.panel2.Controls.Add(Me.tChart1)
        Me.panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel2.Location = New System.Drawing.Point(0, 82)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(426, 190)
        Me.panel2.TabIndex = 4
        '
        'tChart3
        '
        '
        'tChart3.Aspect
        '
        Me.tChart3.Aspect.Elevation = 315
        Me.tChart3.Aspect.ElevationFloat = 315
        Me.tChart3.Aspect.Orthogonal = False
        Me.tChart3.Aspect.Perspective = 0
        Me.tChart3.Aspect.Rotation = 360
        Me.tChart3.Aspect.RotationFloat = 360
        Me.tChart3.Aspect.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
        Me.tChart3.Aspect.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias
        Me.tChart3.Aspect.View3D = False
        '
        'tChart3.Axes
        '
        '
        'tChart3.Axes.Bottom
        '
        Me.tChart3.Axes.Bottom.Automatic = True
        '
        'tChart3.Axes.Bottom.Grid
        '
        Me.tChart3.Axes.Bottom.Grid.ZPosition = 0
        Me.tChart3.Axes.Bottom.Increment = 30
        '
        'tChart3.Axes.Depth
        '
        Me.tChart3.Axes.Depth.Automatic = True
        '
        'tChart3.Axes.Depth.Grid
        '
        Me.tChart3.Axes.Depth.Grid.ZPosition = 0
        '
        'tChart3.Axes.DepthTop
        '
        Me.tChart3.Axes.DepthTop.Automatic = True
        '
        'tChart3.Axes.DepthTop.Grid
        '
        Me.tChart3.Axes.DepthTop.Grid.ZPosition = 0
        '
        'tChart3.Axes.Left
        '
        Me.tChart3.Axes.Left.Automatic = True
        '
        'tChart3.Axes.Left.Grid
        '
        Me.tChart3.Axes.Left.Grid.ZPosition = 0
        '
        'tChart3.Axes.Right
        '
        Me.tChart3.Axes.Right.Automatic = True
        '
        'tChart3.Axes.Right.Grid
        '
        Me.tChart3.Axes.Right.Grid.ZPosition = 0
        '
        'tChart3.Axes.Top
        '
        Me.tChart3.Axes.Top.Automatic = True
        '
        'tChart3.Axes.Top.Grid
        '
        Me.tChart3.Axes.Top.Grid.ZPosition = 0
        Me.tChart3.Axes.Visible = False
        Me.tChart3.Dock = System.Windows.Forms.DockStyle.Fill
        '
        'tChart3.Header
        '
        Me.tChart3.Header.Lines = New String() {"tChart3"}
        Me.tChart3.Header.Visible = False
        '
        'tChart3.Legend
        '
        '
        'tChart3.Legend.Shadow
        '
        Me.tChart3.Legend.Shadow.Visible = True
        '
        'tChart3.Legend.Title
        '
        '
        'tChart3.Legend.Title.Font
        '
        Me.tChart3.Legend.Title.Font.Bold = True
        '
        'tChart3.Legend.Title.Pen
        '
        Me.tChart3.Legend.Title.Pen.Visible = False
        Me.tChart3.Location = New System.Drawing.Point(293, 0)
        Me.tChart3.Name = "tChart3"
        '
        'tChart3.Panel
        '
        '
        'tChart3.Panel.Brush
        '
        '
        'tChart3.Panel.Gradient
        '
        Me.tChart3.Panel.Brush.Gradient.Direction = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.tChart3.Panel.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(254, Byte), CType(255, Byte), CType(255, Byte), CType(255, Byte))
        Me.tChart3.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(254, Byte), CType(0, Byte), CType(0, Byte), CType(64, Byte))
        Me.tChart3.Panel.Brush.Gradient.Visible = True
        '
        'tChart3.Panel.Gradient
        '
        Me.tChart3.Panel.Gradient.Direction = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.tChart3.Panel.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(254, Byte), CType(255, Byte), CType(255, Byte), CType(255, Byte))
        Me.tChart3.Panel.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(254, Byte), CType(0, Byte), CType(0, Byte), CType(64, Byte))
        Me.tChart3.Panel.Gradient.Visible = True
        Me.tChart3.Series.Add(Me.clockSeries3)
        Me.tChart3.Size = New System.Drawing.Size(133, 190)
        Me.tChart3.TabIndex = 2
        '
        'tChart3.Walls
        '
        '
        'tChart3.Walls.Back
        '
        Me.tChart3.Walls.Back.AutoHide = False
        '
        'tChart3.Walls.Bottom
        '
        Me.tChart3.Walls.Bottom.AutoHide = False
        '
        'tChart3.Walls.Left
        '
        Me.tChart3.Walls.Left.AutoHide = False
        '
        'tChart3.Walls.Right
        '
        Me.tChart3.Walls.Right.AutoHide = False
        '
        'clockSeries3
        '
        '
        'clockSeries3.Brush
        '
        Me.clockSeries3.Brush.Color = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(255, Byte))
        Me.clockSeries3.Circled = True
        Me.clockSeries3.CircleLabels = True
        '
        'clockSeries3.Marks
        '
        '
        'clockSeries3.Marks.Callout
        '
        Me.clockSeries3.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None
        Me.clockSeries3.Marks.Callout.ArrowHeadSize = 8
        '
        'clockSeries3.Marks.Callout.Brush
        '
        Me.clockSeries3.Marks.Callout.Brush.Color = System.Drawing.Color.Black
        Me.clockSeries3.Marks.Callout.Distance = 0
        Me.clockSeries3.Marks.Callout.Draw3D = False
        Me.clockSeries3.Marks.Callout.Length = 10
        Me.clockSeries3.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        '
        'clockSeries3.Marks.Shadow
        '
        Me.clockSeries3.Marks.Shadow.Visible = True
        '
        'clockSeries3.Marks.Symbol
        '
        '
        'clockSeries3.Marks.Symbol.Shadow
        '
        Me.clockSeries3.Marks.Symbol.Shadow.Visible = True
        '
        'clockSeries3.Pen
        '
        Me.clockSeries3.Pen.Color = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(255, Byte))
        '
        'clockSeries3.Pointer
        '
        '
        'clockSeries3.Pointer.Brush
        '
        Me.clockSeries3.Pointer.Brush.Color = System.Drawing.Color.FromArgb(CType(254, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
        Me.clockSeries3.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.clockSeries3.RotationAngle = 90
        Me.clockSeries3.ShowInLegend = False
        Me.clockSeries3.Title = "clockSeries3"
        '
        'clockSeries3.XValues
        '
        Me.clockSeries3.XValues.DataMember = "Angle"
        Me.clockSeries3.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        '
        'clockSeries3.YValues
        '
        Me.clockSeries3.YValues.DataMember = "Y"
        '
        'tChart2
        '
        '
        'tChart2.Aspect
        '
        Me.tChart2.Aspect.Elevation = 315
        Me.tChart2.Aspect.ElevationFloat = 315
        Me.tChart2.Aspect.Orthogonal = False
        Me.tChart2.Aspect.Perspective = 0
        Me.tChart2.Aspect.Rotation = 360
        Me.tChart2.Aspect.RotationFloat = 360
        Me.tChart2.Aspect.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
        Me.tChart2.Aspect.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias
        Me.tChart2.Aspect.View3D = False
        '
        'tChart2.Axes
        '
        '
        'tChart2.Axes.Bottom
        '
        Me.tChart2.Axes.Bottom.Automatic = True
        '
        'tChart2.Axes.Bottom.Grid
        '
        Me.tChart2.Axes.Bottom.Grid.ZPosition = 0
        Me.tChart2.Axes.Bottom.Increment = 30
        '
        'tChart2.Axes.Depth
        '
        Me.tChart2.Axes.Depth.Automatic = True
        '
        'tChart2.Axes.Depth.Grid
        '
        Me.tChart2.Axes.Depth.Grid.ZPosition = 0
        '
        'tChart2.Axes.DepthTop
        '
        Me.tChart2.Axes.DepthTop.Automatic = True
        '
        'tChart2.Axes.DepthTop.Grid
        '
        Me.tChart2.Axes.DepthTop.Grid.ZPosition = 0
        '
        'tChart2.Axes.Left
        '
        Me.tChart2.Axes.Left.Automatic = True
        '
        'tChart2.Axes.Left.Grid
        '
        Me.tChart2.Axes.Left.Grid.ZPosition = 0
        '
        'tChart2.Axes.Right
        '
        Me.tChart2.Axes.Right.Automatic = True
        '
        'tChart2.Axes.Right.Grid
        '
        Me.tChart2.Axes.Right.Grid.ZPosition = 0
        '
        'tChart2.Axes.Top
        '
        Me.tChart2.Axes.Top.Automatic = True
        '
        'tChart2.Axes.Top.Grid
        '
        Me.tChart2.Axes.Top.Grid.ZPosition = 0
        Me.tChart2.Axes.Visible = False
        Me.tChart2.Dock = System.Windows.Forms.DockStyle.Left
        '
        'tChart2.Header
        '
        Me.tChart2.Header.Lines = New String() {"tChart2"}
        Me.tChart2.Header.Visible = False
        '
        'tChart2.Legend
        '
        '
        'tChart2.Legend.Shadow
        '
        Me.tChart2.Legend.Shadow.Visible = True
        '
        'tChart2.Legend.Title
        '
        '
        'tChart2.Legend.Title.Font
        '
        Me.tChart2.Legend.Title.Font.Bold = True
        '
        'tChart2.Legend.Title.Pen
        '
        Me.tChart2.Legend.Title.Pen.Visible = False
        Me.tChart2.Location = New System.Drawing.Point(147, 0)
        Me.tChart2.Name = "tChart2"
        '
        'tChart2.Panel
        '
        '
        'tChart2.Panel.Brush
        '
        '
        'tChart2.Panel.Gradient
        '
        Me.tChart2.Panel.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(255, Byte))
        Me.tChart2.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(192, Byte), CType(192, Byte))
        Me.tChart2.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte))
        Me.tChart2.Panel.Brush.Gradient.UseMiddle = True
        Me.tChart2.Panel.Brush.Gradient.Visible = True
        '
        'tChart2.Panel.Gradient
        '
        Me.tChart2.Panel.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(255, Byte))
        Me.tChart2.Panel.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(192, Byte), CType(192, Byte))
        Me.tChart2.Panel.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte))
        Me.tChart2.Panel.Gradient.UseMiddle = True
        Me.tChart2.Panel.Gradient.Visible = True
        Me.tChart2.Series.Add(Me.clockSeries2)
        Me.tChart2.Size = New System.Drawing.Size(146, 190)
        Me.tChart2.TabIndex = 1
        '
        'tChart2.Walls
        '
        '
        'tChart2.Walls.Back
        '
        Me.tChart2.Walls.Back.AutoHide = False
        '
        'tChart2.Walls.Bottom
        '
        Me.tChart2.Walls.Bottom.AutoHide = False
        '
        'tChart2.Walls.Left
        '
        Me.tChart2.Walls.Left.AutoHide = False
        '
        'tChart2.Walls.Right
        '
        Me.tChart2.Walls.Right.AutoHide = False
        '
        'clockSeries2
        '
        '
        'clockSeries2.Brush
        '
        Me.clockSeries2.Brush.Color = System.Drawing.Color.FromArgb(CType(0, Byte), CType(255, Byte), CType(255, Byte))
        Me.clockSeries2.Circled = True
        Me.clockSeries2.CircleLabels = True
        '
        'clockSeries2.Marks
        '
        '
        'clockSeries2.Marks.Callout
        '
        Me.clockSeries2.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None
        Me.clockSeries2.Marks.Callout.ArrowHeadSize = 8
        '
        'clockSeries2.Marks.Callout.Brush
        '
        Me.clockSeries2.Marks.Callout.Brush.Color = System.Drawing.Color.Black
        Me.clockSeries2.Marks.Callout.Distance = 0
        Me.clockSeries2.Marks.Callout.Draw3D = False
        Me.clockSeries2.Marks.Callout.Length = 10
        Me.clockSeries2.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        '
        'clockSeries2.Marks.Shadow
        '
        Me.clockSeries2.Marks.Shadow.Visible = True
        '
        'clockSeries2.Marks.Symbol
        '
        '
        'clockSeries2.Marks.Symbol.Shadow
        '
        Me.clockSeries2.Marks.Symbol.Shadow.Visible = True
        '
        'clockSeries2.Pen
        '
        Me.clockSeries2.Pen.Color = System.Drawing.Color.FromArgb(CType(0, Byte), CType(255, Byte), CType(255, Byte))
        '
        'clockSeries2.Pointer
        '
        '
        'clockSeries2.Pointer.Brush
        '
        Me.clockSeries2.Pointer.Brush.Color = System.Drawing.Color.FromArgb(CType(254, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
        Me.clockSeries2.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.clockSeries2.RotationAngle = 90
        Me.clockSeries2.ShowInLegend = False
        Me.clockSeries2.Title = "clockSeries2"
        '
        'clockSeries2.XValues
        '
        Me.clockSeries2.XValues.DataMember = "Angle"
        Me.clockSeries2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        '
        'clockSeries2.YValues
        '
        Me.clockSeries2.YValues.DataMember = "Y"
        '
        'tChart1
        '
        '
        'tChart1.Aspect
        '
        Me.tChart1.Aspect.Elevation = 315
        Me.tChart1.Aspect.ElevationFloat = 315
        Me.tChart1.Aspect.Orthogonal = False
        Me.tChart1.Aspect.Perspective = 0
        Me.tChart1.Aspect.Rotation = 360
        Me.tChart1.Aspect.RotationFloat = 360
        Me.tChart1.Aspect.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
        Me.tChart1.Aspect.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias
        Me.tChart1.Aspect.View3D = False
        '
        'tChart1.Axes
        '
        '
        'tChart1.Axes.Bottom
        '
        Me.tChart1.Axes.Bottom.Automatic = True
        '
        'tChart1.Axes.Bottom.Grid
        '
        Me.tChart1.Axes.Bottom.Grid.ZPosition = 0
        Me.tChart1.Axes.Bottom.Increment = 30
        '
        'tChart1.Axes.Depth
        '
        Me.tChart1.Axes.Depth.Automatic = True
        '
        'tChart1.Axes.Depth.Grid
        '
        Me.tChart1.Axes.Depth.Grid.ZPosition = 0
        '
        'tChart1.Axes.DepthTop
        '
        Me.tChart1.Axes.DepthTop.Automatic = True
        '
        'tChart1.Axes.DepthTop.Grid
        '
        Me.tChart1.Axes.DepthTop.Grid.ZPosition = 0
        '
        'tChart1.Axes.Left
        '
        Me.tChart1.Axes.Left.Automatic = True
        '
        'tChart1.Axes.Left.Grid
        '
        Me.tChart1.Axes.Left.Grid.ZPosition = 0
        '
        'tChart1.Axes.Right
        '
        Me.tChart1.Axes.Right.Automatic = True
        '
        'tChart1.Axes.Right.Grid
        '
        Me.tChart1.Axes.Right.Grid.ZPosition = 0
        '
        'tChart1.Axes.Top
        '
        Me.tChart1.Axes.Top.Automatic = True
        '
        'tChart1.Axes.Top.Grid
        '
        Me.tChart1.Axes.Top.Grid.ZPosition = 0
        Me.tChart1.Axes.Visible = False
        Me.tChart1.Dock = System.Windows.Forms.DockStyle.Left
        '
        'tChart1.Header
        '
        Me.tChart1.Header.Lines = New String() {"tChart1"}
        Me.tChart1.Header.Visible = False
        '
        'tChart1.Legend
        '
        '
        'tChart1.Legend.Shadow
        '
        Me.tChart1.Legend.Shadow.Visible = True
        '
        'tChart1.Legend.Title
        '
        '
        'tChart1.Legend.Title.Font
        '
        Me.tChart1.Legend.Title.Font.Bold = True
        '
        'tChart1.Legend.Title.Pen
        '
        Me.tChart1.Legend.Title.Pen.Visible = False
        Me.tChart1.Location = New System.Drawing.Point(0, 0)
        Me.tChart1.Name = "tChart1"
        '
        'tChart1.Panel
        '
        '
        'tChart1.Panel.Brush
        '
        '
        'tChart1.Panel.Gradient
        '
        Me.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(254, Byte), CType(255, Byte), CType(255, Byte), CType(255, Byte))
        Me.tChart1.Panel.Brush.Gradient.GammaCorrection = True
        Me.tChart1.Panel.Brush.Gradient.Sigma = True
        Me.tChart1.Panel.Brush.Gradient.SigmaFocus = 0.496!
        Me.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(254, Byte), CType(255, Byte), CType(198, Byte), CType(0, Byte))
        Me.tChart1.Panel.Brush.Gradient.Visible = True
        '
        'tChart1.Panel.Gradient
        '
        Me.tChart1.Panel.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(254, Byte), CType(255, Byte), CType(255, Byte), CType(255, Byte))
        Me.tChart1.Panel.Gradient.GammaCorrection = True
        Me.tChart1.Panel.Gradient.Sigma = True
        Me.tChart1.Panel.Gradient.SigmaFocus = 0.496!
        Me.tChart1.Panel.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(254, Byte), CType(255, Byte), CType(198, Byte), CType(0, Byte))
        Me.tChart1.Panel.Gradient.Visible = True
        Me.tChart1.Series.Add(Me.clockSeries1)
        Me.tChart1.Size = New System.Drawing.Size(147, 190)
        Me.tChart1.TabIndex = 0
        '
        'tChart1.Walls
        '
        '
        'tChart1.Walls.Back
        '
        Me.tChart1.Walls.Back.AutoHide = False
        '
        'tChart1.Walls.Bottom
        '
        Me.tChart1.Walls.Bottom.AutoHide = False
        '
        'tChart1.Walls.Left
        '
        Me.tChart1.Walls.Left.AutoHide = False
        '
        'tChart1.Walls.Right
        '
        Me.tChart1.Walls.Right.AutoHide = False
        '
        'clockSeries1
        '
        '
        'clockSeries1.Brush
        '
        Me.clockSeries1.Brush.Color = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(0, Byte))
        Me.clockSeries1.Circled = True
        Me.clockSeries1.CircleLabels = True
        Me.clockSeries1.CircleLabelsInside = True
        '
        'clockSeries1.CirclePen
        '
        Me.clockSeries1.CirclePen.Color = System.Drawing.Color.FromArgb(CType(254, Byte), CType(149, Byte), CType(134, Byte), CType(0, Byte))
        '
        'clockSeries1.Marks
        '
        '
        'clockSeries1.Marks.Callout
        '
        Me.clockSeries1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None
        Me.clockSeries1.Marks.Callout.ArrowHeadSize = 8
        '
        'clockSeries1.Marks.Callout.Brush
        '
        Me.clockSeries1.Marks.Callout.Brush.Color = System.Drawing.Color.Black
        Me.clockSeries1.Marks.Callout.Distance = 0
        Me.clockSeries1.Marks.Callout.Draw3D = False
        Me.clockSeries1.Marks.Callout.Length = 10
        Me.clockSeries1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        '
        'clockSeries1.Marks.Shadow
        '
        Me.clockSeries1.Marks.Shadow.Visible = True
        '
        'clockSeries1.Marks.Symbol
        '
        '
        'clockSeries1.Marks.Symbol.Shadow
        '
        Me.clockSeries1.Marks.Symbol.Shadow.Visible = True
        '
        'clockSeries1.Pen
        '
        Me.clockSeries1.Pen.Color = System.Drawing.Color.FromArgb(CType(254, Byte), CType(222, Byte), CType(204, Byte), CType(0, Byte))
        Me.clockSeries1.Pen.Visible = False
        '
        'clockSeries1.Pointer
        '
        '
        'clockSeries1.Pointer.Brush
        '
        Me.clockSeries1.Pointer.Brush.Color = System.Drawing.Color.FromArgb(CType(254, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
        Me.clockSeries1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.clockSeries1.RotationAngle = 90
        Me.clockSeries1.ShowInLegend = False
        Me.clockSeries1.Title = "clockSeries1"
        '
        'clockSeries1.XValues
        '
        Me.clockSeries1.XValues.DataMember = "Angle"
        Me.clockSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        '
        'clockSeries1.YValues
        '
        Me.clockSeries1.YValues.DataMember = "Y"
        '
        'SeriesType_Clock
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(426, 272)
        Me.Controls.Add(Me.panel2)
        Me.Controls.Add(Me.panel1)
        Me.Controls.Add(Me.textBox1)
        Me.Name = "SeriesType_Clock"
        Me.Text = "Clock"
        Me.panel1.ResumeLayout(False)
        CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub 'InitializeComponent 
#End Region


    Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox1.CheckedChanged
        If Me.checkBox1.Checked Then
            Me.clockSeries1.Style = Steema.TeeChart.Styles.ClockStyles.Roman
            Me.clockSeries2.Style = Steema.TeeChart.Styles.ClockStyles.Roman
            Me.clockSeries3.Style = Steema.TeeChart.Styles.ClockStyles.Roman
        Else
            Me.clockSeries1.Style = Steema.TeeChart.Styles.ClockStyles.Decimal
            Me.clockSeries2.Style = Steema.TeeChart.Styles.ClockStyles.Decimal
            Me.clockSeries3.Style = Steema.TeeChart.Styles.ClockStyles.Decimal
        End If
    End Sub 'checkBox1_CheckedChanged


    Private Sub numericUpDown1_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles numericUpDown1.TextChanged, numericUpDown1.ValueChanged
        Me.clockSeries1.Timer.Interval = CInt(Me.numericUpDown1.Value)
        Me.clockSeries2.Timer.Interval = CInt(Me.numericUpDown1.Value)
        Me.clockSeries3.Timer.Interval = CInt(Me.numericUpDown1.Value)
    End Sub 'numericUpDown1_ValueChanged
End Class 'SeriesType_Clock