
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms


'/ <summary>
'/ Summary description for BaseNoChart.
'/ </summary>

Public Class BaseNoChart
    Inherits System.Windows.Forms.Form
    Friend Protected textBox1 As System.Windows.Forms.TextBox
    Protected panel1 As System.Windows.Forms.Panel
    Friend Protected panel2 As System.Windows.Forms.Panel
    '/ <summary>
    '/ Required designer variable.
    '/ </summary>
    Private components As System.ComponentModel.Container = Nothing
    
    
    Public Sub New()
        '
        ' Required for Windows Form Designer support
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

#Region "Windows Form Designer generated code"

    '/ <summary>
    '/ Required method for Designer support - do not modify
    '/ the contents of this method with the code editor.
    '/ </summary>
    Private Sub InitializeComponent()
        Me.textBox1 = New System.Windows.Forms.TextBox
        Me.panel1 = New System.Windows.Forms.Panel
        Me.panel2 = New System.Windows.Forms.Panel
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.BackColor = System.Drawing.Color.FromArgb(CType(255, System.Byte), CType(255, System.Byte), CType(192, System.Byte))
        Me.textBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.textBox1.Location = New System.Drawing.Point(0, 0)
        Me.textBox1.Multiline = True
        Me.textBox1.Name = "textBox1"
        Me.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.textBox1.Size = New System.Drawing.Size(426, 62)
        Me.textBox1.TabIndex = 2
        Me.textBox1.Text = ""
        ' 
        ' panel1
        ' 
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel1.Location = New System.Drawing.Point(0, 62)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(426, 42)
        Me.panel1.TabIndex = 3
        ' 
        ' panel2
        ' 
        Me.panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel2.Location = New System.Drawing.Point(0, 104)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(426, 154)
        Me.panel2.TabIndex = 4
        ' 
        ' BaseNoChart
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(426, 258)
        Me.Controls.Add(panel2)
        Me.Controls.Add(panel1)
        Me.Controls.Add(textBox1)
        Me.Name = "BaseNoChart"
        Me.Text = "BaseNoChart"
        Me.ResumeLayout(False)
    End Sub 'InitializeComponent 
#End Region
End Class 'BaseNoChart