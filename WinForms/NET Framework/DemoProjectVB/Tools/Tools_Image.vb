
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing

Imports System.Windows.Forms




Public Class Tools_Image
    Inherits Samples.BaseForm
    Private contourSeries1 As Steema.TeeChart.Styles.Contour
    Private pointSeries1 As Steema.TeeChart.Styles.Points
    Private chartImage1 As Steema.TeeChart.Tools.ChartImage
    Private label1 As System.Windows.Forms.Label
    Private WithEvents hScrollBar1 As System.Windows.Forms.HScrollBar
    Private WithEvents button1 As System.Windows.Forms.Button
    Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
    Private components As System.ComponentModel.IContainer = Nothing
    
    Private Shared OldZoom As Integer = - 1
    
    
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        
        contourSeries1.FillSampleValues(20)
        
        Dim r As New Random()
        Dim t As Integer
        For t = 1 To 49
            pointSeries1.Add(1.0 + r.Next(20), 1.0 + r.Next(20))
        Next t

        ' Do not expand chart margins
        pointSeries1.Pointer.InflateMargins = False
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
        Dim resources As New System.Resources.ResourceManager(GetType(Tools_Image))
        Me.contourSeries1 = New Steema.TeeChart.Styles.Contour
        Me.pointSeries1 = New Steema.TeeChart.Styles.Points
        Me.chartImage1 = New Steema.TeeChart.Tools.ChartImage
        Me.label1 = New System.Windows.Forms.Label
        Me.hScrollBar1 = New System.Windows.Forms.HScrollBar
        Me.button1 = New System.Windows.Forms.Button
        Me.checkBox1 = New System.Windows.Forms.CheckBox
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(466, 63)
        Me.textBox1.Text = "The Image tool draws a picture (bitmap, jpeg, etc) behind chart Series. This can be used for GIS (Geographical) systems, using contours over images, or any other application using images as backgrounds." + vbCr + vbLf + "The image does zoom and scroll, following the associated series and axes."
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.checkBox1)
        Me.panel1.Controls.Add(Me.button1)
        Me.panel1.Controls.Add(Me.hScrollBar1)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Location = New System.Drawing.Point(0, 63)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(466, 41)
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
        ' tChart1.Header
        ' 
        Me.tChart1.Header.Lines = New String() {"tChart1"}
        Me.tChart1.Header.Visible = False
        Me.tChart1.Location = New System.Drawing.Point(0, 104)
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Brush
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.tChart1.Series.Add(Me.contourSeries1)
        Me.tChart1.Series.Add(Me.pointSeries1)
        Me.tChart1.Size = New System.Drawing.Size(466, 182)
        Me.tChart1.Tools.Add(Me.chartImage1)
        ' 
        ' contourSeries1
        ' 
        ' 
        ' contourSeries1.Brush
        ' 
        Me.contourSeries1.Brush.Color = System.Drawing.Color.Red
        Me.contourSeries1.ColorEach = True
        ' 
        ' contourSeries1.Marks
        ' 
        ' 
        ' contourSeries1.Marks.Symbol
        ' 
        ' 
        ' contourSeries1.Marks.Symbol.Shadow
        ' 
        Me.contourSeries1.Marks.Symbol.Shadow.Height = 1
        Me.contourSeries1.Marks.Symbol.Shadow.Visible = True
        Me.contourSeries1.Marks.Symbol.Shadow.Width = 1
        Me.contourSeries1.NumXValues = 25
        Me.contourSeries1.NumZValues = 25
        Me.contourSeries1.PaletteMin = 0
        Me.contourSeries1.PaletteStep = 0
        Me.contourSeries1.Title = "contour1"
        ' 
        ' contourSeries1.XValues
        ' 
        Me.contourSeries1.XValues.DataMember = "X"
        Me.contourSeries1.YPosition = 0.20290816683830415
        ' 
        ' contourSeries1.YValues
        ' 
        Me.contourSeries1.YValues.DataMember = "Y"
        ' 
        ' contourSeries1.ZValues
        ' 
        Me.contourSeries1.ZValues.DataMember = "Z"
        ' 
        ' pointSeries1
        ' 
        Me.pointSeries1.ColorEach = True
        ' 
        ' pointSeries1.Marks
        ' 
        ' 
        ' pointSeries1.Marks.Symbol
        ' 
        ' 
        ' pointSeries1.Marks.Symbol.Shadow
        ' 
        Me.pointSeries1.Marks.Symbol.Shadow.Height = 1
        Me.pointSeries1.Marks.Symbol.Shadow.Visible = True
        Me.pointSeries1.Marks.Symbol.Shadow.Width = 1
        ' 
        ' pointSeries1.Pointer
        ' 
        ' 
        ' pointSeries1.Pointer.Brush
        ' 
        Me.pointSeries1.Pointer.Brush.Color = System.Drawing.Color.Green
        Me.pointSeries1.Pointer.Brush.ForegroundColor = System.Drawing.Color.Empty
        Me.pointSeries1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.pointSeries1.Title = "point1"
        ' 
        ' pointSeries1.XValues
        ' 
        Me.pointSeries1.XValues.DataMember = "X"
        Me.pointSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' pointSeries1.YValues
        ' 
        Me.pointSeries1.YValues.DataMember = "Y"
        ' 
        ' chartImage1
        ' 
        Me.chartImage1.Image = CType(resources.GetObject("chartImage1.Image"), System.Drawing.Image)
        Me.chartImage1.Series = Me.contourSeries1
        ' 
        ' label1
        ' 
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(15, 11)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(36, 16)
        Me.label1.TabIndex = 0
        Me.label1.Text = "&Zoom:"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        ' 
        ' hScrollBar1
        ' 
        Me.hScrollBar1.Location = New System.Drawing.Point(60, 9)
        Me.hScrollBar1.Maximum = 200
        Me.hScrollBar1.Minimum = 50
        Me.hScrollBar1.Name = "hScrollBar1"
        Me.hScrollBar1.Size = New System.Drawing.Size(113, 17)
        Me.hScrollBar1.TabIndex = 1
        Me.hScrollBar1.Value = 100
        ' 
        ' button1
        ' 
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.Location = New System.Drawing.Point(193, 7)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(95, 23)
        Me.button1.TabIndex = 2
        Me.button1.Text = "&Edit tool..."
        ' 
        ' checkBox1
        ' 
        Me.checkBox1.Checked = True
        Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox1.Location = New System.Drawing.Point(312, 8)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(87, 21)
        Me.checkBox1.TabIndex = 3
        Me.checkBox1.Text = "&Active"
        ' 
        ' Tool_Image
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(466, 286)
        Me.Name = "Tool_Image"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub 'InitializeComponent 
#End Region


    Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox1.CheckedChanged
        chartImage1.Active = checkBox1.Checked
    End Sub 'checkBox1_CheckedChanged


    Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
        TeeChart.Editors.Tools.ToolsEditor.ShowEditor(chartImage1)
    End Sub 'button1_Click


    Private Sub hScrollBar1_Scroll(ByVal sender As Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles hScrollBar1.Scroll
        If hScrollBar1.Value > OldZoom Then
            tChart1.Zoom.ZoomPercent(105)
        ElseIf hScrollBar1.Value < OldZoom Then
            tChart1.Zoom.ZoomPercent(95)
        End If
        OldZoom = hScrollBar1.Value
    End Sub 'hScrollBar1_Scroll
End Class 'Tools_Image
