---
title: Implement RadGridView Endless Scrolling
description: How to add more items in RadGridView when the user scrolls to the bottom, by using the ScrollChanged event.
type: how-to
page_title: Implement Infinity Scrolling in RadGridView
slug: kb-gridview-infinity-scrolling
tags: radgridview, wpf, infinity, endless, scrolling
res_type: kb
ticketid: 1666946
---

## Environment

<table>
<tbody>
<tr>
<td>Product</td>
<td>RadGridView for WPF</td>
</tr>
<tr>
<td>Version</td>
<td>2024.3.821</td>
</tr>
</tbody>
</table>

## Description

How to implement endless/infinity scrolling in RadGridView, where new data items are added in the ItemsSource when the user scrolls to the bottom of the data view.

## Solution

To do this, you can get the `GridViewScrollViewer` of `RadGridView` and subscribe to its `ScrollChanged` event. When the user reaches the `ExtentHeight` of the scroll viewer, add the new portion of items.

#### __[C#] Implement infinity scrolling__
{{region kb-gridview-infinity-scrolling-0}}
	public partial class MainWindow : Window
	{
		private ObservableCollection<RowInfo> allData = new ObservableCollection<RowInfo>();
		private ObservableCollection<RowInfo> source = new ObservableCollection<RowInfo>();

		public MainWindow()
		{
			StyleManager.ApplicationTheme = new FluentTheme();
			InitializeComponent();

			allData = new ObservableCollection<RowInfo>();
			for (int i = 0; i < 1000; i++)
			{
				allData.Add(new RowInfo() { Name = "Item " + i, Number = i });
			}

			for (int i = 0; i < 50; i++)
			{
				source.Add(allData[i]);
			}        
			this.gridView.ItemsSource = source;            
		}

		private void gridView_Loaded(object sender, RoutedEventArgs e)
		{
			var scrollViewer = this.gridView.FindChildByType<GridViewScrollViewer>();
			scrollViewer.ScrollChanged += ScrollViewer_ScrollChanged;
		}

		private void ScrollViewer_ScrollChanged(object sender, System.Windows.Controls.ScrollChangedEventArgs e)
		{
			if ((e.VerticalOffset + e.ViewportHeight) == e.ExtentHeight)
			{
				var startIndex = source.Count - 1;
				var loadSize = 10;

				var itemsToLoad = allData.Skip(startIndex).Take(loadSize);
				foreach (var item in itemsToLoad)
				{
					source.Add(item);
				}
			}
		}
	}
{{endregion}}

