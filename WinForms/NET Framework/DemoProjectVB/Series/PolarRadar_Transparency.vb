
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing

Imports System.Windows.Forms




Public Class PolarRadar_Transparency
    Inherits Samples.BaseForm
    Private polarSeries1 As Steema.TeeChart.Styles.Polar
    Private polarSeries2 As Steema.TeeChart.Styles.Polar
    Private polarSeries3 As Steema.TeeChart.Styles.Polar
    Private WithEvents hScrollBar1 As System.Windows.Forms.HScrollBar
    Private WithEvents hScrollBar2 As System.Windows.Forms.HScrollBar
    Private WithEvents hScrollBar3 As System.Windows.Forms.HScrollBar
    Private label1 As System.Windows.Forms.Label
    Private components As System.ComponentModel.IContainer = Nothing
    
    
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.polarSeries1.FillSampleValues(5)
        Me.polarSeries2.FillSampleValues(7)
        Me.polarSeries3.FillSampleValues(8)
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
        Me.polarSeries1 = New Steema.TeeChart.Styles.Polar
        Me.polarSeries2 = New Steema.TeeChart.Styles.Polar
        Me.polarSeries3 = New Steema.TeeChart.Styles.Polar
        Me.hScrollBar1 = New System.Windows.Forms.HScrollBar
        Me.hScrollBar2 = New System.Windows.Forms.HScrollBar
        Me.hScrollBar3 = New System.Windows.Forms.HScrollBar
        Me.label1 = New System.Windows.Forms.Label
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(466, 63)
        Me.textBox1.TabIndex = 0
        Me.textBox1.Text = "Polar and Radar series can be transparent (percent from 0 to 100)." + vbCr + vbLf + vbCr + vbLf + "Example : polarSeries1.Transparency = 40 "
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Controls.Add(Me.hScrollBar3)
        Me.panel1.Controls.Add(Me.hScrollBar2)
        Me.panel1.Controls.Add(Me.hScrollBar1)
        Me.panel1.Location = New System.Drawing.Point(0, 63)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(466, 41)
        Me.panel1.TabIndex = 1
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
        ' tChart1.Header
        ' 
        Me.tChart1.Header.Lines = New String() {"Polar series : Transparency"}
        Me.tChart1.Location = New System.Drawing.Point(0, 104)
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Brush
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.tChart1.Series.Add(Me.polarSeries1)
        Me.tChart1.Series.Add(Me.polarSeries2)
        Me.tChart1.Series.Add(Me.polarSeries3)
        Me.tChart1.Size = New System.Drawing.Size(466, 182)
        Me.tChart1.TabIndex = 2
        ' 
        ' polarSeries1
        ' 
        ' 
        ' polarSeries1.Brush
        ' 
        Me.polarSeries1.Brush.Color = System.Drawing.Color.FromArgb(CType(178, System.Byte), CType(255, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        ' 
        ' polarSeries1.Marks
        ' 
        ' 
        ' polarSeries1.Marks.Symbol
        ' 
        ' 
        ' polarSeries1.Marks.Symbol.Shadow
        ' 
        Me.polarSeries1.Marks.Symbol.Shadow.Height = 1
        Me.polarSeries1.Marks.Symbol.Shadow.Visible = True
        Me.polarSeries1.Marks.Symbol.Shadow.Width = 1
        ' 
        ' polarSeries1.Pen
        ' 
        Me.polarSeries1.Pen.Color = System.Drawing.Color.Red
        ' 
        ' polarSeries1.Pointer
        ' 
        ' 
        ' polarSeries1.Pointer.Brush
        ' 
        Me.polarSeries1.Pointer.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(0, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        Me.polarSeries1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.polarSeries1.Title = "polarSeries1"
        ' 
        ' polarSeries1.XValues
        ' 
        Me.polarSeries1.XValues.DataMember = "Angle"
        Me.polarSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' polarSeries1.YValues
        ' 
        Me.polarSeries1.YValues.DataMember = "Y"
        ' 
        ' polarSeries2
        ' 
        ' 
        ' polarSeries2.Brush
        ' 
        Me.polarSeries2.Brush.Color = System.Drawing.Color.FromArgb(CType(178, System.Byte), CType(0, System.Byte), CType(128, System.Byte), CType(0, System.Byte))
        ' 
        ' polarSeries2.Marks
        ' 
        ' 
        ' polarSeries2.Marks.Symbol
        ' 
        ' 
        ' polarSeries2.Marks.Symbol.Shadow
        ' 
        Me.polarSeries2.Marks.Symbol.Shadow.Height = 1
        Me.polarSeries2.Marks.Symbol.Shadow.Visible = True
        Me.polarSeries2.Marks.Symbol.Shadow.Width = 1
        ' 
        ' polarSeries2.Pen
        ' 
        Me.polarSeries2.Pen.Color = System.Drawing.Color.Green
        ' 
        ' polarSeries2.Pointer
        ' 
        ' 
        ' polarSeries2.Pointer.Brush
        ' 
        Me.polarSeries2.Pointer.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(0, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        Me.polarSeries2.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.polarSeries2.Title = "polarSeries2"
        ' 
        ' polarSeries2.XValues
        ' 
        Me.polarSeries2.XValues.DataMember = "Angle"
        Me.polarSeries2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' polarSeries2.YValues
        ' 
        Me.polarSeries2.YValues.DataMember = "Y"
        ' 
        ' polarSeries3
        ' 
        ' 
        ' polarSeries3.Brush
        ' 
        Me.polarSeries3.Brush.Color = System.Drawing.Color.FromArgb(CType(178, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(0, System.Byte))
        ' 
        ' polarSeries3.Marks
        ' 
        ' 
        ' polarSeries3.Marks.Symbol
        ' 
        ' 
        ' polarSeries3.Marks.Symbol.Shadow
        ' 
        Me.polarSeries3.Marks.Symbol.Shadow.Height = 1
        Me.polarSeries3.Marks.Symbol.Shadow.Visible = True
        Me.polarSeries3.Marks.Symbol.Shadow.Width = 1
        ' 
        ' polarSeries3.Pen
        ' 
        Me.polarSeries3.Pen.Color = System.Drawing.Color.Yellow
        ' 
        ' polarSeries3.Pointer
        ' 
        ' 
        ' polarSeries3.Pointer.Brush
        ' 
        Me.polarSeries3.Pointer.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(0, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        Me.polarSeries3.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.polarSeries3.Title = "polarSeries3"
        ' 
        ' polarSeries3.XValues
        ' 
        Me.polarSeries3.XValues.DataMember = "Angle"
        Me.polarSeries3.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' polarSeries3.YValues
        ' 
        Me.polarSeries3.YValues.DataMember = "Y"
        ' 
        ' hScrollBar1
        ' 
        Me.hScrollBar1.Location = New System.Drawing.Point(94, 12)
        Me.hScrollBar1.Name = "hScrollBar1"
        Me.hScrollBar1.Size = New System.Drawing.Size(100, 17)
        Me.hScrollBar1.TabIndex = 1
        Me.hScrollBar1.Value = 30
        ' 
        ' hScrollBar2
        ' 
        Me.hScrollBar2.Location = New System.Drawing.Point(200, 12)
        Me.hScrollBar2.Name = "hScrollBar2"
        Me.hScrollBar2.Size = New System.Drawing.Size(100, 17)
        Me.hScrollBar2.TabIndex = 2
        Me.hScrollBar2.Value = 30
        ' 
        ' hScrollBar3
        ' 
        Me.hScrollBar3.Location = New System.Drawing.Point(307, 12)
        Me.hScrollBar3.Name = "hScrollBar3"
        Me.hScrollBar3.Size = New System.Drawing.Size(100, 17)
        Me.hScrollBar3.TabIndex = 3
        Me.hScrollBar3.Value = 30
        ' 
        ' label1
        ' 
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(7, 12)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(77, 16)
        Me.label1.TabIndex = 0
        Me.label1.Text = "&Transparency:"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        ' 
        ' Polar_Transparency
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(466, 286)
        Me.Name = "Polar_Transparency"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub 'InitializeComponent 
#End Region


    Private Sub hScrollBar1_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles hScrollBar1.ValueChanged
        Me.polarSeries1.Transparency = Fix(Me.hScrollBar1.Value)
    End Sub 'hScrollBar1_ValueChanged


    Private Sub hScrollBar2_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles hScrollBar2.ValueChanged
        Me.polarSeries2.Transparency = Fix(Me.hScrollBar2.Value)
    End Sub 'hScrollBar2_ValueChanged


    Private Sub hScrollBar3_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles hScrollBar3.ValueChanged
        Me.polarSeries3.Transparency = Fix(Me.hScrollBar3.Value)
    End Sub 'hScrollBar3_ValueChanged
End Class 'PolarRadar_Transparency
