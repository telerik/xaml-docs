---
title: Calling thread cannot access this object when opening RadDocking on another UI thread
type: how-to
page_title: InvalidOperationException is thrown when showing Docking on separate thread.
description: "The calling thread cannot access this object because a different thread owns it, when RadDocking is started on a new UI thread."
slug: kb-docking-invalidoperationexception-input-bindings
tags: raddocking, multiple-threads, exception, thread
res_type: kb
---

## Environment

| Product | Version |
| --- | --- |
| RadDocking for WPF | 2019.2.618 |

## Description

`InvalidOperationException` is thrown when `RadDocking` is hosted in a window that can be opened on separate UI threads. 

The exception message is: *"The calling thread cannot access this object because a different thread owns it."*

## Solution

This happens because of a `MouseBinding` defined in the `InputBindings` collection of one of the `RadDocking` visuals (the `PaneHeader` element).

To avoid the issue, you can add a new `Style` for the `PaneHeader` element in the Resources of the window that opens on the new UI thread.

#### __[XAML]__
{{region kb-docking-invalidoperationexception-input-bindings-0}}
	<UserControl.Resources>
		<!--If you use NoXaml dlls please add BasedOn="{StaticResource PaneHeaderStyle}" to the Style object. For example: -->
		<!--<Style TargetType="telerik:PaneHeader" BasedOn="{StaticResource PaneHeaderStyle}" >-->
		<Style TargetType="telerik:PaneHeader">
			<Setter Property="telerik:InputBindingsManager.InputBindings">
				<Setter.Value>
					<InputBindingCollection>
						<MouseBinding Command="telerikDocking:RadDockingCommands.PaneHeaderMenuOpen">
							<MouseBinding.Gesture>
								<MouseGesture MouseAction="RightClick" />
							</MouseBinding.Gesture>
						</MouseBinding>
					</InputBindingCollection>
				</Setter.Value>
			</Setter>
		</Style>
	</UserControl.Resources>
{{endregion}}

In some cases, you may need to merge this `Style` in the `Resources` of the opened `ToolWindow`. To do this, you can use the `ToolWindowCreated` event of `RadDocking`, where you can access the `Resources` of the window in code-behind.

