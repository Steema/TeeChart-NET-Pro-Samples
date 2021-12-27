
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing

Imports System.Windows.Forms




Public Class Legend_Scroll
    Inherits Samples.BaseForm
    Private lineSeries1 As Steema.TeeChart.Styles.Line
    Private label1 As System.Windows.Forms.Label
    Private WithEvents trackBar1 As System.Windows.Forms.TrackBar
    Private label2 As System.Windows.Forms.Label
    Private WithEvents colorLine1 As Steema.TeeChart.Tools.ColorLine
    Private gridBand1 As Steema.TeeChart.Tools.GridBand
    Private components As System.ComponentModel.IContainer = Nothing
    
    
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        
        Me.lineSeries1.FillSampleValues(100)
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
        Me.label1 = New System.Windows.Forms.Label
        Me.trackBar1 = New System.Windows.Forms.TrackBar
        Me.label2 = New System.Windows.Forms.Label
        Me.colorLine1 = New Steema.TeeChart.Tools.ColorLine
        Me.gridBand1 = New Steema.TeeChart.Tools.GridBand
        Me.panel1.SuspendLayout()
        CType(Me.trackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(466, 63)
        Me.textBox1.Text = "The Chart Legend can be scrolled, to show values starting from our desired point." + " This is done using the Legend.FirstValue property:" + vbCr + vbLf + vbCr + vbLf + "tChart1.Legend.FirstValue" + " = 123 "
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.label2)
        Me.panel1.Controls.Add(Me.trackBar1)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Location = New System.Drawing.Point(0, 63)
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
        Me.tChart1.Header.Lines = New String() {"tChart1"}
        Me.tChart1.Header.Visible = False
        Me.tChart1.Location = New System.Drawing.Point(0, 104)
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Brush
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.tChart1.Series.Add(Me.lineSeries1)
        Me.tChart1.Size = New System.Drawing.Size(466, 182)
        Me.tChart1.Tools.Add(Me.colorLine1)
        Me.tChart1.Tools.Add(Me.gridBand1)
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
        ' lineSeries1
        ' 
        ' 
        ' lineSeries1.Brush
        ' 
        Me.lineSeries1.Brush.Color = System.Drawing.Color.Red
        ' 
        ' lineSeries1.LinePen
        ' 
        Me.lineSeries1.LinePen.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(128, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
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
        ' label1
        ' 
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(20, 11)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(66, 16)
        Me.label1.TabIndex = 0
        Me.label1.Text = "&First value : "
        Me.label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        ' 
        ' trackBar1
        ' 
        Me.trackBar1.AutoSize = False
        Me.trackBar1.Location = New System.Drawing.Point(87, 10)
        Me.trackBar1.Maximum = 99
        Me.trackBar1.Name = "trackBar1"
        Me.trackBar1.Size = New System.Drawing.Size(133, 19)
        Me.trackBar1.TabIndex = 1
        Me.trackBar1.TickFrequency = 5
        ' 
        ' label2
        ' 
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(227, 11)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(10, 16)
        Me.label2.TabIndex = 2
        Me.label2.Text = "0"
        Me.label2.UseMnemonic = False
        ' 
        ' colorLine1
        ' 
        Me.colorLine1.Axis = Me.tChart1.Axes.Bottom
        ' 
        ' gridBand1
        ' 
        Me.gridBand1.Axis = Me.tChart1.Axes.Left
        ' 
        ' gridBand1.Band1
        ' 
        Me.gridBand1.Band1.Color = System.Drawing.Color.FromArgb(CType(127, System.Byte), CType(224, System.Byte), CType(224, System.Byte), CType(224, System.Byte))
        ' 
        ' gridBand1.Band2
        ' 
        Me.gridBand1.Band2.Color = System.Drawing.Color.FromArgb(CType(127, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        ' 
        ' Legend_Scroll
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(466, 286)
        Me.Name = "Legend_Scroll"
        Me.panel1.ResumeLayout(False)
        CType(Me.trackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub 'InitializeComponent 
#End Region


    Private Sub trackBar1_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles trackBar1.ValueChanged
        label2.Text = trackBar1.Value.ToString()
        colorLine1.Value = trackBar1.Value
        tChart1.Legend.FirstValue = Fix(colorLine1.Value)
    End Sub 'trackBar1_ValueChanged


    Private Sub colorLine1_EndDragLine(ByVal sender As Object) Handles colorLine1.EndDragLine
        trackBar1.Value = Fix(colorLine1.Value)
    End Sub 'colorLine1_EndDragLine
End Class 'Legend_Scroll
