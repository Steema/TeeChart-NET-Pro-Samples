
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing

Imports System.Windows.Forms



Public Class VolumePipe_Series
    Inherits Samples.BaseForm

    '/ <summary>
    '/ Required designer variable.
    '/ </summary>
    Private components As System.ComponentModel.IContainer = Nothing


    Public Sub New() ' me call is required by the Windows Form Designer.
        InitializeComponent()
        InitializeChart()
        numericUpDown1.Value = volumePipe.ConePercent
    End Sub

    Private WithEvents numericUpDown1 As NumericUpDown
    Private label2 As Label
    Private WithEvents checkBox1 As CheckBox
    Private WithEvents numericUpDown2 As NumericUpDown
    Private label1 As Label

    Private volumePipe As Steema.TeeChart.Styles.VolumePipe

    Private Sub InitializeChart()

        volumePipe = New Steema.TeeChart.Styles.VolumePipe()
        tChart1.Series.Add(volumePipe)

        volumePipe.Brush.Gradient.Visible = True
        volumePipe.ConePercent = 60
        volumePipe.Separation = 6
        numericUpDown2.Value = volumePipe.Separation

        'Marks
        volumePipe.Marks.Visible = True
        volumePipe.Marks.Gradient.Visible = True
        volumePipe.Marks.Gradient.StartColor = Color.FromArgb(255, 128, 128, 255)
        volumePipe.Marks.Gradient.EndColor = Color.MidnightBlue
        volumePipe.Marks.Font.Color = Color.White

        volumePipe.FillSampleValues()
    End Sub

    Private Sub numericUpDown1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles numericUpDown1.ValueChanged
        If Not volumePipe Is Nothing Then
            volumePipe.ConePercent = CType(numericUpDown1.Value, Integer)
            volumePipe.Invalidate()
        End If
    End Sub

    Private Sub checkBox1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox1.Click
        tChart1.Aspect.View3D = checkBox1.Checked
    End Sub

    Private Sub numericUpDown2_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles numericUpDown2.ValueChanged
        If Not volumePipe Is Nothing Then
            volumePipe.Separation = CInt(numericUpDown2.Value)
            volumePipe.Invalidate()
        End If
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VolumePipe_Series))
        Me.numericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.label2 = New System.Windows.Forms.Label()
        Me.checkBox1 = New System.Windows.Forms.CheckBox()
        Me.numericUpDown2 = New System.Windows.Forms.NumericUpDown()
        Me.label1 = New System.Windows.Forms.Label()
        Me.panel1.SuspendLayout()
        Me.chartContainer.SuspendLayout()
        CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Text = resources.GetString("textBox1.Text")
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.numericUpDown2)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Controls.Add(Me.checkBox1)
        Me.panel1.Controls.Add(Me.numericUpDown1)
        Me.panel1.Controls.Add(Me.label2)
        ' 
        ' tChart1
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Aspect.Chart3DPercent = 85
        Me.tChart1.Aspect.Orthogonal = False
        Me.tChart1.Aspect.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality
        Me.tChart1.Aspect.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        Me.tChart1.Aspect.View3D = False
        ' 
        ' 
        ' 
        Me.tChart1.Header.Lines = New String() {""}
        ' 
        ' 
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(216, Byte), Integer))
        ' 
        ' 
        ' 
        Me.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.tChart1.Panel.Brush.Gradient.ExtendedColorPalette = Nothing
        Me.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tChart1.Panel.Brush.Gradient.Sigma = True
        Me.tChart1.Panel.Brush.Gradient.SigmaFocus = 1.0F
        Me.tChart1.Panel.Brush.Gradient.SigmaScale = 0.8F
        Me.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.White
        Me.tChart1.Panel.Brush.Gradient.UseMiddle = True
        Me.tChart1.Panel.Brush.Gradient.Visible = True
        Me.tChart1.Panel.MarginBottom = 10
        Me.tChart1.Panel.MarginLeft = 10
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
        ' 
        ' numericUpDown1
        ' 
        Me.numericUpDown1.BackColor = System.Drawing.SystemColors.Window
        Me.numericUpDown1.Location = New System.Drawing.Point(254, 9)
        Me.numericUpDown1.Maximum = New Decimal(New Integer() { _
              90, _
              0, _
              0, _
              0})
        Me.numericUpDown1.Minimum = New Decimal(New Integer() { _
              1, _
              0, _
              0, _
              0})
        Me.numericUpDown1.Name = "numericUpDown1"
        Me.numericUpDown1.ReadOnly = True
        Me.numericUpDown1.Size = New System.Drawing.Size(40, 20)
        Me.numericUpDown1.TabIndex = 7
        Me.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numericUpDown1.Value = New Decimal(New Integer() { _
            1, _
            0, _
            0, _
            0})
        ' 
        ' label2
        ' 
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(174, 11)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(74, 13)
        Me.label2.TabIndex = 6
        Me.label2.Text = "Cone percent:"
        Me.label2.UseMnemonic = False
        ' 
        ' checkBox1
        ' 
        Me.checkBox1.Location = New System.Drawing.Point(325, 9)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(66, 17)
        Me.checkBox1.TabIndex = 8
        Me.checkBox1.Text = "View 3D"
#If VS2005 Then
        Me.checkBox1.AutoSize = True
        Me.checkBox1.UseVisualStyleBackColor = True
#End If
        ' 
        ' numericUpDown2
        ' 
        Me.numericUpDown2.BackColor = System.Drawing.SystemColors.Window
        Me.numericUpDown2.Location = New System.Drawing.Point(122, 9)
        Me.numericUpDown2.Maximum = New Decimal(New Integer() { _
            20, _
            0, _
            0, _
            0})
        Me.numericUpDown2.Name = "numericUpDown2"
        Me.numericUpDown2.ReadOnly = True
        Me.numericUpDown2.Size = New System.Drawing.Size(40, 20)
        Me.numericUpDown2.TabIndex = 10
        Me.numericUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        ' 
        ' label1
        ' 
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(12, 11)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(104, 13)
        Me.label1.TabIndex = 9
        Me.label1.Text = "Segment separation:"
        Me.label1.UseMnemonic = False
        ' 
        ' VolumePipe_Series
        ' 
#If VS2005 Then
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
#End If
        Me.ClientSize = New System.Drawing.Size(440, 317)
        Me.Name = "VolumePipe_Series"
        Me.Text = "VolumePipe_Series"
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.chartContainer.ResumeLayout(False)
        CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

#End Region


End Class

