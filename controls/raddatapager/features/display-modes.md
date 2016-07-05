---
title: Display Modes
page_title: Display Modes
description: Display Modes
slug: raddatapager-features-display-modes
tags: display,modes
published: True
position: 1
---

# Display Modes



## 

>tip If you are new to the __RadDataPager__ control, you can consider reading the [Getting Started]({%slug raddatapager-getting-started%}) topic before continuing.

The __RadDataPager__ allows you to decide which of its visual elements to be visible. This is done via the __PagerDisplayModes__ enumeration and the __DisplayMode__ property. 

The enumeration has the following values:

* __First__ - the go to first page button is displayed.


* __FirstLastNumeric__ - the go to first and last page buttons and the numeric buttons are displayed


* __FirstLastPreviousNext__ - the go to first and last page buttons and go to previous and next page buttons are displayed


* __FirstLastPreviousNextNumeric__ - same as above, but in addition the numeric buttons are also displayed


* __Last__ - the go to last page button is displayed


* __Next__ - the go to next page button is displayed


* __Numeric__ - only the numeric buttons are displayed


* __Previous__ - the go to previous page button is displayed


* __PreviousNext__ - the go to previous and next page buttons are displayed


* __PreviousNextNumeric__ - the go to previous and next page buttons are displayed, and in addition the numeric buttons are also displayed


* __Text__ - only the textbox and the label are displayed


* __All (default)__ - all buttons are displayed

__Example 1__ shows how to set up a __RadDataPager__ that displays the previous, next and numeric buttons.

#### __[XAML]Example 1: Set RadDataPager`s DisplayMode__

{{region xaml-raddatapager-features-display-modes_0}}

	<telerik:RadDataPager x:Name="radDataPager"
	                        PageSize="5"
	                        DisplayMode="PreviousNextNumeric" />
{{endregion}}

#### __Figure 1: RadDataPager with Previous, Next and Numeric buttons__
![](images/RadDataPager_Features_DisplayModes_01.png)

If the combination of visual elements doesn't exist in the enumeration, you can combine one or more enumeration values. This is done by separating the values with a coma as shown in __Example 2__:

#### __[XAML]Example 2: Set RadDataPager`s DisplayMode__

{{region xaml-raddatapager-features-display-modes_1}}

	<telerik:RadDataPager x:Name="radDataPager"
	                        PageSize="5"
	                        DisplayMode="PreviousNext,Text" />
{{endregion}}

#### __Figure 2: RadDataPager with Previous, Next buttons and Text Field__
![](images/RadDataPager_Features_DisplayModes_02.png)

# See Also

 * [Page Size]({%slug raddatapager-features-page-size%})

 * [Paging Essentials]({%slug raddapager-features-paging-essentials%})

 * [Auto Ellipsis]({%slug raddatapager-features-auto-ellipsis%})
