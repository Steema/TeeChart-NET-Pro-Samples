
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing

Imports System.Windows.Forms




Public Class ColorGrid_Series
    Inherits Samples.BaseForm
    Private colorGridSeries1 As Steema.TeeChart.Styles.ColorGrid
    Private label1 As System.Windows.Forms.Label
    Private WithEvents numericUpDown1 As System.Windows.Forms.NumericUpDown
    Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
    Private WithEvents button1 As System.Windows.Forms.Button
    Private components As System.ComponentModel.IContainer = Nothing
    
    
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        
        Me.colorGridSeries1.FillSampleValues(20)
        Me.colorGridSeries1.Pen.Color = Color.White
        Me.colorGridSeries1.UsePalette = True
        Me.colorGridSeries1.UseColorRange = False
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
        Me.colorGridSeries1 = New Steema.TeeChart.Styles.ColorGrid
        Me.label1 = New System.Windows.Forms.Label
        Me.numericUpDown1 = New System.Windows.Forms.NumericUpDown
        Me.checkBox1 = New System.Windows.Forms.CheckBox
        Me.button1 = New System.Windows.Forms.Button
        Me.panel1.SuspendLayout()
        CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(466, 63)
        Me.textBox1.Text = "ColorGrid series is a 2D surface. Each ""cell"" has a value and an optional color. The AddXYZ method is used to fill the color grid. An optional ""grid"" over cells is displayed using the Pen property." + vbCr + vbLf + vbCr + vbLf + "Example: colorGridSeries1.Add( 1, 123, 1 )' x=1, z = 1, y(x,z) =123"
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.button1)
        Me.panel1.Controls.Add(Me.checkBox1)
        Me.panel1.Controls.Add(Me.numericUpDown1)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Location = New System.Drawing.Point(0, 63)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(466, 33)
        ' 
        ' tChart1
        ' 
        ' 
        ' tChart1.Aspect
        ' 
        Me.tChart1.Aspect.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality
        Me.tChart1.Aspect.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        Me.tChart1.Aspect.View3D = False
        Me.tChart1.BackColor = System.Drawing.Color.Transparent
        ' 
        ' tChart1.Header
        ' 
        Me.tChart1.Header.Lines = New String() {"tChart1"}
        ' 
        ' tChart1.Legend
        ' 
        Me.tChart1.Legend.MaxNumRows = 8
        Me.tChart1.Location = New System.Drawing.Point(0, 96)
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Brush
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.tChart1.Series.Add(Me.colorGridSeries1)
        Me.tChart1.Size = New System.Drawing.Size(466, 190)
        ' 
        ' colorGridSeries1
        ' 
        ' 
        ' colorGridSeries1.Brush
        ' 
        Me.colorGridSeries1.Brush.Color = System.Drawing.Color.Red
        ' 
        ' colorGridSeries1.Marks
        ' 
        Me.colorGridSeries1.Marks.ArrowLength = 0
        ' 
        ' colorGridSeries1.Marks.Symbol
        ' 
        ' 
        ' colorGridSeries1.Marks.Symbol.Shadow
        ' 
        Me.colorGridSeries1.Marks.Symbol.Shadow.Height = 1
        Me.colorGridSeries1.Marks.Symbol.Shadow.Visible = True
        Me.colorGridSeries1.Marks.Symbol.Shadow.Width = 1
        Me.colorGridSeries1.NumXValues = 25
        Me.colorGridSeries1.NumZValues = 25
        Me.colorGridSeries1.PaletteMin = 0
        Me.colorGridSeries1.PaletteStep = 0
        Me.colorGridSeries1.Title = "colorGridSeries1"
        ' 
        ' colorGridSeries1.XValues
        ' 
        Me.colorGridSeries1.XValues.DataMember = "X"
        ' 
        ' colorGridSeries1.YValues
        ' 
        Me.colorGridSeries1.YValues.DataMember = "Y"
        ' 
        ' colorGridSeries1.ZValues
        ' 
        Me.colorGridSeries1.ZValues.DataMember = "Z"
        ' 
        ' label1
        ' 
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(21, 9)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(29, 16)
        Me.label1.TabIndex = 0
        Me.label1.Text = "&Size:"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        ' 
        ' numericUpDown1
        ' 
        Me.numericUpDown1.Location = New System.Drawing.Point(56, 7)
        Me.numericUpDown1.Minimum = New System.Decimal(New Integer() {2, 0, 0, 0})
        Me.numericUpDown1.Name = "numericUpDown1"
        Me.numericUpDown1.Size = New System.Drawing.Size(40, 20)
        Me.numericUpDown1.TabIndex = 1
        Me.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numericUpDown1.Value = New System.Decimal(New Integer() {20, 0, 0, 0})
        ' 
        ' checkBox1
        ' 
        Me.checkBox1.Checked = True
        Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox1.Location = New System.Drawing.Point(120, 7)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(47, 21)
        Me.checkBox1.TabIndex = 2
        Me.checkBox1.Text = "&Grid"
        ' 
        ' button1
        ' 
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.Location = New System.Drawing.Point(208, 6)
        Me.button1.Name = "button1"
        Me.button1.TabIndex = 3
        Me.button1.Text = "&Edit..."
        ' 
        ' SeriesType_ColorGrid
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(466, 286)
        Me.Name = "SeriesType_ColorGrid"
        Me.panel1.ResumeLayout(False)
        CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub 'InitializeComponent 
#End Region


    Private Sub numericUpDown1_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles numericUpDown1.ValueChanged
        Me.colorGridSeries1.FillSampleValues(Fix(Me.numericUpDown1.Value))
        If Me.numericUpDown1.Value > 30 Then
            Me.checkBox1.Checked = False
            Me.colorGridSeries1.Pen.Visible = False
        End If
    End Sub 'numericUpDown1_ValueChanged


    Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox1.CheckedChanged
        Me.colorGridSeries1.Pen.Visible = checkBox1.Checked
    End Sub 'checkBox1_CheckedChanged


    Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
        TeeChart.Editors.SeriesEditor.ShowEditor(Me.colorGridSeries1)
    End Sub 'button1_Click
End Class 'ColorGrid_Series
