
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing

Imports System.Windows.Forms




Public Class Tools_DrawLine
    Inherits Samples.BaseForm
    Private fastLineSeries1 As Steema.TeeChart.Styles.FastLine
    Private WithEvents drawLine1 As Steema.TeeChart.Tools.DrawLine
    Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
    Private WithEvents checkBox2 As System.Windows.Forms.CheckBox
    Private WithEvents checkBox3 As System.Windows.Forms.CheckBox
    Private label1 As System.Windows.Forms.Label
    Private NumLines As System.Windows.Forms.Label
    Private WithEvents button1 As System.Windows.Forms.Button
    Private label2 As System.Windows.Forms.Label
    Private WithEvents comboBox1 As System.Windows.Forms.ComboBox
    Private gridBand1 As Steema.TeeChart.Tools.GridBand
    Private components As System.ComponentModel.IContainer = Nothing
    
    
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        
        Me.fastLineSeries1.FillSampleValues(100)
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
        Me.drawLine1 = New Steema.TeeChart.Tools.DrawLine
        Me.checkBox1 = New System.Windows.Forms.CheckBox
        Me.checkBox2 = New System.Windows.Forms.CheckBox
        Me.checkBox3 = New System.Windows.Forms.CheckBox
        Me.label1 = New System.Windows.Forms.Label
        Me.NumLines = New System.Windows.Forms.Label
        Me.button1 = New System.Windows.Forms.Button
        Me.label2 = New System.Windows.Forms.Label
        Me.comboBox1 = New System.Windows.Forms.ComboBox
        Me.gridBand1 = New Steema.TeeChart.Tools.GridBand
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(425, 59)
        Me.textBox1.Text = "The Draw Line tool allows the user to draw lines at run-time using the mouse. Lin" + "e pen is customizable. All drawn lines are stored in a Lines array property." + vbCr + vbLf + vbCr + vbLf + "Example: Draw a line dragging the mouse."
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.comboBox1)
        Me.panel1.Controls.Add(Me.label2)
        Me.panel1.Controls.Add(Me.button1)
        Me.panel1.Controls.Add(Me.NumLines)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Controls.Add(Me.checkBox3)
        Me.panel1.Controls.Add(Me.checkBox2)
        Me.panel1.Controls.Add(Me.checkBox1)
        Me.panel1.Location = New System.Drawing.Point(0, 59)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(425, 79)
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
        ' tChart1.Header
        ' 
        Me.tChart1.Header.Lines = New String() {"tChart1"}
        Me.tChart1.Header.Visible = False
        Me.tChart1.Location = New System.Drawing.Point(0, 138)
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Brush
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.tChart1.Series.Add(Me.fastLineSeries1)
        Me.tChart1.Size = New System.Drawing.Size(425, 132)
        Me.tChart1.Tools.Add(Me.drawLine1)
        Me.tChart1.Tools.Add(Me.gridBand1)
        ' 
        ' fastLineSeries1
        ' 
        ' 
        ' fastLineSeries1.LinePen
        ' 
        Me.fastLineSeries1.LinePen.Color = System.Drawing.Color.Red
        ' 
        ' fastLineSeries1.Marks
        ' 
        ' 
        ' fastLineSeries1.Marks.Symbol
        ' 
        ' 
        ' fastLineSeries1.Marks.Symbol.Shadow
        ' 
        Me.fastLineSeries1.Marks.Symbol.Shadow.Height = 1
        Me.fastLineSeries1.Marks.Symbol.Shadow.Visible = True
        Me.fastLineSeries1.Marks.Symbol.Shadow.Width = 1
        Me.fastLineSeries1.Title = "fastLineSeries1"
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
        ' drawLine1
        ' 
        ' 
        ' checkBox1
        ' 
        Me.checkBox1.Checked = True
        Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox1.Location = New System.Drawing.Point(12, 9)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(116, 20)
        Me.checkBox1.TabIndex = 0
        Me.checkBox1.Text = "&Active"
        ' 
        ' checkBox2
        ' 
        Me.checkBox2.Checked = True
        Me.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox2.Location = New System.Drawing.Point(12, 29)
        Me.checkBox2.Name = "checkBox2"
        Me.checkBox2.Size = New System.Drawing.Size(116, 20)
        Me.checkBox2.TabIndex = 1
        Me.checkBox2.Text = "&Enable Draw"
        ' 
        ' checkBox3
        ' 
        Me.checkBox3.Checked = True
        Me.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox3.Location = New System.Drawing.Point(12, 49)
        Me.checkBox3.Name = "checkBox3"
        Me.checkBox3.Size = New System.Drawing.Size(116, 19)
        Me.checkBox3.TabIndex = 2
        Me.checkBox3.Text = "Enable &Selection"
        ' 
        ' label1
        ' 
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(122, 7)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(37, 16)
        Me.label1.TabIndex = 3
        Me.label1.Text = "Lines :"
        Me.label1.UseMnemonic = False
        ' 
        ' NumLines
        ' 
        Me.NumLines.AutoSize = True
        Me.NumLines.Location = New System.Drawing.Point(164, 7)
        Me.NumLines.Name = "NumLines"
        Me.NumLines.Size = New System.Drawing.Size(10, 16)
        Me.NumLines.TabIndex = 4
        Me.NumLines.Text = "0"
        Me.NumLines.UseMnemonic = False
        ' 
        ' button1
        ' 
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.Location = New System.Drawing.Point(176, 48)
        Me.button1.Name = "button1"
        Me.button1.TabIndex = 5
        Me.button1.Text = "&Delete"
        ' 
        ' label2
        ' 
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(213, 18)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(76, 16)
        Me.label2.TabIndex = 6
        Me.label2.Text = "&Mouse button:"
        Me.label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        ' 
        ' comboBox1
        ' 
        Me.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboBox1.Items.AddRange(New Object() {"Left", "Right", "Middle"})
        Me.comboBox1.Location = New System.Drawing.Point(296, 16)
        Me.comboBox1.Name = "comboBox1"
        Me.comboBox1.Size = New System.Drawing.Size(85, 21)
        Me.comboBox1.TabIndex = 7
        ' 
        ' gridBand1
        ' 
        Me.gridBand1.Axis = Me.tChart1.Axes.Left
        ' 
        ' gridBand1.Band1
        ' 
        Me.gridBand1.Band1.Color = System.Drawing.Color.FromArgb(CType(127, System.Byte), CType(224, System.Byte), CType(224, System.Byte), CType(224, System.Byte))
        ' 
        ' gridBand1.Band2
        ' 
        Me.gridBand1.Band2.Color = System.Drawing.Color.FromArgb(CType(127, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        ' 
        ' Tool_DrawLine
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(425, 270)
        Me.Name = "Tool_DrawLine"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub 'InitializeComponent 
#End Region


    Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
        Me.drawLine1.DeleteSelected()
        Me.button1.Enabled = False
        NumLines.Text = Me.drawLine1.Lines.Count.ToString()
    End Sub 'button1_Click


    Private Sub Tool_DrawLine_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.comboBox1.SelectedIndex = 0
    End Sub 'Tool_DrawLine_Load


    Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox1.CheckedChanged
        Me.drawLine1.Active = Me.checkBox1.Checked
    End Sub 'checkBox1_CheckedChanged


    Private Sub comboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboBox1.SelectedIndexChanged
        Select Case comboBox1.SelectedIndex
            Case 0
                Me.drawLine1.Button = System.Windows.Forms.MouseButtons.Left
            Case 1
                Me.drawLine1.Button = System.Windows.Forms.MouseButtons.Right
            Case 2
                Me.drawLine1.Button = System.Windows.Forms.MouseButtons.Middle
        End Select
    End Sub 'comboBox1_SelectedIndexChanged


    Private Sub checkBox2_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox2.CheckedChanged
        Me.drawLine1.EnableDraw = checkBox2.Checked
    End Sub 'checkBox2_CheckedChanged


    Private Sub checkBox3_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox3.CheckedChanged
        Me.drawLine1.EnableSelect = checkBox3.Checked
    End Sub 'checkBox3_CheckedChanged


    Private Sub drawLine1_Select(ByVal sender As Steema.TeeChart.Tools.DrawLine) Handles drawLine1.Select
        Me.button1.Enabled = True
    End Sub 'drawLine1_Select


    Private Sub drawLine1_NewLine(ByVal sender As Steema.TeeChart.Tools.DrawLine) Handles drawLine1.NewLine
        NumLines.Text = Me.drawLine1.Lines.Count.ToString()
    End Sub 'drawLine1_NewLine
End Class 'Tools_DrawLine
