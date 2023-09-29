---
title: Change Hand Icon to Any Loading Icon Upon Clicking on Filter
description: "How to change hand icon to any loading icon upon clicking on filter"
type: how-to
page_title: How to change hand icon to any loading icon upon clicking on filter for WPF 
slug: kb-changehandicon-to-loadingicon
position: 0
tags: loading icon, hand icon, filter, busyindicator
ticketid: 1603581
res_type: kb
---

## Environment
<table>
    <tbody>
        <tr>
            <td>Product Version</td>
            <td>2023.2.718</td>
        </tr>
        <tr>
            <td>Product</td>
            <td>RadBusyIndicator for WPF</td>
        </tr>
    </tbody>
</table>


## Description

How to change hand icon to any loading icon upon clicking on filter.

## Solution

You can use the `MouseDown` event of the `RadGridView` control to get the `FilterDropDown`. Then you can override the cursor.

#### __[C#]__
{{region kb-changehandicon-to-loadingicon}}
	private void OnGridViewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
	{
		var clickedElement = (FrameworkElement)e.OriginalSource;
		var filteringDropDown = clickedElement.ParentOfType<FilteringDropDown>();
		if (filteringDropDown != null)
		{
			if (!filteringDropDown.IsDropDownOpen)
			{
				Mouse.OverrideCursor = Cursors.ArrowCD;                   
			
				// execute this code only if you want to return the cursor back to normal when the drop down content is opened
				Dispatcher.BeginInvoke(new Action(() =>
				{
					Mouse.OverrideCursor = null;
				}), System.Windows.Threading.DispatcherPriority.SystemIdle);
			}
			else
			{
				Mouse.OverrideCursor = null;
			}
		}
	}
{{endregion}}