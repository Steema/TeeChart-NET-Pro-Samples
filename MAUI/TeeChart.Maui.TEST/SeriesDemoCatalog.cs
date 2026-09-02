using Steema.TeeChart.Styles;

namespace TeeChart.Maui.TEST;

internal sealed record SeriesDemo(string Id, string Name, string Category, Type SeriesType);

internal static class SeriesDemoCatalog
{
    internal static readonly IReadOnlyList<SeriesDemo> All = new[]
    {
        D<Bar>("Bar", "Bar", "BASIC"), D<Line>("Line", "Line", "BASIC"), D<Area>("Area", "Area", "BASIC"),
        D<FastLine>("FastLine", "FastLine", "BASIC"), D<Points>("Point", "Point", "BASIC"),
        D<LinePoint>("LinePoint", "Line + Point", "BASIC"), D<HorizLine>("HorizontalLine", "Horizontal Line", "BASIC"),
        D<Bezier>("Bezier", "Bezier", "BASIC"),
        D<Slope>("Slope", "Slope", "BASIC"), D<Arrow>("Arrow", "Arrow", "BASIC"), D<Shape>("Shape", "Shape", "BASIC"),

        D<HorizBar>("HorizontalBar", "Horizontal Bar", "BARS & AREAS"), D<Bar3D>("Bar3D", "Bar 3D", "BARS & AREAS"),
        D<BarJoin>("BarJoin", "Bar Join", "BARS & AREAS"), D<HorizArea>("HorizontalArea", "Horizontal Area", "BARS & AREAS"),
        D<Histogram>("Histogram", "Histogram", "BARS & AREAS"), D<HorizHistogram>("HorizontalHistogram", "Horizontal Histogram", "BARS & AREAS"),
        D<Equalizer>("Equalizer", "Equalizer", "BARS & AREAS"), D<Tornado>("Tornado", "Tornado", "BARS & AREAS"),
        D<ImageBar>("ImageBar", "Image Bar", "BARS & AREAS"), D<RenkoBar>("RenkoBar", "Renko Bar", "BARS & AREAS"),
        D<Funnel>("Funnel", "Funnel", "BARS & AREAS"), D<Pyramid>("Pyramid", "Pyramid", "BARS & AREAS"),
        D<Waterfall>("Waterfall", "Waterfall", "BARS & AREAS"), D<VolumePipe>("VolumePipe", "Volume Pipe", "BARS & AREAS"),

        D<Pie>("Pie", "Pie", "CIRCULAR & POLAR"), D<Donut>("Donut", "Donut", "CIRCULAR & POLAR"),
        D<Polar>("Polar", "Polar", "CIRCULAR & POLAR"), D<PolarBar>("PolarBar", "Polar Bar", "CIRCULAR & POLAR"),
        D<Rose>("Rose", "Rose", "CIRCULAR & POLAR"), D<Radar>("Radar", "Radar", "CIRCULAR & POLAR"),
        D<WindRose>("WindRose", "Wind Rose", "CIRCULAR & POLAR"), D<PolarGrid>("PolarGrid", "Polar Grid", "CIRCULAR & POLAR"),
        D<Smith>("Smith", "Smith", "CIRCULAR & POLAR"),

        D<Candle>("Candle", "Candle", "FINANCIAL"), D<HighLow>("HighLow", "High-Low", "FINANCIAL"),
        D<Volume>("Volume", "Volume", "FINANCIAL"), D<Error>("Error", "Error", "FINANCIAL"),
        D<ErrorBar>("ErrorBar", "Error Bar", "FINANCIAL"), D<ErrorPoint>("ErrorPoint", "Error Point", "FINANCIAL"),
        D<ErrorPoint3D>("ErrorPoint3D", "Error Point 3D", "FINANCIAL"), D<EquiVolume>("EquiVolume", "EquiVolume", "FINANCIAL"),
        D<Darvas>("Darvas", "Darvas Boxes", "FINANCIAL"), D<Kagi>("Kagi", "Kagi", "FINANCIAL"),
        D<Renko>("Renko", "Renko", "FINANCIAL"), D<PointFigure>("PointFigure", "Point & Figure", "FINANCIAL"),

        D<Bubble>("Bubble", "Bubble", "STATISTICS"), D<BubbleCloud>("BubbleCloud", "Bubble Cloud", "STATISTICS"),
        D<Box>("Box", "Box Plot", "STATISTICS"), D<HorizBox>("HorizBox", "Horizontal Box Plot", "STATISTICS"),
        D<Violin>("Violin", "Violin", "STATISTICS"), D<HorizViolin>("HorizViolin", "Horizontal Violin", "STATISTICS"),
        D<BeeSwarm>("BeeSwarm", "Bee Swarm", "STATISTICS"), D<HorizBeeSwarm>("HorizBeeSwarm", "Horizontal Bee Swarm", "STATISTICS"),

        D<Gantt>("Gantt", "Gantt", "ORGANIZATION & FLOWS"), D<Calendar>("Calendar", "Calendar", "ORGANIZATION & FLOWS"),
        D<OrgSeries>("OrgSeries", "Organization Chart", "ORGANIZATION & FLOWS"), D<TreeMap>("TreeMap", "Tree Map", "ORGANIZATION & FLOWS"),
        D<SquarifiedMap>("SquarifiedMap", "Squarified Map", "ORGANIZATION & FLOWS"), D<Sankey>("Sankey", "Sankey", "ORGANIZATION & FLOWS"),
        D<TagCloud>("TagCloud", "Tag Cloud", "ORGANIZATION & FLOWS"),

        D<CircularGauge>("CircularGauge", "Circular Gauge", "GAUGES & INDICATORS"), D<ActivityGauge>("ActivityGauge", "Activity Gauge", "GAUGES & INDICATORS"),
        D<Clock>("Clock", "Clock", "GAUGES & INDICATORS"), D<ClockGauge>("ClockGauge", "Clock Gauge", "GAUGES & INDICATORS"),
        D<KnobGauge>("KnobGauge", "Knob Gauge", "GAUGES & INDICATORS"), D<LinearGauge>("LinearGauge", "Linear Gauge", "GAUGES & INDICATORS"),
        D<VerticalLinearGauge>("VerticalLinearGauge", "Vertical Linear Gauge", "GAUGES & INDICATORS"),
        D<NumericGauge>("NumericGauge", "Numeric Gauge", "GAUGES & INDICATORS"), D<Gauges>("Gauges", "Multiple Gauges", "GAUGES & INDICATORS"),

        D<Points3D>("Points3D", "Points 3D", "3D, SURFACES & MAPS"), D<Vector3D>("Vector3D", "Vector 3D", "3D, SURFACES & MAPS"),
        D<Surface>("Surface", "Surface", "3D, SURFACES & MAPS"), D<Contour>("Contour", "Contour", "3D, SURFACES & MAPS"),
        D<ColorGrid>("ColorGrid", "Color Grid", "3D, SURFACES & MAPS"), D<Tower>("Tower", "Tower", "3D, SURFACES & MAPS"),
        D<TriSurface>("TriSurface", "Tri-Surface", "3D, SURFACES & MAPS"), D<IsoSurface>("IsoSurface", "Iso-Surface", "3D, SURFACES & MAPS"),
        D<Ternary>("Ternary", "Ternary", "3D, SURFACES & MAPS"), D<Steema.TeeChart.Styles.Map>("Map", "Map", "3D, SURFACES & MAPS"),
        D<World>("World", "World Map", "3D, SURFACES & MAPS"), D<ImagePoint>("ImagePoint", "Image Point", "3D, SURFACES & MAPS")
    };

    internal static SeriesDemo? Find(string id) => All.FirstOrDefault(x => x.Id == id);
    private static SeriesDemo D<T>(string id, string name, string category) where T : Series => new(id, name, category, typeof(T));
}
