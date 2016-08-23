---
title: Use with Silverlight Navigation Framework
page_title: Use with Silverlight Navigation Framework
description: Use with Silverlight Navigation Framework
slug: radtransition-how-to-use-with-silverlight-navigation-framework
tags: use,with,silverlight,navigation,framework
published: True
position: 0
site_name: Silverlight
---

# Use with Silverlight Navigation Framework


The __RadTransitionControl__ can be used together with the __Silverlight Navigation Framework__ in order to apply transition effects, when navigating from one page to another. The only thing you have to do is to create a __ControlTemplate__ for the __Frame__ control and to place a __RadTransitionControl__ in it. This tutorial will walk you through the following:

* [Creating a ControlTemplate](#creating-a-controltemplate)

* [Defining and configuring a RadTransitionControl](#defining-and-configuring-a-radtransitioncontrol)

* [Set the ControlTemplate to the Frame](#set-the-controltemplate-to-the-frame)

## Creating a ControlTemplate

The first thing to do is to create a __ControlTemplate__ in your resources section, that targets the __Frame__ control.

>In order to use the __Frame__ control you have to add the following namespace declaration:
>	xmlns:navigation="clr-namespace:System.Windows.Controls;assembly=System.Windows.Controls.Navigation"

#### __XAML__

{{region xaml-radtransition-how-to-use-with-silverlight-navigation-framework_1}}
	<UserControl.Resources>
	    <ControlTemplate x:Name="FrameTemplate"
	                        TargetType="navigation:Frame">
	    </ControlTemplate>
	</UserControl.Resources>
{{endregion}}

## Defining and configuring a RadTransitionControl

Add a __RadTransitionControl__ to the __ControlTemplate__ and configure the appropriate __TemplateBindings__ for the __Content__ and the __ContentTemplate__ properties.

#### __XAML__

{{region xaml-radtransition-how-to-use-with-silverlight-navigation-framework_2}}
	<UserControl.Resources>
	    <ControlTemplate x:Name="FrameTemplate"
	                        TargetType="navigation:Frame">
	        <telerik:RadTransitionControl Content="{TemplateBinding Content}"
	                                        ContentTemplate="{TemplateBinding ContentTemplate}">
	        </telerik:RadTransitionControl>
	    </ControlTemplate>
	</UserControl.Resources>
{{endregion}}

By default there is no transition effect specified for the __RadtRansitionControl__, so you have to define one.

#### __XAML__

{{region xaml-radtransition-how-to-use-with-silverlight-navigation-framework_3}}
	<UserControl.Resources>
	    <ControlTemplate x:Name="FrameTemplate"
	                        TargetType="navigation:Frame">
	        <telerik:RadTransitionControl Content="{TemplateBinding Content}"
	                                        ContentTemplate="{TemplateBinding ContentTemplate}">
	            <telerik:RadTransitionControl.Transition>
	                <telerikTransitions:MotionBlurredZoomTransition />
	            </telerik:RadTransitionControl.Transition>
	        </telerik:RadTransitionControl>
	    </ControlTemplate>
	</UserControl.Resources>
{{endregion}}

## Set the ControlTemplate to the Frame

The last thing to do is to set the created __ControlTemplate__ to the __Frame__ control. Here is an example of how to do this.

#### __XAML__

{{region xaml-radtransition-how-to-use-with-silverlight-navigation-framework_4}}
	<navigation:Frame x:Name="MainFrame" Template="{StaticResource FrameTemplate}" />
{{endregion}}

# See Also

 * [Integration with Content Controls]({%slug radtransition-features-integration-with-content-controls%})

 * [Use with Prism]({%slug radtransition-how-to-use-with-prism%})

 * [Create Custom Transitions]({%slug radtransition-how-to-create-custom-transitions%})
