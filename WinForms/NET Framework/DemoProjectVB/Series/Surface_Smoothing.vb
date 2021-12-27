
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms


Public Class SurfaceSmoothing
    Inherits Steema.TeeChart.Samples.BaseForm
    Private button1 As System.Windows.Forms.Button
    Private label1 As System.Windows.Forms.Label
    Private checkBox1 As System.Windows.Forms.CheckBox
    Private surface1 As Steema.TeeChart.Styles.Surface
    Private rotate1 As Steema.TeeChart.Tools.Rotate
    Private gridBand1 As Steema.TeeChart.Tools.GridBand
    Private components As System.ComponentModel.IContainer = Nothing
    
    Public Sub New() ' This call is required by the Windows Form Designer.
        InitializeComponent()

        surface1.FillSampleValues(5)
        surface1.Pen.Visible = False

        '/ <summary>
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
        Me.button1 = New System.Windows.Forms.Button
        Me.label1 = New System.Windows.Forms.Label
        Me.checkBox1 = New System.Windows.Forms.CheckBox
        Me.surface1 = New Steema.TeeChart.Styles.Surface
        Me.rotate1 = New Steema.TeeChart.Tools.Rotate
        Me.gridBand1 = New Steema.TeeChart.Tools.GridBand
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Text = ("Surfaces (and any other ""grid 3D"" series like Tower, Contour, etc)" & vbCrLf & "that have a small number of cells can be smoothed using a simple linear algorithm" & vbCrLf & "that inser" + "ts new cells in between existing cells by interpolating values.")
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.checkBox1)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Controls.Add(Me.button1)
        Me.panel1.Name = "panel1"
        ' 
        ' tChart1
        ' 
        ' 
        ' tChart1.Aspect
        ' 
        Me.tChart1.Aspect.Chart3DPercent = 40
        Me.tChart1.Aspect.Orthogonal = False
        Me.tChart1.Aspect.Perspective = 100
        Me.tChart1.Aspect.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality
        Me.tChart1.Aspect.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        Me.tChart1.Aspect.Zoom = 79
        Me.tChart1.Cursor = System.Windows.Forms.Cursors.Default
        ' 
        ' tChart1.Header
        ' 
        Me.tChart1.Header.Lines = New String() {"TeeChart"}
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
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(254, Byte), CType(255, Byte), CType(255, Byte), CType(255, Byte))
        Me.tChart1.Series.Add(Me.surface1)
        Me.tChart1.Tools.Add(Me.rotate1)
        Me.tChart1.Tools.Add(Me.gridBand1)
        ' 
        ' tChart1.Walls
        ' 
        ' 
        ' tChart1.Walls.Back
        ' 
        Me.tChart1.Walls.Back.Size = 5
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
        ' tChart1.Walls.Right
        ' 
        Me.tChart1.Walls.Right.Size = 5
        Me.tChart1.Walls.Right.Transparent = True
        Me.tChart1.Walls.Right.Visible = True
        ' 
        ' button1
        ' 
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.Location = New System.Drawing.Point(16, 8)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(128, 23)
        Me.button1.TabIndex = 0
        Me.button1.Text = "Smooth Surface x 2"
        AddHandler button1.Click, AddressOf Me.button1_Click
        ' 
        ' label1
        ' 
        Me.label1.Location = New System.Drawing.Point(160, 12)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(168, 23)
        Me.label1.TabIndex = 1
        Me.label1.Text = "Grid Size = 5 x 5"
        ' 
        ' checkBox1
        ' 
        Me.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox1.Location = New System.Drawing.Point(332, 8)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.TabIndex = 2
        Me.checkBox1.Text = "More Speed"
        AddHandler checkBox1.Click, AddressOf Me.checkBox1_Click
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
        ' gridBand1
        ' 
        Me.gridBand1.Axis = Me.tChart1.Axes.Left
        ' 
        ' gridBand1.Band1
        ' 
        Me.gridBand1.Band1.Color = System.Drawing.Color.FromArgb(CType(127, Byte), CType(224, Byte), CType(224, Byte), CType(224, Byte))
        ' 
        ' gridBand1.Band2
        ' 
        Me.gridBand1.Band2.Color = System.Drawing.Color.FromArgb(CType(127, Byte), CType(255, Byte), CType(255, Byte), CType(255, Byte))
        ' 
        ' SurfaceSmoothing
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(440, 317)
        Me.Name = "SurfaceSmoothing"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub 'New

#End Region
   

    Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        ' Smooth the surface !	TeeSmoothGrid3D	class source in TeeSmoothGrid3D.cs
        TeeSmoothGrid3D.SmoothGrid3D(surface1)

        ' Now re-calculate NumX and NumX to display at label1.Text
        surface1.FillGridIndex()

        ' Display new grid size at label1
        label1.Text = "Grid Size: " + surface1.NumXValues.ToString() + " x " + surface1.NumZValues.ToString()
    End Sub 'button1_Click


    Private Sub checkBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        ' For more speed, lets disable items:
        tChart1.Axes.Visible = Not checkBox1.Checked
        tChart1.Legend.Visible = Not checkBox1.Checked
        tChart1.Header.Visible = Not checkBox1.Checked

        If checkBox1.Checked Then
            tChart1.Panel.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None
        Else
            tChart1.Panel.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.Raised
        End If
        tChart1.Aspect.ClipPoints = Not checkBox1.Checked
        tChart1.Walls.Visible = Not checkBox1.Checked

        ' Speed trick, as we know Surface data will not be modified anymore:
        surface1.ReuseGridIndex = checkBox1.Checked

        '"Palette" color mode is faster than "Range" 
        surface1.UsePalette = checkBox1.Checked
        surface1.UseColorRange = Not checkBox1.Checked

        tChart1.Refresh()
    End Sub 'checkBox1_Click
End Class 'SurfaceSmoothing