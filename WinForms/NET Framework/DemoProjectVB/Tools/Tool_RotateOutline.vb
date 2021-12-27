
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms


Public Class Tool_RotateOutline
    Inherits Steema.TeeChart.Samples.BaseForm
    Private horizArea1 As Steema.TeeChart.Styles.HorizArea
    Private buttonPen1 As Steema.TeeChart.ButtonPen
    Private checkBox1 As System.Windows.Forms.CheckBox
    Private rotate1 As Steema.TeeChart.Tools.Rotate
    Private components As System.ComponentModel.IContainer = Nothing
    
    Public Sub New() ' This call is required by the Windows Form Designer.
        InitializeComponent()

        rotate1.Pen.Visible = True
        buttonPen1.Pen = rotate1.Pen
        horizArea1.FillSampleValues()
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
        Me.horizArea1 = New Steema.TeeChart.Styles.HorizArea
        Me.buttonPen1 = New Steema.TeeChart.ButtonPen
        Me.checkBox1 = New System.Windows.Forms.CheckBox
        Me.rotate1 = New Steema.TeeChart.Tools.Rotate
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(360, 73)
        Me.textBox1.Text = "Rotate tool can now display a wireframe while rotating, instead of re-painting th" + "e whole chart." + vbCr + vbLf + vbCr + vbLf + "Click and drag the chart to see the wireframe."
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.checkBox1)
        Me.panel1.Controls.Add(Me.buttonPen1)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(360, 39)
        ' 
        ' tChart1
        ' 
        ' 
        ' tChart1.Aspect
        ' 
        Me.tChart1.Aspect.Chart3DPercent = 95
        Me.tChart1.Aspect.Orthogonal = False
        Me.tChart1.Aspect.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality
        Me.tChart1.Aspect.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        Me.tChart1.Aspect.Zoom = 87
        Me.tChart1.Cursor = System.Windows.Forms.Cursors.Default
        ' 
        ' tChart1.Header
        ' 
        Me.tChart1.Header.Lines = New String() {"Rotate tool outline"}
        ' 
        ' tChart1.Legend
        ' 
        Me.tChart1.Legend.Visible = False
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Brush
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.tChart1.Series.Add(Me.horizArea1)
        Me.tChart1.Size = New System.Drawing.Size(360, 189)
        Me.tChart1.Tools.Add(Me.rotate1)
        ' 
        ' tChart1.Walls
        ' 
        ' 
        ' tChart1.Walls.Back
        ' 
        ' 
        ' tChart1.Walls.Back.Brush
        ' 
        Me.tChart1.Walls.Back.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(192, System.Byte), CType(192, System.Byte), CType(192, System.Byte))
        Me.tChart1.Walls.Back.Transparent = False
        ' 
        ' tChart1.Walls.Right
        ' 
        ' 
        ' tChart1.Walls.Right.Brush
        ' 
        Me.tChart1.Walls.Right.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(224, System.Byte), CType(224, System.Byte), CType(224, System.Byte))
        Me.tChart1.Walls.Right.Visible = True
        ' 
        ' horizArea1
        ' 
        ' 
        ' horizArea1.AreaBrush
        ' 
        Me.horizArea1.AreaBrush.Color = System.Drawing.Color.FromArgb(CType(204, System.Byte), CType(234, System.Byte), CType(117, System.Byte), CType(0, System.Byte))
        ' 
        ' horizArea1.Gradient
        ' 
        Me.horizArea1.AreaBrush.Gradient.Direction = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.horizArea1.AreaBrush.Gradient.Transparency = 20
        ' 
        ' horizArea1.AreaLines
        ' 
        Me.horizArea1.AreaLines.Color = System.Drawing.Color.FromArgb(CType(204, System.Byte), CType(140, System.Byte), CType(70, System.Byte), CType(0, System.Byte))
        ' 
        ' horizArea1.Brush
        ' 
        Me.horizArea1.Brush.Color = System.Drawing.Color.FromArgb(CType(204, System.Byte), CType(234, System.Byte), CType(117, System.Byte), CType(0, System.Byte))
        ' 
        ' horizArea1.TopGradient
        ' 
        Me.horizArea1.Brush.Gradient.Direction = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.horizArea1.Brush.Gradient.Transparency = 100
        ' 
        ' horizArea1.Gradient
        ' 
        Me.horizArea1.Gradient.Direction = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.horizArea1.Gradient.Transparency = 20
        ' 
        ' horizArea1.LinePen
        ' 
        Me.horizArea1.LinePen.Color = System.Drawing.Color.FromArgb(CType(204, System.Byte), CType(140, System.Byte), CType(70, System.Byte), CType(0, System.Byte))
        ' 
        ' horizArea1.Marks
        ' 
        ' 
        ' horizArea1.Marks.Symbol
        ' 
        ' 
        ' horizArea1.Marks.Symbol.Shadow
        ' 
        Me.horizArea1.Marks.Symbol.Shadow.Height = 1
        Me.horizArea1.Marks.Symbol.Shadow.Visible = True
        Me.horizArea1.Marks.Symbol.Shadow.Width = 1
        ' 
        ' horizArea1.Pointer
        ' 
        ' 
        ' horizArea1.Pointer.Brush
        ' 
        Me.horizArea1.Pointer.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(0, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        Me.horizArea1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.horizArea1.Title = "horizArea1"
        ' 
        ' horizArea1.TopGradient
        ' 
        Me.horizArea1.TopGradient.Direction = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.horizArea1.TopGradient.Transparency = 100
        ' 
        ' horizArea1.XValues
        ' 
        Me.horizArea1.XValues.DataMember = "X"
        ' 
        ' horizArea1.YValues
        ' 
        Me.horizArea1.YValues.DataMember = "Y"
        Me.horizArea1.YValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' buttonPen1
        ' 
        Me.buttonPen1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonPen1.Location = New System.Drawing.Point(24, 8)
        Me.buttonPen1.Name = "buttonPen1"
        Me.buttonPen1.Size = New System.Drawing.Size(80, 24)
        Me.buttonPen1.TabIndex = 1
        Me.buttonPen1.Text = "Outline..."
        ' 
        ' checkBox1
        ' 
        Me.checkBox1.Checked = True
        Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox1.Location = New System.Drawing.Point(120, 12)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(88, 16)
        Me.checkBox1.TabIndex = 2
        Me.checkBox1.Text = "Draw outline"
        AddHandler Me.checkBox1.CheckedChanged, AddressOf Me.checkBox1_CheckedChanged
        ' 
        ' RotateOutline
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(360, 301)
        Me.Name = "RotateOutline"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub 'New 
#End Region


    Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        rotate1.Pen.Visible = checkBox1.Checked
    End Sub 'checkBox1_CheckedChanged
End Class 'Tool_RotateOutline