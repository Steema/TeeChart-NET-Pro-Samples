Imports System
#If VS2005 Then
Imports System.Collections.Generic
#End If
Imports System.ComponentModel
imports System.Data
imports System.Drawing
imports System.Text
imports System.Windows.Forms
imports Steema.TeeChart.Functions


Public Class CurveFitting_Models
    Inherits Samples.BaseForm

    Private yhat As Double()
    Private coeffs As Double()

    Private points1 As Steema.TeeChart.Styles.Points
    Private WithEvents comboBox1 As ComboBox
    Private label1 As Label
    Private line1 As Steema.TeeChart.Styles.Line

    '/ <summary>
    '/ Required designer variable.
    '/ </summary>
    Private components As System.ComponentModel.IContainer = Nothing


    Public Sub New() ' me call is required by the Windows Form Designer.
        InitializeComponent()
        points1.Add(1.1, 1)
        points1.Add(1.2, 2.5)
        points1.Add(1.25, 4)
        points1.Add(1.3, 3)
        points1.Add(1.9, 5.5)
        points1.Add(2.1, 6.2)
        points1.Add(2.2, 6.6)
        points1.Add(2.4, 7.2)
        points1.Add(3, 8)
        points1.Add(3.5, 12)
    End Sub

    Private Function FitModel(ByVal source As Steema.TeeChart.Styles.Series, ByRef yhat As Double(), ByRef coeffs As Double(), ByVal modelindex As Integer) As Boolean
        Dim y As Double() = New Double(source.Count) {}
        Dim x As Double() = New Double(source.Count) {}
        Dim w As Double() = New Double(source.Count) {}
        Dim validmodel As Boolean = True

        Select Case (modelindex)
            Case 0
                ' y(x)=a*Exp(b*x)
                ' linear model: ln(y) = b*x + ln(a)
                For i As Integer = 0 To source.Count - 1
                    x(i) = source.notMandatory(i)
                    y(i) = Math.Log(source.mandatory(i))
                    w(i) = source.mandatory(i) * source.mandatory(i)
                Next i
                Regression.LinearRegression(source.Count, x, y, w, coeffs)
                coeffs(0) = Math.Exp(coeffs(0))
                For i As Integer = 0 To source.Count - 1
                    yhat(i) = coeffs(0) * Math.Exp(coeffs(1) * x(i))
                Next i
                Exit Select
            Case 1
                ' Power model y=a*x^b
                ' linear model : ln(y) = b*ln(x) + ln(a)
                For i As Integer = 0 To source.Count - 1
                    x(i) = Math.Log(source.notMandatory(i))
                    y(i) = Math.Log(source.mandatory(i))
                    w(i) = source.mandatory(i) * source.mandatory(i)
                Next i
                Regression.LinearRegression(source.Count, x, y, w, coeffs)
                coeffs(0) = Math.Exp(coeffs(0))
                For i As Integer = 0 To source.Count - 1
                    yhat(i) = coeffs(0) * Math.Pow(source.notMandatory(i), coeffs(1))
                Next i
                Exit Select
            Case 2
                ' Logarithmic model y = b*ln(x)+a
                For i As Integer = 0 To source.Count - 1
                    x(i) = Math.Log(source.notMandatory(i))
                    y(i) = source.mandatory(i)
                    w(i) = source.mandatory(i) * source.mandatory(i)
                Next i
                Regression.LinearRegression(source.Count, x, y, w, coeffs)
                For i As Integer = 0 To source.Count - 1
                    yhat(i) = coeffs(1) * Math.Log(source.notMandatory(i)) + coeffs(0)
                Next i
                Exit Select
            Case Else
                coeffs = New Double(0) {}
                Exit Select
        End Select
        Return validmodel
    End Function


    Private Sub comboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox1.SelectedIndexChanged
        yhat = New Double(points1.XValues.Count) {}
        line1.Clear()
        If FitModel(points1, yhat, coeffs, comboBox1.SelectedIndex) Then
            line1.XValues.Count = points1.XValues.Count
            line1.XValues.Value = points1.XValues.Value
            line1.YValues.Count = points1.XValues.Count
            line1.YValues.Value = yhat
            Select Case comboBox1.SelectedIndex
                Case 0
                    tChart1.Header.Text = "y=a*Exp(b*x)" & vbCrLf & "a=" + coeffs(0).ToString("0.00") + "  b=" + coeffs(1).ToString("0.00")
                    Exit Select
                Case 1
                    tChart1.Header.Text = "y=ax^b" & vbCrLf & "a=" + coeffs(0).ToString("0.00") + "  b=" + coeffs(1).ToString("0.00")
                    Exit Select
                Case 2
                    tChart1.Header.Text = "y=b*ln(x)+a" & vbCrLf & "a=" + coeffs(0).ToString("0.00") + "  b=" + coeffs(1).ToString("0.00")
                    Exit Select
            End Select
        End If
        line1.Repaint()
    End Sub

  Private Sub CurveFitting_Models_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
    comboBox1.SelectedIndex = 0
  End Sub

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

#Region "Windows Form Designer generated code"

  '/ <summary>
  '/ Required method for Designer support - do not modify
  '/ the contents of me method with the code editor.
  '/ </summary>
  Private Sub InitializeComponent()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CurveFitting_Models))
    Me.points1 = New Steema.TeeChart.Styles.Points
    Me.label1 = New System.Windows.Forms.Label
    Me.comboBox1 = New System.Windows.Forms.ComboBox
    Me.line1 = New Steema.TeeChart.Styles.Line
    Me.panel1.SuspendLayout()
    Me.chartContainer.SuspendLayout()
    Me.SuspendLayout()
    ' 
    ' textBox1
    ' 
    Me.textBox1.Text = "By using linear regression it's possible to fit data to several linearizable mode" + _
            "ls."
    ' 
    ' panel1
    ' 
    Me.panel1.Controls.Add(Me.comboBox1)
    Me.panel1.Controls.Add(Me.label1)
    ' 
    ' tChart1
    ' 
    ' 
    ' 
    ' 
    Me.tChart1.Aspect.View3D = False
    ' 
    ' 
    ' 
    ' 
    ' 
    ' 
    ' 
    ' 
    ' 
    Me.tChart1.Legend.Title.Pen.Visible = False
    Me.tChart1.Series.Add(Me.points1)
    Me.tChart1.Series.Add(Me.line1)
    Me.tChart1.Size = New System.Drawing.Size(440, 205)
    ' 
    ' points1
    ' 
    Me.points1.ColorEach = False
    Me.points1.DefaultNullValue = 0
    ' 
    ' 
    ' 
    Me.points1.LinePen.Color = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(115, Byte), Integer))
    ' 
    ' 
    ' 
    ' 
    ' 
    ' 
    Me.points1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None
    Me.points1.Marks.Callout.ArrowHeadSize = 8
    ' 
    ' 
    ' 
    Me.points1.Marks.Callout.Brush.Color = System.Drawing.Color.Black
    Me.points1.Marks.Callout.Distance = 0
    Me.points1.Marks.Callout.Draw3D = False
    Me.points1.Marks.Callout.Length = 0
    Me.points1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
    ' 
    ' 
    ' 
    ' 
    ' 
    ' 
    Me.points1.Pointer.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(192, Byte), Integer))
    ' 
    ' 
    ' 
    Me.points1.Pointer.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(192, Byte), Integer))
    ' 
    ' 
    ' 
    Me.points1.Pointer.Pen.Color = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(115, Byte), Integer))
    Me.points1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
    Me.points1.Pointer.Visible = True
    Me.points1.Title = "Source"
    ' 
    ' 
    ' 
    Me.points1.XValues.DataMember = "X"
    Me.points1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
    ' 
    ' 
    ' 
    Me.points1.YValues.DataMember = "Y"
    ' 
    ' label1
    ' 
    Me.label1.AutoSize = True
    Me.label1.Location = New System.Drawing.Point(3, 13)
    Me.label1.Name = "label1"
    Me.label1.Size = New System.Drawing.Size(39, 13)
    Me.label1.TabIndex = 0
    Me.label1.Text = "Model:"
    ' 
    ' comboBox1
    ' 
#If VS2005 Then
        Me.comboBox1.FormattingEnabled = True
#End If
    Me.comboBox1.Items.AddRange(New Object() { _
    "y(x)=a*Exp[b*x]", _
    "y(x)=a*x^b", _
    "y(x)=a+b*Ln[x]"})
    Me.comboBox1.Location = New System.Drawing.Point(48, 10)
    Me.comboBox1.Name = "comboBox1"
    Me.comboBox1.Size = New System.Drawing.Size(177, 21)
    Me.comboBox1.TabIndex = 1
    ' 
    ' line1
    ' 
    ' 
    ' 
    ' 
    Me.line1.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(50, Byte), Integer))
    ' 
    ' 
    ' 
    Me.line1.Gradient.Direction = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
    Me.line1.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(20, Byte), Integer))
    Me.line1.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(173, Byte), Integer))
    Me.line1.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(50, Byte), Integer))
    Me.line1.Gradient.UseMiddle = True
    Me.line1.ColorEach = False
    Me.line1.DefaultNullValue = 0
    ' 
    ' 
    ' 
    Me.line1.LinePen.Color = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(25, Byte), Integer))
    ' 
    ' 
    ' 
    ' 
    ' 
    ' 
    Me.line1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None
    Me.line1.Marks.Callout.ArrowHeadSize = 8
    ' 
    ' 
    ' 
    Me.line1.Marks.Callout.Brush.Color = System.Drawing.Color.Black
    Me.line1.Marks.Callout.Distance = 0
    Me.line1.Marks.Callout.Draw3D = False
    Me.line1.Marks.Callout.Length = 10
    Me.line1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
    ' 
    ' 
    ' 
    Me.line1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
    Me.line1.Title = "Fitted"
    ' 
    ' 
    ' 
    Me.line1.XValues.DataMember = "X"
    Me.line1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
    ' 
    ' 
    ' 
    Me.line1.YValues.DataMember = "Y"
    ' 
    ' CurveFitting_Models
    ' 
    Me.ClientSize = New System.Drawing.Size(440, 317)
    Me.Name = "CurveFitting_Models"
    Me.panel1.ResumeLayout(False)
    Me.panel1.PerformLayout()
    Me.chartContainer.ResumeLayout(False)
    Me.ResumeLayout(False)
    Me.PerformLayout()
  End Sub

#End Region



End Class

