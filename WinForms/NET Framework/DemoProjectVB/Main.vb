Imports System
Imports System.Drawing
Imports System.Collections
Imports System.Collections.Specialized
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Reflection
Imports System.IO
Imports Steema.TeeChart

'/ <summary>
'/ Main Examples form.
'/ </summary>

Public Class MainForm
    Inherits System.Windows.Forms.Form
    Private WithEvents statusBar1 As System.Windows.Forms.StatusBar
    Private WithEvents tabControl1 As System.Windows.Forms.TabControl
    Private WithEvents treeView1 As System.Windows.Forms.TreeView
    Private WithEvents panel3 As System.Windows.Forms.Panel
    Private components As System.ComponentModel.IContainer
    Private WithEvents tabSearch As System.Windows.Forms.TabPage
    Private WithEvents panel4 As System.Windows.Forms.Panel
    Private WithEvents treeSearch As System.Windows.Forms.TreeView
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents comboBoxSearch As System.Windows.Forms.ComboBox
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents checkBoxFindAll As System.Windows.Forms.CheckBox
    Private WithEvents checkBoxFindSource As System.Windows.Forms.CheckBox
    Private WithEvents treeView2 As System.Windows.Forms.TreeView
    Private WithEvents textBox2 As System.Windows.Forms.TextBox
    Private WithEvents timer1 As System.Windows.Forms.Timer

    ' manually defined at runtime
    Private DeltaFocus As Single = 0.02F
    Private Shared OldSourceFile As String
    Private Shared TheForm As Form
    Private Shared OldFormType As Type
    Private tabPageNew As System.Windows.Forms.TabPage
    Private tabPageAll As System.Windows.Forms.TabPage
    Private contextMenu1 As System.Windows.Forms.ContextMenu
    Private WithEvents menuItem1 As System.Windows.Forms.MenuItem
    Private statusBarPanel1 As System.Windows.Forms.StatusBarPanel
    Private splitter1 As System.Windows.Forms.Splitter
    Private imageList1 As System.Windows.Forms.ImageList
    Private WithEvents buttonSearch As System.Windows.Forms.Button
    Private WithEvents textBox1 As System.Windows.Forms.TextBox
    Private tChart2 As Steema.TeeChart.TChart
    Private WithEvents tbNodePath As System.Windows.Forms.TextBox
    Private WithEvents butGo As System.Windows.Forms.Button
    Private panelNavBar As System.Windows.Forms.Panel
    Private panelExample As System.Windows.Forms.Panel
    Private WithEvents tabControlExample As System.Windows.Forms.TabControl
    Private tabExample As System.Windows.Forms.TabPage
    Private tabSource As System.Windows.Forms.TabPage
    Private buttonConfig As System.Windows.Forms.Button
    Private richTextBox1 As System.Windows.Forms.RichTextBox
    Private tabWeb As System.Windows.Forms.TabPage
    Private WithEvents buttonF As System.Windows.Forms.Button
    Private WithEvents buttonB As System.Windows.Forms.Button
    Private WithEvents button2 As System.Windows.Forms.Button
    Private WithEvents button1 As System.Windows.Forms.Button
    Private menuItem5 As MenuItem
    Private axWebBrowser As AxSHDocVw.AxWebBrowser
    Private WithEvents panel1 As System.Windows.Forms.Panel
    Private WithEvents panel2 As System.Windows.Forms.Panel
    Private WithEvents panel6 As System.Windows.Forms.Panel
    Private WithEvents panel5 As System.Windows.Forms.Panel
    Private Shared SourceFile As String
    Private Structure DemoFormInfo
        Public formtype As Type
        Public unitname As String
    End Structure 'DemoFormInfo
    Public Sub New()
        '
        ' Required for Windows Form Designer support
        InitializeComponent()
        'Me.tabControl1.TabPages.Remove(Me.tabPageNew) ' well, it's first NET version so ...
        tabControl1.SelectedTab = Me.tabPageNew
        ' load data from tree
        LoadTreeFromStrings(treeView1, textBox1.Lines)
        LoadTreeFromStrings(treeView2, textBox2.Lines)
        treeView1.HotTracking = True
        'ICanvasType = CanvasType.GDIPlus
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

    '/ <summary>
    '/ Finds source code *.vb file
    '/ </summary>
    Private Function CodeFile(ByVal node As TreeNode) As String
        If node Is Nothing Then
            Return ""
        Else
            Dim fn As String = CType(node.Tag, DemoFormInfo).unitname
            If fn <> "" Then
                fn += ".vb"
            End If
            Return fn
        End If
    End Function 'CodeFile


    Private Function FindType(ByVal t As Type) As Type
        Dim tp As Type = Nothing
        ' find match, only one assembly, so not a problem
        Dim a As System.Reflection.Assembly = System.Reflection.Assembly.GetCallingAssembly()
        Dim types As Type() = a.GetExportedTypes()
        Dim i As Integer
        For i = 0 To types.Length - 1
            If types(i).Equals(t) Then
                tp = types(i)
                Exit For
            End If
        Next i
        Return tp
    End Function 'FindType


    '/ <summary>
    '/ Shows specific demo form
    '/ </summary>
    Private Sub ShowForm(ByVal tree As TreeView)
        If Not (tree.SelectedNode Is Nothing) Then
            If Not (CType(tree.SelectedNode.Tag, DemoFormInfo).formtype Is Nothing) Then
                Dim t As Type = FindType(CType(tree.SelectedNode.Tag, DemoFormInfo).formtype)
                If Not (t Is OldFormType) Then
                    Try
                        If Not (TheForm Is Nothing) Then
                            TheForm.Dispose()
                        End If
                        ' find and create form
                        TheForm = CType(System.Activator.CreateInstance(t), Form)
                        OldFormType = t
                        Steema.TeeChart.Editors.EditorUtils.InsertForm(TheForm, tabExample)
                    Catch ee As Exception
                        ' missing form, set red bullet icon
                        MessageBox.Show(ee.Message)
                        tree.SelectedNode.ImageIndex = 3
                        tree.SelectedNode.SelectedImageIndex = 3
                    End Try
                End If
            ElseIf tree.SelectedNode.Nodes.Count = 0 Then
                ' missing form, set red bullet icon
                tree.SelectedNode.ImageIndex = 3
                tree.SelectedNode.SelectedImageIndex = 3
            End If

            statusBar1.Panels(0).Text = tree.SelectedNode.Text
            tbNodePath.Text = tree.SelectedNode.FullPath
        Else
            statusBar1.Panels(0).Text = ""
            tbNodePath.Text = ""
        End If
    End Sub 'ShowForm

#Region "Setup Tree"

    '/ <summary>
    ' Loads treeView structure from a string array
    '/ </summary>
    Private Sub LoadTreeFromStrings(ByVal tree As System.Windows.Forms.TreeView, ByVal strings() As String)
        tree.BeginUpdate()
        Try
            Dim tmpstr, NodeText, ClassName, UnitName As String
            Dim st() As String
            Dim alevel As Integer
            Dim FormInfo As DemoFormInfo

            tree.Nodes.Clear()
            Dim OwnerNode As DemoNode = Nothing
            Dim tmpNode, NextNode As DemoNode
            Dim i As Integer
            For i = 0 To strings.Length - 1
                NodeText = ""
                ' first get level
                alevel = 0
                While strings(i).Chars(alevel) = " "
                    alevel += 1
                End While
                tmpstr = strings(i).Substring(alevel)
                ' split info, get caption, form class name + unit name
                st = tmpstr.Split(","c)
                NodeText = st(0)
                If (st.Length > 1) Then
                    ClassName = "Steema.TeeChart.Samples." + st(1)
                Else
                    ClassName = ""
                End If

                If (st.Length > 2) Then
                    UnitName = st(2)
                Else
                    UnitName = ""
                End If

                ' use TreeNode Tag property to add form info
                FormInfo = New DemoFormInfo
                FormInfo.unitname = UnitName

                If ClassName = "" Then
                    FormInfo.formtype = Nothing
                Else
                    FormInfo.formtype = System.Reflection.Assembly.GetCallingAssembly().GetType(ClassName)
                End If

                ' finally, add node to treeView
                tmpNode = New DemoNode(NodeText)
                If OwnerNode Is Nothing OrElse alevel = 0 Then
                    tree.Nodes.Add(tmpNode)
                ElseIf OwnerNode.Level = alevel Then
                    OwnerNode.Parent.Nodes.Add(tmpNode)
                ElseIf OwnerNode.Level = alevel - 1 Then
                    OwnerNode.Nodes.Add(tmpNode)
                ElseIf OwnerNode.Level > alevel Then
                    NextNode = CType(OwnerNode.Parent, DemoNode)
                    While NextNode.Level > alevel
                        NextNode = CType(NextNode.Parent, DemoNode)
                    End While
                    NextNode.Parent.Nodes.Add(tmpNode)
                End If
                tmpNode.AbsoluteIndex = i
                tmpNode.Tag = FormInfo
                OwnerNode = tmpNode
            Next i
            ' now setup images
            SetTreeNodesImage(tree)
            If tree.Nodes.Count > 0 Then
                tree.Nodes(0).Expand()
            End If
        Finally
            tree.EndUpdate()
        End Try
    End Sub 'LoadTreeFromStrings


    Private Sub SetImagesRecursively(ByVal n As TreeNode)
        n.ImageIndex = IIf(n.Nodes.Count = 0, 2, 0)
        n.SelectedImageIndex = n.ImageIndex
        For Each ch As TreeNode In n.Nodes
            SetImagesRecursively(ch)
        Next ch
    End Sub 'SetImagesRecursively

    Private Sub SetTreeNodesImage(ByVal tree As TreeView)
        tree.BeginUpdate()
        Try
            Dim nodes As TreeNodeCollection = tree.Nodes
            For Each n As TreeNode In nodes
                SetImagesRecursively(n)
            Next n
        Finally
            tree.EndUpdate()
        End Try
    End Sub 'SetTreeNodesImage
#End Region

    Private Function theTree() As TreeView
        If tabControl1.SelectedTab Is tabPageNew Then
            Return treeView1
        ElseIf tabControl1.SelectedTab Is tabPageAll Then
            Return treeView2
        Else
            Return treeSearch
        End If
    End Function 'theTree


    Private Sub OpenWebPage(ByVal location As String)
        Dim rr As Object = Nothing
        Dim dd As Object = Nothing
        Dim vv As Object = Nothing
        Dim gg As Object = Nothing

        axWebBrowser.Navigate(location, rr, dd, vv, gg)
    End Sub 'OpenWebPage

#Region "Tree Search Algorithm"

    Private Function FoundTextIn(ByVal s As String, ByVal Words() As String, ByVal FindAllWords As Boolean) As Boolean
        ' covert to UPPERCASE
        s = s.ToUpper()
        If FindAllWords Then
            Dim t As Integer
            For t = 0 To Words.Length - 1
                If s.IndexOf(Words(t), 0) = -1 Then
                    Return False
                End If
            Next t
            Return True
        Else
            Dim t As Integer
            For t = 0 To Words.Length - 1
                If s.IndexOf(Words(t), 0) <> -1 Then
                    Return True
                End If
            Next t
            Return False
        End If
    End Function 'FoundTextIn


    Private Sub AddResult(ByVal n As DemoNode)
        Dim Added As New DemoNode(n.Text)
        Added.Tag = n.Tag
        Added.AbsoluteIndex = treeSearch.GetNodeCount(False)
        treeSearch.Nodes.Add(Added)
    End Sub 'AddResult


    Private Function SearchInLines(ByVal lines() As String, ByVal Words() As String, ByVal FindAllWords As Boolean) As Boolean
        Dim t As Integer
        For t = 0 To lines.Length - 1
            If FoundTextIn(lines(t), Words, FindAllWords) Then
                Return True
            End If
        Next t
        Return False
    End Function 'SearchInLines


    Private Function SearchInTextBox(ByVal txtbox As TextBox, ByVal Words() As String, ByVal FindAllWords As Boolean) As Boolean
        If txtbox.Lines.Length > 0 Then
            Return SearchInLines(txtbox.Lines, Words, FindAllWords)
        Else
            Return FoundTextIn(txtbox.Text, Words, FindAllWords)
        End If
    End Function 'SearchInTextBox

    Private Function SearchInForm(ByVal form As Form, ByVal Words() As String, ByVal FindAllWords As Boolean) As Boolean
        Dim res As Boolean = False
        Dim t As Integer
        For t = 0 To form.Controls.Count - 1
            If TypeOf form.Controls(t) Is System.Windows.Forms.TextBox Then
                res = SearchInTextBox(form.Controls(t), Words, FindAllWords)
                If res Then
                    Exit For
                End If
            End If
        Next t
        Return res
    End Function 'SearchInForm


    Private Function FoundTextInNode(ByVal n As DemoNode, ByVal Words() As String, ByVal FindAllWords As Boolean, ByVal formNames As StringCollection) As Boolean
        Dim res As Boolean = False
        Dim tmp As DemoFormInfo = CType(n.Tag, DemoFormInfo)
        If Not (tmp.formtype Is Nothing) OrElse Not (tmp.unitname Is Nothing) Then
            ' First of all, search in tree node Text...
            res = FoundTextIn(n.Text, Words, FindAllWords)

            If Not res Then
                Dim t As Type = FindType(CType(n.Tag, DemoFormInfo).formtype)
                If Not (t Is Nothing) Then
                    Dim tmpForm As Form = CType(System.Activator.CreateInstance(t), Form)
                    Try
                        ' Avoid processing same form twice...
                        If formNames.IndexOf(tmp.formtype.ToString()) <> -1 Then
                            Return res
                        End If
                        formNames.Add(tmp.formtype.ToString())

                        ' Now do search ...
                        If TypeOf tmpForm Is BaseForm Then
                            res = SearchInTextBox(DirectCast(tmpForm, BaseForm).textBox1, Words, FindAllWords)
                        End If
                        res = SearchInForm(tmpForm, Words, FindAllWords)
                    Finally
                        tmpForm.Dispose()
                    End Try
                End If
            End If

            ' Load form source code and search...
            If Not res Then
                If Not (tmp.unitname Is Nothing) AndAlso checkBoxFindSource.Checked Then
                    Dim fn As String = Utils.CodePath() + tmp.unitname + ".cs"
                    Dim fi As New FileInfo(fn)
                    If fi.Exists Then
                        Dim r As StreamReader = fi.OpenText()
                        Try
                            Dim textLine As String
                            textLine = r.ReadLine()
                            While Not (textLine = Nothing)
                                res = FoundTextIn(textLine, Words, FindAllWords)
                                If res Then
                                    Exit While
                                End If
                                textLine = r.ReadLine()
                            End While
                        Finally
                            r.Close()
                        End Try
                    End If
                End If
            End If
        End If
        Return res
    End Function 'FoundTextInNode


    Private Sub DoSearchTree(ByVal tree As TreeView, ByVal pb As ProgressBar, ByVal Offset As Integer, ByVal Words() As String, ByVal FindAllWords As Boolean, ByVal formNames As StringCollection)
        Dim tmp As Integer = 0
        Dim n As DemoNode = Nothing
        Dim NodeCount As Integer = tree.GetNodeCount(True)
        If NodeCount > 0 Then
            n = CType(tree.Nodes(0), DemoNode)
        End If
        Dim t As Integer
        For t = 0 To NodeCount - 1
            tmp = Offset + t * 50 / NodeCount
            If pb.Value <> tmp Then
                pb.Value = tmp
            End If
            If FoundTextInNode(n, Words, FindAllWords, formNames) Then
                AddResult(n)
            End If
            t += 1
            n = CType(n.MoveForward(), DemoNode)
        Next t
    End Sub 'DoSearchTree


    Private Sub DoSearch()
        treeSearch.BeginUpdate()
    System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
    Try
            treeSearch.Nodes.Clear()
            If Not (TheForm Is Nothing) Then
                TheForm.Dispose()
            End If
            Dim SearchText As String = comboBoxSearch.Text

            If SearchText <> "" Then
                ' new text item ? Then add it to combobox items
                If comboBoxSearch.Items.IndexOf(SearchText) < 0 Then
                    comboBoxSearch.Items.Add(SearchText)
                End If
                ' first, convert SearchText to UPPERCASE
                SearchText = SearchText.ToUpper()
                ' split words
                Dim Words As String() = SearchText.Split(" "c)
                Dim pb As ProgressBar = New System.Windows.Forms.ProgressBar

                ' used to store all already seached forms (to prevent duplicate search
                Dim formNames As New StringCollection
                Try
                    ' setup ProgressBar properties
                    pb.Location = New System.Drawing.Point(0, 3)
                    pb.Width = Math.Max(200, Me.tabControl1.Width)
                    pb.Minimum = 0
                    pb.Maximum = 100
                    pb.Value = 0
                    statusBar1.SuspendLayout()
                    statusBar1.Controls.Add(pb)
                    statusBar1.ResumeLayout(True)

                    ' now do complete search
                    DoSearchTree(treeView1, pb, 0, Words, checkBoxFindAll.Checked, formNames)
                    DoSearchTree(treeView2, pb, 50, Words, checkBoxFindAll.Checked, formNames)
                    pb.Value = 100
                Finally
                    statusBar1.SuspendLayout()
                    statusBar1.Controls.Remove(pb)
                    pb.Dispose()
                    formNames.Clear()
                    formNames = Nothing
                    statusBar1.ResumeLayout(True)
                End Try
            End If
        Finally
            treeSearch.EndUpdate()
      System.Windows.Forms.Cursor.Current = Cursors.Default
    End Try
    End Sub 'DoSearch
#End Region

#Region "Windows Form Designer generated code"
    Private Sub InitializeComponent()

        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.panel1 = New System.Windows.Forms.Panel
        Me.panel5 = New System.Windows.Forms.Panel
        Me.panel6 = New System.Windows.Forms.Panel
        Me.panel2 = New System.Windows.Forms.Panel
        Me.statusBar1 = New System.Windows.Forms.StatusBar
        Me.contextMenu1 = New System.Windows.Forms.ContextMenu
        Me.menuItem1 = New System.Windows.Forms.MenuItem
        Me.menuItem5 = New System.Windows.Forms.MenuItem
        Me.statusBarPanel1 = New System.Windows.Forms.StatusBarPanel
        Me.tabControl1 = New System.Windows.Forms.TabControl
        Me.tabPageNew = New System.Windows.Forms.TabPage
        Me.textBox2 = New System.Windows.Forms.TextBox
        Me.textBox1 = New System.Windows.Forms.TextBox
        Me.treeView1 = New System.Windows.Forms.TreeView
        Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.tabSearch = New System.Windows.Forms.TabPage
        Me.treeSearch = New System.Windows.Forms.TreeView
        Me.panel4 = New System.Windows.Forms.Panel
        Me.buttonSearch = New System.Windows.Forms.Button
        Me.checkBoxFindSource = New System.Windows.Forms.CheckBox
        Me.checkBoxFindAll = New System.Windows.Forms.CheckBox
        Me.label2 = New System.Windows.Forms.Label
        Me.comboBoxSearch = New System.Windows.Forms.ComboBox
        Me.label1 = New System.Windows.Forms.Label
        Me.tabPageAll = New System.Windows.Forms.TabPage
        Me.treeView2 = New System.Windows.Forms.TreeView
        Me.panel3 = New System.Windows.Forms.Panel
        Me.panelExample = New System.Windows.Forms.Panel
        Me.tabControlExample = New System.Windows.Forms.TabControl
        Me.tabExample = New System.Windows.Forms.TabPage
        Me.tabSource = New System.Windows.Forms.TabPage
        Me.buttonConfig = New System.Windows.Forms.Button
        Me.richTextBox1 = New System.Windows.Forms.RichTextBox
        Me.tabWeb = New System.Windows.Forms.TabPage
        Me.axWebBrowser = New AxSHDocVw.AxWebBrowser
        Me.panelNavBar = New System.Windows.Forms.Panel
        Me.button1 = New System.Windows.Forms.Button
        Me.button2 = New System.Windows.Forms.Button
        Me.buttonF = New System.Windows.Forms.Button
        Me.buttonB = New System.Windows.Forms.Button
        Me.butGo = New System.Windows.Forms.Button
        Me.tbNodePath = New System.Windows.Forms.TextBox
        Me.timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.splitter1 = New System.Windows.Forms.Splitter
        Me.panel1.SuspendLayout()
        CType(Me.statusBarPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabControl1.SuspendLayout()
        Me.tabPageNew.SuspendLayout()
        Me.tabSearch.SuspendLayout()
        Me.panel4.SuspendLayout()
        Me.tabPageAll.SuspendLayout()
        Me.panel3.SuspendLayout()
        Me.panelExample.SuspendLayout()
        Me.tabControlExample.SuspendLayout()
        Me.tabSource.SuspendLayout()
        Me.tabWeb.SuspendLayout()
        CType(Me.axWebBrowser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelNavBar.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' panel1
        ' 
        Me.panel1.BackColor = System.Drawing.Color.White
        Me.panel1.BackgroundImage = CType(resources.GetObject("panel1.BackgroundImage"), System.Drawing.Image)
        Me.panel1.Controls.Add(Me.panel5)
        Me.panel1.Controls.Add(Me.panel6)
        Me.panel1.Controls.Add(Me.panel2)
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel1.Location = New System.Drawing.Point(0, 0)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(964, 81)
        Me.panel1.TabIndex = 0
        AddHandler panel1.Paint, AddressOf Me.panel1_Paint
        ' 
        ' panel5
        ' 
        Me.panel5.BackgroundImage = CType(resources.GetObject("panel5.BackgroundImage"), System.Drawing.Image)
        Me.panel5.Dock = System.Windows.Forms.DockStyle.Right
        Me.panel5.Location = New System.Drawing.Point(791, 0)
        Me.panel5.Name = "panel5"
        Me.panel5.Size = New System.Drawing.Size(173, 81)
        Me.panel5.TabIndex = 10
        ' 
        ' panel6
        ' 
        Me.panel6.BackgroundImage = CType(resources.GetObject("panel6.BackgroundImage"), System.Drawing.Image)
        Me.panel6.Dock = System.Windows.Forms.DockStyle.Left
        Me.panel6.Location = New System.Drawing.Point(646, 0)
        Me.panel6.Name = "panel6"
        Me.panel6.Size = New System.Drawing.Size(80, 81)
        Me.panel6.TabIndex = 11
        ' 
        ' panel2
        ' 
        Me.panel2.BackgroundImage = CType(resources.GetObject("panel2.BackgroundImage"), System.Drawing.Image)
        Me.panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.panel2.Location = New System.Drawing.Point(0, 0)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(646, 81)
        Me.panel2.TabIndex = 9
        ' 
        ' statusBar1
        ' 
        Me.statusBar1.ContextMenu = Me.contextMenu1
        Me.statusBar1.Location = New System.Drawing.Point(0, 690)
        Me.statusBar1.Name = "statusBar1"
        Me.statusBar1.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.statusBarPanel1})
        Me.statusBar1.ShowPanels = True
        Me.statusBar1.Size = New System.Drawing.Size(964, 24)
        Me.statusBar1.TabIndex = 1
        ' 
        ' contextMenu1
        ' 
        Me.contextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem1, Me.menuItem5})
        ' 
        ' menuItem1
        ' 
        Me.menuItem1.Index = 0
        Me.menuItem1.Text = "Show All"
        AddHandler menuItem1.Click, AddressOf Me.menuItem1_Click
        ' 
        ' menuItem5
        ' 
        Me.menuItem5.Index = 1
        Me.menuItem5.Text = "-"
        ' 
        ' statusBarPanel1
        ' 
        Me.statusBarPanel1.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring
#If (VS2005) Then
        Me.statusBarPanel1.Name = "statusBarPanel1"
#End If
        Me.statusBarPanel1.Text = "statusBarPanel1"
        Me.statusBarPanel1.Width = 947
        ' 
        ' tabControl1
        ' 
        Me.tabControl1.Controls.Add(Me.tabPageNew)
        Me.tabControl1.Controls.Add(Me.tabSearch)
        Me.tabControl1.Controls.Add(Me.tabPageAll)
        Me.tabControl1.Dock = System.Windows.Forms.DockStyle.Left
        Me.tabControl1.HotTrack = True
        Me.tabControl1.Location = New System.Drawing.Point(0, 81)
        Me.tabControl1.Name = "tabControl1"
        Me.tabControl1.SelectedIndex = 0
        Me.tabControl1.Size = New System.Drawing.Size(240, 609)
        Me.tabControl1.TabIndex = 0
        AddHandler tabControl1.SelectedIndexChanged, AddressOf Me.tabControl1_SelectedIndexChanged
        ' 
        ' tabPageNew
        ' 
        Me.tabPageNew.Controls.Add(Me.textBox2)
        Me.tabPageNew.Controls.Add(Me.textBox1)
        Me.tabPageNew.Controls.Add(Me.treeView1)
        Me.tabPageNew.ImageIndex = 3
        Me.tabPageNew.Location = New System.Drawing.Point(4, 22)
        Me.tabPageNew.Name = "tabPageNew"
        Me.tabPageNew.Size = New System.Drawing.Size(232, 583)
        Me.tabPageNew.TabIndex = 0
        Me.tabPageNew.Text = "What\'s New?"
        ' 
        ' textBox2
        ' 
        Me.textBox2.Location = New System.Drawing.Point(22, 36)
        Me.textBox2.Multiline = True
        Me.textBox2.Name = "textBox2"
        Me.textBox2.Size = New System.Drawing.Size(176, 196)
        Me.textBox2.TabIndex = 1
        Me.textBox2.Text = resources.GetString("textBox2.Text")
        Me.textBox2.Visible = False
        Me.textBox2.WordWrap = False
        ' 
        ' textBox1
        ' 
        Me.textBox1.Location = New System.Drawing.Point(24, 256)
        Me.textBox1.Multiline = True
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(176, 144)
        Me.textBox1.TabIndex = 3
        Me.textBox1.Text = resources.GetString("textBox1.Text")
        Me.textBox1.Visible = False
        Me.textBox1.WordWrap = False
        AddHandler textBox1.TextChanged, AddressOf Me.textBox1_TextChanged
        ' 
        ' treeView1
        ' 
        Me.treeView1.CausesValidation = False
        Me.treeView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.treeView1.FullRowSelect = True
        Me.treeView1.ImageIndex = 0
        Me.treeView1.ImageList = Me.imageList1
        Me.treeView1.Location = New System.Drawing.Point(0, 0)
        Me.treeView1.Name = "treeView1"
        Me.treeView1.SelectedImageIndex = 0
        Me.treeView1.Size = New System.Drawing.Size(232, 583)
        Me.treeView1.TabIndex = 0
        AddHandler treeView1.BeforeExpand, AddressOf Me.treeView1_BeforeExpand
        AddHandler treeView1.BeforeCollapse, AddressOf Me.treeView1_BeforeCollapse
        AddHandler treeView1.AfterSelect, AddressOf Me.treeView1_AfterSelect
        ' 
        ' imageList1
        ' 
        Me.imageList1.ImageStream = CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
#If (VS2005) Then
        Me.imageList1.Images.SetKeyName(0, "")
        Me.imageList1.Images.SetKeyName(1, "")
        Me.imageList1.Images.SetKeyName(2, "")
        Me.imageList1.Images.SetKeyName(3, "")
#End If
        ' 
        ' tabSearch
        ' 
        Me.tabSearch.Controls.Add(Me.treeSearch)
        Me.tabSearch.Controls.Add(Me.panel4)
        Me.tabSearch.Location = New System.Drawing.Point(4, 22)
        Me.tabSearch.Name = "tabSearch"
        Me.tabSearch.Size = New System.Drawing.Size(232, 583)
        Me.tabSearch.TabIndex = 2
        Me.tabSearch.Text = "Search"
        ' 
        ' treeSearch
        ' 
        Me.treeSearch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.treeSearch.Location = New System.Drawing.Point(0, 112)
        Me.treeSearch.Name = "treeSearch"
        Me.treeSearch.Size = New System.Drawing.Size(232, 471)
        Me.treeSearch.TabIndex = 0
        AddHandler treeSearch.AfterSelect, AddressOf Me.treeView1_AfterSelect
        ' 
        ' panel4
        ' 
        Me.panel4.BackColor = System.Drawing.SystemColors.Control
        Me.panel4.Controls.Add(Me.buttonSearch)
        Me.panel4.Controls.Add(Me.checkBoxFindSource)
        Me.panel4.Controls.Add(Me.checkBoxFindAll)
        Me.panel4.Controls.Add(Me.label2)
        Me.panel4.Controls.Add(Me.comboBoxSearch)
        Me.panel4.Controls.Add(Me.label1)
        Me.panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel4.Location = New System.Drawing.Point(0, 0)
        Me.panel4.Name = "panel4"
        Me.panel4.Size = New System.Drawing.Size(232, 112)
        Me.panel4.TabIndex = 0
        ' 
        ' buttonSearch
        ' 
        Me.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonSearch.Image = CType(resources.GetObject("buttonSearch.Image"), System.Drawing.Image)
        Me.buttonSearch.Location = New System.Drawing.Point(205, 25)
        Me.buttonSearch.Name = "buttonSearch"
        Me.buttonSearch.Size = New System.Drawing.Size(27, 23)
        Me.buttonSearch.TabIndex = 6
        AddHandler buttonSearch.Click, AddressOf Me.buttonSearch_Click_1
        ' 
        ' checkBoxFindSource
        ' 
        Me.checkBoxFindSource.Checked = True
        Me.checkBoxFindSource.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBoxFindSource.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBoxFindSource.Location = New System.Drawing.Point(16, 90)
        Me.checkBoxFindSource.Name = "checkBoxFindSource"
        Me.checkBoxFindSource.Size = New System.Drawing.Size(219, 16)
        Me.checkBoxFindSource.TabIndex = 0
        Me.checkBoxFindSource.Text = "&Look in source code"
        ' 
        ' checkBoxFindAll
        ' 
        Me.checkBoxFindAll.Checked = True
        Me.checkBoxFindAll.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBoxFindAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBoxFindAll.Location = New System.Drawing.Point(16, 71)
        Me.checkBoxFindAll.Name = "checkBoxFindAll"
        Me.checkBoxFindAll.Size = New System.Drawing.Size(219, 16)
        Me.checkBoxFindAll.TabIndex = 5
        Me.checkBoxFindAll.Text = "Find &all words (AND)"
        ' 
        ' label2
        ' 
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(8, 54)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(87, 13)
        Me.label2.TabIndex = 4
        Me.label2.Text = "Search options : "
        ' 
        ' comboBoxSearch
        ' 
        Me.comboBoxSearch.Location = New System.Drawing.Point(8, 26)
        Me.comboBoxSearch.Name = "comboBoxSearch"
        Me.comboBoxSearch.Size = New System.Drawing.Size(193, 21)
        Me.comboBoxSearch.TabIndex = 2
        Me.comboBoxSearch.Text = "Gradient Text"
        AddHandler comboBoxSearch.KeyDown, AddressOf Me.comboBoxSearch_KeyDown
        AddHandler comboBoxSearch.TextChanged, AddressOf Me.comboBoxSearch_TextChanged
        ' 
        ' label1
        ' 
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(8, 7)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(113, 13)
        Me.label1.TabIndex = 1
        Me.label1.Text = "&Enter words to search:"
        ' 
        ' tabPageAll
        ' 
        Me.tabPageAll.Controls.Add(Me.treeView2)
        Me.tabPageAll.Location = New System.Drawing.Point(4, 22)
        Me.tabPageAll.Name = "tabPageAll"
        Me.tabPageAll.Size = New System.Drawing.Size(232, 583)
        Me.tabPageAll.TabIndex = 1
        Me.tabPageAll.Text = "All Features"
        ' 
        ' treeView2
        ' 
        Me.treeView2.CausesValidation = False
        Me.treeView2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.treeView2.ImageIndex = 0
        Me.treeView2.ImageList = Me.imageList1
        Me.treeView2.Location = New System.Drawing.Point(0, 0)
        Me.treeView2.Name = "treeView2"
        Me.treeView2.SelectedImageIndex = 0
        Me.treeView2.Size = New System.Drawing.Size(232, 583)
        Me.treeView2.TabIndex = 1
        AddHandler treeView2.BeforeExpand, AddressOf Me.treeView1_BeforeExpand
        AddHandler treeView2.BeforeCollapse, AddressOf Me.treeView1_BeforeCollapse
        AddHandler treeView2.AfterSelect, AddressOf Me.treeView1_AfterSelect
        ' 
        ' panel3
        ' 
        Me.panel3.Controls.Add(Me.panelExample)
        Me.panel3.Controls.Add(Me.panelNavBar)
        Me.panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel3.Location = New System.Drawing.Point(240, 81)
        Me.panel3.Name = "panel3"
        Me.panel3.Size = New System.Drawing.Size(724, 609)
        Me.panel3.TabIndex = 4
        ' 
        ' panelExample
        ' 
        Me.panelExample.BackColor = System.Drawing.Color.WhiteSmoke
        Me.panelExample.Controls.Add(Me.tabControlExample)
        Me.panelExample.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelExample.Location = New System.Drawing.Point(0, 56)
        Me.panelExample.Name = "panelExample"
        Me.panelExample.Size = New System.Drawing.Size(724, 553)
        Me.panelExample.TabIndex = 2
        ' 
        ' tabControlExample
        ' 
        Me.tabControlExample.Alignment = System.Windows.Forms.TabAlignment.Bottom
        Me.tabControlExample.Controls.Add(Me.tabExample)
        Me.tabControlExample.Controls.Add(Me.tabSource)
        Me.tabControlExample.Controls.Add(Me.tabWeb)
        Me.tabControlExample.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabControlExample.HotTrack = True
        Me.tabControlExample.Location = New System.Drawing.Point(0, 0)
        Me.tabControlExample.Name = "tabControlExample"
        Me.tabControlExample.SelectedIndex = 0
        Me.tabControlExample.Size = New System.Drawing.Size(724, 553)
        Me.tabControlExample.TabIndex = 1
        AddHandler tabControlExample.SelectedIndexChanged, AddressOf Me.tabControlExample_SelectedIndexChanged
        ' 
        ' tabExample
        ' 
        Me.tabExample.BackColor = System.Drawing.Color.White
        Me.tabExample.Location = New System.Drawing.Point(4, 4)
        Me.tabExample.Name = "tabExample"
        Me.tabExample.Size = New System.Drawing.Size(716, 527)
        Me.tabExample.TabIndex = 0
        Me.tabExample.Text = "Example"
        ' 
        ' tabSource
        ' 
        Me.tabSource.Controls.Add(Me.buttonConfig)
        Me.tabSource.Controls.Add(Me.richTextBox1)
        Me.tabSource.Location = New System.Drawing.Point(4, 4)
        Me.tabSource.Name = "tabSource"
        Me.tabSource.Size = New System.Drawing.Size(716, 527)
        Me.tabSource.TabIndex = 2
        Me.tabSource.Text = "Source"
        Me.tabSource.Visible = False
        ' 
        ' buttonConfig
        ' 
        Me.buttonConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonConfig.Location = New System.Drawing.Point(18, 19)
        Me.buttonConfig.Name = "buttonConfig"
        Me.buttonConfig.Size = New System.Drawing.Size(110, 23)
        Me.buttonConfig.TabIndex = 1
        Me.buttonConfig.Text = "&Configure..."
        ' 
        ' richTextBox1
        ' 
        Me.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.richTextBox1.Font = New System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
        Me.richTextBox1.Location = New System.Drawing.Point(0, 0)
        Me.richTextBox1.Name = "richTextBox1"
        Me.richTextBox1.[ReadOnly] = True
        Me.richTextBox1.Size = New System.Drawing.Size(716, 527)
        Me.richTextBox1.TabIndex = 0
        Me.richTextBox1.Text = ""
        Me.richTextBox1.WordWrap = False

        ' 
        ' tabWeb
        ' 
        Me.tabWeb.Controls.Add(Me.axWebBrowser)
        Me.tabWeb.Location = New System.Drawing.Point(4, 4)
        Me.tabWeb.Name = "tabWeb"
        Me.tabWeb.Size = New System.Drawing.Size(716, 527)
        Me.tabWeb.TabIndex = 1
        Me.tabWeb.Text = "Web"
        Me.tabWeb.Visible = False
        ' 
        ' axWebBrowser
        ' 
        Me.axWebBrowser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.axWebBrowser.Enabled = True
        Me.axWebBrowser.Location = New System.Drawing.Point(0, 0)
        Me.axWebBrowser.OcxState = CType(resources.GetObject("axWebBrowser.OcxState"), System.Windows.Forms.AxHost.State)
        Me.axWebBrowser.Size = New System.Drawing.Size(716, 527)
        Me.axWebBrowser.TabIndex = 0
        ' 
        ' panelNavBar
        ' 
        Me.panelNavBar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.panelNavBar.Controls.Add(Me.button1)
        Me.panelNavBar.Controls.Add(Me.button2)
        Me.panelNavBar.Controls.Add(Me.buttonF)
        Me.panelNavBar.Controls.Add(Me.buttonB)
        Me.panelNavBar.Controls.Add(Me.butGo)
        Me.panelNavBar.Controls.Add(Me.tbNodePath)
        Me.panelNavBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelNavBar.Location = New System.Drawing.Point(0, 0)
        Me.panelNavBar.Name = "panelNavBar"
        Me.panelNavBar.Size = New System.Drawing.Size(724, 56)
        Me.panelNavBar.TabIndex = 1
        ' 
        ' button1
        ' 
        Me.button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.Location = New System.Drawing.Point(644, 3)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(75, 20)
        Me.button1.TabIndex = 17
        Me.button1.Text = "&Close"
        AddHandler button1.Click, AddressOf Me.button1_Click
        ' 
        ' button2
        ' 
        Me.button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button2.Location = New System.Drawing.Point(565, 3)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(75, 20)
        Me.button2.TabIndex = 16
        Me.button2.Text = "&About..."
        AddHandler button2.Click, AddressOf Me.button2_Click
        ' 
        ' buttonF
        ' 
        Me.buttonF.BackColor = System.Drawing.Color.WhiteSmoke
        Me.buttonF.CausesValidation = False
        Me.buttonF.Enabled = False
        Me.buttonF.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonF.ForeColor = System.Drawing.SystemColors.ControlText
        Me.buttonF.Image = CType(resources.GetObject("buttonF.Image"), System.Drawing.Image)
        Me.buttonF.Location = New System.Drawing.Point(72, 31)
        Me.buttonF.Name = "buttonF"
        Me.buttonF.Size = New System.Drawing.Size(55, 20)
        Me.buttonF.TabIndex = 15
        Me.buttonF.Text = " Next"
        Me.buttonF.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
#If (VS2005) Then
        Me.buttonF.UseVisualStyleBackColor = False
#End If
        AddHandler buttonF.Click, AddressOf Me.button4_Click
        ' 
        ' buttonB
        ' 
        Me.buttonB.BackColor = System.Drawing.Color.WhiteSmoke
        Me.buttonB.CausesValidation = False
        Me.buttonB.Enabled = False
        Me.buttonB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonB.Image = CType(resources.GetObject("buttonB.Image"), System.Drawing.Image)
        Me.buttonB.Location = New System.Drawing.Point(7, 31)
        Me.buttonB.Name = "buttonB"
        Me.buttonB.Size = New System.Drawing.Size(55, 20)
        Me.buttonB.TabIndex = 14
        Me.buttonB.Text = "Prev_"
        Me.buttonB.TextAlign = System.Drawing.ContentAlignment.MiddleRight
#If (VS2005) Then
        Me.buttonB.UseVisualStyleBackColor = False
#End If
        AddHandler buttonB.Click, AddressOf Me.button3_Click
        ' 
        ' butGo
        ' 
        Me.butGo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butGo.Location = New System.Drawing.Point(364, 3)
        Me.butGo.Name = "butGo"
        Me.butGo.Size = New System.Drawing.Size(75, 20)
        Me.butGo.TabIndex = 13
        Me.butGo.Text = "GoTo"
        AddHandler butGo.Click, AddressOf Me.butGo_Click
        ' 
        ' tbNodePath
        ' 
        Me.tbNodePath.BackColor = System.Drawing.Color.White
        Me.tbNodePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbNodePath.Location = New System.Drawing.Point(7, 3)
        Me.tbNodePath.Name = "tbNodePath"
        Me.tbNodePath.Size = New System.Drawing.Size(353, 20)
        Me.tbNodePath.TabIndex = 12
        AddHandler tbNodePath.TextChanged, AddressOf Me.tbNodePath_TextChanged
        ' 
        ' timer1
        ' 
        Me.timer1.Enabled = True
        Me.timer1.Interval = 1000
        AddHandler timer1.Tick, AddressOf Me.timer1_Tick
        ' 
        ' splitter1
        ' 
        Me.splitter1.Location = New System.Drawing.Point(240, 81)
        Me.splitter1.Name = "splitter1"
        Me.splitter1.Size = New System.Drawing.Size(3, 609)
        Me.splitter1.TabIndex = 5
        Me.splitter1.TabStop = False
        ' 
        ' MainForm
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(964, 714)
        Me.Controls.Add(Me.splitter1)
        Me.Controls.Add(Me.panel3)
        Me.Controls.Add(Me.tabControl1)
        Me.Controls.Add(Me.statusBar1)
        Me.Controls.Add(Me.panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TeeChart for .NET Examples"
        AddHandler Load, AddressOf Me.MainForm_Load
        Me.panel1.ResumeLayout(False)
        CType(Me.statusBarPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabControl1.ResumeLayout(False)
        Me.tabPageNew.ResumeLayout(False)
        Me.tabPageNew.PerformLayout()
        Me.tabSearch.ResumeLayout(False)
        Me.panel4.ResumeLayout(False)
        Me.panel4.PerformLayout()
        Me.tabPageAll.ResumeLayout(False)
        Me.panel3.ResumeLayout(False)
        Me.panelExample.ResumeLayout(False)
        Me.tabControlExample.ResumeLayout(False)
        Me.tabSource.ResumeLayout(False)
        Me.tabWeb.ResumeLayout(False)
        CType(Me.axWebBrowser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelNavBar.ResumeLayout(False)
        Me.panelNavBar.PerformLayout()
        Me.ResumeLayout(False)
    End Sub 'InitializeComponent 
#End Region

    '/ <summary>
    '/ The main entry point for the application.
    '/ </summary>
    <STAThread()> _
    Public Shared Sub Main()
        Application.Run(New MainForm)
    End Sub 'Main


    Private Sub button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button1.Click
        Close()
    End Sub 'button1_Click


    Private Sub button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button2.Click
        Steema.TeeChart.Editors.AboutBox.ShowModal()
    End Sub 'button2_Click

    Private Sub treeView1_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles treeView1.AfterSelect, treeSearch.AfterSelect, treeView2.AfterSelect
        Dim s As TreeView = sender
        tabExample.SuspendLayout()
        Try
            ShowForm(s)
            tabControlExample.SelectedTab = tabExample
            s.Select()
        Finally
            tabExample.ResumeLayout(True)
        End Try
        buttonB.Enabled = Not (s.SelectedNode Is Nothing) AndAlso CType(s.SelectedNode, DemoNode).AbsoluteIndex > 0
        buttonF.Enabled = Not (s.SelectedNode Is Nothing) AndAlso CType(s.SelectedNode, DemoNode).AbsoluteIndex < s.GetNodeCount(True) - 1
    End Sub 'treeView1_AfterSelect


    Private Sub button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonF.Click
        If Not (theTree().SelectedNode Is Nothing) Then
            theTree().SelectedNode = CType(theTree().SelectedNode, DemoNode).MoveForward()
        End If
    End Sub 'button4_Click

    Private Sub button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonB.Click
        theTree().SelectedNode = CType(theTree().SelectedNode, DemoNode).MoveBackward()
    End Sub 'button3_Click


    Private Sub tabControlExample_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tabControlExample.SelectedIndexChanged
        If tabControlExample.SelectedTab Is tabSource Then
            SourceFile = CodeFile(theTree().SelectedNode)
            Dim path As String = Utils.CodePath()

            buttonConfig.Visible = path = ""

            If SourceFile <> "" AndAlso path <> "" Then
                If Not SourceFile.Equals(OldSourceFile) Then
          System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
          Try
                        Dim sc As New SourceControl(richTextBox1)
                        sc.LoadTextFromFile(path & SourceFile)
                        statusBar1.Panels(0).Text = SourceFile
                    Finally
            System.Windows.Forms.Cursor.Current = Cursors.Default
          End Try
                    OldSourceFile = SourceFile
                End If
            End If
        ElseIf tabControlExample.SelectedTab Is tabWeb Then
            If Not (theTree().SelectedNode Is Nothing) AndAlso Not (CType(theTree().SelectedNode.Tag, DemoFormInfo).formtype Is Nothing) Then
                OpenWebPage("ABOUT:Loading page from Steema.com ...")
                Dim URLAddress As String = "http:'www.teechart.net/support"
                OpenWebPage(URLAddress)
            Else
                OpenWebPage(("ABOUT:All information about TeeChart Pro at <A HREF=" + ChrW(34) + "http:'www.teeChart.net" + ChrW(34) + ">www.teeChart.net</A>"))
            End If
        End If
    End Sub 'tabControlExample_SelectedIndexChanged


    Private Sub buttonConfig_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim ds As New DirectorySelect
    If ds.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
      Utils.WriteCodePath(ds.ReturnPath + "\")
      tabControlExample_SelectedIndexChanged(tabControlExample, New System.EventArgs)
    End If
  End Sub 'buttonConfig_Click


    Private Sub tabControl1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tabControl1.SelectedIndexChanged
        If tabControl1.SelectedTab Is tabSearch Then
            checkBoxFindSource.Enabled = Utils.CodePath() <> ""
            If Not checkBoxFindSource.Enabled Then
                checkBoxFindSource.Checked = False
            End If
        Else
            theTree().Select()
            Me.treeView1_AfterSelect(theTree(), New System.Windows.Forms.TreeViewEventArgs(theTree().SelectedNode))
        End If
    End Sub 'tabControl1_SelectedIndexChanged


    Private Sub comboBoxSearch_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles comboBoxSearch.KeyDown
        If e.KeyValue = Char.GetNumericValue(ChrW(13)) Then
            Me.DoSearch()
        End If
    End Sub 'comboBoxSearch_KeyDown

    Private Sub comboBoxSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles comboBoxSearch.TextChanged
        Me.buttonSearch.Enabled = comboBoxSearch.Text <> ""
    End Sub 'comboBoxSearch_TextChanged


    Private Sub buttonSearch_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.DoSearch()
    End Sub 'buttonSearch_Click


    Private Sub treeView1_BeforeCollapse(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewCancelEventArgs) Handles treeView1.BeforeCollapse, treeView2.BeforeCollapse
        e.Node.ImageIndex = 0
        e.Node.SelectedImageIndex = 0
    End Sub 'treeView1_BeforeCollapse


    Private Sub treeView1_BeforeExpand(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewCancelEventArgs) Handles treeView1.BeforeExpand, treeView2.BeforeExpand
        e.Node.SelectedImageIndex = 1
    End Sub 'treeView1_BeforeExpand


    Private Sub timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timer1.Tick
        timer1.Stop()
        Try
            If Not (tChart2 Is Nothing) Then
                Dim s As Single = tChart2.Panel.Gradient.SigmaFocus
                If s > 0.95 Or s < 0.05 Then
                    DeltaFocus = -DeltaFocus  '
                End If
                tChart2.Panel.Gradient.SigmaFocus += DeltaFocus
            End If
        Finally
            timer1.Start()
        End Try
    End Sub 'timer1_Tick


    Private Sub MainForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
#If TEELITE Then
      tChart2.Header.Text="TeeChart Lite for .NET Examples"
#End If

        theTree().Select()
#If DEBUG Then
        timer1.Enabled = False
#End If

    End Sub 'MainForm_Load

    Private Sub ShowFullNode(ByVal n As TreeNode)

#If DEBUG Then
        Console.WriteLine(n.Text)
#End If
        n.TreeView.SelectedNode = n
        n.EnsureVisible()
        Application.DoEvents()
        For Each nn As TreeNode In n.Nodes
            ShowFullNode(nn)
        Next nn
    End Sub 'ShowFullNode

    Private Sub menuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuItem1.Click
        For Each n As TreeNode In theTree().Nodes
            ShowFullNode(n)
        Next n
    End Sub 'menuItem1_Click

    Private Sub buttonSearch_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonSearch.Click
        DoSearch()
    End Sub 'buttonSearch_Click_1

    Private Sub butGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butGo.Click
        Dim st As String() = tbNodePath.Text.Split(New Char() {"\"c})
        Dim n As DemoNode = Nothing
        Dim NodeCount As Integer = theTree().GetNodeCount(True)
        If NodeCount > 0 Then
            n = CType(theTree().Nodes(0), DemoNode)
        End If
        Dim t As Integer
        For t = 0 To NodeCount - 1
            If n.Text = st((st.Length - 1)) Then
                theTree().SelectedNode = n
            Else
                n = CType(n.MoveForward(), DemoNode)
            End If
        Next t
    End Sub 'butGo_Click


    Private Sub panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles panel1.Paint
    End Sub 'panel1_Paint

    Private Sub tbNodePath_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbNodePath.TextChanged
    End Sub 'tbNodePath_TextChanged
    Private Sub textBox1_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles textBox1.TextChanged 'Handles textBox1.TextChanged

    End Sub

  Private ICanvasType As CanvasType

  Private Sub menuGDI_Click(ByVal sender As Object, ByVal e As EventArgs)
    ICanvasType = CanvasType.GDI
  End Sub

  Private Sub menuGDIPlus_Click(ByVal sender As Object, ByVal e As EventArgs)
    ICanvasType = CanvasType.GDIPlus
  End Sub

  Private Sub menuOpenGL_Click(ByVal sender As Object, ByVal e As EventArgs)
    ICanvasType = CanvasType.OpenGL
  End Sub

  'private Sub contextMenu1_Popup(ByVal sender as object,ByVal e as EventArgs)
  '  menuGDI.Checked = false
  '  menuGDIPlus.Checked = false
  '  menuOpenGL.Checked = false
  '  Select Case canvasType
  '        Case CanvasType.GDI
  '          menuGDI.Checked = True
  '          break
  '        Case CanvasType.GDIPlus
  '          menuGDIPlus.Checked = True
  '          break
  '        Case CanvasType.OpenGL
  '          menuOpenGL.Checked = True
  '          break
  '  End Select
  'End Sub

  Public Enum CanvasType
    GDI
    GDIPlus
    OpenGL
  End Enum

End Class 'MainForm 