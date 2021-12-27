
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms


Public Class Circled_Gradient
    Inherits Steema.TeeChart.Samples.BaseForm
    Private button1 As System.Windows.Forms.Button
    Private polar1 As Steema.TeeChart.Styles.Polar
    Private components As System.ComponentModel.IContainer = Nothing
    
    Public Sub New() ' This call is required by the Windows Form Designer.
        InitializeComponent()

        polar1.FillSampleValues()
    End Sub


    '/ <summary>
    '/ Clean up any resources being used.
    '/ </summary>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If Disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(Disposing)
    End Sub 'Dispose

#Region "Windows Form Designer generated code"

    '/ <summary>
    '/ Required method for Designer support - do not modify
    '/ the contents of this method with the code editor.
    '/ </summary>
    Private Sub InitializeComponent()
        Me.button1 = New System.Windows.Forms.Button
        Me.polar1 = New Steema.TeeChart.Styles.Polar
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Text = "New Gradient property for ""Circled"" series like Smith, Polar, Radar, Clock and  W" + "ind-Rose.  "
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.button1)
        Me.panel1.Name = "panel1"
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
        Me.tChart1.Cursor = System.Windows.Forms.Cursors.Default
        ' 
        ' tChart1.Header
        ' 
        Me.tChart1.Header.Lines = New String(-1) {}
        ' 
        ' tChart1.Legend
        ' 
        Me.tChart1.Legend.Visible = False
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
        Me.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(128, System.Byte), CType(128, System.Byte), CType(128, System.Byte))
        Me.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(224, System.Byte), CType(224, System.Byte), CType(224, System.Byte))
        Me.tChart1.Panel.Brush.Gradient.UseMiddle = True
        Me.tChart1.Panel.Brush.Gradient.Visible = True
        ' 
        ' tChart1.Panel.Gradient
        ' 
        Me.tChart1.Panel.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(128, System.Byte), CType(128, System.Byte), CType(128, System.Byte))
        Me.tChart1.Panel.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(224, System.Byte), CType(224, System.Byte), CType(224, System.Byte))
        Me.tChart1.Panel.Gradient.UseMiddle = True
        Me.tChart1.Panel.Gradient.Visible = True
        Me.tChart1.Series.Add(Me.polar1)
        ' 
        ' button1
        ' 
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.Location = New System.Drawing.Point(16, 8)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(96, 23)
        Me.button1.TabIndex = 0
        Me.button1.Text = "Edit Gradient..."
        AddHandler Me.button1.Click, AddressOf Me.button1_Click
        ' 
        ' polar1
        ' 
        ' 
        ' polar1.Brush
        ' 
        Me.polar1.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(128, System.Byte), CType(0, System.Byte))
        Me.polar1.Circled = True
        ' 
        ' polar1.Marks
        ' 
        ' 
        ' polar1.Marks.Symbol
        ' 
        ' 
        ' polar1.Marks.Symbol.Shadow
        ' 
        Me.polar1.Marks.Symbol.Shadow.Height = 1
        Me.polar1.Marks.Symbol.Shadow.Visible = True
        Me.polar1.Marks.Symbol.Shadow.Width = 1
        ' 
        ' polar1.Pen
        ' 
        Me.polar1.Pen.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(128, System.Byte), CType(0, System.Byte))
        ' 
        ' polar1.Pointer
        ' 
        ' 
        ' polar1.Pointer.Brush
        ' 
        Me.polar1.Pointer.Brush.Color = System.Drawing.Color.Red
        Me.polar1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.polar1.Title = "polar1"
        ' 
        ' polar1.XValues
        ' 
        Me.polar1.XValues.DataMember = "Angle"
        Me.polar1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' polar1.YValues
        ' 
        Me.polar1.YValues.DataMember = "Y"
        ' 
        ' Polar_Gradient
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(440, 317)
        Me.Name = "Polar_Gradient"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub 'New 
#End Region


    Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Steema.TeeChart.Editors.GradientEditor.Edit(polar1.CircleGradient)
    End Sub 'button1_Click
End Class 'Circled_Gradient