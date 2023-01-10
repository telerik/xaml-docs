---
title: RadRadialMenu as a ContextMenu
page_title: RadRadialMenu as a ContextMenu
description: Check our &quot;RadRadialMenu as a ContextMenu&quot; documentation article for the RadRadialMenu {{ site.framework_name }} control.
slug: radradialmenu-features-contextmenu
tags: radradialmenu,as,a,contextmenu
published: True
position: 3
---

# {{ site.framework_name }} RadRadialMenu RadRadialMenu as a ContextMenu

__RadRadialMenu__ can be used as a context menu for another __FrameworkElement__. This can be done by using the __RadialContextMenu__ attached property defined in the __RadRadialMenu__ class. Additionally, you will need to set the events/actions of the target element on which the menu will be displayed and closed.

In this topic we will go through the different ways of setting __RadialMenu__ as a context menu such as:

* [Using ShowEventName/HideEventName properties](#using-showeventnamehideeventname-properties)

* [Using the static RadialMenuCommands class](#using-the-static-radialmenucommands-class)

## Using ShowEventName/HideEventName properties

When __RadRadialMenu__ is used as a context menu, you can set its __ShowEventName__ / __HideEventName__ to define the events of the target element on which it will be shown / closed.

__Example 1__ show how these properties can be used when the RadialContextMenu is attached to a TextBox:

#### __[XAML] Example 1: Setting ShowEventName/HideEventName properties__

{{region xaml-radradialmenu-features-contextmenu_0}}
	<TextBox Text="Some Text">
	    <telerik:RadRadialMenu.RadialContextMenu>
	        <telerik:RadRadialMenu ShowEventName="GotFocus" HideEventName="LostFocus">
	            <telerik:RadRadialMenuItem Header="Item 1" />
	            <telerik:RadRadialMenuItem Header="Item 2" />
	            <telerik:RadRadialMenuItem Header="Item 3" />
	        </telerik:RadRadialMenu>
	    </telerik:RadRadialMenu.RadialContextMenu>
	</TextBox>
{{endregion}}

>importantThe values set to ShowEventName/HideEventName should be valid event names of the target element.

## Using the static RadialMenuCommands class

The other option to define when the RadialContextMenu is shown/closed is through the static __RadialMenuCommands__ class and its __Show__ and __Hide__ commands.      

__RadialMenuCommands__ class can be used in the following ways:        

* With the Telerik [EventToCommandBehavior:]({%slug common-event-to-command-behavior%}) __Example 2__ shows how you can use EventToCommandBehavior to bind the Show/Hide commands to any of the target element's events:            

	#### __[XAML] Example 2: Using EventToCommandBehavior__

	{{region xaml-radradialmenu-features-contextmenu_1}}
		<TextBox Text="Some Text">
		    <telerik:EventToCommandBehavior.EventBindings>
		        <telerik:EventBinding EventName="GotFocus" Command="{x:Static telerik:RadialMenuCommands.Show}" />
		        <telerik:EventBinding EventName="LostFocus" Command="{x:Static telerik:RadialMenuCommands.Hide}" />
		    </telerik:EventToCommandBehavior.EventBindings>
		    <telerik:RadRadialMenu.RadialContextMenu>
		        <telerik:RadRadialMenu>
		            <!--...-->
		        </telerik:RadRadialMenu>
		    </telerik:RadRadialMenu.RadialContextMenu>
		</TextBox>
	{{endregion}}

* With InputBindings - you can add KeyBinding, for example, to the InputBindings collection of the target element in order to show/hide the RadialContextMenu when pressing a certain key. __Example 3__ demonstrates how to define showing it on clicking Ctrl+M and hiding it on clicking Escape key.         

	#### __[XAML] Example 3: Using InputBindings__

	{{region xaml-radradialmenu-features-contextmenu_2}}
		<TextBox Text="Some Text">
		    <TextBox.InputBindings>
		        <KeyBinding Modifiers="Control" Key="M" Command="{x:Static telerik:RadialMenuCommands.Show}" />
		        <KeyBinding Key="Escape" Command="{x:Static telerik:RadialMenuCommands.Hide}" />
		    </TextBox.InputBindings>
		    <telerik:RadRadialMenu.RadialContextMenu>
		        <telerik:RadRadialMenu>
		            <!--...-->
		        </telerik:RadRadialMenu>
		    </telerik:RadRadialMenu.RadialContextMenu>
		</TextBox>
	{{endregion}}

* In code-behind - __Example 4__ shows how you can explicitly call Show/Hide commands in code-behind.

	#### __[C#] Example 4: In code-behind__

	{{region cs-radradialmenu-features-contextmenu_3}}
		//show the RadialContextMenu
		RadialMenuCommands.Show.Execute(null, textBox1);
		
		//hide the RadialContextMenu
		RadialMenuCommands.Hide.Execute(null, textBox1);
	{{endregion}}

	where *textBox1* is the name of the target element to which the RadialContextMenu is attached.
