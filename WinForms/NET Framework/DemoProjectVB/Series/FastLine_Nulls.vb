Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Public Class FastLine_Nulls
    Inherits Steema.TeeChart.Samples.BaseForm
    Private fastLine1 As Steema.TeeChart.Styles.FastLine
    Private checkBox1 As System.Windows.Forms.CheckBox
    Private checkBox2 As System.Windows.Forms.CheckBox
    Private checkBox3 As System.Windows.Forms.CheckBox
    Private components As System.ComponentModel.IContainer = Nothing
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        fastLine1.FillSampleValues(50)
        ' set some null points:
        fastLine1.SetNull(14)
        fastLine1.SetNull(20)
        fastLine1.SetNull(31)
        fastLine1.SetNull(39)

        ' allow nulls:
        ' (Ignore nulls ... faster )             
        fastLine1.TreatNulls = Steema.TeeChart.Styles.TreatNullsStyle.Ignore

        ' Draw in "stairs" mode:

        fastLine1.Stairs = True
    End Sub

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>

    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub 'Dispose

#Region "Designer generated code"
    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(FastLine_Nulls))
        Me.fastLine1 = New Steema.TeeChart.Styles.FastLine()
        Me.checkBox1 = New System.Windows.Forms.CheckBox()
        Me.checkBox2 = New System.Windows.Forms.CheckBox()
        Me.checkBox3 = New System.Windows.Forms.CheckBox()
        Me.panel1.SuspendLayout()
        Me.chartContainer.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Text = resources.GetString("textBox1.Text")
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.checkBox3)
        Me.panel1.Controls.Add(Me.checkBox2)
        Me.panel1.Controls.Add(Me.checkBox1)
        Me.panel1.Size = New System.Drawing.Size(440, 55)
        ' 
        ' tChart1
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Header.Lines = New String() {"Fastline series with null points and stairs"}
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Legend.Title.Pen.Visible = False
        Me.tChart1.Legend.Visible = False
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CInt(CByte(254)), CInt(CByte(255)), CInt(CByte(255)), CInt(CByte(255)))
        ' 
        ' 
        ' 
        Me.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(CInt(CByte(254)), CInt(CByte(21)), CInt(CByte(60)), CInt(CByte(89)))
        Me.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CInt(CByte(254)), CInt(CByte(255)), CInt(CByte(255)), CInt(CByte(255)))
        Me.tChart1.Panel.Brush.Gradient.Sigma = True
        Me.tChart1.Panel.Brush.Gradient.SigmaFocus = 1.0F
        Me.tChart1.Panel.Brush.Gradient.SigmaScale = 0.8F
        Me.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CInt(CByte(254)), CInt(CByte(255)), CInt(CByte(255)), CInt(CByte(255)))
        Me.tChart1.Series.Add(Me.fastLine1)
        Me.tChart1.Size = New System.Drawing.Size(440, 189)
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Walls.Back.Brush.Color = System.Drawing.Color.FromArgb(CInt(CByte(76)), CInt(CByte(192)), CInt(CByte(192)), CInt(CByte(192)))
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Walls.Bottom.Brush.Color = System.Drawing.Color.FromArgb(CInt(CByte(178)), CInt(CByte(255)), CInt(CByte(255)), CInt(CByte(255)))
        Me.tChart1.Walls.Bottom.Size = 3
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Walls.Left.Brush.Color = System.Drawing.Color.FromArgb(CInt(CByte(178)), CInt(CByte(255)), CInt(CByte(255)), CInt(CByte(224)))
        Me.tChart1.Walls.Left.Size = 3
        ' 
        ' chartContainer
        ' 
        Me.chartContainer.Location = New System.Drawing.Point(0, 128)
        Me.chartContainer.Size = New System.Drawing.Size(440, 189)
        ' 
        ' fastLine1
        ' 
        Me.fastLine1.ColorEach = False
        Me.fastLine1.IgnoreNulls = False
        ' 
        ' 
        ' 
        Me.fastLine1.LinePen.Color = System.Drawing.Color.FromArgb(CInt(CByte(68)), CInt(CByte(102)), CInt(CByte(163)))
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.fastLine1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None
        Me.fastLine1.Marks.Callout.ArrowHeadSize = 8
        ' 
        ' 
        ' 
        Me.fastLine1.Marks.Callout.Brush.Color = System.Drawing.Color.Black
        Me.fastLine1.Marks.Callout.Distance = 0
        Me.fastLine1.Marks.Callout.Draw3D = False
        Me.fastLine1.Marks.Callout.Length = 10
        Me.fastLine1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.fastLine1.Stairs = True
        Me.fastLine1.Title = "fastLine1"
        Me.fastLine1.TreatNulls = Steema.TeeChart.Styles.TreatNullsStyle.Ignore
        ' 
        ' 
        ' 
        Me.fastLine1.XValues.DataMember = "X"
        Me.fastLine1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' 
        ' 
        Me.fastLine1.YValues.DataMember = "Y"
        ' 
        ' checkBox1
        ' 
        Me.checkBox1.Checked = True
        Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox1.Location = New System.Drawing.Point(16, 16)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(88, 24)
        Me.checkBox1.TabIndex = 0
        Me.checkBox1.Text = "Stairs mode"
        AddHandler Me.checkBox1.CheckedChanged, AddressOf Me.checkBox1_CheckedChanged
        ' 
        ' checkBox2
        ' 
        Me.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox2.Location = New System.Drawing.Point(112, 16)
        Me.checkBox2.Name = "checkBox2"
        Me.checkBox2.Size = New System.Drawing.Size(104, 24)
        Me.checkBox2.TabIndex = 1
        Me.checkBox2.Text = "Inverted stairs"
        AddHandler Me.checkBox2.CheckedChanged, AddressOf Me.checkBox2_CheckedChanged
        ' checkBox3
        ' 
        Me.checkBox3.Checked = True
        Me.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox3.Location = New System.Drawing.Point(240, 16)
        Me.checkBox3.Name = "checkBox3"
        Me.checkBox3.Size = New System.Drawing.Size(104, 24)
        Me.checkBox3.TabIndex = 2
        Me.checkBox3.Text = "Ignore nulls"
        AddHandler Me.checkBox3.CheckedChanged, AddressOf Me.checkBox3_CheckedChanged
        ' 
        ' FastLine_Nulls
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(440, 317)
        Me.Name = "FastLine_Nulls"
        Me.panel1.ResumeLayout(False)
        Me.chartContainer.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub
#End Region
    Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        fastLine1.Stairs = checkBox1.Checked
        checkBox2.Enabled = fastLine1.Stairs
    End Sub

    Private Sub checkBox2_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        fastLine1.InvertedStairs = checkBox2.Checked
    End Sub
    Private Sub checkBox3_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        If (checkBox3.Checked) Then
            fastLine1.TreatNulls = Steema.TeeChart.Styles.TreatNullsStyle.Ignore
        Else
            fastLine1.TreatNulls = Steema.TeeChart.Styles.TreatNullsStyle.DoNotPaint
        End If
        tChart1.Invalidate()
    End Sub

End Class 'FastLine_Nulls