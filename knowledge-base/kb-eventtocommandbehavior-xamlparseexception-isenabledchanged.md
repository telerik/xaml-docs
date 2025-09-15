---
title: XamlParseException When Using EventToCommandBehavior with the IsEnabledChanged Event
description: This article describes the issue where ArgumentException or XamlParseException occurs when using EventToCommandBehavior with the IsEnabledChanged Event
type: troubleshooting
page_title: Cannot Bind to the Target Method Error When Binding IsEnabledChanged Event to View Model Command
slug: kb-eventtocommandbehavior-xamlparseexception-isenabledchanged
tags: radmulticolumncombobox, command, event, isenabledchanged, binding, wpf
res_type: kb
---

## Environment

| Product | Version |
|---------|---------|
| Telerik UI for WPF | 2023.3.1114 |

## Description

`ArgumentException` (often wrapped in `XamlParseException`) is thrown when using the [EventToCommandBehavior]({%slug common-event-to-command-behavior%}) with the [IsEnabledChanged](https://learn.microsoft.com/en-us/dotnet/api/system.windows.uielement.isenabledchanged?view=windowsdesktop-8.0) event.

The exception messages are:

* `XamlParseException`: "Add value to collection of type 'Telerik.Windows.Controls.EventBindingCollection' threw an exception."

* `ArgumentException`: "Cannot bind to the target method because its signature is not compatible with that of the delegate type."

## Solution

This happens because  the `EventToCommandBehavior` supports only events with arguments deriving from the [EventArgs](https://learn.microsoft.com/en-us/dotnet/api/system.eventargs?view=net-5.0) class. `IsEnabledChanged` along with few more UIElement events are using the [DependencyPropertyChangedEventHandler](https://learn.microsoft.com/en-us/dotnet/api/system.windows.dependencypropertychangedeventhandler?view=windowsdesktop-8.0&viewFallbackFrom=net-5.0) delegate which works with the [DependencyPropertyChangedEventArgs](https://learn.microsoft.com/en-us/dotnet/api/system.windows.dependencypropertychangedeventargs?view=windowsdesktop-8.0&viewFallbackFrom=net-5.0) struct. This type of arguments doesn't derive from `EventArgs`.

To resolve the error, you can avoid using the `EventToCommandBehavior` and execute the command in code-behind. Or you can data bind the `IsEnabled` property of the corresponding element to a property in the view model, and then execute the command's logic in the property setter.


```XAML
	<telerik:RadListBox IsEnabled="{Binding IsEnabled, Modet=TwoWay}" />
```


```C#
	private bool isEnabled;	
	public bool IsEnabled
	{
		get { return isEnabled; }
		set
		{
			isEnabled = value;
			OnPropertyChanged(nameof(IsEnabled));
			
			// execute command logic here
		}
	}
```
