---
title: Visual Structure
page_title: Visual Structure
description: Check our &quot;Visual Structure&quot; documentation article for the RadLayoutControl {{ site.framework_name }} control.
slug: radlayoutcontrol-visual-structure
tags: visual, structure, radlayoutcontrol
published: True
position: 1
---

# {{ site.framework_name }} RadLayoutControl Visual Structure

This article describes the visual elements of the __RadLayoutControl__ and defines terms and concepts that are used in the scope of the control and its documentation.

#### __Figure 1: The visual structure of RadLayoutControl__
![{{ site.framework_name }} RadLayoutControl The visual structure of RadLayoutControl](images/layoutcontrol-visual-structure-01.png)

#### __Figure 2: The visual elements involved in the drag/drop operation__
![{{ site.framework_name }} RadLayoutControl The visual elements involved in the drag/drop operation](images/layoutcontrol-visual-structure-02.png)

* __LayoutControlGroup__: This is a control which is used to group UIElements or other LayoutControlGroups. There are several types of layout groups. You can find more information about this in the [Layout Groups]({%slug radlayoutcontrol-features-layoutgroups-overview%}) section in the documentation.

* __LayoutControlManipulationPane__: This element allows control over the properties of the selected item when the control is in edit mode.

* __LayoutControlSelectionIndicator__: This element indicates which item is selected when the control is in edit mode. Also, it allows resizing over the selected item.

* __LayoutControlMouseOverIndicator__: This element indicates the item under the mouse (the hovered item) when the control is in edit mode. 

* __LayoutControlDragVisual__: This element gives visual feedback about the dragged item. 

* __LayoutControlDropIndicator__: This element gives visual feedback about the available drop positions in the layout panels. Each available drop position is represented by a different LayoutControlDropIndicator element.

## See Also
* [Getting Started]({%slug radlayoutcontrol-getting-started%})
* [Edit the Layout]({%slug radlayoutcontrol-edit-the-layout%})
* [Layout Panel]({%slug radlayoutcontrol-getting-started-layoutpanel%})
* [Layout Groups Overview]({%slug radlayoutcontrol-features-layoutgroups-overview%})

