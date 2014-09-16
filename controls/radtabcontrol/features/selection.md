---
title: Selection
page_title: Selection
description: Selection
slug: radtabcontrol-features-selection
tags: selection
publish: True
position: 2
---

# Selection



__RadTabControl__ exposes several useful properties and events, which can help you to work with items selections.
        

## Properties

* By using __SelectedIndex__ property you can get or set the index of the currently selected tab item.

* By using __SelectedItem__ property you can get or set the currently selected tab item. 
          The reference you are passing should be to an instance of __RadTabItem__ that has already been added to the tab
          control items collection.

>If your tab control is bound to a custom collection, then the property __SelectedItem__ will not return 
          __RadTabItem__ as you might expect, but item of the type the source collection contains i.e. 
          __Person__, __TabModel__ etc.

* Another way to make certain tab item selected is by using the __RadTabItem__’s property
          __IsSelected__. This is a Boolean property and when set to __True__, that specific tab
          item is selected, while the previous one gets deselected.

* Use the __SelectedContent__ property to get or set the content of the currently selected tab item. 
          Please note that, when you set value to this property you will replace the content of the currently selected tab item, but the selected
          tab item will not change, it will stay the same.

>__The items counting is zero based, meaning that the index of the first tab items is 0, the index of the second item is 
              1 and so on. Make sure you set the__If you want to clear the selection just set the property __SelectedIndex to -1__.

#### __XAML__

{{region radtabcontrol-features-selection_0}}
	<telerik:RadTabControl x:Name="radTabControl" SelectedIndex="1" SelectionChanged="radTabControl_SelectionChanged">
	</telerik:RadTabControl>
	{{endregion}}



The implementation of the event handler __radTabControl_SelectionChanged__ is located in the 
        code-behind file (C# or VB.NET) and looks like this:

#### __C#__

{{region radtabcontrol-features-selection_1}}
	private void radTabControl_SelectionChanged( System.Object sender, System.Windows.RoutedEventArgs e )
	{
	    RadSelectionChangedEventArgs selectionArgs = ( RadSelectionChangedEventArgs )e;
	    MessageBox.Show( “The selected tab item is ” + ( ( RadTabItem )selectionArgs.AddedItems[ 0 ] ).Header.ToString() );
	}
	{{endregion}}



#### __VB.NET__

{{region radtabcontrol-features-selection_2}}
	Private Sub radTabControl_SelectionChanged( ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs)
	        Dim selectionArgs As RadSelectionChangedEventArgs = DirectCast(e,RadSelectionChangedEventArgs)
	        MessageBox.Show("The selected tab item is " + DirectCast(selectionArgs.AddedItems(0), RadTabItem).Header.ToString() )
	End Sub
	{{endregion}}



>If your tab control is bound to a custom collection, the code above will fail with __InvalidCastException__, 
          because the __AddedItems__ collection will no longer contain items of type 
          __RadTabItem__ and the explicit cast will fail. The collection will contain items that are of the same type 
          that the source collection contains i.e. __Person__, __TabModel__ etc.

# See Also

 * [Keyboard Support]({%slug radtabcontrol-features-keyboard-support%})

 * [Add and Remove Tabs]({%slug radtabcontrol-populating-add-remove-tabs%})
