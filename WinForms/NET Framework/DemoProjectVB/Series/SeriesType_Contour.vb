
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing

Imports System.Windows.Forms




Public Class SeriesType_Contour
    Inherits Samples.BaseForm
    Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
    Private WithEvents checkBox2 As System.Windows.Forms.CheckBox
    Private WithEvents checkBox3 As System.Windows.Forms.CheckBox
    Private WithEvents checkBox4 As System.Windows.Forms.CheckBox
    Private WithEvents checkBox5 As System.Windows.Forms.CheckBox
    Private WithEvents vScrollBar1 As System.Windows.Forms.VScrollBar
    Private contourSeries1 As Steema.TeeChart.Styles.Contour
    Private surfaceSeries1 As Steema.TeeChart.Styles.Surface
    Private rotate1 As Steema.TeeChart.Tools.Rotate
    Private gridBand1 As Steema.TeeChart.Tools.GridBand
    Private components As System.ComponentModel.IContainer = Nothing
    
    
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        

        ' * add points (21x21 = 441 points i.e 20x20 "cells" to contour series
        ' * in this case x,z are integers, so setting 
        ' * IrregularGrid to false makes sense

        contourSeries1.IrregularGrid = False
        Dim x As Integer
        For x = - 10 To 9
            Dim z As Integer
            For z = - 10 To 9
                contourSeries1.Add(x, fun(x, z), z)
            Next z
        Next x
        

        ' * surfaceSeries1 displays the same data, 
        ' * so let's connect it to contour series

        surfaceSeries1.DataSource = contourSeries1
        
        ' Then we specify how many "contour levels" we want 
        contourSeries1.NumLevels = 10
        ' initially, YPosition in the middle
        contourSeries1.YPosition = (0.5 _
                    * (contourSeries1.YValues.Maximum + contourSeries1.YValues.Minimum))
        vScrollBar1.Value = (1000 - CType(contourSeries1.YPosition, Integer))
    End Sub 'New
    
    
    ' auxilary functions for populating series
    Private Function ToAngle(ByVal val As Double) As Double
        Return ((val + 10) * (Math.PI * 0.1))
    End Function

    Private Function fun(ByVal x As Integer, ByVal z As Integer) As Double
        Return (500 * (Math.Sin(ToAngle(x)) + Math.Pow(Math.Cos(z), 2)))
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

#Region "Designer generated code"

    '/ <summary>
    '/ Required method for Designer support - do not modify
    '/ the contents of this method with the code editor.
    '/ </summary>
    Private Sub InitializeComponent()

        Me.checkBox1 = New System.Windows.Forms.CheckBox
        Me.checkBox2 = New System.Windows.Forms.CheckBox
        Me.checkBox3 = New System.Windows.Forms.CheckBox
        Me.checkBox4 = New System.Windows.Forms.CheckBox
        Me.checkBox5 = New System.Windows.Forms.CheckBox
        Me.vScrollBar1 = New System.Windows.Forms.VScrollBar
        Me.contourSeries1 = New Steema.TeeChart.Styles.Contour
        Me.surfaceSeries1 = New Steema.TeeChart.Styles.Surface
        Me.rotate1 = New Steema.TeeChart.Tools.Rotate
        Me.gridBand1 = New Steema.TeeChart.Tools.GridBand
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(509, 62)
        Me.textBox1.Text = "The Contour Series displays lines corresponding to ""Level"" values on 3D XYZ data." + _
          vbCrLf & "The number of levels, the Level intervals, the Levels positions, colors and Legend can be fully customized." + _
         "It can also be viewed in 2D, or rotated in 3D mode."
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.checkBox5)
        Me.panel1.Controls.Add(Me.checkBox4)
        Me.panel1.Controls.Add(Me.checkBox3)
        Me.panel1.Controls.Add(Me.checkBox2)
        Me.panel1.Controls.Add(Me.checkBox1)
        Me.panel1.Location = New System.Drawing.Point(0, 62)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(509, 34)
        ' 
        ' tChart1
        ' 
        ' 
        ' tChart1.Aspect
        ' 
        Me.tChart1.Aspect.Chart3DPercent = 75
        Me.tChart1.Aspect.Elevation = 334
        Me.tChart1.Aspect.Orthogonal = False
        Me.tChart1.Aspect.Perspective = 57
        Me.tChart1.Aspect.Rotation = 299
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
        Me.tChart1.Legend.Alignment = Steema.TeeChart.LegendAlignments.Left
        Me.tChart1.Legend.FontSeriesColor = True
        Me.tChart1.Legend.LegendStyle = Steema.TeeChart.LegendStyles.Values
        Me.tChart1.Legend.ResizeChart = False
        Me.tChart1.Location = New System.Drawing.Point(0, 96)
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Brush
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(254, Byte), CType(255, Byte), CType(255, Byte), CType(255, Byte))
        Me.tChart1.Series.Add(Me.contourSeries1)
        Me.tChart1.Series.Add(Me.surfaceSeries1)
        Me.tChart1.Size = New System.Drawing.Size(509, 224)
        Me.tChart1.Tools.Add(Me.rotate1)
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
        Me.tChart1.Walls.Back.Brush.Color = System.Drawing.Color.FromArgb(CType(178, Byte), CType(224, Byte), CType(224, Byte), CType(224, Byte))
        ' 
        ' tChart1.Walls.Back.Gradient
        ' 
        Me.tChart1.Walls.Back.Brush.Gradient.Transparency = 30
        ' 
        ' tChart1.Walls.Back.Gradient
        ' 
        Me.tChart1.Walls.Back.Gradient.Transparency = 30
        ' 
        ' tChart1.Walls.Back.Pen
        ' 
        Me.tChart1.Walls.Back.Pen.Visible = False
        Me.tChart1.Walls.Back.Size = 7
        Me.tChart1.Walls.Back.Transparent = False
        ' 
        ' tChart1.Walls.Bottom
        ' 
        ' 
        ' tChart1.Walls.Bottom.Brush
        ' 
        Me.tChart1.Walls.Bottom.Brush.Color = System.Drawing.Color.FromArgb(CType(178, Byte), CType(255, Byte), CType(255, Byte), CType(255, Byte))
        ' 
        ' tChart1.Walls.Bottom.Gradient
        ' 
        Me.tChart1.Walls.Bottom.Brush.Gradient.Transparency = 30
        ' 
        ' tChart1.Walls.Bottom.Gradient
        ' 
        Me.tChart1.Walls.Bottom.Gradient.Transparency = 30
        ' 
        ' tChart1.Walls.Bottom.Pen
        ' 
        Me.tChart1.Walls.Bottom.Pen.Visible = False
        Me.tChart1.Walls.Bottom.Size = 8
        ' 
        ' tChart1.Walls.Left
        ' 
        ' 
        ' tChart1.Walls.Left.Brush
        ' 
        Me.tChart1.Walls.Left.Brush.Color = System.Drawing.Color.FromArgb(CType(178, Byte), CType(255, Byte), CType(255, Byte), CType(224, Byte))
        ' 
        ' tChart1.Walls.Left.Gradient
        ' 
        Me.tChart1.Walls.Left.Brush.Gradient.Transparency = 30
        ' 
        ' tChart1.Walls.Left.Gradient
        ' 
        Me.tChart1.Walls.Left.Gradient.Transparency = 30
        ' 
        ' tChart1.Walls.Left.Pen
        ' 
        Me.tChart1.Walls.Left.Pen.Visible = False
        Me.tChart1.Walls.Left.Size = 7
        ' 
        ' checkBox1
        ' 
        Me.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox1.Location = New System.Drawing.Point(13, 7)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(43, 21)
        Me.checkBox1.TabIndex = 0
        Me.checkBox1.Text = "&2D"
        AddHandler checkBox1.CheckedChanged, AddressOf Me.checkBox1_CheckedChanged
        ' 
        ' checkBox2
        ' 
        Me.checkBox2.Checked = True
        Me.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox2.Location = New System.Drawing.Point(67, 7)
        Me.checkBox2.Name = "checkBox2"
        Me.checkBox2.Size = New System.Drawing.Size(101, 21)
        Me.checkBox2.TabIndex = 1
        Me.checkBox2.Text = "Show &Walls"
        AddHandler checkBox2.CheckedChanged, AddressOf Me.checkBox2_CheckedChanged
        ' 
        ' checkBox3
        ' 
        Me.checkBox3.Checked = True
        Me.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox3.Location = New System.Drawing.Point(153, 7)
        Me.checkBox3.Name = "checkBox3"
        Me.checkBox3.Size = New System.Drawing.Size(114, 21)
        Me.checkBox3.TabIndex = 2
        Me.checkBox3.Text = "Color &Each Level"
        AddHandler checkBox3.CheckedChanged, AddressOf Me.checkBox3_CheckedChanged
        ' 
        ' checkBox4
        ' 
        Me.checkBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox4.Location = New System.Drawing.Point(273, 7)
        Me.checkBox4.Name = "checkBox4"
        Me.checkBox4.Size = New System.Drawing.Size(95, 21)
        Me.checkBox4.TabIndex = 3
        Me.checkBox4.Text = "Levels at &Y"
        AddHandler checkBox4.CheckedChanged, AddressOf Me.checkBox4_CheckedChanged
        ' 
        ' checkBox5
        ' 
        Me.checkBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox5.Location = New System.Drawing.Point(360, 7)
        Me.checkBox5.Name = "checkBox5"
        Me.checkBox5.Size = New System.Drawing.Size(60, 21)
        Me.checkBox5.TabIndex = 4
        Me.checkBox5.Text = "&Surface"
        AddHandler checkBox5.CheckedChanged, AddressOf Me.checkBox5_CheckedChanged
        ' 
        ' vScrollBar1
        ' 
        Me.vScrollBar1.Dock = System.Windows.Forms.DockStyle.Right
        Me.vScrollBar1.Location = New System.Drawing.Point(509, 0)
        Me.vScrollBar1.Maximum = 1000
        Me.vScrollBar1.Name = "vScrollBar1"
        Me.vScrollBar1.Size = New System.Drawing.Size(17, 320)
        Me.vScrollBar1.TabIndex = 4
        AddHandler vScrollBar1.Scroll, AddressOf Me.vScrollBar1_Scroll
        ' 
        ' contourSeries1
        ' 
        ' 
        ' contourSeries1.Brush
        ' 
        Me.contourSeries1.ColorEach = True
        Me.contourSeries1.Brush.Visible = False
        ' 
        ' contourSeries1.Marks
        ' 
        ' 
        ' contourSeries1.Marks.Symbol
        ' 
        ' 
        ' contourSeries1.Marks.Symbol.Shadow
        ' 
        Me.contourSeries1.Marks.Symbol.Shadow.Height = 1
        Me.contourSeries1.Marks.Symbol.Shadow.Visible = True
        Me.contourSeries1.Marks.Symbol.Shadow.Width = 1
        Me.contourSeries1.PaletteMin = 0
        Me.contourSeries1.PaletteStep = 0
        Me.contourSeries1.Title = "contour1"
        ' 
        ' contourSeries1.XValues
        ' 
        Me.contourSeries1.XValues.DataMember = "X"
        Me.contourSeries1.YPosition = 0.18959828428699516
        ' 
        ' contourSeries1.YValues
        ' 
        Me.contourSeries1.YValues.DataMember = "Y"
        ' 
        ' contourSeries1.ZValues
        ' 
        Me.contourSeries1.ZValues.DataMember = "Z"
        ' 
        ' surfaceSeries1
        ' 
        ' 
        ' surfaceSeries1.Brush
        ' 
        Me.surfaceSeries1.Brush.Color = System.Drawing.Color.Green
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
        Me.surfaceSeries1.PaletteMin = 0
        Me.surfaceSeries1.PaletteStep = 0
        Me.surfaceSeries1.ShowInLegend = False
        Me.surfaceSeries1.Title = "surface2"
        Me.surfaceSeries1.Visible = False
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
        ' 
        ' gridBand1.Band1
        ' 
        Me.gridBand1.Band1.Color = System.Drawing.Color.Black
        ' 
        ' gridBand1.Band2
        ' 
        Me.gridBand1.Band2.Color = System.Drawing.Color.Black
        ' 
        ' SeriesType_Contour
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(526, 320)
        Me.chartContainer.Controls.Add(Me.vScrollBar1)
        Me.Name = "SeriesType_Contour"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub 'InitializeComponent 
#End Region


    Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox1.CheckedChanged
        tChart1.Aspect.View3D = Not checkBox1.Checked
        checkBox5.Enabled = tChart1.Aspect.View3D
        Me.surfaceSeries1.Active = tChart1.Aspect.View3D
    End Sub 'checkBox1_CheckedChanged


    Private Sub checkBox2_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox2.CheckedChanged
        tChart1.Walls.Visible = checkBox2.Checked
    End Sub 'checkBox2_CheckedChanged


    Private Sub checkBox3_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox3.CheckedChanged
        contourSeries1.ColorEach = checkBox3.Checked
    End Sub 'checkBox3_CheckedChanged


    Private Sub checkBox4_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox4.CheckedChanged
        contourSeries1.YPositionLevel = checkBox4.Checked
    End Sub 'checkBox4_CheckedChanged


    Private Sub checkBox5_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox5.CheckedChanged
        surfaceSeries1.Active = checkBox5.Checked
    End Sub 'checkBox5_CheckedChanged


    Private Sub vScrollBar1_Scroll(ByVal sender As Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles vScrollBar1.Scroll
        contourSeries1.YPositionLevel = False
        contourSeries1.YPosition = vScrollBar1.Value
    End Sub 'vScrollBar1_Scroll
End Class 'SeriesType_Contour
