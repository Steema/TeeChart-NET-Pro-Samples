
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms


Public Class Export_PDF
    Inherits Steema.TeeChart.Samples.BaseForm
    Private button1 As System.Windows.Forms.Button
    Private saveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Private candle1 As Steema.TeeChart.Styles.Candle
    Private line1 As Steema.TeeChart.Styles.Line
    Private button2 As System.Windows.Forms.Button
    Private chartImage1 As Steema.TeeChart.Tools.ChartImage
    Private components As System.ComponentModel.IContainer = Nothing
    
    Public Sub New() ' This call is required by the Windows Form Designer.
        InitializeComponent()

        candle1.FillSampleValues()
        line1.FillSampleValues()
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

        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Export_PDF))
        Me.button1 = New System.Windows.Forms.Button
        Me.saveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.candle1 = New Steema.TeeChart.Styles.Candle
        Me.line1 = New Steema.TeeChart.Styles.Line
        Me.button2 = New System.Windows.Forms.Button
        Me.chartImage1 = New Steema.TeeChart.Tools.ChartImage
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(480, 56)
        Me.textBox1.Text = "Easy export to PDF format. Export filter generates all pdf page elements."
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.button2)
        Me.panel1.Controls.Add(Me.button1)
        Me.panel1.Location = New System.Drawing.Point(0, 56)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(480, 39)
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
        ' tChart1.Axes
        ' 
        ' 
        ' tChart1.Axes.Bottom
        ' 
        ' 
        ' tChart1.Axes.Bottom.Labels
        ' 
        Me.tChart1.Axes.Bottom.Labels.DateTimeFormat = "d.M.yyyy"
        ' 
        ' tChart1.Axes.Bottom.Labels.Font
        ' 
        Me.tChart1.Axes.Bottom.Labels.Font.Name = "Courier New"
        ' 
        ' tChart1.Axes.Left
        ' 
        ' 
        ' tChart1.Axes.Left.Labels
        ' 
        ' 
        ' tChart1.Axes.Left.Labels.Font
        ' 
        Me.tChart1.Axes.Left.Labels.Font.Name = "Courier New"
        Me.tChart1.BackColor = System.Drawing.Color.Transparent
        ' 
        ' tChart1.Header
        ' 
        ' 
        ' tChart1.Header.Font
        ' 
        Me.tChart1.Header.Font.Bold = True
        ' 
        ' tChart1.Header.Font.Brush
        ' 
        Me.tChart1.Header.Font.Brush.Color = System.Drawing.Color.Red
        Me.tChart1.Header.Font.Size = 9
        Me.tChart1.Header.Lines = New String() {"PDF Export"}
        ' 
        ' tChart1.Legend
        ' 
        Me.tChart1.Legend.Visible = False
        Me.tChart1.Location = New System.Drawing.Point(0, 95)
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Brush
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.tChart1.Panel.Brush.ImageMode = Steema.TeeChart.Drawing.ImageMode.Normal
        Me.tChart1.Panel.ImageMode = Steema.TeeChart.Drawing.ImageMode.Normal
        Me.tChart1.Series.Add(Me.candle1)
        Me.tChart1.Series.Add(Me.line1)
        Me.tChart1.Size = New System.Drawing.Size(480, 254)
        Me.tChart1.Tools.Add(Me.chartImage1)
        AddHandler Me.tChart1.AfterDraw, AddressOf Me.tChart1_AfterDraw
        ' 
        ' button1
        ' 
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.Location = New System.Drawing.Point(8, 8)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(104, 23)
        Me.button1.TabIndex = 2
        Me.button1.Text = "Save to PDF"
        AddHandler Me.button1.Click, AddressOf Me.button1_Click
        ' 
        ' candle1
        ' 
        ' 
        ' candle1.Brush
        ' 
        Me.candle1.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(0, System.Byte), CType(0, System.Byte), CType(192, System.Byte))
        Me.candle1.CloseValues = Me.candle1.YValues
        Me.candle1.DateValues = Me.candle1.XValues
        ' 
        ' candle1.Marks
        ' 
        ' 
        ' candle1.Marks.Symbol
        ' 
        ' 
        ' candle1.Marks.Symbol.Shadow
        ' 
        Me.candle1.Marks.Symbol.Shadow.Height = 1
        Me.candle1.Marks.Symbol.Shadow.Visible = True
        Me.candle1.Marks.Symbol.Shadow.Width = 1
        ' 
        ' candle1.Pointer
        ' 
        ' 
        ' candle1.Pointer.Brush
        ' 
        Me.candle1.Pointer.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(0, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        Me.candle1.Pointer.Draw3D = False
        Me.candle1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.candle1.Title = "candle1"
        ' 
        ' candle1.XValues
        ' 
        Me.candle1.XValues.DataMember = "Date"
        Me.candle1.XValues.DateTime = True
        Me.candle1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' candle1.YValues
        ' 
        Me.candle1.YValues.DataMember = "Close"
        ' 
        ' line1
        ' 
        ' 
        ' line1.Brush
        ' 
        Me.line1.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(192, System.Byte), CType(0, System.Byte), CType(192, System.Byte))
        Me.line1.ColorEach = True
        Me.line1.ColorEachLine = False
        ' 
        ' line1.Marks
        ' 
        ' 
        ' line1.Marks.Symbol
        ' 
        ' 
        ' line1.Marks.Symbol.Shadow
        ' 
        Me.line1.Marks.Symbol.Shadow.Height = 1
        Me.line1.Marks.Symbol.Shadow.Visible = True
        Me.line1.Marks.Symbol.Shadow.Width = 1
        ' 
        ' line1.Pointer
        ' 
        ' 
        ' line1.Pointer.Brush
        ' 
        Me.line1.Pointer.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(0, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        Me.line1.Pointer.HorizSize = 3
        Me.line1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Triangle
        Me.line1.Pointer.VertSize = 3
        Me.line1.Pointer.Visible = True
        Me.line1.Title = "line1"
        ' 
        ' line1.XValues
        ' 
        Me.line1.XValues.DataMember = "X"
        Me.line1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' line1.YValues
        ' 
        Me.line1.YValues.DataMember = "Y"
        ' 
        ' button2
        ' 
        Me.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button2.Location = New System.Drawing.Point(152, 8)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(120, 23)
        Me.button2.TabIndex = 3
        Me.button2.Text = "Show export dialog"
        AddHandler Me.button2.Click, AddressOf Me.button2_Click
        ' 
        ' chartImage1
        ' 
        Me.chartImage1.Image = CType(Resources.GetObject("chartImage1.Image"), System.Drawing.Image)
        Me.chartImage1.ImageMode = Steema.TeeChart.Drawing.ImageMode.Center
        ' 
        ' Export_PDF
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(480, 349)
        Me.Name = "Export_PDF"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub 'New 
#End Region


    Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        saveFileDialog1.DefaultExt = tChart1.Export.Image.PDF.FileExtension
        saveFileDialog1.FileName = tChart1.Name + "." + saveFileDialog1.DefaultExt
        saveFileDialog1.Filter = Texts.PDFFilter
    If Me.saveFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
      tChart1.Export.Image.PDF.Save(saveFileDialog1.FileName)
    End If
  End Sub 'button1_Click


    Private Sub button2_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        tChart1.Export.ShowExportDialog(tChart1.Export.Image.PDF)
    End Sub 'button2_Click


    Private Sub tChart1_AfterDraw(ByVal sender As Object, ByVal g As Steema.TeeChart.Drawing.Graphics3D)
        g.Brush.Visible = True
        g.Brush.Color = Color.White
        g.Pie(100, 100, 150, 300, 150, 100, 200, 200)
    End Sub 'tChart1_AfterDraw
End Class 'Export_PDF