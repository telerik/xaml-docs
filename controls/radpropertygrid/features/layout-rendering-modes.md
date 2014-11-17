---
title: Layout Rendering Modes
page_title: Layout Rendering Modes
description: Layout Rendering Modes
slug: radpropertygrid-features-layout-rendering-modes
tags: layout,rendering,modes
published: True
position: 11
---

# Layout Rendering Modes



As of __Q2 2013__ we have introduced a new property of RadPropertyGrid - RenderMode. It represents RadPropertyGrid's layout render mode and has two options:

1. __Hierarchical__: It is the default one and it will nest the PropertyFields into one another, when you have [Nested PropertyDefinitions]({%slug radpropertygrid-nested-properties%}) or grouping.
        

2. __Flat__: This mode represents our new layout mechanism for RadPropertyGrid, which rely entirely on flat rendering of its elements.This allows to virtualize the grouping process which leads to a very good perfromance when RadPropertyGrid is grouped and has a lot of data.
        



>tipFor compatibility reasons, the old render mode is also preserved, but it is recomended to use the new one.

There are a number of benefits of using the __Flat__ render mode. Some are listed below:
      

1. __Faster layout rendering and scrolling time for grouped PropertyGrid__.
        

2. __Support UI Virtualization for grouping scenarios__.
        

3. __Keyboard Navigation__.
        

# See Also

 * [Getting Started with RadPropertyGrid]({%slug radpropertygrid-getting-started-getting-started%})

 * [UI Virtualization]({%slug radpropertygrid-virtualization%})

 * [Keyboard Navigation]({%slug radpropertygrid-nested-properties%})

 * [Edit Modes]({%slug radpropertygrid-edit-modes%})

 * [Scrolling into View]({%slug radpropertygrid-scrolling%})
