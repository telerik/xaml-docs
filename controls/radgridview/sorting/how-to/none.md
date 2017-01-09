---
title: Turn off SortingState.None
page_title: Turn off SortingState.None
description: Turn off SortingState.None
slug: gridview-sorting-none
tags: turn,off,sortingstate.none
published: True
position: 0
---

# Turn off SortingState.None

By design, when you click on the column header the sorting state is changed from None to Ascending, the next click changes it to Descending and the third one brings the None state back. This article shows how to turn off returning to the None state, so when you continuously click on the header the sorting will go from Ascending to Descending and vice-versa. 

To accomplish this you need to subscribe to the __Sorting__ event and define its handler as follows:

#### __C#__

{{region cs-gridview-sorting-none_0}}
	private void clubsGrid_Sorting(object sender, GridViewSortingEventArgs e)
	{
	    if (e.NewSortingState == SortingState.None)
	    {
	        e.NewSortingState = SortingState.Ascending;
	    }
	}
{{endregion}}

#### __VB.NET__

{{region vb-gridview-sorting-none_1}}
	Private Sub clubsGrid_Sorting(sender As Object, e As GridViewSortingEventArgs)
	    If e.NewSortingState = SortingState.None Then
	        e.NewSortingState = SortingState.Ascending
	    End If
	End Sub
{{endregion}}






