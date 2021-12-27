
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing

Imports System.Windows.Forms




Public Class SeriesType_Bezier
    Inherits Samples.BaseForm
    Private bezierSeries1 As Steema.TeeChart.Styles.Bezier
    Private WithEvents button1 As System.Windows.Forms.Button
    Private gridBand1 As Steema.TeeChart.Tools.GridBand
    Private components As System.ComponentModel.IContainer = Nothing
    
    
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        
        Me.bezierSeries1.FillSampleValues(30)
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
        Me.bezierSeries1 = New Steema.TeeChart.Styles.Bezier
        Me.button1 = New System.Windows.Forms.Button
        Me.gridBand1 = New Steema.TeeChart.Tools.GridBand
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(466, 63)
        Me.textBox1.Text = "The Bezier series interpolates points into lines,  using the standard  3 or 4 poi" + _
            "nt Bezier algorithm." & vbCrLf & "The  BezierStyle property, in 2D or 3D modes, changes the " + _
            "way\'  points are interpolated."
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.button1)
        Me.panel1.Location = New System.Drawing.Point(0, 63)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(466, 34)
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
        Me.tChart1.BackColor = System.Drawing.Color.Transparent
        '
        'tChart1.Header
        '
        Me.tChart1.Header.Lines = New String() {"Bezier curves"}
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
        'tChart1.Panel.Brush
        '
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(254, Byte), CType(255, Byte), CType(255, Byte), CType(255, Byte))
        '
        'tChart1.Panel.Gradient
        '
        Me.tChart1.Panel.Brush.Gradient.Angle = 275
        Me.tChart1.Panel.Brush.Gradient.Direction = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(254, Byte), CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(254, Byte), CType(192, Byte), CType(192, Byte), CType(192, Byte))
        Me.tChart1.Panel.Brush.Gradient.UseMiddle = True
        Me.tChart1.Panel.Brush.Gradient.Visible = True
        '
        'tChart1.Panel.Gradient
        '
        Me.tChart1.Panel.Gradient.Angle = 275
        Me.tChart1.Panel.Gradient.Direction = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.tChart1.Panel.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(254, Byte), CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.tChart1.Panel.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(254, Byte), CType(192, Byte), CType(192, Byte), CType(192, Byte))
        Me.tChart1.Panel.Gradient.UseMiddle = True
        Me.tChart1.Panel.Gradient.Visible = True
        Me.tChart1.Series.Add(Me.bezierSeries1)
        Me.tChart1.Size = New System.Drawing.Size(466, 189)
        Me.tChart1.Tools.Add(Me.gridBand1)
        '
        'tChart1.Walls
        '
        '
        'tChart1.Walls.Back
        '
        Me.tChart1.Walls.Back.AutoHide = False
        '
        'tChart1.Walls.Bottom
        '
        Me.tChart1.Walls.Bottom.AutoHide = False
        '
        'tChart1.Walls.Bottom.Brush
        '
        Me.tChart1.Walls.Bottom.Brush.Color = System.Drawing.Color.FromArgb(CType(204, Byte), CType(255, Byte), CType(255, Byte), CType(255, Byte))
        '
        'tChart1.Walls.Bottom.Gradient
        '
        Me.tChart1.Walls.Bottom.Brush.Gradient.Transparency = 20
        '
        'tChart1.Walls.Bottom.Gradient
        '
        Me.tChart1.Walls.Bottom.Gradient.Transparency = 20
        '
        'tChart1.Walls.Bottom.Pen
        '
        Me.tChart1.Walls.Bottom.Pen.Visible = False
        Me.tChart1.Walls.Bottom.Size = 3
        '
        'tChart1.Walls.Left
        '
        Me.tChart1.Walls.Left.AutoHide = False
        '
        'tChart1.Walls.Left.Brush
        '
        Me.tChart1.Walls.Left.Brush.Color = System.Drawing.Color.FromArgb(CType(204, Byte), CType(255, Byte), CType(255, Byte), CType(255, Byte))
        '
        'tChart1.Walls.Left.Gradient
        '
        Me.tChart1.Walls.Left.Brush.Gradient.Transparency = 20
        '
        'tChart1.Walls.Left.Gradient
        '
        Me.tChart1.Walls.Left.Gradient.Transparency = 20
        '
        'tChart1.Walls.Left.Pen
        '
        Me.tChart1.Walls.Left.Pen.Visible = False
        Me.tChart1.Walls.Left.Size = 3
        '
        'tChart1.Walls.Right
        '
        Me.tChart1.Walls.Right.AutoHide = False
        '
        'textBox1
        '
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(466, 63)
        '
        'panel1
        '
        Me.panel1.Controls.Add(Me.button1)
        Me.panel1.Location = New System.Drawing.Point(0, 63)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(466, 34)
        '
        'bezierSeries1
        '
        '
        'bezierSeries1.Brush
        '
        Me.bezierSeries1.Brush.Color = System.Drawing.Color.Red
        Me.bezierSeries1.ColorEach = True
        '
        'bezierSeries1.LinePen
        '
        Me.bezierSeries1.LinePen.Color = System.Drawing.Color.Red
        '
        'bezierSeries1.Marks
        '
        '
        'bezierSeries1.Marks.Callout
        '
        Me.bezierSeries1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None
        Me.bezierSeries1.Marks.Callout.ArrowHeadSize = 8
        '
        'bezierSeries1.Marks.Callout.Brush
        '
        Me.bezierSeries1.Marks.Callout.Brush.Color = System.Drawing.Color.Black
        Me.bezierSeries1.Marks.Callout.Distance = 0
        Me.bezierSeries1.Marks.Callout.Draw3D = False
        Me.bezierSeries1.Marks.Callout.Length = 10
        Me.bezierSeries1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        '
        'bezierSeries1.Marks.Shadow
        '
        Me.bezierSeries1.Marks.Shadow.Visible = True
        '
        'bezierSeries1.Marks.Symbol
        '
        '
        'bezierSeries1.Marks.Symbol.Shadow
        '
        Me.bezierSeries1.Marks.Symbol.Shadow.Visible = True
        '
        'bezierSeries1.Pointer
        '
        '
        'bezierSeries1.Pointer.Brush
        '
        Me.bezierSeries1.Pointer.Brush.Color = System.Drawing.Color.FromArgb(CType(254, Byte), CType(255, Byte), CType(0, Byte), CType(0, Byte))
        Me.bezierSeries1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.bezierSeries1.Pointer.Visible = True
        Me.bezierSeries1.Title = "bezierSeries1"
        '
        'bezierSeries1.XValues
        '
        Me.bezierSeries1.XValues.DataMember = "X"
        Me.bezierSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        '
        'bezierSeries1.YValues
        '
        Me.bezierSeries1.YValues.DataMember = "Y"
        '
        'button1
        '
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.Location = New System.Drawing.Point(327, 7)
        Me.button1.Name = "button1"
        Me.button1.TabIndex = 4
        Me.button1.Text = "&Edit..."
        '
        'gridBand1
        '
        Me.gridBand1.Axis = Me.tChart1.Axes.Left
        '
        'gridBand1.Band1
        '
        Me.gridBand1.Band1.Color = System.Drawing.Color.FromArgb(CType(178, Byte), CType(224, Byte), CType(224, Byte), CType(224, Byte))
        '
        'gridBand1.Band2
        '
        Me.gridBand1.Band2.Color = System.Drawing.Color.FromArgb(CType(178, Byte), CType(255, Byte), CType(255, Byte), CType(255, Byte))
        '
        'SeriesType_Bezier
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(466, 286)
        Me.Name = "SeriesType_Bezier"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub 'InitializeComponent 
#End Region


    Private Sub comboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        ' TODO : add style selection code
    End Sub 'comboBox1_SelectedIndexChanged


    Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
        TeeChart.Editors.SeriesEditor.ShowEditor(Me.bezierSeries1)
    End Sub 'button1_Click
End Class 'SeriesType_Bezier
