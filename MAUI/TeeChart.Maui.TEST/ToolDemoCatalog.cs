namespace TeeChart.Maui.TEST;

internal sealed record ToolDemo(string Id, string Name, string Category, string TypeName, string SeriesType, string Description);

internal static class ToolDemoCatalog
{
    // This list mirrors the tools linked by the .NET 10 Headless target.  Keeping
    // the catalog data-only makes it easy to add a new tool without changing the UI.
    internal static readonly IReadOnlyList<ToolDemo> All = new[]
    {
        T("Annotation", "Annotation", "ANNOTATIONS", "Annotation", "Line", "Contextual text inside the chart area."),
        T("BannerTool", "Banner", "ANNOTATIONS", "BannerTool", "Bar", "Highlighted notice for dashboard states or messages."),
        T("PageNumber", "Page number", "ANNOTATIONS", "PageNumber", "Line", "Page numbering for reports and exports."),
        T("RectangleTool", "Rectangle", "ANNOTATIONS", "RectangleTool", "Line", "Rectangular selection over a time series."),
        T("DrawLine", "Draw line", "ANNOTATIONS", "DrawLine", "Line", "Reference lines drawn over the chart."),
        T("FibonacciTool", "Fibonacci", "ANNOTATIONS", "FibonacciTool", "Candle", "Retracement levels for financial analysis."),

        T("AxisArrow", "Axis arrow", "AXES & GUIDES", "AxisArrow", "Line", "Scroll arrow associated with an axis."),
        T("AxisBreaksTool", "Axis breaks", "AXES & GUIDES", "AxisBreaksTool", "Line", "Breaks that omit intervals without data."),
        T("AxisScroll", "Axis scroll", "AXES & GUIDES", "AxisScroll", "Line", "Scroll the visible axis range."),
        T("ColorBand", "Color band", "AXES & GUIDES", "ColorBand", "Line", "Colored band that highlights a threshold."),
        T("ColorLine", "Color line", "AXES & GUIDES", "ColorLine", "Line", "Target or threshold line on the axis."),
        T("GridBand", "Grid band", "AXES & GUIDES", "GridBand", "Bar", "Alternating bands that improve row readability."),
        T("CycleLines", "Cycle lines", "AXES & GUIDES", "CycleLines", "Line", "Cyclic lines for recurring periods."),
        T("GridTranspose", "Grid transpose", "AXES & GUIDES", "GridTranspose", "ColorGrid", "Swap the rows and columns of a grid."),

        T("CursorTool", "Cursor", "INTERACTION & ANALYSIS", "CursorTool", "Line", "Vertical cursor for inspecting a point in time."),
        T("NearestPoint", "Nearest point", "INTERACTION & ANALYSIS", "NearestPoint", "Point", "Highlights the point nearest to the cursor."),
        T("MarksTip", "Marks tip", "INTERACTION & ANALYSIS", "MarksTip", "Line", "Tooltip with the selected mark's value."),
        T("SeriesStats", "Series statistics", "INTERACTION & ANALYSIS", "SeriesStats", "Line", "Statistical summary of the active series."),
        T("SeriesRegionTool", "Series region", "INTERACTION & ANALYSIS", "SeriesRegionTool", "Line", "Selectable region around a series."),
        T("SeriesBandTool", "Series band", "INTERACTION & ANALYSIS", "SeriesBandTool", "Line", "Tolerance band linked to a series."),
        T("SurfaceNearestTool", "Surface nearest", "INTERACTION & ANALYSIS", "SurfaceNearestTool", "Surface", "Nearest cell on a 3D surface."),
        T("DragPoint", "Drag point", "INTERACTION & ANALYSIS", "DragPoint", "Point", "Directly edit points by dragging them."),
        T("DragMarks", "Drag marks", "INTERACTION & ANALYSIS", "DragMarks", "Line", "Manually reposition labels."),
        T("Selector", "Selector", "INTERACTION & ANALYSIS", "Selector", "Bar", "Select chart elements and their handles."),
        T("SeriesAnimation", "Series animation", "INTERACTION & ANALYSIS", "SeriesAnimation", "Area", "Animated entrance of series values."),

        T("DataTableTool", "Data table", "DATA & LEGEND", "DataTableTool", "Bar", "Data table linked to the chart."),
        T("ExtraLegend", "Extra legend", "DATA & LEGEND", "ExtraLegend", "Line", "Secondary legend for series or indicators."),
        T("LegendPalette", "Legend palette", "DATA & LEGEND", "LegendPalette", "Bar", "Interactive palette from the legend."),
        T("LegendScrollBar", "Legend scrollbar", "DATA & LEGEND", "LegendScrollBar", "Bar", "Scroll an extensive legend."),
        T("PieTool", "Pie slice", "DATA & LEGEND", "PieTool", "Pie", "Focus and explode pie sectors."),

        T("GanttTool", "Gantt drag", "ORGANIZATION", "GanttTool", "Gantt", "Edit tasks and duration in a Gantt chart."),
        T("SubChartTool", "Sub-chart", "ORGANIZATION", "SubChartTool", "Bar", "Secondary regions with nested charts."),
        T("ChartImage", "Chart image", "EXPORT & VIEW", "ChartImage", "Line", "Image associated with a series or point."),
        T("ClipSeries", "Clip series", "EXPORT & VIEW", "ClipSeries", "Area", "Clip the series to the visible area."),
        T("FullScreenTool", "Full screen", "EXPORT & VIEW", "FullScreenTool", "Bar", "Toggle the chart into full-screen view."),
        T("Rotate", "Rotate 3D", "EXPORT & VIEW", "Rotate", "Tower", "Interactively rotate a 3D Tower series."),
        T("ScrollBar", "Scroll bar", "EXPORT & VIEW", "ScrollBar", "Line", "Scroll the data range."),
        T("ScrollPager", "Scroll pager", "EXPORT & VIEW", "ScrollPager", "Line", "Page through a long series."),
        T("SeriesTranspose", "Series transpose", "EXPORT & VIEW", "SeriesTranspose", "Bar", "Change the series orientation."),
        T("CustomHotspot", "Custom hotspot", "MAPS & HOTSPOTS", "CustomHotspot", "Line", "Custom pointer-sensitive areas."),
        T("SeriesHotspot", "Series hotspot", "MAPS & HOTSPOTS", "SeriesHotspot", "Line", "Pointer-sensitive series points."),
    };

    internal static ToolDemo? Find(string id) => All.FirstOrDefault(x => x.Id == id);

    private static ToolDemo T(string id, string name, string category, string typeName, string seriesType, string description) =>
        new(id, name, category, typeName, seriesType, description);
}
