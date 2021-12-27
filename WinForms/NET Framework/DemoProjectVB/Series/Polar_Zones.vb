
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms


Public Class Polar_Zones
    Inherits Steema.TeeChart.Samples.BaseForm
    Private WithEvents polar1 As Steema.TeeChart.Styles.Polar
    Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
    Private components As System.ComponentModel.IContainer = Nothing
    
    Public Sub New() ' This call is required by the Windows Form Designer.
        InitializeComponent()

        polar1.Add(30, 100)
        polar1.Add(45, 150)
        polar1.Add(60, - 90)
        polar1.Add(80, 300)
        polar1.Add(130, 400)
        polar1.Add(170, 250)
        polar1.Add(230, 100)
        polar1.Add(260, 120)
        polar1.Add(330, 700)
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

#Region "Windows Form Designer generated code"

    '/ <summary>
    '/ Required method for Designer support - do not modify
    '/ the contents of this method with the code editor.
    '/ </summary>
    Private Sub InitializeComponent()
        Me.polar1 = New Steema.TeeChart.Styles.Polar
        Me.checkBox1 = New System.Windows.Forms.CheckBox
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Text = "Polar Series can now fill the background using a Gradient, and provides a DrawZone method to fill round \""donut\"" zones. " & vbCrLf & vbCrLf & "polar1.DrawZone(300, 700, tChart1.Aspe" + "ct.Width3D)"
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.checkBox1)
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
        ' 
        ' tChart1.Header
        ' 
        Me.tChart1.Header.Lines = New String() {"Polar background zones"}
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Brush
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(254, Byte), CType(255, Byte), CType(255, Byte), CType(255, Byte))
        ' 
        ' tChart1.Panel.Gradient
        ' 
        Me.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(254, Byte), CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(254, Byte), CType(192, Byte), CType(192, Byte), CType(192, Byte))
        Me.tChart1.Panel.Brush.Gradient.UseMiddle = True
        Me.tChart1.Panel.Brush.Gradient.Visible = True
        ' 
        ' tChart1.Panel.Gradient
        ' 
        Me.tChart1.Panel.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(254, Byte), CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.tChart1.Panel.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(254, Byte), CType(192, Byte), CType(192, Byte), CType(192, Byte))
        Me.tChart1.Panel.Gradient.UseMiddle = True
        Me.tChart1.Panel.Gradient.Visible = True
        Me.tChart1.Series.Add(Me.polar1)
        ' 
        ' polar1
        ' 
        ' 
        ' polar1.Brush
        ' 
        Me.polar1.Brush.Color = System.Drawing.Color.Red
        Me.polar1.Brush.Visible = False
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
        Me.polar1.Pen.Color = System.Drawing.Color.Red
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
        AddHandler polar1.BeforeDrawValues, AddressOf Me.polar1_BeforeDrawValues
        ' 
        ' checkBox1
        ' 
        Me.checkBox1.Checked = True
        Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox1.Location = New System.Drawing.Point(16, 8)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.TabIndex = 0
        Me.checkBox1.Text = "Draw Zones"
        AddHandler checkBox1.Click, AddressOf Me.checkBox1_Click
        ' 
        ' Polar_Zones
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(440, 317)
        Me.Name = "Polar_Zones"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
   
    End Sub
#End Region

    Private Sub DrawPolarZones(ByVal g As Steema.TeeChart.Drawing.Graphics3D)
        If (polar1.CircleXCenter <> 0) Then
            ' Hide pen
            g.Pen.Visible = False
            'Draw three zones (green, yellow and red)
            g.Brush.Color = Color.Red
            polar1.DrawZone(500, 700, tChart1.Aspect.Width3D)
            g.Brush.Color = Color.Yellow
            polar1.DrawZone(300, 500, tChart1.Aspect.Width3D)
            g.Brush.Visible = True
            g.Brush.Color = Color.Green
            polar1.DrawZone(100, 300, tChart1.Aspect.Width3D)
            ' Draw "ring" at 300
            g.Brush.Visible = False
            g.Pen.Visible = True
            g.Pen.Color = Color.White
            g.Pen.Width = 2
            polar1.DrawRing(300, tChart1.Aspect.Width3D)
        End If
    End Sub

    Private Sub polar1_BeforeDrawValues(ByVal sender As Object, ByVal g As Steema.TeeChart.Drawing.Graphics3D) Handles polar1.BeforeDrawValues
        If checkBox1.Checked Then
            DrawPolarZones(g)
        End If
    End Sub

    Private Sub checkBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox1.CheckedChanged
        tChart1.Refresh()
    End Sub
End Class 'Polar_Zones