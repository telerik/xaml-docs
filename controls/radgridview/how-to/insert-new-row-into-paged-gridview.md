---
title: Insert New Row into Paged GridView
page_title: Insert New Row into Paged GridView
description: Insert New Row into Paged GridView
slug: gridview-how-to-insert-new-row-into-paged-gridview
tags: insert,new,row,into,paged,gridview
published: True
position: 13
---

# Insert New Row into Paged GridView

This help article will show you how to insert new row into paged GridView

See this [article]({%slug radgridview-paging-using-telerik-raddatapager%}) for more information about how to page RadGridView.
        

When you insert new row, it is added to the last page of RadDataPager. If you want to page to the new row when the BeginInsert command is called, you will have to handle GridView's AddingNewDataItem event and execute the following code:
        

#### __C#__

{{region gridview-how-to-insert-new-row-into-paged-gridview_0}}

	private void clubsGrid_AddingNewDataItem(object sender, Telerik.Windows.Controls.GridView.GridViewAddingNewEventArgs e)
	    {
	      Dispatcher.BeginInvoke(new Action(()=>{
	        ((RadGridView)sender).Items.MoveToLastPage();
	      }));
	}
{{endregion}}


