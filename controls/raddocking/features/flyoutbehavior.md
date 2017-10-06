---
title: FlyoutBehavior
page_title: FlyoutBehavior
description: FlyoutBehavior
slug: raddocking-features-panes-flyoutbehavior
tags: flyoutbehavior
published: True
position: 7
---

# FlyoutBehavior

**RadDocking** exposes a **FlyoutBehavior** property which can be used to change the behavior of the flyout of the control's **AutoHideArea**.

This property could be set to either one of the existing implementations of the **IFlyoutBehavior** interface (**HoverFlyoutBehavior** and **ClickFlyoutBehavior**) or to a custom implementation.

#### __[XAML] Example 1: Setting RadDocking's FlyoutBehavior__

{{region xaml-raddocking-features-panes-flyoutbehavior_0}}
	<telerik:RadDocking.FlyoutBehavior>
        <telerik:ClickFlyoutBehavior/>
    </telerik:RadDocking.FlyoutBehavior>
{{endregion}}

All that's needed for the custom implementation is to implement the IFlyoutBehavior interface and override its following methods:

* **OnClosingTimerTimeout**: Called when the time of the close timer is up. Commonly the close animation is started here. The close timer is started by calling the **StartCloseTimer** method of the **IFlyoutHost**.
* **OnMouseEnter**: Called when the mouse enters a RadPane.
* **OnMouseLeave**: Called when the mouse leaves a RadPane.
* **OnOpeningTimerTimeout**: Called when the time of the open timer is up. Commonly the open animation is started here. The open timer is started by calling the **StartOpenTimer** method of the **IFlyoutHost**.
* **OnPaneActivated**: Called when a RadPane is being activated.
* **OnPaneDeactivated**: Called when a RadPane is being deactivated.
* **OnPaneMouseLeftButtonDown**: This method is called when a pane receives the **MouseLeftButtonDown** event (i.e. when the user clicks it).

>A sample implementation of a custom FlyoutBehavior for the RadDocking control can be found in the **Click Flyout Behavior With Animation** demo from the [SDK Samples Browser](https://demos.telerik.com/xaml-sdkbrowser/).