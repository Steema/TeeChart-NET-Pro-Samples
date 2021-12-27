
Imports System
#If VS2005 Then
Imports System.Collections.Generic
#End If
Imports System.Collections
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing

Imports System.Windows.Forms



Public Class Canvas_CustomGradients
    Inherits Samples.BaseForm

    '/ <summary>
    '/ Required designer variable.
    '/ </summary>
    Private components As System.ComponentModel.IContainer = Nothing


    Public Sub New() ' me call is required by the Windows Form Designer.
        InitializeComponent()
        InitializeChart()
    End Sub

    Private groupBox1 As GroupBox
    Private WithEvents rbFromCenter As RadioButton
    Private WithEvents rbRadial As RadioButton
    Private label2 As Label
    Private WithEvents udYOffset As NumericUpDown
    Private label1 As Label
    Private WithEvents udXOffset As NumericUpDown
    Private rectangle As Steema.TeeChart.Tools.RectangleTool

    Private Sub InitializeChart()
        rectangle = New Steema.TeeChart.Tools.RectangleTool()
        tChart1.Tools.Add(rectangle)
    End Sub

    Private Sub CustomizeGradient(ByVal gradient As Steema.TeeChart.Drawing.Gradient)
        gradient.Visible = True
        Dim CustomGradientPalette As Color() = New Color() { _
         Color.FromArgb(120, Color.Red), _
         Color.FromArgb(120, Color.Yellow), _
         Color.FromArgb(120, Color.Blue), _
         Color.FromArgb(120, Color.Violet) _
        }
        gradient.ExtendedColorPalette = CustomGradientPalette
        gradient.CustomTargetRectangle = New Rectangle(0, 0, tChart1.Width, tChart1.Height)
        gradient.Style.Visible = True
        gradient.Style.CenterXOffset = 50
        gradient.Style.CenterYOffset = 50
        gradient.Style.Direction = Steema.TeeChart.Drawing.PathGradientMode.FromCenter
    End Sub

    Private Sub tChart1_Resize(ByVal sender As Object, ByVal e As EventArgs) Handles tChart1.Resize
        If Not (rectangle Is Nothing) Then
            CustomizeGradient(rectangle.Shape.Gradient)
        End If
    End Sub

    Private Sub rbRadial_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rbRadial.CheckedChanged
        If rbRadial.Checked And Not (rectangle Is Nothing) Then
            rectangle.Shape.Gradient.Style.Direction = Steema.TeeChart.Drawing.PathGradientMode.Radial
        End If
    End Sub

    Private Sub rbFromCenter_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rbFromCenter.CheckedChanged
        If rbFromCenter.Checked And Not (rectangle Is Nothing) Then
            rectangle.Shape.Gradient.Style.Direction = Steema.TeeChart.Drawing.PathGradientMode.FromCenter
        End If
    End Sub

    Private Sub udXOffset_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles udXOffset.ValueChanged
        If Not (rectangle Is Nothing) Then
            rectangle.Shape.Gradient.Style.CenterXOffset = CType(udXOffset.Value, Integer)
        End If
    End Sub

    Private Sub udYOffset_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles udYOffset.ValueChanged
        If Not (rectangle Is Nothing) Then
            rectangle.Shape.Gradient.Style.CenterYOffset = CInt(udYOffset.Value)
        End If
    End Sub

    '/ <summary>
    '/ Clean up any resources being used.
    '/ </summary>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If Disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(Disposing)
    End Sub 'Dispose

#Region "Windows Form Designer generated code"

    '/ <summary>
    '/ Required method for Designer support - do not modify
    '/ the contents of me method with the code editor.
    '/ </summary>
    Private Sub InitializeComponent()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbFromCenter = New System.Windows.Forms.RadioButton()
        Me.rbRadial = New System.Windows.Forms.RadioButton()
        Me.udXOffset = New System.Windows.Forms.NumericUpDown()
        Me.label1 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.udYOffset = New System.Windows.Forms.NumericUpDown()
        Me.panel1.SuspendLayout()
        Me.chartContainer.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        CType(Me.udXOffset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.udYOffset, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Text = "New gradient properties enable new gradient directions, custom gradient colour pa" + _
        "lettes" & vbCrLf & "and custom destination rectangles." & vbCrLf & vbCrLf & "Resize and move the gradient on th" + _
        "e chart to see the effects."
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.label2)
        Me.panel1.Controls.Add(Me.udYOffset)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Controls.Add(Me.udXOffset)
        Me.panel1.Controls.Add(Me.groupBox1)
        ' 
        ' tChart1
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Aspect.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
        Me.tChart1.Aspect.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Bottom.Labels.Font.Name = "Verdana"
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Bottom.Title.Font.Name = "Verdana"
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Depth.Labels.Font.Name = "Verdana"
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Depth.Title.Font.Name = "Verdana"
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.DepthTop.Labels.Font.Name = "Verdana"
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.DepthTop.Title.Font.Name = "Verdana"
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Left.Labels.Font.Name = "Verdana"
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Left.Title.Font.Name = "Verdana"
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Right.Labels.Font.Name = "Verdana"
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Right.Title.Font.Name = "Verdana"
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Top.Labels.Font.Name = "Verdana"
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Top.Title.Font.Name = "Verdana"
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Header.Font.Name = "Verdana"
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Legend.Font.Name = "Verdana"
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.tChart1.Panel.Brush.Gradient.ExtendedColorPalette = Nothing
        Me.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tChart1.Panel.Brush.Gradient.Sigma = True
        Me.tChart1.Panel.Brush.Gradient.SigmaFocus = 1.0!
        Me.tChart1.Panel.Brush.Gradient.SigmaScale = 0.8!
        Me.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tChart1.Panel.Brush.Gradient.UseMiddle = True
        Me.tChart1.Panel.Brush.Gradient.Visible = True
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
        ' groupBox1
        ' 
        Me.groupBox1.Controls.Add(Me.rbFromCenter)
        Me.groupBox1.Controls.Add(Me.rbRadial)
        Me.groupBox1.Location = New System.Drawing.Point(12, 3)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(172, 33)
        Me.groupBox1.TabIndex = 0
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Direction"
        ' 
        ' rbFromCenter
        ' 
#If VS2005 Then
			me.rbFromCenter.AutoSize = true
#End If
        Me.rbFromCenter.Checked = True
        Me.rbFromCenter.Location = New System.Drawing.Point(77, 13)
        Me.rbFromCenter.Name = "rbFromCenter"
        Me.rbFromCenter.Size = New System.Drawing.Size(82, 17)
        Me.rbFromCenter.TabIndex = 2
        Me.rbFromCenter.TabStop = True
        Me.rbFromCenter.Text = "From Center"
#If VS2005 Then
			me.rbFromCenter.UseVisualStyleBackColor = true
#End If
        ' 
        ' rbRadial
        ' 
#If VS2005 Then
			me.rbRadial.AutoSize = true
#End If
        Me.rbRadial.Location = New System.Drawing.Point(16, 13)
        Me.rbRadial.Name = "rbRadial"
        Me.rbRadial.Size = New System.Drawing.Size(55, 17)
        Me.rbRadial.TabIndex = 1
        Me.rbRadial.Text = "Radial"
#If VS2005 Then
			me.rbRadial.UseVisualStyleBackColor = true
#End If
        ' 
        ' udXOffset
        ' 
        Me.udXOffset.Location = New System.Drawing.Point(241, 16)
        Me.udXOffset.Maximum = New Decimal(New Integer() { _
                 1000, _
                 0, _
                 0, _
                 0})
        Me.udXOffset.Name = "udXOffset"
        Me.udXOffset.Size = New System.Drawing.Size(56, 20)
        Me.udXOffset.TabIndex = 1
        Me.udXOffset.Value = New Decimal(New Integer() { _
                 50, _
                 0, _
                 0, _
                 0})
        ' 
        ' label1
        ' 
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(190, 18)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(45, 13)
        Me.label1.TabIndex = 2
        Me.label1.Text = "XOffset:"
        ' 
        ' label2
        ' 
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(303, 18)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(45, 13)
        Me.label2.TabIndex = 4
        Me.label2.Text = "YOffset:"
        ' 
        ' udYOffset
        ' 
        Me.udYOffset.Location = New System.Drawing.Point(351, 16)
        Me.udYOffset.Maximum = New Decimal(New Integer() { _
                 1000, _
                 0, _
                 0, _
                 0})
        Me.udYOffset.Name = "udYOffset"
        Me.udYOffset.Size = New System.Drawing.Size(56, 20)
        Me.udYOffset.TabIndex = 3
        Me.udYOffset.Value = New Decimal(New Integer() { _
                 50, _
                 0, _
                 0, _
                 0})
        ' 
        ' Canvas_CustomGradients
        ' 
#If VS2005 Then
			me.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F)
			me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
#End If
        Me.ClientSize = New System.Drawing.Size(440, 317)
        Me.Name = "Canvas_CustomGradients"
        Me.Text = "Canvas_CustomGradients"
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.chartContainer.ResumeLayout(False)
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        CType(Me.udXOffset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.udYOffset, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region



End Class

