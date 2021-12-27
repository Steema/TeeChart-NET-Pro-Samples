
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing

Imports System.Windows.Forms




Public Class Canvas_PyramidTrunc
    Inherits Samples.BaseForm
    Private WithEvents hScrollBar1 As System.Windows.Forms.HScrollBar
    Private WithEvents hScrollBar2 As System.Windows.Forms.HScrollBar
    Private label1 As System.Windows.Forms.Label
    Private label2 As System.Windows.Forms.Label
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
        Me.hScrollBar1 = New System.Windows.Forms.HScrollBar
        Me.hScrollBar2 = New System.Windows.Forms.HScrollBar
        Me.label1 = New System.Windows.Forms.Label
        Me.label2 = New System.Windows.Forms.Label
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(536, 88)
        Me.textBox1.TabIndex = 0
        Me.textBox1.Text = "Graphics3D includes a method to draw truncated Pyramids." + vbCr + vbLf + vbCr + vbLf + "Steema.TeeChart.Drawing.Graphics3D gr = tChart1.Graphics3D" + vbCr + vbLf + "gr.Brush.Color = Color.GreenYellow" + vbCr + vbLf + "gr.PyramidTrunc(new System.Drawing.Rectangle(gr.ChartXCenter,gr.ChartYCenter,60,70)," + vbCr + vbLf + vbTab + vbTab + "0,50,10,20)"
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.label2)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Controls.Add(Me.hScrollBar2)
        Me.panel1.Controls.Add(Me.hScrollBar1)
        Me.panel1.Location = New System.Drawing.Point(0, 88)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(536, 33)
        Me.panel1.TabIndex = 1
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
        Me.tChart1.Location = New System.Drawing.Point(0, 121)
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Brush
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.tChart1.Size = New System.Drawing.Size(536, 196)
        Me.tChart1.TabIndex = 2
        ' 
        ' tChart1.Walls
        ' 
        ' 
        ' tChart1.Walls.Back
        ' 
        ' 
        ' tChart1.Walls.Back.Brush
        ' 
        Me.tChart1.Walls.Back.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(224, System.Byte), CType(224, System.Byte), CType(224, System.Byte))
        Me.tChart1.Walls.Back.Transparent = False
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
        ' hScrollBar1
        ' 
        Me.hScrollBar1.Location = New System.Drawing.Point(33, 10)
        Me.hScrollBar1.Maximum = 50
        Me.hScrollBar1.Name = "hScrollBar1"
        Me.hScrollBar1.Size = New System.Drawing.Size(134, 14)
        Me.hScrollBar1.TabIndex = 1
        Me.hScrollBar1.Value = 10
        ' 
        ' hScrollBar2
        ' 
        Me.hScrollBar2.Location = New System.Drawing.Point(213, 10)
        Me.hScrollBar2.Maximum = 50
        Me.hScrollBar2.Name = "hScrollBar2"
        Me.hScrollBar2.Size = New System.Drawing.Size(134, 14)
        Me.hScrollBar2.TabIndex = 3
        Me.hScrollBar2.Value = 10
        ' 
        ' label1
        ' 
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(13, 10)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(18, 16)
        Me.label1.TabIndex = 0
        Me.label1.Text = "&X :"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        ' 
        ' label2
        ' 
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(187, 10)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(17, 16)
        Me.label2.TabIndex = 2
        Me.label2.Text = "&Z :"
        Me.label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        ' 
        ' Canvas_PyramidTrunc
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(536, 317)
        Me.Name = "Canvas_PyramidTrunc"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub 'InitializeComponent 
#End Region


    Private Sub tChart1_AfterDraw(ByVal sender As Object, ByVal g As Steema.TeeChart.Drawing.Graphics3D) Handles tChart1.AfterDraw
        g.Brush.Visible = True
        g.Brush.Gradient.Visible = True
        g.Pen.Color = Color.Blue
        g.PyramidTrunc(New System.Drawing.Rectangle(g.ChartXCenter, g.ChartYCenter, 60, 70), 0, 50, Fix(hScrollBar1.Value), Fix(hScrollBar2.Value))
    End Sub 'tChart1_AfterDraw


    Private Sub hScrollBar1_Scroll(ByVal sender As Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles hScrollBar1.Scroll
        Me.tChart1.Invalidate()
    End Sub 'hScrollBar1_Scroll


    Private Sub hScrollBar2_Scroll(ByVal sender As Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles hScrollBar2.Scroll
        Me.tChart1.Invalidate()
    End Sub 'hScrollBar2_Scroll
End Class 'Canvas_PyramidTrunc
