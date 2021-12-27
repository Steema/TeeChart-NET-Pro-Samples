
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing

Imports System.Windows.Forms




Public Class Bar_StackGroup
    Inherits Samples.BaseForm
    Private label1 As System.Windows.Forms.Label
    Private WithEvents comboBox1 As System.Windows.Forms.ComboBox
    Private barSeries1 As Steema.TeeChart.Styles.Bar
    Private barSeries2 As Steema.TeeChart.Styles.Bar
    Private barSeries3 As Steema.TeeChart.Styles.Bar
    Private barSeries4 As Steema.TeeChart.Styles.Bar
    Private barSeries5 As Steema.TeeChart.Styles.Bar
    Private label2 As System.Windows.Forms.Label
    Private gridBand1 As Steema.TeeChart.Tools.GridBand
    Private components As System.ComponentModel.IContainer = Nothing
    
    
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        

        For Each s As Steema.TeeChart.Styles.Series In tChart1.Series
            s.FillSampleValues(5)
        Next s
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
        Me.label1 = New System.Windows.Forms.Label
        Me.comboBox1 = New System.Windows.Forms.ComboBox
        Me.barSeries1 = New Steema.TeeChart.Styles.Bar
        Me.barSeries2 = New Steema.TeeChart.Styles.Bar
        Me.barSeries3 = New Steema.TeeChart.Styles.Bar
        Me.barSeries4 = New Steema.TeeChart.Styles.Bar
        Me.barSeries5 = New Steema.TeeChart.Styles.Bar
        Me.label2 = New System.Windows.Forms.Label
        Me.gridBand1 = New Steema.TeeChart.Tools.GridBand
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(466, 96)
        Me.textBox1.Text = "Stacked Bar and Horiz. Bar series can be grouped. " + vbCr + vbLf + "The StackGroup property defines the ""group"". There is no limit on how many groups exist." + vbCr + vbLf + vbCr + vbLf + "barSeries1.MultiBar = Steema.TeeChart.Multibars.Stacked" + vbCr + vbLf + "barSeries1.StackGroup = 0   " + vbCr + vbLf + "barSeries2.StackGroup = 1  "
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.label2)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Controls.Add(Me.comboBox1)
        Me.panel1.Location = New System.Drawing.Point(0, 96)
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
        Me.tChart1.Header.Lines = New String() {"tChart1"}
        ' 
        ' tChart1.Legend
        ' 
        ' 
        ' tChart1.Legend.Brush
        ' 
        Me.tChart1.Legend.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(244, System.Byte), CType(244, System.Byte), CType(255, System.Byte))
        ' 
        ' tChart1.Legend.Pen
        ' 
        Me.tChart1.Legend.Pen.Visible = False
        ' 
        ' tChart1.Legend.Shadow
        ' 
        Me.tChart1.Legend.Shadow.Visible = False
        ' 
        ' tChart1.Legend.Symbol
        ' 
        Me.tChart1.Legend.Symbol.Continous = True
        ' 
        ' tChart1.Legend.Symbol.Pen
        ' 
        Me.tChart1.Legend.Symbol.Pen.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(0, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        Me.tChart1.Legend.Symbol.Pen.Style = System.Drawing.Drawing2D.DashStyle.Dash
        Me.tChart1.Location = New System.Drawing.Point(0, 129)
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
        Me.tChart1.Series.Add(Me.barSeries4)
        Me.tChart1.Series.Add(Me.barSeries5)
        Me.tChart1.Size = New System.Drawing.Size(466, 157)
        Me.tChart1.Tools.Add(Me.gridBand1)
        ' 
        ' tChart1.Walls
        ' 
        ' 
        ' tChart1.Walls.Back
        ' 
        ' 
        ' tChart1.Walls.Back.Pen
        ' 
        Me.tChart1.Walls.Back.Pen.Visible = False
        ' 
        ' tChart1.Walls.Bottom
        ' 
        ' 
        ' tChart1.Walls.Bottom.Pen
        ' 
        Me.tChart1.Walls.Bottom.Pen.Visible = False
        Me.tChart1.Walls.Bottom.Size = 6
        ' 
        ' tChart1.Walls.Left
        ' 
        ' 
        ' tChart1.Walls.Left.Pen
        ' 
        Me.tChart1.Walls.Left.Pen.Visible = False
        Me.tChart1.Walls.Left.Size = 5
        ' 
        ' label1
        ' 
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(20, 8)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(57, 16)
        Me.label1.TabIndex = 0
        Me.label1.Text = "&Stack has "
        Me.label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        ' 
        ' comboBox1
        ' 
        Me.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboBox1.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.comboBox1.Location = New System.Drawing.Point(80, 6)
        Me.comboBox1.Name = "comboBox1"
        Me.comboBox1.Size = New System.Drawing.Size(47, 21)
        Me.comboBox1.TabIndex = 1
        ' 
        ' barSeries1
        ' 
        ' 
        ' barSeries1.Brush
        ' 
        Me.barSeries1.Brush.Color = System.Drawing.Color.FromArgb(CType(178, System.Byte), CType(255, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
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
        Me.barSeries1.Pen.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(128, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
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
        Me.barSeries2.Brush.Color = System.Drawing.Color.FromArgb(CType(178, System.Byte), CType(0, System.Byte), CType(128, System.Byte), CType(0, System.Byte))
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
        Me.barSeries3.Brush.Color = System.Drawing.Color.FromArgb(CType(178, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(0, System.Byte))
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
        ' barSeries4
        ' 
        ' 
        ' barSeries4.Brush
        ' 
        Me.barSeries4.Brush.Color = System.Drawing.Color.FromArgb(CType(178, System.Byte), CType(0, System.Byte), CType(0, System.Byte), CType(255, System.Byte))
        ' 
        ' barSeries4.Marks
        ' 
        ' 
        ' barSeries4.Marks.Symbol
        ' 
        ' 
        ' barSeries4.Marks.Symbol.Shadow
        ' 
        Me.barSeries4.Marks.Symbol.Shadow.Height = 1
        Me.barSeries4.Marks.Symbol.Shadow.Visible = True
        Me.barSeries4.Marks.Symbol.Shadow.Width = 1
        Me.barSeries4.Marks.Visible = False
        Me.barSeries4.MultiBar = Steema.TeeChart.Styles.MultiBars.Stacked
        ' 
        ' barSeries4.Pen
        ' 
        Me.barSeries4.Pen.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(0, System.Byte), CType(0, System.Byte), CType(64, System.Byte))
        Me.barSeries4.StackGroup = 1
        Me.barSeries4.Title = "barSeries4"
        ' 
        ' barSeries4.XValues
        ' 
        Me.barSeries4.XValues.DataMember = "X"
        Me.barSeries4.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' barSeries4.YValues
        ' 
        Me.barSeries4.YValues.DataMember = "Bar"
        ' 
        ' barSeries5
        ' 
        ' 
        ' barSeries5.Brush
        ' 
        Me.barSeries5.Brush.Color = System.Drawing.Color.FromArgb(CType(178, System.Byte), CType(255, System.Byte), CType(128, System.Byte), CType(0, System.Byte))
        ' 
        ' barSeries5.Marks
        ' 
        ' 
        ' barSeries5.Marks.Symbol
        ' 
        ' 
        ' barSeries5.Marks.Symbol.Shadow
        ' 
        Me.barSeries5.Marks.Symbol.Shadow.Height = 1
        Me.barSeries5.Marks.Symbol.Shadow.Visible = True
        Me.barSeries5.Marks.Symbol.Shadow.Width = 1
        Me.barSeries5.Marks.Visible = False
        Me.barSeries5.MultiBar = Steema.TeeChart.Styles.MultiBars.Stacked
        ' 
        ' barSeries5.Pen
        ' 
        Me.barSeries5.Pen.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(128, System.Byte), CType(128, System.Byte), CType(128, System.Byte))
        Me.barSeries5.StackGroup = 1
        Me.barSeries5.Title = "barSeries5"
        ' 
        ' barSeries5.XValues
        ' 
        Me.barSeries5.XValues.DataMember = "X"
        Me.barSeries5.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' barSeries5.YValues
        ' 
        Me.barSeries5.YValues.DataMember = "Bar"
        ' 
        ' label2
        ' 
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(133, 8)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(34, 16)
        Me.label2.TabIndex = 2
        Me.label2.Text = "series"
        Me.label2.UseMnemonic = False
        ' 
        ' gridBand1
        ' 
        Me.gridBand1.Axis = Me.tChart1.Axes.Left
        ' 
        ' gridBand1.Band1
        ' 
        Me.gridBand1.Band1.Color = System.Drawing.Color.FromArgb(CType(25, System.Byte), CType(0, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        ' 
        ' gridBand1.Band2
        ' 
        Me.gridBand1.Band2.Color = System.Drawing.Color.FromArgb(CType(102, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(192, System.Byte))
        ' 
        ' Bar_GroupStack
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(466, 286)
        Me.Name = "Bar_GroupStack"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub 'InitializeComponent 
#End Region


    Private Sub Bar_GroupStack_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.comboBox1.SelectedIndex = 2
    End Sub 'Bar_GroupStack_Load


    Private Sub comboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboBox1.SelectedIndexChanged
        Dim t As Integer
        For t = 0 To Fix(Me.comboBox1.SelectedIndex)
            CType(tChart1.Series(t), Steema.TeeChart.Styles.Bar).StackGroup = 0
        Next t

        For t = Fix(Me.comboBox1.SelectedIndex) + 1 To tChart1.Series.Count - 1
            CType(tChart1.Series(t), Steema.TeeChart.Styles.Bar).StackGroup = 1
        Next t

    End Sub 'comboBox1_SelectedIndexChanged
End Class 'Bar_StackGroup
