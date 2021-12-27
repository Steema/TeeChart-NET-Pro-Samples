
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing

Imports System.Windows.Forms



Public Class Kagi
    Inherits Samples.BaseForm
    Private kagi1 As Steema.TeeChart.Styles.Kagi
    Private checkBox1 As CheckBox
    Private checkBox2 As CheckBox
    Private textBox2 As TextBox
    Private label1 As Label
    Private checkBox3 As CheckBox
    Private button1 As Button
    Private components As System.ComponentModel.IContainer = Nothing


    Public Sub New() ' This call is required by the Windows Form Designer.
        InitializeComponent()
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Kagi))
        Me.kagi1 = New Steema.TeeChart.Styles.Kagi
        Me.checkBox1 = New System.Windows.Forms.CheckBox
        Me.checkBox2 = New System.Windows.Forms.CheckBox
        Me.label1 = New System.Windows.Forms.Label
        Me.textBox2 = New System.Windows.Forms.TextBox
        Me.checkBox3 = New System.Windows.Forms.CheckBox
        Me.button1 = New System.Windows.Forms.Button
        Me.panel1.SuspendLayout()
        Me.chartContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'textBox1
        '
        Me.textBox1.Size = New System.Drawing.Size(466, 63)
        Me.textBox1.Text = resources.GetString("textBox1.Text")
        '
        'panel1
        '
        Me.panel1.Controls.Add(Me.button1)
        Me.panel1.Controls.Add(Me.checkBox3)
        Me.panel1.Controls.Add(Me.textBox2)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Controls.Add(Me.checkBox2)
        Me.panel1.Controls.Add(Me.checkBox1)
        Me.panel1.Location = New System.Drawing.Point(0, 63)
        Me.panel1.Size = New System.Drawing.Size(466, 71)
        '
        'tChart1
        '
        '
        '
        '
        Me.tChart1.Aspect.Chart3DPercent = 10
        '
        '
        '
        '
        '
        '
        '
        '
        '
        Me.tChart1.Axes.Bottom.Grid.Color = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tChart1.Axes.Bottom.Grid.Style = System.Drawing.Drawing2D.DashStyle.Dot
        '
        '
        '
        Me.tChart1.Axes.Bottom.Labels.DateTimeFormat = "d.M.yyyy"
        '
        '
        '
        Me.tChart1.Axes.Bottom.Labels.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
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
        Me.tChart1.Axes.Bottom.Title.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        '
        '
        '
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
        Me.tChart1.Axes.Depth.Labels.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
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
        Me.tChart1.Axes.Depth.Title.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        '
        '
        '
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
        Me.tChart1.Axes.DepthTop.Labels.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
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
        Me.tChart1.Axes.DepthTop.Title.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        '
        '
        '
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
        Me.tChart1.Axes.Left.Labels.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
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
        Me.tChart1.Axes.Left.Title.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        '
        '
        '
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
        Me.tChart1.Axes.Right.Labels.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
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
        Me.tChart1.Axes.Right.Title.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        '
        '
        '
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
        Me.tChart1.Axes.Top.Labels.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
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
        Me.tChart1.Axes.Top.Title.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        Me.tChart1.BackColor = System.Drawing.Color.Transparent
        Me.tChart1.Cursor = System.Windows.Forms.Cursors.Default
        '
        '
        '
        '
        '
        '
        Me.tChart1.Footer.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        '
        '
        '
        '
        '
        '
        Me.tChart1.Header.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        Me.tChart1.Header.Lines = New String() {"tChart1"}
        Me.tChart1.Header.Visible = False
        '
        '
        '
        Me.tChart1.Legend.Alignment = Steema.TeeChart.LegendAlignments.Top
        '
        '
        '
        '
        '
        '
        Me.tChart1.Legend.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tChart1.Legend.Brush.Gradient.ExtendedColorPalette = Nothing
        Me.tChart1.Legend.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tChart1.Legend.Brush.Gradient.SigmaFocus = 0.0!
        Me.tChart1.Legend.Brush.Gradient.SigmaScale = 0.0!
        Me.tChart1.Legend.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tChart1.Legend.Brush.Gradient.UseMiddle = True
        Me.tChart1.Legend.Brush.Gradient.Visible = True
        '
        '
        '
        Me.tChart1.Legend.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        '
        '
        '
        '
        '
        '
        Me.tChart1.Legend.Title.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.tChart1.Legend.Visible = False
        Me.tChart1.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        '
        '
        '
        Me.tChart1.Panel.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None
        Me.tChart1.Panel.BorderRound = 10
        '
        '
        '
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(216, Byte), Integer))
        '
        '
        '
        Me.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.tChart1.Panel.Brush.Gradient.ExtendedColorPalette = Nothing
        Me.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tChart1.Panel.Brush.Gradient.SigmaFocus = 0.0!
        Me.tChart1.Panel.Brush.Gradient.SigmaScale = 0.0!
        Me.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tChart1.Panel.Brush.Gradient.UseMiddle = True
        Me.tChart1.Panel.Brush.Gradient.Visible = True
        '
        '
        '
        Me.tChart1.Panel.Pen.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tChart1.Panel.Pen.Visible = True
        Me.tChart1.Panel.Pen.Width = 6
        Me.tChart1.Series.Add(Me.kagi1)
        Me.tChart1.Size = New System.Drawing.Size(466, 152)
        '
        '
        '
        '
        '
        '
        Me.tChart1.SubFooter.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        '
        '
        '
        '
        '
        '
        Me.tChart1.SubHeader.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        '
        '
        '
        '
        '
        '
        '
        '
        '
        Me.tChart1.Walls.Left.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        '
        '
        '
        '
        '
        '
        Me.tChart1.Walls.Right.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        '
        'chartContainer
        '
        Me.chartContainer.Location = New System.Drawing.Point(0, 134)
        Me.chartContainer.Size = New System.Drawing.Size(466, 152)
        '
        'kagi1
        '
        '
        '
        '
        Me.kagi1.Brush.Color = System.Drawing.Color.Red
        Me.kagi1.ColorEach = False
        '
        '
        '
        Me.kagi1.LinePen.Color = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        '
        '
        '
        '
        '
        '
        '
        '
        Me.kagi1.Marks.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.kagi1.Marks.Brush.Gradient.ExtendedColorPalette = Nothing
        Me.kagi1.Marks.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.kagi1.Marks.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.kagi1.Marks.Brush.Gradient.UseMiddle = True
        Me.kagi1.Marks.Brush.Gradient.Visible = True
        '
        '
        '
        Me.kagi1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None
        Me.kagi1.Marks.Callout.ArrowHeadSize = 8
        '
        '
        '
        Me.kagi1.Marks.Callout.Brush.Color = System.Drawing.Color.Black
        Me.kagi1.Marks.Callout.Distance = 0
        Me.kagi1.Marks.Callout.Draw3D = False
        Me.kagi1.Marks.Callout.Length = 10
        Me.kagi1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        '
        '
        '
        Me.kagi1.Marks.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        '
        '
        '
        Me.kagi1.Pointer.Draw3D = False
        Me.kagi1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.kagi1.Title = "kagi1"
        '
        '
        '
        Me.kagi1.UpSwing.Width = 3
        '
        '
        '
        Me.kagi1.XValues.DataMember = "X"
        Me.kagi1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        '
        '
        '
        Me.kagi1.YValues.DataMember = "Y"
        '
        'checkBox1
        '
#If VS2005 Then
        Me.checkBox1.AutoSize = true
#End If
        Me.checkBox1.Checked = True
        Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox1.Location = New System.Drawing.Point(12, 17)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(125, 17)
        Me.checkBox1.TabIndex = 0
        Me.checkBox1.Text = "Show buy/sell symbol"
#If (VS2005) Then
        Me.checkBox1.UseVisualStyleBackColor = true
#End If
        AddHandler checkBox1.CheckedChanged, AddressOf Me.checkBox1_CheckedChanged
        '
        'checkBox2
        '
#If VS2005 Then
        Me.checkBox2.AutoSize = True
#End If
        Me.checkBox2.Checked = True
        Me.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox2.Location = New System.Drawing.Point(12, 40)
        Me.checkBox2.Name = "checkBox2"
        Me.checkBox2.Size = New System.Drawing.Size(37, 17)
        Me.checkBox2.TabIndex = 6
#If VS2005 Then
        Me.checkBox2.TabIndex = 1
#End If
        Me.checkBox2.Text = "3D"
#If VS2005 Then
        Me.checkBox2.UseVisualStyleBackColor = True
#End If
        AddHandler Me.checkBox2.CheckedChanged, AddressOf Me.checkBox2_CheckedChanged
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(157, 19)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(87, 13)
        Me.label1.TabIndex = 2
        Me.label1.Text = "Reversal amount"
        '
        'textBox2
        '
        Me.textBox2.Location = New System.Drawing.Point(250, 16)
        Me.textBox2.Name = "textBox2"
        Me.textBox2.Size = New System.Drawing.Size(58, 20)
        Me.textBox2.TabIndex = 3
        AddHandler textBox2.TextChanged, AddressOf Me.textBox2_TextChanged
        '
        'checkBox3
        '
#If (VS2005) Then
        Me.checkBox3.AutoSize = true
#End If
        Me.checkBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox3.Location = New System.Drawing.Point(160, 40)
        Me.checkBox3.Name = "checkBox3"
        Me.checkBox3.Size = New System.Drawing.Size(104, 17)
        Me.checkBox3.TabIndex = 4
        Me.checkBox3.Text = "Absolute reversal"
#If (VS2005) Then
        Me.checkBox3.UseVisualStyleBackColor = true
#End If
        AddHandler checkBox3.CheckedChanged, AddressOf Me.checkBox3_CheckedChanged
        '
        'button1
        '
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.Location = New System.Drawing.Point(354, 14)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(75, 23)
        Me.button1.TabIndex = 5
        Me.button1.Text = "&Edit series"
#If (VS2005) Then
        Me.button1.UseVisualStyleBackColor = true
#End If
        AddHandler button1.Click, AddressOf Me.button1_Click
        '
        'Kagi
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(466, 286)
        Me.Name = "Kagi"
        AddHandler Me.Load, AddressOf Me.Candle_HighLowPen_Load
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.chartContainer.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region


    Private Sub Candle_HighLowPen_Load(ByVal sender As Object, ByVal e As System.EventArgs)
        ' 1st week
        kagi1.Add(20, "2006-08-21")
        kagi1.Add(14, "2006-08-22")
        kagi1.Add(15, "2006-08-23")
        kagi1.Add(10, "2006-08-24")
        kagi1.Add(12, "2006-08-25")
        ' 2nd week 
        kagi1.Add(12, "2006-08-28")
        kagi1.Add(12, "2006-08-29")
        kagi1.Add(13, "2006-08-30")
        kagi1.Add(9, "2006-08-31")
        kagi1.Add(8, "2006-9-01")
        ' customize axis labels, because Kagi is not aware of time scale
        Dim labels As Steema.TeeChart.AxisLabels = kagi1.GetHorizAxis.Labels
        labels.Items.Clear()
        ' these are dates when direction changes
        labels.Items.Add(0, "2006-08-21")
        labels.Items.Add(1, "2006-08-23")
        labels.Items.Add(2, "2006-08-24")
        labels.Items.Add(3, "2006-08-30")
        labels.Items.Add(4, "2006-09-01")
        textBox2.Text = kagi1.ReversalAmount.ToString
    End Sub

    Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
        kagi1.BuySymbol.Visible = checkBox1.Checked
        kagi1.SellSymbol.Visible = checkBox1.Checked
    End Sub

    Private Sub checkBox2_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
        tChart1.Aspect.View3D = checkBox2.Checked
    End Sub

    Private Sub textBox2_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
        kagi1.ReversalAmount = Steema.TeeChart.Utils.StringToDouble(textBox2.Text, 0.03)
    End Sub

    Private Sub checkBox3_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
        kagi1.AbsoluteReversal = checkBox3.Checked
    End Sub

    Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs)
        Steema.TeeChart.Editors.SeriesEditor.ShowEditor(kagi1)
    End Sub

End Class

