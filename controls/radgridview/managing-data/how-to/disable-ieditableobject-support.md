---
title: Disabling IEditableObject Support in RadGridView's Data Engine
page_title: Disabling IEditableObject Support in RadGridView's Data Engine
description: Disabling IEditableObject Support in RadGridView's Data Engine
slug: gridview-disable-ieditableobject-support
tags: disable,ieditableobject,support,data,engine
published: True
position: 1
---

# Disabling IEditableObject Support in RadGridView's Data Engine

As of Q1 2016 we've introduced the __ShouldRespectIEditableObject__ property. Setting it to false will prevent RadGridView's DataEngine from calling the __IEditableObject__ methods.

#### __[XAML] Example 1: Setting __ShouldRespectIEditableObject____

{{region gridview-disable-ieditableobject-support_0}}

	<telerik:RadGridView Name="gridView" ShouldRespectIEditableObject="False">
{{endregion}}