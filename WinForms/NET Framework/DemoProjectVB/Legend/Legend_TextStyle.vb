
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing

Imports System.Windows.Forms




Public Class Legend_TextStyle
    Inherits Samples.BaseForm
    Private pieSeries1 As Steema.TeeChart.Styles.Pie
    Private label1 As System.Windows.Forms.Label
    Private WithEvents comboBox1 As System.Windows.Forms.ComboBox
    Private components As System.ComponentModel.IContainer = Nothing
    
    
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        
        Me.pieSeries1.FillSampleValues(5)
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
        Me.pieSeries1 = New Steema.TeeChart.Styles.Pie
        Me.label1 = New System.Windows.Forms.Label
        Me.comboBox1 = New System.Windows.Forms.ComboBox
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'textBox1
        '
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(466, 63)
        Me.textBox1.Text = ("Several different legend text styles are supported via the Legend.TextStyle property." & vbCrLf & vbCrLf & "Example: tChart1.Legend.TextStyle =Steema.TeeChart.LegendTextStyles.Left" + "Value")
        '
        'panel1
        '
        Me.panel1.Controls.Add(Me.comboBox1)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Location = New System.Drawing.Point(0, 63)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(466, 41)
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
        Me.tChart1.Header.Lines = New String() {"tChart1"}
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
        Me.tChart1.Series.Add(Me.pieSeries1)
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
        'pieSeries1
        '
        '
        'pieSeries1.Brush
        '
        Me.pieSeries1.Brush.Color = System.Drawing.Color.Red
        Me.pieSeries1.LabelMember = "Labels"
        '
        'pieSeries1.Marks
        '
        '
        'pieSeries1.Marks.Callout
        '
        Me.pieSeries1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None
        Me.pieSeries1.Marks.Callout.ArrowHeadSize = 8
        '
        'pieSeries1.Marks.Callout.Brush
        '
        Me.pieSeries1.Marks.Callout.Brush.Color = System.Drawing.Color.Black
        Me.pieSeries1.Marks.Callout.Distance = 0
        Me.pieSeries1.Marks.Callout.Draw3D = False
        Me.pieSeries1.Marks.Callout.Length = 8
        Me.pieSeries1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        '
        'pieSeries1.Marks.Shadow
        '
        Me.pieSeries1.Marks.Shadow.Visible = True
        '
        'pieSeries1.Marks.Symbol
        '
        '
        'pieSeries1.Marks.Symbol.Shadow
        '
        Me.pieSeries1.Marks.Symbol.Shadow.Visible = True
        '
        'pieSeries1.Pen
        '
        Me.pieSeries1.Pen.Color = System.Drawing.Color.FromArgb(CType(254, Byte), CType(128, Byte), CType(128, Byte), CType(128, Byte))
        '
        'pieSeries1.Shadow
        '
        Me.pieSeries1.Shadow.Height = 20
        Me.pieSeries1.Shadow.Width = 20
        Me.pieSeries1.Title = "pieSeries1"
        '
        'pieSeries1.XValues
        '
        Me.pieSeries1.XValues.DataMember = "Angle"
        Me.pieSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        '
        'pieSeries1.YValues
        '
        Me.pieSeries1.YValues.DataMember = "Pie"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(26, 11)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(36, 16)
        Me.label1.TabIndex = 0
        Me.label1.Text = "&Style :"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'comboBox1
        '
        Me.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboBox1.Items.AddRange(New Object() {"Plain", "Left Value", "Right Value", "Left Percent", "Right Percent", "X Value", "Value", "Percent", "X and Value", "X and Percent"})
        Me.comboBox1.Location = New System.Drawing.Point(67, 9)
        Me.comboBox1.Name = "comboBox1"
        Me.comboBox1.Size = New System.Drawing.Size(100, 21)
        Me.comboBox1.TabIndex = 1
        '
        'Legend_TextStyle
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(466, 286)
        Me.Name = "Legend_TextStyle"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub 'InitializeComponent 
#End Region


    Private Sub Legend_TextStyle_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' left value style
        Me.comboBox1.SelectedIndex = 1
    End Sub 'Legend_TextStyle_Load


    Private Sub comboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboBox1.SelectedIndexChanged
        Me.tChart1.Legend.TextStyle = CType(Me.comboBox1.SelectedIndex, Steema.TeeChart.LegendTextStyles)
    End Sub 'comboBox1_SelectedIndexChanged
End Class 'Legend_TextStyle
