---
title: Add additional element inside RadTabbedWindow's header
description: This article demonstrates how to add additional element inside RadTabbedWindow's header.
type: how-to
page_title: How to add additional element inside RadTabbedWindow's header
slug: kb-add-additional-element-inside-radtabbedwindows-header
position: 0
tags: tabbedwindow, element, header
ticketid: 1444813
res_type: kb
---

## Environment
<table>
	<tbody>
		<tr>
			<td>Product Version</td>
			<td>2019.3.1023</td>
		</tr>
		<tr>
			<td>Product</td>
			<td>RadTabbedWindow for WPF</td>
		</tr>
	</tbody>
</table>


## Description

How to add additional element inside RadTabbedWindow's header.

## Solution

To achieve this requirement, you can subscribe to the Loaded event of RadTabbedWindow. Inside the event handler, you can get the StackPanel that holds the header buttons. Then, you can insert new buttons on the panel.

__Example 1: Subscribe to the ContextMenuOpening event__
    ```C#
        private void RadTabbedWindow_Loaded(object sender, RoutedEventArgs e)
		{
			var stackWithButtons = this.ChildrenOfType<StackPanel>().FirstOrDefault( x=> x.Name == "HeaderButtons");
			if (stackWithButtons != null)
			{
				stackWithButtons.Children.Insert(0, new RadButton() { Content = "My Custom Button" });
			}
		}
    ```