---
title: Declaration
page_title: Declaration
description: Check our &quot;Declaration&quot; documentation article for the RadColorPicker {{ site.framework_name }} control.
slug: colorselector-populating
tags: declaration
published: True
position: 1
---

# Declaration

This article demonstrates how you can declare a __RadColorSelector__ and populate it with colors.

## Selection

* __RadColorSelector__ has a __SelectedColor__ property, which is of type __Color__ and it is used to store selected color value.					

	#### __XAML__
	```XAML
		<telerik:RadColorSelector SelectedColor="Red" />
	```

	#### __C#__
	```C#
		RadColorSelector colorSelector = new RadColorSelector();
		colorSelector.SelectedColor = Colors.Red;
	```

	#### __VB.NET__
	```VB.NET
		Dim colorSelector As New RadColorSelector()
		colorSelector.SelectedColor = Colors.Red
	```

* Whenever a color is selected the __SelectedColorChanged__ event is raised:						

	#### __C#__
	```C#
		colorSelector.SelectedColorChanged += new EventHandler(colorSelector_SelectedColorChanged);
		
		 void colorSelector_SelectedColorChanged(object sender, EventArgs e)
		{
		   RadColorSelector selector = sender as RadColorSelector;
		   Color selectedColor = selector.SelectedColor;
		}
	```

	#### __VB.NET__
	```VB.NET
			colorSelector.SelectedColorChanged += New EventHandler(colorSelector_SelectedColorChanged)
		
			Private Sub colorSelector_SelectedColorChanged(ByVal sender As Object, ByVal e As EventArgs)
				Dim selector As RadColorSelector = TryCast(sender, RadColorSelector)
				Dim selectedColor As Color = selector.SelectedColor
			End Sub
		```
		
## Populating

You can populate the __RadColorSelector__ with any of the built-in palettes using the __ColorPreset__ enumeration. It has __HeaderPalette__, __MainPalette__ and __StandardPalette__ properties, which represent the corresponding parts of the selector.				

* __MainPalette__ property:						

	#### __XAML__
	```XAML
		<telerik:RadColorSelector MainPalette="Grayscale" />
	```

	#### __C#__
	```C#
		RadColorSelector colorSelector = new RadColorSelector();
		colorSelector.MainPalette = ColorPreset.Grayscale;
	```

	#### __VB.NET__
	```VB.NET
			Dim colorSelector As New RadColorSelector()
			colorSelector.MainPalette = ColorPreset.Grayscale
	```

* __HeaderPalette__ property:								

	#### __XAML__
	```XAML
		<telerik:RadColorSelector HeaderPalette="Office" />
	```

	#### __C#__
	```C#
		RadColorSelector colorSelector = new RadColorSelector();
		colorSelector.HeaderPalette = ColorPreset.Office;
	```

	#### __VB.NET__
	```VB.NET
		Dim colorSelector As New RadColorSelector()
		colorSelector.HeaderPalette = ColorPreset.Office
	```

* __StandardPalette__ property:								

	#### __XAML__
	```XAML
		<telerik:RadColorSelector StandardPalette="Standard" />
	```

	#### __C#__
	```C#
		RadColorSelector colorSelector = new RadColorSelector();
		colorSelector.StandardPalette = ColorPreset.Standard;
	```

	#### __VB.NET__
	```VB.NET
		Dim colorSelector As New RadColorSelector()
		colorSelector.StandardPalette = ColorPreset.Standard
	```

* If you prefer to use your own collection of __Colors__ you can always use __HeaderPaletteItemsSource__, __MainPaletteItemsSource__ and __StandardPaletteItemsSource__.						
	* __StandardPaletteItemSource__ property								

		#### __XAML__
		```XAML
			<telerik:RadColorSelector StandardPaletteItemsSource="{Binding Source={StaticResource ColorList}}" />
		```

		#### __C#__
		```C#
			RadColorSelector colorSelector = new RadColorSelector();
			colorSelector.StandardPaletteVisibility = Visibility.Visible;
			Collection<Color> colors = new Collection<Color>();
			colors.Add(Colors.Red);
			colors.Add(Colors.Green);
			colors.Add(Colors.Blue);
			colorSelector.StandardPaletteItemsSource = colors;
		```

		#### __VB.NET__
		```VB.NET
			Dim colorSelector As New RadColorSelector()
			colorSelector.StandardPaletteVisibility = Visibility.Visible
			Dim colors As New Collection(Of Color)()
			_colors.Add(Colors.Red)
			_colors.Add(Colors.Green)
			_colors.Add(Colors.Blue)
			_colorSelector.StandardPaletteItemsSource = _colors
		```

	* __HeaderPaletteItemSource__ property								

		#### __XAML__
		```XAML
			<telerik:RadColorSelector HeaderPaletteItemsSource="{Binding Source={StaticResource ColorList}}" />
		```

		#### __C#__
		```C#
			RadColorSelector colorSelector = new RadColorSelector();
			colorSelector.HeaderPaletteVisibility = Visibility.Visible;
			Collection<Color> colors = new Collection<Color>();
			colors.Add(Colors.Red);
			colors.Add(Colors.Green);
			colors.Add(Colors.Blue);
			colorSelector.HeaderPaletteItemsSource = colors;
		```

		#### __VB.NET__
		```VB.NET
			Dim colorSelector As New RadColorSelector()
			colorSelector.HeaderPaletteVisibility = Visibility.Visible
			Dim _colors As New Collection(Of Color)()
			_colors.Add(Colors.Red)
			_colors.Add(Colors.Green)
			_colors.Add(Colors.Blue)
			colorSelector.HeaderPaletteItemsSource = _colors
		```

	* __MainPaletteItemSource__ property  

		#### __XAML__
		```XAML
			<telerik:RadColorSelector MainPaletteItemsSource="{Binding Source={StaticResource ColorList}}" />
		```

		#### __C#__
		```C#
			RadColorSelector colorSelector = new RadColorSelector();
			Collection<Color> colors = new Collection<Color>();
			colors.Add(Colors.Red);
			colors.Add(Colors.Green);
			colors.Add(Colors.Blue);
			colorSelector.MainPaletteItemsSource = colors;
		```

		#### __VB.NET__
		```VB.NET
			Dim colorSelector As New RadColorSelector()
			Dim _colors As New Collection(Of Color)()
			_colors.Add(Colors.Red)
			_colors.Add(Colors.Green)
			_colors.Add(Colors.Blue)
			colorSelector.MainPaletteItemsSource = _colors
		```