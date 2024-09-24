var chartNode;
var firstLoad = false;

var startX, startY, endX, endY; //abs coords
var chartStartX, chartStartY, chartEndX, chartEndY; //chart coords

function loadChart(chartJS, key) {

    //check allows load only if security tag exists on page
    if (document.querySelector('meta[name="a10"]') !== null)
    {
      var chartSrc = document.createElement('script');
      chartSrc.innerHTML = chartJS;
      chartSrc.type = 'text/javascript';
      chartSrc.setAttribute('nonce', key);
      chartSrc.setAttribute("id", "tSrc");

      if (chartNode !== undefined) {  //clear for re-use
        document.head.removeChild(chartNode);
        chartNode = null;
      }

      document.addEventListener("securitypolicyviolation", function (e) {
        //alert("CSP infraction!");
        chartSrc.remove();
        chartSrc = null;
      });

      //successful appendChild requires correct nonce security key
      chartNode = document.head.appendChild(chartSrc);
    }
}

function loadExtras(aChart) {

    aChart.scroll.enabled = false;

    if (firstLoad == false) {
        aChart.axes.left.setMinMax(0, 500);

        animation = new Tee.SeriesAnimation();
        animation.duration = 900;
        animation.kind = "all";
        fadeAnimation = new Tee.FadeAnimation();
        fadeAnimation.duration = 500;
        fadeAnimation.fade.series = true;
        fadeAnimation.fade.marks = true;
        animation.mode = "linear";
        fadeAnimation.mode = "linear";
        animation.items.push(fadeAnimation);

        animation.animate(aChart)

        firstLoad = true;
    }

    //tooltip
    tip = new Tee.ToolTip(aChart);
    tip.findPoint = false;
    tip.delay = 1000;
    tip.render = "dom";
    tip.domStyle = "padding-left:8px; padding-right:8px; padding-top:0px; padding-bottom:4px; margin-left:5px; margin-top:0px; ";
    tip.domStyle = tip.domStyle + "background-color:#FCFCFC; border-radius:4px 4px; color:#FFF; ";
    tip.domStyle = tip.domStyle + "border-style:solid;border-color:#A3A3AF;border-width:1px; z-index:1000;";

    aChart.tools.add(tip);

    //tip.onshow=function(tool,series,index) { scaling=2; poindex=index; }
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
            s += '<font face="verdana" color="#004000" size="1"><b>' + ser.title + ':</b></font> <font face="verdana" color="red" size="1">' + ser.data.values[index].toFixed(2) + '</font>';
        }
        return s;
    }

    aChart.zoom.enabled = false;
    var canvas = {};
    canvas.node = aChart.canvas; //document.getElementById('canvas');

    aChart.mousemove = function (e) {
        if (!canvas.isDrawing) {
            return;
        }

        endX = e.x;
        endY = e.y;

        chartEndX = e.x;
        chartEndY = e.y;

        aChart.draw();
    };
    aChart.mousedown = function (e) {
        canvas.isDrawing = true;

        var pMove = Point(0, 0);
        getOffset(e, pMove, aChart);

        chartStartX = pMove.x;
        chartStartY = pMove.y;

        startX = pMove.x;
        startY = pMove.y;
    };
    aChart.mouseup = function (e) {

        var pMove = Point(0, 0);
        getOffset(e, pMove, aChart);

        chartEndX = pMove.x;
        chartEndY = pMove.y;

        canvas.isDrawing = false;
    };
    aChart.ondraw = function () {
        var MSECSDAY = 86400000,
            a = aChart.axes.bottom,
            b = aChart.axes.left,
            days = Math.round((a.maximum - a.minimum) / MSECSDAY);

        var axRight = aChart.axes.bottom.calc(aChart.axes.bottom.maximum);
        var topLineY = 50;

        if (chartStartX) {
            aChart.ctx.fillStyle = "rgba(0, 0, 0, 1)";  //"rgba(2, 34, 55, 1)";
            aChart.ctx.font = "12px Tahoma";
            aChart.ctx.textAlign = "start";
            aChart.ctx.fillText("Line stats:", axRight - 100, topLineY - 15);
            aChart.ctx.fillText("startX: " + a.fromPos(chartStartX).toFixed(2) + "", axRight - 100, topLineY);
            aChart.ctx.fillText("endX: " + a.fromPos(chartEndX).toFixed(2) + "", axRight - 100, topLineY + 15);
            aChart.ctx.fillText("startY: " + b.fromPos(chartStartY).toFixed(2) + "", axRight - 100, topLineY + 30);
            aChart.ctx.fillText("endY: " + b.fromPos(chartEndY).toFixed(2) + "", axRight - 100, topLineY + 45);
            aChart.ctx.beginPath();
            aChart.ctx.strokeStyle = "#100000";
            aChart.ctx.moveTo(startX, startY);
            aChart.ctx.arc(startX, startY, 5, 0, 2 * Math.PI);
            aChart.ctx.stroke();
            aChart.ctx.beginPath();
            aChart.ctx.strokeStyle = "#10DD00";
            aChart.ctx.moveTo(startX, startY);
            aChart.ctx.lineTo(endX, endY);
            aChart.ctx.stroke();
            aChart.ctx.beginPath();
            aChart.ctx.strokeStyle = "#100000";
            aChart.ctx.arc(endX, endY, 5, 0, 2 * Math.PI);
            aChart.ctx.stroke();
        }
    }
}

function Point(x, y) {
    this.x = x;
    this.y = y;

    return this;
}

function getOffset(e, p, aChart) {
    p.x = e.clientX;
    p.y = e.clientY;

    var element = aChart.canvas; // this.canvas,
    var r;

    // IE, Moz3+, Chr, Op9.5+, Saf4+
    if (element.getBoundingClientRect) {
        r = element.getBoundingClientRect();
        p.x -= r.left;
        p.y -= r.top;
    } //earlier Moz.
    else if (element.offsetParent)
        do {
            p.x -= element.offsetLeft;
            p.y -= element.offsetTop;
            element = element.offsetParent;
        } while (element);
}


function resize(chart) {

    var startWidth = 900;
    var startHeight = 300;
    var w;
    var h;
    var canvas = chart.canvas;
    if (chart !== null) {
        if (/Android|webOS|iPhone|iPad|iPod|BlackBerry|IEMobile|Opera Mini/i.test(navigator.userAgent)) {

            w = window.innerWidth;
            h = window.innerHeight;
            if (w <= 991) {
                canvas.style.width = "" + w * 0.9 + "px";
                canvas.style.height = "" + w * 0.9 * startHeight / startWidth + "px";
            }
            else {
                canvas.style.width = "" + startWidth + "px";
                canvas.style.height = "" + startHeight + "px";
                chart.bounds.width = startWidth;
                chart.bounds.height = startHeight;
            }
            chart.draw();
        }
        else {
            w = startWidth;
            h = startHeight;

            if ((window.innerWidth - canvas.offsetLeft - 20) < startWidth)
                w = window.innerWidth - canvas.offsetLeft - 20;
            else
                w = startWidth;

            if ((window.innerWidth * startHeight / startWidth) < startHeight)
                h = window.innerWidth * startHeight / startWidth;
            else
                h = startHeight;

            canvas.setAttribute('width', "" + w + "px");

            canvas.setAttribute('height', "" + h + "px");

            canvas.style.width = "" + w + "px";
            canvas.style.height = "" + h + "px";

            chart.bounds.width = w;
            chart.bounds.height = h;

            chart.draw();
        }
    }
}