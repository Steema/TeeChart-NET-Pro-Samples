
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing

Imports System.Windows.Forms




Public Class Function_Average
    Inherits Samples.BaseForm
    Private barSeries1 As Steema.TeeChart.Styles.Bar
    Private average1 As Steema.TeeChart.Functions.Average
    Private lineSeries1 As Steema.TeeChart.Styles.Line
    Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
    Private high1 As Steema.TeeChart.Functions.High
    Private lineSeries2 As Steema.TeeChart.Styles.Line
    Private low1 As Steema.TeeChart.Functions.Low
    Private lineSeries3 As Steema.TeeChart.Styles.Line
    Private components As System.ComponentModel.IContainer = Nothing
    
    
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.barSeries1.FillSampleValues(8)
        CType(Me.average1.Series, Steema.TeeChart.Styles.Line).Pointer.Visible = True
        CType(Me.high1.Series, Steema.TeeChart.Styles.Line).Pointer.Visible = True
        CType(Me.low1.Series, Steema.TeeChart.Styles.Line).Pointer.Visible = True
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
        Me.barSeries1 = New Steema.TeeChart.Styles.Bar
        Me.average1 = New Steema.TeeChart.Functions.Average
        Me.lineSeries1 = New Steema.TeeChart.Styles.Line
        Me.checkBox1 = New System.Windows.Forms.CheckBox
        Me.high1 = New Steema.TeeChart.Functions.High
        Me.lineSeries2 = New Steema.TeeChart.Styles.Line
        Me.low1 = New Steema.TeeChart.Functions.Low
        Me.lineSeries3 = New Steema.TeeChart.Styles.Line
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(466, 104)
        Me.textBox1.Text = "+ The Average function calculates the sum of all points in the data source and divides the result by number of points. It can also be used to calculate averages by every ""n"" number of points." + vbCr + vbLf + "+ The High function calculates the greatest of all points in the data source. It can also be used to calculate the highest value by every ""n"" number of points." + vbCr + vbLf + "+ The Low function calculates the smallest of all points in the data source. It can also be used to calculate the lowest value by every ""n"" number of points."
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.checkBox1)
        Me.panel1.Location = New System.Drawing.Point(0, 104)
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
        ' tChart1.Header
        ' 
        Me.tChart1.Header.Lines = New String() {"Average function"}
        Me.tChart1.Location = New System.Drawing.Point(0, 138)
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Brush
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.tChart1.Series.Add(Me.barSeries1)
        Me.tChart1.Series.Add(Me.lineSeries1)
        Me.tChart1.Series.Add(Me.lineSeries2)
        Me.tChart1.Series.Add(Me.lineSeries3)
        Me.tChart1.Size = New System.Drawing.Size(466, 148)
        ' 
        ' barSeries1
        ' 
        ' 
        ' barSeries1.Brush
        ' 
        Me.barSeries1.Brush.Color = System.Drawing.Color.Red
        ' 
        ' barSeries1.Marks
        ' 
        ' 
        ' barSeries1.Marks.Symbol
        ' 
        ' 
        ' barSeries1.Marks.Symbol.Shadow
        ' 
        Me.barSeries1.Marks.Symbol.Shadow.Height = 1
        Me.barSeries1.Marks.Symbol.Shadow.Visible = True
        Me.barSeries1.Marks.Symbol.Shadow.Width = 1
        Me.barSeries1.Title = "Data"
        ' 
        ' barSeries1.XValues
        ' 
        Me.barSeries1.XValues.DataMember = "X"
        Me.barSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' barSeries1.YValues
        ' 
        Me.barSeries1.YValues.DataMember = "Bar"
        ' 
        ' lineSeries1
        ' 
        ' 
        ' lineSeries1.Brush
        ' 
        Me.lineSeries1.Brush.Color = System.Drawing.Color.Green
        Me.lineSeries1.DataSource = Me.barSeries1
        Me.lineSeries1.Function = Me.average1
        ' 
        ' lineSeries1.Marks
        ' 
        ' 
        ' lineSeries1.Marks.Brush
        ' 
        Me.lineSeries1.Marks.Brush.Color = System.Drawing.Color.FromArgb(CType(0, System.Byte), CType(128, System.Byte), CType(0, System.Byte))
        ' 
        ' lineSeries1.Marks.Font
        ' 
        ' 
        ' lineSeries1.Marks.Font.Brush
        ' 
        Me.lineSeries1.Marks.Font.Brush.Color = System.Drawing.Color.White
        Me.lineSeries1.Marks.Font.Size = 7
        ' 
        ' lineSeries1.Marks.Symbol
        ' 
        ' 
        ' lineSeries1.Marks.Symbol.Shadow
        ' 
        Me.lineSeries1.Marks.Symbol.Shadow.Height = 1
        Me.lineSeries1.Marks.Symbol.Shadow.Visible = True
        Me.lineSeries1.Marks.Symbol.Shadow.Width = 1
        Me.lineSeries1.Marks.Visible = True
        ' 
        ' lineSeries1.Pointer
        ' 
        ' 
        ' lineSeries1.Pointer.Brush
        ' 
        Me.lineSeries1.Pointer.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(0, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        Me.lineSeries1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.lineSeries1.Title = "Average"
        ' 
        ' lineSeries1.XValues
        ' 
        Me.lineSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' checkBox1
        ' 
        Me.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox1.Location = New System.Drawing.Point(16, 8)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(127, 21)
        Me.checkBox1.TabIndex = 1
        Me.checkBox1.Text = "&By every 2 points"
        ' 
        ' lineSeries2
        ' 
        ' 
        ' lineSeries2.Brush
        ' 
        Me.lineSeries2.Brush.Color = System.Drawing.Color.Yellow
        Me.lineSeries2.DataSource = Me.barSeries1
        Me.lineSeries2.Function = Me.high1
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
        Me.lineSeries2.Title = "High"
        ' 
        ' lineSeries2.XValues
        ' 
        Me.lineSeries2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' lineSeries3
        ' 
        ' 
        ' lineSeries3.Brush
        ' 
        Me.lineSeries3.Brush.Color = System.Drawing.Color.Blue
        Me.lineSeries3.DataSource = Me.barSeries1
        Me.lineSeries3.Function = Me.low1
        ' 
        ' lineSeries3.Marks
        ' 
        ' 
        ' lineSeries3.Marks.Symbol
        ' 
        ' 
        ' lineSeries3.Marks.Symbol.Shadow
        ' 
        Me.lineSeries3.Marks.Symbol.Shadow.Height = 1
        Me.lineSeries3.Marks.Symbol.Shadow.Visible = True
        Me.lineSeries3.Marks.Symbol.Shadow.Width = 1
        ' 
        ' lineSeries3.Pointer
        ' 
        ' 
        ' lineSeries3.Pointer.Brush
        ' 
        Me.lineSeries3.Pointer.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(0, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        Me.lineSeries3.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.lineSeries3.Title = "Low"
        ' 
        ' lineSeries3.XValues
        ' 
        Me.lineSeries3.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' Function_Average
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(466, 286)
        Me.Name = "Function_Average"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub 'InitializeComponent 
#End Region


    Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox1.CheckedChanged
        If Me.checkBox1.Checked Then
            Me.average1.Period = 2
            Me.high1.Period = 2
            Me.low1.Period = 2
        Else
            Me.average1.Period = 0 ' all points
            Me.high1.Period = 0 ' all points
            Me.low1.Period = 0 ' all points
        End If
    End Sub 'checkBox1_CheckedChanged
End Class 'Function_Average
