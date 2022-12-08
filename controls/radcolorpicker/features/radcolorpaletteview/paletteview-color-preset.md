---
title: Color Preset
page_title: Color Preset
description: Check our &quot;Color Preset&quot; documentation article for the RadColorPicker {{ site.framework_name }} control.
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
	![WPF RadColorPicker Default Palette](images/radcolorpicker-predefined-palettes-default.png)
	
* __Standard__
	![WPF RadColorPicker Standard Palette](images/radcolorpicker-predefined-palettes-standart.png)
	
* __Grayscale__
	![WPF RadColorPicker Grayscale Palette](images/radcolorpicker-predefined-palettes-grayscale.png)
	
* __Web216__
	![WPF RadColorPicker Web216 Palette](images/radcolorpicker-predefined-palettes-web216.png)
	
* __ReallyWebSafe__
	![WPF RadColorPicker ReallyWebSafe Palette](images/radcolorpicker-predefined-palettes-reallyWebSafe.png)
	
* __Office__
	![WPF RadColorPicker Office Palette](images/radcolorpicker-predefined-palettes-office.png)
	
* __Apex__
	![WPF RadColorPicker Apex Palette](images/radcolorpicker-predefined-palettes-apex.png)
	
* __Aspect__
	![WPF RadColorPicker Aspect Palette](images/radcolorpicker-predefined-palettes-aspect.png)
	
* __Civic__
	![WPF RadColorPicker Civic Palette](images/radcolorpicker-predefined-palettes-civic.png)
	
* __Concourse__
	![WPF RadColorPicker Concourse Palette](images/radcolorpicker-predefined-palettes-concourse.png)
	
* __Equity__
	![WPF RadColorPicker Equity Palette](images/radcolorpicker-predefined-palettes-equity.png)
	
* __Flow__
	![WPF RadColorPicker Flow Palette](images/radcolorpicker-predefined-palettes-flow.png)
	
* __Foundry__
	![WPF RadColorPicker Foundry Palette](images/radcolorpicker-predefined-palettes-foundry.png)
	
* __Median__
	![WPF RadColorPicker Median Palette](images/radcolorpicker-predefined-palettes-median.png)
	
* __Metro__
	![WPF RadColorPicker Metro Palette](images/radcolorpicker-predefined-palettes-metro.png)
	
* __Module__
	![WPF RadColorPicker Module Palette](images/radcolorpicker-predefined-palettes-module.png)
	
* __Opulent__
	![WPF RadColorPicker Opulent Palette](images/radcolorpicker-predefined-palettes-opulent.png)
	
* __Oriel__
	![WPF RadColorPicker Oriel Palette](images/radcolorpicker-predefined-palettes-oriel.png)
	
* __Origin__
	![WPF RadColorPicker Origin Palette](images/radcolorpicker-predefined-palettes-origin.png)
	
* __Paper__
	![WPF RadColorPicker Paper Palette](images/radcolorpicker-predefined-palettes-paper.png)
	
* __Solstice__
	![WPF RadColorPicker Solstice Palette](images/radcolorpicker-predefined-palettes-solstice.png)
	
* __Technique__
	![WPF RadColorPicker Technique Palette](images/radcolorpicker-predefined-palettes-technique.png)
	
* __Trek__
	![WPF RadColorPicker Trek Palette](images/radcolorpicker-predefined-palettes-trek.png)
	
* __Urban__
	![WPF RadColorPicker Urban Palette](images/radcolorpicker-predefined-palettes-urban.png)
	
* __Verve__
	![WPF RadColorPicker Verve Palette](images/radcolorpicker-predefined-palettes-verve.png)