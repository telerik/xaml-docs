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

 
<snippet id='radgridview-filtering-how-to-howto-configure-the-filtering-mode-block_1-xaml' />


__Popup Filtering Mode__  

![Telerik UI for {{ site.framework_name }} RadGridView Popup filtering mode with distinct values and field filters](images/gridview_filtering_basic_01.png)

## Filter Row

To enable the filter row mode, set RadGridView’s `FilteringMode` property to `FilterRow`.

  
<snippet id='radgridview-filtering-how-to-howto-configure-the-filtering-mode-popup_filtering_mode-xaml' />


__FilterRow Filtering Mode__  

![Telerik UI for {{ site.framework_name }} RadGridView FilterRow mode with inline filter editors in the header row](images/gridview_filtering_basic_02.png)

## Filter Editor

To enable the filter editor mode, set RadGridView’s `FilteringMode` property to `FilterEditor`.

  
<snippet id='radgridview-filtering-how-to-howto-configure-the-filtering-mode-filterrow_filtering_mode-xaml' />


__FilterEditor Filtering Mode__  

![Telerik UI for {{ site.framework_name }} RadGridView FilterEditor mode with the filter editor panel displayed](images/gridview_filtering_basic_03.png)


