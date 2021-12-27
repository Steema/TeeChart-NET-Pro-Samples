
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms


Public Class Function_Compression
    Inherits Steema.TeeChart.Samples.BaseForm
    Private label1 As System.Windows.Forms.Label
    Private comboBox1 As System.Windows.Forms.ComboBox
    Private label2 As System.Windows.Forms.Label
    Private comboBox2 As System.Windows.Forms.ComboBox
    Private candle1 As Steema.TeeChart.Styles.Candle
    Private compressOHLC1 As Steema.TeeChart.Functions.CompressOHLC
    Private candle2 As Steema.TeeChart.Styles.Candle
    Private components As System.ComponentModel.IContainer = Nothing
    
    Public Sub New() ' This call is required by the Windows Form Designer.
        InitializeComponent()

        candle1.FillSampleValues(500)
        candle2.Visible = False
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
        Me.label1 = New System.Windows.Forms.Label
        Me.comboBox1 = New System.Windows.Forms.ComboBox
        Me.label2 = New System.Windows.Forms.Label
        Me.comboBox2 = New System.Windows.Forms.ComboBox
        Me.candle1 = New Steema.TeeChart.Styles.Candle
        Me.compressOHLC1 = New Steema.TeeChart.Functions.CompressOHLC
        Me.candle2 = New Steema.TeeChart.Styles.Candle
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Text = "Compression function calculates high and low values for a group of points. " + vbCr + vbLf + "Resu" + "lts are plotted using a Candle series. " + vbCr + vbLf + vbCr + vbLf + "Suitable for displaying Candle OHLC d" + "ata ""weekly"", ""monthly"", etc."
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.comboBox2)
        Me.panel1.Controls.Add(Me.label2)
        Me.panel1.Controls.Add(Me.comboBox1)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Name = "panel1"
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
        ' 
        ' tChart1.Legend
        ' 
        Me.tChart1.Legend.Visible = False
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Brush
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.tChart1.Series.Add(Me.candle1)
        Me.tChart1.Series.Add(Me.candle2)
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
        ' label1
        ' 
        Me.label1.Location = New System.Drawing.Point(8, 8)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(112, 23)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Compression period:"
        ' 
        ' comboBox1
        ' 
        Me.comboBox1.Items.AddRange(New Object() {"Daily", "Weekly", "Monthly", "Bi-monthly", "Quarterly", "Yearly"})
        Me.comboBox1.Location = New System.Drawing.Point(120, 8)
        Me.comboBox1.Name = "comboBox1"
        Me.comboBox1.Size = New System.Drawing.Size(104, 21)
        Me.comboBox1.TabIndex = 1
        Me.comboBox1.Text = "Daily"
        AddHandler Me.comboBox1.SelectedIndexChanged, AddressOf Me.comboBox1_SelectedIndexChanged
        ' 
        ' label2
        ' 
        Me.label2.Location = New System.Drawing.Point(246, 10)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(42, 23)
        Me.label2.TabIndex = 2
        Me.label2.Text = "View:"
        ' 
        ' comboBox2
        ' 
        Me.comboBox2.Items.AddRange(New Object() {"CandleBar", "CandleStick", "Line", "OpenClose"})
        Me.comboBox2.Location = New System.Drawing.Point(287, 8)
        Me.comboBox2.Name = "comboBox2"
        Me.comboBox2.Size = New System.Drawing.Size(107, 21)
        Me.comboBox2.TabIndex = 3
        Me.comboBox2.Text = "CandleStick"
        AddHandler Me.comboBox2.SelectedIndexChanged, AddressOf Me.comboBox2_SelectedIndexChanged
        ' 
        ' candle1
        ' 
        ' 
        ' candle1.Brush
        ' 
        Me.candle1.Brush.Color = System.Drawing.Color.Red
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
        Me.candle1.Pointer.Brush.Color = System.Drawing.Color.Red
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
        ' compressOHLC1
        ' 
        Me.compressOHLC1.Compress = Steema.TeeChart.Functions.CompressionPeriod.ocWeek
        ' 
        ' candle2
        ' 
        ' 
        ' candle2.Brush
        ' 
        Me.candle2.Brush.Color = System.Drawing.Color.Green
        Me.candle2.CloseValues = Me.candle2.YValues
        Me.candle2.DataSource = Me.candle1
        Me.candle2.DateValues = Me.candle2.XValues
        Me.candle2.Function = Me.compressOHLC1
        ' 
        ' candle2.Marks
        ' 
        ' 
        ' candle2.Marks.Symbol
        ' 
        ' 
        ' candle2.Marks.Symbol.Shadow
        ' 
        Me.candle2.Marks.Symbol.Shadow.Height = 1
        Me.candle2.Marks.Symbol.Shadow.Visible = True
        Me.candle2.Marks.Symbol.Shadow.Width = 1
        ' 
        ' candle2.Pointer
        ' 
        ' 
        ' candle2.Pointer.Brush
        ' 
        Me.candle2.Pointer.Brush.Color = System.Drawing.Color.Green
        Me.candle2.Pointer.Draw3D = False
        Me.candle2.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.candle2.Title = "candle2"
        ' 
        ' candle2.XValues
        ' 
        Me.candle2.XValues.DateTime = True
        Me.candle2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' Function_CompressOHLC
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(440, 317)
        Me.Name = "Function_CompressOHLC"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub 'New 
#End Region


    Private Sub comboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        candle1.Visible = False
        candle2.Visible = True

        Select Case comboBox1.SelectedIndex
            Case 0
                compressOHLC1.Compress = Steema.TeeChart.Functions.CompressionPeriod.ocDay
            Case 1
                compressOHLC1.Compress = Steema.TeeChart.Functions.CompressionPeriod.ocWeek
            Case 2
                compressOHLC1.Compress = Steema.TeeChart.Functions.CompressionPeriod.ocMonth
            Case 3
                compressOHLC1.Compress = Steema.TeeChart.Functions.CompressionPeriod.ocBiMonth
            Case 4
                compressOHLC1.Compress = Steema.TeeChart.Functions.CompressionPeriod.ocQuarter
            Case 5
                compressOHLC1.Compress = Steema.TeeChart.Functions.CompressionPeriod.ocYear
        End Select
    End Sub 'comboBox1_SelectedIndexChanged



    Private Sub comboBox2_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Select Case comboBox2.SelectedIndex
            Case 0
                candle1.Style = Steema.TeeChart.Styles.CandleStyles.CandleBar
            Case 1
                candle1.Style = Steema.TeeChart.Styles.CandleStyles.CandleStick
            Case 2
                candle1.Style = Steema.TeeChart.Styles.CandleStyles.Line
            Case 3
                candle1.Style = Steema.TeeChart.Styles.CandleStyles.OpenClose
        End Select
        candle2.Style = candle1.Style
    End Sub 'comboBox2_SelectedIndexChanged
End Class 'Function_Compression