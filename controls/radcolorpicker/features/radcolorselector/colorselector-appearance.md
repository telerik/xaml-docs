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

```XAML
	<telerik:RadColorSelector NoColorVisibility="Visible" />
```

```C#
	RadColorSelector selector = new RadColorSelector();
	selector.NoColorVisibility = Visibility.Visible;
	// selector.NoColorVisibility= Visibility.Collapsed;
```
```VB.NET
	Dim selector As New RadColorSelector()
	selector.NoColorVisibility = Visibility.Visible
	' selector.NoColorVisibility= Visibility.Collapsed '
```

![No Color Field](images/NoColorField.png)

##### 2. You can use __StandardPaletteVisibility__ and __HeaderPaletteVisibility__ in order to set the visibility of the corresponding palettes:						

* __StandardPaletteVisibility__

	```XAML
		<telerik:RadColorSelector StandardPaletteVisibility="Visible" />
	```

	```C#
		RadColorSelector selector = new RadColorSelector();
		selector.StandardPaletteVisibility = Visibility.Visible;
		// selector.StandardPaletteVisibility = Visibility.Collapsed;
	```
	```VB.NET
		Dim selector As New RadColorSelector()
		selector.StandardPaletteVisibility = Visibility.Visible
		' selector.StandardPaletteVisibility = Visibility.Collapsed '
	```

* __HeaderPaletteVisibility__

	```XAML
		<telerik:RadColorSelector HeaderPaletteVisibility="Visible" />
	```
	
	```C#
		RadColorSelector selector = new RadColorSelector();
		selector.HeaderPaletteVisibility = Visibility.Visible;
		// selector.HeaderPaletteVisibility = Visibility.Collapsed;
	```
	```VB.NET
		Dim selector As New RadColorSelector()
		selector.HeaderPaletteVisibility = Visibility.Visible
		' selector.HeaderPaletteVisibility =Visibility.Collapsed '
	```
		

![Color Picker StructureWPF](images/ColorPickerStructureWPF.png)

##### 3. You can set different text for __StandardPalette__ header text , __MainPalette__ header text and __NoColorText__.

* StandardPaletteHeaderText
	
	```XAML
		<telerik:RadColorSelector StandardPaletteHeaderText="Header" />
	```
	
	```C#
		RadColorSelector selector = new RadColorSelector();
		selector.StandardPaletteHeaderText = "header";
	```
	```VB.NET
		Dim selector As New RadColorSelector()
		selector.StandardPaletteHeaderText = "header"
	```
	
* MainPaletteHeaderText
	
	```XAML
		<telerik:RadColorSelector MainPaletteHeaderText="Header" />
	```
	
	```C#
		RadColorSelector selector = new RadColorSelector();
		selector.MainPaletteHeaderText = "header";
	```
	```VB.NET
		Dim selector As New RadColorSelector()
		selector.MainPaletteHeaderText = "header"
	```

* NoColorText
	
	```XAML
		<telerik:RadColorSelector NoColorText="No Color Text" />
	```
	
	```C#
		RadColorSelector selector = new RadColorSelector();
		selector.NoColorText = "No Color Text";
	```
	```VB.NET
		Dim selector As New RadColorSelector()
		selector.NoColorText = "No Color Text"
	```