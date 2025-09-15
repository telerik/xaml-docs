---
title: ToolTip
page_title: ToolTip
description: Check our &quot;ToolTip&quot; documentation article for the RadSlider {{ site.framework_name }} control.
slug: radslider-tooltip
tags: tooltip
published: True
position: 8
---

# ToolTip

The tooltip of RadSlider enables the user to see the value of the slider's thumb while dragging it. In order to enable the ToolTip in the RadSlider component, you can set the __AutoToolTipPlacement__ property. The property is an enumeration of type AutoToolTipPlacement and the possible values which can be set are __None__, __TopLeft__, __BottomRight__. The default value of the __AutoToolTipPlacement__ property is __None__.

__Example 1: Set AutoToolTipPlacement property to TopLeft in horizontal orientation__
```XAML
	<telerik:RadSlider Minimum="0" Maximum="10" AutoToolTipPlacement="TopLeft"/>
```

You can change the postion of the tool tip by setting the Orientation and AutoToolTipPlacement properties. The following pictures display the different position of the tool tip.
#### __Figure 1: Horizontal orientated sliders__
![RadSlider Horizontal orientated AutoToolTipPlacement](images/RadSlider_AutoToolTipPlacement_Horizontal_01.png)

#### __Figure 2: Vertical orientated sliders__
![RadSlider ToolTip AutoToolTipPlacement](images/RadSlider_AutoToolTipPlacement_Vertical_02.png)

## ToolTip Value

By default, the ToolTip displays the thumb's value with two decimal symbols of precision (52.42 for example). To change the precision or the default representation of the ToolTip content you can set the __AutoToolTipContentTemplate__ property.

__Example 3: Set custom DataTemplate to AutoToolTipContentTemplate property__
```XAML
	<telerik:RadSlider Minimum="0" Maximum="10" AutoToolTipPlacement="TopLeft">
		<telerik:RadSlider.AutoToolTipContentTemplate>
			<DataTemplate>
				<TextBlock Text="{Binding .,StringFormat=F1}"/>
			</DataTemplate>
		</telerik:RadSlider.AutoToolTipContentTemplate>
	</telerik:RadSlider>	
```

#### __Figure 3: Setting custom template to the AutoToolTipContentTemplate property__
![RadSlider ToolTip AutoToolTipPlacement BottomRight](images/RadSlider_AutoToolTipPlacement_ContentTemplate_04.png)

>The value of the ToolTip might not display the actual Value/SelectionStart/SelectionEnd values of the slider. When the __IsDeferredDraggingEnabled__ property is set to True, the value of the slider will be updated only when the user finishes the drag operation. Regardless this, the Value of the ToolTip will be updated corresponding to the current location of the thumb, indicating the value when you end the dragging.

## Range Selection

When selection range is enabled, the tooltip will appear on the start thumb or the end thumb depending on which one is dragged. The shown value will correspond to the SelectiondStart and SelectionEnd properties of the RadSlider.

#### __Figure 4: ToolTip in range selection functionality__
![RadSlider ToolTip AutoToolTipPlacement RangeToolTip](images/RadSlider_AutoToolTipPlacement_RangeSelection_03.png)

## ThumbToolTipStyle

With the __R2 2020__ version of Telerik UI for WPF controls, the RadSlider control exposes a __ThumbToolTipStyle__ property which can be used to customize the thumb tooltip. __Example 4__ demonstrates how we can use this property to add RadCallout control inside the thumb tooltip.

__Example 4: Callout as a ToolTip for RadSlider Thumb__
```XAML
	<telerik:RadSlider AutoToolTipPlacement="TopLeft" Minimum="0" Maximum="100" LargeChange="5" SmallChange="1" VerticalAlignment="Center" HorizontalAlignment="Center" Width="500" > 
		<telerik:RadSlider.ThumbToolTipStyle> 
			<Style TargetType="ToolTip"> 
				<Setter Property="BorderThickness" Value="0"/> 
				<Setter Property="Background" Value="Transparent"/> 
			</Style> 
		</telerik:RadSlider.ThumbToolTipStyle> 
		<telerik:RadSlider.AutoToolTipContentTemplate> 
			<DataTemplate> 
				<telerik:RadCallout  Margin="5 5 5 10" > 
					<TextBlock Text="{Binding .,  StringFormat=N2}" /> 
				</telerik:RadCallout> 
			</DataTemplate> 
		</telerik:RadSlider.AutoToolTipContentTemplate> 
    </telerik:RadSlider>     
```

## See Also
 * [Getting Started]({%slug radslider-declaration%})	
 * [Orientation]({%slug radslider-orientation%})
 * [Direction]({%slug radslider-direction%})
 {% if site.site_name == 'WPF' %}
 * [RadCallout Overview]({%slug radcallout-overview%})
 {% endif %}