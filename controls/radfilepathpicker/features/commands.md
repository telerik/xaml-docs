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

__Example 1: Binding the ShowDialog command the Command property of a Button__
<snippet id='radfilepathpicker-features-commands-example_1_binding_the_showdialog_command_the_command_property_of_a_button-xaml' />


__Example 2: Executing the ShowDialog command in code__
<snippet id='radfilepathpicker-features-commands-example_2_executing_the_showdialog_command_in_code-cs' />

<snippet id='radfilepathpicker-features-commands-example_2_executing_the_showdialog_command_in_code-vb' />


## Clear command

The __Clear__ command can be set to the Command property of another element such as a Button or it can be executed in code. Both approaches are demonstrated in __Examples 3 and 4__. When executed, it clears the Text of the control.

__Example 3: Binding the Clear command the Command property of a Button__
<snippet id='radfilepathpicker-features-commands-example_3_binding_the_clear_command_the_command_property_of_a_button-xaml' />


__Example 4: Executing the Clear command in code__
<snippet id='radfilepathpicker-features-commands-example_4_executing_the_clear_command_in_code-cs' />

<snippet id='radfilepathpicker-features-commands-example_4_executing_the_clear_command_in_code-vb' />


## See Also

* [Dialog Types]({%slug radfilepathpicker-dialog-types%})
* [Events]({%slug radfilepathpicker-events%})
