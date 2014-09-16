---
title: Keyboard Support
page_title: Keyboard Support
description: Keyboard Support
slug: radtreeview-features-keyboard-support
tags: keyboard,support
publish: True
position: 10
---

# Keyboard Support



__RadTreeView__allows you to navigate through the nodes without using the mouse. The keyboard can entirely replace the mouse by allowing you to perform navigation, editing, expanding, collapsing and selecting the nodes.

__RadTreeView__provides first class keyboard support. Here is the list of the keys that are supported:

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

>tipTo obtain the pressed key, the object that raised the event or some other information, use the instance of __System.Windows.Input.KeyEventArgs__ passed as a parameter to the event handler method.

In the example below you can see how to attach to __KeyDown__ and __KeyUp__ events and how to specify a value for the __TabNavigation__ property from your XAML. 

#### __XAML__

{{region radtreeview-features-keyboard-support_0}}
	<telerik:RadTreeView x:Name="radTreeView" KeyDown="radTreeView_KeyDown" KeyUp="radTreeView_KeyUp"/>
	{{endregion}}



The implementation of both of the event handlers __radTreeView_KeyDown__ and __radTreeView_KeyUp__ is located in the code-behind file (C# or VB.NET) and looks like this: 

#### __C#__

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



#### __VB.NET__

{{region radtreeview-features-keyboard-support_2}}
	Private Sub radTreeView_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
	    MessageBox.Show("The pressed key is: " & e.Key.ToString())
	End Sub
	Private Sub radTreeView_KeyUp(ByVal sender As Object, ByVal e As KeyEventArgs)
	    MessageBox.Show("The released key is: " & e.Key.ToString())
	End Sub
	{{endregion}}



# See Also

 * [Mouse Support]({%slug radtreeview-features-mouse-support%})

 * [Drag and Drop]({%slug radtreeview-features-drag-and-drop%})
