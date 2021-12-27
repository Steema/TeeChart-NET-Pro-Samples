
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms


Public Class BarJoin_Series
    Inherits Samples.BaseForm
    Private barJoinSeries1 As Steema.TeeChart.Styles.BarJoin
    Private gridBand1 As Steema.TeeChart.Tools.GridBand
    Private components As System.ComponentModel.IContainer = Nothing
    
    Public Sub New() ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.barJoinSeries1.FillSampleValues(4)
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
        Me.barJoinSeries1 = New Steema.TeeChart.Styles.BarJoin
        Me.gridBand1 = New Steema.TeeChart.Tools.GridBand
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(466, 63)
        Me.textBox1.Text = "Bar Join series draws a line between each bar point, at the top position. " + vbCr + vbLf + "The J" + "oinPen property controls the pen used to draw the lines."
        ' 
        ' panel1
        ' 
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
        Me.tChart1.Header.Alignment = System.Drawing.StringAlignment.Near
        Me.tChart1.Header.Lines = New String() {"BarJoin series"}
        Me.tChart1.Location = New System.Drawing.Point(0, 97)
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Brush
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.tChart1.Series.Add(Me.barJoinSeries1)
        Me.tChart1.Size = New System.Drawing.Size(466, 189)
        Me.tChart1.Tools.Add(Me.gridBand1)
        ' 
        ' barJoinSeries1
        ' 
        ' 
        ' barJoinSeries1.Brush
        ' 
        Me.barJoinSeries1.Brush.Color = System.Drawing.Color.Red
        ' 
        ' barJoinSeries1.Marks
        ' 
        ' 
        ' barJoinSeries1.Marks.Symbol
        ' 
        ' 
        ' barJoinSeries1.Marks.Symbol.Shadow
        ' 
        Me.barJoinSeries1.Marks.Symbol.Shadow.Height = 1
        Me.barJoinSeries1.Marks.Symbol.Shadow.Visible = True
        Me.barJoinSeries1.Marks.Symbol.Shadow.Width = 1
        ' 
        ' barJoinSeries1.Pen
        ' 
        Me.barJoinSeries1.Pen.Color = System.Drawing.Color.FromArgb(CType(153, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        Me.barJoinSeries1.Title = "barJoin1"
        ' 
        ' barJoinSeries1.XValues
        ' 
        Me.barJoinSeries1.XValues.DataMember = "X"
        Me.barJoinSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' barJoinSeries1.YValues
        ' 
        Me.barJoinSeries1.YValues.DataMember = "Bar"
        ' 
        ' gridBand1
        ' 
        Me.gridBand1.Axis = Me.tChart1.Axes.Left
        ' 
        ' gridBand1.Band1
        ' 
        Me.gridBand1.Band1.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(224, System.Byte), CType(224, System.Byte), CType(224, System.Byte))
        ' 
        ' gridBand1.Band2
        ' 
        Me.gridBand1.Band2.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        ' 
        ' SeriesType_BarJoin
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(466, 286)
        Me.Name = "SeriesType_BarJoin"
        Me.ResumeLayout(False)
    End Sub 'New 
#End Region
End Class 'BarJoin_Series