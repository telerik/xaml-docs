---
title: Shapefiles Support
page_title: Shapefiles Support
description: Check our &quot;Shapefiles Support&quot; documentation article for the RadMap control.
slug: radmap-features-shapefiles-support
tags: shapefiles,support
published: True
position: 12
---

# Shapefiles Support

The __ESRI Shapefiles__ or simply the shapefiles are popular format for storing geographical data. The files spatially describe geometries like lines, polylines and polygons. These geometries may represent different geographical objects such as countries, roads, rivers, lakes etc. Via a software that supports the format, the geometries can be translated properly on a map.

>tip To learn more about the shapefiles, read this [article](http://en.wikipedia.org/wiki/Shapefile).

This topic will explain the following:

* [Reading Shapefiles with RadMap](#reading-shapefiles-with-radmap)

* [Manual Shape Reading](#manual-shape-reading)

## Reading Shapefiles with RadMap

To read your data you have to use the __MapShapeReader__ class. To learn more about its general usage read the [Shape Reader]({%slug radmap-features-information-layer-shape-reder%}) topic.

To pass the desired shapefile you have to use the __Source__ property of the __MapShapeReader__ and pass the __Uri__ to the desired .shp file to it. The shape file can be accompanied by additional files containing information which is related to the shapes. Example for such file is the .dbf, which holds attribute related to the shapes in the main file. The __RadMap__ allows you to use these types of files. To pass one to the reader use the __DataSource__ property and set it to the respective __Uri__.


```XAML
	<telerik:RadMap x:Name="radMap">
	    <telerik:InformationLayer x:Name="informationLayer">
	        <telerik:InformationLayer.Reader>
	            <telerik:MapShapeReader DataSource="/Silverlight.Help.RadMapSamples;component/Data/world.dbf"
	                                    Source="/Silverlight.Help.RadMapSamples;component/Data/world.shp" />
	        </telerik:InformationLayer.Reader>
	    </telerik:InformationLayer>
	</telerik:RadMap>
```


```C#
	this.informationLayer.Reader = new MapShapeReader();
	this.informationLayer.Reader.Source = new Uri( "/Silverlight.Help.RadMapSamples;component/Data/world.shp", UriKind.RelativeOrAbsolute );
	this.informationLayer.Reader.DataSource = new Uri( "/Silverlight.Help.RadMapSamples;component/Data/world.dbf", UriKind.RelativeOrAbsolute );
```


```VB.NET
	Me.informationLayer.Reader = New MapShapeReader()
	Me.informationLayer.Reader.Source = New Uri( "/Silverlight.Help.RadMapSamples;component/Data/world.shp", UriKind.RelativeOrAbsolute )
	Me.informationLayer.Reader.DataSource = New Uri( "/Silverlight.Help.RadMapSamples;component/Data/world.dbf", UriKind.RelativeOrAbsolute )
```

## Manual Shape Reading

The __RadMap__ allows you to manually read the file, by which you are able to get the shapes collection, without to automatically insert it into the layer. For this purpose you have to use the __ShapeFileReader__ static class.

First of all read the Shapefile as a resource stream. Note that the file must have its __BuildAction__ set to __Resource__. After that call the static __Read()__ method of the __ShapefileReader__ class and pass the resource stream to it. It returns a list of __FrameworkElement__ objects, which you can directly add to the __InformationLayer__ of the __RadMap__.


```C#
	StreamResourceInfo shapeResourceInfo = Application.GetResourceStream( new Uri( "/Silverlight.Help.RadMapSamples;component/Data/world.shp", UriKind.RelativeOrAbsolute ) );
	StreamResourceInfo dbfResourceInfo = Application.GetResourceStream( new Uri( "/Silverlight.Help.RadMapSamples;component/Data/world.dbf", UriKind.RelativeOrAbsolute ) );
	List<FrameworkElement> shapes = ShapeFileReader.Read( shapeResourceInfo.Stream, dbfResourceInfo.Stream );
	foreach ( var shape in shapes )
	{
	    this.informationLayer.Items.Add( shape );
	}
```


```VB.NET
	Dim shapeResourceInfo As StreamResourceInfo = Application.GetResourceStream(New Uri("/Silverlight.Help.RadMapSamples;component/Data/world.shp", UriKind.RelativeOrAbsolute))
	Dim dbfResourceInfo As StreamResourceInfo = Application.GetResourceStream(New Uri("/Silverlight.Help.RadMapSamples;component/Data/world.dbf", UriKind.RelativeOrAbsolute))
	Dim shapes As List(Of FrameworkElement) = ShapeFileReader.Read(shapeResourceInfo.Stream, dbfResourceInfo.Stream)
	For Each shape In shapes
	 Me.informationLayer.Items.Add(shape)
	Next shape
```

>tip RadMap provides built-in converters  for the following coordinate systems EPSG:4326 (Mercator, degrees) <-> OSGB36 (National Grid UK), EPSG:4326 (Mercator, degrees) <-> EPSG:900913 (Mercator, meters). This allows you to use shapefiles created for OSGB36 or EPSG:900913 with map providers that use EPSG:4326 so it is possible to show such shapefiles "as is" over the Azure Maps or OpenStreetMap imagery data. The converter (__OSGB36Converter__/ __EPSG900913Converter__) can be specified by setting the __MapShapeReader.CoordinateConverter__ property.

## See Also
 * [KML Data Import]({%slug radmap-features-kml-data-import%})
 * [Shape Reader]({%slug radmap-features-information-layer-shape-reder%})
 * [Colorizer]({%slug radmap-features-colorizer%})