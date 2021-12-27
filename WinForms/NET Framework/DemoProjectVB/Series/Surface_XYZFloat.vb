
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing

Imports System.Windows.Forms




Public Class Surface_XYZFloat
    Inherits Samples.BaseForm
    Private surfaceSeries1 As Steema.TeeChart.Styles.Surface
    Private gridBand1 As Steema.TeeChart.Tools.GridBand
    Private components As System.ComponentModel.IContainer = Nothing
    
    
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        
        Me.surfaceSeries1.IrregularGrid = True ' <-- IMPORTANT ! means X and Z are float
        Dim x As Integer
        For x = 1 To 10
            Dim z As Integer
            For z = 1 To 10
                Me.surfaceSeries1.Add(x / 10.0, Math.Sqrt(x * z), z / 5.0)
            Next z

        Next x ' set palette colors to "10, strong" ...
        Me.surfaceSeries1.UseColorRange = False
        Me.surfaceSeries1.UsePalette = True
        Me.surfaceSeries1.PaletteStyle = Steema.TeeChart.Styles.PaletteStyles.Strong
        Me.surfaceSeries1.PaletteSteps = 10
        ' adjust some axes properties...
        Me.tChart1.Axes.Depth.Visible = True
        Me.tChart1.Axes.Depth.Labels.ValueFormat = "0.#"
        Me.tChart1.Axes.Depth.Increment = 0.2
        Me.tChart1.Axes.Bottom.Labels.ValueFormat = "0.#" 
        Me.tChart1.Axes.Bottom.Increment = 0.1

        ' visual properties...
        Me.tChart1.Aspect.Chart3DPercent = 100
        Me.tChart1.Aspect.Orthogonal = False
        Me.tChart1.Aspect.Perspective = 50
        Me.tChart1.Aspect.Rotation = 327
        Me.tChart1.Aspect.Elevation = 352
        Me.tChart1.Aspect.Zoom = 70
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
        Me.surfaceSeries1 = New Steema.TeeChart.Styles.Surface
        Me.gridBand1 = New Steema.TeeChart.Tools.GridBand
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(466, 63)
        Me.textBox1.Text = "Another example of using Surface series with XYZ floating point numbers (double)." + ""
        ' 
        ' panel1
        ' 
        Me.panel1.Location = New System.Drawing.Point(0, 63)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(466, 34)
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
        Me.tChart1.Header.Lines = New String() {"Surface Series : float x,z and y(x,z)"}
        ' 
        ' tChart1.Legend
        ' 
        Me.tChart1.Legend.MaxNumRows = 8
        Me.tChart1.Location = New System.Drawing.Point(0, 97)
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Brush
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.tChart1.Series.Add(Me.surfaceSeries1)
        Me.tChart1.Size = New System.Drawing.Size(466, 189)
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
        ' surfaceSeries1
        ' 
        ' 
        ' surfaceSeries1.Brush
        ' 
        Me.surfaceSeries1.Brush.Color = System.Drawing.Color.Red
        ' 
        ' surfaceSeries1.Marks
        ' 
        ' 
        ' surfaceSeries1.Marks.Symbol
        ' 
        ' 
        ' surfaceSeries1.Marks.Symbol.Shadow
        ' 
        Me.surfaceSeries1.Marks.Symbol.Shadow.Height = 1
        Me.surfaceSeries1.Marks.Symbol.Shadow.Visible = True
        Me.surfaceSeries1.Marks.Symbol.Shadow.Width = 1
        Me.surfaceSeries1.NumXValues = 25
        Me.surfaceSeries1.NumZValues = 25
        Me.surfaceSeries1.PaletteMin = 0
        Me.surfaceSeries1.PaletteStep = 0
        Me.surfaceSeries1.Title = "surfaceSeries1"
        Me.surfaceSeries1.UseColorRange = False
        Me.surfaceSeries1.UsePalette = True
        ' 
        ' surfaceSeries1.XValues
        ' 
        Me.surfaceSeries1.XValues.DataMember = "X"
        ' 
        ' surfaceSeries1.YValues
        ' 
        Me.surfaceSeries1.YValues.DataMember = "Y"
        ' 
        ' surfaceSeries1.ZValues
        ' 
        Me.surfaceSeries1.ZValues.DataMember = "Z"
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
        Me.gridBand1.Band2.Color = System.Drawing.Color.FromArgb(CType(127, System.Byte), CType(224, System.Byte), CType(224, System.Byte), CType(224, System.Byte))
        ' 
        ' Surface_XYZFloat
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(466, 286)
        Me.Name = "Surface_XYZFloat"
        Me.ResumeLayout(False)
    End Sub 'InitializeComponent 
#End Region
End Class 'Surface_XYZFloat
