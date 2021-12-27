
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing

Imports System.Windows.Forms



Public Class Tool_SeriesRegion
    Inherits Samples.BaseForm

    Private line1 As Steema.TeeChart.Styles.Line
    Private seriesRegionTool1 As Steema.TeeChart.Tools.SeriesRegionTool
    Private numericUpDown1 As NumericUpDown
    Private label2 As Label
    Private label1 As Label
    Private numericUpDown2 As NumericUpDown
    Private numericUpDown3 As NumericUpDown
    Private label3 As Label
    Private checkBox1 As CheckBox
    Private checkBox2 As CheckBox
    Private button1 As Button
   
    '/ <summary>
    '/ Required designer variable.
    '/ </summary>
    Private components As System.ComponentModel.IContainer = Nothing


    Public Sub New() ' This call is required by the Windows Form Designer.
        InitializeComponent()
        line1.FillSampleValues(20)
        seriesRegionTool1.AutoBound = False
        seriesRegionTool1.Origin = 250.0
        seriesRegionTool1.LowerBound = line1.XValues(2)
        seriesRegionTool1.UpperBound = line1.XValues(15)
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Tool_SeriesRegion))
        Me.Line1 = New Steema.TeeChart.Styles.Line
        Me.SeriesRegionTool1 = New Steema.TeeChart.Tools.SeriesRegionTool
        Me.label1 = New System.Windows.Forms.Label
        Me.label2 = New System.Windows.Forms.Label
        Me.numericUpDown1 = New System.Windows.Forms.NumericUpDown
        Me.numericUpDown2 = New System.Windows.Forms.NumericUpDown
        Me.checkBox1 = New System.Windows.Forms.CheckBox
        Me.label3 = New System.Windows.Forms.Label
        Me.numericUpDown3 = New System.Windows.Forms.NumericUpDown
        Me.checkBox2 = New System.Windows.Forms.CheckBox
        Me.button1 = New System.Windows.Forms.Button
        Me.panel1.SuspendLayout()
        Me.chartContainer.SuspendLayout()
        CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numericUpDown3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Text = ("The SeriesRegionTool can be used to identify area under specific curve (series). " + "All parts are fully configurable.")
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.button1)
        Me.panel1.Controls.Add(Me.checkBox2)
        Me.panel1.Controls.Add(Me.numericUpDown3)
        Me.panel1.Controls.Add(Me.label3)
        Me.panel1.Controls.Add(Me.checkBox1)
        Me.panel1.Controls.Add(Me.numericUpDown2)
        Me.panel1.Controls.Add(Me.numericUpDown1)
        Me.panel1.Controls.Add(Me.label2)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Size = New System.Drawing.Size(440, 76)
        ' 
        ' tChart1
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Aspect.ColorPaletteIndex = 0
        Me.tChart1.Aspect.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
        Me.tChart1.Aspect.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Bottom.Labels.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Bottom.Title.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Depth.Labels.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Depth.Title.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.DepthTop.Labels.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.DepthTop.Title.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Left.Labels.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Left.Title.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Right.Labels.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Right.Title.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Top.Labels.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Top.Title.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Footer.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Header.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Legend.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Legend.Title.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.tChart1.Legend.Visible = False
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(216, Byte), Integer))
        ' 
        ' 
        ' 
        Me.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.tChart1.Panel.Brush.Gradient.ExtendedColorPalette = Nothing
        Me.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tChart1.Panel.Brush.Gradient.Sigma = True
        Me.tChart1.Panel.Brush.Gradient.SigmaFocus = 1.0!
        Me.tChart1.Panel.Brush.Gradient.SigmaScale = 0.8!
        Me.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tChart1.Panel.Brush.Gradient.UseMiddle = True
        Me.tChart1.Panel.Brush.Gradient.Visible = True
        Me.tChart1.Series.Add(Me.Line1)
        Me.tChart1.Size = New System.Drawing.Size(440, 168)
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.SubFooter.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.SubHeader.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        Me.tChart1.Tools.Add(Me.SeriesRegionTool1)
        ' 
        ' chartContainer
        ' 
        Me.chartContainer.Location = New System.Drawing.Point(0, 149)
        Me.chartContainer.Size = New System.Drawing.Size(440, 168)
        ' 
        ' line1
        ' 
        ' 
        ' 
        ' 
        Me.Line1.Brush.Color = System.Drawing.Color.Red
        Me.Line1.ColorEach = False
        ' 
        ' 
        ' 
        Me.Line1.Gradient.ExtendedColorPalette = Nothing
        Me.Line1.Gradient.StartColor = System.Drawing.Color.Red
        ' 
        ' 
        ' 
        Me.Line1.LinePen.Color = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.Line1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None
        Me.Line1.Marks.Callout.ArrowHeadSize = 8
        ' 
        ' 
        ' 
        Me.Line1.Marks.Callout.Brush.Color = System.Drawing.Color.Black
        Me.Line1.Marks.Callout.Distance = 0
        Me.Line1.Marks.Callout.Draw3D = False
        Me.Line1.Marks.Callout.Length = 10
        Me.Line1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        ' 
        ' 
        ' 
        Me.Line1.Marks.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        ' 
        ' 
        ' 
        Me.Line1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.Line1.Title = "line1"
        ' 
        ' 
        ' 
        Me.Line1.XValues.DataMember = "X"
        Me.Line1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' 
        ' 
        Me.Line1.YValues.DataMember = "Y"
        ' 
        ' seriesRegionTool1
        ' 
        Me.SeriesRegionTool1.AutoBound = True
        ' 
        ' 
        ' 
        Me.SeriesRegionTool1.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.SeriesRegionTool1.DrawBehindSeries = True
        Me.SeriesRegionTool1.LowerBound = 0
        Me.SeriesRegionTool1.Origin = 0
        Me.SeriesRegionTool1.Series = Me.Line1
        Me.SeriesRegionTool1.UpperBound = 0
        Me.SeriesRegionTool1.UseOrigin = False
        ' 
        ' label1
        ' 
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(12, 18)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(36, 13)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Lower"
        ' 
        ' label2
        ' 
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(12, 45)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(36, 13)
        Me.label2.TabIndex = 1
        Me.label2.Text = "Upper"
        ' 
        ' numericUpDown1
        ' 
        Me.numericUpDown1.Location = New System.Drawing.Point(54, 16)
        Me.numericUpDown1.Name = "numericUpDown1"
        Me.numericUpDown1.Size = New System.Drawing.Size(54, 20)
        Me.numericUpDown1.TabIndex = 2
        Me.numericUpDown1.Value = New Decimal(New Integer() {2, 0, 0, 0})
        AddHandler numericUpDown1.ValueChanged, AddressOf Me.numericUpDown1_ValueChanged
        ' 
        ' numericUpDown2
        ' 
        Me.numericUpDown2.Location = New System.Drawing.Point(54, 43)
        Me.numericUpDown2.Name = "numericUpDown2"
        Me.numericUpDown2.Size = New System.Drawing.Size(54, 20)
        Me.numericUpDown2.TabIndex = 3
        Me.numericUpDown2.Value = New Decimal(New Integer() {15, 0, 0, 0})
        AddHandler numericUpDown2.ValueChanged, AddressOf Me.numericUpDown2_ValueChanged
        ' 
        ' checkBox1
        ' 
#If VS2005 Then
        Me.checkBox1.AutoSize = True
#End If
        Me.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox1.Location = New System.Drawing.Point(134, 17)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(70, 17)
        Me.checkBox1.TabIndex = 4
        Me.checkBox1.Text = "Use origin"
#If VS2005 Then
Me.checkBox1.UseVisualStyleBackColor = True
#End If
 AddHandler checkBox1.CheckedChanged, AddressOf Me.checkBox1_CheckedChanged
        ' 
        ' label3
        ' 
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(213, 18)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(34, 13)
        Me.label3.TabIndex = 5
        Me.label3.Text = "Origin"
        ' 
        ' numericUpDown3
        ' 
        Me.numericUpDown3.Location = New System.Drawing.Point(253, 16)
        Me.numericUpDown3.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.numericUpDown3.Name = "numericUpDown3"
        Me.numericUpDown3.Size = New System.Drawing.Size(52, 20)
        Me.numericUpDown3.TabIndex = 6
        Me.numericUpDown3.Value = New Decimal(New Integer() {250, 0, 0, 0})
        AddHandler numericUpDown3.ValueChanged, AddressOf Me.numericUpDown3_ValueChanged
        ' 
        ' checkBox2
        ' 
#If VS2005 Then
        Me.checkBox2.AutoSize = True
#End If
        Me.checkBox2.Checked = True
        Me.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox2.Location = New System.Drawing.Point(134, 46)
        Me.checkBox2.Name = "checkBox2"
        Me.checkBox2.Size = New System.Drawing.Size(83, 17)
        Me.checkBox2.TabIndex = 7
        Me.checkBox2.Text = "Draw behind"
    #If VS2005 Then
        Me.checkBox2.UseVisualStyleBackColor = True
#End If
        AddHandler checkBox2.CheckedChanged, AddressOf Me.checkBox2_CheckedChanged
        ' 
        ' button1
        ' 
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.Location = New System.Drawing.Point(342, 13)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(75, 23)
        Me.button1.TabIndex = 8
        Me.button1.Text = "Edit tool"
    #If VS2005 Then
        Me.button1.UseVisualStyleBackColor = True
#End If
 AddHandler button1.Click, AddressOf Me.button1_Click
        ' 
        ' Tool_SeriesRegion
        ' 
        Me.ClientSize = New System.Drawing.Size(440, 317)
        Me.Name = "Tool_SeriesRegion"
        AddHandler Load, AddressOf Me.Tool_SeriesRegion_Load
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.chartContainer.ResumeLayout(False)
        CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numericUpDown3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub numericUpDown1_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
        seriesRegionTool1.LowerBound = line1.XValues(CType(numericUpDown1.Value, Integer))
    End Sub

    Private Sub numericUpDown2_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
        seriesRegionTool1.UpperBound = line1.XValues(CType(numericUpDown2.Value, Integer))
    End Sub

    Private Sub Tool_SeriesRegion_Load(ByVal sender As Object, ByVal e As EventArgs)
        numericUpDown1.Maximum = Line1.Count - 1
        numericUpDown2.Maximum = Line1.Count - 1
    End Sub

    Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
        SeriesRegionTool1.UseOrigin = checkBox1.Checked
    End Sub

    Private Sub numericUpDown3_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
        SeriesRegionTool1.Origin = CType(numericUpDown3.Value, Integer)
    End Sub

    Private Sub checkBox2_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
        SeriesRegionTool1.DrawBehindSeries = checkBox2.Checked
    End Sub

    Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs)
        Editors.Tools.ToolsEditor.ShowEditor(SeriesRegionTool1)
    End Sub
End Class

