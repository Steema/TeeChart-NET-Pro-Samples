
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing

Imports System.Windows.Forms



Public Class FastLine_Realtime
    Inherits Samples.BaseForm

    Private button1 As System.Windows.Forms.Button
    Private checkBox1 As System.Windows.Forms.CheckBox
    Private label1 As System.Windows.Forms.Label
    Private fastLine1 As Steema.TeeChart.Styles.FastLine
    Private fastLine2 As Steema.TeeChart.Styles.FastLine
    Private label2 As System.Windows.Forms.Label
    Private checkBox2 As System.Windows.Forms.CheckBox
    Private textBox2 As System.Windows.Forms.TextBox
    Private textBox3 As System.Windows.Forms.TextBox
    Private Stopped As Boolean
    Private MaxPoints As Integer
    Private ScrollPoints As Integer

    '/ <summary>
    '/ Required designer variable.
    '/ </summary>
    Private components As System.ComponentModel.IContainer = Nothing


    Public Sub New() ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ' Prepare chart for maximum speed:
        '   ClipPoints:=False
        tChart1.Header.Visible = False
        tChart1.Legend.Visible = False
        tChart1.Axes.Left.AxisPen.Width = 1
        tChart1.Axes.Bottom.AxisPen.Width = 1
        tChart1.Axes.Bottom.Labels.RoundFirstLabel = False
        tChart1.Aspect.View3D = False

        ' Private variables for this demo:
        Stopped = True
        MaxPoints = 10000
        ScrollPoints = 5000

        ' Prepare series.
        ' Disable AutoRepaint and X Order

        ' AutoRepaint=False means "real-time" drawing mode.
        ' Points are displayed just after adding them,
        ' without redrawing the whole chart.
        fastLine1.AutoRepaint = False
        fastLine2.AutoRepaint = False

        ' Set Ordering to none, to increment speed when adding points
        fastLine1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.None
        fastLine1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.None

        ' Initialize axis scales
        tChart1.Axes.Left.SetMinMax(0, 10000)
        tChart1.Axes.Bottom.SetMinMax(1, MaxPoints)

        ' Speed tips:

        ' For Windows NT, 2000 and XP only:
        ' Speed realtime painting with solid pens of width 1.
        'fastLine1.FastPen=true
        'fastLine2.FastPen=true

        ' Set axis calculations in "fast mode".
        ' Note: For Windows Me and 98 might produce bad drawings when
        '       chart zoom is very big.
        'tChart1.Axes.FastCalc=true
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


        Me.button1 = New System.Windows.Forms.Button
        Me.checkBox1 = New System.Windows.Forms.CheckBox
        Me.label1 = New System.Windows.Forms.Label
        Me.fastLine1 = New Steema.TeeChart.Styles.FastLine
        Me.fastLine2 = New Steema.TeeChart.Styles.FastLine
        Me.label2 = New System.Windows.Forms.Label
        Me.checkBox2 = New System.Windows.Forms.CheckBox
        Me.textBox2 = New System.Windows.Forms.TextBox
        Me.textBox3 = New System.Windows.Forms.TextBox
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(466, 63)
        Me.textBox1.TabIndex = 0
        Me.textBox1.Text = "New Series """"Delete"""" method to fast delete multiple points in a single call," & vbLf & "much faster than deleti" & _
        "ng multiple points using a loop." & vbLf & vbLf & "New FastLine """"FastPen"""" property to speed up drawing fastline ser" & _
        "ies" & vbLf & "in real-time mode.  ( Note: Supported only in Windows 2000 and XP )" & vbLf & vbLf & "For maximum speed set this " & _
        "property:" & vbLf & "tChart1.Axes.FastCalc=true;"
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.textBox3)
        Me.panel1.Controls.Add(Me.textBox2)
        Me.panel1.Controls.Add(Me.checkBox2)
        Me.panel1.Controls.Add(Me.label2)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Controls.Add(Me.checkBox1)
        Me.panel1.Controls.Add(Me.button1)
        Me.panel1.Location = New System.Drawing.Point(0, 63)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(466, 33)
        Me.panel1.TabIndex = 1
        ' 
        ' tChart1
        ' 
        ' 
        ' tChart1.Aspect
        ' 
        Me.tChart1.Aspect.ColorPaletteIndex = 3
        Me.tChart1.Aspect.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality
        Me.tChart1.Aspect.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        Me.tChart1.Aspect.View3D = False
        ' 
        ' tChart1.Axes
        ' 
        ' 
        ' tChart1.Axes.Bottom
        ' 
        ' 
        ' tChart1.Axes.Bottom.Grid
        ' 
        Me.tChart1.Axes.Bottom.Grid.ZPosition = 0
        ' 
        ' tChart1.Axes.Bottom.Labels
        ' 
        ' 
        ' tChart1.Axes.Bottom.Labels.Font
        ' 
        ' 
        ' tChart1.Axes.Bottom.Labels.Font.Shadow
        ' 
        Me.tChart1.Axes.Bottom.Labels.Font.Shadow.Visible = False
        ' 
        ' tChart1.Axes.Bottom.Labels.Shadow
        ' 
        Me.tChart1.Axes.Bottom.Labels.Shadow.Visible = False
        ' 
        ' tChart1.Axes.Bottom.Title
        ' 
        ' 
        ' tChart1.Axes.Bottom.Title.Font
        ' 
        ' 
        ' tChart1.Axes.Bottom.Title.Font.Shadow
        ' 
        Me.tChart1.Axes.Bottom.Title.Font.Shadow.Visible = False
        ' 
        ' tChart1.Axes.Bottom.Title.Shadow
        ' 
        Me.tChart1.Axes.Bottom.Title.Shadow.Visible = False
        ' 
        ' tChart1.Axes.Depth
        ' 
        ' 
        ' tChart1.Axes.Depth.Grid
        ' 
        Me.tChart1.Axes.Depth.Grid.ZPosition = 0
        ' 
        ' tChart1.Axes.Depth.Labels
        ' 
        ' 
        ' tChart1.Axes.Depth.Labels.Font
        ' 
        ' 
        ' tChart1.Axes.Depth.Labels.Font.Shadow
        ' 
        Me.tChart1.Axes.Depth.Labels.Font.Shadow.Visible = False
        ' 
        ' tChart1.Axes.Depth.Labels.Shadow
        ' 
        Me.tChart1.Axes.Depth.Labels.Shadow.Visible = False
        ' 
        ' tChart1.Axes.Depth.Title
        ' 
        ' 
        ' tChart1.Axes.Depth.Title.Font
        ' 
        ' 
        ' tChart1.Axes.Depth.Title.Font.Shadow
        ' 
        Me.tChart1.Axes.Depth.Title.Font.Shadow.Visible = False
        ' 
        ' tChart1.Axes.Depth.Title.Shadow
        ' 
        Me.tChart1.Axes.Depth.Title.Shadow.Visible = False
        ' 
        ' tChart1.Axes.DepthTop
        ' 
        ' 
        ' tChart1.Axes.DepthTop.Grid
        ' 
        Me.tChart1.Axes.DepthTop.Grid.ZPosition = 0
        ' 
        ' tChart1.Axes.DepthTop.Labels
        ' 
        ' 
        ' tChart1.Axes.DepthTop.Labels.Font
        ' 
        ' 
        ' tChart1.Axes.DepthTop.Labels.Font.Shadow
        ' 
        Me.tChart1.Axes.DepthTop.Labels.Font.Shadow.Visible = False
        ' 
        ' tChart1.Axes.DepthTop.Labels.Shadow
        ' 
        Me.tChart1.Axes.DepthTop.Labels.Shadow.Visible = False
        ' 
        ' tChart1.Axes.DepthTop.Title
        ' 
        ' 
        ' tChart1.Axes.DepthTop.Title.Font
        ' 
        ' 
        ' tChart1.Axes.DepthTop.Title.Font.Shadow
        ' 
        Me.tChart1.Axes.DepthTop.Title.Font.Shadow.Visible = False
        ' 
        ' tChart1.Axes.DepthTop.Title.Shadow
        ' 
        Me.tChart1.Axes.DepthTop.Title.Shadow.Visible = False
        ' 
        ' tChart1.Axes.Left
        ' 
        ' 
        ' tChart1.Axes.Left.Grid
        ' 
        Me.tChart1.Axes.Left.Grid.ZPosition = 0
        ' 
        ' tChart1.Axes.Left.Labels
        ' 
        ' 
        ' tChart1.Axes.Left.Labels.Font
        ' 
        ' 
        ' tChart1.Axes.Left.Labels.Font.Shadow
        ' 
        Me.tChart1.Axes.Left.Labels.Font.Shadow.Visible = False
        ' 
        ' tChart1.Axes.Left.Labels.Shadow
        ' 
        Me.tChart1.Axes.Left.Labels.Shadow.Visible = False
        ' 
        ' tChart1.Axes.Left.Title
        ' 
        ' 
        ' tChart1.Axes.Left.Title.Font
        ' 
        ' 
        ' tChart1.Axes.Left.Title.Font.Shadow
        ' 
        Me.tChart1.Axes.Left.Title.Font.Shadow.Visible = False
        ' 
        ' tChart1.Axes.Left.Title.Shadow
        ' 
        Me.tChart1.Axes.Left.Title.Shadow.Visible = False
        ' 
        ' tChart1.Axes.Right
        ' 
        ' 
        ' tChart1.Axes.Right.Grid
        ' 
        Me.tChart1.Axes.Right.Grid.ZPosition = 0
        ' 
        ' tChart1.Axes.Right.Labels
        ' 
        ' 
        ' tChart1.Axes.Right.Labels.Font
        ' 
        ' 
        ' tChart1.Axes.Right.Labels.Font.Shadow
        ' 
        Me.tChart1.Axes.Right.Labels.Font.Shadow.Visible = False
        ' 
        ' tChart1.Axes.Right.Labels.Shadow
        ' 
        Me.tChart1.Axes.Right.Labels.Shadow.Visible = False
        ' 
        ' tChart1.Axes.Right.Title
        ' 
        ' 
        ' tChart1.Axes.Right.Title.Font
        ' 
        ' 
        ' tChart1.Axes.Right.Title.Font.Shadow
        ' 
        Me.tChart1.Axes.Right.Title.Font.Shadow.Visible = False
        ' 
        ' tChart1.Axes.Right.Title.Shadow
        ' 
        Me.tChart1.Axes.Right.Title.Shadow.Visible = False
        ' 
        ' tChart1.Axes.Top
        ' 
        ' 
        ' tChart1.Axes.Top.Grid
        ' 
        Me.tChart1.Axes.Top.Grid.ZPosition = 0
        ' 
        ' tChart1.Axes.Top.Labels
        ' 
        ' 
        ' tChart1.Axes.Top.Labels.Font
        ' 
        ' 
        ' tChart1.Axes.Top.Labels.Font.Shadow
        ' 
        Me.tChart1.Axes.Top.Labels.Font.Shadow.Visible = False
        ' 
        ' tChart1.Axes.Top.Labels.Shadow
        ' 
        Me.tChart1.Axes.Top.Labels.Shadow.Visible = False
        ' 
        ' tChart1.Axes.Top.Title
        ' 
        ' 
        ' tChart1.Axes.Top.Title.Font
        ' 
        ' 
        ' tChart1.Axes.Top.Title.Font.Shadow
        ' 
        Me.tChart1.Axes.Top.Title.Font.Shadow.Visible = False
        ' 
        ' tChart1.Axes.Top.Title.Shadow
        ' 
        Me.tChart1.Axes.Top.Title.Shadow.Visible = False
        ' 
        ' tChart1.Footer
        ' 
        ' 
        ' tChart1.Footer.Font
        ' 
        ' 
        ' tChart1.Footer.Font.Shadow
        ' 
        Me.tChart1.Footer.Font.Shadow.Visible = False
        ' 
        ' tChart1.Footer.Shadow
        ' 
        Me.tChart1.Footer.Shadow.Visible = False
        ' 
        ' tChart1.Header
        ' 
        ' 
        ' tChart1.Header.Font
        ' 
        ' 
        ' tChart1.Header.Font.Brush
        ' 
        Me.tChart1.Header.Font.Brush.Color = System.Drawing.Color.FromArgb(CType(254, Byte), CType(0, Byte), CType(0, Byte), CType(128, Byte))
        ' 
        ' tChart1.Header.Font.Shadow
        ' 
        ' 
        ' tChart1.Header.Font.Shadow.Brush
        ' 
        Me.tChart1.Header.Font.Shadow.Brush.Color = System.Drawing.Color.FromArgb(CType(254, Byte), CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.tChart1.Header.Lines = New String() {"Area series gradient & transparency"}
        ' 
        ' tChart1.Header.Shadow
        ' 
        Me.tChart1.Header.Shadow.Visible = False
        ' 
        ' tChart1.Legend
        ' 
        ' 
        ' tChart1.Legend.Font
        ' 
        ' 
        ' tChart1.Legend.Font.Shadow
        ' 
        Me.tChart1.Legend.Font.Shadow.Visible = False
        ' 
        ' tChart1.Legend.Title
        ' 
        ' 
        ' tChart1.Legend.Title.Font
        ' 
        Me.tChart1.Legend.Title.Font.Bold = True
        ' 
        ' tChart1.Legend.Title.Font.Shadow
        ' 
        Me.tChart1.Legend.Title.Font.Shadow.Visible = False
        ' 
        ' tChart1.Legend.Title.Pen
        ' 
        Me.tChart1.Legend.Title.Pen.Visible = False
        ' 
        ' tChart1.Legend.Title.Shadow
        ' 
        Me.tChart1.Legend.Title.Shadow.Visible = False
        Me.tChart1.Location = New System.Drawing.Point(0, 96)
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
        Me.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(254, Byte), CType(255, Byte), CType(255, Byte), CType(255, Byte))
        Me.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(254, Byte), CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(254, Byte), CType(192, Byte), CType(192, Byte), CType(255, Byte))
        Me.tChart1.Panel.Brush.Gradient.UseMiddle = True
        Me.tChart1.Panel.Brush.Gradient.Visible = True
        ' 
        ' tChart1.Panel.Gradient
        ' 
        Me.tChart1.Panel.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(254, Byte), CType(255, Byte), CType(255, Byte), CType(255, Byte))
        Me.tChart1.Panel.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(254, Byte), CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.tChart1.Panel.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(254, Byte), CType(192, Byte), CType(192, Byte), CType(255, Byte))
        Me.tChart1.Panel.Gradient.UseMiddle = True
        Me.tChart1.Panel.Gradient.Visible = True
        ' 
        ' tChart1.Panel.Shadow
        ' 
        Me.tChart1.Panel.Shadow.Visible = False
        Me.tChart1.Series.Add(Me.fastLine1)
        Me.tChart1.Series.Add(Me.fastLine2)
        Me.tChart1.Size = New System.Drawing.Size(466, 190)
        ' 
        ' tChart1.SubFooter
        ' 
        ' 
        ' tChart1.SubFooter.Font
        ' 
        ' 
        ' tChart1.SubFooter.Font.Shadow
        ' 
        Me.tChart1.SubFooter.Font.Shadow.Visible = False
        ' 
        ' tChart1.SubFooter.Shadow
        ' 
        Me.tChart1.SubFooter.Shadow.Visible = False
        ' 
        ' tChart1.SubHeader
        ' 
        ' 
        ' tChart1.SubHeader.Font
        ' 
        ' 
        ' tChart1.SubHeader.Font.Shadow
        ' 
        Me.tChart1.SubHeader.Font.Shadow.Visible = False
        ' 
        ' tChart1.SubHeader.Shadow
        ' 
        Me.tChart1.SubHeader.Shadow.Visible = False
        Me.tChart1.TabIndex = 2
        ' 
        ' tChart1.Walls
        ' 
        ' 
        ' tChart1.Walls.Back
        ' 
        Me.tChart1.Walls.Back.AutoHide = False
        ' 
        ' tChart1.Walls.Back.Shadow
        ' 
        Me.tChart1.Walls.Back.Shadow.Visible = False
        ' 
        ' tChart1.Walls.Bottom
        ' 
        Me.tChart1.Walls.Bottom.AutoHide = False
        ' 
        ' tChart1.Walls.Bottom.Shadow
        ' 
        Me.tChart1.Walls.Bottom.Shadow.Visible = False
        ' 
        ' tChart1.Walls.Left
        ' 
        Me.tChart1.Walls.Left.AutoHide = False
        ' 
        ' tChart1.Walls.Left.Shadow
        ' 
        Me.tChart1.Walls.Left.Shadow.Visible = False
        ' 
        ' tChart1.Walls.Right
        ' 
        Me.tChart1.Walls.Right.AutoHide = False
        ' 
        ' tChart1.Walls.Right.Shadow
        ' 
        Me.tChart1.Walls.Right.Shadow.Visible = False
        ' 
        ' button1
        ' 
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.Location = New System.Drawing.Point(8, 5)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(45, 23)
        Me.button1.TabIndex = 0
        Me.button1.Text = "&Start !"
        AddHandler button1.Click, AddressOf Me.button1_Click
        ' 
        ' checkBox1
        ' 
        Me.checkBox1.Checked = True
        Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox1.Location = New System.Drawing.Point(69, 9)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(99, 16)
        Me.checkBox1.TabIndex = 1
        Me.checkBox1.Text = "&Draw All Points"
        AddHandler checkBox1.CheckedChanged, AddressOf Me.checkBox1_CheckedChanged
        ' 
        ' label1
        ' 
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(166, 10)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(70, 16)
        Me.label1.TabIndex = 2
        Me.label1.Text = "&Total Points :"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        ' 
        ' fastLine1
        ' 
        ' 
        ' fastLine1.LinePen
        ' 
        Me.fastLine1.LinePen.Color = System.Drawing.Color.FromArgb(CType(255, Byte), CType(153, Byte), CType(102, Byte))
        ' 
        ' fastLine1.Marks
        ' 
        ' 
        ' fastLine1.Marks.Callout
        ' 
        Me.fastLine1.Marks.Callout.Arrow = Me.fastLine1.Marks.Arrow
        Me.fastLine1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None
        Me.fastLine1.Marks.Callout.ArrowHeadSize = 8
        ' 
        ' fastLine1.Marks.Callout.Brush
        ' 
        Me.fastLine1.Marks.Callout.Brush.Color = System.Drawing.Color.Black
        Me.fastLine1.Marks.Callout.Distance = 0
        Me.fastLine1.Marks.Callout.Draw3D = False
        Me.fastLine1.Marks.Callout.Length = 10
        Me.fastLine1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        ' 
        ' fastLine1.Marks.Font
        ' 
        ' 
        ' fastLine1.Marks.Font.Shadow
        ' 
        Me.fastLine1.Marks.Font.Shadow.Visible = False
        Me.fastLine1.Title = "fastLine1"
        ' 
        ' fastLine1.XValues
        ' 
        Me.fastLine1.XValues.DataMember = "X"
        Me.fastLine1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' fastLine1.YValues
        ' 
        Me.fastLine1.YValues.DataMember = "Y"
        ' 
        ' fastLine2
        ' 
        ' 
        ' fastLine2.LinePen
        ' 
        Me.fastLine2.LinePen.Color = System.Drawing.Color.FromArgb(CType(255, Byte), CType(102, Byte), CType(102, Byte))
        ' 
        ' fastLine2.Marks
        ' 
        ' 
        ' fastLine2.Marks.Callout
        ' 
        Me.fastLine2.Marks.Callout.Arrow = Me.fastLine2.Marks.Arrow
        Me.fastLine2.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None
        Me.fastLine2.Marks.Callout.ArrowHeadSize = 8
        ' 
        ' fastLine2.Marks.Callout.Brush
        ' 
        Me.fastLine2.Marks.Callout.Brush.Color = System.Drawing.Color.Black
        Me.fastLine2.Marks.Callout.Distance = 0
        Me.fastLine2.Marks.Callout.Draw3D = False
        Me.fastLine2.Marks.Callout.Length = 10
        Me.fastLine2.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        ' 
        ' fastLine2.Marks.Font
        ' 
        ' 
        ' fastLine2.Marks.Font.Shadow
        ' 
        Me.fastLine2.Marks.Font.Shadow.Visible = False
        Me.fastLine2.Title = "fastLine2"
        ' 
        ' fastLine2.XValues
        ' 
        Me.fastLine2.XValues.DataMember = "X"
        Me.fastLine2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' fastLine2.YValues
        ' 
        Me.fastLine2.YValues.DataMember = "Y"
        ' 
        ' label2
        ' 
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(285, 10)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(39, 16)
        Me.label2.TabIndex = 3
        Me.label2.Text = "&Scroll :"
        Me.label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        ' 
        ' checkBox2
        ' 
        Me.checkBox2.Checked = True
        Me.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox2.Location = New System.Drawing.Point(384, 9)
        Me.checkBox2.Name = "checkBox2"
        Me.checkBox2.Size = New System.Drawing.Size(67, 16)
        Me.checkBox2.TabIndex = 4
        Me.checkBox2.Text = "&Fast Pen"
        AddHandler checkBox2.CheckedChanged, AddressOf Me.checkBox2_CheckedChanged
        ' 
        ' textBox2
        ' 
        Me.textBox2.Location = New System.Drawing.Point(234, 8)
        Me.textBox2.Name = "textBox2"
        Me.textBox2.Size = New System.Drawing.Size(46, 20)
        Me.textBox2.TabIndex = 5
        Me.textBox2.Text = "10000"
        Me.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        ' 
        ' textBox3
        ' 
        Me.textBox3.Location = New System.Drawing.Point(326, 8)
        Me.textBox3.Name = "textBox3"
        Me.textBox3.Size = New System.Drawing.Size(46, 20)
        Me.textBox3.TabIndex = 6
        Me.textBox3.Text = "5000"
        Me.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        ' 
        ' FastLine_Realtime
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(466, 286)
        Me.Name = "FastLine_Realtime"
        AddHandler Closed, AddressOf Me.FastLine_Realtime_Closed
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        
    End Sub

#End Region

    Private Sub RealTimeAdd(ByVal series As Steema.TeeChart.Styles.FastLine)
        Dim Rnd As Random = New Random()
        ' Next random point
        series.Add(series.XValues.Last + 1, series.YValues.Last + Rnd.Next(10) - 4.5)
    End Sub

    ' When the chart is filled with points, this procedure
    ' deletes and scrolls points to the left.
    Private Sub DoScrollPoints()
        Dim tmp As Double
        Dim tmpMin As Double
        Dim TmpMax As Double
        ' Delete multiple points with a single call.
        ' Much faster than deleting points using a loop.

        fastLine1.Delete(0, ScrollPoints)
        fastLine2.Delete(0, ScrollPoints)

        ' Scroll horizontal bottom axis
        tmp = fastLine1.XValues.Last
        tChart1.Axes.Bottom.SetMinMax(tmp - MaxPoints + ScrollPoints, tmp + ScrollPoints)

        ' Scroll vertical left axis
        tmpMin = fastLine1.YValues.Minimum
        If (fastLine2.YValues.Minimum < tmpMin) Then
            tmpMin = fastLine2.YValues.Minimum
        End If

        TmpMax = fastLine1.YValues.Maximum
        If (fastLine2.YValues.Maximum > TmpMax) Then
            TmpMax = fastLine2.YValues.Maximum
        End If

        tChart1.Axes.Left.SetMinMax(tmpMin - tmpMin * 0.2, TmpMax + TmpMax * 0.2)

        ' Do chart repaint after deleting and scrolling
        Application.DoEvents()
    End Sub

    Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        If (Stopped) Then

            ' Start loop...
            button1.Text = "&Stop"
            textBox2.Enabled = False
            textBox3.Enabled = False

            ' Prepare variables
            MaxPoints = Convert.ToInt32(textBox2.Text)
            ScrollPoints = Convert.ToInt32(textBox3.Text)
            tChart1.Axes.Bottom.SetMinMax(1, MaxPoints)

            ' Clear
            fastLine1.Clear()
            fastLine2.Clear()
            Dim r As Random = New Random()
            fastLine1.Add(r.Next(10000))
            fastLine2.Add(r.Next(5000))
            Application.DoEvents()

            Stopped = False

            ' Start loop
            While (Not Stopped)

                ' Add one more point
                RealTimeAdd(fastLine1)
                RealTimeAdd(fastLine2)

                ' Delete and Scroll points to the left						
                If (fastLine1.Count > MaxPoints - 1) Then
                    DoScrollPoints()
                End If
            End While

        Else
            ' Finish
            Stopped = True
            button1.Text = "&Start"
            textBox2.Enabled = True
            textBox3.Enabled = True
        End If
    End Sub

    Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        fastLine1.DrawAllPoints = checkBox1.Checked
        fastLine2.DrawAllPoints = checkBox1.Checked
    End Sub

    Private Sub FastLine_Realtime_Closed(ByVal sender As Object, ByVal e As System.EventArgs)
        Stopped = True  ' Break loop to allow close form
    End Sub

    Private Sub checkBox2_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        ' When FastLine series have AutoRepaint = False ,
        ' setting FastPen to True increases speed.
        'fastLine1.FastPen=checkBox2.Checked
        'fastLine2.FastPen=checkBox2.Checked		
    End Sub

End Class

