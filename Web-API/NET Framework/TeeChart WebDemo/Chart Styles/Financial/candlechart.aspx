<%@ Page language="c#" Inherits="WebDemo.Chart_Styles.Financial.CandleChart" CodeFile="CandleChart.aspx.cs" %>
<%@ Register TagPrefix="tchart" Namespace="Steema.TeeChart.Web" Assembly="TeeChart" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>CandleChart</title>
		<LINK href="..\..\Styles\ContentStyles.css" type="text/css" rel="stylesheet">
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<tchart:WebChart id="WebChart1" style="Z-INDEX: 101; LEFT: 24px; POSITION: absolute; TOP: 60px; width:632px; height:290px;" runat="server"
				Width="632px" Height="290px" Config="AAEAAAD/////AQAAAAAAAAAMAgAAAFFUZWVDaGFydCwgVmVyc2lvbj00LjEuMjAxNy42MjkwLCBDdWx0dXJlPW5ldXRyYWwsIFB1YmxpY0tleVRva2VuPTljODEyNjI3NmM3N2JkYjcMAwAAAFFTeXN0ZW0uRHJhd2luZywgVmVyc2lvbj00LjAuMC4wLCBDdWx0dXJlPW5ldXRyYWwsIFB1YmxpY0tleVRva2VuPWIwM2Y1ZjdmMTFkNTBhM2EFAQAAABVTdGVlbWEuVGVlQ2hhcnQuQ2hhcnQyAAAADC5DYW5jZWxNb3VzZQ0uQ3VycmVudFRoZW1lEC5DdXN0b21DaGFydFJlY3QXLlBhbmVsLkltYWdlQmV2ZWwuV2lkdGgdLlBhbmVsLkltYWdlQmV2ZWwuUGVuLlZpc2libGUdLlBhbmVsLkltYWdlQmV2ZWwuQnJ1c2guQ29sb3IVLlBhbmVsLkJldmVsLkNvbG9yT25lGy5QYW5lbC5CZXZlbC5TdHJpbmdDb2xvck9uZRUuUGFuZWwuQmV2ZWwuQ29sb3JUd28bLlBhbmVsLkJldmVsLlN0cmluZ0NvbG9yVHdvEi5QYW5lbC5CZXZlbC5PdXRlch0uUGFuZWwuQnJ1c2guR3JhZGllbnQuVmlzaWJsZRIuUGFuZWwuQnJ1c2guQ29sb3IRLkxlZ2VuZC5Gb250LlNpemUWLkxlZ2VuZC5Gb250LlNpemVGbG9hdBguTGVnZW5kLkZvbnQuQnJ1c2guQ29sb3IWLkxlZ2VuZC5TaGFkb3cuVmlzaWJsZQ0uSGVhZGVyLkxpbmVzES5IZWFkZXIuRm9udC5TaXplFi5IZWFkZXIuRm9udC5TaXplRmxvYXQYLkhlYWRlci5Gb250LkJydXNoLkNvbG9yDy5IZWFkZXIuVmlzaWJsZQ4uQXNwZWN0LlZpZXczRBkuV2FsbHMuQmFjay5CcnVzaC5WaXNpYmxlEy5XYWxscy5CYWNrLlZpc2libGUbLkF4ZXMuTGVmdC5MYWJlbHMuRm9udC5TaXplIC5BeGVzLkxlZnQuTGFiZWxzLkZvbnQuU2l6ZUZsb2F0Ii5BeGVzLkxlZnQuTGFiZWxzLkZvbnQuQnJ1c2guQ29sb3IZLkF4ZXMuTGVmdC5HcmlkLkRyYXdFdmVyeRguQXhlcy5MZWZ0Lk1heGltdW1PZmZzZXQaLkF4ZXMuTGVmdC5UaXRsZS5Gb250LlNpemUfLkF4ZXMuTGVmdC5UaXRsZS5Gb250LlNpemVGbG9hdCEuQXhlcy5MZWZ0LlRpdGxlLkZvbnQuQnJ1c2guQ29sb3IaLkF4ZXMuVG9wLkxhYmVscy5Gb250LlNpemUfLkF4ZXMuVG9wLkxhYmVscy5Gb250LlNpemVGbG9hdCEuQXhlcy5Ub3AuTGFiZWxzLkZvbnQuQnJ1c2guQ29sb3IRLkF4ZXMuVG9wLlZpc2libGUcLkF4ZXMuUmlnaHQuTGFiZWxzLkZvbnQuU2l6ZSEuQXhlcy5SaWdodC5MYWJlbHMuRm9udC5TaXplRmxvYXQjLkF4ZXMuUmlnaHQuTGFiZWxzLkZvbnQuQnJ1c2guQ29sb3ITLkF4ZXMuUmlnaHQuVmlzaWJsZR0uQXhlcy5Cb3R0b20uTGFiZWxzLkZvbnQuU2l6ZSIuQXhlcy5Cb3R0b20uTGFiZWxzLkZvbnQuU2l6ZUZsb2F0JC5BeGVzLkJvdHRvbS5MYWJlbHMuRm9udC5CcnVzaC5Db2xvchsuQXhlcy5Cb3R0b20uR3JpZC5EcmF3RXZlcnkaLkF4ZXMuQm90dG9tLk1heGltdW1PZmZzZXQcLkF4ZXMuQm90dG9tLlRpdGxlLkZvbnQuU2l6ZSEuQXhlcy5Cb3R0b20uVGl0bGUuRm9udC5TaXplRmxvYXQjLkF4ZXMuQm90dG9tLlRpdGxlLkZvbnQuQnJ1c2guQ29sb3IPLkF4ZXMuQXV0b21hdGljAAQAAAAEBAEEAQQABAAABAAGAAAEAAAAAAAABAAAAAAEAAAEAAAABAAAAAQAAAAABAABGVN0ZWVtYS5UZWVDaGFydC5UaGVtZVR5cGUCAAAAAQgBFFN5c3RlbS5EcmF3aW5nLkNvbG9yAwAAABRTeXN0ZW0uRHJhd2luZy5Db2xvcgMAAAAUU3lzdGVtLkRyYXdpbmcuQ29sb3IDAAAAI1N0ZWVtYS5UZWVDaGFydC5EcmF3aW5nLkJldmVsU3R5bGVzAgAAAAEUU3lzdGVtLkRyYXdpbmcuQ29sb3IDAAAACAsUU3lzdGVtLkRyYXdpbmcuQ29sb3IDAAAAAQgLFFN5c3RlbS5EcmF3aW5nLkNvbG9yAwAAAAEBAQEICxRTeXN0ZW0uRHJhd2luZy5Db2xvcgMAAAAICAgLFFN5c3RlbS5EcmF3aW5nLkNvbG9yAwAAAAgLFFN5c3RlbS5EcmF3aW5nLkNvbG9yAwAAAAEICxRTeXN0ZW0uRHJhd2luZy5Db2xvcgMAAAABCAsUU3lzdGVtLkRyYXdpbmcuQ29sb3IDAAAACAgICxRTeXN0ZW0uRHJhd2luZy5Db2xvcgMAAAABAgAAAAAF/P///xlTdGVlbWEuVGVlQ2hhcnQuVGhlbWVUeXBlAQAAAAd2YWx1ZV9fAAgCAAAAAAAAAAACAAAAAAX7////FFN5c3RlbS5EcmF3aW5nLkNvbG9yBAAAAARuYW1lBXZhbHVlCmtub3duQ29sb3IFc3RhdGUBAAAACQcHAwAAAAr/6Oj+AAAAAAAAAgAB+v////v///8KgAAA/gAAAAAAAAIABgcAAAAIRkUwMDAwODAB+P////v///8KgAAA/gAAAAAAAAIABgkAAAAIRkUwMDAwODAF9v///yNTdGVlbWEuVGVlQ2hhcnQuRHJhd2luZy5CZXZlbFN0eWxlcwEAAAAHdmFsdWVfXwAIAgAAAAAAAAAAAfX////7////Cv////8AAAAAAAACAAkAAAAAABBBAfT////7////CkBAQP8AAAAAAAACAAAJDQAAAAwAAAAAAEBBAfL////7////CgAAAAAAAAAATgABAAAAAAAJAAAAAAAQQQHx////+////woAAAAAAAAAAE4AAQACAAAALQAAAAsAAAAAADBBAfD////7////CkBAQP8AAAAAAAACAAkAAAAAABBBAe/////7////CkBAQP8AAAAAAAACAAAJAAAAAAAQQQHu////+////wpAQED/AAAAAAAAAgAACQAAAAAAEEEB7f////v///8KgICA/wAAAAAAAAIAAgAAAAgAAAALAAAAAAAwQQHs////+////wpAQED/AAAAAAAAAgABEQ0AAAABAAAABhUAAAASQ2FuZGxlIFNlcmllcyBUeXBlCw=="
				TempChart="Httphandler" AutoPostback="False" GetChartFile="/TeeChartForNET/GetChart.aspx" LastFileName=""></tchart:WebChart>
			<asp:Label id="Label3" style="Z-INDEX: 102; LEFT: 28px; POSITION: absolute; TOP: 16px" runat="server"
				Width="584px" Height="36px"> Candle Series Type</asp:Label>
			<asp:Button id="Button1" style="Z-INDEX: 104; LEFT: 672px; POSITION: absolute; TOP: 156px" runat="server"
				Text="Update Chart" BackColor="White" BorderStyle="Solid"></asp:Button>
			<asp:Label id="Label1" style="Z-INDEX: 105; LEFT: 672px; POSITION: absolute; TOP: 120px" runat="server"
				Height="8px">Style :</asp:Label>
			<asp:DropDownList id="DropDownList1" style="Z-INDEX: 106; LEFT: 724px; POSITION: absolute; TOP: 116px"
				runat="server" AutoPostBack="True" onselectedindexchanged="DropDownList1_SelectedIndexChanged">
				<asp:ListItem Value="Stick" Selected="True">Stick</asp:ListItem>
				<asp:ListItem Value="Bar">Bar</asp:ListItem>
				<asp:ListItem Value="Open-Close">Open-Close</asp:ListItem>
			</asp:DropDownList>
			<asp:CheckBox id="CheckBox1" style="Z-INDEX: 107; LEFT: 668px; POSITION: absolute; TOP: 64px"
				runat="server" Width="114px" Text="Border" AutoPostBack="True" Checked="True" oncheckedchanged="CheckBox1_CheckedChanged"></asp:CheckBox>
			<asp:CheckBox id="CheckBox2" style="Z-INDEX: 108; LEFT: 668px; POSITION: absolute; TOP: 88px"
				runat="server" Width="106px" Text="Draw 3D" AutoPostBack="True" oncheckedchanged="CheckBox2_CheckedChanged"></asp:CheckBox>
		</form>
	</body>
</HTML>
