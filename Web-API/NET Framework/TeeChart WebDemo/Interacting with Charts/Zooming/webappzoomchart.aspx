<%@ Page language="c#" Inherits="WebDemo.Interacting_with_Charts.Zooming.WebAppZoomChart" CodeFile="WebAppZoomChart.aspx.cs" %>
<%@ Register TagPrefix="tchart" Namespace="Steema.TeeChart.Web" Assembly="TeeChart" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>WebAppZoomChart</title>
		<LINK href="..\..\Styles\ContentStyles.css" type="text/css" rel="stylesheet">
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<tchart:WebChart id="WebChart1" style="Z-INDEX: 100; LEFT: 24px; POSITION: absolute; TOP: 40px; Width:632px; Height:290px" runat="server"
				Width="632px" Height="290px" Config="AAEAAAD/////AQAAAAAAAAAMAgAAAFFUZWVDaGFydCwgVmVyc2lvbj00LjEuMjAxNy42MjkwLCBDdWx0dXJlPW5ldXRyYWwsIFB1YmxpY0tleVRva2VuPTljODEyNjI3NmM3N2JkYjcMAwAAAFFTeXN0ZW0uRHJhd2luZywgVmVyc2lvbj00LjAuMC4wLCBDdWx0dXJlPW5ldXRyYWwsIFB1YmxpY0tleVRva2VuPWIwM2Y1ZjdmMTFkNTBhM2EFAQAAABVTdGVlbWEuVGVlQ2hhcnQuQ2hhcnQtAAAADC5DYW5jZWxNb3VzZQ0uQ3VycmVudFRoZW1lEC5DdXN0b21DaGFydFJlY3QXLlBhbmVsLkltYWdlQmV2ZWwuV2lkdGgdLlBhbmVsLkltYWdlQmV2ZWwuUGVuLlZpc2libGUVLlBhbmVsLkJldmVsLkNvbG9yT25lGy5QYW5lbC5CZXZlbC5TdHJpbmdDb2xvck9uZRUuUGFuZWwuQmV2ZWwuQ29sb3JUd28bLlBhbmVsLkJldmVsLlN0cmluZ0NvbG9yVHdvFS5QYW5lbC5TaGFkb3cuVmlzaWJsZR0uUGFuZWwuQnJ1c2guR3JhZGllbnQuVmlzaWJsZRIuUGFuZWwuQnJ1c2guQ29sb3IRLkxlZ2VuZC5Gb250LlNpemUWLkxlZ2VuZC5Gb250LlNpemVGbG9hdBguTGVnZW5kLkZvbnQuQnJ1c2guQ29sb3IWLkxlZ2VuZC5TaGFkb3cuVmlzaWJsZQ0uSGVhZGVyLkxpbmVzES5IZWFkZXIuRm9udC5TaXplFi5IZWFkZXIuRm9udC5TaXplRmxvYXQYLkhlYWRlci5Gb250LkJydXNoLkNvbG9yGS5Bc3BlY3QuQ29sb3JQYWxldHRlSW5kZXgOLkFzcGVjdC5WaWV3M0QZLldhbGxzLkJhY2suQnJ1c2guVmlzaWJsZRMuV2FsbHMuQmFjay5WaXNpYmxlGy5BeGVzLkxlZnQuTGFiZWxzLkZvbnQuU2l6ZSAuQXhlcy5MZWZ0LkxhYmVscy5Gb250LlNpemVGbG9hdCIuQXhlcy5MZWZ0LkxhYmVscy5Gb250LkJydXNoLkNvbG9yGS5BeGVzLkxlZnQuR3JpZC5EcmF3RXZlcnkaLkF4ZXMuTGVmdC5UaXRsZS5Gb250LlNpemUfLkF4ZXMuTGVmdC5UaXRsZS5Gb250LlNpemVGbG9hdCEuQXhlcy5MZWZ0LlRpdGxlLkZvbnQuQnJ1c2guQ29sb3IaLkF4ZXMuVG9wLkxhYmVscy5Gb250LlNpemUfLkF4ZXMuVG9wLkxhYmVscy5Gb250LlNpemVGbG9hdCEuQXhlcy5Ub3AuTGFiZWxzLkZvbnQuQnJ1c2guQ29sb3IcLkF4ZXMuUmlnaHQuTGFiZWxzLkZvbnQuU2l6ZSEuQXhlcy5SaWdodC5MYWJlbHMuRm9udC5TaXplRmxvYXQjLkF4ZXMuUmlnaHQuTGFiZWxzLkZvbnQuQnJ1c2guQ29sb3IdLkF4ZXMuQm90dG9tLkxhYmVscy5Gb250LlNpemUiLkF4ZXMuQm90dG9tLkxhYmVscy5Gb250LlNpemVGbG9hdCQuQXhlcy5Cb3R0b20uTGFiZWxzLkZvbnQuQnJ1c2guQ29sb3IbLkF4ZXMuQm90dG9tLkdyaWQuRHJhd0V2ZXJ5HC5BeGVzLkJvdHRvbS5UaXRsZS5Gb250LlNpemUhLkF4ZXMuQm90dG9tLlRpdGxlLkZvbnQuU2l6ZUZsb2F0Iy5BeGVzLkJvdHRvbS5UaXRsZS5Gb250LkJydXNoLkNvbG9yDy5BeGVzLkF1dG9tYXRpYwAEAAAABAEEAQAABAAABAAGAAAEAAAAAAAABAAAAAQAAAQAAAQAAAQAAAAEAAEZU3RlZW1hLlRlZUNoYXJ0LlRoZW1lVHlwZQIAAAABCAEUU3lzdGVtLkRyYXdpbmcuQ29sb3IDAAAAFFN5c3RlbS5EcmF3aW5nLkNvbG9yAwAAAAEBFFN5c3RlbS5EcmF3aW5nLkNvbG9yAwAAAAgLFFN5c3RlbS5EcmF3aW5nLkNvbG9yAwAAAAEICxRTeXN0ZW0uRHJhd2luZy5Db2xvcgMAAAAIAQEBCAsUU3lzdGVtLkRyYXdpbmcuQ29sb3IDAAAACAgLFFN5c3RlbS5EcmF3aW5nLkNvbG9yAwAAAAgLFFN5c3RlbS5EcmF3aW5nLkNvbG9yAwAAAAgLFFN5c3RlbS5EcmF3aW5nLkNvbG9yAwAAAAgLFFN5c3RlbS5EcmF3aW5nLkNvbG9yAwAAAAgICxRTeXN0ZW0uRHJhd2luZy5Db2xvcgMAAAABAgAAAAAF/P///xlTdGVlbWEuVGVlQ2hhcnQuVGhlbWVUeXBlAQAAAAd2YWx1ZV9fAAgCAAAAAAAAAAACAAAAAAX7////FFN5c3RlbS5EcmF3aW5nLkNvbG9yBAAAAARuYW1lBXZhbHVlCmtub3duQ29sb3IFc3RhdGUBAAAACQcHAwAAAAqAAAD+AAAAAAAAAgAGBgAAAAhGRTAwMDA4MAH5////+////wqAAAD+AAAAAAAAAgAGCAAAAAhGRTAwMDA4MAEAAff////7////Cv////8AAAAAAAACAAkAAAAAABBBAfb////7////CkBAQP8AAAAAAAACAAAJCwAAAAwAAAAAAEBBAfT////7////CgAAAAAAAAAATgABABMAAAAAAAAJAAAAAAAQQQHz////+////woAAAAAAAAAAE4AAQACAAAACwAAAAAAMEEB8v////v///8KQEBA/wAAAAAAAAIACQAAAAAAEEEB8f////v///8KQEBA/wAAAAAAAAIACQAAAAAAEEEB8P////v///8KQEBA/wAAAAAAAAIACQAAAAAAEEEB7/////v///8KgICA/wAAAAAAAAIAAgAAAAsAAAAAADBBAe7////7////CkBAQP8AAAAAAAACAAERCwAAAAEAAAAGEwAAAA1DaGFydCBab29taW5nCw=="
				TempChart="Httphandler" AutoPostback="False" GetChartFile="/TeeChartForNET/GetChart.aspx" OnAfterDraw="WebChart1_AfterDraw" OnClickAxis="WebChart1_ClickAxis" OnClickSeries="WebChart1_ClickSeries" LastFileName=""></tchart:WebChart>
			<asp:Label id="Label2" style="Z-INDEX: 106; LEFT: 24px; POSITION: absolute; TOP: 380px" runat="server"
				Height="36px" Width="584px">- To UnZoom click at the bottom right of any area on Chart, drag and release mousebutton at the top and left of the first click.</asp:Label>
			<asp:Label id="Label1" style="Z-INDEX: 105; LEFT: 24px; POSITION: absolute; TOP: 340px" runat="server"
				Height="36px" Width="584px">- To Zoom click at the top left of the area you wish to zoom, drag and release mousebutton at the bottom right of zoom area.</asp:Label>
			<asp:Label id="Label3" style="Z-INDEX: 101; LEFT: 24px; POSITION: absolute; TOP: 16px" runat="server"
				Width="584px" Height="20px"> This sample shows how to use the Zoom Tool.</asp:Label>
			<asp:Button id="Button1" style="Z-INDEX: 103; LEFT: 664px; POSITION: absolute; TOP: 44px" runat="server"
				Text="Update Chart" OnClick="Button1_Click"></asp:Button>
      <asp:Label ID="Label4" runat="server" Height="36px" Style="z-index: 106; left: 25px;
        position: absolute; top: 421px" Width="584px">- Click on Axes or Series points to see value at mouseclick. Move the mouse over a Point to see the PointLabel as a hint.</asp:Label>
		</form>
	</body>
</HTML>
