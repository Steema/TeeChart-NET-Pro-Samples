
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms


Public Class SeriesType_HorizArea
    Inherits Steema.TeeChart.Samples.BaseForm
    Private horizArea1 As Steema.TeeChart.Styles.HorizArea
    Private horizArea2 As Steema.TeeChart.Styles.HorizArea
    Private horizArea3 As Steema.TeeChart.Styles.HorizArea
    Private label1 As System.Windows.Forms.Label
    Private CBLayout As System.Windows.Forms.ComboBox
    Private CBStairs As System.Windows.Forms.CheckBox
    Private CB3D As System.Windows.Forms.CheckBox
    Private BEdit As System.Windows.Forms.Button
    Private gridBand1 As Steema.TeeChart.Tools.GridBand
    Private components As System.ComponentModel.IContainer = Nothing
    
    Public Sub New() ' This call is required by the Windows Form Designer.
        InitializeComponent()

        horizArea1.FillSampleValues()
        horizArea2.FillSampleValues()
        horizArea3.FillSampleValues()

        CBLayout.SelectedIndex = 0
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
        Me.horizArea1 = New Steema.TeeChart.Styles.HorizArea

        Me.horizArea2 = New Steema.TeeChart.Styles.HorizArea
        Me.horizArea3 = New Steema.TeeChart.Styles.HorizArea
        Me.label1 = New System.Windows.Forms.Label
        Me.CBLayout = New System.Windows.Forms.ComboBox
        Me.CBStairs = New System.Windows.Forms.CheckBox
        Me.CB3D = New System.Windows.Forms.CheckBox
        Me.BEdit = New System.Windows.Forms.Button
        Me.gridBand1 = New Steema.TeeChart.Tools.GridBand
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Text = "The Horizontal Area style allows single or multiple areas, with different layouts ( 3D, overlap, stacked, stacked 100 percent ).Options include 2D and 3D, color-each-area, patterns, gradients,dark 3D, bottom origin, stairs mode, marks, border, transparency, etc."
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.BEdit)
        Me.panel1.Controls.Add(Me.CB3D)
        Me.panel1.Controls.Add(Me.CBStairs)
        Me.panel1.Controls.Add(Me.CBLayout)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Name = "panel1"
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
        Me.tChart1.Legend.Brush.Color = System.Drawing.Color.FromArgb(CType(127, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        ' 
        ' tChart1.Legend.Gradient
        ' 
        Me.tChart1.Legend.Brush.Gradient.Transparency = 50
        ' 
        ' tChart1.Legend.Gradient
        ' 
        Me.tChart1.Legend.Gradient.Transparency = 50
        ' 
        ' tChart1.Legend.Shadow
        ' 
        ' 
        ' tChart1.Legend.Shadow.Brush
        ' 
        Me.tChart1.Legend.Shadow.Brush.Color = System.Drawing.Color.FromArgb(CType(127, System.Byte), CType(0, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Brush
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.tChart1.Series.Add(Me.horizArea1)
        Me.tChart1.Series.Add(Me.horizArea2)
        Me.tChart1.Series.Add(Me.horizArea3)
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
        Me.tChart1.Walls.Bottom.Size = 3
        ' 
        ' tChart1.Walls.Left
        ' 
        ' 
        ' tChart1.Walls.Left.Pen
        ' 
        Me.tChart1.Walls.Left.Pen.Visible = False
        Me.tChart1.Walls.Left.Size = 3
        ' 
        ' horizArea1
        ' 
        ' 
        ' horizArea1.AreaBrush
        ' 
        Me.horizArea1.AreaBrush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(215, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        ' 
        ' horizArea1.Gradient
        ' 
        Me.horizArea1.AreaBrush.Gradient.Direction = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        ' 
        ' horizArea1.AreaLines
        ' 
        Me.horizArea1.AreaLines.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(129, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        ' 
        ' horizArea1.Brush
        ' 
        Me.horizArea1.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(215, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        ' 
        ' horizArea1.Gradient
        ' 
        Me.horizArea1.Gradient.Direction = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        ' 
        ' horizArea1.LinePen
        ' 
        Me.horizArea1.LinePen.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(129, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        ' 
        ' horizArea1.Marks
        ' 
        ' 
        ' horizArea1.Marks.Symbol
        ' 
        ' 
        ' horizArea1.Marks.Symbol.Shadow
        ' 
        Me.horizArea1.Marks.Symbol.Shadow.Height = 1
        Me.horizArea1.Marks.Symbol.Shadow.Visible = True
        Me.horizArea1.Marks.Symbol.Shadow.Width = 1
        ' 
        ' horizArea1.Pointer
        ' 
        ' 
        ' horizArea1.Pointer.Brush
        ' 
        Me.horizArea1.Pointer.Brush.Color = System.Drawing.Color.Red
        Me.horizArea1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.horizArea1.Title = "horizArea1"
        ' 
        ' horizArea1.XValues
        ' 
        Me.horizArea1.XValues.DataMember = "X"
        ' 
        ' horizArea1.YValues
        ' 
        Me.horizArea1.YValues.DataMember = "Y"
        Me.horizArea1.YValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' horizArea2
        ' 
        ' 
        ' horizArea2.AreaBrush
        ' 
        Me.horizArea2.AreaBrush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(0, System.Byte), CType(0, System.Byte), CType(149, System.Byte))
        ' 
        ' horizArea2.Gradient
        ' 
        Me.horizArea2.AreaBrush.Gradient.Direction = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        ' 
        ' horizArea2.AreaLines
        ' 
        Me.horizArea2.AreaLines.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(0, System.Byte), CType(0, System.Byte), CType(89, System.Byte))
        ' 
        ' horizArea2.Brush
        ' 
        Me.horizArea2.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(0, System.Byte), CType(0, System.Byte), CType(149, System.Byte))
        ' 
        ' horizArea2.Gradient
        ' 
        Me.horizArea2.Gradient.Direction = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        ' 
        ' horizArea2.LinePen
        ' 
        Me.horizArea2.LinePen.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(0, System.Byte), CType(0, System.Byte), CType(89, System.Byte))
        ' 
        ' horizArea2.Marks
        ' 
        ' 
        ' horizArea2.Marks.Symbol
        ' 
        ' 
        ' horizArea2.Marks.Symbol.Shadow
        ' 
        Me.horizArea2.Marks.Symbol.Shadow.Height = 1
        Me.horizArea2.Marks.Symbol.Shadow.Visible = True
        Me.horizArea2.Marks.Symbol.Shadow.Width = 1
        ' 
        ' horizArea2.Pointer
        ' 
        ' 
        ' horizArea2.Pointer.Brush
        ' 
        Me.horizArea2.Pointer.Brush.Color = System.Drawing.Color.Green
        Me.horizArea2.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.horizArea2.Title = "horizArea2"
        ' 
        ' horizArea2.XValues
        ' 
        Me.horizArea2.XValues.DataMember = "X"
        ' 
        ' horizArea2.YValues
        ' 
        Me.horizArea2.YValues.DataMember = "Y"
        Me.horizArea2.YValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' horizArea3
        ' 
        ' 
        ' horizArea3.AreaBrush
        ' 
        Me.horizArea3.AreaBrush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(234, System.Byte), CType(234, System.Byte), CType(0, System.Byte))
        ' 
        ' horizArea3.Gradient
        ' 
        Me.horizArea3.AreaBrush.Gradient.Direction = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        ' 
        ' horizArea3.AreaLines
        ' 
        Me.horizArea3.AreaLines.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(140, System.Byte), CType(140, System.Byte), CType(0, System.Byte))
        ' 
        ' horizArea3.Brush
        ' 
        Me.horizArea3.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(234, System.Byte), CType(234, System.Byte), CType(0, System.Byte))
        ' 
        ' horizArea3.Gradient
        ' 
        Me.horizArea3.Gradient.Direction = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        ' 
        ' horizArea3.LinePen
        ' 
        Me.horizArea3.LinePen.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(140, System.Byte), CType(140, System.Byte), CType(0, System.Byte))
        ' 
        ' horizArea3.Marks
        ' 
        ' 
        ' horizArea3.Marks.Symbol
        ' 
        ' 
        ' horizArea3.Marks.Symbol.Shadow
        ' 
        Me.horizArea3.Marks.Symbol.Shadow.Height = 1
        Me.horizArea3.Marks.Symbol.Shadow.Visible = True
        Me.horizArea3.Marks.Symbol.Shadow.Width = 1
        ' 
        ' horizArea3.Pointer
        ' 
        ' 
        ' horizArea3.Pointer.Brush
        ' 
        Me.horizArea3.Pointer.Brush.Color = System.Drawing.Color.Yellow
        Me.horizArea3.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.horizArea3.Title = "horizArea3"
        ' 
        ' horizArea3.XValues
        ' 
        Me.horizArea3.XValues.DataMember = "X"
        ' 
        ' horizArea3.YValues
        ' 
        Me.horizArea3.YValues.DataMember = "Y"
        Me.horizArea3.YValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' label1
        ' 
        Me.label1.Location = New System.Drawing.Point(8, 8)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(56, 23)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Layout:"
        ' 
        ' CBLayout
        ' 
        Me.CBLayout.Items.AddRange(New Object() {"3D", "Stacked", "Stacked 100%"})
        Me.CBLayout.Location = New System.Drawing.Point(51, 6)
        Me.CBLayout.Name = "CBLayout"
        Me.CBLayout.Size = New System.Drawing.Size(93, 21)
        Me.CBLayout.TabIndex = 1
        AddHandler Me.CBLayout.SelectedIndexChanged, AddressOf Me.CBLayout_SelectedIndexChanged
        ' 
        ' CBStairs
        ' 
        Me.CBStairs.Location = New System.Drawing.Point(161, 6)
        Me.CBStairs.Name = "CBStairs"
        Me.CBStairs.Size = New System.Drawing.Size(79, 24)
        Me.CBStairs.TabIndex = 2
        Me.CBStairs.Text = "Stairs"
        AddHandler Me.CBStairs.Click, AddressOf Me.CBStairs_Click
        ' 
        ' CB3D
        ' 
        Me.CB3D.Checked = True
        Me.CB3D.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CB3D.Location = New System.Drawing.Point(234, 7)
        Me.CB3D.Name = "CB3D"
        Me.CB3D.Size = New System.Drawing.Size(79, 24)
        Me.CB3D.TabIndex = 3
        Me.CB3D.Text = "3D"
        AddHandler Me.CB3D.Click, AddressOf Me.CB3D_Click
        ' 
        ' BEdit
        ' 
        Me.BEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BEdit.Location = New System.Drawing.Point(344, 8)
        Me.BEdit.Name = "BEdit"
        Me.BEdit.TabIndex = 4
        Me.BEdit.Text = "Edit..."
        AddHandler Me.BEdit.Click, AddressOf Me.BEdit_Click
        ' 
        ' gridBand1
        ' 
        Me.gridBand1.Axis = Me.tChart1.Axes.Bottom
        ' 
        ' gridBand1.Band1
        ' 
        Me.gridBand1.Band1.Color = System.Drawing.Color.FromArgb(CType(127, System.Byte), CType(224, System.Byte), CType(224, System.Byte), CType(224, System.Byte))
        ' 
        ' gridBand1.Band2
        ' 
        Me.gridBand1.Band2.Color = System.Drawing.Color.FromArgb(CType(127, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        ' 
        ' SeriesType_HorizArea
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(440, 317)
        Me.Name = "SeriesType_HorizArea"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub 'New 
#End Region


    Private Sub CBLayout_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Select Case CBLayout.SelectedIndex
            Case 0
                horizArea1.MultiArea = Steema.TeeChart.Styles.MultiAreas.None
                horizArea2.MultiArea = Steema.TeeChart.Styles.MultiAreas.None
                horizArea3.MultiArea = Steema.TeeChart.Styles.MultiAreas.None
            Case 1
                horizArea1.MultiArea = Steema.TeeChart.Styles.MultiAreas.Stacked
                horizArea2.MultiArea = Steema.TeeChart.Styles.MultiAreas.Stacked
                horizArea3.MultiArea = Steema.TeeChart.Styles.MultiAreas.Stacked
            Case 2
                horizArea1.MultiArea = Steema.TeeChart.Styles.MultiAreas.Stacked100
                horizArea2.MultiArea = Steema.TeeChart.Styles.MultiAreas.Stacked100
                horizArea3.MultiArea = Steema.TeeChart.Styles.MultiAreas.Stacked100
        End Select
        horizArea1.Marks.Visible = horizArea1.MultiArea = Steema.TeeChart.Styles.MultiAreas.None
        horizArea2.Marks.Visible = horizArea2.MultiArea = Steema.TeeChart.Styles.MultiAreas.None
        horizArea3.Marks.Visible = horizArea3.MultiArea = Steema.TeeChart.Styles.MultiAreas.None
    End Sub 'CBLayout_SelectedIndexChanged


    Private Sub CBStairs_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        horizArea1.Stairs = CBStairs.Checked
        horizArea2.Stairs = CBStairs.Checked
        horizArea3.Stairs = CBStairs.Checked
    End Sub 'CBStairs_Click


    Private Sub CB3D_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        tChart1.Aspect.View3D = CB3D.Checked
    End Sub 'CB3D_Click


    Private Sub BEdit_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        tChart1.ShowEditor()
    End Sub 'BEdit_Click
End Class 'SeriesType_HorizArea