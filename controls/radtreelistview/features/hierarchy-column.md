---
title: Hierarchy Column
page_title: Hierarchy Column
description: Check our &quot;Hierarchy Column&quot; documentation article for the RadTreeListView {{ site.framework_name }} control.
slug: radtreelistview-features-hierarchy-column
tags: hierarchy,column
published: True
position: 0
---

# {{ site.framework_name }} RadTreeListView Hierarchy Column



## 

By default the first column contains the tree view UI. In order to change the column which holds it, you have to set the  __HierarchyColumnIndex__ property to the desired value.

>The first column index is __0__.

Here is an example.

#### __XAML__
{{region radtreelistview-features-hierarchy-column_0}}

	<telerik:RadTreeListView x:Name="radTreeListView"
	                            AutoGenerateColumns="False"
	                            HierarchyColumnIndex="1">
	    <telerik:RadTreeListView.ChildTableDefinitions>
	        <telerik:TreeListViewTableDefinition ItemsSource="{Binding Items}">
	        </telerik:TreeListViewTableDefinition>
	    </telerik:RadTreeListView.ChildTableDefinitions>
	    <telerik:RadTreeListView.Columns>
	        <telerik:GridViewDataColumn DataMemberBinding="{Binding Name}"
	                                    Header="Name" />
	        <telerik:GridViewDataColumn DataMemberBinding="{Binding Count}"
	                                    Header="Count" />
	    </telerik:RadTreeListView.Columns>
	</telerik:RadTreeListView>
{{endregion}}

![{{ site.framework_name }} RadTreeListView Hierarchy Column Index 1](images/RadTreeListView_HierarchyColumn_01.png)

## See Also

 * [Columns]({%slug radtreelistview-features-columns%})

 * [Getting Started]({%slug radtreeliestview-getting-started%})

 * [Data Binding]({%slug radtreelistview-features-data-binding%})
