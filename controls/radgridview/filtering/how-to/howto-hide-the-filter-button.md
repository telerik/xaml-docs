---
title: Hide the Filter Button
page_title: Hide the Filter Button
description: Learn how to set the Column.ShowFilterButton to false in order to hide the Filter Button in RadGridView - Telerik's {{ site.framework_name }} DataGrid.
slug: gridview-filtering-howto-hide-the-filter-button
tags: hide,the,filter,button
published: True
position: 16
---

# Hide the Filter Button

When in **Popup** filtering mode, you can set **GridViewColumn.ShowFilterButton** to **False** if you want to hide the **Filter button**. This is useful when you are in immediate filtering mode, i.e. **GridViewColumn.IsFilteringDeferred** is **False**.

__Example 1: Hide filter button in XAML__

<snippet id='radgridview-filtering-how-to-howto-hide-the-filter-button-example_1_hide_filter_button_in_xaml-xaml' />


__Example 2: Hide filter button in code-behind__

<snippet id='radgridview-filtering-how-to-howto-hide-the-filter-button-example_2_hide_filter_button_in_code_behind-cs' />


__Example 2: Hide filter button in code-behind__

<snippet id='radgridview-filtering-how-to-howto-hide-the-filter-button-example_2_hide_filter_button_in_code_behind-vb' />


**Figure 1** and **Figure 2** demonstrate the two setups.

#### **Figure 1: RadGridView with ShowFilterButton set to True**
![Telerik UI for {{ site.framework_name }} RadGridView popup filtering UI with the filter button visible in the column header](images/ShowFilterButtonTrue.png)

#### **Figure 2: RadGridView with ShowFilterButton set to False**
![Telerik UI for {{ site.framework_name }} RadGridView popup filtering UI with the filter button hidden from the column header](images/ShowFilterButtonFalse.png)

## See Also

* [Popup Filtering]({%slug gridview-filtering-basic%}#popup-filtering)
* [Filter on a Property Different from the Displayed One]({%slug gridview-filtering-howto-filter-on-a-property-different-from-the-displayed-one%})
* [Close Filtering Popup on Pressing Filter Button]({%slug gridview-filtering-howto-close-filtering-popup-on-pressing-the-filter-button%})
