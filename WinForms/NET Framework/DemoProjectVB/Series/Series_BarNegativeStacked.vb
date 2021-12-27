
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing

Imports System.Windows.Forms




Public Class Series_BarNegativeStacked
    Inherits Samples.BaseForm
    Private barSeries1 As Steema.TeeChart.Styles.Bar
    Private barSeries2 As Steema.TeeChart.Styles.Bar
    Private barSeries3 As Steema.TeeChart.Styles.Bar
    Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
    Private gridBand1 As Steema.TeeChart.Tools.GridBand
    Private components As System.ComponentModel.IContainer = Nothing
    
    
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        
        Me.barSeries1.Add(New Integer(4) {23, - 56, 42, 9, - 8})
        Me.barSeries2.Add(New Integer(4) {32, - 16, 9, 39, - 28})
        Me.barSeries3.Add(New Integer(4) {12, - 21, 14, 22, - 13})
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
        Me.barSeries2 = New Steema.TeeChart.Styles.Bar
        Me.barSeries3 = New Steema.TeeChart.Styles.Bar
        Me.checkBox1 = New System.Windows.Forms.CheckBox
        Me.gridBand1 = New Steema.TeeChart.Tools.GridBand
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(466, 63)
        Me.textBox1.Text = "Bar and Horizontal bar series can display multiple stacked with a mix of positive" + " and negative values."
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.checkBox1)
        Me.panel1.Location = New System.Drawing.Point(0, 63)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(466, 33)
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
        Me.tChart1.Header.Lines = New String() {"Negative and positive", "stacked bars"}
        Me.tChart1.Location = New System.Drawing.Point(0, 96)
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Brush
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.tChart1.Series.Add(Me.barSeries1)
        Me.tChart1.Series.Add(Me.barSeries2)
        Me.tChart1.Series.Add(Me.barSeries3)
        Me.tChart1.Size = New System.Drawing.Size(466, 190)
        Me.tChart1.Tools.Add(Me.gridBand1)
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
        Me.barSeries1.Marks.Visible = False
        Me.barSeries1.MultiBar = Steema.TeeChart.Styles.MultiBars.Stacked
        ' 
        ' barSeries1.Pen
        ' 
        Me.barSeries1.Pen.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(192, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        Me.barSeries1.Title = "barSeries1"
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
        ' barSeries2
        ' 
        ' 
        ' barSeries2.Brush
        ' 
        Me.barSeries2.Brush.Color = System.Drawing.Color.Green
        ' 
        ' barSeries2.Marks
        ' 
        ' 
        ' barSeries2.Marks.Symbol
        ' 
        ' 
        ' barSeries2.Marks.Symbol.Shadow
        ' 
        Me.barSeries2.Marks.Symbol.Shadow.Height = 1
        Me.barSeries2.Marks.Symbol.Shadow.Visible = True
        Me.barSeries2.Marks.Symbol.Shadow.Width = 1
        Me.barSeries2.Marks.Visible = False
        Me.barSeries2.MultiBar = Steema.TeeChart.Styles.MultiBars.Stacked
        ' 
        ' barSeries2.Pen
        ' 
        Me.barSeries2.Pen.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(0, System.Byte), CType(64, System.Byte), CType(0, System.Byte))
        Me.barSeries2.Title = "barSeries2"
        ' 
        ' barSeries2.XValues
        ' 
        Me.barSeries2.XValues.DataMember = "X"
        Me.barSeries2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' barSeries2.YValues
        ' 
        Me.barSeries2.YValues.DataMember = "Bar"
        ' 
        ' barSeries3
        ' 
        ' 
        ' barSeries3.Brush
        ' 
        Me.barSeries3.Brush.Color = System.Drawing.Color.Yellow
        ' 
        ' barSeries3.Marks
        ' 
        ' 
        ' barSeries3.Marks.Symbol
        ' 
        ' 
        ' barSeries3.Marks.Symbol.Shadow
        ' 
        Me.barSeries3.Marks.Symbol.Shadow.Height = 1
        Me.barSeries3.Marks.Symbol.Shadow.Visible = True
        Me.barSeries3.Marks.Symbol.Shadow.Width = 1
        Me.barSeries3.Marks.Visible = False
        Me.barSeries3.MultiBar = Steema.TeeChart.Styles.MultiBars.Stacked
        ' 
        ' barSeries3.Pen
        ' 
        Me.barSeries3.Pen.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(128, System.Byte), CType(128, System.Byte), CType(0, System.Byte))
        Me.barSeries3.Title = "barSeries3"
        ' 
        ' barSeries3.XValues
        ' 
        Me.barSeries3.XValues.DataMember = "X"
        Me.barSeries3.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' barSeries3.YValues
        ' 
        Me.barSeries3.YValues.DataMember = "Bar"
        ' 
        ' checkBox1
        ' 
        Me.checkBox1.Checked = True
        Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox1.Location = New System.Drawing.Point(16, 8)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(47, 21)
        Me.checkBox1.TabIndex = 0
        Me.checkBox1.Text = "&3D"
        ' 
        ' gridBand1
        ' 
        Me.gridBand1.Axis = Me.tChart1.Axes.Left
        ' 
        ' gridBand1.Band1
        ' 
        Me.gridBand1.Band1.Color = System.Drawing.Color.FromArgb(CType(76, System.Byte), CType(128, System.Byte), CType(128, System.Byte), CType(64, System.Byte))
        ' 
        ' gridBand1.Band2
        ' 
        Me.gridBand1.Band2.Color = System.Drawing.Color.FromArgb(CType(76, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        ' 
        ' Bar_NegativeStacked
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(466, 286)
        Me.Name = "Bar_NegativeStacked"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub 'InitializeComponent 
#End Region


    Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox1.CheckedChanged
        Me.tChart1.Aspect.View3D = Me.checkBox1.Checked
    End Sub 'checkBox1_CheckedChanged
End Class 'Series_BarNegativeStacked
