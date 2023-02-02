


function chartFeatures(aChart) {
    setupFeatures(aChart);
    if (aChart.series.items[0].style == "candle")
      setupCandleTooltip(aChart);
    else
      setupTooltip(aChart);
}


function setupFeatures(aChart) {
    aChart.applyTheme("minimal");

    //config some series appearance characteristics
    for (var i = 0; i < aChart.series.items.length; i++) {
        aChart.series.items[i].format.stroke.fill = aChart.series.items[i].format.fill;
        aChart.series.items[i].format.stroke.size = 2;
        aChart.series.items[i].format.shadow.visible = false;
        aChart.series.items[i].format.transparency = 0.12;
        aChart.series.items[i].hover = false;
        aChart.series.items[i].smooth = 0.5;
    }
}

function setupTooltip(aChart) {
    //tooltip
    tip = new Tee.ToolTip(aChart);
    tip.render = "dom";
    tip.delay = 3000;
    tip.autoHide = true;
    //tip.findPoint = true;
    tip.domStyle = "padding-left:8px; padding-right:8px; padding-top:0px; padding-bottom:4px; margin-left:5px; margin-top:0px; ";
    tip.domStyle = tip.domStyle + "background-color:#FCFCFC; border-radius:4px 4px; color:#FFF; ";
    tip.domStyle = tip.domStyle + "border-style:solid;border-color:#A3A3AF;border-width:1px; z-index:1000;";

    aChart.tools.add(tip);
    tip.onhide = function () { scaling = 0; poindex = -1; }
    tip.ongettext = function (tool, text, series, index) {
        var t, s = "", ser;

        if (typeof (aChart.series.items[0].data.labels[index]) !== 'undefined') {
            s += '<font face="verdana" color="darkblue" size="1"><strong>' + aChart.series.items[0].data.labels[index] + '</strong></font>';
            s += "<br/>";
        }

        for (t = 0; t < aChart.series.count(); t++) {
            ser = aChart.series.items[t];
            if (!Number.isNaN(ser.data.values[index])) {
                if (t != 0)
                  s += "<br/>";
                s += '<font face="verdana" color="#222222" size="1"><b>' + ser.title + ':</b></font> <font face="verdana" color="red" size="1">' + aChart.axes.left.labels.formatValueString(ser.data.values[index]) + '</font>';
            }
        }
        return s;
    }
}

function setupCandleTooltip(aChart) {

    tip = new Tee.ToolTip(aChart);
    tip.render = "dom";
    tip.domStyle = "padding-left:8px; padding-right:8px; padding-top:0px; padding-bottom:4px; margin-left:5px; margin-top:0px; ";
    tip.domStyle = tip.domStyle + "background-color:#FCFCFC; border-radius:4px 4px; color:#FFF; ";
    tip.domStyle = tip.domStyle + "border-style:solid;border-color:#A3A3AF;border-width:1px; z-index:1000;";

    aChart.tools.add(tip);

    tip.onhide = function () { scaling = 0; poindex = -1; }

    tip.onshow = function (tool, series, index) {
    }

    tip.ongettext = function (tool, text, series, index) {
        var t, s = "", ser;

        for (t = 0; t < aChart.series.count(); t++) {
            if (t > 0) s += "<br/>";
            ser = aChart.series.items[t];
            s += '<font face="verdana" color="MediumSlateBlue" size="1"><b>open:</b></font> <font face="verdana" color="#CD5C5C" size="1">' + ser.data.open[index].toFixed(2) + '</font><br/>';
            s += '<font face="verdana" color="MediumSlateBlue" size="1"><b>close:</b></font> <font face="verdana" color="#CD5C5C" size="1">' + ser.data.close[index].toFixed(2) + '</font><br/>';
            s += '<font face="verdana" color="MediumSlateBlue" size="1"><b>lowest:</b></font> <font face="verdana" color="#CD5C5C" size="1">' + ser.data.low[index].toFixed(2) + '</font><br/>';
            s += '<font face="verdana" color="MediumSlateBlue" size="1"><b>highest:</b></font> <font face="verdana" color="#CD5C5C" size="1">' + ser.data.high[index].toFixed(2) + '</font>';
        }
        return s;
    }
}