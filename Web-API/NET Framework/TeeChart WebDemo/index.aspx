<%@ Page language="c#" Inherits="WebDemo.index" CodeFile="index.aspx.cs" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<TITLE>TeeChart ASP.NET Samples Environment</TITLE>
		<script>
		var infoPagesFrameRows = "*,40%";
		</script>
	</HEAD>
	<frameset id="Framemain" frameSpacing="0" rows="82,85%" frameBorder="0">
		<frame id="Frameheader" src="Header.htm" noResize scrolling="no">
		<frameset id="Frametop" frameSpacing="2" frameBorder="0" cols="256,*">
			<frame id="Framenavigation" src="FrameNavigation.htm" scrolling="no">
			<frame id="Framesample" src="FrameSample.htm" scrolling="no" noResize>
		</frameset>
		<noframes>
			<body>
				<p>This page uses frames, but your browser doesn't support them.</p>
			</body>
		</noframes>
	</frameset>
</HTML>
