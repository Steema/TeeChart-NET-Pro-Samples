
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing

Imports System.Windows.Forms




Public Class Zoom_MinPix
    Inherits Samples.BaseForm
    Private horizLineSeries1 As Steema.TeeChart.Styles.HorizLine
    Private label1 As System.Windows.Forms.Label
    Private label2 As System.Windows.Forms.Label
    Private WithEvents numericUpDown1 As System.Windows.Forms.NumericUpDown
    Private label3 As System.Windows.Forms.Label
    Private WithEvents comboBox1 As System.Windows.Forms.ComboBox
    Private components As System.ComponentModel.IContainer = Nothing
    
    
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.horizLineSeries1.FillSampleValues(80)
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
        Me.horizLineSeries1 = New Steema.TeeChart.Styles.HorizLine
        Me.label1 = New System.Windows.Forms.Label
        Me.label2 = New System.Windows.Forms.Label
        Me.numericUpDown1 = New System.Windows.Forms.NumericUpDown
        Me.label3 = New System.Windows.Forms.Label
        Me.comboBox1 = New System.Windows.Forms.ComboBox
        Me.panel1.SuspendLayout()
        CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(466, 63)
        Me.textBox1.TabIndex = 0
        Me.textBox1.Text = "By default, a Chart is zoomed when the user drags a rectangle of minimum 15  pixe" + "ls size." + vbCr + vbLf + "Now the number of minimum pixels can be customized." + vbCr + vbLf + vbCr + vbLf + "Example: tChart" + "1.Zoom.MinPixels = 16 "
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.comboBox1)
        Me.panel1.Controls.Add(Me.label3)
        Me.panel1.Controls.Add(Me.numericUpDown1)
        Me.panel1.Controls.Add(Me.label2)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Location = New System.Drawing.Point(0, 63)
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
        ' tChart1.Header
        ' 
        Me.tChart1.Header.Lines = New String() {"tChart1"}
        Me.tChart1.Location = New System.Drawing.Point(0, 96)
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Brush
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.tChart1.Series.Add(Me.horizLineSeries1)
        Me.tChart1.Size = New System.Drawing.Size(466, 190)
        Me.tChart1.TabIndex = 2
        ' 
        ' horizLineSeries1
        ' 
        ' 
        ' horizLineSeries1.Brush
        ' 
        Me.horizLineSeries1.Brush.Color = System.Drawing.Color.Red
        ' 
        ' horizLineSeries1.Marks
        ' 
        ' 
        ' horizLineSeries1.Marks.Symbol
        ' 
        ' 
        ' horizLineSeries1.Marks.Symbol.Shadow
        ' 
        Me.horizLineSeries1.Marks.Symbol.Shadow.Height = 1
        Me.horizLineSeries1.Marks.Symbol.Shadow.Visible = True
        Me.horizLineSeries1.Marks.Symbol.Shadow.Width = 1
        ' 
        ' horizLineSeries1.Pointer
        ' 
        ' 
        ' horizLineSeries1.Pointer.Brush
        ' 
        Me.horizLineSeries1.Pointer.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(0, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        Me.horizLineSeries1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.horizLineSeries1.Title = "horizLineSeries1"
        ' 
        ' horizLineSeries1.XValues
        ' 
        Me.horizLineSeries1.XValues.DataMember = "X"
        ' 
        ' horizLineSeries1.YValues
        ' 
        Me.horizLineSeries1.YValues.DataMember = "Y"
        Me.horizLineSeries1.YValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' label1
        ' 
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, System.Byte))
        Me.label1.Location = New System.Drawing.Point(11, 9)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(71, 15)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Drag to zoom"
        Me.label1.UseMnemonic = False
        ' 
        ' label2
        ' 
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(113, 8)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(61, 16)
        Me.label2.TabIndex = 1
        Me.label2.Text = "&Min. pixels:"
        Me.label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        ' 
        ' numericUpDown1
        ' 
        Me.numericUpDown1.Location = New System.Drawing.Point(180, 6)
        Me.numericUpDown1.Name = "numericUpDown1"
        Me.numericUpDown1.Size = New System.Drawing.Size(40, 20)
        Me.numericUpDown1.TabIndex = 2
        Me.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numericUpDown1.Value = New System.Decimal(New Integer() {16, 0, 0, 0})
        ' 
        ' label3
        ' 
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(247, 8)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(76, 16)
        Me.label3.TabIndex = 3
        Me.label3.Text = "Mouse &button:"
        Me.label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        ' 
        ' comboBox1
        ' 
        Me.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboBox1.Items.AddRange(New Object() {"Left", "Right", "Middle"})
        Me.comboBox1.Location = New System.Drawing.Point(324, 6)
        Me.comboBox1.Name = "comboBox1"
        Me.comboBox1.Size = New System.Drawing.Size(100, 21)
        Me.comboBox1.TabIndex = 4
        ' 
        ' Zoom_MinPix
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(466, 286)
        Me.Name = "Zoom_MinPix"
        Me.panel1.ResumeLayout(False)
        CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub 'InitializeComponent 
#End Region


    Private Sub numericUpDown1_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles numericUpDown1.ValueChanged
        Me.tChart1.Zoom.MinPixels = Fix(Me.numericUpDown1.Value)
    End Sub 'numericUpDown1_ValueChanged


    Private Sub numericUpDown1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles numericUpDown1.TextChanged
        Me.tChart1.Zoom.MinPixels = Fix(Me.numericUpDown1.Value)
    End Sub 'numericUpDown1_TextChanged


    Private Sub comboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboBox1.SelectedIndexChanged
        Select Case Me.comboBox1.SelectedIndex
            Case 0
                Me.tChart1.Zoom.MouseButton = System.Windows.Forms.MouseButtons.Left
            Case 1
                Me.tChart1.Zoom.MouseButton = System.Windows.Forms.MouseButtons.Right
            Case 2
                Me.tChart1.Zoom.MouseButton = System.Windows.Forms.MouseButtons.Middle
        End Select
    End Sub 'comboBox1_SelectedIndexChanged


    Private Sub Zoom_MinPix_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.comboBox1.SelectedIndex = 0
    End Sub 'Zoom_MinPix_Load
End Class 'Zoom_MinPix
