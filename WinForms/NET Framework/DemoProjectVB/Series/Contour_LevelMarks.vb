
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing

Imports System.Windows.Forms



Public Class Contour_LevelMarks
    Inherits Samples.BaseForm

    '/ <summary>
    '/ Required designer variable.
    '/ </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    Private contour1 As Styles.Contour
    Public Sub New() ' me call is required by the Windows Form Designer.
        InitializeComponent()
        contour1 = New Steema.TeeChart.Styles.Contour(tChart1.Chart)
        ' Marks are supported only when segments are used, so ...
        contour1.DrawingAlgorithm = Steema.TeeChart.Styles.ContourConstruction.Segments
        contour1.FillSampleValues(20)
        contour1.UseColorRange = True
        contour1.UsePalette = False
        contour1.ContourMarks.Visible = True
        contour1.ColorEach = False
        tChart1.Series.Add(contour1)
    End Sub

    Private WithEvents checkBox1 As CheckBox
    Private WithEvents numericUpDown1 As NumericUpDown
    Private label1 As Label
    Private WithEvents numericUpDown2 As NumericUpDown
    Private label2 As Label
    Private WithEvents checkBox2 As CheckBox
    Private WithEvents checkBox3 As CheckBox
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
        Me.checkBox1 = New System.Windows.Forms.CheckBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.numericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.label2 = New System.Windows.Forms.Label()
        Me.numericUpDown2 = New System.Windows.Forms.NumericUpDown()
        Me.checkBox2 = New System.Windows.Forms.CheckBox()
        Me.checkBox3 = New System.Windows.Forms.CheckBox()
        Me.panel1.SuspendLayout()
        Me.chartContainer.SuspendLayout()
        CType((Me.numericUpDown1), System.ComponentModel.ISupportInitialize).BeginInit()
        CType((Me.numericUpDown2), System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Text = "Contour series now supports contour level marks." & vbCrLf & "Level marks are fully controlab" + _
        "le via the Contour.ContourMarks class."
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.checkBox3)
        Me.panel1.Controls.Add(Me.checkBox2)
        Me.panel1.Controls.Add(Me.numericUpDown2)
        Me.panel1.Controls.Add(Me.label2)
        Me.panel1.Controls.Add(Me.numericUpDown1)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Controls.Add(Me.checkBox1)
        Me.panel1.Size = New System.Drawing.Size(440, 57)
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
        Me.tChart1.Axes.Depth.AxisPen.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tChart1.Axes.DepthTop.AxisPen.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tChart1.Axes.Left.AxisPen.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tChart1.Axes.Right.AxisPen.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tChart1.Axes.Top.AxisPen.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tChart1.Header.Font.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tChart1.Header.Lines = New String() { _
        "Contour Level Marks"}
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
        Me.tChart1.Size = New System.Drawing.Size(440, 187)
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
        Me.tChart1.Walls.Back.Brush.Gradient.MiddleColor = System.Drawing.Color.Empty
        Me.tChart1.Walls.Back.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.tChart1.Walls.Back.Brush.Gradient.Visible = True
        Me.tChart1.Walls.Back.Brush.Visible = True
        Me.tChart1.Walls.Back.Transparent = False
        ' 
        ' chartContainer
        ' 
        Me.chartContainer.Location = New System.Drawing.Point(0, 130)
        Me.chartContainer.Size = New System.Drawing.Size(440, 187)
        ' 
        ' checkBox1
        ' 
#If VS2005 Then
            me.checkBox1.AutoSize = true 
#End If
        Me.checkBox1.Checked = True
        Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox1.Location = New System.Drawing.Point(12, 16)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(80, 17)
        Me.checkBox1.TabIndex = 0
        Me.checkBox1.Text = "Level marks"
#If VS2005 Then
            me.checkBox1.UseVisualStyleBackColor = true 
#End If
        ' 
        ' label1
        ' 
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(113, 8)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(42, 13)
        Me.label1.TabIndex = 1
        Me.label1.Text = "Density"
        ' 
        ' numericUpDown1
        ' 
        Me.numericUpDown1.Location = New System.Drawing.Point(161, 6)
        Me.numericUpDown1.Minimum = New Decimal(New Integer() { _
        1, _
        0, _
        0, _
        0})
        Me.numericUpDown1.Name = "numericUpDown1"
        Me.numericUpDown1.Size = New System.Drawing.Size(58, 20)
        Me.numericUpDown1.TabIndex = 2
        Me.numericUpDown1.Value = New Decimal(New Integer() { _
        4, _
        0, _
        0, _
        0})
        ' 
        ' label2
        ' 
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(117, 34)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(38, 13)
        Me.label2.TabIndex = 3
        Me.label2.Text = "Levels"
        ' 
        ' numericUpDown2
        ' 
        Me.numericUpDown2.Location = New System.Drawing.Point(161, 32)
        Me.numericUpDown2.Minimum = New Decimal(New Integer() { _
        2, _
        0, _
        0, _
        0})
        Me.numericUpDown2.Name = "numericUpDown2"
        Me.numericUpDown2.Size = New System.Drawing.Size(46, 20)
        Me.numericUpDown2.TabIndex = 4
        Me.numericUpDown2.Value = New Decimal(New Integer() { _
        10, _
        0, _
        0, _
        0})
        ' 
        ' checkBox2
        ' 
#If VS2005 Then
            me.checkBox2.AutoSize = true 
#End If
        Me.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox2.Location = New System.Drawing.Point(252, 16)
        Me.checkBox2.Name = "checkBox2"
        Me.checkBox2.Size = New System.Drawing.Size(70, 17)
        Me.checkBox2.TabIndex = 5
        Me.checkBox2.Text = "Font color"
#If VS2005 Then
            me.checkBox2.UseVisualStyleBackColor = true 
#End If
        ' 
        ' checkBox3
        '
#If VS2005 Then
            me.checkBox3.AutoSize = true 
            me.checkBox3.UseVisualStyleBackColor = true 
#End If
        Me.checkBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox3.Location = New System.Drawing.Point(252, 35)
        Me.checkBox3.Name = "checkBox3"
        Me.checkBox3.Size = New System.Drawing.Size(79, 17)
        Me.checkBox3.TabIndex = 6
        Me.checkBox3.Text = "Anti overlap"
        ' 
        ' Contour_LevelMarks
        ' 
        Me.ClientSize = New System.Drawing.Size(440, 317)
        Me.Name = "Contour_LevelMarks"
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.chartContainer.ResumeLayout(False)
        CType((Me.numericUpDown1), System.ComponentModel.ISupportInitialize).EndInit()
        CType((Me.numericUpDown2), System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox1.CheckedChanged
        If Not contour1 Is Nothing Then
            contour1.ContourMarks.Visible = checkBox1.Checked
        End If
    End Sub

    Private Sub numericUpDown1_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles numericUpDown1.ValueChanged
        If Not contour1 Is Nothing Then
            contour1.ContourMarks.Density = CInt(numericUpDown1.Value)
        End If
    End Sub

    Private Sub numericUpDown2_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles numericUpDown2.ValueChanged
        If Not contour1 Is Nothing Then
            contour1.NumLevels = CInt(numericUpDown2.Value)
        End If
    End Sub

    Private Sub checkBox2_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox2.CheckedChanged
        If Not contour1 Is Nothing Then
            contour1.ContourMarks.ColorLevel = checkBox2.Checked
        End If
    End Sub

    Private Sub checkBox3_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox3.CheckedChanged
        If Not contour1 Is Nothing Then
            contour1.ContourMarks.AntiOverlap = checkBox3.Checked
        End If
    End Sub

End Class

