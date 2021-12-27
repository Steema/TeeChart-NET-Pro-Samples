
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms



Public Class Canvas_Transparency
    Inherits Samples.BaseForm
    Private label1 As System.Windows.Forms.Label
    Private WithEvents hScrollBar1 As System.Windows.Forms.HScrollBar
    Private label2 As System.Windows.Forms.Label
    Private bubble1 As Steema.TeeChart.Styles.Bubble
    Private components As System.ComponentModel.IContainer = Nothing
    
    
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        bubble1.FillSampleValues(10)
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
        Dim resources As New System.Resources.ResourceManager(GetType(Canvas_Transparency))
        Me.label1 = New System.Windows.Forms.Label
        Me.hScrollBar1 = New System.Windows.Forms.HScrollBar
        Me.label2 = New System.Windows.Forms.Label
        Me.bubble1 = New Steema.TeeChart.Styles.Bubble
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(466, 64)
        Me.textBox1.Text = "The Chart Legend, Titles ( Title, SubTitle, Foot and SubFoot ) and the BackWall (" + "in 2D mode), can ""blend"" with the chart background ( transparency )." + vbCr + vbLf + vbCr + vbLf + "Example:" + " tChart1.Legend.Transparency = 50 "
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.label2)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Controls.Add(Me.hScrollBar1)
        Me.panel1.Location = New System.Drawing.Point(0, 64)
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
        Me.tChart1.Cursor = System.Windows.Forms.Cursors.Default
        ' 
        ' tChart1.Header
        ' 
        ' 
        ' tChart1.Header.Brush
        ' 
        Me.tChart1.Header.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        ' 
        ' tChart1.Header.Font
        ' 
        ' 
        ' tChart1.Header.Font.Brush
        ' 
        Me.tChart1.Header.Font.Brush.Color = System.Drawing.Color.FromArgb(CType(255, System.Byte), CType(255, System.Byte), CType(0, System.Byte))
        Me.tChart1.Header.Font.Italic = True
        ' 
        ' tChart1.Header.Font.Shadow
        ' 
        ' 
        ' tChart1.Header.Font.Shadow.Brush
        ' 
        Me.tChart1.Header.Font.Shadow.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(0, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        Me.tChart1.Header.Font.Shadow.Visible = True
        Me.tChart1.Header.Font.Size = 12
        Me.tChart1.Header.Lines = New String() {"Title with transparency"}
        ' 
        ' tChart1.Header.Shadow
        ' 
        Me.tChart1.Header.Shadow.Height = 2
        Me.tChart1.Header.Shadow.Width = 2
        Me.tChart1.Header.Transparent = False
        ' 
        ' tChart1.Legend
        ' 
        ' 
        ' tChart1.Legend.Brush
        ' 
        Me.tChart1.Legend.Brush.Color = System.Drawing.Color.FromArgb(CType(76, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        ' 
        ' tChart1.Legend.Shadow
        ' 
        ' 
        ' tChart1.Legend.Shadow.Brush
        ' 
        Me.tChart1.Legend.Shadow.Brush.Color = System.Drawing.Color.FromArgb(CType(76, System.Byte), CType(0, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        Me.tChart1.Location = New System.Drawing.Point(0, 97)
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Bevel
        ' 
        Me.tChart1.Panel.Bevel.ColorOne = System.Drawing.Color.FromArgb(CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        ' 
        ' tChart1.Panel.Brush
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.tChart1.Panel.Brush.Image = CType(resources.GetObject("tChart1.Panel.Brush.Image"), System.Drawing.Image)
        Me.tChart1.Panel.Brush.Solid = False
        Me.tChart1.Panel.Image = CType(resources.GetObject("tChart1.Panel.Image"), System.Drawing.Image)
        Me.tChart1.Series.Add(Me.bubble1)
        Me.tChart1.Size = New System.Drawing.Size(466, 189)
        ' 
        ' tChart1.Walls
        ' 
        ' 
        ' tChart1.Walls.Back
        ' 
        ' 
        ' tChart1.Walls.Back.Brush
        ' 
        Me.tChart1.Walls.Back.Brush.Color = System.Drawing.Color.FromArgb(CType(76, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        ' 
        ' tChart1.Walls.Back.Gradient
        ' 
        Me.tChart1.Walls.Back.Brush.Gradient.Transparency = 70
        ' 
        ' tChart1.Walls.Back.Gradient
        ' 
        Me.tChart1.Walls.Back.Gradient.Transparency = 70
        Me.tChart1.Walls.Back.Transparent = False
        ' 
        ' tChart1.Walls.Bottom
        ' 
        ' 
        ' tChart1.Walls.Bottom.Brush
        ' 
        Me.tChart1.Walls.Bottom.Brush.Color = System.Drawing.Color.FromArgb(CType(76, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        ' 
        ' tChart1.Walls.Bottom.Gradient
        ' 
        Me.tChart1.Walls.Bottom.Brush.Gradient.Transparency = 70
        ' 
        ' tChart1.Walls.Bottom.Gradient
        ' 
        Me.tChart1.Walls.Bottom.Gradient.Transparency = 70
        ' 
        ' tChart1.Walls.Left
        ' 
        ' 
        ' tChart1.Walls.Left.Brush
        ' 
        Me.tChart1.Walls.Left.Brush.Color = System.Drawing.Color.FromArgb(CType(76, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(224, System.Byte))
        ' 
        ' tChart1.Walls.Left.Gradient
        ' 
        Me.tChart1.Walls.Left.Brush.Gradient.Transparency = 70
        ' 
        ' tChart1.Walls.Left.Gradient
        ' 
        Me.tChart1.Walls.Left.Gradient.Transparency = 70
        ' 
        ' label1
        ' 
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(8, 8)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(87, 16)
        Me.label1.TabIndex = 0
        Me.label1.Text = "&Transparency %"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        ' 
        ' hScrollBar1
        ' 
        Me.hScrollBar1.Location = New System.Drawing.Point(104, 8)
        Me.hScrollBar1.Name = "hScrollBar1"
        Me.hScrollBar1.Size = New System.Drawing.Size(127, 14)
        Me.hScrollBar1.TabIndex = 1
        Me.hScrollBar1.Value = 70
        ' 
        ' label2
        ' 
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(240, 8)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(17, 16)
        Me.label2.TabIndex = 2
        Me.label2.Text = "70"
        Me.label2.UseMnemonic = False
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
        Me.bubble1.Pointer.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        Me.bubble1.Pointer.Brush.ForegroundColor = System.Drawing.Color.Empty
        Me.bubble1.Pointer.HorizSize = 11
        Me.bubble1.Pointer.InflateMargins = False
        Me.bubble1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Circle
        Me.bubble1.Pointer.VertSize = 11
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
        ' Canvas_Transp
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(466, 286)
        Me.Name = "Canvas_Transp"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub 'InitializeComponent 
#End Region



    Private Sub hScrollBar1_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles hScrollBar1.ValueChanged
        Dim t As Integer = Fix(hScrollBar1.Value)
        tChart1.Header.Transparency = t
        tChart1.Legend.Transparency = t
        tChart1.Legend.Shadow.Transparency = t
        tChart1.Walls.Left.Transparency = t
        tChart1.Walls.Bottom.Transparency = t
        tChart1.Walls.Back.Transparency = t
        label2.Text = t.ToString()
    End Sub 'hScrollBar1_ValueChanged
End Class 'Canvas_Transparency
