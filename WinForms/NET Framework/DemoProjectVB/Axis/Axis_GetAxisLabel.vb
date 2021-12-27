
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing

Imports System.Windows.Forms




Public Class Axis_GetAxisLabel
    Inherits Steema.TeeChart.Samples.BaseForm
    Private fastLine1 As Steema.TeeChart.Styles.FastLine
    Private components As System.ComponentModel.IContainer = Nothing
    
    
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        fastLine1.FillSampleValues()
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
        Me.fastLine1 = New Steema.TeeChart.Styles.FastLine
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.BackColor = System.Drawing.Color.AliceBlue
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(388, 63)
        Me.textBox1.Text = ("Customizing axis labels format (font color, etc) can be done also " & vbCrLf & "using the Get" & "AxisLabel event." & vbCrLf & vbCrLf & "The left axis shows labels in different colors.")
        ' 
        ' panel1
        ' 
        Me.panel1.BackColor = System.Drawing.SystemColors.Control
        Me.panel1.Location = New System.Drawing.Point(0, 63)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(388, 27)
        ' 
        ' tChart1
        ' 
        ' 
        ' tChart1.Aspect
        ' 
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
        Me.tChart1.Axes.Bottom.AxisPen.Width = 1
        ' 
        ' tChart1.Axes.Left
        ' 
        ' 
        ' tChart1.Axes.Left.AxisPen
        ' 
        Me.tChart1.Axes.Left.AxisPen.Width = 1
        ' 
        ' tChart1.Header
        ' 
        ' 
        ' tChart1.Header.Font
        ' 
        ' 
        ' tChart1.Header.Font.Brush
        ' 
        Me.tChart1.Header.Font.Brush.Color = System.Drawing.Color.FromArgb(CType(254, Byte), CType(0, Byte), CType(0, Byte), CType(128, Byte))
        Me.tChart1.Header.Font.Name = "Verdana"
        ' 
        ' tChart1.Header.Font.Shadow
        ' 
        ' 
        ' tChart1.Header.Font.Shadow.Brush
        ' 
        Me.tChart1.Header.Font.Shadow.Brush.Color = System.Drawing.Color.FromArgb(CType(254, Byte), CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.tChart1.Header.Font.Shadow.Visible = True
        Me.tChart1.Header.Lines = New String() {"Axis LAbels Format"}
        ' 
        ' tChart1.Legend
        ' 
        Me.tChart1.Legend.LegendStyle = Steema.TeeChart.LegendStyles.Series
        ' 
        ' tChart1.Legend.Shadow
        ' 
        Me.tChart1.Legend.Shadow.Visible = False
        Me.tChart1.Location = New System.Drawing.Point(0, 90)
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Brush
        ' 
        ' 
        ' tChart1.Panel.Gradient
        ' 
        Me.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(254, Byte), CType(255, Byte), CType(255, Byte), CType(210, Byte))
        Me.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(254, Byte), CType(255, Byte), CType(255, Byte), CType(210, Byte))
        Me.tChart1.Panel.Brush.Gradient.UseMiddle = True
        Me.tChart1.Panel.Brush.Gradient.Visible = True
        ' 
        ' tChart1.Panel.Gradient
        ' 
        Me.tChart1.Panel.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(254, Byte), CType(255, Byte), CType(255, Byte), CType(210, Byte))
        Me.tChart1.Panel.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(254, Byte), CType(255, Byte), CType(255, Byte), CType(210, Byte))
        Me.tChart1.Panel.Gradient.UseMiddle = True
        Me.tChart1.Panel.Gradient.Visible = True
        Me.tChart1.Series.Add(Me.fastLine1)
        Me.tChart1.Size = New System.Drawing.Size(388, 157)
        ' 
        ' tChart1.Walls
        ' 
        ' 
        ' tChart1.Walls.Back
        ' 
        Me.tChart1.Walls.Back.Visible = False
        AddHandler tChart1.GetAxisLabel, AddressOf Me.tChart1_GetAxisLabel
        ' 
        ' fastLine1
        ' 
        ' 
        ' fastLine1.LinePen
        ' 
        Me.fastLine1.LinePen.Color = System.Drawing.Color.FromArgb(CType(102, Byte), CType(153, Byte), CType(255, Byte))
        Me.fastLine1.Title = "fastLine1"
        ' 
        ' fastLine1.XValues
        ' 
        Me.fastLine1.XValues.DataMember = "X"
        Me.fastLine1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' fastLine1.YValues
        ' 
        Me.fastLine1.YValues.DataMember = "Y"
        ' 
        ' Axis_GetAxisLabel
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(388, 247)
        Me.Name = "Axis_GetAxisLabel"
        Me.ResumeLayout(False)
    End Sub 'InitializeComponent 
#End Region


    Private Sub tChart1_GetAxisLabel(ByVal sender As Object, ByVal e As Steema.TeeChart.GetAxisLabelEventArgs) Handles tChart1.GetAxisLabel
        Dim num As Double = Convert.ToDouble(e.LabelText)

        If sender Is tChart1.Axes.Left Then
            If num > CType(sender, Axis).Minimum + (CType(sender, Axis).Maximum - CType(sender, Axis).Minimum) / 2 Then
                CType(sender, Axis).Labels.Font.Color = Color.Red
            Else
                CType(sender, Axis).Labels.Font.Color = Color.Blue
            End If
        ElseIf sender Is tChart1.Axes.Bottom Then
            If num > 12 Then
                CType(sender, Axis).Labels.Font.Color = Color.Red
            Else
                CType(sender, Axis).Labels.Font.Color = Color.Blue
            End If
        End If
    End Sub 'tChart1_GetAxisLabel
End Class 'Axis_GetAxisLabel
