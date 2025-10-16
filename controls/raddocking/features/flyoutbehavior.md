---
title: FlyoutBehavior
page_title: FlyoutBehavior
description: Check our &quot;FlyoutBehavior&quot; documentation article for the RadDocking {{ site.framework_name }} control.
slug: raddocking-features-panes-flyoutbehavior
tags: flyoutbehavior
published: True
position: 7
---

# FlyoutBehavior

The flyout behavior controls how and when the flyout of the __auto hide area__ is opened and closed. RadDocking comes with two implementations of the __IFlyoutBehavior__ - __ClickFlyoutBehavior__ and __HoverFlyoutBehavior__.

## HoverFlyoutBehavior

This is the default behavior. It opens the flyout on hover (mouse over) or activation of a pane inside the auto hide area. The flyout closes when the mouse leaves it.

![RadDocking with HoverFlyoutBehavior](images/raddocking-features-panes-flyoutbehavior-0.gif).

## ClickFlyoutBehavior

It opens the flyout on click or activation of a pane inside the auto hide area. The flyout closes on second click on the pane or when the pane gets deactived.

![RadDocking with ClickFlyoutBehavior](images/raddocking-features-panes-flyoutbehavior-1.gif).

## Setting Flyout Behavior

To set or get the current flyout behavior use the __FlyoutBehavior__ property of RadDocking.

__Example 1: Setting flyout behavior__
```XAML
	<telerik:RadDocking.FlyoutBehavior>
        <telerik:ClickFlyoutBehavior/>
    </telerik:RadDocking.FlyoutBehavior>
```

## Custom Flyout Behavior

To create a custom flyout behavior, implement the __IFlyoutBehavior__ interface. The interface requires the following methods to be implemented:

* __OnClosingTimerTimeout__: Called when the time of the close timer is up. Commonly the close animation is started here. The close timer is started by calling the __StartCloseTimer__ method of the __IFlyoutHost__.

* __OnMouseEnter__: Called when the mouse enters a RadPane.

* __OnMouseLeave__: Called when the mouse leaves a RadPane.

* __OnOpeningTimerTimeout__: Called when the time of the open timer is up. Commonly the open animation is started here. The open timer is started by calling the __StartOpenTimer__ method of the __IFlyoutHost__.

* __OnPaneActivated__: Called when a RadPane is being activated.

* __OnPaneDeactivated__: Called when a RadPane is being deactivated.

* __OnPaneMouseLeftButtonDown__: This method is called when a pane receives the MouseLeftButtonDown event (i.e. when the user clicks it).

The following example shows how to implement a __custom behavior__ that opens the flyout on click and animates the opening and closing.

__Example 2: Custom flyout behavior__
```C#
	public class AnimatedFlyoutBehavior : IFlyoutBehavior
    {
        void IFlyoutBehavior.OnPaneActivated(IFlyoutHost host, RadPane targetPane)
        {
            host.SetSelectedPane(targetPane);
            if (host.CurrentState == FlyoutState.Closed)
            {
                host.StartOpenAnimation();
            }
        }

        void IFlyoutBehavior.OnPaneDeactivated(IFlyoutHost host, RadPane targetPane)
        {
            var selectedPane = host.SelectedPane;
            if (selectedPane != null && !selectedPane.IsActive && host.CurrentState == FlyoutState.Opened)
            {
                host.StartCloseAnimation();
            }
        }

        void IFlyoutBehavior.OnPaneMouseLeftButtonDown(IFlyoutHost host, RadPane targetPane)
        {
            if (host.CurrentState != FlyoutState.Opened)
            {
                host.StartOpenAnimation();
            }
            else
            {
                host.StartCloseAnimation();
            }
        }
		
		void IFlyoutBehavior.OnMouseEnter(IFlyoutHost host, RadPane targetPane)
        {
        }

        void IFlyoutBehavior.OnMouseLeave(IFlyoutHost host)
        {
        }

        void IFlyoutBehavior.OnOpeningTimerTimeout(IFlyoutHost host)
        {
        }

        void IFlyoutBehavior.OnClosingTimerTimeout(IFlyoutHost host)
        {
        }
    }
```

__Example 3: Setting the custom flyout behavior__
```XAML
	<telerik:RadDocking.FlyoutBehavior>
        <local:AnimatedFlyoutBehavior/>
    </telerik:RadDocking.FlyoutBehavior>
```

>tip A runnable project with this example can be found in the [ClickFlyoutBehaviorWithAnimation](https://github.com/telerik/xaml-sdk/tree/master/Docking/ClickFlyoutBehaviorWithAnimation) SDK example.

## Flyout Min Length

The flyout popup element has a default minimum length of 50px. To change this, set the __FlyoutMinLength__ property of RadDocking. The property value applies to the width of the left and right auto-hide area flyouts and to the height of the top and bottom auto-hide area flyouts. 

__Example 2: Setting the minimum size of the flyout popup__
```XAML
	<telerik:RadDocking FlyoutMinLength="150">
```
