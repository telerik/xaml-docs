---
title: Sticky Group Headers
page_title: Sticky Group Headers
description: Sticky Group Headers
slug: gridview-sticky-group-headers
tags: sticky,group,headers
published: True
position: 7
---

# Sticky Group Headers

By default, RadGridView's group headers will go out of view once you scroll past them as illustrated in **Figure 1**.

#### __Figure 1: RadGridView with Disabled Sticky Group Headers__

![RadGridView with Disabled Sticky Group Headers](images/disabledstickygroupheaders.png)

You can stick the headers of the group to the top until its items are scrolled out of view by setting the **EnableStickyGroupHeaders** property to *true*.

>important The EnableStickyGroupHeaders functionality is only supported when [GroupRenderMode]({%slug gridview-grouping-groupingmodes%}) is **Flat**. If the **Nested** grouping mode is set, a **NotSupportedException** will be thrown.

#### __Example 1: Enable Sticky Group Headers__

{{region gridview-sticky-group-headers-0}}
	<telerik:RadGridView EnableStickyGroupHeaders="True" />
{{endregion}}

#### __Figure 2: RadGridView with Enabled Sticky Group Headers__

![RadGridView with Enabled Sticky Group Headers](images/enabledstickygroupheaders.png)

## See Also

 * [Group Footers]({%slug gridview-group-footers%})
 * [Modifying Group Panel]({%slug gridview-modifying-group-panel%})
 * [Grouping Modes]({%slug gridview-grouping-groupingmodes%})
