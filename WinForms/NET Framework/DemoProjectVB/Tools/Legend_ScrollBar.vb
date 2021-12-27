
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms


Public Class LegendScrollBar
    Inherits Steema.TeeChart.Samples.BaseForm
    Private button1 As System.Windows.Forms.Button
    Private label1 As System.Windows.Forms.Label
    Private label2 As System.Windows.Forms.Label
    Private points1 As Steema.TeeChart.Styles.Points
    Private legendScrollBar1 As Steema.TeeChart.Tools.LegendScrollBar
    Private components As System.ComponentModel.IContainer = Nothing
    
    Public Sub New() ' This call is required by the Windows Form Designer.
        InitializeComponent()

        points1.FillSampleValues()
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
        Me.label1 = New System.Windows.Forms.Label
        Me.label2 = New System.Windows.Forms.Label
        Me.points1 = New Steema.TeeChart.Styles.Points
        Me.legendScrollBar1 = New Steema.TeeChart.Tools.LegendScrollBar
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Text = "Legend scrollbar tool displays a scroll-bar inside the legend bounds." + vbCr + vbLf + vbCr + vbLf + "The scro" + "llbar is not a Windows control, thus it allows more customization" + vbCr + vbLf + "of colors, et" + "c."
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.label2)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Controls.Add(Me.button1)
        Me.panel1.Name = "panel1"
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
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Brush
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.tChart1.Series.Add(Me.points1)
        Me.tChart1.Tools.Add(Me.legendScrollBar1)
        ' 
        ' button1
        ' 
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.Location = New System.Drawing.Point(16, 10)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(144, 23)
        Me.button1.TabIndex = 0
        Me.button1.Text = "Edit Legend ScrollBar..."
        AddHandler Me.button1.Click, AddressOf Me.button1_Click
        ' 
        ' label1
        ' 
        Me.label1.Location = New System.Drawing.Point(182, 15)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(106, 16)
        Me.label1.TabIndex = 1
        Me.label1.Text = "Legend First Value:"
        ' 
        ' label2
        ' 
        Me.label2.Location = New System.Drawing.Point(288, 16)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(48, 16)
        Me.label2.TabIndex = 2
        ' 
        ' points1
        ' 
        Me.points1.ColorEach = True
        ' 
        ' points1.Marks
        ' 
        ' 
        ' points1.Marks.Symbol
        ' 
        ' 
        ' points1.Marks.Symbol.Shadow
        ' 
        Me.points1.Marks.Symbol.Shadow.Height = 1
        Me.points1.Marks.Symbol.Shadow.Visible = True
        Me.points1.Marks.Symbol.Shadow.Width = 1
        ' 
        ' points1.Pointer
        ' 
        ' 
        ' points1.Pointer.Brush
        ' 
        Me.points1.Pointer.Brush.Color = System.Drawing.Color.Red
        Me.points1.Pointer.Brush.ForegroundColor = System.Drawing.Color.Empty
        Me.points1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.points1.Title = "points1"
        ' 
        ' points1.XValues
        ' 
        Me.points1.XValues.DataMember = "X"
        Me.points1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' points1.YValues
        ' 
        Me.points1.YValues.DataMember = "Y"
        ' 
        ' legendScrollBar1
        ' 
        ' 
        ' legendScrollBar1.ArrowBrush
        ' 
        Me.legendScrollBar1.ArrowBrush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(192, System.Byte), CType(128, System.Byte))
        ' 
        ' legendScrollBar1.Bevel
        ' 
        Me.legendScrollBar1.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.Raised
        Me.legendScrollBar1.DrawStyle = Steema.TeeChart.Tools.ScrollBarDrawStyle.Always
        Me.legendScrollBar1.Horizontal = False
        ' 
        ' legendScrollBar1.Pen
        ' 
        Me.legendScrollBar1.Pen.Color = System.Drawing.SystemColors.WindowFrame
        Me.legendScrollBar1.Position = 0
        Me.legendScrollBar1.Size = 18
        ' 
        ' legendScrollBar1.ThumbBrush
        ' 
        Me.legendScrollBar1.ThumbBrush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(192, System.Byte), CType(128, System.Byte))
        AddHandler Me.legendScrollBar1.Scrolled, AddressOf Me.legendScrollBar1_Scrolled
        ' 
        ' LegendScrollBar
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(440, 317)
        Me.Name = "LegendScrollBar"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub 'New 
#End Region


    Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Steema.TeeChart.Editors.Tools.ScrollBarEditor.Edit(legendScrollBar1)
    End Sub 'button1_Click


    Private Sub legendScrollBar1_Scrolled(ByVal sender As Object, ByVal e As System.EventArgs)
        label2.Text = tChart1.Legend.FirstValue.ToString()
    End Sub 'legendScrollBar1_Scrolled
End Class 'LegendScrollBar