---
title: Change the predefined scroll buttons
page_title: Change the predefined scroll buttons
description: Check our &quot;Change the predefined scroll buttons&quot; documentation article for the RadCarousel {{ site.framework_name }} control.
slug: radcarousel-how-to-change-scroll-buttons
tags: change,the,predefined,scroll,buttons
published: True
position: 0
site_name: WPF
---

# Change the predefined scroll buttons

RadCarousel does provide a built-in scroll bar that enables you to move the items left, right or directly to the last or first page. However, if the default view does not meet your requirements, you may easily predefine them and change their style. Basically, you need to take a couple of steps:

* Set the HorizontalScrollBarVisibility property of RadCarousel to "Hidden";

* Define the required CarouselScrollButtons and handle their Click events;

* Specify the ResourceDictionary so that the Theme is applied correctly.

Finally, the implementation should be as follows:



<snippet id='radcarousel-how-to-change-scroll-buttons-block_1-xaml' />



<snippet id='radcarousel-how-to-change-scroll-buttons-block_2-cs' />
<snippet id='radcarousel-how-to-change-scroll-buttons-block_2-vb' />


Once you are done, the RadCarousel should be visualized as the image below:
![{{ site.framework_name }} RadCarousel Customized Buttons](images/RadCarousel_ChangeScrollButtons.png)

Still, you are free to change the style of the buttons just as you want them to be. 
