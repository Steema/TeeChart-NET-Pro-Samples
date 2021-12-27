
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing

Imports System.Windows.Forms



Public Class Tool_RotateRotating
    Inherits Samples.BaseForm

    '/ <summary>
    '/ Required designer variable.
    '/ </summary>
    Private components As System.ComponentModel.IContainer = Nothing


    Public Sub New() ' me call is required by the Windows Form Designer.
        InitializeComponent()
        InitializeChart()
    End Sub

    Private Sub InitializeChart()
        tower1.FillSampleValues()
        label1.Text = "Rotation: " + tChart1.Aspect.Rotation.ToString()
    End Sub

    Private label1 As Label
    Private tower1 As Steema.TeeChart.Styles.Tower
    Private WithEvents rotate1 As Steema.TeeChart.Tools.Rotate
    Private lRotation As Label
    Private WithEvents numericUpDown1 As NumericUpDown
    Private label2 As Label
    Private WithEvents hScrollBar1 As HScrollBar
    Private label3 As Label


    Private Sub rotate1_Rotating(ByVal sender As Object, ByVal e As EventArgs) Handles rotate1.Rotating
        label1.Text = "Rotation: " + tChart1.Aspect.Rotation.ToString()
    End Sub

    Private Sub numericUpDown1_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles numericUpDown1.ValueChanged
        rotate1.Speed = Convert.ToInt32(numericUpDown1.Value)
    End Sub

    Private Sub hScrollBar1_Scroll(ByVal sender As Object, ByVal e As ScrollEventArgs) Handles hScrollBar1.Scroll
        rotate1.Inertia = hScrollBar1.Value
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
    '/ the contents of me method with the code editor.
    '/ </summary>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Tool_RotateRotating))
        Me.tower1 = New Steema.TeeChart.Styles.Tower()
        Me.rotate1 = New Steema.TeeChart.Tools.Rotate()
        Me.label1 = New System.Windows.Forms.Label()
        Me.lRotation = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.numericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.label3 = New System.Windows.Forms.Label()
        Me.hScrollBar1 = New System.Windows.Forms.HScrollBar()
        Me.panel1.SuspendLayout()
        Me.chartContainer.SuspendLayout()
        CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Text = "The RotateTool now has been enhanced with a new Rotate event + Speed and Inertia " + _
            "properties."
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.hScrollBar1)
        Me.panel1.Controls.Add(Me.label3)
        Me.panel1.Controls.Add(Me.numericUpDown1)
        Me.panel1.Controls.Add(Me.label2)
        Me.panel1.Controls.Add(Me.lRotation)
        Me.panel1.Controls.Add(Me.label1)
        ' 
        ' tChart1
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Aspect.Chart3DPercent = 25
        Me.tChart1.Aspect.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
        Me.tChart1.Aspect.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias
        Me.tChart1.Header.Lines = New String() { _
        "RotateTool Rotate/Speed"}
        Me.tChart1.Legend.MaxNumRows = 8
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Legend.Visible = False
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
        Me.tChart1.Series.Add(Me.tower1)
        Me.tChart1.Size = New System.Drawing.Size(440, 205)
        Me.tChart1.Tools.Add(Me.rotate1)
        ' 
        ' tower1
        ' 
        ' 
        ' 
        ' 
        Me.tower1.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.tower1.ColorEach = False
        Me.tower1.DefaultNullValue = 0
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tower1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None
        Me.tower1.Marks.Callout.ArrowHeadSize = 8
        ' 
        ' 
        ' 
        Me.tower1.Marks.Callout.Brush.Color = System.Drawing.Color.Black
        Me.tower1.Marks.Callout.Distance = 0
        Me.tower1.Marks.Callout.Draw3D = False
        Me.tower1.Marks.Callout.Length = 10
        Me.tower1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        ' 
        ' 
        ' 
        Me.tower1.Origin = 0
        Me.tower1.PaletteMin = 0
        Me.tower1.PaletteStep = 0
        Me.tower1.PaletteStyle = Steema.TeeChart.Styles.PaletteStyles.Strong
        Me.tower1.Title = "tower1"
        Me.tower1.UseColorRange = False
        Me.tower1.UsePalette = True
        ' 
        ' 
        ' 
        Me.tower1.XValues.DataMember = "X"
        ' 
        ' 
        ' 
        Me.tower1.YValues.DataMember = "Y"
        ' 
        ' 
        ' 
        Me.tower1.ZValues.DataMember = "Z"
        '
        ' label1
        ' 
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(12, 14)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(50, 13)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Rotation:"
        ' 
        ' lRotation
        ' 
        Me.lRotation.AutoSize = True
        Me.lRotation.Location = New System.Drawing.Point(62, 14)
        Me.lRotation.Name = "lRotation"
        Me.lRotation.Size = New System.Drawing.Size(0, 13)
        Me.lRotation.TabIndex = 1
        ' 
        ' label2
        ' 
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(134, 14)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(41, 13)
        Me.label2.TabIndex = 2
        Me.label2.Text = "Speed:"
        ' 
        ' numericUpDown1
        ' 
        Me.numericUpDown1.Location = New System.Drawing.Point(181, 12)
        Me.numericUpDown1.Name = "numericUpDown1"
        Me.numericUpDown1.Size = New System.Drawing.Size(45, 20)
        Me.numericUpDown1.TabIndex = 3
        Me.numericUpDown1.Value = New Decimal(New Integer() { _
            50, _
            0, _
            0, _
            0})
        ' 
        ' label3
        ' 
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(258, 14)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(36, 13)
        Me.label3.TabIndex = 4
        Me.label3.Text = "Inertia"
        ' 
        ' hScrollBar1
        ' 
        Me.hScrollBar1.Location = New System.Drawing.Point(297, 10)
        Me.hScrollBar1.Name = "hScrollBar1"
        Me.hScrollBar1.Size = New System.Drawing.Size(118, 17)
        Me.hScrollBar1.TabIndex = 5
        ' 
        ' Tool_RotateRotating
        ' 
#If VS2005 Then
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
#End If
        Me.ClientSize = New System.Drawing.Size(440, 317)
        Me.Name = "Tool_RotateRotating"
        Me.Text = "Tool_RotateRotating"
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.chartContainer.ResumeLayout(False)
        CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

#End Region

End Class

