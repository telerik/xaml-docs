---
title: Appearance
page_title: Appearance
description: Appearance
slug: radcolorpicker-appearance
tags: appearance
published: True
position: 1
---

# Appearance

You can customize the appearance of a __RadColorPicker__ by choosing which of the parts to be visible.        

##### 1. You can set the __NoColorVisibility__ property to __Visibility.Visible__ to view the __NoColorField__, otherwise you should set it to false:            

#### __XAML__
{{region radcolorpicker-appearance_1}}
	<telerik:RadColorPicker NoColorVisibility="Visible" />
{{endregion}}

#### __C#__
{{region radcolorpicker-appearance_0}}
	RadColorPicker colorPicker = new RadColorPicker();
	colorPicker.NoColorVisibility = Visibility.Visible;
	// colorPicker.NoColorVisibility= Visibility.Collapsed;
{{endregion}}

#### __VB.NET__
{{region radcolorpicker-appearance_0}}
	Dim colorPicker As New RadColorPicker()
	colorPicker.NoColorVisibility = Visibility.Visible
	' colorPicker.NoColorVisibility= Visibility.Collapsed; '
{{endregion}}    

![No Color Field](images/NoColorField.png)

##### 2. You can use __StandardPaletteVisibility__ and __HeaderPaletteVisibility__ in order to set the visibility of the corresponding palettes:            

* __StandardPaletteVisibility__

	#### __XAML__
	{{region radcolorpicker-appearance_3}}
		<telerik:RadColorPicker StandardPaletteVisibility="Visible" />
	{{endregion}}

	#### __C#__
	{{region radcolorpicker-appearance_2}}
		RadColorPicker colorPicker = new RadColorPicker();
		colorPicker.StandardPaletteVisibility = Visibility.Visible;
		 // colorPicker.StandardPaletteVisibility = Visibility.Collapsed;
	{{endregion}}

	#### __VB.NET__
	{{region radcolorpicker-appearance_2}}
		Dim colorPicker As New RadColorPicker()
		colorPicker.StandardPaletteVisibility = Visibility.Visible
		' colorPicker.StandardPaletteVisibility = Visibility.Collapsed; '
	{{endregion}}

* __HeaderPaletteVisibility__

	#### __XAML__
	{{region radcolorpicker-appearance_5}}
		<telerik:RadColorPicker HeaderPaletteVisibility="Visible" />
	{{endregion}}

	#### __C#__
	{{region radcolorpicker-appearance_4}}
		RadColorPicker colorPicker = new RadColorPicker();
		colorPicker.HeaderPaletteVisibility = Visibility.Visible;
		// colorPicker.HeaderPaletteVizibility = Visibility.Collapsed;
	{{endregion}}

	#### __VB.NET__
	{{region radcolorpicker-appearance_4}}
		Dim colorPicker As New RadColorPicker()
		colorPicker.HeaderPaletteVisibility = Visibility.Visible
		' colorPicker.HeaderPaletteVizibility = Visibility.Collapsed; '
	{{endregion}}

{% if site.site_name == 'Silverlight' %}![Color Picker StructureSL](images/ColorPickerStructureSL.png){% endif %}
{% if site.site_name == 'WPF' %}![Color Picker StructureWPF](images/ColorPickerStructureWPF.png){% endif %}

##### 3. You can set different text for __StandardPalette__ header text, __MainPalette__ header text and __NoColorText__.            

* __StandardPaletteHeaderText__

	#### __XAML__
	{{region radcolorpicker-appearance_7}}
		<telerik:RadColorPicker StandardPaletteHeaderText="StandardPalette header" />
	{{endregion}}

	#### __C#__
	{{region radcolorpicker-appearance_6}}
		RadColorPicker colorPicker = new RadColorPicker();
		colorPicker.StandardPaletteHeaderText = "StandardPaletteHeader";
	{{endregion}}

	#### __VB.NET__

	{{region radcolorpicker-appearance_6}}
		Dim colorPicker As New RadColorPicker()
		colorPicker.StandardPaletteHeaderText = "StandardPaletteHeader"
	{{endregion}}

* __MainPaletteHeaderText__

	#### __C#__
	{{region radcolorpicker-appearance_8}}
		RadColorPicker colorPicker = new RadColorPicker();
		colorPicker.MainPaletteHeaderText = "MainPaletteHeader";
	{{endregion}}

	#### __XAML__
	{{region radcolorpicker-appearance_9}}
		<telerik:RadColorPicker MainPaletteHeaderText="MainPalette header" />
	{{endregion}}

* __NoColorText__

	#### __C#__
	{{region radcolorpicker-appearance_10}}
		RadColorPicker colorPicker = new RadColorPicker();
		colorPicker.NoColorText = "No color Text";
	{{endregion}}

	#### __VB.NET__
	{{region radcolorpicker-appearance_10}}
			Dim colorPicker As New RadColorPicker()
		colorPicker.NoColorText = "No color Text"
	{{endregion}}


##### 4. __RadColorPicker__ is a stylable control. You can customize the look of the RadSplitButton. In order to do this you should use __SplitButtonStyle__ property.

* __SplitButtonStyle__ - this property should be used to control the style of the split button.