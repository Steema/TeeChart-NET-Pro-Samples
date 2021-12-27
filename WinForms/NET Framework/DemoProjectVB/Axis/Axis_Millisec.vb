
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Public Class Axis_Millisec
    Inherits Steema.TeeChart.Samples.BaseForm
    Private points1 As Steema.TeeChart.Styles.Points
    Private WithEvents cbFormat As System.Windows.Forms.ComboBox
    Private label2 As System.Windows.Forms.Label
    Private components As System.ComponentModel.IContainer = Nothing
    
    Public Sub New() ' This call is required by the Windows Form Designer.
        InitializeComponent()
        AddFormats()
        points1.Add(Today.AddMilliseconds(1), 100)
        points1.Add(Today.AddMilliseconds(5), 200)
        points1.Add(Today.AddMilliseconds(10), 100)
        points1.Add(Today.AddMilliseconds(15), 50)
        points1.Pointer.Style = TeeChart.Styles.PointerStyles.Triangle
        points1.XValues.DateTime = True
        Dim axis As TeeChart.Axis = tChart1.Axes.Bottom
        axis.Increment = Steema.TeeChart.Utils.GetDateTimeStep(Steema.TeeChart.DateTimeSteps.OneMillisecond)
        axis.Labels.DateTimeFormat = "ss.fff"
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
        Me.points1 = New Steema.TeeChart.Styles.Points
        Me.cbFormat = New System.Windows.Forms.ComboBox
        Me.label2 = New System.Windows.Forms.Label
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.BackColor = System.Drawing.Color.AliceBlue
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(440, 40)
        Me.textBox1.TabIndex = 0
        Me.textBox1.Text = "Axes labels can be formatted using date-time string format specifiers."
        ' 
        ' panel1
        ' 
        Me.panel1.BackColor = System.Drawing.SystemColors.Control
        Me.panel1.Controls.Add(Me.label2)
        Me.panel1.Controls.Add(Me.cbFormat)
        Me.panel1.Location = New System.Drawing.Point(0, 40)
        Me.panel1.Name = "panel1"
        Me.panel1.TabIndex = 1
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
        ' tChart1.Axes.Bottom.Grid
        ' 
        Me.tChart1.Axes.Bottom.Grid.Visible = False
        ' 
        ' tChart1.Axes.Bottom.Labels
        ' 
        Me.tChart1.Axes.Bottom.Labels.Angle = 90
        ' 
        ' tChart1.Axes.Left
        ' 
        ' 
        ' tChart1.Axes.Left.AxisPen
        ' 
        Me.tChart1.Axes.Left.AxisPen.Color = System.Drawing.Color.FromArgb(CType(254, Byte), CType(128, Byte), CType(128, Byte), CType(128, Byte))
        Me.tChart1.Axes.Left.AxisPen.Width = 1
        ' 
        ' tChart1.Axes.Left.Grid
        ' 
        Me.tChart1.Axes.Left.Grid.Visible = False
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
        Me.tChart1.Header.Font.Shadow.Visible = True
        Me.tChart1.Header.Lines = New String() {"Formatted Axis Labels"}
        ' 
        ' tChart1.Legend
        ' 
        ' 
        ' tChart1.Legend.Pen
        ' 
        Me.tChart1.Legend.Pen.Visible = False
        ' 
        ' tChart1.Legend.Shadow
        ' 
        ' 
        ' tChart1.Legend.Shadow.Brush
        ' 
        Me.tChart1.Legend.Shadow.Brush.Color = System.Drawing.Color.FromArgb(CType(254, Byte), CType(128, Byte), CType(128, Byte), CType(128, Byte))
        Me.tChart1.Location = New System.Drawing.Point(0, 79)
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
        Me.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(254, Byte), CType(192, Byte), CType(192, Byte), CType(255, Byte))
        Me.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(254, Byte), CType(255, Byte), CType(255, Byte), CType(210, Byte))
        Me.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(254, Byte), CType(192, Byte), CType(192, Byte), CType(255, Byte))
        Me.tChart1.Panel.Brush.Gradient.UseMiddle = True
        Me.tChart1.Panel.Brush.Gradient.Visible = True
        ' 
        ' tChart1.Panel.Gradient
        ' 
        Me.tChart1.Panel.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(254, Byte), CType(192, Byte), CType(192, Byte), CType(255, Byte))
        Me.tChart1.Panel.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(254, Byte), CType(255, Byte), CType(255, Byte), CType(210, Byte))
        Me.tChart1.Panel.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(254, Byte), CType(192, Byte), CType(192, Byte), CType(255, Byte))
        Me.tChart1.Panel.Gradient.UseMiddle = True
        Me.tChart1.Panel.Gradient.Visible = True
        Me.tChart1.Series.Add(Me.points1)
        Me.tChart1.Size = New System.Drawing.Size(440, 238)
        Me.tChart1.TabIndex = 2
        ' 
        ' tChart1.Walls
        ' 
        ' 
        ' tChart1.Walls.Back
        ' 
        ' 
        ' tChart1.Walls.Back.Brush
        ' 
        Me.tChart1.Walls.Back.Brush.Color = System.Drawing.Color.FromArgb(CType(76, Byte), CType(255, Byte), CType(192, Byte), CType(192, Byte))
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
        ' points1
        ' 
        ' 
        ' points1.LinePen
        ' 
        Me.points1.LinePen.Color = System.Drawing.Color.FromArgb(CType(254, Byte), CType(153, Byte), CType(77, Byte), CType(77, Byte))
        ' 
        ' points1.Pointer
        ' 
        ' 
        ' points1.Pointer.Brush
        ' 
        Me.points1.Pointer.Brush.Color = System.Drawing.Color.FromArgb(CType(254, Byte), CType(255, Byte), CType(128, Byte), CType(128, Byte))
        ' 
        ' points1.Pointer.Pen
        ' 
        Me.points1.Pointer.Pen.Color = System.Drawing.Color.FromArgb(CType(254, Byte), CType(153, Byte), CType(77, Byte), CType(77, Byte))
        Me.points1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.points1.Title = "points1"
        ' 
        ' points1.XValues
        ' 
        Me.points1.XValues.DataMember = "X"
        Me.points1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' points1.YValues
        ' 
        Me.points1.YValues.DataMember = "Y"
        ' 
        ' cbFormat
        ' 
        Me.cbFormat.Location = New System.Drawing.Point(64, 8)
        Me.cbFormat.Name = "cbFormat"
        Me.cbFormat.Size = New System.Drawing.Size(136, 21)
        Me.cbFormat.TabIndex = 1
        AddHandler cbFormat.TextChanged, AddressOf Me.cbFormat_SelectedIndexChanged
        AddHandler cbFormat.SelectedIndexChanged, AddressOf Me.cbFormat_SelectedIndexChanged
        ' 
        ' label2
        ' 
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(17, 12)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(43, 16)
        Me.label2.TabIndex = 0
        Me.label2.Text = "&Format:"
        Me.label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        ' 
        ' Axis_Millisecond
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(440, 317)
        Me.Name = "Axis_Millisecond"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub 'New 
#End Region

    Private Sub AddFormats()
        cbFormat.Items.Clear()
        cbFormat.Items.Add("t")
        cbFormat.Items.Add("T")
        cbFormat.Items.Add(System.Globalization.DateTimeFormatInfo.CurrentInfo.ShortTimePattern)
        cbFormat.Items.Add(System.Globalization.DateTimeFormatInfo.CurrentInfo.LongTimePattern)
        cbFormat.Items.Add("HH mm")
        cbFormat.Items.Add("hh mm")
        cbFormat.Items.Add("hh mm ss")
        cbFormat.Items.Add("hh mm ss.fff")
        cbFormat.Items.Add(System.Globalization.DateTimeFormatInfo.CurrentInfo.ShortDatePattern)
        cbFormat.Items.Add(System.Globalization.DateTimeFormatInfo.CurrentInfo.LongDatePattern)
        cbFormat.Items.Add("yyyy-mm-dd")
        cbFormat.Items.Add("mm-dd-yyyy")
        cbFormat.Items.Add("dd-mm-yyyy")
        cbFormat.Items.Add("ddd")
        cbFormat.Items.Add("dddd")
        cbFormat.Items.Add("mmm")
        cbFormat.Items.Add("mmmm")
        cbFormat.Text = tChart1.Axes.Bottom.Labels.DateTimeFormat
    End Sub 'AddFormats


    Private Sub cbFormat_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        tChart1.Axes.Bottom.Labels.DateTimeFormat = cbFormat.Text
    End Sub 'cbFormat_SelectedIndexChanged
End Class 'Axis_Millisec