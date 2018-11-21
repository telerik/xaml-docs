---
title: Reading Map Shapes
page_title: Reading Map Shapes
description: This article lists the different readers avaialable for the different geospatial data formats. It mainly focuses on the AsyncShapeFileReader, its properties and also on how you can read multiple shape files at once.
slug: radmap-visualization-layer-reading-map-shapes
tags: reading,map,shapes
published: True
position: 6
---

# Reading Map Shapes

The Visualization Layer allows you to read data from several geospatial data formats and wrap it in MapShapeData objects. The currently supported formats are:      

* ESRI shape files.          

* KML files.          

* SQL Geospatial (WKT/WKB).          

In contrast with InformationLayer, the VisualizationLayer allows asynchronous processing of the geospatial data.      

This topic covers the major concepts of the geospatial data reading:      

1. Reading files
1. Specifying a tooltip
1. Clearing the layer
1. Styling the shapes          

## Reading Files

The Visualization Layer reads map shape data using asynchronous map shape data readers:        

* __AsyncShapeFileReader__: reads map shape geometry from the ESRI Shape file (.shp) and extended data from the data file (.dbf).            

* __AsyncKmlReader__: reads map shape geometry and extended data from the KML file.            

	>important Not all KML elements are supported.

* __AsyncSqlGeospatialDataReader__: reads map shape geometry from the WKT/WKB representation.         

> The __AsyncShapeFileReader__ and __AsyncKmlReader__ inherit the [AsyncFileReaderBase](https://docs.telerik.com/devtools/wpf/api/telerik.windows.controls.map.asyncfilereaderbase) abstract class which in turn inherits the [AsyncReaderBase](https://docs.telerik.com/devtools/wpf/api/telerik.windows.controls.map.asyncreaderbase) abstract class, which is the base class for all of the readers mentioned above.

If your application loads a comparatively small number of map shape data, then you can specify the data source directly in XAML as demonstrated in __Example 1__.        

#### __[XAML] Example 1: AsyncShapeFileReader with its source set in xaml__
{{region radmap_visualization_layer_reading_map_shapes_0}}
	<telerik:RadMap x:Name="radMap"
	                ZoomLevel="5"
	                Center="36, -120">
		<telerik:RadMap.Provider>
			<telerik:OpenStreetMapProvider />
		</telerik:RadMap.Provider>
		<telerik:VisualizationLayer x:Name="visualizationLayer">
			<telerik:VisualizationLayer.ShapeFill>
				<telerik:MapShapeFill Fill="#6FDFEFFF"
	                                  Stroke="Blue"
	                                  StrokeThickness="2" />
			</telerik:VisualizationLayer.ShapeFill>
			<telerik:VisualizationLayer.Reader>
				<telerik:AsyncShapeFileReader x:Name="mapShapeDataReader"
	                                          Source="/TestMapFeatures;component/Resources/GeoData/zt06_d00.shp" />
			</telerik:VisualizationLayer.Reader>
		</telerik:VisualizationLayer>
	</telerik:RadMap>
{{endregion}}

In this case the reader starts reading immediately and the loaded shapes will be visible even in the design time. But very often the data source contains numerous map shapes. In this case it is reasonable to perform loading in runtime only and show progress or busy indicator until the process is completed. This is demonstrated in __Examples 2 and 3__.       

#### __[XAML] Example 2: AsyncShapeFileReader with the ProgressChanged and ReadShapeDataCompleted events__
{{region radmap_visualization_layer_reading_map_shapes_1}}
	<telerik:RadBusyIndicator Name="busyIndicator">
		<telerik:RadMap x:Name="radMap"
	                    ZoomLevel="6"
	                    Center="37, -120">
			<telerik:RadMap.Provider>
				<telerik:OpenStreetMapProvider />
			</telerik:RadMap.Provider>
			<telerik:VisualizationLayer x:Name="visualizationLayer">
				<telerik:VisualizationLayer.ShapeFill>
					<telerik:MapShapeFill Fill="#6FDFEFFF"
	                                      Stroke="Blue"
	                                      StrokeThickness="2" />
				</telerik:VisualizationLayer.ShapeFill>
				<telerik:VisualizationLayer.Reader>
					<telerik:AsyncShapeFileReader x:Name="mapShapeDataReader"
	                                              ProgressChanged="OnProgressChanged"
	                                              ReadShapeDataCompleted="OnReadShapeDataCompleted"/>
				</telerik:VisualizationLayer.Reader>
			</telerik:VisualizationLayer>
		</telerik:RadMap>
	</telerik:RadBusyIndicator>
{{endregion}}

#### __[C#] Example 3: Showing a BusyIndicator while the AsyncShapeFileReader is loading shapes__
{{region radmap_visualization_layer_reading_map_shapes_2}}
	public partial class EsriFileReader : UserControl
	{
		public EsriFileReader()
		{
			InitializeComponent();
	
			this.Loaded += this.ExampleLoaded;
		}
	
		private void ExampleLoaded(object sender, RoutedEventArgs e)
		{
			this.busyIndicator.IsIndeterminate = false;
			this.busyIndicator.IsBusy = true;
			this.mapShapeDataReader.Source =  new Uri("/TestMapFeatures;component/Resources/GeoData/zt06_d00.shp", UriKind.Relative);
		}
	
		private void OnProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
		{
			this.busyIndicator.ProgressValue = e.ProgressPercentage;
			if (e.ProgressPercentage >= 100)
			{
				this.busyIndicator.IsIndeterminate = true;
				this.busyIndicator.BusyContent = "Refresh layer";
			}
		}
	
		private void OnReadShapeDataCompleted(object sender, Telerik.Windows.Controls.Map.ReadShapeDataCompletedEventArgs e)
		{
			if (this.busyIndicator != null)
			{
				this.busyIndicator.IsBusy = false;
			}
		}
	}
{{endregion}}

#### __[VB.NET] Example 3: Showing a BusyIndicator while the AsyncShapeFileReader is loading shapes__
{{region radmap_visualization_layer_reading_map_shapes_3}}
	Partial Public Class EsriFileReader
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
	
			AddHandler Me.Loaded, AddressOf Me.ExampleLoaded
		End Sub
	
		Private Sub ExampleLoaded(sender As Object, e As RoutedEventArgs)
			Me.busyIndicator.IsIndeterminate = False
			Me.busyIndicator.IsBusy = True
			Me.mapShapeDataReader.Source = New Uri("/TestMapFeatures;component/Resources/GeoData/zt06_d00.shp", UriKind.Relative)
		End Sub
	
		Private Sub OnProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs)
			Me.busyIndicator.ProgressValue = e.ProgressPercentage
			If e.ProgressPercentage >= 100 Then
				Me.busyIndicator.IsIndeterminate = True
				Me.busyIndicator.BusyContent = "Refresh layer"
			End If
		End Sub
	
		Private Sub OnReadShapeDataCompleted(sender As Object, e As Telerik.Windows.Controls.Map.ReadShapeDataCompletedEventArgs)
			If Me.busyIndicator IsNot Nothing Then
				Me.busyIndicator.IsBusy = False
			End If
		End Sub
	End Class
{{endregion}}

>Sometimes map shape data source can contain extremely large number of the items. In this case you can be faced with insufficient productivity of the WPF/Silverlight rendering engine. If your application is intended to show large number of map shapes, we strongly recommend using items virtualization, which is available out-of-the-box in the VisualizationLayer.   

## AsyncReaderBase events

The events described in this section are available for the AsyncShapeFileReader, AsyncKmlReader and AsyncSqlGeospatialDataReader since they are defined in the AsyncReaderBase class which is inherited by all of them. The example in this section uses the AsyncShapeFileReader for demonstration purposes. 

* __PreviewReadShapeDataCompleted__: Occurs when the reader completes to read shapes.

* __ReadShapeDataCompleted__:  Occurs when the reader completes to read shapes and pass them to target information layer.

* __PreviewReadShapeData__: Occurs each time when a shape data is read. __Example 5__ demonstrates how you can use the PreviewReadShapeData event in order to cancel the loading of the shapes.

	#### __[XAML] Example 4: AsyncShapeFileReader with PreviewReadShapeData event__
	{{region radmap_visualization_layer_reading_map_shapes_4}}
		<telerik:VisualizationLayer.Reader>
			<telerik:AsyncShapeFileReader  x:Name="reader"
										   PreviewReadShapeData="AsyncShapeFileReader_PreviewReadShapeData"/>
		</telerik:VisualizationLayer.Reader>
	{{endregion}}

	#### __[C#] Example 5: Cancel shape loading__
	{{region radmap_visualization_layer_reading_map_shapes_5}}
		private void AsyncShapeFileReader_PreviewReadShapeData(object sender, Telerik.Windows.Controls.Map.PreviewReadShapeDataCompletedEventArgs e)
		{
			if (e.Items.Count > 0)
			{
				var shape = e.Items[0];
	
				// if(....) your condition for cancelling here
	
				this.reader.CancelAsync();
			}
		}
	{{endregion}}

	#### __[VB.NET] Example 5: Cancel shape loading__
	{{region radmap_visualization_layer_reading_map_shapes_6}}
		Private Sub AsyncShapeFileReader_PreviewReadShapeData(ByVal sender As Object, ByVal e As Telerik.Windows.Controls.Map.PreviewReadShapeDataCompletedEventArgs)
			If e.Items.Count > 0 Then
				Dim shape = e.Items(0)

				' if(....) your condition for cancelling here

				Me.reader.CancelAsync()
			End If
		End Sub
	{{endregion}}

* __ProgressChanged__:  Occurs when part of data is read.

## Specifying a tooltip

The asynchronous map shape data readers can use the Extended Data associated with map shape to display it in a tooltip for the respective shape. In order to allow you to configure the tooltip's appearance and content, the readers expose the following properties:        

* __ToolTipFormat__: allows you to specify the format string for the tooltip. This is the simplest way to configure the tooltip, when having a one-line tooltip scenario.            

* __ToolTipStyle__: allows you to apply a Style that targets the ToolTip control.            

* __ToolTipTemplate__: allows you to define a DataTemplate for the tooltip. This one is used when more complex, multi-line and styled tooltip scenarios.            

### ToolTipFormat

Using the ToolTipFormat property is the simplest way to create a single-line tooltip. The property is of type string and allows you to display both the value of a single property of the extended data and combination of the values of different extended data properties.                        

* __Single property value:__

	#### __[XAML] Example 6: Setting the ToolTipFormat of the AsyncShapeFileReader in xaml__
	{{region radmap_visualization_layer_reading_map_shapes_7}}
		<telerik:RadMap x:Name="radMap">
			<telerik:RadMap.Provider>
				<telerik:OpenStreetMapProvider />
			</telerik:RadMap.Provider>
			<telerik:VisualizationLayer x:Name="visualizationLayer">
				<telerik:VisualizationLayer.Reader>
					<telerik:AsyncShapeFileReader DataSource="/TestMapFeatures;component/Resources/GeoData/world.dbf"
												  Source="/TestMapFeatures;component/Resources/GeoData/world.shp"
												  ToolTipFormat="CNTRY_NAME" />
				</telerik:VisualizationLayer.Reader>
			</telerik:VisualizationLayer>
		</telerik:RadMap>
	{{endregion}}

	#### __[C#] Example 7: Setting the ToolTipFormat of the AsyncShapeFileReader in code__
	{{region radmap_visualization_layer_reading_map_shapes_8}}
		this.visualizationLayer.Reader.ToolTipFormat = "CNTRY_NAME";
	{{endregion}}

	#### __[VB.NET] Example 7: Setting the ToolTipFormat of the AsyncShapeFileReader in code__
	{{region radmap_visualization_layer_reading_map_shapes_9}}
		Me.visualizationLayer.Reader.ToolTipFormat = "CNTRY_NAME"
	{{endregion}}

	
	#### Figure 1: Result from Example 6
	![radmap-visualization-layer-reading-map-shapes-0](images/radmap-visualization-layer-reading-map-shapes-0.png)

* __Formatted property value:__

	>Note that in this case the format string begins with "{}". This escapes the following {PropertyName} expressions. In code behind you don't need to add it to the actual format string.              

	#### __[XAML] Example 8: Setting the ToolTipFormat of the AsyncShapeFileReader to a formatted property in xaml__
	{{region radmap_visualization_layer_reading_map_shapes_10}}
		<telerik:RadMap x:Name="radMap">
			<telerik:RadMap.Provider>
				<telerik:OpenStreetMapProvider />
			</telerik:RadMap.Provider>
			<telerik:VisualizationLayer x:Name="visualizationLayer">
				<telerik:VisualizationLayer.Reader>
					<telerik:AsyncShapeFileReader DataSource="/TestMapFeatures;component/Resources/GeoData/world.dbf"
												  Source="/TestMapFeatures;component/Resources/GeoData/world.shp"
												  ToolTipFormat="{}{SQKM|F2}" />
				</telerik:VisualizationLayer.Reader>
			</telerik:VisualizationLayer>
		</telerik:RadMap>
	{{endregion}}

	#### __[C#] Example 9: Setting the ToolTipFormat of the AsyncShapeFileReader to a formatted property in code__
	{{region radmap_visualization_layer_reading_map_shapes_11}}
		this.visualizationLayer.Reader.ToolTipFormat = "{SQKM|F2}";
	{{endregion}}

	#### __[VB.NET] Example 9: Setting the ToolTipFormat of the AsyncShapeFileReader to a formatted property in code__
	{{region radmap_visualization_layer_reading_map_shapes_12}}
		Me.visualizationLayer.Reader.ToolTipFormat = "{SQKM|F2}"
	{{endregion}}

	#### Figure 2: Result from Example 8
	![radmap-visualization-layer-reading-map-shapes-1](images/radmap-visualization-layer-reading-map-shapes-1.png)

* __Multiple formatted property values:__

	#### __[XAML] Example 10: Setting the ToolTipFormat of the AsyncShapeFileReader to a complex format in xaml__
	{{region radmap_visualization_layer_reading_map_shapes_13}}
		<telerik:RadMap x:Name="radMap">
			<telerik:RadMap.Provider>
				<telerik:OpenStreetMapProvider />
			</telerik:RadMap.Provider>
			<telerik:VisualizationLayer x:Name="visualizationLayer">
				<telerik:VisualizationLayer.Reader>
					<telerik:AsyncShapeFileReader DataSource="/TestMapFeatures;component/Resources/GeoData/world.dbf"
												  Source="/TestMapFeatures;component/Resources/GeoData/world.shp"
												  ToolTipFormat="{}{CNTRY_NAME} - {SQKM|#,#.0} sq. km." />
				</telerik:VisualizationLayer.Reader>
			</telerik:VisualizationLayer>
		</telerik:RadMap>
	{{endregion}}

	#### __[C#] Example 11: Setting the ToolTipFormat of the AsyncShapeFileReader to a complex format in code__
	{{region radmap_visualization_layer_reading_map_shapes_14}}
		this.visualizationLayer.Reader.ToolTipFormat = "{CNTRY_NAME} - {SQKM|#,#.0} sq. km.";
	{{endregion}}

	#### __[VB.NET] Example 11: Setting the ToolTipFormat of the AsyncShapeFileReader to a complex format in code__
	{{region radmap_visualization_layer_reading_map_shapes_15}}
		Me.visualizationLayer.Reader.ToolTipFormat = "{CNTRY_NAME} - {SQKM|#,#.0} sq. km."
	{{endregion}}

	#### Figure 3: Result from Example 10
	![radmap-visualization-layer-reading-map-shapes-2](images/radmap-visualization-layer-reading-map-shapes-2.png)

### ToolTipTemplate

The ToolTipTemplate property allows you to define a DataTemplate for the tooltip. This way you are able to create more complex layouts like multiline content or content containing different visual elements like Borders, Images etc.            

__In this case the DataTemplate takes as DataContext the entire Extended Data Set.__ To get a specific value you have to bind to the Data property and use an indexer or converter to access the desired attribute. The RadMap provides such converter out of the box. It is represented by the ExtendedDataConverter. To use it just bind to the extended data set and pass the desired attribute name as parameter. This is demonstrated in __Example 12__.            

>The ToolTipTemplate property will take precedence over the ToolTipFormat one.              

#### __[XAML] Example 12: AsyncShapeFileReader with ToolTipTemplate __
{{region radmap_visualization_layer_reading_map_shapes_16}}
	<UserControl x:Class="TestMapFeatures.Views.VisualizationLayer.Readers.SpecifyTooltipTemplate"
	             xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
	             xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
				 xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"
	             xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006" 
	             xmlns:d="http://schemas.microsoft.com/expression/blend/2008" 
	             mc:Ignorable="d" 
	             d:DesignHeight="600" d:DesignWidth="600">
		<UserControl.Resources>
			<telerik:ExtendedDataConverter x:Key="ExtendedDataConverter" />
			
			<DataTemplate x:Key="TooltipTemplate">
				<Grid>
					<Grid.ColumnDefinitions>
						<ColumnDefinition Width="Auto" />
						<ColumnDefinition Width="Auto" />
					</Grid.ColumnDefinitions>
					<Grid.RowDefinitions>
						<RowDefinition Height="Auto" />
						<RowDefinition Height="Auto" />
						<RowDefinition Height="Auto" />
					</Grid.RowDefinitions>
	
					<TextBlock Grid.Column="0" Grid.Row="0" Text="Name:" />
					<TextBlock Grid.Column="1" Grid.Row="0"
							   FontWeight="Bold"
							   Text="{Binding Path=Data[CNTRY_NAME]}" />
	
					<TextBlock Grid.Column="0" Grid.Row="1" Text="Area (KM):" />
					<TextBlock Grid.Column="1" Grid.Row="1"
							   Text="{Binding Path=Data, Converter={StaticResource ExtendedDataConverter}, ConverterParameter='\{SQKM|#,#.0\}'}" />
	
					<TextBlock Grid.Column="0" Grid.Row="2" Grid.ColumnSpan="2"
							   Text="{Binding Path=Data[Area (MI) \=\{SQMI|F1\} Population\=\{POP_CNTRY|F0\}]}" />
				</Grid>
			</DataTemplate>
		</UserControl.Resources>
		<Grid>
			<telerik:RadBusyIndicator Name="busyIndicator">
				<telerik:RadMap x:Name="radMap"
	                            ZoomLevel="2"
	                            Center="0, 0">
					<telerik:RadMap.Provider>
						<telerik:OpenStreetMapProvider />
					</telerik:RadMap.Provider>
					<telerik:VisualizationLayer x:Name="visualizationLayer">
						<telerik:VisualizationLayer.Reader>
							<telerik:AsyncShapeFileReader DataSource="/TestMapFeatures;component/Resources/GeoData/world.dbf"
	                                                      Source="/TestMapFeatures;component/Resources/GeoData/world.shp"
	                                                      ToolTipTemplate="{StaticResource TooltipTemplate}">
							</telerik:AsyncShapeFileReader>
						</telerik:VisualizationLayer.Reader>
					</telerik:VisualizationLayer>
				</telerik:RadMap>
			</telerik:RadBusyIndicator>
		</Grid>
	</UserControl>
{{endregion}}

#### Figure 4: Result from Example 12
![radmap-visualization-layer-reading-map-shapes-3](images/radmap-visualization-layer-reading-map-shapes-3.png)

### ToolTipStyle

The ToolTipStyle property allows you to specify a Style of the tooltip that gets displayed. The Style should target the ToolTip control.   

#### __[XAML] Example 13: AsyncShapeFileReader with ToolTipTemplate and ToolTipStyle__
{{region radmap_visualization_layer_reading_map_shapes_17}}
	<UserControl x:Class="TestMapFeatures.Views.VisualizationLayer.Readers.SpecifyTooltipTemplate"
	             xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
	             xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
				 xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"
	             xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006" 
	             xmlns:d="http://schemas.microsoft.com/expression/blend/2008" 
	             mc:Ignorable="d" 
	             d:DesignHeight="600" d:DesignWidth="600">
		<UserControl.Resources>
			<telerik:ExtendedDataConverter x:Key="ExtendedDataConverter" />
			
			<DataTemplate x:Key="TooltipTemplate">
				<Grid>
					<Grid.ColumnDefinitions>
						<ColumnDefinition Width="Auto" />
						<ColumnDefinition Width="Auto" />
					</Grid.ColumnDefinitions>
					<Grid.RowDefinitions>
						<RowDefinition Height="Auto" />
						<RowDefinition Height="Auto" />
						<RowDefinition Height="Auto" />
					</Grid.RowDefinitions>
	
					<TextBlock Grid.Column="0" Grid.Row="0" Text="Name:" />
					<TextBlock Grid.Column="1" Grid.Row="0"
							   FontWeight="Bold"
							   Text="{Binding Path=Data[CNTRY_NAME]}" />
	
					<TextBlock Grid.Column="0" Grid.Row="1" Text="Area (KM):" />
					<TextBlock Grid.Column="1" Grid.Row="1"
							   Text="{Binding Path=Data, Converter={StaticResource ExtendedDataConverter}, ConverterParameter='\{SQKM|#,#.0\}'}" />
	
					<TextBlock Grid.Column="0" Grid.Row="2" Grid.ColumnSpan="2"
							   Text="{Binding Path=Data[Area (MI) \=\{SQMI|F1\} Population\=\{POP_CNTRY|F0\}]}" />
				</Grid>
			</DataTemplate>
	
			<Style x:Key="ShapeTooltipStyle" TargetType="ToolTip">
				<Setter Property="BorderBrush"
						Value="Blue" />
				<Setter Property="Background"
						Value="#FFDFEFFF" />
				<Setter Property="Foreground"
						Value="OrangeRed" />
			</Style>
	
		</UserControl.Resources>
		<Grid>
			<telerik:RadBusyIndicator Name="busyIndicator">
				<telerik:RadMap x:Name="radMap"
	                            ZoomLevel="2"
	                            Center="0, 0">
					<telerik:RadMap.Provider>
						<telerik:OpenStreetMapProvider />
					</telerik:RadMap.Provider>
					<telerik:VisualizationLayer x:Name="visualizationLayer">
						<telerik:VisualizationLayer.Reader>
							<telerik:AsyncShapeFileReader DataSource="/TestMapFeatures;component/Resources/GeoData/world.dbf"
	                                                      Source="/TestMapFeatures;component/Resources/GeoData/world.shp"
	                                                      ToolTipTemplate="{StaticResource TooltipTemplate}"
	                                                      ToolTipStyle="{StaticResource ShapeTooltipStyle}">
							</telerik:AsyncShapeFileReader>
						</telerik:VisualizationLayer.Reader>
					</telerik:VisualizationLayer>
				</telerik:RadMap>
			</telerik:RadBusyIndicator>
		</Grid>
	</UserControl>
{{endregion}}

#### Figure 5: Result from Example 13
![radmap-visualization-layer-reading-map-shapes-4](images/radmap-visualization-layer-reading-map-shapes-4.png)

## Reading multiple files

There are many scenarios when it is necessary to read multiple shape files into one layer. The AsyncShapeFileReader and AsyncKmlReader have an ability to specify several sources to read in one process. To specify every single file to read you should use AsyncReaderSourceobject as demonstrated in __Example 14__.   

#### __[XAML] Example 14: Reading multiple shape files with AsyncShapeFileReader in xaml__
{{region radmap_visualization_layer_reading_map_shapes_18}}
	<telerik:RadMap x:Name="radMap"
	                ZoomLevel="6"
	                Center="37, -120">
		<telerik:RadMap.Provider>
			<telerik:EmptyProvider />
		</telerik:RadMap.Provider>
		<telerik:VisualizationLayer x:Name="visualizationLayer">
			<telerik:VisualizationLayer.ShapeFill>
				<telerik:MapShapeFill Fill="#6FDFEFFF"
	                                  Stroke="Blue"
	                                  StrokeThickness="2" />
			</telerik:VisualizationLayer.ShapeFill>
			<telerik:VisualizationLayer.Reader>
				<telerik:AsyncShapeFileReader x:Name="mapShapeDataReader">
					<telerik:AsyncReaderSource Source="/TestMapFeatures;component/Resources/GeoData/Hotel/Hotel_base.shp" />
					<telerik:AsyncReaderSource Source="/TestMapFeatures;component/Resources/GeoData/Hotel/Hotel_Corridors.shp" />
					<telerik:AsyncReaderSource Source="/TestMapFeatures;component/Resources/GeoData/Hotel/Hotel_ServiceRooms.shp" />
					<telerik:AsyncReaderSource Source="/TestMapFeatures;component/Resources/GeoData/Hotel/Hotel_LiftsAndLadders.shp" />
					<telerik:AsyncReaderSource Source="/TestMapFeatures;component/Resources/GeoData/Hotel/Hotel_Rooms.shp" />
				</telerik:AsyncShapeFileReader>
			</telerik:VisualizationLayer.Reader>
		</telerik:VisualizationLayer>
	</telerik:RadMap>
{{endregion}}

#### __[C#]  Example 15: Reading multiple shape files with AsyncShapeFileReader in code__
{{region radmap_visualization_layer_reading_map_shapes_19}}
	this.mapShapeDataReader.SourceCollection.Add(
		new AsyncReaderSource()
		{
			Source = new Uri("/TestMapFeatures;component/Resources/GeoData/Hotel/Hotel_base.shp", UriKind.RelativeOrAbsolute)
		});
	this.mapShapeDataReader.SourceCollection.Add(
		new AsyncReaderSource()
		{
			Source = new Uri("/TestMapFeatures;component/Resources/GeoData/Hotel/Hotel_Corridors.shp", UriKind.RelativeOrAbsolute)
		});
	this.mapShapeDataReader.SourceCollection.Add(
		new AsyncReaderSource()
		{
			Source = new Uri("/TestMapFeatures;component/Resources/GeoData/Hotel/Hotel_ServiceRooms.shp", UriKind.RelativeOrAbsolute)
		});
	this.mapShapeDataReader.SourceCollection.Add(
		new AsyncReaderSource()
		{
			Source = new Uri("/TestMapFeatures;component/Resources/GeoData/Hotel/Hotel_LiftsAndLadders.shp", UriKind.RelativeOrAbsolute)
		});
	this.mapShapeDataReader.SourceCollection.Add(
		new AsyncReaderSource()
		{
			Source = new Uri("/TestMapFeatures;component/Resources/GeoData/Hotel/Hotel_Rooms.shp", UriKind.RelativeOrAbsolute)
		});
	
	this.mapShapeDataReader.ReadAsync();
{{endregion}}

#### __[VB.NET] Example 15: Reading multiple shape files with AsyncShapeFileReader in code__
{{region radmap_visualization_layer_reading_map_shapes_20}}
	Me.mapShapeDataReader.SourceCollection.Add( _
		New AsyncReaderSource() With _
		{
			.Source = New Uri("/TestMapFeatures;component/Resources/GeoData/Hotel/Hotel_base.shp", UriKind.RelativeOrAbsolute) _
		})
	Me.mapShapeDataReader.SourceCollection.Add( _
		New AsyncReaderSource() With _
		{
			.Source = New Uri("/TestMapFeatures;component/Resources/GeoData/Hotel/Hotel_Corridors.shp", UriKind.RelativeOrAbsolute) _
		})
	Me.mapShapeDataReader.SourceCollection.Add( _
		New AsyncReaderSource() With _
		{
			.Source = New Uri("/TestMapFeatures;component/Resources/GeoData/Hotel/Hotel_ServiceRooms.shp", UriKind.RelativeOrAbsolute) _
		})
	Me.mapShapeDataReader.SourceCollection.Add( _
		New AsyncReaderSource() With _
		{
			.Source = New Uri("/TestMapFeatures;component/Resources/GeoData/Hotel/Hotel_LiftsAndLadders.shp", UriKind.RelativeOrAbsolute) _
		})
	Me.mapShapeDataReader.SourceCollection.Add( _
		New AsyncReaderSource() With _
		{
			.Source = New Uri("/TestMapFeatures;component/Resources/GeoData/Hotel/Hotel_Rooms.shp", UriKind.RelativeOrAbsolute) _
		})
	
	Me.mapShapeDataReader.ReadAsync()
{{endregion}}

## Clearing the Layer

When adding the read shapes to the layer, the reader is able to clear it first. This means that all previously added shapes will get removed and the new ones will be added. This behavior is controlled by the ClearLayer property of the reader. Its default value is “True”. This means that the described behavior will be active by default. To disable it set the property to “False”.        

## Styling the Shapes

To modify the appearance of the shapes in terms of Fill, Stroke etc. You can either use the HighlightFill, ShapeFill or SelectedFill properties of the VisualizationLayer or use the __Colorizer__ property of the VisualizationLayer.
