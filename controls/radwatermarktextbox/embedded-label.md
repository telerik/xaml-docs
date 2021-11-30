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

####  __[XAML] Setting the Label property__
{{region radwatermarktextbox-features-label-0}}
	<telerik:RadWatermarkTextBox Label="First Name" />
{{endregion}}

#### Label default visualization  
![](images/radwatermarktextbox-features-label-0.png)

#### Label visualization when floated  
![](images/radwatermarktextbox-features-label-1.png)

To keep the label always positioned on top of the text input area, set the __KeepLabelFloated__ property of RadWatermarkTextBox to True.

####  __[XAML] Setting the KeepLabelFloated property__
{{region radwatermarktextbox-features-label-1}}
	<telerik:RadWatermarkTextBox KeepLabelFloated="True" />
{{endregion}}

To get the current state of the label, use the __IsLabelFloated__ property of RadMaskedTextBox

####  __[C#] Getting the state of the label__
{{region radwatermarktextbox-features-label-2}}
	bool isLabelFloated = this.watermarkTextBox.IsLabelFloated;
{{endregion}}

## Customizing Appearance

The label visual element is of type [Label](https://docs.microsoft.com/en-us/dotnet/api/system.windows.controls.label?view=windowsdesktop-6.0). To customize its appearance, use the __LabelStyle__ property of RadWatermarkTextBox.

####  __[XAML] Customizing the label__
{{region radwatermarktextbox-features-label-0}}
	<telerik:RadWatermarkTextBox Label="First Name">
		<telerik:RadWatermarkTextBox.LabelStyle>
			<Style TargetType="Label">
				<Setter Property="Foreground" Value="#5CB9DE" />                    
				<Setter Property="FontStyle" Value="Italic" />                    
			</Style>
		</telerik:RadWatermarkTextBox.LabelStyle>
	</telerik:RadWatermarkTextBox>
{{endregion}}

#### Customized label  
![](images/radwatermarktextbox-features-label-2.png)

## See also  
* [Overview]({%slug radwatermarktextbox-overview%})
* [Getting Started]({%slug watermarktextbox-getting-started%})