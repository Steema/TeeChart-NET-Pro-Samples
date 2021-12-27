
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms


Public Class Series_HorizHisto
    Inherits Steema.TeeChart.Samples.BaseForm
    Private button1 As System.Windows.Forms.Button
    Private horizHistogram1 As Steema.TeeChart.Styles.HorizHistogram
    Private gridBand1 As Steema.TeeChart.Tools.GridBand
    Private components As System.ComponentModel.IContainer = Nothing
    
    Public Sub New() ' This call is required by the Windows Form Designer.
        InitializeComponent()

        horizHistogram1.FillSampleValues()

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
        Me.button1 = New System.Windows.Forms.Button
        Me.horizHistogram1 = New Steema.TeeChart.Styles.HorizHistogram
        Me.gridBand1 = New Steema.TeeChart.Tools.GridBand
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Text = "Horizontal Histogram series displays values like an horizontal area " + vbCr + vbLf + "series in """ + "stairs"" mode,  but centering the points at Y coordinates."
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.button1)
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
        Me.tChart1.Header.Font.Name = "Times New Roman"
        Me.tChart1.Header.Font.Size = 12
        ' 
        ' tChart1.Header.Gradient
        ' 
        Me.tChart1.Header.Gradient.EndColor = System.Drawing.Color.Black
        Me.tChart1.Header.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(128, System.Byte), CType(0, System.Byte), CType(64, System.Byte))
        Me.tChart1.Header.Gradient.StartColor = System.Drawing.Color.Gray
        Me.tChart1.Header.Gradient.UseMiddle = True
        Me.tChart1.Header.Gradient.Visible = True
        Me.tChart1.Header.Lines = New String() {"Horizontal Histogram"}
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
        Me.tChart1.Series.Add(Me.horizHistogram1)
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
        ' button1
        ' 
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.Location = New System.Drawing.Point(16, 8)
        Me.button1.Name = "button1"
        Me.button1.TabIndex = 0
        Me.button1.Text = "Edit..."
        AddHandler Me.button1.Click, AddressOf Me.button1_Click
        ' 
        ' horizHistogram1
        ' 
        ' 
        ' horizHistogram1.Brush
        ' 
        Me.horizHistogram1.Brush.Color = System.Drawing.Color.FromArgb(CType(255, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        Me.horizHistogram1.Brush.Solid = False
        ' 
        ' horizHistogram1.LinePen
        ' 
        Me.horizHistogram1.LinePen.Color = System.Drawing.Color.Black
        ' 
        ' horizHistogram1.LinesPen
        ' 
        Me.horizHistogram1.LinesPen.Visible = False
        ' 
        ' horizHistogram1.Marks
        ' 
        ' 
        ' horizHistogram1.Marks.Symbol
        ' 
        ' 
        ' horizHistogram1.Marks.Symbol.Shadow
        ' 
        Me.horizHistogram1.Marks.Symbol.Shadow.Height = 1
        Me.horizHistogram1.Marks.Symbol.Shadow.Visible = True
        Me.horizHistogram1.Marks.Symbol.Shadow.Width = 1
        Me.horizHistogram1.Title = "horizHistogram1"
        ' 
        ' horizHistogram1.XValues
        ' 
        Me.horizHistogram1.XValues.DataMember = "X"
        ' 
        ' horizHistogram1.YValues
        ' 
        Me.horizHistogram1.YValues.DataMember = "Y"
        Me.horizHistogram1.YValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' gridBand1
        ' 
        Me.gridBand1.Axis = Me.tChart1.Axes.Bottom
        ' 
        ' gridBand1.Band1
        ' 
        Me.gridBand1.Band1.Color = System.Drawing.Color.FromArgb(CType(127, System.Byte), CType(224, System.Byte), CType(224, System.Byte), CType(224, System.Byte))
        ' 
        ' gridBand1.Band2
        ' 
        Me.gridBand1.Band2.Color = System.Drawing.Color.FromArgb(CType(127, System.Byte), CType(128, System.Byte), CType(128, System.Byte), CType(128, System.Byte))
        ' 
        ' HorizHisto
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(440, 317)
        Me.Name = "HorizHisto"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub 'New 
#End Region


    Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        TeeChart.Editors.SeriesEditor.ShowEditor(horizHistogram1)
    End Sub 'button1_Click
End Class 'Series_HorizHisto