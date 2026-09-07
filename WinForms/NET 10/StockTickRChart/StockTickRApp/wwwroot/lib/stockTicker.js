// Crockford's supplant method (poor man's templating)
if (!String.prototype.supplant) {
    String.prototype.supplant = function (o) {
        return this.replace(/{([^{}]*)}/g,
            function (a, b) {
                var r = o[b];
                return typeof r === 'string' || typeof r === 'number' ? r : a;
            }
        );
    };
}

var stockTable = document.getElementById('stockTable');
var stockTableBody = stockTable.getElementsByTagName('tbody')[0];
var rowTemplate = '<td>{symbol}</td><td>{price}</td><td>{dayOpen}</td><td>{dayHigh}</td><td>{dayLow}</td><td class="changeValue"><span class="dir {directionClass}">{direction}</span> {change}</td><td>{percentChange}</td><td>{photoChart}</td>';
var tickerTemplate = '<span class="symbol">{symbol}</span> <span class="price">{price}</span> <span class="changeValue"><span class="dir {directionClass}">{direction}</span> {change} ({percentChange})</span>';
var stockTicker = document.getElementById('stockTicker');
var stockTickerBody = stockTicker.getElementsByTagName('ul')[0];
var up = '▲';
var down = '▼';

let connection = new signalR.HubConnectionBuilder()
    .withUrl("/stocks")
    .build();

connection.start().then(function () {
    connection.invoke("GetAllStocks").then(function (stocks) {
        for (let i = 0; i < stocks.length; i++) {
            displayStock(stocks[i]);
        }
    });

    connection.invoke("GetMarketState").then(function (state) {
        if (state === 'Open') {
            marketOpened();
            startStreaming();
        } else {
            marketClosed();
        }
    });

    document.getElementById('open').onclick = function () {
        connection.invoke("OpenMarket");
    }

    document.getElementById('close').onclick = function () {
        connection.invoke("CloseMarket");
    }

    document.getElementById('reset').onclick = function () {
        connection.invoke("Reset").then(function () {
            connection.invoke("GetAllStocks").then(function (stocks) {
                for (let i = 0; i < stocks.length; ++i) {
                    displayStock(stocks[i]);
                }
            });
        });
    }
});

connection.on("marketOpened", function () {
    marketOpened();
    startStreaming();
});

connection.on("marketClosed", function () {
    marketClosed();
});

//********************
// TeeChart routines
//********************
function hideAxis(a) {
  a.format.stroke.fill = "";
  a.labels.visible = false;
  a.grid.visible = false;
  a.ticks.visible = false;
}

function cleanChart(c) {
  c.title.visible = false;
  c.panel.transparent = true;
  c.legend.visible = false;
  c.walls.back.visible = false;

  hideAxis(c.axes.left);
  hideAxis(c.axes.bottom);
}

function configPoints(chart,sidx, size) {
  chart.series.items[sidx].pointer.width = size;
  chart.series.items[sidx].pointer.height = size;
  chart.series.items[sidx].pointer.style = "ellipse";
  chart.series.items[sidx].pointer.format.stroke.size = 1;
  chart.series.items[sidx].pointer.format.shadow.visible = false;
  chart.series.items[sidx].format.stroke.size = 12;
  chart.series.items[sidx].format.shadow.visible = false;
}

function drawChart(stock) {
  var Chart1;

  // Create chart:
  Chart1 = new Tee.Chart(stock.symbol);

  // Add series:
  var seriesHL = Chart1.addSeries(new Tee.Line([Number(stock.dayHigh), Number(stock.dayLow), null]));
  seriesHL.data.x = [0, 0];

  var seriesPrice = Chart1.addSeries(new Tee.PointXY([Number(stock.price)]));
  seriesPrice.data.x = [2];
  var seriesPriceLine = Chart1.addSeries(new Tee.Line([Number(stock.price), Number(stock.price)]));
  seriesPriceLine.data.x = [0, 2];

  var seriesOpen = Chart1.addSeries(new Tee.PointXY([Number(stock.dayOpen)]));
  seriesOpen.data.x = [0];

  Chart1.series.items[0].format.stroke.size = 1;
  Chart1.series.items[0].format.shadow.visible = false;

  configPoints(Chart1, 1, 3);

  Chart1.series.items[2].format.stroke.size = 0.5;
  Chart1.series.items[2].format.shadow.visible = false;

  configPoints(Chart1, 3, 2);

  cleanChart(Chart1);

  Chart1.draw();
}
//********************

function startStreaming() {
    connection.stream("StreamStocks").subscribe({
        close: false,
        next: displayStock,
        error: function (err) {
            logger.log(err);
        }
    });
}

var pos = 30;
var tickerInterval;
stockTickerBody.style.marginLeft = '30px';

function moveTicker() {
    pos--;
    if (pos < -600) {
        pos = 500;
    }

    stockTickerBody.style.marginLeft = pos + 'px';
}

function marketOpened() {
    tickerInterval = setInterval(moveTicker, 20);
    document.getElementById('open').setAttribute("disabled", "disabled");
    document.getElementById('close').removeAttribute("disabled");
    document.getElementById('reset').setAttribute("disabled", "disabled");
}

function marketClosed() {
    if (tickerInterval) {
        clearInterval(tickerInterval);
    }
    document.getElementById('open').removeAttribute("disabled");
    document.getElementById('close').setAttribute("disabled", "disabled");
    document.getElementById('reset').removeAttribute("disabled");
}

function displayStock(stock) {
    var displayStock = formatStock(stock);
    addOrReplaceStock(stockTableBody, displayStock, 'tr', rowTemplate);
    addOrReplaceStock(stockTickerBody, displayStock, 'li', tickerTemplate);

    drawChart(stock);

}

function addOrReplaceStock(table, stock, type, template) {
    var child = createStockNode(stock, type, template);

    // try to replace
    var stockNode = document.querySelector(type + "[data-symbol=" + stock.symbol + "]");
    if (stockNode) {
        var change = stockNode.querySelector(".changeValue");
        var prevChange = parseFloat(change.childNodes[1].data);
        if (prevChange > stock.change) {
            child.className = "decrease";
        }
        else if (prevChange < stock.change) {
            child.className = "increase";
        }
        else {
            return;
        }
        table.replaceChild(child, stockNode);
    } else {
        // add new stock
        table.appendChild(child);
    }
}

function formatStock(stock) {
    stock.price = stock.price.toFixed(2);
    stock.percentChange = (stock.percentChange * 100).toFixed(2) + '%';
    stock.direction = stock.change === 0 ? '' : stock.change >= 0 ? up : down;
    stock.directionClass = stock.change === 0 ? 'even' : stock.change >= 0 ? 'up' : 'down';
    stock.photoChart = stock.photoChart;

    return stock;
}

function createStockNode(stock, type, template) {
    var child = document.createElement(type);
    child.setAttribute('data-symbol', stock.symbol);
    child.setAttribute('class', stock.symbol);
    child.innerHTML = template.supplant(stock);
    return child;
}

