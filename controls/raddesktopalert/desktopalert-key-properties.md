---
title: Key Properties
page_title: Key Properties
description: This article lists the main properties exposed by the RadDesktopAlert control.
slug: raddesktopalert-features-key-properties
tags: properties,features,key,properties
published: True
position: 4
---

# Key Properties

The purpose of this help article is to show you the key properties of __RadDesktopAlert__ control. The topic includes the following properties:

* [Header](#header)
* [Content](#content)
* [ShowDuration](#showduration)
* [Icon](#icon)
* [IconColumnWidth](#iconcolumnwidth)
* [IconMargin](#iconmargin)
* [Command](#command)
* [CanAutoClose ](#canautoclose)
* [ShowCloseButton](#showclosebutton)
* [ShowMenuButton](#showmenubutton)
* [ShowInTaskSwitcher](#showintaskswitcher)

## Header

The __Header__ property is used to set the header content of __RadDesktopAlert__. The __Header__ is of type object, so by applying a custom __HeaderTemplate__ as well any desired content can be visualized.

#### __[C#] Example 1: Setting Header__
{{region cs-raddesktopalert-features-key-properties_0}}
	var alert = new RadDesktopAlert();
	alert.Header = "Mail Notification";
{{endregion}}

#### __[VB.NET] Example 1: Setting Header__
{{region vb-raddesktopalert-features-key-properties_0}}
	Dim alert = New RadDesktopAlert()
	alert.Header = "Mail Notification"
{{endregion}}

## Content

Using the __Content__ property the inner content of __RadDesktopAlert__ could easily be set. The __Content__ property is of type object, so any content can be visualized by applying a custom __ContentTemplate__. 

#### __[C#] Example 2: Setting Content__

{{region cs-raddesktopalert-features-key-properties_1}}
	var alert = new RadDesktopAlert();
	alert.Content = "Hello, Here are two things that we noticed today on our front-end meeting";
{{endregion}}

#### __[VB.NET] Example 2: Setting Content__

{{region vb-raddesktopalert-features-key-properties_1}}
	Dim alert = New RadDesktopAlert()
	alert.Content = "Hello, Here are two things that we noticed today on our front-end meeting"
{{endregion}}

## ShowDuration

The duration of the visualization of __RadDesktopAlert__ is determined by the __ShowDuration__ property of the control. It is of type integer and represents the amount of milliseconds after which the alert automatically closes. The default value of the property is 5000.

#### __[C#] Example 3: Setting ShowDuration__
{{region cs-raddesktopalert-features-key-properties_2}}
	var alert = new RadDesktopAlert();
	alert.ShowDuration = 3000;
{{endregion}}

#### __[VB.NET] Example 3: Setting ShowDuration__
{{region vb-raddesktopalert-features-key-properties_2}}
	Dim alert = New RadDesktopAlert()
	alert.ShowDuration = 3000
{{endregion}}

## Icon

In order to display an icon inside __RadDesktopAlert__ the __Icon__ property should be set. It is of type object, so any content can be visualized by applying a custom __IconTemplate__ as well. The following example demonstrates how to show the built in icon image of the currently used theme:

#### __[C#] Example 4: Setting Icon__
{{region cs-raddesktopalert-features-key-properties_3}}
	var alert = new RadDesktopAlert();
 	// the "DesktopAlertIcon" in the example below points to a Telerik's ImageSource resource defined in the XAML, similar to this: <ImageSource x:Key="DesktopAlertIcon">pack://application:,,,/Telerik.Windows.Controls.Navigation;component/Themes/Images/DesktopAlertIconFlatBlack.png</ImageSource>
 	ImageSource icon = Application.Current.FindResource("DesktopAlertIcon") as ImageSource;
	alert.Icon = new Image { Source = icon, Width = 48, Height = 48 };
{{endregion}}

#### __[VB.NET] Example 4: Setting Icon__
{{region vb-raddesktopalert-features-key-properties_3}}
	Dim alert = New RadDesktopAlert()
 	'the "DesktopAlertIcon" in the example below points to a Telerik's ImageSource resource defined in the XAML, similar to this: <ImageSource x:Key="DesktopAlertIcon">pack://application:,,,/Telerik.Windows.Controls.Navigation;component/Themes/Images/DesktopAlertIconFlatBlack.png</ImageSource>
  	Dim icon = TryCast(Application.Current.FindResource("DesktopAlertIcon"), ImageSource)
	alert.Icon = New Image() With
	{
	    .Source = icon,
	    .Width = 48,
	    .Height = 48
	}
{{endregion}}

## IconColumnWidth

Using the __IconColumnWidth__ property you could easily set the Width of the column that contains the icon. The default value is double.NaN, so the property needs to be set always to the needed value if an icon is used.

#### __[C#] Example 5: Setting IconColumnWidth__
{{region cs-raddesktopalert-features-key-properties_4}}
	var alert = new RadDesktopAlert();
	alert.IconColumnWidth = 75;
{{endregion}}

#### __[VB.NET] Example 5: Setting IconColumnWidth__
{{region vb-raddesktopalert-features-key-properties_4}}
	Dim alert = New RadDesktopAlert()
	alert.IconColumnWidth = 75
{{endregion}}

## IconMargin

The __IconMargin__ property is a specific property of __RadDesktopAlert__ that is used to set a Margin around the control's icon. By default there aren't any margins applied.
 
#### __[C#] Example 6: Setting IconMargin__
{{region cs-raddesktopalert-features-key-properties_5}}
	var alert = new RadDesktopAlert();
	alert.IconMargin = new Thickness(0, 0, 10, 10);
{{endregion}}

#### __[VB.NET] Example 6: Setting IconMargin__
{{region vb-raddesktopalert-features-key-properties_5}}
	Dim alert = New RadDesktopAlert()
	alert.IconMargin = New Thickness(0, 0, 10, 10)
{{endregion}}

## Command

__RadDesktopAlert__ provides you with a command property. This means you can bind the alert to a command that will be executed when it gets clicked.

#### __[C#] Example 7: Setting Command__
{{region cs-raddesktopalert-features-key-properties_6}}
	var alert = new RadDesktopAlert();
	alert.Command = new DelegateCommand(this.OnCommandExecuted);
{{endregion}}

#### __[VB.NET] Example 7: Setting Command__
{{region vb-raddesktopalert-features-key-properties_6}}
	Dim alert = New RadDesktopAlert()
	alert.Command = New DelegateCommand(Me.OnCommandExecuted)
{{endregion}}

## CanAutoClose

In order to prevent __RadDesktopAlert__ from auto closing you need to use the __CanAutoClose__ property introduced with Q3 2015 release version of UI for WPF. It is of type bool so it could either be set to True, False – the default value is true:

#### __[C#] Example 8: Setting CanAutoClose__
{{region cs-raddesktopalert-features-key-properties_7}}
	var alert = new RadDesktopAlert();
	alert.CanAutoClose = true;
{{endregion}}

#### __[VB.NET] Example 8: Setting CanAutoClose__
{{region vb-raddesktopalert-features-key-properties_7}}
	Dim alert = New RadDesktopAlert()
	alert.CanAutoClose = True
{{endregion}}

The __CanAutoClose__ property could also be set using the __DesktopAlertParameters__ that are passed to the __ShowAlert__ method of __RadDesktopAlertManager__:

#### __[C#] Example 9: Setting CanAutoClose using DesktopAlertParameters__
{{region cs-raddesktopalert-features-key-properties_8}}
	var manager = new RadDesktopAlertManager();
	manager.ShowAlert(new DesktopAlertParameters
	{
	    CanAutoClose = false,
	    Header = "Message",
	    Content = "A new message has arrived!"
	});
{{endregion}}

#### __[VB.NET] Example 9: Setting CanAutoClose using DesktopAlertParameters__
{{region vb-raddesktopalert-features-key-properties_8}}
	Dim manager = New RadDesktopAlertManager()
	manager.ShowAlert(New DesktopAlertParameters With
	{
	    .CanAutoClose = False,
	    .Header = "Message",
	    .Content = "A new message has arrived!"
	})
{{endregion}}

## ShowCloseButton

You could easily hide the close button of __RadDesktopAlert__ using the __ShowCloseButton__. By setting it to __False__ the button will get hide - be default it is  true. This property was introduced with Q3 2015 released version of UI for WPF:

#### __[C#] Example 10: Setting ShowCloseButton__
{{region cs-raddesktopalert-features-key-properties_9}}
	var alert = new RadDesktopAlert();
	alert.ShowCloseButton = false;
{{endregion}}

#### __[VB.NET] Example 10: Setting ShowCloseButton__
{{region vb-raddesktopalert-features-key-properties_9}}
	Dim alert = New RadDesktopAlert()
	alert.ShowCloseButton = False
{{endregion}}

## ShowMenuButton

In order to visualize the menu of __RadDesktopAlert__ you need to set the __ShowMenuButton__ property to true – by default it is set to false. By doing so a __DropDownButton__ will be visualized next to the close button and an empty menu with no items will be created. This property was introduced with Q3 2015 released version of UI for WPF:

#### __[C#] Example 11: Setting ShowMenuButton__

{{region cs-raddesktopalert-features-key-properties_10}}
	var alert = new RadDesktopAlert();
	alert.ShowMenuButton = false;
{{endregion}}

#### __[VB.NET] Example 11: Setting ShowMenuButton__

{{region vb-raddesktopalert-features-key-properties_10}}
	Dim alert = New RadDesktopAlert()
	alert.ShowMenuButton = False
{{endregion}}

## ShowInTaskSwitcher

By the default the __RadDesktopAlert__ window will appear in the TaskSwitcher (Alt+Tab menu). To hide it from this menu, you need to set the __ShowInTaskSwitcher__ property to false. The default value is __true__.

#### __[C#] Example 12: Setting ShowInTaskSwitcher__
{{region cs-raddesktopalert-features-key-properties_10}}
	var alert = new RadDesktopAlert();
	alert.ShowInTaskSwitcher = false;
{{endregion}}

#### __[VB.NET] Example 12: Setting ShowInTaskSwitcher__
{{region vb-raddesktopalert-features-key-properties_10}}
	Dim alert = New RadDesktopAlert()
	alert.ShowInTaskSwitcher = False
{{endregion}}

## See Also

 * [Overview]({%slug raddesktopalert-overview%})
 * [Getting Started]({%slug raddesktopalert-getting-started%})
