
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing

Imports System.Windows.Forms




Public Class SeriesType_Tower
    Inherits Steema.TeeChart.Samples.BaseForm
    Private towerSeries1 As Steema.TeeChart.Styles.Tower
    Private button1 As System.Windows.Forms.Button
    Private label1 As System.Windows.Forms.Label
    Private comboBox1 As System.Windows.Forms.ComboBox
    Private checkBox1 As System.Windows.Forms.CheckBox
    Private gridBand1 As Steema.TeeChart.Tools.GridBand
    Private components As System.ComponentModel.IContainer = Nothing
    
    
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        
        Dim r As New Random(1000)
        Me.towerSeries1.Clear()
        For x As Integer = 1 To 10
            For z As Integer = 1 To 10
                Me.towerSeries1.Add(x, r.Next(1000) - 100, z)
            Next z
        Next x

        ' example:
        Me.towerSeries1.Origin = 500
        Me.towerSeries1.UseOrigin = True
        
        comboBox1.Items.Clear()
        comboBox1.Items.AddRange([Enum].GetNames(GetType(Styles.TowerStyles)))
        comboBox1.SelectedItem = Styles.TowerStyles.Cube.ToString()
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
        Me.towerSeries1 = New Steema.TeeChart.Styles.Tower
        Me.button1 = New System.Windows.Forms.Button
        Me.label1 = New System.Windows.Forms.Label
        Me.comboBox1 = New System.Windows.Forms.ComboBox
        Me.checkBox1 = New System.Windows.Forms.CheckBox
        Me.gridBand1 = New Steema.TeeChart.Tools.GridBand
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(488, 49)
        Me.textBox1.Text = ("Tower series displays bars in 3D grid mode. Several properties configure the aspe" + "ct and size of each bar.")
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.checkBox1)
        Me.panel1.Controls.Add(Me.comboBox1)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Controls.Add(Me.button1)
        Me.panel1.Location = New System.Drawing.Point(0, 49)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(488, 39)
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
        Me.tChart1.Header.Lines = New String() {"tChart1"}
        ' 
        ' tChart1.Legend
        ' 
        Me.tChart1.Legend.MaxNumRows = 8
        Me.tChart1.Location = New System.Drawing.Point(0, 88)
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Brush
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(254, Byte), CType(255, Byte), CType(255, Byte), CType(255, Byte))
        Me.tChart1.Series.Add(Me.towerSeries1)
        Me.tChart1.Size = New System.Drawing.Size(488, 245)
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
        Me.tChart1.Walls.Bottom.Size = 5
        ' 
        ' tChart1.Walls.Left
        ' 
        ' 
        ' tChart1.Walls.Left.Pen
        ' 
        Me.tChart1.Walls.Left.Pen.Visible = False
        Me.tChart1.Walls.Left.Size = 5
        ' 
        ' towerSeries1
        ' 
        ' 
        ' towerSeries1.Brush
        ' 
        Me.towerSeries1.Brush.Color = System.Drawing.Color.Red
        ' 
        ' towerSeries1.Marks
        ' 
        ' 
        ' towerSeries1.Marks.Symbol
        ' 
        ' 
        ' towerSeries1.Marks.Symbol.Shadow
        ' 
        Me.towerSeries1.Marks.Symbol.Shadow.Height = 1
        Me.towerSeries1.Marks.Symbol.Shadow.Visible = True
        Me.towerSeries1.Marks.Symbol.Shadow.Width = 1
        Me.towerSeries1.NumXValues = 25
        Me.towerSeries1.NumZValues = 25
        Me.towerSeries1.Origin = 0
        Me.towerSeries1.PaletteMin = 0
        Me.towerSeries1.PaletteStep = 0
        Me.towerSeries1.Title = "towerSeries1"
        Me.towerSeries1.UseColorRange = False
        Me.towerSeries1.UsePalette = True
        ' 
        ' towerSeries1.XValues
        ' 
        Me.towerSeries1.XValues.DataMember = "X"
        ' 
        ' towerSeries1.YValues
        ' 
        Me.towerSeries1.YValues.DataMember = "Y"
        ' 
        ' towerSeries1.ZValues
        ' 
        Me.towerSeries1.ZValues.DataMember = "Z"
        ' 
        ' button1
        ' 
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.Location = New System.Drawing.Point(8, 7)
        Me.button1.Name = "button1"
        Me.button1.TabIndex = 0
        Me.button1.Text = "&Edit..."
        AddHandler button1.Click, AddressOf Me.button1_Click
        ' 
        ' label1
        ' 
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(114, 10)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(33, 16)
        Me.label1.TabIndex = 1
        Me.label1.Text = "&Style:"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        ' 
        ' comboBox1
        ' 
        Me.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboBox1.Items.AddRange(New Object() {"Cube", "Rectangle", "Cover", "Cylinder", "Arrow", "Cone"})
        Me.comboBox1.Location = New System.Drawing.Point(153, 8)
        Me.comboBox1.Name = "comboBox1"
        Me.comboBox1.Size = New System.Drawing.Size(101, 21)
        Me.comboBox1.TabIndex = 2
        AddHandler comboBox1.SelectedIndexChanged, AddressOf Me.comboBox1_SelectedIndexChanged
        ' 
        ' checkBox1
        ' 
        Me.checkBox1.Checked = True
        Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox1.Location = New System.Drawing.Point(293, 8)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(87, 21)
        Me.checkBox1.TabIndex = 3
        Me.checkBox1.Text = "&Use origin"
        AddHandler checkBox1.CheckedChanged, AddressOf Me.checkBox1_CheckedChanged
        ' 
        ' gridBand1
        ' 
        Me.gridBand1.Axis = Me.tChart1.Axes.Left
        ' 
        ' gridBand1.Band1
        ' 
        Me.gridBand1.Band1.Color = System.Drawing.Color.FromArgb(CType(127, Byte), CType(224, Byte), CType(224, Byte), CType(224, Byte))
        ' 
        ' gridBand1.Band2
        ' 
        Me.gridBand1.Band2.Color = System.Drawing.Color.FromArgb(CType(127, Byte), CType(255, Byte), CType(255, Byte), CType(255, Byte))
        ' 
        ' SeriesType_Tower
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(488, 333)
        Me.Name = "SeriesType_Tower"
        AddHandler Load, AddressOf Me.SeriesType_Tower_Load
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub 'InitializeComponent 
#End Region


    Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        TeeChart.Editors.SeriesEditor.ShowEditor(Me.towerSeries1)
    End Sub 'button1_Click


    Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.towerSeries1.UseOrigin = Me.checkBox1.Checked
    End Sub 'checkBox1_CheckedChanged


    Private Sub comboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.towerSeries1.TowerStyle = CType(Me.comboBox1.SelectedIndex, Steema.TeeChart.Styles.TowerStyles)
    End Sub 'comboBox1_SelectedIndexChanged


    Private Sub SeriesType_Tower_Load(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.comboBox1.SelectedIndex = 0
    End Sub 'SeriesType_Tower_Load
End Class 'SeriesType_Tower
