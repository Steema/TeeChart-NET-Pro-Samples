
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

Public Class Axis_MultiScroll
    Inherits Steema.TeeChart.Samples.BaseForm
    Private fastLineSeries1 As Steema.TeeChart.Styles.FastLine
    Private fastLineSeries2 As Steema.TeeChart.Styles.FastLine
    Private volumeSeries1 As Steema.TeeChart.Styles.Volume
    Private candleSeries1 As Steema.TeeChart.Styles.Candle
    Private label1 As System.Windows.Forms.Label
    Private checkBox1 As System.Windows.Forms.CheckBox
    Private checkBox2 As System.Windows.Forms.CheckBox
    Private checkBox3 As System.Windows.Forms.CheckBox
    Private components As System.ComponentModel.IContainer = Nothing
    
    Private Green As Steema.TeeChart.Axis
    Private gridBand1 As Steema.TeeChart.Tools.GridBand
    Private gridBand2 As Steema.TeeChart.Tools.GridBand
    Private Blue As Steema.TeeChart.Axis
    
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        tChart1.Series.Add(fastLineSeries1)
        tChart1.Series.Add(fastLineSeries2)
        tChart1.Series.Add(candleSeries1)
        tChart1.Series.Add(volumeSeries1)
        
        For Each s As TeeChart.Styles.Series In Me.tChart1.Series
            s.FillSampleValues(100)
        Next s
        ' change the Left axis properties
        Dim axis As Steema.TeeChart.Axis = Me.tChart1.Axes.Left

        axis.AxisPen.Color = Color.Red
        axis.StartPosition = 0
        axis.EndPosition = 32

        ' create custom axes. This can be done at design-time
        Green = New TeeChart.Axis(tChart1.Chart)
        Me.tChart1.Axes.Custom.Add(Green)
        Green.AxisPen.Color = Color.Green
        Green.StartPosition = 34
        Green.EndPosition = 65

        Blue = New TeeChart.Axis(tChart1.Chart)
        Me.tChart1.Axes.Custom.Add(Blue)
        Blue.AxisPen.Color = Color.Blue
        Blue.StartPosition = 67
        Blue.EndPosition = 100

        ' associate series
        Me.fastLineSeries1.VertAxis = Steema.TeeChart.Styles.VerticalAxis.Left
        Me.fastLineSeries2.VertAxis = Steema.TeeChart.Styles.VerticalAxis.Left
        Me.candleSeries1.CustomVertAxis = Green
        Me.volumeSeries1.CustomVertAxis = Blue

        tChart1.Tools.Add(gridBand1)
        tChart1.Tools.Add(gridBand2)

        gridBand1.Axis = tChart1.Axes.Left
        gridBand2.Axis = Blue
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
        Me.fastLineSeries1 = New Steema.TeeChart.Styles.FastLine
        Me.fastLineSeries2 = New Steema.TeeChart.Styles.FastLine
        Me.volumeSeries1 = New Steema.TeeChart.Styles.Volume
        Me.candleSeries1 = New Steema.TeeChart.Styles.Candle
        Me.label1 = New System.Windows.Forms.Label
        Me.checkBox1 = New System.Windows.Forms.CheckBox
        Me.checkBox2 = New System.Windows.Forms.CheckBox
        Me.checkBox3 = New System.Windows.Forms.CheckBox
        Me.gridBand1 = New Steema.TeeChart.Tools.GridBand
        Me.gridBand2 = New Steema.TeeChart.Tools.GridBand
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.BackColor = System.Drawing.Color.AliceBlue
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(592, 73)
        Me.textBox1.Text = ("This chart contains 3 custom axes and several series associated to all axes.  The example shows how to restrict scroll to some axes only. Most of the code can be done visually at design-time." & vbCrLf & vbCrLf & "Try to scroll vertically using the right mouse button.")
        ' 
        ' panel1
        ' 
        Me.panel1.BackColor = System.Drawing.SystemColors.Control
        Me.panel1.Controls.Add(Me.checkBox3)
        Me.panel1.Controls.Add(Me.checkBox2)
        Me.panel1.Controls.Add(Me.checkBox1)
        Me.panel1.Controls.Add(Me.label1)
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
        Me.tChart1.Aspect.View3D = False
        ' 
        ' tChart1.Header
        ' 
        Me.tChart1.Header.Lines = New String() {"tChart1"}
        Me.tChart1.Header.Visible = False
        ' 
        ' tChart1.Legend
        ' 
        Me.tChart1.Legend.Visible = False
        Me.tChart1.Location = New System.Drawing.Point(0, 104)
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Brush
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(254, Byte), CType(255, Byte), CType(255, Byte), CType(255, Byte))
        ' 
        ' tChart1.Panel.Gradient
        ' 
        Me.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(254, Byte), CType(192, Byte), CType(192, Byte), CType(255, Byte))
        Me.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(254, Byte), CType(192, Byte), CType(192, Byte), CType(255, Byte))
        Me.tChart1.Panel.Brush.Gradient.UseMiddle = True
        Me.tChart1.Panel.Brush.Gradient.Visible = True
        ' 
        ' tChart1.Panel.Gradient
        ' 
        Me.tChart1.Panel.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(254, Byte), CType(192, Byte), CType(192, Byte), CType(255, Byte))
        Me.tChart1.Panel.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(254, Byte), CType(192, Byte), CType(192, Byte), CType(255, Byte))
        Me.tChart1.Panel.Gradient.UseMiddle = True
        Me.tChart1.Panel.Gradient.Visible = True
        Me.tChart1.Size = New System.Drawing.Size(592, 264)
        ' 
        ' tChart1.Walls
        ' 
        ' 
        ' tChart1.Walls.Back
        ' 
        ' 
        ' tChart1.Walls.Back.Pen
        ' 
        Me.tChart1.Walls.Back.Pen.Visible = False
        AddHandler tChart1.Scroll, AddressOf Me.tChart1_Scroll
        ' 
        ' fastLineSeries1
        ' 
        Me.fastLineSeries1.Cursor = System.Windows.Forms.Cursors.Cross
        ' 
        ' fastLineSeries1.LinePen
        ' 
        Me.fastLineSeries1.LinePen.Color = System.Drawing.Color.Red
        Me.fastLineSeries1.Title = "fastLineSeries1"
        ' 
        ' fastLineSeries1.XValues
        ' 
        Me.fastLineSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' fastLineSeries2
        ' 
        Me.fastLineSeries2.Cursor = System.Windows.Forms.Cursors.Cross
        ' 
        ' fastLineSeries2.LinePen
        ' 
        Me.fastLineSeries2.LinePen.Color = System.Drawing.Color.Green
        Me.fastLineSeries2.Title = "fastLineSeries2"
        ' 
        ' fastLineSeries2.XValues
        ' 
        Me.fastLineSeries2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' volumeSeries1
        ' 
        ' 
        ' volumeSeries1.Brush
        ' 
        Me.volumeSeries1.Brush.Color = System.Drawing.Color.Blue
        Me.volumeSeries1.ClickableLine = False
        Me.volumeSeries1.Cursor = System.Windows.Forms.Cursors.Cross
        ' 
        ' volumeSeries1.LinePen
        ' 
        Me.volumeSeries1.LinePen.Color = System.Drawing.Color.Blue
        ' 
        ' volumeSeries1.Pointer
        ' 
        Me.volumeSeries1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.volumeSeries1.Title = "volumeSeries1"
        ' 
        ' volumeSeries1.XValues
        ' 
        Me.volumeSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' candleSeries1
        ' 
        ' 
        ' candleSeries1.Brush
        ' 
        Me.candleSeries1.Brush.Color = System.Drawing.Color.Yellow
        Me.candleSeries1.CloseValues = Me.candleSeries1.YValues
        Me.candleSeries1.Cursor = System.Windows.Forms.Cursors.Cross
        Me.candleSeries1.DateValues = Me.candleSeries1.XValues
        ' 
        ' candleSeries1.Pointer
        ' 
        Me.candleSeries1.Pointer.Draw3D = False
        Me.candleSeries1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.candleSeries1.Title = "candleSeries1"
        ' 
        ' candleSeries1.XValues
        ' 
        Me.candleSeries1.XValues.DateTime = True
        Me.candleSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' label1
        ' 
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(8, 8)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(153, 16)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Enable vertical scroll on axis :"
        Me.label1.UseMnemonic = False
        ' 
        ' checkBox1
        ' 
        Me.checkBox1.Checked = True
        Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox1.Location = New System.Drawing.Point(200, 2)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(56, 24)
        Me.checkBox1.TabIndex = 1
        Me.checkBox1.Text = "&Red"
        ' 
        ' checkBox2
        ' 
        Me.checkBox2.Checked = True
        Me.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox2.Location = New System.Drawing.Point(256, 2)
        Me.checkBox2.Name = "checkBox2"
        Me.checkBox2.Size = New System.Drawing.Size(56, 24)
        Me.checkBox2.TabIndex = 2
        Me.checkBox2.Text = "&Blue"
        ' 
        ' checkBox3
        ' 
        Me.checkBox3.Checked = True
        Me.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox3.Location = New System.Drawing.Point(320, 2)
        Me.checkBox3.Name = "checkBox3"
        Me.checkBox3.Size = New System.Drawing.Size(64, 24)
        Me.checkBox3.TabIndex = 3
        Me.checkBox3.Text = "&Green"
        ' 
        ' gridBand1
        ' 
        ' 
        ' gridBand1.Band1
        ' 
        Me.gridBand1.Band1.Color = System.Drawing.Color.FromArgb(CType(0, Byte), CType(211, Byte), CType(211, Byte), CType(211, Byte))
        Me.gridBand1.Band1.ForegroundColor = System.Drawing.Color.White
        ' 
        ' gridBand1.Band2
        ' 
        Me.gridBand1.Band2.Color = System.Drawing.Color.FromArgb(CType(25, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
        ' 
        ' gridBand2
        ' 
        ' 
        ' gridBand2.Band1
        ' 
        Me.gridBand2.Band1.Color = System.Drawing.Color.FromArgb(CType(0, Byte), CType(211, Byte), CType(211, Byte), CType(211, Byte))
        Me.gridBand2.Band1.ForegroundColor = System.Drawing.Color.White
        ' 
        ' gridBand2.Band2
        ' 
        Me.gridBand2.Band2.Color = System.Drawing.Color.FromArgb(CType(25, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
        ' 
        ' Axis_MultiScroll
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(592, 368)
        Me.Name = "Axis_MultiScroll"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub 'InitializeComponent 
#End Region


    Private Sub tChart1_Scroll(ByVal sender As Object, ByVal e As System.EventArgs) Handles tChart1.Scroll
        Dim tmpMin, tmpMax As Double
        If Not Me.checkBox1.Checked Then
            tmpMin = Math.Min(Me.fastLineSeries1.YValues.Minimum, Me.fastLineSeries2.YValues.Minimum)
            tmpMax = Math.Max(Me.fastLineSeries1.YValues.Maximum, Me.fastLineSeries2.YValues.Maximum)
            Me.tChart1.Axes.Left.SetMinMax(tmpMin, tmpMax)
        End If

        If Not Me.checkBox2.Checked Then
            Blue.SetMinMax(Me.volumeSeries1.YValues.Minimum, Me.volumeSeries1.YValues.Maximum)
        End If
        If Not Me.checkBox3.Checked Then
            Green.SetMinMax(Me.candleSeries1.YValues.Minimum, Me.candleSeries1.YValues.Maximum)
        End If
    End Sub 'tChart1_Scroll
End Class 'Axis_MultiScroll
