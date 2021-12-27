
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms


Public Class Commander_Editor
    Inherits Steema.TeeChart.Samples.BaseForm
    Private commander1 As Steema.TeeChart.Commander
    Private editor1 As Steema.TeeChart.Editor
    Private components As System.ComponentModel.IContainer = Nothing
    
    Public Sub New() ' This call is required by the Windows Form Designer.

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ' This can be done at design-time.
        ' This code is how to do it programatically
        editor1.Chart = tChart1
        commander1.Chart = tChart1
        commander1.Editor = editor1
        editor1.HighLightTabs = True


        editor1.HideTabs = New Steema.TeeChart.Editors.ChartEditorTabs() { _
            Steema.TeeChart.Editors.ChartEditorTabs.Axes, _
            Steema.TeeChart.Editors.ChartEditorTabs.Export, _
            Steema.TeeChart.Editors.ChartEditorTabs.Legend, _
            Steema.TeeChart.Editors.ChartEditorTabs.Main, _
            Steema.TeeChart.Editors.ChartEditorTabs.Page, _
            Steema.TeeChart.Editors.ChartEditorTabs.Panel, _
            Steema.TeeChart.Editors.ChartEditorTabs.Print, _
            Steema.TeeChart.Editors.ChartEditorTabs.Tools, _
            Steema.TeeChart.Editors.ChartEditorTabs.Walls} 
        editor1.Options = New Steema.TeeChart.Editors.ChartEditorOptions() {Steema.TeeChart.Editors.ChartEditorOptions.Add}
        editor1.DefaultTab = Steema.TeeChart.Editors.ChartEditorTabs.Aspect
        editor1.Title = "Insert your Custom Title here"
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
        Me.components = New System.ComponentModel.Container
        Me.commander1 = New Steema.TeeChart.Commander
        Me.editor1 = New Steema.TeeChart.Editor(Me.components)
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Text = ("TeeCommander has a new property to customize which chart editor to use." & vbCrLf & vbCrLf & "Click on the Edit icon to show a custom dialog.")
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.commander1)
        Me.panel1.Name = "panel1"
        '
        'tChart1
        '
        '
        'tChart1.Aspect
        '
        Me.tChart1.Aspect.ElevationFloat = 345
        Me.tChart1.Aspect.RotationFloat = 345
        Me.tChart1.Aspect.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality
        Me.tChart1.Aspect.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        '
        'tChart1.Axes
        '
        '
        'tChart1.Axes.Bottom
        '
        Me.tChart1.Axes.Bottom.Automatic = True
        '
        'tChart1.Axes.Bottom.Grid
        '
        Me.tChart1.Axes.Bottom.Grid.ZPosition = 0
        '
        'tChart1.Axes.Depth
        '
        Me.tChart1.Axes.Depth.Automatic = True
        '
        'tChart1.Axes.Depth.Grid
        '
        Me.tChart1.Axes.Depth.Grid.ZPosition = 0
        '
        'tChart1.Axes.DepthTop
        '
        Me.tChart1.Axes.DepthTop.Automatic = True
        '
        'tChart1.Axes.DepthTop.Grid
        '
        Me.tChart1.Axes.DepthTop.Grid.ZPosition = 0
        '
        'tChart1.Axes.Left
        '
        Me.tChart1.Axes.Left.Automatic = True
        '
        'tChart1.Axes.Left.Grid
        '
        Me.tChart1.Axes.Left.Grid.ZPosition = 0
        '
        'tChart1.Axes.Right
        '
        Me.tChart1.Axes.Right.Automatic = True
        '
        'tChart1.Axes.Right.Grid
        '
        Me.tChart1.Axes.Right.Grid.ZPosition = 0
        '
        'tChart1.Axes.Top
        '
        Me.tChart1.Axes.Top.Automatic = True
        '
        'tChart1.Axes.Top.Grid
        '
        Me.tChart1.Axes.Top.Grid.ZPosition = 0
        '
        'tChart1.Header
        '
        Me.tChart1.Header.Lines = New String() {"TeeChart"}
        '
        'tChart1.Legend
        '
        '
        'tChart1.Legend.Shadow
        '
        Me.tChart1.Legend.Shadow.Visible = True
        '
        'tChart1.Legend.Title
        '
        '
        'tChart1.Legend.Title.Font
        '
        Me.tChart1.Legend.Title.Font.Bold = True
        '
        'tChart1.Legend.Title.Pen
        '
        Me.tChart1.Legend.Title.Pen.Visible = False
        Me.tChart1.Name = "tChart1"
        '
        'tChart1.Panel
        '
        '
        'tChart1.Panel.Brush
        '
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(254, Byte), CType(255, Byte), CType(255, Byte), CType(255, Byte))
        '
        'tChart1.Walls
        '
        '
        'tChart1.Walls.Back
        '
        Me.tChart1.Walls.Back.AutoHide = False
        '
        'tChart1.Walls.Bottom
        '
        Me.tChart1.Walls.Bottom.AutoHide = False
        '
        'tChart1.Walls.Bottom.Pen
        '
        Me.tChart1.Walls.Bottom.Pen.Visible = False
        Me.tChart1.Walls.Bottom.Size = 5
        '
        'tChart1.Walls.Left
        '
        Me.tChart1.Walls.Left.AutoHide = False
        '
        'tChart1.Walls.Left.Pen
        '
        Me.tChart1.Walls.Left.Pen.Visible = False
        Me.tChart1.Walls.Left.Size = 5
        '
        'tChart1.Walls.Right
        '
        Me.tChart1.Walls.Right.AutoHide = False
        '
        'textBox1
        '
        Me.textBox1.Name = "textBox1"
        '
        'panel1
        '
        Me.panel1.Controls.Add(Me.commander1)
        Me.panel1.Name = "panel1"
        '
        'commander1
        '
        Me.commander1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat
        Me.commander1.DropDownArrows = True
        Me.commander1.LabelValues = True
        Me.commander1.Location = New System.Drawing.Point(0, 0)
        Me.commander1.Name = "commander1"
        Me.commander1.ShowToolTips = True
        Me.commander1.Size = New System.Drawing.Size(440, 37)
        Me.commander1.TabIndex = 0
        '
        'editor1
        '
        Me.editor1.HighLightTabs = False
        Me.editor1.Location = New System.Drawing.Point(17, 17)
        Me.editor1.Name = "editor1"
        Me.editor1.Options = Nothing
        Me.editor1.TabIndex = 0
        '
        'Commander_Editor
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(440, 317)
        Me.Name = "Commander_Editor"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub 'New

#End Region
End Class 'Commander_Editor