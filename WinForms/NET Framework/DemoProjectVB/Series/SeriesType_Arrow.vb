
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing


Imports System.Windows.Forms




Public Class SeriesType_Arrow
    Inherits Samples.BaseForm
    Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
    Private WithEvents checkBox2 As System.Windows.Forms.CheckBox
    Private WithEvents checkBox3 As System.Windows.Forms.CheckBox
    Private WithEvents timer1 As System.Windows.Forms.Timer
    Private arrowSeries1 As Steema.TeeChart.Styles.Arrow
    Private components As System.ComponentModel.IContainer = Nothing
    Private gridBand1 As Steema.TeeChart.Tools.GridBand
    
    Private r As Random
    
    
    Private Sub AddRandomArrows()
        Dim x0, y0, x1, y1 As Double
        arrowSeries1.Clear()
        Dim t As Integer
        For t = 1 To 39
            x0 = r.Next(1000)
            y0 = r.Next(1000)
            x1 = r.Next(300) - 150
            If x1 < 50 Then
                x1 = 50
            End If
            x1 += x0
            y1 = r.Next(300) - 150
            If y1 < 50 Then
                y1 = 50
            End If
            y1 += y0
            arrowSeries1.Add(x0, y0, x1, y1)
        Next t
    End Sub 'AddRandomArrows
     
    
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        
        r = New Random()
        
        ' first, setup tChart
        Dim asp As Steema.TeeChart.Drawing.Aspect = tChart1.Aspect
        asp.Orthogonal = False
        asp.Perspective = 55
        asp.Rotation = 341
        asp.Elevation = 353
        asp.Zoom = 93
        tChart1.Legend.Visible = False
        
        ' now the series
        arrowSeries1.ArrowWidth = 32
        arrowSeries1.ArrowHeight = 24
        arrowSeries1.ColorEach = True
        AddRandomArrows()
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
        Me.checkBox1 = New System.Windows.Forms.CheckBox
        Me.checkBox2 = New System.Windows.Forms.CheckBox
        Me.checkBox3 = New System.Windows.Forms.CheckBox
        Me.timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.arrowSeries1 = New Steema.TeeChart.Styles.Arrow
        Me.gridBand1 = New Steema.TeeChart.Tools.GridBand
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(466, 63)
        Me.textBox1.Text = "Each Arrow is represented as a point with Starting and  Ending coordinates. This " + "demo changes arrow positions randomly."
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.checkBox3)
        Me.panel1.Controls.Add(Me.checkBox2)
        Me.panel1.Controls.Add(Me.checkBox1)
        Me.panel1.Location = New System.Drawing.Point(0, 63)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(466, 33)
        ' 
        ' tChart1
        ' 
        ' 
        ' tChart1.Aspect
        ' 
        Me.tChart1.Aspect.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality
        Me.tChart1.Aspect.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        ' 
        ' tChart1.Header
        ' 
        ' 
        ' tChart1.Header.Font
        ' 
        ' 
        ' tChart1.Header.Font.Brush
        ' 
        Me.tChart1.Header.Font.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(64, System.Byte), CType(64, System.Byte), CType(0, System.Byte))
        Me.tChart1.Header.Lines = New String() {"tChart1"}
        ' 
        ' tChart1.Legend
        ' 
        Me.tChart1.Legend.Visible = False
        Me.tChart1.Location = New System.Drawing.Point(0, 96)
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Brush
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.tChart1.Series.Add(Me.arrowSeries1)
        Me.tChart1.Size = New System.Drawing.Size(466, 190)
        Me.tChart1.Tools.Add(Me.gridBand1)
        ' 
        ' tChart1.Walls
        ' 
        ' 
        ' tChart1.Walls.Back
        ' 
        Me.tChart1.Walls.Back.Visible = False
        ' 
        ' tChart1.Walls.Bottom
        ' 
        Me.tChart1.Walls.Bottom.Size = 5
        ' 
        ' tChart1.Walls.Left
        ' 
        Me.tChart1.Walls.Left.Size = 5
        ' 
        ' checkBox1
        ' 
        Me.checkBox1.Checked = True
        Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox1.Location = New System.Drawing.Point(16, 8)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(91, 21)
        Me.checkBox1.TabIndex = 0
        Me.checkBox1.Text = "&Color each"
        ' 
        ' checkBox2
        ' 
        Me.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox2.Location = New System.Drawing.Point(112, 8)
        Me.checkBox2.Name = "checkBox2"
        Me.checkBox2.Size = New System.Drawing.Size(66, 21)
        Me.checkBox2.TabIndex = 1
        Me.checkBox2.Text = "&Animate"
        ' 
        ' checkBox3
        ' 
        Me.checkBox3.Checked = True
        Me.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox3.Location = New System.Drawing.Point(184, 8)
        Me.checkBox3.Name = "checkBox3"
        Me.checkBox3.Size = New System.Drawing.Size(40, 21)
        Me.checkBox3.TabIndex = 2
        Me.checkBox3.Text = "&3D"
        ' 
        ' timer1
        ' 
        Me.timer1.Interval = 50
        ' 
        ' arrowSeries1
        ' 
        Me.arrowSeries1.HorizAxis = Steema.TeeChart.Styles.HorizontalAxis.Both
        Me.arrowSeries1.LabelMember = "Labels"
        ' 
        ' arrowSeries1.Marks
        ' 
        ' 
        ' arrowSeries1.Marks.Pen
        ' 
        Me.arrowSeries1.Marks.Pen.Visible = False
        ' 
        ' arrowSeries1.Marks.Symbol
        ' 
        ' 
        ' arrowSeries1.Marks.Symbol.Shadow
        ' 
        Me.arrowSeries1.Marks.Symbol.Shadow.Height = 1
        Me.arrowSeries1.Marks.Symbol.Shadow.Visible = True
        Me.arrowSeries1.Marks.Symbol.Shadow.Width = 1
        Me.arrowSeries1.Marks.Transparent = True
        ' 
        ' arrowSeries1.Pointer
        ' 
        ' 
        ' arrowSeries1.Pointer.Brush
        ' 
        Me.arrowSeries1.Pointer.Brush.Color = System.Drawing.Color.Red
        Me.arrowSeries1.Pointer.InflateMargins = False
        ' 
        ' arrowSeries1.Pointer.Pen
        ' 
        Me.arrowSeries1.Pointer.Pen.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(64, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        Me.arrowSeries1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.arrowSeries1.StartXValues = Me.arrowSeries1.XValues
        Me.arrowSeries1.StartYValues = Me.arrowSeries1.YValues
        Me.arrowSeries1.Title = "arrow1"
        Me.arrowSeries1.VertAxis = Steema.TeeChart.Styles.VerticalAxis.Both
        ' 
        ' arrowSeries1.XValues
        ' 
        Me.arrowSeries1.XValues.DataMember = "X"
        Me.arrowSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' arrowSeries1.YValues
        ' 
        Me.arrowSeries1.YValues.DataMember = "Y"
        ' 
        ' gridBand1
        ' 
        Me.gridBand1.Axis = Me.tChart1.Axes.Left
        ' 
        ' gridBand1.Band1
        ' 
        Me.gridBand1.Band1.Color = System.Drawing.Color.FromArgb(CType(102, System.Byte), CType(192, System.Byte), CType(192, System.Byte), CType(255, System.Byte))
        ' 
        ' gridBand1.Band2
        ' 
        Me.gridBand1.Band2.Color = System.Drawing.Color.FromArgb(CType(25, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        ' 
        ' SeriesType_Arrow
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(466, 286)
        Me.Name = "SeriesType_Arrow"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub 'InitializeComponent 
#End Region


    Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox1.CheckedChanged
        arrowSeries1.ColorEach = checkBox1.Checked
    End Sub 'checkBox1_CheckedChanged


    Private Sub checkBox3_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox3.CheckedChanged
        tChart1.Aspect.View3D = checkBox3.Checked
    End Sub 'checkBox3_CheckedChanged


    Private Sub checkBox2_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox2.CheckedChanged
        timer1.Enabled = checkBox2.Checked
    End Sub 'checkBox2_CheckedChanged


    Private Sub timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles timer1.Tick
        timer1.Stop()
        Dim t As Integer
        For t = 0 To arrowSeries1.Count - 1
            arrowSeries1.StartXValues(t) = arrowSeries1.StartXValues(t) + r.Next(100) - 50
            arrowSeries1.StartYValues(t) = arrowSeries1.StartYValues(t) + r.Next(100) - 50
            arrowSeries1.EndXValues(t) = arrowSeries1.EndXValues(t) + r.Next(100) - 50
            arrowSeries1.EndYValues(t) = arrowSeries1.EndYValues(t) + r.Next(100) - 50
        Next t
        arrowSeries1.Repaint()

        timer1.Start()
    End Sub 'timer1_Tick
End Class 'SeriesType_Arrow
