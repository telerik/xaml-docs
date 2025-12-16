---
title: Keyboard Support
page_title: Keyboard Support
description: Check our &quot;Keyboard Support&quot; documentation article for the RadTabControl {{ site.framework_name }} control.
slug: radtabcontrol-features-keyboard-support
tags: keyboard,support
published: True
position: 5
---

# Keyboard Support

__RadTabControl__ exposes several useful properties and events, which can help you to control the keyboard interaction and to get notified when a key is up or down.

## Properties 

Set the __IsTabStop__ property to include/exclude the control in the tab navigation cycle. If this property is set to __True__, then the control will be included; if it is __False__ it will be skipped.

* The __TabIndex__ property defines the index of the control in the tab navigation cycle. The lower the number, the earlier the control will be focused while navigating using the Tab key. If you set this property, do not forget to set __IsTabStop__ to __True__. Once focused, you can navigate through the tab pages using the left and right arrow keys. 

## Events

* __KeyDown__ – get notified when the user has pressed a keyboard key.

* __KeyUp__– get notified when the user has released a keyboard key.

>tip To obtain the pressed key, the object that raised the event or some other information, use the instance of __System.Windows.Input.KeyEventArgs__ passed as a parameter to the event handler method.

```XAML
	<telerik:RadTabControl x:Name="tabControl" KeyDown="tabControl_KeyDown" KeyUp="tabControl_KeyUp"/>
```

The implementation of both event handlers __tabControl_KeyDown__ and __tabControl_KeyUp__ is located in the code-behind file and looks like this:

```C#
	private void tabControl_KeyDown( System.Object sender, System.Windows.Input.KeyEventArgs e)
	{
	    MessageBox.Show("The pressed key is: " + e.Key.ToString());
	}
	private void tabControl_KeyUp( System.Object sender, System.Windows.Input.KeyEventArgs e)
	{
	    MessageBox.Show("The released key is: " + e.Key.ToString());
	}
```
```VB.NET
	Private Sub tabControl_KeyDown( ByVal sender As System.Object, ByVal e As System.Windows.Input.KeyEventArgs)
	    MessageBox.Show("The pressed key is: " + e.Key.ToString())
	End Sub
	Private Sub tabControl_KeyUp( ByVal sender As System.Object, ByVal e As System.Windows.Input.KeyEventArgs)
	    MessageBox.Show("The released key is: " + e.Key.ToString())
	End Sub
```

## See Also

 * [Controlling Behavior]({%slug radtabcontrol-features-controlling-behavior%})
