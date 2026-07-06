using System;
using System.IO;
using System.Web;
using System.Drawing;
using Microsoft.Win32;
using System.Windows.Forms.Design;
using System.Windows.Forms;

namespace WebDemo.Codes
{
/*	public class DirectorySelect : FolderNameEditor 
	{
		private FolderBrowser m_fb = new FolderBrowser();
		private string m_description = "Select Folder";
		private string m_returnPath = string.Empty;

		public DirectorySelect() : base() {}

		public string Description 
		{
			get { return m_description; }
			set { m_description = value; }
		}

		public string ReturnPath 
		{
			get { return m_returnPath; }
		}

		public DialogResult RunDialog() 
		{
			m_fb.Description = m_description;
			m_fb.StartLocation = FolderBrowserFolder.Desktop;
			return m_fb.ShowDialog();
		}

		public DialogResult ShowDialog() 
		{
			DialogResult dr = RunDialog();
			if (dr == DialogResult.OK) 
				m_returnPath = m_fb.DirectoryPath;
			else 
				m_returnPath = string.Empty;
			return dr;
		} 
	}*/
	
	/// <summary>
	/// Loads and formats *.cs file 
	/// </summary>
	public class SourceControl : Object
	{
		private RichTextBox frtb;		
		private int p,len;
		private string txt;
		private bool fFormatText;


		public SourceControl(RichTextBox r) 
		{
			this.frtb = r;			
			this.fFormatText = true;
		}

		/// <summary>
		/// where to put formatted text ?
		/// </summary>
		public RichTextBox rtb
		{
			get { return frtb;}
			set { frtb = value;}
		}


		public bool FormatText
		{
			get { return fFormatText;}
			set { fFormatText = value;}
		}

		private bool IsKeyWord(string str)
		{
			string[] keywords = new string[] 
					{
						"abstract", "event", "new", "struct", "as", "explicit", "null", "switch",
						"base", "extern", "object", "this", "bool", "false", "operator", "throw", 
						"break", "finally", "out", "true", "byte", "fixed", "override", "try", 
						"case", "float", "params", "typeof", "catch", "for", "private", "uint",
						"char", "foreach", "protected", "ulong", "checked", "goto", "public", "unchecked", 
						"class", "if", "readonly", "unsafe", "const", "implicit", "ref", "ushort",
						"continue", "in", "return", "using", "decimal", "int", "sbyte", "virtual", 
						"default", "interface", "sealed", "volatile", "delegate", "internal", "short", "void",
						"do", "is", "sizeof", "while", "double", "lock", "stackalloc", "else", "long", "static",
						"enum", "namespace", "string"};

			bool res = false;
			foreach(string st in keywords)
			{
				if (st == str)
				{res = true; break;}
			}
			return res;
		}

		private string fontGreenStart="<Font Color=008000>";
		private string fontGreenEnd="</Font>";
			
		private void HighLightText(string endstring)
		{
			int sublen = endstring.Length;
			frtb.SelectionStart = p-sublen;
			while ((p<= len-sublen) && (!txt.Substring(p,sublen).Equals(endstring))) p++;
			frtb.SelectionLength = p + sublen - frtb.SelectionStart;

			frtb.SelectedText = fontGreenStart + frtb.SelectedText + fontGreenEnd;
			p=p+fontGreenStart.Length+fontGreenEnd.Length;
			len=len+fontGreenStart.Length+fontGreenEnd.Length;
			txt = frtb.Text;

			frtb.SelectionLength = 0;
			frtb.SelectionStart = 0;
		}
			
		private bool NextWordIsKeyword()
		{
			bool res = false;

			while (p <len)
			{
				if (Char.IsLetterOrDigit(txt[p])) break;
				else if ( (p< len -2) && (txt.Substring(p,2).Equals("//"))) HighLightText("\n");
				else if ( (p< len -2) && (txt.Substring(p,2).Equals("/*"))) HighLightText("*/");
				else p++;
			}

			int p2 = p;
			string Key;
			while ((p < len) && (Char.IsLetterOrDigit(txt[p]))) p++;

			if (p > p2)
			{
				Key = txt.Substring(p2,p-p2);
				res = IsKeyWord(Key);
				frtb.SelectionStart = p2;
				frtb.SelectionLength = p-p2;
				p++;
			}
			else res = false;
			return res;
		}

		private string fontBlueStart="<Font Color=0000FF>";
		private string fontBlueEnd="</Font>";

		private void FormatSourceText()
		{
			if (frtb != null)
			{
				txt = frtb.Text;
				len = frtb.Text.Length;
				p = 0;
				while (p < len)
					if (NextWordIsKeyword()) 
					{
						frtb.SelectedText = fontBlueStart + frtb.SelectedText + fontBlueEnd;
						p=p+fontBlueStart.Length+fontBlueEnd.Length;
						len=len+fontBlueStart.Length+fontBlueEnd.Length;

						txt = frtb.Text;
					}
				frtb.SelectionStart = 0;
				frtb.SelectionLength = 0;
			}
		}

		/// <summary>
		/// Load and format filemane.cs file
		/// </summary>
		/// <param name="filename"></param>
		public void LoadTextFromFile(string filename)
		{
			FileInfo fi = new FileInfo(filename);
			if ((fi.Exists) && (frtb != null))
			{
				frtb.Visible = false;
				frtb.SuspendLayout();
				try
				{
					frtb.Clear();
					frtb.LoadFile(filename,RichTextBoxStreamType.PlainText);
					if (fFormatText) FormatSourceText();
				}
				finally
				{
					frtb.Visible = true;
					frtb.ResumeLayout(true);
				}
			}
		}
	}
	
	public class Utils
	{
		private Utils() {}

		public static string TeeChartNETKey=@"Software\Steema Software\TeeChart.NET";
		public static string NetDemoKey=".NET Demo";

		/// <summary>
		/// Restores source code directory from registry
		/// </summary>
		/// <returns></returns>
		public static string CodePath()
		{
			const string ProjectName="TeeChart Examples.csproj";
			string result="";

			RegistryKey key = Registry.CurrentUser.CreateSubKey(Utils.TeeChartNETKey);
			if (key!=null)
			{
				RegistryKey rootPath = key.CreateSubKey(Utils.NetDemoKey);
				if (rootPath!=null)
				{
					object o=rootPath.GetValue("Demo Path");
					result= o==null ? "" : o.ToString(); 
				}
			}

			FileInfo fi = new FileInfo(result+ProjectName);
			if (!fi.Exists)
			{
				fi=new FileInfo(result+@"..\"+ProjectName);
				if (fi.Exists)
					result=result+@"..\";
				else
				{
					fi=new FileInfo(result+@"..\..\"+ProjectName);
					if (fi.Exists)
						result=result+@"..\..\";
				}
			}

			return result;
		}

		/// <summary>
		/// Stores source code directory to registry
		/// </summary>
		/// <param name="path"></param>
		public static void WriteCodePath(string path)
		{
			RegistryKey key = Registry.CurrentUser.CreateSubKey(Utils.TeeChartNETKey);
			if (key!=null)
			{
				RegistryKey rootPath = key.CreateSubKey(Utils.NetDemoKey);
				rootPath.SetValue("Demo Path",path);
			}
		}
	}
}