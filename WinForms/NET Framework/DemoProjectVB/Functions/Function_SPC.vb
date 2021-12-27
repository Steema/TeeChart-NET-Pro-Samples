
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing

Imports System.Windows.Forms




Public Class Function_SPC
    Inherits Samples.BaseForm
    Private lineSeries1 As Steema.TeeChart.Styles.Line
    Private lineSeries2 As Steema.TeeChart.Styles.Line
    Private WithEvents colorLine1 As Steema.TeeChart.Tools.ColorLine
    Private WithEvents colorLine2 As Steema.TeeChart.Tools.ColorLine
    Private label1 As System.Windows.Forms.Label
    Private label2 As System.Windows.Forms.Label
    Private textBox2 As System.Windows.Forms.TextBox
    Private textBox3 As System.Windows.Forms.TextBox
    Private components As System.ComponentModel.IContainer = Nothing
    
    
    Private Sub CalcLimits(Good As Steema.TeeChart.Styles.Series, Bad As Steema.TeeChart.Styles.Series)
        Dim sum, sumn, tmp, aux, lcp, lcn, numtotal, percent As Double
        Dim n As Integer
        Me.colorLine1.Value = 0
        Me.colorLine2.Value = 0
        n = 0

        sum = 0
        sumn = 0
        Dim i As Integer = 0
        Do While (i < Good.Count)
            percent = (Bad.YValues(i) * (Good.YValues(i) / 100))
            numtotal = (Good.YValues(i) + percent)
            If (numtotal > 0) Then
                sum = (sum + (percent / numtotal))
                sumn = (sumn + numtotal)
                n = (n + 1)
            End If
            i = (i + 1)
        Loop
        lcp = (sum / n)
        lcn = (sumn / n)
        tmp = ((lcp * (1 - lcp)) / lcn)
        If (tmp > 0) Then
            aux = (3 * Math.Sqrt(tmp))
            ' <-- 3 by square root
            Me.colorLine1.Value = (100 * (lcp + aux))
            Me.colorLine2.Value = (100 * (lcp - aux))
        End If
    End Sub 'CalcLimits
     
    
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        
        Me.tChart1.Axes.Left.Title.Angle = 90
        Me.tChart1.Axes.Right.Title.Angle = 90
        Me.colorLine1.Pen.Width = 2
        Me.colorLine1.Pen.Color = Color.Green
        Me.colorLine2.Pen.Width = 2
        Me.colorLine2.Pen.Color = Color.Yellow
        
        
        Me.lineSeries1.Pointer.Visible = True
        Me.lineSeries2.Pointer.Visible = True
        Dim r As New System.Random()
        Dim i As Integer
        For i = 1 To 18
            Me.lineSeries1.Add((800 + r.Next(200))) ' good
            Me.lineSeries2.Add((4 + r.Next(4))) ' bad
        Next i
        
        CalcLimits(lineSeries1, lineSeries2)
        Me.textBox2.Text = Me.colorLine1.Value.ToString()
        Me.textBox3.Text = Me.colorLine2.Value.ToString()
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
        Me.lineSeries1 = New Steema.TeeChart.Styles.Line
        Me.lineSeries2 = New Steema.TeeChart.Styles.Line
        Me.colorLine1 = New Steema.TeeChart.Tools.ColorLine
        Me.colorLine2 = New Steema.TeeChart.Tools.ColorLine
        Me.label1 = New System.Windows.Forms.Label
        Me.label2 = New System.Windows.Forms.Label
        Me.textBox2 = New System.Windows.Forms.TextBox
        Me.textBox3 = New System.Windows.Forms.TextBox
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(425, 104)
        Me.textBox1.Text = "Calculating and charting the Upper and Lower limits of an SPC Quality Control series." + vbCr + vbLf + "This example includes formulae to calculate the SPC upper and lower limits. The Chart displays 2 series, one with the number of ""good"" parts " + vbCr + vbLf + "and another with the percent of ""bad"" parts. With these two Series, the example calculates two values: the upper and lower limits." + vbCr + vbLf + "These limits are displayed using another two series. Correctness of calculation depends very much on your particular country rules."
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.textBox3)
        Me.panel1.Controls.Add(Me.textBox2)
        Me.panel1.Controls.Add(Me.label2)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Location = New System.Drawing.Point(0, 104)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(425, 37)
        ' 
        ' tChart1
        ' 
        ' 
        ' tChart1.Aspect
        ' 
        Me.tChart1.Aspect.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality
        Me.tChart1.Aspect.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        ' 
        ' tChart1.Axes
        ' 
        ' 
        ' tChart1.Axes.Left
        ' 
        Me.tChart1.Axes.Left.Automatic = False
        Me.tChart1.Axes.Left.AutomaticMaximum = False
        Me.tChart1.Axes.Left.AutomaticMinimum = False
        Me.tChart1.Axes.Left.Maximum = 1200
        Me.tChart1.Axes.Left.Minimum = 0
        ' 
        ' tChart1.Axes.Left.Title
        ' 
        Me.tChart1.Axes.Left.Title.Caption = "Production (number of pieces)"
        Me.tChart1.Axes.Left.Title.Lines = New String() {"Production (number of pieces)"}
        ' 
        ' tChart1.Axes.Right
        ' 
        Me.tChart1.Axes.Right.Automatic = False
        Me.tChart1.Axes.Right.AutomaticMaximum = False
        Me.tChart1.Axes.Right.AutomaticMinimum = False
        Me.tChart1.Axes.Right.Maximum = 10
        Me.tChart1.Axes.Right.Minimum = 0
        ' 
        ' tChart1.Axes.Right.Title
        ' 
        Me.tChart1.Axes.Right.Title.Caption = "SPC (%)"
        Me.tChart1.Axes.Right.Title.Lines = New String() {"SPC (%)"}
        ' 
        ' tChart1.Header
        ' 
        Me.tChart1.Header.Lines = New String() {"Quality Control Chart"}
        Me.tChart1.Location = New System.Drawing.Point(0, 141)
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Brush
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.tChart1.Series.Add(Me.lineSeries1)
        Me.tChart1.Series.Add(Me.lineSeries2)
        Me.tChart1.Size = New System.Drawing.Size(425, 129)
        Me.tChart1.Tools.Add(Me.colorLine1)
        Me.tChart1.Tools.Add(Me.colorLine2)
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
        ' lineSeries1
        ' 
        ' 
        ' lineSeries1.Brush
        ' 
        Me.lineSeries1.Brush.Color = System.Drawing.Color.Red
        ' 
        ' lineSeries1.Marks
        ' 
        ' 
        ' lineSeries1.Marks.Symbol
        ' 
        ' 
        ' lineSeries1.Marks.Symbol.Shadow
        ' 
        Me.lineSeries1.Marks.Symbol.Shadow.Height = 1
        Me.lineSeries1.Marks.Symbol.Shadow.Visible = True
        Me.lineSeries1.Marks.Symbol.Shadow.Width = 1
        ' 
        ' lineSeries1.Pointer
        ' 
        ' 
        ' lineSeries1.Pointer.Brush
        ' 
        Me.lineSeries1.Pointer.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(0, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        Me.lineSeries1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.lineSeries1.Title = "Good"
        ' 
        ' lineSeries1.XValues
        ' 
        Me.lineSeries1.XValues.DataMember = "X"
        Me.lineSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' lineSeries1.YValues
        ' 
        Me.lineSeries1.YValues.DataMember = "Y"
        ' 
        ' lineSeries2
        ' 
        ' 
        ' lineSeries2.Brush
        ' 
        Me.lineSeries2.Brush.Color = System.Drawing.Color.Green
        ' 
        ' lineSeries2.Marks
        ' 
        ' 
        ' lineSeries2.Marks.Symbol
        ' 
        ' 
        ' lineSeries2.Marks.Symbol.Shadow
        ' 
        Me.lineSeries2.Marks.Symbol.Shadow.Height = 1
        Me.lineSeries2.Marks.Symbol.Shadow.Visible = True
        Me.lineSeries2.Marks.Symbol.Shadow.Width = 1
        ' 
        ' lineSeries2.Pointer
        ' 
        ' 
        ' lineSeries2.Pointer.Brush
        ' 
        Me.lineSeries2.Pointer.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(0, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        Me.lineSeries2.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.lineSeries2.Title = "Bad"
        Me.lineSeries2.VertAxis = Steema.TeeChart.Styles.VerticalAxis.Right
        ' 
        ' lineSeries2.XValues
        ' 
        Me.lineSeries2.XValues.DataMember = "X"
        Me.lineSeries2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' lineSeries2.YValues
        ' 
        Me.lineSeries2.YValues.DataMember = "Y"
        ' 
        ' colorLine1
        ' 
        Me.colorLine1.Axis = Me.tChart1.Axes.Right
        ' 
        ' colorLine2
        ' 
        Me.colorLine2.Axis = Me.tChart1.Axes.Right
        ' 
        ' label1
        ' 
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(12, 13)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(58, 16)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Upper limit"
        Me.label1.UseMnemonic = False
        ' 
        ' label2
        ' 
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(160, 13)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(58, 16)
        Me.label2.TabIndex = 1
        Me.label2.Text = "Lower limit"
        Me.label2.UseMnemonic = False
        ' 
        ' textBox2
        ' 
        Me.textBox2.Location = New System.Drawing.Point(87, 11)
        Me.textBox2.Name = "textBox2"
        Me.textBox2.ReadOnly = True
        Me.textBox2.Size = New System.Drawing.Size(48, 20)
        Me.textBox2.TabIndex = 2
        Me.textBox2.Text = "0"
        Me.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        ' 
        ' textBox3
        ' 
        Me.textBox3.Location = New System.Drawing.Point(232, 11)
        Me.textBox3.Name = "textBox3"
        Me.textBox3.ReadOnly = True
        Me.textBox3.Size = New System.Drawing.Size(48, 20)
        Me.textBox3.TabIndex = 3
        Me.textBox3.Text = "0"
        Me.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        ' 
        ' Function_SPC
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(425, 270)
        Me.Name = "Function_SPC"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub 'InitializeComponent 
#End Region


    Private Sub colorLine1_DragLine(ByVal sender As Object, ByVal e As System.EventArgs) Handles colorLine1.DragLine
        Me.textBox2.Text = Me.colorLine1.Value.ToString("#.00")
    End Sub 'colorLine1_DragLine


    Private Sub colorLine2_DragLine(ByVal sender As Object, ByVal e As System.EventArgs) Handles colorLine2.DragLine
        Me.textBox3.Text = Me.colorLine2.Value.ToString("#.00")
    End Sub 'colorLine2_DragLine


    Private Sub tChart1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tChart1.Click
    End Sub 'tChart1_Click
End Class 'Function_SPC 

