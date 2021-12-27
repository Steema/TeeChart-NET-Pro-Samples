
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing

Imports System.Windows.Forms




Public Class Bar_Gradient
    Inherits Samples.BaseForm
    Private WithEvents button1 As System.Windows.Forms.Button
    Private barSeries1 As Steema.TeeChart.Styles.Bar
    Private gridBand1 As Steema.TeeChart.Tools.GridBand
    Private components As System.ComponentModel.IContainer = Nothing
    
    
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        
        Me.barSeries1.FillSampleValues(6)
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
        Me.button1 = New System.Windows.Forms.Button
        Me.barSeries1 = New Steema.TeeChart.Styles.Bar
        Me.gridBand1 = New Steema.TeeChart.Tools.GridBand
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(466, 80)
        Me.textBox1.Text = "Bar and Horiz.Bar series can display gradients, with ""middle"" color." + vbCr + vbLf + vbCr + vbLf + "Example: " + vbCr + vbLf + "barSeries1.Gradient.MidColor = Color.Yellow " + vbCr + vbLf + "barSeries1.Gradient.StartColor " + "= Color.Gray "
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.button1)
        Me.panel1.Location = New System.Drawing.Point(0, 80)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(466, 41)
        ' 
        ' tChart1
        ' 
        ' 
        ' tChart1.Aspect
        ' 
        Me.tChart1.Aspect.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality
        Me.tChart1.Aspect.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        ' 
        ' tChart1.Header
        ' 
        Me.tChart1.Header.Lines = New String() {"Bar series gradient"}
        Me.tChart1.Location = New System.Drawing.Point(0, 121)
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Brush
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.tChart1.Series.Add(Me.barSeries1)
        Me.tChart1.Size = New System.Drawing.Size(466, 165)
        Me.tChart1.Tools.Add(Me.gridBand1)
        ' 
        ' tChart1.Walls
        ' 
        ' 
        ' tChart1.Walls.Bottom
        ' 
        ' 
        ' tChart1.Walls.Bottom.Pen
        ' 
        Me.tChart1.Walls.Bottom.Pen.Visible = False
        Me.tChart1.Walls.Bottom.Size = 4
        ' 
        ' tChart1.Walls.Left
        ' 
        ' 
        ' tChart1.Walls.Left.Pen
        ' 
        Me.tChart1.Walls.Left.Pen.Visible = False
        Me.tChart1.Walls.Left.Size = 4
        ' 
        ' button1
        ' 
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.Location = New System.Drawing.Point(13, 8)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(107, 23)
        Me.button1.TabIndex = 0
        Me.button1.Text = "&Edit gradient..."
        ' 
        ' barSeries1
        ' 
        ' 
        ' barSeries1.Brush
        ' 
        Me.barSeries1.Brush.Color = System.Drawing.Color.Red
        ' 
        ' barSeries1.Gradient
        ' 
        Me.barSeries1.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(138, System.Byte), CType(138, System.Byte), CType(0, System.Byte))
        Me.barSeries1.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(236, System.Byte), CType(236, System.Byte), CType(0, System.Byte))
        Me.barSeries1.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(192, System.Byte))
        Me.barSeries1.Brush.Gradient.UseMiddle = True
        Me.barSeries1.Brush.Gradient.Visible = True
        ' 
        ' barSeries1.Gradient
        ' 
        Me.barSeries1.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(138, System.Byte), CType(138, System.Byte), CType(0, System.Byte))
        Me.barSeries1.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(236, System.Byte), CType(236, System.Byte), CType(0, System.Byte))
        Me.barSeries1.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(192, System.Byte))
        Me.barSeries1.Gradient.UseMiddle = True
        Me.barSeries1.Gradient.Visible = True
        ' 
        ' barSeries1.Marks
        ' 
        ' 
        ' barSeries1.Marks.Symbol
        ' 
        ' 
        ' barSeries1.Marks.Symbol.Shadow
        ' 
        Me.barSeries1.Marks.Symbol.Shadow.Height = 1
        Me.barSeries1.Marks.Symbol.Shadow.Visible = True
        Me.barSeries1.Marks.Symbol.Shadow.Width = 1
        ' 
        ' barSeries1.Pen
        ' 
        Me.barSeries1.Pen.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(196, System.Byte), CType(196, System.Byte), CType(0, System.Byte))
        Me.barSeries1.Title = "barSeries1"
        ' 
        ' barSeries1.XValues
        ' 
        Me.barSeries1.XValues.DataMember = "X"
        Me.barSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' barSeries1.YValues
        ' 
        Me.barSeries1.YValues.DataMember = "Bar"
        ' 
        ' gridBand1
        ' 
        Me.gridBand1.Axis = Me.tChart1.Axes.Left
        ' 
        ' gridBand1.Band1
        ' 
        Me.gridBand1.Band1.Color = System.Drawing.Color.FromArgb(CType(127, System.Byte), CType(192, System.Byte), CType(192, System.Byte), CType(192, System.Byte))
        ' 
        ' gridBand1.Band2
        ' 
        Me.gridBand1.Band2.Color = System.Drawing.Color.FromArgb(CType(127, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        ' 
        ' Bar_Gradient
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(466, 286)
        Me.Name = "Bar_Gradient"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub 'InitializeComponent 
#End Region


    Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
        Dim gradientEditor As New Steema.TeeChart.Editors.GradientEditor(Me.barSeries1.Brush.Gradient)
        gradientEditor.ShowDialog()
    End Sub 'button1_Click
End Class 'Bar_Gradient
