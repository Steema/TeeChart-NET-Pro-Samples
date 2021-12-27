
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing

Imports System.Windows.Forms




Public Class Tool_CursorProg
    Inherits Samples.BaseForm
    Private pointSeries1 As Steema.TeeChart.Styles.Points
    Private cursorTool1 As Steema.TeeChart.Tools.CursorTool
    Private WithEvents button1 As System.Windows.Forms.Button
    Private WithEvents button2 As System.Windows.Forms.Button
    Private WithEvents button3 As System.Windows.Forms.Button
    Private WithEvents button4 As System.Windows.Forms.Button
    Private components As System.ComponentModel.IContainer = Nothing
    
    
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        
        Me.pointSeries1.FillSampleValues(20)
        ' place cursor in the middle
        Me.cursorTool1.XValue = 0.5 * (Me.pointSeries1.XValues.Maximum + Me.pointSeries1.XValues.Minimum)
        Me.cursorTool1.YValue = 0.5 * (Me.pointSeries1.YValues.Maximum + Me.pointSeries1.YValues.Minimum) '
  
        
        Me.cursorTool1.Pen.Color = Color.Navy
        Me.cursorTool1.Pen.Width = 2
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
        Me.pointSeries1 = New Steema.TeeChart.Styles.Points
        Me.cursorTool1 = New Steema.TeeChart.Tools.CursorTool
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
        Me.textBox1.Size = New System.Drawing.Size(466, 32)
        Me.textBox1.Text = "The Cursor tool now programatically changing the X and Y positions  of the cursor" + " lines."
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.button4)
        Me.panel1.Controls.Add(Me.button3)
        Me.panel1.Controls.Add(Me.button2)
        Me.panel1.Controls.Add(Me.button1)
        Me.panel1.Location = New System.Drawing.Point(0, 32)
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
        Me.tChart1.Aspect.View3D = False
        ' 
        ' tChart1.Header
        ' 
        Me.tChart1.Header.Lines = New String() {"tChart1"}
        Me.tChart1.Header.Visible = False
        ' 
        ' tChart1.Legend
        ' 
        Me.tChart1.Legend.Visible = False
        Me.tChart1.Location = New System.Drawing.Point(0, 73)
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Brush
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.tChart1.Series.Add(Me.pointSeries1)
        Me.tChart1.Size = New System.Drawing.Size(466, 213)
        Me.tChart1.Tools.Add(Me.cursorTool1)
        ' 
        ' pointSeries1
        ' 
        ' 
        ' pointSeries1.LinePen
        ' 
        Me.pointSeries1.LinePen.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(0, System.Byte), CType(0, System.Byte), CType(153, System.Byte))
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
        Me.pointSeries1.Pointer.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(0, System.Byte), CType(0, System.Byte), CType(255, System.Byte))
        ' 
        ' pointSeries1.Pointer.Pen
        ' 
        Me.pointSeries1.Pointer.Pen.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(0, System.Byte), CType(0, System.Byte), CType(153, System.Byte))
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
        ' cursorTool1
        ' 
        Me.cursorTool1.Series = Me.pointSeries1
        ' 
        ' button1
        ' 
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.Location = New System.Drawing.Point(16, 8)
        Me.button1.Name = "button1"
        Me.button1.TabIndex = 0
        Me.button1.Text = "< &Left"
        ' 
        ' button2
        ' 
        Me.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button2.Location = New System.Drawing.Point(104, 8)
        Me.button2.Name = "button2"
        Me.button2.TabIndex = 1
        Me.button2.Text = "&Right >"
        ' 
        ' button3
        ' 
        Me.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button3.Location = New System.Drawing.Point(187, 8)
        Me.button3.Name = "button3"
        Me.button3.TabIndex = 2
        Me.button3.Text = "^ &Up"
        ' 
        ' button4
        ' 
        Me.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button4.Location = New System.Drawing.Point(272, 8)
        Me.button4.Name = "button4"
        Me.button4.TabIndex = 3
        Me.button4.Text = "v &Down"
        ' 
        ' Tool_CursorProg
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(466, 286)
        Me.Name = "Tool_CursorProg"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub 'InitializeComponent 
#End Region


    Private Function SomeValue() As Double
        Dim res As Double = 0.1 * (Me.cursorTool1.Series.YValues.Maximum - Me.cursorTool1.Series.YValues.Minimum)
        Return res
    End Function 'SomeValue

    Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
        Me.cursorTool1.XValue -= 1
    End Sub 'button1_Click


    Private Sub button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button2.Click
        Me.cursorTool1.XValue += 1
    End Sub 'button2_Click


    Private Sub button3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button3.Click
        Me.cursorTool1.YValue += SomeValue()
    End Sub 'button3_Click


    Private Sub button4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button4.Click
        Me.cursorTool1.YValue -= SomeValue()
    End Sub 'button4_Click
End Class 'Tool_CursorProg
