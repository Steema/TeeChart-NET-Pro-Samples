
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms


'/ <summary>
'/ Summary description for Basic_Features.
'/ </summary>

Public Class Basic_Features
    Inherits System.Windows.Forms.Form
    Private textBox1 As System.Windows.Forms.TextBox
    Private panel1 As System.Windows.Forms.Panel
    Private WithEvents button1 As System.Windows.Forms.Button
    Private WithEvents button2 As System.Windows.Forms.Button
    Private textBox2 As System.Windows.Forms.TextBox
    Private tChart1 As Steema.TeeChart.TChart
    Private splitter1 As System.Windows.Forms.Splitter
    '/ <summary>
    '/ Required designer variable.
    '/ </summary>
    Private components As System.ComponentModel.Container = Nothing
    
    
    Public Sub New()
        '
        ' Required for Windows Form Designer support
        InitializeComponent()
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
        Me.textBox2 = New System.Windows.Forms.TextBox
        Me.tChart1 = New Steema.TeeChart.TChart
        Me.splitter1 = New System.Windows.Forms.Splitter
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.BackColor = System.Drawing.Color.FromArgb(CType(255, System.Byte), CType(255, System.Byte), CType(192, System.Byte))
        Me.textBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.textBox1.Location = New System.Drawing.Point(0, 0)
        Me.textBox1.Multiline = True
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(496, 76)
        Me.textBox1.TabIndex = 0
        Me.textBox1.Text = "Creating charts is really easy to do. Just drop a Chart component on your form and double-click it to show the editor dialog. First steps with the editor dialog are clicking the Add button to choose a chart style (series) from the Gallery." + vbCr + vbLf + "Adding points to a series can be done by code or at design-time, linking the series to a database or function."
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.button2)
        Me.panel1.Controls.Add(Me.button1)
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel1.Location = New System.Drawing.Point(0, 76)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(496, 36)
        Me.panel1.TabIndex = 1
        ' 
        ' button2
        ' 
        Me.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button2.Location = New System.Drawing.Point(247, 7)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(113, 23)
        Me.button2.TabIndex = 1
        Me.button2.Text = "&Show Chart Editor"
        ' 
        ' button1
        ' 
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.Location = New System.Drawing.Point(13, 7)
        Me.button1.Name = "button1"
        Me.button1.TabIndex = 0
        Me.button1.Text = "&Run code"
        ' 
        ' textBox2
        ' 
        Me.textBox2.Dock = System.Windows.Forms.DockStyle.Left
        Me.textBox2.Location = New System.Drawing.Point(0, 112)
        Me.textBox2.Multiline = True
        Me.textBox2.Name = "textBox2"
        Me.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.textBox2.Size = New System.Drawing.Size(296, 277)
        Me.textBox2.TabIndex = 2
        Me.textBox2.Text = "Run-time code to create charts:" + vbCr + vbLf + vbCr + vbLf + "tChart1.Series.Clear() " + vbCr + vbLf + vbCr + vbLf + "tChart1.Series.Add(new Steema.TeeChart.Styles.Bar()) " + vbCr + vbLf + "tChart1.Series[0].Clear() " + vbCr + vbLf + "tChart1.Series[0].Add(123, ""ABC"", Color.Red) " + vbCr + vbLf + "tChart1.Series[0].Add(  456, ""DEF"", Color.Blue ) " + vbCr + vbLf + "tChart1.Series[0].Add(  321, ""GHI"", Color.Green ) " + vbCr + vbLf + vbCr + vbLf + "Change the bar Marks :" + vbCr + vbLf + vbCr + vbLf + "tChart1.Series[0].Marks.Style = smsValue  " + vbCr + vbLf + vbCr + vbLf + "To show the editor dialog, use the following code:" + vbCr + vbLf + vbCr + vbLf + "tChart1.ShowEditor() "
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
        Me.tChart1.Header.Lines = New String() {"Chart Example"}
        ' 
        ' tChart1.Legend
        ' 
        Me.tChart1.Legend.Alignment = Steema.TeeChart.LegendAlignments.Bottom
        Me.tChart1.Location = New System.Drawing.Point(296, 112)
        Me.tChart1.Name = "tChart1"
        Me.tChart1.Size = New System.Drawing.Size(200, 277)
        Me.tChart1.TabIndex = 3
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
        ' splitter1
        ' 
        Me.splitter1.Location = New System.Drawing.Point(296, 112)
        Me.splitter1.Name = "splitter1"
        Me.splitter1.Size = New System.Drawing.Size(3, 277)
        Me.splitter1.TabIndex = 4
        Me.splitter1.TabStop = False
        ' 
        ' Basic_Features
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(496, 389)
        Me.Controls.Add(splitter1)
        Me.Controls.Add(tChart1)
        Me.Controls.Add(textBox2)
        Me.Controls.Add(panel1)
        Me.Controls.Add(textBox1)
        Me.Name = "Basic_Features"
        Me.Text = "Basic_Features"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub 'InitializeComponent 
#End Region


    Private Sub button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button2.Click
        tChart1.ShowEditor()
    End Sub 'button2_Click


    Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
        tChart1.Series.Clear()
        tChart1.Series.Add(New Steema.TeeChart.Styles.Bar)
        tChart1.Series(0).Clear()
        tChart1.Series(0).Add(123, "ABC", Color.Red)
        tChart1.Series(0).Add(456, "DEF", Color.Blue)
        tChart1.Series(0).Add(321, "GHI", Color.Green)

        tChart1.Series(0).Marks.Style = Steema.TeeChart.Styles.MarksStyles.Value

        ' Set Axis titles:
        tChart1.Axes.Bottom.Title.Text = "Series"
        tChart1.Axes.Left.Title.Text = "Values"
    End Sub 'button1_Click
End Class 'Basic_Features