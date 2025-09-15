---
title: Data Formatting
page_title: Data Formatting
description: Learn how to format data in Telerik's {{ site.framework_name }} DataGrid by specifying an appropriate format string and assigning it to the DataFormatString property.
slug: gridview-columns-data-formatting
tags: data,formatting
published: True
position: 8
---

# Data Formatting

__GridViewDataColumn__ and __GridViewComboBoxColumn__ allow you to format the displayed data by specifying an appropriate format string and assigning it to the __DataFormatString__ property for the column.

__Example 1: Set DataFormatString property of DateTime column__

```XAML
	<telerik:GridViewDataColumn DataMemberBinding="{Binding OrderDate}"
	                Header="Order Date"
	                UniqueName="OrderDate"
	                DataFormatString="{} {0:dd, MMM, yyyy}" />
```

>__{}__ is the XAML escape sequence which allows subsequent values in the attribute to be interpreted as a literal. You can find more information in the MSDN [Escape Sequence](http://msdn.microsoft.com/en-us/library/ms744986.aspx) article.

__Example 1: Set DataFormatString property of DateTime column__

```C#
	((GridViewDataColumn)this.radGridView.Columns["OrderDate"]).DataFormatString = "{0:dd, MMM, yyyy}";
	// or
	((GridViewDataColumn)this.radGridView.Columns["OrderDate"]).DataFormatString = "dd, MMM, yyyy";
```
```VB.NET
	DirectCast(Me.radGridView.Columns("OrderDate"), GridViewDataColumn).DataFormatString = "{0:dd, MMM, yyyy}"
	' or
	DirectCast(Me.radGridView.Columns("OrderDate"), GridViewDataColumn).DataFormatString = "dd, MMM, yyyy"
```

#### __Figure 1: DateTime column with custom DataFormatString__

![Telerik {{ site.framework_name }} DataGrid Data Formatting 1](images/RadGridView_DataFormatting_1.png)

>The DataFormatString property uses the __string.Format__ method. To learn more, check the [string.Format](http://msdn.microsoft.com/en-us/library/system.string.format.aspx) MSDN article. The resulting string is also dependent on the [IsLocalizationLanguageRespected]({%slug gridview-how-to-custom-format%}) property.

To learn more about formatting visit the [Formatting Overview](http://msdn.microsoft.com/en-us/library/26etazsy.aspx) chapter in MSDN.

## See Also

 * [Column Headers]({%slug gridview-columns-column-headers%})
 * [Column Footers]({%slug gridview-columns-column-footers%})
 * [Custom Format]({%slug gridview-how-to-custom-format%})
