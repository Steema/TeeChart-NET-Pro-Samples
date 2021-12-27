
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing

Imports System.Windows.Forms




Public Class Contour_Palette
    Inherits Samples.BaseForm
    Private contourSeries1 As Steema.TeeChart.Styles.Contour
    Private label1 As System.Windows.Forms.Label
    Private WithEvents comboBox1 As System.Windows.Forms.ComboBox
    Private components As System.ComponentModel.IContainer = Nothing
    
    
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        
        Me.contourSeries1.FillSampleValues(25)
        Me.contourSeries1.ColorEach = False
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

#Region "Designer generated code"

    '/ <summary>
    '/ Required method for Designer support - do not modify
    '/ the contents of this method with the code editor.
    '/ </summary>
    Private Sub InitializeComponent()
        Me.contourSeries1 = New Steema.TeeChart.Styles.Contour
        Me.label1 = New System.Windows.Forms.Label
        Me.comboBox1 = New System.Windows.Forms.ComboBox
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(466, 40)
        Me.textBox1.Text = "Contour Series uses ColorRange and Palette properties like the Surface series does."
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.comboBox1)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Location = New System.Drawing.Point(0, 40)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(466, 33)
        ' 
        ' tChart1
        ' 
        ' 
        ' tChart1.Aspect
        ' 
        Me.tChart1.Aspect.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality
        Me.tChart1.Aspect.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        Me.tChart1.Aspect.View3D = False
        ' 
        ' tChart1.Header
        ' 
        Me.tChart1.Header.Lines = New String() {"tChart1"}
        Me.tChart1.Header.Visible = False
        Me.tChart1.Location = New System.Drawing.Point(0, 73)
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Brush
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.tChart1.Series.Add(Me.contourSeries1)
        Me.tChart1.Size = New System.Drawing.Size(466, 213)
        ' 
        ' contourSeries1
        ' 
        ' 
        ' contourSeries1.Brush
        ' 
        Me.contourSeries1.Brush.Color = System.Drawing.Color.Red
        Me.contourSeries1.ColorEach = True
        ' 
        ' contourSeries1.Marks
        ' 
        ' 
        ' contourSeries1.Marks.Symbol
        ' 
        ' 
        ' contourSeries1.Marks.Symbol.Shadow
        ' 
        Me.contourSeries1.Marks.Symbol.Shadow.Height = 1
        Me.contourSeries1.Marks.Symbol.Shadow.Visible = True
        Me.contourSeries1.Marks.Symbol.Shadow.Width = 1
        Me.contourSeries1.NumXValues = 25
        Me.contourSeries1.NumZValues = 25
        Me.contourSeries1.PaletteMin = 0
        Me.contourSeries1.PaletteStep = 0
        Me.contourSeries1.Title = "contourSeries1"
        ' 
        ' contourSeries1.XValues
        ' 
        Me.contourSeries1.XValues.DataMember = "X"
        Me.contourSeries1.YPosition = 0.20290816683830415
        ' 
        ' contourSeries1.YValues
        ' 
        Me.contourSeries1.YValues.DataMember = "Y"
        ' 
        ' contourSeries1.ZValues
        ' 
        Me.contourSeries1.ZValues.DataMember = "Z"
        ' 
        ' label1
        ' 
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(13, 9)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(40, 16)
        Me.label1.TabIndex = 0
        Me.label1.Text = "&Colors:"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        ' 
        ' comboBox1
        ' 
        Me.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboBox1.Items.AddRange(New Object() {"Single color", "Gradient 2 colors", "Gradient 3 colors", "Palette pale", "Palette strong"})
        Me.comboBox1.Location = New System.Drawing.Point(60, 7)
        Me.comboBox1.Name = "comboBox1"
        Me.comboBox1.Size = New System.Drawing.Size(101, 21)
        Me.comboBox1.TabIndex = 1
        ' 
        ' Contour_Palette
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(466, 286)
        Me.Name = "Contour_Palette"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub 'InitializeComponent 
#End Region


    Private Sub Contour_Palette_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.comboBox1.SelectedIndex = 2
    End Sub 'Contour_Palette_Load


    Private Sub comboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboBox1.SelectedIndexChanged
        Select Case Me.comboBox1.SelectedIndex
            Case 0 ' single
                Me.contourSeries1.UseColorRange = False
                Me.contourSeries1.UsePalette = False
                Me.contourSeries1.Color = Color.Yellow
                Exit Select
            Case 1 ' grad two colors
                Me.contourSeries1.UseColorRange = True
                Me.contourSeries1.UsePalette = False
                Me.contourSeries1.StartColor = Color.Blue
                Me.contourSeries1.EndColor = Color.Red
                Me.contourSeries1.MidColor = Color.Empty
                Exit Select
            Case 2 ' grad three colors
                Me.contourSeries1.UseColorRange = True
                Me.contourSeries1.UsePalette = False
                Me.contourSeries1.StartColor = Color.Blue
                Me.contourSeries1.EndColor = Color.Red
                Me.contourSeries1.MidColor = Color.Yellow
                Exit Select
            Case 3 ' palette pale style
                Me.contourSeries1.UseColorRange = False
                Me.contourSeries1.UsePalette = True
                Me.contourSeries1.PaletteStyle = Steema.TeeChart.Styles.PaletteStyles.Pale
                Exit Select
            Case 4 ' palette strong style
                Me.contourSeries1.UseColorRange = False
                Me.contourSeries1.UsePalette = True
                Me.contourSeries1.PaletteStyle = Steema.TeeChart.Styles.PaletteStyles.Strong
                Exit Select
        End Select
    End Sub 'comboBox1_SelectedIndexChanged
End Class 'Contour_Palette
