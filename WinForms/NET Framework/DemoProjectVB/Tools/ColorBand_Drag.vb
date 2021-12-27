
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms


Public Class ColorBandDrag
    Inherits Steema.TeeChart.Samples.ColorBandClicked
    Private BPStart As Steema.TeeChart.ButtonPen
    Private BPEnd As Steema.TeeChart.ButtonPen
    Private components As System.ComponentModel.IContainer = Nothing
    
    Public Sub New() ' This call is required by the Windows Form Designer.
        InitializeComponent()

        BPStart.Pen = colorBand1.StartLinePen
        BPEnd.Pen = colorBand1.EndLinePen

        colorBand1.ResizeStart = True
        colorBand1.ResizeEnd = True

        tChart1.Aspect.View3D = False

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
        Me.BPStart = New Steema.TeeChart.ButtonPen
        Me.BPEnd = New Steema.TeeChart.ButtonPen
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Text = "The ColorBand tool allows dragging its start or end edges." + vbCr + vbLf + vbCr + vbLf + "colorBand1.ResizeSt" + "art = true " + vbCr + vbLf + "colorBand1.ResizeEnd = true " + vbCr + vbLf + vbCr + vbLf + "Drag the color band edges..." + vbCr + vbLf
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.BPEnd)
        Me.panel1.Controls.Add(Me.BPStart)
        Me.panel1.Name = "panel1"
        Me.panel1.Controls.SetChildIndex(Me.BPStart, 0)
        Me.panel1.Controls.SetChildIndex(Me.BPEnd, 0)
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
        ' 
        ' BPStart
        ' 
        Me.BPStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BPStart.Location = New System.Drawing.Point(224, 8)
        Me.BPStart.Name = "BPStart"
        Me.BPStart.TabIndex = 2
        Me.BPStart.Text = "&Start Pen..."
        ' 
        ' BPEnd
        ' 
        Me.BPEnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BPEnd.Location = New System.Drawing.Point(312, 8)
        Me.BPEnd.Name = "BPEnd"
        Me.BPEnd.TabIndex = 3
        Me.BPEnd.Text = "&End Pen..."
        ' 
        ' ColorBandDrag
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(440, 317)
        Me.Name = "ColorBandDrag"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub 'New 
#End Region
End Class 'ColorBandDrag