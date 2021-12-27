
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing

Imports System.Windows.Forms



Public Class Contour_Pointer
    Inherits Samples.BaseForm

    '/ <summary>
    '/ Required designer variable.
    '/ </summary>
    Private components As System.ComponentModel.IContainer = Nothing


    Public Sub New() ' me call is required by the Windows Form Designer.
        InitializeComponent()
        ' Pointer is supported only when segments are used, so ...
        contour1.FillSampleValues(20)
        contour1.UseColorRange = False
        contour1.UsePalette = True
        contour1.Pointer.Visible = True
        contour1.Pen.Visible = False
        contour1.PaletteStyle = Steema.TeeChart.Styles.PaletteStyles.Rainbow
        contour1.ColorEach = False
        buttonPen1.Pen = contour1.Pen
    End Sub

    Private WithEvents checkBox1 As CheckBox
    Private WithEvents numericUpDown2 As NumericUpDown
    Private WithEvents numericUpDown1 As NumericUpDown
    Private label2 As Label
    Private label1 As Label
    Private buttonPen1 As ButtonPen
    Private contour1 As Steema.TeeChart.Styles.Contour
    Private index As Integer = -1

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Contour_Pointer))
        Me.checkBox1 = New System.Windows.Forms.CheckBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.numericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.numericUpDown2 = New System.Windows.Forms.NumericUpDown()
        Me.buttonPen1 = New Steema.TeeChart.ButtonPen()
        Me.contour1 = New Steema.TeeChart.Styles.Contour()
        Me.panel1.SuspendLayout()
        Me.chartContainer.SuspendLayout()
        CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Text = "Contour series now supports different pointer styles for level lines."
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.buttonPen1)
        Me.panel1.Controls.Add(Me.numericUpDown2)
        Me.panel1.Controls.Add(Me.numericUpDown1)
        Me.panel1.Controls.Add(Me.label2)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Controls.Add(Me.checkBox1)
        ' 
        ' tChart1
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Aspect.ColorPaletteIndex = 0
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
        Me.tChart1.Axes.Depth.AxisPen.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.DepthTop.AxisPen.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
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
        ' 
        ' 
        ' 
        Me.tChart1.Legend.MaxNumRows = 8
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
        Me.tChart1.Series.Add(Me.contour1)
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
        Me.tChart1.Walls.Back.Brush.Gradient.MiddleColor = System.Drawing.Color.Empty
        Me.tChart1.Walls.Back.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.tChart1.Walls.Back.Brush.Gradient.Visible = True
        Me.tChart1.Walls.Back.Brush.Visible = True
        Me.tChart1.Walls.Back.Transparent = False
        ' 
        ' checkBox1
        '
#If VS2005 Then
        Me.checkBox1.AutoSize = True
#End If
        Me.checkBox1.Checked = True
        Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox1.Location = New System.Drawing.Point(12, 16)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(88, 17)
        Me.checkBox1.TabIndex = 0
        Me.checkBox1.Text = "Pointer visible"
#If VS2005 Then
        Me.checkBox1.UseVisualStyleBackColor = True
#End If
        ' 
        ' label1
        ' 
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(121, 18)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(35, 13)
        Me.label1.TabIndex = 1
        Me.label1.Text = "Width"
        ' 
        ' label2
        ' 
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(232, 18)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(38, 13)
        Me.label2.TabIndex = 2
        Me.label2.Text = "Height"
        ' 
        ' numericUpDown1
        ' 
        Me.numericUpDown1.Location = New System.Drawing.Point(162, 16)
        Me.numericUpDown1.Maximum = New Decimal(New Integer() { _
        20, _
        0, _
        0, _
        0})
        Me.numericUpDown1.Minimum = New Decimal(New Integer() { _
        1, _
        0, _
        0, _
        0})
        Me.numericUpDown1.Name = "numericUpDown1"
        Me.numericUpDown1.Size = New System.Drawing.Size(47, 20)
        Me.numericUpDown1.TabIndex = 3
        Me.numericUpDown1.Value = New Decimal(New Integer() { _
        2, _
        0, _
        0, _
        0})

        ' 
        ' numericUpDown2
        ' 
        Me.numericUpDown2.Location = New System.Drawing.Point(276, 16)
        Me.numericUpDown2.Maximum = New Decimal(New Integer() { _
        20, _
        0, _
        0, _
        0})
        Me.numericUpDown2.Minimum = New Decimal(New Integer() { _
        1, _
         0, _
          0, _
    0})
        Me.numericUpDown2.Name = "numericUpDown2"
        Me.numericUpDown2.Size = New System.Drawing.Size(47, 20)
        Me.numericUpDown2.TabIndex = 4
        Me.numericUpDown2.Value = New Decimal(New Integer() { _
    2, _
    0, _
    0, _
    0})
      '
        ' buttonPen1
        ' 
        Me.buttonPen1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonPen1.Location = New System.Drawing.Point(347, 14)
        Me.buttonPen1.Name = "buttonPen1"
        Me.buttonPen1.Size = New System.Drawing.Size(81, 21)
        Me.buttonPen1.TabIndex = 5
        Me.buttonPen1.Text = "Pen ..."
#If VS2005 Then
        Me.buttonPen1.UseVisualStyleBackColor = True
#End If
        ' 
        ' contour1
        ' 
        ' 
        ' 
        ' 
        Me.contour1.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.contour1.ColorEach = False
        Me.contour1.DefaultNullValue = 0
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.contour1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None
        Me.contour1.Marks.Callout.ArrowHeadSize = 8
        ' 
        ' 
        ' 
        Me.contour1.Marks.Callout.Brush.Color = System.Drawing.Color.Black
        Me.contour1.Marks.Callout.Distance = 0
        Me.contour1.Marks.Callout.Draw3D = False
        Me.contour1.Marks.Callout.Length = 10
        Me.contour1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.contour1.Marks.Transparent = True
        Me.contour1.PaletteMin = 0
        Me.contour1.PaletteStep = 0
        Me.contour1.PaletteStyle = Steema.TeeChart.Styles.PaletteStyles.Pale
        ' 
        ' 
        ' 
        Me.contour1.Pointer.HorizSize = 2
        ' 
        ' 
        ' 
        Me.contour1.Pointer.Pen.Visible = False
        Me.contour1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.contour1.Pointer.VertSize = 2
        Me.contour1.Title = "contour1"
        ' 
        ' 
        ' 
        Me.contour1.XValues.DataMember = "X"
        Me.contour1.YPosition = 0.18959828428699516
        ' 
        ' 
        ' 
        Me.contour1.YValues.DataMember = "Y"
        ' 
        ' 
        ' 
        Me.contour1.ZValues.DataMember = "Z"
        ' 
        ' Contour_Pointer
        ' 
        Me.ClientSize = New System.Drawing.Size(440, 317)
        Me.Name = "Contour_Pointer"
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.chartContainer.ResumeLayout(False)
        CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub numericUpDown2_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles numericUpDown2.ValueChanged
        contour1.Pointer.HorizSize = CInt(numericUpDown2.Value)
    End Sub

    Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox1.CheckedChanged
        contour1.Pointer.Visible = checkBox1.Checked
    End Sub

    Private Sub numericUpDown1_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles numericUpDown1.ValueChanged
        contour1.Pointer.VertSize = CInt(numericUpDown1.Value)
    End Sub

    Private Sub tChart1_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles tChart1.MouseMove
        index = contour1.Clicked(e.X, e.Y)
    End Sub

End Class

