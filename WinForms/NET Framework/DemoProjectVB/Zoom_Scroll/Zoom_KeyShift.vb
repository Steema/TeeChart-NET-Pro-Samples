
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing

Imports System.Windows.Forms

Imports System.Data
Imports System.Text



Public Class Zoom_KeyShift
    Inherits Samples.BaseForm

    Private cbModifier As System.Windows.Forms.ComboBox
    Private Line1 As Steema.TeeChart.Styles.Line
    Private label1 As System.Windows.Forms.Label
    Private cbZoom As System.Windows.Forms.CheckBox
    Private cbScroll As System.Windows.Forms.CheckBox

    Private doZoom As Boolean
    Private doScroll As Boolean
    '/ <summary>
    '/ Required designer variable.
    '/ </summary>
    Private components As System.ComponentModel.IContainer = Nothing


    Public Sub New() ' This call is required by the Windows Form Designer.
        InitializeComponent()
        InitializeChart()
    End Sub



    Private Sub InitializeChart()
        cbModifier.Items.Add("None")
        cbModifier.Items.Add("Shift")
        cbModifier.Items.Add("Control")
        cbModifier.Items.Add("Alt")
        cbModifier.SelectedIndex = 0
        doZoom = True
        doScroll = True
        Line1.FillSampleValues(100)
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Zoom_KeyShift))
        Me.cbScroll = New System.Windows.Forms.CheckBox
        Me.cbZoom = New System.Windows.Forms.CheckBox
        Me.label1 = New System.Windows.Forms.Label
        Me.cbModifier = New System.Windows.Forms.ComboBox
        Me.Line1 = New Steema.TeeChart.Styles.Line
        Me.panel1.SuspendLayout()
        Me.chartContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'textBox1
        '
        Me.textBox1.Text = "Zoom and Scroll can now be controlled by a modifier key (shift, control, alt) using" & vbCrLf & "the KeyShift pro" & _
"perty." & vbCrLf & vbCrLf & "Zoom or scroll on the chart below using the different modifiers."
        '
        'panel1
        '
        Me.panel1.Controls.Add(Me.cbScroll)
        Me.panel1.Controls.Add(Me.cbZoom)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Controls.Add(Me.cbModifier)
        ' 
        ' tChart1
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Aspect.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
        Me.tChart1.Aspect.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias
        Me.tChart1.Aspect.View3D = False
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Bottom.Labels.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Bottom.Title.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Depth.Labels.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Depth.Title.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.DepthTop.Labels.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.DepthTop.Title.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Left.Labels.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Left.Title.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Right.Labels.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Right.Title.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Top.Labels.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Axes.Top.Title.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        Me.tChart1.Cursor = System.Windows.Forms.Cursors.Default
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Footer.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Header.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        Me.tChart1.Header.Lines = New String() {"ZoomScroll Key Modifiers"}
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Legend.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Legend.Title.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(216, Byte), Integer))
        ' 
        ' 
        ' 
        Me.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.tChart1.Panel.Brush.Gradient.ExtendedColorPalette = Nothing
        Me.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tChart1.Panel.Brush.Gradient.Sigma = True
        Me.tChart1.Panel.Brush.Gradient.SigmaFocus = 1.0!
        Me.tChart1.Panel.Brush.Gradient.SigmaScale = 0.8!
        Me.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tChart1.Panel.Brush.Gradient.UseMiddle = True
        Me.tChart1.Panel.Brush.Gradient.Visible = True
        Me.tChart1.Series.Add(Me.Line1)
        Me.tChart1.Size = New System.Drawing.Size(440, 205)
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.SubFooter.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.SubHeader.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        '
        'cbScroll
        '
#If VS2005 Then
        Me.cbScroll.AutoSize = True
#End If
        Me.cbScroll.Checked = True
        Me.cbScroll.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbScroll.Location = New System.Drawing.Point(249, 19)
        Me.cbScroll.Name = "cbScroll"
        Me.cbScroll.Size = New System.Drawing.Size(93, 17)
        Me.cbScroll.TabIndex = 7
        Me.cbScroll.Text = "Apply to Scroll"
#If VS2005 Then
        Me.cbScroll.UseVisualStyleBackColor = True
#End If
        AddHandler Me.cbScroll.CheckedChanged, AddressOf Me.cbScroll_CheckedChanged
        '
        'cbZoom
        '
#If VS2005 Then
        Me.cbZoom.AutoSize = True
#End If
        Me.cbZoom.Checked = True
        Me.cbZoom.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbZoom.Location = New System.Drawing.Point(249, 3)
        Me.cbZoom.Name = "cbZoom"
        Me.cbZoom.Size = New System.Drawing.Size(94, 17)
        Me.cbZoom.TabIndex = 6
        Me.cbZoom.Text = "Apply to Zoom"
#If VS2005 Then
        Me.cbZoom.UseVisualStyleBackColor = True
#End If
        AddHandler Me.cbZoom.CheckedChanged, AddressOf Me.cbZoom_CheckedChanged
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(25, 13)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(65, 13)
        Me.label1.TabIndex = 5
        Me.label1.Text = "Key Modifier"
        '
        'cbModifier
        '
#If VS2005 Then
        Me.cbModifier.FormattingEnabled = True
#End If
        Me.cbModifier.Location = New System.Drawing.Point(96, 10)
        Me.cbModifier.Name = "cbModifier"
        Me.cbModifier.Size = New System.Drawing.Size(121, 21)
        Me.cbModifier.TabIndex = 4
        Me.cbModifier.Text = "None"
        AddHandler Me.cbModifier.SelectedIndexChanged, AddressOf Me.cbModifier_SelectedIndexChanged
        '
        'Line1
        '
        '
        '
        '
        Me.Line1.Brush.Color = System.Drawing.Color.Red
        Me.Line1.ColorEach = False
        '
        '
        '
        Me.Line1.Gradient.ExtendedColorPalette = Nothing
        Me.Line1.Gradient.StartColor = System.Drawing.Color.Red
        '
        '
        '
        Me.Line1.LinePen.Color = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        '
        '
        '
        '
        '
        Me.Line1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None
        Me.Line1.Marks.Callout.ArrowHeadSize = 8
        '
        '
        '
        Me.Line1.Marks.Callout.Brush.Color = System.Drawing.Color.Black
        Me.Line1.Marks.Callout.Distance = 0
        Me.Line1.Marks.Callout.Draw3D = False
        Me.Line1.Marks.Callout.Length = 10
        Me.Line1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        '
        '
        '
        Me.Line1.Marks.Font.DrawingFont = New System.Drawing.Font("Arial", 8.0!)
        '
        '
        '
        Me.Line1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.Line1.Title = "line1"
        '
        '
        '
        Me.Line1.XValues.DataMember = "X"
        Me.Line1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        '
        '
        '
        Me.Line1.YValues.DataMember = "Y"
        '
        'Zoom_KeyShift
        '
        Me.ClientSize = New System.Drawing.Size(440, 317)
        Me.Name = "Zoom_KeyShift"
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.chartContainer.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub ApplyKeyShift()
        Dim key As Keys = CType(System.Enum.Parse(GetType(Keys), cbModifier.SelectedItem.ToString()), Keys)

        If (doZoom) Then
            tChart1.Zoom.KeyShift = key
        Else
            tChart1.Zoom.KeyShift = Keys.None
        End If

        If (doScroll) Then
            tChart1.Panning.KeyShift = key
        Else
            tChart1.Panning.KeyShift = Keys.None
        End If
    End Sub

    Private Sub cbZoom_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        doZoom = cbZoom.Checked
        ApplyKeyShift()
    End Sub

    Private Sub cbScroll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        doScroll = cbScroll.Checked
        ApplyKeyShift()
    End Sub

    Private Sub cbModifier_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ApplyKeyShift()
    End Sub
End Class

