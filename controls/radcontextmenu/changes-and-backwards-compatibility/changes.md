---
title: Changes
page_title: Changes
description: Changes
slug: radcontextmenu-changes
tags: changes
published: True
position: 0
---

# Changes

This article describes the release history of the control.

## Latest Release Notes

You can find out the latest release notes {% if site.site_name == 'WPF' %}[here](http://www.telerik.com/products/wpf/whats-new/release-history.aspx){% endif %}{% if site.site_name == 'Silverlight' %}[here](http://www.telerik.com/products/silverlight/whats-new/release-history.aspx){% endif %}.        

## Q3 2013

### What's Fixed

* Visual Studio's designer automatically switches to design view when RadContextMenu is used inside RadDropDownButton

## Q2 2013

### What's new

{% if site.site_name == 'WPF' %}
* Created new RadMenuGroupItem and RadMenuSeparatorItem.

* Added handler for PopupCommands.Close and PopupCommands.CloseAll commands.

* Added integration between RadDropDownButton/RadSplitButton and RadContextMenu.

* Implemented scrolling in RadContextMenu.

* Implemented ItemContainerTemplateSelector for MenuBase and RadMenuItem.

* Added DropDownWidth and DropDownHeight properties to RadMenuItem.

* Added InputGestureText property to RadMenuItem.
{% endif %}

{% if site.site_name == 'Silverlight' %}
* Created new RadMenuGroupItem and RadMenuSeparatorItem.

* Added handler for PopupCommands.Close and PopupCommands.CloseAll commands.

* Added integration between RadDropDownButton/RadSplitButton and RadContextMenu.

* Implemented scrolling in RadContextMenu.

* Implemented ItemContainerTemplateSelector for MenuBase and RadMenuItem.

* Added DropDownWidth and DropDownHeight properties to RadMenuItem.
{% endif %}

### What's fixed

{% if site.site_name == 'WPF' %}
* RadContextMenu is not closed when the ItemsSource is changed on ItemClick.                  

* When you set a Windows8Touch Theme and then change it at runtime the FontSize is not changed correctly.                  

* In most of the themes when you set Background property of a RadMenuItem, it is applied only on the Icon area.                  

* In Windows8Touch Theme submenus do not have vertical border for the icon.                  

* SubMenu stays open when you click over Separator in parent RadMenuItem.                  

* RadMenuItem doesn't receive click in some cases when the template is changed.                  

* Image put as an Icon of RadMenuItem is stretched in Windows8 theme, while in OfficeBlack (and other themes) it isn't.
{% endif %}

{% if site.site_name == 'Silverlight' %}
* RadContextMenu is not closed when the ItemsSource is changed on ItemClick.

* In OOB application when you create a new Window, you are unable to open RadContextMenu in the MainPage.

* In most of the themes when you set Background property of a RadMenuItem, it is applied only on the Icon area.

* In Windows8Touch Theme submenus do not have vertical border for the icon.

* SubMenu stays open when you click over Separator in parent RadMenuItem.

* RadMenuItem doesn't receive click in some cases when the template is changed.

* Image put as an Icon of RadMenuItem is stretched in Windows8 theme, while in OfficeBlack (and other themes) it isn't.
{% endif %}

## Q1 2012

### What's New

* One instance of RadContextMenu can now be attached on multiple elements

* When RadContextMenu is attached on multiple elements and opened with IsOpen=true then PlacementTarget must be specified

* RadContextMenu and RadMenu will close on LeftAlt, RightAlt or F10 key down (WPF)

### What's Fixed

* GetClickedElements now works correctly when browser is zoomed

* Placemet is now correct when browser is zoomed

* Placemet is now correct when FlowDirection is RightToLeft

* RadContextMenu now shows in the correct window when using Silverlight 5 OOB multiple windows

* When SubMenu or RadContextMenu is opened with keyboard (or with IsOpen=true) and mouse appears over RadMenuItem then this RadMenuItem will not be focused/highlighted until mouse move
