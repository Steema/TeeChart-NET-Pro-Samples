
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing

Imports System.Windows.Forms




Public Class Tool_AxisArrow
    Inherits Samples.BaseForm
    Private lineSeries1 As Steema.TeeChart.Styles.Line
    Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
    Private WithEvents checkBox2 As System.Windows.Forms.CheckBox
    Private axisArrow1 As Steema.TeeChart.Tools.AxisArrow
    Private axisArrow2 As Steema.TeeChart.Tools.AxisArrow
    Private axisArrow3 As Steema.TeeChart.Tools.AxisArrow
    Private WithEvents button1 As System.Windows.Forms.Button
    Private components As System.ComponentModel.IContainer = Nothing
    
    
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        
        Me.lineSeries1.FillSampleValues(10)
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
        Me.checkBox1 = New System.Windows.Forms.CheckBox
        Me.checkBox2 = New System.Windows.Forms.CheckBox
        Me.axisArrow1 = New Steema.TeeChart.Tools.AxisArrow
        Me.axisArrow2 = New Steema.TeeChart.Tools.AxisArrow
        Me.axisArrow3 = New Steema.TeeChart.Tools.AxisArrow
        Me.button1 = New System.Windows.Forms.Button
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(466, 63)
        Me.textBox1.Text = "The Axis Arrow tool is used to display small arrows at begin and / or end  positions of axes. Many Arrows can be added to a Chart, each one associated with a different axis. The Arrows can be customized ( pen, pattern, size )." + vbCr + vbLf + "Clicking the arrows will optionally scroll the axis a configurable percent amount."
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.button1)
        Me.panel1.Controls.Add(Me.checkBox2)
        Me.panel1.Controls.Add(Me.checkBox1)
        Me.panel1.Location = New System.Drawing.Point(0, 63)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(466, 34)
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
        Me.tChart1.Header.Lines = New String() {"Axis arrow tool"}
        ' 
        ' tChart1.Legend
        ' 
        Me.tChart1.Legend.Visible = False
        Me.tChart1.Location = New System.Drawing.Point(0, 97)
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Brush
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.tChart1.Series.Add(Me.lineSeries1)
        Me.tChart1.Size = New System.Drawing.Size(466, 189)
        Me.tChart1.Tools.Add(Me.axisArrow1)
        Me.tChart1.Tools.Add(Me.axisArrow2)
        Me.tChart1.Tools.Add(Me.axisArrow3)
        ' 
        ' lineSeries1
        ' 
        ' 
        ' lineSeries1.Brush
        ' 
        Me.lineSeries1.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(0, System.Byte), CType(255, System.Byte))
        ' 
        ' lineSeries1.LinePen
        ' 
        Me.lineSeries1.LinePen.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(153, System.Byte), CType(0, System.Byte), CType(153, System.Byte))
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
        ' checkBox1
        ' 
        Me.checkBox1.Checked = True
        Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox1.Location = New System.Drawing.Point(24, 7)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(140, 21)
        Me.checkBox1.TabIndex = 0
        Me.checkBox1.Text = "&Active left top"
        ' 
        ' checkBox2
        ' 
        Me.checkBox2.Checked = True
        Me.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox2.Location = New System.Drawing.Point(133, 7)
        Me.checkBox2.Name = "checkBox2"
        Me.checkBox2.Size = New System.Drawing.Size(115, 21)
        Me.checkBox2.TabIndex = 1
        Me.checkBox2.Text = "Active &bottom"
        ' 
        ' axisArrow1
        ' 
        Me.axisArrow1.Axis = Me.tChart1.Axes.Left
        ' 
        ' axisArrow1.Brush
        ' 
        Me.axisArrow1.Brush.Color = System.Drawing.Color.FromArgb(CType(255, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        Me.axisArrow1.Position = Steema.TeeChart.Tools.AxisArrowPosition.Start
        ' 
        ' axisArrow2
        ' 
        Me.axisArrow2.Axis = Me.tChart1.Axes.Left
        ' 
        ' axisArrow2.Brush
        ' 
        Me.axisArrow2.Brush.Color = System.Drawing.Color.FromArgb(CType(0, System.Byte), CType(0, System.Byte), CType(128, System.Byte))
        Me.axisArrow2.Position = Steema.TeeChart.Tools.AxisArrowPosition.End
        ' 
        ' axisArrow3
        ' 
        Me.axisArrow3.Axis = Me.tChart1.Axes.Bottom
        ' 
        ' axisArrow3.Brush
        ' 
        Me.axisArrow3.Brush.Color = System.Drawing.Color.FromArgb(CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        ' 
        ' button1
        ' 
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.Location = New System.Drawing.Point(256, 6)
        Me.button1.Name = "button1"
        Me.button1.TabIndex = 2
        Me.button1.Text = "&Edit..."
        ' 
        ' Tool_AxisArrow
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(466, 286)
        Me.Name = "Tool_AxisArrow"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub 'InitializeComponent 
#End Region


    Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox1.CheckedChanged
        Me.axisArrow1.Active = checkBox1.Checked
        Me.axisArrow2.Active = checkBox1.Checked
    End Sub 'checkBox1_CheckedChanged


    Private Sub checkBox2_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox2.CheckedChanged
        Me.axisArrow3.Active = checkBox2.Checked
    End Sub 'checkBox2_CheckedChanged


    Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
        Me.tChart1.ShowEditor()
    End Sub 'button1_Click
End Class 'Tool_AxisArrow
