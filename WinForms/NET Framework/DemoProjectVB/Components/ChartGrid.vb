
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Data



Public Class ChartGrid
    Inherits Steema.TeeChart.Samples.BaseNoChart
    Private WithEvents dataGrid1 As System.Windows.Forms.DataGrid
    Private splitter1 As System.Windows.Forms.Splitter
    Private tChart1 As Steema.TeeChart.TChart
    Private bar1 As Steema.TeeChart.Styles.Bar
    Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
    Private WithEvents button1 As System.Windows.Forms.Button
    Private components As System.ComponentModel.IContainer = Nothing
    
    
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        
        bar1.Add(32, "John")
        bar1.Add(417, "Anne")
        bar1.Add(65, "Louise")
        bar1.Add(87, "Jeff")
        dataGrid1.DataBindings.Clear()
        
        Dim data As DataSet = bar1.DataSource 
        data.DataSetName = "MyDataSet"
        dataGrid1.SetDataBinding(data, "TeeDataTable")
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
        Me.dataGrid1 = New System.Windows.Forms.DataGrid
        Me.splitter1 = New System.Windows.Forms.Splitter
        Me.tChart1 = New Steema.TeeChart.TChart
        Me.bar1 = New Steema.TeeChart.Styles.Bar
        Me.checkBox1 = New System.Windows.Forms.CheckBox
        Me.button1 = New System.Windows.Forms.Button
        Me.panel1.SuspendLayout()
        Me.panel2.SuspendLayout()
        CType(Me.dataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Text = "Using a few lines of simple code, it is now possible to link a TeeChart Series to" + vbCr + vbLf + "a standard .NET DataGrid." + vbCr + vbLf + "Using the grid via the standard navigation keys on " + "your keyboard, " + vbCr + vbLf + "you can add, delete and modify point values and text."
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.button1)
        Me.panel1.Controls.Add(Me.checkBox1)
        Me.panel1.Name = "panel1"
        ' 
        ' panel2
        ' 
        Me.panel2.Controls.Add(Me.tChart1)
        Me.panel2.Controls.Add(Me.splitter1)
        Me.panel2.Controls.Add(Me.dataGrid1)
        Me.panel2.Name = "panel2"
        ' 
        ' dataGrid1
        ' 
        Me.dataGrid1.DataMember = ""
        Me.dataGrid1.Dock = System.Windows.Forms.DockStyle.Top
        Me.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dataGrid1.Location = New System.Drawing.Point(0, 0)
        Me.dataGrid1.Name = "dataGrid1"
        Me.dataGrid1.Size = New System.Drawing.Size(426, 120)
        Me.dataGrid1.TabIndex = 0
        ' 
        ' splitter1
        ' 
        Me.splitter1.Dock = System.Windows.Forms.DockStyle.Top
        Me.splitter1.Location = New System.Drawing.Point(0, 120)
        Me.splitter1.Name = "splitter1"
        Me.splitter1.Size = New System.Drawing.Size(426, 3)
        Me.splitter1.TabIndex = 1
        Me.splitter1.TabStop = False
        ' 
        ' tChart1
        ' 
        ' 
        ' tChart1.Aspect
        ' 
        Me.tChart1.Aspect.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality
        Me.tChart1.Aspect.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        Me.tChart1.Aspect.View3D = False
        Me.tChart1.Dock = System.Windows.Forms.DockStyle.Fill
        ' 
        ' tChart1.Header
        ' 
        Me.tChart1.Header.Lines = New String() {"TeeChart"}
        ' 
        ' tChart1.Legend
        ' 
        Me.tChart1.Legend.Visible = False
        Me.tChart1.Location = New System.Drawing.Point(0, 123)
        Me.tChart1.Name = "tChart1"
        Me.tChart1.Series.Add(Me.bar1)
        Me.tChart1.Size = New System.Drawing.Size(426, 31)
        Me.tChart1.TabIndex = 2
        ' 
        ' bar1
        ' 
        ' 
        ' bar1.Brush
        ' 
        Me.bar1.Brush.Color = System.Drawing.Color.Red
        Me.bar1.ColorEach = True
        ' 
        ' bar1.Marks
        ' 
        ' 
        ' bar1.Marks.Symbol
        ' 
        ' 
        ' bar1.Marks.Symbol.Shadow
        ' 
        Me.bar1.Marks.Symbol.Shadow.Height = 1
        Me.bar1.Marks.Symbol.Shadow.Visible = True
        Me.bar1.Marks.Symbol.Shadow.Width = 1
        Me.bar1.Title = "bar1"
        ' 
        ' bar1.XValues
        ' 
        Me.bar1.XValues.DataMember = "X"
        Me.bar1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' bar1.YValues
        ' 
        Me.bar1.YValues.DataMember = "Bar"
        ' 
        ' checkBox1
        ' 
        Me.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox1.Location = New System.Drawing.Point(24, 8)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.TabIndex = 0
        Me.checkBox1.Text = "Read Only"
        ' 
        ' button1
        ' 
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.Location = New System.Drawing.Point(139, 10)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(125, 23)
        Me.button1.TabIndex = 1
        Me.button1.Text = "Change second value"
        ' 
        ' ChartGrid
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(426, 258)
        Me.Name = "ChartGrid"
        Me.panel1.ResumeLayout(False)
        Me.panel2.ResumeLayout(False)
        CType(Me.dataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub 'InitializeComponent 
#End Region


    Private Sub dataGrid1_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dataGrid1.CurrentCellChanged
        Dim data As DataSet = dataGrid1.DataSource '
        bar1.DataSource = Nothing
        bar1.DataSource = data
    End Sub 'dataGrid1_CurrentCellChanged


    Private Sub checkBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox1.Click
        dataGrid1.ReadOnly = checkBox1.Checked
    End Sub 'checkBox1_Click


    Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
        bar1(1).Y = 50
        bar1(1).Label = "Christine"
        bar1.WriteToDataSource()
        dataGrid1.SetDataBinding(bar1.DataSource, "TeeDataTable")
    End Sub 'button1_Click
End Class 'ChartGrid
