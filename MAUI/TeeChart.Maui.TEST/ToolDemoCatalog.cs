namespace TeeChart.Maui.TEST;

internal sealed record ToolDemo(string Id, string Name, string Category, string TypeName, string SeriesType, string Description);

internal static class ToolDemoCatalog
{
    // This list mirrors the tools linked by the .NET 10 Headless target.  Keeping
    // the catalog data-only makes it easy to add a new tool without changing the UI.
    internal static readonly IReadOnlyList<ToolDemo> All = new[]
    {
        T("Annotation", "Annotation", "ANOTACIONES", "Annotation", "Line", "Texto contextual dentro del área del gráfico."),
        T("BannerTool", "Banner", "ANOTACIONES", "BannerTool", "Bar", "Aviso destacado para estados o mensajes del dashboard."),
        T("PageNumber", "Page number", "ANOTACIONES", "PageNumber", "Line", "Numeración de páginas para informes y exportaciones."),
        T("RectangleTool", "Rectangle", "ANOTACIONES", "RectangleTool", "Line", "Selección rectangular sobre una serie temporal."),
        T("DrawLine", "Draw line", "ANOTACIONES", "DrawLine", "Line", "Líneas de referencia dibujadas sobre el gráfico."),
        T("FibonacciTool", "Fibonacci", "ANOTACIONES", "FibonacciTool", "Candle", "Niveles de retroceso para análisis financiero."),

        T("AxisArrow", "Axis arrow", "EJES Y GUÍAS", "AxisArrow", "Line", "Flecha de desplazamiento asociada a un eje."),
        T("AxisBreaksTool", "Axis breaks", "EJES Y GUÍAS", "AxisBreaksTool", "Line", "Rupturas para omitir intervalos sin datos."),
        T("AxisScroll", "Axis scroll", "EJES Y GUÍAS", "AxisScroll", "Line", "Desplazamiento del rango visible del eje."),
        T("ColorBand", "Color band", "EJES Y GUÍAS", "ColorBand", "Line", "Banda coloreada para destacar un umbral."),
        T("ColorLine", "Color line", "EJES Y GUÍAS", "ColorLine", "Line", "Línea de objetivo o umbral sobre el eje."),
        T("GridBand", "Grid band", "EJES Y GUÍAS", "GridBand", "Bar", "Bandas alternas para facilitar la lectura de filas."),
        T("CycleLines", "Cycle lines", "EJES Y GUÍAS", "CycleLines", "Line", "Líneas cíclicas para periodos repetitivos."),
        T("GridTranspose", "Grid transpose", "EJES Y GUÍAS", "GridTranspose", "ColorGrid", "Intercambio de filas y columnas de una rejilla."),

        T("CursorTool", "Cursor", "INTERACCIÓN Y ANÁLISIS", "CursorTool", "Line", "Cursor vertical para inspeccionar un instante."),
        T("NearestPoint", "Nearest point", "INTERACCIÓN Y ANÁLISIS", "NearestPoint", "Point", "Resalta el punto más cercano al cursor."),
        T("MarksTip", "Marks tip", "INTERACCIÓN Y ANÁLISIS", "MarksTip", "Line", "Tooltip con el valor de la marca seleccionada."),
        T("SeriesStats", "Series statistics", "INTERACCIÓN Y ANÁLISIS", "SeriesStats", "Line", "Resumen estadístico de la serie activa."),
        T("SeriesRegionTool", "Series region", "INTERACCIÓN Y ANÁLISIS", "SeriesRegionTool", "Line", "Región seleccionable alrededor de una serie."),
        T("SeriesBandTool", "Series band", "INTERACCIÓN Y ANÁLISIS", "SeriesBandTool", "Line", "Banda de tolerancia vinculada a una serie."),
        T("SurfaceNearestTool", "Surface nearest", "INTERACCIÓN Y ANÁLISIS", "SurfaceNearestTool", "Surface", "Celda más cercana en una superficie 3D."),
        T("DragPoint", "Drag point", "INTERACCIÓN Y ANÁLISIS", "DragPoint", "Point", "Edición directa de puntos arrastrándolos."),
        T("DragMarks", "Drag marks", "INTERACCIÓN Y ANÁLISIS", "DragMarks", "Line", "Recolocación manual de las etiquetas."),
        T("Selector", "Selector", "INTERACCIÓN Y ANÁLISIS", "Selector", "Bar", "Selección de partes del chart y sus manejadores."),
        T("SeriesAnimation", "Series animation", "INTERACCIÓN Y ANÁLISIS", "SeriesAnimation", "Area", "Entrada animada de los valores de la serie."),

        T("DataTableTool", "Data table", "DATOS Y LEYENDA", "DataTableTool", "Bar", "Tabla de datos vinculada al gráfico."),
        T("ExtraLegend", "Extra legend", "DATOS Y LEYENDA", "ExtraLegend", "Line", "Leyenda secundaria para series o indicadores."),
        T("LegendPalette", "Legend palette", "DATOS Y LEYENDA", "LegendPalette", "Bar", "Paleta interactiva desde la leyenda."),
        T("LegendScrollBar", "Legend scrollbar", "DATOS Y LEYENDA", "LegendScrollBar", "Bar", "Desplazamiento de una leyenda extensa."),
        T("PieTool", "Pie slice", "DATOS Y LEYENDA", "PieTool", "Pie", "Enfoque y separación de sectores del pie."),

        T("GanttTool", "Gantt drag", "ORGANIZACIÓN", "GanttTool", "Gantt", "Edición de tareas y duración en un Gantt."),
        T("SubChartTool", "Sub-chart", "ORGANIZACIÓN", "SubChartTool", "Bar", "Regiones secundarias con gráficos anidados."),
        T("ChartImage", "Chart image", "EXPORTACIÓN Y VISTA", "ChartImage", "Line", "Imagen asociada a una serie o punto."),
        T("ClipSeries", "Clip series", "EXPORTACIÓN Y VISTA", "ClipSeries", "Area", "Recorte de la serie al área visible."),
        T("FullScreenTool", "Full screen", "EXPORTACIÓN Y VISTA", "FullScreenTool", "Bar", "Alterna la vista del gráfico a pantalla completa."),
        T("Rotate", "Rotate 3D", "EXPORTACIÓN Y VISTA", "Rotate", "Tower", "Rotación interactiva de una serie Tower 3D."),
        T("ScrollBar", "Scroll bar", "EXPORTACIÓN Y VISTA", "ScrollBar", "Line", "Barra de desplazamiento del rango de datos."),
        T("ScrollPager", "Scroll pager", "EXPORTACIÓN Y VISTA", "ScrollPager", "Line", "Paginación de una serie larga."),
        T("SeriesTranspose", "Series transpose", "EXPORTACIÓN Y VISTA", "SeriesTranspose", "Bar", "Cambia la orientación de la serie."),
        T("CustomHotspot", "Custom hotspot", "MAPAS Y HOTSPOTS", "CustomHotspot", "Line", "Zonas personalizadas sensibles al puntero."),
        T("SeriesHotspot", "Series hotspot", "MAPAS Y HOTSPOTS", "SeriesHotspot", "Line", "Puntos de serie sensibles al puntero."),
    };

    internal static ToolDemo? Find(string id) => All.FirstOrDefault(x => x.Id == id);

    private static ToolDemo T(string id, string name, string category, string typeName, string seriesType, string description) =>
        new(id, name, category, typeName, seriesType, description);
}
