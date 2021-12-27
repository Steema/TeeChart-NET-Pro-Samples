
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports Steema.TeeChart
Imports Steema.TeeChart.Tools


Public Class ToolSurfaceNearest
    Inherits Steema.TeeChart.Samples.BaseForm
    Private button1 As System.Windows.Forms.Button
    Private surface1 As Steema.TeeChart.Styles.Surface
    Private surfaceNearestTool1 As Steema.TeeChart.Tools.SurfaceNearestTool
    Private label1 As System.Windows.Forms.Label
    Private components As System.ComponentModel.IContainer = Nothing
    
    Public Sub New() ' This call is required by the Windows Form Designer.
        InitializeComponent()

        AddSurfacePoints()
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
        Me.surface1 = New Steema.TeeChart.Styles.Surface
        Me.surfaceNearestTool1 = New Steema.TeeChart.Tools.SurfaceNearestTool
        Me.label1 = New System.Windows.Forms.Label
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Text = "The SurfaceNearest tool can be used to highlight a surface cell" + vbCr + vbLf + "when moving the " + "mouse over a surface series."
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Controls.Add(Me.button1)
        Me.panel1.Name = "panel1"
        ' 
        ' tChart1
        ' 
        ' 
        ' tChart1.Aspect
        ' 
        Me.tChart1.Aspect.Chart3DPercent = 40
        Me.tChart1.Aspect.ColorPaletteIndex = -1
        Me.tChart1.Aspect.Elevation = 324
        Me.tChart1.Aspect.Orthogonal = False
        Me.tChart1.Aspect.Rotation = 353
        Me.tChart1.Aspect.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality
        Me.tChart1.Aspect.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        Me.tChart1.Aspect.ThemeIndex = 1
        Me.tChart1.Aspect.Zoom = 87
        ' 
        ' tChart1.Axes
        ' 
        ' 
        ' tChart1.Axes.Bottom
        ' 
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
        Me.tChart1.Header.Font.Size = 10
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
        ' 
        ' tChart1.Legend
        ' 
        ' 
        ' tChart1.Legend.Brush
        ' 
        ' 
        ' tChart1.Legend.Gradient
        ' 
        Me.tChart1.Legend.Brush.Gradient.Direction = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.tChart1.Legend.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(206, System.Byte), CType(219, System.Byte), CType(255, System.Byte))
        Me.tChart1.Legend.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(224, System.Byte), CType(230, System.Byte), CType(233, System.Byte))
        Me.tChart1.Legend.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(255, System.Byte), CType(243, System.Byte), CType(234, System.Byte))
        Me.tChart1.Legend.Brush.Gradient.UseMiddle = True
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
        Me.tChart1.Legend.Gradient.Direction = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.tChart1.Legend.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(206, System.Byte), CType(219, System.Byte), CType(255, System.Byte))
        Me.tChart1.Legend.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(224, System.Byte), CType(230, System.Byte), CType(233, System.Byte))
        Me.tChart1.Legend.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(255, System.Byte), CType(243, System.Byte), CType(234, System.Byte))
        Me.tChart1.Legend.Gradient.UseMiddle = True
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
        Me.tChart1.Series.Add(Me.surface1)
        Me.tChart1.Tools.Add(Me.surfaceNearestTool1)
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
        Me.tChart1.Walls.Back.Transparent = False
        Me.tChart1.Walls.Back.Visible = False
        ' 
        ' tChart1.Walls.Bottom
        ' 
        Me.tChart1.Walls.Bottom.ApplyDark = False
        ' 
        ' tChart1.Walls.Bottom.Brush
        ' 
        Me.tChart1.Walls.Bottom.Brush.Color = System.Drawing.Color.DarkGray
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
        ' 
        ' tChart1.Walls.Bottom.Pen
        ' 
        Me.tChart1.Walls.Bottom.Pen.Color = System.Drawing.Color.DarkGray
        ' 
        ' tChart1.Walls.Left
        ' 
        Me.tChart1.Walls.Left.ApplyDark = False
        ' 
        ' tChart1.Walls.Left.Brush
        ' 
        Me.tChart1.Walls.Left.Brush.Color = System.Drawing.Color.Silver
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
        Me.tChart1.Walls.Left.Visible = False
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
        ' button1
        ' 
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.Location = New System.Drawing.Point(16, 8)
        Me.button1.Name = "button1"
        Me.button1.TabIndex = 0
        Me.button1.Text = "Edit Tool..."
        AddHandler Me.button1.Click, AddressOf Me.button1_Click
        ' 
        ' surface1
        ' 
        ' 
        ' surface1.Brush
        ' 
        Me.surface1.Brush.Color = System.Drawing.Color.FromArgb(CType(255, System.Byte), CType(153, System.Byte), CType(153, System.Byte))
        ' 
        ' surface1.Marks
        ' 
        ' 
        ' surface1.Marks.Brush
        ' 
        ' 
        ' surface1.Marks.Gradient
        ' 
        Me.surface1.Marks.Brush.Gradient.StartColor = System.Drawing.Color.Silver
        ' 
        ' surface1.Marks.Font
        ' 
        Me.surface1.Marks.Font.Size = 10
        ' 
        ' surface1.Marks.Gradient
        ' 
        Me.surface1.Marks.Gradient.StartColor = System.Drawing.Color.Silver
        ' 
        ' surface1.Marks.Symbol
        ' 
        ' 
        ' surface1.Marks.Symbol.Shadow
        ' 
        Me.surface1.Marks.Symbol.Shadow.Height = 1
        Me.surface1.Marks.Symbol.Shadow.Visible = True
        Me.surface1.Marks.Symbol.Shadow.Width = 1
        Me.surface1.Marks.Transparent = True
        Me.surface1.PaletteMin = 0
        Me.surface1.PaletteStep = 0
        Me.surface1.Title = "surface1"
        Me.surface1.UseColorRange = False
        Me.surface1.UsePalette = True
        ' 
        ' surface1.XValues
        ' 
        Me.surface1.XValues.DataMember = "X"
        ' 
        ' surface1.YValues
        ' 
        Me.surface1.YValues.DataMember = "Y"
        ' 
        ' surface1.ZValues
        ' 
        Me.surface1.ZValues.DataMember = "Z"
        ' 
        ' surfaceNearestTool1
        ' 
        Me.surfaceNearestTool1.CellColor = System.Drawing.Color.Red
        Me.surfaceNearestTool1.ColumnColor = System.Drawing.Color.Green
        Me.surfaceNearestTool1.RowColor = System.Drawing.Color.Blue
        Me.surfaceNearestTool1.Series = Me.surface1
        AddHandler Me.surfaceNearestTool1.Select, AddressOf Me.surfaceNearestTool1_Select
        ' 
        ' label1
        ' 
        Me.label1.Location = New System.Drawing.Point(109, 13)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(147, 16)
        Me.label1.TabIndex = 1
        ' 
        ' ToolSurfaceNearest
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(440, 317)
        Me.Name = "ToolSurfaceNearest"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub 'New 
#End Region


    Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        TeeChart.Editors.Tools.ToolsEditor.ShowEditor(surfaceNearestTool1)
    End Sub 'button1_Click

    Private Sub AddSurfacePoints()
        Const NumX As Integer = 50
        Const NumZ As Integer = 30

        Dim x As Integer
        For x = 0 To NumX
            Dim z As Integer
            For z = 0 To NumZ
                surface1.Add(x, Math.Cos((x)) * Math.Cos((z)) + (x - NumX / 2) * (z - NumZ / 2) + 13 * Math.Exp(-(Math.Pow(x - NumX / 2, 2) + Math.Pow(z - NumZ / 2, 2))) + 6 * Math.Exp(-(Math.Pow(x - NumX / 3, 2) + Math.Pow(z - 3 * (NumZ / 5), 2))) - 1, z)
            Next z
        Next x '
       
    End Sub 'AddSurfacePoints

    Private Sub surfaceNearestTool1_Select(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim tmp As Integer
        Dim tmpRow, tmpColumn As Double

        tmp = CType(sender, SurfaceNearestTool).SelectedCell
        If (tmp = -1) Then
            label1.Text = ""
        Else
            CType(sender, SurfaceNearestTool).GetRowCol(tmpRow, tmpColumn)
            label1.Text = ("Row: "+ (tmpRow.ToString + (" Column: " + tmpColumn.ToString)))
        End If
    End Sub 'surfaceNearestTool1_Select
End Class 'ToolSurfaceNearest