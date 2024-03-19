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

#### __[C#] Defining the view model__
{{region kb-listbox-databind-selecteditems-0}}
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
{{endregion}}

#### __[XAML] Setting the SelectedItemsSource property__
{{region kb-listbox-databind-selecteditems-1}}
	<telerik:RadListBox ItemsSource="{Binding Items}"
						telerik:ListBoxSelectedItemsBehavior.SelectedItemsSource="{Binding SelectedItems}"
						SelectionMode="Multiple" />
{{endregion}}

