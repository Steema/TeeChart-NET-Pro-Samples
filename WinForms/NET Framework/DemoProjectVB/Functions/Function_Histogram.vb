
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing

Imports System.Windows.Forms



Public Class Function_Histogram
    Inherits Samples.BaseNoChart

    Private tChart1 As TChart
    Private tChart2 As TChart
    Private histogram1 As Steema.TeeChart.Styles.Histogram
    Private histogramFunction1 As Steema.TeeChart.Functions.HistogramFunction
    Private checkBox1 As CheckBox
    Private numericUpDown1 As NumericUpDown
    Private label1 As Label
    Private button1 As Button
    Private line1 As Steema.TeeChart.Styles.Line

    '/ <summary>
    '/ Required designer variable.
    '/ </summary>
    Private components As System.ComponentModel.IContainer = Nothing


    Public Sub New() ' This call is required by the Windows Form Designer.
        InitializeComponent()
        line1.FillSampleValues(500)
        'connect line to histogram series
        histogram1.DataSource = line1
        histogram1.RefreshSeries()
    End Sub


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

#Region "Windows Form Designer generated code"

    '/ <summary>
    '/ Required method for Designer support - do not modify
    '/ the contents of this method with the code editor.
    '/ </summary>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Function_Histogram))
        Me.tChart1 = New Steema.TeeChart.TChart
        Me.line1 = New Steema.TeeChart.Styles.Line
        Me.tChart2 = New Steema.TeeChart.TChart
        Me.histogram1 = New Steema.TeeChart.Styles.Histogram
        Me.histogramFunction1 = New Steema.TeeChart.Functions.HistogramFunction
        Me.label1 = New System.Windows.Forms.Label
        Me.numericUpDown1 = New System.Windows.Forms.NumericUpDown
        Me.checkBox1 = New System.Windows.Forms.CheckBox
        Me.button1 = New System.Windows.Forms.Button
        Me.panel1.SuspendLayout()
        Me.panel2.SuspendLayout()
        CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Size = New System.Drawing.Size(540, 62)
        Me.textBox1.Text = ("The HistogramFunction does exactly what it\'s name suggests: It creates a histogra" + "m from single series X or Y values.")
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.button1)
        Me.panel1.Controls.Add(Me.checkBox1)
        Me.panel1.Controls.Add(Me.numericUpDown1)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Size = New System.Drawing.Size(540, 42)
        ' 
        ' panel2
        ' 
        Me.panel2.Controls.Add(Me.tChart2)
        Me.panel2.Controls.Add(Me.tChart1)
        Me.panel2.Size = New System.Drawing.Size(540, 230)
        ' 
        ' tChart1
        ' 
        Me.tChart1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ' 
        ' 
        ' 
        Me.tChart1.Aspect.View3D = False
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Bottom.Grid.Color = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Bottom.Ticks.Length = 2
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Bottom.TicksInner.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Depth.Grid.Color = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Depth.MinorGrid.Visible = True
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Depth.Ticks.Length = 2
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Depth.TicksInner.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.DepthTop.Grid.Color = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        ' 
        ' 
        ' 
        Me.tChart1.Axes.DepthTop.MinorGrid.Visible = True
        ' 
        ' 
        ' 
        Me.tChart1.Axes.DepthTop.Ticks.Length = 2
        ' 
        ' 
        ' 
        Me.tChart1.Axes.DepthTop.TicksInner.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Left.Grid.Color = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Left.Ticks.Length = 2
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Left.TicksInner.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Right.Grid.Color = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Right.MinorGrid.Visible = True
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Right.Ticks.Length = 2
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Right.TicksInner.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Top.Grid.Color = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Top.MinorGrid.Visible = True
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Top.Ticks.Length = 2
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Top.TicksInner.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        ' 
        ' 
        ' 
        Me.tChart1.Header.Lines = New String() {"Data"}
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Legend.DividingLines.Visible = True
        Me.tChart1.Legend.Visible = False
        Me.tChart1.Location = New System.Drawing.Point(3, 6)
        Me.tChart1.Name = "tChart1"
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Panel.Pen.Visible = True
        Me.tChart1.Series.Add(Me.line1)
        Me.tChart1.Size = New System.Drawing.Size(276, 212)
        Me.tChart1.TabIndex = 0
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Walls.Right.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        ' 
        ' line1
        ' 
        ' 
        ' 
        ' 
        Me.line1.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.line1.ColorEach = False
        ' 
        ' 
        ' 
        Me.line1.LinePen.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.line1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None
        Me.line1.Marks.Callout.ArrowHeadSize = 8
        ' 
        ' 
        ' 
        Me.line1.Marks.Callout.Brush.Color = System.Drawing.Color.Black
        Me.line1.Marks.Callout.Distance = 0
        Me.line1.Marks.Callout.Draw3D = False
        Me.line1.Marks.Callout.Length = 10
        Me.line1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        ' 
        ' 
        ' 
        Me.line1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.line1.Title = "line1"
        ' 
        ' 
        ' 
        Me.line1.XValues.DataMember = "X"
        Me.line1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' 
        ' 
        Me.line1.YValues.DataMember = "Y"
        ' 
        ' tChart2
        ' 
        Me.tChart2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ' 
        ' 
        ' 
        Me.tChart2.Aspect.View3D = False
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart2.Axes.Bottom.AxisPen.Visible = False
        ' 
        ' 
        ' 
        Me.tChart2.Axes.Bottom.Grid.Color = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        ' 
        ' 
        ' 
        Me.tChart2.Axes.Bottom.Ticks.Length = 2
        Me.tChart2.Axes.Bottom.Ticks.Visible = False
        ' 
        ' 
        ' 
        Me.tChart2.Axes.Bottom.TicksInner.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart2.Axes.Depth.Grid.Color = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        ' 
        ' 
        ' 
        Me.tChart2.Axes.Depth.MinorGrid.Visible = True
        ' 
        ' 
        ' 
        Me.tChart2.Axes.Depth.Ticks.Length = 2
        ' 
        ' 
        ' 
        Me.tChart2.Axes.Depth.TicksInner.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart2.Axes.DepthTop.Grid.Color = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        ' 
        ' 
        ' 
        Me.tChart2.Axes.DepthTop.MinorGrid.Visible = True
        ' 
        ' 
        ' 
        Me.tChart2.Axes.DepthTop.Ticks.Length = 2
        ' 
        ' 
        ' 
        Me.tChart2.Axes.DepthTop.TicksInner.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart2.Axes.Left.Grid.Color = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tChart2.Axes.Left.Increment = 1
        ' 
        ' 
        ' 
        Me.tChart2.Axes.Left.Ticks.Length = 2
        ' 
        ' 
        ' 
        Me.tChart2.Axes.Left.TicksInner.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart2.Axes.Right.Grid.Color = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        ' 
        ' 
        ' 
        Me.tChart2.Axes.Right.MinorGrid.Visible = True
        ' 
        ' 
        ' 
        Me.tChart2.Axes.Right.Ticks.Length = 2
        ' 
        ' 
        ' 
        Me.tChart2.Axes.Right.TicksInner.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart2.Axes.Top.Grid.Color = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        ' 
        ' 
        ' 
        Me.tChart2.Axes.Top.MinorGrid.Visible = True
        ' 
        ' 
        ' 
        Me.tChart2.Axes.Top.Ticks.Length = 2
        ' 
        ' 
        ' 
        Me.tChart2.Axes.Top.TicksInner.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        ' 
        ' 
        ' 
        Me.tChart2.Header.Lines = New String() {"Histogram"}
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart2.Legend.DividingLines.Visible = True
        Me.tChart2.Legend.Visible = False
        Me.tChart2.Location = New System.Drawing.Point(285, 6)
        Me.tChart2.Name = "tChart2"
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart2.Panel.Pen.Visible = True
        Me.tChart2.Series.Add(Me.histogram1)
        Me.tChart2.Size = New System.Drawing.Size(255, 212)
        Me.tChart2.TabIndex = 1
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart2.Walls.Right.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        ' 
        ' histogram1
        ' 
        ' 
        ' 
        ' 
        Me.histogram1.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.histogram1.ColorEach = False
        Me.histogram1.Function = Me.histogramFunction1
        ' 
        ' 
        ' 
        Me.histogram1.LinePen.Color = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.histogram1.LinePen.Visible = False
        ' 
        ' 
        ' 
        Me.histogram1.LinesPen.Color = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.histogram1.LinesPen.Visible = False
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.histogram1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None
        Me.histogram1.Marks.Callout.ArrowHeadSize = 8
        ' 
        ' 
        ' 
        Me.histogram1.Marks.Callout.Brush.Color = System.Drawing.Color.Black
        Me.histogram1.Marks.Callout.Distance = 0
        Me.histogram1.Marks.Callout.Draw3D = False
        Me.histogram1.Marks.Callout.Length = 10
        Me.histogram1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.histogram1.Title = "histogram1"
        ' 
        ' 
        ' 
        Me.histogram1.XValues.DataMember = "X"
        Me.histogram1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' 
        ' 
        Me.histogram1.YValues.DataMember = "Y"
        ' 
        ' histogramFunction1
        ' 
        Me.histogramFunction1.Cumulative = False
        ' 
        ' label1
        ' 
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(12, 14)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(78, 13)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Number of bins"
        ' 
        ' numericUpDown1
        ' 
        Me.numericUpDown1.Location = New System.Drawing.Point(96, 12)
        Me.numericUpDown1.Name = "numericUpDown1"
        Me.numericUpDown1.Size = New System.Drawing.Size(52, 20)
        Me.numericUpDown1.TabIndex = 1
        Me.numericUpDown1.Value = New Decimal(New Integer() {20, 0, 0, 0})
        AddHandler numericUpDown1.ValueChanged, AddressOf Me.numericUpDown1_ValueChanged
        ' 
        ' checkBox1
        '
#If VS2005 Then
        Me.checkBox1.AutoSize = True
#End If
        Me.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox1.Location = New System.Drawing.Point(170, 13)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(123, 17)
        Me.checkBox1.TabIndex = 2
        Me.checkBox1.Text = "Cumulative histogram"
#If VS2005 Then
        Me.checkBox1.UseVisualStyleBackColor = True
#End If
        AddHandler checkBox1.CheckedChanged, AddressOf Me.checkBox1_CheckedChanged
        ' 
        ' button1
        ' 
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.Location = New System.Drawing.Point(317, 9)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(129, 23)
        Me.button1.TabIndex = 3
        Me.button1.Text = "Recreate data"
#If VS2005 Then
        Me.button1.UseVisualStyleBackColor = True
#End If
        AddHandler button1.Click, AddressOf Me.button1_Click
        ' 
        ' Function_Histogram
        ' 
        Me.ClientSize = New System.Drawing.Size(540, 334)
        Me.Name = "Function_Histogram"
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.panel2.ResumeLayout(False)
        CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub numericUpDown1_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)

        histogramFunction1.NumBins = CType(numericUpDown1.Value, Integer)
        histogramFunction1.Recalculate()
    End Sub

    Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)

        histogramFunction1.Cumulative = checkBox1.Checked
        If (histogramFunction1.Cumulative) Then
            tChart2.Header.Text = "Cumulative Histogram"
        Else
            tChart2.Header.Text = "Histogram"
        End If
       
        histogramFunction1.Recalculate()
    End Sub

    Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs)

        line1.FillSampleValues(500)
        histogramFunction1.Recalculate()
    End Sub

End Class

