
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing

Imports System.Windows.Forms
Imports Steema.TeeChart.Drawing




Public Class Pie_Multi
    Inherits Samples.BaseForm
    Private WithEvents pieSeries1 As Steema.TeeChart.Styles.Pie
    Private WithEvents pieSeries2 As Steema.TeeChart.Styles.Pie
    Private WithEvents pieSeries3 As Steema.TeeChart.Styles.Pie
    Private WithEvents pieSeries4 As Steema.TeeChart.Styles.Pie
    Private components As System.ComponentModel.IContainer = Nothing
    
    
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        

        For Each s As Steema.TeeChart.Styles.Series In tChart1.Series
            s.FillSampleValues(4)
        Next s
        tChart1.Aspect.ApplyZOrder = False
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
        Me.pieSeries1 = New Steema.TeeChart.Styles.Pie
        Me.pieSeries2 = New Steema.TeeChart.Styles.Pie
        Me.pieSeries3 = New Steema.TeeChart.Styles.Pie
        Me.pieSeries4 = New Steema.TeeChart.Styles.Pie
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(466, 63)
        Me.textBox1.Text = "Multiple Pie series can be aligned using the BeforeDrawValues event and the Chart" + "Rect property." + vbCr + vbLf + vbCr + vbLf + "Example: tChart1.Chart.ChartRect = new Rectangle( 20, 20, 200," + "200 )"
        ' 
        ' panel1
        ' 
        Me.panel1.Location = New System.Drawing.Point(0, 63)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(466, 27)
        Me.panel1.Visible = False
        ' 
        ' tChart1
        ' 
        ' 
        ' tChart1.Aspect
        ' 
        Me.tChart1.Aspect.Elevation = 315
        Me.tChart1.Aspect.Orthogonal = False
        Me.tChart1.Aspect.Perspective = 0
        Me.tChart1.Aspect.Rotation = 360
        Me.tChart1.Aspect.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality
        Me.tChart1.Aspect.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        ' 
        ' tChart1.Header
        ' 
        Me.tChart1.Header.Lines = New String() {"Multiple pies per chart"}
        ' 
        ' tChart1.Legend
        ' 
        Me.tChart1.Legend.Visible = False
        Me.tChart1.Location = New System.Drawing.Point(0, 90)
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Brush
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.tChart1.Series.Add(Me.pieSeries1)
        Me.tChart1.Series.Add(Me.pieSeries2)
        Me.tChart1.Series.Add(Me.pieSeries3)
        Me.tChart1.Series.Add(Me.pieSeries4)
        Me.tChart1.Size = New System.Drawing.Size(466, 196)
        ' 
        ' pieSeries1
        ' 
        ' 
        ' pieSeries1.Brush
        ' 
        Me.pieSeries1.Brush.Color = System.Drawing.Color.Red
        Me.pieSeries1.LabelMember = "Labels"
        ' 
        ' pieSeries1.Marks
        ' 
        ' 
        ' pieSeries1.Marks.Symbol
        ' 
        ' 
        ' pieSeries1.Marks.Symbol.Shadow
        ' 
        Me.pieSeries1.Marks.Symbol.Shadow.Height = 1
        Me.pieSeries1.Marks.Symbol.Shadow.Visible = True
        Me.pieSeries1.Marks.Symbol.Shadow.Width = 1
        ' 
        ' pieSeries1.Pen
        ' 
        Me.pieSeries1.Pen.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(128, System.Byte), CType(128, System.Byte), CType(128, System.Byte))
        ' 
        ' pieSeries1.Shadow
        ' 
        Me.pieSeries1.Shadow.Height = 20
        Me.pieSeries1.Shadow.Width = 20
        Me.pieSeries1.Title = "pieSeries1"
        ' 
        ' pieSeries1.XValues
        ' 
        Me.pieSeries1.XValues.DataMember = "Angle"
        Me.pieSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' pieSeries1.YValues
        ' 
        Me.pieSeries1.YValues.DataMember = "Pie"
        ' 
        ' pieSeries2
        ' 
        ' 
        ' pieSeries2.Brush
        ' 
        Me.pieSeries2.Brush.Color = System.Drawing.Color.Green
        Me.pieSeries2.LabelMember = "Labels"
        ' 
        ' pieSeries2.Marks
        ' 
        ' 
        ' pieSeries2.Marks.Symbol
        ' 
        ' 
        ' pieSeries2.Marks.Symbol.Shadow
        ' 
        Me.pieSeries2.Marks.Symbol.Shadow.Height = 1
        Me.pieSeries2.Marks.Symbol.Shadow.Visible = True
        Me.pieSeries2.Marks.Symbol.Shadow.Width = 1
        ' 
        ' pieSeries2.Pen
        ' 
        Me.pieSeries2.Pen.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(128, System.Byte), CType(128, System.Byte), CType(128, System.Byte))
        ' 
        ' pieSeries2.Shadow
        ' 
        Me.pieSeries2.Shadow.Height = 20
        Me.pieSeries2.Shadow.Width = 20
        Me.pieSeries2.Title = "pieSeries2"
        ' 
        ' pieSeries2.XValues
        ' 
        Me.pieSeries2.XValues.DataMember = "Angle"
        Me.pieSeries2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' pieSeries2.YValues
        ' 
        Me.pieSeries2.YValues.DataMember = "Pie"
        ' 
        ' pieSeries3
        ' 
        ' 
        ' pieSeries3.Brush
        ' 
        Me.pieSeries3.Brush.Color = System.Drawing.Color.Yellow
        Me.pieSeries3.LabelMember = "Labels"
        ' 
        ' pieSeries3.Marks
        ' 
        ' 
        ' pieSeries3.Marks.Symbol
        ' 
        ' 
        ' pieSeries3.Marks.Symbol.Shadow
        ' 
        Me.pieSeries3.Marks.Symbol.Shadow.Height = 1
        Me.pieSeries3.Marks.Symbol.Shadow.Visible = True
        Me.pieSeries3.Marks.Symbol.Shadow.Width = 1
        ' 
        ' pieSeries3.Pen
        ' 
        Me.pieSeries3.Pen.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(128, System.Byte), CType(128, System.Byte), CType(128, System.Byte))
        ' 
        ' pieSeries3.Shadow
        ' 
        Me.pieSeries3.Shadow.Height = 20
        Me.pieSeries3.Shadow.Width = 20
        Me.pieSeries3.Title = "pieSeries3"
        ' 
        ' pieSeries3.XValues
        ' 
        Me.pieSeries3.XValues.DataMember = "Angle"
        Me.pieSeries3.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' pieSeries3.YValues
        ' 
        Me.pieSeries3.YValues.DataMember = "Pie"
        ' 
        ' pieSeries4
        ' 
        ' 
        ' pieSeries4.Brush
        ' 
        Me.pieSeries4.Brush.Color = System.Drawing.Color.Blue
        Me.pieSeries4.LabelMember = "Labels"
        ' 
        ' pieSeries4.Marks
        ' 
        ' 
        ' pieSeries4.Marks.Symbol
        ' 
        ' 
        ' pieSeries4.Marks.Symbol.Shadow
        ' 
        Me.pieSeries4.Marks.Symbol.Shadow.Height = 1
        Me.pieSeries4.Marks.Symbol.Shadow.Visible = True
        Me.pieSeries4.Marks.Symbol.Shadow.Width = 1
        ' 
        ' pieSeries4.Pen
        ' 
        Me.pieSeries4.Pen.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(128, System.Byte), CType(128, System.Byte), CType(128, System.Byte))
        ' 
        ' pieSeries4.Shadow
        ' 
        Me.pieSeries4.Shadow.Height = 20
        Me.pieSeries4.Shadow.Width = 20
        Me.pieSeries4.Title = "pieSeries4"
        ' 
        ' pieSeries4.XValues
        ' 
        Me.pieSeries4.XValues.DataMember = "Angle"
        Me.pieSeries4.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' pieSeries4.YValues
        ' 
        Me.pieSeries4.YValues.DataMember = "Pie"
        ' 
        ' Pie_Multi
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(466, 286)
        Me.Name = "Pie_Multi"
        Me.ResumeLayout(False)
    End Sub 'InitializeComponent 
#End Region


    Private Sub pieSeries1_BeforeDrawValues(ByVal sender As Object, ByVal g As Steema.TeeChart.Drawing.Graphics3D) Handles pieSeries1.BeforeDrawValues
        Me.tChart1.Chart.ChartRect = New Rectangle(10, 10, Me.tChart1.Width / 2 - 20, Me.tChart1.Height / 2 - 20)
    End Sub 'pieSeries1_BeforeDrawValues


    Private Sub pieSeries2_BeforeDrawValues(ByVal sender As Object, ByVal g As Steema.TeeChart.Drawing.Graphics3D) Handles pieSeries2.BeforeDrawValues
        Me.tChart1.Chart.ChartRect = New Rectangle(Me.tChart1.Width / 2, 10, Me.tChart1.Width / 2 - 20, Me.tChart1.Height / 2 - 20)
    End Sub 'pieSeries2_BeforeDrawValues


    Private Sub pieSeries3_BeforeDrawValues(ByVal sender As Object, ByVal g As Steema.TeeChart.Drawing.Graphics3D) Handles pieSeries3.BeforeDrawValues
        Me.tChart1.Chart.ChartRect = New Rectangle(10, Me.tChart1.Height / 2, Me.tChart1.Width / 2 - 20, Me.tChart1.Height / 2 - 20)
    End Sub 'pieSeries3_BeforeDrawValues


    Private Sub pieSeries4_BeforeDrawValues(ByVal sender As Object, ByVal g As Steema.TeeChart.Drawing.Graphics3D) Handles pieSeries4.BeforeDrawValues
        Me.tChart1.Chart.ChartRect = New Rectangle(Me.tChart1.Width / 2, Me.tChart1.Height / 2, Me.tChart1.Width / 2 - 20, Me.tChart1.Height / 2 - 20)
    End Sub 'pieSeries4_BeforeDrawValues
End Class 'Pie_Multi
