
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms


Public Class Polar_Smooth
    Inherits Steema.TeeChart.Samples.BaseForm
    Private polar1 As Steema.TeeChart.Styles.Polar
    Private checkBox1 As System.Windows.Forms.CheckBox
    Private polar2 As Steema.TeeChart.Styles.Polar
    Private smoothing1 As Steema.TeeChart.Functions.Smoothing
    Private checkBox2 As System.Windows.Forms.CheckBox
    Private groupBox1 As System.Windows.Forms.GroupBox
    Private checkBox3 As System.Windows.Forms.CheckBox
    Private components As System.ComponentModel.IContainer = Nothing
    
    Public Sub New() ' This call is required by the Windows Form Designer.
        InitializeComponent()

        polar1.FillSampleValues()
        polar2.Pointer.Visible = False
        polar2.RefreshSeries()
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

#Region "Windows Form Designer generated code"

    '/ <summary>
    '/ Required method for Designer support - do not modify
    '/ the contents of this method with the code editor.
    '/ </summary>
    Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Polar_Smooth))
        Me.polar1 = New Steema.TeeChart.Styles.Polar
        Me.checkBox1 = New System.Windows.Forms.CheckBox
        Me.polar2 = New Steema.TeeChart.Styles.Polar
        Me.smoothing1 = New Steema.TeeChart.Functions.Smoothing
        Me.checkBox2 = New System.Windows.Forms.CheckBox
        Me.groupBox1 = New System.Windows.Forms.GroupBox
        Me.checkBox3 = New System.Windows.Forms.CheckBox
        Me.panel1.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Text = "The smoothing function can be applied to Polar charts." & vbCrLf
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.groupBox1)
        Me.panel1.Controls.Add(Me.checkBox2)
        Me.panel1.Controls.Add(Me.checkBox1)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(440, 63)
        '
        ' tChart1
        ' 
        ' 
        ' tChart1.Aspect
        ' 
        Me.tChart1.Aspect.Elevation = 315
        Me.tChart1.Aspect.Orthogonal = False
        Me.tChart1.Aspect.Perspective = 0
        Me.tChart1.Aspect.Rotation = 360
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
        ' tChart1.Axes.Bottom.Grid
        ' 
        Me.tChart1.Axes.Bottom.Grid.ZPosition = 0
        ' 
        ' tChart1.Axes.Bottom.Labels
        ' 
        ' 
        ' tChart1.Axes.Bottom.Labels.Font
        ' 
        ' 
        ' tChart1.Axes.Bottom.Labels.Font.Shadow
        ' 
        Me.tChart1.Axes.Bottom.Labels.Font.Shadow.Visible = False
        ' 
        ' tChart1.Axes.Bottom.Labels.Shadow
        ' 
        Me.tChart1.Axes.Bottom.Labels.Shadow.Visible = False
        ' 
        ' tChart1.Axes.Bottom.Title
        ' 
        ' 
        ' tChart1.Axes.Bottom.Title.Font
        ' 
        ' 
        ' tChart1.Axes.Bottom.Title.Font.Shadow
        ' 
        Me.tChart1.Axes.Bottom.Title.Font.Shadow.Visible = False
        ' 
        ' tChart1.Axes.Bottom.Title.Shadow
        ' 
        Me.tChart1.Axes.Bottom.Title.Shadow.Visible = False
        ' 
        ' tChart1.Axes.Depth
        ' 
        ' 
        ' tChart1.Axes.Depth.Grid
        ' 
        Me.tChart1.Axes.Depth.Grid.ZPosition = 0
        ' 
        ' tChart1.Axes.Depth.Labels
        ' 
        ' 
        ' tChart1.Axes.Depth.Labels.Font
        ' 
        ' 
        ' tChart1.Axes.Depth.Labels.Font.Shadow
        ' 
        Me.tChart1.Axes.Depth.Labels.Font.Shadow.Visible = False
        ' 
        ' tChart1.Axes.Depth.Labels.Shadow
        ' 
        Me.tChart1.Axes.Depth.Labels.Shadow.Visible = False
        ' 
        ' tChart1.Axes.Depth.Title
        ' 
        ' 
        ' tChart1.Axes.Depth.Title.Font
        ' 
        ' 
        ' tChart1.Axes.Depth.Title.Font.Shadow
        ' 
        Me.tChart1.Axes.Depth.Title.Font.Shadow.Visible = False
        ' 
        ' tChart1.Axes.Depth.Title.Shadow
        ' 
        Me.tChart1.Axes.Depth.Title.Shadow.Visible = False
        ' 
        ' tChart1.Axes.DepthTop
        ' 
        ' 
        ' tChart1.Axes.DepthTop.Grid
        ' 
        Me.tChart1.Axes.DepthTop.Grid.ZPosition = 0
        ' 
        ' tChart1.Axes.DepthTop.Labels
        ' 
        ' 
        ' tChart1.Axes.DepthTop.Labels.Font
        ' 
        ' 
        ' tChart1.Axes.DepthTop.Labels.Font.Shadow
        ' 
        Me.tChart1.Axes.DepthTop.Labels.Font.Shadow.Visible = False
        ' 
        ' tChart1.Axes.DepthTop.Labels.Shadow
        ' 
        Me.tChart1.Axes.DepthTop.Labels.Shadow.Visible = False
        ' 
        ' tChart1.Axes.DepthTop.Title
        ' 
        ' 
        ' tChart1.Axes.DepthTop.Title.Font
        ' 
        ' 
        ' tChart1.Axes.DepthTop.Title.Font.Shadow
        ' 
        Me.tChart1.Axes.DepthTop.Title.Font.Shadow.Visible = False
        ' 
        ' tChart1.Axes.DepthTop.Title.Shadow
        ' 
        Me.tChart1.Axes.DepthTop.Title.Shadow.Visible = False
        ' 
        ' tChart1.Axes.Left
        ' 
        ' 
        ' tChart1.Axes.Left.Grid
        ' 
        Me.tChart1.Axes.Left.Grid.ZPosition = 0
        ' 
        ' tChart1.Axes.Left.Labels
        ' 
        ' 
        ' tChart1.Axes.Left.Labels.Font
        ' 
        ' 
        ' tChart1.Axes.Left.Labels.Font.Shadow
        ' 
        Me.tChart1.Axes.Left.Labels.Font.Shadow.Visible = False
        ' 
        ' tChart1.Axes.Left.Labels.Shadow
        ' 
        Me.tChart1.Axes.Left.Labels.Shadow.Visible = False
        ' 
        ' tChart1.Axes.Left.Title
        ' 
        ' 
        ' tChart1.Axes.Left.Title.Font
        ' 
        ' 
        ' tChart1.Axes.Left.Title.Font.Shadow
        ' 
        Me.tChart1.Axes.Left.Title.Font.Shadow.Visible = False
        ' 
        ' tChart1.Axes.Left.Title.Shadow
        ' 
        Me.tChart1.Axes.Left.Title.Shadow.Visible = False
        ' 
        ' tChart1.Axes.Right
        ' 
        ' 
        ' tChart1.Axes.Right.Grid
        ' 
        Me.tChart1.Axes.Right.Grid.ZPosition = 0
        ' 
        ' tChart1.Axes.Right.Labels
        ' 
        ' 
        ' tChart1.Axes.Right.Labels.Font
        ' 
        ' 
        ' tChart1.Axes.Right.Labels.Font.Shadow
        ' 
        Me.tChart1.Axes.Right.Labels.Font.Shadow.Visible = False
        ' 
        ' tChart1.Axes.Right.Labels.Shadow
        ' 
        Me.tChart1.Axes.Right.Labels.Shadow.Visible = False
        ' 
        ' tChart1.Axes.Right.Title
        ' 
        ' 
        ' tChart1.Axes.Right.Title.Font
        ' 
        ' 
        ' tChart1.Axes.Right.Title.Font.Shadow
        ' 
        Me.tChart1.Axes.Right.Title.Font.Shadow.Visible = False
        ' 
        ' tChart1.Axes.Right.Title.Shadow
        ' 
        Me.tChart1.Axes.Right.Title.Shadow.Visible = False
        ' 
        ' tChart1.Axes.Top
        ' 
        ' 
        ' tChart1.Axes.Top.Grid
        ' 
        Me.tChart1.Axes.Top.Grid.ZPosition = 0
        ' 
        ' tChart1.Axes.Top.Labels
        ' 
        ' 
        ' tChart1.Axes.Top.Labels.Font
        ' 
        ' 
        ' tChart1.Axes.Top.Labels.Font.Shadow
        ' 
        Me.tChart1.Axes.Top.Labels.Font.Shadow.Visible = False
        ' 
        ' tChart1.Axes.Top.Labels.Shadow
        ' 
        Me.tChart1.Axes.Top.Labels.Shadow.Visible = False
        ' 
        ' tChart1.Axes.Top.Title
        ' 
        ' 
        ' tChart1.Axes.Top.Title.Font
        ' 
        ' 
        ' tChart1.Axes.Top.Title.Font.Shadow
        ' 
        Me.tChart1.Axes.Top.Title.Font.Shadow.Visible = False
        ' 
        ' tChart1.Axes.Top.Title.Shadow
        ' 
        Me.tChart1.Axes.Top.Title.Shadow.Visible = False
        ' 
        ' tChart1.Footer
        ' 
        ' 
        ' tChart1.Footer.Font
        ' 
        ' 
        ' tChart1.Footer.Font.Shadow
        ' 
        Me.tChart1.Footer.Font.Shadow.Visible = False
        ' 
        ' tChart1.Footer.Shadow
        ' 
        Me.tChart1.Footer.Shadow.Visible = False
        ' 
        ' tChart1.Header
        ' 
        ' 
        ' tChart1.Header.Font
        ' 
        ' 
        ' tChart1.Header.Font.Shadow
        ' 
        Me.tChart1.Header.Font.Shadow.Visible = False
        Me.tChart1.Header.Lines = New String() {"Smooth Polar Chart"}
        ' 
        ' tChart1.Header.Shadow
        ' 
        Me.tChart1.Header.Shadow.Visible = False
        ' 
        ' tChart1.Legend
        ' 
        ' 
        ' tChart1.Legend.Font
        ' 
        ' 
        ' tChart1.Legend.Font.Shadow
        ' 
        Me.tChart1.Legend.Font.Shadow.Visible = False
        ' 
        ' tChart1.Legend.Title
        ' 
        ' 
        ' tChart1.Legend.Title.Font
        ' 
        Me.tChart1.Legend.Title.Font.Bold = True
        ' 
        ' tChart1.Legend.Title.Font.Shadow
        ' 
        Me.tChart1.Legend.Title.Font.Shadow.Visible = False
        ' 
        ' tChart1.Legend.Title.Pen
        ' 
        Me.tChart1.Legend.Title.Pen.Visible = False
        ' 
        ' tChart1.Legend.Title.Shadow
        ' 
        Me.tChart1.Legend.Title.Shadow.Visible = False
        Me.tChart1.Legend.Visible = False
        Me.tChart1.Location = New System.Drawing.Point(0, 136)
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
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        ' 
        ' tChart1.Panel.Gradient
        ' 
        Me.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(128, System.Byte))
        Me.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(192, System.Byte))
        Me.tChart1.Panel.Brush.Gradient.UseMiddle = True
        Me.tChart1.Panel.Brush.Gradient.Visible = True
        ' 
        ' tChart1.Panel.Gradient
        ' 
        Me.tChart1.Panel.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(128, System.Byte))
        Me.tChart1.Panel.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.tChart1.Panel.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(192, System.Byte))
        Me.tChart1.Panel.Gradient.UseMiddle = True
        Me.tChart1.Panel.Gradient.Visible = True
        ' 
        ' tChart1.Panel.ImageBevel
        ' 
        ' 
        ' tChart1.Panel.ImageBevel.Brush
        ' 
        Me.tChart1.Panel.ImageBevel.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(128, System.Byte), CType(128, System.Byte))
        Me.tChart1.Panel.ImageBevel.Visible = True
        Me.tChart1.Panel.ImageBevel.Width = 6
        ' 
        ' tChart1.Panel.Shadow
        ' 
        Me.tChart1.Panel.Shadow.Visible = False
        Me.tChart1.Series.Add(Me.polar2)
        Me.tChart1.Series.Add(Me.polar1)
        Me.tChart1.Size = New System.Drawing.Size(440, 181)
        ' 
        ' tChart1.SubFooter
        ' 
        ' 
        ' tChart1.SubFooter.Font
        ' 
        ' 
        ' tChart1.SubFooter.Font.Shadow
        ' 
        Me.tChart1.SubFooter.Font.Shadow.Visible = False
        ' 
        ' tChart1.SubFooter.Shadow
        ' 
        Me.tChart1.SubFooter.Shadow.Visible = False
        ' 
        ' tChart1.SubHeader
        ' 
        ' 
        ' tChart1.SubHeader.Font
        ' 
        ' 
        ' tChart1.SubHeader.Font.Shadow
        ' 
        Me.tChart1.SubHeader.Font.Shadow.Visible = False
        ' 
        ' tChart1.SubHeader.Shadow
        ' 
        Me.tChart1.SubHeader.Shadow.Visible = False
        ' 
        ' tChart1.Walls
        ' 
        ' 
        ' tChart1.Walls.Back
        ' 
        Me.tChart1.Walls.Back.AutoHide = False
        ' 
        ' tChart1.Walls.Back.Shadow
        ' 
        Me.tChart1.Walls.Back.Shadow.Visible = False
        ' 
        ' tChart1.Walls.Bottom
        ' 
        Me.tChart1.Walls.Bottom.AutoHide = False
        ' 
        ' tChart1.Walls.Bottom.Shadow
        ' 
        Me.tChart1.Walls.Bottom.Shadow.Visible = False
        ' 
        ' tChart1.Walls.Left
        ' 
        Me.tChart1.Walls.Left.AutoHide = False
        ' 
        ' tChart1.Walls.Left.Shadow
        ' 
        Me.tChart1.Walls.Left.Shadow.Visible = False
        ' 
        ' tChart1.Walls.Right
        ' 
        Me.tChart1.Walls.Right.AutoHide = False
        ' 
        ' tChart1.Walls.Right.Shadow
        ' 
        Me.tChart1.Walls.Right.Shadow.Visible = False
        ' 
        ' polar1
        ' 
        ' 
        ' polar1.Brush
        ' 
        Me.polar1.Brush.Color = System.Drawing.Color.Red
        Me.polar1.Brush.Visible = False
        ' 
        ' polar1.CircleGradient
        ' 
        Me.polar1.CircleGradient.EndColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(224, System.Byte), CType(224, System.Byte), CType(224, System.Byte))
        Me.polar1.CircleGradient.MiddleColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.polar1.CircleGradient.StartColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(64, System.Byte), CType(64, System.Byte), CType(64, System.Byte))
        Me.polar1.CircleGradient.UseMiddle = True
        ' 
        ' polar1.CircleLabelsFont
        ' 
        ' 
        ' polar1.CircleLabelsFont.Shadow
        ' 
        Me.polar1.CircleLabelsFont.Shadow.Visible = False
        ' 
        ' polar1.Font
        ' 
        ' 
        ' polar1.Font.Shadow
        ' 
        Me.polar1.Font.Shadow.Visible = False
        ' 
        ' polar1.Marks
        ' 
        ' 
        ' polar1.Marks.Callout
        ' 
        Me.polar1.Marks.Callout.Arrow = Me.polar1.Marks.Arrow
        Me.polar1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None
        Me.polar1.Marks.Callout.ArrowHeadSize = 8
        ' 
        ' polar1.Marks.Callout.Brush
        ' 
        Me.polar1.Marks.Callout.Brush.Color = System.Drawing.Color.Black
        Me.polar1.Marks.Callout.Distance = 0
        Me.polar1.Marks.Callout.Draw3D = False
        Me.polar1.Marks.Callout.Length = 10
        Me.polar1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        ' 
        ' polar1.Marks.Font
        ' 
        ' 
        ' polar1.Marks.Font.Shadow
        ' 
        Me.polar1.Marks.Font.Shadow.Visible = False
        ' 
        ' polar1.Pen
        ' 
        Me.polar1.Pen.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        ' 
        ' polar1.Pointer
        ' 
        ' 
        ' polar1.Pointer.Brush
        ' 
        Me.polar1.Pointer.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(0, System.Byte), CType(255, System.Byte))
        Me.polar1.Pointer.HorizSize = 2
        Me.polar1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.polar1.Pointer.VertSize = 2
        Me.polar1.Pointer.Visible = True
        Me.polar1.Title = "Original"
        ' 
        ' polar1.XValues
        ' 
        Me.polar1.XValues.DataMember = "Angle"
        Me.polar1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' polar1.YValues
        ' 
        Me.polar1.YValues.DataMember = "Y"
        ' 
        ' checkBox1
        ' 
        Me.checkBox1.Checked = True
        Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox1.Location = New System.Drawing.Point(16, 8)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(136, 24)
        Me.checkBox1.TabIndex = 0
        Me.checkBox1.Text = "Show &Original Polar"
        AddHandler Me.checkBox1.CheckedChanged, AddressOf Me.checkBox1_CheckedChanged
        ' 
        ' polar2
        ' 
        ' 
        ' polar2.Brush
        ' 
        Me.polar2.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(0, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.polar2.Brush.Image = CType(Resources.GetObject("polar2.Brush.Image"), System.Drawing.Image)
        Me.polar2.Brush.ImageMode = Steema.TeeChart.Drawing.ImageMode.Tile
        Me.polar2.Brush.Solid = False
        Me.polar2.Brush.Style = System.Drawing.Drawing2D.HatchStyle.LargeCheckerBoard
        ' 
        ' polar2.CircleGradient
        ' 
        Me.polar2.CircleGradient.EndColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.polar2.CircleGradient.MiddleColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.polar2.CircleGradient.StartColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(192, System.Byte), CType(192, System.Byte), CType(192, System.Byte))
        Me.polar2.CircleGradient.Visible = True
        ' 
        ' polar2.CircleLabelsFont
        ' 
        ' 
        ' polar2.CircleLabelsFont.Shadow
        ' 
        Me.polar2.CircleLabelsFont.Shadow.Visible = False
        Me.polar2.DataSource = Me.polar1
        ' 
        ' polar2.Font
        ' 
        ' 
        ' polar2.Font.Shadow
        ' 
        Me.polar2.Font.Shadow.Visible = False
        Me.polar2.Function = Me.smoothing1
        ' 
        ' polar2.Marks
        ' 
        ' 
        ' polar2.Marks.Callout
        ' 
        Me.polar2.Marks.Callout.Arrow = Me.polar2.Marks.Arrow
        Me.polar2.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None
        Me.polar2.Marks.Callout.ArrowHeadSize = 8
        ' 
        ' polar2.Marks.Callout.Brush
        ' 
        Me.polar2.Marks.Callout.Brush.Color = System.Drawing.Color.Black
        Me.polar2.Marks.Callout.Distance = 0
        Me.polar2.Marks.Callout.Draw3D = False
        Me.polar2.Marks.Callout.Length = 10
        Me.polar2.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        ' 
        ' polar2.Marks.Font
        ' 
        ' 
        ' polar2.Marks.Font.Shadow
        ' 
        Me.polar2.Marks.Font.Shadow.Visible = False
        ' 
        ' polar2.Pen
        ' 
        Me.polar2.Pen.Color = System.Drawing.Color.Green
        Me.polar2.Pen.Width = 2
        ' 
        ' polar2.Pointer
        ' 
        ' 
        ' polar2.Pointer.Brush
        ' 
        Me.polar2.Pointer.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(0, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        Me.polar2.Pointer.HorizSize = 3
        Me.polar2.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Circle
        Me.polar2.Pointer.VertSize = 3
        Me.polar2.Pointer.Visible = True
        Me.polar2.Title = "Smooth"
        ' 
        ' polar2.XValues
        ' 
        Me.polar2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' smoothing1
        ' 
        Me.smoothing1.Period = 1
        ' 
        ' checkBox2
        ' 
        Me.checkBox2.Checked = True
        Me.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox2.Location = New System.Drawing.Point(16, 32)
        Me.checkBox2.Name = "checkBox2"
        Me.checkBox2.Size = New System.Drawing.Size(136, 24)
        Me.checkBox2.TabIndex = 1
        Me.checkBox2.Text = "Show &Smooth Polar"
        AddHandler Me.checkBox2.CheckedChanged, AddressOf Me.checkBox2_CheckedChanged
        ' 
        ' groupBox1
        ' 
        Me.groupBox1.Controls.Add(Me.checkBox3)
        Me.groupBox1.Location = New System.Drawing.Point(168, 8)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(144, 48)
        Me.groupBox1.TabIndex = 2
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Smoothing options"
        ' 
        ' checkBox3
        ' 
        Me.checkBox3.Checked = True
        Me.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox3.Location = New System.Drawing.Point(8, 16)
        Me.checkBox3.Name = "checkBox3"
        Me.checkBox3.Size = New System.Drawing.Size(120, 24)
        Me.checkBox3.TabIndex = 1
        Me.checkBox3.Text = "&Interpolate"
        AddHandler Me.checkBox3.CheckedChanged, AddressOf Me.checkBox3_CheckedChanged
        ' 
        ' Polar_Smooth
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(440, 317)
        Me.Name = "Polar_Smooth"
        Me.panel1.ResumeLayout(False)
        Me.groupBox1.ResumeLayout(False)
    End Sub
#End Region


    Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        polar1.Visible = checkBox1.Checked
    End Sub 'checkBox1_CheckedChanged


    Private Sub checkBox2_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        polar2.Visible = checkBox2.Checked
    End Sub 'checkBox2_CheckedChanged


    Private Sub checkBox3_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        smoothing1.Interpolate = checkBox3.Checked
    End Sub 'checkBox3_CheckedChanged
End Class 'Polar_Smooth