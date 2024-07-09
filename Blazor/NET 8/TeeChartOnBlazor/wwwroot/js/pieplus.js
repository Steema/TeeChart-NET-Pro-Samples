
function animatedPie(aChart) {
	var timer = setInterval(function () {
		resizeC(aChart);
		aChart.series.items[0].marks.arrow.stroke.fill = "rgba(255,255,255,1.0)";
		aChart.series.items[0].angleWidth += 2;
		if (aChart.series.items[0].angleWidth >= 360) {
			clearInterval(timer);
			aChart.series.items[0].marks.format.font.fill = "rgba(0,0,0,1.0)";
			aChart.series.items[0].marks.visible = "true";
		}
		aChart.draw();
	}, 1);
}