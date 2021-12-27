
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms



Public Class RSI_Function
    Inherits Steema.TeeChart.Samples.BaseForm
    Private WithEvents comboBox1 As System.Windows.Forms.ComboBox
    Private label1 As System.Windows.Forms.Label
    Private label2 As System.Windows.Forms.Label
    Private WithEvents numericUpDown1 As System.Windows.Forms.NumericUpDown
    Private candle1 As Steema.TeeChart.Styles.Candle
    Private axis1 As Steema.TeeChart.Axis
    Private rsiFunction1 As Steema.TeeChart.Functions.RSIFunction
    Private line1 As Steema.TeeChart.Styles.Line
    Private components As System.ComponentModel.IContainer = Nothing
    
    
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' TODO: Add any initialization after the InitializeComponent call
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
        Me.components = New System.ComponentModel.Container
        Me.comboBox1 = New System.Windows.Forms.ComboBox
        Me.label1 = New System.Windows.Forms.Label
        Me.label2 = New System.Windows.Forms.Label
        Me.numericUpDown1 = New System.Windows.Forms.NumericUpDown
        Me.candle1 = New Steema.TeeChart.Styles.Candle
        Me.axis1 = New Steema.TeeChart.Axis(Me.tChart1.Chart)
        Me.rsiFunction1 = New Steema.TeeChart.Functions.RSIFunction
        Me.line1 = New Steema.TeeChart.Styles.Line
        Me.panel1.SuspendLayout()
        CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Text = "The R.S.I. function (Relative Strength Index) offers two calculation methods." + vbCr + vbLf + "By default, it does the calculation using Open and Close values of the " + vbCr + vbLf + "datasource Candle series. The second method uses Close prices only." + vbCr + vbLf + vbCr + vbLf + "Example: rsiFunction1.Style=RSIStyle.Close   ( default is OpenClose )"
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.numericUpDown1)
        Me.panel1.Controls.Add(Me.label2)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Controls.Add(Me.comboBox1)
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
        ' tChart1.Axes
        ' 
        ' 
        ' tChart1.Axes.Bottom
        ' 
        ' 
        ' tChart1.Axes.Bottom.Labels
        ' 
        Me.tChart1.Axes.Bottom.Labels.Angle = 90
        Me.tChart1.Axes.Bottom.Labels.DateTimeFormat = "dd/MM/yyyy"
        Me.tChart1.Axes.Custom.Add(Me.axis1)
        ' 
        ' tChart1.Axes.Left
        ' 
        Me.tChart1.Axes.Left.EndPosition = 58
        ' 
        ' tChart1.Axes.Left.Title
        ' 
        Me.tChart1.Axes.Left.Title.Caption = "Stock Sample"
        ' 
        ' tChart1.Axes.Left.Title.Font
        ' 
        ' 
        ' tChart1.Axes.Left.Title.Font.Brush
        ' 
        Me.tChart1.Axes.Left.Title.Font.Brush.Color = System.Drawing.Color.Red
        Me.tChart1.Axes.Left.Title.Font.Name = "Verdana"
        Me.tChart1.Axes.Left.Title.Font.Size = 9
        Me.tChart1.Axes.Left.Title.Lines = New String() {"Stock Sample"}
        Me.tChart1.Cursor = System.Windows.Forms.Cursors.Default
        ' 
        ' tChart1.Header
        ' 
        Me.tChart1.Header.Lines = New String() {"TeeChart"}
        Me.tChart1.Header.Visible = False
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
        Me.tChart1.Panel.MarginRight = 12
        Me.tChart1.Series.Add(Me.candle1)
        Me.tChart1.Series.Add(Me.line1)
        ' 
        ' comboBox1
        ' 
        Me.comboBox1.Items.AddRange(New Object() {"Open and Close", "Close only"})
        Me.comboBox1.Location = New System.Drawing.Point(84, 10)
        Me.comboBox1.Name = "comboBox1"
        Me.comboBox1.Size = New System.Drawing.Size(121, 21)
        Me.comboBox1.TabIndex = 0
        ' 
        ' label1
        ' 
        Me.label1.Location = New System.Drawing.Point(8, 14)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(74, 13)
        Me.label1.TabIndex = 1
        Me.label1.Text = "Calc. Method:"
        ' 
        ' label2
        ' 
        Me.label2.Location = New System.Drawing.Point(256, 14)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(40, 15)
        Me.label2.TabIndex = 2
        Me.label2.Text = "Period:"
        ' 
        ' numericUpDown1
        ' 
        Me.numericUpDown1.Location = New System.Drawing.Point(298, 12)
        Me.numericUpDown1.Name = "numericUpDown1"
        Me.numericUpDown1.Size = New System.Drawing.Size(51, 20)
        Me.numericUpDown1.TabIndex = 3
        Me.numericUpDown1.Value = New System.Decimal(New Integer() {10, 0, 0, 0})
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
        ' axis1
        ' 
        Me.axis1.Horizontal = False
        Me.axis1.OtherSide = True
        Me.axis1.StartPosition = 60
        ' 
        ' axis1.Title
        ' 
        Me.axis1.Title.Angle = 90
        Me.axis1.Title.Caption = "R.S.I"
        ' 
        ' axis1.Title.Font
        ' 
        ' 
        ' axis1.Title.Font.Brush
        ' 
        Me.axis1.Title.Font.Brush.Color = System.Drawing.Color.Green
        Me.axis1.Title.Font.Name = "Verdana"
        Me.axis1.Title.Font.Size = 9
        Me.axis1.Title.Lines = New String() {"R.S.I"}
        Me.axis1.ZPosition = 0
        ' 
        ' rsiFunction1
        ' 
        Me.rsiFunction1.Period = 1
        ' 
        ' line1
        ' 
        ' 
        ' line1.Brush
        ' 
        Me.line1.Brush.Color = System.Drawing.Color.Green
        Me.line1.CustomVertAxis = Me.axis1
        Me.line1.DataSource = Me.candle1
        Me.line1.Function = Me.rsiFunction1
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
        Me.line1.Title = "line1"
        Me.line1.VertAxis = Steema.TeeChart.Styles.VerticalAxis.Custom
        ' 
        ' line1.XValues
        ' 
        Me.line1.XValues.DateTime = True
        Me.line1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' line1.YValues
        ' 
        Me.line1.YValues.DataMember = "Close"
        ' 
        ' RSIFunction
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(440, 317)
        Me.Name = "RSIFunction"
        Me.panel1.ResumeLayout(False)
        CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub 'InitializeComponent 
#End Region


    Private Sub RSIFunction_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.comboBox1.SelectedIndex = 0
        candle1.FillSampleValues(100)

        rsiFunction1.Period = 10 ' take 10 prices 
        rsiFunction1.Style = Steema.TeeChart.Functions.RSIStyle.OpenClose ' default calc method 
    End Sub 'RSIFunction_Load


    Private Sub tChart1_AllowScroll(ByVal a As Steema.TeeChart.Axis, ByVal e As Steema.TeeChart.AllowScrollEventArgs) Handles tChart1.AllowScroll
        e.AllowScroll = Not (a Is axis1)
    End Sub 'tChart1_AllowScroll


    Private Sub comboBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboBox1.Click
    End Sub 'comboBox1_Click



    Private Sub numericUpDown1_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles numericUpDown1.ValueChanged
        rsiFunction1.Period = Convert.ToDouble(numericUpDown1.Value)
    End Sub 'numericUpDown1_ValueChanged


    Private Sub comboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboBox1.SelectedIndexChanged
        rsiFunction1.Style = CType(Me.comboBox1.SelectedIndex, Steema.TeeChart.Functions.RSIStyle)
    End Sub 'comboBox1_SelectedIndexChanged
End Class 'RSI_Function
