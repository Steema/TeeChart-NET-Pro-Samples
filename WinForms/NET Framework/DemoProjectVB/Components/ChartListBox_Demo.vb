
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms


Public Class ChartListBox_Demo
    Inherits Steema.TeeChart.Samples.BaseNoChart
    Private chartListBox1 As Steema.TeeChart.ChartListBox
    Private tChart1 As Steema.TeeChart.TChart
#If VS2005 Then
    Private commander1 As Steema.TeeChart.ChartController
#Else
    Private commander1 As Steema.TeeChart.Commander
#End If
    Private line1 As Steema.TeeChart.Styles.Line
    Private line2 As Steema.TeeChart.Styles.Line
    Private points1 As Steema.TeeChart.Styles.Points
    Private bar1 As Steema.TeeChart.Styles.Bar
    Private bar2 As Steema.TeeChart.Styles.Bar
    Private checkBox1 As System.Windows.Forms.CheckBox
    Private checkBox2 As System.Windows.Forms.CheckBox
    Private checkBox3 As System.Windows.Forms.CheckBox
    Private checkBox4 As System.Windows.Forms.CheckBox
    Private splitter1 As System.Windows.Forms.Splitter
    Private components As System.ComponentModel.IContainer = Nothing
    
    Public Sub New() ' This call is required by the Windows Form Designer.
        InitializeComponent()
        For Each s As TeeChart.Styles.Series In tChart1.Series
            s.FillSampleValues(7)
        Next
    End Sub


    '/ <summary>
    '/ Clean up any resources being used.
    '/ </summary>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If Disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(Disposing)
    End Sub 'Dispose

#Region "Windows Form Designer generated code"

    '/ <summary>
    '/ Required method for Designer support - do not modify
    '/ the contents of this method with the code editor.
    '/ </summary>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.chartListBox1 = New Steema.TeeChart.ChartListBox(Me.components)
        Me.tChart1 = New Steema.TeeChart.TChart
        Me.line1 = New Steema.TeeChart.Styles.Line
        Me.line2 = New Steema.TeeChart.Styles.Line
        Me.points1 = New Steema.TeeChart.Styles.Points
        Me.bar1 = New Steema.TeeChart.Styles.Bar
        Me.bar2 = New Steema.TeeChart.Styles.Bar
#If VS2005 Then
        Me.commander1 = New Steema.TeeChart.ChartController
#Else
        Me.commander1 = New Steema.TeeChart.Commander
#End If
        Me.checkBox1 = New System.Windows.Forms.CheckBox
        Me.checkBox2 = New System.Windows.Forms.CheckBox
        Me.checkBox3 = New System.Windows.Forms.CheckBox
        Me.checkBox4 = New System.Windows.Forms.CheckBox
        Me.splitter1 = New System.Windows.Forms.Splitter
        Me.panel1.SuspendLayout()
        Me.panel2.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(513, 62)
        Me.textBox1.Text = "The ""Chart List Box"" component is a custom ListBox to display all Series inside a Chart component." + vbCr + vbLf + "The end-user can show and hide individual Series and change the default Series color or the Series type itself." + vbCr + vbLf + vbCr + vbLf + "Several properties allow customization of the Listbox. Try clicking, double-clicking and dragging on the listbox."
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.checkBox4)
        Me.panel1.Controls.Add(Me.checkBox3)
        Me.panel1.Controls.Add(Me.checkBox2)
        Me.panel1.Controls.Add(Me.checkBox1)
        Me.panel1.Controls.Add(Me.commander1)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(513, 77)
        ' 
        ' panel2
        ' 
        Me.panel2.Controls.Add(Me.splitter1)
        Me.panel2.Controls.Add(Me.tChart1)
        Me.panel2.Controls.Add(Me.chartListBox1)
        Me.panel2.Location = New System.Drawing.Point(0, 139)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(513, 153)
        ' 
        ' chartListBox1
        ' 
        Me.chartListBox1.AllowDrop = True
        Me.chartListBox1.Chart = Me.tChart1
        Me.chartListBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.chartListBox1.IntegralHeight = False
        Me.chartListBox1.Location = New System.Drawing.Point(0, 0)
        Me.chartListBox1.Name = "chartListBox1"
        Me.chartListBox1.OtherItems = Nothing
        Me.chartListBox1.Size = New System.Drawing.Size(112, 153)
        Me.chartListBox1.TabIndex = 0
        ' 
        ' tChart1
        ' 
        ' 
        ' tChart1.Aspect
        ' 
        Me.tChart1.Aspect.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality
        Me.tChart1.Aspect.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        Me.tChart1.Dock = System.Windows.Forms.DockStyle.Fill
        ' 
        ' tChart1.Header
        ' 
        Me.tChart1.Header.Lines = New String() {"TeeChart"}
        Me.tChart1.Header.Visible = False
        Me.tChart1.Location = New System.Drawing.Point(112, 0)
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Brush
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.tChart1.Series.Add(Me.line1)
        Me.tChart1.Series.Add(Me.line2)
        Me.tChart1.Series.Add(Me.points1)
        Me.tChart1.Series.Add(Me.bar1)
        Me.tChart1.Series.Add(Me.bar2)
        Me.tChart1.Size = New System.Drawing.Size(401, 153)
        Me.tChart1.TabIndex = 1
        ' 
        ' tChart1.Walls
        ' 
        ' 
        ' tChart1.Walls.Back
        ' 
        ' 
        ' tChart1.Walls.Back.Brush
        ' 
        Me.tChart1.Walls.Back.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(224, System.Byte), CType(224, System.Byte), CType(224, System.Byte))
        Me.tChart1.Walls.Back.Transparent = False
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
        ' tChart1.Walls.Left.Brush
        ' 
        Me.tChart1.Walls.Left.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(224, System.Byte))
        ' 
        ' tChart1.Walls.Left.Pen
        ' 
        Me.tChart1.Walls.Left.Pen.Visible = False
        Me.tChart1.Walls.Left.Size = 5
        ' 
        ' line1
        ' 
        ' 
        ' line1.Brush
        ' 
        Me.line1.Brush.Color = System.Drawing.Color.Red
        ' 
        ' line1.Marks
        ' 
        ' 
        ' line1.Marks.Symbol
        ' 
        ' 
        ' line1.Marks.Symbol.Shadow
        ' 
        Me.line1.Marks.Symbol.Shadow.Height = 1
        Me.line1.Marks.Symbol.Shadow.Visible = True
        Me.line1.Marks.Symbol.Shadow.Width = 1
        ' 
        ' line1.Pointer
        ' 
        ' 
        ' line1.Pointer.Brush
        ' 
        Me.line1.Pointer.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(0, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
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
        ' line2
        ' 
        ' 
        ' line2.Brush
        ' 
        Me.line2.Brush.Color = System.Drawing.Color.Green
        ' 
        ' line2.Marks
        ' 
        ' 
        ' line2.Marks.Symbol
        ' 
        ' 
        ' line2.Marks.Symbol.Shadow
        ' 
        Me.line2.Marks.Symbol.Shadow.Height = 1
        Me.line2.Marks.Symbol.Shadow.Visible = True
        Me.line2.Marks.Symbol.Shadow.Width = 1
        ' 
        ' line2.Pointer
        ' 
        ' 
        ' line2.Pointer.Brush
        ' 
        Me.line2.Pointer.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(0, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        Me.line2.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.line2.Title = "line2"
        ' 
        ' line2.XValues
        ' 
        Me.line2.XValues.DataMember = "X"
        Me.line2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' line2.YValues
        ' 
        Me.line2.YValues.DataMember = "Y"
        ' 
        ' points1
        ' 
        ' 
        ' points1.Marks
        ' 
        ' 
        ' points1.Marks.Symbol
        ' 
        ' 
        ' points1.Marks.Symbol.Shadow
        ' 
        Me.points1.Marks.Symbol.Shadow.Height = 1
        Me.points1.Marks.Symbol.Shadow.Visible = True
        Me.points1.Marks.Symbol.Shadow.Width = 1
        ' 
        ' points1.Pointer
        ' 
        ' 
        ' points1.Pointer.Brush
        ' 
        Me.points1.Pointer.Brush.Color = System.Drawing.Color.Yellow
        Me.points1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.points1.Title = "points1"
        ' 
        ' points1.XValues
        ' 
        Me.points1.XValues.DataMember = "X"
        Me.points1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' points1.YValues
        ' 
        Me.points1.YValues.DataMember = "Y"
        ' 
        ' bar1
        ' 
        ' 
        ' bar1.Brush
        ' 
        Me.bar1.Brush.Color = System.Drawing.Color.Blue
        ' 
        ' bar1.Marks
        ' 
        ' 
        ' bar1.Marks.Symbol
        ' 
        ' 
        ' bar1.Marks.Symbol.Shadow
        ' 
        Me.bar1.Marks.Symbol.Shadow.Height = 1
        Me.bar1.Marks.Symbol.Shadow.Visible = True
        Me.bar1.Marks.Symbol.Shadow.Width = 1
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
        ' bar2
        ' 
        ' 
        ' bar2.Brush
        ' 
        Me.bar2.Brush.Color = System.Drawing.Color.White
        ' 
        ' bar2.Marks
        ' 
        ' 
        ' bar2.Marks.Symbol
        ' 
        ' 
        ' bar2.Marks.Symbol.Shadow
        ' 
        Me.bar2.Marks.Symbol.Shadow.Height = 1
        Me.bar2.Marks.Symbol.Shadow.Visible = True
        Me.bar2.Marks.Symbol.Shadow.Width = 1
        Me.bar2.Title = "bar2"
        ' 
        ' bar2.XValues
        ' 
        Me.bar2.XValues.DataMember = "X"
        Me.bar2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' bar2.YValues
        ' 
        Me.bar2.YValues.DataMember = "Bar"
        ' 
        ' commander1
        ' 
        Me.commander1.Chart = Me.tChart1
        Me.commander1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.commander1.Location = New System.Drawing.Point(0, 40)
        Me.commander1.Name = "commander1"
        Me.commander1.Size = New System.Drawing.Size(513, 37)
        Me.commander1.TabIndex = 0
        ' 
        ' checkBox1
        ' 
        Me.checkBox1.Checked = True
        Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox1.Location = New System.Drawing.Point(13, 7)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(147, 21)
        Me.checkBox1.TabIndex = 1
        Me.checkBox1.Text = "Show &active checkbox"
        AddHandler Me.checkBox1.CheckedChanged, AddressOf Me.checkBox1_CheckedChanged
        ' 
        ' checkBox2
        ' 
        Me.checkBox2.Checked = True
        Me.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox2.Location = New System.Drawing.Point(153, 7)
        Me.checkBox2.Name = "checkBox2"
        Me.checkBox2.Size = New System.Drawing.Size(119, 21)
        Me.checkBox2.TabIndex = 2
        Me.checkBox2.Text = "Show series &color"
        AddHandler Me.checkBox2.CheckedChanged, AddressOf Me.checkBox2_CheckedChanged
        ' 
        ' checkBox3
        ' 
        Me.checkBox3.Checked = True
        Me.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox3.Location = New System.Drawing.Point(260, 7)
        Me.checkBox3.Name = "checkBox3"
        Me.checkBox3.Size = New System.Drawing.Size(116, 21)
        Me.checkBox3.TabIndex = 3
        Me.checkBox3.Text = "Show series &icon"
        AddHandler Me.checkBox3.CheckedChanged, AddressOf Me.checkBox3_CheckedChanged
        ' 
        ' checkBox4
        ' 
        Me.checkBox4.Checked = True
        Me.checkBox4.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox4.Location = New System.Drawing.Point(367, 7)
        Me.checkBox4.Name = "checkBox4"
        Me.checkBox4.Size = New System.Drawing.Size(121, 21)
        Me.checkBox4.TabIndex = 4
        Me.checkBox4.Text = "Show series &titles"
        AddHandler Me.checkBox4.CheckedChanged, AddressOf Me.checkBox4_CheckedChanged
        ' 
        ' splitter1
        ' 
        Me.splitter1.Location = New System.Drawing.Point(112, 0)
        Me.splitter1.Name = "splitter1"
        Me.splitter1.Size = New System.Drawing.Size(3, 153)
        Me.splitter1.TabIndex = 2
        Me.splitter1.TabStop = False
        ' 
        ' Component_ChartListBox
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(513, 292)
        Me.Name = "Component_ChartListBox"
        Me.panel1.ResumeLayout(False)
        Me.panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub 'New 
#End Region


    Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.chartListBox1.ShowActiveCheck = Me.checkBox1.Checked
    End Sub 'checkBox1_CheckedChanged


    Private Sub checkBox2_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.chartListBox1.ShowSeriesColor = Me.checkBox2.Checked
    End Sub 'checkBox2_CheckedChanged


    Private Sub checkBox3_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.chartListBox1.ShowSeriesIcon = Me.checkBox3.Checked
    End Sub 'checkBox3_CheckedChanged


    Private Sub checkBox4_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.chartListBox1.ShowSeriesTitle = Me.checkBox4.Checked
    End Sub 'checkBox4_CheckedChanged
End Class 'ChartListBox_Demo