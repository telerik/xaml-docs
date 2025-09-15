---
title: Adding Custom Icon Marker on Click in RadMap with VisualizationLayer
description: Add custom visual element on the clicked location in RadMap via VisualizationLayer and handling the MapMouseClick event.
type: how-to
page_title: Show Custom Pin in VisualizationLayer on the Click Point in RadMap WPF
slug: kb-map-add-icon-on-map-click
tags: radmap, wpf, visualizationlayer, mapmouseclick, mouseclickmode, glyph, radglyph
res_type: kb
category: knowledge-base
ticketid: 1653308
---

## Environment

| Property | Value |
| --- | --- |
| Product | Progress® Telerik® RadMap for WPF |
| Version | 2022.2.621 |

## Description

How to add a custom marker in RadMap for WPF on the clicked location.

## Solution

To place a custom icon as a marker on a clicked location in RadMap, you can subscribe to `MapMouseClick` event of `RadMap`. In the event handler, you can add the clicked location (or a custom object) in the `Items` collection of a [VisualizationLayer]({%slug radmap-visualization-layer-introduction%}) added to the map.

To customize the marker visual, you can use the `ItemTemplate` of the `VisualizationLayer`.

__Defining the RadMap element__
```XAML
	<telerik:RadMap x:Name="radMap"
					MapMouseClick="RadMap_MapMouseClick"
					MouseClickMode="None">
		<telerik:RadMap.Provider>
			<telerik:ArcGisMapProvider />
		</telerik:RadMap.Provider>
		<telerik:VisualizationLayer x:Name="layer">
			<telerik:VisualizationLayer.ItemTemplate>
				<DataTemplate>
					<telerik:RadGlyph Glyph="&#xe303;"
									  telerik:MapLayer.Location="{Binding}"
									  Foreground="Green"
									  FontSize="24"/>
				</DataTemplate>
			</telerik:VisualizationLayer.ItemTemplate>
		</telerik:VisualizationLayer>
	</telerik:RadMap>
```


__Implementing the click logic__
```C#
	private void RadMap_MapMouseClick(object sender, Telerik.Windows.Controls.Map.MapMouseRoutedEventArgs eventArgs)
	{
		this.layer.Items.Clear();
		this.layer.Items.Add(eventArgs.Location);
	}
```
