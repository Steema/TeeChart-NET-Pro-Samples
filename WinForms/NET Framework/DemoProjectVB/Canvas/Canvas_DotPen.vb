
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing

Imports System.Windows.Forms




Public Class Canvas_DotPen
    Inherits Samples.BaseForm
    Private fastLineSeries1 As Steema.TeeChart.Styles.FastLine
    Private fastLineSeries2 As Steema.TeeChart.Styles.FastLine
    Private fastLineSeries3 As Steema.TeeChart.Styles.FastLine
    Private fastLineSeries4 As Steema.TeeChart.Styles.FastLine
    Private label1 As System.Windows.Forms.Label
    Private WithEvents numericUpDown1 As System.Windows.Forms.NumericUpDown
    Private components As System.ComponentModel.IContainer = Nothing
    
    
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        
        For Each s As Steema.TeeChart.Styles.Series In tChart1.Series
            s.FillSampleValues(10)
        Next s
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
        Me.fastLineSeries1 = New Steema.TeeChart.Styles.FastLine
        Me.fastLineSeries2 = New Steema.TeeChart.Styles.FastLine
        Me.fastLineSeries3 = New Steema.TeeChart.Styles.FastLine
        Me.fastLineSeries4 = New Steema.TeeChart.Styles.FastLine
        Me.label1 = New System.Windows.Forms.Label
        Me.numericUpDown1 = New System.Windows.Forms.NumericUpDown
        Me.panel1.SuspendLayout()
        CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'textBox1
        '
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(466, 64)
        Me.textBox1.Text = "Lines with dotted styles can draw widths bigger than 1." & vbCr & vbLf & vbCr & vbLf & "lineSeries1.LinePen.Style = System.Drawing.Drawing2D.DashStyle.Dot" & vbCr & vbLf & "lineSeries1.LinePen.Width = 3"
        '
        'panel1
        '
        Me.panel1.Controls.Add(Me.numericUpDown1)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Location = New System.Drawing.Point(0, 64)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(466, 33)
        '
        'tChart1
        '
        '
        'tChart1.Aspect
        '
        Me.tChart1.Aspect.ElevationFloat = 345
        Me.tChart1.Aspect.RotationFloat = 345
        Me.tChart1.Aspect.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality
        Me.tChart1.Aspect.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        Me.tChart1.Aspect.View3D = False
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
        Me.tChart1.Location = New System.Drawing.Point(0, 97)
        Me.tChart1.Name = "tChart1"
        '
        'tChart1.Panel
        '
        '
        'tChart1.Panel.Bevel
        '
        Me.tChart1.Panel.Bevel.ColorTwo = System.Drawing.Color.FromArgb(CType(254, Byte), CType(255, Byte), CType(255, Byte), CType(255, Byte))
        '
        'tChart1.Panel.Brush
        '
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(254, Byte), CType(192, Byte), CType(192, Byte), CType(255, Byte))
        Me.tChart1.Series.Add(Me.fastLineSeries1)
        Me.tChart1.Series.Add(Me.fastLineSeries2)
        Me.tChart1.Series.Add(Me.fastLineSeries3)
        Me.tChart1.Series.Add(Me.fastLineSeries4)
        Me.tChart1.Size = New System.Drawing.Size(466, 189)
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
        Me.tChart1.Walls.Back.Transparent = False
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
        'fastLineSeries1
        '
        '
        'fastLineSeries1.LinePen
        '
        Me.fastLineSeries1.LinePen.Color = System.Drawing.Color.Red
        Me.fastLineSeries1.LinePen.Style = System.Drawing.Drawing2D.DashStyle.DashDot
        Me.fastLineSeries1.LinePen.Width = 2
        '
        'fastLineSeries1.Marks
        '
        '
        'fastLineSeries1.Marks.Callout
        '
        Me.fastLineSeries1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None
        Me.fastLineSeries1.Marks.Callout.ArrowHeadSize = 8
        '
        'fastLineSeries1.Marks.Callout.Brush
        '
        Me.fastLineSeries1.Marks.Callout.Brush.Color = System.Drawing.Color.Black
        Me.fastLineSeries1.Marks.Callout.Distance = 0
        Me.fastLineSeries1.Marks.Callout.Draw3D = False
        Me.fastLineSeries1.Marks.Callout.Length = 10
        Me.fastLineSeries1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        '
        'fastLineSeries1.Marks.Shadow
        '
        Me.fastLineSeries1.Marks.Shadow.Visible = True
        '
        'fastLineSeries1.Marks.Symbol
        '
        '
        'fastLineSeries1.Marks.Symbol.Shadow
        '
        Me.fastLineSeries1.Marks.Symbol.Shadow.Visible = True
        Me.fastLineSeries1.Title = "fastLineSeries1"
        '
        'fastLineSeries1.XValues
        '
        Me.fastLineSeries1.XValues.DataMember = "X"
        Me.fastLineSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        '
        'fastLineSeries1.YValues
        '
        Me.fastLineSeries1.YValues.DataMember = "Y"
        '
        'fastLineSeries2
        '
        '
        'fastLineSeries2.LinePen
        '
        Me.fastLineSeries2.LinePen.Color = System.Drawing.Color.Green
        Me.fastLineSeries2.LinePen.Style = System.Drawing.Drawing2D.DashStyle.Dash
        Me.fastLineSeries2.LinePen.Width = 2
        '
        'fastLineSeries2.Marks
        '
        '
        'fastLineSeries2.Marks.Callout
        '
        Me.fastLineSeries2.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None
        Me.fastLineSeries2.Marks.Callout.ArrowHeadSize = 8
        '
        'fastLineSeries2.Marks.Callout.Brush
        '
        Me.fastLineSeries2.Marks.Callout.Brush.Color = System.Drawing.Color.Black
        Me.fastLineSeries2.Marks.Callout.Distance = 0
        Me.fastLineSeries2.Marks.Callout.Draw3D = False
        Me.fastLineSeries2.Marks.Callout.Length = 10
        Me.fastLineSeries2.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        '
        'fastLineSeries2.Marks.Shadow
        '
        Me.fastLineSeries2.Marks.Shadow.Visible = True
        '
        'fastLineSeries2.Marks.Symbol
        '
        '
        'fastLineSeries2.Marks.Symbol.Shadow
        '
        Me.fastLineSeries2.Marks.Symbol.Shadow.Visible = True
        Me.fastLineSeries2.Title = "fastLineSeries2"
        '
        'fastLineSeries2.XValues
        '
        Me.fastLineSeries2.XValues.DataMember = "X"
        Me.fastLineSeries2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        '
        'fastLineSeries2.YValues
        '
        Me.fastLineSeries2.YValues.DataMember = "Y"
        '
        'fastLineSeries3
        '
        '
        'fastLineSeries3.LinePen
        '
        Me.fastLineSeries3.LinePen.Color = System.Drawing.Color.Yellow
        Me.fastLineSeries3.LinePen.Style = System.Drawing.Drawing2D.DashStyle.DashDotDot
        Me.fastLineSeries3.LinePen.Width = 2
        '
        'fastLineSeries3.Marks
        '
        '
        'fastLineSeries3.Marks.Callout
        '
        Me.fastLineSeries3.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None
        Me.fastLineSeries3.Marks.Callout.ArrowHeadSize = 8
        '
        'fastLineSeries3.Marks.Callout.Brush
        '
        Me.fastLineSeries3.Marks.Callout.Brush.Color = System.Drawing.Color.Black
        Me.fastLineSeries3.Marks.Callout.Distance = 0
        Me.fastLineSeries3.Marks.Callout.Draw3D = False
        Me.fastLineSeries3.Marks.Callout.Length = 10
        Me.fastLineSeries3.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        '
        'fastLineSeries3.Marks.Shadow
        '
        Me.fastLineSeries3.Marks.Shadow.Visible = True
        '
        'fastLineSeries3.Marks.Symbol
        '
        '
        'fastLineSeries3.Marks.Symbol.Shadow
        '
        Me.fastLineSeries3.Marks.Symbol.Shadow.Visible = True
        Me.fastLineSeries3.Title = "fastLineSeries3"
        '
        'fastLineSeries3.XValues
        '
        Me.fastLineSeries3.XValues.DataMember = "X"
        Me.fastLineSeries3.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        '
        'fastLineSeries3.YValues
        '
        Me.fastLineSeries3.YValues.DataMember = "Y"
        '
        'fastLineSeries4
        '
        '
        'fastLineSeries4.LinePen
        '
        Me.fastLineSeries4.LinePen.Color = System.Drawing.Color.Blue
        Me.fastLineSeries4.LinePen.Style = System.Drawing.Drawing2D.DashStyle.Dot
        Me.fastLineSeries4.LinePen.Width = 2
        '
        'fastLineSeries4.Marks
        '
        '
        'fastLineSeries4.Marks.Callout
        '
        Me.fastLineSeries4.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None
        Me.fastLineSeries4.Marks.Callout.ArrowHeadSize = 8
        '
        'fastLineSeries4.Marks.Callout.Brush
        '
        Me.fastLineSeries4.Marks.Callout.Brush.Color = System.Drawing.Color.Black
        Me.fastLineSeries4.Marks.Callout.Distance = 0
        Me.fastLineSeries4.Marks.Callout.Draw3D = False
        Me.fastLineSeries4.Marks.Callout.Length = 10
        Me.fastLineSeries4.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        '
        'fastLineSeries4.Marks.Shadow
        '
        Me.fastLineSeries4.Marks.Shadow.Visible = True
        '
        'fastLineSeries4.Marks.Symbol
        '
        '
        'fastLineSeries4.Marks.Symbol.Shadow
        '
        Me.fastLineSeries4.Marks.Symbol.Shadow.Visible = True
        Me.fastLineSeries4.Title = "fastLineSeries4"
        '
        'fastLineSeries4.XValues
        '
        Me.fastLineSeries4.XValues.DataMember = "X"
        Me.fastLineSeries4.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        '
        'fastLineSeries4.YValues
        '
        Me.fastLineSeries4.YValues.DataMember = "Y"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(13, 10)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(57, 16)
        Me.label1.TabIndex = 0
        Me.label1.Text = "&Pen width:"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'numericUpDown1
        '
        Me.numericUpDown1.Location = New System.Drawing.Point(72, 8)
        Me.numericUpDown1.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.numericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numericUpDown1.Name = "numericUpDown1"
        Me.numericUpDown1.Size = New System.Drawing.Size(47, 20)
        Me.numericUpDown1.TabIndex = 1
        Me.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numericUpDown1.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'Canvas_DotPen
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(466, 286)
        Me.Name = "Canvas_DotPen"
        Me.panel1.ResumeLayout(False)
        CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub 'InitializeComponent 
#End Region


    Private Sub numericUpDown1_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles numericUpDown1.TextChanged, numericUpDown1.ValueChanged
        For Each s As Steema.TeeChart.Styles.FastLine In tChart1.Series
            s.LinePen.Width = Fix(Me.numericUpDown1.Value)
        Next s
    End Sub 'numericUpDown1_ValueChanged
End Class 'Canvas_DotPen
