
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms


Public Class Series_TextSource
    Inherits Steema.TeeChart.Samples.BaseNoChart
    Protected textBox2 As System.Windows.Forms.TextBox
    Protected button1 As System.Windows.Forms.Button
    Protected textSource1 As Steema.TeeChart.Data.TextSource
    Protected tChart1 As Steema.TeeChart.TChart
    Protected bar1 As Steema.TeeChart.Styles.Bar
    Protected button2 As System.Windows.Forms.Button
    Protected textBox3 As System.Windows.Forms.TextBox
    Private components As System.ComponentModel.IContainer = Nothing
    
    Public Sub New() ' This call is required by the Windows Form Designer.
        InitializeComponent()

        Dim count As Integer = 0
        For Each v As Steema.TeeChart.Styles.ValueList In bar1.ValuesLists
            textSource1.Fields.Add(count, v.Name)
            count = count + 1
        Next
        textSource1.Fields.Add(count, "text")
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
        Me.textBox2 = New System.Windows.Forms.TextBox
        Me.button1 = New System.Windows.Forms.Button
        Me.textSource1 = New Steema.TeeChart.Data.TextSource
        Me.bar1 = New Steema.TeeChart.Styles.Bar
        Me.tChart1 = New Steema.TeeChart.TChart
        Me.button2 = New System.Windows.Forms.Button
        Me.textBox3 = New System.Windows.Forms.TextBox
        Me.panel1.SuspendLayout()
        Me.panel2.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Text = ("The Series TextSource component is used to fill a Series with points" & vbCrLf & "coming from" + " text.  Text can be loaded from Strings, File or Web URL address.")
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.textBox3)
        Me.panel1.Controls.Add(Me.button2)
        Me.panel1.Controls.Add(Me.button1)
        Me.panel1.Name = "panel1"
        ' 
        ' panel2
        ' 
        Me.panel2.Controls.Add(Me.tChart1)
        Me.panel2.Controls.Add(Me.textBox2)
        Me.panel2.Name = "panel2"
        ' 
        ' textBox2
        ' 
        Me.textBox2.Dock = System.Windows.Forms.DockStyle.Left
        Me.textBox2.Location = New System.Drawing.Point(0, 0)
        Me.textBox2.Multiline = True
        Me.textBox2.Name = "textBox2"
        Me.textBox2.Size = New System.Drawing.Size(112, 154)
        Me.textBox2.TabIndex = 0
        Me.textBox2.Text = ("This memo contains series points" & vbCrLf & "( format is X,Y,Text )" & vbCrLf & "1,123,A" & vbCrLf & "2,456,B" & vbCrLf & "3,321" + ",C" & vbCrLf & "4,222,D" & vbCrLf & "5,90,E" & vbCrLf & "6,111,F" & vbCrLf & "7,-10,G")
        ' 
        ' button1
        ' 
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.Location = New System.Drawing.Point(16, 11)
        Me.button1.Name = "button1"
        Me.button1.TabIndex = 0
        Me.button1.Text = "Fill Series !"
        AddHandler button1.Click, AddressOf Me.button1_Click
        ' 
        ' textSource1
        ' 
        Me.textSource1.DecimalSeparator = ","c
        Me.textSource1.HeaderLines = 2
        Me.textSource1.Series = Me.bar1
        ' 
        ' bar1
        ' 
        ' 
        ' bar1.Brush
        ' 
        Me.bar1.Brush.Color = System.Drawing.Color.FromArgb((CType((0), System.Byte)), (CType((165), System.Byte)), (CType((255), System.Byte)))
        ' 
        ' bar1.Marks
        ' 
        ' 
        ' bar1.Marks.Brush
        ' 
        ' 
        ' bar1.Marks.Gradient
        ' 
        Me.bar1.Marks.Brush.Gradient.StartColor = System.Drawing.Color.Silver
        Me.bar1.Marks.Brush.Gradient.Visible = True
        ' 
        ' bar1.Marks.Font
        ' 
        Me.bar1.Marks.Font.Name = "Lucida Console"
        ' 
        ' bar1.Marks.Gradient
        ' 
        Me.bar1.Marks.Gradient.StartColor = System.Drawing.Color.Silver
        Me.bar1.Marks.Gradient.Visible = True
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
        ' tChart1
        ' 
        ' 
        ' tChart1.Aspect
        ' 
        Me.tChart1.Aspect.ColorPaletteIndex = -1
        Me.tChart1.Aspect.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality
        Me.tChart1.Aspect.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        Me.tChart1.Aspect.ThemeIndex = 4
        ' 
        ' tChart1.Axes
        ' 
        ' 
        ' tChart1.Axes.Bottom
        ' 
        ' 
        ' tChart1.Axes.Bottom.Grid
        ' 
        Me.tChart1.Axes.Bottom.Grid.Color = System.Drawing.Color.FromArgb((CType((196), System.Byte)), (CType((196), System.Byte)), (CType((196), System.Byte)))
        Me.tChart1.Axes.Bottom.Grid.Style = System.Drawing.Drawing2D.DashStyle.Solid
        Me.tChart1.Axes.Bottom.Grid.Visible = False
        ' 
        ' tChart1.Axes.Bottom.Labels
        ' 
        ' 
        ' tChart1.Axes.Bottom.Labels.Font
        ' 
        Me.tChart1.Axes.Bottom.Labels.Font.Name = "Lucida Console"
        Me.tChart1.Axes.Bottom.Labels.Font.Size = 10
        ' 
        ' tChart1.Axes.Bottom.MinorTicks
        ' 
        Me.tChart1.Axes.Bottom.MinorTicks.Color = System.Drawing.Color.Black
        Me.tChart1.Axes.Bottom.MinorTicks.Length = -3
        ' 
        ' tChart1.Axes.Bottom.Ticks
        ' 
        Me.tChart1.Axes.Bottom.Ticks.Color = System.Drawing.Color.Black
        Me.tChart1.Axes.Bottom.Ticks.Length = 0
        ' 
        ' tChart1.Axes.Bottom.TicksInner
        ' 
        Me.tChart1.Axes.Bottom.TicksInner.Color = System.Drawing.Color.Black
        Me.tChart1.Axes.Bottom.TicksInner.Length = 6
        ' 
        ' tChart1.Axes.Depth
        ' 
        ' 
        ' tChart1.Axes.Depth.Grid
        ' 
        Me.tChart1.Axes.Depth.Grid.Color = System.Drawing.Color.FromArgb((CType((196), System.Byte)), (CType((196), System.Byte)), (CType((196), System.Byte)))
        Me.tChart1.Axes.Depth.Grid.Style = System.Drawing.Drawing2D.DashStyle.Solid
        ' 
        ' tChart1.Axes.Depth.Labels
        ' 
        ' 
        ' tChart1.Axes.Depth.Labels.Font
        ' 
        Me.tChart1.Axes.Depth.Labels.Font.Name = "Lucida Console"
        Me.tChart1.Axes.Depth.Labels.Font.Size = 10
        ' 
        ' tChart1.Axes.Depth.MinorTicks
        ' 
        Me.tChart1.Axes.Depth.MinorTicks.Color = System.Drawing.Color.Black
        Me.tChart1.Axes.Depth.MinorTicks.Length = -3
        ' 
        ' tChart1.Axes.Depth.Ticks
        ' 
        Me.tChart1.Axes.Depth.Ticks.Color = System.Drawing.Color.Black
        Me.tChart1.Axes.Depth.Ticks.Length = 0
        ' 
        ' tChart1.Axes.Depth.TicksInner
        ' 
        Me.tChart1.Axes.Depth.TicksInner.Color = System.Drawing.Color.Black
        Me.tChart1.Axes.Depth.TicksInner.Length = 6
        ' 
        ' tChart1.Axes.Left
        ' 
        ' 
        ' tChart1.Axes.Left.Grid
        ' 
        Me.tChart1.Axes.Left.Grid.Color = System.Drawing.Color.FromArgb((CType((196), System.Byte)), (CType((196), System.Byte)), (CType((196), System.Byte)))
        Me.tChart1.Axes.Left.Grid.Style = System.Drawing.Drawing2D.DashStyle.Solid
        ' 
        ' tChart1.Axes.Left.Labels
        ' 
        ' 
        ' tChart1.Axes.Left.Labels.Font
        ' 
        Me.tChart1.Axes.Left.Labels.Font.Name = "Lucida Console"
        Me.tChart1.Axes.Left.Labels.Font.Size = 10
        ' 
        ' tChart1.Axes.Left.MinorTicks
        ' 
        Me.tChart1.Axes.Left.MinorTicks.Color = System.Drawing.Color.Black
        Me.tChart1.Axes.Left.MinorTicks.Length = -3
        ' 
        ' tChart1.Axes.Left.Ticks
        ' 
        Me.tChart1.Axes.Left.Ticks.Color = System.Drawing.Color.Black
        Me.tChart1.Axes.Left.Ticks.Length = 0
        ' 
        ' tChart1.Axes.Left.TicksInner
        ' 
        Me.tChart1.Axes.Left.TicksInner.Color = System.Drawing.Color.Black
        Me.tChart1.Axes.Left.TicksInner.Length = 6
        ' 
        ' tChart1.Axes.Right
        ' 
        ' 
        ' tChart1.Axes.Right.Grid
        ' 
        Me.tChart1.Axes.Right.Grid.Color = System.Drawing.Color.FromArgb((CType((196), System.Byte)), (CType((196), System.Byte)), (CType((196), System.Byte)))
        Me.tChart1.Axes.Right.Grid.Style = System.Drawing.Drawing2D.DashStyle.Solid
        ' 
        ' tChart1.Axes.Right.Labels
        ' 
        ' 
        ' tChart1.Axes.Right.Labels.Font
        ' 
        Me.tChart1.Axes.Right.Labels.Font.Name = "Lucida Console"
        Me.tChart1.Axes.Right.Labels.Font.Size = 10
        ' 
        ' tChart1.Axes.Right.MinorTicks
        ' 
        Me.tChart1.Axes.Right.MinorTicks.Color = System.Drawing.Color.Black
        Me.tChart1.Axes.Right.MinorTicks.Length = -3
        ' 
        ' tChart1.Axes.Right.Ticks
        ' 
        Me.tChart1.Axes.Right.Ticks.Color = System.Drawing.Color.Black
        Me.tChart1.Axes.Right.Ticks.Length = 0
        ' 
        ' tChart1.Axes.Right.TicksInner
        ' 
        Me.tChart1.Axes.Right.TicksInner.Color = System.Drawing.Color.Black
        Me.tChart1.Axes.Right.TicksInner.Length = 6
        ' 
        ' tChart1.Axes.Top
        ' 
        ' 
        ' tChart1.Axes.Top.Grid
        ' 
        Me.tChart1.Axes.Top.Grid.Color = System.Drawing.Color.FromArgb((CType((196), System.Byte)), (CType((196), System.Byte)), (CType((196), System.Byte)))
        Me.tChart1.Axes.Top.Grid.Style = System.Drawing.Drawing2D.DashStyle.Solid
        Me.tChart1.Axes.Top.Grid.Visible = False
        ' 
        ' tChart1.Axes.Top.Labels
        ' 
        ' 
        ' tChart1.Axes.Top.Labels.Font
        ' 
        Me.tChart1.Axes.Top.Labels.Font.Name = "Lucida Console"
        Me.tChart1.Axes.Top.Labels.Font.Size = 10
        ' 
        ' tChart1.Axes.Top.MinorTicks
        ' 
        Me.tChart1.Axes.Top.MinorTicks.Color = System.Drawing.Color.Black
        Me.tChart1.Axes.Top.MinorTicks.Length = -3
        ' 
        ' tChart1.Axes.Top.Ticks
        ' 
        Me.tChart1.Axes.Top.Ticks.Color = System.Drawing.Color.Black
        Me.tChart1.Axes.Top.Ticks.Length = 0
        ' 
        ' tChart1.Axes.Top.TicksInner
        ' 
        Me.tChart1.Axes.Top.TicksInner.Color = System.Drawing.Color.Black
        Me.tChart1.Axes.Top.TicksInner.Length = 6
        Me.tChart1.Dock = System.Windows.Forms.DockStyle.Fill
        ' 
        ' tChart1.Header
        ' 
        ' 
        ' tChart1.Header.Font
        ' 
        Me.tChart1.Header.Font.Bold = True
        ' 
        ' tChart1.Header.Font.Brush
        ' 
        Me.tChart1.Header.Font.Brush.Color = System.Drawing.Color.Black
        Me.tChart1.Header.Font.Name = "Lucida Console"
        Me.tChart1.Header.Font.Size = 10
        Me.tChart1.Header.Lines = New String() {"TeeChart"}

        ' 
        ' tChart1.Legend
        ' 
        ' 
        ' tChart1.Legend.Brush
        ' 
        ' 
        ' tChart1.Legend.Gradient
        ' 
        Me.tChart1.Legend.Brush.Gradient.EndColor = System.Drawing.Color.Yellow
        Me.tChart1.Legend.Brush.Gradient.MiddleColor = System.Drawing.Color.Empty
        Me.tChart1.Legend.Brush.Gradient.StartColor = System.Drawing.Color.White
        ' 
        ' tChart1.Legend.Font
        ' 
        Me.tChart1.Legend.Font.Name = "Lucida Console"
        Me.tChart1.Legend.Font.Size = 9
        ' 
        ' tChart1.Legend.Gradient
        ' 
        Me.tChart1.Legend.Gradient.EndColor = System.Drawing.Color.Yellow
        Me.tChart1.Legend.Gradient.MiddleColor = System.Drawing.Color.Empty
        Me.tChart1.Legend.Gradient.StartColor = System.Drawing.Color.White
        ' 
        ' tChart1.Legend.Shadow
        ' 
        ' 
        ' tChart1.Legend.Shadow.Brush
        ' 
        Me.tChart1.Legend.Shadow.Brush.Color = System.Drawing.Color.DarkGray
        ' 
        ' tChart1.Legend.Symbol
        ' 
        ' 
        ' tChart1.Legend.Symbol.Pen
        ' 
        Me.tChart1.Legend.Symbol.Pen.Visible = False
        Me.tChart1.Legend.Transparent = True
        Me.tChart1.Legend.Visible = False
        Me.tChart1.Location = New System.Drawing.Point(112, 0)
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
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb((CType((196), System.Byte)), (CType((196), System.Byte)), (CType((196), System.Byte)))
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
        ' 
        ' tChart1.Panel.Shadow.Brush
        ' 
        Me.tChart1.Panel.Shadow.Brush.Color = System.Drawing.Color.Black
        Me.tChart1.Panel.Shadow.Height = 0
        Me.tChart1.Panel.Shadow.Visible = True
        Me.tChart1.Panel.Shadow.Width = 0
        Me.tChart1.Series.Add(Me.bar1)
        Me.tChart1.Size = New System.Drawing.Size(314, 154)
        Me.tChart1.TabIndex = 1
        ' 
        ' tChart1.Walls
        ' 
        ' 
        ' tChart1.Walls.Back
        ' 
        ' 
        ' tChart1.Walls.Back.Brush
        ' 
        Me.tChart1.Walls.Back.Brush.Color = System.Drawing.Color.White
        ' 
        ' tChart1.Walls.Back.Gradient
        ' 
        Me.tChart1.Walls.Back.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb((CType((223), System.Byte)), (CType((122), System.Byte)), (CType((41), System.Byte)))
        Me.tChart1.Walls.Back.Brush.Gradient.MiddleColor = System.Drawing.Color.Empty
        Me.tChart1.Walls.Back.Brush.Gradient.StartColor = System.Drawing.Color.White
        ' 
        ' tChart1.Walls.Back.Gradient
        ' 
        Me.tChart1.Walls.Back.Gradient.EndColor = System.Drawing.Color.FromArgb((CType((223), System.Byte)), (CType((122), System.Byte)), (CType((41), System.Byte)))
        Me.tChart1.Walls.Back.Gradient.MiddleColor = System.Drawing.Color.Empty
        Me.tChart1.Walls.Back.Gradient.StartColor = System.Drawing.Color.White
        Me.tChart1.Walls.Back.Transparent = False
        ' 
        ' tChart1.Walls.Bottom
        ' 
        ' 
        ' tChart1.Walls.Bottom.Brush
        ' 
        ' 
        ' tChart1.Walls.Bottom.Gradient
        ' 
        Me.tChart1.Walls.Bottom.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb((CType((252), System.Byte)), (CType((254), System.Byte)), (CType((253), System.Byte)))
        Me.tChart1.Walls.Bottom.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb((CType((47), System.Byte)), (CType((133), System.Byte)), (CType((253), System.Byte)))
        ' 
        ' tChart1.Walls.Bottom.Gradient
        ' 
        Me.tChart1.Walls.Bottom.Gradient.EndColor = System.Drawing.Color.FromArgb((CType((252), System.Byte)), (CType((254), System.Byte)), (CType((253), System.Byte)))
        Me.tChart1.Walls.Bottom.Gradient.StartColor = System.Drawing.Color.FromArgb((CType((47), System.Byte)), (CType((133), System.Byte)), (CType((253), System.Byte)))
        ' 
        ' tChart1.Walls.Bottom.Pen
        ' 
        Me.tChart1.Walls.Bottom.Pen.Visible = False
        Me.tChart1.Walls.Bottom.Size = 5
        ' 
        ' tChart1.Walls.Left
        ' 
        ' 
        ' tChart1.Walls.Left.Brush
        ' 
        Me.tChart1.Walls.Left.Brush.Color = System.Drawing.Color.White
        ' 
        ' tChart1.Walls.Left.Gradient
        ' 
        Me.tChart1.Walls.Left.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb((CType((36), System.Byte)), (CType((209), System.Byte)), (CType((252), System.Byte)))
        Me.tChart1.Walls.Left.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb((CType((13), System.Byte)), (CType((188), System.Byte)), (CType((124), System.Byte)))
        ' 
        ' tChart1.Walls.Left.Gradient
        ' 
        Me.tChart1.Walls.Left.Gradient.EndColor = System.Drawing.Color.FromArgb((CType((36), System.Byte)), (CType((209), System.Byte)), (CType((252), System.Byte)))
        Me.tChart1.Walls.Left.Gradient.StartColor = System.Drawing.Color.FromArgb((CType((13), System.Byte)), (CType((188), System.Byte)), (CType((124), System.Byte)))
        ' 
        ' tChart1.Walls.Left.Pen
        ' 
        Me.tChart1.Walls.Left.Pen.Visible = False
        Me.tChart1.Walls.Left.Size = 5
        ' 
        ' tChart1.Walls.Right
        ' 
        ' 
        ' tChart1.Walls.Right.Brush
        ' 
        Me.tChart1.Walls.Right.Brush.Color = System.Drawing.Color.White
        ' 
        ' button2
        ' 
        Me.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button2.Location = New System.Drawing.Point(105, 12)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(103, 23)
        Me.button2.TabIndex = 1
        Me.button2.Text = "Fill From Internet:"
        AddHandler button2.Click, AddressOf Me.button2_Click
        ' 
        ' textBox3
        ' 
        Me.textBox3.Location = New System.Drawing.Point(224, 16)
        Me.textBox3.Name = "textBox3"
        Me.textBox3.Size = New System.Drawing.Size(176, 20)
        Me.textBox3.TabIndex = 2
        Me.textBox3.Text = "http://www.steema.com/demo.txt"
        ' 
        ' SeriesTextSource
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(426, 258)
        Me.Name = "SeriesTextSource"
        Me.panel1.ResumeLayout(False)
        Me.panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub 'New

#End Region

    Protected Overridable Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        bar1.Clear()
        textSource1.LoadFromStrings(textBox2.Lines)
    End Sub 'button1_Click


    Protected Overridable Sub button2_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        bar1.Clear()
        textSource1.LoadFromURL(textBox3.Text)
    End Sub 'button2_Click
End Class 'Series_TextSource