Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Public Class Axes_GridBandsCentered
    Inherits BaseForm
    Private horizBar1 As Steema.TeeChart.Styles.HorizBar
    Private button1 As System.Windows.Forms.Button
    Private button2 As System.Windows.Forms.Button
    Private checkBox1 As System.Windows.Forms.CheckBox
    Private checkBox2 As CheckBox
    Private gridBand1 As Steema.TeeChart.Tools.GridBand
    Private components As System.ComponentModel.IContainer = Nothing
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        'This call is required by the Windows Form Designer.
        horizBar1 = New Steema.TeeChart.Styles.HorizBar
        InitializeComponent()
        tChart1.Series.Add(horizBar1)
        horizBar1.FillSampleValues()
        horizBar1.BarHeightPercent = 55
        horizBar1.Gradient.Visible = True
        horizBar1.Gradient.Direction = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        horizBar1.Marks.Transparent = True
        horizBar1.MarksOnBar = True
        horizBar1.Pen.Visible = False
        tChart1.Axes.Left.Grid.Centered = True
    End Sub
    '<summary>
    ' Clean up any resources being used.
    '</summary>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If (Not (components) Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub
#Region "Designer generated code"
    Private Sub InitializeComponent()
        Me.button1 = New System.Windows.Forms.Button
        Me.button2 = New System.Windows.Forms.Button
        Me.checkBox1 = New System.Windows.Forms.CheckBox
        Me.checkBox2 = New System.Windows.Forms.CheckBox
        Me.gridBand1 = New Steema.TeeChart.Tools.GridBand
        Me.panel1.SuspendLayout()
        Me.chartContainer.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Text = ("Grid bands will be centered if CenteredGrid property is set to True for the Axis." + "")
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.checkBox2)
        Me.panel1.Controls.Add(Me.checkBox1)
        Me.panel1.Controls.Add(Me.button2)
        Me.panel1.Controls.Add(Me.button1)
        ' 
        ' tChart1
        '    
        Me.tChart1.Aspect.View3D = False
        Me.tChart1.Aspect.ZOffset = 0
        Me.tChart1.Axes.Left.Grid.Color = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tChart1.Axes.Left.Grid.Visible = False
        Me.tChart1.Header.Lines = New String() {"Axes Grid Bands Centered"}
        Me.tChart1.Legend.Font.Brush.Color = System.Drawing.Color.Blue
        Me.tChart1.Legend.Visible = False
        Me.tChart1.Panel.Bevel.Inner = Steema.TeeChart.Drawing.BevelStyles.Raised
        Me.tChart1.Panel.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.Lowered
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tChart1.Size = New System.Drawing.Size(440, 205)
        Me.tChart1.Tools.Add(Me.gridBand1)
        Me.tChart1.Walls.Back.Pen.Visible = False
        Me.tChart1.Walls.Bottom.Pen.Visible = False
        Me.tChart1.Walls.Bottom.Size = 4
        Me.tChart1.Walls.Left.Pen.Visible = False
        Me.tChart1.Walls.Left.Size = 4
        ' 
        ' button1
        ' 
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.Location = New System.Drawing.Point(24, 8)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(75, 23)
        Me.button1.TabIndex = 0
        Me.button1.Text = "Band 1..."
        AddHandler button1.Click, AddressOf Me.button1_Click
        ' 
        ' button2
        ' 
        Me.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button2.Location = New System.Drawing.Point(120, 8)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(75, 23)
        Me.button2.TabIndex = 1
        Me.button2.Text = "Band 2..."
        AddHandler button2.Click, AddressOf Me.button2_Click
        ' 
        ' checkBox1
        ' 
        Me.checkBox1.Location = New System.Drawing.Point(202, 9)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(78, 24)
        Me.checkBox1.TabIndex = 2
        Me.checkBox1.Text = "View 3D"
        AddHandler checkBox1.Click, AddressOf Me.checkBox1_Click
        ' 
        ' checkBox2
        ' 
        Me.checkBox2.Checked = True
        Me.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox2.Location = New System.Drawing.Point(287, 9)
        Me.checkBox2.Name = "checkBox2"
        Me.checkBox2.Size = New System.Drawing.Size(141, 24)
        Me.checkBox2.TabIndex = 3
        Me.checkBox2.Text = "Axes Left grid centered"
        AddHandler checkBox2.CheckedChanged, AddressOf Me.checkBox2_CheckedChanged
        ' 
        ' gridBand1
        ' 
        Me.gridBand1.Axis = Me.tChart1.Axes.Left
        ' 
        ' 
        ' 
        Me.gridBand1.Band1.Color = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        ' 
        ' 
        ' 
        Me.gridBand1.Band2.Color = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        ' 
        ' Axes_GridBandsCentered
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(440, 317)
        Me.Name = "Axes_GridBandsCentered"
        Me.panel1.ResumeLayout(False)
        Me.chartContainer.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub
#End Region

    Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Steema.TeeChart.Editors.BrushEditor.Edit(gridBand1.Band1, True)
        tChart1.Invalidate()
    End Sub

    Private Sub button2_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Steema.TeeChart.Editors.BrushEditor.Edit(gridBand1.Band2, True)
        tChart1.Invalidate()
    End Sub

    Private Sub checkBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        tChart1.Aspect.View3D = checkBox1.Checked
    End Sub

    Private Sub checkBox2_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
        tChart1.Axes.Left.GridCentered = checkBox2.Checked
    End Sub
End Class