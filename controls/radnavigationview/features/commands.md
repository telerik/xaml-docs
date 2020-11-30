---
title: Commands
page_title: Commands
description:.
slug: radnavigationview-commands
tags: commands, navigationviewitem
position: 3
---

# Commands

The RadNavigationViewItem inherits [ButtonBase](https://docs.microsoft.com/en-us/dotnet/api/system.windows.controls.primitives.buttonbase?view=netframework-4.7.2) and as such provides you with a standard __ICommandSource__ implementation. This means that you can bind the items to commands that will get executed when an item is clicked. For this purpose the following properties can be used.

* Command: Gets the command that will be executed when the command source is invoked.

* CommandParameter: Represents a user defined data value that can be passed to the command when it is executed.

* CommandTarget: The object that the command is being executed on.

>The command property can be set to any command that implements the ICommand interface, for example the [DelegateCommand]({%slug common-mvvm-delegate-command-implementation%}).

## See Also

* [Getting Started]({%slug radnavigationview-getting-started%})
* [DataBinding]({%slug radnavigationview-populating-with-data-databinding%})
* [Display Mode]({%slug radnavigationview-display-mode%})