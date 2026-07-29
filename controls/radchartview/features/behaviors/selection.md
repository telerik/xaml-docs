---
title: Selection
page_title: Selection - ChartView - Behaviors
description: Check our &quot;Selection&quot; documentation article for the RadChartView {{ site.framework_name }} control.
slug: radchartview-features-selection
tags: selection
published: True
position: 3
---

# Selection

The chart selection behavior enables interactions with the data point visual elements.

If the feature is enabled, clicking on a data point will select or deselect it, based on the selection mode and the current selection state of the point. There is no default visual feedback for the selection. This article shows how to use the selection behavior, enable the visual feedback and customize it.

To enable the selection, add a __ChartSelectionBehavior__ element in the __Behaviors__ collection of the chart control. The following example shows how to create a sample data binding setup and enable the feature.

__Example 1: Define the data point model__
<snippet id='radchartview-features-behaviors-selection-example_1_define_the_data_point_model-cs' />


__Example 2: Populating with data__
<snippet id='radchartview-features-behaviors-selection-example_2_populating_with_data-cs' />


__Example 3: Using the ChartSelectionBehavior__
<snippet id='radchartview-features-behaviors-selection-example_3_using_the_chartselectionbehavior-xaml' />


#### Figure 1: Selected data point
![{{ site.framework_name }} RadChartView Selected data point](images/radchartview-features-selection-0.png)

The selected data points can be accessed using the __Selected

## Visual Feedback

By default selecting a data point doesn't highlight it on the plot area. To enable this, you can use the chart [palettes]({%slug radchartview-features-palettes-introduction%}). The __Palette__ property of the chart defines the fill color of the data points. The __SelectionPalette__ property defines the colors of the data points when selected.

__Example 4: Setting the selection palette__
<snippet id='radchartview-features-behaviors-selection-example_4_setting_the_selection_palette-xaml' />


#### Figure 2: Palette based selection coloring
![{{ site.framework_name }} RadChartView Palette based selection coloring](images/radchartview-features-selection-1.png)

To define selection colors different than the ones provided by the predefined palettes, you can create a [custom palette]({%slug radchartview-features-palettes-custom-palettes%}) and assign it to the SelectionPalette property of the chart. Or alternatively, use the [DefaultVisualStyle or PointTemplate]({%slug radchartview-styles-and-templates-customizing-cartesianchart-series%}) of the chart series. 

The following example shows one way to change the selected point's background using a __PointTemplate__. In this case the palette won't be used so there is no need to set the palette propreties.

__Example 5: Customizing the data point visual__
<snippet id='radchartview-features-behaviors-selection-example_5_customizing_the_data_point_visual-xaml' />


The __data context__ of the element in the __PointTemplate__ is an object of type [DataPoint]({%slug radchartview-getting-started-data-point%})

#### Figure 3: PointTemplate based selection coloring
![{{ site.framework_name }} RadChartView PointTemplate based selection coloring](images/radchartview-features-selection-2.png)

An additional way of customizing the selection's visual feedback is to data bind the color property of the default visual element (via DefaultVisualStyle) or the element in the PointTemplate. Then update the underlying property in case the selection changes, using the [SelectionChanged](#events) event of the ChartSelectionBehavior.

## Selection Mode

ChartSelectionBehavior supports two selection modes - __Single__ (default) and __Multiple__. Also, there is a __None__ selection mode which disables the selection.

When the __Single__ mode is used, the click on a data point selects it. If a data point was previously selected, it gets deselected.

When the __Multiple__ mode is used, the click on a data point includes it in the selection. Multiple data points are selected. A click on a selected data point will deselect it.

The selection mode is controlled with the __DataPointSelectionMode__ property of ChartSelectionBehavior.

__Example 6: Setting DataPointSelectionMode__
<snippet id='radchartview-features-behaviors-selection-example_6_setting_datapointselectionmode-xaml' />


#### Figure 4: Multiple selection
![{{ site.framework_name }} RadChartView Multiple selection](images/radchartview-features-selection-3.png)

## Hit Test Area

The hit test area is the space in the data point visual where you can click to select it. By default the area matches the layout slot (position and size) of the data point visual. 

To change expand the size of the hit test area, set the __HitTestMargin__ property of ChartSelectionBehavior. This is useful when showing small data point visuals that are hard to click.

__Example 7: Setting HitTestMargin__
<snippet id='radchartview-features-behaviors-selection-example_7_setting_hittestmargin-xaml' />


## Events

ChartSelectionBehavior exposes the __SelectionChanged__ event which is raised when a data point is selected or deselected.

__Example 8: Subscribing to SelectionChanged__
<snippet id='radchartview-features-behaviors-selection-example_8_subscribing_to_selectionchanged-xaml' />


__Example 9: SelectionChanged event handler__
<snippet id='radchartview-features-behaviors-selection-example_9_selectionchanged_event_handler-cs' />


## Programmatic Selection

To get the selected data points, use the __SelectedPoints__ collection of the chart control. The collection is read-only, so it cannot be replaced, data bound or modified.

__Example 10: Getting the selected data points__
<snippet id='radchartview-features-behaviors-selection-example_10_getting_the_selected_data_points-cs' />


To select or deselect a data point, set the __IsSelected__ property of the corresponding [DataPoint]({%slug radchartview-getting-started-data-point%}) object. 

__Example 11: Selecting a data point from a PointSeries__
<snippet id='radchartview-features-behaviors-selection-example_11_selecting_a_data_point_from_a_pointseries-cs' />


>tip See how to implement a custom behavior allowing SelectedPoints data binding in the [BindingSelectedItemsToViewModel](https://github.com/telerik/xaml-sdk/tree/master/ChartView/WPF/BindingSelectedItemsToViewModel) SDK example.

## See Also  
* [Create Data-Bound Chart]({%slug radchartview-series-databinding%}) 