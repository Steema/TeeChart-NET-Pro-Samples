Imports System
#If VS2005 Then
Imports System.Collections.Generic
#End If
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Public Class Pie_Lighting
    Inherits BaseForm
    Private lEdgeStyle As System.Windows.Forms.Label
    Private WithEvents cbEdgeStyles As System.Windows.Forms.ComboBox
    Private WithEvents numericUpDown1 As System.Windows.Forms.NumericUpDown
    Private label2 As System.Windows.Forms.Label
    Private WithEvents upTransparency As System.Windows.Forms.NumericUpDown
    Private label1 As System.Windows.Forms.Label
    '/ <summary>
    '/ Required designer variable.
    '/ </summary>
    Private components As System.ComponentModel.IContainer = Nothing
    '/<summary>
    '/Clean up any resources being used.
    '/</summary>
    '/<param name="disposing">true if managed resources should be disposed otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If (Not (components) Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub
#Region "Windows Form Designer generated code"
    '/ <summary>
    '/ Required method for Designer support - do not modify
    '/ the contents of this method with the code editor.
    '/ </summary>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pie_Lighting))
        Me.cbEdgeStyles = New System.Windows.Forms.ComboBox
        Me.lEdgeStyle = New System.Windows.Forms.Label
        Me.label1 = New System.Windows.Forms.Label
        Me.upTransparency = New System.Windows.Forms.NumericUpDown
        Me.numericUpDown1 = New System.Windows.Forms.NumericUpDown
        Me.label2 = New System.Windows.Forms.Label
        Me.panel1.SuspendLayout()
        Me.chartContainer.SuspendLayout()
        CType(Me.upTransparency, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'textBox1
        '
        Me.textBox1.Text = resources.GetString("textBox1.Text")
        '
        'panel1
        '
        Me.panel1.Controls.Add(Me.numericUpDown1)
        Me.panel1.Controls.Add(Me.label2)
        Me.panel1.Controls.Add(Me.upTransparency)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Controls.Add(Me.lEdgeStyle)
        Me.panel1.Controls.Add(Me.cbEdgeStyles)
        '
        'tChart1
        '
        '
        '
        '
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
        Me.tChart1.Header.Visible = False
        '
        '
        '
        Me.tChart1.Legend.FontSeriesColor = True
        Me.tChart1.Legend.Transparent = True
        Me.tChart1.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        '
        '
        '
        '
        '
        '
        Me.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tChart1.Panel.Brush.Gradient.UseMiddle = False
        '
        '
        '
        '
        '
        '
        Me.tChart1.Walls.Back.Visible = False
        '
        'cbEdgeStyles
        '
        Me.cbEdgeStyles.FormattingEnabled = True
        Me.cbEdgeStyles.Location = New System.Drawing.Point(341, 12)
        Me.cbEdgeStyles.Name = "cbEdgeStyles"
        Me.cbEdgeStyles.Size = New System.Drawing.Size(87, 21)
        Me.cbEdgeStyles.TabIndex = 0
        '
        'lEdgeStyle
        '
        Me.lEdgeStyle.AutoSize = True
        Me.lEdgeStyle.Location = New System.Drawing.Point(277, 15)
        Me.lEdgeStyle.Name = "lEdgeStyle"
        Me.lEdgeStyle.Size = New System.Drawing.Size(58, 13)
        Me.lEdgeStyle.TabIndex = 1
        Me.lEdgeStyle.Text = "EdgeStyle:"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(12, 15)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(75, 13)
        Me.label1.TabIndex = 2
        Me.label1.Text = "Transparency:"
        '
        'upTransparency
        '
        Me.upTransparency.Location = New System.Drawing.Point(93, 12)
        Me.upTransparency.Name = "upTransparency"
        Me.upTransparency.Size = New System.Drawing.Size(48, 20)
        Me.upTransparency.TabIndex = 3
        '
        'numericUpDown1
        '
        Me.numericUpDown1.Location = New System.Drawing.Point(223, 12)
        Me.numericUpDown1.Name = "numericUpDown1"
        Me.numericUpDown1.Size = New System.Drawing.Size(48, 20)
        Me.numericUpDown1.TabIndex = 5
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(147, 15)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(74, 13)
        Me.label2.TabIndex = 4
        Me.label2.Text = "BevelPercent:"
        '
        'Pie_Lighting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(440, 317)
        Me.Name = "Pie_Lighting"
        Me.Text = "Pie_Lighting"
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.chartContainer.ResumeLayout(False)
        CType(Me.upTransparency, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
#End Region
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        InitializeChart()
    End Sub
    Private pie1 As Steema.TeeChart.Styles.Pie
    Private Sub InitializeChart()
        AddHandler tChart1.DoubleClick, AddressOf Me.tChart1_DoubleClick
        pie1 = New Steema.TeeChart.Styles.Pie()
        tChart1.Series.Add(pie1)
        pie1.FillSampleValues()
        pie1.Pen.Visible = False
        pie1.BevelPercent = 15
        pie1.ExplodeBiggest = 10
        pie1.EdgeStyle = Steema.TeeChart.Drawing.EdgeStyles.Curved
        pie1.Marks.Transparent = True
        pie1.Marks.ArrowLength = 15
        pie1.Marks.FontSeriesColor = True
        cbEdgeStyles.Items.Add(Steema.TeeChart.Drawing.EdgeStyles.Curved)
        cbEdgeStyles.Items.Add(Steema.TeeChart.Drawing.EdgeStyles.Flat)
        cbEdgeStyles.Items.Add(Steema.TeeChart.Drawing.EdgeStyles.None)
        cbEdgeStyles.SelectedIndex = 0
        numericUpDown1.Value = 15
        upTransparency.Value = 0
    End Sub
    Private Sub tChart1_DoubleClick(ByVal sender As Object, ByVal e As EventArgs)
        pie1.FillSampleValues()
    End Sub

    Private Sub upTransparency_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles upTransparency.ValueChanged
        pie1.Transparency = CType(upTransparency.Value, Integer)
    End Sub

    Private Sub numericUpDown1_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles numericUpDown1.ValueChanged
        pie1.BevelPercent = CType(numericUpDown1.Value, Integer)
    End Sub

    Private Sub cbEdgeStyles_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbEdgeStyles.SelectedIndexChanged
        pie1.EdgeStyle = CType(cbEdgeStyles.SelectedItem, Steema.TeeChart.Drawing.EdgeStyles)
    End Sub
End Class