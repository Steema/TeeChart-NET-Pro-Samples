Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Public Class Bar_MarksOnBar
    Inherits BaseForm
    Private cbLocation As System.Windows.Forms.ComboBox
    Private label2 As System.Windows.Forms.Label
    Private cbMarksOnBar As System.Windows.Forms.CheckBox
    Private cbStyle As System.Windows.Forms.ComboBox
    Private label1 As System.Windows.Forms.Label
    Private UDAngle As System.Windows.Forms.NumericUpDown
    Private label3 As System.Windows.Forms.Label
    Private UDFontSize As System.Windows.Forms.NumericUpDown
    Private label4 As System.Windows.Forms.Label
    '/ <summary>
    '/ Required designer variable.
    '/ </summary>
    Private components As System.ComponentModel.IContainer = Nothing
    '/<summary>
    '/Clean up any resources being used.
    '/</summary>
    '/<param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If (Not (components) Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub
#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Bar_MarksOnBar))
        Me.cbLocation = New System.Windows.Forms.ComboBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.cbMarksOnBar = New System.Windows.Forms.CheckBox()
        Me.cbStyle = New System.Windows.Forms.ComboBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.UDAngle = New System.Windows.Forms.NumericUpDown()
        Me.label3 = New System.Windows.Forms.Label()
        Me.UDFontSize = New System.Windows.Forms.NumericUpDown()
        Me.label4 = New System.Windows.Forms.Label()
        Me.panel1.SuspendLayout()
        Me.chartContainer.SuspendLayout()
        DirectCast((Me.UDAngle), System.ComponentModel.ISupportInitialize).BeginInit()
        DirectCast((Me.UDFontSize), System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Size = New System.Drawing.Size(624, 106)
        Me.textBox1.Text = resources.GetString("textBox1.Text")
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.UDFontSize)
        Me.panel1.Controls.Add(Me.label4)
        Me.panel1.Controls.Add(Me.UDAngle)
        Me.panel1.Controls.Add(Me.label3)
        Me.panel1.Controls.Add(Me.cbLocation)
        Me.panel1.Controls.Add(Me.label2)
        Me.panel1.Controls.Add(Me.cbMarksOnBar)
        Me.panel1.Controls.Add(Me.cbStyle)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Location = New System.Drawing.Point(0, 106)
        Me.panel1.Size = New System.Drawing.Size(624, 39)
        ' 
        ' tChart1
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Aspect.ZOffset = 0
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Bottom.Title.Transparent = True
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Depth.Title.Transparent = True
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.DepthTop.Title.Transparent = True
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Left.Title.Transparent = True
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Right.Title.Transparent = True
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Top.Title.Transparent = True
        Me.tChart1.Size = New System.Drawing.Size(624, 298)
        ' 
        ' chartContainer
        ' 
        Me.chartContainer.Location = New System.Drawing.Point(0, 145)
        Me.chartContainer.Size = New System.Drawing.Size(624, 298)
        ' 
        ' cbLocation
        ' 
        Me.cbLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
#If VS2005 Then
        Me.cbLocation.FormattingEnabled = True
#End If
        Me.cbLocation.Items.AddRange(New Object() {"start", "center", "end"})
        Me.cbLocation.Location = New System.Drawing.Point(319, 12)
        Me.cbLocation.Name = "cbLocation"
        Me.cbLocation.Size = New System.Drawing.Size(67, 21)
        Me.cbLocation.TabIndex = 10
        AddHandler Me.cbLocation.SelectedIndexChanged, AddressOf Me.cbLocation_SelectedIndexChanged
        ' 
        ' label2
        ' 
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(264, 15)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(54, 13)
        Me.label2.TabIndex = 9
        Me.label2.Text = "Location :"
        ' 
        ' cbMarksOnBar
        '
#If VS2005 Then
        Me.cbMarksOnBar.AutoSize = True
#End If
        Me.cbMarksOnBar.Checked = True
        Me.cbMarksOnBar.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbMarksOnBar.Location = New System.Drawing.Point(169, 14)
        Me.cbMarksOnBar.Name = "cbMarksOnBar"
        Me.cbMarksOnBar.Size = New System.Drawing.Size(89, 17)
        Me.cbMarksOnBar.TabIndex = 8
        Me.cbMarksOnBar.Text = "Marks on Bar"
#If VS2005 Then
        Me.cbMarksOnBar.AutoSize = True
        Me.cbMarksOnBar.UseVisualStyleBackColor = True
#End If
        AddHandler Me.cbMarksOnBar.CheckedChanged, AddressOf Me.cbMarksOnBar_CheckedChanged
        ' 
        ' cbStyle
        ' 
        Me.cbStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
#If VS2005 Then
        Me.cbStyle.FormattingEnabled = True
#End If
        Me.cbStyle.Items.AddRange(New Object() {"horizontal", "vertical"})
        Me.cbStyle.Location = New System.Drawing.Point(67, 12)
        Me.cbStyle.Name = "cbStyle"
        Me.cbStyle.Size = New System.Drawing.Size(89, 21)
        Me.cbStyle.TabIndex = 7
        AddHandler Me.cbStyle.SelectedIndexChanged, AddressOf Me.cbStyle_SelectedIndexChanged
        ' 
        ' label1
        ' 
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(11, 15)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(55, 13)
        Me.label1.TabIndex = 6
        Me.label1.Text = "Bar Style :"
        ' 
        ' UDAngle
        ' 
        Me.UDAngle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UDAngle.Increment = New Decimal(New Integer() {90, 0, 0, 0})
        Me.UDAngle.Location = New System.Drawing.Point(437, 13)
        Me.UDAngle.Maximum = New Decimal(New Integer() {360, 0, 0, 0})
        Me.UDAngle.Name = "UDAngle"
        Me.UDAngle.Size = New System.Drawing.Size(46, 20)
        Me.UDAngle.TabIndex = 12
        Me.UDAngle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        AddHandler Me.UDAngle.ValueChanged, AddressOf Me.UDAngle_ValueChanged
        ' 
        ' label3
        ' 
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(399, 15)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(37, 13)
        Me.label3.TabIndex = 11
        Me.label3.Text = "&Angle:"
        ' 
        ' UDFontSize
        ' 
        Me.UDFontSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UDFontSize.Location = New System.Drawing.Point(544, 13)
        Me.UDFontSize.Name = "UDFontSize"
        Me.UDFontSize.Size = New System.Drawing.Size(42, 20)
        Me.UDFontSize.TabIndex = 14
        Me.UDFontSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.UDFontSize.Value = New Decimal(New Integer() {8, 0, 0, 0})
        AddHandler Me.UDFontSize.ValueChanged, AddressOf Me.UDFontSize_ValueChanged
        ' 
        ' label4
        ' 
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(489, 15)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(54, 13)
        Me.label4.TabIndex = 13
        Me.label4.Text = "&Font Size:"
        ' 
        ' Bar_MarksOnBar
        ' 
        Me.ClientSize = New System.Drawing.Size(624, 443)
        Me.Name = "Bar_MarksOnBar"
        AddHandler Me.Load, AddressOf Me.Bar_MarksOnBar_Load
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.chartContainer.ResumeLayout(False)
        DirectCast((Me.UDAngle), System.ComponentModel.ISupportInitialize).EndInit()
        DirectCast((Me.UDFontSize), System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

        Me.PerformLayout()
    End Sub

#End Region

    Public Sub New()
        InitializeComponent()
    End Sub
    Private ser1 As Steema.TeeChart.Styles.HorizBar
    Private Sub Bar_MarksOnBar_Load(ByVal sender As Object, ByVal e As EventArgs)
        ser1 = New Steema.TeeChart.Styles.HorizBar()
        ser1.FillSampleValues(5)
        ser1.AutoMarkPosition = False
        ser1.Pen.Visible = False
        tChart1.Series.Add(ser1)
        tChart1.Aspect.View3D = False
        ser1.MarksOnBar = True
        cbStyle.SelectedIndex = 0
        cbLocation.SelectedIndex = 2
        ser1.Marks.Transparent = True
        Dim blackTheme As Steema.TeeChart.Themes.BlackIsBackTheme = New Steema.TeeChart.Themes.BlackIsBackTheme(tChart1.Chart)
        blackTheme.Apply()
        ser1.Marks.Font.Name = "Rage Italic"
        ser1.Marks.Font.Color = Color.Black
        UDFontSize.Value = 17
        ser1.BarStyle = Steema.TeeChart.Styles.BarStyles.RectGradient
        ser1.Gradient.StartColor = Color.FromArgb(230, 200, 90)
        ser1.Gradient.MiddleColor = Color.FromArgb(226, 242, 170)
        ser1.Gradient.EndColor = Color.FromArgb(230, 200, 90)
        ser1.Gradient.Visible = True
    End Sub
    Private Sub cbStyle_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
        Dim s As Steema.TeeChart.Styles.Series = tChart1(0)

        Select Case cbStyle.SelectedIndex
            Case 0
                Steema.TeeChart.Styles.Series.ChangeType(s, GetType(Steema.TeeChart.Styles.HorizBar))
                Exit Select
            Case 1
                Steema.TeeChart.Styles.Series.ChangeType(s, GetType(Steema.TeeChart.Styles.Bar))
                Exit Select
        End Select
        UpdateMarksLocation()
    End Sub

    Private Sub UpdateMarksLocation()
        TryCast(tChart1(0), Steema.TeeChart.Styles.CustomBar).MarksOnBar = cbMarksOnBar.Checked
        cbLocation_SelectedIndexChanged(Nothing, Nothing)
    End Sub

    Private Sub cbMarksOnBar_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
        TryCast(tChart1(0), Steema.TeeChart.Styles.CustomBar).MarksOnBar = cbMarksOnBar.Checked
        cbLocation.Enabled = cbMarksOnBar.Checked
        label2.Enabled = cbMarksOnBar.Enabled
    End Sub

    Private Sub cbLocation_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
        Select Case cbLocation.SelectedIndex
            Case 0
                TryCast(tChart1(0), Steema.TeeChart.Styles.CustomBar).MarksLocation = Steema.TeeChart.Styles.MarksLocation.Start
                Exit Select
            Case 1
                TryCast(tChart1(0), Steema.TeeChart.Styles.CustomBar).MarksLocation = Steema.TeeChart.Styles.MarksLocation.Center
                Exit Select
            Case 2
                TryCast(tChart1(0), Steema.TeeChart.Styles.CustomBar).MarksLocation = Steema.TeeChart.Styles.MarksLocation.[End]
                Exit Select
        End Select
    End Sub

    Private Sub UDAngle_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
        tChart1(0).Marks.Angle = CInt(UDAngle.Value)
    End Sub

    Private Sub UDFontSize_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
        tChart1(0).Marks.Font.Size = CInt(UDFontSize.Value)
    End Sub

End Class