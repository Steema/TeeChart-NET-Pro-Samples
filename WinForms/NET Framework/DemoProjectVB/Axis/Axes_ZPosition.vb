
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Public Class Axes_ZPosition
    Inherits Steema.TeeChart.Samples.BaseForm
    Private comboBox1 As System.Windows.Forms.ComboBox
    Private hScrollBar1 As System.Windows.Forms.HScrollBar
    Private label1 As System.Windows.Forms.Label
    Private line1 As Steema.TeeChart.Styles.Line
    Private components As System.ComponentModel.IContainer = Nothing
    
    Public Sub New() ' This call is required by the Windows Form Designer.
        InitializeComponent()
        'TODO: Add any initialization after the InitializeComponent call
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
    '/// <summary>
    '/// Required method for Designer support - do not modify
    '/// the contents of this method with the code editor.
    '/// </summary>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Axes_ZPosition))
        Me.comboBox1 = New System.Windows.Forms.ComboBox
        Me.hScrollBar1 = New System.Windows.Forms.HScrollBar
        Me.label1 = New System.Windows.Forms.Label
        Me.line1 = New Steema.TeeChart.Styles.Line
        Me.panel1.SuspendLayout()
        Me.chartContainer.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.BackColor = System.Drawing.Color.AliceBlue
        Me.textBox1.Size = New System.Drawing.Size(630, 63)
        Me.textBox1.TabIndex = 0
        Me.textBox1.Text = ("Axes can be positioned along the Z (depth) direction." & vbCrLf & "Example : tChart1.Axes.Lef" & "t.ZPosition = 100" & vbCrLf & vbCrLf & "Axes grid lines can be displayed at any Z position.")
        ' 
        ' panel1
        ' 
        Me.panel1.BackColor = System.Drawing.SystemColors.Control
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Controls.Add(Me.hScrollBar1)
        Me.panel1.Controls.Add(Me.comboBox1)
        Me.panel1.Location = New System.Drawing.Point(0, 63)
        Me.panel1.Size = New System.Drawing.Size(630, 33)
        Me.panel1.TabIndex = 1
        ' 
        ' tChart1
        ' 
        Me.tChart1.Aspect.Chart3DPercent = 100
        Me.tChart1.Aspect.ColorPaletteIndex = 3
        Me.tChart1.Aspect.ZOffset = 0
        Me.tChart1.Header.Font.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tChart1.Header.Font.Shadow.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.tChart1.Header.Font.Shadow.Visible = True
        Me.tChart1.Header.Lines = New String() {"Axes Positioned"}
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tChart1.Series.Add(Me.line1)
        Me.tChart1.Size = New System.Drawing.Size(630, 297)
        Me.tChart1.TabIndex = 2
        Me.tChart1.Walls.Bottom.Pen.Visible = False
        Me.tChart1.Walls.Bottom.Size = 5
        Me.tChart1.Walls.Left.Pen.Visible = False
        Me.tChart1.Walls.Left.Size = 5
        ' 
        ' chartContainer
        ' 
        Me.chartContainer.Location = New System.Drawing.Point(0, 96)
        Me.chartContainer.Size = New System.Drawing.Size(630, 297)
        ' 
        ' comboBox1
        ' 
        Me.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboBox1.Items.AddRange(New Object() {"Left Axis", "Right Axis"})
        Me.comboBox1.Location = New System.Drawing.Point(8, 6)
        Me.comboBox1.Name = "comboBox1"
        Me.comboBox1.Size = New System.Drawing.Size(101, 21)
        Me.comboBox1.TabIndex = 0
        AddHandler comboBox1.SelectedIndexChanged, AddressOf Me.comboBox1_SelectedIndexChanged
        ' 
        ' hScrollBar1
        ' 
        Me.hScrollBar1.Location = New System.Drawing.Point(208, 8)
        Me.hScrollBar1.Name = "hScrollBar1"
        Me.hScrollBar1.Size = New System.Drawing.Size(134, 17)
        Me.hScrollBar1.TabIndex = 2
        AddHandler hScrollBar1.Scroll, AddressOf Me.hScrollBar1_Scroll
        ' 
        ' label1
        ' 
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(128, 8)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(70, 13)
        Me.label1.TabIndex = 1
        Me.label1.Text = "&Z position % :"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        ' 
        ' line1
        ' 
        ' 
        ' 
        ' 
        Me.line1.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.line1.Color = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.line1.ColorEach = False
        ' 
        ' 
        ' 
        Me.line1.LinePen.Color = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.line1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None
        Me.line1.Marks.Callout.ArrowHeadSize = 8
        ' 
        ' 
        ' 
        Me.line1.Marks.Callout.Brush.Color = System.Drawing.Color.Black
        Me.line1.Marks.Callout.Distance = 0
        Me.line1.Marks.Callout.Draw3D = False
        Me.line1.Marks.Callout.Length = 10
        Me.line1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.line1.Marks.Callout.Visible = False
        ' 
        ' 
        ' 
        Me.line1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.line1.Title = "line1"
        Me.line1.VertAxis = Steema.TeeChart.Styles.VerticalAxis.Both
        ' 
        ' 
        ' 
        Me.line1.XValues.DataMember = "X"
        Me.line1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' 
        ' 
        Me.line1.YValues.DataMember = "Y"
        ' 
        ' Axes_ZPosition
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(630, 393)
        Me.Name = "Axes_ZPosition"
        AddHandler Load, AddressOf Me.ZPosition_Load
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.chartContainer.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub 'New 
#End Region
    Private Sub ZPosition_Load(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.comboBox1.SelectedIndex = 0
    End Sub 'ZPosition_Load
    Private Sub hScrollBar1_Scroll(ByVal sender As Object, ByVal e As System.Windows.Forms.ScrollEventArgs)
        If Me.comboBox1.SelectedIndex = 0 Then
            Me.tChart1.Axes.Left.ZPosition = Fix(Me.hScrollBar1.Value)
        Else
            Me.tChart1.Axes.Right.ZPosition = Fix(Me.hScrollBar1.Value)
        End If
    End Sub 'hScrollBar1_Scroll

    Private Sub comboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        If Me.comboBox1.SelectedIndex = 0 Then
            Me.hScrollBar1.Value = Fix(Me.tChart1.Axes.Left.ZPosition)
        Else
            Me.hScrollBar1.Value = Fix(Me.tChart1.Axes.Right.ZPosition)
        End If
    End Sub 'comboBox1_SelectedIndexChanged
End Class 'Axes_ZPosition