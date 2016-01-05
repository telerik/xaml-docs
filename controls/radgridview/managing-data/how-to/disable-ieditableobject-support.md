---
title: Disable IEditableObject Support
page_title: Disable IEditableObject Support
description: Disable IEditableObject Support
slug: gridview-disable-ieditableobject-support
tags: disable,ieditableobject,support,data,engine
published: True
position: 1
---

# Disable IEditableObject Support in RadGridView's Data Engine

As of Q1 2016 we've introduced the **ShouldRespectIEditableObject** property. The default value is **True**. Setting it to false will prevent RadGridView's DataEngine from calling the **IEditableObject** methods - **BeginEdit()**, **CancelEdit()** and **EndEdit()**.

#### __[XAML] Example 1: Setting ShouldRespectIEditableObject__

{{region gridview-disable-ieditableobject-support_0}}

	<telerik:RadGridView Name="gridView" ShouldRespectIEditableObject="False">
{{endregion}}