
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports Steema.TeeChart.Functions



Public Class MACD_Function
    Inherits Steema.TeeChart.Samples.BaseForm
    Private candle1 As Steema.TeeChart.Styles.Candle
    Private axis1 As Steema.TeeChart.Axis
    Private line1 As Steema.TeeChart.Styles.Line
    Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
    Private groupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents numericUpDown1 As System.Windows.Forms.NumericUpDown
    Private WithEvents numericUpDown2 As System.Windows.Forms.NumericUpDown
    Private WithEvents numericUpDown3 As System.Windows.Forms.NumericUpDown
    Private WithEvents label1 As System.Windows.Forms.Label
    Private label2 As System.Windows.Forms.Label
    Private label3 As System.Windows.Forms.Label
    Private WithEvents checkBox2 As System.Windows.Forms.CheckBox
    Private WithEvents checkBox3 As System.Windows.Forms.CheckBox
    Private components As System.ComponentModel.IContainer = Nothing
    
    
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        
        candle1.FillSampleValues(200)
        line1.Function = New Steema.TeeChart.Functions.MACDFunction(tChart1.Chart)
        line1.CheckDataSource()
        
        numericUpDown1.Value = Convert.ToDecimal(CType(line1.Function, Steema.TeeChart.Functions.MACDFunction).Period)
        numericUpDown2.Value = Convert.ToDecimal(CType(line1.Function, Steema.TeeChart.Functions.MACDFunction).Period2)
        numericUpDown3.Value = Convert.ToDecimal(CType(line1.Function, Steema.TeeChart.Functions.MACDFunction).Period3)
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
        Me.candle1 = New Steema.TeeChart.Styles.Candle
        Me.axis1 = New Steema.TeeChart.Axis(Me.tChart1.Chart)
        Me.line1 = New Steema.TeeChart.Styles.Line
        Me.checkBox1 = New System.Windows.Forms.CheckBox
        Me.groupBox1 = New System.Windows.Forms.GroupBox
        Me.label3 = New System.Windows.Forms.Label
        Me.label2 = New System.Windows.Forms.Label
        Me.numericUpDown3 = New System.Windows.Forms.NumericUpDown
        Me.numericUpDown2 = New System.Windows.Forms.NumericUpDown
        Me.numericUpDown1 = New System.Windows.Forms.NumericUpDown
        Me.label1 = New System.Windows.Forms.Label
        Me.checkBox2 = New System.Windows.Forms.CheckBox
        Me.checkBox3 = New System.Windows.Forms.CheckBox
        Me.panel1.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        CType(Me.numericUpDown3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Text = "The MACD function (Moving Average Convergence Divergence) ," + vbCr + vbLf + "used in financial ch" + "arts. "
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.checkBox3)
        Me.panel1.Controls.Add(Me.checkBox2)
        Me.panel1.Controls.Add(Me.groupBox1)
        Me.panel1.Controls.Add(Me.checkBox1)
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
        Me.tChart1.Axes.Custom.Add(Me.axis1)
        ' 
        ' tChart1.Axes.Left
        ' 
        Me.tChart1.Axes.Left.EndPosition = 48
        ' 
        ' tChart1.Axes.Left.Title
        ' 
        Me.tChart1.Axes.Left.Title.Caption = "Candle"
        ' 
        ' tChart1.Axes.Left.Title.Font
        ' 
        ' 
        ' tChart1.Axes.Left.Title.Font.Brush
        ' 
        Me.tChart1.Axes.Left.Title.Font.Brush.Color = System.Drawing.Color.Navy
        ' 
        ' tChart1.Axes.Left.Title.Font.Shadow
        ' 
        ' 
        ' tChart1.Axes.Left.Title.Font.Shadow.Brush
        ' 
        Me.tChart1.Axes.Left.Title.Font.Shadow.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(0, System.Byte), CType(0, System.Byte), CType(192, System.Byte))
        Me.tChart1.Axes.Left.Title.Font.Shadow.Height = 0
        Me.tChart1.Axes.Left.Title.Font.Shadow.Width = 0
        Me.tChart1.Axes.Left.Title.Lines = New String() {"Candle"}
        Me.tChart1.Cursor = System.Windows.Forms.Cursors.Default
        ' 
        ' tChart1.Header
        ' 
        Me.tChart1.Header.Lines = New String() {"TeeChart"}
        Me.tChart1.Header.Visible = False
        ' 
        ' tChart1.Legend
        ' 
        Me.tChart1.Legend.Alignment = Steema.TeeChart.LegendAlignments.Bottom
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
        ' 
        ' candle1
        ' 
        ' 
        ' candle1.Brush
        ' 
        Me.candle1.Brush.Color = System.Drawing.Color.Red
        Me.candle1.CloseValues = Me.candle1.YValues
        Me.candle1.DateValues = Me.candle1.XValues
        Me.candle1.DownCloseColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(0, System.Byte))
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
        Me.candle1.Title = "Source"
        Me.candle1.UpCloseColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(0, System.Byte), CType(0, System.Byte), CType(255, System.Byte))
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
        Me.axis1.OtherSide = False
        Me.axis1.StartPosition = 52
        ' 
        ' axis1.Title
        ' 
        Me.axis1.Title.Angle = 90
        Me.axis1.Title.Caption = "MACD"
        ' 
        ' axis1.Title.Font
        ' 
        ' 
        ' axis1.Title.Font.Brush
        ' 
        Me.axis1.Title.Font.Brush.Color = System.Drawing.Color.Green
        Me.axis1.Title.Lines = New String() {"MACD"}
        ' 
        ' line1
        ' 
        ' 
        ' line1.Brush
        ' 
        Me.line1.Brush.Color = System.Drawing.Color.Green
        Me.line1.CustomVertAxis = Me.axis1
        Me.line1.DataSource = Me.candle1
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
        Me.line1.Title = "MACD"
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
        ' checkBox1
        ' 
        Me.checkBox1.Checked = True
        Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox1.Location = New System.Drawing.Point(8, 8)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(88, 24)
        Me.checkBox1.TabIndex = 0
        Me.checkBox1.Text = "Show MACD"
        ' 
        ' groupBox1
        ' 
        Me.groupBox1.Controls.Add(Me.label3)
        Me.groupBox1.Controls.Add(Me.label2)
        Me.groupBox1.Controls.Add(Me.numericUpDown3)
        Me.groupBox1.Controls.Add(Me.numericUpDown2)
        Me.groupBox1.Controls.Add(Me.numericUpDown1)
        Me.groupBox1.Controls.Add(Me.label1)
        Me.groupBox1.Location = New System.Drawing.Point(94, 1)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(189, 37)
        Me.groupBox1.TabIndex = 1
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Period"
        ' 
        ' label3
        ' 
        Me.label3.Location = New System.Drawing.Point(124, 16)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(14, 12)
        Me.label3.TabIndex = 4
        Me.label3.Text = "3:"
        ' 
        ' label2
        ' 
        Me.label2.Location = New System.Drawing.Point(62, 16)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(14, 12)
        Me.label2.TabIndex = 3
        Me.label2.Text = "2:"
        ' 
        ' numericUpDown3
        ' 
        Me.numericUpDown3.Location = New System.Drawing.Point(138, 13)
        Me.numericUpDown3.Name = "numericUpDown3"
        Me.numericUpDown3.Size = New System.Drawing.Size(44, 20)
        Me.numericUpDown3.TabIndex = 2
        ' 
        ' numericUpDown2
        ' 
        Me.numericUpDown2.Location = New System.Drawing.Point(77, 13)
        Me.numericUpDown2.Name = "numericUpDown2"
        Me.numericUpDown2.Size = New System.Drawing.Size(44, 20)
        Me.numericUpDown2.TabIndex = 1
        ' 
        ' numericUpDown1
        ' 
        Me.numericUpDown1.Location = New System.Drawing.Point(15, 13)
        Me.numericUpDown1.Name = "numericUpDown1"
        Me.numericUpDown1.Size = New System.Drawing.Size(44, 20)
        Me.numericUpDown1.TabIndex = 0
        ' 
        ' label1
        ' 
        Me.label1.Location = New System.Drawing.Point(3, 16)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(14, 12)
        Me.label1.TabIndex = 2
        Me.label1.Text = "1:"
        ' 
        ' checkBox2
        ' 
        Me.checkBox2.Checked = True
        Me.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox2.Location = New System.Drawing.Point(293, 4)
        Me.checkBox2.Name = "checkBox2"
        Me.checkBox2.Size = New System.Drawing.Size(136, 16)
        Me.checkBox2.TabIndex = 2
        Me.checkBox2.Text = "Show line MACD &Exp."
        ' 
        ' checkBox3
        ' 
        Me.checkBox3.Checked = True
        Me.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox3.Location = New System.Drawing.Point(293, 22)
        Me.checkBox3.Name = "checkBox3"
        Me.checkBox3.Size = New System.Drawing.Size(136, 16)
        Me.checkBox3.TabIndex = 3
        Me.checkBox3.Text = "Show &Histogram"
        ' 
        ' MACDFunction
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(440, 317)
        Me.Name = "MACDFunction"
        Me.panel1.ResumeLayout(False)
        Me.groupBox1.ResumeLayout(False)
        CType(Me.numericUpDown3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub 'InitializeComponent 
#End Region


    Private Sub checkBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox1.Click
        line1.Active = checkBox1.Checked
        CType(line1.Function, Steema.TeeChart.Functions.MACDFunction).MACDExp.Active = line1.Active
        CType(line1.Function, Steema.TeeChart.Functions.MACDFunction).Histogram.Active = line1.Active

        tChart1.Legend.Visible = checkBox1.Checked
        axis1.Visible = line1.Active
        If line1.Active Then
            tChart1.Axes.Left.EndPosition = 50
        Else
            tChart1.Axes.Left.EndPosition = 100
        End If
    End Sub 'checkBox1_Click


    Private Sub label1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles label1.Click
    End Sub 'label1_Click



    Private Sub numericUpDown1_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles numericUpDown1.ValueChanged
        CType(line1.Function, Steema.TeeChart.Functions.MACDFunction).Period = Convert.ToDouble(numericUpDown1.Value)
    End Sub 'numericUpDown1_ValueChanged


    Private Sub numericUpDown2_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles numericUpDown2.ValueChanged
        CType(line1.Function, Steema.TeeChart.Functions.MACDFunction).Period2 = Convert.ToDouble(numericUpDown2.Value)
    End Sub 'numericUpDown2_ValueChanged


    Private Sub numericUpDown3_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles numericUpDown3.ValueChanged
        CType(line1.Function, Steema.TeeChart.Functions.MACDFunction).Period3 = Convert.ToDouble(numericUpDown3.Value)
    End Sub 'numericUpDown3_ValueChanged


    Private Sub checkBox2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox2.Click
        CType(line1.Function, Steema.TeeChart.Functions.MACDFunction).MACDExp.Active = checkBox2.Checked
    End Sub 'checkBox2_Click


    Private Sub checkBox3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox3.Click
        CType(line1.Function, Steema.TeeChart.Functions.MACDFunction).Histogram.Active = checkBox3.Checked
    End Sub 'checkBox3_Click
End Class 'MACD_Function
