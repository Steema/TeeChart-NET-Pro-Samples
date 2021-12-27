Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Steema.TeeChart.Styles
Public Class CircularGauge_LGauge
    Inherits BaseForm
    Private WithEvents timer1 As Timer
    Private WithEvents cbHoriz As CheckBox
    Private WithEvents groupBox1 As GroupBox
    Private WithEvents cbAutoPosition As CheckBox
    Private WithEvents udTop As NumericUpDown
    Private label2 As Label
    Private label1 As Label
    Private WithEvents udLeft As NumericUpDown
    Private WithEvents cbSameValue As CheckBox
    Private WithEvents timer2 As Timer
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
    'Required method for Designer support - do not modify
    'the contents of this method with the code editor.
    '/</summary>"    Private Sub InitializeComponent()
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.cbHoriz = New System.Windows.Forms.CheckBox
        Me.groupBox1 = New System.Windows.Forms.GroupBox
        Me.cbAutoPosition = New System.Windows.Forms.CheckBox
        Me.udTop = New System.Windows.Forms.NumericUpDown
        Me.label2 = New System.Windows.Forms.Label
        Me.label1 = New System.Windows.Forms.Label
        Me.udLeft = New System.Windows.Forms.NumericUpDown
        Me.cbSameValue = New System.Windows.Forms.CheckBox
        Me.timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.panel1.SuspendLayout()
        Me.chartContainer.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        CType(Me.udTop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.udLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Text = ("CircularGauge also has new LinearGauge, AutoPositionLinearGauge " & vbCrLf & "and AutoValueLi" & "nearGauge properties, which enable a Linear Gauge" & vbCrLf & "to be embedded within it.")
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.groupBox1)
        Me.panel1.Controls.Add(Me.cbSameValue)
        Me.panel1.Controls.Add(Me.cbHoriz)
        ' 
        ' tChart1
        ' 
        Me.tChart1.Aspect.ZOffset = 0
        Me.tChart1.Axes.Bottom.Title.Transparent = True
        Me.tChart1.Axes.Depth.Title.Transparent = True
        Me.tChart1.Axes.DepthTop.Title.Transparent = True
        Me.tChart1.Axes.Left.Title.Transparent = True
        Me.tChart1.Axes.Right.Title.Transparent = True
        Me.tChart1.Axes.Top.Title.Transparent = True
        Me.tChart1.Legend.TextSymbolGap = 0
        Me.tChart1.Size = New System.Drawing.Size(440, 205)
        ' 
        ' timer1
        ' 
        AddHandler timer1.Tick, AddressOf Me.timer1_Tick
        ' 
        ' cbHoriz
        ' 
        Me.cbHoriz.AutoSize = True
        Me.cbHoriz.Location = New System.Drawing.Point(12, 3)
        Me.cbHoriz.Name = "cbHoriz"
        Me.cbHoriz.Size = New System.Drawing.Size(73, 17)
        Me.cbHoriz.TabIndex = 0
        Me.cbHoriz.Text = "&Horizontal"
        Me.cbHoriz.UseVisualStyleBackColor = True
        AddHandler cbHoriz.CheckedChanged, AddressOf Me.cbHoriz_CheckedChanged
        ' 
        ' groupBox1
        ' 
        Me.groupBox1.Controls.Add(Me.cbAutoPosition)
        Me.groupBox1.Controls.Add(Me.udTop)
        Me.groupBox1.Controls.Add(Me.label2)
        Me.groupBox1.Controls.Add(Me.label1)
        Me.groupBox1.Controls.Add(Me.udLeft)
        Me.groupBox1.Location = New System.Drawing.Point(129, 2)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(299, 35)
        Me.groupBox1.TabIndex = 7
        Me.groupBox1.TabStop = False
        ' 
        ' cbAutoPosition
        ' 
        Me.cbAutoPosition.AutoSize = True
        Me.cbAutoPosition.Checked = True
        Me.cbAutoPosition.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbAutoPosition.Location = New System.Drawing.Point(6, 12)
        Me.cbAutoPosition.Name = "cbAutoPosition"
        Me.cbAutoPosition.Size = New System.Drawing.Size(88, 17)
        Me.cbAutoPosition.TabIndex = 6
        Me.cbAutoPosition.Text = "Auto Position"
        Me.cbAutoPosition.UseVisualStyleBackColor = True
        ' 
        ' udTop
        ' 
        Me.udTop.Enabled = False
        Me.udTop.Location = New System.Drawing.Point(135, 10)
        Me.udTop.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.udTop.Name = "udTop"
        Me.udTop.Size = New System.Drawing.Size(56, 20)
        Me.udTop.TabIndex = 1
        AddHandler udTop.Click, AddressOf Me.udTop_Click
        ' 
        ' label2
        ' 
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(197, 13)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(28, 13)
        Me.label2.TabIndex = 4
        Me.label2.Text = "Left:"
        ' 
        ' label1
        ' 
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(100, 13)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(29, 13)
        Me.label1.TabIndex = 2
        Me.label1.Text = "Top:"
        ' 
        ' udLeft
        ' 
        Me.udLeft.Enabled = False
        Me.udLeft.Location = New System.Drawing.Point(231, 10)
        Me.udLeft.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.udLeft.Name = "udLeft"
        Me.udLeft.Size = New System.Drawing.Size(56, 20)
        Me.udLeft.TabIndex = 3
        AddHandler udLeft.Click, AddressOf Me.udLeft_Click
        ' 
        ' cbSameValue
        ' 
        Me.cbSameValue.AutoSize = True
        Me.cbSameValue.Checked = True
        Me.cbSameValue.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbSameValue.Location = New System.Drawing.Point(12, 19)
        Me.cbSameValue.Name = "cbSameValue"
        Me.cbSameValue.Size = New System.Drawing.Size(83, 17)
        Me.cbSameValue.TabIndex = 6
        Me.cbSameValue.Text = "Same Value"
        Me.cbSameValue.UseVisualStyleBackColor = True
        ' 
        ' timer2
        ' 
        AddHandler timer2.Tick, AddressOf Me.timer2_Tick
        ' 
        ' CircularGauge_LGauge
        ' 
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(440, 317)
        Me.Name = "CircularGauge_LGauge"
        Me.Text = "CircularGauge_LGauge"
        AddHandler Load, AddressOf Me.CircularGauge_LGauge_Load
        AddHandler Resize, AddressOf Me.CircularGauge_LGauge_Resize
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.chartContainer.ResumeLayout(False)
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        CType(Me.udTop, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.udLeft, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub
#End Region

    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        InitializeChart()
    End Sub
    Private cGauge As CircularGauge
    Private up As Boolean = True
    Private rnd As Random = New Random
    Private Sub InitializeChart()
        cGauge = New CircularGauge()
        tChart1.Series.Add(cGauge)
        cGauge.LinearGauge.Visible = True
        cGauge.Value = 1
        cGauge.Axis.Labels.Font.Size = 7
        cGauge.Axis.Labels.Font.Color = CustomGauge.GetGaugePaletteColor(20, cGauge.GaugeColorPalette)
        cGauge.TotalAngle = 280
        timer1.Interval = 10
        timer2.Interval = 500

        AddHandler cbSameValue.CheckedChanged, AddressOf Me.cbSameValue_CheckedChanged
        AddHandler cbAutoPosition.CheckedChanged, AddressOf Me.cbAutoPosition_CheckedChanged
    End Sub

    Private Sub timer1_Tick(ByVal sender As Object, ByVal e As EventArgs)
        If ((CType(cGauge.Value, Integer) = 100) Or (CType(cGauge.Value, Integer) = 0)) Then
            up = Not up
        End If
        If up Then
            cGauge.Value = (cGauge.Value + 0.1)
        Else
            cGauge.Value = (cGauge.Value - 0.1)
        End If
    End Sub

    Private Sub cbHoriz_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
        cGauge.LinearGauge.Horizontal = cbHoriz.Checked
        cGauge.LinearGauge.Axis.Title.Visible = False
        cGauge.LinearGauge.Axis.Increment = 50
        cGauge.LinearGauge.Axis.Labels.Font.Size = 7
        cGauge.LinearGauge.Axis.Labels.Font.Color = CustomGauge.GetGaugePaletteColor(20, cGauge.GaugeColorPalette)
    End Sub

    Private Sub cbSameValue_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
        cGauge.AutoValueLinearGauge = cbSameValue.Checked
        timer2.Enabled = Not cbSameValue.Checked
    End Sub

    Private Sub ResetUpDowns()
        udTop.Value = cGauge.LinearGauge.CustomBounds.Top
        udLeft.Value = cGauge.LinearGauge.CustomBounds.Left
    End Sub

    Private Sub udTop_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim tmpR As Rectangle
        tmpR = cGauge.LinearGauge.CustomBounds
        tmpR.Y = CType(udTop.Value, Integer)
        cGauge.LinearGauge.CustomBounds = tmpR
    End Sub

    Private Sub udLeft_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim tmpR As Rectangle
        tmpR = cGauge.LinearGauge.CustomBounds
        tmpR.X = CType(udLeft.Value, Integer)
        cGauge.LinearGauge.CustomBounds = tmpR
    End Sub

    Private Sub cbAutoPosition_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
        cGauge.AutoPositionLinearGauge = cbAutoPosition.Checked
        udTop.Enabled = Not cbAutoPosition.Checked
        udLeft.Enabled = Not cbAutoPosition.Checked
    End Sub

    Private Sub timer2_Tick(ByVal sender As Object, ByVal e As EventArgs)
        If Not cGauge.AutoValueLinearGauge Then
            cGauge.LinearGauge.Value = rnd.Next(0, 100)
        End If
    End Sub

    Private Sub CircularGauge_LGauge_Load(ByVal sender As Object, ByVal e As EventArgs)
        tChart1.Draw()
        ResetUpDowns()
        timer1.Enabled = True
    End Sub

    Private Sub CircularGauge_LGauge_Resize(ByVal sender As Object, ByVal e As EventArgs)
        If Not (cGauge Is Nothing) Then
            ResetUpDowns()
        End If
    End Sub
End Class