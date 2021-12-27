Imports System
#If (VS2005) Then
Imports System.Collections.Generic
#End If
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Public Class Legend_Items
    Inherits BaseForm
    Private WithEvents textBox2 As TextBox
    Private WithEvents numericUpDown1 As NumericUpDown
    Private label1 As Label
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

    '/// <summary>
    '/// Required method for Designer support - do not modify
    '/// the contents of this method with the code editor.
    '/// </summary>
    Private Sub InitializeComponent()
        Me.label1 = New System.Windows.Forms.Label
        Me.numericUpDown1 = New System.Windows.Forms.NumericUpDown
        Me.textBox2 = New System.Windows.Forms.TextBox
        Me.panel1.SuspendLayout()
        Me.chartContainer.SuspendLayout()
        CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Text = ("Chart Legend stores all values in a Items[]  array property." & vbCrLf & vbCrLf & "tChart1.Legend.It" & "em[5].Text = \""Hello\"";")
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.textBox2)
        Me.panel1.Controls.Add(Me.numericUpDown1)
        Me.panel1.Controls.Add(Me.label1)
        ' 
        ' tChart1
        ' 
        Me.TChart1.Legend.Title.Pen.Visible = False
        Me.TChart1.Size = New System.Drawing.Size(440, 205)
        ' 
        ' label1
        ' 
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(12, 14)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(69, 13)
        Me.label1.TabIndex = 0
        Me.label1.Text = "&Legend Item:"
        ' 
        ' numericUpDown1
        ' 
        Me.numericUpDown1.Location = New System.Drawing.Point(87, 12)
        Me.numericUpDown1.Name = "numericUpDown1"
        Me.numericUpDown1.Size = New System.Drawing.Size(51, 20)
        Me.numericUpDown1.TabIndex = 1
        AddHandler numericUpDown1.Click, AddressOf Me.numericUpDown1_Click
        ' 
        ' textBox2
        ' 
        Me.textBox2.Location = New System.Drawing.Point(162, 11)
        Me.textBox2.Name = "textBox2"
        Me.textBox2.Size = New System.Drawing.Size(100, 20)
        Me.textBox2.TabIndex = 2
        AddHandler textBox2.TextChanged, AddressOf Me.textBox2_TextChanged
        ' 
        ' Legend_Items
        ' 
#If (VS2005) Then
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
#End If
        Me.ClientSize = New System.Drawing.Size(440, 317)
        Me.Name = "Legend_Items"
        Me.Text = "Legend_Items"
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.chartContainer.ResumeLayout(False)
        CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub
#End Region
    Public Sub New()
        InitializeComponent()
        InitializeChart()
    End Sub
    Private pie As Steema.TeeChart.Styles.Pie
    Private Sub InitializeChart()
        pie = New Steema.TeeChart.Styles.Pie()
        TChart1.Series.Add(pie)
        pie.FillSampleValues()
        TChart1.Legend.TextStyle = LegendTextStyles.Value
        TChart1.Legend.ColumnWidthAuto = False
        TChart1.Legend.ColumnWidths(0) = 100
        ' Force re-draw to make tChart1 recalculate all Legend Items[]
        TChart1.Draw()
        numericUpDown1.Maximum = (pie.Count - 1)
        numericUpDown1_Click(Me, EventArgs.Empty)
    End Sub

    Private Sub textBox2_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
        TChart1.Legend.Items(CType(numericUpDown1.Value, Integer)).Text = textBox2.Text
    End Sub
    Private Sub numericUpDown1_Click(ByVal sender As Object, ByVal e As EventArgs)
        textBox2.Text = TChart1.Legend.Items(CType(numericUpDown1.Value, Integer)).Text
    End Sub
End Class