
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing

Imports System.Windows.Forms




Public Class SeriesType_Radar
    Inherits Samples.BaseForm
    Private radarSeries1 As Steema.TeeChart.Styles.Radar
    Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
    Private WithEvents checkBox2 As System.Windows.Forms.CheckBox
    Private WithEvents checkBox3 As System.Windows.Forms.CheckBox
    Private WithEvents checkBox4 As System.Windows.Forms.CheckBox
    Private radarSeries2 As Steema.TeeChart.Styles.Radar
    Private radarSeries3 As Steema.TeeChart.Styles.Radar
    Private components As System.ComponentModel.IContainer = Nothing
    
    
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        

        For Each s As TeeChart.Styles.Series In tChart1.Series
            s.FillSampleValues(5)
        Next s
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
        Me.radarSeries1 = New Steema.TeeChart.Styles.Radar
        Me.checkBox1 = New System.Windows.Forms.CheckBox
        Me.checkBox2 = New System.Windows.Forms.CheckBox
        Me.checkBox3 = New System.Windows.Forms.CheckBox
        Me.checkBox4 = New System.Windows.Forms.CheckBox
        Me.radarSeries2 = New Steema.TeeChart.Styles.Radar
        Me.radarSeries3 = New Steema.TeeChart.Styles.Radar
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(466, 63)
        Me.textBox1.Text = "A Radar series shows each point at a different angle.  " + vbCr + vbLf + "Several Radar series can" + " be displayed at the same time, each one with different configuration."
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.checkBox4)
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
        Me.tChart1.Axes.Bottom.Increment = 72
        ' 
        ' tChart1.Header
        ' 
        Me.tChart1.Header.Alignment = System.Drawing.StringAlignment.Near
        Me.tChart1.Header.Lines = New String() {"Radar series"}
        Me.tChart1.Location = New System.Drawing.Point(0, 96)
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
        Me.tChart1.Panel.Brush.Gradient.Direction = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(255, System.Byte), CType(255, System.Byte), CType(0, System.Byte))
        Me.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(224, System.Byte), CType(224, System.Byte), CType(224, System.Byte))
        Me.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.tChart1.Panel.Brush.Gradient.UseMiddle = True
        Me.tChart1.Panel.Brush.Gradient.Visible = True
        ' 
        ' tChart1.Panel.Gradient
        ' 
        Me.tChart1.Panel.Gradient.Direction = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.tChart1.Panel.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(255, System.Byte), CType(255, System.Byte), CType(0, System.Byte))
        Me.tChart1.Panel.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(224, System.Byte), CType(224, System.Byte), CType(224, System.Byte))
        Me.tChart1.Panel.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.tChart1.Panel.Gradient.UseMiddle = True
        Me.tChart1.Panel.Gradient.Visible = True
        Me.tChart1.Series.Add(Me.radarSeries1)
        Me.tChart1.Series.Add(Me.radarSeries2)
        Me.tChart1.Series.Add(Me.radarSeries3)
        Me.tChart1.Size = New System.Drawing.Size(466, 190)
        ' 
        ' radarSeries1
        ' 
        ' 
        ' radarSeries1.Brush
        ' 
        Me.radarSeries1.Brush.Color = System.Drawing.Color.Red
        Me.radarSeries1.Circled = True
        Me.radarSeries1.CircleLabels = True
        Me.radarSeries1.LabelMember = "Labels"
        ' 
        ' radarSeries1.Marks
        ' 
        ' 
        ' radarSeries1.Marks.Symbol
        ' 
        ' 
        ' radarSeries1.Marks.Symbol.Shadow
        ' 
        Me.radarSeries1.Marks.Symbol.Shadow.Height = 1
        Me.radarSeries1.Marks.Symbol.Shadow.Visible = True
        Me.radarSeries1.Marks.Symbol.Shadow.Width = 1
        ' 
        ' radarSeries1.Pen
        ' 
        Me.radarSeries1.Pen.Color = System.Drawing.Color.Red
        ' 
        ' radarSeries1.Pointer
        ' 
        ' 
        ' radarSeries1.Pointer.Brush
        ' 
        Me.radarSeries1.Pointer.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(0, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        Me.radarSeries1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.radarSeries1.RotationAngle = 90
        Me.radarSeries1.Title = "radar3"
        ' 
        ' radarSeries1.XValues
        ' 
        Me.radarSeries1.XValues.DataMember = "Angle"
        Me.radarSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' radarSeries1.YValues
        ' 
        Me.radarSeries1.YValues.DataMember = "Y"
        ' 
        ' checkBox1
        ' 
        Me.checkBox1.Checked = True
        Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox1.Location = New System.Drawing.Point(13, 6)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(54, 21)
        Me.checkBox1.TabIndex = 0
        Me.checkBox1.Text = "&Labels"
        ' 
        ' checkBox2
        ' 
        Me.checkBox2.Checked = True
        Me.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox2.Location = New System.Drawing.Point(73, 6)
        Me.checkBox2.Name = "checkBox2"
        Me.checkBox2.Size = New System.Drawing.Size(54, 21)
        Me.checkBox2.TabIndex = 1
        Me.checkBox2.Text = "Li&nes"
        ' 
        ' checkBox3
        ' 
        Me.checkBox3.Checked = True
        Me.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox3.Location = New System.Drawing.Point(127, 6)
        Me.checkBox3.Name = "checkBox3"
        Me.checkBox3.Size = New System.Drawing.Size(53, 21)
        Me.checkBox3.TabIndex = 2
        Me.checkBox3.Text = "&Axis"
        ' 
        ' checkBox4
        ' 
        Me.checkBox4.Checked = True
        Me.checkBox4.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox4.Location = New System.Drawing.Point(180, 6)
        Me.checkBox4.Name = "checkBox4"
        Me.checkBox4.Size = New System.Drawing.Size(108, 21)
        Me.checkBox4.TabIndex = 3
        Me.checkBox4.Text = "&Squared"
        ' 
        ' radarSeries2
        ' 
        ' 
        ' radarSeries2.Brush
        ' 
        Me.radarSeries2.Brush.Color = System.Drawing.Color.Green
        Me.radarSeries2.Circled = True
        Me.radarSeries2.CircleLabels = True
        Me.radarSeries2.LabelMember = "Labels"
        ' 
        ' radarSeries2.Marks
        ' 
        ' 
        ' radarSeries2.Marks.Symbol
        ' 
        ' 
        ' radarSeries2.Marks.Symbol.Shadow
        ' 
        Me.radarSeries2.Marks.Symbol.Shadow.Height = 1
        Me.radarSeries2.Marks.Symbol.Shadow.Visible = True
        Me.radarSeries2.Marks.Symbol.Shadow.Width = 1
        ' 
        ' radarSeries2.Pen
        ' 
        Me.radarSeries2.Pen.Color = System.Drawing.Color.Green
        ' 
        ' radarSeries2.Pointer
        ' 
        ' 
        ' radarSeries2.Pointer.Brush
        ' 
        Me.radarSeries2.Pointer.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(0, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        Me.radarSeries2.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.radarSeries2.RotationAngle = 90
        Me.radarSeries2.Title = "radar3"
        ' 
        ' radarSeries2.XValues
        ' 
        Me.radarSeries2.XValues.DataMember = "Angle"
        Me.radarSeries2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' radarSeries2.YValues
        ' 
        Me.radarSeries2.YValues.DataMember = "Y"
        ' 
        ' radarSeries3
        ' 
        ' 
        ' radarSeries3.Brush
        ' 
        Me.radarSeries3.Brush.Color = System.Drawing.Color.Gold
        Me.radarSeries3.Circled = True
        Me.radarSeries3.CircleLabels = True
        Me.radarSeries3.LabelMember = "Labels"
        ' 
        ' radarSeries3.Marks
        ' 
        ' 
        ' radarSeries3.Marks.Symbol
        ' 
        ' 
        ' radarSeries3.Marks.Symbol.Shadow
        ' 
        Me.radarSeries3.Marks.Symbol.Shadow.Height = 1
        Me.radarSeries3.Marks.Symbol.Shadow.Visible = True
        Me.radarSeries3.Marks.Symbol.Shadow.Width = 1
        ' 
        ' radarSeries3.Pen
        ' 
        Me.radarSeries3.Pen.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(0, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        ' 
        ' radarSeries3.Pointer
        ' 
        ' 
        ' radarSeries3.Pointer.Brush
        ' 
        Me.radarSeries3.Pointer.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(0, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        Me.radarSeries3.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.radarSeries3.RotationAngle = 90
        Me.radarSeries3.Title = "radar3"
        ' 
        ' radarSeries3.XValues
        ' 
        Me.radarSeries3.XValues.DataMember = "Angle"
        Me.radarSeries3.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' radarSeries3.YValues
        ' 
        Me.radarSeries3.YValues.DataMember = "Y"
        ' 
        ' SeriesType_Radar
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(466, 286)
        Me.Name = "SeriesType_Radar"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub 'InitializeComponent 
#End Region


    Private Sub checkBox4_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox4.CheckedChanged
        radarSeries1.Circled = checkBox4.Checked
        radarSeries2.Circled = checkBox4.Checked
        radarSeries3.Circled = checkBox4.Checked
    End Sub 'checkBox4_CheckedChanged


    Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox1.CheckedChanged
        radarSeries1.CircleLabels = checkBox1.Checked
    End Sub 'checkBox1_CheckedChanged


    Private Sub checkBox2_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox2.CheckedChanged
        radarSeries1.Pen.Visible = checkBox2.Checked
        radarSeries2.Pen.Visible = checkBox2.Checked
        radarSeries3.Pen.Visible = checkBox2.Checked
    End Sub 'checkBox2_CheckedChanged


    Private Sub checkBox3_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox3.CheckedChanged
        tChart1.Axes.Right.Visible = checkBox3.Checked
    End Sub 'checkBox3_CheckedChanged
End Class 'SeriesType_Radar
