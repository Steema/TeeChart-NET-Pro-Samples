
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing

Imports System.Windows.Forms




Public Class SeriesType_Point
    Inherits Samples.BaseForm
    Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
    Private WithEvents checkBox2 As System.Windows.Forms.CheckBox
    Private WithEvents timer1 As System.Windows.Forms.Timer
    Private pointSeries1 As Steema.TeeChart.Styles.Points
    Private pointSeries2 As Steema.TeeChart.Styles.Points
    Private pointSeries3 As Steema.TeeChart.Styles.Points
    Private pointSeries4 As Steema.TeeChart.Styles.Points
    Private pointSeries5 As Steema.TeeChart.Styles.Points
    Private pointSeries6 As Steema.TeeChart.Styles.Points
    Private components As System.ComponentModel.IContainer = Nothing
    Private gridBand1 As Steema.TeeChart.Tools.GridBand
    Private r As Random
    
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        For Each s As Steema.TeeChart.Styles.Series In tChart1.Series
            s.FillSampleValues(20)
        Next s
        r = New Random
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
        Me.timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.pointSeries1 = New Steema.TeeChart.Styles.Points
        Me.pointSeries2 = New Steema.TeeChart.Styles.Points
        Me.pointSeries3 = New Steema.TeeChart.Styles.Points
        Me.pointSeries4 = New Steema.TeeChart.Styles.Points
        Me.pointSeries5 = New Steema.TeeChart.Styles.Points
        Me.pointSeries6 = New Steema.TeeChart.Styles.Points
        Me.gridBand1 = New Steema.TeeChart.Tools.GridBand
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(466, 63)
        Me.textBox1.Text = "Point series displays XY values using a Pointer." + vbCr + vbLf + vbCr + vbLf + "Each pointer has many differe" + "nt properties, like color, 3D, shadow, style, marks, pattern, border, width, hei" + "ght, etc."
        ' 
        ' panel1
        ' 
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
        Me.tChart1.Aspect.Chart3DPercent = 35
        Me.tChart1.Aspect.Elevation = 350
        Me.tChart1.Aspect.Orthogonal = False
        Me.tChart1.Aspect.Perspective = 55
        Me.tChart1.Aspect.Rotation = 322
        Me.tChart1.Aspect.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality
        Me.tChart1.Aspect.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        Me.tChart1.Aspect.Zoom = 72
        ' 
        ' tChart1.Header
        ' 
        Me.tChart1.Header.Bottom = 26
        Me.tChart1.Header.CustomPosition = True
        ' 
        ' tChart1.Header.Font
        ' 
        Me.tChart1.Header.Font.Bold = True
        ' 
        ' tChart1.Header.Font.Brush
        ' 
        Me.tChart1.Header.Font.Brush.Color = System.Drawing.Color.Teal
        Me.tChart1.Header.Font.Size = 10
        Me.tChart1.Header.Left = 10
        Me.tChart1.Header.Lines = New String() {"Point series"}
        Me.tChart1.Header.Right = 110
        Me.tChart1.Header.Top = 9
        ' 
        ' tChart1.Legend
        ' 
        Me.tChart1.Legend.Alignment = Steema.TeeChart.LegendAlignments.Bottom
        ' 
        ' tChart1.Legend.Brush
        ' 
        Me.tChart1.Legend.Brush.Color = System.Drawing.Color.FromArgb(CType(192, System.Byte), CType(192, System.Byte), CType(192, System.Byte))
        ' 
        ' tChart1.Legend.Pen
        ' 
        Me.tChart1.Legend.Pen.Color = System.Drawing.Color.FromArgb(CType(255, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        ' 
        ' tChart1.Legend.Shadow
        ' 
        ' 
        ' tChart1.Legend.Shadow.Brush
        ' 
        Me.tChart1.Legend.Shadow.Brush.Color = System.Drawing.Color.FromArgb(CType(192, System.Byte), CType(192, System.Byte), CType(192, System.Byte))
        Me.tChart1.Legend.Shadow.Height = 4
        Me.tChart1.Legend.Shadow.Width = 4
        Me.tChart1.Location = New System.Drawing.Point(0, 96)
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Brush
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.tChart1.Series.Add(Me.pointSeries1)
        Me.tChart1.Series.Add(Me.pointSeries2)
        Me.tChart1.Series.Add(Me.pointSeries3)
        Me.tChart1.Series.Add(Me.pointSeries4)
        Me.tChart1.Series.Add(Me.pointSeries5)
        Me.tChart1.Series.Add(Me.pointSeries6)
        Me.tChart1.Size = New System.Drawing.Size(466, 190)
        Me.tChart1.Tools.Add(Me.gridBand1)
        ' 
        ' tChart1.Walls
        ' 
        ' 
        ' tChart1.Walls.Bottom
        ' 
        ' 
        ' tChart1.Walls.Bottom.Brush
        ' 
        Me.tChart1.Walls.Bottom.Brush.Color = System.Drawing.Color.FromArgb(CType(76, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        ' 
        ' tChart1.Walls.Bottom.Gradient
        ' 
        Me.tChart1.Walls.Bottom.Brush.Gradient.Transparency = 70
        ' 
        ' tChart1.Walls.Bottom.Gradient
        ' 
        Me.tChart1.Walls.Bottom.Gradient.Transparency = 70
        ' 
        ' tChart1.Walls.Bottom.Pen
        ' 
        Me.tChart1.Walls.Bottom.Pen.Visible = False
        Me.tChart1.Walls.Bottom.Size = 3
        ' 
        ' tChart1.Walls.Left
        ' 
        ' 
        ' tChart1.Walls.Left.Brush
        ' 
        Me.tChart1.Walls.Left.Brush.Color = System.Drawing.Color.FromArgb(CType(76, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(224, System.Byte))
        ' 
        ' tChart1.Walls.Left.Gradient
        ' 
        Me.tChart1.Walls.Left.Brush.Gradient.Transparency = 70
        ' 
        ' tChart1.Walls.Left.Gradient
        ' 
        Me.tChart1.Walls.Left.Gradient.Transparency = 70
        ' 
        ' tChart1.Walls.Left.Pen
        ' 
        Me.tChart1.Walls.Left.Pen.Visible = False
        Me.tChart1.Walls.Left.Size = 3
        ' 
        ' checkBox1
        ' 
        Me.checkBox1.Checked = True
        Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox1.Location = New System.Drawing.Point(16, 8)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(40, 21)
        Me.checkBox1.TabIndex = 0
        Me.checkBox1.Text = "&3D"
        ' 
        ' checkBox2
        ' 
        Me.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox2.Location = New System.Drawing.Point(93, 8)
        Me.checkBox2.Name = "checkBox2"
        Me.checkBox2.Size = New System.Drawing.Size(67, 21)
        Me.checkBox2.TabIndex = 1
        Me.checkBox2.Text = "&Animate"
        ' 
        ' timer1
        ' 
        Me.timer1.Interval = 1
        ' 
        ' pointSeries1
        ' 
        ' 
        ' pointSeries1.Marks
        ' 
        ' 
        ' pointSeries1.Marks.Symbol
        ' 
        ' 
        ' pointSeries1.Marks.Symbol.Shadow
        ' 
        Me.pointSeries1.Marks.Symbol.Shadow.Height = 1
        Me.pointSeries1.Marks.Symbol.Shadow.Visible = True
        Me.pointSeries1.Marks.Symbol.Shadow.Width = 1
        ' 
        ' pointSeries1.Pointer
        ' 
        ' 
        ' pointSeries1.Pointer.Brush
        ' 
        Me.pointSeries1.Pointer.Brush.Color = System.Drawing.Color.Red
        Me.pointSeries1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.pointSeries1.Title = "point6"
        ' 
        ' pointSeries1.XValues
        ' 
        Me.pointSeries1.XValues.DataMember = "X"
        Me.pointSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' pointSeries1.YValues
        ' 
        Me.pointSeries1.YValues.DataMember = "Y"
        ' 
        ' pointSeries2
        ' 
        ' 
        ' pointSeries2.Marks
        ' 
        ' 
        ' pointSeries2.Marks.Symbol
        ' 
        ' 
        ' pointSeries2.Marks.Symbol.Shadow
        ' 
        Me.pointSeries2.Marks.Symbol.Shadow.Height = 1
        Me.pointSeries2.Marks.Symbol.Shadow.Visible = True
        Me.pointSeries2.Marks.Symbol.Shadow.Width = 1
        ' 
        ' pointSeries2.Pointer
        ' 
        ' 
        ' pointSeries2.Pointer.Brush
        ' 
        Me.pointSeries2.Pointer.Brush.Color = System.Drawing.Color.Green
        Me.pointSeries2.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.pointSeries2.Title = "point6"
        ' 
        ' pointSeries2.XValues
        ' 
        Me.pointSeries2.XValues.DataMember = "X"
        Me.pointSeries2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' pointSeries2.YValues
        ' 
        Me.pointSeries2.YValues.DataMember = "Y"
        ' 
        ' pointSeries3
        ' 
        ' 
        ' pointSeries3.Marks
        ' 
        ' 
        ' pointSeries3.Marks.Symbol
        ' 
        ' 
        ' pointSeries3.Marks.Symbol.Shadow
        ' 
        Me.pointSeries3.Marks.Symbol.Shadow.Height = 1
        Me.pointSeries3.Marks.Symbol.Shadow.Visible = True
        Me.pointSeries3.Marks.Symbol.Shadow.Width = 1
        ' 
        ' pointSeries3.Pointer
        ' 
        ' 
        ' pointSeries3.Pointer.Brush
        ' 
        Me.pointSeries3.Pointer.Brush.Color = System.Drawing.Color.Yellow
        Me.pointSeries3.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.pointSeries3.Title = "point6"
        ' 
        ' pointSeries3.XValues
        ' 
        Me.pointSeries3.XValues.DataMember = "X"
        Me.pointSeries3.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' pointSeries3.YValues
        ' 
        Me.pointSeries3.YValues.DataMember = "Y"
        ' 
        ' pointSeries4
        ' 
        ' 
        ' pointSeries4.Marks
        ' 
        ' 
        ' pointSeries4.Marks.Symbol
        ' 
        ' 
        ' pointSeries4.Marks.Symbol.Shadow
        ' 
        Me.pointSeries4.Marks.Symbol.Shadow.Height = 1
        Me.pointSeries4.Marks.Symbol.Shadow.Visible = True
        Me.pointSeries4.Marks.Symbol.Shadow.Width = 1
        ' 
        ' pointSeries4.Pointer
        ' 
        ' 
        ' pointSeries4.Pointer.Brush
        ' 
        Me.pointSeries4.Pointer.Brush.Color = System.Drawing.Color.Blue
        Me.pointSeries4.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.pointSeries4.Title = "point6"
        ' 
        ' pointSeries4.XValues
        ' 
        Me.pointSeries4.XValues.DataMember = "X"
        Me.pointSeries4.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' pointSeries4.YValues
        ' 
        Me.pointSeries4.YValues.DataMember = "Y"
        ' 
        ' pointSeries5
        ' 
        ' 
        ' pointSeries5.LinePen
        ' 
        Me.pointSeries5.LinePen.Color = System.Drawing.Color.FromArgb(CType(153, System.Byte), CType(153, System.Byte), CType(122, System.Byte))
        ' 
        ' pointSeries5.Marks
        ' 
        ' 
        ' pointSeries5.Marks.Symbol
        ' 
        ' 
        ' pointSeries5.Marks.Symbol.Shadow
        ' 
        Me.pointSeries5.Marks.Symbol.Shadow.Height = 1
        Me.pointSeries5.Marks.Symbol.Shadow.Visible = True
        Me.pointSeries5.Marks.Symbol.Shadow.Width = 1
        ' 
        ' pointSeries5.Pointer
        ' 
        ' 
        ' pointSeries5.Pointer.Brush
        ' 
        Me.pointSeries5.Pointer.Brush.Color = System.Drawing.Color.FromArgb(CType(255, System.Byte), CType(255, System.Byte), CType(204, System.Byte))
        ' 
        ' pointSeries5.Pointer.Pen
        ' 
        Me.pointSeries5.Pointer.Pen.Color = System.Drawing.Color.FromArgb(CType(153, System.Byte), CType(153, System.Byte), CType(122, System.Byte))
        Me.pointSeries5.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.pointSeries5.Title = "point6"
        ' 
        ' pointSeries5.XValues
        ' 
        Me.pointSeries5.XValues.DataMember = "X"
        Me.pointSeries5.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' pointSeries5.YValues
        ' 
        Me.pointSeries5.YValues.DataMember = "Y"
        ' 
        ' pointSeries6
        ' 
        ' 
        ' pointSeries6.Marks
        ' 
        ' 
        ' pointSeries6.Marks.Symbol
        ' 
        ' 
        ' pointSeries6.Marks.Symbol.Shadow
        ' 
        Me.pointSeries6.Marks.Symbol.Shadow.Height = 1
        Me.pointSeries6.Marks.Symbol.Shadow.Visible = True
        Me.pointSeries6.Marks.Symbol.Shadow.Width = 1
        ' 
        ' pointSeries6.Pointer
        ' 
        ' 
        ' pointSeries6.Pointer.Brush
        ' 
        Me.pointSeries6.Pointer.Brush.Color = System.Drawing.Color.Gray
        Me.pointSeries6.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.pointSeries6.Title = "point6"
        ' 
        ' pointSeries6.XValues
        ' 
        Me.pointSeries6.XValues.DataMember = "X"
        Me.pointSeries6.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' pointSeries6.YValues
        ' 
        Me.pointSeries6.YValues.DataMember = "Y"
        ' 
        ' gridBand1
        ' 
        Me.gridBand1.Axis = Me.tChart1.Axes.Left
        ' 
        ' gridBand1.Band1
        ' 
        Me.gridBand1.Band1.Color = System.Drawing.Color.FromArgb(CType(76, System.Byte), CType(128, System.Byte), CType(128, System.Byte), CType(0, System.Byte))
        ' 
        ' gridBand1.Band2
        ' 
        Me.gridBand1.Band2.Color = System.Drawing.Color.FromArgb(CType(76, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        ' 
        ' SeriesType_Point
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(466, 286)
        Me.Name = "SeriesType_Point"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub 'InitializeComponent 
#End Region


    Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox1.CheckedChanged
        tChart1.Aspect.View3D = checkBox1.Checked
    End Sub 'checkBox1_CheckedChanged


    Private Sub checkBox2_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox2.CheckedChanged
        timer1.Enabled = checkBox2.Checked
    End Sub 'checkBox2_CheckedChanged


    Private Sub timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles timer1.Tick
        timer1.Stop()
        Try
            Dim tmpX As Double
            For Each s As Steema.TeeChart.Styles.Series In tChart1.Series
                ' add a new point to each series
                tmpX = s.XValues(1) - s.XValues(0)
                s.Delete(0)
                s.Add(s.XValues.Last + tmpX, s.YValues.Last + r.Next(100) - 50)
            Next s
        Finally
            timer1.Start()
        End Try
    End Sub 'timer1_Tick 
End Class 'SeriesType_Point
