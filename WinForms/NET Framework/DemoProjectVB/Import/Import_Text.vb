
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms


Public Class Import_Text
    Inherits Steema.TeeChart.Samples.BaseNoChart
    Private tChart1 As Steema.TeeChart.TChart
    Private button1 As System.Windows.Forms.Button
    Private label1 As System.Windows.Forms.Label
    Private textBox2 As System.Windows.Forms.TextBox
    Private bar1 As Steema.TeeChart.Styles.Bar
    Private components As System.ComponentModel.IContainer = Nothing
    
    Public Sub New() ' This call is required by the Windows Form Designer.
        InitializeComponent()
        bar1.Clear()
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
        Me.tChart1 = New Steema.TeeChart.TChart
        Me.bar1 = New Steema.TeeChart.Styles.Bar
        Me.button1 = New System.Windows.Forms.Button
        Me.label1 = New System.Windows.Forms.Label
        Me.textBox2 = New System.Windows.Forms.TextBox
        Me.panel1.SuspendLayout()
        Me.panel2.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(473, 62)
        Me.textBox1.Text = "Series can be populated from virtually any text source. Text can be loaded from F" + "ile or Web URL address."
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.textBox2)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Controls.Add(Me.button1)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(473, 42)
        ' 
        ' panel2
        ' 
        Me.panel2.Controls.Add(Me.tChart1)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(473, 195)
        ' 
        ' tChart1
        ' 
        ' 
        ' tChart1.Aspect
        ' 
        Me.tChart1.Aspect.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality
        Me.tChart1.Aspect.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        Me.tChart1.Dock = System.Windows.Forms.DockStyle.Fill
        ' 
        ' tChart1.Header
        ' 
        Me.tChart1.Header.Lines = New String() {"TeeChart"}
        Me.tChart1.Location = New System.Drawing.Point(0, 0)
        Me.tChart1.Name = "tChart1"
        Me.tChart1.Series.Add(Me.bar1)
        Me.tChart1.Size = New System.Drawing.Size(473, 195)
        Me.tChart1.TabIndex = 0
        ' 
        ' tChart1.Walls
        ' 
        ' 
        ' tChart1.Walls.Back
        ' 
        ' 
        ' tChart1.Walls.Back.Brush
        ' 
        Me.tChart1.Walls.Back.Brush.Color = System.Drawing.Color.FromArgb(CType(127, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        ' 
        ' tChart1.Walls.Back.Gradient
        ' 
        Me.tChart1.Walls.Back.Brush.Gradient.Transparency = 50
        ' 
        ' tChart1.Walls.Back.Gradient
        ' 
        Me.tChart1.Walls.Back.Gradient.Transparency = 50
        Me.tChart1.Walls.Back.Transparent = False
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
        ' bar1
        ' 
        ' 
        ' bar1.Brush
        ' 
        Me.bar1.Brush.Color = System.Drawing.Color.Red
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
        ' button1
        ' 
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.Location = New System.Drawing.Point(24, 10)
        Me.button1.Name = "button1"
        Me.button1.TabIndex = 0
        Me.button1.Text = "&Fill series"
        AddHandler Me.button1.Click, AddressOf Me.button1_Click
        ' 
        ' label1
        ' 
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(120, 13)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(43, 16)
        Me.label1.TabIndex = 1
        Me.label1.Text = "&Source:"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        ' 
        ' textBox2
        ' 
        Me.textBox2.Location = New System.Drawing.Point(172, 11)
        Me.textBox2.Name = "textBox2"
        Me.textBox2.Size = New System.Drawing.Size(180, 20)
        Me.textBox2.TabIndex = 2
        Me.textBox2.Text = "http://www.steema.com/demo.txt"
        ' 
        ' Import_Text
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(473, 299)
        Me.Name = "Import_Text"
        Me.panel1.ResumeLayout(False)
        Me.panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub 'New 
#End Region


    Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim ts As New TeeChart.Data.TextSource(textBox2.Text)
        Try
            Cursor = Cursors.WaitCursor
            If ts.IsURL() Then
                ts.HeaderLines = 2
                ts.Separator = ","c
                ts.Fields.Add(0, "X")
                ts.Fields.Add(1, "Bar")
                ts.Fields.Add(2, "Text")
                bar1.DataSource = ts
            End If
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub 'button1_Click
End Class 'Import_Text