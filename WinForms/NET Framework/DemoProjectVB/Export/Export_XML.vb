
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing

Imports System.Windows.Forms




Public Class Export_XML
    Inherits Samples.BaseForm
    Private WithEvents button1 As System.Windows.Forms.Button
    Private saveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Private WithEvents button2 As System.Windows.Forms.Button
    Private checkBox1 As System.Windows.Forms.CheckBox
    Private checkBox2 As System.Windows.Forms.CheckBox
    Private candleSeries1 As Steema.TeeChart.Styles.Candle
    Private pointSeries1 As Steema.TeeChart.Styles.Points
    Private gridBand1 As Steema.TeeChart.Tools.GridBand
    Private components As System.ComponentModel.IContainer = Nothing
    
    
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        

        For Each s As Steema.TeeChart.Styles.Series In tChart1.Series
            s.FillSampleValues(15)
        Next s
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
        Me.button1 = New System.Windows.Forms.Button
        Me.saveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.button2 = New System.Windows.Forms.Button
        Me.checkBox1 = New System.Windows.Forms.CheckBox
        Me.checkBox2 = New System.Windows.Forms.CheckBox
        Me.candleSeries1 = New Steema.TeeChart.Styles.Candle
        Me.pointSeries1 = New Steema.TeeChart.Styles.Points
        Me.gridBand1 = New Steema.TeeChart.Tools.GridBand
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(466, 63)
        Me.textBox1.Text = "Series data can be exported to XML. It allows saving to file and copying to clipb" + "oard. There are several options when exporting to XML format, such as include la" + "bels, point's index, etc."
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.checkBox2)
        Me.panel1.Controls.Add(Me.checkBox1)
        Me.panel1.Controls.Add(Me.button2)
        Me.panel1.Controls.Add(Me.button1)
        Me.panel1.Location = New System.Drawing.Point(0, 63)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(466, 57)
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
        Me.tChart1.Header.Visible = False
        Me.tChart1.Location = New System.Drawing.Point(0, 120)
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Brush
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.tChart1.Series.Add(Me.candleSeries1)
        Me.tChart1.Series.Add(Me.pointSeries1)
        Me.tChart1.Size = New System.Drawing.Size(466, 166)
        Me.tChart1.Tools.Add(Me.gridBand1)
        ' 
        ' button1
        ' 
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.Location = New System.Drawing.Point(7, 10)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(121, 23)
        Me.button1.TabIndex = 3
        Me.button1.Text = "&Save to XML..."
        ' 
        ' saveFileDialog1
        ' 
        Me.saveFileDialog1.FileName = "doc1"
        Me.saveFileDialog1.Title = "Save Data (XML)"
        ' 
        ' button2
        ' 
        Me.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button2.Location = New System.Drawing.Point(152, 10)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(144, 23)
        Me.button2.TabIndex = 8
        Me.button2.Text = "Show &export dialog..."
        ' 
        ' checkBox1
        ' 
        Me.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox1.Location = New System.Drawing.Point(327, 7)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(121, 21)
        Me.checkBox1.TabIndex = 9
        Me.checkBox1.Text = "Include &labels"
        ' 
        ' checkBox2
        ' 
        Me.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox2.Location = New System.Drawing.Point(327, 28)
        Me.checkBox2.Name = "checkBox2"
        Me.checkBox2.Size = New System.Drawing.Size(113, 21)
        Me.checkBox2.TabIndex = 10
        Me.checkBox2.Text = "Include &index"
        ' 
        ' candleSeries1
        ' 
        ' 
        ' candleSeries1.Brush
        ' 
        Me.candleSeries1.Brush.Color = System.Drawing.Color.Red
        Me.candleSeries1.CloseValues = Me.candleSeries1.YValues
        Me.candleSeries1.DateValues = Me.candleSeries1.XValues
        ' 
        ' candleSeries1.Marks
        ' 
        ' 
        ' candleSeries1.Marks.Symbol
        ' 
        ' 
        ' candleSeries1.Marks.Symbol.Shadow
        ' 
        Me.candleSeries1.Marks.Symbol.Shadow.Height = 1
        Me.candleSeries1.Marks.Symbol.Shadow.Visible = True
        Me.candleSeries1.Marks.Symbol.Shadow.Width = 1
        ' 
        ' candleSeries1.Pointer
        ' 
        ' 
        ' candleSeries1.Pointer.Brush
        ' 
        Me.candleSeries1.Pointer.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(0, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        Me.candleSeries1.Pointer.Draw3D = False
        Me.candleSeries1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.candleSeries1.Title = "candleSeries1"
        ' 
        ' candleSeries1.XValues
        ' 
        Me.candleSeries1.XValues.DataMember = "Date"
        Me.candleSeries1.XValues.DateTime = True
        Me.candleSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' candleSeries1.YValues
        ' 
        Me.candleSeries1.YValues.DataMember = "Close"
        ' 
        ' pointSeries1
        ' 
        ' 
        ' pointSeries1.Marks
        ' 
        ' 
        ' pointSeries1.Marks.Symbol
        ' 
        ' 
        ' pointSeries1.Marks.Symbol.Shadow
        ' 
        Me.pointSeries1.Marks.Symbol.Shadow.Height = 1
        Me.pointSeries1.Marks.Symbol.Shadow.Visible = True
        Me.pointSeries1.Marks.Symbol.Shadow.Width = 1
        ' 
        ' pointSeries1.Pointer
        ' 
        ' 
        ' pointSeries1.Pointer.Brush
        ' 
        Me.pointSeries1.Pointer.Brush.Color = System.Drawing.Color.Green
        Me.pointSeries1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.pointSeries1.Title = "pointSeries1"
        ' 
        ' pointSeries1.XValues
        ' 
        Me.pointSeries1.XValues.DataMember = "X"
        Me.pointSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' pointSeries1.YValues
        ' 
        Me.pointSeries1.YValues.DataMember = "Y"
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
        ' Export_XML
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(466, 286)
        Me.Name = "Export_XML"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub 'InitializeComponent 
#End Region


    Private Sub button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button2.Click
        tChart1.Export.ShowExportDialog(tChart1.Export.Data.XML)
    End Sub 'button2_Click


    Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
        saveFileDialog1.DefaultExt = tChart1.Export.Data.XML.FileExtension
        saveFileDialog1.FileName = tChart1.Name + "." + saveFileDialog1.DefaultExt
        saveFileDialog1.Filter = "XML files (*.xml)|*.xml"
    If Me.saveFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
      tChart1.Export.Data.XML.Series = Nothing ' export all series
      tChart1.Export.Data.XML.IncludeLabels = checkBox1.Checked
      tChart1.Export.Data.XML.IncludeIndex = checkBox2.Checked
      tChart1.Export.Data.XML.IncludeHeader = True
      tChart1.Export.Data.XML.Save(Me.saveFileDialog1.FileName)
    End If
  End Sub 'button1_Click
End Class 'Export_XML
