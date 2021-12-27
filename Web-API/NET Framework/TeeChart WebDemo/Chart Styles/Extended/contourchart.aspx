<%@ Page language="c#" Inherits="WebDemo.Chart_Styles.Extended.ContourChart" CodeFile="ContourChart.aspx.cs" %>
<%@ Register TagPrefix="tchart" Namespace="Steema.TeeChart.Web" Assembly="TeeChart" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>ContourChart</title>
		<LINK href="..\..\Styles\ContentStyles.css" type="text/css" rel="stylesheet">
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<tchart:WebChart id="WebChart1" style="Z-INDEX: 101; LEFT: 24px; POSITION: absolute; TOP: 60px; width:857px; height:480px;" runat="server" Config="AAEAAAD/////AQAAAAAAAAAMAgAAAFFUZWVDaGFydCwgVmVyc2lvbj00LjEuMjAxNy42MjkwLCBDdWx0dXJlPW5ldXRyYWwsIFB1YmxpY0tleVRva2VuPTljODEyNjI3NmM3N2JkYjcMAwAAAFFTeXN0ZW0uRHJhd2luZywgVmVyc2lvbj00LjAuMC4wLCBDdWx0dXJlPW5ldXRyYWwsIFB1YmxpY0tleVRva2VuPWIwM2Y1ZjdmMTFkNTBhM2EFAQAAABVTdGVlbWEuVGVlQ2hhcnQuQ2hhcnQpAAAADC5DYW5jZWxNb3VzZQ0uQ3VycmVudFRoZW1lEC5DdXN0b21DaGFydFJlY3QSLlBhbmVsLkJldmVsLk91dGVyHS5QYW5lbC5CcnVzaC5HcmFkaWVudC5WaXNpYmxlEi5QYW5lbC5CcnVzaC5Db2xvchkuTGVnZW5kLlN5bWJvbC5EZWZhdWx0UGVuGi5MZWdlbmQuU3ltYm9sLlBlbi5WaXNpYmxlES5MZWdlbmQuRm9udC5TaXplFi5MZWdlbmQuRm9udC5TaXplRmxvYXQYLkxlZ2VuZC5Gb250LkJydXNoLkNvbG9yFi5MZWdlbmQuU2hhZG93LlZpc2libGUTLkxlZ2VuZC5QZW4uVmlzaWJsZREuSGVhZGVyLkZvbnQuU2l6ZRYuSGVhZGVyLkZvbnQuU2l6ZUZsb2F0GC5IZWFkZXIuRm9udC5CcnVzaC5Db2xvcg8uSGVhZGVyLlZpc2libGUOLkFzcGVjdC5WaWV3M0QZLldhbGxzLkJhY2suQnJ1c2guVmlzaWJsZRMuV2FsbHMuQmFjay5WaXNpYmxlGy5BeGVzLkxlZnQuTGFiZWxzLkZvbnQuU2l6ZSAuQXhlcy5MZWZ0LkxhYmVscy5Gb250LlNpemVGbG9hdCIuQXhlcy5MZWZ0LkxhYmVscy5Gb250LkJydXNoLkNvbG9yGS5BeGVzLkxlZnQuR3JpZC5EcmF3RXZlcnkaLkF4ZXMuTGVmdC5UaXRsZS5Gb250LlNpemUfLkF4ZXMuTGVmdC5UaXRsZS5Gb250LlNpemVGbG9hdCEuQXhlcy5MZWZ0LlRpdGxlLkZvbnQuQnJ1c2guQ29sb3IaLkF4ZXMuVG9wLkxhYmVscy5Gb250LlNpemUfLkF4ZXMuVG9wLkxhYmVscy5Gb250LlNpemVGbG9hdCEuQXhlcy5Ub3AuTGFiZWxzLkZvbnQuQnJ1c2guQ29sb3IcLkF4ZXMuUmlnaHQuTGFiZWxzLkZvbnQuU2l6ZSEuQXhlcy5SaWdodC5MYWJlbHMuRm9udC5TaXplRmxvYXQjLkF4ZXMuUmlnaHQuTGFiZWxzLkZvbnQuQnJ1c2guQ29sb3IdLkF4ZXMuQm90dG9tLkxhYmVscy5Gb250LlNpemUiLkF4ZXMuQm90dG9tLkxhYmVscy5Gb250LlNpemVGbG9hdCQuQXhlcy5Cb3R0b20uTGFiZWxzLkZvbnQuQnJ1c2guQ29sb3IbLkF4ZXMuQm90dG9tLkdyaWQuRHJhd0V2ZXJ5HC5BeGVzLkJvdHRvbS5UaXRsZS5Gb250LlNpemUhLkF4ZXMuQm90dG9tLlRpdGxlLkZvbnQuU2l6ZUZsb2F0Iy5BeGVzLkJvdHRvbS5UaXRsZS5Gb250LkJydXNoLkNvbG9yDy5BeGVzLkF1dG9tYXRpYwAEAAQABAAAAAAEAAAAAAQAAAAAAAAEAAAABAAABAAABAAABAAAAAQAARlTdGVlbWEuVGVlQ2hhcnQuVGhlbWVUeXBlAgAAAAEjU3RlZW1hLlRlZUNoYXJ0LkRyYXdpbmcuQmV2ZWxTdHlsZXMCAAAAARRTeXN0ZW0uRHJhd2luZy5Db2xvcgMAAAABAQgLFFN5c3RlbS5EcmF3aW5nLkNvbG9yAwAAAAEBCAsUU3lzdGVtLkRyYXdpbmcuQ29sb3IDAAAAAQEBAQgLFFN5c3RlbS5EcmF3aW5nLkNvbG9yAwAAAAgICxRTeXN0ZW0uRHJhd2luZy5Db2xvcgMAAAAICxRTeXN0ZW0uRHJhd2luZy5Db2xvcgMAAAAICxRTeXN0ZW0uRHJhd2luZy5Db2xvcgMAAAAICxRTeXN0ZW0uRHJhd2luZy5Db2xvcgMAAAAICAsUU3lzdGVtLkRyYXdpbmcuQ29sb3IDAAAAAQIAAAAABfz///8ZU3RlZW1hLlRlZUNoYXJ0LlRoZW1lVHlwZQEAAAAHdmFsdWVfXwAIAgAAAAAAAAAABfv///8jU3RlZW1hLlRlZUNoYXJ0LkRyYXdpbmcuQmV2ZWxTdHlsZXMBAAAAB3ZhbHVlX18ACAIAAAAAAAAAAAX6////FFN5c3RlbS5EcmF3aW5nLkNvbG9yBAAAAARuYW1lBXZhbHVlCmtub3duQ29sb3IFc3RhdGUBAAAACQcHAwAAAAr/////AAAAAAAAAgAAAAkAAAAAABBBAfn////6////CkBAQP8AAAAAAAACAAAADAAAAAAAQEEB+P////r///8KAAAAAAAAAABOAAEAAAAAAAkAAAAAABBBAff////6////CgAAAAAAAAAATgABAAIAAAALAAAAAAAwQQH2////+v///wpAQED/AAAAAAAAAgAJAAAAAAAQQQH1////+v///wpAQED/AAAAAAAAAgAJAAAAAAAQQQH0////+v///wpAQED/AAAAAAAAAgAJAAAAAAAQQQHz////+v///wqAgID/AAAAAAAAAgACAAAACwAAAAAAMEEB8v////r///8KQEBA/wAAAAAAAAIAAQs="
				TempChart="Httphandler" width="857px" AutoPostback="False" GetChartFile="/TeeChartForNET/GetChart.aspx" LastFileName="" BorderStyle="None" Height="480px"></tchart:WebChart>
			<asp:Label id="Label3" style="Z-INDEX: 102; LEFT: 28px; POSITION: absolute; TOP: 16px; width: 851px;" runat="server" Height="36px">Contour Chart Style</asp:Label>
			<asp:CheckBox id="CheckBox1" style="Z-INDEX: 104; LEFT: 900px; POSITION: absolute; TOP: 64px"
				runat="server" Text="2D" AutoPostBack="True"></asp:CheckBox>
			<asp:CheckBox id="CheckBox2" style="Z-INDEX: 105; LEFT: 900px; POSITION: absolute; TOP: 88px"
				runat="server" Text="Show Walls" Width="112px" AutoPostBack="True" Checked="True"></asp:CheckBox>
			<asp:CheckBox id="CheckBox3" style="Z-INDEX: 106; LEFT: 900px; POSITION: absolute; TOP: 112px"
				runat="server" Text="Color Each Level" Width="138px" AutoPostBack="True" Checked="True"></asp:CheckBox>
			<asp:CheckBox id="CheckBox4" style="Z-INDEX: 107; LEFT: 900px; POSITION: absolute; TOP: 136px"
				runat="server" Text="Levels at Y" Width="134px" AutoPostBack="True"></asp:CheckBox>
			<asp:CheckBox id="CheckBox5" style="Z-INDEX: 108; LEFT: 900px; POSITION: absolute; TOP: 160px"
				runat="server" Text="Surface" AutoPostBack="True"></asp:CheckBox>
		</form>
	</body>
</HTML>
