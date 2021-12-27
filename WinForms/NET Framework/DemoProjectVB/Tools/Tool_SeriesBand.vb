Imports System
#If (VS2005) Then
Imports System.Collections.Generic
#End If
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Public Class Tool_SeriesBand
    Inherits BaseForm
    Private WithEvents button1 As Button
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
    '/ Required method for Designer support - do not modify
    '/the contents of this method with the code editor.
    '/</summary>
    Private Sub InitializeComponent()
        Me.button1 = New System.Windows.Forms.Button
        Me.panel1.SuspendLayout()
        Me.chartContainer.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Text = "SeriesBand tool draws a fully configurable area between two line series."
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.button1)
        ' 
        ' tChart1
        ' 
        ' 
        Me.TChart1.Aspect.ZOffset = 0
        Me.TChart1.Size = New System.Drawing.Size(440, 205)
        ' 
        ' button1
        ' 
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.Location = New System.Drawing.Point(12, 6)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(75, 23)
        Me.button1.TabIndex = 0
        Me.button1.Text = "Edit..."
#If (VS2005) Then
        Me.button1.UseVisualStyleBackColor = True
#End If
        AddHandler button1.Click, AddressOf Me.button1_Click
        ' 
        ' Tool_SeriesBand
        ' 
#If (VS2005) Then
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
#End If
        Me.ClientSize = New System.Drawing.Size(440, 317)
        Me.Name = "Tool_SeriesBand"
        Me.Text = "Tool_SeriesBand"
        Me.panel1.ResumeLayout(False)
        Me.chartContainer.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub


#End Region

    Public Sub New()
        InitializeComponent()
        InitializeChart()
    End Sub
    Private line1 As Steema.TeeChart.Styles.Line
    Private line2 As Steema.TeeChart.Styles.Line
    Private seriesBandTool1 As Steema.TeeChart.Tools.SeriesBandTool

    Private Sub InitializeChart()
        TChart1.Aspect.View3D = False
        line1 = New Steema.TeeChart.Styles.Line()
        line2 = New Steema.TeeChart.Styles.Line()
        TChart1.Series.Add(line1)
        TChart1.Series.Add(line2)
        Dim i As Integer
        For i = 0 To line1.Count
            line2.Add(line1.XValues(i), (line1.YValues(i) / 2))
        Next
        seriesBandTool1 = New Steema.TeeChart.Tools.SeriesBandTool()
        TChart1.Tools.Add(seriesBandTool1)
        seriesBandTool1.Series = line1
        seriesBandTool1.Series2 = line2
        line1.LinePen.Width = 3
        line2.LinePen.Width = 3
        seriesBandTool1.Gradient.Visible = True
        seriesBandTool1.Gradient.StartColor = Color.Silver
    End Sub
    Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim edit As Steema.TeeChart.Editors.Tools.SeriesBandToolEditor = New Steema.TeeChart.Editors.Tools.SeriesBandToolEditor(seriesBandTool1)
        Steema.TeeChart.Editors.EditorUtils.ShowFormModal(edit)
    End Sub
End Class