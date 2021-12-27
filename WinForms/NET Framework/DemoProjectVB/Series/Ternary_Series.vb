Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Steema.TeeChart.Editors.Series
Imports Steema.TeeChart.Editors
Public Class Ternary_Series
    Inherits BaseForm
    Private WithEvents bEdit As Button
    '/ <summary>
    '/ Required designer variable.
    '/ </summary>
    Private components As System.ComponentModel.IContainer = Nothing
    '/<summary>
    '/Clean up any resources being used.
    '/</summary>
    '/<param name="disposing">true if managed resources should be disposed otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If (Not (components) Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub
#Region "Windows Form Designer generated code"
    '/<summary>
    '/Required method for Designer support - do not modify
    '/the contents of this method with the code editor.
    '/ </summary>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ternary_Series))
        Me.bEdit = New System.Windows.Forms.Button
        Me.marksTip1 = New Steema.TeeChart.Tools.MarksTip
        Me.panel1.SuspendLayout()
        Me.chartContainer.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Text = "The Ternary series is used to represent the relative percentage of three components." & vbCrLf & "The three components will sum to 100%, or will be normalised by TeeChart to 100%." & vbCrLf & vbCrLf & "The Ternary Series can plot relative position, value 'size' as point radius and use a colour gradient scale to add weighting information."
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.bEdit)
        ' 
        ' tChart1
        ' 
        Me.tChart1.Aspect.ZOffset = 0
        Me.tChart1.Legend.TextStyle = Steema.TeeChart.LegendTextStyles.RightValue
        Me.tChart1.Legend.Title.Font.Bold = False
        Me.tChart1.Legend.Title.Font.Size = 6
        Me.tChart1.Legend.Title.Font.SizeFloat = 6.0!
        Me.tChart1.Legend.Title.Transparent = True
        Me.tChart1.Legend.Transparent = True
        Me.tChart1.Size = New System.Drawing.Size(440, 205)
        Me.tChart1.Tools.Add(Me.marksTip1)
        AddHandler tChart1.BeforeDraw, AddressOf Me.tChart1_BeforeDraw
        ' 
        ' bEdit
        ' 
        Me.bEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bEdit.Location = New System.Drawing.Point(12, 10)
        Me.bEdit.Name = "bEdit"
        Me.bEdit.Size = New System.Drawing.Size(75, 23)
        Me.bEdit.TabIndex = 0
        Me.bEdit.Text = "Edit..."
#If (VS2005) Then
        Me.bEdit.UseVisualStyleBackColor = True
#End If
        AddHandler bEdit.Click, AddressOf Me.bEdit_Click
        ' 
        ' Ternary_Series
        ' 
#If (VS2005) Then
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
#End If
        Me.ClientSize = New System.Drawing.Size(440, 317)
        Me.Name = "Ternary_Series"
        Me.Text = "Ternary_Series"
        Me.panel1.ResumeLayout(False)
        Me.chartContainer.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub
#End Region
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        InitializeChart()
    End Sub
    Private marksTip1 As Steema.TeeChart.Tools.MarksTip
    Private ternary1 As Steema.TeeChart.Styles.Ternary
    Private Sub InitializeChart()
        tChart1.Header.Text = "Ternay Series Example"
        ternary1 = New Steema.TeeChart.Styles.Ternary()
        tChart1.Series.Add(ternary1)
        ternary1.FillSampleValues(10)
        ternary1.MarkStyle = Steema.TeeChart.Styles.TernaryMarkStyle.LongLabelled
        ternary1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Sphere
        ternary1.TernaryStyle = Steema.TeeChart.Styles.TernaryStyle.Bubble
        ternary1.Pointer.Transparency = 20
        ternary1.TernaryLegendStyle = Steema.TeeChart.Styles.TernaryLegendStyle.BubbleWeight
        tChart1.Legend.Title.Text = (Texts.TernaryMarkRadius + (", " + Texts.TernaryMarkWeight))
        ternary1.Marks.MultiLine = True
        ternary1.EndColor = Color.LightGreen
        'for use when range palette active (ColorEach false)
        tChart1.Legend.Title.Visible = True
    End Sub
    Private Sub bEdit_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim editor As TernarySeries = New TernarySeries(ternary1)
        EditorUtils.ShowFormModal(editor)
    End Sub
    Private Sub tChart1_BeforeDraw(ByVal sender As Object, ByVal g As Steema.TeeChart.Drawing.Graphics3D)
        tChart1.Legend.Title.Visible = ternary1.ColorEach
    End Sub
End Class