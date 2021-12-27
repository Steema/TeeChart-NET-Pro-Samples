Imports System
#If (VS2005) Then
Imports System.Collections.Generic
#End If
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Public Class Point3D_Nulls
    Inherits BaseForm
    Private groupBox1 As GroupBox
    Private cbView3D As CheckBox
    Private rbSkip As RadioButton
    Private rbIgnore As RadioButton
    Private rbDoNotPaint As RadioButton
    Private bRefresh As Button
    '/ <summary>
    '/ Required designer variable.
    '/ </summary>
    Private components As System.ComponentModel.IContainer = Nothing
    '/<summary>
    '/Clean up any resources being used.
    '/</summary>
    '/<param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If (Not (components) Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub
#Region "Windows Form Designer generated code"
    '/ <summary>
    'Required method for Designer support - do not modify
    'the contents of this method with the code editor.
    '/</summary>"    Private Sub InitializeComponent()End Class
    Private Sub InitializeComponent()
        Me.groupBox1 = New System.Windows.Forms.GroupBox
        Me.rbSkip = New System.Windows.Forms.RadioButton
        Me.rbIgnore = New System.Windows.Forms.RadioButton
        Me.rbDoNotPaint = New System.Windows.Forms.RadioButton
        Me.cbView3D = New System.Windows.Forms.CheckBox
        Me.bRefresh = New System.Windows.Forms.Button
        Me.panel1.SuspendLayout()
        Me.chartContainer.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Text = ("Point3D series now fully supports null values. A new Add() overload" & vbCrLf & "is also used" & (" in this example which allows arrays of colors to be directly" & vbCrLf & "added to a Custom" & "3D series."))
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.bRefresh)
        Me.panel1.Controls.Add(Me.cbView3D)
        Me.panel1.Controls.Add(Me.groupBox1)
        ' 
        ' tChart1
        ' 
        ' 
        Me.tChart1.Legend.Title.Pen.Visible = False
        Me.tChart1.Size = New System.Drawing.Size(440, 205)
        ' 
        ' groupBox1
        ' 
        Me.groupBox1.Controls.Add(Me.rbSkip)
        Me.groupBox1.Controls.Add(Me.rbIgnore)
        Me.groupBox1.Controls.Add(Me.rbDoNotPaint)
        Me.groupBox1.Location = New System.Drawing.Point(12, 3)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(213, 36)
        Me.groupBox1.TabIndex = 0
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Null Style"
        ' 
        ' rbSkip
        ' 
        Me.rbSkip.Location = New System.Drawing.Point(158, 13)
        Me.rbSkip.Name = "rbSkip"
        Me.rbSkip.Size = New System.Drawing.Size(46, 17)
        Me.rbSkip.TabIndex = 3
        Me.rbSkip.TabStop = True
        Me.rbSkip.Text = "Skip"
#If (VS2005) Then
        Me.rbSkip.AutoSize = True
        Me.rbSkip.UseVisualStyleBackColor = True
#End If
        ' 
        ' rbIgnore
        ' 
        Me.rbIgnore.Location = New System.Drawing.Point(97, 13)
        Me.rbIgnore.Name = "rbIgnore"
        Me.rbIgnore.Size = New System.Drawing.Size(55, 17)
        Me.rbIgnore.TabIndex = 2
        Me.rbIgnore.TabStop = True
        Me.rbIgnore.Text = "Ignore"
#If (VS2005) Then
        Me.rbIgnore.AutoSize = True
        Me.rbIgnore.UseVisualStyleBackColor = True
#End If
        ' 
        ' rbDoNotPaint
        ' 
        Me.rbDoNotPaint.Checked = True
        Me.rbDoNotPaint.Location = New System.Drawing.Point(6, 13)
        Me.rbDoNotPaint.Name = "rbDoNotPaint"
        Me.rbDoNotPaint.Size = New System.Drawing.Size(80, 17)
        Me.rbDoNotPaint.TabIndex = 1
        Me.rbDoNotPaint.TabStop = True
        Me.rbDoNotPaint.Text = "DoNotPaint"
#If (VS2005) Then
        Me.rbDoNotPaint.AutoSize = True
        Me.rbDoNotPaint.UseVisualStyleBackColor = True
#End If
        ' 
        ' cbView3D
        ' 
        Me.cbView3D.Checked = True
        Me.cbView3D.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbView3D.Location = New System.Drawing.Point(252, 16)
        Me.cbView3D.Name = "cbView3D"
        Me.cbView3D.Size = New System.Drawing.Size(63, 17)
        Me.cbView3D.TabIndex = 1
        Me.cbView3D.Text = "View3D"
#If (VS2005) Then
        Me.cbView3D.AutoSize = True
        Me.cbView3D.UseVisualStyleBackColor = True
#End If
        AddHandler cbView3D.CheckedChanged, AddressOf Me.cbView3D_CheckedChanged
        ' 
        ' bRefresh
        ' 
        Me.bRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bRefresh.Location = New System.Drawing.Point(330, 13)
        Me.bRefresh.Name = "bRefresh"
        Me.bRefresh.Size = New System.Drawing.Size(75, 23)
        Me.bRefresh.TabIndex = 2
        Me.bRefresh.Text = "Refresh..."
#If (VS2005) Then
        Me.bRefresh.UseVisualStyleBackColor = True
#End If
        AddHandler bRefresh.Click, AddressOf Me.bRefresh_Click
        ' 
        ' Point3D_Nulls
        ' 
#If (VS2005) Then
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
#End If
        Me.ClientSize = New System.Drawing.Size(440, 317)
        Me.Name = "Point3D_Nulls"
        Me.Text = "Point3D_Nulls"
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.chartContainer.ResumeLayout(False)
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
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
    Private points3D As Steema.TeeChart.Styles.Points3D
    Private Sub InitializeChart()
        points3D = New Steema.TeeChart.Styles.Points3D()
        tChart1.Series.Add(points3D)
        AddHandler rbDoNotPaint.CheckedChanged, AddressOf Me.rbNulls_CheckedChanged
        AddHandler rbIgnore.CheckedChanged, AddressOf Me.rbNulls_CheckedChanged
        AddHandler rbSkip.CheckedChanged, AddressOf Me.rbNulls_CheckedChanged
    End Sub
    Private Sub rbNulls_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
        Dim but As RadioButton = CType(sender, RadioButton)
        Select Case (but.Text)
            Case "DoNotPaint"
                points3D.TreatNulls = Steema.TeeChart.Styles.TreatNullsStyle.DoNotPaint
            Case "Ignore"
                points3D.TreatNulls = Steema.TeeChart.Styles.TreatNullsStyle.Ignore
            Case "Skip"
                points3D.TreatNulls = Steema.TeeChart.Styles.TreatNullsStyle.Skip
        End Select
    End Sub
    Private Sub AddPoints()
        Dim length As Integer = 55
        Dim xValues() As Double = New Double((length) - 1) {}
        Dim yValues() As Double = New Double((length) - 1) {}
        Dim zValues() As Double = New Double((length) - 1) {}
        Dim colorValues() As Color = New Color((length) - 1) {}
        Dim rnd As Random = New Random
        Dim tmp As Double = 0
        Dim oldTemp As Double = 0
        points3D.DefaultNullValue = 0
        Dim i As Integer
        For i = 0 To length
            tmp = rnd.NextDouble

            While (tmp = oldTemp)
                tmp = rnd.NextDouble

            End While
            If ((i > 0) And ((i Mod 5) = 0)) Then
                xValues(i) = i
                yValues(i) = 0
                zValues(i) = tmp
                colorValues(i) = Color.Transparent
            Else
                xValues(i) = i
                yValues(i) = tmp
                zValues(i) = tmp
                colorValues(i) = Color.FromArgb((255 - Steema.TeeChart.Utils.Round((255 * tmp))), Steema.TeeChart.Utils.Round((255 * tmp)), (255 - Steema.TeeChart.Utils.Round((255 * tmp))))
            End If
            oldTemp = tmp
            i = (i + 1)
        Next
        points3D.Add(xValues, yValues, zValues, colorValues)
    End Sub

    Private Sub cbView3D_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
        tChart1.Aspect.View3D = cbView3D.Checked
    End Sub

    Private Sub bRefresh_Click(ByVal sender As Object, ByVal e As EventArgs)
        points3D.Clear()
        AddPoints()
    End Sub
End Class