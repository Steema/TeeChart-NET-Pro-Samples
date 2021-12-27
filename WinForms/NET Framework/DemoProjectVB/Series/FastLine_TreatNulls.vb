
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing

Imports System.Windows.Forms



Public Class FastLine_TreatNulls
    Inherits Samples.BaseForm

    Private fastLine1 As Steema.TeeChart.Styles.FastLine
    Private groupBox1 As GroupBox
    Private WithEvents radioButton3 As RadioButton
    Private WithEvents radioButton2 As RadioButton
    Private WithEvents radioButton1 As RadioButton

    '/ <summary>
    '/ Required designer variable.
    '/ </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    Private Sub FillSeries()
        Dim done As Boolean = False
        Dim y As Double
        For x As Integer = 0 To 100
            If (x Mod 2 = 0) Then
                y = 10
            Else
                y = 20
            End If
            If (x >= 30) AndAlso (x <= 70) Then
                If Not done Then
                    fastLine1.Add(x, 0, Color.Transparent)
                End If
                done = True
            Else
                fastLine1.Add(x, y)
            End If
        Next x
    End Sub


    Public Sub New() ' me call is required by the Windows Form Designer.
        InitializeComponent()
        fastLine1.TreatNulls = Styles.TreatNullsStyle.DoNotPaint
        fastLine1.TreatNulls = Steema.TeeChart.Styles.TreatNullsStyle.DoNotPaint
        FillSeries()
        fastLine1.GetVertAxis.SetMinMax(-10, 30)
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FastLine_TreatNulls))
        Me.fastLine1 = New Steema.TeeChart.Styles.FastLine()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.radioButton3 = New System.Windows.Forms.RadioButton()
        Me.radioButton2 = New System.Windows.Forms.RadioButton()
        Me.radioButton1 = New System.Windows.Forms.RadioButton()
        Me.panel1.SuspendLayout()
        Me.chartContainer.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Text = resources.GetString("textBox1.Text")
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.groupBox1)
        Me.panel1.Size = New System.Drawing.Size(440, 64)
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
        Me.tChart1.Header.Lines = New String() { _
        "FastLine : null points support"}
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
        Me.tChart1.Panel.Brush.Gradient.SigmaFocus = 1.0!
        Me.tChart1.Panel.Brush.Gradient.SigmaScale = 0.8!
        Me.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tChart1.Panel.Brush.Gradient.UseMiddle = True
        Me.tChart1.Panel.Brush.Gradient.Visible = True
        Me.tChart1.Series.Add(Me.fastLine1)
        Me.tChart1.Size = New System.Drawing.Size(440, 180)
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
        ' chartContainer
        ' 
        Me.chartContainer.Location = New System.Drawing.Point(0, 137)
        Me.chartContainer.Size = New System.Drawing.Size(440, 180)
        ' 
        ' fastLine1
        ' 
        Me.fastLine1.ColorEach = False
        Me.fastLine1.DefaultNullValue = 0
        ' 
        ' 
        ' 
        Me.fastLine1.LinePen.Color = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(44, Byte), Integer))
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.fastLine1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None
        Me.fastLine1.Marks.Callout.ArrowHeadSize = 8
        ' 
        ' 
        ' 
        Me.fastLine1.Marks.Callout.Brush.Color = System.Drawing.Color.Black
        Me.fastLine1.Marks.Callout.Distance = 0
        Me.fastLine1.Marks.Callout.Draw3D = False
        Me.fastLine1.Marks.Callout.Length = 10
        Me.fastLine1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        ' 
        ' 
        ' 
        Me.fastLine1.Title = "fastLine1"
        Me.fastLine1.TreatNulls = Steema.TeeChart.Styles.TreatNullsStyle.Ignore
        ' 
        ' 
        ' 
        Me.fastLine1.XValues.DataMember = "X"
        Me.fastLine1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' 
        ' 
        Me.fastLine1.YValues.DataMember = "Y"
        ' 
        ' groupBox1
        ' 
        Me.groupBox1.Controls.Add(Me.radioButton3)
        Me.groupBox1.Controls.Add(Me.radioButton2)
        Me.groupBox1.Controls.Add(Me.radioButton1)
        Me.groupBox1.Location = New System.Drawing.Point(12, 6)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(223, 48)
        Me.groupBox1.TabIndex = 1
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Treat nulls"
        ' 
        ' radioButton3
        ' 
        Me.radioButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.radioButton3.Location = New System.Drawing.Point(151, 19)
        Me.radioButton3.Name = "radioButton3"
        Me.radioButton3.Size = New System.Drawing.Size(54, 17)
        Me.radioButton3.TabIndex = 2
        Me.radioButton3.Text = "Ignore"
#If VS2005 Then
            me.radioButton3.UseVisualStyleBackColor = true
            me.radioButton3.AutoSize = true
#End If

        ' 
        ' radioButton2
        ' 
        Me.radioButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.radioButton2.Location = New System.Drawing.Point(88, 19)
        Me.radioButton2.Name = "radioButton2"
        Me.radioButton2.Size = New System.Drawing.Size(45, 17)
        Me.radioButton2.TabIndex = 1
        Me.radioButton2.Text = "Skip"
#If VS2005 Then
            me.radioButton2.UseVisualStyleBackColor = true
            me.radioButton2.AutoSize = true
#End If
        ' 
        ' radioButton1
        ' 
#If VS2005 Then
            me.radioButton1.AutoSize = true
            me.radioButton1.UseVisualStyleBackColor = true
#End If
        Me.radioButton1.Checked = True
        Me.radioButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.radioButton1.Location = New System.Drawing.Point(6, 19)
        Me.radioButton1.Name = "radioButton1"
        Me.radioButton1.Size = New System.Drawing.Size(75, 17)
        Me.radioButton1.TabIndex = 0
        Me.radioButton1.TabStop = True
        Me.radioButton1.Text = "Don't paint"
        ' 
        ' FastLine_TreatNulls
        ' 
        Me.ClientSize = New System.Drawing.Size(440, 317)
        Me.Name = "FastLine_TreatNulls"
        Me.panel1.ResumeLayout(False)
        Me.chartContainer.ResumeLayout(False)
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub radioButton1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radioButton1.CheckedChanged, radioButton2.CheckedChanged, radioButton3.CheckedChanged

        If (radioButton1.Checked) Then
            fastLine1.TreatNulls = Steema.TeeChart.Styles.TreatNullsStyle.DoNotPaint
        ElseIf (radioButton2.Checked) Then
            fastLine1.TreatNulls = Steema.TeeChart.Styles.TreatNullsStyle.Skip
        Else
            fastLine1.TreatNulls = Steema.TeeChart.Styles.TreatNullsStyle.Ignore
        End If
    End Sub

End Class

