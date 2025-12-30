---
title: Grouping Modes
page_title: Grouping Modes
description: Get started with the grouping modes property in Telerik's {{ site.framework_name }} DataGrid that allows you to choose either nested or flat mode. 
slug: gridview-grouping-groupingmodes
tags: grouping,modes
published: True
position: 1
---

# Grouping Modes

As of __Q3 2012__ we have introduced a new property of the RadGridView control - __GroupRenderMode__. It has two possible values:

__Nested__: This is the default value and it will nest __GridViewGroupRows__ into one another. With this group render mode every group is represented by its own UI container and groups are nested in a hierarchical manner. The visual element representing the grouped row is __GridViewGroupRow__.

__Flat__: This mode represents our new virtualization mechanism with a completely new item container generator. It simply renders rows one below the other and all rows are on the same level. The visual element representing the grouped row is __GroupHeaderRow__.

>important For compatibility reasons, the Nested render mode is also preserved, but it is highly recommended to use the new Flat mode as it leads to better performance and most of the latest features and bug fixes only target this mode.

>Please note that when you use the __Flat mode__, you should work with __GroupHeaderRow__, not __GridViewGroupRow__.

## See also

* [Basic Grouping]({%slug gridview-grouping-basics%})
* [Programmatic Grouping]({%slug gridview-programmatic-grouping%})
