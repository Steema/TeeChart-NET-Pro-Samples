
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing

Imports System.Windows.Forms




Public Class Legend_AddText
    Inherits Samples.BaseForm
    Private barSeries1 As Steema.TeeChart.Styles.Bar
    Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
    Private components As System.ComponentModel.IContainer = Nothing
    
    
    Public Sub New()
        ' This call is required by the Windows Form Designer.

        InitializeComponent()
        
        Me.barSeries1.FillSampleValues(6)
        Me.barSeries1.Labels(0) = "one"
        Me.barSeries1.Labels(1) = "two"
        Me.barSeries1.Labels(2) = "three"
        Me.barSeries1.Labels(3) = "four"
        Me.barSeries1.Labels(4) = "five"
        Me.barSeries1.Labels(5) = "six"
        Me.tChart1.Legend.LegendStyle = Steema.TeeChart.LegendStyles.Auto
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
        Me.barSeries1 = New Steema.TeeChart.Styles.Bar
        Me.checkBox1 = New System.Windows.Forms.CheckBox
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(425, 64)
        Me.textBox1.Text = "Using the Chart canvas it is possible to display additional text on the Legend." + vbCr + vbLf + vbCr + vbLf + "The TChart GetLegendRect and GetLegendPos events are used to make the legend r" + "ectangle bigger."
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.checkBox1)
        Me.panel1.Location = New System.Drawing.Point(0, 64)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(425, 37)
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
        Me.tChart1.Location = New System.Drawing.Point(0, 101)
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Brush
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        ' 
        ' tChart1.Panel.Gradient
        ' 
        Me.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(223, System.Byte), CType(223, System.Byte), CType(255, System.Byte))
        Me.tChart1.Panel.Brush.Gradient.Visible = True
        ' 
        ' tChart1.Panel.Gradient
        ' 
        Me.tChart1.Panel.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(223, System.Byte), CType(223, System.Byte), CType(255, System.Byte))
        Me.tChart1.Panel.Gradient.Visible = True
        Me.tChart1.Series.Add(Me.barSeries1)
        Me.tChart1.Size = New System.Drawing.Size(425, 169)
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
        Me.tChart1.Walls.Bottom.Size = 5
        ' 
        ' tChart1.Walls.Left
        ' 
        ' 
        ' tChart1.Walls.Left.Pen
        ' 
        Me.tChart1.Walls.Left.Pen.Visible = False
        Me.tChart1.Walls.Left.Size = 5
        ' 
        ' barSeries1
        ' 
        ' 
        ' barSeries1.Brush
        ' 
        Me.barSeries1.Brush.Color = System.Drawing.Color.FromArgb(CType(216, System.Byte), CType(255, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        ' 
        ' barSeries1.Marks
        ' 
        ' 
        ' barSeries1.Marks.Symbol
        ' 
        ' 
        ' barSeries1.Marks.Symbol.Shadow
        ' 
        Me.barSeries1.Marks.Symbol.Shadow.Height = 1
        Me.barSeries1.Marks.Symbol.Shadow.Visible = True
        Me.barSeries1.Marks.Symbol.Shadow.Width = 1
        ' 
        ' barSeries1.Pen
        ' 
        Me.barSeries1.Pen.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(128, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        Me.barSeries1.Title = "barSeries1"
        ' 
        ' barSeries1.XValues
        ' 
        Me.barSeries1.XValues.DataMember = "X"
        Me.barSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' barSeries1.YValues
        ' 
        Me.barSeries1.YValues.DataMember = "Bar"
        ' 
        ' checkBox1
        ' 
        Me.checkBox1.Checked = True
        Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox1.Location = New System.Drawing.Point(8, 8)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(122, 19)
        Me.checkBox1.TabIndex = 0
        Me.checkBox1.Text = "&Draw text on legend"
        ' 
        ' Legend_AddText
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(425, 270)
        Me.Name = "Legend_AddText"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub 'InitializeComponent 
#End Region


    Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox1.CheckedChanged
        Me.tChart1.Refresh()
    End Sub 'checkBox1_CheckedChanged


    Private Sub tChart1_AfterDraw(ByVal sender As Object, ByVal g As Steema.TeeChart.Drawing.Graphics3D) Handles tChart1.AfterDraw
        If Me.checkBox1.Checked Then
            If Me.checkBox1.Checked Then
                Dim legRect As System.Drawing.Rectangle = Me.tChart1.Legend.ShapeBounds
                Dim gr As Steema.TeeChart.Drawing.Graphics3D = tChart1.Graphics3D
                gr.HorizontalLine(legRect.Left, legRect.Right, legRect.Bottom - 30)
                gr.TextAlign = System.Drawing.StringAlignment.Near
                gr.Font.Size = 8
                gr.Font.Color = Color.Navy
                gr.TextOut(legRect.Left + 8, legRect.Bottom - 28, "Additional text")
                gr.TextOut(legRect.Left + 8, legRect.Bottom - 16, "displayed here.")
            End If
        End If
    End Sub 'tChart1_AfterDraw


    Private Sub tChart1_GetLegendPos(ByVal sender As Object, ByVal e As Steema.TeeChart.GetLegendPosEventArgs) Handles tChart1.GetLegendPos
        If Me.checkBox1.Checked Then
            e.X -= 40
            e.XColor -= 40
        End If
    End Sub 'tChart1_GetLegendPos


    Private Sub tChart1_GetLegendRect(ByVal sender As Object, ByVal e As Steema.TeeChart.GetLegendRectEventArgs) Handles tChart1.GetLegendRect
        If Me.checkBox1.Checked Then
            e.Rectangle = New Rectangle(e.Rectangle.Left - 40, e.Rectangle.Top, e.Rectangle.Width + 10, e.Rectangle.Height + 30)
        End If
    End Sub 'tChart1_GetLegendRect
End Class 'Legend_AddText
