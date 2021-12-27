
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing

Imports System.Windows.Forms




Public Class Volume_Origin
    Inherits Samples.BaseForm
    Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
    Private volumeSeries1 As Steema.TeeChart.Styles.Volume
    Private WithEvents numericUpDown1 As System.Windows.Forms.NumericUpDown
    Private gridBand1 As Steema.TeeChart.Tools.GridBand
    Private components As System.ComponentModel.IContainer = Nothing
    
    
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        
        ' TODO : add the YOrigin boolean to true when it's available
        volumeSeries1.FillSampleValues(60)
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
        Me.volumeSeries1 = New Steema.TeeChart.Styles.Volume
        Me.numericUpDown1 = New System.Windows.Forms.NumericUpDown
        Me.gridBand1 = New Steema.TeeChart.Tools.GridBand
        Me.panel1.SuspendLayout()
        CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(466, 63)
        Me.textBox1.Text = "Volume Series introduces two properties: bool UseOrigin double Origin." + vbCr + vbLf + "When UseOrigin is true, lines are displayed starting at Origin value. When false, lines start at minimum value." + vbCr + vbLf + vbCr + vbLf + "volumeSeries1.Origin = 33                 " + vbCr + vbLf + "volumeSeries1.UseOrigin = true "
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.numericUpDown1)
        Me.panel1.Controls.Add(Me.checkBox1)
        Me.panel1.Location = New System.Drawing.Point(0, 63)
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
        Me.tChart1.Header.Lines = New String() {"Volume Series - using a Y Origin value"}
        Me.tChart1.Header.Visible = False
        ' 
        ' tChart1.Legend
        ' 
        Me.tChart1.Legend.Alignment = Steema.TeeChart.LegendAlignments.Top
        Me.tChart1.Legend.Visible = False
        Me.tChart1.Location = New System.Drawing.Point(0, 97)
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Brush
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.tChart1.Series.Add(Me.volumeSeries1)
        Me.tChart1.Size = New System.Drawing.Size(466, 189)
        Me.tChart1.Tools.Add(Me.gridBand1)
        ' 
        ' checkBox1
        ' 
        Me.checkBox1.Checked = True
        Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox1.Location = New System.Drawing.Point(13, 7)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(107, 21)
        Me.checkBox1.TabIndex = 0
        Me.checkBox1.Text = "&Y Origin:"
        ' 
        ' volumeSeries1
        ' 
        ' 
        ' volumeSeries1.Brush
        ' 
        Me.volumeSeries1.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(0, System.Byte), CType(128, System.Byte), CType(0, System.Byte))
        Me.volumeSeries1.ClickableLine = False
        ' 
        ' volumeSeries1.LinePen
        ' 
        Me.volumeSeries1.LinePen.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(0, System.Byte), CType(128, System.Byte), CType(0, System.Byte))
        ' 
        ' volumeSeries1.Marks
        ' 
        ' 
        ' volumeSeries1.Marks.Symbol
        ' 
        ' 
        ' volumeSeries1.Marks.Symbol.Shadow
        ' 
        Me.volumeSeries1.Marks.Symbol.Shadow.Height = 1
        Me.volumeSeries1.Marks.Symbol.Shadow.Visible = True
        Me.volumeSeries1.Marks.Symbol.Shadow.Width = 1
        ' 
        ' volumeSeries1.Pointer
        ' 
        ' 
        ' volumeSeries1.Pointer.Brush
        ' 
        Me.volumeSeries1.Pointer.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(0, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        Me.volumeSeries1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.volumeSeries1.Title = "volume1"
        Me.volumeSeries1.UseOrigin = True
        ' 
        ' volumeSeries1.XValues
        ' 
        Me.volumeSeries1.XValues.DataMember = "X"
        Me.volumeSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' volumeSeries1.YValues
        ' 
        Me.volumeSeries1.YValues.DataMember = "Y"
        ' 
        ' numericUpDown1
        ' 
        Me.numericUpDown1.Location = New System.Drawing.Point(128, 7)
        Me.numericUpDown1.Maximum = New System.Decimal(New Integer() {20000, 0, 0, 0})
        Me.numericUpDown1.Minimum = New System.Decimal(New Integer() {20000, 0, 0, -2147483648})
        Me.numericUpDown1.Name = "numericUpDown1"
        Me.numericUpDown1.Size = New System.Drawing.Size(52, 20)
        Me.numericUpDown1.TabIndex = 1
        Me.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numericUpDown1.Value = New System.Decimal(New Integer() {33, 0, 0, 0})
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
        ' Volume_Origin
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(466, 286)
        Me.Name = "Volume_Origin"
        Me.panel1.ResumeLayout(False)
        CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub 'InitializeComponent 
#End Region


    Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox1.CheckedChanged
        volumeSeries1.UseOrigin = checkBox1.Checked
        Me.numericUpDown1.Enabled = checkBox1.Checked
    End Sub 'checkBox1_CheckedChanged


    Private Sub numericUpDown1_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles numericUpDown1.TextChanged, numericUpDown1.ValueChanged
        volumeSeries1.Origin = System.Convert.ToDouble(numericUpDown1.Value)
    End Sub 'numericUpDown1_ValueChanged
End Class 'Volume_Origin
