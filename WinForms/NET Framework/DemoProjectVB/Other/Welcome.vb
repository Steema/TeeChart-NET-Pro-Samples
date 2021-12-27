
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports Steema.TeeChart


'/ <summary>
'/ Summary description for WelcomeForm.
'/ </summary>

Public Class WelcomeForm
    Inherits System.Windows.Forms.Form
    Private WithEvents tChart1 As Steema.TeeChart.TChart
    Private pieSeries1 As Steema.TeeChart.Styles.Pie
    Private lineSeries1 As Steema.TeeChart.Styles.Line
    Private lineSeries2 As Steema.TeeChart.Styles.Line
    Private fastLineSeries1 As Steema.TeeChart.Styles.FastLine
    Private WithEvents timer1 As System.Timers.Timer
    
    Private scaled As Boolean = False
    
    
    Private Structure BannerText
        Public tmpSize As Integer
        Public DeltaSize As Integer
        Public tmpSizeCount As Integer
        Public tmpX, tmpY As Integer
        Public DeltaX, DeltaY As Integer
        Public SomeText As String
    End Structure 'BannerText
    Private TheSeries As Steema.TeeChart.Styles.Series
    Private bt(2) As BannerText
    Private Delta, DeltaRot, DeltaElev As Integer
    Private r As System.Random
    
    
    '/ <summary>
    '/ Required designer variable.
    '/ </summary>
    Private components As System.ComponentModel.Container = Nothing
    
    
    Public Sub New()
        '
        ' Required for Windows Form Designer support
        '
        InitializeComponent()
        ' constants to rotate...
        ' fill the series
        pieSeries1.FillSampleValues(7)
        
        'Color set with transparency
        pieSeries1.Colors(0) = Color.FromArgb(120, 224, 77, 44)
        pieSeries1.Colors(1) = Color.FromArgb(120, 244, 158, 54)
        pieSeries1.Colors(2) = Color.FromArgb(120, 251, 197, 65)
        pieSeries1.Colors(3) = Color.FromArgb(120, 254, 236, 58)
        pieSeries1.Colors(4) = Color.FromArgb(120, 154, 183, 194)
        pieSeries1.Colors(5) = Color.FromArgb(120, 50, 99, 125)
        pieSeries1.Colors(6) = Color.FromArgb(120, 28, 63, 95)
        pieSeries1.Colors(7) = Color.FromArgb(120, 170, 155, 51)
        
        lineSeries1.FillSampleValues(30)
        lineSeries2.FillSampleValues(30)
        fastLineSeries1.FillSampleValues(50)
        Delta = 1
        DeltaElev = 1
        DeltaRot = 1
        TheSeries = pieSeries1
        tChart1.Aspect.Zoom = 1
        tChart1.Aspect.Orthogonal = False
        tChart1.Aspect.Elevation = 315
        tChart1.Aspect.Rotation = 360
        tChart1.Aspect.Perspective = 0
        tChart1.Aspect.Chart3DPercent = 40
        
        r = New Random()
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
        Me.tChart1 = New Steema.TeeChart.TChart
        Me.pieSeries1 = New Steema.TeeChart.Styles.Pie
        Me.lineSeries1 = New Steema.TeeChart.Styles.Line
        Me.lineSeries2 = New Steema.TeeChart.Styles.Line
        Me.fastLineSeries1 = New Steema.TeeChart.Styles.FastLine
        Me.timer1 = New System.Timers.Timer
        CType(Me.timer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        ' 
        ' tChart1
        ' 
        ' 
        ' tChart1.Aspect
        ' 
        Me.tChart1.Aspect.ColorPaletteIndex = 3
        Me.tChart1.Aspect.Elevation = 315
        Me.tChart1.Aspect.Orthogonal = False
        Me.tChart1.Aspect.Perspective = 0
        Me.tChart1.Aspect.Rotation = 360
        Me.tChart1.Aspect.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
        Me.tChart1.Aspect.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias
        Me.tChart1.BackColor = System.Drawing.Color.White
        Me.tChart1.Cursor = System.Windows.Forms.Cursors.Default
        Me.tChart1.Dock = System.Windows.Forms.DockStyle.Fill
        ' 
        ' tChart1.Header
        ' 
        Me.tChart1.Header.Lines = New String() {"tChart1"}
        Me.tChart1.Header.Visible = False
        ' 
        ' tChart1.Legend
        ' 
        Me.tChart1.Legend.Visible = False
        Me.tChart1.Location = New System.Drawing.Point(0, 0)
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
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        ' 
        ' tChart1.Panel.Gradient
        ' 
        Me.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(21, System.Byte), CType(60, System.Byte), CType(89, System.Byte))
        Me.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.tChart1.Panel.Brush.Gradient.Sigma = True
        Me.tChart1.Panel.Brush.Gradient.SigmaFocus = 0.412F
        Me.tChart1.Panel.Brush.Gradient.SigmaScale = 0.8F
        Me.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte)) '
        Me.tChart1.Panel.Brush.Gradient.UseMiddle = True
        Me.tChart1.Panel.Brush.Gradient.Visible = True
        ' 
        ' tChart1.Panel.Gradient
        ' 
        Me.tChart1.Panel.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(21, System.Byte), CType(60, System.Byte), CType(89, System.Byte))
        Me.tChart1.Panel.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.tChart1.Panel.Gradient.Sigma = True
        Me.tChart1.Panel.Gradient.SigmaFocus = 0.412F
        Me.tChart1.Panel.Gradient.SigmaScale = 0.8F
        Me.tChart1.Panel.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte)) 
        Me.tChart1.Panel.Gradient.UseMiddle = True
        Me.tChart1.Panel.Gradient.Visible = True
        Me.tChart1.Series.Add(Me.pieSeries1)
        Me.tChart1.Series.Add(Me.lineSeries1)
        Me.tChart1.Series.Add(Me.lineSeries2)
        Me.tChart1.Series.Add(Me.fastLineSeries1)
        Me.tChart1.Size = New System.Drawing.Size(393, 279)
        Me.tChart1.TabIndex = 0
        ' 
        ' pieSeries1
        ' 
        ' 
        ' pieSeries1.Brush
        ' 
        Me.pieSeries1.Brush.Color = System.Drawing.Color.Red
        Me.pieSeries1.CircleBackColor = System.Drawing.Color.FromArgb(CType(0, System.Byte), CType(0, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        Me.pieSeries1.ExplodeBiggest = 30
        Me.pieSeries1.LabelMember = "Labels"
        ' 
        ' pieSeries1.Marks
        ' 
        ' 
        ' pieSeries1.Marks.Symbol
        ' 
        ' 
        ' pieSeries1.Marks.Symbol.Shadow
        ' 
        Me.pieSeries1.Marks.Symbol.Shadow.Height = 1
        Me.pieSeries1.Marks.Symbol.Shadow.Visible = True
        Me.pieSeries1.Marks.Symbol.Shadow.Width = 1
        ' 
        ' pieSeries1.Pen
        ' 
        Me.pieSeries1.Pen.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(192, System.Byte), CType(192, System.Byte), CType(192, System.Byte))
        ' 
        ' pieSeries1.Shadow
        ' 
        Me.pieSeries1.Shadow.Height = 20
        Me.pieSeries1.Shadow.Width = 20
        Me.pieSeries1.Title = "pie1"
        ' 
        ' pieSeries1.XValues
        ' 
        Me.pieSeries1.XValues.DataMember = "Angle"
        Me.pieSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' pieSeries1.YValues
        ' 
        Me.pieSeries1.YValues.DataMember = "Pie"
        ' 
        ' lineSeries1
        ' 
        ' 
        ' lineSeries1.Brush
        ' 
        Me.lineSeries1.Brush.Color = System.Drawing.Color.FromArgb(CType(198, System.Byte), CType(255, System.Byte), CType(199, System.Byte), CType(26, System.Byte))
        ' 
        ' lineSeries1.Gradient
        ' 
        Me.lineSeries1.Brush.Gradient.Transparency = 25
        ' 
        ' lineSeries1.Gradient
        ' 
        Me.lineSeries1.Gradient.Transparency = 25
        ' 
        ' lineSeries1.LinePen
        ' 
        Me.lineSeries1.LinePen.Visible = False
        ' 
        ' lineSeries1.Marks
        ' 
        ' 
        ' lineSeries1.Marks.Symbol
        ' 
        ' 
        ' lineSeries1.Marks.Symbol.Shadow
        ' 
        Me.lineSeries1.Marks.Symbol.Shadow.Height = 1
        Me.lineSeries1.Marks.Symbol.Shadow.Visible = True
        Me.lineSeries1.Marks.Symbol.Shadow.Width = 1
        ' 
        ' lineSeries1.Pointer
        ' 
        ' 
        ' lineSeries1.Pointer.Brush
        ' 
        Me.lineSeries1.Pointer.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(0, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        Me.lineSeries1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.lineSeries1.Title = "line2"
        Me.lineSeries1.Visible = False
        ' 
        ' lineSeries1.XValues
        ' 
        Me.lineSeries1.XValues.DataMember = "X"
        Me.lineSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' lineSeries1.YValues
        ' 
        Me.lineSeries1.YValues.DataMember = "Y"
        ' 
        ' lineSeries2
        ' 
        ' 
        ' lineSeries2.Brush
        ' 
        Me.lineSeries2.Brush.Color = System.Drawing.Color.FromArgb(CType(198, System.Byte), CType(106, System.Byte), CType(106, System.Byte), CType(255, System.Byte))
        ' 
        ' lineSeries2.Gradient
        ' 
        Me.lineSeries2.Brush.Gradient.Transparency = 35
        ' 
        ' lineSeries2.Gradient
        ' 
        Me.lineSeries2.Gradient.Transparency = 35
        ' 
        ' lineSeries2.LinePen
        ' 
        Me.lineSeries2.LinePen.Visible = False
        ' 
        ' lineSeries2.Marks
        ' 
        ' 
        ' lineSeries2.Marks.Symbol
        ' 
        ' 
        ' lineSeries2.Marks.Symbol.Shadow
        ' 
        Me.lineSeries2.Marks.Symbol.Shadow.Height = 1
        Me.lineSeries2.Marks.Symbol.Shadow.Visible = True
        Me.lineSeries2.Marks.Symbol.Shadow.Width = 1
        ' 
        ' lineSeries2.Pointer
        ' 
        ' 
        ' lineSeries2.Pointer.Brush
        ' 
        Me.lineSeries2.Pointer.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(0, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        Me.lineSeries2.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.lineSeries2.Title = "line3"
        Me.lineSeries2.Visible = False
        ' 
        ' lineSeries2.XValues
        ' 
        Me.lineSeries2.XValues.DataMember = "X"
        Me.lineSeries2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' lineSeries2.YValues
        ' 
        Me.lineSeries2.YValues.DataMember = "Y"
        ' 
        ' fastLineSeries1
        ' 
        ' 
        ' fastLineSeries1.LinePen
        ' 
        Me.fastLineSeries1.LinePen.Color = System.Drawing.Color.FromArgb(CType(255, System.Byte), CType(255, System.Byte), CType(204, System.Byte))
        ' 
        ' fastLineSeries1.Marks
        ' 
        ' 
        ' fastLineSeries1.Marks.Symbol
        ' 
        ' 
        ' fastLineSeries1.Marks.Symbol.Shadow
        ' 
        Me.fastLineSeries1.Marks.Symbol.Shadow.Height = 1
        Me.fastLineSeries1.Marks.Symbol.Shadow.Visible = True
        Me.fastLineSeries1.Marks.Symbol.Shadow.Width = 1
        Me.fastLineSeries1.Title = "fast Line4"
        Me.fastLineSeries1.Visible = False
        ' 
        ' fastLineSeries1.XValues
        ' 
        Me.fastLineSeries1.XValues.DataMember = "X"
        Me.fastLineSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' fastLineSeries1.YValues
        ' 
        Me.fastLineSeries1.YValues.DataMember = "Y"
        ' 
        ' timer1
        ' 
        Me.timer1.SynchronizingObject = Me
        ' 
        ' WelcomeForm
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(393, 279)
        Me.Controls.Add(tChart1)
        Me.Name = "WelcomeForm"
        Me.Text = "WelcomeForm"
        CType(Me.timer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub 'InitializeComponent 
#End Region






    Private Sub WelcomeForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bt(0).tmpSizeCount = 0
        bt(0).tmpSize = 4
        bt(0).DeltaSize = 1
        bt(0).tmpX = 0
        bt(0).tmpY = 0
        bt(0).DeltaX = 2
        bt(0).DeltaY = 4
        bt(0).SomeText = "100% Source Code"

        bt(1).tmpSizeCount = 1
        bt(1).tmpSize = 12
        bt(1).DeltaSize = -1
        bt(1).tmpX = 0
        bt(1).tmpY = tChart1.Height - 30
        bt(1).DeltaX = 1
        bt(1).DeltaY = -3
        bt(1).SomeText = "For all .NET developers"

        bt(2).tmpSizeCount = 3
        bt(2).tmpSize = 2
        bt(2).DeltaSize = 1
        bt(2).tmpX = tChart1.Width - 50
        bt(2).tmpY = tChart1.Height - 30
        bt(2).DeltaX = -2
        bt(2).DeltaY = -2
        bt(2).SomeText = "Visit our Web Site !"

        timer1.Interval = 50
        timer1.Start()
    End Sub 'WelcomeForm_Load


    Private Sub DrawBannerText()
        Dim c As Steema.TeeChart.Drawing.Graphics3D = tChart1.Graphics3D
        c.Font.Color = Color.Gray
        c.Font.Shadow.Height = 1
        c.Font.Shadow.Width = 1
        Dim i As Integer
        For i = 0 To bt.Length - 1
            bt(i).tmpSizeCount += 1
            If bt(i).tmpSizeCount >= 1 Then
                bt(i).tmpSizeCount = 0
                bt(i).tmpSize += bt(i).DeltaSize
                If bt(i).tmpSize < 2 Then
                    bt(i).DeltaSize = 1
                ElseIf bt(i).tmpSize > 22 Then
                    bt(i).DeltaSize = -1
                End If
            End If
            c.Font.Size = bt(i).tmpSize
            bt(i).tmpX += bt(i).DeltaX

            If bt(i).tmpX < -30 OrElse bt(i).tmpX > tChart1.Width Then
                bt(i).DeltaX = -bt(i).DeltaX
            End If
            bt(i).tmpY += bt(i).DeltaY
            If bt(i).tmpY < 0 OrElse bt(i).tmpY > tChart1.Height Then
                bt(i).DeltaY = -bt(i).DeltaY
            End If
            c.TextOut(bt(i).tmpX, bt(i).tmpY, bt(i).SomeText)
        Next i
    End Sub 'DrawBannerText


    Private Sub AddPoint(ByVal s As Steema.TeeChart.Styles.Series)
        s.Add(s.XValues.Last + 1, s.YValues.Last + r.Next(40) - 20.0)
        s.Delete(0)

    End Sub 'AddPoint

    Private Sub timer1_Elapsed(ByVal sender As Object, ByVal e As System.Timers.ElapsedEventArgs) Handles timer1.Elapsed

        timer1.Stop()
        Dim asp As Steema.TeeChart.Drawing.Aspect = tChart1.Aspect
        ' Pie series, do rotation...

        If (TypeOf TheSeries Is Steema.TeeChart.Styles.Pie) Then
            CType(TheSeries, Steema.TeeChart.Styles.Pie).RotationAngle = (CType(TheSeries, Steema.TeeChart.Styles.Pie).RotationAngle + 2)
        Else
            If (Not scaled) Then

                'Axis
                tChart1.Axes.Left.Increment = (tChart1.Axes.Left.Maximum - tChart1.Axes.Left.Minimum) / 10
                scaled = True
            End If

            ' scroll points...
            AddPoint(lineSeries1)
            AddPoint(lineSeries2)
            AddPoint(fastLineSeries1)
            ' change 3D view (rotation / elevation) ...
            asp.Elevation += DeltaElev


            If ((asp.Elevation > 320) OrElse (asp.Elevation < 280)) Then
                DeltaElev = -DeltaElev
            End If
            asp.Rotation += DeltaRot
            If ((asp.Rotation > 355) OrElse (asp.Rotation < 272)) Then
                DeltaRot = -DeltaRot
            End If
        End If

        'change view Zoom...
        asp.Zoom += Delta
        ' reverse zoom-in / zoom-out
        If (asp.Zoom > 200) OrElse (asp.Zoom < 2) Then
            Delta = -Delta
        End If
        '	change from Pie to Lines..,
        If asp.Zoom > 200 Then
            pieSeries1.Active = False
            lineSeries1.Active = False
            lineSeries2.Active = False
            fastLineSeries1.Active = False
            If (TheSeries Is pieSeries1) Then
                TheSeries = lineSeries1
                lineSeries1.Active = True
                lineSeries2.Active = True
                fastLineSeries1.Active = True
                asp.Perspective = 85
                asp.Rotation = 300
            Else
                TheSeries = pieSeries1
                asp.Rotation = 360
                TheSeries.Active = True
            End If
        End If
        ' re-start the timer...
        timer1.Start()
    End Sub 'timer1_Elapsed


    Private Sub tChart1_AfterDraw(ByVal sender As Object, ByVal g As Steema.TeeChart.Drawing.Graphics3D) Handles tChart1.AfterDraw
        If TypeOf TheSeries Is Steema.TeeChart.Styles.Pie Then
            DrawBannerText()
        End If
    End Sub 'tChart1_AfterDraw

    Private Sub tChart1_BeforeDraw(ByVal sender As Object, ByVal g As Steema.TeeChart.Drawing.Graphics3D) Handles tChart1.BeforeDraw
        If Not TypeOf TheSeries Is Steema.TeeChart.Styles.Pie Then
            DrawBannerText()
        End If
    End Sub 'tChart1_BeforeDraw
End Class 'WelcomeForm