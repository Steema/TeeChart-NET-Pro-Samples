
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing

Imports System.Windows.Forms



Public Class Polar_Nulls
    Inherits Samples.BaseForm


    Friend WithEvents Polar1 As Steema.TeeChart.Styles.Polar
    Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
    '/ <summary>
    '/ Required designer variable.
    '/ </summary>
    Private components As System.ComponentModel.IContainer = Nothing


    Public Sub New() ' This call is required by the Windows Form Designer.
        InitializeComponent()
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Polar_Nulls))
        Me.checkBox1 = New System.Windows.Forms.CheckBox
        Me.Polar1 = New Steema.TeeChart.Styles.Polar
        Me.panel1.SuspendLayout()
        Me.chartContainer.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Text = "Polar and radar series now support null points (controlled via the TreatNulls property). Uncheck the ""Hide null points"" checkbox to see the difference between ""normal"" and ""null"" style(s)."
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.checkBox1)
        ' 
        ' tChart1
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Aspect.Elevation = 315
        Me.tChart1.Aspect.ElevationFloat = 315
        Me.tChart1.Aspect.Orthogonal = False
        Me.tChart1.Aspect.Perspective = 0
        Me.tChart1.Aspect.Rotation = 360
        Me.tChart1.Aspect.RotationFloat = 360
        Me.tChart1.Aspect.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
        Me.tChart1.Aspect.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        Me.tChart1.Aspect.View3D = False
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
        Me.tChart1.Axes.Bottom.Labels.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Bottom.Title.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Depth.Labels.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Depth.Title.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.DepthTop.Labels.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.DepthTop.Title.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Left.Labels.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Left.Title.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        Me.tChart1.Axes.Left.Visible = False
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Right.Labels.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Right.Title.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Top.Labels.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Top.Title.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Footer.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Header.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        Me.tChart1.Header.Lines = New String() {"Polar null points"}
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Legend.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Legend.Title.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(216, Byte), Integer))
        ' 
        ' 
        ' 
        Me.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.tChart1.Panel.Brush.Gradient.ExtendedColorPalette = Nothing
        Me.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tChart1.Panel.Brush.Gradient.Sigma = True
        Me.tChart1.Panel.Brush.Gradient.SigmaFocus = 1.0!
        Me.tChart1.Panel.Brush.Gradient.SigmaScale = 0.8!
        Me.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tChart1.Panel.Brush.Gradient.UseMiddle = True
        Me.tChart1.Panel.Brush.Gradient.Visible = True
        Me.tChart1.Series.Add(Me.Polar1)
        Me.tChart1.Size = New System.Drawing.Size(440, 205)
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.SubFooter.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.SubHeader.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Walls.Back.Brush.Visible = True
        ' 
        ' checkBox1
        ' 
#If VS2005 Then
        Me.checkBox1.AutoSize = True
#End If
        Me.checkBox1.Checked = True
        Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox1.Location = New System.Drawing.Point(12, 16)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(98, 17)
        Me.checkBox1.TabIndex = 0
        Me.checkBox1.Text = "Hide null points"
#If VS2005 Then
        Me.checkBox1.UseVisualStyleBackColor = True
#End If
        AddHandler checkBox1.CheckedChanged, AddressOf Me.checkBox1_CheckedChanged
        ' 
        ' polar1
        ' 
        ' 
        ' 
        ' 
        Me.Polar1.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Polar1.Brush.Solid = False
        Me.Polar1.Brush.Style = System.Drawing.Drawing2D.HatchStyle.DarkUpwardDiagonal
        ' 
        ' 
        ' 
        Me.Polar1.CircleGradient.ExtendedColorPalette = Nothing
        ' 
        ' 
        ' 
        Me.Polar1.CircleLabelsFont.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        Me.Polar1.ColorEach = False
        ' 
        ' 
        ' 
        Me.Polar1.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.Polar1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None
        Me.Polar1.Marks.Callout.ArrowHeadSize = 8
        ' 
        ' 
        ' 
        Me.Polar1.Marks.Callout.Brush.Color = System.Drawing.Color.Black
        Me.Polar1.Marks.Callout.Distance = 0
        Me.Polar1.Marks.Callout.Draw3D = False
        Me.Polar1.Marks.Callout.Length = 10
        Me.Polar1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        ' 
        ' 
        ' 
        Me.Polar1.Marks.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        ' 
        ' 
        ' 
        Me.Polar1.Pen.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        ' 
        ' 
        ' 
        Me.Polar1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.Polar1.Pointer.Visible = True
        Me.Polar1.Title = "polar1"
        Me.Polar1.TreatNulls = Steema.TeeChart.Styles.TreatNullsStyle.DoNotPaint
        ' 
        ' 
        ' 
        Me.Polar1.XValues.DataMember = "Angle"
        Me.Polar1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' 
        ' 
        Me.Polar1.YValues.DataMember = "Y"
        ' 
        ' Polar_Nulls
        ' 
        Me.ClientSize = New System.Drawing.Size(440, 317)
        Me.Name = "Polar_Nulls"
        AddHandler Load, AddressOf Me.Polar_Nulls_Load
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.chartContainer.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)

        If (checkBox1.Checked) Then
            Polar1.TreatNulls = Steema.TeeChart.Styles.TreatNullsStyle.DoNotPaint
        Else
            Polar1.TreatNulls = Steema.TeeChart.Styles.TreatNullsStyle.Ignore
        End If
    End Sub

    Private Sub Polar_Nulls_Load(ByVal sender As Object, ByVal e As EventArgs)

        Polar1.Add(0, 67)
        Polar1.Add(30, 45)
        Polar1.Add(60, 50)
        Polar1.Add(75, 90)
        Polar1.Add(90, 90, Color.Transparent) ' <- Null point .. It lies between angles of 75 and 100
        Polar1.Add(100, 75)
        Polar1.Add(120, 45)
        Polar1.Add(150, 80)
        Polar1.Add(160, 80, Color.Transparent) ' <- Null point .. It lies between angles of 150 and 180
        Polar1.Add(180, 70)
        Polar1.Add(210, 35)
        Polar1.Add(240, 33)
        Polar1.Add(270, 55)
        Polar1.Add(300, 65)
        Polar1.Add(330, 23)
    End Sub


End Class

