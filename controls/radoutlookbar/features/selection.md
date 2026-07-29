---
title: Selection
page_title: Selection
description: Check our &quot;Selection&quot; documentation article for the RadOutlookBar {{ site.framework_name }} control.
slug: radoutlookbar-selection
tags: selection
published: True
position: 0
---

# Selection

## Handling selection changes

To handle changes in the selection you can use the __SelectionChanged__ event: 


<snippet id='radoutlookbar-features-selection-block_1-xaml' />


<snippet id='radoutlookbar-features-selection-block_2-cs' />
<snippet id='radoutlookbar-features-selection-block_2-vb' />

## Setting selected item

You can set the selected item by using its __IsSelected__ property:
        

<snippet id='radoutlookbar-features-selection-block_3-xaml' />

## Properties

The following properties are related to the selection mechanism of the __RadOutlookBar__:        

* __SelectedItem__ - get or set the selected item

* __SelectedIndex__ - get the index of selected item

* __SelectedContent__ - get the selected content

There are also the following properties related to the styling of the selected content and item:

* __SelectedContentTemplate__ - template for the selected content.

* __SelectedContentTemplateSelector__ - template selector for the selected content

## See Also
 * [Getting Started]({%slug radoutlookbar-getting-started%})
 * [Visual Structure]({%slug radoutlookbar-visual-structure%})