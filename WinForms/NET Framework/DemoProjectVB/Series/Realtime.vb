Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Public Class Realtime
    Inherits Steema.TeeChart.Samples.BaseForm
    Private lineSeries1 As Steema.TeeChart.Styles.Line
    Private lineSeries2 As Steema.TeeChart.Styles.Line
    Private lineSeries3 As Steema.TeeChart.Styles.Line
    Private lineSeries4 As Steema.TeeChart.Styles.Line
    Private checkBox1 As System.Windows.Forms.CheckBox
    Private checkBox2 As System.Windows.Forms.CheckBox
    Private timer1 As System.Windows.Forms.Timer
    Private checkBox3 As System.Windows.Forms.CheckBox
    Private cbSmooth As CheckBox
    Private components As System.ComponentModel.IContainer = Nothing
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
    End Sub

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>

    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub 'Dispose

#Region "Designer generated code"
    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Realtime))
        Me.lineSeries1 = New Steema.TeeChart.Styles.Line()
        Me.lineSeries2 = New Steema.TeeChart.Styles.Line()
        Me.lineSeries3 = New Steema.TeeChart.Styles.Line()
        Me.lineSeries4 = New Steema.TeeChart.Styles.Line()
        Me.checkBox1 = New System.Windows.Forms.CheckBox()
        Me.checkBox2 = New System.Windows.Forms.CheckBox()
        Me.timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.checkBox3 = New System.Windows.Forms.CheckBox()
        Me.cbSmooth = New System.Windows.Forms.CheckBox()
        Me.panel1.SuspendLayout()
        Me.chartContainer.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Size = New System.Drawing.Size(488, 48)
        Me.textBox1.Text = "Using series Delete method you can easily do realtime charting. " & vbCr & vbLf & "Scrolling and a" & "xis range scaling is done automatically."
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.cbSmooth)
        Me.panel1.Controls.Add(Me.checkBox3)
        Me.panel1.Controls.Add(Me.checkBox2)
        Me.panel1.Controls.Add(Me.checkBox1)
        Me.panel1.Location = New System.Drawing.Point(0, 48)
        Me.panel1.Size = New System.Drawing.Size(488, 32)
        ' 
        ' tChart1
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Aspect.View3D = False
        Me.tChart1.Aspect.ZOffset = 0
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Left.Labels.Separation = 40
        ' 
        ' 
        ' 
        Me.tChart1.Header.Lines = New String() {"tChart1"}
        Me.tChart1.Header.Visible = False
        ' 
        ' 
        ' 
        Me.tChart1.Legend.LegendStyle = Steema.TeeChart.LegendStyles.LastValues
        Me.tChart1.Legend.Visible = False
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CInt(CByte(254)), CInt(CByte(255)), CInt(CByte(255)), CInt(CByte(255)))
        ' 
        ' 
        ' 
        Me.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(CInt(CByte(145)), CInt(CByte(200)), CInt(CByte(255)))
        Me.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CInt(CByte(187)), CInt(CByte(255)), CInt(CByte(255)))
        Me.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CInt(CByte(0)), CInt(CByte(113)), CInt(CByte(225)))
        Me.tChart1.Series.Add(Me.lineSeries1)
        Me.tChart1.Series.Add(Me.lineSeries2)
        Me.tChart1.Series.Add(Me.lineSeries3)
        Me.tChart1.Series.Add(Me.lineSeries4)
        Me.tChart1.Size = New System.Drawing.Size(488, 237)
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Walls.Back.Brush.Visible = False
        Me.tChart1.Walls.Back.Transparent = True
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Walls.Bottom.Pen.Visible = False
        Me.tChart1.Walls.Bottom.Size = 5
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Walls.Left.Pen.Visible = False
        Me.tChart1.Walls.Left.Size = 5
        ' 
        ' chartContainer
        ' 
        Me.chartContainer.Location = New System.Drawing.Point(0, 80)
        Me.chartContainer.Size = New System.Drawing.Size(488, 237)
        ' 
        ' lineSeries1
        ' 
        ' 
        ' 
        ' 
        Me.lineSeries1.Brush.Color = System.Drawing.Color.FromArgb(CInt(CByte(68)), CInt(CByte(102)), CInt(CByte(163)))
        Me.lineSeries1.Color = System.Drawing.Color.FromArgb(CInt(CByte(68)), CInt(CByte(102)), CInt(CByte(163)))
        Me.lineSeries1.ColorEach = False
        ' 
        ' 
        ' 
        Me.lineSeries1.LinePen.Color = System.Drawing.Color.FromArgb(CInt(CByte(41)), CInt(CByte(61)), CInt(CByte(98)))
        Me.lineSeries1.LinePen.Width = 2
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.lineSeries1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None
        Me.lineSeries1.Marks.Callout.ArrowHeadSize = 8
        ' 
        ' 
        ' 
        Me.lineSeries1.Marks.Callout.Brush.Color = System.Drawing.Color.Black
        Me.lineSeries1.Marks.Callout.Distance = 0
        Me.lineSeries1.Marks.Callout.Draw3D = False
        Me.lineSeries1.Marks.Callout.Length = 10
        Me.lineSeries1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.lineSeries1.Marks.Callout.Visible = False
        ' 
        ' 
        ' 
        Me.lineSeries1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.lineSeries1.Title = "lineSeries1"
        ' 
        ' 
        ' 
        Me.lineSeries1.XValues.DataMember = "X"
        Me.lineSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' 
        ' 
        Me.lineSeries1.YValues.DataMember = "Y"
        ' 
        ' lineSeries2
        ' 
        ' 
        ' 
        ' 
        Me.lineSeries2.Brush.Color = System.Drawing.Color.FromArgb(CInt(CByte(243)), CInt(CByte(156)), CInt(CByte(53)))
        Me.lineSeries2.Color = System.Drawing.Color.FromArgb(CInt(CByte(243)), CInt(CByte(156)), CInt(CByte(53)))
        Me.lineSeries2.ColorEach = False
        ' 
        ' 
        ' 
        Me.lineSeries2.LinePen.Color = System.Drawing.Color.FromArgb(CInt(CByte(146)), CInt(CByte(94)), CInt(CByte(32)))
        Me.lineSeries2.LinePen.Width = 2
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.lineSeries2.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None
        Me.lineSeries2.Marks.Callout.ArrowHeadSize = 8
        ' 
        ' 
        ' 
        Me.lineSeries2.Marks.Callout.Brush.Color = System.Drawing.Color.Black
        Me.lineSeries2.Marks.Callout.Distance = 0
        Me.lineSeries2.Marks.Callout.Draw3D = False
        Me.lineSeries2.Marks.Callout.Length = 10
        Me.lineSeries2.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.lineSeries2.Marks.Callout.Visible = False
        ' 
        ' 
        ' 
        Me.lineSeries2.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.lineSeries2.Title = "lineSeries2"
        ' 
        ' 
        ' 
        Me.lineSeries2.XValues.DataMember = "X"
        Me.lineSeries2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' 
        ' 
        Me.lineSeries2.YValues.DataMember = "Y"
        ' 
        ' lineSeries3
        ' 
        ' 
        ' 
        ' 
        Me.lineSeries3.Brush.Color = System.Drawing.Color.FromArgb(CInt(CByte(241)), CInt(CByte(76)), CInt(CByte(20)))
        Me.lineSeries3.Color = System.Drawing.Color.FromArgb(CInt(CByte(241)), CInt(CByte(76)), CInt(CByte(20)))
        Me.lineSeries3.ColorEach = False
        ' 
        ' 
        ' 
        Me.lineSeries3.LinePen.Color = System.Drawing.Color.FromArgb(CInt(CByte(145)), CInt(CByte(46)), CInt(CByte(12)))
        Me.lineSeries3.LinePen.Width = 2
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.lineSeries3.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None
        Me.lineSeries3.Marks.Callout.ArrowHeadSize = 8
        ' 
        ' 
        ' 
        Me.lineSeries3.Marks.Callout.Brush.Color = System.Drawing.Color.Black
        Me.lineSeries3.Marks.Callout.Distance = 0
        Me.lineSeries3.Marks.Callout.Draw3D = False
        Me.lineSeries3.Marks.Callout.Length = 10
        Me.lineSeries3.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.lineSeries3.Marks.Callout.Visible = False
        ' 
        ' 
        ' 
        Me.lineSeries3.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.lineSeries3.Title = "lineSeries3"
        ' 
        ' 
        ' 
        Me.lineSeries3.XValues.DataMember = "X"
        Me.lineSeries3.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' 
        ' 
        Me.lineSeries3.YValues.DataMember = "Y"
        ' 
        ' lineSeries4
        ' 
        ' 
        ' 
        ' 
        Me.lineSeries4.Brush.Color = System.Drawing.Color.FromArgb(CInt(CByte(78)), CInt(CByte(151)), CInt(CByte(168)))
        Me.lineSeries4.Color = System.Drawing.Color.FromArgb(CInt(CByte(78)), CInt(CByte(151)), CInt(CByte(168)))
        Me.lineSeries4.ColorEach = False
        ' 
        ' 
        ' 
        Me.lineSeries4.LinePen.Color = System.Drawing.Color.FromArgb(CInt(CByte(47)), CInt(CByte(91)), CInt(CByte(101)))
        Me.lineSeries4.LinePen.Width = 2
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.lineSeries4.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None
        Me.lineSeries4.Marks.Callout.ArrowHeadSize = 8
        ' 
        ' 
        ' 
        Me.lineSeries4.Marks.Callout.Brush.Color = System.Drawing.Color.Black
        Me.lineSeries4.Marks.Callout.Distance = 0
        Me.lineSeries4.Marks.Callout.Draw3D = False
        Me.lineSeries4.Marks.Callout.Length = 10
        Me.lineSeries4.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.lineSeries4.Marks.Callout.Visible = False
        ' 
        ' 
        ' 
        Me.lineSeries4.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.lineSeries4.Title = "lineSeries4"
        ' 
        ' 
        ' 
        Me.lineSeries4.XValues.DataMember = "X"
        Me.lineSeries4.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' 
        ' 
        Me.lineSeries4.YValues.DataMember = "Y"
        ' 
        ' checkBox1
        ' 
        Me.checkBox1.Checked = True
        Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox1.Location = New System.Drawing.Point(16, 7)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(67, 21)
        Me.checkBox1.TabIndex = 0
        Me.checkBox1.Text = "&Animate"
        AddHandler Me.checkBox1.CheckedChanged, AddressOf Me.checkBox1_CheckedChanged

        ' 
        ' checkBox2
        ' 
        Me.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox2.Location = New System.Drawing.Point(112, 7)
        Me.checkBox2.Name = "checkBox2"
        Me.checkBox2.Size = New System.Drawing.Size(46, 21)
        Me.checkBox2.TabIndex = 1
        Me.checkBox2.Text = "&3D"
        AddHandler Me.checkBox2.CheckedChanged, AddressOf Me.checkBox2_CheckedChanged
        ' 
        ' timer1
        ' 
        Me.timer1.Enabled = True
        Me.timer1.Interval = 50
        AddHandler Me.timer1.Tick, AddressOf Me.timer1_Tick
        ' 
        ' checkBox3
        ' 
        Me.checkBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox3.Location = New System.Drawing.Point(192, 5)
        Me.checkBox3.Name = "checkBox3"
        Me.checkBox3.Size = New System.Drawing.Size(104, 24)
        Me.checkBox3.TabIndex = 2
        Me.checkBox3.Text = "&Legend"
        AddHandler Me.checkBox3.CheckedChanged, AddressOf Me.checkBox3_CheckedChanged
        ' 
        ' cbSmooth
        ' 
        Me.cbSmooth.Checked = True
        Me.cbSmooth.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbSmooth.Location = New System.Drawing.Point(276, 9)
        Me.cbSmooth.Name = "cbSmooth"
        Me.cbSmooth.Size = New System.Drawing.Size(62, 17)
        Me.cbSmooth.TabIndex = 3
        Me.cbSmooth.Text = "&Smooth"
#If VS2005 Then
        Me.cbSmooth.AutoSize = True
        Me.cbSmooth.UseVisualStyleBackColor = True
#End If
        ' 
        ' Realtime
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(488, 317)
        Me.Name = "Realtime"
        AddHandler Me.Load, AddressOf Me.Realtime_Load

        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.chartContainer.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
#End Region
    Private Sub AnimateSeries(ByVal chart As Steema.TeeChart.TChart)
        Dim rnd As New Random()
        Dim newX As Double, newY As Double
        chart.AutoRepaint = False

        If cbSmooth.Checked Then
            lineSeries1.Smoothed = False
            lineSeries2.Smoothed = False
            lineSeries3.Smoothed = False
            lineSeries4.Smoothed = False
        End If


        For Each s As TeeChart.Styles.Series In chart.Series
            ' show only 50 points - delete the rest
            While s.Count > 50
                s.Delete(0)
            End While
            If s.Count > 50 Then
                s.Delete(0)
            End If
            newX = s.XValues.Last + 1
            newY = s.YValues.Last + 1000 * rnd.[Next](2) - 500
            If Math.Abs(newY) > 10000.0 Then
                newY = 0.0
            End If

            s.Add(newX, newY)
        Next

        If cbSmooth.Checked Then
            lineSeries1.Smoothed = True
            lineSeries2.Smoothed = True
            lineSeries3.Smoothed = True
            lineSeries4.Smoothed = True
        End If

        chart.AutoRepaint = True
        chart.Refresh()
    End Sub

    Private Sub checkBox2_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.tChart1.Aspect.View3D = Me.checkBox2.Checked
    End Sub

    Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.timer1.Enabled = Me.checkBox1.Checked
    End Sub

    Private Sub timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs)
        AnimateSeries(Me.tChart1)
    End Sub

    Private Sub Realtime_Load(ByVal sender As Object, ByVal e As System.EventArgs)
        tChart1.Axes.Bottom.Increment = 5

        ' add one sample value to each Series
        lineSeries1.Add(1000)
        lineSeries2.Add(1000)
        lineSeries3.Add(1000)
        lineSeries4.Add(1000)
    End Sub

    Private Sub checkBox3_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        tChart1.Legend.Visible = checkBox3.Checked
    End Sub

End Class 'Realtime
