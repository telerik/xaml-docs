---
title: Access Filtering Popup
page_title: Access Filtering Popup
description: Access Filter Popup
slug: gridview-filtering-howto-access-popup
tags: filtering,popup
published: True
position: 23
---

# Accessing the filtering popup

The FilteringControl is a Popup and it is displayed on screen over RadGridView control. You can find the instance of the specific Popup and try implementing any modifications.
        
#### __C#: Find all available Popups__
	private void grid_Loaded_1(object sender, RoutedEventArgs e)
	{
	    this.Dispatcher.BeginInvoke(new Action(() => this.FindPopups()));
	}
	  
	private void FindPopups()
	{
	    foreach (var headerCell in this.myGrid.ChildrenOfType<GridViewHeaderCell>())
	    {
	        var popUp = headerCell.ChildrenOfType<Popup>().FirstOrDefault();
	  
	       // do any modification on the Popup itself
	    }
	}
        

# See Also

 * [Basic Filtering]({%slug gridview-filtering-basic%})

 * [Custom Filtering Controls]({%slug gridview-filtering-custom-filtering-controls%})
