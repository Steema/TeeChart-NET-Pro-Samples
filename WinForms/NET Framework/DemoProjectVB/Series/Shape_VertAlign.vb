
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing

Imports System.Windows.Forms




Public Class Shape_VertAlign
    Inherits Steema.TeeChart.Samples.BaseForm
    Private shapeSeries1 As Steema.TeeChart.Styles.Shape
    Private shapeSeries2 As Steema.TeeChart.Styles.Shape
    Private shapeSeries3 As Steema.TeeChart.Styles.Shape
    Private groupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents radioButton1 As System.Windows.Forms.RadioButton
    Private WithEvents radioButton2 As System.Windows.Forms.RadioButton
    Private WithEvents radioButton3 As System.Windows.Forms.RadioButton
    Private components As System.ComponentModel.IContainer = Nothing
    
    
    
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        
        Me.shapeSeries1.FillSampleValues()
        Me.shapeSeries2.FillSampleValues()
        Me.shapeSeries3.FillSampleValues()
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
        Me.shapeSeries1 = New Steema.TeeChart.Styles.Shape
        Me.shapeSeries2 = New Steema.TeeChart.Styles.Shape
        Me.shapeSeries3 = New Steema.TeeChart.Styles.Shape
        Me.groupBox1 = New System.Windows.Forms.GroupBox
        Me.radioButton3 = New System.Windows.Forms.RadioButton
        Me.radioButton2 = New System.Windows.Forms.RadioButton
        Me.radioButton1 = New System.Windows.Forms.RadioButton
        Me.panel1.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(440, 56)
        Me.textBox1.Text = "Shape text canbe top, center or bottom aligned." + vbCr + vbLf + vbCr + vbLf + "Example: shape1.VertAlignment " + "= Styles.ShapeTextVertAlign.Bottom"
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.groupBox1)
        Me.panel1.Location = New System.Drawing.Point(0, 56)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(440, 60)
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
        Me.tChart1.Axes.Bottom.Automatic = False
        Me.tChart1.Axes.Bottom.AutomaticMaximum = False
        Me.tChart1.Axes.Bottom.AutomaticMinimum = False
        Me.tChart1.Axes.Bottom.Maximum = 100
        Me.tChart1.Axes.Bottom.Minimum = 0
        ' 
        ' tChart1.Axes.Left
        ' 
        Me.tChart1.Axes.Left.Automatic = False
        Me.tChart1.Axes.Left.AutomaticMaximum = False
        Me.tChart1.Axes.Left.AutomaticMinimum = False
        Me.tChart1.Axes.Left.LogarithmicBase = 2
        Me.tChart1.Axes.Left.Maximum = 115
        Me.tChart1.Axes.Left.Minimum = 0
        ' 
        ' tChart1.Header
        ' 
        Me.tChart1.Header.Lines = New String() {"tChart1"}
        Me.tChart1.Header.Visible = False
        Me.tChart1.Location = New System.Drawing.Point(0, 116)
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Bevel
        ' 
        Me.tChart1.Panel.Bevel.ColorTwo = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(192, System.Byte), CType(255, System.Byte), CType(192, System.Byte))
        ' 
        ' tChart1.Panel.Brush
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(224, System.Byte), CType(224, System.Byte), CType(224, System.Byte))
        Me.tChart1.Series.Add(Me.shapeSeries1)
        Me.tChart1.Series.Add(Me.shapeSeries2)
        Me.tChart1.Series.Add(Me.shapeSeries3)
        Me.tChart1.Size = New System.Drawing.Size(440, 273)
        ' 
        ' shapeSeries1
        ' 
        ' 
        ' shapeSeries1.Brush
        ' 
        Me.shapeSeries1.Brush.Color = System.Drawing.Color.FromArgb(CType(255, System.Byte), CType(255, System.Byte), CType(0, System.Byte))
        Me.shapeSeries1.Brush.Solid = False
        Me.shapeSeries1.Brush.Style = System.Drawing.Drawing2D.HatchStyle.HorizontalBrick
        Me.shapeSeries1.Cursor = System.Windows.Forms.Cursors.Cross
        ' 
        ' shapeSeries1.Font
        ' 
        Me.shapeSeries1.Font.Bold = True
        Me.shapeSeries1.Font.Size = 10
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
        Me.shapeSeries1.Pen.Color = System.Drawing.Color.FromArgb(CType(153, System.Byte), CType(153, System.Byte), CType(122, System.Byte))
        Me.shapeSeries1.Pen.Style = System.Drawing.Drawing2D.DashStyle.Dot
        Me.shapeSeries1.Pen.Width = 2
        Me.shapeSeries1.Style = Steema.TeeChart.Styles.ShapeStyles.Rectangle
        Me.shapeSeries1.Text = New String() {"Text at bottom"}
        Me.shapeSeries1.Title = "shapeSeries1"
        Me.shapeSeries1.VertAlignment = Steema.TeeChart.Styles.ShapeTextVertAlign.Bottom
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
        Me.shapeSeries2.Cursor = System.Windows.Forms.Cursors.Cross
        ' 
        ' shapeSeries2.Font
        ' 
        Me.shapeSeries2.Font.Bold = True
        Me.shapeSeries2.Font.Italic = True
        Me.shapeSeries2.Font.Size = 12
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
        Me.shapeSeries2.Pen.Color = System.Drawing.Color.FromArgb(CType(122, System.Byte), CType(153, System.Byte), CType(153, System.Byte))
        Me.shapeSeries2.Pen.Style = System.Drawing.Drawing2D.DashStyle.Dash
        Me.shapeSeries2.Pen.Width = 2
        Me.shapeSeries2.Style = Steema.TeeChart.Styles.ShapeStyles.Rectangle
        Me.shapeSeries2.Text = New String() {"Text at center"}
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
        ' shapeSeries3.Brush
        ' 
        Me.shapeSeries3.Brush.Color = System.Drawing.Color.FromArgb(CType(255, System.Byte), CType(192, System.Byte), CType(128, System.Byte))
        Me.shapeSeries3.Brush.ForegroundColor = System.Drawing.Color.FromArgb(CType(192, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        Me.shapeSeries3.Brush.Solid = False
        Me.shapeSeries3.Cursor = System.Windows.Forms.Cursors.Cross
        ' 
        ' shapeSeries3.Font
        ' 
        Me.shapeSeries3.Font.Bold = True
        Me.shapeSeries3.Font.Size = 12
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
        Me.shapeSeries3.Pen.Color = System.Drawing.Color.FromArgb(CType(153, System.Byte), CType(122, System.Byte), CType(122, System.Byte))
        Me.shapeSeries3.Style = Steema.TeeChart.Styles.ShapeStyles.Rectangle
        Me.shapeSeries3.Text = New String() {"Text at top"}
        Me.shapeSeries3.Title = "shapeSeries3"
        Me.shapeSeries3.VertAlignment = Steema.TeeChart.Styles.ShapeTextVertAlign.Top
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
        ' groupBox1
        ' 
        Me.groupBox1.Controls.Add(Me.radioButton3)
        Me.groupBox1.Controls.Add(Me.radioButton2)
        Me.groupBox1.Controls.Add(Me.radioButton1)
        Me.groupBox1.Location = New System.Drawing.Point(7, 7)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(273, 41)
        Me.groupBox1.TabIndex = 0
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Vertical align:"
        ' 
        ' radioButton3
        ' 
        Me.radioButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.radioButton3.Location = New System.Drawing.Point(176, 16)
        Me.radioButton3.Name = "radioButton3"
        Me.radioButton3.Size = New System.Drawing.Size(80, 16)
        Me.radioButton3.TabIndex = 2
        Me.radioButton3.Text = "&Bottom"
        ' 
        ' radioButton2
        ' 
        Me.radioButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.radioButton2.Location = New System.Drawing.Point(88, 16)
        Me.radioButton2.Name = "radioButton2"
        Me.radioButton2.Size = New System.Drawing.Size(79, 16)
        Me.radioButton2.TabIndex = 1
        Me.radioButton2.Text = "&Center"
        ' 
        ' radioButton1
        ' 
        Me.radioButton1.Checked = True
        Me.radioButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.radioButton1.Location = New System.Drawing.Point(20, 16)
        Me.radioButton1.Name = "radioButton1"
        Me.radioButton1.Size = New System.Drawing.Size(67, 16)
        Me.radioButton1.TabIndex = 0
        Me.radioButton1.TabStop = True
        Me.radioButton1.Text = "&Top"
        ' 
        ' Shape_VertAlign
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(440, 389)
        Me.Name = "Shape_VertAlign"
        Me.panel1.ResumeLayout(False)
        Me.groupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub 'InitializeComponent 
#End Region


    Private Sub radioButton1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles radioButton3.CheckedChanged, radioButton2.CheckedChanged, radioButton1.CheckedChanged
        If Me.radioButton1.Checked Then

            For Each s As TeeChart.Styles.Shape In tChart1.Series
                s.VertAlignment = Styles.ShapeTextVertAlign.Top
                s.Text(0) = "Text at Top"
            Next s
        ElseIf Me.radioButton2.Checked Then

            For Each s As TeeChart.Styles.Shape In tChart1.Series
                s.VertAlignment = Styles.ShapeTextVertAlign.Center
                s.Text(0) = "Text at Center"
            Next s
        Else
            For Each s As TeeChart.Styles.Shape In tChart1.Series
                s.VertAlignment = Styles.ShapeTextVertAlign.Bottom
                s.Text(0) = "Text at Bottom"
            Next s
        End If
    End Sub 'radioButton1_CheckedChanged
End Class 'Shape_VertAlign
