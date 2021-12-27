
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms


Public Class ColorBandClicked
    Inherits Steema.TeeChart.Samples.BaseForm
    Protected colorBand1 As Steema.TeeChart.Tools.ColorBand
    Private label1 As System.Windows.Forms.Label
    Private label2 As System.Windows.Forms.Label
    Private components As System.ComponentModel.IContainer = Nothing
    
    Public Sub New() ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' TODO: Add any initialization after the InitializeComponent call
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
        Me.colorBand1 = New Steema.TeeChart.Tools.ColorBand
        Me.label1 = New System.Windows.Forms.Label
        Me.label2 = New System.Windows.Forms.Label
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Text = "The ColorBand tool provides a Click event and a Clicked function" + vbCr + vbLf + "that is trigger" + "ed when clicking it." + vbCr + vbLf + vbCr + vbLf + "Click the white color band..."
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.label2)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Name = "panel1"
        ' 
        ' tChart1
        ' 
        ' 
        ' tChart1.Aspect
        ' 
        Me.tChart1.Aspect.Chart3DPercent = 40
        Me.tChart1.Aspect.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality
        Me.tChart1.Aspect.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        ' 
        ' tChart1.Axes
        ' 
        ' 
        ' tChart1.Axes.Left
        ' 
        Me.tChart1.Axes.Left.Automatic = False
        Me.tChart1.Axes.Left.AutomaticMaximum = False
        Me.tChart1.Axes.Left.AutomaticMinimum = False
        Me.tChart1.Axes.Left.Maximum = 1000
        Me.tChart1.Axes.Left.Minimum = 0
        Me.tChart1.Cursor = System.Windows.Forms.Cursors.Default
        ' 
        ' tChart1.Header
        ' 
        Me.tChart1.Header.Lines = New String() {"TeeChart"}
        Me.tChart1.Header.Visible = False
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Brush
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.tChart1.Tools.Add(Me.colorBand1)
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
        Me.tChart1.Walls.Bottom.Size = 3
        ' 
        ' tChart1.Walls.Left
        ' 
        ' 
        ' tChart1.Walls.Left.Pen
        ' 
        Me.tChart1.Walls.Left.Pen.Visible = False
        Me.tChart1.Walls.Left.Size = 3
        AddHandler Me.tChart1.MouseMove, AddressOf Me.tChart1_MouseMove
        ' 
        ' colorBand1
        ' 
        Me.colorBand1.Axis = Me.tChart1.Axes.Left
        Me.colorBand1.End = 800
        Me.colorBand1.ResizeEnd = False
        Me.colorBand1.ResizeStart = False
        Me.colorBand1.Start = 400
        AddHandler Me.colorBand1.Click, AddressOf Me.colorBand1_Click
        ' 
        ' label1
        ' 
        Me.label1.Location = New System.Drawing.Point(16, 8)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(48, 23)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Clicked:"
        ' 
        ' label2
        ' 
        Me.label2.Location = New System.Drawing.Point(72, 8)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(168, 32)
        Me.label2.TabIndex = 1
        ' 
        ' ColorBandClicked
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(440, 317)
        Me.Name = "ColorBandClicked"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub 'New 
#End Region


    Private Sub colorBand1_Click(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Dim rnd As New Random
        label2.Text = "Clicked at X:" + e.X.ToString() + " Y:" + e.Y.ToString()

        colorBand1.Color = Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255))
    End Sub 'colorBand1_Click


    Private Sub tChart1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If colorBand1.Clicked(e.X, e.Y) Then
            tChart1.Cursor = Cursors.Hand
        Else
            tChart1.Cursor = Cursors.Default
        End If
    End Sub 'tChart1_MouseMove
End Class 'ColorBandClicked