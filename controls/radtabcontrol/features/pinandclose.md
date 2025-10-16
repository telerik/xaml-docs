---
title: Pin and Close
page_title: Pin and Close
description: RadTabControl allows you to pin/unpin and close its RadTabItems.
slug: radtabcontrol-features-pinandclose
tags: pinned,closed,buttonclose, radtabitem,radtabcontrol,plus,
published: True
position: 0
---

# Pin and Close

With the __R2 2019__ version of our controls, the RadTabControl now allows further customization of its items by providing pinning and closing its tab items out of the box. Every RadTabItem now can be pinned or close with a click of a button. 

The purpose of this article is to get you familiar with these functionalities.

## Pin/Unpin

The pin button of the RadTabItem is collapsed by default. Pin functionality can be enabled by setting the __PinButtonVisibility__ Visibility property to Visible. To check if given tab item is pinned you can use its __IsPinned__ property. To get the current pinned tab items you can use the __PinnedItems__ collection.

> The PinnedItems collection of the RadTabControl is __ReadOnlyCollection<RadTabItem>__ so no items can be added or removed. You can only use this collection for iteration or to get the current number of the pinned tabs by using its __Count()__ method.

__Example 1: Show the Pin button__
```XAML
	<Style TargetType="telerik:RadTabItem" >
		<Setter Property="PinButtonVisibility" Value="Visible"/>
	</Style>
```

When an item is pinned it will be moved to the lowest index which is not occupied. For example, when no items are pinned, the first pinned item will move it to index 0 of __PinnedItems__ collection. If there are 3 pinned items, they will be in indices: 0,1,2. Pinning another item will move it to position 3.

Similar behavior is observed when an item is unpinned. Unpinning an item will move it to the first index possible which is not pinned. For example if items 0 1 2 are pinned. If you unpin 1 it will go to index 2. Unpinning removes the item from the __PinnedItems__ collection.

> The pinned/unpinned item will be brought into the view.

![{{ site.framework_name }} RadTabControl Pinned Unpinned Items](images/tabcontrol-pinned-tabitems.png)

## Close

The close button of the RadTabItem is collapsed by default. The button can be shown by setting the __CloseButtonVisibility__ property of the __RadTabItem__ to __Visible__.

> RadTabItem can be close by pressing the mouse middle button while the mouse is over it.

__Example 2: Show the Close button__
```XAML
	<Style TargetType="telerik:RadTabItem" >
		<Setter Property="CloseButtonVisibility" Value="Visible"/>
	</Style>
```

![{{ site.framework_name }} RadTabControl Tab Items with Close Button](images/tabcontrol-closebutton-tabitems.png)

To prevent the tab from closing when the middle mouse button is pressed, set the __CloseTabsOnMouseMiddleButtonDown__ property of RadTabControl to False.

__Example 3: Disable closing the tabs when the middle mouse button is pressed__
```XAML
	<telerik:RadTabControl CloseTabsOnMouseMiddleButtonDown="False" />
```

## Events

__RadTabControl__ provides several events in regards to its pinning and closing functionalities:

### Close events
 
* __PreviewTabClosed__: Occurs before the tab item is closed. The type of the passed event arguments is __PreviewTabChangedEventArgs__. Closing the tab can be canceled by setting the __Cancel__ property from the event arguments.

* __TabClosed__: Occurs after the tab item is closed. The type of the passed event arguments is __TabChangedEventArgs__. You can get the current closed tab and its DataContext from the __TabItem__ and __DataContext__ properties from the event arguments.

### Pin events

* __PreviewTabPinned__: Occurs before the tab item is pinned. The type of the passed event arguments is __PreviewTabChangedEventArgs__. Pinning the tab can be canceled by setting the __Cancel__ property from the event arguments.
* __TabPinned__:  Occurs after the tab item is pinned. The type of the passed event arguments is __TabChangedEventArgs__. You can get the currently pinned tab and its DataContext from the __TabItem__ and __DataContext__ properties from the event arguments.

* __PreviewTabUnpinned__: Occurs before the tab item is unpinned. The type of the passed event arguments is __PreviewTabChangedEventArgs__. Unpinning the tab can be canceled by setting the __Cancel__ property from the event arguments.
* __TabUnpinned__: Occurs after the tab item is unpinned. The type of the passed event arguments is __TabChangedEventArgs__. You can get the current unpinned tab and its DataContext from the __TabItem__ and __DataContext__ properties from the event arguments.

## Commands

RadTabControl exposes its pinned/unpinned functionality through two commands that can be executed on its behalf. These two commands are placed in the static class __TabItemCommands__.

### TogglePin command

When executing the command on a given RadTabItem the item will be pinned/unpinned depending on its current state.

__Example 4: Execute the TogglePin command__
```C#
	TabItemCommands.TogglePin.Execute(null,myRadTabItem);
```

### Close command

When executing the command on a given RadTabItem the item will be close.

__Example 5: Execute the Close command__
```C#
	TabItemCommands.Close.Execute(null,myRadTabItem);
```

## Notes

* __Multi-line Tabs with ReorderTabRows (True by default)__: Pinning items rules are not followed when multiline tabs occur and ReorderTabRows is TRUE (default value). ReorderTabRows makes the selected tab always on the last row so that content is as close as possible. So please consider Pinning items not supported in this case. If you need multiline tabs and pinning please set ReorderTabRows to False.

* __Drag and Drop for pinned/unpinned items__: When the AllowDragReorder property is set to True the user will be able to rearrange the tabs while dragging them. When there are pinned/unpinned tab items this behavior is slightly different. You could rearrange the pinned or unpinned items while performing a dragging operation. Dragging a pinned tab item between unpinned tabs are not allowed.

## See Also  
 * [Keyboard Support]({%slug radtabcontrol-features-keyboard-support%})
 * [Add and Remove Tabs]({%slug radtabcontrol-populating-add-remove-tabs%})
