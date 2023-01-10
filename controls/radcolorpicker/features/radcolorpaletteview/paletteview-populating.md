---
title: Declaration
page_title: Declaration
description: Check our &quot;Declaration&quot; documentation article for the RadColorPicker {{ site.framework_name }} control.
slug: paletteview-populating
tags: declaration
published: True
position: 3
---

# {{ site.framework_name }} RadColorPicker Declaration

This article demonstrates how you can declare a __RadColorPaletteView__ and populate it with colors.

## XAML Declaration

#### __XAML__
{{region paletteview-populating_0}}
	<telerik:RadColorPaletteView />
{{endregion}}

## Dynamic creation

#### __C#__
{{region paletteview-populating_1}}
	RadColorPaletteView colorPaletteView = new RadColorPaletteView();
{{endregion}}

#### __VB.NET__
{{region paletteview-populating_1}}
	Dim colorPaletteView As New RadColorPaletteView()
{{endregion}}

## Selection

The __SelectedItem__ property holds the selected color:				

#### __XAML__
{{region paletteview-populating_2}}
	colorPaletteView.SelectedItem = Colors.Red;
{{endregion}}

## Populating

You can use the __Palette__ property of __RadColorPaletteView__ to populate the paletteview with one of the built-in palettes.				

#### __XAML__
{{region paletteview-populating_4}}
	<telerik:RadColorPaletteView Palette="ColorPreset.Office" />
{{endregion}}

#### __C#__
{{region paletteview-populating_3}}
	RadColorPaletteView colorPaletteView = new RadColorPaletteView();
	colorPaletteView.Palette = ColorPreset.Office;
{{endregion}}

#### __VB.NET__
{{region paletteview-populating_3}}
	Dim colorPaletteView As New RadColorPaletteView()
	colorPaletteView.Palette = ColorPreset.Office
{{endregion}}
    
__RadColorPaletteView__  also allows binding to various data source types through the __ItemSource__ property.				

#### __XAML__
{{region paletteview-populating_6}}
	<telerik:RadColorPaletteView ItemsSource="{Binding Source={StaticResource MyColorList}}" />
{{endregion}}

#### __C#__
{{region paletteview-populating_5}}
	RadColorPaletteView colorPaletteView = new RadColorPaletteView();
	Collection<Color> colors = new Collection<Color>();
	colors.Add(Colors.Red);
	colors.Add(Colors.Green);
	colors.Add(Colors.Blue);
	colorPaletteView.ItemsSource = colors;
{{endregion}}

#### __VB.NET__
{{region paletteview-populating_5}}
	Dim colorPaletteView As New RadColorPaletteView()
	Dim colors1 As New Collection(Of Color)()
	colors1.Add(Colors.Red)
	colors1.Add(Colors.Green)
	colors1.Add(Colors.Blue)
	colorPaletteView.ItemsSource = colors1
{{endregion}}