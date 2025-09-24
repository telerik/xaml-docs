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
				

```C#
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
```


```XAML
	<telerik:RadColorPaletteView Palette="Office" />
	<telerik:RadColorSelector MainPalette="Office" />
```


```C#
	RadColorPaletteView colorPaletteView = new RadColorPaletteView();
	colorPaletteView.Palette = ColorPreset.Office;
	RadColorSelector colorSelector = new RadColorSelector();
	colorSelector.MainPalette = ColorPreset.Office;
```
```VB.NET
		Dim colorPaletteView As New RadColorPaletteView()
		colorPaletteView.Palette = ColorPreset.Office
		Dim colorSelector As New RadColorSelector()
		colorSelector.MainPalette = ColorPreset.Office
```

## Predefined Palettes Preview

This section describes all predefined palettes (ColorPresets) provided in the __RadColorPicker__ suite

* __Default__
	![{{ site.framework_name }} RadColorPicker Default Palette](images/radcolorpicker-predefined-palettes-default.png)
	
* __Standard__
	![{{ site.framework_name }} RadColorPicker Standard Palette](images/radcolorpicker-predefined-palettes-standart.png)
	
* __Grayscale__
	![{{ site.framework_name }} RadColorPicker Grayscale Palette](images/radcolorpicker-predefined-palettes-grayscale.png)
	
* __Web216__
	![{{ site.framework_name }} RadColorPicker Web216 Palette](images/radcolorpicker-predefined-palettes-web216.png)
	
* __ReallyWebSafe__
	![{{ site.framework_name }} RadColorPicker ReallyWebSafe Palette](images/radcolorpicker-predefined-palettes-reallyWebSafe.png)
	
* __Office__
	![{{ site.framework_name }} RadColorPicker Office Palette](images/radcolorpicker-predefined-palettes-office.png)
	
* __Apex__
	![{{ site.framework_name }} RadColorPicker Apex Palette](images/radcolorpicker-predefined-palettes-apex.png)
	
* __Aspect__
	![{{ site.framework_name }} RadColorPicker Aspect Palette](images/radcolorpicker-predefined-palettes-aspect.png)
	
* __Civic__
	![{{ site.framework_name }} RadColorPicker Civic Palette](images/radcolorpicker-predefined-palettes-civic.png)
	
* __Concourse__
	![{{ site.framework_name }} RadColorPicker Concourse Palette](images/radcolorpicker-predefined-palettes-concourse.png)
	
* __Equity__
	![{{ site.framework_name }} RadColorPicker Equity Palette](images/radcolorpicker-predefined-palettes-equity.png)
	
* __Flow__
	![{{ site.framework_name }} RadColorPicker Flow Palette](images/radcolorpicker-predefined-palettes-flow.png)
	
* __Foundry__
	![{{ site.framework_name }} RadColorPicker Foundry Palette](images/radcolorpicker-predefined-palettes-foundry.png)
	
* __Median__
	![{{ site.framework_name }} RadColorPicker Median Palette](images/radcolorpicker-predefined-palettes-median.png)
	
* __Metro__
	![{{ site.framework_name }} RadColorPicker Metro Palette](images/radcolorpicker-predefined-palettes-metro.png)
	
* __Module__
	![{{ site.framework_name }} RadColorPicker Module Palette](images/radcolorpicker-predefined-palettes-module.png)
	
* __Opulent__
	![{{ site.framework_name }} RadColorPicker Opulent Palette](images/radcolorpicker-predefined-palettes-opulent.png)
	
* __Oriel__
	![{{ site.framework_name }} RadColorPicker Oriel Palette](images/radcolorpicker-predefined-palettes-oriel.png)
	
* __Origin__
	![{{ site.framework_name }} RadColorPicker Origin Palette](images/radcolorpicker-predefined-palettes-origin.png)
	
* __Paper__
	![{{ site.framework_name }} RadColorPicker Paper Palette](images/radcolorpicker-predefined-palettes-paper.png)
	
* __Solstice__
	![{{ site.framework_name }} RadColorPicker Solstice Palette](images/radcolorpicker-predefined-palettes-solstice.png)
	
* __Technique__
	![{{ site.framework_name }} RadColorPicker Technique Palette](images/radcolorpicker-predefined-palettes-technique.png)
	
* __Trek__
	![{{ site.framework_name }} RadColorPicker Trek Palette](images/radcolorpicker-predefined-palettes-trek.png)
	
* __Urban__
	![{{ site.framework_name }} RadColorPicker Urban Palette](images/radcolorpicker-predefined-palettes-urban.png)
	
* __Verve__
	![{{ site.framework_name }} RadColorPicker Verve Palette](images/radcolorpicker-predefined-palettes-verve.png)