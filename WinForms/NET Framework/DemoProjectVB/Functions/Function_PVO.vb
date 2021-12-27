
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms


Public Class Function_PVO
    Inherits Steema.TeeChart.Samples.BaseForm
    Private volume1 As Steema.TeeChart.Styles.Volume
    Private button1 As System.Windows.Forms.Button
    Private fastLine1 As Steema.TeeChart.Styles.FastLine
    Private pvoFunction1 As Steema.TeeChart.Functions.PVOFunction
    Private components As System.ComponentModel.IContainer = Nothing
    
    Public Sub New() ' This call is required by the Windows Form Designer.
        InitializeComponent()

        volume1.FillSampleValues()

    End Sub


    '/ <summary>
    '/ Clean up any resources being used.
    '/ </summary>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If Disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(Disposing)
    End Sub 'Dispose

#Region "Windows Form Designer generated code"

    '/ <summary>
    '/ Required method for Designer support - do not modify
    '/ the contents of this method with the code editor.
    '/ </summary>
    Private Sub InitializeComponent()
        Me.volume1 = New Steema.TeeChart.Styles.Volume
        Me.button1 = New System.Windows.Forms.Button
        Me.fastLine1 = New Steema.TeeChart.Styles.FastLine
        Me.pvoFunction1 = New Steema.TeeChart.Functions.PVOFunction
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Text = "PVO function (Percentage Volume Oscillator) is a financial indicator. Requires on" + "e source series (of any type) and 2 period values."
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.button1)
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
        ' tChart1.Header
        ' 
        Me.tChart1.Header.Lines = New String() {"Percentage Volume Oscillator function"}
        ' 
        ' tChart1.Legend
        ' 
        Me.tChart1.Legend.Visible = False
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Brush
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.tChart1.Series.Add(Me.volume1)
        Me.tChart1.Series.Add(Me.fastLine1)
        ' 
        ' volume1
        ' 
        ' 
        ' volume1.Brush
        ' 
        Me.volume1.Brush.Color = System.Drawing.Color.Red
        Me.volume1.ClickableLine = False
        ' 
        ' volume1.LinePen
        ' 
        Me.volume1.LinePen.Color = System.Drawing.Color.Red
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
        Me.volume1.Pointer.Brush.Color = System.Drawing.Color.Red
        Me.volume1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.volume1.Title = "volume1"
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
        ' button1
        ' 
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.Location = New System.Drawing.Point(32, 8)
        Me.button1.Name = "button1"
        Me.button1.TabIndex = 0
        Me.button1.Text = "Edit..."
        AddHandler Me.button1.Click, AddressOf Me.button1_Click
        ' 
        ' fastLine1
        ' 
        Me.fastLine1.DataSource = Me.volume1
        Me.fastLine1.Function = Me.pvoFunction1
        ' 
        ' fastLine1.LinePen
        ' 
        Me.fastLine1.LinePen.Color = System.Drawing.Color.FromArgb(CType(255, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        ' 
        ' fastLine1.Marks
        ' 
        ' 
        ' fastLine1.Marks.Symbol
        ' 
        ' 
        ' fastLine1.Marks.Symbol.Shadow
        ' 
        Me.fastLine1.Marks.Symbol.Shadow.Height = 1
        Me.fastLine1.Marks.Symbol.Shadow.Visible = True
        Me.fastLine1.Marks.Symbol.Shadow.Width = 1
        Me.fastLine1.Title = "fastLine1"
        ' 
        ' fastLine1.XValues
        ' 
        Me.fastLine1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' pvoFunction1
        ' 
        Me.pvoFunction1.Period = 12
        ' 
        ' Function_PVO
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(440, 317)
        Me.Name = "Function_PVO"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub 'New 
#End Region


    Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim pvoEditor As New Steema.TeeChart.Editors.PVOFunctionEditor(fastLine1.Function)
        pvoEditor.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        pvoEditor.ShowDialog()
    End Sub 'button1_Click
End Class 'Function_PVO