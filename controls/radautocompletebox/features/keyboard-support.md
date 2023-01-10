---
title: Keyboard Support
page_title: Keyboard Support
description: Check our &quot;Keyboard Support&quot; documentation article for the RadAutoCompleteBox {{ site.framework_name }} control.
slug: radautocompletebox-features-keyboard-support
tags: keyboard,support
published: True
position: 4
---

# {{ site.framework_name }} RadAutoCompleteBox Keyboard Support

Using the keyboard you can perform some of the most common tasks. 

## Keyboard Shortcuts

This section describes the keyboard shortcuts used by RadAutoCompleteBox.

* __Up__: Navigates up through the items in the DropDown portion of the control.

* __Down__: Navigates down through the items in the DropDown portion of the control.

* __Tab__: Selects the highlighted item and loses the focus. If there is no suggested item just loses the focus.

* __Enter__: Closes the DropDown if it is open and selects the currently highlighted item.

* __Escape__: Closes the DropDown and deletes the last entered text which has not been autocompleted.

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

{{region vb-radautocompletebox-features-keyboard-support-0}}
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

## HighlightedIndex

With the **2020.3.817** version of the controls the RadAutoCompleteBox exposes a new **HighlightedIndex** property which you can use to manually change the highlighted item. This property can be used along with the **HandleKeyDown** method to allow navigation using the **Page Up** and **Page Down** keys, for example.

#### __[C#] Example 2: Using the HighlightedIndex property in the HandleKeyDown method__

{{region cs-radautocompletebox-features-keyboard-support-1}}
    public class CustomAutoCompleteBox : RadAutoCompleteBox
    {
        protected override bool HandleKeyDown(Key systemKey)
        {
            if (systemKey == Key.PageDown)
            {
                this.HighlightedIndex += 10;
                return true;
            }

            if (systemKey == Key.PageUp)
            {
                this.HighlightedIndex -= 10;
                return true;
            }

            return base.HandleKeyDown(systemKey);
        }
    }
{{endregion}}

#### __[VB.NET] Example 2: Using the HighlightedIndex property in the HandleKeyDown method__

{{region vb-radautocompletebox-features-keyboard-support-1}}
	Public Class CustomAutoCompleteBox
		Inherits RadAutoCompleteBox

		Protected Overrides Function HandleKeyDown(ByVal systemKey As Key) As Boolean
			If systemKey Is Key.PageDown Then
				Me.HighlightedIndex += 10
				Return True
			End If

			If systemKey Is Key.PageUp Then
				Me.HighlightedIndex -= 10
				Return True
			End If

			Return MyBase.HandleKeyDown(systemKey)
		End Function
	End Class
{{endregion}}

## Tab Navigation

__TabNavigationExtensions.IsTabStop__ attached property indicates whether RadAutoCompleteBox is included in the tab navigation cycle. __Example 1__ illustrates how to set that property in order to exclude the control from the tab navigation. The property is available since **R3 2016**.

#### __[XAML] Example 3: RadAutoCompleteBox with TabNavigationExtensions.IsTabStop__

{{region xaml-radautocompletebox-features-keyboard-support-2}}
	<telerik:RadAutoCompleteBox telerik:TabNavigationExtensions.IsTabStop="False" />
{{endregion}}

## See Also

* [Key Properties]({%slug radautocompletebox-features-key-properties%})
* [Filtering Behavior]({%slug radautocompletebox-features-filteringbehavior%})
