
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing

Imports System.Windows.Forms




Public Class FastLine_DrawAll
    Inherits Steema.TeeChart.Samples.BaseForm
    Private fastLineSeries1 As Steema.TeeChart.Styles.FastLine
    Private label1 As System.Windows.Forms.Label
    Private WithEvents radioButton1 As System.Windows.Forms.RadioButton
    Private WithEvents radioButton2 As System.Windows.Forms.RadioButton
    Private components As System.ComponentModel.IContainer = Nothing
    
    
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        
        Const numPoints As Integer = 100000
        
        Me.fastLineSeries1.GetHorizAxis.SetMinMax(0, numPoints - 1)
        ' tell Series1 to draw non-repeated points only ( much faster ! )
        Me.fastLineSeries1.DrawAllPoints = False
        ' this.tChart1.Axes.FastCals = true
        ' lets generate 1E+5 points }
        Dim myX(numPoints) As Double
        Dim myY(numPoints) As Double
        
        Dim r As New System.Random()
        Dim tmp As Double = r.NextDouble() * 10000
        Dim t As Integer = 0
        While t < numPoints
            tmp += r.Next(100) - 49.5
            myX(t) = t
            myY(t) = tmp
            System.Math.Min(System.Threading.Interlocked.Increment(t), t - 1)
        End While

        ' now add points to series
        Me.fastLineSeries1.XValues.Count = numPoints
        Me.fastLineSeries1.XValues.Value = myX
        Me.fastLineSeries1.YValues.Count = numPoints
        Me.fastLineSeries1.YValues.Value = myY
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
        Me.fastLineSeries1 = New Steema.TeeChart.Styles.FastLine
        Me.label1 = New System.Windows.Forms.Label
        Me.radioButton1 = New System.Windows.Forms.RadioButton
        Me.radioButton2 = New System.Windows.Forms.RadioButton
        Me.panel1.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(592, 73)
        Me.textBox1.Text = "The Fast-Line series below is displaying 100.000 ! To speed up display, a new pro" + "perty ( DrawAllPoints ) only draws line segments between points that are not pla" + "ced at the same ""X"" pixel position." + vbCr + vbLf + vbCr + vbLf + "fastlineSeries1.DrawAllPoints = false "
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.radioButton2)
        Me.panel1.Controls.Add(Me.radioButton1)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(592, 31)
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
        Me.tChart1.Header.Lines = New String() {"tChart1"}
        Me.tChart1.Header.Visible = False
        ' 
        ' tChart1.Legend
        ' 
        Me.tChart1.Legend.Visible = False
        Me.tChart1.Location = New System.Drawing.Point(0, 104)
        Me.tChart1.Name = "tChart1"
        Me.tChart1.Series.Add(Me.fastLineSeries1)
        Me.tChart1.Size = New System.Drawing.Size(592, 264)
        ' 
        ' fastLineSeries1
        ' 
        Me.fastLineSeries1.Cursor = System.Windows.Forms.Cursors.Cross
        ' 
        ' fastLineSeries1.LinePen
        ' 
        Me.fastLineSeries1.LinePen.Color = System.Drawing.Color.Red
        Me.fastLineSeries1.Title = "fastLineSeries1"
        ' 
        ' label1
        ' 
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(18, 10)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(37, 16)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Draw :"
        Me.label1.UseMnemonic = False
        ' 
        ' radioButton1
        ' 
        Me.radioButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.radioButton1.Location = New System.Drawing.Point(104, 6)
        Me.radioButton1.Name = "radioButton1"
        Me.radioButton1.TabIndex = 1
        Me.radioButton1.Text = "&All points"
        ' 
        ' radioButton2
        ' 
        Me.radioButton2.Checked = True
        Me.radioButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.radioButton2.Location = New System.Drawing.Point(192, 6)
        Me.radioButton2.Name = "radioButton2"
        Me.radioButton2.Size = New System.Drawing.Size(152, 24)
        Me.radioButton2.TabIndex = 2
        Me.radioButton2.TabStop = True
        Me.radioButton2.Text = "&Non-repeated X only"
        ' 
        ' Fastline_DrawAll
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(592, 368)
        Me.Name = "Fastline_DrawAll"
        Me.panel1.ResumeLayout(False)
    End Sub 'InitializeComponent 
#End Region


    Private Sub radioButton2_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles radioButton2.CheckedChanged
        Me.fastLineSeries1.DrawAllPoints = Me.radioButton1.Checked
    End Sub 'radioButton2_CheckedChanged


    Private Sub radioButton1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles radioButton1.CheckedChanged
        Me.fastLineSeries1.DrawAllPoints = Me.radioButton1.Checked
    End Sub 'radioButton1_CheckedChanged
End Class 'FastLine_DrawAll
