
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms


Public Class Axes_DrawBevels
    Inherits Steema.TeeChart.Samples.BaseForm
    Private checkBox1 As System.Windows.Forms.CheckBox
    Private label1 As System.Windows.Forms.Label
    Private numericUpDown1 As System.Windows.Forms.NumericUpDown
    Private comboBox1 As System.Windows.Forms.ComboBox
    Private bar1 As Steema.TeeChart.Styles.Bar
    Private components As System.ComponentModel.IContainer = Nothing
    
    Public Sub New() ' This call is required by the Windows Form Designer.
        InitializeComponent()
        'TODO : Add any initialization after the InitializeComponent call
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
        Me.checkBox1 = New System.Windows.Forms.CheckBox
        Me.label1 = New System.Windows.Forms.Label
        Me.numericUpDown1 = New System.Windows.Forms.NumericUpDown
        Me.comboBox1 = New System.Windows.Forms.ComboBox
        Me.bar1 = New Steema.TeeChart.Styles.Bar
        Me.panel1.SuspendLayout()
        CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.BackColor = System.Drawing.Color.AliceBlue
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Text = ("A small routine to display \""bevels\"" around the 4 default Chart axes." & vbCrLf & vbCrLf & "private v" & ("oid tChart1_AfterDraw(object sender, Steema.TeeChart.Drawing.Graphics3D g)" & vbCrLf & "{" & vbCrLf & " " & " DrawBevelsAroundAxis(g, Steema.TeeChart.Drawing.BevelStyles.Lowered, 2)" & vbCrLf & "}"))
        Me.panel1.BackColor = System.Drawing.SystemColors.Control
        Me.panel1.Controls.Add(Me.comboBox1)
        Me.panel1.Controls.Add(Me.numericUpDown1)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Controls.Add(Me.checkBox1)
        Me.panel1.Name = "panel1"
        ' 
        ' tChart1
        ' 
        ' 
        ' tChart1.Header
        ' 
        Me.tChart1.Header.Lines = New String() {"TeeChart"}
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Brush
        ' 
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
        Me.tChart1.Series.Add(Me.bar1)
        AddHandler tChart1.AfterDraw, AddressOf Me.tChart1_AfterDraw
        ' 
        ' checkBox1
        ' 
        Me.checkBox1.Checked = True
        Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox1.Location = New System.Drawing.Point(8, 8)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(144, 24)
        Me.checkBox1.TabIndex = 0
        Me.checkBox1.Text = "Draw Bevel around axis"
        AddHandler checkBox1.CheckedChanged, AddressOf Me.checkBox1_CheckedChanged
        ' 
        ' label1
        ' 
        Me.label1.Location = New System.Drawing.Point(176, 13)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(32, 19)
        Me.label1.TabIndex = 1
        Me.label1.Text = "&Size:"
        ' 
        ' numericUpDown1
        ' 
        Me.numericUpDown1.Location = New System.Drawing.Point(208, 12)
        Me.numericUpDown1.Name = "numericUpDown1"
        Me.numericUpDown1.Size = New System.Drawing.Size(59, 20)
        Me.numericUpDown1.TabIndex = 2
        Me.numericUpDown1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        AddHandler numericUpDown1.ValueChanged, AddressOf Me.numericUpDown1_ValueChanged
        ' 
        ' comboBox1
        ' 
        Me.comboBox1.Items.AddRange(New Object() {"Lowered", "Raised"})
        Me.comboBox1.Location = New System.Drawing.Point(288, 12)
        Me.comboBox1.Name = "comboBox1"
        Me.comboBox1.Size = New System.Drawing.Size(121, 21)
        Me.comboBox1.TabIndex = 3
        AddHandler comboBox1.SelectedIndexChanged, AddressOf Me.comboBox1_SelectedIndexChanged
        ' 
        ' bar1
        ' 
        Me.bar1.BarStyle = Steema.TeeChart.Styles.BarStyles.Ellipse
        ' 
        ' bar1.Brush
        ' 
        Me.bar1.Brush.Color = System.Drawing.Color.FromArgb(CType(102, Byte), CType(153, Byte), CType(255, Byte))
        Me.bar1.ColorEach = True
        ' 
        ' bar1.Marks
        ' 
        Me.bar1.Marks.Visible = False
        ' 
        ' bar1.Pen
        ' 
        Me.bar1.Pen.Color = System.Drawing.Color.FromArgb(CType(61, Byte), CType(92, Byte), CType(153, Byte))
        Me.bar1.Title = "bar1"
        ' 
        ' bar1.XValues
        ' 
        Me.bar1.XValues.DataMember = "X"
        Me.bar1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' bar1.YValues
        ' 
        Me.bar1.YValues.DataMember = "Bar"
        ' 
        ' AxisDrawBevels
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(440, 317)
        Me.Name = "AxisDrawBevels"
        AddHandler Load, AddressOf Me.AxisDrawBevels_Load
        Me.panel1.ResumeLayout(False)
        CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub 'New 
#End Region

    Private Sub AxisDrawBevels_Load(ByVal sender As Object, ByVal e As System.EventArgs)
        tChart1.Aspect.View3D = False
        comboBox1.SelectedIndex = 0
        tChart1(0).FillSampleValues()
    End Sub 'AxisDrawBevels_Load


    Private Sub AdjustAxisOffsets()
        Dim tmpSize As Integer
        If Me.checkBox1.Checked Then
            tmpSize = Convert.ToInt32(Me.numericUpDown1.Value)
        Else
            tmpSize = 0
        End If
        Dim t As Integer
        For t = 0 To tChart1.Axes.Count - 1
            tChart1.Axes(t).MinimumOffset = tmpSize + 1
            tChart1.Axes(t).MaximumOffset = tmpSize + 1
        Next t

        tChart1.Refresh()
    End Sub 'AdjustAxisOffsets


    Private Sub DrawBevelsAroundAxis(ByVal e As Steema.TeeChart.Drawing.Graphics3D, ByVal style As Steema.TeeChart.Drawing.BevelStyles, ByVal size As Integer)
        Dim bevel As New Steema.TeeChart.Drawing.Bevel(tChart1.Chart)
        bevel.Inner = Steema.TeeChart.Drawing.BevelStyles.None
        bevel.Outer = style
        bevel.Width = size
        bevel.Draw(e, e.Chart.ChartRect)
    End Sub 'DrawBevelsAroundAxis

    Private Sub tChart1_AfterDraw(ByVal sender As Object, ByVal g As Steema.TeeChart.Drawing.Graphics3D) Handles tChart1.AfterDraw
        If checkBox1.Checked Then
            Select Case comboBox1.SelectedIndex
                Case 0
                    DrawBevelsAroundAxis(g, Steema.TeeChart.Drawing.BevelStyles.Lowered, Convert.ToInt32(numericUpDown1.Value))
                Case 1
                    DrawBevelsAroundAxis(g, Steema.TeeChart.Drawing.BevelStyles.Raised, Convert.ToInt32(numericUpDown1.Value))
            End Select
        End If
    End Sub 'tChart1_AfterDraw


    Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        comboBox1.Enabled = checkBox1.Checked
        numericUpDown1.Enabled = checkBox1.Checked
        AdjustAxisOffsets()
    End Sub 'checkBox1_CheckedChanged


    Private Sub numericUpDown1_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        AdjustAxisOffsets()
    End Sub 'numericUpDown1_ValueChanged


    Private Sub comboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        AdjustAxisOffsets()
    End Sub 'comboBox1_SelectedIndexChanged
End Class 'Axes_DrawBevels