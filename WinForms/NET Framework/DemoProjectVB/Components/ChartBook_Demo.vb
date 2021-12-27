Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Steema.TeeChart.Styles
Public Class ChartBook_Demo
    Inherits BaseNoChart
    Private WithEvents checkBox1 As CheckBox
    Private WithEvents comboBox1 As ComboBox
    Private label1 As Label
    Private WithEvents button2 As Button
    Private WithEvents button1 As Button
    '/<summary>
    '/ Required designer variable.
    '/ </summary>
    Private components As System.ComponentModel.IContainer = Nothing
    '/ Clean up any resources being used.
    '/ </summary>
    '/ <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub 'Dispose

#Region "Designer generated code"
    '/<summary>
    '/ Required method for Designer support - do not modify
    '/the contents of this method with the code editor.
    ' /</summary>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ChartBook_Demo))
        Me.label1 = New System.Windows.Forms.Label
        Me.comboBox1 = New System.Windows.Forms.ComboBox
        Me.checkBox1 = New System.Windows.Forms.CheckBox
        Me.button1 = New System.Windows.Forms.Button
        Me.button2 = New System.Windows.Forms.Button
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'textBox1
        '
        Me.textBox1.Text = resources.GetString("textBox1.Text")
        '
        'panel1
        '
        Me.panel1.Controls.Add(Me.button2)
        Me.panel1.Controls.Add(Me.button1)
        Me.panel1.Controls.Add(Me.checkBox1)
        Me.panel1.Controls.Add(Me.comboBox1)
        Me.panel1.Controls.Add(Me.label1)
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(12, 13)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(73, 13)
        Me.label1.TabIndex = 0
        Me.label1.Text = "&Tabs position:"
        '
        'comboBox1
        '
        Me.comboBox1.FormattingEnabled = True
        Me.comboBox1.Items.AddRange(New Object() {"Top", "Bottom", "Left", "Right"})
        Me.comboBox1.Location = New System.Drawing.Point(82, 10)
        Me.comboBox1.Name = "comboBox1"
        Me.comboBox1.Size = New System.Drawing.Size(76, 21)
        Me.comboBox1.TabIndex = 1
        Me.comboBox1.Text = "Left"
        '
        'checkBox1
        '
        Me.checkBox1.AutoSize = True
        Me.checkBox1.Checked = True
        Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox1.Location = New System.Drawing.Point(164, 13)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(88, 17)
        Me.checkBox1.TabIndex = 2
        Me.checkBox1.Text = "&Show toolbar"
        Me.checkBox1.UseVisualStyleBackColor = True
        '
        'button1
        '
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.Location = New System.Drawing.Point(258, 10)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(75, 23)
        Me.button1.TabIndex = 3
        Me.button1.Text = "&Add..."
        Me.button1.UseVisualStyleBackColor = True
        '
        'button2
        '
        Me.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button2.Location = New System.Drawing.Point(339, 10)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(75, 23)
        Me.button2.TabIndex = 4
        Me.button2.Text = "&Delete"
        Me.button2.UseVisualStyleBackColor = True
        '
        'ChartBook_Demo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(426, 258)
        Me.Name = "ChartBook_Demo"
        Me.Text = "ChartBook"
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
#End Region
    Public Sub New()
        InitializeComponent()
        InitializeChart()
    End Sub
    Private chartBook1 As ChartBook
    Private Sub InitializeChart()
        chartBook1 = New ChartBook
        chartBook1.Dock = DockStyle.Fill
        panel2.Controls.Add(chartBook1)
        chartBook1.ShowToolBar = True
        chartBook1.HotTrack = True
        chartBook1.AddChart.Series.Add(GetType(Line)).FillSampleValues()
        chartBook1.AddChart.Series.Add(GetType(Bar)).FillSampleValues()
        chartBook1.AddChart.Series.Add(GetType(Area)).FillSampleValues()
        chartBook1.AddChart.Series.Add(GetType(Pie)).FillSampleValues()
        chartBook1.Alignment = TabAlignment.Left
    End Sub
    Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
        Dim tmp As Series = chartBook1.AddChart.Series.Add(GetType(Line))
        tmp.FillSampleValues()
        tmp.Color = Themes.RandomTheme.RandomColor
        chartBook1.SelectedIndex = (chartBook1.TabCount - 1)
    End Sub
    Private Sub button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button2.Click
        chartBook1.TabPages.RemoveAt(chartBook1.SelectedIndex)
    End Sub
    Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox1.CheckedChanged
        If Not (chartBook1 Is Nothing) Then
            chartBook1.ShowToolBar = checkBox1.Checked
        End If
    End Sub
    Private Sub comboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox1.SelectedIndexChanged
        If Not (chartBook1 Is Nothing) Then
            chartBook1.Visible = False
            chartBook1.Alignment = CType(comboBox1.SelectedIndex, TabAlignment)
            chartBook1.Visible = True
        End If
    End Sub
End Class