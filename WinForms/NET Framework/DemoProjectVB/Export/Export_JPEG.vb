
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing

Imports System.Windows.Forms




Public Class Export_JPEG
    Inherits Samples.BaseForm
    Private arrowSeries1 As Steema.TeeChart.Styles.Arrow
    Private WithEvents button1 As System.Windows.Forms.Button
    Private WithEvents button2 As System.Windows.Forms.Button
    Private saveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Private gridBand1 As Steema.TeeChart.Tools.GridBand
    Private components As System.ComponentModel.IContainer = Nothing
    
    
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        
        Me.arrowSeries1.FillSampleValues(8)
        Me.arrowSeries1.ArrowHeight = 10
        Me.arrowSeries1.ArrowWidth = 10
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
        Me.arrowSeries1 = New Steema.TeeChart.Styles.Arrow
        Me.button1 = New System.Windows.Forms.Button
        Me.button2 = New System.Windows.Forms.Button
        Me.saveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.gridBand1 = New Steema.TeeChart.Tools.GridBand
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(466, 32)
        Me.textBox1.Text = "Exporting to JPEG graphic format is available using the Export Dialog or by code " + "at run-time."
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.button2)
        Me.panel1.Controls.Add(Me.button1)
        Me.panel1.Location = New System.Drawing.Point(0, 32)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(466, 41)
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
        Me.tChart1.Location = New System.Drawing.Point(0, 73)
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Brush
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.tChart1.Series.Add(Me.arrowSeries1)
        Me.tChart1.Size = New System.Drawing.Size(466, 213)
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
        ' arrowSeries1
        ' 
        Me.arrowSeries1.ColorEach = True
        Me.arrowSeries1.LabelMember = "Labels"
        ' 
        ' arrowSeries1.Marks
        ' 
        ' 
        ' arrowSeries1.Marks.Pen
        ' 
        Me.arrowSeries1.Marks.Pen.Visible = False
        ' 
        ' arrowSeries1.Marks.Symbol
        ' 
        ' 
        ' arrowSeries1.Marks.Symbol.Shadow
        ' 
        Me.arrowSeries1.Marks.Symbol.Shadow.Height = 1
        Me.arrowSeries1.Marks.Symbol.Shadow.Visible = True
        Me.arrowSeries1.Marks.Symbol.Shadow.Width = 1
        Me.arrowSeries1.Marks.Transparent = True
        ' 
        ' arrowSeries1.Pointer
        ' 
        ' 
        ' arrowSeries1.Pointer.Brush
        ' 
        Me.arrowSeries1.Pointer.Brush.Color = System.Drawing.Color.Red
        Me.arrowSeries1.Pointer.Brush.ForegroundColor = System.Drawing.Color.Empty
        Me.arrowSeries1.Pointer.InflateMargins = False
        Me.arrowSeries1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.arrowSeries1.StartXValues = Me.arrowSeries1.XValues
        Me.arrowSeries1.StartYValues = Me.arrowSeries1.YValues
        Me.arrowSeries1.Title = "arrowSeries1"
        ' 
        ' arrowSeries1.XValues
        ' 
        Me.arrowSeries1.XValues.DataMember = "X"
        Me.arrowSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' arrowSeries1.YValues
        ' 
        Me.arrowSeries1.YValues.DataMember = "Y"
        ' 
        ' button1
        ' 
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.Location = New System.Drawing.Point(8, 8)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(107, 23)
        Me.button1.TabIndex = 0
        Me.button1.Text = "Save to &JPEG..."
        ' 
        ' button2
        ' 
        Me.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button2.Location = New System.Drawing.Point(127, 8)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(137, 23)
        Me.button2.TabIndex = 1
        Me.button2.Text = "Show &export dialog..."
        ' 
        ' saveFileDialog1
        ' 
        Me.saveFileDialog1.FileName = "doc1"
        Me.saveFileDialog1.Title = "Save Image (JPEG)"
        ' 
        ' gridBand1
        ' 
        Me.gridBand1.Axis = Me.tChart1.Axes.Left
        ' 
        ' gridBand1.Band1
        ' 
        Me.gridBand1.Band1.Color = System.Drawing.Color.FromArgb(CType(127, System.Byte), CType(128, System.Byte), CType(128, System.Byte), CType(0, System.Byte))
        ' 
        ' gridBand1.Band2
        ' 
        Me.gridBand1.Band2.Color = System.Drawing.Color.FromArgb(CType(127, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        ' 
        ' Export_JPEG
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(466, 286)
        Me.Name = "Export_JPEG"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub 'InitializeComponent 
#End Region


    Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
        saveFileDialog1.DefaultExt = tChart1.Export.Image.JPEG.FileExtension
        saveFileDialog1.FileName = tChart1.Name + "." + saveFileDialog1.DefaultExt
        saveFileDialog1.Filter = Texts.JPEGFilter
    If Me.saveFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
      ' set some jpeg properties
      tChart1.Export.Image.JPEG.GrayScale = True
      tChart1.Export.Image.JPEG.Quality = 75
      tChart1.Export.Image.JPEG.Save(saveFileDialog1.FileName)
    End If
  End Sub 'button1_Click


    Private Sub button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button2.Click
        tChart1.Export.ShowExportDialog(tChart1.Export.Image.JPEG)
    End Sub 'button2_Click
End Class 'Export_JPEG
