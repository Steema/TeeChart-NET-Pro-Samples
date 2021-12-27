
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing

Imports System.Windows.Forms




Public Class SeriesType_Polar
    Inherits Samples.BaseForm
    Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
    Private WithEvents checkBox2 As System.Windows.Forms.CheckBox
    Private WithEvents checkBox3 As System.Windows.Forms.CheckBox
    Private WithEvents timer1 As System.Windows.Forms.Timer
    Private polarSeries1 As Steema.TeeChart.Styles.Polar
    Private polarSeries2 As Steema.TeeChart.Styles.Polar
    Private components As System.ComponentModel.IContainer = Nothing
    
    
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        
        polarSeries1.FillSampleValues(15)
        polarSeries2.FillSampleValues(20)
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
        Me.polarSeries1 = New Steema.TeeChart.Styles.Polar
        Me.polarSeries2 = New Steema.TeeChart.Styles.Polar
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(466, 40)
        Me.textBox1.Text = "Polar Series"
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.checkBox3)
        Me.panel1.Controls.Add(Me.checkBox2)
        Me.panel1.Controls.Add(Me.checkBox1)
        Me.panel1.Location = New System.Drawing.Point(0, 40)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(466, 33)
        ' 
        ' tChart1
        ' 
        ' 
        ' tChart1.Aspect
        ' 
        Me.tChart1.Aspect.Elevation = 315
        Me.tChart1.Aspect.Orthogonal = False
        Me.tChart1.Aspect.Perspective = 0
        Me.tChart1.Aspect.Rotation = 360
        Me.tChart1.Aspect.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality
        Me.tChart1.Aspect.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        Me.tChart1.Aspect.View3D = False
        ' 
        ' tChart1.Axes
        ' 
        ' 
        ' tChart1.Axes.Bottom
        ' 
        Me.tChart1.Axes.Bottom.Automatic = False
        Me.tChart1.Axes.Bottom.AutomaticMaximum = False
        Me.tChart1.Axes.Bottom.AutomaticMinimum = False
        Me.tChart1.Axes.Bottom.Increment = 30
        Me.tChart1.Axes.Bottom.Maximum = 992
        Me.tChart1.Axes.Bottom.Minimum = 3
        ' 
        ' tChart1.Header
        ' 
        Me.tChart1.Header.Alignment = System.Drawing.StringAlignment.Near
        ' 
        ' tChart1.Header.Font
        ' 
        Me.tChart1.Header.Font.Bold = True
        Me.tChart1.Header.Font.Italic = True
        Me.tChart1.Header.Font.Size = 10
        Me.tChart1.Header.Lines = New String() {"Wind direction and speed"}
        Me.tChart1.Location = New System.Drawing.Point(0, 73)
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
        Me.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(224, System.Byte), CType(224, System.Byte), CType(224, System.Byte))
        Me.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(192, System.Byte), CType(192, System.Byte), CType(192, System.Byte))
        Me.tChart1.Panel.Brush.Gradient.UseMiddle = True
        Me.tChart1.Panel.Brush.Gradient.Visible = True
        ' 
        ' tChart1.Panel.Gradient
        ' 
        Me.tChart1.Panel.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(224, System.Byte), CType(224, System.Byte), CType(224, System.Byte))
        Me.tChart1.Panel.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(192, System.Byte), CType(192, System.Byte), CType(192, System.Byte))
        Me.tChart1.Panel.Gradient.UseMiddle = True
        Me.tChart1.Panel.Gradient.Visible = True
        Me.tChart1.Series.Add(Me.polarSeries1)
        Me.tChart1.Series.Add(Me.polarSeries2)
        Me.tChart1.Size = New System.Drawing.Size(466, 213)
        ' 
        ' checkBox1
        ' 
        Me.checkBox1.Checked = True
        Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox1.Location = New System.Drawing.Point(13, 8)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(60, 21)
        Me.checkBox1.TabIndex = 0
        Me.checkBox1.Text = "&Circled"
        ' 
        ' checkBox2
        ' 
        Me.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox2.Location = New System.Drawing.Point(80, 8)
        Me.checkBox2.Name = "checkBox2"
        Me.checkBox2.Size = New System.Drawing.Size(87, 21)
        Me.checkBox2.TabIndex = 1
        Me.checkBox2.Text = "&Transparent"
        ' 
        ' checkBox3
        ' 
        Me.checkBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox3.Location = New System.Drawing.Point(200, 8)
        Me.checkBox3.Name = "checkBox3"
        Me.checkBox3.Size = New System.Drawing.Size(96, 21)
        Me.checkBox3.TabIndex = 2
        Me.checkBox3.Text = "&Animate"
        ' 
        ' timer1
        ' 
        ' 
        ' polarSeries1
        ' 
        ' 
        ' polarSeries1.Brush
        ' 
        Me.polarSeries1.Brush.Color = System.Drawing.Color.Red
        Me.polarSeries1.Circled = True
        Me.polarSeries1.CircleLabels = True
        Me.polarSeries1.CircleLabelsInside = True
        Me.polarSeries1.ClockWiseLabels = True
        Me.polarSeries1.ColorEach = True
        ' 
        ' polarSeries1.Marks
        ' 
        ' 
        ' polarSeries1.Marks.Symbol
        ' 
        ' 
        ' polarSeries1.Marks.Symbol.Shadow
        ' 
        Me.polarSeries1.Marks.Symbol.Shadow.Height = 1
        Me.polarSeries1.Marks.Symbol.Shadow.Visible = True
        Me.polarSeries1.Marks.Symbol.Shadow.Width = 1
        ' 
        ' polarSeries1.Pen
        ' 
        Me.polarSeries1.Pen.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        ' 
        ' polarSeries1.Pointer
        ' 
        ' 
        ' polarSeries1.Pointer.Brush
        ' 
        Me.polarSeries1.Pointer.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(0, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        Me.polarSeries1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.polarSeries1.Title = "polar2"
        ' 
        ' polarSeries1.XValues
        ' 
        Me.polarSeries1.XValues.DataMember = "Angle"
        Me.polarSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' polarSeries1.YValues
        ' 
        Me.polarSeries1.YValues.DataMember = "Y"
        ' 
        ' polarSeries2
        ' 
        ' 
        ' polarSeries2.Brush
        ' 
        Me.polarSeries2.Brush.Color = System.Drawing.Color.Green
        Me.polarSeries2.Circled = True
        Me.polarSeries2.CircleLabels = True
        Me.polarSeries2.CircleLabelsInside = True
        Me.polarSeries2.ClockWiseLabels = True
        Me.polarSeries2.ColorEach = True
        ' 
        ' polarSeries2.Marks
        ' 
        ' 
        ' polarSeries2.Marks.Symbol
        ' 
        ' 
        ' polarSeries2.Marks.Symbol.Shadow
        ' 
        Me.polarSeries2.Marks.Symbol.Shadow.Height = 1
        Me.polarSeries2.Marks.Symbol.Shadow.Visible = True
        Me.polarSeries2.Marks.Symbol.Shadow.Width = 1
        ' 
        ' polarSeries2.Pen
        ' 
        Me.polarSeries2.Pen.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        ' 
        ' polarSeries2.Pointer
        ' 
        ' 
        ' polarSeries2.Pointer.Brush
        ' 
        Me.polarSeries2.Pointer.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(0, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        Me.polarSeries2.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.polarSeries2.Title = "polar2"
        ' 
        ' polarSeries2.XValues
        ' 
        Me.polarSeries2.XValues.DataMember = "Angle"
        Me.polarSeries2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' polarSeries2.YValues
        ' 
        Me.polarSeries2.YValues.DataMember = "Y"
        ' 
        ' SeriesType_Polar
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(466, 286)
        Me.Name = "SeriesType_Polar"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub 'InitializeComponent 
#End Region


    Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox1.CheckedChanged
        Me.polarSeries1.Circled = checkBox1.Checked
        Me.polarSeries2.Circled = checkBox1.Checked
    End Sub 'checkBox1_CheckedChanged


    Private Sub checkBox2_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox2.CheckedChanged
        polarSeries1.Brush.Solid = Not checkBox2.Checked
        polarSeries2.Brush.Solid = Not checkBox2.Checked
    End Sub 'checkBox2_CheckedChanged


    Private Sub timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles timer1.Tick
        timer1.Stop()
        polarSeries1.Rotate(5)
        polarSeries2.Rotate(25)
        Dim axis As Steema.TeeChart.Axis
        axis = tChart1.Axes.Bottom
        If ((axis.Increment = 0) OrElse (axis.Increment >= 90)) Then
            axis.Increment = 1
        Else
            axis.Increment = (axis.Increment + 2)
        End If
        '  Change Grid RINGS and Vertical Axis Labels }
        axis = tChart1.Axes.Left
        If ((axis.Increment = 0) _
                    OrElse (axis.Increment >= (0.5 * (axis.Maximum - axis.Minimum)))) Then
            axis.Increment = (0.05 * (axis.Maximum - axis.Minimum))
        Else
            axis.Increment = (2 * (axis.Maximum - axis.Minimum))
        End If
        timer1.Start()
    End Sub 'timer1_Tick


    Private Sub checkBox3_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox3.CheckedChanged
        timer1.Enabled = checkBox3.Checked
    End Sub 'checkBox3_CheckedChanged


    Private Sub tChart1_AfterDraw(ByVal sender As Object, ByVal g As Steema.TeeChart.Drawing.Graphics3D) Handles tChart1.AfterDraw
        Dim canvas As Steema.TeeChart.Drawing.Graphics3D = tChart1.Graphics3D
        canvas.Brush.Solid = True ' <-- IMPORTANT (Try without) !!!
        canvas.Pen.Width = 2

        ' Draw a blue ring passing over the 3rd PolarSeries1 Point
        canvas.Pen.Color = Color.Blue
        ' polarSeries1.DrawRing( polarSeries1.YValues[2], polarSeries1.EndZ );
        ' Draw a green ring passing over the 6th Polar #2 Point
        canvas.Pen.Color = Color.Green
    End Sub 'tChart1_AfterDraw ' polarSeries2.DrawRing( polarSeries2.YValues[5], polarSeries2.EndZ );
End Class 'SeriesType_Polar
