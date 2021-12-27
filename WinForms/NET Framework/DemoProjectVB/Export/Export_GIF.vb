
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing

Imports System.Windows.Forms




Public Class Export_GIF
    Inherits Samples.BaseForm
    Private bubbleSeries1 As Steema.TeeChart.Styles.Bubble
    Private WithEvents button1 As System.Windows.Forms.Button
    Private WithEvents button2 As System.Windows.Forms.Button
    Private saveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Private gridBand1 As Steema.TeeChart.Tools.GridBand
    Private components As System.ComponentModel.IContainer = Nothing
    
    
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        
        Me.bubbleSeries1.FillSampleValues(8)
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
        Me.bubbleSeries1 = New Steema.TeeChart.Styles.Bubble
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
        Me.textBox1.Size = New System.Drawing.Size(466, 56)
        Me.textBox1.Text = "Exporting to GIF graphic format is available using the Export Dialog or by code a" + "t run-time. " + vbCr + vbLf + vbCr + vbLf + "NOTE : Check the LZW compression patent issues."
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.button2)
        Me.panel1.Controls.Add(Me.button1)
        Me.panel1.Location = New System.Drawing.Point(0, 56)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(466, 34)
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
        Me.tChart1.Header.Lines = New String(-1) {}
        Me.tChart1.Header.Visible = False
        Me.tChart1.Location = New System.Drawing.Point(0, 90)
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Brush
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.tChart1.Series.Add(Me.bubbleSeries1)
        Me.tChart1.Size = New System.Drawing.Size(466, 196)
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
        ' bubbleSeries1
        ' 
        Me.bubbleSeries1.LabelMember = "Labels"
        ' 
        ' bubbleSeries1.Marks
        ' 
        ' 
        ' bubbleSeries1.Marks.Symbol
        ' 
        ' 
        ' bubbleSeries1.Marks.Symbol.Shadow
        ' 
        Me.bubbleSeries1.Marks.Symbol.Shadow.Height = 1
        Me.bubbleSeries1.Marks.Symbol.Shadow.Visible = True
        Me.bubbleSeries1.Marks.Symbol.Shadow.Width = 1
        Me.bubbleSeries1.Marks.Transparent = True
        ' 
        ' bubbleSeries1.Pointer
        ' 
        ' 
        ' bubbleSeries1.Pointer.Brush
        ' 
        Me.bubbleSeries1.Pointer.Brush.Color = System.Drawing.Color.Red
        Me.bubbleSeries1.Pointer.Brush.ForegroundColor = System.Drawing.Color.Empty
        Me.bubbleSeries1.Pointer.HorizSize = 19
        Me.bubbleSeries1.Pointer.InflateMargins = False
        Me.bubbleSeries1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Circle
        Me.bubbleSeries1.Pointer.VertSize = 19
        Me.bubbleSeries1.Title = "bubbleSeries1"
        ' 
        ' bubbleSeries1.XValues
        ' 
        Me.bubbleSeries1.XValues.DataMember = "X"
        Me.bubbleSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' bubbleSeries1.YValues
        ' 
        Me.bubbleSeries1.YValues.DataMember = "Y"
        ' 
        ' button1
        ' 
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.Location = New System.Drawing.Point(13, 6)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(107, 23)
        Me.button1.TabIndex = 2
        Me.button1.Text = "&Save to GIF..."
        ' 
        ' button2
        ' 
        Me.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button2.Location = New System.Drawing.Point(144, 6)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(147, 23)
        Me.button2.TabIndex = 3
        Me.button2.Text = "Show &export dialog..."
        ' 
        ' saveFileDialog1
        ' 
        Me.saveFileDialog1.FileName = "doc1"
        Me.saveFileDialog1.Title = "Save Image (GIF)"
        ' 
        ' gridBand1
        ' 
        Me.gridBand1.Axis = Me.tChart1.Axes.Left
        ' 
        ' gridBand1.Band1
        ' 
        Me.gridBand1.Band1.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(224, System.Byte), CType(224, System.Byte), CType(224, System.Byte))
        ' 
        ' gridBand1.Band2
        ' 
        Me.gridBand1.Band2.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        ' 
        ' Export_GIF
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(466, 286)
        Me.Name = "Export_GIF"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub 'InitializeComponent 
#End Region


    Private Sub button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button2.Click
        tChart1.Export.ShowExportDialog(tChart1.Export.Image.GIF)
    End Sub 'button2_Click


    Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
        saveFileDialog1.DefaultExt = tChart1.Export.Image.GIF.FileExtension
        saveFileDialog1.FileName = tChart1.Name + "." + saveFileDialog1.DefaultExt
        saveFileDialog1.Filter = Texts.GIFFilter
    If Me.saveFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
      ' set gif image properties, then save.
      tChart1.Export.Image.GIF.Save(saveFileDialog1.FileName)
    End If
  End Sub 'button1_Click
End Class 'Export_GIF
