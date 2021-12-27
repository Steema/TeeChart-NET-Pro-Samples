<%@ Page language="c#" Inherits="WebDemo.JBarChart1" CodeFile="JActivityGauge.aspx.cs" %>
<%@ Register TagPrefix="tchart" Namespace="Steema.TeeChart.Web" Assembly="TeeChart" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>TeeChart's Activity Gauge</title>
		<LINK href="..\..\Styles\ContentStyles.css" type="text/css" rel="stylesheet">
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
        <script type="text/javascript">

					var updown = true;
					var counter = 0;

					function modVal() {
						var rnd = Math.random();
						var val = WebChart1_chart.series.items[0].value;
						if (updown) {
							val = val + rnd;
							if (val > 2.5) val = 2.5;
							WebChart1_chart.series.items[0].value = val;
							updown = false;
						}
						else {
							val = val - rnd;
							if (val < -5) val = -5;
							WebChart1_chart.series.items[0].value = val;
							updown = true;
						}

						WebChart1_chart.draw();

						if (counter < 1000)
						  setTimeout(modVal, 100);
						counter++;
					}

        </script>
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			&nbsp;

			<tchart:WebChart id="WebChart1" 
                
                style="Z-INDEX: 107; LEFT: 24px; POSITION: absolute; TOP: 60px; height: 300px; width: 650px;" 
                runat="server" Config="AAEAAAD/////AQAAAAAAAAAMAgAAAE9UZWVDaGFydCwgVmVyc2lvbj00LjIwMTguOC4zMCwgQ3VsdHVyZT1uZXV0cmFsLCBQdWJsaWNLZXlUb2tlbj05YzgxMjYyNzZjNzdiZGI3DAMAAABRU3lzdGVtLkRyYXdpbmcsIFZlcnNpb249NC4wLjAuMCwgQ3VsdHVyZT1uZXV0cmFsLCBQdWJsaWNLZXlUb2tlbj1iMDNmNWY3ZjExZDUwYTNhBQEAAAAVU3RlZW1hLlRlZUNoYXJ0LkNoYXJ0IQAAAAwuQ2FuY2VsTW91c2UQLkN1c3RvbUNoYXJ0UmVjdBcuUGFuZWwuSW1hZ2VCZXZlbC5XaWR0aB0uUGFuZWwuSW1hZ2VCZXZlbC5QZW4uVmlzaWJsZR0uUGFuZWwuSW1hZ2VCZXZlbC5CcnVzaC5Db2xvchIuUGFuZWwuQmV2ZWwuSW5uZXIVLlBhbmVsLkJldmVsLkNvbG9yT25lGy5QYW5lbC5CZXZlbC5TdHJpbmdDb2xvck9uZRUuUGFuZWwuQmV2ZWwuQ29sb3JUd28bLlBhbmVsLkJldmVsLlN0cmluZ0NvbG9yVHdvEi5QYW5lbC5CZXZlbC5PdXRlchUuUGFuZWwuU2hhZG93LlZpc2libGUgLlBhbmVsLkJydXNoLkdyYWRpZW50LlN0YXJ0Q29sb3IhLlBhbmVsLkJydXNoLkdyYWRpZW50Lk1pZGRsZUNvbG9yEC5QYW5lbC5QZW4uQ29sb3ISLlBhbmVsLlBlbi5WaXNpYmxlES5QYW5lbC5QZW4uRW5kQ2FwDS5IZWFkZXIuTGluZXMRLkhlYWRlci5Gb250Lk5hbWUfLkhlYWRlci5Gb250LlNoYWRvdy5CcnVzaC5Db2xvchguSGVhZGVyLkZvbnQuQnJ1c2guQ29sb3IPLkhlYWRlci5WaXNpYmxlDi5XYWxscy5WaXNpYmxlGC5BeGVzLkxlZnQuTGFiZWxzLk9uQXhpcxguQXhlcy5MZWZ0LkF4aXNQZW4uV2lkdGgYLkF4ZXMuTGVmdC5BeGlzUGVuLkNvbG9yFy5BeGVzLlRvcC5BeGlzUGVuLldpZHRoGS5BeGVzLlJpZ2h0LkF4aXNQZW4uV2lkdGgaLkF4ZXMuQm90dG9tLkxhYmVscy5PbkF4aXMaLkF4ZXMuQm90dG9tLkF4aXNQZW4uV2lkdGgaLkF4ZXMuQm90dG9tLkF4aXNQZW4uQ29sb3IcLkF4ZXMuRGVwdGhUb3AuQXhpc1Blbi5XaWR0aBkuQXhlcy5EZXB0aC5BeGlzUGVuLldpZHRoAAAAAAQEBAEEAQQABAQEAAQGAQQEAAAAAAQAAAAABAAAAQEIARRTeXN0ZW0uRHJhd2luZy5Db2xvcgMAAAAjU3RlZW1hLlRlZUNoYXJ0LkRyYXdpbmcuQmV2ZWxTdHlsZXMCAAAAFFN5c3RlbS5EcmF3aW5nLkNvbG9yAwAAABRTeXN0ZW0uRHJhd2luZy5Db2xvcgMAAAAjU3RlZW1hLlRlZUNoYXJ0LkRyYXdpbmcuQmV2ZWxTdHlsZXMCAAAAARRTeXN0ZW0uRHJhd2luZy5Db2xvcgMAAAAUU3lzdGVtLkRyYXdpbmcuQ29sb3IDAAAAFFN5c3RlbS5EcmF3aW5nLkNvbG9yAwAAAAEgU3lzdGVtLkRyYXdpbmcuRHJhd2luZzJELkxpbmVDYXADAAAAFFN5c3RlbS5EcmF3aW5nLkNvbG9yAwAAABRTeXN0ZW0uRHJhd2luZy5Db2xvcgMAAAABAQEIFFN5c3RlbS5EcmF3aW5nLkNvbG9yAwAAAAgIAQgUU3lzdGVtLkRyYXdpbmcuQ29sb3IDAAAACAgCAAAAAAACAAAAAAX8////FFN5c3RlbS5EcmF3aW5nLkNvbG9yBAAAAARuYW1lBXZhbHVlCmtub3duQ29sb3IFc3RhdGUBAAAACQcHAwAAAAr/6Oj+AAAAAAAAAgAF+////yNTdGVlbWEuVGVlQ2hhcnQuRHJhd2luZy5CZXZlbFN0eWxlcwEAAAAHdmFsdWVfXwAIAgAAAAIAAAAB+v////z///8KgAAA/gAAAAAAAAIABgcAAAAIRkUwMDAwODAB+P////z///8KgAAA/gAAAAAAAAIABgkAAAAIRkUwMDAwODAB9v////v///8BAAAAAQH1/////P///wr/6ur+AAAAAAAAAgAB9P////z///8K/+rq/gAAAAAAAAIAAfP////8////CoAAAP4AAAAAAAACAAEF8v///yBTeXN0ZW0uRHJhd2luZy5EcmF3aW5nMkQuTGluZUNhcAEAAAAHdmFsdWVfXwAIAwAAAAIAAAAJDwAAAAYQAAAABlRhaG9tYQHv/////P///wrg4OD/AAAAAAAAAgAB7v////z///8KgAAA/gAAAAAAAAIAAAAAAQAAAAHt/////P///wqpqan+AAAAAAAAAgABAAAAAQAAAAABAAAAAez////8////Cqmpqf4AAAAAAAACAAEAAAABAAAAEQ8AAAABAAAABhUAAAAZVGVlQ2hhcnQncyBBY3Rpdml0eSBHYXVnZQs="
				TempChart="Httphandler" AutoPostback="False" 
                GetChartFile="/TeeChartForNET/GetChart.aspx" PictureFormat="JScript" 
                Height="300px" Width="650px" LastFileName=""></tchart:WebChart>
			<asp:Label id="Label3" style="Z-INDEX: 108; LEFT: 28px; POSITION: absolute; TOP: 16px" runat="server"
				Width="584px" Height="36px"></asp:Label>
		</form>
	</body>
</HTML>
