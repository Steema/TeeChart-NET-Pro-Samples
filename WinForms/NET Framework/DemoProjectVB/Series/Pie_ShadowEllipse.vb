
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports Steema.TeeChart.Drawing


Public Class PieShadowEllipse
    Inherits Steema.TeeChart.Samples.BaseForm
    Private checkBox1 As System.Windows.Forms.CheckBox
    Private buttonColor1 As Steema.TeeChart.ButtonColor
    Private groupBox1 As System.Windows.Forms.GroupBox
    Private radioButton1 As System.Windows.Forms.RadioButton
    Private radioButton2 As System.Windows.Forms.RadioButton
    Private radioButton3 As System.Windows.Forms.RadioButton
    Private pie1 As Steema.TeeChart.Styles.Pie
    Private timer1 As System.Windows.Forms.Timer
    Private components As System.ComponentModel.IContainer = Nothing
    
    Public Sub New() ' This call is required by the Windows Form Designer.
        InitializeComponent()

        pie1.FillSampleValues()
        pie1.Circled = False
        tChart1.Legend.Visible = False
        buttonColor1.Color = tChart1.Panel.Color
			
    End Sub


    '/ <summary>
    '/ Clean up any resources being used.
    '/ </summary>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If Disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(Disposing)
    End Sub 'Dispose

#Region "Windows Form Designer generated code"

    '/ <summary>
    '/ Required method for Designer support - do not modify
    '/ the contents of this method with the code editor.
    '/ </summary>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.checkBox1 = New System.Windows.Forms.CheckBox
        Me.buttonColor1 = New Steema.TeeChart.ButtonColor
        Me.groupBox1 = New System.Windows.Forms.GroupBox
        Me.radioButton3 = New System.Windows.Forms.RadioButton
        Me.radioButton2 = New System.Windows.Forms.RadioButton
        Me.radioButton1 = New System.Windows.Forms.RadioButton
        Me.pie1 = New Steema.TeeChart.Styles.Pie
        Me.timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.panel1.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Text = "A procedure to draw elliptical shadows. " + vbCr + vbLf + "Useful for circular series like Pie, at" + " Chart OnBeforeDrawSeries event." + vbCr + vbLf + vbCr + vbLf + "DrawEllipseShadow( Chart1.Canvas, Chart1.Col" + "or, R )"
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.groupBox1)
        Me.panel1.Controls.Add(Me.buttonColor1)
        Me.panel1.Controls.Add(Me.checkBox1)
        Me.panel1.Name = "panel1"
        ' 
        ' tChart1
        ' 
        ' 
        ' tChart1.Aspect
        ' 
        Me.tChart1.Aspect.ColorPaletteIndex = 1
        Me.tChart1.Aspect.Elevation = 315
        Me.tChart1.Aspect.Orthogonal = False
        Me.tChart1.Aspect.Perspective = 0
        Me.tChart1.Aspect.Rotation = 360
        Me.tChart1.Aspect.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality
        Me.tChart1.Aspect.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        ' 
        ' tChart1.Axes
        ' 
        ' 
        ' tChart1.Axes.Bottom
        ' 
        ' 
        ' tChart1.Axes.Bottom.Grid
        ' 
        Me.tChart1.Axes.Bottom.Grid.Color = System.Drawing.Color.Gray
        ' 
        ' tChart1.Axes.Bottom.Ticks
        ' 
        Me.tChart1.Axes.Bottom.Ticks.Length = 2
        ' 
        ' tChart1.Axes.Depth
        ' 
        ' 
        ' tChart1.Axes.Depth.Grid
        ' 
        Me.tChart1.Axes.Depth.Grid.Color = System.Drawing.Color.Gray
        ' 
        ' tChart1.Axes.Depth.Ticks
        ' 
        Me.tChart1.Axes.Depth.Ticks.Length = 2
        ' 
        ' tChart1.Axes.Left
        ' 
        ' 
        ' tChart1.Axes.Left.Grid
        ' 
        Me.tChart1.Axes.Left.Grid.Color = System.Drawing.Color.Gray
        ' 
        ' tChart1.Axes.Left.Ticks
        ' 
        Me.tChart1.Axes.Left.Ticks.Length = 2
        ' 
        ' tChart1.Axes.Right
        ' 
        ' 
        ' tChart1.Axes.Right.Grid
        ' 
        Me.tChart1.Axes.Right.Grid.Color = System.Drawing.Color.Gray
        ' 
        ' tChart1.Axes.Right.Ticks
        ' 
        Me.tChart1.Axes.Right.Ticks.Length = 2
        ' 
        ' tChart1.Axes.Top
        ' 
        ' 
        ' tChart1.Axes.Top.Grid
        ' 
        Me.tChart1.Axes.Top.Grid.Color = System.Drawing.Color.Gray
        ' 
        ' tChart1.Axes.Top.Ticks
        ' 
        Me.tChart1.Axes.Top.Ticks.Length = 2
        ' 
        ' tChart1.Header
        ' 
        Me.tChart1.Header.Lines = New String() {"tChart1"}
        Me.tChart1.Header.Visible = False
        ' 
        ' tChart1.Legend
        ' 
        ' 
        ' tChart1.Legend.Shadow
        ' 
        ' 
        ' tChart1.Legend.Shadow.Brush
        ' 
        Me.tChart1.Legend.Shadow.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(0, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
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
        Me.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.Yellow
        Me.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.Empty
        Me.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.White
        ' 
        ' tChart1.Panel.Gradient
        ' 
        Me.tChart1.Panel.Gradient.EndColor = System.Drawing.Color.Yellow
        Me.tChart1.Panel.Gradient.MiddleColor = System.Drawing.Color.Empty
        Me.tChart1.Panel.Gradient.StartColor = System.Drawing.Color.White
        ' 
        ' tChart1.Panel.ImageBevel
        ' 
        Me.tChart1.Panel.ImageBevel.Visible = True
        Me.tChart1.Panel.ImageBevel.Width = 5
        ' 
        ' tChart1.Panel.Shadow
        ' 
        Me.tChart1.Panel.Shadow.Height = 0
        Me.tChart1.Panel.Shadow.Width = 0
        Me.tChart1.Series.Add(Me.pie1)
        ' 
        ' tChart1.Walls
        ' 
        ' 
        ' tChart1.Walls.Right
        ' 
        ' 
        ' tChart1.Walls.Right.Brush
        ' 
        Me.tChart1.Walls.Right.Brush.Color = System.Drawing.Color.Silver
        AddHandler Me.tChart1.BeforeDrawSeries, AddressOf Me.tChart1_BeforeDrawSeries
        ' 
        ' checkBox1
        ' 
        Me.checkBox1.Checked = True
        Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox1.Location = New System.Drawing.Point(16, 8)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.TabIndex = 0
        Me.checkBox1.Text = "View Shadow:"
        AddHandler Me.checkBox1.CheckedChanged, AddressOf Me.checkBox1_CheckedChanged
        ' 
        ' buttonColor1
        ' 
        Me.buttonColor1.Color = System.Drawing.Color.Empty
        Me.buttonColor1.Location = New System.Drawing.Point(136, 9)
        Me.buttonColor1.Name = "buttonColor1"
        Me.buttonColor1.TabIndex = 1
        Me.buttonColor1.Text = "Color..."
        ' 
        ' groupBox1
        ' 
        Me.groupBox1.Controls.Add(Me.radioButton3)
        Me.groupBox1.Controls.Add(Me.radioButton2)
        Me.groupBox1.Controls.Add(Me.radioButton1)
        Me.groupBox1.Location = New System.Drawing.Point(232, 0)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(184, 37)
        Me.groupBox1.TabIndex = 2
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Animation"
        ' 
        ' radioButton3
        ' 
        Me.radioButton3.Location = New System.Drawing.Point(128, 17)
        Me.radioButton3.Name = "radioButton3"
        Me.radioButton3.Size = New System.Drawing.Size(50, 13)
        Me.radioButton3.TabIndex = 2
        Me.radioButton3.Text = "Fast"
        AddHandler Me.radioButton3.CheckedChanged, AddressOf Me.radioButton_CheckedChanged
        ' 
        ' radioButton2
        ' 
        Me.radioButton2.Checked = True
        Me.radioButton2.Location = New System.Drawing.Point(71, 17)
        Me.radioButton2.Name = "radioButton2"
        Me.radioButton2.Size = New System.Drawing.Size(50, 13)
        Me.radioButton2.TabIndex = 1
        Me.radioButton2.TabStop = True
        Me.radioButton2.Text = "Slow"
        AddHandler Me.radioButton2.CheckedChanged, AddressOf Me.radioButton_CheckedChanged
        ' 
        ' radioButton1
        ' 
        Me.radioButton1.Location = New System.Drawing.Point(14, 17)
        Me.radioButton1.Name = "radioButton1"
        Me.radioButton1.Size = New System.Drawing.Size(50, 13)
        Me.radioButton1.TabIndex = 0
        Me.radioButton1.Text = "None"
        AddHandler Me.radioButton1.CheckedChanged, AddressOf Me.radioButton_CheckedChanged
        ' 
        ' pie1
        ' 
        ' 
        ' pie1.Brush
        ' 
        Me.pie1.Brush.Color = System.Drawing.Color.FromArgb(CType(255, System.Byte), CType(153, System.Byte), CType(153, System.Byte))
        Me.pie1.LabelMember = "Labels"
        ' 
        ' pie1.Marks
        ' 
        ' 
        ' pie1.Marks.Symbol
        ' 
        ' 
        ' pie1.Marks.Symbol.Shadow
        ' 
        Me.pie1.Marks.Symbol.Shadow.Height = 1
        Me.pie1.Marks.Symbol.Shadow.Visible = True
        Me.pie1.Marks.Symbol.Shadow.Width = 1
        ' 
        ' pie1.Pen
        ' 
        Me.pie1.Pen.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(128, System.Byte), CType(128, System.Byte), CType(128, System.Byte))
        ' 
        ' pie1.Shadow
        ' 
        Me.pie1.Shadow.Height = 20
        Me.pie1.Shadow.Width = 20
        Me.pie1.Title = "pie1"
        ' 
        ' pie1.XValues
        ' 
        Me.pie1.XValues.DataMember = "Angle"
        Me.pie1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' pie1.YValues
        ' 
        Me.pie1.YValues.DataMember = "Pie"
        ' 
        ' timer1
        ' 
        Me.timer1.Enabled = True
        Me.timer1.Interval = 200
        AddHandler Me.timer1.Tick, AddressOf Me.timer1_Tick
        ' 
        ' PieShadowEllipse
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(440, 317)
        Me.Name = "PieShadowEllipse"
        Me.panel1.ResumeLayout(False)
        Me.groupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub 'New 
#End Region

    Private Sub DrawEllipseShadow(ByVal g As Steema.TeeChart.Drawing.Graphics3D, ByVal AColor As Color, ByVal R As Rectangle)
        Dim x, y, t As Integer
        Dim Steps As Integer
        Dim tmpW, tmpH As Double

        g.Pen.Visible = False
        g.Brush.Solid = True
        g.Brush.Visible = True
        g.Brush.Color = AColor


        x = (R.Left + R.Right) / 2
        y = (R.Top + R.Bottom) / 2

        Steps = (Math.Min(x, y) / 10)
        tmpW = (0.5 _
                    * ((R.Right - R.Left) _
                    / Steps))
        tmpH = (0.5 _
                    * ((R.Bottom - R.Top) _
                    / Steps))
       

        For t = Steps To 1 Step -1
            Graphics3D.ApplyDark(AColor, 8)
            g.Brush.Color = AColor
            R = Rectangle.FromLTRB(x - Convert.ToInt32(t * tmpW), y - Convert.ToInt32(t * tmpH), x + Convert.ToInt32(t * tmpW), y + Convert.ToInt32(t * tmpH))
            g.Ellipse(R)
        Next t
    End Sub 'DrawEllipseShadow


    Private Sub tChart1_BeforeDrawSeries(ByVal sender As Object, ByVal g As Steema.TeeChart.Drawing.Graphics3D)
        Dim R As Rectangle
        If checkBox1.Checked Then
            R = tChart1.Chart.ChartRect
            R = Rectangle.FromLTRB(R.Left + 80, R.Bottom - 40, R.Right - 80, R.Bottom)
            DrawEllipseShadow(g, tChart1.Panel.Color, R)
        End If
    End Sub 'tChart1_BeforeDrawSeries


    Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        tChart1.Refresh()
    End Sub 'checkBox1_CheckedChanged


    Private Sub timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs)
        pie1.RotationAngle = pie1.RotationAngle + 1
    End Sub 'timer1_Tick


    Private Sub radioButton_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        timer1.Enabled = Not radioButton1.Checked
        If radioButton2.Checked Then
            timer1.Interval = 200
        Else
            timer1.Interval = 1
        End If
    End Sub 'radioButton_CheckedChanged
End Class 'PieShadowEllipse