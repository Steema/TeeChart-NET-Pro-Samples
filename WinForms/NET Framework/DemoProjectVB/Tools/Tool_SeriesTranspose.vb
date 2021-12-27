
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing

Imports System.Windows.Forms



Public Class Tool_SeriesTranspose
    Inherits Samples.BaseForm


    Private button1 As Button
    Private bar1 As Steema.TeeChart.Styles.Bar
    Private bar2 As Steema.TeeChart.Styles.Bar
    Private bar3 As Steema.TeeChart.Styles.Bar
    Private seriesTranspose1 As Steema.TeeChart.Tools.SeriesTranspose
    '/ <summary>
    '/ Required designer variable.
    '/ </summary>
    Private components As System.ComponentModel.IContainer = Nothing


    Public Sub New() ' This call is required by the Windows Form Designer.
        InitializeComponent()
        bar1.FillSampleValues(6)
        bar2.FillSampleValues(6)
        bar3.FillSampleValues(6)

        bar3.SetNull(5)
        bar3.Delete(5)
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

        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Tool_SeriesTranspose))
        Me.bar1 = New Steema.TeeChart.Styles.Bar
        Me.bar2 = New Steema.TeeChart.Styles.Bar
        Me.bar3 = New Steema.TeeChart.Styles.Bar
        Me.button1 = New System.Windows.Forms.Button
        Me.seriesTranspose1 = New Steema.TeeChart.Tools.SeriesTranspose
        Me.panel1.SuspendLayout()
        Me.chartContainer.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.button1)
        ' 
        ' tChart1
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Aspect.ColorPaletteIndex = 0
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
        Me.tChart1.Series.Add(Me.bar1)
        Me.tChart1.Series.Add(Me.bar2)
        Me.tChart1.Series.Add(Me.bar3)
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
        Me.tChart1.Tools.Add(Me.seriesTranspose1)
        ' 
        ' bar1
        ' 
        ' 
        ' 
        ' 
        Me.bar1.Brush.Color = System.Drawing.Color.Red
        Me.bar1.ColorEach = False
        ' 
        ' 
        ' 
        Me.bar1.Gradient.ExtendedColorPalette = Nothing
        Me.bar1.Gradient.StartColor = System.Drawing.Color.Red
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.bar1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None
        Me.bar1.Marks.Callout.ArrowHeadSize = 8
        ' 
        ' 
        ' 
        Me.bar1.Marks.Callout.Brush.Color = System.Drawing.Color.Black
        Me.bar1.Marks.Callout.Distance = 0
        Me.bar1.Marks.Callout.Draw3D = False
        Me.bar1.Marks.Callout.Length = 20
        Me.bar1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        ' 
        ' 
        ' 
        Me.bar1.Marks.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        Me.bar1.MultiBar = Steema.TeeChart.Styles.MultiBars.None
        Me.bar1.Title = "bar1"
        ' 
        ' 
        ' 
        Me.bar1.XValues.DataMember = "X"
        Me.bar1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' 
        ' 
        Me.bar1.YValues.DataMember = "Bar"
        ' 
        ' bar2
        ' 
        ' 
        ' 
        ' 
        Me.bar2.Brush.Color = System.Drawing.Color.Green
        Me.bar2.ColorEach = False
        ' 
        ' 
        ' 
        Me.bar2.Gradient.ExtendedColorPalette = Nothing
        Me.bar2.Gradient.StartColor = System.Drawing.Color.Green
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.bar2.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None
        Me.bar2.Marks.Callout.ArrowHeadSize = 8
        ' 
        ' 
        ' 
        Me.bar2.Marks.Callout.Brush.Color = System.Drawing.Color.Black
        Me.bar2.Marks.Callout.Distance = 0
        Me.bar2.Marks.Callout.Draw3D = False
        Me.bar2.Marks.Callout.Length = 20
        Me.bar2.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        ' 
        ' 
        ' 
        Me.bar2.Marks.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        Me.bar2.MultiBar = Steema.TeeChart.Styles.MultiBars.None
        Me.bar2.Title = "bar2"
        ' 
        ' 
        ' 
        Me.bar2.XValues.DataMember = "X"
        Me.bar2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' 
        ' 
        Me.bar2.YValues.DataMember = "Bar"
        ' 
        ' bar3
        ' 
        ' 
        ' 
        ' 
        Me.bar3.Brush.Color = System.Drawing.Color.Yellow
        Me.bar3.ColorEach = False
        ' 
        ' 
        ' 
        Me.bar3.Gradient.ExtendedColorPalette = Nothing
        Me.bar3.Gradient.StartColor = System.Drawing.Color.Yellow
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.bar3.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None
        Me.bar3.Marks.Callout.ArrowHeadSize = 8
        ' 
        ' 
        ' 
        Me.bar3.Marks.Callout.Brush.Color = System.Drawing.Color.Black
        Me.bar3.Marks.Callout.Distance = 0
        Me.bar3.Marks.Callout.Draw3D = False
        Me.bar3.Marks.Callout.Length = 20
        Me.bar3.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        ' 
        ' 
        ' 
        Me.bar3.Marks.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        Me.bar3.MultiBar = Steema.TeeChart.Styles.MultiBars.None
        Me.bar3.Title = "bar3"
        ' 
        ' 
        ' 
        Me.bar3.XValues.DataMember = "X"
        Me.bar3.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' 
        ' 
        Me.bar3.YValues.DataMember = "Bar"
        ' 
        ' button1
        ' 
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.Location = New System.Drawing.Point(12, 10)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(75, 23)
        Me.button1.TabIndex = 0
        Me.button1.Text = "Transpose"
#If VS2005 Then
        Me.button1.UseVisualStyleBackColor = True
#End If
        AddHandler button1.Click, AddressOf Me.button1_Click
        ' 
        ' Tool_SeriesTranspose
        ' 
        Me.ClientSize = New System.Drawing.Size(440, 317)
        Me.Name = "Tool_SeriesTranspose"
        Me.panel1.ResumeLayout(False)
        Me.chartContainer.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

#End Region

    Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs)
        seriesTranspose1.Transpose()
    End Sub


End Class

