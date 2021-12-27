
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms



Public Class SeriesType_FastLine
    Inherits Samples.BaseForm
    Private fastLineSeries1 As Steema.TeeChart.Styles.FastLine
    Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
    Private WithEvents checkBox2 As System.Windows.Forms.CheckBox
    Private WithEvents checkBox3 As System.Windows.Forms.CheckBox
    Private WithEvents button1 As System.Windows.Forms.Button
    Private fastLineSeries2 As Steema.TeeChart.Styles.FastLine
    Private components As System.ComponentModel.IContainer = Nothing
    
    
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        
        ' Make the chart flicker by default, only for this demo
        tChart1.Graphics3D.BufferStyle = Drawing.BufferStyle.None

        ' hide things for better speed
        tChart1.Aspect.View3D = False
        tChart1.Legend.Visible = False
        tChart1.Header.Visible = False
        tChart1.Footer.Visible = False
        
        ' 1000 random points each series
        Dim r As New Random()
        Dim tmprandom As Integer
        Dim t As Integer
        For t = 1 To 999
            tmprandom = r.Next(Math.Abs(500 - t)) - Math.Abs(500 - t) / 2
            fastLineSeries1.Add(1000 - t + tmprandom)
            fastLineSeries2.Add(t + tmprandom)
        Next t
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
        Me.checkBox1 = New System.Windows.Forms.CheckBox
        Me.checkBox2 = New System.Windows.Forms.CheckBox
        Me.checkBox3 = New System.Windows.Forms.CheckBox
        Me.button1 = New System.Windows.Forms.Button
        Me.fastLineSeries2 = New Steema.TeeChart.Styles.FastLine
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(511, 64)
        Me.textBox1.Text = "The Fast-Line chart style is, at it's name implies, the fastest way to plot many points.  It simply draws a thin line connecting all points." + vbCr + vbLf + "Some optimizations (like not drawing repeated values) are performed. It can be used in real-time applications to plot new added points."
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.button1)
        Me.panel1.Controls.Add(Me.checkBox3)
        Me.panel1.Controls.Add(Me.checkBox2)
        Me.panel1.Controls.Add(Me.checkBox1)
        Me.panel1.Location = New System.Drawing.Point(0, 64)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(511, 40)
        ' 
        ' tChart1
        ' 
        ' 
        ' tChart1.Aspect
        ' 
        Me.tChart1.Aspect.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality
        Me.tChart1.Aspect.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        Me.tChart1.BackColor = System.Drawing.Color.Transparent
        ' 
        ' tChart1.Header
        ' 
        Me.tChart1.Header.Lines = New String() {"tChart1"}
        Me.tChart1.Location = New System.Drawing.Point(0, 104)
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Brush
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.tChart1.Series.Add(Me.fastLineSeries1)
        Me.tChart1.Series.Add(Me.fastLineSeries2)
        Me.tChart1.Size = New System.Drawing.Size(511, 208)
        ' 
        ' tChart1.Walls
        ' 
        ' 
        ' tChart1.Walls.Back
        ' 
        ' 
        ' tChart1.Walls.Back.Brush
        ' 
        Me.tChart1.Walls.Back.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(224, System.Byte), CType(224, System.Byte), CType(224, System.Byte))
        ' 
        ' tChart1.Walls.Bottom
        ' 
        ' 
        ' tChart1.Walls.Bottom.Brush
        ' 
        Me.tChart1.Walls.Bottom.Brush.Color = System.Drawing.Color.FromArgb(CType(178, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        ' 
        ' tChart1.Walls.Bottom.Gradient
        ' 
        Me.tChart1.Walls.Bottom.Brush.Gradient.Transparency = 30
        ' 
        ' tChart1.Walls.Bottom.Gradient
        ' 
        Me.tChart1.Walls.Bottom.Gradient.Transparency = 30
        ' 
        ' tChart1.Walls.Left
        ' 
        ' 
        ' tChart1.Walls.Left.Brush
        ' 
        Me.tChart1.Walls.Left.Brush.Color = System.Drawing.Color.FromArgb(CType(178, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(224, System.Byte))
        ' 
        ' tChart1.Walls.Left.Gradient
        ' 
        Me.tChart1.Walls.Left.Brush.Gradient.Transparency = 30
        ' 
        ' tChart1.Walls.Left.Gradient
        ' 
        Me.tChart1.Walls.Left.Gradient.Transparency = 30
        ' 
        ' fastLineSeries1
        ' 
        Me.fastLineSeries1.Cursor = System.Windows.Forms.Cursors.Cross
        ' 
        ' fastLineSeries1.LinePen
        ' 
        Me.fastLineSeries1.LinePen.Color = System.Drawing.Color.Red
        ' 
        ' fastLineSeries1.Marks
        ' 
        ' 
        ' fastLineSeries1.Marks.Symbol
        ' 
        ' 
        ' fastLineSeries1.Marks.Symbol.Shadow
        ' 
        Me.fastLineSeries1.Marks.Symbol.Shadow.Height = 1
        Me.fastLineSeries1.Marks.Symbol.Shadow.Visible = True
        Me.fastLineSeries1.Marks.Symbol.Shadow.Width = 1
        Me.fastLineSeries1.Title = "fastLine2"
        ' 
        ' fastLineSeries1.XValues
        ' 
        Me.fastLineSeries1.XValues.DataMember = "X"
        Me.fastLineSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' fastLineSeries1.YValues
        ' 
        Me.fastLineSeries1.YValues.DataMember = "Y"
        ' 
        ' checkBox1
        ' 
        Me.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox1.Location = New System.Drawing.Point(14, 8)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(73, 22)
        Me.checkBox1.TabIndex = 0
        Me.checkBox1.Text = "&Buffered"
        ' 
        ' checkBox2
        ' 
        Me.checkBox2.Checked = True
        Me.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox2.Location = New System.Drawing.Point(95, 8)
        Me.checkBox2.Name = "checkBox2"
        Me.checkBox2.Size = New System.Drawing.Size(89, 22)
        Me.checkBox2.TabIndex = 1
        Me.checkBox2.Text = "&Draw Axes"
        ' 
        ' checkBox3
        ' 
        Me.checkBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox3.Location = New System.Drawing.Point(182, 8)
        Me.checkBox3.Name = "checkBox3"
        Me.checkBox3.Size = New System.Drawing.Size(81, 22)
        Me.checkBox3.TabIndex = 2
        Me.checkBox3.Text = "&Clip points"
        ' 
        ' button1
        ' 
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.Location = New System.Drawing.Point(292, 8)
        Me.button1.Name = "button1"
        Me.button1.TabIndex = 3
        Me.button1.Text = "&Test speed"
        ' 
        ' fastLineSeries2
        ' 
        Me.fastLineSeries2.Cursor = System.Windows.Forms.Cursors.Cross
        ' 
        ' fastLineSeries2.LinePen
        ' 
        Me.fastLineSeries2.LinePen.Color = System.Drawing.Color.Green
        ' 
        ' fastLineSeries2.Marks
        ' 
        ' 
        ' fastLineSeries2.Marks.Symbol
        ' 
        ' 
        ' fastLineSeries2.Marks.Symbol.Shadow
        ' 
        Me.fastLineSeries2.Marks.Symbol.Shadow.Height = 1
        Me.fastLineSeries2.Marks.Symbol.Shadow.Visible = True
        Me.fastLineSeries2.Marks.Symbol.Shadow.Width = 1
        Me.fastLineSeries2.Title = "fastLine2"
        ' 
        ' fastLineSeries2.XValues
        ' 
        Me.fastLineSeries2.XValues.DataMember = "X"
        Me.fastLineSeries2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' fastLineSeries2.YValues
        ' 
        Me.fastLineSeries2.YValues.DataMember = "Y"
        ' 
        ' SeriesType_Fastline
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(511, 312)
        Me.Name = "SeriesType_Fastline"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub 'InitializeComponent 
#End Region


    Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox1.CheckedChanged
        If checkBox1.Checked Then
            tChart1.Graphics3D.BufferStyle = Drawing.BufferStyle.OptimizedBuffer
        Else
            tChart1.Graphics3D.BufferStyle = Drawing.BufferStyle.None
        End If

    End Sub 'checkBox1_CheckedChanged


    Private Sub checkBox2_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox2.CheckedChanged
        tChart1.Axes.Visible = checkBox2.Checked
    End Sub 'checkBox2_CheckedChanged


    Private Sub checkBox3_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox3.CheckedChanged
        tChart1.Aspect.ClipPoints = checkBox3.Checked
    End Sub 'checkBox3_CheckedChanged


    Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
    System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
    Dim MarkTime As Integer
        Try
            tChart1.Zoom.Animated = False
            MarkTime = Environment.TickCount
            Dim t As Integer
            For t = 1 To 29
                tChart1.Zoom.ZoomPercent(105)
                tChart1.Refresh()
            Next t
            For t = 1 To 29
                tChart1.Zoom.ZoomPercent(95)
                tChart1.Refresh()
            Next t
            MarkTime = Environment.TickCount - MarkTime
            tChart1.Zoom.Animated = True
            tChart1.Zoom.Undo()
        Finally
      System.Windows.Forms.Cursor.Current = Cursors.Default
    End Try
        MessageBox.Show("Time to plot 2000 points " + vbLf + " 61 times : " + vbLf + " " + MarkTime.ToString() + " milliseconds.")
    End Sub 'button1_Click
End Class 'SeriesType_FastLine