---
title: Balloon Notifications
page_title: Balloon Notifications
description: This article allows demonstrates how to display a balloon notification via the API exposed by the RadNotifyIcon.
slug: radnotifyicon-balloon-notifications
tags: balloon, notifications, notifyicon
position: 4
---

# Balloon Notifications

With the `RadNotifyIcon` you can show a notification allowing you to display a message or prompt the user for some action.

## Balloon Notification Properties

The RadNotifyIcon exposes the following properties for controlling the look of the notification:

* `BalloonTitle`&mdash;Gets or sets the title of the balloon tip.
* `BalloonText`&mdash;Gets or sets the text of the balloon tip.
* `BalloonIcon`&mdash;A property of type `System.Drawing.Icon` that gets or sets the icon of the balloon tip.
* `BalloonIconSource`&mdash;This property provides an alternative way of setting an icon by using an `ImageSource` or a __string__ path pointing to the location of your icon.

> If the BalloonIconSource property is set, it should point to an __.ico__ file.

>tip Use an .ico file with bigger dimensions (Width/Height) as Windows can scale it down, however, it will not be scaled up if it is less than the default size. 

__Setting up the RadNotifyIcon__
```XAML
    <Grid>
        <Button Content="Show notification" Click="OnShowNotification" />
        <telerik:RadNotifyIcon
            x:Name="icon"
            BalloonText="Balloon Text"
            BalloonTitle="Balloon Title"
            TrayIconSource="/Icons/ProgressGreen.ico"
            BalloonIconSource="/Icons/ProgressGreen.ico">
        </telerik:RadNotifyIcon>
    </Grid>
```

__Showing a notification__
```C#  
    private void OnShowNotification(object sender, RoutedEventArgs e)
    {
        this.icon.ShowBalloonTip();
    }
```
```VB.NET
    Private Sub OnShowNotification(ByVal sender As Object, ByVal e As RoutedEventArgs)
        Me.icon.ShowBalloonTip()
    End Sub
```

__Balloon Notification__

![Balloon Notification](images/radnotifyicon_balloon_tip.png)

## ShowBalloonTip Overloads

Here are the overloads exposed by the ShowBallonTip method:

* **void ShowBalloonTip(int timeout = 10)**&mdash;This overload uses the `BalloonTitle`, `BalloonText` and the icon provided by `BalloonIcon`/`BalloonIconSource` properties to show a notification. Optionally an integer can be passed to specify the amount of seconds to wait before the balloon auto hides (The system minimum and maximum are 10 and 30 seconds).

      > The timeout parameter is not supported by the Windows OS after Windows Vista, so setting the `timeout` won't do anything.

* **void ShowBalloonTip(string title, string text, BalloonTipIcon icon, bool doNotPlaySound = false, int timeout = 10)**&mdash;This overload allows for passing a title, text, and choosing an icon from the set of standardized icons. Optionally you can specify whether sound should be played and the amount of seconds to wait before the balloon auto hides (The system minimum and maximum are 10 and 30 seconds). 

	__Showing a warning notification__
	```C#
		this.icon.ShowBalloonTip("Warning", "Emergency", BalloonTipIcon.Warning, false, 15);
	```
	```VB.NET
			Me.icon.ShowBalloonTip("Warning", "Emergency", BalloonTipIcon.Warning, False, 15)
	```

    __Warning Notification__

    ![Warning Notification](images/radnotifyicon_balloon_tip_warning.png)

* **void ShowBalloonTip(string title, string text, System.Drawing.Icon icon, bool useLargeIcon = true, bool doNotPlaySound = false, int timeout = 10)**&mdash;This overload allows for passing a title, text, and a `System.Drawing.Icon` instance. Optionally you can specify whether the large version of the provided icon should be used, whether sound should be played and the amount of seconds to wait before the balloon auto hides (The system minimum and maximum are 10 and 30 seconds). 

    __Showing a notification with custom icon__
    ```C#
        var icon = new System.Drawing.Icon("YourIconPath.ico");
        this.icon.ShowBalloonTip("Balloon Title", "Balloon Text", icon, true, false, 15);
    ```
	```VB.NET
        Dim icon = New System.Drawing.Icon("YourIconPath.ico")
        Me.icon.ShowBalloonTip("Balloon Title", "Balloon Text", icon, True, False, 15)
    ```

## Hide the Notification

You can manually hide the notification by invoking the `HideBalloonTip` method.

__Hide the notification__
```C#
    this.icon.HideBalloonTip();
```
```VB.NET
    Me.icon.HideBalloonTip()
```

## See Also 

* [Events]({%slug radnotifyicon-events%})
* [Tooltip]({%slug radnotifyicon-tooltip%})
* [Popup]({%slug radnotifyicon-popup%})
* [ContextMenu]({%slug radnotifyicon-contextmenu%})
