
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms


Public Class Series_Groups
    Inherits Steema.TeeChart.Samples.BaseNoChart
    Private chartListBox1 As Steema.TeeChart.ChartListBox
    Private tChart1 As Steema.TeeChart.TChart
    Private checkBox1 As System.Windows.Forms.CheckBox
    Private checkBox2 As System.Windows.Forms.CheckBox
    Private splitter1 As System.Windows.Forms.Splitter
    Private comboBox1 As System.Windows.Forms.ComboBox
    Private button1 As System.Windows.Forms.Button
    Private components As System.ComponentModel.IContainer = Nothing
    Private group1, group2 As Styles.SeriesGroup
    Private editor1 As Steema.TeeChart.Editor
    
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Dim t As Integer = 0
        Do While (t < 10)
            Dim line As Styles.Line = New Styles.Line
            line.Title = ("line" + t.ToString)
            tChart1.Series.Add(line)
            line.FillSampleValues()
            t = (t + 1)
        Loop
        ' Create two "Series Groups", and add some series to each group...
        group1 = tChart1.Series.AddGroup("First group")
        group1.Series.Add(tChart1.Series(0))
        group1.Series.Add(tChart1.Series(2))
        group1.Series.Add(tChart1.Series(4))
        group1.Series.Add(tChart1.Series(6))
        group1.Series.Add(tChart1.Series(8))
        group2 = tChart1.Series.AddGroup("Second group")
        group2.Series.Add(tChart1.Series(1))
        group2.Series.Add(tChart1.Series(3))
        group2.Series.Add(tChart1.Series(5))
        group2.Series.Add(tChart1.Series(7))
        group2.Series.Add(tChart1.Series(9))
        ' Show all series in first group
        tChart1.Series.Groups(0).Show()
        ' Hide all series in second group
        tChart1.Series.Groups(1).Hide()
        ' Tell the Chart ListBox to show the Group1 only...
        chartListBox1.SeriesGroup = group1
        ' Add all groups to combo-box for selection...
        comboBox1.Items.Clear()
        t = 0
        Do While (t < tChart1.Series.Groups.Count)
            comboBox1.Items.Add(tChart1.Series.Groups(t))
            t = (t + 1)
        Loop
        comboBox1.SelectedIndex = 0
        Dim options() As Steema.TeeChart.Editors.ChartEditorOptions = New Steema.TeeChart.Editors.ChartEditorOptions(8) {}
        options(0) = Steema.TeeChart.Editors.ChartEditorOptions.Help
        options(1) = Steema.TeeChart.Editors.ChartEditorOptions.Add
        options(2) = Steema.TeeChart.Editors.ChartEditorOptions.Delete
        options(3) = Steema.TeeChart.Editors.ChartEditorOptions.Change
        options(4) = Steema.TeeChart.Editors.ChartEditorOptions.Clone
        options(5) = Steema.TeeChart.Editors.ChartEditorOptions.Groups
        options(6) = Steema.TeeChart.Editors.ChartEditorOptions.GroupAll
        options(7) = Steema.TeeChart.Editors.ChartEditorOptions.Title
        editor1.Options = options

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
        Me.chartListBox1 = New Steema.TeeChart.ChartListBox(Me.components)
        Me.tChart1 = New Steema.TeeChart.TChart
        Me.checkBox1 = New System.Windows.Forms.CheckBox
        Me.checkBox2 = New System.Windows.Forms.CheckBox
        Me.splitter1 = New System.Windows.Forms.Splitter
        Me.comboBox1 = New System.Windows.Forms.ComboBox
        Me.button1 = New System.Windows.Forms.Button
        Me.editor1 = New Steema.TeeChart.Editor(Me.components)
        Me.panel1.SuspendLayout()
        Me.panel2.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(513, 62)
        Me.textBox1.Text = ("Series components can be grouped to easily show / hide multiple series at once. " & vbCr + ("" & vbLf & "The Chart editor, when groups are enabled, show the group names." & vbCrLf & vbCrLf & "tChart1.Series.AddGroup(""First group"")"))
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.button1)
        Me.panel1.Controls.Add(Me.comboBox1)
        Me.panel1.Controls.Add(Me.checkBox2)
        Me.panel1.Controls.Add(Me.checkBox1)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(513, 42)
        ' 
        ' panel2
        ' 
        Me.panel2.Controls.Add(Me.splitter1)
        Me.panel2.Controls.Add(Me.tChart1)
        Me.panel2.Controls.Add(Me.chartListBox1)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(513, 188)
        ' 
        ' chartListBox1
        ' 
        Me.chartListBox1.AllowDrop = True
        Me.chartListBox1.Chart = Me.tChart1
        Me.chartListBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.chartListBox1.IntegralHeight = False
        Me.chartListBox1.Location = New System.Drawing.Point(0, 0)
        Me.chartListBox1.Name = "chartListBox1"
        Me.chartListBox1.OtherItems = Nothing
        Me.chartListBox1.SeriesGroup = Nothing
        Me.chartListBox1.Size = New System.Drawing.Size(112, 188)
        Me.chartListBox1.TabIndex = 0
        ' 
        ' tChart1
        ' 
        ' 
        ' tChart1.Aspect
        ' 
        Me.tChart1.Aspect.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality
        Me.tChart1.Aspect.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        ' 
        ' tChart1.Axes
        ' 
        ' 
        ' tChart1.Axes.Bottom
        ' 
        ' 
        ' tChart1.Axes.Bottom.Grid
        ' 
        Me.tChart1.Axes.Bottom.Grid.ZPosition = 0
        ' 
        ' tChart1.Axes.Bottom.Labels
        ' 
        ' 
        ' tChart1.Axes.Bottom.Labels.Font
        ' 
        ' 
        ' tChart1.Axes.Bottom.Labels.Font.Shadow
        ' 
        Me.tChart1.Axes.Bottom.Labels.Font.Shadow.Visible = False
        ' 
        ' tChart1.Axes.Bottom.Labels.Shadow
        ' 
        Me.tChart1.Axes.Bottom.Labels.Shadow.Visible = False
        ' 
        ' tChart1.Axes.Bottom.Title
        ' 
        ' 
        ' tChart1.Axes.Bottom.Title.Font
        ' 
        ' 
        ' tChart1.Axes.Bottom.Title.Font.Shadow
        ' 
        Me.tChart1.Axes.Bottom.Title.Font.Shadow.Visible = False
        ' 
        ' tChart1.Axes.Bottom.Title.Shadow
        ' 
        Me.tChart1.Axes.Bottom.Title.Shadow.Visible = False
        ' 
        ' tChart1.Axes.Depth
        ' 
        ' 
        ' tChart1.Axes.Depth.Grid
        ' 
        Me.tChart1.Axes.Depth.Grid.ZPosition = 0
        ' 
        ' tChart1.Axes.Depth.Labels
        ' 
        ' 
        ' tChart1.Axes.Depth.Labels.Font
        ' 
        ' 
        ' tChart1.Axes.Depth.Labels.Font.Shadow
        ' 
        Me.tChart1.Axes.Depth.Labels.Font.Shadow.Visible = False
        ' 
        ' tChart1.Axes.Depth.Labels.Shadow
        ' 
        Me.tChart1.Axes.Depth.Labels.Shadow.Visible = False
        ' 
        ' tChart1.Axes.Depth.Title
        ' 
        ' 
        ' tChart1.Axes.Depth.Title.Font
        ' 
        ' 
        ' tChart1.Axes.Depth.Title.Font.Shadow
        ' 
        Me.tChart1.Axes.Depth.Title.Font.Shadow.Visible = False
        ' 
        ' tChart1.Axes.Depth.Title.Shadow
        ' 
        Me.tChart1.Axes.Depth.Title.Shadow.Visible = False
        ' 
        ' tChart1.Axes.DepthTop
        ' 
        ' 
        ' tChart1.Axes.DepthTop.Grid
        ' 
        Me.tChart1.Axes.DepthTop.Grid.ZPosition = 0
        ' 
        ' tChart1.Axes.DepthTop.Labels
        ' 
        ' 
        ' tChart1.Axes.DepthTop.Labels.Font
        ' 
        ' 
        ' tChart1.Axes.DepthTop.Labels.Font.Shadow
        ' 
        Me.tChart1.Axes.DepthTop.Labels.Font.Shadow.Visible = False
        ' 
        ' tChart1.Axes.DepthTop.Labels.Shadow
        ' 
        Me.tChart1.Axes.DepthTop.Labels.Shadow.Visible = False
        ' 
        ' tChart1.Axes.DepthTop.Title
        ' 
        ' 
        ' tChart1.Axes.DepthTop.Title.Font
        ' 
        ' 
        ' tChart1.Axes.DepthTop.Title.Font.Shadow
        ' 
        Me.tChart1.Axes.DepthTop.Title.Font.Shadow.Visible = False
        ' 
        ' tChart1.Axes.DepthTop.Title.Shadow
        ' 
        Me.tChart1.Axes.DepthTop.Title.Shadow.Visible = False
        ' 
        ' tChart1.Axes.Left
        ' 
        ' 
        ' tChart1.Axes.Left.Grid
        ' 
        Me.tChart1.Axes.Left.Grid.ZPosition = 0
        ' 
        ' tChart1.Axes.Left.Labels
        ' 
        ' 
        ' tChart1.Axes.Left.Labels.Font
        ' 
        ' 
        ' tChart1.Axes.Left.Labels.Font.Shadow
        ' 
        Me.tChart1.Axes.Left.Labels.Font.Shadow.Visible = False
        ' 
        ' tChart1.Axes.Left.Labels.Shadow
        ' 
        Me.tChart1.Axes.Left.Labels.Shadow.Visible = False
        ' 
        ' tChart1.Axes.Left.Title
        ' 
        ' 
        ' tChart1.Axes.Left.Title.Font
        ' 
        ' 
        ' tChart1.Axes.Left.Title.Font.Shadow
        ' 
        Me.tChart1.Axes.Left.Title.Font.Shadow.Visible = False
        ' 
        ' tChart1.Axes.Left.Title.Shadow
        ' 
        Me.tChart1.Axes.Left.Title.Shadow.Visible = False
        ' 
        ' tChart1.Axes.Right
        ' 
        ' 
        ' tChart1.Axes.Right.Grid
        ' 
        Me.tChart1.Axes.Right.Grid.ZPosition = 0
        ' 
        ' tChart1.Axes.Right.Labels
        ' 
        ' 
        ' tChart1.Axes.Right.Labels.Font
        ' 
        ' 
        ' tChart1.Axes.Right.Labels.Font.Shadow
        ' 
        Me.tChart1.Axes.Right.Labels.Font.Shadow.Visible = False
        ' 
        ' tChart1.Axes.Right.Labels.Shadow
        ' 
        Me.tChart1.Axes.Right.Labels.Shadow.Visible = False
        ' 
        ' tChart1.Axes.Right.Title
        ' 
        ' 
        ' tChart1.Axes.Right.Title.Font
        ' 
        ' 
        ' tChart1.Axes.Right.Title.Font.Shadow
        ' 
        Me.tChart1.Axes.Right.Title.Font.Shadow.Visible = False
        ' 
        ' tChart1.Axes.Right.Title.Shadow
        ' 
        Me.tChart1.Axes.Right.Title.Shadow.Visible = False
        ' 
        ' tChart1.Axes.Top
        ' 
        ' 
        ' tChart1.Axes.Top.Grid
        ' 
        Me.tChart1.Axes.Top.Grid.ZPosition = 0
        ' 
        ' tChart1.Axes.Top.Labels
        ' 
        ' 
        ' tChart1.Axes.Top.Labels.Font
        ' 
        ' 
        ' tChart1.Axes.Top.Labels.Font.Shadow
        ' 
        Me.tChart1.Axes.Top.Labels.Font.Shadow.Visible = False
        ' 
        ' tChart1.Axes.Top.Labels.Shadow
        ' 
        Me.tChart1.Axes.Top.Labels.Shadow.Visible = False
        ' 
        ' tChart1.Axes.Top.Title
        ' 
        ' 
        ' tChart1.Axes.Top.Title.Font
        ' 
        ' 
        ' tChart1.Axes.Top.Title.Font.Shadow
        ' 
        Me.tChart1.Axes.Top.Title.Font.Shadow.Visible = False
        ' 
        ' tChart1.Axes.Top.Title.Shadow
        ' 
        Me.tChart1.Axes.Top.Title.Shadow.Visible = False
        Me.tChart1.Dock = System.Windows.Forms.DockStyle.Fill
        ' 
        ' tChart1.Footer
        ' 
        ' 
        ' tChart1.Footer.Font
        ' 
        ' 
        ' tChart1.Footer.Font.Shadow
        ' 
        Me.tChart1.Footer.Font.Shadow.Visible = False
        ' 
        ' tChart1.Footer.Shadow
        ' 
        Me.tChart1.Footer.Shadow.Visible = False
        ' 
        ' tChart1.Header
        ' 
        ' 
        ' tChart1.Header.Font
        ' 
        ' 
        ' tChart1.Header.Font.Shadow
        ' 
        Me.tChart1.Header.Font.Shadow.Visible = False
        Me.tChart1.Header.Lines = New String() {"TeeChart"}
        ' 
        ' tChart1.Header.Shadow
        ' 
        Me.tChart1.Header.Shadow.Visible = False
        Me.tChart1.Header.Visible = False
        ' 
        ' tChart1.Legend
        ' 
        ' 
        ' tChart1.Legend.Font
        ' 
        ' 
        ' tChart1.Legend.Font.Shadow
        ' 
        Me.tChart1.Legend.Font.Shadow.Visible = False
        ' 
        ' tChart1.Legend.Title
        ' 
        ' 
        ' tChart1.Legend.Title.Font
        ' 
        Me.tChart1.Legend.Title.Font.Bold = True
        ' 
        ' tChart1.Legend.Title.Font.Shadow
        ' 
        Me.tChart1.Legend.Title.Font.Shadow.Visible = False
        ' 
        ' tChart1.Legend.Title.Pen
        ' 
        Me.tChart1.Legend.Title.Pen.Visible = False
        ' 
        ' tChart1.Legend.Title.Shadow
        ' 
        Me.tChart1.Legend.Title.Shadow.Visible = False
        Me.tChart1.Location = New System.Drawing.Point(112, 0)
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Brush
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(254, Byte), CType(255, Byte), CType(255, Byte), CType(255, Byte))
        ' 
        ' tChart1.Panel.Shadow
        ' 
        Me.tChart1.Panel.Shadow.Visible = False
        Me.tChart1.Size = New System.Drawing.Size(401, 188)
        ' 
        ' tChart1.SubFooter
        ' 
        ' 
        ' tChart1.SubFooter.Font
        ' 
        ' 
        ' tChart1.SubFooter.Font.Shadow
        ' 
        Me.tChart1.SubFooter.Font.Shadow.Visible = False
        ' 
        ' tChart1.SubFooter.Shadow
        ' 
        Me.tChart1.SubFooter.Shadow.Visible = False
        ' 
        ' tChart1.SubHeader
        ' 
        ' 
        ' tChart1.SubHeader.Font
        ' 
        ' 
        ' tChart1.SubHeader.Font.Shadow
        ' 
        Me.tChart1.SubHeader.Font.Shadow.Visible = False
        ' 
        ' tChart1.SubHeader.Shadow
        ' 
        Me.tChart1.SubHeader.Shadow.Visible = False
        Me.tChart1.TabIndex = 1
        ' 
        ' tChart1.Walls
        ' 
        ' 
        ' tChart1.Walls.Back
        ' 
        Me.tChart1.Walls.Back.AutoHide = False
        ' 
        ' tChart1.Walls.Back.Brush
        ' 
        Me.tChart1.Walls.Back.Brush.Color = System.Drawing.Color.FromArgb(CType(254, Byte), CType(224, Byte), CType(224, Byte), CType(224, Byte))
        ' 
        ' tChart1.Walls.Back.Shadow
        ' 
        Me.tChart1.Walls.Back.Shadow.Visible = False
        Me.tChart1.Walls.Back.Transparent = False
        ' 
        ' tChart1.Walls.Bottom
        ' 
        Me.tChart1.Walls.Bottom.AutoHide = False
        ' 
        ' tChart1.Walls.Bottom.Pen
        ' 
        Me.tChart1.Walls.Bottom.Pen.Visible = False
        ' 
        ' tChart1.Walls.Bottom.Shadow
        ' 
        Me.tChart1.Walls.Bottom.Shadow.Visible = False
        Me.tChart1.Walls.Bottom.Size = 5
        ' 
        ' tChart1.Walls.Left
        ' 
        Me.tChart1.Walls.Left.AutoHide = False
        ' 
        ' tChart1.Walls.Left.Brush
        ' 
        Me.tChart1.Walls.Left.Brush.Color = System.Drawing.Color.FromArgb(CType(254, Byte), CType(255, Byte), CType(255, Byte), CType(224, Byte))
        ' 
        ' tChart1.Walls.Left.Pen
        ' 
        Me.tChart1.Walls.Left.Pen.Visible = False
        ' 
        ' tChart1.Walls.Left.Shadow
        ' 
        Me.tChart1.Walls.Left.Shadow.Visible = False
        Me.tChart1.Walls.Left.Size = 5
        ' 
        ' tChart1.Walls.Right
        ' 
        Me.tChart1.Walls.Right.AutoHide = False
        ' 
        ' tChart1.Walls.Right.Shadow
        ' 
        Me.tChart1.Walls.Right.Shadow.Visible = False
        ' 
        ' checkBox1
        ' 
        Me.checkBox1.Checked = True
        Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox1.Location = New System.Drawing.Point(256, 2)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(147, 21)
        Me.checkBox1.TabIndex = 2
        Me.checkBox1.Text = "Show &groups at editor"
        ' 
        ' checkBox2
        ' 
        Me.checkBox2.Checked = True
        Me.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox2.Location = New System.Drawing.Point(256, 18)
        Me.checkBox2.Name = "checkBox2"
        Me.checkBox2.Size = New System.Drawing.Size(176, 21)
        Me.checkBox2.TabIndex = 3
        Me.checkBox2.Text = "Show ""&All groups"" at editor"
        ' 
        ' splitter1
        ' 
        Me.splitter1.Location = New System.Drawing.Point(112, 0)
        Me.splitter1.Name = "splitter1"
        Me.splitter1.Size = New System.Drawing.Size(3, 188)
        Me.splitter1.TabIndex = 2
        Me.splitter1.TabStop = False
        ' 
        ' comboBox1
        ' 
        Me.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboBox1.Location = New System.Drawing.Point(8, 11)
        Me.comboBox1.Name = "comboBox1"
        Me.comboBox1.Size = New System.Drawing.Size(120, 21)
        Me.comboBox1.TabIndex = 0
        AddHandler comboBox1.SelectedIndexChanged, AddressOf Me.comboBox1_SelectedIndexChanged
        ' 
        ' button1
        ' 
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.Location = New System.Drawing.Point(152, 8)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(80, 24)
        Me.button1.TabIndex = 1
        Me.button1.Text = "&Edit..."
        AddHandler button1.Click, AddressOf Me.button1_Click
        ' 
        ' editor1
        ' 
        Me.editor1.Chart = Me.tChart1
        Me.editor1.HighLightTabs = False
        Me.editor1.Location = New System.Drawing.Point(17, 17)
        Me.editor1.Name = "editor1"
        Me.editor1.Options = Nothing
        Me.editor1.TabIndex = 0
        ' 
        ' Series_Groups
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(513, 292)
        Me.Name = "Series_Groups"
        Me.panel1.ResumeLayout(False)
        Me.panel2.ResumeLayout(False)

    End Sub
#End Region


    Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim options As ArrayList = New ArrayList
        options.AddRange(editor1.Options)
        If (checkBox1.Checked _
                    AndAlso (options.IndexOf(Steema.TeeChart.Editors.ChartEditorOptions.Groups) < 0)) Then
            options.Add(Steema.TeeChart.Editors.ChartEditorOptions.Groups)
        End If
        If Not checkBox1.Checked Then
            options.Remove(Steema.TeeChart.Editors.ChartEditorOptions.Groups)
        End If
        If (checkBox2.Checked _
                    AndAlso (options.IndexOf(Steema.TeeChart.Editors.ChartEditorOptions.GroupAll) < 0)) Then
            options.Add(Steema.TeeChart.Editors.ChartEditorOptions.GroupAll)
        End If
        If Not checkBox2.Checked Then
            options.Remove(Steema.TeeChart.Editors.ChartEditorOptions.GroupAll)
        End If
        editor1.Options = CType(options.ToArray(GetType(Steema.TeeChart.Editors.ChartEditorOptions)), Steema.TeeChart.Editors.ChartEditorOptions())
        editor1.ShowModal(Me)
    End Sub

    Private Sub comboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        ' Hide series in current group
        chartListBox1.SeriesGroup.Hide()
        ' Change series group to show at listbox...
        chartListBox1.SeriesGroup = CType(comboBox1.Items(comboBox1.SelectedIndex), Styles.SeriesGroup)
        ' Show series in newly selected group
        chartListBox1.SeriesGroup.Show()
    End Sub


End Class 'Series_Groups