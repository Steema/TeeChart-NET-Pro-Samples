
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing

Imports System.Windows.Forms



Public Class Marks_NewStyles
    Inherits Samples.BaseForm

    '/ <summary>
    '/ Required designer variable.
    '/ </summary>
    Private components As System.ComponentModel.IContainer = Nothing


    Public Sub New() ' me call is required by the Windows Form Designer.
        InitializeComponent()
        bar1.FillSampleValues(6)
    End Sub

    Private WithEvents comboBox1 As ComboBox
    Private label1 As Label
    Private bar1 As Steema.TeeChart.Styles.Bar

    Private Sub comboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox1.SelectedIndexChanged
        bar1.Marks.Style = CType(comboBox1.SelectedIndex, Steema.TeeChart.Styles.MarksStyles)
    End Sub

  Private Sub Marks_NewStyles_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
    comboBox1.SelectedIndex = CInt(bar1.Marks.Style)
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Marks_NewStyles))
    Me.bar1 = New Steema.TeeChart.Styles.Bar
    Me.label1 = New System.Windows.Forms.Label
    Me.comboBox1 = New System.Windows.Forms.ComboBox
    Me.panel1.SuspendLayout()
    Me.chartContainer.SuspendLayout()
    Me.SuspendLayout()
    ' 
    ' textBox1
    ' 
    Me.textBox1.Text = "New Marks styles : " & vbCrLf + " Series Title" + vbCrLf + "  Point Index" + vbCrLf + "  Percent Relative"
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
    Me.tChart1.Aspect.Chart3DPercent = 100
    Me.tChart1.Aspect.ColorPaletteIndex = 0
    Me.tChart1.Aspect.Elevation = 322
    Me.tChart1.Aspect.ElevationFloat = 322
    Me.tChart1.Aspect.Orthogonal = False
    Me.tChart1.Aspect.Perspective = 100
    Me.tChart1.Aspect.Rotation = 324
    Me.tChart1.Aspect.RotationFloat = 324
    Me.tChart1.Aspect.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
    Me.tChart1.Aspect.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias
    Me.tChart1.Aspect.Zoom = 79
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
    ' 
    ' 
    ' 
    ' 
    ' 
    ' 
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
    Me.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(89, Byte), Integer))
    Me.tChart1.Panel.Brush.Gradient.ExtendedColorPalette = Nothing
    Me.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.tChart1.Panel.Brush.Gradient.Sigma = True
    Me.tChart1.Panel.Brush.Gradient.SigmaFocus = 1.0F
    Me.tChart1.Panel.Brush.Gradient.SigmaScale = 0.800000012F
    Me.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.tChart1.Panel.Brush.Gradient.UseMiddle = True
    Me.tChart1.Panel.Brush.Gradient.Visible = True
    Me.tChart1.Series.Add(Me.bar1)
    Me.tChart1.Size = New System.Drawing.Size(440, 205)
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
    ' 
    ' bar1
    ' 
    Me.bar1.BarStyle = Steema.TeeChart.Styles.BarStyles.Cylinder
    Me.bar1.Gradient.Visible = True
    ' 
    ' 
    ' 
    ' 
    ' 
    ' 
    Me.bar1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None
    Me.bar1.Marks.Callout.ArrowHeadSize = 8
    ' 
    ' 
    ' 
    Me.bar1.Marks.Callout.Brush.Color = System.Drawing.Color.Black
    Me.bar1.Marks.Callout.Distance = 0
    Me.bar1.Marks.Callout.Draw3D = False
    Me.bar1.Marks.Callout.Length = 20
    Me.bar1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
    ' 
    ' 
    ' 
    Me.bar1.Marks.Style = Steema.TeeChart.Styles.MarksStyles.PercentRelative
    Me.bar1.Title = "bar1"
    ' 
    ' 
    ' 
    Me.bar1.XValues.DataMember = "X"
    Me.bar1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
    ' 
    ' 
    ' 
    Me.bar1.YValues.DataMember = "Bar"
    ' 
    ' label1
    ' 
    Me.label1.AutoSize = True
    Me.label1.Location = New System.Drawing.Point(12, 14)
    Me.label1.Name = "label1"
    Me.label1.Size = New System.Drawing.Size(55, 13)
    Me.label1.TabIndex = 0
    Me.label1.Text = "Mark style"
    ' 
    ' comboBox1
    '
#If VS2005 Then
        Me.comboBox1.FormattingEnabled = True
#End If
    Me.comboBox1.Items.AddRange(New Object() { _
        "Value", _
        "Percent", _
        "Label", _
        "Label and Percent", _
        "Label and Value", _
        "Legend", _
        "Percent Total", _
        "Label and Percent Total", _
        "X value", _
        "X and Y values", _
        "Series Title", _
        "Point Index", _
        "Percent relative"})
    Me.comboBox1.Location = New System.Drawing.Point(73, 11)
    Me.comboBox1.Name = "comboBox1"
    Me.comboBox1.Size = New System.Drawing.Size(121, 21)
    Me.comboBox1.TabIndex = 1
    ' 
    ' Marks_NewStyles
    ' 
    Me.ClientSize = New System.Drawing.Size(440, 317)
    Me.Name = "Marks_NewStyles"
    Me.panel1.ResumeLayout(False)
    Me.panel1.PerformLayout()
    Me.chartContainer.ResumeLayout(False)
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

#End Region



End Class

