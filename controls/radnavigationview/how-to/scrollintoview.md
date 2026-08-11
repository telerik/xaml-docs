---
title: Scroll Item into View
page_title: Scroll Item into View
description: This article demonstrates the ScrollIntoView suppport of RadNavigationView.
slug: radnavigationview-how-to-scrollintoview
tags: scroll,item,into,view
published: True
position: 0
---

# Scroll Item into View

The __RadNavigationView API__ offers __ScrollIntoView__ support through the following method: __ScrollIntoView__. This method allows you to programmatically scroll an item into view when there are many RadNavigationViewItems.

## ScrollIntoView

The ScrollIntoView method has two overloads. One of them accepts an item and the other one accepts an index. __Examples 1, 2__ setup a RadNavigationView in a databinding scenario to demonstrate this method.

__Example 1: Setting up the model and viewmodel__
<snippet id='radnavigationview-how-to-scrollintoview-block_1-cs' />
<snippet id='radnavigationview-how-to-scrollintoview-block_1-vb' />

__Example 2: Setting up the xaml__
<snippet id='radnavigationview-how-to-scrollintoview-block_2-xaml' />

__Example 3__ demonstrates how the ScrollIntoView method can be used, in the Button's Click event handler, by passing it either an item, or an index. 

__Example 3: Scrolling an item/index into View__
<snippet id='radnavigationview-how-to-scrollintoview-block_3-cs' />
<snippet id='radnavigationview-how-to-scrollintoview-block_3-vb' />

## See Also

 * [Getting Started]({%slug radnavigationview-getting-started%})
 * [Selection]({%slug radnavigationview-features-selection%})
 * [DataBinding]({%slug radnavigationview-populating-with-data-databinding%})