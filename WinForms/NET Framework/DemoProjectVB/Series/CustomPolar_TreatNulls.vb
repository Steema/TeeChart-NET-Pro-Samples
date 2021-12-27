
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing

Imports System.Windows.Forms



Public Class CustomPolar_TreatNulls
    Inherits Samples.BaseForm

    '/ <summary>
    '/ Required designer variable.
    '/ </summary>
    Private components As System.ComponentModel.IContainer = Nothing


    Public Sub New() ' me call is required by the Windows Form Designer.
        InitializeComponent()
        tChart1(0).FillSampleValues(10)
        tChart1(0).SetNull(5, checkBox1.Checked)
    End Sub

    Private polar1 As Steema.TeeChart.Styles.Polar
    Private WithEvents comboBox1 As ComboBox
    Private label1 As Label
    Private label2 As Label
    Private WithEvents comboBox2 As ComboBox
    Private WithEvents checkBox2 As CheckBox
    Private WithEvents checkBox1 As CheckBox


  Private Sub CustomPolar_TreatNulls_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
    comboBox1.SelectedIndex = 0
    comboBox2.SelectedIndex = 2 ' ignore
  End Sub

  Private Sub comboBox2_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox2.SelectedIndexChanged
    CType(tChart1(0), Styles.CustomPolar).TreatNulls = CType(comboBox2.SelectedIndex, Styles.TreatNullsStyle)
  End Sub

  Private Sub checkBox2_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox2.CheckedChanged
    CType(tChart1(0), Styles.CustomPolar).Brush.Visible = checkBox2.Checked
  End Sub

  Private Sub comboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox1.SelectedIndexChanged
    Dim s As Styles.Series = tChart1(0)
    Select Case (comboBox1.SelectedIndex)
      Case 1
        Styles.Series.ChangeType(s, GetType(Styles.PolarBar))
        Exit Select
      Case 2
        Styles.Series.ChangeType(s, GetType(Styles.Radar))
        Exit Select
      Case 3
        Styles.Series.ChangeType(s, GetType(Styles.WindRose))
        Exit Select
      Case Else
        Styles.Series.ChangeType(s, GetType(Styles.Polar))
        Exit Select
    End Select
  End Sub

  Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox1.CheckedChanged
    tChart1(0).SetNull(5, checkBox1.Checked)
    tChart1(0).Repaint()
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CustomPolar_TreatNulls))
    Me.polar1 = New Steema.TeeChart.Styles.Polar
    Me.label1 = New System.Windows.Forms.Label
    Me.comboBox1 = New System.Windows.Forms.ComboBox
    Me.label2 = New System.Windows.Forms.Label
    Me.comboBox2 = New System.Windows.Forms.ComboBox
    Me.checkBox1 = New System.Windows.Forms.CheckBox
    Me.checkBox2 = New System.Windows.Forms.CheckBox
    Me.panel1.SuspendLayout()
    Me.chartContainer.SuspendLayout()
    Me.SuspendLayout()
    ' 
    ' textBox1
    ' 
    Me.textBox1.Text = "All series derived from CustomPolar series now support null points. me includes" + _
            " Polar, Polar Bar, Radar and Windrose series."
    ' 
    ' panel1
    ' 
    Me.panel1.Controls.Add(Me.checkBox2)
    Me.panel1.Controls.Add(Me.checkBox1)
    Me.panel1.Controls.Add(Me.comboBox2)
    Me.panel1.Controls.Add(Me.label2)
    Me.panel1.Controls.Add(Me.comboBox1)
    Me.panel1.Controls.Add(Me.label1)
    Me.panel1.Size = New System.Drawing.Size(440, 61)
    ' 
    ' tChart1
    ' 
    ' 
    ' 
    ' 
    Me.tChart1.Aspect.ColorPaletteIndex = 0
    Me.tChart1.Aspect.Elevation = 315
    Me.tChart1.Aspect.ElevationFloat = 315
    Me.tChart1.Aspect.Orthogonal = False
    Me.tChart1.Aspect.Perspective = 0
    Me.tChart1.Aspect.Rotation = 360
    Me.tChart1.Aspect.RotationFloat = 360
    Me.tChart1.Aspect.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
    Me.tChart1.Aspect.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias
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
    Me.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(89, Byte), Integer))
    Me.tChart1.Panel.Brush.Gradient.ExtendedColorPalette = Nothing
    Me.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.tChart1.Panel.Brush.Gradient.Sigma = True
    Me.tChart1.Panel.Brush.Gradient.SigmaFocus = 1.0F
    Me.tChart1.Panel.Brush.Gradient.SigmaScale = 0.800000012F
    Me.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.tChart1.Panel.Brush.Gradient.UseMiddle = True
    Me.tChart1.Panel.Brush.Gradient.Visible = True
    Me.tChart1.Series.Add(Me.polar1)
    Me.tChart1.Size = New System.Drawing.Size(440, 183)
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
    Me.chartContainer.Location = New System.Drawing.Point(0, 134)
    Me.chartContainer.Size = New System.Drawing.Size(440, 183)
    ' 
    ' polar1
    ' 
    ' 
    ' 
    ' 
    Me.polar1.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
    Me.polar1.CircleBackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
    ' 
    ' 
    ' 
    Me.polar1.CircleGradient.ExtendedColorPalette = Nothing
    Me.polar1.CircleGradient.Visible = True
    Me.polar1.ColorEach = False
    Me.polar1.DefaultNullValue = 0
    ' 
    ' 
    ' 
    ' 
    ' 
    ' 
    Me.polar1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None
    Me.polar1.Marks.Callout.ArrowHeadSize = 8
    ' 
    ' 
    ' 
    Me.polar1.Marks.Callout.Brush.Color = System.Drawing.Color.Black
    Me.polar1.Marks.Callout.Distance = 0
    Me.polar1.Marks.Callout.Draw3D = False
    Me.polar1.Marks.Callout.Length = 10
    Me.polar1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
    ' 
    ' 
    ' 
    Me.polar1.Pen.Color = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
    ' 
    ' 
    ' 
    Me.polar1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
    Me.polar1.Pointer.Visible = True
    Me.polar1.Title = "polar1"
    ' 
    ' 
    ' 
    Me.polar1.XValues.DataMember = "Angle"
    Me.polar1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
    ' 
    ' 
    ' 
    Me.polar1.YValues.DataMember = "Y"
    ' 
    ' label1
    ' 
    Me.label1.AutoSize = True
    Me.label1.Location = New System.Drawing.Point(12, 19)
    Me.label1.Name = "label1"
    Me.label1.Size = New System.Drawing.Size(30, 13)
    Me.label1.TabIndex = 0
    Me.label1.Text = "Style"
    ' 
    ' comboBox1
    ' 
#If VS2005 Then
        Me.comboBox1.FormattingEnabled = True
#End If
    Me.comboBox1.Items.AddRange(New Object() { _
    "Polar", _
    "Polar Bar", _
    "Radar", _
    "Windrose"})
    Me.comboBox1.Location = New System.Drawing.Point(48, 16)
    Me.comboBox1.Name = "comboBox1"
    Me.comboBox1.Size = New System.Drawing.Size(97, 21)
    Me.comboBox1.TabIndex = 1
    ' 
    ' label2
    ' 
    Me.label2.AutoSize = True
    Me.label2.Location = New System.Drawing.Point(168, 19)
    Me.label2.Name = "label2"
    Me.label2.Size = New System.Drawing.Size(56, 13)
    Me.label2.TabIndex = 2
    Me.label2.Text = "Treat nulls"
    ' 
    ' comboBox2
    ' 
#If VS2005 Then
        Me.comboBox2.FormattingEnabled = True
#End If
    Me.comboBox2.Items.AddRange(New Object() { _
    "Don't paint", _
    "Skip", _
    "Ignore"})
    Me.comboBox2.Location = New System.Drawing.Point(230, 16)
    Me.comboBox2.Name = "comboBox2"
    Me.comboBox2.Size = New System.Drawing.Size(97, 21)
    Me.comboBox2.TabIndex = 3
    ' 
    ' checkBox1
    ' 
#If VS2005 Then
        Me.checkBox1.AutoSize = True
        Me.checkBox1.UseVisualStyleBackColor = True
#End If
    Me.checkBox1.Checked = True
    Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
    Me.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.checkBox1.Location = New System.Drawing.Point(343, 15)
    Me.checkBox1.Name = "checkBox1"
    Me.checkBox1.Size = New System.Drawing.Size(85, 17)
    Me.checkBox1.TabIndex = 4
    Me.checkBox1.Text = "Point 5 is null"
    ' 
    ' checkBox2
    ' 
#If VS2005 Then
        Me.checkBox2.AutoSize = True
        Me.checkBox2.UseVisualStyleBackColor = True
#End If
    Me.checkBox2.Checked = True
    Me.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked
    Me.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.checkBox2.Location = New System.Drawing.Point(343, 37)
    Me.checkBox2.Name = "checkBox2"
    Me.checkBox2.Size = New System.Drawing.Size(47, 17)
    Me.checkBox2.TabIndex = 5
    Me.checkBox2.Text = "Filled"
    ' 
    ' CustomPolar_TreatNulls
    ' 
    Me.ClientSize = New System.Drawing.Size(440, 317)
    Me.Name = "CustomPolar_TreatNulls"
    Me.panel1.ResumeLayout(False)
    Me.panel1.PerformLayout()
    Me.chartContainer.ResumeLayout(False)
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

#End Region



End Class

