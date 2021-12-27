
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing

Imports System.Windows.Forms




Public Class Function_Multiply
    Inherits Samples.BaseForm
    Private barSeries1 As Steema.TeeChart.Styles.Bar
    Private barSeries2 As Steema.TeeChart.Styles.Bar
    Private multiply1 As Steema.TeeChart.Functions.Multiply
    Private lineSeries1 As Steema.TeeChart.Styles.Line
    Private components As System.ComponentModel.IContainer = Nothing
    
    
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        
        Me.barSeries1.Add(New Double(5) {2, 3, 5, 7, 1, 4})
        Me.barSeries2.Add(New Double(5) {1, 5, 9, 3, 8, 2})
        Me.lineSeries1.CheckDataSource()
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
        Me.multiply1 = New Steema.TeeChart.Functions.Multiply
        Me.lineSeries1 = New Steema.TeeChart.Styles.Line
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(354, 53)
        Me.textBox1.Text = "The Multiply function calculates the product of every point of several data sourc" + "e series."
        ' 
        ' panel1
        ' 
        Me.panel1.Location = New System.Drawing.Point(0, 53)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(354, 11)
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
        Me.tChart1.Header.Lines = New String() {"Multiply function"}
        Me.tChart1.Location = New System.Drawing.Point(0, 64)
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Brush
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.tChart1.Series.Add(Me.barSeries1)
        Me.tChart1.Series.Add(Me.barSeries2)
        Me.tChart1.Series.Add(Me.lineSeries1)
        Me.tChart1.Size = New System.Drawing.Size(354, 177)
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
        Me.barSeries1.Title = "Source1"
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
        Me.barSeries2.Brush.Color = System.Drawing.Color.Green
        ' 
        ' barSeries2.Marks
        ' 
        ' 
        ' barSeries2.Marks.Symbol
        ' 
        ' 
        ' barSeries2.Marks.Symbol.Shadow
        ' 
        Me.barSeries2.Marks.Symbol.Shadow.Height = 1
        Me.barSeries2.Marks.Symbol.Shadow.Visible = True
        Me.barSeries2.Marks.Symbol.Shadow.Width = 1
        Me.barSeries2.Title = "Source2"
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
        ' lineSeries1
        ' 
        ' 
        ' lineSeries1.Brush
        ' 
        Me.lineSeries1.Brush.Color = System.Drawing.Color.Yellow
        Me.lineSeries1.DataSource = New Object() {Me.barSeries1, Me.barSeries2}
        Me.lineSeries1.Function = Me.multiply1
        ' 
        ' lineSeries1.Marks
        ' 
        ' 
        ' lineSeries1.Marks.Arrow
        ' 
        Me.lineSeries1.Marks.Arrow.Color = System.Drawing.Color.FromArgb(CType(255, System.Byte), CType(255, System.Byte), CType(0, System.Byte))
        ' 
        ' lineSeries1.Marks.Brush
        ' 
        Me.lineSeries1.Marks.Brush.Color = System.Drawing.Color.FromArgb(CType(255, System.Byte), CType(255, System.Byte), CType(0, System.Byte))
        ' 
        ' lineSeries1.Marks.Font
        ' 
        ' 
        ' lineSeries1.Marks.Font.Brush
        ' 
        Me.lineSeries1.Marks.Font.Brush.Color = System.Drawing.Color.Red
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
        Me.lineSeries1.Title = "Multiply"
        ' 
        ' lineSeries1.XValues
        ' 
        Me.lineSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' Function_Multiply
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(354, 241)
        Me.Name = "Function_Multiply"
        Me.ResumeLayout(False)
    End Sub 'InitializeComponent 
#End Region
End Class 'Function_Multiply
