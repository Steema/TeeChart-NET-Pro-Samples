
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing

Imports System.Windows.Forms




Public Class Histogram_Transparency
    Inherits Samples.BaseForm
    Private histogramSeries1 As Steema.TeeChart.Styles.Histogram
    Private histogramSeries2 As Steema.TeeChart.Styles.Histogram
    Private label1 As System.Windows.Forms.Label
    Private WithEvents numericUpDown1 As System.Windows.Forms.NumericUpDown
    Private components As System.ComponentModel.IContainer = Nothing
    
    
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        

        For Each s As Steema.TeeChart.Styles.Series In tChart1.Series
            s.FillSampleValues(15)
        Next s
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
        Me.histogramSeries1 = New Steema.TeeChart.Styles.Histogram
        Me.histogramSeries2 = New Steema.TeeChart.Styles.Histogram
        Me.label1 = New System.Windows.Forms.Label
        Me.numericUpDown1 = New System.Windows.Forms.NumericUpDown
        Me.panel1.SuspendLayout()
        CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(466, 63)
        Me.textBox1.Text = "The Histogram series includes a Transparency property (from 0 to 100 percent)." + vbCr + vbLf + vbCr + vbLf + "histogramSeries1.Transparency = 50 "
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.numericUpDown1)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Location = New System.Drawing.Point(0, 63)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(466, 34)
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
        Me.tChart1.Header.Lines = New String() {"Histogram series with transparency"}
        ' 
        ' tChart1.Legend
        ' 
        Me.tChart1.Legend.Visible = False
        Me.tChart1.Location = New System.Drawing.Point(0, 97)
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
        Me.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(0, System.Byte), CType(0, System.Byte), CType(128, System.Byte))
        Me.tChart1.Panel.Brush.Gradient.GammaCorrection = True
        Me.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.tChart1.Panel.Brush.Gradient.Visible = True
        ' 
        ' tChart1.Panel.Gradient
        ' 
        Me.tChart1.Panel.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(0, System.Byte), CType(0, System.Byte), CType(128, System.Byte))
        Me.tChart1.Panel.Gradient.GammaCorrection = True
        Me.tChart1.Panel.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.tChart1.Panel.Gradient.Visible = True
        Me.tChart1.Series.Add(Me.histogramSeries1)
        Me.tChart1.Series.Add(Me.histogramSeries2)
        Me.tChart1.Size = New System.Drawing.Size(466, 189)
        ' 
        ' histogramSeries1
        ' 
        ' 
        ' histogramSeries1.Brush
        ' 
        Me.histogramSeries1.Brush.Color = System.Drawing.Color.Red
        ' 
        ' histogramSeries1.LinePen
        ' 
        Me.histogramSeries1.LinePen.Color = System.Drawing.Color.Black
        ' 
        ' histogramSeries1.Marks
        ' 
        ' 
        ' histogramSeries1.Marks.Symbol
        ' 
        ' 
        ' histogramSeries1.Marks.Symbol.Shadow
        ' 
        Me.histogramSeries1.Marks.Symbol.Shadow.Height = 1
        Me.histogramSeries1.Marks.Symbol.Shadow.Visible = True
        Me.histogramSeries1.Marks.Symbol.Shadow.Width = 1
        Me.histogramSeries1.Title = "histogramSeries1"
        ' 
        ' histogramSeries1.XValues
        ' 
        Me.histogramSeries1.XValues.DataMember = "X"
        Me.histogramSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' histogramSeries1.YValues
        ' 
        Me.histogramSeries1.YValues.DataMember = "Y"
        ' 
        ' histogramSeries2
        ' 
        ' 
        ' histogramSeries2.Brush
        ' 
        Me.histogramSeries2.Brush.Color = System.Drawing.Color.FromArgb(CType(127, System.Byte), CType(0, System.Byte), CType(128, System.Byte), CType(0, System.Byte))
        ' 
        ' histogramSeries2.LinePen
        ' 
        Me.histogramSeries2.LinePen.Color = System.Drawing.Color.Black
        ' 
        ' histogramSeries2.Marks
        ' 
        ' 
        ' histogramSeries2.Marks.Symbol
        ' 
        ' 
        ' histogramSeries2.Marks.Symbol.Shadow
        ' 
        Me.histogramSeries2.Marks.Symbol.Shadow.Height = 1
        Me.histogramSeries2.Marks.Symbol.Shadow.Visible = True
        Me.histogramSeries2.Marks.Symbol.Shadow.Width = 1
        Me.histogramSeries2.Title = "histogramSeries2"
        ' 
        ' histogramSeries2.XValues
        ' 
        Me.histogramSeries2.XValues.DataMember = "X"
        Me.histogramSeries2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' histogramSeries2.YValues
        ' 
        Me.histogramSeries2.YValues.DataMember = "Y"
        ' 
        ' label1
        ' 
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(20, 7)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(93, 16)
        Me.label1.TabIndex = 0
        Me.label1.Text = "&Transparency % :"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        ' 
        ' numericUpDown1
        ' 
        Me.numericUpDown1.Location = New System.Drawing.Point(120, 7)
        Me.numericUpDown1.Name = "numericUpDown1"
        Me.numericUpDown1.Size = New System.Drawing.Size(53, 20)
        Me.numericUpDown1.TabIndex = 1
        Me.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numericUpDown1.Value = New System.Decimal(New Integer() {50, 0, 0, 0})
        ' 
        ' Histogram_Transparency
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(466, 286)
        Me.Name = "Histogram_Transparency"
        Me.panel1.ResumeLayout(False)
        CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub 'InitializeComponent 
#End Region


    Private Sub numericUpDown1_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles numericUpDown1.TextChanged, numericUpDown1.ValueChanged
        Me.histogramSeries2.Transparency = Fix(Me.numericUpDown1.Value)
    End Sub 'numericUpDown1_ValueChanged
End Class 'Histogram_Transparency
