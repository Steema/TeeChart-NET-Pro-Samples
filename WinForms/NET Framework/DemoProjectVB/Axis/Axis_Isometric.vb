
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports Steema.TeeChart
Imports System.Runtime.InteropServices


Public Class Axis_Isometric
    Inherits Steema.TeeChart.Samples.BaseForm
    Private button1 As System.Windows.Forms.Button
    Private line1 As Steema.TeeChart.Styles.Line
    Private components As System.ComponentModel.IContainer = Nothing
    
    Private Sub MakeIsometric(ByVal vertical As Axis, ByVal horizontal As Axis)
        If vertical.Chart.Width > 0 AndAlso vertical.Chart.Height > 0 Then ' setup values
            Dim xrange As Double = horizontal.Maximum - horizontal.Minimum
            Dim yrange As Double = vertical.Maximum - vertical.Minimum
            Dim tmpx As Double = xrange / System.Convert.ToDouble(vertical.Chart.Width)
            Dim tmpy As Double = yrange / System.Convert.ToDouble(vertical.Chart.Height)

      Dim screen As Screen = System.Windows.Forms.Screen.FromControl(Me)
      Dim g As Graphics = Graphics.FromHwnd(Me.Handle)
            Dim hptr As IntPtr = g.GetHdc()
            Dim xyscreen As Double = GetDeviceCaps(hptr, HORZSIZE) * screen.Bounds.Height
            xyscreen /= System.Convert.ToDouble(GetDeviceCaps(hptr, VERTSIZE)) * screen.Bounds.Width
            g.ReleaseHdc(hptr)
            g.Dispose()

            tmpy *= xyscreen
            Dim offset As Double = 0.0
            If tmpx > tmpy Then '
                If tmpy <> 0.0 Then
                    offset = 0.5 * (yrange * tmpx / tmpy - yrange)
                    vertical.SetMinMax(vertical.Minimum - offset, vertical.Maximum + offset)
                End If
            ElseIf tmpx < tmpy Then
                If tmpx <> 0.0 Then
                    offset = 0.5 * (xrange * tmpy / tmpx - xrange)
                    horizontal.SetMinMax(horizontal.Minimum - offset, horizontal.Maximum + offset)
                End If
            End If
        End If
    End Sub 'MakeIsometric

    Private Sub MakeIsometric(ByVal series As Styles.Series)
        MakeIsometric(series.GetVertAxis, series.GetHorizAxis)
    End Sub

    Public Sub New() ' Axis_Isometric()

        InitializeComponent()
        tChart1.Axes.Left.Grid.Style = System.Drawing.Drawing2D.DashStyle.Solid
        tChart1.Axes.Left.Grid.Color = Color.Black
        tChart1.Axes.Left.Increment = 50.0
        tChart1.Axes.Left.Labels.Separation = 0

        tChart1.Axes.Bottom.Grid.Style = System.Drawing.Drawing2D.DashStyle.Solid
        tChart1.Axes.Bottom.Grid.Color = Color.Black
        tChart1.Axes.Bottom.Increment = 50.0
        tChart1.Axes.Bottom.Labels.Separation = 0

        Dim r As Random = New Random
        Dim i As Integer = 1
        Do While (i <= 100)
            line1.Add(i, r.Next(1, 100))
            i = (i + 1)
        Loop
    End Sub

    Private Shared HORZSIZE As Short = 4   ' Horizontal size in millimeters 
    Private Shared VERTSIZE As Short = 6   ' Vertical size in millimeters
    Private Declare Function GetDeviceCaps Lib "gdi32.dll" (ByVal hdc As IntPtr, ByVal capindex As Int32) As Int32

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
        Me.button1 = New System.Windows.Forms.Button
        Me.line1 = New Steema.TeeChart.Styles.Line
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.BackColor = System.Drawing.Color.AliceBlue
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Text = "A small function lets you make two axis """"isometric"""". That is, for same number of pixels, same scale" & _
        "s according to your screen size, so grid lines form perfect """"squares"""" instead of rectangle. MakeI" & _
        "soAxis(line1)Note: Must be called after axes have recalculated min and max values. See code."
        ' 
        ' panel1
        ' 
        Me.panel1.BackColor = System.Drawing.SystemColors.Control
        Me.panel1.Controls.Add(Me.button1)
        Me.panel1.Name = "panel1"
        ' 
        ' tChart1
        ' 
        ' 
        ' tChart1.Aspect
        ' 
        Me.tChart1.Aspect.View3D = False
        ' 
        ' tChart1.Axes
        ' 
        ' 
        ' tChart1.Axes.Bottom
        ' 
        ' 
        ' tChart1.Axes.Bottom.AxisPen
        ' 
        Me.tChart1.Axes.Bottom.AxisPen.Visible = False
        ' 
        ' tChart1.Axes.Left
        ' 
        ' 
        ' tChart1.Axes.Left.AxisPen
        ' 
        Me.tChart1.Axes.Left.AxisPen.Visible = False
        ' 
        ' tChart1.Axes.Top
        ' 
        ' 
        ' tChart1.Axes.Top.AxisPen
        ' 
        Me.tChart1.Axes.Top.AxisPen.Visible = False
        Me.tChart1.Axes.Top.Visible = False
        Me.tChart1.BackColor = System.Drawing.Color.White
        ' 
        ' tChart1.Header
        ' 
        ' 
        ' tChart1.Header.Font
        ' 
        ' 
        ' tChart1.Header.Font.Brush
        ' 
        Me.tChart1.Header.Font.Brush.Color = System.Drawing.Color.FromArgb(CType(254, Byte), CType(0, Byte), CType(0, Byte), CType(128, Byte))
        Me.tChart1.Header.Font.Name = "Verdana"
        ' 
        ' tChart1.Header.Font.Shadow
        ' 
        ' 
        ' tChart1.Header.Font.Shadow.Brush
        ' 
        Me.tChart1.Header.Font.Shadow.Brush.Color = System.Drawing.Color.FromArgb(CType(254, Byte), CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.tChart1.Header.Font.Shadow.Visible = True
        Me.tChart1.Header.Lines = New String() {"Isometric Axis"}
        ' 
        ' tChart1.Legend
        ' 
        Me.tChart1.Legend.Visible = False
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Brush
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.White
        ' 
        ' tChart1.Panel.Gradient
        ' 
        Me.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(254, Byte), CType(192, Byte), CType(192, Byte), CType(255, Byte))
        Me.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(254, Byte), CType(192, Byte), CType(192, Byte), CType(255, Byte))
        Me.tChart1.Panel.Brush.Gradient.UseMiddle = True
        Me.tChart1.Panel.Brush.Gradient.Visible = True
        ' 
        ' tChart1.Panel.Gradient
        ' 
        Me.tChart1.Panel.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(254, Byte), CType(192, Byte), CType(192, Byte), CType(255, Byte))
        Me.tChart1.Panel.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(254, Byte), CType(192, Byte), CType(192, Byte), CType(255, Byte))
        Me.tChart1.Panel.Gradient.UseMiddle = True
        Me.tChart1.Panel.Gradient.Visible = True
        Me.tChart1.Series.Add(Me.line1)
        AddHandler tChart1.Zoomed, AddressOf Me.tChart1_Zoomed
        AddHandler tChart1.UndoneZoom, AddressOf Me.tChart1_UndoneZoom
        ' 
        ' button1
        ' 
        Me.button1.Location = New System.Drawing.Point(8, 8)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(96, 23)
        Me.button1.TabIndex = 0
        Me.button1.Text = "Make isometric"
        AddHandler button1.Click, AddressOf Me.button1_Click
        ' 
        ' line1
        ' 
        ' 
        ' line1.Brush
        ' 
        Me.line1.Brush.Color = System.Drawing.Color.FromArgb(CType(102, Byte), CType(153, Byte), CType(255, Byte))
        ' 
        ' line1.LinePen
        ' 
        Me.line1.LinePen.Color = System.Drawing.Color.FromArgb(CType(61, Byte), CType(92, Byte), CType(153, Byte))
        ' 
        ' line1.Pointer
        ' 
        ' 
        ' 
        ' line1.Pointer.Pen
        ' 
        Me.line1.Pointer.Pen.Visible = False
        Me.line1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.line1.Pointer.Visible = True
        Me.line1.Title = "line1"
        ' 
        ' line1.XValues
        ' 
        Me.line1.XValues.DataMember = "X"
        Me.line1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' line1.YValues
        ' 
        Me.line1.YValues.DataMember = "Y"
        ' 
        ' Axis_Isometric
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(440, 317)
        Me.Name = "Axis_Isometric"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub 'New 
#End Region


    Private Sub tChart1_Zoomed(ByVal sender As Object, ByVal e As System.EventArgs) Handles tChart1.Zoomed
        MakeIsometric(line1)
    End Sub 'tChart1_Zoomed


    Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        MakeIsometric(line1)
    End Sub 'button1_Click


    Private Sub tChart1_UndoneZoom(ByVal sender As Object, ByVal e As System.EventArgs) Handles tChart1.UndoneZoom
        MakeIsometric(line1)
    End Sub 'tChart1_UndoneZoom
End Class 'Axis_Isometric