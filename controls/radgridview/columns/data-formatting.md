---
title: Data Formatting
page_title: Data Formatting
description: Data Formatting
slug: gridview-columns-data-formatting
tags: data,formatting
published: True
position: 5
---

# Data Formatting

The __GridViewDataColumn__ and the __GridViewComboBoxColumn__ allow you to format the data displayed in them. To do that you have to specify a format string appropriate for the data displayed and set it to the __DataFormatString__ property of the column.

#### __XAML__

{{region gridview-columns-data-formatting_0}}

	<telerik:GridViewDataColumn DataMemberBinding="{Binding OrderDate}"
                                Header="Order Date"
                                UniqueName="OrderDate"
                                DataFormatString="{} {0:dd, MMM, yyyy}" />
{{endregion}}



>tipDefining format strings in XAML can be done in the following way- {}:{0:__your format string__}.

#### __C#__

{{region gridview-columns-data-formatting_1}}

	((GridViewDataColumn)this.radGridView.Columns["OrderDate"] ).DataFormatString = "{0:dd, MMM, yyyy}";
	    // or
	((GridViewDataColumn)this.radGridView.Columns["OrderDate"] ).DataFormatString = "dd, MMM, yyyy";
{{endregion}}



#### __VB.NET__

{{region gridview-columns-data-formatting_2}}

	DirectCast(Me.radGridView.Columns("OrderDate"), GridViewDataColumn).DataFormatString = "{0:dd, MMM, yyyy}"
	    ' or'
	DirectCast(Me.radGridView.Columns("OrderDate"), GridViewDataColumn).DataFormatString = "dd, MMM, yyyy"
{{endregion}}


![](images/RadGridView_DataFormatting_1.png)

>DataFormatString is plain __string.Format__. To learn more please check this MSDN article:
[string.Format](http://msdn.microsoft.com/en-us/library/system.string.format.aspx)

>__{}__ is the XAML escape sequence. You can find again more information in MSDN:
[Escape Sequence](http://msdn.microsoft.com/en-us/library/ms744986.aspx)

To learn more about formatting visit the [Formatting Overview](http://msdn.microsoft.com/en-us/library/26etazsy.aspx) chapter in MSDN.

# See Also

 * [Column Headers]({%slug gridview-columns-column-headers%})

 * [Column Footers]({%slug gridview-columns-column-footers%})

 * [Aggregate Functions]({%slug gridview-columns-aggregate-functions%})
