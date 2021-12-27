
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms


Public Class ChartListBoxEditor
    Inherits Steema.TeeChart.Samples.ChartListBoxRadio
    Private checkBox1 As System.Windows.Forms.CheckBox
    Private components As System.ComponentModel.IContainer = Nothing
    
    Public Sub New() ' This call is required by the Windows Form Designer.
        InitializeComponent()

        Me.radioButton1.Visible = False
        Me.radioButton2.Visible = False
        Me.groupBox1.Visible = False

    End Sub


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

#Region "Windows Form Designer generated code"

    '/ <summary>
    '/ Required method for Designer support - do not modify
    '/ the contents of this method with the code editor.
    '/ </summary>
    Private Sub InitializeComponent()
        Me.checkBox1 = New System.Windows.Forms.CheckBox
        Me.groupBox1.SuspendLayout()
        Me.panel1.SuspendLayout()
        Me.panel2.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' chartListBox1
        ' 
        Me.chartListBox1.Name = "chartListBox1"
        ' 
        ' groupBox1
        ' 
        Me.groupBox1.Name = "groupBox1"
        ' 
        ' radioButton1
        ' 
        Me.radioButton1.Name = "radioButton1"
        ' 
        ' radioButton2
        ' 
        Me.radioButton2.Name = "radioButton2"
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Text = "Pressing F2 or calling a method is possible to edit the ChartListBox text" + vbCr + vbLf + "of the" + " selected Series." + vbCr + vbLf + vbCr + vbLf + "Press F2 or click ""Editor"" checkbox. To hide the editor, pr" + "ess F2, Escape," + vbCr + vbLf + "Enter or arrows keys or click anywhere in the list."
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.checkBox1)
        Me.panel1.Name = "panel1"
        Me.panel1.Controls.SetChildIndex(Me.checkBox1, 0)
        Me.panel1.Controls.SetChildIndex(Me.groupBox1, 0)
        ' 
        ' panel2
        ' 
        Me.panel2.Name = "panel2"
        ' 
        ' checkBox1
        ' 
        Me.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox1.Location = New System.Drawing.Point(192, 8)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.TabIndex = 1
        Me.checkBox1.Text = "Editor"
        AddHandler Me.checkBox1.Click, AddressOf Me.checkBox1_Click
        ' 
        ' ChartListBoxEditor
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(426, 258)
        Me.Name = "ChartListBoxEditor"
        Me.groupBox1.ResumeLayout(False)
        Me.panel1.ResumeLayout(False)
        Me.panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub 'New 
#End Region


    Private Sub checkBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        If checkBox1.Checked Then
            chartListBox1.ShowEditor()
        Else
            chartListBox1.HideEditor()
        End If
    End Sub 'checkBox1_Click
End Class 'ChartListBoxEditor