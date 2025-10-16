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

```XAML

    <telerik:GridViewDataColumn ShowFilterButton="False" IsFilteringDeferred="False" />
```

__Example 2: Hide filter button in code-behind__

```C#

    private void Grid_AutoGeneratingColumn(object sender, GridViewAutoGeneratingColumnEventArgs e)
    {
        if (e.ItemPropertyInfo.PropertyType == typeof(string))
        {
            e.Column.IsFilteringDeferred = false;
            e.Column.ShowFilterButton = false;
        }
    };
```

__Example 2: Hide filter button in code-behind__

```VB

    Private Sub Grid_AutoGeneratingColumn(ByVal sender As Object, ByVal e As GridViewAutoGeneratingColumnEventArgs)
		If e.ItemPropertyInfo.PropertyType Is GetType(String) Then
			e.Column.IsFilteringDeferred = False
			e.Column.ShowFilterButton = False
		End If
    End Sub
```

**Figure 1** and **Figure 2** demonstrate the two setups.

#### **Figure 1: RadGridView with ShowFilterButton set to True**
![Telerik {{ site.framework_name }} DataGrid Show Filter Button True](images/ShowFilterButtonTrue.png)

#### **Figure 2: RadGridView with ShowFilterButton set to False**
![Telerik {{ site.framework_name }} DataGrid Show Filter Button False](images/ShowFilterButtonFalse.png)

## See Also

* [Popup Filtering]({%slug gridview-filtering-basic%}#popup-filtering)
* [Filter on a Property Different from the Displayed One]({%slug gridview-filtering-howto-filter-on-a-property-different-from-the-displayed-one%})
* [Close Filtering Popup on Pressing Filter Button]({%slug gridview-filtering-howto-close-filtering-popup-on-pressing-the-filter-button%})
