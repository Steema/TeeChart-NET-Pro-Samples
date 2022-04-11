/**
 * @preserve TeeChart(tm) for JavaScript(tm)
 * @fileOverview TeeChart for JavaScript(tm)
 * v2.6 May 2020
 * Copyright(c) 2012-2020 by Steema Software SL. All Rights Reserved.
 * http://www.steema.com
 *
 * Licensed with commercial and non-commercial attributes,
 * specifically: http://www.steema.com/licensing/html5
 *
 * JavaScript is a trademark of Oracle Corporation.
 */

/**
 * @author <a href="mailto:david@steema.com">Steema Software</a>
 * @version 2.4
 */

/*global XMLHttpRequest, ActiveXObject */

/**
 * @namespace Tee.Data namespace, Multi-Dimensional Charting.
 */
//var Tee=Tee || {};

//(function() {
// "use strict";

//CDI Error: can't access lexical declaration `Chart' before initialization
/*Chart.prototype.drawReflection = function () {
  var c = this.ctx, h = this.bounds.height;

  c.scale(1, -1);
  c.translate(0, -h * 2);

  this.ondraw = null;
  this.draw();
  c.translate(0, h * 2);
  c.scale(1, -1);

  var mirrorHeight = this.canvas.height - h, y = h,
    gradient = c.createLinearGradient(0, y, 0, y + mirrorHeight),
    color = this.reflectionColor;

  gradient.addColorStop(0, colorAlpha(color, 0.5));
  gradient.addColorStop(1, colorAlpha(color, 1));
  c.fillStyle = gradient;
  c.beginPath();
  c.shadowColor = "transparent";
  c.rect(0, y, this.bounds.width, mirrorHeight);
  c.fill();

  this.ondraw = this.drawReflection;
}

function colorAlpha(color, alpha) {
  return 'rgba( ' + color[0] + ', ' + color[1] + ', ' + color[2] + ', ' + alpha + ' )';
}*/

class Theme {

  static applyTheme(c, theme) {
    if ((!theme) || (theme == ""))
      this.applyTheme("default");
    else
      if (theme == "default")
        Theme.defaultTheme(c);
      else
        if (theme == "minimal")
          Theme.minimalTheme(c);
        else
          if (theme == "excel")
            Theme.excelTheme(c);
          else
            if (theme == "dark")
              Theme.darkTheme(c);
            else
              if (theme == "twilight")
                Theme.twilightTheme(c);
              else
                if (theme == "daybreak")
                  Theme.daybreakTheme(c);
  
    c.themeName = theme;
    c.draw();
  }

  //CDI themes will probably have to live in a Theme class
  static defaultTheme(c) {

    var featureColor = "rgba(0,0,0,1)";
    var defaultStrokeColor = "rgba(39,79,105,0.8)";
    var backBlendColor = "white";
    var seriesPenColor = "white";

    c.title.format.font.style = "18px Verdana";
    c.walls.visible = true;
    c.panel.format.shadow.visible = false;
    c.panel.format.round.x = 8;
    c.panel.format.round.y = 8;
    c.panel.format.gradient.visible = true;
    c.panel.format.gradient.colors = ["rgba(224,224,224,1.0)", "white"];
    c.panel.format.gradient.direction = "diagonalup";
    c.panel.format.stroke.fill = "rgba(204,204,204,1.0)";
    c.panel.format.stroke.size = 1;

    Theme.applyPalette(c, "opera");

    if (c.series.items.length > 0) {
      for (var i = 0; i < c.series.items.length; i++) {
        c.series.items[i].format.fill = c.palette.get(i);
        if (c.series.items[i].pointer != null) {
          c.series.items[i].pointer.format.fill = c.palette.get(i);
          c.series.items[i].pointer.format.stroke.fill = backBlendColor;
        }
      }
    }

    c.axes.left.labels.format.font.setSize(11);
    c.axes.bottom.labels.format.font.setSize(11);
    c.axes.left.format.stroke.fill = defaultStrokeColor;
    c.axes.bottom.format.stroke.fill = defaultStrokeColor;
    c.axes.left.labels.format.font.fill = featureColor;
    c.axes.bottom.labels.format.font.fill = featureColor;
    c.axes.left.title.format.font.fill = featureColor;
    c.axes.left.title.format.font.setSize(20);
    c.axes.bottom.title.format.font.fill = featureColor;
    c.axes.bottom.title.format.font.setSize(20);
    c.axes.left.grid.visible = true;
    c.axes.bottom.grid.visible = false;

    c.axes.left.grid.format.stroke.size = 0.6;
    c.axes.bottom.grid.format.stroke.size = 0.6;
    c.axes.left.grid.format.stroke.fill = "silver";
    c.axes.bottom.grid.format.stroke.fill = "silver";

    c.axes.left.grid.visible = true;
    c.axes.top.grid.visible = true;
    c.axes.right.grid.visible = true;
    c.axes.bottom.grid.visible = true;

    if (c.axes.items.length > 0) {
      modCustomAxes(c, featureColor, defaultStrokeColor)
    }

    //legend
    c.legend.transparent = false;
    c.legend.format.fill = "white";
    c.legend.format.font.setSize(11);
    c.legend.format.font.fill = featureColor;
    c.legend.fontColor = false;

    //title
    c.title.format.font.fill = featureColor;

    c.walls.visible = false;
  }

  static twilightTheme(c) {

    var featureColor = "rgba(224,224,224,0.6)";
    var defaultStrokeColor = "rgba(39,79,105,0.8)";
    var backBlendColor = "rgba(82,82,82,1)";
    var seriesPenColor = "white";

    c.title.format.font.style = "18px Verdana";
    c.walls.visible = true;
    c.panel.format.shadow.visible = false;
    c.panel.format.round.x = 8;
    c.panel.format.round.y = 8;
    c.panel.format.gradient.visible = true;
    c.panel.format.gradient.colors = ["rgba(99,99,99,1.0)", "rgba(19,19,19,1.0)"];
    c.panel.format.gradient.direction = "topbottom";
    c.panel.format.stroke.fill = "rgba(204,204,204,1.0)";
    c.panel.format.stroke.size = 1;

    Theme.applyPalette(c, "redRiver");

    if (c.series.items.length > 0) {
      for (var i = 0; i < c.series.items.length; i++) {
        c.series.items[i].format.fill = c.palette.get(i);
        if (c.series.items[i].pointer != null) {
          c.series.items[i].pointer.format.fill = c.palette.get(i);
          c.series.items[i].pointer.format.stroke.fill = backBlendColor;
        }
      }
    }

    //axes
    c.axes.left.format.stroke.fill = featureColor;
    c.axes.bottom.format.stroke.fill = featureColor;
    c.axes.left.labels.format.font.setSize(11);
    c.axes.bottom.labels.format.font.setSize(11);
    c.axes.left.labels.format.font.fill = featureColor;
    c.axes.bottom.labels.format.font.fill = featureColor;
    c.axes.left.title.format.font.fill = featureColor;
    c.axes.left.title.format.font.setSize(20);
    c.axes.bottom.title.format.font.fill = featureColor;
    c.axes.bottom.title.format.font.setSize(20);
    c.axes.bottom.grid.visible = false;
    c.axes.left.grid.visible = true;
    c.axes.left.grid.format.stroke.fill = "silver";
    c.axes.bottom.grid.format.stroke.fill = "silver";

    if (c.axes.items.length > 0) {
      modCustomAxes(c, featureColor, defaultStrokeColor)
    }

    //legend
    c.legend.transparent = true;
    c.legend.format.font.setSize(14);
    c.legend.format.font.fill = featureColor;
    c.legend.format.fill = "rgba(0,0,0,0.1)";

    //title
    c.title.format.shadow.visible = false;
    var baseFontStyle = "18px Arial";
    c.title.format.font.style = baseFontStyle;
    c.title.format.font.style = "bold " + baseFontStyle;
    c.title.format.font.fill = featureColor;
    c.title.format.font.shadow.visible = false;

    c.walls.visible = false;
  }

  static daybreakTheme(c) {

    var darkContrastColor = "rgba(14,14,54,0.6)";
    var featureColor = "rgba(224,224,224,0.6)";
    var defaultStrokeColor = "rgba(39,79,105,0.8)";
    var backBlendColor = "rgba(82,82,82,1)";
    var seriesPenColor = "white";

    c.title.format.font.style = "18px Verdana";
    c.walls.visible = true;
    c.panel.format.shadow.visible = false;
    c.panel.format.round.x = 8;
    c.panel.format.round.y = 8;
    c.panel.format.gradient.visible = true;
    c.panel.format.gradient.colors = ["rgba(201,204,242,1.0)", "rgba(255,252,255,1.0)", "rgba(21,21,23,1.0)"];
    c.panel.format.gradient.direction = "topbottom";
    c.panel.format.stroke.fill = "rgba(204,204,204,1.0)";
    c.panel.format.stroke.size = 1;

    Theme.applyPalette(c, "redRiver");

    if (c.series.items.length > 0) {
      for (var i = 0; i < c.series.items.length; i++) {
        c.series.items[i].format.fill = c.palette.get(i);
        if (c.series.items[i].pointer != null) {
          c.series.items[i].pointer.format.fill = c.palette.get(i);
          c.series.items[i].pointer.format.stroke.fill = backBlendColor;
        }
      }
    }

    //axes
    for (var i = 0; i < c.axes.items.length; i++) {
      var a = c.axes.items[i];
      a.format.stroke.fill = darkContrastColor;
      a.labels.format.font.setSize(11);
      a.labels.format.font.fill = featureColor;
      a.title.format.font.setSize(20);
      a.title.format.font.fill = featureColor;
      a.grid.visible = i < 3;
      a.grid.format.stroke.fill = "silver";
    }

    //legend
    c.legend.transparent = true;
    c.legend.format.font.setSize(14);
    c.legend.format.font.fill = "silver";

    //title
    c.title.format.shadow.visible = false;
    var baseFontStyle = "18px Arial";
    c.title.format.font.style = baseFontStyle;
    c.title.format.font.style = "bold " + baseFontStyle;
    c.title.format.font.fill = darkContrastColor;
    c.title.format.font.shadow.visible = false;

    c.walls.visible = false;
  }

  static minimalTheme(c) {
    //designed with white background in mind
    c.title.transparent = true;
    c.walls.visible = false;
    c.footer.transparent = true;
    c.panel.format.shadow.visible = false;
    c.panel.format.stroke.fill = "";
    c.panel.format.round.x = 0;
    c.panel.format.round.y = 0;
    c.panel.format.gradient.visible = false;
    c.panel.format.fill = "white";

    var featureColor = "rgba(124,124,144,0.9)";
    var defaultStrokeColor = "rgba(39,79,105,0.8)";
    var invisibleStrokeColor = "rgba(0,0,0,0.0)";
    var backBlendColor = "white";
    var seriesPenColor = "white";

    Theme.applyPalette(c, "seaWash");

    if (c.series.items.length > 0) {
      for (var i = 0; i < c.series.items.length; i++) {
        c.series.items[i].format.fill = c.palette.get(i);
        if ((c.series.items[i].pointer != null) && (c.series.items[i].pointer.format != null)) {
          c.series.items[i].pointer.format.fill = c.palette.get(i);
          c.series.items[i].pointer.format.stroke.fill = backBlendColor;
        }
      }
    }

    //axes
    for (var i = 0; i < c.axes.items.length; i++) {
      var a = c.axes.items[i];
      a.format.stroke.fill = defaultStrokeColor;
      a.labels.format.font.setSize(14);
      a.labels.format.font.fill = featureColor;
      a.title.format.font.setSize(20);
      a.title.format.font.fill = featureColor;
    }

    for (i = 0; i < c.axes.items.length; i++) {

      if (!c.axes.items[i].horizontal) {
        c.axes.items[i].grid.visible = true;
        c.axes.items[i].grid.format.stroke.size = 0.6;
        c.axes.items[i].grid.format.stroke.fill = "silver";

      }
      else {
        c.axes.items[i].grid.visible = false;
        c.axes.items[i].grid.format.stroke.size = 0.6;
        c.axes.items[i].grid.format.stroke.fill = "silver";
      }
    }


    //legend
    c.legend.transparent = true;
    c.legend.format.font.setSize(14);
    c.legend.format.font.fill = featureColor;

    //title
    c.title.format.shadow.visible = false;
    var baseFontStyle = "18px Arial";
    c.title.format.font.style = baseFontStyle;
    c.title.format.font.style = "bold " + baseFontStyle;
    c.title.format.font.fill = featureColor;
    c.title.format.font.shadow.visible = false;

  }

  static excelTheme(c) {

    minimalTheme(c);

    var featureColor = "rgba(0,0,0,0.9)";
    var defaultStrokeColor = "rgba(39,79,105,0.8)";
    var backBlendColor = "white";
    var seriesPenColor = "white";

    Theme.applyPalette(c, "excel");

    c.axes.left.grid.format.stroke.fill = featureColor;
    c.axes.bottom.grid.format.stroke.fill = featureColor;

    if (c.series.items.length > 0) {
      for (var i = 0; i < c.series.items.length; i++) {
        c.series.items[i].format.fill = c.palette.get(i);
        if (c.series.items[i].pointer != null) {
          c.series.items[i].pointer.format.fill = c.palette.get(i);
          c.series.items[i].pointer.format.stroke.fill = backBlendColor;
        }
      }
    }
  }

  static darkTheme(c) {

    Theme.applyPalette(c, "onBlack");

    var featureColor = "rgba(224,224,224,0.6)";
    var defaultStrokeColor = "rgba(39,79,105,0.8)";
    var backBlendColor = "rgba(82,82,82,1)";
    var seriesPenColor = "white";

    c.title.transparent = true;
    c.legend.transparent = true;
    c.footer.transparent = true;

    //panel
    c.panel.format.shadow.visible = false;
    c.panel.format.stroke.fill = "";
    c.panel.format.round.x = 0;
    c.panel.format.round.y = 0;
    c.panel.format.gradient.colors = ["rgba(0,0,0,1)", "rgba(0,0,0,1)"];
    c.panel.format.gradient.visible = true;

    if (c.series.items.length > 0) {
      for (var i = 0; i < c.series.items.length; i++) {
        c.series.items[i].format.fill = c.palette.get(i);
        if (c.series.items[i].pointer != null) {
          c.series.items[i].pointer.format.fill = c.palette.get(i);
          c.series.items[i].pointer.format.stroke.fill = backBlendColor;
        }
      }
    }

    //axes
    c.axes.left.format.stroke.fill = featureColor; //defaultStrokeColor;
    c.axes.bottom.format.stroke.fill = featureColor; //defaultStrokeColor;
    c.axes.left.labels.format.font.setSize(14);
    c.axes.bottom.labels.format.font.setSize(14);
    c.axes.left.labels.format.font.fill = featureColor;
    c.axes.bottom.labels.format.font.fill = featureColor;
    c.axes.left.title.format.font.fill = featureColor;
    c.axes.left.title.format.font.setSize(20);
    c.axes.bottom.title.format.font.fill = featureColor;
    c.axes.bottom.title.format.font.setSize(20);
    c.axes.bottom.grid.visible = false;
    c.axes.left.grid.visible = true;
    c.axes.left.grid.format.stroke.fill = "silver";
    c.axes.bottom.grid.format.stroke.fill = "silver";

    if (c.axes.items.length > 0) {
      Theme.modCustomAxes(c, featureColor, defaultStrokeColor)
    }

    //walls
    c.walls.visible = false;

    //legend
    c.legend.transparent = true;
    c.legend.format.font.setSize(14);
    c.legend.format.font.fill = featureColor;

    //title
    c.title.format.shadow.visible = false;
    var baseFontStyle = "18px Arial";
    c.title.format.font.style = baseFontStyle;
    c.title.format.font.style = "bold " + baseFontStyle;
    c.title.format.font.fill = featureColor;
    c.title.format.font.shadow.visible = false;
  }

  static applyPalette(c, paletteName) {

    //default (Opera)
    var colorList = ["#4466a3", "#f39c35", "#f14c14", "#4e97a8", "#2b406b",
      "#1d7b63", "#b3080e", "#f2c05d", "#5db79e", "#707070",
      "#f3ea8d", "#b4b4b4"];

    if (paletteName == "castaway")
      colorList = ["#4466a3", "#E8D0A9", "#B7AFA3", "#C1DAD6", "#F5FAFA", "#ACD1E9", "#6D929B"];
    else
      if (paletteName == "classic")
        colorList = ["#0000FF", "#00FF00", "#00FFFF", "#FF0000", "#FF00FF", "#FFFF00", "#000080",
          "#008000", "#008080", "#800000", "#808000", "#808080"];
      else
        if (paletteName == "cool")
          colorList = ["rgba(43,64,107,1.0)", "rgba(59,84,140,1.0)", "rgba(68,102,163,1.0)",
            "rgba(78,151,168,1.0)", "rgba(93,183,158,1.0)", "rgba(65,160,138,1.0)",
            "rgba(43,146,125,1.0)", "rgba(29,123,99)"];
        else
          if (paletteName == "excel")
            colorList = ["#FF9999", "#663399", "#CCFFFF", "#FFFFCC", "#660066", "#8080FF", "#CC6600",
              "#FFCCCC", "#800000", "#FF00FF", "#00FFFF", "#FFFF00", "#800080", "#000080",
              "#808000", "#FF0000", "#FFCC00", "#FFFFCC", "#CCFFCC", "#00FFFF", "#FFCC99",
              "#CC99FF"];
          else
            if (paletteName == "grayscale")
              colorList = ["#F0F0F0", "#E0E0E0", "#D0D0D0", "#C0C0C0", "#B0B0B0", "#A0A0A0", "#909090",
                "#808080", "#707070", "#606060", "#505050", "#404040", "#303030", "#202020",
                "#101010"];
            else
              if (paletteName == "macOS")
                colorList = ["#FFFFFF", "#FCF305", "#FF6402", "#DD0806", "#F20884", "#4600A5", "#0000D4",
                  "#02ABEA", "#1FB714", "#006411", "#562C05", "#90713A", "#C0C0C0", "#808080",
                  "#404040", "#000000"];
              else
                if (paletteName == "modern")
                  colorList = ["#FF9966", "#FF6666", "#99CCFF", "#669966", "#CCCC99", "#9966CC", "#CC6666",
                    "#FFCC99", "#9966FF", "#CCCCCC", "#66FFCC", "#6699FF", "#996699", "#CCCCFF"];
                else
                  if (paletteName == "onBlack")
                    colorList = ["rgba(200,230,90,1.0)", "rgba(90,150,220,1.0)", "rgba(230,90,40,1.0)",
                      "rgba(230,160,15)"];
                  else
                    if (paletteName == "opera")
                      colorList = colorList; //do nothing, Opera is default.
                    else
                      if (paletteName == "pastels")
                        colorList = ["#CCFFFF", "#FFFFCC", "#CCCCFF", "#00CCCC", "#CCCCCC", "#009999", "#999999",
                          "#DDCCCC", "#FFCC66", "#CCCCFF", "#FF9999", "#FFFF99", "#99CCFF", "#CCFFCC"];
                      else
                        if (paletteName == "rainbow")
                          colorList = ["#FF0000", "#FF7F00", "#FFFF00", "#00FF00", "#0000FF", "#6600FF", "#8B00FF"]
                        else
                          if (paletteName == "redRiver")
                            colorList = ["#DC5C05", "#FFC519", "#6EC5B8", "#FF9000", "#978B7D", "#C7BAA7"];  //#FFAC00
                          else
                            if (paletteName == "rust")
                              colorList = ["#CBFFFA", "#7F3D17", "#7F5E17", "#22287F", "#DD1E2F", "#EBB035", "#06A2CB",
                                "#218559", "#D0C6B1", "#B67721", "#68819E", "#747E80", "#D5E1DD", "#F7F3E8",
                                "#F2583E", "#77BED2"];
                            else
                              if (paletteName == "seaWash")
                                colorList = ["#DC5C05", "#FFAC00", "#6EC5B8", "#E8D0A9", "#978B7D", "#C7BAA7", "#C1DAD6",
                                  "#FFC99F", "#ACD1E9", "#6D929B", "#D3E397", "#FFF5C3"];
                              else
                                if (paletteName == "solid")
                                  colorList = ["#0000FF", "#FF0000", "#00FF00", "#FFCC00", "#404040", "#FFFF00", "#FF00C0",
                                    "#FFFFFF"];
                                else
                                  if (paletteName == "teechart")
                                    colorList = ["rgba(255,0,0,1.0)", "rgba(0,128,0,1.0)", "rgba(255,255,0,1.0)", "rgba(0,0,255,1.0)",
                                      "rgba(255,255,255,1.0)", "rgba(128,128,128,1.0)", "rgba(255,0,255,1.0)",
                                      "rgba(0,128,128,1.0)", "rgba(0,0,128,1.0)", "rgba(128,0,0,1.0)", "rgba(0,255,0,1.0)",
                                      "rgba(128,128,0,1.0)", "rgba(128,0,128,1.0)", "rgba(192,192,192,1.0)",
                                      "rgba(0,255,255,1.0)", "rgba(0,0,0,1.0)", "rgba(173,255,47,1.0)", "rgba(135,206,235,1.0)",
                                      "rgba(255,228,196,1.0)", "rgba(75,0,130,1.0)"];
                                  else
                                    if (paletteName == "warm")
                                      colorList = ["rgba(243,234,141,1.0)", "rgba(242,192,93,1.0)", "rgba(243,156,53,1.0)",
                                        "rgba(245,129,28,1.0)", "rgba(243,107,21,1.0)", "rgba(241,76,20,1.0)",
                                        "rgba(230,24,10,1.0)", "rgba(179,8,14)"];
                                    else
                                      if (paletteName == "web")
                                        colorList = ["#FFA500", "#0000CE", "#00CE00", "#FFFF40", "#40FFFF", "#FF40FF", "#FF4000",
                                          "#8080A5", "#808040"];
                                      else
                                        if (paletteName == "rainbowWide")
                                          colorList = ["#990000", "#C30000", "#EE0000", "#FF1A00", "#FF4600", "#FF7300", "#FF9F00",
                                            "#FFCB00", "#FFF700", "#E3F408", "#C3E711", "#A3DA1B", "#83CD25", "#63C02E",
                                            "#42B338", "#22A642", "#029A4B", "#0C876A", "#1A758A", "#2863AA", "#3650CB",
                                            "#443EEB", "#612AFF", "#9615FF", "#CC00FF"];
                                        else
                                          if (paletteName == "windowsVista")
                                            colorList = ["#001FD2", "#E00201", "#1E6602", "#E8CD7E", "#AFABAC", "#A4D0D9", "#3D3B3C",
                                              "#95DD31", "#9E0001", "#DCF774", "#45FDFD", "#D18E74", "#A0D891", "#D57A65",
                                              "#9695D9"];
                                          else
                                            if (paletteName == "windowsxp")
                                              colorList = ["rgba(130,155,254,1.0)", "rgba(252,209,36,1.0)", "rgba(124,188,13,1.0)", "rgba(253,133,47,1.0)",
                                                "rgba(253,254,252,1.0)", "rgba(226,78,33,1.0)", "rgba(41,56,214,1.0)", "rgba(183,148,0,1.0)",
                                                "rgba(90,134,0,1.0)", "rgba(210,70,0,1.0)", "rgba(211,229,250,1.0)", "rgba(216,216,216,1.0)",
                                                "rgba(95,113,123,1.0)"];
                                            else
                                              if (paletteName == "victorian")
                                                colorList = ["#5DA5A1", "#C45331", "#E79609", "#F6E84A", "#B1A2A7", "#C9A784", "#8C7951",
                                                  "#D8CDB7", "#086553", "#F7D87B", "#016484"];


    c.paletteName = paletteName;
    c.palette.colors = colorList;

    if (c.series.items.length > 0) {
      for (var i = 0; i < c.series.items.length; i++) {
        c.series.items[i].format.fill = c.palette.get(i);
        if ((c.series.items[i].pointer != null) && (c.series.items[i].pointer.format != null)) {
          c.series.items[i].pointer.format.fill = c.palette.get(i);
        }
      }
    }

    c.draw();
  }

  static modCustomAxes(c, featureColor, defaultStrokeColor) {
    for (var i = 0; i < c.axes.items.length; i++) {
      if (i > 3) {
        c.axes.items[i].labels.format.font.setSize(11);
        c.axes.items[i].format.stroke.fill = defaultStrokeColor;
        c.axes.items[i].labels.format.font.fill = featureColor;
        c.axes.items[i].title.format.font.fill = featureColor;
        c.axes.items[i].title.format.font.setSize(20);
        c.axes.items[i].grid.visible = false;
        c.axes.items[i].grid.format.stroke.size = 0.6;
        c.axes.items[i].grid.format.stroke.fill = "silver";
      }
    }
  }

}

//CDI these two functions will have to be housed somewhere
/*
function makeHttpObject() {
  try { return new XMLHttpRequest(); }
  catch (error) { }
  try { return new ActiveXObject("Msxml2.XMLHTTP"); }
  catch (error) { }
  try { return new ActiveXObject("Microsoft.XMLHTTP"); }
  catch (error) { }

  throw new Error("Could not create HTTP request object.");
}

doHttpRequest = function (target, url, success, failure) {
  var request = makeHttpObject();
  if (request) {
    request.onreadystatechange = function () {
      if (request.readyState == 4) {
        if ((request.status === 200) || (request.status === 0))
          success(target, request.responseText);
        else
          if (failure)
            failure(request.status, request.statusText);
      }
    };
    request.open("GET", url, true);
    request.send(null);
  }
}*/

//Slider.prototype=new Tool();

//Scroller.prototype=new Chart();

/*SliderControl = function (canvas) {
  var tmp = new Chart(canvas);
  tmp.panel.transparent = true;
  tmp.title.visible = false;

  var s = new Slider(tmp);

  s.bounds.x = s.thumbSize + 1;
  s.bounds.width = tmp.canvas.width - 2 * s.thumbSize - 2;
  s.bounds.y = (tmp.canvas.height - s.bounds.height) * 0.5;

  tmp.tools.add(s);
  return s;
}*/

//CheckBox.prototype=new Annotation();

//}).call(this);

export { Theme };
