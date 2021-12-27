#If VS2005 Then
Imports System.Collections.Generic
#End If
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Public Class Pie_MarksVertCenter
    Inherits Samples.BaseForm
    Public Sub New()
        InitializeComponent()
        pie1.FillSampleValues(6)
    End Sub

    Private checkBox1 As CheckBox
    Private hScrollBar1 As HScrollBar
    Private label1 As Label

    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub 'Dispose

#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Pie_MarksVertCenter))
        Me.pie1 = New Steema.TeeChart.Styles.Pie()
        Me.checkBox1 = New System.Windows.Forms.CheckBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.hScrollBar1 = New System.Windows.Forms.HScrollBar()
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
        Me.panel1.Controls.Add(Me.hScrollBar1)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Controls.Add(Me.checkBox1)
        ' 
        ' tChart1
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Aspect.ColorPaletteIndex = 9
        Me.tChart1.Aspect.Elevation = 315
        Me.tChart1.Aspect.ElevationFloat = 315
        Me.tChart1.Aspect.Orthogonal = False
        Me.tChart1.Aspect.Perspective = 0
        Me.tChart1.Aspect.Rotation = 360
        Me.tChart1.Aspect.RotationFloat = 360
        Me.tChart1.Aspect.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Legend.Title.Pen.Visible = False
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(CInt(CByte(254)), CInt(CByte(21)), CInt(CByte(60)), CInt(CByte(89)))
        Me.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CInt(CByte(254)), CInt(CByte(255)), CInt(CByte(255)), CInt(CByte(255)))
        Me.tChart1.Panel.Brush.Gradient.Sigma = True
        Me.tChart1.Panel.Brush.Gradient.SigmaFocus = 1.0F
        Me.tChart1.Panel.Brush.Gradient.SigmaScale = 0.8F
        Me.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CInt(CByte(254)), CInt(CByte(255)), CInt(CByte(255)), CInt(CByte(255)))
        Me.tChart1.Series.Add(Me.pie1)
        Me.tChart1.Size = New System.Drawing.Size(440, 205)
        ' 
        ' pie1
        ' 
        ' 
        ' 
        ' 
        Me.pie1.Brush.Color = System.Drawing.Color.FromArgb(CInt(CByte(151)), CInt(CByte(116)), CInt(CByte(0)))
        Me.pie1.LabelMember = "Labels"
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.pie1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None
        Me.pie1.Marks.Callout.ArrowHeadSize = 8
        ' 
        ' 
        ' 
        Me.pie1.Marks.Callout.Brush.Color = System.Drawing.Color.Black
        Me.pie1.Marks.Callout.Distance = 0
        Me.pie1.Marks.Callout.Draw3D = False
        Me.pie1.Marks.Callout.Length = 8
        Me.pie1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        ' 
        ' 
        ' 
        Me.pie1.MarksPie.LegSize = 10
        Me.pie1.MarksPie.VertCenter = True
        Me.pie1.MultiPie = Steema.TeeChart.Styles.MultiPies.Automatic
        ' 
        ' 
        ' 
        Me.pie1.Shadow.Height = 20
        Me.pie1.Shadow.Width = 20
        Me.pie1.Title = "pie1"
        ' 
        ' 
        ' 
        Me.pie1.XValues.DataMember = "Angle"
        Me.pie1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' 
        ' 
        Me.pie1.YValues.DataMember = "Pie"
        ' 
        ' checkBox1
        ' 
        Me.checkBox1.Checked = True
        Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox1.Location = New System.Drawing.Point(12, 16)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(91, 17)
        Me.checkBox1.TabIndex = 0
        Me.checkBox1.Text = "Vertical center"
#If VS2005 Then
        Me.checkBox1.AutoSize = True
        Me.checkBox1.UseVisualStyleBackColor = True
#End If
        AddHandler Me.checkBox1.CheckedChanged, AddressOf Me.checkBox1_CheckedChanged
        ' label1
        ' 
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(137, 18)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(49, 13)
        Me.label1.TabIndex = 1
        Me.label1.Text = "Leg size:"
        ' 
        ' hScrollBar1
        ' 
        Me.hScrollBar1.Location = New System.Drawing.Point(189, 16)
        Me.hScrollBar1.Name = "hScrollBar1"
        Me.hScrollBar1.Size = New System.Drawing.Size(142, 17)
        Me.hScrollBar1.TabIndex = 2
        Me.hScrollBar1.Value = 10
        AddHandler Me.hScrollBar1.Scroll, AddressOf hScrollBar1_Scroll
        ' 
        ' Pie_MarksVertCenter
        ' 
        Me.ClientSize = New System.Drawing.Size(440, 317)
        Me.Name = "Pie_MarksVertCenter"
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.chartContainer.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
#End Region
    Private pie1 As Steema.TeeChart.Styles.Pie
    Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
        pie1.MarksPie.VertCenter = checkBox1.Checked
    End Sub
    Private Sub hScrollBar1_Scroll(ByVal sender As Object, ByVal e As ScrollEventArgs)
        pie1.MarksPie.LegSize = hScrollBar1.Value
    End Sub
End Class

