
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing

Imports System.Windows.Forms




Public Class Smith_Series
    Inherits Samples.BaseForm
    Private smithSeries1 As Steema.TeeChart.Styles.Smith
    Private WithEvents button1 As System.Windows.Forms.Button
    Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
    Private label1 As System.Windows.Forms.Label
    Private WithEvents textBox2 As System.Windows.Forms.TextBox
    Private components As System.ComponentModel.IContainer = Nothing
    
    
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        
        Me.smithSeries1.FillSampleValues(20)
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
        Me.smithSeries1 = New Steema.TeeChart.Styles.Smith
        Me.button1 = New System.Windows.Forms.Button
        Me.checkBox1 = New System.Windows.Forms.CheckBox
        Me.label1 = New System.Windows.Forms.Label
        Me.textBox2 = New System.Windows.Forms.TextBox
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(499, 64)
        Me.textBox1.Text = "As name suggests SmithSeries draws Smith charts. Each point is defined with Resis" + "tance and Reactance values." + vbCr + vbLf + "Inherits most common properties with Polar and Circ" + "led ancestor series."
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.textBox2)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Controls.Add(Me.checkBox1)
        Me.panel1.Controls.Add(Me.button1)
        Me.panel1.Location = New System.Drawing.Point(0, 64)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(499, 39)
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
        Me.tChart1.Header.Visible = False
        Me.tChart1.Location = New System.Drawing.Point(0, 103)
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
        Me.tChart1.Panel.Brush.Gradient.Direction = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(192, System.Byte))
        Me.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(128, System.Byte))
        Me.tChart1.Panel.Brush.Gradient.UseMiddle = True
        Me.tChart1.Panel.Brush.Gradient.Visible = True
        ' 
        ' tChart1.Panel.Gradient
        ' 
        Me.tChart1.Panel.Gradient.Direction = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.tChart1.Panel.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(192, System.Byte))
        Me.tChart1.Panel.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(128, System.Byte))
        Me.tChart1.Panel.Gradient.UseMiddle = True
        Me.tChart1.Panel.Gradient.Visible = True
        Me.tChart1.Series.Add(Me.smithSeries1)
        Me.tChart1.Size = New System.Drawing.Size(499, 217)
        ' 
        ' smithSeries1
        ' 
        ' 
        ' smithSeries1.Brush
        ' 
        Me.smithSeries1.Brush.Color = System.Drawing.Color.Red
        Me.smithSeries1.Brush.Visible = False
        Me.smithSeries1.CircleBackColor = System.Drawing.Color.FromArgb(CType(0, System.Byte), CType(0, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        Me.smithSeries1.Circled = True
        Me.smithSeries1.CLabels = True
        Me.smithSeries1.ImagSymbol = "i"
        ' 
        ' smithSeries1.Marks
        ' 
        ' 
        ' smithSeries1.Marks.Symbol
        ' 
        ' 
        ' smithSeries1.Marks.Symbol.Shadow
        ' 
        Me.smithSeries1.Marks.Symbol.Shadow.Height = 1
        Me.smithSeries1.Marks.Symbol.Shadow.Visible = True
        Me.smithSeries1.Marks.Symbol.Shadow.Width = 1
        ' 
        ' smithSeries1.Pointer
        ' 
        ' 
        ' smithSeries1.Pointer.Brush
        ' 
        Me.smithSeries1.Pointer.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(0, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        Me.smithSeries1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.smithSeries1.RLabels = True
        Me.smithSeries1.Title = "smithSeries1"
        ' 
        ' smithSeries1.XValues
        ' 
        Me.smithSeries1.XValues.DataMember = "Resistance"
        ' 
        ' smithSeries1.YValues
        ' 
        Me.smithSeries1.YValues.DataMember = "Reactance"
        ' 
        ' button1
        ' 
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.Location = New System.Drawing.Point(13, 9)
        Me.button1.Name = "button1"
        Me.button1.TabIndex = 0
        Me.button1.Text = "&Edit..."
        ' 
        ' checkBox1
        ' 
        Me.checkBox1.Checked = True
        Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox1.Location = New System.Drawing.Point(107, 9)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(60, 21)
        Me.checkBox1.TabIndex = 1
        Me.checkBox1.Text = "&Circled"
        ' 
        ' label1
        ' 
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(180, 11)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(78, 16)
        Me.label1.TabIndex = 2
        Me.label1.Text = "&Imag. symbol :"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        ' 
        ' textBox2
        ' 
        Me.textBox2.Location = New System.Drawing.Point(260, 9)
        Me.textBox2.Name = "textBox2"
        Me.textBox2.Size = New System.Drawing.Size(27, 20)
        Me.textBox2.TabIndex = 3
        Me.textBox2.Text = "i"
        ' 
        ' SeriesType_Smith
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(499, 320)
        Me.Name = "SeriesType_Smith"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub 'InitializeComponent 
#End Region


    Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
        Me.smithSeries1.FillSampleValues(10)
    End Sub 'button1_Click


    Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox1.CheckedChanged
        Me.smithSeries1.Circled = checkBox1.Checked
    End Sub 'checkBox1_CheckedChanged


    Private Sub textBox2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles textBox2.TextChanged
        Me.smithSeries1.ImagSymbol = textBox2.Text
    End Sub 'textBox2_TextChanged
End Class 'Smith_Series
