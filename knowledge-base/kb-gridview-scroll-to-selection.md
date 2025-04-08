---
title: Programmatically Binding Selected Item Into View in RadGridView
description: Bring the RadGridView selected item into view programmatically
type: how-to
page_title: Scroll Automatically to the Selected Row in RadGridView 
slug: kb-gridview-scroll-to-selection
tags: scroll,bring,into,view,selection
res_type: kb
---

## Environment

| Product | Version |
| --- | --- |
| UI for WPF | 2024.1.312 |

## Description

How to automatically scroll to the selected row in RadGridView for WPF.

## Solution

To do that, you can use the `SelectionChanged` event of `RadGridView`. In the event handler, you can access the `GridViewScrollViewer` control and call its `ScrollToVerticalOffset`. The offset can be calculated based on the index of the selected row multiplied by the `RowHeight` setting of the data grid.

This approach can be wrapped in an attached property that can be re-used in multiple `RadGridView` instances.

#### __[C#]__
{{region kb-gridview-scroll-to-selection-0}}
	public class GridViewUtilities
	{
		public static readonly DependencyProperty ScrollSelectedIntoViewProperty =
			DependencyProperty.RegisterAttached("ScrollSelectedIntoView", typeof(bool), typeof(GridViewUtilities), new FrameworkPropertyMetadata(false, ScrollSelectedIntoViewPropertyChanged));
	 
		public static bool GetScrollSelectedIntoView(DependencyObject obj)
		{
			return (bool)obj.GetValue(ScrollSelectedIntoViewProperty);
		}
	 
		public static void SetScrollSelectedIntoView(DependencyObject obj, bool value)
		{
			obj.SetValue(ScrollSelectedIntoViewProperty, value);
		}
	 
		private static void ScrollSelectedIntoViewPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			var gridView = (RadGridView)d;
			if ((bool)e.NewValue)
			{		
				gridView.SelectionChanged += RadGridView_SelectionChanged;
			}
			else 
			{
				gridView.SelectionChanged -= RadGridView_SelectionChanged;
			}
		}
	 
		private static void RadGridView_SelectionChanged(object sender, SelectionChangeEventArgs e)
		{    
			var gridView = (RadGridView)sender;         
			if (gridView.SelectedItem != null)
			{
				var scrollOffset = gridView.Items.IndexOf(gridView.SelectedItem) * gridView.RowHeight;
				var scrollViewer = gridView.ChildrenOfType<GridViewScrollViewer>().First();
				var svo = scrollViewer.VerticalOffset;
				var svh = scrollViewer.ViewportHeight;
	 
				if(scrollOffset < svo || scrollOffset > (svo + svh))
				{
					scrollViewer.ScrollToVerticalOffset(scrollOffset);
				}
				else
				{
					scrollViewer.ScrollToVerticalOffset(svo);
				}             
			}
		} 
	}
{{endregion}}

#### __[XAML]__
{{region kb-gridview-scroll-to-selection-1}}
	<telerik:RadGridView local:GridViewUtilities.ScrollSelectedIntoView="True"/>
{{endregion}}
