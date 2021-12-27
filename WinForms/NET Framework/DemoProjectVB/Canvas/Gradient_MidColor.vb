
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms



Public Class Gradient_MidColor
    Inherits Samples.BaseForm
    Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
    Private WithEvents panel2 As System.Windows.Forms.Panel
    Private label1 As System.Windows.Forms.Label
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
        Me.checkBox1 = New System.Windows.Forms.CheckBox
        Me.panel2 = New System.Windows.Forms.Panel
        Me.label1 = New System.Windows.Forms.Label
        Me.button1 = New System.Windows.Forms.Button
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(466, 63)
        Me.textBox1.Text = "The Gradient object fills using an optional Middle color. Several components have" + " Gradient objects, like for example the Chart panel, the Legend, Bar series, Tit" + "les, Marks, Back Wall, etc."
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.button1)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Controls.Add(Me.panel2)
        Me.panel1.Controls.Add(Me.checkBox1)
        Me.panel1.Location = New System.Drawing.Point(0, 63)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(466, 33)
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
        Me.tChart1.Location = New System.Drawing.Point(0, 96)
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Brush
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        ' 
        ' tChart1.Panel.Gradient
        ' 
        Me.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(255, System.Byte), CType(0, System.Byte), CType(255, System.Byte))
        Me.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(128, System.Byte), CType(255, System.Byte), CType(128, System.Byte))
        Me.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(128, System.Byte), CType(128, System.Byte), CType(128, System.Byte))
        Me.tChart1.Panel.Brush.Gradient.UseMiddle = True
        Me.tChart1.Panel.Brush.Gradient.Visible = True
        ' 
        ' tChart1.Panel.Gradient
        ' 
        Me.tChart1.Panel.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(255, System.Byte), CType(0, System.Byte), CType(255, System.Byte))
        Me.tChart1.Panel.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(128, System.Byte), CType(255, System.Byte), CType(128, System.Byte))
        Me.tChart1.Panel.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(128, System.Byte), CType(128, System.Byte), CType(128, System.Byte))
        Me.tChart1.Panel.Gradient.UseMiddle = True
        Me.tChart1.Panel.Gradient.Visible = True
        Me.tChart1.Size = New System.Drawing.Size(466, 190)
        ' 
        ' checkBox1
        ' 
        Me.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox1.Location = New System.Drawing.Point(168, 6)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(87, 21)
        Me.checkBox1.TabIndex = 0
        Me.checkBox1.Text = "&No middle"
        ' 
        ' panel2
        ' 
        Me.panel2.BackColor = System.Drawing.Color.FromArgb(CType(128, System.Byte), CType(255, System.Byte), CType(128, System.Byte))
        Me.panel2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.panel2.ForeColor = System.Drawing.Color.White
        Me.panel2.Location = New System.Drawing.Point(128, 5)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(24, 24)
        Me.panel2.TabIndex = 1
        ' 
        ' label1
        ' 
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(8, 8)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(118, 16)
        Me.label1.TabIndex = 2
        Me.label1.Text = "Gradient middle color :"
        Me.label1.UseMnemonic = False
        ' 
        ' button1
        ' 
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.Location = New System.Drawing.Point(272, 5)
        Me.button1.Name = "button1"
        Me.button1.TabIndex = 3
        Me.button1.Text = "&Edit..."
        ' 
        ' Canvas_GradMiddle
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(466, 286)
        Me.Name = "Canvas_GradMiddle"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub 'InitializeComponent 
#End Region


    Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox1.CheckedChanged
        If checkBox1.Checked Then
            tChart1.Panel.Gradient.MiddleColor = Color.Empty
        Else
            tChart1.Panel.Gradient.MiddleColor = panel2.BackColor
        End If
    End Sub 'checkBox1_CheckedChanged

    Private Sub panel2_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles panel2.MouseUp
        panel2.BackColor = Steema.TeeChart.Editors.ColorEditor.Choose(tChart1.Panel.Gradient.MiddleColor, Me)
        tChart1.Panel.Gradient.MiddleColor = panel2.BackColor
        checkBox1.Checked = (tChart1.Panel.Gradient.MiddleColor.Equals(Color.Empty))
    End Sub 'panel2_MouseUp


    Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
        TeeChart.Editors.GradientEditor.Edit(tChart1.Panel.Gradient)
    End Sub 'button1_Click
End Class 'Gradient_MidColor