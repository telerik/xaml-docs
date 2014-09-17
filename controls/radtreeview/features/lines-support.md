---
title: Lines Support
page_title: Lines Support
description: Lines Support
slug: radtreeview-features-lines-support
tags: lines,support
published: True
position: 4
---

# Lines Support



The __RadTreeView__ allows you to enable connected lines between the nodes of a treeview. By default the connecting lines between the nodes are not enabled (they are not visible). You should use a single property to do so - __IsLineEnabled__and set it to __True__.

#### __XAML__

{{region radtreeview-features-lines-support_0}}
	<telerik:RadTreeView x:Name="radTreeView" IsLineEnabled="True">
	{{endregion}}

![Rad Tree View Features Lines Support 001](images/RadTreeView_Features_LinesSupport_001.png)

You can also control the visibility of the lines between the root items (the items on the first level) of the treeview. This can be done with the __IsRootLinesEnabled__ property of the treeview. The default value of this property is __True__

#### __XAML__

{{region radtreeview-features-lines-support_1}}
	<telerik:RadTreeView x:Name="radTreeView" IsLineEnabled="True" IsRootLinesEnabled="False">
	{{endregion}}

![Rad Tree View Features Lines Support 002](images/RadTreeView_Features_LinesSupport_002.png)

>tipFor more information about the visual structure of the __RadTreeView__, check out the [Visual Structure]({%slug radtreeview-visual-structure%}) topic.

## Change the LineColor

Take a look at the [Styling the Lines]({%slug radtreeview-styling-appearance-styling-line%}) topic in the Styling and Appearance section.

# See Also

 * [Selection]({%slug radtreeview-feautres-treeviewitem-selection%})

 * [Drag and Drop]({%slug radtreeview-features-drag-and-drop%})

 * [UI Virtualization]({%slug radtreeview-features-ui-virtualization%})
