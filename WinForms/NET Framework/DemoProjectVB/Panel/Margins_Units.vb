
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms


Public Class Margins_Units
    Inherits Steema.TeeChart.Samples.BaseForm
    Private comboBox1 As System.Windows.Forms.ComboBox
    Private label1 As System.Windows.Forms.Label
    Private label2 As System.Windows.Forms.Label
    Private label3 As System.Windows.Forms.Label
    Private numericUpDown1 As System.Windows.Forms.NumericUpDown
    Private components As System.ComponentModel.IContainer = Nothing
    
    Public Sub New() ' This call is required by the Windows Form Designer.
        InitializeComponent()

        comboBox1.SelectedIndex = 0
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
        Me.comboBox1 = New System.Windows.Forms.ComboBox
        Me.label1 = New System.Windows.Forms.Label
        Me.label2 = New System.Windows.Forms.Label
        Me.label3 = New System.Windows.Forms.Label
        Me.numericUpDown1 = New System.Windows.Forms.NumericUpDown
        Me.panel1.SuspendLayout()
        CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Text = "Chart Margins can be expressed as percentage or pixels." + vbCr + vbLf + vbCr + vbLf + "tChart1.Panel.MarginUnits = " + _
        "Steema.TeeChart.PanelMarginUnits.Pixels" + vbCr + vbLf + "tChart1.Panel.MarginLeft = 10 ' <--- 10 pixels"
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.numericUpDown1)
        Me.panel1.Controls.Add(Me.label3)
        Me.panel1.Controls.Add(Me.label2)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Controls.Add(Me.comboBox1)
        Me.panel1.Name = "panel1"
        ' 
        ' tChart1
        ' 
        ' 
        ' tChart1.Aspect
        ' 
        Me.tChart1.Aspect.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality
        Me.tChart1.Aspect.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        Me.tChart1.Cursor = System.Windows.Forms.Cursors.Default
        ' 
        ' tChart1.Header
        ' 
        Me.tChart1.Header.Lines = New String() {"Margin Pixels"}
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Brush
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
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
        ' comboBox1
        ' 
        Me.comboBox1.Items.AddRange(New Object() {"Percentage", "Pixels"})
        Me.comboBox1.Location = New System.Drawing.Point(99, 9)
        Me.comboBox1.Name = "comboBox1"
        Me.comboBox1.Size = New System.Drawing.Size(90, 21)
        Me.comboBox1.Sorted = True
        Me.comboBox1.TabIndex = 0
        Me.comboBox1.Text = "Pixels"
        AddHandler Me.comboBox1.SelectedIndexChanged, AddressOf Me.comboBox1_SelectedIndexChanged
        ' 
        ' label1
        ' 
        Me.label1.Location = New System.Drawing.Point(15, 12)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(72, 16)
        Me.label1.TabIndex = 1
        Me.label1.Text = "Margin Units:"
        ' 
        ' label2
        ' 
        Me.label2.Location = New System.Drawing.Point(214, 13)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(48, 16)
        Me.label2.TabIndex = 3
        Me.label2.Text = "Value:"
        ' 
        ' label3
        ' 
        Me.label3.Location = New System.Drawing.Point(321, 15)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(42, 12)
        Me.label3.TabIndex = 4
        ' 
        ' numericUpDown1
        ' 
        Me.numericUpDown1.Location = New System.Drawing.Point(267, 11)
        Me.numericUpDown1.Name = "numericUpDown1"
        Me.numericUpDown1.Size = New System.Drawing.Size(49, 20)
        Me.numericUpDown1.TabIndex = 6
        AddHandler Me.numericUpDown1.ValueChanged, AddressOf Me.numericUpDown1_ValueChanged
        ' 
        ' Panel_MarginUnits
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(440, 317)
        Me.Name = "Panel_MarginUnits"
        Me.panel1.ResumeLayout(False)
        CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub 'New 
#End Region


    Private Sub comboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        If comboBox1.SelectedIndex = 0 Then
            tChart1.Panel.MarginUnits = Steema.TeeChart.PanelMarginUnits.Percent
            label3.Text = "%"
        Else
            tChart1.Panel.MarginUnits = Steema.TeeChart.PanelMarginUnits.Pixels
            label3.Text = "Pixels"
        End If
    End Sub 'comboBox1_SelectedIndexChanged


    Private Sub numericUpDown1_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        tChart1.Panel.MarginLeft = System.Convert.ToDouble(numericUpDown1.Value)
        tChart1.Panel.MarginTop = System.Convert.ToDouble(numericUpDown1.Value)
        tChart1.Panel.MarginRight = System.Convert.ToDouble(numericUpDown1.Value)
        tChart1.Panel.MarginBottom = System.Convert.ToDouble(numericUpDown1.Value)
    End Sub 'numericUpDown1_ValueChanged
End Class 'Margins_Units