
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing

Imports System.Windows.Forms



Public Class Area_StackGroup
    Inherits Samples.BaseForm

    '/ <summary>
    '/ Required designer variable.
    '/ </summary>
    Private components As System.ComponentModel.IContainer = Nothing


    Public Sub New() ' me call is required by the Windows Form Designer.
        InitializeComponent()
        For Each s As Styles.Series In tChart1.Series
            s.FillSampleValues(10)
            comboBox1.Items.Add(s.Title)
        Next
        comboBox1.SelectedIndex = 0
    End Sub

    Private area1 As Steema.TeeChart.Styles.Area
    Private area2 As Steema.TeeChart.Styles.Area
    Private area3 As Steema.TeeChart.Styles.Area
    Private area4 As Steema.TeeChart.Styles.Area
    Private WithEvents checkBox1 As CheckBox
    Private WithEvents comboBox1 As ComboBox
    Private label1 As Label
    Private WithEvents numericUpDown1 As NumericUpDown
    Private label2 As Label

    Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox1.CheckedChanged
        For Each s As Styles.Series In tChart1.Series
            If checkBox1.Checked Then
                CType(s, Styles.Area).MultiArea = Styles.MultiAreas.Stacked
            Else
                CType(s, Styles.Area).MultiArea = Styles.MultiAreas.None
            End If
        Next
    End Sub

    Private Sub comboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox1.SelectedIndexChanged
        numericUpDown1.Value = CType(tChart1(comboBox1.SelectedIndex), Styles.Area).StackGroup
    End Sub

    Private Sub numericUpDown1_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles numericUpDown1.ValueChanged
        CType(tChart1(comboBox1.SelectedIndex), Styles.Area).StackGroup = CInt(numericUpDown1.Value)
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
    '/ the contents of me method with the code editor.
    '/ </summary>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Area_StackGroup))
        Me.area1 = New Steema.TeeChart.Styles.Area()
        Me.area2 = New Steema.TeeChart.Styles.Area()
        Me.area3 = New Steema.TeeChart.Styles.Area()
        Me.area4 = New Steema.TeeChart.Styles.Area()
        Me.checkBox1 = New System.Windows.Forms.CheckBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.comboBox1 = New System.Windows.Forms.ComboBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.numericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.panel1.SuspendLayout()
        Me.chartContainer.SuspendLayout()
        CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
    Me.textBox1.Text = "Area  series can now be grouped. The StackGroup propertydefines the ""group"". " & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "Th" & _
       "ere is no limit on how many groups exist." & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "Example: area1.StackGroup = 0 " & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & " ar" & _
       "ea2.StackGroup = 1  "
        '
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.numericUpDown1)
        Me.panel1.Controls.Add(Me.label2)
        Me.panel1.Controls.Add(Me.comboBox1)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Controls.Add(Me.checkBox1)
        ' 
        ' tChart1
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Aspect.ColorPaletteIndex = 0
        ' 
        ' 
        ' 
        Me.tChart1.Legend.Alignment = Steema.TeeChart.LegendAlignments.Bottom
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tChart1.Panel.Brush.Gradient.ExtendedColorPalette = Nothing
        Me.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.tChart1.Panel.Brush.Gradient.UseMiddle = True
        Me.tChart1.Panel.Brush.Gradient.Visible = True
        Me.tChart1.Series.Add(Me.area1)
        Me.tChart1.Series.Add(Me.area2)
        Me.tChart1.Series.Add(Me.area3)
        Me.tChart1.Series.Add(Me.area4)
        Me.tChart1.Size = New System.Drawing.Size(440, 205)
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
        Me.tChart1.Walls.Back.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tChart1.Walls.Back.Brush.Gradient.ExtendedColorPalette = Nothing
        Me.tChart1.Walls.Back.Brush.Gradient.MiddleColor = System.Drawing.Color.Empty
        Me.tChart1.Walls.Back.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.tChart1.Walls.Back.Brush.Gradient.Visible = True
        Me.tChart1.Walls.Back.Brush.Visible = True
        Me.tChart1.Walls.Back.Transparent = False
        ' 
        ' area1
        ' 
        ' 
        ' 
        ' 
        Me.area1.AreaBrush.Color = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(44, Byte), Integer))
        ' 
        ' 
        ' 
        Me.area1.AreaLines.Color = System.Drawing.Color.FromArgb(CType(CType(134, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(26, Byte), Integer))
        ' 
        ' 
        ' 
        Me.area1.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.area1.ColorEach = False
        Me.area1.DefaultNullValue = 0
        ' 
        ' 
        ' 
        Me.area1.Gradient.ExtendedColorPalette = Nothing
        Me.area1.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.area1.Gradient.Transparency = 30
        ' 
        ' 
        ' 
        Me.area1.LinePen.Color = System.Drawing.Color.FromArgb(CType(CType(134, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(26, Byte), Integer))
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.area1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None
        Me.area1.Marks.Callout.ArrowHeadSize = 8
        ' 
        ' 
        ' 
        Me.area1.Marks.Callout.Brush.Color = System.Drawing.Color.Black
        Me.area1.Marks.Callout.Distance = 0
        Me.area1.Marks.Callout.Draw3D = False
        Me.area1.Marks.Callout.Length = 10
        Me.area1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.area1.MultiArea = Steema.TeeChart.Styles.MultiAreas.Stacked
        ' 
        ' 
        ' 
        Me.area1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.area1.Stacked = Steema.TeeChart.Styles.CustomStack.Stack
        Me.area1.Title = "area1"
        ' 
        ' 
        ' 
        Me.area1.TopGradient.Direction = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.area1.TopGradient.EndColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.area1.TopGradient.ExtendedColorPalette = Nothing
        Me.area1.TopGradient.MiddleColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.area1.TopGradient.StartColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.area1.TopGradient.Transparency = 30
        Me.area1.TopGradient.UseMiddle = True
        ' 
        ' 
        ' 
        Me.area1.XValues.DataMember = "X"
        Me.area1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' 
        ' 
        Me.area1.YValues.DataMember = "Y"
        ' 
        ' area2
        ' 
        ' 
        ' 
        ' 
        Me.area2.AreaBrush.Color = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(54, Byte), Integer))
        ' 
        ' 
        ' 
        Me.area2.AreaLines.Color = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(32, Byte), Integer))
        ' 
        ' 
        ' 
        Me.area2.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.area2.ColorEach = False
        Me.area2.DefaultNullValue = 0
        ' 
        ' 
        ' 
        Me.area2.Gradient.ExtendedColorPalette = Nothing
        Me.area2.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.area2.Gradient.Transparency = 30
        ' 
        ' 
        ' 
        Me.area2.LinePen.Color = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(32, Byte), Integer))
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.area2.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None
        Me.area2.Marks.Callout.ArrowHeadSize = 8
        ' 
        ' 
        ' 
        Me.area2.Marks.Callout.Brush.Color = System.Drawing.Color.Black
        Me.area2.Marks.Callout.Distance = 0
        Me.area2.Marks.Callout.Draw3D = False
        Me.area2.Marks.Callout.Length = 10
        Me.area2.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.area2.MultiArea = Steema.TeeChart.Styles.MultiAreas.Stacked
        ' 
        ' 
        ' 
        Me.area2.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.area2.Stacked = Steema.TeeChart.Styles.CustomStack.Stack
        Me.area2.StackGroup = 1
        Me.area2.Title = "area2"
        ' 
        ' 
        ' 
        Me.area2.TopGradient.Direction = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.area2.TopGradient.EndColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.area2.TopGradient.ExtendedColorPalette = Nothing
        Me.area2.TopGradient.MiddleColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.area2.TopGradient.StartColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.area2.TopGradient.Transparency = 30
        Me.area2.TopGradient.UseMiddle = True
        ' 
        ' 
        ' 
        Me.area2.XValues.DataMember = "X"
        Me.area2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' 
        ' 
        Me.area2.YValues.DataMember = "Y"
        ' 
        ' area3
        ' 
        ' 
        ' 
        ' 
        Me.area3.AreaBrush.Color = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(65, Byte), Integer))
        ' 
        ' 
        ' 
        Me.area3.AreaLines.Color = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(39, Byte), Integer))
        ' 
        ' 
        ' 
        Me.area3.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.area3.ColorEach = False
        Me.area3.DefaultNullValue = 0
        ' 
        ' 
        ' 
        Me.area3.Gradient.ExtendedColorPalette = Nothing
        Me.area3.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.area3.Gradient.Transparency = 30
        ' 
        ' 
        ' 
        Me.area3.LinePen.Color = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(39, Byte), Integer))
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.area3.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None
        Me.area3.Marks.Callout.ArrowHeadSize = 8
        ' 
        ' 
        ' 
        Me.area3.Marks.Callout.Brush.Color = System.Drawing.Color.Black
        Me.area3.Marks.Callout.Distance = 0
        Me.area3.Marks.Callout.Draw3D = False
        Me.area3.Marks.Callout.Length = 10
        Me.area3.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.area3.MultiArea = Steema.TeeChart.Styles.MultiAreas.Stacked
        ' 
        ' 
        ' 
        Me.area3.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.area3.Stacked = Steema.TeeChart.Styles.CustomStack.Stack
        Me.area3.Title = "area3"
        ' 
        ' 
        ' 
        Me.area3.TopGradient.Direction = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.area3.TopGradient.EndColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.area3.TopGradient.ExtendedColorPalette = Nothing
        Me.area3.TopGradient.MiddleColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.area3.TopGradient.StartColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.area3.TopGradient.Transparency = 30
        Me.area3.TopGradient.UseMiddle = True
        ' 
        ' 
        ' 
        Me.area3.XValues.DataMember = "X"
        Me.area3.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' 
        ' 
        Me.area3.YValues.DataMember = "Y"
        ' 
        ' area4
        ' 
        ' 
        ' 
        ' 
        Me.area4.AreaBrush.Color = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(58, Byte), Integer))
        ' 
        ' 
        ' 
        Me.area4.AreaLines.Color = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(35, Byte), Integer))
        ' 
        ' 
        ' 
        Me.area4.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.area4.ColorEach = False
        Me.area4.DefaultNullValue = 0
        ' 
        ' 
        ' 
        Me.area4.Gradient.ExtendedColorPalette = Nothing
        Me.area4.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.area4.Gradient.Transparency = 30
        ' 
        ' 
        ' 
        Me.area4.LinePen.Color = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(35, Byte), Integer))
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.area4.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None
        Me.area4.Marks.Callout.ArrowHeadSize = 8
        ' 
        ' 
        ' 
        Me.area4.Marks.Callout.Brush.Color = System.Drawing.Color.Black
        Me.area4.Marks.Callout.Distance = 0
        Me.area4.Marks.Callout.Draw3D = False
        Me.area4.Marks.Callout.Length = 10
        Me.area4.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.area4.MultiArea = Steema.TeeChart.Styles.MultiAreas.Stacked
        ' 
        ' 
        ' 
        Me.area4.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.area4.Stacked = Steema.TeeChart.Styles.CustomStack.Stack
        Me.area4.StackGroup = 1
        Me.area4.Title = "area4"
        ' 
        ' 
        ' 
        Me.area4.TopGradient.Direction = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.area4.TopGradient.EndColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.area4.TopGradient.ExtendedColorPalette = Nothing
        Me.area4.TopGradient.MiddleColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.area4.TopGradient.StartColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.area4.TopGradient.Transparency = 30
        Me.area4.TopGradient.UseMiddle = True
        ' 
        ' 
        ' 
        Me.area4.XValues.DataMember = "X"
        Me.area4.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' 
        ' 
        Me.area4.YValues.DataMember = "Y"
        ' 
        ' checkBox1
        ' 
#If VS2005 Then
        Me.checkBox1.AutoSize = True
#End If
        Me.checkBox1.Checked = True
        Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox1.Location = New System.Drawing.Point(12, 16)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(63, 17)
        Me.checkBox1.TabIndex = 0
        Me.checkBox1.Text = "Stacked"
#If VS2005 Then
        Me.checkBox1.UseVisualStyleBackColor = True
#End If
        ' 
        ' label1
        ' 
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(129, 18)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(36, 13)
        Me.label1.TabIndex = 1
        Me.label1.Text = "Series"
        ' 
        ' comboBox1
        ' 
#If VS2005 Then
        Me.comboBox1.FormattingEnabled = True
#End If
        Me.comboBox1.Location = New System.Drawing.Point(171, 15)
        Me.comboBox1.Name = "comboBox1"
        Me.comboBox1.Size = New System.Drawing.Size(90, 21)
        Me.comboBox1.TabIndex = 2
        ' 
        ' label2
        ' 
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(277, 18)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(36, 13)
        Me.label2.TabIndex = 3
        Me.label2.Text = "Group"
        ' 
        ' numericUpDown1
        ' 
        Me.numericUpDown1.Location = New System.Drawing.Point(319, 16)
        Me.numericUpDown1.Maximum = New Decimal(New Integer() { _
        3, _
        0, _
        0, _
        0})
        Me.numericUpDown1.Name = "numericUpDown1"
        Me.numericUpDown1.Size = New System.Drawing.Size(45, 20)
        Me.numericUpDown1.TabIndex = 4
        ' 
        ' Area_StackGroup
        ' 
        Me.ClientSize = New System.Drawing.Size(440, 317)
        Me.Name = "Area_StackGroup"
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.chartContainer.ResumeLayout(False)
        CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()


    End Sub

#End Region

End Class

