
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms


Public Class Function_Mode
    Inherits Steema.TeeChart.Samples.BaseForm
    Private checkBox1 As System.Windows.Forms.CheckBox
    Private checkBox2 As System.Windows.Forms.CheckBox
    Private fastLine1 As Steema.TeeChart.Styles.FastLine
    Private line1 As Steema.TeeChart.Styles.Line
    Private modeFunction1 As Steema.TeeChart.Functions.ModeFunction
    Private components As System.ComponentModel.IContainer = Nothing
    
    Public Sub New() ' This call is required by the Windows Form Designer.
        InitializeComponent()

        fastLine1.Add(40)
        fastLine1.Add(86)
        fastLine1.Add(34)
        fastLine1.Add(138)
        fastLine1.Add(79)
        fastLine1.Add(76)
        fastLine1.Add(19)
        fastLine1.Add(31)
        fastLine1.Add(106)
        fastLine1.Add(31)
        fastLine1.Add(123)
        fastLine1.Add(155)
        fastLine1.Add(34)
        fastLine1.Add(31)
        fastLine1.Add(46)
        fastLine1.Add(123)
        fastLine1.Add(150)
        
        fastLine1.SetNull(7)
        fastLine1.SetNull(9)
        fastLine1.SetNull(14)
        
        line1.CheckDataSource()
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
        Me.checkBox1 = New System.Windows.Forms.CheckBox
        Me.checkBox2 = New System.Windows.Forms.CheckBox
        Me.fastLine1 = New Steema.TeeChart.Styles.FastLine
        Me.line1 = New Steema.TeeChart.Styles.Line
        Me.modeFunction1 = New Steema.TeeChart.Functions.ModeFunction
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Text = ("The Mode function calculates the value with highest count of duplicates inside " & vbCrLf + "the source series data." & vbCrLf & "Includes the option to ignore null source values.")
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.checkBox2)
        Me.panel1.Controls.Add(Me.checkBox1)
        Me.panel1.Name = "panel1"
        ' 
        ' tChart1
        ' 
        ' 
        ' tChart1.Aspect
        ' 
        Me.tChart1.Aspect.ColorPaletteIndex = 4
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
        Me.tChart1.Axes.Bottom.AxisPen.Width = 1
        ' 
        ' tChart1.Axes.Bottom.Grid
        ' 
        Me.tChart1.Axes.Bottom.Grid.Color = System.Drawing.Color.Gray
        Me.tChart1.Axes.Bottom.Grid.Style = System.Drawing.Drawing2D.DashStyle.Solid
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
        Me.tChart1.Axes.Left.AxisPen.Width = 1
        ' 
        ' tChart1.Axes.Left.Grid
        ' 
        Me.tChart1.Axes.Left.Grid.Color = System.Drawing.Color.Gray
        Me.tChart1.Axes.Left.Grid.Style = System.Drawing.Drawing2D.DashStyle.Solid
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
        Me.tChart1.Header.Font.Brush.Color = System.Drawing.Color.Black
        Me.tChart1.Header.Font.Size = 12
        ' 
        ' tChart1.Header.Gradient
        ' 
        Me.tChart1.Header.Gradient.EndColor = System.Drawing.Color.Gray
        Me.tChart1.Header.Gradient.MiddleColor = System.Drawing.Color.Empty
        Me.tChart1.Header.Gradient.StartColor = System.Drawing.Color.White
        Me.tChart1.Header.Gradient.Visible = True
        Me.tChart1.Header.Lines = New String() {"TeeChart"}
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
        Me.tChart1.Legend.Font.Size = 10
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
        Me.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.Yellow
        Me.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.Empty
        Me.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.White
        ' 
        ' tChart1.Panel.Gradient
        ' 
        Me.tChart1.Panel.Gradient.EndColor = System.Drawing.Color.Yellow
        Me.tChart1.Panel.Gradient.MiddleColor = System.Drawing.Color.Empty
        Me.tChart1.Panel.Gradient.StartColor = System.Drawing.Color.White
        ' 
        ' tChart1.Panel.Pen
        ' 
        Me.tChart1.Panel.Pen.Visible = True
        ' 
        ' tChart1.Panel.Shadow
        ' 
        Me.tChart1.Panel.Shadow.Height = 0
        Me.tChart1.Panel.Shadow.Width = 0
        Me.tChart1.Series.Add(Me.fastLine1)
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
        ' 
        ' checkBox1
        ' 
        Me.checkBox1.Checked = True
        Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox1.Location = New System.Drawing.Point(24, 8)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(184, 24)
        Me.checkBox1.TabIndex = 0
        Me.checkBox1.Text = "Include Null values in calculation"
        AddHandler checkBox1.Click, AddressOf Me.checkBox1_Click
        AddHandler checkBox1.CheckedChanged, AddressOf Me.checkBox1_CheckedChanged
        ' 
        ' checkBox2
        ' 
        Me.checkBox2.Checked = True
        Me.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox2.Location = New System.Drawing.Point(248, 9)
        Me.checkBox2.Name = "checkBox2"
        Me.checkBox2.Size = New System.Drawing.Size(192, 24)
        Me.checkBox2.TabIndex = 1
        Me.checkBox2.Text = "Hide Null values in Source series"
        AddHandler checkBox2.Click, AddressOf Me.checkBox2_Click
        ' 
        ' fastLine1
        ' 
        ' 
        ' fastLine1.LinePen
        ' 
        Me.fastLine1.LinePen.Color = System.Drawing.Color.FromArgb(CType(255, Byte), CType(0, Byte), CType(0, Byte))
        ' 
        ' fastLine1.Marks
        ' 
        ' 
        ' fastLine1.Marks.Arrow
        ' 
        Me.fastLine1.Marks.Arrow.Color = System.Drawing.Color.Black
        ' 
        ' fastLine1.Marks.Brush
        ' 
        ' 
        ' fastLine1.Marks.Gradient
        ' 
        Me.fastLine1.Marks.Brush.Gradient.StartColor = System.Drawing.Color.Silver
        ' 
        ' fastLine1.Marks.Font
        ' 
        Me.fastLine1.Marks.Font.Size = 10
        ' 
        ' fastLine1.Marks.Gradient
        ' 
        Me.fastLine1.Marks.Gradient.StartColor = System.Drawing.Color.Silver
        ' 
        ' fastLine1.Marks.Symbol
        ' 
        ' 
        ' fastLine1.Marks.Symbol.Shadow
        ' 
        Me.fastLine1.Marks.Symbol.Shadow.Height = 1
        Me.fastLine1.Marks.Symbol.Shadow.Visible = True
        Me.fastLine1.Marks.Symbol.Shadow.Width = 1
        Me.fastLine1.Marks.Transparent = True
        Me.fastLine1.Title = "Source"
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
        ' line1
        ' 
        ' 
        ' line1.Brush
        ' 
        Me.line1.Brush.Color = System.Drawing.Color.FromArgb(CType(49, Byte), CType(83, Byte), CType(196, Byte))
        Me.line1.DataSource = Me.fastLine1
        Me.line1.Function = Me.modeFunction1
        ' 
        ' line1.Marks
        ' 
        ' 
        ' line1.Marks.Arrow
        ' 
        Me.line1.Marks.Arrow.Color = System.Drawing.Color.Black
        ' 
        ' line1.Marks.Brush
        ' 
        ' 
        ' line1.Marks.Gradient
        ' 
        Me.line1.Marks.Brush.Gradient.StartColor = System.Drawing.Color.Silver
        ' 
        ' line1.Marks.Font
        ' 
        Me.line1.Marks.Font.Size = 10
        ' 
        ' line1.Marks.Gradient
        ' 
        Me.line1.Marks.Gradient.StartColor = System.Drawing.Color.Silver
        ' 
        ' line1.Marks.Symbol
        ' 
        ' 
        ' line1.Marks.Symbol.Shadow
        ' 
        Me.line1.Marks.Symbol.Shadow.Height = 1
        Me.line1.Marks.Symbol.Shadow.Visible = True
        Me.line1.Marks.Symbol.Shadow.Width = 1
        Me.line1.Marks.Transparent = True
        ' 
        ' line1.Pointer
        ' 
        ' 
        ' line1.Pointer.Brush
        ' 
        Me.line1.Pointer.Brush.Color = System.Drawing.Color.FromArgb(CType(254, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
        Me.line1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.line1.Title = "Mode"
        Me.line1.VertAxis = Steema.TeeChart.Styles.VerticalAxis.Right
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
        ' Mode
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(440, 317)
        Me.Name = "Mode"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub 'New



#End Region

    Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    End Sub 'checkBox1_CheckedChanged



    Private Sub checkBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        modeFunction1.IncludeNulls = checkBox1.Checked
    End Sub 'checkBox1_Click


    Private Sub checkBox2_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        fastLine1.TreatNulls = IIf(checkBox2.Checked, Steema.TeeChart.Styles.TreatNullsStyle.Ignore, Steema.TeeChart.Styles.TreatNullsStyle.DoNotPaint)
    End Sub 'checkBox2_Click
End Class 'Function_Mode