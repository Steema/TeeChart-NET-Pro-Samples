<%@ Register TagPrefix="tchart" Namespace="Steema.TeeChart.Web" Assembly="TeeChart" %>
<%@ Page language="c#" Inherits="WebDemo.Interacting_with_Charts.Drill_Down.DrillDownWithPreviewChart" CodeFile="AggregationAndDrillDownChart.aspx.cs" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>AggregationAndDrillDownChart</title>
		<LINK href="..\..\..\Styles\ContentStyles.css" type="text/css" rel="stylesheet">
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<asp:Label id="Label3" style="Z-INDEX: 100; LEFT: 28px; POSITION: absolute; TOP: 16px" runat="server"
				Width="584px" Height="36px">This sample demonstrates how you could drilldown through Chart data using the Hotspot tool.</asp:Label>
			<asp:Label id="Label1" style="Z-INDEX: 104; LEFT: 28px; POSITION: absolute; TOP: 352px" runat="server"
				Height="36px" Width="584px">Simulation of monthly aggregation of weekly sales data.</asp:Label>
			<DIV style="Z-INDEX: 102; LEFT: 20px; WIDTH: 560px; POSITION: absolute; TOP: 396px; HEIGHT: 13px"></DIV>
			<tchart:WebChart id="WebChart1" style="Z-INDEX: 103; LEFT: 24px; POSITION: absolute; TOP: 68px" runat="server"
				AutoPostback="False" TempChart="Httphandler" Config="AAEAAAD/////AQAAAAAAAAAMAgAAAFJUZWVDaGFydCwgVmVyc2lvbj0yLjMuMjUyMy4xNzgzMiwgQ3VsdHVyZT1uZXV0cmFsLCBQdWJsaWNLZXlUb2tlbj05YzgxMjYyNzZjNzdiZGI3DAMAAABRU3lzdGVtLkRyYXdpbmcsIFZlcnNpb249Mi4wLjAuMCwgQ3VsdHVyZT1uZXV0cmFsLCBQdWJsaWNLZXlUb2tlbj1iMDNmNWY3ZjExZDUwYTNhBQEAAAAVU3RlZW1hLlRlZUNoYXJ0LkNoYXJ0HwAAABkuV2FsbHMuQmFjay5CcnVzaC5WaXNpYmxlDi5XYWxscy5WaXNpYmxlDi5Bc3BlY3QuVmlldzNEFS5Bc3BlY3QuU21vb3RoaW5nTW9kZRkuQXNwZWN0LlRleHRSZW5kZXJpbmdIaW50EC5QYW5lbC5QZW4uQ29sb3ISLlBhbmVsLlBlbi5WaXNpYmxlES5QYW5lbC5QZW4uRW5kQ2FwFS5QYW5lbC5CZXZlbC5Db2xvck9uZRUuUGFuZWwuQmV2ZWwuQ29sb3JUd28SLlBhbmVsLkJldmVsLk91dGVyEi5QYW5lbC5CZXZlbC5Jbm5lchcuUGFuZWwuSW1hZ2VCZXZlbC5XaWR0aB0uUGFuZWwuSW1hZ2VCZXZlbC5QZW4uVmlzaWJsZR8uUGFuZWwuQnJ1c2guR3JhZGllbnQuVXNlTWlkZGxlIS5QYW5lbC5CcnVzaC5HcmFkaWVudC5NaWRkbGVDb2xvciAuUGFuZWwuQnJ1c2guR3JhZGllbnQuU3RhcnRDb2xvch0uUGFuZWwuQnJ1c2guR3JhZGllbnQuVmlzaWJsZRUuUGFuZWwuU2hhZG93LlZpc2libGUNLkhlYWRlci5MaW5lcxEuSGVhZGVyLkZvbnQuU2l6ZRouSGVhZGVyLkZvbnQuU2hhZG93LkhlaWdodBkuSGVhZGVyLkZvbnQuU2hhZG93LldpZHRoGy5IZWFkZXIuRm9udC5TaGFkb3cuVmlzaWJsZRguSGVhZGVyLkZvbnQuQnJ1c2guQ29sb3IRLkhlYWRlci5Gb250Lk5hbWUWLkhlYWRlci5Gb250LlNpemVGbG9hdBguQXhlcy5MZWZ0LkxhYmVscy5PbkF4aXMYLkF4ZXMuTGVmdC5BeGlzUGVuLldpZHRoGi5BeGVzLkJvdHRvbS5MYWJlbHMuT25BeGlzGi5BeGVzLkJvdHRvbS5BeGlzUGVuLldpZHRoAAAABAQEAAQEBAQEAAAABAQAAAYAAAAABAEAAAAAAAEBASZTeXN0ZW0uRHJhd2luZy5EcmF3aW5nMkQuU21vb3RoaW5nTW9kZQMAAAAlU3lzdGVtLkRyYXdpbmcuVGV4dC5UZXh0UmVuZGVyaW5nSGludAMAAAAUU3lzdGVtLkRyYXdpbmcuQ29sb3IDAAAAASBTeXN0ZW0uRHJhd2luZy5EcmF3aW5nMkQuTGluZUNhcAMAAAAUU3lzdGVtLkRyYXdpbmcuQ29sb3IDAAAAFFN5c3RlbS5EcmF3aW5nLkNvbG9yAwAAACNTdGVlbWEuVGVlQ2hhcnQuRHJhd2luZy5CZXZlbFN0eWxlcwIAAAAjU3RlZW1hLlRlZUNoYXJ0LkRyYXdpbmcuQmV2ZWxTdHlsZXMCAAAACAEBFFN5c3RlbS5EcmF3aW5nLkNvbG9yAwAAABRTeXN0ZW0uRHJhd2luZy5Db2xvcgMAAAABAQgICAEUU3lzdGVtLkRyYXdpbmcuQ29sb3IDAAAACwEIAQgCAAAAAQAABfz///8mU3lzdGVtLkRyYXdpbmcuRHJhd2luZzJELlNtb290aGluZ01vZGUBAAAAB3ZhbHVlX18ACAMAAAACAAAABfv///8lU3lzdGVtLkRyYXdpbmcuVGV4dC5UZXh0UmVuZGVyaW5nSGludAEAAAAHdmFsdWVfXwAIAwAAAAUAAAAF+v///xRTeXN0ZW0uRHJhd2luZy5Db2xvcgQAAAAEbmFtZQV2YWx1ZQprbm93bkNvbG9yBXN0YXRlAQAAAAkHBwMAAAAKgAAA/gAAAAAAAAIAAQX5////IFN5c3RlbS5EcmF3aW5nLkRyYXdpbmcyRC5MaW5lQ2FwAQAAAAd2YWx1ZV9fAAgDAAAAAgAAAAH4////+v///wqAAAD+AAAAAAAAAgAB9/////r///8KgAAA/gAAAAAAAAIABfb///8jU3RlZW1hLlRlZUNoYXJ0LkRyYXdpbmcuQmV2ZWxTdHlsZXMBAAAAB3ZhbHVlX18ACAIAAAABAAAAAfX////2////AgAAAAIAAAAAAQH0////+v///wr/6ur+AAAAAAAAAgAB8/////r///8K/+rq/gAAAAAAAAIAAQEJDgAAAAwAAAACAAAAAgAAAAEB8f////r///8KAAAAAAAAAAB7AAEABhAAAAAGVGFob21hAABAQQABAAAAAAEAAAARDgAAAAEAAAAGEQAAAAlEcmlsbGRvd24L"
				Height="272px" Width="456px" GetChartFile="/TeeChartForNET/GetChart.aspx"></tchart:WebChart>
		</form>
	</body>
</HTML>
