<%@ Register TagPrefix="tchart" Namespace="Steema.TeeChart.Web" Assembly="TeeChart" %>
<%@ Page language="c#" Inherits="WebDemo.Interacting_with_Charts.Mouseover_Hints.CustomisingMouseoverMarks.DisplayingCustomToolTipChart" CodeFile="CustomisingMouseoverMarksChart.aspx.cs" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>CustomisingMouseoverMarksChart</title>
		<LINK href="..\..\..\Styles\ContentStyles.css" type="text/css" rel="stylesheet">
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<asp:label id="Label1" style="Z-INDEX: 106; LEFT: 490px; POSITION: absolute; TOP: 68px" runat="server"
				Width="151px">Series Tool tip content:</asp:label><asp:dropdownlist id="DropDownList1" style="Z-INDEX: 101; LEFT: 646px; POSITION: absolute; TOP: 65px"
				runat="server" Width="144px" AutoPostBack="True">
				<asp:ListItem Value="Image" Selected="True">Image</asp:ListItem>
				<asp:ListItem Value="Statistics Chart">Statistics Chart</asp:ListItem>
				<asp:ListItem Value="Num. of Accidents">Num. of Accidents</asp:ListItem>
			</asp:dropdownlist><tchart:webchart id="WebChart1" style="Z-INDEX: 107; LEFT: 24px; POSITION: absolute; TOP: 60px" runat="server"
				Width="430px" AutoPostback="False" TempChart="Httphandler" Config="AAEAAAD/////AQAAAAAAAAAMAgAAAE9UZWVDaGFydCwgVmVyc2lvbj00LjAuMC4xOTQ2MCwgQ3VsdHVyZT1uZXV0cmFsLCBQdWJsaWNLZXlUb2tlbj05YzgxMjYyNzZjNzdiZGI3DAMAAABRU3lzdGVtLkRyYXdpbmcsIFZlcnNpb249Mi4wLjAuMCwgQ3VsdHVyZT1uZXV0cmFsLCBQdWJsaWNLZXlUb2tlbj1iMDNmNWY3ZjExZDUwYTNhBQEAAAAVU3RlZW1hLlRlZUNoYXJ0LkNoYXJ0HAAAABAuQ3VzdG9tQ2hhcnRSZWN0Fy5QYW5lbC5JbWFnZUJldmVsLldpZHRoHS5QYW5lbC5JbWFnZUJldmVsLlBlbi5WaXNpYmxlEi5QYW5lbC5CZXZlbC5Jbm5lchUuUGFuZWwuQmV2ZWwuQ29sb3JPbmUVLlBhbmVsLkJldmVsLkNvbG9yVHdvEi5QYW5lbC5CZXZlbC5PdXRlchUuUGFuZWwuU2hhZG93LlZpc2libGUgLlBhbmVsLkJydXNoLkdyYWRpZW50LlN0YXJ0Q29sb3IhLlBhbmVsLkJydXNoLkdyYWRpZW50Lk1pZGRsZUNvbG9yEC5QYW5lbC5QZW4uQ29sb3ISLlBhbmVsLlBlbi5WaXNpYmxlES5QYW5lbC5QZW4uRW5kQ2FwFS5MZWdlbmQuVGV4dFN5bWJvbEdhcA0uSGVhZGVyLkxpbmVzES5IZWFkZXIuRm9udC5OYW1lES5IZWFkZXIuRm9udC5TaXplFi5IZWFkZXIuRm9udC5TaXplRmxvYXQaLkhlYWRlci5Gb250LlNoYWRvdy5IZWlnaHQZLkhlYWRlci5Gb250LlNoYWRvdy5XaWR0aBsuSGVhZGVyLkZvbnQuU2hhZG93LlZpc2libGUPLkFzcGVjdC5aT2Zmc2V0Di5Bc3BlY3QuVmlldzNEDi5XYWxscy5WaXNpYmxlGC5BeGVzLkxlZnQuTGFiZWxzLk9uQXhpcxguQXhlcy5MZWZ0LkF4aXNQZW4uV2lkdGgaLkF4ZXMuQm90dG9tLkxhYmVscy5PbkF4aXMaLkF4ZXMuQm90dG9tLkF4aXNQZW4uV2lkdGgAAAAEBAQEAAQEBAAEAAYBAAAAAAAAAAAAAAAAAQgBI1N0ZWVtYS5UZWVDaGFydC5EcmF3aW5nLkJldmVsU3R5bGVzAgAAABRTeXN0ZW0uRHJhd2luZy5Db2xvcgMAAAAUU3lzdGVtLkRyYXdpbmcuQ29sb3IDAAAAI1N0ZWVtYS5UZWVDaGFydC5EcmF3aW5nLkJldmVsU3R5bGVzAgAAAAEUU3lzdGVtLkRyYXdpbmcuQ29sb3IDAAAAFFN5c3RlbS5EcmF3aW5nLkNvbG9yAwAAABRTeXN0ZW0uRHJhd2luZy5Db2xvcgMAAAABIFN5c3RlbS5EcmF3aW5nLkRyYXdpbmcyRC5MaW5lQ2FwAwAAAAgICwgIAQYBAQEIAQgCAAAAAAIAAAAABfz///8jU3RlZW1hLlRlZUNoYXJ0LkRyYXdpbmcuQmV2ZWxTdHlsZXMBAAAAB3ZhbHVlX18ACAIAAAACAAAABfv///8UU3lzdGVtLkRyYXdpbmcuQ29sb3IEAAAABG5hbWUFdmFsdWUKa25vd25Db2xvcgVzdGF0ZQEAAAAJBwcDAAAACoAAAP4AAAAAAAACAAH6////+////wqAAAD+AAAAAAAAAgAB+f////z///8BAAAAAQH4////+////wr/6ur+AAAAAAAAAgAB9/////v///8K/+rq/gAAAAAAAAIAAfb////7////CoAAAP4AAAAAAAACAAEF9f///yBTeXN0ZW0uRHJhd2luZy5EcmF3aW5nMkQuTGluZUNhcAEAAAAHdmFsdWVfXwAIAwAAAAIAAAAAAAAACQwAAAAGDQAAAAZUYWhvbWEMAAAAAABAQQIAAAACAAAAAQAAAAAAAAAAAAAAAQAAAAABAAAAEQwAAAABAAAABg4AAAAPTW91c2VvdmVyIE1hcmtzCw=="
				Height="290px" GetChartFile="/TeeChartForNET/GetChart.aspx"></tchart:webchart><asp:label id="Label3" style="Z-INDEX: 108; LEFT: 28px; POSITION: absolute; TOP: 16px" runat="server"
				Width="584px" Height="36px">This sample demonstrates how to fade-in text hints, images or drill-down Charts when passing the mouse over the data points of the Chart.</asp:label>
			<DIV style="Z-INDEX: 109; LEFT: 24px; WIDTH: 560px; POSITION: absolute; TOP: 376px; HEIGHT: 13px"></DIV>
            <asp:Label ID="Label2" runat="server" Style="z-index: 106; left: 490px; position: absolute;
                top: 155px" Width="272px">See the Custom Tool tips over Legend and Left Axis. You can set Labels or Javascript mouseover actions for any Chart element.</asp:Label>
		</form>
	</body>
</HTML>
