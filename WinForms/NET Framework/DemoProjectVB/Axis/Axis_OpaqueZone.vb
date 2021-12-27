
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

Public Class Axis_OpaqueZone
    Inherits Steema.TeeChart.Samples.BaseForm
    Private axis1 As Steema.TeeChart.Axis
    Private axis2 As Steema.TeeChart.Axis
    Private axis3 As Steema.TeeChart.Axis
    Private WithEvents lineSeries1 As Steema.TeeChart.Styles.Line
    Private WithEvents lineSeries2 As Steema.TeeChart.Styles.Line
    Private WithEvents lineSeries3 As Steema.TeeChart.Styles.Line
    Private WithEvents lineSeries4 As Steema.TeeChart.Styles.Line
    Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
    Private label1 As System.Windows.Forms.Label
    Private WithEvents hScrollBar1 As System.Windows.Forms.HScrollBar
    Private components As System.ComponentModel.IContainer = Nothing

    Private Sub DoScroll(s As Steema.TeeChart.Styles.Series)
        Dim tmp As Double = (0.01 * ((CType(hScrollBar1.Value, Integer) - 50) * (s.YValues.Maximum - s.YValues.Minimum)))
        s.GetVertAxis.SetMinMax((s.YValues.Maximum + tmp), (s.YValues.Minimum + tmp))
    End Sub 'DoScroll
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        hScrollBar1.Value = 50
        ' Fill random values
        For Each s As TeeChart.Styles.Series In tChart1.Series
            s.FillSampleValues(20)
        Next s
        ' Set custom axes
        lineSeries1.VertAxis = TeeChart.Styles.VerticalAxis.Left
        lineSeries2.CustomVertAxis = axis1
        lineSeries3.CustomVertAxis = axis2
        lineSeries4.CustomVertAxis = axis3

        ' Disable automatic clipping
        tChart1.Aspect.ClipPoints = False

        ' Apply palette
        Steema.TeeChart.Themes.ColorPalettes.ApplyPalette(tChart1.Chart, 3)
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
        Me.components = New System.ComponentModel.Container
        Me.axis1 = New Steema.TeeChart.Axis(Me.tChart1.Chart)
        Me.axis2 = New Steema.TeeChart.Axis(Me.tChart1.Chart)
        Me.axis3 = New Steema.TeeChart.Axis(Me.tChart1.Chart)
        Me.lineSeries1 = New Steema.TeeChart.Styles.Line
        Me.lineSeries2 = New Steema.TeeChart.Styles.Line
        Me.lineSeries3 = New Steema.TeeChart.Styles.Line
        Me.lineSeries4 = New Steema.TeeChart.Styles.Line
        Me.checkBox1 = New System.Windows.Forms.CheckBox
        Me.label1 = New System.Windows.Forms.Label
        Me.hScrollBar1 = New System.Windows.Forms.HScrollBar
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.BackColor = System.Drawing.Color.AliceBlue
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(504, 68)
        Me.textBox1.Text = ("When using multiple axes and doing zoom or scroll, series points can display outside the axes \""zones\"" or limits." & vbCrLf & "You can prevent this with a small code at Serie" & "s events: BeforeDrawValues and AfterDrawValues.")
        ' 
        ' panel1
        ' 
        Me.panel1.BackColor = System.Drawing.SystemColors.Control
        Me.panel1.Controls.Add(Me.hScrollBar1)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Controls.Add(Me.checkBox1)
        Me.panel1.Location = New System.Drawing.Point(0, 68)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(504, 36)
        ' 
        ' tChart1
        ' 
        ' 
        ' tChart1.Aspect
        ' 
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
        Me.tChart1.Axes.Bottom.AxisPen.Color = System.Drawing.Color.FromArgb(CType(254, Byte), CType(128, Byte), CType(128, Byte), CType(128, Byte))
        Me.tChart1.Axes.Bottom.AxisPen.Width = 1
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
        Me.tChart1.Axes.Custom.Add(Me.axis1)
        Me.tChart1.Axes.Custom.Add(Me.axis2)
        Me.tChart1.Axes.Custom.Add(Me.axis3)
        ' 
        ' tChart1.Axes.Depth
        ' 
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
        ' tChart1.Axes.Left.AxisPen
        ' 
        Me.tChart1.Axes.Left.AxisPen.Color = System.Drawing.Color.FromArgb(CType(255, Byte), CType(0, Byte), CType(0, Byte))
        Me.tChart1.Axes.Left.EndPosition = 25
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
        Me.tChart1.Axes.Left.LogarithmicBase = 2
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
        Me.tChart1.Header.Lines = New String() {"Opaque Zone"}
        ' 
        ' tChart1.Header.Shadow
        ' 
        Me.tChart1.Header.Shadow.Visible = False
        ' 
        ' tChart1.Legend
        ' 
        Me.tChart1.Legend.Alignment = Steema.TeeChart.LegendAlignments.Bottom
        Me.tChart1.Legend.BorderRound = 8
        ' 
        ' tChart1.Legend.Font
        ' 
        ' 
        ' tChart1.Legend.Font.Shadow
        ' 
        Me.tChart1.Legend.Font.Shadow.Visible = False
        ' 
        ' tChart1.Legend.Shadow
        ' 
        Me.tChart1.Legend.Shadow.Visible = False
        Me.tChart1.Legend.ShapeStyle = Steema.TeeChart.Drawing.TextShapeStyle.RoundRectangle
        ' 
        ' tChart1.Legend.Symbol
        ' 
        Me.tChart1.Legend.Symbol.Visible = False
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
        Me.tChart1.Location = New System.Drawing.Point(0, 104)
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
        ' 
        ' tChart1.Panel.Shadow
        ' 
        Me.tChart1.Panel.Shadow.Visible = False
        Me.tChart1.Series.Add(Me.lineSeries1)
        Me.tChart1.Series.Add(Me.lineSeries2)
        Me.tChart1.Series.Add(Me.lineSeries3)
        Me.tChart1.Series.Add(Me.lineSeries4)
        Me.tChart1.Size = New System.Drawing.Size(504, 301)
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
        Me.tChart1.Walls.Back.Pen.Visible = False
        ' 
        ' tChart1.Walls.Back.Shadow
        ' 
        Me.tChart1.Walls.Back.Shadow.Visible = False
        Me.tChart1.Walls.Back.Transparent = False
        ' 
        ' tChart1.Walls.Bottom
        ' 
        ' 
        ' tChart1.Walls.Bottom.Shadow
        ' 
        Me.tChart1.Walls.Bottom.Shadow.Visible = False
        ' 
        ' tChart1.Walls.Left
        ' 
        ' 
        ' tChart1.Walls.Left.Shadow
        ' 
        Me.tChart1.Walls.Left.Shadow.Visible = False
        ' 
        ' tChart1.Walls.Right
        ' 
        ' 
        ' tChart1.Walls.Right.Shadow
        ' 
        Me.tChart1.Walls.Right.Shadow.Visible = False
        AddHandler tChart1.MouseDown, AddressOf Me.tChart1_MouseDown
        AddHandler tChart1.MouseUp, AddressOf Me.tChart1_MouseUp
        AddHandler tChart1.Zoomed, AddressOf Me.tChart1_Zoomed
        AddHandler tChart1.UndoneZoom, AddressOf Me.tChart1_UndoneZoom
        ' 
        ' axis1
        ' 
        ' 
        ' axis1.AxisPen
        ' 
        Me.axis1.AxisPen.Color = System.Drawing.Color.FromArgb(CType(0, Byte), CType(192, Byte), CType(0, Byte))
        Me.axis1.EndPosition = 50
        Me.axis1.Horizontal = False
        ' 
        ' axis1.Labels
        ' 
        ' 
        ' axis1.Labels.Font
        ' 
        ' 
        ' axis1.Labels.Font.Shadow
        ' 
        Me.axis1.Labels.Font.Shadow.Visible = False
        ' 
        ' axis1.Labels.Shadow
        ' 
        Me.axis1.Labels.Shadow.Visible = False
        Me.axis1.OtherSide = False
        Me.axis1.StartPosition = 25
        ' 
        ' axis1.Title
        ' 
        ' 
        ' axis1.Title.Font
        ' 
        ' 
        ' axis1.Title.Font.Shadow
        ' 
        Me.axis1.Title.Font.Shadow.Visible = False
        ' 
        ' axis1.Title.Shadow
        ' 
        Me.axis1.Title.Shadow.Visible = False
        ' 
        ' axis2
        ' 
        ' 
        ' axis2.AxisPen
        ' 
        Me.axis2.AxisPen.Color = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(0, Byte))
        Me.axis2.EndPosition = 75
        Me.axis2.Horizontal = False
        ' 
        ' axis2.Labels
        ' 
        ' 
        ' axis2.Labels.Font
        ' 
        ' 
        ' axis2.Labels.Font.Shadow
        ' 
        Me.axis2.Labels.Font.Shadow.Visible = False
        ' 
        ' axis2.Labels.Shadow
        ' 
        Me.axis2.Labels.Shadow.Visible = False
        Me.axis2.OtherSide = False
        Me.axis2.StartPosition = 50
        ' 
        ' axis2.Title
        ' 
        ' 
        ' axis2.Title.Font
        ' 
        ' 
        ' axis2.Title.Font.Shadow
        ' 
        Me.axis2.Title.Font.Shadow.Visible = False
        ' 
        ' axis2.Title.Shadow
        ' 
        Me.axis2.Title.Shadow.Visible = False
        ' 
        ' axis3
        ' 
        ' 
        ' axis3.AxisPen
        ' 
        Me.axis3.AxisPen.Color = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(255, Byte))
        Me.axis3.Horizontal = False
        ' 
        ' axis3.Labels
        ' 
        ' 
        ' axis3.Labels.Font
        ' 
        ' 
        ' axis3.Labels.Font.Shadow
        ' 
        Me.axis3.Labels.Font.Shadow.Visible = False
        ' 
        ' axis3.Labels.Shadow
        ' 
        Me.axis3.Labels.Shadow.Visible = False
        Me.axis3.OtherSide = False
        Me.axis3.StartPosition = 75
        ' 
        ' axis3.Title
        ' 
        ' 
        ' axis3.Title.Font
        ' 
        ' 
        ' axis3.Title.Font.Shadow
        ' 
        Me.axis3.Title.Font.Shadow.Visible = False
        ' 
        ' axis3.Title.Shadow
        ' 
        Me.axis3.Title.Shadow.Visible = False
        ' 
        ' lineSeries1
        ' 
        ' 
        ' lineSeries1.Brush
        ' 
        Me.lineSeries1.Brush.Color = System.Drawing.Color.Red
        Me.lineSeries1.Cursor = System.Windows.Forms.Cursors.Cross
        ' 
        ' lineSeries1.Marks
        ' 
        ' 
        ' lineSeries1.Marks.Callout
        ' 
        Me.lineSeries1.Marks.Callout.Arrow = Me.lineSeries1.Marks.Arrow
        Me.lineSeries1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None
        Me.lineSeries1.Marks.Callout.ArrowHeadSize = 8
        ' 
        ' lineSeries1.Marks.Callout.Brush
        ' 
        Me.lineSeries1.Marks.Callout.Brush.Color = System.Drawing.Color.Black
        Me.lineSeries1.Marks.Callout.Distance = 0
        Me.lineSeries1.Marks.Callout.Draw3D = False
        Me.lineSeries1.Marks.Callout.Length = 10
        Me.lineSeries1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        ' 
        ' lineSeries1.Marks.Font
        ' 
        ' 
        ' lineSeries1.Marks.Font.Shadow
        ' 
        Me.lineSeries1.Marks.Font.Shadow.Visible = False
        ' 
        ' lineSeries1.Pointer
        ' 
        Me.lineSeries1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.lineSeries1.Title = "lineSeries1"
        ' 
        ' lineSeries1.XValues
        ' 
        Me.lineSeries1.XValues.DataMember = "X"
        Me.lineSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' lineSeries1.YValues
        ' 
        Me.lineSeries1.YValues.DataMember = "Y"
        AddHandler lineSeries1.BeforeDrawValues, AddressOf Me.lineSeries1_BeforeDrawValues
        AddHandler lineSeries1.AfterDrawValues, AddressOf Me.lineSeries1_AfterDrawValues
        ' 
        ' lineSeries2
        ' 
        ' 
        ' lineSeries2.Brush
        ' 
        Me.lineSeries2.Brush.Color = System.Drawing.Color.Green
        Me.lineSeries2.Cursor = System.Windows.Forms.Cursors.Cross
        ' 
        ' lineSeries2.Marks
        ' 
        ' 
        ' lineSeries2.Marks.Callout
        ' 
        Me.lineSeries2.Marks.Callout.Arrow = Me.lineSeries2.Marks.Arrow
        Me.lineSeries2.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None
        Me.lineSeries2.Marks.Callout.ArrowHeadSize = 8
        ' 
        ' lineSeries2.Marks.Callout.Brush
        ' 
        Me.lineSeries2.Marks.Callout.Brush.Color = System.Drawing.Color.Black
        Me.lineSeries2.Marks.Callout.Distance = 0
        Me.lineSeries2.Marks.Callout.Draw3D = False
        Me.lineSeries2.Marks.Callout.Length = 10
        Me.lineSeries2.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        ' 
        ' lineSeries2.Marks.Font
        ' 
        ' 
        ' lineSeries2.Marks.Font.Shadow
        ' 
        Me.lineSeries2.Marks.Font.Shadow.Visible = False
        ' 
        ' lineSeries2.Pointer
        ' 
        Me.lineSeries2.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.lineSeries2.Title = "lineSeries2"
        ' 
        ' lineSeries2.XValues
        ' 
        Me.lineSeries2.XValues.DataMember = "X"
        Me.lineSeries2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' lineSeries2.YValues
        ' 
        Me.lineSeries2.YValues.DataMember = "Y"
        AddHandler lineSeries2.BeforeDrawValues, AddressOf Me.lineSeries1_BeforeDrawValues
        AddHandler lineSeries2.AfterDrawValues, AddressOf Me.lineSeries1_AfterDrawValues
        ' 
        ' lineSeries3
        ' 
        ' 
        ' lineSeries3.Brush
        ' 
        Me.lineSeries3.Brush.Color = System.Drawing.Color.Yellow
        Me.lineSeries3.Cursor = System.Windows.Forms.Cursors.Cross
        ' 
        ' lineSeries3.Marks
        ' 
        ' 
        ' lineSeries3.Marks.Callout
        ' 
        Me.lineSeries3.Marks.Callout.Arrow = Me.lineSeries3.Marks.Arrow
        Me.lineSeries3.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None
        Me.lineSeries3.Marks.Callout.ArrowHeadSize = 8
        ' 
        ' lineSeries3.Marks.Callout.Brush
        ' 
        Me.lineSeries3.Marks.Callout.Brush.Color = System.Drawing.Color.Black
        Me.lineSeries3.Marks.Callout.Distance = 0
        Me.lineSeries3.Marks.Callout.Draw3D = False
        Me.lineSeries3.Marks.Callout.Length = 10
        Me.lineSeries3.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        ' 
        ' lineSeries3.Marks.Font
        ' 
        ' 
        ' lineSeries3.Marks.Font.Shadow
        ' 
        Me.lineSeries3.Marks.Font.Shadow.Visible = False
        ' 
        ' lineSeries3.Pointer
        ' 
        Me.lineSeries3.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.lineSeries3.Title = "lineSeries3"
        ' 
        ' lineSeries3.XValues
        ' 
        Me.lineSeries3.XValues.DataMember = "X"
        Me.lineSeries3.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' lineSeries3.YValues
        ' 
        Me.lineSeries3.YValues.DataMember = "Y"
        AddHandler lineSeries3.BeforeDrawValues, AddressOf Me.lineSeries1_BeforeDrawValues
        AddHandler lineSeries3.AfterDrawValues, AddressOf Me.lineSeries1_AfterDrawValues
        ' 
        ' lineSeries4
        ' 
        ' 
        ' lineSeries4.Brush
        ' 
        Me.lineSeries4.Brush.Color = System.Drawing.Color.Blue
        Me.lineSeries4.Cursor = System.Windows.Forms.Cursors.Cross
        ' 
        ' lineSeries4.Marks
        ' 
        ' 
        ' lineSeries4.Marks.Callout
        ' 
        Me.lineSeries4.Marks.Callout.Arrow = Me.lineSeries4.Marks.Arrow
        Me.lineSeries4.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None
        Me.lineSeries4.Marks.Callout.ArrowHeadSize = 8
        ' 
        ' lineSeries4.Marks.Callout.Brush
        ' 
        Me.lineSeries4.Marks.Callout.Brush.Color = System.Drawing.Color.Black
        Me.lineSeries4.Marks.Callout.Distance = 0
        Me.lineSeries4.Marks.Callout.Draw3D = False
        Me.lineSeries4.Marks.Callout.Length = 10
        Me.lineSeries4.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        ' 
        ' lineSeries4.Marks.Font
        ' 
        ' 
        ' lineSeries4.Marks.Font.Shadow
        ' 
        Me.lineSeries4.Marks.Font.Shadow.Visible = False
        ' 
        ' lineSeries4.Pointer
        ' 
        Me.lineSeries4.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.lineSeries4.Title = "lineSeries4"
        ' 
        ' lineSeries4.XValues
        ' 
        Me.lineSeries4.XValues.DataMember = "X"
        Me.lineSeries4.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' lineSeries4.YValues
        ' 
        Me.lineSeries4.YValues.DataMember = "Y"
        AddHandler lineSeries4.BeforeDrawValues, AddressOf Me.lineSeries1_BeforeDrawValues
        AddHandler lineSeries4.AfterDrawValues, AddressOf Me.lineSeries1_AfterDrawValues
        ' 
        ' checkBox1
        ' 
        Me.checkBox1.Checked = True
        Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox1.Location = New System.Drawing.Point(16, 8)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(112, 20)
        Me.checkBox1.TabIndex = 0
        Me.checkBox1.Text = "&Opaque zones"
        AddHandler checkBox1.CheckedChanged, AddressOf Me.checkBox1_CheckedChanged
        ' 
        ' label1
        ' 
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(128, 12)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(36, 16)
        Me.label1.TabIndex = 1
        Me.label1.Text = "&Scroll:"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        ' 
        ' hScrollBar1
        ' 
        Me.hScrollBar1.Location = New System.Drawing.Point(168, 8)
        Me.hScrollBar1.Name = "hScrollBar1"
        Me.hScrollBar1.Size = New System.Drawing.Size(123, 18)
        Me.hScrollBar1.TabIndex = 2
        AddHandler hScrollBar1.Scroll, AddressOf Me.hScrollBar1_Scroll
        ' 
        ' Axis_OpaqueZone
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(504, 405)
        Me.Name = "Axis_OpaqueZone"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub 'InitializeComponent 
#End Region

    Private Sub hScrollBar1_Scroll(ByVal sender As Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles hScrollBar1.Scroll
        DoScroll(lineSeries1)
        DoScroll(lineSeries2)
        DoScroll(lineSeries3)
        DoScroll(lineSeries4)
    End Sub 'hScrollBar1_Scroll

    Private Sub lineSeries1_BeforeDrawValues(ByVal sender As Object, ByVal g As Steema.TeeChart.Drawing.Graphics3D) Handles lineSeries1.BeforeDrawValues, lineSeries2.BeforeDrawValues, lineSeries3.BeforeDrawValues, lineSeries4.BeforeDrawValues
        '  make opaque
        If checkBox1.Checked Then
            Dim s As Steema.TeeChart.Styles.Series = CType(sender, Steema.TeeChart.Styles.Series)
            Dim left As Integer = s.GetHorizAxis.IStartPos
            Dim right As Integer = s.GetHorizAxis.IEndPos
            Dim top As Integer = s.GetVertAxis.IStartPos
            Dim bottom As Integer = s.GetVertAxis.IEndPos
            tChart1.Graphics3D.ClipRectangle(left, top, right, bottom)
        End If
    End Sub 'lineSeries1_BeforeDrawValues

    Private Sub lineSeries1_AfterDrawValues(ByVal sender As Object, ByVal g As Steema.TeeChart.Drawing.Graphics3D) Handles lineSeries1.AfterDrawValues, lineSeries2.AfterDrawValues, lineSeries3.AfterDrawValues, lineSeries4.AfterDrawValues
        If checkBox1.Checked Then
            tChart1.Graphics3D.ClearClipRegions()
        End If
    End Sub 'lineSeries1_AfterDrawValues

    Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox1.CheckedChanged
        tChart1.Invalidate()
    End Sub 'checkBox1_CheckedChanged

    Private zoomed As Boolean = False

    Private Sub tChart1_Zoomed(ByVal sender As Object, ByVal e As System.EventArgs) Handles tChart1.Zoomed
        zoomed = True
    End Sub

    Private MouseXDown As Integer
    Private MouseYDown As Integer
    Private MouseXUp As Integer
    Private MouseYUp As Integer


    Private Sub tChart1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tChart1.MouseDown
        MouseXDown = e.X
        MouseYDown = e.Y
    End Sub 'tChart1_MouseDown


    Private Sub tChart1_UndoneZoom(ByVal sender As Object, ByVal e As System.EventArgs) Handles tChart1.UndoneZoom
        zoomed = False
        lineSeries2.CustomVertAxis.Automatic = True
        lineSeries3.CustomVertAxis.Automatic = True
        lineSeries4.CustomVertAxis.Automatic = True
    End Sub 'tChart1_UndoneZoom

    Private Sub tChart1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tChart1.MouseUp
        If zoomed Then
            MouseXUp = e.X
            MouseYUp = e.Y

            Dim max As Double = lineSeries2.YScreenToValue(MouseYDown)
            Dim min As Double = lineSeries2.YScreenToValue(MouseYUp)
            lineSeries2.CustomVertAxis.SetMinMax(min, max)

            max = lineSeries3.YScreenToValue(MouseYDown)
            min = lineSeries3.YScreenToValue(MouseYUp)
            lineSeries3.CustomVertAxis.SetMinMax(min, max)

            max = lineSeries4.YScreenToValue(MouseYDown)
            min = lineSeries4.YScreenToValue(MouseYUp)
            lineSeries4.CustomVertAxis.SetMinMax(min, max)
        End If
    End Sub 'tChart1_MouseUp
End Class 'Axis_OpaqueZone
