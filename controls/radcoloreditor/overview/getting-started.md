---
title: Getting Started
page_title: Getting Started
description: Check our &quot;Getting Started&quot; documentation article for the RadColorEditor {{ site.framework_name }} control.
slug: radcoloreditor-getting-started
tags: getting,started
published: True
position: 1
---

# Getting Started

This article will help you get started with the Telerik RadColorEditor control

## Assembly References

>In order to use the __RadColorEditor__ in your projects you have to add references to the following assemblies:
* __Telerik.Windows.Controls__
* __Telerik.Windows.Controls.Input__
>{% if site.site_name == 'WPF' %}You can find more info [here](http://www.telerik.com/help/wpf/installation-installing-controls-dependencies-wpf.html).{% endif %}
>{% if site.site_name == 'Silverlight' %}You can find more info [here](http://www.telerik.com/help/silverlight/installation-installing-controls-dependencies.html).{% endif %}

## Adding __RadColorEditor__ to the Project

You can add __RadColorEditor__ manually by writing the XAML code in __Example 1__. You can also add the control by dragging it from the Visual Studio Toolbox and dropping it over the XAML view.

#### __[XAML] Example 1: Adding RadColorEditor in XAML__
{{region radcoloreditor-getting-started_0}}
	<Grid>
		<telerik:RadColorEditor x:Name="colorEditor" />
	</Grid>
{{endregion}}

## Selection

The __RadColorEditor__ is a control that displays a custom palette from which users can select a single color. The control exposes a __SelectedColor__ property, which is of type __Color__ and is used to store the selected color value.						

#### __[XAML] Example 2: Setting the SelectedColor property__
{{region radcoloreditor-getting-started-1}}
	<telerik:RadColorEditor SelectedColor="Red" />
{{endregion}}

#### __[C#] Example 2: Setting the SelectedColor property in code behind__
{{region radcoloreditor-getting-started-2}}
	RadColorEditor colorEditor = new RadColorEditor();
	colorEditor.SelectedColor = Colors.Red;
{{endregion}}

#### __[VB.NET] Example 2: Setting the SelectedColor property in code behind__
{{region radcoloreditor-getting-started-3}}
	Dim colorEditor As New RadColorEditor()
	colorEditor.SelectedColor = Colors.Red
{{endregion}}

Whenever a color is selected the __SelectedColorChanged__ event is raised:						

#### __[XAML] Example 3: Subscribing to SelectedColorChanged event__
{{region radcoloreditor-getting-started-4}}
	<telerik:RadColorEditor x:Name="colorEditor" SelectedColorChanged="colorEditor_SelectedColorChanged " />
{{endregion}}

#### __[C#] Example 4: Subscribing to SelectedColorChanged event in code behind__
{{region radcoloreditor-getting-started-5}}
	colorEditor.SelectedColorChanged += new EventHandler<ColorChangeEventArgs>(colorEditor_SelectedColorChanged);
	
	private void colorEditor1_SelectedColorChanged(object sender, ColorChangeEventArgs e)
	{
	   Color selectedColor = e.Color;
	}
{{endregion}}

#### __[VB.NET] Example 4: Subscribing to SelectedColorChanged event in code behin__
{{region radcoloreditor-getting-started-6}}
	colorEditor.SelectedColorChanged += New EventHandler(Of ColorChangeEventArgs)(colorEditor_SelectedColorChanged)
	
	Private Sub colorEditor1_SelectedColorChanged(ByVal sender As Object, ByVal e As ColorChangeEventArgs)
		Dim selectedColor As Color = e.Color
	End Sub
{{endregion}}

## See Also
 * [Overview]({%slug radcoloreditor-overview%})
 * [Structure]({%slug radcoloreditor-structure%})