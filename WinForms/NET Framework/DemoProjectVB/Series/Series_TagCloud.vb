
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing

Imports System.Windows.Forms




Public Class Series_TagCloud
    Inherits Samples.BaseForm
   
    Private components As System.ComponentModel.IContainer = Nothing


    Public Sub New()
        ' me call is required by the Windows Form Designer.
        InitializeComponent()
        InitializeChart()

    End Sub 'New

    Private WithEvents button1 As Button
    Private tagCloud1 As Steema.TeeChart.Styles.TagCloud

    Private Sub InitializeChart()
        tagCloud1 = New Steema.TeeChart.Styles.TagCloud()
        tChart1.Series.Add(tagCloud1)
        tagCloud1.FillSampleValues()
    End Sub

    Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
        tagCloud1.FillSampleValues()
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

#Region "Designer generated code"

    '/ <summary>
    '/ Required method for Designer support - do not modify
    '/ the contents of me method with the code editor.
    '/ </summary>
    Private Sub InitializeComponent()
        Me.button1 = New System.Windows.Forms.Button()
        Me.panel1.SuspendLayout()
        Me.chartContainer.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Text = "Using the TagClouds AddTag() method you can add in a text with its frequency" + vbCr + vbLf + "and" + _
          " have that displayed in a cloud with a font whose colour and size is" + vbCr + vbLf + vbCr + vbLf + "relative t" + _
          "o that frequency."
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.button1)
        ' 
        ' tChart1
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Header.Lines = New String() { _
        "TagCloud"}
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        ' 
        Me.tChart1.Legend.Title.Pen.Visible = False
        Me.tChart1.Size = New System.Drawing.Size(440, 205)
        ' 
        ' button1
        ' 
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.Location = New System.Drawing.Point(12, 10)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(151, 23)
        Me.button1.TabIndex = 0
        Me.button1.Text = "Refill with Sample Values"
#If VS2005 Then
        Me.button1.UseVisualStyleBackColor = True
        ' 
        ' Series_TagCloud
        ' 
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
#End If
        Me.ClientSize = New System.Drawing.Size(440, 317)
        Me.Name = "Series_TagCloud"
        Me.Text = "Series_TagCloud"
        Me.panel1.ResumeLayout(False)
        Me.chartContainer.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub 'InitializeComponent 
#End Region


End Class 'Area_Gradient
