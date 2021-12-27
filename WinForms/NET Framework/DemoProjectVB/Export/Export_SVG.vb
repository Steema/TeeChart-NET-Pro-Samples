
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms


Public Class Export_SVG
    Inherits Steema.TeeChart.Samples.BaseForm
    Private line1 As Steema.TeeChart.Styles.Line
    Private area1 As Steema.TeeChart.Styles.Area
    Private button1 As System.Windows.Forms.Button
    Private saveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Private button2 As System.Windows.Forms.Button
    Private annotation1 As Steema.TeeChart.Tools.Annotation
    Private components As System.ComponentModel.IContainer = Nothing
    
    Public Sub New() ' This call is required by the Windows Form Designer.
        InitializeComponent()
      
        line1.FillSampleValues(10)
        area1.FillSampleValues(10)
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
        Me.line1 = New Steema.TeeChart.Styles.Line
        Me.area1 = New Steema.TeeChart.Styles.Area
        Me.button1 = New System.Windows.Forms.Button
        Me.saveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.button2 = New System.Windows.Forms.Button
        Me.annotation1 = New Steema.TeeChart.Tools.Annotation
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(440, 56)
        Me.textBox1.Text = "Exporting to SVG (Scalable Vector Graphics) graphic format is available using the" + " Export Dialog or by code at run-time. "
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.button2)
        Me.panel1.Controls.Add(Me.button1)
        Me.panel1.Location = New System.Drawing.Point(0, 56)
        Me.panel1.Name = "panel1"
        ' 
        ' tChart1
        ' 
        ' 
        ' tChart1.Aspect
        ' 
        Me.tChart1.Aspect.Chart3DPercent = 10
        Me.tChart1.Aspect.Perspective = 0
        Me.tChart1.Aspect.Rotation = 348
        Me.tChart1.Aspect.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality
        Me.tChart1.Aspect.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        ' 
        ' tChart1.Header
        ' 
        Me.tChart1.Header.Lines = New String() {"tChart1"}
        Me.tChart1.Header.Visible = False
        ' 
        ' tChart1.Legend
        ' 
        Me.tChart1.Legend.Visible = False
        Me.tChart1.Location = New System.Drawing.Point(0, 95)
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Brush
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.tChart1.Series.Add(Me.line1)
        Me.tChart1.Series.Add(Me.area1)
        Me.tChart1.Size = New System.Drawing.Size(440, 222)
        Me.tChart1.Tools.Add(Me.annotation1)
        ' 
        ' tChart1.Walls
        ' 
        ' 
        ' tChart1.Walls.Bottom
        ' 
        ' 
        ' tChart1.Walls.Bottom.Brush
        ' 
        Me.tChart1.Walls.Bottom.Brush.Color = System.Drawing.Color.FromArgb(CType(178, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        ' 
        ' tChart1.Walls.Bottom.Gradient
        ' 
        Me.tChart1.Walls.Bottom.Brush.Gradient.Transparency = 30
        ' 
        ' tChart1.Walls.Bottom.Gradient
        ' 
        Me.tChart1.Walls.Bottom.Gradient.Transparency = 30
        ' 
        ' tChart1.Walls.Bottom.Pen
        ' 
        Me.tChart1.Walls.Bottom.Pen.Visible = False
        Me.tChart1.Walls.Bottom.Size = 5
        ' 
        ' tChart1.Walls.Left
        ' 
        ' 
        ' tChart1.Walls.Left.Brush
        ' 
        Me.tChart1.Walls.Left.Brush.Color = System.Drawing.Color.FromArgb(CType(178, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(224, System.Byte))
        ' 
        ' tChart1.Walls.Left.Gradient
        ' 
        Me.tChart1.Walls.Left.Brush.Gradient.Transparency = 30
        ' 
        ' tChart1.Walls.Left.Gradient
        ' 
        Me.tChart1.Walls.Left.Gradient.Transparency = 30
        ' 
        ' tChart1.Walls.Left.Pen
        ' 
        Me.tChart1.Walls.Left.Pen.Visible = False
        Me.tChart1.Walls.Left.Size = 5
        ' 
        ' line1
        ' 
        ' 
        ' line1.Brush
        ' 
        Me.line1.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(0, System.Byte), CType(128, System.Byte), CType(0, System.Byte))
        Me.line1.ColorEach = True
        ' 
        ' line1.Marks
        ' 
        ' 
        ' line1.Marks.Symbol
        ' 
        ' 
        ' line1.Marks.Symbol.Shadow
        ' 
        Me.line1.Marks.Symbol.Shadow.Height = 1
        Me.line1.Marks.Symbol.Shadow.Visible = True
        Me.line1.Marks.Symbol.Shadow.Width = 1
        ' 
        ' line1.Pointer
        ' 
        ' 
        ' line1.Pointer.Brush
        ' 
        Me.line1.Pointer.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(0, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        Me.line1.Pointer.HorizSize = 2
        Me.line1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.line1.Pointer.VertSize = 2
        Me.line1.Pointer.Visible = True
        Me.line1.Title = "line1"
        Me.line1.VertAxis = Steema.TeeChart.Styles.VerticalAxis.Right
        ' 
        ' line1.XValues
        ' 
        Me.line1.XValues.DataMember = "X"
        Me.line1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' line1.YValues
        ' 
        Me.line1.YValues.DataMember = "Y"
        ' 
        ' area1
        ' 
        ' 
        ' area1.AreaBrush
        ' 
        Me.area1.AreaBrush.Color = System.Drawing.Color.FromArgb(CType(127, System.Byte), CType(0, System.Byte), CType(128, System.Byte), CType(0, System.Byte))
        ' 
        ' area1.Gradient
        ' 
        Me.area1.AreaBrush.Gradient.Transparency = 50
        ' 
        ' area1.Brush
        ' 
        Me.area1.Brush.Color = System.Drawing.Color.FromArgb(CType(127, System.Byte), CType(255, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        Me.area1.ColorEach = True
        ' 
        ' area1.Gradient
        ' 
        Me.area1.Gradient.Transparency = 50
        ' 
        ' area1.Marks
        ' 
        ' 
        ' area1.Marks.Symbol
        ' 
        ' 
        ' area1.Marks.Symbol.Shadow
        ' 
        Me.area1.Marks.Symbol.Shadow.Height = 1
        Me.area1.Marks.Symbol.Shadow.Visible = True
        Me.area1.Marks.Symbol.Shadow.Width = 1
        ' 
        ' area1.Pointer
        ' 
        ' 
        ' area1.Pointer.Brush
        ' 
        Me.area1.Pointer.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(0, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        Me.area1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.area1.Title = "area1"
        ' 
        ' area1.XValues
        ' 
        Me.area1.XValues.DataMember = "X"
        Me.area1.XValues.DateTime = True
        Me.area1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' area1.YValues
        ' 
        Me.area1.YValues.DataMember = "Y"
        ' 
        ' button1
        ' 
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.Location = New System.Drawing.Point(8, 8)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(104, 23)
        Me.button1.TabIndex = 1
        Me.button1.Text = "Save to SVG"
        AddHandler Me.button1.Click, AddressOf Me.button1_Click
        ' 
        ' button2
        ' 
        Me.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button2.Location = New System.Drawing.Point(160, 8)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(120, 23)
        Me.button2.TabIndex = 2
        Me.button2.Text = "Show export dialog"
        AddHandler Me.button2.Click, AddressOf Me.button2_Click
        ' 
        ' annotation1
        ' 
        Me.annotation1.Cursor = System.Windows.Forms.Cursors.Default
        Me.annotation1.Left = 100
        ' 
        ' annotation1.Shape
        ' 
        Me.annotation1.Shape.BorderRound = 8
        Me.annotation1.Shape.Bottom = 40
        ' 
        ' annotation1.Shape.Brush
        ' 
        Me.annotation1.Shape.Brush.Color = System.Drawing.Color.FromArgb(CType(102, System.Byte), CType(255, System.Byte), CType(128, System.Byte), CType(0, System.Byte))
        ' 
        ' annotation1.Shape.Gradient
        ' 
        Me.annotation1.Shape.Brush.Gradient.Transparency = 60
        Me.annotation1.Shape.CustomPosition = True
        ' 
        ' annotation1.Shape.Font
        ' 
        ' 
        ' annotation1.Shape.Font.Brush
        ' 
        Me.annotation1.Shape.Font.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.annotation1.Shape.Font.Name = "Arial Black"
        ' 
        ' annotation1.Shape.Gradient
        ' 
        Me.annotation1.Shape.Gradient.Transparency = 60
        Me.annotation1.Shape.Left = 100
        Me.annotation1.Shape.Lines = New String() {"SVG example"}
        Me.annotation1.Shape.Right = 190
        ' 
        ' annotation1.Shape.Shadow
        ' 
        Me.annotation1.Shape.Shadow.Visible = True
        Me.annotation1.Shape.ShapeStyle = Steema.TeeChart.Drawing.TextShapeStyle.RoundRectangle
        Me.annotation1.Shape.Top = 20
        Me.annotation1.Text = "SVG example"
        Me.annotation1.Top = 20
        ' 
        ' Export_SVG
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(440, 317)
        Me.Name = "Export_SVG"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub 'New 
#End Region


    Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        saveFileDialog1.DefaultExt = tChart1.Export.Image.SVG.FileExtension
        saveFileDialog1.FileName = tChart1.Name + "." + saveFileDialog1.DefaultExt
        saveFileDialog1.Filter = Texts.SVGFilter
    If Me.saveFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
      tChart1.Export.Image.SVG.Save(saveFileDialog1.FileName)
    End If
  End Sub 'button1_Click


    Private Sub button2_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        tChart1.Export.ShowExportDialog(tChart1.Export.Image.SVG)
    End Sub 'button2_Click
End Class 'Export_SVG