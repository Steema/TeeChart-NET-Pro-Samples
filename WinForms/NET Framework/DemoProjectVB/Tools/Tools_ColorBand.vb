
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing

Imports System.Windows.Forms




Public Class Tools_ColorBand
    Inherits Samples.BaseForm
    Private barSeries1 As Steema.TeeChart.Styles.Bar
    Private colorBand1 As Steema.TeeChart.Tools.ColorBand
    Private colorBand2 As Steema.TeeChart.Tools.ColorBand
    Private colorBand3 As Steema.TeeChart.Tools.ColorBand
    Private colorBand4 As Steema.TeeChart.Tools.ColorBand
    Private colorBand5 As Steema.TeeChart.Tools.ColorBand
    Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
    Private WithEvents checkBox2 As System.Windows.Forms.CheckBox
    Private WithEvents checkBox3 As System.Windows.Forms.CheckBox
    Private WithEvents checkBox4 As System.Windows.Forms.CheckBox
    Private components As System.ComponentModel.IContainer = Nothing
    
    
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        
        ' alternative method to add points
        barSeries1.Add(New Double(4) {30, 150, 75, 280, 600})
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
        Me.barSeries1 = New Steema.TeeChart.Styles.Bar
        Me.colorBand1 = New Steema.TeeChart.Tools.ColorBand
        Me.colorBand2 = New Steema.TeeChart.Tools.ColorBand
        Me.colorBand3 = New Steema.TeeChart.Tools.ColorBand
        Me.colorBand4 = New Steema.TeeChart.Tools.ColorBand
        Me.colorBand5 = New Steema.TeeChart.Tools.ColorBand
        Me.checkBox1 = New System.Windows.Forms.CheckBox
        Me.checkBox2 = New System.Windows.Forms.CheckBox
        Me.checkBox3 = New System.Windows.Forms.CheckBox
        Me.checkBox4 = New System.Windows.Forms.CheckBox
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(466, 63)
        Me.textBox1.Text = """Color Band"" tools are small objects that define a rectangular region. They can b" + "e associated to any axis (Left, Right, Top, Bottom, etc) and have Pen, Pattern a" + "nd Gradient attributes."
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.checkBox4)
        Me.panel1.Controls.Add(Me.checkBox3)
        Me.panel1.Controls.Add(Me.checkBox2)
        Me.panel1.Controls.Add(Me.checkBox1)
        Me.panel1.Location = New System.Drawing.Point(0, 63)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(466, 33)
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
        Me.tChart1.Location = New System.Drawing.Point(0, 96)
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Brush
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.tChart1.Series.Add(Me.barSeries1)
        Me.tChart1.Size = New System.Drawing.Size(466, 190)
        Me.tChart1.Tools.Add(Me.colorBand1)
        Me.tChart1.Tools.Add(Me.colorBand2)
        Me.tChart1.Tools.Add(Me.colorBand3)
        Me.tChart1.Tools.Add(Me.colorBand4)
        Me.tChart1.Tools.Add(Me.colorBand5)
        ' 
        ' barSeries1
        ' 
        ' 
        ' barSeries1.Brush
        ' 
        Me.barSeries1.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(210, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        ' 
        ' barSeries1.Marks
        ' 
        ' 
        ' barSeries1.Marks.Symbol
        ' 
        ' 
        ' barSeries1.Marks.Symbol.Shadow
        ' 
        Me.barSeries1.Marks.Symbol.Shadow.Height = 1
        Me.barSeries1.Marks.Symbol.Shadow.Visible = True
        Me.barSeries1.Marks.Symbol.Shadow.Width = 1
        ' 
        ' barSeries1.Pen
        ' 
        Me.barSeries1.Pen.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(126, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        Me.barSeries1.Title = "bar1"
        ' 
        ' barSeries1.XValues
        ' 
        Me.barSeries1.XValues.DataMember = "X"
        Me.barSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' barSeries1.YValues
        ' 
        Me.barSeries1.YValues.DataMember = "Bar"
        ' 
        ' colorBand1
        ' 
        Me.colorBand1.Axis = Me.tChart1.Axes.Left
        ' 
        ' colorBand1.Brush
        ' 
        Me.colorBand1.Brush.Color = System.Drawing.Color.FromArgb(CType(255, System.Byte), CType(128, System.Byte), CType(0, System.Byte))
        Me.colorBand1.End = 100
        Me.colorBand1.ResizeEnd = False
        Me.colorBand1.ResizeStart = False
        Me.colorBand1.Start = 0
        ' 
        ' colorBand2
        ' 
        Me.colorBand2.Axis = Me.tChart1.Axes.Left
        ' 
        ' colorBand2.Brush
        ' 
        Me.colorBand2.Brush.Color = System.Drawing.Color.FromArgb(CType(255, System.Byte), CType(192, System.Byte), CType(128, System.Byte))
        Me.colorBand2.End = 200
        Me.colorBand2.ResizeEnd = False
        Me.colorBand2.ResizeStart = False
        Me.colorBand2.Start = 100
        ' 
        ' colorBand3
        ' 
        Me.colorBand3.Axis = Me.tChart1.Axes.Left
        ' 
        ' colorBand3.Brush
        ' 
        Me.colorBand3.Brush.Color = System.Drawing.Color.FromArgb(CType(255, System.Byte), CType(224, System.Byte), CType(192, System.Byte))
        Me.colorBand3.Brush.Solid = False
        Me.colorBand3.End = 300
        Me.colorBand3.ResizeEnd = False
        Me.colorBand3.ResizeStart = False
        Me.colorBand3.Start = 200
        ' 
        ' colorBand4
        ' 
        Me.colorBand4.Axis = Me.tChart1.Axes.Left
        ' 
        ' colorBand4.Brush
        ' 
        Me.colorBand4.Brush.Color = System.Drawing.Color.Aqua
        Me.colorBand4.End = 400
        Me.colorBand4.ResizeEnd = False
        Me.colorBand4.ResizeStart = False
        Me.colorBand4.Start = 300
        ' 
        ' colorBand5
        ' 
        Me.colorBand5.Axis = Me.tChart1.Axes.Left
        ' 
        ' colorBand5.Brush
        ' 
        Me.colorBand5.Brush.Color = System.Drawing.Color.Lime
        Me.colorBand5.Brush.Solid = False
        Me.colorBand5.Brush.Style = System.Drawing.Drawing2D.HatchStyle.Percent40
        Me.colorBand5.End = 700
        Me.colorBand5.ResizeEnd = False
        Me.colorBand5.ResizeStart = False
        Me.colorBand5.Start = 500
        ' 
        ' checkBox1
        ' 
        Me.checkBox1.Checked = True
        Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox1.Location = New System.Drawing.Point(13, 7)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(99, 21)
        Me.checkBox1.TabIndex = 0
        Me.checkBox1.Text = "&Show bands"
        ' 
        ' checkBox2
        ' 
        Me.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox2.Location = New System.Drawing.Point(107, 7)
        Me.checkBox2.Name = "checkBox2"
        Me.checkBox2.Size = New System.Drawing.Size(80, 21)
        Me.checkBox2.TabIndex = 1
        Me.checkBox2.Text = "&Inverted"
        ' 
        ' checkBox3
        ' 
        Me.checkBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox3.Location = New System.Drawing.Point(187, 7)
        Me.checkBox3.Name = "checkBox3"
        Me.checkBox3.Size = New System.Drawing.Size(80, 21)
        Me.checkBox3.TabIndex = 2
        Me.checkBox3.Text = "&Gradient"
        ' 
        ' checkBox4
        ' 
        Me.checkBox4.Checked = True
        Me.checkBox4.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox4.Location = New System.Drawing.Point(273, 7)
        Me.checkBox4.Name = "checkBox4"
        Me.checkBox4.Size = New System.Drawing.Size(103, 21)
        Me.checkBox4.TabIndex = 3
        Me.checkBox4.Text = "&Draw behind"
        ' 
        ' Tool_ColorBand
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(466, 286)
        Me.Name = "Tool_ColorBand"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub 'InitializeComponent 
#End Region


    Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox1.CheckedChanged
        Me.colorBand1.Active = checkBox1.Checked
        Me.colorBand2.Active = checkBox1.Checked
        Me.colorBand3.Active = checkBox1.Checked
        Me.colorBand4.Active = checkBox1.Checked
        Me.colorBand5.Active = checkBox1.Checked
    End Sub 'checkBox1_CheckedChanged


    Private Sub checkBox2_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox2.CheckedChanged
        Me.tChart1.Axes.Left.Inverted = checkBox2.Checked
    End Sub 'checkBox2_CheckedChanged


    Private Sub checkBox3_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox3.CheckedChanged
        Me.colorBand3.Gradient.Visible = checkBox3.Checked
    End Sub 'checkBox3_CheckedChanged


    Private Sub checkBox4_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox4.CheckedChanged
        Me.colorBand1.DrawBehind = checkBox4.Checked
        Me.colorBand2.DrawBehind = checkBox4.Checked
        Me.colorBand3.DrawBehind = checkBox4.Checked
        Me.colorBand4.DrawBehind = checkBox4.Checked
        Me.colorBand5.DrawBehind = checkBox4.Checked
    End Sub 'checkBox4_CheckedChanged
End Class 'Tools_ColorBand
