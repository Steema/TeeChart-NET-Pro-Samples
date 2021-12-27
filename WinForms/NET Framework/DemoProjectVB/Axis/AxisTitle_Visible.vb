
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Public Class AxisTitle_Visible
    Inherits Samples.BaseForm
    Private pointSeries1 As Steema.TeeChart.Styles.Points
    Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
    Private WithEvents textBox2 As System.Windows.Forms.TextBox
    Private label1 As System.Windows.Forms.Label
    Private WithEvents button1 As System.Windows.Forms.Button
    Private components As System.ComponentModel.IContainer = Nothing

    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        pointSeries1.FillSampleValues(20)
        textBox2.Text = tChart1.Axes.Left.Title.Caption
        tChart1.Axes.Left.Title.Angle = 90
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AxisTitle_Visible))
        Me.pointSeries1 = New Steema.TeeChart.Styles.Points
        Me.checkBox1 = New System.Windows.Forms.CheckBox
        Me.textBox2 = New System.Windows.Forms.TextBox
        Me.label1 = New System.Windows.Forms.Label
        Me.button1 = New System.Windows.Forms.Button
        Me.panel1.SuspendLayout()
        Me.chartContainer.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.BackColor = System.Drawing.Color.AliceBlue
        Me.textBox1.Size = New System.Drawing.Size(466, 40)
        Me.textBox1.TabIndex = 0
        Me.textBox1.Text = ("Chart Axis Title has a Visible property (defaults to true) and extended Font and " + "formatting properties.")
        ' 
        ' panel1
        ' 
        Me.panel1.BackColor = System.Drawing.SystemColors.Control
        Me.panel1.Controls.Add(Me.button1)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Controls.Add(Me.textBox2)
        Me.panel1.Controls.Add(Me.checkBox1)
        Me.panel1.Location = New System.Drawing.Point(0, 40)
        Me.panel1.Size = New System.Drawing.Size(466, 33)
        Me.panel1.TabIndex = 1
        ' 
        ' tChart1
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Aspect.ZOffset = 0
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Bottom.Grid.Visible = False
        Me.tChart1.Axes.Bottom.MaximumOffset = 5
        Me.tChart1.Axes.Bottom.MinimumOffset = 5
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Left.Grid.Visible = False
        Me.tChart1.Axes.Left.LogarithmicBase = 2
        Me.tChart1.Axes.Left.MaximumOffset = 5
        Me.tChart1.Axes.Left.MinimumOffset = 5
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Left.Title.Caption = "Temperature [C]"
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Left.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Left.Title.Font.Shadow.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.tChart1.Axes.Left.Title.Font.Shadow.Visible = True
        Me.tChart1.Axes.Left.Title.Lines = New String() {"Temperature [C]"}
        Me.tChart1.Cursor = System.Windows.Forms.Cursors.Default
        ' 
        ' 
        ' 
        Me.tChart1.Header.Lines = New String() {"tChart1"}
        Me.tChart1.Header.Visible = False
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Legend.Pen.Visible = False
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Legend.Shadow.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tChart1.Legend.Shadow.Height = 2
        Me.tChart1.Legend.Shadow.Width = 2
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        ' 
        ' 
        ' 
        Me.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tChart1.Panel.MarginTop = 10
        Me.tChart1.Series.Add(Me.pointSeries1)
        Me.tChart1.Size = New System.Drawing.Size(466, 213)
        Me.tChart1.TabIndex = 2
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Walls.Back.Visible = False
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Walls.Bottom.Pen.Visible = False
        Me.tChart1.Walls.Bottom.Size = 5
        Me.tChart1.Walls.Left.Pen.Visible = False
        Me.tChart1.Walls.Left.Size = 5
        ' 
        ' chartContainer
        ' 
        Me.chartContainer.Location = New System.Drawing.Point(0, 73)
        Me.chartContainer.Size = New System.Drawing.Size(466, 213)
        ' 
        ' pointSeries1
        ' 
        Me.pointSeries1.Color = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pointSeries1.ColorEach = False
        ' 
        ' 
        ' 
        Me.pointSeries1.LinePen.Color = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.pointSeries1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None
        Me.pointSeries1.Marks.Callout.ArrowHeadSize = 8
        ' 
        ' 
        ' 
        Me.pointSeries1.Marks.Callout.Brush.Color = System.Drawing.Color.Black
        Me.pointSeries1.Marks.Callout.Distance = 0
        Me.pointSeries1.Marks.Callout.Draw3D = False
        Me.pointSeries1.Marks.Callout.Length = 0
        Me.pointSeries1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.pointSeries1.Marks.Callout.Visible = False
        Me.pointSeries1.Pointer.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        ' 
        ' 
        ' 
        Me.pointSeries1.Pointer.Pen.Color = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.pointSeries1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.pointSeries1.Title = "pointSeries1"
        ' 
        ' 
        ' 
        Me.pointSeries1.XValues.DataMember = "X"
        Me.pointSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' 
        ' 
        Me.pointSeries1.YValues.DataMember = "Y"
        ' 
        ' checkBox1
        ' 
        Me.checkBox1.Checked = True
        Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox1.Location = New System.Drawing.Point(13, 6)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(107, 21)
        Me.checkBox1.TabIndex = 0
        Me.checkBox1.Text = "&Visible axis title"
        AddHandler checkBox1.CheckedChanged, AddressOf Me.checkBox1_CheckedChanged
        ' 
        ' textBox2
        ' 
        Me.textBox2.Location = New System.Drawing.Point(208, 6)
        Me.textBox2.Name = "textBox2"
        Me.textBox2.Size = New System.Drawing.Size(120, 20)
        Me.textBox2.TabIndex = 2
        Me.textBox2.Text = "textBox2"
        AddHandler textBox2.TextChanged, AddressOf Me.textBox2_TextChanged
        ' 
        ' label1
        ' 
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(152, 8)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(48, 13)
        Me.label1.TabIndex = 1
        Me.label1.Text = "Axis &title:"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        ' 
        ' button1
        ' 
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.Location = New System.Drawing.Point(344, 5)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(104, 23)
        Me.button1.TabIndex = 3
        Me.button1.Text = "&Edit Title..."
        AddHandler button1.Click, AddressOf Me.button1_Click
        ' 
        ' Axis_TitleVisible
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(466, 286)
        Me.Name = "Axis_TitleVisible"
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.chartContainer.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub 'InitializeComponent 
#End Region
    Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox1.CheckedChanged
        tChart1.Axes.Left.Title.Visible = checkBox1.Checked
    End Sub 'checkBox1_CheckedChanged


    Private Sub textBox2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles textBox2.TextChanged
        tChart1.Axes.Left.Title.Caption = textBox2.Text
    End Sub 'textBox2_TextChanged

    Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
        Dim a As New TeeChart.Editors.AxisEditor(tChart1.Axes.Left, Nothing, False)
        Try
            a.SelectTab(3) ' Title tab
            TeeChart.Editors.EditorUtils.ShowFormModal(a, Me)
        Finally
            a.Dispose()
        End Try
    End Sub 'button1_Click
End Class 'AxisTitle_Visible
