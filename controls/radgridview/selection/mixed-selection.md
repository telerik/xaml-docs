---
title: Mixed Selection
page_title: Mixed Selection
description: Get started with Telerik's {{ site.framework_name }} DataGrid allowing the user to select a cell as well as to select a row. 
slug: gridview-mixed-selection
tags: mixed,selection
published: True
position: 2
---

# Mixed Selection

Since Q3 2012 SP1 release, __RadGridView__ allows the user to select a cell as well as to select a row. By default this functionality is disabled and to turn it on you have to set the __SelectionUnit__ property to __Mixed__.

>In order to select a full row, you must click on it, but not on its cell.

RadGridView provides three selection modes, which allow you to manipulate the type of selection. You can combine them with SelectionUnit - Mixed:
        

* With Single Selection:              

![Telerik {{ site.framework_name }} DataGrid MixedSelection 4](images/RadGridView_MixedSelection_4.png)

You can select only one unit at a time.
            
* With Multiple Selection:

![Telerik {{ site.framework_name }} DataGrid MixedSelection 3](images/RadGridView_MixedSelection_3.png)

You are able to select any cell and any row. Units are added to the selection when they are clicked and get removed when they are clicked again.
            
* With Extended Selection:

![Telerik {{ site.framework_name }} DataGrid MixedSelection 2](images/RadGridView_MixedSelection_2.png)

Units are added to the selection only by combining the mouse clicks with the Ctrl or Shift key.
            
For more information take a look at the [Basic Selection]({%slug gridview-selection-basics%}) topic.

## See Also

 * [Basic Selection]({%slug gridview-selection-basics%})

 * [Programmatic Selection]({%slug radgridview-selection-programmatic-selection%})

 * [Basic Filtering]({%slug gridview-filtering-basic%})

 * [Programmatic Filtering]({%slug gridview-filtering-programmatic%})

 * [Multiple-column Sorting]({%slug gridview-multiple-column-sorting%})
