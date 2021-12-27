Imports System
#If VS2005 Then
Imports System.Collections.Generic
#End If
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms



Public Class Tool_DataTable
    Inherits Samples.BaseForm

    Private dataTableTool1 As Steema.TeeChart.Tools.DataTableTool
    Private button1 As Button
    Private button2 As Button
    Private checkBox1 As CheckBox
    Private button3 As Button

    Private bar1 As Steema.TeeChart.Styles.Bar
    Private bar2 As Steema.TeeChart.Styles.Bar
    Private bar3 As Steema.TeeChart.Styles.Bar

    '/ <summary>
    '/ Required designer variable.
    '/ </summary>
    Private components As System.ComponentModel.IContainer = Nothing


    Public Sub New() ' This call is required by the Windows Form Designer.
        InitializeComponent()
        bar1.FillSampleValues(6)
        bar2.FillSampleValues(6)
        bar3.FillSampleValues(6)
        bar2.SetNull(3)
    End Sub


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
    '/ the contents of this method with the code editor.
    '/ </summary>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Tool_DataTable))
        Me.bar1 = New Steema.TeeChart.Styles.Bar
        Me.bar2 = New Steema.TeeChart.Styles.Bar
        Me.bar3 = New Steema.TeeChart.Styles.Bar
        Me.dataTableTool1 = New Steema.TeeChart.Tools.DataTableTool
        Me.button1 = New System.Windows.Forms.Button
        Me.button2 = New System.Windows.Forms.Button
        Me.checkBox1 = New System.Windows.Forms.CheckBox
        Me.button3 = New System.Windows.Forms.Button
        Me.panel1.SuspendLayout()
        Me.chartContainer.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Text = resources.GetString("textBox1.Text")
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.button3)
        Me.panel1.Controls.Add(Me.checkBox1)
        Me.panel1.Controls.Add(Me.button2)
        Me.panel1.Controls.Add(Me.button1)
        Me.panel1.Size = New System.Drawing.Size(440, 61)
        ' 
        ' tChart1
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Aspect.ColorPaletteIndex = 1
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
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Legend.CheckBoxes = True
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
        ' 
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(216, Byte), Integer))
        ' 
        ' 
        ' 
        Me.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.tChart1.Panel.Brush.Gradient.ExtendedColorPalette = Nothing
        Me.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tChart1.Panel.Brush.Gradient.Sigma = True
        Me.tChart1.Panel.Brush.Gradient.SigmaFocus = 1.0!
        Me.tChart1.Panel.Brush.Gradient.SigmaScale = 0.8!
        Me.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tChart1.Panel.Brush.Gradient.UseMiddle = True
        Me.tChart1.Panel.Brush.Gradient.Visible = True
        Me.tChart1.Series.Add(Me.bar1)
        Me.tChart1.Series.Add(Me.bar2)
        Me.tChart1.Series.Add(Me.bar3)
        Me.tChart1.Size = New System.Drawing.Size(440, 183)
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
        Me.tChart1.Tools.Add(Me.dataTableTool1)
        ' 
        ' chartContainer
        ' 
        Me.chartContainer.Location = New System.Drawing.Point(0, 134)
        Me.chartContainer.Size = New System.Drawing.Size(440, 183)
        ' 
        ' bar1
        ' 
        ' 
        ' 
        ' 
        Me.bar1.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.bar1.ColorEach = False
        ' 
        ' 
        ' 
        Me.bar1.Gradient.ExtendedColorPalette = Nothing
        Me.bar1.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.bar1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None
        Me.bar1.Marks.Callout.ArrowHeadSize = 8
        ' 
        ' 
        ' 
        Me.bar1.Marks.Callout.Brush.Color = System.Drawing.Color.Black
        Me.bar1.Marks.Callout.Distance = 0
        Me.bar1.Marks.Callout.Draw3D = False
        Me.bar1.Marks.Callout.Length = 20
        Me.bar1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        ' 
        ' 
        ' 
        Me.bar1.Title = "bar1"
        ' 
        ' 
        ' 
        Me.bar1.XValues.DataMember = "X"
        Me.bar1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' 
        ' 
        Me.bar1.YValues.DataMember = "Bar"
        ' 
        ' bar2
        ' 
        ' 
        ' 
        ' 
        Me.bar2.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.bar2.ColorEach = False
        ' 
        ' 
        ' 
        Me.bar2.Gradient.ExtendedColorPalette = Nothing
        Me.bar2.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer))
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.bar2.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None
        Me.bar2.Marks.Callout.ArrowHeadSize = 8
        ' 
        ' 
        ' 
        Me.bar2.Marks.Callout.Brush.Color = System.Drawing.Color.Black
        Me.bar2.Marks.Callout.Distance = 0
        Me.bar2.Marks.Callout.Draw3D = False
        Me.bar2.Marks.Callout.Length = 20
        Me.bar2.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        ' 
        ' 
        ' 
        Me.bar2.Title = "bar2"
        ' 
        ' 
        ' 
        Me.bar2.XValues.DataMember = "X"
        Me.bar2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' 
        ' 
        Me.bar2.YValues.DataMember = "Bar"
        ' 
        ' bar3
        ' 
        ' 
        ' 
        ' 
        Me.bar3.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.bar3.ColorEach = False
        ' 
        ' 
        ' 
        Me.bar3.Gradient.ExtendedColorPalette = Nothing
        Me.bar3.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer))
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.bar3.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None
        Me.bar3.Marks.Callout.ArrowHeadSize = 8
        ' 
        ' 
        ' 
        Me.bar3.Marks.Callout.Brush.Color = System.Drawing.Color.Black
        Me.bar3.Marks.Callout.Distance = 0
        Me.bar3.Marks.Callout.Draw3D = False
        Me.bar3.Marks.Callout.Length = 20
        Me.bar3.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        ' 
        ' 
        ' 
        Me.bar3.Title = "bar3"
        ' 
        ' 
        ' 
        Me.bar3.XValues.DataMember = "X"
        Me.bar3.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' 
        ' 
        Me.bar3.YValues.DataMember = "Bar"
        ' 
        ' dataTableTool1
        ' 
        ' 
        ' 
        ' 
        Me.dataTableTool1.ColumnPen.Color = System.Drawing.Color.Black
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.dataTableTool1.RowPen.Color = System.Drawing.Color.Black
        Me.dataTableTool1.Top = 103
        ' 
        ' button1
        ' 
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.Location = New System.Drawing.Point(12, 16)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(111, 23)
        Me.button1.TabIndex = 0
        Me.button1.Text = "Vert <-> Horiz"
#If VS2005 Then
        Me.button1.UseVisualStyleBackColor = True
#End If
        AddHandler button1.Click, AddressOf Me.button1_Click
        ' 
        ' button2
        ' 
        Me.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button2.Location = New System.Drawing.Point(129, 16)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(111, 23)
        Me.button2.TabIndex = 1
        Me.button2.Text = "Axis <-> Other axis"
#If VS2005 Then
        Me.button2.UseVisualStyleBackColor = True
#End If
 AddHandler button2.Click, AddressOf Me.button2_Click
        ' 
        ' checkBox1
        ' 
#If VS2005 Then
        Me.checkBox1.AutoSize = True
#End If
        Me.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox1.Location = New System.Drawing.Point(270, 19)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(83, 17)
        Me.checkBox1.TabIndex = 2
        Me.checkBox1.Text = "Axis inverted"
#If VS2005 Then
        Me.checkBox1.UseVisualStyleBackColor = True
#End If
        AddHandler checkBox1.CheckedChanged, AddressOf Me.checkBox1_CheckedChanged
        ' 
        ' button3
        ' 
        Me.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button3.Location = New System.Drawing.Point(359, 16)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(75, 23)
        Me.button3.TabIndex = 3
        Me.button3.Text = "Edit tool"
#If VS2005 Then
        Me.button3.UseVisualStyleBackColor = True
#End If
        AddHandler button3.Click, AddressOf Me.button3_Click
        ' 
        ' Tool_DataTable
        ' 
        Me.ClientSize = New System.Drawing.Size(440, 317)
        Me.Name = "Tool_DataTable"
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.chartContainer.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim style As Type
        If tChart1(0).YValues Is tChart1(0).mandatory Then
            style = GetType(Styles.HorizBar)
        Else
            style = GetType(Styles.Bar)
        End If

        For t As Integer = 0 To tChart1.Series.Count - 1
            Dim s As Styles.Series = tChart1(t)
            Styles.Series.ChangeType(s, style)
        Next t
    End Sub

    Private Sub button2_Click(ByVal sender As Object, ByVal e As EventArgs)
        For t As Integer = 0 To tChart1.Series.Count - 1
            Dim vals As Styles.ValueList = tChart1(t).mandatory
            If (vals Is tChart1(t).YValues) Then
                If (tChart1(t).HorizAxis = Steema.TeeChart.Styles.HorizontalAxis.Bottom) Then
                    tChart1(t).HorizAxis = Steema.TeeChart.Styles.HorizontalAxis.Top
                Else
                    tChart1(t).HorizAxis = Steema.TeeChart.Styles.HorizontalAxis.Bottom
                End If
            ElseIf (tChart1(t).VertAxis = Steema.TeeChart.Styles.VerticalAxis.Left) Then
                tChart1(t).VertAxis = Steema.TeeChart.Styles.VerticalAxis.Right
            Else
                tChart1(t).VertAxis = Steema.TeeChart.Styles.VerticalAxis.Left
            End If
            Exit For
        Next t
    End Sub

    Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)

        For t As Integer = 0 To tChart1.Series.Count - 1
            If (tChart1(t).Visible) Then
                If tChart1(t).mandatory Is tChart1(t).YValues Then
                    tChart1(t).GetHorizAxis.Inverted = checkBox1.Checked
                Else
                    tChart1(t).GetVertAxis.Inverted = checkBox1.Checked
                End If
                Exit For
            End If
        Next t
    End Sub

    Private Sub button3_Click(ByVal sender As Object, ByVal e As EventArgs)
        Editors.Tools.ToolsEditor.ShowEditor(dataTableTool1)
    End Sub

End Class

