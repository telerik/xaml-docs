---
title: Hide the Filter Button
page_title: Hide the Filter Button
description: Learn how to set the Column.ShowFilterButton to false in order to hide the Filter Button in RadGridView - Telerik's WPF DataGrid.
slug: gridview-filtering-howto-hide-the-filter-button
tags: hide,the,filter,button
published: True
position: 16
---

# Hide the Filter Button

When in **Popup** filtering mode, you can set **GridViewColumn.ShowFilterButton** to **False** if you want to hide the **Filter button**. This is useful when you are in immediate filtering mode, i.e. **GridViewColumn.IsFilteringDeferred** is **False**.

#### __[XAML] Example 1: Hide filter button in XAML__

{{region xaml-gridview-filtering-howto-hide-the-filter-button-1}}

    <telerik:GridViewDataColumn ShowFilterButton="False" IsFilteringDeferred="False" />
{{endregion}}

#### __[C#] Example 2: Hide filter button in code-behind__

{{region cs-gridview-filtering-howto-hide-the-filter-button-2}}

    private void Grid_AutoGeneratingColumn(object sender, GridViewAutoGeneratingColumnEventArgs e)
    {
        if (e.ItemPropertyInfo.PropertyType == typeof(string))
        {
            e.Column.IsFilteringDeferred = false;
            e.Column.ShowFilterButton = false;
        }
    };
{{endregion}}

#### __[VB] Example 2: Hide filter button in code-behind__

{{region vb-gridview-filtering-howto-hide-the-filter-button-3}}

    Private Sub Grid_AutoGeneratingColumn(ByVal sender As Object, ByVal e As GridViewAutoGeneratingColumnEventArgs)
		If e.ItemPropertyInfo.PropertyType Is GetType(String) Then
			e.Column.IsFilteringDeferred = False
			e.Column.ShowFilterButton = False
		End If
    End Sub
{{endregion}}

**Figure 1** and **Figure 2** demonstrate the two setups.

#### **Figure 1: RadGridView with ShowFilterButton set to True**
![RadGridView with ShowFilterButton set to True](images/ShowFilterButtonTrue.png)

#### **Figure 2: RadGridView with ShowFilterButton set to False**
![RadGridView with ShowFilterButton set to False](images/ShowFilterButtonFalse.png)

## See Also

* [Popup Filtering]({%slug gridview-filtering-basic%}#popup-filtering)
* [Filter on a Property Different from the Displayed One]({%slug gridview-filtering-howto-filter-on-a-property-different-from-the-displayed-one%})
* [Close Filtering Popup on Pressing Filter Button]({%slug gridview-filtering-howto-close-filtering-popup-on-pressing-the-filter-button%})
