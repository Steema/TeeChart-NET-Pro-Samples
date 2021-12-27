
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing

Imports System.Windows.Forms




Public Class SeriesType_Bar
    Inherits Samples.BaseForm
    Private WithEvents comboBox1 As System.Windows.Forms.ComboBox
    Private label1 As System.Windows.Forms.Label
    Private label2 As System.Windows.Forms.Label
    Private WithEvents comboBox2 As System.Windows.Forms.ComboBox
    Private WithEvents button1 As System.Windows.Forms.Button
    Private bar1 As Steema.TeeChart.Styles.Bar
    Private bar2 As Steema.TeeChart.Styles.Bar
    Private bar3 As Steema.TeeChart.Styles.Bar
    Private gridBand1 As Steema.TeeChart.Tools.GridBand
    Private components As System.ComponentModel.IContainer = Nothing
    
    
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        
        bar1.FillSampleValues(6)
        bar2.FillSampleValues(6)
        bar3.FillSampleValues(6)
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
        Me.comboBox1 = New System.Windows.Forms.ComboBox
        Me.label1 = New System.Windows.Forms.Label
        Me.label2 = New System.Windows.Forms.Label
        Me.comboBox2 = New System.Windows.Forms.ComboBox
        Me.button1 = New System.Windows.Forms.Button
        Me.bar1 = New Steema.TeeChart.Styles.Bar
        Me.bar2 = New Steema.TeeChart.Styles.Bar
        Me.bar3 = New Steema.TeeChart.Styles.Bar
        Me.gridBand1 = New Steema.TeeChart.Tools.GridBand
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(466, 80)
        Me.textBox1.TabIndex = 0
        Me.textBox1.Text = "The Bar style allows single or multiple bars, with different layouts ( 3D, side-to-side, side-all, stacked, stacked 100% )." + vbCr + vbLf + vbCr + vbLf + "Options include 2D and 3D, color-each-bar, bar style, patterns, dark 3D, bottom origin, auto-mark positions, stacking groups, marks, border, etc."
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.button1)
        Me.panel1.Controls.Add(Me.comboBox2)
        Me.panel1.Controls.Add(Me.label2)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Controls.Add(Me.comboBox1)
        Me.panel1.Location = New System.Drawing.Point(0, 80)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(466, 40)
        Me.panel1.TabIndex = 1
        ' 
        ' tChart1
        ' 
        ' 
        ' tChart1.Aspect
        ' 
        Me.tChart1.Aspect.ColorPaletteIndex = -1
        Me.tChart1.Aspect.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality
        Me.tChart1.Aspect.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        ' 
        ' tChart1.Axes
        ' 
        ' 
        ' tChart1.Axes.Bottom
        ' 
        ' 
        ' tChart1.Axes.Bottom.Grid
        ' 
        Me.tChart1.Axes.Bottom.Grid.Color = System.Drawing.Color.Gray
        ' 
        ' tChart1.Axes.Bottom.Ticks
        ' 
        Me.tChart1.Axes.Bottom.Ticks.Length = 2
        ' 
        ' tChart1.Axes.Depth
        ' 
        ' 
        ' tChart1.Axes.Depth.Grid
        ' 
        Me.tChart1.Axes.Depth.Grid.Color = System.Drawing.Color.Gray
        ' 
        ' tChart1.Axes.Depth.Ticks
        ' 
        Me.tChart1.Axes.Depth.Ticks.Length = 2
        ' 
        ' tChart1.Axes.Left
        ' 
        ' 
        ' tChart1.Axes.Left.Grid
        ' 
        Me.tChart1.Axes.Left.Grid.Color = System.Drawing.Color.Gray
        ' 
        ' tChart1.Axes.Left.Ticks
        ' 
        Me.tChart1.Axes.Left.Ticks.Length = 2
        ' 
        ' tChart1.Axes.Right
        ' 
        ' 
        ' tChart1.Axes.Right.Grid
        ' 
        Me.tChart1.Axes.Right.Grid.Color = System.Drawing.Color.Gray
        ' 
        ' tChart1.Axes.Right.Ticks
        ' 
        Me.tChart1.Axes.Right.Ticks.Length = 2
        ' 
        ' tChart1.Axes.Top
        ' 
        ' 
        ' tChart1.Axes.Top.Grid
        ' 
        Me.tChart1.Axes.Top.Grid.Color = System.Drawing.Color.Gray
        ' 
        ' tChart1.Axes.Top.Ticks
        ' 
        Me.tChart1.Axes.Top.Ticks.Length = 2
        ' 
        ' tChart1.Header
        ' 
        Me.tChart1.Header.Lines = New String() {"TeeChart"}
        ' 
        ' tChart1.Legend
        ' 
        ' 
        ' tChart1.Legend.Shadow
        ' 
        ' 
        ' tChart1.Legend.Shadow.Brush
        ' 
        Me.tChart1.Legend.Shadow.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(0, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        Me.tChart1.Location = New System.Drawing.Point(0, 120)
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Brush
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        ' 
        ' tChart1.Panel.Gradient
        ' 
        Me.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.Yellow
        Me.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.Empty
        Me.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.White
        ' 
        ' tChart1.Panel.Gradient
        ' 
        Me.tChart1.Panel.Gradient.EndColor = System.Drawing.Color.Yellow
        Me.tChart1.Panel.Gradient.MiddleColor = System.Drawing.Color.Empty
        Me.tChart1.Panel.Gradient.StartColor = System.Drawing.Color.White
        ' 
        ' tChart1.Panel.Shadow
        ' 
        Me.tChart1.Panel.Shadow.Height = 0
        Me.tChart1.Panel.Shadow.Width = 0
        Me.tChart1.Series.Add(Me.bar1)
        Me.tChart1.Series.Add(Me.bar2)
        Me.tChart1.Series.Add(Me.bar3)
        Me.tChart1.Size = New System.Drawing.Size(466, 166)
        Me.tChart1.TabIndex = 2
        Me.tChart1.Tools.Add(Me.gridBand1)
        ' 
        ' tChart1.Walls
        ' 
        ' 
        ' tChart1.Walls.Right
        ' 
        ' 
        ' tChart1.Walls.Right.Brush
        ' 
        Me.tChart1.Walls.Right.Brush.Color = System.Drawing.Color.Silver
        ' 
        ' comboBox1
        ' 
        Me.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboBox1.Items.AddRange(New Object() {"3D", "Side-to-side", "Stacked", "Stacked 100%", "Side All", "Self Stacked"})
        Me.comboBox1.Location = New System.Drawing.Point(53, 8)
        Me.comboBox1.Name = "comboBox1"
        Me.comboBox1.Size = New System.Drawing.Size(94, 21)
        Me.comboBox1.TabIndex = 1
        ' 
        ' label1
        ' 
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(7, 10)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(44, 16)
        Me.label1.TabIndex = 0
        Me.label1.Text = "&Layout :"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        ' 
        ' label2
        ' 
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(160, 10)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(63, 16)
        Me.label2.TabIndex = 2
        Me.label2.Text = "&Style Bar 1:"
        Me.label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        ' 
        ' comboBox2
        ' 
        Me.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboBox2.Items.AddRange(New Object() {"Rectangle", "Pyramid", "Invert. Pyramid", "Cylinder", "Ellipse", "Arrow", "Rect. Gradient", "Cone"})
        Me.comboBox2.Location = New System.Drawing.Point(227, 8)
        Me.comboBox2.Name = "comboBox2"
        Me.comboBox2.Size = New System.Drawing.Size(86, 21)
        Me.comboBox2.TabIndex = 3
        ' 
        ' button1
        ' 
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.Location = New System.Drawing.Point(333, 7)
        Me.button1.Name = "button1"
        Me.button1.TabIndex = 4
        Me.button1.Text = "&Edit..."
        ' 
        ' bar1
        ' 
        ' 
        ' bar1.Brush
        ' 
        Me.bar1.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        ' 
        ' bar1.Marks
        ' 
        ' 
        ' bar1.Marks.Symbol
        ' 
        ' 
        ' bar1.Marks.Symbol.Shadow
        ' 
        Me.bar1.Marks.Symbol.Shadow.Height = 1
        Me.bar1.Marks.Symbol.Shadow.Visible = True
        Me.bar1.Marks.Symbol.Shadow.Width = 1
        ' 
        ' bar1.Pen
        ' 
        Me.bar1.Pen.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(153, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        Me.bar1.Title = "bar1"
        ' 
        ' bar1.XValues
        ' 
        Me.bar1.XValues.DataMember = "X"
        Me.bar1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' bar1.YValues
        ' 
        Me.bar1.YValues.DataMember = "Bar"
        ' 
        ' bar2
        ' 
        ' 
        ' bar2.Brush
        ' 
        Me.bar2.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(0, System.Byte), CType(128, System.Byte), CType(0, System.Byte))
        ' 
        ' bar2.Marks
        ' 
        ' 
        ' bar2.Marks.Symbol
        ' 
        ' 
        ' bar2.Marks.Symbol.Shadow
        ' 
        Me.bar2.Marks.Symbol.Shadow.Height = 1
        Me.bar2.Marks.Symbol.Shadow.Visible = True
        Me.bar2.Marks.Symbol.Shadow.Width = 1
        ' 
        ' bar2.Pen
        ' 
        Me.bar2.Pen.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(0, System.Byte), CType(77, System.Byte), CType(0, System.Byte))
        Me.bar2.Title = "bar2"
        ' 
        ' bar2.XValues
        ' 
        Me.bar2.XValues.DataMember = "X"
        Me.bar2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' bar2.YValues
        ' 
        Me.bar2.YValues.DataMember = "Bar"
        ' 
        ' bar3
        ' 
        ' 
        ' bar3.Brush
        ' 
        Me.bar3.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(0, System.Byte))
        ' 
        ' bar3.Marks
        ' 
        ' 
        ' bar3.Marks.Symbol
        ' 
        ' 
        ' bar3.Marks.Symbol.Shadow
        ' 
        Me.bar3.Marks.Symbol.Shadow.Height = 1
        Me.bar3.Marks.Symbol.Shadow.Visible = True
        Me.bar3.Marks.Symbol.Shadow.Width = 1
        ' 
        ' bar3.Pen
        ' 
        Me.bar3.Pen.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(153, System.Byte), CType(153, System.Byte), CType(0, System.Byte))
        Me.bar3.Title = "bar3"
        ' 
        ' bar3.XValues
        ' 
        Me.bar3.XValues.DataMember = "X"
        Me.bar3.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' bar3.YValues
        ' 
        Me.bar3.YValues.DataMember = "Bar"
        ' 
        ' gridBand1
        ' 
        Me.gridBand1.Axis = Me.tChart1.Axes.Left
        ' 
        ' gridBand1.Band1
        ' 
        Me.gridBand1.Band1.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        ' 
        ' gridBand1.Band2
        ' 
        Me.gridBand1.Band2.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(224, System.Byte), CType(224, System.Byte), CType(224, System.Byte))
        ' 
        ' SeriesType_Bar
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(466, 286)
        Me.Name = "SeriesType_Bar"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub 'InitializeComponent 
#End Region


    Private Sub comboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboBox1.SelectedIndexChanged
        Select Case comboBox1.SelectedIndex
            Case 0
                bar1.MultiBar = Steema.TeeChart.Styles.MultiBars.None
            Case 1
                bar1.MultiBar = Steema.TeeChart.Styles.MultiBars.Side
            Case 2
                bar1.MultiBar = Steema.TeeChart.Styles.MultiBars.Stacked
            Case 3
                bar1.MultiBar = Steema.TeeChart.Styles.MultiBars.Stacked100
            Case 4
                bar1.MultiBar = Steema.TeeChart.Styles.MultiBars.SideAll
            Case 5
                bar1.MultiBar = Steema.TeeChart.Styles.MultiBars.SelfStack
        End Select

        ' remove "Marks" when stacking...
        bar1.Marks.Visible = bar1.MultiBar <> Steema.TeeChart.Styles.MultiBars.Stacked AndAlso bar1.MultiBar <> Steema.TeeChart.Styles.MultiBars.Stacked100 AndAlso bar1.MultiBar <> Steema.TeeChart.Styles.MultiBars.SelfStack
        bar2.Marks.Visible = bar1.Marks.Visible
        bar3.Marks.Visible = bar1.Marks.Visible
    End Sub 'comboBox1_SelectedIndexChanged


    Private Sub comboBox2_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboBox2.SelectedIndexChanged
        Select Case comboBox2.SelectedIndex
            Case 0
                bar1.BarStyle = Steema.TeeChart.Styles.BarStyles.Rectangle
            Case 1
                bar1.BarStyle = Steema.TeeChart.Styles.BarStyles.Pyramid
            Case 2
                bar1.BarStyle = Steema.TeeChart.Styles.BarStyles.InvPyramid
            Case 3
                bar1.BarStyle = Steema.TeeChart.Styles.BarStyles.Cylinder
            Case 4
                bar1.BarStyle = Steema.TeeChart.Styles.BarStyles.Ellipse
            Case 5
                bar1.BarStyle = Steema.TeeChart.Styles.BarStyles.Arrow
            Case 6
                bar1.BarStyle = Steema.TeeChart.Styles.BarStyles.RectGradient
            Case 7
                bar1.BarStyle = Steema.TeeChart.Styles.BarStyles.Cone
        End Select
    End Sub 'comboBox2_SelectedIndexChanged


    Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
        tChart1.ShowEditor()
    End Sub 'button1_Click


    Private Sub SeriesType_Bar_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        comboBox1.SelectedIndex = 1
        comboBox2.SelectedIndex = 0
    End Sub 'SeriesType_Bar_Load
End Class 'SeriesType_Bar
