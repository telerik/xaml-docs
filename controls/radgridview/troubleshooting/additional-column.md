---
title: Additional column appears
page_title: Additional column appears
description: Additional column added after all gridview columns
slug: gridview-troubleshooting-additional-column
tags: additional,column,added,after,all,gridview,columns
published: True
position: 8
---

# Additional column added after all gridview columns

__PROBLEM__

RadGridView adds an additional empty column after all gridview columns:

![](images/troubleshooting_additional_column_gridview.png)

__CAUSE__

RadGridView tries to fill all the width that it takes. Actually this is not a column, but rather the rows which span to end of the __GridView__.

__SOLUTION__

You can use either of the following methods: 

* Set the __ColumnWidth__ property of RadGridView to "__*__"

#### __XAML__

{{region xaml-gridview-troubleshooting-additional-column_0}}
	<telerik:RadGridView ItemsSource="{Binding Clubs}" ColumnWidth="*" />
{{endregion}}

The result would be:

![](images/troubleshooting_additional_column_gridview_fix1.png)

* Set the __Width__ of any of the columns to "__*__"

#### __XAML__

{{region xaml-gridview-troubleshooting-additional-column_1}}
	<telerik:GridViewDataColumn DataMemberBinding="{Binding StadiumCapacity}" 
	            Header="Stadium" 
	            Width="*"/>
{{endregion}}

Now, the result would be:

![](images/troubleshooting_additional_column_gridview_fix2.png)

# See Also
* [Columns Overview]({%slug gridview-columns-overview%})
 

