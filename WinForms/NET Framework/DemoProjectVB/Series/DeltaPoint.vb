
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms



Public Class SeriesType_DeltaPoint
    Inherits Samples.BaseForm
    Private label1 As System.Windows.Forms.Label
    Private WithEvents pictureBox1 As System.Windows.Forms.PictureBox
    Private WithEvents pictureBox2 As System.Windows.Forms.PictureBox
    Private WithEvents pictureBox3 As System.Windows.Forms.PictureBox
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
        Me.pictureBox1 = New System.Windows.Forms.PictureBox
        Me.pictureBox2 = New System.Windows.Forms.PictureBox
        Me.pictureBox3 = New System.Windows.Forms.PictureBox
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(466, 63)
        Me.textBox1.Text = "Delta Point series."
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.pictureBox3)
        Me.panel1.Controls.Add(Me.pictureBox2)
        Me.panel1.Controls.Add(Me.pictureBox1)
        Me.panel1.Controls.Add(Me.label1)
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
        Me.tChart1.Size = New System.Drawing.Size(466, 190)
        ' 
        ' label1
        ' 
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(13, 10)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(44, 16)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Images:"
        Me.label1.UseMnemonic = False
        ' 
        ' pictureBox1
        ' 
        Me.pictureBox1.Location = New System.Drawing.Point(67, 21)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(13, 14)
        Me.pictureBox1.TabIndex = 1
        Me.pictureBox1.TabStop = False
        ' 
        ' pictureBox2
        ' 
        Me.pictureBox2.Location = New System.Drawing.Point(93, 11)
        Me.pictureBox2.Name = "pictureBox2"
        Me.pictureBox2.Size = New System.Drawing.Size(14, 14)
        Me.pictureBox2.TabIndex = 2
        Me.pictureBox2.TabStop = False
        ' 
        ' pictureBox3
        ' 
        Me.pictureBox3.Location = New System.Drawing.Point(120, 11)
        Me.pictureBox3.Name = "pictureBox3"
        Me.pictureBox3.Size = New System.Drawing.Size(13, 14)
        Me.pictureBox3.TabIndex = 3
        Me.pictureBox3.TabStop = False
        ' 
        ' SeriesType_DeltaPoint
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(466, 286)
        Me.Name = "SeriesType_DeltaPoint"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub 'InitializeComponent 
#End Region


    Private Sub pictureBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pictureBox1.Click, pictureBox2.Click, pictureBox3.Click
    End Sub 'pictureBox1_Click
End Class 'SeriesType_DeltaPoint ' 
