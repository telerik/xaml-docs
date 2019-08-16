---
title: WatermarkTextBox Properties
page_title: WatermarkTextBox Properties
description: The article will list the properties that the RadFilePathPicker control exposes for controlling the behavior of the RadWatermarkTextBox inside it.
slug: radfilepathpicker-watermarktextbox-properties
tags: watermarktextbox, properties
position: 3
---

# WatermarkTextBox Properties

The __RadFilePathPicker__ has a [RadWatermarkTextBox]({%slug watermarktextbox-getting-started%}) element inside it, which is responsible for holding the text. This article will list the properties that the control exposes for working with the RadWatermarkTextBox.

## WatermarkContent

The __WatermarkContent__ property of the control sets the [WatermarkContent]({%slug radwatermarktextbox-features%}#using-the-watermarkcontent-property) of the RadWatermarkTextBox. 

#### __[XAML] Example 1: Setting the WatermarkContent__
{{region xaml-radfilepathpicker-watermarktextbox-properties_0}}
	<telerik:RadFilePathPicker WatermarkContent="Select a file!" />
{{endregion}}

#### __Figure 1: RadFilePathPicker with WatermarkContent__
![RadFilePathPicker with WatermarkContent](images/FilePathPicker_WatermarkContent.png)

## WatermarkTemplate

The __WatermarkTemplate__ property of the control sets the [WatermarkTemplate]({%slug radwatermarktextbox-features%}#using-watermarktemplate-property) of the RadWatermarkTextBox.

#### __[XAML] Example 2: Setting the WatermarkTemplate__
{{region xaml-radfilepathpicker-watermarktextbox-properties_1}}
	<StackPanel>
        <StackPanel.Resources>
            <DataTemplate x:Key="WatermarkTemplate">
                <StackPanel Orientation="Horizontal">
                    <TextBlock Text="{Binding}" Margin="0 0 5 0" />
                    <telerik:RadGlyph Glyph="&#xe403;" Foreground="Red"/>
                </StackPanel>
            </DataTemplate>
        </StackPanel.Resources>
        <telerik:RadFilePathPicker WatermarkContent="Select a file" WatermarkTemplate="{StaticResource WatermarkTemplate}" />
    </StackPanel>
{{endregion}}

#### __Figure 2: RadFilePathPicker with WatermarkTemplate__
![RadFilePathPicker with WatermarkTemplate](images/FilePathPicker_WatermarkTemplate.png)

## WatermarkVisibility

The __WatermarkVisibility__ property controls the __Visibility__ of the RadWatermarkTextbox. 

#### __[XAML] Example 3: Setting the WatermarkTemplate property__
{{region xaml-radfilepathpicker-watermarktextbox-properties_2}}

    <telerik:RadFilePathPicker WatermarkVisibility="Collapsed" />
{{endregion}}

## See Also

* [Dialog Types]({%slug radfilepathpicker-dialog-types%})
* [Commands]({%slug radfilepathpicker-commands%})
* [IconTemplateSelector]({%slug radfilepathpicker-icontemplateselector%})