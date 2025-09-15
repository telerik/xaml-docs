---
title: Disable IEditableObject Support through ShouldRespectIEditableObject Property
page_title: Disable IEditableObject Support
description: Get started with Telerik's {{ site.framework_name }} DataGrid and learn how to disable IEditableObject support in the Data Engine through ShouldRespectIEditableObject property.
slug: radgridview-managing-data-how-to-disable-ieditableobject-support
tags: disable,ieditableobject,support,data,engine
published: True
position: 1
---

# Disable IEditableObject Support in the RadGridView Data Engine through ShouldRespectIEditableObject Property
As of Q1 2016, we've introduced the **ShouldRespectIEditableObject** property. The default value is **True**. Setting it to false will prevent the RadGridView Data Engine from calling the [**IEditableObject**](https://msdn.microsoft.com/en-us/library/system.componentmodel.ieditableobject(v=vs.110).aspx) methods - **BeginEdit()**, **CancelEdit()** and **EndEdit()**.

>Setting **ShouldRespectIEditableObject** to **False** will only prevent the IEditableObject methods of the object implementing the interface. RadGridView's **BeginEdit()**, **CancelEdit()** and **EndEdit()** methods will still be executed and the respective [events]({%slug gridview-events-edit%}) will be raised.

__Example 1: Setting ShouldRespectIEditableObject__

```XAML
	<telerik:RadGridView Name="gridView" ShouldRespectIEditableObject="False" />
```

## See Also

 * [Events - Edit]({%slug gridview-events-edit%})

 * [Updating an Entry]({%slug gridview-managing-data-updating-entry%})
