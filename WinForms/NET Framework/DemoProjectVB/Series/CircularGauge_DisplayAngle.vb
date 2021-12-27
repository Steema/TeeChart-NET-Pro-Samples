
Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Steema.TeeChart.Styles
Public Class CircularGauge_DisplayAngle
    Inherits BaseForm
    Private label1 As Label
    Private WithEvents udDisplayRotationAngle As NumericUpDown
    Private label2 As Label
    Private WithEvents upDisplayTotalAngle As NumericUpDown
    Private WithEvents udTotalAngle As NumericUpDown
    Private label3 As Label
    Private WithEvents udRotationAngle As NumericUpDown
    Private label4 As Label
    Private WithEvents timer1 As Timer
    '/ <summary>
    '/ Required designer variable.
    '/ </summary>
    Private components As System.ComponentModel.IContainer = Nothing
    '/<summary>
    '/Clean up any resources being used.
    '/</summary>
    '/<param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If (Not (components) Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"
    '/ <summary>
    '/Required method for Designer support - do not modify
    '/the contents of this method with the code editor.
    '/</summary>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.label1 = New System.Windows.Forms.Label
        Me.upDisplayTotalAngle = New System.Windows.Forms.NumericUpDown
        Me.udDisplayRotationAngle = New System.Windows.Forms.NumericUpDown
        Me.label2 = New System.Windows.Forms.Label
        Me.udTotalAngle = New System.Windows.Forms.NumericUpDown
        Me.label3 = New System.Windows.Forms.Label
        Me.udRotationAngle = New System.Windows.Forms.NumericUpDown
        Me.label4 = New System.Windows.Forms.Label
        Me.timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.panel1.SuspendLayout()
        Me.chartContainer.SuspendLayout()
        CType(Me.upDisplayTotalAngle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.udDisplayRotationAngle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.udTotalAngle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.udRotationAngle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Text = ("The new CircularGauge Properties, DisplayTotalAngle and DisplayRotationAngle, ena" & "ble" & vbCrLf & "\" & "semi-circular\" & " or \" & "partial\" & " Circular Gauge series to be displayed.")
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.udRotationAngle)
        Me.panel1.Controls.Add(Me.label4)
        Me.panel1.Controls.Add(Me.udTotalAngle)
        Me.panel1.Controls.Add(Me.label3)
        Me.panel1.Controls.Add(Me.udDisplayRotationAngle)
        Me.panel1.Controls.Add(Me.label2)
        Me.panel1.Controls.Add(Me.upDisplayTotalAngle)
        Me.panel1.Controls.Add(Me.label1)
        ' 
        ' tChart1
        ' 
        Me.tChart1.Aspect.ZOffset = 0
        Me.tChart1.Legend.TextSymbolGap = 0
        Me.tChart1.Size = New System.Drawing.Size(440, 205)
        ' 
        ' label1
        ' 
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(3, 3)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(95, 13)
        Me.label1.TabIndex = 0
        Me.label1.Text = "DisplayTotalAngle:"
        ' 
        ' upDisplayTotalAngle
        ' 
        Me.upDisplayTotalAngle.Location = New System.Drawing.Point(43, 19)
        Me.upDisplayTotalAngle.Maximum = New Decimal(New Integer() {360, 0, 0, 0})
        Me.upDisplayTotalAngle.Name = "upDisplayTotalAngle"
        Me.upDisplayTotalAngle.Size = New System.Drawing.Size(55, 20)
        Me.upDisplayTotalAngle.TabIndex = 1
        Me.upDisplayTotalAngle.Value = New Decimal(New Integer() {180, 0, 0, 0})
        AddHandler upDisplayTotalAngle.ValueChanged, AddressOf Me.upDisplayTotalAngle_ValueChanged
        ' 
        ' udDisplayRotationAngle
        ' 
        Me.udDisplayRotationAngle.Location = New System.Drawing.Point(181, 19)
        Me.udDisplayRotationAngle.Maximum = New Decimal(New Integer() {360, 0, 0, 0})
        Me.udDisplayRotationAngle.Minimum = New Decimal(New Integer() {360, 0, 0, -2147483648})
        Me.udDisplayRotationAngle.Name = "udDisplayRotationAngle"
        Me.udDisplayRotationAngle.Size = New System.Drawing.Size(55, 20)
        Me.udDisplayRotationAngle.TabIndex = 3
        Me.udDisplayRotationAngle.Value = New Decimal(New Integer() {90, 0, 0, -2147483648})
        AddHandler udDisplayRotationAngle.ValueChanged, AddressOf Me.udDisplayRotationAngle_ValueChanged
        ' 
        ' label2
        ' 
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(125, 3)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(111, 13)
        Me.label2.TabIndex = 2
        Me.label2.Text = "DisplayRotationAngle:"
        ' 
        ' udTotalAngle
        ' 
        Me.udTotalAngle.Location = New System.Drawing.Point(285, 19)
        Me.udTotalAngle.Maximum = New Decimal(New Integer() {360, 0, 0, 0})
        Me.udTotalAngle.Name = "udTotalAngle"
        Me.udTotalAngle.Size = New System.Drawing.Size(55, 20)
        Me.udTotalAngle.TabIndex = 5
        Me.udTotalAngle.Value = New Decimal(New Integer() {150, 0, 0, 0})
        AddHandler udTotalAngle.ValueChanged, AddressOf Me.udTotalAngle_ValueChanged
        ' 
        ' label3
        ' 
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(259, 3)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(61, 13)
        Me.label3.TabIndex = 4
        Me.label3.Text = "TotalAngle:"
        ' 
        ' udRotationAngle
        ' 
        Me.udRotationAngle.Location = New System.Drawing.Point(373, 19)
        Me.udRotationAngle.Maximum = New Decimal(New Integer() {360, 0, 0, 0})
        Me.udRotationAngle.Minimum = New Decimal(New Integer() {360, 0, 0, -2147483648})
        Me.udRotationAngle.Name = "udRotationAngle"
        Me.udRotationAngle.Size = New System.Drawing.Size(55, 20)
        Me.udRotationAngle.TabIndex = 7
        Me.udRotationAngle.Value = New Decimal(New Integer() {90, 0, 0, 0})
        AddHandler udRotationAngle.ValueChanged, AddressOf Me.udRotationAngle_ValueChanged
        ' 
        ' label4
        ' 
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(347, 3)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(77, 13)
        Me.label4.TabIndex = 6
        Me.label4.Text = "RotationAngle:"
        ' 
        ' timer1
        ' 
        Me.timer1.Interval = 10
        AddHandler timer1.Tick, AddressOf Me.timer1_Tick
        ' 
        ' CircularGauge_DisplayAngle
        ' 
#If (VS2005) Then
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
#End If
        Me.ClientSize = New System.Drawing.Size(440, 317)
        Me.Name = "CircularGauge_DisplayAngle"
        Me.Text = "CircularGauge_DisplayAngle"
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.chartContainer.ResumeLayout(False)
        CType(Me.upDisplayTotalAngle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.udDisplayRotationAngle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.udTotalAngle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.udRotationAngle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub
#End Region
    Private cGauge As CircularGauge
    Private up As Boolean = True
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        InitializeChart()
    End Sub
    Private Sub InitializeChart()
        cGauge = New CircularGauge()
        tChart1.Series.Add(cGauge)
        cGauge.DisplayTotalAngle = 180
        cGauge.DisplayRotationAngle = -90
        cGauge.TotalAngle = 150
        cGauge.RotationAngle = 90
        cGauge.Value = 1
        cGauge.Axis.Labels.Font.Size = 7
        cGauge.Axis.Labels.Font.Color = CustomGauge.GetGaugePaletteColor(20, cGauge.GaugeColorPalette)
        cGauge.FaceBrush.Color = Color.FromArgb(255, 255, 192)
        cGauge.FaceBrush.Gradient.Visible = False
        timer1.Enabled = True
    End Sub

    Private Sub upDisplayTotalAngle_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
        cGauge.DisplayTotalAngle = CType(upDisplayTotalAngle.Value, Integer)
    End Sub

    Private Sub udDisplayRotationAngle_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
        cGauge.DisplayRotationAngle = CType(udDisplayRotationAngle.Value, Integer)
    End Sub

    Private Sub udTotalAngle_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
        cGauge.TotalAngle = CType(udTotalAngle.Value, Integer)
    End Sub

    Private Sub udRotationAngle_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
        cGauge.RotationAngle = CType(udRotationAngle.Value, Integer)
    End Sub
    Private Sub timer1_Tick(ByVal sender As Object, ByVal e As EventArgs)
        If ((CType(cGauge.Value, Integer) = 100) Or (CType(cGauge.Value, Integer) = 0)) Then
            up = Not up
        End If
        If up Then
            cGauge.Value = (cGauge.Value + 1)
        Else
            cGauge.Value = (cGauge.Value - 1)
        End If
    End Sub
End Class