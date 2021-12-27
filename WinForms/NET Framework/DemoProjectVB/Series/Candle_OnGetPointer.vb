
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms



Public Class Candle_OnGetPointer
    Inherits Samples.BaseForm
    Private WithEvents candleSeries1 As Steema.TeeChart.Styles.Candle
    Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
    Private gridBand1 As Steema.TeeChart.Tools.GridBand
    Private components As System.ComponentModel.IContainer = Nothing
    
    
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        
        candleSeries1.FillSampleValues(20)
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
        Me.candleSeries1 = New Steema.TeeChart.Styles.Candle
        Me.checkBox1 = New System.Windows.Forms.CheckBox
        Me.gridBand1 = New Steema.TeeChart.Tools.GridBand
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(425, 32)
        Me.textBox1.Text = "Candle series provide an event to customize point styles."
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.checkBox1)
        Me.panel1.Location = New System.Drawing.Point(0, 32)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(425, 32)
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
        Me.tChart1.Header.Lines = New String() {"Candle series - OnGetPointerStyle event example"}
        ' 
        ' tChart1.Legend
        ' 
        ' 
        ' tChart1.Legend.Brush
        ' 
        Me.tChart1.Legend.Brush.Color = System.Drawing.Color.FromArgb(CType(51, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        ' 
        ' tChart1.Legend.Gradient
        ' 
        Me.tChart1.Legend.Brush.Gradient.Transparency = 80
        ' 
        ' tChart1.Legend.Gradient
        ' 
        Me.tChart1.Legend.Gradient.Transparency = 80
        ' 
        ' tChart1.Legend.Shadow
        ' 
        ' 
        ' tChart1.Legend.Shadow.Brush
        ' 
        Me.tChart1.Legend.Shadow.Brush.Color = System.Drawing.Color.FromArgb(CType(51, System.Byte), CType(0, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        Me.tChart1.Location = New System.Drawing.Point(0, 64)
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Brush
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.tChart1.Series.Add(Me.candleSeries1)
        Me.tChart1.Size = New System.Drawing.Size(425, 206)
        Me.tChart1.Tools.Add(Me.gridBand1)
        ' 
        ' candleSeries1
        ' 
        ' 
        ' candleSeries1.Brush
        ' 
        Me.candleSeries1.Brush.Color = System.Drawing.Color.Red
        Me.candleSeries1.CloseValues = Me.candleSeries1.YValues
        Me.candleSeries1.DateValues = Me.candleSeries1.XValues
        ' 
        ' candleSeries1.Marks
        ' 
        ' 
        ' candleSeries1.Marks.Symbol
        ' 
        ' 
        ' candleSeries1.Marks.Symbol.Shadow
        ' 
        Me.candleSeries1.Marks.Symbol.Shadow.Height = 1
        Me.candleSeries1.Marks.Symbol.Shadow.Visible = True
        Me.candleSeries1.Marks.Symbol.Shadow.Width = 1
        ' 
        ' candleSeries1.Pointer
        ' 
        ' 
        ' candleSeries1.Pointer.Brush
        ' 
        Me.candleSeries1.Pointer.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(0, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        Me.candleSeries1.Pointer.Draw3D = False
        Me.candleSeries1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.candleSeries1.Title = "candle1"
        ' 
        ' candleSeries1.XValues
        ' 
        Me.candleSeries1.XValues.DataMember = "Date"
        Me.candleSeries1.XValues.DateTime = True
        Me.candleSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' candleSeries1.YValues
        ' 
        Me.candleSeries1.YValues.DataMember = "Close"
        ' 
        ' checkBox1
        ' 
        Me.checkBox1.Checked = True
        Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox1.Location = New System.Drawing.Point(16, 8)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(292, 19)
        Me.checkBox1.TabIndex = 0
        Me.checkBox1.Text = "&Use the event to change Candle border colors"
        ' 
        ' gridBand1
        ' 
        Me.gridBand1.Axis = Me.tChart1.Axes.Left
        ' 
        ' gridBand1.Band1
        ' 
        Me.gridBand1.Band1.Color = System.Drawing.Color.FromArgb(CType(178, System.Byte), CType(224, System.Byte), CType(224, System.Byte), CType(224, System.Byte))
        ' 
        ' gridBand1.Band2
        ' 
        Me.gridBand1.Band2.Color = System.Drawing.Color.FromArgb(CType(178, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        ' 
        ' Candle_GetPointerStyle
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(425, 270)
        Me.Name = "Candle_GetPointerStyle"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub 'InitializeComponent 
#End Region


    Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox1.CheckedChanged
        candleSeries1.Repaint()
    End Sub 'checkBox1_CheckedChanged


    Private Sub candleSeries1_GetPointerStyle(ByVal series As Steema.TeeChart.Styles.CustomPoint, ByVal e As Steema.TeeChart.Styles.GetPointerStyleEventArgs) Handles candleSeries1.GetPointerStyle
        If checkBox1.Checked Then ' custom
            ' change some candle colors...
            If e.ValueIndex Mod 2 = 0 Then
                e.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
                candleSeries1.Pointer.Pen.Color = Color.Yellow
            Else
                e.Style = Steema.TeeChart.Styles.PointerStyles.Diamond
                candleSeries1.Pointer.Pen.Color = Color.Blue
            End If
            ' default 
        Else
            e.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
            candleSeries1.Pointer.Pen.Color = Color.Black
        End If
    End Sub 'candleSeries1_GetPointerStyle
End Class 'Candle_OnGetPointer