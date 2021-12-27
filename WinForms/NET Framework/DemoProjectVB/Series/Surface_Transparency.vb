
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms


Public Class Surface_Transparency
    Inherits Steema.TeeChart.Samples.BaseForm
    Private surface1 As Steema.TeeChart.Styles.Surface
    Private trackBar1 As System.Windows.Forms.TrackBar
    Private label1 As System.Windows.Forms.Label
    Private gridBand1 As Steema.TeeChart.Tools.GridBand
    Private components As System.ComponentModel.IContainer = Nothing
    
    Public Sub New() ' This call is required by the Windows Form Designer.
        InitializeComponent()

        surface1.FillSampleValues()
        tChart1.Walls.Back.Color = Color.Orange
        surface1.Brush.Transparency = 50
        surface1.Pen.Transparency = 50

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
        Me.surface1 = New Steema.TeeChart.Styles.Surface
        Me.trackBar1 = New System.Windows.Forms.TrackBar
        Me.label1 = New System.Windows.Forms.Label
        Me.gridBand1 = New Steema.TeeChart.Tools.GridBand
        Me.panel1.SuspendLayout()
        CType(Me.trackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Text = "Surface series can now display cells with transparency. " + vbCr + vbLf + vbCr + vbLf + "surface1.Brush.Transp" + "arency = 50" + vbCr + vbLf + "surface1.Pen.Transparency = 50"
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Controls.Add(Me.trackBar1)
        Me.panel1.Name = "panel1"
        ' 
        ' tChart1
        ' 
        ' 
        ' tChart1.Aspect
        ' 
        Me.tChart1.Aspect.Chart3DPercent = 45
        Me.tChart1.Aspect.Orthogonal = False
        Me.tChart1.Aspect.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality
        Me.tChart1.Aspect.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        Me.tChart1.Aspect.Zoom = 79
        ' 
        ' tChart1.Header
        ' 
        Me.tChart1.Header.Lines = New String() {"Surface and transparency"}
        ' 
        ' tChart1.Legend
        ' 
        Me.tChart1.Legend.MaxNumRows = 8
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Brush
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.tChart1.Series.Add(Me.surface1)
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
        Me.tChart1.Walls.Back.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(128, System.Byte), CType(0, System.Byte))
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
        ' surface1
        ' 
        ' 
        ' surface1.Brush
        ' 
        Me.surface1.Brush.Color = System.Drawing.Color.Red
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
        ' trackBar1
        ' 
        Me.trackBar1.Location = New System.Drawing.Point(120, 0)
        Me.trackBar1.Maximum = 100
        Me.trackBar1.Name = "trackBar1"
        Me.trackBar1.Size = New System.Drawing.Size(184, 42)
        Me.trackBar1.TabIndex = 0
        Me.trackBar1.TickFrequency = 10
        Me.trackBar1.Value = 50
        AddHandler Me.trackBar1.Scroll, AddressOf Me.trackBar1_Scroll
        ' 
        ' label1
        ' 
        Me.label1.Location = New System.Drawing.Point(312, 8)
        Me.label1.Name = "label1"
        Me.label1.TabIndex = 1
        Me.label1.Text = "50 %"
        ' 
        ' gridBand1
        ' 
        Me.gridBand1.Axis = Me.tChart1.Axes.Left
        ' 
        ' gridBand1.Band1
        ' 
        Me.gridBand1.Band1.Color = System.Drawing.Color.FromArgb(CType(153, System.Byte), CType(224, System.Byte), CType(224, System.Byte), CType(224, System.Byte))
        ' 
        ' gridBand1.Band2
        ' 
        Me.gridBand1.Band2.Color = System.Drawing.Color.FromArgb(CType(153, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        ' 
        ' Surface_Transparency
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(440, 317)
        Me.Name = "Surface_Transparency"
        Me.panel1.ResumeLayout(False)
        CType(Me.trackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub 'New
#End Region


    Private Sub trackBar1_Scroll(ByVal sender As Object, ByVal e As System.EventArgs)
        surface1.Brush.Transparency = trackBar1.Value
        surface1.Pen.Transparency = trackBar1.Value

        label1.Text = trackBar1.Value.ToString() + " %"
    End Sub 'trackBar1_Scroll 
End Class 'Surface_Transparency