---
title: Label
page_title: Label
description: "The embedded label feature of RadWatermarkTextBox allows you to display additional information about the entered text."
slug: radwatermarktextbox-features-label
tags: label, embedded
published: True
position: 2
---

# Label

The label feature allows you to display additional information about the text.

The label displays as a watermark content (placeholder) when the RadWatermarkTextBox control is unfocused and the text is empty. When the control gets focused or any text is entered, the label is positioned on top (floating) of the text input area.

__Setting the Label property__
```XAML
	<telerik:RadWatermarkTextBox Label="First Name" />
```

#### Label default visualization  
![{{ site.framework_name }} RadWatermarkTextBox Label Default Visualization](images/radwatermarktextbox-features-label-0.png)

#### Label visualization when floated  
![{{ site.framework_name }} RadWatermarkTextBox Label Visualization When Floated](images/radwatermarktextbox-features-label-1.png)

To keep the label always positioned on top of the text input area, set the __KeepLabelFloated__ property of RadWatermarkTextBox to True.

__Setting the KeepLabelFloated property__
```XAML
	<telerik:RadWatermarkTextBox KeepLabelFloated="True" />
```

To get the current state of the label, use the __IsLabelFloated__ property of RadWatermarkTextBox.

__Getting the state of the label__
```C#
	bool isLabelFloated = this.watermarkTextBox.IsLabelFloated;
```

## Customizing Appearance

The label visual element is of type [Label](https://docs.microsoft.com/en-us/dotnet/api/system.windows.controls.label?view=windowsdesktop-6.0). To customize its appearance, use the __LabelStyle__ property of RadWatermarkTextBox.

__Customizing the label__
```XAML
	<telerik:RadWatermarkTextBox Label="First Name">
		<telerik:RadWatermarkTextBox.LabelStyle>
			<Style TargetType="Label">
				<Setter Property="Foreground" Value="#5CB9DE" />                    
				<Setter Property="FontStyle" Value="Italic" />                    
			</Style>
		</telerik:RadWatermarkTextBox.LabelStyle>
	</telerik:RadWatermarkTextBox>
```

#### Customized label  
![{{ site.framework_name }} RadWatermarkTextBox Customized Label](images/radwatermarktextbox-features-label-2.png)

## Animation

The label comes with a built-in animation that moves the label on top of the input text and then return it back to the center when necessary. This feature is enabled using Telerik's `AnimationManager` class. To change the animation, set the attached `AnimationManager.AnimationSelector` property on the RadWatermarkTextBox control. The property allows you to define an `AnimationSelector` with two groups describing the two animations that appear - make the label floating and return it to the text input area (the center).

The following example shows the default `AnimationSelector` used with the control but with slightly changed `Duration` of the animations.

__Customizing the label__
```XAML
	<telerik:RadWatermarkTextBox Label="First Name">         
		<telerik:AnimationManager.AnimationSelector>
			<telerik:AnimationSelector>
				<telerik:AnimationGroup AnimationName="LabelFloatAnimation">
					<telerik:LabelPositionAnimation TargetElementName="PART_LabelVisualElement" Duration="00:00:00.500" Direction="Out"  />
					<telerik:FontSizeAnimation TargetElementName="PART_LabelVisualElement" Duration="00:00:00.500" Direction="Out" />                        
				</telerik:AnimationGroup>
				<telerik:AnimationGroup AnimationName="LabelCenterAnimation">
					<telerik:LabelPositionAnimation TargetElementName="PART_LabelVisualElement" Duration="00:00:00.500" Direction="In"  />
					<telerik:FontSizeAnimation TargetElementName="PART_LabelVisualElement" Duration="00:00:00.500" Direction="In" />
				</telerik:AnimationGroup>
			</telerik:AnimationSelector>
		</telerik:AnimationManager.AnimationSelector>
	</telerik:RadWatermarkTextBox>
```

## See also  
* [Overview]({%slug radwatermarktextbox-overview%})
* [Getting Started]({%slug watermarktextbox-getting-started%})