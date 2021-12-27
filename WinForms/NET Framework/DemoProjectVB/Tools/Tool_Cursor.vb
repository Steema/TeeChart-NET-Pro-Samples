
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms




Public Class Tool_Cursor
    Inherits Samples.BaseForm
    Private lineSeries1 As Steema.TeeChart.Styles.Line
    Private lineSeries2 As Steema.TeeChart.Styles.Line
    Private label1 As System.Windows.Forms.Label
    Private label2 As System.Windows.Forms.Label
    Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
    Private WithEvents checkBox2 As System.Windows.Forms.CheckBox
    Private WithEvents button1 As System.Windows.Forms.Button
    Private axis1 As Steema.TeeChart.Axis
    Private WithEvents cursorTool1 As Steema.TeeChart.Tools.CursorTool
    Private WithEvents cursorTool2 As Steema.TeeChart.Tools.CursorTool
    Private components As System.ComponentModel.IContainer = Nothing
    
    
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        
        Me.lineSeries1.FillSampleValues(100)
        Me.lineSeries2.FillSampleValues(100)
        Me.tChart1.Axes.Left.AutomaticMinimum = False
        Me.tChart1.Axes.Left.Minimum = 0.0
        Me.lineSeries2.CustomVertAxis = Me.axis1

        ' place upper series cursor in the middle
        Me.cursorTool1.XValue = (0.5 * (Me.lineSeries1.XValues.Maximum + Me.lineSeries1.XValues.Minimum))

        Me.cursorTool1.Pen.Color = Color.Navy
        Me.cursorTool1.Pen.Style = System.Drawing.Drawing2D.DashStyle.Dash
        Me.cursorTool1.Pen.Width = 2
        
        Me.cursorTool2.Pen.Color = Color.White
        Me.cursorTool2.Pen.Style = System.Drawing.Drawing2D.DashStyle.Dot
        Me.cursorTool2.Pen.Width = 2
    End Sub 'New
     
    
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

#Region "Designer generated code"

    '/ <summary>
    '/ Required method for Designer support - do not modify
    '/ the contents of this method with the code editor.
    '/ </summary>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.lineSeries1 = New Steema.TeeChart.Styles.Line
        Me.lineSeries2 = New Steema.TeeChart.Styles.Line
        Me.axis1 = New Steema.TeeChart.Axis(Me.tChart1.Chart)
        Me.label1 = New System.Windows.Forms.Label
        Me.label2 = New System.Windows.Forms.Label
        Me.checkBox1 = New System.Windows.Forms.CheckBox
        Me.checkBox2 = New System.Windows.Forms.CheckBox
        Me.button1 = New System.Windows.Forms.Button
        Me.cursorTool1 = New Steema.TeeChart.Tools.CursorTool
        Me.cursorTool2 = New Steema.TeeChart.Tools.CursorTool
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(406, 56)
        Me.textBox1.Text = "Cursor Tool is used to display vertical and / or horizontal lines on top of chart" + "s. Cursors can be dragged by mouse or by code at runtime. They notify position c" + "hanges with the OnChange event."
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.button1)
        Me.panel1.Controls.Add(Me.checkBox2)
        Me.panel1.Controls.Add(Me.checkBox1)
        Me.panel1.Controls.Add(Me.label2)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Location = New System.Drawing.Point(0, 56)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(406, 52)
        ' 
        ' tChart1
        ' 
        ' 
        ' tChart1.Aspect
        ' 
        Me.tChart1.Aspect.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality
        Me.tChart1.Aspect.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        Me.tChart1.Aspect.View3D = False
        ' 
        ' tChart1.Axes
        ' 
        Me.tChart1.Axes.Custom.Add(Me.axis1)
        ' 
        ' tChart1.Axes.Left
        ' 
        Me.tChart1.Axes.Left.EndPosition = 50
        ' 
        ' tChart1.Axes.Left.Labels
        ' 
        ' 
        ' tChart1.Axes.Left.Labels.Font
        ' 
        ' 
        ' tChart1.Axes.Left.Labels.Font.Brush
        ' 
        Me.tChart1.Axes.Left.Labels.Font.Brush.Color = System.Drawing.Color.Red
        Me.tChart1.Axes.Left.Labels.Font.Size = 7
        Me.tChart1.Axes.Left.LogarithmicBase = 2
        ' 
        ' tChart1.Header
        ' 
        Me.tChart1.Header.Lines = New String() {"Cursor tool example"}
        Me.tChart1.Header.Visible = False
        Me.tChart1.Location = New System.Drawing.Point(0, 108)
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Brush
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.tChart1.Series.Add(Me.lineSeries1)
        Me.tChart1.Series.Add(Me.lineSeries2)
        Me.tChart1.Size = New System.Drawing.Size(406, 155)
        Me.tChart1.Tools.Add(Me.cursorTool1)
        Me.tChart1.Tools.Add(Me.cursorTool2)
        ' 
        ' lineSeries1
        ' 
        ' 
        ' lineSeries1.Brush
        ' 
        Me.lineSeries1.Brush.Color = System.Drawing.Color.Red
        ' 
        ' lineSeries1.Marks
        ' 
        ' 
        ' lineSeries1.Marks.Symbol
        ' 
        ' 
        ' lineSeries1.Marks.Symbol.Shadow
        ' 
        Me.lineSeries1.Marks.Symbol.Shadow.Height = 1
        Me.lineSeries1.Marks.Symbol.Shadow.Visible = True
        Me.lineSeries1.Marks.Symbol.Shadow.Width = 1
        ' 
        ' lineSeries1.Pointer
        ' 
        ' 
        ' lineSeries1.Pointer.Brush
        ' 
        Me.lineSeries1.Pointer.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(0, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        Me.lineSeries1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.lineSeries1.Title = "line2"
        ' 
        ' lineSeries1.XValues
        ' 
        Me.lineSeries1.XValues.DataMember = "X"
        Me.lineSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' lineSeries1.YValues
        ' 
        Me.lineSeries1.YValues.DataMember = "Y"
        ' 
        ' lineSeries2
        ' 
        ' 
        ' lineSeries2.Brush
        ' 
        Me.lineSeries2.Brush.Color = System.Drawing.Color.Green
        Me.lineSeries2.CustomVertAxis = Me.axis1
        ' 
        ' lineSeries2.Marks
        ' 
        ' 
        ' lineSeries2.Marks.Symbol
        ' 
        ' 
        ' lineSeries2.Marks.Symbol.Shadow
        ' 
        Me.lineSeries2.Marks.Symbol.Shadow.Height = 1
        Me.lineSeries2.Marks.Symbol.Shadow.Visible = True
        Me.lineSeries2.Marks.Symbol.Shadow.Width = 1
        ' 
        ' lineSeries2.Pointer
        ' 
        ' 
        ' lineSeries2.Pointer.Brush
        ' 
        Me.lineSeries2.Pointer.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(0, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        Me.lineSeries2.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.lineSeries2.Title = "line2"
        Me.lineSeries2.VertAxis = Steema.TeeChart.Styles.VerticalAxis.Custom
        ' 
        ' lineSeries2.XValues
        ' 
        Me.lineSeries2.XValues.DataMember = "X"
        Me.lineSeries2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' lineSeries2.YValues
        ' 
        Me.lineSeries2.YValues.DataMember = "Y"
        ' 
        ' axis1
        ' 
        Me.axis1.Horizontal = False
        ' 
        ' axis1.Labels
        ' 
        ' 
        ' axis1.Labels.Font
        ' 
        ' 
        ' axis1.Labels.Font.Brush
        ' 
        Me.axis1.Labels.Font.Brush.Color = System.Drawing.Color.Green
        Me.axis1.Labels.Font.Size = 7
        Me.axis1.OtherSide = False
        Me.axis1.StartPosition = 50
        ' 
        ' label1
        ' 
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(5, 7)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(0, 16)
        Me.label1.TabIndex = 0
        Me.label1.UseMnemonic = False
        ' 
        ' label2
        ' 
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(5, 26)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(0, 16)
        Me.label2.TabIndex = 1
        Me.label2.UseMnemonic = False
        ' 
        ' checkBox1
        ' 
        Me.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox1.Location = New System.Drawing.Point(107, 12)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(53, 23)
        Me.checkBox1.TabIndex = 2
        Me.checkBox1.Text = "&Snap"
        ' 
        ' checkBox2
        ' 
        Me.checkBox2.Checked = True
        Me.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox2.Location = New System.Drawing.Point(167, 12)
        Me.checkBox2.Name = "checkBox2"
        Me.checkBox2.Size = New System.Drawing.Size(72, 23)
        Me.checkBox2.TabIndex = 3
        Me.checkBox2.Text = "&Active"
        ' 
        ' button1
        ' 
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.Location = New System.Drawing.Point(247, 12)
        Me.button1.Name = "button1"
        Me.button1.TabIndex = 4
        Me.button1.Text = "&Edit..."
        ' 
        ' cursorTool1
        ' 
        Me.cursorTool1.Series = Me.lineSeries1
        Me.cursorTool1.Style = Steema.TeeChart.Tools.CursorToolStyles.Vertical
        ' 
        ' cursorTool2
        ' 
        Me.cursorTool2.FollowMouse = True
        Me.cursorTool2.Series = Me.lineSeries2
        ' 
        ' Tool_Cursor
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(406, 263)
        Me.Name = "Tool_Cursor"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub 'InitializeComponent 
#End Region


    Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox1.CheckedChanged
        Me.cursorTool1.Snap = Me.checkBox1.Checked
        Me.cursorTool1.Style = Steema.TeeChart.Tools.CursorToolStyles.Vertical
    End Sub 'checkBox1_CheckedChanged


    Private Sub checkBox2_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox2.CheckedChanged
        Me.cursorTool1.Active = Me.checkBox2.Checked
    End Sub 'checkBox2_CheckedChanged


    Private Sub tChart1_AfterDraw(ByVal sender As Object, ByVal g As Steema.TeeChart.Drawing.Graphics3D) Handles tChart1.AfterDraw
        Dim gr As Steema.TeeChart.Drawing.Graphics3D = Me.tChart1.Graphics3D
    End Sub 'tChart1_AfterDraw
    ' TODO : add custom horizontal line where the axes meet

    Private Sub cursorTool1_Change(ByVal sender As Object, ByVal e As Steema.TeeChart.Tools.CursorChangeEventArgs) Handles cursorTool1.Change
        ' show the cursor values...
        Me.label1.Text = "X=" + e.XValue.ToString("#.00")
    End Sub 'cursorTool1_Change


    Private Sub cursorTool2_Change(ByVal sender As Object, ByVal e As Steema.TeeChart.Tools.CursorChangeEventArgs) Handles cursorTool2.Change
        ' show the cursor values...
        Me.label2.Text = "X=" + e.XValue.ToString("#.00") + "; Y=" + e.YValue.ToString("#.00")
    End Sub 'cursorTool2_Change


    Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
        TeeChart.Editors.Tools.ToolsEditor.ShowEditor(Me.cursorTool1)
    End Sub 'button1_Click
End Class 'Tool_Cursor
