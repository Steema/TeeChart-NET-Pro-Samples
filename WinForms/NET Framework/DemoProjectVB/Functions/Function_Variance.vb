
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms


Public Class Function_Variance
    Inherits Steema.TeeChart.Samples.BaseForm
    Private button1 As System.Windows.Forms.Button
    Private points1 As Steema.TeeChart.Styles.Points
    Private varianceFunction1 As Steema.TeeChart.Functions.VarianceFunction
    Private line1 As Steema.TeeChart.Styles.Line
    Private components As System.ComponentModel.IContainer = Nothing
    
    Public Sub New() ' This call is required by the Windows Form Designer.
        InitializeComponent()

        points1.FillSampleValues()
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
        Me.button1 = New System.Windows.Forms.Button
        Me.points1 = New Steema.TeeChart.Styles.Points
        Me.varianceFunction1 = New Steema.TeeChart.Functions.VarianceFunction
        Me.line1 = New Steema.TeeChart.Styles.Line
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(440, 56)
        Me.textBox1.Text = "The Variance function returns how spread out a distribution is. The Standard Devi" + "ation function is the square root of the variance."
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.button1)
        Me.panel1.Location = New System.Drawing.Point(0, 56)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(440, 48)
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
        ' tChart1.Axes
        ' 
        ' 
        ' tChart1.Axes.Left
        ' 
        ' 
        ' tChart1.Axes.Left.Labels
        ' 
        ' 
        ' tChart1.Axes.Left.Labels.Font
        ' 
        Me.tChart1.Axes.Left.Labels.Font.Name = "Georgia"
        ' 
        ' tChart1.Axes.Right
        ' 
        ' 
        ' tChart1.Axes.Right.Labels
        ' 
        ' 
        ' tChart1.Axes.Right.Labels.Font
        ' 
        Me.tChart1.Axes.Right.Labels.Font.Name = "Georgia"
        Me.tChart1.BackColor = System.Drawing.Color.Transparent
        ' 
        ' tChart1.Header
        ' 
        ' 
        ' tChart1.Header.Font
        ' 
        Me.tChart1.Header.Font.Name = "Georgia"
        Me.tChart1.Header.Font.Size = 9
        Me.tChart1.Header.Lines = New String() {"Variance function example"}
        ' 
        ' tChart1.Legend
        ' 
        Me.tChart1.Legend.Alignment = Steema.TeeChart.LegendAlignments.Bottom
        Me.tChart1.Location = New System.Drawing.Point(0, 104)
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Brush
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.tChart1.Series.Add(Me.points1)
        Me.tChart1.Series.Add(Me.line1)
        Me.tChart1.Size = New System.Drawing.Size(440, 213)
        ' 
        ' button1
        ' 
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.Location = New System.Drawing.Point(32, 16)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(120, 23)
        Me.button1.TabIndex = 0
        Me.button1.Text = "New random values"
        AddHandler Me.button1.Click, AddressOf Me.button1_Click
        ' 
        ' points1
        ' 
        ' 
        ' points1.Marks
        ' 
        ' 
        ' points1.Marks.Symbol
        ' 
        ' 
        ' points1.Marks.Symbol.Shadow
        ' 
        Me.points1.Marks.Symbol.Shadow.Height = 1
        Me.points1.Marks.Symbol.Shadow.Visible = True
        Me.points1.Marks.Symbol.Shadow.Width = 1
        ' 
        ' points1.Pointer
        ' 
        ' 
        ' points1.Pointer.Brush
        ' 
        Me.points1.Pointer.Brush.Color = System.Drawing.Color.Red
        Me.points1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.points1.Title = "Data"
        ' 
        ' points1.XValues
        ' 
        Me.points1.XValues.DataMember = "X"
        Me.points1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' points1.YValues
        ' 
        Me.points1.YValues.DataMember = "Y"
        ' 
        ' line1
        ' 
        ' 
        ' line1.Brush
        ' 
        Me.line1.Brush.Color = System.Drawing.Color.Green
        Me.line1.DataSource = Me.points1
        Me.line1.Function = Me.varianceFunction1
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
        Me.line1.Title = "Variance"
        Me.line1.VertAxis = Steema.TeeChart.Styles.VerticalAxis.Right
        ' 
        ' line1.XValues
        ' 
        Me.line1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' Function_Variance
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(440, 317)
        Me.Name = "Function_Variance"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub
#End Region


    Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        points1.FillSampleValues()
    End Sub 'button1_Click
End Class 'Function_Variance