
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing

Imports System.Windows.Forms




Public Class Series_Funnel
    Inherits Samples.BaseForm
    Private funnelSeries1 As Steema.TeeChart.Styles.Funnel
    Private WithEvents button1 As System.Windows.Forms.Button
    Private label1 As System.Windows.Forms.Label
    Private WithEvents numericUpDown1 As System.Windows.Forms.NumericUpDown
    Private gridBand1 As Steema.TeeChart.Tools.GridBand
    Private components As System.ComponentModel.IContainer = Nothing
    
    
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        
        ' custom setup
        Me.funnelSeries1.Marks.Visible = True
        Me.funnelSeries1.Marks.Clip = True
        ' add some points to Funnnel/Pipeline
        Me.funnelSeries1.Add(50, 110, "1st", Color.Red)
        Me.funnelSeries1.Add(200, 50, "2nd", Color.Yellow)
        Me.funnelSeries1.Add(100, 50, "3rd", Color.Green)
        Me.funnelSeries1.Add(60, 55, "4th", Color.Blue)
        ' recalculate appearance
        Me.funnelSeries1.Recalc()
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
        Me.funnelSeries1 = New Steema.TeeChart.Styles.Funnel
        Me.button1 = New System.Windows.Forms.Button
        Me.label1 = New System.Windows.Forms.Label
        Me.numericUpDown1 = New System.Windows.Forms.NumericUpDown
        Me.gridBand1 = New Steema.TeeChart.Tools.GridBand
        Me.panel1.SuspendLayout()
        CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(466, 40)
        Me.textBox1.Text = "Funnel Series"
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.numericUpDown1)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Controls.Add(Me.button1)
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
        ' tChart1.Axes
        ' 
        ' 
        ' tChart1.Axes.Bottom
        ' 
        ' 
        ' tChart1.Axes.Bottom.Labels
        ' 
        Me.tChart1.Axes.Bottom.Labels.Angle = 90
        ' 
        ' tChart1.Axes.Left
        ' 
        Me.tChart1.Axes.Left.Visible = False
        ' 
        ' tChart1.Header
        ' 
        Me.tChart1.Header.Lines = New String() {"tChart1"}
        Me.tChart1.Header.Visible = False
        Me.tChart1.Location = New System.Drawing.Point(0, 81)
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Brush
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.tChart1.Series.Add(Me.funnelSeries1)
        Me.tChart1.Size = New System.Drawing.Size(466, 205)
        Me.tChart1.Tools.Add(Me.gridBand1)
        ' 
        ' tChart1.Walls
        ' 
        ' 
        ' tChart1.Walls.Bottom
        ' 
        ' 
        ' tChart1.Walls.Bottom.Brush
        ' 
        Me.tChart1.Walls.Bottom.Brush.Color = System.Drawing.Color.FromArgb(CType(175, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        ' 
        ' tChart1.Walls.Bottom.Gradient
        ' 
        Me.tChart1.Walls.Bottom.Brush.Gradient.Transparency = 31
        ' 
        ' tChart1.Walls.Bottom.Gradient
        ' 
        Me.tChart1.Walls.Bottom.Gradient.Transparency = 31
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
        ' funnelSeries1
        ' 
        ' 
        ' funnelSeries1.Brush
        ' 
        Me.funnelSeries1.Brush.Color = System.Drawing.Color.Red
        Me.funnelSeries1.LabelMember = "Labels"
        ' 
        ' funnelSeries1.Marks
        ' 
        ' 
        ' funnelSeries1.Marks.Symbol
        ' 
        ' 
        ' funnelSeries1.Marks.Symbol.Shadow
        ' 
        Me.funnelSeries1.Marks.Symbol.Shadow.Height = 1
        Me.funnelSeries1.Marks.Symbol.Shadow.Visible = True
        Me.funnelSeries1.Marks.Symbol.Shadow.Width = 1
        ' 
        ' funnelSeries1.OpportunityValues
        ' 
        Me.funnelSeries1.OpportunityValues.DataMember = "OpportunityValues"
        Me.funnelSeries1.PercentFormat = "0.00 %"
        Me.funnelSeries1.Title = "funnelSeries1"
        ' 
        ' funnelSeries1.XValues
        ' 
        Me.funnelSeries1.XValues.DataMember = "X"
        ' 
        ' funnelSeries1.YValues
        ' 
        Me.funnelSeries1.YValues.DataMember = "QuoteValues"
        Me.funnelSeries1.YValues.Order = Steema.TeeChart.Styles.ValueListOrder.Descending
        ' 
        ' button1
        ' 
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.Location = New System.Drawing.Point(8, 7)
        Me.button1.Name = "button1"
        Me.button1.TabIndex = 0
        Me.button1.Text = "&Edit..."
        ' 
        ' label1
        ' 
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(96, 10)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(173, 16)
        Me.label1.TabIndex = 1
        Me.label1.Text = "&Desired tolerance for acceptance:"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        ' 
        ' numericUpDown1
        ' 
        Me.numericUpDown1.Location = New System.Drawing.Point(288, 8)
        Me.numericUpDown1.Minimum = New System.Decimal(New Integer() {1, 0, 0, 0})
        Me.numericUpDown1.Name = "numericUpDown1"
        Me.numericUpDown1.Size = New System.Drawing.Size(53, 20)
        Me.numericUpDown1.TabIndex = 2
        Me.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numericUpDown1.Value = New System.Decimal(New Integer() {30, 0, 0, 0})
        ' 
        ' gridBand1
        ' 
        Me.gridBand1.Axis = Me.tChart1.Axes.Left
        ' 
        ' gridBand1.Band1
        ' 
        Me.gridBand1.Band1.Color = System.Drawing.Color.FromArgb(CType(76, System.Byte), CType(192, System.Byte), CType(192, System.Byte), CType(192, System.Byte))
        ' 
        ' gridBand1.Band2
        ' 
        Me.gridBand1.Band2.Color = System.Drawing.Color.FromArgb(CType(76, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        ' 
        ' SeriesType_Funnel
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(466, 286)
        Me.Name = "SeriesType_Funnel"
        Me.panel1.ResumeLayout(False)
        CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub 'InitializeComponent 
#End Region



    Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
        TeeChart.Editors.SeriesEditor.ShowEditor(Me.funnelSeries1)
    End Sub 'button1_Click


    Private Sub numericUpDown1_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles numericUpDown1.TextChanged, numericUpDown1.ValueChanged
        Me.funnelSeries1.DifferenceLimit = System.Convert.ToDouble(numericUpDown1.Value)
        Me.funnelSeries1.Recalc()
    End Sub 'numericUpDown1_ValueChanged
End Class 'Series_Funnel
