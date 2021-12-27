Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Public Class Bubble_Sphere
    Inherits Steema.TeeChart.Samples.BaseForm
    Private checkBox1 As System.Windows.Forms.CheckBox
    Private bubble1 As Steema.TeeChart.Styles.Bubble
    Private button1 As System.Windows.Forms.Button
    Private comboBox1 As System.Windows.Forms.ComboBox
    Private label1 As System.Windows.Forms.Label
    Private gridBand1 As Steema.TeeChart.Tools.GridBand
    Private components As System.ComponentModel.IContainer = Nothing

    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        bubble1.Pointer.Gradient.StartColor = Color.DarkBlue
        bubble1.FillSampleValues()
    End Sub

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If Disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(Disposing)
    End Sub 'Dispose

#Region "Designer generated code"
    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Bubble_Sphere))
        Me.checkBox1 = New System.Windows.Forms.CheckBox()
        Me.bubble1 = New Steema.TeeChart.Styles.Bubble()
        Me.button1 = New System.Windows.Forms.Button()
        Me.comboBox1 = New System.Windows.Forms.ComboBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.gridBand1 = New Steema.TeeChart.Tools.GridBand()
        Me.panel1.SuspendLayout()
        Me.chartContainer.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Text = "Bubble series can now fill points using a gradient. " & vbCr & vbLf & vbCr & vbLf & "bubble1.Pointer.Gradient." & "Visible = True"
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Controls.Add(Me.comboBox1)
        Me.panel1.Controls.Add(Me.button1)
        Me.panel1.Controls.Add(Me.checkBox1)
        ' 
        ' tChart1
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Aspect.Chart3DPercent = 100
        Me.tChart1.Aspect.ColorPaletteIndex = 1
        Me.tChart1.Aspect.Elevation = 351
        Me.tChart1.Aspect.ElevationFloat = 351
        Me.tChart1.Aspect.Orthogonal = False
        Me.tChart1.Aspect.Perspective = 88
        Me.tChart1.Aspect.Rotation = 336
        Me.tChart1.Aspect.RotationFloat = 336
        Me.tChart1.Aspect.ZOffset = 0
        Me.tChart1.Aspect.Zoom = 78
        Me.tChart1.Aspect.ZoomFloat = 78
        ' 
        ' 
        ' 
        Me.tChart1.Header.Lines = New String() {"tChart1"}
        Me.tChart1.Header.Visible = False
        ' 
        ' 
        ' 
        Me.tChart1.Legend.Visible = False
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CInt(CByte(254)), CInt(CByte(255)), CInt(CByte(255)), CInt(CByte(255)))
        Me.tChart1.Series.Add(Me.bubble1)
        Me.tChart1.Size = New System.Drawing.Size(440, 205)
        Me.tChart1.Tools.Add(Me.gridBand1)
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Walls.Bottom.Pen.Visible = False
        Me.tChart1.Walls.Bottom.Size = 3
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Walls.Left.Pen.Visible = False
        Me.tChart1.Walls.Left.Size = 3
        ' 
        ' checkBox1
        ' 
        Me.checkBox1.Location = New System.Drawing.Point(16, 8)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(104, 24)
        Me.checkBox1.TabIndex = 0
        Me.checkBox1.Text = "Use Gradient"
        AddHandler Me.checkBox1.Click, AddressOf Me.checkBox1_Click
        ' 
        ' bubble1
        ' 
        Me.bubble1.Color = System.Drawing.Color.Red
        Me.bubble1.LabelMember = "Labels"
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.bubble1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None
        Me.bubble1.Marks.Callout.ArrowHeadSize = 8
        ' 
        ' 
        ' 
        Me.bubble1.Marks.Callout.Brush.Color = System.Drawing.Color.Black
        Me.bubble1.Marks.Callout.Distance = 0
        Me.bubble1.Marks.Callout.Draw3D = False
        Me.bubble1.Marks.Callout.Length = 0
        Me.bubble1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.bubble1.Marks.Callout.Visible = False
        Me.bubble1.Marks.Transparent = True
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.bubble1.Pointer.Brush.Color = System.Drawing.Color.Red
        Me.bubble1.Pointer.Brush.ForegroundColor = System.Drawing.Color.Empty
        Me.bubble1.Pointer.HorizSize = 19
        Me.bubble1.Pointer.InflateMargins = False
        ' 
        ' 
        ' 
        Me.bubble1.Pointer.Pen.Visible = False
        Me.bubble1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Sphere
        Me.bubble1.Pointer.VertSize = 19
        Me.bubble1.Title = "bubble1"
        ' 
        ' 
        ' 
        Me.bubble1.XValues.DataMember = "X"
        Me.bubble1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' 
        ' 
        Me.bubble1.YValues.DataMember = "Y"
        ' 
        ' button1
        ' 
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.Location = New System.Drawing.Point(120, 8)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(89, 23)
        Me.button1.TabIndex = 1
        Me.button1.Text = "Edit Gradient..."
        AddHandler Me.button1.Click, AddressOf Me.button1_Click

        ' 
        ' comboBox1
        ' 
        Me.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboBox1.Items.AddRange(New Object() {"Plain Bubble", "Sphere", "Polished"})
        Me.comboBox1.Location = New System.Drawing.Point(328, 11)
        Me.comboBox1.Name = "comboBox1"
        Me.comboBox1.Size = New System.Drawing.Size(96, 21)
        Me.comboBox1.TabIndex = 2
        Me.comboBox1.SelectedIndex = 1
        AddHandler Me.comboBox1.SelectedIndexChanged, AddressOf Me.comboBox1_SelectedIndexChanged
        ' 
        ' label1
        ' 
        Me.label1.Location = New System.Drawing.Point(240, 12)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(80, 16)
        Me.label1.TabIndex = 3
        Me.label1.Text = "&Bubble style:"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        ' 
        ' gridBand1
        ' 
        Me.gridBand1.Axis = Me.tChart1.Axes.Left
        ' 
        ' 
        ' 
        Me.gridBand1.Band1.Color = System.Drawing.Color.FromArgb(CInt(CByte(76)), CInt(CByte(128)), CInt(CByte(128)), CInt(CByte(128)))
        ' 
        ' 
        ' 
        Me.gridBand1.Band2.Color = System.Drawing.Color.FromArgb(CInt(CByte(76)), CInt(CByte(255)), CInt(CByte(255)), CInt(CByte(255)))
        ' 
        ' Bubble_Sphere
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(440, 317)
        Me.Name = "Bubble_Sphere"
        Me.panel1.ResumeLayout(False)
        Me.chartContainer.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
#End Region


    Private Sub checkBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        bubble1.Pointer.Gradient.Visible = checkBox1.Checked
    End Sub

    Private Sub setGradient(ByVal val As Boolean)
        bubble1.Pointer.Gradient.Visible = val
        checkBox1.Checked = val
    End Sub

    Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Steema.TeeChart.Editors.GradientEditor.Edit(bubble1.Pointer.Gradient)
        checkBox1.Checked = bubble1.Pointer.Gradient.Visible
    End Sub

    Private Sub comboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Select Case comboBox1.SelectedIndex
            Case 0
                bubble1.Pointer.Style = Styles.PointerStyles.Circle
                Exit Select
            Case 1
                bubble1.Pointer.Style = Styles.PointerStyles.Sphere
                setGradient(False)
                Exit Select
            Case 2
                bubble1.Pointer.Style = Styles.PointerStyles.PolishedSphere
                setGradient(False)
                Exit Select
        End Select

        If comboBox1.SelectedIndex = 0 Then
            checkBox1.Enabled = True
            checkBox1.Checked = bubble1.Pointer.Gradient.Visible
            button1.Enabled = True
        Else
            checkBox1.Enabled = False
            button1.Enabled = False
        End If
    End Sub
End Class 'Bubble_Sphere