
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing

Imports System.Windows.Forms



Public Class Function_SAR
    Inherits Samples.BaseForm

    Private setting As Boolean = True

    Private candle1 As Steema.TeeChart.Styles.Candle
    Private line1 As Steema.TeeChart.Styles.Line
    Private sarFunction1 As Steema.TeeChart.Functions.SARFunction
    Private WithEvents textBox2 As TextBox
    Private label1 As Label
    '/ <summary>
    '/ Required designer variable.
    '/ </summary>
    Private components As System.ComponentModel.IContainer = Nothing


    Public Sub New() ' me call is required by the Windows Form Designer.
        InitializeComponent()
        candle1.FillSampleValues(10)
    End Sub


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

  Private Sub Function_SAR_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
    textBox2.Text = sarFunction1.AccelerationFactor.ToString("0.00")
    setting = False
  End Sub

  Private Sub textBox2_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles textBox2.TextChanged
    If Not setting Then
      sarFunction1.AccelerationFactor = Convert.ToDouble(textBox2.Text)
    End If
  End Sub

#Region "Windows Form Designer generated code"

  '/ <summary>
  '/ Required method for Designer support - do not modify
  '/ the contents of me method with the code editor.
  '/ </summary>
  Private Sub InitializeComponent()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Function_SAR))
    Me.candle1 = New Steema.TeeChart.Styles.Candle
    Me.line1 = New Steema.TeeChart.Styles.Line
    Me.sarFunction1 = New Steema.TeeChart.Functions.SARFunction
    Me.label1 = New System.Windows.Forms.Label
    Me.textBox2 = New System.Windows.Forms.TextBox
    Me.panel1.SuspendLayout()
    Me.chartContainer.SuspendLayout()
    Me.SuspendLayout()
    ' 
    ' textBox1
    ' 
    Me.textBox1.Text = resources.GetString("textBox1.Text")
    ' 
    ' panel1
    ' 
    Me.panel1.Controls.Add(Me.textBox2)
    Me.panel1.Controls.Add(Me.label1)
    ' 
    ' tChart1
    ' 
    ' 
    ' 
    ' 
    Me.tChart1.Aspect.ColorPaletteIndex = 0
    Me.tChart1.Aspect.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
    Me.tChart1.Aspect.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias
    Me.tChart1.Aspect.View3D = False
    ' 
    ' 
    ' 
    ' 
    ' 
    ' 
    ' 
    ' 
    ' 
    Me.tChart1.Legend.Title.Pen.Visible = False
    ' 
    ' 
    ' 
    ' 
    ' 
    ' 
    ' 
    ' 
    ' 
    Me.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(89, Byte), Integer))
    Me.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.tChart1.Panel.Brush.Gradient.Sigma = True
    Me.tChart1.Panel.Brush.Gradient.SigmaFocus = 1.0F
    Me.tChart1.Panel.Brush.Gradient.SigmaScale = 0.800000012F
    Me.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.tChart1.Series.Add(Me.candle1)
    Me.tChart1.Series.Add(Me.line1)
    Me.tChart1.Size = New System.Drawing.Size(440, 205)
    ' 
    ' candle1
    ' 
    ' 
    ' 
    ' 
    Me.candle1.Brush.Color = System.Drawing.Color.Red
    Me.candle1.CloseValues = Me.candle1.YValues
    Me.candle1.ColorEach = False
    Me.candle1.DateValues = Me.candle1.XValues
    ' 
    ' 
    ' 
    Me.candle1.HighLowPen.Color = System.Drawing.Color.Black
    ' 
    ' 
    ' 
    Me.candle1.LinePen.Color = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
    ' 
    ' 
    ' 
    ' 
    ' 
    ' 
    Me.candle1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None
    Me.candle1.Marks.Callout.ArrowHeadSize = 8
    ' 
    ' 
    ' 
    Me.candle1.Marks.Callout.Brush.Color = System.Drawing.Color.Black
    Me.candle1.Marks.Callout.Distance = 0
    Me.candle1.Marks.Callout.Draw3D = False
    Me.candle1.Marks.Callout.Length = 10
    Me.candle1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
    ' 
    ' 
    ' 
    Me.candle1.Pointer.Draw3D = False
    ' 
    ' 
    ' 
    Me.candle1.Pointer.Pen.Color = System.Drawing.Color.White
    Me.candle1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
    Me.candle1.Pointer.Visible = True
    Me.candle1.Title = "Data"
    ' 
    ' 
    ' 
    Me.candle1.XValues.DataMember = "Date"
    Me.candle1.XValues.DateTime = True
    Me.candle1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
    ' 
    ' 
    ' 
    Me.candle1.YValues.DataMember = "Close"
    ' 
    ' line1
    ' 
    ' 
    ' 
    ' 
    Me.line1.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))
    ' 
    ' 
    ' 
    Me.line1.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))
    Me.line1.Gradient.Visible = True
    Me.line1.ColorEach = False
    Me.line1.DataSource = Me.candle1
    Me.line1.Function = Me.sarFunction1
    ' 
    ' 
    ' 
    Me.line1.LinePen.Color = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(0, Byte), Integer))
    ' 
    ' 
    ' 
    ' 
    ' 
    ' 
    Me.line1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None
    Me.line1.Marks.Callout.ArrowHeadSize = 8
    ' 
    ' 
    ' 
    Me.line1.Marks.Callout.Brush.Color = System.Drawing.Color.Black
    Me.line1.Marks.Callout.Distance = 0
    Me.line1.Marks.Callout.Draw3D = False
    Me.line1.Marks.Callout.Length = 10
    Me.line1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
    Me.line1.Marks.Style = Steema.TeeChart.Styles.MarksStyles.Value
    Me.line1.Marks.Transparent = True
    Me.line1.Marks.Visible = True
    ' 
    ' 
    ' 
    Me.line1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
    Me.line1.Pointer.Visible = True
    Me.line1.Title = "SAR"
    ' 
    ' 
    ' 
    Me.line1.XValues.DateTime = True
    Me.line1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
    ' 
    ' 
    ' 
    Me.line1.YValues.DataMember = "Close"
    ' 
    ' sarFunction1
    ' 
    Me.sarFunction1.AccelerationFactor = 0.019999999552965164
    Me.sarFunction1.MaxStep = 0.30000001192092896
    ' 
    ' label1
    ' 
    Me.label1.AutoSize = True
    Me.label1.Location = New System.Drawing.Point(12, 13)
    Me.label1.Name = "label1"
    Me.label1.Size = New System.Drawing.Size(96, 13)
    Me.label1.TabIndex = 0
    Me.label1.Text = "Acceleration factor"
    ' 
    ' textBox2
    ' 
    Me.textBox2.Location = New System.Drawing.Point(114, 10)
    Me.textBox2.Name = "textBox2"
    Me.textBox2.Size = New System.Drawing.Size(100, 20)
    Me.textBox2.TabIndex = 1
    ' 
    ' Function_SAR
    ' 
    Me.ClientSize = New System.Drawing.Size(440, 317)
    Me.Name = "Function_SAR"
    Me.panel1.ResumeLayout(False)
    Me.panel1.PerformLayout()
    Me.chartContainer.ResumeLayout(False)
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

#End Region



End Class

