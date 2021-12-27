
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing

Imports System.Windows.Forms




Public Class Bar_Image
    Inherits Steema.TeeChart.Samples.BaseForm
    Private barSeries1 As Steema.TeeChart.Styles.Bar
    Private checkBox1 As System.Windows.Forms.CheckBox
    Private imageList1 As System.Windows.Forms.ImageList
    Private barSeries2 As Steema.TeeChart.Styles.Bar
    Private gridBand1 As Steema.TeeChart.Tools.GridBand
    Private components As System.ComponentModel.IContainer = Nothing
    
    
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        
        For Each s As TeeChart.Styles.Series In Me.tChart1.Series
            s.FillSampleValues(3)
        Next s
        Me.checkBox1_CheckedChanged(Me.checkBox1, New System.EventArgs)
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
        Dim resources As New System.Resources.ResourceManager(GetType(Bar_Image))
        Me.barSeries1 = New Steema.TeeChart.Styles.Bar
        Me.checkBox1 = New System.Windows.Forms.CheckBox
        Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.barSeries2 = New Steema.TeeChart.Styles.Bar
        Me.gridBand1 = New Steema.TeeChart.Tools.GridBand
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(528, 64)
        Me.textBox1.Text = "Bar and Horiz.Bar series can display Images. At design-time, edit the Brush prope" + "rty. At run-time, you can use for example the code below." + vbCr + vbLf + vbCr + vbLf + "Example: barSeries1" + ".Brush.Image.LoadFile(@""c:\mybitmap.bmp"")"
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.checkBox1)
        Me.panel1.Location = New System.Drawing.Point(0, 64)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(528, 32)
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
        Me.tChart1.Location = New System.Drawing.Point(0, 96)
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
        Me.tChart1.Size = New System.Drawing.Size(528, 261)
        Me.tChart1.Tools.Add(Me.gridBand1)
        ' 
        ' barSeries1
        ' 
        ' 
        ' barSeries1.Brush
        ' 
        Me.barSeries1.Brush.Color = System.Drawing.Color.Red
        Me.barSeries1.Cursor = System.Windows.Forms.Cursors.Cross
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
        Me.barSeries1.Title = "barSeries1"
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
        ' checkBox1
        ' 
        Me.checkBox1.Checked = True
        Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox1.Location = New System.Drawing.Point(8, 8)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(136, 19)
        Me.checkBox1.TabIndex = 0
        Me.checkBox1.Text = "&Use patterns"
        AddHandler Me.checkBox1.CheckedChanged, AddressOf Me.checkBox1_CheckedChanged
        ' 
        ' imageList1
        ' 
        Me.imageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.imageList1.ImageStream = CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
        ' 
        ' barSeries2
        ' 
        ' 
        ' barSeries2.Brush
        ' 
        Me.barSeries2.Brush.Color = System.Drawing.Color.Green
        Me.barSeries2.Cursor = System.Windows.Forms.Cursors.Cross
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
        Me.barSeries2.Title = "barSeries2"
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
        Me.gridBand1.Band2.Color = System.Drawing.Color.FromArgb(CType(127, System.Byte), CType(192, System.Byte), CType(192, System.Byte), CType(192, System.Byte))
        ' 
        ' Bar_Image
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(528, 357)
        Me.Name = "Bar_Image"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub 'InitializeComponent 
#End Region


    Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        If Me.checkBox1.Checked Then
            'the imageList1 contains the patterns for this example
            Me.barSeries1.Brush.Image = Me.imageList1.Images(0)
            Me.barSeries2.Brush.Image = Me.imageList1.Images(1)
        Else
            Me.barSeries1.Brush.Image = Nothing
            Me.barSeries2.Brush.Image = Nothing
        End If
    End Sub 'checkBox1_CheckedChanged
End Class 'Bar_Image
