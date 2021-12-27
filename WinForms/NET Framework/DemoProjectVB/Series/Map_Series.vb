
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports Steema.TeeChart
Imports Steema.TeeChart.Styles



Public Class Map_Series
    Inherits Steema.TeeChart.Samples.BaseForm
    Private map1 As Steema.TeeChart.Styles.Map
    Private WithEvents button1 As System.Windows.Forms.Button
    Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
    Private WithEvents checkBox2 As System.Windows.Forms.CheckBox
    Private WithEvents checkBox3 As System.Windows.Forms.CheckBox
    Private panel2 As System.Windows.Forms.Panel
    Private components As System.ComponentModel.IContainer = Nothing
    
    Private rnd As New Random()
    Private Colors() As Color
    
    
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
    End Sub 'New
     
    ' TODO: Add any initialization after the InitializeComponent call
    
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
        Me.map1 = New Steema.TeeChart.Styles.Map
        Me.button1 = New System.Windows.Forms.Button
        Me.checkBox1 = New System.Windows.Forms.CheckBox
        Me.checkBox2 = New System.Windows.Forms.CheckBox
        Me.checkBox3 = New System.Windows.Forms.CheckBox
        Me.panel2 = New System.Windows.Forms.Panel
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Text = "Map Series is a collection of polygon shapes. Each shape has" + vbCr + vbLf + "formatting attribut" + "es and a Value. The shape color lookups the" + vbCr + vbLf + "color palette for the Value."
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.panel2)
        Me.panel1.Controls.Add(Me.checkBox3)
        Me.panel1.Controls.Add(Me.checkBox2)
        Me.panel1.Controls.Add(Me.checkBox1)
        Me.panel1.Controls.Add(Me.button1)
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
        ' tChart1.Axes
        ' 
        ' 
        ' tChart1.Axes.Left
        ' 
        ' 
        ' tChart1.Axes.Left.Labels
        ' 
        Me.tChart1.Axes.Left.Labels.Style = Steema.TeeChart.AxisLabelStyle.Value
        ' 
        ' tChart1.Header
        ' 
        Me.tChart1.Header.Lines = New String() {"TeeChart"}
        Me.tChart1.Header.Visible = False
        ' 
        ' tChart1.Legend
        ' 
        Me.tChart1.Legend.Visible = False
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Brush
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(255, System.Byte), CType(255, System.Byte), CType(255, System.Byte))
        Me.tChart1.Series.Add(Me.map1)
        ' 
        ' tChart1.Walls
        ' 
        ' 
        ' tChart1.Walls.Back
        ' 
        ' 
        ' tChart1.Walls.Back.Brush
        ' 
        Me.tChart1.Walls.Back.Brush.Color = System.Drawing.Color.FromArgb(CType(127, System.Byte), CType(192, System.Byte), CType(192, System.Byte), CType(192, System.Byte))
        ' 
        ' tChart1.Walls.Back.Gradient
        ' 
        Me.tChart1.Walls.Back.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(224, System.Byte), CType(224, System.Byte), CType(224, System.Byte))
        Me.tChart1.Walls.Back.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(192, System.Byte), CType(192, System.Byte), CType(192, System.Byte))
        Me.tChart1.Walls.Back.Brush.Gradient.Transparency = 50
        Me.tChart1.Walls.Back.Brush.Gradient.UseMiddle = True
        Me.tChart1.Walls.Back.Brush.Gradient.Visible = True
        ' 
        ' tChart1.Walls.Back.Gradient
        ' 
        Me.tChart1.Walls.Back.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(224, System.Byte), CType(224, System.Byte), CType(224, System.Byte))
        Me.tChart1.Walls.Back.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(192, System.Byte), CType(192, System.Byte), CType(192, System.Byte))
        Me.tChart1.Walls.Back.Gradient.Transparency = 50
        Me.tChart1.Walls.Back.Gradient.UseMiddle = True
        Me.tChart1.Walls.Back.Gradient.Visible = True
        Me.tChart1.Walls.Back.Transparent = False
        ' 
        ' map1
        ' 
        ' 
        ' map1.Brush
        ' 
        Me.map1.Brush.Color = System.Drawing.Color.Red
        Me.map1.LabelMember = "Labels"
        ' 
        ' map1.Marks
        ' 
        ' 
        ' map1.Marks.Symbol
        ' 
        ' 
        ' map1.Marks.Symbol.Shadow
        ' 
        Me.map1.Marks.Symbol.Shadow.Height = 1
        Me.map1.Marks.Symbol.Shadow.Visible = True
        Me.map1.Marks.Symbol.Shadow.Width = 1
        Me.map1.PaletteMin = 0
        Me.map1.PaletteStep = 0
        Me.map1.Title = "map1"
        ' 
        ' map1.XValues
        ' 
        Me.map1.XValues.DataMember = "X"
        ' 
        ' map1.YValues
        ' 
        Me.map1.YValues.DataMember = "Y"
        ' 
        ' map1.ZValues
        ' 
        Me.map1.ZValues.DataMember = "Z"
        ' 
        ' button1
        ' 
        Me.button1.Location = New System.Drawing.Point(16, 8)
        Me.button1.Name = "button1"
        Me.button1.TabIndex = 0
        Me.button1.Text = "Edit..."
        ' 
        ' checkBox1
        ' 
        Me.checkBox1.Checked = True
        Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox1.Location = New System.Drawing.Point(111, 9)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(57, 24)
        Me.checkBox1.TabIndex = 1
        Me.checkBox1.Text = "&Axes"
        ' 
        ' checkBox2
        ' 
        Me.checkBox2.Checked = True
        Me.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox2.Location = New System.Drawing.Point(185, 10)
        Me.checkBox2.Name = "checkBox2"
        Me.checkBox2.Size = New System.Drawing.Size(57, 24)
        Me.checkBox2.TabIndex = 2
        Me.checkBox2.Text = "&Marks"
        ' 
        ' checkBox3
        ' 
        Me.checkBox3.Location = New System.Drawing.Point(264, 10)
        Me.checkBox3.Name = "checkBox3"
        Me.checkBox3.Size = New System.Drawing.Size(57, 24)
        Me.checkBox3.TabIndex = 3
        Me.checkBox3.Text = "&Palette"
        ' 
        ' panel2
        ' 
        Me.panel2.Location = New System.Drawing.Point(344, 8)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(32, 24)
        Me.panel2.TabIndex = 4
        ' 
        ' Map
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(440, 317)
        Me.Name = "Map"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub 'InitializeComponent 
#End Region


    'Private Sub panel1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles panel1.Paint
    'End Sub 'panel1_Paint


    Private Sub Map_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        map1.Clear()
        AddSampleShapes()
        map1.Marks.Visible = True
        map1.Marks.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.Raised
        map1.Color = Color.Silver
    End Sub 'Map_Load


    Private Sub AddSampleShapes()
        Dim AX() As Integer = {1, 3, 4, 4, 5, 5, 6, 6, 4, 3, 2, 1, 2, 2}
        Dim AY() As Integer = {7, 5, 5, 7, 8, 9, 10, 11, 11, 12, 12, 11, 10, 8}
        Dim BX() As Integer = {5, 7, 8, 8, 7, 6, 5, 4, 4}
        Dim BY() As Integer = {4, 4, 5, 6, 7, 7, 8, 7, 5}
        Dim CX() As Integer = {9, 10, 11, 11, 12, 9, 8, 7, 6, 6, 5, 5, 6, 7, 8, 8}
        Dim CY() As Integer = {5, 6, 6, 7, 8, 11, 11, 12, 11, 10, 9, 8, 7, 7, 6, 5}
        Dim DX() As Integer = {12, 14, 15, 14, 13, 12, 11, 11}
        Dim DY() As Integer = {5, 5, 6, 7, 7, 8, 7, 6}
        Dim EX() As Integer = {4, 6, 7, 7, 6, 6, 5, 4, 3, 3, 2}
        Dim EY() As Integer = {11, 11, 12, 13, 14, 15, 16, 16, 15, 14, 13}
        Dim FX() As Integer = {7, 8, 9, 11, 10, 8, 7, 6, 5, 5, 6, 6}
        Dim FY() As Integer = {13, 14, 14, 16, 17, 17, 18, 18, 17, 16, 15, 14}
        Dim GX() As Integer = {10, 12, 12, 14, 13, 11, 9, 8, 7, 7, 8, 9}
        Dim GY() As Integer = {10, 12, 13, 15, 16, 16, 14, 14, 13, 12, 11, 11}
        Dim HX() As Integer = {17, 19, 18, 18, 17, 15, 14, 13, 15, 16}
        Dim HY() As Integer = {11, 13, 14, 16, 17, 15, 15, 14, 12, 12}
        Dim IX() As Integer = {15, 16, 17, 16, 15, 14, 14, 13, 12, 11, 10, 11, 12, 13, 14}
        Dim IY() As Integer = {6, 6, 7, 8, 8, 9, 10, 11, 12, 11, 10, 9, 8, 7, 7}
        Dim JX() As Integer = {15, 16, 16, 17, 17, 16, 15, 13, 12, 12, 14, 14}
        Dim JY() As Integer = {8, 8, 9, 10, 11, 12, 12, 14, 13, 12, 10, 9}
        Dim KX() As Integer = {17, 19, 20, 20, 19, 17, 16, 16, 17, 16}
        Dim KY() As Integer = {5, 5, 6, 8, 8, 10, 9, 8, 7, 6}
        Dim LX() As Integer = {19, 20, 21, 21, 19, 17, 17}
        Dim LY() As Integer = {8, 8, 9, 11, 13, 11, 10}

        Colors = New Color() {Color.Lime, Color.Red, Color.Fuchsia, Color.Aqua, Color.Silver, Color.Aqua, Color.Green, Color.Teal, Color.White, Color.Red, Color.Blue, Color.Yellow}


        AddShape(AX, AY, Colors(0), "A")
        AddShape(BX, BY, Colors(1), "B")
        AddShape(CX, CY, Colors(2), "C")
        AddShape(DX, DY, Colors(3), "D")
        AddShape(EX, EY, Colors(4), "E")
        AddShape(FX, FY, Colors(5), "F")
        AddShape(GX, GY, Colors(6), "G")
        AddShape(HX, HY, Colors(7), "H")
        AddShape(IX, IY, Colors(8), "I")
        AddShape(JX, JY, Colors(9), "J")
        AddShape(KX, KY, Colors(10), "K")
        AddShape(LX, LY, Colors(11), "L")
    End Sub 'AddSampleShapes


    Private Sub AddShape(ByVal X() As Integer, ByVal Y() As Integer, ByVal AColor As Color, ByVal [Text] As String)
        Dim toAdd As New Polygon(map1.Shapes, tChart1.Chart)

        Dim t As Integer
        For t = X.GetLowerBound(0) To X.GetUpperBound(0)
            toAdd.Add(X(t), Y(t))
        Next t

        Dim i As Integer = map1.Shapes.Add(toAdd)
        map1.Shapes(i).ParentBrush = False
        map1.Shapes(i).Text = [Text]
        map1.Shapes(i).Color = AColor
        map1.Shapes(i).Z = rnd.Next(1000) / 1000.0
    End Sub 'AddShape


    Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
        Steema.TeeChart.Editors.SeriesEditor.ShowModal(map1)
    End Sub 'button1_Click


    Private Sub checkBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox1.Click
        Dim a As Integer
        For a = 0 To tChart1.Axes.Count - 1
            tChart1.Axes(a).Visible = checkBox1.Checked
        Next a
    End Sub 'checkBox1_Click

    Private Sub checkBox2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox2.Click
        map1.Marks.Visible = checkBox2.Checked
    End Sub 'checkBox2_Click


    Private Sub checkBox3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox3.Click
        If checkBox3.Checked Then
            map1.UseColorRange = False
            map1.UsePalette = True
            Dim i As Integer
            For i = 0 To map1.Shapes.Count - 1
                map1.Shapes(i).ParentBrush = True
            Next i
        Else
            map1.UseColorRange = False
            map1.UsePalette = False
            Dim i As Integer
            For i = 0 To map1.Shapes.Count - 1
                map1.Shapes(i).ParentBrush = False
                map1.Shapes(i).Color = Colors(i)
            Next i
        End If
        map1.Invalidate()
    End Sub 'checkBox3_Click


    Private Sub tChart1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tChart1.MouseMove
        Dim tmp As Integer = map1.Clicked(e.X, e.Y)
        If tmp = -1 Then
            panel2.Visible = False
        Else
            panel2.Visible = True
            panel2.BackColor = map1.Shapes(tmp).Points.Color
        End If
    End Sub 'tChart1_MouseMove


    Private Sub map1_Click(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        MessageBox.Show("Shape: " + map1.Labels(map1.Clicked(e.X, e.Y)) + "  Value: " + map1.ZValues(map1.Clicked(e.X, e.Y)).ToString())
        tChart1.Chart.CancelMouse = True
    End Sub 'map1_Click
End Class 'Map_Series 
