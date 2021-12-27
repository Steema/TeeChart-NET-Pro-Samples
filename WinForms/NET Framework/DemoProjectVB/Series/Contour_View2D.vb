
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing

Imports System.Windows.Forms




Public Class Contour_View2D
    Inherits Samples.BaseForm
    Private contourSeries1 As Steema.TeeChart.Styles.Contour
    Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
    Private rotate1 As Steema.TeeChart.Tools.Rotate
    Private components As System.ComponentModel.IContainer = Nothing
    
    
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        
        Me.rotate1.Active = False
        Me.contourSeries1.FillSampleValues(20)
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
        Me.checkBox1 = New System.Windows.Forms.CheckBox
        Me.rotate1 = New Steema.TeeChart.Tools.Rotate
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(466, 63)
        Me.textBox1.Text = "Contour series can also be displayed in 2D. The ""Z"" values are used to set the ""Y" + """ axis." + vbCr + vbLf + vbCr + vbLf + "Example: tChart1.Aspect.View3D = false"
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.checkBox1)
        Me.panel1.Location = New System.Drawing.Point(0, 63)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(466, 34)
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
        Me.tChart1.Location = New System.Drawing.Point(0, 97)
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Brush
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.tChart1.Series.Add(Me.contourSeries1)
        Me.tChart1.Size = New System.Drawing.Size(466, 189)
        Me.tChart1.Tools.Add(Me.rotate1)
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
        ' checkBox1
        ' 
        Me.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox1.Location = New System.Drawing.Point(24, 8)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(87, 21)
        Me.checkBox1.TabIndex = 0
        Me.checkBox1.Text = "&View 3D ?"
        ' 
        ' Contour_View2D
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(466, 286)
        Me.Name = "Contour_View2D"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub 'InitializeComponent 
#End Region


    Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox1.CheckedChanged
        Me.tChart1.Aspect.View3D = Me.checkBox1.Checked
        Me.rotate1.Active = Me.tChart1.Aspect.View3D
    End Sub 'checkBox1_CheckedChanged
End Class 'Contour_View2D
