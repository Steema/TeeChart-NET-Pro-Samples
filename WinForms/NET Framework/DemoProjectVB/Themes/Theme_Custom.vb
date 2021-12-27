
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing

Imports System.Windows.Forms



Public Class Theme_Custom
    Inherits Samples.BaseForm

    Private cbBase64 As System.Windows.Forms.CheckBox
    Private bApply As System.Windows.Forms.Button
    Private tChart2 As Steema.TeeChart.TChart

    '/ <summary>
    '/ Required designer variable.
    '/ </summary>
    Private components As System.ComponentModel.IContainer = Nothing


    Public Sub New() ' This call is required by the Windows Form Designer.
        InitializeComponent()
        tChart2 = New Steema.TeeChart.TChart()
        tChart2.Dock = DockStyle.Right
        tChart2.Width = 400
        chartContainer.Controls.Add(tChart2)

        CreateStyle()

        tChart1.Series.Add(New Steema.TeeChart.Styles.Points())
        tChart1(0).FillSampleValues()
    End Sub

    Private Sub CreateStyle()

        Dim i As Integer
        For i = 0 To tChart1.Axes.Count - 1 Step +1
            Dim a As Axis = tChart1.Axes(i)
            a.Labels.Font.Name = "Verdana"
            a.Labels.Font.Size = 7
        Next

        tChart1.Aspect.View3D = False
        tChart1.Header.Font.Name = "Verdana"
        tChart1.Header.Font.Size = 9
        tChart1.Legend.Font.Name = "Verdana"
        tChart1.Legend.Font.Size = 7

        tChart1.Panel.Gradient.Visible = True
        tChart1.Panel.Gradient.StartColor = Color.SeaGreen
        tChart1.Panel.Gradient.MiddleColor = Color.SeaShell
        tChart1.Panel.Gradient.EndColor = Color.Sienna

        tChart1.Panel.Bevel.Inner = Steema.TeeChart.Drawing.BevelStyles.Raised
        tChart1.Panel.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None
    End Sub


    Private themeDirectory As String

    Private Sub SaveCustomTheme()

        themeDirectory = Steema.TeeChart.Utils.ThemeFolder()
        tChart1.Export.Theme.SaveWithBase64 = Me.cbBase64.Checked
        tChart1.Export.Theme.Save(themeDirectory + "\\My Theme.xml")
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
    '/ the contents of this method with the code editor.
    '/ </summary>
    Private Sub InitializeComponent()
        Me.cbBase64 = New System.Windows.Forms.CheckBox
        Me.bApply = New System.Windows.Forms.Button
        Me.panel1.SuspendLayout()
        Me.chartContainer.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Text = "Custom Themes can now be easily created and visualised within the Chart Editor." & vbLf & "As Custom Themes are " & _
        "XML files they can be edited completely independently of" & vbLf & "TeeChart." & vbLf & "In the example below, apply a the" & _
        "me to the chart on the left with or without " & vbLf & "'template' information, which in this case includes the" & _
        " series and its properties." & vbLf & "Double click on this textbox to view the chart editor and navigate to th" & _
        "e Themes" & vbLf & "tab to view the newly created custom theme, 'My Theme'!"
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.bApply)
        Me.panel1.Controls.Add(Me.cbBase64)
        Me.panel1.Name = "panel1"
        ' 
        ' tChart1
        ' 
        ' 
        ' tChart1.Aspect
        ' 
        Me.tChart1.Aspect.ColorPaletteIndex = -1
        Me.tChart1.Aspect.ElevationFloat = 345
        Me.tChart1.Aspect.RotationFloat = 345
        ' 
        ' tChart1.Axes
        ' 
        ' 
        ' tChart1.Axes.Bottom
        ' 
        Me.tChart1.Axes.Bottom.Automatic = True
        ' 
        ' tChart1.Axes.Bottom.Labels
        ' 
        ' 
        ' tChart1.Axes.Bottom.Labels.Shadow
        ' 
        Me.tChart1.Axes.Bottom.Labels.Shadow.Visible = False
        ' 
        ' tChart1.Axes.Depth
        ' 
        Me.tChart1.Axes.Depth.Automatic = True
        ' 
        ' tChart1.Axes.Depth.Labels
        ' 
        ' 
        ' tChart1.Axes.Depth.Labels.Shadow
        ' 
        Me.tChart1.Axes.Depth.Labels.Shadow.Visible = False
        ' 
        ' tChart1.Axes.DepthTop
        ' 
        Me.tChart1.Axes.DepthTop.Automatic = True
        ' 
        ' tChart1.Axes.DepthTop.Labels
        ' 
        ' 
        ' tChart1.Axes.DepthTop.Labels.Shadow
        ' 
        Me.tChart1.Axes.DepthTop.Labels.Shadow.Visible = False
        ' 
        ' tChart1.Axes.Left
        ' 
        Me.tChart1.Axes.Left.Automatic = True
        ' 
        ' tChart1.Axes.Left.Labels
        ' 
        ' 
        ' tChart1.Axes.Left.Labels.Shadow
        ' 
        Me.tChart1.Axes.Left.Labels.Shadow.Visible = False
        ' 
        ' tChart1.Axes.Right
        ' 
        Me.tChart1.Axes.Right.Automatic = True
        ' 
        ' tChart1.Axes.Right.Labels
        ' 
        ' 
        ' tChart1.Axes.Right.Labels.Shadow
        ' 
        Me.tChart1.Axes.Right.Labels.Shadow.Visible = False
        ' 
        ' tChart1.Axes.Top
        ' 
        Me.tChart1.Axes.Top.Automatic = True
        ' 
        ' tChart1.Axes.Top.Labels
        ' 
        ' 
        ' tChart1.Axes.Top.Labels.Shadow
        ' 
        Me.tChart1.Axes.Top.Labels.Shadow.Visible = False
        ' 
        ' tChart1.Footer
        ' 
        ' 
        ' tChart1.Footer.Shadow
        ' 
        Me.tChart1.Footer.Shadow.Visible = False
        ' 
        ' tChart1.Header
        ' 
        Me.tChart1.Header.Lines = New String() {"TeeChart"}
        ' 
        ' tChart1.Header.Shadow
        ' 
        Me.tChart1.Header.Shadow.Visible = False
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Shadow
        ' 
        Me.tChart1.Panel.Shadow.Visible = False
        ' 
        ' tChart1.SubFooter
        ' 
        ' 
        ' tChart1.SubFooter.Shadow
        ' 
        Me.tChart1.SubFooter.Shadow.Visible = False
        ' 
        ' tChart1.SubHeader
        ' 
        ' 
        ' tChart1.SubHeader.Shadow
        ' 
        Me.tChart1.SubHeader.Shadow.Visible = False
        ' 
        ' tChart1.Walls
        ' 
        ' 
        ' tChart1.Walls.Back
        ' 
        Me.tChart1.Walls.Back.AutoHide = False
        ' 
        ' tChart1.Walls.Back.Shadow
        ' 
        Me.tChart1.Walls.Back.Shadow.Visible = False
        ' 
        ' tChart1.Walls.Bottom
        ' 
        Me.tChart1.Walls.Bottom.AutoHide = False
        ' 
        ' tChart1.Walls.Bottom.Shadow
        ' 
        Me.tChart1.Walls.Bottom.Shadow.Visible = False
        ' 
        ' tChart1.Walls.Left
        ' 
        Me.tChart1.Walls.Left.AutoHide = False
        ' 
        ' tChart1.Walls.Left.Shadow
        ' 
        Me.tChart1.Walls.Left.Shadow.Visible = False
        ' 
        ' tChart1.Walls.Right
        ' 
        Me.tChart1.Walls.Right.AutoHide = False
        ' 
        ' tChart1.Walls.Right.Shadow
        ' 
        Me.tChart1.Walls.Right.Shadow.Visible = False
        ' 
        ' chartContainer
        ' 
        Me.chartContainer.Name = "chartContainer"
        ' 
        ' cbBase64
        ' 
        Me.cbBase64.Checked = True
        Me.cbBase64.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbBase64.Location = New System.Drawing.Point(16, 8)
        Me.cbBase64.Name = "cbBase64"
        Me.cbBase64.Size = New System.Drawing.Size(144, 24)
        Me.cbBase64.TabIndex = 0
        Me.cbBase64.Text = "Save with Template"
        ' 
        ' bApply
        ' 
        Me.bApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bApply.Location = New System.Drawing.Point(176, 8)
        Me.bApply.Name = "bApply"
        Me.bApply.Size = New System.Drawing.Size(88, 23)
        Me.bApply.TabIndex = 1
        Me.bApply.Text = "Apply Theme"
        AddHandler bApply.Click, AddressOf Me.bApply_Click
        ' 
        ' Theme_Custom
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(440, 317)
        Me.Name = "Theme_Custom"
        Me.panel1.ResumeLayout(False)
        Me.chartContainer.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub bApply_Click(ByVal sender As Object, ByVal e As System.EventArgs)

        SaveCustomTheme()
        tChart2.Clear()
        tChart2.Import.Theme.Load(themeDirectory + "\\My Theme.xml")

    End Sub

End Class

