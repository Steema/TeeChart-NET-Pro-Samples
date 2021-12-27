
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing

Imports System.Windows.Forms



Public Class Map_Transparency
    Inherits Samples.BaseForm

    Private label1 As Label
    Private tbTransparency As TrackBar
    Private map1 As Steema.TeeChart.Styles.Map

    '/ <summary>
    '/ Required designer variable.
    '/ </summary>
    Private components As System.ComponentModel.IContainer = Nothing


    Public Sub New() ' This call is required by the Windows Form Designer.
        InitializeComponent()
        map1.FillSampleValues()
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Map_Transparency))
        Me.map1 = New Steema.TeeChart.Styles.Map
        Me.tbTransparency = New System.Windows.Forms.TrackBar
        Me.label1 = New System.Windows.Forms.Label
        Me.panel1.SuspendLayout()
        Me.chartContainer.SuspendLayout()
        CType(Me.tbTransparency, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Text = "Map series now has a new transparency property."
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Controls.Add(Me.tbTransparency)
        ' 
        ' tChart1
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Aspect.ColorPaletteIndex = -1
        Me.tChart1.Aspect.ElevationFloat = 345
        Me.tChart1.Aspect.RotationFloat = 345
        Me.tChart1.Aspect.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
        Me.tChart1.Aspect.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias
        Me.tChart1.Aspect.View3D = False
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Bottom.Automatic = True
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Bottom.AxisPen.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Bottom.Grid.Color = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.tChart1.Axes.Bottom.Grid.Style = System.Drawing.Drawing2D.DashStyle.Dash
        Me.tChart1.Axes.Bottom.Grid.ZPosition = 0
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Bottom.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tChart1.Axes.Bottom.Labels.Font.Unit = System.Drawing.GraphicsUnit.World
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Bottom.MinorGrid.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Bottom.Ticks.Color = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Bottom.TicksInner.Color = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Bottom.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tChart1.Axes.Bottom.Title.Font.Unit = System.Drawing.GraphicsUnit.World
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Depth.Automatic = True
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Depth.AxisPen.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Depth.Grid.Color = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.tChart1.Axes.Depth.Grid.Style = System.Drawing.Drawing2D.DashStyle.Dash
        Me.tChart1.Axes.Depth.Grid.ZPosition = 0
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Depth.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tChart1.Axes.Depth.Labels.Font.Unit = System.Drawing.GraphicsUnit.World
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Depth.MinorGrid.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Depth.Ticks.Color = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Depth.TicksInner.Color = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Depth.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tChart1.Axes.Depth.Title.Font.Unit = System.Drawing.GraphicsUnit.World
        ' 
        ' 
        ' 
        Me.tChart1.Axes.DepthTop.Automatic = True
        ' 
        ' 
        ' 
        Me.tChart1.Axes.DepthTop.AxisPen.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        ' 
        ' 
        ' 
        Me.tChart1.Axes.DepthTop.Grid.Color = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.tChart1.Axes.DepthTop.Grid.Style = System.Drawing.Drawing2D.DashStyle.Dash
        Me.tChart1.Axes.DepthTop.Grid.ZPosition = 0
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.DepthTop.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tChart1.Axes.DepthTop.Labels.Font.Unit = System.Drawing.GraphicsUnit.World
        ' 
        ' 
        ' 
        Me.tChart1.Axes.DepthTop.MinorGrid.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        ' 
        ' 
        ' 
        Me.tChart1.Axes.DepthTop.Ticks.Color = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        ' 
        ' 
        ' 
        Me.tChart1.Axes.DepthTop.TicksInner.Color = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.DepthTop.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tChart1.Axes.DepthTop.Title.Font.Unit = System.Drawing.GraphicsUnit.World
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Left.Automatic = True
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Left.AxisPen.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Left.Grid.Color = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.tChart1.Axes.Left.Grid.Style = System.Drawing.Drawing2D.DashStyle.Dash
        Me.tChart1.Axes.Left.Grid.ZPosition = 0
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Left.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tChart1.Axes.Left.Labels.Font.Unit = System.Drawing.GraphicsUnit.World
        Me.tChart1.Axes.Left.Labels.Style = Steema.TeeChart.AxisLabelStyle.Value
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Left.MinorGrid.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Left.Ticks.Color = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Left.TicksInner.Color = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Left.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tChart1.Axes.Left.Title.Font.Unit = System.Drawing.GraphicsUnit.World
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Right.Automatic = True
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Right.AxisPen.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Right.Grid.Color = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.tChart1.Axes.Right.Grid.Style = System.Drawing.Drawing2D.DashStyle.Dash
        Me.tChart1.Axes.Right.Grid.ZPosition = 0
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Right.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tChart1.Axes.Right.Labels.Font.Unit = System.Drawing.GraphicsUnit.World
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Right.MinorGrid.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Right.Ticks.Color = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Right.TicksInner.Color = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Right.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tChart1.Axes.Right.Title.Font.Unit = System.Drawing.GraphicsUnit.World
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Top.Automatic = True
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Top.AxisPen.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Top.Grid.Color = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.tChart1.Axes.Top.Grid.Style = System.Drawing.Drawing2D.DashStyle.Dash
        Me.tChart1.Axes.Top.Grid.ZPosition = 0
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Top.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tChart1.Axes.Top.Labels.Font.Unit = System.Drawing.GraphicsUnit.World
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Top.MinorGrid.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Top.Ticks.Color = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Top.TicksInner.Color = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Top.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tChart1.Axes.Top.Title.Font.Unit = System.Drawing.GraphicsUnit.World
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Footer.Font.Unit = System.Drawing.GraphicsUnit.World
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Header.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        ' 
        ' 
        ' 
        Me.tChart1.Header.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tChart1.Header.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tChart1.Header.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tChart1.Header.Gradient.UseMiddle = True
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Header.Font.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tChart1.Header.Font.Unit = System.Drawing.GraphicsUnit.World
        Me.tChart1.Header.Lines = New String() {"TeeChart"}
        ' 
        ' 
        ' 
        Me.tChart1.Header.Pen.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Header.Shadow.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Legend.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tChart1.Legend.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tChart1.Legend.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tChart1.Legend.Gradient.UseMiddle = True
        ' 
        ' 
        ' 
        Me.tChart1.Legend.DividingLines.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Legend.Font.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tChart1.Legend.Font.Unit = System.Drawing.GraphicsUnit.World
        Me.tChart1.Legend.MaxNumRows = 8
        ' 
        ' 
        ' 
        Me.tChart1.Legend.Pen.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Legend.Shadow.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tChart1.Legend.Shadow.Visible = True
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Legend.Title.Font.Bold = True
        Me.tChart1.Legend.Title.Font.Unit = System.Drawing.GraphicsUnit.World
        ' 
        ' 
        ' 
        Me.tChart1.Legend.Title.Pen.Visible = False
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
        Me.tChart1.Panel.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.tChart1.Panel.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tChart1.Panel.Gradient.Sigma = True
        Me.tChart1.Panel.Gradient.SigmaFocus = 1.0!
        Me.tChart1.Panel.Gradient.SigmaScale = 0.8!
        Me.tChart1.Panel.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tChart1.Panel.Gradient.UseMiddle = True
        Me.tChart1.Panel.Gradient.Visible = True
        ' 
        ' 
        ' 
        Me.tChart1.Panel.Pen.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tChart1.Series.Add(Me.map1)
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.SubFooter.Font.Unit = System.Drawing.GraphicsUnit.World
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.SubHeader.Font.Unit = System.Drawing.GraphicsUnit.World
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Walls.Back.AutoHide = False
        ' 
        ' 
        ' 
        Me.tChart1.Walls.Back.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        ' 
        ' 
        ' 
        Me.tChart1.Walls.Back.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tChart1.Walls.Back.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tChart1.Walls.Back.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tChart1.Walls.Back.Gradient.UseMiddle = True
        Me.tChart1.Walls.Back.Brush.Visible = False
        ' 
        ' 
        ' 
        Me.tChart1.Walls.Back.Pen.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        ' 
        ' 
        ' 
        Me.tChart1.Walls.Bottom.AutoHide = False
        ' 
        ' 
        ' 
        Me.tChart1.Walls.Bottom.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        ' 
        ' 
        ' 
        Me.tChart1.Walls.Bottom.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tChart1.Walls.Bottom.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tChart1.Walls.Bottom.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tChart1.Walls.Bottom.Gradient.UseMiddle = True
        ' 
        ' 
        ' 
        Me.tChart1.Walls.Bottom.Pen.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        ' 
        ' 
        ' 
        Me.tChart1.Walls.Left.AutoHide = False
        ' 
        ' 
        ' 
        Me.tChart1.Walls.Left.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer))
        ' 
        ' 
        ' 
        Me.tChart1.Walls.Left.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tChart1.Walls.Left.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tChart1.Walls.Left.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tChart1.Walls.Left.Gradient.UseMiddle = True
        ' 
        ' 
        ' 
        Me.tChart1.Walls.Left.Pen.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        ' 
        ' 
        ' 
        Me.tChart1.Walls.Right.AutoHide = False
        ' 
        ' 
        ' 
        Me.tChart1.Walls.Right.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer))
        ' 
        ' 
        ' 
        Me.tChart1.Walls.Right.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tChart1.Walls.Right.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tChart1.Walls.Right.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tChart1.Walls.Right.Gradient.UseMiddle = True
        ' 
        ' 
        ' 
        Me.tChart1.Walls.Right.Pen.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        ' 
        ' map1
        ' 
        ' 
        ' 
        ' 
        Me.map1.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(10, Byte), Integer))
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.map1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None
        Me.map1.Marks.Callout.ArrowHeadSize = 8
        Me.map1.Marks.Callout.Distance = 0
        Me.map1.Marks.Callout.Draw3D = False
        Me.map1.Marks.Callout.Length = 10
        Me.map1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        ' 
        ' 
        ' 
        Me.map1.Marks.Font.Unit = System.Drawing.GraphicsUnit.World
        ' 
        ' 
        ' 
        Me.map1.Marks.Shadow.Visible = True
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.map1.Marks.Symbol.Shadow.Visible = True
        Me.map1.PaletteMin = 0
        Me.map1.PaletteStep = 0
        Me.map1.Title = "map1"
        Me.map1.UseColorRange = False
        Me.map1.UsePalette = True
        ' 
        ' tbTransparency
        ' 
        Me.tbTransparency.Location = New System.Drawing.Point(119, 0)
        Me.tbTransparency.Maximum = 100
        Me.tbTransparency.Name = "tbTransparency"
        Me.tbTransparency.Size = New System.Drawing.Size(191, 45)
        Me.tbTransparency.TabIndex = 0
        AddHandler tbTransparency.Scroll, AddressOf Me.tbTransparency_Scroll
        ' 
        ' label1
        ' 
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(38, 14)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(75, 13)
        Me.label1.TabIndex = 1
        Me.label1.Text = "Transparency:"
        ' 
        ' Map_Transparency
        ' 
#If (VS2005) Then
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
#End If
        Me.ClientSize = New System.Drawing.Size(440, 317)
        Me.Name = "Map_Transparency"
        Me.Text = "Map_Transparency"
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.chartContainer.ResumeLayout(False)
        CType(Me.tbTransparency, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub tbTransparency_Scroll(ByVal sender As Object, ByVal e As EventArgs)
        map1.Transparency = tbTransparency.Value
        map1.Invalidate()
    End Sub

End Class

