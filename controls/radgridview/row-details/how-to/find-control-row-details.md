---
title: Find a control in RowDetailsTemplate
page_title: Find a control in RowDetailsTemplate
description: Get started with Telerik's {{ site.framework_name }} DataGrid and learn how to find a control which is placed in the DataTemplate of the RowDetailsTemplate.
slug: gridview-find-control-row-details
tags: find,a,control,in,rowdetailstemplate
published: True
position: 0
---

# Find a control in RowDetailsTemplate

This article demonstrates how to find a control which is placed in the DataTemplate of the __RowDetailsTemplate__. 

Let assume that you have a control (RadComboBox) in the RowDetailsTemplate which you need to set some properties at __runtime__:



<snippet id='radgridview-row-details-how-to-find-control-row-details-block_1-xaml' />


The best way to do this is to subscribe to the [LoadingRowDetails]({%slug radgridview-row-details-programming%}) event and find the control there:



<snippet id='radgridview-row-details-how-to-find-control-row-details-block_2-xaml' />


In the [LoadingRowDetails]({%slug radgridview-row-details-programming%}) event handler use the [FindName](http://msdn.microsoft.com/en-us/library/system.windows.frameworkelement.findname.aspx) method of the __e.DetailsElement__:



<snippet id='radgridview-row-details-how-to-find-control-row-details-block_3-cs' />

<snippet id='radgridview-row-details-how-to-find-control-row-details-block_3-vb' />


## See Also

 * [RowDetails - Overview]({%slug radgridview-row-details-overview%})
