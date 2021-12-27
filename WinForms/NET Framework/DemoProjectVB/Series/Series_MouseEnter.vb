
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing

Imports System.Windows.Forms




Public Class Series_MouseEnter
    Inherits Samples.BaseForm
    Private label1 As System.Windows.Forms.Label
    Private WithEvents barSeries1 As Steema.TeeChart.Styles.Bar
    Private WithEvents line1 As Steema.TeeChart.Styles.Line
    Private gridBand1 As Steema.TeeChart.Tools.GridBand
    Private components As System.ComponentModel.IContainer = Nothing
    
    
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        
        barSeries1.FillSampleValues(6)
        line1.FillSampleValues(6)
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
        Me.label1 = New System.Windows.Forms.Label
        Me.barSeries1 = New Steema.TeeChart.Styles.Bar
        Me.line1 = New Steema.TeeChart.Styles.Line
        Me.gridBand1 = New Steema.TeeChart.Tools.GridBand
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(466, 64)
        Me.textBox1.TabIndex = 0
        Me.textBox1.Text = "All Series styles now provide OnMouseEnter and OnMouseLeave events." + vbCr + vbLf + "These events" + " are triggered when the mouse enters and exits a series point." + vbCr + vbLf + vbCr + vbLf + "Move the mouse" + " over points to test..."
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Location = New System.Drawing.Point(0, 64)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(466, 40)
        Me.panel1.TabIndex = 1
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
        Me.tChart1.Header.Lines = New String() {"Bar Series example"}
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
        Me.tChart1.Series.Add(Me.barSeries1)
        Me.tChart1.Series.Add(Me.line1)
        Me.tChart1.Size = New System.Drawing.Size(466, 182)
        Me.tChart1.TabIndex = 2
        Me.tChart1.Tools.Add(Me.gridBand1)
        ' 
        ' label1
        ' 
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(7, 10)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(8, 16)
        Me.label1.TabIndex = 0
        Me.label1.Text = "-"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.TopRight
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
        Me.barSeries1.Title = "bar1"
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
        ' line1
        ' 
        ' 
        ' line1.Brush
        ' 
        Me.line1.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(0, System.Byte), CType(0, System.Byte), CType(255, System.Byte))
        ' 
        ' line1.LinePen
        ' 
        Me.line1.LinePen.Width = 3
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
        Me.line1.Pointer.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(0, System.Byte), CType(128, System.Byte), CType(0, System.Byte))
        Me.line1.Pointer.HorizSize = 3
        ' 
        ' line1.Pointer.Pen
        ' 
        Me.line1.Pointer.Pen.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(128, System.Byte), CType(255, System.Byte), CType(128, System.Byte))
        Me.line1.Pointer.Pen.Width = 2
        Me.line1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.line1.Pointer.VertSize = 3
        Me.line1.Pointer.Visible = True
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
        ' SeriesMouseEnter
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(466, 286)
        Me.Name = "SeriesMouseEnter"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub 'InitializeComponent 
#End Region


    Private Sub barSeries1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles barSeries1.MouseEnter, line1.MouseEnter
        Dim tmp As Styles.Series
        Dim clicked As Integer

        tmp = CType(sender, Styles.Series) ' Sender is the Series
    ' Obtain point index under mouse cursor
    clicked = tmp.Clicked(tChart1.PointToClient(System.Windows.Forms.Cursor.Position))


    ' Show Series name and point index and value
    label1.Text = "Series: " + tmp.ToString() + " point: " + clicked.ToString() + " value: " + tmp.YValues.Value(clicked).ToString()

    End Sub 'barSeries1_MouseEnter


    Private Sub barSeries1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles barSeries1.MouseLeave, line1.MouseLeave
        label1.Text = ""
    End Sub 'barSeries1_MouseLeave
End Class 'Series_MouseEnter 
