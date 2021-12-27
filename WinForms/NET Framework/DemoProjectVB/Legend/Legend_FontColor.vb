
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing

Imports System.Windows.Forms




Public Class Legend_FontColor
    Inherits Samples.BaseForm
    Private pointSeries1 As Steema.TeeChart.Styles.Points
    Private lineSeries1 As Steema.TeeChart.Styles.Line
    Private lineSeries2 As Steema.TeeChart.Styles.Line
    Private lineSeries3 As Steema.TeeChart.Styles.Line
    Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
    Private WithEvents checkBox2 As System.Windows.Forms.CheckBox
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
        Me.pointSeries1 = New Steema.TeeChart.Styles.Points
        Me.lineSeries1 = New Steema.TeeChart.Styles.Line
        Me.lineSeries2 = New Steema.TeeChart.Styles.Line
        Me.lineSeries3 = New Steema.TeeChart.Styles.Line
        Me.checkBox1 = New System.Windows.Forms.CheckBox
        Me.checkBox2 = New System.Windows.Forms.CheckBox
        Me.gridBand1 = New Steema.TeeChart.Tools.GridBand
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(466, 63)
        Me.textBox1.Text = "Legend.FontSeriesColor property displays each Legend item using the Series Color." + " Applies to both single and multiple series in the same chart." + vbCr + vbLf + vbCr + vbLf + "Example: tChart1.Legend.FontSeriesColor = true  "
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.checkBox2)
        Me.panel1.Controls.Add(Me.checkBox1)
        Me.panel1.Location = New System.Drawing.Point(0, 63)
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
        ' 
        ' tChart1.Legend
        ' 
        ' 
        ' tChart1.Legend.Font
        ' 
        Me.tChart1.Legend.Font.Italic = True
        ' 
        ' tChart1.Legend.Font.Shadow
        ' 
        Me.tChart1.Legend.Font.Shadow.Visible = True
        Me.tChart1.Legend.Font.Size = 10
        Me.tChart1.Legend.FontSeriesColor = True
        Me.tChart1.Location = New System.Drawing.Point(0, 97)
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Brush
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.tChart1.Series.Add(Me.pointSeries1)
        Me.tChart1.Series.Add(Me.lineSeries1)
        Me.tChart1.Series.Add(Me.lineSeries2)
        Me.tChart1.Series.Add(Me.lineSeries3)
        Me.tChart1.Size = New System.Drawing.Size(466, 189)
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
        ' pointSeries1
        ' 
        Me.pointSeries1.ColorEach = True
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
        Me.pointSeries1.Pointer.Brush.Color = System.Drawing.Color.Red
        Me.pointSeries1.Pointer.Brush.ForegroundColor = System.Drawing.Color.Empty
        ' 
        ' pointSeries1.Pointer.Pen
        ' 
        Me.pointSeries1.Pointer.Pen.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(64, System.Byte), CType(64, System.Byte), CType(64, System.Byte))
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
        ' lineSeries1
        ' 
        ' 
        ' lineSeries1.Brush
        ' 
        Me.lineSeries1.Brush.Color = System.Drawing.Color.Green
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
        Me.lineSeries1.Visible = False
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
        Me.lineSeries2.Brush.Color = System.Drawing.Color.Yellow
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
        Me.lineSeries2.Visible = False
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
        Me.lineSeries3.Brush.Color = System.Drawing.Color.Blue
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
        Me.lineSeries3.Visible = False
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
        ' checkBox1
        ' 
        Me.checkBox1.Checked = True
        Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox1.Location = New System.Drawing.Point(13, 6)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(180, 21)
        Me.checkBox1.TabIndex = 0
        Me.checkBox1.Text = "&Legend font series color"
        ' 
        ' checkBox2
        ' 
        Me.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox2.Location = New System.Drawing.Point(220, 6)
        Me.checkBox2.Name = "checkBox2"
        Me.checkBox2.Size = New System.Drawing.Size(100, 21)
        Me.checkBox2.TabIndex = 1
        Me.checkBox2.Text = "&Multiple series"
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
        ' Legend_FontColor
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(466, 286)
        Me.Name = "Legend_FontColor"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub 'InitializeComponent 
#End Region


    Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox1.CheckedChanged
        Me.tChart1.Legend.FontSeriesColor = Me.checkBox1.Checked
    End Sub 'checkBox1_CheckedChanged


    Private Sub checkBox2_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox2.CheckedChanged
        Me.lineSeries1.Active = Me.checkBox2.Checked
        Me.lineSeries2.Active = Me.checkBox2.Checked
        Me.lineSeries3.Active = Me.checkBox2.Checked

        Me.pointSeries1.ColorEach = Not Me.checkBox2.Checked
    End Sub 'checkBox2_CheckedChanged
End Class 'Legend_FontColor
