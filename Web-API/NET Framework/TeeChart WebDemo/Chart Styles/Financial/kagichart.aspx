<%@ Page language="c#" Inherits="WebDemo.Chart_Styles.Financial.KagiChart" CodeFile="kagichart.aspx.cs" %>
<%@ Register TagPrefix="tchart" Namespace="Steema.TeeChart.Web" Assembly="TeeChart" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>KagiChart</title>
		<LINK href="..\..\Styles\ContentStyles.css" type="text/css" rel="stylesheet">
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<tchart:WebChart id="WebChart1" style="Z-INDEX: 101; LEFT: 24px; POSITION: absolute; TOP: 60px; width:632px; height:290px;" runat="server"
				Width="632px" Height="290px" Config="AAEAAAD/////AQAAAAAAAAAMAgAAAFJUZWVDaGFydCwgVmVyc2lvbj0zLjAuMjY3OS4yOTg1MywgQ3VsdHVyZT1uZXV0cmFsLCBQdWJsaWNLZXlUb2tlbj05YzgxMjYyNzZjNzdiZGI3DAMAAABRU3lzdGVtLkRyYXdpbmcsIFZlcnNpb249Mi4wLjAuMCwgQ3VsdHVyZT1uZXV0cmFsLCBQdWJsaWNLZXlUb2tlbj1iMDNmNWY3ZjExZDUwYTNhBQEAAAAVU3RlZW1hLlRlZUNoYXJ0LkNoYXJ0MAAAABUuV2FsbHMuQmFjay5QZW4uQ29sb3IXLldhbGxzLkJhY2suQnJ1c2guQ29sb3InLldhbGxzLkJhY2suQnJ1c2guR3JhZGllbnQuVHJhbnNwYXJlbmN5Ey5XYWxscy5MZWZ0LlZpc2libGUVLldhbGxzLkJvdHRvbS5WaXNpYmxlDi5Bc3BlY3QuVmlldzNEGS5MZWdlbmQuVGl0bGUuUGVuLlZpc2libGUQLlBhbmVsLlBlbi5Db2xvchIuUGFuZWwuUGVuLlZpc2libGURLlBhbmVsLlBlbi5FbmRDYXAVLlBhbmVsLkJldmVsLkNvbG9yT25lFS5QYW5lbC5CZXZlbC5Db2xvclR3bxIuUGFuZWwuQmV2ZWwuT3V0ZXISLlBhbmVsLkJldmVsLklubmVyHS5QYW5lbC5JbWFnZUJldmVsLkJydXNoLkNvbG9yFy5QYW5lbC5JbWFnZUJldmVsLldpZHRoHS5QYW5lbC5JbWFnZUJldmVsLlBlbi5WaXNpYmxlIS5QYW5lbC5CcnVzaC5HcmFkaWVudC5NaWRkbGVDb2xvciAuUGFuZWwuQnJ1c2guR3JhZGllbnQuU3RhcnRDb2xvchUuUGFuZWwuU2hhZG93LlZpc2libGUNLkhlYWRlci5MaW5lcxEuSGVhZGVyLkZvbnQuU2l6ZR8uSGVhZGVyLkZvbnQuU2hhZG93LkJydXNoLkNvbG9yGi5IZWFkZXIuRm9udC5TaGFkb3cuSGVpZ2h0GS5IZWFkZXIuRm9udC5TaGFkb3cuV2lkdGgbLkhlYWRlci5Gb250LlNoYWRvdy5WaXNpYmxlGC5IZWFkZXIuRm9udC5CcnVzaC5Db2xvchEuSGVhZGVyLkZvbnQuTmFtZRYuSGVhZGVyLkZvbnQuU2l6ZUZsb2F0GC5BeGVzLkxlZnQuTGFiZWxzLk9uQXhpcyIuQXhlcy5MZWZ0LkxhYmVscy5Gb250LkJydXNoLkNvbG9yGC5BeGVzLkxlZnQuTWF4aW11bU9mZnNldB0uQXhlcy5MZWZ0Lk1pbm9yVGlja3MuVmlzaWJsZRguQXhlcy5MZWZ0LkF4aXNQZW4uQ29sb3IYLkF4ZXMuTGVmdC5BeGlzUGVuLldpZHRoES5BeGVzLlRvcC5WaXNpYmxlFy5BeGVzLlRvcC5BeGlzUGVuLldpZHRoGS5BeGVzLkRlcHRoLkF4aXNQZW4uV2lkdGgaLkF4ZXMuQm90dG9tLkxhYmVscy5PbkF4aXMkLkF4ZXMuQm90dG9tLkxhYmVscy5Gb250LkJydXNoLkNvbG9yGi5BeGVzLkJvdHRvbS5NYXhpbXVtT2Zmc2V0Hy5BeGVzLkJvdHRvbS5NaW5vclRpY2tzLlZpc2libGUaLkF4ZXMuQm90dG9tLkF4aXNQZW4uQ29sb3IaLkF4ZXMuQm90dG9tLkF4aXNQZW4uV2lkdGgcLkF4ZXMuQm90dG9tLkF4aXNQZW4uVmlzaWJsZRMuQXhlcy5SaWdodC5WaXNpYmxlGS5BeGVzLlJpZ2h0LkF4aXNQZW4uV2lkdGgcLkF4ZXMuRGVwdGhUb3AuQXhpc1Blbi5XaWR0aAQEAAAAAAAEAAQEBAQEBAAABAQABgAEAAAABAEAAAQAAAQAAAAAAAQAAAQAAAAAABRTeXN0ZW0uRHJhd2luZy5Db2xvcgMAAAAUU3lzdGVtLkRyYXdpbmcuQ29sb3IDAAAACAEBAQEUU3lzdGVtLkRyYXdpbmcuQ29sb3IDAAAAASBTeXN0ZW0uRHJhd2luZy5EcmF3aW5nMkQuTGluZUNhcAMAAAAUU3lzdGVtLkRyYXdpbmcuQ29sb3IDAAAAFFN5c3RlbS5EcmF3aW5nLkNvbG9yAwAAACNTdGVlbWEuVGVlQ2hhcnQuRHJhd2luZy5CZXZlbFN0eWxlcwIAAAAjU3RlZW1hLlRlZUNoYXJ0LkRyYXdpbmcuQmV2ZWxTdHlsZXMCAAAAFFN5c3RlbS5EcmF3aW5nLkNvbG9yAwAAAAgBFFN5c3RlbS5EcmF3aW5nLkNvbG9yAwAAABRTeXN0ZW0uRHJhd2luZy5Db2xvcgMAAAABCBRTeXN0ZW0uRHJhd2luZy5Db2xvcgMAAAAICAEUU3lzdGVtLkRyYXdpbmcuQ29sb3IDAAAACwEUU3lzdGVtLkRyYXdpbmcuQ29sb3IDAAAACAEUU3lzdGVtLkRyYXdpbmcuQ29sb3IDAAAACAEICAEUU3lzdGVtLkRyYXdpbmcuQ29sb3IDAAAACAEUU3lzdGVtLkRyYXdpbmcuQ29sb3IDAAAACAEBCAgCAAAABfz///8UU3lzdGVtLkRyYXdpbmcuQ29sb3IEAAAABG5hbWUFdmFsdWUKa25vd25Db2xvcgVzdGF0ZQEAAAAJBwcDAAAACqmpqf4AAAAAAAACAAH7/////P///wrA//9mAAAAAAAAAgA8AAAAAAAAAAH6/////P///wqAAAD+AAAAAAAAAgABBfn///8gU3lzdGVtLkRyYXdpbmcuRHJhd2luZzJELkxpbmVDYXABAAAAB3ZhbHVlX18ACAMAAAACAAAAAfj////8////CoAAAP4AAAAAAAACAAH3/////P///wqAAAD+AAAAAAAAAgAF9v///yNTdGVlbWEuVGVlQ2hhcnQuRHJhd2luZy5CZXZlbFN0eWxlcwEAAAAHdmFsdWVfXwAIAgAAAAEAAAAB9f////b///8CAAAAAfT////8////Cv/o6P4AAAAAAAACAAIAAAAAAfP////8////Cv/q6v4AAAAAAAACAAHy/////P///wr/6ur+AAAAAAAAAgABCQ8AAAAMAAAAAfD////8////CsDAwP4AAAAAAAACAAIAAAACAAAAAQHv/////P///wqAAAD+AAAAAAAAAgAGEgAAAAZUYWhvbWEAAEBBAAHt/////P///wqAgID+AAAAAAAAAgAtAAAAAAHs/////P///wqpqan+AAAAAAAAAgABAAAAAAEAAAABAAAAAAHr/////P///wqAgID+AAAAAAAAAgAIAAAAAAHq/////P///wqpqan+AAAAAAAAAgABAAAAAAABAAAAAQAAABEPAAAAAQAAAAYXAAAACkthZ2kgQ2hhcnQL"
				TempChart="Httphandler" AutoPostback="False" GetChartFile="/TeeChartForNET/GetChart.aspx"></tchart:WebChart>
			<asp:Label id="Label3" style="Z-INDEX: 102; LEFT: 28px; POSITION: absolute; TOP: 16px" runat="server"
				Width="584px" Height="36px"> Kagi Chart Type</asp:Label>
			<asp:Button id="Button1" style="Z-INDEX: 104; LEFT: 668px; POSITION: absolute; TOP: 64px" runat="server"
				Text="Update Chart"></asp:Button>
		</form>
	</body>
</HTML>
