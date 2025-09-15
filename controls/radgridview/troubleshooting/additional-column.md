---
title: Additional column appears
page_title: Additional column appears
description: Learn how to troubleshoot when an additional empty column appears after all columns within RadGridView - Telerik's {{ site.framework_name }} DataGrid.
slug: gridview-troubleshooting-additional-column
tags: additional,column,added,after,all,gridview,columns
published: True
position: 8
---

# Additional column added after all gridview columns

__PROBLEM__

RadGridView adds an additional empty column after all gridview columns:

![troubleshooting additional column Telerik {{ site.framework_name }} DataGrid](images/troubleshooting_additional_column_gridview.png)

__CAUSE__

RadGridView tries to fill all the width that it takes. Actually this is not a column, but rather the rows which span to end of the __GridView__.

__SOLUTION__

You can use either of the following methods: 

* Set the __ColumnWidth__ property of RadGridView to "__*__"

#### __XAML__

```XAML
	<telerik:RadGridView ItemsSource="{Binding Clubs}" ColumnWidth="*" />
```

The result would be:

![troubleshooting additional column Telerik {{ site.framework_name }} DataGrid fix1](images/troubleshooting_additional_column_gridview_fix1.png)

* Set the __Width__ of any of the columns to "__*__"

#### __XAML__

```XAML
	<telerik:GridViewDataColumn DataMemberBinding="{Binding StadiumCapacity}" 
	            Header="Stadium" 
	            Width="*"/>
```

Now, the result would be:

![troubleshooting additional column Telerik {{ site.framework_name }} DataGrid fix2](images/troubleshooting_additional_column_gridview_fix2.png)

## See Also
* [Defining Columns]({%slug gridview-columns-defining-columns%})