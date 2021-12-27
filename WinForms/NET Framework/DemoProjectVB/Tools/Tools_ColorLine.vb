
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing

Imports System.Windows.Forms




Public Class Tools_ColorLine
    Inherits Samples.BaseForm
    Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
    Private WithEvents checkBox2 As System.Windows.Forms.CheckBox
    Private WithEvents checkBox3 As System.Windows.Forms.CheckBox
    Private WithEvents checkBox4 As System.Windows.Forms.CheckBox
    Private WithEvents checkBox5 As System.Windows.Forms.CheckBox
    Private WithEvents checkBox6 As System.Windows.Forms.CheckBox
    Private WithEvents checkBox7 As System.Windows.Forms.CheckBox
    Private pointSeries1 As Steema.TeeChart.Styles.Points
    Private lineSeries1 As Steema.TeeChart.Styles.Line
    Private colorLine1 As Steema.TeeChart.Tools.ColorLine
    Private colorLine2 As Steema.TeeChart.Tools.ColorLine
    Private buttonPen1 As Steema.TeeChart.ButtonPen
    Private buttonPen2 As Steema.TeeChart.ButtonPen
    Private components As System.ComponentModel.IContainer = Nothing
    
    
    Public Sub New()
        Dim min, max As Double
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        

        For Each s As Steema.TeeChart.Styles.Series In tChart1.Series
            s.FillSampleValues(20)
        Next s
        buttonPen1.Pen = colorLine1.Pen
        buttonPen2.Pen = colorLine2.Pen

        If lineSeries1.YValues.Maximum > pointSeries1.YValues.Maximum Then
            max = lineSeries1.YValues.Maximum
        Else
            max = pointSeries1.YValues.Maximum
        End If
        If lineSeries1.YValues.Minimum > pointSeries1.YValues.Minimum Then
            min = pointSeries1.YValues.Minimum
        Else
            min = lineSeries1.YValues.Minimum
        End If
        colorLine1.Value = min + (max - min) / 2
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
        Me.checkBox2 = New System.Windows.Forms.CheckBox
        Me.checkBox3 = New System.Windows.Forms.CheckBox
        Me.checkBox4 = New System.Windows.Forms.CheckBox
        Me.checkBox5 = New System.Windows.Forms.CheckBox
        Me.checkBox6 = New System.Windows.Forms.CheckBox
        Me.checkBox7 = New System.Windows.Forms.CheckBox
        Me.pointSeries1 = New Steema.TeeChart.Styles.Points
        Me.lineSeries1 = New Steema.TeeChart.Styles.Line
        Me.colorLine1 = New Steema.TeeChart.Tools.ColorLine
        Me.colorLine2 = New Steema.TeeChart.Tools.ColorLine
        Me.buttonPen1 = New Steema.TeeChart.ButtonPen
        Me.buttonPen2 = New Steema.TeeChart.ButtonPen
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(466, 63)
        Me.textBox1.Text = """Color Line"" tools are small objects that draw a line at a specific axis and axis" + " position. " + vbCr + vbLf + "They can be used to mark axis values or to separate regions defined" + " by custom axes." + vbCr + vbLf + "Try to drag the lines with the mouse."
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.buttonPen2)
        Me.panel1.Controls.Add(Me.buttonPen1)
        Me.panel1.Controls.Add(Me.checkBox7)
        Me.panel1.Controls.Add(Me.checkBox6)
        Me.panel1.Controls.Add(Me.checkBox5)
        Me.panel1.Controls.Add(Me.checkBox4)
        Me.panel1.Controls.Add(Me.checkBox3)
        Me.panel1.Controls.Add(Me.checkBox2)
        Me.panel1.Controls.Add(Me.checkBox1)
        Me.panel1.Location = New System.Drawing.Point(0, 63)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(466, 57)
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
        Me.tChart1.Header.Lines = New String() {"tChart1"}
        Me.tChart1.Header.Visible = False
        Me.tChart1.Location = New System.Drawing.Point(0, 120)
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Brush
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.tChart1.Series.Add(Me.pointSeries1)
        Me.tChart1.Series.Add(Me.lineSeries1)
        Me.tChart1.Size = New System.Drawing.Size(466, 166)
        Me.tChart1.Tools.Add(Me.colorLine1)
        Me.tChart1.Tools.Add(Me.colorLine2)
        ' 
        ' tChart1.Walls
        ' 
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
        Me.checkBox1.Location = New System.Drawing.Point(13, 7)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(83, 20)
        Me.checkBox1.TabIndex = 0
        Me.checkBox1.Text = "&Show lines"
        ' 
        ' checkBox2
        ' 
        Me.checkBox2.Checked = True
        Me.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox2.Location = New System.Drawing.Point(13, 33)
        Me.checkBox2.Name = "checkBox2"
        Me.checkBox2.Size = New System.Drawing.Size(83, 20)
        Me.checkBox2.TabIndex = 1
        Me.checkBox2.Text = "&Allow drag"
        ' 
        ' checkBox3
        ' 
        Me.checkBox3.Checked = True
        Me.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox3.Location = New System.Drawing.Point(100, 7)
        Me.checkBox3.Name = "checkBox3"
        Me.checkBox3.Size = New System.Drawing.Size(44, 20)
        Me.checkBox3.TabIndex = 2
        Me.checkBox3.Text = "&3D"
        ' 
        ' checkBox4
        ' 
        Me.checkBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox4.Location = New System.Drawing.Point(100, 33)
        Me.checkBox4.Name = "checkBox4"
        Me.checkBox4.Size = New System.Drawing.Size(100, 20)
        Me.checkBox4.TabIndex = 3
        Me.checkBox4.Text = "Drag &repaint"
        ' 
        ' checkBox5
        ' 
        Me.checkBox5.Checked = True
        Me.checkBox5.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox5.Location = New System.Drawing.Point(140, 7)
        Me.checkBox5.Name = "checkBox5"
        Me.checkBox5.Size = New System.Drawing.Size(73, 20)
        Me.checkBox5.TabIndex = 4
        Me.checkBox5.Text = "3D &lines"
        ' 
        ' checkBox6
        ' 
        Me.checkBox6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox6.Location = New System.Drawing.Point(213, 7)
        Me.checkBox6.Name = "checkBox6"
        Me.checkBox6.Size = New System.Drawing.Size(123, 20)
        Me.checkBox6.TabIndex = 5
        Me.checkBox6.Text = "&Draw behind"
        ' 
        ' checkBox7
        ' 
        Me.checkBox7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox7.Location = New System.Drawing.Point(213, 33)
        Me.checkBox7.Name = "checkBox7"
        Me.checkBox7.Size = New System.Drawing.Size(107, 20)
        Me.checkBox7.TabIndex = 6
        Me.checkBox7.Text = "&No limit drag"
        ' 
        ' pointSeries1
        ' 
        ' 
        ' pointSeries1.Marks
        ' 
        ' 
        ' pointSeries1.Marks.Symbol
        ' 
        ' 
        ' pointSeries1.Marks.Symbol.Shadow
        ' 
        Me.pointSeries1.Marks.Symbol.Shadow.Height = 1
        Me.pointSeries1.Marks.Symbol.Shadow.Visible = True
        Me.pointSeries1.Marks.Symbol.Shadow.Width = 1
        ' 
        ' pointSeries1.Pointer
        ' 
        ' 
        ' pointSeries1.Pointer.Brush
        ' 
        Me.pointSeries1.Pointer.Brush.Color = System.Drawing.Color.Red
        Me.pointSeries1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.pointSeries1.Title = "pointSeries1"
        ' 
        ' pointSeries1.XValues
        ' 
        Me.pointSeries1.XValues.DataMember = "X"
        Me.pointSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' pointSeries1.YValues
        ' 
        Me.pointSeries1.YValues.DataMember = "Y"
        ' 
        ' lineSeries1
        ' 
        ' 
        ' lineSeries1.Brush
        ' 
        Me.lineSeries1.Brush.Color = System.Drawing.Color.Green
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
        Me.lineSeries1.Title = "lineSeries1"
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
        ' colorLine1
        ' 
        Me.colorLine1.Axis = Me.tChart1.Axes.Left
        ' 
        ' colorLine1.Pen
        ' 
        Me.colorLine1.Pen.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(0, System.Byte), CType(0, System.Byte), CType(255, System.Byte))
        ' 
        ' colorLine2
        ' 
        Me.colorLine2.Axis = Me.tChart1.Axes.Bottom
        ' 
        ' colorLine2.Pen
        ' 
        Me.colorLine2.Pen.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(128, System.Byte), CType(255, System.Byte), CType(128, System.Byte))
        Me.colorLine2.Pen.Width = 2
        Me.colorLine2.Value = 10
        ' 
        ' buttonPen1
        ' 
        Me.buttonPen1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonPen1.Location = New System.Drawing.Point(344, 13)
        Me.buttonPen1.Name = "buttonPen1"
        Me.buttonPen1.Size = New System.Drawing.Size(32, 23)
        Me.buttonPen1.TabIndex = 7
        Me.buttonPen1.Text = "Border"
        ' 
        ' buttonPen2
        ' 
        Me.buttonPen2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonPen2.Location = New System.Drawing.Point(384, 13)
        Me.buttonPen2.Name = "buttonPen2"
        Me.buttonPen2.Size = New System.Drawing.Size(32, 23)
        Me.buttonPen2.TabIndex = 8
        Me.buttonPen2.Text = "Border"
        ' 
        ' Tool_ColorLine
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(466, 286)
        Me.Name = "Tool_ColorLine"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub 'InitializeComponent 
#End Region


    Private Sub checkBox3_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox3.CheckedChanged
        tChart1.Aspect.View3D = checkBox3.Checked
        checkBox5.Enabled = checkBox3.Checked
    End Sub 'checkBox3_CheckedChanged


    Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox1.CheckedChanged

        For Each tool As Steema.TeeChart.Tools.Tool In tChart1.Tools
            tool.Active = checkBox1.Checked
        Next tool
    End Sub 'checkBox1_CheckedChanged

    Private Sub checkBox5_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox5.CheckedChanged
        Me.colorLine1.Draw3D = checkBox5.Checked
        Me.colorLine2.Draw3D = checkBox5.Checked
    End Sub 'checkBox5_CheckedChanged


    Private Sub checkBox6_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox6.CheckedChanged
        Me.colorLine1.DrawBehind = checkBox6.Checked
        Me.colorLine2.DrawBehind = checkBox6.Checked
    End Sub 'checkBox6_CheckedChanged


    Private Sub checkBox2_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox2.CheckedChanged
        Me.colorLine1.AllowDrag = checkBox2.Checked
        Me.colorLine2.AllowDrag = checkBox2.Checked
    End Sub 'checkBox2_CheckedChanged


    Private Sub checkBox4_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox4.CheckedChanged
        Me.colorLine1.DragRepaint = checkBox4.Checked
        Me.colorLine2.DragRepaint = checkBox4.Checked
    End Sub 'checkBox4_CheckedChanged


    Private Sub checkBox7_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox7.CheckedChanged
        Me.colorLine1.NoLimitDrag = checkBox7.Checked
        Me.colorLine2.NoLimitDrag = checkBox7.Checked
    End Sub 'checkBox7_CheckedChanged
End Class 'Tools_ColorLine
