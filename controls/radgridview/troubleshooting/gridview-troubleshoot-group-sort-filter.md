---
title: Cannot group, sort and filter a specific column
page_title: Cannot group, sort and filter a specific column
description: Cannot group, sort and filter a specific column
slug: gridview-troubleshoot-group-sort-filter
tags: cannot,group,,sort,and,filter,a,specific,column
publish: True
position: 5
---

# Cannot group, sort and filter a specific column



## 

__PROBLEM__

You cannot sort, group and/or filter a column even if the all three properties are true: __CanUserSortColumns__, __IsFilteringAllowed__, __ShowGroupPanel__.



__CAUSE__

Probably you are using a __CellTemplate__ for that particular column and you have not specified the __DataMemberBinding__ property of it like this:

#### __XAML__

{{region gridview-troubleshoot-group-sort-filter_0}}
	<telerik:RadGridView.Columns>
	    <telerik:GridViewDataColumn Header="FirstName" >
	        <telerik:GridViewDataColumn.CellTemplate>
	            <DataTemplate>
	                <TextBlock Text="{Binding FirstName}" />
	            </DataTemplate>
	        </telerik:GridViewDataColumn.CellTemplate>
	    </telerik:GridViewDataColumn>
	</telerik:RadGridView.Columns>
	{{endregion}}





__SOLUTION__

Set the __DataMemberBinding__ property of the column to the field that you want the gridview to sort, group and filter on.

#### __XAML__

{{region gridview-troubleshoot-group-sort-filter_1}}
	<telerik:RadGridView.Columns>
	    <telerik:GridViewDataColumn Header="FirstName" DataMemberBinding="{Binding FirstName}" >
	        <telerik:GridViewDataColumn.CellTemplate>
	            <DataTemplate>
	                <TextBlock Text="{Binding FirstName}" />
	            </DataTemplate>
	        </telerik:GridViewDataColumn.CellTemplate>
	    </telerik:GridViewDataColumn>
	</telerik:RadGridView.Columns>
	{{endregion}}


