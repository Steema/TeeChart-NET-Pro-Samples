
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing

Imports System.Windows.Forms




Public Class SeriesType_Bubble
    Inherits Samples.BaseForm
    Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
    Private WithEvents checkBox2 As System.Windows.Forms.CheckBox
    Private WithEvents comboBox1 As System.Windows.Forms.ComboBox
    Private label1 As System.Windows.Forms.Label
    Private WithEvents button1 As System.Windows.Forms.Button
    Private WithEvents button2 As System.Windows.Forms.Button
    Private WithEvents bubbleSeries1 As Steema.TeeChart.Styles.Bubble
    Private components As System.ComponentModel.IContainer = Nothing
    Private random As New Random()
    
    
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        
        bubbleSeries1.Clear()
        Dim t As Integer
        For t = 0 To 99
            bubbleSeries1.Add(t, random.Next(1000), 1000.0 / (20 + random.Next(25)))
        Next t
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
        Me.comboBox1 = New System.Windows.Forms.ComboBox
        Me.label1 = New System.Windows.Forms.Label
        Me.button1 = New System.Windows.Forms.Button
        Me.button2 = New System.Windows.Forms.Button
        Me.bubbleSeries1 = New Steema.TeeChart.Styles.Bubble
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(466, 63)
        Me.textBox1.Text = "Bubbles are represented with a center position and Radius. Each bubble can show a" + " different style using the OnGetPointerStyle event." + vbCr + vbLf + vbCr + vbLf + "Options include style, pa" + "ttern, border, marks, radius, etc."
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.button2)
        Me.panel1.Controls.Add(Me.button1)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Controls.Add(Me.comboBox1)
        Me.panel1.Controls.Add(Me.checkBox2)
        Me.panel1.Controls.Add(Me.checkBox1)
        Me.panel1.Location = New System.Drawing.Point(0, 63)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(466, 33)
        ' 
        ' tChart1
        ' 
        ' 
        ' tChart1.Aspect
        ' 
        Me.tChart1.Aspect.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality
        Me.tChart1.Aspect.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        Me.tChart1.Aspect.View3D = False
        ' 
        ' tChart1.Header
        ' 
        Me.tChart1.Header.Lines = New String() {"Bubble"}
        Me.tChart1.Header.Visible = False
        ' 
        ' tChart1.Legend
        ' 
        Me.tChart1.Legend.Visible = False
        Me.tChart1.Location = New System.Drawing.Point(0, 96)
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Brush
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        ' 
        ' tChart1.Panel.Gradient
        ' 
        Me.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(234, System.Byte), CType(234, System.Byte), CType(255, System.Byte))
        Me.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.tChart1.Panel.Brush.Gradient.Visible = True
        ' 
        ' tChart1.Panel.Gradient
        ' 
        Me.tChart1.Panel.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(234, System.Byte), CType(234, System.Byte), CType(255, System.Byte))
        Me.tChart1.Panel.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.tChart1.Panel.Gradient.Visible = True
        Me.tChart1.Series.Add(Me.bubbleSeries1)
        Me.tChart1.Size = New System.Drawing.Size(466, 190)
        ' 
        ' tChart1.Zoom
        ' 
        Me.tChart1.Zoom.Animated = True
        ' 
        ' checkBox1
        ' 
        Me.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox1.Location = New System.Drawing.Point(13, 7)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(107, 21)
        Me.checkBox1.TabIndex = 0
        Me.checkBox1.Text = "&View Marks"
        ' 
        ' checkBox2
        ' 
        Me.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox2.Location = New System.Drawing.Point(96, 7)
        Me.checkBox2.Name = "checkBox2"
        Me.checkBox2.Size = New System.Drawing.Size(80, 21)
        Me.checkBox2.TabIndex = 1
        Me.checkBox2.Text = "&Random"
        ' 
        ' comboBox1
        ' 
        Me.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboBox1.Items.AddRange(New Object() {"Rectangle", "Circle", "Triangle", "DownTriangle", "Cross", "DiagCross", "Star", "Diamond"})
        Me.comboBox1.Location = New System.Drawing.Point(207, 7)
        Me.comboBox1.Name = "comboBox1"
        Me.comboBox1.Size = New System.Drawing.Size(86, 21)
        Me.comboBox1.TabIndex = 2
        ' 
        ' label1
        ' 
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(167, 9)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(36, 16)
        Me.label1.TabIndex = 3
        Me.label1.Text = "&Style :"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        ' 
        ' button1
        ' 
        Me.button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, System.Byte))
        Me.button1.Location = New System.Drawing.Point(307, 6) 
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(23, 23)
        Me.button1.TabIndex = 4
        Me.button1.Text = "+"
        ' 
        ' button2
        ' 
        Me.button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, System.Byte))
        Me.button2.Location = New System.Drawing.Point(336, 6) 
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(23, 23)
        Me.button2.TabIndex = 5
        Me.button2.Text = "-"
        ' 
        ' bubbleSeries1
        ' 
        Me.bubbleSeries1.LabelMember = "Labels"
        ' 
        ' bubbleSeries1.Marks
        ' 
        ' 
        ' bubbleSeries1.Marks.Symbol
        ' 
        ' 
        ' bubbleSeries1.Marks.Symbol.Shadow
        ' 
        Me.bubbleSeries1.Marks.Symbol.Shadow.Height = 1
        Me.bubbleSeries1.Marks.Symbol.Shadow.Visible = True
        Me.bubbleSeries1.Marks.Symbol.Shadow.Width = 1
        Me.bubbleSeries1.Marks.Transparent = True
        ' 
        ' bubbleSeries1.Pointer
        ' 
        ' 
        ' bubbleSeries1.Pointer.Brush
        ' 
        Me.bubbleSeries1.Pointer.Brush.Color = System.Drawing.Color.Red
        Me.bubbleSeries1.Pointer.Brush.ForegroundColor = System.Drawing.Color.Empty
        Me.bubbleSeries1.Pointer.HorizSize = 19
        Me.bubbleSeries1.Pointer.InflateMargins = False
        Me.bubbleSeries1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Sphere
        Me.bubbleSeries1.Pointer.VertSize = 19
        Me.bubbleSeries1.Title = "bubble1"
        ' 
        ' bubbleSeries1.XValues
        ' 
        Me.bubbleSeries1.XValues.DataMember = "X"
        Me.bubbleSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' bubbleSeries1.YValues
        ' 
        Me.bubbleSeries1.YValues.DataMember = "Y"
        ' 
        ' SeriesType_Bubble
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(466, 286)
        Me.Name = "SeriesType_Bubble"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub 'InitializeComponent 
#End Region


    Private Sub SeriesType_Bubble_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.comboBox1.SelectedIndex = Fix(Steema.TeeChart.Styles.PointerStyles.Circle)
    End Sub 'SeriesType_Bubble_Load


    Private Sub comboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboBox1.SelectedIndexChanged
        bubbleSeries1.Pointer.Style = CType(Me.comboBox1.SelectedIndex, Steema.TeeChart.Styles.PointerStyles)
    End Sub 'comboBox1_SelectedIndexChanged


    Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox1.CheckedChanged
        bubbleSeries1.Marks.Visible = checkBox1.Checked
    End Sub 'checkBox1_CheckedChanged


    Private Sub checkBox2_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox2.CheckedChanged
        bubbleSeries1.Repaint()
        comboBox1.Enabled = Not checkBox2.Checked
    End Sub 'checkBox2_CheckedChanged


    Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
        tChart1.Zoom.ZoomPercent(110)
    End Sub 'button1_Click


    Private Sub button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button2.Click
        tChart1.Zoom.ZoomPercent(90)
    End Sub 'button2_Click


    Private Sub bubbleSeries1_GetPointerStyle(ByVal series As Steema.TeeChart.Styles.CustomPoint, ByVal e As Steema.TeeChart.Styles.GetPointerStyleEventArgs) Handles bubbleSeries1.GetPointerStyle
        If checkBox2.Checked Then
            Select Case random.Next(8)
                Case 1
                    e.Style = Styles.PointerStyles.Circle
                    Exit Select
                Case 2
                    e.Style = Styles.PointerStyles.Diamond
                    Exit Select
                Case 3
                    e.Style = Styles.PointerStyles.Triangle
                    Exit Select
                Case 4
                    e.Style = Styles.PointerStyles.Cross
                    Exit Select
                Case 5
                    e.Style = Styles.PointerStyles.DiagCross
                    Exit Select
                Case 6
                    e.Style = Styles.PointerStyles.DownTriangle
                    Exit Select
                Case 7
                    e.Style = Styles.PointerStyles.Star
                    Exit Select
                Case Else
                    e.Style = Styles.PointerStyles.Rectangle
                    Exit Select
            End Select
        End If
    End Sub 'bubbleSeries1_GetPointerStyle
End Class 'SeriesType_Bubble
