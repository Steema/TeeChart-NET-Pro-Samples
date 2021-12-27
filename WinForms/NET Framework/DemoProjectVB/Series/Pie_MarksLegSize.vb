Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Public Class Pie_MarksLegSize
    Inherits Samples.BaseForm
    Public Sub New()
        InitializeComponent()
        pie1.FillSampleValues(5)
        pie1.MarksPie.LegSize = 10
    End Sub
    Private pie1 As Steema.TeeChart.Styles.Pie
    Private trackBar1 As TrackBar
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
        Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Pie_MarksLegSize))
        Me.pie1 = New Steema.TeeChart.Styles.Pie()
        Me.label1 = New System.Windows.Forms.Label()
        Me.trackBar1 = New System.Windows.Forms.TrackBar()
        Me.panel1.SuspendLayout()
        Me.chartContainer.SuspendLayout()
        DirectCast(Me.trackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Text = "Pie series marks can optionally display lines from the mark rectangle to the Pie " & "slice with a ""L"" shape of predefined size:" & vbCr & vbLf & vbCr & vbLf & "pie1.MarksPie.LegSize = 25"
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.trackBar1)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Size = New System.Drawing.Size(440, 52)
        ' 
        ' tChart1
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Aspect.ColorPaletteIndex = 5
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
        Me.tChart1.Size = New System.Drawing.Size(440, 192)
        ' 
        ' chartContainer
        ' 
        Me.chartContainer.Location = New System.Drawing.Point(0, 125)
        Me.chartContainer.Size = New System.Drawing.Size(440, 192)
        ' 
        ' pie1
        ' 
        ' 
        ' 
        ' 
        Me.pie1.Brush.Color = System.Drawing.Color.FromArgb(CInt(CByte(0)), CInt(CByte(96)), CInt(CByte(0)))
        Me.pie1.Circled = True
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
        Me.pie1.MarksPie.LegSize = 0
        Me.pie1.MarksPie.VertCenter = False
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
        ' label1
        ' 
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(12, 17)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(49, 13)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Leg size:"
        ' 
        ' trackBar1
        ' 
        Me.trackBar1.AutoSize = False
        Me.trackBar1.Location = New System.Drawing.Point(67, 17)
        Me.trackBar1.Maximum = 100
        Me.trackBar1.Name = "trackBar1"
        Me.trackBar1.Size = New System.Drawing.Size(173, 29)
        Me.trackBar1.TabIndex = 1
        Me.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None
        Me.trackBar1.Value = 10
        AddHandler Me.trackBar1.Scroll, AddressOf Me.trackBar1_Scroll
        ' 
        ' Pie_MarksLegSize
        ' 
        Me.ClientSize = New System.Drawing.Size(440, 317)
        Me.Name = "Pie_MarksLegSize"
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.chartContainer.ResumeLayout(False)
        DirectCast(Me.trackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Private Sub trackBar1_Scroll(ByVal sender As Object, ByVal e As EventArgs)
        pie1.MarksPie.LegSize = trackBar1.Value
    End Sub
End Class

