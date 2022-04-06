﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="runtimedataset.aspx.cs" Inherits="Datasets_runtimedata" %>

<%@ Register assembly="TeeChart" namespace="Steema.TeeChart.Web" tagprefix="tchart" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Runtime Assigned Datasets</title>
   	<LINK href="..\Styles\ContentStyles.css" type="text/css" rel="stylesheet">
	<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
	<meta content="C#" name="CODE_LANGUAGE">
	<meta content="JavaScript" name="vs_defaultClientScript">
	<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" 
        
            Text="TeeChart's WebChart can connect to datasources defined at runtime.&lt;br&gt;Use The Series CheckDatasource method to refresh live data when required."></asp:Label>
    </div>
    <tchart:WebChart ID="WebChart1" runat="server" Height="300px" Width="540px" style="position: absolute; top: 70px; left: 10px; width: 537px;"
        AutoPostback="False" TempChart="Httphandler" 
        Config="AAEAAAD/////AQAAAAAAAAAMAgAAAE9UZWVDaGFydCwgVmVyc2lvbj00LjAuMC4zMDcxNCwgQ3VsdHVyZT1uZXV0cmFsLCBQdWJsaWNLZXlUb2tlbj05YzgxMjYyNzZjNzdiZGI3DAMAAABRU3lzdGVtLkRyYXdpbmcsIFZlcnNpb249Mi4wLjAuMCwgQ3VsdHVyZT1uZXV0cmFsLCBQdWJsaWNLZXlUb2tlbj1iMDNmNWY3ZjExZDUwYTNhBQEAAAAVU3RlZW1hLlRlZUNoYXJ0LkNoYXJ0lQAAABAuQ3VzdG9tQ2hhcnRSZWN0IC5QYW5lbC5CcnVzaC5HcmFkaWVudC5TaWdtYUZvY3VzIC5QYW5lbC5CcnVzaC5HcmFkaWVudC5TaWdtYVNjYWxlIC5QYW5lbC5CcnVzaC5HcmFkaWVudC5TdGFydENvbG9yHy5QYW5lbC5CcnVzaC5HcmFkaWVudC5Vc2VNaWRkbGUhLlBhbmVsLkJydXNoLkdyYWRpZW50Lk1pZGRsZUNvbG9yHi5QYW5lbC5CcnVzaC5HcmFkaWVudC5FbmRDb2xvchIuUGFuZWwuQnJ1c2guQ29sb3IYLkxlZ2VuZC5Gb250LkJydXNoLkNvbG9yIS5MZWdlbmQuQnJ1c2guR3JhZGllbnQuU2lnbWFGb2N1cyEuTGVnZW5kLkJydXNoLkdyYWRpZW50LlNpZ21hU2NhbGUhLkxlZ2VuZC5CcnVzaC5HcmFkaWVudC5TdGFydENvbG9yIi5MZWdlbmQuQnJ1c2guR3JhZGllbnQuTWlkZGxlQ29sb3IfLkxlZ2VuZC5CcnVzaC5HcmFkaWVudC5FbmRDb2xvch4uTGVnZW5kLkJydXNoLkdyYWRpZW50LlZpc2libGUPLkxlZ2VuZC5WaXNpYmxlEy5MZWdlbmQuUGVuLlZpc2libGUNLkhlYWRlci5MaW5lcxEuSGVhZGVyLkZvbnQuU2l6ZRYuSGVhZGVyLkZvbnQuU2l6ZUZsb2F0GC5IZWFkZXIuRm9udC5CcnVzaC5Db2xvciEuSGVhZGVyLkJydXNoLkdyYWRpZW50LlNpZ21hRm9jdXMhLkhlYWRlci5CcnVzaC5HcmFkaWVudC5TaWdtYVNjYWxlIS5IZWFkZXIuQnJ1c2guR3JhZGllbnQuU3RhcnRDb2xvciIuSGVhZGVyLkJydXNoLkdyYWRpZW50Lk1pZGRsZUNvbG9yHy5IZWFkZXIuQnJ1c2guR3JhZGllbnQuRW5kQ29sb3IZLkFzcGVjdC5Db2xvclBhbGV0dGVJbmRleA8uQXNwZWN0LlpPZmZzZXQOLkFzcGVjdC5WaWV3M0QIU2VyaWVzLjAVLlNlcmllcy4wLkJydXNoLkNvbG9yEy5TZXJpZXMuMC5QZW4uQ29sb3ITLlNlcmllcy4wLlBlbi5XaWR0aBAuU2VyaWVzLjAuQ29sb3JzFy5TZXJpZXMuMC5YVmFsdWVzLlZhbHVlFy5TZXJpZXMuMC5YVmFsdWVzLkNvdW50HC5TZXJpZXMuMC5YVmFsdWVzLkRhdGFNZW1iZXIXLlNlcmllcy4wLlhWYWx1ZXMuT3JkZXIXLlNlcmllcy4wLllWYWx1ZXMuVmFsdWUXLlNlcmllcy4wLllWYWx1ZXMuQ291bnQcLlNlcmllcy4wLllWYWx1ZXMuRGF0YU1lbWJlchUuU2VyaWVzLjAuQ29sb3JNZW1iZXITLlNlcmllcy4wLkNvbG9yRWFjaA8uU2VyaWVzLjAuQ29sb3IPLlNlcmllcy4wLlRpdGxlHi5TZXJpZXMuMC5NYXJrcy5DYWxsb3V0Lkxlbmd0aCUuU2VyaWVzLjAuTWFya3MuQ2FsbG91dC5BcnJvdy5WaXNpYmxlIS5TZXJpZXMuMC5NYXJrcy5DYWxsb3V0LkFycm93SGVhZCUuU2VyaWVzLjAuTWFya3MuQ2FsbG91dC5BcnJvd0hlYWRTaXplIC5TZXJpZXMuMC5NYXJrcy5DYWxsb3V0LkRpc3RhbmNlHi5TZXJpZXMuMC5NYXJrcy5DYWxsb3V0LkRyYXczRB8uU2VyaWVzLjAuTWFya3MuQ2FsbG91dC5WaXNpYmxlHS5TZXJpZXMuMC5NYXJrcy5DYWxsb3V0LlN0eWxlIy5TZXJpZXMuMC5NYXJrcy5DYWxsb3V0LkJydXNoLkNvbG9yHi5TZXJpZXMuMC5NYXJrcy5JdGVtcy5DYXBhY2l0eR0uU2VyaWVzLjAuTWFya3MuQXJyb3cuVmlzaWJsZRsuU2VyaWVzLjAuTWFya3MuQXJyb3dMZW5ndGgZLlNlcmllcy4wLk1hcmtzLkZvbnQuU2l6ZR4uU2VyaWVzLjAuTWFya3MuRm9udC5TaXplRmxvYXQZLlNlcmllcy4wLk1hcmtzLkZvbnQuQm9sZCcuU2VyaWVzLjAuTWFya3MuRm9udC5TaGFkb3cuQnJ1c2guQ29sb3IjLlNlcmllcy4wLk1hcmtzLkZvbnQuU2hhZG93LlZpc2libGUpLlNlcmllcy4wLk1hcmtzLkJydXNoLkdyYWRpZW50LlNpZ21hRm9jdXMpLlNlcmllcy4wLk1hcmtzLkJydXNoLkdyYWRpZW50LlNpZ21hU2NhbGUpLlNlcmllcy4wLk1hcmtzLkJydXNoLkdyYWRpZW50LlN0YXJ0Q29sb3IqLlNlcmllcy4wLk1hcmtzLkJydXNoLkdyYWRpZW50Lk1pZGRsZUNvbG9yJy5TZXJpZXMuMC5NYXJrcy5CcnVzaC5HcmFkaWVudC5FbmRDb2xvch0uU2VyaWVzLjAuTWFya3MuQnJ1c2guVmlzaWJsZRsuU2VyaWVzLjAuTWFya3MuVHJhbnNwYXJlbnQbLlNlcmllcy4wLk1hcmtzLlBlbi5WaXNpYmxlJS5XYWxscy5MZWZ0LkJydXNoLkdyYWRpZW50LlNpZ21hRm9jdXMlLldhbGxzLkxlZnQuQnJ1c2guR3JhZGllbnQuU2lnbWFTY2FsZSUuV2FsbHMuTGVmdC5CcnVzaC5HcmFkaWVudC5TdGFydENvbG9yJi5XYWxscy5MZWZ0LkJydXNoLkdyYWRpZW50Lk1pZGRsZUNvbG9yIy5XYWxscy5MZWZ0LkJydXNoLkdyYWRpZW50LkVuZENvbG9yFy5XYWxscy5MZWZ0LlBlbi5WaXNpYmxlJi5XYWxscy5SaWdodC5CcnVzaC5HcmFkaWVudC5TaWdtYUZvY3VzJi5XYWxscy5SaWdodC5CcnVzaC5HcmFkaWVudC5TaWdtYVNjYWxlJi5XYWxscy5SaWdodC5CcnVzaC5HcmFkaWVudC5TdGFydENvbG9yJy5XYWxscy5SaWdodC5CcnVzaC5HcmFkaWVudC5NaWRkbGVDb2xvciQuV2FsbHMuUmlnaHQuQnJ1c2guR3JhZGllbnQuRW5kQ29sb3IYLldhbGxzLlJpZ2h0LkJydXNoLkNvbG9yGC5XYWxscy5SaWdodC5QZW4uVmlzaWJsZSUuV2FsbHMuQmFjay5CcnVzaC5HcmFkaWVudC5TdGFydENvbG9yJi5XYWxscy5CYWNrLkJydXNoLkdyYWRpZW50Lk1pZGRsZUNvbG9yIy5XYWxscy5CYWNrLkJydXNoLkdyYWRpZW50LkVuZENvbG9yFy5XYWxscy5CYWNrLlBlbi5WaXNpYmxlJy5XYWxscy5Cb3R0b20uQnJ1c2guR3JhZGllbnQuU2lnbWFGb2N1cycuV2FsbHMuQm90dG9tLkJydXNoLkdyYWRpZW50LlNpZ21hU2NhbGUnLldhbGxzLkJvdHRvbS5CcnVzaC5HcmFkaWVudC5TdGFydENvbG9yKC5XYWxscy5Cb3R0b20uQnJ1c2guR3JhZGllbnQuTWlkZGxlQ29sb3IlLldhbGxzLkJvdHRvbS5CcnVzaC5HcmFkaWVudC5FbmRDb2xvchkuV2FsbHMuQm90dG9tLlBlbi5WaXNpYmxlIi5BeGVzLkxlZnQuTGFiZWxzLkZvbnQuQnJ1c2guQ29sb3IYLkF4ZXMuTGVmdC5BeGlzUGVuLkNvbG9yFS5BeGVzLkxlZnQuR3JpZC5TdHlsZRUuQXhlcy5MZWZ0LkdyaWQuQ29sb3IYLkF4ZXMuTGVmdC5NYXhpbXVtT2Zmc2V0HS5BeGVzLkxlZnQuTWlub3JUaWNrcy5WaXNpYmxlFi5BeGVzLkxlZnQuVGlja3MuQ29sb3IdLkF4ZXMuTGVmdC5UaWNrc0lubmVyLlZpc2libGUYLkF4ZXMuTGVmdC5UaXRsZS5DYXB0aW9uFi5BeGVzLkxlZnQuVGl0bGUuTGluZXMaLkF4ZXMuTGVmdC5UaXRsZS5Gb250LlNpemUfLkF4ZXMuTGVmdC5UaXRsZS5Gb250LlNpemVGbG9hdCEuQXhlcy5MZWZ0LlRpdGxlLkZvbnQuQnJ1c2guQ29sb3IhLkF4ZXMuVG9wLkxhYmVscy5Gb250LkJydXNoLkNvbG9yFy5BeGVzLlRvcC5BeGlzUGVuLkNvbG9yFC5BeGVzLlRvcC5HcmlkLlN0eWxlFC5BeGVzLlRvcC5HcmlkLkNvbG9yHC5BeGVzLlRvcC5NaW5vclRpY2tzLlZpc2libGUVLkF4ZXMuVG9wLlRpY2tzLkNvbG9yHC5BeGVzLlRvcC5UaWNrc0lubmVyLlZpc2libGUjLkF4ZXMuUmlnaHQuTGFiZWxzLkZvbnQuQnJ1c2guQ29sb3IZLkF4ZXMuUmlnaHQuQXhpc1Blbi5Db2xvchYuQXhlcy5SaWdodC5HcmlkLlN0eWxlFi5BeGVzLlJpZ2h0LkdyaWQuQ29sb3IeLkF4ZXMuUmlnaHQuTWlub3JUaWNrcy5WaXNpYmxlFy5BeGVzLlJpZ2h0LlRpY2tzLkNvbG9yHi5BeGVzLlJpZ2h0LlRpY2tzSW5uZXIuVmlzaWJsZSQuQXhlcy5Cb3R0b20uTGFiZWxzLkZvbnQuQnJ1c2guQ29sb3IbLkF4ZXMuQm90dG9tLkxhYmVscy5WaXNpYmxlGi5BeGVzLkJvdHRvbS5BeGlzUGVuLkNvbG9yFy5BeGVzLkJvdHRvbS5HcmlkLlN0eWxlFy5BeGVzLkJvdHRvbS5HcmlkLkNvbG9yGi5BeGVzLkJvdHRvbS5NYXhpbXVtT2Zmc2V0Gi5BeGVzLkJvdHRvbS5NaW5pbXVtT2Zmc2V0Hy5BeGVzLkJvdHRvbS5NaW5vclRpY2tzLlZpc2libGUYLkF4ZXMuQm90dG9tLlRpY2tzLkNvbG9yHy5BeGVzLkJvdHRvbS5UaWNrc0lubmVyLlZpc2libGUaLkF4ZXMuQm90dG9tLlRpdGxlLkNhcHRpb24YLkF4ZXMuQm90dG9tLlRpdGxlLkxpbmVzHC5BeGVzLkJvdHRvbS5UaXRsZS5Gb250LlNpemUhLkF4ZXMuQm90dG9tLlRpdGxlLkZvbnQuU2l6ZUZsb2F0Iy5BeGVzLkJvdHRvbS5UaXRsZS5Gb250LkJydXNoLkNvbG9yJi5BeGVzLkRlcHRoVG9wLkxhYmVscy5Gb250LkJydXNoLkNvbG9yHC5BeGVzLkRlcHRoVG9wLkF4aXNQZW4uQ29sb3IZLkF4ZXMuRGVwdGhUb3AuR3JpZC5TdHlsZRkuQXhlcy5EZXB0aFRvcC5HcmlkLkNvbG9yIS5BeGVzLkRlcHRoVG9wLk1pbm9yVGlja3MuVmlzaWJsZRouQXhlcy5EZXB0aFRvcC5UaWNrcy5Db2xvciEuQXhlcy5EZXB0aFRvcC5UaWNrc0lubmVyLlZpc2libGUjLkF4ZXMuRGVwdGguTGFiZWxzLkZvbnQuQnJ1c2guQ29sb3IZLkF4ZXMuRGVwdGguQXhpc1Blbi5Db2xvchYuQXhlcy5EZXB0aC5HcmlkLlN0eWxlFi5BeGVzLkRlcHRoLkdyaWQuQ29sb3IeLkF4ZXMuRGVwdGguTWlub3JUaWNrcy5WaXNpYmxlFy5BeGVzLkRlcHRoLlRpY2tzLkNvbG9yHi5BeGVzLkRlcHRoLlRpY2tzSW5uZXIuVmlzaWJsZQAAAAQABAQEBAAABAQEAAAABgAABAAABAQEAAAAAQQEAAQHAAEEBwABAQAEAQAABAAAAAAEBAAAAAAAAAQAAAAEBAQAAAAAAAQEBAAAAAQEBAQABAQEAAAABAQEAAQEBAQAAAQAAQYAAAQEBAQEAAQABAQEBAAEAAQABAQEAAAABAABBgAABAQEBAQABAAEBAQEAAQAAQsLFFN5c3RlbS5EcmF3aW5nLkNvbG9yAwAAAAEUU3lzdGVtLkRyYXdpbmcuQ29sb3IDAAAAFFN5c3RlbS5EcmF3aW5nLkNvbG9yAwAAABRTeXN0ZW0uRHJhd2luZy5Db2xvcgMAAAAUU3lzdGVtLkRyYXdpbmcuQ29sb3IDAAAACwsUU3lzdGVtLkRyYXdpbmcuQ29sb3IDAAAAFFN5c3RlbS5EcmF3aW5nLkNvbG9yAwAAABRTeXN0ZW0uRHJhd2luZy5Db2xvcgMAAAABAQEICxRTeXN0ZW0uRHJhd2luZy5Db2xvcgMAAAALCxRTeXN0ZW0uRHJhd2luZy5Db2xvcgMAAAAUU3lzdGVtLkRyYXdpbmcuQ29sb3IDAAAAFFN5c3RlbS5EcmF3aW5nLkNvbG9yAwAAAAgGARRTeXN0ZW0uRHJhd2luZy5Db2xvcgMAAAAUU3lzdGVtLkRyYXdpbmcuQ29sb3IDAAAACCBTdGVlbWEuVGVlQ2hhcnQuU3R5bGVzLkNvbG9yTGlzdAIAAAAGCCVTdGVlbWEuVGVlQ2hhcnQuU3R5bGVzLlZhbHVlTGlzdE9yZGVyAgAAAAYIARRTeXN0ZW0uRHJhd2luZy5Db2xvcgMAAAAIASZTdGVlbWEuVGVlQ2hhcnQuU3R5bGVzLkFycm93SGVhZFN0eWxlcwIAAAAICAEBJFN0ZWVtYS5UZWVDaGFydC5TdHlsZXMuUG9pbnRlclN0eWxlcwIAAAAUU3lzdGVtLkRyYXdpbmcuQ29sb3IDAAAACAEICAsBFFN5c3RlbS5EcmF3aW5nLkNvbG9yAwAAAAELCxRTeXN0ZW0uRHJhd2luZy5Db2xvcgMAAAAUU3lzdGVtLkRyYXdpbmcuQ29sb3IDAAAAFFN5c3RlbS5EcmF3aW5nLkNvbG9yAwAAAAEBAQsLFFN5c3RlbS5EcmF3aW5nLkNvbG9yAwAAABRTeXN0ZW0uRHJhd2luZy5Db2xvcgMAAAAUU3lzdGVtLkRyYXdpbmcuQ29sb3IDAAAAAQsLFFN5c3RlbS5EcmF3aW5nLkNvbG9yAwAAABRTeXN0ZW0uRHJhd2luZy5Db2xvcgMAAAAUU3lzdGVtLkRyYXdpbmcuQ29sb3IDAAAAFFN5c3RlbS5EcmF3aW5nLkNvbG9yAwAAAAEUU3lzdGVtLkRyYXdpbmcuQ29sb3IDAAAAFFN5c3RlbS5EcmF3aW5nLkNvbG9yAwAAABRTeXN0ZW0uRHJhd2luZy5Db2xvcgMAAAABCwsUU3lzdGVtLkRyYXdpbmcuQ29sb3IDAAAAFFN5c3RlbS5EcmF3aW5nLkNvbG9yAwAAABRTeXN0ZW0uRHJhd2luZy5Db2xvcgMAAAABFFN5c3RlbS5EcmF3aW5nLkNvbG9yAwAAABRTeXN0ZW0uRHJhd2luZy5Db2xvcgMAAAAiU3lzdGVtLkRyYXdpbmcuRHJhd2luZzJELkRhc2hTdHlsZQMAAAAUU3lzdGVtLkRyYXdpbmcuQ29sb3IDAAAACAEUU3lzdGVtLkRyYXdpbmcuQ29sb3IDAAAAAQgLFFN5c3RlbS5EcmF3aW5nLkNvbG9yAwAAABRTeXN0ZW0uRHJhd2luZy5Db2xvcgMAAAAUU3lzdGVtLkRyYXdpbmcuQ29sb3IDAAAAIlN5c3RlbS5EcmF3aW5nLkRyYXdpbmcyRC5EYXNoU3R5bGUDAAAAFFN5c3RlbS5EcmF3aW5nLkNvbG9yAwAAAAEUU3lzdGVtLkRyYXdpbmcuQ29sb3IDAAAAARRTeXN0ZW0uRHJhd2luZy5Db2xvcgMAAAAUU3lzdGVtLkRyYXdpbmcuQ29sb3IDAAAAIlN5c3RlbS5EcmF3aW5nLkRyYXdpbmcyRC5EYXNoU3R5bGUDAAAAFFN5c3RlbS5EcmF3aW5nLkNvbG9yAwAAAAEUU3lzdGVtLkRyYXdpbmcuQ29sb3IDAAAAARRTeXN0ZW0uRHJhd2luZy5Db2xvcgMAAAABFFN5c3RlbS5EcmF3aW5nLkNvbG9yAwAAACJTeXN0ZW0uRHJhd2luZy5EcmF3aW5nMkQuRGFzaFN0eWxlAwAAABRTeXN0ZW0uRHJhd2luZy5Db2xvcgMAAAAICAEUU3lzdGVtLkRyYXdpbmcuQ29sb3IDAAAAAQgLFFN5c3RlbS5EcmF3aW5nLkNvbG9yAwAAABRTeXN0ZW0uRHJhd2luZy5Db2xvcgMAAAAUU3lzdGVtLkRyYXdpbmcuQ29sb3IDAAAAIlN5c3RlbS5EcmF3aW5nLkRyYXdpbmcyRC5EYXNoU3R5bGUDAAAAFFN5c3RlbS5EcmF3aW5nLkNvbG9yAwAAAAEUU3lzdGVtLkRyYXdpbmcuQ29sb3IDAAAAARRTeXN0ZW0uRHJhd2luZy5Db2xvcgMAAAAUU3lzdGVtLkRyYXdpbmcuQ29sb3IDAAAAIlN5c3RlbS5EcmF3aW5nLkRyYXdpbmcyRC5EYXNoU3R5bGUDAAAAFFN5c3RlbS5EcmF3aW5nLkNvbG9yAwAAAAEUU3lzdGVtLkRyYXdpbmcuQ29sb3IDAAAAAQIAAAAAAAAAAAAAAAAF/P///xRTeXN0ZW0uRHJhd2luZy5Db2xvcgQAAAAEbmFtZQV2YWx1ZQprbm93bkNvbG9yBXN0YXRlAQAAAAkHBwMAAAAKRkZG/wAAAAAAAAIAAAH7/////P///woAAAAAAAAAAAAAAgAB+v////z///8KRkZG/wAAAAAAAAIAAfn////8////CvDw8P8AAAAAAAACAAH4/////P///wr/////AAAAAAAAAgAAAAAAAAAAAAH3/////P///wpGRkb/AAAAAAAAAgAB9v////z///8KAAAAAAAAAAAAAAIAAfX////8////Cnh4eP8AAAAAAAACAAEAAAkMAAAACQAAAAAAEEEB8/////z///8K/////wAAAAAAAAIAAAAAAAAAAAAB8v////z///8K/////wAAAAAAAAIAAfH////8////CgAAAAAAAAAAAAACAAHw/////P///woA////AAAAAAAAAgAOAAAAAAAAAAAAAAAABhEAAAAaU3RlZW1hLlRlZUNoYXJ0LlN0eWxlcy5CYXIB7v////z///8Kjerz/wAAAAAAAAIAAe3////8////CsD///8AAAAAAAACAAIAAAAJFAAAAAkVAAAABgAAAAYWAAAAAVgF6f///yVTdGVlbWEuVGVlQ2hhcnQuU3R5bGVzLlZhbHVlTGlzdE9yZGVyAQAAAAd2YWx1ZV9fAAgCAAAAAQAAAAkYAAAABgAAAAYZAAAAA0JhcgYaAAAABkNvbG9ycwAB5f////z///8Kjerz/wAAAAAAAAIABhwAAAAEYmFyMez///8ABeP///8mU3RlZW1hLlRlZUNoYXJ0LlN0eWxlcy5BcnJvd0hlYWRTdHlsZXMBAAAAB3ZhbHVlX18ACAIAAAAAAAAACAAAAAAAAAAAAAXi////JFN0ZWVtYS5UZWVDaGFydC5TdHlsZXMuUG9pbnRlclN0eWxlcwEAAAAHdmFsdWVfXwAIAgAAAAAAAAAB4f////z///8KAAAAAAAAAAAjAAEAAAAAAADs////CQAAAAAAEEEBAeD////8////Cv////8AAAAAAAACAAEAAAAAAAAAAAHf/////P///wr/////AAAAAAAAAgAB3v////z///8KAAAAAAAAAAAAAAIAAd3////8////CgD///8AAAAAAAACAAABAAAAAAAAAAAAAdz////8////Cv////8AAAAAAAACAAHb/////P///woAAAAAAAAAAAAAAgAB2v////z///8KAP///wAAAAAAAAIAAAAAAAAAAAAAAdn////8////Cv////8AAAAAAAACAAHY/////P///woAAAAAAAAAAAAAAgAB1/////z///8KAP///wAAAAAAAAIAAdb////8////CsDAwP8AAAAAAAACAAAB1f////z///8KRkZG/wAAAAAAAAIAAdT////8////CgAAAAAAAAAAAAACAAHT/////P///wp4eHj/AAAAAAAAAgAAAAAAAAAAAAAB0v////z///8K/////wAAAAAAAAIAAdH////8////CgAAAAAAAAAAAAACAAHQ/////P///woA////AAAAAAAAAgAAAc/////8////Cv////8AAAAAAAACAAHO/////P///wqCgoL/AAAAAAAAAgAFzf///yJTeXN0ZW0uRHJhd2luZy5EcmF3aW5nMkQuRGFzaFN0eWxlAQAAAAd2YWx1ZV9fAAgDAAAAAAAAAAHM/////P///wqCgoL/AAAAAAAAAgAlAAAAAAHL/////P///wqCgoL/AAAAAAAAAgABBjYAAAAQTG90dGVyeSBXaW5uaW5ncwk3AAAACQAAAAAAEEEByP////z///8KAAAAAAAAAACkAAEAAcf////8////Cv////8AAAAAAAACAAHG/////P///wqCgoL/AAAAAAAAAgABxf///83///8AAAAAAcT////8////CoKCgv8AAAAAAAACAAABw/////z///8KgoKC/wAAAAAAAAIAAQHC/////P///wr/////AAAAAAAAAgABwf////z///8KgoKC/wAAAAAAAAIAAcD////N////AAAAAAG//////P///wqCgoL/AAAAAAAAAgAAAb7////8////CoKCgv8AAAAAAAACAAEBvf////z///8K/////wAAAAAAAAIAAAG8/////P///wqCgoL/AAAAAAAAAgABu////83///8AAAAAAbr////8////CoKCgv8AAAAAAAACABwAAAAcAAAAAAG5/////P///wqCgoL/AAAAAAAAAgABBkgAAAAIVGhlIFRlYW0JSQAAAAkAAAAAABBBAbb////8////CgAAAAAAAAAApAABAAG1/////P///wr/////AAAAAAAAAgABtP////z///8KgoKC/wAAAAAAAAIAAbP////N////AAAAAAGy/////P///wqCgoL/AAAAAAAAAgAAAbH////8////CoKCgv8AAAAAAAACAAEBsP////z///8K/////wAAAAAAAAIAAa/////8////CoKCgv8AAAAAAAACAAGu////zf///wAAAAABrf////z///8KgoKC/wAAAAAAAAIAAAGs/////P///wqCgoL/AAAAAAAAAgABEQwAAAABAAAABlUAAAArRXhhbXBsZSBEYXRhc2V0IEFzc2lnbmVkIEJ5IENvZGUgQXQgUnVudGltZQUUAAAAIFN0ZWVtYS5UZWVDaGFydC5TdHlsZXMuQ29sb3JMaXN0AwAAAA1MaXN0YDErX2l0ZW1zDExpc3RgMStfc2l6ZQ9MaXN0YDErX3ZlcnNpb24EAAAWU3lzdGVtLkRyYXdpbmcuQ29sb3JbXQMAAAAICAIAAAAJVgAAAAYAAAABAAAADxUAAAAGAAAABgAAAAAAAAAAAAAAAAAA8D8AAAAAAAAAQAAAAAAAAAhAAAAAAAAAEEAAAAAAAAAUQA8YAAAABgAAAAYAAAAAAKBhQAAAAAAA4GtAAAAAAADQcUAAAAAAACBqQAAAAAAAwGBAAAAAAACAQ0ARNwAAAAEAAAAGVwAAABBMb3R0ZXJ5IFdpbm5pbmdzEUkAAAABAAAABlgAAAAIVGhlIFRlYW0HVgAAAAABAAAABgAAAAQUU3lzdGVtLkRyYXdpbmcuQ29sb3IDAAAAAaf////8////CgAAAAAAAAAAAAAAAAGm/////P///woAAAAAAAAAAAAAAAABpf////z///8KAAAAAAAAAAAAAAAAAaT////8////CgAAAAAAAAAAAAAAAAGj/////P///woAAAAAAAAAAAAAAAABov////z///8KAAAAAAAAAAAAAAAACw==" 
        GetChartFile="GetChart.aspx"/>
    </form>
</body>
</html>