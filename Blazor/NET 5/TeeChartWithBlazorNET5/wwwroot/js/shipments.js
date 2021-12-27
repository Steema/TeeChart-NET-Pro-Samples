
var enableCursor = false;

function setupClientChart(aChart) {
	//function series
	var avg = new Tee.Line();
	avg.title = "Average";
	var avgVals = new Array();

	aChart.title.visible = false;

	aChart.axes.bottom.datetime = true;
	aChart.axes.bottom.labels.dateFormat = "shortDate";
	aChart.series.items[0].dateFormat = "shortDate";

	for (var i = 0; i < aChart.series.items[0].data.x.length; i++)
	{
		aChart.series.items[0].data.x[i] = new Date(aChart.series.items[0].data.x[i]);
		avgVals[i] = (aChart.series.items[0].data.values[i] + aChart.series.items[1].data.values[i]) / 2;
	}

	avg.data.values = avgVals;
	avg.data.x = aChart.series.items[0].data.x;
	avg.format.stroke.size = 2;
	avg.smooth = 0.5;
	aChart.addSeries(avg);

	//tooltip
	tip = new Tee.ToolTip(aChart);
	tip.render = "dom";
	tip.findPoint = false;
	tip.domStyle = "padding-left:8px; padding-right:8px; padding-top:0px; padding-bottom:4px; margin-left:5px; margin-top:0px; ";
	tip.domStyle = tip.domStyle + "background-color:#FCFCFC; border-radius:4px 4px; color:#FFF; ";
	tip.domStyle = tip.domStyle + "border-style:solid;border-color:#A3A3AF;border-width:1px; z-index:1000;";

	aChart.tools.add(tip);

	tip.onhide = function () { scaling = 0; poindex = -1; }

	var t = new Tee.CursorTool(aChart);
	t.direction = "vertical";

	tip.onshow = function (tool, series, index) {
		if (!enableCursor) {
			aChart.tools.add(t);
			enableCursor = true;
		}
	}

	tip.ongettext = function (tool, text, series, index) {
		var t, s = "", ser;

		for (t = 0; t < aChart.series.count(); t++) {
			if (t > 0) s += "<br/>";
			ser = aChart.series.items[t];
			s += '<font face="verdana" color="darkorange" size="1"><b>' + ser.title + ':</b></font> <font face="verdana" color="red" size="1">' + ser.data.values[index].toFixed(2) + '</font>';
		}
		//console.log(index);
		return s;
	}

	aChart.applyTheme("minimal");

	//animation
	animation = new Tee.SeriesAnimation();
	animation.duration = 1500;
	animation.kind = "each";
	fadeAnimation = new Tee.FadeAnimation();
	fadeAnimation.duration = 500;
	fadeAnimation.fade.series = true;
	fadeAnimation.fade.marks = true;
	animation.mode = "linear";
	fadeAnimation.mode = "linear";
	animation.items.push(fadeAnimation);

	animation.animate(aChart);
}


function convertWinJSDate(aDateTime) {
	return aDateTime
		.Subtract(new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc))
		.TotalMilliseconds;
}