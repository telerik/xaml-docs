---
title: Commands
page_title: RadTimeBar Commands
description: Learn more about the commands of Telerik's {{ site.framework_name }} TimeBar that allow you to easily handle the user interface actions.
slug: timebar-commands
tags: commands, timebar, timebar commands
published: True
position: 0
---

# Commands Overview

RadTimeBar provides a set of built-in commands that enables you to further control its behavior and keep your logic separated from the UI layout.

The following list contains all of the supported commands provided by the `RadTimeBarCommands` class:

* `CenterSelection`: Changes the visible period of the control, in order to show the selection centered.

* `ExpandVisiblePeriod`: Expands the visible period range to period range.

* `ExpandVisiblePeriodToStart`: Expands the visible period start to period start.

* `ExpandVisiblePeriodToEnd`: Expands the visible period end to period end.

* `SelectionGroupInterval`: Allows you to select the current group interval.

* `SelectionGroupIntervalStart`: Allows you to select the start of the current group interval.

* `SelectionGroupIntervalEnd`: Allows you to select the end of the current group interval.

As the commands provided by RadTimeBarCommands class are [__ICommands__](https://docs.microsoft.com/en-us/dotnet/api/system.windows.input.icommand?view=net-6.0) at their core, they do provide methods for both checking if they can be invoked - `CanExecute` and for invoking them - `Execute`.

__Command execution__
```C#
    private void RadButton_Click(object sender, RoutedEventArgs e)
    {
        RoutedUICommand centerSelection = RadTimeBarCommands.CenterSelection as RoutedUICommand;
        centerSelection.Execute(null, this.radTimeBar);
    }
```
```VB.NET
    Private Sub RadButton_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
        Dim centerSelection As RoutedUICommand = TryCast(RadTimeBarCommands.CenterSelection, RoutedUICommand)
        centerSelection.Execute(Nothing, Me.radTimeBar)
    End Sub
```
