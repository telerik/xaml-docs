---
title: Appearance
page_title: Appearance
description: Check our &quot;Appearance&quot; documentation article for the RadColorPicker {{ site.framework_name }} control.
slug: colorselector-appearance
tags: appearance
published: True
position: 2
---

# Appearance

You can customize the appearance of a RadColorSelector by choosing which of the parts to be visible.
				

##### 1. You can set the __NoColorVisibility__ property to __Visibility.Visible__ to view the __NoColorField__, otherwise you should set it to false:						

#### __XAML__
```XAML
	<telerik:RadColorSelector NoColorVisibility="Visible" />
```

#### __C#__
```C#
	RadColorSelector selector = new RadColorSelector();
	selector.NoColorVisibility = Visibility.Visible;
	// selector.NoColorVisibility= Visibility.Collapsed;
```

#### __VB.NET__
```VB.NET
	Dim selector As New RadColorSelector()
	selector.NoColorVisibility = Visibility.Visible
	' selector.NoColorVisibility= Visibility.Collapsed '
```

![No Color Field](images/NoColorField.png)

##### 2. You can use __StandardPaletteVisibility__ and __HeaderPaletteVisibility__ in order to set the visibility of the corresponding palettes:						

* __StandardPaletteVisibility__

	#### __XAML__
	```XAML
		<telerik:RadColorSelector StandardPaletteVisibility="Visible" />
	```

	#### __C#__
	```C#
		RadColorSelector selector = new RadColorSelector();
		selector.StandardPaletteVisibility = Visibility.Visible;
		// selector.StandardPaletteVisibility = Visibility.Collapsed;
	```

	#### __VB.NET__
	```VB.NET
		Dim selector As New RadColorSelector()
		selector.StandardPaletteVisibility = Visibility.Visible
		' selector.StandardPaletteVisibility = Visibility.Collapsed '
	```

* __HeaderPaletteVisibility__

	#### __XAML__
	```XAML
		<telerik:RadColorSelector HeaderPaletteVisibility="Visible" />
	```

	#### __C#__
	```C#
		RadColorSelector selector = new RadColorSelector();
		selector.HeaderPaletteVisibility = Visibility.Visible;
		// selector.HeaderPaletteVisibility = Visibility.Collapsed;
	```

	#### __VB.NET__
	```VB.NET
		Dim selector As New RadColorSelector()
		selector.HeaderPaletteVisibility = Visibility.Visible
		' selector.HeaderPaletteVisibility =Visibility.Collapsed '
	```
		
{% if site.site_name == 'Silverlight' %}![Color Picker StructureSL](images/ColorPickerStructureSL.png){% endif %}
{% if site.site_name == 'WPF' %}![Color Picker StructureWPF](images/ColorPickerStructureWPF.png){% endif %}

##### 3. You can set different text for __StandardPalette__ header text , __MainPalette__ header text and __NoColorText__.

* StandardPaletteHeaderText
	
	#### __XAML__
	```XAML
		<telerik:RadColorSelector StandardPaletteHeaderText="Header" />
	```
		
	#### __C#__
	```C#
		RadColorSelector selector = new RadColorSelector();
		selector.StandardPaletteHeaderText = "header";
	```
		
	#### __VB.NET__
	```VB.NET
		Dim selector As New RadColorSelector()
		selector.StandardPaletteHeaderText = "header"
	```
	
* MainPaletteHeaderText
	
	#### __XAML__
	```XAML
		<telerik:RadColorSelector MainPaletteHeaderText="Header" />
	```
	 
	#### __C#__
	```C#
		RadColorSelector selector = new RadColorSelector();
		selector.MainPaletteHeaderText = "header";
	```
		
	#### __VB.NET__
	```VB.NET
		Dim selector As New RadColorSelector()
		selector.MainPaletteHeaderText = "header"
	```

* NoColorText
	
	#### __XAML__
	```XAML
		<telerik:RadColorSelector NoColorText="No Color Text" />
	```
		
	#### __C#__
	```C#
		RadColorSelector selector = new RadColorSelector();
		selector.NoColorText = "No Color Text";
	```
		
	#### __VB.NET__
	```VB.NET
		Dim selector As New RadColorSelector()
		selector.NoColorText = "No Color Text"
	```