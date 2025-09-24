---
title: Ribbon SplitButton
page_title: Ribbon SplitButton
description: Check our &quot;Ribbon SplitButton&quot; documentation article for the RadRibbonView {{ site.framework_name }} control.
slug: radribbonview-split-button
tags: ribbon,splitbutton
published: True
position: 5
---

# Ribbon SplitButton

The __RadRibbonSplitButton__ represents an extension of the __RadSplitButton__. It provides an easier interaction with the __RadRibbonView__ control. What is special about the __RadRibbonSplitButton__ is that it is separated into two areas. The first one exposes a default action for the button while the second one pops up the drop down content like the __RadRibbonDropDownButton__ does. This means that the user does not need to open the popup area every time he needs to select an action, he can just select the one exposed directly by the button.	  

>tip To learn more about the __RadSplitButton__ control read its documentation.		

Here is a sample definition of a __RadRibbonSplitButton__ without having any drop down content defined:	  


```XAML
	<telerik:RadRibbonSplitButton LargeImage="Icons/32/paste.png"
	                              Size="Large"
	                              SmallImage="Icons/16/paste.png"
	                              Text="Paste" />
```

>tip As all buttons in the RadRibbonView's set slightly expose the same functionality, take a look at the [Overview]({%slug radribbonview-buttons-overview%}) topic.

This button has its initial size set to __Large__ and its text label set to __"Paste"__.
![{{ site.framework_name }} RadRibbonView Large Split Button](images/RibbonView_Buttons_SplitButton.png)

But if the size of the button is __Medium__, then it will look like this:
![Rad Ribbon View Split Button Medium Size](images/RadRibbonView_SplitButton_MediumSize.png)

Please note that the __Text__ value of the button is displayed in its button part. If you want to modify that behavior and display the __Text__ in the DropDownPart of the button, then you can use the __IsTextInMiddleButton__ property. If set to __False__, this property will make sure the button displays its __Text__ in the DropDownPart of the __RibbonSplitButon__.		

## Setting the Drop Down Content

To set the popup content you have to simply set the __DropDownContent__ property of the button. Here is an example of a __RadRibbonSplitButton__ with three menu items inside its drop down.		


```XAML
	<telerik:RadRibbonSplitButton LargeImage="Icons/32/paste.png" Size="Large"
	        SmallImage="Icons/16/paste.png" Text="Paste">
	    <telerik:RadRibbonSplitButton.DropDownContent>
	        <telerik:RadContextMenu BorderThickness="0">
	            <telerik:RadMenuItem Header="Paste">
	                <telerik:RadMenuItem.Icon>
	                    <Image Source="Icons/16/paste.png" />
	                </telerik:RadMenuItem.Icon>
	            </telerik:RadMenuItem>
	            <telerik:RadMenuItem Header="Paste Special...">
	                <telerik:RadMenuItem.Icon>
	                    <Image Source="Icons/16/pastespecial.png" />
	                </telerik:RadMenuItem.Icon>
	            </telerik:RadMenuItem>
	            <telerik:RadMenuItem Header="Paste as Hyperlink" IsEnabled="False">
	                <telerik:RadMenuItem.Icon>
	                    <Image Source="Icons/16/pastehyperlink.png" />
	                </telerik:RadMenuItem.Icon>
	            </telerik:RadMenuItem>
	        </telerik:RadContextMenu>
	    </telerik:RadRibbonSplitButton.DropDownContent>
	</telerik:RadRibbonSplitButton>
```

![{{ site.framework_name }} RadRibbonView Split Button Dropdown Content](images/RibbonView_Buttons_SplitButton_DDContent.png)

## Handling the Drop Down Events

Besides the __Click__ event, the __RadRibbonSplitButton__ exposes several drop down related events:		

* __DropDownClosed__ - fires after the popup area has been closed.			

* __DropDownOpening__ - fires before the popup area gets opened.			

* __DropDownOpend__ - fires after the popup area has been opened.			


```XAML
	<telerik:RadRibbonSplitButton LargeImage="Icons/32/paste.png"
	                              ...
	                              DropDownClosed="RadRibbonSplitButton_DropDownClosed"
	                              DropDownOpened="RadRibbonSplitButton_DropDownOpened"
	                              DropDownOpening="RadRibbonSplitButton_DropDownOpening">
	    ...
	</telerik:RadRibbonSplitButton>
```


```C#
	private void RadRibbonSplitButton_DropDownClosed(object sender, RoutedEventArgs e)
	{
	}
	private void RadRibbonSplitButton_DropDownOpened(object sender, RoutedEventArgs e)
	{
	}
	private void RadRibbonSplitButton_DropDownOpening(object sender, RoutedEventArgs e)
	{
	}
```


```VB.NET
	Private Sub RadRibbonSplitButton_DropDownClosed(sender As Object, e As RoutedEventArgs)
	End Sub
	
	Private Sub RadRibbonSplitButton_DropDownOpened(sender As Object, e As RoutedEventArgs)
	End Sub
	
	Private Sub RadRibbonSplitButton_DropDownOpening(sender As Object, e As RoutedEventArgs)
	End Sub
```		  

## See Also
 * [Styling the RadRibbonSplitButton]({%slug radribbonview-styling-ribbonsplitbutton%})