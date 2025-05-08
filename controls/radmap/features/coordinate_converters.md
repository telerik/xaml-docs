---
title: Coordinate Converters
page_title: Coordinate Converters
description: This article describes the build-in coordinate converters.
slug: radmap-features-coordinate-converters
tags: osgb36converter, epsg900913converter, coordinateconverter, projection, mercator
published: True
position: 3
---

# Coordinate Converters

By default all of built-in __RadMap__ providers (AzureMapProvider, OpenStreetMapProvider) use the standard __Mercator__ projection. When reading shape files with different projections, then you can use a coordinate converter. To do this, set the `CoordinateConverter` property of `MapShapeReader`. 

The RadMap contains two built-in converters which convert coordinates from EPSG:27700 and EPSG:3857 to EPSG:4326 projection. 

* __OSGB36Converter__
* __EPSG900913Converter__

The converter (OSGB36Converter/ EPSG900913Converter) can be specified by setting it to the __MapShapeReader.CoordinateConverter__ property.

#### __[XAML] Example 1: Setting CoordinateConverter property__
{{region radmap-features-coordinate-converters_0}}
	<telerik:RadMap>
		<telerik:RadMap.Providers>
			<telerik:OpenStreetMapProvider />
		</telerik:RadMap.Providers>
		<telerik:VisualizationLayer >
			<telerik:VisualizationLayer.Reader>
				<telerik:AsyncShapeFileReader >
					<telerik:AsyncShapeFileReader.CoordinateConverter>
						<telerik:EPSG900913Converter />
					</telerik:AsyncShapeFileReader.CoordinateConverter>
				</telerik:AsyncShapeFileReader>
			</telerik:VisualizationLayer.Reader>
		</telerik:VisualizationLayer>
	</telerik:RadMap>
{{endregion}}

## Custom Coordinate Converter

The API of the RadMap allows you to use a custom coordinate converter by implementing the __ICoordinateConverter__ interface.

#### __[C#] Example 2: Implement ICoordinateConverter__
{{region cs-radmap-features-coordinate-converters_1}}
	public class CustomCoordinateConverter : ICoordinateConverter
	{
		public LocationCollection ConvertBack(LocationCollection collection)
		{			
			return new LocationCollection();
		}

		public LocationCollection ConvertTo(LocationCollection collection)
		{
			return new LocationCollection();
		}

		public Location FromLocation(Location location)
		{
			return new Location();
		}

		public Location ToLocation(object coordinates)
		{
			return new Location();
		}

		public string ToString(Location location)
		{
			return location.ToString();
		}
	}
{{endregion}}

The custom coordinate converter can be assigned to the __MapShapeReader.CoordinateConverter__ property.

#### __[XAML] Example 3: Setting CustomCoordinateConverter in XAML__
{{region radmap-features-coordinate-converters_2}}
	<telerik:RadMap>
		<telerik:RadMap.Providers>
			<telerik:OpenStreetMapProvider />
		</telerik:RadMap.Providers>
		<telerik:VisualizationLayer >
			<telerik:VisualizationLayer.Reader>
				<telerik:AsyncShapeFileReader >
					<telerik:AsyncShapeFileReader.CoordinateConverter>
						<local:CustomCoordinateConverter />
					</telerik:AsyncShapeFileReader.CoordinateConverter>
				</telerik:AsyncShapeFileReader>
			</telerik:VisualizationLayer.Reader>
		</telerik:VisualizationLayer>
	</telerik:RadMap>
{{endregion}}

## See Also
 * [Navigation]({%slug radmap-features-navigation%})
 * [Zoom Modes]({%slug radmap-features-zoom-modes%})
 * [Distance and Scale]({%slug radmap-features-dsitance-and-scale%})
 * [Mouse Location]({%slug radmap-features-mouse-location%})
 * [Default Layout]({%slug radmap-features-default-layout%})
