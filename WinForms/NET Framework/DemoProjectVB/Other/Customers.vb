
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms


'/ <summary>
'/ Summary description for Costomers.
'/ </summary>

Public Class Customers
    Inherits System.Windows.Forms.Form
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
        Me.textBox1 = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.textBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, System.Byte))
        Me.textBox1.Location = New System.Drawing.Point(0, 0)
        Me.textBox1.Multiline = True
        Me.textBox1.Name = "textBox1"
        Me.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.textBox1.Size = New System.Drawing.Size(266, 248)
        Me.textBox1.TabIndex = 0
        Me.textBox1.Text = "Some of the (many tens of thousands) TeeChart Pro customers are..." + vbCr + vbLf + vbCr + vbLf + "-Microsoft" + vbCr + vbLf + "-CommerzBank" + vbCr + vbLf + "-Siemens" + vbCr + vbLf + "-Dell" + vbCr + vbLf + "-Compaq" + vbCr + vbLf + "-Allied Signal." + vbCr + vbLf + "-Discovery Com." + vbCr + vbLf + "-Disney" + vbCr + vbLf + "-Mayo Found. Rochester." + vbCr + vbLf + "-Arthur & Andersen." + vbCr + vbLf + "-Duracell." + vbCr + vbLf + "-Merril Lynch." + vbCr + vbLf + "-BASF." + vbCr + vbLf + "-ENSCO Inc." + vbCr + vbLf + "-Michelin." + vbCr + vbLf + "-Barclays." + vbCr + vbLf + "-Ericsson." + vbCr + vbLf + "-Mitsubishi Chemical Amer. " + vbCr + vbLf + "-Bell Helicopter Textron. " + vbCr + vbLf + "-Flex Control." + vbCr + vbLf + "-Motorola. " + vbCr + vbLf + "-Benetton Formula LDT. " + vbCr + vbLf + "-Ford. " + vbCr + vbLf + "-The National Trust." + vbCr + vbLf + "-BP (British Petroleum). " + vbCr + vbLf + "-General Motors. " + vbCr + vbLf + "-Nokia." + vbCr + vbLf + "-B.B.C. " + vbCr + vbLf + "-HBO. " + vbCr + vbLf + "-Norwest Financial Inf. " + vbCr + vbLf + "-Cannon. " + vbCr + vbLf + "-Heinrich Hertz." + vbCr + vbLf + "-Pinacle Automation." + vbCr + vbLf + "-Campbell Soup. " + vbCr + vbLf + "-Hewlett Packard. " + vbCr + vbLf + "-Philips." + vbCr + vbLf + "-Champion Intl. " + vbCr + vbLf + "-Home Savings of Amer. " + vbCr + vbLf + "-Porsche. " + vbCr + vbLf + "-Colgate Palmolive." + vbCr + vbLf + "-Kraft Foods " + vbCr + vbLf + "-COSTaFAC 2001 " + vbCr + vbLf + "-C&F. " + vbCr + vbLf + "-Lifescan. " + vbCr + vbLf + "-Inverline.com" + vbCr + vbLf + "-Crown Intl." + vbCr + vbLf + "-Mathoolds. " + vbCr + vbLf + "-Tel-Aviv University" + vbCr + vbLf + vbCr + vbLf + "* All names are trademarks or registered trademarks of their respective owners." + vbCr + vbLf + " "
        ' 
        ' Customers
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(266, 248)
        Me.Controls.Add(textBox1)
        Me.Name = "Customers"
        Me.Text = "Customers"
        Me.ResumeLayout(False)
    End Sub 'InitializeComponent 
#End Region
End Class 'Customers