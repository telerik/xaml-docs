---
title: Bring RadTreeViewItem Into View With Offset When UI Virtualization is Enabled
description: How to bring RadTreeViewItem by path into the view with an offset, when UI virtualization is enabled.
type: how-to
page_title: BringPathIntoView With Offset When RadTreeView IsVirtualizing is True
slug: kb-treeview-bringpathintoview-offset-virtualization
tags: radtreeview, wpf, bring-into-view, virtualization,offset
res_type: kb
---

## Environment

| Product | Version |
|---------|---------|
| RadTreeView for WPF | 2023.3.1114 |

## Description

How to bring an item into the viewport and apply an offset when using the [BringPathIntoView]({%slug radtreeview-features-treeviewitem-bring-into-view-support%}#bringpathintoview) method of RadTreeView and the UI virtualization is enabled.

The method will bring the item into the viewport, but because of the UI virtualization its position won't be top-left and therefore the applied offset won't work properly.

## Solution

To make this work with a specific offset, you can manually scroll the ScrollViewer to the required position.


```C#
	private void OnBringItemIntoView(MyTreeItem item, string path, double offsetY)
	{   
		this.radTreeView.BringPathIntoView(path);

		Dispatcher.BeginInvoke(new Action(() =>
		{
			RadTreeViewItem container = this.radTreeView.ContainerFromItemRecursive(item);
			Rect bounds = BoundsRelativeTo(container, this.radTreeView);

			var scrollViewer = this.radTreeView.FindChildByType<ScrollViewer>();
			double newOffset = scrollViewer.VerticalOffset + bounds.Y - offsetY;
			scrollViewer.ScrollToVerticalOffset(newOffset);

		}), (System.Windows.Threading.DispatcherPriority)4);
	}
	
	public static Rect BoundsRelativeTo(FrameworkElement child, Visual parent)
	{
		GeneralTransform gt = child.TransformToAncestor(parent);
		return gt.TransformBounds(new Rect(0, 0, child.ActualWidth, child.ActualHeight));
	}
```
