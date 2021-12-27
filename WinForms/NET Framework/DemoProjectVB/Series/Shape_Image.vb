
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing

Imports System.Windows.Forms




Public Class Shape_Image
    Inherits Steema.TeeChart.Samples.BaseForm
    Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
    Private shapeSeries1 As Steema.TeeChart.Styles.Shape
    Private shapeSeries2 As Steema.TeeChart.Styles.Shape
    Private components As System.ComponentModel.IContainer = Nothing
    
    
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        
        Me.shapeSeries1.FillSampleValues()
        Me.shapeSeries2.FillSampleValues()
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
        Dim resources As New System.Resources.ResourceManager(GetType(Shape_Image))
        Me.checkBox1 = New System.Windows.Forms.CheckBox
        Me.shapeSeries1 = New Steema.TeeChart.Styles.Shape
        Me.shapeSeries2 = New Steema.TeeChart.Styles.Shape
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Text = "Shape series accept Images to fill the interior. The Brush.Image property is used" + vbCr + vbLf + "to set the image bitmap." + vbCr + vbLf + vbCr + vbLf + "Example: shapeSeries1.Brush.LoadImage(""c:\\mybitma" + "p.bmp"")"
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.checkBox1)
        Me.panel1.Name = "panel1"
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
        Me.tChart1.Header.Lines = New String() {"tChart1"}
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
        Me.tChart1.Size = New System.Drawing.Size(440, 237)
        ' 
        ' tChart1.Walls
        ' 
        ' 
        ' tChart1.Walls.Bottom
        ' 
        ' 
        ' tChart1.Walls.Bottom.Pen
        ' 
        Me.tChart1.Walls.Bottom.Pen.Visible = False
        Me.tChart1.Walls.Bottom.Size = 5
        ' 
        ' tChart1.Walls.Left
        ' 
        ' 
        ' tChart1.Walls.Left.Pen
        ' 
        Me.tChart1.Walls.Left.Pen.Visible = False
        Me.tChart1.Walls.Left.Size = 5
        ' 
        ' checkBox1
        ' 
        Me.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox1.Location = New System.Drawing.Point(16, 8)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(152, 24)
        Me.checkBox1.TabIndex = 0
        Me.checkBox1.Text = "&Transparent Shapes"
        ' 
        ' shapeSeries1
        ' 
        ' 
        ' shapeSeries1.Brush
        ' 
        Me.shapeSeries1.Brush.Image = CType(resources.GetObject("shapeSeries1.Brush.Image"), System.Drawing.Image)
        Me.shapeSeries1.Brush.Solid = False
        Me.shapeSeries1.Cursor = System.Windows.Forms.Cursors.Cross
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
        Me.shapeSeries1.Pen.Width = 2
        Me.shapeSeries1.Style = Steema.TeeChart.Styles.ShapeStyles.Circle
        Me.shapeSeries1.Text = New String(-1) {}
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
        ' 
        ' shapeSeries2.Brush
        ' 
        Me.shapeSeries2.Brush.Image = CType(resources.GetObject("shapeSeries2.Brush.Image"), System.Drawing.Image)
        Me.shapeSeries2.Brush.Solid = False
        Me.shapeSeries2.Cursor = System.Windows.Forms.Cursors.Cross
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
        Me.shapeSeries2.Pen.Style = System.Drawing.Drawing2D.DashStyle.Dash
        Me.shapeSeries2.Pen.Width = 2
        Me.shapeSeries2.Style = Steema.TeeChart.Styles.ShapeStyles.Rectangle
        Me.shapeSeries2.Text = New String(-1) {}
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
        ' Shape_Image
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(440, 349)
        Me.Name = "Shape_Image"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub 'InitializeComponent 
#End Region


    Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox1.CheckedChanged

        For Each sh As TeeChart.Styles.Shape In Me.tChart1.Series
            sh.Transparent = Me.checkBox1.Checked
        Next sh
    End Sub 'checkBox1_CheckedChanged
End Class 'Shape_Image
