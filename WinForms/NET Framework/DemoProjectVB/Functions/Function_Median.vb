
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms


Public Class Function_Median
    Inherits Steema.TeeChart.Samples.BaseForm
    Private fastLine1 As Steema.TeeChart.Styles.FastLine
    Private line1 As Steema.TeeChart.Styles.Line
    Private medianFunction1 As Steema.TeeChart.Functions.MedianFunction
    Private components As System.ComponentModel.IContainer = Nothing
    
    Public Sub New() ' This call is required by the Windows Form Designer.
        InitializeComponent()

        fastLine1.FillSampleValues()
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
        Me.fastLine1 = New Steema.TeeChart.Styles.FastLine
        Me.line1 = New Steema.TeeChart.Styles.Line
        Me.medianFunction1 = New Steema.TeeChart.Functions.MedianFunction
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Text = "The Median function calculates the value that is in the middle if the" + vbCr + vbLf + "source val" + "ues were sorted." + vbCr + vbLf + "If two values are in the middle, the function does a simple av" + "erage on them." + vbCr + vbLf + vbCr + vbLf + "Null source values can be included or not in the calculation."
        ' 
        ' panel1
        ' 
        Me.panel1.Name = "panel1"
        ' 
        ' tChart1
        ' 
        ' 
        ' tChart1.Aspect
        ' 
        Me.tChart1.Aspect.ColorPaletteIndex = -1
        Me.tChart1.Aspect.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality
        Me.tChart1.Aspect.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        Me.tChart1.Aspect.ThemeIndex = 3
        Me.tChart1.Aspect.View3D = False
        ' 
        ' tChart1.Axes
        ' 
        ' 
        ' tChart1.Axes.Bottom
        ' 
        ' 
        ' tChart1.Axes.Bottom.Grid
        ' 
        Me.tChart1.Axes.Bottom.Grid.Color = System.Drawing.Color.Gray
        ' 
        ' tChart1.Axes.Bottom.Ticks
        ' 
        Me.tChart1.Axes.Bottom.Ticks.Length = 2
        ' 
        ' tChart1.Axes.Depth
        ' 
        ' 
        ' tChart1.Axes.Depth.Grid
        ' 
        Me.tChart1.Axes.Depth.Grid.Color = System.Drawing.Color.Gray
        ' 
        ' tChart1.Axes.Depth.Ticks
        ' 
        Me.tChart1.Axes.Depth.Ticks.Length = 2
        ' 
        ' tChart1.Axes.Left
        ' 
        ' 
        ' tChart1.Axes.Left.Grid
        ' 
        Me.tChart1.Axes.Left.Grid.Color = System.Drawing.Color.Gray
        ' 
        ' tChart1.Axes.Left.Ticks
        ' 
        Me.tChart1.Axes.Left.Ticks.Length = 2
        ' 
        ' tChart1.Axes.Right
        ' 
        ' 
        ' tChart1.Axes.Right.Grid
        ' 
        Me.tChart1.Axes.Right.Grid.Color = System.Drawing.Color.Gray
        ' 
        ' tChart1.Axes.Right.Ticks
        ' 
        Me.tChart1.Axes.Right.Ticks.Length = 2
        ' 
        ' tChart1.Axes.Top
        ' 
        ' 
        ' tChart1.Axes.Top.Grid
        ' 
        Me.tChart1.Axes.Top.Grid.Color = System.Drawing.Color.Gray
        ' 
        ' tChart1.Axes.Top.Ticks
        ' 
        Me.tChart1.Axes.Top.Ticks.Length = 2
        ' 
        ' tChart1.Header
        ' 
        Me.tChart1.Header.Lines = New String() {"TeeChart"}
        ' 
        ' tChart1.Legend
        ' 
        ' 
        ' tChart1.Legend.Brush
        ' 
        ' 
        ' tChart1.Legend.Gradient
        ' 
        Me.tChart1.Legend.Brush.Gradient.EndColor = System.Drawing.Color.Yellow
        Me.tChart1.Legend.Brush.Gradient.MiddleColor = System.Drawing.Color.Empty
        Me.tChart1.Legend.Brush.Gradient.StartColor = System.Drawing.Color.White
        Me.tChart1.Legend.Brush.Gradient.Visible = True
        ' 
        ' tChart1.Legend.Gradient
        ' 
        Me.tChart1.Legend.Gradient.EndColor = System.Drawing.Color.Yellow
        Me.tChart1.Legend.Gradient.MiddleColor = System.Drawing.Color.Empty
        Me.tChart1.Legend.Gradient.StartColor = System.Drawing.Color.White
        Me.tChart1.Legend.Gradient.Visible = True
        ' 
        ' tChart1.Legend.Shadow
        ' 
        ' 
        ' tChart1.Legend.Shadow.Brush
        ' 
        Me.tChart1.Legend.Shadow.Brush.Color = System.Drawing.Color.FromArgb(CType(127, System.Byte), CType(0, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Bevel
        ' 
        Me.tChart1.Panel.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None
        ' 
        ' tChart1.Panel.Brush
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.White
        ' 
        ' tChart1.Panel.Gradient
        ' 
        Me.tChart1.Panel.Brush.Gradient.Direction = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(177, System.Byte), CType(177, System.Byte), CType(177, System.Byte))
        Me.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.Empty
        Me.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.White
        Me.tChart1.Panel.Brush.Gradient.Visible = True
        ' 
        ' tChart1.Panel.Gradient
        ' 
        Me.tChart1.Panel.Gradient.Direction = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.tChart1.Panel.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(177, System.Byte), CType(177, System.Byte), CType(177, System.Byte))
        Me.tChart1.Panel.Gradient.MiddleColor = System.Drawing.Color.Empty
        Me.tChart1.Panel.Gradient.StartColor = System.Drawing.Color.White
        Me.tChart1.Panel.Gradient.Visible = True
        ' 
        ' tChart1.Panel.Pen
        ' 
        Me.tChart1.Panel.Pen.Color = System.Drawing.Color.FromArgb(CType(223, System.Byte), CType(122, System.Byte), CType(41, System.Byte))
        Me.tChart1.Panel.Pen.Visible = True
        Me.tChart1.Panel.Pen.Width = 7
        ' 
        ' tChart1.Panel.Shadow
        ' 
        ' 
        ' tChart1.Panel.Shadow.Brush
        ' 
        Me.tChart1.Panel.Shadow.Brush.Color = System.Drawing.Color.Black
        Me.tChart1.Panel.Shadow.Height = 10
        Me.tChart1.Panel.Shadow.Visible = True
        Me.tChart1.Panel.Shadow.Width = 10
        Me.tChart1.Series.Add(Me.fastLine1)
        Me.tChart1.Series.Add(Me.line1)
        ' 
        ' tChart1.Walls
        ' 
        ' 
        ' tChart1.Walls.Back
        ' 
        ' 
        ' tChart1.Walls.Back.Brush
        ' 
        ' 
        ' tChart1.Walls.Back.Gradient
        ' 
        Me.tChart1.Walls.Back.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(223, System.Byte), CType(122, System.Byte), CType(41, System.Byte))
        Me.tChart1.Walls.Back.Brush.Gradient.MiddleColor = System.Drawing.Color.Empty
        Me.tChart1.Walls.Back.Brush.Gradient.StartColor = System.Drawing.Color.White
        Me.tChart1.Walls.Back.Brush.Gradient.Visible = True
        ' 
        ' tChart1.Walls.Back.Gradient
        ' 
        Me.tChart1.Walls.Back.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(223, System.Byte), CType(122, System.Byte), CType(41, System.Byte))
        Me.tChart1.Walls.Back.Gradient.MiddleColor = System.Drawing.Color.Empty
        Me.tChart1.Walls.Back.Gradient.StartColor = System.Drawing.Color.White
        Me.tChart1.Walls.Back.Gradient.Visible = True
        Me.tChart1.Walls.Back.Transparent = False
        ' 
        ' tChart1.Walls.Bottom
        ' 
        ' 
        ' tChart1.Walls.Bottom.Brush
        ' 
        ' 
        ' tChart1.Walls.Bottom.Gradient
        ' 
        Me.tChart1.Walls.Bottom.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(252, System.Byte), CType(254, System.Byte), CType(253, System.Byte))
        Me.tChart1.Walls.Bottom.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(47, System.Byte), CType(133, System.Byte), CType(253, System.Byte))
        Me.tChart1.Walls.Bottom.Brush.Gradient.Visible = True
        ' 
        ' tChart1.Walls.Bottom.Gradient
        ' 
        Me.tChart1.Walls.Bottom.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(252, System.Byte), CType(254, System.Byte), CType(253, System.Byte))
        Me.tChart1.Walls.Bottom.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(47, System.Byte), CType(133, System.Byte), CType(253, System.Byte))
        Me.tChart1.Walls.Bottom.Gradient.Visible = True
        ' 
        ' tChart1.Walls.Left
        ' 
        ' 
        ' tChart1.Walls.Left.Brush
        ' 
        Me.tChart1.Walls.Left.Brush.Color = System.Drawing.Color.FromArgb(CType(128, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        ' 
        ' tChart1.Walls.Left.Gradient
        ' 
        Me.tChart1.Walls.Left.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(36, System.Byte), CType(209, System.Byte), CType(252, System.Byte))
        Me.tChart1.Walls.Left.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(13, System.Byte), CType(188, System.Byte), CType(124, System.Byte))
        Me.tChart1.Walls.Left.Brush.Gradient.Visible = True
        ' 
        ' tChart1.Walls.Left.Gradient
        ' 
        Me.tChart1.Walls.Left.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(36, System.Byte), CType(209, System.Byte), CType(252, System.Byte))
        Me.tChart1.Walls.Left.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(13, System.Byte), CType(188, System.Byte), CType(124, System.Byte))
        Me.tChart1.Walls.Left.Gradient.Visible = True
        ' 
        ' tChart1.Walls.Right
        ' 
        ' 
        ' tChart1.Walls.Right.Brush
        ' 
        Me.tChart1.Walls.Right.Brush.Color = System.Drawing.Color.Silver
        ' 
        ' fastLine1
        ' 
        ' 
        ' fastLine1.LinePen
        ' 
        Me.fastLine1.LinePen.Color = System.Drawing.Color.FromArgb(CType(161, System.Byte), CType(165, System.Byte), CType(93, System.Byte))
        ' 
        ' fastLine1.Marks
        ' 
        ' 
        ' fastLine1.Marks.Brush
        ' 
        ' 
        ' fastLine1.Marks.Gradient
        ' 
        Me.fastLine1.Marks.Brush.Gradient.StartColor = System.Drawing.Color.Silver
        Me.fastLine1.Marks.Brush.Gradient.Visible = True
        ' 
        ' fastLine1.Marks.Gradient
        ' 
        Me.fastLine1.Marks.Gradient.StartColor = System.Drawing.Color.Silver
        Me.fastLine1.Marks.Gradient.Visible = True
        ' 
        ' fastLine1.Marks.Symbol
        ' 
        ' 
        ' fastLine1.Marks.Symbol.Shadow
        ' 
        Me.fastLine1.Marks.Symbol.Shadow.Height = 1
        Me.fastLine1.Marks.Symbol.Shadow.Visible = True
        Me.fastLine1.Marks.Symbol.Shadow.Width = 1
        Me.fastLine1.Title = "Source"
        ' 
        ' fastLine1.XValues
        ' 
        Me.fastLine1.XValues.DataMember = "X"
        Me.fastLine1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' fastLine1.YValues
        ' 
        Me.fastLine1.YValues.DataMember = "Y"
        ' 
        ' line1
        ' 
        ' 
        ' line1.Brush
        ' 
        Me.line1.Brush.Color = System.Drawing.Color.FromArgb(CType(36, System.Byte), CType(209, System.Byte), CType(252, System.Byte))
        Me.line1.DataSource = Me.fastLine1
        Me.line1.Function = Me.medianFunction1
        ' 
        ' line1.Marks
        ' 
        ' 
        ' line1.Marks.Brush
        ' 
        ' 
        ' line1.Marks.Gradient
        ' 
        Me.line1.Marks.Brush.Gradient.StartColor = System.Drawing.Color.Silver
        Me.line1.Marks.Brush.Gradient.Visible = True
        ' 
        ' line1.Marks.Gradient
        ' 
        Me.line1.Marks.Gradient.StartColor = System.Drawing.Color.Silver
        Me.line1.Marks.Gradient.Visible = True
        ' 
        ' line1.Marks.Symbol
        ' 
        ' 
        ' line1.Marks.Symbol.Shadow
        ' 
        Me.line1.Marks.Symbol.Shadow.Height = 1
        Me.line1.Marks.Symbol.Shadow.Visible = True
        Me.line1.Marks.Symbol.Shadow.Width = 1
        ' 
        ' line1.Pointer
        ' 
        ' 
        ' line1.Pointer.Brush
        ' 
        Me.line1.Pointer.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(0, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        Me.line1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.line1.Title = "Median"
        Me.line1.VertAxis = Steema.TeeChart.Styles.VerticalAxis.Right
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
        ' Median
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(440, 317)
        Me.Name = "Median"
        Me.ResumeLayout(False)
    End Sub 'New 
#End Region
End Class 'Function_Median