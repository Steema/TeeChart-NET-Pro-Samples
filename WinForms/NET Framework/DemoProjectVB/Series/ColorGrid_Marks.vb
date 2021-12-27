
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms


Public Class ColorGrid_Marks
    Inherits Steema.TeeChart.Samples.BaseForm
    Private colorGrid1 As Steema.TeeChart.Styles.ColorGrid
    Private checkBox1 As System.Windows.Forms.CheckBox
    Private button1 As System.Windows.Forms.Button
    Private checkBox2 As System.Windows.Forms.CheckBox
    Private components As System.ComponentModel.IContainer = Nothing
    
    Public Sub New() ' This call is required by the Windows Form Designer.
        InitializeComponent()

        colorGrid1.FillSampleValues(5)
    End Sub


    '/ <summary>
    '/ Clean up any resources being used.
    '/ </summary>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If Disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(Disposing)
    End Sub 'Dispose

#Region "Windows Form Designer generated code"

    '/ <summary>
    '/ Required method for Designer support - do not modify
    '/ the contents of this method with the code editor.
    '/ </summary>
    Private Sub InitializeComponent()
        Me.colorGrid1 = New Steema.TeeChart.Styles.ColorGrid
        Me.checkBox1 = New System.Windows.Forms.CheckBox
        Me.button1 = New System.Windows.Forms.Button
        Me.checkBox2 = New System.Windows.Forms.CheckBox
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Text = "ColorGrid series can now display Marks. " + vbCr + vbLf + vbCr + vbLf + "colorGrid1.Marks.Visible = true "
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.checkBox2)
        Me.panel1.Controls.Add(Me.button1)
        Me.panel1.Controls.Add(Me.checkBox1)
        Me.panel1.Name = "panel1"
        ' 
        ' tChart1
        ' 
        ' 
        ' tChart1.Aspect
        ' 
        Me.tChart1.Aspect.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality
        Me.tChart1.Aspect.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        Me.tChart1.Aspect.View3D = False
        ' 
        ' tChart1.Header
        ' 
        Me.tChart1.Header.Lines = New String() {"tChart1"}
        ' 
        ' tChart1.Legend
        ' 
        Me.tChart1.Legend.MaxNumRows = 8
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Brush
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.tChart1.Series.Add(Me.colorGrid1)
        ' 
        ' colorGrid1
        ' 
        ' 
        ' colorGrid1.Brush
        ' 
        Me.colorGrid1.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        Me.colorGrid1.CenteredPoints = True
        ' 
        ' colorGrid1.Marks
        ' 
        Me.colorGrid1.Marks.ArrowLength = 0
        ' 
        ' colorGrid1.Marks.Symbol
        ' 
        ' 
        ' colorGrid1.Marks.Symbol.Shadow
        ' 
        Me.colorGrid1.Marks.Symbol.Shadow.Height = 1
        Me.colorGrid1.Marks.Symbol.Shadow.Visible = True
        Me.colorGrid1.Marks.Symbol.Shadow.Width = 1
        Me.colorGrid1.Marks.Visible = True
        Me.colorGrid1.PaletteMin = 0
        Me.colorGrid1.PaletteStep = 0
        Me.colorGrid1.StartColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(206, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        Me.colorGrid1.Title = "colorGrid1"
        ' 
        ' colorGrid1.XValues
        ' 
        Me.colorGrid1.XValues.DataMember = "X"
        ' 
        ' colorGrid1.YValues
        ' 
        Me.colorGrid1.YValues.DataMember = "Y"
        ' 
        ' colorGrid1.ZValues
        ' 
        Me.colorGrid1.ZValues.DataMember = "Z"
        ' 
        ' checkBox1
        ' 
        Me.checkBox1.Checked = True
        Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox1.Location = New System.Drawing.Point(16, 8)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.TabIndex = 0
        Me.checkBox1.Text = "View Marks"
        AddHandler Me.checkBox1.Click, AddressOf Me.checkBox1_Click
        ' 
        ' button1
        ' 
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.Location = New System.Drawing.Point(144, 8)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(76, 25)
        Me.button1.TabIndex = 1
        Me.button1.Text = "Edit Marks..."
        AddHandler Me.button1.Click, AddressOf Me.button1_Click
        ' 
        ' checkBox2
        ' 
        Me.checkBox2.Checked = True
        Me.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox2.Location = New System.Drawing.Point(288, 13)
        Me.checkBox2.Name = "checkBox2"
        Me.checkBox2.Size = New System.Drawing.Size(104, 19)
        Me.checkBox2.TabIndex = 2
        Me.checkBox2.Text = "Centered Points"
        AddHandler Me.checkBox2.Click, AddressOf Me.checkBox2_Click
        ' 
        ' ColorGrid_Marks
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(440, 317)
        Me.Name = "ColorGrid_Marks"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub 'New 
#End Region


    Private Sub checkBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        colorGrid1.Marks.Visible = checkBox1.Checked
    End Sub 'checkBox1_Click


    Private Sub checkBox2_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        colorGrid1.CenteredPoints = checkBox2.Checked
    End Sub 'checkBox2_Click


    Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim marksEditor As New Steema.TeeChart.Editors.SeriesMarksEditor(colorGrid1.Marks, Nothing)
        Steema.TeeChart.Editors.EditorUtils.ShowFormModal(marksEditor)
    End Sub 'button1_Click
End Class 'ColorGrid_Marks