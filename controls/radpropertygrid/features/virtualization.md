---
title: UI Virtualization
page_title: UI Virtualization
description: UI Virtualization
slug: radpropertygrid-virtualization
tags: ui,virtualization
published: True
position: 7
---

# UI Virtualization



Since __Q1 2013__ RadPropertyGrid supports __UI Virtualization__. It processes only information that is loaded in the viewable area, which reduces the memory footprint of the application and speeds up the loading time. This means that only the needed containers (rows) that are currently visible have a visual element. When RadPropertyGrid is scrolled up and down, the __UI Virtualization__ mechanism enables RadPropertyGrid to reuse the existing containers over and over again for different data items, instead of creating new ones. This is of great importance when it is bound to large data sets.
      

> As of __Q2 2013__ RadPropertyGrid supports UI Virtualization for grouping scenarios. It is supported only when RadpropertyGrid's property - RenderMode is set to Flat.
      

The following tutorial shows how to bind to a collection of business objects and virtualize the items displayed in a RadPropertyGrid element using the __IsVirtualizing__ property.
      

>tipBy default __IsVirtualizing__ property is set to __False__.
      

Here is a simple RadPropertyGrid declaration.

#### __[XAML]Example 1: Defining RadPropertyGrid__

	{{region radpropertygrid-virtualization_0}}
	<telerik:RadPropertyGrid x:Name="propertyGrid1" />
	{{endregion}}



RadPropertyGrid is populated with 10 000 rows.

#### __[C#]Example 2: Populating RadPropertyGrid__

	{{region radpropertygrid-virtualization_1}}
	this.propertyGrid1.Item = this.GetVeryLargeDataSource();
	{{endregion}}



#### __[VB.NET]Example 2: Populating RadPropertyGrid__

	{{region radpropertygrid-virtualization_2}}
	    Me.propertyGrid1.Item = Me.GetVeryLargeDataSource()
	{{endregion}}



Finally, in order to enable the __UI Virtualization__ behavior, you should set the __IsVirtualizing__ property of RadPropertyGrid to __True__. See the example below:
      

#### __[XAML]Example 3: Setting IsVirtualizing property__

	{{region radpropertygrid-virtualization_1}}
	<telerik:RadPropertyGrid x:Name="propertyGrid1" IsVirtualizing="True" />
	{{endregion}}



>tipA complete example of RadPropertyGrid UI Virtualization is available in{% if site.site_name == 'Silverlight' %}[ this online demo](http://demos.telerik.com/silverlight/#PropertyGrid/Virtualization){% endif %}{% if site.site_name == 'WPF' %}[this online demo](http://demos.telerik.com/wpf/#PropertyGrid/Virtualization){% endif %}.
      