
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms


Public Class Bubble_Transparency
    Inherits Steema.TeeChart.Samples.BaseForm
    Private bubble1 As Steema.TeeChart.Styles.Bubble
    Private hScrollBar1 As System.Windows.Forms.HScrollBar
    Private label1 As System.Windows.Forms.Label
    Private label2 As System.Windows.Forms.Label
    Private gridBand1 As Steema.TeeChart.Tools.GridBand
    Private components As System.ComponentModel.IContainer = Nothing
    
    Public Sub New() ' This call is required by the Windows Form Designer.
        InitializeComponent()

        bubble1.FillSampleValues()
    End Sub


    '/ <summary>
    '/ Clean up any resources being used.
    '/ </summary>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If Disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(Disposing)
    End Sub 'Dispose

#Region "Windows Form Designer generated code"

    '/ <summary>
    '/ Required method for Designer support - do not modify
    '/ the contents of this method with the code editor.
    '/ </summary>
    Private Sub InitializeComponent()
        Me.bubble1 = New Steema.TeeChart.Styles.Bubble
        Me.hScrollBar1 = New System.Windows.Forms.HScrollBar
        Me.label1 = New System.Windows.Forms.Label
        Me.label2 = New System.Windows.Forms.Label
        Me.gridBand1 = New Steema.TeeChart.Tools.GridBand
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Text = "Bubble series allows Transparency:" + vbCr + vbLf + vbCr + vbLf + "bubble1.Pointer.Transparency = 50  ' <-- " + "50 %"
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.label2)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Controls.Add(Me.hScrollBar1)
        Me.panel1.Name = "panel1"
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
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Brush
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.tChart1.Series.Add(Me.bubble1)
        Me.tChart1.Tools.Add(Me.gridBand1)
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
        ' bubble1
        ' 
        Me.bubble1.LabelMember = "Labels"
        ' 
        ' bubble1.Marks
        ' 
        ' 
        ' bubble1.Marks.Symbol
        ' 
        ' 
        ' bubble1.Marks.Symbol.Shadow
        ' 
        Me.bubble1.Marks.Symbol.Shadow.Height = 1
        Me.bubble1.Marks.Symbol.Shadow.Visible = True
        Me.bubble1.Marks.Symbol.Shadow.Width = 1
        Me.bubble1.Marks.Transparent = True
        ' 
        ' bubble1.Pointer
        ' 
        ' 
        ' bubble1.Pointer.Brush
        ' 
        Me.bubble1.Pointer.Brush.Color = System.Drawing.Color.FromArgb(CType(127, System.Byte), CType(255, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        Me.bubble1.Pointer.Brush.ForegroundColor = System.Drawing.Color.Empty
        Me.bubble1.Pointer.HorizSize = 17
        Me.bubble1.Pointer.InflateMargins = False
        Me.bubble1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Circle
        Me.bubble1.Pointer.VertSize = 17
        Me.bubble1.Title = "bubble1"
        ' 
        ' bubble1.XValues
        ' 
        Me.bubble1.XValues.DataMember = "X"
        Me.bubble1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' bubble1.YValues
        ' 
        Me.bubble1.YValues.DataMember = "Y"
        ' 
        ' hScrollBar1
        ' 
        Me.hScrollBar1.Location = New System.Drawing.Point(104, 13)
        Me.hScrollBar1.Maximum = 109
        Me.hScrollBar1.Name = "hScrollBar1"
        Me.hScrollBar1.Size = New System.Drawing.Size(227, 17)
        Me.hScrollBar1.TabIndex = 0
        Me.hScrollBar1.Value = 50
        AddHandler Me.hScrollBar1.Scroll, AddressOf Me.hScrollBar1_Scroll
        ' 
        ' label1
        ' 
        Me.label1.Location = New System.Drawing.Point(28, 14)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(78, 23)
        Me.label1.TabIndex = 1
        Me.label1.Text = "Transparency:"
        ' 
        ' label2
        ' 
        Me.label2.Location = New System.Drawing.Point(338, 15)
        Me.label2.Name = "label2"
        Me.label2.TabIndex = 2
        Me.label2.Text = "50"
        ' 
        ' gridBand1
        ' 
        Me.gridBand1.Axis = Me.tChart1.Axes.Left
        ' 
        ' gridBand1.Band1
        ' 
        Me.gridBand1.Band1.Color = System.Drawing.Color.FromArgb(CType(127, System.Byte), CType(192, System.Byte), CType(192, System.Byte), CType(192, System.Byte))
        ' 
        ' gridBand1.Band2
        ' 
        Me.gridBand1.Band2.Color = System.Drawing.Color.FromArgb(CType(127, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        ' 
        ' Bubble_Transparency
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(440, 317)
        Me.Name = "Bubble_Transparency"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub 'New 
#End Region


    Private Sub hScrollBar1_Scroll(ByVal sender As Object, ByVal e As System.Windows.Forms.ScrollEventArgs)
        bubble1.Pointer.Transparency = hScrollBar1.Value
        label2.Text = hScrollBar1.Value.ToString()
    End Sub 'hScrollBar1_Scroll
End Class 'Bubble_Transparency