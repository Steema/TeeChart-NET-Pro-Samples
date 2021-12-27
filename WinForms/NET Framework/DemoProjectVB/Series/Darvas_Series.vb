Imports System
#If VS2005 Then
Imports System.Collections.Generic
#End If
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms




Public Class Darvas_Series
    Inherits Samples.BaseForm
    'private box as integer = -1
    Private recttool As Tools.RectangleTool
    Private WithEvents button1 As Button
    Private candle1 As Steema.TeeChart.Styles.Candle
    Private darvas1 As Steema.TeeChart.Styles.Darvas
    Private components As System.ComponentModel.IContainer = Nothing


    Public Sub New()
        ' Me call is required by the Windows Form Designer.
        InitializeComponent()
        'Setup tool
        recttool = New Steema.TeeChart.Tools.RectangleTool(tChart1.Chart)
        recttool.Active = False
        recttool.AllowDrag = False
        recttool.AllowResize = False
        tChart1.Tools.Add(recttool)
        InitializeChart()
    End Sub 'New

    Private Sub InitializeChart()
        candle1.FillSampleValues(100)
        For i As Integer = 0 To candle1.Count - 1
            darvas1.Add(candle1.DateValues(i), candle1.OpenValues(i), candle1.HighValues(i), candle1.LowValues(i), candle1.CloseValues(i))
        Next i
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

#Region "Designer generated code"

    '/ <summary>
    '/ Required method for Designer support - do not modify
    '/ the contents of Me method with the code editor.
    '/ </summary>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Darvas_Series))
        Me.button1 = New System.Windows.Forms.Button()
        Me.candle1 = New Steema.TeeChart.Styles.Candle()
        Me.darvas1 = New Steema.TeeChart.Styles.Darvas()
        Me.panel1.SuspendLayout()
        Me.chartContainer.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Text = resources.GetString("textBox1.Text")
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.button1)
        ' 
        ' tChart1
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
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Left.AxisPen.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
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
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Top.AxisPen.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Header.Font.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tChart1.Header.Lines = New String() { _
        "Darvas Boxes example"}
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.tChart1.Panel.Brush.Gradient.ExtendedColorPalette = Nothing
        Me.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tChart1.Panel.Brush.Gradient.Sigma = True
        Me.tChart1.Panel.Brush.Gradient.SigmaFocus = 1.0F
        Me.tChart1.Panel.Brush.Gradient.SigmaScale = 0.8F
        Me.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tChart1.Panel.Brush.Gradient.UseMiddle = True
        Me.tChart1.Panel.Brush.Gradient.Visible = True
        Me.tChart1.Series.Add(Me.candle1)
        Me.tChart1.Series.Add(Me.darvas1)
        Me.tChart1.Size = New System.Drawing.Size(440, 205)
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
        Me.tChart1.Walls.Back.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tChart1.Walls.Back.Brush.Gradient.ExtendedColorPalette = Nothing
        Me.tChart1.Walls.Back.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.tChart1.Walls.Back.Brush.Gradient.Visible = True
        Me.tChart1.Walls.Back.Brush.Visible = True
        Me.tChart1.Walls.Back.Transparent = False
        ' 
        ' button1
        ' 
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.Location = New System.Drawing.Point(12, 6)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(75, 23)
        Me.button1.TabIndex = 0
        Me.button1.Text = "Edit..."
#If VS2005 Then
        Me.button1.UseVisualStyleBackColor = True
#End If
        ' 
        ' candle1
        ' 
        ' 
        ' 
        ' 
        Me.candle1.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.candle1.CloseValues = Me.candle1.YValues
        Me.candle1.ColorEach = False
        Me.candle1.DateValues = Me.candle1.XValues
        Me.candle1.DefaultNullValue = 0
        ' 
        ' 
        ' 
        Me.candle1.HighLowPen.Color = System.Drawing.Color.Black
        ' 
        ' 
        ' 
        Me.candle1.LinePen.Color = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(26, Byte), Integer))
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.candle1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None
        Me.candle1.Marks.Callout.ArrowHeadSize = 8
        ' 
        ' 
        ' 
        Me.candle1.Marks.Callout.Brush.Color = System.Drawing.Color.Black
        Me.candle1.Marks.Callout.Distance = 0
        Me.candle1.Marks.Callout.Draw3D = False
        Me.candle1.Marks.Callout.Length = 10
        Me.candle1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        ' 
        ' 
        ' 
        Me.candle1.Pointer.Draw3D = False
        Me.candle1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.candle1.Pointer.Visible = True
        Me.candle1.Title = "candle1"
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
        ' darvas1
        ' 
        ' 
        ' 
        ' 
        Me.darvas1.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.darvas1.CloseValues = Me.darvas1.YValues
        Me.darvas1.ColorEach = False
        Me.darvas1.DateValues = Me.darvas1.XValues
        Me.darvas1.DefaultNullValue = 0
        ' 
        ' 
        ' 
        Me.darvas1.LinePen.Color = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(32, Byte), Integer))
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.darvas1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None
        Me.darvas1.Marks.Callout.ArrowHeadSize = 8
        ' 
        ' 
        ' 
        Me.darvas1.Marks.Callout.Brush.Color = System.Drawing.Color.Black
        Me.darvas1.Marks.Callout.Distance = 0
        Me.darvas1.Marks.Callout.Draw3D = False
        Me.darvas1.Marks.Callout.Length = 10
        Me.darvas1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        ' 
        ' 
        ' 
        Me.darvas1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.darvas1.Pointer.Visible = True
        Me.darvas1.Title = "darvas1"
        ' 
        ' 
        ' 
        Me.darvas1.XValues.DataMember = "Date"
        Me.darvas1.XValues.DateTime = True
        Me.darvas1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' 
        ' 
        Me.darvas1.YValues.DataMember = "Close"
        ' 
        ' Darvas_Series
        ' 
#If VS2005 Then
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
#End If
        Me.ClientSize = New System.Drawing.Size(440, 317)
        Me.Name = "Darvas_Series"
        Me.Text = "Darvas_Series"
        Me.panel1.ResumeLayout(False)
        Me.chartContainer.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub 'InitializeComponent 
#End Region


    Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
        Dim Editor As Steema.TeeChart.Editors.Series.DarvasEditor = New Steema.TeeChart.Editors.Series.DarvasEditor(darvas1)
        Editor.SetParent(Nothing)
        Steema.TeeChart.Editors.EditorUtils.ShowFormModal(Editor)
    End Sub

    Private Sub tChart1_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles tChart1.MouseMove
        Dim tmp As Integer = darvas1.Clicked(e.X, e.Y)
        recttool.Active = (tmp <> -1)
        If recttool.Active Then
            recttool.Bounds = darvas1.Boxes(tmp)
            recttool.Invalidate()
        End If
    End Sub
End Class 'Area_Gradient
