
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing

Imports System.Windows.Forms




Public Class WindRose_Series
    Inherits Samples.BaseForm
    Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
    Private WithEvents checkBox2 As System.Windows.Forms.CheckBox
    Private label1 As System.Windows.Forms.Label
    Private WithEvents comboBox1 As System.Windows.Forms.ComboBox
    Private WithEvents button1 As System.Windows.Forms.Button
    Private windRose1 As Steema.TeeChart.Styles.WindRose
    Private windRose2 As Steema.TeeChart.Styles.WindRose
    Private components As System.ComponentModel.IContainer = Nothing
    
    
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        windRose1.Clear()
        windRose1.Add(30, 100)
        windRose1.Add(60, 200)
        windRose1.Add(90, 50)
        windRose1.Add(120, 150)
        
        windRose2.Clear()
        windRose2.Add(130, 100)
        windRose2.Add(160, 200)
        windRose2.Add(190, 50)
        windRose2.Add(220, 150)
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
        Me.checkBox2 = New System.Windows.Forms.CheckBox
        Me.label1 = New System.Windows.Forms.Label
        Me.comboBox1 = New System.Windows.Forms.ComboBox
        Me.button1 = New System.Windows.Forms.Button
        Me.windRose1 = New Steema.TeeChart.Styles.WindRose
        Me.windRose2 = New Steema.TeeChart.Styles.WindRose
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tChart1
        '
        '
        'tChart1.Aspect
        '
        Me.tChart1.Aspect.Elevation = 315
        Me.tChart1.Aspect.ElevationFloat = 315
        Me.tChart1.Aspect.Orthogonal = False
        Me.tChart1.Aspect.Perspective = 0
        Me.tChart1.Aspect.Rotation = 360
        Me.tChart1.Aspect.RotationFloat = 360
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
        Me.tChart1.Axes.Left.LogarithmicBase = 2
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
        Me.tChart1.BackColor = System.Drawing.Color.Gray
        '
        'tChart1.Header
        '
        '
        'tChart1.Header.Brush
        '
        Me.tChart1.Header.Brush.Color = System.Drawing.Color.FromArgb(CType(254, Byte), CType(255, Byte), CType(0, Byte), CType(0, Byte))
        '
        'tChart1.Header.Font
        '
        Me.tChart1.Header.Font.Bold = True
        '
        'tChart1.Header.Font.Brush
        '
        Me.tChart1.Header.Font.Brush.Color = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(255, Byte))
        Me.tChart1.Header.Font.Size = 7
        Me.tChart1.Header.Font.SizeFloat = 7.0!
        Me.tChart1.Header.Lines = New String() {"Wind rose series"}
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
        Me.tChart1.Legend.Visible = False
        Me.tChart1.Location = New System.Drawing.Point(0, 104)
        Me.tChart1.Name = "tChart1"
        '
        'tChart1.Panel
        '
        '
        'tChart1.Panel.Bevel
        '
        Me.tChart1.Panel.Bevel.ColorOne = System.Drawing.Color.FromArgb(CType(128, Byte), CType(128, Byte), CType(128, Byte))
        '
        'tChart1.Panel.Brush
        '
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.Gray
        '
        'tChart1.Panel.Gradient
        '
        Me.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(254, Byte), CType(255, Byte), CType(255, Byte), CType(128, Byte))
        Me.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(254, Byte), CType(128, Byte), CType(128, Byte), CType(128, Byte))
        Me.tChart1.Panel.Brush.Gradient.UseMiddle = True
        Me.tChart1.Panel.Brush.Gradient.Visible = True
        '
        'tChart1.Panel.Gradient
        '
        Me.tChart1.Panel.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(254, Byte), CType(255, Byte), CType(255, Byte), CType(128, Byte))
        Me.tChart1.Panel.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(254, Byte), CType(128, Byte), CType(128, Byte), CType(128, Byte))
        Me.tChart1.Panel.Gradient.UseMiddle = True
        Me.tChart1.Panel.Gradient.Visible = True
        Me.tChart1.Series.Add(Me.windRose1)
        Me.tChart1.Series.Add(Me.windRose2)
        Me.tChart1.Size = New System.Drawing.Size(466, 182)
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
        'textBox1
        '
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(466, 63)
        Me.textBox1.Text = ("Wind-Rose series is a polar chart showing geographical coordinates around the cir" + ("cle. ( N = North, S = South, W = West, E = East )." & vbCrLf & vbCrLf & "Displays more than one ser" + "ies at the same time, each one with specific properties."))
        '
        'panel1
        '
        Me.panel1.Controls.Add(Me.button1)
        Me.panel1.Controls.Add(Me.comboBox1)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Controls.Add(Me.checkBox1)
        Me.panel1.Controls.Add(Me.checkBox2)
        Me.panel1.Location = New System.Drawing.Point(0, 63)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(466, 41)
        '
        'checkBox1
        '
        Me.checkBox1.Checked = True
        Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox1.Location = New System.Drawing.Point(13, 7)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(47, 21)
        Me.checkBox1.TabIndex = 0
        Me.checkBox1.Text = "&Axes"
        '
        'checkBox2
        '
        Me.checkBox2.Checked = True
        Me.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox2.Location = New System.Drawing.Point(73, 7)
        Me.checkBox2.Name = "checkBox2"
        Me.checkBox2.Size = New System.Drawing.Size(67, 21)
        Me.checkBox2.TabIndex = 1
        Me.checkBox2.Text = "&Circled"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(160, 11)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(44, 16)
        Me.label1.TabIndex = 2
        Me.label1.Text = "&Labels :"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'comboBox1
        '
        Me.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboBox1.Items.AddRange(New Object() {"15", "30", "45", "90"})
        Me.comboBox1.Location = New System.Drawing.Point(207, 7)
        Me.comboBox1.Name = "comboBox1"
        Me.comboBox1.Size = New System.Drawing.Size(100, 21)
        Me.comboBox1.TabIndex = 3
        '
        'button1
        '
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.Location = New System.Drawing.Point(333, 6)
        Me.button1.Name = "button1"
        Me.button1.TabIndex = 4
        Me.button1.Text = "&Edit..."
        '
        'windRose1
        '
        '
        'windRose1.Brush
        '
        Me.windRose1.Brush.Color = System.Drawing.Color.Red
        Me.windRose1.Circled = True
        Me.windRose1.CircleLabels = True
        '
        'windRose1.Marks
        '
        '
        'windRose1.Marks.Callout
        '
        Me.windRose1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None
        Me.windRose1.Marks.Callout.ArrowHeadSize = 8
        '
        'windRose1.Marks.Callout.Brush
        '
        Me.windRose1.Marks.Callout.Brush.Color = System.Drawing.Color.Black
        Me.windRose1.Marks.Callout.Distance = 0
        Me.windRose1.Marks.Callout.Draw3D = False
        Me.windRose1.Marks.Callout.Length = 10
        Me.windRose1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        '
        'windRose1.Marks.Shadow
        '
        Me.windRose1.Marks.Shadow.Visible = True
        '
        'windRose1.Marks.Symbol
        '
        '
        'windRose1.Marks.Symbol.Shadow
        '
        Me.windRose1.Marks.Symbol.Shadow.Visible = True
        '
        'windRose1.Pen
        '
        Me.windRose1.Pen.Color = System.Drawing.Color.Red
        '
        'windRose1.Pointer
        '
        '
        'windRose1.Pointer.Brush
        '
        Me.windRose1.Pointer.Brush.Color = System.Drawing.Color.FromArgb(CType(254, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
        Me.windRose1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.windRose1.Pointer.Visible = True
        Me.windRose1.RotationAngle = 90
        Me.windRose1.Title = "windRose1"
        '
        'windRose1.XValues
        '
        Me.windRose1.XValues.DataMember = "Angle"
        Me.windRose1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        '
        'windRose1.YValues
        '
        Me.windRose1.YValues.DataMember = "Y"
        '
        'windRose2
        '
        '
        'windRose2.Brush
        '
        Me.windRose2.Brush.Color = System.Drawing.Color.Green
        Me.windRose2.Circled = True
        Me.windRose2.CircleLabels = True
        '
        'windRose2.Marks
        '
        '
        'windRose2.Marks.Callout
        '
        Me.windRose2.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None
        Me.windRose2.Marks.Callout.ArrowHeadSize = 8
        '
        'windRose2.Marks.Callout.Brush
        '
        Me.windRose2.Marks.Callout.Brush.Color = System.Drawing.Color.Black
        Me.windRose2.Marks.Callout.Distance = 0
        Me.windRose2.Marks.Callout.Draw3D = False
        Me.windRose2.Marks.Callout.Length = 10
        Me.windRose2.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        '
        'windRose2.Marks.Shadow
        '
        Me.windRose2.Marks.Shadow.Visible = True
        '
        'windRose2.Marks.Symbol
        '
        '
        'windRose2.Marks.Symbol.Shadow
        '
        Me.windRose2.Marks.Symbol.Shadow.Visible = True
        '
        'windRose2.Pen
        '
        Me.windRose2.Pen.Color = System.Drawing.Color.Green
        '
        'windRose2.Pointer
        '
        '
        'windRose2.Pointer.Brush
        '
        Me.windRose2.Pointer.Brush.Color = System.Drawing.Color.FromArgb(CType(254, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
        Me.windRose2.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.windRose2.Pointer.Visible = True
        Me.windRose2.RotationAngle = 90
        Me.windRose2.Title = "windRose2"
        '
        'windRose2.XValues
        '
        Me.windRose2.XValues.DataMember = "Angle"
        Me.windRose2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        '
        'windRose2.YValues
        '
        Me.windRose2.YValues.DataMember = "Y"
        '
        'WindRose_Series
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(466, 286)
        Me.Name = "WindRose_Series"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub 'InitializeComponent 
#End Region


    Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox1.CheckedChanged
        Me.tChart1.Axes.Visible = checkBox1.Checked
    End Sub 'checkBox1_CheckedChanged


    Private Sub checkBox2_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox2.CheckedChanged
        windRose1.Circled = checkBox2.Checked
        windRose2.Circled = checkBox2.Checked
    End Sub 'checkBox2_CheckedChanged


    Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
        TeeChart.Editors.SeriesEditor.ShowEditor(windRose1)
    End Sub 'button1_Click


    Private Sub comboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboBox1.SelectedIndexChanged
        Select Case comboBox1.SelectedIndex
            Case 0
                windRose1.AngleIncrement = 15
            Case 1
                windRose1.AngleIncrement = 30
            Case 2
                windRose1.AngleIncrement = 45
            Case 3
                windRose1.AngleIncrement = 90
        End Select
    End Sub 'comboBox1_SelectedIndexChanged


    Private Sub SeriesType_WindRose_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.comboBox1.SelectedIndex = 1
    End Sub 'SeriesType_WindRose_Load
End Class 'WindRose_Series 
