
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing

Imports System.Windows.Forms




Public Class Function_Count
    Inherits Samples.BaseForm
    Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
    Private barSeries1 As Steema.TeeChart.Styles.Bar
    Private count1 As Steema.TeeChart.Functions.Count
    Private lineSeries1 As Steema.TeeChart.Styles.Line
    Private components As System.ComponentModel.IContainer = Nothing
    
    
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        
        Me.barSeries1.FillSampleValues(8)
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
        Me.barSeries1 = New Steema.TeeChart.Styles.Bar
        Me.count1 = New Steema.TeeChart.Functions.Count
        Me.lineSeries1 = New Steema.TeeChart.Styles.Line
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(466, 32)
        Me.textBox1.Text = "The Count function calculates the number of points of the data source series."
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.checkBox1)
        Me.panel1.Location = New System.Drawing.Point(0, 32)
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
        ' 
        ' tChart1.Header
        ' 
        Me.tChart1.Header.Lines = New String() {"tChart1"}
        Me.tChart1.Location = New System.Drawing.Point(0, 66)
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Brush
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.tChart1.Series.Add(Me.barSeries1)
        Me.tChart1.Series.Add(Me.lineSeries1)
        Me.tChart1.Size = New System.Drawing.Size(466, 220)
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
        Me.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox1.Location = New System.Drawing.Point(13, 8)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(127, 21)
        Me.checkBox1.TabIndex = 2
        Me.checkBox1.Text = "&By every 2 points"
        ' 
        ' barSeries1
        ' 
        ' 
        ' barSeries1.Brush
        ' 
        Me.barSeries1.Brush.Color = System.Drawing.Color.Red
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
        Me.barSeries1.Title = "Source"
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
        ' lineSeries1
        ' 
        ' 
        ' lineSeries1.Brush
        ' 
        Me.lineSeries1.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(0, System.Byte), CType(0, System.Byte), CType(255, System.Byte))
        Me.lineSeries1.DataSource = Me.barSeries1
        Me.lineSeries1.Function = Me.count1
        ' 
        ' lineSeries1.LinePen
        ' 
        Me.lineSeries1.LinePen.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(0, System.Byte), CType(0, System.Byte), CType(153, System.Byte))
        ' 
        ' lineSeries1.Marks
        ' 
        ' 
        ' lineSeries1.Marks.Brush
        ' 
        Me.lineSeries1.Marks.Brush.Color = System.Drawing.Color.FromArgb(CType(0, System.Byte), CType(128, System.Byte), CType(0, System.Byte))
        ' 
        ' lineSeries1.Marks.Font
        ' 
        ' 
        ' lineSeries1.Marks.Font.Brush
        ' 
        Me.lineSeries1.Marks.Font.Brush.Color = System.Drawing.Color.FromArgb(CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        ' 
        ' lineSeries1.Marks.Symbol
        ' 
        ' 
        ' lineSeries1.Marks.Symbol.Shadow
        ' 
        Me.lineSeries1.Marks.Symbol.Shadow.Height = 1
        Me.lineSeries1.Marks.Symbol.Shadow.Visible = True
        Me.lineSeries1.Marks.Symbol.Shadow.Width = 1
        Me.lineSeries1.Marks.Visible = True
        ' 
        ' lineSeries1.Pointer
        ' 
        ' 
        ' lineSeries1.Pointer.Brush
        ' 
        Me.lineSeries1.Pointer.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(0, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        Me.lineSeries1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.lineSeries1.Title = "Count"
        ' 
        ' lineSeries1.XValues
        ' 
        Me.lineSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' Function_Count
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(466, 286)
        Me.Name = "Function_Count"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub 'InitializeComponent 
#End Region


    Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox1.CheckedChanged
        If Me.checkBox1.Checked Then
            Me.count1.Period = 2
        Else
            Me.count1.Period = 0 ' all points
        End If
    End Sub 'checkBox1_CheckedChanged
End Class 'Function_Count
