
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing

Imports System.Windows.Forms
Public Class Axis_Items
    Inherits Steema.TeeChart.Samples.BaseForm
    Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
    Private line1 As Steema.TeeChart.Styles.Line
    Private WithEvents numericUpDown1 As System.Windows.Forms.NumericUpDown
    Private WithEvents numericUpDown2 As System.Windows.Forms.NumericUpDown
    Private WithEvents button1 As System.Windows.Forms.Button
    Private label1 As System.Windows.Forms.Label
    Private components As System.ComponentModel.IContainer = Nothing
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        Dim values As Integer() = {200, 0, 123, 300, 260, -100, 650, 400}
        line1.Add(values)
        AddCustomLabels()
        SetDemoControls()
        numericUpDown2.Value = 123
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
        Me.line1 = New Steema.TeeChart.Styles.Line
        Me.numericUpDown1 = New System.Windows.Forms.NumericUpDown
        Me.numericUpDown2 = New System.Windows.Forms.NumericUpDown
        Me.button1 = New System.Windows.Forms.Button
        Me.label1 = New System.Windows.Forms.Label
        Me.panel1.SuspendLayout()
        CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.BackColor = System.Drawing.Color.AliceBlue
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(388, 63)
        Me.textBox1.Text = ("Axis can be customized to display labels at specific positions with" & vbCrLf & "custom text " + ("and formatting, without using any event:" & vbCrLf & vbCrLf & "tChart1.Axes.Left.Labels.Items.Add(1" & "23,\""Hello\"");"))
        ' 
        ' panel1
        ' 
        Me.panel1.BackColor = System.Drawing.SystemColors.Control
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Controls.Add(Me.button1)
        Me.panel1.Controls.Add(Me.numericUpDown2)
        Me.panel1.Controls.Add(Me.numericUpDown1)
        Me.panel1.Controls.Add(Me.checkBox1)
        Me.panel1.Location = New System.Drawing.Point(0, 63)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(388, 33)
        ' 
        ' tChart1
        ' 
        ' 
        ' tChart1.Aspect
        ' 
        Me.tChart1.Aspect.Chart3DPercent = 50
        Me.tChart1.Aspect.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality
        Me.tChart1.Aspect.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
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
        Me.tChart1.Header.Lines = New String() {"Custom axis labels "}
        ' 
        ' tChart1.Legend
        ' 
        Me.tChart1.Legend.BorderRound = 8
        ' 
        ' tChart1.Legend.Brush
        ' 
        Me.tChart1.Legend.Brush.Color = System.Drawing.Color.FromArgb(CType(254, Byte), CType(255, Byte), CType(255, Byte), CType(210, Byte))
        ' 
        ' tChart1.Legend.Font
        ' 
        ' 
        ' tChart1.Legend.Font.Brush
        ' 
        Me.tChart1.Legend.Font.Brush.Color = System.Drawing.Color.FromArgb(CType(254, Byte), CType(0, Byte), CType(0, Byte), CType(128, Byte))
        ' 
        ' tChart1.Legend.Pen
        ' 
        Me.tChart1.Legend.Pen.Color = System.Drawing.Color.FromArgb(CType(254, Byte), CType(255, Byte), CType(255, Byte), CType(192, Byte))
        ' 
        ' tChart1.Legend.Shadow
        ' 
        Me.tChart1.Legend.Shadow.Visible = False
        Me.tChart1.Legend.ShapeStyle = Steema.TeeChart.Drawing.TextShapeStyle.RoundRectangle
        Me.tChart1.Location = New System.Drawing.Point(0, 96)
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
        Me.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(254, Byte), CType(192, Byte), CType(192, Byte), CType(255, Byte))
        Me.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(254, Byte), CType(192, Byte), CType(192, Byte), CType(255, Byte))
        Me.tChart1.Panel.Brush.Gradient.UseMiddle = True
        Me.tChart1.Panel.Brush.Gradient.Visible = True
        ' 
        ' tChart1.Panel.Gradient
        ' 
        Me.tChart1.Panel.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(254, Byte), CType(192, Byte), CType(192, Byte), CType(255, Byte))
        Me.tChart1.Panel.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(254, Byte), CType(192, Byte), CType(192, Byte), CType(255, Byte))
        Me.tChart1.Panel.Gradient.UseMiddle = True
        Me.tChart1.Panel.Gradient.Visible = True
        Me.tChart1.Series.Add(Me.line1)
        Me.tChart1.Size = New System.Drawing.Size(388, 151)
        ' 
        ' tChart1.Walls
        ' 
        ' 
        ' tChart1.Walls.Back
        ' 
        Me.tChart1.Walls.Back.Visible = False
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
        Me.checkBox1.Location = New System.Drawing.Point(13, 7)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(91, 18)
        Me.checkBox1.TabIndex = 0
        Me.checkBox1.Text = "&Custom labels"
        AddHandler checkBox1.CheckedChanged, AddressOf Me.checkBox1_CheckedChanged
        ' 
        ' line1
        ' 
        ' 
        ' line1.Brush
        ' 
        Me.line1.Brush.Color = System.Drawing.Color.FromArgb(CType(254, Byte), CType(223, Byte), CType(0, Byte), CType(0, Byte))
        ' 
        ' line1.LinePen
        ' 
        Me.line1.LinePen.Color = System.Drawing.Color.FromArgb(CType(254, Byte), CType(134, Byte), CType(0, Byte), CType(0, Byte))
        ' 
        ' line1.Pointer
        ' 
        Me.line1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.line1.Title = "line1"
        ' 
        ' line1.XValues
        ' 
        Me.line1.XValues.DataMember = "X"
        Me.line1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' line1.YValues
        ' 
        Me.line1.YValues.DataMember = "Y"
        ' 
        ' numericUpDown1
        ' 
        Me.numericUpDown1.Location = New System.Drawing.Point(152, 6)
        Me.numericUpDown1.Name = "numericUpDown1"
        Me.numericUpDown1.Size = New System.Drawing.Size(40, 20)
        Me.numericUpDown1.TabIndex = 1
        AddHandler numericUpDown1.ValueChanged, AddressOf Me.numericUpDown1_ValueChanged
        ' 
        ' numericUpDown2
        ' 
        Me.numericUpDown2.Location = New System.Drawing.Point(195, 6)
        Me.numericUpDown2.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.numericUpDown2.Minimum = New Decimal(New Integer() {10000, 0, 0, -2147483648})
        Me.numericUpDown2.Name = "numericUpDown2"
        Me.numericUpDown2.Size = New System.Drawing.Size(61, 20)
        Me.numericUpDown2.TabIndex = 2
        AddHandler numericUpDown2.ValueChanged, AddressOf Me.numericUpDown2_ValueChanged
        ' 
        ' button1
        ' 
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.Location = New System.Drawing.Point(272, 5)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(56, 24)
        Me.button1.TabIndex = 3
        Me.button1.Text = "&Edit..."
        AddHandler button1.Click, AddressOf Me.button1_Click
        ' 
        ' label1
        ' 
        Me.label1.Location = New System.Drawing.Point(112, 8)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(40, 16)
        Me.label1.TabIndex = 4
        Me.label1.Text = "&Label:"
        ' 
        ' Axis_Items
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(388, 247)
        Me.Name = "Axis_Items"
        Me.Text = "Axis_Items"
        Me.panel1.ResumeLayout(False)
        CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub 'InitializeComponent 
#End Region


    Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox1.CheckedChanged
        If checkBox1.Checked Then
            AddCustomLabels()
        Else
            tChart1.Axes.Left.Labels.Items.Clear()
        End If
        SetDemoControls()
    End Sub 'checkBox1_CheckedChanged
    Private Sub AddCustomLabels()
        tChart1.Axes.Left.Labels.Items.Clear()
        tChart1.Axes.Left.Labels.Items.Add(123, "Hello").Font.Size = 16
        tChart1.Axes.Left.Labels.Items.Add(466, "Good" + vbLf + vbCr + "bye").Transparent = False
        tChart1.Axes.Left.Labels.Items.Add(300)
        Dim a As AxisLabelItem = tChart1.Axes.Left.Labels.Items.Add(-100)
        a.Transparent = False
        a.Color = Color.Blue
        a.Transparency = 50
    End Sub 'AddCustomLabels


    Private Sub SetDemoControls()
        numericUpDown1.Enabled = tChart1.Axes.Left.Labels.Items.Count > 0

        If numericUpDown1.Enabled Then
            numericUpDown1.Maximum = tChart1.Axes.Left.Labels.Items.Count - 1
        End If
        numericUpDown2.Enabled = numericUpDown1.Enabled
        button1.Enabled = numericUpDown1.Enabled
    End Sub 'SetDemoControls


    Private Sub numericUpDown1_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles numericUpDown1.ValueChanged
        numericUpDown2.Value = System.Convert.ToDecimal(tChart1.Axes.Left.Labels.Items(Fix(numericUpDown1.Value)).Value)
    End Sub 'numericUpDown1_ValueChanged


    Private Sub numericUpDown2_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles numericUpDown2.ValueChanged
        tChart1.Axes.Left.Labels.Items(Fix(numericUpDown1.Value)).Value = System.Convert.ToDouble(numericUpDown2.Value)
    End Sub 'numericUpDown2_ValueChanged


    Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
        Dim s As New Editors.CustomShapeEditor(tChart1.Axes.Left.Labels.Items(Fix(numericUpDown1.Value)))
        Steema.TeeChart.Editors.EditorUtils.ShowFormModal(s, Me)
    End Sub 'button1_Click
End Class 'Axis_Items 
