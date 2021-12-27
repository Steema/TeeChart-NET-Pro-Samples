
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms


'/ <summary>
'/ Summary description for Order_Info.
'/ </summary>

Public Class Order_Info
    Inherits System.Windows.Forms.Form
    Private panel1 As System.Windows.Forms.Panel
    Private textBox1 As System.Windows.Forms.TextBox
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
        Me.panel1 = New System.Windows.Forms.Panel
        Me.textBox1 = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        ' 
        ' panel1
        ' 
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel1.Location = New System.Drawing.Point(0, 0)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(243, 16)
        Me.panel1.TabIndex = 0
        Me.panel1.Visible = False
        ' 
        ' textBox1
        ' 
        Me.textBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.textBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, System.Byte))
        Me.textBox1.Location = New System.Drawing.Point(0, 16)
        Me.textBox1.Multiline = True
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(243, 211)
        Me.textBox1.TabIndex = 1
        Me.textBox1.Text = "If you wish to order and register TeeChart .NET, or upgrade from a previous version, please visit our web site:" + vbCr + vbLf + vbCr + vbLf + "http://www.steema.com" + vbCr + vbLf + vbCr + vbLf + "We provide multi-site licensing, priority support plans and discounts for educational and non-profit organizations." + vbCr + vbLf + vbCr + vbLf + "Thank You !!" + vbCr + vbLf + "Steema Software."
        ' 
        ' Order_Info
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(243, 227)
        Me.Controls.Add(textBox1)
        Me.Controls.Add(panel1)
        Me.Name = "Order_Info"
        Me.Text = "Order Info"
        Me.ResumeLayout(False)
    End Sub 'InitializeComponent 
#End Region
End Class 'Order_Info