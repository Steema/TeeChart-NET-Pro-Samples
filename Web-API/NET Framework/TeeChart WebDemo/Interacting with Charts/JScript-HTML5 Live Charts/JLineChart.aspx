<%@ Page language="c#" Inherits="WebDemo.JLineChart1" CodeFile="JLineChart.aspx.cs" %>
<%@ Register TagPrefix="tchart" Namespace="Steema.TeeChart.Web" Assembly="TeeChart" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>JLineChart</title>
		<LINK href="..\..\Styles\ContentStyles.css" type="text/css" rel="stylesheet">
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<asp:label id="Label1" style="Z-INDEX: 106; LEFT: 676px; POSITION: absolute; TOP: 68px" runat="server">Smoothing Factor:</asp:label>
            
            <select id="factor" style="Z-INDEX: 106; LEFT: 800px; POSITION: absolute; TOP: 68px"  onchange="WebChart1_chart.series.items[0].smooth = parseFloat(this.value); WebChart1_chart.series.items[1].smooth = parseFloat(this.value); WebChart1_chart.draw();">
              <option value="0">None</option>
              <option value="0.2">1/5</option>
              <option value="0.25">1/4</option>
              <option value="0.333333333" selected>1/3</option>
              <option value="0.5">1/2</option>
              <option value="0.666666666">2/3</option>
            </SELECT>
			<tchart:WebChart id="WebChart1" 
                style="Z-INDEX: 107; LEFT: 24px; POSITION: absolute; TOP: 60px; height: 350px; width: 640px;" 
                runat="server" Config="AAEAAAD/////AQAAAAAAAAAMAgAAAFFUZWVDaGFydCwgVmVyc2lvbj00LjEuMjAxNy42MjkwLCBDdWx0dXJlPW5ldXRyYWwsIFB1YmxpY0tleVRva2VuPTljODEyNjI3NmM3N2JkYjcMAwAAAFFTeXN0ZW0uRHJhd2luZywgVmVyc2lvbj00LjAuMC4wLCBDdWx0dXJlPW5ldXRyYWwsIFB1YmxpY0tleVRva2VuPWIwM2Y1ZjdmMTFkNTBhM2EFAQAAABVTdGVlbWEuVGVlQ2hhcnQuQ2hhcnQvAAAADC5DYW5jZWxNb3VzZQ0uQ3VycmVudFRoZW1lEC5DdXN0b21DaGFydFJlY3QXLlBhbmVsLkltYWdlQmV2ZWwuV2lkdGgdLlBhbmVsLkltYWdlQmV2ZWwuUGVuLlZpc2libGUdLlBhbmVsLkltYWdlQmV2ZWwuQnJ1c2guQ29sb3IVLlBhbmVsLkJldmVsLkNvbG9yT25lGy5QYW5lbC5CZXZlbC5TdHJpbmdDb2xvck9uZRUuUGFuZWwuQmV2ZWwuQ29sb3JUd28bLlBhbmVsLkJldmVsLlN0cmluZ0NvbG9yVHdvEi5QYW5lbC5CZXZlbC5PdXRlch0uUGFuZWwuQnJ1c2guR3JhZGllbnQuVmlzaWJsZRIuUGFuZWwuQnJ1c2guQ29sb3IRLkxlZ2VuZC5Gb250LlNpemUWLkxlZ2VuZC5Gb250LlNpemVGbG9hdBguTGVnZW5kLkZvbnQuQnJ1c2guQ29sb3IWLkxlZ2VuZC5TaGFkb3cuVmlzaWJsZQ0uSGVhZGVyLkxpbmVzES5IZWFkZXIuRm9udC5TaXplFi5IZWFkZXIuRm9udC5TaXplRmxvYXQYLkhlYWRlci5Gb250LkJydXNoLkNvbG9yDy5IZWFkZXIuVmlzaWJsZQ4uQXNwZWN0LlZpZXczRBkuV2FsbHMuQmFjay5CcnVzaC5WaXNpYmxlEy5XYWxscy5CYWNrLlZpc2libGUOLldhbGxzLlZpc2libGUbLkF4ZXMuTGVmdC5MYWJlbHMuRm9udC5TaXplIC5BeGVzLkxlZnQuTGFiZWxzLkZvbnQuU2l6ZUZsb2F0Ii5BeGVzLkxlZnQuTGFiZWxzLkZvbnQuQnJ1c2guQ29sb3IZLkF4ZXMuTGVmdC5HcmlkLkRyYXdFdmVyeRouQXhlcy5MZWZ0LlRpdGxlLkZvbnQuU2l6ZR8uQXhlcy5MZWZ0LlRpdGxlLkZvbnQuU2l6ZUZsb2F0IS5BeGVzLkxlZnQuVGl0bGUuRm9udC5CcnVzaC5Db2xvchouQXhlcy5Ub3AuTGFiZWxzLkZvbnQuU2l6ZR8uQXhlcy5Ub3AuTGFiZWxzLkZvbnQuU2l6ZUZsb2F0IS5BeGVzLlRvcC5MYWJlbHMuRm9udC5CcnVzaC5Db2xvchwuQXhlcy5SaWdodC5MYWJlbHMuRm9udC5TaXplIS5BeGVzLlJpZ2h0LkxhYmVscy5Gb250LlNpemVGbG9hdCMuQXhlcy5SaWdodC5MYWJlbHMuRm9udC5CcnVzaC5Db2xvch0uQXhlcy5Cb3R0b20uTGFiZWxzLkZvbnQuU2l6ZSIuQXhlcy5Cb3R0b20uTGFiZWxzLkZvbnQuU2l6ZUZsb2F0JC5BeGVzLkJvdHRvbS5MYWJlbHMuRm9udC5CcnVzaC5Db2xvchsuQXhlcy5Cb3R0b20uR3JpZC5EcmF3RXZlcnkcLkF4ZXMuQm90dG9tLlRpdGxlLkZvbnQuU2l6ZSEuQXhlcy5Cb3R0b20uVGl0bGUuRm9udC5TaXplRmxvYXQjLkF4ZXMuQm90dG9tLlRpdGxlLkZvbnQuQnJ1c2guQ29sb3IPLkF4ZXMuQXV0b21hdGljAAQAAAAEBAEEAQQABAAABAAGAAAEAAAAAAAAAAQAAAAEAAAEAAAEAAAEAAAABAABGVN0ZWVtYS5UZWVDaGFydC5UaGVtZVR5cGUCAAAAAQgBFFN5c3RlbS5EcmF3aW5nLkNvbG9yAwAAABRTeXN0ZW0uRHJhd2luZy5Db2xvcgMAAAAUU3lzdGVtLkRyYXdpbmcuQ29sb3IDAAAAI1N0ZWVtYS5UZWVDaGFydC5EcmF3aW5nLkJldmVsU3R5bGVzAgAAAAEUU3lzdGVtLkRyYXdpbmcuQ29sb3IDAAAACAsUU3lzdGVtLkRyYXdpbmcuQ29sb3IDAAAAAQgLFFN5c3RlbS5EcmF3aW5nLkNvbG9yAwAAAAEBAQEBCAsUU3lzdGVtLkRyYXdpbmcuQ29sb3IDAAAACAgLFFN5c3RlbS5EcmF3aW5nLkNvbG9yAwAAAAgLFFN5c3RlbS5EcmF3aW5nLkNvbG9yAwAAAAgLFFN5c3RlbS5EcmF3aW5nLkNvbG9yAwAAAAgLFFN5c3RlbS5EcmF3aW5nLkNvbG9yAwAAAAgICxRTeXN0ZW0uRHJhd2luZy5Db2xvcgMAAAABAgAAAAAF/P///xlTdGVlbWEuVGVlQ2hhcnQuVGhlbWVUeXBlAQAAAAd2YWx1ZV9fAAgCAAAAAAAAAAACAAAAAAX7////FFN5c3RlbS5EcmF3aW5nLkNvbG9yBAAAAARuYW1lBXZhbHVlCmtub3duQ29sb3IFc3RhdGUBAAAACQcHAwAAAAr/6Oj+AAAAAAAAAgAB+v////v///8KgAAA/gAAAAAAAAIABgcAAAAIRkUwMDAwODAB+P////v///8KgAAA/gAAAAAAAAIABgkAAAAIRkUwMDAwODAF9v///yNTdGVlbWEuVGVlQ2hhcnQuRHJhd2luZy5CZXZlbFN0eWxlcwEAAAAHdmFsdWVfXwAIAgAAAAAAAAAAAfX////7////Cv////8AAAAAAAACAAkAAAAAABBBAfT////7////CkBAQP8AAAAAAAACAAAJDQAAAAwAAAAAAEBBAfL////7////CgAAAAAAAAAATgABAAAAAAAACQAAAAAAEEEB8f////v///8KAAAAAAAAAABOAAEAAgAAAAsAAAAAADBBAfD////7////CkBAQP8AAAAAAAACAAkAAAAAABBBAe/////7////CkBAQP8AAAAAAAACAAkAAAAAABBBAe7////7////CkBAQP8AAAAAAAACAAkAAAAAABBBAe3////7////CoCAgP8AAAAAAAACAAIAAAALAAAAAAAwQQHs////+////wpAQED/AAAAAAAAAgABEQ0AAAABAAAABhUAAAAKTGluZSBTdHlsZQs="
				TempChart="Httphandler" AutoPostback="False" 
                GetChartFile="/TeeChartForNET/GetChart.aspx" PictureFormat="JScript" 
                Height="350px" width="640px" LastFileName=""></tchart:WebChart>
			<asp:Label id="Label3" style="Z-INDEX: 108; LEFT: 28px; POSITION: absolute; TOP: 16px" runat="server"
				Width="584px" Height="36px">Line Style</asp:Label>
            <asp:Label id="Label2" style="Z-INDEX: 108; LEFT: 28px; POSITION: absolute; TOP: 420px" runat="server"
				Width="584px" Height="36px">
                TeeChart Javascript chart exported from TeeChart for .NET. The chart is live for 
                zoom and scroll and may be further customised using Javascript.</asp:Label>
		</form>
	</body>
</HTML>
