---
title: Commands
page_title: Commands
description: This article will list the RoutedUICommands that the RadFilePathPicker exposes.
slug: radfilepathpicker-commands
tags: commands, filepathpicker
position: 3
---

# Commands

The __RadFilePathPicker__ control provides the following commands through the __RadFilePathPickerCommands__ static class: __ShowDialog__ and __Clear__. 

## ShowDialog command

The __ShowDialog__ command can be set to the Command property of another element such as a Button or it can be executed in code. Both approaches are demonstrated in __Examples 1 and 2__. When executed, it opens a different file dialog depending on the [DialogType]({%slug radfilepathpicker-dialog-types%}).

#### __[XAML] Example 1: Binding the ShowDialog command the Command property of a Button__
{{region xaml-radfilepathpicker-commands-0}}
    <StackPanel xmlns:fileDialogs="clr-namespace:Telerik.Windows.Controls.FileDialogs;assembly=Telerik.Windows.Controls.FileDialogs">

        <telerik:RadFilePathPicker x:Name="filePathPicker" />

        <Button Content="Clear" Command="{x:Static fileDialogs:RadFilePathPickerCommands.ShowDialog}" CommandTarget="{Binding ElementName=filePathPicker}" />
    </StackPanel>
{{endregion}}

#### __[C#] Example 2: Executing the ShowDialog command in code__
{{region cs-radfilepathpicker-commands-1}}
    RadFilePathPickerCommands.ShowDialog.Execute(null, this.filePathPicker);
{{endregion}}

#### __[VB.NET] Example 2: Executing the ShowDialog command in code__
{{region vb-radfilepathpicker-commands-2}}
    RadFilePathPickerCommands.ShowDialog.Execute(Nothing, Me.filePathPicker)
{{endregion}}

## Clear command

The __Clear__ command can be set to the Command property of another element such as a Button or it can be executed in code. Both approaches are demonstrated in __Examples 3 and 4__. When executed, it clears the Text of the control.

#### __[XAML] Example 3: Binding the Clear command the Command property of a Button__
{{region xaml-radfilepathpicker-commands-3}}
    <StackPanel xmlns:fileDialogs="clr-namespace:Telerik.Windows.Controls.FileDialogs;assembly=Telerik.Windows.Controls.FileDialogs">
       
        <telerik:RadFilePathPicker x:Name="filePathPicker" />

        <Button Content="Clear" Command="{x:Static fileDialogs:RadFilePathPickerCommands.Clear}" CommandTarget="{Binding ElementName=filePathPicker}" />
    </StackPanel>
{{endregion}}

#### __[C#] Example 4: Executing the Clear command in code__
{{region cs-radfilepathpicker-commands-4}}
    RadFilePathPickerCommands.Clear.Execute(null, this.filePathPicker);
{{endregion}}

#### __[VB.NET] Example 4: Executing the Clear command in code__
{{region vb-radfilepathpicker-commands-5}}
    RadFilePathPickerCommands.Clear.Execute(Nothing, Me.filePathPicker)
{{endregion}}

## See Also

* [Dialog Types]({%slug radfilepathpicker-dialog-types%})
* [Events]({%slug radfilepathpicker-events%})
