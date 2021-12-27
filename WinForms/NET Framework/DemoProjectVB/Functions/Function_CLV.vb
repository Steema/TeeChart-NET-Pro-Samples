
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms



Public Class Function_CLV
    Inherits Steema.TeeChart.Samples.BaseForm
    Private candle1 As Steema.TeeChart.Styles.Candle
    Private axis1 As Steema.TeeChart.Axis
    Private volume1 As Steema.TeeChart.Styles.Volume
    Private axis2 As Steema.TeeChart.Axis
    Private clvFunction1 As Steema.TeeChart.Functions.CLVFunction
    Private line1 As Steema.TeeChart.Styles.Line
    Private axis3 As Steema.TeeChart.Axis
    Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
    Private WithEvents checkBox2 As System.Windows.Forms.CheckBox
    Private components As System.ComponentModel.IContainer = Nothing
    
    
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        
        candle1.FillSampleValues()
        volume1.FillSampleValues()
        
        checkBox1.Checked = clvFunction1.Accumulate
        checkBox2.Checked = Not (clvFunction1.Volume Is Nothing)
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
        Me.components = New System.ComponentModel.Container
        Me.candle1 = New Steema.TeeChart.Styles.Candle
        Me.axis1 = New Steema.TeeChart.Axis(Me.tChart1.Chart)
        Me.volume1 = New Steema.TeeChart.Styles.Volume
        Me.axis2 = New Steema.TeeChart.Axis(Me.tChart1.Chart)
        Me.clvFunction1 = New Steema.TeeChart.Functions.CLVFunction
        Me.line1 = New Steema.TeeChart.Styles.Line
        Me.axis3 = New Steema.TeeChart.Axis(Me.tChart1.Chart)
        Me.checkBox1 = New System.Windows.Forms.CheckBox
        Me.checkBox2 = New System.Windows.Forms.CheckBox
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Text = """Accumulation / Distribution Line"" function ( CLV ) is a financial indicator. " + vbCr + vbLf + "The formula is:  ( scroll down to see all ) " + vbCr + vbLf + vbCr + vbLf + "((( Close - Low ) - ( High - Close )) / ( High - Low )) x Volume " + vbCr + vbLf + vbCr + vbLf + "Results can be optionally acumulated and / or multiplied by a Volume series,"
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.checkBox2)
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
        Me.tChart1.Aspect.View3D = False
        ' 
        ' tChart1.Axes
        ' 
        Me.tChart1.Axes.Custom.Add(Me.axis1)
        Me.tChart1.Axes.Custom.Add(Me.axis2)
        Me.tChart1.Axes.Custom.Add(Me.axis3)
        Me.tChart1.Cursor = System.Windows.Forms.Cursors.Default
        ' 
        ' tChart1.Header
        ' 
        Me.tChart1.Header.Lines = New String(-1) {}
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Brush
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.tChart1.Panel.MarginLeft = 7
        Me.tChart1.Series.Add(Me.candle1)
        Me.tChart1.Series.Add(Me.volume1)
        Me.tChart1.Series.Add(Me.line1)
        ' 
        ' candle1
        ' 
        ' 
        ' candle1.Brush
        ' 
        Me.candle1.Brush.Color = System.Drawing.Color.Red
        Me.candle1.CloseValues = Me.candle1.YValues
        Me.candle1.CustomVertAxis = Me.axis1
        Me.candle1.DateValues = Me.candle1.XValues
        ' 
        ' candle1.Marks
        ' 
        ' 
        ' candle1.Marks.Symbol
        ' 
        ' 
        ' candle1.Marks.Symbol.Shadow
        ' 
        Me.candle1.Marks.Symbol.Shadow.Height = 1
        Me.candle1.Marks.Symbol.Shadow.Visible = True
        Me.candle1.Marks.Symbol.Shadow.Width = 1
        ' 
        ' candle1.Pointer
        ' 
        ' 
        ' candle1.Pointer.Brush
        ' 
        Me.candle1.Pointer.Brush.Color = System.Drawing.Color.Red
        Me.candle1.Pointer.Draw3D = False
        Me.candle1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.candle1.Title = "Candle"
        Me.candle1.VertAxis = Steema.TeeChart.Styles.VerticalAxis.Custom
        ' 
        ' candle1.XValues
        ' 
        Me.candle1.XValues.DataMember = "Date"
        Me.candle1.XValues.DateTime = True
        Me.candle1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' candle1.YValues
        ' 
        Me.candle1.YValues.DataMember = "Close"
        ' 
        ' axis1
        ' 
        Me.axis1.EndPosition = 37
        Me.axis1.Horizontal = False
        Me.axis1.OtherSide = False
        ' 
        ' volume1
        ' 
        ' 
        ' volume1.Brush
        ' 
        Me.volume1.Brush.Color = System.Drawing.Color.Green
        Me.volume1.ClickableLine = False
        Me.volume1.CustomVertAxis = Me.axis2
        ' 
        ' volume1.LinePen
        ' 
        Me.volume1.LinePen.Color = System.Drawing.Color.Green
        ' 
        ' volume1.Marks
        ' 
        ' 
        ' volume1.Marks.Symbol
        ' 
        ' 
        ' volume1.Marks.Symbol.Shadow
        ' 
        Me.volume1.Marks.Symbol.Shadow.Height = 1
        Me.volume1.Marks.Symbol.Shadow.Visible = True
        Me.volume1.Marks.Symbol.Shadow.Width = 1
        ' 
        ' volume1.Pointer
        ' 
        ' 
        ' volume1.Pointer.Brush
        ' 
        Me.volume1.Pointer.Brush.Color = System.Drawing.Color.Green
        Me.volume1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.volume1.Title = "Volume"
        Me.volume1.VertAxis = Steema.TeeChart.Styles.VerticalAxis.Custom
        ' 
        ' volume1.XValues
        ' 
        Me.volume1.XValues.DataMember = "X"
        Me.volume1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' volume1.YValues
        ' 
        Me.volume1.YValues.DataMember = "Y"
        ' 
        ' axis2
        ' 
        Me.axis2.EndPosition = 69
        Me.axis2.Horizontal = False
        Me.axis2.OtherSide = False
        Me.axis2.StartPosition = 40
        ' 
        ' clvFunction1
        ' 
        Me.clvFunction1.Accumulate = True
        Me.clvFunction1.Period = 1
        Me.clvFunction1.Volume = Me.volume1
        ' 
        ' line1
        ' 
        ' 
        ' line1.Brush
        ' 
        Me.line1.Brush.Color = System.Drawing.Color.Yellow
        Me.line1.CustomVertAxis = Me.axis3
        Me.line1.DataSource = Me.candle1
        Me.line1.Function = Me.clvFunction1
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
        Me.line1.Pointer.Brush.Color = System.Drawing.Color.Yellow
        Me.line1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.line1.Title = "CLV Function"
        Me.line1.VertAxis = Steema.TeeChart.Styles.VerticalAxis.Custom
        ' 
        ' line1.XValues
        ' 
        Me.line1.XValues.DateTime = True
        Me.line1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' axis3
        ' 
        Me.axis3.Horizontal = False
        Me.axis3.OtherSide = False
        Me.axis3.StartPosition = 72
        ' 
        ' checkBox1
        ' 
        Me.checkBox1.Location = New System.Drawing.Point(16, 8)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.TabIndex = 0
        Me.checkBox1.Text = "Accumulate"
        ' 
        ' checkBox2
        ' 
        Me.checkBox2.Location = New System.Drawing.Point(144, 8)
        Me.checkBox2.Name = "checkBox2"
        Me.checkBox2.Size = New System.Drawing.Size(128, 24)
        Me.checkBox2.TabIndex = 1
        Me.checkBox2.Text = "Multiply by Volume"
        ' 
        ' Function_CLV
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(440, 317)
        Me.Name = "Function_CLV"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub 'InitializeComponent 
#End Region


    Private Sub checkBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox1.Click
        clvFunction1.Accumulate = checkBox1.Checked
    End Sub 'checkBox1_Click


    Private Sub checkBox2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox2.Click
        clvFunction1.Volume = IIf(checkBox2.Checked, volume1, Nothing)
    End Sub 'checkBox2_Click
End Class 'Function_CLV 
