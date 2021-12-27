
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing

Imports System.Windows.Forms



Public Class Tool_Fader
    Inherits Samples.BaseForm

    Private WithEvents bEdit As Button
    Private WithEvents bStart As Button
    '/ <summary>
    '/ Required designer variable.
    '/ </summary>
    Private components As System.ComponentModel.IContainer = Nothing


    Public Sub New() ' me call is required by the Windows Form Designer.
        InitializeComponent()
        InitializeChart()
    End Sub

    Private fader As Steema.TeeChart.Tools.FaderTool
    Private bar As Steema.TeeChart.Styles.Bar
    Private Sub InitializeChart()
        fader = New Steema.TeeChart.Tools.FaderTool()
        tChart1.Tools.Add(fader)
        bar = New Steema.TeeChart.Styles.Bar()
        tChart1.Series.Add(bar)
        bar.FillSampleValues()
        fader.Color = tChart1.Panel.Gradient.EndColor
        fader.Speed = 2
        AddHandler fader.FaderStop, AddressOf Me.fader_FaderStop
    End Sub

    Private Sub fader_FaderStop(ByVal sender As Object, ByVal e As EventArgs)
        If bStart.Text = "Stop" Then
            If fader.Style = Steema.TeeChart.Tools.FaderStyle.FadeIn Then
                fader.Style = Steema.TeeChart.Tools.FaderStyle.FadeOut
            Else
                fader.Style = Steema.TeeChart.Tools.FaderStyle.FadeIn
            End If
            fader.Start()
        End If
    End Sub

    Private Sub bEdit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles bEdit.Click
        Dim faderEdit As Steema.TeeChart.Editors.Tools.FaderToolEditor = New Steema.TeeChart.Editors.Tools.FaderToolEditor(fader)
        Steema.TeeChart.Editors.EditorUtils.ShowFormModal(faderEdit)
    End Sub

    Private Sub bStart_Click(ByVal sender As Object, ByVal e As EventArgs) Handles bStart.Click
        If bStart.Text = "Start" Then
            bStart.Text = "Stop"
            fader.Start()
        ElseIf bStart.Text = "Stop" Then
            bStart.Text = "Start"
            fader.Stop()
        End If
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
    '/ the contents of me method with the code editor.
    '/ </summary>
    Private Sub InitializeComponent()

        Me.bEdit = New System.Windows.Forms.Button()
        Me.bStart = New System.Windows.Forms.Button()
        Me.panel1.SuspendLayout()
        Me.chartContainer.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Text = "The Fader Tool creates an Animated Chart which fades in and out of a specified co" + _
        "lor."
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.bStart)
        Me.panel1.Controls.Add(Me.bEdit)
        ' 
        ' tChart1
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Aspect.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
        Me.tChart1.Aspect.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb((CType(((CType((236), Byte))), Integer)), (CType(((CType((233), Byte))), Integer)), (CType(((CType((216), Byte))), Integer)))
        ' 
        ' 
        ' 
        Me.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb((CType(((CType((254), Byte))), Integer)), (CType(((CType((21), Byte))), Integer)), (CType(((CType((60), Byte))), Integer)), (CType(((CType((89), Byte))), Integer)))
        Me.tChart1.Panel.Brush.Gradient.ExtendedColorPalette = Nothing
        Me.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb((CType(((CType((254), Byte))), Integer)), (CType(((CType((255), Byte))), Integer)), (CType(((CType((255), Byte))), Integer)), (CType(((CType((255), Byte))), Integer)))
        Me.tChart1.Panel.Brush.Gradient.Sigma = True
        Me.tChart1.Panel.Brush.Gradient.SigmaFocus = 1.0F
        Me.tChart1.Panel.Brush.Gradient.SigmaScale = 0.8F
        Me.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb((CType(((CType((254), Byte))), Integer)), (CType(((CType((255), Byte))), Integer)), (CType(((CType((255), Byte))), Integer)), (CType(((CType((255), Byte))), Integer)))

        Me.tChart1.Panel.Brush.Gradient.UseMiddle = True
        Me.tChart1.Panel.Brush.Gradient.Visible = True
        Me.tChart1.Size = New System.Drawing.Size(440, 205)
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' bEdit
        ' 
        Me.bEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bEdit.Location = New System.Drawing.Point(115, 10)
        Me.bEdit.Name = "bEdit"
        Me.bEdit.Size = New System.Drawing.Size(75, 23)
        Me.bEdit.TabIndex = 0
        Me.bEdit.Text = "Edit..."
#If VS2005 Then
			me.bEdit.UseVisualStyleBackColor = true
#End If
        ' 
        ' bStart
        ' 
        Me.bStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bStart.Location = New System.Drawing.Point(12, 10)
        Me.bStart.Name = "bStart"
        Me.bStart.Size = New System.Drawing.Size(75, 23)
        Me.bStart.TabIndex = 1
        Me.bStart.Text = "Start"
#If VS2005 Then
			me.bStart.UseVisualStyleBackColor = true
#End If
        ' 
        ' Tool_Fader
        ' 
#If VS2005 Then
			me.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F)
			me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
#End If
        Me.ClientSize = New System.Drawing.Size(440, 317)
        Me.Name = "Tool_Fader"
        Me.Text = "Tool_Fader"
        Me.panel1.ResumeLayout(False)
        Me.chartContainer.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

#End Region



End Class

