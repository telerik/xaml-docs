---
title: Getting Started
page_title: Getting Started
description: Getting Started
slug: radnumericupdown-drag-and-drop
tags: getting,started
published: True
position: 1
---

# Getting Started


This article will show you how to create a simple NumericUpDown.

>In order to use __RadNumericUpDown__ control in your projects you have to add references to the following assemblies:
>	1. __Telerik.Windows.Controls__
>	2. __Telerik.Windows.Controls.Input__

{% if site.site_name == 'Silverlight' %}
You can find more info [here]({%slug installation-installing-controls-dependencies%}).
{% endif %}

1. Drag and Drop the NumericUpDown control from the toolbox.

	![](images/RadNumeric1.gif)

1. After you have dropped the control onto the XAML you can manage the control by setting various properties to operate the control's behavior:

	#### __XAML__

	{{region radnumericupdown-drag-and-drop_0}}
		<telerik:RadNumericUpDown IsEditable="True" Minimum="10" Maximum="50"></telerik:RadNumericUpDown>
	{{endregion}}

>importantThe default value of the __RadNumericUpDown__ control is equal to __null__. If the desired behavior is to have the default value to be equal to another value make sure that it is set beforehand.