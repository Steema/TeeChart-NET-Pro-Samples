<%@ Register TagPrefix="tchart" Namespace="Steema.TeeChart.Web" Assembly="TeeChart" %>
<%@ Page language="c#" Inherits="WebDemo.Chart_Styles.Standard.PieChart" CodeFile="PieChart.aspx.cs" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>PieChart</title>
		<LINK href="..\..\Styles\ContentStyles.css" type="text/css" rel="stylesheet">
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<tchart:WebChart id="WebChart1" 
                style="Z-INDEX: 107; LEFT: 24px; POSITION: absolute; Width:600px; Height:400px; TOP: 60px" runat="server"
				Width="600px" Height="400px" Config="AAEAAAD/////AQAAAAAAAAAMAgAAAFFUZWVDaGFydCwgVmVyc2lvbj00LjEuMjAxNy42MjkwLCBDdWx0dXJlPW5ldXRyYWwsIFB1YmxpY0tleVRva2VuPTljODEyNjI3NmM3N2JkYjcMAwAAAFFTeXN0ZW0uRHJhd2luZywgVmVyc2lvbj00LjAuMC4wLCBDdWx0dXJlPW5ldXRyYWwsIFB1YmxpY0tleVRva2VuPWIwM2Y1ZjdmMTFkNTBhM2EFAQAAABVTdGVlbWEuVGVlQ2hhcnQuQ2hhcnQoAAAADC5DYW5jZWxNb3VzZQ0uQ3VycmVudFRoZW1lEC5DdXN0b21DaGFydFJlY3QSLlBhbmVsLkJldmVsLk91dGVyHS5QYW5lbC5CcnVzaC5HcmFkaWVudC5WaXNpYmxlEi5QYW5lbC5CcnVzaC5Db2xvchEuTGVnZW5kLkZvbnQuU2l6ZRYuTGVnZW5kLkZvbnQuU2l6ZUZsb2F0GC5MZWdlbmQuRm9udC5CcnVzaC5Db2xvchYuTGVnZW5kLlNoYWRvdy5WaXNpYmxlDS5IZWFkZXIuTGluZXMRLkhlYWRlci5Gb250LlNpemUWLkhlYWRlci5Gb250LlNpemVGbG9hdBguSGVhZGVyLkZvbnQuQnJ1c2guQ29sb3IPLkhlYWRlci5WaXNpYmxlGS5Bc3BlY3QuQ29sb3JQYWxldHRlSW5kZXgOLkFzcGVjdC5WaWV3M0QZLldhbGxzLkJhY2suQnJ1c2guVmlzaWJsZRMuV2FsbHMuQmFjay5WaXNpYmxlGy5BeGVzLkxlZnQuTGFiZWxzLkZvbnQuU2l6ZSAuQXhlcy5MZWZ0LkxhYmVscy5Gb250LlNpemVGbG9hdCIuQXhlcy5MZWZ0LkxhYmVscy5Gb250LkJydXNoLkNvbG9yGS5BeGVzLkxlZnQuR3JpZC5EcmF3RXZlcnkaLkF4ZXMuTGVmdC5UaXRsZS5Gb250LlNpemUfLkF4ZXMuTGVmdC5UaXRsZS5Gb250LlNpemVGbG9hdCEuQXhlcy5MZWZ0LlRpdGxlLkZvbnQuQnJ1c2guQ29sb3IaLkF4ZXMuVG9wLkxhYmVscy5Gb250LlNpemUfLkF4ZXMuVG9wLkxhYmVscy5Gb250LlNpemVGbG9hdCEuQXhlcy5Ub3AuTGFiZWxzLkZvbnQuQnJ1c2guQ29sb3IcLkF4ZXMuUmlnaHQuTGFiZWxzLkZvbnQuU2l6ZSEuQXhlcy5SaWdodC5MYWJlbHMuRm9udC5TaXplRmxvYXQjLkF4ZXMuUmlnaHQuTGFiZWxzLkZvbnQuQnJ1c2guQ29sb3IdLkF4ZXMuQm90dG9tLkxhYmVscy5Gb250LlNpemUiLkF4ZXMuQm90dG9tLkxhYmVscy5Gb250LlNpemVGbG9hdCQuQXhlcy5Cb3R0b20uTGFiZWxzLkZvbnQuQnJ1c2guQ29sb3IbLkF4ZXMuQm90dG9tLkdyaWQuRHJhd0V2ZXJ5HC5BeGVzLkJvdHRvbS5UaXRsZS5Gb250LlNpemUhLkF4ZXMuQm90dG9tLlRpdGxlLkZvbnQuU2l6ZUZsb2F0Iy5BeGVzLkJvdHRvbS5UaXRsZS5Gb250LkJydXNoLkNvbG9yDy5BeGVzLkF1dG9tYXRpYwAEAAQABAAABAAGAAAEAAAAAAAAAAQAAAAEAAAEAAAEAAAEAAAABAABGVN0ZWVtYS5UZWVDaGFydC5UaGVtZVR5cGUCAAAAASNTdGVlbWEuVGVlQ2hhcnQuRHJhd2luZy5CZXZlbFN0eWxlcwIAAAABFFN5c3RlbS5EcmF3aW5nLkNvbG9yAwAAAAgLFFN5c3RlbS5EcmF3aW5nLkNvbG9yAwAAAAEICxRTeXN0ZW0uRHJhd2luZy5Db2xvcgMAAAABCAEBAQgLFFN5c3RlbS5EcmF3aW5nLkNvbG9yAwAAAAgICxRTeXN0ZW0uRHJhd2luZy5Db2xvcgMAAAAICxRTeXN0ZW0uRHJhd2luZy5Db2xvcgMAAAAICxRTeXN0ZW0uRHJhd2luZy5Db2xvcgMAAAAICxRTeXN0ZW0uRHJhd2luZy5Db2xvcgMAAAAICAsUU3lzdGVtLkRyYXdpbmcuQ29sb3IDAAAAAQIAAAAABfz///8ZU3RlZW1hLlRlZUNoYXJ0LlRoZW1lVHlwZQEAAAAHdmFsdWVfXwAIAgAAABAAAAAABfv///8jU3RlZW1hLlRlZUNoYXJ0LkRyYXdpbmcuQmV2ZWxTdHlsZXMBAAAAB3ZhbHVlX18ACAIAAAAAAAAAAAX6////FFN5c3RlbS5EcmF3aW5nLkNvbG9yBAAAAARuYW1lBXZhbHVlCmtub3duQ29sb3IFc3RhdGUBAAAACQcHAwAAAAr/////AAAAAAAAAgAJAAAAAAAQQQH5////+v///wpAQED/AAAAAAAAAgAACQgAAAAMAAAAAABAQQH3////+v///woAAAAAAAAAAE4AAQAAFAAAAAAAAAkAAAAAABBBAfb////6////CgAAAAAAAAAATgABAAIAAAALAAAAAAAwQQH1////+v///wpAQED/AAAAAAAAAgAJAAAAAAAQQQH0////+v///wpAQED/AAAAAAAAAgAJAAAAAAAQQQHz////+v///wpAQED/AAAAAAAAAgAJAAAAAAAQQQHy////+v///wqAgID/AAAAAAAAAgACAAAACwAAAAAAMEEB8f////r///8KQEBA/wAAAAAAAAIAAREIAAAAAQAAAAYQAAAACVBpZSBTdHlsZQs="
				TempChart="Httphandler" AutoPostback="False"
                GetChartFile="/TeeChartForNET/GetChart.aspx" LastFileName="" CurrentTheme="Report"></tchart:WebChart>
			<asp:Label id="Label3" style="Z-INDEX: 108; LEFT: 28px; POSITION: absolute; TOP: 16px" runat="server"
				Width="584px" Height="36px">Pie Chart Style.</asp:Label>
		</form>
	</body>
</HTML>
