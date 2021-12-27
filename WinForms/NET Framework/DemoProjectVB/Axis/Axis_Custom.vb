
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Public Class Axis_Custom
    Inherits Steema.TeeChart.Samples.BaseForm
    Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
    Private WithEvents button1 As System.Windows.Forms.Button
    Private axis1 As Steema.TeeChart.Axis
    Private axis2 As Steema.TeeChart.Axis
    Private axis3 As Steema.TeeChart.Axis
    Private axis4 As Steema.TeeChart.Axis
    Private line1 As Steema.TeeChart.Styles.Line
    Private line2 As Steema.TeeChart.Styles.Line
    Private line3 As Steema.TeeChart.Styles.Line
    Private components As System.ComponentModel.IContainer = Nothing
    
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        'Use of elected Partner Axes to limit GridLine zone
        line1.CustomHorizAxis = axis2
        line2.CustomVertAxis = axis1
        line3.CustomHorizAxis = axis3
        line3.CustomVertAxis = axis4
        tChart1.Axes.Bottom.UsePartnerAxis = True
        tChart1.Axes.Bottom.PartnerAxis = tChart1.Axes.Custom(0)
        tChart1.Axes.Custom(0).UsePartnerAxis = True
        tChart1.Axes.Custom(0).PartnerAxis = tChart1.Axes.Bottom
        tChart1.Axes.Custom(1).UsePartnerAxis = True
        tChart1.Axes.Custom(1).PartnerAxis = tChart1.Axes.Left
        tChart1.Axes.Custom(3).UsePartnerAxis = True
        tChart1.Axes.Custom(3).PartnerAxis = tChart1.Axes.Custom(2)
        tChart1.Axes.Custom(2).UsePartnerAxis = True
        tChart1.Axes.Custom(2).PartnerAxis = tChart1.Axes.Custom(3)
        For Each s As TeeChart.Styles.Series In tChart1.Series
            s.FillSampleValues(20)
        Next s
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Axis_Custom))
        Me.axis1 = New Steema.TeeChart.Axis(Me.components)
        Me.axis2 = New Steema.TeeChart.Axis(Me.components)
        Me.checkBox1 = New System.Windows.Forms.CheckBox
        Me.button1 = New System.Windows.Forms.Button
        Me.axis3 = New Steema.TeeChart.Axis(Me.components)
        Me.axis4 = New Steema.TeeChart.Axis(Me.components)
        Me.line1 = New Steema.TeeChart.Styles.Line
        Me.line2 = New Steema.TeeChart.Styles.Line
        Me.line3 = New Steema.TeeChart.Styles.Line
        Me.panel1.SuspendLayout()
        Me.chartContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'textBox1
        '
        Me.textBox1.BackColor = System.Drawing.Color.AliceBlue
        Me.textBox1.Size = New System.Drawing.Size(472, 62)
        Me.textBox1.Text = resources.GetString("textBox1.Text")
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.SystemColors.Control
        Me.panel1.Controls.Add(Me.button1)
        Me.panel1.Controls.Add(Me.checkBox1)
        Me.panel1.Location = New System.Drawing.Point(0, 62)
        Me.panel1.Size = New System.Drawing.Size(472, 34)
        '
        'tChart1
        '
        '
        '
        '
        Me.tChart1.Aspect.ColorPaletteIndex = 10
        Me.tChart1.Aspect.View3D = False
        Me.tChart1.Aspect.ZOffset = 0
        Me.tChart1.Axes.Bottom.AxisPen.Color = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.tChart1.Axes.Bottom.EndPosition = 50

        Me.tChart1.Axes.Bottom.Grid.Color = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.tChart1.Axes.Bottom.Grid.Style = System.Drawing.Drawing2D.DashStyle.Solid
        Me.tChart1.Axes.Bottom.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tChart1.Axes.Bottom.MinorTicks.Visible = False
        Me.tChart1.Axes.Bottom.Ticks.Color = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer))
        '
        '
        '
        Me.tChart1.Axes.Bottom.TicksInner.Visible = True
        '
        '
        '
        Me.tChart1.Axes.Bottom.Title.Transparent = True
        Me.tChart1.Axes.Custom.Add(Me.axis1)
        Me.tChart1.Axes.Custom.Add(Me.axis2)
        Me.tChart1.Axes.Custom.Add(Me.axis3)
        Me.tChart1.Axes.Custom.Add(Me.axis4)
        '
        '
        '
        '
        '
        '
        Me.tChart1.Axes.Depth.AxisPen.Color = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer))
        '
        '
        '
        Me.tChart1.Axes.Depth.Grid.Color = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.tChart1.Axes.Depth.Grid.Style = System.Drawing.Drawing2D.DashStyle.Solid
        Me.tChart1.Axes.Depth.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tChart1.Axes.Depth.MinorTicks.Visible = False
        Me.tChart1.Axes.Depth.Ticks.Color = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer))
    
        Me.tChart1.Axes.Depth.TicksInner.Visible = True
        '
        '
        '
        Me.tChart1.Axes.Depth.Title.Transparent = True
        '
        '
        '
        '
        '
        '
        Me.tChart1.Axes.DepthTop.AxisPen.Color = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer))
        '
        '
        '
        Me.tChart1.Axes.DepthTop.Grid.Color = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.tChart1.Axes.DepthTop.Grid.Style = System.Drawing.Drawing2D.DashStyle.Solid
        '
        '
        '
        '
        '
        '
        '
        '
        '
        Me.tChart1.Axes.DepthTop.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.tChart1.Axes.DepthTop.MinorTicks.Visible = False
        '
        '
        '
        Me.tChart1.Axes.DepthTop.Ticks.Color = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer))
        '
        '
        '
        Me.tChart1.Axes.DepthTop.TicksInner.Visible = True
        '
        '
        '
        Me.tChart1.Axes.DepthTop.Title.Transparent = True
        '
        '
        '
        '
        '
        '
        Me.tChart1.Axes.Left.AxisPen.Color = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.tChart1.Axes.Left.EndPosition = 50
        '
        '
        '
        Me.tChart1.Axes.Left.Grid.Color = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.tChart1.Axes.Left.Grid.Style = System.Drawing.Drawing2D.DashStyle.Solid
        '
        '
        '
        '
        '
        '
        '
        '
        '
        Me.tChart1.Axes.Left.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tChart1.Axes.Left.LogarithmicBase = 2
        '
        '
        '
        Me.tChart1.Axes.Left.MinorTicks.Visible = False
        '
        '
        '
        Me.tChart1.Axes.Left.Ticks.Color = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer))
        '
        '
        '
        Me.tChart1.Axes.Left.TicksInner.Visible = True
        '
        '
        '
        Me.tChart1.Axes.Left.Title.Transparent = True
        '
        '
        '
        '
        '
        '
        Me.tChart1.Axes.Right.AxisPen.Color = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer))
        '
        '
        '
        Me.tChart1.Axes.Right.Grid.Color = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.tChart1.Axes.Right.Grid.Style = System.Drawing.Drawing2D.DashStyle.Solid
        '
        '
        '
        '
        '
        '
        '
        '
        '
        Me.tChart1.Axes.Right.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.tChart1.Axes.Right.MinorTicks.Visible = False
        '
        '
        '
        Me.tChart1.Axes.Right.Ticks.Color = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer))
        '
        '
        '
        Me.tChart1.Axes.Right.TicksInner.Visible = True
        '
        '
        '
        Me.tChart1.Axes.Right.Title.Transparent = True
        '
        '
        '
        '
        '
        '
        Me.tChart1.Axes.Top.AxisPen.Color = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer))
        '
        '
        '
        Me.tChart1.Axes.Top.Grid.Color = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.tChart1.Axes.Top.Grid.Style = System.Drawing.Drawing2D.DashStyle.Solid
        '
        '
        '
        '
        '
        '
        '
        '
        '
        Me.tChart1.Axes.Top.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.tChart1.Axes.Top.MinorTicks.Visible = False
        '
        '
        '
        Me.tChart1.Axes.Top.Ticks.Color = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer))
        '
        '
        '
        Me.tChart1.Axes.Top.TicksInner.Visible = True
        '
        '
        '
        Me.tChart1.Axes.Top.Title.Transparent = True
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
        '
        '
        '
        Me.tChart1.Header.Font.Bold = True
        '
        '
        '
        Me.tChart1.Header.Font.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.tChart1.Header.Font.Shadow.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.tChart1.Header.Font.Size = 11
        Me.tChart1.Header.Font.SizeFloat = 11.0!
        Me.tChart1.Header.Lines = New String() {"Axis grid zoning"}
        Me.tChart1.Legend.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.tChart1.Legend.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tChart1.Legend.Brush.Gradient.SigmaFocus = 0.0!
        Me.tChart1.Legend.Brush.Gradient.SigmaScale = 0.0!
        Me.tChart1.Legend.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.tChart1.Legend.Brush.Gradient.Visible = True
        Me.tChart1.Legend.Font.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tChart1.Legend.Pen.Visible = False
        Me.tChart1.Location = New System.Drawing.Point(0, 0)
        Me.tChart1.Panel.Bevel.ColorTwo = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tChart1.Panel.Brush.Gradient.SigmaFocus = 0.0!
        Me.tChart1.Panel.Brush.Gradient.SigmaScale = 0.0!
        Me.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.tChart1.Panel.Brush.Gradient.UseMiddle = False
        Me.tChart1.Panel.Shadow.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tChart1.Series.Add(Me.line1)
        Me.tChart1.Series.Add(Me.line2)
        Me.tChart1.Series.Add(Me.line3)
        Me.tChart1.Size = New System.Drawing.Size(472, 221)
        Me.tChart1.Walls.Back.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.tChart1.Walls.Back.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tChart1.Walls.Back.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.tChart1.Walls.Back.Pen.Visible = False
        Me.tChart1.Walls.Bottom.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tChart1.Walls.Bottom.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tChart1.Walls.Bottom.Brush.Gradient.SigmaFocus = 0.0!
        Me.tChart1.Walls.Bottom.Brush.Gradient.SigmaScale = 0.0!
        Me.tChart1.Walls.Bottom.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tChart1.Walls.Bottom.Pen.Visible = False
        Me.tChart1.Walls.Left.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tChart1.Walls.Left.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tChart1.Walls.Left.Brush.Gradient.SigmaFocus = 0.0!
        Me.tChart1.Walls.Left.Brush.Gradient.SigmaScale = 0.0!
        Me.tChart1.Walls.Left.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tChart1.Walls.Left.Pen.Visible = False
        Me.tChart1.Walls.Right.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tChart1.Walls.Right.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tChart1.Walls.Right.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tChart1.Walls.Right.Brush.Gradient.SigmaFocus = 0.0!
        Me.tChart1.Walls.Right.Brush.Gradient.SigmaScale = 0.0!
        Me.tChart1.Walls.Right.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tChart1.Walls.Right.Pen.Visible = False
        '
        'chartContainer
        '
        Me.chartContainer.Location = New System.Drawing.Point(0, 96)
        Me.chartContainer.Size = New System.Drawing.Size(472, 221)
        '
        'axis1
        '
        Me.axis1.AxisPen.Color = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.axis1.Grid.Color = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.axis1.Grid.Style = System.Drawing.Drawing2D.DashStyle.Solid
        Me.axis1.Horizontal = False
        Me.axis1.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.axis1.LogarithmicBase = 2
        Me.axis1.MinorTicks.Visible = False
        Me.axis1.OtherSide = False
        Me.axis1.StartPosition = 62
        Me.axis1.Ticks.Color = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.axis1.TicksInner.Visible = True
        Me.axis1.Title.Transparent = True
        '
        'axis2
        '
        Me.axis2.AxisPen.Color = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.axis2.Grid.Color = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.axis2.Grid.Style = System.Drawing.Drawing2D.DashStyle.Solid
        Me.axis2.Horizontal = True
        Me.axis2.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.axis2.LogarithmicBase = 2
        Me.axis2.MinorTicks.Visible = False
        Me.axis2.OtherSide = False
        Me.axis2.RelativePosition = 50
        Me.axis2.Ticks.Color = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.axis2.TicksInner.Visible = True
        Me.axis2.Title.Transparent = True
        '
        'checkBox1
        '
        Me.checkBox1.Checked = True
        Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox1.Location = New System.Drawing.Point(13, 4)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(123, 23)
        Me.checkBox1.TabIndex = 0
        Me.checkBox1.Text = "&Show custom axes"
        '
        'button1
        '
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.Location = New System.Drawing.Point(184, 5)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(75, 23)
        Me.button1.TabIndex = 1
        Me.button1.Text = "&Edit..."
        '
        'axis3
        '
        Me.axis3.AxisPen.Color = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.axis3.Grid.Color = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.axis3.Grid.Style = System.Drawing.Drawing2D.DashStyle.Solid
        Me.axis3.Horizontal = True
        Me.axis3.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.axis3.LogarithmicBase = 2
        Me.axis3.MinorTicks.Visible = False
        Me.axis3.OtherSide = False
        Me.axis3.StartPosition = 55
        Me.axis3.Ticks.Color = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.axis3.TicksInner.Visible = True
        Me.axis3.Title.Transparent = True
        '
        'axis4
        '
        '
        '
        '
        Me.axis4.AxisPen.Color = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.axis4.Grid.Color = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.axis4.Grid.Style = System.Drawing.Drawing2D.DashStyle.Solid
        Me.axis4.Horizontal = False
        Me.axis4.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.axis4.LogarithmicBase = 2
        Me.axis4.MinorTicks.Visible = False
        Me.axis4.OtherSide = True
        Me.axis4.StartPosition = 62
        Me.axis4.Ticks.Color = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.axis4.TicksInner.Visible = True
        Me.axis4.Title.Transparent = True
        Me.axis4.ZPosition = 0
        '
        'line1
        '
        Me.line1.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.line1.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.line1.ColorEach = False
        Me.line1.LinePen.Color = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.line1.Marks.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.line1.Marks.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.line1.Marks.Brush.Gradient.SigmaFocus = 0.0!
        Me.line1.Marks.Brush.Gradient.SigmaScale = 0.0!
        Me.line1.Marks.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.line1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None
        Me.line1.Marks.Callout.ArrowHeadSize = 8
        Me.line1.Marks.Callout.Brush.Color = System.Drawing.Color.Black
        Me.line1.Marks.Callout.Distance = 0
        Me.line1.Marks.Callout.Draw3D = False
        Me.line1.Marks.Callout.Length = 10
        Me.line1.Marks.Callout.Series = Me.line1
        Me.line1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.line1.Marks.Callout.Visible = False
        Me.line1.Marks.Font.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.line1.Marks.Series = Me.line1
        Me.line1.Marks.Transparent = True
        Me.line1.Pointer.Series = Me.line1
        Me.line1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.line1.Title = "line1"
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
        'line2
        '
        '
        '
        '
        Me.line2.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.line2.Color = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.line2.ColorEach = False
        '
        '
        '
        Me.line2.LinePen.Color = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.line2.Marks.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.line2.Marks.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.line2.Marks.Brush.Gradient.SigmaFocus = 0.0!
        Me.line2.Marks.Brush.Gradient.SigmaScale = 0.0!
        Me.line2.Marks.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.line2.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None
        Me.line2.Marks.Callout.ArrowHeadSize = 8
        Me.line2.Marks.Callout.Brush.Color = System.Drawing.Color.Black
        Me.line2.Marks.Callout.Distance = 0
        Me.line2.Marks.Callout.Draw3D = False
        Me.line2.Marks.Callout.Length = 10
        Me.line2.Marks.Callout.Series = Me.line2
        Me.line2.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.line2.Marks.Callout.Visible = False
        Me.line2.Marks.Font.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.line2.Marks.Series = Me.line2
        Me.line2.Marks.Transparent = True
        Me.line2.Pointer.Series = Me.line2
        Me.line2.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.line2.Title = "line2"
        '
        '
        '
        Me.line2.XValues.DataMember = "X"
        Me.line2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        '
        '
        '
        Me.line2.YValues.DataMember = "Y"
        '
        'line3
        '
        Me.line3.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.line3.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.line3.ColorEach = False
        Me.line3.LinePen.Color = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.line3.Marks.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.line3.Marks.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.line3.Marks.Brush.Gradient.SigmaFocus = 0.0!
        Me.line3.Marks.Brush.Gradient.SigmaScale = 0.0!
        Me.line3.Marks.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
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
        Me.line3.Marks.Callout.Series = Me.line3
        Me.line3.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.line3.Marks.Callout.Visible = False
        '
        '
        '
        '
        '
        '
        Me.line3.Marks.Font.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.line3.Marks.Series = Me.line3
        Me.line3.Marks.Transparent = True
        '
        '
        '
        Me.line3.Pointer.Series = Me.line3
        Me.line3.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.line3.Title = "line3"
        '
        '
        '
        Me.line3.XValues.DataMember = "X"
        Me.line3.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        '
        '
        '
        Me.line3.YValues.DataMember = "Y"
        '
        'Axis_Custom
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(472, 317)
        Me.Name = "Axis_Custom"
        Me.panel1.ResumeLayout(False)
        Me.chartContainer.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub 'InitializeComponent 
#End Region
    Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox1.CheckedChanged
        Dim axes As Steema.TeeChart.CustomAxes = tChart1.Axes.Custom
        Dim t As Integer
        For t = 0 To axes.Count - 1
            axes(t).Visible = checkBox1.Checked
        Next t
    End Sub 'checkBox1_CheckedChanged

    Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
        If tChart1.Axes.Custom.Count > 0 Then
            Dim a As New Editors.AxesEditor(tChart1.Chart, Nothing)
            Editors.EditorUtils.ShowFormModal(a, Me)
        End If
    End Sub 'button1_Click
    Private Sub panel1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub 'Axis_Paint
    Private Sub textBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles textBox1.TextChanged

    End Sub
End Class 'Axis_Custom 
