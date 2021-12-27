
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms



Public Class Candle_CustomColors
    Inherits Samples.BaseForm
    Private candleSeries1 As Steema.TeeChart.Styles.Candle
    Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
    Private label1 As System.Windows.Forms.Label
    Private WithEvents comboBox1 As System.Windows.Forms.ComboBox
    Private gridBand1 As Steema.TeeChart.Tools.GridBand
    Private components As System.ComponentModel.IContainer = Nothing
    
    
    Private Sub SetCustomColors()
        candleSeries1.Colors(11) = Color.Yellow
        candleSeries1.Colors(15) = Color.Lime
        candleSeries1.Colors(16) = Color.Blue
    End Sub 'SetCustomColors
    
    
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        
        candleSeries1.FillSampleValues(30)
        
        SetCustomColors()
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
        Me.candleSeries1 = New Steema.TeeChart.Styles.Candle
        Me.checkBox1 = New System.Windows.Forms.CheckBox
        Me.label1 = New System.Windows.Forms.Label
        Me.comboBox1 = New System.Windows.Forms.ComboBox
        Me.gridBand1 = New Steema.TeeChart.Tools.GridBand
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(466, 40)
        Me.textBox1.Text = "Candle bars can be displayed using custom colors."
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.comboBox1)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Controls.Add(Me.checkBox1)
        Me.panel1.Location = New System.Drawing.Point(0, 40)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(466, 41)
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
        Me.tChart1.Header.Lines = New String() {"tChart1"}
        Me.tChart1.Location = New System.Drawing.Point(0, 81)
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Brush
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.tChart1.Series.Add(Me.candleSeries1)
        Me.tChart1.Size = New System.Drawing.Size(466, 205)
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
        ' candleSeries1
        ' 
        ' 
        ' candleSeries1.Brush
        ' 
        Me.candleSeries1.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(128, System.Byte), CType(128, System.Byte), CType(0, System.Byte))
        Me.candleSeries1.CloseValues = Me.candleSeries1.YValues
        Me.candleSeries1.DateValues = Me.candleSeries1.XValues
        Me.candleSeries1.DownCloseColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(128, System.Byte), CType(128, System.Byte), CType(0, System.Byte))
        ' 
        ' candleSeries1.LinePen
        ' 
        Me.candleSeries1.LinePen.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(77, System.Byte), CType(77, System.Byte), CType(0, System.Byte))
        ' 
        ' candleSeries1.Marks
        ' 
        ' 
        ' candleSeries1.Marks.Symbol
        ' 
        ' 
        ' candleSeries1.Marks.Symbol.Shadow
        ' 
        Me.candleSeries1.Marks.Symbol.Shadow.Height = 1
        Me.candleSeries1.Marks.Symbol.Shadow.Visible = True
        Me.candleSeries1.Marks.Symbol.Shadow.Width = 1
        ' 
        ' candleSeries1.Pointer
        ' 
        ' 
        ' candleSeries1.Pointer.Brush
        ' 
        Me.candleSeries1.Pointer.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(0, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        Me.candleSeries1.Pointer.Draw3D = False
        Me.candleSeries1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.candleSeries1.Title = "candleSeries1"
        ' 
        ' candleSeries1.XValues
        ' 
        Me.candleSeries1.XValues.DataMember = "Date"
        Me.candleSeries1.XValues.DateTime = True
        Me.candleSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' candleSeries1.YValues
        ' 
        Me.candleSeries1.YValues.DataMember = "Close"
        ' 
        ' checkBox1
        ' 
        Me.checkBox1.Checked = True
        Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox1.Location = New System.Drawing.Point(20, 9)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(116, 21)
        Me.checkBox1.TabIndex = 0
        Me.checkBox1.Text = "&Custom Colors"
        ' 
        ' label1
        ' 
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(147, 11)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(33, 16)
        Me.label1.TabIndex = 1
        Me.label1.Text = "&Style:"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        ' 
        ' comboBox1
        ' 
        Me.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboBox1.Items.AddRange(New Object() {"Stick", "Bar", "Open Close", "Line"})
        Me.comboBox1.Location = New System.Drawing.Point(187, 9)
        Me.comboBox1.Name = "comboBox1"
        Me.comboBox1.Size = New System.Drawing.Size(100, 21)
        Me.comboBox1.TabIndex = 2
        ' 
        ' gridBand1
        ' 
        Me.gridBand1.Axis = Me.tChart1.Axes.Left
        ' 
        ' gridBand1.Band1
        ' 
        Me.gridBand1.Band1.Color = System.Drawing.Color.FromArgb(CType(127, System.Byte), CType(192, System.Byte), CType(192, System.Byte), CType(192, System.Byte))
        ' 
        ' gridBand1.Band2
        ' 
        Me.gridBand1.Band2.Color = System.Drawing.Color.FromArgb(CType(127, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        ' 
        ' Candle_CustomColors
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(466, 286)
        Me.Name = "Candle_CustomColors"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub 'InitializeComponent 
#End Region


    Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox1.CheckedChanged
        If Me.checkBox1.Checked Then
            SetCustomColors()
        Else
            Dim i As Integer
            For i = 0 To candleSeries1.Count - 1
                candleSeries1(i).Color = Color.Empty
            Next i
        End If
    End Sub 'checkBox1_CheckedChanged

    Private Sub comboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboBox1.SelectedIndexChanged
        candleSeries1.Style = CType(comboBox1.SelectedIndex, TeeChart.Styles.CandleStyles)
    End Sub 'comboBox1_SelectedIndexChanged


    Private Sub Candle_CustomColors_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        comboBox1.SelectedIndex = 0
    End Sub 'Candle_CustomColors_Load
End Class 'Candle_CustomColors