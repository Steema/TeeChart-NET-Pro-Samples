
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms


'/ <summary>
'/ Summary description for Fixed_Defects_v2.
'/ </summary>

Public Class FixedDefectsv2
    Inherits System.Windows.Forms.Form
    Private WithEvents textBox1 As System.Windows.Forms.TextBox
    '/ <summary>
    '/ Required designer variable.
    '/ </summary>
    Private components As System.ComponentModel.Container = Nothing
    
    
    Public Sub New()
        '
        ' Required for Windows Form Designer support
        '
        InitializeComponent()
        ' TODO: Add any constructor code after InitializeComponent call
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
        Me.textBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, System.Byte))
        Me.textBox1.Location = New System.Drawing.Point(0, 0)
        Me.textBox1.Multiline = True
        Me.textBox1.Name = "textBox1"
        Me.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.textBox1.Size = New System.Drawing.Size(267, 241)
        Me.textBox1.TabIndex = 0
        Me.textBox1.Text = "Release v2.0 beta" + vbCr + vbLf + vbCr + vbLf + "Defect" + vbTab + vbTab + "Description" + vbCr + vbLf + "-----------" + vbTab + vbTab + "--------------" + vbCr + vbLf + "TF02010076" + vbTab + "DataSources not appearing in WebChart Chart Editor" + vbCr + vbLf + "TF02010054 " + vbTab + "Changing Chart type at runtime/designtime disassociated " + vbCr + vbLf + vbTab + vbTab + "series from DataSource." + vbCr + vbLf + "TF02010194 " + vbTab + "ZoomText property not functional with rotated text" + vbCr + vbLf + "TF02010249 " + vbTab + "Changing Scroll style in Chart Editor not functional" + vbCr + vbLf + "TF02010250 " + vbTab + "Changing the Zoom Allow checkbox in Chart Editor not functional" + vbCr + vbLf + "TF02010297 " + vbTab + "When deleting a line with ‘DrawLine.DeleteSelected’ the " + vbCr + vbLf + vbTab + vbTab + "DrawHandles remain" + vbCr + vbLf + "TF02010275 " + vbTab + "Changing Chart type at runtime/designtime disassociated " + vbCr + vbLf + vbTab + vbTab + "series from Custom axes." + vbCr + vbLf + "TF02010289 " + vbTab + "Checking/UnChecking Series in the Legend with checkboxes set" + vbCr + vbLf + vbTab + vbTab + "to true and using scroll does not work correctly." + vbCr + vbLf + "TF02010261" + vbTab + "Excessive memory usage when chart with Contour series" + vbCr + vbLf + vbTab + vbTab + "loses focus at design or runtime." + vbCr + vbLf + "TF02010228" + vbTab + "Image Patterns example in the Feature Demo non-functional." + vbCr + vbLf + "TF02010627" + vbTab + "BarWidthPercent (Bar Series) non-functional at designtime. Fixed."
        ' 
        ' FixedDefectsv2
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(267, 241)
        Me.Controls.Add(textBox1)
        Me.Name = "FixedDefectsv2"
        Me.Text = "Fixed Defects"
        Me.ResumeLayout(False)
    End Sub 'InitializeComponent 
#End Region


    Private Sub textBox1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles textBox1.TextChanged
    End Sub 'textBox1_TextChanged
End Class 'FixedDefectsv2 