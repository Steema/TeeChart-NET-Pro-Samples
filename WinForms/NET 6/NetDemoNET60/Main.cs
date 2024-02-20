using System;
using System.Collections.Specialized;
using System.IO;
using System.Windows.Forms;

namespace Steema.TeeChart.Samples
{
  /// <summary>
  /// Main Examples form.
  /// </summary>
  public class MainForm : System.Windows.Forms.Form
  {
    private System.Windows.Forms.Panel panel1;
    //private System.Windows.Forms.StatusBar statusBar1;
    private TabControl tabControl1;
    private TreeView treeView1;
    private System.Windows.Forms.Panel panel3;
    private System.ComponentModel.IContainer components;
    private TabPage tabSearch;
    private System.Windows.Forms.Panel panel4;
    private TreeView treeSearch;
    private Label label1;
    private ComboBox comboBoxSearch;
    private Label label2;
    private CheckBox checkBoxFindAll;
    private CheckBox checkBoxFindSource;
    private TreeView treeView2;
    private TextBox textBox2;
    private Timer timer1;

    // manually defined at runtime
    private static string OldSourceFile;
    private static Form TheForm;
    private static Type OldFormType;
    private TabPage tabPageNew;
    private TabPage tabPageAll;
    //private System.Windows.Forms.ContextMenu contextMenu1;
    //private System.Windows.Forms.MenuItem menuItem1;
    //private System.Windows.Forms.StatusBarPanel statusBarPanel1;
    private Splitter splitter1;
    private ImageList imageList1;
    private Button buttonSearch;
    private TextBox textBox1;
    private System.Windows.Forms.Panel panel2;
    private TextBox tbNodePath;
    private Button butGo;
    private System.Windows.Forms.Panel panelNavBar;
    private System.Windows.Forms.Panel panelExample;
    private TabControl tabControlExample;
    private TabPage tabExample;
    private TabPage tabSource;
    private Button buttonConfig;
    private RichTextBox richTextBox1;
    private TabPage tabWeb;
    private Button buttonF;
    private Button buttonB;
    private Button button2;
    private Button button1;
    //private MenuItem menuItem5;
    private System.Windows.Forms.Panel panel6;
    private System.Windows.Forms.Panel panel5;
    private SaveFileDialog saveFileDialog1;
    private static string SourceFile;

    private struct DemoFormInfo
    {
      public Type formtype;
      public string unitname;
    }

    public MainForm()
    {
      //
      // Required for Windows Form Designer support
      //
      InitializeComponent();

      //			this.tabControl1.TabPages.Remove(this.tabPageNew); // well, it's first NET version so ...
      tabControl1.SelectedTab = tabPageNew;
      // load data from tree
      LoadTreeFromStrings(treeView1, textBox1.Lines);
      LoadTreeFromStrings(treeView2, textBox2.Lines);
      treeView1.HotTracking = true;
      //canvasType = CanvasType.GDIPlus;
    }

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    protected override void Dispose(bool disposing)
    {
      if (disposing)
      {
        if (components != null)
        {
          components.Dispose();
        }
      }
      base.Dispose(disposing);
    }

    /// <summary>
    /// Finds source code *.cs file
    /// </summary>
    private string CodeFile(TreeNode node)
    {
      if (node == null)
      {
        return "";
      }
      else
      {
        var fn = ((DemoFormInfo)node.Tag).unitname;
        fn = fn.Trim();
        if (fn != "")
        {
          fn += ".cs";
        }

        return fn;
      }
    }

    private Type FindType(Type t)
    {
      Type tp = null;
      // find match, only one assembly, so not a problem
      var a = System.Reflection.Assembly.GetCallingAssembly();
      var types = a.GetExportedTypes();
      for (var i = 0; i < types.Length; i++)
      {
        if (types[i].Equals(t))
        {
          tp = types[i];
          break;
        }
      }

      return tp;
    }

    /// <summary>
    /// Shows specific demo form
    /// </summary>
    private void ShowForm(TreeView tree)
    {
      if (tree.SelectedNode != null)
      {
        if (((DemoFormInfo)tree.SelectedNode.Tag).formtype != null)
        {
          var t = FindType(((DemoFormInfo)tree.SelectedNode.Tag).formtype);
          if (t != OldFormType)
          {
            try
            {
              if (TheForm != null)
              {
                TheForm.Dispose();
              }
              // find and create form
              TheForm = (Form)System.Activator.CreateInstance(t);
              OldFormType = t;
              Steema.TeeChart.Editors.EditorUtils.InsertForm(TheForm, tabExample);
            }
            catch (Exception ee)
            {
              // missing form, set red bullet icon
              MessageBox.Show(ee.Message);
              tree.SelectedNode.ImageIndex = 3;
              tree.SelectedNode.SelectedImageIndex = 3;
            }
          }
        }
        else
          if (tree.SelectedNode.Nodes.Count == 0)
        {
          // missing form, set red bullet icon
          tree.SelectedNode.ImageIndex = 3;
          tree.SelectedNode.SelectedImageIndex = 3;
        }

        //statusBar1.Panels[0].Text = tree.SelectedNode.Text;
        tbNodePath.Text = tree.SelectedNode.FullPath;
      }
      else
      {
        //statusBar1.Panels[0].Text = "";
        tbNodePath.Text = "";

      }
    }

    #region Setup Tree
    /// <summary>
    // Loads treeView structure from a string array
    /// </summary>
    private void LoadTreeFromStrings(TreeView tree,
        string[] strings)
    {
      tree.BeginUpdate();
      try
      {
        string tmpstr, NodeText, ClassName, UnitName;
        string[] st;
        int alevel;
        DemoFormInfo FormInfo;

        tree.Nodes.Clear();
        DemoNode OwnerNode = null;
        DemoNode tmpNode, NextNode;
        for (var i = 0; i < strings.Length; i++)
        {
          NodeText = "";
          // first get level
          alevel = 0;
          while (strings[i][alevel] == ' ')
          {
            alevel++;
          }

          tmpstr = strings[i].Substring(alevel);
          // split info, get caption, form class name + unit name
          st = tmpstr.Split(',');
          NodeText = st[0];
          ClassName = st.Length > 1 ? "Steema.TeeChart.Samples." + st[1] : "";
          UnitName = st.Length > 2 ? st[2] : "";

          // use TreeNode Tag property to add form info
          FormInfo = new DemoFormInfo
          {
            unitname = UnitName,
            formtype = ClassName == "" ? null : System.Reflection.Assembly.GetCallingAssembly().GetType(ClassName)
          };

          // finally, add node to treeView
          tmpNode = new DemoNode(NodeText);
          if ((OwnerNode == null) || (alevel == 0))
          {
            tree.Nodes.Add(tmpNode);
          }
          else if (OwnerNode.Level == alevel)
          {
            OwnerNode.Parent.Nodes.Add(tmpNode);
          }
          else if (OwnerNode.Level == alevel - 1)
          {
            OwnerNode.Nodes.Add(tmpNode);
          }
          else if (OwnerNode.Level > alevel)
          {
            NextNode = (DemoNode)OwnerNode.Parent;
            while (NextNode.Level > alevel)
            {
              NextNode = (DemoNode)NextNode.Parent;
            }

            NextNode.Parent.Nodes.Add(tmpNode);
          }
          tmpNode.AbsoluteIndex = i;
          tmpNode.Tag = FormInfo;
          OwnerNode = tmpNode;
        }
        // now setup images
        SetTreeNodesImage(tree);
        if (tree.Nodes.Count > 0)
        {
          tree.Nodes[0].Expand();
        }
      }
      finally
      {
        tree.EndUpdate();
      }
    }

    private void SetImagesRecursively(TreeNode n)
    {
      n.ImageIndex = n.Nodes.Count == 0 ? 2 : 0;
      n.SelectedImageIndex = n.ImageIndex;
      foreach (TreeNode ch in n.Nodes)
      {
        SetImagesRecursively(ch);
      }
    }

    private void SetTreeNodesImage(TreeView tree)
    {
      tree.BeginUpdate();
      try
      {
        var nodes = tree.Nodes;
        foreach (TreeNode n in nodes)
        {
          SetImagesRecursively(n);
        }
      }
      finally
      {
        tree.EndUpdate();
      }
    }
    #endregion

    private TreeView theTree()
    {
      if (tabControl1.SelectedTab == tabPageNew)
      {
        return treeView1;
      }
      else if (tabControl1.SelectedTab == tabPageAll)
      {
        return treeView2;
      }
      else
      {
        return treeSearch;
      }
    }

    private void OpenWebPage(string location)
    {

    }

    #region	Tree Search Algorithm
    private bool FoundTextIn(string s, string[] Words, bool FindAllWords)
    {
      // covert to UPPERCASE
      s = s.ToUpper();
      if (FindAllWords)
      {
        for (var t = 0; t < Words.Length; t++)
        {
          if (s.IndexOf(Words[t], 0) == -1)
          {
            return false;
          }
        }

        return true;
      }
      else
      {
        for (var t = 0; t < Words.Length; t++)
        {
          if (s.IndexOf(Words[t], 0) != -1)
          {
            return true;
          }
        }

        return false;
      }
    }

    private void AddResult(DemoNode n)
    {
      var Added = new DemoNode(n.Text)
      {
        Tag = n.Tag,
        AbsoluteIndex = treeSearch.GetNodeCount(false)
      };
      treeSearch.Nodes.Add(Added);
    }

    private bool SearchInLines(string[] lines, string[] Words, bool FindAllWords)
    {
      for (var t = 0; t < lines.Length; t++)
      {
        if (FoundTextIn(lines[t], Words, FindAllWords))
        {
          return true;
        }
      }

      return false;
    }

    private bool SearchInTextBox(TextBox txtbox, string[] Words, bool FindAllWords)
    {
      if (txtbox.Lines.Length > 0)
      {
        return SearchInLines(txtbox.Lines, Words, FindAllWords);
      }
      else
      {
        return FoundTextIn(txtbox.Text, Words, FindAllWords);
      }
    }

    private bool SearchInForm(Form form, string[] Words, bool FindAllWords)
    {
      var res = false;
      for (var t = 0; t < form.Controls.Count; t++)
      {
        if (form.Controls[t] is TextBox)
        {
          res = SearchInTextBox(form.Controls[t] as TextBox, Words, FindAllWords);
          if (res)
          {
            break;
          }
        }
      }

      return res;
    }

    private bool FoundTextInNode(DemoNode n, string[] Words, bool FindAllWords,
                                StringCollection formNames)
    {
      var res = false;
      var tmp = (DemoFormInfo)n.Tag;
      if ((tmp.formtype != null) || (tmp.unitname != null))
      {
        // First of all, search in tree node Text...
        res = FoundTextIn(n.Text, Words, FindAllWords);

        if (!res)
        {
          var t = FindType(((DemoFormInfo)n.Tag).formtype);
          if (t != null)
          {
            using (var tmpForm = (Form)System.Activator.CreateInstance(t))
            {
              // Avoid processing same form twice...
              if (formNames.IndexOf(tmp.formtype.ToString()) != -1)
              {
                return res;
              }

              formNames.Add(tmp.formtype.ToString());

              // Now do search ...
              if (tmpForm is BaseForm)
              {
                res = SearchInTextBox((tmpForm as BaseForm).textBox1, Words, FindAllWords);
              }
              else
              {
                res = SearchInForm(tmpForm, Words, FindAllWords);
              }
            }
          }
        }

        // Load form source code and search...
        if (!res)
        {
          if ((tmp.unitname != null) && (checkBoxFindSource.Checked))
          {
            var fn = Utils.CodePath() + tmp.unitname + ".cs";
            var fi = new FileInfo(fn);
            if (fi.Exists)
            {
              var r = fi.OpenText();
              try
              {
                string textLine;
                while ((textLine = r.ReadLine()) != null)
                {
                  res = FoundTextIn(textLine, Words, FindAllWords);
                  if (res)
                  {
                    break;
                  }
                }
              }
              finally
              {
                r.Close();
              }
            }
          }
        }
      }
      return res;
    }

    private void DoSearchTree(TreeView tree, ProgressBar pb, int Offset,
        string[] Words, bool FindAllWords, StringCollection formNames)
    {
      var tmp = 0;
      DemoNode n = null;
      var NodeCount = tree.GetNodeCount(true);
      if (NodeCount > 0)
      {
        n = (DemoNode)tree.Nodes[0];
      }

      for (var t = 0; t < NodeCount; t++)
      {
        tmp = Offset + t * 50 / NodeCount;
        if (pb.Value != tmp)
        {
          pb.Value = tmp;
        }

        if (FoundTextInNode(n, Words, FindAllWords, formNames))
        {
          AddResult(n);
        }

        t++;
        n = (DemoNode)n.MoveForward();
      }
    }

    private void DoSearch()
    {
      treeSearch.BeginUpdate();
      Cursor.Current = Cursors.WaitCursor;
      try
      {
        treeSearch.Nodes.Clear();
        if (TheForm != null)
        {
          TheForm.Dispose();
        }

        var SearchText = comboBoxSearch.Text;

        if (SearchText != "")
        {
          // new text item ? Then add it to combobox items
          if (comboBoxSearch.Items.IndexOf(SearchText) < 0)
          {
            comboBoxSearch.Items.Add(SearchText);
          }

          // first, convert SearchText to UPPERCASE
          SearchText = SearchText.ToUpper();
          // split words
          var Words = SearchText.Split(' ');
          var pb = new ProgressBar(); ;

          // used to store all already seached forms (to prevent duplicate search
          var formNames = new StringCollection();
          try
          {
            // setup ProgressBar properties
            pb.Location = new System.Drawing.Point(0, 3);
            pb.Width = Math.Max(200, tabControl1.Width);
            pb.Minimum = 0;
            pb.Maximum = 100;
            pb.Value = 0;
            //statusBar1.SuspendLayout();
            //statusBar1.Controls.Add(pb);
            //statusBar1.ResumeLayout(true);

            // now do complete search
            DoSearchTree(treeView1, pb, 0, Words, checkBoxFindAll.Checked, formNames);
            DoSearchTree(treeView2, pb, 50, Words, checkBoxFindAll.Checked, formNames);
            pb.Value = 100;
          }
          finally
          {
            //statusBar1.SuspendLayout();
            //statusBar1.Controls.Remove(pb);
            pb.Dispose();
            formNames.Clear();
            formNames = null;
            //statusBar1.ResumeLayout(true);
          }
        }
      }
      finally
      {
        treeSearch.EndUpdate();
        Cursor.Current = Cursors.Default;
      }
    }
    #endregion

    #region Windows Form Designer generated code
    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
      panel1 = new System.Windows.Forms.Panel();
      panel5 = new System.Windows.Forms.Panel();
      panel6 = new System.Windows.Forms.Panel();
      panel2 = new System.Windows.Forms.Panel();
      tabControl1 = new TabControl();
      tabPageNew = new TabPage();
      textBox2 = new TextBox();
      textBox1 = new TextBox();
      treeView1 = new TreeView();
      imageList1 = new ImageList(components);
      tabSearch = new TabPage();
      treeSearch = new TreeView();
      panel4 = new System.Windows.Forms.Panel();
      buttonSearch = new Button();
      checkBoxFindSource = new CheckBox();
      checkBoxFindAll = new CheckBox();
      label2 = new Label();
      comboBoxSearch = new ComboBox();
      label1 = new Label();
      tabPageAll = new TabPage();
      treeView2 = new TreeView();
      panel3 = new System.Windows.Forms.Panel();
      panelExample = new System.Windows.Forms.Panel();
      tabControlExample = new TabControl();
      tabExample = new TabPage();
      tabSource = new TabPage();
      buttonConfig = new Button();
      richTextBox1 = new RichTextBox();
      tabWeb = new TabPage();
      panelNavBar = new System.Windows.Forms.Panel();
      button1 = new Button();
      button2 = new Button();
      buttonF = new Button();
      buttonB = new Button();
      butGo = new Button();
      tbNodePath = new TextBox();
      timer1 = new Timer(components);
      splitter1 = new Splitter();
      saveFileDialog1 = new SaveFileDialog();
      panel1.SuspendLayout();
      tabControl1.SuspendLayout();
      tabPageNew.SuspendLayout();
      tabSearch.SuspendLayout();
      panel4.SuspendLayout();
      tabPageAll.SuspendLayout();
      panel3.SuspendLayout();
      panelExample.SuspendLayout();
      tabControlExample.SuspendLayout();
      tabSource.SuspendLayout();
      panelNavBar.SuspendLayout();
      SuspendLayout();
      // 
      // panel1
      // 
      panel1.BackColor = System.Drawing.Color.White;
      panel1.BackgroundImage = (System.Drawing.Image)resources.GetObject("panel1.BackgroundImage");
      panel1.Controls.Add(panel5);
      panel1.Controls.Add(panel6);
      panel1.Controls.Add(panel2);
      panel1.Dock = DockStyle.Top;
      panel1.Location = new System.Drawing.Point(0, 0);
      panel1.Name = "panel1";
      panel1.Size = new System.Drawing.Size(964, 100);
      panel1.TabIndex = 0;
      panel1.Paint += panel1_Paint;
      // 
      // panel5
      // 
      panel5.BackgroundImage = (System.Drawing.Image)resources.GetObject("panel5.BackgroundImage");
      panel5.Dock = DockStyle.Right;
      panel5.Location = new System.Drawing.Point(756, 0);
      panel5.Name = "panel5";
      panel5.Size = new System.Drawing.Size(208, 100);
      panel5.TabIndex = 10;
      // 
      // panel6
      // 
      panel6.BackgroundImage = (System.Drawing.Image)resources.GetObject("panel6.BackgroundImage");
      panel6.Dock = DockStyle.Left;
      panel6.Location = new System.Drawing.Point(775, 0);
      panel6.Name = "panel6";
      panel6.Size = new System.Drawing.Size(96, 100);
      panel6.TabIndex = 11;
      // 
      // panel2
      // 
      panel2.BackgroundImage = (System.Drawing.Image)resources.GetObject("panel2.BackgroundImage");
      panel2.Dock = DockStyle.Left;
      panel2.Location = new System.Drawing.Point(0, 0);
      panel2.Name = "panel2";
      panel2.Size = new System.Drawing.Size(775, 100);
      panel2.TabIndex = 9;
      // 
      // tabControl1
      // 
      tabControl1.Controls.Add(tabPageNew);
      tabControl1.Controls.Add(tabSearch);
      tabControl1.Controls.Add(tabPageAll);
      tabControl1.Dock = DockStyle.Left;
      tabControl1.HotTrack = true;
      tabControl1.Location = new System.Drawing.Point(0, 100);
      tabControl1.Name = "tabControl1";
      tabControl1.SelectedIndex = 0;
      tabControl1.Size = new System.Drawing.Size(288, 614);
      tabControl1.TabIndex = 0;
      tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
      tabControl1.MouseClick += tabControl1_MouseClick;
      // 
      // tabPageNew
      // 
      tabPageNew.Controls.Add(textBox2);
      tabPageNew.Controls.Add(textBox1);
      tabPageNew.Controls.Add(treeView1);
      tabPageNew.ImageIndex = 3;
      tabPageNew.Location = new System.Drawing.Point(4, 24);
      tabPageNew.Name = "tabPageNew";
      tabPageNew.Size = new System.Drawing.Size(280, 586);
      tabPageNew.TabIndex = 0;
      tabPageNew.Text = "What's New?";
      // 
      // textBox2
      // 
      textBox2.Location = new System.Drawing.Point(26, 44);
      textBox2.Multiline = true;
      textBox2.Name = "textBox2";
      textBox2.Size = new System.Drawing.Size(212, 242);
      textBox2.TabIndex = 1;
      textBox2.Text = resources.GetString("textBox2.Text");
      textBox2.Visible = false;
      textBox2.WordWrap = false;
      // 
      // textBox1
      // 
      textBox1.Location = new System.Drawing.Point(29, 315);
      textBox1.Multiline = true;
      textBox1.Name = "textBox1";
      textBox1.Size = new System.Drawing.Size(211, 177);
      textBox1.TabIndex = 3;
      textBox1.Text = resources.GetString("textBox1.Text");
      textBox1.Visible = false;
      textBox1.WordWrap = false;
      textBox1.TextChanged += textBox1_TextChanged;
      // 
      // treeView1
      // 
      treeView1.CausesValidation = false;
      treeView1.Dock = DockStyle.Fill;
      treeView1.FullRowSelect = true;
      treeView1.ImageIndex = 0;
      treeView1.ImageList = imageList1;
      treeView1.Location = new System.Drawing.Point(0, 0);
      treeView1.Name = "treeView1";
      treeView1.SelectedImageIndex = 0;
      treeView1.Size = new System.Drawing.Size(280, 586);
      treeView1.TabIndex = 0;
      treeView1.BeforeCollapse += treeView1_BeforeCollapse;
      treeView1.BeforeExpand += treeView1_BeforeExpand;
      treeView1.AfterSelect += treeView1_AfterSelect;
      // 
      // imageList1
      // 
      imageList1.ColorDepth = ColorDepth.Depth8Bit;
      imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
      imageList1.TransparentColor = System.Drawing.Color.Transparent;
      imageList1.Images.SetKeyName(0, "");
      imageList1.Images.SetKeyName(1, "");
      imageList1.Images.SetKeyName(2, "");
      imageList1.Images.SetKeyName(3, "");
      // 
      // tabSearch
      // 
      tabSearch.Controls.Add(treeSearch);
      tabSearch.Controls.Add(panel4);
      tabSearch.Location = new System.Drawing.Point(4, 24);
      tabSearch.Name = "tabSearch";
      tabSearch.Size = new System.Drawing.Size(280, 586);
      tabSearch.TabIndex = 2;
      tabSearch.Text = "Search";
      // 
      // treeSearch
      // 
      treeSearch.Dock = DockStyle.Fill;
      treeSearch.Location = new System.Drawing.Point(0, 138);
      treeSearch.Name = "treeSearch";
      treeSearch.Size = new System.Drawing.Size(280, 448);
      treeSearch.TabIndex = 0;
      treeSearch.AfterSelect += treeView1_AfterSelect;
      // 
      // panel4
      // 
      panel4.BackColor = System.Drawing.SystemColors.Control;
      panel4.Controls.Add(buttonSearch);
      panel4.Controls.Add(checkBoxFindSource);
      panel4.Controls.Add(checkBoxFindAll);
      panel4.Controls.Add(label2);
      panel4.Controls.Add(comboBoxSearch);
      panel4.Controls.Add(label1);
      panel4.Dock = DockStyle.Top;
      panel4.Location = new System.Drawing.Point(0, 0);
      panel4.Name = "panel4";
      panel4.Size = new System.Drawing.Size(280, 138);
      panel4.TabIndex = 0;
      // 
      // buttonSearch
      // 
      buttonSearch.FlatStyle = FlatStyle.Flat;
      buttonSearch.Image = (System.Drawing.Image)resources.GetObject("buttonSearch.Image");
      buttonSearch.Location = new System.Drawing.Point(246, 31);
      buttonSearch.Name = "buttonSearch";
      buttonSearch.Size = new System.Drawing.Size(32, 28);
      buttonSearch.TabIndex = 6;
      buttonSearch.Click += buttonSearch_Click_1;
      // 
      // checkBoxFindSource
      // 
      checkBoxFindSource.Checked = true;
      checkBoxFindSource.CheckState = CheckState.Checked;
      checkBoxFindSource.FlatStyle = FlatStyle.Flat;
      checkBoxFindSource.Location = new System.Drawing.Point(19, 111);
      checkBoxFindSource.Name = "checkBoxFindSource";
      checkBoxFindSource.Size = new System.Drawing.Size(263, 19);
      checkBoxFindSource.TabIndex = 0;
      checkBoxFindSource.Text = "&Look in source code";
      // 
      // checkBoxFindAll
      // 
      checkBoxFindAll.Checked = true;
      checkBoxFindAll.CheckState = CheckState.Checked;
      checkBoxFindAll.FlatStyle = FlatStyle.Flat;
      checkBoxFindAll.Location = new System.Drawing.Point(19, 87);
      checkBoxFindAll.Name = "checkBoxFindAll";
      checkBoxFindAll.Size = new System.Drawing.Size(263, 20);
      checkBoxFindAll.TabIndex = 5;
      checkBoxFindAll.Text = "Find &all words (AND)";
      // 
      // label2
      // 
      label2.AutoSize = true;
      label2.Location = new System.Drawing.Point(10, 66);
      label2.Name = "label2";
      label2.Size = new System.Drawing.Size(94, 15);
      label2.TabIndex = 4;
      label2.Text = "Search options : ";
      // 
      // comboBoxSearch
      // 
      comboBoxSearch.Location = new System.Drawing.Point(10, 32);
      comboBoxSearch.Name = "comboBoxSearch";
      comboBoxSearch.Size = new System.Drawing.Size(231, 23);
      comboBoxSearch.TabIndex = 2;
      comboBoxSearch.Text = "Gradient Text";
      comboBoxSearch.TextChanged += comboBoxSearch_TextChanged;
      comboBoxSearch.KeyDown += comboBoxSearch_KeyDown;
      // 
      // label1
      // 
      label1.AutoSize = true;
      label1.Location = new System.Drawing.Point(10, 9);
      label1.Name = "label1";
      label1.Size = new System.Drawing.Size(123, 15);
      label1.TabIndex = 1;
      label1.Text = "&Enter words to search:";
      // 
      // tabPageAll
      // 
      tabPageAll.Controls.Add(treeView2);
      tabPageAll.Location = new System.Drawing.Point(4, 24);
      tabPageAll.Name = "tabPageAll";
      tabPageAll.Size = new System.Drawing.Size(280, 586);
      tabPageAll.TabIndex = 1;
      tabPageAll.Text = "All Features";
      // 
      // treeView2
      // 
      treeView2.CausesValidation = false;
      treeView2.Dock = DockStyle.Fill;
      treeView2.ImageIndex = 0;
      treeView2.ImageList = imageList1;
      treeView2.Location = new System.Drawing.Point(0, 0);
      treeView2.Name = "treeView2";
      treeView2.SelectedImageIndex = 0;
      treeView2.Size = new System.Drawing.Size(280, 586);
      treeView2.TabIndex = 1;
      treeView2.BeforeCollapse += treeView1_BeforeCollapse;
      treeView2.BeforeExpand += treeView1_BeforeExpand;
      treeView2.AfterSelect += treeView1_AfterSelect;
      // 
      // panel3
      // 
      panel3.Controls.Add(panelExample);
      panel3.Controls.Add(panelNavBar);
      panel3.Dock = DockStyle.Fill;
      panel3.Location = new System.Drawing.Point(288, 100);
      panel3.Name = "panel3";
      panel3.Size = new System.Drawing.Size(676, 614);
      panel3.TabIndex = 4;
      // 
      // panelExample
      // 
      panelExample.BackColor = System.Drawing.Color.WhiteSmoke;
      panelExample.Controls.Add(tabControlExample);
      panelExample.Dock = DockStyle.Fill;
      panelExample.Location = new System.Drawing.Point(0, 69);
      panelExample.Name = "panelExample";
      panelExample.Size = new System.Drawing.Size(676, 545);
      panelExample.TabIndex = 2;
      // 
      // tabControlExample
      // 
      tabControlExample.Alignment = TabAlignment.Bottom;
      tabControlExample.Controls.Add(tabExample);
      tabControlExample.Controls.Add(tabSource);
      tabControlExample.Controls.Add(tabWeb);
      tabControlExample.Dock = DockStyle.Fill;
      tabControlExample.HotTrack = true;
      tabControlExample.Location = new System.Drawing.Point(0, 0);
      tabControlExample.Name = "tabControlExample";
      tabControlExample.SelectedIndex = 0;
      tabControlExample.Size = new System.Drawing.Size(676, 545);
      tabControlExample.TabIndex = 1;
      tabControlExample.SelectedIndexChanged += tabControlExample_SelectedIndexChanged;
      // 
      // tabExample
      // 
      tabExample.BackColor = System.Drawing.Color.White;
      tabExample.Location = new System.Drawing.Point(4, 4);
      tabExample.Name = "tabExample";
      tabExample.Size = new System.Drawing.Size(668, 517);
      tabExample.TabIndex = 0;
      tabExample.Text = "Example";
      // 
      // tabSource
      // 
      tabSource.Controls.Add(buttonConfig);
      tabSource.Controls.Add(richTextBox1);
      tabSource.Location = new System.Drawing.Point(4, 4);
      tabSource.Name = "tabSource";
      tabSource.Size = new System.Drawing.Size(668, 517);
      tabSource.TabIndex = 2;
      tabSource.Text = "Source";
      tabSource.Visible = false;
      // 
      // buttonConfig
      // 
      buttonConfig.FlatStyle = FlatStyle.Flat;
      buttonConfig.Location = new System.Drawing.Point(22, 23);
      buttonConfig.Name = "buttonConfig";
      buttonConfig.Size = new System.Drawing.Size(132, 29);
      buttonConfig.TabIndex = 1;
      buttonConfig.Text = "&Configure...";
      // 
      // richTextBox1
      // 
      richTextBox1.Dock = DockStyle.Fill;
      richTextBox1.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      richTextBox1.Location = new System.Drawing.Point(0, 0);
      richTextBox1.Name = "richTextBox1";
      richTextBox1.ReadOnly = true;
      richTextBox1.Size = new System.Drawing.Size(668, 517);
      richTextBox1.TabIndex = 0;
      richTextBox1.Text = "";
      richTextBox1.WordWrap = false;
      // 
      // tabWeb
      // 
      tabWeb.Location = new System.Drawing.Point(4, 4);
      tabWeb.Name = "tabWeb";
      tabWeb.Size = new System.Drawing.Size(668, 517);
      tabWeb.TabIndex = 1;
      tabWeb.Text = "Web";
      tabWeb.Visible = false;
      // 
      // panelNavBar
      // 
      panelNavBar.BackColor = System.Drawing.Color.WhiteSmoke;
      panelNavBar.Controls.Add(button1);
      panelNavBar.Controls.Add(button2);
      panelNavBar.Controls.Add(buttonF);
      panelNavBar.Controls.Add(buttonB);
      panelNavBar.Controls.Add(butGo);
      panelNavBar.Controls.Add(tbNodePath);
      panelNavBar.Dock = DockStyle.Top;
      panelNavBar.Location = new System.Drawing.Point(0, 0);
      panelNavBar.Name = "panelNavBar";
      panelNavBar.Size = new System.Drawing.Size(676, 69);
      panelNavBar.TabIndex = 1;
      // 
      // button1
      // 
      button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      button1.FlatStyle = FlatStyle.Flat;
      button1.Location = new System.Drawing.Point(580, 4);
      button1.Name = "button1";
      button1.Size = new System.Drawing.Size(90, 24);
      button1.TabIndex = 17;
      button1.Text = "&Close";
      button1.Click += button1_Click;
      // 
      // button2
      // 
      button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      button2.FlatStyle = FlatStyle.Flat;
      button2.Location = new System.Drawing.Point(485, 4);
      button2.Name = "button2";
      button2.Size = new System.Drawing.Size(90, 24);
      button2.TabIndex = 16;
      button2.Text = "&About...";
      button2.Click += button2_Click;
      // 
      // buttonF
      // 
      buttonF.BackColor = System.Drawing.Color.WhiteSmoke;
      buttonF.CausesValidation = false;
      buttonF.Enabled = false;
      buttonF.FlatStyle = FlatStyle.Flat;
      buttonF.ForeColor = System.Drawing.SystemColors.ControlText;
      buttonF.Image = (System.Drawing.Image)resources.GetObject("buttonF.Image");
      buttonF.Location = new System.Drawing.Point(86, 38);
      buttonF.Name = "buttonF";
      buttonF.Size = new System.Drawing.Size(66, 25);
      buttonF.TabIndex = 15;
      buttonF.Text = " Next";
      buttonF.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      buttonF.UseVisualStyleBackColor = false;
      buttonF.Click += button4_Click;
      // 
      // buttonB
      // 
      buttonB.BackColor = System.Drawing.Color.WhiteSmoke;
      buttonB.CausesValidation = false;
      buttonB.Enabled = false;
      buttonB.FlatStyle = FlatStyle.Flat;
      buttonB.Image = (System.Drawing.Image)resources.GetObject("buttonB.Image");
      buttonB.Location = new System.Drawing.Point(8, 38);
      buttonB.Name = "buttonB";
      buttonB.Size = new System.Drawing.Size(66, 25);
      buttonB.TabIndex = 14;
      buttonB.Text = "Prev_";
      buttonB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      buttonB.UseVisualStyleBackColor = false;
      buttonB.Click += button3_Click;
      // 
      // butGo
      // 
      butGo.FlatStyle = FlatStyle.Flat;
      butGo.Location = new System.Drawing.Point(397, 4);
      butGo.Name = "butGo";
      butGo.Size = new System.Drawing.Size(90, 24);
      butGo.TabIndex = 13;
      butGo.Text = "GoTo";
      butGo.Click += butGo_Click;
      // 
      // tbNodePath
      // 
      tbNodePath.BackColor = System.Drawing.Color.White;
      tbNodePath.BorderStyle = BorderStyle.FixedSingle;
      tbNodePath.Location = new System.Drawing.Point(8, 4);
      tbNodePath.Name = "tbNodePath";
      tbNodePath.Size = new System.Drawing.Size(388, 23);
      tbNodePath.TabIndex = 12;
      tbNodePath.TextChanged += tbNodePath_TextChanged;
      // 
      // timer1
      // 
      timer1.Enabled = true;
      timer1.Interval = 1000;
      timer1.Tick += timer1_Tick;
      // 
      // splitter1
      // 
      splitter1.Location = new System.Drawing.Point(288, 100);
      splitter1.Name = "splitter1";
      splitter1.Size = new System.Drawing.Size(4, 614);
      splitter1.TabIndex = 5;
      splitter1.TabStop = false;
      // 
      // saveFileDialog1
      // 
      saveFileDialog1.FileName = "ChartLayout.bmp";
      saveFileDialog1.Filter = "Bitmap files |*.bmp";
      // 
      // MainForm
      // 
      AutoScaleBaseSize = new System.Drawing.Size(6, 16);
      ClientSize = new System.Drawing.Size(964, 714);
      Controls.Add(splitter1);
      Controls.Add(panel3);
      Controls.Add(tabControl1);
      Controls.Add(panel1);
      Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
      Name = "MainForm";
      StartPosition = FormStartPosition.CenterScreen;
      Text = "TeeChart for .NET Examples";
      Load += MainForm_Load;
      panel1.ResumeLayout(false);
      tabControl1.ResumeLayout(false);
      tabPageNew.ResumeLayout(false);
      tabPageNew.PerformLayout();
      tabSearch.ResumeLayout(false);
      panel4.ResumeLayout(false);
      panel4.PerformLayout();
      tabPageAll.ResumeLayout(false);
      panel3.ResumeLayout(false);
      panelExample.ResumeLayout(false);
      tabControlExample.ResumeLayout(false);
      tabSource.ResumeLayout(false);
      panelNavBar.ResumeLayout(false);
      panelNavBar.PerformLayout();
      ResumeLayout(false);
    }
    #endregion

    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    public static void Main()
    {
      Application.Run(new MainForm());
    }

    private void button1_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      Steema.TeeChart.Editors.AboutBox.ShowModal();
    }

    private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
    {
      var s = sender as TreeView;
      tabExample.SuspendLayout();
      try
      {
        ShowForm(s);
        tabControlExample.SelectedTab = tabExample;
        s.Select();
      }
      finally
      {
        tabExample.ResumeLayout(true);
      }

      buttonB.Enabled = (s.SelectedNode != null) && (((DemoNode)s.SelectedNode).AbsoluteIndex > 0);
      buttonF.Enabled = (s.SelectedNode != null) && (((DemoNode)s.SelectedNode).AbsoluteIndex < s.GetNodeCount(true) - 1);
    }

    private void button4_Click(object sender, EventArgs e)
    {
      if (theTree().SelectedNode != null)
      {
        theTree().SelectedNode = ((DemoNode)theTree().SelectedNode).MoveForward();
      }
    }

    private void button3_Click(object sender, EventArgs e)
    {
      theTree().SelectedNode = ((DemoNode)theTree().SelectedNode).MoveBackward();
    }

    private void tabControlExample_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (tabControlExample.SelectedTab == tabSource)
      {
        SourceFile = CodeFile(theTree().SelectedNode);
        var path = Utils.CodePath();

        buttonConfig.Visible = path == "";

        if ((SourceFile != "") && (path != ""))
        {
          if (!SourceFile.Equals(OldSourceFile))
          {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
              var sc = new SourceControl(richTextBox1);
              sc.LoadTextFromFile(path + SourceFile);
              //statusBar1.Panels[0].Text = SourceFile;
            }
            finally
            {
              Cursor.Current = Cursors.Default;
            }
            OldSourceFile = SourceFile;
          }
        }
      }
      else if (tabControlExample.SelectedTab == tabWeb)
      {
        if ((theTree().SelectedNode != null) && (((DemoFormInfo)theTree().SelectedNode.Tag).formtype != null))
        {
          OpenWebPage("ABOUT:Loading page from Steema.com ...");
          //string URLAddress = "http://www.Steema.TeeChart.net/"+((DemoFormInfo)theTree().SelectedNode.Tag).formtype+".htm";
          var URLAddress = "http://www.teechart.net/support";
          OpenWebPage(URLAddress);
        }
        else
        {
          OpenWebPage("ABOUT:All information about TeeChart Pro at <A HREF=" + (char)34 + "http://www.teeChart.net" + (char)34 + ">www.teeChart.net</A>");
        }
      }
    }

    private void buttonConfig_Click(object sender, EventArgs e)
    {
      var ds = new DirectorySelect();
      if (ds.ShowDialog() == DialogResult.OK)
      {
        Utils.WriteCodePath(ds.ReturnPath + "\\");
        tabControlExample_SelectedIndexChanged(tabControlExample, new EventArgs());
      }
    }

    private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (tabControl1.SelectedTab == tabSearch)
      {
        checkBoxFindSource.Enabled = Utils.CodePath() != "";
        if (!checkBoxFindSource.Enabled)
        {
          checkBoxFindSource.Checked = false;
        }
      }
      else
      {
        theTree().Select();
        treeView1_AfterSelect(theTree(), new TreeViewEventArgs(theTree().SelectedNode));
      }
    }

    private void comboBoxSearch_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyValue == (char)13)
      {
        DoSearch();
      }
    }

    private void comboBoxSearch_TextChanged(object sender, EventArgs e)
    {
      buttonSearch.Enabled = comboBoxSearch.Text != "";
    }

    private void buttonSearch_Click(object sender, EventArgs e)
    {
      DoSearch();
    }

    private void treeView1_BeforeCollapse(object sender, TreeViewCancelEventArgs e)
    {
      e.Node.ImageIndex = 0;
      e.Node.SelectedImageIndex = 0;
    }

    private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
    {
      e.Node.ImageIndex = 1;
      e.Node.SelectedImageIndex = 1;
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      timer1.Stop();
      try
      {
      }
      finally
      {
        timer1.Start();
      }
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
#if TEELITE
      tChart2.Header.Text="TeeChart Lite for .NET Examples";
#endif

#if CHINESE
      Languages.ChineseSimp.Activate();
#endif

      theTree().Select();
#if DEBUG
      timer1.Enabled = false;
#endif
    }

    private void ShowFullNode(TreeNode n)
    {
#if DEBUG
      Console.WriteLine(n.Text);
#endif
      n.TreeView.SelectedNode = n;
      n.EnsureVisible();
      Application.DoEvents();
      foreach (TreeNode nn in n.Nodes)
      {
        ShowFullNode(nn);
      }
    }

    private void menuItem1_Click(object sender, EventArgs e)
    {
      foreach (TreeNode n in theTree().Nodes)
      {
        ShowFullNode(n);
      }
    }

    private void buttonSearch_Click_1(object sender, EventArgs e)
    {
      DoSearch();
    }

    private void butGo_Click(object sender, EventArgs e)
    {
      var st = tbNodePath.Text.Split(new char[] { '\\' });
      DemoNode n = null;
      var NodeCount = theTree().GetNodeCount(true);
      if (NodeCount > 0)
      {
        n = (DemoNode)theTree().Nodes[0];
      }

      for (var t = 0; t < NodeCount; t++)
      {
        if (n.Text == st[st.Length - 1])
        {
          theTree().SelectedNode = n;
        }
        else
        {
          n = (DemoNode)n.MoveForward();
        }
      }

    }

    private void panel1_Paint(object sender, PaintEventArgs e)
    {

    }

    private void tbNodePath_TextChanged(object sender, EventArgs e)
    {

    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }

    private void tabControl1_MouseClick(object sender, MouseEventArgs e)
    {
      if (e.Button == MouseButtons.Right)
      {
        foreach (TreeNode n in theTree().Nodes)
          ShowFullNode(n);
      }
    }

    //    private CanvasType canvasType;
    //
    //    private void menuGDI_Click(object sender, EventArgs e)
    //    {
    //      canvasType = CanvasType.GDI;
    //    }
    //
    //    private void menuGDIPlus_Click(object sender, EventArgs e)
    //    {
    //      canvasType = CanvasType.GDIPlus;
    //    }
    //
    //    private void menuOpenGL_Click(object sender, EventArgs e)
    //    {
    //      canvasType = CanvasType.OpenGL;
    //    }

    //private void contextMenu1_Popup(object sender, EventArgs e)
    //{
    //  menuGDI.Checked = false;
    //  menuGDIPlus.Checked = false;
    //  menuOpenGL.Checked = false;
    //  switch(canvasType) 
    //  {
    //    case CanvasType.GDI:
    //      menuGDI.Checked = true;
    //      break;
    //    case CanvasType.GDIPlus:
    //      menuGDIPlus.Checked = true;
    //      break;
    //    case CanvasType.OpenGL:
    //      menuOpenGL.Checked = true;
    //      break;
    //  }
    //}
  }

  public enum CanvasType
  {
    GDI,
    GDIPlus,
    OpenGL
  }
}
