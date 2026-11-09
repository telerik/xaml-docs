---
title: Close Filtering Popup on Pressing Filter Button
page_title: Close Filtering Popup on Pressing Filter Button
description: Learn how to close the RadGridView filtering popup when you click Filter by using a custom filtering control in Telerik UI for WPF.
components: ["gridview"]
slug: gridview-filtering-howto-close-filtering-popup-on-pressing-the-filter-button
tags: close,filtering,popup,on,pressing,filter,button
published: True
position: 22
---

# Close Filtering Popup on Pressing Filter Button

To close the `RadGridView` filtering popup when you click its **Filter** button, override `FilteringControl.OnApplyFilter` in a custom filtering control. This targets the button inside the popup, not the funnel button in the column header.

These examples assume an existing `RadGridView` with data and column definitions. For project setup in Progress® Telerik® UI for WPF, follow [Getting Started with RadGridView]({%slug gridview-getting-started2%}).

For a complete application, see the [CloseFilteringPopupFilterButton SDK example on GitHub](https://github.com/telerik/xaml-sdk/tree/master/GridView/CloseFilteringPopupFilterButton).

Create a class derived from `FilteringControl` and override `OnApplyFilter`, as shown in the following C# and VB.NET fragments.

**Example 1: Overriding the `OnApplyFilter` method**
<snippet id='radgridview-filtering-how-to-howto-close-filtering-popup-on-pressing-the-filter-button-example_1_overriding_onapplyfilter_method-cs' />

<snippet id='radgridview-filtering-how-to-howto-close-filtering-popup-on-pressing-the-filter-button-example_1_overriding_onapplyfilter_method-vb' />


Assign the custom filtering control to the target column's `FilteringControl` property in your code-behind, after the grid's columns exist.

**Example 2: Applying the custom filtering control to a column**
<snippet id='radgridview-filtering-how-to-howto-close-filtering-popup-on-pressing-the-filter-button-example_2_apply_the_custom_filter_to_the_column-cs' />

<snippet id='radgridview-filtering-how-to-howto-close-filtering-popup-on-pressing-the-filter-button-example_2_apply_the_custom_filter_to_the_column-vb' />


>important If you use [NoXaml assemblies and implicit styles]({%slug styling-apperance-implicit-styles-overview%}), also apply a style to the derived control. Follow [Styling Custom Controls]({%slug implicit-styles-styling-the-controls%}#styling-custom-controls) for the required theme resources.

The following XAML fragment shows a style for the custom filtering control.

**Example 3: Styling the custom filtering control**

<snippet id='radgridview-filtering-how-to-howto-close-filtering-popup-on-pressing-the-filter-button-example_3_style_targetting_the_custom_control-xaml' />

To verify the result, open the target column's filtering popup, choose filter criteria, and click **Filter**. Confirm that the grid applies the filter and the popup closes.

## See Also

* [Basic RadGridView Filtering]({%slug gridview-filtering-basic%})
* [Custom Filtering Controls]({%slug gridview-filtering-custom-filtering-controls%})
