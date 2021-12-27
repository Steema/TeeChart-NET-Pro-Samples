Imports System
#If VS2005 Then
Imports System.Collections.Generic
#End If
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms



Public Class Series_NullableValues
    Inherits Samples.BaseForm

    '/ <summary>
    '/ Required designer variable.
    '/ </summary>
    Private components As System.ComponentModel.IContainer = Nothing


    Public Sub New() ' me call is required by the Windows Form Designer.
        InitializeComponent()
#If VS2005 Then
			InitializeChart()
#End If
    End Sub
#If VS2005 Then
		private Sub InitializeChart()
        tChart1.Aspect.View3D = False

        Dim XValues() As Nullable(Of Double) = New Nullable(Of Double)(200) {}
        Dim YValues() As Nullable(Of Double) = New Nullable(Of Double)(200) {}

        Dim rnd As Random = New Random()
        For i As Integer = 0 To 200 - 1
            XValues(i) = i
            If (i Mod 4) = 0 Then
                YValues(i) = Nothing
            Else
                YValues(i) = rnd.NextDouble()
            End If
        Next i
        Dim fastLine As Steema.TeeChart.Styles.FastLine = New Steema.TeeChart.Styles.FastLine()
        tChart1.Series.Add(fastLine)
        fastLine.TreatNulls = Steema.TeeChart.Styles.TreatNullsStyle.DoNotPaint
        tChart1.Series(0).Add(XValues, YValues)
    End Sub

    Private Sub textBox1_TextChanged(ByVal sender As Object, ByVal e As EventArgs)

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Series_NullableValues))
        Me.chartContainer.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 

        Me.textBox1.Text = resources.GetString("textBox1.Text")
#If Not VS2005 Then
        Me.textBox1.Text += "System.Nullable only supported in .NET Framework 2.0"
#Else
        AddHandler textBox1.TextChanged, AddressOf Me.textBox1_TextChanged
#End If
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
        Me.tChart1.Axes.Bottom.Labels.Font.Name = "Verdana"
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Bottom.Title.Font.Name = "Verdana"
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Depth.Labels.Font.Name = "Verdana"
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Depth.Title.Font.Name = "Verdana"
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.DepthTop.Labels.Font.Name = "Verdana"
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.DepthTop.Title.Font.Name = "Verdana"
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Left.Labels.Font.Name = "Verdana"
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Left.Title.Font.Name = "Verdana"
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Right.Labels.Font.Name = "Verdana"
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Right.Title.Font.Name = "Verdana"
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Top.Labels.Font.Name = "Verdana"
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Top.Title.Font.Name = "Verdana"
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
        Me.tChart1.Header.Font.Name = "Verdana"
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Legend.Font.Name = "Verdana"
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
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb((CType(((CType((236), Byte))), Integer)), (CType(((CType((233), Byte))), Integer)), (CType(((CType((216), Byte))), Integer)))
        ' 
        ' 
        ' 
        Me.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb((CType(((CType((254), Byte))), Integer)), (CType(((CType((21), Byte))), Integer)), (CType(((CType((60), Byte))), Integer)), (CType(((CType((89), Byte))), Integer)))
        Me.tChart1.Panel.Brush.Gradient.ExtendedColorPalette = Nothing
        Me.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb((CType(((CType((254), Byte))), Integer)), (CType(((CType((255), Byte))), Integer)), (CType(((CType((255), Byte))), Integer)), (CType(((CType((255), Byte))), Integer)))
        Me.tChart1.Panel.Brush.Gradient.Sigma = True
        Me.tChart1.Panel.Brush.Gradient.SigmaFocus = 1.0F
        Me.tChart1.Panel.Brush.Gradient.SigmaScale = 0.8F
        Me.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb((CType(((CType((254), Byte))), Integer)), (CType(((CType((255), Byte))), Integer)), (CType(((CType((255), Byte))), Integer)), (CType(((CType((255), Byte))), Integer)))
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
        ' 
        ' Series_NullableValues
        ' 
#If VS2005 Then
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
#End If
        Me.ClientSize = New System.Drawing.Size(440, 317)
        Me.Name = "Series_NullableValues"
        Me.Text = "Series_NullableValues"
        Me.chartContainer.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region



End Class

