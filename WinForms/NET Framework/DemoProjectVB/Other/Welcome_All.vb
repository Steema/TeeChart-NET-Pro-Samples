
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms


'/ <summary>
'/ Welcome_All dialogue.
'/ </summary>

Public Class Welcome_All
    Inherits System.Windows.Forms.Form
    Protected WithEvents tChart1 As Steema.TeeChart.TChart
    Private lineSeries1 As Steema.TeeChart.Styles.Line
    Private WithEvents timer1 As System.Timers.Timer
    Private panel1 As System.Windows.Forms.Panel
    Private label1 As System.Windows.Forms.Label
    Private label2 As System.Windows.Forms.Label
    Private label3 As System.Windows.Forms.Label
    Private pictureBox4 As System.Windows.Forms.PictureBox
    Private pictureBox5 As System.Windows.Forms.PictureBox
    Private label4 As System.Windows.Forms.Label
    Private r As New Random(45)
    Private deltaUp As Boolean = False
    Private label5 As System.Windows.Forms.Label
    Private label6 As System.Windows.Forms.Label
    Private label7 As System.Windows.Forms.Label
    Private gridBand1 As Steema.TeeChart.Tools.GridBand
    Private label8 As System.Windows.Forms.Label
    '/ <summary>
    '/ Required designer variable.
    '/ </summary>
    Private components As System.ComponentModel.Container = Nothing
    
    
    Public Sub New()
        '
        ' Required for Windows Form Designer support
        '
        InitializeComponent()
        
        tChart1.Zoom.Allow = False
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Welcome_All))
        Me.tChart1 = New Steema.TeeChart.TChart
        Me.lineSeries1 = New Steema.TeeChart.Styles.Line
        Me.gridBand1 = New Steema.TeeChart.Tools.GridBand
        Me.timer1 = New System.Timers.Timer
        Me.panel1 = New System.Windows.Forms.Panel
        Me.label8 = New System.Windows.Forms.Label
        Me.label7 = New System.Windows.Forms.Label
        Me.label6 = New System.Windows.Forms.Label
        Me.label5 = New System.Windows.Forms.Label
        Me.label4 = New System.Windows.Forms.Label
        Me.label3 = New System.Windows.Forms.Label
        Me.label2 = New System.Windows.Forms.Label
        Me.label1 = New System.Windows.Forms.Label
        Me.pictureBox4 = New System.Windows.Forms.PictureBox
        Me.pictureBox5 = New System.Windows.Forms.PictureBox
        CType(Me.timer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tChart1
        '
        '
        'tChart1.Aspect
        '
        Me.tChart1.Aspect.Chart3DPercent = 10
        Me.tChart1.Aspect.Elevation = 360
        Me.tChart1.Aspect.ElevationFloat = 360
        Me.tChart1.Aspect.Perspective = 50
        Me.tChart1.Aspect.Rotation = 315
        Me.tChart1.Aspect.RotationFloat = 315
        Me.tChart1.Aspect.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality
        Me.tChart1.Aspect.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        Me.tChart1.Aspect.Zoom = 102
        '
        'tChart1.Axes
        '
        '
        'tChart1.Axes.Bottom
        '
        Me.tChart1.Axes.Bottom.Automatic = True
        '
        'tChart1.Axes.Bottom.Grid
        '
        Me.tChart1.Axes.Bottom.Grid.ZPosition = 0
        '
        'tChart1.Axes.Bottom.Labels
        '
        Me.tChart1.Axes.Bottom.Labels.Style = Steema.TeeChart.AxisLabelStyle.None
        Me.tChart1.Axes.Bottom.Visible = False
        '
        'tChart1.Axes.Depth
        '
        Me.tChart1.Axes.Depth.Automatic = True
        '
        'tChart1.Axes.Depth.Grid
        '
        Me.tChart1.Axes.Depth.Grid.ZPosition = 0
        '
        'tChart1.Axes.DepthTop
        '
        Me.tChart1.Axes.DepthTop.Automatic = True
        '
        'tChart1.Axes.DepthTop.Grid
        '
        Me.tChart1.Axes.DepthTop.Grid.ZPosition = 0
        '
        'tChart1.Axes.Left
        '
        Me.tChart1.Axes.Left.Automatic = True
        '
        'tChart1.Axes.Left.Grid
        '
        Me.tChart1.Axes.Left.Grid.Color = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.tChart1.Axes.Left.Grid.ZPosition = 0
        '
        'tChart1.Axes.Left.Labels
        '
        Me.tChart1.Axes.Left.Labels.CustomSize = 1
        Me.tChart1.Axes.Left.LogarithmicBase = 2
        '
        'tChart1.Axes.Right
        '
        Me.tChart1.Axes.Right.Automatic = True
        '
        'tChart1.Axes.Right.Grid
        '
        Me.tChart1.Axes.Right.Grid.ZPosition = 0
        '
        'tChart1.Axes.Top
        '
        Me.tChart1.Axes.Top.Automatic = True
        '
        'tChart1.Axes.Top.Grid
        '
        Me.tChart1.Axes.Top.Grid.ZPosition = 0
        Me.tChart1.Cursor = System.Windows.Forms.Cursors.Default
        Me.tChart1.Dock = System.Windows.Forms.DockStyle.Bottom
        '
        'tChart1.Header
        '
        Me.tChart1.Header.Lines = New String() {"tChart1"}
        Me.tChart1.Header.Visible = False
        '
        'tChart1.Legend
        '
        '
        'tChart1.Legend.Shadow
        '
        Me.tChart1.Legend.Shadow.Visible = True
        '
        'tChart1.Legend.Title
        '
        '
        'tChart1.Legend.Title.Font
        '
        Me.tChart1.Legend.Title.Font.Bold = True
        '
        'tChart1.Legend.Title.Pen
        '
        Me.tChart1.Legend.Title.Pen.Visible = False
        Me.tChart1.Legend.Visible = False
        Me.tChart1.Location = New System.Drawing.Point(0, 237)
        Me.tChart1.Name = "tChart1"
        '
        'tChart1.Panel
        '
        '
        'tChart1.Panel.Brush
        '
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(254, Byte), CType(255, Byte), CType(255, Byte), CType(255, Byte))
        '
        'tChart1.Panel.Gradient
        '
        Me.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(117, Byte), CType(126, Byte), CType(100, Byte))
        '
        'tChart1.Panel.Gradient
        '
        Me.tChart1.Panel.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(117, Byte), CType(126, Byte), CType(100, Byte))
        Me.tChart1.Panel.MarginLeft = 0
        Me.tChart1.Panel.MarginRight = 2
        Me.tChart1.Series.Add(Me.lineSeries1)
        Me.tChart1.Size = New System.Drawing.Size(489, 113)
        Me.tChart1.TabIndex = 4
        Me.tChart1.Tools.Add(Me.gridBand1)
        '
        'tChart1.Walls
        '
        '
        'tChart1.Walls.Back
        '
        Me.tChart1.Walls.Back.AutoHide = False
        '
        'tChart1.Walls.Bottom
        '
        Me.tChart1.Walls.Bottom.AutoHide = False
        '
        'tChart1.Walls.Left
        '
        Me.tChart1.Walls.Left.AutoHide = False
        '
        'tChart1.Walls.Right
        '
        Me.tChart1.Walls.Right.AutoHide = False
        '
        'lineSeries1
        '
        '
        'lineSeries1.Brush
        '
        Me.lineSeries1.Brush.Color = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(128, Byte))
        '
        'lineSeries1.LinePen
        '
        Me.lineSeries1.LinePen.Color = System.Drawing.Color.FromArgb(CType(128, Byte), CType(128, Byte), CType(0, Byte))
        '
        'lineSeries1.Marks
        '
        '
        'lineSeries1.Marks.Callout
        '
        Me.lineSeries1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None
        Me.lineSeries1.Marks.Callout.ArrowHeadSize = 8
        '
        'lineSeries1.Marks.Callout.Brush
        '
        Me.lineSeries1.Marks.Callout.Brush.Color = System.Drawing.Color.Black
        Me.lineSeries1.Marks.Callout.Distance = 0
        Me.lineSeries1.Marks.Callout.Draw3D = False
        Me.lineSeries1.Marks.Callout.Length = 10
        Me.lineSeries1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        '
        'lineSeries1.Marks.Shadow
        '
        Me.lineSeries1.Marks.Shadow.Visible = True
        '
        'lineSeries1.Marks.Symbol
        '
        '
        'lineSeries1.Marks.Symbol.Shadow
        '
        Me.lineSeries1.Marks.Symbol.Shadow.Visible = True
        '
        'lineSeries1.Pointer
        '
        '
        'lineSeries1.Pointer.Brush
        '
        Me.lineSeries1.Pointer.Brush.Color = System.Drawing.Color.FromArgb(CType(254, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
        Me.lineSeries1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.lineSeries1.Title = "line1"
        '
        'lineSeries1.XValues
        '
        Me.lineSeries1.XValues.DataMember = "X"
        Me.lineSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        '
        'lineSeries1.YValues
        '
        Me.lineSeries1.YValues.DataMember = "Y"
        '
        'gridBand1
        '
        Me.gridBand1.Axis = Me.tChart1.Axes.Left
        '
        'gridBand1.Band1
        '
        Me.gridBand1.Band1.Color = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
        '
        'gridBand1.Band2
        '
        Me.gridBand1.Band2.Color = System.Drawing.Color.FromArgb(CType(127, Byte), CType(224, Byte), CType(224, Byte), CType(224, Byte))
        '
        'timer1
        '
        Me.timer1.Interval = 50
        Me.timer1.SynchronizingObject = Me
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.Color.White
        Me.panel1.Controls.Add(Me.label8)
        Me.panel1.Controls.Add(Me.label7)
        Me.panel1.Controls.Add(Me.label6)
        Me.panel1.Controls.Add(Me.label5)
        Me.panel1.Controls.Add(Me.label4)
        Me.panel1.Controls.Add(Me.label3)
        Me.panel1.Controls.Add(Me.label2)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Controls.Add(Me.pictureBox4)
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel1.Location = New System.Drawing.Point(0, 80)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(489, 157)
        Me.panel1.TabIndex = 6
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.BackColor = System.Drawing.Color.Transparent
        Me.label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label8.Location = New System.Drawing.Point(30, 36)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(121, 17)
        Me.label8.TabIndex = 11
        Me.label8.Text = "Extensive User Tools"
        Me.label8.UseMnemonic = False
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.BackColor = System.Drawing.Color.Transparent
        Me.label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label7.Location = New System.Drawing.Point(30, 90)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(118, 17)
        Me.label7.TabIndex = 10
        Me.label7.Text = "OpenGL Component"
        Me.label7.UseMnemonic = False
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.BackColor = System.Drawing.Color.Transparent
        Me.label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label6.Location = New System.Drawing.Point(30, 126)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(185, 17)
        Me.label6.TabIndex = 9
        Me.label6.Text = "PocketPC and WebMatrix Charts"
        Me.label6.UseMnemonic = False
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.BackColor = System.Drawing.Color.Transparent
        Me.label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label5.Location = New System.Drawing.Point(30, 108)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(345, 17)
        Me.label5.TabIndex = 8
        Me.label5.Text = "Data aware. Supports SQLDataAdapter, Dataviews and tables"
        Me.label5.UseMnemonic = False
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.BackColor = System.Drawing.Color.Transparent
        Me.label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.Location = New System.Drawing.Point(30, 72)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(218, 17)
        Me.label4.TabIndex = 7
        Me.label4.Text = "ASP.NET support with WebForm Chart"
        Me.label4.UseMnemonic = False
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.BackColor = System.Drawing.Color.Transparent
        Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.Location = New System.Drawing.Point(30, 54)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(318, 17)
        Me.label3.TabIndex = 2
        Me.label3.Text = "Run-time Editor, Print-Preview, Gallery and Navigator bar"
        Me.label3.UseMnemonic = False
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.BackColor = System.Drawing.Color.Transparent
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(30, 18)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(257, 17)
        Me.label2.TabIndex = 1
        Me.label2.Text = "39 Functions (Standard, Financial, Statistical)."
        Me.label2.UseMnemonic = False
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.BackColor = System.Drawing.Color.Transparent
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(30, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(322, 17)
        Me.label1.TabIndex = 0
        Me.label1.Text = "47 Chart styles (in 2D and 3D plus multiple combinations)."
        Me.label1.UseMnemonic = False
        '
        'pictureBox4
        '
        Me.pictureBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pictureBox4.Image = CType(resources.GetObject("pictureBox4.Image"), System.Drawing.Image)
        Me.pictureBox4.Location = New System.Drawing.Point(0, -4)
        Me.pictureBox4.Name = "pictureBox4"
        Me.pictureBox4.Size = New System.Drawing.Size(489, 161)
        Me.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pictureBox4.TabIndex = 6
        Me.pictureBox4.TabStop = False
        '
        'pictureBox5
        '
        Me.pictureBox5.BackColor = System.Drawing.Color.White
        Me.pictureBox5.Dock = System.Windows.Forms.DockStyle.Top
        Me.pictureBox5.Location = New System.Drawing.Point(0, 0)
        Me.pictureBox5.Name = "pictureBox5"
        Me.pictureBox5.Size = New System.Drawing.Size(489, 80)
        Me.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pictureBox5.TabIndex = 7
        Me.pictureBox5.TabStop = False
        '
        'Welcome_All
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(489, 350)
        Me.Controls.Add(Me.panel1)
        Me.Controls.Add(Me.tChart1)
        Me.Controls.Add(Me.pictureBox5)
        Me.Name = "Welcome_All"
        Me.Text = "Welcome_All"
        CType(Me.timer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub 'InitializeComponent 
#End Region


    Private Sub Welcome_All_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '  Set axis...
        tChart1.Axes.Left.SetMinMax(-100, 100)
        tChart1.Axes.Bottom.SetMinMax(0, 360)
        ' Start animation
        timer1.Start()
    End Sub 'Welcome_All_Load


    Private Sub timer1_Elapsed(ByVal sender As Object, ByVal e As System.Timers.ElapsedEventArgs) Handles timer1.Elapsed
        timer1.Stop()
        If lineSeries1.Count > 360 Then
            If lineSeries1.XValues.Last > 540 Then
                If deltaUp Then
                    lineSeries1.Add(lineSeries1.XValues.Last + 1, lineSeries1.YValues.Last + r.Next(-5, 45))
                    If lineSeries1.YValues.Last > 54 Then
                        deltaUp = False
                    End If
                Else
                    lineSeries1.Add(lineSeries1.XValues.Last + 1, lineSeries1.YValues.Last + r.Next(-45, 5))
                    If lineSeries1.YValues.Last < -54 Then
                        deltaUp = True
                    End If
                End If
            Else
                lineSeries1.Add(lineSeries1.XValues.Last + 1, (100.0 * Math.Sin((lineSeries1.XValues.Last - 360) * Math.PI / 180)))
            End If
            lineSeries1.Delete(0, 1) '
            tChart1.Axes.Bottom.Scroll(1, False)
        Else
            lineSeries1.Add(100.0 * Math.Sin(lineSeries1.Count * Math.PI / 180))
        End If
        timer1.Start() '
    End Sub 'timer1_Elapsed


    Private Sub tChart1_GetAxisLabel(ByVal sender As Object, ByVal e As Steema.TeeChart.GetAxisLabelEventArgs) Handles tChart1.GetAxisLabel
        e.LabelText = ""
    End Sub 'tChart1_GetAxisLabel

End Class 'Welcome_All