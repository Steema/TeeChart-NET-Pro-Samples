
var hostChart;

function viewCode(evt, viewType) {

   //* resizeAll();
    // Declare all variables
    var i, tabcontent, tablinks;

    // Get all elements with class="tabcontent" and hide them
    tabcontent = document.getElementsByClassName("tabcontent");
    for (i = 0; i < tabcontent.length; i++) {
        tabcontent[i].style.display = "none";
    }

    // Get all elements with class="tablinks" and remove the class "active"
    tablinks = document.getElementsByClassName("tablinks");
    for (i = 0; i < tablinks.length; i++) {
        tablinks[i].className = tablinks[i].className.replace(" active", "");
    }

    // Show the current tab, and add an "active" class to the button that opened the tab
    document.getElementById(viewType).style.display = "block";
    evt.currentTarget.className += " active";
}

function resize(element) {
    if (element != null) {
        var w = 0, xContent, canvas, chart;

        if (element instanceof HTMLCanvasElement) {
            canvas = element;

            if (canvas.chart instanceof Tee.Chart) {
                chart = canvas.chart;

                hostChart = canvas.chart; 

                if (element.offsetParent != null)
                    w = element.offsetParent.clientWidth - 280;
                else {
                    xContent = $(canvas).closest('.tabcontent')[0];
                    w = xContent.parentElement.offsetWidth * 0.95;
                }

                canvas.width = w;
                chart.bounds.width = w - 30;
                chart.draw();
            }
        }
    }
}

function resizeC(chart) {
    resize(chart.ctx.canvas);
}

function resizeAll() {
    $('canvas').each(function () {
        resize(this);
    })
}

window.onresize = function () {
    resizeAll();
}

function oldResizeC(chart) {

  hostChart = chart;

  var startWidth = 1600;
  var startHeight = 400;
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

/*$(window).on('resize', function (evt) {
    resizeAll();
});*/

$(window).on('mousemove', function (evt) {

    if ((hostChart != undefined) && (hostChart.tools != undefined)) {

        var p = new Tee.Point(evt.clientX, evt.clientY);
        var overChart = -1;

        var tooltip = undefined;
        hostChart.tools.items.forEach(tool => {
            if (tool instanceof Tee.ToolTip)
                tooltip = tool;
        });

        if (tooltip != undefined) {

            tooltip.isDom = tooltip.render === "dom";

            var rect = hostChart.canvas.getBoundingClientRect();
            rect = new Tee.Rectangle(rect.x, rect.y, rect.width, rect.height);
            if (!rect.contains(p)) {
                if (!tooltip.isDom) {
                    tooltip.hide();
                }
            }
            else {
                if (tooltip.isDom) {
                    overChart = -1; // idx;
                    return true;
                }
            }

            if ((overChart == -1) && (tooltip !== undefined)) {
                tooltip.hide();
            }
        }
    }
});