
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms


Public Class Canvas_AntiAlias
    Inherits Steema.TeeChart.Samples.BaseForm
    Private pie1 As Steema.TeeChart.Styles.Pie
    Private checkBox1 As System.Windows.Forms.CheckBox
    Private components As System.ComponentModel.IContainer = Nothing
    
    Public Sub New() ' This call is required by the Windows Form Designer.
        InitializeComponent()
        pie1.FillSampleValues(8)
			
        Dim b As Bitmap = tChart1.Bitmap
    End Sub


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
        Me.pie1 = New Steema.TeeChart.Styles.Pie
        Me.checkBox1 = New System.Windows.Forms.CheckBox
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Text = "Global method to smooth curve and diagonal lines (Anti-Alias), and new Canvas pro" + "perty to zoom fonts (as percentage)."
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.checkBox1)
        Me.panel1.Name = "panel1"
        ' 
        ' tChart1
        ' 
        ' 
        ' tChart1.Aspect
        ' 
        Me.tChart1.Aspect.Elevation = 315
        Me.tChart1.Aspect.Orthogonal = False
        Me.tChart1.Aspect.Perspective = 0
        Me.tChart1.Aspect.Rotation = 360
        Me.tChart1.Aspect.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
        Me.tChart1.Aspect.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias
        ' 
        ' tChart1.Header
        ' 
        Me.tChart1.Header.Lines = New String() {"Anti-Aliased Pie"}
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Brush
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.tChart1.Series.Add(Me.pie1)
        AddHandler Me.tChart1.AfterDraw, AddressOf Me.tChart1_AfterDraw
        ' 
        ' pie1
        ' 
        ' 
        ' pie1.Brush
        ' 
        Me.pie1.Brush.Color = System.Drawing.Color.Red
        Me.pie1.LabelMember = "Labels"
        ' 
        ' pie1.Marks
        ' 
        ' 
        ' pie1.Marks.Symbol
        ' 
        ' 
        ' pie1.Marks.Symbol.Shadow
        ' 
        Me.pie1.Marks.Symbol.Shadow.Height = 1
        Me.pie1.Marks.Symbol.Shadow.Visible = True
        Me.pie1.Marks.Symbol.Shadow.Width = 1
        ' 
        ' pie1.Shadow
        ' 
        Me.pie1.Shadow.Height = 20
        Me.pie1.Shadow.Width = 20
        Me.pie1.Title = "pie1"
        ' 
        ' pie1.XValues
        ' 
        Me.pie1.XValues.DataMember = "Angle"
        Me.pie1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' pie1.YValues
        ' 
        Me.pie1.YValues.DataMember = "Pie"
        ' 
        ' checkBox1
        ' 
        Me.checkBox1.Location = New System.Drawing.Point(16, 8)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.TabIndex = 0
        Me.checkBox1.Text = "Anti-Alias"
        AddHandler Me.checkBox1.Click, AddressOf Me.checkBox1_Click
        AddHandler Me.checkBox1.CheckedChanged, AddressOf Me.checkBox1_CheckedChanged
        ' 
        ' Canvas_AntiAlias
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(440, 317)
        Me.Name = "Canvas_AntiAlias"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub 'New 
#End Region


    Private Sub checkBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs)
    End Sub 'checkBox1_Click


    Private Sub tChart1_AfterDraw(ByVal sender As Object, ByVal g As Steema.TeeChart.Drawing.Graphics3D) Handles tChart1.AfterDraw
        If g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.Default Then
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
        Else
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.Default
        End If
    End Sub 'tChart1_AfterDraw


    Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        tChart1.Invalidate()
    End Sub 'checkBox1_CheckedChanged


    Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim ts As Steema.TeeChart.Drawing.TextShape
        ts = pie1.Marks
        ts.Font.Size = 20
    End Sub 'button1_Click
End Class 'Canvas_AntiAlias 