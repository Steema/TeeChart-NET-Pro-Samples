
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing

Imports System.Windows.Forms




Public Class Contour_Filled
    Inherits Samples.BaseForm
    Private contour1 As Steema.TeeChart.Styles.Contour
    Private buttonPen1 As ButtonPen
    Private WithEvents button2 As Button
    Private WithEvents button1 As Button
    Private components As System.ComponentModel.IContainer = Nothing


    Public Sub New()
        ' me call is required by the Windows Form Designer.
        InitializeComponent()
        buttonPen1.Pen = contour1.Frame
        contour1.FillSampleValues(10)
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
    '/ the contents of me method with the code editor.
    '/ </summary>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Contour_Filled))
        Me.contour1 = New Steema.TeeChart.Styles.Contour
        Me.button1 = New System.Windows.Forms.Button
        Me.button2 = New System.Windows.Forms.Button
        Me.buttonPen1 = New Steema.TeeChart.ButtonPen
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
        Me.panel1.Controls.Add(Me.buttonPen1)
        Me.panel1.Controls.Add(Me.button2)
        Me.panel1.Controls.Add(Me.button1)
        '
        'tChart1
        '
        '
        '
        '
        Me.tChart1.Aspect.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
        Me.tChart1.Aspect.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias
        Me.tChart1.Aspect.View3D = False
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
        Me.tChart1.Legend.MaxNumRows = 8
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
        Me.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tChart1.Panel.Brush.Gradient.SigmaFocus = 0.0!
        Me.tChart1.Panel.Brush.Gradient.SigmaScale = 0.0!
        Me.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tChart1.Panel.Brush.Gradient.Visible = False
        Me.tChart1.Series.Add(Me.contour1)
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
        Me.tChart1.Walls.Back.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tChart1.Walls.Back.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tChart1.Walls.Back.Brush.Gradient.SigmaFocus = 0.0!
        Me.tChart1.Walls.Back.Brush.Gradient.SigmaScale = 0.0!
        Me.tChart1.Walls.Back.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tChart1.Walls.Back.Brush.Gradient.UseMiddle = True
        Me.tChart1.Walls.Back.Brush.Gradient.Visible = False
        Me.tChart1.Walls.Back.Brush.Visible = False
        Me.tChart1.Walls.Back.Transparent = True
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
        'contour1
        '
        '
        '
        '
        Me.contour1.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.contour1.ColorEach = False
        Me.contour1.EndColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.contour1.FillLevels = True
        '
        '
        '
        '
        '
        '
        Me.contour1.Marks.Brush.Visible = False
        '
        '
        '
        Me.contour1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None
        Me.contour1.Marks.Callout.ArrowHeadSize = 8
        '
        '
        '
        Me.contour1.Marks.Callout.Brush.Color = System.Drawing.Color.Black
        Me.contour1.Marks.Callout.Distance = 0
        Me.contour1.Marks.Callout.Draw3D = False
        Me.contour1.Marks.Callout.Length = 10
        Me.contour1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.contour1.Marks.Transparent = True
        Me.contour1.Marks.Visible = True
        Me.contour1.NumLevels = 8
        Me.contour1.PaletteMin = 0
        Me.contour1.PaletteStep = 0
        Me.contour1.PaletteStyle = Steema.TeeChart.Styles.PaletteStyles.Pale
        '
        '
        '
        Me.contour1.Pen.Color = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.contour1.Pen.Style = System.Drawing.Drawing2D.DashStyle.Dot
        '
        '
        '
        Me.contour1.Pointer.HorizSize = 2
        '
        '
        '
        Me.contour1.Pointer.Pen.Visible = False
        Me.contour1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.contour1.Pointer.VertSize = 2
        Me.contour1.StartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.contour1.Title = "contour1"
        '
        '
        '
        Me.contour1.XValues.DataMember = "X"
        Me.contour1.YPosition = 0.18959828428699516
        '
        '
        '
        Me.contour1.YValues.DataMember = "Y"
        '
        '
        '
        Me.contour1.ZValues.DataMember = "Z"
        '
        'button1
        '
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.Location = New System.Drawing.Point(25, 10)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(75, 23)
        Me.button1.TabIndex = 0
        Me.button1.Text = "Edit"
#If VS2005 Then
        Me.button1.UseVisualStyleBackColor = True
#End If
        '
        'button2
        '
        Me.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button2.Location = New System.Drawing.Point(106, 10)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(75, 23)
        Me.button2.TabIndex = 1
        Me.button2.Text = "Pattern"
#If VS2005 Then
        Me.button2.UseVisualStyleBackColor = True
#End If
        '
        'buttonPen1
        '
        Me.buttonPen1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonPen1.Location = New System.Drawing.Point(187, 10)
        Me.buttonPen1.Name = "buttonPen1"
        Me.buttonPen1.Size = New System.Drawing.Size(75, 23)
        Me.buttonPen1.TabIndex = 2
        Me.buttonPen1.Text = "Frame"
#If VS2005 Then
        Me.buttonPen1.UseVisualStyleBackColor = True
#End If
        '
        'Contour_Filled
        '
        Me.ClientSize = New System.Drawing.Size(440, 317)
        Me.Name = "Contour_Filled"
        Me.panel1.ResumeLayout(False)
        Me.chartContainer.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub 'InitializeComponent 
#End Region

    Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
        Dim Form As Steema.TeeChart.Editors.Series.ContourSeries = New Steema.TeeChart.Editors.Series.ContourSeries(contour1)
        Steema.TeeChart.Editors.EditorUtils.ShowFormModal(Form)
    End Sub

    Private Sub button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button2.Click
        Dim bredit As Steema.TeeChart.Editors.BrushEditor = New Steema.TeeChart.Editors.BrushEditor(contour1.Brush)
        Steema.TeeChart.Editors.EditorUtils.ShowFormModal(bredit)
    End Sub

End Class 'Area_Gradient
