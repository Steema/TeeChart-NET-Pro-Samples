
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing

Imports System.Windows.Forms




Public Class Export_Text
    Inherits Samples.BaseForm
    Private lineSeries1 As Steema.TeeChart.Styles.Line
    Private lineSeries2 As Steema.TeeChart.Styles.Line
    Private lineSeries3 As Steema.TeeChart.Styles.Line
    Private WithEvents button1 As System.Windows.Forms.Button
    Private saveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Private checkBox1 As System.Windows.Forms.CheckBox
    Private checkBox2 As System.Windows.Forms.CheckBox
    Private checkBox3 As System.Windows.Forms.CheckBox
    Private WithEvents button2 As System.Windows.Forms.Button
    Private gridBand1 As Steema.TeeChart.Tools.GridBand
    Private components As System.ComponentModel.IContainer = Nothing
    
    
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        
        For Each s As Steema.TeeChart.Styles.Series In tChart1.Series
            s.FillSampleValues(10)
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
        Me.lineSeries1 = New Steema.TeeChart.Styles.Line
        Me.lineSeries2 = New Steema.TeeChart.Styles.Line
        Me.lineSeries3 = New Steema.TeeChart.Styles.Line
        Me.button1 = New System.Windows.Forms.Button
        Me.saveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.checkBox1 = New System.Windows.Forms.CheckBox
        Me.checkBox2 = New System.Windows.Forms.CheckBox
        Me.checkBox3 = New System.Windows.Forms.CheckBox
        Me.button2 = New System.Windows.Forms.Button
        Me.gridBand1 = New Steema.TeeChart.Tools.GridBand
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(466, 63)
        Me.textBox1.Text = "Series data can be exported to text (ascii). It allows saving to file and copying" + " to clipboard. There are several options when exporting t'o text format, such as" + " field delimiter, include labels and point's index, etc."
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.button2)
        Me.panel1.Controls.Add(Me.checkBox3)
        Me.panel1.Controls.Add(Me.checkBox2)
        Me.panel1.Controls.Add(Me.checkBox1)
        Me.panel1.Controls.Add(Me.button1)
        Me.panel1.Location = New System.Drawing.Point(0, 63)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(466, 78)
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
        Me.tChart1.Location = New System.Drawing.Point(0, 141)
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
        Me.tChart1.Size = New System.Drawing.Size(466, 145)
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
        ' button1
        ' 
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.Location = New System.Drawing.Point(13, 14)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(94, 23)
        Me.button1.TabIndex = 2
        Me.button1.Text = "&Save to Text..."
        ' 
        ' saveFileDialog1
        ' 
        Me.saveFileDialog1.FileName = "doc1"
        Me.saveFileDialog1.Title = "Save Data (Text)"
        ' 
        ' checkBox1
        ' 
        Me.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox1.Location = New System.Drawing.Point(287, 7)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(129, 21)
        Me.checkBox1.TabIndex = 4
        Me.checkBox1.Text = "Include &labels"
        ' 
        ' checkBox2
        ' 
        Me.checkBox2.Checked = True
        Me.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox2.Location = New System.Drawing.Point(287, 28)
        Me.checkBox2.Name = "checkBox2"
        Me.checkBox2.Size = New System.Drawing.Size(129, 21)
        Me.checkBox2.TabIndex = 5
        Me.checkBox2.Text = "Include &index"
        ' 
        ' checkBox3
        ' 
        Me.checkBox3.Checked = True
        Me.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox3.Location = New System.Drawing.Point(287, 49)
        Me.checkBox3.Name = "checkBox3"
        Me.checkBox3.Size = New System.Drawing.Size(129, 20)
        Me.checkBox3.TabIndex = 6
        Me.checkBox3.Text = "Include &header"
        ' 
        ' button2
        ' 
        Me.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button2.Location = New System.Drawing.Point(136, 14)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(131, 23)
        Me.button2.TabIndex = 7
        Me.button2.Text = "Show &export dialog..."
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
        Me.gridBand1.Band2.Color = System.Drawing.Color.FromArgb(CType(127, System.Byte), CType(128, System.Byte), CType(128, System.Byte), CType(128, System.Byte))
        ' 
        ' Export_Text
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(466, 286)
        Me.Name = "Export_Text"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub 'InitializeComponent 
#End Region


    Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
        saveFileDialog1.DefaultExt = tChart1.Export.Data.Text.FileExtension
        saveFileDialog1.FileName = tChart1.Name + "." + saveFileDialog1.DefaultExt
        saveFileDialog1.Filter = "Text files (*.csv;*.txt)|*.csv;*.txt"
    If Me.saveFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
      tChart1.Export.Data.Text.Series = Me.lineSeries1 ' export only 1st series
      tChart1.Export.Data.Text.IncludeLabels = checkBox1.Checked
      tChart1.Export.Data.Text.IncludeIndex = checkBox2.Checked
      tChart1.Export.Data.Text.IncludeHeader = checkBox3.Checked
      tChart1.Export.Data.Text.Save(Me.saveFileDialog1.FileName)
    End If
  End Sub 'button1_Click


    Private Sub button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button2.Click
        tChart1.Export.ShowExportDialog(tChart1.Export.Data.Text)
    End Sub 'button2_Click
End Class 'Export_Text
