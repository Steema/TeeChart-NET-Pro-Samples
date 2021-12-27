
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Text.RegularExpressions



Public Class Function_CCI
    Inherits Steema.TeeChart.Samples.BaseForm
    Private candle1 As Steema.TeeChart.Styles.Candle
    Private axis1 As Steema.TeeChart.Axis
    Private label1 As System.Windows.Forms.Label
    Private WithEvents numericUpDown1 As System.Windows.Forms.NumericUpDown
    Private label2 As System.Windows.Forms.Label
    Private WithEvents textBox2 As System.Windows.Forms.TextBox
    Private cciFunction1 As Steema.TeeChart.Functions.CCIFunction
    Private line1 As Steema.TeeChart.Styles.Line
    Private axis2 As Steema.TeeChart.Axis
    Private components As System.ComponentModel.IContainer = Nothing
    
    
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        
        candle1.FillSampleValues()
        numericUpDown1.Value = System.Convert.ToDecimal(cciFunction1.Period)
        textBox2.Text = cciFunction1.Constant.ToString()
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
        Me.label1 = New System.Windows.Forms.Label
        Me.numericUpDown1 = New System.Windows.Forms.NumericUpDown
        Me.label2 = New System.Windows.Forms.Label
        Me.textBox2 = New System.Windows.Forms.TextBox
        Me.cciFunction1 = New Steema.TeeChart.Functions.CCIFunction
        Me.line1 = New Steema.TeeChart.Styles.Line
        Me.axis2 = New Steema.TeeChart.Axis(Me.tChart1.Chart)
        Me.panel1.SuspendLayout()
        CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Text = "CCI function (Commodity Channel Index), is a financial indicator. " + vbCr + vbLf + "It is used to" + " identify cyclical turns in commodities."
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.textBox2)
        Me.panel1.Controls.Add(Me.label2)
        Me.panel1.Controls.Add(Me.numericUpDown1)
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
        Me.tChart1.Aspect.View3D = False
        ' 
        ' tChart1.Axes
        ' 
        Me.tChart1.Axes.Custom.Add(Me.axis1)
        Me.tChart1.Axes.Custom.Add(Me.axis2)
        ' 
        ' tChart1.Axes.Left
        ' 
        Me.tChart1.Axes.Left.Visible = False
        Me.tChart1.Cursor = System.Windows.Forms.Cursors.Default
        ' 
        ' tChart1.Header
        ' 
        Me.tChart1.Header.Lines = New String() {"CCI Function"}
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
        Me.tChart1.Panel.MarginLeft = 8
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
        Me.candle1.CustomVertAxis = Me.axis1
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
        Me.candle1.VertAxis = Steema.TeeChart.Styles.VerticalAxis.Custom
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
        Me.axis1.EndPosition = 49
        Me.axis1.Horizontal = False
        Me.axis1.OtherSide = False
        ' 
        ' label1
        ' 
        Me.label1.Location = New System.Drawing.Point(8, 8)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(128, 23)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Moving average period:"
        ' 
        ' numericUpDown1
        ' 
        Me.numericUpDown1.Location = New System.Drawing.Point(128, 8)
        Me.numericUpDown1.Name = "numericUpDown1"
        Me.numericUpDown1.Size = New System.Drawing.Size(96, 20)
        Me.numericUpDown1.TabIndex = 1
        ' 
        ' label2
        ' 
        Me.label2.Location = New System.Drawing.Point(240, 10)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(64, 23)
        Me.label2.TabIndex = 2
        Me.label2.Text = "Constant:"
        ' 
        ' textBox2
        ' 
        Me.textBox2.Location = New System.Drawing.Point(296, 8)
        Me.textBox2.Name = "textBox2"
        Me.textBox2.TabIndex = 3
        Me.textBox2.Text = ""
        ' 
        ' cciFunction1
        ' 
        Me.cciFunction1.Period = 20
        ' 
        ' line1
        ' 
        ' 
        ' line1.Brush
        ' 
        Me.line1.Brush.Color = System.Drawing.Color.Green
        Me.line1.CustomVertAxis = Me.axis2
        Me.line1.DataSource = Me.candle1
        Me.line1.Function = Me.cciFunction1
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
        Me.line1.Pointer.Brush.Color = System.Drawing.Color.Green
        Me.line1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.line1.Title = "line1"
        Me.line1.VertAxis = Steema.TeeChart.Styles.VerticalAxis.Custom
        ' 
        ' line1.XValues
        ' 
        Me.line1.XValues.DateTime = True
        Me.line1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' axis2
        ' 
        Me.axis2.Horizontal = False
        Me.axis2.OtherSide = False
        Me.axis2.StartPosition = 51
        ' 
        ' Function_CCI
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(440, 317)
        Me.Name = "Function_CCI"
        Me.panel1.ResumeLayout(False)
        CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub 'InitializeComponent 
#End Region


    Private Sub numericUpDown1_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles numericUpDown1.ValueChanged
        cciFunction1.Period = System.Convert.ToDouble(numericUpDown1.Value)
    End Sub 'numericUpDown1_ValueChanged


    Private Sub textBox2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles textBox2.TextChanged
        If Not Regex.IsMatch(textBox2.Text, "[^0-9.,]") And textBox2.Text <> "" Then
            Try
                cciFunction1.Constant = Convert.ToDouble(textBox2.Text)
				Catch
            Throw
            End Try
        End If
    End Sub
End Class 'Function_CCI 