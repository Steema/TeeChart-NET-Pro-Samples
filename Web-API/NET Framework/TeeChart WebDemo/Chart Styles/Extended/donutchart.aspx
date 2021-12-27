<%@ Page language="c#" Inherits="WebDemo.Chart_Styles.Extended.DonutChart" CodeFile="DonutChart.aspx.cs" %>
<%@ Register TagPrefix="tchart" Namespace="Steema.TeeChart.Web" Assembly="TeeChart" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>DonutChart</title>
		<LINK href="..\..\Styles\ContentStyles.css" type="text/css" rel="stylesheet">
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<asp:label id="Label1" style="Z-INDEX: 102; LEFT: 640px; POSITION: absolute; TOP: 64px" runat="server">% Hole :</asp:label><asp:button id="Button2" style="Z-INDEX: 101; LEFT: 753px; POSITION: absolute; TOP: 60px" runat="server"
				Text="Go !" onclick="Button2_Click"></asp:button>
            <tchart:webchart id="WebChart1" style="Z-INDEX: 103; LEFT: 24px; POSITION: absolute; TOP: 60px; height:400px; width:600px;" runat="server"
				AutoPostback="False" TempChart="Httphandler" Config="AAEAAAD/////AQAAAAAAAAAMAgAAAFFUZWVDaGFydCwgVmVyc2lvbj00LjEuMjAxNy42MjkwLCBDdWx0dXJlPW5ldXRyYWwsIFB1YmxpY0tleVRva2VuPTljODEyNjI3NmM3N2JkYjcMAwAAAFFTeXN0ZW0uRHJhd2luZywgVmVyc2lvbj00LjAuMC4wLCBDdWx0dXJlPW5ldXRyYWwsIFB1YmxpY0tleVRva2VuPWIwM2Y1ZjdmMTFkNTBhM2EFAQAAABVTdGVlbWEuVGVlQ2hhcnQuQ2hhcnQoAAAADC5DYW5jZWxNb3VzZQ0uQ3VycmVudFRoZW1lEC5DdXN0b21DaGFydFJlY3QSLlBhbmVsLkJldmVsLk91dGVyHS5QYW5lbC5CcnVzaC5HcmFkaWVudC5WaXNpYmxlEi5QYW5lbC5CcnVzaC5Db2xvchEuTGVnZW5kLkZvbnQuU2l6ZRYuTGVnZW5kLkZvbnQuU2l6ZUZsb2F0GC5MZWdlbmQuRm9udC5CcnVzaC5Db2xvchYuTGVnZW5kLlNoYWRvdy5WaXNpYmxlEy5MZWdlbmQuUGVuLlZpc2libGURLkhlYWRlci5Gb250LlNpemUWLkhlYWRlci5Gb250LlNpemVGbG9hdBguSGVhZGVyLkZvbnQuQnJ1c2guQ29sb3IPLkhlYWRlci5WaXNpYmxlGS5Bc3BlY3QuQ29sb3JQYWxldHRlSW5kZXgOLkFzcGVjdC5WaWV3M0QZLldhbGxzLkJhY2suQnJ1c2guVmlzaWJsZRMuV2FsbHMuQmFjay5WaXNpYmxlGy5BeGVzLkxlZnQuTGFiZWxzLkZvbnQuU2l6ZSAuQXhlcy5MZWZ0LkxhYmVscy5Gb250LlNpemVGbG9hdCIuQXhlcy5MZWZ0LkxhYmVscy5Gb250LkJydXNoLkNvbG9yGS5BeGVzLkxlZnQuR3JpZC5EcmF3RXZlcnkaLkF4ZXMuTGVmdC5UaXRsZS5Gb250LlNpemUfLkF4ZXMuTGVmdC5UaXRsZS5Gb250LlNpemVGbG9hdCEuQXhlcy5MZWZ0LlRpdGxlLkZvbnQuQnJ1c2guQ29sb3IaLkF4ZXMuVG9wLkxhYmVscy5Gb250LlNpemUfLkF4ZXMuVG9wLkxhYmVscy5Gb250LlNpemVGbG9hdCEuQXhlcy5Ub3AuTGFiZWxzLkZvbnQuQnJ1c2guQ29sb3IcLkF4ZXMuUmlnaHQuTGFiZWxzLkZvbnQuU2l6ZSEuQXhlcy5SaWdodC5MYWJlbHMuRm9udC5TaXplRmxvYXQjLkF4ZXMuUmlnaHQuTGFiZWxzLkZvbnQuQnJ1c2guQ29sb3IdLkF4ZXMuQm90dG9tLkxhYmVscy5Gb250LlNpemUiLkF4ZXMuQm90dG9tLkxhYmVscy5Gb250LlNpemVGbG9hdCQuQXhlcy5Cb3R0b20uTGFiZWxzLkZvbnQuQnJ1c2guQ29sb3IbLkF4ZXMuQm90dG9tLkdyaWQuRHJhd0V2ZXJ5HC5BeGVzLkJvdHRvbS5UaXRsZS5Gb250LlNpemUhLkF4ZXMuQm90dG9tLlRpdGxlLkZvbnQuU2l6ZUZsb2F0Iy5BeGVzLkJvdHRvbS5UaXRsZS5Gb250LkJydXNoLkNvbG9yDy5BeGVzLkF1dG9tYXRpYwAEAAQABAAABAAAAAAEAAAAAAAAAAQAAAAEAAAEAAAEAAAEAAAABAABGVN0ZWVtYS5UZWVDaGFydC5UaGVtZVR5cGUCAAAAASNTdGVlbWEuVGVlQ2hhcnQuRHJhd2luZy5CZXZlbFN0eWxlcwIAAAABFFN5c3RlbS5EcmF3aW5nLkNvbG9yAwAAAAgLFFN5c3RlbS5EcmF3aW5nLkNvbG9yAwAAAAEBCAsUU3lzdGVtLkRyYXdpbmcuQ29sb3IDAAAAAQgBAQEICxRTeXN0ZW0uRHJhd2luZy5Db2xvcgMAAAAICAsUU3lzdGVtLkRyYXdpbmcuQ29sb3IDAAAACAsUU3lzdGVtLkRyYXdpbmcuQ29sb3IDAAAACAsUU3lzdGVtLkRyYXdpbmcuQ29sb3IDAAAACAsUU3lzdGVtLkRyYXdpbmcuQ29sb3IDAAAACAgLFFN5c3RlbS5EcmF3aW5nLkNvbG9yAwAAAAECAAAAAAX8////GVN0ZWVtYS5UZWVDaGFydC5UaGVtZVR5cGUBAAAAB3ZhbHVlX18ACAIAAAAQAAAAAAX7////I1N0ZWVtYS5UZWVDaGFydC5EcmF3aW5nLkJldmVsU3R5bGVzAQAAAAd2YWx1ZV9fAAgCAAAAAAAAAAAF+v///xRTeXN0ZW0uRHJhd2luZy5Db2xvcgQAAAAEbmFtZQV2YWx1ZQprbm93bkNvbG9yBXN0YXRlAQAAAAkHBwMAAAAK/////wAAAAAAAAIACQAAAAAAEEEB+f////r///8KQEBA/wAAAAAAAAIAAAAMAAAAAABAQQH4////+v///woAAAAAAAAAAE4AAQAAFAAAAAAAAAkAAAAAABBBAff////6////CgAAAAAAAAAATgABAAIAAAALAAAAAAAwQQH2////+v///wpAQED/AAAAAAAAAgAJAAAAAAAQQQH1////+v///wpAQED/AAAAAAAAAgAJAAAAAAAQQQH0////+v///wpAQED/AAAAAAAAAgAJAAAAAAAQQQHz////+v///wqAgID/AAAAAAAAAgACAAAACwAAAAAAMEEB8v////r///8KQEBA/wAAAAAAAAIAAQs="
				Height="400px" Width="600px" GetChartFile="/TeeChartForNET/GetChart.aspx" LastFileName="" CurrentTheme="Report"></tchart:webchart><asp:label id="Label3" style="Z-INDEX: 104; LEFT: 640px; POSITION: absolute; TOP: 16px" runat="server"
				Height="36px" Width="584px">Donut Chart Style</asp:label>
			<asp:textbox id="TextBox1" style="Z-INDEX: 106; LEFT: 707px; POSITION: absolute; TOP: 60px" runat="server"
				Width="34px">50</asp:textbox></form>
	</body>
</HTML>
