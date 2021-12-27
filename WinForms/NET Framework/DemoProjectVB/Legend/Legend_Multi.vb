
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing

Imports System.Windows.Forms




Public Class Legend_Multi
    Inherits Samples.BaseForm
    Private barSeries1 As Steema.TeeChart.Styles.Bar
    Private barSeries2 As Steema.TeeChart.Styles.Bar
    Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
    Private gridBand1 As Steema.TeeChart.Tools.GridBand
    Private components As System.ComponentModel.IContainer = Nothing
    
    
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        
        barSeries1.FillSampleValues(5)
        barSeries2.FillSampleValues(5)
        tChart1.Legend.LegendStyle = Steema.TeeChart.LegendStyles.Values
        tChart1.Legend.Series = barSeries1
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
        Me.barSeries2 = New Steema.TeeChart.Styles.Bar
        Me.checkBox1 = New System.Windows.Forms.CheckBox
        Me.gridBand1 = New Steema.TeeChart.Tools.GridBand
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(466, 40)
        Me.textBox1.Text = "Multiple Legends can be displayed in the same Chart using the Chart AfterDraw eve" + "nt."
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.checkBox1)
        Me.panel1.Location = New System.Drawing.Point(0, 40)
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
        Me.tChart1.Cursor = System.Windows.Forms.Cursors.Default
        ' 
        ' tChart1.Header
        ' 
        Me.tChart1.Header.Lines = New String() {"tChart1"}
        Me.tChart1.Header.Visible = False
        ' 
        ' tChart1.Legend
        ' 
        ' 
        ' tChart1.Legend.Pen
        ' 
        Me.tChart1.Legend.Pen.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(192, System.Byte), CType(192, System.Byte), CType(192, System.Byte))
        ' 
        ' tChart1.Legend.Shadow
        ' 
        ' 
        ' tChart1.Legend.Shadow.Brush
        ' 
        Me.tChart1.Legend.Shadow.Brush.Color = System.Drawing.Color.FromArgb(CType(142, System.Byte), CType(0, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        Me.tChart1.Location = New System.Drawing.Point(0, 74)
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Brush
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.tChart1.Panel.MarginTop = 6
        Me.tChart1.Series.Add(Me.barSeries1)
        Me.tChart1.Series.Add(Me.barSeries2)
        Me.tChart1.Size = New System.Drawing.Size(466, 212)
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
        ' barSeries1
        ' 
        ' 
        ' barSeries1.Brush
        ' 
        Me.barSeries1.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(192, System.Byte), CType(128, System.Byte))
        ' 
        ' barSeries1.Marks
        ' 
        ' 
        ' barSeries1.Marks.Pen
        ' 
        Me.barSeries1.Marks.Pen.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(128, System.Byte), CType(128, System.Byte), CType(128, System.Byte))
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
        Me.barSeries1.Pen.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(192, System.Byte), CType(64, System.Byte), CType(0, System.Byte))
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
        ' barSeries2
        ' 
        ' 
        ' barSeries2.Brush
        ' 
        Me.barSeries2.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(128, System.Byte), CType(255, System.Byte), CType(128, System.Byte))
        ' 
        ' barSeries2.Marks
        ' 
        ' 
        ' barSeries2.Marks.Pen
        ' 
        Me.barSeries2.Marks.Pen.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(192, System.Byte), CType(192, System.Byte), CType(192, System.Byte))
        ' 
        ' barSeries2.Marks.Symbol
        ' 
        ' 
        ' barSeries2.Marks.Symbol.Shadow
        ' 
        Me.barSeries2.Marks.Symbol.Shadow.Height = 1
        Me.barSeries2.Marks.Symbol.Shadow.Visible = True
        Me.barSeries2.Marks.Symbol.Shadow.Width = 1
        ' 
        ' barSeries2.Pen
        ' 
        Me.barSeries2.Pen.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(0, System.Byte), CType(128, System.Byte), CType(0, System.Byte))
        Me.barSeries2.Title = "barSeries2"
        ' 
        ' barSeries2.XValues
        ' 
        Me.barSeries2.XValues.DataMember = "X"
        Me.barSeries2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' barSeries2.YValues
        ' 
        Me.barSeries2.YValues.DataMember = "Bar"
        ' 
        ' checkBox1
        ' 
        Me.checkBox1.Checked = True
        Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox1.Location = New System.Drawing.Point(13, 7)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(140, 21)
        Me.checkBox1.TabIndex = 0
        Me.checkBox1.Text = "&Show second legend"
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
        ' Legend_Multi
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(466, 286)
        Me.Name = "Legend_Multi"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub 'InitializeComponent 
#End Region


    Private Sub tChart1_AfterDraw(ByVal sender As Object, ByVal g As Steema.TeeChart.Drawing.Graphics3D) Handles tChart1.AfterDraw
        If checkBox1.Checked Then
            Dim l As Steema.TeeChart.Legend = tChart1.Legend

            l.Series = barSeries2
            Dim oldTop As Integer = l.Top
            l.CustomPosition = True
            l.Top = 190
            l.Bottom = 300
            l.Paint(tChart1.Graphics3D, l.ShapeBounds)

            ' restore 
            l.Series = barSeries1
            l.CustomPosition = False
            l.Top = oldTop
        Else
            tChart1.Legend.Series = barSeries1
        End If
    End Sub 'tChart1_AfterDraw

    Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox1.CheckedChanged
        tChart1.Refresh()
    End Sub 'checkBox1_CheckedChanged
End Class 'Legend_Multi
