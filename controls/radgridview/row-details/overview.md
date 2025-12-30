---
title: Overview
page_title: Row Details Overview
description: Check our &quot;Overview&quot; documentation article for the RadGridView {{ site.framework_name }} control.
slug: radgridview-row-details-overview
tags: overview
published: True
position: 0
---

# Row Details Overview

Each __RadGridView__ row is capable of presenting additional information by means of a __Row Details__. The __Row Details__ is a __DataTemplate__ defined on the grid- or row-level and is used for displaying data without affecting the dimensions of the row and the cells within it.

One of the advantages of using a __Row Details__ template is that it can be displayed for the selected row only, thus providing a more compact layout. Another benefit of __Row Details__ is the option of placing the __Details Presenter__ outside the __RadGridView__, which provides more room for traditional rows without depriving the user of the additional information.

![Telerik {{ site.framework_name }} DataGrid RowDetails 1](images/RadGridView_RowDetails_1.png)

>tip To easily expand / collapse the __Row Details__ you can use the [Toggle RowDetails Column]({%slug radgridview-columns-column-types-toggle-rowdetails-column%}).
	
>tip The row and the row details share the same data context, so you are free to bind the elements in your template to any of the properties of the data item. To learn more about the __Row Details template__ read [here]({%slug radgridview-row-details-template%}).
	
>tip In order to not scroll the RowDetails when horizontally scrolling the parent RadGridView, you should set __AreRowDetailsFrozen="True"__ for it.

This chapter will make you familiar with the specifics around the __Row Details__. The following things will get explained:

* [Row Details Template]({%slug radgridview-row-details-template%})

* [Row Details Visibility]({%slug radgridview-row-details-visibility%})

* [Row Details TemplateSelector]({%slug radgridview-row-details-templateselector%})

* [Programming]({%slug radgridview-row-details-programming%})

* [External Row Details]({%slug radgridview-row-details-external-row-details%})

* [Customizing the Row Details]({%slug radgridview-row-details-customizing-the-row-details%})

## Related Resources

If you want to learn more about the __Row Details__ and how to implement them in more specific scenarios, please take a look at the list with related resources:

* [Display Hierarchical Data with Row Details](http://blogs.telerik.com/rossenhristov/posts/09-07-30/how-to-display-hierarchical-data-with-row-details-radgridview-for-silverlight.aspx)

* [Toggle Row Details one at a time](http://blogs.telerik.com/rossenhristov/posts/09-12-01/how-to-toggle-row-details-one-at-a-time-with-telerik-radgridview-for-silverlight.aspx)

* [Display RadGridView Row Details](http://blogs.telerik.com/rossenhristov/posts/09-12-11/how-to-display-radgridview-row-details-with-radwindow-for-silverlight.aspx)

* [Tooltip Row Details with RadGridView](http://blogs.telerik.com/rossenhristov/posts/09-12-19/how-to-tooltip-row-details-with-radgridview-for-silverlight.aspx)

* [Asynchronous Master-Details with RadGridView](http://blogs.telerik.com/rossenhristov/posts/10-01-07/asynchronous-master-details-with-radgridview-for-silverlight-and-wcf-ria-services.aspx)

* [Asynchronous Master-Details with RadGridView Part II](http://blogs.telerik.com/rossenhristov/posts/10-01-08/radgridview-for-silverlight-and-wcf-ria-services-part-ii-basic-editing-support.aspx)

## See Also

 * [Grid Rows Overview]({%slug gridview-rows-overview%})

 * [Defining Columns]({%slug gridview-columns-defining-columns%})

 * [Populating with Data Overview]({%slug gridview-data-overview%})

 * [UI Virtualization]({%slug radgridview-features-ui-virtualization%})
