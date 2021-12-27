
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports Steema.TeeChart

'/ <summary>
'/ Summary description for BaseForm.
'/ </summary>

Public Class BaseForm
    Inherits System.Windows.Forms.Form
    Friend Protected WithEvents textBox1 As System.Windows.Forms.TextBox
    Protected panel1 As System.Windows.Forms.Panel
    Protected WithEvents tChart1 As Steema.TeeChart.TChart
    Protected chartContainer As System.Windows.Forms.Panel

    '/ <summary>
    '/ Required designer variable.
    '/ </summary>
    Private components As System.ComponentModel.Container = Nothing
    Public Sub New()
        '
        ' Required for Windows Form Designer support
        '
        InitializeComponent()
    tChart1.Aspect.ColorPaletteIndex = 13

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

#Region "Windows Form Designer generated code"

    '/ <summary>
    '/ Required method for Designer support - do not modify
    '/ the contents of this method with the code editor.
    '/ </summary>
    Private Sub InitializeComponent()
        Me.textBox1 = New System.Windows.Forms.TextBox
        Me.panel1 = New System.Windows.Forms.Panel
        Me.chartContainer = New System.Windows.Forms.Panel
        Me.tChart1 = New Steema.TeeChart.TChart
        Me.chartContainer.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.BackColor = System.Drawing.Color.FromArgb(CType(255, System.Byte), CType(255, System.Byte), CType(192, System.Byte))
        Me.textBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.textBox1.Location = New System.Drawing.Point(0, 0)
        Me.textBox1.Multiline = True
        Me.textBox1.Name = "textBox1"
        Me.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.textBox1.Size = New System.Drawing.Size(440, 73)
        Me.textBox1.TabIndex = 1
        'Me.textBox1.Text = ""
        AddHandler textBox1.DoubleClick, AddressOf Me.textBox1_DoubleClick
        ' 
        ' panel1
        ' 
        Me.panel1.BackColor = System.Drawing.Color.White
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel1.Location = New System.Drawing.Point(0, 73)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(440, 39)
        Me.panel1.TabIndex = 2
        ' 
        ' chartContainer
        ' 
        Me.chartContainer.Controls.Add(Me.tChart1)
        Me.chartContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chartContainer.Location = New System.Drawing.Point(0, 112)
        Me.chartContainer.Name = "chartContainer"
        Me.chartContainer.Size = New System.Drawing.Size(440, 205)
        Me.chartContainer.TabIndex = 3
        ' 
        ' tChart1
        ' 
        Me.tChart1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tChart1.Location = New System.Drawing.Point(0, 112)
        Me.tChart1.Name = "tChart1"
        Me.tChart1.Size = New System.Drawing.Size(440, 205)
        Me.tChart1.TabIndex = 3
        ' 
        ' BaseForm
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(440, 317)
        Me.Controls.Add(Me.chartContainer)
        Me.Controls.Add(panel1)
        Me.Controls.Add(textBox1)
        Me.Name = "BaseForm"
        Me.chartContainer.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub 'InitializeComponent 
#End Region


    Private Sub textBox1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles textBox1.DoubleClick
        tChart1.ShowEditor()
    End Sub 'textBox1_DoubleClick

    Public Sub ChangeCanvas(ByVal canvas As MainForm.CanvasType)
        Select Case (canvas)
            'case CanvasType.GDI:
            '  tChart1.Graphics3D = new Steema.TeeChart.Drawing.Graphics3DGdi(tChart1.Chart);
            '  tChart1.Invalidate();
            '  break;
            Case MainForm.CanvasType.GDIPlus
                tChart1.Graphics3D = New Steema.TeeChart.Drawing.Graphics3DGdiPlus(tChart1.Chart)
                tChart1.Invalidate()
                'case CanvasType.OpenGL:
                '  Steema.TeeChart.Drawing.GL.TeeOpenGL openGL = new Steema.TeeChart.Drawing.GL.TeeOpenGL(tChart1);
                '  tChart1.Graphics3D = new Steema.TeeChart.Drawing.GL.GraphicsGL(tChart1.Chart, openGL);
                '  openGL.Chart = tChart1;
                '  openGL.Active = true;
                '  tChart1.Invalidate();
                '  break;
        End Select
    End Sub

End Class 'BaseForm