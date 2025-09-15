---
title: Scroll to Top of WPF RadGridView after Page Change
description: "How to automatically scroll to the top of RadGridView when changing pages using RadDataPager buttons."
type: how-to
page_title: Move the Vertical Scrollbar to Top of RadGridView on PageIndexChanged of DataPager
slug: kb-gridview-scroll-to-top-on-pagechanged
tags: radgridview, raddatapager, scroll, page change, commands, top
res_type: kb
---

## Environment

| Property | Value |
| --- | --- |
| Product | RadGridView for WPF |
| Version | 2024.1.130 |

## Description

How to automatically scroll to the top of RadGridView when changing a page in the associated RadDataPager.

## Solution

To scroll to the top of the GridView, you can use the `ScrollItemIntoView` method of `RadGridView` or the `ScrollToTop` method of the `GridViewScrollViewer` in the `PageIndexChanged` event handler of `RadDataPager`.

The following code snippets show the two approaches:

__ScrollItemIntoView example__
```XAML
	private void RadDataPager_PageIndexChanged(object sender, Telerik.Windows.Controls.PageIndexChangedEventArgs e)
	{
		// the dispatcher delays the ScrollIntoView call
		Dispatcher.BeginInvoke(new Action(() =>
		{
			if (this.gridView.Items.Count > 0)
			{
				this.gridView.ScrollIntoView(this.gridView.Items[0]);
			}
		}));
	}
```

__ScrollToTop example__
```XAML
	private void RadDataPager_PageIndexChanged(object sender, Telerik.Windows.Controls.PageIndexChangedEventArgs e)
	{
		var scrollViewer = this.gridView.FindChildByType<GridViewScrollViewer>();
		if (scrollViewer != null)
		{
			scrollViewer.ScrollToTop();
		}
	}
```
