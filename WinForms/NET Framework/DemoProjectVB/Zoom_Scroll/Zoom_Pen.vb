Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Public Class Zoom_Pen
    Inherits Samples.BaseForm
    Private fastLineSeries1 As Steema.TeeChart.Styles.FastLine
    Private button1 As System.Windows.Forms.Button
    Private label1 As System.Windows.Forms.Label
    Private buttonPen1 As Steema.TeeChart.ButtonPen
    Private gridBand1 As Steema.TeeChart.Tools.GridBand
    Private CBHistory As CheckBox
    Private components As System.ComponentModel.IContainer = Nothing
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        Me.fastLineSeries1.FillSampleValues(50)

        Me.tChart1.Zoom.Pen.Color = Color.LightSteelBlue
        Me.tChart1.Zoom.Brush.Color = Color.DarkGray
        Me.tChart1.Zoom.Pen.Width = 2
        tChart1.Zoom.History = True
        ' connect pen, brush to appropriate buttons
        Me.buttonPen1.Pen = Me.tChart1.Zoom.Pen
    End Sub
    
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
    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Zoom_Pen))
        Me.fastLineSeries1 = New Steema.TeeChart.Styles.FastLine()
        Me.button1 = New System.Windows.Forms.Button()
        Me.label1 = New System.Windows.Forms.Label()
        Me.buttonPen1 = New Steema.TeeChart.ButtonPen()
        Me.gridBand1 = New Steema.TeeChart.Tools.GridBand()
        Me.CBHistory = New System.Windows.Forms.CheckBox()
        Me.panel1.SuspendLayout()
        Me.chartContainer.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Size = New System.Drawing.Size(544, 68)
        Me.textBox1.Text = resources.GetString("textBox1.Text")
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.CBHistory)
        Me.panel1.Controls.Add(Me.buttonPen1)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Controls.Add(Me.button1)
        Me.panel1.Location = New System.Drawing.Point(0, 68)
        Me.panel1.Size = New System.Drawing.Size(544, 36)
        ' 
        ' tChart1
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Aspect.View3D = False
        Me.tChart1.Aspect.ZOffset = 0
        Me.tChart1.Cursor = System.Windows.Forms.Cursors.[Default]
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Header.Font.Brush.Color = System.Drawing.Color.FromArgb(CInt(CByte(0)), CInt(CByte(0)), CInt(CByte(0)))
        Me.tChart1.Header.Font.Size = 11
        Me.tChart1.Header.Font.SizeFloat = 11.0F
        Me.tChart1.Header.Lines = New String() {"Zoom history, brush & pen"}
        ' 
        ' 
        ' 
        Me.tChart1.Legend.TextSymbolGap = 0
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
        Me.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(CInt(CByte(128)), CInt(CByte(128)), CInt(CByte(128)))
        Me.tChart1.Series.Add(Me.fastLineSeries1)
        Me.tChart1.Size = New System.Drawing.Size(544, 228)
        Me.tChart1.Tools.Add(Me.gridBand1)
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Walls.Back.Pen.Visible = False
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Walls.Bottom.Pen.Visible = False
        Me.tChart1.Walls.Bottom.Size = 5
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Walls.Left.Pen.Visible = False
        Me.tChart1.Walls.Left.Size = 5
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Zoom.Brush.Color = System.Drawing.Color.FromArgb(CInt(CByte(64)), CInt(CByte(64)), CInt(CByte(64)))
        ' 
        ' chartContainer
        ' 
        Me.chartContainer.Location = New System.Drawing.Point(0, 104)
        Me.chartContainer.Size = New System.Drawing.Size(544, 228)
        ' 
        ' fastLineSeries1
        ' 
        Me.fastLineSeries1.Color = System.Drawing.Color.FromArgb(CInt(CByte(68)), CInt(CByte(102)), CInt(CByte(163)))
        Me.fastLineSeries1.ColorEach = False
        ' 
        ' 
        ' 
        Me.fastLineSeries1.LinePen.Color = System.Drawing.Color.FromArgb(CInt(CByte(68)), CInt(CByte(102)), CInt(CByte(163)))
        Me.fastLineSeries1.LinePen.Width = 2
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.fastLineSeries1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None
        Me.fastLineSeries1.Marks.Callout.ArrowHeadSize = 8
        ' 
        ' 
        ' 
        Me.fastLineSeries1.Marks.Callout.Brush.Color = System.Drawing.Color.Black
        Me.fastLineSeries1.Marks.Callout.Distance = 0
        Me.fastLineSeries1.Marks.Callout.Draw3D = False
        Me.fastLineSeries1.Marks.Callout.Length = 10
        Me.fastLineSeries1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.fastLineSeries1.Marks.Callout.Visible = False
        Me.fastLineSeries1.Title = "fastLineSeries1"
        Me.fastLineSeries1.TreatNulls = Steema.TeeChart.Styles.TreatNullsStyle.Ignore
        ' 
        ' 
        ' 
        Me.fastLineSeries1.XValues.DataMember = "X"
        Me.fastLineSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' 
        ' 
        Me.fastLineSeries1.YValues.DataMember = "Y"
        ' 
        ' button1
        ' 
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.Location = New System.Drawing.Point(233, 5)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(87, 23)
        Me.button1.TabIndex = 0
        Me.button1.Text = "Zoom &brush..."
        AddHandler Me.button1.Click, AddressOf Me.button1_Click


        ' 
        ' label1
        ' 
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
        Me.label1.Location = New System.Drawing.Point(7, 9)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(82, 13)
        Me.label1.TabIndex = 2
        Me.label1.Text = "Drag to zoom"
        Me.label1.UseMnemonic = False
        ' 
        ' buttonPen1
        ' 
        Me.buttonPen1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonPen1.Location = New System.Drawing.Point(133, 5)
        Me.buttonPen1.Name = "buttonPen1"
        Me.buttonPen1.Size = New System.Drawing.Size(87, 23)
        Me.buttonPen1.TabIndex = 3
        Me.buttonPen1.Text = "Zoom &pen..."
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
        ' CBHistory
        ' 
        Me.CBHistory.Checked = True
        Me.CBHistory.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CBHistory.Location = New System.Drawing.Point(361, 9)
        Me.CBHistory.Name = "CBHistory"
        Me.CBHistory.Size = New System.Drawing.Size(137, 17)
        Me.CBHistory.TabIndex = 5
        Me.CBHistory.Text = "Historical unzoom steps"
        Me.CBHistory.TextAlign = System.Drawing.ContentAlignment.MiddleRight
#If VS2005 Then
        Me.CBHistory.AutoSize = True
        Me.CBHistory.UseVisualStyleBackColor = True
#End If

        AddHandler Me.CBHistory.CheckedChanged, AddressOf Me.CBHistory_CheckedChanged

        ' 
        ' Zoom_Pen
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(544, 332)
        Me.Name = "Zoom_Pen"
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.chartContainer.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub
#End Region

    Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim br As New Steema.TeeChart.Editors.BrushEditor(Me.tChart1.Zoom.Brush)
        Try
            br.ShowDialog()
        Finally
            br.Dispose()
        End Try
    End Sub
    Private Sub CBHistory_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
        tChart1.Zoom.History = CBHistory.Checked
    End Sub
End Class 'Zoom_Pen
