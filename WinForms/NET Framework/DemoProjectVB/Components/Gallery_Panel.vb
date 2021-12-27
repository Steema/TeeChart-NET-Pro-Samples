
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms



Public Class Gallery_Panel
    Inherits Steema.TeeChart.Samples.BaseNoChart
    Private WithEvents galleryPanel1 As Steema.TeeChart.GalleryPanel
    Private tChart1 As Steema.TeeChart.TChart
    Private lineSeries1 As Steema.TeeChart.Styles.Line
    Private ganttTool1 As Steema.TeeChart.Tools.GanttTool
    Private components As System.ComponentModel.IContainer = Nothing
    
    
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        
        lineSeries1.FillSampleValues(10)
        
        galleryPanel1.NumRows = 3
        galleryPanel1.NumCols = 2
        
        galleryPanel1.CreateGallerySeries(GetType(TeeChart.Styles.Line))
        galleryPanel1.CreateGallerySeries(GetType(TeeChart.Styles.Bar))
        galleryPanel1.CreateGallerySeries(GetType(TeeChart.Styles.Points))
        galleryPanel1.CreateGallerySeries(GetType(TeeChart.Styles.Area))
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
        Me.galleryPanel1 = New Steema.TeeChart.GalleryPanel
        Me.tChart1 = New Steema.TeeChart.TChart
        Me.lineSeries1 = New Steema.TeeChart.Styles.Line
        Me.ganttTool1 = New Steema.TeeChart.Tools.GanttTool
        Me.panel2.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(426, 40)
        Me.textBox1.Text = "GalleryPanel control displays chart styles."
        ' 
        ' panel1
        ' 
        Me.panel1.Location = New System.Drawing.Point(0, 40)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(426, 36)
        ' 
        ' panel2
        ' 
        Me.panel2.Controls.Add(Me.tChart1)
        Me.panel2.Controls.Add(Me.galleryPanel1)
        Me.panel2.Location = New System.Drawing.Point(0, 76)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(426, 182)
        ' 
        ' galleryPanel1
        ' 
        Me.galleryPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.galleryPanel1.Location = New System.Drawing.Point(0, 0)
        Me.galleryPanel1.Name = "galleryPanel1"
        Me.galleryPanel1.Size = New System.Drawing.Size(167, 182)
        Me.galleryPanel1.TabIndex = 0
        ' 
        ' tChart1
        ' 
        ' 
        ' tChart1.Aspect
        ' 
        Me.tChart1.Aspect.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality
        Me.tChart1.Aspect.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        ' 
        ' tChart1.Axes
        ' 
        ' 
        ' tChart1.Axes.Bottom
        ' 
        Me.tChart1.Axes.Bottom.Increment = 14.4
        Me.tChart1.Dock = System.Windows.Forms.DockStyle.Fill
        ' 
        ' tChart1.Header
        ' 
        Me.tChart1.Header.Lines = New String() {"tChart1"}
        ' 
        ' tChart1.Legend
        ' 
        Me.tChart1.Legend.Visible = False
        Me.tChart1.Location = New System.Drawing.Point(167, 0)
        Me.tChart1.Name = "tChart1"
        Me.tChart1.Series.Add(Me.lineSeries1)
        Me.tChart1.Size = New System.Drawing.Size(259, 182)
        Me.tChart1.TabIndex = 1
        Me.tChart1.Tools.Add(Me.ganttTool1)
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
        Me.tChart1.Walls.Bottom.Size = 3
        ' 
        ' tChart1.Walls.Left
        ' 
        ' 
        ' tChart1.Walls.Left.Pen
        ' 
        Me.tChart1.Walls.Left.Pen.Visible = False
        Me.tChart1.Walls.Left.Size = 3
        ' 
        ' lineSeries1
        ' 
        ' 
        ' lineSeries1.Brush
        ' 
        Me.lineSeries1.Brush.Color = System.Drawing.Color.Red
        ' 
        ' lineSeries1.Gradient
        ' 
        Me.lineSeries1.Brush.Gradient.Visible = True
        Me.lineSeries1.Brush.Solid = False
        Me.lineSeries1.Cursor = System.Windows.Forms.Cursors.Cross
        ' 
        ' lineSeries1.Gradient
        ' 
        Me.lineSeries1.Gradient.Visible = True
        ' 
        ' lineSeries1.Marks
        ' 
        ' 
        ' lineSeries1.Marks.Symbol
        ' 
        ' 
        ' lineSeries1.Marks.Symbol.Shadow
        ' 
        Me.lineSeries1.Marks.Symbol.Shadow.Height = 1
        Me.lineSeries1.Marks.Symbol.Shadow.Visible = True
        Me.lineSeries1.Marks.Symbol.Shadow.Width = 1
        ' 
        ' lineSeries1.Pointer
        ' 
        ' 
        ' lineSeries1.Pointer.Brush
        ' 
        Me.lineSeries1.Pointer.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(0, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        Me.lineSeries1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.lineSeries1.Title = "lineSeries1"
        ' 
        ' lineSeries1.XValues
        ' 
        Me.lineSeries1.XValues.DataMember = "X"
        Me.lineSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' lineSeries1.YValues
        ' 
        Me.lineSeries1.YValues.DataMember = "Y"
        ' 
        ' Gallery_Panel
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(426, 258)
        Me.Name = "Gallery_Panel"
        Me.panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub 'InitializeComponent 
#End Region


    Private Sub galleryPanel1_OnChangeChart(ByVal sender As Object, ByVal e As System.EventArgs) Handles galleryPanel1.OnChangeChart
        Dim s As TeeChart.Styles.Series = tChart1(0)
        TeeChart.Styles.Series.ChangeType(s, galleryPanel1.SelectedChart(0).GetType())
    End Sub 'galleryPanel1_OnChangeChart


    Private Sub galleryPanel1_OnSubSelected(ByVal sender As Object, ByVal e As System.EventArgs) Handles galleryPanel1.OnSubSelected
        galleryPanel1.SetSubSelected(tChart1(0), Fix(galleryPanel1.SelectedChart.Tag))
    End Sub 'galleryPanel1_OnSubSelected
End Class 'Gallery_Panel
