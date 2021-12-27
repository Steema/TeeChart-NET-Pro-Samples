<%@ Page language="c#" Inherits="WebDemo.Chart_Styles.Extended.RadarChart" CodeFile="RadarChart.aspx.cs" %>
<%@ Register TagPrefix="tchart" Namespace="Steema.TeeChart.Web" Assembly="TeeChart" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>RadarChart</title>
		<LINK href="..\..\Styles\ContentStyles.css" type="text/css" rel="stylesheet">
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<tchart:WebChart id="WebChart1" style="Z-INDEX: 101; LEFT: 24px; POSITION: absolute; TOP: 60px; width:432px; height:290px;" runat="server"
				Width="432px" Height="290px" Config="AAEAAAD/////AQAAAAAAAAAMAgAAAFJUZWVDaGFydCwgVmVyc2lvbj0yLjMuMjU3OC4zMTIxNywgQ3VsdHVyZT1uZXV0cmFsLCBQdWJsaWNLZXlUb2tlbj05YzgxMjYyNzZjNzdiZGI3DAMAAABRU3lzdGVtLkRyYXdpbmcsIFZlcnNpb249Mi4wLjAuMCwgQ3VsdHVyZT1uZXV0cmFsLCBQdWJsaWNLZXlUb2tlbj1iMDNmNWY3ZjExZDUwYTNhBQEAAAAVU3RlZW1hLlRlZUNoYXJ0LkNoYXJ0MQAAABUuV2FsbHMuQmFjay5QZW4uQ29sb3ITLldhbGxzLkxlZnQuVmlzaWJsZRUuV2FsbHMuQm90dG9tLlZpc2libGUMLkFzcGVjdC5ab29tDi5Bc3BlY3QuVmlldzNEFS5Bc3BlY3QuU21vb3RoaW5nTW9kZRkuQXNwZWN0LlRleHRSZW5kZXJpbmdIaW50Dy5MZWdlbmQuVmlzaWJsZRAuUGFuZWwuUGVuLkNvbG9yEi5QYW5lbC5QZW4uVmlzaWJsZREuUGFuZWwuUGVuLkVuZENhcBUuUGFuZWwuQmV2ZWwuQ29sb3JPbmUVLlBhbmVsLkJldmVsLkNvbG9yVHdvEi5QYW5lbC5CZXZlbC5PdXRlchIuUGFuZWwuQmV2ZWwuSW5uZXIdLlBhbmVsLkltYWdlQmV2ZWwuQnJ1c2guQ29sb3IXLlBhbmVsLkltYWdlQmV2ZWwuV2lkdGgdLlBhbmVsLkltYWdlQmV2ZWwuUGVuLlZpc2libGUfLlBhbmVsLkJydXNoLkdyYWRpZW50LlVzZU1pZGRsZSEuUGFuZWwuQnJ1c2guR3JhZGllbnQuTWlkZGxlQ29sb3IgLlBhbmVsLkJydXNoLkdyYWRpZW50LlN0YXJ0Q29sb3IdLlBhbmVsLkJydXNoLkdyYWRpZW50LlZpc2libGURLlBhbmVsLk1hcmdpbkxlZnQSLlBhbmVsLk1hcmdpblJpZ2h0FS5QYW5lbC5TaGFkb3cuVmlzaWJsZQ0uSGVhZGVyLkxpbmVzES5IZWFkZXIuRm9udC5TaXplHy5IZWFkZXIuRm9udC5TaGFkb3cuQnJ1c2guQ29sb3IaLkhlYWRlci5Gb250LlNoYWRvdy5IZWlnaHQZLkhlYWRlci5Gb250LlNoYWRvdy5XaWR0aBsuSGVhZGVyLkZvbnQuU2hhZG93LlZpc2libGUYLkhlYWRlci5Gb250LkJydXNoLkNvbG9yES5IZWFkZXIuRm9udC5OYW1lFi5IZWFkZXIuRm9udC5TaXplRmxvYXQYLkF4ZXMuTGVmdC5MYWJlbHMuT25BeGlzHS5BeGVzLkxlZnQuTWlub3JUaWNrcy5WaXNpYmxlGC5BeGVzLkxlZnQuQXhpc1Blbi5XaWR0aBouQXhlcy5MZWZ0LkF4aXNQZW4uVmlzaWJsZRcuQXhlcy5Ub3AuQXhpc1Blbi5XaWR0aBkuQXhlcy5Ub3AuQXhpc1Blbi5WaXNpYmxlGS5BeGVzLkRlcHRoLkF4aXNQZW4uV2lkdGgaLkF4ZXMuQm90dG9tLkxhYmVscy5PbkF4aXMfLkF4ZXMuQm90dG9tLk1pbm9yVGlja3MuVmlzaWJsZRouQXhlcy5Cb3R0b20uQXhpc1Blbi5XaWR0aBwuQXhlcy5Cb3R0b20uQXhpc1Blbi5WaXNpYmxlEy5BeGVzLlJpZ2h0LlZpc2libGUZLkF4ZXMuUmlnaHQuQXhpc1Blbi5XaWR0aBsuQXhlcy5SaWdodC5BeGlzUGVuLlZpc2libGUcLkF4ZXMuRGVwdGhUb3AuQXhpc1Blbi5XaWR0aAQAAAAABAQABAAEBAQEBAQAAAAEBAAAAAAGAAQAAAAEAQAAAAAAAAAAAAAAAAAAAAAUU3lzdGVtLkRyYXdpbmcuQ29sb3IDAAAAAQEIASZTeXN0ZW0uRHJhd2luZy5EcmF3aW5nMkQuU21vb3RoaW5nTW9kZQMAAAAlU3lzdGVtLkRyYXdpbmcuVGV4dC5UZXh0UmVuZGVyaW5nSGludAMAAAABFFN5c3RlbS5EcmF3aW5nLkNvbG9yAwAAAAEgU3lzdGVtLkRyYXdpbmcuRHJhd2luZzJELkxpbmVDYXADAAAAFFN5c3RlbS5EcmF3aW5nLkNvbG9yAwAAABRTeXN0ZW0uRHJhd2luZy5Db2xvcgMAAAAjU3RlZW1hLlRlZUNoYXJ0LkRyYXdpbmcuQmV2ZWxTdHlsZXMCAAAAI1N0ZWVtYS5UZWVDaGFydC5EcmF3aW5nLkJldmVsU3R5bGVzAgAAABRTeXN0ZW0uRHJhd2luZy5Db2xvcgMAAAAIAQEUU3lzdGVtLkRyYXdpbmcuQ29sb3IDAAAAFFN5c3RlbS5EcmF3aW5nLkNvbG9yAwAAAAEGBgEIFFN5c3RlbS5EcmF3aW5nLkNvbG9yAwAAAAgIARRTeXN0ZW0uRHJhd2luZy5Db2xvcgMAAAALAQEIAQgBCAEBCAEBCAEIAgAAAAX8////FFN5c3RlbS5EcmF3aW5nLkNvbG9yBAAAAARuYW1lBXZhbHVlCmtub3duQ29sb3IFc3RhdGUBAAAACQcHAwAAAAqpqan+AAAAAAAAAgAAAEcAAAAABfv///8mU3lzdGVtLkRyYXdpbmcuRHJhd2luZzJELlNtb290aGluZ01vZGUBAAAAB3ZhbHVlX18ACAMAAAACAAAABfr///8lU3lzdGVtLkRyYXdpbmcuVGV4dC5UZXh0UmVuZGVyaW5nSGludAEAAAAHdmFsdWVfXwAIAwAAAAUAAAAAAfn////8////CoAAAP4AAAAAAAACAAEF+P///yBTeXN0ZW0uRHJhd2luZy5EcmF3aW5nMkQuTGluZUNhcAEAAAAHdmFsdWVfXwAIAwAAAAIAAAAB9/////z///8KgAAA/gAAAAAAAAIAAfb////8////CoAAAP4AAAAAAAACAAX1////I1N0ZWVtYS5UZWVDaGFydC5EcmF3aW5nLkJldmVsU3R5bGVzAQAAAAd2YWx1ZV9fAAgCAAAAAQAAAAH0////9f///wIAAAAB8/////z///8K/+jo/gAAAAAAAAIAAgAAAAABAfL////8////Cv/q6v4AAAAAAAACAAHx/////P///wr/6ur+AAAAAAAAAgABAAAAAAAAFEAAAAAAAAAUQAEJEAAAAAwAAAAB7/////z///8KwMDA/gAAAAAAAAIAAgAAAAIAAAABAe7////8////CoAAAP4AAAAAAAACAAYTAAAABlRhaG9tYQAAQEEAAAEAAAAAAQAAAAABAAAAAAABAAAAAAABAAAAAAEAAAAREAAAAAEAAAAGFAAAABFSYWRhciBDaGFydCBTdHlsZQs="
				TempChart="Httphandler" AutoPostback="False" GetChartFile="/TeeChartForNET/GetChart.aspx"></tchart:WebChart>
			<asp:Label id="Label3" style="Z-INDEX: 102; LEFT: 28px; POSITION: absolute; TOP: 16px" runat="server"
				Width="584px" Height="36px">Radar Chart Style</asp:Label>
			<asp:CheckBox id="CheckBox1" style="Z-INDEX: 104; LEFT: 468px; POSITION: absolute; TOP: 68px"
				runat="server" Text="Labels" AutoPostBack="True" Checked="True"></asp:CheckBox>
			<asp:CheckBox id="CheckBox2" style="Z-INDEX: 105; LEFT: 468px; POSITION: absolute; TOP: 92px"
				runat="server" Text="Lines" AutoPostBack="True" Checked="True"></asp:CheckBox>
			<asp:CheckBox id="CheckBox3" style="Z-INDEX: 106; LEFT: 468px; POSITION: absolute; TOP: 116px"
				runat="server" Text="Axis" AutoPostBack="True" Checked="True"></asp:CheckBox>
			<asp:CheckBox id="CheckBox4" style="Z-INDEX: 107; LEFT: 468px; POSITION: absolute; TOP: 140px"
				runat="server" Text="Squared" AutoPostBack="True" Checked="True"></asp:CheckBox>
		</form>
	</body>
</HTML>
