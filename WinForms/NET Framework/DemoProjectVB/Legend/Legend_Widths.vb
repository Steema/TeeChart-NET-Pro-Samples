Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Public Class Legend_Widths
    Inherits Samples.BaseForm
    Private checkBox1 As System.Windows.Forms.CheckBox
    Private numericUpDown1 As System.Windows.Forms.NumericUpDown
    Private label1 As System.Windows.Forms.Label
    Private label2 As System.Windows.Forms.Label
    Private numericUpDown2 As System.Windows.Forms.NumericUpDown
    Private gridBand1 As Steema.TeeChart.Tools.GridBand
    Private label3 As Label
    Private UDSymbolGap As NumericUpDown
    Private line1 As Steema.TeeChart.Styles.Line
    Private folderBrowserDialog1 As FolderBrowserDialog
    Private components As System.ComponentModel.IContainer = Nothing
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        Me.line1.FillSampleValues(20)

        UDSymbolGap.Value = tChart1.Legend.TextSymbolGap
    End Sub
    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub 'Dispose

#Region "Designer generated code"
    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Legend_Widths))
        Me.checkBox1 = New System.Windows.Forms.CheckBox()
        Me.numericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.label1 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.numericUpDown2 = New System.Windows.Forms.NumericUpDown()
        Me.gridBand1 = New Steema.TeeChart.Tools.GridBand()
        Me.label3 = New System.Windows.Forms.Label()
        Me.UDSymbolGap = New System.Windows.Forms.NumericUpDown()
        Me.line1 = New Steema.TeeChart.Styles.Line()
        Me.folderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.panel1.SuspendLayout()
        Me.chartContainer.SuspendLayout()
        DirectCast(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        DirectCast(Me.numericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        DirectCast(Me.UDSymbolGap, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Size = New System.Drawing.Size(466, 88)
        Me.textBox1.TabIndex = 0
        Me.textBox1.Text = resources.GetString("textBox1.Text")
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.label3)
        Me.panel1.Controls.Add(Me.UDSymbolGap)
        Me.panel1.Controls.Add(Me.numericUpDown2)
        Me.panel1.Controls.Add(Me.label2)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Controls.Add(Me.numericUpDown1)
        Me.panel1.Controls.Add(Me.checkBox1)
        Me.panel1.Location = New System.Drawing.Point(0, 88)
        Me.panel1.Size = New System.Drawing.Size(466, 65)
        Me.panel1.TabIndex = 1
        ' 
        ' tChart1
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Aspect.View3D = False
        Me.tChart1.Aspect.ZOffset = 0
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Bottom.Labels.DateTimeFormat = "dd/MM/yyyy"
        Me.tChart1.Axes.Bottom.MaximumOffset = 6
        Me.tChart1.Axes.Bottom.MinimumOffset = 6
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Left.MaximumOffset = 6
        Me.tChart1.Axes.Left.MinimumOffset = 6
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Header.Font.Brush.Color = System.Drawing.Color.FromArgb(CInt(CByte(64)), CInt(CByte(64)), CInt(CByte(64)))
        Me.tChart1.Header.Font.Size = 11
        Me.tChart1.Header.Font.SizeFloat = 11.0F
        Me.tChart1.Header.Lines = New String() {"Adjusting Legend spacing"}
        ' 
        ' 
        ' 
        Me.tChart1.Legend.BorderRound = 8
        ' 
        ' 
        ' 
        Me.tChart1.Legend.Pen.Color = System.Drawing.Color.FromArgb(CInt(CByte(255)), CInt(CByte(128)), CInt(CByte(0)))
        ' 
        ' 
        ' 
        Me.tChart1.Legend.Shadow.Visible = False
        Me.tChart1.Legend.ShapeStyle = Steema.TeeChart.Drawing.TextShapeStyle.RoundRectangle
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CInt(CByte(254)), CInt(CByte(255)), CInt(CByte(255)), CInt(CByte(255)))
        ' 
        ' 
        ' 
        Me.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(CInt(CByte(185)), CInt(CByte(185)), CInt(CByte(225)))
        Me.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CInt(CByte(234)), CInt(CByte(234)), CInt(CByte(254)))
        Me.tChart1.Series.Add(Me.line1)
        Me.tChart1.Size = New System.Drawing.Size(466, 133)
        Me.tChart1.TabIndex = 2
        Me.tChart1.Tools.Add(Me.gridBand1)
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Walls.Back.Pen.Visible = False
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Walls.Bottom.Pen.Visible = False
        Me.tChart1.Walls.Bottom.Size = 5
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Walls.Left.Pen.Visible = False
        Me.tChart1.Walls.Left.Size = 5
        ' 
        ' chartContainer
        ' 
        Me.chartContainer.Location = New System.Drawing.Point(0, 153)
        Me.chartContainer.Size = New System.Drawing.Size(466, 133)
        ' 
        ' checkBox1
        ' 
        Me.checkBox1.Checked = True
        Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox1.Location = New System.Drawing.Point(13, 9)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(120, 21)
        Me.checkBox1.TabIndex = 0
        Me.checkBox1.Text = "&Automatic widths"
        AddHandler Me.checkBox1.CheckedChanged, AddressOf Me.checkBox1_CheckedChanged
        ' 
        ' numericUpDown1
        ' 
        Me.numericUpDown1.Enabled = False
        Me.numericUpDown1.Location = New System.Drawing.Point(216, 9)
        Me.numericUpDown1.Name = "numericUpDown1"
        Me.numericUpDown1.Size = New System.Drawing.Size(47, 20)
        Me.numericUpDown1.TabIndex = 2
        Me.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numericUpDown1.Value = New Decimal(New Integer() {30, 0, 0, 0})
        AddHandler Me.numericUpDown1.ValueChanged, AddressOf Me.numericUpDown1_ValueChanged
        ' 
        ' label1
        ' 
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(130, 11)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(82, 13)
        Me.label1.TabIndex = 1
        Me.label1.Text = "Column &1 width:"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        ' 
        ' label2
        ' 
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(130, 39)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(82, 13)
        Me.label2.TabIndex = 3
        Me.label2.Text = "Column &2 width:"
        Me.label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        ' 
        ' numericUpDown2
        ' 
        Me.numericUpDown2.Enabled = False
        Me.numericUpDown2.Location = New System.Drawing.Point(216, 37)
        Me.numericUpDown2.Name = "numericUpDown2"
        Me.numericUpDown2.Size = New System.Drawing.Size(47, 20)
        Me.numericUpDown2.TabIndex = 4
        Me.numericUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numericUpDown2.Value = New Decimal(New Integer() {14, 0, 0, 0})
        AddHandler Me.numericUpDown2.ValueChanged, AddressOf Me.numericUpDown2_ValueChanged
        ' 
        ' gridBand1
        ' 
        Me.gridBand1.Axis = Me.tChart1.Axes.Left
        ' 
        ' 
        ' 
        Me.gridBand1.Band1.Color = System.Drawing.Color.FromArgb(CInt(CByte(0)), CInt(CByte(0)), CInt(CByte(0)), CInt(CByte(0)))
        ' 
        ' 
        ' 
        Me.gridBand1.Band2.Color = System.Drawing.Color.FromArgb(CInt(CByte(51)), CInt(CByte(192)), CInt(CByte(192)), CInt(CByte(255)))
        ' 
        ' label3
        ' 
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(280, 11)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(121, 13)
        Me.label3.TabIndex = 5
        Me.label3.Text = "Ad&just gap Symbol-Text:"
        Me.label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        ' 
        ' UDSymbolGap
        ' 
        Me.UDSymbolGap.Location = New System.Drawing.Point(408, 9)
        Me.UDSymbolGap.Maximum = New Decimal(New Integer() {30, 0, 0, 0})
        Me.UDSymbolGap.Minimum = New Decimal(New Integer() {5, 0, 0, -2147483648})
        Me.UDSymbolGap.Name = "UDSymbolGap"
        Me.UDSymbolGap.Size = New System.Drawing.Size(47, 20)
        Me.UDSymbolGap.TabIndex = 6
        Me.UDSymbolGap.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        AddHandler Me.UDSymbolGap.ValueChanged, AddressOf Me.UDSymbolGap_ValueChanged
        ' 
        ' line1
        ' 
        ' 
        ' 
        ' 
        Me.line1.Brush.Color = System.Drawing.Color.FromArgb(CInt(CByte(68)), CInt(CByte(102)), CInt(CByte(163)))
        Me.line1.Color = System.Drawing.Color.FromArgb(CInt(CByte(68)), CInt(CByte(102)), CInt(CByte(163)))
        Me.line1.ColorEach = False
        ' 
        ' 
        ' 
        Me.line1.LinePen.Color = System.Drawing.Color.FromArgb(CInt(CByte(41)), CInt(CByte(61)), CInt(CByte(98)))
        Me.line1.LinePen.Width = 2
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.line1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None
        Me.line1.Marks.Callout.ArrowHeadSize = 8
        ' 
        ' 
        ' 
        Me.line1.Marks.Callout.Brush.Color = System.Drawing.Color.Black
        Me.line1.Marks.Callout.Distance = 0
        Me.line1.Marks.Callout.Draw3D = False
        Me.line1.Marks.Callout.Length = 10
        Me.line1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        ' 
        ' 
        ' 
        Me.line1.Pointer.HorizSize = 5
        ' 
        ' 
        ' 
        Me.line1.Pointer.Pen.Visible = False
        Me.line1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Sphere
        Me.line1.Pointer.VertSize = 5
        Me.line1.Pointer.Visible = True
        Me.line1.Title = "line1"
        ' 
        ' 
        ' 
        Me.line1.XValues.DataMember = "X"
        Me.line1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' 
        ' 
        Me.line1.YValues.DataMember = "Y"
        ' 
        ' Legend_Widths
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(466, 286)
        Me.Name = "Legend_Widths"
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.chartContainer.ResumeLayout(False)
        DirectCast(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        DirectCast(Me.numericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        DirectCast(Me.UDSymbolGap, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub
#End Region
    Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.tChart1.Legend.ColumnWidthAuto = Me.checkBox1.Checked
        Me.tChart1.Refresh()

        Me.numericUpDown1.Enabled = Not Me.tChart1.Legend.ColumnWidthAuto
        Me.numericUpDown2.Enabled = Not Me.tChart1.Legend.ColumnWidthAuto

        numericUpDown1.Value = tChart1.Legend.ColumnWidths(0)
        numericUpDown2.Value = tChart1.Legend.ColumnWidths(1)
    End Sub

    Private Sub numericUpDown1_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.tChart1.Legend.ColumnWidths(0) = CInt(Me.numericUpDown1.Value)
        Me.tChart1.Refresh()
    End Sub

    Private Sub numericUpDown2_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.tChart1.Legend.ColumnWidths(1) = CInt(Me.numericUpDown2.Value)
        Me.tChart1.Refresh()
    End Sub
    Private Sub UDSymbolGap_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
        Me.tChart1.Legend.TextSymbolGap = CInt(UDSymbolGap.Value)
    End Sub
End Class 'Legend_Widths
