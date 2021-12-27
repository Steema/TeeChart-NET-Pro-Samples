
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms


Public Class RichText_Drawing
    Inherits Steema.TeeChart.Samples.BaseForm
    Private components As System.ComponentModel.IContainer = Nothing
    
    Public Sub New() ' This call is required by the Windows Form Designer.
        InitializeComponent()

        Dim RichText As String
        RichText = "{\rtf1\ansi\ansicpg1252\uc1\deff0\stshfdbch0\stshfloch0\stshfhich0\stshfbi0\deflang1033\deflangfe1033{\fonttbl{\f0\froman\fcharset0\fprq2{\*\panose 02020603050405020304}Times New Roman;}{\f39\fswiss\fcharset0\fprq2{\*\panose 020b0604030504040204}Verdana;}" + _
         "{\f226\froman\fcharset238\fprq2 Times New Roman CE;}{\f227\froman\fcharset204\fprq2 Times New Roman Cyr;}{\f229\froman\fcharset161\fprq2 Times New Roman Greek;}{\f230\froman\fcharset162\fprq2 Times New Roman Tur;}" + _
         "{\f231\froman\fcharset177\fprq2 Times New Roman (Hebrew);}{\f232\froman\fcharset178\fprq2 Times New Roman (Arabic);}{\f233\froman\fcharset186\fprq2 Times New Roman Baltic;}{\f234\froman\fcharset163\fprq2 Times New Roman (Vietnamese);}" + _
         "{\f616\fswiss\fcharset238\fprq2 Verdana CE;}{\f617\fswiss\fcharset204\fprq2 Verdana Cyr;}{\f619\fswiss\fcharset161\fprq2 Verdana Greek;}{\f620\fswiss\fcharset162\fprq2 Verdana Tur;}{\f623\fswiss\fcharset186\fprq2 Verdana Baltic;}" + _
         "{\f624\fswiss\fcharset163\fprq2 Verdana (Vietnamese);}}{\colortbl;\red0\green0\blue0;\red0\green0\blue255;\red0\green255\blue255;\red0\green255\blue0;\red255\green0\blue255;\red255\green0\blue0;\red255\green255\blue0;\red255\green255\blue255;" + _
         "\red0\green0\blue128;\red0\green128\blue128;\red0\green128\blue0;\red128\green0\blue128;\red128\green0\blue0;\red128\green128\blue0;\red128\green128\blue128;\red192\green192\blue192;}{\stylesheet{" + _
         "\ql \li0\ri0\widctlpar\aspalpha\aspnum\faauto\adjustright\rin0\lin0\itap0 \fs24\lang1033\langfe1033\cgrid\langnp1033\langfenp1033 \snext0 Normal;}{\*\cs10 \additive \ssemihidden Default Paragraph Font;}{\*" + _
         "\ts11\tsrowd\trftsWidthB3\trpaddl108\trpaddr108\trpaddfl3\trpaddft3\trpaddfb3\trpaddfr3\trcbpat1\trcfpat1\tscellwidthfts0\tsvertalt\tsbrdrt\tsbrdrl\tsbrdrb\tsbrdrr\tsbrdrdgl\tsbrdrdgr\tsbrdrh\tsbrdrv " + _
         "\ql \li0\ri0\widctlpar\aspalpha\aspnum\faauto\adjustright\rin0\lin0\itap0 \fs20\lang1024\langfe1024\cgrid\langnp1024\langfenp1024 \snext11 \ssemihidden Normal Table;}}{\*\latentstyles\lsdstimax156\lsdlockeddef0}{\*\rsidtbl \rsid11430898}{\*\generator Micr" + _
         "osoft Word 11.0.6113;}{\info{\title SuperScriptsuper  SubScriptsub}{\author Christopher Ireland}{\operator Christopher Ireland}{\creatim\yr2004\mo2\dy23\hr12\min23}{\revtim\yr2004\mo2\dy23\hr12\min26}{\version1}{\edmins3}{\nofpages1}{\nofwords9}" + _
         "{\nofchars52}{\*\company irelandlife.net}{\nofcharsws60}{\vern24699}}\widowctrl\ftnbj\aenddoc\noxlattoyen\expshrtn\noultrlspc\dntblnsbdb\nospaceforul\formshade\horzdoc\dgmargin\dghspace180\dgvspace180\dghorigin1800\dgvorigin1440\dghshow1\dgvshow1" + _
         "\jexpand\viewkind1\viewscale100\pgbrdrhead\pgbrdrfoot\splytwnine\ftnlytwnine\htmautsp\nolnhtadjtbl\useltbaln\alntblind\lytcalctblwd\lyttblrtgr\lnbrkrule\nobrkwrptbl\snaptogridincell\allowfieldendsel\wrppunct" + _
         "\asianbrkrule\rsidroot11430898\newtblstyruls\nogrowautofit \fet0\sectd \linex0\headery708\footery708\colsx708\endnhere\sectlinegrid360\sectdefaultcl\sftnbj {\*\pnseclvl1\pnucrm\pnstart1\pnindent720\pnhang {\pntxta .}}{\*\pnseclvl2" + _
         "\pnucltr\pnstart1\pnindent720\pnhang {\pntxta .}}{\*\pnseclvl3\pndec\pnstart1\pnindent720\pnhang {\pntxta .}}{\*\pnseclvl4\pnlcltr\pnstart1\pnindent720\pnhang {\pntxta )}}{\*\pnseclvl5\pndec\pnstart1\pnindent720\pnhang {\pntxtb (}{\pntxta )}}{\*\pnseclvl6" + _
         "\pnlcltr\pnstart1\pnindent720\pnhang {\pntxtb (}{\pntxta )}}{\*\pnseclvl7\pnlcrm\pnstart1\pnindent720\pnhang {\pntxtb (}{\pntxta )}}{\*\pnseclvl8\pnlcltr\pnstart1\pnindent720\pnhang {\pntxtb (}{\pntxta )}}{\*\pnseclvl9\pnlcrm\pnstart1\pnindent720\pnhang " + _
         "{\pntxtb (}{\pntxta )}}\pard\plain \ql \li0\ri0\widctlpar\aspalpha\aspnum\faauto\adjustright\rin0\lin0\itap0\pararsid11430898 \fs24\lang1033\langfe1033\cgrid\langnp1033\langfenp1033 {\f39\lang1027\langfe1033\langnp1027\insrsid11430898 SuperScript}{" + _
         "\f39\lang1027\langfe1033\super\langnp1027\insrsid11430898\charrsid11430898 super}{\f39\lang1027\langfe1033\super\langnp1027\insrsid11430898  }{\f39\lang1027\langfe1033\langnp1027\insrsid11430898  SubScript}{" + _
         "\f39\lang1027\langfe1033\sub\langnp1027\insrsid11430898\charrsid11430898 sub}{\f39\lang1027\langfe1033\sub\langnp1027\insrsid11430898 " + _
         "\par }{\f39\lang1027\langfe1033\langnp1027\insrsid11430898 " + _
         "\par Normal" + _
         "\par }{\b\f39\lang1027\langfe1033\langnp1027\insrsid11430898\charrsid11430898 Bold}{\f39\lang1027\langfe1033\langnp1027\insrsid11430898  }{\i\f39\lang1027\langfe1033\langnp1027\insrsid11430898\charrsid11430898 Italic}{" + _
         "\f39\lang1027\langfe1033\langnp1027\insrsid11430898  }{\f39\ul\lang1027\langfe1033\langnp1027\insrsid11430898\charrsid11430898 Underline}{\f39\lang1027\langfe1033\langnp1027\insrsid11430898\charrsid11430898 " + _
         "\par }}"
        
        DrawRichText(tChart1, RichText, New System.Drawing.Point(60, 100), New System.Drawing.Size(360, 90))
    End Sub 'New
    
    Private Sub DrawRichText(Chart As Steema.TeeChart.TChart, RichText As String, p As System.Drawing.Point, s As System.Drawing.Size)
        Dim richTextBox1 As New System.Windows.Forms.RichTextBox()
        richTextBox1.Location = p
        richTextBox1.Size = s
        richTextBox1.Rtf = RichText
        richTextBox1.BackColor = Chart.BackColor
        richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Chart.Controls.Add(richTextBox1)
    End Sub 'DrawRichText 
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
        Me.SuspendLayout()
        ' 
        ' textBox1
        ' 
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Text = "RichText controls (RTF) can be used to draw text with extended formatting."
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
        ' 
        ' tChart1.Header
        ' 
        Me.tChart1.Header.Lines = New String() {"RichText Drawing Example"}
        Me.tChart1.Name = "tChart1"
        ' 
        ' tChart1.Panel
        ' 
        ' 
        ' tChart1.Panel.Brush
        ' 
        Me.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb((CType((254), System.Byte)), (CType((224), System.Byte)), (CType((224), System.Byte)), (CType((224), System.Byte)))
        ' 
        ' tChart1.Walls
        ' 
        ' 
        ' tChart1.Walls.Back
        ' 
        ' 
        ' tChart1.Walls.Back.Brush
        ' 
        Me.tChart1.Walls.Back.Brush.Color = System.Drawing.Color.FromArgb((CType((254), System.Byte)), (CType((255), System.Byte)), (CType((255), System.Byte)), (CType((255), System.Byte)))
        Me.tChart1.Walls.Back.Transparent = False
        ' 
        ' tChart1.Walls.Bottom
        ' 
        ' 
        ' tChart1.Walls.Bottom.Pen
        ' 
        Me.tChart1.Walls.Bottom.Pen.Visible = False
        Me.tChart1.Walls.Bottom.Size = 5
        ' 
        ' tChart1.Walls.Left
        ' 
        ' 
        ' tChart1.Walls.Left.Pen
        ' 
        Me.tChart1.Walls.Left.Pen.Visible = False
        Me.tChart1.Walls.Left.Size = 5
        ' 
        ' Canvas_RichText
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(440, 317)
        Me.Name = "Canvas_RichText"
        Me.ResumeLayout(False)


    End Sub

#End Region
End Class 'RichText_Drawing