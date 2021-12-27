
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing

Imports System.Windows.Forms




Public Class Tool_GanttTool
    Inherits Steema.TeeChart.Samples.BaseForm
    Private WithEvents ganttSeries1 As Steema.TeeChart.Styles.Gantt
    Private WithEvents ganttTool1 As Steema.TeeChart.Tools.GanttTool
    Private WithEvents comboBox1 As System.Windows.Forms.ComboBox
    Private WithEvents button1 As System.Windows.Forms.Button
    Private WithEvents button2 As System.Windows.Forms.Button
    Private WithEvents button3 As System.Windows.Forms.Button
    Private WithEvents button4 As System.Windows.Forms.Button
    Private components As System.ComponentModel.IContainer = Nothing
    
    
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        
        ' Disable automatic sorting by date
        Me.ganttSeries1.XValues.Order = TeeChart.Styles.ValueListOrder.None
        ' Fill Gantt with sample date-time values:
        Me.ganttSeries1.Add(New System.DateTime(2002, 4, 1), New System.DateTime(2002, 4, 10), 0, "A")
        Me.ganttSeries1.Add(New System.DateTime(2002, 4, 5), New System.DateTime(2002, 4, 15), 1, "B")
        Me.ganttSeries1.Add(New System.DateTime(2002, 4, 2), New System.DateTime(2002, 4, 8), 2, "C")
        Me.ganttSeries1.Add(New System.DateTime(2002, 4, 9), New System.DateTime(2002, 4, 21), 3, "D")
        
        ' Make marks visible
        Me.ganttSeries1.Marks.Visible = True
        Me.ganttSeries1.Marks.Shadow.Height = 0
        Me.ganttSeries1.Marks.Shadow.Width = 0
        Me.ganttSeries1.Marks.Gradient.Visible = True
        
        ' Set horizontal bottom axis minimum and maximum
        Me.tChart1.Axes.Bottom.SetMinMax(New System.DateTime(2002, 4, 1), New System.DateTime(2002, 5, 1))
        
        ' Set vertical left axis minimum and maximum
        Me.tChart1.Axes.Left.SetMinMax(- 2, 5)
        Me.tChart1.Axes.Left.Grid.Centered = False
        
        ' Disable zoom
        Me.tChart1.Zoom.Allow = False
        
        ' Set horizontal daily Increment for labels and grids:
        Me.tChart1.Axes.Bottom.Increment = Convert.ToDouble(TeeChart.DateTimeSteps.OneDay) ' one day
        Me.tChart1.Axes.Bottom.Labels.Angle = 90
        Me.tChart1.Axes.Bottom.Labels.DateTimeFormat = "dd-mmm"
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
        Me.ganttSeries1 = New Steema.TeeChart.Styles.Gantt
        Me.ganttTool1 = New Steema.TeeChart.Tools.GanttTool
        Me.comboBox1 = New System.Windows.Forms.ComboBox
        Me.button1 = New System.Windows.Forms.Button
        Me.button2 = New System.Windows.Forms.Button
        Me.button3 = New System.Windows.Forms.Button
        Me.button4 = New System.Windows.Forms.Button
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(504, 32)
        Me.textBox1.Text = "Gantt Tool offers mouse interaction to drag and resize Gantt bars."
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.button4)
        Me.panel1.Controls.Add(Me.button3)
        Me.panel1.Controls.Add(Me.button2)
        Me.panel1.Controls.Add(Me.button1)
        Me.panel1.Controls.Add(Me.comboBox1)
        Me.panel1.Location = New System.Drawing.Point(0, 32)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(504, 33)
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
        ' tChart1.Header
        ' 
        Me.tChart1.Header.Lines = New String(-1) {}
        Me.tChart1.Location = New System.Drawing.Point(0, 65)
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Brush
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.tChart1.Series.Add(Me.ganttSeries1)
        Me.tChart1.Size = New System.Drawing.Size(504, 276)
        Me.tChart1.Tools.Add(Me.ganttTool1)
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
        Me.ganttSeries1.Title = "ganttSeries1"
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
        ' ganttTool1
        ' 
        Me.ganttTool1.Series = Me.ganttSeries1
        ' 
        ' comboBox1
        ' 
        Me.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboBox1.Items.AddRange(New Object() {"One day", "One week", "Half month", "One month"})
        Me.comboBox1.Location = New System.Drawing.Point(13, 6)
        Me.comboBox1.Name = "comboBox1"
        Me.comboBox1.Size = New System.Drawing.Size(101, 21)
        Me.comboBox1.TabIndex = 0
        ' 
        ' button1
        ' 
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.Location = New System.Drawing.Point(153, 6)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(34, 23)
        Me.button1.TabIndex = 1
        Me.button1.Text = "<<"
        ' 
        ' button2
        ' 
        Me.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button2.Location = New System.Drawing.Point(193, 6)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(34, 23)
        Me.button2.TabIndex = 2
        Me.button2.Text = ">>"
        ' 
        ' button3
        ' 
        Me.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button3.Location = New System.Drawing.Point(253, 6)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(34, 23)
        Me.button3.TabIndex = 3
        Me.button3.Text = "><"
        ' 
        ' button4
        ' 
        Me.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button4.Location = New System.Drawing.Point(293, 6)
        Me.button4.Name = "button4"
        Me.button4.Size = New System.Drawing.Size(34, 23)
        Me.button4.TabIndex = 4
        Me.button4.Text = "<>"
        ' 
        ' Tool_GanttTool
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(504, 341)
        Me.Name = "Tool_GanttTool"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub 'InitializeComponent 
#End Region


    Private Sub Tool_GanttTool_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.comboBox1.SelectedIndex = 0
    End Sub 'Tool_GanttTool_Load


    Private Sub comboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboBox1.SelectedIndexChanged
        Select Case Me.comboBox1.SelectedIndex
            Case 0
                Me.tChart1.Axes.Bottom.Increment = Convert.ToDouble(TeeChart.DateTimeSteps.OneDay)
            Case 1
                Me.tChart1.Axes.Bottom.Increment = Convert.ToDouble(TeeChart.DateTimeSteps.OneWeek)
            Case 2
                Me.tChart1.Axes.Bottom.Increment = Convert.ToDouble(TeeChart.DateTimeSteps.HalfMonth)
            Case 3
                Me.tChart1.Axes.Bottom.Increment = Convert.ToDouble(TeeChart.DateTimeSteps.OneMonth)
        End Select
    End Sub 'comboBox1_SelectedIndexChanged


    Private Sub ganttSeries1_GetSeriesMark(ByVal series As Steema.TeeChart.Styles.Series, ByVal e As Steema.TeeChart.Styles.GetSeriesMarkEventArgs) Handles ganttSeries1.GetSeriesMark
        ' Example, customize Series marks...
        Select Case e.ValueIndex
            Case 0
                e.MarkText = "John"
            Case 1
                e.MarkText = "Ann"
            Case 2
                e.MarkText = "David"
            Case 3
                e.MarkText = "Carol"
        End Select
    End Sub 'ganttSeries1_GetSeriesMark


    Private Sub tChart1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tChart1.MouseUp
        Me.tChart1.Header.Text = ""
    End Sub 'tChart1_MouseUp


    Private Sub ganttTool1_DragBar(ByVal sender As Object, ByVal e As Steema.TeeChart.Tools.GanttDragEventArgs) Handles ganttTool1.DragBar
        Me.tChart1.Header.Text = (CType(sender,TeeChart.Tools.GanttTool).Gantt.StartValues(e.Bar).ToString + (" " + CType(sender,TeeChart.Tools.GanttTool).Gantt.EndValues(e.Bar).ToString))
    End Sub 'ganttTool1_DragBar


    Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
        Me.tChart1.Axes.Bottom.Scroll(-1, False)
    End Sub 'button1_Click


    Private Sub button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button2.Click
        Me.tChart1.Axes.Bottom.Scroll(1, False)
    End Sub 'button2_Click


    Private Sub button3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button3.Click
        Me.tChart1.Axes.Bottom.SetMinMax(Me.tChart1.Axes.Bottom.Minimum + 1, Me.tChart1.Axes.Bottom.Maximum - 1)
    End Sub 'button3_Click


    Private Sub button4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button4.Click
        Me.tChart1.Axes.Bottom.SetMinMax(Me.tChart1.Axes.Bottom.Minimum - 1, Me.tChart1.Axes.Bottom.Maximum + 1)
    End Sub 'button4_Click
End Class 'Tool_GanttTool
