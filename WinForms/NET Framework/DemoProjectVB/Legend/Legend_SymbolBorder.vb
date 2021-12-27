
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms


Public Class Legend_SymbolBorder
    Inherits Steema.TeeChart.Samples.BaseForm
    Private bar1 As Steema.TeeChart.Styles.Bar
    Private checkBox1 As System.Windows.Forms.CheckBox
    Private buttonPen1 As Steema.TeeChart.ButtonPen
    Private checkBox2 As System.Windows.Forms.CheckBox
    Private components As System.ComponentModel.IContainer = Nothing
    
    Public Sub New() ' This call is required by the Windows Form Designer.
        InitializeComponent()

        bar1.FillSampleValues()
        Dim legendSymbol As Steema.TeeChart.LegendSymbol = tChart1.Legend.Symbol
        legendSymbol.DefaultPen = False
        legendSymbol.Pen.Color = Color.Red
        legendSymbol.Pen.Width = 2
        legendSymbol.Pen.EndCap = System.Drawing.Drawing2D.LineCap.Flat
        buttonPen1.Pen = legendSymbol.Pen
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
        Me.bar1 = New Steema.TeeChart.Styles.Bar
        Me.checkBox1 = New System.Windows.Forms.CheckBox
        Me.buttonPen1 = New Steema.TeeChart.ButtonPen
        Me.checkBox2 = New System.Windows.Forms.CheckBox
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Text = "Legend symbols can now display using a customized border. By default, legend symbols use the Series border." & vbCr & vbLf & "tChart1.Legend.Symbol.DefaultPen = False" & vbCr & vbLf & "tChart1.Legend.Symbol.Pen.Color= Color.Red"
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.checkBox2)
        Me.panel1.Controls.Add(Me.buttonPen1)
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
        ' 
        ' tChart1.Header
        ' 
        Me.tChart1.Header.Lines = New String() {"tChart1"}

        ' 
        ' tChart1.Legend
        ' 
        ' 
        ' tChart1.Legend.Brush
        ' 
        Me.tChart1.Legend.Brush.Color = System.Drawing.Color.FromArgb((CType((254), System.Byte)), (CType((192), System.Byte)), (CType((192), System.Byte)), (CType((192), System.Byte)))
        ' 
        ' tChart1.Legend.Gradient
        ' 
        Me.tChart1.Legend.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb((CType((254), System.Byte)), (CType((192), System.Byte)), (CType((192), System.Byte)), (CType((192), System.Byte)))
        Me.tChart1.Legend.Brush.Gradient.Visible = True
        ' 
        ' tChart1.Legend.Font
        ' 
        Me.tChart1.Legend.Font.Size = 14
        ' 
        ' tChart1.Legend.Gradient
        ' 
        Me.tChart1.Legend.Gradient.StartColor = System.Drawing.Color.FromArgb((CType((254), System.Byte)), (CType((192), System.Byte)), (CType((192), System.Byte)), (CType((192), System.Byte)))
        Me.tChart1.Legend.Gradient.Visible = True
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Brush
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb((CType((254), System.Byte)), (CType((255), System.Byte)), (CType((255), System.Byte)), (CType((255), System.Byte)))
        Me.tChart1.Series.Add(Me.bar1)
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
        ' bar1
        ' 
        ' 
        ' bar1.Brush
        ' 
        Me.bar1.Brush.Color = System.Drawing.Color.FromArgb((CType((147), System.Byte)), (CType((0), System.Byte)), (CType((0), System.Byte)), (CType((192), System.Byte)))
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
        ' 
        ' bar1.Pen
        ' 
        Me.bar1.Pen.Color = System.Drawing.Color.FromArgb((CType((254), System.Byte)), (CType((128), System.Byte)), (CType((128), System.Byte)), (CType((255), System.Byte)))
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
        Me.checkBox1.Location = New System.Drawing.Point(8, 8)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(120, 24)
        Me.checkBox1.TabIndex = 0
        Me.checkBox1.Text = "Use Series Border"
        AddHandler checkBox1.Click, AddressOf Me.checkBox1_Click
        ' 
        ' buttonPen1
        ' 
        Me.buttonPen1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonPen1.Location = New System.Drawing.Point(152, 8)
        Me.buttonPen1.Name = "buttonPen1"
        Me.buttonPen1.Size = New System.Drawing.Size(96, 23)
        Me.buttonPen1.TabIndex = 1
        Me.buttonPen1.Text = "Edit Border..."
        ' 
        ' checkBox2
        ' 
        Me.checkBox2.Location = New System.Drawing.Point(288, 8)
        Me.checkBox2.Name = "checkBox2"
        Me.checkBox2.Size = New System.Drawing.Size(120, 24)
        Me.checkBox2.TabIndex = 2
        Me.checkBox2.Text = "Squared Symbols"
        AddHandler checkBox2.Click, AddressOf Me.checkBox2_Click
        ' 
        ' Legend_SymbolBorder
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(440, 317)
        Me.Name = "Legend_SymbolBorder"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub 'New

#End Region
   

    Private Sub checkBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        tChart1.Legend.Symbol.DefaultPen = checkBox1.Checked
        buttonPen1.Enabled = Not checkBox1.Checked
    End Sub 'checkBox1_Click


    Private Sub checkBox2_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        tChart1.Legend.Symbol.Squared = checkBox1.Checked
    End Sub 'checkBox2_Click
End Class 'Legend_SymbolBorder