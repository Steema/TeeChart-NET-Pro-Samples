
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing

Imports System.Windows.Forms




Public Class SeriesType_Point3D
    Inherits Samples.BaseForm
    Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
    Private WithEvents checkBox2 As System.Windows.Forms.CheckBox
    Private WithEvents checkBox3 As System.Windows.Forms.CheckBox
    Private WithEvents checkBox4 As System.Windows.Forms.CheckBox
    Private WithEvents checkBox5 As System.Windows.Forms.CheckBox
    Private WithEvents checkBox6 As System.Windows.Forms.CheckBox
    Private point3DSeries1 As Steema.TeeChart.Styles.Points3D
    Private components As System.ComponentModel.IContainer = Nothing
    
    Private Shared DeltaRotate As Integer = - 5
    Private WithEvents timer1 As System.Windows.Forms.Timer
    Private gridBand1 As Steema.TeeChart.Tools.GridBand
    Private Shared DeltaElevate As Integer = - 4
    
    
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        
        point3DSeries1.FillSampleValues(100)
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
        Me.checkBox4 = New System.Windows.Forms.CheckBox
        Me.checkBox5 = New System.Windows.Forms.CheckBox
        Me.checkBox6 = New System.Windows.Forms.CheckBox
        Me.point3DSeries1 = New Steema.TeeChart.Styles.Points3D
        Me.timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.gridBand1 = New Steema.TeeChart.Tools.GridBand
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(466, 63)
        Me.textBox1.Text = "The Point 3D series draws points at any XYZ position, using a standard ""Pointer"" " + "object.  Lines between points can also be displayed." + vbCr + vbLf + vbCr + vbLf + "Zoom, rotation, elevatio" + "n and scrolling are also supported."
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.checkBox6)
        Me.panel1.Controls.Add(Me.checkBox5)
        Me.panel1.Controls.Add(Me.checkBox4)
        Me.panel1.Controls.Add(Me.checkBox3)
        Me.panel1.Controls.Add(Me.checkBox2)
        Me.panel1.Controls.Add(Me.checkBox1)
        Me.panel1.Location = New System.Drawing.Point(0, 63)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(466, 49)
        ' 
        ' tChart1
        ' 
        ' 
        ' tChart1.Aspect
        ' 
        Me.tChart1.Aspect.Chart3DPercent = 100
        Me.tChart1.Aspect.Orthogonal = False
        Me.tChart1.Aspect.Perspective = 55
        Me.tChart1.Aspect.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality
        Me.tChart1.Aspect.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        Me.tChart1.Aspect.Zoom = 86
        ' 
        ' tChart1.Axes
        ' 
        ' 
        ' tChart1.Axes.Depth
        ' 
        Me.tChart1.Axes.Depth.Visible = True
        Me.tChart1.BackColor = System.Drawing.Color.Transparent
        ' 
        ' tChart1.Header
        ' 
        Me.tChart1.Header.Lines = New String() {"tChart1"}
        Me.tChart1.Header.Visible = False
        ' 
        ' tChart1.Legend
        ' 
        Me.tChart1.Legend.Alignment = Steema.TeeChart.LegendAlignments.Top
        Me.tChart1.Legend.Visible = False
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Brush
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.tChart1.Series.Add(Me.point3DSeries1)
        Me.tChart1.Size = New System.Drawing.Size(466, 174)
        Me.tChart1.Tools.Add(Me.gridBand1)
        ' 
        ' tChart1.Walls
        ' 
        ' 
        ' tChart1.Walls.Back
        ' 
        ' 
        ' tChart1.Walls.Back.Brush
        ' 
        Me.tChart1.Walls.Back.Brush.Color = System.Drawing.Color.FromArgb(CType(204, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        ' 
        ' tChart1.Walls.Back.Gradient
        ' 
        Me.tChart1.Walls.Back.Brush.Gradient.Transparency = 20
        ' 
        ' tChart1.Walls.Back.Gradient
        ' 
        Me.tChart1.Walls.Back.Gradient.Transparency = 20
        ' 
        ' tChart1.Walls.Back.Pen
        ' 
        Me.tChart1.Walls.Back.Pen.Visible = False
        Me.tChart1.Walls.Back.Transparent = False
        ' 
        ' tChart1.Walls.Bottom
        ' 
        ' 
        ' tChart1.Walls.Bottom.Brush
        ' 
        Me.tChart1.Walls.Bottom.Brush.Color = System.Drawing.Color.FromArgb(CType(153, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        ' 
        ' tChart1.Walls.Bottom.Gradient
        ' 
        Me.tChart1.Walls.Bottom.Brush.Gradient.Transparency = 40
        ' 
        ' tChart1.Walls.Bottom.Gradient
        ' 
        Me.tChart1.Walls.Bottom.Gradient.Transparency = 40
        ' 
        ' tChart1.Walls.Bottom.Pen
        ' 
        Me.tChart1.Walls.Bottom.Pen.Transparency = 20
        Me.tChart1.Walls.Bottom.Pen.Visible = False
        Me.tChart1.Walls.Bottom.Size = 3
        ' 
        ' tChart1.Walls.Left
        ' 
        ' 
        ' tChart1.Walls.Left.Brush
        ' 
        Me.tChart1.Walls.Left.Brush.Color = System.Drawing.Color.FromArgb(CType(153, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(224, System.Byte))
        ' 
        ' tChart1.Walls.Left.Gradient
        ' 
        Me.tChart1.Walls.Left.Brush.Gradient.Transparency = 40
        ' 
        ' tChart1.Walls.Left.Gradient
        ' 
        Me.tChart1.Walls.Left.Gradient.Transparency = 40
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
        Me.checkBox1.Location = New System.Drawing.Point(13, 14)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(54, 21)
        Me.checkBox1.TabIndex = 0
        Me.checkBox1.Text = "&Lines"
        ' 
        ' checkBox2
        ' 
        Me.checkBox2.Checked = True
        Me.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox2.Location = New System.Drawing.Point(67, 14)
        Me.checkBox2.Name = "checkBox2"
        Me.checkBox2.Size = New System.Drawing.Size(53, 21)
        Me.checkBox2.TabIndex = 1
        Me.checkBox2.Text = "&Walls"
        ' 
        ' checkBox3
        ' 
        Me.checkBox3.Checked = True
        Me.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox3.Location = New System.Drawing.Point(120, 14)
        Me.checkBox3.Name = "checkBox3"
        Me.checkBox3.Size = New System.Drawing.Size(53, 21)
        Me.checkBox3.TabIndex = 2
        Me.checkBox3.Text = "&Axes"
        ' 
        ' checkBox4
        ' 
        Me.checkBox4.Checked = True
        Me.checkBox4.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox4.Location = New System.Drawing.Point(167, 14)
        Me.checkBox4.Name = "checkBox4"
        Me.checkBox4.Size = New System.Drawing.Size(65, 21)
        Me.checkBox4.TabIndex = 3
        Me.checkBox4.Text = "&Points"
        ' 
        ' checkBox5
        ' 
        Me.checkBox5.Checked = True
        Me.checkBox5.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox5.Location = New System.Drawing.Point(220, 14)
        Me.checkBox5.Name = "checkBox5"
        Me.checkBox5.Size = New System.Drawing.Size(92, 21)
        Me.checkBox5.TabIndex = 4
        Me.checkBox5.Text = "&Color each"
        ' 
        ' checkBox6
        ' 
        Me.checkBox6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox6.Location = New System.Drawing.Point(333, 14)
        Me.checkBox6.Name = "checkBox6"
        Me.checkBox6.Size = New System.Drawing.Size(91, 21)
        Me.checkBox6.TabIndex = 5
        Me.checkBox6.Text = "A&nimate"
        ' 
        ' point3DSeries1
        ' 
        Me.point3DSeries1.ColorEach = True
        ' 
        ' point3DSeries1.Marks
        ' 
        ' 
        ' point3DSeries1.Marks.Symbol
        ' 
        ' 
        ' point3DSeries1.Marks.Symbol.Shadow
        ' 
        Me.point3DSeries1.Marks.Symbol.Shadow.Height = 1
        Me.point3DSeries1.Marks.Symbol.Shadow.Visible = True
        Me.point3DSeries1.Marks.Symbol.Shadow.Width = 1
        ' 
        ' point3DSeries1.Pointer
        ' 
        ' 
        ' point3DSeries1.Pointer.Brush
        ' 
        Me.point3DSeries1.Pointer.Brush.Color = System.Drawing.Color.FromArgb(CType(255, System.Byte), CType(255, System.Byte), CType(204, System.Byte))
        Me.point3DSeries1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.point3DSeries1.Title = "point3D1"
        ' 
        ' point3DSeries1.XValues
        ' 
        Me.point3DSeries1.XValues.DataMember = "X"
        ' 
        ' point3DSeries1.YValues
        ' 
        Me.point3DSeries1.YValues.DataMember = "Y"
        ' 
        ' point3DSeries1.ZValues
        ' 
        Me.point3DSeries1.ZValues.DataMember = "Z"
        ' 
        ' timer1
        ' 
        Me.timer1.Interval = 1
        ' 
        ' gridBand1
        ' 
        Me.gridBand1.Axis = Me.tChart1.Axes.Left
        ' 
        ' gridBand1.Band1
        ' 
        Me.gridBand1.Band1.Color = System.Drawing.Color.FromArgb(CType(127, System.Byte), CType(224, System.Byte), CType(224, System.Byte), CType(224, System.Byte))
        ' 
        ' gridBand1.Band2
        ' 
        Me.gridBand1.Band2.Color = System.Drawing.Color.FromArgb(CType(127, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        ' 
        ' SeriesType_Point3D
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(466, 286)
        Me.Name = "SeriesType_Point3D"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub 'InitializeComponent 
#End Region


    Private Sub checkBox6_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox6.CheckedChanged
        timer1.Enabled = checkBox6.Checked
    End Sub 'checkBox6_CheckedChanged


    Private Sub timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles timer1.Tick
        timer1.Stop()
        Try
            Dim asp As Steema.TeeChart.Drawing.Aspect = tChart1.Aspect
            asp.Rotation += DeltaRotate
            If asp.Rotation < 280 OrElse asp.Rotation > 350 Then
                DeltaRotate = -DeltaRotate
            End If
            asp.Elevation += DeltaElevate
            If asp.Elevation < 280 OrElse asp.Elevation > 350 Then
                DeltaElevate = -DeltaElevate
            End If
        Finally
            timer1.Start()
        End Try
    End Sub 'timer1_Tick


    Private Sub checkBox2_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox2.CheckedChanged
        tChart1.Walls.Visible = checkBox2.Checked
    End Sub 'checkBox2_CheckedChanged


    Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox1.CheckedChanged
        point3DSeries1.LinePen.Visible = checkBox1.Checked
    End Sub 'checkBox1_CheckedChanged


    Private Sub checkBox3_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox3.CheckedChanged
        tChart1.Axes.Visible = checkBox3.Checked
    End Sub 'checkBox3_CheckedChanged


    Private Sub checkBox4_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox4.CheckedChanged
        Me.point3DSeries1.Pointer.Visible = checkBox4.Checked
    End Sub 'checkBox4_CheckedChanged


    Private Sub checkBox5_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox5.CheckedChanged
        point3DSeries1.ColorEach = checkBox5.Checked
    End Sub 'checkBox5_CheckedChanged
End Class 'SeriesType_Point3D
