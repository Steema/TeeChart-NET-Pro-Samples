
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms


Public Class Tool_AnnotationCallout
    Inherits Steema.TeeChart.Samples.BaseForm
    Private buttonPen1 As Steema.TeeChart.ButtonPen
    Private checkBox1 As System.Windows.Forms.CheckBox
    Private button1 As System.Windows.Forms.Button
    Private points1 As Steema.TeeChart.Styles.Points
    Private annotation1 As Steema.TeeChart.Tools.Annotation
    Private components As System.ComponentModel.IContainer = Nothing
    
    Public Sub New() ' This call is required by the Windows Form Designer.
        InitializeComponent()

        points1.FillSampleValues()

        annotation1.Callout.Visible = True
        annotation1.Callout.Arrow.Visible = True

        buttonPen1.Pen = annotation1.Callout.Arrow
    End Sub


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
        Me.buttonPen1 = New Steema.TeeChart.ButtonPen
        Me.checkBox1 = New System.Windows.Forms.CheckBox
        Me.button1 = New System.Windows.Forms.Button
        Me.points1 = New Steema.TeeChart.Styles.Points
        Me.annotation1 = New Steema.TeeChart.Tools.Annotation
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(360, 73)
        Me.textBox1.Text = "Annotations include a Callout object." + vbCr + vbLf + vbCr + vbLf + "This object is used to draw a line from " + "the annotation to any position in the chart."
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.button1)
        Me.panel1.Controls.Add(Me.checkBox1)
        Me.panel1.Controls.Add(Me.buttonPen1)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(360, 39)
        ' 
        ' tChart1
        ' 
        ' 
        ' tChart1.Aspect
        ' 
        Me.tChart1.Aspect.Chart3DPercent = 25
        Me.tChart1.Aspect.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality
        Me.tChart1.Aspect.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        Me.tChart1.Aspect.ZoomText = False
        Me.tChart1.Cursor = System.Windows.Forms.Cursors.Default
        ' 
        ' tChart1.Header
        ' 
        Me.tChart1.Header.Lines = New String() {"Annotation callout"}
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Brush
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        ' 
        ' tChart1.Panel.Gradient
        ' 
        Me.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(224, System.Byte), CType(224, System.Byte), CType(224, System.Byte))
        Me.tChart1.Panel.Brush.Gradient.Visible = True
        ' 
        ' tChart1.Panel.Gradient
        ' 
        Me.tChart1.Panel.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(224, System.Byte), CType(224, System.Byte), CType(224, System.Byte))
        Me.tChart1.Panel.Gradient.Visible = True
        Me.tChart1.Series.Add(Me.points1)
        Me.tChart1.Size = New System.Drawing.Size(360, 189)
        Me.tChart1.Tools.Add(Me.annotation1)
        ' 
        ' tChart1.Walls
        ' 
        ' 
        ' tChart1.Walls.Back
        ' 
        ' 
        ' tChart1.Walls.Back.Brush
        ' 
        Me.tChart1.Walls.Back.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(192, System.Byte), CType(192, System.Byte), CType(192, System.Byte))
        ' 
        ' tChart1.Walls.Bottom
        ' 
        ' 
        ' tChart1.Walls.Bottom.Pen
        ' 
        Me.tChart1.Walls.Bottom.Pen.Visible = False
        Me.tChart1.Walls.Bottom.Size = 5
        ' 
        ' tChart1.Walls.Left
        ' 
        ' 
        ' tChart1.Walls.Left.Brush
        ' 
        Me.tChart1.Walls.Left.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(128, System.Byte))
        ' 
        ' tChart1.Walls.Left.Pen
        ' 
        Me.tChart1.Walls.Left.Pen.Visible = False
        Me.tChart1.Walls.Left.Size = 5
        ' 
        ' tChart1.Walls.Right
        ' 
        ' 
        ' tChart1.Walls.Right.Brush
        ' 
        Me.tChart1.Walls.Right.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(224, System.Byte), CType(224, System.Byte), CType(224, System.Byte))
        AddHandler Me.tChart1.ClickSeries, AddressOf Me.tChart1_ClickSeries
        AddHandler Me.tChart1.MouseMove, AddressOf Me.tChart1_MouseMove
        ' 
        ' buttonPen1
        ' 
        Me.buttonPen1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonPen1.Location = New System.Drawing.Point(116, 8)
        Me.buttonPen1.Name = "buttonPen1"
        Me.buttonPen1.Size = New System.Drawing.Size(64, 24)
        Me.buttonPen1.TabIndex = 2
        Me.buttonPen1.Text = "Border..."
        ' 
        ' checkBox1
        ' 
        Me.checkBox1.Checked = True
        Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox1.Location = New System.Drawing.Point(196, 12)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(92, 16)
        Me.checkBox1.TabIndex = 3
        Me.checkBox1.Text = "Follow mouse"
        AddHandler Me.checkBox1.CheckedChanged, AddressOf Me.checkBox1_CheckedChanged
        ' 
        ' button1
        ' 
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.Location = New System.Drawing.Point(32, 8)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(64, 24)
        Me.button1.TabIndex = 1
        Me.button1.Text = "Edit..."
        AddHandler Me.button1.Click, AddressOf Me.button1_Click
        ' 
        ' points1
        ' 
        Me.points1.ColorEach = True
        ' 
        ' points1.Marks
        ' 
        ' 
        ' points1.Marks.Symbol
        ' 
        ' 
        ' points1.Marks.Symbol.Shadow
        ' 
        Me.points1.Marks.Symbol.Shadow.Height = 1
        Me.points1.Marks.Symbol.Shadow.Visible = True
        Me.points1.Marks.Symbol.Shadow.Width = 1
        ' 
        ' points1.Pointer
        ' 
        ' 
        ' points1.Pointer.Brush
        ' 
        Me.points1.Pointer.Brush.Color = System.Drawing.Color.FromArgb(CType(255, System.Byte), CType(255, System.Byte), CType(204, System.Byte))
        Me.points1.Pointer.Brush.ForegroundColor = System.Drawing.Color.Empty
        Me.points1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.points1.Title = "points1"
        ' 
        ' points1.XValues
        ' 
        Me.points1.XValues.DataMember = "X"
        Me.points1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' points1.YValues
        ' 
        Me.points1.YValues.DataMember = "Y"
        ' 
        ' annotation1
        ' 
        Me.annotation1.Cursor = System.Windows.Forms.Cursors.Default
        Me.annotation1.Left = 180
        ' 
        ' annotation1.Shape
        ' 
        Me.annotation1.Shape.Bottom = 42
        Me.annotation1.Shape.CustomPosition = True
        Me.annotation1.Shape.Left = 180
        Me.annotation1.Shape.Lines = New String() {" Move the mouse ! "}
        ' 
        ' annotation1.Shape.Pen
        ' 
        Me.annotation1.Shape.Pen.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(0, System.Byte), CType(0, System.Byte), CType(255, System.Byte))
        Me.annotation1.Shape.Right = 279
        ' 
        ' annotation1.Shape.Shadow
        ' 
        Me.annotation1.Shape.Shadow.Visible = True
        Me.annotation1.Shape.Top = 25
        Me.annotation1.Text = " Move the mouse ! "
        Me.annotation1.Top = 25
        ' 
        ' AnnotationCallout
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(360, 301)
        Me.Name = "AnnotationCallout"
        AddHandler Me.Load, AddressOf Me.AnnotationCallout_Load
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub
#End Region


    Private Sub AnnotationCallout_Load(ByVal sender As Object, ByVal e As System.EventArgs)
        ' force a first-time chart redrawing, to obtain valid
        ' coordinates (Series1.CalcYPos, etc).
        tChart1.Invalidate()

        tChart1.Aspect.Zoom = 100
        ' Start positioning annotation callout at point index 5
        SetCallout(5)
    End Sub 'AnnotationCallout_Load

    Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        If checkBox1.Checked Then
            tChart1.Text = "Move the mouse over points !"
            points1.Cursor = Cursors.Default
        Else
            tChart1.Text = "Click a point !"
            points1.Cursor = Cursors.Hand
        End If
    End Sub 'checkBox1_CheckedChanged


    Private Sub tChart1_ClickSeries(ByVal sender As Object, ByVal s As Steema.TeeChart.Styles.Series, ByVal valueIndex As Integer, ByVal e As System.Windows.Forms.MouseEventArgs)
        If Not checkBox1.Checked Then
            SetCallout(valueIndex)
        End If
    End Sub 'tChart1_ClickSeries

    Private Sub tChart1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If checkBox1.Checked Then ' follow mouse
            ' Locate nearest point to mouse...
            Dim tmp As Integer = NearestPoint(points1, e.X, e.Y)
            If tmp <> -1 Then
                SetCallout(tmp) ' set annotation callout
            End If
        End If
    End Sub 'tChart1_MouseMove

    Private Sub SetCallout(ByVal AIndex As Integer)
        ' Change annotation text
        annotation1.Text = "Point: " + AIndex.ToString() + vbCr + vbLf + "Value: " + points1.ValueMarkText(AIndex)

        ' Re-position annotation callout
        annotation1.Callout.XPosition = points1.CalcXPos(AIndex)
        annotation1.Callout.YPosition = points1.CalcYPos(AIndex)
        annotation1.Callout.ZPosition = 0
    End Sub 'SetCallout


    ' Returns Series point index that is nearest to xy position.
    Private Function NearestPoint(ByVal ASeries As Steema.TeeChart.Styles.Series, ByVal x As Integer, ByVal y As Integer) As Integer
        Dim diff As Integer = -1
        Dim res As Integer
        Dim tmpDiff As Integer
        Dim t As Integer
        Dim tmpX As Integer
        Dim tmpY As Integer
        res = -1
        t = 0
        Do While (t < ASeries.Count)
            tmpX = (ASeries.CalcXPos(t) - x)
            tmpY = (ASeries.CalcYPos(t) - y)
            tmpDiff = TeeChart.Utils.Round(Math.Sqrt((TeeChart.Utils.Sqr(tmpX) + TeeChart.Utils.Sqr(tmpY))))
            If ((diff = -1) OrElse (tmpDiff < diff)) Then
                diff = tmpDiff
                res = t
            End If
            t = (t + 1)
        Loop
        Return res
    End Function

    Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Editors.ChartEditor.ShowModal(tChart1.Chart, Editors.ChartEditorTabs.Tools)
    End Sub 'button1_Click
End Class 'Tool_AnnotationCallout