
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms


Public Class Exponential_Trend
    Inherits Steema.TeeChart.Samples.BaseForm
    Private fastLine1 As Steema.TeeChart.Styles.FastLine
    Private fastLine2 As Steema.TeeChart.Styles.FastLine
    Private fastLine3 As Steema.TeeChart.Styles.FastLine
    Private expTrendFunction1 As Steema.TeeChart.Functions.ExpTrendFunction
    Private trendFunction1 As Steema.TeeChart.Functions.TrendFunction
    Private gridBand1 As Steema.TeeChart.Tools.GridBand
    Private components As System.ComponentModel.IContainer = Nothing
    
    Public Sub New() ' This call is required by the Windows Form Designer.
        InitializeComponent()
        fastLine1.FillSampleValues(100)

        ' TODO: Add any initialization after the InitializeComponent call
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
        Me.fastLine1 = New Steema.TeeChart.Styles.FastLine
        Me.fastLine2 = New Steema.TeeChart.Styles.FastLine
        Me.expTrendFunction1 = New Steema.TeeChart.Functions.ExpTrendFunction
        Me.fastLine3 = New Steema.TeeChart.Styles.FastLine
        Me.trendFunction1 = New Steema.TeeChart.Functions.TrendFunction
        Me.gridBand1 = New Steema.TeeChart.Tools.GridBand
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Text = "The Exponential Trend function is similar to Trend, except" + vbCr + vbLf + "the calculation fits " + "values using their exponential (e) weights." + vbCr + vbLf + "Compare it to the normal Trend clic" + "king the legend green series."
        ' 
        ' panel1
        ' 
        Me.panel1.Name = "panel1"
        ' 
        ' tChart1
        ' 
        ' 
        ' tChart1.Aspect
        ' 
        Me.tChart1.Aspect.ColorPaletteIndex = 2
        Me.tChart1.Aspect.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality
        Me.tChart1.Aspect.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        Me.tChart1.Aspect.ThemeIndex = 4
        Me.tChart1.Aspect.View3D = False
        ' 
        ' tChart1.Axes
        ' 
        ' 
        ' tChart1.Axes.Bottom
        ' 
        ' 
        ' tChart1.Axes.Bottom.Grid
        ' 
        Me.tChart1.Axes.Bottom.Grid.Color = System.Drawing.Color.FromArgb(CType(196, System.Byte), CType(196, System.Byte), CType(196, System.Byte))
        Me.tChart1.Axes.Bottom.Grid.Style = System.Drawing.Drawing2D.DashStyle.Solid
        Me.tChart1.Axes.Bottom.Grid.Visible = False
        ' 
        ' tChart1.Axes.Bottom.Labels
        ' 
        ' 
        ' tChart1.Axes.Bottom.Labels.Font
        ' 
        Me.tChart1.Axes.Bottom.Labels.Font.Name = "Lucida Console"
        Me.tChart1.Axes.Bottom.Labels.Font.Size = 10
        ' 
        ' tChart1.Axes.Bottom.MinorTicks
        ' 
        Me.tChart1.Axes.Bottom.MinorTicks.Color = System.Drawing.Color.Black
        Me.tChart1.Axes.Bottom.MinorTicks.Length = -3
        ' 
        ' tChart1.Axes.Bottom.Ticks
        ' 
        Me.tChart1.Axes.Bottom.Ticks.Color = System.Drawing.Color.Black
        Me.tChart1.Axes.Bottom.Ticks.Length = 0
        ' 
        ' tChart1.Axes.Bottom.TicksInner
        ' 
        Me.tChart1.Axes.Bottom.TicksInner.Color = System.Drawing.Color.Black
        Me.tChart1.Axes.Bottom.TicksInner.Length = 6
        ' 
        ' tChart1.Axes.Depth
        ' 
        ' 
        ' tChart1.Axes.Depth.Grid
        ' 
        Me.tChart1.Axes.Depth.Grid.Color = System.Drawing.Color.FromArgb(CType(196, System.Byte), CType(196, System.Byte), CType(196, System.Byte))
        Me.tChart1.Axes.Depth.Grid.Style = System.Drawing.Drawing2D.DashStyle.Solid
        ' 
        ' tChart1.Axes.Depth.Labels
        ' 
        ' 
        ' tChart1.Axes.Depth.Labels.Font
        ' 
        Me.tChart1.Axes.Depth.Labels.Font.Name = "Lucida Console"
        Me.tChart1.Axes.Depth.Labels.Font.Size = 10
        ' 
        ' tChart1.Axes.Depth.MinorTicks
        ' 
        Me.tChart1.Axes.Depth.MinorTicks.Color = System.Drawing.Color.Black
        Me.tChart1.Axes.Depth.MinorTicks.Length = -3
        ' 
        ' tChart1.Axes.Depth.Ticks
        ' 
        Me.tChart1.Axes.Depth.Ticks.Color = System.Drawing.Color.Black
        Me.tChart1.Axes.Depth.Ticks.Length = 0
        ' 
        ' tChart1.Axes.Depth.TicksInner
        ' 
        Me.tChart1.Axes.Depth.TicksInner.Color = System.Drawing.Color.Black
        Me.tChart1.Axes.Depth.TicksInner.Length = 6
        ' 
        ' tChart1.Axes.Left
        ' 
        ' 
        ' tChart1.Axes.Left.Grid
        ' 
        Me.tChart1.Axes.Left.Grid.Color = System.Drawing.Color.FromArgb(CType(196, System.Byte), CType(196, System.Byte), CType(196, System.Byte))
        Me.tChart1.Axes.Left.Grid.Style = System.Drawing.Drawing2D.DashStyle.Solid
        ' 
        ' tChart1.Axes.Left.Labels
        ' 
        ' 
        ' tChart1.Axes.Left.Labels.Font
        ' 
        Me.tChart1.Axes.Left.Labels.Font.Name = "Lucida Console"
        Me.tChart1.Axes.Left.Labels.Font.Size = 10
        ' 
        ' tChart1.Axes.Left.MinorTicks
        ' 
        Me.tChart1.Axes.Left.MinorTicks.Color = System.Drawing.Color.Black
        Me.tChart1.Axes.Left.MinorTicks.Length = -3
        ' 
        ' tChart1.Axes.Left.Ticks
        ' 
        Me.tChart1.Axes.Left.Ticks.Color = System.Drawing.Color.Black
        Me.tChart1.Axes.Left.Ticks.Length = 0
        ' 
        ' tChart1.Axes.Left.TicksInner
        ' 
        Me.tChart1.Axes.Left.TicksInner.Color = System.Drawing.Color.Black
        Me.tChart1.Axes.Left.TicksInner.Length = 6
        ' 
        ' tChart1.Axes.Right
        ' 
        ' 
        ' tChart1.Axes.Right.Grid
        ' 
        Me.tChart1.Axes.Right.Grid.Color = System.Drawing.Color.FromArgb(CType(196, System.Byte), CType(196, System.Byte), CType(196, System.Byte))
        Me.tChart1.Axes.Right.Grid.Style = System.Drawing.Drawing2D.DashStyle.Solid
        ' 
        ' tChart1.Axes.Right.Labels
        ' 
        ' 
        ' tChart1.Axes.Right.Labels.Font
        ' 
        Me.tChart1.Axes.Right.Labels.Font.Name = "Lucida Console"
        Me.tChart1.Axes.Right.Labels.Font.Size = 10
        ' 
        ' tChart1.Axes.Right.MinorTicks
        ' 
        Me.tChart1.Axes.Right.MinorTicks.Color = System.Drawing.Color.Black
        Me.tChart1.Axes.Right.MinorTicks.Length = -3
        ' 
        ' tChart1.Axes.Right.Ticks
        ' 
        Me.tChart1.Axes.Right.Ticks.Color = System.Drawing.Color.Black
        Me.tChart1.Axes.Right.Ticks.Length = 0
        ' 
        ' tChart1.Axes.Right.TicksInner
        ' 
        Me.tChart1.Axes.Right.TicksInner.Color = System.Drawing.Color.Black
        Me.tChart1.Axes.Right.TicksInner.Length = 6
        ' 
        ' tChart1.Axes.Top
        ' 
        ' 
        ' tChart1.Axes.Top.Grid
        ' 
        Me.tChart1.Axes.Top.Grid.Color = System.Drawing.Color.FromArgb(CType(196, System.Byte), CType(196, System.Byte), CType(196, System.Byte))
        Me.tChart1.Axes.Top.Grid.Style = System.Drawing.Drawing2D.DashStyle.Solid
        Me.tChart1.Axes.Top.Grid.Visible = False
        ' 
        ' tChart1.Axes.Top.Labels
        ' 
        ' 
        ' tChart1.Axes.Top.Labels.Font
        ' 
        Me.tChart1.Axes.Top.Labels.Font.Name = "Lucida Console"
        Me.tChart1.Axes.Top.Labels.Font.Size = 10
        ' 
        ' tChart1.Axes.Top.MinorTicks
        ' 
        Me.tChart1.Axes.Top.MinorTicks.Color = System.Drawing.Color.Black
        Me.tChart1.Axes.Top.MinorTicks.Length = -3
        ' 
        ' tChart1.Axes.Top.Ticks
        ' 
        Me.tChart1.Axes.Top.Ticks.Color = System.Drawing.Color.Black
        Me.tChart1.Axes.Top.Ticks.Length = 0
        ' 
        ' tChart1.Axes.Top.TicksInner
        ' 
        Me.tChart1.Axes.Top.TicksInner.Color = System.Drawing.Color.Black
        Me.tChart1.Axes.Top.TicksInner.Length = 6
        ' 
        ' tChart1.Header
        ' 
        ' 
        ' tChart1.Header.Font
        ' 
        Me.tChart1.Header.Font.Bold = True
        ' 
        ' tChart1.Header.Font.Brush
        ' 
        Me.tChart1.Header.Font.Brush.Color = System.Drawing.Color.Black
        Me.tChart1.Header.Font.Name = "Lucida Console"
        Me.tChart1.Header.Font.Size = 10
        Me.tChart1.Header.Lines = New String() {"TeeChart"}
        Me.tChart1.Header.Visible = False
        ' 
        ' tChart1.Legend
        ' 
        Me.tChart1.Legend.CheckBoxes = True
        ' 
        ' tChart1.Legend.Font
        ' 
        Me.tChart1.Legend.Font.Name = "Lucida Console"
        Me.tChart1.Legend.Font.Size = 9
        ' 
        ' tChart1.Legend.Shadow
        ' 
        ' 
        ' tChart1.Legend.Shadow.Brush
        ' 
        Me.tChart1.Legend.Shadow.Brush.Color = System.Drawing.Color.DarkGray
        Me.tChart1.Legend.Transparent = True
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
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(192, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
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
        Me.tChart1.Panel.Shadow.Height = 0
        Me.tChart1.Panel.Shadow.Width = 0
        Me.tChart1.Series.Add(Me.fastLine1)
        Me.tChart1.Series.Add(Me.fastLine2)
        Me.tChart1.Series.Add(Me.fastLine3)
        Me.tChart1.Tools.Add(Me.gridBand1)
        ' 
        ' tChart1.Walls
        ' 
        ' 
        ' tChart1.Walls.Back
        ' 
        ' 
        ' tChart1.Walls.Back.Brush
        ' 
        Me.tChart1.Walls.Back.Brush.Color = System.Drawing.Color.White
        Me.tChart1.Walls.Back.Transparent = False
        ' 
        ' tChart1.Walls.Left
        ' 
        ' 
        ' tChart1.Walls.Left.Brush
        ' 
        Me.tChart1.Walls.Left.Brush.Color = System.Drawing.Color.White
        ' 
        ' tChart1.Walls.Right
        ' 
        ' 
        ' tChart1.Walls.Right.Brush
        ' 
        Me.tChart1.Walls.Right.Brush.Color = System.Drawing.Color.White
        ' 
        ' fastLine1
        ' 
        ' 
        ' fastLine1.LinePen
        ' 
        Me.fastLine1.LinePen.Color = System.Drawing.Color.FromArgb(CType(161, System.Byte), CType(165, System.Byte), CType(93, System.Byte))
        ' 
        ' fastLine1.Marks
        ' 
        ' 
        ' fastLine1.Marks.Brush
        ' 
        ' 
        ' fastLine1.Marks.Gradient
        ' 
        Me.fastLine1.Marks.Brush.Gradient.StartColor = System.Drawing.Color.Silver
        Me.fastLine1.Marks.Brush.Gradient.Visible = True
        ' 
        ' fastLine1.Marks.Font
        ' 
        Me.fastLine1.Marks.Font.Name = "Lucida Console"
        ' 
        ' fastLine1.Marks.Gradient
        ' 
        Me.fastLine1.Marks.Gradient.StartColor = System.Drawing.Color.Silver
        Me.fastLine1.Marks.Gradient.Visible = True
        ' 
        ' fastLine1.Marks.Symbol
        ' 
        ' 
        ' fastLine1.Marks.Symbol.Shadow
        ' 
        Me.fastLine1.Marks.Symbol.Shadow.Height = 1
        Me.fastLine1.Marks.Symbol.Shadow.Visible = True
        Me.fastLine1.Marks.Symbol.Shadow.Width = 1
        Me.fastLine1.Title = "Source"
        ' 
        ' fastLine1.XValues
        ' 
        Me.fastLine1.XValues.DataMember = "X"
        Me.fastLine1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' fastLine1.YValues
        ' 
        Me.fastLine1.YValues.DataMember = "Y"
        ' 
        ' fastLine2
        ' 
        Me.fastLine2.DataSource = Me.fastLine1
        Me.fastLine2.Function = Me.expTrendFunction1
        ' 
        ' fastLine2.LinePen
        ' 
        Me.fastLine2.LinePen.Color = System.Drawing.Color.FromArgb(CType(49, System.Byte), CType(83, System.Byte), CType(196, System.Byte))
        ' 
        ' fastLine2.Marks
        ' 
        ' 
        ' fastLine2.Marks.Brush
        ' 
        ' 
        ' fastLine2.Marks.Gradient
        ' 
        Me.fastLine2.Marks.Brush.Gradient.StartColor = System.Drawing.Color.Silver
        Me.fastLine2.Marks.Brush.Gradient.Visible = True
        ' 
        ' fastLine2.Marks.Font
        ' 
        Me.fastLine2.Marks.Font.Name = "Lucida Console"
        ' 
        ' fastLine2.Marks.Gradient
        ' 
        Me.fastLine2.Marks.Gradient.StartColor = System.Drawing.Color.Silver
        Me.fastLine2.Marks.Gradient.Visible = True
        ' 
        ' fastLine2.Marks.Symbol
        ' 
        ' 
        ' fastLine2.Marks.Symbol.Shadow
        ' 
        Me.fastLine2.Marks.Symbol.Shadow.Height = 1
        Me.fastLine2.Marks.Symbol.Shadow.Visible = True
        Me.fastLine2.Marks.Symbol.Shadow.Width = 1
        Me.fastLine2.Title = "Exp. Trend"
        ' 
        ' fastLine2.XValues
        ' 
        Me.fastLine2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' expTrendFunction1
        ' 
        Me.expTrendFunction1.TrendStyle = Steema.TeeChart.Functions.TrendStyles.Exponential
        ' 
        ' fastLine3
        ' 
        Me.fastLine3.DataSource = Me.fastLine1
        Me.fastLine3.Function = Me.trendFunction1
        ' 
        ' fastLine3.LinePen
        ' 
        Me.fastLine3.LinePen.Color = System.Drawing.Color.FromArgb(CType(9, System.Byte), CType(150, System.Byte), CType(231, System.Byte))
        ' 
        ' fastLine3.Marks
        ' 
        ' 
        ' fastLine3.Marks.Brush
        ' 
        ' 
        ' fastLine3.Marks.Gradient
        ' 
        Me.fastLine3.Marks.Brush.Gradient.StartColor = System.Drawing.Color.Silver
        Me.fastLine3.Marks.Brush.Gradient.Visible = True
        ' 
        ' fastLine3.Marks.Font
        ' 
        Me.fastLine3.Marks.Font.Name = "Lucida Console"
        ' 
        ' fastLine3.Marks.Gradient
        ' 
        Me.fastLine3.Marks.Gradient.StartColor = System.Drawing.Color.Silver
        Me.fastLine3.Marks.Gradient.Visible = True
        ' 
        ' fastLine3.Marks.Symbol
        ' 
        ' 
        ' fastLine3.Marks.Symbol.Shadow
        ' 
        Me.fastLine3.Marks.Symbol.Shadow.Height = 1
        Me.fastLine3.Marks.Symbol.Shadow.Visible = True
        Me.fastLine3.Marks.Symbol.Shadow.Width = 1
        Me.fastLine3.Title = "Trend"
        Me.fastLine3.Visible = False
        ' 
        ' fastLine3.XValues
        ' 
        Me.fastLine3.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' gridBand1
        ' 
        Me.gridBand1.Axis = Me.tChart1.Axes.Left
        ' 
        ' gridBand1.Band1
        ' 
        Me.gridBand1.Band1.Color = System.Drawing.Color.FromArgb(CType(127, System.Byte), CType(224, System.Byte), CType(224, System.Byte), CType(224, System.Byte))
        ' 
        ' gridBand1.Band2
        ' 
        Me.gridBand1.Band2.Color = System.Drawing.Color.FromArgb(CType(127, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        ' 
        ' ExpTrend
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(440, 317)
        Me.Name = "ExpTrend"
        Me.ResumeLayout(False)
    End Sub 'New 
#End Region
End Class 'Exponential_Trend