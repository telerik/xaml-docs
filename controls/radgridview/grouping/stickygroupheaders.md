---
title: Sticky Group Headers
page_title: Sticky Group Headers
description: Get started with the grouping functionality of Telerik's {{ site.framework_name }} DataGrid and learn how to stick the headers of a group to the top. 
slug: gridview-sticky-group-headers
tags: sticky,group,headers
published: True
position: 7
---

# Sticky Group Headers

By default, RadGridView's group headers will go out of view once you scroll past them as illustrated in **Figure 1**.

#### __Figure 1: RadGridView with Disabled Sticky Group Headers__

![Telerik UI for {{ site.framework_name }} RadGridView grouped data with sticky group headers disabled during scrolling](images/disabledstickygroupheaders.png)

You can stick the headers of the group to the top until its items are scrolled out of view by setting the **EnableStickyGroupHeaders** property to *true*.

>important The EnableStickyGroupHeaders functionality is only supported when [GroupRenderMode]({%slug gridview-grouping-groupingmodes%}) is **Flat**. If the **Nested** grouping mode is set, a **NotSupportedException** will be thrown.

__Example 1: Enable Sticky Group Headers__

<snippet id='radgridview-grouping-stickygroupheaders-example_1_enable_sticky_group_headers-xaml' />


#### __Figure 2: RadGridView with Enabled Sticky Group Headers__

![Telerik UI for {{ site.framework_name }} RadGridView grouped data with sticky group headers pinned to the top during scrolling](images/enabledstickygroupheaders.png)

## See Also

 * [Group Footers]({%slug gridview-group-footers%})
 * [Modifying Group Panel]({%slug gridview-modifying-group-panel%})
 * [Grouping Modes]({%slug gridview-grouping-groupingmodes%})
