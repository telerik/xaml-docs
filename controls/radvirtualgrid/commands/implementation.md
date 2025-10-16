---
title: Implementation
page_title: Implementation
description: Check our &quot;Implementation&quot; documentation article for the RadVirtualGrid {{ site.framework_name }} control.
slug: virtualgrid-commands-implementation
tags: commands, implementation
published: True
position: 1
---

# Implementation

The following article will go through the process of utilizing the built-in commands of __RadVirtualGrid__.

A straightforward approach for implementing the commands is to set them directly to a particular __RadButton__. Thus, once you click a single button, the predefined command will be executed. 

__Example 1: Using RadButton for triggering a built-in command__
```XAML
	<telerik:RadButton Width="150" Content="Begin edit" 
           Command="telerik:RadVirtualGridCommands.BeginEdit" 
           CommandTarget="{Binding ElementName=VirtualGrid}" />
```

Note, that the target object needs to be explicitly set in the definition of the __CommandTarget__ Property, specifying the RadVirtualGrid towards which the command has to be applied. 

## See Also

* [Overview]({%slug virtualgrid-commands-overview%})

* [Keyboard Command Provider]({%slug virtualgrid-commands-keyboard-command-provider%})