
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports Steema.TeeChart.Drawing

Imports System.Windows.Forms




Public Class Canvas_RotCenter
    Inherits Samples.BaseForm
    Private surfaceSeries1 As Steema.TeeChart.Styles.Surface
    Private label1 As System.Windows.Forms.Label
    Private WithEvents trackBar1 As System.Windows.Forms.TrackBar
    Private label2 As System.Windows.Forms.Label
    Private label3 As System.Windows.Forms.Label
    Private WithEvents trackBar2 As System.Windows.Forms.TrackBar
    Private label4 As System.Windows.Forms.Label
    Private WithEvents trackBar3 As System.Windows.Forms.TrackBar
    Private WithEvents timer1 As System.Windows.Forms.Timer
    Private components As System.ComponentModel.IContainer = Nothing
    Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
    Private WithEvents checkBox2 As System.Windows.Forms.CheckBox
    Private WithEvents checkBox3 As System.Windows.Forms.CheckBox
    
    Private Delta As Integer
    
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Delta = 1
        Me.surfaceSeries1.FillSampleValues(25)
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
        Me.surfaceSeries1 = New Steema.TeeChart.Styles.Surface
        Me.label1 = New System.Windows.Forms.Label
        Me.trackBar1 = New System.Windows.Forms.TrackBar
        Me.label2 = New System.Windows.Forms.Label
        Me.label3 = New System.Windows.Forms.Label
        Me.trackBar2 = New System.Windows.Forms.TrackBar
        Me.label4 = New System.Windows.Forms.Label
        Me.trackBar3 = New System.Windows.Forms.TrackBar
        Me.timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.checkBox1 = New System.Windows.Forms.CheckBox
        Me.checkBox2 = New System.Windows.Forms.CheckBox
        Me.checkBox3 = New System.Windows.Forms.CheckBox
        Me.panel1.SuspendLayout()
        CType(Me.trackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trackBar2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trackBar3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(480, 72)
        Me.textBox1.TabIndex = 0
        Me.textBox1.Text = "Graphics3D RotationCenter property defines the offset in pixels from the Chart ce" + "nter to rotate around it.  " + vbCr + vbLf + vbCr + vbLf + "tChart1.Graphics3D.RotationCenter.X =100"
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.checkBox3)
        Me.panel1.Controls.Add(Me.checkBox2)
        Me.panel1.Controls.Add(Me.checkBox1)
        Me.panel1.Controls.Add(Me.trackBar3)
        Me.panel1.Controls.Add(Me.label4)
        Me.panel1.Controls.Add(Me.trackBar2)
        Me.panel1.Controls.Add(Me.label3)
        Me.panel1.Controls.Add(Me.label2)
        Me.panel1.Controls.Add(Me.trackBar1)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Location = New System.Drawing.Point(0, 72)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(480, 73)
        Me.panel1.TabIndex = 1
        ' 
        ' tChart1
        ' 
        ' 
        ' tChart1.Aspect
        ' 
        Me.tChart1.Aspect.Chart3DPercent = 100
        Me.tChart1.Aspect.Elevation = 333
        Me.tChart1.Aspect.Orthogonal = False
        Me.tChart1.Aspect.Perspective = 100
        Me.tChart1.Aspect.Rotation = 333
        Me.tChart1.Aspect.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality
        Me.tChart1.Aspect.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        Me.tChart1.Aspect.Zoom = 72
        ' 
        ' tChart1.Header
        ' 
        Me.tChart1.Header.Lines = New String() {"tChart1"}
        Me.tChart1.Header.Visible = False
        ' 
        ' tChart1.Legend
        ' 
        Me.tChart1.Legend.Visible = False
        Me.tChart1.Location = New System.Drawing.Point(0, 145)
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Brush
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.tChart1.Series.Add(Me.surfaceSeries1)
        Me.tChart1.Size = New System.Drawing.Size(480, 148)
        Me.tChart1.TabIndex = 2
        ' 
        ' tChart1.Walls
        ' 
        ' 
        ' tChart1.Walls.Bottom
        ' 
        ' 
        ' tChart1.Walls.Bottom.Brush
        ' 
        Me.tChart1.Walls.Bottom.Brush.Color = System.Drawing.Color.FromArgb(CType(127, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        ' 
        ' tChart1.Walls.Bottom.Gradient
        ' 
        Me.tChart1.Walls.Bottom.Brush.Gradient.Transparency = 50
        ' 
        ' tChart1.Walls.Bottom.Gradient
        ' 
        Me.tChart1.Walls.Bottom.Gradient.Transparency = 50
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
        Me.tChart1.Walls.Left.Brush.Color = System.Drawing.Color.FromArgb(CType(127, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(224, System.Byte))
        ' 
        ' tChart1.Walls.Left.Gradient
        ' 
        Me.tChart1.Walls.Left.Brush.Gradient.Transparency = 50
        ' 
        ' tChart1.Walls.Left.Gradient
        ' 
        Me.tChart1.Walls.Left.Gradient.Transparency = 50
        ' 
        ' tChart1.Walls.Left.Pen
        ' 
        Me.tChart1.Walls.Left.Pen.Visible = False
        Me.tChart1.Walls.Left.Size = 5
        ' 
        ' surfaceSeries1
        ' 
        ' 
        ' surfaceSeries1.Brush
        ' 
        Me.surfaceSeries1.Brush.Color = System.Drawing.Color.Red
        Me.surfaceSeries1.Brush.Visible = False
        ' 
        ' surfaceSeries1.Marks
        ' 
        ' 
        ' surfaceSeries1.Marks.Symbol
        ' 
        ' 
        ' surfaceSeries1.Marks.Symbol.Shadow
        ' 
        Me.surfaceSeries1.Marks.Symbol.Shadow.Height = 1
        Me.surfaceSeries1.Marks.Symbol.Shadow.Visible = True
        Me.surfaceSeries1.Marks.Symbol.Shadow.Width = 1
        Me.surfaceSeries1.NumXValues = 25
        Me.surfaceSeries1.NumZValues = 25
        Me.surfaceSeries1.PaletteMin = 0
        Me.surfaceSeries1.PaletteStep = 0
        Me.surfaceSeries1.Title = "surfaceSeries1"
        Me.surfaceSeries1.UseColorRange = False
        Me.surfaceSeries1.UsePalette = True
        Me.surfaceSeries1.WireFrame = True
        ' 
        ' surfaceSeries1.XValues
        ' 
        Me.surfaceSeries1.XValues.DataMember = "X"
        ' 
        ' surfaceSeries1.YValues
        ' 
        Me.surfaceSeries1.YValues.DataMember = "Y"
        ' 
        ' surfaceSeries1.ZValues
        ' 
        Me.surfaceSeries1.ZValues.DataMember = "Z"
        ' 
        ' label1
        ' 
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(7, 14)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(84, 16)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Rotation center:"
        Me.label1.UseMnemonic = False
        ' 
        ' trackBar1
        ' 
        Me.trackBar1.AutoSize = False
        Me.trackBar1.Location = New System.Drawing.Point(144, 8)
        Me.trackBar1.Maximum = 100
        Me.trackBar1.Minimum = -100
        Me.trackBar1.Name = "trackBar1"
        Me.trackBar1.Size = New System.Drawing.Size(61, 35)
        Me.trackBar1.TabIndex = 2
        Me.trackBar1.TickFrequency = 20
        ' 
        ' label2
        ' 
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(136, 16)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(12, 16)
        Me.label2.TabIndex = 1
        Me.label2.Text = "&X"
        Me.label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        ' 
        ' label3
        ' 
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(212, 16)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(12, 16)
        Me.label3.TabIndex = 3
        Me.label3.Text = "&Y"
        Me.label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        ' 
        ' trackBar2
        ' 
        Me.trackBar2.AutoSize = False
        Me.trackBar2.Location = New System.Drawing.Point(224, 8)
        Me.trackBar2.Maximum = 100
        Me.trackBar2.Minimum = -100
        Me.trackBar2.Name = "trackBar2"
        Me.trackBar2.Size = New System.Drawing.Size(60, 35)
        Me.trackBar2.TabIndex = 4
        Me.trackBar2.TickFrequency = 20
        ' 
        ' label4
        ' 
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(288, 16)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(11, 16)
        Me.label4.TabIndex = 5
        Me.label4.Text = "&Z"
        Me.label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        ' 
        ' trackBar3
        ' 
        Me.trackBar3.AutoSize = False
        Me.trackBar3.Location = New System.Drawing.Point(304, 8)
        Me.trackBar3.Maximum = 100
        Me.trackBar3.Minimum = -100
        Me.trackBar3.Name = "trackBar3"
        Me.trackBar3.Size = New System.Drawing.Size(60, 35)
        Me.trackBar3.TabIndex = 6
        Me.trackBar3.TickFrequency = 20
        ' 
        ' timer1
        ' 
        Me.timer1.Interval = 20
        ' 
        ' checkBox1
        ' 
        Me.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox1.Location = New System.Drawing.Point(10, 50)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(86, 17)
        Me.checkBox1.TabIndex = 7
        Me.checkBox1.Text = "&Animate"
        ' 
        ' checkBox2
        ' 
        Me.checkBox2.Checked = True
        Me.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox2.Location = New System.Drawing.Point(136, 50)
        Me.checkBox2.Name = "checkBox2"
        Me.checkBox2.Size = New System.Drawing.Size(64, 17)
        Me.checkBox2.TabIndex = 8
        Me.checkBox2.Text = "&3D axes"
        ' 
        ' checkBox3
        ' 
        Me.checkBox3.Checked = True
        Me.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox3.Location = New System.Drawing.Point(224, 50)
        Me.checkBox3.Name = "checkBox3"
        Me.checkBox3.Size = New System.Drawing.Size(80, 17)
        Me.checkBox3.TabIndex = 9
        Me.checkBox3.Text = "&Surface"
        ' 
        ' Canvas_RotCenter
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(480, 293)
        Me.Name = "Canvas_RotCenter"
        Me.panel1.ResumeLayout(False)
        CType(Me.trackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trackBar2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trackBar3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub 'InitializeComponent 
#End Region


  Private Sub trackBar1_Scroll(ByVal sender As Object, ByVal e As System.EventArgs) Handles trackBar1.Scroll
    Dim tmp As PointXYZ
    tmp = tChart1.Graphics3D.RotationCenter
    tmp.X = Fix(trackBar1.Value)
    tChart1.Graphics3D.RotationCenter = tmp
    tChart1.Invalidate()
  End Sub 'trackBar1_Scroll


  Private Sub trackBar2_Scroll(ByVal sender As Object, ByVal e As System.EventArgs) Handles trackBar2.Scroll
    Dim tmp As PointXYZ
    tmp = tChart1.Graphics3D.RotationCenter
    tmp.Y = Fix(trackBar2.Value)
    tChart1.Graphics3D.RotationCenter = tmp
    tChart1.Invalidate()
  End Sub 'trackBar2_Scroll


    Private Sub trackBar3_Scroll(ByVal sender As Object, ByVal e As System.EventArgs) Handles trackBar3.Scroll
    Dim tmp As PointXYZ
    tmp = tChart1.Graphics3D.RotationCenter
    tmp.Z = Fix(trackBar3.Value)
    tChart1.Graphics3D.RotationCenter = tmp
    tChart1.Invalidate()
    End Sub 'trackBar3_Scroll


    Private Sub timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles timer1.Tick
        Me.tChart1.Aspect.Rotation += Delta
        If tChart1.Aspect.Rotation = 360 Then
            Delta = -1
        ElseIf tChart1.Aspect.Rotation = 270 Then
            Delta = 1
        End If
    End Sub 'timer1_Tick

    Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox1.CheckedChanged
        Me.timer1.Enabled = Me.checkBox1.Checked
    End Sub 'checkBox1_CheckedChanged


    Private Sub tChart1_AfterDraw(ByVal sender As Object, ByVal g As Steema.TeeChart.Drawing.Graphics3D) Handles tChart1.AfterDraw
        If checkBox2.Checked Then ' draw 3D axes
            Dim gr As Steema.TeeChart.Drawing.Graphics3D = tChart1.Graphics3D
            ' set pen style
            gr.Pen.Color = Color.Blue
            gr.Pen.Width = 1
            gr.Pen.Style = System.Drawing.Drawing2D.DashStyle.Dot
            ' center position
            Dim tmpY As Integer = gr.ChartYCenter + gr.RotationCenter.Y
            Dim tmpX As Integer = gr.ChartXCenter + gr.RotationCenter.X
            Dim tmpZ As Integer = tChart1.Aspect.Width3D / 2 + gr.RotationCenter.Z
            ' draw axes
            Dim cr As Rectangle = tChart1.Chart.ChartRect
            gr.HorizontalLine(cr.Left, cr.Right, tmpY, tmpZ)
            gr.VerticalLine(tmpX, cr.Top, cr.Bottom, tmpZ)
            gr.ZLine(tmpX, tmpY, 0, tChart1.Aspect.Width3D)
        End If
    End Sub 'tChart1_AfterDraw


    Private Sub checkBox3_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox3.CheckedChanged
        surfaceSeries1.Active = checkBox3.Checked
    End Sub 'checkBox3_CheckedChanged


    Private Sub checkBox2_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox2.CheckedChanged
        tChart1.Invalidate()
    End Sub 'checkBox2_CheckedChanged
End Class 'Canvas_RotCenter
