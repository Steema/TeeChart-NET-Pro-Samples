
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms


'/ <summary>
'/ Summary description for Template.
'/ </summary>

Public Class Template_Chart
    Inherits System.Windows.Forms.Form
    Friend Protected textBox1 As System.Windows.Forms.TextBox
    Protected panel1 As System.Windows.Forms.Panel
    Private panel2 As System.Windows.Forms.Panel
    Private tChart1 As Steema.TeeChart.TChart
    Private tChart2 As Steema.TeeChart.TChart
    Private splitter1 As System.Windows.Forms.Splitter
    Private WithEvents button1 As System.Windows.Forms.Button
    Private WithEvents button2 As System.Windows.Forms.Button
    Private pointSeries1 As Steema.TeeChart.Styles.Points
    '/ <summary>
    '/ Required designer variable.
    '/ </summary>
    Private components As System.ComponentModel.Container = Nothing
    
    
    Public Sub New()
        '
        ' Required for Windows Form Designer support
        '
        InitializeComponent()
        

        For Each s As Steema.TeeChart.Styles.Series In tChart1.Series
            s.FillSampleValues(10)
        Next s
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

#Region "Windows Form Designer generated code"

    '/ <summary>
    '/ Required method for Designer support - do not modify
    '/ the contents of this method with the code editor.
    '/ </summary>
    Private Sub InitializeComponent()
        Me.textBox1 = New System.Windows.Forms.TextBox
        Me.panel1 = New System.Windows.Forms.Panel
        Me.button2 = New System.Windows.Forms.Button
        Me.button1 = New System.Windows.Forms.Button
        Me.panel2 = New System.Windows.Forms.Panel
        Me.splitter1 = New System.Windows.Forms.Splitter
        Me.tChart2 = New Steema.TeeChart.TChart
        Me.tChart1 = New Steema.TeeChart.TChart
        Me.pointSeries1 = New Steema.TeeChart.Styles.Points
        Me.panel1.SuspendLayout()
        Me.panel2.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.BackColor = System.Drawing.Color.FromArgb(CType(255, System.Byte), CType(255, System.Byte), CType(192, System.Byte))
        Me.textBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.textBox1.Location = New System.Drawing.Point(0, 0)
        Me.textBox1.Multiline = True
        Me.textBox1.Name = "textBox1"
        Me.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.textBox1.Size = New System.Drawing.Size(439, 62)
        Me.textBox1.TabIndex = 2
        Me.textBox1.Text = "Native Charts (*.ten files), can be exported without data to create templates. They can be saved to streams and files and can be used for example in dynamic charts, where new Series are added to the Chart with formatting settings from other pre-created charts."
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.button2)
        Me.panel1.Controls.Add(Me.button1)
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel1.Location = New System.Drawing.Point(0, 62)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(439, 42)
        Me.panel1.TabIndex = 3
        ' 
        ' button2
        ' 
        Me.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button2.Location = New System.Drawing.Point(153, 7)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(143, 23)
        Me.button2.TabIndex = 1
        Me.button2.Text = "&Run Example"
        ' 
        ' button1
        ' 
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.Location = New System.Drawing.Point(16, 7)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(100, 23)
        Me.button1.TabIndex = 0
        Me.button1.Text = "&Edit Template..."
        ' 
        ' panel2
        ' 
        Me.panel2.Controls.Add(Me.splitter1)
        Me.panel2.Controls.Add(Me.tChart2)
        Me.panel2.Controls.Add(Me.tChart1)
        Me.panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel2.Location = New System.Drawing.Point(0, 104)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(439, 168)
        Me.panel2.TabIndex = 4
        ' 
        ' splitter1
        ' 
        Me.splitter1.Location = New System.Drawing.Point(142, 0)
        Me.splitter1.Name = "splitter1"
        Me.splitter1.Size = New System.Drawing.Size(5, 168)
        Me.splitter1.TabIndex = 2
        Me.splitter1.TabStop = False
        ' 
        ' tChart2
        ' 
        ' 
        ' tChart2.Aspect
        ' 
        Me.tChart2.Aspect.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality
        Me.tChart2.Aspect.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        Me.tChart2.Dock = System.Windows.Forms.DockStyle.Fill
        ' 
        ' tChart2.Header
        ' 
        Me.tChart2.Header.Lines = New String() {"tChart2"}
        Me.tChart2.Location = New System.Drawing.Point(142, 0)
        Me.tChart2.Name = "tChart2"
        Me.tChart2.Size = New System.Drawing.Size(297, 168)
        Me.tChart2.TabIndex = 1
        ' 
        ' tChart2.Walls
        ' 
        ' 
        ' tChart2.Walls.Bottom
        ' 
        ' 
        ' tChart2.Walls.Bottom.Pen
        ' 
        Me.tChart2.Walls.Bottom.Pen.Visible = False
        Me.tChart2.Walls.Bottom.Size = 5
        ' 
        ' tChart2.Walls.Left
        ' 
        ' 
        ' tChart2.Walls.Left.Pen
        ' 
        Me.tChart2.Walls.Left.Pen.Visible = False
        Me.tChart2.Walls.Left.Size = 5
        ' 
        ' tChart1
        ' 
        ' 
        ' tChart1.Aspect
        ' 
        Me.tChart1.Aspect.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality
        Me.tChart1.Aspect.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        Me.tChart1.Dock = System.Windows.Forms.DockStyle.Left
        ' 
        ' tChart1.Header
        ' 
        Me.tChart1.Header.Lines = New String() {"tChart1"}
        ' 
        ' tChart1.Legend
        ' 
        Me.tChart1.Legend.Visible = False
        Me.tChart1.Location = New System.Drawing.Point(0, 0)
        Me.tChart1.Name = "tChart1"
        Me.tChart1.Series.Add(Me.pointSeries1)
        Me.tChart1.Size = New System.Drawing.Size(142, 168)
        Me.tChart1.TabIndex = 0
        ' 
        ' tChart1.Walls
        ' 
        ' 
        ' tChart1.Walls.Bottom
        ' 
        ' 
        ' tChart1.Walls.Bottom.Pen
        ' 
        Me.tChart1.Walls.Bottom.Pen.Visible = False
        Me.tChart1.Walls.Bottom.Size = 5
        ' 
        ' tChart1.Walls.Left
        ' 
        ' 
        ' tChart1.Walls.Left.Pen
        ' 
        Me.tChart1.Walls.Left.Pen.Visible = False
        Me.tChart1.Walls.Left.Size = 5
        ' 
        ' pointSeries1
        ' 
        ' 
        ' pointSeries1.Marks
        ' 
        ' 
        ' pointSeries1.Marks.Symbol
        ' 
        ' 
        ' pointSeries1.Marks.Symbol.Shadow
        ' 
        Me.pointSeries1.Marks.Symbol.Shadow.Height = 1
        Me.pointSeries1.Marks.Symbol.Shadow.Visible = True
        Me.pointSeries1.Marks.Symbol.Shadow.Width = 1
        ' 
        ' pointSeries1.Pointer
        ' 
        ' 
        ' pointSeries1.Pointer.Brush
        ' 
        Me.pointSeries1.Pointer.Brush.Color = System.Drawing.Color.Red
        Me.pointSeries1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.pointSeries1.Title = "pointSeries1"
        ' 
        ' pointSeries1.XValues
        ' 
        Me.pointSeries1.XValues.DataMember = "X"
        Me.pointSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' pointSeries1.YValues
        ' 
        Me.pointSeries1.YValues.DataMember = "Y"
        ' 
        ' Export_Template
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(439, 272)
        Me.Controls.Add(panel2)
        Me.Controls.Add(panel1)
        Me.Controls.Add(textBox1)
        Me.Name = "Export_Template"
        Me.Text = "Template"
        Me.panel1.ResumeLayout(False)
        Me.panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub 'InitializeComponent 
#End Region


    Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
        tChart1.ShowEditor()
    End Sub 'button1_Click


    Private Sub button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button2.Click
        '  1) Save the template into a Stream...
        Dim stream As New System.IO.MemoryStream
        Try
            ' save only Chart and Series formatting, NOT including data
            tChart1.Export.Template.Save(stream)
            ' 2) Load the template into other Chart...
            stream.Position = 0
            tChart2.Import.Template.Load(stream)
            ' restore the chart alignment (in this example)
            Me.tChart2.Dock = DockStyle.Fill
            ' repaint the Chart
            Me.tChart2.Refresh()
        Finally
            ' remove the stream, it's no longer necessary...
            stream.Close()
        End Try
    End Sub 'button2_Click
End Class 'Template_Chart