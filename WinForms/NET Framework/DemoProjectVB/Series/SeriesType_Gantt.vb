
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing

Imports System.Windows.Forms




Public Class SeriesType_Gantt
    Inherits Samples.BaseForm
    Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
    Private WithEvents button1 As System.Windows.Forms.Button
    Private ganttSeries1 As Steema.TeeChart.Styles.Gantt
    Private gridBand1 As Steema.TeeChart.Tools.GridBand
    Private components As System.ComponentModel.IContainer = Nothing
    
    
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        
        ganttSeries1.FillSampleValues(10)
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
        Me.checkBox1 = New System.Windows.Forms.CheckBox
        Me.button1 = New System.Windows.Forms.Button
        Me.ganttSeries1 = New Steema.TeeChart.Styles.Gantt
        Me.gridBand1 = New Steema.TeeChart.Tools.GridBand
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(466, 72)
        Me.textBox1.Text = "For scheduling applications, the Gantt chart style allows points with start and e" + "nd dates." + vbCr + vbLf + vbCr + vbLf + "Options include point style, label, marks, color, border, pattern, " + "drag and drop of bars, connecting lines, click events, etc."
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.button1)
        Me.panel1.Controls.Add(Me.checkBox1)
        Me.panel1.Location = New System.Drawing.Point(0, 72)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(466, 41)
        ' 
        ' tChart1
        ' 
        ' 
        ' tChart1.Aspect
        ' 
        Me.tChart1.Aspect.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality
        Me.tChart1.Aspect.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        ' 
        ' tChart1.Header
        ' 
        Me.tChart1.Header.Lines = New String() {"Gantt - Scheduling"}
        Me.tChart1.Location = New System.Drawing.Point(0, 113)
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Brush
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.tChart1.Series.Add(Me.ganttSeries1)
        Me.tChart1.Size = New System.Drawing.Size(466, 173)
        Me.tChart1.Tools.Add(Me.gridBand1)
        ' 
        ' tChart1.Walls
        ' 
        ' 
        ' tChart1.Walls.Back
        ' 
        ' 
        ' tChart1.Walls.Back.Brush
        ' 
        Me.tChart1.Walls.Back.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.tChart1.Walls.Back.Transparent = False
        ' 
        ' tChart1.Walls.Bottom
        ' 
        ' 
        ' tChart1.Walls.Bottom.Pen
        ' 
        Me.tChart1.Walls.Bottom.Pen.Visible = False
        Me.tChart1.Walls.Bottom.Size = 3
        ' 
        ' tChart1.Walls.Left
        ' 
        ' 
        ' tChart1.Walls.Left.Pen
        ' 
        Me.tChart1.Walls.Left.Pen.Visible = False
        Me.tChart1.Walls.Left.Size = 3
        ' 
        ' checkBox1
        ' 
        Me.checkBox1.Checked = True
        Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox1.Location = New System.Drawing.Point(20, 7)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(52, 21)
        Me.checkBox1.TabIndex = 0
        Me.checkBox1.Text = "&3D"
        ' 
        ' button1
        ' 
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.Location = New System.Drawing.Point(113, 7)
        Me.button1.Name = "button1"
        Me.button1.TabIndex = 5
        Me.button1.Text = "&Edit..."
        ' 
        ' ganttSeries1
        ' 
        Me.ganttSeries1.ColorEach = True
        ' 
        ' ganttSeries1.EndValues
        ' 
        Me.ganttSeries1.EndValues.DataMember = "End"
        Me.ganttSeries1.EndValues.DateTime = True
        Me.ganttSeries1.LabelMember = "Labels"
        ' 
        ' ganttSeries1.LinePen
        ' 
        Me.ganttSeries1.LinePen.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(64, System.Byte), CType(64, System.Byte), CType(64, System.Byte))
        ' 
        ' ganttSeries1.Marks
        ' 
        ' 
        ' ganttSeries1.Marks.Symbol
        ' 
        ' 
        ' ganttSeries1.Marks.Symbol.Shadow
        ' 
        Me.ganttSeries1.Marks.Symbol.Shadow.Height = 1
        Me.ganttSeries1.Marks.Symbol.Shadow.Visible = True
        Me.ganttSeries1.Marks.Symbol.Shadow.Width = 1
        ' 
        ' ganttSeries1.NextTasks
        ' 
        Me.ganttSeries1.NextTasks.DataMember = "NextTask"
        ' 
        ' ganttSeries1.Pointer
        ' 
        ' 
        ' ganttSeries1.Pointer.Brush
        ' 
        Me.ganttSeries1.Pointer.Brush.Color = System.Drawing.Color.Red
        Me.ganttSeries1.Pointer.Brush.ForegroundColor = System.Drawing.Color.Empty
        Me.ganttSeries1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        ' 
        ' ganttSeries1.StartValues
        ' 
        Me.ganttSeries1.StartValues.DataMember = "Start"
        Me.ganttSeries1.StartValues.DateTime = True
        Me.ganttSeries1.Title = "gantt1"
        ' 
        ' ganttSeries1.StartValues
        ' 
        Me.ganttSeries1.XValues.DataMember = "Start"
        Me.ganttSeries1.XValues.DateTime = True
        ' 
        ' ganttSeries1.YValues
        ' 
        Me.ganttSeries1.YValues.DataMember = "Y"
        ' 
        ' gridBand1
        ' 
        Me.gridBand1.Axis = Me.tChart1.Axes.Left
        ' 
        ' gridBand1.Band1
        ' 
        Me.gridBand1.Band1.Color = System.Drawing.Color.FromArgb(CType(76, System.Byte), CType(192, System.Byte), CType(192, System.Byte), CType(192, System.Byte))
        ' 
        ' gridBand1.Band2
        ' 
        Me.gridBand1.Band2.Color = System.Drawing.Color.FromArgb(CType(76, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        ' 
        ' SeriesType_Gantt
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(466, 286)
        Me.Name = "SeriesType_Gantt"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub 'InitializeComponent 
#End Region


    Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox1.CheckedChanged
        tChart1.Aspect.View3D = checkBox1.Checked
    End Sub 'checkBox1_CheckedChanged


    Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
        TeeChart.Editors.SeriesEditor.ShowEditor(Me.ganttSeries1)
    End Sub 'button1_Click
End Class 'SeriesType_Gantt
