
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms



Public Class HorizLine_Series
    Inherits Samples.BaseForm
    Private horizLineSeries1 As Steema.TeeChart.Styles.HorizLine
    Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
    Private gridBand1 As Steema.TeeChart.Tools.GridBand
    Private components As System.ComponentModel.IContainer = Nothing
    
    
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        
        horizLineSeries1.Pointer.Visible = True
        horizLineSeries1.FillSampleValues(8)
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
        Me.horizLineSeries1 = New Steema.TeeChart.Styles.HorizLine
        Me.checkBox1 = New System.Windows.Forms.CheckBox
        Me.gridBand1 = New Steema.TeeChart.Tools.GridBand
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(466, 48)
        Me.textBox1.Text = "Horizontal Line series is like a line series that draws points sorted on their Y " + "values instead of the X values."
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.checkBox1)
        Me.panel1.Location = New System.Drawing.Point(0, 48)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(466, 33)
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
        Me.tChart1.Header.Lines = New String() {"tChart1"}
        Me.tChart1.Header.Visible = False
        ' 
        ' tChart1.Legend
        ' 
        Me.tChart1.Legend.Visible = False
        Me.tChart1.Location = New System.Drawing.Point(0, 81)
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Brush
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.tChart1.Series.Add(Me.horizLineSeries1)
        Me.tChart1.Size = New System.Drawing.Size(466, 205)
        Me.tChart1.Tools.Add(Me.gridBand1)
        ' 
        ' horizLineSeries1
        ' 
        ' 
        ' horizLineSeries1.Brush
        ' 
        Me.horizLineSeries1.Brush.Color = System.Drawing.Color.FromArgb(CType(255, System.Byte), CType(128, System.Byte), CType(0, System.Byte))
        ' 
        ' horizLineSeries1.Marks
        ' 
        ' 
        ' horizLineSeries1.Marks.Symbol
        ' 
        ' 
        ' horizLineSeries1.Marks.Symbol.Shadow
        ' 
        Me.horizLineSeries1.Marks.Symbol.Shadow.Height = 1
        Me.horizLineSeries1.Marks.Symbol.Shadow.Visible = True
        Me.horizLineSeries1.Marks.Symbol.Shadow.Width = 1
        ' 
        ' horizLineSeries1.Pointer
        ' 
        ' 
        ' horizLineSeries1.Pointer.Brush
        ' 
        Me.horizLineSeries1.Pointer.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(0, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        Me.horizLineSeries1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.horizLineSeries1.Title = "horizLine1"
        ' 
        ' horizLineSeries1.XValues
        ' 
        Me.horizLineSeries1.XValues.DataMember = "X"
        ' 
        ' horizLineSeries1.YValues
        ' 
        Me.horizLineSeries1.YValues.DataMember = "Y"
        Me.horizLineSeries1.YValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' checkBox1
        ' 
        Me.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox1.Location = New System.Drawing.Point(20, 7)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(68, 21)
        Me.checkBox1.TabIndex = 1
        Me.checkBox1.Text = "&Stairs"
        ' 
        ' gridBand1
        ' 
        Me.gridBand1.Axis = Me.tChart1.Axes.Bottom
        ' 
        ' gridBand1.Band1
        ' 
        Me.gridBand1.Band1.Color = System.Drawing.Color.FromArgb(CType(127, System.Byte), CType(192, System.Byte), CType(192, System.Byte), CType(192, System.Byte))
        ' 
        ' gridBand1.Band2
        ' 
        Me.gridBand1.Band2.Color = System.Drawing.Color.FromArgb(CType(127, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        ' 
        ' SeriesType_HorizLine
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(466, 286)
        Me.Name = "SeriesType_HorizLine"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub 'InitializeComponent 
#End Region


    Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox1.CheckedChanged
        horizLineSeries1.Stairs = checkBox1.Checked
    End Sub 'checkBox1_CheckedChanged
End Class 'HorizLine_Series
