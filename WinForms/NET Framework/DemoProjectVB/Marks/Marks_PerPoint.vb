
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing

Imports System.Windows.Forms




Public Class Marks_PerPoint
    Inherits Samples.BaseForm
    Private label2 As System.Windows.Forms.Label
    Private WithEvents button1 As System.Windows.Forms.Button
    Private WithEvents numericUpDown1 As System.Windows.Forms.NumericUpDown
    Private WithEvents button2 As System.Windows.Forms.Button
    Private label1 As System.Windows.Forms.Label
    Private pie1 As Steema.TeeChart.Styles.Pie
    Private components As System.ComponentModel.IContainer = Nothing
    
    
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        
        pie1.FillSampleValues()
        
        ' customize mark...
        pie1.Marks.Items(3).Font.Size = 14
        pie1.Marks.Items(3).Color = Color.Silver
        
        ' customize another mark...
        pie1.Marks.Items(5).Font.Size = 12
        pie1.Marks.Items(5).Font.Color = Color.White
        pie1.Marks.Items(5).Color = Color.Navy
        pie1.Marks.Items(5).ShapeStyle = Drawing.TextShapeStyle.RoundRectangle
        pie1.Marks.Items(5).Shadow.Width = 4
        pie1.Marks.Items(5).Shadow.Height = 4
        pie1.Marks.Items(5).Shadow.Transparency = 60
        pie1.Marks.Items(5).Shadow.Color = Color.DarkGray
        
        numericUpDown1.Maximum = pie1.Count - 1
        
        label1.Text = pie1.Labels(Convert.ToInt16(numericUpDown1.Value))
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
        Me.label2 = New System.Windows.Forms.Label
        Me.button1 = New System.Windows.Forms.Button
        Me.numericUpDown1 = New System.Windows.Forms.NumericUpDown
        Me.button2 = New System.Windows.Forms.Button
        Me.label1 = New System.Windows.Forms.Label
        Me.pie1 = New Steema.TeeChart.Styles.Pie
        Me.panel1.SuspendLayout()
        CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(466, 64)
        Me.textBox1.TabIndex = 0
        Me.textBox1.Text = "Series Marks can be individually customized using the default property:" + vbCr + vbLf + vbCr + vbLf + "pie1.M" + "arks.Items[3].Font.Size = 14     ' custom font for mark item 3"
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Controls.Add(Me.button2)
        Me.panel1.Controls.Add(Me.numericUpDown1)
        Me.panel1.Controls.Add(Me.button1)
        Me.panel1.Controls.Add(Me.label2)
        Me.panel1.Location = New System.Drawing.Point(0, 64)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(466, 40)
        Me.panel1.TabIndex = 1
        ' 
        ' tChart1
        ' 
        ' 
        ' tChart1.Aspect
        ' 
        Me.tChart1.Aspect.Chart3DPercent = 20
        Me.tChart1.Aspect.Elevation = 310
        Me.tChart1.Aspect.Orthogonal = False
        Me.tChart1.Aspect.Perspective = 0
        Me.tChart1.Aspect.Rotation = 360
        Me.tChart1.Aspect.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality
        Me.tChart1.Aspect.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        ' 
        ' tChart1.Axes
        ' 
        ' 
        ' tChart1.Axes.Bottom
        ' 
        ' 
        ' tChart1.Axes.Bottom.Grid
        ' 
        Me.tChart1.Axes.Bottom.Grid.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(192, System.Byte), CType(192, System.Byte), CType(192, System.Byte))
        Me.tChart1.Axes.Bottom.Grid.Style = System.Drawing.Drawing2D.DashStyle.Dash
        ' 
        ' tChart1.Axes.Left
        ' 
        ' 
        ' tChart1.Axes.Left.Grid
        ' 
        Me.tChart1.Axes.Left.Grid.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(192, System.Byte), CType(192, System.Byte), CType(192, System.Byte))
        Me.tChart1.Axes.Left.Grid.Style = System.Drawing.Drawing2D.DashStyle.Dash
        Me.tChart1.BackColor = System.Drawing.Color.Transparent
        Me.tChart1.Cursor = System.Windows.Forms.Cursors.Default
        ' 
        ' tChart1.Header
        ' 
        Me.tChart1.Header.AdjustFrame = False
        ' 
        ' tChart1.Header.Brush
        ' 
        Me.tChart1.Header.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        ' 
        ' tChart1.Header.Font
        ' 
        Me.tChart1.Header.Font.Bold = True
        ' 
        ' tChart1.Header.Font.Brush
        ' 
        Me.tChart1.Header.Font.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(192, System.Byte), CType(192, System.Byte), CType(192, System.Byte))
        Me.tChart1.Header.Font.Brush.ForegroundColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(64, System.Byte), CType(64, System.Byte), CType(64, System.Byte))
        Me.tChart1.Header.Font.Brush.Solid = False
        Me.tChart1.Header.Font.Brush.Style = System.Drawing.Drawing2D.HatchStyle.Percent50
        Me.tChart1.Header.Font.Name = "Microsoft Sans Serif"
        Me.tChart1.Header.Font.Size = 14
        Me.tChart1.Header.Lines = New String() {"Marks per position"}
        ' 
        ' tChart1.Header.Shadow
        ' 
        ' 
        ' tChart1.Header.Shadow.Brush
        ' 
        Me.tChart1.Header.Shadow.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(0, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        Me.tChart1.Header.Shadow.Height = 1
        Me.tChart1.Header.Shadow.Width = 1
        ' 
        ' tChart1.Legend
        ' 
        ' 
        ' tChart1.Legend.Pen
        ' 
        Me.tChart1.Legend.Pen.Visible = False
        ' 
        ' tChart1.Legend.Shadow
        ' 
        ' 
        ' tChart1.Legend.Shadow.Brush
        ' 
        Me.tChart1.Legend.Shadow.Brush.Color = System.Drawing.Color.FromArgb(CType(155, System.Byte), CType(128, System.Byte), CType(128, System.Byte), CType(128, System.Byte))
        Me.tChart1.Legend.Shadow.Height = 4
        Me.tChart1.Legend.Shadow.Width = 4
        ' 
        ' tChart1.Legend.Symbol
        ' 
        Me.tChart1.Legend.Symbol.DefaultPen = False
        Me.tChart1.Location = New System.Drawing.Point(0, 104)
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Brush
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(224, System.Byte), CType(224, System.Byte), CType(224, System.Byte))
        ' 
        ' tChart1.Panel.Gradient
        ' 
        Me.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.tChart1.Panel.Brush.Gradient.Sigma = True
        Me.tChart1.Panel.Brush.Gradient.SigmaFocus = 0.447F
        Me.tChart1.Panel.Brush.Gradient.SigmaScale = 0.694F
        Me.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(223, System.Byte), CType(223, System.Byte), CType(255, System.Byte))
        Me.tChart1.Panel.Brush.Gradient.Visible = True
        ' 
        ' tChart1.Panel.Gradient
        ' 
        Me.tChart1.Panel.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.tChart1.Panel.Gradient.Sigma = True
        Me.tChart1.Panel.Gradient.SigmaFocus = 0.447F
        Me.tChart1.Panel.Gradient.SigmaScale = 0.694F
        Me.tChart1.Panel.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(223, System.Byte), CType(223, System.Byte), CType(255, System.Byte))
        Me.tChart1.Panel.Gradient.Visible = True
        Me.tChart1.Series.Add(Me.pie1)
        Me.tChart1.Size = New System.Drawing.Size(466, 182)
        Me.tChart1.TabIndex = 2
        ' 
        ' label2
        ' 
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(24, 13)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(32, 16)
        Me.label2.TabIndex = 2
        Me.label2.Text = "&Mark:"
        ' 
        ' button1
        ' 
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.Location = New System.Drawing.Point(108, 8)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(80, 24)
        Me.button1.TabIndex = 1
        Me.button1.Text = "&Edit..."
        ' 
        ' numericUpDown1
        ' 
        Me.numericUpDown1.Location = New System.Drawing.Point(56, 10)
        Me.numericUpDown1.Name = "numericUpDown1"
        Me.numericUpDown1.Size = New System.Drawing.Size(40, 20)
        Me.numericUpDown1.TabIndex = 0
        ' 
        ' button2
        ' 
        Me.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button2.Location = New System.Drawing.Point(208, 8)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(80, 24)
        Me.button2.TabIndex = 2
        Me.button2.Text = "&Reset"
        ' 
        ' label1
        ' 
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(304, 12)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(35, 16)
        Me.label1.TabIndex = 7
        Me.label1.Text = "label1"
        ' 
        ' pie1
        ' 
        ' 
        ' pie1.Brush
        ' 
        Me.pie1.Brush.Color = System.Drawing.Color.Red
        Me.pie1.LabelMember = "Labels"
        ' 
        ' pie1.Marks
        ' 
        Me.pie1.Marks.ArrowLength = 10
        ' 
        ' pie1.Marks.Symbol
        ' 
        ' 
        ' pie1.Marks.Symbol.Shadow
        ' 
        Me.pie1.Marks.Symbol.Shadow.Height = 1
        Me.pie1.Marks.Symbol.Shadow.Visible = True
        Me.pie1.Marks.Symbol.Shadow.Width = 1
        ' 
        ' pie1.Pen
        ' 
        Me.pie1.Pen.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(128, System.Byte), CType(128, System.Byte), CType(128, System.Byte))
        ' 
        ' pie1.Shadow
        ' 
        Me.pie1.Shadow.Height = 20
        Me.pie1.Shadow.Width = 20
        Me.pie1.Title = "pie1"
        ' 
        ' pie1.XValues
        ' 
        Me.pie1.XValues.DataMember = "Angle"
        Me.pie1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' pie1.YValues
        ' 
        Me.pie1.YValues.DataMember = "Pie"
        ' 
        ' MarksPerPoint
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(466, 286)
        Me.Name = "MarksPerPoint"
        Me.panel1.ResumeLayout(False)
        CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub 'InitializeComponent 
#End Region



    Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
        Dim a As New Editors.CustomShapeEditor(pie1.Marks.Items(Convert.ToInt16(numericUpDown1.Value)))
        Editors.EditorUtils.ShowFormModal(a, Me)
    End Sub 'button1_Click


    Private Sub numericUpDown1_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles numericUpDown1.ValueChanged
        label1.Text = pie1.Labels(Convert.ToInt16(numericUpDown1.Value))
    End Sub 'numericUpDown1_ValueChanged


    Private Sub button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button2.Click
        ' Remove custom marks (set all to default)
        pie1.Marks.Clear()
    End Sub 'button2_Click
End Class 'Marks_PerPoint 
