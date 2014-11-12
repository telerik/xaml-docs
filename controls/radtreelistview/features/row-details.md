---
title: Row Details
page_title: Row Details
description: Row Details
slug: radtreelistview-features-row-details
tags: row,details
published: True
position: 3
---

# Row Details



## 

Each __RadTreeListView__ row is capable of presenting additional information by means of a __Row Details__. The __Row Details__ is a __DataTemplate__ defined on the grid- or row-level and is used for displaying data without affecting the dimensions of the row and the cells within it.

One of the advantages of using a __Row Details__ template is that it can be displayed for the selected row only, thus providing a more compact layout. This is done by setting the __RowDetailsVisibilityMode__ property.

Another benefit of the __Row Details__ is the option of placing the __Details Presenter__ outside the __RadGridView__, which provides more room for traditional rows without depriving the user of the additional information.

____

>tipThe row and the row details share the same data context, so you are free to bind the elements in your template to any of the properties of the data item.

As the __Row Details__ feature is inherited from the __RadGridView__, you can find more detailed information and examples in {% if site.site_name == 'Silverlight' %}[its documentation](http://www.telerik.com/help/silverlight/radgridview-row-details-overview.html){% endif %}{% if site.site_name == 'WPF' %}[its documentation](http://www.telerik.com/help/wpf/radgridview-row-details-overview.html){% endif %}.

# See Also

 * [Getting Started]({%slug radtreeliestview-getting-started%})

 * [Columns]({%slug radtreelistview-features-columns%})

 * [Data Binding]({%slug radtreelistview-features-data-binding%})
