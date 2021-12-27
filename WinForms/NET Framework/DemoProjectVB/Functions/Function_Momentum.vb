
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing

Imports System.Windows.Forms




Public Class Function_Momentum
    Inherits Samples.BaseForm
    Private lineSeries1 As Steema.TeeChart.Styles.Line
    Private WithEvents numericUpDown1 As System.Windows.Forms.NumericUpDown
    Private label1 As System.Windows.Forms.Label
    Private momentum1 As Steema.TeeChart.Functions.Momentum
    Private lineSeries2 As Steema.TeeChart.Styles.Line
    Private components As System.ComponentModel.IContainer = Nothing
    
    
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.lineSeries1.Pointer.Visible = True
        'Me.lineSeries2.Pointer.Visible = true
        Me.lineSeries1.FillSampleValues(30)
        'Me.lineSeries2.CheckDataSource()
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
        Me.lineSeries1 = New Steema.TeeChart.Styles.Line
        Me.numericUpDown1 = New System.Windows.Forms.NumericUpDown
        Me.label1 = New System.Windows.Forms.Label
        Me.momentum1 = New Steema.TeeChart.Functions.Momentum
        Me.lineSeries2 = New Steema.TeeChart.Styles.Line
        Me.panel1.SuspendLayout()
        CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(388, 55)
        Me.textBox1.TabIndex = 0
        Me.textBox1.Text = "The Momentum function calculates the difference between each point in the data so" + "urce and the ""n"" previous point value."
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Controls.Add(Me.numericUpDown1)
        Me.panel1.Location = New System.Drawing.Point(0, 55)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(388, 41)
        Me.panel1.TabIndex = 1
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
        Me.tChart1.Header.Lines = New String() {"Momentum function"}
        Me.tChart1.Location = New System.Drawing.Point(0, 96)
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Brush
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.tChart1.Series.Add(Me.lineSeries1)
        Me.tChart1.Series.Add(Me.lineSeries2)
        Me.tChart1.Size = New System.Drawing.Size(388, 159)
        Me.tChart1.TabIndex = 2
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
        ' lineSeries1
        ' 
        ' 
        ' lineSeries1.Brush
        ' 
        Me.lineSeries1.Brush.Color = System.Drawing.Color.Red
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
        Me.lineSeries1.Title = "Source"
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
        ' numericUpDown1
        ' 
        Me.numericUpDown1.Location = New System.Drawing.Point(56, 11)
        Me.numericUpDown1.Name = "numericUpDown1"
        Me.numericUpDown1.Size = New System.Drawing.Size(56, 20)
        Me.numericUpDown1.TabIndex = 1
        Me.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numericUpDown1.Value = New System.Decimal(New Integer() {10, 0, 0, 0})
        ' 
        ' label1
        ' 
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(12, 13)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(40, 16)
        Me.label1.TabIndex = 0
        Me.label1.Text = "&Period:"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        ' 
        ' momentum1
        ' 
        Me.momentum1.Period = 10
        ' 
        ' lineSeries2
        ' 
        ' 
        ' lineSeries2.Brush
        ' 
        Me.lineSeries2.Brush.Color = System.Drawing.Color.Green
        Me.lineSeries2.DataSource = Me.lineSeries1
        Me.lineSeries2.Function = Me.momentum1
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
        ' 
        ' lineSeries2.XValues
        ' 
        Me.lineSeries2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' Function_Momentum
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(388, 255)
        Me.Name = "Function_Momentum"
        Me.panel1.ResumeLayout(False)
        CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub 'InitializeComponent 
#End Region


    Private Sub numericUpDown1_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles numericUpDown1.ValueChanged
        Me.momentum1.Period = Fix(Me.numericUpDown1.Value)
    End Sub 'numericUpDown1_ValueChanged


    Private Sub numericUpDown1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles numericUpDown1.TextChanged
        Me.momentum1.Period = Fix(Me.numericUpDown1.Value)
    End Sub 'numericUpDown1_TextChanged
End Class 'Function_Momentum
