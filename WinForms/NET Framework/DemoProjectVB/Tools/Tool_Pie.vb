
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms



Public Class Tool_Pie
    Inherits Steema.TeeChart.Samples.BaseForm
    Private pieSeries1 As Steema.TeeChart.Styles.Pie
    Private pieTool1 As Steema.TeeChart.Tools.PieTool
    Private label1 As System.Windows.Forms.Label
    Private label2 As System.Windows.Forms.Label
    Private buttonPen1 As Steema.TeeChart.ButtonPen
    Private WithEvents button1 As System.Windows.Forms.Button
    Private panelColor As System.Windows.Forms.Panel
    Private components As System.ComponentModel.IContainer = Nothing
    
    
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        
        pieSeries1.FillSampleValues(6)
        tChart1.Legend.Visible = False
        
        ' link pen button with tool pen
        buttonPen1.Pen = pieTool1.Pen
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
        Me.pieSeries1 = New Steema.TeeChart.Styles.Pie
        Me.pieTool1 = New Steema.TeeChart.Tools.PieTool
        Me.label1 = New System.Windows.Forms.Label
        Me.label2 = New System.Windows.Forms.Label
        Me.buttonPen1 = New Steema.TeeChart.ButtonPen
        Me.button1 = New System.Windows.Forms.Button
        Me.panelColor = New System.Windows.Forms.Panel
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(440, 63)
        Me.textBox1.Text = "Use PieTool to focus pie slices when passing the mouse over them." + vbCr + vbLf + "Move the mouse" + " over pie slices..."
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.panelColor)
        Me.panel1.Controls.Add(Me.button1)
        Me.panel1.Controls.Add(Me.buttonPen1)
        Me.panel1.Controls.Add(Me.label2)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Location = New System.Drawing.Point(0, 63)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(440, 41)
        ' 
        ' tChart1
        ' 
        ' 
        ' tChart1.Aspect
        ' 
        Me.tChart1.Aspect.Elevation = 315
        Me.tChart1.Aspect.Orthogonal = False
        Me.tChart1.Aspect.Perspective = 0
        Me.tChart1.Aspect.Rotation = 360
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
        ' 
        ' tChart1.Panel.Gradient
        ' 
        Me.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(0, System.Byte), CType(0, System.Byte), CType(128, System.Byte))
        Me.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(128, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.tChart1.Panel.Brush.Gradient.Visible = True
        ' 
        ' tChart1.Panel.Gradient
        ' 
        Me.tChart1.Panel.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(0, System.Byte), CType(0, System.Byte), CType(128, System.Byte))
        Me.tChart1.Panel.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(128, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.tChart1.Panel.Gradient.Visible = True
        Me.tChart1.Series.Add(Me.pieSeries1)
        Me.tChart1.Size = New System.Drawing.Size(440, 237)
        Me.tChart1.Tools.Add(Me.pieTool1)
        ' 
        ' pieSeries1
        ' 
        ' 
        ' pieSeries1.Brush
        ' 
        Me.pieSeries1.Brush.Color = System.Drawing.Color.Red
        Me.pieSeries1.LabelMember = "Labels"
        ' 
        ' pieSeries1.Marks
        ' 
        ' 
        ' pieSeries1.Marks.Symbol
        ' 
        ' 
        ' pieSeries1.Marks.Symbol.Shadow
        ' 
        Me.pieSeries1.Marks.Symbol.Shadow.Height = 1
        Me.pieSeries1.Marks.Symbol.Shadow.Visible = True
        Me.pieSeries1.Marks.Symbol.Shadow.Width = 1
        ' 
        ' pieSeries1.Pen
        ' 
        Me.pieSeries1.Pen.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(128, System.Byte), CType(128, System.Byte), CType(128, System.Byte))
        ' 
        ' pieSeries1.Shadow
        ' 
        Me.pieSeries1.Shadow.Height = 20
        Me.pieSeries1.Shadow.Width = 20
        Me.pieSeries1.Title = "pieSeries1"
        ' 
        ' pieSeries1.XValues
        ' 
        Me.pieSeries1.XValues.DataMember = "Angle"
        Me.pieSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' pieSeries1.YValues
        ' 
        Me.pieSeries1.YValues.DataMember = "Pie"
        ' 
        ' pieTool1
        ' 
        ' 
        ' pieTool1.Pen
        ' 
        Me.pieTool1.Pen.Width = 4
        Me.pieTool1.Series = Me.pieSeries1
        ' 
        ' label1
        ' 
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(13, 11)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(32, 16)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Slice:"
        Me.label1.UseMnemonic = False
        ' 
        ' label2
        ' 
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(47, 11)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(14, 16)
        Me.label2.TabIndex = 1
        Me.label2.Text = "..."
        Me.label2.UseMnemonic = False
        ' 
        ' buttonPen1
        ' 
        Me.buttonPen1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonPen1.Location = New System.Drawing.Point(167, 8)
        Me.buttonPen1.Name = "buttonPen1"
        Me.buttonPen1.TabIndex = 2
        Me.buttonPen1.Text = "&Pen..."
        ' 
        ' button1
        ' 
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.Location = New System.Drawing.Point(264, 8)
        Me.button1.Name = "button1"
        Me.button1.TabIndex = 3
        Me.button1.Text = "&Edit..."
        ' 
        ' panelColor
        ' 
        Me.panelColor.Location = New System.Drawing.Point(127, 5)
        Me.panelColor.Name = "panelColor"
        Me.panelColor.Size = New System.Drawing.Size(26, 28)
        Me.panelColor.TabIndex = 4
        ' 
        ' Tool_PieTool
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(440, 341)
        Me.Name = "Tool_PieTool"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub 'InitializeComponent 
#End Region


    Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
        TeeChart.Editors.Tools.ToolsEditor.ShowEditor(pieTool1)
    End Sub 'button1_Click


    Private Sub tChart1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tChart1.MouseMove
        Dim tmp As Integer = pieTool1.Slice
        If tmp = -1 Then
            label2.Text = ""
            panelColor.Visible = False
        Else
            label2.Text = pieSeries1.Labels(tmp)
            panelColor.BackColor = pieSeries1.ValueColor(tmp)
            panelColor.Visible = True
        End If
    End Sub 'tChart1_MouseMove
End Class 'Tool_Pie