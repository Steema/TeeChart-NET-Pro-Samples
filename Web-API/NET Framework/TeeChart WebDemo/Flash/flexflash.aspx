<%@ Page Language="C#" AutoEventWireup="true" CodeFile="flexflash.aspx.cs" Inherits="Flash_FlexFlash" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>TeeChart Flash via Flex</title>
	<LINK href="..\Styles\ContentStyles.css" type="text/css" rel="stylesheet">
	<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
	<meta content="C#" name="CODE_LANGUAGE">
	<meta content="JavaScript" name="vs_defaultClientScript">
	<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
    <style type="text/css">
        #Object1
        {
            float: right;
        }
        </style>
</head>
<body>
<asp:Label ID="Label1" runat="server" 
            
            
        Text="TeeChart can generate Flash Charts via the Adobe Flex compiler.&lt;br&gt;Some animations are already included (mouseover points for example) and we'll be adding more features as time progresses."></asp:Label>

<div style="position: absolute; top: 70px; left: 10px;">            
<table width="80%" border="0" cellpadding="0" cellspacing="0"><tr><td><object classid="clsid:D27CDB6E-AE6D-11cf-96B8-444553540000"
id="Chart1" width="250" height="150" menu="true"
codebase="http://fpdownload.macromedia.com/get/flashplayer/current/swflash.cab">
<param name="movie" value="FlexFlashChart.swf" />
<param name="quality" value="high" />
<param name="menu" value="true" />
<param name="bgcolor" value="FFFFFF">
<param name="allowScriptAccess" value="sameDomain" />
<embed src="FlexFlashChart.swf" width="250" height="150">
</object></td><td>&nbsp;&nbsp;&nbsp;&nbsp;</td><td>Steema chose the term Compact Chart to represent the kind of small 'Chartlet' that might be useful in a column on an information page, 
    perhaps as an accessory to editorial text. Notwithstanding the Chart may be created in any 
    size required.</td></tr>
</table>            
</div>
</body>
</html>
