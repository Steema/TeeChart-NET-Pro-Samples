
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing

Imports System.Windows.Forms




Public Class SeriesType_Area
    Inherits Samples.BaseForm
    Private label1 As System.Windows.Forms.Label
    Private WithEvents comboBox1 As System.Windows.Forms.ComboBox
    Private WithEvents button1 As System.Windows.Forms.Button
    Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
    Private WithEvents checkBox2 As System.Windows.Forms.CheckBox
    Private areaSeries1 As Steema.TeeChart.Styles.Area
    Private areaSeries2 As Steema.TeeChart.Styles.Area
    Private areaSeries3 As Steema.TeeChart.Styles.Area
    Private WithEvents cBMarks As System.Windows.Forms.CheckBox
    Private gridBand1 As Steema.TeeChart.Tools.GridBand
    Private components As System.ComponentModel.IContainer = Nothing
    
    
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        
        '			areaSeries1.FillSampleValues(6)
        '			areaSeries2.FillSampleValues(6)
        '			areaSeries3.FillSampleValues(6)

        Dim r As New Random
        Dim s As Integer
        For s = 0 To tChart1.Series.Count - 1
            Dim i As Integer
            For i = 0 To 4
                tChart1(s).Add(r.Next(100 - s * 20))
            Next i
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
        Me.button1 = New System.Windows.Forms.Button
        Me.checkBox1 = New System.Windows.Forms.CheckBox
        Me.checkBox2 = New System.Windows.Forms.CheckBox
        Me.areaSeries1 = New Steema.TeeChart.Styles.Area
        Me.areaSeries2 = New Steema.TeeChart.Styles.Area
        Me.areaSeries3 = New Steema.TeeChart.Styles.Area
        Me.cBMarks = New System.Windows.Forms.CheckBox
        Me.gridBand1 = New Steema.TeeChart.Tools.GridBand
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(466, 63)
        Me.textBox1.Text = "The Area style allows single or multiple areas, with different layouts ( 3D, stac" + "ked, stacked 100% )." + vbCr + vbLf + "Options include 2D and 3D, color-each-area, patterns, dark" + " 3D, bottom origin, stairs mode, marks, border, etc."
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.cBMarks)
        Me.panel1.Controls.Add(Me.checkBox2)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Controls.Add(Me.checkBox1)
        Me.panel1.Controls.Add(Me.button1)
        Me.panel1.Controls.Add(Me.comboBox1)
        Me.panel1.Location = New System.Drawing.Point(0, 63)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(466, 41)
        ' 
        ' tChart1
        ' 
        ' 
        ' tChart1.Aspect
        ' 
        Me.tChart1.Aspect.ColorPaletteIndex = 3
        Me.tChart1.Aspect.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality
        Me.tChart1.Aspect.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        ' 
        ' tChart1.Header
        ' 
        ' 
        ' tChart1.Header.Font
        ' 
        ' 
        ' tChart1.Header.Font.Brush
        ' 
        Me.tChart1.Header.Font.Brush.Color = System.Drawing.Color.Black
        Me.tChart1.Header.Font.Name = "Microsoft Sans Serif"
        Me.tChart1.Header.Font.Size = 11
        Me.tChart1.Header.Lines = New String() {"Area Series example"}
        ' 
        ' tChart1.Legend
        ' 
        ' 
        ' tChart1.Legend.Pen
        ' 
        Me.tChart1.Legend.Pen.Visible = False
        ' 
        ' tChart1.Legend.Shadow
        ' 
        Me.tChart1.Legend.Shadow.Visible = False
        Me.tChart1.Location = New System.Drawing.Point(0, 104)
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Brush
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.tChart1.Series.Add(Me.areaSeries1)
        Me.tChart1.Series.Add(Me.areaSeries2)
        Me.tChart1.Series.Add(Me.areaSeries3)
        Me.tChart1.Size = New System.Drawing.Size(466, 182)
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
        Me.tChart1.Walls.Back.Pen.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(192, System.Byte), CType(192, System.Byte), CType(192, System.Byte))
        ' 
        ' tChart1.Walls.Bottom
        ' 
        ' 
        ' tChart1.Walls.Bottom.Pen
        ' 
        Me.tChart1.Walls.Bottom.Pen.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(192, System.Byte), CType(192, System.Byte), CType(192, System.Byte))
        Me.tChart1.Walls.Bottom.Pen.Visible = False
        Me.tChart1.Walls.Bottom.Size = 5
        ' 
        ' tChart1.Walls.Left
        ' 
        ' 
        ' tChart1.Walls.Left.Pen
        ' 
        Me.tChart1.Walls.Left.Pen.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(192, System.Byte), CType(192, System.Byte), CType(192, System.Byte))
        Me.tChart1.Walls.Left.Pen.Visible = False
        Me.tChart1.Walls.Left.Size = 5
        ' 
        ' label1
        ' 
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(9, 10)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(44, 16)
        Me.label1.TabIndex = 2
        Me.label1.Text = "&Layout :"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        ' 
        ' comboBox1
        ' 
        Me.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboBox1.Items.AddRange(New Object() {"3D", "Stacked", "Stacked 100%"})
        Me.comboBox1.Location = New System.Drawing.Point(53, 8)
        Me.comboBox1.Name = "comboBox1"
        Me.comboBox1.Size = New System.Drawing.Size(94, 21)
        Me.comboBox1.TabIndex = 3
        ' 
        ' button1
        ' 
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.Location = New System.Drawing.Point(368, 8)
        Me.button1.Name = "button1"
        Me.button1.TabIndex = 5
        Me.button1.Text = "&Edit..."
        ' 
        ' checkBox1
        ' 
        Me.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox1.Location = New System.Drawing.Point(160, 11)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(53, 14)
        Me.checkBox1.TabIndex = 6
        Me.checkBox1.Text = "&Stairs"
        ' 
        ' checkBox2
        ' 
        Me.checkBox2.Checked = True
        Me.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox2.Location = New System.Drawing.Point(220, 11)
        Me.checkBox2.Name = "checkBox2"
        Me.checkBox2.Size = New System.Drawing.Size(46, 14)
        Me.checkBox2.TabIndex = 7
        Me.checkBox2.Text = "&3D"
        ' 
        ' areaSeries1
        ' 
        ' 
        ' areaSeries1.AreaBrush
        ' 
        Me.areaSeries1.AreaBrush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(1, System.Byte), CType(43, System.Byte), CType(81, System.Byte))
        ' 
        ' areaSeries1.Gradient
        ' 
        Me.areaSeries1.AreaBrush.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(1, System.Byte), CType(11, System.Byte), CType(49, System.Byte))
        Me.areaSeries1.AreaBrush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(1, System.Byte), CType(43, System.Byte), CType(81, System.Byte))
        Me.areaSeries1.AreaBrush.Gradient.Visible = True
        ' 
        ' areaSeries1.AreaLines
        ' 
        Me.areaSeries1.AreaLines.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(2, System.Byte), CType(9, System.Byte), CType(32, System.Byte))
        ' 
        ' areaSeries1.Brush
        ' 
        Me.areaSeries1.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(1, System.Byte), CType(43, System.Byte), CType(81, System.Byte))
        ' 
        ' areaSeries1.TopGradient
        ' 
        Me.areaSeries1.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(1, System.Byte), CType(43, System.Byte), CType(81, System.Byte))
        ' 
        ' areaSeries1.Gradient
        ' 
        Me.areaSeries1.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(1, System.Byte), CType(11, System.Byte), CType(49, System.Byte))
        Me.areaSeries1.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(1, System.Byte), CType(43, System.Byte), CType(81, System.Byte))
        Me.areaSeries1.Gradient.Visible = True
        ' 
        ' areaSeries1.LinePen
        ' 
        Me.areaSeries1.LinePen.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(2, System.Byte), CType(9, System.Byte), CType(32, System.Byte))
        ' 
        ' areaSeries1.Marks
        ' 
        ' 
        ' areaSeries1.Marks.Arrow
        ' 
        Me.areaSeries1.Marks.Arrow.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(128, System.Byte), CType(128, System.Byte), CType(128, System.Byte))
        ' 
        ' areaSeries1.Marks.Brush
        ' 
        Me.areaSeries1.Marks.Brush.Color = System.Drawing.Color.FromArgb(CType(211, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(224, System.Byte))
        ' 
        ' areaSeries1.Marks.Gradient
        ' 
        Me.areaSeries1.Marks.Brush.Gradient.Transparency = 17
        ' 
        ' areaSeries1.Marks.Gradient
        ' 
        Me.areaSeries1.Marks.Gradient.Transparency = 17
        ' 
        ' areaSeries1.Marks.Pen
        ' 
        Me.areaSeries1.Marks.Pen.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(128, System.Byte), CType(128, System.Byte), CType(128, System.Byte))
        ' 
        ' areaSeries1.Marks.Shadow
        ' 
        Me.areaSeries1.Marks.Shadow.Visible = False
        ' 
        ' areaSeries1.Marks.Symbol
        ' 
        ' 
        ' areaSeries1.Marks.Symbol.Shadow
        ' 
        Me.areaSeries1.Marks.Symbol.Shadow.Height = 1
        Me.areaSeries1.Marks.Symbol.Shadow.Visible = True
        Me.areaSeries1.Marks.Symbol.Shadow.Width = 1
        ' 
        ' areaSeries1.Pointer
        ' 
        ' 
        ' areaSeries1.Pointer.Brush
        ' 
        Me.areaSeries1.Pointer.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(0, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        Me.areaSeries1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.areaSeries1.Title = "area1"
        ' 
        ' areaSeries1.TopGradient
        ' 
        Me.areaSeries1.TopGradient.StartColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(1, System.Byte), CType(43, System.Byte), CType(81, System.Byte))
        ' 
        ' areaSeries1.XValues
        ' 
        Me.areaSeries1.XValues.DataMember = "X"
        Me.areaSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' areaSeries1.YValues
        ' 
        Me.areaSeries1.YValues.DataMember = "Y"
        ' 
        ' areaSeries2
        ' 
        ' 
        ' areaSeries2.AreaBrush
        ' 
        Me.areaSeries2.AreaBrush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(219, System.Byte), CType(37, System.Byte), CType(23, System.Byte))
        ' 
        ' areaSeries2.Gradient
        ' 
        Me.areaSeries2.AreaBrush.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(187, System.Byte), CType(5, System.Byte), CType(0, System.Byte))
        Me.areaSeries2.AreaBrush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(219, System.Byte), CType(37, System.Byte), CType(23, System.Byte))
        Me.areaSeries2.AreaBrush.Gradient.Visible = True
        ' 
        ' areaSeries2.AreaLines
        ' 
        Me.areaSeries2.AreaLines.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(148, System.Byte), CType(26, System.Byte), CType(16, System.Byte))
        ' 
        ' areaSeries2.Brush
        ' 
        Me.areaSeries2.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(219, System.Byte), CType(37, System.Byte), CType(23, System.Byte))
        ' 
        ' areaSeries2.Gradient
        ' 
        Me.areaSeries2.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(187, System.Byte), CType(5, System.Byte), CType(0, System.Byte))
        Me.areaSeries2.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(219, System.Byte), CType(37, System.Byte), CType(23, System.Byte))
        Me.areaSeries2.Gradient.Visible = True
        ' 
        ' areaSeries2.LinePen
        ' 
        Me.areaSeries2.LinePen.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(148, System.Byte), CType(26, System.Byte), CType(15, System.Byte))
        ' 
        ' areaSeries2.Marks
        ' 
        ' 
        ' areaSeries2.Marks.Arrow
        ' 
        Me.areaSeries2.Marks.Arrow.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(128, System.Byte), CType(128, System.Byte), CType(128, System.Byte))
        ' 
        ' areaSeries2.Marks.Brush
        ' 
        Me.areaSeries2.Marks.Brush.Color = System.Drawing.Color.FromArgb(CType(211, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(224, System.Byte))
        ' 
        ' areaSeries2.Marks.Gradient
        ' 
        Me.areaSeries2.Marks.Brush.Gradient.Transparency = 17
        ' 
        ' areaSeries2.Marks.Gradient
        ' 
        Me.areaSeries2.Marks.Gradient.Transparency = 17
        ' 
        ' areaSeries2.Marks.Pen
        ' 
        Me.areaSeries2.Marks.Pen.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(192, System.Byte), CType(192, System.Byte), CType(192, System.Byte))
        ' 
        ' areaSeries2.Marks.Shadow
        ' 
        Me.areaSeries2.Marks.Shadow.Visible = False
        ' 
        ' areaSeries2.Marks.Symbol
        ' 
        ' 
        ' areaSeries2.Marks.Symbol.Shadow
        ' 
        Me.areaSeries2.Marks.Symbol.Shadow.Height = 1
        Me.areaSeries2.Marks.Symbol.Shadow.Visible = True
        Me.areaSeries2.Marks.Symbol.Shadow.Width = 1
        ' 
        ' areaSeries2.Pointer
        ' 
        ' 
        ' areaSeries2.Pointer.Brush
        ' 
        Me.areaSeries2.Pointer.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(0, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        Me.areaSeries2.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.areaSeries2.Title = "area2"
        ' 
        ' areaSeries2.XValues
        ' 
        Me.areaSeries2.XValues.DataMember = "X"
        Me.areaSeries2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' areaSeries2.YValues
        ' 
        Me.areaSeries2.YValues.DataMember = "Y"
        ' 
        ' areaSeries3
        ' 
        ' 
        ' areaSeries3.AreaBrush
        ' 
        Me.areaSeries3.AreaBrush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(234, System.Byte), CType(88, System.Byte))
        ' 
        ' areaSeries3.Gradient
        ' 
        Me.areaSeries3.AreaBrush.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(223, System.Byte), CType(202, System.Byte), CType(56, System.Byte))
        Me.areaSeries3.AreaBrush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(234, System.Byte), CType(88, System.Byte))
        Me.areaSeries3.AreaBrush.Gradient.Visible = True
        ' 
        ' areaSeries3.AreaLines
        ' 
        Me.areaSeries3.AreaLines.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(206, System.Byte), CType(186, System.Byte), CType(0, System.Byte))
        ' 
        ' areaSeries3.Brush
        ' 
        Me.areaSeries3.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(234, System.Byte), CType(88, System.Byte))
        ' 
        ' areaSeries3.Gradient
        ' 
        Me.areaSeries3.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(223, System.Byte), CType(202, System.Byte), CType(56, System.Byte))
        Me.areaSeries3.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(234, System.Byte), CType(88, System.Byte))
        Me.areaSeries3.Gradient.Visible = True
        ' 
        ' areaSeries3.LinePen
        ' 
        Me.areaSeries3.LinePen.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(206, System.Byte), CType(186, System.Byte), CType(0, System.Byte))
        ' 
        ' areaSeries3.Marks
        ' 
        ' 
        ' areaSeries3.Marks.Arrow
        ' 
        Me.areaSeries3.Marks.Arrow.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(128, System.Byte), CType(128, System.Byte), CType(128, System.Byte))
        ' 
        ' areaSeries3.Marks.Brush
        ' 
        Me.areaSeries3.Marks.Brush.Color = System.Drawing.Color.FromArgb(CType(211, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(224, System.Byte))
        ' 
        ' areaSeries3.Marks.Gradient
        ' 
        Me.areaSeries3.Marks.Brush.Gradient.Transparency = 17
        ' 
        ' areaSeries3.Marks.Gradient
        ' 
        Me.areaSeries3.Marks.Gradient.Transparency = 17
        ' 
        ' areaSeries3.Marks.Pen
        ' 
        Me.areaSeries3.Marks.Pen.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(192, System.Byte), CType(192, System.Byte), CType(192, System.Byte))
        ' 
        ' areaSeries3.Marks.Shadow
        ' 
        Me.areaSeries3.Marks.Shadow.Visible = False
        ' 
        ' areaSeries3.Marks.Symbol
        ' 
        ' 
        ' areaSeries3.Marks.Symbol.Shadow
        ' 
        Me.areaSeries3.Marks.Symbol.Shadow.Height = 1
        Me.areaSeries3.Marks.Symbol.Shadow.Visible = True
        Me.areaSeries3.Marks.Symbol.Shadow.Width = 1
        ' 
        ' areaSeries3.Pointer
        ' 
        ' 
        ' areaSeries3.Pointer.Brush
        ' 
        Me.areaSeries3.Pointer.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(0, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        Me.areaSeries3.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.areaSeries3.Title = "area3"
        ' 
        ' areaSeries3.XValues
        ' 
        Me.areaSeries3.XValues.DataMember = "X"
        Me.areaSeries3.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' areaSeries3.YValues
        ' 
        Me.areaSeries3.YValues.DataMember = "Y"
        ' 
        ' cBMarks
        ' 
        Me.cBMarks.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cBMarks.Location = New System.Drawing.Point(273, 10)
        Me.cBMarks.Name = "cBMarks"
        Me.cBMarks.Size = New System.Drawing.Size(87, 16)
        Me.cBMarks.TabIndex = 8
        Me.cBMarks.Text = "Show &Marks"
        ' 
        ' gridBand1
        ' 
        Me.gridBand1.Axis = Me.tChart1.Axes.Left
        ' 
        ' gridBand1.Band1
        ' 
        Me.gridBand1.Band1.Color = System.Drawing.Color.FromArgb(CType(76, System.Byte), CType(128, System.Byte), CType(128, System.Byte), CType(0, System.Byte))
        ' 
        ' gridBand1.Band2
        ' 
        Me.gridBand1.Band2.Color = System.Drawing.Color.FromArgb(CType(102, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        ' 
        ' SeriesType_Area
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(466, 286)
        Me.Name = "SeriesType_Area"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub 'InitializeComponent 
#End Region


    Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
        TeeChart.Editors.SeriesEditor.ShowEditor(Me.areaSeries1)
    End Sub 'button1_Click


    Private Sub checkBox2_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox2.CheckedChanged
        tChart1.Aspect.View3D = checkBox2.Checked
    End Sub 'checkBox2_CheckedChanged


    Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox1.CheckedChanged
        areaSeries1.Stairs = checkBox1.Checked
        areaSeries2.Stairs = checkBox1.Checked
        areaSeries3.Stairs = checkBox1.Checked
    End Sub 'checkBox1_CheckedChanged


    Private Sub comboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboBox1.SelectedIndexChanged
        Select Case comboBox1.SelectedIndex
            Case 0
                areaSeries1.MultiArea = Steema.TeeChart.Styles.MultiAreas.None
            Case 1
                areaSeries1.MultiArea = Steema.TeeChart.Styles.MultiAreas.Stacked
            Case 2
                areaSeries1.MultiArea = Steema.TeeChart.Styles.MultiAreas.Stacked100
        End Select

        If comboBox1.SelectedIndex = 0 Then
            areaSeries1.Marks.Visible = cBMarks.Checked
            areaSeries2.Marks.Visible = cBMarks.Checked
            areaSeries3.Marks.Visible = cBMarks.Checked
        Else
            ' remove "Marks" when stacking...
            areaSeries1.Marks.Visible = areaSeries1.MultiArea = Steema.TeeChart.Styles.MultiAreas.None
            areaSeries2.Marks.Visible = areaSeries2.MultiArea = Steema.TeeChart.Styles.MultiAreas.None
            areaSeries3.Marks.Visible = areaSeries3.MultiArea = Steema.TeeChart.Styles.MultiAreas.None
        End If
    End Sub 'comboBox1_SelectedIndexChanged


    Private Sub SeriesType_Area_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        comboBox1.SelectedIndex = 0
    End Sub 'SeriesType_Area_Load


    Private Sub cBMarks_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cBMarks.CheckedChanged
        comboBox1_SelectedIndexChanged(sender, e)
    End Sub 'cBMarks_CheckedChanged
End Class 'SeriesType_Area
