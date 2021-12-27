
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms


Public Class Commander_Custom
    Inherits Steema.TeeChart.Samples.BaseForm
#If VS2005 Then
    Private commander1 As Steema.TeeChart.ChartController
#Else
    Private commander1 As Steema.TeeChart.Commander
#End If
    Private line1 As Steema.TeeChart.Styles.Line
    Private gridBand1 As Steema.TeeChart.Tools.GridBand
    Private components As System.ComponentModel.IContainer = Nothing
    
    Public Sub New() ' This call is required by the Windows Form Designer.
        InitializeComponent()
        InitialiseChart()
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
#If VS2005 Then
        Me.commander1 = New Steema.TeeChart.ChartController
#Else
        Me.commander1 = New Steema.TeeChart.Commander
#End If
        Me.line1 = New Steema.TeeChart.Styles.Line
        Me.gridBand1 = New Steema.TeeChart.Tools.GridBand
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Text = "TeeChart's ChartController ToolBar can now be fully customised by the addition of desir" + _
                            "ed buttons and separators."
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.commander1)
        Me.panel1.Name = "panel1"
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
        Me.tChart1.Header.Lines = New String() {"ChartController Buttons"}
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Brush
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.tChart1.Series.Add(Me.line1)
        Me.tChart1.Tools.Add(Me.gridBand1)
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
        ' commander1
        ' 
        Me.commander1.Location = New System.Drawing.Point(0, 0)
        Me.commander1.Name = "commander1"
        Me.commander1.Size = New System.Drawing.Size(440, 37)
        Me.commander1.TabIndex = 0
        ' 
        ' line1
        ' 
        ' 
        ' line1.Brush
        ' 
        Me.line1.Brush.Color = System.Drawing.Color.Red
        ' 
        ' line1.Marks
        ' 
        ' 
        ' line1.Marks.Symbol
        ' 
        ' 
        ' line1.Marks.Symbol.Shadow
        ' 
        Me.line1.Marks.Symbol.Shadow.Height = 1
        Me.line1.Marks.Symbol.Shadow.Visible = True
        Me.line1.Marks.Symbol.Shadow.Width = 1
        ' 
        ' line1.Pointer
        ' 
        ' 
        ' line1.Pointer.Brush
        ' 
        Me.line1.Pointer.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(0, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        Me.line1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.line1.Title = "line1"
        ' 
        ' line1.XValues
        ' 
        Me.line1.XValues.DataMember = "X"
        Me.line1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' line1.YValues
        ' 
        Me.line1.YValues.DataMember = "Y"
        ' 
        ' gridBand1
        ' 
        Me.gridBand1.Axis = Me.tChart1.Axes.Left
        ' 
        ' gridBand1.Band1
        ' 
        Me.gridBand1.Band1.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(224, System.Byte), CType(224, System.Byte), CType(224, System.Byte))
        ' 
        ' gridBand1.Band2
        ' 
        Me.gridBand1.Band2.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        ' 
        ' TCommander_Buttons
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(440, 317)
        Me.Name = "TCommander_Buttons"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub 'New 

    

#End Region

    Private Sub InitialiseChart()
        Const buttonCount As Integer = 5
#If VS2005 Then
        Dim comButtons As System.Windows.Forms.ToolStripItem() = New System.Windows.Forms.ToolStripItem(buttonCount - 1) {}
        Dim tmpBut As ToolStripButton
#Else
        Dim comButtons As System.Windows.Forms.ToolBarButton() = New System.Windows.Forms.ToolBarButton(buttonCount - 1) {}
#End If

#If VS2005 Then
        For Each button As ToolStripItem In commander1.Items
#Else
        For Each button As ToolBarButton In commander1.Buttons
#End If

#If VS2005 Then
            If TypeOf button Is System.Windows.Forms.ToolStripButton Then
                tmpBut = CType(button, System.Windows.Forms.ToolStripButton)
                tmpBut.Checked = False
#Else
            button.Pushed = False
#End If
                Select Case (button.Tag.ToString())
                    Case "bNormal"
                    Exit Select
#If VS2005 Then
                    Case "bSeparator"
                    comButtons(1) = button
                    comButtons(3) = button
                    Exit Select
#End If
                Case "bRotate"
#If VS2005 Then
                    tmpBut.Checked = True
#Else
                    button.Pushed = True
#End If
                    comButtons(0) = button
                    Exit Select
                Case "bMove"
                    Exit Select
                Case "bZoom"
                    comButtons(2) = button
                    Exit Select
                Case "bDepth"
                    Exit Select
                Case "bView3D"
                    Exit Select
                Case "bEdit"
                    comButtons(4) = button
                    Exit Select
                Case "bPrint"
                    Exit Select
                Case "bCopy"
                    Exit Select
                Case "bExport"
                    Exit Select
            End Select
#If VS2005 Then
            ElseIf TypeOf button Is System.Windows.Forms.ToolStripSeparator Then

            Select Case button.Tag.ToString()
                Case "bSeparator"
                    comButtons(1) = button
                    comButtons(3) = button
                    Exit Select
            End Select
            End If
#End If
        Next

#If VS2005 Then
        commander1.Items = comButtons
#Else
        commander1.Buttons = comButtons
#End If
        commander1.Chart = tChart1
        line1.FillSampleValues()
    End Sub 'InitialiseChart

End Class 'Commander_Custom