
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms



Public Class HighLow_Series
    Inherits Samples.BaseForm
    Private highLowSeries1 As Steema.TeeChart.Styles.HighLow
    Private WithEvents button1 As System.Windows.Forms.Button
    Private gridBand1 As Steema.TeeChart.Tools.GridBand
    Private components As System.ComponentModel.IContainer = Nothing
    
    
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        
        highLowSeries1.FillSampleValues(20)
        highLowSeries1.Color = Color.Red
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
        Me.highLowSeries1 = New Steema.TeeChart.Styles.HighLow
        Me.button1 = New System.Windows.Forms.Button
        Me.gridBand1 = New Steema.TeeChart.Tools.GridBand
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(466, 40)
        Me.textBox1.Text = "High-Low series draws (and optionally fills) two lines with High and Low values f" + "or each point."
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.button1)
        Me.panel1.Location = New System.Drawing.Point(0, 40)
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
        Me.tChart1.Location = New System.Drawing.Point(0, 73)
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Brush
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.tChart1.Series.Add(Me.highLowSeries1)
        Me.tChart1.Size = New System.Drawing.Size(466, 213)
        Me.tChart1.Tools.Add(Me.gridBand1)
        ' 
        ' highLowSeries1
        ' 
        ' 
        ' highLowSeries1.HighBrush
        ' 
        Me.highLowSeries1.HighBrush.Solid = False
        Me.highLowSeries1.HighBrush.Style = System.Drawing.Drawing2D.HatchStyle.Percent50
        ' 
        ' highLowSeries1.YValues
        ' 
        Me.highLowSeries1.HighValues.DataMember = "Y"
        Me.highLowSeries1.LabelMember = "Labels"
        ' 
        ' highLowSeries1.LowBrush
        ' 
        Me.highLowSeries1.LowBrush.Solid = False
        Me.highLowSeries1.LowBrush.Style = System.Drawing.Drawing2D.HatchStyle.Percent50
        ' 
        ' highLowSeries1.LowValues
        ' 
        Me.highLowSeries1.LowValues.DataMember = "Low"
        ' 
        ' highLowSeries1.Marks
        ' 
        ' 
        ' highLowSeries1.Marks.Symbol
        ' 
        ' 
        ' highLowSeries1.Marks.Symbol.Shadow
        ' 
        Me.highLowSeries1.Marks.Symbol.Shadow.Height = 1
        Me.highLowSeries1.Marks.Symbol.Shadow.Visible = True
        Me.highLowSeries1.Marks.Symbol.Shadow.Width = 1
        Me.highLowSeries1.Title = "high-Low1"
        ' 
        ' highLowSeries1.XValues
        ' 
        Me.highLowSeries1.XValues.DataMember = "X"
        Me.highLowSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' highLowSeries1.YValues
        ' 
        Me.highLowSeries1.YValues.DataMember = "Y"
        ' 
        ' button1
        ' 
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.Location = New System.Drawing.Point(16, 5)
        Me.button1.Name = "button1"
        Me.button1.TabIndex = 0
        Me.button1.Text = "&Edit..."
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
        ' SeriesType_HighLow
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(466, 286)
        Me.Name = "SeriesType_HighLow"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub 'InitializeComponent 
#End Region


    Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
        TeeChart.Editors.SeriesEditor.ShowModal(highLowSeries1)
    End Sub 'button1_Click
End Class 'HighLow_Series
