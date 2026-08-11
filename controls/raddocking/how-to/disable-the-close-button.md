---
title: How to Disable the Close Button
page_title: How to Disable the Close Button
description: Check our &quot;How to Disable the Close Button&quot; documentation article for the RadDocking {{ site.framework_name }} control.
slug: raddocking-how-to-disable-the-close-button
tags: how,to,disable,the,close,button
published: True
position: 2
---

# How to Disable the Close Button

The purpose of this tutorial is to show you how to disable/hide the close ("X") button. 

For more information about the RadPane and its visual elements, read [here]({%slug raddocking-panes-radpane%}).

There are two solutions for disabling the close button:

* Setting the __CanUserClose__ property

* Handling the __PreviewClose__ event

## Setting the CanUserClose Property

The first way to disable the close button is to simply __hide__ it. In order to do that you need to set the __CanUserClose__ property of the __RadPane__ to __False__. See the following example.

Here is a simple __RadDocking__ declaration with a single pane.



<snippet id='raddocking-how-to-disable-the-close-button-block_1-xaml' />


As you can see, by default the close button is enabled and you can close the pane anytime when you click the "X".

![{{ site.framework_name }} RadDocking Default Close Button](images/RadDocking_HowTo_DisableCloseButton_010.png)

So, find your __RadPane__ declaration and set the following attribute:



<snippet id='raddocking-how-to-disable-the-close-button-block_2-xaml' />


Now, if you run your application, the close button will be no longer visible.

![{{ site.framework_name }} RadDocking Pane without Close Button](images/RadDocking_HowTo_DisableCloseButton_020.png)

The same operation can be done in the code-behind. In order to do that, set the __CanUserClose__ property on an instance of the __RadPane__ class to __false__.



<snippet id='raddocking-how-to-disable-the-close-button-block_3-cs' />

<snippet id='raddocking-how-to-disable-the-close-button-block_3-vb' />


>Note that even the __CanUserClose__ property is set to False, when you drag your pane so that you make it floatable. The window that contains the pane will still have a close button visible. __However, you won't be able to close if you try to click the "X" button.__

![{{ site.framework_name }} RadDocking with ToolWindow Close Button](images/RadDocking_HowTo_DisableCloseButton_030.png)

## Handling the PreviewClose Event

The second way to disable the close button is to handle the __PreviewClose__ event. So if you take a look again at the initial RadDocking declaration, attach to the __PreviewClose__ event of the __RadDocking__ class.



<snippet id='raddocking-how-to-disable-the-close-button-block_4-xaml' />


Switch to the code-behind and add the following code in the event handler:



<snippet id='raddocking-how-to-disable-the-close-button-block_5-cs' />

<snippet id='raddocking-how-to-disable-the-close-button-block_5-vb' />


Run your application. Note that the close button is now visible. However, if you try to click, the pane won't close. The same is valid when your window is floatable.

## See Also

 * [Visual Structure]({%slug raddocking-visual-structure%})

 * [How to Customize or Remove the RadPane's Menu]({%slug raddocking-how-to-add-menu-items-to-the-radpanes-menu%})

 * [How to Add Buttons to the Pane Header]({%slug raddocking-how-to-add-buttons-to-the-pane-headers%})
