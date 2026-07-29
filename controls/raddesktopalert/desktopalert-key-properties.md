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

__Example 1: Setting Header__
<snippet id='raddesktopalert-desktopalert-key-properties-example_1_setting_header-cs' />

<snippet id='raddesktopalert-desktopalert-key-properties-example_1_setting_header-vb' />


## Content

Using the __Content__ property the inner content of __RadDesktopAlert__ could easily be set. The __Content__ property is of type object, so any content can be visualized by applying a custom __ContentTemplate__. 

__Example 2: Setting Content__

<snippet id='raddesktopalert-desktopalert-key-properties-example_2_setting_content-cs' />

<snippet id='raddesktopalert-desktopalert-key-properties-example_2_setting_content-vb' />


## ShowDuration

The duration of the visualization of __RadDesktopAlert__ is determined by the __ShowDuration__ property of the control. It is of type integer and represents the amount of milliseconds after which the alert automatically closes. The default value of the property is 5000.

__Example 3: Setting ShowDuration__
<snippet id='raddesktopalert-desktopalert-key-properties-example_3_setting_showduration-cs' />

<snippet id='raddesktopalert-desktopalert-key-properties-example_3_setting_showduration-vb' />


## Icon

In order to display an icon inside __RadDesktopAlert__ the __Icon__ property should be set. It is of type object, so any content can be visualized by applying a custom __IconTemplate__ as well. The following example demonstrates how to show the built in icon image of the currently used theme:

__Example 4: Setting Icon__
<snippet id='raddesktopalert-desktopalert-key-properties-example_4_setting_icon-cs' />

<snippet id='raddesktopalert-desktopalert-key-properties-example_4_setting_icon-vb' />


## IconColumnWidth

Using the __IconColumnWidth__ property you could easily set the Width of the column that contains the icon. The default value is double.NaN, so the property needs to be set always to the needed value if an icon is used.

__Example 5: Setting IconColumnWidth__
<snippet id='raddesktopalert-desktopalert-key-properties-example_5_setting_iconcolumnwidth-cs' />

<snippet id='raddesktopalert-desktopalert-key-properties-example_5_setting_iconcolumnwidth-vb' />


## IconMargin

The __IconMargin__ property is a specific property of __RadDesktopAlert__ that is used to set a Margin around the control's icon. By default there aren't any margins applied.
 
__Example 6: Setting IconMargin__
<snippet id='raddesktopalert-desktopalert-key-properties-example_6_setting_iconmargin-cs' />

<snippet id='raddesktopalert-desktopalert-key-properties-example_6_setting_iconmargin-vb' />


## Command

__RadDesktopAlert__ provides you with a command property. This means you can bind the alert to a command that will be executed when it gets clicked.

__Example 7: Setting Command__
<snippet id='raddesktopalert-desktopalert-key-properties-example_7_setting_command-cs' />

<snippet id='raddesktopalert-desktopalert-key-properties-example_7_setting_command-vb' />


## CanAutoClose

In order to prevent __RadDesktopAlert__ from auto closing you need to use the __CanAutoClose__ property introduced with Q3 2015 release version of UI for WPF. It is of type bool so it could either be set to True, False – the default value is true:

__Example 8: Setting CanAutoClose__
<snippet id='raddesktopalert-desktopalert-key-properties-example_8_setting_canautoclose-cs' />

<snippet id='raddesktopalert-desktopalert-key-properties-example_8_setting_canautoclose-vb' />


The __CanAutoClose__ property could also be set using the __DesktopAlertParameters__ that are passed to the __ShowAlert__ method of __RadDesktopAlertManager__:

__Example 9: Setting CanAutoClose using DesktopAlertParameters__
<snippet id='raddesktopalert-desktopalert-key-properties-example_9_setting_canautoclose_using_desktopalertparameters-cs' />

<snippet id='raddesktopalert-desktopalert-key-properties-example_9_setting_canautoclose_using_desktopalertparameters-vb' />


## ShowCloseButton

You could easily hide the close button of __RadDesktopAlert__ using the __ShowCloseButton__. By setting it to __False__ the button will get hide - be default it is  true. This property was introduced with Q3 2015 released version of UI for WPF:

__Example 10: Setting ShowCloseButton__
<snippet id='raddesktopalert-desktopalert-key-properties-example_10_setting_showclosebutton-cs' />

<snippet id='raddesktopalert-desktopalert-key-properties-example_10_setting_showclosebutton-vb' />


## ShowMenuButton

In order to visualize the menu of __RadDesktopAlert__ you need to set the __ShowMenuButton__ property to true – by default it is set to false. By doing so a __DropDownButton__ will be visualized next to the close button and an empty menu with no items will be created. This property was introduced with Q3 2015 released version of UI for WPF:

__Example 11: Setting ShowMenuButton__

<snippet id='raddesktopalert-desktopalert-key-properties-example_11_setting_showmenubutton-cs' />

<snippet id='raddesktopalert-desktopalert-key-properties-example_11_setting_showmenubutton-vb' />


## ShowInTaskSwitcher

By the default the __RadDesktopAlert__ window will appear in the TaskSwitcher (Alt+Tab menu). To hide it from this menu, you need to set the __ShowInTaskSwitcher__ property to false. The default value is __true__.

__Example 12: Setting ShowInTaskSwitcher__
<snippet id='raddesktopalert-desktopalert-key-properties-example_12_setting_showintaskswitcher-cs' />

<snippet id='raddesktopalert-desktopalert-key-properties-example_12_setting_showintaskswitcher-vb' />


## See Also

 * [Overview]({%slug raddesktopalert-overview%})
 * [Getting Started]({%slug raddesktopalert-getting-started%})
