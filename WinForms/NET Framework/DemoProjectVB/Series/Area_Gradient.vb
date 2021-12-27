
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing

Imports System.Windows.Forms




Public Class Area_Gradient
    Inherits Samples.BaseForm
    Private areaSeries1 As Steema.TeeChart.Styles.Area
    Private WithEvents button1 As System.Windows.Forms.Button
    Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
    Private WithEvents trackBar1 As System.Windows.Forms.TrackBar
    Private label1 As System.Windows.Forms.Label
    Private components As System.ComponentModel.IContainer = Nothing
    
    
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        
        areaSeries1.FillSampleValues(10)
        areaSeries1.Gradient.Visible = True
        areaSeries1.Gradient.StartColor = Color.Red
        areaSeries1.Gradient.MiddleColor = Color.Blue
        areaSeries1.Gradient.EndColor = Color.Green
        
        trackBar1.Value = areaSeries1.Transparency
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
        Me.button1 = New System.Windows.Forms.Button
        Me.checkBox1 = New System.Windows.Forms.CheckBox
        Me.trackBar1 = New System.Windows.Forms.TrackBar
        Me.label1 = New System.Windows.Forms.Label
        Me.panel1.SuspendLayout()
        CType(Me.trackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(466, 63)
        Me.textBox1.TabIndex = 0
        Me.textBox1.Text = "Area Series includes a Gradient property to fill Area segments." + vbCr + vbLf + "This feature is " + "better visualized in 2 dimensions and with vertically oriented gradients. Transp" + "arency of gradient filling is also supported."
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Controls.Add(Me.trackBar1)
        Me.panel1.Controls.Add(Me.checkBox1)
        Me.panel1.Controls.Add(Me.button1)
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
        Me.tChart1.Header.Lines = New String() {"Area series gradient & transparency"}
        Me.tChart1.Location = New System.Drawing.Point(0, 96)
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
        Me.tChart1.Panel.Brush.Gradient.Direction = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.tChart1.Panel.Brush.Gradient.Visible = True
        ' 
        ' tChart1.Panel.Gradient
        ' 
        Me.tChart1.Panel.Gradient.Direction = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.tChart1.Panel.Gradient.Visible = True
        Me.tChart1.Series.Add(Me.areaSeries1)
        Me.tChart1.Size = New System.Drawing.Size(466, 190)
        Me.tChart1.TabIndex = 2
        ' 
        ' areaSeries1
        ' 
        ' 
        ' areaSeries1.AreaBrush
        ' 
        Me.areaSeries1.AreaBrush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(204, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        ' 
        ' areaSeries1.AreaLines
        ' 
        Me.areaSeries1.AreaLines.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(122, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        ' 
        ' areaSeries1.Brush
        ' 
        Me.areaSeries1.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(204, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        ' 
        ' areaSeries1.LinePen
        ' 
        Me.areaSeries1.LinePen.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(122, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
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
        ' button1
        ' 
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.Location = New System.Drawing.Point(11, 5)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(101, 23)
        Me.button1.TabIndex = 0
        Me.button1.Text = "&Edit gradient..."
        ' 
        ' checkBox1
        ' 
        Me.checkBox1.Checked = True
        Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox1.Location = New System.Drawing.Point(128, 6)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(112, 21)
        Me.checkBox1.TabIndex = 1
        Me.checkBox1.Text = "&Gradient visible"
        ' 
        ' trackBar1
        ' 
        Me.trackBar1.AutoSize = False
        Me.trackBar1.LargeChange = 10
        Me.trackBar1.Location = New System.Drawing.Point(288, 8)
        Me.trackBar1.Maximum = 100
        Me.trackBar1.Name = "trackBar1"
        Me.trackBar1.Size = New System.Drawing.Size(127, 16)
        Me.trackBar1.TabIndex = 3
        Me.trackBar1.TickFrequency = 5
        ' 
        ' label1
        ' 
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(240, 8)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(43, 16)
        Me.label1.TabIndex = 2
        Me.label1.Text = "&Transp:"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        ' 
        ' Area_Gradient
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(466, 286)
        Me.Name = "Area_Gradient"
        Me.panel1.ResumeLayout(False)
        CType(Me.trackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub 'InitializeComponent 
#End Region


    Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
        Steema.TeeChart.Editors.GradientEditor.Edit(areaSeries1.Brush.Gradient)

        ' reset this controls
        checkBox1.Checked = areaSeries1.Gradient.Visible
        trackBar1.Value = areaSeries1.Gradient.Transparency
        areaSeries1.Transparency = areaSeries1.Gradient.Transparency
    End Sub 'button1_Click


    Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox1.CheckedChanged
        Me.areaSeries1.Brush.Gradient.Visible = Me.checkBox1.Checked
    End Sub 'checkBox1_CheckedChanged


    Private Sub trackBar1_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles trackBar1.ValueChanged
        Me.areaSeries1.Transparency = Fix(Me.trackBar1.Value)
    End Sub 'trackBar1_ValueChanged
End Class 'Area_Gradient
