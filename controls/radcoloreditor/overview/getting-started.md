---
title: Getting Started
page_title: Getting Started
description: Getting Started
slug: radcoloreditor-getting-started
tags: getting,started
published: True
position: 1
---

# Getting Started

This article will help you get started with the Telerik RadColorEditor control

## Selection

The __RadColorEditor__ is a control that displays a custom palette from which users can select a single color.				

>In order to use the __RadColorEditor__ in your projects you have to add references to the following assemblies:
>	- __Telerik.Windows.Controls__ 
>	- __Telerik.Windows.Controls.Input__  

>{% if site.site_name == 'WPF' %}You can find more info [here](http://www.telerik.com/help/wpf/installation-installing-controls-dependencies-wpf.html).{% endif %}
>{% if site.site_name == 'Silverlight' %}You can find more info [here](http://www.telerik.com/help/silverlight/installation-installing-controls-dependencies.html).{% endif %}

The control exposes a __SelectedColor__ property, which is of type __Color__ and is used to store the selected color value.						

#### __XAML__
{{region radcoloreditor-getting-started-0}}
	<telerik:RadColorEditor SelectedColor="Red" />
{{endregion}}

#### __C#__
{{region radcoloreditor-getting-started-0}}
	RadColorEditor colorEditor = new RadColorEditor();
	colorEditor.SelectedColor = Colors.Red;
{{endregion}}

#### __VB.NET__
{{region radcoloreditor-getting-started-0}}
	Dim colorEditor As New RadColorEditor()
	colorEditor.SelectedColor = Colors.Red
{{endregion}}

Whenever a color is selected the __SelectedColorChanged__ event is raised:						

#### __XAML__
{{region radcoloreditor-getting-started-1}}
	<telerik:RadColorEditor x:Name="colorEditor" SelectedColorChanged="colorEditor_SelectedColorChanged " />
{{endregion}}

#### __C#__
{{region radcoloreditor-getting-started-1}}
	colorEditor.SelectedColorChanged += new EventHandler<ColorChangeEventArgs>(colorEditor_SelectedColorChanged);
	
	private void colorEditor1_SelectedColorChanged(object sender, ColorChangeEventArgs e)
	{
	   Color selectedColor = e.Color;
	}
{{endregion}}

#### __VB.NET__
{{region radcoloreditor-getting-started-1}}
	colorEditor.SelectedColorChanged += New EventHandler(Of ColorChangeEventArgs)(colorEditor_SelectedColorChanged)
	
	Private Sub colorEditor1_SelectedColorChanged(ByVal sender As Object, ByVal e As ColorChangeEventArgs)
		Dim selectedColor As Color = e.Color
	End Sub
{{endregion}}

## See Also
 * [Overview]({%slug radcoloreditor-overview%})
 * [Structure]({%slug radcoloreditor-structure%})