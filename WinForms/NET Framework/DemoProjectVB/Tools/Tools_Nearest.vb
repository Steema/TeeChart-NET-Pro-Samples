
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing

Imports System.Windows.Forms




Public Class Tools_Nearest
    Inherits Samples.BaseForm
    Private pointSeries1 As Steema.TeeChart.Styles.Points
    Private nearestPoint1 As Steema.TeeChart.Tools.NearestPoint
    Private label1 As System.Windows.Forms.Label
    Private WithEvents comboBox1 As System.Windows.Forms.ComboBox
    Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
    Private WithEvents checkBox2 As System.Windows.Forms.CheckBox
    Private WithEvents button1 As System.Windows.Forms.Button
    Private components As System.ComponentModel.IContainer = Nothing
    
    
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        
        Me.pointSeries1.FillSampleValues(10)
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
        Me.pointSeries1 = New Steema.TeeChart.Styles.Points
        Me.nearestPoint1 = New Steema.TeeChart.Tools.NearestPoint
        Me.label1 = New System.Windows.Forms.Label
        Me.comboBox1 = New System.Windows.Forms.ComboBox
        Me.checkBox1 = New System.Windows.Forms.CheckBox
        Me.checkBox2 = New System.Windows.Forms.CheckBox
        Me.button1 = New System.Windows.Forms.Button
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'textBox1
        '
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(466, 63)
        Me.textBox1.Text = ("This tool draws ""hints"" (circles or rectangles) around Series points. When moving" + (" the mouse the ""hint"" locates the nearest point and displays the hint shape." & vbCrLf & vbCrLf + "It can be customized (border, pattern, style, etc)."))
        '
        'tChart1
        '
        '
        'tChart1.Aspect
        '
        Me.tChart1.Aspect.ElevationFloat = 345
        Me.tChart1.Aspect.RotationFloat = 345
        Me.tChart1.Aspect.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality
        Me.tChart1.Aspect.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        Me.tChart1.Aspect.View3D = False
        '
        'tChart1.Axes
        '
        '
        'tChart1.Axes.Bottom
        '
        Me.tChart1.Axes.Bottom.Automatic = True
        '
        'tChart1.Axes.Bottom.Grid
        '
        Me.tChart1.Axes.Bottom.Grid.ZPosition = 0
        '
        'tChart1.Axes.Depth
        '
        Me.tChart1.Axes.Depth.Automatic = True
        '
        'tChart1.Axes.Depth.Grid
        '
        Me.tChart1.Axes.Depth.Grid.ZPosition = 0
        '
        'tChart1.Axes.DepthTop
        '
        Me.tChart1.Axes.DepthTop.Automatic = True
        '
        'tChart1.Axes.DepthTop.Grid
        '
        Me.tChart1.Axes.DepthTop.Grid.ZPosition = 0
        '
        'tChart1.Axes.Left
        '
        Me.tChart1.Axes.Left.Automatic = True
        '
        'tChart1.Axes.Left.Grid
        '
        Me.tChart1.Axes.Left.Grid.ZPosition = 0
        '
        'tChart1.Axes.Right
        '
        Me.tChart1.Axes.Right.Automatic = True
        '
        'tChart1.Axes.Right.Grid
        '
        Me.tChart1.Axes.Right.Grid.ZPosition = 0
        '
        'tChart1.Axes.Top
        '
        Me.tChart1.Axes.Top.Automatic = True
        '
        'tChart1.Axes.Top.Grid
        '
        Me.tChart1.Axes.Top.Grid.ZPosition = 0
        '
        'tChart1.Header
        '
        Me.tChart1.Header.Alignment = System.Drawing.StringAlignment.Near
        Me.tChart1.Header.Lines = New String() {"Nearest tool example"}
        '
        'tChart1.Legend
        '
        '
        'tChart1.Legend.Shadow
        '
        Me.tChart1.Legend.Shadow.Visible = True
        '
        'tChart1.Legend.Title
        '
        '
        'tChart1.Legend.Title.Font
        '
        Me.tChart1.Legend.Title.Font.Bold = True
        '
        'tChart1.Legend.Title.Pen
        '
        Me.tChart1.Legend.Title.Pen.Visible = False
        Me.tChart1.Location = New System.Drawing.Point(0, 104)
        Me.tChart1.Name = "tChart1"
        '
        'tChart1.Panel
        '
        '
        'tChart1.Panel.Brush
        '
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(254, Byte), CType(255, Byte), CType(255, Byte), CType(255, Byte))
        Me.tChart1.Series.Add(Me.pointSeries1)
        Me.tChart1.Size = New System.Drawing.Size(466, 182)
        Me.tChart1.Tools.Add(Me.nearestPoint1)
        '
        'tChart1.Walls
        '
        '
        'tChart1.Walls.Back
        '
        Me.tChart1.Walls.Back.AutoHide = False
        '
        'tChart1.Walls.Bottom
        '
        Me.tChart1.Walls.Bottom.AutoHide = False
        '
        'tChart1.Walls.Left
        '
        Me.tChart1.Walls.Left.AutoHide = False
        '
        'tChart1.Walls.Right
        '
        Me.tChart1.Walls.Right.AutoHide = False
        '
        'panel1
        '
        Me.panel1.Controls.Add(Me.button1)
        Me.panel1.Controls.Add(Me.checkBox2)
        Me.panel1.Controls.Add(Me.checkBox1)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Controls.Add(Me.comboBox1)
        Me.panel1.Location = New System.Drawing.Point(0, 63)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(466, 41)
        '
        'pointSeries1
        '
        '
        'pointSeries1.Marks
        '
        '
        'pointSeries1.Marks.Callout
        '
        Me.pointSeries1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None
        Me.pointSeries1.Marks.Callout.ArrowHeadSize = 8
        '
        'pointSeries1.Marks.Callout.Brush
        '
        Me.pointSeries1.Marks.Callout.Brush.Color = System.Drawing.Color.Black
        Me.pointSeries1.Marks.Callout.Distance = 0
        Me.pointSeries1.Marks.Callout.Draw3D = False
        Me.pointSeries1.Marks.Callout.Length = 0
        Me.pointSeries1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        '
        'pointSeries1.Marks.Shadow
        '
        Me.pointSeries1.Marks.Shadow.Visible = True
        '
        'pointSeries1.Marks.Symbol
        '
        '
        'pointSeries1.Marks.Symbol.Shadow
        '
        Me.pointSeries1.Marks.Symbol.Shadow.Visible = True
        Me.pointSeries1.Marks.Visible = True
        '
        'pointSeries1.Pointer
        '
        '
        'pointSeries1.Pointer.Brush
        '
        Me.pointSeries1.Pointer.Brush.Color = System.Drawing.Color.Red
        Me.pointSeries1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.pointSeries1.Pointer.Visible = True
        Me.pointSeries1.Title = "pointSeries1"
        '
        'pointSeries1.XValues
        '
        Me.pointSeries1.XValues.DataMember = "X"
        Me.pointSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        '
        'pointSeries1.YValues
        '
        Me.pointSeries1.YValues.DataMember = "Y"
        '
        'nearestPoint1
        '
        '
        'nearestPoint1.Pen
        '
        Me.nearestPoint1.Pen.Color = System.Drawing.Color.FromArgb(CType(255, Byte), CType(0, Byte), CType(0, Byte))
        Me.nearestPoint1.Series = Me.pointSeries1
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(7, 9)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(33, 16)
        Me.label1.TabIndex = 0
        Me.label1.Text = "&Style:"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'comboBox1
        '
        Me.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboBox1.Items.AddRange(New Object() {"None", "Circle", "Rectangle", "Diamond"})
        Me.comboBox1.Location = New System.Drawing.Point(47, 7)
        Me.comboBox1.Name = "comboBox1"
        Me.comboBox1.Size = New System.Drawing.Size(100, 21)
        Me.comboBox1.TabIndex = 1
        '
        'checkBox1
        '
        Me.checkBox1.Checked = True
        Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox1.Location = New System.Drawing.Point(160, 7)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(67, 21)
        Me.checkBox1.TabIndex = 2
        Me.checkBox1.Text = "&Active"
        '
        'checkBox2
        '
        Me.checkBox2.Checked = True
        Me.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox2.Location = New System.Drawing.Point(227, 7)
        Me.checkBox2.Name = "checkBox2"
        Me.checkBox2.Size = New System.Drawing.Size(85, 21)
        Me.checkBox2.TabIndex = 3
        Me.checkBox2.Text = "&Draw Line"
        '
        'button1
        '
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.Location = New System.Drawing.Point(320, 6)
        Me.button1.Name = "button1"
        Me.button1.TabIndex = 4
        Me.button1.Text = "&Edit..."
        '
        'Tools_Nearest
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(466, 286)
        Me.Name = "Tools_Nearest"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub 'InitializeComponent 
#End Region


    Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox1.CheckedChanged
        Me.nearestPoint1.Active = checkBox1.Checked
    End Sub 'checkBox1_CheckedChanged


    Private Sub checkBox2_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox2.CheckedChanged
        Me.nearestPoint1.DrawLine = checkBox2.Checked
    End Sub 'checkBox2_CheckedChanged


    Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
        TeeChart.Editors.Tools.ToolsEditor.ShowEditor(Me.nearestPoint1)
    End Sub 'button1_Click


    Private Sub comboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboBox1.SelectedIndexChanged
        Me.nearestPoint1.Style = CType(comboBox1.SelectedIndex, Steema.TeeChart.Tools.NearestPointStyles)
    End Sub 'comboBox1_SelectedIndexChanged


    Private Sub Tool_Nearest_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.comboBox1.SelectedIndex = 1 ' circle style
    End Sub 'Tool_Nearest_Load
End Class 'Tools_Nearest
