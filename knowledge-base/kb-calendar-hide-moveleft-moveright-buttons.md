---
title: How to Hide the Forward and Backward Buttons in RadCalendar
description: Controlling the visibility of the previous and next buttons in RadCalendar.
type: how-to
page_title: Change the Visibility of the Move Left and Move Right Buttons in the Calendar Header
slug: kb-calendar-hide-moveleft-moveright-buttons
position: 0
tags: loaded,childrenoftype,repeatbutton,visual,tree,helper
ticketid: 1407259
res_type: kb
---

## Environment
<table>
    <tbody>
	    <tr>
	    	<td>Product Version</td>
	    	<td>2017.3.1018</td>
	    </tr>
	    <tr>
	    	<td>Product</td>
	    	<td>RadCalendar for WPF</td>
	    </tr>
    </tbody>
</table>

## Description

How to hide the forward and backward buttons in RadCalendar.

## Solution 1

1. Subscribe to the `Loaded` event of RadCalendar.
2. Use the `ChildrenOfType<T>` extension method to get the RepeatButton controls representing the move-left and move-right buttons. The `ChildrenOfType<T>` method is defined in the `Telerik.Windows.Controls.ChildrenOfTypeExtensions` class.


```C#
	private void RadCalendar_Loaded(object sender, RoutedEventArgs e)
	{
		var calendar = (RadCalendar)sender;
		var moveLeftButton = calendar.ChildrenOfType<RepeatButton>().FirstOrDefault(x => x.Name == "MoveLeft");
		var moveRightButton = calendar.ChildrenOfType<RepeatButton>().FirstOrDefault(x => x.Name == "MoveRight");

		moveLeftButton.Visibility = Visibility.Collapsed;
		moveRightButton.Visibility = Visibility.Collapsed;
	}
```

## Solution 2

After __R3 2019__, you can use the __PreviousButtonVisibility__ and __NextButtonVisibility__ properties of the __RadCalendar__.


```XAML
	<Grid>
        	<telerik:RadCalendar NextButtonVisibility="Hidden"/>
    	</Grid>
```


## See Also
* [Visual Tree Helpers]({%slug common-visual-tree-helpers%})
