
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports System.IO


Public Class ColorGrid_Bitmap
    Inherits Steema.TeeChart.Samples.BaseForm
    Private pictureBox1 As System.Windows.Forms.PictureBox
    Private button1 As System.Windows.Forms.Button
    Private button2 As System.Windows.Forms.Button
    Private comboBox1 As System.Windows.Forms.ComboBox
    Private colorGrid1 As Steema.TeeChart.Styles.ColorGrid
    Private buttonPen1 As Steema.TeeChart.ButtonPen
    Private components As System.ComponentModel.IContainer = Nothing
    
    Public Sub New() ' This call is required by the Windows Form Designer.
        InitializeComponent()

        buttonPen1.Pen = colorGrid1.Pen
        comboBox1.SelectedIndex = 0
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(ColorGrid_Bitmap))
        Me.pictureBox1 = New System.Windows.Forms.PictureBox
        Me.button1 = New System.Windows.Forms.Button
        Me.button2 = New System.Windows.Forms.Button
        Me.comboBox1 = New System.Windows.Forms.ComboBox
        Me.colorGrid1 = New Steema.TeeChart.Styles.ColorGrid
        Me.buttonPen1 = New Steema.TeeChart.ButtonPen
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Text = "The ColorGrid series maintains an internal Bitmap property, filled using all series ""Y"" values. " + vbCr + vbLf + vbCr + vbLf + "It is also possible to do the opposite. In this example we set the Bitmap with a picture, and the color grid series will use this picture pixels as ""Y"" values."
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.buttonPen1)
        Me.panel1.Controls.Add(Me.comboBox1)
        Me.panel1.Controls.Add(Me.button2)
        Me.panel1.Controls.Add(Me.button1)
        Me.panel1.Controls.Add(Me.pictureBox1)
        Me.panel1.Name = "panel1"
        ' 
        ' tChart1
        ' 
        ' 
        ' tChart1.Aspect
        ' 
        Me.tChart1.Aspect.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality
        Me.tChart1.Aspect.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        Me.tChart1.Aspect.View3D = False
        ' 
        ' tChart1.Header
        ' 
        Me.tChart1.Header.Lines = New String() {"tChart1"}
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
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.tChart1.Series.Add(Me.colorGrid1)
        ' 
        ' pictureBox1
        ' 
        Me.pictureBox1.Image = CType(Resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
        Me.pictureBox1.Location = New System.Drawing.Point(344, -16)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(95, 77)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pictureBox1.TabIndex = 0
        Me.pictureBox1.TabStop = False
        ' 
        ' button1
        ' 
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.Location = New System.Drawing.Point(8, 8)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(56, 23)
        Me.button1.TabIndex = 1
        Me.button1.Text = "+ Zoom"
        AddHandler Me.button1.Click, AddressOf Me.button1_Click
        ' 
        ' button2
        ' 
        Me.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button2.Location = New System.Drawing.Point(72, 8)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(56, 23)
        Me.button2.TabIndex = 2
        Me.button2.Text = "- Zoom"
        AddHandler Me.button2.Click, AddressOf Me.button2_Click
        ' 
        ' comboBox1
        ' 
        Me.comboBox1.Items.AddRange(New Object() {"Original Colors", "Color Range", "Color Palette"})
        Me.comboBox1.Location = New System.Drawing.Point(136, 9)
        Me.comboBox1.Name = "comboBox1"
        Me.comboBox1.Size = New System.Drawing.Size(121, 21)
        Me.comboBox1.TabIndex = 3
        AddHandler Me.comboBox1.SelectedIndexChanged, AddressOf Me.comboBox1_SelectedIndexChanged
        ' 
        ' colorGrid1
        ' 
        ' 
        ' colorGrid1.Brush
        ' 
        Me.colorGrid1.Brush.Color = System.Drawing.Color.Red
        ' 
        ' colorGrid1.Marks
        ' 
        Me.colorGrid1.Marks.ArrowLength = 0
        ' 
        ' colorGrid1.Marks.Symbol
        ' 
        ' 
        ' colorGrid1.Marks.Symbol.Shadow
        ' 
        Me.colorGrid1.Marks.Symbol.Shadow.Height = 1
        Me.colorGrid1.Marks.Symbol.Shadow.Visible = True
        Me.colorGrid1.Marks.Symbol.Shadow.Width = 1
        Me.colorGrid1.PaletteMin = 0
        Me.colorGrid1.PaletteStep = 0
        ' 
        ' colorGrid1.Pen
        ' 
        Me.colorGrid1.Pen.Visible = False
        Me.colorGrid1.Title = "colorGrid1"
        ' 
        ' colorGrid1.XValues
        ' 
        Me.colorGrid1.XValues.DataMember = "X"
        ' 
        ' colorGrid1.YValues
        ' 
        Me.colorGrid1.YValues.DataMember = "Y"
        ' 
        ' colorGrid1.ZValues
        ' 
        Me.colorGrid1.ZValues.DataMember = "Z"
        ' 
        ' buttonPen1
        ' 
        Me.buttonPen1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonPen1.Location = New System.Drawing.Point(264, 8)
        Me.buttonPen1.Name = "buttonPen1"
        Me.buttonPen1.TabIndex = 4
        Me.buttonPen1.Text = "Grid..."
        ' 
        ' ColorGrid_Bitmap
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(440, 317)
        Me.Name = "ColorGrid_Bitmap"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub 'New 
#End Region


    Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        tChart1.Zoom.ZoomPercent(105)
    End Sub 'button1_Click


    Private Sub button2_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        tChart1.Zoom.ZoomPercent(95)
    End Sub 'button2_Click


    Private Sub SetFlower()
        Dim ms As New MemoryStream
        Dim flower As Image = pictureBox1.Image
        flower.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
        Dim bm As New Bitmap(ms)
        colorGrid1.Bitmap = bm
    End Sub 'SetFlower


    Private Sub comboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Select Case comboBox1.SelectedIndex
            Case 0
                colorGrid1.UseColorRange = False
                colorGrid1.UsePalette = False
                SetFlower()
            Case 1
                colorGrid1.Colors.Clear()
                colorGrid1.UseColorRange = True
                colorGrid1.UsePalette = False
            Case 2
                colorGrid1.Colors.Clear()
                colorGrid1.UseColorRange = False
                colorGrid1.UsePalette = True
        End Select
    End Sub 'comboBox1_SelectedIndexChanged
End Class 'ColorGrid_Bitmap