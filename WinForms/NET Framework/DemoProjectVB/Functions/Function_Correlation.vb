
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms


Public Class Function_Correlation
    Inherits Steema.TeeChart.Samples.BaseForm
    Private checkBox1 As System.Windows.Forms.CheckBox
    Private button1 As System.Windows.Forms.Button
    Private points1 As Steema.TeeChart.Styles.Points
    Private correlationFunction1 As Steema.TeeChart.Functions.CorrelationFunction
    Private line1 As Steema.TeeChart.Styles.Line
    Private trendFunction1 As Steema.TeeChart.Functions.TrendFunction
    Private line2 As Steema.TeeChart.Styles.Line
    Private components As System.ComponentModel.IContainer = Nothing
    
    Public Sub New() ' This call is required by the Windows Form Designer.
        InitializeComponent()

        points1.FillSampleValues(20)
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
        Me.points1 = New Steema.TeeChart.Styles.Points
        Me.correlationFunction1 = New Steema.TeeChart.Functions.CorrelationFunction
        Me.line1 = New Steema.TeeChart.Styles.Line
        Me.trendFunction1 = New Steema.TeeChart.Functions.TrendFunction
        Me.line2 = New Steema.TeeChart.Styles.Line
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(440, 56)
        Me.textBox1.Text = "Correlation function calculates a coefficient value from -1 to 1 that indicates h" + "ow well source X and Y values follow the same trend."
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.button1)
        Me.panel1.Controls.Add(Me.checkBox1)
        Me.panel1.Location = New System.Drawing.Point(0, 56)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(440, 40)
        ' 
        ' tChart1
        ' 
        ' 
        ' tChart1.Aspect
        ' 
        Me.tChart1.Aspect.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality
        Me.tChart1.Aspect.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        Me.tChart1.Aspect.View3D = False
        Me.tChart1.BackColor = System.Drawing.Color.Transparent
        ' 
        ' tChart1.Header
        ' 
        Me.tChart1.Header.Lines = New String() {"Correlation function example"}
        Me.tChart1.Location = New System.Drawing.Point(0, 96)
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Bevel
        ' 
        Me.tChart1.Panel.Bevel.ColorTwo = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(192, System.Byte), CType(192, System.Byte), CType(192, System.Byte))
        ' 
        ' tChart1.Panel.Brush
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(224, System.Byte), CType(224, System.Byte), CType(224, System.Byte))
        Me.tChart1.Series.Add(Me.points1)
        Me.tChart1.Series.Add(Me.line1)
        Me.tChart1.Series.Add(Me.line2)
        Me.tChart1.Size = New System.Drawing.Size(440, 221)
        ' 
        ' checkBox1
        ' 
        Me.checkBox1.Location = New System.Drawing.Point(16, 8)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.TabIndex = 0
        Me.checkBox1.Text = "Show trend"
        AddHandler Me.checkBox1.CheckedChanged, AddressOf Me.checkBox1_CheckedChanged
        ' 
        ' button1
        ' 
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.Location = New System.Drawing.Point(160, 8)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(128, 23)
        Me.button1.TabIndex = 1
        Me.button1.Text = "New random values"
        AddHandler Me.button1.Click, AddressOf Me.button1_Click
        ' 
        ' points1
        ' 
        ' 
        ' points1.Marks
        ' 
        ' 
        ' points1.Marks.Symbol
        ' 
        ' 
        ' points1.Marks.Symbol.Shadow
        ' 
        Me.points1.Marks.Symbol.Shadow.Height = 1
        Me.points1.Marks.Symbol.Shadow.Visible = True
        Me.points1.Marks.Symbol.Shadow.Width = 1
        ' 
        ' points1.Pointer
        ' 
        ' 
        ' points1.Pointer.Brush
        ' 
        Me.points1.Pointer.Brush.Color = System.Drawing.Color.Red
        Me.points1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Diamond
        Me.points1.Title = "Data"
        ' 
        ' points1.XValues
        ' 
        Me.points1.XValues.DataMember = "X"
        Me.points1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' points1.YValues
        ' 
        Me.points1.YValues.DataMember = "Y"
        ' 
        ' line1
        ' 
        ' 
        ' line1.Brush
        ' 
        Me.line1.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(0, System.Byte), CType(255, System.Byte))
        Me.line1.DataSource = Me.points1
        Me.line1.Function = Me.correlationFunction1
        ' 
        ' line1.LinePen
        ' 
        Me.line1.LinePen.Style = System.Drawing.Drawing2D.DashStyle.Dot
        Me.line1.LinePen.Width = 2
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
        Me.line1.Pointer.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(0, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        Me.line1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.line1.Title = "Correlation"
        Me.line1.VertAxis = Steema.TeeChart.Styles.VerticalAxis.Right
        ' 
        ' line1.XValues
        ' 
        Me.line1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' line2
        ' 
        ' 
        ' line2.Brush
        ' 
        Me.line2.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(0, System.Byte), CType(0, System.Byte), CType(255, System.Byte))
        Me.line2.DataSource = Me.points1
        Me.line2.Function = Me.trendFunction1
        ' 
        ' line2.LinePen
        ' 
        Me.line2.LinePen.Width = 2
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
        Me.line2.Pointer.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(0, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        Me.line2.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.line2.Title = "Trend"
        Me.line2.Visible = False
        ' 
        ' line2.XValues
        ' 
        Me.line2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' Function_Correlation
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(440, 317)
        Me.Name = "Function_Correlation"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub
#End Region


    Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        line2.Active = checkBox1.Checked
    End Sub 'checkBox1_CheckedChanged


    Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        points1.FillSampleValues(20)
    End Sub 'button1_Click
End Class 'Function_Correlation