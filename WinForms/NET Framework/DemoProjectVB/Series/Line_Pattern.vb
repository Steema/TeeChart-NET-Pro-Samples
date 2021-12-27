
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing

Imports System.Windows.Forms



Public Class Line_Pattern
    Inherits Samples.BaseForm
    Private lineSeries1 As Steema.TeeChart.Styles.Line
    Private lineSeries2 As Steema.TeeChart.Styles.Line
    Private lineSeries3 As Steema.TeeChart.Styles.Line
    Private WithEvents pictureBox1 As System.Windows.Forms.PictureBox
    Private WithEvents pictureBox2 As System.Windows.Forms.PictureBox
    Private WithEvents pictureBox3 As System.Windows.Forms.PictureBox
    Private mainMenu1 As System.Windows.Forms.MainMenu
    Private gridBand1 As Steema.TeeChart.Tools.GridBand
    Private components As System.ComponentModel.IContainer = Nothing
    
    
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        

        For Each s As Steema.TeeChart.Styles.Series In tChart1.Series
            s.FillSampleValues(10)
        Next s
        lineSeries1.Brush.ImageMode = Steema.TeeChart.Drawing.ImageMode.Tile
        lineSeries2.Brush.ImageMode = Steema.TeeChart.Drawing.ImageMode.Tile
        lineSeries3.Brush.ImageMode = Steema.TeeChart.Drawing.ImageMode.Tile
        Me.lineSeries1.Brush.Image = Me.pictureBox1.Image
        Me.lineSeries2.Brush.Image = Me.pictureBox2.Image
        Me.lineSeries3.Brush.Image = Me.pictureBox3.Image
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
        Dim resources As New System.Resources.ResourceManager(GetType(Line_Pattern))
        Me.lineSeries1 = New Steema.TeeChart.Styles.Line
        Me.lineSeries2 = New Steema.TeeChart.Styles.Line
        Me.lineSeries3 = New Steema.TeeChart.Styles.Line
        Me.pictureBox1 = New System.Windows.Forms.PictureBox
        Me.pictureBox2 = New System.Windows.Forms.PictureBox
        Me.pictureBox3 = New System.Windows.Forms.PictureBox
        Me.mainMenu1 = New System.Windows.Forms.MainMenu
        Me.gridBand1 = New Steema.TeeChart.Tools.GridBand
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(466, 63)
        Me.textBox1.Text = "Small bitmap pictures can be used to fill Line series." + vbCr + vbLf + "Click the images to load " + "your custom small bitmaps..."
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.pictureBox3)
        Me.panel1.Controls.Add(Me.pictureBox2)
        Me.panel1.Controls.Add(Me.pictureBox1)
        Me.panel1.Location = New System.Drawing.Point(0, 63)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(466, 49)
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
        Me.tChart1.Header.Visible = False
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Brush
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.tChart1.Series.Add(Me.lineSeries1)
        Me.tChart1.Series.Add(Me.lineSeries2)
        Me.tChart1.Series.Add(Me.lineSeries3)
        Me.tChart1.Size = New System.Drawing.Size(466, 174)
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
        Me.tChart1.Walls.Bottom.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
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
        Me.tChart1.Walls.Left.Size = 6
        ' 
        ' lineSeries1
        ' 
        ' 
        ' lineSeries1.Brush
        ' 
        Me.lineSeries1.Brush.Color = System.Drawing.Color.Red
        ' 
        ' lineSeries1.Marks
        ' 
        ' 
        ' lineSeries1.Marks.Symbol
        ' 
        ' 
        ' lineSeries1.Marks.Symbol.Shadow
        ' 
        Me.lineSeries1.Marks.Symbol.Shadow.Height = 1
        Me.lineSeries1.Marks.Symbol.Shadow.Visible = True
        Me.lineSeries1.Marks.Symbol.Shadow.Width = 1
        ' 
        ' lineSeries1.Pointer
        ' 
        ' 
        ' lineSeries1.Pointer.Brush
        ' 
        Me.lineSeries1.Pointer.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(0, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        Me.lineSeries1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.lineSeries1.Title = "lineSeries1"
        ' 
        ' lineSeries1.XValues
        ' 
        Me.lineSeries1.XValues.DataMember = "X"
        Me.lineSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' lineSeries1.YValues
        ' 
        Me.lineSeries1.YValues.DataMember = "Y"
        ' 
        ' lineSeries2
        ' 
        ' 
        ' lineSeries2.Brush
        ' 
        Me.lineSeries2.Brush.Color = System.Drawing.Color.Green
        ' 
        ' lineSeries2.Marks
        ' 
        ' 
        ' lineSeries2.Marks.Symbol
        ' 
        ' 
        ' lineSeries2.Marks.Symbol.Shadow
        ' 
        Me.lineSeries2.Marks.Symbol.Shadow.Height = 1
        Me.lineSeries2.Marks.Symbol.Shadow.Visible = True
        Me.lineSeries2.Marks.Symbol.Shadow.Width = 1
        ' 
        ' lineSeries2.Pointer
        ' 
        ' 
        ' lineSeries2.Pointer.Brush
        ' 
        Me.lineSeries2.Pointer.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(0, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        Me.lineSeries2.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.lineSeries2.Title = "lineSeries2"
        ' 
        ' lineSeries2.XValues
        ' 
        Me.lineSeries2.XValues.DataMember = "X"
        Me.lineSeries2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' lineSeries2.YValues
        ' 
        Me.lineSeries2.YValues.DataMember = "Y"
        ' 
        ' lineSeries3
        ' 
        ' 
        ' lineSeries3.Brush
        ' 
        Me.lineSeries3.Brush.Color = System.Drawing.Color.Yellow
        ' 
        ' lineSeries3.Marks
        ' 
        ' 
        ' lineSeries3.Marks.Symbol
        ' 
        ' 
        ' lineSeries3.Marks.Symbol.Shadow
        ' 
        Me.lineSeries3.Marks.Symbol.Shadow.Height = 1
        Me.lineSeries3.Marks.Symbol.Shadow.Visible = True
        Me.lineSeries3.Marks.Symbol.Shadow.Width = 1
        ' 
        ' lineSeries3.Pointer
        ' 
        ' 
        ' lineSeries3.Pointer.Brush
        ' 
        Me.lineSeries3.Pointer.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(0, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        Me.lineSeries3.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.lineSeries3.Title = "lineSeries3"
        ' 
        ' lineSeries3.XValues
        ' 
        Me.lineSeries3.XValues.DataMember = "X"
        Me.lineSeries3.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' lineSeries3.YValues
        ' 
        Me.lineSeries3.YValues.DataMember = "Y"
        ' 
        ' pictureBox1
        ' 
        Me.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
        Me.pictureBox1.Location = New System.Drawing.Point(13, 9)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(34, 35)
        Me.pictureBox1.TabIndex = 0
        Me.pictureBox1.TabStop = False
        Me.pictureBox1.Tag = "0"
        ' 
        ' pictureBox2
        ' 
        Me.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pictureBox2.Image = CType(resources.GetObject("pictureBox2.Image"), System.Drawing.Image)
        Me.pictureBox2.Location = New System.Drawing.Point(60, 9)
        Me.pictureBox2.Name = "pictureBox2"
        Me.pictureBox2.Size = New System.Drawing.Size(33, 35)
        Me.pictureBox2.TabIndex = 1
        Me.pictureBox2.TabStop = False
        Me.pictureBox2.Tag = "1"
        ' 
        ' pictureBox3
        ' 
        Me.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pictureBox3.Image = CType(resources.GetObject("pictureBox3.Image"), System.Drawing.Image)
        Me.pictureBox3.Location = New System.Drawing.Point(107, 9)
        Me.pictureBox3.Name = "pictureBox3"
        Me.pictureBox3.Size = New System.Drawing.Size(33, 35)
        Me.pictureBox3.TabIndex = 2
        Me.pictureBox3.TabStop = False
        Me.pictureBox3.Tag = "2"
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
        ' Line_Patterns
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(466, 286)
        Me.Menu = Me.mainMenu1
        Me.Name = "Line_Patterns"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub 'InitializeComponent 
#End Region


    Private Sub pictureBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pictureBox1.Click, pictureBox2.Click, pictureBox3.Click
        Dim fileName As String = Steema.TeeChart.Editors.PictureDialog.FileName(Me)
        If (fileName <> "") Then
            Dim pbox As System.Windows.Forms.PictureBox = CType(sender, System.Windows.Forms.PictureBox)
            Dim SeriesIndex As Integer
            If (sender Is Me.pictureBox1) Then
                SeriesIndex = 0
            ElseIf (sender Is Me.pictureBox2) Then
                SeriesIndex = 1
            Else
                SeriesIndex = 2
            End If
            Dim lineseries As Steema.TeeChart.Styles.Line = CType(Me.tChart1.Series(SeriesIndex), Steema.TeeChart.Styles.Line)
            lineseries.Brush.Image = Image.FromFile(fileName)
            pbox.Image = lineseries.Brush.Image
        End If
    End Sub 'pictureBox1_Click
End Class 'Line_Pattern
