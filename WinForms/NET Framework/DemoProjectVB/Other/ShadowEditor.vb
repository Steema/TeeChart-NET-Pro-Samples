
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms


'/ <summary>
'/ Summary description for ShadowEditor.
'/ </summary>

Public Class ShadowEditor
    Inherits System.Windows.Forms.Form
    Private label1 As System.Windows.Forms.Label
    Private label2 As System.Windows.Forms.Label
    Private label3 As System.Windows.Forms.Label
    Private WithEvents bOK As System.Windows.Forms.Button
    Private WithEvents UDShaHoriz As System.Windows.Forms.NumericUpDown
    Private WithEvents UDShaVert As System.Windows.Forms.NumericUpDown
    Private WithEvents UDShaTrans As System.Windows.Forms.NumericUpDown
    Private shadowColor As Steema.TeeChart.ButtonColor
    '/ <summary>
    '/ Required designer variable.
    '/ </summary>
    Private components As System.ComponentModel.Container = Nothing
    
    
    Public Sub New()
        InitializeComponent()
    End Sub 'New
    
    Private Shadow As Steema.TeeChart.Drawing.Shadow
    
    
    Public Sub New(AShadow As Steema.TeeChart.Drawing.Shadow)
        InitializeComponent()
        
        Shadow = AShadow
        bOK.Visible = True
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


    Private Sub RefreshControls(ByVal AShadow As Steema.TeeChart.Drawing.Shadow)
        Shadow = AShadow
        UDShaHoriz.Value = Shadow.Width
        UDShaVert.Value = Shadow.Height
        UDShaTrans.Value = Shadow.Transparency
        shadowColor.Color = Shadow.Color
    End Sub 'RefreshControls

#Region "Windows Form Designer generated code"

    '/ <summary>
    '/ Required method for Designer support - do not modify
    '/ the contents of this method with the code editor.
    '/ </summary>
    Private Sub InitializeComponent()
        Me.shadowColor = New Steema.TeeChart.ButtonColor
        Me.UDShaHoriz = New System.Windows.Forms.NumericUpDown
        Me.UDShaVert = New System.Windows.Forms.NumericUpDown
        Me.UDShaTrans = New System.Windows.Forms.NumericUpDown
        Me.bOK = New System.Windows.Forms.Button
        Me.label1 = New System.Windows.Forms.Label
        Me.label2 = New System.Windows.Forms.Label
        Me.label3 = New System.Windows.Forms.Label
        CType(Me.UDShaHoriz, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UDShaVert, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UDShaTrans, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        ' 
        ' shadowColor
        ' 
        Me.shadowColor.Color = System.Drawing.Color.Empty
        Me.shadowColor.Location = New System.Drawing.Point(48, 16)
        Me.shadowColor.Name = "shadowColor"
        Me.shadowColor.Size = New System.Drawing.Size(72, 23)
        Me.shadowColor.TabIndex = 0
        Me.shadowColor.Text = "&Color..."
        ' 
        ' UDShaHoriz
        ' 
        Me.UDShaHoriz.Location = New System.Drawing.Point(81, 52)
        Me.UDShaHoriz.Name = "UDShaHoriz"
        Me.UDShaHoriz.Size = New System.Drawing.Size(40, 20)
        Me.UDShaHoriz.TabIndex = 1
        ' 
        ' UDShaVert
        ' 
        Me.UDShaVert.Location = New System.Drawing.Point(81, 78)
        Me.UDShaVert.Name = "UDShaVert"
        Me.UDShaVert.Size = New System.Drawing.Size(40, 20)
        Me.UDShaVert.TabIndex = 2
        ' 
        ' UDShaTrans
        ' 
        Me.UDShaTrans.Location = New System.Drawing.Point(80, 103)
        Me.UDShaTrans.Name = "UDShaTrans"
        Me.UDShaTrans.Size = New System.Drawing.Size(40, 20)
        Me.UDShaTrans.TabIndex = 3
        ' 
        ' bOK
        ' 
        Me.bOK.Location = New System.Drawing.Point(45, 136)
        Me.bOK.Name = "bOK"
        Me.bOK.TabIndex = 4
        Me.bOK.Text = "OK"
        ' 
        ' label1
        ' 
        Me.label1.Location = New System.Drawing.Point(8, 56)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(64, 16)
        Me.label1.TabIndex = 5
        Me.label1.Text = "&Horiz Size:"
        ' 
        ' label2
        ' 
        Me.label2.Location = New System.Drawing.Point(8, 80)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(64, 16)
        Me.label2.TabIndex = 6
        Me.label2.Text = "&Vert Size:"
        ' 
        ' label3
        ' 
        Me.label3.Location = New System.Drawing.Point(-1, 104)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(77, 16)
        Me.label3.TabIndex = 7
        Me.label3.Text = "&Transparency:"
        ' 
        ' ShadowEditor
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(144, 166)
        Me.Controls.Add(label3)
        Me.Controls.Add(label2)
        Me.Controls.Add(label1)
        Me.Controls.Add(bOK)
        Me.Controls.Add(UDShaTrans)
        Me.Controls.Add(UDShaVert)
        Me.Controls.Add(UDShaHoriz)
        Me.Controls.Add(shadowColor)
        Me.Name = "ShadowEditor"
        Me.Text = "ShadowEditor"
        CType(Me.UDShaHoriz, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UDShaVert, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UDShaTrans, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub 'InitializeComponent 
#End Region


    Private Sub UDShaHoriz_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles UDShaHoriz.ValueChanged
        Shadow.Width = Fix(UDShaHoriz.Value)
    End Sub 'UDShaHoriz_ValueChanged


    Private Sub UDShaVert_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles UDShaVert.ValueChanged
        Shadow.Height = Fix(UDShaVert.Value)
    End Sub 'UDShaVert_ValueChanged


    Private Sub UDShaTrans_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles UDShaTrans.ValueChanged
        Shadow.Transparency = Fix(UDShaTrans.Value)
    End Sub 'UDShaTrans_ValueChanged


    Private Sub ShadowEditor_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RefreshControls(Shadow)
    End Sub 'ShadowEditor_Load


    Private Sub bOK_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles bOK.Click
        Shadow.Color = shadowColor.Color
        Me.Close()
    End Sub 'bOK_Click
End Class 'ShadowEditor 
