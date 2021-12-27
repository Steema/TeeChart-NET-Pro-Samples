
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing

Imports System.Windows.Forms




Public Class Pie_Semi
    Inherits Samples.BaseForm
    Private pieSeries1 As Steema.TeeChart.Styles.Pie
    Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
    Private WithEvents checkBox2 As System.Windows.Forms.CheckBox
    Private components As System.ComponentModel.IContainer = Nothing
    
    
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        
        Me.pieSeries1.FillSampleValues(5)
        Me.pieSeries1.AngleSize = 180
        Me.pieSeries1.RotationAngle = 90
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
        Me.checkBox2 = New System.Windows.Forms.CheckBox
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(466, 64)
        Me.textBox1.Text = "The AngleSize property, used with RotationAngle, can display horizontal or vertic" + "al partial pie series." + vbCr + vbLf + vbCr + vbLf + "Example: pieSeries1.AngleSize = 180    pieSeries1.Rot" + "ationAngle = 90"
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.checkBox2)
        Me.panel1.Controls.Add(Me.checkBox1)
        Me.panel1.Location = New System.Drawing.Point(0, 64)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(466, 34)
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
        Me.tChart1.Aspect.View3D = False
        ' 
        ' tChart1.Header
        ' 
        Me.tChart1.Header.Lines = New String() {"tChart1"}
        Me.tChart1.Location = New System.Drawing.Point(0, 98)
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Brush
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.tChart1.Series.Add(Me.pieSeries1)
        Me.tChart1.Size = New System.Drawing.Size(466, 188)
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
        Me.pieSeries1.Pen.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(128, System.Byte), CType(128, System.Byte), CType(128, System.Byte))
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
        Me.checkBox1.Location = New System.Drawing.Point(20, 7)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(87, 21)
        Me.checkBox1.TabIndex = 0
        Me.checkBox1.Text = "&Semi"
        ' 
        ' checkBox2
        ' 
        Me.checkBox2.Checked = True
        Me.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox2.Location = New System.Drawing.Point(120, 7)
        Me.checkBox2.Name = "checkBox2"
        Me.checkBox2.Size = New System.Drawing.Size(87, 21)
        Me.checkBox2.TabIndex = 1
        Me.checkBox2.Text = "&Vertical"
        ' 
        ' Pie_Semi
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(466, 286)
        Me.Name = "Pie_Semi"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub 'InitializeComponent 
#End Region


    Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox1.CheckedChanged
        If Me.checkBox1.Checked Then
            Me.pieSeries1.AngleSize = 180
        Else
            Me.pieSeries1.AngleSize = 360
        End If
    End Sub 'checkBox1_CheckedChanged

    Private Sub checkBox2_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox2.CheckedChanged
        If Me.checkBox2.Checked Then
            Me.pieSeries1.RotationAngle = 90
        Else
            Me.pieSeries1.RotationAngle = 0
        End If
    End Sub 'checkBox2_CheckedChanged
End Class 'Pie_Semi
