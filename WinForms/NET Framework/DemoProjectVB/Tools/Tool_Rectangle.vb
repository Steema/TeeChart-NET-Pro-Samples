
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing

Imports System.Windows.Forms



Public Class Tool_Rectangle
    Inherits Samples.BaseForm

    Private points1 As Steema.TeeChart.Styles.Points
    Private rectangleTool1 As Steema.TeeChart.Tools.RectangleTool
    Private bEditRectangleTool As Button

    '/ <summary>
    '/ Required designer variable.
    '/ </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    Public Sub New() ' This call is required by the Windows Form Designer.
        InitializeComponent()
        InitializeChart()
    End Sub

    Private Sub InitializeChart()

        tChart1(0).FillSampleValues()

        rectangleTool1 = New Steema.TeeChart.Tools.RectangleTool(tChart1.Chart)
        rectangleTool1.AutoSize = True
        rectangleTool1.Text = "Rectangle"

        AddHandler rectangleTool1.Click, AddressOf Me.rectangleTool1_Click
        AddHandler rectangleTool1.Dragged, AddressOf Me.rectangleTool1_Dragged
        AddHandler rectangleTool1.Dragging, AddressOf Me.rectangleTool1_Dragging
        AddHandler rectangleTool1.Resized, AddressOf Me.rectangleTool1_Resized
        AddHandler rectangleTool1.Resizing, AddressOf Me.rectangleTool1_Resizing
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Tool_Rectangle))
        Me.points1 = New Steema.TeeChart.Styles.Points
        Me.bEditRectangleTool = New System.Windows.Forms.Button
        Me.panel1.SuspendLayout()
        Me.chartContainer.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Text = "New Rectangle Tool defines a fully configurable shape with text which can be drag" + "" & vbCrLf & "and resized at runtime." & vbCrLf & vbCrLf & "Click on the 'Rectangle' to drag and resize it."
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.bEditRectangleTool)
        ' 
        ' tChart1
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Aspect.ColorPaletteIndex = -1
        Me.tChart1.Aspect.ElevationFloat = 345
        Me.tChart1.Aspect.RotationFloat = 345
        Me.tChart1.Aspect.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
        Me.tChart1.Aspect.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Bottom.Automatic = True
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Bottom.Grid.Style = System.Drawing.Drawing2D.DashStyle.Dash
        Me.tChart1.Axes.Bottom.Grid.ZPosition = 0
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Bottom.Labels.Font.Unit = System.Drawing.GraphicsUnit.World
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Bottom.MinorTicks.Visible = True
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Bottom.TicksInner.Color = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.tChart1.Axes.Bottom.TicksInner.Visible = True
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Bottom.Title.Font.Unit = System.Drawing.GraphicsUnit.World
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Depth.Automatic = True
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Depth.Grid.Style = System.Drawing.Drawing2D.DashStyle.Dash
        Me.tChart1.Axes.Depth.Grid.ZPosition = 0
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Depth.Labels.Font.Unit = System.Drawing.GraphicsUnit.World
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Depth.MinorTicks.Visible = True
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Depth.TicksInner.Color = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.tChart1.Axes.Depth.TicksInner.Visible = True
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Depth.Title.Font.Unit = System.Drawing.GraphicsUnit.World
        ' 
        ' 
        ' 
        Me.tChart1.Axes.DepthTop.Automatic = True
        ' 
        ' 
        ' 
        Me.tChart1.Axes.DepthTop.Grid.Style = System.Drawing.Drawing2D.DashStyle.Dash
        Me.tChart1.Axes.DepthTop.Grid.ZPosition = 0
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.DepthTop.Labels.Font.Unit = System.Drawing.GraphicsUnit.World
        ' 
        ' 
        ' 
        Me.tChart1.Axes.DepthTop.MinorTicks.Visible = True
        ' 
        ' 
        ' 
        Me.tChart1.Axes.DepthTop.TicksInner.Color = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.tChart1.Axes.DepthTop.TicksInner.Visible = True
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.DepthTop.Title.Font.Unit = System.Drawing.GraphicsUnit.World
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Left.Automatic = True
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Left.Grid.Style = System.Drawing.Drawing2D.DashStyle.Dash
        Me.tChart1.Axes.Left.Grid.ZPosition = 0
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Left.Labels.Font.Unit = System.Drawing.GraphicsUnit.World
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Left.MinorTicks.Visible = True
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Left.TicksInner.Color = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.tChart1.Axes.Left.TicksInner.Visible = True
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Left.Title.Font.Unit = System.Drawing.GraphicsUnit.World
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Right.Automatic = True
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Right.Grid.Style = System.Drawing.Drawing2D.DashStyle.Dash
        Me.tChart1.Axes.Right.Grid.ZPosition = 0
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Right.Labels.Font.Unit = System.Drawing.GraphicsUnit.World
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Right.MinorTicks.Visible = True
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Right.TicksInner.Color = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.tChart1.Axes.Right.TicksInner.Visible = True
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Right.Title.Font.Unit = System.Drawing.GraphicsUnit.World
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Top.Automatic = True
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Top.Grid.Style = System.Drawing.Drawing2D.DashStyle.Dash
        Me.tChart1.Axes.Top.Grid.ZPosition = 0
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Top.Labels.Font.Unit = System.Drawing.GraphicsUnit.World
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Top.MinorTicks.Visible = True
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Top.TicksInner.Color = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.tChart1.Axes.Top.TicksInner.Visible = True
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Top.Title.Font.Unit = System.Drawing.GraphicsUnit.World
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Footer.Font.Unit = System.Drawing.GraphicsUnit.World
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Header.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tChart1.Header.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tChart1.Header.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tChart1.Header.Gradient.UseMiddle = True
        ' 
        ' 
        ' 
        Me.tChart1.Header.Font.Unit = System.Drawing.GraphicsUnit.World
        Me.tChart1.Header.Lines = New String() {"Rectangle Tool"}
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Legend.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tChart1.Legend.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tChart1.Legend.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tChart1.Legend.Gradient.UseMiddle = True
        ' 
        ' 
        ' 
        Me.tChart1.Legend.Font.Unit = System.Drawing.GraphicsUnit.World
        ' 
        ' 
        ' 
        Me.tChart1.Legend.Shadow.Visible = True
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Legend.Title.Font.Bold = True
        Me.tChart1.Legend.Title.Font.Unit = System.Drawing.GraphicsUnit.World
        ' 
        ' 
        ' 
        Me.tChart1.Legend.Title.Pen.Visible = False
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Panel.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.tChart1.Panel.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tChart1.Panel.Gradient.Sigma = True
        Me.tChart1.Panel.Gradient.SigmaFocus = 1.0!
        Me.tChart1.Panel.Gradient.SigmaScale = 0.8!
        Me.tChart1.Panel.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tChart1.Panel.Gradient.UseMiddle = True
        Me.tChart1.Panel.Gradient.Visible = True
        Me.tChart1.Series.Add(Me.points1)
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.SubFooter.Font.Unit = System.Drawing.GraphicsUnit.World
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.SubHeader.Font.Unit = System.Drawing.GraphicsUnit.World
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Walls.Back.AutoHide = False
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Walls.Back.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tChart1.Walls.Back.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tChart1.Walls.Back.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tChart1.Walls.Back.Gradient.UseMiddle = True
        ' 
        ' 
        ' 
        Me.tChart1.Walls.Bottom.AutoHide = False
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Walls.Bottom.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tChart1.Walls.Bottom.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tChart1.Walls.Bottom.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tChart1.Walls.Bottom.Gradient.UseMiddle = True
        ' 
        ' 
        ' 
        Me.tChart1.Walls.Left.AutoHide = False
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Walls.Left.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tChart1.Walls.Left.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tChart1.Walls.Left.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tChart1.Walls.Left.Gradient.UseMiddle = True
        ' 
        ' 
        ' 
        Me.tChart1.Walls.Right.AutoHide = False
        ' 
        ' 
        ' 
        Me.tChart1.Walls.Right.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer))
        ' 
        ' 
        ' 
        Me.tChart1.Walls.Right.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tChart1.Walls.Right.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tChart1.Walls.Right.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tChart1.Walls.Right.Gradient.UseMiddle = True
        Me.tChart1.Walls.Right.Brush.Visible = True
        ' 
        ' points1
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.points1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None
        Me.points1.Marks.Callout.ArrowHeadSize = 8
        Me.points1.Marks.Callout.Distance = 0
        Me.points1.Marks.Callout.Draw3D = False
        Me.points1.Marks.Callout.Length = 0
        Me.points1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        ' 
        ' 
        ' 
        Me.points1.Marks.Font.Unit = System.Drawing.GraphicsUnit.World
        ' 
        ' 
        ' 
        Me.points1.Marks.Shadow.Visible = True
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.points1.Marks.Symbol.Shadow.Visible = True
        ' 
        ' 
        ' 
        Me.points1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.points1.Pointer.Visible = True
        Me.points1.Title = "point1"
        ' 
        ' 
        ' 
        Me.points1.XValues.DataMember = "X"
        Me.points1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' 
        ' 
        Me.points1.YValues.DataMember = "Y"
        ' 
        ' bEditRectangleTool
        ' 
        Me.bEditRectangleTool.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bEditRectangleTool.Location = New System.Drawing.Point(12, 6)
        Me.bEditRectangleTool.Name = "bEditRectangleTool"
        Me.bEditRectangleTool.Size = New System.Drawing.Size(134, 23)
        Me.bEditRectangleTool.TabIndex = 0
        Me.bEditRectangleTool.Text = "Edit RectangleTool..."
#If (VS2005) Then
Me.bEditRectangleTool.UseVisualStyleBackColor = true
#End If
        AddHandler bEditRectangleTool.Click, AddressOf Me.bEditRectangleTool_Click
        ' 
        ' Tool_Rectangle
        ' 
#If (VS2005) Then
Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
#End If
        Me.ClientSize = New System.Drawing.Size(440, 317)
        Me.Name = "Tool_Rectangle"
        Me.Text = "Tool_Rectangle"
        Me.panel1.ResumeLayout(False)
        Me.chartContainer.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

#End Region

    Private Sub bEditRectangleTool_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim rect As Steema.TeeChart.Editors.Tools.AnnotationEditor = New Steema.TeeChart.Editors.Tools.AnnotationEditor(rectangleTool1)
        Steema.TeeChart.Editors.EditorUtils.ShowFormModal(rect)
    End Sub

    Private Sub rectangleTool1_Click(ByVal sender As Object, ByVal e As MouseEventArgs)
        rectangleTool1.AutoSize = False
        rectangleTool1.Text = "Click"
    End Sub

    Private Sub rectangleTool1_Dragged(ByVal sender As Object, ByVal e As EventArgs)
        rectangleTool1.Text = "Dragged"
    End Sub

    Private Sub rectangleTool1_Dragging(ByVal sender As Object, ByVal e As EventArgs)
        rectangleTool1.Text = "Dragging"
    End Sub

    Private Sub rectangleTool1_Resized(ByVal sender As Object, ByVal e As EventArgs)
        rectangleTool1.Text = "Resized"
    End Sub

    Private Sub rectangleTool1_Resizing(ByVal sender As Object, ByVal e As EventArgs)
        rectangleTool1.Text = "Resizing"
    End Sub

End Class

