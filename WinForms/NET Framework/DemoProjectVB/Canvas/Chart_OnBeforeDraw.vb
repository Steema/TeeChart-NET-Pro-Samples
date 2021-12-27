
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms


Public Class Chart_OnBeforeDraw
    Inherits Steema.TeeChart.Samples.BaseForm
    Private bar1 As Steema.TeeChart.Styles.Bar
    Private components As System.ComponentModel.IContainer = Nothing
    Private BeforeChart, BeforeAxes, BeforeSeries, AfterDraw As Boolean
    Private groupBox1 As System.Windows.Forms.GroupBox
    Private radioButton1 As System.Windows.Forms.RadioButton
    Private radioButton2 As System.Windows.Forms.RadioButton
    Private radioButton3 As System.Windows.Forms.RadioButton
    Private gridBand1 As Steema.TeeChart.Tools.GridBand
    Private radioButton4 As System.Windows.Forms.RadioButton
    
    Public Sub New() ' This call is required by the Windows Form Designer.
        InitializeComponent()

        bar1.FillSampleValues()
        BeforeChart = True
        BeforeAxes = False
        BeforeSeries = False
        AfterDraw = False

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
        Me.bar1 = New Steema.TeeChart.Styles.Bar
        Me.groupBox1 = New System.Windows.Forms.GroupBox
        Me.radioButton4 = New System.Windows.Forms.RadioButton
        Me.radioButton3 = New System.Windows.Forms.RadioButton
        Me.radioButton2 = New System.Windows.Forms.RadioButton
        Me.radioButton1 = New System.Windows.Forms.RadioButton
        Me.gridBand1 = New Steema.TeeChart.Tools.GridBand
        Me.panel1.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Text = "TeeChart's events can be used to draw Graphics objects onto the Chart at differen" + "t times of rendering."
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.groupBox1)
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
        Me.tChart1.Header.Lines = New String() {"TeeChart Canvas Events"}
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Brush
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.tChart1.Series.Add(Me.bar1)
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
        Me.tChart1.Walls.Bottom.Size = 5
        ' 
        ' tChart1.Walls.Left
        ' 
        ' 
        ' tChart1.Walls.Left.Pen
        ' 
        Me.tChart1.Walls.Left.Pen.Visible = False
        Me.tChart1.Walls.Left.Size = 5
        AddHandler Me.tChart1.BeforeDrawAxes, AddressOf Me.tChart1_BeforeDrawAxes
        AddHandler Me.tChart1.AfterDraw, AddressOf Me.tChart1_AfterDraw
        AddHandler Me.tChart1.BeforeDrawSeries, AddressOf Me.tChart1_BeforeDrawSeries
        AddHandler Me.tChart1.BeforeDraw, AddressOf Me.tChart1_BeforeDraw
        ' 
        ' bar1
        ' 
        ' 
        ' bar1.Brush
        ' 
        Me.bar1.Brush.Color = System.Drawing.Color.Red
        ' 
        ' bar1.Marks
        ' 
        ' 
        ' bar1.Marks.Symbol
        ' 
        ' 
        ' bar1.Marks.Symbol.Shadow
        ' 
        Me.bar1.Marks.Symbol.Shadow.Height = 1
        Me.bar1.Marks.Symbol.Shadow.Visible = True
        Me.bar1.Marks.Symbol.Shadow.Width = 1
        Me.bar1.Title = "bar1"
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
        ' groupBox1
        ' 
        Me.groupBox1.Controls.Add(Me.radioButton4)
        Me.groupBox1.Controls.Add(Me.radioButton3)
        Me.groupBox1.Controls.Add(Me.radioButton2)
        Me.groupBox1.Controls.Add(Me.radioButton1)
        Me.groupBox1.Location = New System.Drawing.Point(2, -3)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(435, 41)
        Me.groupBox1.TabIndex = 0
        Me.groupBox1.TabStop = False
        ' 
        ' radioButton4
        ' 
        Me.radioButton4.Location = New System.Drawing.Point(328, 16)
        Me.radioButton4.Name = "radioButton4"
        Me.radioButton4.Size = New System.Drawing.Size(91, 17)
        Me.radioButton4.TabIndex = 3
        Me.radioButton4.Text = "After Chart"
        AddHandler Me.radioButton4.Click, AddressOf Me.radioButtons_Click
        ' 
        ' radioButton3
        ' 
        Me.radioButton3.Location = New System.Drawing.Point(214, 16)
        Me.radioButton3.Name = "radioButton3"
        Me.radioButton3.Size = New System.Drawing.Size(91, 17)
        Me.radioButton3.TabIndex = 2
        Me.radioButton3.Text = "Before Series"
        AddHandler Me.radioButton3.Click, AddressOf Me.radioButtons_Click
        ' 
        ' radioButton2
        ' 
        Me.radioButton2.Location = New System.Drawing.Point(111, 17)
        Me.radioButton2.Name = "radioButton2"
        Me.radioButton2.Size = New System.Drawing.Size(91, 17)
        Me.radioButton2.TabIndex = 1
        Me.radioButton2.Text = "Before Axes"
        AddHandler Me.radioButton2.Click, AddressOf Me.radioButtons_Click
        ' 
        ' radioButton1
        ' 
        Me.radioButton1.Checked = True
        Me.radioButton1.Location = New System.Drawing.Point(8, 16)
        Me.radioButton1.Name = "radioButton1"
        Me.radioButton1.Size = New System.Drawing.Size(104, 17)
        Me.radioButton1.TabIndex = 0
        Me.radioButton1.TabStop = True
        Me.radioButton1.Text = "Before Chart"
        AddHandler Me.radioButton1.Click, AddressOf Me.radioButtons_Click
        ' 
        ' gridBand1
        ' 
        Me.gridBand1.Axis = Me.tChart1.Axes.Left
        ' 
        ' gridBand1.Band1
        ' 
        Me.gridBand1.Band1.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(224, System.Byte), CType(224, System.Byte), CType(224, System.Byte))
        ' 
        ' gridBand1.Band2
        ' 
        Me.gridBand1.Band2.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        ' 
        ' Canvas_Events
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(440, 317)
        Me.Name = "Canvas_Events"
        Me.panel1.ResumeLayout(False)
        Me.groupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub 'New 
#End Region


    Private Sub DrawShape()
        tChart1.Graphics3D.Pen.Style = System.Drawing.Drawing2D.DashStyle.Dot
        tChart1.Graphics3D.Brush.Visible = True
        tChart1.Graphics3D.Brush.Color = Color.Yellow
        tChart1.Graphics3D.Ellipse(1, 1, tChart1.Graphics3D.Chart.Width - 1, tChart1.Graphics3D.Chart.Height - 1)
    End Sub 'DrawShape


    Private Sub tChart1_AfterDraw(ByVal sender As Object, ByVal g As Steema.TeeChart.Drawing.Graphics3D)
        If AfterDraw Then
            DrawShape()
        End If
        BeforeChart = False
        BeforeAxes = False
        BeforeSeries = False
        AfterDraw = False
    End Sub 'tChart1_AfterDraw


    Private Sub tChart1_BeforeDrawAxes(ByVal sender As Object, ByVal g As Steema.TeeChart.Drawing.Graphics3D)
        If BeforeAxes Then
            DrawShape()
        End If
    End Sub 'tChart1_BeforeDrawAxes

    Private Sub tChart1_BeforeDrawSeries(ByVal sender As Object, ByVal g As Steema.TeeChart.Drawing.Graphics3D)
        If BeforeSeries Then
            DrawShape()
        End If
    End Sub 'tChart1_BeforeDrawSeries

    Private Sub tChart1_BeforeDraw(ByVal sender As Object, ByVal g As Steema.TeeChart.Drawing.Graphics3D)
        If BeforeChart Then
            DrawShape()
        End If
    End Sub 'tChart1_BeforeDraw

    Private Sub radioButtons_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim endsWith As String = CType(sender, RadioButton).Name.Substring(11, 1)
        Select Case endsWith
            Case "1"
                BeforeChart = True
            Case "2"
                BeforeAxes = True
            Case "3"
                BeforeSeries = True
            Case "4"
                AfterDraw = True
        End Select
        tChart1.Invalidate()
    End Sub 'radioButtons_Click
End Class 'Chart_OnBeforeDraw