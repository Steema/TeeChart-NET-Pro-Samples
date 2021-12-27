
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing

Imports System.Windows.Forms




Public Class MomentumDiv_Function
    Inherits Samples.BaseForm
    Private lineSeries1 As Steema.TeeChart.Styles.Line
    Private momentumDivision1 As Steema.TeeChart.Functions.MomentumDivision
    Private lineSeries2 As Steema.TeeChart.Styles.Line
    Private label1 As System.Windows.Forms.Label
    Private WithEvents numericUpDown1 As System.Windows.Forms.NumericUpDown
    Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
    Private colorLine1 As Steema.TeeChart.Tools.ColorLine
    Private axis1 As Steema.TeeChart.Axis
    Private components As System.ComponentModel.IContainer = Nothing
    
    
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        
        Me.lineSeries1.FillSampleValues(50)
        Me.lineSeries2.CheckDataSource()
        ' set the correct position for the blue line...
        Me.colorLine1.Value = Me.lineSeries1.YValues.Minimum
        ' function is = 100 * Value / (Previous 10th value)
        Me.momentumDivision1.Period = 10
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
        Me.lineSeries1 = New Steema.TeeChart.Styles.Line
        Me.momentumDivision1 = New Steema.TeeChart.Functions.MomentumDivision
        Me.lineSeries2 = New Steema.TeeChart.Styles.Line
        Me.axis1 = New Steema.TeeChart.Axis(Me.tChart1.Chart)
        Me.label1 = New System.Windows.Forms.Label
        Me.numericUpDown1 = New System.Windows.Forms.NumericUpDown
        Me.checkBox1 = New System.Windows.Forms.CheckBox
        Me.colorLine1 = New Steema.TeeChart.Tools.ColorLine
        Me.panel1.SuspendLayout()
        CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(425, 64)
        Me.textBox1.Text = "The Momentum Division function calculates the ratio of a point value compared to " + "the previous N point value." + vbCr + vbLf + vbCr + vbLf + "The formula is :   Momentum = 100 * Value / Previ" + "ousValue"
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.checkBox1)
        Me.panel1.Controls.Add(Me.numericUpDown1)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Location = New System.Drawing.Point(0, 64)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(425, 37)
        ' 
        ' tChart1
        ' 
        ' 
        ' tChart1.Aspect
        ' 
        Me.tChart1.Aspect.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality
        Me.tChart1.Aspect.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        ' 
        ' tChart1.Axes
        ' 
        Me.tChart1.Axes.Custom.Add(Me.axis1)
        ' 
        ' tChart1.Axes.Left
        ' 
        Me.tChart1.Axes.Left.EndPosition = 80
        Me.tChart1.Axes.Left.LogarithmicBase = 2
        ' 
        ' tChart1.Header
        ' 
        Me.tChart1.Header.Lines = New String() {"Momentum Div. function"}
        Me.tChart1.Location = New System.Drawing.Point(0, 101)
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
        Me.tChart1.Size = New System.Drawing.Size(425, 169)
        Me.tChart1.Tools.Add(Me.colorLine1)
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
        ' momentumDivision1
        ' 
        Me.momentumDivision1.Period = 1
        ' 
        ' lineSeries2
        ' 
        ' 
        ' lineSeries2.Brush
        ' 
        Me.lineSeries2.Brush.Color = System.Drawing.Color.Green
        Me.lineSeries2.CustomVertAxis = Me.axis1
        Me.lineSeries2.DataSource = Me.lineSeries1
        Me.lineSeries2.Function = Me.momentumDivision1
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
        Me.lineSeries2.VertAxis = Steema.TeeChart.Styles.VerticalAxis.Custom
        ' 
        ' lineSeries2.XValues
        ' 
        Me.lineSeries2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' axis1
        ' 
        Me.axis1.Horizontal = False
        Me.axis1.LogarithmicBase = 2
        Me.axis1.OtherSide = False
        Me.axis1.StartPosition = 90
        Me.axis1.TickOnLabelsOnly = False
        ' 
        ' axis1.Title
        ' 
        Me.axis1.Title.Angle = 90
        Me.axis1.Title.Caption = "Mom. div."
        Me.axis1.Title.Lines = New String() {"Mom. div."}
        ' 
        ' label1
        ' 
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(18, 10)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(40, 16)
        Me.label1.TabIndex = 0
        Me.label1.Text = "&Period:"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        ' 
        ' numericUpDown1
        ' 
        Me.numericUpDown1.Location = New System.Drawing.Point(64, 8)
        Me.numericUpDown1.Name = "numericUpDown1"
        Me.numericUpDown1.Size = New System.Drawing.Size(48, 20)
        Me.numericUpDown1.TabIndex = 1
        Me.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numericUpDown1.Value = New System.Decimal(New Integer() {10, 0, 0, 0})
        ' 
        ' checkBox1
        ' 
        Me.checkBox1.Checked = True
        Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox1.Location = New System.Drawing.Point(160, 8)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(117, 20)
        Me.checkBox1.TabIndex = 2
        Me.checkBox1.Text = "&Show momentum"
        ' 
        ' colorLine1
        ' 
        Me.colorLine1.Axis = Me.tChart1.Axes.Left
        ' 
        ' Function_MomentumDiv
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(425, 270)
        Me.Name = "Function_MomentumDiv"
        Me.panel1.ResumeLayout(False)
        CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub 'InitializeComponent 
#End Region


    Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox1.CheckedChanged
        ' show / hide the momentum series
        Me.lineSeries2.Active = Me.checkBox1.Checked

        ' re-position the axis
        If Me.lineSeries2.Active Then
            Me.tChart1.Axes.Left.EndPosition = 80
        Else
            Me.tChart1.Axes.Left.EndPosition = 100
        End If
        ' show / hide the custom right axis
        Me.tChart1.Axes.Custom(0).Visible = Me.lineSeries2.Active
        ' show / hide the blue color line
        Me.colorLine1.Active = Me.lineSeries2.Active
    End Sub 'checkBox1_CheckedChanged


    Private Sub numericUpDown1_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles numericUpDown1.ValueChanged
        Me.momentumDivision1.Period = Fix(Me.numericUpDown1.Value)
    End Sub 'numericUpDown1_ValueChanged


    Private Sub numericUpDown1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles numericUpDown1.TextChanged
        Me.momentumDivision1.Period = Fix(Me.numericUpDown1.Value)
    End Sub 'numericUpDown1_TextChanged
End Class 'MomentumDiv_Function
