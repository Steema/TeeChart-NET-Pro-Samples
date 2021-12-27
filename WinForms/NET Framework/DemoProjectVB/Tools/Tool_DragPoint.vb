
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing

Imports System.Windows.Forms




Public Class Tool_DragPoint
    Inherits Samples.BaseForm
    Private lineSeries1 As Steema.TeeChart.Styles.Line
    Private dragPoint1 As Steema.TeeChart.Tools.DragPoint
    Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
    Private WithEvents comboBox1 As System.Windows.Forms.ComboBox
    Private label1 As System.Windows.Forms.Label
    Private WithEvents button1 As System.Windows.Forms.Button
    Private components As System.ComponentModel.IContainer = Nothing
    
    
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        
        Me.lineSeries1.FillSampleValues(20)
        Me.lineSeries1.Pointer.Visible = True
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
        Me.lineSeries1 = New Steema.TeeChart.Styles.Line
        Me.dragPoint1 = New Steema.TeeChart.Tools.DragPoint
        Me.checkBox1 = New System.Windows.Forms.CheckBox
        Me.comboBox1 = New System.Windows.Forms.ComboBox
        Me.label1 = New System.Windows.Forms.Label
        Me.button1 = New System.Windows.Forms.Button
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(466, 48)
        Me.textBox1.Text = "The Drag Point tool allows clicking and moving Series points at run-time, using t" + "he mouse." + vbCr + vbLf + "Click and drag a point !"
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.button1)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Controls.Add(Me.comboBox1)
        Me.panel1.Controls.Add(Me.checkBox1)
        Me.panel1.Location = New System.Drawing.Point(0, 48)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(466, 41)
        ' 
        ' tChart1
        ' 
        ' 
        ' tChart1.Aspect
        ' 
        Me.tChart1.Aspect.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality
        Me.tChart1.Aspect.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        ' 
        ' tChart1.Header
        ' 
        Me.tChart1.Header.Lines = New String() {"Drag point tool"}
        Me.tChart1.Location = New System.Drawing.Point(0, 89)
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Brush
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.tChart1.Series.Add(Me.lineSeries1)
        Me.tChart1.Size = New System.Drawing.Size(466, 197)
        Me.tChart1.Tools.Add(Me.dragPoint1)
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
        Me.tChart1.Walls.Bottom.Size = 5
        ' 
        ' tChart1.Walls.Left
        ' 
        ' 
        ' tChart1.Walls.Left.Pen
        ' 
        Me.tChart1.Walls.Left.Pen.Visible = False
        Me.tChart1.Walls.Left.Size = 5
        ' 
        ' lineSeries1
        ' 
        ' 
        ' lineSeries1.Brush
        ' 
        Me.lineSeries1.Brush.Color = System.Drawing.Color.Red
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
        ' dragPoint1
        ' 
        Me.dragPoint1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dragPoint1.Series = Me.lineSeries1
        ' 
        ' checkBox1
        ' 
        Me.checkBox1.Checked = True
        Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox1.Location = New System.Drawing.Point(13, 7)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(54, 21)
        Me.checkBox1.TabIndex = 0
        Me.checkBox1.Text = "&Active"
        ' 
        ' comboBox1
        ' 
        Me.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboBox1.Items.AddRange(New Object() {"X only", "Y only", "X and Y"})
        Me.comboBox1.Location = New System.Drawing.Point(130, 7)
        Me.comboBox1.Name = "comboBox1"
        Me.comboBox1.Size = New System.Drawing.Size(100, 21)
        Me.comboBox1.TabIndex = 1
        ' 
        ' label1
        ' 
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(96, 9)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(33, 16)
        Me.label1.TabIndex = 2
        Me.label1.Text = "&Style:"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        ' 
        ' button1
        ' 
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.Location = New System.Drawing.Point(273, 6)
        Me.button1.Name = "button1"
        Me.button1.TabIndex = 3
        Me.button1.Text = "&Edit..."
        ' 
        ' Tool_DragPoint
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(466, 286)
        Me.Name = "Tool_DragPoint"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub 'InitializeComponent 
#End Region


    Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox1.CheckedChanged
        Me.dragPoint1.Active = checkBox1.Checked
    End Sub 'checkBox1_CheckedChanged


    Private Sub Tools_DragPoint_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.comboBox1.SelectedIndex = 2
    End Sub 'Tools_DragPoint_Load


    Private Sub comboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboBox1.SelectedIndexChanged
        Me.dragPoint1.Style = CType(comboBox1.SelectedIndex, Steema.TeeChart.Tools.DragPointStyles)
    End Sub 'comboBox1_SelectedIndexChanged


    Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
        TeeChart.Editors.Tools.ToolsEditor.ShowEditor(Me.dragPoint1)
    End Sub 'button1_Click
End Class 'Tool_DragPoint
