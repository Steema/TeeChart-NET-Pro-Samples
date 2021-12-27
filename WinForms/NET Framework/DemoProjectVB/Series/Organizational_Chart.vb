
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing

Imports System.Windows.Forms



Public Class Organizational_Chart
    Inherits Samples.BaseForm

    Private WithEvents button1 As Button
    Private s As Styles.OrgSeries
    '/ <summary>
    '/ Required designer variable.
    '/ </summary>
    Private components As System.ComponentModel.IContainer = Nothing


    Public Sub New() ' me call is required by the Windows Form Designer.
        InitializeComponent()
    End Sub

  Private Sub Organizational_Chart_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
    s = New Steema.TeeChart.Styles.OrgSeries(tChart1.Chart)
    s.Pen.Width = 2
    s.Pen.Style = System.Drawing.Drawing2D.DashStyle.Dot
    s.FillSampleValues()
  End Sub

  Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
    Dim editor As Steema.TeeChart.Editors.Series.OrgChartEditor = New Steema.TeeChart.Editors.Series.OrgChartEditor(s)
    Steema.TeeChart.Editors.EditorUtils.ShowFormModal(editor)
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
  '/ the contents of me method with the code editor.
  '/ </summary>
  Private Sub InitializeComponent()
    Me.button1 = New System.Windows.Forms.Button
    Me.panel1.SuspendLayout()
    Me.chartContainer.SuspendLayout()
    Me.SuspendLayout()
    ' 
    ' textBox1
    ' 
    Me.textBox1.Text = "Organizational Charts display elements in hierarchical structures, such as Compan" + _
            "y and  Employers."
    ' 
    ' panel1
    ' 
    Me.panel1.Controls.Add(Me.button1)
    ' 
    ' tChart1
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
    Me.tChart1.Axes.Bottom.Labels.TextAlign = System.Drawing.StringAlignment.Center
    ' 
    ' 
    ' 
    Me.tChart1.Axes.Bottom.Title.TextAlign = System.Drawing.StringAlignment.Center
    ' 
    ' 
    ' 
    ' 
    ' 
    ' 
    Me.tChart1.Axes.Depth.Labels.TextAlign = System.Drawing.StringAlignment.Center
    ' 
    ' 
    ' 
    Me.tChart1.Axes.Depth.Title.TextAlign = System.Drawing.StringAlignment.Center
    ' 
    ' 
    ' 
    ' 
    ' 
    ' 
    Me.tChart1.Axes.DepthTop.Labels.TextAlign = System.Drawing.StringAlignment.Center
    ' 
    ' 
    ' 
    Me.tChart1.Axes.DepthTop.Title.TextAlign = System.Drawing.StringAlignment.Center
    ' 
    ' 
    ' 
    ' 
    ' 
    ' 
    Me.tChart1.Axes.Left.Labels.TextAlign = System.Drawing.StringAlignment.Center
    ' 
    ' 
    ' 
    Me.tChart1.Axes.Left.Title.TextAlign = System.Drawing.StringAlignment.Center
    ' 
    ' 
    ' 
    ' 
    ' 
    ' 
    Me.tChart1.Axes.Right.Labels.TextAlign = System.Drawing.StringAlignment.Center
    ' 
    ' 
    ' 
    Me.tChart1.Axes.Right.Title.TextAlign = System.Drawing.StringAlignment.Center
    ' 
    ' 
    ' 
    ' 
    ' 
    ' 
    Me.tChart1.Axes.Top.Labels.TextAlign = System.Drawing.StringAlignment.Center
    ' 
    ' 
    ' 
    Me.tChart1.Axes.Top.Title.TextAlign = System.Drawing.StringAlignment.Center
    ' 
    ' 
    ' 
    Me.tChart1.Footer.TextAlign = System.Drawing.StringAlignment.Center
    ' 
    ' 
    ' 
    Me.tChart1.Header.TextAlign = System.Drawing.StringAlignment.Center
    ' 
    ' 
    ' 
    Me.tChart1.Legend.TextAlign = System.Drawing.StringAlignment.Center
    ' 
    ' 
    ' 
    ' 
    ' 
    ' 
    Me.tChart1.Legend.Title.Pen.Visible = False
    Me.tChart1.Size = New System.Drawing.Size(440, 205)
    ' 
    ' 
    ' 
    Me.tChart1.SubFooter.TextAlign = System.Drawing.StringAlignment.Center
    ' 
    ' 
    ' 
    Me.tChart1.SubHeader.TextAlign = System.Drawing.StringAlignment.Center
    ' 
    ' button1
    ' 
    Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.button1.Location = New System.Drawing.Point(12, 10)
    Me.button1.Name = "button1"
    Me.button1.Size = New System.Drawing.Size(75, 23)
    Me.button1.TabIndex = 0
    Me.button1.Text = "&Edit"
#If VS2005 Then
        Me.button1.UseVisualStyleBackColor = True
#End If
    ' 
    ' Organizational_Chart
    ' 
    Me.ClientSize = New System.Drawing.Size(440, 317)
    Me.Name = "Organizational_Chart"
    Me.panel1.ResumeLayout(False)
    Me.chartContainer.ResumeLayout(False)
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

#End Region

End Class

