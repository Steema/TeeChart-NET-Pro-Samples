Imports System
#If VS2005 Then
imports System.Collections.Generic
#End If
imports System.ComponentModel
imports System.Data
imports System.Drawing
imports System.Text
imports System.Windows.Forms



Public Class Tool_BannerTool
    Inherits Samples.BaseForm

    '/ <summary>
    '/ Required designer variable.
    '/ </summary>
    Private components As System.ComponentModel.IContainer = Nothing


    Public Sub New() ' me call is required by the Windows Form Designer.
        InitializeComponent()
    End Sub

    Private bannerTool1 As Steema.TeeChart.Tools.BannerTool
    Private WithEvents checkBox1 As CheckBox
    Private WithEvents checkBox2 As CheckBox
    Private WithEvents comboBox1 As ComboBox
    Private label1 As Label
    Private WithEvents textBox2 As TextBox
    Private label2 As Label


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
        Me.bannerTool1 = New Steema.TeeChart.Tools.BannerTool()
        Me.checkBox1 = New System.Windows.Forms.CheckBox()
        Me.checkBox2 = New System.Windows.Forms.CheckBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.comboBox1 = New System.Windows.Forms.ComboBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.textBox2 = New System.Windows.Forms.TextBox()
        Me.panel1.SuspendLayout()
        Me.chartContainer.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Text = "Scrolling banner and Font Blinker."
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.textBox2)
        Me.panel1.Controls.Add(Me.label2)
        Me.panel1.Controls.Add(Me.comboBox1)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Controls.Add(Me.checkBox2)
        Me.panel1.Controls.Add(Me.checkBox1)
        Me.panel1.Size = New System.Drawing.Size(440, 68)
        ' 
        ' tChart1
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Aspect.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
        Me.tChart1.Aspect.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias
        Me.tChart1.Aspect.View3D = False
        Me.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.tChart1.Panel.Brush.Gradient.ExtendedColorPalette = Nothing
        Me.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tChart1.Panel.Brush.Gradient.Sigma = True
        Me.tChart1.Panel.Brush.Gradient.SigmaFocus = 1.0!
        Me.tChart1.Panel.Brush.Gradient.SigmaScale = 0.8!
        Me.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tChart1.Panel.Brush.Gradient.UseMiddle = True
        Me.tChart1.Panel.Brush.Gradient.Visible = True
        Me.tChart1.Size = New System.Drawing.Size(440, 176)
        Me.tChart1.Tools.Add(Me.bannerTool1)
        ' 
        ' chartContainer
        ' 
        Me.chartContainer.Location = New System.Drawing.Point(0, 141)
        Me.chartContainer.Size = New System.Drawing.Size(440, 176)
        ' 
        ' bannerTool1
        ' 
        Me.bannerTool1.AutoSize = True
        Me.bannerTool1.BlinkDelayOff = 500
        Me.bannerTool1.Cursor = System.Windows.Forms.Cursors.Default
        Me.bannerTool1.Left = 100
        Me.bannerTool1.Position = Steema.TeeChart.Tools.AnnotationPositions.RightTop
        ' 
        ' 
        ' 
        Me.bannerTool1.Shape.BorderRound = 8
        Me.bannerTool1.Shape.Bottom = 119
        Me.bannerTool1.Shape.CustomPosition = True
        ' 
        ' 
        ' 
        Me.bannerTool1.Shape.Left = 100
        Me.bannerTool1.Shape.Lines = New String() { _
        "Scrolling and/or blinking text"}
        Me.bannerTool1.Shape.Right = 247
        ' 
        ' 
        ' 
        Me.bannerTool1.Shape.Shadow.Visible = True
        Me.bannerTool1.Shape.ShapeStyle = Steema.TeeChart.Drawing.TextShapeStyle.RoundRectangle
        Me.bannerTool1.Shape.Top = 100
        Me.bannerTool1.Text = "Scrolling and/or blinking text"
        Me.bannerTool1.Top = 100
        ' 
        ' checkBox1
        ' 
        Me.checkBox1.Checked = True
        Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox1.Location = New System.Drawing.Point(12, 16)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(49, 17)
        Me.checkBox1.TabIndex = 0
        Me.checkBox1.Text = "Scroll"
#If VS2005 Then
            me.checkBox1.AutoSize = true
            me.checkBox1.UseVisualStyleBackColor = true
#End If
        ' 
        ' checkBox2
        ' 
        Me.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox2.Location = New System.Drawing.Point(81, 16)
        Me.checkBox2.Name = "checkBox2"
        Me.checkBox2.Size = New System.Drawing.Size(46, 17)
        Me.checkBox2.TabIndex = 1
        Me.checkBox2.Text = "Blink"
#If VS2005 Then
            me.checkBox2.AutoSize = true
            me.checkBox2.UseVisualStyleBackColor = true
#End If
        ' 
        ' label1
        ' 
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(12, 44)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(49, 13)
        Me.label1.TabIndex = 2
        Me.label1.Text = "Direction"
        ' 
        ' comboBox1
        ' 
#If VS2005 Then
            me.comboBox1.FormattingEnabled = true
#End If
        Me.comboBox1.Items.AddRange(New Object() { _
        "Right to Left", _
        "Left to Right"})
        Me.comboBox1.Location = New System.Drawing.Point(81, 41)
        Me.comboBox1.Name = "comboBox1"
        Me.comboBox1.Size = New System.Drawing.Size(111, 21)
        Me.comboBox1.TabIndex = 3
        ' 
        ' label2
        ' 
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(196, 18)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(31, 13)
        Me.label2.TabIndex = 4
        Me.label2.Text = "Text:"
        ' 
        ' textBox2
        ' 
        Me.textBox2.Location = New System.Drawing.Point(233, 15)
        Me.textBox2.Name = "textBox2"
        Me.textBox2.Size = New System.Drawing.Size(195, 20)
        Me.textBox2.TabIndex = 5
        Me.textBox2.Text = "Scrolling and blinking text"
        ' 
        ' Tool_BannerTool
        ' 
        Me.ClientSize = New System.Drawing.Size(440, 317)
        Me.Name = "Tool_BannerTool"
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.chartContainer.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()


    End Sub

#End Region

    Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox1.CheckedChanged
        bannerTool1.Scroll = checkBox1.Checked
    End Sub

    Private Sub checkBox2_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox2.CheckedChanged
        bannerTool1.Blink = checkBox2.Checked
    End Sub

    Private Sub comboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox1.SelectedIndexChanged
        bannerTool1.ScrollDirection = CType(comboBox1.SelectedIndex, Steema.TeeChart.Tools.ScrollingDirection)
    End Sub

  Private Sub Tool_BannerTool_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
    comboBox1.SelectedIndex = 1
  End Sub

  Private Sub textBox2_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles textBox2.TextChanged
    bannerTool1.Text = textBox2.Text
  End Sub

End Class

