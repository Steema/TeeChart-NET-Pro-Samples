
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing

Imports System.Windows.Forms




Public Class Series_Shape
    Inherits Samples.BaseForm
    Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
    Private shapeSeries1 As Steema.TeeChart.Styles.Shape
    Private shapeSeries2 As Steema.TeeChart.Styles.Shape
    Private shapeSeries3 As Steema.TeeChart.Styles.Shape
    Private shapeSeries4 As Steema.TeeChart.Styles.Shape
    Private WithEvents button1 As System.Windows.Forms.Button
    Private components As System.ComponentModel.IContainer = Nothing
    
    
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.shapeSeries2.Color = Color.Orange
        
        Me.shapeSeries1.FillSampleValues()
        Me.shapeSeries2.FillSampleValues()
        Me.shapeSeries3.FillSampleValues()
        Me.shapeSeries4.FillSampleValues()
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
        Me.checkBox1 = New System.Windows.Forms.CheckBox
        Me.shapeSeries1 = New Steema.TeeChart.Styles.Shape
        Me.shapeSeries2 = New Steema.TeeChart.Styles.Shape
        Me.shapeSeries3 = New Steema.TeeChart.Styles.Shape
        Me.shapeSeries4 = New Steema.TeeChart.Styles.Shape
        Me.button1 = New System.Windows.Forms.Button
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(511, 64)
        Me.textBox1.Text = "The Shape series allows displaying text on any Chart position with optional text," + " style and visual attributes." + vbCr + vbLf + "Click on a shape to edit its properties."
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.button1)
        Me.panel1.Controls.Add(Me.checkBox1)
        Me.panel1.Location = New System.Drawing.Point(0, 64)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(511, 40)
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
        ' tChart1.Axes.Bottom
        ' 
        ' 
        ' tChart1.Axes.Bottom.Grid
        ' 
        Me.tChart1.Axes.Bottom.Grid.Visible = False
        ' 
        ' tChart1.Axes.Left
        ' 
        ' 
        ' tChart1.Axes.Left.Grid
        ' 
        Me.tChart1.Axes.Left.Grid.Visible = False
        ' 
        ' tChart1.Header
        ' 
        ' 
        ' tChart1.Header.Brush
        ' 
        ' 
        ' tChart1.Header.Gradient
        ' 
        Me.tChart1.Header.Brush.Gradient.Direction = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.tChart1.Header.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(192, System.Byte), CType(192, System.Byte), CType(192, System.Byte))
        Me.tChart1.Header.Brush.Gradient.Visible = True
        ' 
        ' tChart1.Header.Font
        ' 
        Me.tChart1.Header.Font.Bold = True
        Me.tChart1.Header.Font.Size = 7
        ' 
        ' tChart1.Header.Gradient
        ' 
        Me.tChart1.Header.Gradient.Direction = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.tChart1.Header.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(192, System.Byte), CType(192, System.Byte), CType(192, System.Byte))
        Me.tChart1.Header.Gradient.Visible = True
        Me.tChart1.Header.Lines = New String() {"Different Shape Styles"}
        ' 
        ' tChart1.Header.Pen
        ' 
        Me.tChart1.Header.Pen.Style = System.Drawing.Drawing2D.DashStyle.Dot
        Me.tChart1.Header.Pen.Width = 2
        Me.tChart1.Header.Visible = False
        Me.tChart1.Location = New System.Drawing.Point(0, 104)
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Brush
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.tChart1.Series.Add(Me.shapeSeries1)
        Me.tChart1.Series.Add(Me.shapeSeries2)
        Me.tChart1.Series.Add(Me.shapeSeries3)
        Me.tChart1.Series.Add(Me.shapeSeries4)
        Me.tChart1.Size = New System.Drawing.Size(511, 208)
        ' 
        ' tChart1.Walls
        ' 
        ' 
        ' tChart1.Walls.Back
        ' 
        ' 
        ' tChart1.Walls.Back.Brush
        ' 
        Me.tChart1.Walls.Back.Brush.Color = System.Drawing.Color.FromArgb(CType(51, System.Byte), CType(192, System.Byte), CType(192, System.Byte), CType(192, System.Byte))
        ' 
        ' tChart1.Walls.Back.Gradient
        ' 
        Me.tChart1.Walls.Back.Brush.Gradient.Transparency = 80
        ' 
        ' tChart1.Walls.Back.Gradient
        ' 
        Me.tChart1.Walls.Back.Gradient.Transparency = 80
        Me.tChart1.Walls.Back.Transparent = False
        ' 
        ' checkBox1
        ' 
        Me.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox1.Location = New System.Drawing.Point(15, 8)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(87, 23)
        Me.checkBox1.TabIndex = 0
        Me.checkBox1.Text = "&Transparent"
        ' 
        ' shapeSeries1
        ' 
        ' 
        ' shapeSeries1.Brush
        ' 
        ' 
        ' shapeSeries1.Gradient
        ' 
        Me.shapeSeries1.Brush.Gradient.Direction = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.shapeSeries1.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(255, System.Byte), CType(255, System.Byte), CType(0, System.Byte))
        Me.shapeSeries1.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(128, System.Byte), CType(255, System.Byte), CType(128, System.Byte))
        Me.shapeSeries1.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.shapeSeries1.Brush.Gradient.UseMiddle = True
        Me.shapeSeries1.Brush.Gradient.Visible = True
        ' 
        ' shapeSeries1.Gradient
        ' 
        Me.shapeSeries1.Gradient.Direction = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.shapeSeries1.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(255, System.Byte), CType(255, System.Byte), CType(0, System.Byte))
        Me.shapeSeries1.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(128, System.Byte), CType(255, System.Byte), CType(128, System.Byte))
        Me.shapeSeries1.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.shapeSeries1.Gradient.UseMiddle = True
        Me.shapeSeries1.Gradient.Visible = True
        Me.shapeSeries1.HorizAlignment = Steema.TeeChart.Styles.ShapeTextHorizAlign.Center
        ' 
        ' shapeSeries1.Marks
        ' 
        ' 
        ' shapeSeries1.Marks.Symbol
        ' 
        ' 
        ' shapeSeries1.Marks.Symbol.Shadow
        ' 
        Me.shapeSeries1.Marks.Symbol.Shadow.Height = 1
        Me.shapeSeries1.Marks.Symbol.Shadow.Visible = True
        Me.shapeSeries1.Marks.Symbol.Shadow.Width = 1
        ' 
        ' shapeSeries1.Pen
        ' 
        Me.shapeSeries1.Pen.Color = System.Drawing.Color.FromArgb(CType(153, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        Me.shapeSeries1.Style = Steema.TeeChart.Styles.ShapeStyles.Circle
        Me.shapeSeries1.Text = New String() {"This is an ellipse."}
        Me.shapeSeries1.Title = "shapeSeries1"
        Me.shapeSeries1.VertAlignment = Steema.TeeChart.Styles.ShapeTextVertAlign.Center
        ' 
        ' shapeSeries1.XValues
        ' 
        Me.shapeSeries1.XValues.DataMember = "X"
        Me.shapeSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        Me.shapeSeries1.XYStyle = Steema.TeeChart.Styles.ShapeXYStyles.Axis
        ' 
        ' shapeSeries1.YValues
        ' 
        Me.shapeSeries1.YValues.DataMember = "Y"
        ' 
        ' shapeSeries2
        ' 
        Me.shapeSeries2.HorizAlignment = Steema.TeeChart.Styles.ShapeTextHorizAlign.Center
        ' 
        ' shapeSeries2.Marks
        ' 
        ' 
        ' shapeSeries2.Marks.Symbol
        ' 
        ' 
        ' shapeSeries2.Marks.Symbol.Shadow
        ' 
        Me.shapeSeries2.Marks.Symbol.Shadow.Height = 1
        Me.shapeSeries2.Marks.Symbol.Shadow.Visible = True
        Me.shapeSeries2.Marks.Symbol.Shadow.Width = 1
        ' 
        ' shapeSeries2.Pen
        ' 
        Me.shapeSeries2.Pen.Color = System.Drawing.Color.FromArgb(CType(0, System.Byte), CType(77, System.Byte), CType(0, System.Byte))
        Me.shapeSeries2.Pen.Width = 2
        Me.shapeSeries2.Style = Steema.TeeChart.Styles.ShapeStyles.Rectangle
        Me.shapeSeries2.Text = New String() {"This is a round ", "rectangle."}
        Me.shapeSeries2.Title = "shapeSeries2"
        Me.shapeSeries2.VertAlignment = Steema.TeeChart.Styles.ShapeTextVertAlign.Center
        ' 
        ' shapeSeries2.XValues
        ' 
        Me.shapeSeries2.XValues.DataMember = "X"
        Me.shapeSeries2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        Me.shapeSeries2.XYStyle = Steema.TeeChart.Styles.ShapeXYStyles.Axis
        ' 
        ' shapeSeries2.YValues
        ' 
        Me.shapeSeries2.YValues.DataMember = "Y"
        ' 
        ' shapeSeries3
        ' 
        ' 
        ' shapeSeries3.Font
        ' 
        Me.shapeSeries3.Font.Bold = True
        ' 
        ' shapeSeries3.Font.Brush
        ' 
        Me.shapeSeries3.Font.Brush.Color = System.Drawing.Color.Green
        Me.shapeSeries3.HorizAlignment = Steema.TeeChart.Styles.ShapeTextHorizAlign.Center
        ' 
        ' shapeSeries3.Marks
        ' 
        ' 
        ' shapeSeries3.Marks.Symbol
        ' 
        ' 
        ' shapeSeries3.Marks.Symbol.Shadow
        ' 
        Me.shapeSeries3.Marks.Symbol.Shadow.Height = 1
        Me.shapeSeries3.Marks.Symbol.Shadow.Visible = True
        Me.shapeSeries3.Marks.Symbol.Shadow.Width = 1
        ' 
        ' shapeSeries3.Pen
        ' 
        Me.shapeSeries3.Pen.Color = System.Drawing.Color.FromArgb(CType(153, System.Byte), CType(153, System.Byte), CType(0, System.Byte))
        Me.shapeSeries3.Style = Steema.TeeChart.Styles.ShapeStyles.InvertTriangle
        Me.shapeSeries3.Text = New String() {"A triangle shape."}
        Me.shapeSeries3.Title = "shapeSeries3"
        Me.shapeSeries3.VertAlignment = Steema.TeeChart.Styles.ShapeTextVertAlign.Center
        ' 
        ' shapeSeries3.XValues
        ' 
        Me.shapeSeries3.XValues.DataMember = "X"
        Me.shapeSeries3.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        Me.shapeSeries3.XYStyle = Steema.TeeChart.Styles.ShapeXYStyles.Axis
        ' 
        ' shapeSeries3.YValues
        ' 
        Me.shapeSeries3.YValues.DataMember = "Y"
        ' 
        ' shapeSeries4
        ' 
        Me.shapeSeries4.HorizAlignment = Steema.TeeChart.Styles.ShapeTextHorizAlign.Center
        ' 
        ' shapeSeries4.Marks
        ' 
        ' 
        ' shapeSeries4.Marks.Symbol
        ' 
        ' 
        ' shapeSeries4.Marks.Symbol.Shadow
        ' 
        Me.shapeSeries4.Marks.Symbol.Shadow.Height = 1
        Me.shapeSeries4.Marks.Symbol.Shadow.Visible = True
        Me.shapeSeries4.Marks.Symbol.Shadow.Width = 1
        ' 
        ' shapeSeries4.Pen
        ' 
        Me.shapeSeries4.Pen.Color = System.Drawing.Color.FromArgb(CType(0, System.Byte), CType(0, System.Byte), CType(153, System.Byte))
        Me.shapeSeries4.Style = Steema.TeeChart.Styles.ShapeStyles.Diamond
        Me.shapeSeries4.Text = New String() {"Diamond shape"}
        Me.shapeSeries4.Title = "shapeSeries4"
        Me.shapeSeries4.VertAlignment = Steema.TeeChart.Styles.ShapeTextVertAlign.Center
        ' 
        ' shapeSeries4.XValues
        ' 
        Me.shapeSeries4.XValues.DataMember = "X"
        Me.shapeSeries4.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        Me.shapeSeries4.XYStyle = Steema.TeeChart.Styles.ShapeXYStyles.Axis
        ' 
        ' shapeSeries4.YValues
        ' 
        Me.shapeSeries4.YValues.DataMember = "Y"
        ' 
        ' button1
        ' 
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.Location = New System.Drawing.Point(136, 8)
        Me.button1.Name = "button1"
        Me.button1.TabIndex = 1
        Me.button1.Text = "&Edit..."
        ' 
        ' SeriesType_Shape
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(511, 312)
        Me.Name = "SeriesType_Shape"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub 'InitializeComponent 
#End Region


    Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox1.CheckedChanged

        For Each s As Steema.TeeChart.Styles.Series In tChart1.Series
            If TypeOf s Is Steema.TeeChart.Styles.Shape Then
                CType(s, Steema.TeeChart.Styles.Shape).Transparent = checkBox1.Checked
            End If
        Next s
    End Sub 'checkBox1_CheckedChanged

    Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
        Steema.TeeChart.Editors.SeriesEditor.ShowModal(tChart1(0))
    End Sub 'button1_Click
End Class 'Series_Shape
