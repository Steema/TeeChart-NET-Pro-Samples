<%@ Register TagPrefix="tchart" Namespace="Steema.TeeChart.Web" Assembly="TeeChart" %>
<%@ Page language="c#" Inherits="WebDemo.Chart_Styles.Extended.TowerChart" CodeFile="TowerChart.aspx.cs" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>TowerChart</title>
		<LINK href="..\..\Styles\ContentStyles.css" type="text/css" rel="stylesheet">
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<asp:label id="Label1" style="Z-INDEX: 102; LEFT: 683px; POSITION: absolute; TOP: 68px;" runat="server">Style :</asp:label><asp:dropdownlist id="DropDownList1" style="Z-INDEX: 101; LEFT: 738px; POSITION: absolute; TOP: 64px"
				runat="server" AutoPostBack="True" Width="98px">
				<asp:ListItem Value="Cube" Selected="True">Cube</asp:ListItem>
				<asp:ListItem Value="Rectangle">Rectangle</asp:ListItem>
				<asp:ListItem Value="Cover">Cover</asp:ListItem>
				<asp:ListItem Value="Cylinder">Cylinder</asp:ListItem>
				<asp:ListItem Value="Arrow">Arrow</asp:ListItem>
				<asp:ListItem Value="Cone">Cone</asp:ListItem>
			</asp:dropdownlist>
            <tchart:webchart id="WebChart1" style="Z-INDEX: 103; LEFT: 24px; POSITION: absolute; TOP: 60px; width:640px; height:500px;" runat="server"
				Width="642px" Height="500px" AutoPostback="False" TempChart="Httphandler" Config="AAEAAAD/////AQAAAAAAAAAMAgAAAFFUZWVDaGFydCwgVmVyc2lvbj00LjEuMjAxNy42MjkwLCBDdWx0dXJlPW5ldXRyYWwsIFB1YmxpY0tleVRva2VuPTljODEyNjI3NmM3N2JkYjcMAwAAAFFTeXN0ZW0uRHJhd2luZywgVmVyc2lvbj00LjAuMC4wLCBDdWx0dXJlPW5ldXRyYWwsIFB1YmxpY0tleVRva2VuPWIwM2Y1ZjdmMTFkNTBhM2EFAQAAABVTdGVlbWEuVGVlQ2hhcnQuQ2hhcnQ+AAAADC5DYW5jZWxNb3VzZQ0uQ3VycmVudFRoZW1lEC5DdXN0b21DaGFydFJlY3QXLlBhbmVsLkltYWdlQmV2ZWwuV2lkdGgdLlBhbmVsLkltYWdlQmV2ZWwuUGVuLlZpc2libGUdLlBhbmVsLkltYWdlQmV2ZWwuQnJ1c2guQ29sb3IVLlBhbmVsLkJldmVsLkNvbG9yT25lGy5QYW5lbC5CZXZlbC5TdHJpbmdDb2xvck9uZRUuUGFuZWwuQmV2ZWwuQ29sb3JUd28bLlBhbmVsLkJldmVsLlN0cmluZ0NvbG9yVHdvEi5QYW5lbC5CZXZlbC5PdXRlch0uUGFuZWwuQnJ1c2guR3JhZGllbnQuVmlzaWJsZRIuUGFuZWwuQnJ1c2guQ29sb3IRLkxlZ2VuZC5Gb250LlNpemUWLkxlZ2VuZC5Gb250LlNpemVGbG9hdBguTGVnZW5kLkZvbnQuQnJ1c2guQ29sb3IWLkxlZ2VuZC5TaGFkb3cuVmlzaWJsZQ8uTGVnZW5kLlZpc2libGUNLkhlYWRlci5MaW5lcxEuSGVhZGVyLkZvbnQuU2l6ZRYuSGVhZGVyLkZvbnQuU2l6ZUZsb2F0GC5IZWFkZXIuRm9udC5CcnVzaC5Db2xvcg8uSGVhZGVyLlZpc2libGUQLkFzcGVjdC5Sb3RhdGlvbhUuQXNwZWN0LlJvdGF0aW9uRmxvYXQSLkFzcGVjdC5PcnRob2dvbmFsES5Bc3BlY3QuWm9vbUZsb2F0DC5Bc3BlY3QuWm9vbRMuQXNwZWN0LlBlcnNwZWN0aXZlFi5Bc3BlY3QuQ2hhcnQzRFBlcmNlbnQSLkFzcGVjdC5WZXJ0T2Zmc2V0Fy5Bc3BlY3QuVmVydE9mZnNldEZsb2F0GS5XYWxscy5CYWNrLkJydXNoLlZpc2libGUTLldhbGxzLkJhY2suVmlzaWJsZQ4uV2FsbHMuVmlzaWJsZRsuQXhlcy5MZWZ0LkxhYmVscy5Gb250LlNpemUgLkF4ZXMuTGVmdC5MYWJlbHMuRm9udC5TaXplRmxvYXQiLkF4ZXMuTGVmdC5MYWJlbHMuRm9udC5CcnVzaC5Db2xvchguQXhlcy5MZWZ0LkF4aXNQZW4uQ29sb3IZLkF4ZXMuTGVmdC5HcmlkLkRyYXdFdmVyeRcuQXhlcy5MZWZ0LkdyaWQuVmlzaWJsZRouQXhlcy5MZWZ0LlRpdGxlLkZvbnQuU2l6ZR8uQXhlcy5MZWZ0LlRpdGxlLkZvbnQuU2l6ZUZsb2F0IS5BeGVzLkxlZnQuVGl0bGUuRm9udC5CcnVzaC5Db2xvchsuQXhlcy5MZWZ0LlJlbGF0aXZlUG9zaXRpb24aLkF4ZXMuVG9wLkxhYmVscy5Gb250LlNpemUfLkF4ZXMuVG9wLkxhYmVscy5Gb250LlNpemVGbG9hdCEuQXhlcy5Ub3AuTGFiZWxzLkZvbnQuQnJ1c2guQ29sb3IRLkF4ZXMuVG9wLlZpc2libGUcLkF4ZXMuUmlnaHQuTGFiZWxzLkZvbnQuU2l6ZSEuQXhlcy5SaWdodC5MYWJlbHMuRm9udC5TaXplRmxvYXQjLkF4ZXMuUmlnaHQuTGFiZWxzLkZvbnQuQnJ1c2guQ29sb3ITLkF4ZXMuUmlnaHQuVmlzaWJsZR0uQXhlcy5Cb3R0b20uTGFiZWxzLkZvbnQuU2l6ZSIuQXhlcy5Cb3R0b20uTGFiZWxzLkZvbnQuU2l6ZUZsb2F0JC5BeGVzLkJvdHRvbS5MYWJlbHMuRm9udC5CcnVzaC5Db2xvchsuQXhlcy5Cb3R0b20uR3JpZC5EcmF3RXZlcnkcLkF4ZXMuQm90dG9tLlRpdGxlLkZvbnQuU2l6ZSEuQXhlcy5Cb3R0b20uVGl0bGUuRm9udC5TaXplRmxvYXQjLkF4ZXMuQm90dG9tLlRpdGxlLkZvbnQuQnJ1c2guQ29sb3IULkF4ZXMuQm90dG9tLlZpc2libGUPLkF4ZXMuQXV0b21hdGljAAQAAAAEBAEEAQQABAAABAAABgAABAAAAAAAAAAAAAAAAAAAAAQEAAAAAAQAAAAEAAAABAAAAAQAAAAEAAABGVN0ZWVtYS5UZWVDaGFydC5UaGVtZVR5cGUCAAAAAQgBFFN5c3RlbS5EcmF3aW5nLkNvbG9yAwAAABRTeXN0ZW0uRHJhd2luZy5Db2xvcgMAAAAUU3lzdGVtLkRyYXdpbmcuQ29sb3IDAAAAI1N0ZWVtYS5UZWVDaGFydC5EcmF3aW5nLkJldmVsU3R5bGVzAgAAAAEUU3lzdGVtLkRyYXdpbmcuQ29sb3IDAAAACAsUU3lzdGVtLkRyYXdpbmcuQ29sb3IDAAAAAQEICxRTeXN0ZW0uRHJhd2luZy5Db2xvcgMAAAABCAYBBggICAgGAQEBCAsUU3lzdGVtLkRyYXdpbmcuQ29sb3IDAAAAFFN5c3RlbS5EcmF3aW5nLkNvbG9yAwAAAAgBCAsUU3lzdGVtLkRyYXdpbmcuQ29sb3IDAAAABggLFFN5c3RlbS5EcmF3aW5nLkNvbG9yAwAAAAEICxRTeXN0ZW0uRHJhd2luZy5Db2xvcgMAAAABCAsUU3lzdGVtLkRyYXdpbmcuQ29sb3IDAAAACAgLFFN5c3RlbS5EcmF3aW5nLkNvbG9yAwAAAAEBAgAAAAAF/P///xlTdGVlbWEuVGVlQ2hhcnQuVGhlbWVUeXBlAQAAAAd2YWx1ZV9fAAgCAAAAAAAAAAACAAAAAAX7////FFN5c3RlbS5EcmF3aW5nLkNvbG9yBAAAAARuYW1lBXZhbHVlCmtub3duQ29sb3IFc3RhdGUBAAAACQcHAwAAAAr/6Oj+AAAAAAAAAgAB+v////v///8KgAAA/gAAAAAAAAIABgcAAAAIRkUwMDAwODAB+P////v///8KgAAA/gAAAAAAAAIABgkAAAAIRkUwMDAwODAF9v///yNTdGVlbWEuVGVlQ2hhcnQuRHJhd2luZy5CZXZlbFN0eWxlcwEAAAAHdmFsdWVfXwAIAgAAAAAAAAAAAfX////7////Cv////8AAAAAAAACAAkAAAAAABBBAfT////7////CkBAQP8AAAAAAAACAAAACQ0AAAAMAAAAAABAQQHy////+////woAAAAAAAAAAE4AAQAAPgEAAAAAAAAA4HNAAAAAAAAAwFNATwAAAEMAAABQAAAA2////wAAAAAAgELAAAAACQAAAAAAEEEB8f////v///8KAAAAAAAAAABOAAEAAfD////7////CsDAwP8AAAAAAAACAAIAAAAACwAAAAAAMEEB7/////v///8KQEBA/wAAAAAAAAIAAAAAAAAAFMAJAAAAAAAQQQHu////+////wpAQED/AAAAAAAAAgAACQAAAAAAEEEB7f////v///8KQEBA/wAAAAAAAAIAAAkAAAAAABBBAez////7////CoCAgP8AAAAAAAACAAIAAAALAAAAAAAwQQHr////+////wpAQED/AAAAAAAAAgAAARENAAAAAQAAAAYWAAAAEVRvd2VyIENoYXJ0IFN0eWxlCw==" GetChartFile="/TeeChartForNET/GetChart.aspx" LastFileName="" BorderStyle="None"></tchart:webchart>
            <asp:label id="Label3" style="Z-INDEX: 104; LEFT: 28px; POSITION: absolute; TOP: 16px" runat="server"
				Width="584px" Height="36px">Tower Chart Style</asp:label>
			<asp:checkbox id="CheckBox1" style="Z-INDEX: 106; LEFT: 680px; POSITION: absolute; TOP: 112px"
				runat="server" AutoPostBack="True" Width="134px" Checked="True" Text="Use Origin"></asp:checkbox></form>
	</body>
</HTML>
