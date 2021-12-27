
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing

Imports System.Windows.Forms



Public Class Custom_PointerHexagon
    Inherits Samples.BaseForm

    Private checkBox1 As CheckBox
    Private line1 As Steema.TeeChart.Styles.Line
    Private numericUpDown2 As NumericUpDown
    Private numericUpDown1 As NumericUpDown
    Private label2 As Label
    Private label1 As Label
    '/ <summary>
    '/ Required designer variable.
    '/ </summary>
    Private components As System.ComponentModel.IContainer = Nothing


    Public Sub New() ' This call is required by the Windows Form Designer.
        InitializeComponent()
        line1.FillSampleValues(10)
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
    '/ the contents of this method with the code editor.
    '/ </summary>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Custom_PointerHexagon))
        Me.line1 = New Steema.TeeChart.Styles.Line
        Me.checkBox1 = New System.Windows.Forms.CheckBox
        Me.label1 = New System.Windows.Forms.Label
        Me.label2 = New System.Windows.Forms.Label
        Me.numericUpDown1 = New System.Windows.Forms.NumericUpDown
        Me.numericUpDown2 = New System.Windows.Forms.NumericUpDown
        Me.panel1.SuspendLayout()
        Me.chartContainer.SuspendLayout()
        CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Text = "New series pointer style : hexagon"
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.numericUpDown2)
        Me.panel1.Controls.Add(Me.numericUpDown1)
        Me.panel1.Controls.Add(Me.label2)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Controls.Add(Me.checkBox1)
        Me.panel1.Size = New System.Drawing.Size(440, 45)
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
        Me.tChart1.Legend.Pen.Color = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
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
        Me.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tChart1.Panel.Brush.Gradient.Sigma = True
        Me.tChart1.Panel.Brush.Gradient.SigmaFocus = 1.0!
        Me.tChart1.Panel.Brush.Gradient.SigmaScale = 0.8!
        Me.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tChart1.Panel.Brush.Gradient.UseMiddle = True
        Me.tChart1.Panel.Brush.Gradient.Visible = True
        Me.tChart1.Series.Add(Me.line1)
        Me.tChart1.Size = New System.Drawing.Size(440, 199)
        ' 
        ' chartContainer
        ' 
        Me.chartContainer.Location = New System.Drawing.Point(0, 118)
        Me.chartContainer.Size = New System.Drawing.Size(440, 199)
        ' 
        ' line1
        ' 
        ' 
        ' 
        ' 
        Me.line1.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.line1.ColorEach = True
        ' 
        ' 
        ' 
        Me.line1.Gradient.StartColor = System.Drawing.Color.Red
        ' 
        ' 
        ' 
        Me.line1.LinePen.Color = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.line1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None
        Me.line1.Marks.Callout.ArrowHeadSize = 8
        ' 
        ' 
        ' 
        Me.line1.Marks.Callout.Brush.Color = System.Drawing.Color.Black
        Me.line1.Marks.Callout.Distance = 0
        Me.line1.Marks.Callout.Draw3D = False
        Me.line1.Marks.Callout.Length = 10
        Me.line1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        ' 
        ' 
        ' 
        Me.line1.Pointer.HorizSize = 8
        Me.line1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Hexagon
        Me.line1.Pointer.VertSize = 8
        Me.line1.Pointer.Visible = True
        Me.line1.Title = "line1"
        ' 
        ' 
        ' 
        Me.line1.XValues.DataMember = "X"
        Me.line1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' 
        ' 
        Me.line1.YValues.DataMember = "Y"
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
        Me.checkBox1.Size = New System.Drawing.Size(84, 17)
        Me.checkBox1.TabIndex = 0
        Me.checkBox1.Text = "Points visible"
#If VS2005 Then
        Me.checkBox1.UseVisualStyleBackColor = True
#End If
        AddHandler checkBox1.CheckedChanged, AddressOf Me.checkBox1_CheckedChanged
        ' 
        ' label1
        ' 
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(126, 20)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(63, 13)
        Me.label1.TabIndex = 1
        Me.label1.Text = "Vertical size"
        ' 
        ' label2
        ' 
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(265, 20)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(75, 13)
        Me.label2.TabIndex = 2
        Me.label2.Text = "Horizontal size"
        ' 
        ' numericUpDown1
        ' 
        Me.numericUpDown1.Location = New System.Drawing.Point(195, 16)
        Me.numericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numericUpDown1.Name = "numericUpDown1"
        Me.numericUpDown1.Size = New System.Drawing.Size(46, 20)
        Me.numericUpDown1.TabIndex = 3
        Me.numericUpDown1.Value = New Decimal(New Integer() {8, 0, 0, 0})
        AddHandler numericUpDown1.ValueChanged, AddressOf Me.numericUpDown1_ValueChanged
        ' 
        ' numericUpDown2
        ' 
        Me.numericUpDown2.Location = New System.Drawing.Point(346, 16)
        Me.numericUpDown2.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numericUpDown2.Name = "numericUpDown2"
        Me.numericUpDown2.Size = New System.Drawing.Size(46, 20)
        Me.numericUpDown2.TabIndex = 4
        Me.numericUpDown2.Value = New Decimal(New Integer() {8, 0, 0, 0})
        AddHandler numericUpDown2.ValueChanged, AddressOf Me.numericUpDown2_ValueChanged
        ' 
        ' Custom_PointerHexagon
        ' 
        Me.ClientSize = New System.Drawing.Size(440, 317)
        Me.Name = "Custom_PointerHexagon"
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.chartContainer.ResumeLayout(False)
        CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
        line1.Pointer.Visible = checkBox1.Checked
    End Sub

    Private Sub numericUpDown2_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
        line1.Pointer.HorizSize = CType(numericUpDown2.Value, Integer)
    End Sub

    Private Sub numericUpDown1_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
        line1.Pointer.VertSize = CType(numericUpDown1.Value, Integer)
    End Sub

End Class

