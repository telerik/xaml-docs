---
title: Declaration
page_title: Declaration
description: Declaration
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
	{{region colorselector-populating_1}}
		<telerik:RadColorSelector SelectedColor="Red" />
	{{endregion}}

	#### __C#__
	{{region colorselector-populating_0}}
		RadColorSelector colorSelector = new RadColorSelector();
		colorSelector.SelectedColor = Colors.Red;
	{{endregion}}

	#### __VB.NET__
	{{region colorselector-populating_0}}
		Dim colorSelector As New RadColorSelector()
		colorSelector.SelectedColor = Colors.Red
	{{endregion}}

* Whenever a color is selected the __SelectedColorChanged__ event is raised:						

	#### __C#__
	{{region colorselector-populating_2}}
		colorSelector.SelectedColorChanged += new EventHandler(colorSelector_SelectedColorChanged);
		
		 void colorSelector_SelectedColorChanged(object sender, EventArgs e)
		{
		   RadColorSelector selector = sender as RadColorSelector;
		   Color selectedColor = selector.SelectedColor;
		}
	{{endregion}}

	#### __VB.NET__
	{{region colorselector-populating_2}}
			colorSelector.SelectedColorChanged += New EventHandler(colorSelector_SelectedColorChanged)
		
			Private Sub colorSelector_SelectedColorChanged(ByVal sender As Object, ByVal e As EventArgs)
				Dim selector As RadColorSelector = TryCast(sender, RadColorSelector)
				Dim selectedColor As Color = selector.SelectedColor
			End Sub
		{{endregion}}
		
## Populating

You can populate the __RadColorSelector__ with any of the built-in palettes using the __ColorPreset__ enumeration. It has __HeaderPalette__, __MainPalette__ and __StandardPalette__ properties, which represent the corresponding parts of the selector.				

* __MainPalette__ property:						

	#### __XAML__
	{{region colorselector-populating_4}}
		<telerik:RadColorSelector MainPalette="Grayscale" />
	{{endregion}}

	#### __C#__
	{{region colorselector-populating_3}}
		RadColorSelector colorSelector = new RadColorSelector();
		colorSelector.MainPalette = ColorPreset.Grayscale;
	{{endregion}}

	#### __VB.NET__
	{{region colorselector-populating_3}}
			Dim colorSelector As New RadColorSelector()
			colorSelector.MainPalette = ColorPreset.Grayscale
	{{endregion}}

* __HeaderPalette__ property:								

	#### __XAML__
	{{region colorselector-populating_6}}
		<telerik:RadColorSelector HeaderPalette="Office" />
	{{endregion}}

	#### __C#__
	{{region colorselector-populating_5}}
		RadColorSelector colorSelector = new RadColorSelector();
		colorSelector.HeaderPalette = ColorPreset.Office;
	{{endregion}}

	#### __VB.NET__
	{{region colorselector-populating_5}}
		Dim colorSelector As New RadColorSelector()
		colorSelector.HeaderPalette = ColorPreset.Office
	{{endregion}}

* __StandardPalette__ property:								

	#### __XAML__
	{{region colorselector-populating_8}}
		<telerik:RadColorSelector StandardPalette="Standard" />
	{{endregion}}

	#### __C#__
	{{region colorselector-populating_7}}
		RadColorSelector colorSelector = new RadColorSelector();
		colorSelector.StandardPalette = ColorPreset.Standard;
	{{endregion}}

	#### __VB.NET__
	{{region colorselector-populating_7}}
		Dim colorSelector As New RadColorSelector()
		colorSelector.StandardPalette = ColorPreset.Standard
	{{endregion}}

* If you prefer to use your own collection of __Colors__ you can always use __HeaderPaletteItemsSource__, __MainPaletteItemsSource__ and __StandardPaletteItemsSource__.						
	* __StandardPaletteItemSource__ property								

		#### __XAML__
		{{region colorselector-populating_10}}
			<telerik:RadColorSelector StandardPaletteItemsSource="{Binding Source={StaticResource ColorList}}" />
		{{endregion}}

		#### __C#__
		{{region colorselector-populating_9}}
			RadColorSelector colorSelector = new RadColorSelector();
			colorSelector.StandardPaletteVisibility = Visibility.Visible;
			Collection<Color> colors = new Collection<Color>();
			colors.Add(Colors.Red);
			colors.Add(Colors.Green);
			colors.Add(Colors.Blue);
			colorSelector.StandardPaletteItemsSource = colors;
		{{endregion}}

		#### __VB.NET__
		{{region colorselector-populating_9}}
			Dim colorSelector As New RadColorSelector()
			colorSelector.StandardPaletteVisibility = Visibility.Visible
			Dim colors As New Collection(Of Color)()
			_colors.Add(Colors.Red)
			_colors.Add(Colors.Green)
			_colors.Add(Colors.Blue)
			_colorSelector.StandardPaletteItemsSource = _colors
		{{endregion}}

	* __HeaderPaletteItemSource__ property								

		#### __XAML__
		{{region colorselector-populating_12}}
			<telerik:RadColorSelector HeaderPaletteItemsSource="{Binding Source={StaticResource ColorList}}" />
		{{endregion}}

		#### __C#__
		{{region colorselector-populating_11}}
			RadColorSelector colorSelector = new RadColorSelector();
			colorSelector.HeaderPaletteVisibility = Visibility.Visible;
			Collection<Color> colors = new Collection<Color>();
			colors.Add(Colors.Red);
			colors.Add(Colors.Green);
			colors.Add(Colors.Blue);
			colorSelector.HeaderPaletteItemsSource = colors;
		{{endregion}}

		#### __VB.NET__
		{{region colorselector-populating_11}}
			Dim colorSelector As New RadColorSelector()
			colorSelector.HeaderPaletteVisibility = Visibility.Visible
			Dim _colors As New Collection(Of Color)()
			_colors.Add(Colors.Red)
			_colors.Add(Colors.Green)
			_colors.Add(Colors.Blue)
			colorSelector.HeaderPaletteItemsSource = _colors
		{{endregion}}

	* __MainPaletteItemSource__ property  

		#### __XAML__
		{{region colorselector-populating_14}}
			<telerik:RadColorSelector MainPaletteItemsSource="{Binding Source={StaticResource ColorList}}" />
		{{endregion}}

		#### __C#__
		{{region colorselector-populating_13}}
			RadColorSelector colorSelector = new RadColorSelector();
			Collection<Color> colors = new Collection<Color>();
			colors.Add(Colors.Red);
			colors.Add(Colors.Green);
			colors.Add(Colors.Blue);
			colorSelector.MainPaletteItemsSource = colors;
		{{endregion}}

		#### __VB.NET__
		{{region colorselector-populating_13}}
			Dim colorSelector As New RadColorSelector()
			Dim _colors As New Collection(Of Color)()
			_colors.Add(Colors.Red)
			_colors.Add(Colors.Green)
			_colors.Add(Colors.Blue)
			colorSelector.MainPaletteItemsSource = _colors
		{{endregion}}