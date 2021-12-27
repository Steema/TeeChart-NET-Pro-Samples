
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing

Imports System.Windows.Forms



Public Class IsoSurface_Series
    Inherits Samples.BaseForm

    Private groupBox1 As GroupBox
    Private rbDotGrid As RadioButton
    Private rbWireFrame As RadioButton
    Private rbNormal As RadioButton
    Private isoSurface1 As Steema.TeeChart.Styles.IsoSurface
    Private cbSides As CheckBox
    Private bEdit As Button


    '/ <summary>
    '/ Required designer variable.
    '/ </summary>
    Private components As System.ComponentModel.IContainer = Nothing


    Public Sub New() ' This call is required by the Windows Form Designer.
        InitializeComponent()
        InitializeChart()
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

#Region "Windows Form Designer generated code"

    '/ <summary>
    '/ Required method for Designer support - do not modify
    '/ the contents of this method with the code editor.
    '/ </summary>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IsoSurface_Series))
        Me.groupBox1 = New System.Windows.Forms.GroupBox
        Me.rbDotGrid = New System.Windows.Forms.RadioButton
        Me.rbWireFrame = New System.Windows.Forms.RadioButton
        Me.rbNormal = New System.Windows.Forms.RadioButton
        Me.isoSurface1 = New Steema.TeeChart.Styles.IsoSurface
        Me.cbSides = New System.Windows.Forms.CheckBox
        Me.bEdit = New System.Windows.Forms.Button
        Me.panel1.SuspendLayout()
        Me.chartContainer.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Text = ("The new IsoSurface Series enables the visualization of 3D data in a \'map\' like fa" + "shion.")
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.bEdit)
        Me.panel1.Controls.Add(Me.cbSides)
        Me.panel1.Controls.Add(Me.groupBox1)
        ' 
        ' tChart1
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Aspect.Orthogonal = False
        Me.tChart1.Aspect.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
        Me.tChart1.Aspect.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Bottom.Labels.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Bottom.Title.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Depth.Labels.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Depth.Title.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.DepthTop.Labels.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.DepthTop.Title.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Left.Labels.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Left.Title.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Right.Labels.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Right.Title.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Top.Labels.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Top.Title.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Footer.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Header.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        Me.tChart1.Header.Lines = New String() {"IsoSurface Series"}
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Legend.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        Me.tChart1.Legend.MaxNumRows = 8
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Legend.Title.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(216, Byte), Integer))
        ' 
        ' 
        ' 
        Me.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.tChart1.Panel.Brush.Gradient.ExtendedColorPalette = Nothing
        Me.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tChart1.Panel.Brush.Gradient.Sigma = True
        Me.tChart1.Panel.Brush.Gradient.SigmaFocus = 1.0!
        Me.tChart1.Panel.Brush.Gradient.SigmaScale = 0.8!
        Me.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tChart1.Panel.Brush.Gradient.UseMiddle = True
        Me.tChart1.Panel.Brush.Gradient.Visible = True
        Me.tChart1.Series.Add(Me.isoSurface1)
        Me.tChart1.Size = New System.Drawing.Size(440, 205)
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.SubFooter.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.SubHeader.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        ' 
        ' groupBox1
        ' 
        Me.groupBox1.Controls.Add(Me.rbDotGrid)
        Me.groupBox1.Controls.Add(Me.rbWireFrame)
        Me.groupBox1.Controls.Add(Me.rbNormal)
        Me.groupBox1.Location = New System.Drawing.Point(12, 3)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(231, 33)
        Me.groupBox1.TabIndex = 0
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Style"
        ' 
        ' rbDotGrid
        ' 
        Me.rbDotGrid.Location = New System.Drawing.Point(168, 13)
        Me.rbDotGrid.Name = "rbDotGrid"
        Me.rbDotGrid.Size = New System.Drawing.Size(61, 17)
        Me.rbDotGrid.TabIndex = 2
        Me.rbDotGrid.Text = "DotGrid"
        AddHandler rbDotGrid.CheckedChanged, AddressOf Me.rbDotGrid_CheckedChanged
        ' 
        ' rbWireFrame
        ' 
        Me.rbWireFrame.Location = New System.Drawing.Point(80, 13)
        Me.rbWireFrame.Name = "rbWireFrame"
        Me.rbWireFrame.Size = New System.Drawing.Size(82, 17)
        Me.rbWireFrame.TabIndex = 1
        Me.rbWireFrame.Text = "WireFrame"
        AddHandler rbWireFrame.CheckedChanged, AddressOf Me.rbWireFrame_CheckedChanged
        ' 
        ' rbNormal
        ' 
        Me.rbNormal.Checked = True
        Me.rbNormal.Location = New System.Drawing.Point(6, 13)
        Me.rbNormal.Name = "rbNormal"
        Me.rbNormal.Size = New System.Drawing.Size(66, 17)
        Me.rbNormal.TabIndex = 0
        Me.rbNormal.TabStop = True
        Me.rbNormal.Text = "Normal"
        AddHandler rbNormal.CheckedChanged, AddressOf Me.rbNormal_CheckedChanged
        ' 
        ' isoSurface1
        ' 
        ' 
        ' 
        ' 
        Me.isoSurface1.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.isoSurface1.ColorEach = False
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.isoSurface1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None
        Me.isoSurface1.Marks.Callout.ArrowHeadSize = 8
        ' 
        ' 
        ' 
        Me.isoSurface1.Marks.Callout.Brush.Color = System.Drawing.Color.Black
        Me.isoSurface1.Marks.Callout.Distance = 0
        Me.isoSurface1.Marks.Callout.Draw3D = False
        Me.isoSurface1.Marks.Callout.Length = 10
        Me.isoSurface1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        ' 
        ' 
        ' 
        Me.isoSurface1.Marks.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        Me.isoSurface1.PaletteMin = 0
        Me.isoSurface1.PaletteStep = 0
        Me.isoSurface1.Title = "iso-Surface1"
        Me.isoSurface1.UseColorRange = False
        ' 
        ' 
        ' 
        Me.isoSurface1.XValues.DataMember = "X"
        ' 
        ' 
        ' 
        Me.isoSurface1.YValues.DataMember = "Y"
        ' 
        ' 
        ' 
        Me.isoSurface1.ZValues.DataMember = "Z"
        ' 
        ' cbSides
        ' 
        Me.cbSides.Location = New System.Drawing.Point(249, 16)
        Me.cbSides.Name = "cbSides"
        Me.cbSides.Size = New System.Drawing.Size(82, 17)
        Me.cbSides.TabIndex = 3
        Me.cbSides.Text = "Show Sides"
        AddHandler cbSides.CheckedChanged, AddressOf Me.cbSides_CheckedChanged
        ' 
        ' bEdit
        ' 
        Me.bEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bEdit.Location = New System.Drawing.Point(337, 10)
        Me.bEdit.Name = "bEdit"
        Me.bEdit.Size = New System.Drawing.Size(75, 23)
        Me.bEdit.TabIndex = 2
        Me.bEdit.Text = "Edit..."
        AddHandler bEdit.Click, AddressOf Me.bEdit_Click
        ' 
        ' IsoSurface_Series
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(440, 317)
        Me.Name = "IsoSurface_Series"
        Me.Text = "IsoSurface_Series"
        Me.panel1.ResumeLayout(False)
        Me.chartContainer.ResumeLayout(False)
        Me.groupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub InitializeChart()

        IsoSurface1.Brush.Transparency = 0
        IsoSurface1.BandPen.Visible = True
        IsoSurface1.FillSampleValues()
    End Sub

    Private Sub Normalize()
        IsoSurface1.UseColorRange = False
        IsoSurface1.UsePalette = False
        IsoSurface1.WireFrame = False
        IsoSurface1.DotFrame = False
    End Sub

    Private Sub rbNormal_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
        IsoSurface1.WireFrame = False
        isoSurface1.DotFrame = False
    End Sub

    Private Sub rbWireFrame_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
        IsoSurface1.WireFrame = rbWireFrame.Checked
    End Sub

    Private Sub rbDotGrid_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
        IsoSurface1.DotFrame = rbDotGrid.Checked
    End Sub

    Private Sub cbSides_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
        isoSurface1.SideBrush.Visible = cbSides.Checked
    End Sub

    Private Sub bEdit_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim form As Steema.TeeChart.Editors.Series.IsoSurfaceEditor = New Steema.TeeChart.Editors.Series.IsoSurfaceEditor(isoSurface1)
        Steema.TeeChart.Editors.EditorUtils.ShowFormModal(Form)
    End Sub

End Class

