
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms



Public Class PanelImageBevel
    Inherits Steema.TeeChart.Samples.BaseForm
    Private WithEvents bEdit As System.Windows.Forms.Button
    Private pie1 As Steema.TeeChart.Styles.Pie
    Private components As System.ComponentModel.IContainer = Nothing
    
    
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        
        pie1.FillSampleValues()
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
        Me.bEdit = New System.Windows.Forms.Button
        Me.pie1 = New Steema.TeeChart.Styles.Pie
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Text = "Image Bevels are an alternative to standard Windows bevels and " + vbCr + vbLf + "can be configure" + "d to any number of interesting combinations to give" + vbCr + vbLf + "that extra touch to your ch" + "arts."
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.bEdit)
        Me.panel1.Name = "panel1"
        ' 
        ' tChart1
        ' 
        ' 
        ' tChart1.Aspect
        ' 
        Me.tChart1.Aspect.Chart3DPercent = 70
        Me.tChart1.Aspect.Elevation = 333
        Me.tChart1.Aspect.HorizOffset = -12
        Me.tChart1.Aspect.Orthogonal = False
        Me.tChart1.Aspect.Perspective = 46
        Me.tChart1.Aspect.Rotation = 342
        Me.tChart1.Aspect.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
        Me.tChart1.Aspect.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias
        Me.tChart1.Aspect.VertOffset = -12
        Me.tChart1.Aspect.Zoom = 79
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
        Me.tChart1.Axes.Bottom.Grid.Color = System.Drawing.Color.FromArgb(CType(255, System.Byte), CType(185, System.Byte), CType(185, System.Byte))
        ' 
        ' tChart1.Axes.Bottom.Labels
        ' 
        ' 
        ' tChart1.Axes.Bottom.Labels.Font
        ' 
        Me.tChart1.Axes.Bottom.Labels.Font.Bold = True
        ' 
        ' tChart1.Axes.Bottom.Labels.Font.Brush
        ' 
        Me.tChart1.Axes.Bottom.Labels.Font.Brush.Color = System.Drawing.Color.Navy
        Me.tChart1.Axes.Bottom.Labels.Font.Name = "Tahoma"
        ' 
        ' tChart1.Axes.Bottom.MinorGrid
        ' 
        Me.tChart1.Axes.Bottom.MinorGrid.Color = System.Drawing.Color.FromArgb(CType(229, System.Byte), CType(229, System.Byte), CType(229, System.Byte))
        Me.tChart1.Axes.Bottom.MinorGrid.Visible = True
        Me.tChart1.Axes.Bottom.MinorTickCount = 7
        ' 
        ' tChart1.Axes.Bottom.Ticks
        ' 
        Me.tChart1.Axes.Bottom.Ticks.Length = 5
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
        ' 
        ' tChart1.Axes.Left
        ' 
        ' 
        ' tChart1.Axes.Left.AxisPen
        ' 
        Me.tChart1.Axes.Left.AxisPen.Color = System.Drawing.Color.Navy
        Me.tChart1.Axes.Left.AxisPen.Width = 1
        ' 
        ' tChart1.Axes.Left.Grid
        ' 
        Me.tChart1.Axes.Left.Grid.Color = System.Drawing.Color.Blue
        ' 
        ' tChart1.Axes.Left.Labels
        ' 
        ' 
        ' tChart1.Axes.Left.Labels.Font
        ' 
        Me.tChart1.Axes.Left.Labels.Font.Bold = True
        ' 
        ' tChart1.Axes.Left.Labels.Font.Brush
        ' 
        Me.tChart1.Axes.Left.Labels.Font.Brush.Color = System.Drawing.Color.Navy
        Me.tChart1.Axes.Left.Labels.Font.Name = "Tahoma"
        ' 
        ' tChart1.Axes.Left.Ticks
        ' 
        Me.tChart1.Axes.Left.Ticks.Length = 2
        ' 
        ' tChart1.Axes.Right
        ' 
        ' 
        ' tChart1.Axes.Right.Grid
        ' 
        Me.tChart1.Axes.Right.Grid.Color = System.Drawing.Color.Gray
        ' 
        ' tChart1.Axes.Right.Ticks
        ' 
        Me.tChart1.Axes.Right.Ticks.Length = 2
        Me.tChart1.Axes.Right.Visible = False
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
        ' tChart1.Header.Brush
        ' 
        Me.tChart1.Header.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(0, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        ' 
        ' tChart1.Header.Gradient
        ' 
        Me.tChart1.Header.Brush.Gradient.EndColor = System.Drawing.Color.Black
        Me.tChart1.Header.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(128, System.Byte), CType(0, System.Byte), CType(64, System.Byte))
        Me.tChart1.Header.Brush.Gradient.StartColor = System.Drawing.Color.Gray
        Me.tChart1.Header.Brush.Gradient.UseMiddle = True
        Me.tChart1.Header.Brush.Gradient.Visible = True
        ' 
        ' tChart1.Header.Font
        ' 
        Me.tChart1.Header.Font.Bold = True
        ' 
        ' tChart1.Header.Font.Brush
        ' 
        Me.tChart1.Header.Font.Brush.Color = System.Drawing.Color.Navy
        Me.tChart1.Header.Font.Name = "Verdana"
        Me.tChart1.Header.Font.Size = 12
        ' 
        ' tChart1.Header.Gradient
        ' 
        Me.tChart1.Header.Gradient.EndColor = System.Drawing.Color.Black
        Me.tChart1.Header.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(128, System.Byte), CType(0, System.Byte), CType(64, System.Byte))
        Me.tChart1.Header.Gradient.StartColor = System.Drawing.Color.Gray
        Me.tChart1.Header.Gradient.UseMiddle = True
        Me.tChart1.Header.Gradient.Visible = True
        Me.tChart1.Header.Lines = New String() {"Image Bevels"}
        ' 
        ' tChart1.Header.Pen
        ' 
        Me.tChart1.Header.Pen.Color = System.Drawing.Color.FromArgb(CType(153, System.Byte), CType(221, System.Byte), CType(251, System.Byte))
        Me.tChart1.Header.Pen.Width = 2
        ' 
        ' tChart1.Header.Shadow
        ' 
        ' 
        ' tChart1.Header.Shadow.Brush
        ' 
        Me.tChart1.Header.Shadow.Brush.Color = System.Drawing.Color.FromArgb(CType(76, System.Byte), CType(169, System.Byte), CType(169, System.Byte), CType(169, System.Byte))
        Me.tChart1.Header.Shadow.Height = 4
        Me.tChart1.Header.Shadow.Width = 4
        ' 
        ' tChart1.Legend
        ' 
        ' 
        ' tChart1.Legend.Brush
        ' 
        ' 
        ' tChart1.Legend.Gradient
        ' 
        Me.tChart1.Legend.Brush.Gradient.Direction = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.tChart1.Legend.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(206, System.Byte), CType(219, System.Byte), CType(255, System.Byte))
        Me.tChart1.Legend.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(224, System.Byte), CType(230, System.Byte), CType(233, System.Byte))
        Me.tChart1.Legend.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(255, System.Byte), CType(243, System.Byte), CType(234, System.Byte))
        Me.tChart1.Legend.Brush.Gradient.UseMiddle = True
        Me.tChart1.Legend.Brush.Gradient.Visible = True
        ' 
        ' tChart1.Legend.DividingLines
        ' 
        Me.tChart1.Legend.DividingLines.Color = System.Drawing.Color.Silver
        Me.tChart1.Legend.DividingLines.Visible = True
        ' 
        ' tChart1.Legend.Font
        ' 
        ' 
        ' tChart1.Legend.Font.Brush
        ' 
        Me.tChart1.Legend.Font.Brush.Color = System.Drawing.Color.FromArgb(CType(100, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        ' 
        ' tChart1.Legend.Gradient
        ' 
        Me.tChart1.Legend.Gradient.Direction = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.tChart1.Legend.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(206, System.Byte), CType(219, System.Byte), CType(255, System.Byte))
        Me.tChart1.Legend.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(224, System.Byte), CType(230, System.Byte), CType(233, System.Byte))
        Me.tChart1.Legend.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(255, System.Byte), CType(243, System.Byte), CType(234, System.Byte))
        Me.tChart1.Legend.Gradient.UseMiddle = True
        Me.tChart1.Legend.Gradient.Visible = True
        ' 
        ' tChart1.Legend.Shadow
        ' 
        ' 
        ' tChart1.Legend.Shadow.Brush
        ' 
        Me.tChart1.Legend.Shadow.Brush.Color = System.Drawing.Color.FromArgb(CType(127, System.Byte), CType(0, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        Me.tChart1.Legend.Shadow.Height = 4
        Me.tChart1.Legend.Shadow.Width = 5
        ' 
        ' tChart1.Legend.Symbol
        ' 
        Me.tChart1.Legend.Symbol.Squared = True
        Me.tChart1.Legend.Visible = False
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Brush
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        ' 
        ' tChart1.Panel.Gradient
        ' 
        Me.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(255, System.Byte), CType(255, System.Byte), CType(128, System.Byte))
        Me.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(165, System.Byte), CType(3, System.Byte), CType(32, System.Byte))
        Me.tChart1.Panel.Brush.Gradient.UseMiddle = True
        ' 
        ' tChart1.Panel.Gradient
        ' 
        Me.tChart1.Panel.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(255, System.Byte), CType(255, System.Byte), CType(128, System.Byte))
        Me.tChart1.Panel.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(165, System.Byte), CType(3, System.Byte), CType(32, System.Byte))
        Me.tChart1.Panel.Gradient.UseMiddle = True
        ' 
        ' tChart1.Panel.ImageBevel
        ' 
        ' 
        ' tChart1.Panel.ImageBevel.Brush
        ' 
        Me.tChart1.Panel.ImageBevel.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(128, System.Byte), CType(128, System.Byte), CType(208, System.Byte))
        Me.tChart1.Panel.ImageBevel.Brush.ForegroundColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(192, System.Byte), CType(192, System.Byte), CType(192, System.Byte))
        Me.tChart1.Panel.ImageBevel.Brush.Solid = False
        Me.tChart1.Panel.ImageBevel.Brush.Style = System.Drawing.Drawing2D.HatchStyle.Shingle
        ' 
        ' tChart1.Panel.ImageBevel.Pen
        ' 
        Me.tChart1.Panel.ImageBevel.Pen.Color = System.Drawing.Color.FromArgb(CType(127, System.Byte), CType(0, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        Me.tChart1.Panel.ImageBevel.Pen.Transparency = 50
        Me.tChart1.Panel.ImageBevel.Pen.Visible = False
        Me.tChart1.Panel.ImageBevel.Pen.Width = 2
        Me.tChart1.Panel.ImageBevel.Visible = True
        Me.tChart1.Panel.ImageBevel.Width = 18
        ' 
        ' tChart1.Panel.Pen
        ' 
        Me.tChart1.Panel.Pen.Color = System.Drawing.Color.Navy
        Me.tChart1.Panel.Pen.Width = 6
        ' 
        ' tChart1.Panel.Shadow
        ' 
        ' 
        ' tChart1.Panel.Shadow.Brush
        ' 
        Me.tChart1.Panel.Shadow.Brush.Color = System.Drawing.Color.Black
        Me.tChart1.Panel.Shadow.Height = 7
        Me.tChart1.Panel.Shadow.Visible = True
        Me.tChart1.Panel.Shadow.Width = 7
        ' 
        ' tChart1.Walls
        ' 
        ' 
        ' tChart1.Walls.Back
        ' 
        ' 
        ' tChart1.Walls.Back.Brush
        ' 
        Me.tChart1.Walls.Back.Brush.Color = System.Drawing.Color.FromArgb(CType(51, System.Byte), CType(207, System.Byte), CType(236, System.Byte), CType(252, System.Byte))
        ' 
        ' tChart1.Walls.Back.Gradient
        ' 
        Me.tChart1.Walls.Back.Brush.Gradient.Transparency = 80
        ' 
        ' tChart1.Walls.Back.Gradient
        ' 
        Me.tChart1.Walls.Back.Gradient.Transparency = 80
        ' 
        ' tChart1.Walls.Back.Pen
        ' 
        Me.tChart1.Walls.Back.Pen.Visible = False
        Me.tChart1.Walls.Back.Size = 5
        Me.tChart1.Walls.Back.Transparent = False
        ' 
        ' tChart1.Walls.Bottom
        ' 
        ' 
        ' tChart1.Walls.Bottom.Brush
        ' 
        Me.tChart1.Walls.Bottom.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(192, System.Byte))
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
        Me.tChart1.Walls.Left.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(53, System.Byte), CType(53, System.Byte), CType(0, System.Byte))
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
        Me.tChart1.Walls.Right.Brush.Color = System.Drawing.Color.Silver
        Me.tChart1.Walls.Right.Size = 5
        ' 
        ' bEdit
        ' 
        Me.bEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bEdit.Location = New System.Drawing.Point(16, 8)
        Me.bEdit.Name = "bEdit"
        Me.bEdit.Size = New System.Drawing.Size(72, 23)
        Me.bEdit.TabIndex = 0
        Me.bEdit.Text = "Edit..."
        ' 
        ' pie1
        ' 
        ' 
        ' pie1.Brush
        ' 
        Me.pie1.Brush.Color = System.Drawing.Color.FromArgb(CType(255, System.Byte), CType(255, System.Byte), CType(204, System.Byte))
        ' 
        ' pie1.Marks
        ' 
        ' 
        ' pie1.Marks.Symbol
        ' 
        ' 
        ' pie1.Marks.Symbol.Shadow
        ' 
        Me.pie1.Marks.Symbol.Shadow.Height = 1
        Me.pie1.Marks.Symbol.Shadow.Visible = True
        Me.pie1.Marks.Symbol.Shadow.Width = 1
        ' 
        ' pie1.Shadow
        ' 
        Me.pie1.Shadow.Height = 20
        Me.pie1.Shadow.Width = 20
        Me.pie1.Title = "pie1"
        ' 
        ' pie1.XValues
        ' 
        Me.pie1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' PanelImageBevel
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(440, 317)
        Me.Name = "PanelImageBevel"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub 'InitializeComponent 
#End Region


    Private Sub bEdit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles bEdit.Click
        Dim editor As New Steema.TeeChart.Editors.BevelImageEditor(tChart1.Panel.ImageBevel, Nothing)
        Steema.TeeChart.Editors.EditorUtils.Translate(editor)
        Steema.TeeChart.Editors.EditorUtils.ShowFormModal(editor)
    End Sub 'bEdit_Click
End Class 'PanelImageBevel
