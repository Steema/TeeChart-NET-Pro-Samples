
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Windows.Forms




Public Class DateTimeData
    Inherits Steema.TeeChart.Samples.BaseForm
    'variables
    Private sourceTable As DataTable
    Private colDate As DataColumn
    Private colDateAsDbl As DataColumn
    Private colOpen As DataColumn
    Private colHigh As DataColumn
    Private colLow As DataColumn
    Private colClose As DataColumn
    Private checkBox1 As System.Windows.Forms.CheckBox
    
    Private components As System.ComponentModel.IContainer = Nothing
    
    
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
    '/ Required method for Designer support - do not modify
    '/ the contents of this method with the code editor.
    '/ </summary>
    Private Sub InitializeComponent()
        Me.checkBox1 = New System.Windows.Forms.CheckBox
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(592, 40)
        Me.textBox1.Text = "DateTime fields may be passed to a Series directly as DateTime values or alternat" + "ively as doubles (OADateTime)."
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.checkBox1)
        Me.panel1.Location = New System.Drawing.Point(0, 40)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(592, 31)
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
        Me.tChart1.Location = New System.Drawing.Point(0, 71)
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Brush
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.tChart1.Size = New System.Drawing.Size(592, 297)
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
        ' checkBox1
        ' 
        Me.checkBox1.Checked = True
        Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox1.Location = New System.Drawing.Point(8, 6)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(360, 24)
        Me.checkBox1.TabIndex = 0
        Me.checkBox1.Text = "When checked uses &DateTime, if not it uses the Date as doubles"
        AddHandler Me.checkBox1.CheckedChanged, AddressOf Me.checkBox1_CheckedChanged
        ' 
        ' DateTimeData
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(592, 368)
        Me.Name = "DateTimeData"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub 'InitializeComponent 
#End Region


    Private Sub DateTimeData_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tChart1.Axes.Bottom.Labels.Angle = 90
        CreateTable()
        LoadData()
    End Sub 'DateTimeData_Load


    Private Sub CreateTable()
        Dim r As New Random(255)

        ' Create DataTable
        sourceTable = New DataTable("sourceTable")
        colDate = New DataColumn(Texts.ValuesDate, Type.GetType("System.DateTime"))
        colDateAsDbl = New DataColumn("DateAsDbl", Type.GetType("System.Double"))
        colOpen = New DataColumn(Texts.ValuesOpen, Type.GetType("System.Double"))
        colHigh = New DataColumn(Texts.ValuesHigh, Type.GetType("System.Double"))
        colLow = New DataColumn(Texts.ValuesLow, Type.GetType("System.Double"))
        colClose = New DataColumn(Texts.ValuesClose, Type.GetType("System.Double"))

        sourceTable.Columns.Add(colDate)
        sourceTable.Columns.Add(colDateAsDbl)
        sourceTable.Columns.Add(colOpen)
        sourceTable.Columns.Add(colHigh)
        sourceTable.Columns.Add(colLow)
        sourceTable.Columns.Add(colClose)

        'add some data
        Dim highVal As Double
        Dim lowVal As Double
        Dim lastClose As Double = r.Next(10)
        Dim NewRow As DataRow
        Dim i As Integer
        For i = 0 To 19
            Dim tmpVar As Double = r.Next(10)
            NewRow = sourceTable.NewRow()
            NewRow(Texts.ValuesDate) = DateTime.FromOADate(i + 37550)
            NewRow("DateAsDbl") = i + 37550 'OADate
            NewRow(Texts.ValuesOpen) = lastClose
            highVal = lastClose + 1 + r.Next(10)
            NewRow(Texts.ValuesHigh) = highVal
            lowVal = lastClose - 1 - r.Next(10)
            NewRow(Texts.ValuesLow) = lowVal
            lastClose = lowVal + r.Next(Fix(highVal - lowVal))
            NewRow(Texts.ValuesClose) = lastClose

            sourceTable.Rows.Add(NewRow)
        Next i
    End Sub 'CreateTable



    Private Sub LoadData()
        tChart1.Series.RemoveAllSeries()

        Dim cs As New Styles.Candle
        tChart1.Series.Add(cs)

        If checkBox1.Checked Then
            For Each v As Styles.ValueList In cs.ValuesLists
                v.DataMember = v.Name 'as column name is same as ValueList name
            Next v
        Else
            For Each v As Styles.ValueList In cs.ValuesLists
                If v.Name <> "Date" Then
                    v.DataMember = v.Name
                End If
            Next v
            cs.DateValues.DataMember = "DateAsDbl"
        End If

        Dim localView As New DataView(sourceTable)

        tChart1(0).DataSource = localView
    End Sub 'LoadData


    Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        LoadData()
    End Sub 'checkBox1_CheckedChanged


    Private Sub tChart1_AfterDraw(ByVal sender As Object, ByVal g As Steema.TeeChart.Drawing.Graphics3D) Handles tChart1.AfterDraw
        g.Font.Color = Color.Blue
        g.Font.Bold = True
        g.Font.Size = 11

        g.TextAlign = StringAlignment.Near

        If checkBox1.Checked Then
            g.TextOut(10, 10, "DateTime values")
        Else
            g.TextOut(10, 10, "DateTime as double")
        End If
    End Sub 'tChart1_AfterDraw
End Class 'DateTimeData
