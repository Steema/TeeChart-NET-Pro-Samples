Imports System
#If VS2005 Then
Imports System.Collections.Generic
#End If
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms



Public Class SeriesType_ImagePoint
    Inherits Samples.BaseForm

    Private label1 As System.Windows.Forms.Label
    Private imagePoint1 As Steema.TeeChart.Styles.ImagePoint
    Private numericUpDown2 As System.Windows.Forms.NumericUpDown
    Private label2 As System.Windows.Forms.Label
    Private numericUpDown1 As System.Windows.Forms.NumericUpDown
    Private pictureBox1 As System.Windows.Forms.PictureBox
    Private label3 As System.Windows.Forms.Label


    '/ <summary>
    '/ Required designer variable.
    '/ </summary>
    Private components As System.ComponentModel.IContainer = Nothing


    Public Sub New() ' This call is required by the Windows Form Designer.
        InitializeComponent()


        Dim s As String = "Steema.TeeChart.Samples.point-image.bmp"
        Dim stream As System.IO.Stream = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream(s)
        If (Not stream Is Nothing) Then
            imagePoint1.PointImage = Image.FromStream(stream)
        End If

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SeriesType_ImagePoint))
        Me.imagePoint1 = New Steema.TeeChart.Styles.ImagePoint
        Me.label1 = New System.Windows.Forms.Label
        Me.numericUpDown1 = New System.Windows.Forms.NumericUpDown
        Me.label2 = New System.Windows.Forms.Label
        Me.numericUpDown2 = New System.Windows.Forms.NumericUpDown
        Me.pictureBox1 = New System.Windows.Forms.PictureBox
        Me.label3 = New System.Windows.Forms.Label
        Me.panel1.SuspendLayout()
        Me.chartContainer.SuspendLayout()
        CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
#If (VS2005) Then
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
#End If
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Text = "The ImagePoint style uses custom image to paint individual points." & vbCrLf & "Size is controlled using the ImagePoint.Pointer properties."
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.label3)
        Me.panel1.Controls.Add(Me.pictureBox1)
        Me.panel1.Controls.Add(Me.numericUpDown2)
        Me.panel1.Controls.Add(Me.label2)
        Me.panel1.Controls.Add(Me.numericUpDown1)
        Me.panel1.Controls.Add(Me.label1)
        ' 
        ' tChart1
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Aspect.ColorPaletteIndex = 0
        Me.tChart1.Aspect.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Legend.Title.Pen.Visible = False
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tChart1.Panel.Brush.Gradient.Sigma = True
        Me.tChart1.Panel.Brush.Gradient.SigmaFocus = 1.0!
        Me.tChart1.Panel.Brush.Gradient.SigmaScale = 0.8!
        Me.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tChart1.Series.Add(Me.imagePoint1)
        Me.tChart1.Size = New System.Drawing.Size(440, 205)
        ' 
        ' imagePoint1
        ' 
        Me.imagePoint1.ColorEach = False
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.imagePoint1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None
        Me.imagePoint1.Marks.Callout.ArrowHeadSize = 8
        ' 
        ' 
        ' 
        Me.imagePoint1.Marks.Callout.Brush.Color = System.Drawing.Color.Black
        Me.imagePoint1.Marks.Callout.Distance = 0
        Me.imagePoint1.Marks.Callout.Draw3D = False
        Me.imagePoint1.Marks.Callout.Length = 0
        Me.imagePoint1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        ' 
        ' 
        ' 
        Me.imagePoint1.Pointer.HorizSize = 8
        Me.imagePoint1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.imagePoint1.Pointer.VertSize = 8
        Me.imagePoint1.Pointer.Visible = True
        Me.imagePoint1.PointImage = CType(resources.GetObject("imagePoint1.PointImage"), System.Drawing.Image)
        Me.imagePoint1.Title = "point1"
        Me.imagePoint1.Transparent = True
        ' 
        ' 
        ' 
        Me.imagePoint1.XValues.DataMember = "X"
        Me.imagePoint1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' 
        ' 
        Me.imagePoint1.YValues.DataMember = "Y"
        ' 
        ' label1
        ' 
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(119, 14)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(35, 13)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Width"
        ' 
        ' numericUpDown1
        ' 
        Me.numericUpDown1.Location = New System.Drawing.Point(160, 12)
        Me.numericUpDown1.Name = "numericUpDown1"
        Me.numericUpDown1.Size = New System.Drawing.Size(42, 20)
        Me.numericUpDown1.TabIndex = 1
        Me.numericUpDown1.Value = New Decimal(New Integer() {8, 0, 0, 0})
        AddHandler numericUpDown1.ValueChanged, AddressOf Me.numericUpDown1_ValueChanged
        ' 
        ' label2
        ' 
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(221, 14)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(38, 13)
        Me.label2.TabIndex = 2
        Me.label2.Text = "Height"
        ' 
        ' numericUpDown2
        ' 
        Me.numericUpDown2.Location = New System.Drawing.Point(265, 12)
        Me.numericUpDown2.Name = "numericUpDown2"
        Me.numericUpDown2.Size = New System.Drawing.Size(42, 20)
        Me.numericUpDown2.TabIndex = 3
        Me.numericUpDown2.Value = New Decimal(New Integer() {8, 0, 0, 0})
        AddHandler numericUpDown2.ValueChanged, AddressOf Me.numericUpDown2_ValueChanged
        ' 
        ' pictureBox1
        ' 
        Me.pictureBox1.Location = New System.Drawing.Point(52, 6)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(34, 30)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox1.TabIndex = 4
        Me.pictureBox1.TabStop = False
        AddHandler pictureBox1.Click, AddressOf Me.pictureBox1_Click
        ' 
        ' label3
        ' 
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(10, 11)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(36, 13)
        Me.label3.TabIndex = 5
        Me.label3.Text = "Image"
        ' 
        ' SeriesType_ImagePoint
        ' 
        Me.ClientSize = New System.Drawing.Size(440, 317)
        Me.Name = "SeriesType_ImagePoint"
        AddHandler Load, AddressOf Me.SeriesType_ImagePoint_Load
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.chartContainer.ResumeLayout(False)
        CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
#If (VS2005) Then
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
#End If
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

#End Region

    Private Sub numericUpDown1_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)

        imagePoint1.Pointer.HorizSize = CType(numericUpDown1.Value, Integer)
    End Sub

    Private Sub numericUpDown2_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)

        imagePoint1.Pointer.VertSize = CType(numericUpDown2.Value, Integer)
    End Sub

    Private Sub SeriesType_ImagePoint_Load(ByVal sender As Object, ByVal e As EventArgs)

        pictureBox1.Image = imagePoint1.PointImage
        imagePoint1.FillSampleValues()
        numericUpDown1.Value = imagePoint1.Pointer.HorizSize
        numericUpDown2.Value = imagePoint1.Pointer.VertSize
    End Sub

    Private Sub pictureBox1_Click(ByVal sender As Object, ByVal e As EventArgs)

        Dim filename As String = Steema.TeeChart.Editors.PictureDialog.FileName(Me)
        If (filename.Length <> 0) Then
            imagePoint1.PointImage = Image.FromFile(filename)
            pictureBox1.Image = imagePoint1.PointImage
            numericUpDown1.Value = imagePoint1.Pointer.HorizSize
            numericUpDown2.Value = imagePoint1.Pointer.VertSize
        End If

    End Sub

End Class

