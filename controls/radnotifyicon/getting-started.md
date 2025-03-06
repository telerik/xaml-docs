---
title: Getting Started
page_title: Getting Started
description: This article will walk you through the creation of a sample application that contains a RadNotifyIcon control.
slug: radnotifyicon-getting-started
tags: getting,started,radnotifyicon
position: 2
---

# Getting Started with {{ site.framework_name }} NotifyIcon

This tutorial will walk you through the creation of a sample application that contains a __RadNotifyIcon__ control.
			
## Adding Telerik Assemblies Using NuGet

To use __RadNotifyIcon__ when working with NuGet packages, install the `Telerik.Windows.Controls.Navigation.for.Wpf.Xaml` package. The [package name may vary]({%slug nuget-available-packages%}) slightly based on the Telerik dlls set - [Xaml or NoXaml]({%slug xaml-vs-noxaml%})

Read more about NuGet installation in the [Installing UI for WPF from NuGet Package]({%slug nuget-installation%}) article.

>tip With the 2025 Q1 release, the Telerik UI for WPF has a new licensing mechanism. You can learn more about it [here]({%slug installing-license-key%}).

## Adding Assembly References Manually

If you are not using NuGet packages, you can add a reference to the following assemblies:

* __Telerik.Licensing.Runtime__
* __Telerik.Windows.Controls__
* __Telerik.Windows.Controls.Navigation__

You can find the required assemblies for each control from the suite in the [Controls Dependencies]({%slug installation-installing-controls-dependencies-wpf%}) help article.

## Defining RadNotifyIcon

__Example 1__ demonstrates how you can define a RadNotifyIcon in xaml. You have to point the RadNotifyIcon to an ".ico" file that will be shown in the taskbar notification area. 
You can either set the __TrayIconSource__ property which accepts an __ImageSource__/__string__ pointing to the file, or the __TrayIcon__ property, which accepts a __System.Drawing.Icon__ object. 

#### __[XAML] Example 1: Defining RadNotifyIcon__
{{region xaml-radnotifyicon-getting-started-0}}

    <telerik:RadNotifyIcon x:Name="icon" TrayIconSource="YourIconPath.ico" GuidItem="00000001-0002-0003-0004-000000000005" />
{{endregion}}

>important You should replace the placeholder __GuidItem__ with your own Guid. Make sure to create two separate Guids for building in __Debug__ and __Release__ mode and use the same ones for a given application. This will allow Windows to recognize the icon each time you show it in the tray. 

> Each time you use a new __GuidItem__, Windows will register a new icon. To learn how to clear the icon cache, you can check out the following thread: [How to remove old notification icons from the Windows 10 system tray](https://answers.microsoft.com/en-us/windows/forum/all/how-to-remove-old-notification-icons-from-the/c66892b4-51a9-44fa-853f-b17cdff5ed2f).

## Showing and Hiding the Icon

By default the icon will be displayed in the tray area once the application is started. If you want to manually show the icon, you can initially set its __ShowTrayIcon__ to __False__. __Example 3__ shows two options for showing and hiding the icon in code.

#### __[XAML] Example 2: Hiding the icon by default__
{{region xaml-radnotifyicon-getting-started-1}}

    <telerik:RadNotifyIcon x:Name="icon" ShowTrayIcon="False" />
{{endregion}}

#### __[C#] Example 3: Show/Hide the icon in code__
{{region cs-radnotifyicon-getting-started-2}}

    // Options for showing the icon
    this.icon.ShowTrayIcon = true;
    this.icon.AddIcon();


    // Options for hiding the icon
    this.icon.ShowTrayIcon = false;
    this.icon.RemoveIcon();
{{endregion}}

#### __[VB.NET] Example 3: Show/Hide the icon in code__
{{region vb-radnotifyicon-getting-started-3}}

    ' Options for showing the icon
    Me.icon.ShowTrayIcon = True
    Me.icon.AddIcon()


    ' Options for hiding the icon
    Me.icon.ShowTrayIcon = False
    Me.icon.RemoveIcon()
{{endregion}}

## Refreshing the Icon

The __RadNotifyIcon__ allows for refreshing the icon through the __UpdateIcon__ method.

#### __[C#] Example 4: Updating the icon__
{{region cs-radnotifyicon-getting-started-4}}

    this.icon.UpdateIcon();
{{endregion}}

#### __[VB.NET] Example 4: Updating the icon__
{{region vb-radnotifyicon-getting-started-5}}

    Me.icon.UpdateIcon()
{{endregion}}

## Interacting with the Icon

The __RadNotifyIcon__ supports displaying a popup, tooltip, context menu and balloon notifications. You can learn more about each feature in its respective article:

* [Tooltip]({%slug radnotifyicon-tooltip%})
* [Popup]({%slug radnotifyicon-popup%})
* [ContextMenu]({%slug radnotifyicon-contextmenu%})
* [Balloon Notifications]({%slug radnotifyicon-balloon-notifications%})

## GetUserNotificationState

The __RadNotifyIcon__ exposes the __GetUserNotificationState__ static method, which allows you to check the state of the computer for the current user to determine whether sending a notification is appropriate. 

#### __[C#] Example 5: Using the GetUserNotificationState method__
{{region cs-radnotifyicon-getting-started-6}}

    var state = RadNotifyIcon.GetUserNotificationState();

    if(state == UserNotificationState.AcceptsNotifications)
    {
        // send notification
    }
{{endregion}}

#### __[VB.NET] Example 5: Using the GetUserNotificationState method__
{{region vb-radnotifyicon-getting-started-7}}

    Dim state = RadNotifyIcon.GetUserNotificationState()

	If state Is UserNotificationState.AcceptsNotifications Then
		' send notification
	End If
{{endregion}}

## Setting a Theme

The controls from our suite support different themes. You can see how to apply a theme different than the default one in the [Setting a Theme]({%slug styling-apperance-implicit-styles-overview%}) help article.

>important Changing the theme using implicit styles will affect all controls that have styles defined in the merged resource dictionaries. This is applicable only for the controls in the scope in which the resources are merged. 

To change the theme, you can follow the steps below:

* Choose between the themes and add reference to the corresponding theme assembly (ex: **Telerik.Windows.Themes.Windows8.dll**). You can see the different themes applied in the **Theming** examples from our [WPF Controls Examples](https://demos.telerik.com/wpf/) application.

* Merge the ResourceDictionaries with the namespace required for the controls that you are using from the theme assembly. For the __RadNotifyIcon__, you will need to merge the following resources:

	* __Telerik.Windows.Controls__
	* __Telerik.Windows.Controls.Navigation__

__Example 6__ demonstrates how to merge the ResourceDictionaries so that they are applied globally for the entire application.

#### __[XAML] Example 6: Merge the ResourceDictionaries__  
{{region radnotifyicon--setting-theme-getting-started_8}}
	<Application.Resources>
		<ResourceDictionary>
			<ResourceDictionary.MergedDictionaries>
				<ResourceDictionary Source="/Telerik.Windows.Themes.Windows8;component/Themes/System.Windows.xaml"/>
				<ResourceDictionary Source="/Telerik.Windows.Themes.Windows8;component/Themes/Telerik.Windows.Controls.xaml"/>
				<ResourceDictionary Source="/Telerik.Windows.Themes.Windows8;component/Themes/Telerik.Windows.Controls.Navigation.xaml"/>
			</ResourceDictionary.MergedDictionaries>
		</ResourceDictionary>
	</Application.Resources>
{{endregion}}

>Alternatively, you can use the theme of the control via the {% if site.site_name == 'WPF' %}[StyleManager](https://docs.telerik.com/devtools/wpf/styling-and-appearance/stylemanager/common-styling-apperance-setting-theme-wpf){% else %}[StyleManager](https://docs.telerik.com/devtools/silverlight/styling-and-appearance/stylemanager/common-styling-apperance-setting-theme){% endif %}.

__Figure 3__ shows a __RadNotifyIcon__ with the **Windows8** theme applied.

#### __Figure 3: RadNotifyIcon with the Windows8 theme__
![radnotifyicon- with Windows8 theme](images/radnotifyicon-setting-theme.png)

{% if site.site_name == 'WPF' %}
## Telerik UI for WPF Learning Resources

* [Telerik UI for WPF NotifyIcon Component](https://www.telerik.com/products/wpf/notify-icon-control.aspx)
* [Getting Started with Telerik UI for WPF Components]({%slug getting-started-first-steps%})
* [Telerik UI for WPF Installation]({%slug installation-installing-which-file-do-i-need%})
* [Telerik UI for WPF and WinForms Integration]({%slug winforms-integration%})
* [Telerik UI for WPF Visual Studio Templates]({%slug visual-studio-templates%})
* [Setting a Theme with Telerik UI for WPF]({%slug styling-apperance-implicit-styles-overview%})
* [Telerik UI for WPF Virtual Classroom (Training Courses for Registered Users)](https://learn.telerik.com/learn/course/external/view/elearning/16/telerik-ui-for-wpf) 
* [Telerik UI for WPF License Agreement](https://www.telerik.com/purchase/license-agreement/wpf-dlw-s)
{% endif %}

## See Also 

* [Events]({%slug radnotifyicon-events%})
