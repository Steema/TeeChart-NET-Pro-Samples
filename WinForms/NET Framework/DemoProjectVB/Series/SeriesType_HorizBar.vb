
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms



Public Class SeriesType_HorizBar
    Inherits Samples.BaseForm
    Private label1 As System.Windows.Forms.Label
    Private WithEvents comboBox1 As System.Windows.Forms.ComboBox
    Private label2 As System.Windows.Forms.Label
    Private WithEvents comboBox2 As System.Windows.Forms.ComboBox
    Private WithEvents button1 As System.Windows.Forms.Button
    Private horizBarSeries1 As Steema.TeeChart.Styles.HorizBar
    Private horizBarSeries2 As Steema.TeeChart.Styles.HorizBar
    Private horizBarSeries3 As Steema.TeeChart.Styles.HorizBar
    Private gridBand1 As Steema.TeeChart.Tools.GridBand
    Private components As System.ComponentModel.IContainer = Nothing
    
    
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        

        For Each hb As TeeChart.Styles.HorizBar In tChart1.Series
            hb.FillSampleValues(4)
            hb.MultiBar = Steema.TeeChart.Styles.MultiBars.None
        Next hb
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
        Me.label2 = New System.Windows.Forms.Label
        Me.comboBox2 = New System.Windows.Forms.ComboBox
        Me.button1 = New System.Windows.Forms.Button
        Me.horizBarSeries1 = New Steema.TeeChart.Styles.HorizBar
        Me.horizBarSeries2 = New Steema.TeeChart.Styles.HorizBar
        Me.horizBarSeries3 = New Steema.TeeChart.Styles.HorizBar
        Me.gridBand1 = New Steema.TeeChart.Tools.GridBand
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(560, 80)
        Me.textBox1.Text = "The Horizontal Bar style allows single or multiple bars, with different layouts ( 3D, side-to-side, side-all, stacked, stacked 100% )." + vbCr + vbLf + vbCr + vbLf + "Options include 2D and 3D, color-each-bar, bar style, patterns, dark 3D, bottom origin, auto-mark positions, stacking groups, marks, border, etc."
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.button1)
        Me.panel1.Controls.Add(Me.comboBox2)
        Me.panel1.Controls.Add(Me.label2)
        Me.panel1.Controls.Add(Me.comboBox1)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Location = New System.Drawing.Point(0, 80)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(560, 36)
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
        Me.tChart1.Location = New System.Drawing.Point(0, 116)
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Brush
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.tChart1.Series.Add(Me.horizBarSeries1)
        Me.tChart1.Series.Add(Me.horizBarSeries2)
        Me.tChart1.Series.Add(Me.horizBarSeries3)
        Me.tChart1.Size = New System.Drawing.Size(560, 214)
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
        ' label1
        ' 
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(14, 10)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(44, 16)
        Me.label1.TabIndex = 2
        Me.label1.Text = "&Layout :"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        ' 
        ' comboBox1
        ' 
        Me.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboBox1.Items.AddRange(New Object() {"3D", "Side-to-side", "Stacked", "Stacked 100%", "Side All"})
        Me.comboBox1.Location = New System.Drawing.Point(64, 8)
        Me.comboBox1.Name = "comboBox1"
        Me.comboBox1.Size = New System.Drawing.Size(112, 21)
        Me.comboBox1.TabIndex = 3
        ' 
        ' label2
        ' 
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(202, 10)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(63, 16)
        Me.label2.TabIndex = 4
        Me.label2.Text = "&Style Bar 1:"
        Me.label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        ' 
        ' comboBox2
        ' 
        Me.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboBox2.Items.AddRange(New Object() {"Rectangle", "Pyramid", "Invert. Pyramid", "Cylinder", "Ellipse", "Arrow", "Rect. Gradient", "Cone"})
        Me.comboBox2.Location = New System.Drawing.Point(272, 8)
        Me.comboBox2.Name = "comboBox2"
        Me.comboBox2.Size = New System.Drawing.Size(104, 21)
        Me.comboBox2.TabIndex = 5
        ' 
        ' button1
        ' 
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.Location = New System.Drawing.Point(400, 6)
        Me.button1.Name = "button1"
        Me.button1.TabIndex = 6
        Me.button1.Text = "&Edit..."
        ' 
        ' horizBarSeries1
        ' 
        ' 
        ' horizBarSeries1.Brush
        ' 
        Me.horizBarSeries1.Brush.Color = System.Drawing.Color.Red
        ' 
        ' horizBarSeries1.Gradient
        ' 
        Me.horizBarSeries1.Brush.Gradient.Direction = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        ' 
        ' horizBarSeries1.Gradient
        ' 
        Me.horizBarSeries1.Gradient.Direction = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        ' 
        ' horizBarSeries1.Marks
        ' 
        ' 
        ' horizBarSeries1.Marks.Symbol
        ' 
        ' 
        ' horizBarSeries1.Marks.Symbol.Shadow
        ' 
        Me.horizBarSeries1.Marks.Symbol.Shadow.Height = 1
        Me.horizBarSeries1.Marks.Symbol.Shadow.Visible = True
        Me.horizBarSeries1.Marks.Symbol.Shadow.Width = 1
        Me.horizBarSeries1.Title = "horizBarSeries1"
        ' 
        ' horizBarSeries1.XValues
        ' 
        Me.horizBarSeries1.XValues.DataMember = "X"
        ' 
        ' horizBarSeries1.YValues
        ' 
        Me.horizBarSeries1.YValues.DataMember = "Bar"
        Me.horizBarSeries1.YValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' horizBarSeries2
        ' 
        ' 
        ' horizBarSeries2.Brush
        ' 
        Me.horizBarSeries2.Brush.Color = System.Drawing.Color.Green
        ' 
        ' horizBarSeries2.Gradient
        ' 
        Me.horizBarSeries2.Brush.Gradient.Direction = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        ' 
        ' horizBarSeries2.Gradient
        ' 
        Me.horizBarSeries2.Gradient.Direction = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        ' 
        ' horizBarSeries2.Marks
        ' 
        ' 
        ' horizBarSeries2.Marks.Symbol
        ' 
        ' 
        ' horizBarSeries2.Marks.Symbol.Shadow
        ' 
        Me.horizBarSeries2.Marks.Symbol.Shadow.Height = 1
        Me.horizBarSeries2.Marks.Symbol.Shadow.Visible = True
        Me.horizBarSeries2.Marks.Symbol.Shadow.Width = 1
        Me.horizBarSeries2.Title = "horizBarSeries2"
        ' 
        ' horizBarSeries2.XValues
        ' 
        Me.horizBarSeries2.XValues.DataMember = "X"
        ' 
        ' horizBarSeries2.YValues
        ' 
        Me.horizBarSeries2.YValues.DataMember = "Bar"
        Me.horizBarSeries2.YValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' horizBarSeries3
        ' 
        ' 
        ' horizBarSeries3.Brush
        ' 
        Me.horizBarSeries3.Brush.Color = System.Drawing.Color.Yellow
        ' 
        ' horizBarSeries3.Gradient
        ' 
        Me.horizBarSeries3.Brush.Gradient.Direction = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        ' 
        ' horizBarSeries3.Gradient
        ' 
        Me.horizBarSeries3.Gradient.Direction = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        ' 
        ' horizBarSeries3.Marks
        ' 
        ' 
        ' horizBarSeries3.Marks.Symbol
        ' 
        ' 
        ' horizBarSeries3.Marks.Symbol.Shadow
        ' 
        Me.horizBarSeries3.Marks.Symbol.Shadow.Height = 1
        Me.horizBarSeries3.Marks.Symbol.Shadow.Visible = True
        Me.horizBarSeries3.Marks.Symbol.Shadow.Width = 1
        Me.horizBarSeries3.Title = "horizBarSeries3"
        ' 
        ' horizBarSeries3.XValues
        ' 
        Me.horizBarSeries3.XValues.DataMember = "X"
        ' 
        ' horizBarSeries3.YValues
        ' 
        Me.horizBarSeries3.YValues.DataMember = "Bar"
        Me.horizBarSeries3.YValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' gridBand1
        ' 
        Me.gridBand1.Axis = Me.tChart1.Axes.Bottom
        ' 
        ' gridBand1.Band1
        ' 
        Me.gridBand1.Band1.Color = System.Drawing.Color.FromArgb(CType(127, System.Byte), CType(192, System.Byte), CType(192, System.Byte), CType(192, System.Byte))
        ' 
        ' gridBand1.Band2
        ' 
        Me.gridBand1.Band2.Color = System.Drawing.Color.FromArgb(CType(127, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        ' 
        ' SeriesType_HorizBar
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(560, 330)
        Me.Name = "SeriesType_HorizBar"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub 'InitializeComponent 
#End Region


    Private Sub comboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboBox1.SelectedIndexChanged
        Select Case comboBox1.SelectedIndex
            Case 0
                horizBarSeries1.MultiBar = Steema.TeeChart.Styles.MultiBars.None
            Case 1
                horizBarSeries1.MultiBar = Steema.TeeChart.Styles.MultiBars.Side
            Case 2
                horizBarSeries1.MultiBar = Steema.TeeChart.Styles.MultiBars.Stacked
            Case 3
                horizBarSeries1.MultiBar = Steema.TeeChart.Styles.MultiBars.Stacked100
            Case 4
                horizBarSeries1.MultiBar = Steema.TeeChart.Styles.MultiBars.SideAll
        End Select

        ' remove "Marks" when stacking...
        horizBarSeries1.Marks.Visible = horizBarSeries1.MultiBar <> Steema.TeeChart.Styles.MultiBars.Stacked AndAlso horizBarSeries1.MultiBar <> Steema.TeeChart.Styles.MultiBars.Stacked100
        horizBarSeries2.Marks.Visible = horizBarSeries1.Marks.Visible
        horizBarSeries3.Marks.Visible = horizBarSeries1.Marks.Visible
    End Sub 'comboBox1_SelectedIndexChanged


    Private Sub comboBox2_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboBox2.SelectedIndexChanged
        Select Case comboBox2.SelectedIndex
            Case 0
                horizBarSeries1.BarStyle = Steema.TeeChart.Styles.BarStyles.Rectangle
            Case 1
                horizBarSeries1.BarStyle = Steema.TeeChart.Styles.BarStyles.Pyramid
            Case 2
                horizBarSeries1.BarStyle = Steema.TeeChart.Styles.BarStyles.InvPyramid
            Case 3
                horizBarSeries1.BarStyle = Steema.TeeChart.Styles.BarStyles.Cylinder
            Case 4
                horizBarSeries1.BarStyle = Steema.TeeChart.Styles.BarStyles.Ellipse
            Case 5
                horizBarSeries1.BarStyle = Steema.TeeChart.Styles.BarStyles.Arrow
            Case 6
                horizBarSeries1.BarStyle = Steema.TeeChart.Styles.BarStyles.RectGradient
            Case 7
                horizBarSeries1.BarStyle = Steema.TeeChart.Styles.BarStyles.Cone
        End Select
    End Sub 'comboBox2_SelectedIndexChanged


    Private Sub SeriesType_HorizBar_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        comboBox1.SelectedIndex = 0
        comboBox2.SelectedIndex = 0
    End Sub 'SeriesType_HorizBar_Load


    Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
        TeeChart.Editors.SeriesEditor.ShowEditor(horizBarSeries1)
    End Sub 'button1_Click
End Class 'SeriesType_HorizBar