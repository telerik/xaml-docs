---
title: How to Add Buttons to the Pane Header
page_title: How to Add Buttons to the Pane Header
description: Check our &quot;How to Add Buttons to the Pane Header&quot; documentation article for the RadDocking {{ site.framework_name }} control.
slug: raddocking-how-to-add-buttons-to-the-pane-headers
tags: how,to,add,buttons,to,the,pane,header
published: True
position: 1
---

# How to Add Buttons to the Pane Header

The purpose of this tutorial is to walk you through the common task of adding buttons to the pane header and attaching some behavior to them.

>tip For more information about the __RadPane__ and its visual elements, read [here]({%slug raddocking-panes-radpane%}).

For the purpose of this tutorial, the following __RadDocking__ declaration will be used:



<snippet id='raddocking-how-to-add-buttons-to-the-pane-headers-block_1-xaml' />


![{{ site.framework_name }} RadDocking Sample Declaration](images/RadDocking_HowTo_AddHeaderButton_020.png)

## Adding Buttons to the Pane Header 

In order to add additional elements to the pane header, you need to set the __TitleTemplate__ of the __RadPane__.

Create a new data template in your XAML. For example, see the next declaration:



<snippet id='raddocking-how-to-add-buttons-to-the-pane-headers-block_2-xaml' />


Change your XAML declaration and set the __TitleTemplate__ property of the __RadPane__.



<snippet id='raddocking-how-to-add-buttons-to-the-pane-headers-block_3-xaml' />


Now you will get a result which is the same as the final one. The only difference is that when you click the button nothing will happen.

![{{ site.framework_name }} RadDocking with Pane Header Button](images/RadDocking_HowTo_AddHeaderButton_030.png)

## Adding a Behavior

In order to add a behavior to the button, you should use the command mechanism. __RadDocking__ defines commands for all the items in the menu. So if want to add a "make floating" button in the header, you can use the command property of the button: 



<snippet id='raddocking-how-to-add-buttons-to-the-pane-headers-block_4-xaml' />


>This is the complete list of the exposed __RadDocking__ commands:
>	* Close
>	* ContextMenuOpen
>	* Floating
>	* Dockable
>	* PaneHeaderMenuOpen
>	* Pin
>	* TabbedDocument

Of course you may need to do something more complex than just one of the standard actions. In this situation you might prefer implementing your own commands.

Note that in the previous example, the button will be __enabled__ only when the __RadPane__ is docked. Respectively, when the pane is in floating state, the button will be __disabled__.

## See Also

 * [How to Disable the Close Button]({%slug raddocking-how-to-disable-the-close-button%})

 * [How to Implement Conditional Docking]({%slug raddocking-how-to-implement-conditional-docking%})
