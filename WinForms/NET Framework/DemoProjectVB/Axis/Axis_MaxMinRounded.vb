Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Public Class Axis_MaxMinRounded
    Inherits Samples.BaseForm
    Private label1 As Label
    Private WithEvents cbAxis As ComboBox
    Private WithEvents cbRoundMin As CheckBox
    Private WithEvents cbRoundMax As CheckBox
    Private components As System.ComponentModel.IContainer = Nothing
    '/ <summary>
    '/Clean up any resources being used.
    '/ </summary>
    '/ <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub 'Dispose

#Region "Windows Form Designer generated code"

    '/ <summary>
    '/ Required method for Designer support - do not modify
    '/ the contents of this method with the code editor.
    '/ </summary>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Axis_MaxMinRounded))
        Me.cbAxis = New System.Windows.Forms.ComboBox
        Me.label1 = New System.Windows.Forms.Label
        Me.cbRoundMax = New System.Windows.Forms.CheckBox
        Me.cbRoundMin = New System.Windows.Forms.CheckBox
        Me.panel1.SuspendLayout()
        Me.chartContainer.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Text = resources.GetString("textBox1.Text")
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.cbRoundMin)
        Me.panel1.Controls.Add(Me.cbRoundMax)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Controls.Add(Me.cbAxis)
        ' 
        ' tChart1
        ' 
        ' 
        Me.tChart1.Legend.Title.Pen.Visible = False
        Me.tChart1.Size = New System.Drawing.Size(440, 205)
        ' 
        ' cbAxis
        ' 
#If (VS2005) Then
        Me.cbAxis.FormattingEnabled = True
#End If
        Me.cbAxis.Items.AddRange(New Object() {"Left", "Bottom"})
        Me.cbAxis.Location = New System.Drawing.Point(47, 12)
        Me.cbAxis.Name = "cbAxis"
        Me.cbAxis.Size = New System.Drawing.Size(78, 21)
        Me.cbAxis.TabIndex = 0
        Me.cbAxis.Text = "Left"
        AddHandler cbAxis.SelectedIndexChanged, AddressOf Me.cbAxis_SelectedIndexChanged
        ' 
        ' label1
        ' 
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(12, 15)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(29, 13)
        Me.label1.TabIndex = 1
        Me.label1.Text = "&Axis:"
        ' 
        ' cbRoundMax
        ' 
        Me.cbRoundMax.Checked = True
        Me.cbRoundMax.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbRoundMax.Location = New System.Drawing.Point(131, 14)
        Me.cbRoundMax.Name = "cbRoundMax"
        Me.cbRoundMax.Size = New System.Drawing.Size(117, 17)
        Me.cbRoundMax.TabIndex = 2
        Me.cbRoundMax.Text = "&Maximum Rounded"
#If (VS2005) Then
        Me.cbRoundMax.AutoSize = True
        Me.cbRoundMax.UseVisualStyleBackColor = True
#End If
        AddHandler cbRoundMax.CheckedChanged, AddressOf Me.cbRoundMax_CheckedChanged
        ' 
        ' cbRoundMin
        ' 
        Me.cbRoundMin.Checked = True
        Me.cbRoundMin.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbRoundMin.Location = New System.Drawing.Point(254, 14)
        Me.cbRoundMin.Name = "cbRoundMin"
        Me.cbRoundMin.Size = New System.Drawing.Size(114, 17)
        Me.cbRoundMin.TabIndex = 3
        Me.cbRoundMin.Text = "Minimum &Rounded"
#If (VS2005) Then
        Me.cbRoundMin.AutoSize = True
        Me.cbRoundMin.UseVisualStyleBackColor = True
#End If
        AddHandler cbRoundMin.CheckedChanged, AddressOf Me.cbRoundMin_CheckedChanged
        ' 
        ' Axis_MaxMinRounded
        ' 
#If (VS2005) Then
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
#End If
        Me.ClientSize = New System.Drawing.Size(440, 317)
        Me.Name = "Axis_MaxMinRounded"
        Me.Text = "Axis_MaxMinRounded"
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.chartContainer.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub
#End Region
    Public Sub New()
        InitializeComponent()
        InitializeChart()
    End Sub
    Dim fastLine As Steema.TeeChart.Styles.FastLine
    Private Sub InitializeChart()
        tChart1.Aspect.View3D = False
        tChart1.Legend.Visible = False
        tChart1.Panel.Color = Color.Black
        tChart1.Panel.Gradient.Visible = False
        tChart1.Axes.Bottom.Labels.Font.Color = Color.White
        tChart1.Axes.Left.Labels.Font.Color = Color.White
        tChart1.Walls.Back.Brush.Gradient.Visible = False
        tChart1.Walls.Back.Color = Color.Black
        fastLine = New Steema.TeeChart.Styles.FastLine()

        tChart1.Series.Add(fastLine)
        fastLine.FillSampleValues(200)

        tChart1.Axes.Left.MaximumRound = True
        tChart1.Axes.Left.MinimumRound = True
    End Sub
    Private Function TheAxis() As Axis
        If (cbAxis.SelectedIndex = 0) Then
            Return tChart1.Axes.Left
        Else
            Return tChart1.Axes.Bottom
        End If
    End Function

    Private Sub cbAxis_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
        cbRoundMax.Checked = TheAxis.MaximumRound
        cbRoundMin.Checked = TheAxis.MinimumRound
    End Sub

    Private Sub cbRoundMax_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
        TheAxis.MaximumRound = cbRoundMax.Checked
    End Sub

    Private Sub cbRoundMin_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
        TheAxis.MinimumRound = cbRoundMin.Checked
    End Sub
End Class