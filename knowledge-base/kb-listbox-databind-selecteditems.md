---
title: Data Binding RadListBox SelectedItems Property
description: How to data bind the SeletedItems of RadListBox to a view model collection.
type: how-to
page_title: How to Data Bind the SelectedItemsSource collection of Telerik ListBox
slug: kb-listbox-databind-selecteditems
tags: data, binding, selection
res_type: kb
---

## Environment

| Property | Value |
| --- | --- |
| Product | RadListBox for WPF |
| Version | 2024.1.312 |

## Description

How to data bind the `SelectedItems` of `RadListBox` to a collection property in the view model.

## Solution

This can be done via the [ListBoxSelectedItemsBehavior.SelectedItemsSource]({%slug radlistbox-features-selecteditemssource%}) attached property.

__Defining the view model__
```C#
	public class MainViewModel
	{
		public MainViewModel()
		{
			Items = new ObservableCollection<MyItemType>();
			// populate the Items collection
			
			SelectedItems = new ObservableCollection<MyItemType>();
		}
	  
		public ObservableCollection<MyItemType> Items { get; set; }
		public ObservableCollection<MyItemType> SelectedItems { get; set; }  
	}
```

__Setting the SelectedItemsSource property__
```XAML
	<telerik:RadListBox ItemsSource="{Binding Items}"
						telerik:ListBoxSelectedItemsBehavior.SelectedItemsSource="{Binding SelectedItems}"
						SelectionMode="Multiple" />
```

