---
title: Commands
page_title: Commands
description: Commands
slug: radmenu-features-commands
tags: commands
published: True
position: 6
---

# Commands

The __RadMenuItem__ control provides you with a standard __ICommandSource__ implementation. This means that you can bind your items to commands that will get executed when an item is clicked. For this purpose you can use the following properties.

* __Command__ - gets the command that will be executed when the command source is invoked. 

* __CommandParameter__ - represents a user defined data value that can be passed to the command when it is executed.  

* __CommandTarget__ - the object that the command is being executed on.  

>tipAs the __RadMenuItem__ implements the __ICommandSource__, you can use it with any command that implements the __ICommand__ interface, for example the __DelegateCommands__ in Prism.

# See Also

 * [Checkable Items]({%slug radmenu-features-checkable-items%})

 * [Separator Items]({%slug radmenu-features-separator-items%})

 * [Binding to Dynamic Data]({%slug radmenu-populating-with-data-binding-to-dynamic-data%})