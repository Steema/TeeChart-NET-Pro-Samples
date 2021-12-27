
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms


Public Class Candle_AxisLabels
    Inherits Samples.BaseForm
    Private candleSeries1 As Steema.TeeChart.Styles.Candle
    Private components As System.ComponentModel.IContainer = Nothing
    
    Public Sub New() ' This call is required by the Windows Form Designer.
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Dim r As Random = New Random
        candleSeries1.Clear()
        Dim labels As TeeChart.Styles.StringList = New TeeChart.Styles.StringList(10)
        labels.Add("07/02/2003")
        labels.Add("10/02/2003")
        labels.Add("11/02/2003")
        labels.Add("12/02/2003")
        labels.Add("13/02/2003")
        labels.Add("14/02/2003")
        labels.Add("17/02/2003")
        labels.Add("18/02/2003")
        labels.Add("19/02/2003")
        candleSeries1.XValues.DateTime = False
        candleSeries1.GetHorizAxis.Labels.Angle = 90
        Dim tmpOpen As Double = r.Next(1000)
        Dim tmpClose As Double
        Dim count As Integer = 0
        Dim dt As DateTime = DateTime.Parse("07/02/2003")
        Dim ts As TimeSpan = TimeSpan.FromDays(1)
        Dim t As Integer = 0
        Do While (t < 13)
            tmpOpen = (tmpOpen + (r.Next(100) - 50))
            tmpClose = ((tmpOpen - r.Next(100)) + 50)
            If ((dt.DayOfWeek <> DayOfWeek.Saturday) And (dt.DayOfWeek <> DayOfWeek.Sunday)) Then
                count = count + 1
                candleSeries1.Add(count, tmpOpen, (tmpOpen + r.Next(10)), (tmpClose - r.Next(10)), tmpClose)
            End If
            dt = dt.Add(ts)
            t = (t + 1)
        Loop
        candleSeries1.Labels = labels
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
        Me.candleSeries1 = New Steema.TeeChart.Styles.Candle
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(466, 63)
        Me.textBox1.Text = "When using Candle series with intraday data (default), the bottom axis automatically shows time labels.  But, when adding Candle points that have ""weekends"", it's necessary some code to display day / month labels correctly, without showing the weekend days."
        ' 
        ' panel1
        ' 
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
        ' tChart1.Header
        ' 
        Me.tChart1.Header.Lines = New String() {"tChart1"}
        Me.tChart1.Header.Visible = False
        ' 
        ' tChart1.Legend
        ' 
        Me.tChart1.Legend.Alignment = Steema.TeeChart.LegendAlignments.Top
        Me.tChart1.Legend.Visible = False
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
        Me.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(220, System.Byte), CType(220, System.Byte), CType(226, System.Byte))
        Me.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.tChart1.Panel.Brush.Gradient.Visible = True
        ' 
        ' tChart1.Panel.Gradient
        ' 
        Me.tChart1.Panel.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(220, System.Byte), CType(220, System.Byte), CType(226, System.Byte))
        Me.tChart1.Panel.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.tChart1.Panel.Gradient.Visible = True
        Me.tChart1.Series.Add(Me.candleSeries1)
        Me.tChart1.Size = New System.Drawing.Size(466, 189)
        ' 
        ' candleSeries1
        ' 
        ' 
        ' candleSeries1.Brush
        ' 
        Me.candleSeries1.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        Me.candleSeries1.CloseValues = Me.candleSeries1.YValues
        Me.candleSeries1.DateValues = Me.candleSeries1.XValues
        Me.candleSeries1.DownCloseColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(0, System.Byte), CType(128, System.Byte), CType(0, System.Byte))
        ' 
        ' candleSeries1.LinePen
        ' 
        Me.candleSeries1.LinePen.Color = System.Drawing.Color.FromArgb(CType(153, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
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
        Me.candleSeries1.Title = "candle1"
        Me.candleSeries1.UpCloseColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
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
        ' Candle_NoWeekends
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(466, 286)
        Me.Name = "Candle_NoWeekends"
        Me.ResumeLayout(False)
    End Sub 'New 
#End Region
End Class 'Candle_AxisLabels