
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing

Imports System.Windows.Forms




Public Class Surface_Irregular
    Inherits Samples.BaseForm
    Private surfaceSeries1 As Steema.TeeChart.Styles.Surface
    Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
    Private WithEvents checkBox2 As System.Windows.Forms.CheckBox
    Private gridBand1 As Steema.TeeChart.Tools.GridBand
    Private components As System.ComponentModel.IContainer = Nothing
    
    
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ' Arrays of X and Z values with sample points...
        'The values have floating point decimals and define
        'an irregular grid
        Dim xval() As Double = New Double() {0.1, 0.2, 0.3, 0.5, 0.8, 1.1, 1.5, 2, 2.2, 3}
        Dim zval() As Double = New Double() {0.5, 0.6, 0.7, 0.75, 0.8, 1.1, 1.5, 2, 2.2, 5.6}
        surfaceSeries1.IrregularGrid = True ' <---------- VERY IMPORTANT !!!
        surfaceSeries1.GetVertAxis.SetMinMax(-2, 2)' axis scale for Y values
        ' Now add all "Y" points...
        ' An irregular grid of 10 x 10 cells
        surfaceSeries1.NumXValues = 10
        surfaceSeries1.NumZValues = 10
        Dim y As Double
        Dim x As Integer = 0
        Do While (x < 9) '= 10 rowa
            Dim z As Integer = 0
            Do While (z < 9) '=10 columns
                y = (Math.Sin((z * (Math.PI / 10))) * Math.Cos((x * (Math.PI / 5))))' example Y value
                surfaceSeries1.Add(xval(x), y, zval(z))
                z = (z + 1)
            Loop
            x = (x + 1)
        Loop
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
        Me.surfaceSeries1 = New Steema.TeeChart.Styles.Surface
        Me.checkBox1 = New System.Windows.Forms.CheckBox
        Me.checkBox2 = New System.Windows.Forms.CheckBox
        Me.gridBand1 = New Steema.TeeChart.Tools.GridBand
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(466, 63)
        Me.textBox1.Text = "Surface series accept X,Y and Z values as ""double"" floating point numbers." + vbCr + vbLf + "The I" + "rregularGrid property controls if X and Z values should be equidistant or not." + vbCr + vbLf + vbCr + vbLf + "Example: surfaceSeries11.Add( -123.456, 321.45, 456.789 )"
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.checkBox2)
        Me.panel1.Controls.Add(Me.checkBox1)
        Me.panel1.Location = New System.Drawing.Point(0, 63)
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
        ' 
        ' tChart1.Header
        ' 
        Me.tChart1.Header.Lines = New String() {"Surface Series : ", "irregular grid example"}
        ' 
        ' tChart1.Legend
        ' 
        Me.tChart1.Legend.MaxNumRows = 8
        Me.tChart1.Location = New System.Drawing.Point(0, 96)
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Brush
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.tChart1.Series.Add(Me.surfaceSeries1)
        Me.tChart1.Size = New System.Drawing.Size(466, 190)
        Me.tChart1.Tools.Add(Me.gridBand1)
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
        Me.tChart1.Walls.Bottom.Size = 5
        ' 
        ' tChart1.Walls.Left
        ' 
        ' 
        ' tChart1.Walls.Left.Pen
        ' 
        Me.tChart1.Walls.Left.Pen.Visible = False
        Me.tChart1.Walls.Left.Size = 5
        ' 
        ' surfaceSeries1
        ' 
        ' 
        ' surfaceSeries1.Brush
        ' 
        Me.surfaceSeries1.Brush.Color = System.Drawing.Color.Red
        ' 
        ' surfaceSeries1.Marks
        ' 
        ' 
        ' surfaceSeries1.Marks.Symbol
        ' 
        ' 
        ' surfaceSeries1.Marks.Symbol.Shadow
        ' 
        Me.surfaceSeries1.Marks.Symbol.Shadow.Height = 1
        Me.surfaceSeries1.Marks.Symbol.Shadow.Visible = True
        Me.surfaceSeries1.Marks.Symbol.Shadow.Width = 1
        Me.surfaceSeries1.NumXValues = 25
        Me.surfaceSeries1.NumZValues = 25
        Me.surfaceSeries1.PaletteMin = 0
        Me.surfaceSeries1.PaletteStep = 0
        Me.surfaceSeries1.StartColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(0, System.Byte), CType(128, System.Byte), CType(0, System.Byte))
        Me.surfaceSeries1.Title = "surfaceSeries1"
        ' 
        ' surfaceSeries1.XValues
        ' 
        Me.surfaceSeries1.XValues.DataMember = "X"
        ' 
        ' surfaceSeries1.YValues
        ' 
        Me.surfaceSeries1.YValues.DataMember = "Y"
        ' 
        ' surfaceSeries1.ZValues
        ' 
        Me.surfaceSeries1.ZValues.DataMember = "Z"
        ' 
        ' checkBox1
        ' 
        Me.checkBox1.Checked = True
        Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox1.Location = New System.Drawing.Point(13, 7)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(83, 21)
        Me.checkBox1.TabIndex = 0
        Me.checkBox1.Text = "&Irregular"
        ' 
        ' checkBox2
        ' 
        Me.checkBox2.Checked = True
        Me.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox2.Location = New System.Drawing.Point(93, 7)
        Me.checkBox2.Name = "checkBox2"
        Me.checkBox2.Size = New System.Drawing.Size(115, 21)
        Me.checkBox2.TabIndex = 1
        Me.checkBox2.Text = "&3D"
        ' 
        ' gridBand1
        ' 
        Me.gridBand1.Axis = Me.tChart1.Axes.Left
        ' 
        ' gridBand1.Band1
        ' 
        Me.gridBand1.Band1.Color = System.Drawing.Color.FromArgb(CType(76, System.Byte), CType(128, System.Byte), CType(128, System.Byte), CType(0, System.Byte))
        ' 
        ' gridBand1.Band2
        ' 
        Me.gridBand1.Band2.Color = System.Drawing.Color.FromArgb(CType(76, System.Byte), CType(192, System.Byte), CType(192, System.Byte), CType(192, System.Byte))
        ' 
        ' Surface_Irregular
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(466, 286)
        Me.Name = "Surface_Irregular"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub 'InitializeComponent 
#End Region


    Private Sub checkBox2_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox2.CheckedChanged
        tChart1.Aspect.View3D = checkBox2.Checked
    End Sub 'checkBox2_CheckedChanged


    Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox1.CheckedChanged
        surfaceSeries1.IrregularGrid = checkBox1.Checked
    End Sub 'checkBox1_CheckedChanged
End Class 'Surface_Irregular