---
title: Prevent the closing of the panes in the auto-hide area when a ContextMenu is opened
description: This article demonstrates how to prevent RadPanes from closing in the auto-hide area when a ContextMenu is opened.
type: how-to
page_title: 
slug: kb-prevent-panes-auto-hide-context-menu-is-opened
position: 0
tags: docking, pane, prevent, auto-hide, auto hide, context menu,
ticketid: 1443675
res_type: kb
---

## Environment
<table>
	<tbody>
		<tr>
			<td>Product Version</td>
			<td>2019.3.917</td>
		</tr>
		<tr>
			<td>Product</td>
			<td>RadDocking for WPF</td>
		</tr>
	</tbody>
</table>


## Description

In the following solution we are going to demonstrates how to prevent RadPanes from closing in the auto-hide area when a ContextMenu is opened.

## Solution

To achieve this requirement you can handle the __ContextMenuOpening__ event of the element to which you've added the ContextMenu (the TextBlock in this case) and focus its content.

#### __[C#] Example 1: Subscribe to the ContextMenuOpening event__
    {{region cs-kb-prevent-panes-auto-hide-context-menu-is-opened-1}}
        private void TextBlock_ContextMenuOpening(object sender, ContextMenuEventArgs e)
        {
            var element = sender as FrameworkElement;
            element.Focus();
        }
    {{endregion}}

Please note that in the case of the TextBlock you also need to set its Focusable property to True.

#### __[C#] Example 2: Set Focusable to True__
    {{region cs-kb-prevent-panes-auto-hide-context-menu-is-opened-2}}
        <TextBlock Focusable="True" Text="Open the Context menu with right klick" ContextMenuOpening="TextBlock_ContextMenuOpening">
			<TextBlock.ContextMenu>
				<ContextMenu>
					<MenuItem Header="MenuItem1" />
					<MenuItem Header="MenuItem2" />
				</ContextMenu>
			</TextBlock.ContextMenu>
		</TextBlock>
    {{endregion}}