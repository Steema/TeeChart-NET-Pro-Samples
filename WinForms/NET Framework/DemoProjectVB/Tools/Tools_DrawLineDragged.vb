
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms



Public Class Tools_DrawLineDragged
  Inherits Samples.BaseForm
  Private lineSeries1 As Steema.TeeChart.Styles.Line
  Private WithEvents drawLine1 As Steema.TeeChart.Tools.DrawLine
  Private label1 As System.Windows.Forms.Label
  Private label2 As System.Windows.Forms.Label
  Private label3 As System.Windows.Forms.Label
  Private components As System.ComponentModel.IContainer = Nothing


  Public Sub New()
    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    Me.lineSeries1.FillSampleValues(30)

    ' set the "X" line positions (start and end position) 
    Dim I As New Steema.TeeChart.Tools.DrawLineItem(drawLine1)

    ' set the "Y" line positions (start and end position) 
    Dim tmp As Double = lineSeries1.YValues.Range / 5.0

    I.StartPos = New Steema.TeeChart.Drawing.PointDouble(5, lineSeries1.YValues.Maximum - tmp)
    I.EndPos = New Steema.TeeChart.Drawing.PointDouble(15, lineSeries1.YValues.Minimum + tmp)


    drawLine1.Pen.Color = Color.Blue
    drawLine1.Pen.Width = 2
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
    Me.lineSeries1 = New Steema.TeeChart.Styles.Line
    Me.drawLine1 = New Steema.TeeChart.Tools.DrawLine
    Me.label1 = New System.Windows.Forms.Label
    Me.label2 = New System.Windows.Forms.Label
    Me.label3 = New System.Windows.Forms.Label
    Me.panel1.SuspendLayout()
    Me.SuspendLayout()
    ' 
    ' textBox1
    ' 
    Me.textBox1.Name = "textBox1"
    Me.textBox1.Size = New System.Drawing.Size(512, 64)
    Me.textBox1.Text = "DrawLine tool introduces OnDraggedLine event. This event is triggered when the us" + "er finishes dragging a line." + vbCr + vbLf + "Try drawing a line, then clicking and moving it. W" + "hen finished, the event is raised and the label below shows the new line positio" + "n."
    ' 
    ' panel1
    ' 
    Me.panel1.Controls.Add(Me.label3)
    Me.panel1.Controls.Add(Me.label2)
    Me.panel1.Controls.Add(Me.label1)
    Me.panel1.Location = New System.Drawing.Point(0, 64)
    Me.panel1.Name = "panel1"
    Me.panel1.Size = New System.Drawing.Size(512, 48)
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
    Me.tChart1.Name = "tChart1"
    ' 
    ' tChart1.Panel
    ' 
    ' 
    ' tChart1.Panel.Brush
    ' 
    Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
    Me.tChart1.Series.Add(Me.lineSeries1)
    Me.tChart1.Size = New System.Drawing.Size(512, 181)
    Me.tChart1.Tools.Add(Me.drawLine1)
    ' 
    ' lineSeries1
    ' 
    ' 
    ' lineSeries1.Brush
    ' 
    Me.lineSeries1.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(0, System.Byte), CType(128, System.Byte), CType(0, System.Byte))
    ' 
    ' lineSeries1.LinePen
    ' 
    Me.lineSeries1.LinePen.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(0, System.Byte), CType(77, System.Byte), CType(0, System.Byte))
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
    ' drawLine1
    ' 
    Me.drawLine1.EnableDraw = False
    ' 
    ' label1
    ' 
    Me.label1.AutoSize = True
    Me.label1.Location = New System.Drawing.Point(11, 8)
    Me.label1.Name = "label1"
    Me.label1.Size = New System.Drawing.Size(122, 16)
    Me.label1.TabIndex = 0
    Me.label1.Text = "Dragging line position : "
    Me.label1.UseMnemonic = False
    ' 
    ' label2
    ' 
    Me.label2.AutoSize = True
    Me.label2.Location = New System.Drawing.Point(160, 8)
    Me.label2.Name = "label2"
    Me.label2.Size = New System.Drawing.Size(20, 16)
    Me.label2.TabIndex = 1
    Me.label2.Text = "0,0"
    Me.label2.UseMnemonic = False
    ' 
    ' label3
    ' 
    Me.label3.AutoSize = True
    Me.label3.Location = New System.Drawing.Point(160, 24)
    Me.label3.Name = "label3"
    Me.label3.Size = New System.Drawing.Size(20, 16)
    Me.label3.TabIndex = 2
    Me.label3.Text = "0,0"
    Me.label3.UseMnemonic = False
    ' 
    ' Tool_DrawLineDragged
    ' 
    Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
    Me.ClientSize = New System.Drawing.Size(512, 293)
    Me.Name = "Tool_DrawLineDragged"
    Me.panel1.ResumeLayout(False)
    Me.ResumeLayout(False)
  End Sub 'InitializeComponent 
#End Region


  Private Sub drawLine1_DraggedLine(ByVal sender As Steema.TeeChart.Tools.DrawLine) Handles drawLine1.DraggedLine
    Dim I As Steema.TeeChart.Tools.DrawLineItem = drawLine1.Selected
    label2.Text = "Start: (x: " + I.StartPos.X.ToString("0.00") + ", y: " + I.StartPos.Y.ToString("0.00") + ")"
    label3.Text = "End: (x: " + I.EndPos.X.ToString("0.00") + ", y: " + I.EndHandle.Y.ToString("0.00") + ")"
  End Sub 'drawLine1_DraggedLine
End Class 'Tools_DrawLineDragged
