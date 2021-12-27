Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Steema.TeeChart.Drawing
Imports Steema.TeeChart.Styles
Imports Steema.TeeChart.Tools
Public Class Rotate_Inertia
    Inherits Steema.TeeChart.Samples.BaseForm
    Private WithEvents comboBox1 As ComboBox
    Private label1 As Label
    Private label2 As Label
    '/ <summary>
    '/ Required designer variable.
    '/ </summary>
    Dim components As System.ComponentModel.IContainer = Nothing
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
    '/ </summary>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Rotate_Inertia))
        Me.label1 = New System.Windows.Forms.Label
        Me.comboBox1 = New System.Windows.Forms.ComboBox
        Me.label2 = New System.Windows.Forms.Label
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
        Me.panel1.Controls.Add(Me.label2)
        Me.panel1.Controls.Add(Me.comboBox1)
        Me.panel1.Controls.Add(Me.label1)
        ' 
        ' tChart1
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Aspect.ZOffset = 0
        Me.tChart1.Size = New System.Drawing.Size(440, 205)
        ' 
        ' label1
        ' 
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(12, 12)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(39, 13)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Inertia:"
        ' 
        ' comboBox1
        ' 
#If (VS2005) Then
        Me.comboBox1.FormattingEnabled = True
#End If
        Me.comboBox1.Items.AddRange(New Object() {"100", "80", "60", "40", "20", "0"})
        Me.comboBox1.Location = New System.Drawing.Point(57, 9)
        Me.comboBox1.Name = "comboBox1"
        Me.comboBox1.Size = New System.Drawing.Size(121, 21)
        Me.comboBox1.TabIndex = 1
        Me.comboBox1.Text = "80"
        AddHandler comboBox1.SelectedIndexChanged, AddressOf Me.comboBox1_SelectedIndexChanged
        ' 
        ' label2
        ' 
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(212, 11)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(129, 13)
        Me.label2.TabIndex = 2
        Me.label2.Text = "Drag the Chart to rotate it!"
        ' 
        ' Rotate_Inertia
        ' 
#If (VS2005) Then
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
#End If
        Me.ClientSize = New System.Drawing.Size(440, 317)
        Me.Name = "Rotate_Inertia"
        Me.Text = "Rotate_Inertia"
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.chartContainer.ResumeLayout(False)
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
    Private point3D As Points3D
    Private rotate As Rotate
    Private Sub InitializeChart()
        TChart1.Aspect.Chart3DPercent = 75
        TChart1.Aspect.Zoom = 75
        TChart1.Aspect.Orthogonal = False
        point3D = New Points3D()
        TChart1.Series.Add(point3D)
        point3D.FillSampleValues()
        rotate = New Rotate()
        TChart1.Tools.Add(rotate)
        rotate.Inertia = 80
    End Sub
    Private Sub comboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
        rotate.Inertia = Convert.ToInt32(comboBox1.SelectedItem)
    End Sub

End Class