---
title: Filter goes outside the window
page_title: Filter goes outside the window
description: Learn how to troubleshoot if the filtering control goes out of the window or gets cut by the browser boundaries when working with the Telerik {{ site.framework_name }} DataGrid.
slug: gridview-troubleshooting-filtering-control
tags: filter,goes,outside,the,window
published: True
position: 11
---

# Filter goes outside the window

__PROBLEM__

The filtering control goes out of the window boundaries when there is not enough space for it. Here is an example:

![troubleshooting filtering boundaries Telerik {{ site.framework_name }} DataGrid](images/troubleshooting_filtering_boundaries_gridview.png)

__SOLUTION__

You have two options here:

1. You can shorten the filtering control by either removing the distinct values listbox (top part) or the field filter controls (bottom part). The two boolean properties that controls these behaviors are: __ShowDistinctFilters__ and __ShowFieldFilters__

![troubleshooting filtering boundaries Telerik {{ site.framework_name }} DataGrid 2](images/troubleshooting_filtering_boundaries_gridview2.png)

2. Or you can customize the ControlTemplate of the FilteringControl to reduce the height of the distinct values ListBox. See how to extract the default ControlTemplate of a Telerik control in the [Editing Control Templates]({%slug styling-apperance-editing-control-templates%}) article. After the template is copied into your project, find the __PART_DistinctValuesList__ ListBox and set its __MaxHeight__ property to a smaller value, e.g. `MaxHeight="100"`.

![troubleshooting filtering boundaries Telerik {{ site.framework_name }} DataGrid 4](images/troubleshooting_filtering_boundaries_gridview4.png)
