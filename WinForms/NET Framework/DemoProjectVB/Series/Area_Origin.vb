
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing

Imports System.Windows.Forms




Public Class Area_Origin
    Inherits Samples.BaseForm
    Private areaSeries1 As Steema.TeeChart.Styles.Area
    Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
    Private WithEvents numericUpDown1 As System.Windows.Forms.NumericUpDown
    Private label1 As System.Windows.Forms.Label
    Private components As System.ComponentModel.IContainer = Nothing
    
    
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.areaSeries1.FillSampleValues(20)
        Dim origin As Integer = CType(Math.Round((0.5 _
                        * (Me.areaSeries1.YValues.Maximum + Me.areaSeries1.YValues.Minimum))), Integer)
        Me.numericUpDown1.Value = origin
        Me.areaSeries1.Origin = origin
        Me.areaSeries1.UseOrigin = True
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
        Me.areaSeries1 = New Steema.TeeChart.Styles.Area
        Me.checkBox1 = New System.Windows.Forms.CheckBox
        Me.numericUpDown1 = New System.Windows.Forms.NumericUpDown
        Me.label1 = New System.Windows.Forms.Label
        Me.panel1.SuspendLayout()
        CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(466, 64)
        Me.textBox1.TabIndex = 0
        Me.textBox1.Text = "Area series can specify the ""Y Origin"". This is the Y value that defines the bott" + "om position for area points." + vbCr + vbLf + vbCr + vbLf + "Example: areaSeries1.UseOrigin=true   Series1.O" + "rigin = 200 "
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Controls.Add(Me.numericUpDown1)
        Me.panel1.Controls.Add(Me.checkBox1)
        Me.panel1.Location = New System.Drawing.Point(0, 64)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(466, 33)
        Me.panel1.TabIndex = 1
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
        ' tChart1.Axes
        ' 
        ' 
        ' tChart1.Axes.Bottom
        ' 
        ' 
        ' tChart1.Axes.Bottom.AxisPen
        ' 
        Me.tChart1.Axes.Bottom.AxisPen.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(64, System.Byte), CType(64, System.Byte), CType(64, System.Byte))
        ' 
        ' tChart1.Axes.Left
        ' 
        ' 
        ' tChart1.Axes.Left.AxisPen
        ' 
        Me.tChart1.Axes.Left.AxisPen.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(64, System.Byte), CType(64, System.Byte), CType(64, System.Byte))
        ' 
        ' tChart1.Header
        ' 
        Me.tChart1.Header.Lines = New String(-1) {}
        ' 
        ' tChart1.Legend
        ' 
        Me.tChart1.Legend.Visible = False
        Me.tChart1.Location = New System.Drawing.Point(0, 97)
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Brush
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        ' 
        ' tChart1.Panel.Gradient
        ' 
        Me.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(192, System.Byte), CType(192, System.Byte), CType(255, System.Byte))
        Me.tChart1.Panel.Brush.Gradient.Visible = True
        ' 
        ' tChart1.Panel.Gradient
        ' 
        Me.tChart1.Panel.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(192, System.Byte), CType(192, System.Byte), CType(255, System.Byte))
        Me.tChart1.Panel.Gradient.Visible = True
        Me.tChart1.Series.Add(Me.areaSeries1)
        Me.tChart1.Size = New System.Drawing.Size(466, 189)
        Me.tChart1.TabIndex = 2
        ' 
        ' tChart1.Walls
        ' 
        Me.tChart1.Walls.Visible = False
        ' 
        ' areaSeries1
        ' 
        ' 
        ' areaSeries1.AreaBrush
        ' 
        Me.areaSeries1.AreaBrush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        ' 
        ' areaSeries1.Gradient
        ' 
        Me.areaSeries1.AreaBrush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(128, System.Byte))
        Me.areaSeries1.AreaBrush.Gradient.Visible = True
        ' 
        ' areaSeries1.AreaLines
        ' 
        Me.areaSeries1.AreaLines.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(192, System.Byte), CType(192, System.Byte), CType(0, System.Byte))
        ' 
        ' areaSeries1.Brush
        ' 
        Me.areaSeries1.Brush.Color = System.Drawing.Color.Red
        ' 
        ' areaSeries1.Gradient
        ' 
        Me.areaSeries1.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(128, System.Byte))
        Me.areaSeries1.Gradient.Visible = True
        ' 
        ' areaSeries1.LinePen
        ' 
        Me.areaSeries1.LinePen.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(128, System.Byte), CType(128, System.Byte), CType(0, System.Byte))
        ' 
        ' areaSeries1.Marks
        ' 
        ' 
        ' areaSeries1.Marks.Symbol
        ' 
        ' 
        ' areaSeries1.Marks.Symbol.Shadow
        ' 
        Me.areaSeries1.Marks.Symbol.Shadow.Height = 1
        Me.areaSeries1.Marks.Symbol.Shadow.Visible = True
        Me.areaSeries1.Marks.Symbol.Shadow.Width = 1
        ' 
        ' areaSeries1.Pointer
        ' 
        ' 
        ' areaSeries1.Pointer.Brush
        ' 
        Me.areaSeries1.Pointer.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(0, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        Me.areaSeries1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.areaSeries1.Title = "areaSeries1"
        ' 
        ' areaSeries1.XValues
        ' 
        Me.areaSeries1.XValues.DataMember = "X"
        Me.areaSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' areaSeries1.YValues
        ' 
        Me.areaSeries1.YValues.DataMember = "Y"
        ' 
        ' checkBox1
        ' 
        Me.checkBox1.Checked = True
        Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox1.Location = New System.Drawing.Point(13, 8)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(87, 21)
        Me.checkBox1.TabIndex = 0
        Me.checkBox1.Text = "&Use Origin"
        ' 
        ' numericUpDown1
        ' 
        Me.numericUpDown1.Location = New System.Drawing.Point(153, 8)
        Me.numericUpDown1.Maximum = New System.Decimal(New Integer() {30000, 0, 0, 0})
        Me.numericUpDown1.Minimum = New System.Decimal(New Integer() {30000, 0, 0, -2147483648})
        Me.numericUpDown1.Name = "numericUpDown1"
        Me.numericUpDown1.Size = New System.Drawing.Size(54, 20)
        Me.numericUpDown1.TabIndex = 2
        Me.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        ' 
        ' label1
        ' 
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(111, 10)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(38, 16)
        Me.label1.TabIndex = 1
        Me.label1.Text = "&Origin:"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        ' 
        ' Area_Origin
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(466, 286)
        Me.Name = "Area_Origin"
        Me.panel1.ResumeLayout(False)
        CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub 'InitializeComponent 
#End Region


    Private Sub numericUpDown1_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles numericUpDown1.ValueChanged
        Me.areaSeries1.Origin = Fix(Me.numericUpDown1.Value)
    End Sub 'numericUpDown1_ValueChanged


    Private Sub numericUpDown1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles numericUpDown1.TextChanged
        Me.areaSeries1.Origin = Fix(Me.numericUpDown1.Value)
    End Sub 'numericUpDown1_TextChanged


    Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox1.CheckedChanged
        Me.areaSeries1.UseOrigin = Me.checkBox1.Checked
    End Sub 'checkBox1_CheckedChanged
End Class 'Area_Origin
