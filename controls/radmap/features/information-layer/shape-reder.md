---
title: Shape Reader
page_title: Shape Reader
description: Check our &quot;Shape Reader&quot; documentation article for the RadMap {{ site.framework_name }} control.
slug: radmap-features-information-layer-shape-reder
tags: shape,reader
published: True
position: 8
---

# Shape Reader

The __RadMap__ allows you to read data from several data formats and wrap it in __MapShape__ objects. The currently supported formats are:

* [KML Data]({%slug radmap-features-kml-data-import%})

* [Shapefile Data]({%slug radmap-features-shapefiles-support%})

This topic will explain the following:

* [Reading Files](#reading-files)

* [Specifying a Tooltip](#specifying-a-tooltip)

* [Clearing the Layer](#clearing-the-layer)

* [Styling the Shapes](#styling-the-shapes)

## Reading Files

The __RadMap__ control supports the visualization of __ESRI Shapefiles__ and KML Data. It reads the data via the __MapShapeReader__ class implemented in the __Information Layer__.


<snippet id='radmap-features-information-layer-shape-reder-block_1-xaml' />


<snippet id='radmap-features-information-layer-shape-reder-block_2-cs' />
<snippet id='radmap-features-information-layer-shape-reder-block_2-vb' />

To specify the type of the data the reader should read use the __SourceType__ property of the __MapShapeReader__ class. It can have the following values:

* __Auto__ - automatically determines the type of the data.

* __KML__ - specifies that the file to be read, contains KML Data.

* __Shapefile__ - specifies that the file to be read contains Shapefile data.

To learn how to specify the files for each of the types read the respective topics:

* [KML Data Import]({%slug radmap-features-kml-data-import%})

* [Shapefiles Support]({%slug radmap-features-shapefiles-support%})

## Specifying a Tooltip

The __MapShapeReader__ object can use the data in the .dbf file and display it in a tooltip for the respective shape. In order to allow you to configure the tooltip's appearance and content, The __MapShapeReader__ class exposes the following properties:        

* [ToolTipFormat](#tooltipformat) - allows you to specify the format string for the tooltip. This is the simplest way to configure the tooltip, when having a one-line tooltip scenario.

* [ToolTipStyle](#tooltipstyle) - allows you to apply a Style that targets the ToolTip control.

* [ToolTipTemplate](#tooltiptemplate) - allows you to define a DataTemplate for the tooltip. This one is used when more complex, multiline and styled tooltip scenarios.

## ToolTipFormat

Using the __ToolTipFormat__ property is the simplest way to create a single-line tooltip. The property is of type string and allow you to display both the value of a single property of the extended data and combination of the values of different extended data properties.        

>tip To access the value of an extended data property use its name.

Here is an examples for different __ToolTipFormat__ values.        

## Single property value 


<snippet id='radmap-features-information-layer-shape-reder-block_3-xaml' />


<snippet id='radmap-features-information-layer-shape-reder-block_4-cs' />
<snippet id='radmap-features-information-layer-shape-reder-block_4-vb' />

Here is a snapshot of the result:

![{{ site.framework_name }} RadMap Shape Reader Tooltip Format](images/RadMap_Shapefiles_01.png)

## Formatted property value

>Note that in this case the format string begins with "__{}__". This escapes the following __{PropertyName}__ expressions. In code behind you mustn't add it to the actual format string.


<snippet id='radmap-features-information-layer-shape-reder-block_5-xaml' />
    

<snippet id='radmap-features-information-layer-shape-reder-block_6-cs' />
<snippet id='radmap-features-information-layer-shape-reder-block_6-vb' />
    
Here is a snapshot of the result:

![{{ site.framework_name }} RadMap Shape Reader Tooltip Format Custom](images/RadMap_Shapefiles_02.png)

## Multiple formatted property values

>Note that in this case the format string begins with "__{}__". This escapes the following __{PropertyName}__ expressions. In code behind you mustn't add it to the actual format string.


<snippet id='radmap-features-information-layer-shape-reder-block_7-xaml' />


<snippet id='radmap-features-information-layer-shape-reder-block_8-cs' />
<snippet id='radmap-features-information-layer-shape-reder-block_8-vb' />

Here is a snapshot of the result:

![{{ site.framework_name }} RadMap Shape Reader Tooltip Format Multiple Values](images/RadMap_Shapefiles_03.png)

## ToolTipStyle

The __ToolTipStyle__ property allows you to specify a Style of the tooltip that gets displayed. The Style should target the ToolTip control. Here is an example.

>tip To learn how to modify the color of the shapes like on the snapshot below, you have to read the [Styling the Shapes](#styling-the-shapes) section.


<snippet id='radmap-features-information-layer-shape-reder-block_9-xaml' />

Here is a snapshot of the result:

![{{ site.framework_name }} RadMap Shape Reader Tooltip Style](images/RadMap_Shapefiles_04.png)

## ToolTipTemplate

The __ToolTipTemplate__ property allows you to define a __DataTemplate__ for the tooltip. This way you are able to create more complex layouts like multiline content or content containing different visual elements like __Borders__, __Images__ etc.

In this case the __DataTemplate__ takes as __DataContext__ the entire Extended Data Set. To get a specific value you have to bind to it and use a converter to access the desired attribute. The __RadMap__ provides such converter out of the box. It is represented by the __ExtendedDataConverter__. To use it just bind to the extended data set and pass the desired attribute name as parameter. Here is an example.

>The __ToolTipTemplate__ property will take precedence over the __ToolTipFormat__ one.


<snippet id='radmap-features-information-layer-shape-reder-block_10-xaml' />

Here is a snapshot of the result:

![{{ site.framework_name }} RadMap Shape Reader Tooltip Template](images/RadMap_Shapefiles_05.png)

## Clearing the Layer

When adding the read shapes to the layer, the __MapShapeReader__ is able to clear it first. This means that all previously added shapes will get removed and the new ones will be added. This behavior is controled by the __ClearLayer__ property of the __MapShapeLayer__. It's default value is __True__. This means that the described behavior will be active by default. To disable it set the property to __False__.

## Styling the Shapes

To modify the appearance of the shapes in terms of __Fill__, __Stroke__ etc. you can either use the HighlightFill and Shape Fill properties of the __InformationLayer__ or use the [Colorizer]({%slug radmap-features-colorizer%}) property of the __InformationLayer__.

## See Also
 * [Shapefiles Support]({%slug radmap-features-shapefiles-support%})
 * [KML Data Import]({%slug radmap-features-kml-data-import%})
 * [Colorizer]({%slug radmap-features-colorizer%})
 * [Map Legend]({%slug radmap-features-map-legend%})