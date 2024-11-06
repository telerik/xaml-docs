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

#### __XAML__ 
{{region xaml-gridview-filtering-howto-configure-the-filtering-mode_0}}
	<telerik:RadGridView FilteringMode="Popup" />
{{endregion}}

__Popup Filtering Mode__  

![Telerik {{ site.framework_name }} DataGrid filtering basic 01](images/gridview_filtering_basic_01.png)

## Filter Row

To enable the filter row mode, set RadGridView’s `FilteringMode` property to `FilterRow`.

#### __XAML__  
{{region xaml-gridview-filtering-howto-configure-the-filtering-mode_1}}
	<telerik:RadGridView FilteringMode="FilterRow" />
{{endregion}}

__FilterRow Filtering Mode__  

![Telerik {{ site.framework_name }} DataGrid filtering basic 02](images/gridview_filtering_basic_02.png)

## Filter Editor

To enable the filter editor mode, set RadGridView’s `FilteringMode` property to `FilterEditor`.

#### __XAML__  
{{region xaml-gridview-filtering-howto-configure-the-filtering-mode_2}}
	<telerik:RadGridView FilteringMode="FilterEditor" />
{{endregion}}

__FilterEditor Filtering Mode__  

![Telerik {{ site.framework_name }} DataGrid filtering basic 03](images/gridview_filtering_basic_03.png)


