---
title: Configure The Filtering Mode
page_title: Configure The Filtering Mode
description: Get started with the filtering functionality of Telerik's {{ site.framework_name }} DataGrid and learn how to configure the filtering mode.
slug: gridview-filtering-howto-configure-the-filtering-mode
tags: configure,the,filtering,mode
published: True
position: 0
---

# Configure The Filtering Mode

RadGridView has three filtering modes as described in the [Filtering Basics]({%slug gridview-filtering-basic%}) article.

## Popup Filtering

To enable the popup filtering mode, set RadGridView’s `FilteringMode` property to `Popup` or do not set anything, since this is the standard default filtering mode.

 
```XAML
	<telerik:RadGridView FilteringMode="Popup" />
```

__Popup Filtering Mode__  

![Telerik {{ site.framework_name }} DataGrid filtering basic 01](images/gridview_filtering_basic_01.png)

## Filter Row

To enable the filter row mode, set RadGridView’s `FilteringMode` property to `FilterRow`.

  
```XAML
	<telerik:RadGridView FilteringMode="FilterRow" />
```

__FilterRow Filtering Mode__  

![Telerik {{ site.framework_name }} DataGrid filtering basic 02](images/gridview_filtering_basic_02.png)

## Filter Editor

To enable the filter editor mode, set RadGridView’s `FilteringMode` property to `FilterEditor`.

  
```XAML
	<telerik:RadGridView FilteringMode="FilterEditor" />
```

__FilterEditor Filtering Mode__  

![Telerik {{ site.framework_name }} DataGrid filtering basic 03](images/gridview_filtering_basic_03.png)


