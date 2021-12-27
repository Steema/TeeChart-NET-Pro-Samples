
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing

Imports System.Windows.Forms



Public Class Legend_SymbolShadow
    Inherits Samples.BaseForm

    Private WithEvents button1 As Button
    Private surface1 As Steema.TeeChart.Styles.Surface

    '/ <summary>
    '/ Required designer variable.
    '/ </summary>
    Private components As System.ComponentModel.IContainer = Nothing


    Public Sub New() ' This call is required by the Windows Form Designer.
        InitializeComponent()
        surface1.FillSampleValues()
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Legend_SymbolShadow))
        Me.button1 = New System.Windows.Forms.Button
        Me.surface1 = New Steema.TeeChart.Styles.Surface
        Me.panel1.SuspendLayout()
        Me.chartContainer.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Text = "New to Legend Symbols, Legend Symbol Shadows."
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.button1)
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
        Me.tChart1.Aspect.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
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
        Me.tChart1.Legend.Symbol.Pen.Visible = True
        Me.tChart1.Legend.Shadow.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tChart1.Legend.Shadow.Visible = True
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Legend.Symbol.Shadow.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tChart1.Legend.Symbol.Shadow.Height = 3
        Me.tChart1.Legend.Symbol.Shadow.Visible = True
        Me.tChart1.Legend.Symbol.Shadow.Width = 3
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
        Me.tChart1.Series.Add(Me.surface1)
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
        ' button1
        ' 
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.Location = New System.Drawing.Point(12, 6)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(188, 23)
        Me.button1.TabIndex = 0
        Me.button1.Text = "Legend Symbol Shadow Editor..."
#If (VS2005) Then
Me.button1.UseVisualStyleBackColor = true
#End If
        AddHandler button1.Click, AddressOf Me.button1_Click
        ' 
        ' surface1
        ' 
        ' 
        ' 
        ' 
        Me.surface1.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.surface1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None
        Me.surface1.Marks.Callout.ArrowHeadSize = 8
        Me.surface1.Marks.Callout.Distance = 0
        Me.surface1.Marks.Callout.Draw3D = False
        Me.surface1.Marks.Callout.Length = 10
        Me.surface1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        ' 
        ' 
        ' 
        Me.surface1.Marks.Font.Unit = System.Drawing.GraphicsUnit.World
        ' 
        ' 
        ' 
        Me.surface1.Marks.Shadow.Visible = True
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.surface1.Marks.Symbol.Shadow.Visible = True
        Me.surface1.PaletteMin = 0
        Me.surface1.PaletteStep = 0
        Me.surface1.PaletteStyle = Steema.TeeChart.Styles.PaletteStyles.Strong
        Me.surface1.Title = "surface1"
        Me.surface1.UseColorRange = False
        Me.surface1.UsePalette = True
        ' 
        ' 
        ' 
        Me.surface1.XValues.DataMember = "X"
        ' 
        ' 
        ' 
        Me.surface1.YValues.DataMember = "Y"
        ' 
        ' 
        ' 
        Me.surface1.ZValues.DataMember = "Z"
        ' 
        ' Legend_SymbolShadow
        ' 
#If (VS2005) Then
Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
#End If
        Me.ClientSize = New System.Drawing.Size(440, 317)
        Me.Name = "Legend_SymbolShadow"
        Me.Text = "Legend_SymbolShadow"
        Me.panel1.ResumeLayout(False)
        Me.chartContainer.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region


    Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
        Dim ediShad As Steema.TeeChart.Editors.ShadowEditor = New Steema.TeeChart.Editors.ShadowEditor(tChart1.Legend.Symbol.Shadow)
        Steema.TeeChart.Editors.EditorUtils.ShowFormModal(ediShad)
    End Sub

    
End Class

