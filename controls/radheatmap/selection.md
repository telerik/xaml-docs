---
title: Selection
page_title: Selection
description: Selection
slug: radheatmap-selection
tags: Selection
published: True
position: 5
---

# Selection

The RadHeatMap control allows you to select its cells visually. A border around the cell represents this functionality, and it is disabled by default. To enable it, you need to set SelectionMode, SelectedCellBorderColor, SelectedCellBorderThickness properties of the RadHeatMap.  

>You need to set all three properties (SelectionMode, SelectedCellBorderColor, SelectedCellBorderThickness) otherwise, the visual selection of the cells won't appear.

The __SelecitionMode__ property is an enumeration of type __HeatMapSelectionMode__ which provides the following values:

* __None__: When set the selection is disable. (default)
* __SingleDataItem__: When set only a single data item can be selected with interaction.
* __MultipleDataItems__: When set multiple data items can be selected with interaction.

The __SelectedCellBorderColor__ property is of type __Color__ that gets or sets the color of the selection border.

The __SelectedCellBorderThickness__ property is of type __Thickness__ that gets or sets the thickness of the selection border.

#### __[C#] Example 1: Enabling the selection behavior of the RadHeatMap__

{{region radheatmap-selection_0}}
	 <telerik:RadHeatMap SelectionMode="MultipleDataItems" SelectedCellBorderColor="Red" SelectedCellBorderThickness="2" />
{{endregion}}

#### __Figure 1: RadHeatMap with selection enabled__

![RadHeatMap with selection enabled](images/radheatmap-selection_0.PNG)

## See Also
* [Getting Started]({%slug radheatmap-getting-started%})
* [Labels]({%slug radheatmap-labels%})
* [Populating With Data]({%slug radheatmap-populating-with-data%})
