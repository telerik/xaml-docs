---
title: SDK Examples
page_title: SDK Examples
description: SDK Examples
slug: radmap-sdk-examples
tags: sdk,examples
published: True
position: 1
---

# SDK Examples



The [Telerik XAML SDK repository](https://github.com/telerik/xaml-sdk/tree/master/) provides additional demos for most of the Telerik UI for {% if site.site_name == 'WPF' %}WPF{% endif %}{% if site.site_name == 'Silverlight' %}Silverlight{% endif %} controls. The examples demonstrate many specific user case scenarios, that might be really helpful. In this article you can find the complete list of all SDK examples for __RadMap__.

## List of all RadMap SDK examples:{% if site.site_name == 'WPF' %}

* __Click modes custom behavior__ - RadMap supports both single and double mouse clicks. You can configure the behavior of the control in this respect using the MouseClickMode and MouseDoubleClickMode properties. These properties support the following predefined values: Center, None, ZoomPointToCenter, ZoomToPoint. In order to execute custom logic on click or double click, set these properties to None and handle the MapMouseClick and MapMouseDoubleClick events of RadMap.

* __Click modes predefined values__ - RadMap supports both single and double mouse clicks. You can configure the behavior of the control in this respect using the MouseClickMode and MouseDoubleClickMode properties. These properties support the following predefined values: Center, None, ZoomPointToCenter, ZoomToPoint.

* __Default layout disabled__ - The default layout of RadMap is represented by the UI controls that appear in it. In case you want to hide all of these controls and create your custom layout, you can set the UseDefaultLayout property of RadMap to false.

* __Distance and scale distance unit__ - RadMap uses two measure units for distance - mile and kilometer. The measure units determine the placement of the MapShapes, as their width and height are measured in the selected unit. You can specify the unit using the DistanceUnit property of RadMap. The default value is Kilometer.

* __Distance and scale external map scale__ - You can use the MapScale control outside the RadMap control. In order to associate the external MapScale control and the RadMap instance, set the MapControl property of MapScale to the respective RadMap instance. You can configure the RadMap control not to show its default MapScale control using its ScaleVisibility property or the UseDefaultLayout property that disables the default layout of RadMap.

* __Distance and scale scale visibility__ - You can change the Visibility of the MapScale control in the default layout of RadMap using the ScaleVisibility property.

* __Dynamic layer__ - The DynamicLayer allows you to display additional data on top of the displayed map. In contrast to InformationLayer which processes all items in a collection, the DynamicLayer requests items to process. It makes favour when thousands of items are available (pictures of POIs, for example). Your application can select what pictures are suitable for given location and zoom factor and return only these ones.

* __External map mouse location indicator__ - You can use the MapMouseLocationIndicator control outside the RadMap control. In order to associate the external MapMouseLocationIndicator control and the RadMap instance, set the MapControl property of MapMouseLocationIndicator to the respective RadMap instance. You can configure the RadMap control not to show its default MapMouseLocationIndicator control using its MouseLocationIndicatorVisibility property or the UseDefaultLayout property that disables the default layout of RadMap.

* __Geocode__ - The RadMap provides unified geocoding architecture, which uses the functionality of the different geocoding services. This allows you to easily convert a location point to an address and the opposite - address to a location point.

* __How to bring aLocation into view__ - In order to bring a location point into view, you have to set the Center property of the RadMap property.

* __Display Information From Custom Shapefile__ - The ESRI Shapefiles or simply the shapefiles are popular format for storing geographical data. The files spatially describe geometries like lines, polylines and polygons. These geometries may represent different geographical objects such as countries, roads, rivers, lakes etc. Via a software that supports the format, the geometries can be translated properly on a map.

* __Implement Custom Commands For Map Command Bar__ - It is now possible to customize the default set of commands in the MapCommandBar UI for every map provider. Every custom command should be described by a CommandDescription instance that you need to add to the respective MapProvider.Commands collection (if your custom command is RoutedCommand / RoutedUICommand, you can add the associated CommandBinding to the MapProvider.CommandBindingCollection).

* __How to implement custom map provider__ - You can create a custom map provider and use it with RadMap. In order to do this, you should implement a custom provider and custom map source that inherit TiledProvider or ImageProvider and TiledMapSource or ImageMapSource.

* __Implement Custom Zoom Levels For Map Zoom Bar__ - You can customize the default preset zoom levels in the MapZoomBar UI for every map provider. You can add custom zoom level through the MapZoomBar.RegisterSetZoomLevelCommand(zoomLevel, commandText, dataTemplate, imageUri) method.

* __How to put a mark on the clicked location__ - If you want to mark the position where the user has clicked, you have to handle the MapMouseClick event and add the desired mark element to the InformationLayer of the RadMap on the clicked location.

* __Resize Map Shapes With Mouse__ - RadMap provides a rich set of geocoordinate-enabled shapes that can be defined and displayed onto the map surface .There are scenarios, however, where you would like to do more than just position a shape onto the map. This example will demonstrate how to manipulate each individual segment of line/polyline/polygon shape based on mouse input from the user. For example we will select (highlight) a point, and drag the selected object to another location on the map – modifying in this way the shape or the line segment.

* __How to restrict panning and zooming region__ - You can restrict the zooming and panning region in RadMap by setting the RadMap.MinZoomLevel / RadMap.MaxZoomLevel properties and the RadMap.GeoBounds property.

* __How to select map shapes__ - RadMap provides a rich set of geocoordinate-enabled shapes that can be defined and displayed onto the map surface. There are scenarios, however, where you would like to do more than just position a shape onto the map. This example will demonstrate how to manipulate each individual segment of line/polyline/polygon shape based on mouse input from the user. For example we will select (highlight) a Line segment of the Polyline and set a green color for it. The Polyline itself will be colored blue and on click it will become red. All these customizations will be made through styles.

* __Ste The Best View For The Information Layer__ - In case you have a set of elements displayed by the InformationLayer, you might want to be able to display all of them in the visible area of the map and to set the optimal zoom for them. This can be done by using the Best View feature of the RadMap. To use it you have to call the GetBestView() method of the InformationLayer and pass its items to it. This method will return a LocationRect object which represents the best view for the items in the InformationLayer. You can use it in order to adjust the RadMap center and zoom level.

* __Information layer clustered data source__ - Clustered data source provides functionality for grouping of the geographic locations using some criteria. The default implementation uses distance in degrees between 2 locations as grouping condition. It can be changed at any time by creation of the new class which implements IClusterItemGenerator or which inherits from the ClusterItemGenerator class (the default built-in implementation of the grouping condition). The clustered data source provides information layer with 2 kinds of items: ClusterItem and ClusteredItem. The first one represents cluster which contains list of the items grouped by some criteria. The second one represents wrapper around original data with some additional functionality.

* __Information layer colorizer colors__ - The ColorMeasureScale can apply a different color to each range it creates. You are able to specify the desired set of colors not only for the normal fill of the shapes, but for the highlighted one too. This is done by using the ShapeFillCollection and HighlightFillCollection properties. They are collections of MapShapeFill objects.

* __Information layer colorizer mode auto__ - The ColorMeasureScale splits the values passed through its ExtendedPropertyName property and associates a fill color and highlight color for each one. It can automatically create ranges in two ways. For that purpose you have to use the Mode property of the ColorMeasureScale object. This example demonstrates the Auto mode.

* __Information layer colorizer mode count__ - The ColorMeasureScale splits the values passed through its ExtendedPropertyName property and associates a fill color and highlight color for each one. It can automatically create ranges in two ways. For that purpose you have to use the Mode property of the ColorMeasureScale object. This example demonstrates the Count mode.

* __Information layer colorizer mode ranges__ - The ColorMeasureScale splits the values passed through its ExtendedPropertyName property and associates a fill color and highlight color for each one. It can automatically create ranges in two ways. For that purpose you have to use the Mode property of the ColorMeasureScale object. This example demonstrates the Ranges mode.

* __Information Layer Colorizer Mode Ranges__ - The ColorMeasureScale splits the values passed through its ExtendedPropertyName property and associates a fill color and highlight color for each one. It can automatically create ranges in two ways. For that purpose you have to use the Mode property of the ColorMeasureScale object. This example demonstrates the RangesPredefinedColors mode.

* __Information layer colorizer mode step__ - The ColorMeasureScale splits the values passed through its ExtendedPropertyName property and associates a fill color and highlight color for each one. It can automatically create ranges in two ways. For that purpose you have to use the Mode property of the ColorMeasureScale object. This example demonstrates the Step mode.

* __Information Layer Data Binding__ - When displaying a map, you might also want to visualize some data on it in the form of hot spots, pin points, etc. The InformationLayer object allows you to dynamically load and display map markers via data binding. This example demonstrates how you can use attached properties to configure the dynamically created map markers.

* __Information Layer Data Mappings__ - When displaying a map, you might also want to visualize some data on it in the form of hot spots, pin points, etc. The InformationLayer object allows you to dynamically load and display map markers via data binding. This example demonstrates how you can use DataMappings to configure the dynamically created map markers.

* __Information layer framework elements__ - One of the objects that can be displayed inside the InformationLayer is the FrameworkElement. This means that you can actually display anything inside the InformationLayer. If you want to compose more than one control for your element, you just have to wrap them inside one of the layout controls.

* __Information layer graph colorizer__ - The RadMap provides Graph Colorizer which sets filling to the Map shapes using the coloring of graph approach as its name implies. In short when any 2 shapes which have common border they will be colored differently.

* __Information layer hot spots__ - Normally the elements placed in the Information Layer get positioned via Location coordinates. In this way their top-left corner will coincide with the point representing the location. When using FrameworkElements in your InformationLayer you can additionally arrange them around the point via their HorizontalAlignment and VerticalAlignment properties. To adjust the position of the element via the HotSpot you have to set its X and Y properties. Their value can be measured in different units. To choose the desired unit you have to set the XUnits and YUnits properties.

* __Information layer initialize completed__ - The InitializeCompleted event of RadMap fires when the initialization of the map provider completes.

* __Information layer map ellipse__ - The RadMap control provides you with a set of shape objects, which are specifically designed to work with the RadMap. This example demonstrates MapEllipse.

* __Information layer map line__ - The RadMap control provides you with a set of shape objects, which are specifically designed to work with the RadMap. This example demonstrates MapLine.

* __Information layer map path__ - The RadMap control provides you with a set of shape objects, which are specifically designed to work with the RadMap. This example demonstrates MapPath.

* __Information layer map polygon__ - The RadMap control provides you with a set of shape objects, which are specifically designed to work with the RadMap. This example demonstrates MapPolygon.

* __Information layer map polyline__ - The RadMap control provides you with a set of shape objects, which are specifically designed to work with the RadMap. This example demonstrates MapPolyline.

* __Information layer map rectangle__ - The RadMap control provides you with a set of shape objects, which are specifically designed to work with the RadMap. This example demonstrates MapRectangle.

* __Information layer map shape extended data__ - The MapShape object exposes a property called ExtendedData. It allows you to attach additional data to the shape. For example, if a shape represents a country on the map, you can use the ExtendedData property to attach information about the country such as Area, Capitol, Population etc. Later this data can be accessed through the ExtendedData property.

* __Information layer map shape fill__ - The ColorMeasureScale can apply a different color to each range it creates. You are able to specify the desired set of colors not only for the normal fill of the shapes, but for the highlighted one too. This is done by using the ShapeFillCollection and HighlightFillCollection properties. They are collections of MapShapeFill objects.

* __Information layer map shape map shape fill__ - The MapShape objects expose two specific properties - ShapeFill and HightlightFill. The first one is applied to the shapes, when they are in their normal state. The HighlightFill gets applied when the mouse is over the shape. The two properties are of type MapShapeFill. The MapShapeFill object allows you not only to specify the Fill color, but to modify the stroke as well.

* __Information layer map shape properties__ - When using MapShape objects there are several ways to control their appearance. This example demonstrates the trivial properties provided by the framework such as Fill, Stroke, StrokeThickness.

* __Information layer pin points__ - The MapPinPoint class is designed to represent Point objects from KML files. However, it can be also used outside the KML context in order to mark points of interest (POIs) or something else.

* __Information layer unbound mode__ - The InformationLayer allows you to display additional data on top of the displayed map. This data can be in the form of simple framework elements, pin points or map shapes. As the InformationLayer derives from the ItemsControl class you are able to display more than one item in one and the same InformationLayer. You can even data bind the InformationLayer to a collection of locations. This example demonstrates the unbound mode of the InformationLayer.

* __KML manual reading__ - The RadMap provides support for stunning map overlays through its KML-import feature. Once you have the desired set of features (place marks, images, polygons, textual descriptions, etc.) encoded in KML, you can easily import the data and visualize it through the RadMap control. In this way you can easily visualize complex shapes like country's borders on the map and fill the separate shapes with different colors in order to achieve a sort of grouping.The RadMap allows you to manually read the file, by which you are able to get the shapes collection, without to automatically insert it into the layer. For this purpose you have to use the KMLReader static class.

* __KML map shape reader__ - The RadMap provides support for stunning map overlays through its KML-import feature. Once you have the desired set of features (place marks, images, polygons, textual descriptions, etc.) encoded in KML, you can easily import the data and visualize it through the RadMap control. In this way you can easily visualize complex shapes like country's borders on the map and fill the separate shapes with different colors in order to achieve a sort of grouping.To read your data you have to use the MapShapeReader class. To pass the desired KML file you have to use the Source property of the MapShapeReader and pass the Uri to the desired .kml file to it. This will automatically generate shapes according to the data inside the file.

* __Map legend__ - The RadMap control introduces the MapLegend object. It allows you to display a legend for a particular Information Layer inside the RadMap control.

* __Map shape reader tool tip format__ - The ToolTipFormat property of MapShapeReader is the simplest way to create a single-line tooltip. The property is of type string and allow you to display both the value of a single property of the extended data and combination of the values of different extended data properties.

* __Map shape reader tool tip style__ - The ToolTipStyle property of MapShapeReader allows you to specify a Style of the tooltip that gets displayed. The Style should target the ToolTip control.

* __Map shape reader tool tip template__ - The ToolTipTemplate property of MapShapeReader allows you to define a DataTemplate for the tooltip. This way you are able to create more complex layouts like multiline content or content containing different visual elements like Borders, Images etc.

* __Mini map__ - This example demonstrates the Mini Map feature of RadMap.

* __Navigation disabled__ - You can change the Visibility of the MapNavigation control in the default layout of RadMap using the NavigationVisibility property.

* __Navigation external map navigation__ - You can use the MapNavigation control outside the RadMap control. In order to associate the external MapNavigation control and the RadMap instance, set the MapControl property of MapNavigation to the respective RadMap instance. You can configure the RadMap control not to show its default MapNavigation control using its NavigationVisibility property or the UseDefaultLayout property that disables the default layout of RadMap.

* __Providers bing map provider__ - The RadMap control doesn't display a map on itself, it needs a map provider from which to consume the required data. This example demonstrates the BingMapProvider.

* __Providers bing map traffic provider__ - The RadMap control doesn't display a map on itself, it needs a map provider from which to consume the required data. This example demonstrates the BingMapTrafficProvider.

* __Providers empty provider__ - The RadMap control doesn't display a map on itself, it needs a map provider from which to consume the required data. This example demonstrates the EmptyProvider.

* __Providers open street map provider__ - The RadMap control doesn't display a map on itself, it needs a map provider from which to consume the required data. This example demonstrates the OpenStreetMapProvider.

* __Providers uri image provider__ - The RadMap control doesn't display a map on itself, it needs a map provider from which to consume the required data. This example demonstrates the UriImageProvider.

* __Routing__ - The RadMap provides unified route search architecture which uses functionality of the different routing services. This allows you to calculate route between different locations on the map.

* __Search__ - The RadMap control allows you to implement search functionality, that will allow the user to search for a specific location on the map. The search is performed by using Search Providers, which communicate with the respective Map Provider's services. With this feature available you are able to build an UI that allows the user to input search criteria and execute a search.

* __Shapefile manual reading__ - The ESRI Shapefiles or simply the shapefiles are popular format for storing geographical data. The files spatially describe geometries like lines, polylines and polygons. These geometries may represent different geographical objects such as countries, roads, rivers, lakes etc. Via a software that supports the format, the geometries can be translated properly on a map. The RadMap allows you to manually read the file, by which you are able to get the shapes collection, without to automatically insert it into the layer. For this purpose you have to use the ShapeFileReader static class.

* __Shapefile map shape reader__ - The ESRI Shapefiles or simply the shapefiles are popular format for storing geographical data. The files spatially describe geometries like lines, polylines and polygons. These geometries may represent different geographical objects such as countries, roads, rivers, lakes etc. Via a software that supports the format, the geometries can be translated properly on a map. To read your data you have to use the MapShapeReader class. To pass the desired shapefile you have to use the Source property of the MapShapeReader and pass the Uri to the desired .shp file to it.

* __SQL geospatial data__ - RadGeospatialDataReader enables you to bind RadMap to SQL Geospatial data. It allows generating map shapes from any IEnumerable instance (for example a row collection) which contains a property with geospatial data in Wkt (Well known text) or Wkb (Well known binary) format. The Source property and the GeospatialPropertyName propertyare used to specify the IEnumerable instance and the name of the property which contains a Geospatial data.

* __View modes disable command__ - RadMap allows you to bring the map in several view modes. After setting the desired view mode, the user is also capable of changing the view, depending on his/her needs. He/She can do it via the button with the eye-like icon, which represents the command bar. This example demonstrates how you can disable a specific command for a provider, e.g. changing the visibility of the map labels.

* __View modes external map command bar__ - You can use the MapCommandBar control outside the RadMap control. In order to associate the external MapCommandBar control and the RadMap instance, set the MapControl property of MapCommandBar to the respective RadMap instance. You can configure the RadMap control not to show its default MapCommandBar control using its CommandBarVisibility property or the UseDefaultLayout property that disables the default layout of RadMap.

* __View modes setting view mode__ - The RadMap allows you to bring the map in several view modes. After setting the desired view mode, the user is also capable of changing the view, depending on his/her needs. He/She can do it via the button with the eye-like icon, which represents the command bar.

* __Zooming disabled__ - You can change the Visibility of the MapZoomBar control in the default layout of RadMap using the ZoomBarVisibility property.

* __Zooming external map zoom bar__ - You can use the MapZoomBar control outside the RadMap control. In order to associate the external MapZoomBar control and the RadMap instance, set the MapControl property of MapZoomBar to the respective RadMap instance. You can configure the RadMap control not to show its default MapZoomBar control using its ZoomBarVisibility property or the UseDefaultLayout property that disables the default layout of RadMap.

* __Zooming preset with custom label__ - This example demonstrates how you can add a custom zoom level to the MapZoomBar.{% endif %}{% if site.site_name == 'Silverlight' %}

* __Click modes custom behavior__ - RadMap supports both single and double mouse clicks. You can configure the behavior of the control in this respect using the MouseClickMode and MouseDoubleClickMode properties. These properties support the following predefined values: Center, None, ZoomPointToCenter, ZoomToPoint. In order to execute custom logic on click or double click, set these properties to None and handle the MapMouseClick and MapMouseDoubleClick events of RadMap.

* __Click modes predefined values__ - RadMap supports both single and double mouse clicks. You can configure the behavior of the control in this respect using the MouseClickMode and MouseDoubleClickMode properties. These properties support the following predefined values: Center, None, ZoomPointToCenter, ZoomToPoint.

* __Default layout disabled__ - The default layout of RadMap is represented by the UI controls that appear in it. In case you want to hide all of these controls and create your custom layout, you can set the UseDefaultLayout property of RadMap to false.

* __Distance and scale distance unit__ - RadMap uses two measure units for distance - mile and kilometer. The measure units determine the placement of the MapShapes, as their width and height are measured in the selected unit. You can specify the unit using the DistanceUnit property of RadMap. The default value is Kilometer.

* __Distance and scale external map scale__ - You can use the MapScale control outside the RadMap control. In order to associate the external MapScale control and the RadMap instance, set the MapControl property of MapScale to the respective RadMap instance. You can configure the RadMap control not to show its default MapScale control using its ScaleVisibility property or the UseDefaultLayout property that disables the default layout of RadMap.

* __Distance and scale scale visibility__ - You can change the Visibility of the MapScale control in the default layout of RadMap using the ScaleVisibility property.

* __Dynamic layer__ - The DynamicLayer allows you to display additional data on top of the displayed map. In contrast to InformationLayer which processes all items in a collection, the DynamicLayer requests items to process. It makes favour when thousands of items are available (pictures of POIs, for example). Your application can select what pictures are suitable for given location and zoom factor and return only these ones.

* __External map mouse location indicator__ - You can use the MapMouseLocationIndicator control outside the RadMap control. In order to associate the external MapMouseLocationIndicator control and the RadMap instance, set the MapControl property of MapMouseLocationIndicator to the respective RadMap instance. You can configure the RadMap control not to show its default MapMouseLocationIndicator control using its MouseLocationIndicatorVisibility property or the UseDefaultLayout property that disables the default layout of RadMap.

* __Geocode__ - The RadMap provides unified geocoding architecture, which uses the functionality of the different geocoding services. This allows you to easily convert a location point to an address and the opposite - address to a location point.

* __How to bring aLocation into view__ - In order to bring a location point into view, you have to set the Center property of the RadMap property.

* __How to custom commands for map command bar__ - It is now possible to customize the default set of commands in the MapCommandBar UI for every map provider. Every custom command should be described by a CommandDescription instance that you need to add to the respective MapProvider.Commands collection (if your custom command is RoutedCommand / RoutedUICommand, you can add the associated CommandBinding to the MapProvider.CommandBindingCollection).

* __How to custom zoom levels for map zoom bar__ - You can customize the default preset zoom levels in the MapZoomBar UI for every map provider. You can add custom zoom level through the MapZoomBar.RegisterSetZoomLevelCommand(zoomLevel, commandText, dataTemplate, imageUri) method.

* __How to display info from custom shapefile__ - The ESRI Shapefiles or simply the shapefiles are popular format for storing geographical data. The files spatially describe geometries like lines, polylines and polygons. These geometries may represent different geographical objects such as countries, roads, rivers, lakes etc. Via a software that supports the format, the geometries can be translated properly on a map.

* __How to implement custom map provider__ - You can create a custom map provider and use it with RadMap. In order to do this, you should implement a custom provider and custom map source that inherit TiledProvider or ImageProvider and TiledMapSource or ImageMapSource.

* __How to put a mark on the clicked location__ - If you want to mark the position where the user has clicked, you have to handle the MapMouseClick event and add the desired mark element to the InformationLayer of the RadMap on the clicked location.

* __How to resize map shapes with mouse dragging__ - RadMap provides a rich set of geocoordinate-enabled shapes that can be defined and displayed onto the map surface .There are scenarios, however, where you would like to do more than just position a shape onto the map. This example will demonstrate how to manipulate each individual segment of line/polyline/polygon shape based on mouse input from the user. For example we will select (highlight) a point, and drag the selected object to another location on the map – modifying in this way the shape or the line segment.

* __How to restrict panning and zooming region__ - You can restrict the zooming and panning region in RadMap by setting the RadMap.MinZoomLevel / RadMap.MaxZoomLevel properties and the RadMap.GeoBounds property.

* __How to select map shapes__ - RadMap provides a rich set of geocoordinate-enabled shapes that can be defined and displayed onto the map surface. There are scenarios, however, where you would like to do more than just position a shape onto the map. This example will demonstrate how to manipulate each individual segment of line/polyline/polygon shape based on mouse input from the user. For example we will select (highlight) a Line segment of the Polyline and set a green color for it. The Polyline itself will be colored blue and on click it will become red. All these customizations will be made through styles.

* __How to set the best view for information layer__ - In case you have a set of elements displayed by the InformationLayer, you might want to be able to display all of them in the visible area of the map and to set the optimal zoom for them. This can be done by using the Best View feature of the RadMap. To use it you have to call the GetBestView() method of the InformationLayer and pass its items to it. This method will return a LocationRect object which represents the best view for the items in the InformationLayer. You can use it in order to adjust the RadMap center and zoom level.

* __Information layer clustered data source__ - Clustered data source provides functionality for grouping of the geographic locations using some criteria. The default implementation uses distance in degrees between 2 locations as grouping condition. It can be changed at any time by creation of the new class which implements IClusterItemGenerator or which inherits from the ClusterItemGenerator class (the default built-in implementation of the grouping condition). The clustered data source provides information layer with 2 kinds of items: ClusterItem and ClusteredItem. The first one represents cluster which contains list of the items grouped by some criteria. The second one represents wrapper around original data with some additional functionality.

* __Information layer colorizer colors__ - The ColorMeasureScale can apply a different color to each range it creates. You are able to specify the desired set of colors not only for the normal fill of the shapes, but for the highlighted one too. This is done by using the ShapeFillCollection and HighlightFillCollection properties. They are collections of MapShapeFill objects.

* __Information layer colorizer mode auto__ - The ColorMeasureScale splits the values passed through its ExtendedPropertyName property and associates a fill color and highlight color for each one. It can automatically create ranges in two ways. For that purpose you have to use the Mode property of the ColorMeasureScale object. This example demonstrates the Auto mode.

* __Information layer colorizer mode count__ - The ColorMeasureScale splits the values passed through its ExtendedPropertyName property and associates a fill color and highlight color for each one. It can automatically create ranges in two ways. For that purpose you have to use the Mode property of the ColorMeasureScale object. This example demonstrates the Count mode.

* __Information layer colorizer mode ranges__ - The ColorMeasureScale splits the values passed through its ExtendedPropertyName property and associates a fill color and highlight color for each one. It can automatically create ranges in two ways. For that purpose you have to use the Mode property of the ColorMeasureScale object. This example demonstrates the Ranges mode.

* __Information layer colorizer mode step__ - The ColorMeasureScale splits the values passed through its ExtendedPropertyName property and associates a fill color and highlight color for each one. It can automatically create ranges in two ways. For that purpose you have to use the Mode property of the ColorMeasureScale object. This example demonstrates the Step mode.

* __Information layer data binding data mappings__ - When displaying a map, you might also want to visualize some data on it in the form of hot spots, pin points, etc. The InformationLayer object allows you to dynamically load and display map markers via data binding. This example demonstrates how you can use DataMappings to configure the dynamically created map markers.

* __Information layer data binding data template__ - When displaying a map, you might also want to visualize some data on it in the form of hot spots, pin points, etc. The InformationLayer object allows you to dynamically load and display map markers via data binding. This example demonstrates how you can use attached properties to configure the dynamically created map markers.

* __Information layer framework elements__ - One of the objects that can be displayed inside the InformationLayer is the FrameworkElement. This means that you can actually display anything inside the InformationLayer. If you want to compose more than one control for your element, you just have to wrap them inside one of the layout controls.

* __Information layer graph colorizer__ - The RadMap provides Graph Colorizer which sets filling to the Map shapes using the coloring of graph approach as its name implies. In short when any 2 shapes which have common border they will be colored differently.

* __Information layer hot spots__ - Normally the elements placed in the Information Layer get positioned via Location coordinates. In this way their top-left corner will coincide with the point representing the location. When using FrameworkElements in your InformationLayer you can additionally arrange them around the point via their HorizontalAlignment and VerticalAlignment properties. To adjust the position of the element via the HotSpot you have to set its X and Y properties. Their value can be measured in different units. To choose the desired unit you have to set the XUnits and YUnits properties.

* __Information layer initialize completed__ - The InitializeCompleted event of RadMap fires when the initialization of the map provider completes.

* __Information layer map ellipse__ - The RadMap control provides you with a set of shape objects, which are specifically designed to work with the RadMap. This example demonstrates MapEllipse.

* __Information layer map line__ - The RadMap control provides you with a set of shape objects, which are specifically designed to work with the RadMap. This example demonstrates MapLine.

* __Information layer map path__ - The RadMap control provides you with a set of shape objects, which are specifically designed to work with the RadMap. This example demonstrates MapPath.

* __Information layer map polygon__ - The RadMap control provides you with a set of shape objects, which are specifically designed to work with the RadMap. This example demonstrates MapPolygon.

* __Information layer map polyline__ - The RadMap control provides you with a set of shape objects, which are specifically designed to work with the RadMap. This example demonstrates MapPolyline.

* __Information layer map rectangle__ - The RadMap control provides you with a set of shape objects, which are specifically designed to work with the RadMap. This example demonstrates MapRectangle.

* __Information layer map shape extended data__ - The MapShape object exposes a property called ExtendedData. It allows you to attach additional data to the shape. For example, if a shape represents a country on the map, you can use the ExtendedData property to attach information about the country such as Area, Capitol, Population etc. Later this data can be accessed through the ExtendedData property.

* __Information layer map shape fill__ - The ColorMeasureScale can apply a different color to each range it creates. You are able to specify the desired set of colors not only for the normal fill of the shapes, but for the highlighted one too. This is done by using the ShapeFillCollection and HighlightFillCollection properties. They are collections of MapShapeFill objects.

* __Information layer map shape map shape fill__ - The MapShape objects expose two specific properties - ShapeFill and HightlightFill. The first one is applied to the shapes, when they are in their normal state. The HighlightFill gets applied when the mouse is over the shape. The two properties are of type MapShapeFill. The MapShapeFill object allows you not only to specify the Fill color, but to modify the stroke as well.

* __Information layer map shape properties__ - When using MapShape objects there are several ways to control their appearance. This example demonstrates the trivial properties provided by the framework such as Fill, Stroke, StrokeThickness.

* __Information layer pin points__ - The MapPinPoint class is designed to represent Point objects from KML files. However, it can be also used outside the KML context in order to mark points of interest (POIs) or something else.

* __Information layer ranges predefined colors__ - The ColorMeasureScale splits the values passed through its ExtendedPropertyName property and associates a fill color and highlight color for each one. It can automatically create ranges in two ways. For that purpose you have to use the Mode property of the ColorMeasureScale object. This example demonstrates the RangesPredefinedColors mode.

* __Information layer unbound mode__ - The InformationLayer allows you to display additional data on top of the displayed map. This data can be in the form of simple framework elements, pin points or map shapes. As the InformationLayer derives from the ItemsControl class you are able to display more than one item in one and the same InformationLayer. You can even data bind the InformationLayer to a collection of locations. This example demonstrates the unbound mode of the InformationLayer.

* __KML manual reading__ - The RadMap provides support for stunning map overlays through its KML-import feature. Once you have the desired set of features (place marks, images, polygons, textual descriptions, etc.) encoded in KML, you can easily import the data and visualize it through the RadMap control. In this way you can easily visualize complex shapes like country's borders on the map and fill the separate shapes with different colors in order to achieve a sort of grouping.The RadMap allows you to manually read the file, by which you are able to get the shapes collection, without to automatically insert it into the layer. For this purpose you have to use the KMLReader static class.

* __KML map shape reader__ - The RadMap provides support for stunning map overlays through its KML-import feature. Once you have the desired set of features (place marks, images, polygons, textual descriptions, etc.) encoded in KML, you can easily import the data and visualize it through the RadMap control. In this way you can easily visualize complex shapes like country's borders on the map and fill the separate shapes with different colors in order to achieve a sort of grouping.To read your data you have to use the MapShapeReader class. To pass the desired KML file you have to use the Source property of the MapShapeReader and pass the Uri to the desired .kml file to it. This will automatically generate shapes according to the data inside the file.

* __Map legend__ - The RadMap control introduces the MapLegend object. It allows you to display a legend for a particular Information Layer inside the RadMap control.

* __Map shape reader tool tip format__ - The ToolTipFormat property of MapShapeReader is the simplest way to create a single-line tooltip. The property is of type string and allow you to display both the value of a single property of the extended data and combination of the values of different extended data properties.

* __Map shape reader tool tip style__ - The ToolTipStyle property of MapShapeReader allows you to specify a Style of the tooltip that gets displayed. The Style should target the ToolTip control.

* __Map shape reader tool tip template__ - The ToolTipTemplate property of MapShapeReader allows you to define a DataTemplate for the tooltip. This way you are able to create more complex layouts like multiline content or content containing different visual elements like Borders, Images etc.

* __Mini map__ - This example demonstrates the Mini Map feature of RadMap.

* __Navigation disabled__ - You can change the Visibility of the MapNavigation control in the default layout of RadMap using the NavigationVisibility property.

* __Navigation external map navigation__ - You can use the MapNavigation control outside the RadMap control. In order to associate the external MapNavigation control and the RadMap instance, set the MapControl property of MapNavigation to the respective RadMap instance. You can configure the RadMap control not to show its default MapNavigation control using its NavigationVisibility property or the UseDefaultLayout property that disables the default layout of RadMap.

* __Providers bing map provider__ - The RadMap control doesn't display a map on itself, it needs a map provider from which to consume the required data. This example demonstrates the BingMapProvider.

* __Providers bing map traffic provider__ - The RadMap control doesn't display a map on itself, it needs a map provider from which to consume the required data. This example demonstrates the BingMapTrafficProvider.

* __Providers empty provider__ - The RadMap control doesn't display a map on itself, it needs a map provider from which to consume the required data. This example demonstrates the EmptyProvider.

* __Providers open street map provider__ - The RadMap control doesn't display a map on itself, it needs a map provider from which to consume the required data. This example demonstrates the OpenStreetMapProvider.

* __Providers uri image provider__ - The RadMap control doesn't display a map on itself, it needs a map provider from which to consume the required data. This example demonstrates the UriImageProvider.

* __Routing__ - The RadMap provides unified route search architecture which uses functionality of the different routing services. This allows you to calculate route between different locations on the map.

* __Search__ - The RadMap control allows you to implement search functionality, that will allow the user to search for a specific location on the map. The search is performed by using Search Providers, which communicate with the respective Map Provider's services. With this feature available you are able to build an UI that allows the user to input search criteria and execute a search.

* __Shapefile manual reading__ - The ESRI Shapefiles or simply the shapefiles are popular format for storing geographical data. The files spatially describe geometries like lines, polylines and polygons. These geometries may represent different geographical objects such as countries, roads, rivers, lakes etc. Via a software that supports the format, the geometries can be translated properly on a map. The RadMap allows you to manually read the file, by which you are able to get the shapes collection, without to automatically insert it into the layer. For this purpose you have to use the ShapeFileReader static class.

* __Shapefile map shape reader__ - The ESRI Shapefiles or simply the shapefiles are popular format for storing geographical data. The files spatially describe geometries like lines, polylines and polygons. These geometries may represent different geographical objects such as countries, roads, rivers, lakes etc. Via a software that supports the format, the geometries can be translated properly on a map. To read your data you have to use the MapShapeReader class. To pass the desired shapefile you have to use the Source property of the MapShapeReader and pass the Uri to the desired .shp file to it.

* __SQL geospatial data__ - RadGeospatialDataReader enables you to bind RadMap to SQL Geospatial data. It allows generating map shapes from any IEnumerable instance (for example a row collection) which contains a property with geospatial data in Wkt (Well known text) or Wkb (Well known binary) format. The Source property and the GeospatialPropertyName propertyare used to specify the IEnumerable instance and the name of the property which contains a Geospatial data.

* __View modes disable command__ - RadMap allows you to bring the map in several view modes. After setting the desired view mode, the user is also capable of changing the view, depending on his/her needs. He/She can do it via the button with the eye-like icon, which represents the command bar. This example demonstrates how you can disable a specific command for a provider, e.g. changing the visibility of the map labels.

* __View modes external map command bar__ - You can use the MapCommandBar control outside the RadMap control. In order to associate the external MapCommandBar control and the RadMap instance, set the MapControl property of MapCommandBar to the respective RadMap instance. You can configure the RadMap control not to show its default MapCommandBar control using its CommandBarVisibility property or the UseDefaultLayout property that disables the default layout of RadMap.

* __View modes setting view mode__ - The RadMap allows you to bring the map in several view modes. After setting the desired view mode, the user is also capable of changing the view, depending on his/her needs. He/She can do it via the button with the eye-like icon, which represents the command bar.

* __Zooming disabled__ - You can change the Visibility of the MapZoomBar control in the default layout of RadMap using the ZoomBarVisibility property.

* __Zooming external map zoom bar__ - You can use the MapZoomBar control outside the RadMap control. In order to associate the external MapZoomBar control and the RadMap instance, set the MapControl property of MapZoomBar to the respective RadMap instance. You can configure the RadMap control not to show its default MapZoomBar control using its ZoomBarVisibility property or the UseDefaultLayout property that disables the default layout of RadMap.

* __Zooming preset with custom label__ - This example demonstrates how you can add a custom zoom level to the MapZoomBar.{% endif %}

>You can also check the [SDK Samples Browser]({%slug sdk-samples-browser%}) that provides a more convenient approach in exploring and executing the examples in the Telerik XAML SDK repository. The SDK Samples Browser application is available for download from [this link](http://demos.telerik.com/xaml-sdkbrowser/).

# See Also
