Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Public Class Line_Stack
    Inherits Samples.BaseForm
    Private lineSeries1 As Steema.TeeChart.Styles.Line
    Private lineSeries2 As Steema.TeeChart.Styles.Line
    Private lineSeries3 As Steema.TeeChart.Styles.Line
    Private label1 As System.Windows.Forms.Label
    Private comboBox1 As System.Windows.Forms.ComboBox
    Private lineSeries4 As Steema.TeeChart.Styles.Line
    Private components As System.ComponentModel.IContainer = Nothing

    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        For Each s As Steema.TeeChart.Styles.Series In tChart1.Series
            s.FillSampleValues(10)
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
        Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Line_Stack))
        Me.lineSeries1 = New Steema.TeeChart.Styles.Line()
        Me.lineSeries2 = New Steema.TeeChart.Styles.Line()
        Me.lineSeries3 = New Steema.TeeChart.Styles.Line()
        Me.label1 = New System.Windows.Forms.Label()
        Me.comboBox1 = New System.Windows.Forms.ComboBox()
        Me.lineSeries4 = New Steema.TeeChart.Styles.Line()
        Me.panel1.SuspendLayout()
        Me.chartContainer.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Size = New System.Drawing.Size(466, 56)
        Me.textBox1.Text = "Line Series can be Stacked and Overlaped. " & vbCr & vbLf & "Example:" & vbCr & vbLf & "lineSeries1.Stacked  = Stee" & "ma.TeeChart.Styles.CustomStack.Stack;"
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.comboBox1)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Location = New System.Drawing.Point(0, 56)
        Me.panel1.Size = New System.Drawing.Size(466, 33)
        ' 
        ' tChart1
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Aspect.Chart3DPercent = 35
        Me.tChart1.Aspect.ZOffset = 0
        Me.tChart1.Cursor = System.Windows.Forms.Cursors.[Default]
        ' 
        ' 
        ' 
        Me.tChart1.Header.Lines = New String() {"tChart1"}
        Me.tChart1.Header.Visible = False
        ' 
        ' 
        ' 
        Me.tChart1.Legend.Visible = False
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CInt(CByte(254)), CInt(CByte(255)), CInt(CByte(255)), CInt(CByte(255)))
        Me.tChart1.Series.Add(Me.lineSeries1)
        Me.tChart1.Series.Add(Me.lineSeries2)
        Me.tChart1.Series.Add(Me.lineSeries3)
        Me.tChart1.Series.Add(Me.lineSeries4)
        Me.tChart1.Size = New System.Drawing.Size(466, 197)
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Walls.Back.Brush.Color = System.Drawing.Color.FromArgb(CInt(CByte(0)), CInt(CByte(0)), CInt(CByte(0)))
        ' 
        ' 
        ' 
        Me.tChart1.Walls.Back.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CInt(CByte(255)), CInt(CByte(0)), CInt(CByte(0)))
        Me.tChart1.Walls.Back.Brush.Visible = False
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Walls.Bottom.Pen.Visible = False
        Me.tChart1.Walls.Bottom.Size = 5
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Walls.Left.Pen.Visible = False
        Me.tChart1.Walls.Left.Size = 5
        ' 
        ' chartContainer
        ' 
        Me.chartContainer.Location = New System.Drawing.Point(0, 89)
        Me.chartContainer.Size = New System.Drawing.Size(466, 197)
        ' 
        ' lineSeries1
        ' 
        ' 
        ' 
        ' 
        Me.lineSeries1.Brush.Color = System.Drawing.Color.FromArgb(CInt(CByte(68)), CInt(CByte(102)), CInt(CByte(163)))
        Me.lineSeries1.Color = System.Drawing.Color.FromArgb(CInt(CByte(68)), CInt(CByte(102)), CInt(CByte(163)))
        Me.lineSeries1.ColorEach = False
        ' 
        ' 
        ' 
        Me.lineSeries1.LinePen.Color = System.Drawing.Color.FromArgb(CInt(CByte(41)), CInt(CByte(61)), CInt(CByte(98)))
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.lineSeries1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None
        Me.lineSeries1.Marks.Callout.ArrowHeadSize = 8
        ' 
        ' 
        ' 
        Me.lineSeries1.Marks.Callout.Brush.Color = System.Drawing.Color.Black
        Me.lineSeries1.Marks.Callout.Distance = 0
        Me.lineSeries1.Marks.Callout.Draw3D = False
        Me.lineSeries1.Marks.Callout.Length = 10
        Me.lineSeries1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.lineSeries1.Marks.Callout.Visible = False
        ' 
        ' 
        ' 
        Me.lineSeries1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.lineSeries1.Title = "lineSeries1"
        ' 
        ' 
        ' 
        Me.lineSeries1.XValues.DataMember = "X"
        Me.lineSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' 
        ' 
        Me.lineSeries1.YValues.DataMember = "Y"
        ' 
        ' lineSeries2
        ' 
        ' 
        ' 
        ' 
        Me.lineSeries2.Brush.Color = System.Drawing.Color.FromArgb(CInt(CByte(243)), CInt(CByte(156)), CInt(CByte(53)))
        Me.lineSeries2.Color = System.Drawing.Color.FromArgb(CInt(CByte(243)), CInt(CByte(156)), CInt(CByte(53)))
        Me.lineSeries2.ColorEach = False
        ' 
        ' 
        ' 
        Me.lineSeries2.LinePen.Color = System.Drawing.Color.FromArgb(CInt(CByte(146)), CInt(CByte(94)), CInt(CByte(32)))
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.lineSeries2.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None
        Me.lineSeries2.Marks.Callout.ArrowHeadSize = 8
        ' 
        ' 
        ' 
        Me.lineSeries2.Marks.Callout.Brush.Color = System.Drawing.Color.Black
        Me.lineSeries2.Marks.Callout.Distance = 0
        Me.lineSeries2.Marks.Callout.Draw3D = False
        Me.lineSeries2.Marks.Callout.Length = 10
        Me.lineSeries2.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.lineSeries2.Marks.Callout.Visible = False
        ' 
        ' 
        ' 
        Me.lineSeries2.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.lineSeries2.Title = "lineSeries2"
        ' 
        ' 
        ' 
        Me.lineSeries2.XValues.DataMember = "X"
        Me.lineSeries2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' 
        ' 
        Me.lineSeries2.YValues.DataMember = "Y"
        ' 
        ' lineSeries3
        ' 
        ' 
        ' 
        ' 
        Me.lineSeries3.Brush.Color = System.Drawing.Color.FromArgb(CInt(CByte(241)), CInt(CByte(76)), CInt(CByte(20)))
        Me.lineSeries3.Color = System.Drawing.Color.FromArgb(CInt(CByte(241)), CInt(CByte(76)), CInt(CByte(20)))
        Me.lineSeries3.ColorEach = False
        ' 
        ' 
        ' 
        Me.lineSeries3.LinePen.Color = System.Drawing.Color.FromArgb(CInt(CByte(145)), CInt(CByte(46)), CInt(CByte(12)))
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.lineSeries3.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None
        Me.lineSeries3.Marks.Callout.ArrowHeadSize = 8
        ' 
        ' 
        ' 
        Me.lineSeries3.Marks.Callout.Brush.Color = System.Drawing.Color.Black
        Me.lineSeries3.Marks.Callout.Distance = 0
        Me.lineSeries3.Marks.Callout.Draw3D = False
        Me.lineSeries3.Marks.Callout.Length = 10
        Me.lineSeries3.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.lineSeries3.Marks.Callout.Visible = False
        ' 
        ' 
        ' 
        Me.lineSeries3.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.lineSeries3.Title = "lineSeries3"
        ' 
        ' 
        ' 
        Me.lineSeries3.XValues.DataMember = "X"
        Me.lineSeries3.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' 
        ' 
        Me.lineSeries3.YValues.DataMember = "Y"
        ' 
        ' label1
        ' 
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(16, 9)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(37, 13)
        Me.label1.TabIndex = 0
        Me.label1.Text = "&Mode:"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        ' 
        ' comboBox1
        ' 
        Me.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboBox1.Items.AddRange(New Object() {"Normal", "Overlap", "Stack", "Stack 100%"})
        Me.comboBox1.Location = New System.Drawing.Point(60, 6)
        Me.comboBox1.Name = "comboBox1"
        Me.comboBox1.Size = New System.Drawing.Size(101, 21)
        Me.comboBox1.TabIndex = 1
        AddHandler Me.comboBox1.SelectedIndexChanged, AddressOf Me.comboBox1_SelectedIndexChanged
        ' 
        ' lineSeries4
        ' 
        ' 
        ' 
        ' 
        Me.lineSeries4.Brush.Color = System.Drawing.Color.FromArgb(CInt(CByte(78)), CInt(CByte(151)), CInt(CByte(168)))
        Me.lineSeries4.Color = System.Drawing.Color.FromArgb(CInt(CByte(78)), CInt(CByte(151)), CInt(CByte(168)))
        Me.lineSeries4.ColorEach = False
        ' 
        ' 
        ' 
        Me.lineSeries4.LinePen.Color = System.Drawing.Color.FromArgb(CInt(CByte(47)), CInt(CByte(91)), CInt(CByte(101)))
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.lineSeries4.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None
        Me.lineSeries4.Marks.Callout.ArrowHeadSize = 8
        ' 
        ' 
        ' 
        Me.lineSeries4.Marks.Callout.Brush.Color = System.Drawing.Color.Black
        Me.lineSeries4.Marks.Callout.Distance = 0
        Me.lineSeries4.Marks.Callout.Draw3D = False
        Me.lineSeries4.Marks.Callout.Length = 10
        Me.lineSeries4.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.lineSeries4.Marks.Callout.Visible = False
        ' 
        ' 
        ' 
        Me.lineSeries4.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.lineSeries4.Title = "lineSeries4"
        ' 
        ' 
        ' 
        Me.lineSeries4.XValues.DataMember = "X"
        Me.lineSeries4.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' 
        ' 
        Me.lineSeries4.YValues.DataMember = "Y"
        ' 
        ' Line_Stack
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(466, 286)
        Me.Name = "Line_Stack"
        AddHandler Me.Load, AddressOf Me.Line_Stack_Load
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.chartContainer.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
#End Region


    Private Sub Line_Stack_Load(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.comboBox1.SelectedIndex = 0
    End Sub

    Private Sub comboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Select Case Me.comboBox1.SelectedIndex
            Case 0
                Me.lineSeries1.Stacked = Steema.TeeChart.Styles.CustomStack.None
                Exit Select
            Case 1
                Me.lineSeries1.Stacked = Steema.TeeChart.Styles.CustomStack.Overlap
                Exit Select
            Case 2
                Me.lineSeries1.Stacked = Steema.TeeChart.Styles.CustomStack.Stack
                Exit Select
            Case 3
                Me.lineSeries1.Stacked = Steema.TeeChart.Styles.CustomStack.Stack100
                Exit Select
        End Select
    End Sub
End Class 'Line_Stack
