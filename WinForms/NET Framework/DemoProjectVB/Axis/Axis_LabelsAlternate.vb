
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms


Public Class AlternateAxisLabels
    Inherits Steema.TeeChart.Samples.BaseForm
    Private line1 As Steema.TeeChart.Styles.Line
    Private cbAlternate As System.Windows.Forms.CheckBox
    Private groupBox1 As System.Windows.Forms.GroupBox
    Private rbLeft As System.Windows.Forms.RadioButton
    Private rbTop As System.Windows.Forms.RadioButton
    Private rbRight As System.Windows.Forms.RadioButton
    Private rbBottom As System.Windows.Forms.RadioButton
    Private components As System.ComponentModel.IContainer = Nothing
    Private itemIndex As String
    
    Public Sub New() ' This call is required by the Windows Form Designer.
        InitializeComponent()

        line1.FillSampleValues()
        line1.Pointer.Brush.Gradient.Visible = True
        line1.Pointer.Brush.Gradient.EndColor = Color.Red

        Dim i As Integer
        For i = 0 To tChart1.Axes.Count - 1 Step +1
            tChart1.Axes(i).Labels.Alternate = cbAlternate.Checked
        Next i
        itemIndex = "rbBottom"
        HighLight()

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
        Me.line1 = New Steema.TeeChart.Styles.Line
        Me.cbAlternate = New System.Windows.Forms.CheckBox
        Me.groupBox1 = New System.Windows.Forms.GroupBox
        Me.rbBottom = New System.Windows.Forms.RadioButton
        Me.rbRight = New System.Windows.Forms.RadioButton
        Me.rbTop = New System.Windows.Forms.RadioButton
        Me.rbLeft = New System.Windows.Forms.RadioButton
        Me.panel1.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.BackColor = System.Drawing.Color.AliceBlue
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Text = ("Axis labels can be displayed in \""alternate\"" mode. " & vbCrLf & "This shows two rows or two columns of axis labels." & vbCrLf & vbCrLf & "  tChart1.Axes.Left.Labels.Alternate =True")
        ' 
        ' panel1
        ' 
        Me.panel1.BackColor = System.Drawing.SystemColors.Control
        Me.panel1.Controls.Add(Me.groupBox1)
        Me.panel1.Controls.Add(Me.cbAlternate)
        Me.panel1.Name = "panel1"
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
        Me.tChart1.Axes.Bottom.Grid.Color = System.Drawing.Color.FromArgb(CType(196, Byte), CType(196, Byte), CType(196, Byte))
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
        Me.tChart1.Axes.Depth.Grid.Color = System.Drawing.Color.FromArgb(CType(196, Byte), CType(196, Byte), CType(196, Byte))
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
        Me.tChart1.Axes.Left.Grid.Color = System.Drawing.Color.FromArgb(CType(196, Byte), CType(196, Byte), CType(196, Byte))
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
        Me.tChart1.Axes.Right.Grid.Color = System.Drawing.Color.FromArgb(CType(196, Byte), CType(196, Byte), CType(196, Byte))
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
        Me.tChart1.Axes.Top.Grid.Color = System.Drawing.Color.FromArgb(CType(196, Byte), CType(196, Byte), CType(196, Byte))
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
        Me.tChart1.Header.Lines = New String() {"tChart1"}
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
        Me.tChart1.Legend.Shadow.Height = -1
        ' 
        ' tChart1.Legend.Symbol
        ' 
        ' 
        ' tChart1.Legend.Symbol.Pen
        ' 
        Me.tChart1.Legend.Symbol.Pen.Visible = False
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
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(196, Byte), CType(196, Byte), CType(196, Byte))
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
        Me.tChart1.Series.Add(Me.line1)
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
        Me.tChart1.Walls.Back.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(223, Byte), CType(122, Byte), CType(41, Byte))
        Me.tChart1.Walls.Back.Brush.Gradient.MiddleColor = System.Drawing.Color.Empty
        Me.tChart1.Walls.Back.Brush.Gradient.StartColor = System.Drawing.Color.White
        ' 
        ' tChart1.Walls.Back.Gradient
        ' 
        Me.tChart1.Walls.Back.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(223, Byte), CType(122, Byte), CType(41, Byte))
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
        Me.tChart1.Walls.Bottom.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(252, Byte), CType(254, Byte), CType(253, Byte))
        Me.tChart1.Walls.Bottom.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(47, Byte), CType(133, Byte), CType(253, Byte))
        ' 
        ' tChart1.Walls.Bottom.Gradient
        ' 
        Me.tChart1.Walls.Bottom.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(252, Byte), CType(254, Byte), CType(253, Byte))
        Me.tChart1.Walls.Bottom.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(47, Byte), CType(133, Byte), CType(253, Byte))
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
        Me.tChart1.Walls.Left.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(36, Byte), CType(209, Byte), CType(252, Byte))
        Me.tChart1.Walls.Left.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(13, Byte), CType(188, Byte), CType(124, Byte))
        ' 
        ' tChart1.Walls.Left.Gradient
        ' 
        Me.tChart1.Walls.Left.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(36, Byte), CType(209, Byte), CType(252, Byte))
        Me.tChart1.Walls.Left.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(13, Byte), CType(188, Byte), CType(124, Byte))
        ' 
        ' tChart1.Walls.Right
        ' 
        ' 
        ' tChart1.Walls.Right.Brush
        ' 
        Me.tChart1.Walls.Right.Brush.Color = System.Drawing.Color.White
        ' 
        ' line1
        ' 
        ' 
        ' line1.Brush
        ' 
        Me.line1.Brush.Color = System.Drawing.Color.FromArgb(CType(0, Byte), CType(165, Byte), CType(255, Byte))
        Me.line1.HorizAxis = Steema.TeeChart.Styles.HorizontalAxis.Both
        ' 
        ' line1.Marks
        ' 
        ' 
        ' line1.Marks.Brush
        ' 
        ' 
        ' line1.Marks.Gradient
        ' 
        Me.line1.Marks.Brush.Gradient.StartColor = System.Drawing.Color.Silver
        Me.line1.Marks.Brush.Gradient.Visible = True
        ' 
        ' line1.Marks.Font
        ' 
        Me.line1.Marks.Font.Name = "Lucida Console"
        ' 
        ' line1.Marks.Gradient
        ' 
        Me.line1.Marks.Gradient.StartColor = System.Drawing.Color.Silver
        Me.line1.Marks.Gradient.Visible = True
        ' 
        ' line1.Pointer
        ' 
        ' 
        ' line1.Pointer.Brush
        ' 
        Me.line1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.line1.Pointer.Visible = True
        Me.line1.Title = "line1"
        Me.line1.VertAxis = Steema.TeeChart.Styles.VerticalAxis.Both
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
        ' cbAlternate
        ' 
        Me.cbAlternate.Checked = True
        Me.cbAlternate.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbAlternate.Location = New System.Drawing.Point(304, 8)
        Me.cbAlternate.Name = "cbAlternate"
        Me.cbAlternate.Size = New System.Drawing.Size(112, 24)
        Me.cbAlternate.TabIndex = 0
        Me.cbAlternate.Text = "Alternate Labels"
        AddHandler cbAlternate.CheckedChanged, AddressOf Me.cbAlternate_CheckedChanged
        ' 
        ' groupBox1
        ' 
        Me.groupBox1.Controls.Add(Me.rbBottom)
        Me.groupBox1.Controls.Add(Me.rbRight)
        Me.groupBox1.Controls.Add(Me.rbTop)
        Me.groupBox1.Controls.Add(Me.rbLeft)
        Me.groupBox1.Location = New System.Drawing.Point(8, 0)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(259, 40)
        Me.groupBox1.TabIndex = 1
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Axis"
        ' 
        ' rbBottom
        ' 
        Me.rbBottom.Checked = True
        Me.rbBottom.Location = New System.Drawing.Point(190, 18)
        Me.rbBottom.Name = "rbBottom"
        Me.rbBottom.Size = New System.Drawing.Size(64, 14)
        Me.rbBottom.TabIndex = 3
        Me.rbBottom.TabStop = True
        Me.rbBottom.Text = "Bottom"
        AddHandler rbBottom.CheckedChanged, AddressOf Me.RBAxis_CheckedChanged
        ' 
        ' rbRight
        ' 
        Me.rbRight.Location = New System.Drawing.Point(126, 17)
        Me.rbRight.Name = "rbRight"
        Me.rbRight.Size = New System.Drawing.Size(51, 16)
        Me.rbRight.TabIndex = 2
        Me.rbRight.Text = "Right"
        AddHandler rbRight.CheckedChanged, AddressOf Me.RBAxis_CheckedChanged
        ' 
        ' rbTop
        ' 
        Me.rbTop.Location = New System.Drawing.Point(67, 16)
        Me.rbTop.Name = "rbTop"
        Me.rbTop.Size = New System.Drawing.Size(42, 17)
        Me.rbTop.TabIndex = 1
        Me.rbTop.Text = "Top"
        AddHandler rbTop.CheckedChanged, AddressOf Me.RBAxis_CheckedChanged
        ' 
        ' rbLeft
        ' 
        Me.rbLeft.Location = New System.Drawing.Point(10, 17)
        Me.rbLeft.Name = "rbLeft"
        Me.rbLeft.Size = New System.Drawing.Size(42, 14)
        Me.rbLeft.TabIndex = 0
        Me.rbLeft.Text = "Left"
        AddHandler rbLeft.CheckedChanged, AddressOf Me.RBAxis_CheckedChanged
        ' 
        ' AlternateAxisLabels
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(440, 317)
        Me.Name = "AlternateAxisLabels"
        Me.panel1.ResumeLayout(False)
        Me.groupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub 'New
#End Region

    Private Sub cbAlternate_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        TheAxis().Labels.Alternate = cbAlternate.Checked
        HighLight()
    End Sub 'cbAlternate_CheckedChanged


    Private Sub HighLightAxis(ByVal Axis As Steema.TeeChart.Axis)
        Axis.Labels.Font.Bold = (TheAxis() Is Axis)
    End Sub 'HighLightAxis


    Private Sub HighLight()
        HighLightAxis(tChart1.Axes.Left)
        HighLightAxis(tChart1.Axes.Right)
        HighLightAxis(tChart1.Axes.Top)
        HighLightAxis(tChart1.Axes.Bottom)
    End Sub 'HighLight


    Private Function TheAxis() As Steema.TeeChart.Axis
        Dim result As Steema.TeeChart.Axis = Nothing
        Select Case itemIndex
            Case "rbLeft"
                result = tChart1.Axes.Left
            Case "rbRight"
                result = tChart1.Axes.Right
            Case "rbTop"
                result = tChart1.Axes.Top
            Case "rbBottom"
                result = tChart1.Axes.Bottom
        End Select
        Return result
    End Function 'TheAxis


    Private Sub RBAxis_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        itemIndex = CType(sender, RadioButton).Name
        cbAlternate.Checked = TheAxis().Labels.Alternate
        HighLight()
    End Sub 'RBAxis_CheckedChanged
End Class 'AlternateAxisLabels