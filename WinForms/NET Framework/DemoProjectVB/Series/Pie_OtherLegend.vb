
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms


Public Class Pie_OtherLegend
    Inherits Steema.TeeChart.Samples.BaseForm
    Private pie1 As Steema.TeeChart.Styles.Pie
    Private checkBox1 As System.Windows.Forms.CheckBox
    Private button1 As System.Windows.Forms.Button
    Private components As System.ComponentModel.IContainer = Nothing
    
    Public Sub New() ' This call is required by the Windows Form Designer.
        InitializeComponent()

        'add data
        pie1.Add(134, "Google")
        pie1.Add(65, "Yahoo")
        pie1.Add(23, "AltaVista")
        pie1.Add(12, "AllTheWeb")
        pie1.Add(9, "Terra")
        pie1.Add(6, "Lycos")
        pie1.Add(3, "Ask Jeeves")
        
        ' prepare "Other" to group values below 10
        pie1.OtherSlice.Style = Steema.TeeChart.Styles.PieOtherStyles.BelowValue
        pie1.OtherSlice.Value = 10
        pie1.OtherSlice.Text = "Other"
        
        pie1.OtherSlice.Legend.Visible = True
        pie1.OtherSlice.Legend.CustomPosition = True
        pie1.OtherSlice.Legend.Left = 475
        pie1.OtherSlice.Legend.Top = 150
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
        Me.pie1 = New Steema.TeeChart.Styles.Pie
        Me.checkBox1 = New System.Windows.Forms.CheckBox
        Me.button1 = New System.Windows.Forms.Button
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Text = ("New Pie series Legend property to display a sub-legend for Pie ""Other"" grouped slices. " & vbCrLf & vbCrLf & "pie1.OtherSlice.Legend.Visible = true")
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.button1)
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
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb((CType((254), System.Byte)), (CType((255), System.Byte)), (CType((255), System.Byte)), (CType((255), System.Byte)))
        Me.tChart1.Series.Add(Me.pie1)
        AddHandler tChart1.AfterDraw, AddressOf Me.tChart1_AfterDraw
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
        Me.pie1.Pen.Color = System.Drawing.Color.FromArgb((CType((254), System.Byte)), (CType((128), System.Byte)), (CType((128), System.Byte)), (CType((128), System.Byte)))
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
        ' checkBox1
        ' 
        Me.checkBox1.Checked = True
        Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox1.Location = New System.Drawing.Point(8, 8)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(136, 24)
        Me.checkBox1.TabIndex = 0
        Me.checkBox1.Text = "Show ""other"" Legend"
        AddHandler checkBox1.Click, AddressOf Me.checkBox1_Click
        ' 
        ' button1
        ' 
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.Location = New System.Drawing.Point(203, 10)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(84, 23)
        Me.button1.TabIndex = 1
        Me.button1.Text = "Edit Legend..."
        AddHandler button1.Click, AddressOf Me.button1_Click
        ' 
        ' Pie_OtherLegend
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(440, 317)
        Me.Name = "Pie_OtherLegend"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub 'New

   
#End Region
    

    Private Sub tChart1_AfterDraw(ByVal sender As Object, ByVal g As Steema.TeeChart.Drawing.Graphics3D)
        ' cosmetic line from normal legend to "other" legend
        If pie1.OtherSlice.Legend.Visible Then
            g.Pen.Style = System.Drawing.Drawing2D.DashStyle.Dot
            g.Pen.Width = 2
            g.Pen.Color = Color.Navy

            Dim tmpX As Integer = tChart1.Legend.Left
            g.MoveTo(tmpX, tChart1.Legend.ShapeBounds.Bottom - 4)
            g.LineTo(tmpX - 10, tChart1.Legend.ShapeBounds.Bottom - 4)
            g.LineTo(tmpX - 10, pie1.OtherSlice.Legend.Top + 4)
            g.LineTo(pie1.OtherSlice.Legend.Left, pie1.OtherSlice.Legend.Top + 4)
        End If
    End Sub 'tChart1_AfterDraw


    Private Sub checkBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        pie1.OtherSlice.Legend.Visible = checkBox1.Checked
    End Sub 'checkBox1_Click


    Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim lEdit As New Steema.TeeChart.Editors.LegendEditor(tChart1.Chart, pie1.OtherSlice.Legend, Nothing)
        Steema.TeeChart.Editors.EditorUtils.ShowFormModal(lEdit)
    End Sub 'button1_Click
End Class 'Pie_OtherLegend