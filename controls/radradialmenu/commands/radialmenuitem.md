---
title: RadialMenuItem Commands
page_title: RadialMenuItem Commands
description: Check our &quot;RadialMenuItem Commands&quot; documentation article for the RadRadialMenu {{ site.framework_name }} control.
slug: radradialmenu-commands-radialmenuitem
tags: radialmenuitem,commands
published: True
position: 1
---

# RadialMenuItem Commands

__RadRadialMenuItem__ provides a __Command__ property that can be bound to an __ICommand__ implementation. The execution of the command is triggered by click/tap event. The parameter passed to the command is set through the __CommandParameter__ property of the RadialMenuItem.        

## Create a Command

Here is an example demonstrating how to add a command to a RadialMenuItem.

1. First, create a class that implements the __ICommand__ interface. __Example 1__ shows a sample implementation.          

	<snippet id='radradialmenu-commands-radialmenuitem-block_1-cs' />

1. Add an instance of the custom command class to the Resources of the UserControl.

	<snippet id='radradialmenu-commands-radialmenuitem-block_2-xaml' />

1. Bind the __Command__ property of the RadialMenuItem to the instance of the custom command as shown in __Example 3__.          

	<snippet id='radradialmenu-commands-radialmenuitem-block_3-xaml' />

## See Also

 * [RadialMenu Commands]({%slug radradialmenu-commands-radialmenu%})