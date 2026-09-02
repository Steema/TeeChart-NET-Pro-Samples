using Steema.TeeChart.Styles;

namespace TeeChart.Maui.TEST;

internal sealed record SeriesDemo(string Id, string Name, string Category, Type SeriesType);

internal static class SeriesDemoCatalog
{
    internal static readonly IReadOnlyList<SeriesDemo> All = new[]
    {
        D<Bar>("Bar", "Bar", "BÁSICAS"), D<Line>("Line", "Line", "BÁSICAS"), D<Area>("Area", "Area", "BÁSICAS"),
        D<FastLine>("FastLine", "FastLine", "BÁSICAS"), D<Points>("Point", "Point", "BÁSICAS"),
        D<LinePoint>("LinePoint", "Line + Point", "BÁSICAS"), D<HorizLine>("HorizontalLine", "Horizontal Line", "BÁSICAS"),
        D<Bezier>("Bezier", "Bezier", "BÁSICAS"),
        D<Slope>("Slope", "Slope", "BÁSICAS"), D<Arrow>("Arrow", "Arrow", "BÁSICAS"), D<Shape>("Shape", "Shape", "BÁSICAS"),

        D<HorizBar>("HorizontalBar", "Horizontal Bar", "BARRAS Y ÁREAS"), D<Bar3D>("Bar3D", "Bar 3D", "BARRAS Y ÁREAS"),
        D<BarJoin>("BarJoin", "Bar Join", "BARRAS Y ÁREAS"), D<HorizArea>("HorizontalArea", "Horizontal Area", "BARRAS Y ÁREAS"),
        D<Histogram>("Histogram", "Histogram", "BARRAS Y ÁREAS"), D<HorizHistogram>("HorizontalHistogram", "Horizontal Histogram", "BARRAS Y ÁREAS"),
        D<Equalizer>("Equalizer", "Equalizer", "BARRAS Y ÁREAS"), D<Tornado>("Tornado", "Tornado", "BARRAS Y ÁREAS"),
        D<ImageBar>("ImageBar", "Image Bar", "BARRAS Y ÁREAS"), D<RenkoBar>("RenkoBar", "Renko Bar", "BARRAS Y ÁREAS"),
        D<Funnel>("Funnel", "Funnel", "BARRAS Y ÁREAS"), D<Pyramid>("Pyramid", "Pyramid", "BARRAS Y ÁREAS"),
        D<Waterfall>("Waterfall", "Waterfall", "BARRAS Y ÁREAS"), D<VolumePipe>("VolumePipe", "Volume Pipe", "BARRAS Y ÁREAS"),

        D<Pie>("Pie", "Pie", "CIRCULARES Y POLARES"), D<Donut>("Donut", "Donut", "CIRCULARES Y POLARES"),
        D<Polar>("Polar", "Polar", "CIRCULARES Y POLARES"), D<PolarBar>("PolarBar", "Polar Bar", "CIRCULARES Y POLARES"),
        D<Rose>("Rose", "Rose", "CIRCULARES Y POLARES"), D<Radar>("Radar", "Radar", "CIRCULARES Y POLARES"),
        D<WindRose>("WindRose", "Wind Rose", "CIRCULARES Y POLARES"), D<PolarGrid>("PolarGrid", "Polar Grid", "CIRCULARES Y POLARES"),
        D<Smith>("Smith", "Smith", "CIRCULARES Y POLARES"),

        D<Candle>("Candle", "Candle", "FINANCIERAS"), D<HighLow>("HighLow", "High-Low", "FINANCIERAS"),
        D<Volume>("Volume", "Volume", "FINANCIERAS"), D<Error>("Error", "Error", "FINANCIERAS"),
        D<ErrorBar>("ErrorBar", "Error Bar", "FINANCIERAS"), D<ErrorPoint>("ErrorPoint", "Error Point", "FINANCIERAS"),
        D<ErrorPoint3D>("ErrorPoint3D", "Error Point 3D", "FINANCIERAS"), D<EquiVolume>("EquiVolume", "EquiVolume", "FINANCIERAS"),
        D<Darvas>("Darvas", "Darvas Boxes", "FINANCIERAS"), D<Kagi>("Kagi", "Kagi", "FINANCIERAS"),
        D<Renko>("Renko", "Renko", "FINANCIERAS"), D<PointFigure>("PointFigure", "Point & Figure", "FINANCIERAS"),

        D<Bubble>("Bubble", "Bubble", "ESTADÍSTICAS"), D<BubbleCloud>("BubbleCloud", "Bubble Cloud", "ESTADÍSTICAS"),
        D<Box>("Box", "Box Plot", "ESTADÍSTICAS"), D<HorizBox>("HorizBox", "Horizontal Box Plot", "ESTADÍSTICAS"),
        D<Violin>("Violin", "Violin", "ESTADÍSTICAS"), D<HorizViolin>("HorizViolin", "Horizontal Violin", "ESTADÍSTICAS"),
        D<BeeSwarm>("BeeSwarm", "Bee Swarm", "ESTADÍSTICAS"), D<HorizBeeSwarm>("HorizBeeSwarm", "Horizontal Bee Swarm", "ESTADÍSTICAS"),

        D<Gantt>("Gantt", "Gantt", "ORGANIZACIÓN Y FLUJOS"), D<Calendar>("Calendar", "Calendar", "ORGANIZACIÓN Y FLUJOS"),
        D<OrgSeries>("OrgSeries", "Organization Chart", "ORGANIZACIÓN Y FLUJOS"), D<TreeMap>("TreeMap", "Tree Map", "ORGANIZACIÓN Y FLUJOS"),
        D<SquarifiedMap>("SquarifiedMap", "Squarified Map", "ORGANIZACIÓN Y FLUJOS"), D<Sankey>("Sankey", "Sankey", "ORGANIZACIÓN Y FLUJOS"),
        D<TagCloud>("TagCloud", "Tag Cloud", "ORGANIZACIÓN Y FLUJOS"),

        D<CircularGauge>("CircularGauge", "Circular Gauge", "GAUGES E INDICADORES"), D<ActivityGauge>("ActivityGauge", "Activity Gauge", "GAUGES E INDICADORES"),
        D<Clock>("Clock", "Clock", "GAUGES E INDICADORES"), D<ClockGauge>("ClockGauge", "Clock Gauge", "GAUGES E INDICADORES"),
        D<KnobGauge>("KnobGauge", "Knob Gauge", "GAUGES E INDICADORES"), D<LinearGauge>("LinearGauge", "Linear Gauge", "GAUGES E INDICADORES"),
        D<VerticalLinearGauge>("VerticalLinearGauge", "Vertical Linear Gauge", "GAUGES E INDICADORES"),
        D<NumericGauge>("NumericGauge", "Numeric Gauge", "GAUGES E INDICADORES"), D<Gauges>("Gauges", "Multiple Gauges", "GAUGES E INDICADORES"),

        D<Points3D>("Points3D", "Points 3D", "3D, SUPERFICIES Y MAPAS"), D<Vector3D>("Vector3D", "Vector 3D", "3D, SUPERFICIES Y MAPAS"),
        D<Surface>("Surface", "Surface", "3D, SUPERFICIES Y MAPAS"), D<Contour>("Contour", "Contour", "3D, SUPERFICIES Y MAPAS"),
        D<ColorGrid>("ColorGrid", "Color Grid", "3D, SUPERFICIES Y MAPAS"), D<Tower>("Tower", "Tower", "3D, SUPERFICIES Y MAPAS"),
        D<TriSurface>("TriSurface", "Tri-Surface", "3D, SUPERFICIES Y MAPAS"), D<IsoSurface>("IsoSurface", "Iso-Surface", "3D, SUPERFICIES Y MAPAS"),
        D<Ternary>("Ternary", "Ternary", "3D, SUPERFICIES Y MAPAS"), D<Steema.TeeChart.Styles.Map>("Map", "Map", "3D, SUPERFICIES Y MAPAS"),
        D<World>("World", "World Map", "3D, SUPERFICIES Y MAPAS"), D<ImagePoint>("ImagePoint", "Image Point", "3D, SUPERFICIES Y MAPAS")
    };

    internal static SeriesDemo? Find(string id) => All.FirstOrDefault(x => x.Id == id);
    private static SeriesDemo D<T>(string id, string name, string category) where T : Series => new(id, name, category, typeof(T));
}
