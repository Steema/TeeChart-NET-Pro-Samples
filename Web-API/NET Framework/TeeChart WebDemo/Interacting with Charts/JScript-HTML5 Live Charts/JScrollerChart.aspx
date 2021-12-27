<%@ Page language="c#" Inherits="WebDemo.JScrollerChart1" CodeFile="JScrollerChart.aspx.cs" %>
<%@ Register TagPrefix="tchart" Namespace="Steema.TeeChart.Web" Assembly="TeeChart" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>JScrollerChart</title>
		<LINK href="..\..\Styles\ContentStyles.css" type="text/css" rel="stylesheet">
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
        <script type="text/javascript">
            var scroller;

            function changeTheme(aTheme) {
               
                WebChart1_chart.applyTheme(aTheme);

                scroller.scroller.back.gradient.visible = false;
                scroller.scroller.back.fill = "";

                if (aTheme == "dark") {
                    scroller.panel.format.gradient.colors = ["black", "black"];
                }
                else if ((aTheme == "minimal") || (aTheme == "excel")) {
                    scroller.scroller.back.gradient.visible = false;
                    scroller.panel.format.fill = "white";
                    scroller.panel.format.gradient.colors = ["white", "white"];
                }
                else {
                    scroller.panel.format.gradient.visible = true;
                    if (WebChart1_chart.panel.format.gradient.colors.length > 1)
                        scroller.panel.format.gradient.colors = [WebChart1_chart.panel.format.gradient.colors[0], WebChart1_chart.panel.format.gradient.colors[1]];
                    else
                        scroller.panel.format.gradient.colors = ["white"];
                }

                scroller.draw();
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
                
                style="Z-INDEX: 107; LEFT: 24px; POSITION: absolute; TOP: 60px; height: 370px; width: 560px;" 
                runat="server" Config="AAEAAAD/////AQAAAAAAAAAMAgAAAFFUZWVDaGFydCwgVmVyc2lvbj00LjEuMjAxMy41MjgxLCBDdWx0dXJlPW5ldXRyYWwsIFB1YmxpY0tleVRva2VuPTljODEyNjI3NmM3N2JkYjcMAwAAAFFTeXN0ZW0uRHJhd2luZywgVmVyc2lvbj00LjAuMC4wLCBDdWx0dXJlPW5ldXRyYWwsIFB1YmxpY0tleVRva2VuPWIwM2Y1ZjdmMTFkNTBhM2EFAQAAABVTdGVlbWEuVGVlQ2hhcnQuQ2hhcnQqAAAADy5ab29tLkRpcmVjdGlvbg4uUGFubmluZy5BbGxvdxAuQ3VzdG9tQ2hhcnRSZWN0Dy5MZWdlbmQuVmlzaWJsZRkuQXNwZWN0LkNvbG9yUGFsZXR0ZUluZGV4Di5Bc3BlY3QuVmlldzNECFNlcmllcy4wGi5TZXJpZXMuMC5EYXRlVmFsdWVzLlZhbHVlGi5TZXJpZXMuMC5EYXRlVmFsdWVzLkNvdW50HS5TZXJpZXMuMC5EYXRlVmFsdWVzLkRhdGVUaW1lGi5TZXJpZXMuMC5EYXRlVmFsdWVzLk9yZGVyGy5TZXJpZXMuMC5DbG9zZVZhbHVlcy5WYWx1ZRsuU2VyaWVzLjAuQ2xvc2VWYWx1ZXMuQ291bnQaLlNlcmllcy4wLk9wZW5WYWx1ZXMuVmFsdWUaLlNlcmllcy4wLk9wZW5WYWx1ZXMuQ291bnQaLlNlcmllcy4wLkhpZ2hWYWx1ZXMuVmFsdWUaLlNlcmllcy4wLkhpZ2hWYWx1ZXMuQ291bnQZLlNlcmllcy4wLkxvd1ZhbHVlcy5WYWx1ZRkuU2VyaWVzLjAuTG93VmFsdWVzLkNvdW50FS5TZXJpZXMuMC5CcnVzaC5Db2xvchguU2VyaWVzLjAuUG9pbnRlci5EcmF3M0QcLlNlcmllcy4wLlBvaW50ZXIuU2l6ZURvdWJsZRsuU2VyaWVzLjAuUG9pbnRlci5TaXplVW5pdHMXLlNlcmllcy4wLkxpbmVQZW4uQ29sb3IXLlNlcmllcy4wLlhWYWx1ZXMuVmFsdWUXLlNlcmllcy4wLlhWYWx1ZXMuQ291bnQaLlNlcmllcy4wLlhWYWx1ZXMuRGF0ZVRpbWUXLlNlcmllcy4wLlhWYWx1ZXMuT3JkZXIXLlNlcmllcy4wLllWYWx1ZXMuVmFsdWUXLlNlcmllcy4wLllWYWx1ZXMuQ291bnQTLlNlcmllcy4wLkNvbG9yRWFjaA8uU2VyaWVzLjAuQ29sb3IPLlNlcmllcy4wLlRpdGxlB1Rvb2xzLjASLlRvb2xzLjAuQWxpZ25BeGVzFi5Ub29scy4wLkRpdmlzaW9uUmF0aW8PLlRvb2xzLjAuU2VyaWVzFi5BeGVzLkJvdHRvbS5BdXRvbWF0aWMdLkF4ZXMuQm90dG9tLkF1dG9tYXRpY01heGltdW0dLkF4ZXMuQm90dG9tLkF1dG9tYXRpY01pbmltdW0ULkF4ZXMuQm90dG9tLk1heGltdW0ULkF4ZXMuQm90dG9tLk1pbmltdW0EBAAAAAABBwAABAcABwAHAAcABAAABAQHAAAEBwAABAEBAAABAAAAAAAeU3RlZW1hLlRlZUNoYXJ0Llpvb21EaXJlY3Rpb25zAgAAABtTdGVlbWEuVGVlQ2hhcnQuU2Nyb2xsTW9kZXMCAAAAAQEIAQYIASVTdGVlbWEuVGVlQ2hhcnQuU3R5bGVzLlZhbHVlTGlzdE9yZGVyAgAAAAYIBggGCAYIFFN5c3RlbS5EcmF3aW5nLkNvbG9yAwAAAAEGJ1N0ZWVtYS5UZWVDaGFydC5TdHlsZXMuUG9pbnRlclNpemVVbml0cwIAAAAUU3lzdGVtLkRyYXdpbmcuQ29sb3IDAAAABggBJVN0ZWVtYS5UZWVDaGFydC5TdHlsZXMuVmFsdWVMaXN0T3JkZXICAAAABggBFFN5c3RlbS5EcmF3aW5nLkNvbG9yAwAAAAEGAQEBBgYCAAAABfz///8eU3RlZW1hLlRlZUNoYXJ0Llpvb21EaXJlY3Rpb25zAQAAAAd2YWx1ZV9fAAgCAAAAAAAAAAX7////G1N0ZWVtYS5UZWVDaGFydC5TY3JvbGxNb2RlcwEAAAAHdmFsdWVfXwAIAgAAAAIAAAABAAAAAAAABgYAAAAdU3RlZW1hLlRlZUNoYXJ0LlN0eWxlcy5DYW5kbGUJBwAAAAAAAAABBfj///8lU3RlZW1hLlRlZUNoYXJ0LlN0eWxlcy5WYWx1ZUxpc3RPcmRlcgEAAAAHdmFsdWVfXwAIAgAAAAEAAAAJCQAAAAAAAAAJCgAAAAAAAAAJCwAAAAAAAAAJDAAAAAAAAAAF8////xRTeXN0ZW0uRHJhd2luZy5Db2xvcgQAAAAEbmFtZQV2YWx1ZQprbm93bkNvbG9yBXN0YXRlAQAAAAkHBwMAAAAKAAD//wAAAAAAAAIAAAAAAAAAAAAABfL///8nU3RlZW1hLlRlZUNoYXJ0LlN0eWxlcy5Qb2ludGVyU2l6ZVVuaXRzAQAAAAd2YWx1ZV9fAAgCAAAAAAAAAAHx////8////woAAJn/AAAAAAAAAgAJEAAAAAAAAAABAe/////4////AQAAAAkSAAAAAAAAAAAB7f////P///8KAAD//wAAAAAAAAIABhQAAAAHY2FuZGxlMQYVAAAAIVN0ZWVtYS5UZWVDaGFydC5Ub29scy5TY3JvbGxQYWdlcgEAAAAAAAAUQAYWAAAACFNlcmllcy4wAAAAAAAAAAAAAAAAAAAAAAAAAA8HAAAAAAAAAAYPCQAAAAAAAAAGDwoAAAAAAAAABg8LAAAAAAAAAAYPDAAAAAAAAAAGDxAAAAAAAAAABg8SAAAAAAAAAAYL"
				TempChart="Httphandler" AutoPostback="False" 
                GetChartFile="/TeeChartForNET/GetChart.aspx" PictureFormat="JScript" Width="560px" Height="370px"></tchart:WebChart>
			<asp:Label id="Label3" style="Z-INDEX: 108; LEFT: 28px; POSITION: absolute; TOP: 16px" runat="server"
				Width="584px" Height="36px">TeeChart HTML5 ScrollPager</asp:Label>
            <span id="data" style="Z-INDEX: 109; LEFT: 24px; WIDTH: 560px; POSITION: absolute; TOP: 450px; HEIGHT: 13px"></SPAN>
			<DIV style="Z-INDEX: 109; LEFT: 24px; WIDTH: 560px; POSITION: absolute; TOP: 508px; HEIGHT: 13px">
                TeeChart Javascript chart exported from TeeChart for .NET. The chart is live for 
                zoom and scroll and may be further customised using Javascript.</DIV>
		</form>
	</body>
</HTML>
