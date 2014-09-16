using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;

namespace WpfApplication1
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
	}

#region radmap_visualization_layer_map_shape_data_0
EllipseData ellipse = new EllipseData()
{
	Location = new Location(43.4457539183824, 23.2927663758679),
	Height = 0.5,
	Width = 0.5, 
	ShapeFill = new MapShapeFill()
	{
		Fill = new SolidColorBrush(Color.FromArgb(127, 0, 240, 255)),
		Stroke = new SolidColorBrush(Colors.Red),
		StrokeThickness = 2
	}
};

this.visualizationLayer.Items.Add(ellipse);
#endregion

#region radmap_visualization_layer_map_shape_data_1
LineData line = new LineData()
{
	Point1 = new Location(42.6957539183824, 23.3327663758679),
	Point2 = new Location(42.1429369264591, 24.7498095849434),
	ShapeFill = new MapShapeFill()
	{
		Stroke = new SolidColorBrush(Colors.Red),
		StrokeThickness = 2
	}
};

this.visualizationLayer.Items.Add(line);
#endregion

#region radmap_visualization_layer_map_shape_data_2
PathData path = new PathData()
{
	ShapeFill = new MapShapeFill()
	{
		Fill = new SolidColorBrush(Color.FromArgb(127, 0, 240, 255)),
		Stroke = new SolidColorBrush(Colors.Red),
		StrokeThickness = 2
	}
};

PathGeometryData geometry = new PathGeometryData();

PathFigureData figure = new PathFigureData()
{
	IsClosed = true,
	StartPoint = new Location(44.6957539183824, 23.3327663758679)
};

LineSegmentData segment = new LineSegmentData()
{
	Point = new Location(44.1429369264591, 24.7498095849434)
};
figure.Segments.Add(segment);

segment = new LineSegmentData()
{
	Point = new Location(44.5131732087098, 27.4611884843576)
};
figure.Segments.Add(segment);

segment = new LineSegmentData()
{
	Point = new Location(45.2073941930888, 27.9275176988258)
};
figure.Segments.Add(segment);

segment = new LineSegmentData()
{
	Point = new Location(45.1957539183824,23.5427663758679)
};
figure.Segments.Add(segment);

geometry.Figures.Add(figure);
path.Data = geometry;

this.visualizationLayer.Items.Add(path);
#endregion

#region radmap_visualization_layer_map_shape_data_3
PolygonData polygon = new PolygonData()
{
	ShapeFill = new MapShapeFill()
	{
		Fill = new SolidColorBrush(Color.FromArgb(127, 0, 240, 255)),
		Stroke = new SolidColorBrush(Colors.Red),
		StrokeThickness = 2
	}
};

LocationCollection points = new LocationCollection();
points.Add(new Location(48,-104));
points.Add(new Location(48,-108));
points.Add(new Location(52,-108));
points.Add(new Location(52, -104));

polygon.Points = points;

this.visualizationLayer.Items.Add(polygon);
#endregion

#region radmap_visualization_layer_map_shape_data_4
PolylineData polyline = new PolylineData()
{
	ShapeFill = new MapShapeFill()
	{
		Stroke = new SolidColorBrush(Colors.Red),
		StrokeThickness = 2
	}
};

LocationCollection points = new LocationCollection();
points.Add(new Location(44.6957539183824, 23.3327663758679));
points.Add(new Location(44.1429369264591, 24.7498095849434));
points.Add(new Location(44.5131732087098, 27.4611884843576));
points.Add(new Location(45.2073941930888, 27.9275176988258));

polyline.Points = points;

this.visualizationLayer.Items.Add(polyline);
#endregion

#region radmap_visualization_layer_map_shape_data_5
RectangleData rect = new RectangleData()
{
	Location = new Location(43.4457539183824, 23.2927663758679),
	Height = 0.5,
	Width = 0.5,
	RadiusX = 0.05,
	RadiusY = 0.05,
	ShapeFill = new MapShapeFill()
	{
		Fill = new SolidColorBrush(Color.FromArgb(127, 0, 240, 255)),
		Stroke = new SolidColorBrush(Colors.Red),
		StrokeThickness = 2
	}
};

this.visualizationLayer.Items.Add(rect);
#endregion
}
