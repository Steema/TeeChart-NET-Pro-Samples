
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms


Public Class Bar3DDepth
    Inherits Steema.TeeChart.Samples.BaseForm
    Private bar1 As Steema.TeeChart.Styles.Bar
    Private bar2 As Steema.TeeChart.Styles.Bar
    Private bar3 As Steema.TeeChart.Styles.Bar
    Private bar4 As Steema.TeeChart.Styles.Bar
    Private hScrollBar1 As System.Windows.Forms.HScrollBar
    Private label1 As System.Windows.Forms.Label
    Private label2 As System.Windows.Forms.Label
    Private hScrollBar2 As System.Windows.Forms.HScrollBar
    Private gridBand1 As Steema.TeeChart.Tools.GridBand
    Private components As System.ComponentModel.IContainer = Nothing
    
    Public Sub New() ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Dim i As Integer = 0
        Do While (i < tChart1.Series.Count)
            tChart1.Series(i).FillSampleValues()
            i = i + 1
        Loop

        hScrollBar1.Value = bar1.DepthPercent
        hScrollBar2.Value = bar1.BarWidthPercent


    End Sub


    '/ <summary>
    '/ Clean up any resources being used.
    '/ </summary>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If Disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(Disposing)
    End Sub 'Dispose

#Region "Windows Form Designer generated code"

    '/ <summary>
    '/ Required method for Designer support - do not modify
    '/ the contents of this method with the code editor.
    '/ </summary>
    Private Sub InitializeComponent()
        Me.bar1 = New Steema.TeeChart.Styles.Bar
        Me.bar2 = New Steema.TeeChart.Styles.Bar
        Me.bar3 = New Steema.TeeChart.Styles.Bar
        Me.bar4 = New Steema.TeeChart.Styles.Bar
        Me.hScrollBar1 = New System.Windows.Forms.HScrollBar
        Me.label1 = New System.Windows.Forms.Label
        Me.label2 = New System.Windows.Forms.Label
        Me.hScrollBar2 = New System.Windows.Forms.HScrollBar
        Me.gridBand1 = New Steema.TeeChart.Tools.GridBand
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Text = "The Bar and Horizontal bar series ""DepthPercent"" property controls the" + vbCr + vbLf + "size of b" + "ars in 3D (Z depth) direction." + vbCr + vbLf + vbCr + vbLf + "bar1.DepthPercent = 50    ' % of 3D depth"
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.label2)
        Me.panel1.Controls.Add(Me.hScrollBar2)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Controls.Add(Me.hScrollBar1)
        Me.panel1.Name = "panel1"
        ' 
        ' tChart1
        ' 
        ' 
        ' tChart1.Aspect
        ' 
        Me.tChart1.Aspect.Chart3DPercent = 65
        Me.tChart1.Aspect.ColorPaletteIndex = 6
        Me.tChart1.Aspect.Elevation = 353
        Me.tChart1.Aspect.Orthogonal = False
        Me.tChart1.Aspect.Perspective = 34
        Me.tChart1.Aspect.Rotation = 302
        Me.tChart1.Aspect.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality
        Me.tChart1.Aspect.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        Me.tChart1.Aspect.ThemeIndex = 1
        Me.tChart1.Aspect.Zoom = 79
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
        Me.tChart1.Axes.Bottom.Grid.Visible = False
        ' 
        ' tChart1.Axes.Bottom.Labels
        ' 
        ' 
        ' tChart1.Axes.Bottom.Labels.Font
        ' 
        Me.tChart1.Axes.Bottom.Labels.Font.Bold = True
        Me.tChart1.Axes.Bottom.Labels.Font.Size = 11
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
        ' tChart1.Axes.Depth
        ' 
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
        ' tChart1.Axes.Left
        ' 
        ' 
        ' tChart1.Axes.Left.AxisPen
        ' 
        Me.tChart1.Axes.Left.AxisPen.Width = 1
        ' 
        ' tChart1.Axes.Left.Grid
        ' 
        Me.tChart1.Axes.Left.Grid.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(128, System.Byte), CType(128, System.Byte), CType(128, System.Byte))
        ' 
        ' tChart1.Axes.Left.Labels
        ' 
        ' 
        ' tChart1.Axes.Left.Labels.Font
        ' 
        Me.tChart1.Axes.Left.Labels.Font.Bold = True
        Me.tChart1.Axes.Left.Labels.Font.Size = 11
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
        ' tChart1.Axes.Right
        ' 
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
        ' tChart1.Axes.Top
        ' 
        ' 
        ' tChart1.Axes.Top.Grid
        ' 
        Me.tChart1.Axes.Top.Grid.Color = System.Drawing.Color.Black
        Me.tChart1.Axes.Top.Grid.Style = System.Drawing.Drawing2D.DashStyle.Solid
        Me.tChart1.Axes.Top.Grid.Visible = False
        ' 
        ' tChart1.Axes.Top.Labels
        ' 
        ' 
        ' tChart1.Axes.Top.Labels.Font
        ' 
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
        ' tChart1.Header
        ' 
        ' 
        ' tChart1.Header.Brush
        ' 
        Me.tChart1.Header.Brush.Color = System.Drawing.Color.Black
        ' 
        ' tChart1.Header.Gradient
        ' 
        Me.tChart1.Header.Brush.Gradient.EndColor = System.Drawing.Color.Black
        Me.tChart1.Header.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(128, System.Byte), CType(0, System.Byte), CType(64, System.Byte))
        Me.tChart1.Header.Brush.Gradient.StartColor = System.Drawing.Color.Gray
        Me.tChart1.Header.Brush.Gradient.UseMiddle = True
        Me.tChart1.Header.Brush.Gradient.Visible = True
        ' 
        ' tChart1.Header.Font
        ' 
        ' 
        ' tChart1.Header.Font.Brush
        ' 
        Me.tChart1.Header.Font.Brush.Color = System.Drawing.Color.Black
        Me.tChart1.Header.Font.Size = 10
        ' 
        ' tChart1.Header.Gradient
        ' 
        Me.tChart1.Header.Gradient.EndColor = System.Drawing.Color.Black
        Me.tChart1.Header.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(128, System.Byte), CType(0, System.Byte), CType(64, System.Byte))
        Me.tChart1.Header.Gradient.StartColor = System.Drawing.Color.Gray
        Me.tChart1.Header.Gradient.UseMiddle = True
        Me.tChart1.Header.Gradient.Visible = True
        Me.tChart1.Header.Lines = New String() {"tChart1"}
        ' 
        ' tChart1.Header.Pen
        ' 
        Me.tChart1.Header.Pen.Color = System.Drawing.Color.FromArgb(CType(153, System.Byte), CType(221, System.Byte), CType(251, System.Byte))
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
        ' 
        ' tChart1.Legend
        ' 
        ' 
        ' tChart1.Legend.Brush
        ' 
        ' 
        ' tChart1.Legend.Gradient
        ' 
        Me.tChart1.Legend.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(192, System.Byte), CType(192, System.Byte), CType(192, System.Byte))
        Me.tChart1.Legend.Brush.Gradient.MiddleColor = System.Drawing.Color.Empty
        Me.tChart1.Legend.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.tChart1.Legend.Brush.Gradient.Visible = True
        Me.tChart1.Legend.Brush.Visible = False
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
        Me.tChart1.Legend.Font.Size = 10
        ' 
        ' tChart1.Legend.Gradient
        ' 
        Me.tChart1.Legend.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(192, System.Byte), CType(192, System.Byte), CType(192, System.Byte))
        Me.tChart1.Legend.Gradient.MiddleColor = System.Drawing.Color.Empty
        Me.tChart1.Legend.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.tChart1.Legend.Gradient.Visible = True
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
        ' 
        ' tChart1.Legend.Symbol.Pen
        ' 
        Me.tChart1.Legend.Symbol.Pen.Visible = False
        Me.tChart1.Legend.Symbol.Squared = True
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
        Me.tChart1.Series.Add(Me.bar1)
        Me.tChart1.Series.Add(Me.bar2)
        Me.tChart1.Series.Add(Me.bar3)
        Me.tChart1.Series.Add(Me.bar4)
        Me.tChart1.Tools.Add(Me.gridBand1)
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
        ' 
        ' tChart1.Walls.Back.Pen
        ' 
        Me.tChart1.Walls.Back.Pen.Color = System.Drawing.Color.DarkGray
        Me.tChart1.Walls.Back.Pen.Visible = False
        Me.tChart1.Walls.Back.Size = 9
        Me.tChart1.Walls.Back.Transparent = False
        ' 
        ' tChart1.Walls.Bottom
        ' 
        Me.tChart1.Walls.Bottom.ApplyDark = False
        ' 
        ' tChart1.Walls.Bottom.Brush
        ' 
        Me.tChart1.Walls.Bottom.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(128, System.Byte), CType(128, System.Byte), CType(128, System.Byte))
        ' 
        ' tChart1.Walls.Bottom.Gradient
        ' 
        Me.tChart1.Walls.Bottom.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(252, System.Byte), CType(254, System.Byte), CType(253, System.Byte))
        Me.tChart1.Walls.Bottom.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(147, System.Byte), CType(133, System.Byte), CType(153, System.Byte))
        Me.tChart1.Walls.Bottom.Brush.Gradient.Visible = True
        ' 
        ' tChart1.Walls.Bottom.Gradient
        ' 
        Me.tChart1.Walls.Bottom.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(252, System.Byte), CType(254, System.Byte), CType(253, System.Byte))
        Me.tChart1.Walls.Bottom.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(147, System.Byte), CType(133, System.Byte), CType(153, System.Byte))
        Me.tChart1.Walls.Bottom.Gradient.Visible = True
        ' 
        ' tChart1.Walls.Bottom.Pen
        ' 
        Me.tChart1.Walls.Bottom.Pen.Color = System.Drawing.Color.DarkGray
        Me.tChart1.Walls.Bottom.Pen.Visible = False
        Me.tChart1.Walls.Bottom.Size = 8
        ' 
        ' tChart1.Walls.Left
        ' 
        Me.tChart1.Walls.Left.ApplyDark = False
        ' 
        ' tChart1.Walls.Left.Brush
        ' 
        Me.tChart1.Walls.Left.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(224, System.Byte), CType(224, System.Byte), CType(224, System.Byte))
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
        ' 
        ' tChart1.Walls.Left.Pen
        ' 
        Me.tChart1.Walls.Left.Pen.Color = System.Drawing.Color.DarkGray
        Me.tChart1.Walls.Left.Pen.Visible = False
        Me.tChart1.Walls.Left.Size = 9
        ' 
        ' tChart1.Walls.Right
        ' 
        Me.tChart1.Walls.Right.ApplyDark = False
        ' 
        ' tChart1.Walls.Right.Brush
        ' 
        Me.tChart1.Walls.Right.Brush.Color = System.Drawing.Color.Silver
        ' 
        ' tChart1.Walls.Right.Pen
        ' 
        Me.tChart1.Walls.Right.Pen.Color = System.Drawing.Color.DarkGray
        ' 
        ' bar1
        ' 
        ' 
        ' bar1.Brush
        ' 
        Me.bar1.Brush.Color = System.Drawing.Color.FromArgb(CType(0, System.Byte), CType(165, System.Byte), CType(255, System.Byte))
        ' 
        ' bar1.Marks
        ' 
        ' 
        ' bar1.Marks.Brush
        ' 
        ' 
        ' bar1.Marks.Gradient
        ' 
        Me.bar1.Marks.Brush.Gradient.StartColor = System.Drawing.Color.Silver
        ' 
        ' bar1.Marks.Font
        ' 
        Me.bar1.Marks.Font.Size = 11
        ' 
        ' bar1.Marks.Gradient
        ' 
        Me.bar1.Marks.Gradient.StartColor = System.Drawing.Color.Silver
        ' 
        ' bar1.Marks.Symbol
        ' 
        ' 
        ' bar1.Marks.Symbol.Shadow
        ' 
        Me.bar1.Marks.Symbol.Shadow.Height = 1
        Me.bar1.Marks.Symbol.Shadow.Visible = True
        Me.bar1.Marks.Symbol.Shadow.Width = 1
        Me.bar1.Marks.Transparent = True
        Me.bar1.MultiBar = Steema.TeeChart.Styles.MultiBars.None
        ' 
        ' bar1.Pen
        ' 
        Me.bar1.Pen.Visible = False
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
        ' bar2
        ' 
        ' 
        ' bar2.Brush
        ' 
        Me.bar2.Brush.Color = System.Drawing.Color.FromArgb(CType(206, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        ' 
        ' bar2.Marks
        ' 
        ' 
        ' bar2.Marks.Brush
        ' 
        ' 
        ' bar2.Marks.Gradient
        ' 
        Me.bar2.Marks.Brush.Gradient.StartColor = System.Drawing.Color.Silver
        ' 
        ' bar2.Marks.Font
        ' 
        Me.bar2.Marks.Font.Size = 11
        ' 
        ' bar2.Marks.Gradient
        ' 
        Me.bar2.Marks.Gradient.StartColor = System.Drawing.Color.Silver
        ' 
        ' bar2.Marks.Symbol
        ' 
        ' 
        ' bar2.Marks.Symbol.Shadow
        ' 
        Me.bar2.Marks.Symbol.Shadow.Height = 1
        Me.bar2.Marks.Symbol.Shadow.Visible = True
        Me.bar2.Marks.Symbol.Shadow.Width = 1
        Me.bar2.Marks.Transparent = True
        Me.bar2.MultiBar = Steema.TeeChart.Styles.MultiBars.None
        ' 
        ' bar2.Pen
        ' 
        Me.bar2.Pen.Visible = False
        Me.bar2.Title = "bar2"
        ' 
        ' bar2.XValues
        ' 
        Me.bar2.XValues.DataMember = "X"
        Me.bar2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' bar2.YValues
        ' 
        Me.bar2.YValues.DataMember = "Bar"
        ' 
        ' bar3
        ' 
        ' 
        ' bar3.Brush
        ' 
        Me.bar3.Brush.Color = System.Drawing.Color.FromArgb(CType(0, System.Byte), CType(206, System.Byte), CType(0, System.Byte))
        ' 
        ' bar3.Marks
        ' 
        ' 
        ' bar3.Marks.Brush
        ' 
        ' 
        ' bar3.Marks.Gradient
        ' 
        Me.bar3.Marks.Brush.Gradient.StartColor = System.Drawing.Color.Silver
        ' 
        ' bar3.Marks.Font
        ' 
        Me.bar3.Marks.Font.Size = 11
        ' 
        ' bar3.Marks.Gradient
        ' 
        Me.bar3.Marks.Gradient.StartColor = System.Drawing.Color.Silver
        ' 
        ' bar3.Marks.Symbol
        ' 
        ' 
        ' bar3.Marks.Symbol.Shadow
        ' 
        Me.bar3.Marks.Symbol.Shadow.Height = 1
        Me.bar3.Marks.Symbol.Shadow.Visible = True
        Me.bar3.Marks.Symbol.Shadow.Width = 1
        Me.bar3.Marks.Transparent = True
        Me.bar3.MultiBar = Steema.TeeChart.Styles.MultiBars.None
        ' 
        ' bar3.Pen
        ' 
        Me.bar3.Pen.Visible = False
        Me.bar3.Title = "bar3"
        ' 
        ' bar3.XValues
        ' 
        Me.bar3.XValues.DataMember = "X"
        Me.bar3.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' bar3.YValues
        ' 
        Me.bar3.YValues.DataMember = "Bar"
        ' 
        ' bar4
        ' 
        ' 
        ' bar4.Brush
        ' 
        Me.bar4.Brush.Color = System.Drawing.Color.FromArgb(CType(64, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        ' 
        ' bar4.Marks
        ' 
        ' 
        ' bar4.Marks.Brush
        ' 
        ' 
        ' bar4.Marks.Gradient
        ' 
        Me.bar4.Marks.Brush.Gradient.StartColor = System.Drawing.Color.Silver
        ' 
        ' bar4.Marks.Font
        ' 
        Me.bar4.Marks.Font.Size = 11
        ' 
        ' bar4.Marks.Gradient
        ' 
        Me.bar4.Marks.Gradient.StartColor = System.Drawing.Color.Silver
        ' 
        ' bar4.Marks.Symbol
        ' 
        ' 
        ' bar4.Marks.Symbol.Shadow
        ' 
        Me.bar4.Marks.Symbol.Shadow.Height = 1
        Me.bar4.Marks.Symbol.Shadow.Visible = True
        Me.bar4.Marks.Symbol.Shadow.Width = 1
        Me.bar4.Marks.Transparent = True
        Me.bar4.MultiBar = Steema.TeeChart.Styles.MultiBars.None
        ' 
        ' bar4.Pen
        ' 
        Me.bar4.Pen.Visible = False
        Me.bar4.Title = "bar4"
        ' 
        ' bar4.XValues
        ' 
        Me.bar4.XValues.DataMember = "X"
        Me.bar4.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' bar4.YValues
        ' 
        Me.bar4.YValues.DataMember = "Bar"
        ' 
        ' hScrollBar1
        ' 
        Me.hScrollBar1.Location = New System.Drawing.Point(53, 13)
        Me.hScrollBar1.Name = "hScrollBar1"
        Me.hScrollBar1.Size = New System.Drawing.Size(155, 17)
        Me.hScrollBar1.TabIndex = 0
        AddHandler Me.hScrollBar1.Scroll, AddressOf Me.hScrollBar1_Scroll
        ' 
        ' label1
        ' 
        Me.label1.Location = New System.Drawing.Point(11, 14)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(45, 16)
        Me.label1.TabIndex = 1
        Me.label1.Text = "Depth:"
        ' 
        ' label2
        ' 
        Me.label2.Location = New System.Drawing.Point(224, 16)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(45, 16)
        Me.label2.TabIndex = 3
        Me.label2.Text = "Width:"
        ' 
        ' hScrollBar2
        ' 
        Me.hScrollBar2.Location = New System.Drawing.Point(268, 14)
        Me.hScrollBar2.Name = "hScrollBar2"
        Me.hScrollBar2.Size = New System.Drawing.Size(155, 17)
        Me.hScrollBar2.TabIndex = 2
        AddHandler Me.hScrollBar2.Scroll, AddressOf Me.hScrollBar2_Scroll
        ' 
        ' gridBand1
        ' 
        Me.gridBand1.Axis = Me.tChart1.Axes.Left
        ' 
        ' gridBand1.Band1
        ' 
        Me.gridBand1.Band1.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(192, System.Byte), CType(192, System.Byte), CType(192, System.Byte))
        ' 
        ' gridBand1.Band2
        ' 
        Me.gridBand1.Band2.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        ' 
        ' Bar3DDepth
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(440, 317)
        Me.Name = "Bar3DDepth"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub 'New 
#End Region


    Private Sub hScrollBar1_Scroll(ByVal sender As Object, ByVal e As System.Windows.Forms.ScrollEventArgs)
        Dim i As Integer
        For i = 0 To tChart1.Series.Count - 1
            CType(tChart1.Series(i), Steema.TeeChart.Styles.Bar).DepthPercent = hScrollBar1.Value
        Next i


    End Sub 'hScrollBar1_Scroll

    Private Sub hScrollBar2_Scroll(ByVal sender As Object, ByVal e As System.Windows.Forms.ScrollEventArgs)
        Dim i As Integer
        For i = 0 To tChart1.Series.Count - 1
            CType(tChart1.Series(i),Steema.TeeChart.Styles.Bar).BarWidthPercent = hScrollBar2.Value
        Next i
    End Sub 'hScrollBar2_Scroll
End Class 'Bar3DDepth