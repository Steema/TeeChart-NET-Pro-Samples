
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms


Public Class Function_CrossPoints
    Inherits Steema.TeeChart.Samples.BaseForm
    Private line1 As Steema.TeeChart.Styles.Line
    Private line2 As Steema.TeeChart.Styles.Line
    Private crossPoints1 As Steema.TeeChart.Functions.CrossPoints
    Private line3 As Steema.TeeChart.Styles.Line
    Private checkBox1 As System.Windows.Forms.CheckBox
    Private components As System.ComponentModel.IContainer = Nothing
    
    Public Sub New() ' This call is required by the Windows Form Designer.
        InitializeComponent()

        Dim x As Double = -5
        Do While (x < 5)
            Me.line1.Add(x, Math.Sin((Math.PI / (2 * x))))
            Me.line2.Add(x, (Math.Sin((Math.PI / (6 * x))) - 0.25))
            x = (x + 0.2)
        Loop

        line3.CheckDataSource()
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
        Me.line1 = New Steema.TeeChart.Styles.Line
        Me.line2 = New Steema.TeeChart.Styles.Line
        Me.crossPoints1 = New Steema.TeeChart.Functions.CrossPoints
        Me.line3 = New Steema.TeeChart.Styles.Line
        Me.checkBox1 = New System.Windows.Forms.CheckBox
        Me.panel1.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(480, 63)
        Me.textBox1.Text = "CrossPoints function calculates coordinates for crossing points of source line se" + "ries. The yellow line series shows points where line1 and line2 cross."
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.checkBox1)
        Me.panel1.Location = New System.Drawing.Point(0, 63)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(480, 33)
        ' 
        ' tChart1
        ' 
        ' 
        ' tChart1.Aspect
        ' 
        Me.tChart1.Aspect.View3D = False
        ' 
        ' tChart1.Header
        ' 
        Me.tChart1.Header.Lines = New String() {"tChart1"}
        Me.tChart1.Location = New System.Drawing.Point(0, 96)
        Me.tChart1.Name = "tChart1"
        Me.tChart1.Series.Add(Me.line1)
        Me.tChart1.Series.Add(Me.line2)
        Me.tChart1.Series.Add(Me.line3)
        Me.tChart1.Size = New System.Drawing.Size(480, 197)
        ' 
        ' line1
        ' 
        ' 
        ' line1.Brush
        ' 
        Me.line1.Brush.Color = System.Drawing.Color.Red
        ' 
        ' line1.Pointer
        ' 
        ' 
        ' line1.Pointer.Brush
        ' 
        Me.line1.Pointer.Brush.Color = System.Drawing.Color.Red
        Me.line1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.line1.Title = "line1"
        ' 
        ' line1.XValues
        ' 
        Me.line1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' line2
        ' 
        ' 
        ' line2.Brush
        ' 
        Me.line2.Brush.Color = System.Drawing.Color.Green
        ' 
        ' line2.Pointer
        ' 
        ' 
        ' line2.Pointer.Brush
        ' 
        Me.line2.Pointer.Brush.Color = System.Drawing.Color.Green
        Me.line2.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.line2.Title = "line2"
        ' 
        ' line2.XValues
        ' 
        Me.line2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' line3
        ' 
        ' 
        ' line3.Brush
        ' 
        Me.line3.Brush.Color = System.Drawing.Color.Yellow
        Me.line3.DataSource = New Object() {Me.line1, Me.line2}
        Me.line3.Function = Me.crossPoints1
        ' 
        ' line3.Pointer
        ' 
        ' 
        ' line3.Pointer.Brush
        ' 
        Me.line3.Pointer.Brush.Color = System.Drawing.Color.Yellow
        Me.line3.Pointer.HorizSize = 2
        Me.line3.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.line3.Pointer.VertSize = 2
        Me.line3.Pointer.Visible = True
        Me.line3.Title = "line3"
        ' 
        ' line3.XValues
        ' 
        Me.line3.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' checkBox1
        ' 
        Me.checkBox1.Checked = True
        Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox1.Location = New System.Drawing.Point(16, 8)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(133, 21)
        Me.checkBox1.TabIndex = 0
        Me.checkBox1.Text = "&View crosspoints line"
        AddHandler Me.checkBox1.CheckedChanged, AddressOf Me.checkBox1_CheckedChanged
        ' 
        ' Function_CrossPoint
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(480, 293)
        Me.Name = "Function_CrossPoint"
        Me.panel1.ResumeLayout(False)
    End Sub 'New 
#End Region


    Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.line3.Active = Me.checkBox1.Checked
    End Sub 'checkBox1_CheckedChanged
End Class 'Function_CrossPoints