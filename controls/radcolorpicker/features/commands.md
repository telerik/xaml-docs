---
title: Commands
page_title: Commands
description: Commands
slug: radcolorpicker-commands
tags: commands
published: True
position: 3
---

# Commands



This topic covers the commands available in __RadColorPicker__. 
      Commanding is a way to invoke some code in the ViewModels when a user interaction is performed instead of invoking a code behind function.

## Command

__RadColorPicker__ provides __Command__ property of type __ICommand__ which can be bound to Command from your ViewModels / Business Objects.
        	This Command is executed in the following cases:        	
			

1. User clicks the left part of the SplitButton (the "A" - like RadButton in the SplitButton)

1. User clicks on a non-selected RadColorPaletteViewItem.

>

Please note that the Command __will not be executed__ when the user clicks on the Toggle Button (the right part of the SplitButton).

Clicking an already selected color __will not trigger__ the Command too.

>

__Command__ is also a property of the __RadColorSelector__. It is triggered when the user clicks a non-selected color from the ColorSelector.
			Among with Command, RadColorPicker and RadColorSelector provide the standard accompanying properties: __CommandParameter__ and __CommandTarget__.
        
