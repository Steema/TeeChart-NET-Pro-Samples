
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms


Public Class AxisDepthDateTime
    Inherits Steema.TeeChart.Samples.BaseForm
    Private checkBox1 As System.Windows.Forms.CheckBox
    Private tower1 As Steema.TeeChart.Styles.Tower
    Private components As System.ComponentModel.IContainer = Nothing
    
    Public Sub New() ' This call is required by the Windows Form Designer.
        InitializeComponent()
        tower1.XValues.DateTime = True
        tower1.ZValues.DateTime = True
        tower1.FillSampleValues()
        tChart1.Axes.DepthTop.Labels.DateTimeFormat = "MMM-dd"
        tChart1.Axes.Depth.Labels.DateTimeFormat = "MMM-dd"
        tChart1.Axes.Bottom.Labels.DateTimeFormat = "MMM-dd"
        tChart1.Axes.DepthTop.Visible = True
        tChart1.Axes.Depth.Visible = True
        tChart1.Axes.DepthTop.Increment = 2
        tChart1.Axes.Depth.Increment = 2
        Dim i As Integer
        For i = 0 To tChart1.Axes.Count - 1
            tChart1.Axes(i).Labels.Font.Size = 12
        Next i
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
        Me.tower1 = New Steema.TeeChart.Styles.Tower
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.BackColor = System.Drawing.Color.AliceBlue
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Text = ("Depth and Depth-Top axes can be set to display date-time labels," & vbCrLf & "just like all other axis.")
        ' 
        ' panel1
        ' 
        Me.panel1.BackColor = System.Drawing.SystemColors.Control
        Me.panel1.Controls.Add(Me.checkBox1)
        Me.panel1.Name = "panel1"
        ' 
        ' tChart1
        ' 
        Me.tChart1.Cursor = System.Windows.Forms.Cursors.Default
        ' 
        ' tChart1.Header
        ' 
        Me.tChart1.Header.Lines = New String() {"TeeChart"}
        ' 
        ' tChart1.Legend
        ' 
        Me.tChart1.Legend.MaxNumRows = 8
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
        Me.tChart1.Series.Add(Me.tower1)
        ' 
        ' checkBox1
        ' 
        Me.checkBox1.Checked = True
        Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox1.Location = New System.Drawing.Point(8, 8)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(184, 24)
        Me.checkBox1.TabIndex = 0
        Me.checkBox1.Text = "DateTime Depth Axes"
        AddHandler checkBox1.Click, AddressOf Me.checkBox1_Click
        ' 
        ' tower1
        ' 
        ' 
        ' tower1.Brush
        ' 
        Me.tower1.Brush.Color = System.Drawing.Color.FromArgb(CType(102, Byte), CType(153, Byte), CType(255, Byte))
        Me.tower1.Origin = 0
        Me.tower1.PaletteMin = 0
        Me.tower1.PaletteStep = 0
        Me.tower1.StartColor = System.Drawing.Color.FromArgb(CType(254, Byte), CType(102, Byte), CType(153, Byte), CType(255, Byte))
        Me.tower1.Title = "tower1"
        ' 
        ' tower1.XValues
        ' 
        Me.tower1.XValues.DataMember = "X"
        ' 
        ' tower1.YValues
        ' 
        Me.tower1.YValues.DataMember = "Y"
        ' 
        ' tower1.ZValues
        ' 
        Me.tower1.ZValues.DataMember = "Z"
        ' 
        ' AxisDepthDateTime
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(440, 317)
        Me.Name = "AxisDepthDateTime"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub 'New


#End Region
   

    Private Sub checkBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        tower1.ZValues.DateTime = checkBox1.Checked
    End Sub 'checkBox1_Click
End Class 'AxisDepthDateTime