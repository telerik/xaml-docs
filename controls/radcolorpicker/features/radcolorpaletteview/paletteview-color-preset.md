---
title: Color Preset
page_title: Color Preset
description: Color Preset
slug: paletteview-color-preset
tags: color,preset
published: True
position: 1
---

# Color Preset

__ColorPreset__ is an enum that represent all built-in palettes.				

You can use it to set  the __Palette__ property of RadColorPaletteView or __HeaderPalette__/__StandardPalette__/__MainPalette__ properties of the __RadColorSelector__.
				
#### __C#__
{{region paletteview-color-preset-0}}
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
{{endregion}}

#### __XAML__
{{region paletteview-color-preset_1}}
	<telerik:RadColorPaletteView Palette="Office" />
	<telerik:RadColorSelector MainPalette="Office" />
{{endregion}}

#### __C#__
{{region paletteview-color-preset_2}}
	RadColorPaletteView colorPaletteView = new RadColorPaletteView();
	colorPaletteView.Palette = ColorPreset.Office;
	RadColorSelector colorSelector = new RadColorSelector();
	colorSelector.MainPalette = ColorPreset.Office;
{{endregion}}

#### __VB.NET__
{{region paletteview-color-preset_3}}
		Dim colorPaletteView As New RadColorPaletteView()
		colorPaletteView.Palette = ColorPreset.Office
		Dim colorSelector As New RadColorSelector()
		colorSelector.MainPalette = ColorPreset.Office
{{endregion}}

## Predefined Palettes Preview

This section describes all predefined palettes (ColorPresets) provided in the __RadColorPicker__ suite

* __Default__
	![](images/radcolorpicker-predefined-palettes-default.png)
	
* __Standard__
	![](images/radcolorpicker-predefined-palettes-standart.png)
	
* __Grayscale__
	![](images/radcolorpicker-predefined-palettes-grayscale.png)
	
* __Web216__
	![](images/radcolorpicker-predefined-palettes-web216.png)
	
* __ReallyWebSafe__
	![](images/radcolorpicker-predefined-palettes-reallyWebSafe.png)
	
* __Office__
	![](images/radcolorpicker-predefined-palettes-office.png)
	
* __Apex__
	![](images/radcolorpicker-predefined-palettes-apex.png)
	
* __Aspect__
	![](images/radcolorpicker-predefined-palettes-aspect.png)
	
* __Civic__
	![](images/radcolorpicker-predefined-palettes-civic.png)
	
* __Concourse__
	![](images/radcolorpicker-predefined-palettes-concourse.png)
	
* __Equity__
	![](images/radcolorpicker-predefined-palettes-equity.png)
	
* __Flow__
	![](images/radcolorpicker-predefined-palettes-flow.png)
	
* __Foundry__
	![](images/radcolorpicker-predefined-palettes-foundry.png)
	
* __Median__
	![](images/radcolorpicker-predefined-palettes-median.png)
	
* __Metro__
	![](images/radcolorpicker-predefined-palettes-metro.png)
	
* __Module__
	![](images/radcolorpicker-predefined-palettes-module.png)
	
* __Opulent__
	![](images/radcolorpicker-predefined-palettes-opulent.png)
	
* __Oriel__
	![](images/radcolorpicker-predefined-palettes-oriel.png)
	
* __Origin__
	![](images/radcolorpicker-predefined-palettes-origin.png)
	
* __Paper__
	![](images/radcolorpicker-predefined-palettes-paper.png)
	
* __Solstice__
	![](images/radcolorpicker-predefined-palettes-solstice.png)
	
* __Technique__
	![](images/radcolorpicker-predefined-palettes-technique.png)
	
* __Trek__
	![](images/radcolorpicker-predefined-palettes-trek.png)
	
* __Urban__
	![](images/radcolorpicker-predefined-palettes-urban.png)
	
* __Verve__
	![](images/radcolorpicker-predefined-palettes-verve.png)