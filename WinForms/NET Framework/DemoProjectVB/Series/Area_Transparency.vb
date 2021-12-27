
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing

Imports System.Windows.Forms




Public Class Area_Transparency
    Inherits Samples.BaseForm
    Private areaSeries1 As Steema.TeeChart.Styles.Area
    Private areaSeries2 As Steema.TeeChart.Styles.Area
    Private areaSeries3 As Steema.TeeChart.Styles.Area
    Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
    Private WithEvents hScrollBar1 As System.Windows.Forms.HScrollBar
    Private WithEvents hScrollBar2 As System.Windows.Forms.HScrollBar
    Private WithEvents hScrollBar3 As System.Windows.Forms.HScrollBar
    Private components As System.ComponentModel.IContainer = Nothing
    
    
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        

        For Each s As Steema.TeeChart.Styles.Area In Me.tChart1.Series
            s.FillSampleValues(10)
            s.Transparency = 30
        Next s

        ' Fix Net bug:
        hScrollBar1.Maximum += hScrollBar1.LargeChange - 1
        hScrollBar2.Maximum += hScrollBar2.LargeChange - 1
        hScrollBar3.Maximum += hScrollBar3.LargeChange - 1
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
        Me.areaSeries1 = New Steema.TeeChart.Styles.Area
        Me.areaSeries2 = New Steema.TeeChart.Styles.Area
        Me.areaSeries3 = New Steema.TeeChart.Styles.Area
        Me.checkBox1 = New System.Windows.Forms.CheckBox
        Me.hScrollBar1 = New System.Windows.Forms.HScrollBar
        Me.hScrollBar2 = New System.Windows.Forms.HScrollBar
        Me.hScrollBar3 = New System.Windows.Forms.HScrollBar
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(466, 73)
        Me.textBox1.Text = "Area Series, when displayed in 2D mode, allows Transparency. Transparency is a nu" + "mber from 0 to 100 expressed in percent units." + vbCr + vbLf + vbCr + vbLf + "areaSeries1.Transparency = 45 " + ""
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.hScrollBar3)
        Me.panel1.Controls.Add(Me.hScrollBar2)
        Me.panel1.Controls.Add(Me.hScrollBar1)
        Me.panel1.Controls.Add(Me.checkBox1)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(466, 31)
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
        Me.tChart1.Header.Lines = New String() {"Area series transparency"}
        ' 
        ' tChart1.Legend
        ' 
        ' 
        ' tChart1.Legend.Brush
        ' 
        Me.tChart1.Legend.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(240, System.Byte), CType(240, System.Byte), CType(255, System.Byte))
        ' 
        ' tChart1.Legend.Pen
        ' 
        Me.tChart1.Legend.Pen.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(134, System.Byte), CType(134, System.Byte), CType(134, System.Byte))
        Me.tChart1.Legend.Pen.Visible = False
        ' 
        ' tChart1.Legend.Shadow
        ' 
        Me.tChart1.Legend.Shadow.Visible = False
        Me.tChart1.Location = New System.Drawing.Point(0, 104)
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Brush
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        ' 
        ' tChart1.Panel.Gradient
        ' 
        Me.tChart1.Panel.Brush.Gradient.Direction = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(224, System.Byte), CType(224, System.Byte), CType(224, System.Byte))
        Me.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(192, System.Byte), CType(192, System.Byte), CType(192, System.Byte))
        Me.tChart1.Panel.Brush.Gradient.UseMiddle = True
        Me.tChart1.Panel.Brush.Gradient.Visible = True
        ' 
        ' tChart1.Panel.Gradient
        ' 
        Me.tChart1.Panel.Gradient.Direction = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.tChart1.Panel.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(224, System.Byte), CType(224, System.Byte), CType(224, System.Byte))
        Me.tChart1.Panel.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(192, System.Byte), CType(192, System.Byte), CType(192, System.Byte))
        Me.tChart1.Panel.Gradient.UseMiddle = True
        Me.tChart1.Panel.Gradient.Visible = True
        Me.tChart1.Series.Add(Me.areaSeries1)
        Me.tChart1.Series.Add(Me.areaSeries2)
        Me.tChart1.Series.Add(Me.areaSeries3)
        Me.tChart1.Size = New System.Drawing.Size(466, 182)
        ' 
        ' areaSeries1
        ' 
        ' 
        ' areaSeries1.AreaBrush
        ' 
        Me.areaSeries1.AreaBrush.Color = System.Drawing.Color.FromArgb(CType(178, System.Byte), CType(219, System.Byte), CType(37, System.Byte), CType(23, System.Byte))
        ' 
        ' areaSeries1.Gradient
        ' 
        Me.areaSeries1.AreaBrush.Gradient.Transparency = 30
        ' 
        ' areaSeries1.AreaLines
        ' 
        Me.areaSeries1.AreaLines.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(128, System.Byte), CType(64, System.Byte), CType(64, System.Byte))
        ' 
        ' areaSeries1.Brush
        ' 
        Me.areaSeries1.Brush.Color = System.Drawing.Color.FromArgb(CType(178, System.Byte), CType(219, System.Byte), CType(37, System.Byte), CType(23, System.Byte))
        ' 
        ' areaSeries1.TopGradient
        ' 
        Me.areaSeries1.Brush.Gradient.Transparency = 30
        ' 
        ' areaSeries1.Gradient
        ' 
        Me.areaSeries1.Gradient.Transparency = 30
        ' 
        ' areaSeries1.LinePen
        ' 
        Me.areaSeries1.LinePen.Visible = False
        ' 
        ' areaSeries1.Marks
        ' 
        ' 
        ' areaSeries1.Marks.Symbol
        ' 
        ' 
        ' areaSeries1.Marks.Symbol.Shadow
        ' 
        Me.areaSeries1.Marks.Symbol.Shadow.Height = 1
        Me.areaSeries1.Marks.Symbol.Shadow.Visible = True
        Me.areaSeries1.Marks.Symbol.Shadow.Width = 1
        ' 
        ' areaSeries1.Pointer
        ' 
        ' 
        ' areaSeries1.Pointer.Brush
        ' 
        Me.areaSeries1.Pointer.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(0, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        Me.areaSeries1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.areaSeries1.Title = "areaSeries1"
        ' 
        ' areaSeries1.TopGradient
        ' 
        Me.areaSeries1.TopGradient.Transparency = 30
        ' 
        ' areaSeries1.XValues
        ' 
        Me.areaSeries1.XValues.DataMember = "X"
        Me.areaSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' areaSeries1.YValues
        ' 
        Me.areaSeries1.YValues.DataMember = "Y"
        ' 
        ' areaSeries2
        ' 
        ' 
        ' areaSeries2.AreaBrush
        ' 
        Me.areaSeries2.AreaBrush.Color = System.Drawing.Color.FromArgb(CType(178, System.Byte), CType(1, System.Byte), CType(43, System.Byte), CType(81, System.Byte))
        ' 
        ' areaSeries2.Gradient
        ' 
        Me.areaSeries2.AreaBrush.Gradient.Transparency = 30
        ' 
        ' areaSeries2.AreaLines
        ' 
        Me.areaSeries2.AreaLines.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(0, System.Byte), CType(0, System.Byte), CType(64, System.Byte))
        ' 
        ' areaSeries2.Brush
        ' 
        Me.areaSeries2.Brush.Color = System.Drawing.Color.FromArgb(CType(178, System.Byte), CType(1, System.Byte), CType(43, System.Byte), CType(81, System.Byte))
        ' 
        ' areaSeries2.TopGradient
        ' 
        Me.areaSeries2.Brush.Gradient.Transparency = 30
        ' 
        ' areaSeries2.Gradient
        ' 
        Me.areaSeries2.Gradient.Transparency = 30
        ' 
        ' areaSeries2.LinePen
        ' 
        Me.areaSeries2.LinePen.Visible = False
        ' 
        ' areaSeries2.Marks
        ' 
        ' 
        ' areaSeries2.Marks.Symbol
        ' 
        ' 
        ' areaSeries2.Marks.Symbol.Shadow
        ' 
        Me.areaSeries2.Marks.Symbol.Shadow.Height = 1
        Me.areaSeries2.Marks.Symbol.Shadow.Visible = True
        Me.areaSeries2.Marks.Symbol.Shadow.Width = 1
        ' 
        ' areaSeries2.Pointer
        ' 
        ' 
        ' areaSeries2.Pointer.Brush
        ' 
        Me.areaSeries2.Pointer.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(0, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        Me.areaSeries2.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.areaSeries2.Title = "areaSeries2"
        ' 
        ' areaSeries2.TopGradient
        ' 
        Me.areaSeries2.TopGradient.Transparency = 30
        ' 
        ' areaSeries2.XValues
        ' 
        Me.areaSeries2.XValues.DataMember = "X"
        Me.areaSeries2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' areaSeries2.YValues
        ' 
        Me.areaSeries2.YValues.DataMember = "Y"
        ' 
        ' areaSeries3
        ' 
        ' 
        ' areaSeries3.AreaBrush
        ' 
        Me.areaSeries3.AreaBrush.Color = System.Drawing.Color.FromArgb(CType(178, System.Byte), CType(255, System.Byte), CType(234, System.Byte), CType(88, System.Byte))
        ' 
        ' areaSeries3.Gradient
        ' 
        Me.areaSeries3.AreaBrush.Gradient.Transparency = 30
        ' 
        ' areaSeries3.AreaLines
        ' 
        Me.areaSeries3.AreaLines.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(64, System.Byte), CType(64, System.Byte), CType(0, System.Byte))
        ' 
        ' areaSeries3.Brush
        ' 
        Me.areaSeries3.Brush.Color = System.Drawing.Color.FromArgb(CType(178, System.Byte), CType(255, System.Byte), CType(234, System.Byte), CType(88, System.Byte))
        ' 
        ' areaSeries3.TopGradient
        ' 
        Me.areaSeries3.Brush.Gradient.Transparency = 30
        ' 
        ' areaSeries3.Gradient
        ' 
        Me.areaSeries3.Gradient.Transparency = 30
        ' 
        ' areaSeries3.LinePen
        ' 
        Me.areaSeries3.LinePen.Visible = False
        ' 
        ' areaSeries3.Marks
        ' 
        ' 
        ' areaSeries3.Marks.Symbol
        ' 
        ' 
        ' areaSeries3.Marks.Symbol.Shadow
        ' 
        Me.areaSeries3.Marks.Symbol.Shadow.Height = 1
        Me.areaSeries3.Marks.Symbol.Shadow.Visible = True
        Me.areaSeries3.Marks.Symbol.Shadow.Width = 1
        ' 
        ' areaSeries3.Pointer
        ' 
        ' 
        ' areaSeries3.Pointer.Brush
        ' 
        Me.areaSeries3.Pointer.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(0, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        Me.areaSeries3.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.areaSeries3.Title = "areaSeries3"
        ' 
        ' areaSeries3.TopGradient
        ' 
        Me.areaSeries3.TopGradient.Transparency = 30
        ' 
        ' areaSeries3.XValues
        ' 
        Me.areaSeries3.XValues.DataMember = "X"
        Me.areaSeries3.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' areaSeries3.YValues
        ' 
        Me.areaSeries3.YValues.DataMember = "Y"
        ' 
        ' checkBox1
        ' 
        Me.checkBox1.Checked = True
        Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox1.Location = New System.Drawing.Point(13, 7)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(94, 21)
        Me.checkBox1.TabIndex = 0
        Me.checkBox1.Text = "&Transparency"
        ' 
        ' hScrollBar1
        ' 
        Me.hScrollBar1.Location = New System.Drawing.Point(120, 10)
        Me.hScrollBar1.Name = "hScrollBar1"
        Me.hScrollBar1.Size = New System.Drawing.Size(100, 14)
        Me.hScrollBar1.TabIndex = 1
        Me.hScrollBar1.Value = 30
        ' 
        ' hScrollBar2
        ' 
        Me.hScrollBar2.Location = New System.Drawing.Point(232, 10)
        Me.hScrollBar2.Name = "hScrollBar2"
        Me.hScrollBar2.Size = New System.Drawing.Size(100, 14)
        Me.hScrollBar2.TabIndex = 2
        Me.hScrollBar2.Value = 30
        ' 
        ' hScrollBar3
        ' 
        Me.hScrollBar3.Location = New System.Drawing.Point(333, 10)
        Me.hScrollBar3.Name = "hScrollBar3"
        Me.hScrollBar3.Size = New System.Drawing.Size(100, 14)
        Me.hScrollBar3.TabIndex = 3
        Me.hScrollBar3.Value = 30
        ' 
        ' Area_Transparency
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(466, 286)
        Me.Name = "Area_Transparency"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub 'InitializeComponent 
#End Region


    Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox1.CheckedChanged
        If Me.checkBox1.Checked Then
            Me.areaSeries1.Transparency = Fix(Me.hScrollBar1.Value)
            Me.areaSeries2.Transparency = Fix(Me.hScrollBar2.Value)
            Me.areaSeries3.Transparency = Fix(Me.hScrollBar3.Value)

        Else

            For Each s As Steema.TeeChart.Styles.Area In Me.tChart1.Series
                s.Transparency = 0
            Next s
        End If
    End Sub 'checkBox1_CheckedChanged

    Private Sub hScrollBar1_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles hScrollBar1.ValueChanged
        Me.areaSeries1.Transparency = Fix(Me.hScrollBar1.Value)
    End Sub 'hScrollBar1_ValueChanged


    Private Sub hScrollBar2_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles hScrollBar2.ValueChanged
        Me.areaSeries2.Transparency = Fix(Me.hScrollBar2.Value)
    End Sub 'hScrollBar2_ValueChanged


    Private Sub hScrollBar3_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles hScrollBar3.ValueChanged
        Me.areaSeries3.Transparency = Fix(Me.hScrollBar3.Value)
    End Sub 'hScrollBar3_ValueChanged


    Private Sub hScrollBar1_Scroll(ByVal sender As Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles hScrollBar1.Scroll
    End Sub 'hScrollBar1_Scroll
End Class 'Area_Transparency 
