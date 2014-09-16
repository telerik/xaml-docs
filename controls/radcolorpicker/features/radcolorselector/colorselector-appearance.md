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

You can customize the appearance of a RadColorSelector by choosing which of
					the parts to be visible.
				

1. You can set the __NoColorVisibility__property to __Visibility.Visible__to view the __NoColorField__,
							otherwise you should set it to false:
						

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
	#End Region
	
	#Region "colorselector-appearance_2"
		Dim selector As New RadColorSelector()
		selector.StandardPaletteVisibility = Visibility.Visible
		' selector.StandardPaletteVisibility = Visibility.Collapsed
	#End Region
	
	#Region "colorselector-appearance_4"
		Dim selector As New RadColorSelector()
		selector.HeaderPaletteVisibility = Visibility.Visible
		' selector.HeaderPaletteVisibility =Visibility.Collapsed
	#End Region
	
	#Region "colorselector-appearance_6"
		Dim selector As New RadColorSelector()
		selector.StandardPaletteHeaderText = "header"
	#End Region
	
	#Region "colorselector-appearance_8"
		Dim selector As New RadColorSelector()
		selector.MainPaletteHeaderText = "header"
	#End Region
	
	#Region "colorselector-appearance_10"
		Dim selector As New RadColorSelector()
		selector.NoColorText = "No Color Text"
	#End Region
	
	End Class

![No Color Field](images/NoColorField.png)

1. You can use __StandardPaletteVisibility__ and
							__HeaderPaletteVisibility__ in order to set the visibility of the
							corresponding palettes:
						

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
	#End Region
	
	#Region "colorselector-appearance_4"
		Dim selector As New RadColorSelector()
		selector.HeaderPaletteVisibility = Visibility.Visible
		' selector.HeaderPaletteVisibility =Visibility.Collapsed
	#End Region
	
	#Region "colorselector-appearance_6"
		Dim selector As New RadColorSelector()
		selector.StandardPaletteHeaderText = "header"
	#End Region
	
	#Region "colorselector-appearance_8"
		Dim selector As New RadColorSelector()
		selector.MainPaletteHeaderText = "header"
	#End Region
	
	#Region "colorselector-appearance_10"
		Dim selector As New RadColorSelector()
		selector.NoColorText = "No Color Text"
	#End Region
	
	End Class



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
	#End Region
	
	#Region "colorselector-appearance_6"
		Dim selector As New RadColorSelector()
		selector.StandardPaletteHeaderText = "header"
	#End Region
	
	#Region "colorselector-appearance_8"
		Dim selector As New RadColorSelector()
		selector.MainPaletteHeaderText = "header"
	#End Region
	
	#Region "colorselector-appearance_10"
		Dim selector As New RadColorSelector()
		selector.NoColorText = "No Color Text"
	#End Region
	
	End Class

{% if site.site_name == 'Silverlight' %}![Color Picker StructureSL](images/ColorPickerStructureSL.png){% endif %}{% if site.site_name == 'WPF' %}![Color Picker StructureWPF](images/ColorPickerStructureWPF.png){% endif %}

1. You can set different text for
							__StandardPalette__ header text , __MainPalette__
							header text and __NoColorText__.
						
