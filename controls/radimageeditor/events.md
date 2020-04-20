---
title: Events
page_title: Events
description: Check our &quot;Events&quot; documentation article for the RadImageEditor {{ site.framework_name }} control.
slug: radimageeditor-events
tags: events
published: True
position: 7
---

# Events

This topic covers the specific events exposed by the RadImageEditor control.

RadImageEditor raises the following events:

* __CommandError__: Occurs when an error gets thrown while executing a command. Through the __CommandErrorEventArgs__, you can access the following property:

	* **Exception**: Gets the currently thrown exception.               

* __CommandExecuted__: Occurs when a command gets executed. Through the __ImageCommandExecutedEventArgs__, you can access the following properties:
           
	* **Command**: Gets the current executed command.         
	* **CommandParameter**: Gets the current executed command parameter.  	
		   
* __CommandExecuting__: Occurs before a command gets executed. Through the __ImageCommandExecutingEventArgs__, you can access the following properties:
           
	* **Command**: Gets the current executed command.         
	* **CommandParameter**: Gets the current executed command parameter.  		                

* __ImageViewSizeChanged__: Occurs when the __ImageViewSize__ property changes.
            
> __ImageViewSize__ property of the RadImageEditor's holds the actual image size (with scaling) set to the control.                

* __IsReadOnlyChanged__: Occurs when the IsReadOnly property changes.                

* __ScaleFactorChanged__: Occurs when the ScaleFactor value has changed.                 

* __ToolCommitted__: Occurs when a tool is committed. Through the __ToolCommittedEventArgs__, you can access the following properties:      
      
	* **Tool**: Gets the current executed tool.
	* **ExecuteSameToolAfterCommit**: Gets or sets a value indicating whether the tool is preserved as a current executing tool. If set to false, the current executing tool will be deactivated.

* __ToolCommitting__: Occurs before a tool is committed. Through the __ToolCommittingEventArgs__, you can access the following property:      
      
	* **Tool**: Gets the current executed tool.              

>tipWhen a tool is executed, the CommandExecuting/ CommandExecuted events are raised for the ExecuteToolCommand. The specific tool is available from the CommandParameter, however you cannot control its behavior (for example, cancel it). For this purpose the ToolCommitting/ToolCommitted events are raised. You can find a working example of their use in our online SDK reporitory: [Handle Tool Commit](https://github.com/telerik/xaml-sdk/tree/master/ImageEditor/HandleToolCommit).
          

## See Also

 * [Commands and Tools]({%slug radimageeditor-features-commands-and-tools%})
