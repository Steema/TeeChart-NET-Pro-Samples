<%@ Register TagPrefix="tchart" Namespace="Steema.TeeChart.Web" Assembly="TeeChart" %>
<%@ Page language="c#" Inherits="WebDemo.Chart_Styles.Standard.VHAreaChart" CodeFile="VHAreaChart.aspx.cs" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>VHAreaChart</title>
		<LINK href="..\..\Styles\ContentStyles.css" type="text/css" rel="stylesheet">
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<asp:label id="Label1" style="Z-INDEX: 106; LEFT: 672px; POSITION: absolute; TOP: 68px" runat="server"
				Width="76px">Area Style :</asp:label>
			<asp:dropdownlist id="DropDownList1" style="Z-INDEX: 110; LEFT: 748px; POSITION: absolute; TOP: 64px"
				runat="server" Width="89px" AutoPostBack="True">
				<asp:ListItem Value="Vertical" Selected="True">Vertical</asp:ListItem>
				<asp:ListItem Value="Horizontal">Horizontal</asp:ListItem>
			</asp:dropdownlist>
			<tchart:WebChart id="WebChart1" 
                style="Z-INDEX: 107; LEFT: 24px; POSITION: absolute; TOP: 60px; width:640; height:400px" runat="server"
				Width="640px" height="400px" Config="AAEAAAD/////AQAAAAAAAAAMAgAAAFFUZWVDaGFydCwgVmVyc2lvbj00LjEuMjAxNy42MjkwLCBDdWx0dXJlPW5ldXRyYWwsIFB1YmxpY0tleVRva2VuPTljODEyNjI3NmM3N2JkYjcMAwAAAFFTeXN0ZW0uRHJhd2luZywgVmVyc2lvbj00LjAuMC4wLCBDdWx0dXJlPW5ldXRyYWwsIFB1YmxpY0tleVRva2VuPWIwM2Y1ZjdmMTFkNTBhM2EFAQAAABVTdGVlbWEuVGVlQ2hhcnQuQ2hhcnQnAAAADC5DYW5jZWxNb3VzZQ0uQ3VycmVudFRoZW1lEC5DdXN0b21DaGFydFJlY3QSLlBhbmVsLkJldmVsLk91dGVyHS5QYW5lbC5CcnVzaC5HcmFkaWVudC5WaXNpYmxlEi5QYW5lbC5CcnVzaC5Db2xvchEuTGVnZW5kLkZvbnQuU2l6ZRYuTGVnZW5kLkZvbnQuU2l6ZUZsb2F0GC5MZWdlbmQuRm9udC5CcnVzaC5Db2xvchYuTGVnZW5kLlNoYWRvdy5WaXNpYmxlDS5IZWFkZXIuTGluZXMRLkhlYWRlci5Gb250LlNpemUWLkhlYWRlci5Gb250LlNpemVGbG9hdBguSGVhZGVyLkZvbnQuQnJ1c2guQ29sb3IPLkhlYWRlci5WaXNpYmxlDi5Bc3BlY3QuVmlldzNEGS5XYWxscy5CYWNrLkJydXNoLlZpc2libGUTLldhbGxzLkJhY2suVmlzaWJsZRsuQXhlcy5MZWZ0LkxhYmVscy5Gb250LlNpemUgLkF4ZXMuTGVmdC5MYWJlbHMuRm9udC5TaXplRmxvYXQiLkF4ZXMuTGVmdC5MYWJlbHMuRm9udC5CcnVzaC5Db2xvchkuQXhlcy5MZWZ0LkdyaWQuRHJhd0V2ZXJ5Gi5BeGVzLkxlZnQuVGl0bGUuRm9udC5TaXplHy5BeGVzLkxlZnQuVGl0bGUuRm9udC5TaXplRmxvYXQhLkF4ZXMuTGVmdC5UaXRsZS5Gb250LkJydXNoLkNvbG9yGi5BeGVzLlRvcC5MYWJlbHMuRm9udC5TaXplHy5BeGVzLlRvcC5MYWJlbHMuRm9udC5TaXplRmxvYXQhLkF4ZXMuVG9wLkxhYmVscy5Gb250LkJydXNoLkNvbG9yHC5BeGVzLlJpZ2h0LkxhYmVscy5Gb250LlNpemUhLkF4ZXMuUmlnaHQuTGFiZWxzLkZvbnQuU2l6ZUZsb2F0Iy5BeGVzLlJpZ2h0LkxhYmVscy5Gb250LkJydXNoLkNvbG9yHS5BeGVzLkJvdHRvbS5MYWJlbHMuRm9udC5TaXplIi5BeGVzLkJvdHRvbS5MYWJlbHMuRm9udC5TaXplRmxvYXQkLkF4ZXMuQm90dG9tLkxhYmVscy5Gb250LkJydXNoLkNvbG9yGy5BeGVzLkJvdHRvbS5HcmlkLkRyYXdFdmVyeRwuQXhlcy5Cb3R0b20uVGl0bGUuRm9udC5TaXplIS5BeGVzLkJvdHRvbS5UaXRsZS5Gb250LlNpemVGbG9hdCMuQXhlcy5Cb3R0b20uVGl0bGUuRm9udC5CcnVzaC5Db2xvcg8uQXhlcy5BdXRvbWF0aWMABAAEAAQAAAQABgAABAAAAAAAAAQAAAAEAAAEAAAEAAAEAAAABAABGVN0ZWVtYS5UZWVDaGFydC5UaGVtZVR5cGUCAAAAASNTdGVlbWEuVGVlQ2hhcnQuRHJhd2luZy5CZXZlbFN0eWxlcwIAAAABFFN5c3RlbS5EcmF3aW5nLkNvbG9yAwAAAAgLFFN5c3RlbS5EcmF3aW5nLkNvbG9yAwAAAAEICxRTeXN0ZW0uRHJhd2luZy5Db2xvcgMAAAABAQEBCAsUU3lzdGVtLkRyYXdpbmcuQ29sb3IDAAAACAgLFFN5c3RlbS5EcmF3aW5nLkNvbG9yAwAAAAgLFFN5c3RlbS5EcmF3aW5nLkNvbG9yAwAAAAgLFFN5c3RlbS5EcmF3aW5nLkNvbG9yAwAAAAgLFFN5c3RlbS5EcmF3aW5nLkNvbG9yAwAAAAgICxRTeXN0ZW0uRHJhd2luZy5Db2xvcgMAAAABAgAAAAAF/P///xlTdGVlbWEuVGVlQ2hhcnQuVGhlbWVUeXBlAQAAAAd2YWx1ZV9fAAgCAAAAAAAAAAAF+////yNTdGVlbWEuVGVlQ2hhcnQuRHJhd2luZy5CZXZlbFN0eWxlcwEAAAAHdmFsdWVfXwAIAgAAAAAAAAAABfr///8UU3lzdGVtLkRyYXdpbmcuQ29sb3IEAAAABG5hbWUFdmFsdWUKa25vd25Db2xvcgVzdGF0ZQEAAAAJBwcDAAAACv////8AAAAAAAACAAkAAAAAABBBAfn////6////CkBAQP8AAAAAAAACAAAJCAAAAAwAAAAAAEBBAff////6////CgAAAAAAAAAATgABAAAAAAAJAAAAAAAQQQH2////+v///woAAAAAAAAAAE4AAQACAAAACwAAAAAAMEEB9f////r///8KQEBA/wAAAAAAAAIACQAAAAAAEEEB9P////r///8KQEBA/wAAAAAAAAIACQAAAAAAEEEB8/////r///8KQEBA/wAAAAAAAAIACQAAAAAAEEEB8v////r///8KgICA/wAAAAAAAAIAAgAAAAsAAAAAADBBAfH////6////CkBAQP8AAAAAAAACAAERCAAAAAEAAAAGEAAAABlBcmVhICYgSG9yaXouIEFyZWEgU2VyaWVzCw=="
				TempChart="Httphandler" AutoPostback="False" 
                GetChartFile="/TeeChartForNET/GetChart.aspx" LastFileName=""></tchart:WebChart>
			<asp:Label id="Label3" style="Z-INDEX: 108; LEFT: 28px; POSITION: absolute; TOP: 16px" runat="server"
				Width="584px" Height="36px">Vertical and Horizontal Area Chart Style.</asp:Label>
		</form>
	</body>
</HTML>
