
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing

Imports System.Windows.Forms




Public Class Canvas_180Rotation
    Inherits Samples.BaseForm
    Private WithEvents hScrollBar2 As System.Windows.Forms.HScrollBar
    Private label1 As System.Windows.Forms.Label
    Private label2 As System.Windows.Forms.Label
    Private bar1 As Steema.TeeChart.Styles.Bar
    Private components As System.ComponentModel.IContainer = Nothing
    
    
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        
        bar1.FillSampleValues(4)
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Canvas_180Rotation))
        Me.hScrollBar2 = New System.Windows.Forms.HScrollBar
        Me.label1 = New System.Windows.Forms.Label
        Me.label2 = New System.Windows.Forms.Label
        Me.bar1 = New Steema.TeeChart.Styles.Bar
        Me.panel1.SuspendLayout()
        Me.chartContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'textBox1
        '
        Me.textBox1.Size = New System.Drawing.Size(432, 72)
        Me.textBox1.TabIndex = 0
        Me.textBox1.Text = "Chart can be rotated 180 degrees along the horizontal (x) axis." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "In previous vers" & _
            "ions it allowed 90 degree rotation only." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Using OpenGL charts can be fully rotat" & _
            "ed 360 degree."
        '
        'panel1
        '
        Me.panel1.Controls.Add(Me.label2)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Controls.Add(Me.hScrollBar2)
        Me.panel1.Location = New System.Drawing.Point(0, 72)
        Me.panel1.Size = New System.Drawing.Size(432, 33)
        Me.panel1.TabIndex = 1
        '
        'tChart1
        '
        '
        '
        '
        Me.tChart1.Aspect.Chart3DPercent = 25
        Me.tChart1.Aspect.Elevation = 356
        Me.tChart1.Aspect.ElevationFloat = 356
        Me.tChart1.Aspect.Orthogonal = False
        Me.tChart1.Aspect.Perspective = 75
        Me.tChart1.Aspect.Rotation = 360
        Me.tChart1.Aspect.RotationFloat = 360
        Me.tChart1.Aspect.ZOffset = 0
        '
        '
        '
        '
        '
        '
        Me.tChart1.Axes.Bottom.MaximumOffset = 30
        Me.tChart1.Axes.Bottom.MinimumOffset = 30
        '
        '
        '
        Me.tChart1.Axes.Bottom.Title.Transparent = True
        '
        '
        '
        '
        '
        '
        Me.tChart1.Axes.Depth.Title.Transparent = True
        '
        '
        '
        '
        '
        '
        Me.tChart1.Axes.DepthTop.Title.Transparent = True
        '
        '
        '
        Me.tChart1.Axes.Left.MaximumOffset = 37
        '
        '
        '
        Me.tChart1.Axes.Left.Title.Transparent = True
        '
        '
        '
        '
        '
        '
        Me.tChart1.Axes.Right.Title.Transparent = True
        '
        '
        '
        '
        '
        '
        Me.tChart1.Axes.Top.Title.Transparent = True
        '
        '
        '
        Me.tChart1.Header.Lines = New String() {"tChart1"}
        Me.tChart1.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        '
        '
        '
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tChart1.Series.Add(Me.bar1)
        Me.tChart1.Size = New System.Drawing.Size(432, 212)
        Me.tChart1.TabIndex = 2
        '
        '
        '
        '
        '
        '
        Me.tChart1.Walls.Bottom.Size = 5
        '
        '
        '
        '
        '
        '
        Me.tChart1.Walls.Left.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tChart1.Walls.Left.Size = 10
        '
        '
        '
        '
        '
        '
        Me.tChart1.Walls.Right.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tChart1.Walls.Right.Size = 10
        Me.tChart1.Walls.Right.Visible = True
        '
        'chartContainer
        '
        Me.chartContainer.Location = New System.Drawing.Point(0, 105)
        Me.chartContainer.Size = New System.Drawing.Size(432, 212)
        '
        'hScrollBar2
        '
        Me.hScrollBar2.LargeChange = 1
        Me.hScrollBar2.Location = New System.Drawing.Point(131, 10)
        Me.hScrollBar2.Maximum = 180
        Me.hScrollBar2.Name = "hScrollBar2"
        Me.hScrollBar2.Size = New System.Drawing.Size(134, 14)
        Me.hScrollBar2.TabIndex = 3
        Me.hScrollBar2.Value = 90
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(52, 10)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(79, 13)
        Me.label1.TabIndex = 0
        Me.label1.Text = "&Rotation angle:"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(272, 10)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(25, 13)
        Me.label2.TabIndex = 2
        Me.label2.Text = "360"
        Me.label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'bar1
        '
        '
        '
        '
        Me.bar1.Brush.Color = System.Drawing.Color.Red
        '
        '
        '
        Me.bar1.Brush.Gradient.EndColor = System.Drawing.Color.Red
        Me.bar1.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.bar1.Brush.Gradient.Visible = True
        Me.bar1.Color = System.Drawing.Color.Red
        Me.bar1.ColorEach = False
        '
        '
        '
        '
        '
        '
        Me.bar1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None
        Me.bar1.Marks.Callout.ArrowHeadSize = 8
        '
        '
        '
        Me.bar1.Marks.Callout.Brush.Color = System.Drawing.Color.Black
        Me.bar1.Marks.Callout.Distance = 0
        Me.bar1.Marks.Callout.Draw3D = False
        Me.bar1.Marks.Callout.Length = 20
        Me.bar1.Marks.Callout.Series = Me.bar1
        Me.bar1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.bar1.Marks.Callout.Visible = False
        Me.bar1.Marks.Series = Me.bar1
        Me.bar1.Title = "bar1"
        '
        '
        '
        Me.bar1.XValues.DataMember = "X"
        Me.bar1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        '
        '
        '
        Me.bar1.YValues.DataMember = "Bar"
        '
        'Canvas_180Rotation
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(432, 317)
        Me.Name = "Canvas_180Rotation"
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.chartContainer.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub 'InitializeComponent 
#End Region


    Private Sub hScrollBar2_Scroll(ByVal sender As Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles hScrollBar2.Scroll
        If hScrollBar2.Value < 90 Then
            tChart1.Aspect.Rotation = 270 + hScrollBar2.Value
        Else
            tChart1.Aspect.Rotation = hScrollBar2.Value - 90
        End If
        label2.Text = tChart1.Aspect.Rotation.ToString()
    End Sub 'hScrollBar2_Scroll
End Class 'Canvas_180Rotation
