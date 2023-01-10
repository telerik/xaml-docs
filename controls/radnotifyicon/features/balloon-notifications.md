---
title: Balloon Notifications
page_title: Balloon Notifications
description: This article allows demonstrates how to display a balloon notification via the API exposed by the RadNotifyIcon.
slug: radnotifyicon-balloon-notifications
tags: balloon, notifications, notifyicon
position: 4
---

# {{ site.framework_name }} RadNotifyIcon Balloon Notifications

With the __RadNotifyIcon__ you can show a notification allowing you to display a message or prompt the user for some action.

## Balloon Notification Properties

The RadNotifyIcon exposes the following properties for controlling the look of the notification:

* __BalloonTitle__: Gets or sets the title of the balloon tip.
* __BalloonText__: Gets or sets the text of the balloon tip.
* __BalloonIcon__: A property of type __System.Drawing.Icon__ that gets or sets the icon of the balloon tip.
* __BalloonIconSource__: This property provides an alternative way of setting an icon by using an __ImageSource__ or a __string__ path pointing to the location of your icon.

> If the __BalloonIconSource__ property is set, it should point to an __.ico__ file. 
<!-- -->
>tip Use an .ico file with bigger dimensions (Width/Height) as Windows can scale it down, however it will not be scaled up, if it is less than the default size. 

#### __[XAML] Example 1: Setting up the RadNotifyIcon__
{{region xaml-radnotifyicon-balloon-notifications-0}}
    
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
{{endregion}}

#### __[C#] Example 2: Showing a notification__
{{region cs-radnotifyicon-balloon-notifications-1}}
    
    private void OnShowNotification(object sender, RoutedEventArgs e)
    {
        this.icon.ShowBalloonTip();
    }
{{endregion}}

#### __[VB.NET] Example 2: Showing a notification__
{{region vb-radnotifyicon-balloon-notifications-2}}
    
    Private Sub OnShowNotification(ByVal sender As Object, ByVal e As RoutedEventArgs)
        Me.icon.ShowBalloonTip()
    End Sub
{{endregion}}

#### __Figure 1: Balloon Notification__

![Balloon Notification](images/radnotifyicon_balloon_tip.png)

## ShowBalloonTip Overloads

Here are the overloads exposed by the ShowBallonTip method:

* **void ShowBalloonTip(int timeout = 10)**: This overload uses the __BalloonTitle__, __BalloonText__ and the icon provided by __BalloonIcon__/__BalloonIconSource__ properties to show a notification. Optionally an integer can be passed to specify the amount of seconds to wait before the balloon auto hides (The system minimum and maximum are 10 and 30 seconds).

* **void ShowBalloonTip(string title, string text, BalloonTipIcon icon, bool doNotPlaySound = false, int timeout = 10)**: This overload allows for passing a title, text and choosing an icon from the set of standardized icons. Optionally you can specify whether sound should be played and the amount of seconds to wait before the balloon auto hides (The system minimum and maximum are 10 and 30 seconds). 

    #### __[C#] Example 3: Showing a warning notification__
    {{region cs-radnotifyicon-balloon-notifications-3}}
        
        this.icon.ShowBalloonTip("Warning", "Emergency", BalloonTipIcon.Warning, false, 15);
    {{endregion}}

    #### __[VB.NET] Example 3: Showing a warning notification__
    {{region vb-radnotifyicon-balloon-notifications-4}}
        
        Me.icon.ShowBalloonTip("Warning", "Emergency", BalloonTipIcon.Warning, False, 15)
    {{endregion}}

    #### __Figure 2: Warning Notification__

    ![Warning Notification](images/radnotifyicon_balloon_tip_warning.png)

* **void ShowBalloonTip(string title, string text, System.Drawing.Icon icon, bool useLargeIcon = true, bool doNotPlaySound = false, int timeout = 10)**: This overload allows for passing a title, text and a __System.Drawing.Icon__ instance. Optionally you can specify whether the large version of the provided icon should be used, whether sound should be played and the amount of seconds to wait before the balloon auto hides (The system minimum and maximum are 10 and 30 seconds). 

    #### __[C#] Example 4: Showing a notification with custom icon__
    {{region cs-radnotifyicon-balloon-notifications-5}}
        
        var icon = new System.Drawing.Icon("YourIconPath.ico");
        this.icon.ShowBalloonTip("Balloon Title", "Balloon Text", icon, true, false, 15);
    {{endregion}}

    #### __[VB.NET] Example 4: Showing a notification with custom icon__
    {{region vb-radnotifyicon-balloon-notifications-6}}
        
        Dim icon = New System.Drawing.Icon("YourIconPath.ico")
        Me.icon.ShowBalloonTip("Balloon Title", "Balloon Text", icon, True, False, 15)
    {{endregion}}

## Hide the Notification

You can manually hide the notification by invoking the __HideBalloonTip__ method.

#### __[C#] Example 5: Hide the notification__
{{region cs-radnotifyicon-balloon-notifications-7}}
    
    this.icon.HideBalloonTip();
{{endregion}}

#### __[VB.NET] Example 5: Hide the notification__
{{region vb-radnotifyicon-balloon-notifications-8}}
    
    Me.icon.HideBalloonTip()
{{endregion}}

## See Also 

* [Events]({%slug radnotifyicon-events%})
* [Tooltip]({%slug radnotifyicon-tooltip%})
* [Popup]({%slug radnotifyicon-popup%})
* [ContextMenu]({%slug radnotifyicon-contextmenu%})
