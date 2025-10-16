---
title: Unpinned RadPane with WindowsFormsHost Hides on Click
description: This article describes a scenario where an unpinned RadPane containing a HwndHost content (like WinForms view) auto-hides when clicked, and provides a solution to prevent this behavior.
type: troubleshooting
page_title: Prevent Unpinned RadPane with HwndHost from Hiding on Click in WPF
slug: kb-docking-unpinned-pane-hide-on-winforms-content-click
tags: radpane, radwindow, windowsformshost, wpf, click, hide
res_type: kb
ticketid: 1672937
---

## Environment

<table>
<tbody>
<tr>
<td>Product</td>
<td>RadDocking for WPF</td>
</tr>
<tr>
<td>Version</td>
<td>2024.3.821</td>
</tr>
</tbody>
</table>

## Description

Unpinned RadPane elements with HwndHost (like WinFormsHost) content auto-hide on click insde the pane (over the HwndHost area).

## Cause

The issue occurs because of the interoperation between the WinForms and WPF technologies and their corresponding [regions](https://learn.microsoft.com/en-us/dotnet/desktop/wpf/advanced/technology-regions-overview?view=netframeworkdesktop-4.8) ("airspaces"). Clicking in the WinFormsHost content, steals the mouse from the WPF application, which triggers an event chain that closes the pane.

## Solution

To prevent this, change the FlyoutBehavior property of RadDocking from its default HoverFlyoutBehavior to [ClickFlyoutBehavior]({%slug raddocking-features-panes-flyoutbehavior%}).


```XAML
	<telerik:RadDocking.FlyoutBehavior>
		<telerik:ClickFlyoutBehavior/>
	</telerik:RadDocking.FlyoutBehavior>
```


