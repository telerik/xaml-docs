---
title: Virtualization
page_title: Virtualization
description: Check our &quot;Virtualization&quot; documentation article for the RadDiagram {{ site.framework_name }} control.
slug: raddiagrams-features-virtualization
tags: virtualization
published: True
position: 6
---

# Virtualization

__Telerik Diagramming Framework__ supports __UI Virtualization__, which collapses all items outside the viewable area, thus enhancing the UI performance while manipulating the Diagramming elements. However as the virtualization implementation only collapses the visibility of the controls outside the veiwport, those items will still be considered during a layout operation for example. This means that a __Layout__ operation will change the visibility of the Diagramming elements if they are brought into the viewport area.

By default the __Virtualization__ feature of the __RadDiagram__ is enabled. You can disable it by setting the __DiagramSurface.IsVirtualizing__ attached property to False.
		
	
```XAML
    <telerik:RadDiagram x:Name="diagram" telerik:DiagramSurface.IsVirtualizing="False"/>	  		  
```

<br />
>tip Binding the __Visibility__ property of the diagram items is not recommended. That is because when the virtualization is enabled the diagram items have their Visibility set locally. A value which is locally set has a higher priority than a one set through a OneWay binding so the value that comes from the binding won't be respected. To hide a shape we recommend using its __Opacity__ property instead.

## See Also
 * [Getting Started]({%slug raddiagram-getting-started%})
 * [Populating with Data]({%slug raddiagram-data-overview%})
 * [Shapes]({%slug raddiagrams-features-shapes%})
 * [Connections]({%slug raddiagrams-features-connections%})
 * [Serialization]({%slug raddiagrams-features-serialization%})
 * [Commands]({%slug raddiagrams-features-commands%})
 * [Diagram Events]({%slug raddiagrams-events-diagram%})
 * [Items Events]({%slug raddiagrams-events-item%})
