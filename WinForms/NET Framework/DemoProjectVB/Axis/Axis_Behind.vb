
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Public Class Axis_Behind
    Inherits Samples.BaseForm
    Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
    Private bar1 As Steema.TeeChart.Styles.Bar
    Private components As System.ComponentModel.IContainer = Nothing
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        bar1.FillSampleValues(6)
        ' tChart1.Axes.Left.Grid.Color = Color.White
        'tChart1.Axes.Bottom.Grid.Color = Color.Blue
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
        Me.checkBox1 = New System.Windows.Forms.CheckBox
        Me.bar1 = New Steema.TeeChart.Styles.Bar
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.BackColor = System.Drawing.Color.AliceBlue
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(388, 63)
        Me.textBox1.Text = ("tChart1.Axes.DrawBehind property controls if axes will be displayed in front of S" & ("eries. This is useful to display Grid lines over series." & vbCrLf & vbCrLf & "Example: tChart1.Axe" & "s.DrawBehind = false"))
        ' 
        ' panel1
        ' 
        Me.panel1.BackColor = System.Drawing.SystemColors.Control
        Me.panel1.Controls.Add(Me.checkBox1)
        Me.panel1.Location = New System.Drawing.Point(0, 63)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(388, 27)
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
        ' tChart1.Axes.Bottom.AxisPen
        ' 
        Me.tChart1.Axes.Bottom.AxisPen.Visible = False
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
        Me.tChart1.Axes.Bottom.Ticks.Length = 2
        ' 
        ' tChart1.Axes.Depth
        ' 
        ' 
        ' tChart1.Axes.Depth.Grid
        ' 
        Me.tChart1.Axes.Depth.Grid.Color = System.Drawing.Color.Gray
        ' 
        ' tChart1.Axes.Depth.Ticks
        ' 
        Me.tChart1.Axes.Depth.Ticks.Length = 2
        Me.tChart1.Axes.DrawBehind = False
        ' 
        ' tChart1.Axes.Left
        ' 
        ' 
        ' tChart1.Axes.Left.AxisPen
        ' 
        Me.tChart1.Axes.Left.AxisPen.Visible = False
        ' 
        ' tChart1.Axes.Left.Grid
        ' 
        Me.tChart1.Axes.Left.Grid.Color = System.Drawing.Color.Gray
        ' 
        ' tChart1.Axes.Left.Labels
        ' 
        ' 
        ' tChart1.Axes.Left.Labels.Font
        ' 
        ' 
        ' tChart1.Axes.Left.Labels.Font.Brush
        ' 
        Me.tChart1.Axes.Left.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(CType(254, Byte), CType(128, Byte), CType(128, Byte), CType(128, Byte))
        ' 
        ' tChart1.Axes.Left.MinorTicks
        ' 
        Me.tChart1.Axes.Left.MinorTicks.Visible = False
        ' 
        ' tChart1.Axes.Left.Ticks
        ' 
        Me.tChart1.Axes.Left.Ticks.Length = 2
        ' 
        ' tChart1.Axes.Right
        ' 
        ' 
        ' tChart1.Axes.Right.AxisPen
        ' 
        Me.tChart1.Axes.Right.AxisPen.Visible = False
        ' 
        ' tChart1.Axes.Right.Grid
        ' 
        Me.tChart1.Axes.Right.Grid.Color = System.Drawing.Color.Gray
        ' 
        ' tChart1.Axes.Right.Ticks
        ' 
        Me.tChart1.Axes.Right.Ticks.Length = 2
        ' 
        ' tChart1.Axes.Top
        ' 
        ' 
        ' tChart1.Axes.Top.AxisPen
        ' 
        Me.tChart1.Axes.Top.AxisPen.Visible = False
        ' 
        ' tChart1.Axes.Top.Grid
        ' 
        Me.tChart1.Axes.Top.Grid.Color = System.Drawing.Color.Gray
        ' 
        ' tChart1.Axes.Top.Ticks
        ' 
        Me.tChart1.Axes.Top.Ticks.Length = 2
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
        Me.tChart1.Header.Font.Name = "Verdana"
        ' 
        ' tChart1.Header.Font.Shadow
        ' 
        ' 
        ' tChart1.Header.Font.Shadow.Brush
        ' 
        Me.tChart1.Header.Font.Shadow.Brush.Color = System.Drawing.Color.FromArgb(CType(254, Byte), CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.tChart1.Header.Font.Shadow.Visible = True
        Me.tChart1.Header.Lines = New String() {"Controlling when axes are drawn"}
        ' 
        ' tChart1.Legend
        ' 
        ' 
        ' tChart1.Legend.Shadow
        ' 
        ' 
        ' tChart1.Legend.Shadow.Brush
        ' 
        Me.tChart1.Legend.Shadow.Brush.Color = System.Drawing.Color.FromArgb(CType(254, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
        Me.tChart1.Legend.Transparent = True
        Me.tChart1.Location = New System.Drawing.Point(0, 90)
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Brush
        ' 
        ' 
        ' tChart1.Panel.Gradient
        ' 
        Me.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(254, Byte), CType(255, Byte), CType(255, Byte), CType(255, Byte))
        Me.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(254, Byte), CType(192, Byte), CType(192, Byte), CType(255, Byte))
        Me.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(254, Byte), CType(192, Byte), CType(192, Byte), CType(255, Byte))
        Me.tChart1.Panel.Brush.Gradient.UseMiddle = True
        Me.tChart1.Panel.Brush.Gradient.Visible = True
        ' 
        ' tChart1.Panel.Gradient
        ' 
        Me.tChart1.Panel.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(254, Byte), CType(255, Byte), CType(255, Byte), CType(255, Byte))
        Me.tChart1.Panel.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(254, Byte), CType(192, Byte), CType(192, Byte), CType(255, Byte))
        Me.tChart1.Panel.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(254, Byte), CType(192, Byte), CType(192, Byte), CType(255, Byte))
        Me.tChart1.Panel.Gradient.UseMiddle = True
        Me.tChart1.Panel.Gradient.Visible = True
        ' 
        ' tChart1.Panel.Shadow
        ' 
        Me.tChart1.Panel.Shadow.Height = 0
        Me.tChart1.Panel.Shadow.Width = 0
        Me.tChart1.Series.Add(Me.bar1)
        Me.tChart1.Size = New System.Drawing.Size(388, 157)
        ' 
        ' tChart1.Walls
        ' 
        ' 
        ' tChart1.Walls.Back
        ' 
        ' 
        ' tChart1.Walls.Back.Brush
        ' 
        Me.tChart1.Walls.Back.Brush.Color = System.Drawing.Color.FromArgb(CType(127, Byte), CType(255, Byte), CType(255, Byte), CType(255, Byte))
        ' 
        ' tChart1.Walls.Back.Gradient
        ' 
        Me.tChart1.Walls.Back.Brush.Gradient.Transparency = 50
        ' 
        ' tChart1.Walls.Back.Gradient
        ' 
        Me.tChart1.Walls.Back.Gradient.Transparency = 50
        ' 
        ' tChart1.Walls.Back.Pen
        ' 
        Me.tChart1.Walls.Back.Pen.Color = System.Drawing.Color.FromArgb(CType(254, Byte), CType(169, Byte), CType(169, Byte), CType(169, Byte))
        Me.tChart1.Walls.Back.Transparent = False
        ' 
        ' tChart1.Walls.Right
        ' 
        ' 
        ' tChart1.Walls.Right.Brush
        ' 
        Me.tChart1.Walls.Right.Brush.Color = System.Drawing.Color.Silver
        ' 
        ' checkBox1
        ' 
        Me.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox1.Location = New System.Drawing.Point(13, 7)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(123, 18)
        Me.checkBox1.TabIndex = 0
        Me.checkBox1.Text = "Axes &Behind"
        AddHandler checkBox1.CheckedChanged, AddressOf Me.checkBox1_CheckedChanged
        ' 
        ' bar1
        ' 
        ' 
        ' bar1.Brush
        ' 
        Me.bar1.Brush.Color = System.Drawing.Color.FromArgb(CType(102, Byte), CType(153, Byte), CType(255, Byte))
        ' 
        ' bar1.Marks
        ' 
        Me.bar1.Marks.Visible = False
        ' 
        ' bar1.Pen
        ' 
        Me.bar1.Pen.Color = System.Drawing.Color.FromArgb(CType(61, Byte), CType(92, Byte), CType(153, Byte))
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
        ' Axis_Behind
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(388, 247)
        Me.Name = "Axis_Behind"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub 'InitializeComponent 
#End Region


    Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox1.CheckedChanged
        tChart1.Axes.DrawBehind = checkBox1.Checked
    End Sub 'checkBox1_CheckedChanged
End Class 'Axis_Behind
