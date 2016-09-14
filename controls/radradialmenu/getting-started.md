---
title: Getting Started
page_title: Getting Started
description: Getting Started
slug: radradialmenu-getting-started
tags: getting,started
published: True
position: 1
---

# Getting Started

This topic will walk you through the creating of __RadRadialMenu__.    

>In order to use __RadRadialMenu__ in your project you have to add references to the following two assemblies:
> * Telerik.Windows.Controls.dll
> * Telerik.Windows.Controls.Navigation.dll

## RadRadialMenu as a Normal Menu

You can include the control in your page by either dragging it from the toolbox in Visual Studio, or manually creating the control. Below is an example of how to create the RadRadialMenu control in code behind and XAML code: 

#### __[XAML]  Creating RadRadialMenu__

{{region xaml-radradialmenu-getting-started_0}}
	<telerik:RadRadialMenu>
	    <telerik:RadRadialMenuItem Header="Item 1" />
	    <telerik:RadRadialMenuItem Header="Item 2" />
	    <telerik:RadRadialMenuItem Header="Item 3" />
	</telerik:RadRadialMenu>
{{endregion}}

where *telerik* namespace is defined like this:        

#### __[XAML]__

{{region xaml-radradialmenu-getting-started_1}}
	xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"  
{{endregion}}

#### __[C#] Creating RadRadialMenu with code__

{{region cs-radradialmenu-getting-started_2}}
	var radialMenu = new RadRadialMenu();
	
	radialMenu.Items.Add(new RadRadialMenuItem() { Header = "Item 1" });
	radialMenu.Items.Add(new RadRadialMenuItem() { Header = "Item 2" });
	radialMenu.Items.Add(new RadRadialMenuItem() { Header = "Item 3" });
{{endregion}}

## RadRadialMenu as a Context Menu

Here is a simple example demonstrating how to declare a __RadRadialMenu__ instance as a context menu for a TextBox using its __ShowEventName__ and __HideEventName__ properties.

#### __[XAML] RadialMenu as a ContextMenu__

{{region xaml-radradialmenu-getting-started_3}}
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

For further reference check [RadRadialMenu as a ContextMenu]({%slug radradialmenu-features-contextmenu%}) topic.

# See Also

 * [Getting Started]({%slug radradialmenu-getting-started%})

 * [RadRadialMenu as a ContextMenu]({%slug radradialmenu-features-contextmenu%})
