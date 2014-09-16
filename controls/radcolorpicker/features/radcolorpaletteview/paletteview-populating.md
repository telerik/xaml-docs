---
title: Declaration
page_title: Declaration
description: Declaration
slug: paletteview-populating
tags: declaration
publish: True
position: 3
---

# Declaration



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
	#End Region
	
	
	End Class



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
	#End Region
	
	#Region "paletteview-populating_5"
		Dim colorPaletteView As New RadColorPaletteView()
		Dim colors1 As New Collection(Of Color)()
		colors1.Add(Colors.Red)
		colors1.Add(Colors.Green)
		colors1.Add(Colors.Blue)
		colorPaletteView.ItemsSource = colors1
	#End Region
	#Region "paletteview-populating_1"
		Dim colorPaletteView As New RadColorPaletteView()
	#End Region
	
	
	End Class



__RadColorPaletteView__  also allows binding to various datasource types through the __ItemSource__ property.
				

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
	#End Region
	#Region "paletteview-populating_1"
		Dim colorPaletteView As New RadColorPaletteView()
	#End Region
	
	
	End Class


