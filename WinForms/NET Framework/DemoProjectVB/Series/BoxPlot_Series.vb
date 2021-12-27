
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms



Public Class BoxPlot_Series
    Inherits Samples.BaseForm
    Private boxSeries1 As Steema.TeeChart.Styles.Box
    Private boxSeries2 As Steema.TeeChart.Styles.Box
    Private boxSeries3 As Steema.TeeChart.Styles.Box
    Private WithEvents button1 As System.Windows.Forms.Button
    Private gridBand1 As Steema.TeeChart.Tools.GridBand
    Private components As System.ComponentModel.IContainer = Nothing
    
    
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        
        boxSeries1.Add(New Double(5) {3, 6, 8, 15, 19, 21})
        boxSeries2.Add(New Double(3) {5, 7, 12, 21})
        boxSeries3.Add(New Double(4) {6, 7, 8, 15, 21})
        
        ' A simple trick to force custom axis labels on bottom axis.
        ' In this case, series titles
        Dim labels As Steema.TeeChart.AxisLabelsItems = tChart1.Axes.Bottom.Labels.Items
        labels.Clear()

        For Each b As Styles.Box In tChart1.Series
            labels.Add(b.Position, b.Title)
        Next b
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
        Me.boxSeries1 = New Steema.TeeChart.Styles.Box
        Me.boxSeries2 = New Steema.TeeChart.Styles.Box
        Me.boxSeries3 = New Steema.TeeChart.Styles.Box
        Me.button1 = New System.Windows.Forms.Button
        Me.gridBand1 = New Steema.TeeChart.Tools.GridBand
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(466, 63)
        Me.textBox1.Text = "Box series (also called Box & Whisker or Box-Plot) draws a ""box"" and  calculates " + "the Median and Whisker quantities." + vbCr + vbLf + "All visual parts are fully configurable."
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.button1)
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
        Me.tChart1.Aspect.View3D = False
        ' 
        ' tChart1.Header
        ' 
        ' 
        ' tChart1.Header.Font
        ' 
        Me.tChart1.Header.Font.Bold = True
        Me.tChart1.Header.Font.Size = 7
        Me.tChart1.Header.Lines = New String() {"BoxPlot series example"}
        Me.tChart1.Location = New System.Drawing.Point(0, 97)
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Brush
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        ' 
        ' tChart1.Panel.Gradient
        ' 
        Me.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(215, System.Byte), CType(0, System.Byte))
        Me.tChart1.Panel.Brush.Gradient.Transparency = 40
        Me.tChart1.Panel.Brush.Gradient.Visible = True
        ' 
        ' tChart1.Panel.Gradient
        ' 
        Me.tChart1.Panel.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(215, System.Byte), CType(0, System.Byte))
        Me.tChart1.Panel.Gradient.Transparency = 40
        Me.tChart1.Panel.Gradient.Visible = True
        Me.tChart1.Series.Add(Me.boxSeries1)
        Me.tChart1.Series.Add(Me.boxSeries2)
        Me.tChart1.Series.Add(Me.boxSeries3)
        Me.tChart1.Size = New System.Drawing.Size(466, 189)
        Me.tChart1.Tools.Add(Me.gridBand1)
        ' 
        ' boxSeries1
        ' 
        Me.boxSeries1.AdjacentPoint1 = 1
        Me.boxSeries1.AdjacentPoint3 = 12
        ' 
        ' boxSeries1.ExtrOut
        ' 
        ' 
        ' boxSeries1.ExtrOut.Brush
        ' 
        Me.boxSeries1.ExtrOut.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.boxSeries1.ExtrOut.Style = Steema.TeeChart.Styles.PointerStyles.Star
        Me.boxSeries1.ExtrOut.Visible = False
        Me.boxSeries1.InnerFence1 = -7.5
        Me.boxSeries1.InnerFence3 = 20.5
        ' 
        ' boxSeries1.LinePen
        ' 
        Me.boxSeries1.LinePen.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(124, System.Byte), CType(21, System.Byte), CType(10, System.Byte))
        ' 
        ' boxSeries1.Marks
        ' 
        ' 
        ' boxSeries1.Marks.Symbol
        ' 
        ' 
        ' boxSeries1.Marks.Symbol.Shadow
        ' 
        Me.boxSeries1.Marks.Symbol.Shadow.Height = 1
        Me.boxSeries1.Marks.Symbol.Shadow.Visible = True
        Me.boxSeries1.Marks.Symbol.Shadow.Width = 1
        Me.boxSeries1.Median = 6.5
        ' 
        ' boxSeries1.MedianPen
        ' 
        Me.boxSeries1.MedianPen.Style = System.Drawing.Drawing2D.DashStyle.Dot
        ' 
        ' boxSeries1.MildOut
        ' 
        ' 
        ' boxSeries1.MildOut.Brush
        ' 
        Me.boxSeries1.MildOut.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.boxSeries1.MildOut.Style = Steema.TeeChart.Styles.PointerStyles.Circle
        Me.boxSeries1.MildOut.Visible = False
        Me.boxSeries1.OuterFence1 = -18
        Me.boxSeries1.OuterFence3 = 31
        ' 
        ' boxSeries1.Pointer
        ' 
        ' 
        ' boxSeries1.Pointer.Brush
        ' 
        Me.boxSeries1.Pointer.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(207, System.Byte), CType(35, System.Byte), CType(16, System.Byte))
        Me.boxSeries1.Pointer.Draw3D = False
        Me.boxSeries1.Pointer.HorizSize = 15
        ' 
        ' boxSeries1.Pointer.Pen
        ' 
        Me.boxSeries1.Pointer.Pen.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(124, System.Byte), CType(21, System.Byte), CType(10, System.Byte))
        Me.boxSeries1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.boxSeries1.Pointer.VertSize = 15
        Me.boxSeries1.Quartile1 = 3
        Me.boxSeries1.Quartile3 = 10
        Me.boxSeries1.Title = "Dataset 1"
        ' 
        ' boxSeries1.XValues
        ' 
        Me.boxSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' boxSeries2
        ' 
        Me.boxSeries2.AdjacentPoint1 = 1
        Me.boxSeries2.AdjacentPoint3 = 19
        ' 
        ' boxSeries2.ExtrOut
        ' 
        ' 
        ' boxSeries2.ExtrOut.Brush
        ' 
        Me.boxSeries2.ExtrOut.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.boxSeries2.ExtrOut.Style = Steema.TeeChart.Styles.PointerStyles.Star
        Me.boxSeries2.ExtrOut.Visible = False
        Me.boxSeries2.InnerFence1 = -10
        Me.boxSeries2.InnerFence3 = 30
        ' 
        ' boxSeries2.LinePen
        ' 
        Me.boxSeries2.LinePen.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(0, System.Byte), CType(67, System.Byte), CType(0, System.Byte))
        ' 
        ' boxSeries2.Marks
        ' 
        ' 
        ' boxSeries2.Marks.Symbol
        ' 
        ' 
        ' boxSeries2.Marks.Symbol.Shadow
        ' 
        Me.boxSeries2.Marks.Symbol.Shadow.Height = 1
        Me.boxSeries2.Marks.Symbol.Shadow.Visible = True
        Me.boxSeries2.Marks.Symbol.Shadow.Width = 1
        Me.boxSeries2.Median = 10
        ' 
        ' boxSeries2.MedianPen
        ' 
        Me.boxSeries2.MedianPen.Style = System.Drawing.Drawing2D.DashStyle.Dot
        ' 
        ' boxSeries2.MildOut
        ' 
        ' 
        ' boxSeries2.MildOut.Brush
        ' 
        Me.boxSeries2.MildOut.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.boxSeries2.MildOut.Style = Steema.TeeChart.Styles.PointerStyles.Circle
        Me.boxSeries2.MildOut.Visible = False
        Me.boxSeries2.OuterFence1 = -25
        Me.boxSeries2.OuterFence3 = 45
        ' 
        ' boxSeries2.Pointer
        ' 
        ' 
        ' boxSeries2.Pointer.Brush
        ' 
        Me.boxSeries2.Pointer.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(0, System.Byte), CType(111, System.Byte), CType(0, System.Byte))
        Me.boxSeries2.Pointer.Draw3D = False
        Me.boxSeries2.Pointer.HorizSize = 15
        ' 
        ' boxSeries2.Pointer.Pen
        ' 
        Me.boxSeries2.Pointer.Pen.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(0, System.Byte), CType(67, System.Byte), CType(0, System.Byte))
        Me.boxSeries2.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.boxSeries2.Pointer.VertSize = 15
        Me.boxSeries2.Position = 1
        Me.boxSeries2.Quartile1 = 5
        Me.boxSeries2.Quartile3 = 15
        Me.boxSeries2.Title = "Dataset 2"
        ' 
        ' boxSeries2.XValues
        ' 
        Me.boxSeries2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' boxSeries3
        ' 
        Me.boxSeries3.AdjacentPoint1 = 2
        Me.boxSeries3.AdjacentPoint3 = 25
        ' 
        ' boxSeries3.ExtrOut
        ' 
        ' 
        ' boxSeries3.ExtrOut.Brush
        ' 
        Me.boxSeries3.ExtrOut.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.boxSeries3.ExtrOut.Style = Steema.TeeChart.Styles.PointerStyles.Star
        Me.boxSeries3.ExtrOut.Visible = False
        Me.boxSeries3.InnerFence1 = -14.5
        Me.boxSeries3.InnerFence3 = 41.5 
        ' 
        ' boxSeries3.LinePen
        ' 
        Me.boxSeries3.LinePen.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(134, System.Byte), CType(134, System.Byte), CType(0, System.Byte))
        ' 
        ' boxSeries3.Marks
        ' 
        ' 
        ' boxSeries3.Marks.Symbol
        ' 
        ' 
        ' boxSeries3.Marks.Symbol.Shadow
        ' 
        Me.boxSeries3.Marks.Symbol.Shadow.Height = 1
        Me.boxSeries3.Marks.Symbol.Shadow.Visible = True
        Me.boxSeries3.Marks.Symbol.Shadow.Width = 1
        Me.boxSeries3.Median = 13.5
        ' 
        ' boxSeries3.MedianPen
        ' 
        Me.boxSeries3.MedianPen.Style = System.Drawing.Drawing2D.DashStyle.Dot
        ' 
        ' boxSeries3.MildOut
        ' 
        ' 
        ' boxSeries3.MildOut.Brush
        ' 
        Me.boxSeries3.MildOut.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.boxSeries3.MildOut.Style = Steema.TeeChart.Styles.PointerStyles.Circle
        Me.boxSeries3.MildOut.Visible = False
        Me.boxSeries3.OuterFence1 = -35.5
        Me.boxSeries3.OuterFence3 = 62.5 
        ' 
        ' boxSeries3.Pointer
        ' 
        ' 
        ' boxSeries3.Pointer.Brush
        ' 
        Me.boxSeries3.Pointer.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(223, System.Byte), CType(223, System.Byte), CType(0, System.Byte))
        Me.boxSeries3.Pointer.Draw3D = False
        Me.boxSeries3.Pointer.HorizSize = 15
        ' 
        ' boxSeries3.Pointer.Pen
        ' 
        Me.boxSeries3.Pointer.Pen.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(134, System.Byte), CType(134, System.Byte), CType(0, System.Byte))
        Me.boxSeries3.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.boxSeries3.Pointer.VertSize = 15
        Me.boxSeries3.Position = 2
        Me.boxSeries3.Quartile1 = 6.5
        Me.boxSeries3.Quartile3 = 20.5
        Me.boxSeries3.Title = "Dataset 3"
        '
        ' boxSeries3.XValues
        ' 
        Me.boxSeries3.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' button1
        ' 
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.Location = New System.Drawing.Point(16, 7)
        Me.button1.Name = "button1"
        Me.button1.TabIndex = 1
        Me.button1.Text = "&Edit..."
        ' 
        ' gridBand1
        ' 
        Me.gridBand1.Axis = Me.tChart1.Axes.Left
        ' 
        ' gridBand1.Band1
        ' 
        Me.gridBand1.Band1.Color = System.Drawing.Color.FromArgb(CType(127, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(128, System.Byte))
        ' 
        ' gridBand1.Band2
        ' 
        Me.gridBand1.Band2.Color = System.Drawing.Color.FromArgb(CType(127, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        ' 
        ' SeriesType_BoxPlot
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(466, 286)
        Me.Name = "SeriesType_BoxPlot"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub 'InitializeComponent 
#End Region


    Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
        tChart1.ShowEditor()
    End Sub 'button1_Click


    Private Sub tChart1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tChart1.Click
    End Sub 'tChart1_Click
End Class 'BoxPlot_Series 