
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing

Imports System.Windows.Forms




Public Class Series_BarSize
    Inherits Steema.TeeChart.Samples.BaseForm
    Private annotation1 As Steema.TeeChart.Tools.Annotation
    Private components As System.ComponentModel.IContainer = Nothing
    Private WithEvents numericUpDown1 As System.Windows.Forms.NumericUpDown
    Private WithEvents trackBar1 As System.Windows.Forms.TrackBar
    Private label1 As System.Windows.Forms.Label
    Private label2 As System.Windows.Forms.Label
    Private label3 As System.Windows.Forms.Label
    Private label4 As System.Windows.Forms.Label
    Private label5 As System.Windows.Forms.Label
    Private WithEvents trackBar2 As System.Windows.Forms.TrackBar
    
    Private Series1 As BarSize
    
    
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
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
        Me.annotation1 = New Steema.TeeChart.Tools.Annotation
        Me.numericUpDown1 = New System.Windows.Forms.NumericUpDown
        Me.trackBar1 = New System.Windows.Forms.TrackBar
        Me.label1 = New System.Windows.Forms.Label
        Me.label2 = New System.Windows.Forms.Label
        Me.label3 = New System.Windows.Forms.Label
        Me.label4 = New System.Windows.Forms.Label
        Me.label5 = New System.Windows.Forms.Label
        Me.trackBar2 = New System.Windows.Forms.TrackBar
        Me.panel1.SuspendLayout()
        CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trackBar2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.ReadOnly = True
        Me.textBox1.Size = New System.Drawing.Size(528, 56)
        Me.textBox1.Text = "An example of a new Bar series that can display individual " + vbCr + vbLf + "bars with different " + "sizes (widths)."
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.trackBar2)
        Me.panel1.Controls.Add(Me.label5)
        Me.panel1.Controls.Add(Me.label4)
        Me.panel1.Controls.Add(Me.label3)
        Me.panel1.Controls.Add(Me.label2)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Controls.Add(Me.trackBar1)
        Me.panel1.Controls.Add(Me.numericUpDown1)
        Me.panel1.Location = New System.Drawing.Point(0, 56)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(528, 40)
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
        Me.tChart1.Header.Lines = New String() {"Bar Size Series example"}
        Me.tChart1.Location = New System.Drawing.Point(0, 96)
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
        Me.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(192, System.Byte))
        Me.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(192, System.Byte), CType(192, System.Byte), CType(0, System.Byte))
        Me.tChart1.Panel.Brush.Gradient.UseMiddle = True
        Me.tChart1.Panel.Brush.Gradient.Visible = True
        ' 
        ' tChart1.Panel.Gradient
        ' 
        Me.tChart1.Panel.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(192, System.Byte))
        Me.tChart1.Panel.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(192, System.Byte), CType(192, System.Byte), CType(0, System.Byte))
        Me.tChart1.Panel.Gradient.UseMiddle = True
        Me.tChart1.Panel.Gradient.Visible = True
        Me.tChart1.Size = New System.Drawing.Size(528, 261)
        Me.tChart1.Tools.Add(Me.annotation1)
        ' 
        ' annotation1
        ' 
        Me.annotation1.Cursor = System.Windows.Forms.Cursors.Default
        Me.annotation1.Left = 6
        ' 
        ' annotation1.Shape
        ' 
        Me.annotation1.Shape.Bottom = 25
        ' 
        ' annotation1.Shape.Brush
        ' 
        ' 
        ' annotation1.Shape.Gradient
        ' 
        Me.annotation1.Shape.Brush.Gradient.Direction = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.annotation1.Shape.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(224, System.Byte), CType(224, System.Byte), CType(224, System.Byte))
        Me.annotation1.Shape.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.annotation1.Shape.Brush.Gradient.Visible = True
        Me.annotation1.Shape.CustomPosition = True
        ' 
        ' annotation1.Shape.Gradient
        ' 
        Me.annotation1.Shape.Gradient.Direction = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.annotation1.Shape.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(224, System.Byte), CType(224, System.Byte), CType(224, System.Byte))
        Me.annotation1.Shape.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.annotation1.Shape.Gradient.Visible = True
        Me.annotation1.Shape.Left = 6
        Me.annotation1.Shape.Right = 15
        ' 
        ' annotation1.Shape.Shadow
        ' 
        Me.annotation1.Shape.Shadow.Height = 1
        Me.annotation1.Shape.Shadow.Visible = True
        Me.annotation1.Shape.Shadow.Width = 1
        Me.annotation1.Shape.Top = 8
        Me.annotation1.Top = 8
        ' 
        ' numericUpDown1
        ' 
        Me.numericUpDown1.Location = New System.Drawing.Point(64, 8)
        Me.numericUpDown1.Name = "numericUpDown1"
        Me.numericUpDown1.Size = New System.Drawing.Size(56, 20)
        Me.numericUpDown1.TabIndex = 0
        ' 
        ' trackBar1
        ' 
        Me.trackBar1.AutoSize = False
        Me.trackBar1.Location = New System.Drawing.Point(187, 8)
        Me.trackBar1.Maximum = 100
        Me.trackBar1.Name = "trackBar1"
        Me.trackBar1.Size = New System.Drawing.Size(88, 21)
        Me.trackBar1.TabIndex = 1
        Me.trackBar1.TickFrequency = 10
        ' 
        ' label1
        ' 
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(40, 10)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(25, 16)
        Me.label1.TabIndex = 2
        Me.label1.Text = "Bar:"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        ' 
        ' label2
        ' 
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(144, 11)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(48, 16)
        Me.label2.TabIndex = 3
        Me.label2.Text = "Position:"
        Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        ' 
        ' label3
        ' 
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(320, 10)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(29, 16)
        Me.label3.TabIndex = 4
        Me.label3.Text = "Size:"
        Me.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        ' 
        ' label4
        ' 
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(272, 11)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(10, 16)
        Me.label4.TabIndex = 6
        Me.label4.Text = "0"
        Me.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        ' 
        ' label5
        ' 
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(432, 10)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(10, 16)
        Me.label5.TabIndex = 7
        Me.label5.Text = "1"
        Me.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        ' 
        ' trackBar2
        ' 
        Me.trackBar2.AutoSize = False
        Me.trackBar2.BackColor = System.Drawing.SystemColors.Control
        Me.trackBar2.Location = New System.Drawing.Point(344, 8)
        Me.trackBar2.Maximum = 300
        Me.trackBar2.Name = "trackBar2"
        Me.trackBar2.Size = New System.Drawing.Size(88, 21)
        Me.trackBar2.TabIndex = 8
        Me.trackBar2.TickFrequency = 20
        Me.trackBar2.Value = 100
        ' 
        ' Bar_Size_Example
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(528, 357)
        Me.Name = "Bar_Size_Example"
        Me.panel1.ResumeLayout(False)
        CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trackBar2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub 'InitializeComponent 
#End Region


    Private Sub Bar_Size_Example_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Series1 = New Steema.TeeChart.Samples.BarSize(tChart1.Chart)
        Series1.FillSampleValues()

        Series1.SizeValues(0) = 0.4
        Series1.SizeValues(2) = 0.1
        Series1.SizeValues(4) = 1.1
       

        Series1.XValues(3) = 2.8
       

        Series1.Colors(1) = Color.Blue
        Series1.Colors(4) = Color.Yellow

        Series1.Marks.Visible = False

        Series1.Cursor = Cursors.Hand

        trackBar1.Maximum = Series1.Count * 100
        trackBar1.TickFrequency = trackBar1.Maximum / 10
        trackBar1.Minimum = -trackBar1.Maximum

        numericUpDown1.Maximum = Series1.Count - 1
        numericUpDown1_ValueChanged(Nothing, Nothing)
    End Sub 'Bar_Size_Example_Load


    Private Sub trackBar1_Scroll(ByVal sender As Object, ByVal e As System.EventArgs) Handles trackBar1.Scroll
        Series1.XValues(Convert.ToInt32(numericUpDown1.Value)) = trackBar1.Value / 100.0
        Series1.Repaint() '
        
        label4.Text = Series1.XValues(Convert.ToInt32(numericUpDown1.Value)).ToString()

        RefreshAnnotation()
    End Sub 'trackBar1_Scroll


    Private Sub trackBar2_Scroll(ByVal sender As Object, ByVal e As System.EventArgs) Handles trackBar2.Scroll
        Series1.SizeValues(Convert.ToInt32(numericUpDown1.Value)) = trackBar2.Value / 100.0
        Series1.Repaint()

        label5.Text = Series1.SizeValues(Convert.ToInt32(numericUpDown1.Value)).ToString()
    End Sub 'trackBar2_Scroll


    Private Sub numericUpDown1_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles numericUpDown1.ValueChanged
        trackBar1.Value = Convert.ToInt32(Series1.XValues(Convert.ToInt32(numericUpDown1.Value)) * 100)
        trackBar2.Value = Convert.ToInt32(Series1.SizeValues(Convert.ToInt32(numericUpDown1.Value)) * 100)

        RefreshAnnotation()
    End Sub 'numericUpDown1_ValueChanged


    Private Sub RefreshAnnotation()
        annotation1.Text = numericUpDown1.Value.ToString()
        annotation1.Shape.Top = tChart1.Height - 28
        annotation1.Shape.Left = Series1.CalcXPosValue(Series1.XValues(Convert.ToInt32(numericUpDown1.Value))) - 8
    End Sub 'RefreshAnnotation


    Private Sub tChart1_ClickSeries(ByVal sender As Object, ByVal s As Steema.TeeChart.Styles.Series, ByVal valueIndex As Integer, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tChart1.ClickSeries
        If valueIndex >= 0 Then
            numericUpDown1.Value = valueIndex
        End If
    End Sub 'tChart1_ClickSeries

    'Private Sub panel1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles panel1.Paint
    'End Sub 'panel1_Paint
End Class 'Series_BarSize 

