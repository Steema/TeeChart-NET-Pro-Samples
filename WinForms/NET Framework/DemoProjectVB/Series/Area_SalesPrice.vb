Imports System
#If (VS2005) Then
Imports System.Collections.Generic
#End If
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Public Class Area_SalesPrice
    Inherits BaseForm
    Private console() As String = {"Wii", "PS3", "X360", "PSP", "DS"}
    Private units() As Integer = {217235, 162239, 101889, 161156, 609136}
    Private price() As Double = {249, 299, 249, 169, 149}
    Private area1 As Steema.TeeChart.Styles.Area
    Private annotation1 As Steema.TeeChart.Tools.Annotation
    Private annotation2 As Steema.TeeChart.Tools.Annotation
    Private average As Steema.TeeChart.Styles.Line
    '/ <summary>
    '/ Required designer variable.
    '/ </summary>
    Private components As System.ComponentModel.IContainer = Nothing
    '/<summary>
    '/Clean up any resources being used.
    '/</summary>
    '/<param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If (Not (components) Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub
#Region "Windows Form Designer generated code"
    '/ <summary>
    '/ Required method for Designer support - do not modify
    '/the contents of this method with the code editor.
    '/</summary>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Area_SalesPrice))
        Me.area1 = New Steema.TeeChart.Styles.Area
        Me.chartContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'textBox1
        '
        Me.textBox1.Text = resources.GetString("textBox1.Text")
        '
        'panel1
        '
        Me.panel1.Size = New System.Drawing.Size(440, 10)
        '
        'tChart1
        '
        '
        '
        '
        Me.tChart1.Aspect.ZOffset = 0
        Me.tChart1.Series.Add(Me.area1)
        Me.tChart1.Size = New System.Drawing.Size(440, 234)
        '
        'chartContainer
        '
        Me.chartContainer.Location = New System.Drawing.Point(0, 83)
        Me.chartContainer.Size = New System.Drawing.Size(440, 234)
        '
        'area1
        '
        '
        '
        '
        Me.area1.AreaBrush.Color = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(163, Byte), Integer))
        '
        '
        '
        Me.area1.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(163, Byte), Integer))
        '
        '
        '
        Me.area1.AreaLines.Color = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(98, Byte), Integer))
        '
        '
        '
        Me.area1.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.area1.Color = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.area1.ColorEach = False
        '
        '
        '
        Me.area1.LinePen.Color = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(98, Byte), Integer))
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
        '
        '
        '
        Me.area1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.area1.Title = "area1"
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
        'Area_SalesPrice
        '
        Me.ClientSize = New System.Drawing.Size(440, 317)
        Me.Name = "Area_SalesPrice"
        Me.chartContainer.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
#End Region

    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        InitializeChart()
    End Sub
    Dim chartInitialized As Boolean = False
    Private Sub InitializeChart()
        area1.Stairs = True
        area1.ColorEach = True
        area1.Marks.Visible = True
        area1.Marks.Style = Steema.TeeChart.Styles.MarksStyles.Value
        area1.Marks.Transparent = True
        area1.Marks.Font.Bold = True
        AddHandler area1.GetSeriesMark, AddressOf area1_GetSeriesMark
        FillSeries()
        tChart1.Aspect.View3D = False
        tChart1.Legend.Visible = False
        tChart1.Header.Visible = True
        tChart1.Header.Text = "Gaming consoles sales 1st half 2009 in Spain"
        tChart1.Header.Font.Size = 10
        tChart1.Axes.Left.Title.Text = "Price (€)"
        tChart1.Axes.Left.Title.Font.Bold = True
        tChart1.Axes.Left.SetMinMax(0, 350)
        tChart1.Axes.Left.Increment = 50
        tChart1.Axes.Bottom.Grid.Visible = False
        AddCustomLabels()
        'AddDataTable()

        AddHandler tChart1.AfterDraw, AddressOf tChart1_AfterDraw
        AddHandler tChart1.Zoomed, AddressOf tChart1_Zoomed
        AddHandler tChart1.UndoneZoom, AddressOf tChart1_UndoneZoom
        AddHandler Me.Resize, AddressOf Area_SalesPrice_Resize

    End Sub
    Private Sub tChart1_UndoneZoom(ByVal sender As Object, ByVal e As EventArgs)
        'Necessary so that marks have valid positions
        tChart1.Draw()
    End Sub
    Private Sub tChart1_Zoomed(ByVal sender As Object, ByVal e As EventArgs)
        'Necessary so that marks have valid positions
        tChart1.Draw()
    End Sub

    Private Sub Area_SalesPrice_Resize(ByVal sender As Object, ByVal e As EventArgs)
        'Necessary so that marks have valid positions
        tChart1.Draw()
    End Sub

    Private Sub tChart1_AfterDraw(ByVal sender As Object, ByVal g As Steema.TeeChart.Drawing.Graphics3D)
        SetCustomMarksPosition()
        SetupAnnotations()
    End Sub

    Private Sub SetupAnnotations()
        Dim tmp As Integer = area1.CalcXPos(area1.Count - 2) + ((area1.CalcXPos(area1.Count - 1) - area1.CalcXPos(area1.Count - 2)) / 2)
        Dim chartRect As Rectangle = tChart1.Chart.ChartRect

        If annotation1 Is Nothing Then
            annotation1 = New Steema.TeeChart.Tools.Annotation(tChart1.Chart)
        End If
        annotation1.Text = "Total = " & area1.MaxXValue().ToString() & " consoles sold"
        annotation1.Shape.Font.Bold = True
        annotation1.Shape.Transparent = True
        annotation1.Shape.CustomPosition = True
        annotation1.Shape.Left = tmp - 80
        annotation1.Shape.Top = chartRect.Top + 20

        If annotation2 Is Nothing Then
            annotation2 = New Steema.TeeChart.Tools.Annotation(tChart1.Chart)
        End If
        annotation2.Text = "Average price " & average.MaxYValue().ToString() & " €"
        annotation2.Shape.Font.Bold = True
        annotation2.Shape.Font.Color = Color.Red
        annotation2.Shape.Transparent = True
        annotation2.Shape.CustomPosition = True
        annotation2.Shape.Left = tmp
        annotation2.Shape.Top = average.CalcYPos(0) - 15
    End Sub
    Private Sub SetCustomMarksPosition()
        For i As Integer = 0 To area1.Marks.Positions.Count - 1
            Dim tmp As Double = area1.XValues(i) + ((area1.XValues(i + 1) - area1.XValues(i)) / 2)
            area1.Marks.Positions(i).[Custom] = True
            area1.Marks.Positions(i).LeftTop.X = tChart1.Axes.Bottom.CalcXPosValue(tmp) - (area1.Marks.Positions(i).Width / 2)
            area1.Marks.Positions(i).LeftTop.Y = area1.CalcYPos(i) - 25
        Next

        area1.Marks.Arrow.Visible = False
        area1.Repaint()
    End Sub
    Private Sub area1_GetSeriesMark(ByVal series As Steema.TeeChart.Styles.Series, ByVal e As Steema.TeeChart.Styles.GetSeriesMarkEventArgs)
        '"Dummy" point mark removed
        If (e.ValueIndex < area1.Count - 1) Then
            e.MarkText = e.MarkText & "€"
        Else
            e.MarkText = ""
        End If
    End Sub

    Private Sub AddDataTable()
        Dim dataTable As New Steema.TeeChart.Tools.DataTableTool(tChart1.Chart)

        dataTable.RowPen.Visible = False
        dataTable.ColumnPen.Visible = False
        dataTable.TableLegend.Symbol.Visible = False
        dataTable.TableLegend.Font.Bold = True

        AddHandler dataTable.FilterSeries, AddressOf dataTable_FilterSeries

        'Add series to display customized data in the DataTable tool
        'They are not visible because they are out of the range of the left axis
        Dim salesSeries As New Steema.TeeChart.Styles.FastLine(tChart1.Chart)
        salesSeries.Title = "Sales (in €)"

        Dim unitsSeries As New Steema.TeeChart.Styles.FastLine(tChart1.Chart)
        unitsSeries.Title = "Units sold"

        For i As Integer = 1 To area1.Count - 1
            Dim tmp As Double = area1.XValues(i) - area1.XValues(i - 1)
            salesSeries.Add(area1.XValues(i), tmp * price(i - 1))
            unitsSeries.Add(area1.XValues(i), tmp)
        Next

        area1.Title = ""
        average.Title = ""
    End Sub

    Private Sub dataTable_FilterSeries(ByVal sender As Steema.TeeChart.Tools.DataTableTool, ByVal e As Steema.TeeChart.Tools.DataTableFilterSeriesEventArgs)
        If tChart1.Series.IndexOf(e.Series) < 2 Then
            e.Accept = False
        End If
    End Sub

    Private Sub AddCustomLabels()
        tChart1.Axes.Bottom.Labels.Items.Clear()

        For i As Integer = 0 To area1.Count - 2
            Dim value As Double = area1.XValues(i) + ((area1.XValues(i + 1) - area1.XValues(i)) / 2)
            tChart1.Axes.Bottom.Labels.Items.Add(value, console(i)).Font.Bold = True
        Next
    End Sub


    Private Sub FillSeries()
        Dim tmp As Double = 0

        For i As Integer = 0 To console.Length - 1
            area1.Add(tmp, price(i), console(i))
            tmp += units(i)
        Next

        average = New Steema.TeeChart.Styles.Line(tChart1.Chart)
        average.Color = Color.Black
        average.[Function] = New Steema.TeeChart.Functions.Average()
        average.DataSource = area1

        'A "dummy" point is necessary to plot last area
        area1.Add(tmp, price(price.Length - 1))
        average.XValues(average.Count - 1) = tmp
    End Sub

End Class