Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Reflection
Public Class Chart_MultiLanguage
    Inherits Steema.TeeChart.Samples.BaseForm
    Private label1 As System.Windows.Forms.Label
    Private WithEvents comboBox1 As System.Windows.Forms.ComboBox
    Private WithEvents button1 As System.Windows.Forms.Button
    Private components As System.ComponentModel.IContainer = Nothing
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
    End Sub 'New

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
    '/ <summary>
    '/ Required method for Designer support - do not modify
    '/ the contents of this method with the code editor.
    '/ </summary>
    Private Sub InitializeComponent()
        Me.label1 = New System.Windows.Forms.Label
        Me.comboBox1 = New System.Windows.Forms.ComboBox
        Me.button1 = New System.Windows.Forms.Button
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Text = "The assembly TeeChart.Languages.dll contains translations of TeeChart forms and s" + "tring constants to several languages." + vbCr + vbLf + "To activate a language use the following " + "code:" + vbCr + vbLf + vbCr + vbLf + "Steema.TeeChart.Languages.Spanish.Activate() "
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.button1)
        Me.panel1.Controls.Add(Me.comboBox1)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Name = "panel1"
        ' 
        ' tChart1
        ' 
        ' 
        ' tChart1.Aspect
        ' 
        Me.tChart1.Aspect.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality
        Me.tChart1.Aspect.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        ' 
        ' tChart1.Header
        ' 
        Me.tChart1.Header.Lines = New String() {"tChart1"}
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Brush
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        ' 
        ' tChart1.Walls
        ' 
        ' 
        ' tChart1.Walls.Bottom
        ' 
        ' 
        ' tChart1.Walls.Bottom.Pen
        ' 
        Me.tChart1.Walls.Bottom.Pen.Visible = False
        Me.tChart1.Walls.Bottom.Size = 5
        ' 
        ' tChart1.Walls.Left
        ' 
        ' 
        ' tChart1.Walls.Left.Pen
        ' 
        Me.tChart1.Walls.Left.Pen.Visible = False
        Me.tChart1.Walls.Left.Size = 5
        ' 
        ' label1
        ' 
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(16, 8)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(58, 16)
        Me.label1.TabIndex = 0
        Me.label1.Text = "&Language:"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        ' 
        ' comboBox1
        ' 
        Me.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboBox1.Location = New System.Drawing.Point(80, 5)
        Me.comboBox1.Name = "comboBox1"
        Me.comboBox1.Size = New System.Drawing.Size(120, 21)
        Me.comboBox1.TabIndex = 1
        ' 
        ' button1
        ' 
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.Location = New System.Drawing.Point(216, 6)
        Me.button1.Name = "button1"
        Me.button1.TabIndex = 2
        Me.button1.Text = "&Edit..."
        ' 
        ' Translations
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(440, 317)
        Me.Name = "Translations"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub 'InitializeComponent 
#End Region
    Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
        tChart1.ShowEditor() ' show editor
    End Sub 'button1_Click
    Private Sub Translations_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddLanguages()
    End Sub 'Translations_Load
    Private Sub AddLanguages()
        ' Fill languages combobox:
        comboBox1.Items.Clear()
        comboBox1.Items.AddRange(Steema.TeeChart.Languages.Utils.LanguageList)
        comboBox1.Items.Insert(0, "English")
        comboBox1.SelectedIndex = 0
    End Sub 'AddLanguages
    Private Sub comboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboBox1.SelectedIndexChanged
        ' Change language:
        TeeChart.Editors.AskLanguage.ChangeLanguage(comboBox1.SelectedIndex)
        ' Example, replace texts:
        label1.Text = "&Language:"
        TeeChart.Editors.EditorUtils.Translate(label1)
        button1.Text = "&Edit..."
        TeeChart.Editors.EditorUtils.Translate(button1)
    End Sub 'comboBox1_SelectedIndexChanged
End Class 'Chart_MultiLanguage
