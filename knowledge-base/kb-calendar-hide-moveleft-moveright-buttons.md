---
title: How to Hide the Forward and Backward Buttons in RadCalendar
description: Controlling the visibility of the previous and next buttons in RadCalendar
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

## Solution

1. Use the __PreviousButtonVisibility__ and __NextButtonVisibility__ properties of the __RadCalendar__.

#### __[XAML]__
{{region kb-calendar-hide-moveleft-moveright-buttons-0}}
	<Grid>
        <telerik:RadCalendar NextButtonVisibility="Hidden"/>
    </Grid>
{{endregion}}

## See Also
* [Visual Tree Helpers]({%slug common-visual-tree-helpers%})