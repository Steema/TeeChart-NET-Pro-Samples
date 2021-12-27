
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Public Class Axes_Offsets
    Inherits Steema.TeeChart.Samples.BaseForm
    Private fastLineSeries1 As Steema.TeeChart.Styles.FastLine
    Private WithEvents comboBox1 As System.Windows.Forms.ComboBox
    Private label1 As System.Windows.Forms.Label
    Private WithEvents numericUpDown1 As System.Windows.Forms.NumericUpDown
    Private label2 As System.Windows.Forms.Label
    Private label3 As System.Windows.Forms.Label
    Private WithEvents numericUpDown2 As System.Windows.Forms.NumericUpDown
    Private gridBand1 As Steema.TeeChart.Tools.GridBand
    Private components As System.ComponentModel.IContainer = Nothing
    
    
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        
        Me.fastLineSeries1.FillSampleValues(100)
        Me.tChart1.Axes.Left.MinimumOffset = 5
        Me.tChart1.Axes.Left.MaximumOffset = 5
        
        ' Apply palette
        Steema.TeeChart.Themes.ColorPalettes.ApplyPalette(tChart1.Chart, 3)
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
        Me.fastLineSeries1 = New Steema.TeeChart.Styles.FastLine
        Me.comboBox1 = New System.Windows.Forms.ComboBox
        Me.label1 = New System.Windows.Forms.Label
        Me.numericUpDown1 = New System.Windows.Forms.NumericUpDown
        Me.label2 = New System.Windows.Forms.Label
        Me.label3 = New System.Windows.Forms.Label
        Me.numericUpDown2 = New System.Windows.Forms.NumericUpDown
        Me.gridBand1 = New Steema.TeeChart.Tools.GridBand
        Me.panel1.SuspendLayout()
        CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.BackColor = System.Drawing.Color.AliceBlue
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(552, 72)
        Me.textBox1.TabIndex = 0
        Me.textBox1.Text = ("Axes can have Offsets (in pixels) for both Minimum and Maximum scales." & vbCrLf & vbCrLf & "tChart1" & ".Axes.Left.MaximumOffset = 4" & vbCrLf & "tChart1.Axes.Left.MinimumOffset = 4 ")
        ' 
        ' panel1
        ' 
        Me.panel1.BackColor = System.Drawing.SystemColors.Control
        Me.panel1.Controls.Add(Me.comboBox1)
        Me.panel1.Controls.Add(Me.numericUpDown2)
        Me.panel1.Controls.Add(Me.numericUpDown1)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Controls.Add(Me.label2)
        Me.panel1.Controls.Add(Me.label3)
        Me.panel1.Location = New System.Drawing.Point(0, 72)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(552, 40)
        Me.panel1.TabIndex = 1
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
        ' tChart1.Axes
        ' 
        ' 
        ' tChart1.Axes.Bottom
        ' 
        ' 
        ' tChart1.Axes.Bottom.AxisPen
        ' 
        Me.tChart1.Axes.Bottom.AxisPen.Color = System.Drawing.Color.FromArgb(CType(254, Byte), CType(128, Byte), CType(128, Byte), CType(128, Byte))
        Me.tChart1.Axes.Bottom.AxisPen.Width = 1
        ' 
        ' tChart1.Axes.Left
        ' 
        ' 
        ' tChart1.Axes.Left.AxisPen
        ' 
        Me.tChart1.Axes.Left.AxisPen.Color = System.Drawing.Color.FromArgb(CType(254, Byte), CType(128, Byte), CType(128, Byte), CType(128, Byte))
        Me.tChart1.Axes.Left.AxisPen.Width = 1
        ' 
        ' tChart1.Header
        ' 
        ' 
        ' tChart1.Header.Font
        ' 
        ' 
        ' tChart1.Header.Font.Brush
        ' 
        Me.tChart1.Header.Font.Brush.Color = System.Drawing.Color.FromArgb(CType(254, Byte), CType(0, Byte), CType(0, Byte), CType(128, Byte))
        Me.tChart1.Header.Font.Name = "Verdana"
        ' 
        ' tChart1.Header.Font.Shadow
        ' 
        ' 
        ' tChart1.Header.Font.Shadow.Brush
        ' 
        Me.tChart1.Header.Font.Shadow.Brush.Color = System.Drawing.Color.FromArgb(CType(254, Byte), CType(192, Byte), CType(192, Byte), CType(192, Byte))
        Me.tChart1.Header.Font.Shadow.Visible = True
        Me.tChart1.Header.Lines = New String() {"Axes Offsets"}
        ' 
        ' tChart1.Legend
        ' 
        Me.tChart1.Legend.Alignment = Steema.TeeChart.LegendAlignments.Left
        ' 
        ' tChart1.Legend.Brush
        ' 
        Me.tChart1.Legend.Brush.Color = System.Drawing.Color.FromArgb(CType(76, Byte), CType(255, Byte), CType(255, Byte), CType(255, Byte))
        ' 
        ' tChart1.Legend.Gradient
        ' 
        Me.tChart1.Legend.Brush.Gradient.Transparency = 70
        ' 
        ' tChart1.Legend.Gradient
        ' 
        Me.tChart1.Legend.Gradient.Transparency = 70
        Me.tChart1.Legend.LegendStyle = Steema.TeeChart.LegendStyles.Series
        ' 
        ' tChart1.Legend.Pen
        ' 
        Me.tChart1.Legend.Pen.Color = System.Drawing.Color.FromArgb(CType(254, Byte), CType(128, Byte), CType(128, Byte), CType(128, Byte))
        ' 
        ' tChart1.Legend.Shadow
        ' 
        ' 
        ' tChart1.Legend.Shadow.Brush
        ' 
        Me.tChart1.Legend.Shadow.Brush.Color = System.Drawing.Color.FromArgb(CType(254, Byte), CType(128, Byte), CType(128, Byte), CType(128, Byte))
        Me.tChart1.Legend.Shadow.Height = 1
        Me.tChart1.Legend.Shadow.Width = 1
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Brush
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(254, Byte), CType(255, Byte), CType(255, Byte), CType(255, Byte))
        ' 
        ' tChart1.Panel.Gradient
        ' 
        Me.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(254, Byte), CType(255, Byte), CType(255, Byte), CType(210, Byte))
        Me.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(254, Byte), CType(255, Byte), CType(255, Byte), CType(210, Byte))
        Me.tChart1.Panel.Brush.Gradient.UseMiddle = True
        Me.tChart1.Panel.Brush.Gradient.Visible = True
        ' 
        ' tChart1.Panel.Gradient
        ' 
        Me.tChart1.Panel.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(254, Byte), CType(255, Byte), CType(255, Byte), CType(210, Byte))
        Me.tChart1.Panel.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(254, Byte), CType(255, Byte), CType(255, Byte), CType(210, Byte))
        Me.tChart1.Panel.Gradient.UseMiddle = True
        Me.tChart1.Panel.Gradient.Visible = True
        Me.tChart1.Series.Add(Me.fastLineSeries1)
        Me.tChart1.Size = New System.Drawing.Size(552, 253)
        Me.tChart1.TabIndex = 2
        Me.tChart1.Tools.Add(Me.gridBand1)
        ' 
        ' tChart1.Walls
        ' 
        ' 
        ' tChart1.Walls.Back
        ' 
        ' 
        ' tChart1.Walls.Back.Pen
        ' 
        Me.tChart1.Walls.Back.Pen.Color = System.Drawing.Color.FromArgb(CType(254, Byte), CType(128, Byte), CType(128, Byte), CType(128, Byte))
        ' 
        ' fastLineSeries1
        ' 
        ' 
        ' fastLineSeries1.LinePen
        ' 
        Me.fastLineSeries1.LinePen.Color = System.Drawing.Color.FromArgb(CType(0, Byte), CType(165, Byte), CType(255, Byte))
        Me.fastLineSeries1.Title = "Offsets"
        ' 
        ' fastLineSeries1.XValues
        ' 
        Me.fastLineSeries1.XValues.DataMember = "X"
        Me.fastLineSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' fastLineSeries1.YValues
        ' 
        Me.fastLineSeries1.YValues.DataMember = "Y"
        ' 
        ' comboBox1
        ' 
        Me.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboBox1.Items.AddRange(New Object() {"Left", "Bottom"})
        Me.comboBox1.Location = New System.Drawing.Point(40, 8)
        Me.comboBox1.Name = "comboBox1"
        Me.comboBox1.Size = New System.Drawing.Size(120, 21)
        Me.comboBox1.TabIndex = 1
        AddHandler comboBox1.SelectedIndexChanged, AddressOf Me.comboBox1_SelectedIndexChanged
        ' 
        ' label1
        ' 
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(10, 10)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(29, 16)
        Me.label1.TabIndex = 0
        Me.label1.Text = "&Axis:"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        ' 
        ' numericUpDown1
        ' 
        Me.numericUpDown1.Location = New System.Drawing.Point(232, 8)
        Me.numericUpDown1.Name = "numericUpDown1"
        Me.numericUpDown1.Size = New System.Drawing.Size(56, 20)
        Me.numericUpDown1.TabIndex = 3
        Me.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numericUpDown1.Value = New Decimal(New Integer() {5, 0, 0, 0})
        AddHandler numericUpDown1.TextChanged, AddressOf Me.numericUpDown1_TextChanged
        AddHandler numericUpDown1.ValueChanged, AddressOf Me.numericUpDown1_ValueChanged
        ' 
        ' label2
        ' 
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(168, 10)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(56, 16)
        Me.label2.TabIndex = 2
        Me.label2.Text = "&Min offset:"
        Me.label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        ' 
        ' label3
        ' 
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(304, 10)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(59, 16)
        Me.label3.TabIndex = 4
        Me.label3.Text = "Ma&x offset:"
        Me.label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        ' 
        ' numericUpDown2
        ' 
        Me.numericUpDown2.Location = New System.Drawing.Point(368, 8)
        Me.numericUpDown2.Name = "numericUpDown2"
        Me.numericUpDown2.Size = New System.Drawing.Size(56, 20)
        Me.numericUpDown2.TabIndex = 5
        Me.numericUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numericUpDown2.Value = New Decimal(New Integer() {5, 0, 0, 0})
        AddHandler numericUpDown2.TextChanged, AddressOf Me.numericUpDown2_TextChanged
        AddHandler numericUpDown2.ValueChanged, AddressOf Me.numericUpDown2_ValueChanged
        ' 
        ' gridBand1
        ' 
        Me.gridBand1.Axis = Me.tChart1.Axes.Left
        ' 
        ' gridBand1.Band1
        ' 
        Me.gridBand1.Band1.Color = System.Drawing.Color.FromArgb(CType(127, Byte), CType(255, Byte), CType(255, Byte), CType(128, Byte))
        ' 
        ' gridBand1.Band2
        ' 
        Me.gridBand1.Band2.Color = System.Drawing.Color.FromArgb(CType(127, Byte), CType(255, Byte), CType(255, Byte), CType(192, Byte))
        ' 
        ' Axes_Offsets
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(552, 365)
        Me.Name = "Axes_Offsets"
        AddHandler Load, AddressOf Me.Axes_Offsets_Load
        Me.panel1.ResumeLayout(False)
        CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub 'InitializeComponent 
#End Region


    Private Sub Axes_Offsets_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not Me.DesignMode Then
            Me.comboBox1.SelectedIndex = 0
        End If
    End Sub 'Axes_Offsets_Load


    Private Sub numericUpDown1_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles numericUpDown1.ValueChanged
        If Me.comboBox1.SelectedIndex = 0 Then ' left axis
            Me.tChart1.Axes.Left.MinimumOffset = Fix(Me.numericUpDown1.Value)
            ' bottom axis
        Else
            Me.tChart1.Axes.Bottom.MinimumOffset = Fix(Me.numericUpDown1.Value)
        End If
    End Sub 'numericUpDown1_ValueChanged


    Private Sub numericUpDown2_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles numericUpDown2.ValueChanged
        If Me.comboBox1.SelectedIndex = 0 Then ' left axis
            Me.tChart1.Axes.Left.MinimumOffset = Fix(Me.numericUpDown2.Value)
            ' bottom axis
        Else
            Me.tChart1.Axes.Bottom.MinimumOffset = Fix(Me.numericUpDown2.Value)
        End If
    End Sub 'numericUpDown2_ValueChanged


    Private Sub numericUpDown2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles numericUpDown2.TextChanged
        If Me.comboBox1.SelectedIndex = 0 Then ' left axis
            Me.tChart1.Axes.Left.MaximumOffset = Fix(Me.numericUpDown2.Value)
            ' bottom axis
        Else
            Me.tChart1.Axes.Bottom.MaximumOffset = Fix(Me.numericUpDown2.Value)
        End If
    End Sub 'numericUpDown2_TextChanged


    Private Sub numericUpDown1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles numericUpDown1.TextChanged
        If Me.comboBox1.SelectedIndex = 0 Then ' left axis
            Me.tChart1.Axes.Left.MinimumOffset = Fix(Me.numericUpDown1.Value)
            ' bottom axis
        Else
            Me.tChart1.Axes.Bottom.MinimumOffset = Fix(Me.numericUpDown1.Value)
        End If
    End Sub 'numericUpDown1_TextChanged


    Private Sub comboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboBox1.SelectedIndexChanged
        If Me.comboBox1.SelectedIndex = 0 Then ' left axis
            Me.numericUpDown1.Value = Me.tChart1.Axes.Left.MinimumOffset
            Me.numericUpDown2.Value = Me.tChart1.Axes.Left.MaximumOffset
        Else
            Me.numericUpDown1.Value = Me.tChart1.Axes.Bottom.MinimumOffset
            Me.numericUpDown2.Value = Me.tChart1.Axes.Bottom.MaximumOffset
        End If
    End Sub 'comboBox1_SelectedIndexChanged
End Class 'Axes_Offsets
