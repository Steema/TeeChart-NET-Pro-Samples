
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms


Public Class Tool_ExtraLegend
    Inherits Steema.TeeChart.Samples.BaseForm
    Private checkBox1 As System.Windows.Forms.CheckBox
    Private button1 As System.Windows.Forms.Button
    Private button2 As System.Windows.Forms.Button
    Private components As System.ComponentModel.IContainer = Nothing
    Private line1 As Steema.TeeChart.Styles.Line
    Private extraLegend1 As Steema.TeeChart.Tools.ExtraLegend
    Private gridBand1 As Steema.TeeChart.Tools.GridBand
    Private line2 As Steema.TeeChart.Styles.Line
    
    
    Public Sub New()
        ' This call is required by the Windows Form Designer.
			
        InitializeComponent()
        line1.FillSampleValues()
        line2.FillSampleValues()
        ' Cosmetic...
        extraLegend1.Legend.Left = 50
        extraLegend1.Legend.Top = 50
  
		
End Sub


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

#Region "Windows Form Designer generated code"

    '/ <summary>
    '/ Required method for Designer support - do not modify
    '/ the contents of this method with the code editor.
    '/ </summary>
    Private Sub InitializeComponent()
        Me.checkBox1 = New System.Windows.Forms.CheckBox
        Me.button1 = New System.Windows.Forms.Button
        Me.button2 = New System.Windows.Forms.Button
        Me.line1 = New Steema.TeeChart.Styles.Line
        Me.line2 = New Steema.TeeChart.Styles.Line
        Me.extraLegend1 = New Steema.TeeChart.Tools.ExtraLegend
        Me.gridBand1 = New Steema.TeeChart.Tools.GridBand
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Text = "ExtraLegend tool displays additional legend objects. " + vbCr + vbLf + "The tool has a Series property to display legend with series values and / or texts."
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.button2)
        Me.panel1.Controls.Add(Me.button1)
        Me.panel1.Controls.Add(Me.checkBox1)
        Me.panel1.Name = "panel1"
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

        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Brush
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb((CType((254), System.Byte)), (CType((255), System.Byte)), (CType((255), System.Byte)), (CType((255), System.Byte)))
        Me.tChart1.Series.Add(Me.line1)
        Me.tChart1.Series.Add(Me.line2)
        Me.tChart1.Tools.Add(Me.extraLegend1)
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
        ' checkBox1
        ' 
        Me.checkBox1.Checked = True
        Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox1.Location = New System.Drawing.Point(8, 8)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(128, 24)
        Me.checkBox1.TabIndex = 0
        Me.checkBox1.Text = "Show Extra Legend"
        AddHandler checkBox1.Click, AddressOf Me.checkBox1_Click
        ' 
        ' button1
        ' 
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.Location = New System.Drawing.Point(144, 8)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(112, 23)
        Me.button1.TabIndex = 1
        Me.button1.Text = "Edit Extra Legend..."
        AddHandler button1.Click, AddressOf Me.button1_Click
        ' 
        ' button2
        ' 
        Me.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button2.Location = New System.Drawing.Point(304, 8)
        Me.button2.Name = "button2"
        Me.button2.TabIndex = 2
        Me.button2.Text = "Align"
        AddHandler button2.Click, AddressOf Me.button2_Click
        ' 
        ' line1
        ' 
        ' 
        ' line1.Brush
        ' 
        Me.line1.Brush.Color = System.Drawing.Color.FromArgb((CType((254), System.Byte)), (CType((0), System.Byte)), (CType((128), System.Byte)), (CType((0), System.Byte)))
        ' 
        ' line1.LinePen
        ' 
        Me.line1.LinePen.Color = System.Drawing.Color.FromArgb((CType((254), System.Byte)), (CType((0), System.Byte)), (CType((77), System.Byte)), (CType((0), System.Byte)))
        ' 
        ' line1.Marks
        ' 
        ' 
        ' line1.Marks.Symbol
        ' 
        ' 
        ' line1.Marks.Symbol.Shadow
        ' 
        Me.line1.Marks.Symbol.Shadow.Height = 1
        Me.line1.Marks.Symbol.Shadow.Visible = True
        Me.line1.Marks.Symbol.Shadow.Width = 1
        ' 
        ' line1.Pointer
        ' 
        ' 
        ' line1.Pointer.Brush
        ' 
        Me.line1.Pointer.Brush.Color = System.Drawing.Color.Red
        Me.line1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.line1.Title = "line1"
        ' 
        ' line1.XValues
        ' 
        Me.line1.XValues.DataMember = "X"
        Me.line1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' line1.YValues
        ' 
        Me.line1.YValues.DataMember = "Y"
        ' 
        ' line2
        ' 
        ' 
        ' line2.Brush
        ' 
        Me.line2.Brush.Color = System.Drawing.Color.FromArgb((CType((254), System.Byte)), (CType((128), System.Byte)), (CType((0), System.Byte)), (CType((128), System.Byte)))
        ' 
        ' line2.LinePen
        ' 
        Me.line2.LinePen.Color = System.Drawing.Color.FromArgb((CType((254), System.Byte)), (CType((77), System.Byte)), (CType((0), System.Byte)), (CType((77), System.Byte)))
        ' 
        ' line2.Marks
        ' 
        ' 
        ' line2.Marks.Symbol
        ' 
        ' 
        ' line2.Marks.Symbol.Shadow
        ' 
        Me.line2.Marks.Symbol.Shadow.Height = 1
        Me.line2.Marks.Symbol.Shadow.Visible = True
        Me.line2.Marks.Symbol.Shadow.Width = 1
        ' 
        ' line2.Pointer
        ' 
        ' 
        ' line2.Pointer.Brush
        ' 
        Me.line2.Pointer.Brush.Color = System.Drawing.Color.Green
        Me.line2.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.line2.Title = "line2"
        ' 
        ' line2.XValues
        ' 
        Me.line2.XValues.DataMember = "X"
        Me.line2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' line2.YValues
        ' 
        Me.line2.YValues.DataMember = "Y"
        ' 
        ' extraLegend1
        ' 
        Me.extraLegend1.Series = Me.line2
        ' 
        ' gridBand1
        ' 
        Me.gridBand1.Axis = Me.tChart1.Axes.Left
        ' 
        ' gridBand1.Band1
        ' 
        Me.gridBand1.Band1.Color = System.Drawing.Color.FromArgb((CType((127), System.Byte)), (CType((224), System.Byte)), (CType((224), System.Byte)), (CType((224), System.Byte)))
        ' 
        ' gridBand1.Band2
        ' 
        Me.gridBand1.Band2.Color = System.Drawing.Color.FromArgb((CType((127), System.Byte)), (CType((255), System.Byte)), (CType((255), System.Byte)), (CType((255), System.Byte)))
        ' 
        ' Tool_ExtraLegend
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(440, 317)
        Me.Name = "Tool_ExtraLegend"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    

    Private Sub checkBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        extraLegend1.Active = checkBox1.Checked
    End Sub 'checkBox1_Click


    Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim lEdit As New Steema.TeeChart.Editors.LegendEditor(tChart1.Chart, extraLegend1.Legend, Nothing)
        Steema.TeeChart.Editors.EditorUtils.ShowFormModal(lEdit)
    End Sub 'button1_Click


    Private Sub button2_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        ' Customize extra legend position.
        ' Align with default normal legend.
        extraLegend1.Legend.Left = tChart1.Legend.Left
        extraLegend1.Legend.Top = tChart1.Legend.ShapeBounds.Bottom + 10
    End Sub 'button2_Click 
End Class 'Tool_ExtraLegend