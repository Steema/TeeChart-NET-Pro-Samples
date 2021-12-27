
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms


Public Class Series_PointFigure
    Inherits Steema.TeeChart.Samples.BaseForm
    Private pointFigure1 As Steema.TeeChart.Styles.PointFigure
    Private components As System.ComponentModel.IContainer = Nothing
    
    Public Sub New() ' This call is required by the Windows Form Designer.
        InitializeComponent()

        Me.pointFigure1.FillSampleValues(10)
        Me.pointFigure1.BoxSize = 5
    End Sub


    '/ <summary>
    '/ Clean up any resources being used.
    '/ </summary>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If Disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(Disposing)
    End Sub 'Dispose

#Region "Windows Form Designer generated code"

    '/ <summary>
    '/ Required method for Designer support - do not modify
    '/ the contents of this method with the code editor.
    '/ </summary>
    Private Sub InitializeComponent()
        Me.pointFigure1 = New Steema.TeeChart.Styles.PointFigure
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(630, 63)
        Me.textBox1.Text = "Point & Figure series is a financial chart style. Point & Figure is made of X's a" + "nd O's symbols representing over time filtered price movements."
        ' 
        ' panel1
        ' 
        Me.panel1.Location = New System.Drawing.Point(0, 63)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(630, 34)
        ' 
        ' tChart1
        ' 
        ' 
        ' tChart1.Aspect
        ' 
        Me.tChart1.Aspect.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality
        Me.tChart1.Aspect.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        ' 
        ' tChart1.Header
        ' 
        Me.tChart1.Header.Lines = New String() {"Point and figure chart"}
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
        Me.tChart1.Panel.Brush.Gradient.Direction = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(224, System.Byte), CType(224, System.Byte), CType(224, System.Byte))
        Me.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(255, System.Byte), CType(255, System.Byte), CType(192, System.Byte))
        Me.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(255, System.Byte), CType(255, System.Byte), CType(0, System.Byte))
        Me.tChart1.Panel.Brush.Gradient.UseMiddle = True
        Me.tChart1.Panel.Brush.Gradient.Visible = True
        ' 
        ' tChart1.Panel.Gradient
        ' 
        Me.tChart1.Panel.Gradient.Direction = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.tChart1.Panel.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(224, System.Byte), CType(224, System.Byte), CType(224, System.Byte))
        Me.tChart1.Panel.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(255, System.Byte), CType(255, System.Byte), CType(192, System.Byte))
        Me.tChart1.Panel.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(255, System.Byte), CType(255, System.Byte), CType(0, System.Byte))
        Me.tChart1.Panel.Gradient.UseMiddle = True
        Me.tChart1.Panel.Gradient.Visible = True
        Me.tChart1.Series.Add(Me.pointFigure1)
        Me.tChart1.Size = New System.Drawing.Size(630, 296)
        ' 
        ' pointFigure1
        ' 
        ' 
        ' pointFigure1.Brush
        ' 
        Me.pointFigure1.Brush.Color = System.Drawing.Color.Red
        Me.pointFigure1.CloseValues = Me.pointFigure1.YValues
        Me.pointFigure1.DateValues = Me.pointFigure1.XValues
        ' 
        ' pointFigure1.Marks
        ' 
        ' 
        ' pointFigure1.Marks.Symbol
        ' 
        ' 
        ' pointFigure1.Marks.Symbol.Shadow
        ' 
        Me.pointFigure1.Marks.Symbol.Shadow.Height = 1
        Me.pointFigure1.Marks.Symbol.Shadow.Visible = True
        Me.pointFigure1.Marks.Symbol.Shadow.Width = 1
        ' 
        ' pointFigure1.Pointer
        ' 
        ' 
        ' pointFigure1.Pointer.Brush
        ' 
        Me.pointFigure1.Pointer.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        Me.pointFigure1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.pointFigure1.Title = "pointFigure1"
        ' 
        ' pointFigure1.XValues
        ' 
        Me.pointFigure1.XValues.DataMember = "Date"
        Me.pointFigure1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' pointFigure1.YValues
        ' 
        Me.pointFigure1.YValues.DataMember = "Close"
        ' 
        ' Series_PointAndFigure
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(630, 393)
        Me.Name = "Series_PointAndFigure"
        Me.ResumeLayout(False)
    End Sub 'New 
#End Region
End Class 'Series_PointFigure