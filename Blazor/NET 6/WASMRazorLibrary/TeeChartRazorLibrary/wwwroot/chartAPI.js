
import { Chart } from './teechart.js';
import { Bar } from './teechart.js';
import { Area } from './teechart.js';
import { Line } from './teechart.js';
import { SeriesAnimation } from './teechart.js';
import { Theme } from './teechart-extras.js';

var chart = new Chart("teeCanvas");
const charts = [];

export function setChart(chartName) {
    if (charts.length == 0) {
        charts.push({ canvas: "teeCanvas", tchart: chart });
    }

    var chartobj = charts.find(c => c.canvas == chartName);

    if (chartobj == null) {
        chart = new Chart(chartName);
        charts.push({ canvas: chartName, tchart: chart });
    }
    else {
        chart = chartobj.tchart;
    }
}

export function setChartTitle(aText) {
  chart.title.text = aText;
}

export function setAxisMinMax(axis, min, max) {
    switch (axis) {
        case "Bottom":
            chart.axes.bottom.automatic = false;
            chart.axes.bottom.minimum = min;
            chart.axes.bottom.maximum = max;
            break;
        case "Left":
            chart.axes.left.automatic = false;
            chart.axes.left.minimum = min;
            chart.axes.left.maximum = max;
            break;
    }
}

export function appendData(seriesIndex, xData, yData) {
    chart.getSeries(seriesIndex).data.values.push(yData);
    chart.getSeries(seriesIndex).data.x.push(xData);
}

export function addData(seriesIndex, xData, yData) {
    chart.getSeries(seriesIndex).data.values = yData;
    chart.getSeries(seriesIndex).data.x = xData;
}

export function addDateData(seriesIndex, xDateData, yData) {
  chart.getSeries(seriesIndex).data.values = yData;
  chart.getSeries(seriesIndex).data.x = [];

  for (var t = 0; t < chart.getSeries(seriesIndex).data.values.length; t++) {
    chart.getSeries(seriesIndex).data.x[t] = new Date(xDateData[t]);
  }

  chart.axes.bottom.increment = 86400000;
  chart.axes.bottom.labels.dateFormat = "d/M/yyyy";
}

// sets the aTheme to the aChart
export function changeTheme(aTheme) {
    Theme.applyTheme(chart, aTheme);

    for (var i = 0; i < chart.series.count(); i++) {
        if ((chart.series.items[i].pointer) && (chart.series.items[i].pointer.format))
            chart.series.items[i].pointer.format.stroke.fill = "white";
    }
}

export function addSeries(series) {
    var series1;
    switch (series) {
        case "Area":
            series1 = chart.addSeries(new Area());
            break;
        case "Bar":
            series1 = chart.addSeries(new Bar());
            break;
        case "Line":
            series1 = chart.addSeries(new Line());
            break;
        default:
        // code block
    }

    series1.format.fill = "#7799D6";
    series1.format.gradient.colors = ["#FFD700", "#FFFFFF"];
    series1.format.gradient.direction = "topbottom";
    series1.format.gradient.visible = false;
    series1.format.shadow.color = "#A9A9A9";
    series1.format.shadow.width = 3;
    series1.format.shadow.height = 3;
    series1.format.shadow.visible = false;
    series1.format.shadow.blur = 0;
    series1.format.round.x = 0;
    series1.format.round.y = 0;
    series1.format.stroke.fill = "#475C80";
    series1.format.stroke.cap = "butt";
    series1.colorEach = "no";
    series1.hover.enabled = false;
    series1.marks.visible = true;
    series1.marks.format.round.x = 0;
    series1.marks.format.round.y = 0;
    series1.marks.format.font.style = "12px Verdana";
    series1.marks.format.font.fill = "#000000";
    series1.marks.format.font.shadow.color = "#A9A9A9";
    series1.marks.format.font.shadow.width = 1;
    series1.marks.format.font.shadow.height = 1;
    series1.marks.format.font.shadow.visible = false;
    series1.marks.format.font.shadow.blur = 0;
    series1.marks.format.fill = "#FFFFFF";
    series1.marks.format.gradient.colors = ["#FFD700", "#FFFFFF"];
    series1.marks.format.gradient.direction = "topbottom";
    series1.marks.format.gradient.visible = false;
    series1.marks.format.stroke.fill = "#6B8AC1";
    series1.marks.format.stroke.cap = "butt";
    series1.marks.format.shadow.visible = false;
    series1.marks.arrow.visible = false;
    series1.marks.arrow.length = 10;
}

export function animateSeries(aDuration) {

    var animation;
    var fadeAnimation;

    animation = new SeriesAnimation();
    animation.duration = aDuration;
    animation.kind = "each";
    fadeAnimation = new Tee.FadeAnimation();
    fadeAnimation.duration = 500;
    fadeAnimation.fade.series = true;
    fadeAnimation.fade.marks = true;
    animation.mode = "linear";
    fadeAnimation.mode = "linear";
    animation.items.push(fadeAnimation);

    animation.animate(chart);
}

export function drawChart() {
    chart.scroll.direction = 'both';
    chart.zoom.direction = 'both';
    chart.panel.format.fill = "#FFFFFF";
    chart.panel.format.gradient.colors = ["#EAEAEA", "#FFFFFF"];
    chart.panel.format.gradient.direction = "topbottom";
    chart.panel.format.gradient.visible = false;
    chart.panel.format.stroke.fill = "";
    chart.panel.format.stroke.cap = "butt";
    chart.panel.format.shadow.visible = false;
    chart.panel.margins.left = 3;
    chart.panel.margins.right = 3;
    chart.panel.margins.top = 4;
    chart.panel.margins.bottom = 4;
    chart.walls.back.visible = false;
    chart.walls.back.format.fill = "";
    chart.walls.back.format.stroke.fill = "";
    chart.walls.back.format.gradient.colors = ["#EAEAEA", "#FFFFFF"];
    chart.walls.back.format.gradient.direction = "topbottom";
    chart.walls.back.format.gradient.visible = true;
    chart.walls.back.format.stroke.fill = "#000000";
    chart.walls.back.format.stroke.cap = "butt";
    chart.walls.back.format.shadow.visible = false;
    if (chart.title.text == "")
      chart.title.text = "TeeChart Razor component example";
    chart.title.format.font.style = "16px Verdana";
    chart.title.format.font.fill = "#808080";
    chart.title.format.font.shadow.color = "#A9A9A9";
    chart.title.format.font.shadow.width = 1;
    chart.title.format.font.shadow.height = 1;
    chart.title.format.font.shadow.visible = false;
    chart.title.format.font.shadow.blur = 0;
    chart.footer.visible = false;
    //chart.palette = new Tee.Palette(["#7799D6", "#FFCF68", "#FF7F47", "#81CADB", "#5E739E", "#50AE96", "#E63B41", "#FFF390", "#90EAD1", "#A3A3A3", "#FFFFC0", "#E7E7E7"]);
    chart.axes.left.start = 0;
    chart.axes.left.end = 100;
    chart.axes.left.position = 0;
    chart.axes.left.labels.format.font.style = "13px Verdana";
    chart.axes.left.labels.format.font.fill = "#808080";
    chart.axes.left.labels.format.font.shadow.color = "#A9A9A9";
    chart.axes.left.labels.format.font.shadow.width = 1;
    chart.axes.left.labels.format.font.shadow.height = 1;
    chart.axes.left.labels.format.font.shadow.visible = false;
    chart.axes.left.labels.format.font.shadow.blur = 0;
    chart.axes.left.format.stroke.fill = "";
    chart.axes.left.format.stroke.size = 2;
    chart.axes.left.format.stroke.cap = "butt";
    chart.axes.left.grid.format.stroke.fill = "#A9A9A9";
    chart.axes.left.grid.format.stroke.cap = "butt";
    chart.axes.left.title.text = "ºC";
    chart.axes.left.title.format.round.x = 0;
    chart.axes.left.title.format.round.y = 0;
    chart.axes.left.title.format.font.style = "15px Verdana";
    chart.axes.left.title.format.font.fill = "#404040";
    chart.axes.left.title.format.font.shadow.color = "#A9A9A9";
    chart.axes.left.title.format.font.shadow.width = 1;
    chart.axes.left.title.format.font.shadow.height = 1;
    chart.axes.left.title.format.font.shadow.visible = false;
    chart.axes.left.title.format.font.shadow.blur = 0;
    chart.axes.left.title.format.fill = "";
    chart.axes.left.title.format.stroke.fill = "";
    chart.axes.left.title.format.gradient.colors = ["#FFD700", "#FFFFFF"];
    chart.axes.left.title.format.gradient.direction = "topbottom";
    chart.axes.left.title.format.gradient.visible = false;
    chart.axes.left.title.format.stroke.fill = "#000000";
    chart.axes.left.title.format.stroke.cap = "butt";
    chart.axes.left.title.format.shadow.visible = false;
    chart.axes.top.visible = false;
    chart.axes.top.start = 0;
    chart.axes.top.end = 100;
    chart.axes.top.position = 0;
    chart.axes.top.labels.format.font.style = "13px Verdana";
    chart.axes.top.labels.format.font.fill = "#808080";
    chart.axes.top.labels.format.font.shadow.color = "#A9A9A9";
    chart.axes.top.labels.format.font.shadow.width = 1;
    chart.axes.top.labels.format.font.shadow.height = 1;
    chart.axes.top.labels.format.font.shadow.visible = false;
    chart.axes.top.labels.format.font.shadow.blur = 0;
    chart.axes.top.format.stroke.fill = "#404040";
    chart.axes.top.format.stroke.size = 2;
    chart.axes.top.format.stroke.cap = "butt";
    chart.axes.top.grid.format.stroke.fill = "#A9A9A9";
    chart.axes.top.grid.format.stroke.cap = "butt";
    chart.axes.right.visible = false;
    chart.axes.right.start = 0;
    chart.axes.right.end = 100;
    chart.axes.right.position = 0;
    chart.axes.right.labels.format.font.style = "13px Verdana";
    chart.axes.right.labels.format.font.fill = "#808080";
    chart.axes.right.labels.format.font.shadow.color = "#A9A9A9";
    chart.axes.right.labels.format.font.shadow.width = 1;
    chart.axes.right.labels.format.font.shadow.height = 1;
    chart.axes.right.labels.format.font.shadow.visible = false;
    chart.axes.right.labels.format.font.shadow.blur = 0;
    chart.axes.right.format.stroke.fill = "";
    chart.axes.right.format.stroke.size = 2;
    chart.axes.right.format.stroke.cap = "butt";
    chart.axes.right.grid.format.stroke.fill = "#A9A9A9";
    chart.axes.right.grid.format.stroke.cap = "butt";
    //chart.axes.bottom.increment = 86400000;
    chart.axes.bottom.labels.dateFormat = "dd/mm/yyyy";
    //chart.axes.bottom.start = 0;
    //chart.axes.bottom.end = 100;
    chart.axes.bottom.position = 0;
    chart.axes.bottom.labels.format.font.style = "13px Verdana";
    chart.axes.bottom.labels.format.font.fill = "#808080";
    chart.axes.bottom.labels.format.font.shadow.color = "#A9A9A9";
    chart.axes.bottom.labels.format.font.shadow.width = 1;
    chart.axes.bottom.labels.format.font.shadow.height = 1;
    chart.axes.bottom.labels.format.font.shadow.visible = false;
    chart.axes.bottom.labels.format.font.shadow.blur = 0;
    chart.axes.bottom.format.stroke.fill = "#404040";
    chart.axes.bottom.format.stroke.size = 2;
    chart.axes.bottom.format.stroke.cap = "butt";
    chart.axes.bottom.grid.visible = false;
    chart.axes.bottom.grid.format.stroke.fill = "";
    chart.axes.bottom.grid.format.stroke.cap = "butt";
    chart.legend.position = "right";
    chart.legend.legendStyle = "auto";
    chart.legend.format.round.x = 0;
    chart.legend.format.round.y = 0;
    chart.legend.format.font.style = "13px Verdana";
    chart.legend.format.font.fill = "#404040";
    chart.legend.format.font.shadow.color = "#A9A9A9";
    chart.legend.format.font.shadow.width = 1;
    chart.legend.format.font.shadow.height = 1;
    chart.legend.format.font.shadow.visible = false;
    chart.legend.format.font.shadow.blur = 0;
    chart.legend.format.fill = "";
    chart.legend.format.stroke.fill = "";
    chart.legend.format.gradient.colors = ["#FFD700", "#FFFFFF"];
    chart.legend.format.gradient.direction = "topbottom";
    chart.legend.format.gradient.visible = false;
    chart.legend.format.stroke.fill = "";
    chart.legend.format.stroke.cap = "butt";
    chart.legend.format.shadow.visible = false;
    chart.legend.transparent = true;
    chart.legend.symbol.format.stroke.fill = "#00000000";
    chart.legend.symbol.format.stroke.cap = "butt";
    chart.legend.symbol.format.shadow.color = "#A9A9A9";
    chart.legend.symbol.format.shadow.width = 0;
    chart.legend.symbol.format.shadow.height = 0;
    chart.legend.symbol.format.shadow.visible = false;
    chart.legend.symbol.format.shadow.blur = 0;
    prettify();
    chart.draw();
}

function prettifyPanel() {
    chart.panel.format.gradient.visible = false;
    chart.panel.format.fill = "white";
    chart.panel.format.fill = "#FFFFFF";
    chart.panel.format.gradient.colors = ["#EAEAEA", "#FFFFFF"];
    chart.panel.format.gradient.direction = "topbottom";
    chart.panel.format.gradient.visible = false;
    chart.panel.format.stroke.fill = "";
    chart.panel.format.stroke.cap = "butt";
    chart.panel.format.shadow.visible = false;
    chart.panel.margins.top = 10;
    chart.panel.margins.right = 5;
}

function prettifyLegend() {
    chart.legend.format.shadow.visible = false;
    chart.legend.position = "bottom";
    chart.legend.legendStyle = "series";
    chart.legend.format.font.style = "12px Arial";
    chart.legend.symbol.format.shadow.visible = false;
    chart.legend.format.round.x = 0;
    chart.legend.format.round.y = 0;
    chart.legend.format.font.style = "13px Verdana";
    chart.legend.format.font.fill = "#404040";
    chart.legend.format.font.shadow.color = "#A9A9A9";
    chart.legend.format.font.shadow.width = 1;
    chart.legend.format.font.shadow.height = 1;
    chart.legend.format.font.shadow.visible = false;
    chart.legend.format.font.shadow.blur = 0;
    chart.legend.format.fill = "";
    chart.legend.format.stroke.fill = "";
    chart.legend.format.gradient.colors = ["#FFD700", "#FFFFFF"];
    chart.legend.format.gradient.direction = "topbottom";
    chart.legend.format.gradient.visible = false;
    chart.legend.format.stroke.fill = "";
    chart.legend.format.stroke.cap = "butt";
    chart.legend.format.shadow.visible = false;
    chart.legend.transparent = true;
    chart.legend.symbol.format.stroke.fill = "#00000000";
    chart.legend.symbol.format.stroke.cap = "butt";
    chart.legend.symbol.format.shadow.color = "#A9A9A9";
    chart.legend.symbol.format.shadow.width = 0;
    chart.legend.symbol.format.shadow.height = 0;
    chart.legend.symbol.format.shadow.visible = false;
    chart.legend.symbol.format.shadow.blur = 0;
    chart.legend.format.stroke.fill = "";
}

function prettifyAxes() {
    // chart.axes.left.checkMinMax = function () {
    //   const series = chart.series;
    //   const offset =
    //     (series.maxYValue(this) - series.minYValue(this)) *
    //     this.offsetPercent *
    //     0.01;
    //   this.minimum = series.minYValue(this) - offset;
    //   this.maximum = series.maxYValue(this) + offset;
    //   this.checkRange();
    // };

    chart.axes.left.start = 0;
    chart.axes.left.end = 100;
    chart.axes.left.position = 0;
    chart.axes.left.offsetPercent = 10;
    chart.axes.left.labels.format.font.style = "13px Verdana";
    chart.axes.left.labels.format.font.fill = "#808080";
    chart.axes.left.labels.format.font.shadow.color = "#A9A9A9";
    chart.axes.left.labels.format.font.shadow.width = 1;
    chart.axes.left.labels.format.font.shadow.height = 1;
    chart.axes.left.labels.format.font.shadow.visible = false;
    chart.axes.left.labels.format.font.shadow.blur = 0;
    chart.axes.left.labels.decimals = 1;
    chart.axes.left.format.stroke.fill = "";
    chart.axes.left.format.stroke.size = 2;
    chart.axes.left.format.stroke.cap = "butt";
    chart.axes.left.grid.format.stroke.fill = "#EEEEEE";
    chart.axes.left.grid.format.stroke.cap = "butt";
    chart.axes.left.title.visible = true;
    chart.axes.left.title.text = "ºC";
    chart.axes.left.title.format.round.x = 0;
    chart.axes.left.title.format.round.y = 0;
    chart.axes.left.title.format.font.style = "15px Verdana";
    chart.axes.left.title.format.font.fill = "#404040";
    chart.axes.left.title.format.font.shadow.color = "#A9A9A9";
    chart.axes.left.title.format.font.shadow.width = 1;
    chart.axes.left.title.format.font.shadow.height = 1;
    chart.axes.left.title.format.font.shadow.visible = false;
    chart.axes.left.title.format.font.shadow.blur = 0;
    chart.axes.left.title.format.fill = "";
    chart.axes.left.title.format.stroke.fill = "";
    chart.axes.left.title.format.gradient.colors = ["#FFD700", "#FFFFFF"];
    chart.axes.left.title.format.gradient.direction = "topbottom";
    chart.axes.left.title.format.gradient.visible = false;
    chart.axes.left.title.format.stroke.fill = "#000000";
    chart.axes.left.title.format.stroke.cap = "butt";
    chart.axes.left.title.format.shadow.visible = false;
    chart.axes.left.ticks.visible = false;

    chart.axes.top.visible = false;
    chart.axes.top.start = 0;
    chart.axes.top.end = 100;
    chart.axes.top.position = 0;
    chart.axes.top.offsetPercent = 10;
    chart.axes.top.labels.format.font.style = "13px Verdana";
    chart.axes.top.labels.format.font.fill = "#808080";
    chart.axes.top.labels.format.font.shadow.color = "#A9A9A9";
    chart.axes.top.labels.format.font.shadow.width = 1;
    chart.axes.top.labels.format.font.shadow.height = 1;
    chart.axes.top.labels.format.font.shadow.visible = false;
    chart.axes.top.labels.format.font.shadow.blur = 0;
    chart.axes.top.format.stroke.fill = "#404040";
    chart.axes.top.format.stroke.size = 2;
    chart.axes.top.format.stroke.cap = "butt";
    chart.axes.top.grid.format.stroke.fill = "#A9A9A9";
    chart.axes.top.grid.format.stroke.cap = "butt";

    chart.axes.right.visible = false;
    chart.axes.right.start = 0;
    chart.axes.right.end = 100;
    chart.axes.right.position = 0;
    chart.axes.right.labels.format.font.style = "13px Verdana";
    chart.axes.right.labels.format.font.fill = "#808080";
    chart.axes.right.labels.format.font.shadow.color = "#A9A9A9";
    chart.axes.right.labels.format.font.shadow.width = 1;
    chart.axes.right.labels.format.font.shadow.height = 1;
    chart.axes.right.labels.format.font.shadow.visible = false;
    chart.axes.right.labels.format.font.shadow.blur = 0;
    chart.axes.right.format.stroke.fill = "";
    chart.axes.right.format.stroke.size = 2;
    chart.axes.right.format.stroke.cap = "butt";
    chart.axes.right.grid.format.stroke.fill = "#A9A9A9";
    chart.axes.right.grid.format.stroke.cap = "butt";

    //this.chart.axes.bottom.increment = 86400000;
    //chart.axes.bottom.labels.dateFormat = "hh:mm.ss";
    chart.axes.bottom.labels.format.font.style = "12px Verdana";
    chart.axes.bottom.labels.format.font.fill = "#808080";
    chart.axes.bottom.labels.format.font.shadow.color = "#A9A9A9";
    chart.axes.bottom.labels.format.font.shadow.width = 1;
    chart.axes.bottom.labels.format.font.shadow.height = 1;
    chart.axes.bottom.labels.format.font.shadow.visible = false;
    chart.axes.bottom.labels.format.font.shadow.blur = 0;
    chart.axes.bottom.labels.decimals = 0;
    chart.axes.bottom.format.stroke.fill = "#FFFFFF";
    chart.axes.bottom.format.stroke.size = 1;
    chart.axes.bottom.format.stroke.cap = "butt";
    chart.axes.bottom.grid.visible = false;
    chart.axes.bottom.grid.format.stroke.fill = "";
    chart.axes.bottom.grid.format.stroke.cap = "butt";
    chart.axes.bottom.ticks.visible = false;

    function cuteMandatoryAxis(axis) {
        axis.title.format.font.setSize(13);
        axis.title.format.font.fill = "#555555";
        axis.labels.decimals = 0;
        axis.title.format.font.style = "14px Arial";
        axis.format.stroke.fill = "rgba(0, 0, 0, 0.3)";
        axis.format.stroke.size = 1;
        axis.ticks.visible = true;
        axis.ticks.length = 10;
        axis.innerTicks.visible = false;
        axis.grid.visible = true;
    }
    function cuteNotMandatoryAxis(axis) {
        axis.ticks.visible = true;
        axis.ticks.stroke.fill = "transparent";
        axis.ticks.length = 6;
        axis.format.stroke.size = 1;
        axis.format.stroke.fill = "rgba(0, 0, 0, 0.3)";
        axis.labels.format.font.style = "12px Arial";
        axis.labels.dateFormat = "isoTime";
        axis.grid.visible = false;
    }

    // cuteMandatoryAxis(this.chart.axes.bottom);
    // cuteNotMandatoryAxis(this.chart.axes.left);
}

function prettifySeries() {
    chart.series.items.forEach(serie => {
        if (serie instanceof Area) {
            serie.format.transparency = 0.1;
            serie.format.shadow.visible = false;
            serie.format.stroke.fill = serie.format.fill;
            serie.format.stroke.size = 2;
        }
        else if (serie instanceof Line) {
            serie.pointer.visible = true;
            serie.format.transparency = 0;
            serie.format.stroke.size = 2;
            serie.pointer.style = "ellipse";
            serie.pointer.format.shadow.visible = false;
            serie.pointer.setSize(8);
            serie.pointer.format.gradient.visible = false;
            serie.pointer.format.stroke.fill = "white";
            serie.pointer.format.stroke.size = 1;
            serie.format.shadow.blur = 0;
            serie.format.shadow.width = 0;
            serie.format.shadow.height = 0;
        }
        else if (serie instanceof Bar) {
            serie.format.gradient.visible = false;
            serie.colorEach = false;
            serie.format.round.x = 0;
            serie.format.round.y = 0;
            serie.marks.arrow.visible = false;
            serie.marks.visible = false;
            serie.format.transparency = 0.1;
            serie.format.shadow.visible = false;
            serie.format.stroke.fill = "transparent";
            serie.marks.format.shadow.visible = false;
            serie.marks.format.fill = "white";
        }
    });
}

function prettify() {
    //chart.title.visible = false;
    //chart.footer.visible = false;
    //chart.walls.visible = false;
    //chart.scroll.direction = "both";
    //chart.zoom.direction = "both";

    prettifyPanel();
    prettifyLegend();
    prettifyAxes();
    prettifySeries();
}