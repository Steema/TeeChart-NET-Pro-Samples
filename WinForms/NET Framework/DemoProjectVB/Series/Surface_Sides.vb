
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms


Public Class Surface_Sides
    Inherits Steema.TeeChart.Samples.BaseForm
    Private surface1 As Steema.TeeChart.Styles.Surface
    Private checkBox1 As System.Windows.Forms.CheckBox
    Private button1 As System.Windows.Forms.Button
    Private rotate1 As Steema.TeeChart.Tools.Rotate
    Private components As System.ComponentModel.IContainer = Nothing
    
    Public Sub New() ' This call is required by the Windows Form Designer.
        InitializeComponent()

        surface1.FillSampleValues(12)
        surface1.SideBrush.Style = System.Drawing.Drawing2D.HatchStyle.DiagonalCross
        surface1.SideBrush.Color = Color.Blue
        surface1.SideBrush.Visible = True
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
        Me.surface1 = New Steema.TeeChart.Styles.Surface
        Me.checkBox1 = New System.Windows.Forms.CheckBox
        Me.button1 = New System.Windows.Forms.Button
        Me.rotate1 = New Steema.TeeChart.Tools.Rotate
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Text = ("Surface series can now display ""sides"", using the SideBrush property." & vbCrLf & "Example: " & vbCr + "" & vbLf & "surface1.SideBrush.Visible = true" & vbCrLf & "surface1.SideBrush.Color = Color.Blue")
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.button1)
        Me.panel1.Controls.Add(Me.checkBox1)
        Me.panel1.Name = "panel1"
        ' 
        ' tChart1
        ' 
        ' 
        ' tChart1.Aspect
        ' 
        Me.tChart1.Aspect.Chart3DPercent = 100
        Me.tChart1.Aspect.Elevation = 348
        Me.tChart1.Aspect.Orthogonal = False
        Me.tChart1.Aspect.Perspective = 0
        Me.tChart1.Aspect.Rotation = 330
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
        Me.tChart1.Legend.Visible = False
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
        ' 
        ' tChart1.Walls
        ' 
        ' 
        ' tChart1.Walls.Back
        ' 
        ' 
        ' tChart1.Walls.Back.Brush
        ' 
        Me.tChart1.Walls.Back.Brush.Color = System.Drawing.Color.FromArgb(CType(254, Byte), CType(192, Byte), CType(192, Byte), CType(192, Byte))
        ' 
        ' tChart1.Walls.Back.Pen
        ' 
        Me.tChart1.Walls.Back.Pen.Visible = False
        Me.tChart1.Walls.Back.Size = 5
        Me.tChart1.Walls.Back.Transparent = False
        Me.tChart1.Walls.Back.Visible = False
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
        ' checkBox1
        ' 
        Me.checkBox1.Checked = True
        Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox1.Location = New System.Drawing.Point(16, 8)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.TabIndex = 0
        Me.checkBox1.Text = "Sides visible"
        AddHandler checkBox1.CheckedChanged, AddressOf Me.checkBox1_CheckedChanged
        ' 
        ' button1
        ' 
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.Location = New System.Drawing.Point(136, 8)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(96, 23)
        Me.button1.TabIndex = 1
        Me.button1.Text = "Edit side brush"
        AddHandler button1.Click, AddressOf Me.button1_Click
        ' 
        ' Surface_Sides
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(440, 317)
        Me.Name = "Surface_Sides"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub
#End Region
    

    Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        surface1.SideBrush.Visible = checkBox1.Checked
    End Sub 'checkBox1_CheckedChanged


    Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim br As New Steema.TeeChart.Editors.BrushEditor(surface1.SideBrush)
        Try
            br.ShowDialog()
        Finally
            br.Dispose()
        End Try
    End Sub 'button1_Click
End Class 'Surface_Sides