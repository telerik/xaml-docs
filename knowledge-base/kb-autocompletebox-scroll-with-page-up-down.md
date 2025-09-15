---
title: How to Scroll Multiple Items with Page Up and Down
description: An article explaining how to enable the scrolling of an arbitrary number of items.
type: how-to
page_title: Allow Scrolling of an Arbitrary Number of Items with Page Up and Page Down
slug: kb-autocompletebox-scroll-with-page-up-down
position: 0
tags: autocompletebox, scroll, multiple, number, items, page, up, down
ticketid: 1479153
res_type: kb
---

## Environment
<table>
	<tbody>
		<tr>
			<td>Product Version</td>
			<td>2020.3.817</td>
		</tr>
		<tr>
			<td>Product</td>
			<td>RadAutoCompleteBox for WPF</td>
		</tr>
	</tbody>
</table>

## Description

How to enable the scrolling of multiple items using the **Page Up** and **Page Down** keys.

## Solution

As of version **2020.3.817** the RadAutoCompleteBox exposes a protected **HighlightedIndex** property which can be used to set the highlighted item. This property can be used in the **HandleKeyDown** method of the control to enable [custom keyboard navigation]({%slug radautocompletebox-features-keyboard-support%}) with the **Page Up** and **Page Down** keys.


```C#
    public class CustomAutoCompleteBox : RadAutoCompleteBox
    {
        protected override bool HandleKeyDown(Key systemKey)
        {
            if (systemKey == Key.PageDown)
            {
                this.HighlightedIndex += 10;
                return true;
            }

            if (systemKey == Key.PageUp)
            {
                this.HighlightedIndex -= 10;
                return true;
            }

            return base.HandleKeyDown(systemKey);
        }
    }
```

## See Also
* [Keyboard Support]({%slug radautocompletebox-features-keyboard-support%})
