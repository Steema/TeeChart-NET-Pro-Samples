Imports System
#If VS2005 Then
Imports System.Collections.Generic
#End If
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms




Public Class Contour_Frame
    Inherits Samples.BaseForm

    Private contour1 As Steema.TeeChart.Styles.Contour
    Private buttonPen1 As ButtonPen

    '/ <summary>
    '/ Required designer variable.
    '/ </summary>
    Private components As System.ComponentModel.IContainer = Nothing


    Public Sub New() ' me call is required by the Windows Form Designer.
        InitializeComponent()
        contour1.FillSampleValues(25)
        buttonPen1.Pen = contour1.Frame
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
    '/ the contents of me method with the code editor.
    '/ </summary>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Contour_Frame))
        Me.contour1 = New Steema.TeeChart.Styles.Contour()
        Me.buttonPen1 = New Steema.TeeChart.ButtonPen()
        Me.panel1.SuspendLayout()
        Me.chartContainer.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Text = "Contour series now has a Frame pen."
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.buttonPen1)
        ' 
        ' tChart1
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Aspect.Chart3DPercent = 50
        Me.tChart1.Aspect.ColorPaletteIndex = 0
        Me.tChart1.Aspect.Orthogonal = False
        Me.tChart1.Aspect.Perspective = 100
        Me.tChart1.Aspect.Rotation = 321
        Me.tChart1.Aspect.RotationFloat = 321
        Me.tChart1.Aspect.Zoom = 95
        Me.tChart1.Aspect.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
        ' 
        ' 
        ' 
        Me.tChart1.Legend.MaxNumRows = 8
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tChart1.Panel.Brush.Gradient.ExtendedColorPalette = Nothing
        Me.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.tChart1.Panel.Brush.Gradient.UseMiddle = True
        Me.tChart1.Panel.Brush.Gradient.Visible = True
        Me.tChart1.Series.Add(Me.contour1)
        Me.tChart1.Size = New System.Drawing.Size(440, 205)
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Walls.Back.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tChart1.Walls.Back.Brush.Gradient.ExtendedColorPalette = Nothing
        Me.tChart1.Walls.Back.Brush.Gradient.MiddleColor = System.Drawing.Color.Empty
        Me.tChart1.Walls.Back.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.tChart1.Walls.Back.Brush.Gradient.Visible = True
        Me.tChart1.Walls.Back.Brush.Visible = True
        Me.tChart1.Walls.Back.Transparent = False
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Walls.Bottom.Brush.Visible = False
        ' 
        ' contour1
        ' 
        ' 
        ' 
        ' 
        Me.contour1.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.contour1.ColorEach = False
        Me.contour1.DefaultNullValue = 0
        Me.contour1.DrawingAlgorithm = Steema.TeeChart.Styles.ContourConstruction.Fast
        ' 
        ' 
        ' 
        Me.contour1.Frame.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.contour1.Frame.Style = System.Drawing.Drawing2D.DashStyle.Dot
        Me.contour1.Frame.Visible = True
        Me.contour1.Frame.Width = 3
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.contour1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None
        Me.contour1.Marks.Callout.ArrowHeadSize = 8
        ' 
        ' 
        ' 
        Me.contour1.Marks.Callout.Brush.Color = System.Drawing.Color.Black
        Me.contour1.Marks.Callout.Distance = 0
        Me.contour1.Marks.Callout.Draw3D = False
        Me.contour1.Marks.Callout.Length = 10
        Me.contour1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.contour1.Marks.Transparent = True
        Me.contour1.PaletteMin = 0
        Me.contour1.PaletteStep = 0
        Me.contour1.PaletteStyle = Steema.TeeChart.Styles.PaletteStyles.Pale
        ' 
        ' 
        ' 
        Me.contour1.Pointer.HorizSize = 2
        ' 
        ' 
        ' 
        Me.contour1.Pointer.Pen.Visible = False
        Me.contour1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.contour1.Pointer.VertSize = 2
        Me.contour1.Title = "contour1"
        ' 
        ' 
        ' 
        Me.contour1.XValues.DataMember = "X"
        Me.contour1.YPosition = 0.18959828428699516
        ' 
        ' 
        ' 
        Me.contour1.YValues.DataMember = "Y"
        ' 
        ' 
        ' 
        Me.contour1.ZValues.DataMember = "Z"
        ' 
        ' buttonPen1
        ' 
        Me.buttonPen1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonPen1.Location = New System.Drawing.Point(12, 10)
        Me.buttonPen1.Name = "buttonPen1"
        Me.buttonPen1.Size = New System.Drawing.Size(75, 23)
        Me.buttonPen1.TabIndex = 1
        Me.buttonPen1.Text = "Frame..."
#If (VS2005) Then
            me.buttonPen1.UseVisualStyleBackColor = true
#End If
        ' 
        ' Contour_Frame
        ' 
        Me.ClientSize = New System.Drawing.Size(440, 317)
        Me.Name = "Contour_Frame"
        Me.panel1.ResumeLayout(False)
        Me.chartContainer.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region



End Class

