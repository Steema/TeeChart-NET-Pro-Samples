
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Public Class Axis_MinorGrid
    Inherits Steema.TeeChart.Samples.BaseForm
    Private areaSeries1 As Steema.TeeChart.Styles.Area
    Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
    Private buttonPen1 As Steema.TeeChart.ButtonPen
    Private components As System.ComponentModel.IContainer = Nothing
     
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        
        areaSeries1.FillSampleValues(5)
        
        tChart1.Axes.DrawBehind = False
        tChart1.Axes.Bottom.MinorGrid.Color = Color.White
        tChart1.Axes.Bottom.MinorGrid.Style = System.Drawing.Drawing2D.DashStyle.DashDotDot
        tChart1.Axes.Bottom.MinorGrid.Visible = True
        tChart1.Axes.Bottom.MinorTickCount = 3
        
        buttonPen1.Pen = tChart1.Axes.Bottom.MinorGrid
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
        Me.areaSeries1 = New Steema.TeeChart.Styles.Area
        Me.checkBox1 = New System.Windows.Forms.CheckBox
        Me.buttonPen1 = New Steema.TeeChart.ButtonPen
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.BackColor = System.Drawing.Color.AliceBlue
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(630, 63)
        Me.textBox1.Text = ("All Axes can display a Minor Grid, that is, grid lines inside grid lines. The MinorTickCount property controls the number of minor grid lines." & vbCrLf & vbCrLf & "this.tChart1.Axes.Bottom.MinorGrid.Visible = True" & vbCrLf & "this.tChart1.Axes.Bottom.MinorTickCount = 3")
        ' 
        ' panel1
        ' 
        Me.panel1.BackColor = System.Drawing.SystemColors.Control
        Me.panel1.Controls.Add(Me.buttonPen1)
        Me.panel1.Controls.Add(Me.checkBox1)
        Me.panel1.Location = New System.Drawing.Point(0, 63)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(630, 33)
        ' 
        ' tChart1
        ' 
        ' 
        ' tChart1.Aspect
        ' 
        Me.tChart1.Aspect.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality
        Me.tChart1.Aspect.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
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
        ' tChart1.Axes.Left
        ' 
        ' 
        ' tChart1.Axes.Left.AxisPen
        ' 
        Me.tChart1.Axes.Left.AxisPen.Width = 1
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
        Me.tChart1.Header.Font.Shadow.Brush.Color = System.Drawing.Color.FromArgb(CType(254, Byte), CType(192, Byte), CType(192, Byte), CType(192, Byte))
        Me.tChart1.Header.Font.Shadow.Visible = True
        Me.tChart1.Header.Lines = New String() {"Minor Grid"}
        ' 
        ' tChart1.Legend
        ' 
        Me.tChart1.Legend.Alignment = Steema.TeeChart.LegendAlignments.Bottom
        Me.tChart1.Legend.Transparent = True
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
        Me.tChart1.Series.Add(Me.areaSeries1)
        Me.tChart1.Size = New System.Drawing.Size(630, 297)
        ' 
        ' tChart1.Walls
        ' 
        ' 
        ' tChart1.Walls.Back
        ' 
        ' 
        ' tChart1.Walls.Back.Brush
        ' 
        Me.tChart1.Walls.Back.Brush.Color = System.Drawing.Color.FromArgb(CType(76, Byte), CType(192, Byte), CType(192, Byte), CType(192, Byte))
        ' 
        ' tChart1.Walls.Back.Gradient
        ' 
        Me.tChart1.Walls.Back.Brush.Gradient.Transparency = 70
        ' 
        ' tChart1.Walls.Back.Gradient
        ' 
        Me.tChart1.Walls.Back.Gradient.Transparency = 70
        ' 
        ' tChart1.Walls.Back.Pen
        ' 
        Me.tChart1.Walls.Back.Pen.Visible = False
        Me.tChart1.Walls.Back.Transparent = False
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
        ' 
        ' areaSeries1
        ' 
        ' 
        ' areaSeries1.AreaBrush
        ' 
        Me.areaSeries1.AreaBrush.Color = System.Drawing.Color.FromArgb(CType(254, Byte), CType(255, Byte), CType(0, Byte), CType(0, Byte))
        ' 
        ' areaSeries1.AreaLines
        ' 
        Me.areaSeries1.AreaLines.Visible = False
        ' 
        ' areaSeries1.Brush
        ' 
        Me.areaSeries1.Brush.Color = System.Drawing.Color.Red
        Me.areaSeries1.ColorEach = True
        ' 
        ' areaSeries1.LinePen
        ' 
        Me.areaSeries1.LinePen.Visible = False
        ' 
        ' areaSeries1.Pointer
        '
        Me.areaSeries1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.areaSeries1.Title = "areaSeries1"
        Me.areaSeries1.UseOrigin = True
        ' 
        ' areaSeries1.XValues
        ' 
        Me.areaSeries1.XValues.DataMember = "X"
        Me.areaSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' areaSeries1.YValues
        ' 
        Me.areaSeries1.YValues.DataMember = "Y"
        ' 
        ' checkBox1
        ' 
        Me.checkBox1.Checked = True
        Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox1.Location = New System.Drawing.Point(8, 8)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(87, 21)
        Me.checkBox1.TabIndex = 0
        Me.checkBox1.Text = "&Minor grid"
        AddHandler checkBox1.CheckedChanged, AddressOf Me.checkBox1_CheckedChanged
        ' 
        ' buttonPen1
        ' 
        Me.buttonPen1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonPen1.Location = New System.Drawing.Point(120, 5)
        Me.buttonPen1.Name = "buttonPen1"
        Me.buttonPen1.TabIndex = 1
        Me.buttonPen1.Text = "&Border..."
        ' 
        ' Axis_MinorGrid
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(630, 393)
        Me.Name = "Axis_MinorGrid"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub 'InitializeComponent 
#End Region


    Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox1.CheckedChanged
        tChart1.Axes.Bottom.MinorGrid.Visible = checkBox1.Checked
    End Sub 'checkBox1_CheckedChanged
End Class 'Axis_MinorGrid
