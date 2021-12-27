Imports System
#If (VS2005) Then
Imports System.Collections.Generic
#End If
    Imports System.ComponentModel
    Imports System.Data
    Imports System.Drawing
    Imports System.Text
    Imports System.Windows.Forms
    Imports Steema.TeeChart.Styles


Public Class Canvas_SmoothShadow
    Inherits Samples.BaseForm
    '/<summary>
    '/Required designer variable.
    ' </summary>
    Private components As System.ComponentModel.IContainer = Nothing
    Private button1 As Button
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
    ' <summary>
    ' Required method for Designer support - do not modify
    ' the contents of this method with the code editor.
    ' </summary>
    Private Sub InitializeComponent()
        Me.button1 = New System.Windows.Forms.Button
        Me.panel1.SuspendLayout()
        Me.chartContainer.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Text = "New for .NET Framework 2.0 are smooth shadows!"
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.button1)
        ' 
        ' tChart1
        ' 
        Me.tChart1.Legend.Title.Pen.Visible = False
        Me.tChart1.Size = New System.Drawing.Size(440, 205)
        ' 
        ' button1
        ' 
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.Location = New System.Drawing.Point(12, 10)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(75, 23)
        Me.button1.TabIndex = 0
        Me.button1.Text = "Edit..."
#If (VS2005) Then
        Me.button1.UseVisualStyleBackColor = True
#End If
        AddHandler button1.Click, AddressOf Me.button1_Click
        ' 
        ' Canvas_SmoothShadow
        ' 
#If (VS2005) Then
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
#End If
        Me.ClientSize = New System.Drawing.Size(440, 317)
        Me.Name = "Canvas_SmoothShadow"
        Me.Text = "Canvas_SmoothShadow"
        Me.panel1.ResumeLayout(False)
        Me.chartContainer.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
#End Region

    Public Sub New()
        InitializeComponent()
#If (VS2005) Then
        InitializeChart()
#End If
    End Sub
    Private bar1 As Bar

    Private Sub InitializeChart()
#If (VS2005) Then
        bar1 = New Steema.TeeChart.Styles.Bar()
        tChart1.Series.Add(bar1)
        bar1.FillSampleValues()
        tChart1.Legend.Shadow.Width = 16
        tChart1.Legend.Shadow.Height = 16
        tChart1.Legend.Shadow.Smooth = True
#End If
    End Sub

    Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs)
#If (VS2005) Then
        Dim shadow As Steema.TeeChart.Editors.ShadowEditor = New Steema.TeeChart.Editors.ShadowEditor(tChart1.Legend.Shadow)
        Steema.TeeChart.Editors.EditorUtils.ShowFormModal(shadow)
#End If
    End Sub
End Class