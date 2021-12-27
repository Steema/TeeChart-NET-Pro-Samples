
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing

Imports System.Windows.Forms




Public Class Canvas_RotatedEllipse
    Inherits Samples.BaseForm
    Private WithEvents hScrollBar2 As System.Windows.Forms.HScrollBar
    Private label1 As System.Windows.Forms.Label
    Private label2 As System.Windows.Forms.Label
    Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
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
        Dim resources As New System.Resources.ResourceManager(GetType(Canvas_RotatedEllipse))
        Me.hScrollBar2 = New System.Windows.Forms.HScrollBar
        Me.label1 = New System.Windows.Forms.Label
        Me.label2 = New System.Windows.Forms.Label
        Me.checkBox1 = New System.Windows.Forms.CheckBox
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(432, 72)
        Me.textBox1.TabIndex = 0
        Me.textBox1.Text = "Ellipses can now be rotated 360 degrees around vertical axis."
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.checkBox1)
        Me.panel1.Controls.Add(Me.label2)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Controls.Add(Me.hScrollBar2)
        Me.panel1.Location = New System.Drawing.Point(0, 72)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(432, 33)
        Me.panel1.TabIndex = 1
        ' 
        ' tChart1
        ' 
        ' 
        ' tChart1.Aspect
        ' 
        Me.tChart1.Aspect.Chart3DPercent = 65
        Me.tChart1.Aspect.Orthogonal = False
        Me.tChart1.Aspect.Perspective = 71
        Me.tChart1.Aspect.Rotation = 341
        Me.tChart1.Aspect.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality
        Me.tChart1.Aspect.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        Me.tChart1.BackColor = System.Drawing.Color.Transparent
        Me.tChart1.Cursor = System.Windows.Forms.Cursors.Default
        ' 
        ' tChart1.Header
        ' 
        Me.tChart1.Header.Lines = New String() {"New Canvas methods"}
        Me.tChart1.Location = New System.Drawing.Point(0, 105)
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Brush
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.Transparent
        Me.tChart1.Panel.Brush.Image = CType(resources.GetObject("tChart1.Panel.Brush.Image"), System.Drawing.Image)
        Me.tChart1.Panel.Brush.Solid = False
        Me.tChart1.Panel.Image = CType(resources.GetObject("tChart1.Panel.Image"), System.Drawing.Image)
        Me.tChart1.Size = New System.Drawing.Size(432, 212)
        Me.tChart1.TabIndex = 2
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
        ' tChart1.Walls.Left.Brush
        ' 
        Me.tChart1.Walls.Left.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(192, System.Byte))
        Me.tChart1.Walls.Left.Size = 5
        ' 
        ' tChart1.Walls.Right
        ' 
        ' 
        ' tChart1.Walls.Right.Brush
        ' 
        Me.tChart1.Walls.Right.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(192, System.Byte), CType(192, System.Byte), CType(192, System.Byte))
        ' 
        ' hScrollBar2
        ' 
        Me.hScrollBar2.LargeChange = 1
        Me.hScrollBar2.Location = New System.Drawing.Point(96, 10)
        Me.hScrollBar2.Maximum = 360
        Me.hScrollBar2.Name = "hScrollBar2"
        Me.hScrollBar2.Size = New System.Drawing.Size(134, 14)
        Me.hScrollBar2.TabIndex = 3
        Me.hScrollBar2.Value = 60
        ' 
        ' label1
        ' 
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(16, 10)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(72, 16)
        Me.label1.TabIndex = 0
        Me.label1.Text = "&Ellipse angle:"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        ' 
        ' label2
        ' 
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(240, 10)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(17, 16)
        Me.label2.TabIndex = 2
        Me.label2.Text = "60"
        Me.label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        ' 
        ' checkBox1
        ' 
        Me.checkBox1.Checked = True
        Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox1.Location = New System.Drawing.Point(288, 10)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(40, 16)
        Me.checkBox1.TabIndex = 4
        Me.checkBox1.Text = "3D"
        ' 
        ' Canvas_RotatedEllipse
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(432, 317)
        Me.Name = "Canvas_RotatedEllipse"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub 'InitializeComponent 
#End Region


    Private Sub hScrollBar2_Scroll(ByVal sender As Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles hScrollBar2.Scroll
        label2.Text = hScrollBar2.Value.ToString()
        tChart1.Invalidate()
    End Sub 'hScrollBar2_Scroll


    Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox1.CheckedChanged
        tChart1.Aspect.View3D = checkBox1.Checked
    End Sub 'checkBox1_CheckedChanged


    Private Sub AfterDraw(ByVal sender As Object, ByVal g As Steema.TeeChart.Drawing.Graphics3D) Handles tChart1.AfterDraw
        g.Pen.Style = System.Drawing.Drawing2D.DashStyle.Solid
        g.Pen.Color = Color.Blue
        g.Brush.Visible = True
        g.Brush.Color = Color.Azure
        g.Ellipse(50, 90, 250, 160, 0, hScrollBar2.Value)
    End Sub 'tChart1_AfterDraw
End Class 'Canvas_RotatedEllipse
