Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Public Class Line_Clickable
    Inherits Samples.BaseForm
    Private lineSeries1 As Steema.TeeChart.Styles.Line
    Private checkBox1 As System.Windows.Forms.CheckBox
    Private label1 As System.Windows.Forms.Label
    Private gridBand1 As Steema.TeeChart.Tools.GridBand
    Private components As System.ComponentModel.IContainer = Nothing
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        Me.lineSeries1.FillSampleValues(20)
        Me.lineSeries1.Pointer.Visible = True
        Me.lineSeries1.ClickableLine = True
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
        Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Line_Clickable))
        Me.lineSeries1 = New Steema.TeeChart.Styles.Line()
        Me.checkBox1 = New System.Windows.Forms.CheckBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.gridBand1 = New Steema.TeeChart.Tools.GridBand()
        Me.panel1.SuspendLayout()
        Me.chartContainer.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Size = New System.Drawing.Size(466, 63)
        Me.textBox1.Text = resources.GetString("textBox1.Text")
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Controls.Add(Me.checkBox1)
        Me.panel1.Location = New System.Drawing.Point(0, 63)
        Me.panel1.Size = New System.Drawing.Size(466, 33)
        ' 
        ' tChart1
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Aspect.View3D = False
        Me.tChart1.Aspect.ZOffset = 0
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Bottom.MaximumOffset = 5
        Me.tChart1.Axes.Bottom.MinimumOffset = 5
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Left.MaximumOffset = 5
        Me.tChart1.Axes.Left.MinimumOffset = 5
        ' 
        ' 
        ' 
        Me.tChart1.Header.Lines = New String() {"Line : clickable lines"}
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Series.Add(Me.lineSeries1)
        Me.tChart1.Size = New System.Drawing.Size(466, 190)
        Me.tChart1.Tools.Add(Me.gridBand1)
        AddHandler Me.tChart1.MouseMove, AddressOf Me.tChart1_MouseMove
        ' 
        ' chartContainer
        ' 
        Me.chartContainer.Location = New System.Drawing.Point(0, 96)
        Me.chartContainer.Size = New System.Drawing.Size(466, 190)
        ' 
        ' lineSeries1
        ' 
        ' 
        ' 
        ' 
        Me.lineSeries1.ColorEach = False
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.lineSeries1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None
        Me.lineSeries1.Marks.Callout.ArrowHeadSize = 8
        ' 
        ' 
        ' 
        Me.lineSeries1.Marks.Callout.Brush.Color = System.Drawing.Color.Black
        Me.lineSeries1.Marks.Callout.Distance = 0
        Me.lineSeries1.Marks.Callout.Draw3D = False
        Me.lineSeries1.Marks.Callout.Length = 10
        Me.lineSeries1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.lineSeries1.Marks.Callout.Visible = False
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.lineSeries1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.lineSeries1.Pointer.Visible = True
        Me.lineSeries1.Title = "lineSeries1"
        ' 
        ' 
        ' 
        Me.lineSeries1.XValues.DataMember = "X"
        Me.lineSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' 
        ' 
        Me.lineSeries1.YValues.DataMember = "Y"
        ' 
        ' checkBox1
        ' 
        Me.checkBox1.Checked = True
        Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox1.Location = New System.Drawing.Point(8, 5)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(112, 21)
        Me.checkBox1.TabIndex = 0
        Me.checkBox1.Text = "&Clickable line"
        AddHandler Me.checkBox1.CheckedChanged, AddressOf Me.checkBox1_CheckedChanged
        ' 
        ' label1
        ' 
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(200, 8)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(46, 13)
        Me.label1.TabIndex = 1
        Me.label1.Text = "Point : ?"
        Me.label1.UseMnemonic = False
        ' 
        ' gridBand1
        ' 
        Me.gridBand1.Axis = Me.tChart1.Axes.Left
        ' 
        ' 
        ' 
        Me.gridBand1.Band1.Color = System.Drawing.Color.FromArgb(CInt(CByte(127)), CInt(CByte(224)), CInt(CByte(224)), CInt(CByte(224)))
        ' 
        ' 
        ' 
        Me.gridBand1.Band2.Color = System.Drawing.Color.FromArgb(CInt(CByte(127)), CInt(CByte(255)), CInt(CByte(255)), CInt(CByte(255)))
        ' 
        ' Line_Clickable
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(466, 286)
        Me.Name = "Line_Clickable"
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.chartContainer.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
#End Region

    Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.lineSeries1.ClickableLine = Me.checkBox1.Checked
    End Sub

    Private Sub tChart1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)

        Dim tmp As Integer = Me.lineSeries1.Clicked(e.X, e.Y)
        If tmp <> -1 Then
            Me.label1.Text = "Point : " + tmp.ToString()
        Else
            Me.label1.Text = "Point : ?"
        End If
    End Sub
End Class 'Line_Clickable
