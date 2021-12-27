
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms


Public Class Surface_WirePalette
    Inherits Steema.TeeChart.Samples.BaseForm
    Private comboBox1 As System.Windows.Forms.ComboBox
    Private label1 As System.Windows.Forms.Label
    Private checkBox1 As System.Windows.Forms.CheckBox
    Private surface1 As Steema.TeeChart.Styles.Surface
    Private components As System.ComponentModel.IContainer = Nothing
    
    Public Sub New() ' This call is required by the Windows Form Designer.
        InitializeComponent()

        surface1.UsePalette = True
        surface1.FillSampleValues(10)
        surface1.WireFrame = True
        surface1.Pen.Width = 2
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
        Me.comboBox1 = New System.Windows.Forms.ComboBox
        Me.label1 = New System.Windows.Forms.Label
        Me.checkBox1 = New System.Windows.Forms.CheckBox
        Me.surface1 = New Steema.TeeChart.Styles.Surface
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(440, 72)
        Me.textBox1.Text = "Surface series can now display in ""Wire-frame"" mode using the color palette and r" + "ange." + vbCr + vbLf + vbCr + vbLf + "Example: surface1.UsePalette = true   " + vbCr + vbLf + "               surface1.Pen.Wi" + "dth = 2 " + vbCr + vbLf + "               surfac1.WireFrame = true"
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.checkBox1)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Controls.Add(Me.comboBox1)
        Me.panel1.Location = New System.Drawing.Point(0, 72)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(440, 55)
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
        Me.tChart1.Header.Lines = New String() {"tChart1"}
        ' 
        ' tChart1.Legend
        ' 
        Me.tChart1.Legend.MaxNumRows = 8
        Me.tChart1.Location = New System.Drawing.Point(0, 127)
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Brush
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.tChart1.Series.Add(Me.surface1)
        Me.tChart1.Size = New System.Drawing.Size(440, 190)
        ' 
        ' tChart1.Walls
        ' 
        ' 
        ' tChart1.Walls.Back
        ' 
        ' 
        ' tChart1.Walls.Back.Brush
        ' 
        Me.tChart1.Walls.Back.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(224, System.Byte), CType(224, System.Byte), CType(224, System.Byte))
        Me.tChart1.Walls.Back.Transparent = False
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
        ' comboBox1
        ' 
        Me.comboBox1.Items.AddRange(New Object() {"Single", "Range", "Palette"})
        Me.comboBox1.Location = New System.Drawing.Point(128, 16)
        Me.comboBox1.Name = "comboBox1"
        Me.comboBox1.Size = New System.Drawing.Size(120, 21)
        Me.comboBox1.TabIndex = 0
        Me.comboBox1.Text = "comboBox1"
        AddHandler Me.comboBox1.SelectedIndexChanged, AddressOf Me.comboBox1_SelectedIndexChanged
        ' 
        ' label1
        ' 
        Me.label1.Location = New System.Drawing.Point(8, 16)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(120, 23)
        Me.label1.TabIndex = 1
        Me.label1.Text = "Wireframe color style:"
        ' 
        ' checkBox1
        ' 
        Me.checkBox1.Checked = True
        Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox1.Location = New System.Drawing.Point(272, 16)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(120, 24)
        Me.checkBox1.TabIndex = 2
        Me.checkBox1.Text = "Wireframe"
        AddHandler Me.checkBox1.CheckedChanged, AddressOf Me.checkBox1_CheckedChanged
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
        ' Surface_Wireframepalette
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(440, 317)
        Me.Name = "Surface_Wireframepalette"
        AddHandler Me.Load, AddressOf Me.Surface_Wireframepalette_Load
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub 'New 
#End Region


    Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        surface1.WireFrame = checkBox1.Checked
    End Sub 'checkBox1_CheckedChanged


    Private Sub comboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Select Case comboBox1.SelectedIndex
            Case 0
                surface1.UsePalette = False
                surface1.UseColorRange = False
                Exit Select
            Case 1
                surface1.UsePalette = False
                surface1.UseColorRange = True
                Exit Select
            Case 2
                surface1.UsePalette = True
                surface1.UseColorRange = False
                Exit Select
        End Select
    End Sub 'comboBox1_SelectedIndexChanged


    Private Sub Surface_Wireframepalette_Load(ByVal sender As Object, ByVal e As System.EventArgs)
        comboBox1.SelectedIndex = 2
    End Sub 'Surface_Wireframepalette_Load
End Class 'Surface_WirePalette