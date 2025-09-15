---
title: Change Hand Cursor Icon to Loading Icon Upon Clicking on Filter in RadGridView Column Header
description: "How to modify hand mouse cursor icon upon clicking on the filter drop down button of the GridView column header."
type: how-to
page_title: How to Replace the Hand Mouse Cursor When GridView Column Header Filter Icon is Clicked
slug: kb-gridview-change-filteringdropdownbutton-hand-icon
position: 0
tags: loading icon, hand icon, filter, gridview
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
            <td>RadGridView for WPF</td>
        </tr>
    </tbody>
</table>


## Description

How to change the mouse cursor icon on click over the filter drop down button of the `RadGridView` column headers (the funnel icon).

## Solution

You can use the `MouseLeftButtonDown` event of the `RadGridView` control to get the `FilterDropDown` control. Then you can override the cursor on click.


```C#
	public MainWindow()
	{
		InitializeComponent();	
		this.gridView.AddHandler(RadGridView.MouseLeftButtonDownEvent, new MouseButtonEventHandler(OnGridViewMouseLeftButtonDown), true);
	}

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
```
