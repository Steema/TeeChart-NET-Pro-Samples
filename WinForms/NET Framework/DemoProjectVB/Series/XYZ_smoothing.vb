
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms


Public Class XYZ_smoothing
    Inherits Steema.TeeChart.Samples.BaseForm
    Private surface1 As Steema.TeeChart.Styles.Surface
    Private WithEvents button1 As System.Windows.Forms.Button
    Private label1 As System.Windows.Forms.Label
    Private rotate1 As Steema.TeeChart.Tools.Rotate
    Private gridBand1 As Steema.TeeChart.Tools.GridBand
    Private components As System.ComponentModel.IContainer = Nothing
    
    Public Sub New() ' This call is required by the Windows Form Designer.
        InitializeComponent()

        surface1.FillSampleValues(5)

        ' Remove surface grid lines (they disturb when the surface has lots of cells)
        surface1.Pen.Visible = False
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

#Region "Windows Form Designer generated code"

    '/ <summary>
    '/ Required method for Designer support - do not modify
    '/ the contents of this method with the code editor.
    '/ </summary>
    Private Sub InitializeComponent()
        Me.surface1 = New Steema.TeeChart.Styles.Surface
        Me.button1 = New System.Windows.Forms.Button
        Me.label1 = New System.Windows.Forms.Label
        Me.rotate1 = New Steema.TeeChart.Tools.Rotate
        Me.gridBand1 = New Steema.TeeChart.Tools.GridBand
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Text = "Surfaces (and any other ""grid 3D"" series like Tower, Contour, etc)" + _
        "that have a small number of cells can be smoothed using a simple linear algorithm" + _
        "that inserts new cells in between existing cells by interpolating values."
        '
        '
        'tChart1
        '
        '
        'tChart1.Aspect
        '
        Me.tChart1.Aspect.Chart3DPercent = 75
        Me.tChart1.Aspect.Elevation = 349
        Me.tChart1.Aspect.ElevationFloat = 349
        Me.tChart1.Aspect.Orthogonal = False
        Me.tChart1.Aspect.Perspective = 0
        Me.tChart1.Aspect.Rotation = 329
        Me.tChart1.Aspect.RotationFloat = 329
        Me.tChart1.Aspect.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality
        Me.tChart1.Aspect.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        Me.tChart1.Aspect.Zoom = 79
        '
        'tChart1.Axes
        '
        '
        'tChart1.Axes.Bottom
        '
        Me.tChart1.Axes.Bottom.Automatic = True
        '
        'tChart1.Axes.Bottom.Grid
        '
        Me.tChart1.Axes.Bottom.Grid.ZPosition = 0
        '
        'tChart1.Axes.Depth
        '
        Me.tChart1.Axes.Depth.Automatic = True
        '
        'tChart1.Axes.Depth.Grid
        '
        Me.tChart1.Axes.Depth.Grid.ZPosition = 0
        '
        'tChart1.Axes.DepthTop
        '
        Me.tChart1.Axes.DepthTop.Automatic = True
        '
        'tChart1.Axes.DepthTop.Grid
        '
        Me.tChart1.Axes.DepthTop.Grid.ZPosition = 0
        '
        'tChart1.Axes.Left
        '
        Me.tChart1.Axes.Left.Automatic = True
        '
        'tChart1.Axes.Left.Grid
        '
        Me.tChart1.Axes.Left.Grid.ZPosition = 0
        '
        'tChart1.Axes.Right
        '
        Me.tChart1.Axes.Right.Automatic = True
        '
        'tChart1.Axes.Right.Grid
        '
        Me.tChart1.Axes.Right.Grid.ZPosition = 0
        '
        'tChart1.Axes.Top
        '
        Me.tChart1.Axes.Top.Automatic = True
        '
        'tChart1.Axes.Top.Grid
        '
        Me.tChart1.Axes.Top.Grid.ZPosition = 0
        '
        'tChart1.Header
        '
        Me.tChart1.Header.Lines = New String() {"tChart1"}
        '
        'tChart1.Legend
        '
        Me.tChart1.Legend.MaxNumRows = 8
        '
        'tChart1.Legend.Shadow
        '
        Me.tChart1.Legend.Shadow.Visible = True
        '
        'tChart1.Legend.Title
        '
        '
        'tChart1.Legend.Title.Font
        '
        Me.tChart1.Legend.Title.Font.Bold = True
        '
        'tChart1.Legend.Title.Pen
        '
        Me.tChart1.Legend.Title.Pen.Visible = False
        Me.tChart1.Location = New System.Drawing.Point(0, 128)
        Me.tChart1.Name = "tChart1"
        '
        'tChart1.Panel
        '
        '
        'tChart1.Panel.Brush
        '
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(254, Byte), CType(255, Byte), CType(255, Byte), CType(255, Byte))
        Me.tChart1.Series.Add(Me.surface1)
        Me.tChart1.Size = New System.Drawing.Size(440, 189)
        Me.tChart1.Tools.Add(Me.rotate1)
        Me.tChart1.Tools.Add(Me.gridBand1)
        '
        'tChart1.Walls
        '
        '
        'tChart1.Walls.Back
        '
        Me.tChart1.Walls.Back.AutoHide = False
        '
        'tChart1.Walls.Back.Pen
        '
        Me.tChart1.Walls.Back.Pen.Visible = False
        Me.tChart1.Walls.Back.Size = 5
        '
        'tChart1.Walls.Bottom
        '
        Me.tChart1.Walls.Bottom.AutoHide = False
        '
        'tChart1.Walls.Bottom.Brush
        '
        Me.tChart1.Walls.Bottom.Brush.Color = System.Drawing.Color.FromArgb(CType(178, Byte), CType(255, Byte), CType(255, Byte), CType(255, Byte))
        '
        'tChart1.Walls.Bottom.Gradient
        '
        Me.tChart1.Walls.Bottom.Brush.Gradient.Transparency = 30
        '
        'tChart1.Walls.Bottom.Gradient
        '
        Me.tChart1.Walls.Bottom.Gradient.Transparency = 30
        '
        'tChart1.Walls.Bottom.Pen
        '
        Me.tChart1.Walls.Bottom.Pen.Visible = False
        Me.tChart1.Walls.Bottom.Size = 5
        '
        'tChart1.Walls.Left
        '
        Me.tChart1.Walls.Left.AutoHide = False
        '
        'tChart1.Walls.Left.Brush
        '
        Me.tChart1.Walls.Left.Brush.Color = System.Drawing.Color.FromArgb(CType(178, Byte), CType(255, Byte), CType(255, Byte), CType(224, Byte))
        '
        'tChart1.Walls.Left.Gradient
        '
        Me.tChart1.Walls.Left.Brush.Gradient.Transparency = 30
        '
        'tChart1.Walls.Left.Gradient
        '
        Me.tChart1.Walls.Left.Gradient.Transparency = 30
        '
        'tChart1.Walls.Left.Pen
        '
        Me.tChart1.Walls.Left.Pen.Visible = False
        Me.tChart1.Walls.Left.Size = 5
        '
        'tChart1.Walls.Right
        '
        Me.tChart1.Walls.Right.AutoHide = False
        '
        'textBox1
        '
        Me.textBox1.Name = "textBox1"
        '
        'panel1
        '
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Controls.Add(Me.button1)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(440, 55)
        '
        'surface1
        '
        '
        'surface1.Brush
        '
        Me.surface1.Brush.Color = System.Drawing.Color.Red
        '
        'surface1.Marks
        '
        '
        'surface1.Marks.Callout
        '
        Me.surface1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None
        Me.surface1.Marks.Callout.ArrowHeadSize = 8
        '
        'surface1.Marks.Callout.Brush
        '
        Me.surface1.Marks.Callout.Brush.Color = System.Drawing.Color.Black
        Me.surface1.Marks.Callout.Distance = 0
        Me.surface1.Marks.Callout.Draw3D = False
        Me.surface1.Marks.Callout.Length = 10
        Me.surface1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        '
        'surface1.Marks.Shadow
        '
        Me.surface1.Marks.Shadow.Visible = True
        '
        'surface1.Marks.Symbol
        '
        '
        'surface1.Marks.Symbol.Shadow
        '
        Me.surface1.Marks.Symbol.Shadow.Visible = True
        Me.surface1.MidColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.surface1.PaletteMin = 0
        Me.surface1.PaletteStep = 0
        Me.surface1.StartColor = System.Drawing.Color.FromArgb(CType(254, Byte), CType(0, Byte), CType(128, Byte), CType(0, Byte))
        Me.surface1.Title = "surface1"
        Me.surface1.UseColorRange = False
        Me.surface1.UsePalette = True
        '
        'surface1.XValues
        '
        Me.surface1.XValues.DataMember = "X"
        '
        'surface1.YValues
        '
        Me.surface1.YValues.DataMember = "Y"
        '
        'surface1.ZValues
        '
        Me.surface1.ZValues.DataMember = "Z"
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(32, 16)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(144, 23)
        Me.button1.TabIndex = 0
        Me.button1.Text = "Smooth surface 2x"
        '
        'label1
        '
        Me.label1.Location = New System.Drawing.Point(224, 16)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(168, 23)
        Me.label1.TabIndex = 1
        Me.label1.Text = "Grid size : 5x5"
        '
        'gridBand1
        '
        Me.gridBand1.Axis = Me.tChart1.Axes.Left
        '
        'gridBand1.Band1
        '
        Me.gridBand1.Band1.Color = System.Drawing.Color.FromArgb(CType(127, Byte), CType(192, Byte), CType(192, Byte), CType(192, Byte))
        '
        'gridBand1.Band2
        '
        Me.gridBand1.Band2.Color = System.Drawing.Color.FromArgb(CType(127, Byte), CType(255, Byte), CType(255, Byte), CType(255, Byte))
        '
        'XYZ_smoothing
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(440, 317)
        Me.Name = "XYZ_smoothing"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
#End Region


    Private Sub button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button1.Click
        ' Smooth the surface !
        Grid3DUtils.SmoothGrid(surface1)
        ' Now re-calculate NumX and NumX to display at Label1.Caption
        surface1.FillGridIndex()
        ' Display new grid size at Label1
        label1.Text = ("Grid size : " _
                    + (surface1.NumXValues.ToString + (" x " + surface1.NumZValues.ToString)))
    End Sub
End Class 'XYZ_smoothing