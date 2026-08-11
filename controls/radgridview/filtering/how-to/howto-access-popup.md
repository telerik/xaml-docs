---
title: Access Filtering Popup
page_title: Access Filtering Popup
description: Get started with the filtering functionality of Telerik's {{ site.framework_name }} DataGrid and learn how to access a filtering popup.
slug: gridview-filtering-howto-access-popup
tags: filtering,popup
published: True
position: 23
---

# Accessing the filtering popup

The __filtering control__ is a __Popup__ and it is displayed on screen over RadGridView control. You can find the instance of the specific Popup and try implementing any modifications on its behavior.

#### __C# Example 1: Find all available Popups__
<snippet id='radgridview-filtering-how-to-howto-access-popup-block_1-cs' />

    
## Opening filtering control from code    

The filtering control can be opened in code by finding the respective __FilteringDropDown__ element and setting its property __IsDropDownOpened__ to True. For example:

#### __C# Example 2: Open the first FilteringDropDown__
<snippet id='radgridview-filtering-how-to-howto-access-popup-block_2-cs' />


## See Also
 * [Basic Filtering]({%slug gridview-filtering-basic%})
 * [Custom Filtering Controls]({%slug gridview-filtering-custom-filtering-controls%})
