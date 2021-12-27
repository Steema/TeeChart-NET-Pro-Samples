
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing

Imports System.Windows.Forms




Public Class SeriesType_Surface
    Inherits Samples.BaseForm
    Private WithEvents surfaceSeries1 As Steema.TeeChart.Styles.Surface
    Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
    Private label1 As System.Windows.Forms.Label
    Private WithEvents comboBox1 As System.Windows.Forms.ComboBox
    Private WithEvents comboBox2 As System.Windows.Forms.ComboBox
    Private label2 As System.Windows.Forms.Label
    Private WithEvents numericUpDown1 As System.Windows.Forms.NumericUpDown
    Private WithEvents timer1 As System.Windows.Forms.Timer
    Private rotate1 As Steema.TeeChart.Tools.Rotate
    Private components As System.ComponentModel.IContainer = Nothing
    Private gridBand1 As Steema.TeeChart.Tools.GridBand
    
    Private r As Random
    
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        r = New Random()
        surfaceSeries1.FillSampleValues(30)
        Me.numericUpDown1.Value = 1
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
        Me.components = New System.ComponentModel.Container
        Me.surfaceSeries1 = New Steema.TeeChart.Styles.Surface
        Me.checkBox1 = New System.Windows.Forms.CheckBox
        Me.label1 = New System.Windows.Forms.Label
        Me.comboBox1 = New System.Windows.Forms.ComboBox
        Me.comboBox2 = New System.Windows.Forms.ComboBox
        Me.label2 = New System.Windows.Forms.Label
        Me.numericUpDown1 = New System.Windows.Forms.NumericUpDown
        Me.timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.rotate1 = New Steema.TeeChart.Tools.Rotate
        Me.gridBand1 = New Steema.TeeChart.Tools.GridBand
        Me.panel1.SuspendLayout()
        CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(399, 56)
        Me.textBox1.TabIndex = 0
        Me.textBox1.Text = "Surface displays a grid of XYZ floating point values." + vbCr + vbLf + "Options include palette, b" + "order, pattern, null values, wire-frame, dots, surface sides, marks, gradients, " + "inverted axes, etc." + vbCr + vbLf + vbCr + vbLf + "Things to try: Click and drag mouse to rotate chart."
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.numericUpDown1)
        Me.panel1.Controls.Add(Me.label2)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Controls.Add(Me.comboBox2)
        Me.panel1.Controls.Add(Me.comboBox1)
        Me.panel1.Controls.Add(Me.checkBox1)
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
        Me.tChart1.Aspect.Elevation = 348
        Me.tChart1.Aspect.Orthogonal = False
        Me.tChart1.Aspect.Perspective = 62
        Me.tChart1.Aspect.Rotation = 329
        Me.tChart1.Aspect.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality
        Me.tChart1.Aspect.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        Me.tChart1.Aspect.VertOffset = -20
        Me.tChart1.Aspect.Zoom = 66
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
        Me.tChart1.Header.Lines = New String() {"tChart1"}
        ' 
        ' tChart1.Header.Shadow
        ' 
        Me.tChart1.Header.Shadow.Visible = False
        ' 
        ' tChart1.Legend
        ' 
        Me.tChart1.Legend.Alignment = Steema.TeeChart.LegendAlignments.Top
        ' 
        ' tChart1.Legend.Font
        ' 
        ' 
        ' tChart1.Legend.Font.Shadow
        ' 
        Me.tChart1.Legend.Font.Shadow.Visible = False
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
        Me.tChart1.Legend.Visible = False
        Me.tChart1.Location = New System.Drawing.Point(0, 91)
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Brush
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
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
        Me.tChart1.Tools.Add(Me.gridBand1)
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
        ' tChart1.Walls.Back.Gradient
        ' 
        Me.tChart1.Walls.Back.Brush.Gradient.Transparency = 40
        ' 
        ' tChart1.Walls.Back.Gradient
        ' 
        Me.tChart1.Walls.Back.Gradient.Transparency = 40
        ' 
        ' tChart1.Walls.Back.Pen
        ' 
        Me.tChart1.Walls.Back.Pen.Visible = False
        ' 
        ' tChart1.Walls.Back.Shadow
        ' 
        Me.tChart1.Walls.Back.Shadow.Visible = False
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
        Me.tChart1.Walls.Left.Brush.Color = System.Drawing.Color.FromArgb(CType(153, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(224, System.Byte))
        ' 
        ' tChart1.Walls.Left.Gradient
        ' 
        Me.tChart1.Walls.Left.Brush.Gradient.Transparency = 40
        ' 
        ' tChart1.Walls.Left.Gradient
        ' 
        Me.tChart1.Walls.Left.Gradient.Transparency = 40
        ' 
        ' tChart1.Walls.Left.Pen
        ' 
        Me.tChart1.Walls.Left.Pen.Visible = False
        ' 
        ' tChart1.Walls.Left.Shadow
        ' 
        Me.tChart1.Walls.Left.Shadow.Visible = False
        Me.tChart1.Walls.Left.Size = 5
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
        Me.surfaceSeries1.Title = "surface1"
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
        ' checkBox1
        ' 
        Me.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox1.Location = New System.Drawing.Point(8, 7)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(80, 21)
        Me.checkBox1.TabIndex = 0
        Me.checkBox1.Text = "&Animate"
        ' 
        ' label1
        ' 
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(175, 10)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(36, 16)
        Me.label1.TabIndex = 2
        Me.label1.Text = "&Style :"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        ' 
        ' comboBox1
        ' 
        Me.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboBox1.Items.AddRange(New Object() {"Single Color", "Color Range", "Color Palette", "Strong Palette", "Gray scale", "Inverted Gray", "Rainbow"})
        Me.comboBox1.Location = New System.Drawing.Point(78, 7)
        Me.comboBox1.Name = "comboBox1"
        Me.comboBox1.Size = New System.Drawing.Size(88, 21)
        Me.comboBox1.TabIndex = 1
        ' 
        ' comboBox2
        ' 
        Me.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboBox2.Items.AddRange(New Object() {"Solid and Grid", "Solid", "Wireframe", "Dots"})
        Me.comboBox2.Location = New System.Drawing.Point(212, 7)
        Me.comboBox2.Name = "comboBox2"
        Me.comboBox2.Size = New System.Drawing.Size(73, 21)
        Me.comboBox2.TabIndex = 3
        ' 
        ' label2
        ' 
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(295, 10)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(46, 16)
        Me.label2.TabIndex = 4
        Me.label2.Text = "Sample:"
        Me.label2.UseMnemonic = False
        ' 
        ' numericUpDown1
        ' 
        Me.numericUpDown1.Location = New System.Drawing.Point(348, 8)
        Me.numericUpDown1.Maximum = New System.Decimal(New Integer() {8, 0, 0, 0})
        Me.numericUpDown1.Minimum = New System.Decimal(New Integer() {1, 0, 0, 0})
        Me.numericUpDown1.Name = "numericUpDown1"
        Me.numericUpDown1.ReadOnly = True
        Me.numericUpDown1.Size = New System.Drawing.Size(40, 20)
        Me.numericUpDown1.TabIndex = 5
        Me.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numericUpDown1.Value = New System.Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' timer1
        ' 
        ' 
        ' gridBand1
        ' 
        Me.gridBand1.Axis = Me.tChart1.Axes.Left
        ' 
        ' gridBand1.Band1
        ' 
        Me.gridBand1.Band1.Color = System.Drawing.Color.FromArgb(CType(127, System.Byte), CType(192, System.Byte), CType(192, System.Byte), CType(192, System.Byte))
        ' 
        ' gridBand1.Band2
        ' 
        Me.gridBand1.Band2.Color = System.Drawing.Color.FromArgb(CType(127, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        ' 
        ' SeriesType_Surface
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(399, 256)
        Me.Name = "SeriesType_Surface"
        Me.panel1.ResumeLayout(False)
        CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
    End Sub 'InitializeComponent 
#End Region


    Private Sub SeriesType_Surface_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        comboBox1.SelectedIndex = 3
        comboBox2.SelectedIndex = 0
    End Sub 'SeriesType_Surface_Load


    Private Sub comboBox2_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboBox2.SelectedIndexChanged
        Select Case comboBox2.SelectedIndex
            Case 0
                surfaceSeries1.WireFrame = False
                surfaceSeries1.DotFrame = False
                surfaceSeries1.Pen.Visible = True
                Exit Select
            Case 1
                surfaceSeries1.WireFrame = False
                surfaceSeries1.DotFrame = False
                surfaceSeries1.Pen.Visible = False
                Exit Select
            Case 2
                surfaceSeries1.WireFrame = True
                surfaceSeries1.Pen.Visible = True
                Exit Select
            Case 3
                surfaceSeries1.DotFrame = True
        End Select
    End Sub 'comboBox2_SelectedIndexChanged


    Private Sub comboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboBox1.SelectedIndexChanged
        Select Case comboBox1.SelectedIndex
            Case 0
                surfaceSeries1.UseColorRange = False
                surfaceSeries1.UsePalette = False
                Exit Select
            Case 1
                surfaceSeries1.UseColorRange = True
                surfaceSeries1.UsePalette = False
                Exit Select
            Case 2
                surfaceSeries1.UseColorRange = False
                surfaceSeries1.UsePalette = True
                surfaceSeries1.PaletteStyle = Steema.TeeChart.Styles.PaletteStyles.Pale
                Exit Select
            Case 3
                surfaceSeries1.UseColorRange = False
                surfaceSeries1.UsePalette = True
                surfaceSeries1.PaletteStyle = Steema.TeeChart.Styles.PaletteStyles.Strong
                Exit Select
            Case 4
                surfaceSeries1.UseColorRange = False
                surfaceSeries1.UsePalette = True
                surfaceSeries1.PaletteStyle = Steema.TeeChart.Styles.PaletteStyles.GrayScale
                Exit Select
            Case 5
                surfaceSeries1.UseColorRange = False
                surfaceSeries1.UsePalette = True
                surfaceSeries1.PaletteStyle = Steema.TeeChart.Styles.PaletteStyles.InvertedGray
                Exit Select
            Case 6
                surfaceSeries1.UseColorRange = False
                surfaceSeries1.UsePalette = True
                surfaceSeries1.PaletteStyle = Steema.TeeChart.Styles.PaletteStyles.Rainbow
                Exit Select
        End Select
    End Sub 'comboBox1_SelectedIndexChanged


    Private Sub surfaceSeries1_GetYValue(ByVal sender As Steema.TeeChart.Styles.Series, ByVal e As Steema.TeeChart.Styles.Custom3DGrid.GetYValueEventArgs) Handles surfaceSeries1.GetYValue
        Dim piPortion As Double = Math.PI / Me.surfaceSeries1.NumXValues
        Const halfPI As Double = Math.PI * 0.5
        Dim tmpX As Double = e.X * piPortion
        Dim tmpZ As Double = e.Z * piPortion
        ' sample surfaces...
        Select Case Fix(Me.numericUpDown1.Value)
            Case 1
                e.Value = ((0.5 * Math.Pow(Math.Cos((e.X / (Me.surfaceSeries1.NumXValues * 0.2))), 2)) _
                          + (Math.Pow(Math.Cos((e.Z / (Me.surfaceSeries1.NumXValues * 0.2))), 2) - Math.Cos((e.Z _
                          / (Me.surfaceSeries1.NumXValues * 0.5)))))
                Exit Select
            Case 2
                e.Value = (Math.Pow(Math.Cos(tmpX), 2) * Math.Pow(Math.Sin(tmpZ), 2))
                Exit Select
            Case 3
                e.Value = (Math.Cos((tmpX * tmpX)) + Math.Sin((tmpZ * tmpZ)))
                Exit Select
            Case 4
                e.Value = (Math.Pow(Math.Cos(tmpX), 2) + Math.Pow(Math.Sin(tmpZ), 2))
                Exit Select
            Case 5
                e.Value = ((tmpX * -1) + (Math.Pow(tmpZ, 2) * Math.Sin((tmpX * tmpZ))))
                Exit Select
            Case 6
                e.Value = Math.Sqrt(((tmpX * tmpX)  + (tmpZ * tmpZ)))
                Exit Select
            Case 7
                e.Value = (Math.Cos(Math.Abs((tmpX - halfPI))) * Math.Sin(tmpZ))
                Exit Select
            Case 8
                e.Value = Math.Cos((Math.Abs((tmpX - halfPI)) * Math.Abs((tmpZ - halfPI))))
                Exit Select
        End Select
    End Sub 'surfaceSeries1_GetYValue


    Private Sub numericUpDown1_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles numericUpDown1.ValueChanged
        Me.surfaceSeries1.Clear()
        Me.surfaceSeries1.CreateValues(Me.surfaceSeries1.NumXValues, Me.surfaceSeries1.NumZValues)
    End Sub 'numericUpDown1_ValueChanged


    Private Sub timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles timer1.Tick
        Me.timer1.Stop() ' stop animation timer
        ' Invert Left axis randomly
        If r.Next(100) < 2 Then
            Me.tChart1.Axes.Left.Inverted = Not Me.tChart1.Axes.Left.Inverted
        End If ' Invert Bottom axis randomly
        If r.Next(100) < 2 Then
            Me.tChart1.Axes.Bottom.Inverted = Not Me.tChart1.Axes.Bottom.Inverted
        End If ' Invert Depth axis randomly
        If r.Next(100) < 2 Then
            Me.tChart1.Axes.Depth.Inverted = Not Me.tChart1.Axes.Depth.Inverted
        End If
        ' Change Color Mode (Single, Range, Palette or Grayscale) randomly
        If r.Next(100) < 2 Then
            If Me.comboBox1.SelectedIndex < Me.comboBox1.Items.Count - 2 Then
                Me.comboBox1.SelectedIndex += 1
            Else
                Me.comboBox1.SelectedIndex = 0
            End If
            Me.comboBox1_SelectedIndexChanged(Me.comboBox1, New System.EventArgs)
        End If

        ' Change Surface Example:
        If Me.numericUpDown1.Value < Me.numericUpDown1.Maximum Then
            Me.numericUpDown1.Value += 1
        Else
            Me.numericUpDown1.Value = Me.numericUpDown1.Minimum
        End If
        Me.timer1.Start() '  re-start animation timer
    End Sub 'timer1_Tick


    Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox1.CheckedChanged
        Me.timer1.Enabled = Me.checkBox1.Checked
    End Sub 'checkBox1_CheckedChanged
End Class 'SeriesType_Surface
