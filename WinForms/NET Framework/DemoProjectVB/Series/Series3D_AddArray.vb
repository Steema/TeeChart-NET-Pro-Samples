
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms


Public Class Series3D_AddArray
    Inherits Steema.TeeChart.Samples.BaseForm
    Private colorGrid1 As Steema.TeeChart.Styles.ColorGrid
    Private components As System.ComponentModel.IContainer = Nothing
    
    Public Sub New() ' This call is required by the Windows Form Designer.
        InitializeComponent()

        Dim rnd As Random = New Random
        Dim xValues(35) As Double
        Dim yValues(35) As Double
        Dim zValues(35) As Double
        Dim count As Integer = 0
        
        Dim x As Double
        For x = 0 To 5
            Dim y As Double
            For y = 0 To 5
                xValues(count) = x
                zValues(count) = y
                yValues(count) = rnd.Next(100)
                count += 1
            Next y
        Next x
        
        colorGrid1.Add(xValues, yValues, zValues)

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
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Text = ("All 3D Series (surface, contour, colorgrid, etc) include a new method to add a un" + ("i-dimensional set of arrays (x by z grid of values). " & vbCrLf & vbCrLf & "colorGrid1.Add(xValues," + " yValues, zValues)"))
        ' 
        ' panel1
        ' 
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
        Me.tChart1.Header.Lines = New String((0) - 1) {}
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
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(254, Byte), CType(255, Byte), CType(255, Byte), CType(255, Byte))
        Me.tChart1.Series.Add(Me.colorGrid1)
        ' 
        ' colorGrid1
        ' 
        ' 
        ' colorGrid1.Brush
        ' 
        Me.colorGrid1.Brush.Color = System.Drawing.Color.Red
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
        Me.colorGrid1.PaletteMin = 0
        Me.colorGrid1.PaletteStep = 0
        Me.colorGrid1.PaletteStyle = Steema.TeeChart.Styles.PaletteStyles.Strong
        Me.colorGrid1.Title = "colorGrid1"
        Me.colorGrid1.UseColorRange = False
        Me.colorGrid1.UsePalette = True
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
        ' Series3D_AddArray
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(440, 317)
        Me.Name = "Series3D_AddArray"
        Me.ResumeLayout(False)
    End Sub 'New

#End Region

End Class 'Series3D_AddArray