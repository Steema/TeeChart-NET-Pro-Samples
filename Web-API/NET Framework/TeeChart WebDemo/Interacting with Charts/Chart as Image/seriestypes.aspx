<%@ Page language="c#" Inherits="WebDemo.Interacting_with_Charts.Chart_as_Image.SeriesTypes" CodeFile="SeriesTypes.aspx.cs" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>Series Types</title>
		<LINK href="..\..\Styles\ContentStyles.css" type="text/css" rel="stylesheet">
		<meta name="GENERATOR" Content="Microsoft Visual Studio 7.0">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<asp:image id="Image1" style="Z-INDEX: 100; LEFT: 12px; POSITION: absolute; TOP: 36px" runat="server"
				Width="400px" Height="300px"></asp:image>
			<asp:label id="Label1" style="Z-INDEX: 107; LEFT: 12px; POSITION: absolute; TOP: 344px" runat="server"
				Height="64px" Width="528px">Select a Chart type from the list to see a sample appear on the browser as a PNG image. The Chart images are created serverside by TeeChart.NET, written in 100% C#.NET code.</asp:label>
			<asp:label id="Label4" style="Z-INDEX: 106; LEFT: 16px; POSITION: absolute; TOP: 12px" runat="server"
				Height="20px" Width="584px">This sample shows how the use of the Chart as an Image.</asp:label>
			<asp:button id="Button1" style="Z-INDEX: 101; LEFT: 432px; POSITION: absolute; TOP: 76px" runat="server"
				Width="115px" Height="32px" Text="Refresh Chart" onclick="Button1_Click"></asp:button>
			<HR style="Z-INDEX: 102; LEFT: 16px; POSITION: absolute; TOP: 420px; HEIGHT: 2px" width="100%"
				SIZE="2">
			<asp:dropdownlist id="DropDownList1" style="Z-INDEX: 103; LEFT: 432px; POSITION: absolute; TOP: 48px"
				runat="server" Width="115px" Height="28px" onselectedindexchanged="DropDownList1_SelectedIndexChanged">
				<asp:ListItem Value="Line" Selected="True">Line</asp:ListItem>
				<asp:ListItem Value="Bar">Bar</asp:ListItem>
				<asp:ListItem Value="HorizBar">HorizBar</asp:ListItem>
				<asp:ListItem Value="Area">Area</asp:ListItem>
				<asp:ListItem Value="Point">Point</asp:ListItem>
				<asp:ListItem Value="Surface">Surface</asp:ListItem>
			</asp:dropdownlist>
			<asp:CheckBox id="CheckBox1" style="Z-INDEX: 104; LEFT: 560px; POSITION: absolute; TOP: 48px"
				runat="server" Width="84px" Height="19px" Text="View 3D" Font-Names="Arial" Font-Size="10pt"
				Checked="True"></asp:CheckBox>
		</form>
	</body>
</HTML>
