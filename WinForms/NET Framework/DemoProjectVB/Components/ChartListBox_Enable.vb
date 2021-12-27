
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms


Public Class ChartListBoxEnable
    Inherits Steema.TeeChart.Samples.BaseNoChart
    Private groupBox1 As System.Windows.Forms.GroupBox
    Private CBColor As System.Windows.Forms.CheckBox
    Private CBType As System.Windows.Forms.CheckBox
    Private CBInsert As System.Windows.Forms.CheckBox
    Private CBDelete As System.Windows.Forms.CheckBox
    Private CBDrag As System.Windows.Forms.CheckBox
    Private pLeft As System.Windows.Forms.Panel
    Private pRight As System.Windows.Forms.Panel
    Private splitter1 As System.Windows.Forms.Splitter
    Private tChart1 As Steema.TeeChart.TChart
    Private chartListBox1 As Steema.TeeChart.ChartListBox
    Private area1 As Steema.TeeChart.Styles.Area
    Private bar1 As Steema.TeeChart.Styles.Bar
    Private bubble1 As Steema.TeeChart.Styles.Bubble
    Private line1 As Steema.TeeChart.Styles.Line
    Private components As System.ComponentModel.IContainer = Nothing
    
    Public Sub New() ' This call is required by the Windows Form Designer.
        InitializeComponent()

        For Each s As Steema.TeeChart.Styles.Series In tChart1.Series
            s.FillSampleValues()
        Next

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
        Me.components = New System.ComponentModel.Container
        Me.groupBox1 = New System.Windows.Forms.GroupBox
        Me.CBDrag = New System.Windows.Forms.CheckBox
        Me.CBDelete = New System.Windows.Forms.CheckBox
        Me.CBInsert = New System.Windows.Forms.CheckBox
        Me.CBType = New System.Windows.Forms.CheckBox
        Me.CBColor = New System.Windows.Forms.CheckBox
        Me.pLeft = New System.Windows.Forms.Panel
        Me.chartListBox1 = New Steema.TeeChart.ChartListBox(Me.components)
        Me.tChart1 = New Steema.TeeChart.TChart
        Me.area1 = New Steema.TeeChart.Styles.Area
        Me.bar1 = New Steema.TeeChart.Styles.Bar
        Me.bubble1 = New Steema.TeeChart.Styles.Bubble
        Me.line1 = New Steema.TeeChart.Styles.Line
        Me.pRight = New System.Windows.Forms.Panel
        Me.splitter1 = New System.Windows.Forms.Splitter
        Me.panel1.SuspendLayout()
        Me.panel2.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        Me.pLeft.SuspendLayout()
        Me.pRight.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Text = "The ChartListBox component now has additional properties to control if the" + vbCr + vbLf + "end-user can change a Series type or Series color, if Series can be" + vbCr + vbLf + "re-ordered by dragging, and if Series can be deleted pressing the Del key." + vbCr + vbLf + vbCr + vbLf + "Example: chartListBox1.EnableChangeColor=false" + vbCr + vbLf + vbCr + vbLf + "ChartListBox now also synchronizes when Series are added or deleted programatically"
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.groupBox1)
        Me.panel1.Name = "panel1"
        ' 
        ' panel2
        ' 
        Me.panel2.Controls.Add(Me.splitter1)
        Me.panel2.Controls.Add(Me.pRight)
        Me.panel2.Controls.Add(Me.pLeft)
        Me.panel2.Name = "panel2"
        ' 
        ' groupBox1
        ' 
        Me.groupBox1.Controls.Add(Me.CBDrag)
        Me.groupBox1.Controls.Add(Me.CBDelete)
        Me.groupBox1.Controls.Add(Me.CBInsert)
        Me.groupBox1.Controls.Add(Me.CBType)
        Me.groupBox1.Controls.Add(Me.CBColor)
        Me.groupBox1.Location = New System.Drawing.Point(2, 1)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(421, 39)
        Me.groupBox1.TabIndex = 0
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Enable"
        ' 
        ' CBDrag
        ' 
        Me.CBDrag.Checked = True
        Me.CBDrag.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CBDrag.Location = New System.Drawing.Point(331, 14)
        Me.CBDrag.Name = "CBDrag"
        Me.CBDrag.Size = New System.Drawing.Size(83, 19)
        Me.CBDrag.TabIndex = 4
        Me.CBDrag.Text = "Drag Series"
        AddHandler Me.CBDrag.Click, AddressOf Me.CBDrag_Click
        ' 
        ' CBDelete
        ' 
        Me.CBDelete.Checked = True
        Me.CBDelete.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CBDelete.Location = New System.Drawing.Point(255, 14)
        Me.CBDelete.Name = "CBDelete"
        Me.CBDelete.Size = New System.Drawing.Size(81, 19)
        Me.CBDelete.TabIndex = 3
        Me.CBDelete.Text = "Delete Key"
        AddHandler Me.CBDelete.Click, AddressOf Me.CBDelete_Click
        ' 
        ' CBInsert
        ' 
        Me.CBInsert.Checked = True
        Me.CBInsert.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CBInsert.Location = New System.Drawing.Point(186, 14)
        Me.CBInsert.Name = "CBInsert"
        Me.CBInsert.Size = New System.Drawing.Size(74, 19)
        Me.CBInsert.TabIndex = 2
        Me.CBInsert.Text = "Insert Key"
        AddHandler Me.CBInsert.Click, AddressOf Me.CBInsert_Click
        ' 
        ' CBType
        ' 
        Me.CBType.Checked = True
        Me.CBType.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CBType.Location = New System.Drawing.Point(96, 14)
        Me.CBType.Name = "CBType"
        Me.CBType.Size = New System.Drawing.Size(93, 19)
        Me.CBType.TabIndex = 1
        Me.CBType.Text = "Change Type"
        AddHandler Me.CBType.Click, AddressOf Me.CBType_Click
        ' 
        ' CBColor
        ' 
        Me.CBColor.Checked = True
        Me.CBColor.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CBColor.Location = New System.Drawing.Point(8, 14)
        Me.CBColor.Name = "CBColor"
        Me.CBColor.Size = New System.Drawing.Size(93, 19)
        Me.CBColor.TabIndex = 0
        Me.CBColor.Text = "Change Color"
        AddHandler Me.CBColor.Click, AddressOf Me.CBColor_Click
        ' 
        ' pLeft
        ' 
        Me.pLeft.BackColor = System.Drawing.Color.White
        Me.pLeft.Controls.Add(Me.chartListBox1)
        Me.pLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.pLeft.Location = New System.Drawing.Point(0, 0)
        Me.pLeft.Name = "pLeft"
        Me.pLeft.Size = New System.Drawing.Size(176, 154)
        Me.pLeft.TabIndex = 0
        ' 
        ' chartListBox1
        ' 
        Me.chartListBox1.AllowDrop = True
        Me.chartListBox1.Chart = Me.tChart1
        Me.chartListBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chartListBox1.Location = New System.Drawing.Point(0, 0)
        Me.chartListBox1.Name = "chartListBox1"
        Me.chartListBox1.OtherItems = Nothing
        Me.chartListBox1.Size = New System.Drawing.Size(176, 148)
        Me.chartListBox1.TabIndex = 0
        ' 
        ' tChart1
        ' 
        ' 
        ' tChart1.Aspect
        ' 
        Me.tChart1.Aspect.ColorPaletteIndex = 3
        Me.tChart1.Aspect.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality
        Me.tChart1.Aspect.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        Me.tChart1.BackColor = System.Drawing.Color.Red
        Me.tChart1.Dock = System.Windows.Forms.DockStyle.Fill
        ' 
        ' tChart1.Header
        ' 
        Me.tChart1.Header.Lines = New String() {"TeeChart"}
        Me.tChart1.Location = New System.Drawing.Point(0, 0)
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
        Me.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(225, System.Byte), CType(225, System.Byte), CType(255, System.Byte))
        Me.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        ' 
        ' tChart1.Panel.Gradient
        ' 
        Me.tChart1.Panel.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(225, System.Byte), CType(225, System.Byte), CType(255, System.Byte))
        Me.tChart1.Panel.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.tChart1.Series.Add(Me.area1)
        Me.tChart1.Series.Add(Me.bar1)
        Me.tChart1.Series.Add(Me.bubble1)
        Me.tChart1.Series.Add(Me.line1)
        Me.tChart1.Size = New System.Drawing.Size(250, 154)
        Me.tChart1.TabIndex = 0
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
        ' area1
        ' 
        ' 
        ' area1.AreaBrush
        ' 
        Me.area1.AreaBrush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(128, System.Byte), CType(0, System.Byte))
        ' 
        ' area1.AreaLines
        ' 
        Me.area1.AreaLines.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(153, System.Byte), CType(77, System.Byte), CType(0, System.Byte))
        ' 
        ' area1.Brush
        ' 
        Me.area1.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(128, System.Byte), CType(0, System.Byte))
        ' 
        ' area1.LinePen
        ' 
        Me.area1.LinePen.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(153, System.Byte), CType(77, System.Byte), CType(0, System.Byte))
        ' 
        ' area1.Marks
        ' 
        ' 
        ' area1.Marks.Font
        ' 
        ' 
        ' area1.Marks.Font.Brush
        ' 
        Me.area1.Marks.Font.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(64, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        Me.area1.Marks.Font.Size = 14
        ' 
        ' area1.Marks.Pen
        ' 
        Me.area1.Marks.Pen.Visible = False
        ' 
        ' area1.Marks.Symbol
        ' 
        ' 
        ' area1.Marks.Symbol.Shadow
        ' 
        Me.area1.Marks.Symbol.Shadow.Height = 1
        Me.area1.Marks.Symbol.Shadow.Visible = True
        Me.area1.Marks.Symbol.Shadow.Width = 1
        ' 
        ' area1.Pointer
        ' 
        ' 
        ' area1.Pointer.Brush
        ' 
        Me.area1.Pointer.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(0, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        Me.area1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.area1.Title = "area1"
        ' 
        ' area1.XValues
        ' 
        Me.area1.XValues.DataMember = "X"
        Me.area1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' area1.YValues
        ' 
        Me.area1.YValues.DataMember = "Y"
        ' 
        ' bar1
        ' 
        ' 
        ' bar1.Brush
        ' 
        Me.bar1.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(128, System.Byte))
        ' 
        ' bar1.Marks
        ' 
        ' 
        ' bar1.Marks.Font
        ' 
        ' 
        ' bar1.Marks.Font.Brush
        ' 
        Me.bar1.Marks.Font.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(64, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        Me.bar1.Marks.Font.Size = 14
        ' 
        ' bar1.Marks.Pen
        ' 
        Me.bar1.Marks.Pen.Visible = False
        ' 
        ' bar1.Marks.Symbol
        ' 
        ' 
        ' bar1.Marks.Symbol.Shadow
        ' 
        Me.bar1.Marks.Symbol.Shadow.Height = 1
        Me.bar1.Marks.Symbol.Shadow.Visible = True
        Me.bar1.Marks.Symbol.Shadow.Width = 1
        Me.bar1.Marks.Transparent = True
        ' 
        ' bar1.Pen
        ' 
        Me.bar1.Pen.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(153, System.Byte), CType(153, System.Byte), CType(77, System.Byte))
        Me.bar1.Title = "bar2"
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
        ' bubble1
        ' 
        Me.bubble1.ColorEach = False
        Me.bubble1.LabelMember = "Labels"
        ' 
        ' bubble1.LinePen
        ' 
        Me.bubble1.LinePen.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(77, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        ' 
        ' bubble1.Marks
        ' 
        ' 
        ' bubble1.Marks.Symbol
        ' 
        ' 
        ' bubble1.Marks.Symbol.Shadow
        ' 
        Me.bubble1.Marks.Symbol.Shadow.Height = 1
        Me.bubble1.Marks.Symbol.Shadow.Visible = True
        Me.bubble1.Marks.Symbol.Shadow.Width = 1
        Me.bubble1.Marks.Transparent = True
        ' 
        ' bubble1.Pointer
        ' 
        ' 
        ' bubble1.Pointer.Brush
        ' 
        Me.bubble1.Pointer.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(128, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        Me.bubble1.Pointer.InflateMargins = False
        ' 
        ' bubble1.Pointer.Pen
        ' 
        Me.bubble1.Pointer.Pen.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(77, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        Me.bubble1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Sphere
        Me.bubble1.Title = "bubble3"
        ' 
        ' bubble1.XValues
        ' 
        Me.bubble1.XValues.DataMember = "X"
        Me.bubble1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' bubble1.YValues
        ' 
        Me.bubble1.YValues.DataMember = "Y"
        ' 
        ' line1
        ' 
        ' 
        ' line1.Brush
        ' 
        Me.line1.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(0, System.Byte), CType(0, System.Byte), CType(64, System.Byte))
        ' 
        ' line1.LinePen
        ' 
        Me.line1.LinePen.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(0, System.Byte), CType(0, System.Byte), CType(38, System.Byte))
        ' 
        ' line1.Marks
        ' 
        ' 
        ' line1.Marks.Symbol
        ' 
        ' 
        ' line1.Marks.Symbol.Shadow
        ' 
        Me.line1.Marks.Symbol.Shadow.Height = 1
        Me.line1.Marks.Symbol.Shadow.Visible = True
        Me.line1.Marks.Symbol.Shadow.Width = 1
        ' 
        ' line1.Pointer
        ' 
        ' 
        ' line1.Pointer.Brush
        ' 
        Me.line1.Pointer.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(0, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        Me.line1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.line1.Title = "line4"
        ' 
        ' line1.XValues
        ' 
        Me.line1.XValues.DataMember = "X"
        Me.line1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' line1.YValues
        ' 
        Me.line1.YValues.DataMember = "Y"
        ' 
        ' pRight
        ' 
        Me.pRight.BackColor = System.Drawing.Color.White
        Me.pRight.Controls.Add(Me.tChart1)
        Me.pRight.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pRight.Location = New System.Drawing.Point(176, 0)
        Me.pRight.Name = "pRight"
        Me.pRight.Size = New System.Drawing.Size(250, 154)
        Me.pRight.TabIndex = 1
        ' 
        ' splitter1
        ' 
        Me.splitter1.Location = New System.Drawing.Point(176, 0)
        Me.splitter1.Name = "splitter1"
        Me.splitter1.Size = New System.Drawing.Size(3, 154)
        Me.splitter1.TabIndex = 0
        Me.splitter1.TabStop = False
        ' 
        ' ChartListBoxEnable
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(426, 258)
        Me.Name = "ChartListBoxEnable"
        Me.panel1.ResumeLayout(False)
        Me.panel2.ResumeLayout(False)
        Me.groupBox1.ResumeLayout(False)
        Me.pLeft.ResumeLayout(False)
        Me.pRight.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub 'New 
#End Region


    Private Sub CBColor_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        chartListBox1.EnableChangeColor = CBColor.Checked
    End Sub 'CBColor_Click


    Private Sub CBType_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        chartListBox1.EnableChangeType = CBType.Checked
    End Sub 'CBType_Click


    Private Sub CBInsert_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        chartListBox1.AllowAddSeries = CBInsert.Checked
    End Sub 'CBInsert_Click


    Private Sub CBDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        chartListBox1.AllowDeleteSeries = CBDelete.Checked
    End Sub 'CBDelete_Click


    Private Sub CBDrag_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        chartListBox1.EnableDragSeries = CBDrag.Checked
    End Sub 'CBDrag_Click
End Class 'ChartListBoxEnable