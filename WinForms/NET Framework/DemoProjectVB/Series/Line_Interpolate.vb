Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Public Class Line_Interpolate
    Inherits Steema.TeeChart.Samples.BaseForm
    Private line1 As Steema.TeeChart.Styles.Line
    Private line2 As Steema.TeeChart.Styles.Line
    Private line3 As Steema.TeeChart.Styles.Line
    Private cursorTool1 As Steema.TeeChart.Tools.CursorTool
    Private checkBox1 As System.Windows.Forms.CheckBox
    Private components As System.ComponentModel.IContainer = Nothing
    Private gridBand1 As Steema.TeeChart.Tools.GridBand
    Private xval As Double

    ''' <summary>
    ''' Calculate y=y(x) for arbitrary x. Works fine only for line series with ordered x values.
    ''' </summary>
    ''' <param name="series"></param>
    ''' <param name="firstindex"></param>
    ''' <param name="lastindex"></param>
    ''' <param name="xvalue"></param>
    ''' <returns>y=y(xvalue) where xvalue is arbitrary x value.</returns>
    Private Function InterpolateLineSeries(ByVal series As TeeChart.Styles.Custom, ByVal firstindex As Integer, ByVal lastindex As Integer, ByVal xvalue As Double) As Double
        Dim index As Integer
        For index = firstindex To lastindex
            If index = -1 OrElse series.XValues.Value(index) > xvalue Then
                Exit For
            End If
        Next
        ' safeguard
        If index < 1 Then
            index = 1
        ElseIf index >= series.Count Then
            index = series.Count - 1
        End If
        ' y=(y2-y1)/(x2-x1)*(x-x1)+y1
        Dim dx As Double = series.XValues(index) - series.XValues(index - 1)
        Dim dy As Double = series.YValues(index) - series.YValues(index - 1)
        If dx <> 0.0 Then
            Return dy * (xvalue - series.XValues(index - 1)) / dx + series.YValues(index - 1)
        Else
            Return 0.0
        End If
    End Function

    Private Function InterpolateLineSeries(ByVal series As TeeChart.Styles.Custom, ByVal xvalue As Double) As Double
        Return InterpolateLineSeries(series, series.FirstVisibleIndex, series.LastVisibleIndex, xvalue)
    End Function

    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        For Each s As TeeChart.Styles.Series In tChart1.Series
            s.FillSampleValues(20)
        Next
    End Sub
    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub 'Dispose
#Region "Designer generated code"
    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Me.line1 = New Steema.TeeChart.Styles.Line()
        Me.line2 = New Steema.TeeChart.Styles.Line()
        Me.line3 = New Steema.TeeChart.Styles.Line()
        Me.cursorTool1 = New Steema.TeeChart.Tools.CursorTool()
        Me.checkBox1 = New System.Windows.Forms.CheckBox()
        Me.gridBand1 = New Steema.TeeChart.Tools.GridBand()
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(440, 72)
        Me.textBox1.Text = "Using a simple linear interpolation formula it's now possible to calculate y=y(x) for arbitrary x value. The code will work correctly only if you use line/fastline series and if x values are ordered." & vbCr & vbLf & "Try moving the cursor -> series y values will be shown for arbitrary x value."
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.checkBox1)
        Me.panel1.Location = New System.Drawing.Point(0, 72)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(440, 40)
        ' 
        ' tChart1
        ' 
        ' 
        ' tChart1.Aspect
        ' 
        Me.tChart1.Aspect.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality
        Me.tChart1.Aspect.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        Me.tChart1.Aspect.View3D = False
        ' 
        ' tChart1.Header
        ' 
        Me.tChart1.Header.Lines = New String() {"TeeChart"}
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Brush
        ' 
        Me.tChart1.Series.Add(Me.line1)
        Me.tChart1.Series.Add(Me.line2)
        Me.tChart1.Series.Add(Me.line3)
        Me.tChart1.Tools.Add(Me.cursorTool1)
        Me.tChart1.Tools.Add(Me.gridBand1)
        AddHandler Me.tChart1.AfterDraw, AddressOf tChart1_AfterDraw
        ' 
        ' line1
        ' 
        ' 
        ' line1.Brush
        ' 
        Me.line1.Brush.Color = System.Drawing.Color.Red
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
        Me.line1.Pointer.HorizSize = 3
        Me.line1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.line1.Pointer.VertSize = 3
        Me.line1.Pointer.Visible = True
        Me.line1.Title = "line1"
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
        ' line2
        ' 
        ' 
        ' line2.Brush
        ' 
        Me.line2.Brush.Color = System.Drawing.Color.Green
        ' 
        ' line2.Marks
        ' 
        ' 
        ' line2.Marks.Symbol
        ' 
        ' 
        ' line2.Marks.Symbol.Shadow
        ' 
        Me.line2.Marks.Symbol.Shadow.Height = 1
        Me.line2.Marks.Symbol.Shadow.Visible = True
        Me.line2.Marks.Symbol.Shadow.Width = 1
        ' 
        ' line2.Pointer
        ' 
        ' 
        ' line2.Pointer.Brush
        ' 
        Me.line2.Pointer.HorizSize = 3
        Me.line2.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Circle
        Me.line2.Pointer.VertSize = 3
        Me.line2.Pointer.Visible = True
        Me.line2.Title = "line2"
        ' 
        ' line2.XValues
        ' 
        Me.line2.XValues.DataMember = "X"
        Me.line2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' line2.YValues
        ' 
        Me.line2.YValues.DataMember = "Y"
        ' 
        ' line3
        ' 
        ' 
        ' line3.Brush
        ' 
        Me.line3.Brush.Color = System.Drawing.Color.Yellow
        ' 
        ' line3.Marks
        ' 
        ' 
        ' line3.Marks.Symbol
        ' 
        ' 
        ' line3.Marks.Symbol.Shadow
        ' 
        Me.line3.Marks.Symbol.Shadow.Height = 1
        Me.line3.Marks.Symbol.Shadow.Visible = True
        Me.line3.Marks.Symbol.Shadow.Width = 1
        ' 
        ' line3.Pointer
        ' 
        ' 
        ' line3.Pointer.Brush
        ' 
        Me.line3.Pointer.HorizSize = 3
        Me.line3.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Triangle
        Me.line3.Pointer.VertSize = 3
        Me.line3.Pointer.Visible = True
        Me.line3.Title = "line3"
        ' 
        ' line3.XValues
        ' 
        Me.line3.XValues.DataMember = "X"
        Me.line3.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' line3.YValues
        ' 
        Me.line3.YValues.DataMember = "Y"
        ' 
        ' cursorTool1
        ' 
        Me.cursorTool1.FollowMouse = True
        ' 
        ' cursorTool1.Pen
        ' 
        Me.cursorTool1.Pen.Style = System.Drawing.Drawing2D.DashStyle.Dash
        Me.cursorTool1.Style = Steema.TeeChart.Tools.CursorToolStyles.Vertical
        AddHandler Me.cursorTool1.Change, AddressOf Me.cursorTool1_Change
        ' 
        ' checkBox1
        ' 
        Me.checkBox1.Checked = True
        Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox1.Location = New System.Drawing.Point(8, 8)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(112, 24)
        Me.checkBox1.TabIndex = 0
        Me.checkBox1.Text = "Show markers"
        ' 
        ' gridBand1
        ' 
        Me.gridBand1.Axis = Me.tChart1.Axes.Left
        ' 
        ' gridBand1.Band1
        ' 
        Me.gridBand1.Band1.Color = System.Drawing.Color.FromArgb(CByte(127), CByte(224), CByte(224), CByte(224))
        ' 
        ' gridBand1.Band2
        ' 
        Me.gridBand1.Band2.Color = System.Drawing.Color.FromArgb(CByte(127), CByte(255), CByte(255), CByte(255))
        ' 
        ' Line_Interpolate
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(440, 317)
        Me.Name = "Line_Interpolate"
        AddHandler Me.Load, AddressOf Me.Line_Interpolate_Load
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
#End Region
    Private Sub cursorTool1_Change(ByVal sender As Object, ByVal e As Steema.TeeChart.Tools.CursorChangeEventArgs)
        xval = e.XValue
        tChart1.Header.Text = ""
        For i As Integer = 0 To tChart1.Series.Count - 1
            If TypeOf tChart1.Series(i) Is TeeChart.Styles.Custom Then
                tChart1.Header.Text += tChart1.Series(i).Title + ": Y(" + e.XValue.ToString("0.00") & ")= "
                tChart1.Header.Text += InterpolateLineSeries(TryCast(tChart1.Series(i), Steema.TeeChart.Styles.Custom), e.XValue).ToString("0.00") + vbCr & vbLf
            End If
        Next
    End Sub
    Private Sub Line_Interpolate_Load(ByVal sender As Object, ByVal e As System.EventArgs)
        cursorTool1_Change(tChart1, New Steema.TeeChart.Tools.CursorChangeEventArgs())
    End Sub
    Private Sub tChart1_AfterDraw(ByVal sender As Object, ByVal g As Steema.TeeChart.Drawing.Graphics3D)
        If checkBox1.Checked Then
            Dim xs As Integer = tChart1.Axes.Bottom.CalcXPosValue(xval)
            Dim ys As Integer
            g.Brush.Visible = True
            g.Brush.Solid = True
            For i As Integer = 0 To tChart1.Series.Count - 1
                If TypeOf tChart1.Series(i) Is TeeChart.Styles.Custom Then
                    ys = tChart1.Series(i).GetVertAxis.CalcYPosValue(InterpolateLineSeries(TryCast(tChart1.Series(i), Steema.TeeChart.Styles.Custom), xval))
                    g.Brush.Color = tChart1.Series(i).Color
                    g.Ellipse(New Rectangle(xs - 4, ys - 4, 8, 8))
                End If
            Next
        End If
    End Sub

End Class 'Line_Interpolate