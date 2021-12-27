
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing

Imports System.Windows.Forms




Public Class TriSurface_Series
    Inherits Samples.BaseForm
    Private triSurfaceSeries1 As Steema.TeeChart.Styles.TriSurface
    Private rotate1 As Steema.TeeChart.Tools.Rotate
    Private WithEvents button1 As System.Windows.Forms.Button
    Private gridBand1 As Steema.TeeChart.Tools.GridBand
    Private components As System.ComponentModel.IContainer = Nothing
    
    
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        
        Me.triSurfaceSeries1.FillSampleValues(25)
        Me.triSurfaceSeries1.Pen.Width = 2
        Me.triSurfaceSeries1.Pen.Color = Color.GreenYellow
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
        Me.rotate1 = New Steema.TeeChart.Tools.Rotate
        Me.button1 = New System.Windows.Forms.Button
        Me.gridBand1 = New Steema.TeeChart.Tools.GridBand
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(466, 63)
        Me.textBox1.Text = "A TriSurface series draws triangles using all XYZ points." + vbCr + vbLf + vbCr + vbLf + "Includes a pen to dr" + "aw a line around the point boundaries. Inherits all properties and methods from " + "Grid3D series (palette, AddXYZ, etc)."
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.button1)
        Me.panel1.Location = New System.Drawing.Point(0, 63)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(466, 41)
        ' 
        ' tChart1
        ' 
        ' 
        ' tChart1.Aspect
        ' 
        Me.tChart1.Aspect.Chart3DPercent = 70
        Me.tChart1.Aspect.Elevation = 334
        Me.tChart1.Aspect.Orthogonal = False
        Me.tChart1.Aspect.Perspective = 36
        Me.tChart1.Aspect.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality
        Me.tChart1.Aspect.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        Me.tChart1.Aspect.Zoom = 66
        ' 
        ' tChart1.Axes
        ' 
        ' 
        ' tChart1.Axes.Depth
        ' 
        Me.tChart1.Axes.Depth.Visible = True
        ' 
        ' tChart1.Header
        ' 
        Me.tChart1.Header.Lines = New String() {"tChart1"}
        Me.tChart1.Header.Visible = False
        ' 
        ' tChart1.Legend
        ' 
        Me.tChart1.Legend.MaxNumRows = 8
        Me.tChart1.Location = New System.Drawing.Point(0, 104)
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Brush
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.tChart1.Series.Add(Me.triSurfaceSeries1)
        Me.tChart1.Size = New System.Drawing.Size(466, 182)
        Me.tChart1.Tools.Add(Me.rotate1)
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
        Me.tChart1.Walls.Bottom.Size = 5
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
        Me.tChart1.Walls.Left.Size = 5
        ' 
        ' triSurfaceSeries1
        ' 
        ' 
        ' triSurfaceSeries1.Brush
        ' 
        Me.triSurfaceSeries1.Brush.Color = System.Drawing.Color.Red
        Me.triSurfaceSeries1.EndColor = System.Drawing.Color.LightSkyBlue
        Me.triSurfaceSeries1.HideTriangles = False
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
        Me.triSurfaceSeries1.StartColor = System.Drawing.Color.Green
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
        ' button1
        ' 
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.Location = New System.Drawing.Point(16, 8)
        Me.button1.Name = "button1"
        Me.button1.TabIndex = 0
        Me.button1.Text = "&Edit..."
        ' 
        ' gridBand1
        ' 
        Me.gridBand1.Axis = Me.tChart1.Axes.Left
        ' 
        ' gridBand1.Band1
        ' 
        Me.gridBand1.Band1.Color = System.Drawing.Color.FromArgb(CType(127, System.Byte), CType(224, System.Byte), CType(224, System.Byte), CType(224, System.Byte))
        ' 
        ' gridBand1.Band2
        ' 
        Me.gridBand1.Band2.Color = System.Drawing.Color.FromArgb(CType(127, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        ' 
        ' SeriesType_TriSurface
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(466, 286)
        Me.Name = "SeriesType_TriSurface"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub 'InitializeComponent 
#End Region


    Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
        TeeChart.Editors.SeriesEditor.ShowEditor(Me.triSurfaceSeries1)
    End Sub 'button1_Click
End Class 'TriSurface_Series
