---
title: Expand all rows
page_title: Expand all rows
description: Check our &quot;Expand all rows&quot; documentation article for the RadTreeListView {{ site.framework_name }} control.
slug: treelistview-expand-all-hierarchy
tags: expand,all,rows
published: True
position: 0
---

# {{ site.framework_name }} RadTreeListView Expand all rows



## 

This article shows how to expand all rows of __RadTreeListView__.

There are two options:

__Option 1:__ Set the __AutoExpandItems__ property of __RadTreeListView__ to ___True___. This property sets a value indicating if the hierarchy items should be expanded initially or not. Its default value is ___False___.
        

__Option 2:__ You can follow these steps to accomplish the same task:

1. Subscribe to the __DataLoaded__ event of the __RadTreeListView__:

	#### __C#__

	{{region treelistview-expand-all-hierarchy_0}}

		treeListView.DataLoaded += new EventHandler<EventArgs>(treeListView_DataLoaded);
{{endregion}}



	#### __VB.NET__

	{{region treelistview-expand-all-hierarchy_1}}

		AddHandler treeListView.DataLoaded, AddressOf treeListView_DataLoaded
{{endregion}}



2. Define the __DataLoaded__ handler as follows:

	#### __C#__

	{{region treelistview-expand-all-hierarchy_2}}

		void treeListView_DataLoaded(object sender, EventArgs e)
		{
	   		treeListView.DataLoaded -= treeListView_DataLoaded;
	    	treeListView.ExpandAllHierarchyItems();   
		}
{{endregion}}



	#### __VB.NET__

	{{region treelistview-expand-all-hierarchy_3}}

		Private Sub treeListView_DataLoaded(sender As Object, e As EventArgs)
	   	treeListView.DataLoaded -= treeListView_DataLoaded
	   	treeListView.ExpandAllHierarchyItems()
		End Sub
{{endregion}}





>Note that we unsubscribe for that event on the first line, so it is not called for each child table. Calling the __ExpandAllHierarchyItems__ will expand all parent rows.

>caution Binding to the __IsExpanded__ property of __TreeListViewRow__ is not fully supported. You can consider using [IsExpandedBinding]({%slug radtreelsitview-how-to-control-expand-settings%}) property instead.