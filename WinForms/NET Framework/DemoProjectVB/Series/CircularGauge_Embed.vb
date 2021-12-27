Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Steema.TeeChart.Styles
Imports Steema.TeeChart.Drawing
Public Class CircularGauge_Embed
    Inherits BaseForm
    Private timer1 As Timer
    Private cbPalette As ComboBox
    Private label1 As Label
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
    '/</summary>"    Private Sub InitializeComponent()

    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.label1 = New System.Windows.Forms.Label
        Me.cbPalette = New System.Windows.Forms.ComboBox
        Me.panel1.SuspendLayout()
        Me.chartContainer.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Text = ("Using a very simple technique demonstrated here, multiple Numeric Gauges" & vbCrLf & "and/or " & "LinearGauges can be embedded in a CircularGauge.")
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.cbPalette)
        Me.panel1.Controls.Add(Me.label1)
        ' 
        ' tChart1
        ' 
        Me.tChart1.Aspect.ZOffset = 0
        Me.tChart1.Axes.Bottom.PartnerAxis = Nothing
        Me.tChart1.Axes.Bottom.UsePartnerAxis = False
        Me.tChart1.Axes.Depth.PartnerAxis = Nothing
        Me.tChart1.Axes.Depth.UsePartnerAxis = False
        Me.tChart1.Axes.DepthTop.PartnerAxis = Nothing
        Me.tChart1.Axes.DepthTop.UsePartnerAxis = False
        Me.tChart1.Axes.Left.PartnerAxis = Nothing
        Me.tChart1.Axes.Left.UsePartnerAxis = False
        Me.tChart1.Axes.Right.PartnerAxis = Nothing
        Me.tChart1.Axes.Right.UsePartnerAxis = False
        Me.tChart1.Axes.Top.PartnerAxis = Nothing
        Me.tChart1.Axes.Top.UsePartnerAxis = False
        Me.tChart1.Legend.TextSymbolGap = 0
        Me.tChart1.Size = New System.Drawing.Size(440, 205)
        ' 
        ' timer1
        ' 
        Me.timer1.Interval = 10
        AddHandler timer1.Tick, AddressOf Me.timer1_Tick
        ' 
        ' label1
        ' 
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(12, 14)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(43, 13)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Palette:"
        ' 
        ' cbPalette
        ' 
#If (VS2005) Then
        Me.cbPalette.FormattingEnabled = True
#End If
        Me.cbPalette.Location = New System.Drawing.Point(61, 11)
        Me.cbPalette.Name = "cbPalette"
        Me.cbPalette.Size = New System.Drawing.Size(217, 21)
        Me.cbPalette.TabIndex = 1
        AddHandler cbPalette.SelectedIndexChanged, AddressOf Me.cbPalette_SelectedIndexChanged
        ' 
        ' CircularGauge_Embed
        ' 
#If (VS2005) Then
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
#End If
        Me.ClientSize = New System.Drawing.Size(440, 317)
        Me.Name = "CircularGauge_Embed"
        Me.Text = "CircularGauge_Embed"
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.chartContainer.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub
#End Region
    Private cGauge As CircularGauge
    Private nGauge As NumericGauge
    Private lGauge As LinearGauge
    Private rnd As Random = New Random
    Private up As Boolean = True
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        FillComboBox()
        InitializeChart()
    End Sub

    Private Sub FillComboBox()
        cbPalette.Items.Add("Current")
        cbPalette.Items.Add("BlackPalette")
        cbPalette.Items.Add("BluesPalette")
        cbPalette.Items.AddRange(Steema.TeeChart.Themes.Theme.ColorPalettes.ToArray)
        cbPalette.SelectedIndex = 0
    End Sub

    Private Sub InitializeChart()
        cGauge = New CircularGauge()
        tChart1.Series.Add(cGauge)
        cGauge.RotationAngle = 270
        cGauge.TotalAngle = 180
        cGauge.Axis.Labels.Font.Size = 7
        cGauge.Axis.Labels.Font.Color = CustomGauge.GetGaugePaletteColor(20, cGauge.GaugeColorPalette)
        cGauge.RedLine.Visible = False
        cGauge.GreenLine.Visible = False
        AddHandler cGauge.BeforeDrawHand, AddressOf Me.cGauge_BeforeDrawHand
        cGauge.Value = 1
        timer1.Enabled = True
        SetUpNGauge()
        SetUpLGauge()
    End Sub
    Private Sub SetUpLGauge()
        Dim axisH As Axis = New Axis
        axisH.Horizontal = True
        Dim axisV As Axis = New Axis
        axisV.Horizontal = False
        lGauge = New LinearGauge
        lGauge.HorizAxis = HorizontalAxis.Custom
        lGauge.VertAxis = VerticalAxis.Custom
        lGauge.Horizontal = False
        lGauge.Visible = False
        lGauge.CustomHorizAxis = axisH
        lGauge.CustomVertAxis = axisV
        lGauge.Axis.Title.Font.Size = 7
        lGauge.Axis.Title.Font.Color = CustomGauge.GetGaugePaletteColor(20, lGauge.GaugeColorPalette)
        lGauge.Axis.Title.Caption = "Independent value"
        lGauge.Axis.Labels.Font.Size = 6
        lGauge.Axis.Labels.Font.Color = CustomGauge.GetGaugePaletteColor(20, lGauge.GaugeColorPalette)
        lGauge.Axis.Increment = 20
        lGauge.RedLine.Visible = False
        lGauge.GreenLine.Visible = False
        lGauge.Frame.Visible = False
        lGauge.FaceBrush.Visible = False
    End Sub

  Private Sub SetUpNGauge()
    Dim axis As Axis = New Axis
    axis.Horizontal = True
    nGauge = New NumericGauge
    nGauge.HorizAxis = HorizontalAxis.Custom
    nGauge.CustomHorizAxis = axis
    nGauge.Visible = False
    nGauge.TextMarker.Active = False
    nGauge.UnitsMarker.Active = False
    nGauge.Horizontal = True
    nGauge.ValueFormat = "###.0"
    nGauge.ValueMarker.Active = True
    nGauge.ValueMarker.Shape.Font.Size = 14
  End Sub

   Private Function CalcLGaugeBounds() As Rectangle
        Dim result As Rectangle = Steema.TeeChart.Utils.FromLTRB(Convert.ToInt32(cGauge.CircleXCenter + (cGauge.CircleWidth / 7)), Convert.ToInt32(cGauge.CircleYCenter - (cGauge.CircleHeight / 3)), Convert.ToInt32(cGauge.CircleXCenter + (cGauge.CircleWidth / 4)), Convert.ToInt32(cGauge.CircleYCenter + (cGauge.CircleHeight / 3)))
        Return result
    End Function

    Private Function CalcNGaugeBounds() As Rectangle
        Dim result As Rectangle = Steema.TeeChart.Utils.FromLTRB(Convert.ToInt32(cGauge.CircleXCenter - Steema.TeeChart.Utils.Round(cGauge.CircleWidth / 3.75)), Convert.ToInt32(cGauge.CircleYCenter - (cGauge.CircleHeight / 10)), Convert.ToInt32(cGauge.CircleXCenter - (cGauge.CircleWidth / 12)), Convert.ToInt32(cGauge.CircleYCenter + (cGauge.CircleHeight / 10)))
        Return result
    End Function

    Private Sub DrawNGauge(ByVal g As Graphics3D)
        nGauge.Value = cGauge.Value
        nGauge.CustomBounds = CalcNGaugeBounds()
        nGauge.Draw(g)
    End Sub

    Private Sub DrawLGauge(ByVal g As Graphics3D)
        lGauge.Value = rnd.Next(0, 100)
        lGauge.CustomBounds = CalcLGaugeBounds()
        lGauge.Draw(g)
    End Sub

    Private Sub cGauge_BeforeDrawHand(ByVal sender As Object, ByVal g As Steema.TeeChart.Drawing.Graphics3D)
        DrawNGauge(g)
        DrawLGauge(g)
    End Sub

    Private Sub timer1_Tick(ByVal sender As Object, ByVal e As EventArgs)
        If ((CType(cGauge.Value, Integer) = 100) _
                    OrElse (CType(cGauge.Value, Integer) = 0)) Then
            up = Not up
        End If
        If up Then
            cGauge.Value = (cGauge.Value + 0.1)
        Else
            cGauge.Value = (cGauge.Value - 0.1)
        End If
    End Sub

    Private Sub ApplyPalette(ByVal palette() As Color)
        cGauge.GaugeColorPalette = palette
        cGauge.GreenLine.Visible = False
        cGauge.RedLine.Visible = False
        lGauge.GaugeColorPalette = palette
        lGauge.GreenLine.Visible = False
        lGauge.RedLine.Visible = False
        lGauge.FaceBrush.Visible = False
        lGauge.Hand.Pen.Visible = False
    End Sub

    Private Sub cbPalette_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
        If (cbPalette.SelectedIndex > 2) Then
            ApplyPalette(Steema.TeeChart.Themes.ColorPalettes.GetPalette((cbPalette.SelectedIndex - 3)))
        ElseIf (cbPalette.SelectedIndex = 1) Then
            ApplyPalette(Steema.TeeChart.Styles.CustomGauge.BlackPalette)
        ElseIf (cbPalette.SelectedIndex = 2) Then
            ApplyPalette(Steema.TeeChart.Styles.CustomGauge.BluesPalette)
        End If
    End Sub
End Class