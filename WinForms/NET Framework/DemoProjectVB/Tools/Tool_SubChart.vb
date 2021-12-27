
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing

Imports System.Windows.Forms



Public Class Tool_SubChart
    Inherits Samples.BaseForm

    Private WithEvents bEdit As Button
    '/ <summary>
    '/ Required designer variable.
    '/ </summary>
    Private components As System.ComponentModel.IContainer = Nothing


    Public Sub New() ' me call is required by the Windows Form Designer.
        InitializeComponent()
        InitializeChart()
    End Sub

    Private line1 As Steema.TeeChart.Styles.Line
    Private subChartTool1 As Steema.TeeChart.Tools.SubChartTool
    Private Sub InitializeChart()

        Dim chart As TChart
        line1 = New Steema.TeeChart.Styles.Line()
        tChart1.Series.Add(line1)
        subChartTool1 = New Steema.TeeChart.Tools.SubChartTool()
        tChart1.Tools.Add(subChartTool1)
        chart = subChartTool1.Charts.AddChart("Chart0")
        chart.Panel.Color = Color.Transparent
        chart.Series.Add(New Steema.TeeChart.Styles.Bar())
        chart(0).Marks.Visible = False
        chart(0).Color = Color.FromArgb(100, Color.Blue)
        chart = subChartTool1.Charts.AddChart("Chart1")
        chart.Panel.Color = Color.Transparent
        chart.Series.Add(New Steema.TeeChart.Styles.Area())
        chart(0).Color = Color.FromArgb(100, Color.Yellow)
        subChartTool1.Charts(1).Left = 220
        line1.FillSampleValues()

        For j As Integer = 0 To subChartTool1.Charts.Count - 1
            chart = subChartTool1.Charts(j).Chart
            For i As Integer = 0 To line1.Count - 1
                chart(0).Add(line1.XValues(i), line1.YValues(i))
            Next i
        Next j
    End Sub

    Private Sub bEdit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles bEdit.Click
        Dim editor As Steema.TeeChart.Editors.Tools.SubChartEditor = New Steema.TeeChart.Editors.Tools.SubChartEditor(subChartTool1)
        Steema.TeeChart.Editors.EditorUtils.ShowFormModal(editor)
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
    '/ the contents of me method with the code editor.
    '/ </summary>
    Private Sub InitializeComponent()
        Me.bEdit = New System.Windows.Forms.Button()
        Me.panel1.SuspendLayout()
        Me.chartContainer.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Text = "The SubChart Tools adds unlimited nested charts to the Chart component."
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.bEdit)
        ' 
        ' tChart1
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Aspect.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
        Me.tChart1.Aspect.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.tChart1.Panel.Brush.Gradient.ExtendedColorPalette = Nothing
        Me.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tChart1.Panel.Brush.Gradient.Sigma = True
        Me.tChart1.Panel.Brush.Gradient.SigmaFocus = 1.0F
        Me.tChart1.Panel.Brush.Gradient.SigmaScale = 0.8F
        Me.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tChart1.Panel.Brush.Gradient.UseMiddle = True
        Me.tChart1.Panel.Brush.Gradient.Visible = True
        Me.tChart1.Size = New System.Drawing.Size(440, 205)
        ' 
        ' bEdit
        ' 
        Me.bEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bEdit.Location = New System.Drawing.Point(12, 10)
        Me.bEdit.Name = "bEdit"
        Me.bEdit.Size = New System.Drawing.Size(101, 23)
        Me.bEdit.TabIndex = 0
        Me.bEdit.Text = "Edit SubCharts..."
#If VS2005 Then
			me.bEdit.UseVisualStyleBackColor = true
#End If
        ' 
        ' Tool_SubChart
        ' 
        Me.ClientSize = New System.Drawing.Size(440, 317)
        Me.Name = "Tool_SubChart"
        Me.panel1.ResumeLayout(False)
        Me.chartContainer.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region



End Class

