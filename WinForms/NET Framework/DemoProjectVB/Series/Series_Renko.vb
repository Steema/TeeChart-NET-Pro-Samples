
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing

Imports System.Windows.Forms



Public Class Series_Renko
    Inherits Samples.BaseForm

    Private candle1 As Steema.TeeChart.Styles.Candle
    Private renko1 As Steema.TeeChart.Styles.Renko
    Private label1 As Label
    Private buttonColor2 As ButtonColor
    Private buttonColor1 As ButtonColor
    Private numericUpDown1 As NumericUpDown

    '/ <summary>
    '/ Required designer variable.
    '/ </summary>
    Private components As System.ComponentModel.IContainer = Nothing


    Public Sub New() ' This call is required by the Windows Form Designer.
        InitializeComponent()
        candle1.FillSampleValues(20)

        ' populate renko with closing values
        renko1.Clear()
        Dim i As Integer = 0
        Do While (i < candle1.Count)
            renko1.Add(candle1.CloseValues(i))
            i = (i + 1)
        Loop

        ' box size set to 2
        renko1.BoxSize = 5

        ' link buttons to colors
        buttonColor1.Color = renko1.UpSwingColor
        buttonColor2.Color = renko1.DownSwingColor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Series_Renko))
        Me.candle1 = New Steema.TeeChart.Styles.Candle
        Me.renko1 = New Steema.TeeChart.Styles.Renko
        Me.buttonColor1 = New Steema.TeeChart.ButtonColor
        Me.buttonColor2 = New Steema.TeeChart.ButtonColor
        Me.label1 = New System.Windows.Forms.Label
        Me.numericUpDown1 = New System.Windows.Forms.NumericUpDown
        Me.panel1.SuspendLayout()
        CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Text = resources.GetString("textBox1.Text")
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.numericUpDown1)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Controls.Add(Me.buttonColor2)
        Me.panel1.Controls.Add(Me.buttonColor1)
        Me.panel1.Size = New System.Drawing.Size(440, 69)
        ' 
        ' tChart1
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Aspect.ColorPaletteIndex = 5
        Me.tChart1.Aspect.ElevationFloat = 345
        Me.tChart1.Aspect.RotationFloat = 345
        Me.tChart1.Aspect.View3D = False
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
        Me.tChart1.Axes.Bottom.Labels.DateTimeFormat = "d.M.yyyy"
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Bottom.Labels.Font.Shadow.Visible = False
        Me.tChart1.Axes.Bottom.Labels.Font.Unit = System.Drawing.GraphicsUnit.World
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Bottom.Labels.Shadow.Visible = False
        Me.tChart1.Axes.Bottom.RelativePosition = 50
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Bottom.Title.Font.Shadow.Visible = False
        Me.tChart1.Axes.Bottom.Title.Font.Unit = System.Drawing.GraphicsUnit.World
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Bottom.Title.Shadow.Visible = False
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
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Depth.Labels.Font.Shadow.Visible = False
        Me.tChart1.Axes.Depth.Labels.Font.Unit = System.Drawing.GraphicsUnit.World
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Depth.Labels.Shadow.Visible = False
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Depth.Title.Font.Shadow.Visible = False
        Me.tChart1.Axes.Depth.Title.Font.Unit = System.Drawing.GraphicsUnit.World
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Depth.Title.Shadow.Visible = False
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
        ' 
        ' 
        ' 
        Me.tChart1.Axes.DepthTop.Labels.Font.Shadow.Visible = False
        Me.tChart1.Axes.DepthTop.Labels.Font.Unit = System.Drawing.GraphicsUnit.World
        ' 
        ' 
        ' 
        Me.tChart1.Axes.DepthTop.Labels.Shadow.Visible = False
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.DepthTop.Title.Font.Shadow.Visible = False
        Me.tChart1.Axes.DepthTop.Title.Font.Unit = System.Drawing.GraphicsUnit.World
        ' 
        ' 
        ' 
        Me.tChart1.Axes.DepthTop.Title.Shadow.Visible = False
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Left.Automatic = True
        Me.tChart1.Axes.Left.EndPosition = 50
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
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Left.Labels.Font.Shadow.Visible = False
        Me.tChart1.Axes.Left.Labels.Font.Unit = System.Drawing.GraphicsUnit.World
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Left.Labels.Shadow.Visible = False
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Left.Title.Font.Shadow.Visible = False
        Me.tChart1.Axes.Left.Title.Font.Unit = System.Drawing.GraphicsUnit.World
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Left.Title.Shadow.Visible = False
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
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Right.Labels.Font.Shadow.Visible = False
        Me.tChart1.Axes.Right.Labels.Font.Unit = System.Drawing.GraphicsUnit.World
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Right.Labels.Shadow.Visible = False
        Me.tChart1.Axes.Right.StartPosition = 50
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Right.Title.Font.Shadow.Visible = False
        Me.tChart1.Axes.Right.Title.Font.Unit = System.Drawing.GraphicsUnit.World
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Right.Title.Shadow.Visible = False
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
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Top.Labels.Font.Shadow.Visible = False
        Me.tChart1.Axes.Top.Labels.Font.Unit = System.Drawing.GraphicsUnit.World
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Top.Labels.Shadow.Visible = False
        Me.tChart1.Axes.Top.Labels.Visible = False
        Me.tChart1.Axes.Top.RelativePosition = 100
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Top.Title.Font.Shadow.Visible = False
        Me.tChart1.Axes.Top.Title.Font.Unit = System.Drawing.GraphicsUnit.World
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Top.Title.Shadow.Visible = False
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Footer.Font.Shadow.Visible = False
        Me.tChart1.Footer.Font.Unit = System.Drawing.GraphicsUnit.World
        ' 
        ' 
        ' 
        Me.tChart1.Footer.Shadow.Visible = False
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Header.Font.Shadow.Visible = False
        Me.tChart1.Header.Font.Unit = System.Drawing.GraphicsUnit.World
        Me.tChart1.Header.Lines = New String() {"TeeChart"}
        ' 
        ' 
        ' 
        Me.tChart1.Header.Shadow.Visible = False
        Me.tChart1.Header.Visible = False
        ' 
        ' 
        ' 
        Me.tChart1.Legend.Alignment = Steema.TeeChart.LegendAlignments.Bottom
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Legend.Font.Shadow.Visible = False
        Me.tChart1.Legend.Font.Unit = System.Drawing.GraphicsUnit.World
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Legend.Title.Font.Bold = True
        ' 
        ' 
        ' 
        Me.tChart1.Legend.Title.Font.Shadow.Visible = False
        Me.tChart1.Legend.Title.Font.Unit = System.Drawing.GraphicsUnit.World
        ' 
        ' 
        ' 
        Me.tChart1.Legend.Title.Pen.Visible = False
        ' 
        ' 
        ' 
        Me.tChart1.Legend.Title.Shadow.Visible = False
        Me.tChart1.Location = New System.Drawing.Point(0, 142)
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Panel.Shadow.Visible = False
        Me.tChart1.Series.Add(Me.candle1)
        Me.tChart1.Series.Add(Me.renko1)
        Me.tChart1.Size = New System.Drawing.Size(440, 175)
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.SubFooter.Font.Shadow.Visible = False
        Me.tChart1.SubFooter.Font.Unit = System.Drawing.GraphicsUnit.World
        ' 
        ' 
        ' 
        Me.tChart1.SubFooter.Shadow.Visible = False
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.SubHeader.Font.Shadow.Visible = False
        Me.tChart1.SubHeader.Font.Unit = System.Drawing.GraphicsUnit.World
        ' 
        ' 
        ' 
        Me.tChart1.SubHeader.Shadow.Visible = False
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
        Me.tChart1.Walls.Back.Brush.Visible = False
        ' 
        ' 
        ' 
        Me.tChart1.Walls.Back.Shadow.Visible = False
        ' 
        ' 
        ' 
        Me.tChart1.Walls.Bottom.AutoHide = False
        ' 
        ' 
        ' 
        Me.tChart1.Walls.Bottom.Shadow.Visible = False
        ' 
        ' 
        ' 
        Me.tChart1.Walls.Left.AutoHide = False
        ' 
        ' 
        ' 
        Me.tChart1.Walls.Left.Shadow.Visible = False
        ' 
        ' 
        ' 
        Me.tChart1.Walls.Right.AutoHide = False
        ' 
        ' 
        ' 
        Me.tChart1.Walls.Right.Shadow.Visible = False
        ' 
        ' candle1
        ' 
        ' 
        ' 
        ' 
        Me.candle1.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.candle1.CloseValues = Me.candle1.YValues
        Me.candle1.DateValues = Me.candle1.XValues
        ' 
        ' 
        ' 
        Me.candle1.HighLowPen.Color = System.Drawing.Color.Black
        ' 
        ' 
        ' 
        Me.candle1.LinePen.Color = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(161, Byte), Integer))
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.candle1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None
        Me.candle1.Marks.Callout.ArrowHeadSize = 8
        Me.candle1.Marks.Callout.Distance = 0
        Me.candle1.Marks.Callout.Draw3D = False
        Me.candle1.Marks.Callout.Length = 10
        Me.candle1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.candle1.Marks.Font.Shadow.Visible = False
        Me.candle1.Marks.Font.Unit = System.Drawing.GraphicsUnit.World
        ' 
        ' 
        ' 
        Me.candle1.Pointer.Draw3D = False
        Me.candle1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.candle1.Pointer.Visible = True
        Me.candle1.Title = "Trading data"
        ' 
        ' 
        ' 
        Me.candle1.XValues.DataMember = "Date"
        Me.candle1.XValues.DateTime = True
        Me.candle1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' 
        ' 
        Me.candle1.YValues.DataMember = "Close"
        ' 
        ' renko1
        ' 
        ' 
        ' 
        ' 
        Me.renko1.Brush.Color = System.Drawing.Color.White
        Me.renko1.HorizAxis = Steema.TeeChart.Styles.HorizontalAxis.Top
        ' 
        ' 
        ' 
        Me.renko1.LinePen.Color = System.Drawing.Color.White
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.renko1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None
        Me.renko1.Marks.Callout.ArrowHeadSize = 8
        Me.renko1.Marks.Callout.Distance = 0
        Me.renko1.Marks.Callout.Draw3D = False
        Me.renko1.Marks.Callout.Length = 10
        Me.renko1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.renko1.Marks.Font.Shadow.Visible = False
        Me.renko1.Marks.Font.Unit = System.Drawing.GraphicsUnit.World
        ' 
        ' 
        ' 
        Me.renko1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.renko1.Title = "Renko (close values)"
        Me.renko1.VertAxis = Steema.TeeChart.Styles.VerticalAxis.Right
        ' 
        ' 
        ' 
        Me.renko1.XValues.DataMember = "X"
        Me.renko1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' 
        ' 
        Me.renko1.YValues.DataMember = "Y"
        ' 
        ' buttonColor1
        ' 
        Me.buttonColor1.Color = System.Drawing.Color.Empty
        Me.buttonColor1.Location = New System.Drawing.Point(12, 6)
        Me.buttonColor1.Name = "buttonColor1"
        Me.buttonColor1.Size = New System.Drawing.Size(105, 23)
        Me.buttonColor1.TabIndex = 0
        Me.buttonColor1.Text = "Up swing"
#If (VS2005) Then
Me.buttonColor1.UseVisualStyleBackColor = true
#End If
        AddHandler buttonColor1.Click, AddressOf Me.buttonColor1_Click
        ' 
        ' buttonColor2
        ' 
        Me.buttonColor2.Color = System.Drawing.Color.Empty
        Me.buttonColor2.Location = New System.Drawing.Point(12, 35)
        Me.buttonColor2.Name = "buttonColor2"
        Me.buttonColor2.Size = New System.Drawing.Size(105, 23)
        Me.buttonColor2.TabIndex = 1
        Me.buttonColor2.Text = "Down swing"
#If (VS2005) Then
Me.buttonColor2.UseVisualStyleBackColor = true
#End If
        AddHandler buttonColor2.Click, AddressOf Me.buttonColor2_Click
        ' 
        ' label1
        ' 
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(143, 11)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(46, 13)
        Me.label1.TabIndex = 2
        Me.label1.Text = "Box size"
        ' 
        ' numericUpDown1
        ' 
        Me.numericUpDown1.Location = New System.Drawing.Point(195, 9)
        Me.numericUpDown1.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.numericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numericUpDown1.Name = "numericUpDown1"
        Me.numericUpDown1.Size = New System.Drawing.Size(64, 20)
        Me.numericUpDown1.TabIndex = 3
        Me.numericUpDown1.Value = New Decimal(New Integer() {5, 0, 0, 0})
        AddHandler numericUpDown1.ValueChanged, AddressOf Me.numericUpDown1_ValueChanged
        ' 
        ' Series_Renko
        ' 
        Me.ClientSize = New System.Drawing.Size(440, 317)
        Me.Name = "Series_Renko"
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

#End Region

    Private Sub numericUpDown1_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
        renko1.BoxSize = CType(numericUpDown1.Value, Integer)
    End Sub

    Private Sub buttonColor1_Click(ByVal sender As Object, ByVal e As EventArgs)
        renko1.UpSwingColor = buttonColor1.Color
    End Sub

    Private Sub buttonColor2_Click(ByVal sender As Object, ByVal e As EventArgs)
        renko1.DownSwingColor = buttonColor2.Color
    End Sub

End Class

