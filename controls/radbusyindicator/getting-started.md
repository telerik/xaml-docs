---
title: Getting Started
page_title: Getting Started
description: Getting Started
slug: radbusyindicator-getting-started
tags: getting,started
published: True
position: 2
---

# Getting Started



The __RadBusyIndicator__is a control which gives you the ability to notify the user that there is an ongoing process in the application. This tutorial will help you get started with the __RadBusyIndicator__ basics. 

* [Create a RadBusyIndicator control](#Create_a_RadBusyIndicator_control)

* [Enable the RadBusyIndicator](#Enable_the_RadBusyIndicator)

* [Styles and Templates](#Styles_and_Templates)

* [Working with the RadBusyIndicator](#Working_with_the_RadBusyIndicator_control)

## Create a RadBusyIndicator control

In order to add a __RadBusyIndicator__to your application, you have to simply create an instance of it in your XAML. 

>

As the __RadBusyIndicator__is located in the __Telerik.Windows.Controls__namespace of the __Telerik.Windows.Controls__assembly, you have to add references to the following assembly to your project:

* __Telerik.Windows.Controls__

You also have to declare the following namespace in your __UserControl:______

#### __XAML__

{{region radbusyindicator-getting-started_0}}
	xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"
	{{endregion}}



 Here is a sample code:

#### __XAML__

{{region radbusyindicator-getting-started_1}}
	<telerik:RadBusyIndicator x:Name="radBusyIndicator">
	    <!--Some Content-->
	</telerik:RadBusyIndicator>
	{{endregion}}



You can also create a __RadBusyIndicator__ in code-behind:

#### __C#__

{{region radbusyindicator-getting-started_2}}
	RadBusyIndicator busyIndicator = new RadBusyIndicator();
	{{endregion}}



#### __VB.NET__

{{region radbusyindicator-getting-started_3}}
	Dim busyIndicator As New RadBusyIndicator()
	{{endregion}}



>

When you are using the __RadBusyIndicator__ control you always have to set its __Content__ property. This will be the content on top of which you want to visualize the __RadBusyIndicator__ control.

## Enable the RadBusyIndicator

In order to display the __RadBusyIndicator__ in your application you will have to use its __IsBusy__ property. When set to __True__ the __RadBusyIndicator__ control becomes visible.

## Styles and Templates

Take a look at the [Styles and Templates]({%slug radbusyindicator-styles-and-templates-overview%}) section which is entirely dedicated to styling and templating the __RadBusyIndicator__ control.

##  Working with the RadBusyIndicator control

In order to learn how to use the __RadBusyIndicator__ and what capabilities it holds, read the various topics that describe its features. Learn more about the:

* [Progress Determination]({%slug radbusyindicator-features-progress-determination%})

* [Report changing progress values]({%slug radbusyindicator-features-report-progress-value%})

* [Define custom Busy Content]({%slug radbusyindicator-features-custom-busy-content%})

* [Delay the RadBusyIndicator's display]({%slug radbusyindicator-features-delayed-display%})

* [Use the RadBusyindicator when calling service methods]({%slug radbusyindicator-how-to-integrate-with-services-and-radwindow%})

# See Also

 * [Overview]({%slug radbusyindicator-overview%})

 * [Visual Structure]({%slug radbusyindicator-visual-structure%})

 * [Styles and Templates - Overview]({%slug radbusyindicator-styles-and-templates-overview%})
