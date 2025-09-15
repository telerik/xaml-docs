---
title: Events
page_title: Events
description: Check our &quot;Events&quot; documentation article for the RadImageEditor and RadImageEditorUI {{ site.framework_name }} control.
slug: radimageeditor-events
tags: events
published: True
position: 5
---

# Events

This topic covers the specific events exposed by the `RadImageEditor` and `RadImageEditorUI` controls.

## RadImageEditor Events

The ImageEditor raises the following events:

* `CommandError`&mdash;Occurs when an error gets thrown while executing a command. Through the `CommandErrorEventArgs`, you can access the following property:

	* `Exception`&mdash;Gets the currently thrown exception.               

* `CommandExecuted`&mdash;Occurs when a command gets executed. Through the `ImageCommandExecutedEventArgs`, you can access the following properties:
           
	* `Command`&mdash;Gets the current executed command.         
	* `CommandParameter`&mdash;Gets the current executed command parameter.  	
		   
* `CommandExecuting`&mdash;Occurs before a command gets executed. Through the `ImageCommandExecutingEventArgs`, you can access the following properties:
           
	* `Command`&mdash;Gets the current executed command.         
	* `CommandParameter`&mdash;Gets the current executed command parameter.  		                

* `ImageViewSizeChanged`&mdash;Occurs when the `ImageViewSize` property changes.
            
	> `ImageViewSize` property of RadImageEditor holds the actual image size (with scaling) set to the control.                

* `IsReadOnlyChanged`&mdash;Occurs when the `IsReadOnly` property changes.                

* `ScaleFactorChanged`&mdash;Occurs when the `ScaleFactor` value has changed.                 

* `ToolCommitted`&mdash;Occurs when a tool is committed. Through the `ToolCommittedEventArgs`, you can access the following properties:      
      
	* `Tool`&mdash;Gets the current executed tool.
	* `ExecuteSameToolAfterCommit`&mdash;Gets or sets a value indicating whether the tool is preserved as a current executing tool. If set to false, the current executing tool will be deactivated.

* `ToolCommitting`&mdash;Occurs before a tool is committed. Through the `ToolCommittingEventArgs`, you can access the following property:      
      
	* `Tool`&mdash;Gets the current executed tool.

>tip When a tool is executed, the `CommandExecuting`/`CommandExecuted` events are raised for the `ExecuteToolCommand`. The specific tool is available from the `CommandParameter`, however you cannot control its behavior (for example, cancel it). For this purpose the `ToolCommitting`/`ToolCommitted` events are raised. Find a working example of their usage in our online SDK reporitory: [Handle Tool Commit](https://github.com/telerik/xaml-sdk/tree/master/ImageEditor/HandleToolCommit).          

## RadImageEditorUI Events

The `RadImageEditorUI` component exposes the `ImageEditorLoaded` event, that occurs when the underlying `RadImageEditor` control is loaded. The image editor can be accessed using the `ImageEditor` property of `RadImageEditorUI`.

__ImageEditorLoaded event handler__
```C#
	private void RadImageEditorUI_ImageEditorLoaded(object? sender, EventArgs e)
	{
		RadImageEditorUI ui = (RadImageEditorUI)sender;
		RadImageEditor imageEditor = ui.ImageEditor;
	}
```

## See Also  
 * [Commands and Tools]({%slug radimageeditor-features-commands-and-tools%})