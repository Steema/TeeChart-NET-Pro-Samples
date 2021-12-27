Imports System
#If VS2005 Then
Imports System.Collections.Generic
#End If
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms


Public Class Function_DSamp_MMFLN_DPC
    Inherits Samples.BaseForm

    '/ <summary>
    '/ Required designer variable.
    '/ </summary>
    Private components As System.ComponentModel.IContainer = Nothing


    Public Sub New() ' me call is required by the Windows Form Designer.
        InitializeComponent()
#If VS2005 Then
        cbMethod.Items.AddRange(System.Enum.GetNames(GetType(Steema.TeeChart.Functions.DownSamplingMethod)))
        InitializeChart()
#End If
    End Sub


    Private points As Steema.TeeChart.Styles.Points
    Private fastLine As Steema.TeeChart.Styles.FastLine
    Private downSampling As Steema.TeeChart.Functions.DownSampling
    Private label1 As Label
    Private label2 As Label
    Private WithEvents cbMethod As ComboBox
    Private WithEvents udPointCount As NumericUpDown
#If VS2005 Then
    Private xValues() As Nullable(Of Double)
    Private yValues() As Nullable(Of Double)

    Private Sub InitializeChart()
        CreateArrays()
        tChart1.Aspect.View3D = False
        tChart1.Zoom.Direction = ZoomDirections.Horizontal
        points = New Steema.TeeChart.Styles.Points()
        tChart1.Series.Add(points)
        fastLine = New Steema.TeeChart.Styles.FastLine()
        tChart1.Series.Add(fastLine)

        downSampling = New Steema.TeeChart.Functions.DownSampling(tChart1.Chart)
        points.Add(xValues, yValues)
        points.Active = False

        downSampling.DisplayedPointCount = 1000
        downSampling.Method = Steema.TeeChart.Functions.DownSamplingMethod.MinMaxFirstLastNull
        fastLine.TreatNulls = Steema.TeeChart.Styles.TreatNullsStyle.DoNotPaint
        fastLine.DataSource = points
        fastLine.Function = downSampling

    End Sub

    Private Sub CreateArrays()
        Dim length As Integer = 20000

        xValues = New Nullable(Of Double)(length) {}
        yValues = New Nullable(Of Double)(length) {}

        Dim rnd As Random = New Random()
        For i As Integer = 0 To length - 1
            xValues(i) = i
            If (i Mod 20) = 0 Then
                yValues(i) = Nothing
            Else
                yValues(i) = rnd.Next(100)
            End If
        Next i
    End Sub

    Private Sub tChart1_Zoomed(ByVal sender As Object, ByVal e As EventArgs) Handles tChart1.Zoomed
        tChart1(1).CheckDataSource() 'series 1 is the function series
    End Sub

    Private Sub tChart1_UndoneZoom(ByVal sender As Object, ByVal e As EventArgs) Handles tChart1.UndoneZoom
        tChart1.Axes.Bottom.SetMinMax(0, tChart1(0).Count) 'series 0 is the original series, although you could use any value to set the maximum
        tChart1(1).CheckDataSource()
    End Sub

    Private Sub udPointCount_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles udPointCount.ValueChanged
        If Not downSampling Is Nothing Then
            downSampling.DisplayedPointCount = CInt(udPointCount.Value)
            tChart1.Axes.Bottom.SetMinMax(0, tChart1(0).Count)
            tChart1(1).CheckDataSource()
        End If
    End Sub

    Private Sub cbMethod_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbMethod.SelectedIndexChanged
        downSampling.Method = CType(System.Enum.Parse(GetType(Steema.TeeChart.Functions.DownSamplingMethod), cbMethod.SelectedItem.ToString), Steema.TeeChart.Functions.DownSamplingMethod)
        tChart1(1).CheckDataSource()
    End Sub
#End If

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
    '/ the contents of me method with the code editor.
    '/ </summary>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Function_DSamp_MMFLN_DPC))
        Me.udPointCount = New System.Windows.Forms.NumericUpDown()
        Me.label1 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.cbMethod = New System.Windows.Forms.ComboBox()
        Me.panel1.SuspendLayout()
        Me.chartContainer.SuspendLayout()
        CType(Me.udPointCount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Text = resources.GetString("textBox1.Text")
#If Not VS2005 Then
			me.textBox1.Text += " System.Nullable only supported in .NET Framework 2.0"
#End If
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.cbMethod)
        Me.panel1.Controls.Add(Me.label2)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Controls.Add(Me.udPointCount)
        ' 
        ' tChart1
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tChart1.Panel.Brush.Gradient.ExtendedColorPalette = Nothing
        Me.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.tChart1.Panel.Brush.Gradient.UseMiddle = True
        Me.tChart1.Panel.Brush.Gradient.Visible = True
        Me.tChart1.Size = New System.Drawing.Size(440, 205)
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Walls.Back.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tChart1.Walls.Back.Brush.Gradient.ExtendedColorPalette = Nothing
        Me.tChart1.Walls.Back.Brush.Gradient.MiddleColor = System.Drawing.Color.Empty
        Me.tChart1.Walls.Back.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.tChart1.Walls.Back.Brush.Gradient.Visible = True
        Me.tChart1.Walls.Back.Brush.Visible = True
        Me.tChart1.Walls.Back.Transparent = False
        ' 
        ' udPointCount
        ' 
        Me.udPointCount.Increment = New Decimal(New Integer() { _
                 100, _
                 0, _
                 0, _
                 0})
        Me.udPointCount.Location = New System.Drawing.Point(117, 8)
        Me.udPointCount.Maximum = New Decimal(New Integer() { _
                 20000, _
                 0, _
                 0, _
                 0})
        Me.udPointCount.Minimum = New Decimal(New Integer() { _
                 4, _
                 0, _
                 0, _
                 0})
        Me.udPointCount.Name = "udPointCount"
        Me.udPointCount.Size = New System.Drawing.Size(66, 20)
        Me.udPointCount.TabIndex = 0
        Me.udPointCount.Value = New Decimal(New Integer() { _
                 1000, _
                 0, _
                 0, _
                 0})
        ' 
        ' label1
        ' 
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(3, 10)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(108, 13)
        Me.label1.TabIndex = 1
        Me.label1.Text = "DisplayedPointCount:"
        ' 
        ' label2
        ' 
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(189, 10)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(117, 13)
        Me.label2.TabIndex = 2
        Me.label2.Text = "DownSamplingMethod:"
        ' 
        ' cbMethod
        ' 
        Me.cbMethod.Location = New System.Drawing.Point(307, 8)
        Me.cbMethod.Name = "cbMethod"
        Me.cbMethod.Size = New System.Drawing.Size(121, 21)
        Me.cbMethod.TabIndex = 3
        Me.cbMethod.Text = "MinMaxFirstLastNull"
        ' 
        ' Function_DSamp_MMFLN_DPC
        '
#If VS2005 Then
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
#End If
        Me.ClientSize = New System.Drawing.Size(440, 317)
        Me.Name = "Function_DSamp_MMFLN_DPC"
        Me.Text = "Function_DSamp_MMFLN_DPC"
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.chartContainer.ResumeLayout(False)
        CType(Me.udPointCount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

#End Region



End Class

