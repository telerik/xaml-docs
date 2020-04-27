---
title: Getting Started
page_title: Getting Started
description: This article will walk you through the creation of a sample application that contains a RadFilePathPicker control.
slug: radfilepathpicker-getting-started
tags: getting,started,radfilepathpicker
position: 2
---

# Getting Started

This tutorial will walk you through the creation of a sample application that contains a __RadFilePathPicker__ control.
			
## Assembly References

In order to use __RadFilePathPicker__, you will need to add references to the following assemblies:
* __Telerik.Windows.Controls__
* __Telerik.Windows.Controls.Input__
* __Telerik.Windows.Controls.Navigation__
* __Telerik.Windows.Controls.GridView__
* __Telerik.Windows.Controls.FileDialogs__
* __Telerik.Windows.Data__

You can find the required assemblies for each control from the suite in the [Controls Dependencies]({%slug installation-installing-controls-dependencies-wpf%}) help article.

## Defining RadFilePathPicker

__Example 1__ demonstrates how you can define a RadFilePathPicker in xaml.

#### __[XAML] Example 1: Defining RadFilePathPicker__
{{region xaml-radfilepathpicker-getting-started-0}}
    <telerik:RadFilePathPicker x:Name="filePathPicker"  />
{{endregion}}

#### __Figure 1: RadFilePathPicker in the Office2016 theme__
![RadFilePathPicker Getting started](images/FilePathPicker_GettingStarted.png)

Even at this point, you are ready to start using the control. The following few sections will demonstrate some of the features of the __RadFilePathPicker__.

## IsReadOnly

By default the RadFilePathPicker is read-only, which means that you cannot input text in the RadWatermarkTextBox inside it. In order to change this, you can set the __IsReadOnly__ property to __False__ as demonstrated in __Example 2__.

#### __[XAML] Example 2: Setting the IsReadOnly property__
{{region xaml-radfilepathpicker-getting-started-1}}
    <telerik:RadFilePathPicker IsReadOnly="False"  />
{{endregion}}

## Text and FilePath

The __RadFilePathPicker__ control exposes two properties that come in handy for working with input: __Text__ and __FilePath__. The __Text__ property is updated constantly when the user is typing. The __FilePath__ property is only updated when a valid file path is entered or when one is selected through a file dialog. 

## ShowDialogButtonContent and ShowDialogButtonTemplate 

There are two properties that allow for modifying the appearance of the button on the right side of the control, which opens the dialog. The __ShowDialogButtonContent__ expects a glyph as a value, since the default __ShowDialogButtonTemplate__ contains a [RadGlyph]({%slug common-styling-appearance-radglyph%}). __Example 3__ demonstrates how to change the default glyph shown in the button.

#### __[XAML] Example 3: Setting the ShowDialogButtonContent__
{{region xaml-radfilepathpicker-getting-started-2}}
    <telerik:RadFilePathPicker ShowDialogButtonContent="&#xe11f;" />
{{endregion}}

#### __Figure 2: RadFilePathPicker with ShowDialogButtonContent set in the Office2016 theme__
![RadFilePathPicker with ShowDialogButtonContent](images/FilePathPicker_GettingStarted_ShowDialogButtonContent.png)

If you don't want to show a RadGlyph in the show dialog button, you can set the __ShowDialogButtonTemplate__ property to a custom DataTemplate. Note, that whatever is set to the __ShowDialogButtonContent__ will be the DataContext inside the __ShowDialogButtonTemplate__. 

#### __[XAML] Example 4: Setting the ShowDialogButtonTemplate__
{{region xaml-radfilepathpicker-getting-started-3}}

    <StackPanel>
        <StackPanel.Resources>
            <DataTemplate x:Key="ShowDialogButtonTemplate">
                <TextBlock Text="{Binding}" />
            </DataTemplate>
        </StackPanel.Resources>

        <telerik:RadFilePathPicker ShowDialogButtonContent="Show" ShowDialogButtonTemplate="{StaticResource ShowDialogButtonTemplate}"  />
    </StackPanel>
{{endregion}}

#### __Figure 3: RadFilePathPicker with ShowDialogButtonTemplate set in the Office2016 theme__
![RadFilePathPicker with ShowDialogButtonTemplate](images/FilePathPicker_GettingStarted_ShowDialogButtonTemplate.png)

## ClearButtonContent and ClearButtonTemplate 

There are two properties that allow for modifying the appearance of the clear button, which is shown when some text is entered. The __ClearButtonContent__ expects a glyph as a value, since the default __ClearButtonTemplate__ contains a [RadGlyph]({%slug common-styling-appearance-radglyph%}). __Example 5__ demonstrates how to change the default glyph shown in the button.

#### __[XAML] Example 5: Setting the ClearButtonContent__
{{region xaml-radfilepathpicker-getting-started-4}}
    <telerik:RadFilePathPicker IsReadOnly="False" ClearButtonContent="&#xe11d;" />
{{endregion}}

#### __Figure 4: RadFilePathPicker with ClearButtonContent set in the Office2016 theme__
![RadFilePathPicker with ClearButtonContent](images/FilePathPicker_GettingStarted_ClearButtonContent.png)

To avoid showing a RadGlyph in the clear button, you can set the __ClearButtonTemplate__ property to a custom DataTemplate. Note, that whatever is set to the __ClearButtonContent__ will be the DataContext inside the __ClearButtonTemplate__. 

#### __[XAML] Example 6: Setting the ClearButtonTemplate__
{{region xaml-radfilepathpicker-getting-started-5}}

    <StackPanel>
        <StackPanel.Resources>
            <DataTemplate x:Key="ClearButtonTemplate">
                <TextBlock Text="{Binding}" />
            </DataTemplate>
        </StackPanel.Resources>

        <telerik:RadFilePathPicker IsReadOnly="False" ClearButtonContent="Clear" ClearButtonTemplate="{StaticResource ClearButtonTemplate}"/>
    </StackPanel>
{{endregion}}

#### __Figure 5: RadFilePathPicker with ClearButtonTemplate set in the Office2016 theme__
![RadFilePathPicker with ClearButtonTemplate](images/FilePathPicker_GettingStarted_ClearButtonTemplate.png)

## Setting FilePath on Drop

Since the __2020.1.316__ internal build version, the RadFilePathPicker automatically sets its __FilePath__ when a file is dropped over it. If multiple files are dropped, the first one will be used. In order to disable this functionality, you can set the __AllowDrop__ property of the control to __False__.
 
#### __Figure 6: Dropping a file over the RadFilePathPicker__
![Dropping a file over the RadFilePathPicker](images/FilePathPicker_GettingStarted_Drop.gif)

## See Also 

* [Commands]({%slug radfilepathpicker-commands%})
* [Dialog Types]({%slug radfilepathpicker-dialog-types%})
* [WatermarkTextbox Properties]({%slug radfilepathpicker-watermarktextbox-properties%})
* [IconTemplateSelector]({%slug radfilepathpicker-icontemplateselector%})