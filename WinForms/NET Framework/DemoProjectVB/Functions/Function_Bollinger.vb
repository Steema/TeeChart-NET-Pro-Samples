
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms


Public Class Function_Bollinger
    Inherits Steema.TeeChart.Samples.BaseForm
    Private candle1 As Steema.TeeChart.Styles.Candle
    Private bollinger1 As Steema.TeeChart.Functions.Bollinger
    Private line1 As Steema.TeeChart.Styles.Line
    Private numericUpDown1 As System.Windows.Forms.NumericUpDown
    Private label1 As System.Windows.Forms.Label
    Private label2 As System.Windows.Forms.Label
    Private numericUpDown2 As System.Windows.Forms.NumericUpDown
    Private checkBox1 As System.Windows.Forms.CheckBox
    Private buttonColor1 As Steema.TeeChart.ButtonColor
    Private gridBand1 As Steema.TeeChart.Tools.GridBand
    Private components As System.ComponentModel.IContainer = Nothing
    
    Public Sub New() ' This call is required by the Windows Form Designer.
        InitializeComponent()

        candle1.FillSampleValues(400)
        bollinger1.Period = 50
        numericUpDown1.Value = 50
        bollinger1.Deviation = 2
        numericUpDown2.Value = 2
			
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
        Me.candle1 = New Steema.TeeChart.Styles.Candle
        Me.bollinger1 = New Steema.TeeChart.Functions.Bollinger
        Me.line1 = New Steema.TeeChart.Styles.Line
        Me.numericUpDown1 = New System.Windows.Forms.NumericUpDown
        Me.label1 = New System.Windows.Forms.Label
        Me.label2 = New System.Windows.Forms.Label
        Me.numericUpDown2 = New System.Windows.Forms.NumericUpDown
        Me.checkBox1 = New System.Windows.Forms.CheckBox
        Me.buttonColor1 = New Steema.TeeChart.ButtonColor
        Me.gridBand1 = New Steema.TeeChart.Tools.GridBand
        Me.panel1.SuspendLayout()
        CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Text = "Bollinger bands is a special function used as a financial indicator." + vbCr + vbLf + "It calculat" + "es and displays two lines, using a moving average " + vbCr + vbLf + "(exponential or not) and the" + " standard deviation."
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.buttonColor1)
        Me.panel1.Controls.Add(Me.checkBox1)
        Me.panel1.Controls.Add(Me.label2)
        Me.panel1.Controls.Add(Me.numericUpDown2)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Controls.Add(Me.numericUpDown1)
        Me.panel1.Name = "panel1"
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
        Me.tChart1.Header.Lines = New String() {"Financial TeeChart - Bollinger bands"}
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Brush
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.tChart1.Series.Add(Me.candle1)
        Me.tChart1.Series.Add(Me.line1)
        Me.tChart1.Tools.Add(Me.gridBand1)
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
        Me.candle1.Pointer.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(0, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        Me.candle1.Pointer.Draw3D = False
        Me.candle1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.candle1.Style = Steema.TeeChart.Styles.CandleStyles.CandleBar
        Me.candle1.Title = "Candle"
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
        ' bollinger1
        ' 
        Me.bollinger1.Deviation = 2
        Me.bollinger1.Period = 10
        ' 
        ' line1
        ' 
        ' 
        ' line1.Brush
        ' 
        Me.line1.Brush.Color = System.Drawing.Color.Green
        Me.line1.DataSource = Me.candle1
        Me.line1.Function = Me.bollinger1
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
        Me.line1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.line1.Title = "Bollinger"
        ' 
        ' line1.XValues
        ' 
        Me.line1.XValues.DateTime = True
        Me.line1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' numericUpDown1
        ' 
        Me.numericUpDown1.Location = New System.Drawing.Point(134, 12)
        Me.numericUpDown1.Name = "numericUpDown1"
        Me.numericUpDown1.Size = New System.Drawing.Size(50, 20)
        Me.numericUpDown1.TabIndex = 1
        AddHandler Me.numericUpDown1.ValueChanged, AddressOf Me.numericUpDown1_ValueChanged
        ' 
        ' label1
        ' 
        Me.label1.Location = New System.Drawing.Point(89, 14)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(47, 23)
        Me.label1.TabIndex = 2
        Me.label1.Text = "Period:"
        ' 
        ' label2
        ' 
        Me.label2.Location = New System.Drawing.Point(208, 15)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(56, 16)
        Me.label2.TabIndex = 4
        Me.label2.Text = "Deviation:"
        ' 
        ' numericUpDown2
        ' 
        Me.numericUpDown2.Location = New System.Drawing.Point(268, 12)
        Me.numericUpDown2.Name = "numericUpDown2"
        Me.numericUpDown2.Size = New System.Drawing.Size(50, 20)
        Me.numericUpDown2.TabIndex = 3
        AddHandler Me.numericUpDown2.ValueChanged, AddressOf Me.numericUpDown2_ValueChanged
        ' 
        ' checkBox1
        ' 
        Me.checkBox1.Checked = True
        Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox1.Location = New System.Drawing.Point(341, 10)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.TabIndex = 5
        Me.checkBox1.Text = "Exponential"
        AddHandler Me.checkBox1.Click, AddressOf Me.checkBox1_Click
        ' 
        ' buttonColor1
        ' 
        Me.buttonColor1.Color = System.Drawing.Color.Empty
        Me.buttonColor1.Location = New System.Drawing.Point(6, 9)
        Me.buttonColor1.Name = "buttonColor1"
        Me.buttonColor1.TabIndex = 6
        Me.buttonColor1.Text = "Color..."
        AddHandler Me.buttonColor1.Click, AddressOf Me.buttonColor1_Click
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
        ' BollingerFunction
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(440, 317)
        Me.Name = "BollingerFunction"
        AddHandler Me.Load, AddressOf Me.BollingerFunction_Load
        Me.panel1.ResumeLayout(False)
        CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub 'New 
#End Region



    Private Sub checkBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        bollinger1.Exponential = checkBox1.Checked
    End Sub 'checkBox1_Click


    Private Sub numericUpDown1_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        bollinger1.Period = Convert.ToDouble(numericUpDown1.Value)
    End Sub 'numericUpDown1_ValueChanged


    Private Sub numericUpDown2_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        bollinger1.Deviation = Convert.ToDouble(numericUpDown2.Value)
    End Sub 'numericUpDown2_ValueChanged


    Private Sub buttonColor1_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        line1.Color = buttonColor1.Color
        bollinger1.LowBandPen.Color = buttonColor1.Color
    End Sub 'buttonColor1_Click


    Private Sub BollingerFunction_Load(ByVal sender As Object, ByVal e As System.EventArgs)
        buttonColor1.Color = line1.Color
    End Sub 'BollingerFunction_Load
End Class 'Function_Bollinger