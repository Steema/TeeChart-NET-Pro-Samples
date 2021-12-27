
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms


Public Class Log_CustomIncrement
    Inherits Steema.TeeChart.Samples.BaseForm
    Private line1 As Steema.TeeChart.Styles.Line
    Private components As System.ComponentModel.IContainer = Nothing
    Private Const majorcount As Integer = 4
    Private majors(majorcount) As Double
    Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
    Private WithEvents checkBox2 As System.Windows.Forms.CheckBox
    Private minors(2 * majorcount - 2) As Double
    
    Public Sub New() ' This call is required by the Windows Form Designer.
        InitializeComponent()

        'major(ticks = labels)
        majors(0) = 0.1
        majors(1) = 0.2
        majors(2) = 0.5
        majors(3) = 1.0

        ' two minors between each major tick 
        minors(0) = 0.12
        minors(1) = 0.17

        minors(2) = 0.3
        minors(3) = 0.38

        minors(4) = 0.55
        minors(5) = 0.7

        Dim t As Integer
        For t = 0 To 100 - 1 Step t + 1
            line1.Add(t, 0.002 * (5 * t - 50) * (2 * t - 10) + 5.0)
        Next t
    End Sub

    '/ <summary>
    '/// Clean up any resources being used.
    '/// </summary>
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
        Me.line1 = New Steema.TeeChart.Styles.Line
        Me.checkBox1 = New System.Windows.Forms.CheckBox
        Me.checkBox2 = New System.Windows.Forms.CheckBox
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.BackColor = System.Drawing.Color.AliceBlue
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Text = "Using custom axis labels it's fairly easy to construct non-linear axis scale. " + vbLf + "The following example " + _
        "demonstrates how to setup custom logarithmic axis increment and minor ticks for vertical axis." + vbLf + "In th" + _
        "e example we setup four axis labels per decade and additionally two minor ticklines between each lab" + _
        "el (see code)."
        ' 
        ' panel1
        ' 
        Me.panel1.BackColor = System.Drawing.SystemColors.Control
        Me.panel1.Controls.Add(Me.checkBox2)
        Me.panel1.Controls.Add(Me.checkBox1)
        Me.panel1.Name = "panel1"
        ' 
        ' tChart1
        ' 
        ' 
        ' tChart1.Aspect
        ' 
        Me.tChart1.Aspect.ColorPaletteIndex = 6
        Me.tChart1.Aspect.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality
        Me.tChart1.Aspect.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        Me.tChart1.Aspect.ThemeIndex = 7
        Me.tChart1.Aspect.View3D = False
        ' 
        ' tChart1.Axes
        ' 
        ' 
        ' tChart1.Axes.Bottom
        ' 
        ' 
        ' tChart1.Axes.Bottom.AxisPen
        ' 
        Me.tChart1.Axes.Bottom.AxisPen.Color = System.Drawing.Color.FromArgb(CType(254, Byte), CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.tChart1.Axes.Bottom.AxisPen.Width = 1
        ' 
        ' tChart1.Axes.Bottom.Grid
        ' 
        Me.tChart1.Axes.Bottom.Grid.Color = System.Drawing.Color.Gray
        ' 
        ' tChart1.Axes.Bottom.MinorTicks
        ' 
        Me.tChart1.Axes.Bottom.MinorTicks.Visible = False
        ' 
        ' tChart1.Axes.Bottom.Ticks
        ' 
        Me.tChart1.Axes.Bottom.Ticks.Color = System.Drawing.Color.Black
        Me.tChart1.Axes.Bottom.Ticks.Length = 2
        ' 
        ' tChart1.Axes.Bottom.TicksInner
        ' 
        Me.tChart1.Axes.Bottom.TicksInner.Visible = False
        ' 
        ' tChart1.Axes.Depth
        ' 
        ' 
        ' tChart1.Axes.Depth.AxisPen
        ' 
        Me.tChart1.Axes.Depth.AxisPen.Width = 1
        ' 
        ' tChart1.Axes.Depth.Grid
        ' 
        Me.tChart1.Axes.Depth.Grid.Color = System.Drawing.Color.Gray
        Me.tChart1.Axes.Depth.Grid.Style = System.Drawing.Drawing2D.DashStyle.Solid
        ' 
        ' tChart1.Axes.Depth.MinorTicks
        ' 
        Me.tChart1.Axes.Depth.MinorTicks.Visible = False
        ' 
        ' tChart1.Axes.Depth.Ticks
        ' 
        Me.tChart1.Axes.Depth.Ticks.Color = System.Drawing.Color.Black
        Me.tChart1.Axes.Depth.Ticks.Length = 2
        ' 
        ' tChart1.Axes.Depth.TicksInner
        ' 
        Me.tChart1.Axes.Depth.TicksInner.Visible = False
        ' 
        ' tChart1.Axes.Left
        ' 
        ' 
        ' tChart1.Axes.Left.AxisPen
        ' 
        Me.tChart1.Axes.Left.AxisPen.Color = System.Drawing.Color.FromArgb(CType(254, Byte), CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.tChart1.Axes.Left.AxisPen.Width = 1
        ' 
        ' tChart1.Axes.Left.Grid
        ' 
        Me.tChart1.Axes.Left.Grid.Color = System.Drawing.Color.Gray
        ' 
        ' tChart1.Axes.Left.Labels
        ' 
        Me.tChart1.Axes.Left.Labels.CustomSize = 50
        Me.tChart1.Axes.Left.Logarithmic = True
        ' 
        ' tChart1.Axes.Left.MinorTicks
        ' 
        Me.tChart1.Axes.Left.MinorTicks.Visible = False
        ' 
        ' tChart1.Axes.Left.Ticks
        ' 
        Me.tChart1.Axes.Left.Ticks.Color = System.Drawing.Color.Black
        Me.tChart1.Axes.Left.Ticks.Length = 2
        ' 
        ' tChart1.Axes.Left.TicksInner
        ' 
        Me.tChart1.Axes.Left.TicksInner.Visible = False
        ' 
        ' tChart1.Axes.Right
        ' 
        ' 
        ' tChart1.Axes.Right.AxisPen
        ' 
        Me.tChart1.Axes.Right.AxisPen.Width = 1
        ' 
        ' tChart1.Axes.Right.Grid
        ' 
        Me.tChart1.Axes.Right.Grid.Color = System.Drawing.Color.Gray
        Me.tChart1.Axes.Right.Grid.Style = System.Drawing.Drawing2D.DashStyle.Solid
        ' 
        ' tChart1.Axes.Right.MinorTicks
        ' 
        Me.tChart1.Axes.Right.MinorTicks.Visible = False
        ' 
        ' tChart1.Axes.Right.Ticks
        ' 
        Me.tChart1.Axes.Right.Ticks.Color = System.Drawing.Color.Black
        Me.tChart1.Axes.Right.Ticks.Length = 2
        ' 
        ' tChart1.Axes.Right.TicksInner
        ' 
        Me.tChart1.Axes.Right.TicksInner.Visible = False
        ' 
        ' tChart1.Axes.Top
        ' 
        ' 
        ' tChart1.Axes.Top.AxisPen
        ' 
        Me.tChart1.Axes.Top.AxisPen.Width = 1
        ' 
        ' tChart1.Axes.Top.Grid
        ' 
        Me.tChart1.Axes.Top.Grid.Color = System.Drawing.Color.Gray
        Me.tChart1.Axes.Top.Grid.Style = System.Drawing.Drawing2D.DashStyle.Solid
        ' 
        ' tChart1.Axes.Top.MinorTicks
        ' 
        Me.tChart1.Axes.Top.MinorTicks.Visible = False
        ' 
        ' tChart1.Axes.Top.Ticks
        ' 
        Me.tChart1.Axes.Top.Ticks.Color = System.Drawing.Color.Black
        Me.tChart1.Axes.Top.Ticks.Length = 2
        ' 
        ' tChart1.Axes.Top.TicksInner
        ' 
        Me.tChart1.Axes.Top.TicksInner.Visible = False
        ' 
        ' tChart1.Header
        ' 
        ' 
        ' tChart1.Header.Brush
        ' 
        Me.tChart1.Header.Brush.Color = System.Drawing.Color.White
        ' 
        ' tChart1.Header.Gradient
        ' 
        Me.tChart1.Header.Brush.Gradient.EndColor = System.Drawing.Color.Gray
        Me.tChart1.Header.Brush.Gradient.MiddleColor = System.Drawing.Color.Empty
        Me.tChart1.Header.Brush.Gradient.StartColor = System.Drawing.Color.White
        Me.tChart1.Header.Brush.Gradient.Visible = True
        ' 
        ' tChart1.Header.Font
        ' 
        ' 
        ' tChart1.Header.Font.Brush
        ' 
        Me.tChart1.Header.Font.Brush.Color = System.Drawing.Color.FromArgb(CType(254, Byte), CType(0, Byte), CType(0, Byte), CType(128, Byte))
        Me.tChart1.Header.Font.Name = "Verdana"
        ' 
        ' tChart1.Header.Font.Shadow
        ' 
        ' 
        ' tChart1.Header.Font.Shadow.Brush
        ' 
        Me.tChart1.Header.Font.Shadow.Brush.Color = System.Drawing.Color.FromArgb(CType(254, Byte), CType(192, Byte), CType(192, Byte), CType(192, Byte))
        Me.tChart1.Header.Font.Shadow.Visible = True
        ' 
        ' tChart1.Header.Gradient
        ' 
        Me.tChart1.Header.Gradient.EndColor = System.Drawing.Color.Gray
        Me.tChart1.Header.Gradient.MiddleColor = System.Drawing.Color.Empty
        Me.tChart1.Header.Gradient.StartColor = System.Drawing.Color.White
        Me.tChart1.Header.Gradient.Visible = True
        Me.tChart1.Header.Lines = New String() {"Logarithmic axis labels"}
        ' 
        ' tChart1.Legend
        ' 
        ' 
        ' tChart1.Legend.DividingLines
        ' 
        Me.tChart1.Legend.DividingLines.Visible = True
        ' 
        ' tChart1.Legend.Font
        ' 
        Me.tChart1.Legend.Font.Name = "Verdana"
        ' 
        ' tChart1.Legend.Shadow
        ' 
        ' 
        ' tChart1.Legend.Shadow.Brush
        ' 
        Me.tChart1.Legend.Shadow.Brush.Color = System.Drawing.Color.FromArgb(CType(254, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
        Me.tChart1.Legend.Shadow.Height = 0
        Me.tChart1.Legend.Shadow.Width = 0
        Me.tChart1.Legend.Transparent = True
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Bevel
        ' 
        Me.tChart1.Panel.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None
        ' 
        ' tChart1.Panel.Brush
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.White
        ' 
        ' tChart1.Panel.Gradient
        ' 
        Me.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(254, Byte), CType(255, Byte), CType(255, Byte), CType(255, Byte))
        Me.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(254, Byte), CType(255, Byte), CType(255, Byte), CType(210, Byte))
        Me.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(254, Byte), CType(255, Byte), CType(255, Byte), CType(210, Byte))
        Me.tChart1.Panel.Brush.Gradient.UseMiddle = True
        Me.tChart1.Panel.Brush.Gradient.Visible = True
        ' 
        ' tChart1.Panel.Gradient
        ' 
        Me.tChart1.Panel.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(254, Byte), CType(255, Byte), CType(255, Byte), CType(255, Byte))
        Me.tChart1.Panel.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(254, Byte), CType(255, Byte), CType(255, Byte), CType(210, Byte))
        Me.tChart1.Panel.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(254, Byte), CType(255, Byte), CType(255, Byte), CType(210, Byte))
        Me.tChart1.Panel.Gradient.UseMiddle = True
        Me.tChart1.Panel.Gradient.Visible = True
        ' 
        ' tChart1.Panel.Pen
        ' 
        Me.tChart1.Panel.Pen.Visible = True
        ' 
        ' tChart1.Panel.Shadow
        ' 
        Me.tChart1.Panel.Shadow.Height = 0
        Me.tChart1.Panel.Shadow.Width = 0
        Me.tChart1.Series.Add(Me.line1)
        ' 
        ' tChart1.Walls
        ' 
        ' 
        ' tChart1.Walls.Back
        ' 
        Me.tChart1.Walls.Back.ApplyDark = False
        ' 
        ' tChart1.Walls.Back.Brush
        ' 
        Me.tChart1.Walls.Back.Brush.Color = System.Drawing.Color.White
        Me.tChart1.Walls.Back.Size = 8
        Me.tChart1.Walls.Back.Transparent = False
        Me.tChart1.Walls.Back.Visible = False
        ' 
        ' tChart1.Walls.Bottom
        ' 
        Me.tChart1.Walls.Bottom.ApplyDark = False
        Me.tChart1.Walls.Bottom.Size = 8
        ' 
        ' tChart1.Walls.Left
        ' 
        Me.tChart1.Walls.Left.ApplyDark = False
        ' 
        ' tChart1.Walls.Left.Brush
        ' 
        Me.tChart1.Walls.Left.Brush.Color = System.Drawing.Color.White
        Me.tChart1.Walls.Left.Size = 8
        ' 
        ' tChart1.Walls.Right
        ' 
        Me.tChart1.Walls.Right.ApplyDark = False
        ' 
        ' tChart1.Walls.Right.Brush
        ' 
        Me.tChart1.Walls.Right.Brush.Color = System.Drawing.Color.White
        Me.tChart1.Walls.Right.Size = 8
        AddHandler tChart1.BeforeDrawAxes, AddressOf Me.tChart1_BeforeDrawAxes
        ' 
        ' line1
        ' 
        ' 
        ' line1.Brush
        ' 
        Me.line1.Brush.Color = System.Drawing.Color.FromArgb(CType(0, Byte), CType(165, Byte), CType(255, Byte))
        ' 
        ' line1.Marks
        ' 
        ' 
        ' line1.Marks.Arrow
        ' 
        Me.line1.Marks.Arrow.Color = System.Drawing.Color.Black
        ' 
        ' line1.Marks.Font
        ' 
        Me.line1.Marks.Font.Size = 10
        Me.line1.Marks.Transparent = True
        ' 
        ' line1.Pointer
        ' 
        Me.line1.Pointer.HorizSize = 3
        Me.line1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Diamond
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
        ' checkBox1
        ' 
        Me.checkBox1.Checked = True
        Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox1.Location = New System.Drawing.Point(8, 8)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(152, 24)
        Me.checkBox1.TabIndex = 0
        Me.checkBox1.Text = "Logarithmic vertical axis"
        AddHandler checkBox1.CheckedChanged, AddressOf Me.checkBox1_CheckedChanged
        ' 
        ' checkBox2
        ' 
        Me.checkBox2.Location = New System.Drawing.Point(176, 8)
        Me.checkBox2.Name = "checkBox2"
        Me.checkBox2.Size = New System.Drawing.Size(176, 24)
        Me.checkBox2.TabIndex = 1
        Me.checkBox2.Text = "Custom log axis increment"
        AddHandler checkBox2.CheckedChanged, AddressOf Me.checkBox2_CheckedChanged
        ' 
        ' Log_CustomIncrement
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(440, 317)
        Me.Name = "Log_CustomIncrement"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub 'New
#End Region


    '/ <summary>
    '/ Calculates the decade of 0.y x 10^n 
    '/ </summary>
    '/ <param name="Value"></param>
    '/ <returns>the decade number</returns>
    Private Function GetDecade(ByVal Value As Double) As Integer
        Dim absval As Double = Math.Abs(Value)
        Dim res As Integer = 0
        If absval >= 1 Then
            While absval >= 1.0

                absval /= 10.0
                res += 1 '

            End While
        Else
            While absval < 1.0

                absval *= 10.0
                res -= 1 '
            End While
        End If
        Return res
    End Function 'GetDecade
    '/ <summary> 
    '/ Generates specific logarithmic labels for axis. 
    '/ </summary> 
    '/ <param name="g">Graphics3D object</param> 
    '/ <param name="ax">Axis</param> 
    '/ <param name="majorlabels">array of logarithmic axis labels</param> 
    '/ <param name="minorticks">array of minor ticks</param> 
    '/ <param name="start">left/lower bound for minor tick</param> 
    '/ <param name="end">right/upper bound for minor tick</param> 
    Private Sub GenerateLogLabels(ByVal g As Steema.TeeChart.Drawing.Graphics3D, ByVal ax As Steema.TeeChart.Axis, ByVal majorlabels() As Double, ByVal minorticks() As Double, ByVal start As Integer, ByVal [end] As Integer)
        ax.Labels.Items.Clear()
        Dim mindecade As Integer = GetDecade(ax.Minimum)
        Dim maxdecade As Integer = GetDecade(ax.Maximum)
        Dim currval As Double
        Dim tickypos As Integer

        start -= ax.MinorTicks.Length
        [end] += ax.MinorTicks.Length

        g.Pen.Style = ax.MinorGrid.Style
        g.Pen.Color = ax.MinorGrid.Color

        Dim i As Integer
        For i = mindecade To maxdecade
            Dim j As Integer
            For j = 0 To majorlabels.Length - 1
                currval = majorlabels(j) * Math.Pow(10, i)
                If currval >= ax.Minimum AndAlso currval <= ax.Maximum Then
                    ax.Labels.Items.Add(currval)
                End If
            Next j
            Dim k As Integer
            For k = 0 To minorticks.Length - 1
                currval = minorticks(k) * Math.Pow(10, i)
                If currval >= ax.Minimum AndAlso currval <= ax.Maximum Then
                    tickypos = ax.CalcPosValue(currval)
                    If ax.Horizontal Then
                        g.Line(tickypos, start, tickypos, [end])
                    Else
                        g.Line(start, tickypos, [end], tickypos)
                    End If
                End If
            Next k
        Next i
    End Sub 'GenerateLogLabels

    Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        tChart1.Axes.Left.Logarithmic = checkBox1.Checked
    End Sub 'checkBox1_CheckedChanged


    Private Sub checkBox2_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        tChart1.Invalidate()
    End Sub 'checkBox2_CheckedChanged


    Private Sub tChart1_BeforeDrawAxes(ByVal sender As Object, ByVal g As Steema.TeeChart.Drawing.Graphics3D) Handles tChart1.BeforeDrawAxes
        If checkBox1.Checked AndAlso checkBox2.Checked Then
            GenerateLogLabels(g, line1.GetVertAxis, majors, minors, line1.GetHorizAxis.IStartPos, line1.GetHorizAxis.IEndPos)
            tChart1.Invalidate()
        Else
            line1.GetVertAxis.Labels.Items.Clear()
        End If
    End Sub 'tChart1_BeforeDrawAxes
End Class 'Log_CustomIncrement