---
title: Appearance
page_title: Appearance
description: Appearance
slug: colorselector-appearance
tags: appearance
published: True
position: 2
---

# Appearance



## 

You can customize the appearance of a RadColorSelector by choosing which of the parts to be visible.
				

##### 1. You can set the __NoColorVisibility__ property to __Visibility.Visible__ to view the __NoColorField__, otherwise you should set it to false:
						

#### __XAML__

{{region colorselector-appearance_1}}
	        <telerik:RadColorSelector NoColorVisibility="Visible" />
	{{endregion}}



#### __C#__

{{region colorselector-appearance_0}}
	RadColorSelector selector = new RadColorSelector();
	selector.NoColorVisibility = Visibility.Visible;
	// selector.NoColorVisibility= Visibility.Collapsed;
	{{endregion}}



#### __VB.NET__

{{region colorselector-appearance_0}}
		Dim selector As New RadColorSelector()
		selector.NoColorVisibility = Visibility.Visible
		' selector.NoColorVisibility= Visibility.Collapsed
	{{endregion}}

![No Color Field](images/NoColorField.png)

##### 2. You can use __StandardPaletteVisibility__ and __HeaderPaletteVisibility__ in order to set the visibility of the corresponding palettes:
						

* __StandardPaletteVisibility__

#### __XAML__

{{region colorselector-appearance_3}}
	        <telerik:RadColorSelector StandardPaletteVisibility="Visible" />
	{{endregion}}



#### __C#__

{{region colorselector-appearance_2}}
	RadColorSelector selector = new RadColorSelector();
	selector.StandardPaletteVisibility = Visibility.Visible;
	// selector.StandardPaletteVisibility = Visibility.Collapsed;
	{{endregion}}



#### __VB.NET__

{{region colorselector-appearance_2}}
		Dim selector As New RadColorSelector()
		selector.StandardPaletteVisibility = Visibility.Visible
		' selector.StandardPaletteVisibility = Visibility.Collapsed
	{{endregion}}


* __HeaderPaletteVisibility__

#### __XAML__

{{region colorselector-appearance_5}}
	        <telerik:RadColorSelector HeaderPaletteVisibility="Visible" />
	{{endregion}}



#### __C#__

{{region colorselector-appearance_4}}
	RadColorSelector selector = new RadColorSelector();
	selector.HeaderPaletteVisibility = Visibility.Visible;
	// selector.HeaderPaletteVisibility = Visibility.Collapsed;
	{{endregion}}



#### __VB.NET__

{{region colorselector-appearance_4}}
		Dim selector As New RadColorSelector()
		selector.HeaderPaletteVisibility = Visibility.Visible
		' selector.HeaderPaletteVisibility =Visibility.Collapsed
	{{endregion}}
    
{% if site.site_name == 'Silverlight' %}![Color Picker StructureSL](images/ColorPickerStructureSL.png){% endif %}{% if site.site_name == 'WPF' %}![Color Picker StructureWPF](images/ColorPickerStructureWPF.png){% endif %}

##### 3. You can set different text for __StandardPalette__ header text , __MainPalette__ header text and __NoColorText__.
						
