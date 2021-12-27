
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms


Public Class Legend_Title
    Inherits Steema.TeeChart.Samples.BaseForm
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
        Me.checkBox1 = New System.Windows.Forms.CheckBox
        Me.button1 = New System.Windows.Forms.Button
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Text = "The Legend Title property displays text at top of Legend rectangle." + vbCr + vbLf + vbCr + vbLf + "Chart1.Leg" + "end.Title.Visible = true "
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.button1)
        Me.panel1.Controls.Add(Me.checkBox1)
        Me.panel1.Name = "panel1"
        ' 
        ' tChart1
        ' 
        ' 
        ' tChart1.Axes
        ' 
        ' 
        ' tChart1.Axes.Bottom
        ' 
        ' 
        ' tChart1.Axes.Bottom.Labels
        ' 
        Me.tChart1.Axes.Bottom.Labels.Height = 0
        Me.tChart1.Axes.Bottom.Labels.Width = 0
        ' 
        ' tChart1.Axes.Bottom.Title
        ' 
        Me.tChart1.Axes.Bottom.Title.Height = 0
        Me.tChart1.Axes.Bottom.Title.Width = 0
        ' 
        ' tChart1.Axes.Depth
        ' 
        ' 
        ' tChart1.Axes.Depth.Labels
        ' 
        Me.tChart1.Axes.Depth.Labels.Height = 0
        Me.tChart1.Axes.Depth.Labels.Width = 0
        ' 
        ' tChart1.Axes.Depth.Title
        ' 
        Me.tChart1.Axes.Depth.Title.Height = 0
        Me.tChart1.Axes.Depth.Title.Width = 0
        ' 
        ' tChart1.Axes.DepthTop
        ' 
        ' 
        ' tChart1.Axes.DepthTop.Labels
        ' 
        Me.tChart1.Axes.DepthTop.Labels.Height = 0
        Me.tChart1.Axes.DepthTop.Labels.Width = 0
        ' 
        ' tChart1.Axes.DepthTop.Title
        ' 
        Me.tChart1.Axes.DepthTop.Title.Height = 0
        Me.tChart1.Axes.DepthTop.Title.Width = 0
        ' 
        ' tChart1.Axes.Left
        ' 
        ' 
        ' tChart1.Axes.Left.Labels
        ' 
        Me.tChart1.Axes.Left.Labels.Height = 0
        Me.tChart1.Axes.Left.Labels.Width = 0
        ' 
        ' tChart1.Axes.Left.Title
        ' 
        Me.tChart1.Axes.Left.Title.Height = 0
        Me.tChart1.Axes.Left.Title.Width = 0
        ' 
        ' tChart1.Axes.Right
        ' 
        ' 
        ' tChart1.Axes.Right.Labels
        ' 
        Me.tChart1.Axes.Right.Labels.Height = 0
        Me.tChart1.Axes.Right.Labels.Width = 0
        ' 
        ' tChart1.Axes.Right.Title
        ' 
        Me.tChart1.Axes.Right.Title.Height = 0
        Me.tChart1.Axes.Right.Title.Width = 0
        ' 
        ' tChart1.Axes.Top
        ' 
        ' 
        ' tChart1.Axes.Top.Labels
        ' 
        Me.tChart1.Axes.Top.Labels.Height = 0
        Me.tChart1.Axes.Top.Labels.Width = 0
        ' 
        ' tChart1.Axes.Top.Title
        ' 
        Me.tChart1.Axes.Top.Title.Height = 0
        Me.tChart1.Axes.Top.Title.Width = 0
        ' 
        ' tChart1.Footer
        ' 
        Me.tChart1.Footer.Height = 0
        Me.tChart1.Footer.Width = 0
        ' 
        ' tChart1.Header
        ' 
        Me.tChart1.Header.Height = 14
        Me.tChart1.Header.Lines = New String() {"TeeChart"}
        Me.tChart1.Header.Width = 62
        ' 
        ' tChart1.Legend
        ' 
        Me.tChart1.Legend.Height = 0
        ' 
        ' tChart1.Legend.Title
        ' 
        ' 
        ' tChart1.Legend.Title.Font
        ' 
        Me.tChart1.Legend.Title.Font.Bold = True
        Me.tChart1.Legend.Title.Height = 0
        Me.tChart1.Legend.Title.Width = 0
        Me.tChart1.Legend.Width = 0
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        Me.tChart1.Panel.Height = 0
        Me.tChart1.Panel.Width = 0
        ' 
        ' tChart1.SubFooter
        ' 
        Me.tChart1.SubFooter.Height = 0
        Me.tChart1.SubFooter.Width = 0
        ' 
        ' tChart1.SubHeader
        ' 
        Me.tChart1.SubHeader.Height = 0
        Me.tChart1.SubHeader.Width = 0
        ' 
        ' tChart1.Walls
        ' 
        ' 
        ' tChart1.Walls.Back
        ' 
        Me.tChart1.Walls.Back.Height = 0
        Me.tChart1.Walls.Back.Width = 0
        ' 
        ' tChart1.Walls.Bottom
        ' 
        Me.tChart1.Walls.Bottom.Height = 0
        Me.tChart1.Walls.Bottom.Width = 0
        ' 
        ' tChart1.Walls.Left
        ' 
        Me.tChart1.Walls.Left.Height = 0
        Me.tChart1.Walls.Left.Width = 0
        ' 
        ' tChart1.Walls.Right
        ' 
        Me.tChart1.Walls.Right.Height = 0
        Me.tChart1.Walls.Right.Width = 0
        ' 
        ' checkBox1
        ' 
        Me.checkBox1.Checked = True
        Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox1.Location = New System.Drawing.Point(16, 8)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.TabIndex = 0
        Me.checkBox1.Text = "Visible"
        AddHandler Me.checkBox1.Click, AddressOf Me.checkBox1_Click
        ' 
        ' button1
        ' 
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.Location = New System.Drawing.Point(152, 8)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(120, 23)
        Me.button1.TabIndex = 1
        Me.button1.Text = "Legend Properties..."
        AddHandler Me.button1.Click, AddressOf Me.button1_Click
        ' 
        ' Legend_Title
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(440, 317)
        Me.Name = "Legend_Title"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub 'New 
#End Region

    Private checkBox1 As System.Windows.Forms.CheckBox
    Private button1 As System.Windows.Forms.Button

    Private line1 As Steema.TeeChart.Styles.Line

    Private Sub InitializeChart()
        line1 = New Steema.TeeChart.Styles.Line(tChart1.Chart)
        line1.FillSampleValues()
        tChart1.Legend.Title.Visible = True
        tChart1.Legend.Title.Text = "Values"
    End Sub 'InitializeChart


    Private Sub checkBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        tChart1.Legend.Title.Visible = checkBox1.Checked
    End Sub 'checkBox1_Click


    Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim legend As New Steema.TeeChart.Editors.LegendEditor(tChart1.Chart, Nothing)
        Steema.TeeChart.Editors.EditorUtils.ShowFormModal(legend)
    End Sub 'button1_Click
End Class 'Legend_Title