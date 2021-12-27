
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing

Imports System.Windows.Forms




Public Class Donut_Series
    Inherits Samples.BaseForm
    Private label1 As System.Windows.Forms.Label
    Private WithEvents numericUpDown1 As System.Windows.Forms.NumericUpDown
    Private donutSeries1 As Steema.TeeChart.Styles.Donut
    Private components As System.ComponentModel.IContainer = Nothing
    
    
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        
        Me.donutSeries1.FillSampleValues(8)
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
        Me.label1 = New System.Windows.Forms.Label
        Me.numericUpDown1 = New System.Windows.Forms.NumericUpDown
        Me.donutSeries1 = New Steema.TeeChart.Styles.Donut
        Me.panel1.SuspendLayout()
        CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tChart1
        '
        '
        'tChart1.Aspect
        '
        Me.tChart1.Aspect.Chart3DPercent = 20
        Me.tChart1.Aspect.Elevation = 315
        Me.tChart1.Aspect.ElevationFloat = 315
        Me.tChart1.Aspect.Orthogonal = False
        Me.tChart1.Aspect.Perspective = 0
        Me.tChart1.Aspect.Rotation = 360
        Me.tChart1.Aspect.RotationFloat = 360
        Me.tChart1.Aspect.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality
        Me.tChart1.Aspect.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
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
        Me.tChart1.Cursor = System.Windows.Forms.Cursors.Default
        '
        'tChart1.Header
        '
        Me.tChart1.Header.Lines = New String() {"tChart1"}
        Me.tChart1.Header.Visible = False
        '
        'tChart1.Legend
        '
        '
        'tChart1.Legend.Pen
        '
        Me.tChart1.Legend.Pen.Visible = False
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
        Me.tChart1.Location = New System.Drawing.Point(0, 104)
        Me.tChart1.Name = "tChart1"
        '
        'tChart1.Panel
        '
        '
        'tChart1.Panel.Brush
        '
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(254, Byte), CType(255, Byte), CType(255, Byte), CType(255, Byte))
        '
        'tChart1.Panel.Gradient
        '
        Me.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(127, Byte), CType(255, Byte), CType(215, Byte), CType(0, Byte))
        Me.tChart1.Panel.Brush.Gradient.Visible = True
        '
        'tChart1.Panel.Gradient
        '
        Me.tChart1.Panel.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(127, Byte), CType(255, Byte), CType(215, Byte), CType(0, Byte))
        Me.tChart1.Panel.Gradient.Visible = True
        Me.tChart1.Series.Add(Me.donutSeries1)
        Me.tChart1.Size = New System.Drawing.Size(466, 182)
        '
        'tChart1.Walls
        '
        '
        'tChart1.Walls.Back
        '
        Me.tChart1.Walls.Back.AutoHide = False
        '
        'tChart1.Walls.Back.Brush
        '
        Me.tChart1.Walls.Back.Brush.Color = System.Drawing.Color.FromArgb(CType(254, Byte), CType(255, Byte), CType(255, Byte), CType(255, Byte))
        '
        'tChart1.Walls.Bottom
        '
        Me.tChart1.Walls.Bottom.AutoHide = False
        '
        'tChart1.Walls.Left
        '
        Me.tChart1.Walls.Left.AutoHide = False
        '
        'tChart1.Walls.Right
        '
        Me.tChart1.Walls.Right.AutoHide = False
        '
        'textBox1
        '
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(466, 73)
        Me.textBox1.Text = ("Donut series draws points very similar to Pie series, with a middle hole. The hol" + ("e dimensions can be configured as percent of circle radius." & vbCrLf & vbCrLf & "Example: donutSer" + "ies1.DonutPercent =75;"))
        '
        'panel1
        '
        Me.panel1.Controls.Add(Me.numericUpDown1)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(466, 31)
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(13, 8)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(41, 16)
        Me.label1.TabIndex = 0
        Me.label1.Text = "&Hole %"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'numericUpDown1
        '
        Me.numericUpDown1.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        Me.numericUpDown1.Location = New System.Drawing.Point(67, 6)
        Me.numericUpDown1.Name = "numericUpDown1"
        Me.numericUpDown1.Size = New System.Drawing.Size(53, 20)
        Me.numericUpDown1.TabIndex = 1
        Me.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numericUpDown1.Value = New Decimal(New Integer() {50, 0, 0, 0})
        '
        'donutSeries1
        '
        '
        'donutSeries1.Brush
        '
        Me.donutSeries1.Brush.Color = System.Drawing.Color.Red
        Me.donutSeries1.LabelMember = "Labels"
        '
        'donutSeries1.Marks
        '
        '
        'donutSeries1.Marks.Callout
        '
        Me.donutSeries1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None
        Me.donutSeries1.Marks.Callout.ArrowHeadSize = 8
        '
        'donutSeries1.Marks.Callout.Brush
        '
        Me.donutSeries1.Marks.Callout.Brush.Color = System.Drawing.Color.Black
        Me.donutSeries1.Marks.Callout.Distance = 0
        Me.donutSeries1.Marks.Callout.Draw3D = False
        Me.donutSeries1.Marks.Callout.Length = 8
        Me.donutSeries1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        '
        'donutSeries1.Marks.Shadow
        '
        Me.donutSeries1.Marks.Shadow.Visible = True
        '
        'donutSeries1.Marks.Symbol
        '
        '
        'donutSeries1.Marks.Symbol.Shadow
        '
        Me.donutSeries1.Marks.Symbol.Shadow.Visible = True
        '
        'donutSeries1.Pen
        '
        Me.donutSeries1.Pen.Color = System.Drawing.Color.FromArgb(CType(254, Byte), CType(64, Byte), CType(64, Byte), CType(64, Byte))
        '
        'donutSeries1.Shadow
        '
        Me.donutSeries1.Shadow.Height = 20
        Me.donutSeries1.Shadow.Width = 20
        Me.donutSeries1.Title = "donutSeries1"
        '
        'donutSeries1.XValues
        '
        Me.donutSeries1.XValues.DataMember = "Angle"
        Me.donutSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        '
        'donutSeries1.YValues
        '
        Me.donutSeries1.YValues.DataMember = "Pie"
        '
        'Donut_Series
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(466, 286)
        Me.Name = "Donut_Series"
        Me.panel1.ResumeLayout(False)
        CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub 'InitializeComponent 
#End Region


    Private Sub numericUpDown1_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles numericUpDown1.TextChanged, numericUpDown1.ValueChanged
        Me.donutSeries1.DonutPercent = Fix(numericUpDown1.Value)
    End Sub 'numericUpDown1_ValueChanged
End Class 'Donut_Series
