
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing

Imports System.Windows.Forms



Public Class Area_TreatNulls
    Inherits Samples.BaseForm

    Private label1 As Label
    Private WithEvents comboBox1 As ComboBox
    Private area1 As Steema.TeeChart.Styles.Area
    '/ <summary>
    '/ Required designer variable.
    '/ </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    Private Sub FillSeries()
        Dim done As Boolean = False
        Dim y As Double
        For x As Integer = 0 To 10
            If (x Mod 2) = 0 Then
                y = 10
            Else
                y = 20
            End If
            If (x >= 3) AndAlso (x <= 7) Then
                If Not done Then
                    area1.Add(x, 0, Color.Transparent)
                End If
                done = True
            Else
                area1.Add(x, y)
            End If
        Next x
    End Sub

    Public Sub New() ' me call is required by the Windows Form Designer.
        InitializeComponent()
        area1.GetVertAxis.SetMinMax(-10, 30)
        FillSeries()
        area1.TreatNulls = Steema.TeeChart.Styles.TreatNullsStyle.DoNotPaint
    End Sub

    Private Sub comboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox1.SelectedIndexChanged
        Select Case (comboBox1.SelectedIndex)
            Case 0
                area1.TreatNulls = Steema.TeeChart.Styles.TreatNullsStyle.DoNotPaint
                Exit Select
            Case 1
                area1.TreatNulls = Steema.TeeChart.Styles.TreatNullsStyle.Skip
                Exit Select
            Case Else
                area1.TreatNulls = Steema.TeeChart.Styles.TreatNullsStyle.Ignore
                Exit Select
        End Select
    End Sub

  Private Sub Area_TreatNulls_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Area_TreatNulls))
    Me.area1 = New Steema.TeeChart.Styles.Area
    Me.label1 = New System.Windows.Forms.Label
    Me.comboBox1 = New System.Windows.Forms.ComboBox
    Me.panel1.SuspendLayout()
    Me.chartContainer.SuspendLayout()
    Me.SuspendLayout()
    ' 
    ' panel1
    ' 
    Me.panel1.Controls.Add(Me.comboBox1)
    Me.panel1.Controls.Add(Me.label1)
    Me.panel1.Size = New System.Drawing.Size(440, 55)
    ' 
    ' tChart1
    ' 
    ' 
    ' 
    ' 
    Me.tChart1.Aspect.ColorPaletteIndex = 0
    Me.tChart1.Aspect.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
    Me.tChart1.Aspect.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias
    Me.tChart1.Aspect.View3D = False
    ' 
    ' 
    ' 
    Me.tChart1.Header.Visible = False
    ' 
    ' 
    ' 
    ' 
    ' 
    ' 
    ' 
    ' 
    ' 
    Me.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(89, Byte), Integer))
    Me.tChart1.Panel.Brush.Gradient.ExtendedColorPalette = Nothing
    Me.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.tChart1.Panel.Brush.Gradient.Sigma = True
    Me.tChart1.Panel.Brush.Gradient.SigmaFocus = 1.0F
    Me.tChart1.Panel.Brush.Gradient.SigmaScale = 0.800000012F
    Me.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.tChart1.Panel.Brush.Gradient.UseMiddle = True
    Me.tChart1.Panel.Brush.Gradient.Visible = True
    Me.tChart1.Series.Add(Me.area1)
    Me.tChart1.Size = New System.Drawing.Size(440, 189)
    ' 
    ' 
    ' 
    ' 
    ' 
    ' 
    ' 
    ' 
    ' 
    ' 
    ' 
    ' 
    Me.tChart1.Walls.Back.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.tChart1.Walls.Back.Brush.Gradient.ExtendedColorPalette = Nothing
    Me.tChart1.Walls.Back.Brush.Gradient.MiddleColor = System.Drawing.Color.Empty
    Me.tChart1.Walls.Back.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer))
    Me.tChart1.Walls.Back.Brush.Gradient.Visible = True
    Me.tChart1.Walls.Back.Brush.Visible = True
    Me.tChart1.Walls.Back.Transparent = False
    ' 
    ' chartContainer
    ' 
    Me.chartContainer.Location = New System.Drawing.Point(0, 128)
    Me.chartContainer.Size = New System.Drawing.Size(440, 189)
    ' 
    ' area1
    ' 
    ' 
    ' 
    ' 
    Me.area1.AreaBrush.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
    ' 
    ' 
    ' 
    Me.area1.AreaLines.Color = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
    ' 
    ' 
    ' 
    Me.area1.Brush.Color = System.Drawing.Color.Red
    Me.area1.ColorEach = False
    Me.area1.DefaultNullValue = 0
    ' 
    ' 
    ' 
    Me.area1.Gradient.ExtendedColorPalette = Nothing
    Me.area1.Gradient.StartColor = System.Drawing.Color.Red
    ' 
    ' 
    ' 
    Me.area1.LinePen.Color = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
    ' 
    ' 
    ' 
    ' 
    ' 
    ' 
    Me.area1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None
    Me.area1.Marks.Callout.ArrowHeadSize = 8
    ' 
    ' 
    ' 
    Me.area1.Marks.Callout.Brush.Color = System.Drawing.Color.Black
    Me.area1.Marks.Callout.Distance = 0
    Me.area1.Marks.Callout.Draw3D = False
    Me.area1.Marks.Callout.Length = 10
    Me.area1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
    ' 
    ' 
    ' 
    Me.area1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
    Me.area1.Title = "area1"
    ' 
    ' 
    ' 
    Me.area1.TopGradient.ExtendedColorPalette = Nothing
    Me.area1.TopGradient.StartColor = System.Drawing.Color.Red
    ' 
    ' 
    ' 
    Me.area1.XValues.DataMember = "X"
    Me.area1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
    ' 
    ' 
    ' 
    Me.area1.YValues.DataMember = "Y"
    ' 
    ' label1
    ' 
    Me.label1.AutoSize = True
    Me.label1.Location = New System.Drawing.Point(12, 22)
    Me.label1.Name = "label1"
    Me.label1.Size = New System.Drawing.Size(56, 13)
    Me.label1.TabIndex = 1
    Me.label1.Text = "Treat nulls"
    ' 
    ' comboBox1
    ' 
#If VS2005 Then
        Me.comboBox1.FormattingEnabled = True
#End If
    Me.comboBox1.Items.AddRange(New Object() { _
    "Don't paint", _
    "Skip", _
    "As value"})
    Me.comboBox1.Location = New System.Drawing.Point(74, 19)
    Me.comboBox1.Name = "comboBox1"
    Me.comboBox1.Size = New System.Drawing.Size(101, 21)
    Me.comboBox1.TabIndex = 2
    ' 
    ' Area_TreatNulls
    ' 
    Me.ClientSize = New System.Drawing.Size(440, 317)
    Me.Name = "Area_TreatNulls"
    Me.panel1.ResumeLayout(False)
    Me.panel1.PerformLayout()
    Me.chartContainer.ResumeLayout(False)
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

#End Region



End Class

