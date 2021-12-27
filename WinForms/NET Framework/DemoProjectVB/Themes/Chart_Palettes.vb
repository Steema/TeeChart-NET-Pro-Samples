
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports Steema.TeeChart.Themes


Public Class ChartPalettes
    Inherits Steema.TeeChart.Samples.BaseForm
    Private cbCustom As System.Windows.Forms.ComboBox
    Private label1 As System.Windows.Forms.Label
    Private label2 As System.Windows.Forms.Label
    Private cbDefault As System.Windows.Forms.ComboBox
    Private bar1 As Steema.TeeChart.Styles.Bar
    Private components As System.ComponentModel.IContainer = Nothing
    Private RedPalette() As Color
    Private BluePalette() As Color
    Private GreenPalette() As Color
    
    Public Sub New() ' This call is required by the Windows Form Designer.
        InitializeComponent()
    End Sub


    '/// <summary>
    '/// Clean up any resources being used.
    '/// </summary>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)

        If (disposing) Then
            If Not components Is Nothing Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Designer generated code"

    '/ <summary>
    '/ Required method for Designer support - do not modify
    '/ the contents of this method with the code editor.
    '/ </summary>
    Private Sub InitializeComponent()

        Me.cbCustom = New System.Windows.Forms.ComboBox
        Me.label1 = New System.Windows.Forms.Label
        Me.label2 = New System.Windows.Forms.Label
        Me.cbDefault = New System.Windows.Forms.ComboBox
        Me.bar1 = New Steema.TeeChart.Styles.Bar
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Text = "Several pre-defined color palettes can be assigned to each chart." + vbCr + vbLf + vbCr + vbLf + "tmp.ApplyPal" + "ette(tChart1.Chart, cbDefault.SelectedIndex + 1) " + vbCr + vbLf + vbCr + vbLf + "Additionally, you can set y" + "our custom color palettes."
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.label2)
        Me.panel1.Controls.Add(Me.cbDefault)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Controls.Add(Me.cbCustom)
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
        ' 
        ' tChart1.Axes
        ' 
        ' 
        ' tChart1.Axes.Bottom
        ' 
        ' 
        ' tChart1.Axes.Bottom.AxisPen
        ' 
        Me.tChart1.Axes.Bottom.AxisPen.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(128, System.Byte), CType(128, System.Byte), CType(0, System.Byte))
        Me.tChart1.Axes.Bottom.AxisPen.Width = 1
        ' 
        ' tChart1.Axes.Bottom.Grid
        ' 
        Me.tChart1.Axes.Bottom.Grid.Centered = True
        Me.tChart1.Axes.Bottom.Grid.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(128, System.Byte), CType(128, System.Byte), CType(0, System.Byte))
        ' 
        ' tChart1.Axes.Bottom.Labels
        ' 
        ' 
        ' tChart1.Axes.Bottom.Labels.Font
        ' 
        Me.tChart1.Axes.Bottom.Labels.Font.Name = "Times New Roman"
        Me.tChart1.Axes.Bottom.Labels.Font.Size = 10
        ' 
        ' tChart1.Axes.Bottom.MinorTicks
        ' 
        Me.tChart1.Axes.Bottom.MinorTicks.Visible = False
        ' 
        ' tChart1.Axes.Bottom.Ticks
        ' 
        Me.tChart1.Axes.Bottom.Ticks.Color = System.Drawing.Color.Black
        Me.tChart1.Axes.Bottom.Ticks.Length = 2
        ' 
        ' tChart1.Axes.Bottom.TicksInner
        ' 
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
        Me.tChart1.Axes.Depth.MinorTicks.Visible = False
        ' 
        ' tChart1.Axes.Depth.Ticks
        ' 
        Me.tChart1.Axes.Depth.Ticks.Color = System.Drawing.Color.Black
        Me.tChart1.Axes.Depth.Ticks.Length = 2
        ' 
        ' tChart1.Axes.Depth.TicksInner
        ' 
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
        Me.tChart1.Axes.Left.AxisPen.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(128, System.Byte), CType(128, System.Byte), CType(0, System.Byte))
        Me.tChart1.Axes.Left.AxisPen.Width = 1
        ' 
        ' tChart1.Axes.Left.Grid
        ' 
        Me.tChart1.Axes.Left.Grid.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(128, System.Byte), CType(128, System.Byte), CType(0, System.Byte))
        ' 
        ' tChart1.Axes.Left.Labels
        ' 
        ' 
        ' tChart1.Axes.Left.Labels.Font
        ' 
        Me.tChart1.Axes.Left.Labels.Font.Name = "Times New Roman"
        Me.tChart1.Axes.Left.Labels.Font.Size = 10
        ' 
        ' tChart1.Axes.Left.MinorTicks
        ' 
        Me.tChart1.Axes.Left.MinorTicks.Visible = False
        ' 
        ' tChart1.Axes.Left.Ticks
        ' 
        Me.tChart1.Axes.Left.Ticks.Color = System.Drawing.Color.Black
        Me.tChart1.Axes.Left.Ticks.Length = 2
        ' 
        ' tChart1.Axes.Left.TicksInner
        ' 
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
        Me.tChart1.Axes.Right.MinorTicks.Visible = False
        ' 
        ' tChart1.Axes.Right.Ticks
        ' 
        Me.tChart1.Axes.Right.Ticks.Color = System.Drawing.Color.Black
        Me.tChart1.Axes.Right.Ticks.Length = 2
        ' 
        ' tChart1.Axes.Right.TicksInner
        ' 
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
        Me.tChart1.Axes.Top.MinorTicks.Visible = False
        ' 
        ' tChart1.Axes.Top.Ticks
        ' 
        Me.tChart1.Axes.Top.Ticks.Color = System.Drawing.Color.Black
        Me.tChart1.Axes.Top.Ticks.Length = 2
        ' 
        ' tChart1.Axes.Top.TicksInner
        ' 
        Me.tChart1.Axes.Top.TicksInner.Visible = False
        ' 
        ' tChart1.Axes.Top.Title
        ' 
        ' 
        ' tChart1.Axes.Top.Title.Font
        ' 
        Me.tChart1.Axes.Top.Title.Font.Name = "Times New Roman"
        Me.tChart1.Axes.Top.Visible = False
        ' 
        ' tChart1.Header
        ' 
        ' 
        ' tChart1.Header.Font
        ' 
        ' 
        ' tChart1.Header.Font.Brush
        ' 
        Me.tChart1.Header.Font.Brush.Color = System.Drawing.Color.Black
        Me.tChart1.Header.Font.Name = "Times New Roman"
        Me.tChart1.Header.Font.Size = 12
        Me.tChart1.Header.Lines = New String() {"TChart - Color Palettes"}
        ' 
        ' tChart1.Legend
        ' 
        ' 
        ' tChart1.Legend.Font
        ' 
        Me.tChart1.Legend.Font.Name = "Times New Roman"
        Me.tChart1.Legend.Font.Size = 10
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
        Me.tChart1.Legend.Shadow.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(0, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
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
        Me.tChart1.Panel.Shadow.Height = 0
        Me.tChart1.Panel.Shadow.Width = 0
        Me.tChart1.Series.Add(Me.bar1)
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
        Me.tChart1.Walls.Back.Size = 8
        Me.tChart1.Walls.Back.Transparent = False
        Me.tChart1.Walls.Back.Visible = False
        ' 
        ' tChart1.Walls.Bottom
        ' 
        Me.tChart1.Walls.Bottom.ApplyDark = False
        ' 
        ' tChart1.Walls.Bottom.Brush
        ' 
        Me.tChart1.Walls.Bottom.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(192, System.Byte))
        ' 
        ' tChart1.Walls.Bottom.Pen
        ' 
        Me.tChart1.Walls.Bottom.Pen.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(204, System.Byte), CType(204, System.Byte), CType(0, System.Byte))
        Me.tChart1.Walls.Bottom.Size = 8
        ' 
        ' tChart1.Walls.Left
        ' 
        Me.tChart1.Walls.Left.ApplyDark = False
        ' 
        ' tChart1.Walls.Left.Brush
        ' 
        Me.tChart1.Walls.Left.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(192, System.Byte))
        ' 
        ' tChart1.Walls.Left.Pen
        ' 
        Me.tChart1.Walls.Left.Pen.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(206, System.Byte), CType(206, System.Byte), CType(0, System.Byte))
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
        ' cbCustom
        ' 
        Me.cbCustom.Items.AddRange(New Object() {"Default TeeChart", "Reds", "Blues", "Greens"})
        Me.cbCustom.Location = New System.Drawing.Point(26, 17)
        Me.cbCustom.Name = "cbCustom"
        Me.cbCustom.Size = New System.Drawing.Size(121, 21)
        Me.cbCustom.TabIndex = 0
        AddHandler Me.cbCustom.SelectedIndexChanged, AddressOf Me.cbCustom_SelectedIndexChanged
        ' 
        ' label1
        ' 
        Me.label1.Location = New System.Drawing.Point(24, 4)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(100, 11)
        Me.label1.TabIndex = 1
        Me.label1.Text = "Custom Palettes:"
        ' 
        ' label2
        ' 
        Me.label2.Location = New System.Drawing.Point(159, 2)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(100, 11)
        Me.label2.TabIndex = 3
        Me.label2.Text = "Default Palettes:"
        ' 
        ' cbDefault
        ' 
        Me.cbDefault.Location = New System.Drawing.Point(161, 15)
        Me.cbDefault.Name = "cbDefault"
        Me.cbDefault.Size = New System.Drawing.Size(121, 21)
        Me.cbDefault.TabIndex = 2
        AddHandler Me.cbDefault.SelectedIndexChanged, AddressOf Me.cbDefault_SelectedIndexChanged
        ' 
        ' bar1
        ' 
        ' 
        ' bar1.Brush
        ' 
        Me.bar1.Brush.Color = System.Drawing.Color.Red
        Me.bar1.ColorEach = True
        ' 
        ' bar1.Marks
        ' 
        ' 
        ' bar1.Marks.Arrow
        ' 
        Me.bar1.Marks.Arrow.Color = System.Drawing.Color.Black
        ' 
        ' bar1.Marks.Font
        ' 
        Me.bar1.Marks.Font.Name = "Times New Roman"
        Me.bar1.Marks.Font.Size = 10
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
        ' ChartPalettes
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(440, 317)
        Me.Name = "ChartPalettes"
        AddHandler Me.Leave, AddressOf Me.ChartPalettes_Leave
        AddHandler Me.Load, AddressOf Me.ChartPalettes_Load
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub 'New 
#End Region


    Private Sub ChartPalettes_Load(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim t As Integer
        bar1.FillSampleValues(15)
        bar1.ColorEach = True

        cbCustom.SelectedIndex = 0
        cbDefault.Items.Clear()



        For Each s As String In Theme.ColorPalettes
            cbDefault.Items.Add(s)
        Next s

        RedPalette = New Color(15) {}
        For t = 0 To 14
            RedPalette(t) = Color.FromArgb(128 + Convert.ToInt32(Math.Round(t * (128.0 / 15.0))), 0, 0)
        Next t '


        BluePalette = New Color(15) {}
        For t = 0 To 14
            BluePalette(t) = Color.FromArgb(0, 0, 128 + Convert.ToInt32(Math.Round(t * (128.0 / 15.0))))
        Next t '


        GreenPalette = New Color(14) {}
        For t = 0 To 14
            GreenPalette(t) = Color.FromArgb(0, 128 + Convert.ToInt32(Math.Round(t * (128.0 / 15.0))), 0)
        Next t '


    End Sub 'ChartPalettes_Load


    Private Sub cbCustom_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Select Case cbCustom.SelectedIndex
            Case 0
                ColorPalettes.ApplyPalette(tChart1.Chart, Steema.TeeChart.Themes.Theme.TeeChartPalette)
                tChart1.Refresh()
            Case 1
                ColorPalettes.ApplyPalette(tChart1.Chart, RedPalette)
                tChart1.Refresh()
            Case 2
                ColorPalettes.ApplyPalette(tChart1.Chart, BluePalette)
                tChart1.Refresh()
            Case 3
                ColorPalettes.ApplyPalette(tChart1.Chart, GreenPalette)
                tChart1.Refresh()
        End Select
    End Sub 'cbCustom_SelectedIndexChanged


    Private Sub cbDefault_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        ColorPalettes.ApplyPalette(tChart1.Chart, cbDefault.SelectedIndex)
    End Sub 'cbDefault_SelectedIndexChanged



    Private Sub ChartPalettes_Leave(ByVal sender As Object, ByVal e As System.EventArgs)
        ColorPalettes.ApplyPalette(tChart1.Chart, Steema.TeeChart.Themes.Theme.TeeChartPalette)
    End Sub 'ChartPalettes_Leave
End Class 'ChartPalettes