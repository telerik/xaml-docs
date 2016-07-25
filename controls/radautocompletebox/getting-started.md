---
title: Getting Started
page_title: Getting Started
description: Getting Started
slug: radautocompletebox-getting-started
tags: getting,started
published: True
position: 1
---

# Getting Started

Getting started with __RadAutoCompleteBox__ is pretty straightforward.

>In order to use __RadAutoCompleteBox__ in your project you have to add a reference to the following assemblies:
>	* __Telerik.Windows.Controls__
>	* __Telerik.Windows.Controls.Input__

## Adding RadAutoCompleteBox to the project

It is possible to include the control in your projects by either dragging it from the toolbox in Visual Studio and Expression Blend or by manually creating the control.

The following example shows how to create a __RadAutoCompleteBox__ control in the code behind and in XAML:

#### __[C#] Creating RadAutoCompleteBox__

{{region cs-radautocompletebox-getting-started-0}}
	RadAutoCompleteBox autoCompleteBox = new RadAutoCompleteBox();
{{endregion}}

#### __[VB] Creating RadAutoCompleteBox__

{{region vb-radautocompletebox-getting-started-0}}
	Dim autoCompleteBox As New RadAutoCompleteBox()
{{endregion}}

#### __[XAML] Creating RadAutoCompleteBox__

{{region xaml-radautocompletebox-getting-started-0}}
	<UserControl xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation">
	    <Grid x:Name="LayoutRoot" Background="White">
	        <telerik:RadAutoCompleteBox x:Name="radAutoCompleteBox"/>
	    </Grid>
	</UserControl>
{{endregion}}

# See Also

 * [Overview]({%slug radautocompletebox-overview%})
