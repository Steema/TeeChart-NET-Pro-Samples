
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms


Public Class Function_CurveFitting
    Inherits Steema.TeeChart.Samples.BaseForm
    Private fastLine1 As Steema.TeeChart.Styles.FastLine
    Private fastLine2 As Steema.TeeChart.Styles.FastLine
    Private polyFitting1 As Steema.TeeChart.Functions.PolyFitting
    Private fastLine3 As Steema.TeeChart.Styles.FastLine
    Private polyFitting2 As Steema.TeeChart.Functions.PolyFitting
    Private checkBox1 As System.Windows.Forms.CheckBox
    Private label1 As System.Windows.Forms.Label
    Private numericUpDown1 As System.Windows.Forms.NumericUpDown
    Private label2 As System.Windows.Forms.Label
    Private numericUpDown2 As System.Windows.Forms.NumericUpDown
    Private timer1 As System.Windows.Forms.Timer
    Private gridBand1 As Steema.TeeChart.Tools.GridBand
    Private components As System.ComponentModel.IContainer = Nothing
    
    Public Sub New() ' This call is required by the Windows Form Designer.
        InitializeComponent()

        fastLine1.FillSampleValues(100)
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
        Me.components = New System.ComponentModel.Container
        Me.fastLine1 = New Steema.TeeChart.Styles.FastLine
        Me.fastLine2 = New Steema.TeeChart.Styles.FastLine
        Me.polyFitting1 = New Steema.TeeChart.Functions.PolyFitting
        Me.fastLine3 = New Steema.TeeChart.Styles.FastLine
        Me.polyFitting2 = New Steema.TeeChart.Functions.PolyFitting
        Me.checkBox1 = New System.Windows.Forms.CheckBox
        Me.label1 = New System.Windows.Forms.Label
        Me.numericUpDown1 = New System.Windows.Forms.NumericUpDown
        Me.label2 = New System.Windows.Forms.Label
        Me.numericUpDown2 = New System.Windows.Forms.NumericUpDown
        Me.timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.gridBand1 = New Steema.TeeChart.Tools.GridBand
        Me.panel1.SuspendLayout()
        CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(464, 73)
        Me.textBox1.Text = "Polynomial curvefitting function calculates the polynomial factors that best matc" + "hes the source data. The degree of the polynomial is configurable (from 2 to 20)" + "."
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.numericUpDown2)
        Me.panel1.Controls.Add(Me.label2)
        Me.panel1.Controls.Add(Me.numericUpDown1)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Controls.Add(Me.checkBox1)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(464, 47)
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
        Me.tChart1.Header.Lines = New String() {"Polynomial fitting"}
        Me.tChart1.Location = New System.Drawing.Point(0, 120)
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Brush
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(224, System.Byte), CType(224, System.Byte), CType(224, System.Byte))
        Me.tChart1.Series.Add(Me.fastLine1)
        Me.tChart1.Series.Add(Me.fastLine2)
        Me.tChart1.Series.Add(Me.fastLine3)
        Me.tChart1.Size = New System.Drawing.Size(464, 213)
        Me.tChart1.Tools.Add(Me.gridBand1)
        ' 
        ' fastLine1
        ' 
        ' 
        ' fastLine1.LinePen
        ' 
        Me.fastLine1.LinePen.Color = System.Drawing.Color.FromArgb(CType(255, System.Byte), CType(255, System.Byte), CType(204, System.Byte))
        ' 
        ' fastLine1.Marks
        ' 
        ' 
        ' fastLine1.Marks.Symbol
        ' 
        ' 
        ' fastLine1.Marks.Symbol.Shadow
        ' 
        Me.fastLine1.Marks.Symbol.Shadow.Height = 1
        Me.fastLine1.Marks.Symbol.Shadow.Visible = True
        Me.fastLine1.Marks.Symbol.Shadow.Width = 1
        Me.fastLine1.Title = "Data"
        ' 
        ' fastLine1.XValues
        ' 
        Me.fastLine1.XValues.DataMember = "X"
        Me.fastLine1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' fastLine1.YValues
        ' 
        Me.fastLine1.YValues.DataMember = "Y"
        ' 
        ' fastLine2
        ' 
        Me.fastLine2.DataSource = Me.fastLine1
        Me.fastLine2.Function = Me.polyFitting1
        ' 
        ' fastLine2.LinePen
        ' 
        Me.fastLine2.LinePen.Color = System.Drawing.Color.FromArgb(CType(204, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        ' 
        ' fastLine2.Marks
        ' 
        ' 
        ' fastLine2.Marks.Symbol
        ' 
        ' 
        ' fastLine2.Marks.Symbol.Shadow
        ' 
        Me.fastLine2.Marks.Symbol.Shadow.Height = 1
        Me.fastLine2.Marks.Symbol.Shadow.Visible = True
        Me.fastLine2.Marks.Symbol.Shadow.Width = 1
        Me.fastLine2.Title = "Curve 1"
        ' 
        ' fastLine2.XValues
        ' 
        Me.fastLine2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' polyFitting1
        ' 
        Me.polyFitting1.PolyDegree = 3
        ' 
        ' fastLine3
        ' 
        Me.fastLine3.DataSource = Me.fastLine1
        Me.fastLine3.Function = Me.polyFitting2
        ' 
        ' fastLine3.LinePen
        ' 
        Me.fastLine3.LinePen.Color = System.Drawing.Color.FromArgb(CType(255, System.Byte), CType(204, System.Byte), CType(204, System.Byte))
        ' 
        ' fastLine3.Marks
        ' 
        ' 
        ' fastLine3.Marks.Symbol
        ' 
        ' 
        ' fastLine3.Marks.Symbol.Shadow
        ' 
        Me.fastLine3.Marks.Symbol.Shadow.Height = 1
        Me.fastLine3.Marks.Symbol.Shadow.Visible = True
        Me.fastLine3.Marks.Symbol.Shadow.Width = 1
        Me.fastLine3.Title = "Curve 2"
        ' 
        ' fastLine3.XValues
        ' 
        Me.fastLine3.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' checkBox1
        ' 
        Me.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox1.Location = New System.Drawing.Point(16, 16)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(72, 24)
        Me.checkBox1.TabIndex = 0
        Me.checkBox1.Text = "Animate"
        AddHandler Me.checkBox1.CheckedChanged, AddressOf Me.checkBox1_CheckedChanged
        ' 
        ' label1
        ' 
        Me.label1.Location = New System.Drawing.Point(104, 16)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(80, 23)
        Me.label1.TabIndex = 1
        Me.label1.Text = "Poly 1 degree:"
        ' 
        ' numericUpDown1
        ' 
        Me.numericUpDown1.Location = New System.Drawing.Point(184, 16)
        Me.numericUpDown1.Maximum = New System.Decimal(New Integer() {20, 0, 0, 0})
        Me.numericUpDown1.Minimum = New System.Decimal(New Integer() {2, 0, 0, 0})
        Me.numericUpDown1.Name = "numericUpDown1"
        Me.numericUpDown1.Size = New System.Drawing.Size(40, 20)
        Me.numericUpDown1.TabIndex = 3
        Me.numericUpDown1.Value = New System.Decimal(New Integer() {3, 0, 0, 0})
        AddHandler Me.numericUpDown1.ValueChanged, AddressOf Me.numericUpDown1_ValueChanged
        ' 
        ' label2
        ' 
        Me.label2.Location = New System.Drawing.Point(240, 16)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(80, 23)
        Me.label2.TabIndex = 4
        Me.label2.Text = "Poly 2 degree:"
        ' 
        ' numericUpDown2
        ' 
        Me.numericUpDown2.Location = New System.Drawing.Point(320, 16)
        Me.numericUpDown2.Maximum = New System.Decimal(New Integer() {20, 0, 0, 0})
        Me.numericUpDown2.Minimum = New System.Decimal(New Integer() {2, 0, 0, 0})
        Me.numericUpDown2.Name = "numericUpDown2"
        Me.numericUpDown2.Size = New System.Drawing.Size(40, 20)
        Me.numericUpDown2.TabIndex = 5
        Me.numericUpDown2.Value = New System.Decimal(New Integer() {5, 0, 0, 0})
        AddHandler Me.numericUpDown2.ValueChanged, AddressOf Me.numericUpDown2_ValueChanged
        ' 
        ' timer1
        ' 
        Me.timer1.Interval = 10
        AddHandler Me.timer1.Tick, AddressOf Me.timer1_Tick
        ' 
        ' gridBand1
        ' 
        Me.gridBand1.Axis = Me.tChart1.Axes.Left
        ' 
        ' gridBand1.Band1
        ' 
        Me.gridBand1.Band1.Color = System.Drawing.Color.FromArgb(CType(127, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        ' 
        ' gridBand1.Band2
        ' 
        Me.gridBand1.Band2.Color = System.Drawing.Color.FromArgb(CType(127, System.Byte), CType(128, System.Byte), CType(128, System.Byte), CType(128, System.Byte))
        ' 
        ' Function_CurveFitting
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(464, 333)
        Me.Name = "Function_CurveFitting"
        Me.panel1.ResumeLayout(False)
        CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub 'New 
#End Region


    Private Sub numericUpDown2_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        polyFitting2.PolyDegree = Fix(numericUpDown2.Value)
    End Sub 'numericUpDown2_ValueChanged


    Private Sub numericUpDown1_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        polyFitting1.PolyDegree = Fix(numericUpDown1.Value)
    End Sub 'numericUpDown1_ValueChanged


    Private Sub timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs)
        timer1.Enabled = False
        Try
            fastLine1.Delete(0)
            Dim r As Random = New Random
            fastLine1.Add((fastLine1.XValues.Last + 1), (fastLine1.YValues.Last _
                            + (r.Next(100) - 50)))
            fastLine2.CheckDataSource()' <-- fill again the points
            fastLine3.CheckDataSource()' <-- fill again the points
        Finally
            timer1.Enabled = True
        End Try
    End Sub 'timer1_Tick

    Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        timer1.Enabled = checkBox1.Checked
    End Sub 'checkBox1_CheckedChanged
End Class 'Function_CurveFitting