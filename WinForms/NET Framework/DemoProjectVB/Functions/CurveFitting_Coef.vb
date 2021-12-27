
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms


Public Class CurveFitting_Coef
    Inherits Steema.TeeChart.Samples.BaseForm
    Private fastLine1 As Steema.TeeChart.Styles.FastLine
    Private fastLine2 As Steema.TeeChart.Styles.FastLine
    Private polyFitting1 As Steema.TeeChart.Functions.PolyFitting
    Private label1 As System.Windows.Forms.Label
    Private cursorTool1 As Steema.TeeChart.Tools.CursorTool
    Private components As System.ComponentModel.IContainer = Nothing
    
    Public Sub New() ' This call is required by the Windows Form Designer.
        InitializeComponent()

        fastLine1.FillSampleValues(100)
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
        Me.fastLine1 = New Steema.TeeChart.Styles.FastLine
        Me.fastLine2 = New Steema.TeeChart.Styles.FastLine
        Me.polyFitting1 = New Steema.TeeChart.Functions.PolyFitting
        Me.label1 = New System.Windows.Forms.Label
        Me.cursorTool1 = New Steema.TeeChart.Tools.CursorTool
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(464, 73)
        Me.textBox1.Text = "The PolyFitting function returns the polynomial coefficients by using the Coefficient(int index) method, where index is a value between 0 and PolyDegree-1." + vbCr + vbLf + "NOTE: X and Y values are first ""normalized"" ( X - MinX, Y - MinY ) to avoid FP errors. Move the mouse to find the Y value for a given X position."
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(464, 39)
        ' 
        ' tChart1
        ' 
        ' 
        ' tChart1.Aspect
        ' 
        Me.tChart1.Aspect.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality
        Me.tChart1.Aspect.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        Me.tChart1.Aspect.View3D = False
        Me.tChart1.BackColor = System.Drawing.Color.Transparent
        ' 
        ' tChart1.Header
        ' 
        Me.tChart1.Header.Lines = New String() {"tChart1"}
        Me.tChart1.Header.Visible = False
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Brush
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(212, System.Byte), CType(208, System.Byte), CType(200, System.Byte))
        ' 
        ' tChart1.Panel.Gradient
        ' 
        Me.tChart1.Panel.Brush.Gradient.Direction = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(224, System.Byte), CType(192, System.Byte))
        Me.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(128, System.Byte), CType(128, System.Byte), CType(128, System.Byte))
        Me.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(128, System.Byte))
        Me.tChart1.Panel.Brush.Gradient.UseMiddle = True
        Me.tChart1.Panel.Brush.Gradient.Visible = True
        ' 
        ' tChart1.Panel.Gradient
        ' 
        Me.tChart1.Panel.Gradient.Direction = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.tChart1.Panel.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(224, System.Byte), CType(192, System.Byte))
        Me.tChart1.Panel.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(128, System.Byte), CType(128, System.Byte), CType(128, System.Byte))
        Me.tChart1.Panel.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(128, System.Byte))
        Me.tChart1.Panel.Gradient.UseMiddle = True
        Me.tChart1.Panel.Gradient.Visible = True
        Me.tChart1.Series.Add(Me.fastLine1)
        Me.tChart1.Series.Add(Me.fastLine2)
        Me.tChart1.Size = New System.Drawing.Size(464, 221)
        Me.tChart1.Tools.Add(Me.cursorTool1)
        AddHandler Me.tChart1.AfterDraw, AddressOf Me.tChart1_AfterDraw
        AddHandler Me.tChart1.MouseMove, AddressOf Me.tChart1_MouseMove
        ' 
        ' fastLine1
        ' 
        ' 
        ' fastLine1.LinePen
        ' 
        Me.fastLine1.LinePen.Color = System.Drawing.Color.FromArgb(CType(255, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        ' 
        ' fastLine1.Marks
        ' 
        ' 
        ' fastLine1.Marks.Symbol
        ' 
        ' 
        ' fastLine1.Marks.Symbol.Shadow
        ' 
        Me.fastLine1.Marks.Symbol.Shadow.Height = 1
        Me.fastLine1.Marks.Symbol.Shadow.Visible = True
        Me.fastLine1.Marks.Symbol.Shadow.Width = 1
        Me.fastLine1.Title = "Data"
        ' 
        ' fastLine1.XValues
        ' 
        Me.fastLine1.XValues.DataMember = "X"
        Me.fastLine1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' fastLine1.YValues
        ' 
        Me.fastLine1.YValues.DataMember = "Y"
        ' 
        ' fastLine2
        ' 
        Me.fastLine2.DataSource = Me.fastLine1
        Me.fastLine2.Function = Me.polyFitting1
        ' 
        ' fastLine2.LinePen
        ' 
        Me.fastLine2.LinePen.Color = System.Drawing.Color.FromArgb(CType(0, System.Byte), CType(0, System.Byte), CType(255, System.Byte))
        ' 
        ' fastLine2.Marks
        ' 
        ' 
        ' fastLine2.Marks.Symbol
        ' 
        ' 
        ' fastLine2.Marks.Symbol.Shadow
        ' 
        Me.fastLine2.Marks.Symbol.Shadow.Height = 1
        Me.fastLine2.Marks.Symbol.Shadow.Visible = True
        Me.fastLine2.Marks.Symbol.Shadow.Width = 1
        Me.fastLine2.Title = "Poly"
        ' 
        ' fastLine2.XValues
        ' 
        Me.fastLine2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' polyFitting1
        ' 
        Me.polyFitting1.PolyDegree = 4
        ' 
        ' label1
        ' 
        Me.label1.Location = New System.Drawing.Point(16, 8)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(424, 16)
        Me.label1.TabIndex = 0
        Me.label1.Text = "label1"
        ' 
        ' Function_PolyFitCoeff
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(464, 333)
        Me.Name = "Function_PolyFitCoeff"
        AddHandler Me.Load, AddressOf Me.PolyFitCoeff_Load
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub 'New 
#End Region

    Private Sub ShowFunction()
        Dim txt As String = "y="
        Dim t As Integer = 0
        Do While (t < polyFitting1.PolyDegree)
            txt = (txt + " ")
            If (polyFitting1.Coefficient(t) >= 0) Then
                txt = (txt + "+")
            End If
            txt = (txt + polyFitting1.Coefficient(t).ToString("0.00##"))
            If (t > 0) Then
                txt = (txt + "*x")
            End If
            If (t > 1) Then
                txt = (txt + ("^" + t.ToString))
            End If
            t = (t + 1)
        Loop
        label1.Text = ("Function : " + txt)
    End Sub 'ShowFunction

    Private Sub PolyFitCoeff_Load(ByVal sender As Object, ByVal e As System.EventArgs)
        ShowFunction()
    End Sub 'PolyFitCoeff_Load


    Private Sub tChart1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Dim xval As Double = fastLine2.GetHorizAxis.CalcPosPoint(e.X)
        Dim yval As Double = polyFitting1.GetCurveYValue(fastLine1, xval)
        cursorTool1.XValue = xval
        cursorTool1.YValue = yval
    End Sub 'tChart1_MouseMove

    Private Sub tChart1_AfterDraw(ByVal sender As Object, ByVal g As Steema.TeeChart.Drawing.Graphics3D)
        If cursorTool1.XValue > tChart1.Axes.Bottom.Minimum AndAlso cursorTool1.XValue < tChart1.Axes.Bottom.Maximum Then
            g.Brush.Color = Color.Red
            g.Brush.Visible = True
            Dim xpos As Integer = cursorTool1.GetHorizAxis.CalcPosValue(cursorTool1.XValue)
            Dim ypos As Integer = cursorTool1.GetVertAxis.CalcPosValue(cursorTool1.YValue)
            g.Rectangle(xpos - 5, ypos + 5, xpos + 5, ypos - 5)
        End If
    End Sub 'tChart1_AfterDraw
End Class 'CurveFitting_Coef