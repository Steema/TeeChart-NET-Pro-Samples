
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports Steema.TeeChart.Functions


Public Class Function_Trend
    Inherits Steema.TeeChart.Samples.BaseForm
    Private area1 As Steema.TeeChart.Styles.Area
    Private trendFunction1 As Steema.TeeChart.Functions.TrendFunction
    Private line1 As Steema.TeeChart.Styles.Line
    Private button1 As System.Windows.Forms.Button
    Private comboBox1 As System.Windows.Forms.ComboBox
    Private label1 As System.Windows.Forms.Label
    Private components As System.ComponentModel.IContainer = Nothing
    
    Public Sub New() ' This call is required by the Windows Form Designer.
        InitializeComponent()
        area1.FillSampleValues()
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

    '/ <summary>
    '/ Required method for Designer support - do not modify
    '/ the contents of this method with the code editor.
    '/ </summary>
    Private Sub InitializeComponent()
        Me.area1 = New Steema.TeeChart.Styles.Area
        Me.trendFunction1 = New Steema.TeeChart.Functions.TrendFunction
        Me.line1 = New Steema.TeeChart.Styles.Line
        Me.button1 = New System.Windows.Forms.Button
        Me.comboBox1 = New System.Windows.Forms.ComboBox
        Me.label1 = New System.Windows.Forms.Label
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(440, 56)
        Me.textBox1.Text = "The Trend function calculates the ""best fit"" line using all the data source point" + "s.Trend function supports several different trendline styles:" + vbCr + vbLf + "- normal ""best fi" + "t"" line" + vbCr + vbLf + "- exponential (weighted) fit," + vbCr + vbLf + "- logarithmic fit."
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Controls.Add(Me.comboBox1)
        Me.panel1.Controls.Add(Me.button1)
        Me.panel1.Location = New System.Drawing.Point(0, 56)
        Me.panel1.Name = "panel1"
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
        ' 
        ' tChart1.Header.Font
        ' 
        Me.tChart1.Header.Font.Bold = True
        Me.tChart1.Header.Font.Name = "Courier New"
        Me.tChart1.Header.Lines = New String() {"Trendline example"}
        Me.tChart1.Location = New System.Drawing.Point(0, 95)
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
        Me.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(224, System.Byte), CType(192, System.Byte))
        Me.tChart1.Panel.Brush.Gradient.Visible = True
        ' 
        ' tChart1.Panel.Gradient
        ' 
        Me.tChart1.Panel.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(224, System.Byte), CType(192, System.Byte))
        Me.tChart1.Panel.Gradient.Visible = True
        Me.tChart1.Series.Add(Me.area1)
        Me.tChart1.Series.Add(Me.line1)
        Me.tChart1.Size = New System.Drawing.Size(440, 222)
        ' 
        ' area1
        ' 
        ' 
        ' area1.AreaBrush
        ' 
        Me.area1.AreaBrush.Color = System.Drawing.Color.FromArgb(CType(204, System.Byte), CType(128, System.Byte), CType(128, System.Byte), CType(255, System.Byte))
        ' 
        ' area1.Gradient
        ' 
        Me.area1.AreaBrush.Gradient.Transparency = 20
        ' 
        ' area1.Brush
        ' 
        Me.area1.Brush.Color = System.Drawing.Color.FromArgb(CType(204, System.Byte), CType(128, System.Byte), CType(128, System.Byte), CType(255, System.Byte))
        Me.area1.Brush.Visible = False
        ' 
        ' area1.Gradient
        ' 
        Me.area1.Gradient.Transparency = 20
        ' 
        ' area1.Marks
        ' 
        ' 
        ' area1.Marks.Symbol
        ' 
        ' 
        ' area1.Marks.Symbol.Shadow
        ' 
        Me.area1.Marks.Symbol.Shadow.Height = 1
        Me.area1.Marks.Symbol.Shadow.Visible = True
        Me.area1.Marks.Symbol.Shadow.Width = 1
        ' 
        ' area1.Pointer
        ' 
        ' 
        ' area1.Pointer.Brush
        ' 
        Me.area1.Pointer.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(0, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        Me.area1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.area1.Title = "Data"
        ' 
        ' area1.XValues
        ' 
        Me.area1.XValues.DataMember = "X"
        Me.area1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' area1.YValues
        ' 
        Me.area1.YValues.DataMember = "Y"
        ' 
        ' line1
        ' 
        ' 
        ' line1.Brush
        ' 
        Me.line1.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(0, System.Byte), CType(128, System.Byte), CType(0, System.Byte))
        Me.line1.DataSource = Me.area1
        Me.line1.Function = Me.trendFunction1
        ' 
        ' line1.LinePen
        ' 
        Me.line1.LinePen.Style = System.Drawing.Drawing2D.DashStyle.DashDot
        Me.line1.LinePen.Width = 2
        ' 
        ' line1.Marks
        ' 
        ' 
        ' line1.Marks.Symbol
        ' 
        ' 
        ' line1.Marks.Symbol.Shadow
        ' 
        Me.line1.Marks.Symbol.Shadow.Height = 1
        Me.line1.Marks.Symbol.Shadow.Visible = True
        Me.line1.Marks.Symbol.Shadow.Width = 1
        ' 
        ' line1.Pointer
        ' 
        ' 
        ' line1.Pointer.Brush
        ' 
        Me.line1.Pointer.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(0, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        Me.line1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.line1.Title = "Trendline"
        ' 
        ' line1.XValues
        ' 
        Me.line1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' button1
        ' 
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.Location = New System.Drawing.Point(16, 8)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(160, 23)
        Me.button1.TabIndex = 0
        Me.button1.Text = "New random points"
        AddHandler Me.button1.Click, AddressOf Me.button1_Click
        ' 
        ' comboBox1
        ' 
        Me.comboBox1.Items.AddRange(New Object() {"Normal", "Exponential", "Logarithmic"})
        Me.comboBox1.Location = New System.Drawing.Point(280, 8)
        Me.comboBox1.Name = "comboBox1"
        Me.comboBox1.Size = New System.Drawing.Size(121, 21)
        Me.comboBox1.TabIndex = 1
        Me.comboBox1.Text = "comboBox1"
        AddHandler Me.comboBox1.SelectedIndexChanged, AddressOf Me.comboBox1_SelectedIndexChanged
        ' 
        ' label1
        ' 
        Me.label1.Location = New System.Drawing.Point(208, 8)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(72, 16)
        Me.label1.TabIndex = 2
        Me.label1.Text = "Trend style:"
        ' 
        ' Function_Trend
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(440, 317)
        Me.Name = "Function_Trend"
        AddHandler Me.Load, AddressOf Me.Function_Trend_Load
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub
#End Region


    Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        area1.FillSampleValues()
    End Sub 'button1_Click


    Private Sub Function_Trend_Load(ByVal sender As Object, ByVal e As System.EventArgs)
        comboBox1.SelectedIndex = 0
    End Sub 'Function_Trend_Load


    Private Sub comboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Select Case comboBox1.SelectedIndex
            Case 0
                trendFunction1.TrendStyle = TrendStyles.Normal
                trendFunction1.Series.Title = "Trendline"
                Exit Select
            Case 1
                trendFunction1.TrendStyle = TrendStyles.Exponential
                trendFunction1.Series.Title = "Exp.trendline"
                Exit Select
            Case 2
                trendFunction1.TrendStyle = TrendStyles.Logarithmic
                trendFunction1.Series.Title = "Log.trendline"
                Exit Select
        End Select
    End Sub 'comboBox1_SelectedIndexChanged
End Class 'Function_Trend