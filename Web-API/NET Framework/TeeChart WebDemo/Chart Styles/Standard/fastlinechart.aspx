<%@ Register TagPrefix="tchart" Namespace="Steema.TeeChart.Web" Assembly="TeeChart" %>
<%@ Page language="c#" Inherits="WebDemo.Chart_Styles.Standard.FastLineChart" CodeFile="FastLineChart.aspx.cs" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>FastLineChart</title>
		<LINK href="..\..\Styles\ContentStyles.css" type="text/css" rel="stylesheet">
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<tchart:WebChart id="WebChart1" 
                style="Z-INDEX: 100; LEFT: 24px; POSITION: absolute; TOP: 60px; width:640px; height:400;" runat="server" Height="400px" Config="AAEAAAD/////AQAAAAAAAAAMAgAAAFFUZWVDaGFydCwgVmVyc2lvbj00LjEuMjAxNy42MjkwLCBDdWx0dXJlPW5ldXRyYWwsIFB1YmxpY0tleVRva2VuPTljODEyNjI3NmM3N2JkYjcMAwAAAFFTeXN0ZW0uRHJhd2luZywgVmVyc2lvbj00LjAuMC4wLCBDdWx0dXJlPW5ldXRyYWwsIFB1YmxpY0tleVRva2VuPWIwM2Y1ZjdmMTFkNTBhM2EFAQAAABVTdGVlbWEuVGVlQ2hhcnQuQ2hhcnQwAAAADC5DYW5jZWxNb3VzZQ0uQ3VycmVudFRoZW1lEC5DdXN0b21DaGFydFJlY3QXLlBhbmVsLkltYWdlQmV2ZWwuV2lkdGgdLlBhbmVsLkltYWdlQmV2ZWwuUGVuLlZpc2libGUdLlBhbmVsLkltYWdlQmV2ZWwuQnJ1c2guQ29sb3IVLlBhbmVsLkJldmVsLkNvbG9yT25lGy5QYW5lbC5CZXZlbC5TdHJpbmdDb2xvck9uZRUuUGFuZWwuQmV2ZWwuQ29sb3JUd28bLlBhbmVsLkJldmVsLlN0cmluZ0NvbG9yVHdvHS5QYW5lbC5CcnVzaC5HcmFkaWVudC5WaXNpYmxlEi5QYW5lbC5CcnVzaC5Db2xvchEuTGVnZW5kLkZvbnQuU2l6ZRYuTGVnZW5kLkZvbnQuU2l6ZUZsb2F0GC5MZWdlbmQuRm9udC5CcnVzaC5Db2xvchYuTGVnZW5kLlNoYWRvdy5WaXNpYmxlDy5MZWdlbmQuVmlzaWJsZQ0uSGVhZGVyLkxpbmVzES5IZWFkZXIuRm9udC5TaXplFi5IZWFkZXIuRm9udC5TaXplRmxvYXQYLkhlYWRlci5Gb250LkJydXNoLkNvbG9yGS5Bc3BlY3QuQ29sb3JQYWxldHRlSW5kZXgOLkFzcGVjdC5WaWV3M0QZLldhbGxzLkJhY2suQnJ1c2guVmlzaWJsZRMuV2FsbHMuQmFjay5WaXNpYmxlGy5BeGVzLkxlZnQuTGFiZWxzLkZvbnQuU2l6ZSAuQXhlcy5MZWZ0LkxhYmVscy5Gb250LlNpemVGbG9hdCIuQXhlcy5MZWZ0LkxhYmVscy5Gb250LkJydXNoLkNvbG9yGS5BeGVzLkxlZnQuR3JpZC5EcmF3RXZlcnkYLkF4ZXMuTGVmdC5NYXhpbXVtT2Zmc2V0Gi5BeGVzLkxlZnQuVGl0bGUuRm9udC5TaXplHy5BeGVzLkxlZnQuVGl0bGUuRm9udC5TaXplRmxvYXQhLkF4ZXMuTGVmdC5UaXRsZS5Gb250LkJydXNoLkNvbG9yGi5BeGVzLlRvcC5MYWJlbHMuRm9udC5TaXplHy5BeGVzLlRvcC5MYWJlbHMuRm9udC5TaXplRmxvYXQhLkF4ZXMuVG9wLkxhYmVscy5Gb250LkJydXNoLkNvbG9yHC5BeGVzLlJpZ2h0LkxhYmVscy5Gb250LlNpemUhLkF4ZXMuUmlnaHQuTGFiZWxzLkZvbnQuU2l6ZUZsb2F0Iy5BeGVzLlJpZ2h0LkxhYmVscy5Gb250LkJydXNoLkNvbG9yHS5BeGVzLkJvdHRvbS5MYWJlbHMuRm9udC5TaXplIi5BeGVzLkJvdHRvbS5MYWJlbHMuRm9udC5TaXplRmxvYXQkLkF4ZXMuQm90dG9tLkxhYmVscy5Gb250LkJydXNoLkNvbG9yGy5BeGVzLkJvdHRvbS5HcmlkLkRyYXdFdmVyeRouQXhlcy5Cb3R0b20uTWF4aW11bU9mZnNldBwuQXhlcy5Cb3R0b20uVGl0bGUuRm9udC5TaXplIS5BeGVzLkJvdHRvbS5UaXRsZS5Gb250LlNpemVGbG9hdCMuQXhlcy5Cb3R0b20uVGl0bGUuRm9udC5CcnVzaC5Db2xvcg8uQXhlcy5BdXRvbWF0aWMABAAAAAQEAQQBAAQAAAQAAAYAAAQAAAAAAAAEAAAAAAQAAAQAAAQAAAQAAAAABAABGVN0ZWVtYS5UZWVDaGFydC5UaGVtZVR5cGUCAAAAAQgBFFN5c3RlbS5EcmF3aW5nLkNvbG9yAwAAABRTeXN0ZW0uRHJhd2luZy5Db2xvcgMAAAAUU3lzdGVtLkRyYXdpbmcuQ29sb3IDAAAAARRTeXN0ZW0uRHJhd2luZy5Db2xvcgMAAAAICxRTeXN0ZW0uRHJhd2luZy5Db2xvcgMAAAABAQgLFFN5c3RlbS5EcmF3aW5nLkNvbG9yAwAAAAgBAQEICxRTeXN0ZW0uRHJhd2luZy5Db2xvcgMAAAAICAgLFFN5c3RlbS5EcmF3aW5nLkNvbG9yAwAAAAgLFFN5c3RlbS5EcmF3aW5nLkNvbG9yAwAAAAgLFFN5c3RlbS5EcmF3aW5nLkNvbG9yAwAAAAgLFFN5c3RlbS5EcmF3aW5nLkNvbG9yAwAAAAgICAsUU3lzdGVtLkRyYXdpbmcuQ29sb3IDAAAAAQIAAAAABfz///8ZU3RlZW1hLlRlZUNoYXJ0LlRoZW1lVHlwZQEAAAAHdmFsdWVfXwAIAgAAABAAAAAAAgAAAAAF+////xRTeXN0ZW0uRHJhd2luZy5Db2xvcgQAAAAEbmFtZQV2YWx1ZQprbm93bkNvbG9yBXN0YXRlAQAAAAkHBwMAAAAK/+jo/gAAAAAAAAIAAfr////7////CoAAAP4AAAAAAAACAAYHAAAACEZFMDAwMDgwAfj////7////CoAAAP4AAAAAAAACAAYJAAAACEZFMDAwMDgwAAH2////+////wr/////AAAAAAAAAgAJAAAAAAAQQQH1////+////wpAQED/AAAAAAAAAgAAAAkMAAAADAAAAAAAQEEB8/////v///8KAAAAAAAAAABOAAEAFAAAAAAAAAkAAAAAABBBAfL////7////CgAAAAAAAAAATgABAAIAAAAIAAAACwAAAAAAMEEB8f////v///8KQEBA/wAAAAAAAAIACQAAAAAAEEEB8P////v///8KQEBA/wAAAAAAAAIACQAAAAAAEEEB7/////v///8KQEBA/wAAAAAAAAIACQAAAAAAEEEB7v////v///8KgICA/wAAAAAAAAIAAgAAAAgAAAALAAAAAAAwQQHt////+////wpAQED/AAAAAAAAAgABEQwAAAABAAAABhQAAAAORmFzdExpbmUgU3R5bGUL"
				TempChart="Httphandler" AutoPostback="False" 
                GetChartFile="/TeeChartForNET/GetChart.aspx" CurrentTheme="Report" LastFileName="" Width="640px" BorderStyle="None"></tchart:WebChart>
			<asp:CheckBox id="CBInverted" style="Z-INDEX: 105; LEFT: 676px; POSITION: absolute; TOP: 97px; height: 8px;"
				runat="server" Text="Inverted Stairs" Width="134px" AutoPostBack="True" oncheckedchanged="CBInverted_CheckedChanged"></asp:CheckBox>
			<asp:Label id="Label3" style="Z-INDEX: 101; LEFT: 28px; POSITION: absolute; TOP: 16px" runat="server"
				Width="584px" Height="36px">FastLine Style for high/fast volume data. It also supports null points and &quot;stairs&quot; mode.</asp:Label>
			<DIV style="Z-INDEX: 102; LEFT: 26px; WIDTH: 630px; POSITION: absolute; TOP: 376px; HEIGHT: 13px"></DIV>
			<asp:CheckBox id="CBStairs" style="Z-INDEX: 103; LEFT: 676px; POSITION: absolute; TOP: 65px" runat="server"
				Text="Stairs Mode" Width="134px" Checked="True" AutoPostBack="True" oncheckedchanged="CBStairs_CheckedChanged"></asp:CheckBox>
		</form>
	</body>
</HTML>
