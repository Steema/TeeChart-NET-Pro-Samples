
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing

Imports System.Windows.Forms




Public Class Series_Bar3D
    Inherits Samples.BaseForm
    Private bar3DSeries1 As Steema.TeeChart.Styles.Bar3D
    Private label1 As System.Windows.Forms.Label
    Private WithEvents comboBox1 As System.Windows.Forms.ComboBox
    Private WithEvents button1 As System.Windows.Forms.Button
    Private colorBand1 As Steema.TeeChart.Tools.ColorBand
    Private gridBand1 As Steema.TeeChart.Tools.GridBand
    Private components As System.ComponentModel.IContainer = Nothing
    
    
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        
        Me.bar3DSeries1.Clear()
        Me.bar3DSeries1.Add(0, 250, 200, "A", Color.Red)
        Me.bar3DSeries1.Add(1, 10, 200, "B", Color.Green)
        Me.bar3DSeries1.Add(2, 90, 100, "C", Color.Yellow)
        Me.bar3DSeries1.Add(3, 30, 50, "D", Color.Blue)
        Me.bar3DSeries1.Add(4, 70, 150, "E", Color.White)
        Me.bar3DSeries1.Add(5, 120, 150, "F", Color.Silver)
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
        Me.bar3DSeries1 = New Steema.TeeChart.Styles.Bar3D
        Me.label1 = New System.Windows.Forms.Label
        Me.comboBox1 = New System.Windows.Forms.ComboBox
        Me.button1 = New System.Windows.Forms.Button
        Me.colorBand1 = New Steema.TeeChart.Tools.ColorBand
        Me.gridBand1 = New Steema.TeeChart.Tools.GridBand
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(466, 48)
        Me.textBox1.Text = "The Bar 3D series is an extension of Bar series, providing an extra ""Y"" coordinat" + "e for each bar point."
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.button1)
        Me.panel1.Controls.Add(Me.comboBox1)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Location = New System.Drawing.Point(0, 48)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(466, 40)
        ' 
        ' tChart1
        ' 
        ' 
        ' tChart1.Aspect
        ' 
        Me.tChart1.Aspect.Chart3DPercent = 25
        Me.tChart1.Aspect.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality
        Me.tChart1.Aspect.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        ' 
        ' tChart1.Header
        ' 
        Me.tChart1.Header.Lines = New String() {"Bar 3D series"}
        Me.tChart1.Location = New System.Drawing.Point(0, 88)
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Brush
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.tChart1.Series.Add(Me.bar3DSeries1)
        Me.tChart1.Size = New System.Drawing.Size(466, 198)
        Me.tChart1.Tools.Add(Me.colorBand1)
        Me.tChart1.Tools.Add(Me.gridBand1)
        ' 
        ' tChart1.Walls
        ' 
        ' 
        ' tChart1.Walls.Back
        ' 
        Me.tChart1.Walls.Back.Visible = False
        ' 
        ' tChart1.Walls.Bottom
        ' 
        ' 
        ' tChart1.Walls.Bottom.Brush
        ' 
        Me.tChart1.Walls.Bottom.Brush.Color = System.Drawing.Color.FromArgb(CType(178, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        ' 
        ' tChart1.Walls.Bottom.Gradient
        ' 
        Me.tChart1.Walls.Bottom.Brush.Gradient.Transparency = 30
        ' 
        ' tChart1.Walls.Bottom.Gradient
        ' 
        Me.tChart1.Walls.Bottom.Gradient.Transparency = 30
        ' 
        ' tChart1.Walls.Bottom.Pen
        ' 
        Me.tChart1.Walls.Bottom.Pen.Visible = False
        Me.tChart1.Walls.Bottom.Size = 3
        ' 
        ' tChart1.Walls.Left
        ' 
        ' 
        ' tChart1.Walls.Left.Brush
        ' 
        Me.tChart1.Walls.Left.Brush.Color = System.Drawing.Color.FromArgb(CType(178, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(224, System.Byte))
        ' 
        ' tChart1.Walls.Left.Gradient
        ' 
        Me.tChart1.Walls.Left.Brush.Gradient.Transparency = 30
        ' 
        ' tChart1.Walls.Left.Gradient
        ' 
        Me.tChart1.Walls.Left.Gradient.Transparency = 30
        ' 
        ' tChart1.Walls.Left.Pen
        ' 
        Me.tChart1.Walls.Left.Pen.Visible = False
        Me.tChart1.Walls.Left.Size = 3
        ' 
        ' bar3DSeries1
        ' 
        ' 
        ' bar3DSeries1.Brush
        ' 
        Me.bar3DSeries1.Brush.Color = System.Drawing.Color.Red
        ' 
        ' bar3DSeries1.Gradient
        ' 
        Me.bar3DSeries1.Brush.Gradient.StartColor = System.Drawing.Color.Yellow
        Me.bar3DSeries1.Brush.Gradient.Visible = True
        ' 
        ' bar3DSeries1.Gradient
        ' 
        Me.bar3DSeries1.Gradient.StartColor = System.Drawing.Color.Yellow
        Me.bar3DSeries1.Gradient.Visible = True
        Me.bar3DSeries1.LabelMember = "Labels"
        ' 
        ' bar3DSeries1.Marks
        ' 
        ' 
        ' bar3DSeries1.Marks.Symbol
        ' 
        ' 
        ' bar3DSeries1.Marks.Symbol.Shadow
        ' 
        Me.bar3DSeries1.Marks.Symbol.Shadow.Height = 1
        Me.bar3DSeries1.Marks.Symbol.Shadow.Visible = True
        Me.bar3DSeries1.Marks.Symbol.Shadow.Width = 1
        ' 
        ' bar3DSeries1.Pen
        ' 
        Me.bar3DSeries1.Pen.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(64, System.Byte), CType(64, System.Byte), CType(0, System.Byte))
        Me.bar3DSeries1.Title = "bar3DSeries1"
        ' 
        ' bar3DSeries1.XValues
        ' 
        Me.bar3DSeries1.XValues.DataMember = "X"
        Me.bar3DSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' bar3DSeries1.YValues
        ' 
        Me.bar3DSeries1.YValues.DataMember = "Bar"
        ' 
        ' label1
        ' 
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(16, 12)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(36, 16)
        Me.label1.TabIndex = 0
        Me.label1.Text = "&Style :"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        ' 
        ' comboBox1
        ' 
        Me.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboBox1.Items.AddRange(New Object() {"Rectangle", "Pyramid", "Invert. Pyramid", "Cylinder", "Ellipse", "Arrow", "Rect. Gradient", "Cone"})
        Me.comboBox1.Location = New System.Drawing.Point(60, 10)
        Me.comboBox1.Name = "comboBox1"
        Me.comboBox1.Size = New System.Drawing.Size(101, 21)
        Me.comboBox1.TabIndex = 1
        ' 
        ' button1
        ' 
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.Location = New System.Drawing.Point(200, 9)
        Me.button1.Name = "button1"
        Me.button1.TabIndex = 2
        Me.button1.Text = "&Edit..."
        ' 
        ' colorBand1
        ' 
        Me.colorBand1.Axis = Me.tChart1.Axes.Left
        ' 
        ' colorBand1.Brush
        ' 
        Me.colorBand1.Brush.Color = System.Drawing.Color.FromArgb(CType(33, System.Byte), CType(224, System.Byte), CType(224, System.Byte), CType(255, System.Byte))
        Me.colorBand1.End = 400
        ' 
        ' colorBand1.Pen
        ' 
        Me.colorBand1.Pen.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(128, System.Byte), CType(128, System.Byte), CType(160, System.Byte))
        Me.colorBand1.ResizeEnd = False
        Me.colorBand1.ResizeStart = False
        Me.colorBand1.Start = 800
        ' 
        ' gridBand1
        ' 
        Me.gridBand1.Axis = Me.tChart1.Axes.Left
        ' 
        ' gridBand1.Band1
        ' 
        Me.gridBand1.Band1.Color = System.Drawing.Color.FromArgb(CType(127, System.Byte), CType(224, System.Byte), CType(224, System.Byte), CType(224, System.Byte))
        ' 
        ' gridBand1.Band2
        ' 
        Me.gridBand1.Band2.Color = System.Drawing.Color.FromArgb(CType(127, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        ' 
        ' SeriesType_Bar3D
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(466, 286)
        Me.Name = "SeriesType_Bar3D"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub 'InitializeComponent 
#End Region


    Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
        TeeChart.Editors.SeriesEditor.ShowEditor(Me.bar3DSeries1)
    End Sub 'button1_Click


    Private Sub comboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboBox1.SelectedIndexChanged
        Me.bar3DSeries1.BarStyle = CType(comboBox1.SelectedIndex, Steema.TeeChart.Styles.BarStyles)
    End Sub 'comboBox1_SelectedIndexChanged


    Private Sub SeriesType_Bar3D_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.comboBox1.SelectedIndex = 6
    End Sub 'SeriesType_Bar3D_Load
End Class 'Series_Bar3D
