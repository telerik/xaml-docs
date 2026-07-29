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

	<snippet id='radcolorpicker-features-radcolorselector-colorselector-populating-block_1-xaml' />


	<snippet id='radcolorpicker-features-radcolorselector-colorselector-populating-block_2-cs' />

	<snippet id='radcolorpicker-features-radcolorselector-colorselector-populating-block_2-vb' />


* Whenever a color is selected the __SelectedColorChanged__ event is raised:						

	<snippet id='radcolorpicker-features-radcolorselector-colorselector-populating-block_3-cs' />

	<snippet id='radcolorpicker-features-radcolorselector-colorselector-populating-block_3-vb' />

		
## Populating

You can populate the __RadColorSelector__ with any of the built-in palettes using the __ColorPreset__ enumeration. It has __HeaderPalette__, __MainPalette__ and __StandardPalette__ properties, which represent the corresponding parts of the selector.				

* __MainPalette__ property:						
	
	<snippet id='radcolorpicker-features-radcolorselector-colorselector-populating-block_4-xaml' />


	<snippet id='radcolorpicker-features-radcolorselector-colorselector-populating-block_5-cs' />

	<snippet id='radcolorpicker-features-radcolorselector-colorselector-populating-block_5-vb' />


* __HeaderPalette__ property:								

	<snippet id='radcolorpicker-features-radcolorselector-colorselector-populating-block_6-xaml' />


	<snippet id='radcolorpicker-features-radcolorselector-colorselector-populating-block_7-cs' />

	<snippet id='radcolorpicker-features-radcolorselector-colorselector-populating-block_7-vb' />


* __StandardPalette__ property:								

	<snippet id='radcolorpicker-features-radcolorselector-colorselector-populating-block_8-xaml' />

	
	<snippet id='radcolorpicker-features-radcolorselector-colorselector-populating-block_9-cs' />

	<snippet id='radcolorpicker-features-radcolorselector-colorselector-populating-block_9-vb' />


* If you prefer to use your own collection of __Colors__ you can always use __HeaderPaletteItemsSource__, __MainPaletteItemsSource__ and __StandardPaletteItemsSource__.						
	* __StandardPaletteItemSource__ property								

		<snippet id='radcolorpicker-features-radcolorselector-colorselector-populating-block_10-xaml' />

		
		<snippet id='radcolorpicker-features-radcolorselector-colorselector-populating-block_11-cs' />

		<snippet id='radcolorpicker-features-radcolorselector-colorselector-populating-block_11-vb' />


	* __HeaderPaletteItemSource__ property								

		<snippet id='radcolorpicker-features-radcolorselector-colorselector-populating-block_12-xaml' />


		<snippet id='radcolorpicker-features-radcolorselector-colorselector-populating-block_13-cs' />

		<snippet id='radcolorpicker-features-radcolorselector-colorselector-populating-block_13-vb' />


	* __MainPaletteItemSource__ property  

		<snippet id='radcolorpicker-features-radcolorselector-colorselector-populating-block_14-xaml' />


		<snippet id='radcolorpicker-features-radcolorselector-colorselector-populating-block_15-cs' />

		<snippet id='radcolorpicker-features-radcolorselector-colorselector-populating-block_15-vb' />
