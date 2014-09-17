---
title: Step size
page_title: Step size
description: Step size
slug: radslider-step-size
tags: step,size
published: True
position: 4
---

# Step size



## 

__RadSlider's__ properties - __LargeChange__ and 
          __SmallChange__ allow you to define the amount of value that will be used as a 
          step-size. Setting __LargeChange__, for example, will control how much the thumb
          will travel when the track is clicked.

#### __XAML__

{{region radslider-step-size_0}}
	        <telerik:RadSlider LargeChange="2" Maximum="10" />
	{{endregion}}

![](images/largeChange.png)

__SmallChange__ on the other hand is used when __RadSlider__
          has its handles visible. Clicking any of the handles will increase/decrease the value by the amount
          specified in __SmallChange__.

#### __XAML__

{{region radslider-step-size_1}}
	        <telerik:RadSlider SmallChange="1" HandlesVisibility="Visible" Maximum="10" />
	{{endregion}}

![](images/smallChange.png)

The same applies for the thumbs when the __RadSlider__ is in selection range mode.
        
