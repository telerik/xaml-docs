---
title: Show on Current Screen
page_title: Show on Current Screen
description: Learn how to display the RadDesktopAlerts only on the current screen.
slug: raddesktopalert-show-on-current-screen
tags: visual,structure,difference,alert
published: True
position: 7
---

# Show on Current Screen

By default, the alerts displayed by the RadDesktopAlertManager are only shown on the primary screen.

## Attach

As of **R2 2022**, the `RadDesktopAlertManager` allows you to show alerts on the current screen on which a particular parent window instance is displayed. This can be accomplished via the new `Attach` method of the class.

__Attach the RadDesktopAlertManager to the MainWindow__

```C#
    var manager = new RadDesktopAlertManager();
    manager.Attach(App.Current.MainWindow);
```

After this, if you move the `MainWindow` of the application to another screen (different than the primary), any new alerts shown via the `ShowAlert` will be displayed on this screen.

Actually, you can pass any `DependencyObject` to the Attach method and it will automatically determine the window to which the manager has to be attached.

__Attach the RadDesktopAlertManager to a DependencyObject__

```C#
    var manager = new RadDesktopAlertManager();
    manager.Attach(this.LayoutRoot);
```

>If you attach the same RadDesktopAlertManager instance on a new element, any alerts which are already displayed will remain open. Alerts which are displayed on a different screen will also stay open.
>
>The screenPositionOffset parameter that is passed to the constructor of the RadDesktopAlertManager is not taken into account if the manager is attached to a particular screen.

## Detach

If you want to bring back the default behavior and show the alerts only on the primary screen, you can call the new `Detach` method of the class.

__Detach the RadDesktopAlertManager__

```C#
    manager.Detach();
```

>importantDoing so will close all previously opened alerts.

>You do not need to call the Detach method if you want to attach the manager to a different element.

## See Also  
 * [DesktopAlertManager]({%slug raddesktopalert-desktop-alert-manager%})
 * [Moving Alerts]({%slug raddesktopalert-moving%})
