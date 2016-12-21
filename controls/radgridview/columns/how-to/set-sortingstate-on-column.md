---
title: Set SortingState on Column
page_title: Set SortingState on Column
description: Set SortingState on Column
slug: gridview-set-sortingstate-on-column
tags: set,sortingstate,on,column
published: True
position: 12
---

# Set SortingState on Column

Generally, each GridViewColumn enables you to set it in a specific sorting state. This may be easily done by defining its corresponding property SortingState. It may have the following values:

* Ascending;
* Descending;
* None.

As it comes to RadGridView, this approach represents custom sorting logic and as being such, you have to set one more property - __IsCustomSortingEnabled__:

#### __[XAML] Example 1: Setting SortingState for a column.__

{{region xaml-gridview-set-sortingstate-on-column_1}}
	<telerik:GridViewDataColumn DataMemberBinding="{Binding Name}" SortingState="Ascending" IsCustomSortingEnabled="True"/>
{{endregion}}

Once you define all the necessary properties, the corresponding column will be set in an Ascending sorting order. Furthermore, you will be able to handle the Sorting event of the RadGridView and perform any additional logic that you need.

>tipFor further information on implementing custom sorting you may run through the [Custom Sorting]({%slug gridview-sorting-custom%}) article.

# See also

 * [Basic Sorting]({%slug gridview-sorting-basics%})

 * [Custom Sorting]({%slug gridview-sorting-custom%})

 * [Multiple-column Sorting]({%slug gridview-multiple-column-sorting%})



