
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms


Public Class Series_Gauge
    Inherits Steema.TeeChart.Samples.BaseForm
    Private gauges1 As Steema.TeeChart.Styles.Gauges
    Private BEdit As System.Windows.Forms.Button
    Private trackBar1 As System.Windows.Forms.TrackBar
    Private label1 As System.Windows.Forms.Label
    Private components As System.ComponentModel.IContainer = Nothing
    
    Public Sub New() ' This call is required by the Windows Form Designer.
        InitializeComponent()

        trackBar1.Value = CType(gauges1.Value, Integer)
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
        Me.gauges1 = New Steema.TeeChart.Styles.Gauges
        Me.BEdit = New System.Windows.Forms.Button
        Me.trackBar1 = New System.Windows.Forms.TrackBar
        Me.label1 = New System.Windows.Forms.Label
        Me.panel1.SuspendLayout()
        CType(Me.trackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Text = "Gauge series displays industrial instrumentation controls. " + vbCr + vbLf + "Lots of properties allow full customization."
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Controls.Add(Me.trackBar1)
        Me.panel1.Controls.Add(Me.BEdit)
        Me.panel1.Name = "panel1"
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
        ' tChart1.Axes.Left
        ' 
        Me.tChart1.Axes.Left.Increment = 10
        Me.tChart1.BackColor = System.Drawing.Color.Transparent
        ' 
        ' tChart1.Header
        ' 
        Me.tChart1.Header.Lines = New String() {"Volts"}
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Bevel
        ' 
        Me.tChart1.Panel.Bevel.ColorOne = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.tChart1.Panel.Bevel.ColorTwo = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(128, System.Byte), CType(128, System.Byte), CType(128, System.Byte))
        ' 
        ' tChart1.Panel.Brush
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(128, System.Byte))
        ' 
        ' tChart1.Panel.Gradient
        ' 
        Me.tChart1.Panel.Brush.Gradient.Angle = 15
        Me.tChart1.Panel.Brush.Gradient.Direction = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(192, System.Byte), CType(192, System.Byte), CType(0, System.Byte))
        Me.tChart1.Panel.Brush.Gradient.Visible = True
        ' 
        ' tChart1.Panel.Gradient
        ' 
        Me.tChart1.Panel.Gradient.Angle = 15
        Me.tChart1.Panel.Gradient.Direction = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.tChart1.Panel.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(192, System.Byte), CType(192, System.Byte), CType(0, System.Byte))
        Me.tChart1.Panel.Gradient.Visible = True
        Me.tChart1.Series.Add(Me.gauges1)
        ' 
        ' tChart1.Walls
        ' 
        ' 
        ' tChart1.Walls.Back
        ' 
        ' 
        ' tChart1.Walls.Back.Brush
        ' 
        Me.tChart1.Walls.Back.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.tChart1.Walls.Back.Transparent = False
        ' 
        ' gauges1
        ' 
        ' 
        ' gauges1.Center
        ' 
        ' 
        ' gauges1.Center.Brush
        ' 
        Me.gauges1.Center.Brush.Color = System.Drawing.Color.Black
        Me.gauges1.Center.HorizSize = 8
        Me.gauges1.Center.Style = Steema.TeeChart.Styles.PointerStyles.Circle
        Me.gauges1.Center.VertSize = 8
        Me.gauges1.Circled = True
        ' 
        ' gauges1.EndPoint
        ' 
        Me.gauges1.EndPoint.HorizSize = 3
        Me.gauges1.EndPoint.Style = Steema.TeeChart.Styles.PointerStyles.Circle
        Me.gauges1.EndPoint.VertSize = 3
        Me.gauges1.EndPoint.Visible = False
        ' 
        ' gauges1.Marks
        ' 
        ' 
        ' gauges1.Marks.Symbol
        ' 
        ' 
        ' gauges1.Marks.Symbol.Shadow
        ' 
        Me.gauges1.Marks.Symbol.Shadow.Height = 1
        Me.gauges1.Marks.Symbol.Shadow.Visible = True
        Me.gauges1.Marks.Symbol.Shadow.Width = 1
        Me.gauges1.Maximum = 100
        Me.gauges1.Minimum = 0
        Me.gauges1.RotationAngle = 135
        Me.gauges1.ShowInLegend = False
        Me.gauges1.Title = "gauges1"
        Me.gauges1.TotalAngle = 90
        Me.gauges1.Value = 66.859565287297386
        ' 
        ' gauges1.XValues
        ' 
        Me.gauges1.XValues.DataMember = "Angle"
        Me.gauges1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' gauges1.YValues
        ' 
        Me.gauges1.YValues.DataMember = "Y"
        AddHandler Me.gauges1.OnChange, AddressOf Me.gauges1_OnChange
        ' 
        ' BEdit
        ' 
        Me.BEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BEdit.Location = New System.Drawing.Point(16, 8)
        Me.BEdit.Name = "BEdit"
        Me.BEdit.TabIndex = 0
        Me.BEdit.Text = "Edit..."
        AddHandler Me.BEdit.Click, AddressOf Me.BEdit_Click
        ' 
        ' trackBar1
        ' 
        Me.trackBar1.LargeChange = 20
        Me.trackBar1.Location = New System.Drawing.Point(148, 6)
        Me.trackBar1.Maximum = 100
        Me.trackBar1.Name = "trackBar1"
        Me.trackBar1.Size = New System.Drawing.Size(132, 42)
        Me.trackBar1.TabIndex = 1
        Me.trackBar1.TickFrequency = 10
        Me.trackBar1.Value = 1
        AddHandler Me.trackBar1.Scroll, AddressOf Me.trackBar1_Scroll
        ' 
        ' label1
        ' 
        Me.label1.Location = New System.Drawing.Point(296, 12)
        Me.label1.Name = "label1"
        Me.label1.TabIndex = 2
        ' 
        ' SeriesType_Gauges
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(440, 317)
        Me.Name = "SeriesType_Gauges"
        Me.panel1.ResumeLayout(False)
        CType(Me.trackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub 'New 
#End Region


    Private Sub BEdit_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        'Steema.TeeChart.Editors.EditorUtils.ShowFormModal(new Steema.TeeChart.Editors.Series.GaugesSeries(gauges1));
        Steema.TeeChart.Editors.SeriesEditor.ShowEditor(gauges1)
    End Sub 'BEdit_Click


    Private Sub trackBar1_Scroll(ByVal sender As Object, ByVal e As System.EventArgs)
        gauges1.Value = System.Convert.ToDouble(trackBar1.Value)
    End Sub 'trackBar1_Scroll


    Private Sub gauges1_OnChange(ByVal sender As Object, ByVal e As System.EventArgs)
        label1.Text = gauges1.Value.ToString()
    End Sub 'gauges1_OnChange
End Class 'Series_Gauge