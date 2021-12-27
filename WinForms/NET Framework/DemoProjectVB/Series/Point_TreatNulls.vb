Imports System
#If VS2005 Then
Imports System.Collections.Generic
#End If
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms



Public Class Point_TreatNulls
    Inherits Samples.BaseNoChart

    '/ <summary>
    '/ Required designer variable.
    '/ </summary>
    Private components As System.ComponentModel.IContainer = Nothing


    Public Sub New() ' me call is required by the Windows Form Designer.
        InitializeComponent()
        FillSeries()
        points1.GetVertAxis.SetMinMax(-10, 30)
    End Sub

    Private Sub FillSeries()
        Dim done As Boolean = False
        Dim y As Double
        For x As Integer = 0 To 5
            If (x Mod 2) = 0 Then
                y = 10
            Else
                y = 20
            End If
            If x = 3 Then
                If Not done Then
                    points1.Add(x, 0, Color.Transparent)
                End If
                done = True
            Else
                points1.Add(x, y)
            End If
        Next x
    End Sub

    Private tChart1 As TChart
    Private groupBox1 As GroupBox
    Private WithEvents radioButton3 As RadioButton
    Private WithEvents radioButton2 As RadioButton
    Private WithEvents radioButton1 As RadioButton
    Private points1 As Steema.TeeChart.Styles.Points
    Private WithEvents checkBox1 As CheckBox

    Private Sub radioButton1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radioButton1.CheckedChanged, radioButton2.CheckedChanged, radioButton3.CheckedChanged
        If (radioButton1.Checked) Then
            points1.TreatNulls = Steema.TeeChart.Styles.TreatNullsStyle.DoNotPaint
        ElseIf (radioButton2.Checked) Then
            points1.TreatNulls = Steema.TeeChart.Styles.TreatNullsStyle.Skip
        Else
            points1.TreatNulls = Steema.TeeChart.Styles.TreatNullsStyle.Ignore
        End If
    End Sub

    Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox1.CheckedChanged
        points1.GetVertAxis.Automatic = checkBox1.Checked
        If Not points1.GetVertAxis.Automatic Then
            points1.GetVertAxis.SetMinMax(-10, 30)
        End If
        tChart1.Refresh()
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Point_TreatNulls))
        Me.tChart1 = New Steema.TeeChart.TChart()
        Me.points1 = New Steema.TeeChart.Styles.Points()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.radioButton3 = New System.Windows.Forms.RadioButton()
        Me.radioButton2 = New System.Windows.Forms.RadioButton()
        Me.radioButton1 = New System.Windows.Forms.RadioButton()
        Me.checkBox1 = New System.Windows.Forms.CheckBox()
        Me.panel1.SuspendLayout()
        Me.panel2.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Text = "Point series has a new TreatNulls property."
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.checkBox1)
        Me.panel1.Controls.Add(Me.groupBox1)
        Me.panel1.Size = New System.Drawing.Size(426, 62)
        ' 
        ' panel2
        ' 
        Me.panel2.Controls.Add(Me.tChart1)
        Me.panel2.Location = New System.Drawing.Point(0, 124)
        Me.panel2.Size = New System.Drawing.Size(426, 134)
        ' 
        ' tChart1
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Aspect.ColorPaletteIndex = 0
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
        Me.tChart1.Dock = System.Windows.Forms.DockStyle.Fill
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
        Me.tChart1.Location = New System.Drawing.Point(0, 0)
        Me.tChart1.Name = "tChart1"
        Me.tChart1.Series.Add(Me.points1)
        Me.tChart1.Size = New System.Drawing.Size(426, 134)
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
        Me.tChart1.TabIndex = 0
        ' 
        ' points1
        ' 
        Me.points1.ColorEach = False
        ' 
        ' 
        ' 
        Me.points1.LinePen.Color = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
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
        ' 
        ' 
        ' 
        Me.points1.Pointer.Brush.Color = System.Drawing.Color.Red
        ' 
        ' 
        ' 
        Me.points1.Pointer.Pen.Color = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.points1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.points1.Pointer.Visible = True
        Me.points1.Title = "point1"
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
        ' groupBox1
        ' 
        Me.groupBox1.Controls.Add(Me.radioButton3)
        Me.groupBox1.Controls.Add(Me.radioButton2)
        Me.groupBox1.Controls.Add(Me.radioButton1)
        Me.groupBox1.Location = New System.Drawing.Point(12, 6)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(223, 48)
        Me.groupBox1.TabIndex = 0
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Treat nulls"
        ' 
        ' radioButton3
        ' 
#If VS2005 Then
        Me.radioButton3.AutoSize = True
#End If
        Me.radioButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.radioButton3.Location = New System.Drawing.Point(151, 19)
        Me.radioButton3.Name = "radioButton3"
        Me.radioButton3.Size = New System.Drawing.Size(54, 17)
        Me.radioButton3.TabIndex = 2
        Me.radioButton3.Text = "Ignore"
#If VS2005 Then
        Me.radioButton3.UseVisualStyleBackColor = True
#End If
        ' 
        ' radioButton2
        '
#If VS2005 Then
        Me.radioButton2.AutoSize = True
        Me.radioButton2.Name = "radioButton2"
        Me.radioButton2.UseVisualStyleBackColor = True
#End If
        Me.radioButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.radioButton2.Location = New System.Drawing.Point(88, 19)
        Me.radioButton2.Size = New System.Drawing.Size(45, 17)
        Me.radioButton2.TabIndex = 1
        Me.radioButton2.Text = "Skip"
        ' 
        ' radioButton1
        ' 
        Me.radioButton1.Checked = True
        Me.radioButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.radioButton1.Location = New System.Drawing.Point(6, 19)
        Me.radioButton1.Name = "radioButton1"
        Me.radioButton1.Size = New System.Drawing.Size(75, 17)
        Me.radioButton1.TabIndex = 0
        Me.radioButton1.TabStop = True
        Me.radioButton1.Text = "Don't paint"
#If VS2005 Then
        Me.radioButton1.UseVisualStyleBackColor = True
        Me.radioButton1.AutoSize = True
#End If
        ' 
        ' checkBox1
        ' 
        Me.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox1.Location = New System.Drawing.Point(253, 26)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(128, 17)
        Me.checkBox1.TabIndex = 1
        Me.checkBox1.Text = "Automatic vertical axis"
#If VS2005 Then
        Me.checkBox1.AutoSize = True
        Me.checkBox1.UseVisualStyleBackColor = True
#End If
        ' 
        ' Point_TreatNulls
        ' 
        Me.ClientSize = New System.Drawing.Size(426, 258)
        Me.Name = "Point_TreatNulls"
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.panel2.ResumeLayout(False)
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

#End Region



End Class

