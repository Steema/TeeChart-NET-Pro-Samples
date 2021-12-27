
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms


Public Class Wall_Transparency
    Inherits Steema.TeeChart.Samples.BaseForm
    Private hScrollBar1 As System.Windows.Forms.HScrollBar
    Private label1 As System.Windows.Forms.Label
    Private button1 As System.Windows.Forms.Button
    Private surface1 As Steema.TeeChart.Styles.Surface
    Private label2 As System.Windows.Forms.Label
    Private components As System.ComponentModel.IContainer = Nothing
    
    Public Sub New() ' This call is required by the Windows Form Designer.
    InitializeComponent()

    Dim z As Integer
    Dim x As Integer

    For x = -10 To x <= 10
      For z = -10 To 10
        surface1.Add(x, Calc(x, z), z)
      Next z
    Next x
  End Sub 'New

  Private Function Calc(ByVal x As Double, ByVal y As Double) As Double
    Const a As Double = 3.0
    Const b As Double = 10.0
    Const c As Double = 5.0
    Const d As Double = 1.0

    x = x / 3.0
    y = y / 3.0 '
    Dim result As Double = a * Math.Pow(d - x, 2) * Math.Exp(-(x * x) - Math.Pow(y + d, 2)) - b * (x / c - x * x * x - y * y * y * y * y) * Math.Exp(-Math.Pow(x, 2) - Math.Pow(y, 2)) - d / a * Math.Exp(-Math.Pow(x + d, 2) - Math.Pow(y, 2))  '

    Return result

  End Function

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

    '
    Private Sub InitializeComponent()
        Me.hScrollBar1 = New System.Windows.Forms.HScrollBar
        Me.label1 = New System.Windows.Forms.Label
        Me.button1 = New System.Windows.Forms.Button
        Me.surface1 = New Steema.TeeChart.Styles.Surface
        Me.label2 = New System.Windows.Forms.Label
        Me.panel1.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Text = "The four chart walls now support transparency, even with gradient filling." & vbCr & vbLf & vbCr & vbLf & "tChart1.Walls.Left.Transparency = 70    ' % of transparency"
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.label2)
        Me.panel1.Controls.Add(Me.button1)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Controls.Add(Me.hScrollBar1)
        Me.panel1.Name = "panel1"
        ' 
        ' tChart1
        ' 
        ' 
        ' tChart1.Aspect
        ' 
        Me.tChart1.Aspect.Chart3DPercent = 50
        Me.tChart1.Aspect.Elevation = 338
        Me.tChart1.Aspect.Orthogonal = False
        Me.tChart1.Aspect.Perspective = 100
        Me.tChart1.Aspect.Rotation = 331
        Me.tChart1.Aspect.Zoom = 79
        ' 
        ' tChart1.Header
        ' 
        ' 
        ' tChart1.Header.Brush
        ' 
        Me.tChart1.Header.Brush.Color = System.Drawing.Color.FromArgb((CType((229), System.Byte)), (CType((192), System.Byte)), (CType((192), System.Byte)), (CType((192), System.Byte)))
        ' 
        ' tChart1.Header.Brush.Gradient
        ' 
        Me.tChart1.Header.Brush.Gradient.Transparency = 10
        ' 
        ' tChart1.Header.Font
        ' 
        ' 
        ' tChart1.Header.Font.Brush
        ' 
        Me.tChart1.Header.Font.Brush.Color = System.Drawing.Color.White
        Me.tChart1.Header.Font.Size = 12
        Me.tChart1.Header.Lines = New String ()	{"Walls Transparency"}

        Me.tChart1.Header.ShapeStyle = Steema.TeeChart.Drawing.TextShapeStyle.RoundRectangle
        Me.tChart1.Header.Transparent = False
        ' 
        ' tChart1.Legend
        ' 
        ' 
        ' tChart1.Legend.Brush
        ' 
        Me.tChart1.Legend.Brush.Color = System.Drawing.Color.FromArgb((CType((254), System.Byte)), (CType((255), System.Byte)), (CType((255), System.Byte)), (CType((255), System.Byte)))
        ' 
        ' tChart1.Legend.Brush.Gradient
        ' 
        Me.tChart1.Legend.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb((CType((254), System.Byte)), (CType((0), System.Byte)), (CType((128), System.Byte)), (CType((0), System.Byte)))
        Me.tChart1.Legend.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb((CType((254), System.Byte)), (CType((255), System.Byte)), (CType((0), System.Byte)), (CType((0), System.Byte)))
        Me.tChart1.Legend.Brush.Gradient.Visible = True
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Brush
        ' 
        ' 
        ' tChart1.Panel.Brush.Gradient
        ' 
        Me.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb((CType((254), System.Byte)), (CType((0), System.Byte)), (CType((128), System.Byte)), (CType((0), System.Byte)))
        Me.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb((CType((254), System.Byte)), (CType((255), System.Byte)), (CType((0), System.Byte)), (CType((0), System.Byte)))
        Me.tChart1.Panel.Brush.Gradient.Visible = True
        Me.tChart1.Series.Add(Me.surface1)
        ' 
        ' tChart1.Walls
        ' 
        ' 
        ' tChart1.Walls.Back
        ' 
        ' 
        ' tChart1.Walls.Back.Brush
        ' 
        Me.tChart1.Walls.Back.Brush.Color = System.Drawing.Color.FromArgb((CType((127), System.Byte)), (CType((255), System.Byte)), (CType((128), System.Byte)), (CType((255), System.Byte)))
        ' 
        ' tChart1.Walls.Back.Brush.Gradient
        ' 
        Me.tChart1.Walls.Back.Brush.Gradient.Transparency = 50
        Me.tChart1.Walls.Back.Transparent = False
        ' 
        ' tChart1.Walls.Bottom
        ' 
        ' 
        ' tChart1.Walls.Bottom.Brush
        ' 
        Me.tChart1.Walls.Bottom.Brush.Color = System.Drawing.Color.FromArgb((CType((127), System.Byte)), (CType((255), System.Byte)), (CType((128), System.Byte)), (CType((255), System.Byte)))
        ' 
        ' tChart1.Walls.Bottom.Brush.Gradient
        ' 
        Me.tChart1.Walls.Bottom.Brush.Gradient.Transparency = 50
        ' 
        ' tChart1.Walls.Left
        ' 
        ' 
        ' tChart1.Walls.Left.Brush
        ' 
        Me.tChart1.Walls.Left.Brush.Color = System.Drawing.Color.FromArgb((CType((127), System.Byte)), (CType((255), System.Byte)), (CType((128), System.Byte)), (CType((255), System.Byte)))
        ' 
        ' tChart1.Walls.Left.Brush.Gradient
        ' 
        Me.tChart1.Walls.Left.Brush.Gradient.Transparency = 50
        ' 
        ' tChart1.Walls.Right
        ' 
        ' 
        ' tChart1.Walls.Right.Brush
        ' 
        Me.tChart1.Walls.Right.Brush.Color = System.Drawing.Color.FromArgb((CType((127), System.Byte)), (CType((255), System.Byte)), (CType((128), System.Byte)), (CType((255), System.Byte)))
        ' 
        ' tChart1.Walls.Right.Brush.Gradient
        ' 
        Me.tChart1.Walls.Right.Brush.Gradient.Transparency = 50
        Me.tChart1.Walls.Right.Visible = True
        ' 
        ' hScrollBar1
        ' 
        Me.hScrollBar1.Location = New System.Drawing.Point(97, 14)
        Me.hScrollBar1.Name = "hScrollBar1"
        Me.hScrollBar1.Size = New System.Drawing.Size(175, 17)
        Me.hScrollBar1.TabIndex = 0
        Me.hScrollBar1.Value = 50
        AddHandler hScrollBar1.Scroll, AddressOf Me.hScrollBar1_Scroll
        ' 
        ' label1
        ' 
        Me.label1.Location = New System.Drawing.Point(12, 15)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(78, 23)
        Me.label1.TabIndex = 1
        Me.label1.Text = "Transparency:"
        ' 
        ' button1
        ' 
        Me.button1.Location = New System.Drawing.Point(341, 11)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(71, 23)
        Me.button1.TabIndex = 2
        Me.button1.Text = "Edit..."
        AddHandler button1.Click, AddressOf Me.button1_Click
        ' 
        ' surface1
        ' 
        ' 
        ' surface1.Brush
        ' 
        Me.surface1.Brush.Color = System.Drawing.Color.Red
        Me.surface1.PaletteMin = 0
        Me.surface1.PaletteStep = 0
        Me.surface1.PaletteStyle = Steema.TeeChart.Styles.PaletteStyles.Strong
        Me.surface1.Title = "surface1"
        Me.surface1.UseColorRange = False
        Me.surface1.UsePalette = True
        ' 
        ' label2
        ' 
        Me.label2.Location = New System.Drawing.Point(283, 12)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(40, 23)
        Me.label2.TabIndex = 3
        ' 
        ' Walls_Transparency
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(440, 317)
        Me.Name = "Walls_Transparency"
        Me.panel1.ResumeLayout(False)

    End Sub

#End Region
   
    Private Sub hScrollBar1_Scroll(ByVal sender As Object, ByVal e As System.Windows.Forms.ScrollEventArgs)
        ' Set transparency to all walls
        tChart1.Walls.Left.Transparency = hScrollBar1.Value
        tChart1.Walls.Right.Transparency = hScrollBar1.Value
        tChart1.Walls.Bottom.Transparency = hScrollBar1.Value
        tChart1.Walls.Back.Transparency = hScrollBar1.Value

        label2.Text = hScrollBar1.Value.ToString()
    End Sub 'hScrollBar1_Scroll


    Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        tChart1.ShowEditor()
    End Sub 'button1_Click
End Class 'Wall_Transparency 