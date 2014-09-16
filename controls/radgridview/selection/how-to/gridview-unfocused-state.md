---
title: Stop Showing the Unfocused State
page_title: Stop Showing the Unfocused State
description: Stop Showing the Unfocused State
slug: gridview-selection-unfocused-state
tags: stop,showing,the,unfocused,state
publish: True
position: 1
---

# Stop Showing the Unfocused State



## 

With Q2 2012 we have introduced a new __Unfocused__ state for the selected GridViewRow. It will be shown when the GridView is out of focus.![Rad Grid View Selection Unfocused State 01](images/RadGridView_Selection_UnfocusedState_01.PNG)

If you want to __revert to the previous behavior__ you should set GridView's property - __EnableLostFocusSelectedState__ to __False__.

>
          This property is available with our internal build (version - 2013.1.0311).
        

Here is the result: 
        ![Rad Grid View Selection Unfocused State 02](images/RadGridView_Selection_UnfocusedState_02.PNG)
