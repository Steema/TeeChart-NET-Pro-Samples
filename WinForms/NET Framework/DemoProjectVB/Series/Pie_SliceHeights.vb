
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms


Public Class PieSliceHeights
    Inherits Steema.TeeChart.Samples.BaseForm
    Private donut1 As Steema.TeeChart.Styles.Donut
    Private checkBox1 As System.Windows.Forms.CheckBox
    Private hScrollBar1 As System.Windows.Forms.HScrollBar
    Private label1 As System.Windows.Forms.Label
    Private components As System.ComponentModel.IContainer = Nothing
    
    Public Sub New() ' This call is required by the Windows Form Designer.
        InitializeComponent()

        donut1.FillSampleValues()
        checkBox1.Checked = True
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
        Me.donut1 = New Steema.TeeChart.Styles.Donut
        Me.checkBox1 = New System.Windows.Forms.CheckBox
        Me.hScrollBar1 = New System.Windows.Forms.HScrollBar
        Me.label1 = New System.Windows.Forms.Label
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Text = "Each pie or donut series slice can be displayed using a different height, " + vbCr + vbLf + "as pe" + "rcentage of Chart1.Chart3DPercent.  Default is 100 %." + vbCr + vbLf + vbCr + vbLf + "donut1.SliceHeight[3] =" + " 50   ' slice index 3, using a 50% of 3D height."
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Controls.Add(Me.hScrollBar1)
        Me.panel1.Controls.Add(Me.checkBox1)
        Me.panel1.Name = "panel1"
        ' 
        ' tChart1
        ' 
        ' 
        ' tChart1.Aspect
        ' 
        Me.tChart1.Aspect.Chart3DPercent = 55
        Me.tChart1.Aspect.ColorPaletteIndex = 3
        Me.tChart1.Aspect.Elevation = 315
        Me.tChart1.Aspect.Orthogonal = False
        Me.tChart1.Aspect.Perspective = 0
        Me.tChart1.Aspect.Rotation = 360
        Me.tChart1.Aspect.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality
        Me.tChart1.Aspect.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        Me.tChart1.Aspect.ThemeIndex = 4
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
        Me.tChart1.Axes.Bottom.Labels.Font.Bold = True
        Me.tChart1.Axes.Bottom.Labels.Font.Name = "Lucida Console"
        Me.tChart1.Axes.Bottom.Labels.Font.Size = 10
        ' 
        ' tChart1.Axes.Bottom.MinorGrid
        ' 
        Me.tChart1.Axes.Bottom.MinorGrid.Color = System.Drawing.Color.FromArgb(CType(229, System.Byte), CType(229, System.Byte), CType(229, System.Byte))
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
        Me.tChart1.Axes.Left.Labels.Font.Bold = True
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
        Me.tChart1.Header.Font.Bold = True
        ' 
        ' tChart1.Header.Font.Brush
        ' 
        Me.tChart1.Header.Font.Brush.Color = System.Drawing.Color.Black
        Me.tChart1.Header.Font.Name = "Lucida Console"
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
        Me.tChart1.Legend.Font.Name = "Lucida Console"
        Me.tChart1.Legend.Font.Size = 9
        ' 
        ' tChart1.Legend.Gradient
        ' 
        Me.tChart1.Legend.Gradient.EndColor = System.Drawing.Color.Yellow
        Me.tChart1.Legend.Gradient.MiddleColor = System.Drawing.Color.Empty
        Me.tChart1.Legend.Gradient.StartColor = System.Drawing.Color.White
        ' 
        ' tChart1.Legend.Shadow
        ' 
        ' 
        ' tChart1.Legend.Shadow.Brush
        ' 
        Me.tChart1.Legend.Shadow.Brush.Color = System.Drawing.Color.DarkGray
        ' 
        ' tChart1.Legend.Symbol
        ' 
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
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(196, System.Byte), CType(196, System.Byte), CType(196, System.Byte))
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
        Me.tChart1.Series.Add(Me.donut1)
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
        Me.tChart1.Walls.Back.Transparent = False
        ' 
        ' tChart1.Walls.Bottom
        ' 
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
        ' 
        ' tChart1.Walls.Left
        ' 
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
        ' 
        ' tChart1.Walls.Right
        ' 
        ' 
        ' tChart1.Walls.Right.Brush
        ' 
        Me.tChart1.Walls.Right.Brush.Color = System.Drawing.Color.White
        ' 
        ' donut1
        ' 
        ' 
        ' donut1.Brush
        ' 
        Me.donut1.Brush.Color = System.Drawing.Color.Red
        Me.donut1.LabelMember = "Labels"
        ' 
        ' donut1.Marks
        ' 
        ' 
        ' donut1.Marks.Arrow
        ' 
        Me.donut1.Marks.Arrow.Color = System.Drawing.Color.White
        ' 
        ' donut1.Marks.Brush
        ' 
        ' 
        ' donut1.Marks.Gradient
        ' 
        Me.donut1.Marks.Brush.Gradient.StartColor = System.Drawing.Color.Silver
        Me.donut1.Marks.Brush.Gradient.Visible = True
        ' 
        ' donut1.Marks.Font
        ' 
        Me.donut1.Marks.Font.Name = "Lucida Console"
        ' 
        ' donut1.Marks.Gradient
        ' 
        Me.donut1.Marks.Gradient.StartColor = System.Drawing.Color.Silver
        Me.donut1.Marks.Gradient.Visible = True
        ' 
        ' donut1.Marks.Symbol
        ' 
        ' 
        ' donut1.Marks.Symbol.Shadow
        ' 
        Me.donut1.Marks.Symbol.Shadow.Height = 1
        Me.donut1.Marks.Symbol.Shadow.Visible = True
        Me.donut1.Marks.Symbol.Shadow.Width = 1
        ' 
        ' donut1.Pen
        ' 
        Me.donut1.Pen.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(128, System.Byte), CType(128, System.Byte), CType(128, System.Byte))
        ' 
        ' donut1.Shadow
        ' 
        Me.donut1.Shadow.Height = 20
        Me.donut1.Shadow.Width = 20
        Me.donut1.Title = "donut1"
        ' 
        ' donut1.XValues
        ' 
        Me.donut1.XValues.DataMember = "Angle"
        Me.donut1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' donut1.YValues
        ' 
        Me.donut1.YValues.DataMember = "Pie"
        ' 
        ' checkBox1
        ' 
        Me.checkBox1.Location = New System.Drawing.Point(8, 8)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(120, 24)
        Me.checkBox1.TabIndex = 0
        Me.checkBox1.Text = "Vary Slice Heights"
        AddHandler Me.checkBox1.CheckedChanged, AddressOf Me.checkBox1_CheckedChanged
        ' 
        ' hScrollBar1
        ' 
        Me.hScrollBar1.Location = New System.Drawing.Point(247, 12)
        Me.hScrollBar1.Maximum = 360
        Me.hScrollBar1.Name = "hScrollBar1"
        Me.hScrollBar1.Size = New System.Drawing.Size(128, 17)
        Me.hScrollBar1.TabIndex = 1
        AddHandler Me.hScrollBar1.Scroll, AddressOf Me.hScrollBar1_Scroll
        ' 
        ' label1
        ' 
        Me.label1.Location = New System.Drawing.Point(198, 13)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(45, 16)
        Me.label1.TabIndex = 2
        Me.label1.Text = "Rotate:"
        ' 
        ' PieSliceHeights
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(440, 317)
        Me.Name = "PieSliceHeights"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub 'New 
#End Region


    Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim t As Integer
        For t = 0 To donut1.Count - 1
            If checkBox1.Checked Then
                donut1.SliceHeight(t) = Convert.ToInt32(t * 100 / donut1.Count) ' vary height
            Else
                donut1.SliceHeight(t) = 100 ' total height for all slices
            End If
        Next t
    End Sub 'checkBox1_CheckedChanged

    Private Sub hScrollBar1_Scroll(ByVal sender As Object, ByVal e As System.Windows.Forms.ScrollEventArgs)
        donut1.RotationAngle = hScrollBar1.Value
    End Sub 'hScrollBar1_Scroll
End Class 'PieSliceHeights