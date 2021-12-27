<%@ Page language="c#" Inherits="WebDemo.Chart_Styles.Statistical.VolumePipeChart" CodeFile="volumepipechart.aspx.cs" %>
<%@ Register TagPrefix="tchart" Namespace="Steema.TeeChart.Web" Assembly="TeeChart" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>VolumePipeChart</title>
		<LINK href="..\..\Styles\ContentStyles.css" type="text/css" rel="stylesheet">
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<tchart:WebChart id="WebChart1" style="Z-INDEX: 110; LEFT: 24px; POSITION: absolute; TOP: 60px" runat="server"
				Width="432px" AutoPostback="False" TempChart="Httphandler" Config="AAEAAAD/////AQAAAAAAAAAMAgAAAFJUZWVDaGFydCwgVmVyc2lvbj0zLjAuMjY3OS4yOTg1MywgQ3VsdHVyZT1uZXV0cmFsLCBQdWJsaWNLZXlUb2tlbj05YzgxMjYyNzZjNzdiZGI3DAMAAABRU3lzdGVtLkRyYXdpbmcsIFZlcnNpb249Mi4wLjAuMCwgQ3VsdHVyZT1uZXV0cmFsLCBQdWJsaWNLZXlUb2tlbj1iMDNmNWY3ZjExZDUwYTNhBQEAAAAVU3RlZW1hLlRlZUNoYXJ0LkNoYXJ0IgAAAA4uV2FsbHMuVmlzaWJsZRsuU3ViSGVhZGVyLkZvbnQuQnJ1c2guQ29sb3IOLkFzcGVjdC5WaWV3M0QZLkxlZ2VuZC5UaXRsZS5QZW4uVmlzaWJsZRMuTGVnZW5kLlRyYW5zcGFyZW50EC5QYW5lbC5QZW4uQ29sb3ISLlBhbmVsLlBlbi5WaXNpYmxlES5QYW5lbC5QZW4uRW5kQ2FwFS5QYW5lbC5CZXZlbC5Db2xvck9uZRUuUGFuZWwuQmV2ZWwuQ29sb3JUd28SLlBhbmVsLkJldmVsLk91dGVyEi5QYW5lbC5CZXZlbC5Jbm5lchcuUGFuZWwuSW1hZ2VCZXZlbC5XaWR0aB0uUGFuZWwuSW1hZ2VCZXZlbC5QZW4uVmlzaWJsZSEuUGFuZWwuQnJ1c2guR3JhZGllbnQuTWlkZGxlQ29sb3IgLlBhbmVsLkJydXNoLkdyYWRpZW50LlN0YXJ0Q29sb3IVLlBhbmVsLlNoYWRvdy5WaXNpYmxlDS5IZWFkZXIuTGluZXMRLkhlYWRlci5Gb250LlNpemUaLkhlYWRlci5Gb250LlNoYWRvdy5IZWlnaHQZLkhlYWRlci5Gb250LlNoYWRvdy5XaWR0aBsuSGVhZGVyLkZvbnQuU2hhZG93LlZpc2libGURLkhlYWRlci5Gb250Lk5hbWUWLkhlYWRlci5Gb250LlNpemVGbG9hdBguQXhlcy5MZWZ0LkxhYmVscy5PbkF4aXMYLkF4ZXMuTGVmdC5BeGlzUGVuLldpZHRoES5BeGVzLlRvcC5WaXNpYmxlFy5BeGVzLlRvcC5BeGlzUGVuLldpZHRoGS5BeGVzLkRlcHRoLkF4aXNQZW4uV2lkdGgaLkF4ZXMuQm90dG9tLkxhYmVscy5PbkF4aXMaLkF4ZXMuQm90dG9tLkF4aXNQZW4uV2lkdGgTLkF4ZXMuUmlnaHQuVmlzaWJsZRkuQXhlcy5SaWdodC5BeGlzUGVuLldpZHRoHC5BeGVzLkRlcHRoVG9wLkF4aXNQZW4uV2lkdGgABAAAAAQABAQEBAQAAAQEAAYAAAAAAQAAAAAAAAAAAAAAARRTeXN0ZW0uRHJhd2luZy5Db2xvcgMAAAABAQEUU3lzdGVtLkRyYXdpbmcuQ29sb3IDAAAAASBTeXN0ZW0uRHJhd2luZy5EcmF3aW5nMkQuTGluZUNhcAMAAAAUU3lzdGVtLkRyYXdpbmcuQ29sb3IDAAAAFFN5c3RlbS5EcmF3aW5nLkNvbG9yAwAAACNTdGVlbWEuVGVlQ2hhcnQuRHJhd2luZy5CZXZlbFN0eWxlcwIAAAAjU3RlZW1hLlRlZUNoYXJ0LkRyYXdpbmcuQmV2ZWxTdHlsZXMCAAAACAEUU3lzdGVtLkRyYXdpbmcuQ29sb3IDAAAAFFN5c3RlbS5EcmF3aW5nLkNvbG9yAwAAAAEICAgBCwEIAQgIAQgBCAgCAAAAAAX8////FFN5c3RlbS5EcmF3aW5nLkNvbG9yBAAAAARuYW1lBXZhbHVlCmtub3duQ29sb3IFc3RhdGUBAAAACQcHAwAAAAoAAAAAAAAAACUAAQAAAAEB+/////z///8KgAAA/gAAAAAAAAIAAQX6////IFN5c3RlbS5EcmF3aW5nLkRyYXdpbmcyRC5MaW5lQ2FwAQAAAAd2YWx1ZV9fAAgDAAAAAgAAAAH5/////P///wqAAAD+AAAAAAAAAgAB+P////z///8KgAAA/gAAAAAAAAIABff///8jU3RlZW1hLlRlZUNoYXJ0LkRyYXdpbmcuQmV2ZWxTdHlsZXMBAAAAB3ZhbHVlX18ACAIAAAABAAAAAfb////3////AgAAAAIAAAAAAfX////8////Cv/q6v4AAAAAAAACAAH0/////P///wr/6ur+AAAAAAAAAgABCQ0AAAAMAAAAAgAAAAIAAAABBg4AAAAGVGFob21hAABAQQABAAAAAAEAAAABAAAAAAEAAAAAAQAAAAEAAAARDQAAAAEAAAAGDwAAABZWb2x1bWVQaXBlIFN0eWxlIENoYXJ0Cw=="
				Height="290px" GetChartFile="/TeeChartForNET/GetChart.aspx"></tchart:WebChart>
			<asp:Label id="Label3" style="Z-INDEX: 108; LEFT: 28px; POSITION: absolute; TOP: 16px" runat="server"
				Width="584px" Height="36px">VolumePipe Chart Style</asp:Label>
			<DIV style="Z-INDEX: 109; LEFT: 24px; WIDTH: 560px; POSITION: absolute; TOP: 376px; HEIGHT: 13px"></DIV>
		</form>
	</body>
</HTML>
