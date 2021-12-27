Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Public Class Chart_NewLanguages
    Inherits BaseForm
    Private WithEvents comboBox1 As ComboBox
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
    '/ Required method for Designer support - do not modify
    '/the contents of this method with the code editor.
    '/</summary>
    Private Sub InitializeComponent()
        Me.comboBox1 = New System.Windows.Forms.ComboBox
        Me.panel1.SuspendLayout()
        Me.chartContainer.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Text = "Six new languages have been added to the TeeChart.Languages.dll."
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.comboBox1)
        ' 
        ' tChart1
        ' 
        Me.tChart1.Aspect.ZOffset = 0

        Me.tChart1.Header.Visible = False
        Me.tChart1.Size = New System.Drawing.Size(440, 205)
        ' 
        ' comboBox1
        '
#If (VS2005) Then
        Me.comboBox1.FormattingEnabled = True
#End If
        Me.comboBox1.Items.AddRange(New Object() {"Croatian", "Czech", "Farsi", "Malaysian", "Romanian", "Urdu"})
        Me.comboBox1.Location = New System.Drawing.Point(12, 12)
        Me.comboBox1.Name = "comboBox1"
        Me.comboBox1.Size = New System.Drawing.Size(207, 21)
        Me.comboBox1.TabIndex = 0
        Me.comboBox1.Text = "Choose one of the new languages..."
        AddHandler comboBox1.SelectedIndexChanged, AddressOf Me.comboBox1_SelectedIndexChanged
        ' 
        ' Chart_NewLanguages
        ' 
#If (VS2005) Then
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
#End If
        Me.ClientSize = New System.Drawing.Size(440, 317)
        Me.Name = "Chart_NewLanguages"
        Me.Text = "Chart_NewLanguages"
        Me.panel1.ResumeLayout(False)
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
    Private label As Label
    Private Sub InitializeChart()
        tChart1.Panel.MarginTop = 20
        tChart1.Panel.Gradient.Visible = False
        label = New Label
        label.Text = "About TeeChart for .Net 2009"
        label.Font = New Font("Verdana", 12)
        label.ForeColor = Color.Turquoise
        label.Left = ((tChart1.Width / 2) _
                    - 35)
        label.Top = 15
        label.AutoSize = True
        tChart1.Controls.Add(label)
    End Sub

    Private Sub comboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
        label.Text = "About TeeChart for .Net 2009"
        Select Case (comboBox1.SelectedItem.ToString)
            Case "Croatian"
                Steema.TeeChart.Languages.Croatian.Activate()
            Case "Czech"
                Steema.TeeChart.Languages.Czech.Activate()
            Case "Farsi"
                Steema.TeeChart.Languages.Farsi.Activate()
            Case "Malaysian"
                Steema.TeeChart.Languages.Malaysian.Activate()
            Case "Romanian"
                Steema.TeeChart.Languages.Romanian.Activate()
            Case "Urdu"
                Steema.TeeChart.Languages.Urdu.Activate()
        End Select
        Texts.Translator.Translate(tChart1)
        tChart1.ShowEditor()
    End Sub
End Class