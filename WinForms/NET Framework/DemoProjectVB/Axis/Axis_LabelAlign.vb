
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing

Imports System.Windows.Forms




Public Class Axis_LabelAlign
    Inherits Steema.TeeChart.Samples.BaseForm
    Private WithEvents radioButton1 As System.Windows.Forms.RadioButton
    Private radioButton2 As System.Windows.Forms.RadioButton
    Private label1 As System.Windows.Forms.Label
    Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
    Private horizBar1 As Steema.TeeChart.Styles.HorizBar
    Private components As System.ComponentModel.IContainer = Nothing
    
    
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ' Sample values 
        Me.horizBar1.Add(278, "Africa")
        Me.horizBar1.Add(123, "America")
        Me.horizBar1.Add(321, "Asia")
        Me.horizBar1.Add(432, "Australia")
        Me.horizBar1.Add(89, "Europe")
        Me.horizBar1.Add(300, "Moon")
        
        ' show % values
        Me.horizBar1.Marks.Style = TeeChart.Styles.MarksStyles.Percent
        ' Set axes labels to "opposite" alignment
        Me.tChart1.Axes.Left.Labels.Align = TeeChart.AxisLabelAlign.Opposite
        Me.tChart1.Axes.Right.Labels.Align = TeeChart.AxisLabelAlign.Opposite
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
        Me.radioButton1 = New System.Windows.Forms.RadioButton
        Me.radioButton2 = New System.Windows.Forms.RadioButton
        Me.label1 = New System.Windows.Forms.Label
        Me.checkBox1 = New System.Windows.Forms.CheckBox
        Me.horizBar1 = New Steema.TeeChart.Styles.HorizBar
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.BackColor = System.Drawing.Color.AliceBlue
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(440, 63)
        Me.textBox1.Text = ("Vertical axes can align their Labels to the opposite direction." & vbCrLf & "Note: The labels" & (" Angle should be 0 (no label rotation)." & vbCrLf & vbCrLf & "tChart1.Axes.Left.Labels.Align = TeeChart.AxisLabelAlign.Opposite"))
        ' 
        ' panel1
        ' 
        Me.panel1.BackColor = System.Drawing.SystemColors.Control
        Me.panel1.Controls.Add(Me.checkBox1)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Controls.Add(Me.radioButton2)
        Me.panel1.Controls.Add(Me.radioButton1)
        Me.panel1.Location = New System.Drawing.Point(0, 63)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(440, 33)
        ' 
        ' tChart1
        ' 
        ' 
        ' tChart1.Aspect
        ' 
        Me.tChart1.Aspect.Chart3DPercent = 20
        Me.tChart1.Aspect.ColorPaletteIndex = 3
        Me.tChart1.Aspect.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality
        Me.tChart1.Aspect.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        ' 
        ' tChart1.Axes
        ' 
        ' 
        ' tChart1.Axes.Bottom
        ' 
        ' 
        ' tChart1.Axes.Bottom.AxisPen
        ' 
        Me.tChart1.Axes.Bottom.AxisPen.Width = 1
        ' 
        ' tChart1.Axes.Bottom.Labels
        ' 
        ' 
        ' tChart1.Axes.Bottom.Labels.Font
        ' 
        ' 
        ' tChart1.Axes.Bottom.Labels.Font.Brush
        ' 
        Me.tChart1.Axes.Bottom.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(CType(254, Byte), CType(0, Byte), CType(0, Byte), CType(128, Byte))
        ' 
        ' tChart1.Axes.Left
        ' 
        ' 
        ' tChart1.Axes.Left.AxisPen
        ' 
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
        Me.tChart1.Header.Font.Shadow.Brush.Color = System.Drawing.Color.FromArgb(CType(254, Byte), CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.tChart1.Header.Font.Shadow.Visible = True
        Me.tChart1.Header.Lines = New String() {"Axis labels alignment"}
        ' 
        ' tChart1.Legend
        ' 
        ' 
        ' tChart1.Legend.Shadow
        ' 
        Me.tChart1.Legend.Shadow.Visible = False
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
        Me.tChart1.Series.Add(Me.horizBar1)
        Me.tChart1.Size = New System.Drawing.Size(440, 237)
        ' 
        ' tChart1.Walls
        ' 
        ' 
        ' tChart1.Walls.Back
        ' 
        ' 
        ' tChart1.Walls.Back.Brush
        ' 
        Me.tChart1.Walls.Back.Brush.Color = System.Drawing.Color.FromArgb(CType(63, Byte), CType(192, Byte), CType(192, Byte), CType(255, Byte))
        ' 
        ' tChart1.Walls.Back.Gradient
        ' 
        Me.tChart1.Walls.Back.Brush.Gradient.Transparency = 75
        ' 
        ' tChart1.Walls.Back.Gradient
        ' 
        Me.tChart1.Walls.Back.Gradient.Transparency = 75
        Me.tChart1.Walls.Back.Transparent = False
        ' 
        ' tChart1.Walls.Bottom
        ' 
        ' 
        ' tChart1.Walls.Bottom.Pen
        ' 
        Me.tChart1.Walls.Bottom.Pen.Visible = False
        ' 
        ' tChart1.Walls.Left
        ' 
        ' 
        ' tChart1.Walls.Left.Pen
        ' 
        Me.tChart1.Walls.Left.Pen.Visible = False
        Me.tChart1.Walls.Left.Size = 1
        ' 
        ' radioButton1
        ' 
        Me.radioButton1.Checked = True
        Me.radioButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.radioButton1.Location = New System.Drawing.Point(64, 8)
        Me.radioButton1.Name = "radioButton1"
        Me.radioButton1.Size = New System.Drawing.Size(47, 21)
        Me.radioButton1.TabIndex = 0
        Me.radioButton1.TabStop = True
        Me.radioButton1.Text = "&Left"
        AddHandler radioButton1.CheckedChanged, AddressOf Me.radioButton1_CheckedChanged
        ' 
        ' radioButton2
        ' 
        Me.radioButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.radioButton2.Location = New System.Drawing.Point(120, 8)
        Me.radioButton2.Name = "radioButton2"
        Me.radioButton2.Size = New System.Drawing.Size(79, 21)
        Me.radioButton2.TabIndex = 1
        Me.radioButton2.Text = "&Right"
        ' 
        ' label1
        ' 
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(20, 10)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(29, 16)
        Me.label1.TabIndex = 2
        Me.label1.Text = "Axis:"
        Me.label1.UseMnemonic = False
        ' 
        ' checkBox1
        ' 
        Me.checkBox1.Checked = True
        Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox1.Location = New System.Drawing.Point(216, 8)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(154, 21)
        Me.checkBox1.TabIndex = 3
        Me.checkBox1.Text = "&Opposite label alignment"
        AddHandler checkBox1.CheckedChanged, AddressOf Me.checkBox1_CheckedChanged
        ' 
        ' horizBar1
        ' 
        ' 
        ' horizBar1.Brush
        ' 
        Me.horizBar1.Brush.Color = System.Drawing.Color.FromArgb(CType(102, Byte), CType(153, Byte), CType(255, Byte))
        ' 
        ' horizBar1.Gradient
        ' 
        Me.horizBar1.Brush.Gradient.Direction = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        ' 
        ' horizBar1.Gradient
        ' 
        Me.horizBar1.Gradient.Direction = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        ' 
        ' horizBar1.Marks
        ' 
        Me.horizBar1.Marks.Visible = False
        ' 
        ' horizBar1.Pen
        ' 
        Me.horizBar1.Pen.Color = System.Drawing.Color.FromArgb(CType(61, Byte), CType(92, Byte), CType(153, Byte))
        Me.horizBar1.Title = "horizBar1"
        ' 
        ' horizBar1.XValues
        ' 
        Me.horizBar1.XValues.DataMember = "X"
        ' 
        ' horizBar1.YValues
        ' 
        Me.horizBar1.YValues.DataMember = "Bar"
        Me.horizBar1.YValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' Axis_LabelAlign
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(440, 333)
        Me.Name = "Axis_LabelAlign"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub 'InitializeComponent 
#End Region
    Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox1.CheckedChanged
        If Me.checkBox1.Checked Then
            Me.horizBar1.GetVertAxis.Labels.Align = TeeChart.AxisLabelAlign.Opposite
        Else
            Me.horizBar1.GetVertAxis.Labels.Align = TeeChart.AxisLabelAlign.Default
        End If
    End Sub 'checkBox1_CheckedChanged

    Private Sub radioButton1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles radioButton1.CheckedChanged
        If Me.radioButton1.Checked Then
            Me.horizBar1.VertAxis = TeeChart.Styles.VerticalAxis.Left
        Else
            Me.horizBar1.VertAxis = TeeChart.Styles.VerticalAxis.Right
        End If
        checkBox1_CheckedChanged(Me, New System.EventArgs)
    End Sub 'radioButton1_CheckedChanged
End Class 'Axis_LabelAlign
