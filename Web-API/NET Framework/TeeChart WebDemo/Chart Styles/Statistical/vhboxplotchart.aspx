<%@ Register TagPrefix="tchart" Namespace="Steema.TeeChart.Web" Assembly="TeeChart" %>
<%@ Page language="c#" Inherits="WebDemo.Chart_Styles.Statistical.VHBoxPlotChart" CodeFile="VHBoxPlotChart.aspx.cs" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>VHBoxPlotChart</title>
		<LINK href="..\..\Styles\ContentStyles.css" type="text/css" rel="stylesheet">
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<asp:label id="Label1" style="Z-INDEX: 106; LEFT: 672px; POSITION: absolute; TOP: 68px" runat="server">Box Style :</asp:label>
			<tchart:WebChart id="WebChart1" style="Z-INDEX: 110; LEFT: 24px; POSITION: absolute; TOP: 64px; width:632px; height:400px;" runat="server"
				Width="632px" AutoPostback="False" TempChart="Httphandler" Config="AAEAAAD/////AQAAAAAAAAAMAgAAAFFUZWVDaGFydCwgVmVyc2lvbj00LjEuMjAxNy42MjkwLCBDdWx0dXJlPW5ldXRyYWwsIFB1YmxpY0tleVRva2VuPTljODEyNjI3NmM3N2JkYjcMAwAAAFFTeXN0ZW0uRHJhd2luZywgVmVyc2lvbj00LjAuMC4wLCBDdWx0dXJlPW5ldXRyYWwsIFB1YmxpY0tleVRva2VuPWIwM2Y1ZjdmMTFkNTBhM2EFAQAAABVTdGVlbWEuVGVlQ2hhcnQuQ2hhcnQsAAAADC5DYW5jZWxNb3VzZQ0uQ3VycmVudFRoZW1lEC5DdXN0b21DaGFydFJlY3QSLlBhbmVsLkJldmVsLk91dGVyHS5QYW5lbC5CcnVzaC5HcmFkaWVudC5WaXNpYmxlEi5QYW5lbC5CcnVzaC5Db2xvchEuTGVnZW5kLkZvbnQuU2l6ZRYuTGVnZW5kLkZvbnQuU2l6ZUZsb2F0GC5MZWdlbmQuRm9udC5CcnVzaC5Db2xvchYuTGVnZW5kLlNoYWRvdy5WaXNpYmxlEy5MZWdlbmQuUGVuLlZpc2libGURLkhlYWRlci5Gb250LlNpemUWLkhlYWRlci5Gb250LlNpemVGbG9hdBguSGVhZGVyLkZvbnQuQnJ1c2guQ29sb3IPLkhlYWRlci5WaXNpYmxlGS5Bc3BlY3QuQ29sb3JQYWxldHRlSW5kZXgOLkFzcGVjdC5WaWV3M0QZLldhbGxzLkJhY2suQnJ1c2guVmlzaWJsZRMuV2FsbHMuQmFjay5WaXNpYmxlGy5BeGVzLkxlZnQuTGFiZWxzLkZvbnQuU2l6ZSAuQXhlcy5MZWZ0LkxhYmVscy5Gb250LlNpemVGbG9hdCIuQXhlcy5MZWZ0LkxhYmVscy5Gb250LkJydXNoLkNvbG9yGi5BeGVzLkxlZnQuQXhpc1Blbi5WaXNpYmxlGS5BeGVzLkxlZnQuR3JpZC5EcmF3RXZlcnkaLkF4ZXMuTGVmdC5UaXRsZS5Gb250LlNpemUfLkF4ZXMuTGVmdC5UaXRsZS5Gb250LlNpemVGbG9hdCEuQXhlcy5MZWZ0LlRpdGxlLkZvbnQuQnJ1c2guQ29sb3IbLkF4ZXMuTGVmdC5SZWxhdGl2ZVBvc2l0aW9uGi5BeGVzLlRvcC5MYWJlbHMuRm9udC5TaXplHy5BeGVzLlRvcC5MYWJlbHMuRm9udC5TaXplRmxvYXQhLkF4ZXMuVG9wLkxhYmVscy5Gb250LkJydXNoLkNvbG9yHC5BeGVzLlJpZ2h0LkxhYmVscy5Gb250LlNpemUhLkF4ZXMuUmlnaHQuTGFiZWxzLkZvbnQuU2l6ZUZsb2F0Iy5BeGVzLlJpZ2h0LkxhYmVscy5Gb250LkJydXNoLkNvbG9yHS5BeGVzLkJvdHRvbS5MYWJlbHMuRm9udC5TaXplIi5BeGVzLkJvdHRvbS5MYWJlbHMuRm9udC5TaXplRmxvYXQkLkF4ZXMuQm90dG9tLkxhYmVscy5Gb250LkJydXNoLkNvbG9yHC5BeGVzLkJvdHRvbS5BeGlzUGVuLlZpc2libGUbLkF4ZXMuQm90dG9tLkdyaWQuRHJhd0V2ZXJ5HC5BeGVzLkJvdHRvbS5UaXRsZS5Gb250LlNpemUhLkF4ZXMuQm90dG9tLlRpdGxlLkZvbnQuU2l6ZUZsb2F0Iy5BeGVzLkJvdHRvbS5UaXRsZS5Gb250LkJydXNoLkNvbG9yHS5BeGVzLkJvdHRvbS5SZWxhdGl2ZVBvc2l0aW9uDy5BeGVzLkF1dG9tYXRpYwAEAAQABAAABAAAAAAEAAAAAAAAAAQAAAAABAAAAAQAAAQAAAQAAAAABAAAARlTdGVlbWEuVGVlQ2hhcnQuVGhlbWVUeXBlAgAAAAEjU3RlZW1hLlRlZUNoYXJ0LkRyYXdpbmcuQmV2ZWxTdHlsZXMCAAAAARRTeXN0ZW0uRHJhd2luZy5Db2xvcgMAAAAICxRTeXN0ZW0uRHJhd2luZy5Db2xvcgMAAAABAQgLFFN5c3RlbS5EcmF3aW5nLkNvbG9yAwAAAAEIAQEBCAsUU3lzdGVtLkRyYXdpbmcuQ29sb3IDAAAAAQgICxRTeXN0ZW0uRHJhd2luZy5Db2xvcgMAAAAGCAsUU3lzdGVtLkRyYXdpbmcuQ29sb3IDAAAACAsUU3lzdGVtLkRyYXdpbmcuQ29sb3IDAAAACAsUU3lzdGVtLkRyYXdpbmcuQ29sb3IDAAAAAQgICxRTeXN0ZW0uRHJhd2luZy5Db2xvcgMAAAAGAQIAAAAABfz///8ZU3RlZW1hLlRlZUNoYXJ0LlRoZW1lVHlwZQEAAAAHdmFsdWVfXwAIAgAAAAAAAAAABfv///8jU3RlZW1hLlRlZUNoYXJ0LkRyYXdpbmcuQmV2ZWxTdHlsZXMBAAAAB3ZhbHVlX18ACAIAAAAAAAAAAAX6////FFN5c3RlbS5EcmF3aW5nLkNvbG9yBAAAAARuYW1lBXZhbHVlCmtub3duQ29sb3IFc3RhdGUBAAAACQcHAwAAAAr/////AAAAAAAAAgAJAAAAAAAQQQH5////+v///wpAQED/AAAAAAAAAgAAAAwAAAAAAEBBAfj////6////CgAAAAAAAAAATgABAAAVAAAAAAAACQAAAAAAEEEB9/////r///8KAAAAAAAAAABOAAEAAAIAAAALAAAAAAAwQQH2////+v///wpAQED/AAAAAAAAAgAAAAAAAAAUwAkAAAAAABBBAfX////6////CkBAQP8AAAAAAAACAAkAAAAAABBBAfT////6////CkBAQP8AAAAAAAACAAkAAAAAABBBAfP////6////CoCAgP8AAAAAAAACAAACAAAACwAAAAAAMEEB8v////r///8KQEBA/wAAAAAAAAIAAAAAAAAAFMABCw=="
				Height="400px" GetChartFile="/TeeChartForNET/GetChart.aspx" LastFileName=""></tchart:WebChart><asp:dropdownlist id="DropDownList1" style="Z-INDEX: 101; LEFT: 756px; POSITION: absolute; TOP: 64px"
				runat="server" Width="89px" AutoPostBack="True">
				<asp:ListItem Value="Vertical" Selected="True">Vertical</asp:ListItem>
				<asp:ListItem Value="Horizontal">Horizontal</asp:ListItem>
			</asp:dropdownlist>
			<asp:Label id="Label3" style="Z-INDEX: 108; LEFT: 28px; POSITION: absolute; TOP: 16px" runat="server"
				Width="584px" Height="36px">BoxPlot Chart Style</asp:Label>
		</form>
	</body>
</HTML>
