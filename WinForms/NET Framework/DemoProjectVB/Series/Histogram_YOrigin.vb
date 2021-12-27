
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Public Class Histogram_YOrigin
    Inherits BaseForm
    Private WithEvents cbUseYOrigin As CheckBox
    Private label1 As Label
    Private WithEvents numericUpDown1 As NumericUpDown
    Private WithEvents ser1 As Steema.TeeChart.Styles.Histogram
    '/ <summary>
    '/ Required designer variable.
    '/ </summary>
    Private components As System.ComponentModel.IContainer = Nothing
    '/<summary>
    '/Clean up any resources being used.
    '/</summary>
    '/<param name="disposing">true if managed resources should be disposed otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If (Not (components) Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
    End Sub
    Private Sub Histogram_YOrigin_Load(ByVal sender As Object, ByVal e As EventArgs)
        tChart1.Aspect.View3D = False
        ser1 = New Steema.TeeChart.Styles.Histogram
        tChart1.Series.Add(ser1)
        ser1.Add(0, 10)
        ser1.Add(1, 20)
        ser1.Add(2, -30)
        ser1.Add(3, -10)
        ser1.Add(4, 10)
        ser1.Add(5, 20)
        ser1.Add(6, 30)
        ser1.Add(7, 10)
        ser1.UseYOrigin = True
        ser1.YOrigin = 0
    End Sub
#Region "Windows Form Designer generated code"

    '/ <summary>
    '/ Required method for Designer support - do not modify
    '/ the contents of this method with the code editor.
    '/ </summary>
    Private Sub InitializeComponent()
        Me.cbUseYOrigin = New System.Windows.Forms.CheckBox
        Me.numericUpDown1 = New System.Windows.Forms.NumericUpDown
        Me.label1 = New System.Windows.Forms.Label
        Me.panel1.SuspendLayout()
        Me.chartContainer.SuspendLayout()
        CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Text = ("Histogram Series now allows to specify an YOrigin. " & vbCrLf & "Example :" & vbCrLf & "  histoSeries.Use" & "YOrigin = True" & vbCrLf & "  histoSeries.YOrigin = 0")
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Controls.Add(Me.numericUpDown1)
        Me.panel1.Controls.Add(Me.cbUseYOrigin)
        ' 
        ' tChart1
        ' 
        Me.tChart1.Aspect.ZOffset = 0
        Me.tChart1.Axes.Bottom.Title.Transparent = True
        Me.tChart1.Axes.Depth.Title.Transparent = True
        Me.tChart1.Axes.DepthTop.Title.Transparent = True
        Me.tChart1.Axes.Left.Title.Transparent = True
        Me.tChart1.Axes.Right.Title.Transparent = True
        Me.tChart1.Axes.Top.Title.Transparent = True
        Me.tChart1.Size = New System.Drawing.Size(440, 205)
        ' 
        ' cbUseYOrigin
        ' 
        Me.cbUseYOrigin.AutoSize = True
        Me.cbUseYOrigin.Checked = True
        Me.cbUseYOrigin.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbUseYOrigin.Location = New System.Drawing.Point(19, 13)
        Me.cbUseYOrigin.Name = "cbUseYOrigin"
        Me.cbUseYOrigin.Size = New System.Drawing.Size(82, 17)
        Me.cbUseYOrigin.TabIndex = 0
        Me.cbUseYOrigin.Text = "&Use YOrigin"
        Me.cbUseYOrigin.UseVisualStyleBackColor = True
        AddHandler cbUseYOrigin.CheckedChanged, AddressOf Me.cbUseYOrigin_CheckedChanged
        ' 
        ' numericUpDown1
        ' 
        Me.numericUpDown1.Location = New System.Drawing.Point(204, 10)
        Me.numericUpDown1.Maximum = New Decimal(New Integer() {9999999, 0, 0, 0})
        Me.numericUpDown1.Minimum = New Decimal(New Integer() {9999999, 0, 0, -2147483648})
        Me.numericUpDown1.Name = "numericUpDown1"
        Me.numericUpDown1.Size = New System.Drawing.Size(75, 20)
        Me.numericUpDown1.TabIndex = 1
        AddHandler numericUpDown1.ValueChanged, AddressOf Me.numericUpDown1_ValueChanged
        ' 
        ' label1
        ' 
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(150, 14)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(44, 13)
        Me.label1.TabIndex = 2
        Me.label1.Text = "YOrigin:"
        ' 
        ' Histogram_YOrigin
        ' 
        Me.ClientSize = New System.Drawing.Size(440, 317)
        Me.Name = "Histogram_YOrigin"
        AddHandler Load, AddressOf Me.Histogram_YOrigin_Load
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.chartContainer.ResumeLayout(False)
        CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub
#End Region
    Private Sub cbUseYOrigin_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
        ser1.UseYOrigin = cbUseYOrigin.Checked
        label1.Enabled = cbUseYOrigin.Checked
        numericUpDown1.Enabled = cbUseYOrigin.Checked
    End Sub

    Private Sub numericUpDown1_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
        ser1.YOrigin = CType(numericUpDown1.Value, Integer)
    End Sub
End Class