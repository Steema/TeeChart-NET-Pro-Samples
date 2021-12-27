Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Steema.TeeChart.Styles
Imports Steema.TeeChart.Drawing
Public Class KnobGauge_Series
    Inherits BaseForm
    Private WithEvents timer1 As Timer
    Private kGauge1, kGauge2 As KnobGauge
    Private WithEvents nGauge1, nGauge2 As NumericGauge
    Private WithEvents cBActiveCenter As CheckBox
    Private WithEvents cBAnimate As CheckBox
    Private WithEvents timer2 As Timer
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
    '/ <summary>
    'Required method for Designer support - do not modify
    'the contents of this method with the code editor.
    '/</summary>"    Private Sub InitializeComponent()End Class
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.cBAnimate = New System.Windows.Forms.CheckBox
        Me.cBActiveCenter = New System.Windows.Forms.CheckBox
        Me.panel1.SuspendLayout()
        Me.chartContainer.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Text = ("New in this version is the KnobGauge series type. With ActiveCenter true, you can" & " change the Knobgauge value by mousedragging on the centre hub.")
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.cBActiveCenter)
        Me.panel1.Controls.Add(Me.cBAnimate)
        ' 
        ' tChart1
        ' 
        Me.tChart1.Aspect.ZOffset = 0
        Me.tChart1.Legend.TextSymbolGap = 0
        Me.tChart1.Size = New System.Drawing.Size(440, 205)
        ' 
        ' timer1
        ' 
        Me.timer1.Interval = 10
        AddHandler timer1.Tick, AddressOf Me.timer1_Tick
        ' 
        ' timer2
        ' 
        Me.timer2.Interval = 10
        AddHandler timer2.Tick, AddressOf Me.timer2_Tick
        ' 
        ' cBAnimate
        ' 
        Me.cBAnimate.Checked = True
        Me.cBAnimate.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cBAnimate.Location = New System.Drawing.Point(31, 10)
        Me.cBAnimate.Name = "cBAnimate"
        Me.cBAnimate.Size = New System.Drawing.Size(80, 17)
        Me.cBAnimate.TabIndex = 0
        Me.cBAnimate.Text = "Animate"
#If (VS2005) Then
        Me.cBAnimate.AutoSize = True
        Me.cBAnimate.UseVisualStyleBackColor = True
#End If
        AddHandler cBAnimate.CheckedChanged, AddressOf Me.cBAnimate_CheckedChanged
        ' 
        ' cBActiveCenter
        ' 
        Me.cBActiveCenter.Enabled = False
        Me.cBActiveCenter.Location = New System.Drawing.Point(180, 11)
        Me.cBActiveCenter.Name = "cBActiveCenter"
        Me.cBActiveCenter.Size = New System.Drawing.Size(100, 17)
        Me.cBActiveCenter.TabIndex = 1
        Me.cBActiveCenter.Text = "ActiveCenter"
#If (VS2005) Then
        Me.cBActiveCenter.AutoSize = True
        Me.cBActiveCenter.UseVisualStyleBackColor = True
#End If
        AddHandler cBActiveCenter.CheckedChanged, AddressOf Me.cBActiveCenter_CheckedChanged
        ' 
        ' KnobGauge_Series
        ' 
#If (VS2005) Then
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
#End If
        Me.ClientSize = New System.Drawing.Size(440, 317)
        Me.Name = "KnobGauge_Series"
        Me.Text = "KnobGauge_Series"
        Me.chartContainer.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

#End Region
    Private up1 As Boolean = True
    Private up2 As Boolean = True
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        InitializeChart()
    End Sub
    Private Sub InitializeChart()
        kGauge1 = New KnobGauge()
        tChart1.Series.Add(kGauge1)
        kGauge1.Value = 1
        kGauge2 = New KnobGauge()
        tChart1.Series.Add(kGauge2)
        kGauge2.Value = 99
        timer1.Enabled = True
        timer2.Enabled = True
        SetUpNGauge1()
        SetUpNGauge2()
        AddHandler tChart1.AfterDraw, AddressOf Me.tChart1_AfterDraw
    End Sub

    Private Sub tChart1_AfterDraw(ByVal sender As Object, ByVal g As Graphics3D)
        DrawNGauge1(g)
        DrawNGauge2(g)
    End Sub

    Private Sub SetUpNGauge1()
        Dim axis As Axis = New Axis
        axis.Horizontal = True
        nGauge1 = New NumericGauge
        nGauge1.HorizAxis = HorizontalAxis.Custom
        nGauge1.CustomHorizAxis = axis
        nGauge1.Visible = False
        nGauge1.TextMarker.Active = False
        nGauge1.UnitsMarker.Active = False
        nGauge1.Horizontal = True
        nGauge1.ValueFormat = "###.0"
        nGauge1.ValueMarker.Active = True
        nGauge1.ValueMarker.Shape.Font.Size = 10
        nGauge1.GaugeColorPalette = NumericGauge.LEDPalette
    End Sub

    Private Sub SetUpNGauge2()
        Dim axis As Axis = New Axis
        axis.Horizontal = True
        nGauge2 = New NumericGauge
        nGauge2.HorizAxis = HorizontalAxis.Custom
        nGauge2.CustomHorizAxis = axis
        nGauge2.Visible = False
        nGauge2.TextMarker.Active = False
        nGauge2.UnitsMarker.Active = False
        nGauge2.Horizontal = True
        nGauge2.ValueFormat = "###.0"
        nGauge2.ValueMarker.Active = True
        nGauge2.ValueMarker.Shape.Font.Size = 10
        nGauge2.GaugeColorPalette = NumericGauge.LEDPalette
    End Sub

    Private Sub DrawNGauge1(ByVal g As Graphics3D)
        nGauge1.Value = kGauge1.Value
        nGauge1.CustomBounds = CalcNGauge1Bounds()
        nGauge1.Draw(g)
    End Sub

    Private Sub DrawNGauge2(ByVal g As Graphics3D)
        nGauge2.Value = kGauge2.Value
        nGauge2.CustomBounds = CalcNGauge2Bounds()
        nGauge2.Draw(g)
    End Sub

    Private Function CalcNGauge1Bounds() As Rectangle
        Dim result As Rectangle = Steema.TeeChart.Utils.FromLTRB((kGauge1.CircleXCenter - 30), (kGauge1.CircleRect.Bottom + 10), (kGauge1.CircleXCenter + 30), (kGauge1.CircleRect.Bottom + 40))
        Return result
    End Function

    Private Function CalcNGauge2Bounds() As Rectangle
        Dim result As Rectangle = Steema.TeeChart.Utils.FromLTRB((kGauge2.CircleXCenter - 30), (kGauge2.CircleRect.Bottom + 10), (kGauge2.CircleXCenter + 30), (kGauge2.CircleRect.Bottom + 40))
        Return result
    End Function
    Private Sub timer1_Tick(ByVal sender As Object, ByVal e As EventArgs)
        If ((CType(kGauge1.Value, Integer) = 100) _
                    OrElse (CType(kGauge1.Value, Integer) = 0)) Then
            up1 = Not up1
        End If
        If up1 Then
            kGauge1.Value = (kGauge1.Value + 1)
        Else
            kGauge1.Value = (kGauge1.Value - 1)
        End If
    End Sub

    Private Sub timer2_Tick(ByVal sender As Object, ByVal e As EventArgs)
        If ((CType(kGauge2.Value, Integer) = 100) _
                    OrElse (CType(kGauge2.Value, Integer) = 0)) Then
            up2 = Not up2
        End If
        If up2 Then
            kGauge2.Value = (kGauge2.Value + 1)
        Else
            kGauge2.Value = (kGauge2.Value - 1)
        End If
    End Sub

    Private Sub cBAnimate_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
        timer1.Enabled = cBAnimate.Checked
        timer2.Enabled = cBAnimate.Checked
        cBActiveCenter.Enabled = Not cBAnimate.Checked
    End Sub

    Private Sub cBActiveCenter_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
        kGauge1.ActiveCenter = cBActiveCenter.Checked
        kGauge2.ActiveCenter = cBActiveCenter.Checked
    End Sub
End Class