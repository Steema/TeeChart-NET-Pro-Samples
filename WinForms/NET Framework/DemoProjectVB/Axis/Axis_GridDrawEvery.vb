
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

Public Class Axis_GridDrawEvery
    Inherits Samples.BaseForm
    Private axis As Steema.TeeChart.Axis
    Private bubble1 As Steema.TeeChart.Styles.Bubble
    Private WithEvents comboBox1 As ComboBox
    Private label1 As Label
    Private WithEvents numericUpDown1 As NumericUpDown
    Private label2 As Label

    '/ <summary>
    '/ Required designer variable.
    '/ </summary>
    Private components As System.ComponentModel.IContainer = Nothing


    Public Sub New() ' me call is required by the Windows Form Designer.
        InitializeComponent()
        bubble1.FillSampleValues(6)
        Axis = bubble1.GetVertAxis
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Axis_GridDrawEvery))
        Me.bubble1 = New Steema.TeeChart.Styles.Bubble
        Me.label1 = New System.Windows.Forms.Label
        Me.comboBox1 = New System.Windows.Forms.ComboBox
        Me.label2 = New System.Windows.Forms.Label
        Me.numericUpDown1 = New System.Windows.Forms.NumericUpDown
        Me.panel1.SuspendLayout()
        Me.chartContainer.SuspendLayout()
        CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Text = ("Axis.Grid now has a DrawEvery property. Setting DrawEvery to value greater than 1" & " forces the axis to display only every n-th gridline.")
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.numericUpDown1)
        Me.panel1.Controls.Add(Me.label2)
        Me.panel1.Controls.Add(Me.comboBox1)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Size = New System.Drawing.Size(440, 54)
        ' 
        ' tChart1
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Aspect.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
        Me.tChart1.Aspect.ZOffset = 0
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
        Me.tChart1.Series.Add(Me.bubble1)
        Me.tChart1.Size = New System.Drawing.Size(440, 190)
        ' 
        ' chartContainer
        ' 
        Me.chartContainer.Location = New System.Drawing.Point(0, 127)
        Me.chartContainer.Size = New System.Drawing.Size(440, 190)
        ' 
        ' bubble1
        ' 
        Me.bubble1.Color = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(44, Byte), Integer))
        ' 
        ' 
        ' 
        Me.bubble1.LinePen.Color = System.Drawing.Color.FromArgb(CType(CType(134, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(26, Byte), Integer))
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.bubble1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None
        Me.bubble1.Marks.Callout.ArrowHeadSize = 8
        ' 
        ' 
        ' 
        Me.bubble1.Marks.Callout.Brush.Color = System.Drawing.Color.Black
        Me.bubble1.Marks.Callout.Distance = 0
        Me.bubble1.Marks.Callout.Draw3D = False
        Me.bubble1.Marks.Callout.Length = 0
        Me.bubble1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.bubble1.Marks.Callout.Visible = False
        Me.bubble1.Marks.Transparent = True
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.bubble1.Pointer.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.bubble1.Pointer.Brush.ForegroundColor = System.Drawing.Color.Empty
        Me.bubble1.Pointer.HorizSize = 18
        Me.bubble1.Pointer.InflateMargins = False
        ' 
        ' 
        ' 
        Me.bubble1.Pointer.Pen.Visible = False
        Me.bubble1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.PolishedSphere
        Me.bubble1.Pointer.VertSize = 18
        Me.bubble1.Title = "bubble1"
        ' 
        ' 
        ' 
        Me.bubble1.XValues.DataMember = "X"
        Me.bubble1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' 
        ' 
        Me.bubble1.YValues.DataMember = "Y"
        ' 
        ' label1
        ' 
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(12, 21)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(26, 13)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Axis"
        ' 
        ' comboBox1
        ' 
        Me.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboBox1.Items.AddRange(New Object() {"Vertical", "Horizontal"})
        Me.comboBox1.Location = New System.Drawing.Point(44, 18)
        Me.comboBox1.Name = "comboBox1"
        Me.comboBox1.Size = New System.Drawing.Size(111, 21)
        Me.comboBox1.TabIndex = 1
        AddHandler comboBox1.SelectedIndexChanged, AddressOf Me.comboBox1_SelectedIndexChanged
        ' 
        ' label2
        ' 
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(185, 21)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(61, 13)
        Me.label2.TabIndex = 2
        Me.label2.Text = "Draw every"
        ' 
        ' numericUpDown1
        ' 
        Me.numericUpDown1.Location = New System.Drawing.Point(252, 19)
        Me.numericUpDown1.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.numericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numericUpDown1.Name = "numericUpDown1"
        Me.numericUpDown1.Size = New System.Drawing.Size(67, 20)
        Me.numericUpDown1.TabIndex = 3
        Me.numericUpDown1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        AddHandler numericUpDown1.ValueChanged, AddressOf Me.numericUpDown1_ValueChanged
        ' 
        ' Axis_GridDrawEvery
        ' 
        Me.ClientSize = New System.Drawing.Size(440, 317)
        Me.Name = "Axis_GridDrawEvery"
        AddHandler Load, AddressOf Me.Axis_GridDrawEvery_Load
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.chartContainer.ResumeLayout(False)
        CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

#End Region

  Private Sub Axis_GridDrawEvery_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
    comboBox1.SelectedIndex = 0 ' vertical axis
  End Sub

  Private Sub comboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox1.SelectedIndexChanged
    Select Case (comboBox1.SelectedIndex)
      Case 0
        axis = bubble1.GetVertAxis
        Exit Select
      Case 1
        axis = bubble1.GetHorizAxis
        Exit Select
    End Select
  End Sub

  Private Sub numericUpDown1_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles numericUpDown1.ValueChanged
    If Not axis Is Nothing Then
      axis.Grid.DrawEvery = CType(numericUpDown1.Value, Integer)
    End If
  End Sub

End Class