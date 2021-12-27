
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing

Imports System.Windows.Forms




Public Class ErrorBar_Negative
    Inherits Samples.BaseForm
    Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
    Private errorBarSeries1 As Steema.TeeChart.Styles.ErrorBar
    Private components As System.ComponentModel.IContainer = Nothing
    
    
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        
        Me.errorBarSeries1.Add(0, - 123, 23)
        Me.errorBarSeries1.Add(1, 432, 65)
        Me.errorBarSeries1.Add(2, - 88, 13)
        Me.errorBarSeries1.Add(3, 222, 44)
        Me.errorBarSeries1.Add(4, - 321, 49)
        ' custom properties for error pen
        Me.errorBarSeries1.ErrorPen.Color = Color.Blue
        Me.errorBarSeries1.ErrorPen.Width = 2
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
        Me.errorBarSeries1 = New Steema.TeeChart.Styles.ErrorBar
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(466, 32)
        Me.textBox1.Text = "Error Bar Series and Error Series accept negative values."
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
        Me.tChart1.Aspect.View3D = False
        ' 
        ' tChart1.Header
        ' 
        Me.tChart1.Header.Lines = New String() {"Error bar series with negative values"}
        Me.tChart1.Header.Visible = False
        Me.tChart1.Location = New System.Drawing.Point(0, 66)
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Brush
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        ' 
        ' tChart1.Panel.Gradient
        ' 
        Me.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(192, System.Byte), CType(192, System.Byte), CType(192, System.Byte))
        Me.tChart1.Panel.Brush.Gradient.Visible = True
        ' 
        ' tChart1.Panel.Gradient
        ' 
        Me.tChart1.Panel.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.tChart1.Panel.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(192, System.Byte), CType(192, System.Byte), CType(192, System.Byte))
        Me.tChart1.Panel.Gradient.Visible = True
        Me.tChart1.Series.Add(Me.errorBarSeries1)
        Me.tChart1.Size = New System.Drawing.Size(466, 220)
        ' 
        ' checkBox1
        ' 
        Me.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox1.Location = New System.Drawing.Point(13, 6)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(115, 21)
        Me.checkBox1.TabIndex = 0
        Me.checkBox1.Text = "&View 3D"
        ' 
        ' errorBarSeries1
        ' 
        ' 
        ' errorBarSeries1.Brush
        ' 
        Me.errorBarSeries1.Brush.Color = System.Drawing.Color.Red
        Me.errorBarSeries1.ErrorStyle = Steema.TeeChart.Styles.ErrorStyles.Top
        ' 
        ' errorBarSeries1.ErrorValues
        ' 
        Me.errorBarSeries1.ErrorValues.DataMember = "StdError"
        Me.errorBarSeries1.LabelMember = "Labels"
        ' 
        ' errorBarSeries1.Marks
        ' 
        ' 
        ' errorBarSeries1.Marks.Symbol
        ' 
        ' 
        ' errorBarSeries1.Marks.Symbol.Shadow
        ' 
        Me.errorBarSeries1.Marks.Symbol.Shadow.Height = 1
        Me.errorBarSeries1.Marks.Symbol.Shadow.Visible = True
        Me.errorBarSeries1.Marks.Symbol.Shadow.Width = 1
        Me.errorBarSeries1.Marks.Visible = False
        Me.errorBarSeries1.MultiBar = Steema.TeeChart.Styles.MultiBars.None
        Me.errorBarSeries1.Title = "errorBar1"
        ' 
        ' errorBarSeries1.XValues
        ' 
        Me.errorBarSeries1.XValues.DataMember = "X"
        Me.errorBarSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' errorBarSeries1.YValues
        ' 
        Me.errorBarSeries1.YValues.DataMember = "Bar"
        ' 
        ' ErrorBar_Negative
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(466, 286)
        Me.Name = "ErrorBar_Negative"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub 'InitializeComponent 
#End Region


    Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox1.CheckedChanged
        tChart1.Aspect.View3D = checkBox1.Checked
    End Sub 'checkBox1_CheckedChanged
End Class 'ErrorBar_Negative
