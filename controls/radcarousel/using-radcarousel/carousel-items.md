---
title: Carousel Items
page_title: Carousel Items
description: Check our &quot;Carousel Items&quot; documentation article for the RadCarousel {{ site.framework_name }} control.
slug: carousel-items
tags: carousel,items
published: True
position: 0
---

# Carousel Items

## Overview

RadCarousel tries to mimic the familiar API of a standard WPF __ItemsControl__. When displaying data, the control will wrap visible data items in a __CarouselItem__ control that provides the visual representation of carousel items. In addition to providing the visual representation of data items, __CarouselItem__ controls are also the entry point for data-related properties such as the ones supporting item selection.

## Customization

Using the fact that all data items are automatically wrapped inside a __CarouselItem__ you can change an item's appearance by using WPF styles targeting __CarouselItem__ controls. Here is how to do that and present your carousel items inside two nested Border elements:



<snippet id='radcarousel-using-radcarousel-carousel-items-block_1-xaml' />

## Displaying Visual Cues for Selected Items

The above style will make all carousel items look identical. If you need selection logic in your RadCarousel control, you will most certainly want selected items to appear different than the rest. To implement that, you need to use a trigger in your __CarouselItem__ style and modify your appearance according to the __IsSelected__ property value. The example below adds a trigger to the __CarouselItem__ control template to change the two Border elements' background color when the respective __CarouselItem__ has been selected:



<snippet id='radcarousel-using-radcarousel-carousel-items-block_2-xaml' />

##  Data Record Presenters

Remember the __ContentPresenter__ control that we used in our __CarouselItem__ control template? It will not display the data items directly, but will use a __CarouselDataRecordPresenter__ control to do its job. The data record presenter works closely with the RadCarousel data engine and wraps a data item object. You Here is how you can create a custom style to modify the __CarouselDataRecordPresenter__ template and customize the way your data is presented:



<snippet id='radcarousel-using-radcarousel-carousel-items-block_3-xaml' />