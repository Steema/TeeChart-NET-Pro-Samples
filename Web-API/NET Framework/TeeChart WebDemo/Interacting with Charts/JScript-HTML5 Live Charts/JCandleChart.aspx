<%@ Page language="c#" Inherits="WebDemo.JCandleChart1" CodeFile="JCandleChart.aspx.cs" %>
<%@ Register TagPrefix="tchart" Namespace="Steema.TeeChart.Web" Assembly="TeeChart" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>JCandleChart</title>
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

                WebChart1_chart.series.items[0].lower.fill=WebChart1_chart.palette.colors[1];

                WebChart1_chart.draw();
            }

            var STARTAXISMIN, STARTAXISMAX;
        </script>
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<asp:label id="Label1" 
                style="Z-INDEX: 106; LEFT: 700px; POSITION: absolute; TOP: 71px" runat="server">JScript Themes:</asp:label>
            <select id="theme" style="Z-INDEX: 106; LEFT: 820px; POSITION: absolute; TOP: 68px"  onchange="changeTheme(this.value);">
              <option value="">Default</option>
              <option value="dark">Dark</option>
              <option value="daybreak">Daybreak</option>    
              <option value="excel">Microsoft Excel (TM)</option>
              <option value="minimal" selected>Minimal</option>  
              <option value="twilight">Twilight</option>
              </select>
            <asp:label id="Label2" 
                style="Z-INDEX: 106; LEFT: 700px; POSITION: absolute; TOP: 101px" runat="server">JScript Palettes:</asp:label>
            <select id="palette" style="Z-INDEX: 106; LEFT: 820px; POSITION: absolute; TOP: 98px" onchange="changePalette(this.value);">
              <option value="">Default</option>
              <option value="cool">Cool</option> 
              <option value="excel">Microsoft Excel (TM)</option>  
              <option value="onBlack">On Black</option>
              <option value="opera">Opera</option>
              <option value="rainbow">Rainbow</option>
              <option value="redRiver">Red River</option>
              <option value="seaWash" selected>Sea Wash</option>
              <option value="warm">Warm</option>  
              <option value="windowsxp">Windows XP</option>  
            </select>
            <asp:label id="Label4" 
                style="Z-INDEX: 106; LEFT: 700px; POSITION: absolute; TOP: 131px" runat="server">Date formats:</asp:label>
            <select id="format" style="Z-INDEX: 106; LEFT: 820px; POSITION: absolute; TOP: 128px" onchange="WebChart1_chart.axes.bottom.labels.dateFormat=this.value; WebChart1_chart.draw();">
              <option value="shortDate" selected>Short Date</option>
              <option value="mediumDate">Medium Date</option>
              <option value="longDate">Long Date</option>
              <option value="isoDate">ISO Date</option>
              <option value="default">Default</option>
              <option value="shortTime">Short Time</option>
              <option value="mediumTime">Medium Time</option>
              <option value="longTime">Long Time</option>
              <option value="isoTime">ISO Time</option>
              <option value="isoDateTime">ISO Date and Time</option>
              <option value="'Custom: ' yyyy, m d">Custom</option>
            </select>
            <asp:label id="Label5" 
                style="Z-INDEX: 106; LEFT: 700px; POSITION: absolute; TOP: 161px" runat="server">Candle Style:</asp:label>
            <select id="style" style="Z-INDEX: 106; LEFT: 820px; POSITION: absolute; TOP: 158px" onchange="WebChart1_chart.series.items[0].style=this.value; WebChart1_chart.draw();">
              <option value="candle" selected>Candle</option>
              <option value="bar">Candle Bar</option>
              <option value="openclose">Open-Close</option>
            </select>

			<tchart:WebChart id="WebChart1" 
                
                style="Z-INDEX: 107; LEFT: 24px; POSITION: absolute; TOP: 60px; height: 360px; width: 650px;" 
                runat="server" Config="AAEAAAD/////AQAAAAAAAAAMAgAAAFFUZWVDaGFydCwgVmVyc2lvbj00LjEuMjAxMy41MjgxLCBDdWx0dXJlPW5ldXRyYWwsIFB1YmxpY0tleVRva2VuPTljODEyNjI3NmM3N2JkYjcMAwAAAFFTeXN0ZW0uRHJhd2luZywgVmVyc2lvbj00LjAuMC4wLCBDdWx0dXJlPW5ldXRyYWwsIFB1YmxpY0tleVRva2VuPWIwM2Y1ZjdmMTFkNTBhM2EFAQAAABVTdGVlbWEuVGVlQ2hhcnQuQ2hhcnQmAAAAEC5DdXN0b21DaGFydFJlY3QXLlBhbmVsLkltYWdlQmV2ZWwuV2lkdGgdLlBhbmVsLkltYWdlQmV2ZWwuUGVuLlZpc2libGUdLlBhbmVsLkltYWdlQmV2ZWwuQnJ1c2guQ29sb3ISLlBhbmVsLkJldmVsLklubmVyFS5QYW5lbC5CZXZlbC5Db2xvck9uZRsuUGFuZWwuQmV2ZWwuU3RyaW5nQ29sb3JPbmUVLlBhbmVsLkJldmVsLkNvbG9yVHdvGy5QYW5lbC5CZXZlbC5TdHJpbmdDb2xvclR3bxIuUGFuZWwuQmV2ZWwuT3V0ZXIVLlBhbmVsLlNoYWRvdy5WaXNpYmxlIC5QYW5lbC5CcnVzaC5HcmFkaWVudC5TdGFydENvbG9yIS5QYW5lbC5CcnVzaC5HcmFkaWVudC5NaWRkbGVDb2xvchAuUGFuZWwuUGVuLkNvbG9yEi5QYW5lbC5QZW4uVmlzaWJsZREuUGFuZWwuUGVuLkVuZENhcBEuSGVhZGVyLkFsaWdubWVudA0uSGVhZGVyLkxpbmVzES5IZWFkZXIuRm9udC5OYW1lES5IZWFkZXIuRm9udC5TaXplFi5IZWFkZXIuRm9udC5TaXplRmxvYXQfLkhlYWRlci5Gb250LlNoYWRvdy5CcnVzaC5Db2xvchsuSGVhZGVyLkZvbnQuU2hhZG93LlZpc2libGUYLkhlYWRlci5Gb250LkJydXNoLkNvbG9yDi5Bc3BlY3QuVmlldzNEDi5XYWxscy5WaXNpYmxlGC5BeGVzLkxlZnQuTGFiZWxzLk9uQXhpcxguQXhlcy5MZWZ0LkF4aXNQZW4uV2lkdGgYLkF4ZXMuTGVmdC5BeGlzUGVuLkNvbG9yHS5BeGVzLkxlZnQuTWlub3JUaWNrcy5WaXNpYmxlFy5BeGVzLlRvcC5BeGlzUGVuLldpZHRoGS5BeGVzLlJpZ2h0LkF4aXNQZW4uV2lkdGgaLkF4ZXMuQm90dG9tLkxhYmVscy5PbkF4aXMaLkF4ZXMuQm90dG9tLkF4aXNQZW4uV2lkdGgaLkF4ZXMuQm90dG9tLkF4aXNQZW4uQ29sb3IfLkF4ZXMuQm90dG9tLk1pbm9yVGlja3MuVmlzaWJsZRwuQXhlcy5EZXB0aFRvcC5BeGlzUGVuLldpZHRoGS5BeGVzLkRlcHRoLkF4aXNQZW4uV2lkdGgAAAAEBAQBBAEEAAQEBAAEBAYBAAAEAAQAAAAABAAAAAAABAAAAAEIARRTeXN0ZW0uRHJhd2luZy5Db2xvcgMAAAAjU3RlZW1hLlRlZUNoYXJ0LkRyYXdpbmcuQmV2ZWxTdHlsZXMCAAAAFFN5c3RlbS5EcmF3aW5nLkNvbG9yAwAAABRTeXN0ZW0uRHJhd2luZy5Db2xvcgMAAAAjU3RlZW1hLlRlZUNoYXJ0LkRyYXdpbmcuQmV2ZWxTdHlsZXMCAAAAARRTeXN0ZW0uRHJhd2luZy5Db2xvcgMAAAAUU3lzdGVtLkRyYXdpbmcuQ29sb3IDAAAAFFN5c3RlbS5EcmF3aW5nLkNvbG9yAwAAAAEgU3lzdGVtLkRyYXdpbmcuRHJhd2luZzJELkxpbmVDYXADAAAAHlN5c3RlbS5EcmF3aW5nLlN0cmluZ0FsaWdubWVudAMAAAAICxRTeXN0ZW0uRHJhd2luZy5Db2xvcgMAAAABFFN5c3RlbS5EcmF3aW5nLkNvbG9yAwAAAAEBAQgUU3lzdGVtLkRyYXdpbmcuQ29sb3IDAAAAAQgIAQgUU3lzdGVtLkRyYXdpbmcuQ29sb3IDAAAAAQgIAgAAAAACAAAAAAX8////FFN5c3RlbS5EcmF3aW5nLkNvbG9yBAAAAARuYW1lBXZhbHVlCmtub3duQ29sb3IFc3RhdGUBAAAACQcHAwAAAAr/6Oj+AAAAAAAAAgAF+////yNTdGVlbWEuVGVlQ2hhcnQuRHJhd2luZy5CZXZlbFN0eWxlcwEAAAAHdmFsdWVfXwAIAgAAAAIAAAAB+v////z///8KgAAA/gAAAAAAAAIABgcAAAAIRkUwMDAwODAB+P////z///8KgAAA/gAAAAAAAAIABgkAAAAIRkUwMDAwODAB9v////v///8BAAAAAQH1/////P///wr/6ur+AAAAAAAAAgAB9P////z///8K/+rq/gAAAAAAAAIAAfP////8////CoAAAP4AAAAAAAACAAEF8v///yBTeXN0ZW0uRHJhd2luZy5EcmF3aW5nMkQuTGluZUNhcAEAAAAHdmFsdWVfXwAIAwAAAAIAAAAF8f///x5TeXN0ZW0uRHJhd2luZy5TdHJpbmdBbGlnbm1lbnQBAAAAB3ZhbHVlX18ACAMAAAAAAAAACRAAAAAGEQAAAAZUYWhvbWEMAAAAAABAQQHu/////P///wrg4OD/AAAAAAAAAgABAe3////8////CoAAAP4AAAAAAAACAAAAAAEAAAAB7P////z///8Kqamp/gAAAAAAAAIAAAEAAAABAAAAAAEAAAAB6/////z///8Kqamp/gAAAAAAAAIAAAEAAAABAAAAERAAAAABAAAABhYAAAASRmluYW5jaWFsIENoYXJ0aW5nCw=="
				TempChart="Httphandler" AutoPostback="False" 
                GetChartFile="/TeeChartForNET/GetChart.aspx" PictureFormat="JScript" Width="650px" Height="360px"></tchart:WebChart>
			<asp:Label id="Label3" style="Z-INDEX: 108; LEFT: 28px; POSITION: absolute; TOP: 16px" runat="server"
				Width="584px" Height="36px">TeeChart for .NET - Javascript HTML5 Candle and Volume Styles</asp:Label>
			<DIV style="Z-INDEX: 109; LEFT: 24px; WIDTH: 560px; POSITION: absolute; TOP: 433px; HEIGHT: 13px">
                This Chart, rendered with HTML5, is using a Candle (OHLC) Series and a Volume Series. The Chart includes custom axes to define an independent zone for the Volume data. Zoom and Scroll have been set to allow horizontal zoom only (zoom in drag with right mousebutton ro right and unzoom dragging with right mousebutton to left) and horizontal scroll (use left mousebutton). The example shows how visualisation themes may be applied to the Chart and different datetime format for Axis labels.<br />
                <br />
                 <a href="../../index.aspx">Return to examples start page</a></DIV>
		</form>
	</body>
</HTML>
