<%@ Page language="c#" Inherits="WebDemo.JBarChart1" CodeFile="JBarChart.aspx.cs" %>
<%@ Register TagPrefix="tchart" Namespace="Steema.TeeChart.Web" Assembly="TeeChart" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>JBarChart</title>
		<LINK href="..\..\Styles\ContentStyles.css" type="text/css" rel="stylesheet">
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
        <script type="text/javascript">
            function changeTheme(aTheme) {
                WebChart1_chart.applyTheme(aTheme);
                WebChart1_chart.draw();
            }

            function changePalette(palette) {
                WebChart1_chart.applyPalette(palette);
                WebChart1_chart.draw();
            }

        </script>
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<asp:label id="Label1" 
                style="Z-INDEX: 106; LEFT: 700px; POSITION: absolute; TOP: 71px" runat="server">JScript Themes:</asp:label>
            <select id="theme" style="Z-INDEX: 106; LEFT: 820px; POSITION: absolute; TOP: 68px"  onchange="changeTheme(this.value);">
              <option value="" selected>Default</option>
              <option value="dark">Dark</option>
              <option value="daybreak">Daybreak</option>    
              <option value="excel">Microsoft Excel (TM)</option>
              <option value="minimal">Minimal</option>  
              <option value="twilight">Twilight</option>
              </select>
            <asp:label id="Label2" 
                style="Z-INDEX: 106; LEFT: 700px; POSITION: absolute; TOP: 101px" runat="server">JScript Palettes:</asp:label>
            <select id="palette" style="Z-INDEX: 106; LEFT: 820px; POSITION: absolute; TOP: 98px" onchange="changePalette(this.value);">
              <option value="">Default</option>
              <option value="cool">Cool</option> 
              <option value="excel">Microsoft Excel (TM)</option>  
              <option value="onBlack">On Black</option>
              <option value="opera" selected>Opera</option>
              <option value="rainbow">Rainbow</option>
              <option value="redRiver">Red River</option>
              <option value="seaWash">Sea Wash</option>
              <option value="warm">Warm</option>  
              <option value="windowsxp">Windows XP</option>  
            </select>

			<tchart:WebChart id="WebChart1" 
                
                style="Z-INDEX: 107; LEFT: 24px; POSITION: absolute; TOP: 60px; height: 300px; width: 650px;" 
                runat="server" Config="AAEAAAD/////AQAAAAAAAAAMAgAAAFFUZWVDaGFydCwgVmVyc2lvbj00LjEuMjAxMy41MjgxLCBDdWx0dXJlPW5ldXRyYWwsIFB1YmxpY0tleVRva2VuPTljODEyNjI3NmM3N2JkYjcMAwAAAFFTeXN0ZW0uRHJhd2luZywgVmVyc2lvbj00LjAuMC4wLCBDdWx0dXJlPW5ldXRyYWwsIFB1YmxpY0tleVRva2VuPWIwM2Y1ZjdmMTFkNTBhM2EFAQAAABVTdGVlbWEuVGVlQ2hhcnQuQ2hhcnQlAAAAEC5DdXN0b21DaGFydFJlY3QXLlBhbmVsLkltYWdlQmV2ZWwuV2lkdGgdLlBhbmVsLkltYWdlQmV2ZWwuUGVuLlZpc2libGUdLlBhbmVsLkltYWdlQmV2ZWwuQnJ1c2guQ29sb3ISLlBhbmVsLkJldmVsLklubmVyFS5QYW5lbC5CZXZlbC5Db2xvck9uZRsuUGFuZWwuQmV2ZWwuU3RyaW5nQ29sb3JPbmUVLlBhbmVsLkJldmVsLkNvbG9yVHdvGy5QYW5lbC5CZXZlbC5TdHJpbmdDb2xvclR3bxIuUGFuZWwuQmV2ZWwuT3V0ZXIVLlBhbmVsLlNoYWRvdy5WaXNpYmxlIC5QYW5lbC5CcnVzaC5HcmFkaWVudC5TdGFydENvbG9yIS5QYW5lbC5CcnVzaC5HcmFkaWVudC5NaWRkbGVDb2xvchAuUGFuZWwuUGVuLkNvbG9yEi5QYW5lbC5QZW4uVmlzaWJsZREuUGFuZWwuUGVuLkVuZENhcA0uSGVhZGVyLkxpbmVzES5IZWFkZXIuRm9udC5OYW1lES5IZWFkZXIuRm9udC5TaXplFi5IZWFkZXIuRm9udC5TaXplRmxvYXQfLkhlYWRlci5Gb250LlNoYWRvdy5CcnVzaC5Db2xvchsuSGVhZGVyLkZvbnQuU2hhZG93LlZpc2libGUYLkhlYWRlci5Gb250LkJydXNoLkNvbG9yDi5Bc3BlY3QuVmlldzNEDi5XYWxscy5WaXNpYmxlGC5BeGVzLkxlZnQuTGFiZWxzLk9uQXhpcxguQXhlcy5MZWZ0LkF4aXNQZW4uV2lkdGgYLkF4ZXMuTGVmdC5BeGlzUGVuLkNvbG9yHS5BeGVzLkxlZnQuTWlub3JUaWNrcy5WaXNpYmxlFy5BeGVzLlRvcC5BeGlzUGVuLldpZHRoGS5BeGVzLlJpZ2h0LkF4aXNQZW4uV2lkdGgaLkF4ZXMuQm90dG9tLkxhYmVscy5PbkF4aXMaLkF4ZXMuQm90dG9tLkF4aXNQZW4uV2lkdGgaLkF4ZXMuQm90dG9tLkF4aXNQZW4uQ29sb3IfLkF4ZXMuQm90dG9tLk1pbm9yVGlja3MuVmlzaWJsZRwuQXhlcy5EZXB0aFRvcC5BeGlzUGVuLldpZHRoGS5BeGVzLkRlcHRoLkF4aXNQZW4uV2lkdGgAAAAEBAQBBAEEAAQEBAAEBgEAAAQABAAAAAAEAAAAAAAEAAAAAQgBFFN5c3RlbS5EcmF3aW5nLkNvbG9yAwAAACNTdGVlbWEuVGVlQ2hhcnQuRHJhd2luZy5CZXZlbFN0eWxlcwIAAAAUU3lzdGVtLkRyYXdpbmcuQ29sb3IDAAAAFFN5c3RlbS5EcmF3aW5nLkNvbG9yAwAAACNTdGVlbWEuVGVlQ2hhcnQuRHJhd2luZy5CZXZlbFN0eWxlcwIAAAABFFN5c3RlbS5EcmF3aW5nLkNvbG9yAwAAABRTeXN0ZW0uRHJhd2luZy5Db2xvcgMAAAAUU3lzdGVtLkRyYXdpbmcuQ29sb3IDAAAAASBTeXN0ZW0uRHJhd2luZy5EcmF3aW5nMkQuTGluZUNhcAMAAAAICxRTeXN0ZW0uRHJhd2luZy5Db2xvcgMAAAABFFN5c3RlbS5EcmF3aW5nLkNvbG9yAwAAAAEBAQgUU3lzdGVtLkRyYXdpbmcuQ29sb3IDAAAAAQgIAQgUU3lzdGVtLkRyYXdpbmcuQ29sb3IDAAAAAQgIAgAAAAACAAAAAAX8////FFN5c3RlbS5EcmF3aW5nLkNvbG9yBAAAAARuYW1lBXZhbHVlCmtub3duQ29sb3IFc3RhdGUBAAAACQcHAwAAAAr/6Oj+AAAAAAAAAgAF+////yNTdGVlbWEuVGVlQ2hhcnQuRHJhd2luZy5CZXZlbFN0eWxlcwEAAAAHdmFsdWVfXwAIAgAAAAIAAAAB+v////z///8KgAAA/gAAAAAAAAIABgcAAAAIRkUwMDAwODAB+P////z///8KgAAA/gAAAAAAAAIABgkAAAAIRkUwMDAwODAB9v////v///8BAAAAAQH1/////P///wr/6ur+AAAAAAAAAgAB9P////z///8K/+rq/gAAAAAAAAIAAfP////8////CoAAAP4AAAAAAAACAAEF8v///yBTeXN0ZW0uRHJhd2luZy5EcmF3aW5nMkQuTGluZUNhcAEAAAAHdmFsdWVfXwAIAwAAAAIAAAAJDwAAAAYQAAAABlRhaG9tYQwAAAAAAEBBAe/////8////CuDg4P8AAAAAAAACAAEB7v////z///8KgAAA/gAAAAAAAAIAAAAAAQAAAAHt/////P///wqpqan+AAAAAAAAAgAAAQAAAAEAAAAAAQAAAAHs/////P///wqpqan+AAAAAAAAAgAAAQAAAAEAAAARDwAAAAEAAAAGFQAAAAlCYXIgU3R5bGUL"
				TempChart="Httphandler" AutoPostback="False" 
                GetChartFile="/TeeChartForNET/GetChart.aspx" PictureFormat="JScript" 
                Height="300px" Width="650px"></tchart:WebChart>
			<asp:Label id="Label3" style="Z-INDEX: 108; LEFT: 28px; POSITION: absolute; TOP: 16px" runat="server"
				Width="584px" Height="36px">Bar Styles</asp:Label>
			<DIV style="Z-INDEX: 109; LEFT: 28px; WIDTH: 560px; POSITION: absolute; TOP: 392px; HEIGHT: 13px">
                TeeChart Javascript chart exported from TeeChart for .NET. The chart is live for 
                zoom and scroll and may be further customised using Javascript.</DIV>
		</form>
	</body>
</HTML>
