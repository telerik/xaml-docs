---
title: How to Disable the Close Button
page_title: How to Disable the Close Button
description: How to Disable the Close Button
slug: raddocking-how-to-disable-the-close-button
tags: how,to,disable,the,close,button
publish: True
position: 2
---

# How to Disable the Close Button



The purpose of this tutorial is to show you how to disable/hide the close ("X") button. 

For more information about the RadPane and its visual elements, read [here]({%slug raddocking-panes-radpane%}).

There are two solutions for disabling the close button:

* Setting the __CanUserClose__ property

* Handling the __PreviewClose__event

## Setting the CanUserClose Property

The first way to disable the close button is to simply __hide__ it. In order to do that you need to set the __CanUserClose__ property of the __RadPane__to __False__. See the following example.

Here is a simple __RadDocking__declaration with a single pane.

#### __XAML__

{{region raddocking-how-to-disable-the-close-button_0}}
	<telerik:RadDocking x:Name="radDocking">
	    <telerik:RadDocking.DocumentHost>
	        <telerik:RadSplitContainer>
	            <telerik:RadPaneGroup >
	                <telerik:RadPane x:Name="radPane" Title="Pane 1">
	                    <TextBlock Text="Some simple text here"></TextBlock>
	                </telerik:RadPane>
	            </telerik:RadPaneGroup>
	        </telerik:RadSplitContainer>
	    </telerik:RadDocking.DocumentHost>
	</telerik:RadDocking>
	{{endregion}}



As you can see, by default the close button is enabled and you can close the pane anytime when you click the "X".




         
      ![](images/RadDocking_HowTo_DisableCloseButton_010.png)

So, find your __RadPane__declaration and set the following attribute:

#### __XAML__

{{region raddocking-how-to-disable-the-close-button_1}}
	CanUserClose="False"
	{{endregion}}



Now, if you run your application, the close button will be no longer visible.




         
      ![](images/RadDocking_HowTo_DisableCloseButton_020.png)

The same operation can be done in the code-behind. In order to do that, set the __CanUserClose__ property on an instance of the __RadPane__ class to __false__.

#### __C#__

{{region raddocking-how-to-disable-the-close-button_2}}
	private void HideTheCloseButton()
	{
	    radPane.CanUserClose = false;
	}
	{{endregion}}



#### __VB.NET__

{{region raddocking-how-to-disable-the-close-button_3}}
	Private Sub HideTheCloseButton()
	    radPane.CanUserClose = False
	End Sub
	{{endregion}}



>

Note that even the __CanUserClose__property is set to False, when you drag your pane so that you make it floatable. The window that contains the pane will still have a close button visible. __However, you won't be able to close if you try to click the "X" button.__




         
      ![](images/RadDocking_HowTo_DisableCloseButton_030.png)

## Handling the PreviewClose Event

The second way to disable the close button is to handle the __PreviewClose__event. So if you take a look again at the initial RadDocking declaration, attach to the __PreviewClose__event of the __RadDocking__class.

#### __XAML__

{{region raddocking-how-to-disable-the-close-button_4}}
	<telerik:RadDocking x:Name="radDocking" PreviewClose="radDocking_PreviewClose">
	{{endregion}}



Switch to the code-behind and add the following code in the event handler:

#### __C#__

{{region raddocking-how-to-disable-the-close-button_5}}
	private void radDocking_PreviewClose( object sender, StateChangeEventArgs e )
	{
	    e.Handled = true;
	}
	{{endregion}}



#### __VB.NET__

{{region raddocking-how-to-disable-the-close-button_6}}
	Private Sub radDocking_PreviewClose(ByVal sender As Object, ByVal e As StateChangeEventArgs)
	    e.Handled = True
	End Sub
	{{endregion}}



Run your application. Note that the close button is now visible. However, if you try to click, the pane won't close. The same is valid when your window is floatable.

# See Also

 * [Visual Structure]({%slug raddocking-visual-structure%})

 * [How to Customize or Remove the RadPane's Menu]({%slug raddocking-how-to-add-menu-items-to-the-radpanes-menu%})

 * [How to Add Buttons to the Pane Header]({%slug raddocking-how-to-add-buttons-to-the-pane-headers%})
