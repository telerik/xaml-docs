---
title: Scroll to a particular row or column
page_title: Scroll to a particular row or column
description: Scroll to a particular row or column
slug: gridview-scroll-item
tags: scroll,to,a,particular,row,or,column
published: True
position: 3
---

# Scroll to a particular row or column

This article shows how to scroll RadGridView to a particular row and / or column. There are two methods that we can use __ScrollIntoViewAsync__ and __ScrollIndexIntoViewAsync__. We can use them against a grid with many rows and columns. The ultimate goal would be to scroll to the last column of the last row:
                     
![](images/how_to_scroll_gridview.png)

## ScrollIntoViewAsync

The __ScrollIntoViewAsync__ method accepts the following parameters:
            

* DataItem of type Object - here you pass the business object you want to scroll to.

* [optional] Column of type GridViewColumn - here you pass the GridViewColumn you want to scroll to

* CallBack method - it will be called when the method succeeds

Here is the code that will scroll into the last row and last column of the gridview:

#### __C#__

{{region gridview-scroll-item_0}}

	this.gridView.ScrollIntoViewAsync(this.gridView.Items[this.gridView.Items.Count - 1], //the row
	                                  this.gridView.Columns[this.gridView.Columns.Count - 1], //the column
	                                  new Action<FrameworkElement>((f) => 
	                                  {
	                                     (f as GridViewRow).IsSelected = true; // the callback method; if it is not necessary, you may set that parameter to null;
	                                  }));
{{endregion}}



#### __VB.NET__

{{region gridview-scroll-item_1}}

	    Me.gridView.ScrollIntoViewAsync(Me.gridView.Items(Me.gridView.Items.Count - 1), Me.gridView.Columns(Me.gridView.Columns.Count - 1), New Action(Of FrameworkElement)(AddressOf SelectRow))
	   
	    Private Sub SelectRow(f As FrameworkElement)
	        TryCast(f, GridViewRow).IsSelected = True
	    End Sub
	{{endregion}}

You should use this method when the virtualization is turned on (which is by default). If for some reason you have disabled the virtualization - you can use the __ScrollIntoView__ counterpart. The only difference in terms of programming API is that no callback method is called when the ScrollIntoView succeeds.
 
## ScrollIndexIntoViewAsync (added Q3 2011)

The __ScrollIndexIntoViewAsync__ method accepts the following parameters:
            

* Index of type int - here you pass the index of the business object you want to scroll to.

* [optional] Column of type GridViewColumn - here you pass the GridViewColumn you want to scroll to

* CallBack method - it will be called when the method succeeds

* [optional] CallBack method - the method to execute when scrolling has failed.

Here is the code that will scroll into the last row and last column of the gridview:

#### __C#__

{{region gridview-scroll-item_2}}

	this.gridView.ScrollIndexIntoViewAsync(this.gridView.Items.Count - 1, //the row
	                                  this.gridView.Columns[this.gridView.Columns.Count - 1], //the column
	                                  new Action<FrameworkElement>((f) => 
	                                  {
	                                     (f as GridViewRow).IsSelected = true; // the callback method; if it is not necessary, you may set that parameter to null;
	                                  }), null);
{{endregion}}



#### __VB.NET__

{{region gridview-scroll-item_3}}

    Me.clubsGrid.ScrollIndexIntoViewAsync(Me.clubsGrid.Items.Count - 1, Me.clubsGrid.Columns(Me.clubsGrid.Columns.Count - 1), New Action(Of FrameworkElement)(AddressOf SelectRow), Nothing)
    
    Private Sub SelectRow(f As FrameworkElement)
	    TryCast(f, GridViewRow).IsSelected = True
    End Sub
{{endregion}}

You should use this method when the virtualization is turned on (which is by default). If you have disabled the virtualization - you can use the __ScrollIndexIntoView__ counterpart. The only difference in terms of programming API is that no callback method is called when the ScrollIndexIntoView succeeds.
            


