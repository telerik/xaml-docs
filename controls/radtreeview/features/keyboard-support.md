---
title: Keyboard Support
page_title: Keyboard Support
description: Keyboard Support
slug: radtreeview-features-keyboard-support
tags: keyboard,support
published: True
position: 10
---

# Keyboard Support

__RadTreeView__ allows you to navigate through the nodes without using the mouse. The keyboard can entirely replace the mouse by allowing you to perform navigation, editing, expanding, collapsing and selecting the nodes.

* [Keys List](#keys-list)
* [Properties](#properties)
* [Events](#events)
* [Keyboard Selection](#keyboard-selection)

## Keys List

__RadTreeView__ provides first class keyboard support. Here is the list of the keys that are supported:

* __ARROW KEYS__ - navigate in the tree
* __PageUp, PageDown__ - page the __RadTreeViewItems__ in the view port area
* __End, Home__ - go to last/first visible item
* __ENTER__ - if in edit mode - set the new item value, else toggle collapsed/expanded state
* __ESC__ - cancel edit or drag
* __MULTIPLY__ - Expand all child items
* __DIVIDE__ - Collapse all child items
* __ADD, SUBSTRACT__ - expand/collapse selected item
* __F2, SPACE__ - start edit mode
* __CTRL, SHIFT__ - multiple item selection

__RadTreeView__ exposes several useful properties and events, which can help you control the keyboard interaction and get notified when a key is up or down.

## Properties 

Set the __IsTabStop__ property to include/exclude the control in the tab navigation cycle. If this property is set to __True__, then the control will be included; if it is __False__ then it will be skipped.

* The __TabIndex__ property defines the index of the control in the tab navigation cycle. The lower the number is, the earlier the control will be focused while navigating using the Tab key. If you set this property, do not forget to set __IsTabStop__ to True. Once focused, you can navigate through the tab pages using the left and the right arrow keys. 

## Events 

* __KeyDown__ - Get notofied when the user has pressed a keyboard key.
* __KeyUp__ - Get notified when the user has released a keyboard key.

>tip To obtain the pressed key, the object that raised the event or some other information, use the instance of __System.Windows.Input.KeyEventArgs__ passed as a parameter to the event handler method.

In the example below you can see how to attach to __KeyDown__ and __KeyUp__ events and how to specify a value for the __TabNavigation__ property from your XAML. 

#### __[XAML] Example 1: Subscribing to the KeyDown and KeyUp events__

{{region radtreeview-features-keyboard-support_0}}
	<telerik:RadTreeView x:Name="radTreeView" KeyDown="radTreeView_KeyDown" KeyUp="radTreeView_KeyUp"/>
	{{endregion}}



The implementation of both of the event handlers __radTreeView_KeyDown__ and __radTreeView_KeyUp__ is located in the code-behind file (C# or VB.NET) and looks like this: 

#### __[C#] Example 2: Handling the KeyDown and KeyUp events__

{{region radtreeview-features-keyboard-support_1}}
	private void radTreeView_KeyDown( object sender, KeyEventArgs e )
	{
	    MessageBox.Show( "The pressed key is: " + e.Key.ToString() );
	}
	private void radTreeView_KeyUp( object sender, KeyEventArgs e )
	{
	    MessageBox.Show( "The released key is: " + e.Key.ToString() );
	}
	{{endregion}}

#### __[VB.NET] Example 2: Handling the KeyDown and KeyUp events__

{{region radtreeview-features-keyboard-support_2}}
	Private Sub radTreeView_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
	    MessageBox.Show("The pressed key is: " & e.Key.ToString())
	End Sub
	Private Sub radTreeView_KeyUp(ByVal sender As Object, ByVal e As KeyEventArgs)
	    MessageBox.Show("The released key is: " & e.Key.ToString())
	End Sub
	{{endregion}}

## Keyboard Selection

>More information on the __IsSelectable__ property of __RadTreeViewItem__ can be found in the [Selection]({%slug radtreeview-feautres-treeviewitem-selection%}) topic.

By default, navigating through the keyboard will select the given __RadTreeViewItem__. It exposes the __IsSelectable__ property through which this default behavior can be altered. Let's have the following example. In it the first item is selected and the second one has its __IsSelectable__ property set to __False__.

#### __Figure 1: RadTreeView with its first item selected__
![RadTreeView with its first item selected](images/RadTreeView_KeyboardSupport_01.png)

When pressing the Down arrow key in this case the end result will be as follows.

#### __Figure 2: RadTreeView with the IsSelectable of the second item set to False__
![RadTreeView with its first item selected](images/RadTreeView_Keyboard_Support_02.png)

## See Also
 * [Mouse Support]({%slug radtreeview-features-mouse-support%})
 * [Drag and Drop]({%slug radtreeview-features-drag-and-drop%})