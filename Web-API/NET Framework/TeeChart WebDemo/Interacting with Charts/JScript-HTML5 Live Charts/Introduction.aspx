<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Introduction.aspx.cs" Inherits="Interacting_with_Charts_JScript_HTML5_Live_Charts_Introduction" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
	<HEAD>
		<title>Introduction to TeeChart for .NET's HTML5/Javascript Webform Chart rendering</title>
		<!--<LINK href="..\..\Styles\ContentStyles.css" type="text/css" rel="stylesheet">-->
		<meta name="GENERATOR" Content="Microsoft Visual Studio 7.0">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">

        <!-- Font -->
        <link rel='stylesheet' href='//fonts.googleapis.com/css?family=Arimo:400,700,400italic,700italic'>
        <link rel='stylesheet' href='//fonts.googleapis.com/css?family=Lato:300,400,700,900,400italic,700italic'>

        <link rel="stylesheet" href="/css/buttons/buttons.css">
        <link rel="stylesheet" href="/css/buttons/social-icons.css">
        <link rel="stylesheet" href="/css/font-awesome.min.css">
        <link rel="stylesheet" href="/css/bootstrap.min.css">
        <link rel="stylesheet" href="/css/jslider.css">
        <link rel="stylesheet" href="/css/settings.css">
        <link rel="stylesheet" href="/css/jquery.fancybox.css">
        <link rel="stylesheet" href="/css/animate.css">
        <link rel="stylesheet" href="/css/video-js.min.css">
        <link rel="stylesheet" href="/css/morris.css">
        <link rel="stylesheet" href="/css/royalslider/royalslider.css">
        <link rel="stylesheet" href="/css/royalslider/skins/minimal-white/rs-minimal-white.css">
        <link rel="stylesheet" href="/css/layerslider/layerslider.css">
        <link rel="stylesheet" href="/css/ladda.min.css">
        <link rel="stylesheet" href="/css/datepicker.css">
        <link rel="stylesheet" href="/css/jquery.scrollbar.css">

        <!-- Theme CSS -->
        <link rel="stylesheet" href="/css/style.css">

        <!-- Responsive CSS -->
        <link rel="stylesheet" href="/css/responsive.css">

        <!-- Custom CSS -->
        <link rel="stylesheet" href="/css/customizer/pages.css">
        <link rel="stylesheet" href="/css/customizer/pages-pages-customizer.css">
        <link rel="stylesheet" href="/css/style-child.css">

        <!-- IE Styles-->
        <link rel='stylesheet' href="/css/ie/ie.css">
	</HEAD>
<body style="margin-left:20px" >
    <form id="form1" runat="server">
    <div>
        <h2>TeeChart for .NET Webforms - HTML5/Javascript rendering</h2>
    
        <h4>Summary</h4>
        <p>TeeChart for .NET now supports native HTML5/Javascript rendering for some Series types:<br />
        <br />
        <b>Line, Point (scatter), Area, Bar, Pie, Bubble, Candle, Volume, HorizLine, HorizBar and Donut</b></li></p>
        <p>Support for more Series types will be added in upcoming releases.</p>

        <p>Export features include some tool types including the Chart scrollbar. InChart zoom and scroll are enabled and custom javascript coding is supported permitting you to
            chart almost all the options shown in the TeeChart for Javascript examples:<br /><br />
            <a href="http://www.steema.com/files/public/teechart/html5/latest/demos/" target="_blank">http://www.steema.com/files/public/teechart/html5/latest/demos/</a>.
            <br />
        </p>

        <p>You can add animations and custom canvas output. Data may be sourced directly from your .NET projects and datasources or may be sourced via a myriad of alternative 
            sources. Clientside charts are fully interactive permitting you to feedback chart clicks as arguments for drill-downs. We'll add some extra examples to show that in 
            upcoming releases.</p>

        <h4>Limitations</h4>
        <p>Besides the fact that only a limited Series set of TeeChart's NET Series are currently available for HTML5/Javascript render, there are other limitations to be taken 
            into account when using HTML5 as the render format. Not all properties are translated for render. The rendering is the 'essence' of the WebForm designtime chart and 
            we advise that you keep the designtime chart as simple as possible. Whilst the translation-parse to Javascript may be simple and limited in nature, on the plus side, 
            once in Javascript you can add many sophisticated aesthetic and functional features to the Chart. The examples in the folder show some custom code examples 
            of how this is achieved. Please look at the code-behind and the native javascript demo linked above, for a better understanding of possibilities</p>

        <h4>Future</h4>
        <p>We plan to add the following Series, Maps and Gauges types very soon:<br />
            <b>Circular-Gauges; World-Maps; Polar, Gantt and ColorGrid Series.</b>
        </p>
    </div>
    </form>
</body>
</html>
