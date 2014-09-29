---
title: Events
page_title: Events
description: Events
slug: radimageeditor-events
tags: events
published: True
position: 5
---

# Events



This topic covers the specific events exposed by the RadImageEditor control.

## 

RadImageEditor raises the following events:

* __CommandError__: Occurs when an error gets thrown while executing a command. The event handler receives two arguments:
            

* The sender argument contains the RadImageEditor. The argument is of type object but can be cast to the RadImageEditor type.
                

* A CommandErrorEventArgs object which allows you to get the Exception or access whether the error is Handled.
                

* __CommandExecuted__: Occurs when a command gets executed. The event handler receives two arguments.
            

* The sender argument contains the RadImageEditor. The argument is of type object but can be cast to the RadImageEditor type.
                

* A ImageCommandExecutedEventArgs object which allows you to get obtain the command that was executed and its command parameter.
                

* __CommandExecuting__: Occurs before a command gets executed. The event handler receives two arguments.
            

* The sender argument contains the RadImageEditor. The argument is of type object but can be cast to the RadImageEditor type.
                

* A ImageCommandExecutingEventArgs object which allows you to get obtain the command that is to be executed and its command parameter.
                

* __ImageViewSizeChanged__: Occurs when the ImageViewSize property changes. The event handler receives two arguments.
            

* The sender argument contains the RadImageEditor. The argument is of type object but can be cast to the RadImageEditor type.
                

* An EventArgs object.
                

* __IsReadOnlyChanged__: Occurs when the IsReadOnly property changes. The event handler receives two arguments.
            

* The sender argument contains the RadImageEditor. The argument is of type object but can be cast to the RadImageEditor type.
                

* An EventArgs object.
                

* __ScaleFactorChanged__: Occurs when the ScaleFactor value has changed. The event handler receives two arguments:
            

* The sender argument contains the RadImageEditor. The argument is of type object but can be cast to the RadImageEditor type.
                

* An EventArgs object.
                

* __ToolCommitted__: Occurs when a tool is committed. The event handler receives two arguments:
            

* The sender argument contains the RadImageEditor. The argument is of type object but can be cast to the RadImageEditor type.
                

* A ToolCommittedEventArgs object which allows you access to the executed tool and provides an option to specify whether the tool should be executed again.
                

* __ToolCommitting__: Occurs before a tool is committed. The event handler receives two arguments:
            

* The sender argument contains the RadImageEditor. The argument is of type object but can be cast to the RadImageEditor type.
                

* A ToolCommittingEventArgs object which allows you access to the tool being executed and provides an option to cancel the execution.
                

>tipWhen a tool is executed, the CommandExecuting/ CommandExecuted events are raised for the ExecuteToolCommand. The specific tool is available from the CommandParameter, however you cannot control its behavior (for example, cancel it). For this purpose the ToolCommitting/ToolCommitted events are raised. You can find a working example of their use in our online SDK reporitory: [Handle Tool Commit](https://github.com/telerik/xaml-sdk/tree/master/ImageEditor/HandleToolCommit).
          

# See Also

 * [Commands and Tools]({%slug radimageeditor-features-commands-and-tools%})
