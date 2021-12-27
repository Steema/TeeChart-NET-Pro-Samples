Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Steema.TeeChart.Drawing
Imports Steema.TeeChart.Styles
Imports Steema.TeeChart.Tools
Imports System.IO
Public Class CompactCharts
    Inherits BaseForm
    Private WithEvents button1 As Button
    Private label2 As Label
    Private label1 As Label
    Private udWidth As NumericUpDown
    Private udHeight As NumericUpDown
    Private folderBrowserDialog1 As FolderBrowserDialog
    ' /<summary>
    '/ Required designer variable.
    '/ </summary>
    Private components As System.ComponentModel.IContainer = Nothing
    '/<summary>
    '/Clean up any resources being used.
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
    '/<summary>
    '/ Required method for Designer support - do not modify
    '/the contents of this method with the code editor.
    ' /</summary>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CompactCharts))
        Me.button1 = New System.Windows.Forms.Button
        Me.udHeight = New System.Windows.Forms.NumericUpDown
        Me.udWidth = New System.Windows.Forms.NumericUpDown
        Me.label1 = New System.Windows.Forms.Label
        Me.label2 = New System.Windows.Forms.Label
        Me.folderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        Me.panel1.SuspendLayout()
        Me.chartContainer.SuspendLayout()
        CType(Me.udHeight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.udWidth, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'textBox1
        '
        Me.textBox1.Text = resources.GetString("textBox1.Text")
        '
        'panel1
        '
        Me.panel1.Controls.Add(Me.label2)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Controls.Add(Me.udWidth)
        Me.panel1.Controls.Add(Me.udHeight)
        Me.panel1.Controls.Add(Me.button1)
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
        Me.tChart1.Location = New System.Drawing.Point(0, 0)
        '
        'button1
        '
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.Location = New System.Drawing.Point(12, 10)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(199, 23)
        Me.button1.TabIndex = 0
        Me.button1.Text = "Create and Open CompactChart..."
        Me.button1.UseVisualStyleBackColor = True
        '
        'udHeight
        '
        Me.udHeight.Increment = New Decimal(New Integer() {50, 0, 0, 0})
        Me.udHeight.Location = New System.Drawing.Point(370, 13)
        Me.udHeight.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.udHeight.Name = "udHeight"
        Me.udHeight.Size = New System.Drawing.Size(47, 20)
        Me.udHeight.TabIndex = 1
        '
        'udWidth
        '
        Me.udWidth.Increment = New Decimal(New Integer() {50, 0, 0, 0})
        Me.udWidth.Location = New System.Drawing.Point(270, 13)
        Me.udWidth.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.udWidth.Name = "udWidth"
        Me.udWidth.Size = New System.Drawing.Size(47, 20)
        Me.udWidth.TabIndex = 2
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(226, 15)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(38, 13)
        Me.label1.TabIndex = 3
        Me.label1.Text = "Width:"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(323, 15)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(41, 13)
        Me.label2.TabIndex = 4
        Me.label2.Text = "Height:"
        '
        'CompactCharts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(440, 317)
        Me.Name = "CompactCharts"
        Me.Text = "CompactCharts"
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.chartContainer.ResumeLayout(False)
        CType(Me.udHeight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.udWidth, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
#End Region
    Public Sub New()
        InitializeComponent()
        udWidth.Value = 250
        udHeight.Value = 150
        InitializeChart()
    End Sub
    Private Sub Initializechart()
        tChart1.Aspect.View3D = False
        tChart1.Legend.Visible = False
        tChart1.Header.Font.Color = Color.FromArgb(154, 154, 154)
        tChart1.Header.Text = "Euribor"
        tChart1.Panel.Bevel.Inner = BevelStyles.None
        tChart1.Panel.Bevel.Outer = BevelStyles.None
        tChart1.Panel.Color = Color.White
        tChart1.Panel.Gradient.Visible = False
        tChart1.Axes.Left.AxisPen.Color = Color.FromArgb(120, 60, 20)
        tChart1.Axes.Left.AxisPen.Width = 4
        tChart1.Axes.Left.MinorTicks.Visible = False
        tChart1.Axes.Left.Grid.Color = Color.FromArgb(245, 225, 170)
        tChart1.Axes.Left.Grid.Style = System.Drawing.Drawing2D.DashStyle.Solid
        tChart1.Axes.Bottom.AxisPen.Color = Color.FromArgb(120, 60, 20)
        tChart1.Axes.Bottom.Grid.Visible = False
        tChart1.Axes.Bottom.MinorTicks.Visible = False
        tChart1.Axes.Bottom.AxisPen.Width = 4
        tChart1.Walls.Back.Pen.Visible = False
        tChart1.Walls.Back.Gradient.Visible = False
        tChart1.Walls.Back.Color = Color.White
        Dim series1 As Steema.TeeChart.Styles.Line = New Steema.TeeChart.Styles.Line(tChart1.Chart)
        series1.Color = Color.FromArgb(128, 128, 128)
        series1.Pointer.Style = PointerStyles.Circle
        series1.Pointer.Visible = True
        series1.Add(5.323, "08-Aug")
        series1.Add(5.384, "08-Sep")
        series1.Add(5.248, "08-Oct")
        series1.Add(4.35, "08-Nov")
        series1.Add(3.452, "08-Dec")
        series1.Add(2.622, "09-Jan")
        series1.Add(2.135, "09-Feb")
        Dim region As Steema.TeeChart.Tools.SeriesRegionTool = New Steema.TeeChart.Tools.SeriesRegionTool(tChart1.Chart)
        region.Color = Color.FromArgb(225, 225, 255)
        region.Transparency = 50
        region.Series = series1
        Dim markstip As Steema.TeeChart.Tools.MarksTip = New MarksTip(tChart1.Chart)
        markstip.Series = series1
#If (VS2005) Then
        markstip.BackColor = Color.White
#End If
        markstip.Style = MarksStyles.Value
        Dim expand As Steema.TeeChart.Animations.Expand
        expand = New Steema.TeeChart.Animations.Expand()
        tChart1.Animations.Add(expand)
        expand.Target = ChartClickedPartStyle.SeriesPointer
        expand.Trigger = Steema.TeeChart.Animations.AnimationTrigger.MouseOver
    End Sub
    Private Sub CompileAndShow()
        Dim tmpPath As String = Steema.TeeChart.Utils.Registry_GetValue(Utils.TeeChartKeyName, "FlexCanvas_Temp", "").ToString
        If (Steema.TeeChart.Utils.IsNullOrEmpty(tmpPath) _
                    OrElse Not Directory.Exists(tmpPath)) Then
            tmpPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal)
            Steema.TeeChart.Utils.Registry_SetValue(Utils.TeeChartKeyName, "FlexCanvas_Temp", tmpPath)
        End If
        Steema.TeeChart.Export.FlexOptions.CompileDeleteShow(tChart1.Chart, CType(udWidth.Value, Integer), CType(udHeight.Value, Integer), tmpPath, False, True, True)
    End Sub
    Private Function RecurSiveChooseFolder() As Boolean
        Dim result As Boolean = False
        folderBrowserDialog1.Description = "Adobe Flex 3 SDK folder"
        folderBrowserDialog1.ShowNewFolderButton = False
        Select Case (folderBrowserDialog1.ShowDialog)
      Case System.Windows.Forms.DialogResult.Cancel
        result = True
      Case System.Windows.Forms.DialogResult.OK
        If File.Exists((folderBrowserDialog1.SelectedPath + "\\bin\\mxmlc.exe")) Then
                    Steema.TeeChart.Utils.Registry_SetValue(Utils.TeeChartKeyName, "FlexCanvas_Compiler", (folderBrowserDialog1.SelectedPath + "\\bin"))
                    result = True
                End If
        End Select
        Return result
    End Function
    Private Function TryCompileAndShow() As Boolean
        Dim result As Boolean = False
        Dim mxmlc As String = CType(Steema.TeeChart.Utils.Registry_GetValue(Utils.TeeChartKeyName, "FlexCanvas_Compiler", ""), String)
        mxmlc = (mxmlc + "\\mxmlc.exe")
        If File.Exists(mxmlc) Then
            result = True
            CompileAndShow()
        End If
        Return result
    End Function
    Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
        If Not TryCompileAndShow() Then
            If Steema.TeeChart.Utils.YesNo(("For this demonstration to work, you need the Adobe Flex 3 SDK" _
                            + (Environment.NewLine + ("installed on your machine" _
                            + (Environment.NewLine _
                            + (Environment.NewLine + ("If you have the Flex SDK installed on your machine, please click yes to select the folder." _
                            + (Environment.NewLine _
                            + (Environment.NewLine + "Otherwise click no to be taken to the download location."))))))))) Then
                Dim canCompile As Boolean = False
                While Not canCompile
                    canCompile = RecurSiveChooseFolder()
                    If canCompile Then
                        TryCompileAndShow()
                    End If

                End While
            Else
                System.Diagnostics.Process.Start("http://www.adobe.com/products/flex/flexdownloads/")
            End If
        End If
    End Sub

End Class