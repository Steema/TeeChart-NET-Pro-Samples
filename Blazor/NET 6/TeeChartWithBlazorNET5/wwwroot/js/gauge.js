

function modGauge(aChart, aGauge) {

    theChart = aChart;

    aGauge.format.font.style = "12px Arial";
    aGauge.format.font.fill = "black";
    aGauge.format.font.shadow.visible = true;
    aGauge.format.gradient.colors[1] = "#999999";
    aGauge.format.gradient.colors[0] = "#EEEEEE";
    aGauge.ticksBack.visible = true;
    //aGauge.ticksBack.radius = 0;
    aGauge.ticksBack.ranges = [{ value: 0, fill: "rgba(255,255,255,0.0)" }, { value: 3, fill: "rgba(255,0,0,0.1)" }];
    aGauge.ticksBack.gradient.visible = true;
    aGauge.shape = "rectangle";
    aGauge.bounds.custom = true;
    aGauge.bounds.set(10, 40, 480, 280);
    aGauge.ticks.outside = false;
    aGauge.ticks.stroke.fill = "gray";
    aGauge.bevel.gradient.direction = "rightleft";
    aGauge.bevel.gradient.colors = ["gray", "#525151"];
    aGauge.bevel.round.x = 8;
    aGauge.bevel.round.y = 8;
    aGauge.format.size = 8;
    aGauge.value = 1.5;
    aGauge.min = -10;
    aGauge.max = 3;
    aGauge.step = 1;
    aGauge.ongetText = function (value) {
        return value < 0 ? value : "+" + value;
    }
    aGauge.units.text = "VU";
    aGauge.units.location.y = -10;
    aGauge.units.format.font.fill = "black";
    aGauge.units.format.font.style = "16px Arial";
    aGauge.back.gradient.colors[1] = "#EFCE92";
    aGauge.back.gradient.colors[0] = "#FEF8B9";
    aGauge.back.round.x = 8;
    aGauge.back.round.y = 8;
    aGauge.center.location.y = 60;
    aGauge.angle = 90;
    aGauge.hand.size = 3;
    aGauge.hand.back = 0;
    aGauge.hand.length = 65;
    aGauge.hand.gradient.colors[1] = "black";
    aGauge.hand.gradient.direction = "rightleft";
}

var updown = true;
var counter = 0;
var theChart;

function modVal() {
    var rnd = Math.random();
    var val = theChart.series.items[0].value;
    if (updown) {
        val = val + rnd;
        if (val > 2.5) val = 2.5;
        theChart.series.items[0].value = val;
        updown = false;
    }
    else {
        val = val - rnd;
        if (val < -5) val = -5;
        theChart.series.items[0].value = val;
        updown = true;
    }

    theChart.draw();

    if (counter < 1000)
        setTimeout(modVal, 100);
    counter++;
}

var startVal = Math.random() * 100;

function growVal(aChart) {

    if (aChart != undefined)
      theChart = aChart;
    
    if (theChart.series.items[0].value < startVal) {
        theChart.series.items[0].value = theChart.series.items[0].value + 1;
    }

    theChart.draw();

    if (theChart.series.items[0].value < startVal)
        setTimeout(growVal, 50);
    counter++;
}