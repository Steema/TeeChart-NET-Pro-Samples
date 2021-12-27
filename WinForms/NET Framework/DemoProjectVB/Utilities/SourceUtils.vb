
Imports System
Imports System.IO
Imports System.Windows.Forms
Imports System.Drawing
Imports Microsoft.Win32
Imports System.Windows.Forms.Design



Public Class DirectorySelect
    Inherits FolderNameEditor
    Private m_fb As New FolderBrowser()
    Private m_description As String = "Select Folder"
    Private m_returnPath As String = String.Empty
    
    
    Public Sub New()
    End Sub 'New 
    
    Public Property Description() As String
        Get
            Return m_description
        End Get
        Set
            m_description = value
        End Set
    End Property 
    
    Public ReadOnly Property ReturnPath() As String
        Get
            Return m_returnPath
        End Get
    End Property
     
    Public Function RunDialog() As DialogResult
        m_fb.Description = m_description
        m_fb.StartLocation = FolderBrowserFolder.Desktop
        Return m_fb.ShowDialog()
    End Function 'RunDialog
    
    
    Public Function ShowDialog() As DialogResult
        Dim dr As DialogResult = RunDialog()
        If dr = DialogResult.OK Then
            m_returnPath = m_fb.DirectoryPath
        Else
            m_returnPath = String.Empty
        End If
        Return dr
    End Function 'ShowDialog
End Class 'DirectorySelect

'/ <summary>
'/ Loads and formats *.cs file 
'/ </summary>

Public Class SourceControl
    Inherits [Object]
    Private frtb As RichTextBox
    Private p, len As Integer
    Private txt As String
    Private fFormatText As Boolean
    
    
    Public Sub New(r As RichTextBox)
        Me.frtb = r
        Me.fFormatText = True
    End Sub 'New
    
    '/ <summary>
    '/ where to put formatted text ?
    '/ </summary>
    
    Public Property rtb() As RichTextBox
        Get
            Return frtb
        End Get
        Set
            frtb = value
        End Set
    End Property 
    
    Public Property FormatText() As Boolean
        Get
            Return fFormatText
        End Get
        Set
            fFormatText = value
        End Set
    End Property
     
    Private Function IsKeyWord(str As String) As Boolean

        Dim keywords() As String = {"Function", "End", "Private", "Dim", "If", "Then", "For", _
         "Each", "True", "False", "Imports", "Me", "Public", "Class", "Inherits", "As", "New", _
         "String", "Get", "Set", "ReadOnly", "Property", "Return", "Else", "Sub", "Region", _
         "Protected", "Overrides", "ByVal", "Boolean", "MyBase", "AddHandler", "CType", "Byte", _
         "Do", "Is", "WithEvents", "Structure", "Not", "Exit", "Try", "Catch", "ElseIf", "Finally", _
         "Handles", "Nothing", "While", "Double", "Integer", "String", "Long", "Float", "Static", _
         "To", "Default", "Checked", "Unchecked", "Case", "Select", "Loop", "Char", "In", "Next", _
         "Shor", "Namespace", "Using", "AddressOf", "Structure", "Interface", "Module", _
         "Enum", "Object", "Event", "Throw", "Overrides", "Goto", "Const", "Decimal", "Delegate"}

        Dim res As Boolean = False
        For Each st As String In keywords
            If st = str Then
                res = True
                Exit For
            End If
        Next st
        Return res
    End Function 'IsKeyWord
    
    
    Private Sub HighLightText(endstring As String)
        Dim sublen As Integer = endstring.Length
        frtb.SelectionStart = p - sublen
        While p <= len - sublen AndAlso Not txt.Substring(p, sublen).Equals(endstring)
            p += 1
        End While
        frtb.SelectionLength = p + sublen - frtb.SelectionStart
        frtb.SelectionColor = Color.Green
        frtb.SelectionLength = 0
        frtb.SelectionStart = 0
    End Sub 'HighLightText
    
    
    Private Function NextWordIsKeyword() As Boolean
        Dim res As Boolean = False
        
        While p < len
            If (Char.IsLetterOrDigit(txt.Chars(p))) Then
                Exit While
            ElseIf p < len - 1 AndAlso txt.Substring(p, 1).Equals("'") Then
                HighLightText(vbLf)
                'ElseIf p < len - 2 AndAlso txt.Substring(p, 2).Equals("/*") Then
                'HighLightText("*/")
            Else
                p += 1
            End If
        End While
        Dim p2 As Integer = p
        Dim Key As String
        While p < len AndAlso Char.IsLetterOrDigit(txt.Chars(p))
            p += 1
        End While
        If p > p2 Then
            Key = txt.Substring(p2, p - p2)
            res = IsKeyWord(Key)
            frtb.SelectionStart = p2
            frtb.SelectionLength = p - p2
            p += 1
        Else
            res = False
        End If
        Return res
    End Function 'NextWordIsKeyword
    
    
    Private Sub FormatSourceText()
        If Not (frtb Is Nothing) Then
            txt = frtb.Text
            len = frtb.Text.Length
            p = 0
            While p < len
                If NextWordIsKeyword() Then
                    frtb.SelectionColor = Color.Blue
                End If
            End While
            frtb.SelectionStart = 0
            frtb.SelectionLength = 0
        End If
    End Sub 'FormatSourceText
    
    
    '/ <summary>
    '/ Load and format filemane.cs file
    '/ </summary>
    '/ <param name="filename"></param>
    Public Sub LoadTextFromFile(filename As String)
        Dim fi As New FileInfo(filename)
        If fi.Exists AndAlso Not (frtb Is Nothing) Then
            frtb.Visible = False
            frtb.SuspendLayout()
            Try
                frtb.Clear()
                frtb.LoadFile(filename, RichTextBoxStreamType.PlainText)
                If fFormatText Then
                    FormatSourceText()
                End If
            Finally
                frtb.Visible = True
                frtb.ResumeLayout(True)
            End Try
        End If
    End Sub 'LoadTextFromFile
End Class 'SourceControl


Public Class Utils
    
    Private Sub New()
    End Sub 'New 
    Public Shared TeeChartNETKey As String = "Software\Steema Software\TeeChart.NET"
    Public Shared NetDemoKey As String = ".NET Demo"
    Public Shared TeeChartRoot As String = "HKEY_LOCAL_MACHINE"
    Public Shared TeeChartSubKey As String = "Software\Steema Software\TeeChart.NET"
    Public Shared TeeChartKeyName As String = (TeeChartRoot + ("\" + TeeChartSubKey))

    Public Shared Function DemoPath() As String
        Dim tmpStr As String = CType(Steema.TeeChart.Utils.Registry_GetValue(TeeChartKeyName, "DemoPath", "..\"), String)
        Return tmpStr.Replace("..\..\", "..\")
    End Function
    
    '/ <summary>
    '/ Restores source code directory from registry
    '/ </summary>
    '/ <returns></returns>
    Public Shared Function CodePath() As String

#If (DESIGN) Then
    #if (VS2005) Then
        Dim ProjectName As String = "TeeChart Examples2005_VB.vbproj"
    #Else'  Then
        Dim ProjectName As String = "TeeChart Examples2003_VB.vbproj"
    #End If
#Else 'Then
        Dim ProjectName As String = "TeeChart Examples.vbproj"
#End If

        Dim result As String = DemoPath()
        
        Dim fi As New FileInfo(result + ProjectName)
        If Not fi.Exists Then
            fi = New FileInfo(result + "..\" + ProjectName)
            If fi.Exists Then
                result = result + "..\"
            Else
                fi = New FileInfo(result + "..\..\" + ProjectName)
                If fi.Exists Then
                    result = result + "..\..\"
                End If
            End If
        End If 
        Return result
    End Function 'CodePath
    
    
    '/ <summary>
    '/ Stores source code directory to registry
    '/ </summary>
    '/ <param name="path"></param>
    Public Shared Sub WriteCodePath(path As String)
        Dim key As RegistryKey = Registry.CurrentUser.CreateSubKey(Utils.TeeChartNETKey)
        If Not (key Is Nothing) Then
            Dim rootPath As RegistryKey = key.CreateSubKey(Utils.NetDemoKey)
            rootPath.SetValue("Demo Path", path)
        End If
    End Sub 'WriteCodePath
End Class 'Utils