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

<snippet id='radgridview-columns-data-formatting-example_1_set_dataformatstring_property_of_datetime_column-xaml' />


>__{}__ is the XAML escape sequence which allows subsequent values in the attribute to be interpreted as a literal. You can find more information in the MSDN [Escape Sequence](http://msdn.microsoft.com/en-us/library/ms744986.aspx) article.

__Example 1: Set DataFormatString property of DateTime column__

<snippet id='radgridview-columns-data-formatting-example_1_set_dataformatstring_property_of_datetime_column-cs' />

<snippet id='radgridview-columns-data-formatting-example_1_set_dataformatstring_property_of_datetime_column-vb' />


#### __Figure 1: DateTime column with custom DataFormatString__

![Telerik UI for {{ site.framework_name }} RadGridView DateTime column formatted with a custom DataFormatString](images/RadGridView_DataFormatting_1.png)

>The DataFormatString property uses the __string.Format__ method. To learn more, check the [string.Format](http://msdn.microsoft.com/en-us/library/system.string.format.aspx) MSDN article. The resulting string is also dependent on the [IsLocalizationLanguageRespected]({%slug gridview-how-to-custom-format%}) property.

To learn more about formatting visit the [Formatting Overview](http://msdn.microsoft.com/en-us/library/26etazsy.aspx) chapter in MSDN.

## See Also

 * [Column Headers]({%slug gridview-columns-column-headers%})
 * [Column Footers]({%slug gridview-columns-column-footers%})
 * [Custom Format]({%slug gridview-how-to-custom-format%})
