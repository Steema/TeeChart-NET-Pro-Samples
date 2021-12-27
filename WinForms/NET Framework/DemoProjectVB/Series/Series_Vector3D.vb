
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms


Public Class Series_Vector3D
    Inherits Steema.TeeChart.Samples.BaseForm
    Private BPPen As Steema.TeeChart.ButtonPen
    Private vector3D1 As Steema.TeeChart.Styles.Vector3D
    Private gridBand1 As Steema.TeeChart.Tools.GridBand
    Private components As System.ComponentModel.IContainer = Nothing
    
    Public Sub New() ' This call is required by the Windows Form Designer.
        InitializeComponent()
		
        vector3D1.FillSampleValues()
			
			
        BPPen.Pen = vector3D1.Pen
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
        Me.BPPen = New Steema.TeeChart.ButtonPen
        Me.vector3D1 = New Steema.TeeChart.Styles.Vector3D
        Me.gridBand1 = New Steema.TeeChart.Tools.GridBand
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Text = "Vector 3D series draws points as simple lines in 3D space. " + vbCr + vbLf + "Each series point de" + "termines start and end xyz values. " + vbCr + vbLf + vbCr + vbLf + "vector3D1.Add(x0,y0,z0,x1,y1,z1 )"
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.BPPen)
        Me.panel1.Name = "panel1"
        ' 
        ' tChart1
        ' 
        ' 
        ' tChart1.Aspect
        ' 
        Me.tChart1.Aspect.Chart3DPercent = 25
        Me.tChart1.Aspect.Orthogonal = False
        Me.tChart1.Aspect.Perspective = 100
        Me.tChart1.Aspect.Rotation = 360
        Me.tChart1.Aspect.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality
        Me.tChart1.Aspect.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        Me.tChart1.Aspect.Zoom = 95
        Me.tChart1.BackColor = System.Drawing.Color.Transparent
        ' 
        ' tChart1.Header
        ' 
        Me.tChart1.Header.Lines = New String() {"3D Vectors"}
        ' 
        ' tChart1.Legend
        ' 
        Me.tChart1.Legend.Visible = False
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Brush
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.tChart1.Series.Add(Me.vector3D1)
        Me.tChart1.Tools.Add(Me.gridBand1)
        ' 
        ' tChart1.Walls
        ' 
        ' 
        ' tChart1.Walls.Back
        ' 
        ' 
        ' tChart1.Walls.Back.Brush
        ' 
        Me.tChart1.Walls.Back.Brush.Color = System.Drawing.Color.FromArgb(CType(0, System.Byte), CType(192, System.Byte), CType(192, System.Byte), CType(192, System.Byte))
        ' 
        ' tChart1.Walls.Bottom
        ' 
        ' 
        ' tChart1.Walls.Bottom.Brush
        ' 
        Me.tChart1.Walls.Bottom.Brush.Color = System.Drawing.Color.FromArgb(CType(76, System.Byte), CType(192, System.Byte), CType(192, System.Byte), CType(255, System.Byte))
        ' 
        ' tChart1.Walls.Bottom.Gradient
        ' 
        Me.tChart1.Walls.Bottom.Brush.Gradient.Transparency = 70
        ' 
        ' tChart1.Walls.Bottom.Gradient
        ' 
        Me.tChart1.Walls.Bottom.Gradient.Transparency = 70
        ' 
        ' tChart1.Walls.Bottom.Pen
        ' 
        Me.tChart1.Walls.Bottom.Pen.Visible = False
        Me.tChart1.Walls.Bottom.Size = 3
        ' 
        ' tChart1.Walls.Left
        ' 
        ' 
        ' tChart1.Walls.Left.Brush
        ' 
        Me.tChart1.Walls.Left.Brush.Color = System.Drawing.Color.FromArgb(CType(76, System.Byte), CType(192, System.Byte), CType(192, System.Byte), CType(255, System.Byte))
        ' 
        ' tChart1.Walls.Left.Gradient
        ' 
        Me.tChart1.Walls.Left.Brush.Gradient.Transparency = 70
        ' 
        ' tChart1.Walls.Left.Gradient
        ' 
        Me.tChart1.Walls.Left.Gradient.Transparency = 70
        ' 
        ' tChart1.Walls.Left.Pen
        ' 
        Me.tChart1.Walls.Left.Pen.Visible = False
        Me.tChart1.Walls.Left.Size = 3
        ' 
        ' tChart1.Walls.Right
        ' 
        ' 
        ' tChart1.Walls.Right.Brush
        ' 
        Me.tChart1.Walls.Right.Brush.Color = System.Drawing.Color.FromArgb(CType(76, System.Byte), CType(192, System.Byte), CType(192, System.Byte), CType(255, System.Byte))
        ' 
        ' tChart1.Walls.Right.Gradient
        ' 
        Me.tChart1.Walls.Right.Brush.Gradient.Transparency = 70
        ' 
        ' tChart1.Walls.Right.Gradient
        ' 
        Me.tChart1.Walls.Right.Gradient.Transparency = 70
        ' 
        ' tChart1.Walls.Right.Pen
        ' 
        Me.tChart1.Walls.Right.Pen.Visible = False
        Me.tChart1.Walls.Right.Size = 2
        Me.tChart1.Walls.Right.Visible = True
        ' 
        ' BPPen
        ' 
        Me.BPPen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BPPen.Location = New System.Drawing.Point(24, 8)
        Me.BPPen.Name = "BPPen"
        Me.BPPen.TabIndex = 0
        Me.BPPen.Text = "Pen"
        ' 
        ' vector3D1
        ' 
        ' 
        ' vector3D1.Brush
        ' 
        Me.vector3D1.Brush.Color = System.Drawing.Color.Red
        ' 
        ' vector3D1.EndXValues
        ' 
        Me.vector3D1.EndXValues.DataMember = "EndXValues"
        ' 
        ' vector3D1.EndYValues
        ' 
        Me.vector3D1.EndYValues.DataMember = "EndYValues"
        ' 
        ' vector3D1.EndZValues
        ' 
        Me.vector3D1.EndZValues.DataMember = "EndZValues"
        ' 
        ' vector3D1.Marks
        ' 
        ' 
        ' vector3D1.Marks.Symbol
        ' 
        ' 
        ' vector3D1.Marks.Symbol.Shadow
        ' 
        Me.vector3D1.Marks.Symbol.Shadow.Height = 1
        Me.vector3D1.Marks.Symbol.Shadow.Visible = True
        Me.vector3D1.Marks.Symbol.Shadow.Width = 1
        Me.vector3D1.PaletteMin = 0
        Me.vector3D1.PaletteStep = 0
        Me.vector3D1.Title = "vector3D1"
        ' 
        ' vector3D1.XValues
        ' 
        Me.vector3D1.XValues.DataMember = "X"
        ' 
        ' vector3D1.YValues
        ' 
        Me.vector3D1.YValues.DataMember = "Y"
        ' 
        ' vector3D1.ZValues
        ' 
        Me.vector3D1.ZValues.DataMember = "Z"
        ' 
        ' gridBand1
        ' 
        Me.gridBand1.Axis = Me.tChart1.Axes.Left
        ' 
        ' gridBand1.Band1
        ' 
        Me.gridBand1.Band1.Color = System.Drawing.Color.FromArgb(CType(102, System.Byte), CType(192, System.Byte), CType(192, System.Byte), CType(255, System.Byte))
        ' 
        ' gridBand1.Band2
        ' 
        Me.gridBand1.Band2.Color = System.Drawing.Color.FromArgb(CType(102, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        ' 
        ' SeriesType_Vector3D
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(440, 317)
        Me.Name = "SeriesType_Vector3D"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub 'New 
#End Region
End Class 'Series_Vector3D