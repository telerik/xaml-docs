---
title: Layout Rendering Modes
page_title: Layout Rendering Modes
description: Check our &quot;Layout Rendering Modes&quot; documentation article for the RadPropertyGrid {{ site.framework_name }} control.
slug: radpropertygrid-features-layout-rendering-modes
tags: layout,rendering,modes
published: True
position: 11
---

# Layout Rendering Modes



As of __Q2 2013__ RadPropertyGrid exposes new property - __RenderMode__. It represents RadPropertyGrid's layout render mode and has two options:

1. __Hierarchical__: This is the default one and it will nest the PropertyFields into one another, when you have [Nested PropertyDefinitions]({%slug radpropertygrid-nested-properties%}) or grouping.
        

2. __Flat__: This mode represents RadPropertyGrid's new layout mechanism, which rely entirely on flat rendering of its elements.This allows to virtualize the grouping process which leads to a very good perfromance when RadPropertyGrid is grouped and has a lot of data.
        



>tip For compatibility reasons, Hierarchical mode is also preserved, but it is recommended to use Flat mode.

There are a number of benefits of using the __Flat__ render mode. Some are listed below:
      

* __Faster layout rendering__ and __scrolling time__ for __grouped__ RadPropertyGrid.
        

* Supported [UI Virtualization]({%slug radpropertygrid-virtualization%}) for __grouping scenarios__.
        

* [Keyboard Navigation]({%slug radpropertygrid-features-keyboard-support%})
        

## See Also

 * [Getting Started with RadPropertyGrid]({%slug radpropertygrid-getting-started-getting-started%})

 * [UI Virtualization]({%slug radpropertygrid-virtualization%})

 * [Edit Modes]({%slug radpropertygrid-edit-modes%})

 * [Scrolling into View]({%slug radpropertygrid-scrolling%})
