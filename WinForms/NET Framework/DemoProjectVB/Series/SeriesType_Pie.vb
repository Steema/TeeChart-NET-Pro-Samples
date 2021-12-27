
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing

Imports System.Windows.Forms




Public Class SeriesType_Pie
    Inherits Samples.BaseForm
    Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
    Private WithEvents checkBox2 As System.Windows.Forms.CheckBox
    Private WithEvents checkBox3 As System.Windows.Forms.CheckBox
    Private WithEvents checkBox4 As System.Windows.Forms.CheckBox
    Private WithEvents checkBox5 As System.Windows.Forms.CheckBox
    Private WithEvents button1 As System.Windows.Forms.Button
    Private pie1 As Steema.TeeChart.Styles.Pie
    Private components As System.ComponentModel.IContainer = Nothing
    
    
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        
        pie1.Shadow.Width = 40
        pie1.Shadow.Height = 40
        pie1.FillSampleValues(6)
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
        Me.checkBox1 = New System.Windows.Forms.CheckBox
        Me.checkBox2 = New System.Windows.Forms.CheckBox
        Me.checkBox3 = New System.Windows.Forms.CheckBox
        Me.checkBox4 = New System.Windows.Forms.CheckBox
        Me.checkBox5 = New System.Windows.Forms.CheckBox
        Me.button1 = New System.Windows.Forms.Button
        Me.pie1 = New Steema.TeeChart.Styles.Pie
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(466, 56)
        Me.textBox1.Text = "Pie series draw values as portions (slices) of a full solid circle." + vbCr + vbLf + "Slices can b" + "e ""exploded"" and grouped if they are very small." + vbCr + vbLf + "Other options include formatti" + "ng, shadow, marks and semi-pie styles."
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.checkBox5)
        Me.panel1.Controls.Add(Me.checkBox4)
        Me.panel1.Controls.Add(Me.checkBox3)
        Me.panel1.Controls.Add(Me.checkBox2)
        Me.panel1.Controls.Add(Me.checkBox1)
        Me.panel1.Location = New System.Drawing.Point(0, 56)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(466, 40)
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
        ' 
        ' tChart1.Legend.Brush
        ' 
        Me.tChart1.Legend.Brush.Color = System.Drawing.Color.FromArgb(CType(127, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        ' 
        ' tChart1.Legend.Gradient
        ' 
        Me.tChart1.Legend.Brush.Gradient.Transparency = 50
        ' 
        ' tChart1.Legend.Gradient
        ' 
        Me.tChart1.Legend.Gradient.Transparency = 50
        ' 
        ' tChart1.Legend.Shadow
        ' 
        ' 
        ' tChart1.Legend.Shadow.Brush
        ' 
        Me.tChart1.Legend.Shadow.Brush.Color = System.Drawing.Color.FromArgb(CType(127, System.Byte), CType(0, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        Me.tChart1.Location = New System.Drawing.Point(0, 96)
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Brush
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.tChart1.Series.Add(Me.pie1)
        Me.tChart1.Size = New System.Drawing.Size(466, 190)
        ' 
        ' checkBox1
        ' 
        Me.checkBox1.Checked = True
        Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox1.Location = New System.Drawing.Point(13, 8)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(40, 21)
        Me.checkBox1.TabIndex = 0
        Me.checkBox1.Text = "&3D"
        ' 
        ' checkBox2
        ' 
        Me.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox2.Location = New System.Drawing.Point(53, 8)
        Me.checkBox2.Name = "checkBox2"
        Me.checkBox2.Size = New System.Drawing.Size(75, 21)
        Me.checkBox2.TabIndex = 1
        Me.checkBox2.Text = "&Exploded"
        ' 
        ' checkBox3
        ' 
        Me.checkBox3.Checked = True
        Me.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox3.Location = New System.Drawing.Point(127, 8)
        Me.checkBox3.Name = "checkBox3"
        Me.checkBox3.Size = New System.Drawing.Size(53, 21)
        Me.checkBox3.TabIndex = 2
        Me.checkBox3.Text = "&Marks"
        ' 
        ' checkBox4
        ' 
        Me.checkBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox4.Location = New System.Drawing.Point(187, 8)
        Me.checkBox4.Name = "checkBox4"
        Me.checkBox4.Size = New System.Drawing.Size(61, 21)
        Me.checkBox4.TabIndex = 3
        Me.checkBox4.Text = "&Shadow"
        ' 
        ' checkBox5
        ' 
        Me.checkBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox5.Location = New System.Drawing.Point(253, 8)
        Me.checkBox5.Name = "checkBox5"
        Me.checkBox5.Size = New System.Drawing.Size(54, 21)
        Me.checkBox5.TabIndex = 4
        Me.checkBox5.Text = "&Partial"
        ' 
        ' button1
        ' 
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.Location = New System.Drawing.Point(392, 24)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(72, 24)
        Me.button1.TabIndex = 6
        Me.button1.Text = "&Edit"
        ' 
        ' pie1
        ' 
        ' 
        ' pie1.Brush
        ' 
        Me.pie1.Brush.Color = System.Drawing.Color.Red
        Me.pie1.LabelMember = "Labels"
        ' 
        ' pie1.Marks
        ' 
        ' 
        ' pie1.Marks.Symbol
        ' 
        ' 
        ' pie1.Marks.Symbol.Shadow
        ' 
        Me.pie1.Marks.Symbol.Shadow.Height = 1
        Me.pie1.Marks.Symbol.Shadow.Visible = True
        Me.pie1.Marks.Symbol.Shadow.Width = 1
        ' 
        ' pie1.Pen
        ' 
        Me.pie1.Pen.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(128, System.Byte), CType(128, System.Byte), CType(128, System.Byte))
        ' 
        ' pie1.Shadow
        ' 
        Me.pie1.Shadow.Height = 20
        Me.pie1.Shadow.Width = 20
        Me.pie1.Title = "pie1"
        ' 
        ' pie1.XValues
        ' 
        Me.pie1.XValues.DataMember = "Angle"
        Me.pie1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' pie1.YValues
        ' 
        Me.pie1.YValues.DataMember = "Pie"
        ' 
        ' SeriesType_Pie
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(466, 286)
        Me.Name = "SeriesType_Pie"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub 'InitializeComponent 
#End Region


    Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox1.CheckedChanged
        tChart1.Aspect.View3D = checkBox1.Checked
    End Sub 'checkBox1_CheckedChanged


    Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
        TeeChart.Editors.SeriesEditor.ShowEditor(Me.pie1)
    End Sub 'button1_Click


    Private Sub checkBox2_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox2.CheckedChanged
        If checkBox2.Checked Then
            pie1.ExplodeBiggest = 30
        Else
            pie1.ExplodeBiggest = 0
        End If
    End Sub 'checkBox2_CheckedChanged


    Private Sub checkBox3_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox3.CheckedChanged
        pie1.Marks.Visible = checkBox3.Checked
    End Sub 'checkBox3_CheckedChanged


    Private Sub checkBox4_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox4.CheckedChanged
        pie1.Shadow.Visible = checkBox4.Checked
    End Sub 'checkBox4_CheckedChanged


    Private Sub checkBox5_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox5.CheckedChanged
        If checkBox5.Checked Then
            pie1.AngleSize = 180
            checkBox4.Checked = False
            Me.checkBox4_CheckedChanged(checkBox4, New System.EventArgs)
        Else
            pie1.AngleSize = 360
        End If
    End Sub 'checkBox5_CheckedChanged
End Class 'SeriesType_Pie
