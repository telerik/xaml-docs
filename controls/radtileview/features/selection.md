---
title: Selection
page_title: Selection
description: This article demonstrates the selection feature of the RadTileView control.
slug: radtileview-selection
tags: animation
published: True
position: 9
---

# Selection

This article demonstrates the selection feature of the RadTileView control.

## Enabling Selection

The selection feature is disabled by default. To enable it set the __IsSelectionEnabled__ property of RadTileView to __True__. To select a RadTileViewItem, click on it in the UI, or set the SelectedItem property of the control.

__Example 1: Enabling selection__
<snippet id='radtileview-features-selection-block_1-xaml' />

#### Figure 1: Selected tile
![radtileview-selection-0.png](images/radtileview-selection-0.png)

## Selection Mode

The control supports three selection modes. They can be set via the __SelectionMode__ property of RadTileView.

* __Single__: In this mode the user will be able to select only one item at once. This is the __default__ mode.

* __Multiple__: This mode allows selection of multiple items. Clicking an item selects or deselects it depending on its current state. Also, the previously selected items will preserve their selection state.

* __Extended__: This mode allows the user to select multiple items at once by holding down the Ctrl or Shift keys and clicking multiple items with the mouse or by using the keyboard. A second click on a selected item will unselect that item.

__Example 2: Setting selection mode__
<snippet id='radtileview-features-selection-block_2-xaml' />

## Setting and Getting Selected Items Manually

The selected tile is stored in the __SelectedItem__ property of RadTileView and also in its __SelectedItems__ collection. You can use both to access or update the selected tiles.

Depending on the setup the SelectedItem property can contain different values. If the control is populated directly using RadTileViewItem instances, the property will contain a value of type RadTileViewItem. If the control is populated via its ItemsSource property, the SelectedItem will contain an object from the ItemsSource (the model of the selected RadTileViewItem).

__Example 3: Getting and setting selection manually via the SelectedItem property__
<snippet id='radtileview-features-selection-block_3-cs' />
<snippet id='radtileview-features-selection-block_4-vb' />

__Example 4: Setting selection via the SelectedItems collection property__
<snippet id='radtileview-features-selection-block_5-cs' />
<snippet id='radtileview-features-selection-block_6-vb' />

## Events

The RadTileView control exposes several selection events. Please note that these events should be used instead of the standard **SelectionChanged** event.

* __PreviewTileSelectionChanged__: This event fires just before the selection state of the tile gets changed. You can use the event to cancel the selection of the tile by setting the __Handled__ property of the event arguments to __True__.

* __TileSelectionChanged__: This event fires just after the selection state of the tile is changed.

* __PreviewTilesSelectionChanged__: This event fires just before the selection operation completes. For example, if you select multiple items using the Shift key + Mouse click (in Extended selection mode), the event will get fired only once. You can use the event to cancel the selection of the tile by setting the __Handled__ property of the event arguments to __True__.

* __TilesSelectionChanged__: This event fires just after the selection operation completes. For example, if you select multiple items using the Shift key + Mouse click (in Extended selection mode), the event will get fired only once.

## Binding SelectedItem

This section demonstrates how to data bind the SelectedItem property of the control.

__Example 5: Defining the model and populating it with data__
<snippet id='radtileview-features-selection-block_7-cs' />
<snippet id='radtileview-features-selection-block_8-vb' />

__Example 6: Setting the DataContext__
<snippet id='radtileview-features-selection-block_9-xaml' />

__Example 7: Setting up the view and binding the SelectedItem property__
<snippet id='radtileview-features-selection-block_10-xaml' />

#### Figure 2: Data binding example
![radtileview-selection-1.png](images/radtileview-selection-1.png)

> You can find more information about the __ViewModeBase__ class used in Example 5 in the [ViewModelBase Class]({%slug common-viewmodelbase-class%}) article.

## See Also
 * [Getting Started]({%slug radtileview-getting-started%})
 * [Events]({%slug radtileview-events%})
 * [Reordering Tiles]({%slug radtileview-features-reordering-tiles%})