
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing

Imports System.Windows.Forms




Public Class Tool_CursorSynchro
    Inherits Steema.TeeChart.Samples.BaseNoChart
    Private WithEvents tChart1 As Steema.TeeChart.TChart
    Private lineSeries1 As Steema.TeeChart.Styles.Line
    Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
    Private WithEvents cursorSRC As Steema.TeeChart.Tools.CursorTool
    Private tChart2 As Steema.TeeChart.TChart
    Private lineSeries2 As Steema.TeeChart.Styles.Line
    Private WithEvents cursorDEST As Steema.TeeChart.Tools.CursorTool
    Private checkBox2 As System.Windows.Forms.CheckBox
    Private label1 As System.Windows.Forms.Label
    Private components As System.ComponentModel.IContainer = Nothing
    
    
    
    '/ <summary>
    '/ This procedure synchronizes two cursors.
    '/ "SRC" is the original cursor, and "DEST" the cursor
    '/ that is re-positioned.
    '/ </summary>
    Private Sub CursorSynchronize(SRC As Steema.TeeChart.Tools.CursorTool, DEST As Steema.TeeChart.Tools.CursorTool)
        ' DEST.Chart.AutoRepaint = false ' stop repainting
        ' DEST.RedrawCursor()   ' hide cursor			

        DEST.XValue = SRC.XValue
        DEST.YValue = SRC.YValue

        ' TODO: DEST.RedrawCursor() ' draw cursor again
        ' DEST.Chart.AutoRepaint = true ' enable repainting			

    End Sub 'CursorSynchronize
     
    
    
    Private Sub ShowXY(X As Double, Y As Double)
        Me.label1.Text = X.ToString("#.00") + "   " + Y.ToString("#.00")
    End Sub 'ShowXY
    
    
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        
        Me.lineSeries1.FillSampleValues(1000)
        Me.lineSeries2.DataSource = Me.lineSeries1
        
        ' Setup cursors
        Me.cursorSRC.FollowMouse = True
        Me.cursorSRC.Series = Me.lineSeries1
        Me.cursorSRC.XValue = 500
        Me.cursorSRC.YValue = 0.5 * (Me.lineSeries1.YValues.Maximum + Me.lineSeries1.YValues.Minimum)
        
        
        Me.cursorDEST.Series = Me.lineSeries2
        Me.cursorDEST.FollowMouse = True
    End Sub 'New
     
    
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
        Me.tChart1 = New Steema.TeeChart.TChart
        Me.lineSeries1 = New Steema.TeeChart.Styles.Line
        Me.cursorSRC = New Steema.TeeChart.Tools.CursorTool
        Me.checkBox1 = New System.Windows.Forms.CheckBox
        Me.tChart2 = New Steema.TeeChart.TChart
        Me.lineSeries2 = New Steema.TeeChart.Styles.Line
        Me.cursorDEST = New Steema.TeeChart.Tools.CursorTool
        Me.checkBox2 = New System.Windows.Forms.CheckBox
        Me.label1 = New System.Windows.Forms.Label
        Me.panel1.SuspendLayout()
        Me.panel2.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(426, 54)
        Me.textBox1.Text = "Cursors can be synchronized as this example shows. Both Chart1 and Chart2 contain" + " a Cursor tool. The Cursor tool OnChange event is used to synchronize the other." + ""
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Controls.Add(Me.checkBox2)
        Me.panel1.Controls.Add(Me.checkBox1)
        Me.panel1.Location = New System.Drawing.Point(0, 54)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(426, 48)
        ' 
        ' panel2
        ' 
        Me.panel2.Controls.Add(Me.tChart2)
        Me.panel2.Controls.Add(Me.tChart1)
        Me.panel2.Location = New System.Drawing.Point(0, 102)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(426, 156)
        ' 
        ' tChart1
        ' 
        ' 
        ' tChart1.Aspect
        ' 
        Me.tChart1.Aspect.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality
        Me.tChart1.Aspect.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        Me.tChart1.Aspect.View3D = False
        Me.tChart1.BackColor = System.Drawing.Color.Transparent
        Me.tChart1.Dock = System.Windows.Forms.DockStyle.Left
        ' 
        ' tChart1.Header
        ' 
        Me.tChart1.Header.Lines = New String() {"tChart1"}
        ' 
        ' tChart1.Legend
        ' 
        Me.tChart1.Legend.Visible = False
        Me.tChart1.Location = New System.Drawing.Point(0, 0)
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Bevel
        ' 
        Me.tChart1.Panel.Bevel.ColorOne = System.Drawing.Color.FromArgb(CType(255, System.Byte), CType(128, System.Byte), CType(128, System.Byte))
        ' 
        ' tChart1.Panel.Brush
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(178, System.Byte), CType(255, System.Byte), CType(192, System.Byte), CType(128, System.Byte))
        Me.tChart1.Series.Add(Me.lineSeries1)
        Me.tChart1.Size = New System.Drawing.Size(200, 156)
        Me.tChart1.TabIndex = 0
        Me.tChart1.Tools.Add(Me.cursorSRC)
        ' 
        ' lineSeries1
        ' 
        ' 
        ' lineSeries1.Brush
        ' 
        Me.lineSeries1.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(128, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        Me.lineSeries1.Cursor = System.Windows.Forms.Cursors.Cross
        ' 
        ' lineSeries1.LinePen
        ' 
        Me.lineSeries1.LinePen.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(77, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        ' 
        ' lineSeries1.Marks
        ' 
        ' 
        ' lineSeries1.Marks.Symbol
        ' 
        ' 
        ' lineSeries1.Marks.Symbol.Shadow
        ' 
        Me.lineSeries1.Marks.Symbol.Shadow.Height = 1
        Me.lineSeries1.Marks.Symbol.Shadow.Visible = True
        Me.lineSeries1.Marks.Symbol.Shadow.Width = 1
        ' 
        ' lineSeries1.Pointer
        ' 
        ' 
        ' lineSeries1.Pointer.Brush
        ' 
        Me.lineSeries1.Pointer.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(0, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        Me.lineSeries1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.lineSeries1.Title = "lineSeries1"
        ' 
        ' lineSeries1.XValues
        ' 
        Me.lineSeries1.XValues.DataMember = "X"
        Me.lineSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' lineSeries1.YValues
        ' 
        Me.lineSeries1.YValues.DataMember = "Y"
        ' 
        ' cursorSRC
        ' 
        ' 
        ' checkBox1
        ' 
        Me.checkBox1.Checked = True
        Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox1.Location = New System.Drawing.Point(13, 14)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(99, 21)
        Me.checkBox1.TabIndex = 0
        Me.checkBox1.Text = "&Follow mouse"
        ' 
        ' tChart2
        ' 
        ' 
        ' tChart2.Aspect
        ' 
        Me.tChart2.Aspect.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality
        Me.tChart2.Aspect.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        Me.tChart2.Aspect.View3D = False
        Me.tChart2.BackColor = System.Drawing.Color.Transparent
        Me.tChart2.Dock = System.Windows.Forms.DockStyle.Fill
        ' 
        ' tChart2.Header
        ' 
        Me.tChart2.Header.Lines = New String() {"tChart2"}
        ' 
        ' tChart2.Legend
        ' 
        Me.tChart2.Legend.Visible = False
        Me.tChart2.Location = New System.Drawing.Point(200, 0)
        Me.tChart2.Name = "tChart2"
        ' 
        ' tChart2.Panel
        ' 
        ' 
        ' tChart2.Panel.Brush
        ' 
        Me.tChart2.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(76, System.Byte), CType(128, System.Byte), CType(64, System.Byte), CType(0, System.Byte))
        Me.tChart2.Series.Add(Me.lineSeries2)
        Me.tChart2.Size = New System.Drawing.Size(226, 156)
        Me.tChart2.TabIndex = 1
        Me.tChart2.Tools.Add(Me.cursorDEST)
        ' 
        ' lineSeries2
        ' 
        ' 
        ' lineSeries2.Brush
        ' 
        Me.lineSeries2.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(128, System.Byte), CType(128, System.Byte), CType(255, System.Byte))
        Me.lineSeries2.Cursor = System.Windows.Forms.Cursors.Cross
        ' 
        ' lineSeries2.LinePen
        ' 
        Me.lineSeries2.LinePen.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(77, System.Byte), CType(77, System.Byte), CType(153, System.Byte))
        ' 
        ' lineSeries2.Marks
        ' 
        ' 
        ' lineSeries2.Marks.Symbol
        ' 
        ' 
        ' lineSeries2.Marks.Symbol.Shadow
        ' 
        Me.lineSeries2.Marks.Symbol.Shadow.Height = 1
        Me.lineSeries2.Marks.Symbol.Shadow.Visible = True
        Me.lineSeries2.Marks.Symbol.Shadow.Width = 1
        ' 
        ' lineSeries2.Pointer
        ' 
        ' 
        ' lineSeries2.Pointer.Brush
        ' 
        Me.lineSeries2.Pointer.Brush.Color = System.Drawing.Color.FromArgb(CType(254, System.Byte), CType(0, System.Byte), CType(0, System.Byte), CType(0, System.Byte))
        Me.lineSeries2.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        Me.lineSeries2.Title = "lineSeries2"
        ' 
        ' lineSeries2.XValues
        ' 
        Me.lineSeries2.XValues.DataMember = "X"
        Me.lineSeries2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        ' 
        ' lineSeries2.YValues
        ' 
        Me.lineSeries2.YValues.DataMember = "Y"
        ' 
        ' cursorDEST
        ' 
        ' 
        ' checkBox2
        ' 
        Me.checkBox2.Checked = True
        Me.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox2.Location = New System.Drawing.Point(127, 14)
        Me.checkBox2.Name = "checkBox2"
        Me.checkBox2.Size = New System.Drawing.Size(86, 21)
        Me.checkBox2.TabIndex = 1
        Me.checkBox2.Text = "&Synchronize"
        ' 
        ' label1
        ' 
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(220, 17)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(20, 16)
        Me.label1.TabIndex = 2
        Me.label1.Text = "0,0"
        Me.label1.UseMnemonic = False
        ' 
        ' Cursor_Sync
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(426, 258)
        Me.Name = "Cursor_Sync"
        Me.panel1.ResumeLayout(False)
        Me.panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub 'InitializeComponent 
#End Region


    Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox1.CheckedChanged
        Me.cursorSRC.FollowMouse = Me.checkBox1.Checked
        Me.cursorDEST.FollowMouse = Me.checkBox1.Checked
    End Sub 'checkBox1_CheckedChanged


    Private Sub cursorSRC_Change(ByVal sender As Object, ByVal e As Steema.TeeChart.Tools.CursorChangeEventArgs) Handles cursorSRC.Change
        If Me.checkBox2.Checked Then
            CursorSynchronize(CType(sender, Steema.TeeChart.Tools.CursorTool), Me.cursorDEST)
        End If
        ShowXY(e.XValue, e.YValue)
    End Sub 'cursorSRC_Change


    Private Sub cursorDEST_Change(ByVal sender As Object, ByVal e As Steema.TeeChart.Tools.CursorChangeEventArgs) Handles cursorDEST.Change
        If Me.checkBox2.Checked Then
            CursorSynchronize(CType(sender, Steema.TeeChart.Tools.CursorTool), Me.cursorSRC)
        End If
        ShowXY(e.XValue, e.YValue)
    End Sub 'cursorDEST_Change


    Private Sub tChart1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tChart1.Click
    End Sub 'tChart1_Click
End Class 'Tool_CursorSynchro 
