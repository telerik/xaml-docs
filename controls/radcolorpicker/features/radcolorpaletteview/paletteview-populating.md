---
title: Declaration
page_title: Declaration
description: Check our &quot;Declaration&quot; documentation article for the RadColorPicker {{ site.framework_name }} control.
slug: paletteview-populating
tags: declaration
published: True
position: 3
---

# Declaration

This article demonstrates how you can declare a __RadColorPaletteView__ and populate it with colors.

## XAML Declaration

#### __XAML__
```XAML
	<telerik:RadColorPaletteView />
```

## Dynamic creation

#### __C#__
```C#
	RadColorPaletteView colorPaletteView = new RadColorPaletteView();
```

#### __VB.NET__
```VB.NET
	Dim colorPaletteView As New RadColorPaletteView()
```

## Selection

The __SelectedItem__ property holds the selected color:				

#### __XAML__
```XAML
	colorPaletteView.SelectedItem = Colors.Red;
```

## Populating

You can use the __Palette__ property of __RadColorPaletteView__ to populate the paletteview with one of the built-in palettes.				

#### __XAML__
```XAML
	<telerik:RadColorPaletteView Palette="ColorPreset.Office" />
```

#### __C#__
```C#
	RadColorPaletteView colorPaletteView = new RadColorPaletteView();
	colorPaletteView.Palette = ColorPreset.Office;
```

#### __VB.NET__
```VB.NET
	Dim colorPaletteView As New RadColorPaletteView()
	colorPaletteView.Palette = ColorPreset.Office
```
    
__RadColorPaletteView__  also allows binding to various data source types through the __ItemSource__ property.				

#### __XAML__
```XAML
	<telerik:RadColorPaletteView ItemsSource="{Binding Source={StaticResource MyColorList}}" />
```

#### __C#__
```C#
	RadColorPaletteView colorPaletteView = new RadColorPaletteView();
	Collection<Color> colors = new Collection<Color>();
	colors.Add(Colors.Red);
	colors.Add(Colors.Green);
	colors.Add(Colors.Blue);
	colorPaletteView.ItemsSource = colors;
```

#### __VB.NET__
```VB.NET
	Dim colorPaletteView As New RadColorPaletteView()
	Dim colors1 As New Collection(Of Color)()
	colors1.Add(Colors.Red)
	colors1.Add(Colors.Green)
	colors1.Add(Colors.Blue)
	colorPaletteView.ItemsSource = colors1
```