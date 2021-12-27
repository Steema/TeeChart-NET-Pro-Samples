
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms


Public Class Function_DownSampling
    Inherits Steema.TeeChart.Samples.BaseForm
    Private points1 As Steema.TeeChart.Styles.Points
    Private line1 As Steema.TeeChart.Styles.Line
    Private downsampling1 As Steema.TeeChart.Functions.DownSampling
    Private hScrollBar1 As System.Windows.Forms.HScrollBar
    Private label1 As System.Windows.Forms.Label
    Private label2 As System.Windows.Forms.Label
    Private textBox2 As System.Windows.Forms.TextBox
    Private components As System.ComponentModel.IContainer = Nothing
    Private label3 As System.Windows.Forms.Label
    Private label4 As System.Windows.Forms.Label
    Private comboBox1 As System.Windows.Forms.ComboBox
    
    Public Sub New() ' This call is required by the Windows Form Designer.
        InitializeComponent()
        points1.FillSampleValues(1000)
        ' connect function to parent series 
        line1.DataSource = points1
        ' setup downnsapling function properties
        downsampling1.Tolerance = 10.0
        line1.Function = downsampling1
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
        Me.points1 = New Steema.TeeChart.Styles.Points
        Me.line1 = New Steema.TeeChart.Styles.Line
        Me.downsampling1 = New Steema.TeeChart.Functions.DownSampling
        Me.hScrollBar1 = New System.Windows.Forms.HScrollBar
        Me.label1 = New System.Windows.Forms.Label
        Me.label2 = New System.Windows.Forms.Label
        Me.textBox2 = New System.Windows.Forms.TextBox
        Me.label3 = New System.Windows.Forms.Label
        Me.comboBox1 = New System.Windows.Forms.ComboBox
        Me.label4 = New System.Windows.Forms.Label
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(440, 104)
        Me.textBox1.Text = "DownSampling function reduces the number of points in series by using " + vbCr + vbLf + "several different methods:" + vbCr + vbLf + vbCr + vbLf + "+ dsAverage : replace group of points with group average values" + vbCr + vbLf + "+ dsMax : replace group of points with group maximum values" + vbCr + vbLf + "+ dsMin : replace group of points with group minimum values" + vbCr + vbLf + "+ dsMinMax : replace group of points with group minimum AND maximum values"
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.label4)
        Me.panel1.Controls.Add(Me.comboBox1)
        Me.panel1.Controls.Add(Me.label3)
        Me.panel1.Controls.Add(Me.textBox2)
        Me.panel1.Controls.Add(Me.label2)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Controls.Add(Me.hScrollBar1)
        Me.panel1.Location = New System.Drawing.Point(0, 104)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(440, 80)
        ' 
        ' tChart1
        ' 
        ' 
        ' tChart1.Aspect
        ' 
        Me.tChart1.Aspect.View3D = False
        ' 
        ' tChart1.Header
        ' 
        Me.tChart1.Header.Lines = New String() {"Downsampling function example"}
        ' 
        ' tChart1.Legend
        ' 
        Me.tChart1.Legend.Alignment = Steema.TeeChart.LegendAlignments.Bottom
        Me.tChart1.Location = New System.Drawing.Point(0, 184)
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Brush
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.tChart1.Series.Add(Me.points1)
        Me.tChart1.Series.Add(Me.line1)
        Me.tChart1.Size = New System.Drawing.Size(440, 133)
        ' 
        ' points1
        ' 
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
        Me.points1.Pointer.HorizSize = 2
        ' 
        ' points1.Pointer.Pen
        ' 
        Me.points1.Pointer.Pen.Visible = False
        Me.points1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Triangle
        Me.points1.Pointer.VertSize = 2
        Me.points1.Title = "Data"
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
        ' line1
        ' 
        ' 
        ' line1.Brush
        ' 
        Me.line1.Brush.Color = System.Drawing.Color.Green
        ' 
        ' line1.Marks
        ' 
        ' 
        ' line1.Marks.Symbol
        ' 
        ' 
        ' line1.Marks.Symbol.Shadow
        ' 
        Me.line1.Marks.Symbol.Shadow.Height = 1
        Me.line1.Marks.Symbol.Shadow.Visible = True
        Me.line1.Marks.Symbol.Shadow.Width = 1
        ' 
        ' line1.Pointer
        ' 
        ' 
        ' line1.Pointer.Brush
        ' 
        Me.line1.Pointer.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(0, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        Me.line1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.line1.Title = "Reduced data"
        ' 
        ' line1.XValues
        ' 
        Me.line1.XValues.DataMember = "X"
        Me.line1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' line1.YValues
        ' 
        Me.line1.YValues.DataMember = "Y"
        ' 
        ' downsampling1
        ' 
        Me.downsampling1.Method = Steema.TeeChart.Functions.DownSamplingMethod.Average
        Me.downsampling1.Period = 1
        Me.downsampling1.Tolerance = 1
        ' 
        ' hScrollBar1
        ' 
        Me.hScrollBar1.LargeChange = 1000
        Me.hScrollBar1.Location = New System.Drawing.Point(8, 16)
        Me.hScrollBar1.Maximum = 10000
        Me.hScrollBar1.Name = "hScrollBar1"
        Me.hScrollBar1.Size = New System.Drawing.Size(152, 16)
        Me.hScrollBar1.SmallChange = 100
        Me.hScrollBar1.TabIndex = 0
        Me.hScrollBar1.Value = 1000
        AddHandler Me.hScrollBar1.Scroll, AddressOf Me.hScrollBar1_Scroll
        ' 
        ' label1
        ' 
        Me.label1.Location = New System.Drawing.Point(16, 40)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(136, 16)
        Me.label1.TabIndex = 1
        Me.label1.Text = "Data points :  1000"
        ' 
        ' label2
        ' 
        Me.label2.Location = New System.Drawing.Point(200, 16)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(72, 16)
        Me.label2.TabIndex = 2
        Me.label2.Text = "Tolerance :"
        ' 
        ' textBox2
        ' 
        Me.textBox2.Location = New System.Drawing.Point(272, 16)
        Me.textBox2.Name = "textBox2"
        Me.textBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.textBox2.Size = New System.Drawing.Size(40, 20)
        Me.textBox2.TabIndex = 3
        Me.textBox2.Text = "10"
        AddHandler Me.textBox2.TextChanged, AddressOf Me.textBox2_TextChanged
        ' 
        ' label3
        ' 
        Me.label3.Location = New System.Drawing.Point(208, 40)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(48, 23)
        Me.label3.TabIndex = 4
        Me.label3.Text = "Method :"
        ' 
        ' comboBox1
        ' 
        Me.comboBox1.Items.AddRange(New Object() {"Average", "Maximum", "Minimum", "Minimum AND Maximum"})
        Me.comboBox1.Location = New System.Drawing.Point(272, 40)
        Me.comboBox1.Name = "comboBox1"
        Me.comboBox1.Size = New System.Drawing.Size(104, 21)
        Me.comboBox1.TabIndex = 5
        AddHandler Me.comboBox1.SelectedIndexChanged, AddressOf Me.comboBox1_SelectedIndexChanged
        ' 
        ' label4
        ' 
        Me.label4.Location = New System.Drawing.Point(16, 64)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(136, 16)
        Me.label4.TabIndex = 6
        Me.label4.Text = "label4"
        ' 
        ' Function_DownSampling
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(440, 317)
        Me.Name = "Function_DownSampling"
        AddHandler Me.Load, AddressOf Me.Function_DownSampling_Load
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub 'New 
#End Region


    Private Sub hScrollBar1_Scroll(ByVal sender As Object, ByVal e As System.Windows.Forms.ScrollEventArgs)
        label1.Text = "Data points : " + hScrollBar1.Value.ToString()
        points1.Clear()
        points1.BeginUpdate()
        ' repopulate
        Dim r As New System.Random
        Dim tmp As Double = r.NextDouble() * 10000
        Dim t As Integer
        For t = 0 To hScrollBar1.Value - 1
            tmp = (tmp + (r.Next(100) - 49.5))
            points1.Add(t, tmp)
        Next t
        points1.EndUpdate()
        downsampling1.Recalculate()
        label4.Text = "Reduced data size :" + downsampling1.ReducedSize.ToString()
    End Sub 'hScrollBar1_Scroll


    Private Sub textBox2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        line1.BeginUpdate()
        Dim factor As Double = Convert.ToDouble(textBox2.Text)
        line1.EndUpdate()
        downsampling1.Tolerance = factor
        label4.Text = "Reduced data size :" + downsampling1.ReducedSize.ToString()
    End Sub 'textBox2_TextChanged


    Private Sub comboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Select Case comboBox1.SelectedIndex
            Case 0
                downsampling1.Method = Steema.TeeChart.Functions.DownSamplingMethod.Average
            Case 1
                downsampling1.Method = Steema.TeeChart.Functions.DownSamplingMethod.Max
            Case 2
                downsampling1.Method = Steema.TeeChart.Functions.DownSamplingMethod.Min
            Case 3
                downsampling1.Method = Steema.TeeChart.Functions.DownSamplingMethod.MinMax
        End Select
        label4.Text = "Reduced data size :" + downsampling1.ReducedSize.ToString()
    End Sub 'comboBox1_SelectedIndexChanged


    Private Sub Function_DownSampling_Load(ByVal sender As Object, ByVal e As System.EventArgs)
        comboBox1.SelectedIndex = 0
    End Sub 'Function_DownSampling_Load
End Class 'Function_DownSampling