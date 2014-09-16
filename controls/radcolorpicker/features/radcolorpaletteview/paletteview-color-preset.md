---
title: Color Preset
page_title: Color Preset
description: Color Preset
slug: paletteview-color-preset
tags: color,preset
publish: True
position: 1
---

# Color Preset



## 

__ColorPreset__ is an enum that represent all built-in palettes.
				

You can use it to set  the __Palette__ property of RadColorPaletteView or
					__HeaderPalette__/__StandardPalette__/__MainPalette__
					properties of the __RadColorSelector__.
				

	
					public enum ColorPreset
					{
						None,
						Default,
						Standard,
						Grayscale,
						Web216,
						ReallyWebSafe,
						// MS word named presets below
						Office,
						Apex,
						Aspect,
						Civic,
						Concourse,
						Equity,
						Flow,
						Foundry,
						Median,
						Metro,
						Module,
						Opulent,
						Oriel,
						Origin,
						Paper,
						Solstice,
						Technic,
						Trek,
						Urban,
						Verve
					}
				



#### __XAML__

{{region paletteview-color-preset_0}}
	<telerik:RadColorPaletteView Palette="Office" />
	<telerik:RadColorSelector MainPalette="Office" />
	{{endregion}}



#### __C#__

{{region paletteview-color-preset_1}}
	RadColorPaletteView colorPaletteView = new RadColorPaletteView();
	colorPaletteView.Palette = ColorPreset.Office;
	RadColorSelector colorSelector = new RadColorSelector();
	colorSelector.MainPalette = ColorPreset.Office;
	{{endregion}}



#### __VB.NET__

{{region paletteview-color-preset_1}}
		Dim colorPaletteView As New RadColorPaletteView()
		colorPaletteView.Palette = ColorPreset.Office
		Dim colorSelector As New RadColorSelector()
		colorSelector.MainPalette = ColorPreset.Office
	#End Region
	
	End Class


