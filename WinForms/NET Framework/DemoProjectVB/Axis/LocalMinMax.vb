
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports Steema.TeeChart.Styles


Public Class Axis_LocalMinMax
    Inherits Steema.TeeChart.Samples.BaseForm
    Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
    Private pageNumber1 As Steema.TeeChart.Tools.PageNumber
    Private WithEvents button1 As System.Windows.Forms.Button
    Private WithEvents button2 As System.Windows.Forms.Button
    Private candle1 As Steema.TeeChart.Styles.Candle
    Private components As System.ComponentModel.IContainer = Nothing
    
    Public Sub New() ' This call is required by the Windows Form Designer.
        InitializeComponent()

        candle1.FillSampleValues(100)
    End Sub

    '/// <summary>
    '/// Clean up any resources being used.
    '/// </summary>
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
        Me.checkBox1 = New System.Windows.Forms.CheckBox
        Me.pageNumber1 = New Steema.TeeChart.Tools.PageNumber
        Me.button1 = New System.Windows.Forms.Button
        Me.button2 = New System.Windows.Forms.Button
        Me.candle1 = New Steema.TeeChart.Styles.Candle
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.BackColor = System.Drawing.Color.AliceBlue
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Text = ("It\'s easy to use the Series Value lists to find the minimum and maximum of a \""win" + "dow\"" of series points.")
        ' 
        ' panel1
        ' 
        Me.panel1.BackColor = System.Drawing.SystemColors.Control
        Me.panel1.Controls.Add(Me.button2)
        Me.panel1.Controls.Add(Me.button1)
        Me.panel1.Controls.Add(Me.checkBox1)
        Me.panel1.Name = "panel1"
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
        Me.tChart1.Axes.Bottom.AxisPen.Visible = False
        Me.tChart1.Axes.Bottom.AxisPen.Width = 1
        ' 
        ' tChart1.Axes.Left
        ' 
        ' 
        ' tChart1.Axes.Left.AxisPen
        ' 
        Me.tChart1.Axes.Left.AxisPen.Visible = False
        Me.tChart1.Axes.Left.AxisPen.Width = 1
        Me.tChart1.Cursor = System.Windows.Forms.Cursors.Default
        ' 
        ' tChart1.Header
        ' 
        Me.tChart1.Header.Lines = New String() {"tChart1"}
        Me.tChart1.Header.Visible = False
        ' 
        ' tChart1.Legend
        ' 
        Me.tChart1.Legend.Visible = False
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Page
        ' 
        Me.tChart1.Page.MaxPointsPerPage = 25
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
        Me.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(254, Byte), CType(255, Byte), CType(255, Byte), CType(210, Byte))
        Me.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(254, Byte), CType(255, Byte), CType(255, Byte), CType(210, Byte))
        Me.tChart1.Panel.Brush.Gradient.UseMiddle = True
        Me.tChart1.Panel.Brush.Gradient.Visible = True
        ' 
        ' tChart1.Panel.Gradient
        ' 
        Me.tChart1.Panel.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(254, Byte), CType(255, Byte), CType(255, Byte), CType(210, Byte))
        Me.tChart1.Panel.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(254, Byte), CType(255, Byte), CType(255, Byte), CType(210, Byte))
        Me.tChart1.Panel.Gradient.UseMiddle = True
        Me.tChart1.Panel.Gradient.Visible = True
        Me.tChart1.Panel.MarginTop = 10
        Me.tChart1.Series.Add(Me.candle1)
        Me.tChart1.Tools.Add(Me.pageNumber1)
        ' 
        ' tChart1.Walls
        ' 
        ' 
        ' tChart1.Walls.Back
        ' 
        ' 
        ' tChart1.Walls.Back.Pen
        ' 
        Me.tChart1.Walls.Back.Pen.Color = System.Drawing.Color.FromArgb(CType(254, Byte), CType(128, Byte), CType(128, Byte), CType(128, Byte))
        ' 
        ' checkBox1
        ' 
        Me.checkBox1.Location = New System.Drawing.Point(8, 8)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(136, 16)
        Me.checkBox1.TabIndex = 0
        Me.checkBox1.Text = "Adjust vertical axis"
        AddHandler checkBox1.CheckedChanged, AddressOf Me.checkBox1_CheckedChanged
        ' 
        ' pageNumber1
        ' 
        Me.pageNumber1.Cursor = System.Windows.Forms.Cursors.Default
        Me.pageNumber1.Format = "Page {0} of {1}"
        Me.pageNumber1.Left = 6
        ' 
        ' pageNumber1.Shape
        ' 
        Me.pageNumber1.Shape.Bottom = 25
        ' 
        ' pageNumber1.Shape.Brush
        ' 
        Me.pageNumber1.Shape.Brush.Color = System.Drawing.Color.FromArgb(CType(254, Byte), CType(240, Byte), CType(240, Byte), CType(255, Byte))
        Me.pageNumber1.Shape.CustomPosition = True
        Me.pageNumber1.Shape.Left = 6
        Me.pageNumber1.Shape.Lines = New String() {"Page {0} of {1}"}
        ' 
        ' pageNumber1.Shape.Pen
        ' 
        Me.pageNumber1.Shape.Pen.Visible = False
        Me.pageNumber1.Shape.Right = 86
        ' 
        ' pageNumber1.Shape.Shadow
        ' 
        Me.pageNumber1.Shape.Shadow.Visible = True
        Me.pageNumber1.Shape.Top = 8
        Me.pageNumber1.Text = "Page {0} of {1}"
        Me.pageNumber1.Top = 8
        ' 
        ' button1
        ' 
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.Location = New System.Drawing.Point(160, 8)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(24, 23)
        Me.button1.TabIndex = 1
        Me.button1.Text = "<"
        AddHandler button1.Click, AddressOf Me.button1_Click
        ' 
        ' button2
        ' 
        Me.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button2.Location = New System.Drawing.Point(192, 8)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(24, 23)
        Me.button2.TabIndex = 2
        Me.button2.Text = ">"
        AddHandler button2.Click, AddressOf Me.button2_Click
        ' 
        ' candle1
        ' 
        ' 
        ' candle1.Brush
        ' 
        Me.candle1.Brush.Color = System.Drawing.Color.Red
        Me.candle1.CloseValues = Me.candle1.YValues
        Me.candle1.DateValues = Me.candle1.XValues
        Me.candle1.DownCloseColor = System.Drawing.Color.FromArgb(CType(254, Byte), CType(255, Byte), CType(128, Byte), CType(128, Byte))
        ' 
        ' candle1.Pointer
        ' 
        Me.candle1.Pointer.Draw3D = False
        Me.candle1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.candle1.Title = "candle1"
        Me.candle1.UpCloseColor = System.Drawing.Color.FromArgb(CType(254, Byte), CType(102, Byte), CType(153, Byte), CType(255, Byte))
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
        ' Axis_LocalMinMax
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(440, 317)
        Me.Name = "Axis_LocalMinMax"
        AddHandler Load, AddressOf Me.Axis_LocalMinMax_Load
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub 'New 
#End Region

    Private Sub FindMinMax(ByVal v As ValueList, ByVal firstPoint As Integer, ByVal lastPoint As Integer, ByRef min As Double, ByRef max As Double)
        min = v.Value(firstPoint)
        max = v.Value(lastPoint)
        Dim t As Integer
        For t = firstPoint To lastPoint
            If v.Value(t) < min Then
                min = v.Value(t)
            ElseIf v.Value(t) > max Then
                max = v.Value(t)
            End If
        Next t
    End Sub 'FindMinMax

    Private Sub AdjustAxisScale(ByVal s As Steema.TeeChart.Styles.Series, ByVal firstPoint As Integer, ByVal lastPoint As Integer, ByVal vertical As Boolean)
        Dim min, max As Double
        If vertical Then
            FindMinMax(s.YValues, firstPoint, lastPoint, min, max)
            s.GetVertAxis.Automatic = False
            s.GetVertAxis.SetMinMax(min, max)
        Else
            FindMinMax(s.XValues, firstPoint, lastPoint, min, max)
            s.GetHorizAxis.Automatic = False
            s.GetHorizAxis.SetMinMax(min, max)
        End If
    End Sub 'AdjustAxisScale


    Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        tChart1.Page.Previous()
        If checkBox1.Checked Then
            AdjustAxisScale(candle1, candle1.FirstVisibleIndex, candle1.LastVisibleIndex, True)
        Else
            candle1.GetVertAxis.Automatic = True
        End If
    End Sub 'button1_Click

    Private Sub button2_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        tChart1.Page.Next()
        If checkBox1.Checked Then
            AdjustAxisScale(candle1, candle1.FirstVisibleIndex, candle1.LastVisibleIndex, True)
        Else
            candle1.GetVertAxis.Automatic = True
        End If
    End Sub 'button2_Click

    Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        candle1.Repaint()
    End Sub 'checkBox1_CheckedChanged


    Private Sub Axis_LocalMinMax_Load(ByVal sender As Object, ByVal e As System.EventArgs)
    End Sub 'Axis_LocalMinMax_Load
End Class 'Axis_LocalMinMax