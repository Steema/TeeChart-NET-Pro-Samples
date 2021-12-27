Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Public Class ChartEditor_Options
    Inherits BaseForm
    Private WithEvents bEditorRuntime As Button
#If (VS2005) Then
    Private chartController1 As ChartController
#Else
    Private chartController1 As Commander
#End If
    Private groupBox3 As GroupBox
    Private groupBox2 As GroupBox
    Private editorGalleryHeight As NumericUpDown
    Private label5 As Label
    Private editorGalleryWidth As NumericUpDown
    Private label6 As Label
    Private groupBox1 As GroupBox
    Private editorHeight As NumericUpDown
    Private label3 As Label
    Private editorWidth As NumericUpDown
    Private label4 As Label
    Private groupBox4 As GroupBox
    Private WithEvents ChartControllerEdHeight As NumericUpDown
    Private label1 As Label
    Private WithEvents ChartControllerEdWidth As NumericUpDown
    Private label2 As Label
    Private editor1 As Editor
    Private WithEvents button1 As Button
    Private components As System.ComponentModel.IContainer = Nothing
    Public Sub New()
        'This call is required by the Windows Form Designer.
        InitializeComponent()
    End Sub
    '<summary>
    'Clean up any resources being used.
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ChartEditor_Options))
#If (VS2005) Then
        Me.chartController1 = New Steema.TeeChart.ChartController
#Else
        Me.chartController1 = New Steema.TeeChart.Commander
#End If
        Me.bEditorRuntime = New System.Windows.Forms.Button
        Me.groupBox1 = New System.Windows.Forms.GroupBox
        Me.editorHeight = New System.Windows.Forms.NumericUpDown
        Me.label3 = New System.Windows.Forms.Label
        Me.editorWidth = New System.Windows.Forms.NumericUpDown
        Me.label4 = New System.Windows.Forms.Label
        Me.groupBox2 = New System.Windows.Forms.GroupBox
        Me.editorGalleryHeight = New System.Windows.Forms.NumericUpDown
        Me.label5 = New System.Windows.Forms.Label
        Me.editorGalleryWidth = New System.Windows.Forms.NumericUpDown
        Me.label6 = New System.Windows.Forms.Label
        Me.groupBox3 = New System.Windows.Forms.GroupBox
        Me.groupBox4 = New System.Windows.Forms.GroupBox
        Me.ChartControllerEdHeight = New System.Windows.Forms.NumericUpDown
        Me.label1 = New System.Windows.Forms.Label
        Me.ChartControllerEdWidth = New System.Windows.Forms.NumericUpDown
        Me.label2 = New System.Windows.Forms.Label
        Me.button1 = New System.Windows.Forms.Button
        Me.editor1 = New Steema.TeeChart.Editor(Me.components)
        Me.panel1.SuspendLayout()
        Me.chartContainer.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        CType(Me.editorHeight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.editorWidth, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox2.SuspendLayout()
        CType(Me.editorGalleryHeight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.editorGalleryWidth, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox3.SuspendLayout()
        Me.groupBox4.SuspendLayout()
        CType(Me.ChartControllerEdHeight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChartControllerEdWidth, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'textBox1
        '
        Me.textBox1.Size = New System.Drawing.Size(466, 65)
        Me.textBox1.Text = resources.GetString("textBox1.Text")
        '
        'panel1
        '
        Me.panel1.Controls.Add(Me.button1)
        Me.panel1.Controls.Add(Me.groupBox4)
        Me.panel1.Controls.Add(Me.groupBox3)
        Me.panel1.Location = New System.Drawing.Point(0, 65)
        Me.panel1.Size = New System.Drawing.Size(466, 126)
        '
        'tChart1
        '
        '
        '
        '
        Me.tChart1.Aspect.ZOffset = 0
        '
        '
        '
        '
        '
        '
        '
        '
        '
        Me.tChart1.Axes.Bottom.Title.Transparent = True
        '
        '
        '
        '
        '
        '
        Me.tChart1.Axes.Depth.Title.Transparent = True
        '
        '
        '
        '
        '
        '
        Me.tChart1.Axes.DepthTop.Title.Transparent = True
        '
        '
        '
        '
        '
        '
        Me.tChart1.Axes.Left.Title.Transparent = True
        '
        '
        '
        '
        '
        '
        Me.tChart1.Axes.Right.Title.Transparent = True
        '
        '
        '
        '
        '
        '
        Me.tChart1.Axes.Top.Title.Transparent = True
        '
        '
        '
        Me.tChart1.Header.Lines = New String() {"tChart1"}
        Me.tChart1.Location = New System.Drawing.Point(0, 25)
        '
        '
        '
        '
        '
        '
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tChart1.Size = New System.Drawing.Size(466, 70)
        '
        '
        '
        '
        '
        '
        '
        '
        '
        Me.tChart1.Walls.Back.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
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
        'chartContainer
        '
        Me.chartContainer.Controls.Add(Me.chartController1)
        Me.chartContainer.Location = New System.Drawing.Point(0, 191)
        Me.chartContainer.Size = New System.Drawing.Size(466, 95)
        Me.chartContainer.Controls.SetChildIndex(Me.chartController1, 0)
        Me.chartContainer.Controls.SetChildIndex(Me.tChart1, 0)
        '
        'chartController1
        '
    'Me.chartController1.ButtonSize = Steema.TeeChart.ControllerButtonSize.x16
        Me.chartController1.LabelValues = True
        Me.chartController1.Location = New System.Drawing.Point(0, 0)
        Me.chartController1.Name = "chartController1"
        Me.chartController1.Size = New System.Drawing.Size(466, 25)
        Me.chartController1.TabIndex = 1
        Me.chartController1.Text = "chartController1"
        '
        'bEditorRuntime
        '
        Me.bEditorRuntime.Location = New System.Drawing.Point(8, 11)
        Me.bEditorRuntime.Name = "bEditorRuntime"
        Me.bEditorRuntime.Size = New System.Drawing.Size(119, 23)
        Me.bEditorRuntime.TabIndex = 1
        Me.bEditorRuntime.Text = "Show &Editor Runtime"
        Me.bEditorRuntime.UseVisualStyleBackColor = True
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.editorHeight)
        Me.groupBox1.Controls.Add(Me.label3)
        Me.groupBox1.Controls.Add(Me.editorWidth)
        Me.groupBox1.Controls.Add(Me.label4)
        Me.groupBox1.Location = New System.Drawing.Point(8, 40)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(119, 72)
        Me.groupBox1.TabIndex = 10
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Editor Size"
        '
        'editorHeight
        '
        Me.editorHeight.Location = New System.Drawing.Point(60, 43)
        Me.editorHeight.Maximum = New Decimal(New Integer() {2000, 0, 0, 0})
        Me.editorHeight.Name = "editorHeight"
        Me.editorHeight.Size = New System.Drawing.Size(53, 20)
        Me.editorHeight.TabIndex = 13
        Me.editorHeight.Value = New Decimal(New Integer() {400, 0, 0, 0})
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(15, 45)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(44, 13)
        Me.label3.TabIndex = 12
        Me.label3.Text = "&Height :"
        '
        'editorWidth
        '
        Me.editorWidth.Location = New System.Drawing.Point(60, 18)
        Me.editorWidth.Maximum = New Decimal(New Integer() {2000, 0, 0, 0})
        Me.editorWidth.Name = "editorWidth"
        Me.editorWidth.Size = New System.Drawing.Size(53, 20)
        Me.editorWidth.TabIndex = 11
        Me.editorWidth.Value = New Decimal(New Integer() {600, 0, 0, 0})
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(15, 20)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(41, 13)
        Me.label4.TabIndex = 10
        Me.label4.Text = "&Width :"
        '
        'groupBox2
        '
        Me.groupBox2.Controls.Add(Me.editorGalleryHeight)
        Me.groupBox2.Controls.Add(Me.label5)
        Me.groupBox2.Controls.Add(Me.editorGalleryWidth)
        Me.groupBox2.Controls.Add(Me.label6)
        Me.groupBox2.Location = New System.Drawing.Point(141, 40)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(119, 72)
        Me.groupBox2.TabIndex = 14
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "Editor Gallery Size"
        '
        'editorGalleryHeight
        '
        Me.editorGalleryHeight.Location = New System.Drawing.Point(60, 43)
        Me.editorGalleryHeight.Maximum = New Decimal(New Integer() {2000, 0, 0, 0})
        Me.editorGalleryHeight.Name = "editorGalleryHeight"
        Me.editorGalleryHeight.Size = New System.Drawing.Size(53, 20)
        Me.editorGalleryHeight.TabIndex = 13
        Me.editorGalleryHeight.Value = New Decimal(New Integer() {400, 0, 0, 0})
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(15, 45)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(44, 13)
        Me.label5.TabIndex = 12
        Me.label5.Text = "&Height :"
        '
        'editorGalleryWidth
        '
        Me.editorGalleryWidth.Location = New System.Drawing.Point(60, 18)
        Me.editorGalleryWidth.Maximum = New Decimal(New Integer() {2000, 0, 0, 0})
        Me.editorGalleryWidth.Name = "editorGalleryWidth"
        Me.editorGalleryWidth.Size = New System.Drawing.Size(53, 20)
        Me.editorGalleryWidth.TabIndex = 11
        Me.editorGalleryWidth.Value = New Decimal(New Integer() {600, 0, 0, 0})
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(15, 20)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(41, 13)
        Me.label6.TabIndex = 10
        Me.label6.Text = "&Width :"
        '
        'groupBox3
        '
        Me.groupBox3.Controls.Add(Me.groupBox2)
        Me.groupBox3.Controls.Add(Me.groupBox1)
        Me.groupBox3.Controls.Add(Me.bEditorRuntime)
        Me.groupBox3.Location = New System.Drawing.Point(9, 1)
        Me.groupBox3.Name = "groupBox3"
        Me.groupBox3.Size = New System.Drawing.Size(274, 120)
        Me.groupBox3.TabIndex = 15
        Me.groupBox3.TabStop = False
        '
        'groupBox4
        '
        Me.groupBox4.Controls.Add(Me.ChartControllerEdHeight)
        Me.groupBox4.Controls.Add(Me.label1)
        Me.groupBox4.Controls.Add(Me.ChartControllerEdWidth)
        Me.groupBox4.Controls.Add(Me.label2)
        Me.groupBox4.Location = New System.Drawing.Point(290, 4)
        Me.groupBox4.Name = "groupBox4"
        Me.groupBox4.Size = New System.Drawing.Size(173, 72)
        Me.groupBox4.TabIndex = 16
        Me.groupBox4.TabStop = False
        Me.groupBox4.Text = "ChartController Editor Size"
        '
        'ChartControllerEdHeight
        '
        Me.ChartControllerEdHeight.Location = New System.Drawing.Point(60, 43)
        Me.ChartControllerEdHeight.Maximum = New Decimal(New Integer() {2000, 0, 0, 0})
        Me.ChartControllerEdHeight.Name = "ChartControllerEdHeight"
        Me.ChartControllerEdHeight.Size = New System.Drawing.Size(56, 20)
        Me.ChartControllerEdHeight.TabIndex = 13
        Me.ChartControllerEdHeight.Value = New Decimal(New Integer() {500, 0, 0, 0})
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(15, 45)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(44, 13)
        Me.label1.TabIndex = 12
        Me.label1.Text = "&Height :"
        '
        'ChartControllerEdWidth
        '
        Me.ChartControllerEdWidth.Location = New System.Drawing.Point(60, 18)
        Me.ChartControllerEdWidth.Maximum = New Decimal(New Integer() {2000, 0, 0, 0})
        Me.ChartControllerEdWidth.Name = "ChartControllerEdWidth"
        Me.ChartControllerEdWidth.Size = New System.Drawing.Size(56, 20)
        Me.ChartControllerEdWidth.TabIndex = 11
        Me.ChartControllerEdWidth.Value = New Decimal(New Integer() {650, 0, 0, 0})
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(15, 20)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(41, 13)
        Me.label2.TabIndex = 10
        Me.label2.Text = "&Width :"
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(290, 90)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(150, 23)
        Me.button1.TabIndex = 17
        Me.button1.Text = "&ShowGallery Custom Size"
        Me.button1.UseVisualStyleBackColor = True
        '
        'editor1
        '
        Me.editor1.HighLightTabs = False
        Me.editor1.Location = New System.Drawing.Point(0, 0)
        Me.editor1.Name = "editor1"
        Me.editor1.Options = Nothing
        Me.editor1.TabIndex = 0
        '
        'ChartEditor_Options
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(466, 286)
        Me.Name = "ChartEditor_Options"
        Me.panel1.ResumeLayout(False)
        Me.chartContainer.ResumeLayout(False)
        Me.chartContainer.PerformLayout()
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        CType(Me.editorHeight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.editorWidth, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox2.PerformLayout()
        CType(Me.editorGalleryHeight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.editorGalleryWidth, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox3.ResumeLayout(False)
        Me.groupBox4.ResumeLayout(False)
        Me.groupBox4.PerformLayout()
        CType(Me.ChartControllerEdHeight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartControllerEdWidth, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
#End Region

    Private Sub ChartEditor_Options_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        editor1.Width = CType(ChartControllerEdWidth.Value, Integer)
        editor1.Height = CType(ChartControllerEdHeight.Value, Integer)
        Me.editor1.Chart = Me.tChart1
        Me.chartController1.Chart = Me.tChart1
        Me.chartController1.Editor = Me.editor1
    End Sub
    Private Sub button1_Click_1(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
        Dim s As Styles.Series = Editors.ChartGallery.CreateNew(tChart1.Chart, Nothing, 650, 500)
        If (Not (s) Is Nothing) Then
            s.FillSampleValues()
        End If
    End Sub
    Private Sub bEditorRuntime_Click(ByVal sender As Object, ByVal e As EventArgs) Handles bEditorRuntime.Click
        Dim ed As Steema.TeeChart.Editors.ChartEditor = New Steema.TeeChart.Editors.ChartEditor(tChart1.Chart)
        ed.Width = CType(editorWidth.Value, Integer)
        ed.Height = CType(editorHeight.Value, Integer)
        Dim size As Size = New Size(CType(editorGalleryWidth.Value, Integer), CType(editorGalleryHeight.Value, Integer))
        ed.GallerySize = size
        ed.ShowDialog()
    End Sub

    Private Sub ChartControllerEdWidth_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ChartControllerEdWidth.ValueChanged
        editor1.Width = CType(ChartControllerEdWidth.Value, Integer)
    End Sub

    Private Sub ChartControllerEdHeight_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ChartControllerEdHeight.ValueChanged
        editor1.Height = CType(ChartControllerEdHeight.Value, Integer)
    End Sub

End Class