---
title: Keyboard Support
page_title: Keyboard Support
description: The article describes the Keyboard Support feature of RadNavigationView.
slug: radnavigationview-features-keyboard-support
tags: keyboard, support, shortcut
position: 4
---

# Keyboard Support

The article describes the Keyboard Support feature of RadNavigationView.

## Keyboard Shortcuts

This section describes the keyboard shortcuts supported by __RadNavigationView__.

* __Escape__: Closes the Navigation Pane.

* __Up__: Highlights the previous RadNavigationViewItem.

* __Down__: Highlights the next RadNavigationViewItem.

* __Left__: Highlights the previous RadNavigationViewItem. If the currently highlighted item has children and it is expanded, it will collapse it.

* __Right__: Highlights the next RadNavigationViewItem. If the currently highlighted item has children and it is collapsed, it will expand it.

* __PageUp__: Highlights the 10th item previous to the currently highlighted item or the first item if there are less than 10.

* __PageDown__: Highlights the 10th item after the currently highlighted item or the last item if there are less than 10.

* __Enter__: Selects the currently highlighted item.

* __Home__: Highlights the first RadNavigationViewItem.

* __End__: Highlights the last RadNavigationViewItem.

* __F4__: Opens/Closes the NavigationPane.

## Customize Shortcuts

In order to customize the behavior for a given shortcut or introduce custom behavior, the __HandleKeyDown__ virtual method can be overriden. __Example 1__ demonstrates how this can be done in order to prevent the closing of the Navigation Pane when the Escape key is hit.

__Example 1: Overriding the RadNavigationView behavior for the Escape key__

```C#
	public class CustomNavigationView : RadNavigationView
    {
        protected override bool HandleKeyDown(Key key)
        {
            if(key == Key.Escape)
            {
                return false;
            }

            return base.HandleKeyDown(key);
        }
    }
```
```VB.NET
	Public Class CustomNavigationView
	    Inherits RadNavigationView

		Protected Overrides Function HandleKeyDown(ByVal key As Key) As Boolean
			If key Is Key.Escape Then
				Return False
			End If

			Return MyBase.HandleKeyDown(key)
		End Function
    End Class
```

## Keyboard Navigation Selection

By default, when the user is navigating through the RadNavigationViewItems with the keyboard, they are only highlighted, but not selected. However, you can change this behavior by setting the __CanKeyboardNavigationSelectItems__ property of the RadNavigationView to __True__. This way the RadNavigationViewItems will be selected when navigating through them.

__Example 1: Setting the CanKeyboardNavigationSelectItems property__
```XAML
	 <telerik:RadNavigationView CanKeyboardNavigationSelectItems="True" />
```

## See Also

* [Icon and IconTemplate]({%slug radnavigationview-icon-and-icontemplate%})
* [Header and Footer]({%slug radnavigationview-header-and-footer%})