Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Public Class Line_ColorEachLine
    Inherits Samples.BaseForm
    Private checkBox1 As System.Windows.Forms.CheckBox
    Private checkBox2 As System.Windows.Forms.CheckBox
    Private components As System.ComponentModel.IContainer = Nothing
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        InitializeChart()
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
        Me.checkBox1 = New System.Windows.Forms.CheckBox()
        Me.checkBox2 = New System.Windows.Forms.CheckBox()
        Me.panel1.SuspendLayout()
        Me.chartContainer.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Size = New System.Drawing.Size(466, 96)
        Me.textBox1.Text = "Line Series in 2D mode can now display points with different colors while drawing" & " Line segments with a single color." & vbCr & vbLf & vbCr & vbLf & "Example: " & vbCr & vbLf & "lineSeries1.ColorEach =true; " & vbCr & vbLf & "lineSeries1.ColorEachLine = false; "
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.checkBox2)
        Me.panel1.Controls.Add(Me.checkBox1)
        Me.panel1.Location = New System.Drawing.Point(0, 96)
        Me.panel1.Size = New System.Drawing.Size(466, 33)
        ' 
        ' tChart1
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Aspect.ZOffset = 0
        Me.tChart1.Size = New System.Drawing.Size(466, 157)
        ' 
        ' chartContainer
        ' 
        Me.chartContainer.Location = New System.Drawing.Point(0, 129)
        Me.chartContainer.Size = New System.Drawing.Size(466, 157)
        ' 
        ' checkBox1
        ' 
        Me.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox1.Location = New System.Drawing.Point(16, 8)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(112, 21)
        Me.checkBox1.TabIndex = 0
        Me.checkBox1.Text = "&Color each line"
        AddHandler Me.checkBox1.CheckedChanged, AddressOf Me.checkBox1_CheckedChanged
        ' 
        ' checkBox2
        ' 
        Me.checkBox2.Checked = True
        Me.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox2.Location = New System.Drawing.Point(127, 8)
        Me.checkBox2.Name = "checkBox2"
        Me.checkBox2.Size = New System.Drawing.Size(113, 21)
        Me.checkBox2.TabIndex = 1
        Me.checkBox2.Text = "Color &each point"
        AddHandler Me.checkBox2.CheckedChanged, AddressOf Me.checkBox2_CheckedChanged
        ' 
        ' Line_ColorEach
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(466, 286)
        Me.Name = "Line_ColorEach"
        Me.panel1.ResumeLayout(False)
        Me.chartContainer.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
#End Region
    Private lineSeries1 As Steema.TeeChart.Styles.Line
    Private gridBand1 As Steema.TeeChart.Tools.GridBand
    Private Sub InitializeChart()
        tChart1.Aspect.View3D = False
        gridBand1 = New Steema.TeeChart.Tools.GridBand()
        tChart1.Tools.Add(gridBand1)
        lineSeries1 = New Steema.TeeChart.Styles.Line()
        tChart1.Series.Add(lineSeries1)
        gridBand1.Axis = tChart1.Axes.Left
        gridBand1.Band1.Color = Color.DarkGray
        gridBand1.Band2.Color = Color.WhiteSmoke
        lineSeries1.ColorEach = True
        lineSeries1.ColorEachLine = False
        Me.lineSeries1.FillSampleValues(25)
        Me.lineSeries1.Pointer.Visible = True
    End Sub
    Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.lineSeries1.ColorEachLine = Me.checkBox1.Checked
    End Sub

    Private Sub checkBox2_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.lineSeries1.ColorEach = Me.checkBox2.Checked
    End Sub
End Class
