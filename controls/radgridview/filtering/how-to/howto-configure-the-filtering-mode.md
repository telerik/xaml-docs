---
title: Configure The Filtering Mode
page_title: Configure The Filtering Mode
description: Get started with the filtering functionality of Telerik's {{ site.framework_name }} DataGrid and learn how to configure the filtering mode.
slug: gridview-filtering-howto-configure-the-filtering-mode
tags: configure,the,filtering,mode
published: True
position: 0
---

# {{ site.framework_name }} RadGridView Configure The Filtering Mode


RadGridView has two filtering modes as described in this [article.]({%slug gridview-filtering-basic%})

## Popup Filtering Mode

To enable the popup filtering mode, set RadGridView’s FilteringMode property to Popup or do not set anything, since this is the standard default filtering mode.

#### __XAML__

{{region xaml-gridview-filtering-howto-configure-the-filtering-mode_0}}
	<telerik:RadGridView FilteringMode="Popup" />
{{endregion}}

Popup Filtering Mode

![Telerik {{ site.framework_name }} DataGrid filtering basic 01](images/gridview_filtering_basic_01.png)

## Filter Row Mode

To enable the custom filter row mode, set RadGridView’s FilteringMode property to FilterRow.

#### __XAML__

{{region xaml-gridview-filtering-howto-configure-the-filtering-mode_1}}
	<telerik:RadGridView FilteringMode="FilterRow" />
{{endregion}}


Popup Filtering Mode

![Telerik {{ site.framework_name }} DataGrid filtering basic 02](images/gridview_filtering_basic_02.png)

