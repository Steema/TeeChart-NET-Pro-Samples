Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Steema.TeeChart.Styles
Imports Steema.TeeChart.Tools
Public Class Surface_HideCells
    Inherits BaseForm
    Private WithEvents CBHideCells As CheckBox
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
    '/<summary>
    '/Required method for Designer support - do not modify
    '/the contents of this method with the code editor.
    '/ </summary>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Surface_HideCells))
        Me.CBHideCells = New System.Windows.Forms.CheckBox
        Me.panel1.SuspendLayout()
        Me.chartContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'textBox1
        '
        Me.textBox1.Size = New System.Drawing.Size(503, 73)
        Me.textBox1.Text = resources.GetString("textBox1.Text")
        '
        'panel1
        '
        Me.panel1.Controls.Add(Me.CBHideCells)
        Me.panel1.Size = New System.Drawing.Size(503, 39)
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
        Me.tChart1.Location = New System.Drawing.Point(0, 0)
        Me.tChart1.Size = New System.Drawing.Size(503, 266)
        '
        'chartContainer
        '
        Me.chartContainer.Size = New System.Drawing.Size(503, 266)
        '
        'CBHideCells
        '
        Me.CBHideCells.AutoSize = True
        Me.CBHideCells.Checked = True
        Me.CBHideCells.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CBHideCells.Location = New System.Drawing.Point(12, 6)
        Me.CBHideCells.Name = "CBHideCells"
        Me.CBHideCells.Size = New System.Drawing.Size(73, 17)
        Me.CBHideCells.TabIndex = 0
        Me.CBHideCells.Text = "Hide Cells"
        Me.CBHideCells.UseVisualStyleBackColor = True
        '
        'Surface_HideCells
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(503, 378)
        Me.Name = "Surface_HideCells"
        Me.Text = "Surface_HideCells"
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.chartContainer.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
#End Region
    Private surface As Surface
    Private rotate As Rotate
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        InitializeChart()
    End Sub
    Private Sub InitializeChart()
        surface = New Surface()
        tChart1.Series.Add(surface)
        tChart1.Aspect.Chart3DPercent = 60
        tChart1.Aspect.Elevation = 349
        tChart1.Aspect.Orthogonal = False
        tChart1.Aspect.Perspective = 123
        tChart1.Aspect.Rotation = 350
        tChart1.Aspect.Zoom = 80
        surface.HideCells = True
        surface.FillSampleValues()
        tChart1.Header.Text = ""
        rotate = New Rotate()
        tChart1.Tools.Add(rotate)
        rotate.Inertia = 80
    End Sub
    Private Sub CBHideCells_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles CBHideCells.CheckedChanged
        If Not (surface Is Nothing) Then
            surface.HideCells = CBHideCells.Checked
        End If
    End Sub
End Class