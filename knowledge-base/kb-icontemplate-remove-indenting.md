---
title: Remove Indenting From IconTemplate in RadNavigationView
description: "How to remove indenting from IconTemplate of the NavigationView element."
page_title: How to Hide Indentation From Icon Template of RadNavigationView for WPF
type: how-to 
slug: kb-icontemplate-remove-indenting
position: 0
tags: indenting,icontemplate,RadNavigationView
ticketid: 1601042
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
            <td>RadNavigationView for WPF</td>
        </tr>
    </tbody>
</table>	

## Description

How to remove indenting from `IconTemplate` of the `RadNavigationView` element.

## Solution 1

1. [Extract the ControlTemplate]({%slug styling-apperance-editing-control-templates%}) of `RadNavigationViewItem`.

2. In the `ControlTemplate` find the `Grid` panel with `x:Name` set to "ItemContentGrid" and change the `Width` of the first `ColumnDefinition`.

3. Apply the modified template to the `RadNavigationViewItem` elements.

## Solution 2

Use the [ChildrenOfType]({%slug common-visual-tree-helpers%}) extension method to get the `Grid` panel with `x:Name` set to "ItemContentGrid" and change the `Width` of the first `ColumnDefinition` .


```C#
	private void RadNavigationViewItem_Loaded(object sender, RoutedEventArgs e)
	{
		var itemContainer = (RadNavigationViewItem)sender;
		var panel = itemContainer.ChildrenOfType<Grid>().FirstOrDefault(x => x.Name == "ItemContentGrid");
		panel.ColumnDefinitions[0].Width = new GridLength(0);
	}
```
