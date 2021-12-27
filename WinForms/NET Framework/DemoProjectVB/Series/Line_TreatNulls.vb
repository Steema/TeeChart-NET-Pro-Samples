
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing

Imports System.Windows.Forms
Imports Steema.TeeChart.Styles


Public Class Line_TreatNulls
    Inherits Samples.BaseForm

    Private WithEvents comboBox1 As ComboBox
    Private label1 As Label
    Private groupBox1 As GroupBox
    Private WithEvents radioButton2 As RadioButton
    Private WithEvents radioButton1 As RadioButton

    '/ <summary>
    '/ Required designer variable.
    '/ </summary>
    Private components As System.ComponentModel.IContainer = Nothing


    Public Sub New() ' me call is required by the Windows Form Designer.
        InitializeComponent()
        tChart1(0).FillSampleValues(25)
        tChart1(0).SetNull(12)
        tChart1(0).YValues(12) = 0
        tChart1(0).SetNull(13)
        tChart1(0).YValues(13) = 0
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

        Me.line1 = New Steema.TeeChart.Styles.Line()
        Me.label1 = New System.Windows.Forms.Label()
        Me.comboBox1 = New System.Windows.Forms.ComboBox()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.radioButton2 = New System.Windows.Forms.RadioButton()
        Me.radioButton1 = New System.Windows.Forms.RadioButton()
        Me.panel1.SuspendLayout()
        Me.chartContainer.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Text = "Line and horizontal line now support null points. As with other series types, sev" + _
                "eral different null point drawing modes are supported."
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.groupBox1)
        Me.panel1.Controls.Add(Me.comboBox1)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Size = New System.Drawing.Size(440, 65)
        ' 
        ' tChart1
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Aspect.ColorPaletteIndex = 0
        Me.tChart1.Aspect.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Legend.Pen.Color = System.Drawing.Color.FromArgb((CType(((CType((153), Byte))), Integer)), (CType(((CType((0), Byte))), Integer)), (CType(((CType((0), Byte))), Integer)))
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb((CType(((CType((254), Byte))), Integer)), (CType(((CType((21), Byte))), Integer)), (CType(((CType((60), Byte))), Integer)), (CType(((CType((89), Byte))), Integer)))
        Me.tChart1.Panel.Brush.Gradient.ExtendedColorPalette = Nothing
        Me.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb((CType(((CType((254), Byte))), Integer)), (CType(((CType((255), Byte))), Integer)), (CType(((CType((255), Byte))), Integer)), (CType(((CType((255), Byte))), Integer)))
        Me.tChart1.Panel.Brush.Gradient.Sigma = True
        Me.tChart1.Panel.Brush.Gradient.SigmaFocus = 1.0F
        Me.tChart1.Panel.Brush.Gradient.SigmaScale = 0.8F
        Me.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb((CType(((CType((254), Byte))), Integer)), (CType(((CType((255), Byte))), Integer)), (CType(((CType((255), Byte))), Integer)), (CType(((CType((255), Byte))), Integer)))
        Me.tChart1.Panel.Brush.Gradient.UseMiddle = True
        Me.tChart1.Panel.Brush.Gradient.Visible = True
        Me.tChart1.Series.Add(Me.line1)
        Me.tChart1.Size = New System.Drawing.Size(440, 179)
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
        Me.tChart1.Walls.Back.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb((CType(((CType((255), Byte))), Integer)), (CType(((CType((255), Byte))), Integer)), (CType(((CType((255), Byte))), Integer)))
        Me.tChart1.Walls.Back.Brush.Gradient.ExtendedColorPalette = Nothing
        Me.tChart1.Walls.Back.Brush.Gradient.MiddleColor = System.Drawing.Color.Empty
        Me.tChart1.Walls.Back.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb((CType(((CType((234), Byte))), Integer)), (CType(((CType((234), Byte))), Integer)), (CType(((CType((234), Byte))), Integer)))

        Me.tChart1.Walls.Back.Brush.Gradient.Visible = True
        Me.tChart1.Walls.Back.Brush.Visible = True
        Me.tChart1.Walls.Back.Transparent = False
        ' 
        ' chartContainer
        ' 
        Me.chartContainer.Location = New System.Drawing.Point(0, 138)
        Me.chartContainer.Size = New System.Drawing.Size(440, 179)
        ' 
        ' line1
        ' 
        ' 
        ' 
        ' 
        Me.line1.Brush.Color = System.Drawing.Color.FromArgb((CType(((CType((255), Byte))), Integer)), (CType(((CType((128), Byte))), Integer)), (CType(((CType((255), Byte))), Integer)))
        ' 
        ' 
        ' 
        Me.line1.Gradient.Direction = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.line1.Gradient.EndColor = System.Drawing.Color.FromArgb((CType(((CType((255), Byte))), Integer)), (CType(((CType((255), Byte))), Integer)), (CType(((CType((0), Byte))), Integer)))
        Me.line1.Gradient.ExtendedColorPalette = Nothing
        Me.line1.Gradient.StartColor = System.Drawing.Color.FromArgb((CType(((CType((255), Byte))), Integer)), (CType(((CType((128), Byte))), Integer)), (CType(((CType((255), Byte))), Integer)))
        Me.line1.Gradient.Visible = True
        Me.line1.ColorEach = False
        Me.line1.ColorEachLine = False
        Me.line1.DefaultNullValue = 0
        ' 
        ' 
        ' 
        Me.line1.LinePen.Color = System.Drawing.Color.FromArgb((CType(((CType((153), Byte))), Integer)), (CType(((CType((77), Byte))), Integer)), (CType(((CType((153), Byte))), Integer)))
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
        Me.line1.Pointer.Visible = True
        Me.line1.Title = "line1"
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
        ' label1
        ' 
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(12, 19)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(56, 13)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Treat nulls"
        ' 
        ' comboBox1
        ' 
#If VS2005 Then
            me.comboBox1.FormattingEnabled = true
#End If
        Me.comboBox1.Items.AddRange(New Object() { _
        "Don't paint", _
        "Skip", _
        "As value"})
        Me.comboBox1.Location = New System.Drawing.Point(74, 16)
        Me.comboBox1.Name = "comboBox1"
        Me.comboBox1.Size = New System.Drawing.Size(101, 21)
        Me.comboBox1.TabIndex = 1
        ' 
        ' groupBox1
        ' 
        Me.groupBox1.Controls.Add(Me.radioButton2)
        Me.groupBox1.Controls.Add(Me.radioButton1)
        Me.groupBox1.Location = New System.Drawing.Point(215, 6)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(159, 46)
        Me.groupBox1.TabIndex = 2
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Style"
        ' 
        ' radioButton2
        ' 
#If VS2005 Then
            me.radioButton2.AutoSize = true
#End If
        Me.radioButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.radioButton2.Location = New System.Drawing.Point(56, 19)
        Me.radioButton2.Name = "radioButton2"
        Me.radioButton2.Size = New System.Drawing.Size(90, 17)
        Me.radioButton2.TabIndex = 1
        Me.radioButton2.Text = "Horizontal line"
#If VS2005 Then
            me.radioButton2.UseVisualStyleBackColor = true
#End If
        ' 
        ' radioButton1
        ' 
#If VS2005 Then
            me.radioButton1.AutoSize = true
#End If
        Me.radioButton1.Checked = True
        Me.radioButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.radioButton1.Location = New System.Drawing.Point(6, 19)
        Me.radioButton1.Name = "radioButton1"
        Me.radioButton1.Size = New System.Drawing.Size(44, 17)
        Me.radioButton1.TabIndex = 0
        Me.radioButton1.TabStop = True
        Me.radioButton1.Text = "Line"
#If VS2005 Then
            me.radioButton1.UseVisualStyleBackColor = true
#End If
        ' 
        ' Line_TreatNulls
        ' 
        Me.ClientSize = New System.Drawing.Size(440, 317)
        Me.Name = "Line_TreatNulls"
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.chartContainer.ResumeLayout(False)
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

#End Region

    Private line1 As Steema.TeeChart.Styles.Line

    Private Sub comboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox1.SelectedIndexChanged
        Select Case (comboBox1.SelectedIndex)
            Case 0
                CType(tChart1(0), Styles.CustomPoint).TreatNulls = Steema.TeeChart.Styles.TreatNullsStyle.DoNotPaint
                Exit Select
            Case 1
                CType(tChart1(0), Styles.CustomPoint).TreatNulls = Steema.TeeChart.Styles.TreatNullsStyle.Skip
                Exit Select
            Case Else
                CType(tChart1(0), Styles.CustomPoint).TreatNulls = Steema.TeeChart.Styles.TreatNullsStyle.Ignore
                Exit Select
        End Select
    End Sub

  Private Sub Line_TreatNulls_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
    comboBox1.SelectedIndex = 1
    CType(tChart1(0), Styles.CustomPoint).TreatNulls = Steema.TeeChart.Styles.TreatNullsStyle.Skip
  End Sub


  Private Sub radioButton1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radioButton2.CheckedChanged, radioButton1.CheckedChanged
    Dim s As Series = tChart1(0)
    If radioButton1.Checked Then
      Series.ChangeType(s, GetType(Line))
    Else
      Series.ChangeType(s, GetType(HorizLine))
    End If
  End Sub

End Class

