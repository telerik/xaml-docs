---
title: Prevent Scroll Jumping When Selecting an Item in a Grouping Scenario With ScrollViewer.CanContentScroll Set to False.
description: This article shows how you can disable the jumping of the scroll when selecting an item in a grouping scenario with CanContentScroll set to False.
page_title: Disable Scroll Jumping in Grouping and ScrollViewer.CanContentScroll Set to False Scenario When Selecting an Item.
type: troubleshooting
slug: kb-listbox-grouping-unwanted-scroll
position: 0
tags: wpf, listbox, cancontentscroll, false, group
res_type: kb
---

## Environment

<table>
	<tbody>
		<tr>
			<td>Product Version</td>
			<td>2024.2.514</td>
		</tr>
		<tr>
			<td>Product</td>
			<td>RadListBox for WPF</td>
		</tr>
	</tbody>
</table>

## Description

Selecting an item when [grouping]({%slug radlistbox-how-to-group-items%}) is applied and the `ScrollViewer.CanContentScroll` is set to __False__ causes the `RadListBox`'s scrolling to jump.

## Solution

To disable this behavior, set the `IsScrollIntoViewEnabled` property of the RadListBox control to __False__. This will disable the automatic scroll into view logic when selecting a new item.

__Setting the IsScrollIntoViewEnabled property of RadListBox to False__
```XAML
    <telerik:RadListBox
        DisplayMemberPath="MyPropertyName"
        IsScrollIntoViewEnabled="False"
        ItemsSource="{Binding MyCollection}"
        ScrollViewer.CanContentScroll="False">
        <telerik:RadListBox.GroupStyle>
            <GroupStyle />
        </telerik:RadListBox.GroupStyle>
    </telerik:RadListBox>
```