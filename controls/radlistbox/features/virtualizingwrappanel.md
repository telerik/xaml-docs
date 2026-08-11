---
title: VirtualizingWrapPanel
page_title: VirtualizingWrapPanel
description: This article will describe the VirtualizingWrapPanel and how it can be used as an ItemsPanel for a RadListBox.
slug: radlistbox-features-virtualizingwrappanel
tags: virtualizingwrappanel, itemspanel, listbox
published: True
position: 4
---

# VirtualizingWrapPanel

This article will describe the [VirtualizingWrapPanel](https://docs.telerik.com/devtools/wpf/api/telerik.windows.controls.virtualizingwrappanel) and how it can be used as an ItemsPanel for a RadListBox.

## Key Properties

* __ItemHeight__: Gets or sets a value that specifies the Height of all items that are contained within a VirtualizingWrapPanel.
* __ItemWidth__: Gets or sets a value that specifies the Width of all items that are contained within a VirtualizingWrapPanel.
* __ScrollStep__: Gets or sets a value for the amount that will be scrolled when using the mouse wheel or the scrollbar buttons (Not supported when grouping is enabled).

	> Scrolling with the __Page up__ and __Page down__ keys and navigating with the __Left__ and __Right__ arrow keys is not supported when grouping is enabled. 

* __VirtualizingPanel.ScrollUnit__ : The possible values are __Pixel__ (the scrolling is pixel based) and __Item__ (the scrolling is item based). (When grouping is enabled, only __Pixel__ is supported). The default value is __Item__.
* __VirtualizingPanel.IsVirtualizingWhenGrouping__ : Set this property to __True__ to enable virtualizing when grouping. 
* __VirtualizingPanel.VirtualizationMode__: Specifies the method the panel will use to manage virtualizing its child items. The possible values are __Standard__ (create and discard the item containers) and __Recycling__ (reuse the item containers).

	The ScrollUnit, IsVirtualizingWhenGroupinga and VirtualizationMode properties are available in .NET 4.6.2 and later.

## VirtualizingWrapPanel

In order to demonstrate how the VirtualizingWrapPanel can be used, we will setup some sample data as demonstrated in __Example 1__.

__Example 1: Setting up the model and viewmodel__

<snippet id='radlistbox-features-virtualizingwrappanel-block_1-cs' />
<snippet id='radlistbox-features-virtualizingwrappanel-block_1-vb' />

## Setting up the RadListBox

__Example 2__ demonstrates how the VirtualizingWrapPanel can be used as an ItemsPanel for a __RadListBox__. You can read some more about the benefits of UI Virtualization in the following [article](https://docs.microsoft.com/en-us/dotnet/framework/wpf/advanced/optimizing-performance-controls#displaying-large-data-sets).

__Example 2: RadListBox with VirtualizingWrapPanel as ItemsPanel__
<snippet id='radlistbox-features-virtualizingwrappanel-block_2-xaml' />

#### __Figure 1: Result from Example 2 in the Office2016 theme__
![RadListBox with VirtualizingWrapPanel as ItemsPanel](images/radlistbox_features_virtualizingwrappanel.gif)

## Grouping

__Example 3__ demonstrates how you can apply grouping to the data by setting the __GroupStyle__ property. Otherwise, the example uses the same setup as __Example 2__.

__Example 3: Grouped RadListBox with VirtualizingWrapPanel as ItemsPanel__
<snippet id='radlistbox-features-virtualizingwrappanel-block_3-xaml' />

## Grouping and Virtualization

The VirtualizingWrapPanel supports virtualization when the data is grouped. This feature is only available for __.NET 4.6.2__ and above.

In order to turn on this feature, you have to set the __VirtualizingPanel.IsVirtualizingWhenGrouping__ attached property to __True__.

Additionally, you have to set the __VirtualizingPanel.ScrollUnit__ to __Pixel__, since __VirtualizingPanel.ScrollUnit="Item"__ is not supported while grouping. Optionally, you can also set the __VirtualizingPanel.VirtualizationMode__ property to __Recycling__ in order for the item containers to be recycled during scrolling.

__Example 4: Turning on virtualization while grouping__
<snippet id='radlistbox-features-virtualizingwrappanel-block_4-xaml' />

>Note that you also need to set the attached properties on the panel in the **GroupStyle** as they will not be transferred automatically.

>important When the __VirtualizingPanel.IsVirtualizingWhenGrouping__ property is set to __True__, the __VirtualizingPanel.ScrollUnit__ needs to be __Pixel__, since __VirtualizingPanel.ScrollUnit="Item"__ is not supported.

## See Also

* [Binding To Object]({%slug radlistbox-populating-with-data-binding-to-object%})