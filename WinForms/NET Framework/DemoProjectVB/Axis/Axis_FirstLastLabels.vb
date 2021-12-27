
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms


Public Class AxisFirstLastLabels
    Inherits Steema.TeeChart.Samples.BaseForm
    Private checkBox1 As System.Windows.Forms.CheckBox
    Private line1 As Steema.TeeChart.Styles.Line
    Private components As System.ComponentModel.IContainer = Nothing
    
    Public Sub New() ' This call is required by the Windows Form Designer.
        InitializeComponent()
        line1.Clear()
        line1.Add(123, "First")
        line1.Add(456, "Second")
        line1.Add(321, "Third")
        line1.Add(234, "Last")
        AddHandler tChart1.Axes.Bottom.GetAxisDrawLabel, AddressOf Bottom_GetAxisDrawLabel
    End Sub
    '/ <summary>
    '/// Clean up any resources being used.
    '/// </summary>
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
        Me.line1 = New Steema.TeeChart.Styles.Line
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.BackColor = System.Drawing.Color.AliceBlue
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Text = ("The Axis \""GetAxisDrawLabel\"" event can be used for multiple purposes." & vbCrLf & "It is calle" & ("d just before the axis is going to draw a label." & vbCrLf & vbCrLf & "This example shows how to se" & "t a different text alignment for the first and" & vbCrLf & "last labels of the bottom axis."))
        ' 
        ' panel1
        ' 
        Me.panel1.BackColor = System.Drawing.SystemColors.Control
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
        Me.tChart1.Series.Add(Me.line1)
        ' 
        ' checkBox1
        ' 
        Me.checkBox1.Checked = True
        Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox1.Location = New System.Drawing.Point(16, 8)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(248, 24)
        Me.checkBox1.TabIndex = 0
        Me.checkBox1.Text = "First and last bottom axis labels aligned"
        AddHandler checkBox1.Click, AddressOf Me.checkBox1_Click
        ' 
        ' line1
        ' 
        ' 
        ' line1.Brush
        ' 
        Me.line1.Brush.Color = System.Drawing.Color.FromArgb(CType(102, Byte), CType(153, Byte), CType(255, Byte))
        Me.line1.ColorEach = True
        ' 
        ' line1.LinePen
        ' 
        Me.line1.LinePen.Color = System.Drawing.Color.FromArgb(CType(61, Byte), CType(92, Byte), CType(153, Byte))
        ' 
        ' line1.Pointer
        '                         
        Me.line1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.line1.Pointer.Visible = True
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
        ' AxisFirstLastLabels
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(440, 317)
        Me.Name = "AxisFirstLastLabels"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub 'New

#End Region

    Private Sub Bottom_GetAxisDrawLabel(ByVal sender As Object, ByVal e As Steema.TeeChart.GetAxisDrawLabelEventArgs)
        Dim bottom As Steema.TeeChart.Axis = CType(sender, Steema.TeeChart.Axis)

        bottom.Labels.Font.Bold = False
        If Me.checkBox1.Checked Then
            If e.X = bottom.CalcPosValue(bottom.Minimum) Then
                bottom.Chart.Graphics3D.TextAlign = System.Drawing.StringAlignment.Near
                bottom.Labels.Font.Bold = True
            ElseIf e.X = bottom.CalcPosValue(bottom.Maximum) Then
                bottom.Chart.Graphics3D.TextAlign = System.Drawing.StringAlignment.Far
                bottom.Labels.Font.Bold = True
            Else
                bottom.Labels.Font.Bold = False
            End If
        End If
    End Sub 'Bottom_GetAxisDrawLabel

    Private Sub checkBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        tChart1.Refresh()
    End Sub 'checkBox1_Click
End Class 'AxisFirstLastLabels