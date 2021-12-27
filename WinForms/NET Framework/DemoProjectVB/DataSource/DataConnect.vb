
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data

Imports System.Windows.Forms




Public Class DataConnect


    Inherits Steema.TeeChart.Samples.BaseForm
    Private components As System.ComponentModel.IContainer = Nothing

    'variables
    Private sourceTable As DataTable
    Private colXData As DataColumn
    Private colYData As DataColumn
    Private colDesc As DataColumn
    Private barSeries1 As Steema.TeeChart.Styles.Bar
    Private gridBand1 As Steema.TeeChart.Tools.GridBand
    Private colColor As DataColumn


    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
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
    '/ Required method for Designer support - do not moify
    '/ the contents of this method with the code editor.
    '/ </summary>
    Private checkBox1 As System.Windows.Forms.CheckBox
    Private checkBox2 As System.Windows.Forms.CheckBox
    Private Sub InitializeComponent()
        Me.barSeries1 = New Steema.TeeChart.Styles.Bar
        Me.checkBox1 = New System.Windows.Forms.CheckBox
        Me.checkBox2 = New System.Windows.Forms.CheckBox
        Me.gridBand1 = New Steema.TeeChart.Tools.GridBand
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()

        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(592, 73)
        Me.textBox1.Text = ("This example demonstrates how to connect a TeeChart XY Series to a DataTable at r" + _
            ("untime." & vbCrLf & vbCrLf & "Check/uncheck the checkboxes to include/exclude the X value and Label" + _
            " DataTable fields from the Series."))
        '
        'tChart1
        '
        '
        'tChart1.Aspect
        '
        Me.tChart1.Aspect.ElevationFloat = 345
        Me.tChart1.Aspect.RotationFloat = 345
        Me.tChart1.Aspect.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality
        Me.tChart1.Aspect.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        '
        'tChart1.Axes
        '
        '
        'tChart1.Axes.Bottom
        '
        Me.tChart1.Axes.Bottom.Automatic = True
        '
        'tChart1.Axes.Bottom.Grid
        '
        Me.tChart1.Axes.Bottom.Grid.ZPosition = 0
        '
        'tChart1.Axes.Depth
        '
        Me.tChart1.Axes.Depth.Automatic = True
        '
        'tChart1.Axes.Depth.Grid
        '
        Me.tChart1.Axes.Depth.Grid.ZPosition = 0
        '
        'tChart1.Axes.DepthTop
        '
        Me.tChart1.Axes.DepthTop.Automatic = True
        '
        'tChart1.Axes.DepthTop.Grid
        '
        Me.tChart1.Axes.DepthTop.Grid.ZPosition = 0
        '
        'tChart1.Axes.Left
        '
        Me.tChart1.Axes.Left.Automatic = True
        '
        'tChart1.Axes.Left.Grid
        '
        Me.tChart1.Axes.Left.Grid.ZPosition = 0
        '
        'tChart1.Axes.Right
        '
        Me.tChart1.Axes.Right.Automatic = True
        '
        'tChart1.Axes.Right.Grid
        '
        Me.tChart1.Axes.Right.Grid.ZPosition = 0
        '
        'tChart1.Axes.Top
        '
        Me.tChart1.Axes.Top.Automatic = True
        '
        'tChart1.Axes.Top.Grid
        '
        Me.tChart1.Axes.Top.Grid.ZPosition = 0
        '
        'tChart1.Header
        '
        Me.tChart1.Header.Lines = New String() {"tChart1"}
        '
        'tChart1.Legend
        '
        '
        'tChart1.Legend.Shadow
        '
        Me.tChart1.Legend.Shadow.Visible = True
        '
        'tChart1.Legend.Title
        '
        '
        'tChart1.Legend.Title.Font
        '
        Me.tChart1.Legend.Title.Font.Bold = True
        '
        'tChart1.Legend.Title.Pen
        '
        Me.tChart1.Legend.Title.Pen.Visible = False
        Me.tChart1.Location = New System.Drawing.Point(0, 104)
        Me.tChart1.Name = "tChart1"
        '
        'tChart1.Panel
        '
        '
        'tChart1.Panel.Brush
        '
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(254, Byte), CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.tChart1.Series.Add(Me.barSeries1)
        Me.tChart1.Size = New System.Drawing.Size(592, 264)
        Me.tChart1.Tools.Add(Me.gridBand1)
        '
        'tChart1.Walls
        '
        '
        'tChart1.Walls.Back
        '
        Me.tChart1.Walls.Back.AutoHide = False
        '
        'tChart1.Walls.Back.Brush
        '
        Me.tChart1.Walls.Back.Brush.Color = System.Drawing.Color.FromArgb(CType(254, Byte), CType(255, Byte), CType(255, Byte), CType(255, Byte))
        Me.tChart1.Walls.Back.Transparent = False
        '
        'tChart1.Walls.Bottom
        '
        Me.tChart1.Walls.Bottom.AutoHide = False
        '
        'tChart1.Walls.Bottom.Pen
        '
        Me.tChart1.Walls.Bottom.Pen.Visible = False
        Me.tChart1.Walls.Bottom.Size = 5
        '
        'tChart1.Walls.Left
        '
        Me.tChart1.Walls.Left.AutoHide = False
        '
        'tChart1.Walls.Left.Pen
        '
        Me.tChart1.Walls.Left.Pen.Visible = False
        Me.tChart1.Walls.Left.Size = 5
        '
        'tChart1.Walls.Right
        '
        Me.tChart1.Walls.Right.AutoHide = False
        '
        'textBox1
        '
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(592, 73)
        '
        'panel1
        '
        Me.panel1.Controls.Add(Me.checkBox2)
        Me.panel1.Controls.Add(Me.checkBox1)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(592, 31)
        '
        'barSeries1
        '
        '
        'barSeries1.Brush
        '
        Me.barSeries1.Brush.Color = System.Drawing.Color.Red
        Me.barSeries1.Cursor = System.Windows.Forms.Cursors.Cross
        '
        'barSeries1.Marks
        '
        '
        'barSeries1.Marks.Callout
        '
        Me.barSeries1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None
        Me.barSeries1.Marks.Callout.ArrowHeadSize = 8
        '
        'barSeries1.Marks.Callout.Brush
        '
        Me.barSeries1.Marks.Callout.Brush.Color = System.Drawing.Color.Black
        Me.barSeries1.Marks.Callout.Distance = 0
        Me.barSeries1.Marks.Callout.Draw3D = False
        Me.barSeries1.Marks.Callout.Length = 20
        Me.barSeries1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        '
        'barSeries1.Marks.Shadow
        '
        Me.barSeries1.Marks.Shadow.Visible = True
        '
        'barSeries1.Marks.Symbol
        '
        '
        'barSeries1.Marks.Symbol.Shadow
        '
        Me.barSeries1.Marks.Symbol.Shadow.Visible = True
        Me.barSeries1.Title = "barSeries1"
        '
        'barSeries1.XValues
        '
        Me.barSeries1.XValues.DataMember = "X"
        Me.barSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        '
        'barSeries1.YValues
        '
        Me.barSeries1.YValues.DataMember = "Bar"
        '
        'checkBox1
        '
        Me.checkBox1.Checked = True
        Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox1.Location = New System.Drawing.Point(16, 6)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.TabIndex = 0
        Me.checkBox1.Text = "Include &Labels"
        AddHandler Me.checkBox1.CheckedChanged, AddressOf Me.checkBox1_CheckedChanged
        '
        'checkBox2
        '
        Me.checkBox2.Checked = True
        Me.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox2.Location = New System.Drawing.Point(120, 6)
        Me.checkBox2.Name = "checkBox2"
        Me.checkBox2.Size = New System.Drawing.Size(120, 24)
        Me.checkBox2.TabIndex = 1
        Me.checkBox2.Text = "Include &XValues"
        AddHandler Me.checkBox2.CheckedChanged, AddressOf Me.checkBox2_CheckedChanged
        '
        'gridBand1
        '
        Me.gridBand1.Axis = Me.tChart1.Axes.Left
        '
        'gridBand1.Band1
        '
        Me.gridBand1.Band1.Color = System.Drawing.Color.FromArgb(CType(127, Byte), CType(224, Byte), CType(224, Byte), CType(224, Byte))
        '
        'gridBand1.Band2
        '
        Me.gridBand1.Band2.Color = System.Drawing.Color.FromArgb(CType(127, Byte), CType(255, Byte), CType(255, Byte), CType(255, Byte))
        '
        'DataConnect
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(592, 368)
        Me.Name = "DataConnect"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub 'InitializeComponent 
#End Region


    Private Sub DataConnect_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tChart1.Axes.Bottom.Labels.Style = AxisLabelStyle.Value
        CreateTable()
        LoadData()
    End Sub 'DataConnect_Load


    Private Sub CreateTable()
        Dim r As New Random(255)

        ' Create DataTable
        sourceTable = New DataTable("sourceTable")
        colXData = New DataColumn("XData", Type.GetType("System.Double"))
        colYData = New DataColumn("YData", Type.GetType("System.Double"))
        colDesc = New DataColumn("Desc", Type.GetType("System.String"))
        colColor = New DataColumn("Color", Type.GetType("System.Object"))

        sourceTable.Columns.Add(colXData)
        sourceTable.Columns.Add(colYData)
        sourceTable.Columns.Add(colDesc)
        sourceTable.Columns.Add(colColor)

        ' Add table items.
        Dim NewRow As DataRow
        Dim lastVal As Double = 0
        Dim i As Integer
        For i = 0 To 9
            Dim cc As Color = Color.FromArgb(r.Next(255), r.Next(255), r.Next(255))
            NewRow = sourceTable.NewRow()
            NewRow("Desc") = "Label" + i.ToString()
            NewRow("XData") = lastVal
            NewRow("YData") = r.Next(10)
            NewRow("Color") = cc
            sourceTable.Rows.Add(NewRow)
            lastVal = lastVal + 5 + r.Next(5)
        Next i
    End Sub 'CreateTable


    Private Sub LoadData()
        tChart1(0).Clear()

        'include Labels
        If checkBox1.Checked Then
            tChart1(0).LabelMember = colDesc.ToString()
        Else
            tChart1(0).LabelMember = ""
        End If
        'include XValues
        If checkBox2.Checked Then
            tChart1(0).XValues.DataMember = colXData.ToString()
        Else
            tChart1(0).XValues.DataMember = ""
        End If
        tChart1(0).ColorMember = colColor.ToString()
        tChart1(0).YValues.DataMember = colYData.ToString()
        tChart1(0).DataSource = sourceTable
    End Sub 'LoadData


    Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) 'Handles checkBox1.CheckedChanged
        LoadData()
        tChart1(0).CheckDataSource()
    End Sub 'checkBox1_CheckedChanged


    Private Sub checkBox2_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) 'Handles checkBox2.CheckedChanged
        LoadData()
        tChart1(0).CheckDataSource()
    End Sub 'checkBox2_CheckedChanged
End Class 'DataConnect 
