
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing

Imports System.Windows.Forms




Public Class Line_Outline
    Inherits Samples.BaseForm
    Private lineSeries1 As Steema.TeeChart.Styles.Line
    Private buttonPen1 As Steema.TeeChart.ButtonPen
    Private buttonPen2 As Steema.TeeChart.ButtonPen
    Private WithEvents buttonColor1 As Steema.TeeChart.ButtonColor
    Private gridBand1 As Steema.TeeChart.Tools.GridBand
    Private components As System.ComponentModel.IContainer = Nothing
    
    
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        
        lineSeries1.FillSampleValues(25)
        Me.buttonPen1.Pen = Me.lineSeries1.LinePen
        Me.buttonPen2.Pen = Me.lineSeries1.OutLine
        buttonColor1.Color = lineSeries1.Color
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
        Me.buttonPen1 = New Steema.TeeChart.ButtonPen
        Me.buttonPen2 = New Steema.TeeChart.ButtonPen
        Me.buttonColor1 = New Steema.TeeChart.ButtonColor
        Me.gridBand1 = New Steema.TeeChart.Tools.GridBand
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(528, 56)
        Me.textBox1.Text = "Line series Outline property is a Pen used to display the same line at the backgr" + "ound with a bigger size." + vbCr + vbLf + vbCr + vbLf + "line1.Outline.Color = Color.Yellow "
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.buttonColor1)
        Me.panel1.Controls.Add(Me.buttonPen2)
        Me.panel1.Controls.Add(Me.buttonPen1)
        Me.panel1.Location = New System.Drawing.Point(0, 56)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(528, 42)
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
        Me.tChart1.Location = New System.Drawing.Point(0, 98)
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Brush
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.tChart1.Series.Add(Me.lineSeries1)
        Me.tChart1.Size = New System.Drawing.Size(528, 211)
        Me.tChart1.Tools.Add(Me.gridBand1)
        ' 
        ' lineSeries1
        ' 
        ' 
        ' lineSeries1.Brush
        ' 
        Me.lineSeries1.Brush.Color = System.Drawing.Color.Red
        ' 
        ' lineSeries1.LinePen
        ' 
        Me.lineSeries1.LinePen.Color = System.Drawing.Color.FromArgb(CType(153, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
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
        ' lineSeries1.OutLine
        ' 
        Me.lineSeries1.OutLine.Color = System.Drawing.Color.FromArgb(CType(255, System.Byte), CType(255, System.Byte), CType(0, System.Byte))
        Me.lineSeries1.OutLine.Visible = True
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
        ' buttonPen1
        ' 
        Me.buttonPen1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonPen1.Location = New System.Drawing.Point(15, 9)
        Me.buttonPen1.Name = "buttonPen1"
        Me.buttonPen1.TabIndex = 0
        Me.buttonPen1.Text = "&Line..."
        ' 
        ' buttonPen2
        ' 
        Me.buttonPen2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonPen2.Location = New System.Drawing.Point(112, 8)
        Me.buttonPen2.Name = "buttonPen2"
        Me.buttonPen2.TabIndex = 1
        Me.buttonPen2.Text = "&Outline..."
        ' 
        ' buttonColor1
        ' 
        Me.buttonColor1.Color = System.Drawing.Color.Empty
        Me.buttonColor1.Location = New System.Drawing.Point(208, 8)
        Me.buttonColor1.Name = "buttonColor1"
        Me.buttonColor1.TabIndex = 2
        Me.buttonColor1.Text = "&Color..."
        ' 
        ' gridBand1
        ' 
        Me.gridBand1.Axis = Me.tChart1.Axes.Left
        ' 
        ' gridBand1.Band1
        ' 
        Me.gridBand1.Band1.Color = System.Drawing.Color.FromArgb(CType(127, System.Byte), CType(128, System.Byte), CType(128, System.Byte), CType(128, System.Byte))
        ' 
        ' gridBand1.Band2
        ' 
        Me.gridBand1.Band2.Color = System.Drawing.Color.FromArgb(CType(127, System.Byte), CType(224, System.Byte), CType(224, System.Byte), CType(224, System.Byte))
        ' 
        ' Line_Outline
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(528, 309)
        Me.Name = "Line_Outline"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub 'InitializeComponent 
#End Region


    Private Sub buttonColor1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles buttonColor1.Click
        lineSeries1.Color = buttonColor1.Color
    End Sub 'buttonColor1_Click
End Class 'Line_Outline
