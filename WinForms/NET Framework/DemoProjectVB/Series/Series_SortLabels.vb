
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing

Imports System.Windows.Forms




Public Class Series_SortLabels
    Inherits Samples.BaseForm
    Private barSeries1 As Steema.TeeChart.Styles.Bar
    Private WithEvents comboBox1 As System.Windows.Forms.ComboBox
    Private label2 As System.Windows.Forms.Label
    Private label3 As System.Windows.Forms.Label
    Private gridBand1 As Steema.TeeChart.Tools.GridBand
    Private components As System.ComponentModel.IContainer = Nothing
    
    
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        
        barSeries1.Add(323, "John")
        barSeries1.Add(222, "Anne")
        barSeries1.Add(456, "Matt")
        barSeries1.Add(188, "Sean")
        barSeries1.Add(701, "Andrew")
        barSeries1.Add(411, "Marc")
        
        label3.Text = ""
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
        Me.barSeries1 = New Steema.TeeChart.Styles.Bar
        Me.comboBox1 = New System.Windows.Forms.ComboBox
        Me.label2 = New System.Windows.Forms.Label
        Me.label3 = New System.Windows.Forms.Label
        Me.gridBand1 = New Steema.TeeChart.Tools.GridBand
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(466, 64)
        Me.textBox1.TabIndex = 0
        Me.textBox1.Text = "Series data can be sorted by point's text, in ascending or descending order." + vbCr + vbLf + "Not" + "e: After applying text order, the ""X"" values are lost." + vbCr + vbLf + vbCr + vbLf + "barSeries1.SortByLabel" + "s(ValueListOrder.Ascending)"
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.label3)
        Me.panel1.Controls.Add(Me.label2)
        Me.panel1.Controls.Add(Me.comboBox1)
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
        Me.tChart1.Aspect.Chart3DPercent = 25
        Me.tChart1.Aspect.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality
        Me.tChart1.Aspect.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        ' 
        ' tChart1.Axes
        ' 
        ' 
        ' tChart1.Axes.Bottom
        ' 
        ' 
        ' tChart1.Axes.Bottom.Grid
        ' 
        Me.tChart1.Axes.Bottom.Grid.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(0, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        Me.tChart1.Axes.Bottom.Grid.Style = System.Drawing.Drawing2D.DashStyle.Solid
        ' 
        ' tChart1.Axes.Left
        ' 
        ' 
        ' tChart1.Axes.Left.Grid
        ' 
        Me.tChart1.Axes.Left.Grid.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        Me.tChart1.Axes.Left.Grid.Style = System.Drawing.Drawing2D.DashStyle.Solid
        Me.tChart1.BackColor = System.Drawing.Color.Transparent
        Me.tChart1.Cursor = System.Windows.Forms.Cursors.Default
        ' 
        ' tChart1.Header
        ' 
        ' 
        ' tChart1.Header.Brush
        ' 
        Me.tChart1.Header.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.tChart1.Header.Lines = New String() {"Data sorting by labels"}
        ' 
        ' tChart1.Header.Shadow
        ' 
        ' 
        ' tChart1.Header.Shadow.Brush
        ' 
        Me.tChart1.Header.Shadow.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(0, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        Me.tChart1.Header.Shadow.Height = 1
        Me.tChart1.Header.Shadow.Visible = True
        Me.tChart1.Header.Shadow.Width = 1
        Me.tChart1.Header.Transparent = False
        ' 
        ' tChart1.Legend
        ' 
        ' 
        ' tChart1.Legend.Symbol
        ' 
        Me.tChart1.Legend.Symbol.DefaultPen = False
        Me.tChart1.Location = New System.Drawing.Point(0, 104)
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Brush
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(192, System.Byte), CType(192, System.Byte), CType(192, System.Byte))
        ' 
        ' tChart1.Panel.Gradient
        ' 
        Me.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(128, System.Byte), CType(128, System.Byte), CType(128, System.Byte))
        Me.tChart1.Panel.Brush.Gradient.Visible = True
        ' 
        ' tChart1.Panel.Gradient
        ' 
        Me.tChart1.Panel.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(128, System.Byte), CType(128, System.Byte), CType(128, System.Byte))
        Me.tChart1.Panel.Gradient.Visible = True
        Me.tChart1.Series.Add(Me.barSeries1)
        Me.tChart1.Size = New System.Drawing.Size(466, 182)
        Me.tChart1.TabIndex = 2
        Me.tChart1.Tools.Add(Me.gridBand1)
        ' 
        ' barSeries1
        ' 
        Me.barSeries1.BarStyle = Steema.TeeChart.Styles.BarStyles.Cylinder
        ' 
        ' barSeries1.Brush
        ' 
        Me.barSeries1.Brush.Color = System.Drawing.Color.FromArgb(CType(191, System.Byte), CType(0, System.Byte), CType(0, System.Byte), CType(128, System.Byte))
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
        ' 
        ' barSeries1.Pen
        ' 
        Me.barSeries1.Pen.Color = System.Drawing.Color.FromArgb(CType(191, System.Byte), CType(0, System.Byte), CType(0, System.Byte), CType(77, System.Byte))
        Me.barSeries1.Pen.Transparency = 30
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
        ' comboBox1
        ' 
        Me.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboBox1.Items.AddRange(New Object() {"Ascending", "Descending"})
        Me.comboBox1.Location = New System.Drawing.Point(80, 8)
        Me.comboBox1.Name = "comboBox1"
        Me.comboBox1.Size = New System.Drawing.Size(121, 21)
        Me.comboBox1.TabIndex = 1
        ' 
        ' label2
        ' 
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(24, 11)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(53, 16)
        Me.label2.TabIndex = 2
        Me.label2.Text = "Sort type:"
        ' 
        ' label3
        ' 
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(216, 11)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(35, 16)
        Me.label3.TabIndex = 3
        Me.label3.Text = "label3"
        ' 
        ' gridBand1
        ' 
        Me.gridBand1.Axis = Me.tChart1.Axes.Left
        ' 
        ' gridBand1.Band1
        ' 
        Me.gridBand1.Band1.Color = System.Drawing.Color.FromArgb(CType(127, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        ' 
        ' gridBand1.Band2
        ' 
        Me.gridBand1.Band2.Color = System.Drawing.Color.FromArgb(CType(127, System.Byte), CType(224, System.Byte), CType(224, System.Byte), CType(224, System.Byte))
        ' 
        ' SeriesSortLabels
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(466, 286)
        Me.Name = "SeriesSortLabels"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub 'InitializeComponent 
#End Region


    Private Sub comboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboBox1.SelectedIndexChanged
        If comboBox1.SelectedIndex = 0 Then
            barSeries1.SortByLabels(Styles.ValueListOrder.Ascending)
            label3.Text = "Data is sorted by text (ascending)"
        Else
            barSeries1.SortByLabels(Styles.ValueListOrder.Descending)
            label3.Text = "Data is sorted by text (descending)"
        End If
    End Sub 'comboBox1_SelectedIndexChanged
End Class 'Series_SortLabels 
