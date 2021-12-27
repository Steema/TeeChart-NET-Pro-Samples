
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing

Imports System.Windows.Forms
Imports Steema.TeeChart.Tools


Public Class Tool_AnnotationAllowEdit
    Inherits Samples.BaseForm

    '/ <summary>
    '/ Required designer variable.
    '/ </summary>
    Private components As System.ComponentModel.IContainer = Nothing


    Public Sub New() ' me call is required by the Windows Form Designer.
        InitializeComponent()
        InitializeChart()
    End Sub

    Private anno1 As Annotation
    Private rect1 As RectangleTool
    Private anno2 As Annotation
    Private WithEvents cbTopLeft As CheckBox
    Private WithEvents cbBottomRight As CheckBox
    Private WithEvents cbTopRight As CheckBox
    Private WithEvents cbBottomLeft As CheckBox
    Private rect2 As RectangleTool

    Private Sub InitializeChart()
        tChart1.Aspect.View3D = False
        anno1 = New Annotation()
        tChart1.Tools.Add(anno1)
        rect1 = New RectangleTool()
        tChart1.Tools.Add(rect1)
        anno2 = New Annotation()
        tChart1.Tools.Add(anno2)
        rect2 = New RectangleTool
        tChart1.Tools.Add(rect2)

        rect1.Position = AnnotationPositions.LeftBottom
        anno2.Position = AnnotationPositions.RightBottom
        rect2.Position = AnnotationPositions.RightTop

        anno1.Text = "Top Left"
        rect1.Text = "Bottom Left"
        anno2.Text = "Bottom Right"
        rect2.Text = "Top Right"

        rect1.AutoSize = True
        rect2.AutoSize = True
        anno1.AllowEdit = True
        rect1.AllowEdit = True
        anno2.AllowEdit = True
        rect2.AllowEdit = True

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
    '/ the contents of me method with the code editor.
    '/ </summary>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Tool_AnnotationAllowEdit))
        Me.cbTopLeft = New System.Windows.Forms.CheckBox
        Me.cbBottomLeft = New System.Windows.Forms.CheckBox
        Me.cbTopRight = New System.Windows.Forms.CheckBox
        Me.cbBottomRight = New System.Windows.Forms.CheckBox
        Me.panel1.SuspendLayout()
        Me.chartContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'textBox1
        '
        Me.textBox1.Text = resources.GetString("textBox1.Text")
        '
        'panel1
        '
        Me.panel1.Controls.Add(Me.cbBottomRight)
        Me.panel1.Controls.Add(Me.cbTopRight)
        Me.panel1.Controls.Add(Me.cbBottomLeft)
        Me.panel1.Controls.Add(Me.cbTopLeft)
        '
        'tChart1
        '
        '
        '
        '
        Me.tChart1.Aspect.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighSpeed
        Me.tChart1.Aspect.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        '
        '
        '
        '
        '
        '
        '
        '
        '
        Me.tChart1.Axes.Bottom.AxisPen.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        '
        '
        Me.tChart1.Axes.Bottom.Grid.Color = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tChart1.Axes.Bottom.Grid.Style = System.Drawing.Drawing2D.DashStyle.Dot
        '
        '
        '
        '
        '
        '
        Me.tChart1.Axes.Bottom.Labels.Font.Name = "Arial"
        '
        '
        '
        Me.tChart1.Axes.Bottom.Ticks.Length = 2
        '
        '
        '
        Me.tChart1.Axes.Bottom.TicksInner.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        '
        '
        '
        '
        '
        Me.tChart1.Axes.Bottom.Title.Font.Name = "Arial"
        '
        '
        '
        '
        '
        '
        Me.tChart1.Axes.Depth.AxisPen.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        '
        '
        Me.tChart1.Axes.Depth.Grid.Color = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tChart1.Axes.Depth.Grid.Style = System.Drawing.Drawing2D.DashStyle.Dot
        '
        '
        '
        '
        '
        '
        Me.tChart1.Axes.Depth.Labels.Font.Name = "Arial"
        '
        '
        '
        Me.tChart1.Axes.Depth.Ticks.Length = 2
        '
        '
        '
        Me.tChart1.Axes.Depth.TicksInner.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        '
        '
        '
        '
        '
        Me.tChart1.Axes.Depth.Title.Font.Name = "Arial"
        '
        '
        '
        '
        '
        '
        Me.tChart1.Axes.DepthTop.AxisPen.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        '
        '
        Me.tChart1.Axes.DepthTop.Grid.Color = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tChart1.Axes.DepthTop.Grid.Style = System.Drawing.Drawing2D.DashStyle.Dot
        '
        '
        '
        '
        '
        '
        Me.tChart1.Axes.DepthTop.Labels.Font.Name = "Arial"
        '
        '
        '
        Me.tChart1.Axes.DepthTop.Ticks.Length = 2
        '
        '
        '
        Me.tChart1.Axes.DepthTop.TicksInner.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        '
        '
        '
        '
        '
        Me.tChart1.Axes.DepthTop.Title.Font.Name = "Arial"
        '
        '
        '
        '
        '
        '
        Me.tChart1.Axes.Left.AxisPen.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        '
        '
        Me.tChart1.Axes.Left.Grid.Color = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tChart1.Axes.Left.Grid.Style = System.Drawing.Drawing2D.DashStyle.Dot
        '
        '
        '
        '
        '
        '
        Me.tChart1.Axes.Left.Labels.Font.Name = "Arial"
        '
        '
        '
        Me.tChart1.Axes.Left.Ticks.Length = 2
        '
        '
        '
        Me.tChart1.Axes.Left.TicksInner.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        '
        '
        '
        '
        '
        Me.tChart1.Axes.Left.Title.Font.Name = "Arial"
        '
        '
        '
        '
        '
        '
        Me.tChart1.Axes.Right.AxisPen.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        '
        '
        Me.tChart1.Axes.Right.Grid.Color = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tChart1.Axes.Right.Grid.Style = System.Drawing.Drawing2D.DashStyle.Dot
        '
        '
        '
        '
        '
        '
        Me.tChart1.Axes.Right.Labels.Font.Name = "Arial"
        '
        '
        '
        Me.tChart1.Axes.Right.Ticks.Length = 2
        '
        '
        '
        Me.tChart1.Axes.Right.TicksInner.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        '
        '
        '
        '
        '
        Me.tChart1.Axes.Right.Title.Font.Name = "Arial"
        '
        '
        '
        '
        '
        '
        Me.tChart1.Axes.Top.AxisPen.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        '
        '
        Me.tChart1.Axes.Top.Grid.Color = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tChart1.Axes.Top.Grid.Style = System.Drawing.Drawing2D.DashStyle.Dot
        '
        '
        '
        '
        '
        '
        Me.tChart1.Axes.Top.Labels.Font.Name = "Arial"
        '
        '
        '
        Me.tChart1.Axes.Top.Ticks.Length = 2
        '
        '
        '
        Me.tChart1.Axes.Top.TicksInner.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        '
        '
        '
        '
        '
        Me.tChart1.Axes.Top.Title.Font.Name = "Arial"
        '
        '
        '
        '
        '
        '
        '
        '
        '
        Me.tChart1.Header.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tChart1.Header.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tChart1.Header.Brush.Gradient.SigmaFocus = 0.0!
        Me.tChart1.Header.Brush.Gradient.SigmaScale = 0.0!
        Me.tChart1.Header.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tChart1.Header.Brush.Gradient.UseMiddle = True
        '
        '
        '
        '
        '
        '
        Me.tChart1.Header.Font.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tChart1.Header.Font.Name = "Arial"
        Me.tChart1.Header.Lines = New String() {"Annotation Allow Edit"}
        '
        '
        '
        Me.tChart1.Header.Pen.Visible = False
        '
        '
        '
        '
        '
        '
        '
        '
        '
        Me.tChart1.Legend.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tChart1.Legend.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tChart1.Legend.Brush.Gradient.SigmaFocus = 0.0!
        Me.tChart1.Legend.Brush.Gradient.SigmaScale = 0.0!
        Me.tChart1.Legend.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tChart1.Legend.Brush.Gradient.UseMiddle = True
        '
        '
        '
        Me.tChart1.Legend.Font.Name = "Arial"
        '
        '
        '
        '
        '
        '
        Me.tChart1.Legend.Title.Pen.Visible = False
        Me.tChart1.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        '
        '
        '
        '
        '
        '
        Me.tChart1.Panel.Brush.Gradient.SigmaFocus = 0.0!
        Me.tChart1.Panel.Brush.Gradient.SigmaScale = 0.0!
        '
        '
        '
        '
        '
        '
        '
        '
        '
        '
        '
        '
        Me.tChart1.Walls.Back.Brush.Gradient.SigmaFocus = 0.0!
        Me.tChart1.Walls.Back.Brush.Gradient.SigmaScale = 0.0!
        '
        '
        '
        '
        '
        '
        '
        '
        '
        Me.tChart1.Walls.Bottom.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tChart1.Walls.Bottom.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tChart1.Walls.Bottom.Brush.Gradient.SigmaFocus = 0.0!
        Me.tChart1.Walls.Bottom.Brush.Gradient.SigmaScale = 0.0!
        Me.tChart1.Walls.Bottom.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tChart1.Walls.Bottom.Brush.Gradient.UseMiddle = True
        '
        '
        '
        '
        '
        '
        '
        '
        '
        Me.tChart1.Walls.Left.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tChart1.Walls.Left.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tChart1.Walls.Left.Brush.Gradient.SigmaFocus = 0.0!
        Me.tChart1.Walls.Left.Brush.Gradient.SigmaScale = 0.0!
        Me.tChart1.Walls.Left.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tChart1.Walls.Left.Brush.Gradient.UseMiddle = True
        '
        '
        '
        '
        '
        '
        Me.tChart1.Walls.Right.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        '
        '
        '
        Me.tChart1.Walls.Right.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tChart1.Walls.Right.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tChart1.Walls.Right.Brush.Gradient.SigmaFocus = 0.0!
        Me.tChart1.Walls.Right.Brush.Gradient.SigmaScale = 0.0!
        Me.tChart1.Walls.Right.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tChart1.Walls.Right.Brush.Gradient.UseMiddle = True
        '
        'cbTopLeft
        '
        Me.cbTopLeft.Checked = True
        Me.cbTopLeft.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbTopLeft.Location = New System.Drawing.Point(12, 3)
        Me.cbTopLeft.Name = "cbTopLeft"
        Me.cbTopLeft.Size = New System.Drawing.Size(109, 17)
        Me.cbTopLeft.TabIndex = 0
        Me.cbTopLeft.Text = "AllowEdit TopLeft"
        '
        'cbBottomLeft
        '
        Me.cbBottomLeft.Checked = True
        Me.cbBottomLeft.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbBottomLeft.Location = New System.Drawing.Point(12, 19)
        Me.cbBottomLeft.Name = "cbBottomLeft"
        Me.cbBottomLeft.Size = New System.Drawing.Size(123, 17)
        Me.cbBottomLeft.TabIndex = 1
        Me.cbBottomLeft.Text = "AllowEdit BottomLeft"
        '
        'cbTopRight
        '
        Me.cbTopRight.Checked = True
        Me.cbTopRight.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbTopRight.Location = New System.Drawing.Point(141, 3)
        Me.cbTopRight.Name = "cbTopRight"
        Me.cbTopRight.Size = New System.Drawing.Size(116, 17)
        Me.cbTopRight.TabIndex = 2
        Me.cbTopRight.Text = "AllowEdit TopRight"
        '
        'cbBottomRight
        '
        Me.cbBottomRight.Checked = True
        Me.cbBottomRight.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbBottomRight.Location = New System.Drawing.Point(141, 19)
        Me.cbBottomRight.Name = "cbBottomRight"
        Me.cbBottomRight.Size = New System.Drawing.Size(130, 17)
        Me.cbBottomRight.TabIndex = 3
        Me.cbBottomRight.Text = "AllowEdit BottomRight"
        '
        'Tool_AnnotationAllowEdit
        '
        Me.ClientSize = New System.Drawing.Size(440, 317)
        Me.Name = "Tool_AnnotationAllowEdit"
        Me.Text = "Tool_AnnotationAllowEdit"
        Me.panel1.ResumeLayout(False)
        Me.chartContainer.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub cbTopLeft_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbTopLeft.CheckedChanged
        If Not anno1 Is Nothing Then
            anno1.AllowEdit = cbTopLeft.Checked
        End If
    End Sub

    Private Sub cbBottomLeft_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbBottomLeft.CheckedChanged
        If Not rect1 Is Nothing Then
            rect1.AllowEdit = cbBottomLeft.Checked
        End If
    End Sub

    Private Sub cbTopRight_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbTopRight.CheckedChanged
        If Not rect2 Is Nothing Then
            rect2.AllowEdit = cbTopLeft.Checked
        End If
    End Sub

    Private Sub cbBottomRight_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbBottomRight.CheckedChanged
        If Not anno2 Is Nothing Then
            anno2.AllowEdit = cbTopLeft.Checked
        End If
    End Sub

End Class

