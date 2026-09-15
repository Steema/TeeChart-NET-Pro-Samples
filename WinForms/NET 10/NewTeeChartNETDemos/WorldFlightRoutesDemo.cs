using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Steema.TeeChart;
using Steema.TeeChart.Drawing;
using Steema.TeeChart.Styles;

namespace NewTeeChartNETDemos
{
    public class WorldFlightRoutesDemo : AttentionChartDemoBase
    {
        private readonly List<FlightRoute> routes = new();
        private Points aircraftSeries = null!;
        private double[] aircraftHeadings = Array.Empty<double>();

        public WorldFlightRoutesDemo() : base("World Flight Routes")
        {
            TeeChart.Panel.Color = Color.FromArgb(14, 28, 41);
            TeeChart.Header.Text = "World Flight Routes · animated great-circle traffic";
            TeeChart.Legend.Visible = false;
            TeeChart.Aspect.View3D = false;

            var world = new World(TeeChart.Chart)
            {
                Map = WorldMapType.World,
                Color = Color.FromArgb(42, 76, 98)
            };
            world.Pen.Color = Color.FromArgb(105, 155, 170);
            world.Pen.Transparency = 35;
            world.Pen.Width = 1;
            world.Marks.Visible = false;

            ConfigureMapAxes();
            CreateRoutes();
            CreateDestinationsTable();
            CreateAirportLayer();
            CreateAircraftLayer();

            StartValueAnimation(phase =>
            {
                aircraftSeries.BeginUpdate();
                try
                {
                    for (int i = 0; i < routes.Count; i++)
                    {
                        FlightRoute route = routes[i];
                        double progress = (phase * 0.065 + i * 0.15) % 1.0;
                        GeoPoint position = GreatCirclePoint(route.Origin, route.Destination, progress);
                        GeoPoint previous = GreatCirclePoint(route.Origin, route.Destination, Math.Max(0, progress - 0.01));
                        GeoPoint next = GreatCirclePoint(route.Origin, route.Destination, Math.Min(1, progress + 0.01));

                        aircraftSeries.XValues[route.AircraftIndex] = position.Longitude;
                        aircraftSeries.YValues[route.AircraftIndex] = position.Latitude;
                        aircraftHeadings[route.AircraftIndex] = HeadingOnChart(previous, next);
                    }
                }
                finally
                {
                    aircraftSeries.EndUpdate();
                }
            });
        }

        private void ConfigureMapAxes()
        {
            TeeChart.Axes.Bottom.SetMinMax(-180, 180);
            TeeChart.Axes.Bottom.Increment = 30;
            TeeChart.Axes.Bottom.Title.Text = "Longitude";
            TeeChart.Axes.Bottom.Labels.ValueFormat = "0°";

            TeeChart.Axes.Left.SetMinMax(-90, 90);
            TeeChart.Axes.Left.Increment = 15;
            TeeChart.Axes.Left.Title.Text = "Latitude";
            TeeChart.Axes.Left.Labels.ValueFormat = "0°";

            TeeChart.Axes.Bottom.Labels.Font.Color = Color.LightGray;
            TeeChart.Axes.Left.Labels.Font.Color = Color.LightGray;
            TeeChart.Axes.Bottom.Title.Font.Color = Color.LightGray;
            TeeChart.Axes.Left.Title.Font.Color = Color.LightGray;
        }

        private void CreateRoutes()
        {
            routes.Add(new FlightRoute(
                "New York → London",
                new Airport("JFK", "New York", -73.7781, 40.6413),
                new Airport("LHR", "London", -0.4543, 51.4700),
                Color.FromArgb(255, 105, 97)));

            routes.Add(new FlightRoute(
                "San Francisco → Paris",
                new Airport("SFO", "San Francisco", -122.3790, 37.6213),
                new Airport("CDG", "Paris", 2.5559, 49.0097),
                Color.FromArgb(255, 196, 79)));

            routes.Add(new FlightRoute(
                "Dubai → Singapore",
                new Airport("DXB", "Dubai", 55.3644, 25.2532),
                new Airport("SIN", "Singapore", 103.9915, 1.3644),
                Color.FromArgb(71, 214, 174)));

            routes.Add(new FlightRoute(
                "Madrid → São Paulo",
                new Airport("MAD", "Madrid", -3.5670, 40.4983),
                new Airport("GRU", "São Paulo", -46.4731, -23.4356),
                Color.FromArgb(91, 164, 255)));

            routes.Add(new FlightRoute(
                "Sydney → Tokyo",
                new Airport("SYD", "Sydney", 151.1772, -33.9461),
                new Airport("HND", "Tokyo", 139.7798, 35.5494),
                Color.FromArgb(211, 128, 255)));

            foreach (FlightRoute route in routes)
            {
                route.Track = new Line(TeeChart.Chart)
                {
                    Title = route.Name,
                    Color = route.Color
                };

                route.Track.LinePen.Color = route.Color;
                route.Track.LinePen.Width = 2;
                route.Track.LinePen.Transparency = 28;
                route.Track.Pointer.Visible = false;
                route.Track.Marks.Visible = false;

                for (int i = 0; i <= 48; i++)
                {
                    GeoPoint point = GreatCirclePoint(route.Origin, route.Destination, i / 48.0);
                    route.Track.Add(point.Longitude, point.Latitude);
                }
            }
        }

        private void CreateDestinationsTable()
        {
            var table = new DataGridView
            {
                Dock = DockStyle.Bottom,
                Height = 112,
                ReadOnly = true,
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                AllowUserToResizeRows = false,
                AutoGenerateColumns = false,
                RowHeadersVisible = false,
                BorderStyle = BorderStyle.None,
                BackgroundColor = Color.FromArgb(17, 34, 48),
                GridColor = Color.FromArgb(55, 84, 99),
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                MultiSelect = false,
                EnableHeadersVisualStyles = false,
                ColumnHeadersHeight = 28
            };

            table.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.FromArgb(24, 48, 64),
                ForeColor = Color.FromArgb(190, 215, 225),
                Font = new System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold),
                Alignment = DataGridViewContentAlignment.MiddleLeft
            };
            table.DefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.FromArgb(17, 34, 48),
                ForeColor = Color.White,
                SelectionBackColor = Color.FromArgb(35, 72, 88),
                SelectionForeColor = Color.White,
                Font = new System.Drawing.Font("Segoe UI", 9),
                Padding = new Padding(4, 0, 4, 0)
            };

            table.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "RouteColor",
                HeaderText = " ",
                Width = 42,
                SortMode = DataGridViewColumnSortMode.NotSortable
            });
            table.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Origin",
                HeaderText = "Ciudad origen",
                Width = 220,
                SortMode = DataGridViewColumnSortMode.NotSortable
            });
            table.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Destination",
                HeaderText = "Ciudad destino",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                SortMode = DataGridViewColumnSortMode.NotSortable
            });

            foreach (FlightRoute route in routes)
            {
                int rowIndex = table.Rows.Add("●", route.Origin.City, route.Destination.City);
                DataGridViewCell colorCell = table.Rows[rowIndex].Cells[0];
                colorCell.Style = new DataGridViewCellStyle
                {
                    ForeColor = route.Color,
                    Font = new System.Drawing.Font("Segoe UI Symbol", 14),
                    Alignment = DataGridViewContentAlignment.MiddleCenter,
                    BackColor = Color.FromArgb(17, 34, 48),
                    SelectionBackColor = Color.FromArgb(35, 72, 88)
                };
            }

            Controls.Add(table);
            table.BringToFront();
        }

        private void CreateAirportLayer()
        {
            var airports = new Points(TeeChart.Chart)
            {
                Title = "Airports",
                Color = Color.White
            };

            airports.Pointer.Style = PointerStyles.Circle;
            airports.Pointer.Visible = true;
            airports.Pointer.HorizSize = 5;
            airports.Pointer.VertSize = 5;
            airports.Pointer.Brush.Color = Color.White;
            airports.Pointer.Pen.Color = Color.FromArgb(14, 28, 41);
            airports.Marks.Visible = true;
            airports.Marks.Style = MarksStyles.Label;
            airports.Marks.Transparent = true;
            airports.Marks.Font.Color = Color.White;
            airports.Marks.Font.Size = 8;

            var added = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            foreach (FlightRoute route in routes)
            {
                AddAirportIfNeeded(airports, added, route.Origin);
                AddAirportIfNeeded(airports, added, route.Destination);
            }
        }

        private static void AddAirportIfNeeded(Points airports, HashSet<string> added, Airport airport)
        {
            if (added.Add(airport.Code))
                airports.Add(airport.Longitude, airport.Latitude, airport.Code, Color.White);
        }

        private void CreateAircraftLayer()
        {
            aircraftSeries = new Points(TeeChart.Chart)
            {
                Title = "Aircraft",
                ColorEach = true
            };

            // The plane is rendered in AfterDrawValues so its silhouette can follow the route heading.
            aircraftSeries.Pointer.Visible = false;
            aircraftSeries.Marks.Visible = false;
            aircraftHeadings = new double[routes.Count];
            aircraftSeries.AfterDrawValues += AircraftSeries_AfterDrawValues;

            foreach (FlightRoute route in routes)
            {
                route.AircraftIndex = aircraftSeries.Add(
                    route.Origin.Longitude,
                    route.Origin.Latitude,
                    "✈",
                    route.Color);
            }
        }

        private void AircraftSeries_AfterDrawValues(object sender, IGraphics3D graphics)
        {
            Color previousBrush = graphics.Brush.Color;
            Color previousPen = graphics.Pen.Color;
            int previousPenWidth = graphics.Pen.Width;

            try
            {
                for (int i = 0; i < routes.Count; i++)
                {
                    FlightRoute route = routes[i];
                    int x = aircraftSeries.CalcXPos(route.AircraftIndex);
                    int y = aircraftSeries.CalcYPos(route.AircraftIndex);
                    double angle = DegreesToRadians(aircraftHeadings[route.AircraftIndex]);
                    double cosine = Math.Cos(angle);
                    double sine = Math.Sin(angle);

                    Point[] plane =
                    {
                        RotatePoint(x, y, 12, 0, cosine, sine),
                        RotatePoint(x, y, -4, -3, cosine, sine),
                        RotatePoint(x, y, -8, -9, cosine, sine),
                        RotatePoint(x, y, -6, -1, cosine, sine),
                        RotatePoint(x, y, -11, -4, cosine, sine),
                        RotatePoint(x, y, -11, 4, cosine, sine),
                        RotatePoint(x, y, -6, 1, cosine, sine),
                        RotatePoint(x, y, -8, 9, cosine, sine),
                        RotatePoint(x, y, -4, 3, cosine, sine)
                    };

                    graphics.Brush.Color = route.Color;
                    graphics.Pen.Color = Color.White;
                    graphics.Pen.Width = 1;
                    graphics.Polygon(0, plane);
                }
            }
            finally
            {
                graphics.Brush.Color = previousBrush;
                graphics.Pen.Color = previousPen;
                graphics.Pen.Width = previousPenWidth;
            }
        }

        private static Point RotatePoint(int centerX, int centerY, int localX, int localY, double cosine, double sine)
        {
            return new Point(
                centerX + (int)Math.Round(localX * cosine - localY * sine),
                centerY + (int)Math.Round(localX * sine + localY * cosine));
        }

        private double HeadingOnChart(GeoPoint previous, GeoPoint next)
        {
            int previousX = TeeChart.Axes.Bottom.CalcPosValue(previous.Longitude);
            int previousY = TeeChart.Axes.Left.CalcPosValue(previous.Latitude);
            int nextX = TeeChart.Axes.Bottom.CalcPosValue(next.Longitude);
            int nextY = TeeChart.Axes.Left.CalcPosValue(next.Latitude);
            return RadiansToDegrees(Math.Atan2(nextY - previousY, nextX - previousX));
        }

        private static GeoPoint GreatCirclePoint(Airport origin, Airport destination, double fraction)
        {
            double latitude1 = DegreesToRadians(origin.Latitude);
            double longitude1 = DegreesToRadians(origin.Longitude);
            double latitude2 = DegreesToRadians(destination.Latitude);
            double longitude2 = DegreesToRadians(destination.Longitude);

            double delta = 2 * Math.Asin(Math.Sqrt(
                Math.Pow(Math.Sin((latitude2 - latitude1) / 2), 2)
                + Math.Cos(latitude1) * Math.Cos(latitude2)
                * Math.Pow(Math.Sin((longitude2 - longitude1) / 2), 2)));

            if (delta < 0.000001)
                return new GeoPoint(origin.Longitude, origin.Latitude);

            double scaleA = Math.Sin((1 - fraction) * delta) / Math.Sin(delta);
            double scaleB = Math.Sin(fraction * delta) / Math.Sin(delta);
            double x = scaleA * Math.Cos(latitude1) * Math.Cos(longitude1)
                + scaleB * Math.Cos(latitude2) * Math.Cos(longitude2);
            double y = scaleA * Math.Cos(latitude1) * Math.Sin(longitude1)
                + scaleB * Math.Cos(latitude2) * Math.Sin(longitude2);
            double z = scaleA * Math.Sin(latitude1) + scaleB * Math.Sin(latitude2);

            double latitude = Math.Atan2(z, Math.Sqrt(x * x + y * y));
            double longitude = Math.Atan2(y, x);
            return new GeoPoint(RadiansToDegrees(longitude), RadiansToDegrees(latitude));
        }

        private static double DegreesToRadians(double value) => value * Math.PI / 180.0;
        private static double RadiansToDegrees(double value) => value * 180.0 / Math.PI;

        private sealed class FlightRoute
        {
            public FlightRoute(string name, Airport origin, Airport destination, Color color)
            {
                Name = name;
                Origin = origin;
                Destination = destination;
                Color = color;
            }

            public string Name { get; }
            public Airport Origin { get; }
            public Airport Destination { get; }
            public Color Color { get; }
            public Line Track { get; set; } = null!;
            public int AircraftIndex { get; set; }
        }

        private sealed class Airport
        {
            public Airport(string code, double longitude, double latitude)
            {
                Code = code;
                City = code;
                Longitude = longitude;
                Latitude = latitude;
            }

            public Airport(string code, string city, double longitude, double latitude)
            {
                Code = code;
                City = city;
                Longitude = longitude;
                Latitude = latitude;
            }

            public string Code { get; }
            public string City { get; }
            public double Longitude { get; }
            public double Latitude { get; }
        }

        private readonly struct GeoPoint
        {
            public GeoPoint(double longitude, double latitude)
            {
                Longitude = longitude;
                Latitude = latitude;
            }

            public double Longitude { get; }
            public double Latitude { get; }
        }
    }
}
