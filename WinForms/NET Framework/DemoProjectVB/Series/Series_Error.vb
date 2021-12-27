
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing

Imports System.Windows.Forms




Public Class Series_Error
    Inherits Samples.BaseForm
    Private WithEvents button1 As System.Windows.Forms.Button
    Private label1 As System.Windows.Forms.Label
    Private WithEvents comboBox1 As System.Windows.Forms.ComboBox
    Private WithEvents hScrollBar1 As System.Windows.Forms.HScrollBar
    Private label2 As System.Windows.Forms.Label
    Private errorSeries1 As Steema.TeeChart.Styles.Error
    Private gridBand1 As Steema.TeeChart.Tools.GridBand
    Private components As System.ComponentModel.IContainer = Nothing
    
    
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        
        Me.errorSeries1.Clear()
        Me.errorSeries1.Add(0, 50, 10, "A", Color.Red)
        Me.errorSeries1.Add(1, 80, 20, "B", Color.Yellow)
        Me.errorSeries1.Add(2, 20, 8, "C", Color.Green)
        Me.errorSeries1.Add(3, 60, 30, "D", Color.Blue)
        Me.errorSeries1.Add(4, 40, 5, "E", Color.White)
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
        Me.button1 = New System.Windows.Forms.Button
        Me.label1 = New System.Windows.Forms.Label
        Me.comboBox1 = New System.Windows.Forms.ComboBox
        Me.hScrollBar1 = New System.Windows.Forms.HScrollBar
        Me.label2 = New System.Windows.Forms.Label
        Me.errorSeries1 = New Steema.TeeChart.Styles.Error
        Me.gridBand1 = New Steema.TeeChart.Tools.GridBand
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(466, 63)
        Me.textBox1.TabIndex = 0
        Me.textBox1.Text = """Error"" series uses X,Y and Error coordinate values to display points. Style, pos" + "ition of error bars and size are configurable."
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.label2)
        Me.panel1.Controls.Add(Me.hScrollBar1)
        Me.panel1.Controls.Add(Me.comboBox1)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Controls.Add(Me.button1)
        Me.panel1.Location = New System.Drawing.Point(0, 63)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(466, 41)
        Me.panel1.TabIndex = 1
        ' 
        ' tChart1
        ' 
        ' 
        ' tChart1.Aspect
        ' 
        Me.tChart1.Aspect.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality
        Me.tChart1.Aspect.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        ' 
        ' tChart1.Header
        ' 
        Me.tChart1.Header.Alignment = System.Drawing.StringAlignment.Near
        ' 
        ' tChart1.Header.Font
        ' 
        Me.tChart1.Header.Font.Bold = True
        Me.tChart1.Header.Font.Size = 7
        Me.tChart1.Header.Lines = New String() {"Error Series"}
        Me.tChart1.Location = New System.Drawing.Point(0, 104)
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Brush
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.tChart1.Series.Add(Me.errorSeries1)
        Me.tChart1.Size = New System.Drawing.Size(466, 182)
        Me.tChart1.TabIndex = 2
        Me.tChart1.Tools.Add(Me.gridBand1)
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
        Me.tChart1.Walls.Bottom.Size = 3
        ' 
        ' tChart1.Walls.Left
        ' 
        ' 
        ' tChart1.Walls.Left.Pen
        ' 
        Me.tChart1.Walls.Left.Pen.Visible = False
        Me.tChart1.Walls.Left.Size = 3
        ' 
        ' button1
        ' 
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.Location = New System.Drawing.Point(13, 7)
        Me.button1.Name = "button1"
        Me.button1.TabIndex = 0
        Me.button1.Text = "&Edit..."
        ' 
        ' label1
        ' 
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(97, 10)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(36, 16)
        Me.label1.TabIndex = 1
        Me.label1.Text = "&Style :"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        ' 
        ' comboBox1
        ' 
        Me.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboBox1.Items.AddRange(New Object() {"Left", "Top", "Right", "Bottom", "Left and Right", "Top and Bottom"})
        Me.comboBox1.Location = New System.Drawing.Point(138, 8)
        Me.comboBox1.Name = "comboBox1"
        Me.comboBox1.Size = New System.Drawing.Size(101, 21)
        Me.comboBox1.TabIndex = 2
        ' 
        ' hScrollBar1
        ' 
        Me.hScrollBar1.Location = New System.Drawing.Point(300, 10)
        Me.hScrollBar1.Maximum = 200
        Me.hScrollBar1.Name = "hScrollBar1"
        Me.hScrollBar1.Size = New System.Drawing.Size(93, 17)
        Me.hScrollBar1.TabIndex = 4
        Me.hScrollBar1.Value = 100
        ' 
        ' label2
        ' 
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(253, 10)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(32, 16)
        Me.label2.TabIndex = 3
        Me.label2.Text = "S&ize :"
        Me.label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        ' 
        ' errorSeries1
        ' 
        ' 
        ' errorSeries1.Brush
        ' 
        Me.errorSeries1.Brush.Color = System.Drawing.Color.SaddleBrown
        Me.errorSeries1.ColorEach = True
        ' 
        ' errorSeries1.ErrorPen
        ' 
        Me.errorSeries1.ErrorPen.Color = System.Drawing.Color.SaddleBrown
        ' 
        ' errorSeries1.ErrorValues
        ' 
        Me.errorSeries1.ErrorValues.DataMember = "StdError"
        Me.errorSeries1.LabelMember = "Labels"
        ' 
        ' errorSeries1.Marks
        ' 
        ' 
        ' errorSeries1.Marks.Symbol
        ' 
        ' 
        ' errorSeries1.Marks.Symbol.Shadow
        ' 
        Me.errorSeries1.Marks.Symbol.Shadow.Height = 1
        Me.errorSeries1.Marks.Symbol.Shadow.Visible = True
        Me.errorSeries1.Marks.Symbol.Shadow.Width = 1
        Me.errorSeries1.Marks.Visible = False
        Me.errorSeries1.MultiBar = Steema.TeeChart.Styles.MultiBars.None
        Me.errorSeries1.Title = "error1"
        ' 
        ' errorSeries1.XValues
        ' 
        Me.errorSeries1.XValues.DataMember = "X"
        Me.errorSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' errorSeries1.YValues
        ' 
        Me.errorSeries1.YValues.DataMember = "Bar"
        ' 
        ' gridBand1
        ' 
        Me.gridBand1.Axis = Me.tChart1.Axes.Left
        ' 
        ' gridBand1.Band1
        ' 
        Me.gridBand1.Band1.Color = System.Drawing.Color.FromArgb(CType(76, System.Byte), CType(224, System.Byte), CType(224, System.Byte), CType(224, System.Byte))
        ' 
        ' gridBand1.Band2
        ' 
        Me.gridBand1.Band2.Color = System.Drawing.Color.FromArgb(CType(127, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        ' 
        ' SeriesType_Error
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(466, 286)
        Me.Name = "SeriesType_Error"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub 'InitializeComponent 
#End Region


    Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
        TeeChart.Editors.SeriesEditor.ShowEditor(Me.errorSeries1)
    End Sub 'button1_Click


    Private Sub comboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboBox1.SelectedIndexChanged
        Select Case comboBox1.SelectedIndex
            Case 0
                Me.errorSeries1.ErrorStyle = Steema.TeeChart.Styles.ErrorStyles.Left
            Case 1
                Me.errorSeries1.ErrorStyle = Steema.TeeChart.Styles.ErrorStyles.Top
            Case 2
                Me.errorSeries1.ErrorStyle = Steema.TeeChart.Styles.ErrorStyles.Right
            Case 3
                Me.errorSeries1.ErrorStyle = Steema.TeeChart.Styles.ErrorStyles.Bottom
            Case 4
                Me.errorSeries1.ErrorStyle = Steema.TeeChart.Styles.ErrorStyles.LeftRight
            Case 5
                Me.errorSeries1.ErrorStyle = Steema.TeeChart.Styles.ErrorStyles.TopBottom
        End Select
    End Sub 'comboBox1_SelectedIndexChanged


    Private Sub hScrollBar1_Scroll(ByVal sender As Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles hScrollBar1.Scroll
        Me.errorSeries1.ErrorWidth = hScrollBar1.Value
    End Sub 'hScrollBar1_Scroll


    Private Sub SeriesType_Error_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.comboBox1.SelectedIndex = 5
    End Sub 'SeriesType_Error_Load
End Class 'Series_Error
