
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing

Imports System.Windows.Forms




Public Class Marks_Shadow
    Inherits Samples.BaseForm
    Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
    Private barSeries1 As Steema.TeeChart.Styles.Bar
    Private label1 As System.Windows.Forms.Label
    Private WithEvents panel2 As System.Windows.Forms.Panel
    Private label2 As System.Windows.Forms.Label
    Private WithEvents numericUpDown1 As System.Windows.Forms.NumericUpDown
    Private components As System.ComponentModel.IContainer = Nothing
    
    
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        
        Me.barSeries1.FillSampleValues(5)
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
        Me.checkBox1 = New System.Windows.Forms.CheckBox
        Me.barSeries1 = New Steema.TeeChart.Styles.Bar
        Me.label1 = New System.Windows.Forms.Label
        Me.panel2 = New System.Windows.Forms.Panel
        Me.label2 = New System.Windows.Forms.Label
        Me.numericUpDown1 = New System.Windows.Forms.NumericUpDown
        Me.panel1.SuspendLayout()
        CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(466, 80)
        Me.textBox1.Text = "By default Series Marks have a shadowed border. It can be turned on / off at design and run-time, and changed its color and transparency too." + vbCr + vbLf + vbCr + vbLf + "Example: " + vbCr + vbLf + "barSeries1.Marks.Shadow.Visible = true" + vbCr + vbLf + "barSeries1.Marks.Shadow.Width = 2 " + vbCr + vbLf + "barSeries1.Marks.Shadow.Color= Color.Black"
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.numericUpDown1)
        Me.panel1.Controls.Add(Me.label2)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Controls.Add(Me.checkBox1)
        Me.panel1.Controls.Add(Me.panel2)
        Me.panel1.Location = New System.Drawing.Point(0, 80)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(466, 41)
        ' 
        ' tChart1
        ' 
        ' 
        ' tChart1.Aspect
        ' 
        Me.tChart1.Aspect.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality
        Me.tChart1.Aspect.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        ' 
        ' tChart1.Header
        ' 
        Me.tChart1.Header.Lines = New String() {"Example : Mark shadow"}
        Me.tChart1.Location = New System.Drawing.Point(0, 121)
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Brush
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.tChart1.Series.Add(Me.barSeries1)
        Me.tChart1.Size = New System.Drawing.Size(466, 165)
        ' 
        ' tChart1.Walls
        ' 
        ' 
        ' tChart1.Walls.Bottom
        ' 
        ' 
        ' tChart1.Walls.Bottom.Pen
        ' 
        Me.tChart1.Walls.Bottom.Pen.Visible = False
        Me.tChart1.Walls.Bottom.Size = 5
        ' 
        ' tChart1.Walls.Left
        ' 
        ' 
        ' tChart1.Walls.Left.Pen
        ' 
        Me.tChart1.Walls.Left.Pen.Visible = False
        Me.tChart1.Walls.Left.Size = 5
        ' 
        ' checkBox1
        ' 
        Me.checkBox1.Checked = True
        Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox1.Location = New System.Drawing.Point(13, 10)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(123, 21)
        Me.checkBox1.TabIndex = 0
        Me.checkBox1.Tag = ""
        Me.checkBox1.Text = "&Marks Shadow"
        ' 
        ' barSeries1
        ' 
        ' 
        ' barSeries1.Brush
        ' 
        Me.barSeries1.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(0, System.Byte), CType(128, System.Byte), CType(0, System.Byte))
        ' 
        ' barSeries1.Gradient
        ' 
        Me.barSeries1.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(128, System.Byte))
        Me.barSeries1.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(0, System.Byte), CType(192, System.Byte), CType(0, System.Byte))
        Me.barSeries1.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(0, System.Byte), CType(128, System.Byte), CType(0, System.Byte))
        Me.barSeries1.Brush.Gradient.UseMiddle = True
        Me.barSeries1.Brush.Gradient.Visible = True
        ' 
        ' barSeries1.Gradient
        ' 
        Me.barSeries1.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(128, System.Byte))
        Me.barSeries1.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(0, System.Byte), CType(192, System.Byte), CType(0, System.Byte))
        Me.barSeries1.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(0, System.Byte), CType(128, System.Byte), CType(0, System.Byte))
        Me.barSeries1.Gradient.UseMiddle = True
        Me.barSeries1.Gradient.Visible = True
        ' 
        ' barSeries1.Marks
        ' 
        ' 
        ' barSeries1.Marks.Shadow
        ' 
        Me.barSeries1.Marks.Shadow.Height = 3
        Me.barSeries1.Marks.Shadow.Width = 3
        ' 
        ' barSeries1.Marks.Symbol
        ' 
        ' 
        ' barSeries1.Marks.Symbol.Shadow
        ' 
        Me.barSeries1.Marks.Symbol.Shadow.Height = 1
        Me.barSeries1.Marks.Symbol.Shadow.Visible = True
        Me.barSeries1.Marks.Symbol.Shadow.Width = 1
        ' 
        ' barSeries1.Pen
        ' 
        Me.barSeries1.Pen.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(0, System.Byte), CType(77, System.Byte), CType(0, System.Byte))
        Me.barSeries1.Title = "barSeries1"
        ' 
        ' barSeries1.XValues
        ' 
        Me.barSeries1.XValues.DataMember = "X"
        Me.barSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' barSeries1.YValues
        ' 
        Me.barSeries1.YValues.DataMember = "Bar"
        ' 
        ' label1
        ' 
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(133, 12)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(31, 16)
        Me.label1.TabIndex = 1
        Me.label1.Text = "Color"
        Me.label1.UseMnemonic = False
        ' 
        ' panel2
        ' 
        Me.panel2.BackColor = System.Drawing.Color.DarkGray
        Me.panel2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.panel2.Location = New System.Drawing.Point(173, 9)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(23, 23)
        Me.panel2.TabIndex = 2
        ' 
        ' label2
        ' 
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(231, 12)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(29, 16)
        Me.label2.TabIndex = 3
        Me.label2.Text = "&Size:"
        Me.label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        ' 
        ' numericUpDown1
        ' 
        Me.numericUpDown1.Location = New System.Drawing.Point(267, 10)
        Me.numericUpDown1.Maximum = New System.Decimal(New Integer() {20, 0, 0, 0})
        Me.numericUpDown1.Minimum = New System.Decimal(New Integer() {1, 0, 0, 0})
        Me.numericUpDown1.Name = "numericUpDown1"
        Me.numericUpDown1.Size = New System.Drawing.Size(40, 20)
        Me.numericUpDown1.TabIndex = 4
        Me.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numericUpDown1.Value = New System.Decimal(New Integer() {3, 0, 0, 0})
        ' 
        ' Shadow
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(466, 286)
        Me.Name = "Shadow"
        Me.panel1.ResumeLayout(False)
        CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub 'InitializeComponent 
#End Region


    Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox1.CheckedChanged
        Me.barSeries1.Marks.Shadow.Visible = Me.checkBox1.Checked
    End Sub 'checkBox1_CheckedChanged


    Private Sub numericUpDown1_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles numericUpDown1.ValueChanged
        Me.barSeries1.Marks.Shadow.Width = Fix(Me.numericUpDown1.Value)
        Me.barSeries1.Marks.Shadow.Height = Fix(Me.numericUpDown1.Value)
    End Sub 'numericUpDown1_ValueChanged


    Private Sub numericUpDown1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles numericUpDown1.TextChanged
        Me.barSeries1.Marks.Shadow.Width = Fix(Me.numericUpDown1.Value)
        Me.barSeries1.Marks.Shadow.Height = Fix(Me.numericUpDown1.Value)
    End Sub 'numericUpDown1_TextChanged


    Private Sub panel2_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles panel2.MouseUp
        Me.panel2.BackColor = Steema.TeeChart.Editors.ColorEditor.Choose(Me.barSeries1.Marks.Shadow.Color, Me)
        Me.barSeries1.Marks.Shadow.Color = Me.panel2.BackColor
    End Sub 'panel2_MouseUp
End Class 'Marks_Shadow
