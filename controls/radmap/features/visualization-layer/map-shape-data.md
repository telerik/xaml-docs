---
title: Map Shape Data
page_title: Map Shape Data
description: Check our &quot;Map Shape Data&quot; documentation article for the RadMap {{ site.framework_name }} control.
slug: radmap-visualization-layer-map-shape-data
tags: map,shape,data
published: True
position: 3
---

# Map Shape Data

The visualization engine based on the VisualizationLayer class introduces a new approach that separates the geographical data and its visualization. The new map shape data classes are not dependency objects. This allows them to be created in the background thread. The unified map shape visualization engine allows attaching to any input event supported by the [ContentPresenter](http://msdn.microsoft.com/en-us/library/system.windows.controls.contentpresenter.aspx) class to the map shape visual presentation.      

You will be able to find equivalents to most of the Shapes available in {{ site.framework_name }}.      

>To learn more about the different ways of customizing the shape appearance, please check the [Shape Appearance]({%slug radmap-visualization-layer-shape-appearance%}) topic.        

The map shape data can be used identically to their visual element counterparts. This topic will focus briefly on showing you how to use the most important of them:      

1. EllipseData
2. LineData
3. PathData
4. PolygonData
5. PolylineData
6. RectangleData

>tip Adding map shape data objects in the ItemsSource of VisualizationLayer is not recommended. This is especially valid if the same source collection is shared between multiple VisualizationLayer instances.

## EllipseData

The EllipseData class represents an ellipse given in geographical coordinates.

In contrast with MapEllipse which is used with InformationLayer, the `Width` and `Height` of the `EllipseData` are given in the spatial reference units (degrees by default) instead of the current distance unit (mile or kilometer).          

To use the EllipseData in your visualization layer you have to set the following of its properties:
        
* **Location**: Represents the location on the map on which the ellipse will be displayed.
            
* **Width / Height**: Represent the width / height of the ellipse in spatial reference units (degrees by default).
            
>Note that the top left corner coincides with the given location.
          
Here it is an example:        


```XAML
	<telerik:RadMap x:Name="radMap"
	                ZoomLevel="8"
	                Center="42.6957539183824, 23.3327663758679">
		<telerik:RadMap.Provider>
			<telerik:OpenStreetMapProvider />
		</telerik:RadMap.Provider>
		<telerik:VisualizationLayer x:Name="visualizationLayer">
			<telerik:EllipseData Location="42.9457539183824,23.0827663758679"
	                             Height="0.5"
	                             Width="0.5">
				<telerik:EllipseData.ShapeFill>
					<telerik:MapShapeFill Fill="#6FDFEFFF"
	                                      Stroke="Blue"
	                                      StrokeThickness="2" />
				</telerik:EllipseData.ShapeFill>
			</telerik:EllipseData>
		</telerik:VisualizationLayer>
	</telerik:RadMap>
```


```C#
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
```
```VB.NET
	Dim ellipse As New EllipseData() With { _
		.Location = New Location(43.4457539183824, 23.2927663758679), _
		.Height = 0.5, _
		.Width = 0.5, _
		.ShapeFill = New MapShapeFill() With { _
			.Fill = New SolidColorBrush(Color.FromArgb(127, 0, 240, 255)), _
			.Stroke = New SolidColorBrush(Colors.Red), _
			.StrokeThickness = 2 _
		} _
	}
	
	Me.visualizationLayer.Items.Add(ellipse)
```

![radmap-visualization-layer-map-shape-data-ellipse](images/radmap-visualization-layer-map-shape-data-ellipse.png)

## LineData

The `LineData` class represents a line given in geographical coordinates.

The most important properties of the `LineData` class are the `Point1` and `Point2` properties, which are of type `Location`. They define the start and the end points of the line. Here is an example:        


```XAML
	<telerik:RadMap x:Name="radMap"
	                ZoomLevel="8"
	                Center="42.6957539183824, 23.3327663758679">
		<telerik:RadMap.Provider>
			<telerik:OpenStreetMapProvider />
		</telerik:RadMap.Provider>
		<telerik:VisualizationLayer x:Name="visualizationLayer">
			<telerik:LineData Point1="42.6957539183824,23.3327663758679"
	                          Point2="43.1957539183824,23.5427663758679">
				<telerik:LineData.ShapeFill>
					<telerik:MapShapeFill Stroke="Blue"
	                                      StrokeThickness="2" />
				</telerik:LineData.ShapeFill>
			</telerik:LineData>
		</telerik:VisualizationLayer>
	</telerik:RadMap>
```


```C#
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
```
```VB.NET
	Dim line As New LineData() With { _
		.Point1 = New Location(42.6957539183824, 23.3327663758679), _
		.Point2 = New Location(42.1429369264591, 24.7498095849434), _
		.ShapeFill = New MapShapeFill() With { _
			.Stroke = New SolidColorBrush(Colors.Red), _
			.StrokeThickness = 2 _
		} _
	}
	
	Me.visualizationLayer.Items.Add(line)
```

![radmap-visualization-layer-map-shape-data-line](images/radmap-visualization-layer-map-shape-data-line.png)

## PathData

The `PathData` provides equivalents of the standard `Geometry` and `Segment` classes in {{ site.framework_name }}. It exposes a `Data` property of type `GeometryData` which can be set to an instance of the `PathGeometryData` which specifies the shape to be drawn.

Here is an example that uses a `PathGeometryData` which in turn holds a `PathFigureData` figure composed of `LineSegmentData` segments:


```XAML
	<telerik:RadMap x:Name="radMap"
	                ZoomLevel="7"
	                Center="42.6957539183824, 24.8327663758679">
		<telerik:RadMap.Provider>
			<telerik:OpenStreetMapProvider />
		</telerik:RadMap.Provider>
		<telerik:VisualizationLayer x:Name="visualizationLayer">
			<telerik:PathData>
				<telerik:PathData.Data>
					<telerik:PathGeometryData>
						<telerik:PathGeometryData.Figures>
							<telerik:PathFigureData IsClosed="True"
	                                                StartPoint="42.6957539183824, 23.3327663758679">
								<telerik:PathFigureData.Segments>
									<telerik:LineSegmentData Point="42.1429369264591, 24.7498095849434" />
									<telerik:LineSegmentData Point="42.5131732087098, 27.4611884843576" />
									<telerik:LineSegmentData Point="43.2073941930888, 27.9275176988258" />
									<telerik:LineSegmentData Point="43.1957539183824,23.5427663758679" />
								</telerik:PathFigureData.Segments>
							</telerik:PathFigureData>
							<telerik:PathFigureData IsClosed="True"
	                                                StartPoint="42.6957539183824, 23.8327663758679">
								<telerik:PathFigureData.Segments>
									<telerik:LineSegmentData Point="42.3429369264591, 24.7498095849434" />
									<telerik:LineSegmentData Point="42.6131732087098, 26.9611884843576" />
									<telerik:LineSegmentData Point="43.0073941930888, 27.3275176988258" />
									<telerik:LineSegmentData Point="42.9957539183824, 23.9427663758679" />
								</telerik:PathFigureData.Segments>
							</telerik:PathFigureData>
						</telerik:PathGeometryData.Figures>
					</telerik:PathGeometryData>
				</telerik:PathData.Data>
				<telerik:PathData.ShapeFill>
					<telerik:MapShapeFill Fill="#6FDFEFFF"
	                                      Stroke="Blue"
	                                      StrokeThickness="2" />
				</telerik:PathData.ShapeFill>
			</telerik:PathData>
		</telerik:VisualizationLayer>
	</telerik:RadMap>
```


```C#
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
```
```VB.NET
	Dim path As New PathData() With { _
		.ShapeFill = New MapShapeFill() With { _
			.Fill = New SolidColorBrush(Color.FromArgb(127, 0, 240, 255)), _
			.Stroke = New SolidColorBrush(Colors.Red), _
			.StrokeThickness = 2 _
		} _
	}
	
	Dim geometry As New PathGeometryData()
	
	Dim figure As New PathFigureData() With { _
		.IsClosed = True, _
		.StartPoint = New Location(44.6957539183824, 23.3327663758679) _
	}
	
	Dim segment As New LineSegmentData() With { _
		.Point = New Location(44.1429369264591, 24.7498095849434) _
	}
	figure.Segments.Add(segment)
	
	segment = New LineSegmentData() With { _
		.Point = New Location(44.5131732087098, 27.4611884843576) _
	}
	figure.Segments.Add(segment)
	
	segment = New LineSegmentData() With { _
		.Point = New Location(45.2073941930888, 27.9275176988258) _
	}
	figure.Segments.Add(segment)
	
	segment = New LineSegmentData() With { _
		.Point = New Location(45.1957539183824, 23.5427663758679) _
	}
	figure.Segments.Add(segment)
	
	geometry.Figures.Add(figure)
	path.Data = geometry
	
	Me.visualizationLayer.Items.Add(path)
```

![radmap-visualization-layer-map-shape-data-path](images/radmap-visualization-layer-map-shape-data-path.png)

As of **R2 2022 SP1** you can also use an instance of `CombinedGeometryData` as the Data of the `PathGeometryData`. The CombinedGeometryData represents a composite geometry which is a combination of two GeometryData objects. They can be combined via 4 `GeometryCombineMode` types:

* **Union**: The two regions are combined by taking the union of both. The resulting geometry is geometry A + geometry B.
* **Intersect**: The two regions are combined by taking their intersection. The new area consists of the overlapping region between the two geometries.
* **Xor**: The two regions are combined by taking the area that exists in the first region but not the second and the area that exists in the second region but not the first. The new region consists of (A-B) + (B-A), where A and B are geometries.
* **Exclude**: The second region is excluded from the first. Given two geometries, A and B, the area of geometry B is removed from the area of geometry A, producing a region that is A-B.


```XAML
	<telerik:RadMap x:Name="radMap"
	                ZoomLevel="7"
	                Center="42.6957539183824, 24.8327663758679">
		<telerik:RadMap.Provider>
			<telerik:OpenStreetMapProvider />
		</telerik:RadMap.Provider>
		<telerik:VisualizationLayer x:Name="visualizationLayer">
			<telerik:PathData>
				<telerik:PathData.Data>
					<telerik:CombinedGeometryData CombineMode="Intersect">
						<telerik:CombinedGeometryData.Geometry1>
							<telerik:EllipseGeometryData Center="42.6957539183824,23.3327663758679" RadiusX="0.4" RadiusY="0.4" />
						</telerik:CombinedGeometryData.Geometry1>
						<telerik:CombinedGeometryData.Geometry2>
							<telerik:EllipseGeometryData Center="43.1957539183824,23.5427663758679" RadiusX="0.4" RadiusY="0.4" />
						</telerik:CombinedGeometryData.Geometry2>
					</telerik:CombinedGeometryData>
				</telerik:PathData.Data>
				<telerik:PathData.ShapeFill>
					<telerik:MapShapeFill Fill="#6F3170ED" 
									Stroke="Blue" 
									StrokeThickness="2" />
				</telerik:PathData.ShapeFill>
			</telerik:PathData>
		</telerik:VisualizationLayer>
	</telerik:RadMap>
```


```C#
	CombinedGeometryData combinedData = new CombinedGeometryData() { CombineMode = GeometryCombineMode.Xor };
	combinedData.Geometry1 = new EllipseGeometryData()
	{
		Center = new Location(43.1957539183824, 23.5427663758679),
		RadiusX = 0.4,
		RadiusY = 0.4,
	};

	combinedData.Geometry2 = new EllipseGeometryData()
	{
		Center = new Location(42.6957539183824, 23.3327663758679),
		RadiusX = 0.4,
		RadiusY = 0.4,
	};

	PathData path = new PathData();
	path.ShapeFill = new MapShapeFill()
	{
		Fill = new SolidColorBrush(Color.FromArgb(127, 0, 240, 255)),
		Stroke = new SolidColorBrush(Colors.Red),
		StrokeThickness = 1
	};
	path.Data = combinedData;

	this.visualizationLayer.Items.Add(path);
```
```VB.NET
	Dim combinedData As New CombinedGeometryData() With {.CombineMode = GeometryCombineMode.Xor}
	combinedData.Geometry1 = New EllipseGeometryData() With {
		.Center = New Location(43.1957539183824, 23.5427663758679),
		.RadiusX = 0.4,
		.RadiusY = 0.4
	}

	combinedData.Geometry2 = New EllipseGeometryData() With {
		.Center = New Location(42.6957539183824, 23.3327663758679),
		.RadiusX = 0.4,
		.RadiusY = 0.4
	}

	Dim path As New PathData()
	path.ShapeFill = New MapShapeFill() With {
		.Fill = New SolidColorBrush(Color.FromArgb(127, 0, 240, 255)),
		.Stroke = New SolidColorBrush(Colors.Red),
		.StrokeThickness = 1
	}
	path.Data = combinedData

	Me.visualizationLayer.Items.Add(path)
```

![RadMap Visualization Layer CombinedGeometryData](images/radmap-visualization-layer-map-shape-data-combined.png)

## PolygonData

The `PolygonData` class represents polygon data in geographical coordinates.

The difference between the standard Polygon and the PolygonData is that the `Points` property of the `PolygonData` is a set of Locations. Here is an example:        


```XAML
	<telerik:RadMap x:Name="radMap"
	                ZoomLevel="5"
	                Center="52,-104">
		<telerik:RadMap.Provider>
			<telerik:OpenStreetMapProvider />
		</telerik:RadMap.Provider>
		<telerik:VisualizationLayer x:Name="visualizationLayer">
			<telerik:PolygonData Points="56,-100 56,-104 52,-104 52,-100">
				<telerik:PolygonData.ShapeFill>
					<telerik:MapShapeFill Fill="#6FDFEFFF"
	                                      Stroke="Blue"
	                                      StrokeThickness="2" />
				</telerik:PolygonData.ShapeFill>
			</telerik:PolygonData>
		</telerik:VisualizationLayer>
	</telerik:RadMap>
```


```C#
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
```
```VB.NET
	Dim polygon As New PolygonData() With { _
		.ShapeFill = New MapShapeFill() With { _
			.Fill = New SolidColorBrush(Color.FromArgb(127, 0, 240, 255)), _
			.Stroke = New SolidColorBrush(Colors.Red), _
			.StrokeThickness = 2 _
		} _
	}
	
	Dim points As New LocationCollection()
	points.Add(New Location(48, -104))
	points.Add(New Location(48, -108))
	points.Add(New Location(52, -108))
	points.Add(New Location(52, -104))
	
	polygon.Points = points
	
	Me.visualizationLayer.Items.Add(polygon)
```

![radmap-visualization-layer-map-shape-data-polygon](images/radmap-visualization-layer-map-shape-data-polygon.png)

## PolylineData

The `PolylineData` class represents polyline data in geographical coordinates.

The difference between the standard Polyline and the PolylineData is that the `Points` property of the `PolylineData` is a set of Locations. Here is an example:        


```XAML
	<telerik:RadMap x:Name="radMap"
	                ZoomLevel="7"
	                Center="42.6957539183824, 25.3327663758679">
		<telerik:RadMap.Provider>
			<telerik:OpenStreetMapProvider />
		</telerik:RadMap.Provider>
		<telerik:VisualizationLayer x:Name="visualizationLayer">
			<telerik:PolylineData Points="42.945,23.082 42.142, 24.749 42.513, 27.461 43.207, 27.927">
				<telerik:PolylineData.ShapeFill>
					<telerik:MapShapeFill Stroke="Blue"
	                                      StrokeThickness="2" />
				</telerik:PolylineData.ShapeFill>
			</telerik:PolylineData>
		</telerik:VisualizationLayer>
	</telerik:RadMap>
```


```C#
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
```
```VB.NET
	Dim polyline As New PolylineData() With { _
		.ShapeFill = New MapShapeFill() With { _
			.Stroke = New SolidColorBrush(Colors.Red), _
			.StrokeThickness = 2 _
		} _
	}
	
	Dim points As New LocationCollection()
	points.Add(New Location(44.6957539183824, 23.3327663758679))
	points.Add(New Location(44.1429369264591, 24.7498095849434))
	points.Add(New Location(44.5131732087098, 27.4611884843576))
	points.Add(New Location(45.2073941930888, 27.9275176988258))
	
	polyline.Points = points
	
	Me.visualizationLayer.Items.Add(polyline)
```

![radmap-visualization-layer-map-shape-data-polyline](images/radmap-visualization-layer-map-shape-data-polyline.png)

## RectangleData

The `RectangleData` class represents a rectangle given in geographical coordinates.

To use the RectangleData in your visualization layer you have to set the following properties:       

* **Location**: Represents the location on the map, to which the ellipse is bound.            

* **Width / Height**: Represent the width / height of the ellipse. Just like the Width and Height properties of the EllipseData class, they are specified in spatial reference units (degrees by default).            

* **RadiusX / RadiusY**: Represent the radius of the rectangle corners. Measured in spatial reference units.            

>Note that the top left corner coincides with the given location.          

Here it is an example:        


```XAML
	<telerik:RadMap x:Name="radMap"
	                ZoomLevel="8"
	                Center="42.6957539183824, 23.3327663758679">
		<telerik:RadMap.Provider>
			<telerik:OpenStreetMapProvider />
		</telerik:RadMap.Provider>
		<telerik:VisualizationLayer x:Name="visualizationLayer">
			<telerik:RectangleData Location="42.9457539183824,23.0827663758679"
	                               Height="0.5"
	                               Width="0.5"
	                               RadiusX="0.05"
	                               RadiusY="0.05">
				<telerik:RectangleData.ShapeFill>
					<telerik:MapShapeFill Fill="#6FDFEFFF"
	                                      Stroke="Blue"
	                                      StrokeThickness="2" />
				</telerik:RectangleData.ShapeFill>
			</telerik:RectangleData>
		</telerik:VisualizationLayer>
	</telerik:RadMap>
```


```C#
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
```
```VB.NET
	Dim rect As New RectangleData() With { _
		.Location = New Location(43.4457539183824, 23.2927663758679), _
		.Height = 0.5, _
		.Width = 0.5, _
		.RadiusX = 0.05, _
		.RadiusY = 0.05, _
		.ShapeFill = New MapShapeFill() With { _
			.Fill = New SolidColorBrush(Color.FromArgb(127, 0, 240, 255)), _
			.Stroke = New SolidColorBrush(Colors.Red), _
			.StrokeThickness = 2 _
		} _
	}
	
	Me.visualizationLayer.Items.Add(rect)
```

![radmap-visualization-layer-map-shape-data-rectangle](images/radmap-visualization-layer-map-shape-data-rectangle.png)

## See Also

 * [Visualization Layer ]({%slug radmap-visualization-layer-introduction%})
 * [Information Layer]({%slug radmap-features-information-layer%})
 * [Map Shapes]({%slug radmap-features-map-shapes%})