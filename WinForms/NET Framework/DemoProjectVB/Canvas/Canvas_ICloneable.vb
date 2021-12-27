
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing

Imports System.Windows.Forms
Imports Steema.TeeChart.Tools
Imports Steema.TeeChart.Styles



Public Class Canvas_ICloneable
    Inherits Samples.BaseForm

    Private label1 As System.Windows.Forms.Label
    Private label2 As System.Windows.Forms.Label

    Private line1 As Steema.TeeChart.Styles.Line
    Private selector1 As Steema.TeeChart.Tools.Selector
    Private annotation1 As Steema.TeeChart.Tools.Annotation



    '/ <summary>
    '/ Required designer variable.
    '/ </summary>
    Private components As System.ComponentModel.IContainer = Nothing


    Public Sub New() ' This call is required by the Windows Form Designer.
        InitializeComponent()
        InitializeChart()
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
        Me.label1 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Text = "A number of Canvas objects now implement the ICloneable interface," & vbCrLf & "making deep copies of these objects a one line operation, e.g." & vbCrLf & vbCrLf & "Dim NewAxis As Steema.TeeChart.Axis =  tChart1.Axes.Left.Clone() as Axis_bottom"
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.label2)
        Me.panel1.Controls.Add(Me.label1)
        ' 
        ' tChart1
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Aspect.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
        Me.tChart1.Aspect.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
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
        Me.tChart1.Axes.Bottom.Labels.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Bottom.Title.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Depth.Labels.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Depth.Title.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.DepthTop.Labels.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.DepthTop.Title.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Left.Labels.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Left.Title.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Right.Labels.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Right.Title.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Top.Labels.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Top.Title.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Footer.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Header.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Legend.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Legend.Title.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(216, Byte), Integer))
        ' 
        ' 
        ' 
        Me.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.tChart1.Panel.Brush.Gradient.ExtendedColorPalette = Nothing
        Me.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tChart1.Panel.Brush.Gradient.Sigma = True
        Me.tChart1.Panel.Brush.Gradient.SigmaFocus = 1.0!
        Me.tChart1.Panel.Brush.Gradient.SigmaScale = 0.8!
        Me.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tChart1.Panel.Brush.Gradient.UseMiddle = True
        Me.tChart1.Panel.Brush.Gradient.Visible = True
        Me.tChart1.Size = New System.Drawing.Size(440, 205)
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.SubFooter.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.SubHeader.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        ' 
        ' label1
        ' 
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(12, 3)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(346, 13)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Select an object with the mouse (axes, series, legend, titles, annotation) "
        ' 
        ' label2
        ' 
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(12, 18)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(160, 13)
        Me.label2.TabIndex = 1
        Me.label2.Text = "and click Ctrl+V to paste a copy!"
        ' 
        ' Canvas_ICloneable
        ' 
        Me.ClientSize = New System.Drawing.Size(440, 317)
        Me.Name = "Canvas_ICloneable"
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.chartContainer.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

#End Region

    Private Sub InitializeChart()
        tChart1.Aspect.View3D = False
        tChart1.Header.Text = "Canvas ICloneable Implementation"
        annotation1 = New Steema.TeeChart.Tools.Annotation(tChart1.Chart)
        annotation1.Text = "Click on me!"
        annotation1.Position = Steema.TeeChart.Tools.AnnotationPositions.LeftTop
        line1 = New Steema.TeeChart.Styles.Line(tChart1.Chart)
        line1.FillSampleValues()
        selector1 = New Steema.TeeChart.Tools.Selector(tChart1.Chart)
        selector1.AllowDrag = False
        AddHandler selector1.Selected, AddressOf Me.selector1_Selected

        tChart1.Axes.Left.Grid.Visible = False
        tChart1.Axes.Bottom.Grid.Visible = False

        AddHandler tChart1.KeyDown, AddressOf Me.tChart1_KeyDown
        AddHandler tChart1.AfterDraw, AddressOf Me.tChart1_AfterDraw

    End Sub

    Sub tChart1_AfterDraw(ByVal sender As Object, ByVal g As Steema.TeeChart.Drawing.Graphics3D)

        If (Not (tempTitle) Is Nothing) Then
            tempTitle.CustomPosition = True
            Dim rect As Rectangle = tChart1.Chart.ChartRect
            tempTitle.DoDraw(g, rect, True, "")
        End If

    End Sub
    Private tempTitle As Title

    Sub tChart1_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)

        Dim tempAnno As Annotation
        Dim tempSeries As Steema.TeeChart.Styles.Series
        Dim tempAxis As Axis

        If ((e.Control = True) AndAlso (e.KeyCode = Keys.V)) Then
            If TypeOf selected Is ICloneable Then

                If TypeOf selected Is Annotation Then
                    tempAnno = CType(CType(selected, ICloneable).Clone, Annotation)
                    tempAnno.Shape.CustomPosition = True
                    tempAnno.Left = (tempAnno.Left + 50)
                    tempAnno.Top = (tempAnno.Top + 50)
                    tChart1.Invalidate()

                ElseIf TypeOf selected Is Steema.TeeChart.Styles.Series Then
                    tempSeries = CType(CType(selected, ICloneable).Clone, Steema.TeeChart.Styles.Series)
                    Dim i As Integer = 0
                    Do While (i < tempSeries.Count)
                        tempSeries.XValues(i) = (tempSeries.XValues(i) + 1)
                        i = (i + 1)
                    Loop
                    tempSeries.Invalidate()

                ElseIf TypeOf selected Is Axis Then
                    tempAxis = CType(CType(selected, ICloneable).Clone, Axis)
                    tChart1.Axes.Custom.Add(tempAxis)
                    tempAxis.RelativePosition = (tempAxis.RelativePosition + 10)
                    If tempAxis.Horizontal Then
                        line1.CustomHorizAxis = tempAxis
                    Else
                        line1.CustomVertAxis = tempAxis
                    End If

                ElseIf TypeOf selected Is Title Then
                    tempTitle = CType(CType(selected, ICloneable).Clone, Title)
                    tempTitle.Top = (tempTitle.Top + 20)
                    tChart1.Invalidate()

                ElseIf TypeOf selected Is Legend Then
                    Dim legend As Steema.TeeChart.Tools.ExtraLegend = New ExtraLegend(tChart1.Chart)
                    'The ExtraLegend.Legend property implements Legend.Clone().
                    legend.Legend = CType(selected, Legend)
                    legend.Series = line1
                    legend.Legend.Left = (tChart1.Legend.Left - 50)
                End If
            End If
        End If
    End Sub



    Private selected As Object

    Sub selector1_Selected(ByVal sender As Object, ByVal e As EventArgs)
        selected = selector1.Selection
    End Sub

End Class

