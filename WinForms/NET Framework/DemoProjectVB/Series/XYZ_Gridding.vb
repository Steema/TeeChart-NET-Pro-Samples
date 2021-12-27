
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms


Public Class XYZ_Gridding
    Inherits Steema.TeeChart.Samples.BaseForm
    Private points3D1 As Steema.TeeChart.Styles.Points3D
    Private surface1 As Steema.TeeChart.Styles.Surface
    Private label1 As System.Windows.Forms.Label
    Private radioButton1 As System.Windows.Forms.RadioButton
    Private radioButton2 As System.Windows.Forms.RadioButton
    Private rotate1 As Steema.TeeChart.Tools.Rotate
    Private gridBand1 As Steema.TeeChart.Tools.GridBand
    Private components As System.ComponentModel.IContainer = Nothing
    
    Private Sub Fill()
        points3D1.Clear()
        points3D1.BeginUpdate()
        Try
            Dim m As Integer = 40
            Dim tmpy As Double
            Dim tmpz As Double
            Dim tmpx As Double
            Dim x As Integer = (m * -1)
            Do While (x < m)
                tmpx = (x * (x / 900))
                Dim z As Integer = (m * -1)
                Do While (z < m)
                    tmpz = (z _
                                * (z / 900))
                    tmpz = Math.Sqrt((tmpx + tmpz))
                    tmpy = (4 * (Math.Cos((3 * tmpz)) * Math.Exp(((0.5 * tmpz) * -1))))
                    points3D1.Add(x, tmpy, z)
                    z = (z + 1)
                Loop
                x = (x + 1)
            Loop
        Finally
            points3D1.EndUpdate()
        End Try
    End Sub


    Public Sub New()
        InitializeComponent()
        Fill()
        Grid3DUtils.CreateGrid(points3D1, surface1, 15)
    End Sub


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

    '/ <summary>
    '/ Required method for Designer support - do not modify
    '/ the contents of this method with the code editor.
    '/ </summary>
    Private Sub InitializeComponent()
        Me.points3D1 = New Steema.TeeChart.Styles.Points3D
        Me.surface1 = New Steema.TeeChart.Styles.Surface
        Me.label1 = New System.Windows.Forms.Label
        Me.radioButton1 = New System.Windows.Forms.RadioButton
        Me.radioButton2 = New System.Windows.Forms.RadioButton
        Me.rotate1 = New Steema.TeeChart.Tools.Rotate
        Me.gridBand1 = New Steema.TeeChart.Tools.GridBand
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(544, 56)
        Me.textBox1.Text = "Small routine can do the ""gridding"" of arbitrary, floating XYZ data." + vbCr + vbLf + vbCr + vbLf + "The gridd" + "ing algorithm creates a fixed, regular grid of aproximate values using XYZ data." + ""
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.radioButton2)
        Me.panel1.Controls.Add(Me.radioButton1)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Location = New System.Drawing.Point(0, 56)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(544, 40)
        ' 
        ' tChart1
        ' 
        ' 
        ' tChart1.Aspect
        ' 
        Me.tChart1.Aspect.Chart3DPercent = 75
        Me.tChart1.Aspect.Elevation = 338
        Me.tChart1.Aspect.Orthogonal = False
        Me.tChart1.Aspect.Perspective = 0
        Me.tChart1.Aspect.Rotation = 314
        Me.tChart1.Aspect.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality
        Me.tChart1.Aspect.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        Me.tChart1.Aspect.Zoom = 63
        ' 
        ' tChart1.Header
        ' 
        Me.tChart1.Header.Lines = New String() {"tChart1"}
        Me.tChart1.Header.Visible = False
        ' 
        ' tChart1.Legend
        ' 
        Me.tChart1.Legend.MaxNumRows = 8
        Me.tChart1.Location = New System.Drawing.Point(0, 96)
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Brush
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.tChart1.Series.Add(Me.points3D1)
        Me.tChart1.Series.Add(Me.surface1)
        Me.tChart1.Size = New System.Drawing.Size(544, 253)
        Me.tChart1.Tools.Add(Me.rotate1)
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
        ' tChart1.Walls.Left.Brush
        ' 
        Me.tChart1.Walls.Left.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(224, System.Byte))
        ' 
        ' tChart1.Walls.Left.Pen
        ' 
        Me.tChart1.Walls.Left.Pen.Visible = False
        Me.tChart1.Walls.Left.Size = 5
        ' 
        ' points3D1
        ' 
        ' 
        ' points3D1.LinePen
        ' 
        Me.points3D1.LinePen.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(0, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        Me.points3D1.LinePen.Visible = False
        ' 
        ' points3D1.Marks
        ' 
        ' 
        ' points3D1.Marks.Symbol
        ' 
        ' 
        ' points3D1.Marks.Symbol.Shadow
        ' 
        Me.points3D1.Marks.Symbol.Shadow.Height = 1
        Me.points3D1.Marks.Symbol.Shadow.Visible = True
        Me.points3D1.Marks.Symbol.Shadow.Width = 1
        ' 
        ' points3D1.Pointer
        ' 
        ' 
        ' points3D1.Pointer.Brush
        ' 
        Me.points3D1.Pointer.Brush.Color = System.Drawing.Color.Red
        Me.points3D1.Pointer.HorizSize = 2
        Me.points3D1.Pointer.InflateMargins = False
        ' 
        ' points3D1.Pointer.Pen
        ' 
        Me.points3D1.Pointer.Pen.Color = System.Drawing.Color.FromArgb(CType(153, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        Me.points3D1.Pointer.Pen.Visible = False
        Me.points3D1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.points3D1.Pointer.VertSize = 2
        Me.points3D1.Title = "points3D1"
        Me.points3D1.Visible = False
        ' 
        ' points3D1.XValues
        ' 
        Me.points3D1.XValues.DataMember = "X"
        ' 
        ' points3D1.YValues
        ' 
        Me.points3D1.YValues.DataMember = "Y"
        ' 
        ' points3D1.ZValues
        ' 
        Me.points3D1.ZValues.DataMember = "Z"
        ' 
        ' surface1
        ' 
        ' 
        ' surface1.Brush
        ' 
        Me.surface1.Brush.Color = System.Drawing.Color.Green
        Me.surface1.EndColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(192, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        ' 
        ' surface1.Marks
        ' 
        ' 
        ' surface1.Marks.Symbol
        ' 
        ' 
        ' surface1.Marks.Symbol.Shadow
        ' 
        Me.surface1.Marks.Symbol.Shadow.Height = 1
        Me.surface1.Marks.Symbol.Shadow.Visible = True
        Me.surface1.Marks.Symbol.Shadow.Width = 1
        Me.surface1.PaletteMin = 0
        Me.surface1.PaletteStep = 0
        Me.surface1.PaletteStyle = Steema.TeeChart.Styles.PaletteStyles.Strong
        Me.surface1.StartColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(192, System.Byte))
        Me.surface1.Title = "surface1"
        ' 
        ' surface1.XValues
        ' 
        Me.surface1.XValues.DataMember = "X"
        ' 
        ' surface1.YValues
        ' 
        Me.surface1.YValues.DataMember = "Y"
        ' 
        ' surface1.ZValues
        ' 
        Me.surface1.ZValues.DataMember = "Z"
        ' 
        ' label1
        ' 
        Me.label1.Location = New System.Drawing.Point(32, 8)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(56, 23)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Show:"
        ' 
        ' radioButton1
        ' 
        Me.radioButton1.Location = New System.Drawing.Point(104, 8)
        Me.radioButton1.Name = "radioButton1"
        Me.radioButton1.TabIndex = 1
        Me.radioButton1.Text = "Original data"
        AddHandler Me.radioButton1.CheckedChanged, AddressOf Me.radioButton1_CheckedChanged
        ' 
        ' radioButton2
        ' 
        Me.radioButton2.Checked = True
        Me.radioButton2.Location = New System.Drawing.Point(224, 8)
        Me.radioButton2.Name = "radioButton2"
        Me.radioButton2.TabIndex = 2
        Me.radioButton2.TabStop = True
        Me.radioButton2.Text = "Surface"
        AddHandler Me.radioButton2.CheckedChanged, AddressOf Me.radioButton2_CheckedChanged
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
        ' XYZ_gridding
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(544, 349)
        Me.Name = "XYZ_gridding"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub 'New 
#End Region


    Private Sub radioButton1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        points3D1.Visible = radioButton1.Checked
        surface1.Visible = Not radioButton1.Checked
    End Sub 'radioButton1_CheckedChanged


    Private Sub radioButton2_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        surface1.Visible = radioButton2.Checked
        points3D1.Visible = Not radioButton2.Checked
    End Sub 'radioButton2_CheckedChanged
End Class 'XYZ_Gridding