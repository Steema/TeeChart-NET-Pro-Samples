var chartNode;
var firstLoad = false;

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

    if (firstLoad == false) {
        aChart.axes.left.setMinMax(0, 50);

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