
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing

Imports System.Windows.Forms




Public Class TriSurface_Hidding
    Inherits Samples.BaseForm
    Private triSurfaceSeries1 As Steema.TeeChart.Styles.TriSurface
    Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
    Private WithEvents checkBox2 As System.Windows.Forms.CheckBox
    Private rotate1 As Steema.TeeChart.Tools.Rotate
    Private components As System.ComponentModel.IContainer = Nothing
    
    
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        
        ' fill sample data
        Me.triSurfaceSeries1.Clear()
        Dim n As Double = 0.5
        Dim m As Integer = 10 
        Dim x As Integer
        For x = - m To m - 1
            Dim z As Integer
            For z = - m To m - 1
                Me.triSurfaceSeries1.Add(x, 4 * Math.Cos(3 * Math.Sqrt(x * x / 9) + z * z / 9) * Math.Exp(- n * Math.Sqrt(x * x / 9 + z * z / 9)), z)
            Next z
        Next x
        
        ' setup series properties
        Me.triSurfaceSeries1.Pen.Visible = False
        Me.triSurfaceSeries1.HideTriangles = True
        Me.triSurfaceSeries1.CacheTriangles = False
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
        Me.triSurfaceSeries1 = New Steema.TeeChart.Styles.TriSurface
        Me.checkBox1 = New System.Windows.Forms.CheckBox
        Me.checkBox2 = New System.Windows.Forms.CheckBox
        Me.rotate1 = New Steema.TeeChart.Tools.Rotate
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(472, 96)
        Me.textBox1.Text = "Tri-Surface boolean properties:" + vbCr + vbLf + vbCr + vbLf + "triSurfaceSeries.HideTriangles ( default true )" + vbCr + vbLf + "Constructed triangles behind other triangles are hidden before displaying them." + vbCr + vbLf + vbCr + vbLf + "triSurfaceSeries.CacheTriangles ( default false )" + vbCr + vbLf + "When true, Triangles are preserved on consecutive displays (ie: rotating or zooming) (this gives much better speed when repainting the series without modifying values)"
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.checkBox2)
        Me.panel1.Controls.Add(Me.checkBox1)
        Me.panel1.Location = New System.Drawing.Point(0, 96)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(472, 32)
        ' 
        ' tChart1
        ' 
        ' 
        ' tChart1.Aspect
        ' 
        Me.tChart1.Aspect.Chart3DPercent = 75
        Me.tChart1.Aspect.Elevation = 340
        Me.tChart1.Aspect.Orthogonal = False
        Me.tChart1.Aspect.Perspective = 72
        Me.tChart1.Aspect.Rotation = 319
        Me.tChart1.Aspect.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality
        Me.tChart1.Aspect.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        Me.tChart1.Aspect.Zoom = 75
        ' 
        ' tChart1.Header
        ' 
        Me.tChart1.Header.Lines = New String() {"tChart1"}
        Me.tChart1.Header.Visible = False
        ' 
        ' tChart1.Legend
        ' 
        Me.tChart1.Legend.Visible = False
        Me.tChart1.Location = New System.Drawing.Point(0, 128)
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
        Me.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(128, System.Byte), CType(128, System.Byte), CType(128, System.Byte))
        Me.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(192, System.Byte), CType(192, System.Byte), CType(192, System.Byte))
        Me.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.tChart1.Panel.Brush.Gradient.UseMiddle = True
        Me.tChart1.Panel.Brush.Gradient.Visible = True
        ' 
        ' tChart1.Panel.Gradient
        ' 
        Me.tChart1.Panel.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(128, System.Byte), CType(128, System.Byte), CType(128, System.Byte))
        Me.tChart1.Panel.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(192, System.Byte), CType(192, System.Byte), CType(192, System.Byte))
        Me.tChart1.Panel.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.tChart1.Panel.Gradient.UseMiddle = True
        Me.tChart1.Panel.Gradient.Visible = True
        Me.tChart1.Series.Add(Me.triSurfaceSeries1)
        Me.tChart1.Size = New System.Drawing.Size(472, 165)
        Me.tChart1.Tools.Add(Me.rotate1)
        ' 
        ' tChart1.Walls
        ' 
        Me.tChart1.Walls.Visible = False
        ' 
        ' triSurfaceSeries1
        ' 
        ' 
        ' triSurfaceSeries1.Brush
        ' 
        Me.triSurfaceSeries1.Brush.Color = System.Drawing.Color.Red
        ' 
        ' triSurfaceSeries1.Marks
        ' 
        ' 
        ' triSurfaceSeries1.Marks.Symbol
        ' 
        ' 
        ' triSurfaceSeries1.Marks.Symbol.Shadow
        ' 
        Me.triSurfaceSeries1.Marks.Symbol.Shadow.Height = 1
        Me.triSurfaceSeries1.Marks.Symbol.Shadow.Visible = True
        Me.triSurfaceSeries1.Marks.Symbol.Shadow.Width = 1
        Me.triSurfaceSeries1.PaletteMin = 0
        Me.triSurfaceSeries1.PaletteStep = 0
        Me.triSurfaceSeries1.Title = "triSurfaceSeries1"
        ' 
        ' triSurfaceSeries1.XValues
        ' 
        Me.triSurfaceSeries1.XValues.DataMember = "X"
        ' 
        ' triSurfaceSeries1.YValues
        ' 
        Me.triSurfaceSeries1.YValues.DataMember = "Y"
        ' 
        ' triSurfaceSeries1.ZValues
        ' 
        Me.triSurfaceSeries1.ZValues.DataMember = "Z"
        ' 
        ' checkBox1
        ' 
        Me.checkBox1.Checked = True
        Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox1.Location = New System.Drawing.Point(13, 7)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(107, 17)
        Me.checkBox1.TabIndex = 0
        Me.checkBox1.Text = "&Hide triangles"
        ' 
        ' checkBox2
        ' 
        Me.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox2.Location = New System.Drawing.Point(145, 7)
        Me.checkBox2.Name = "checkBox2"
        Me.checkBox2.Size = New System.Drawing.Size(116, 17)
        Me.checkBox2.TabIndex = 1
        Me.checkBox2.Text = "&Cache triangles"
        ' 
        ' TriSurface_Hiding
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(472, 293)
        Me.Name = "TriSurface_Hiding"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub 'InitializeComponent 
#End Region


    Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox1.CheckedChanged
        Me.triSurfaceSeries1.HideTriangles = Me.checkBox1.Checked
    End Sub 'checkBox1_CheckedChanged


    Private Sub checkBox2_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox2.CheckedChanged
        Me.triSurfaceSeries1.CacheTriangles = Me.checkBox2.Checked
    End Sub 'checkBox2_CheckedChanged
End Class 'TriSurface_Hidding
