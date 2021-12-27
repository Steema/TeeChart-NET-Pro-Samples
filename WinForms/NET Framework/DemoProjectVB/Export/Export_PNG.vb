
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing

Imports System.Windows.Forms




Public Class Export_PNG
    Inherits Samples.BaseForm
    Private WithEvents button1 As System.Windows.Forms.Button
    Private WithEvents button2 As System.Windows.Forms.Button
    Private saveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Private ganttSeries1 As Steema.TeeChart.Styles.Gantt
    Private components As System.ComponentModel.IContainer = Nothing
    
    
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        
        Me.ganttSeries1.FillSampleValues(6)
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
        Me.button2 = New System.Windows.Forms.Button
        Me.saveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.ganttSeries1 = New Steema.TeeChart.Styles.Gantt
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(466, 40)
        Me.textBox1.Text = "Exporting to PNG graphic format is available using the Export Dialog or by code a" + "t run-time."
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.button2)
        Me.panel1.Controls.Add(Me.button1)
        Me.panel1.Location = New System.Drawing.Point(0, 40)
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
        Me.tChart1.Header.Lines = New String() {"tChart1"}
        Me.tChart1.Header.Visible = False
        Me.tChart1.Location = New System.Drawing.Point(0, 74)
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Brush
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.tChart1.Series.Add(Me.ganttSeries1)
        Me.tChart1.Size = New System.Drawing.Size(466, 212)
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
        ' button1
        ' 
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.Location = New System.Drawing.Point(13, 7)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(94, 23)
        Me.button1.TabIndex = 1
        Me.button1.Text = "&Save to PNG..."
        ' 
        ' button2
        ' 
        Me.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button2.Location = New System.Drawing.Point(128, 7)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(131, 23)
        Me.button2.TabIndex = 2
        Me.button2.Text = "Show &export dialog..."
        ' 
        ' saveFileDialog1
        ' 
        Me.saveFileDialog1.FileName = "doc1"
        Me.saveFileDialog1.Title = "Save Image (PNG)"
        ' 
        ' ganttSeries1
        ' 
        Me.ganttSeries1.ColorEach = True
        ' 
        ' ganttSeries1.EndValues
        ' 
        Me.ganttSeries1.EndValues.DataMember = "End"
        Me.ganttSeries1.EndValues.DateTime = True
        Me.ganttSeries1.LabelMember = "Labels"
        ' 
        ' ganttSeries1.Marks
        ' 
        ' 
        ' ganttSeries1.Marks.Symbol
        ' 
        ' 
        ' ganttSeries1.Marks.Symbol.Shadow
        ' 
        Me.ganttSeries1.Marks.Symbol.Shadow.Height = 1
        Me.ganttSeries1.Marks.Symbol.Shadow.Visible = True
        Me.ganttSeries1.Marks.Symbol.Shadow.Width = 1
        ' 
        ' ganttSeries1.NextTasks
        ' 
        Me.ganttSeries1.NextTasks.DataMember = "NextTask"
        ' 
        ' ganttSeries1.Pointer
        ' 
        ' 
        ' ganttSeries1.Pointer.Brush
        ' 
        Me.ganttSeries1.Pointer.Brush.Color = System.Drawing.Color.Red
        Me.ganttSeries1.Pointer.Brush.ForegroundColor = System.Drawing.Color.Empty
        Me.ganttSeries1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        ' 
        ' ganttSeries1.StartValues
        ' 
        Me.ganttSeries1.StartValues.DataMember = "Start"
        Me.ganttSeries1.StartValues.DateTime = True
        Me.ganttSeries1.Title = "ganttSeries1"
        ' 
        ' ganttSeries1.StartValues
        ' 
        Me.ganttSeries1.XValues.DataMember = "Start"
        Me.ganttSeries1.XValues.DateTime = True
        ' 
        ' ganttSeries1.YValues
        ' 
        Me.ganttSeries1.YValues.DataMember = "Y"
        ' 
        ' Export_PNG
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(466, 286)
        Me.Name = "Export_PNG"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub 'InitializeComponent 
#End Region


    Private Sub button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button2.Click
        tChart1.Export.ShowExportDialog(tChart1.Export.Image.PNG)
    End Sub 'button2_Click


    Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
        saveFileDialog1.DefaultExt = tChart1.Export.Image.PNG.FileExtension
        saveFileDialog1.FileName = tChart1.Name + "." + saveFileDialog1.DefaultExt
        saveFileDialog1.Filter = Texts.PNGFilter
    If Me.saveFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
      ' set properties
      tChart1.Export.Image.PNG.GrayScale = False
      tChart1.Export.Image.PNG.Save(saveFileDialog1.FileName)
    End If
  End Sub 'button1_Click
End Class 'Export_PNG
