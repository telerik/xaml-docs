---
title: Use Commands with RadRibbonView Buttons
page_title: Use Commands with RadRibbonView Buttons
description: Check our &quot;Use Commands with RadRibbonView Buttons&quot; documentation article for the RadRibbonView {{ site.framework_name }} control.
slug: radribbonview-howto-use-commands-with-radribbonview-buttons
tags: use,commands,with,radribbonview,buttons
published: True
position: 12
---

# Use Commands with RadRibbonView Buttons

All __RadRibbonView__ buttons provide a standard __ICommandSource__ implementation. This is why you can bind the __RadRibbonButtons__ to commands that will get executed when a button is clicked. For this purpose you can use the following properties.		

* __Command__ - gets the command that will be executed when the command source is invoked.

* __CommandParameter__ - represents a user defined data value that can be passed to the command when it is executed.

* __CommandTarget__ - the object on which the command is being executed.			

>tip As all butons implement the __ICommandSource__ interface, you can use them with any command that implements the __ICommand__ interface, for example the __DelegateCommands__.		  

Here is an example of a command usage in a MVVM scenario. The command is located in the __ButtonViewModel__ class.		


<snippet id='radribbonview-how-to-howto-use-commands-with-radribbonview-buttons-block_1-cs' />
<snippet id='radribbonview-how-to-howto-use-commands-with-radribbonview-buttons-block_2-vb' />

Set the __ButtonViewModel__ as the __DataContext__ of your __UserControl__.	  


<snippet id='radribbonview-how-to-howto-use-commands-with-radribbonview-buttons-block_3-cs' />
<snippet id='radribbonview-how-to-howto-use-commands-with-radribbonview-buttons-block_4-vb' />

In the XAML provide the bindings for the command and set the command parameter.		

>tip This can be applied to each of the __RadRibbonButtons__. To learn more about them read [here]({%slug radribbonview-buttons-overview%}). Commands can be used with any control, placed in the __RadRibbonView__, that implements the __ICommandSource__ interface.		  


<snippet id='radribbonview-how-to-howto-use-commands-with-radribbonview-buttons-block_5-xaml' />

## See Also
 * [RibbonButtons]({%slug radribbonview-buttons-overview%})