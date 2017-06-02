---
title: Keyboard Support
page_title: Keyboard Support
description: Keyboard Support
slug: radautocompletebox-features-keyboard-support
tags: keyboard,support
published: True
position: 4
---

# Keyboard Support

Using the keyboard you can perform some of the most common tasks. 

## Keyboard Shortcuts

This section describes the keyboard shortcuts used by RadAutoCompleteBox.

* __Up__: Navigates up through the items in the DropDown portion of the control.

* __Down__: Navigates down through the items in the DropDown portion of the control.

* __Tab__: Selects the highlighted item and loses the focus. If there is no suggested item just loses the focus.

* __Enter__: Closes the DropDown if it is open and selects the currently highlighted item.

* __Escape__: Closes the DropDown and deletes the last non autocompleted entered text.

>When an item is selected with the keyboard, it should be scrolled into the viewport and made visible.

## Customize Shortcuts

As of **R2 2016 SP1** the **HandleKeyDown** method can be overridden in order to customize the keys' default behavior or handle other keys. The method returns **True** if the **KeyDown** event should be handled, and **False** otherwise.

A possible scenario would be to select the highlighted item and move the focus to the next control once the user presses **Tab**. Example 1 demonstrates how this can be achieved.

#### __[C#] Example 1: Overriding the HandleKeyDown method__

{{region cs-radautocompletebox-features-keyboard-support-0}}
	public class CustomAutoCompleteBox : RadAutoCompleteBox
	{
		protected override bool HandleKeyDown(Key systemKey)
		{
			if (systemKey == Key.Tab)
			{
				base.HandleKeyDown(systemKey);
				return false;
			}

			return base.HandleKeyDown(systemKey);
		}
	}
{{endregion}}

#### __[VB.NET] Example 1: Overriding the HandleKeyDown method__

{{region cs-radautocompletebox-features-keyboard-support-0}}
	Public Class CustomAutoCompleteBox
	Inherits RadAutoCompleteBox

		Protected Overrides Function HandleKeyDown(ByVal systemKey As Key) As Boolean
			If systemKey Is Key.Tab Then
				MyBase.HandleKeyDown(systemKey)
				Return False
			End If

			Return MyBase.HandleKeyDown(systemKey)
		End Function
	End Class
{{endregion}}

## Tab Navigation

__TabNavigationExtensions.IsTabStop__ attached property indicates whether RadAutoCompleteBox is included in the tab navigation cycle. __Example 1__ illustrates how to set that property in order to exclude the control from the tab navigation. The property is available since **R3 2016**.

#### __[XAML] Example 2: RadAutoCompleteBox with TabNavigationExtensions.IsTabStop__

{{region xaml-radautocompletebox-features-keyboard-support-0}}
	<telerik:RadAutoCompleteBox telerik:TabNavigationExtensions.IsTabStop="False" />
{{endregion}}
