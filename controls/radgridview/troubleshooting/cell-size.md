---
title: Containers' Size is Increased
page_title: Containers' Size is Increased
description: Get started with Telerik's {{ site.framework_name }} DataGrid allowing you to adjust the size of the containers based on the size of the content to be shown in them. 
slug: gridview-troubleshooting-cell-size
tags: containers',size,is,increased
published: True
position: 15
---

# Containers' Size is Increased

With __Q1 2013__ we have introduced __dynamic FontStyle, FontSize and Brushes for Windows8 and Windows8Touch Themes__.

For example with the __Windows8Theme and Windows8TouchTheme__ applied, the size of the GridView's containers (for example GridViewCell, GridViewHeaderCell, GridViewFooterCell etc.) will be adjusted based on the size of the content to be shown in them. If you set a CellTemplate for the column, having larger content occupying the entire cell, then the container showing it will be larger as well. 
    
You can compare:

The appearance __before__:

![Telerik {{ site.framework_name }} DataGrid dynamic fonts 1](images/gridview_dynamic_fonts_1.png)

The appearance __now__:

![Telerik {{ site.framework_name }} DataGrid dynamic fonts 2](images/gridview_dynamic_fonts_2.png)

In order to have a different (smaller) Size for the containers, you can define a Style targeting the element you are interested in. Then __set its Height property with the desired value__. In the example with the CellTemplate, you could define a __simple Style targeting the GridViewRow element__ and set a fixed Height.

You can check this [help article]({%slug common-styles-appearance-colorizing-metro-theme%}#changing-font-properties) and this
[blog post](http://blogs.telerik.com/blogs/13-02-26/dynamic-fontsizes-with-windows8-and-windows8touch-themes) on explaining details about the new dynamic FontSizes.

More information on GridView's Styling could be found [here]({%slug gridview-stylines-and-templates-overview%}). If you use the Implicit Themes, then this [article]({%slug styling-apperance-implicit-styles-overview%}) might be helpful as well.

## See Also

 * [Styling a Row]({%slug gridview-styling-a-row%})
 * [Styling the Header Row]({%slug gridview-styling-header-row%})
 * [Styling the Group Row]({%slug gridview-styling-group-row%})
