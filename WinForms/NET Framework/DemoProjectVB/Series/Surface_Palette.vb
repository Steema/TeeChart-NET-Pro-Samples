
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing

Imports System.Windows.Forms




Public Class Surface_Palette
    Inherits Samples.BaseForm
    Private surfaceSeries1 As Steema.TeeChart.Styles.Surface
    Private WithEvents comboBox1 As System.Windows.Forms.ComboBox
    Private rotate1 As Steema.TeeChart.Tools.Rotate
    Private components As System.ComponentModel.IContainer = Nothing
    Private label1 As System.Windows.Forms.Label
    
    
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        surfaceSeries1.FillSampleValues(30)
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
        Me.surfaceSeries1 = New Steema.TeeChart.Styles.Surface
        Me.comboBox1 = New System.Windows.Forms.ComboBox
        Me.rotate1 = New Steema.TeeChart.Tools.Rotate
        Me.label1 = New System.Windows.Forms.Label
        Me.panel1.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(399, 56)
        Me.textBox1.TabIndex = 0
        Me.textBox1.Text = "Surface palette can be of several types: Pale, Strong, Gray scale, Inverted gray " + "and Rainbow" + vbCr + vbLf + vbCr + vbLf + "Example: surfaceSeries1.PaletteStyle = Steema.TeeChart.Styles.Pal" + "etteStyles.Rainbow"
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Controls.Add(Me.comboBox1)
        Me.panel1.Location = New System.Drawing.Point(0, 56)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(399, 35)
        Me.panel1.TabIndex = 1
        ' 
        ' tChart1
        ' 
        ' 
        ' tChart1.Aspect
        ' 
        Me.tChart1.Aspect.Chart3DPercent = 90
        Me.tChart1.Aspect.Elevation = 312
        Me.tChart1.Aspect.Orthogonal = False
        Me.tChart1.Aspect.Perspective = 62
        Me.tChart1.Aspect.Rotation = 330
        Me.tChart1.Aspect.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality
        Me.tChart1.Aspect.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        Me.tChart1.Aspect.VertOffset = -20
        Me.tChart1.Aspect.Zoom = 46
        ' 
        ' tChart1.Axes
        ' 
        ' 
        ' tChart1.Axes.Bottom
        ' 
        ' 
        ' tChart1.Axes.Bottom.Grid
        ' 
        Me.tChart1.Axes.Bottom.Grid.ZPosition = 0
        ' 
        ' tChart1.Axes.Bottom.Labels
        ' 
        ' 
        ' tChart1.Axes.Bottom.Labels.Font
        ' 
        ' 
        ' tChart1.Axes.Bottom.Labels.Font.Shadow
        ' 
        Me.tChart1.Axes.Bottom.Labels.Font.Shadow.Visible = False
        ' 
        ' tChart1.Axes.Bottom.Labels.Shadow
        ' 
        Me.tChart1.Axes.Bottom.Labels.Shadow.Visible = False
        ' 
        ' tChart1.Axes.Bottom.Title
        ' 
        ' 
        ' tChart1.Axes.Bottom.Title.Font
        ' 
        ' 
        ' tChart1.Axes.Bottom.Title.Font.Shadow
        ' 
        Me.tChart1.Axes.Bottom.Title.Font.Shadow.Visible = False
        ' 
        ' tChart1.Axes.Bottom.Title.Shadow
        ' 
        Me.tChart1.Axes.Bottom.Title.Shadow.Visible = False
        ' 
        ' tChart1.Axes.Depth
        ' 
        ' 
        ' tChart1.Axes.Depth.Grid
        ' 
        Me.tChart1.Axes.Depth.Grid.ZPosition = 0
        ' 
        ' tChart1.Axes.Depth.Labels
        ' 
        ' 
        ' tChart1.Axes.Depth.Labels.Font
        ' 
        ' 
        ' tChart1.Axes.Depth.Labels.Font.Shadow
        ' 
        Me.tChart1.Axes.Depth.Labels.Font.Shadow.Visible = False
        ' 
        ' tChart1.Axes.Depth.Labels.Shadow
        ' 
        Me.tChart1.Axes.Depth.Labels.Shadow.Visible = False
        ' 
        ' tChart1.Axes.Depth.Title
        ' 
        ' 
        ' tChart1.Axes.Depth.Title.Font
        ' 
        ' 
        ' tChart1.Axes.Depth.Title.Font.Shadow
        ' 
        Me.tChart1.Axes.Depth.Title.Font.Shadow.Visible = False
        ' 
        ' tChart1.Axes.Depth.Title.Shadow
        ' 
        Me.tChart1.Axes.Depth.Title.Shadow.Visible = False
        Me.tChart1.Axes.Depth.Visible = True
        ' 
        ' tChart1.Axes.DepthTop
        ' 
        ' 
        ' tChart1.Axes.DepthTop.Grid
        ' 
        Me.tChart1.Axes.DepthTop.Grid.ZPosition = 0
        ' 
        ' tChart1.Axes.DepthTop.Labels
        ' 
        ' 
        ' tChart1.Axes.DepthTop.Labels.Font
        ' 
        ' 
        ' tChart1.Axes.DepthTop.Labels.Font.Shadow
        ' 
        Me.tChart1.Axes.DepthTop.Labels.Font.Shadow.Visible = False
        ' 
        ' tChart1.Axes.DepthTop.Labels.Shadow
        ' 
        Me.tChart1.Axes.DepthTop.Labels.Shadow.Visible = False
        ' 
        ' tChart1.Axes.DepthTop.Title
        ' 
        ' 
        ' tChart1.Axes.DepthTop.Title.Font
        ' 
        ' 
        ' tChart1.Axes.DepthTop.Title.Font.Shadow
        ' 
        Me.tChart1.Axes.DepthTop.Title.Font.Shadow.Visible = False
        ' 
        ' tChart1.Axes.DepthTop.Title.Shadow
        ' 
        Me.tChart1.Axes.DepthTop.Title.Shadow.Visible = False
        ' 
        ' tChart1.Axes.Left
        ' 
        ' 
        ' tChart1.Axes.Left.Grid
        ' 
        Me.tChart1.Axes.Left.Grid.ZPosition = 0
        ' 
        ' tChart1.Axes.Left.Labels
        ' 
        ' 
        ' tChart1.Axes.Left.Labels.Font
        ' 
        ' 
        ' tChart1.Axes.Left.Labels.Font.Shadow
        ' 
        Me.tChart1.Axes.Left.Labels.Font.Shadow.Visible = False
        ' 
        ' tChart1.Axes.Left.Labels.Shadow
        ' 
        Me.tChart1.Axes.Left.Labels.Shadow.Visible = False
        ' 
        ' tChart1.Axes.Left.Title
        ' 
        ' 
        ' tChart1.Axes.Left.Title.Font
        ' 
        ' 
        ' tChart1.Axes.Left.Title.Font.Shadow
        ' 
        Me.tChart1.Axes.Left.Title.Font.Shadow.Visible = False
        ' 
        ' tChart1.Axes.Left.Title.Shadow
        ' 
        Me.tChart1.Axes.Left.Title.Shadow.Visible = False
        ' 
        ' tChart1.Axes.Right
        ' 
        ' 
        ' tChart1.Axes.Right.Grid
        ' 
        Me.tChart1.Axes.Right.Grid.ZPosition = 0
        ' 
        ' tChart1.Axes.Right.Labels
        ' 
        ' 
        ' tChart1.Axes.Right.Labels.Font
        ' 
        ' 
        ' tChart1.Axes.Right.Labels.Font.Shadow
        ' 
        Me.tChart1.Axes.Right.Labels.Font.Shadow.Visible = False
        ' 
        ' tChart1.Axes.Right.Labels.Shadow
        ' 
        Me.tChart1.Axes.Right.Labels.Shadow.Visible = False
        ' 
        ' tChart1.Axes.Right.Title
        ' 
        ' 
        ' tChart1.Axes.Right.Title.Font
        ' 
        ' 
        ' tChart1.Axes.Right.Title.Font.Shadow
        ' 
        Me.tChart1.Axes.Right.Title.Font.Shadow.Visible = False
        ' 
        ' tChart1.Axes.Right.Title.Shadow
        ' 
        Me.tChart1.Axes.Right.Title.Shadow.Visible = False
        ' 
        ' tChart1.Axes.Top
        ' 
        ' 
        ' tChart1.Axes.Top.Grid
        ' 
        Me.tChart1.Axes.Top.Grid.ZPosition = 0
        ' 
        ' tChart1.Axes.Top.Labels
        ' 
        ' 
        ' tChart1.Axes.Top.Labels.Font
        ' 
        ' 
        ' tChart1.Axes.Top.Labels.Font.Shadow
        ' 
        Me.tChart1.Axes.Top.Labels.Font.Shadow.Visible = False
        ' 
        ' tChart1.Axes.Top.Labels.Shadow
        ' 
        Me.tChart1.Axes.Top.Labels.Shadow.Visible = False
        ' 
        ' tChart1.Axes.Top.Title
        ' 
        ' 
        ' tChart1.Axes.Top.Title.Font
        ' 
        ' 
        ' tChart1.Axes.Top.Title.Font.Shadow
        ' 
        Me.tChart1.Axes.Top.Title.Font.Shadow.Visible = False
        ' 
        ' tChart1.Axes.Top.Title.Shadow
        ' 
        Me.tChart1.Axes.Top.Title.Shadow.Visible = False
        Me.tChart1.BackColor = System.Drawing.Color.Transparent
        ' 
        ' tChart1.Footer
        ' 
        ' 
        ' tChart1.Footer.Font
        ' 
        ' 
        ' tChart1.Footer.Font.Shadow
        ' 
        Me.tChart1.Footer.Font.Shadow.Visible = False
        ' 
        ' tChart1.Footer.Shadow
        ' 
        Me.tChart1.Footer.Shadow.Visible = False
        ' 
        ' tChart1.Header
        ' 
        ' 
        ' tChart1.Header.Font
        ' 
        ' 
        ' tChart1.Header.Font.Shadow
        ' 
        Me.tChart1.Header.Font.Shadow.Visible = False
        Me.tChart1.Header.Lines = New String() {""}
        ' 
        ' tChart1.Header.Shadow
        ' 
        Me.tChart1.Header.Shadow.Visible = False
        ' 
        ' tChart1.Legend
        ' 
        ' 
        ' tChart1.Legend.Font
        ' 
        ' 
        ' tChart1.Legend.Font.Shadow
        ' 
        Me.tChart1.Legend.Font.Shadow.Visible = False
        Me.tChart1.Legend.MaxNumRows = 8
        ' 
        ' tChart1.Legend.Pen
        ' 
        Me.tChart1.Legend.Pen.Visible = False
        Me.tChart1.Legend.ResizeChart = False
        ' 
        ' tChart1.Legend.Symbol
        ' 
        Me.tChart1.Legend.Symbol.Continous = True
        Me.tChart1.Legend.Symbol.DefaultPen = False
        Me.tChart1.Legend.Symbol.Position = Steema.TeeChart.LegendSymbolPosition.Right
        ' 
        ' tChart1.Legend.Title
        ' 
        ' 
        ' tChart1.Legend.Title.Font
        ' 
        Me.tChart1.Legend.Title.Font.Bold = True
        ' 
        ' tChart1.Legend.Title.Font.Shadow
        ' 
        Me.tChart1.Legend.Title.Font.Shadow.Visible = False
        ' 
        ' tChart1.Legend.Title.Pen
        ' 
        Me.tChart1.Legend.Title.Pen.Visible = False
        ' 
        ' tChart1.Legend.Title.Shadow
        ' 
        Me.tChart1.Legend.Title.Shadow.Visible = False
        Me.tChart1.Location = New System.Drawing.Point(0, 91)
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Brush
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(127, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(192, System.Byte))
        ' 
        ' tChart1.Panel.Gradient
        ' 
        Me.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(192, System.Byte))
        Me.tChart1.Panel.Brush.Gradient.Visible = True
        ' 
        ' tChart1.Panel.Gradient
        ' 
        Me.tChart1.Panel.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(192, System.Byte))
        Me.tChart1.Panel.Gradient.Visible = True
        ' 
        ' tChart1.Panel.Pen
        ' 
        Me.tChart1.Panel.Pen.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(0, System.Byte), CType(0, System.Byte), CType(128, System.Byte))
        Me.tChart1.Panel.Pen.Visible = True
        Me.tChart1.Panel.Pen.Width = 2
        ' 
        ' tChart1.Panel.Shadow
        ' 
        Me.tChart1.Panel.Shadow.Visible = False
        Me.tChart1.Series.Add(Me.surfaceSeries1)
        Me.tChart1.Size = New System.Drawing.Size(399, 165)
        ' 
        ' tChart1.SubFooter
        ' 
        ' 
        ' tChart1.SubFooter.Font
        ' 
        ' 
        ' tChart1.SubFooter.Font.Shadow
        ' 
        Me.tChart1.SubFooter.Font.Shadow.Visible = False
        ' 
        ' tChart1.SubFooter.Shadow
        ' 
        Me.tChart1.SubFooter.Shadow.Visible = False
        ' 
        ' tChart1.SubHeader
        ' 
        ' 
        ' tChart1.SubHeader.Font
        ' 
        ' 
        ' tChart1.SubHeader.Font.Shadow
        ' 
        Me.tChart1.SubHeader.Font.Shadow.Visible = False
        ' 
        ' tChart1.SubHeader.Shadow
        ' 
        Me.tChart1.SubHeader.Shadow.Visible = False
        Me.tChart1.TabIndex = 2
        Me.tChart1.Tools.Add(Me.rotate1)
        ' 
        ' tChart1.Walls
        ' 
        ' 
        ' tChart1.Walls.Back
        ' 
        Me.tChart1.Walls.Back.AutoHide = False
        ' 
        ' tChart1.Walls.Back.Brush
        ' 
        Me.tChart1.Walls.Back.Brush.Color = System.Drawing.Color.FromArgb(CType(153, System.Byte), CType(192, System.Byte), CType(192, System.Byte), CType(192, System.Byte))
        ' 
        ' tChart1.Walls.Back.Pen
        ' 
        Me.tChart1.Walls.Back.Pen.Visible = False
        ' 
        ' tChart1.Walls.Back.Shadow
        ' 
        Me.tChart1.Walls.Back.Shadow.Visible = False
        Me.tChart1.Walls.Back.Size = 4
        Me.tChart1.Walls.Back.Transparent = False
        ' 
        ' tChart1.Walls.Bottom
        ' 
        Me.tChart1.Walls.Bottom.AutoHide = False
        ' 
        ' tChart1.Walls.Bottom.Brush
        ' 
        Me.tChart1.Walls.Bottom.Brush.Color = System.Drawing.Color.FromArgb(CType(153, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        ' 
        ' tChart1.Walls.Bottom.Gradient
        ' 
        Me.tChart1.Walls.Bottom.Brush.Gradient.Transparency = 40
        ' 
        ' tChart1.Walls.Bottom.Gradient
        ' 
        Me.tChart1.Walls.Bottom.Gradient.Transparency = 40
        ' 
        ' tChart1.Walls.Bottom.Pen
        ' 
        Me.tChart1.Walls.Bottom.Pen.Visible = False
        ' 
        ' tChart1.Walls.Bottom.Shadow
        ' 
        Me.tChart1.Walls.Bottom.Shadow.Visible = False
        Me.tChart1.Walls.Bottom.Size = 5
        ' 
        ' tChart1.Walls.Left
        ' 
        Me.tChart1.Walls.Left.AutoHide = False
        ' 
        ' tChart1.Walls.Left.Brush
        ' 
        Me.tChart1.Walls.Left.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(224, System.Byte))
        ' 
        ' tChart1.Walls.Left.Pen
        ' 
        Me.tChart1.Walls.Left.Pen.Visible = False
        ' 
        ' tChart1.Walls.Left.Shadow
        ' 
        Me.tChart1.Walls.Left.Shadow.Visible = False
        Me.tChart1.Walls.Left.Size = 4
        ' 
        ' tChart1.Walls.Right
        ' 
        Me.tChart1.Walls.Right.AutoHide = False
        ' 
        ' tChart1.Walls.Right.Shadow
        ' 
        Me.tChart1.Walls.Right.Shadow.Visible = False
        ' 
        ' surfaceSeries1
        ' 
        ' 
        ' surfaceSeries1.Brush
        ' 
        Me.surfaceSeries1.Brush.Color = System.Drawing.Color.Red
        ' 
        ' surfaceSeries1.Marks
        ' 
        ' 
        ' surfaceSeries1.Marks.Callout
        ' 
        Me.surfaceSeries1.Marks.Callout.Arrow = Me.surfaceSeries1.Marks.Arrow
        Me.surfaceSeries1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None
        Me.surfaceSeries1.Marks.Callout.ArrowHeadSize = 8
        ' 
        ' surfaceSeries1.Marks.Callout.Brush
        ' 
        Me.surfaceSeries1.Marks.Callout.Brush.Color = System.Drawing.Color.Black
        Me.surfaceSeries1.Marks.Callout.Distance = 0
        Me.surfaceSeries1.Marks.Callout.Draw3D = False
        Me.surfaceSeries1.Marks.Callout.Length = 10
        Me.surfaceSeries1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        ' 
        ' surfaceSeries1.Marks.Font
        ' 
        ' 
        ' surfaceSeries1.Marks.Font.Shadow
        ' 
        Me.surfaceSeries1.Marks.Font.Shadow.Visible = False
        Me.surfaceSeries1.NumXValues = 25
        Me.surfaceSeries1.NumZValues = 25
        Me.surfaceSeries1.PaletteMin = 0
        Me.surfaceSeries1.PaletteStep = 0
        Me.surfaceSeries1.PaletteStyle = Steema.TeeChart.Styles.PaletteStyles.Rainbow
        ' 
        ' surfaceSeries1.Pen
        ' 
        Me.surfaceSeries1.Pen.Visible = False
        Me.surfaceSeries1.Title = "surface1"
        Me.surfaceSeries1.UseColorRange = False
        Me.surfaceSeries1.UsePalette = True
        ' 
        ' surfaceSeries1.XValues
        ' 
        Me.surfaceSeries1.XValues.DataMember = "X"
        ' 
        ' surfaceSeries1.YValues
        ' 
        Me.surfaceSeries1.YValues.DataMember = "Y"
        ' 
        ' surfaceSeries1.ZValues
        ' 
        Me.surfaceSeries1.ZValues.DataMember = "Z"
        ' 
        ' comboBox1
        ' 
        Me.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboBox1.Items.AddRange(New Object() {"Pale", "Strong", "Gray", "Inverted gray", "Rainbow"})
        Me.comboBox1.Location = New System.Drawing.Point(96, 8)
        Me.comboBox1.Name = "comboBox1"
        Me.comboBox1.Size = New System.Drawing.Size(88, 21)
        Me.comboBox1.TabIndex = 1
        ' 
        ' label1
        ' 
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(23, 11)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(71, 16)
        Me.label1.TabIndex = 2
        Me.label1.Text = "Palette Style:"
        ' 
        ' Surface_Palette
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(399, 256)
        Me.Name = "Surface_Palette"
        Me.panel1.ResumeLayout(False)
    End Sub 'InitializeComponent 
#End Region


    Private Sub SeriesType_Surface_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        surfaceSeries1.UseColorRange = False
        surfaceSeries1.UsePalette = True
        comboBox1.SelectedIndex = 4
    End Sub 'SeriesType_Surface_Load


    Private Sub comboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboBox1.SelectedIndexChanged
        Select Case comboBox1.SelectedIndex
            Case 0
                surfaceSeries1.PaletteStyle = Steema.TeeChart.Styles.PaletteStyles.Pale
                surfaceSeries1.PaletteSteps = 32
                Exit Select
            Case 1
                surfaceSeries1.PaletteStyle = Steema.TeeChart.Styles.PaletteStyles.Strong
                surfaceSeries1.PaletteSteps = 32
                Exit Select
            Case 2
                surfaceSeries1.PaletteStyle = Steema.TeeChart.Styles.PaletteStyles.GrayScale
                surfaceSeries1.PaletteSteps = 32
                Exit Select
            Case 3
                surfaceSeries1.PaletteStyle = Steema.TeeChart.Styles.PaletteStyles.InvertedGray
                surfaceSeries1.PaletteSteps = 32
                Exit Select
            Case 4
                surfaceSeries1.PaletteStyle = Steema.TeeChart.Styles.PaletteStyles.Rainbow
                surfaceSeries1.PaletteSteps = 25
                Exit Select
        End Select
    End Sub 'comboBox1_SelectedIndexChanged
End Class 'Surface_Palette
