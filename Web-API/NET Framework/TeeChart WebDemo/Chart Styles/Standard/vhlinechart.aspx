<%@ Page language="c#" Inherits="WebDemo.VHLineChart1" CodeFile="VHLineChart.aspx.cs" %>
<%@ Register TagPrefix="tchart" Namespace="Steema.TeeChart.Web" Assembly="TeeChart" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>VHLineChart</title>
		<LINK href="..\..\Styles\ContentStyles.css" type="text/css" rel="stylesheet">
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<asp:label id="Label1" style="Z-INDEX: 101; LEFT: 645px; POSITION: absolute; TOP: 68px; right: 753px; height: 21px;" runat="server">Line Style :</asp:label>
                
            <asp:dropdownlist id="DropDownList1" style="Z-INDEX: 106; LEFT: 734px; POSITION: absolute; TOP: 67px;"
				runat="server" width="93px" AutoPostBack="True" onselectedindexchanged="DropDownList1_SelectedIndexChanged">
				<asp:ListItem Value="Vertical" Selected="True">Vertical</asp:ListItem>
				<asp:ListItem Value="Horizontal">Horizontal</asp:ListItem>
			</asp:dropdownlist>

			<tchart:WebChart id="WebChart1" 
                style="Z-INDEX: 107; LEFT: 24px; width:600px; height:400px; POSITION: absolute; TOP: 60px" runat="server" Width="600px" Height="400px" Config="AAEAAAD/////AQAAAAAAAAAMAgAAAFFUZWVDaGFydCwgVmVyc2lvbj00LjEuMjAxNy42MjkwLCBDdWx0dXJlPW5ldXRyYWwsIFB1YmxpY0tleVRva2VuPTljODEyNjI3NmM3N2JkYjcMAwAAAFFTeXN0ZW0uRHJhd2luZywgVmVyc2lvbj00LjAuMC4wLCBDdWx0dXJlPW5ldXRyYWwsIFB1YmxpY0tleVRva2VuPWIwM2Y1ZjdmMTFkNTBhM2EFAQAAABVTdGVlbWEuVGVlQ2hhcnQuQ2hhcnQpAAAADC5DYW5jZWxNb3VzZQ0uQ3VycmVudFRoZW1lEC5DdXN0b21DaGFydFJlY3QSLlBhbmVsLkJldmVsLk91dGVyHS5QYW5lbC5CcnVzaC5HcmFkaWVudC5WaXNpYmxlEi5QYW5lbC5CcnVzaC5Db2xvchEuTGVnZW5kLkZvbnQuU2l6ZRYuTGVnZW5kLkZvbnQuU2l6ZUZsb2F0GC5MZWdlbmQuRm9udC5CcnVzaC5Db2xvchYuTGVnZW5kLlNoYWRvdy5WaXNpYmxlES5IZWFkZXIuRm9udC5TaXplFi5IZWFkZXIuRm9udC5TaXplRmxvYXQYLkhlYWRlci5Gb250LkJydXNoLkNvbG9yB1Rvb2xzLjAULlRvb2xzLjAuTWFwRWxlbWVudHMSLlRvb2xzLjAuTWFwQWN0aW9uGy5Ub29scy4wLkhvdHNwb3RDYW52YXNJbmRleBUuVG9vbHMuMC5IZWxwZXJTY3JpcHQZLldhbGxzLkJhY2suQnJ1c2guVmlzaWJsZRMuV2FsbHMuQmFjay5WaXNpYmxlGy5BeGVzLkxlZnQuTGFiZWxzLkZvbnQuU2l6ZSAuQXhlcy5MZWZ0LkxhYmVscy5Gb250LlNpemVGbG9hdCIuQXhlcy5MZWZ0LkxhYmVscy5Gb250LkJydXNoLkNvbG9yGS5BeGVzLkxlZnQuR3JpZC5EcmF3RXZlcnkaLkF4ZXMuTGVmdC5UaXRsZS5Gb250LlNpemUfLkF4ZXMuTGVmdC5UaXRsZS5Gb250LlNpemVGbG9hdCEuQXhlcy5MZWZ0LlRpdGxlLkZvbnQuQnJ1c2guQ29sb3IaLkF4ZXMuVG9wLkxhYmVscy5Gb250LlNpemUfLkF4ZXMuVG9wLkxhYmVscy5Gb250LlNpemVGbG9hdCEuQXhlcy5Ub3AuTGFiZWxzLkZvbnQuQnJ1c2guQ29sb3IcLkF4ZXMuUmlnaHQuTGFiZWxzLkZvbnQuU2l6ZSEuQXhlcy5SaWdodC5MYWJlbHMuRm9udC5TaXplRmxvYXQjLkF4ZXMuUmlnaHQuTGFiZWxzLkZvbnQuQnJ1c2guQ29sb3IdLkF4ZXMuQm90dG9tLkxhYmVscy5Gb250LlNpemUiLkF4ZXMuQm90dG9tLkxhYmVscy5Gb250LlNpemVGbG9hdCQuQXhlcy5Cb3R0b20uTGFiZWxzLkZvbnQuQnJ1c2guQ29sb3IbLkF4ZXMuQm90dG9tLkdyaWQuRHJhd0V2ZXJ5HC5BeGVzLkJvdHRvbS5UaXRsZS5Gb250LlNpemUhLkF4ZXMuQm90dG9tLlRpdGxlLkZvbnQuU2l6ZUZsb2F0Iy5BeGVzLkJvdHRvbS5UaXRsZS5Gb250LkJydXNoLkNvbG9yDy5BeGVzLkF1dG9tYXRpYwAEAAQABAAABAAAAAQBAQQABAAAAAAEAAAABAAABAAABAAABAAAAAQAARlTdGVlbWEuVGVlQ2hhcnQuVGhlbWVUeXBlAgAAAAEjU3RlZW1hLlRlZUNoYXJ0LkRyYXdpbmcuQmV2ZWxTdHlsZXMCAAAAARRTeXN0ZW0uRHJhd2luZy5Db2xvcgMAAAAICxRTeXN0ZW0uRHJhd2luZy5Db2xvcgMAAAABCAsUU3lzdGVtLkRyYXdpbmcuQ29sb3IDAAAAIFN0ZWVtYS5UZWVDaGFydC5TdHlsZXMuTWFwQWN0aW9uAgAAAAgqU3RlZW1hLlRlZUNoYXJ0LlRvb2xzLkhvdHNwb3RIZWxwZXJTY3JpcHRzAgAAAAEBCAsUU3lzdGVtLkRyYXdpbmcuQ29sb3IDAAAACAgLFFN5c3RlbS5EcmF3aW5nLkNvbG9yAwAAAAgLFFN5c3RlbS5EcmF3aW5nLkNvbG9yAwAAAAgLFFN5c3RlbS5EcmF3aW5nLkNvbG9yAwAAAAgLFFN5c3RlbS5EcmF3aW5nLkNvbG9yAwAAAAgICxRTeXN0ZW0uRHJhd2luZy5Db2xvcgMAAAABAgAAAAAF/P///xlTdGVlbWEuVGVlQ2hhcnQuVGhlbWVUeXBlAQAAAAd2YWx1ZV9fAAgCAAAAAAAAAAAF+////yNTdGVlbWEuVGVlQ2hhcnQuRHJhd2luZy5CZXZlbFN0eWxlcwEAAAAHdmFsdWVfXwAIAgAAAAAAAAAABfr///8UU3lzdGVtLkRyYXdpbmcuQ29sb3IEAAAABG5hbWUFdmFsdWUKa25vd25Db2xvcgVzdGF0ZQEAAAAJBwcDAAAACv////8AAAAAAAACAAkAAAAAABBBAfn////6////CkBAQP8AAAAAAAACAAAMAAAAAABAQQH4////+v///woAAAAAAAAAAE4AAQAGCQAAACNTdGVlbWEuVGVlQ2hhcnQuVG9vbHMuU2VyaWVzSG90c3BvdAYKAAAAAAX1////IFN0ZWVtYS5UZWVDaGFydC5TdHlsZXMuTWFwQWN0aW9uAQAAAAd2YWx1ZV9fAAgCAAAAAAAAAPMBAAAF9P///ypTdGVlbWEuVGVlQ2hhcnQuVG9vbHMuSG90c3BvdEhlbHBlclNjcmlwdHMBAAAAB3ZhbHVlX18ACAIAAAABAAAAAAAJAAAAAAAQQQHz////+v///woAAAAAAAAAAE4AAQACAAAACwAAAAAAMEEB8v////r///8KQEBA/wAAAAAAAAIACQAAAAAAEEEB8f////r///8KQEBA/wAAAAAAAAIACQAAAAAAEEEB8P////r///8KQEBA/wAAAAAAAAIACQAAAAAAEEEB7/////r///8KgICA/wAAAAAAAAIAAgAAAAsAAAAAADBBAe7////6////CkBAQP8AAAAAAAACAAEL"
				TempChart="Httphandler" AutoPostback="False"
                GetChartFile="/TeeChartForNET/GetChart.aspx" LastFileName="" BorderStyle="None"></tchart:WebChart>
			<asp:Label id="Label3" style="Z-INDEX: 108; LEFT: 28px; POSITION: absolute; TOP: 16px" runat="server"
				Width="584px" Height="36px">Line and Horizontal Line Styles</asp:Label>
		</form>
	</body>
</HTML>
