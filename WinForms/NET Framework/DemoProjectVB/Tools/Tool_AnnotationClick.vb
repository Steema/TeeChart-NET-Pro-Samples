
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms



Public Class Tool_AnnotationClick
    Inherits Samples.BaseForm
    Private WithEvents annotation1 As Steema.TeeChart.Tools.Annotation
    Private WithEvents annotation2 As Steema.TeeChart.Tools.Annotation
    Private WithEvents annotation3 As Steema.TeeChart.Tools.Annotation
    Private label1 As System.Windows.Forms.Label
    Private components As System.ComponentModel.IContainer = Nothing
    
    
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        label1.Text = ""
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
        Me.annotation1 = New Steema.TeeChart.Tools.Annotation
        Me.annotation2 = New Steema.TeeChart.Tools.Annotation
        Me.annotation3 = New Steema.TeeChart.Tools.Annotation
        Me.label1 = New System.Windows.Forms.Label
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(456, 48)
        Me.textBox1.Text = "Annotation tools include a Cursor property and Click event'." + vbCr + vbLf + "Move the mouse over" + " annotations and click them..."
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Location = New System.Drawing.Point(0, 48)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(456, 32)
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
        Me.tChart1.Header.Lines = New String() {"Annotation tool : Click and cursor example"}
        Me.tChart1.Location = New System.Drawing.Point(0, 80)
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Brush
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.tChart1.Size = New System.Drawing.Size(456, 253)
        Me.tChart1.Tools.Add(Me.annotation1)
        Me.tChart1.Tools.Add(Me.annotation2)
        Me.tChart1.Tools.Add(Me.annotation3)
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
        ' tChart1.Walls.Left.Pen
        ' 
        Me.tChart1.Walls.Left.Pen.Visible = False
        Me.tChart1.Walls.Left.Size = 5
        ' 
        ' annotation1
        ' 
        Me.annotation1.Cursor = System.Windows.Forms.Cursors.Default
        Me.annotation1.Position = Steema.TeeChart.Tools.AnnotationPositions.LeftBottom
        ' 
        ' annotation1.Shape
        ' 
        Me.annotation1.Shape.Lines = New String() {"ABCD"}
        ' 
        ' annotation1.Shape.Shadow
        ' 
        ' 
        ' annotation1.Shape.Shadow.Brush
        ' 
        Me.annotation1.Shape.Shadow.Brush.Color = System.Drawing.Color.FromArgb(CType(128, System.Byte), CType(128, System.Byte), CType(128, System.Byte))
        Me.annotation1.Shape.Shadow.Visible = True
        Me.annotation1.Text = "ABCD"
        ' 
        ' annotation2
        ' 
        Me.annotation2.Cursor = System.Windows.Forms.Cursors.Default
        ' 
        ' annotation2.Shape
        ' 
        ' 
        ' annotation2.Shape.Brush
        ' 
        Me.annotation2.Shape.Brush.Color = System.Drawing.Color.FromArgb(CType(255, System.Byte), CType(255, System.Byte), CType(0, System.Byte))
        ' 
        ' annotation2.Shape.Font
        ' 
        ' 
        ' annotation2.Shape.Font.Shadow
        ' 
        Me.annotation2.Shape.Font.Shadow.Visible = True
        Me.annotation2.Shape.Font.Size = 9
        Me.annotation2.Shape.Lines = New String() {"Hello" + vbCr + vbLf + "World"}
        ' 
        ' annotation2.Shape.Shadow
        ' 
        Me.annotation2.Shape.Shadow.Visible = True
        Me.annotation2.Text = "Hello" + vbCr + vbLf + "World"
        ' 
        ' annotation3
        ' 
        Me.annotation3.Cursor = System.Windows.Forms.Cursors.Default
        Me.annotation3.Position = Steema.TeeChart.Tools.AnnotationPositions.RightTop
        ' 
        ' annotation3.Shape
        ' 
        ' 
        ' annotation3.Shape.Brush
        ' 
        Me.annotation3.Shape.Brush.Color = System.Drawing.Color.FromArgb(CType(255, System.Byte), CType(192, System.Byte), CType(128, System.Byte))
        ' 
        ' annotation3.Shape.Font
        ' 
        ' 
        ' annotation3.Shape.Font.Brush
        ' 
        Me.annotation3.Shape.Font.Brush.Color = System.Drawing.Color.Navy
        ' 
        ' annotation3.Shape.Font.Shadow
        ' 
        ' 
        ' annotation3.Shape.Font.Shadow.Brush
        ' 
        Me.annotation3.Shape.Font.Shadow.Brush.Color = System.Drawing.Color.FromArgb(CType(0, System.Byte), CType(0, System.Byte), CType(128, System.Byte))
        Me.annotation3.Shape.Font.Shadow.Visible = True
        Me.annotation3.Shape.Font.Size = 12
        Me.annotation3.Shape.Lines = New String() {"1234567"}
        ' 
        ' annotation3.Shape.Shadow
        ' 
        Me.annotation3.Shape.Shadow.Visible = True
        Me.annotation3.Text = "1234567"
        ' 
        ' label1
        ' 
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(20, 10)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(35, 16)
        Me.label1.TabIndex = 0
        Me.label1.Text = "label1"
        Me.label1.UseMnemonic = False
        ' 
        ' Annotation_Click
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(456, 333)
        Me.Name = "Annotation_Click"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub 'InitializeComponent 
#End Region


    Private Sub annotation1_onClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles annotation1.Click, annotation2.Click, annotation3.Click
       MessageBox.Show(CType(sender,TeeChart.Tools.Annotation).Text, "Clicked")
    End Sub 'annotation1_onClick


    Private Sub tChart1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tChart1.MouseMove
        Dim p As New Point(e.X, e.Y)
        If annotation1.Shape.ShapeBounds.Contains(p) Then
            label1.Text = annotation1.Text
        ElseIf annotation2.Shape.ShapeBounds.Contains(p) Then
            label1.Text = annotation2.Text
        ElseIf annotation3.Shape.ShapeBounds.Contains(p) Then
            label1.Text = annotation3.Text
        Else
            label1.Text = ""
        End If
    End Sub 'tChart1_MouseMove
End Class 'Tool_AnnotationClick
