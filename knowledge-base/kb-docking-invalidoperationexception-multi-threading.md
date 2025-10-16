---
title: InvalidOperationException When Using RadDocking on Different UI Threads
page_title: InvalidOperationException Thrown If RadDocking Used on Multi Threads
description: The calling thread cannot access this object because a different thread owns it - message shown when RadDocking is shown on a separate UI thread.
type: troubleshooting
slug: kb-docking-invalidoperationexception-multi-threading
position: 0
tags: multithreading,invalidoperationexception,docking,pane
ticketid: 1425680
res_type: kb
---

## Environment
<table>
    <tbody>
	    <tr>
	    	<td>Product Version</td>
	    	<td>2019.2.618</td>
	    </tr>
	    <tr>
	    	<td>Product</td>
	    	<td>RadDocking for WPF</td>
	    </tr>
    </tbody>
</table>

## Description

"InvalidOperationException: The calling thread cannot access this object because a different thread owns it" thrown when RadDocking pane is opened in a thread different than the main UI thread. The error appears when try to interact with a RadPane's header.

## Solution

Define a custom Style targeting the PaneHeader control. Preferably, the Style should be defined in the Resources of the Window or UserControl that shows the RadDocking on the separate thread. The Style should re-define the mouse right-click input binding of the header.


```XAML
	<Window.Resources>
		<!-- If you use NoXaml dlls set the following property on the Style object: BasedOn="{StaticResource PaneHeaderStyle}" -->
		<Style TargetType="telerik:PaneHeader">
			<Setter Property="telerik:InputBindingsManager.InputBindings">
				<Setter.Value>
					<InputBindingCollection>
						<MouseBinding Command="telerik:RadDockingCommands.PaneHeaderMenuOpen">
							<MouseBinding.Gesture>
								<MouseGesture MouseAction="RightClick" />
							</MouseBinding.Gesture>
						</MouseBinding>
					</InputBindingCollection>
				</Setter.Value>
			</Setter>
		</Style>
	</Window.Resources>
```
