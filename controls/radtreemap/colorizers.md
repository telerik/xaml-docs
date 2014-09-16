---
title: Colorizers
page_title: Colorizers
description: Colorizers
slug: radtreemap-colorizers
tags: colorizers
publish: True
position: 7
---

# Colorizers



## ValueGradientColorizer

A colorizer, which contains a set of GradientStops. It chooses the brush to be applied according to the RadTreeMapItem's value and colorizer's gradient stops.
         Each GradientStop.Offset value can be absolute or relative (between 0 and 1) depending on the IsAbsolute property value.
         Note that the RangeMinimum and RangeMaximum properties are set the same as the min and max values of the RadTreeMapItem-s.
         

#### __XAML__

{{region radtreemap-colorizers_3}}
	  <telerik:TypeDefinition.Mappings>
		<telerik:ValueGradientColorizer RangeMinimum="318" RangeMaximum="5310">
			<GradientStop Offset="0" Color="#FFFFD000" />
			<GradientStop Offset="0.50" Color="#FFD11010" />
			<GradientStop Offset="1" Color="#de290b" />
		</telerik:ValueGradientColorizer>
	  </telerik:TypeDefinition.Mappings>
	{{endregion}}

![Rad Tree Map radtreemap colorizer 1](images/RadTreeMap_radtreemap_colorizer_1.PNG)

## ValueBrushColorizer

This colorizer contains a set of RangeBrush objects. It chooses the brush to be applied according to the RadTreeMapItem value,
         set by the *ValuePath* property of the TreeMap and the From and To values of each RangeBrush.
         The values of each RangeBrush can be absolute or relative (between 0 and 1) depending on the IsAbsolute property value.

#### __XAML__

{{region radtreemap-colorizers_4}}
	<UserControl.Resources>
	    <SolidColorBrush Color="#FFE10000" x:Key="Thousand" />
	    <SolidColorBrush Color="#FFF5A4A4" x:Key="TwoThousand" />
	    <SolidColorBrush Color="#FFBDDDFF" x:Key="ThreeThousand"/>
	    <SolidColorBrush Color="#FF87C2FF" x:Key="FourThousand" />
	    <SolidColorBrush Color="#FF0C6BBF" x:Key="FiveThousand" />
	
	    <telerik:RangeBrushCollection x:Key="ColorizerBrushes">
	        <telerik:RangeBrush Brush="{StaticResource Thousand}" From="0" To="999" />
	        <telerik:RangeBrush Brush="{StaticResource TwoThousand}" From="1000" To="2000"  />
	        <telerik:RangeBrush Brush="{StaticResource ThreeThousand}" From="2001" To="3000" />
	        <telerik:RangeBrush Brush="{StaticResource FourThousand}" From="4000" To="5000" />
	        <telerik:RangeBrush Brush="{StaticResource FiveThousand}" From="5001" To="6000"  />
	    </telerik:RangeBrushCollection>
	</UserControl.Resources>
	
	<telerik:TypeDefinition.Mappings>
		<telerik:ValueBrushColorizer IsAbsolute="True" ValuePath="Gdp" RangeMinimum="318" RangeMaximum="5310"
									 Brushes="{StaticResource ColorizerBrushes}">
		</telerik:ValueBrushColorizer>
	</telerik:TypeDefinition.Mappings>
	{{endregion}}

![Rad Tree Map radtreemap colorizer 2](images/RadTreeMap_radtreemap_colorizer_2.PNG)

Here's an example of the same colorizer with relative colors (IsAbsolute property is turned off):

#### __XAML__

{{region radtreemap-colorizers_5}}
	<UserControl.Resources>
	    <SolidColorBrush Color="#FFE10000" x:Key="Thousand" />
	    <SolidColorBrush Color="#FFF5A4A4" x:Key="TwoThousand" />
	    <SolidColorBrush Color="#FFBDDDFF" x:Key="ThreeThousand"/>
	    <SolidColorBrush Color="#FF87C2FF" x:Key="FourThousand" />
	    <SolidColorBrush Color="#FF0C6BBF" x:Key="FiveThousand" />
	
	    <telerik:RangeBrushCollection x:Key="ColorizerBrushes">
	        <telerik:RangeBrush Brush="{StaticResource FourThousand}" From="0" To="0.5" />
	        <telerik:RangeBrush Brush="{StaticResource FiveThousand}" From="0.6" To="1"  />
	    </telerik:RangeBrushCollection>
	</UserControl.Resources>
	
	<telerik:TypeDefinition.Mappings>
	    <telerik:ValueBrushColorizer IsAbsolute="False" 
	                                 Brushes="{StaticResource ColorizerBrushes}">
	    </telerik:ValueBrushColorizer>
	</telerik:TypeDefinition.Mappings>
	{{endregion}}

![Rad Tree Map radtreemap colorizer 3](images/RadTreeMap_radtreemap_colorizer_3.PNG)

## DesaturationColorizer

It reduces the level of saturation of a given StartColor depending on the RadTreeMapItem value. The level of desaturation can be controlled using From and To properties.

#### __XAML__

{{region radtreemap-colorizers_6}}
	<telerik:TypeDefinition.Mappings>
	    <telerik:DesaturationColorizer From="1" To="0.2" StartColor="#69C7D3"/>
	</telerik:TypeDefinition.Mappings>
	{{endregion}}

![Rad Tree Map radtreemap colorizer 4](images/RadTreeMap_radtreemap_colorizer_4.PNG)

## Palette Colorizer

Colorizes RadTreeMap per predefined collection of Brush objects. 

#### __XAML__

{{region radtreemap-colorizers_7}}
	<UserControl.Resources>
		<telerik:PaletteBrushes x:Key="ColorizerBrushes">
			<SolidColorBrush Color="#69C7D3" />
			<SolidColorBrush Color="#B1E292" />
			<SolidColorBrush Color="#D2B4E2" />
			<SolidColorBrush Color="#A2D7F0" />
			<SolidColorBrush Color="#E8D982" />
			<SolidColorBrush Color="#BBDBC6" />
		</telerik:PaletteBrushes>
	</UserControl.Resources>
	
	<telerik:TypeDefinition.Mappings>
	    <telerik:PaletteColorizer Brushes="{StaticResource ColorizerBrushes}" />
	</telerik:TypeDefinition.Mappings>
	{{endregion}}

![Rad Tree Map radtreemap colorizer 5](images/RadTreeMap_radtreemap_colorizer_5.PNG)

## Brush Colorizer

Paints RadTreeMapItem by the color set via brush. You may control the target of the coloring by *TargetPropertyName* property as shown below.

#### __XAML__

{{region radtreemap-colorizers_8}}
	<telerik:TypeDefinition.Mappings>
	    <telerik:BrushColorizer Brush="#F0B32D" /> 
	    <telerik:BrushColorizer Brush="#D2412C" TargetPropertyName="BorderBrush" />
	</telerik:TypeDefinition.Mappings>
	{{endregion}}

![Rad Tree Map radtreemap colorizer 6](images/RadTreeMap_radtreemap_colorizer_6.PNG)
