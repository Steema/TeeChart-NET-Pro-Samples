
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing

Imports System.Windows.Forms




Public Class Marks_Angle
    Inherits Samples.BaseForm
    Private areaSeries1 As Steema.TeeChart.Styles.Area
    Private label1 As System.Windows.Forms.Label
    Private WithEvents hScrollBar1 As System.Windows.Forms.HScrollBar
    Private label2 As System.Windows.Forms.Label
    Private WithEvents button1 As System.Windows.Forms.Button
    Private WithEvents button2 As System.Windows.Forms.Button
    Private components As System.ComponentModel.IContainer = Nothing
    
    
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        
        Me.areaSeries1.FillSampleValues(10)
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
        Me.areaSeries1 = New Steema.TeeChart.Styles.Area
        Me.label1 = New System.Windows.Forms.Label
        Me.hScrollBar1 = New System.Windows.Forms.HScrollBar
        Me.label2 = New System.Windows.Forms.Label
        Me.button1 = New System.Windows.Forms.Button
        Me.button2 = New System.Windows.Forms.Button
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(466, 63)
        Me.textBox1.Text = "Series Marks can be rotated using the Angle property." + vbCr + vbLf + vbCr + vbLf + "Example: areaSeries1.Mar" + "ks.Angle = 90 "
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.button2)
        Me.panel1.Controls.Add(Me.button1)
        Me.panel1.Controls.Add(Me.label2)
        Me.panel1.Controls.Add(Me.hScrollBar1)
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
        Me.tChart1.Location = New System.Drawing.Point(0, 104)
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Brush
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.tChart1.Series.Add(Me.areaSeries1)
        Me.tChart1.Size = New System.Drawing.Size(466, 182)
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
        ' areaSeries1
        ' 
        ' 
        ' areaSeries1.AreaBrush
        ' 
        Me.areaSeries1.AreaBrush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        ' 
        ' areaSeries1.Brush
        ' 
        Me.areaSeries1.Brush.Color = System.Drawing.Color.Red
        ' 
        ' areaSeries1.Marks
        ' 
        Me.areaSeries1.Marks.Angle = 45
        ' 
        ' areaSeries1.Marks.Symbol
        ' 
        ' 
        ' areaSeries1.Marks.Symbol.Shadow
        ' 
        Me.areaSeries1.Marks.Symbol.Shadow.Height = 1
        Me.areaSeries1.Marks.Symbol.Shadow.Visible = True
        Me.areaSeries1.Marks.Symbol.Shadow.Width = 1
        Me.areaSeries1.Marks.Visible = True
        ' 
        ' areaSeries1.Pointer
        ' 
        ' 
        ' areaSeries1.Pointer.Brush
        ' 
        Me.areaSeries1.Pointer.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(0, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        Me.areaSeries1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.areaSeries1.Title = "areaSeries1"
        ' 
        ' areaSeries1.XValues
        ' 
        Me.areaSeries1.XValues.DataMember = "X"
        Me.areaSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' areaSeries1.YValues
        ' 
        Me.areaSeries1.YValues.DataMember = "Y"
        ' 
        ' label1
        ' 
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(20, 13)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(36, 16)
        Me.label1.TabIndex = 0
        Me.label1.Text = "&Angle:"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        ' 
        ' hScrollBar1
        ' 
        Me.hScrollBar1.Location = New System.Drawing.Point(60, 13)
        Me.hScrollBar1.Maximum = 360
        Me.hScrollBar1.Name = "hScrollBar1"
        Me.hScrollBar1.Size = New System.Drawing.Size(113, 17)
        Me.hScrollBar1.TabIndex = 1
        Me.hScrollBar1.Value = 45
        ' 
        ' label2
        ' 
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(180, 13)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(17, 16)
        Me.label2.TabIndex = 2
        Me.label2.Text = "45"
        Me.label2.UseMnemonic = False
        ' 
        ' button1
        ' 
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.Location = New System.Drawing.Point(232, 10)
        Me.button1.Name = "button1"
        Me.button1.TabIndex = 3
        Me.button1.Text = "&Reset"
        ' 
        ' button2
        ' 
        Me.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button2.Location = New System.Drawing.Point(327, 10)
        Me.button2.Name = "button2"
        Me.button2.TabIndex = 4
        Me.button2.Text = "&Vertical"
        ' 
        ' Angle
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(466, 286)
        Me.Name = "Angle"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub 'InitializeComponent 
#End Region



    Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
        Me.hScrollBar1.Value = 0
    End Sub 'button1_Click


    Private Sub button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button2.Click
        Me.hScrollBar1.Value = 90
    End Sub 'button2_Click


    Private Sub hScrollBar1_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles hScrollBar1.ValueChanged
        Me.label2.Text = Me.hScrollBar1.Value.ToString()
        Me.areaSeries1.Marks.Angle = Fix(Me.hScrollBar1.Value)
    End Sub 'hScrollBar1_ValueChanged
End Class 'Marks_Angle
