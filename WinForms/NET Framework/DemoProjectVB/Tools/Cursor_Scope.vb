Imports System
#If (VS2005) Then
Imports System.Collections.Generic
#End If
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Public Class Cursor_Scope
    Inherits BaseForm
    Private line1 As Steema.TeeChart.Styles.Line
    Private line2 As Steema.TeeChart.Styles.Line
    Private cbUseSeriesZ As CheckBox
    Private cbFullWidth As CheckBox
    Private cbFastCursor As CheckBox
    Private bEdit As Button
    Private myCursor As Steema.TeeChart.Tools.CursorTool
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

    Public Sub New()
        InitializeComponent()
        InitializeChart()
    End Sub
#Region "Designer generated code"
    '/<summary>
    '/ Required method for Designer support - do not modify
    '/ the contents of this method with the code editor.
    '/ </summary>
    Private Sub InitializeComponent()
        Me.cbUseSeriesZ = New System.Windows.Forms.CheckBox
        Me.cbFullWidth = New System.Windows.Forms.CheckBox
        Me.cbFastCursor = New System.Windows.Forms.CheckBox
        Me.bEdit = New System.Windows.Forms.Button
        Me.panel1.SuspendLayout()
        Me.chartContainer.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Text = "CursorTool has scopes of various styles and the UseSeriesZ property."
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.bEdit)
        Me.panel1.Controls.Add(Me.cbFastCursor)
        Me.panel1.Controls.Add(Me.cbFullWidth)
        Me.panel1.Controls.Add(Me.cbUseSeriesZ)
        ' 
        ' tChart1
        ' 
        Me.tChart1.Header.Lines = New String() {"Cursor Scope"}
        Me.tChart1.Legend.Title.Pen.Visible = False
        Me.tChart1.Size = New System.Drawing.Size(440, 205)
        ' 
        ' cbUseSeriesZ
        ' 
        Me.cbUseSeriesZ.Checked = True
        Me.cbUseSeriesZ.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbUseSeriesZ.Location = New System.Drawing.Point(3, 6)
        Me.cbUseSeriesZ.Name = "cbUseSeriesZ"
        Me.cbUseSeriesZ.Size = New System.Drawing.Size(81, 17)
        Me.cbUseSeriesZ.TabIndex = 0
        Me.cbUseSeriesZ.Text = "UseSeriesZ"
#If (VS2005) Then
        Me.cbUseSeriesZ.AutoSize = True
        Me.cbUseSeriesZ.UseVisualStyleBackColor = True
#End If
        AddHandler cbUseSeriesZ.CheckedChanged, AddressOf Me.cbUseSeriesZ_CheckedChanged
        ' 
        ' cbFullWidth
        ' 
        Me.cbFullWidth.Location = New System.Drawing.Point(90, 6)
        Me.cbFullWidth.Name = "cbFullWidth"
        Me.cbFullWidth.Size = New System.Drawing.Size(73, 17)
        Me.cbFullWidth.TabIndex = 1
        Me.cbFullWidth.Text = "Full Width"
#If (VS2005) Then
        Me.cbFullWidth.AutoSize = True
        Me.cbFullWidth.UseVisualStyleBackColor = True
#End If
        AddHandler cbFullWidth.CheckedChanged, AddressOf Me.cbFullWidth_CheckedChanged
        ' 
        ' cbFastCursor
        ' 
        Me.cbFastCursor.Location = New System.Drawing.Point(169, 6)
        Me.cbFastCursor.Name = "cbFastCursor"
        Me.cbFastCursor.Size = New System.Drawing.Size(76, 17)
        Me.cbFastCursor.TabIndex = 2
        Me.cbFastCursor.Text = "FastCursor"
#If (VS2005) Then
        Me.cbFastCursor.AutoSize = True
        Me.cbFastCursor.UseVisualStyleBackColor = True
#End If
        AddHandler cbFastCursor.CheckedChanged, AddressOf Me.cbFastCursor_CheckedChanged
        ' 
        ' bEdit
        ' 
        Me.bEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bEdit.Location = New System.Drawing.Point(340, 7)
        Me.bEdit.Name = "bEdit"
        Me.bEdit.Size = New System.Drawing.Size(75, 23)
        Me.bEdit.TabIndex = 3
        Me.bEdit.Text = "Edit..."
#If (VS2005) Then
        Me.bEdit.UseVisualStyleBackColor = True
#End If
        AddHandler bEdit.Click, AddressOf Me.bEdit_Click
        ' 
        ' Cursor_Scope
        ' 
#If (VS2005) Then
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
#End If
        Me.ClientSize = New System.Drawing.Size(440, 317)
        Me.Name = "Cursor_Scope"
        Me.Text = "Cursor_Scope"
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.chartContainer.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub
#End Region
    Private Sub InitializeChart()
        line1 = New Steema.TeeChart.Styles.Line()
        line2 = New Steema.TeeChart.Styles.Line()
        tChart1.Series.Add(line1)
        tChart1.Series.Add(line2)
        line1.FillSampleValues()
        line2.FillSampleValues()
        myCursor = New Steema.TeeChart.Tools.CursorTool()
        tChart1.Tools.Add(myCursor)
        myCursor.UseSeriesZ = True
        myCursor.FollowMouse = True
        myCursor.Style = Steema.TeeChart.Tools.CursorToolStyles.Scope
        myCursor.ScopeStyle = Steema.TeeChart.Tools.ScopeCursorStyle.Rectangle
        myCursor.ScopeSize = 20
        myCursor.HorizSize = 10
        myCursor.VertSize = 10
    End Sub

    Private Sub cbUseSeriesZ_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
        myCursor.UseSeriesZ = cbUseSeriesZ.Checked
    End Sub

    Private Sub cbFullWidth_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
        myCursor.HorizSize = cbFullWidth.Checked
        myCursor.VertSize = cbFullWidth.Checked
    End Sub

    Private Sub cbFastCursor_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
        myCursor.FastCursor = cbFastCursor.Checked
    End Sub

    Private Sub bEdit_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim editor As Steema.TeeChart.Editors.Tools.CursorEditor = New Steema.TeeChart.Editors.Tools.CursorEditor(myCursor)
        Steema.TeeChart.Editors.EditorUtils.ShowFormModal(editor)
    End Sub
End Class