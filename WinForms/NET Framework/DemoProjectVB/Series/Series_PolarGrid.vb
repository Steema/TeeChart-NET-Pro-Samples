Public Class Series_PolarGrid
    Inherits BaseForm

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        tChart1.Clear()
        'This call is required by the Windows Form Designer.
        InitializeComponent()

        tChart1.Legend.Visible = False
        tChart1.Aspect.View3D = False
        PolarGrid1.FillSampleValues(10)
        PolarGrid1.CircleLabels = True
        PolarGrid1.CircleLabelsInside = False

    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents PolarGrid1 As Steema.TeeChart.Styles.PolarGrid
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents NumericUpDown2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.PolarGrid1 = New Steema.TeeChart.Styles.PolarGrid
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.CheckBox2 = New System.Windows.Forms.CheckBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.panel1.SuspendLayout()
        Me.chartContainer.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tChart1
        '
        Me.tChart1.Location = New System.Drawing.Point(0, 0)
        Me.tChart1.Name = "tChart1"
        Me.tChart1.Series.Add(Me.PolarGrid1)
        Me.tChart1.Size = New System.Drawing.Size(488, 278)
        '
        'textBox1
        '
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(488, 73)
        Me.textBox1.Text = "Displays an array of values as a circular grid of cells, very similar to a for ex" & _
        "ample" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "hard disk plate with sectors and tracks. Use the AddCell method to popula" & _
        "te " & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "series with data."
        '
        'panel1
        '
        Me.panel1.Controls.Add(Me.Button1)
        Me.panel1.Controls.Add(Me.CheckBox2)
        Me.panel1.Controls.Add(Me.CheckBox1)
        Me.panel1.Controls.Add(Me.NumericUpDown2)
        Me.panel1.Controls.Add(Me.NumericUpDown1)
        Me.panel1.Controls.Add(Me.Label2)
        Me.panel1.Controls.Add(Me.Label1)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(488, 63)
        '
        'chartContainer
        '
        Me.chartContainer.Location = New System.Drawing.Point(0, 136)
        Me.chartContainer.Name = "chartContainer"
        Me.chartContainer.Size = New System.Drawing.Size(488, 278)
        '
        'PolarGrid1
        '
        '
        'PolarGrid1.Brush
        '
        Me.PolarGrid1.Brush.Color = System.Drawing.Color.FromArgb(CType(68, Byte), CType(102, Byte), CType(163, Byte))
        Me.PolarGrid1.ColorEach = False
        '
        'PolarGrid1.Pen
        '
        Me.PolarGrid1.Pen.Color = System.Drawing.Color.FromArgb(CType(68, Byte), CType(102, Byte), CType(163, Byte))
        '
        'PolarGrid1.Pointer
        '
        Me.PolarGrid1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.PolarGrid1.RotationAngle = 90
        Me.PolarGrid1.Title = "polarGrid1"
        '
        'PolarGrid1.XValues
        '
        Me.PolarGrid1.XValues.DataMember = "Sectors"
        '
        'PolarGrid1.YValues
        '
        Me.PolarGrid1.YValues.DataMember = "Tracks"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sectors"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tracks"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(72, 8)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(72, 20)
        Me.NumericUpDown1.TabIndex = 2
        Me.NumericUpDown1.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.Location = New System.Drawing.Point(72, 32)
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.Size = New System.Drawing.Size(72, 20)
        Me.NumericUpDown2.TabIndex = 3
        Me.NumericUpDown2.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'CheckBox1
        '
        Me.CheckBox1.Location = New System.Drawing.Point(160, 8)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(88, 24)
        Me.CheckBox1.TabIndex = 4
        Me.CheckBox1.Text = "Clockwise"
        '
        'CheckBox2
        '
        Me.CheckBox2.Location = New System.Drawing.Point(256, 9)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(80, 24)
        Me.CheckBox2.TabIndex = 5
        Me.CheckBox2.Text = "Axis on to"
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(344, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Edit..."
        '
        'Series_PolarGrid
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(488, 414)
        Me.Name = "Series_PolarGrid"
        Me.Text = "Series_PolarGrid"
        Me.panel1.ResumeLayout(False)
        Me.chartContainer.ResumeLayout(False)
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Steema.TeeChart.Editors.SeriesEditor.ShowEditor(PolarGrid1)
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        PolarGrid1.ClockWiseLabels = CheckBox1.Checked
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        tChart1.Axes.DrawBehind = Not CheckBox2.Checked
    End Sub

    Private Sub NumericUpDown1_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles NumericUpDown1.ValueChanged
        PolarGrid1.NumSectors = CType(NumericUpDown1.Value, Integer)
        PolarGrid1.NumTracks = CType(NumericUpDown2.Value, Integer)
        PolarGrid1.Clear()
        PolarGrid1.BeginUpdate()
        Dim tmp As Double
        Dim sector As Integer = 0
        Do While (sector < PolarGrid1.NumSectors)
            Dim track As Integer = 0
            Do While (track < PolarGrid1.NumTracks)
                tmp = ((0.5 * Math.Pow(Math.Cos((sector _
                                    / (PolarGrid1.NumSectors * 0.2))), 2)) _
                            + (Math.Pow(Math.Cos((track _
                                    / (PolarGrid1.NumTracks * 0.2))), 2) - Math.Cos((track _
                                / (PolarGrid1.NumTracks * 0.5)))))
                PolarGrid1.AddCell(sector, track, tmp)
                track = (track + 1)
            Loop
            sector = (sector + 1)
        Loop
        PolarGrid1.EndUpdate()
    End Sub
End Class
