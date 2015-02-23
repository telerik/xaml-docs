---
title: UI Structure
page_title: UI Structure
description: UI Structure
slug: carousel-ui-structure
tags: ui,structure
published: True
position: 1
---

# UI Structure

Knowing the visual structure of a control is fundamental for creating new custom themes and [custom styles]({%slug carousel-global-styles%}). This topic will present the building blocks of the [RadCarousel]({%slug carousel-overview%}), thus help you to better understand its UI structure.

##  RadCarousel
 ![](images/radCarousel.png)

The RadCarousel is primarily composed of four elements - __CarouselItemsControl__, [RadCarouselPanel](#radcarouselpanel), [CarouselItem]({%slug carousel-items%}), and a __ScrollViewer__.
We will take a closer look at each of those elements and briefly explain their purpose. 

## CarouselItemsControl

Although it is not directly accessible and you should not worry about styling this class it is crucial for the functioning of the RadCarousel.

## RadCarouselPanel 
   ![](images/radCarouselPanel.png)

The RadCarouselPanel is the most important element in the visual tree of the RadCarousel since it is the actual workhorse - it hosts the carousel items, runs all animations, and computes all effects like scaling and opacity. 

>The __RadCarouselPanel__ is used as __ItemsPanel__ for the __CarouselItemsControl__

## CarouselItem
 ![](images/carouselItem.png)

The [CarouselItem]({%slug carousel-items%}) represents a selectable item in a RadCarousel and also contains the visual representation of a data element. Usually, container items such as the CarouselItem display the selection state of the element that they contain.

## CarouselDataRecordPresenter

![](images/carouselDataRecordPresenter.png)

If the __AutoGenerateRecordPresenters__ property is set to __true__ RadCarousel will inspect the data source and it will create a special __CarouselDataRecordPresenter__ for each data item. This object defines the visual representation of the data items, thus you can change the appearance of the data by providing a [new style]({%slug carousel-global-styles%}) for the __CarouselDataRecordPresenter__.

## CarouselDataFieldPresenter

The __CarouselDataFieldPresenter__ is used to display a single field (or a column) of a data item and you can use it to change the appearance of all fields as a whole.
