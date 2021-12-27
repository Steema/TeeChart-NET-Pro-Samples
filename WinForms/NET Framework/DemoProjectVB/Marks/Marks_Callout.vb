
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing

Imports System.Windows.Forms




Public Class Marks_Callout
    Inherits Samples.BaseForm
    Private WithEvents comboBox1 As System.Windows.Forms.ComboBox
    Private label2 As System.Windows.Forms.Label
    Private bar1 As Steema.TeeChart.Styles.Bar
    Private WithEvents button1 As System.Windows.Forms.Button
    Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
    Private components As System.ComponentModel.IContainer = Nothing
    
    
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        
        bar1.FillSampleValues()
        bar1.Marks.Callout.Style = Styles.PointerStyles.DownTriangle
        comboBox1.SelectedIndex = 3
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
        Me.comboBox1 = New System.Windows.Forms.ComboBox
        Me.label2 = New System.Windows.Forms.Label
        Me.bar1 = New Steema.TeeChart.Styles.Bar
        Me.button1 = New System.Windows.Forms.Button
        Me.checkBox1 = New System.Windows.Forms.CheckBox
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(466, 64)
        Me.textBox1.TabIndex = 0
        Me.textBox1.Text = "Series Marks new CallOut property, to change the appearance of lines connecting m" + "arks to series points." + vbCr + vbLf + vbCr + vbLf + "New styles: Callout, rectangle, ellipse... and new pro" + "perties: size, brush, distance."
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.checkBox1)
        Me.panel1.Controls.Add(Me.button1)
        Me.panel1.Controls.Add(Me.label2)
        Me.panel1.Controls.Add(Me.comboBox1)
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
        Me.tChart1.Aspect.Chart3DPercent = 25
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
        Me.tChart1.Header.Font.Brush.Color = System.Drawing.Color.Navy
        Me.tChart1.Header.Font.Size = 9
        Me.tChart1.Header.Lines = New String() {"Series Marks Callout"}
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
        ' tChart1.Legend.Symbol
        ' 
        Me.tChart1.Legend.Symbol.DefaultPen = False
        Me.tChart1.Legend.Visible = False
        Me.tChart1.Location = New System.Drawing.Point(0, 104)
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Brush
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(224, System.Byte), CType(223, System.Byte), CType(227, System.Byte))
        ' 
        ' tChart1.Panel.Gradient
        ' 
        Me.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(244, System.Byte), CType(244, System.Byte), CType(255, System.Byte))
        Me.tChart1.Panel.Brush.Gradient.Visible = True
        ' 
        ' tChart1.Panel.Gradient
        ' 
        Me.tChart1.Panel.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.tChart1.Panel.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(244, System.Byte), CType(244, System.Byte), CType(255, System.Byte))
        Me.tChart1.Panel.Gradient.Visible = True
        Me.tChart1.Series.Add(Me.bar1)
        Me.tChart1.Size = New System.Drawing.Size(466, 182)
        Me.tChart1.TabIndex = 2
        ' 
        ' tChart1.Walls
        ' 
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
        ' tChart1.Walls.Left.Pen
        ' 
        Me.tChart1.Walls.Left.Pen.Visible = False
        Me.tChart1.Walls.Left.Size = 5
        ' 
        ' comboBox1
        ' 
        Me.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboBox1.Items.AddRange(New Object() {"Square", "Circle", "Triangle", "Down Triangle", "Cross", "Diagonal Cross", "Star", "Diamond", "Small Dot", "Nothing", "Left Triangle", "Right Triangle"})
        Me.comboBox1.Location = New System.Drawing.Point(64, 8)
        Me.comboBox1.Name = "comboBox1"
        Me.comboBox1.Size = New System.Drawing.Size(121, 21)
        Me.comboBox1.TabIndex = 1
        ' 
        ' label2
        ' 
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(24, 11)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(33, 16)
        Me.label2.TabIndex = 2
        Me.label2.Text = "&Style:"
        ' 
        ' bar1
        ' 
        Me.bar1.BarStyle = Steema.TeeChart.Styles.BarStyles.Cylinder
        ' 
        ' bar1.Brush
        ' 
        Me.bar1.Brush.Color = System.Drawing.Color.FromArgb(CType(178, System.Byte), CType(255, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
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
        ' 
        ' bar1.Pen
        ' 
        Me.bar1.Pen.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(128, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
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
        ' button1
        ' 
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.Location = New System.Drawing.Point(200, 7)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(80, 24)
        Me.button1.TabIndex = 3
        Me.button1.Text = "&Edit..."
        ' 
        ' checkBox1
        ' 
        Me.checkBox1.Location = New System.Drawing.Point(296, 11)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(64, 16)
        Me.checkBox1.TabIndex = 4
        Me.checkBox1.Text = "&Visible"
        ' 
        ' MarksCallout
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(466, 286)
        Me.Name = "MarksCallout"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub 'InitializeComponent 
#End Region


    Private Sub comboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboBox1.SelectedIndexChanged
        bar1.Marks.Callout.Style = CType(comboBox1.SelectedIndex, Styles.PointerStyles)
    End Sub 'comboBox1_SelectedIndexChanged


    Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
        Editors.ChartEditor.ShowModal(tChart1.Chart, Editors.ChartEditorTabs.Series)
    End Sub 'button1_Click


    Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox1.CheckedChanged
        bar1.Marks.Callout.Visible = checkBox1.Checked
    End Sub 'checkBox1_CheckedChanged
End Class 'Marks_Callout 
