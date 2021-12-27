Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Steema.TeeChart.Styles
Imports Steema.TeeChart.Tools
Public Class DrawLine_Style
    Inherits BaseForm
    Private label2 As Label
    Private WithEvents cbStyles As ComboBox
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
    '/ <summary>
    '/ Required method for Designer support - do not modify
    '/the contents of this method with the code editor.
    '/ </summary>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DrawLine_Style))
        Me.label1 = New System.Windows.Forms.Label
        Me.cbStyles = New System.Windows.Forms.ComboBox
        Me.label2 = New System.Windows.Forms.Label
        Me.panel1.SuspendLayout()
        Me.chartContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'textBox1
        '
        Me.textBox1.Text = resources.GetString("textBox1.Text")
        '
        'panel1
        '
        Me.panel1.Controls.Add(Me.label2)
        Me.panel1.Controls.Add(Me.cbStyles)
        Me.panel1.Controls.Add(Me.label1)
        '
        'tChart1
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
        '
        '
        '
        Me.tChart1.Header.Lines = New String() {"New DrawLine Styles example"}
        Me.tChart1.Location = New System.Drawing.Point(0, 0)
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(12, 14)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(75, 13)
        Me.label1.TabIndex = 0
        Me.label1.Text = "New line &style:"
        '
        'cbStyles
        '
        Me.cbStyles.FormattingEnabled = True
        Me.cbStyles.Location = New System.Drawing.Point(93, 11)
        Me.cbStyles.Name = "cbStyles"
        Me.cbStyles.Size = New System.Drawing.Size(157, 21)
        Me.cbStyles.TabIndex = 1
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(270, 14)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(164, 13)
        Me.label2.TabIndex = 2
        Me.label2.Text = "(click and drag left mouse button)"
        '
        'DrawLine_Style
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(440, 317)
        Me.Name = "DrawLine_Style"
        Me.Text = "DrawLine_Style"
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.chartContainer.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        InitializeChart()
    End Sub
    Private drawLine As DrawLine
    Private Sub InitializeChart()
        FillCombo()
        tChart1.Aspect.View3D = False
        tChart1.Series.Add(GetType(Line))
        tChart1(0).FillSampleValues()
        drawLine = New DrawLine()
        tChart1.Tools.Add(drawLine)
        drawLine.Pen.Color = Color.Blue
        drawLine.Pen.Width = 2
        cbStyles.SelectedIndex = 2
    End Sub

    Private Sub FillCombo()
        cbStyles.Items.Add(DrawLineStyle.Ellipse)
        cbStyles.Items.Add(DrawLineStyle.HorizParallel)
        cbStyles.Items.Add(DrawLineStyle.Line)
        cbStyles.Items.Add(DrawLineStyle.Rectangle)
        cbStyles.Items.Add(DrawLineStyle.VertParallel)
    End Sub
    Private Sub cbStyles_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbStyles.SelectedIndexChanged
        drawLine.Style = CType(cbStyles.SelectedItem, DrawLineStyle)
    End Sub
End Class