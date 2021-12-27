
Imports System
#If VS2005 Then
Imports System.Collections.Generic
#End If
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Steema.TeeChart.Drawing
Imports Steema.TeeChart.Styles
Public Class Custom_Smoothed
    Inherits BaseForm
    Private panel2 As System.Windows.Forms.Panel
    Private rbLine As RadioButton
    Private rbArea As RadioButton
    Private cbSmoothed As System.Windows.Forms.CheckBox
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
    '/</summary>"    Private Sub InitializeComponent()End Class
    Private Sub InitializeComponent()
        Me.cbSmoothed = New System.Windows.Forms.CheckBox
        Me.panel2 = New System.Windows.Forms.Panel
        Me.rbLine = New System.Windows.Forms.RadioButton
        Me.rbArea = New System.Windows.Forms.RadioButton
        Me.panel1.SuspendLayout()
        Me.chartContainer.SuspendLayout()
        Me.panel2.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Text = "The Line Series Smoothed property smooths the lines between the series points."
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.panel2)
        Me.panel1.Controls.Add(Me.cbSmoothed)
        ' 
        ' tChart1
        ' 
        Me.tChart1.Aspect.ZOffset = 0
        Me.tChart1.Size = New System.Drawing.Size(440, 205)
        ' 
        ' cbSmoothed
        ' 
#If (VS2005) Then
        Me.cbSmoothed.AutoSize = True
        Me.cbSmoothed.TabIndex = 0
        Me.cbSmoothed.UseVisualStyleBackColor = True
#End If
        Me.cbSmoothed.Location = New System.Drawing.Point(16, 11)
        Me.cbSmoothed.Name = "cbSmoothed"
        Me.cbSmoothed.Size = New System.Drawing.Size(74, 17)
        Me.cbSmoothed.Text = "Smoothed"
        AddHandler cbSmoothed.Click, AddressOf Me.cbSmoothed_Click
        ' 
        ' panel2
        ' 
        Me.panel2.Controls.Add(Me.rbArea)
        Me.panel2.Controls.Add(Me.rbLine)
        Me.panel2.Location = New System.Drawing.Point(96, 4)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(194, 32)
        Me.panel2.TabIndex = 1
        ' 
        ' rbLine
        ' 
#If (VS2005) Then
        Me.rbLine.AutoSize = True
        Me.rbLine.UseVisualStyleBackColor = True
#End If
        Me.rbLine.Checked = True
        Me.rbLine.Location = New System.Drawing.Point(12, 7)
        Me.rbLine.Name = "rbLine"
        Me.rbLine.Size = New System.Drawing.Size(77, 17)
        Me.rbLine.TabIndex = 0
        Me.rbLine.TabStop = True
        Me.rbLine.Text = "Line Series"
        AddHandler rbLine.CheckedChanged, AddressOf Me.rbLine_CheckedChanged
        ' 
        ' rbArea
        '
#If (VS2005) Then
        Me.rbArea.AutoSize = True
        Me.rbArea.UseVisualStyleBackColor = True
#End If
        Me.rbArea.Location = New System.Drawing.Point(105, 8)
        Me.rbArea.Name = "rbArea"
        Me.rbArea.Size = New System.Drawing.Size(79, 17)
        Me.rbArea.TabIndex = 1
        Me.rbArea.Text = "Area Series"
        AddHandler rbArea.CheckedChanged, AddressOf Me.rbArea_CheckedChanged
        ' 
        ' Custom_Smoothed
        ' 
#If (VS2005) Then
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
#End If
        Me.ClientSize = New System.Drawing.Size(440, 317)
        Me.Name = "Custom_Smoothed"
        Me.Text = "Line_Smoothed"
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.chartContainer.ResumeLayout(False)
        Me.panel2.ResumeLayout(False)
        Me.panel2.PerformLayout()
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
    Private series1 As Steema.TeeChart.Styles.Series
    Private Sub InitializeChart()
        tChart1.Aspect.View3D = False
        tChart1.Legend.Visible = False
        tChart1.Header.Font.Color = Color.FromArgb(225, 225, 255)
        tChart1.Header.Text = "Euribor"
        tChart1.Panel.Bevel.Inner = BevelStyles.None
        tChart1.Panel.Bevel.Outer = BevelStyles.None
        tChart1.Panel.Color = Color.White
        tChart1.Panel.Gradient.Visible = False
        tChart1.Axes.Left.AxisPen.Color = Color.FromArgb(120, 60, 20)
        tChart1.Axes.Left.AxisPen.Width = 4
        tChart1.Axes.Left.MinorTicks.Visible = False
        tChart1.Axes.Left.Grid.Color = Color.FromArgb(245, 225, 170)
        tChart1.Axes.Left.Grid.Style = System.Drawing.Drawing2D.DashStyle.Solid
        tChart1.Axes.Bottom.AxisPen.Color = Color.FromArgb(120, 60, 20)
        tChart1.Axes.Bottom.Grid.Visible = False
        tChart1.Axes.Bottom.MinorTicks.Visible = False
        tChart1.Axes.Bottom.AxisPen.Width = 4
        tChart1.Walls.Back.Pen.Visible = False
        tChart1.Walls.Back.Gradient.Visible = False
        tChart1.Walls.Back.Color = Color.White
        series1 = New Steema.TeeChart.Styles.Line()
        tChart1.Series.Add(series1)
        series1.Color = Color.FromArgb(128, 128, 128)
        CType(series1, Custom).Pointer.Style = PointerStyles.Circle
        CType(series1, Custom).Pointer.Visible = True
        series1.FillSampleValues()
    End Sub

    Private Sub cbSmoothed_Click(ByVal sender As Object, ByVal e As EventArgs)
        CType(series1, Custom).Smoothed = cbSmoothed.Checked
    End Sub

    Private Sub rbLine_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
        If rbLine.Checked Then
            tChart1.Aspect.View3D = False
            tChart1.Series.Remove(series1)
            series1.Chart = Nothing
            series1 = New Steema.TeeChart.Styles.Line()
            tChart1.Series.Add(series1)
            CType(series1, Custom).Pointer.Style = PointerStyles.Circle
            CType(series1, Custom).Pointer.Visible = True
            series1.Color = Color.FromArgb(128, 128, 128)
            series1.FillSampleValues()
            CType(series1, Custom).Smoothed = cbSmoothed.Checked
        End If
    End Sub

    Private Sub rbArea_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
        If rbArea.Checked Then
            tChart1.Aspect.View3D = True
            tChart1.Series.Remove(series1)
            series1.Chart = Nothing
            series1 = New Steema.TeeChart.Styles.Area()
            tChart1.Series.Add(series1)
            series1.Color = Color.FromArgb(128, 128, 128)
            series1.FillSampleValues()
            CType(series1, Custom).Smoothed = cbSmoothed.Checked
        End If
    End Sub
End Class