
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms



Public Class Legend_CustomPos
    Inherits Samples.BaseForm
    Private pieSeries1 As Steema.TeeChart.Styles.Pie
    Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
    Private WithEvents trackBar1 As System.Windows.Forms.TrackBar
    Private WithEvents trackBar2 As System.Windows.Forms.TrackBar
    Private label1 As System.Windows.Forms.Label
    Private label2 As System.Windows.Forms.Label
    Private components As System.ComponentModel.IContainer = Nothing
    Private setting As Boolean = False
    
    
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        
        pieSeries1.FillSampleValues(5)
        tChart1.Legend.CustomPosition = True
        tChart1.Legend.Left = 0
        tChart1.Legend.Top = 0
        
        trackBar1.Value = tChart1.Legend.Left
        trackBar2.Value = tChart1.Legend.Top
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
        Me.pieSeries1 = New Steema.TeeChart.Styles.Pie
        Me.checkBox1 = New System.Windows.Forms.CheckBox
        Me.trackBar1 = New System.Windows.Forms.TrackBar
        Me.trackBar2 = New System.Windows.Forms.TrackBar
        Me.label1 = New System.Windows.Forms.Label
        Me.label2 = New System.Windows.Forms.Label
        Me.panel1.SuspendLayout()
        CType(Me.trackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trackBar2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(511, 64)
        Me.textBox1.TabIndex = 0
        Me.textBox1.Text = "The Chart Legend can be custom-positioned." + vbCr + vbLf + vbCr + vbLf + "Example: tChart1.Legend.CustomPosit" + "ion = true " + vbCr + vbLf + "              tChart1.Legend.Left = 123 "
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.label2)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Controls.Add(Me.trackBar2)
        Me.panel1.Controls.Add(Me.trackBar1)
        Me.panel1.Controls.Add(Me.checkBox1)
        Me.panel1.Location = New System.Drawing.Point(0, 64)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(511, 40)
        Me.panel1.TabIndex = 1
        ' 
        ' tChart1
        ' 
        ' 
        ' tChart1.Aspect
        ' 
        Me.tChart1.Aspect.Elevation = 315
        Me.tChart1.Aspect.Orthogonal = False
        Me.tChart1.Aspect.Perspective = 0
        Me.tChart1.Aspect.Rotation = 360
        Me.tChart1.Aspect.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality
        Me.tChart1.Aspect.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        ' 
        ' tChart1.Header
        ' 
        Me.tChart1.Header.Lines = New String() {"tChart1"}
        ' 
        ' tChart1.Legend
        ' 
        Me.tChart1.Legend.Alignment = Steema.TeeChart.LegendAlignments.Left
        ' 
        ' tChart1.Legend.Pen
        ' 
        Me.tChart1.Legend.Pen.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(192, System.Byte), CType(192, System.Byte), CType(192, System.Byte))
        Me.tChart1.Location = New System.Drawing.Point(0, 104)
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Brush
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.tChart1.Series.Add(Me.pieSeries1)
        Me.tChart1.Size = New System.Drawing.Size(511, 208)
        Me.tChart1.TabIndex = 2
        ' 
        ' pieSeries1
        ' 
        ' 
        ' pieSeries1.Brush
        ' 
        Me.pieSeries1.Brush.Color = System.Drawing.Color.Red
        Me.pieSeries1.LabelMember = "Labels"
        ' 
        ' pieSeries1.Marks
        ' 
        ' 
        ' pieSeries1.Marks.Pen
        ' 
        Me.pieSeries1.Marks.Pen.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(192, System.Byte), CType(192, System.Byte), CType(192, System.Byte))
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
        Me.pieSeries1.Pen.Visible = False
        ' 
        ' pieSeries1.Shadow
        ' 
        Me.pieSeries1.Shadow.Height = 20
        Me.pieSeries1.Shadow.Width = 20
        Me.pieSeries1.Title = "pieSeries1"
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
        ' checkBox1
        ' 
        Me.checkBox1.Checked = True
        Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox1.Location = New System.Drawing.Point(15, 8)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(109, 23)
        Me.checkBox1.TabIndex = 0
        Me.checkBox1.Text = "&Custom position"
        ' 
        ' trackBar1
        ' 
        Me.trackBar1.AutoSize = False
        Me.trackBar1.Location = New System.Drawing.Point(183, 11)
        Me.trackBar1.Maximum = 300
        Me.trackBar1.Name = "trackBar1"
        Me.trackBar1.Size = New System.Drawing.Size(102, 17)
        Me.trackBar1.TabIndex = 2
        Me.trackBar1.TickFrequency = 20
        ' 
        ' trackBar2
        ' 
        Me.trackBar2.AutoSize = False
        Me.trackBar2.Location = New System.Drawing.Point(336, 11)
        Me.trackBar2.Maximum = 300
        Me.trackBar2.Name = "trackBar2"
        Me.trackBar2.Size = New System.Drawing.Size(102, 17)
        Me.trackBar2.TabIndex = 4
        Me.trackBar2.TickFrequency = 20
        ' 
        ' label1
        ' 
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(146, 11)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(26, 16)
        Me.label1.TabIndex = 1
        Me.label1.Text = "&Left:"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        ' 
        ' label2
        ' 
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(292, 11)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(27, 16)
        Me.label2.TabIndex = 3
        Me.label2.Text = "&Top:"
        Me.label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        ' 
        ' Legend_CustomPos
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(511, 312)
        Me.Name = "Legend_CustomPos"
        Me.panel1.ResumeLayout(False)
        CType(Me.trackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trackBar2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub 'InitializeComponent 
#End Region


    Private Sub trackBar1_Scroll(ByVal sender As Object, ByVal e As System.EventArgs) Handles trackBar1.Scroll
        UpdateCustomPosition()
        tChart1.Legend.Left = Fix(trackBar1.Value)
    End Sub 'trackBar1_Scroll


    Private Sub trackBar2_Scroll(ByVal sender As Object, ByVal e As System.EventArgs) Handles trackBar2.Scroll
        UpdateCustomPosition()
        tChart1.Legend.Top = Fix(trackBar2.Value)
    End Sub 'trackBar2_Scroll


    Private Sub UpdateCustomPosition()
        tChart1.Legend.CustomPosition = True
        setting = True
        checkBox1.Checked = True
        setting = False
    End Sub 'UpdateCustomPosition


    Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox1.CheckedChanged
        If Not setting Then
            tChart1.Legend.CustomPosition = checkBox1.Checked

            ' Force chart repaint and update trackbar positions
            tChart1.Refresh()
            trackBar1.Value = tChart1.Legend.Left
            trackBar2.Value = tChart1.Legend.Top
        End If
    End Sub 'checkBox1_CheckedChanged
End Class 'Legend_CustomPos