
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms


Public Class Bar_SelfStack
    Inherits Steema.TeeChart.Samples.BaseForm
    Private bar1 As Steema.TeeChart.Styles.Bar
    Private checkBox1 As System.Windows.Forms.CheckBox
    Private gridBand1 As Steema.TeeChart.Tools.GridBand
    Private components As System.ComponentModel.IContainer = Nothing
    
    Public Sub New() ' This call is required by the Windows Form Designer.
        InitializeComponent()

        bar1.Add(100, "Cars")
        bar1.Add(300, "Phones")
        bar1.Add(200, "Lamps")
        
        ' Set "Self-Stacked":
        bar1.MultiBar = Steema.TeeChart.Styles.MultiBars.SelfStack
        
        ' cosmetic
        bar1.Marks.Visible = False
        bar1.Marks.Style = Steema.TeeChart.Styles.MarksStyles.Value
        bar1.ColorEach = True
        Me.checkBox1_CheckedChanged(Me, New System.EventArgs)
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
        Me.bar1 = New Steema.TeeChart.Styles.Bar
        Me.checkBox1 = New System.Windows.Forms.CheckBox
        Me.gridBand1 = New Steema.TeeChart.Tools.GridBand
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Text = "Bar and Horizontal Bar series provide a stacking style to display a single series \""self stacked\""." & vbCrLf & "" & vbCrLf & "bar1.MultiBar = Steema.TeeChart.Styles.MultiBars.SelfStack"
        ' 
        ' panel1
        ' 
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
        Me.tChart1.BackColor = System.Drawing.Color.Transparent
        Me.tChart1.Cursor = System.Windows.Forms.Cursors.Default
        ' 
        ' tChart1.Header
        '  
        Me.tChart1.Header.Lines = New String() {"tChart1"}
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Brush
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb((CType((254), System.Byte)), (CType((255), System.Byte)), (CType((255), System.Byte)), (CType((255), System.Byte)))
        Me.tChart1.Panel.MarginBottom = 10
        Me.tChart1.Series.Add(Me.bar1)
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
        Me.tChart1.Walls.Bottom.Size = 3
        ' 
        ' tChart1.Walls.Left
        ' 
        ' 
        ' tChart1.Walls.Left.Pen
        ' 
        Me.tChart1.Walls.Left.Pen.Visible = False
        Me.tChart1.Walls.Left.Size = 3
        ' 
        ' bar1
        ' 
        ' 
        ' bar1.Brush
        ' 
        Me.bar1.Brush.Color = System.Drawing.Color.Red
        Me.bar1.ColorEach = True
        ' 
        ' bar1.Marks
        ' 
        ' 
        ' bar1.Marks.Symbol
        ' 
        ' 
        ' bar1.Marks.Symbol.Shadow
        ' 
        Me.bar1.Marks.Symbol.Shadow.Height = 1
        Me.bar1.Marks.Symbol.Shadow.Visible = True
        Me.bar1.Marks.Symbol.Shadow.Width = 1
        Me.bar1.MultiBar = Steema.TeeChart.Styles.MultiBars.SelfStack
        Me.bar1.Title = "bar1"
        ' 
        ' bar1.XValues
        ' 
        Me.bar1.XValues.DataMember = "X"
        Me.bar1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' bar1.YValues
        ' 
        Me.bar1.YValues.DataMember = "Bar"
        ' 
        ' checkBox1
        ' 
        Me.checkBox1.Checked = True
        Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox1.Location = New System.Drawing.Point(16, 8)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(144, 24)
        Me.checkBox1.TabIndex = 0
        Me.checkBox1.Text = "Self stack"
        AddHandler checkBox1.CheckedChanged, AddressOf Me.checkBox1_CheckedChanged
        ' 
        ' gridBand1
        ' 
        Me.gridBand1.Axis = Me.tChart1.Axes.Left
        ' 
        ' gridBand1.Band1
        ' 
        Me.gridBand1.Band1.Color = System.Drawing.Color.FromArgb((CType((127), System.Byte)), (CType((64), System.Byte)), (CType((64), System.Byte)), (CType((0), System.Byte)))
        ' 
        ' gridBand1.Band2
        ' 
        Me.gridBand1.Band2.Color = System.Drawing.Color.FromArgb((CType((127), System.Byte)), (CType((224), System.Byte)), (CType((224), System.Byte)), (CType((224), System.Byte)))
        ' 
        ' Bar_Selfstack
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(440, 317)
        Me.Name = "Bar_Selfstack"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub 'New

  
#End Region
   
    Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        If checkBox1.Checked Then
            tChart1.Panel.MarginBottom = 10
            bar1.MultiBar = Steema.TeeChart.Styles.MultiBars.SelfStack
            bar1.GetHorizAxis.Labels.Items.Clear()
            Dim val As String = ""
            Dim i As Integer
            For i = 0 To bar1.Count - 1
                val += bar1.Labels(i) + vbLf
            Next i
            bar1.GetHorizAxis.Labels.Items.Add(0, val)
        Else
            tChart1.Panel.MarginBottom = 4
            bar1.MultiBar = Steema.TeeChart.Styles.MultiBars.None
            bar1.GetHorizAxis.Labels.Items.Clear()
        End If

        ' show marks when not in self-stacking mode:
        bar1.Marks.Visible = Not checkBox1.Checked
    End Sub 'checkBox1_CheckedChanged
End Class 'Bar_SelfStack