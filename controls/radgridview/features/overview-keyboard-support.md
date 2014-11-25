---
title: Keyboard Support
page_title: Keyboard Support
description: Keyboard Support
slug: gridview-overview-keyboard-support
tags: keyboard,support
published: True
position: 7
---

# Keyboard Support


__RadGridView__ exposes several useful properties and events, which can help you control the keyboard interaction and get notified when keyboard events occur. Moreover, using the keyboard you can perform some common tasks, such as:

* Change the __selection__ - use the __arrow__ keys to change your selection. To select multiple rows hold the __Shift\Ctrl__ key pressed and use the arrow keys or the mouse to select the desired rows.

* __Sort__ by multiple columns - just hold the __Shift__ key pressed and click all column headers by which you wish to sort your data.

* __Start cell edit__ - press __F2__ and the current cell will enter in edit mode.

* __End cell edit__ - press __Enter__ while the cell is in edit mode. This will confirm the changes you've made.

* __Cancel cell edit__ - press __Escape__ while the cell is in edit mode. This will rollback the changes you've made.

* __Add new row__ - press __Insert__ and new row will be inserted automatically.

* __Delete existing row__ - users can delete (if supported by the grid __ItemsSource__) selected items using __DELETE__ key. This feature can be controlled with __RadGridView__'s __CanUserDeleteRows__ property.

>In case you require to utilize different commands corresponding to the keyboard interaction, you may take advantage of the IKeyboardCommandProvider Interface and implement your custom logic. Please check  [this article]({%slug gridview-commands-keyboardcommandprovider%}) for a further information.
        

## Properties

* Set the __IsTabStop__ property to include/exclude the control in the tab navigation cycle. If this property is set to __True__, then the control will be included; if it is __False__ it will be skipped.

* The __TabIndex__ property defines the index of the control in the tab navigation cycle. The lower the number is, the earlier the control will be focused while navigating using the Tab key. If you set this property, do not forget to set __IsTabStop__ to __True__. 

* The __TabStopMode__ property of the __column__ denotes if its cells could gain focus with the TAB key navigation.
{% if site.site_name == 'Silverlight' %}

* If you are looking for a better way to control how the tab navigation cycles inside the __RadGridView__, use the property __TabNavigation__. You can set it to one of these three possible values:
{% endif %}

## Events

Here is a list of the common keyboard events exposed by the __RadGridView__, __GridViewRow__ and __GridViewCell__ objects:

* __KeyUp__ - occurs when the user releases a keyboard key. The type of the passed event arguments is __KeyEventArgs__.

* __KeyDown__ - occurs when the user presses a keyboard key. The type of the passed event arguments is __KeyEventArgs__.

In the example below you can see how to attach to __KeyDown__ and __KeyUp__ events from your XAML.

#### __XAML__

{{region gridview-overview-keyboard-support_0}}

	<telerik:RadGridView x:Name="radGridView" KeyDown="radGridView_KeyDown" KeyUp="radGridView_KeyUp"/>
{{endregion}}

>tipIt is always a good practice to attach your event handlers in the XAML, whenever your application logic allows this.

The implementation of both event handlers __radGridView_KeyDown__ and __radGridView_KeyUp__ is located in the code-behind file (C# or VB.NET) and looks like this:

#### __C#__

{{region gridview-overview-keyboard-support_1}}

	private void radGridView_KeyDown( object sender, KeyEventArgs e )
	{
	    MessageBox.Show( "The pressed key is: " + e.Key.ToString() );
	}
	private void radGridView_KeyUp( object sender, KeyEventArgs e )
	{
	    MessageBox.Show( "The released key is: " + e.Key.ToString() );
	}
{{endregion}}


#### __VB.NET__

{{region gridview-overview-keyboard-support_2}}

	Private Sub radGridView_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
	    MessageBox.Show("The pressed key is: " & e.Key.ToString())
	End Sub
	Private Sub radGridView_KeyUp(ByVal sender As Object, ByVal e As KeyEventArgs)
	    MessageBox.Show("The released key is: " & e.Key.ToString())
	End Sub
{{endregion}}


You can attach to the other keyboard events in the same way.

# See Also

 * [RadGridView Overview]({%slug gridview-overview2%})

 * [Mouse Support]({%slug gridview-overview-mouse-support%})

 * [Keyboard Command Provider]({%slug gridview-commands-keyboardcommandprovider%})

 * [Data Binding]({%slug gridview-overview-data-binding%})

 * [Managing Data]({%slug gridview-overview-managing-data%})
