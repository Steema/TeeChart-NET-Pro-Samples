
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing

Imports System.Windows.Forms




Public Class Tool_Annotation
    Inherits Samples.BaseForm
    Private lineSeries1 As Steema.TeeChart.Styles.Line
    Private annotation1 As Steema.TeeChart.Tools.Annotation
    Private annotation2 As Steema.TeeChart.Tools.Annotation
    Private annotation3 As Steema.TeeChart.Tools.Annotation
    Private WithEvents button1 As System.Windows.Forms.Button
    Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
    Private components As System.ComponentModel.IContainer = Nothing
    
    
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        
        Me.lineSeries1.FillSampleValues(20)
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
        Me.annotation1 = New Steema.TeeChart.Tools.Annotation
        Me.annotation2 = New Steema.TeeChart.Tools.Annotation
        Me.annotation3 = New Steema.TeeChart.Tools.Annotation
        Me.button1 = New System.Windows.Forms.Button
        Me.checkBox1 = New System.Windows.Forms.CheckBox
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(466, 63)
        Me.textBox1.Text = "The Annotation tool is a general purpose component to show text over Chart panels" + ". It includes formatting properties and custom positioning."
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.checkBox1)
        Me.panel1.Controls.Add(Me.button1)
        Me.panel1.Location = New System.Drawing.Point(0, 63)
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
        Me.tChart1.Aspect.View3D = False
        ' 
        ' tChart1.Header
        ' 
        Me.tChart1.Header.Lines = New String() {"Annotation tool example"}
        ' 
        ' tChart1.Legend
        ' 
        Me.tChart1.Legend.Alignment = Steema.TeeChart.LegendAlignments.Top
        Me.tChart1.Legend.Visible = False
        Me.tChart1.Location = New System.Drawing.Point(0, 104)
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Brush
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.tChart1.Series.Add(Me.lineSeries1)
        Me.tChart1.Size = New System.Drawing.Size(466, 182)
        Me.tChart1.Tools.Add(Me.annotation1)
        Me.tChart1.Tools.Add(Me.annotation2)
        Me.tChart1.Tools.Add(Me.annotation3)
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
        Me.lineSeries1.Title = "line1"
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
        ' annotation1
        ' 
        Me.annotation1.Cursor = System.Windows.Forms.Cursors.Default
        Me.annotation1.Left = 65
        ' 
        ' annotation1.Shape
        ' 
        Me.annotation1.Shape.Bottom = 142
        Me.annotation1.Shape.CustomPosition = True
        Me.annotation1.Shape.Left = 65
        Me.annotation1.Shape.Lines = New String() {"Annotation1"}
        Me.annotation1.Shape.Right = 133
        ' 
        ' annotation1.Shape.Shadow
        ' 
        ' 
        ' annotation1.Shape.Shadow.Brush
        ' 
        Me.annotation1.Shape.Shadow.Brush.Color = System.Drawing.Color.Gray
        Me.annotation1.Shape.Shadow.Visible = True
        Me.annotation1.Shape.Top = 125
        Me.annotation1.Text = "Annotation1"
        Me.annotation1.Top = 125
        ' 
        ' annotation2
        ' 
        Me.annotation2.Cursor = System.Windows.Forms.Cursors.Default
        Me.annotation2.Left = 130
        ' 
        ' annotation2.Shape
        ' 
        Me.annotation2.Shape.Bottom = 87
        ' 
        ' annotation2.Shape.Brush
        ' 
        Me.annotation2.Shape.Brush.Color = System.Drawing.Color.FromArgb(CType(255, System.Byte), CType(128, System.Byte), CType(255, System.Byte))
        Me.annotation2.Shape.CustomPosition = True
        Me.annotation2.Shape.Left = 130
        Me.annotation2.Shape.Lines = New String() {"Annotation 2"}
        Me.annotation2.Shape.Right = 201
        ' 
        ' annotation2.Shape.Shadow
        ' 
        ' 
        ' annotation2.Shape.Shadow.Brush
        ' 
        Me.annotation2.Shape.Shadow.Brush.Color = System.Drawing.Color.Black
        Me.annotation2.Shape.Shadow.Visible = True
        Me.annotation2.Shape.Top = 70
        Me.annotation2.Text = "Annotation 2"
        Me.annotation2.Top = 70
        ' 
        ' annotation3
        ' 
        Me.annotation3.Cursor = System.Windows.Forms.Cursors.Default
        Me.annotation3.Position = Steema.TeeChart.Tools.AnnotationPositions.RightTop
        ' 
        ' annotation3.Shape
        ' 
        ' 
        ' annotation3.Shape.Bevel
        ' 
        Me.annotation3.Shape.Bevel.Inner = Steema.TeeChart.Drawing.BevelStyles.Raised
        ' 
        ' annotation3.Shape.Brush
        ' 
        Me.annotation3.Shape.Brush.Color = System.Drawing.Color.FromArgb(CType(255, System.Byte), CType(255, System.Byte), CType(128, System.Byte))
        Me.annotation3.Shape.Lines = New String() {"Another one"}
        ' 
        ' annotation3.Shape.Shadow
        ' 
        Me.annotation3.Shape.Shadow.Visible = True
        Me.annotation3.Text = "Another one"
        ' 
        ' button1
        ' 
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.Location = New System.Drawing.Point(13, 7)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(115, 23)
        Me.button1.TabIndex = 0
        Me.button1.Text = "&Edit annotation..."
        ' 
        ' checkBox1
        ' 
        Me.checkBox1.Checked = True
        Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox1.Location = New System.Drawing.Point(147, 7)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(93, 21)
        Me.checkBox1.TabIndex = 1
        Me.checkBox1.Text = "&Visible"
        ' 
        ' Tool_Annotation
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(466, 286)
        Me.Name = "Tool_Annotation"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub 'InitializeComponent 
#End Region


    Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
        TeeChart.Editors.Tools.ToolsEditor.ShowEditor(Me.annotation1)
    End Sub 'button1_Click


    Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox1.CheckedChanged
        Me.annotation1.Active = checkBox1.Checked
        Me.annotation2.Active = checkBox1.Checked
        Me.annotation3.Active = checkBox1.Checked
    End Sub 'checkBox1_CheckedChanged
End Class 'Tool_Annotation
