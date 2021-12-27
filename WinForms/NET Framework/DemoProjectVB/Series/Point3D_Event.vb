
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms



Public Class Point3D_Event
    Inherits Samples.BaseForm
    Private WithEvents point3DSeries1 As Steema.TeeChart.Styles.Points3D
    Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
    Private gridBand1 As Steema.TeeChart.Tools.GridBand
    Private components As System.ComponentModel.IContainer = Nothing
    
    
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        
        point3DSeries1.FillSampleValues(20)
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
        Me.point3DSeries1 = New Steema.TeeChart.Styles.Points3D
        Me.checkBox1 = New System.Windows.Forms.CheckBox
        Me.gridBand1 = New Steema.TeeChart.Tools.GridBand
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(466, 32)
        Me.textBox1.Text = "Point 3D series has an event to supply each point style, color, etc."
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.checkBox1)
        Me.panel1.Location = New System.Drawing.Point(0, 32)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(466, 33)
        ' 
        ' tChart1
        ' 
        ' 
        ' tChart1.Aspect
        ' 
        Me.tChart1.Aspect.Chart3DPercent = 100
        Me.tChart1.Aspect.Elevation = 355
        Me.tChart1.Aspect.Orthogonal = False
        Me.tChart1.Aspect.Perspective = 76
        Me.tChart1.Aspect.Rotation = 336
        Me.tChart1.Aspect.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality
        Me.tChart1.Aspect.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        Me.tChart1.Aspect.Zoom = 66
        ' 
        ' tChart1.Header
        ' 
        Me.tChart1.Header.Lines = New String() {"Custom Point3D series pointer styles"}
        Me.tChart1.Location = New System.Drawing.Point(0, 65)
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Brush
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.tChart1.Series.Add(Me.point3DSeries1)
        Me.tChart1.Size = New System.Drawing.Size(466, 221)
        Me.tChart1.Tools.Add(Me.gridBand1)
        ' 
        ' tChart1.Walls
        ' 
        ' 
        ' tChart1.Walls.Bottom
        ' 
        ' 
        ' tChart1.Walls.Bottom.Brush
        ' 
        Me.tChart1.Walls.Bottom.Brush.Color = System.Drawing.Color.FromArgb(CType(153, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        ' 
        ' tChart1.Walls.Bottom.Gradient
        ' 
        Me.tChart1.Walls.Bottom.Brush.Gradient.Transparency = 40
        ' 
        ' tChart1.Walls.Bottom.Gradient
        ' 
        Me.tChart1.Walls.Bottom.Gradient.Transparency = 40
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
        Me.tChart1.Walls.Left.Brush.Color = System.Drawing.Color.FromArgb(CType(153, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(224, System.Byte))
        ' 
        ' tChart1.Walls.Left.Gradient
        ' 
        Me.tChart1.Walls.Left.Brush.Gradient.Transparency = 40
        ' 
        ' tChart1.Walls.Left.Gradient
        ' 
        Me.tChart1.Walls.Left.Gradient.Transparency = 40
        ' 
        ' tChart1.Walls.Left.Pen
        ' 
        Me.tChart1.Walls.Left.Pen.Visible = False
        Me.tChart1.Walls.Left.Size = 3
        ' 
        ' point3DSeries1
        ' 
        Me.point3DSeries1.ColorEach = True
        ' 
        ' point3DSeries1.LinePen
        ' 
        Me.point3DSeries1.LinePen.Color = System.Drawing.Color.Brown
        ' 
        ' point3DSeries1.Marks
        ' 
        ' 
        ' point3DSeries1.Marks.Symbol
        ' 
        ' 
        ' point3DSeries1.Marks.Symbol.Shadow
        ' 
        Me.point3DSeries1.Marks.Symbol.Shadow.Height = 1
        Me.point3DSeries1.Marks.Symbol.Shadow.Visible = True
        Me.point3DSeries1.Marks.Symbol.Shadow.Width = 1
        ' 
        ' point3DSeries1.Pointer
        ' 
        ' 
        ' point3DSeries1.Pointer.Brush
        ' 
        Me.point3DSeries1.Pointer.Brush.Color = System.Drawing.Color.FromArgb(CType(255, System.Byte), CType(255, System.Byte), CType(204, System.Byte))
        Me.point3DSeries1.Pointer.HorizSize = 14
        ' 
        ' point3DSeries1.Pointer.Pen
        ' 
        Me.point3DSeries1.Pointer.Pen.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(0, System.Byte), CType(0, System.Byte), CType(255, System.Byte))
        Me.point3DSeries1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.point3DSeries1.Pointer.VertSize = 14
        Me.point3DSeries1.Title = "point3DSeries1"
        ' 
        ' point3DSeries1.XValues
        ' 
        Me.point3DSeries1.XValues.DataMember = "X"
        ' 
        ' point3DSeries1.YValues
        ' 
        Me.point3DSeries1.YValues.DataMember = "Y"
        ' 
        ' point3DSeries1.ZValues
        ' 
        Me.point3DSeries1.ZValues.DataMember = "Z"
        ' 
        ' checkBox1
        ' 
        Me.checkBox1.Checked = True
        Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox1.Location = New System.Drawing.Point(24, 8)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(87, 21)
        Me.checkBox1.TabIndex = 0
        Me.checkBox1.Text = "&Use event"
        ' 
        ' gridBand1
        ' 
        Me.gridBand1.Axis = Me.tChart1.Axes.Left
        ' 
        ' gridBand1.Band1
        ' 
        Me.gridBand1.Band1.Color = System.Drawing.Color.FromArgb(CType(178, System.Byte), CType(224, System.Byte), CType(224, System.Byte), CType(224, System.Byte))
        ' 
        ' gridBand1.Band2
        ' 
        Me.gridBand1.Band2.Color = System.Drawing.Color.FromArgb(CType(178, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        ' 
        ' Point3D_Event
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(466, 286)
        Me.Name = "Point3D_Event"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub 'InitializeComponent 
#End Region


    Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox1.CheckedChanged
        point3DSeries1.Repaint()
    End Sub 'checkBox1_CheckedChanged


    Private Sub point3DSeries1_GetPointerStyle(ByVal series As Steema.TeeChart.Styles.Points3D, ByVal e As Steema.TeeChart.Styles.GetPointerStyleEventArgs) Handles point3DSeries1.GetPointerStyle
        e.Style = Styles.PointerStyles.Rectangle

        If checkBox1.Checked Then
            Select Case e.ValueIndex Mod 3
                Case 0
                    If (True) Then
                        e.Style = Styles.PointerStyles.Circle
                        point3DSeries1.Pointer.Brush.Color = Color.Red
                    End If
                Case 1
                    If (True) Then
                        e.Style = Styles.PointerStyles.Triangle
                        point3DSeries1.Pointer.Brush.Color = Color.Blue
                    End If
                Case 2
                    If (True) Then
                        e.Style = Styles.PointerStyles.Rectangle
                        point3DSeries1.Pointer.Brush.Color = Color.Yellow
                    End If
                Case Else
                    If (True) Then
                        e.Style = Styles.PointerStyles.Rectangle
                        point3DSeries1.Pointer.Brush.Color = Color.Empty
                    End If
            End Select
        End If
    End Sub 'point3DSeries1_GetPointerStyle
End Class 'Point3D_Event