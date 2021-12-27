Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Public Class Box_CustomValues
    Inherits Samples.BaseForm
    Private checkBox1 As System.Windows.Forms.CheckBox
    Private label1 As System.Windows.Forms.Label
    Private label2 As System.Windows.Forms.Label
    Private label3 As System.Windows.Forms.Label
    Private label4 As System.Windows.Forms.Label
    Private box1 As Steema.TeeChart.Styles.Box
    Private gridBand1 As Steema.TeeChart.Tools.GridBand
    Private components As System.ComponentModel.IContainer = Nothing
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' add sample data
        box1.Clear()
        box1.Add(New Double(10) {35, 36, 37, 38, 38, 39, 39, 40, 41, 44, 61})
        ' the values aren't actualy calculated before series is drawn
        ' so if you need them before, just call ReconstructFromData() method
        box1.ReconstructFromData()
    End Sub 'New
    Private Sub UpdateDisplay()
        label1.Text = "Median = " + box1.Median.ToString("0.00")
        label2.Text = "Inner Fences = [" + box1.InnerFence1.ToString("0.00") + " ; " + box1.InnerFence3.ToString("0.00") + "]"
        label3.Text = "Outer Fences = [" + box1.OuterFence1.ToString("0.00") + " ; " + box1.OuterFence3.ToString("0.00") + "]"
        label4.Text = "Adjacent Points = [" + box1.AdjacentPoint1.ToString("0.00") + " ; " + box1.AdjacentPoint3.ToString("0.00") + "]"
    End Sub 'UpdateDisplay

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
        Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Box_CustomValues))
        Me.checkBox1 = New System.Windows.Forms.CheckBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.box1 = New Steema.TeeChart.Styles.Box()
        Me.gridBand1 = New Steema.TeeChart.Tools.GridBand()
        Me.panel1.SuspendLayout()
        Me.chartContainer.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Size = New System.Drawing.Size(466, 48)
        Me.textBox1.Text = "Now you can fully customize all TBoxPlotSeries parameters. All you must do is set" & " UseCustomValues property to True and then pass your values to Quartile, InnerFe" & "nce and OuterFence properties."
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.label4)
        Me.panel1.Controls.Add(Me.label3)
        Me.panel1.Controls.Add(Me.label2)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Controls.Add(Me.checkBox1)
        Me.panel1.Location = New System.Drawing.Point(0, 48)
        Me.panel1.Size = New System.Drawing.Size(466, 81)
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
        Me.tChart1.Axes.Bottom.MaximumOffset = 16
        Me.tChart1.Axes.Bottom.MinimumOffset = 16
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Left.MaximumOffset = 16
        Me.tChart1.Axes.Left.MinimumOffset = 16
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Left.MinorTicks.Visible = False
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Header.Font.Bold = True
        Me.tChart1.Header.Font.Size = 7
        Me.tChart1.Header.Font.SizeFloat = 7.0F
        Me.tChart1.Header.Lines = New String() {"BoxPlot series example"}
        ' 
        ' 
        ' 
        Me.tChart1.Legend.Visible = False
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CInt(CByte((254))), CInt(CByte((255))), CInt(CByte((255))), CInt(CByte((255))))
        Me.tChart1.Series.Add(Me.box1)
        Me.tChart1.Size = New System.Drawing.Size(466, 157)
        Me.tChart1.Tools.Add(Me.gridBand1)
        ' 
        ' chartContainer
        ' 
        Me.chartContainer.Location = New System.Drawing.Point(0, 129)
        Me.chartContainer.Size = New System.Drawing.Size(466, 157)
        ' 
        ' checkBox1
        ' 
        Me.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox1.Location = New System.Drawing.Point(24, 8)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(120, 16)
        Me.checkBox1.TabIndex = 0
        Me.checkBox1.Text = "Custom values"
        AddHandler Me.checkBox1.CheckedChanged, AddressOf Me.checkBox1_CheckedChanged
        ' 
        ' label1
        ' 
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(184, 8)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(45, 13)
        Me.label1.TabIndex = 1
        Me.label1.Text = "Median:"
        ' 
        ' label2
        ' 
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(184, 24)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(87, 13)
        Me.label2.TabIndex = 2
        Me.label2.Text = "Inner Fences = []"
        ' 
        ' label3
        ' 
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(184, 40)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(89, 13)
        Me.label3.TabIndex = 3
        Me.label3.Text = "Outer Fences = []"
        ' 
        ' label4
        ' 
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(184, 56)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(98, 13)
        Me.label4.TabIndex = 4
        Me.label4.Text = "Adjacent points = []"
        ' 
        ' box1
        ' 
        Me.box1.AdjacentPoint3 = 5
        Me.box1.Color = System.Drawing.Color.FromArgb(CInt(CByte((178))), CInt(CByte((255))), CInt(CByte((0))), CInt(CByte((0))))
        Me.box1.ColorEach = False
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.box1.ExtrOut.Brush.Color = System.Drawing.Color.FromArgb(CInt(CByte((254))), CInt(CByte((255))), CInt(CByte((255))), CInt(CByte((255))))
        Me.box1.ExtrOut.Style = Steema.TeeChart.Styles.PointerStyles.Star
        Me.box1.InnerFence1 = -3.5
        Me.box1.InnerFence3 = 8.5
        ' 
        ' 
        ' 
        Me.box1.LinePen.Color = System.Drawing.Color.FromArgb(CInt(CByte((178))), CInt(CByte((153))), CInt(CByte((0))), CInt(CByte((0))))
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.box1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None
        Me.box1.Marks.Callout.ArrowHeadSize = 8
        ' 
        ' 
        ' 
        Me.box1.Marks.Callout.Brush.Color = System.Drawing.Color.Black
        Me.box1.Marks.Callout.Distance = 0
        Me.box1.Marks.Callout.Draw3D = False
        Me.box1.Marks.Callout.Length = 0
        Me.box1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.box1.Marks.Callout.Visible = False
        Me.box1.Median = 2.5
        ' 
        ' 
        ' 
        Me.box1.MedianPen.Style = System.Drawing.Drawing2D.DashStyle.Dot
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.box1.MildOut.Brush.Color = System.Drawing.Color.FromArgb(CInt(CByte((254))), CInt(CByte((255))), CInt(CByte((255))), CInt(CByte((255))))
        Me.box1.MildOut.Style = Steema.TeeChart.Styles.PointerStyles.Circle
        Me.box1.OuterFence1 = -8
        Me.box1.OuterFence3 = 13
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.box1.Pointer.Brush.Color = System.Drawing.Color.FromArgb(CInt(CByte((178))), CInt(CByte((255))), CInt(CByte((0))), CInt(CByte((0))))
        Me.box1.Pointer.Brush.ForegroundColor = System.Drawing.Color.Empty
        ' 
        ' 
        ' 
        Me.box1.Pointer.Brush.Gradient.StartColor = System.Drawing.Color.White
        Me.box1.Pointer.Brush.Gradient.Transparency = 30
        Me.box1.Pointer.Draw3D = False
        Me.box1.Pointer.HorizSize = 15
        ' 
        ' 
        ' 
        Me.box1.Pointer.Pen.Color = System.Drawing.Color.FromArgb(CInt(CByte((178))), CInt(CByte((153))), CInt(CByte((0))), CInt(CByte((0))))
        Me.box1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.box1.Pointer.VertSize = 15
        Me.box1.Quartile1 = 1
        Me.box1.Quartile3 = 4
        Me.box1.Title = "box1"
        ' 
        ' 
        ' 
        Me.box1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' gridBand1
        ' 
        Me.gridBand1.Axis = Me.tChart1.Axes.Left
        ' 
        ' 
        ' 
        Me.gridBand1.Band1.Color = System.Drawing.Color.FromArgb(CInt(CByte((254))), CInt(CByte((224))), CInt(CByte((224))), CInt(CByte((224))))
        ' 
        ' 
        ' 
        Me.gridBand1.Band2.Color = System.Drawing.Color.FromArgb(CInt(CByte((254))), CInt(CByte((255))), CInt(CByte((255))), CInt(CByte((255))))
        ' 
        ' Box_CustomValues
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(466, 286)
        Me.Name = "Box_CustomValues"
        AddHandler Me.Load, AddressOf Me.Box_CustomValues_Load
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.chartContainer.ResumeLayout(False)
        Me.ResumeLayout(False)

        Me.PerformLayout()
    End Sub
#End Region

    Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        box1.UseCustomValues = checkBox1.Checked
        box1.Clear()
        If box1.UseCustomValues Then
            box1.UseCustomValues = True
            box1.Median = 38
            box1.Quartile1 = 37.25
            box1.Quartile3 = 40.75
            ' adjacent points are related with whisker lines
            box1.AdjacentPoint1 = 37 ' lower whisker at 37
            box1.AdjacentPoint3 = 43 ' upper whisker at 43
            ' using this all added points will be extreme outliers
            box1.InnerFence1 = 39
            box1.InnerFence3 = 39
            box1.OuterFence1 = 39
            box1.OuterFence3 = 39
            ' add outliers
            box1.Add(New Single(3) {35, 36, 44, 61})
        Else
            box1.Add(New Double(10) {35, 36, 37, 38, 38, 39, 39, 40, 41, 44, 61}) ' re-add everything
            box1.ReconstructFromData()
        End If
        UpdateDisplay()
    End Sub 'checkBox1_CheckedChanged


    Private Sub Box_CustomValues_Load(ByVal sender As Object, ByVal e As System.EventArgs)
        UpdateDisplay()
    End Sub 'Box_CustomValues_Load
End Class 'BoxSeries_CustomValues 