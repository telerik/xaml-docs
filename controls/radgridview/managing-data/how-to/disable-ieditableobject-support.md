---
title: Disable IEditableObject Support
page_title: Disable IEditableObject Support
description: Disable IEditableObject Support
slug: radgridview-managing-data-how-to-disable-ieditableobject-support
tags: disable,ieditableobject,support,data,engine
published: True
position: 1
---

# Disable IEditableObject Support in RadGridView's Data Engine

As of Q1 2016 we've introduced the **ShouldRespectIEditableObject** property. The default value is **True**. Setting it to false will prevent RadGridView's DataEngine from calling the [**IEditableObject**](https://msdn.microsoft.com/en-us/library/system.componentmodel.ieditableobject(v=vs.110).aspx) methods - **BeginEdit()**, **CancelEdit()** and **EndEdit()**.

>Setting **ShouldRespectIEditableObject** to false will only prevent the IEditableObject methods of the object implementing the interface. RadGridView's **BeginEdit()**, **CancelEdit()** and **EndEdit()** methods will still be executed and the respective [events]({%slug gridview-events-edit%}) will be raised.

#### __[XAML] Example 1: Setting ShouldRespectIEditableObject__

{{region gridview-disable-ieditableobject-support_0}}

	<telerik:RadGridView Name="gridView" ShouldRespectIEditableObject="False">
{{endregion}}

## See Also

 * [Events - Edit]({%slug gridview-events-edit%})

 * [Updating an Entry]({%slug gridview-managing-data-updating-entry%})