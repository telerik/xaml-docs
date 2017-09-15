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

The __filtering control__ is a __Popup__ and it is displayed on screen over RadGridView control. You can find the instance of the specific Popup and try implementing any modifications on its behavior.

#### __C# Example 1: Find all available Popups__
{{region gridview-filtering-howto-access-popup-0}}
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
{{endregion}}
    
## Opening filtering control from code    

The filtering control can be opened in code by finding the respective __FilteringDropDown__ element and setting its property __IsDropDownOpened__ to True. For example:

#### __C# Example 2: Open the first FilteringDropDown__
{{region gridview-filtering-howto-access-popup-1}}
	private void Button1_Click(object sender, RoutedEventArgs e)
	{
	    clubsGrid.ChildrenOfType<FilteringDropDown>().First().IsDropDownOpen = true;
	}
{{endregion}}

## See Also
 * [Basic Filtering]({%slug gridview-filtering-basic%})
 * [Custom Filtering Controls]({%slug gridview-filtering-custom-filtering-controls%})