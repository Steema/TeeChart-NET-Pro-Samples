
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms


Public Class Candle_HighLowPen
    Inherits Samples.BaseForm
    Private candle1 As Steema.TeeChart.Styles.Candle
    Private buttonPen1 As Steema.TeeChart.ButtonPen
    Private buttonPen2 As Steema.TeeChart.ButtonPen
    Private checkBox1 As System.Windows.Forms.CheckBox
    Private components As System.ComponentModel.IContainer = Nothing
    
    Public Sub New() ' This call is required by the Windows Form Designer.
        InitializeComponent()
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
        Me.candle1 = New Steema.TeeChart.Styles.Candle
        Me.buttonPen1 = New Steema.TeeChart.ButtonPen
        Me.buttonPen2 = New Steema.TeeChart.ButtonPen
        Me.checkBox1 = New System.Windows.Forms.CheckBox
        Me.panel1.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(466, 63)
        Me.textBox1.Text = "Financial Candle series provides a ""High Low"" pen to display lines from high to l" + "ow with a different pen than candle border." + vbCr + vbLf + vbCr + vbLf + "candle1.HighLowPen.Color = Color." + "Blue"
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.checkBox1)
        Me.panel1.Controls.Add(Me.buttonPen2)
        Me.panel1.Controls.Add(Me.buttonPen1)
        Me.panel1.Location = New System.Drawing.Point(0, 63)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(466, 34)
        ' 
        ' tChart1
        ' 
        ' 
        ' tChart1.Aspect
        ' 
        Me.tChart1.Aspect.Chart3DPercent = 10
        ' 
        ' tChart1.Axes
        ' 
        ' 
        ' tChart1.Axes.Bottom
        ' 
        ' 
        ' tChart1.Axes.Bottom.Labels
        ' 
        Me.tChart1.Axes.Bottom.Labels.DateTimeFormat = "d.M.yyyy"
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
        Me.tChart1.BackColor = System.Drawing.Color.Transparent
        Me.tChart1.Cursor = System.Windows.Forms.Cursors.Default
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
        Me.tChart1.Header.Lines = New String() {"tChart1"}
        ' 
        ' tChart1.Header.Shadow
        ' 
        Me.tChart1.Header.Shadow.Visible = False
        Me.tChart1.Header.Visible = False
        ' 
        ' tChart1.Legend
        ' 
        Me.tChart1.Legend.Alignment = Steema.TeeChart.LegendAlignments.Top
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
        Me.tChart1.Location = New System.Drawing.Point(0, 97)
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Brush
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(236, System.Byte), CType(233, System.Byte), CType(216, System.Byte))
        ' 
        ' tChart1.Panel.Gradient
        ' 
        Me.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(192, System.Byte))
        Me.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.tChart1.Panel.Brush.Gradient.UseMiddle = True
        Me.tChart1.Panel.Brush.Gradient.Visible = True
        ' 
        ' tChart1.Panel.Gradient
        ' 
        Me.tChart1.Panel.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(192, System.Byte))
        Me.tChart1.Panel.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.tChart1.Panel.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.tChart1.Panel.Gradient.UseMiddle = True
        Me.tChart1.Panel.Gradient.Visible = True
        ' 
        ' tChart1.Panel.Pen
        ' 
        Me.tChart1.Panel.Pen.Visible = True
        Me.tChart1.Panel.Pen.Width = 2
        ' 
        ' tChart1.Panel.Shadow
        ' 
        Me.tChart1.Panel.Shadow.Visible = False
        Me.tChart1.Series.Add(Me.candle1)
        Me.tChart1.Size = New System.Drawing.Size(466, 189)
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
        ' tChart1.Walls.Back.Shadow
        ' 
        Me.tChart1.Walls.Back.Shadow.Visible = False
        ' 
        ' tChart1.Walls.Bottom
        ' 
        ' 
        ' tChart1.Walls.Bottom.Brush
        ' 
        Me.tChart1.Walls.Bottom.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        ' 
        ' tChart1.Walls.Bottom.Shadow
        ' 
        Me.tChart1.Walls.Bottom.Shadow.Visible = False
        ' 
        ' tChart1.Walls.Left
        ' 
        Me.tChart1.Walls.Left.ApplyDark = False
        ' 
        ' tChart1.Walls.Left.Brush
        ' 
        Me.tChart1.Walls.Left.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(192, System.Byte))
        ' 
        ' tChart1.Walls.Left.Shadow
        ' 
        Me.tChart1.Walls.Left.Shadow.Visible = False
        Me.tChart1.Walls.Left.Size = 1
        ' 
        ' tChart1.Walls.Right
        ' 
        ' 
        ' tChart1.Walls.Right.Shadow
        ' 
        Me.tChart1.Walls.Right.Shadow.Visible = False
        ' 
        ' candle1
        ' 
        ' 
        ' candle1.Brush
        ' 
        Me.candle1.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        Me.candle1.CloseValues = Me.candle1.YValues
        Me.candle1.DateValues = Me.candle1.XValues
        Me.candle1.DownCloseColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        ' 
        ' candle1.HighLowPen
        ' 
        Me.candle1.HighLowPen.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(0, System.Byte), CType(0, System.Byte), CType(255, System.Byte))
        Me.candle1.HighLowPen.Width = 2
        ' 
        ' candle1.LinePen
        ' 
        Me.candle1.LinePen.Color = System.Drawing.Color.FromArgb(CType(153, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        ' 
        ' candle1.Marks
        ' 
        ' 
        ' candle1.Marks.Callout
        ' 
        Me.candle1.Marks.Callout.Arrow = Me.candle1.Marks.Arrow
        Me.candle1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None
        Me.candle1.Marks.Callout.ArrowHeadSize = 8
        ' 
        ' candle1.Marks.Callout.Brush
        ' 
        Me.candle1.Marks.Callout.Brush.Color = System.Drawing.Color.Black
        Me.candle1.Marks.Callout.Distance = 0
        Me.candle1.Marks.Callout.Draw3D = False
        Me.candle1.Marks.Callout.Length = 10
        Me.candle1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        ' 
        ' candle1.Marks.Font
        ' 
        ' 
        ' candle1.Marks.Font.Shadow
        ' 
        Me.candle1.Marks.Font.Shadow.Visible = False
        ' 
        ' candle1.Pointer
        ' 
        ' 
        ' candle1.Pointer.Brush
        ' 
        Me.candle1.Pointer.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(0, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        Me.candle1.Pointer.Draw3D = False
        Me.candle1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.candle1.Pointer.Visible = True
        Me.candle1.Title = "candle1"
        Me.candle1.UpCloseColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        ' 
        ' candle1.XValues
        ' 
        Me.candle1.XValues.DataMember = "Date"
        Me.candle1.XValues.DateTime = True
        Me.candle1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' candle1.YValues
        ' 
        Me.candle1.YValues.DataMember = "Close"
        ' 
        ' buttonPen1
        ' 
        Me.buttonPen1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonPen1.Location = New System.Drawing.Point(16, 8)
        Me.buttonPen1.Name = "buttonPen1"
        Me.buttonPen1.Size = New System.Drawing.Size(88, 24)
        Me.buttonPen1.TabIndex = 0
        Me.buttonPen1.Text = "&Border..."
        ' 
        ' buttonPen2
        ' 
        Me.buttonPen2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonPen2.Location = New System.Drawing.Point(120, 8)
        Me.buttonPen2.Name = "buttonPen2"
        Me.buttonPen2.Size = New System.Drawing.Size(112, 24)
        Me.buttonPen2.TabIndex = 1
        Me.buttonPen2.Text = "&High Low..."
        ' 
        ' checkBox1
        ' 
        Me.checkBox1.Location = New System.Drawing.Point(248, 16)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(144, 16)
        Me.checkBox1.TabIndex = 2
        Me.checkBox1.Text = "&Default high low color"
        AddHandler Me.checkBox1.CheckedChanged, AddressOf Me.checkBox1_CheckedChanged
        ' 
        ' Candle_HighLowPen
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(466, 286)
        Me.Name = "Candle_HighLowPen"
        AddHandler Me.Load, AddressOf Me.Candle_HighLowPen_Load
        Me.panel1.ResumeLayout(False)
    End Sub 'New 
#End Region


    Private Sub Candle_HighLowPen_Load(ByVal sender As Object, ByVal e As System.EventArgs)
        buttonPen1.Pen = candle1.Pen
        buttonPen2.Pen = candle1.HighLowPen

        candle1.HighLowPen.Color = Color.Blue
        candle1.HighLowPen.Width = 2

        candle1.CandleWidth = 8
        candle1.FillSampleValues()
    End Sub 'Candle_HighLowPen_Load


    Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        If checkBox1.Checked Then
            candle1.HighLowPen.Color = Color.Empty
        Else
            candle1.HighLowPen.Color = Color.Blue
        End If
        candle1.HighLowPen.Invalidate()
    End Sub 'checkBox1_CheckedChanged
End Class 'Candle_HighLowPen