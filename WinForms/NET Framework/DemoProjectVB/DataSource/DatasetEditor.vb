
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data

Imports System.Windows.Forms




Public Class DatasetEditor
    Inherits Steema.TeeChart.Samples.BaseForm
    Private dataSet1 As System.Data.DataSet
    Private dataTable1 As System.Data.DataTable
    Private colX As System.Data.DataColumn
    Private colY As System.Data.DataColumn
    Private colZ As System.Data.DataColumn
    Private colDesc As System.Data.DataColumn
    Private point3DSeries1 As Steema.TeeChart.Styles.Points3D
    Private rotate1 As Steema.TeeChart.Tools.Rotate
    Private WithEvents button1 As System.Windows.Forms.Button
    Private gridBand1 As Steema.TeeChart.Tools.GridBand
    Private components As System.ComponentModel.IContainer = Nothing
    
    
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
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
        Me.dataSet1 = New System.Data.DataSet
        Me.dataTable1 = New System.Data.DataTable
        Me.colX = New System.Data.DataColumn
        Me.colY = New System.Data.DataColumn
        Me.colZ = New System.Data.DataColumn
        Me.colDesc = New System.Data.DataColumn
        Me.point3DSeries1 = New Steema.TeeChart.Styles.Points3D
        Me.rotate1 = New Steema.TeeChart.Tools.Rotate
        Me.button1 = New System.Windows.Forms.Button
        Me.gridBand1 = New Steema.TeeChart.Tools.GridBand
        Me.panel1.SuspendLayout()
        CType(Me.dataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(592, 48)
        Me.textBox1.Text = "This example uses a DataSet created at designtime and linked via the Chart Editor" + " to a Chart Series at designtime. The DataSet is populated at Form load."
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.button1)
        Me.panel1.Location = New System.Drawing.Point(0, 48)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(592, 40)
        ' 
        ' tChart1
        ' 
        ' 
        ' tChart1.Aspect
        ' 
        Me.tChart1.Aspect.Chart3DPercent = 50
        Me.tChart1.Aspect.Orthogonal = False
        Me.tChart1.Aspect.Perspective = 78
        Me.tChart1.Aspect.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality
        Me.tChart1.Aspect.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        Me.tChart1.Aspect.Zoom = 75
        ' 
        ' tChart1.Axes
        ' 
        ' 
        ' tChart1.Axes.Bottom
        ' 
        ' 
        ' tChart1.Axes.Bottom.Labels
        ' 
        ' 
        ' tChart1.Axes.Bottom.Labels.Font
        ' 
        ' 
        ' tChart1.Axes.Bottom.Labels.Font.Shadow
        ' 
        Me.tChart1.Axes.Bottom.Labels.Font.Shadow.Visible = False
        ' 
        ' tChart1.Axes.Bottom.Labels.Shadow
        ' 
        Me.tChart1.Axes.Bottom.Labels.Shadow.Visible = False
        ' 
        ' tChart1.Axes.Bottom.Title
        ' 
        ' 
        ' tChart1.Axes.Bottom.Title.Font
        ' 
        ' 
        ' tChart1.Axes.Bottom.Title.Font.Shadow
        ' 
        Me.tChart1.Axes.Bottom.Title.Font.Shadow.Visible = False
        ' 
        ' tChart1.Axes.Bottom.Title.Shadow
        ' 
        Me.tChart1.Axes.Bottom.Title.Shadow.Visible = False
        ' 
        ' tChart1.Axes.Depth
        ' 
        ' 
        ' tChart1.Axes.Depth.Labels
        ' 
        ' 
        ' tChart1.Axes.Depth.Labels.Font
        ' 
        ' 
        ' tChart1.Axes.Depth.Labels.Font.Shadow
        ' 
        Me.tChart1.Axes.Depth.Labels.Font.Shadow.Visible = False
        ' 
        ' tChart1.Axes.Depth.Labels.Shadow
        ' 
        Me.tChart1.Axes.Depth.Labels.Shadow.Visible = False
        ' 
        ' tChart1.Axes.Depth.Title
        ' 
        ' 
        ' tChart1.Axes.Depth.Title.Font
        ' 
        ' 
        ' tChart1.Axes.Depth.Title.Font.Shadow
        ' 
        Me.tChart1.Axes.Depth.Title.Font.Shadow.Visible = False
        ' 
        ' tChart1.Axes.Depth.Title.Shadow
        ' 
        Me.tChart1.Axes.Depth.Title.Shadow.Visible = False
        ' 
        ' tChart1.Axes.DepthTop
        ' 
        ' 
        ' tChart1.Axes.DepthTop.Labels
        ' 
        ' 
        ' tChart1.Axes.DepthTop.Labels.Font
        ' 
        ' 
        ' tChart1.Axes.DepthTop.Labels.Font.Shadow
        ' 
        Me.tChart1.Axes.DepthTop.Labels.Font.Shadow.Visible = False
        ' 
        ' tChart1.Axes.DepthTop.Labels.Shadow
        ' 
        Me.tChart1.Axes.DepthTop.Labels.Shadow.Visible = False
        ' 
        ' tChart1.Axes.DepthTop.Title
        ' 
        ' 
        ' tChart1.Axes.DepthTop.Title.Font
        ' 
        ' 
        ' tChart1.Axes.DepthTop.Title.Font.Shadow
        ' 
        Me.tChart1.Axes.DepthTop.Title.Font.Shadow.Visible = False
        ' 
        ' tChart1.Axes.DepthTop.Title.Shadow
        ' 
        Me.tChart1.Axes.DepthTop.Title.Shadow.Visible = False
        ' 
        ' tChart1.Axes.Left
        ' 
        ' 
        ' tChart1.Axes.Left.Labels
        ' 
        ' 
        ' tChart1.Axes.Left.Labels.Font
        ' 
        ' 
        ' tChart1.Axes.Left.Labels.Font.Shadow
        ' 
        Me.tChart1.Axes.Left.Labels.Font.Shadow.Visible = False
        ' 
        ' tChart1.Axes.Left.Labels.Shadow
        ' 
        Me.tChart1.Axes.Left.Labels.Shadow.Visible = False
        ' 
        ' tChart1.Axes.Left.Title
        ' 
        ' 
        ' tChart1.Axes.Left.Title.Font
        ' 
        ' 
        ' tChart1.Axes.Left.Title.Font.Shadow
        ' 
        Me.tChart1.Axes.Left.Title.Font.Shadow.Visible = False
        ' 
        ' tChart1.Axes.Left.Title.Shadow
        ' 
        Me.tChart1.Axes.Left.Title.Shadow.Visible = False
        ' 
        ' tChart1.Axes.Right
        ' 
        ' 
        ' tChart1.Axes.Right.Labels
        ' 
        ' 
        ' tChart1.Axes.Right.Labels.Font
        ' 
        ' 
        ' tChart1.Axes.Right.Labels.Font.Shadow
        ' 
        Me.tChart1.Axes.Right.Labels.Font.Shadow.Visible = False
        ' 
        ' tChart1.Axes.Right.Labels.Shadow
        ' 
        Me.tChart1.Axes.Right.Labels.Shadow.Visible = False
        ' 
        ' tChart1.Axes.Right.Title
        ' 
        ' 
        ' tChart1.Axes.Right.Title.Font
        ' 
        ' 
        ' tChart1.Axes.Right.Title.Font.Shadow
        ' 
        Me.tChart1.Axes.Right.Title.Font.Shadow.Visible = False
        ' 
        ' tChart1.Axes.Right.Title.Shadow
        ' 
        Me.tChart1.Axes.Right.Title.Shadow.Visible = False
        ' 
        ' tChart1.Axes.Top
        ' 
        ' 
        ' tChart1.Axes.Top.Labels
        ' 
        ' 
        ' tChart1.Axes.Top.Labels.Font
        ' 
        ' 
        ' tChart1.Axes.Top.Labels.Font.Shadow
        ' 
        Me.tChart1.Axes.Top.Labels.Font.Shadow.Visible = False
        ' 
        ' tChart1.Axes.Top.Labels.Shadow
        ' 
        Me.tChart1.Axes.Top.Labels.Shadow.Visible = False
        ' 
        ' tChart1.Axes.Top.Title
        ' 
        ' 
        ' tChart1.Axes.Top.Title.Font
        ' 
        ' 
        ' tChart1.Axes.Top.Title.Font.Shadow
        ' 
        Me.tChart1.Axes.Top.Title.Font.Shadow.Visible = False
        ' 
        ' tChart1.Axes.Top.Title.Shadow
        ' 
        Me.tChart1.Axes.Top.Title.Shadow.Visible = False
        ' 
        ' tChart1.Footer
        ' 
        ' 
        ' tChart1.Footer.Font
        ' 
        ' 
        ' tChart1.Footer.Font.Shadow
        ' 
        Me.tChart1.Footer.Font.Shadow.Visible = False
        ' 
        ' tChart1.Footer.Shadow
        ' 
        Me.tChart1.Footer.Shadow.Visible = False
        ' 
        ' tChart1.Header
        ' 
        ' 
        ' tChart1.Header.Font
        ' 
        ' 
        ' tChart1.Header.Font.Shadow
        ' 
        Me.tChart1.Header.Font.Shadow.Visible = False
        Me.tChart1.Header.Lines = New String() {"tChart1"}
        ' 
        ' tChart1.Header.Shadow
        ' 
        Me.tChart1.Header.Shadow.Visible = False
        ' 
        ' tChart1.Legend
        ' 
        ' 
        ' tChart1.Legend.Font
        ' 
        ' 
        ' tChart1.Legend.Font.Shadow
        ' 
        Me.tChart1.Legend.Font.Shadow.Visible = False
        ' 
        ' tChart1.Legend.Title
        ' 
        ' 
        ' tChart1.Legend.Title.Font
        ' 
        Me.tChart1.Legend.Title.Font.Bold = True
        ' 
        ' tChart1.Legend.Title.Font.Shadow
        ' 
        Me.tChart1.Legend.Title.Font.Shadow.Visible = False
        ' 
        ' tChart1.Legend.Title.Pen
        ' 
        Me.tChart1.Legend.Title.Pen.Visible = False
        ' 
        ' tChart1.Legend.Title.Shadow
        ' 
        Me.tChart1.Legend.Title.Shadow.Visible = False
        Me.tChart1.Location = New System.Drawing.Point(0, 88)
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Brush
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        ' 
        ' tChart1.Panel.Gradient
        ' 
        Me.tChart1.Panel.Brush.Gradient.Visible = True
        ' 
        ' tChart1.Panel.Gradient
        ' 
        Me.tChart1.Panel.Gradient.Visible = True
        ' 
        ' tChart1.Panel.Shadow
        ' 
        Me.tChart1.Panel.Shadow.Visible = False
        Me.tChart1.Series.Add(Me.point3DSeries1)
        Me.tChart1.Size = New System.Drawing.Size(592, 280)
        ' 
        ' tChart1.SubFooter
        ' 
        ' 
        ' tChart1.SubFooter.Font
        ' 
        ' 
        ' tChart1.SubFooter.Font.Shadow
        ' 
        Me.tChart1.SubFooter.Font.Shadow.Visible = False
        ' 
        ' tChart1.SubFooter.Shadow
        ' 
        Me.tChart1.SubFooter.Shadow.Visible = False
        ' 
        ' tChart1.SubHeader
        ' 
        ' 
        ' tChart1.SubHeader.Font
        ' 
        ' 
        ' tChart1.SubHeader.Font.Shadow
        ' 
        Me.tChart1.SubHeader.Font.Shadow.Visible = False
        ' 
        ' tChart1.SubHeader.Shadow
        ' 
        Me.tChart1.SubHeader.Shadow.Visible = False
        Me.tChart1.Tools.Add(Me.rotate1)
        Me.tChart1.Tools.Add(Me.gridBand1)
        ' 
        ' tChart1.Walls
        ' 
        ' 
        ' tChart1.Walls.Back
        ' 
        ' 
        ' tChart1.Walls.Back.Pen
        ' 
        Me.tChart1.Walls.Back.Pen.Visible = False
        ' 
        ' tChart1.Walls.Back.Shadow
        ' 
        Me.tChart1.Walls.Back.Shadow.Visible = False
        ' 
        ' tChart1.Walls.Bottom
        ' 
        ' 
        ' tChart1.Walls.Bottom.Pen
        ' 
        Me.tChart1.Walls.Bottom.Pen.Visible = False
        ' 
        ' tChart1.Walls.Bottom.Shadow
        ' 
        Me.tChart1.Walls.Bottom.Shadow.Visible = False
        Me.tChart1.Walls.Bottom.Size = 4
        ' 
        ' tChart1.Walls.Left
        ' 
        ' 
        ' tChart1.Walls.Left.Pen
        ' 
        Me.tChart1.Walls.Left.Pen.Visible = False
        ' 
        ' tChart1.Walls.Left.Shadow
        ' 
        Me.tChart1.Walls.Left.Shadow.Visible = False
        Me.tChart1.Walls.Left.Size = 4
        ' 
        ' tChart1.Walls.Right
        ' 
        ' 
        ' tChart1.Walls.Right.Shadow
        ' 
        Me.tChart1.Walls.Right.Shadow.Visible = False
        ' 
        ' dataSet1
        ' 
        Me.dataSet1.DataSetName = "NewDataSet"
        Me.dataSet1.Locale = New System.Globalization.CultureInfo("es-ES")
        Me.dataSet1.Tables.AddRange(New System.Data.DataTable() {Me.dataTable1})
        ' 
        ' dataTable1
        ' 
        Me.dataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.colX, Me.colY, Me.colZ, Me.colDesc})
        Me.dataTable1.TableName = "Table1"
        ' 
        ' colX
        ' 
        Me.colX.Caption = "colX"
        Me.colX.ColumnName = "colX"
        Me.colX.DataType = GetType(System.Double)
        ' 
        ' colY
        ' 
        Me.colY.Caption = "colY"
        Me.colY.ColumnName = "colY"
        Me.colY.DataType = GetType(System.Double)
        ' 
        ' colZ
        ' 
        Me.colZ.Caption = "colZ"
        Me.colZ.ColumnName = "colZ"
        Me.colZ.DataType = GetType(System.Double)
        ' 
        ' colDesc
        ' 
        Me.colDesc.ColumnName = "colDesc"
        ' 
        ' point3DSeries1
        ' 
        Me.point3DSeries1.Cursor = System.Windows.Forms.Cursors.Cross
        Me.point3DSeries1.DataSource = Me.dataTable1
        Me.point3DSeries1.LabelMember = "colDesc"
        ' 
        ' point3DSeries1.LinePen
        ' 
        Me.point3DSeries1.LinePen.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(192, System.Byte), CType(192, System.Byte), CType(192, System.Byte))
        ' 
        ' point3DSeries1.Marks
        ' 
        ' 
        ' point3DSeries1.Marks.Callout
        ' 
        Me.point3DSeries1.Marks.Callout.Arrow = Me.point3DSeries1.Marks.Arrow
        Me.point3DSeries1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None
        Me.point3DSeries1.Marks.Callout.ArrowHeadSize = 8
        ' 
        ' point3DSeries1.Marks.Callout.Brush
        ' 
        Me.point3DSeries1.Marks.Callout.Brush.Color = System.Drawing.Color.Black
        Me.point3DSeries1.Marks.Callout.Distance = 0
        Me.point3DSeries1.Marks.Callout.Draw3D = False
        Me.point3DSeries1.Marks.Callout.Length = 10
        Me.point3DSeries1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        ' 
        ' point3DSeries1.Marks.Font
        ' 
        ' 
        ' point3DSeries1.Marks.Font.Shadow
        ' 
        Me.point3DSeries1.Marks.Font.Shadow.Visible = False
        ' 
        ' point3DSeries1.Pointer
        ' 
        ' 
        ' point3DSeries1.Pointer.Brush
        ' 
        Me.point3DSeries1.Pointer.Brush.Color = System.Drawing.Color.Red
        Me.point3DSeries1.Pointer.HorizSize = 5
        ' 
        ' point3DSeries1.Pointer.Pen
        ' 
        Me.point3DSeries1.Pointer.Pen.Color = System.Drawing.Color.FromArgb(CType(153, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        Me.point3DSeries1.Pointer.Pen.Visible = False
        Me.point3DSeries1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.point3DSeries1.Pointer.VertSize = 5
        Me.point3DSeries1.Pointer.Visible = True
        Me.point3DSeries1.Title = "point3DSeries1"
        ' 
        ' point3DSeries1.XValues
        ' 
        Me.point3DSeries1.XValues.DataMember = "colX"
        ' 
        ' point3DSeries1.YValues
        ' 
        Me.point3DSeries1.YValues.DataMember = "colY"
        ' 
        ' point3DSeries1.ZValues
        ' 
        Me.point3DSeries1.ZValues.DataMember = "colZ"
        ' 
        ' button1
        ' 
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.Location = New System.Drawing.Point(16, 8)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(120, 23)
        Me.button1.TabIndex = 0
        Me.button1.Text = "&Edit Datasource..."
        ' 
        ' gridBand1
        ' 
        Me.gridBand1.Axis = Me.tChart1.Axes.Left
        ' 
        ' gridBand1.Band1
        ' 
        Me.gridBand1.Band1.Color = System.Drawing.Color.FromArgb(CType(25, System.Byte), CType(0, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        ' 
        ' gridBand1.Band2
        ' 
        Me.gridBand1.Band2.Color = System.Drawing.Color.FromArgb(CType(0, System.Byte), CType(0, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        ' 
        ' DatasetEditor
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(592, 368)
        Me.Name = "DatasetEditor"
        Me.panel1.ResumeLayout(False)
        CType(Me.dataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub 'InitializeComponent 
#End Region


    Private Sub PopulateTable()
        Dim r As New Random(255)
        Dim numVals As Integer = 20

        Dim NewRow As DataRow
        Dim x As Integer
        For x = 0 To numVals - 1
            Dim z As Integer
            For z = 0 To numVals - 1
                Dim tmpvar As Double = r.Next(10)
                NewRow = dataTable1.NewRow()
                NewRow("colDesc") = "Text" + x.ToString() + z.ToString()
                NewRow("colX") = x
                NewRow("colY") = 0.5 * Math.Pow(Math.Cos(x / (numVals * 0.2)), 2) + Math.Pow(Math.Cos(z / (numVals * 0.2)), 2) - Math.Cos(z / (numVals * 0.5))
                NewRow("colZ") = z 
                dataTable1.Rows.Add(NewRow)
            Next z
        Next x
    End Sub 'PopulateTable

    Private Sub DatasetEditor_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PopulateTable()
        tChart1(0).CheckDataSource()
    End Sub 'DatasetEditor_Load


    Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
        TeeChart.Editors.SeriesEditor.ShowEditor(tChart1(0), TeeChart.Editors.ChartEditorTabs.SeriesDataSource)
    End Sub 'button1_Click
End Class 'DatasetEditor
