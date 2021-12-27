
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Data
Imports System.Text
#If VS2005 Then
Imports System.Collections.Generic
#End If




Public Class Tool_LegendPalette
    Inherits Samples.BaseForm

    '/ <summary>
    '/ Required designer variable.
    '/ </summary>
    Private components As System.ComponentModel.IContainer = Nothing


    Public Sub New() ' me call is required by the Windows Form Designer.
        InitializeComponent()
        AddSurfacePoints()
        surface1.UseColorRange = False
        surface1.UsePalette = True
        surface1.PaletteStyle = Steema.TeeChart.Styles.PaletteStyles.Rainbow
    End Sub

    Private Sub AddSurfacePoints()
        Dim NumX As Integer = 30
        Dim NumZ As Integer = 30
        surface1.NumXValues = NumX
        surface1.NumZValues = NumZ
        For x As Integer = 1 To NumX
            For z As Integer = 1 To NumZ
                surface1.Add(x, Math.Cos(0.14 * x) * Math.Cos(0.25 * z) + _
                      0.01 * (x - (NumX / 2)) * (z - (NumZ / 2)) + _
                      13.0 * Math.Exp(-0.06 * (Math.Pow(x - (NumX / 2), 2) + Math.Pow(z - (NumZ / 2), 2))) + _
                      6 * Math.Exp(-0.03 * (Math.Pow(x - (NumX / 3), 2) + Math.Pow(z - 3 * (NumZ / 5), 2))) - 1, _
                      z)
            Next z
        Next x
    End Sub

    Private surface1 As Steema.TeeChart.Styles.Surface
    Private legendPalette1 As Steema.TeeChart.Tools.LegendPalette
    Private WithEvents checkBox1 As CheckBox
    Private WithEvents checkBox2 As CheckBox
    Private label1 As Label
    Private WithEvents comboBox1 As ComboBox
    Private WithEvents checkBox3 As CheckBox

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
    '/ the contents of me method with the code editor.
    '/ </summary>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Tool_LegendPalette))
        Me.surface1 = New Steema.TeeChart.Styles.Surface
        Me.legendPalette1 = New Steema.TeeChart.Tools.LegendPalette
        Me.checkBox1 = New System.Windows.Forms.CheckBox
        Me.checkBox2 = New System.Windows.Forms.CheckBox
        Me.comboBox1 = New System.Windows.Forms.ComboBox
        Me.label1 = New System.Windows.Forms.Label
        Me.checkBox3 = New System.Windows.Forms.CheckBox
        Me.panel1.SuspendLayout()
        Me.chartContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'textBox1
        '
        Me.textBox1.Text = resources.GetString("textBox1.Text")
        '
        'panel1
        '
        Me.panel1.Controls.Add(Me.checkBox3)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Controls.Add(Me.comboBox1)
        Me.panel1.Controls.Add(Me.checkBox2)
        Me.panel1.Controls.Add(Me.checkBox1)
        Me.panel1.Size = New System.Drawing.Size(440, 49)
        '
        'tChart1
        '
        '
        '
        '
        Me.tChart1.Aspect.Chart3DPercent = 80
        Me.tChart1.Aspect.ColorPaletteIndex = 0
        Me.tChart1.Aspect.Elevation = 351
        Me.tChart1.Aspect.ElevationFloat = 351
        Me.tChart1.Aspect.Orthogonal = False
        Me.tChart1.Aspect.Rotation = 318
        Me.tChart1.Aspect.RotationFloat = 318
        Me.tChart1.Aspect.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
        Me.tChart1.Aspect.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias
        Me.tChart1.Aspect.Zoom = 79
        '
        '
        '
        '
        '
        '
        '
        '
        '
        Me.tChart1.Axes.Bottom.AxisPen.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        '
        '
        Me.tChart1.Axes.Bottom.Grid.Color = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tChart1.Axes.Bottom.Grid.Style = System.Drawing.Drawing2D.DashStyle.Dot
        '
        '
        '
        '
        '
        '
        Me.tChart1.Axes.Bottom.Labels.Font.Name = "Arial"
        '
        '
        '
        Me.tChart1.Axes.Bottom.Ticks.Length = 2
        '
        '
        '
        Me.tChart1.Axes.Bottom.TicksInner.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        '
        '
        '
        '
        '
        Me.tChart1.Axes.Bottom.Title.Font.Name = "Arial"
        '
        '
        '
        '
        '
        '
        Me.tChart1.Axes.Depth.AxisPen.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        '
        '
        Me.tChart1.Axes.Depth.Grid.Color = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tChart1.Axes.Depth.Grid.Style = System.Drawing.Drawing2D.DashStyle.Dot
        '
        '
        '
        '
        '
        '
        Me.tChart1.Axes.Depth.Labels.Font.Name = "Arial"
        '
        '
        '
        Me.tChart1.Axes.Depth.Ticks.Length = 2
        '
        '
        '
        Me.tChart1.Axes.Depth.TicksInner.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        '
        '
        '
        '
        '
        Me.tChart1.Axes.Depth.Title.Font.Name = "Arial"
        '
        '
        '
        '
        '
        '
        Me.tChart1.Axes.DepthTop.AxisPen.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        '
        '
        Me.tChart1.Axes.DepthTop.Grid.Color = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tChart1.Axes.DepthTop.Grid.Style = System.Drawing.Drawing2D.DashStyle.Dot
        '
        '
        '
        '
        '
        '
        Me.tChart1.Axes.DepthTop.Labels.Font.Name = "Arial"
        '
        '
        '
        Me.tChart1.Axes.DepthTop.Ticks.Length = 2
        '
        '
        '
        Me.tChart1.Axes.DepthTop.TicksInner.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        '
        '
        '
        '
        '
        Me.tChart1.Axes.DepthTop.Title.Font.Name = "Arial"
        '
        '
        '
        '
        '
        '
        Me.tChart1.Axes.Left.AxisPen.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        '
        '
        Me.tChart1.Axes.Left.Grid.Color = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tChart1.Axes.Left.Grid.Style = System.Drawing.Drawing2D.DashStyle.Dot
        '
        '
        '
        '
        '
        '
        Me.tChart1.Axes.Left.Labels.Font.Name = "Arial"
        '
        '
        '
        Me.tChart1.Axes.Left.Ticks.Length = 2
        '
        '
        '
        Me.tChart1.Axes.Left.TicksInner.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        '
        '
        '
        '
        '
        Me.tChart1.Axes.Left.Title.Font.Name = "Arial"
        '
        '
        '
        '
        '
        '
        Me.tChart1.Axes.Right.AxisPen.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        '
        '
        Me.tChart1.Axes.Right.Grid.Color = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tChart1.Axes.Right.Grid.Style = System.Drawing.Drawing2D.DashStyle.Dot
        '
        '
        '
        '
        '
        '
        Me.tChart1.Axes.Right.Labels.Font.Name = "Arial"
        '
        '
        '
        Me.tChart1.Axes.Right.Ticks.Length = 2
        '
        '
        '
        Me.tChart1.Axes.Right.TicksInner.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        '
        '
        '
        '
        '
        Me.tChart1.Axes.Right.Title.Font.Name = "Arial"
        '
        '
        '
        '
        '
        '
        Me.tChart1.Axes.Top.AxisPen.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        '
        '
        Me.tChart1.Axes.Top.Grid.Color = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tChart1.Axes.Top.Grid.Style = System.Drawing.Drawing2D.DashStyle.Dot
        '
        '
        '
        '
        '
        '
        Me.tChart1.Axes.Top.Labels.Font.Name = "Arial"
        '
        '
        '
        Me.tChart1.Axes.Top.Ticks.Length = 2
        '
        '
        '
        Me.tChart1.Axes.Top.TicksInner.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        '
        '
        '
        '
        '
        Me.tChart1.Axes.Top.Title.Font.Name = "Arial"
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
        Me.tChart1.Header.Brush.Gradient.UseMiddle = True
        '
        '
        '
        '
        '
        '
        Me.tChart1.Header.Font.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tChart1.Header.Font.Name = "Arial"
        '
        '
        '
        Me.tChart1.Header.Pen.Visible = False
        Me.tChart1.Header.Visible = False
        '
        '
        '
        '
        '
        '
        '
        '
        '
        Me.tChart1.Legend.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tChart1.Legend.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tChart1.Legend.Brush.Gradient.SigmaFocus = 0.0!
        Me.tChart1.Legend.Brush.Gradient.SigmaScale = 0.0!
        Me.tChart1.Legend.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tChart1.Legend.Brush.Gradient.UseMiddle = True
        '
        '
        '
        Me.tChart1.Legend.Font.Name = "Arial"
        Me.tChart1.Legend.MaxNumRows = 8
        '
        '
        '
        '
        '
        '
        Me.tChart1.Legend.Title.Pen.Visible = False
        Me.tChart1.Legend.Visible = False
        Me.tChart1.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        '
        '
        '
        '
        '
        '
        Me.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tChart1.Panel.Brush.Gradient.Sigma = True
        Me.tChart1.Panel.Brush.Gradient.SigmaFocus = 1.0!
        Me.tChart1.Panel.Brush.Gradient.SigmaScale = 0.8!
        Me.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tChart1.Panel.Brush.Gradient.Visible = False
        Me.tChart1.Panel.MarginRight = 25
        Me.tChart1.Series.Add(Me.surface1)
        Me.tChart1.Size = New System.Drawing.Size(440, 195)
        Me.tChart1.Tools.Add(Me.legendPalette1)
        '
        '
        '
        '
        '
        '
        '
        '
        '
        '
        '
        '
        Me.tChart1.Walls.Back.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tChart1.Walls.Back.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tChart1.Walls.Back.Brush.Gradient.SigmaFocus = 0.0!
        Me.tChart1.Walls.Back.Brush.Gradient.SigmaScale = 0.0!
        Me.tChart1.Walls.Back.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tChart1.Walls.Back.Brush.Gradient.UseMiddle = True
        Me.tChart1.Walls.Back.Brush.Gradient.Visible = False
        Me.tChart1.Walls.Back.Brush.Visible = False
        Me.tChart1.Walls.Back.Transparent = True
        '
        '
        '
        '
        '
        '
        '
        '
        '
        Me.tChart1.Walls.Bottom.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tChart1.Walls.Bottom.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tChart1.Walls.Bottom.Brush.Gradient.SigmaFocus = 0.0!
        Me.tChart1.Walls.Bottom.Brush.Gradient.SigmaScale = 0.0!
        Me.tChart1.Walls.Bottom.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tChart1.Walls.Bottom.Brush.Gradient.UseMiddle = True
        '
        '
        '
        '
        '
        '
        '
        '
        '
        Me.tChart1.Walls.Left.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tChart1.Walls.Left.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tChart1.Walls.Left.Brush.Gradient.SigmaFocus = 0.0!
        Me.tChart1.Walls.Left.Brush.Gradient.SigmaScale = 0.0!
        Me.tChart1.Walls.Left.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tChart1.Walls.Left.Brush.Gradient.UseMiddle = True
        '
        '
        '
        '
        '
        '
        Me.tChart1.Walls.Right.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        '
        '
        '
        Me.tChart1.Walls.Right.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tChart1.Walls.Right.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tChart1.Walls.Right.Brush.Gradient.SigmaFocus = 0.0!
        Me.tChart1.Walls.Right.Brush.Gradient.SigmaScale = 0.0!
        Me.tChart1.Walls.Right.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tChart1.Walls.Right.Brush.Gradient.UseMiddle = True
        '
        'chartContainer
        '
        Me.chartContainer.Location = New System.Drawing.Point(0, 122)
        Me.chartContainer.Size = New System.Drawing.Size(440, 195)
        '
        'surface1
        '
        '
        '
        '
        Me.surface1.Brush.Color = System.Drawing.Color.Red
        Me.surface1.ColorEach = False
        Me.surface1.EndColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        '
        '
        '
        Me.surface1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None
        Me.surface1.Marks.Callout.ArrowHeadSize = 8
        '
        '
        '
        Me.surface1.Marks.Callout.Brush.Color = System.Drawing.Color.Black
        Me.surface1.Marks.Callout.Distance = 0
        Me.surface1.Marks.Callout.Draw3D = False
        Me.surface1.Marks.Callout.Length = 10
        Me.surface1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.surface1.PaletteMin = 0
        Me.surface1.PaletteStep = 0
        Me.surface1.PaletteStyle = Steema.TeeChart.Styles.PaletteStyles.Pale
        Me.surface1.StartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.surface1.Title = "surface1"
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
        'legendPalette1
        '
        Me.legendPalette1.Axis = Steema.TeeChart.Tools.LegendPaletteAxis.laBoth
        Me.legendPalette1.Series = Me.surface1
        '
        'checkBox1
        '
        Me.checkBox1.Checked = True
        Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox1.Location = New System.Drawing.Point(12, 16)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(58, 17)
        Me.checkBox1.TabIndex = 0
        Me.checkBox1.Text = "Vertical"
        '
        'checkBox2
        '
        Me.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox2.Location = New System.Drawing.Point(76, 16)
        Me.checkBox2.Name = "checkBox2"
        Me.checkBox2.Size = New System.Drawing.Size(80, 17)
        Me.checkBox2.TabIndex = 1
        Me.checkBox2.Text = "Transparent"
        '
        'comboBox1
        '
        Me.comboBox1.Items.AddRange(New Object() {"Default", "Other", "Both"})
        Me.comboBox1.Location = New System.Drawing.Point(212, 15)
        Me.comboBox1.Name = "comboBox1"
        Me.comboBox1.Size = New System.Drawing.Size(89, 21)
        Me.comboBox1.TabIndex = 2
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(180, 18)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(26, 13)
        Me.label1.TabIndex = 3
        Me.label1.Text = "Axis"
        '
        'checkBox3
        '
        Me.checkBox3.Checked = True
        Me.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox3.Location = New System.Drawing.Point(337, 17)
        Me.checkBox3.Name = "checkBox3"
        Me.checkBox3.Size = New System.Drawing.Size(42, 17)
        Me.checkBox3.TabIndex = 4
        Me.checkBox3.Text = "Pen"
        '
        'Tool_LegendPalette
        '
        Me.ClientSize = New System.Drawing.Size(440, 317)
        Me.Name = "Tool_LegendPalette"
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.chartContainer.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox1.CheckedChanged
        legendPalette1.Vertical = checkBox1.Checked
        legendPalette1.Left = tChart1.Width - legendPalette1.Width - 10
    End Sub

    Private Sub checkBox2_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox2.CheckedChanged
        legendPalette1.Transparent = checkBox2.Checked
    End Sub

    Private Sub comboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox1.SelectedIndexChanged
        legendPalette1.Axis = CType(comboBox1.SelectedIndex, Steema.TeeChart.Tools.LegendPaletteAxis)
    End Sub

  Private Sub Tool_LegendPalette_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
    comboBox1.SelectedIndex = 2
  End Sub

  Private Sub checkBox3_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox3.CheckedChanged
    legendPalette1.Pen.Visible = checkBox3.Checked
  End Sub

  Private Sub tChart1_Resize(ByVal sender As Object, ByVal e As EventArgs) Handles tChart1.Resize
    If Not (legendPalette1 Is Nothing) Then
      legendPalette1.Left = tChart1.Width - legendPalette1.Width - 10
    End If
  End Sub
End Class

